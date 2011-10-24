﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Wares;
using Compas.Helpers;

namespace Compas.AdminUI.Wares.Category
{
    public partial class CategoryData : Form
    {
        string mode;
        List<ItemIntValue> items = new List<ItemIntValue>();

        int? id;
        ContextManager manager;
        private void Fill()
        {
            WareCategoriesLogic cl = new WareCategoriesLogic(manager);
            FillCategoriesHierarchy(null, "");
            CategoriesCB.DataSource = items;
            if (mode == "edit")
            {
                WareCategory category = cl.Get(Convert.ToInt32(id));
                if (category != null)
                {
                    NameTB.Text = category.Name;
                    foreach (ItemIntValue i in items)
                    {
                        if (category.ParentCategoryID == i.ID)
                        {
                            CategoriesCB.SelectedItem = i;
                        }
                        
                    }
                }
            }

            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category">батьківська категорія</param>
        private void FillCategoriesHierarchy(WareCategory category, string prefix)
        {
            if (items.Count == 0)
            {
                ItemIntValue none = new ItemIntValue();
                
                none.Name =  " - не вибрано -";
                items.Add(none);
            }
            WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);
            List<WareCategory> categories = new List<WareCategory>();
            if(category == null)
                categories = categoriesLogic.GetAllRoot();
            else
                categories = categoriesLogic.GetAll(category.ID);
            
            foreach (WareCategory a in categories)
            {
                //TreeNode node = new TreeNode(;
                //node.Text = a.Name;
                //node.
                ItemIntValue item = new ItemIntValue();
                item.ID = a.ID;
                item.Name = prefix + a.Name;
                items.Add(item);

                //CategoriesTV.Nodes.Add(a.ID.ToString(), a.Name);
                
                FillCategoriesHierarchy(a, prefix+@"   ");
            }
            
            
        }

        public CategoryData(string _mode, int? _id)
        {
            
            InitializeComponent();
            
            manager = new ContextManager();
            CategoriesCB.DisplayMember = "Name";
            CategoriesCB.ValueMember = "ID";
            mode = _mode;
            
            id = _id;
            
            
                Fill();
            
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            WareCategoriesLogic cl = new WareCategoriesLogic(manager);
            int? parentCategoryId = null;
            if (CategoriesCB.SelectedValue != null & CategoriesCB.SelectedIndex > 0)
            {
                parentCategoryId = Convert.ToInt32(((ItemIntValue)CategoriesCB.SelectedItem).ID);
            }
                    

            if (mode == "new")
            {               
                
                cl.Create(NameTB.Text, parentCategoryId);
            }
            if (mode == "edit")
            {
                cl.Update(Convert.ToInt32(id), NameTB.Text, parentCategoryId);
            }
            manager.Save();
            
            Fill();
            this.Close();
        }

        private void EnterpriseData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

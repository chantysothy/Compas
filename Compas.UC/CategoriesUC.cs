using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Helpers;

namespace Compas.UC
{
    public partial class CategoriesUC : UserControl
    {
        ContextManager manager;

        public event EventHandler SelectedCategoryChanged;


        public int? SelectedCategoryID
        {
            get
            {
                int? result = null;
                if (CategoriesTV.SelectedNode != null)
                {
                    result = Convert.ToInt32(CategoriesTV.SelectedNode.Tag);
                }
                return result;
            }
        }

        public void ExpandAll()
        {
            CategoriesTV.ExpandAll();
        }


        public void ScrollUp()
        {
            if (CategoriesTV.TopNode.PrevNode != null)
                CategoriesTV.TopNode = CategoriesTV.TopNode.PrevNode;
            else
                if (CategoriesTV.TopNode.Parent != null)
                    CategoriesTV.TopNode = CategoriesTV.TopNode.Parent;
        }

        public void ScrollDown()
        {
            ScrollNode(CategoriesTV.TopNode);
        }
        private void ScrollNode(TreeNode node)
        {
            if(CategoriesTV.TopNode.NextNode != null)
                CategoriesTV.TopNode = node.NextNode;
            else
                CategoriesTV.TopNode = node;
            CategoriesTV.Refresh();
            System.Threading.Thread.Sleep(50);
            if (node.IsExpanded)
            {
                foreach (TreeNode subNode in node.Nodes)
                    ScrollNode(subNode);
            }
        }
        

        public void Fill(int? ParentCategoryID, TreeNode ParentNode)
        {
            Logic.Wares.WareCategoriesLogic categoriesLogic = new Logic.Wares.WareCategoriesLogic(manager);
            List<WareCategory> categories = new List<WareCategory>();
            if (ParentCategoryID == null)
                categories = categoriesLogic.GetAllRoot();
            else
                categories = categoriesLogic.GetAll(Convert.ToInt32(ParentCategoryID));

            foreach (WareCategory category in categories)
            {
                TreeNode node = new TreeNode();
                node.Name = category.Name;
                node.Text = category.Name;
                node.Tag = category.ID.ToString();

                //if (ParentCategoryID == null)
                //{
                //    CategoriesTV.Nodes.Add(node);
                //}
                //else
                {
                    ParentNode.Nodes.Add(node);
                }
                Fill(category.ID, node);
            }
        }

        public void Fill()
        {
            CategoriesTV.Nodes.Clear();
            TreeNode node = new TreeNode();
            node.Name = "ALL";
            node.Text = "Всі";
            node.Tag = "-1";
            CategoriesTV.Nodes.Add(node);

            manager = new ContextManager();
            Fill(null, node);
        }

        public CategoriesUC()
        {
            InitializeComponent();
            
            CategoriesTV.AfterSelect += this.HandleSelectedCategoryChanged;
        }

        private void CategoriesTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void HandleSelectedCategoryChanged(object sender, EventArgs e)
        {
            // we'll explain this in a minute
            this.OnSelectedCategoryChanged(EventArgs.Empty);
        }

        protected virtual void OnSelectedCategoryChanged(EventArgs e)
        {
            EventHandler handler = this.SelectedCategoryChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}

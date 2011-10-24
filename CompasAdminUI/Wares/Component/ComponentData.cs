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

namespace Compas.AdminUI.Wares
{
    public partial class ComponentData : Form
    {
        string mode;

        int? id;
        ContextManager manager;
        private List<string> codesList = new List<string>();
        private List<string> codesListForDelete = new List<string>();
        private void FillManufacturers()
        {
            ItemIntValue none = new ItemIntValue();
            none.ID = -1;
            none.Name = " - не вибрано - ";
            WareManufacturersLogic manufacturers = new WareManufacturersLogic(manager);
            List<ItemIntValue> items1 = new List<ItemIntValue>();
            items1.Clear();
            items1.Add(none);
            foreach (var a in manufacturers.GetAll().OrderBy(a => a.Name))
            {
                ItemIntValue i = new ItemIntValue();
                i.ID = a.ID;
                i.Name = a.Name;
                items1.Add(i);
            }

            ManufacturersCB.DataSource = items1;
            ManufacturersCB.ValueMember = "ID";
            ManufacturersCB.DisplayMember = "Name";
            ManufacturersCB.Update();
        }

        private void FillCategories()
        {
            ItemIntValue none = new ItemIntValue();
            none.ID = -1;
            none.Name = " - не вибрано - ";
            List<ItemIntValue> items0 = new List<ItemIntValue>();

            WareCategoriesLogic categories = new WareCategoriesLogic(manager);
            items0.Clear();
            //items0.Add(none);
            foreach (var a in categories.GetCategoriesHierarchy().OrderBy(a => a.Name))
            {
                ItemIntValue i = new ItemIntValue();
                i.ID = a.ID;
                i.Name = a.Name;
                items0.Add(i);
            }
            CategoriesCB.DataSource = items0;
            CategoriesCB.ValueMember = "ID";
            CategoriesCB.DisplayMember = "Name";
            CategoriesCB.Update();
        }

        private void FillUnits()
        {
            ItemIntValue none = new ItemIntValue();
            none.ID = -1;
            none.Name = " - не вибрано - ";

            WareUnitsLogic units = new WareUnitsLogic(manager);
            List<ItemIntValue> items2 = new List<ItemIntValue>();
            items2.Clear();
            items2.Add(none);
            foreach (var a in units.GetAll().OrderBy(a => a.Name))
            {
                ItemIntValue i = new ItemIntValue();
                i.ID = a.ID;
                i.Name = a.Name;
                items2.Add(i);
            }
            UnitsCB.DataSource = items2;
            UnitsCB.ValueMember = "ID";
            UnitsCB.DisplayMember = "Name";
            UnitsCB.Update();

            
        }

        private void FillSecondaryUnits()
        {
            ItemIntValue none = new ItemIntValue();
            none.ID = -1;
            none.Name = " - не вибрано - ";

            WareUnitsLogic units = new WareUnitsLogic(manager);
            List<ItemIntValue> items2 = new List<ItemIntValue>();
            items2.Clear();
            items2.Add(none);
            foreach (var a in units.GetAll().OrderBy(a => a.Name))
            {
                ItemIntValue i = new ItemIntValue();
                i.ID = a.ID;
                i.Name = a.Name;
                items2.Add(i);
            }
           

            SecondaryUnitsCB.DataSource = items2;
            SecondaryUnitsCB.ValueMember = "ID";
            SecondaryUnitsCB.DisplayMember = "Name";
            SecondaryUnitsCB.Update();
        }

        private void FillCodes()
        {
            WareCodesLogic codes = new WareCodesLogic(manager);
            

            foreach (var a in codes.GetAll(Convert.ToInt32(id)))
            {                
                codesList.Add(a.Code);
            }

            CodesGV.DataSource = (from c in codesList
                                 select new { Code = c }).ToList();
            Update();
        }

        private void Fill()
        {
            ItemIntValue none = new ItemIntValue();
            none.ID = -1;
            none.Name = " - не вибрано - ";

            FillCategories();

            FillManufacturers();

            FillUnits();

            FillSecondaryUnits();

            FillCodes();
            
            if (mode == "edit")
            {
                WaresLogic wares = new WaresLogic(manager);
                

                var ware = wares.Get(Convert.ToInt32(id));
                if (ware != null)
                {
                    NameTB.Text = ware.Name;
                    int? categoryId = ware.CategoryID;
                    int? manufacturerId = ware.ManufacturerID;
                    int? unitId = ware.UnitID;
                    int? secondaryUnitId = ware.SecondaryUnitID;
                    decimal? secondaryUnitQuantity = ware.SecondaryUnitQuantity;
                    if (secondaryUnitQuantity != null)
                        SecondaryQuantityNUD.Value = Convert.ToDecimal(secondaryUnitQuantity);

                    if (categoryId != null)
                    { 
                       int i = 0;
                       foreach (ItemIntValue a in CategoriesCB.Items)
                       {
                           if (a.ID == categoryId)
                           {                               
                               CategoriesCB.SelectedIndex = i;
                           }
                           i++;
                       }
                    }

                    if (unitId != null)
                    {
                        int i = 0;
                        foreach (ItemIntValue a in UnitsCB.Items)
                        {
                            if (a.ID == unitId)
                            {
                                UnitsCB.SelectedIndex = i;
                            }
                            i++;
                        }
                    }

                    if (secondaryUnitId != null)
                    {
                        int i = 0;
                        foreach (ItemIntValue a in SecondaryUnitsCB.Items)
                        {
                            if (a.ID == secondaryUnitId)
                            {
                                SecondaryUnitsCB.SelectedIndex = i;
                            }
                            i++;
                        }
                    }

                    if (manufacturerId != null)
                    {
                        int i = 0;
                        foreach (ItemIntValue a in ManufacturersCB.Items)
                        {
                            if (a.ID == manufacturerId)
                            {
                                ManufacturersCB.SelectedIndex = i;
                            }
                            i++;
                        }
                    }
                }
            }
            
        }

        public ComponentData(string _mode, int? _id)
        {

            InitializeComponent();
            SecondaryQuantityNUD.Text = "";
            manager = new ContextManager();
            mode = _mode;
            id = _id;
            Fill();

        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            WaresLogic wares = new WaresLogic(manager);
            WareCodesLogic codes = new WareCodesLogic(manager);
            string name = NameTB.Text;
            int? categoryId = null;
            if (CategoriesCB.SelectedIndex > 0)
                categoryId = Convert.ToInt32(CategoriesCB.SelectedValue);
            int? manufacturerId = null;
            if (ManufacturersCB.SelectedIndex > 0)
                manufacturerId = Convert.ToInt32(ManufacturersCB.SelectedValue);
            int unitId = Convert.ToInt32(UnitsCB.SelectedValue);
            int? secondaryUnitId = null;
            decimal? secondaryUnitQuantity = null;
            if (SecondaryUnitsCB.SelectedIndex > 0)
            {
                secondaryUnitId = Convert.ToInt32(SecondaryUnitsCB.SelectedValue);
                secondaryUnitQuantity = Convert.ToDecimal(SecondaryQuantityNUD.Value);
            }
            Model.Ware ware = null;
            if (mode == "new")
            {
                ware = wares.Create(NameTB.Text, unitId, 0, manufacturerId, categoryId, secondaryUnitId, secondaryUnitQuantity);
            }
            if (mode == "edit")
            {
                ware = wares.Update(Convert.ToInt32(id), NameTB.Text, unitId, manufacturerId, categoryId, secondaryUnitId, secondaryUnitQuantity);
                foreach (string code in codesListForDelete)
                {

                    codes.Delete(Convert.ToInt32(id), code);

                }
            }
            foreach (string code in codesList)
            {

                codes.Create(ware, code);

            }





            manager.Save();

            this.Close();
        }

        private void EnterpriseData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddManufacturerBt_Click(object sender, EventArgs e)
        {
            Manufacturer.ManufacturerData form = new Manufacturer.ManufacturerData("new", null);
            form.ShowDialog();
            FillManufacturers();
        }

        private void AddCategoryBt_Click(object sender, EventArgs e)
        {
            Category.CategoryData form = new Category.CategoryData("new", null);
            form.ShowDialog();
            FillCategories();
        }

        private void AddUnitBt_Click(object sender, EventArgs e)
        {
            Unit.UnitData form = new Unit.UnitData("new", null);
            form.ShowDialog();
            FillUnits();
        }

        private void AddCodeBt_Click(object sender, EventArgs e)
        {
            codesList.Add(CodeTB.Text);
            codesListForDelete.Remove(CodeTB.Text);
            CodeTB.Text = "";
            
            CodesGV.DataSource = (from c in codesList
                                  select new { Code = c }).ToList();
            Update();
        }

        private void DeleteCodeBt_Click(object sender, EventArgs e)
        {
            codesList.Remove(CodesGV.SelectedRows[0].Cells[0].Value.ToString());
            codesListForDelete.Add(CodesGV.SelectedRows[0].Cells[0].Value.ToString());
            
            CodesGV.DataSource = (from c in codesList
                                 select new { Code = c }).ToList();
            Update();
        }

       
    }
}

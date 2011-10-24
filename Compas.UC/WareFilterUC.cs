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
using Compas.Logic.Wares;

using Compas.Helpers;

namespace Compas.UC
{
    public partial class WareFilterUC : UserControl
    {
        ContextManager manager;
        int? fieldWidth = null;
        public int? ManufacturerID
        {
            get
            {
                int? result = null;
                if (ManufacturersCB.SelectedIndex > 0)
                {
                    result = Convert.ToInt32(ManufacturersCB.SelectedValue);
                }
                return result;
            }
        }

        public int? CategoryID
        {
            get
            {
                int? result = null;
                if (CategoriesCB.SelectedIndex > 0)
                {
                    result = Convert.ToInt32(CategoriesCB.SelectedValue);
                }
                return result;
            }
        }

        public int? UnitID
        {
            get
            {
                int? result = null;
                if (UnitsCB.SelectedIndex > 0)
                {
                    result = Convert.ToInt32(UnitsCB.SelectedValue);
                }
                return result;
            }
        }

        public int? FieldWidth
        {
            get
            {
                return fieldWidth;
            }
            set
            {
                fieldWidth = value;
            }
        }

        public void SetFieldsWidth(int fieldWidth)
        {
            ManufacturersCB.Width = Convert.ToInt32(fieldWidth);
            UnitsCB.Width = Convert.ToInt32(fieldWidth);
            CategoriesCB.Width = Convert.ToInt32(fieldWidth);
        }
        //public string WareName
        //{
        //    get
        //    {
        //        string result = null;
        //        if (NameTB.Text.Length > 0)
        //        {
        //            result = NameTB.Text;
        //        }
        //        return result;
        //    }
        //}

        public void Fill()
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
            //ManufacturersCB.DataSource = manufacturers.GetAll();
            ManufacturersCB.DataSource = items1;
            ManufacturersCB.ValueMember = "ID";
            ManufacturersCB.DisplayMember = "Name";
            ManufacturersCB.Update();

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

        public WareFilterUC()
        {
            InitializeComponent();
            manager = new ContextManager();
            if (fieldWidth != null)
            {
                ManufacturersCB.Width = Convert.ToInt32(fieldWidth);
                UnitsCB.Width = Convert.ToInt32(fieldWidth);
                CategoriesCB.Width = Convert.ToInt32(fieldWidth);
            }
        }

    }
}

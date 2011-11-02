using System;
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

namespace Compas.AdminUI.Wares.Ware
{
    public partial class WareComponentDataSimple : Form
    {
        string mode;
        bool columnsCreated = false;
        int? id;
        ContextManager manager;
        private void Fill()
        {
            

            if (mode == "edit")
            {
                WaresLogic waresLogic = new WaresLogic(manager);
                Model.Ware ware = waresLogic.Get(Convert.ToInt32(id));
                WareNameL.Text = ware.Name;               
               
            }

        }
        SortableBindingList<WareView> view;


        private void FillComponentWareUnits(int ComponentWareID)
        {
            //WaresLogic waresLogic = new WaresLogic(manager);
            //Compas.Model.Ware ware = waresLogic.Get(Convert.ToInt32(ComponentWareID));
            //UnitsRG.Properties.Items.Clear();
            //if (ware != null)
            //{ 
                
            //    DevExpress.XtraEditors.Controls.RadioGroupItem item0 = new DevExpress.XtraEditors.Controls.RadioGroupItem(ware.UnitID, ware.WareUnit.Name);
            //    UnitsRG.Properties.Items.Add(item0);
            //    UnitsRG.SelectedIndex = 0;
            //    if(ware.SecondaryUnitID != null)
            //    {
            //        DevExpress.XtraEditors.Controls.RadioGroupItem item1 = new DevExpress.XtraEditors.Controls.RadioGroupItem(ware.SecondaryUnitID, ware.WareUnit1.Name);
            //        UnitsRG.Properties.Items.Add(item1);
            //    }
            //}
        }

        private void FillComponentWares()
        {
            
            ContextManager manager0 = new ContextManager();
            WareComponentsLogic wareComponentsLogic = new WareComponentsLogic(manager0);
            WareComponentsGV.AutoGenerateColumns = false;
            List<WareComponentView> components = wareComponentsLogic.GetAllView(Convert.ToInt32(id));
            WareComponentsGV.ClearSelection();
            //WareComponentsGV.Rows.Clear();
            WareComponentsGV.DataSource = null;
            
            WareComponentsGV.Rows.Clear();
            SortableBindingList<WareComponentView> view = new SortableBindingList<WareComponentView>(components);

            WareComponentsGV.DataSource = view;

        }

        

        



        public WareComponentDataSimple(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            //FillWares();
            
            FillComponentWares();
            wareSelectorUC1.Init(_mode); 
            //wareFilterUC1.Fill();
            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            //WareUnitsLogic units = new WareUnitsLogic(manager);

            if (mode == "new")
            {
                //units.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                //units.Update(Convert.ToInt32(id), NameTB.Text);
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

        private void WareLUE_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CodeTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
           
        }

        private void AddComponentBt_Click(object sender, EventArgs e)
        {
            int wareId = Convert.ToInt32(id);
            int componentWareId = Convert.ToInt32(wareSelectorUC1.WareID);
            decimal unitQuantity = 0;
            decimal secondaryUnitQuantity = 0;
           
                unitQuantity = Convert.ToDecimal(UnitQuantityNUD.Value);
            //if (UnitsRG.Properties.Items.Count == 1)
            //{
            //    unitQuantity = Convert.ToDecimal(UnitQuantityTB.EditValue);
            //}
            //if (UnitsRG.Properties.Items.Count == 2)
            //{
            //    if(UnitsRG.SelectedIndex == 0)
            //        unitQuantity = Convert.ToDecimal(UnitQuantityTB.EditValue);
            //    if (UnitsRG.SelectedIndex == 1)
            //        unitQuantity = Convert.ToDecimal(UnitQuantityTB.EditValue);
            //}
            
            WareComponentsLogic wareComponentsLogic = new WareComponentsLogic(manager);
            wareComponentsLogic.Create(wareId, componentWareId, unitQuantity, secondaryUnitQuantity);
            manager.Save();
            FillComponentWares();
        }

        private void DeleteComponentBt_Click(object sender, EventArgs e)
        {
            if (WareComponentsGV.SelectedRows.Count > 0)
            {
                int wareComponentId = Convert.ToInt32(WareComponentsGV.SelectedRows[0].Cells["WareComponentID"].Value);
                WareComponentsLogic wareComponentsLogic = new WareComponentsLogic(manager);
                wareComponentsLogic.Delete(wareComponentId);
                manager.Save();
                manager.CloseContext();
                manager = new ContextManager();
                FillComponentWares();
            }
        }

        private void UnitQuantityTB_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void SecondaryUnitQuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void WareLUE_EditValueChanged(object sender, EventArgs e)
        {
            //if(WareLUE.EditValue != null)
            // FillComponentWareUnits(Convert.ToInt32(WareLUE.EditValue));
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wareSelectorUC1_SelectedWareChanged(object sender, EventArgs e)
        {
            if (wareSelectorUC1.WareID != null)
                AddComponentBt.Enabled = true;
            else
                AddComponentBt.Enabled = false;
        }

        

       
    }
}

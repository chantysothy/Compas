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
using Compas.Logic.Staff;
using Compas.Logic.Documents;
using Compas.Helpers;

namespace Compas.AdminUI.Wares.Remain
{

   
    public partial class RemainsList : Form
    {
        
        int StructureObjectId;
        SortableBindingList<WareView> view;
        ContextManager manager;

        private void Fill()
        {
           
            manager = new ContextManager();
            WareRemainsLogic remains = new WareRemainsLogic(manager);
            DataGV.AutoGenerateColumns = false;
            int? structureObjectId = null;
            int? wareCategoryId = null;
            int? wareId = null;
            string wareCode = "";
            DateTime? startDate = null;
            DateTime? endDate = null;


            structureObjectId = universalFilter1.StructureObjectID;
            wareCategoryId = universalFilter1.WareCategoryID;
            wareId = universalFilter1.WareID;
            startDate = universalFilter1.StartDate;
            endDate = universalFilter1.EndDate;

            
            List<RemainView> result = remains.GetAllView(structureObjectId, wareId, startDate, endDate, wareCategoryId);
            DataGV.DataSource = result.OrderByDescending(a=>a.StartDate).ToList();
            DataGV.Update();

        }


        
        
        

        


        public RemainsList()
        {
            InitializeComponent();
           
           
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            if (allowed == true)
            {
                universalFilter1.Fill();
                Fill();
               
               
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");
                this.Close();
            }

        }

        private void NewSB_Click(object sender, EventArgs e)
        {

            Wares.Remain.RemainData form = new Wares.Remain.RemainData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Wares.Remain.RemainData form = new Wares.Remain.RemainData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            WareRemainsLogic remains = new WareRemainsLogic(manager);
            remains.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void RefreshSB_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void RecalculateSB_Click(object sender, EventArgs e)
        {
            WareRemainsLogic remains = new WareRemainsLogic(manager);
            if (universalFilter1.StartDate != null)
            {
                DialogResult result = MessageBox.Show(this, "Виконати перерахунок залишків починаючи з " + universalFilter1.StartDate.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    remains.Recalculate(Convert.ToDateTime(universalFilter1.StartDate));
                    manager.Save();

                    Fill();
                }
            }
            else
            {
                MessageBox.Show("Не задана початкова дата, перерахунок НЕ виконано");
            }
        }

        private void ApplyFilterBt_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void WareCodeTE_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void WareCodeTE_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}

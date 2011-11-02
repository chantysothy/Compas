using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Logic;
using Compas.Logic.Wares;
using Compas.Logic.Staff;
using Compas.Helpers;
using Compas.Model;

namespace Compas.AdminUI.Wares.Ware
{
    public partial class WareMinQuantity : Form
    {
        private int wareId;
        private CompasDataContext context;
        private ContextManager manager;

        public void FillWare()
        {
           
            WaresLogic waresLogic = new WaresLogic(manager);
            Compas.Model.Ware ware = waresLogic.Get(wareId);
            WareNameL.Text = ware.Name;
        }

        public void FillStructureObjects()
        {
            Logic.Staff.StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            StructureObjectsCB.DisplayMember = "Name";
            StructureObjectsCB.ValueMember = "ID";
            StructureObjectsCB.DataSource = structureObjectsLogic.GetHeirarchyView();

        }

        public void Fill()
        {
            FillWare();
            FillStructureObjects();
        }

        public WareMinQuantity(int WareID)
        {            
            InitializeComponent();
            manager = new ContextManager();
            context = manager.Context;
            wareId = WareID;
            Fill();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

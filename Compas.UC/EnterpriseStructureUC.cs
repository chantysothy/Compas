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
using Compas.Logic.Staff;
using Compas.Helpers;

namespace Compas.UC
{
    public partial class EnterpriseStructureUC : UserControl
    {
        ContextManager manager;

       

        public int? StructureObjectID
        {
            get {
                int? result = null;
                if (StructureObjectsCB.SelectedIndex > 0)
                {
                    result = Convert.ToInt32(StructureObjectsCB.SelectedValue);
                }
                return result; 
            }
        }

        public int? ShiftID
        {
            get
            {
                int? result = null;
                if (ShiftsCB.SelectedIndex > 0)
                {
                    result = Convert.ToInt32(ShiftsCB.SelectedValue);
                }
                return result;
            }
        }

        public int? TeamID
        {
            get
            {
                int? result = null;
                if (TeamsCB.SelectedIndex > 0)
                {
                    result = Convert.ToInt32(TeamsCB.SelectedValue);
                }
                return result;
            }
        }

        

        public DateTime? StartDate
        {
            get
            {
                DateTime? result = null;
                if (DateDTP.Checked == true)
                {
                    result = new DateTime(DateDTP.Value.Year, DateDTP.Value.Month, DateDTP.Value.Day);
                }
                return result;
            }
        }


       

        private void FillStructureObjects()
        {
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            StructureObjectsCB.ValueMember = "ID";
            StructureObjectsCB.DisplayMember = "Name";
            StructureObjectsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemIntValue none = new ItemIntValue();
            //none.ID = -1;
            none.Name = "- не вибрано -";
            List<ItemIntValue> list = new List<ItemIntValue>();
            list.Add(none);
            list.AddRange(StructureObjects.GetStructureObjectsHierarchy(true).Select(a => a));

            StructureObjectsCB.DataSource = list;
        }

        private void FillShifts()
        {
            StaffShiftsLogic shifts = new StaffShiftsLogic(manager);
            ShiftsCB.ValueMember = "ID";
            ShiftsCB.DisplayMember = "Name";
            ShiftsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StaffShift none = new StaffShift();
            //none.ID = -1;
            none.Name = "- не вибрано -";
            List<StaffShift> list = new List<StaffShift>();
            list.Add(none);
            list.AddRange(shifts.GetAll());

            ShiftsCB.DataSource = list;
        }

        private void FillTeams()
        {
            StaffTeamsLogic teams = new StaffTeamsLogic(manager);
            TeamsCB.ValueMember = "ID";
            TeamsCB.DisplayMember = "Name";
            TeamsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StaffTeam none = new StaffTeam();
            //none.ID = -1;
            none.Name = "- не вибрано -";
            List<StaffTeam> list = new List<StaffTeam>();
            list.Add(none);
            int StructureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
            list.AddRange(teams.GetByStructureObject(StructureObjectId));

            TeamsCB.DataSource = list;
        }

        //private void FillWorkPlaces()
        //{
        //    StaffWorkPlacesLogic workPlaces = new StaffWorkPlacesLogic(manager);
        //    WorkPlacesCB.ValueMember = "ID";
        //    WorkPlacesCB.DisplayMember = "Name";
        //    WorkPlacesCB.DropDownStyle = ComboBoxStyle.DropDownList;
        //    StaffWorkPlace none = new StaffWorkPlace();
        //    //none.ID = -1;
        //    none.Name = "- не вибрано -";
        //    List<StaffWorkPlace> list = new List<StaffWorkPlace>();
        //    list.Add(none);
        //    int StructureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
        //    list.AddRange(workPlaces.GetByStructureObject(StructureObjectId));

        //    WorkPlacesCB.DataSource = list;
        //}

        public void Fill()
        {
            manager = new ContextManager();
      
            FillStructureObjects();
            FillShifts();
            FillTeams();
            //FillWorkPlaces();
        }

        public EnterpriseStructureUC()
        {
            InitializeComponent();
           
        }

        private void EnterprisesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillStructureObjects();
        }

        private void StructureObjectsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTeams();
            //FillWorkPlaces();
        }

        private void DateDTP_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

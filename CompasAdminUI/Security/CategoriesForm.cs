using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Compas.Logic;
using Compas.Logic.Security;

namespace Compas.AdminUI.Security
{
    public partial class CategoriesForm : Form
    {
        private void FillGrid()
        {
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic logic = new SecurityCategoriesLogic(manager);
            DataGV.DataSource = logic.GetAll();
        }

        public CategoriesForm()
        {
            InitializeComponent();
            DataGV.AutoGenerateColumns = false;
            FillGrid();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic sr = new SecurityCategoriesLogic(manager);
            sr.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells[0].FormattedValue));
            manager.Save();
            FillGrid();
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            //string[] args = new string[] { "new" };

            CategoryNew rn = new CategoryNew();
            rn.ShowDialog();
            FillGrid();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            CategoryEdit rn = new CategoryEdit(Convert.ToInt32(DataGV.SelectedRows[0].Cells[0].FormattedValue));
            rn.ShowDialog();
            FillGrid();
        }

        


    }
}

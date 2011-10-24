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
using Compas.Logic.Documents;

using Compas.Helpers;

namespace Compas.UC
{
    public partial class DocumentFilterUC : UserControl
    {
        ContextManager manager;

        public int? DocumentTypeID
        {
            get
            {
                int? result = null;
                if (DocumentTypesCB.SelectedIndex >= 0)
                {
                    result = Convert.ToInt32(DocumentTypesCB.SelectedValue);
                }
                return result;
            }
        }

       
        public string DocumentNumber
        {
            get
            {
                string result = null;
                result = DocumentNumberTB.Text;
                return result;
            }
        }

        
       
        public decimal? DocumentSum
        {
            get
            {
                decimal? result = null;
                if (DocumentSumSE.EditValue != null)
                {
                    result = Convert.ToDecimal(DocumentSumSE.EditValue);
                }
                return result;
            }
        }

        public void Fill()
        {
            ItemIntValue none = new ItemIntValue();
            none.ID = -1;
            none.Name = " - не вибрано - ";
            List<ItemIntValue> items0 = new List<ItemIntValue>();

            DocumentTypesLogic documentTypesLogic = new DocumentTypesLogic(manager);
            items0.Clear();
            items0.Add(none);
            foreach (var a in documentTypesLogic.GetAll().OrderBy(a => a.Name))
            {
                ItemIntValue i = new ItemIntValue();
                i.ID = a.ID;
                i.Name = a.Name;
                items0.Add(i);
            }
            DocumentTypesCB.DataSource = items0;
            DocumentTypesCB.ValueMember = "ID";
            DocumentTypesCB.DisplayMember = "Name";
            DocumentTypesCB.Update();

            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
           

        }

        public DocumentFilterUC()
        {
            InitializeComponent();
            manager = new ContextManager();
            
        }

        private void DocumentFilterUC_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}

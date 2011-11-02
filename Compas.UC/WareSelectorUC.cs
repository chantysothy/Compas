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
using Compas.Logic.Staff;
using Compas.Logic.Documents;
using Compas.Helpers;
using Compas.Logic.Config;

namespace Compas.UC
{
    public partial class WareSelectorUC : UserControl
    {
        public event EventHandler SelectedWareChanged;

        private void HandleSelectedWareChanged(object sender, EventArgs e)
        {
            
            this.OnSelectedWareChanged(EventArgs.Empty);
        }

        protected virtual void OnSelectedWareChanged(EventArgs e)
        {
            EventHandler handler = this.SelectedWareChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public int? WareID
        {
            get
            {
                int? result = null;
                if (WaresGV.SelectedRows.Count > 0)
                {
                    if(WaresGV.SelectedRows[0] != null )
                        result = Convert.ToInt32(WaresGV.SelectedRows[0].Cells["WareIDColumn"].Value);
                }
                return result;
            }
        }

        private float fontSize;

        public float FontSize
        {
            get 
            { 
                return fontSize;            
            }
            set
            {
                fontSize = value;
                categoriesUC2.Font = new Font(categoriesUC2.Font.Name, value);
                WaresGV.RowTemplate.DefaultCellStyle.Font = new Font(categoriesUC2.Font.Name, value);
            }
        }
        


        //ініціалізація компонента
        public void Init(string _mode)
        {
            manager = new ContextManager();
            mode = _mode;
           

            //Document = document;
            //DocumentDetails = documentDetails;
            //DocumentDetail = documentDetail;
            categoriesUC2.Fill();
            categoriesUC2.ExpandAll();

            
        }

        public WareSelectorUC()
        {
            InitializeComponent();
            WaresGV.SelectionChanged += this.HandleSelectedWareChanged;
        }

         string mode;

        int? id;
        ContextManager manager;

        public WareDocumentDetail DocumentDetail;
        private WareDocument Document;
        private List<WareDocumentDetail> DocumentDetails;

        SortableBindingList<ViewWare> view;

        private void FillWares()
        {
            WaresLogic wares = new WaresLogic(manager);

            int? categoryId = null;
            int? manufacturerId = null;
            int? unitId = null;
            //string name = wareFilterUC1.WareName;
            categoryId = categoriesUC2.SelectedCategoryID;
            if (categoryId < 0)
                categoryId = null;
            BindingSource bs = new BindingSource();



            List<ViewWare> waresList = wares.GetAllView("", categoryId, manufacturerId, unitId);
            //    mode == "new" ?
            //    wares.GetAllView("",categoryId, manufacturerId, unitId):
            //   /* wares.GetAll("", categoryId, manufacturerId, unitId).Select(a => new
            //    {
            //        a.ID,
            //        Name = a.Name,
            //        UnitName = a.WareUnit != null ? a.WareUnit.Name : "",
            //        ManufacturerName = a.WareManufacturer != null ? a.WareManufacturer.Name : "",
            //        CategoryName = a.WareCategory != null ? a.WareCategory.Name : "",
            //        SecondaryUnitID = a.SecondaryUnitID != null ? a.SecondaryUnitID : null,
            //        SecondaryUnitName = a.WareUnit1 != null ? a.WareUnit1.Name : "",
            //        SecondaryUnitQuantity = a.SecondaryUnitQuantity != null ? a.SecondaryUnitQuantity : null,
            //        a.WareCodes
            //    }) */
            //wares.GetAllByWareID(DocumentDetail.WareID).Select(a => new
            //{
            //    a.ID,
            //    Name = a.Name,
            //    UnitName = a.WareUnit != null ? a.WareUnit.Name : "",
            //    ManufacturerName = a.WareManufacturer != null ? a.WareManufacturer.Name : "",
            //    CategoryName = a.WareCategory != null ? a.WareCategory.Name : "",
            //    SecondaryUnitID = a.SecondaryUnitID != null ? a.SecondaryUnitID : null,
            //    SecondaryUnitName = a.WareUnit1 != null ? a.WareUnit1.Name : "",
            //    SecondaryUnitQuantity = a.SecondaryUnitQuantity != null ? a.SecondaryUnitQuantity : null,
            //    a.WareCodes
            //})

            //.OrderBy(a => a.CategoryName).ThenBy(a=> a.Name).ToList();
            //List<WareView> viewList = new List<WareView>();
            //foreach (var a in waresList)
            //{
            //    WareView wv = new WareView();
            //    wv.ID = a.ID;
            //    wv.Name = a.Name;
            //    wv.CategoryName = a.CategoryName;
            //    wv.ManufacturerName = a.ManufacturerName;
            //    wv.UnitName = a.UnitName;
            //    wv.SecondaryUnitID = a.SecondaryUnitID;
            //    wv.SecondaryUnitName = a.SecondaryUnitName;
            //    wv.SecondaryUnitQuantity = a.SecondaryUnitQuantity;
            //    wv.WareCodes = a.WareCodes.ToList();
            //    viewList.Add(wv);
            //}

            //BindingListView<ViewWare> view = new BindingListView<ViewWare>(waresList);
            //bs.DataSource = view;
            //bs.Sort = columnName;

            view = new SortableBindingList<ViewWare>(waresList);

            WaresGV.AutoGenerateColumns = false;
            WaresGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            WaresGV.DataSource = view;

            

        }

        

        

        

        private void PriceGroupsCBE_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void categoriesUC2_Click(object sender, EventArgs e)
        {

        }

        private void categoriesUC2_SelectedCategoryChanged(object sender, EventArgs e)
        {
            FillWares();
        }

        private void WaresUpBt_Click(object sender, EventArgs e)
        {
            if (WaresGV.FirstDisplayedScrollingRowIndex > 0)
                WaresGV.FirstDisplayedScrollingRowIndex = WaresGV.FirstDisplayedScrollingRowIndex - 1;
        }

        private void WaresDownBt_Click(object sender, EventArgs e)
        {
            if(WaresGV.FirstDisplayedScrollingRowIndex < WaresGV.RowCount)
                WaresGV.FirstDisplayedScrollingRowIndex = WaresGV.FirstDisplayedScrollingRowIndex + 1;
        }

        private void CategoriesUpBt_Click(object sender, EventArgs e)
        {
            categoriesUC2.ScrollUp();
        }

        private void CategoriesDownBt_Click(object sender, EventArgs e)
        {
            categoriesUC2.ScrollDown();
        }

        private void WaresGV_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void UnitQuantityNUD_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SecondaryUnitQuantityNUD_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void UnitPriceNUD_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowNumPadBt_Click(object sender, EventArgs e)
        {
         
        }

        

        private void CancelBt_Click(object sender, EventArgs e)
        {
            
        }

        private void UnitPriceNUD_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void DiscountForUnitNUD_ValueChanged(object sender, EventArgs e)
        {
           
        }

        

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            WaresGV.DataSource = new SortableBindingList<ViewWare>(view.Where(a => (a.Name.ToUpper().Contains(NameTB.Text.ToUpper()) == true)));
            WaresGV.Update();
        }

        private void CodeTB_TextChanged(object sender, EventArgs e)
        {
            WaresGV.DataSource = new SortableBindingList<ViewWare>(view.Where(a => (a.WareCode.ToUpper().Contains(CodeTB.Text.ToUpper()) == true)));
            WaresGV.Update();
        }

        private void categoriesUC2_SelectedCategoryChanged_1(object sender, EventArgs e)
        {
            FillWares();
        }

    }
}

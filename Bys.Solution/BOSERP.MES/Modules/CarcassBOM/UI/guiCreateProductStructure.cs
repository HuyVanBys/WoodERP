using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiCreateProductStructure : BOSERPScreen
    {
        //List<ICProductsInfo> objProductsInfoList;
        public string ObjectType = string.Empty;
        public int ProductID = 0;
        public decimal Qty = 0;
        public bool HasComponent = false;
        public int ProcessID = 0;
        public string ProductDesc = string.Empty;
        bool ReadOnly = false;
        bool IsReload = false;
        public List<ICProductsInfo> SemiProduct { get; set; }

        public List<ICProductsInfo> SelectedList { get; set; }
        public guiCreateProductStructure(int productID, decimal qty, bool hasComponent, int processID, string productDesc, bool isReadOnly, List<ICProductsInfo> semiProducts)
        {
            InitializeComponent();
            ProductID = productID;
            Qty = qty;
            HasComponent = hasComponent;
            ProcessID = processID;
            ProductDesc = productDesc;
            ReadOnly = isReadOnly;
            SemiProduct = new List<ICProductsInfo>();
            SemiProduct = semiProducts;
            SelectedList = new List<ICProductsInfo>();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiCreateProductStructure_Load(object sender, EventArgs e)
        {
            if (IsReload)
                return;

            InitializeControls(Controls);
            InvalidateDataControls();
        }

        private void InvalidateDataControls()
        {
            fld_lkeICProductID1.EditValue = ProductID;
            fld_txtQty.EditValue = Qty;
            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
            entity.ProductItemList.InitBOSListGridControl(fld_dgcSemiProduct1);
            if (SemiProduct != null)
            {
                entity.ProductItemList.Invalidate(SemiProduct);
                entity.ProductItemList.GridControl?.RefreshDataSource();
            }
            fld_btnSave.Enabled = !ReadOnly;

            GridView gridView = (GridView)fld_dgcSemiProduct1.MainView;
            if (gridView == null)
                return;

            try
            {
                gridView.ClearSelection();
                gridView.ClearColumnsFilter();
                gridView.ClearSorting();
            }
            catch (Exception e) { }
            SelectedList = SemiProduct.Where(p => p.Selected == true).ToList();
            for (int i = 0; i < SemiProduct.Count(); i++)
            {
                ICProductsInfo item = (ICProductsInfo)gridView.GetRow(i);
                if (SelectedList.Where(o => o.ICProductID == item.ICProductID).Count() > 0)
                    gridView.SelectRow(i);
            }
            gridView.RefreshData();
        }

        public void ReloadData(int productID, decimal qty, bool hasComponent, int processID, string productDesc, bool isReadOnly, List<ICProductsInfo> semiProducts)
        {
            IsReload = true;
            ProductID = productID;
            Qty = qty;
            HasComponent = hasComponent;
            ProcessID = processID;
            ProductDesc = productDesc;
            ReadOnly = isReadOnly;
            SemiProduct = new List<ICProductsInfo>();
            SemiProduct = semiProducts;

            InvalidateDataControls();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcSemiProduct1.MainView;
            SelectedList.Clear();
            int[] rowSelected = gridView.GetSelectedRows();
            foreach (int i in rowSelected)
            {
                ICProductsInfo item = (ICProductsInfo)gridView.GetRow(i);
                if (item == null || i < 0)
                    continue;

                SelectedList.Add(item);
            }
            decimal.TryParse(fld_txtQty.EditValue.ToString(), out Qty);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}

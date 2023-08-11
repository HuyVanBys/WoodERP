using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ConversionProposal
{
    public partial class guiShowProductSeries : BOSERPScreen
    {
        public ICProductAttributesInfo Attributes { get; set; }
        public List<ICProductSeriesInfo> ListSeries = new List<ICProductSeriesInfo>();
        public List<ICProductSeriesInfo> ProductSeriesInfoList = new List<ICProductSeriesInfo>();
        private bool isFilterChecked = true;
        private bool flag = false;
        private bool IsShowDialog;
        private BOSGridControl GridControlResult;
        public ICProductSeriesGridControl ShowProductSeriesGridControl
        {
            get { return fld_dgcICProductSeries; }
        }
        public int DepartmentID,
                    ProductAttributeWoodTypeID,
                    ProductGroupID;
        public string ProductType, StockIDs;
        public Decimal ProductHeight { get; set; }
        public Decimal ProductWidth { get; set; }
        public Decimal ProductLength { get; set; }

        public guiShowProductSeries()
        {
            InitializeComponent();
            ICStocksController objStocksController = new ICStocksController();
            this.fld_cbbStocks.Properties.DataSource = objStocksController.GetListRealStock();
            this.fld_cbbStocks.Properties.ValueMember = "ICStockID";
            this.fld_cbbStocks.Properties.DisplayMember = "ICStockName";
            this.fld_cbbStocks.RefreshEditValue();
        }

        public guiShowProductSeries(int stockID, bool isShowDialog)
        {
            InitializeComponent();
            StockIDs = stockID.ToString();
            //fld_lkeStocks.EditValue = stockID;
            ProductWidth = 0;
            ProductLength = 0;
            ProductHeight = 0;
            IsShowDialog = isShowDialog;
            fld_btnChosse.Visible = isShowDialog;
            ICStocksController objStocksController = new ICStocksController();
            this.fld_cbbStocks.Properties.DataSource = objStocksController.GetListRealStock();
            this.fld_cbbStocks.Properties.ValueMember = "ICStockID";
            this.fld_cbbStocks.Properties.DisplayMember = "ICStockName";
            this.fld_cbbStocks.EditValue = stockID;
            this.fld_cbbStocks.RefreshEditValue();
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

        private void guiShowInventoryStock_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            if (fld_lkeDepartments.EditValue != null)
            {
                DepartmentID = int.Parse(fld_lkeDepartments.EditValue.ToString());
            }
            else
            {
                DepartmentID = 0;
            }

            if (fld_lkeWoodType.EditValue != null)
            {
                ProductAttributeWoodTypeID = int.Parse(fld_lkeWoodType.EditValue.ToString());
            }
            else
            {
                ProductAttributeWoodTypeID = 0;
            }

            if (fld_cbbStocks.EditValue != null)
            {
                StockIDs = fld_cbbStocks.EditValue.ToString();
            }
            else
            {
                StockIDs = string.Empty;
            }

            if (fld_txtProductHeight.EditValue != null)
            {
                Decimal.TryParse(fld_txtProductHeight.EditValue.ToString(), out decimal height);
                ProductHeight = height;
            }
            else
            {
                ProductHeight = 0M;
            }

            if (fld_txtProductWidth.EditValue != null)
            {
                Decimal.TryParse(fld_txtProductWidth.EditValue.ToString(), out decimal width);
                ProductWidth = width;
            }
            else
            {
                ProductWidth = 0M;
            }

            if (fld_txtProductLength.EditValue != null)
            {
                Decimal.TryParse(fld_txtProductLength.EditValue.ToString(), out decimal length);
                ProductLength = length;
            }
            else
            {
                ProductLength = 0M;
            }

            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ListSeries = objProductSeriesController.ShowInventoryStockProductSeries(BOSApp.GetCurrentServerDate(), DepartmentID, ProductGroupID, ProductAttributeWoodTypeID, StockIDs, ProductHeight, ProductWidth, ProductLength);
            fld_dgcICProductSeries.DataSource = ListSeries;
            GridView gridView = (GridView)fld_dgcICProductSeries.MainView;
            gridView.BestFitColumns();

        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (fld_lkeDepartments.EditValue != null)
            {
                DepartmentID = int.Parse(fld_lkeDepartments.EditValue.ToString());
            }
            else
            {
                DepartmentID = 0;
            }
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo.FK_ICDepartmentID = DepartmentID;
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(objProductsInfo.FK_ICDepartmentID, objProductsInfo.FK_ICProductGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    DepartmentID = objProductGroupsInfo.FK_ICDepartmentID;
                    ProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    fld_lkeDepartments.EditValue = DepartmentID;
                    fld_bedFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    objProductsInfo.FK_ICProductGroupID = 0;
                    objProductsInfo.ICProductGroupName = string.Empty;
                }
            }
        }

        //private void fld_lkeICProductType_EditValueChanged(object sender, EventArgs e)
        //{
        //    //ICProductsInfo objProductsInfo = new ICProductsInfo();

        //    if (fld_lkeICProductType.EditValue != null)
        //    {
        //        ICProductType = fld_lkeICProductType.EditValue.ToString();
        //    }
        //    List<ICProductsForViewInfo> ListProduct = BOSApp.CurrentProductList.Where(p => p.ICProductType == ICProductType || ICProductType == string.Empty).ToList();
        //    fld_lkeFK_ICProductID1.Properties.DataSource = ListProduct;

        //    GridView gridView = (GridView)fld_dgcICProductSeries.MainView;

        //    // foreach (GridColumn column in gridView.Columns)
        //    {
        //        if (gridView.Columns["ICProductSerieNo"] != null)
        //        {
        //            gridView.Columns["ICProductSerieNo"].Caption = "Mã kiện/Mã đầu lóng";
        //        }

        //        if (gridView.Columns["ICInventoryStockQuantity"] != null)
        //        {
        //            if (ICProductType == ProductType.Verneer.ToString()
        //       || ICProductType == ProductType.Roundwood.ToString()
        //       || ICProductType == ProductType.Reuse.ToString()
        //       || ICProductType == ProductType.Lumber.ToString()
        //       || ICProductType == ProductType.ArtificialBoard.ToString())
        //            {
        //                gridView.Columns["ICInventoryStockQuantity"].Caption = "Khối lượng";
        //            }
        //            else
        //            {
        //                gridView.Columns["ICInventoryStockQuantity"].Caption = "Số lượng";
        //            }
        //            gridView.Columns["ICInventoryStockQuantity"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
        //            gridView.Columns["ICInventoryStockQuantity"].DisplayFormat.FormatString = "{0:0.####}";
        //        }

        //        if (ICProductType == ProductType.Roundwood.ToString())
        //        {
        //            if (gridView.Columns["FK_ICModelID"] != null)
        //            {
        //                gridView.Columns["FK_ICModelID"].Visible = true;
        //            }
        //            if (gridView.Columns["FK_ICModelDetailID"] != null)
        //            {
        //                gridView.Columns["FK_ICModelDetailID"].Visible = true;
        //            }
        //        }

        //        if (ICProductType == ProductType.Roundwood.ToString())
        //        {
        //            if (gridView.Columns["ICProductSerieProductHeight"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductHeight"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductPerimeter"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductPerimeter"].Visible = true;
        //            }
        //            if (gridView.Columns["ICProductSerieProductLength"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductLength"].Visible = true;
        //            }
        //            if (gridView.Columns["ICProductSerieProductLengthMax"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductLengthMax"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductWidth"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductWidth"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductWidthMax"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductWidthMax"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieNo"] != null)
        //            {
        //                gridView.Columns["ICProductSerieNo"].Caption = "Mã đầu lóng";
        //            }

        //        }
        //        else if (ICProductType == ProductType.Lumber.ToString() || ICProductType == ProductType.Reuse.ToString())
        //        {
        //            if (gridView.Columns["ICProductSerieProductHeight"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductHeight"].Visible = true;
        //            }
        //            if (gridView.Columns["ICProductSerieProductLength"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductLength"].Visible = true;
        //            }
        //            if (gridView.Columns["ICProductSerieProductWidth"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductWidth"].Visible = true;
        //            }
        //            if (gridView.Columns["ICProductSerieProductPerimeter"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductPerimeter"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductLengthMax"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductLengthMax"].Visible = true;
        //            }
        //            if (gridView.Columns["ICProductSerieProductWidthMax"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductWidthMax"].Visible = true;
        //            }
        //            if (gridView.Columns["ICProductSerieNo"] != null)
        //            {
        //                gridView.Columns["ICProductSerieNo"].Caption = "Mã kiện";
        //            }
        //        }
        //        else
        //        {
        //            if (gridView.Columns["ICProductSerieProductHeight"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductHeight"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductPerimeter"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductPerimeter"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductLength"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductLength"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductLengthMax"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductLengthMax"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductWidth"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductWidth"].Visible = false;
        //            }
        //            if (gridView.Columns["ICProductSerieProductWidthMax"] != null)
        //            {
        //                gridView.Columns["ICProductSerieProductWidthMax"].Visible = false;
        //            }
        //            if (gridView.Columns["ICInventoryStockWoodQuantity"] != null)
        //            {
        //                gridView.Columns["ICInventoryStockWoodQuantity"].Visible = false;
        //            }
        //            if (ICProductType == ProductType.IngredientPackaging.ToString())
        //            {
        //                if (gridView.Columns["ICProductSerieProductDesc"] != null)
        //                {
        //                    gridView.Columns["ICProductSerieProductDesc"].Visible = true;
        //                }
        //            }
        //            else
        //            {
        //                if (gridView.Columns["ICProductSerieProductDesc"] != null)
        //                {
        //                    gridView.Columns["ICProductSerieProductDesc"].Visible = false;
        //                }
        //            }
        //        }
        //    }
        //    gridView.GroupFormat = "[#image]{1}: {2}";
        //    gridView.BestFitColumns();


        //}

        private void fld_btnChosse_Click(object sender, EventArgs e)
        {
            if (ListSeries.Count > 0)
            {
                foreach (ICProductSeriesInfo item in ListSeries)
                {
                    if (item.Selected == true)
                    {
                        ProductSeriesInfoList.Add(item);
                    }
                }
            }
            if (!IsShowDialog && ProductSeriesInfoList.Count > 0)
            {
                ((ConversionProposalModule)Module).GetSelectedSeriesList(ProductSeriesInfoList);
            }    
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkSelectAll.Checked);
            fld_dgcICProductSeries.RefreshDataSource();
        }

        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcICProductSeries.MainView;
            List<ICProductSeriesInfo> listView = new List<ICProductSeriesInfo>();
            List<ICProductSeriesInfo> objects = (List<ICProductSeriesInfo>)fld_dgcICProductSeries.DataSource;
            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    ICProductSeriesInfo objDataViewPermissionsInfo = (ICProductSeriesInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }
                }
            }
        }
    }
}

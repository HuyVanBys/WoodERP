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

namespace BOSERP
{
    public partial class guiShowInventoryStock : BOSERPScreen
    {

        public ICProductsInfo Product { get; set; }
        public ICProductAttributesInfo Attributes { get; set; }
        public List<ICProductSeriesInfo> ListSeries = new List<ICProductSeriesInfo>();
        public List<ICProductSeriesInfo> ProductSeriesInfoList = new List<ICProductSeriesInfo>();
        private bool isFilterChecked = true;
        private bool flag = false;
        private BOSGridControl GridControlResult;
        public ShowInventoryStockGridControl ShowInventoryStockGridControl
        {
            get { return fld_dgcICProductSeries; }
        }
        public int
                    ICProductID,
                    FK_ICProductAttributeWoodTypeID,
                    FK_ICProductGroupID,
                    stocks
                    ;
        public int batchProduct = 0, productForBatch = 0, operation = 0;
        public string ICProductType;
        //public guiShowInventoryStock InventoryStockQuantityGridControl
        //{
        //get { return fld_dgcInventoryStocks; }
        // }
        public guiShowInventoryStock()
        {
            InitializeComponent();
        }

        public guiShowInventoryStock(string productType, int stockID)
        {
            InitializeComponent();
            ICProductType = productType;
            stocks = stockID;
            fld_lkeStocks.EditValue = stockID;
        }

        public guiShowInventoryStock(string productType)
        {
            InitializeComponent();
            ICProductType = productType;
        }
        public guiShowInventoryStock(string productType, bool fflag)
        {
            InitializeComponent();
            ICProductType = productType;
            flag = fflag;
        }
        public guiShowInventoryStock(string productType, bool fflag, int MMbatchProductID, int productForBatchID)
        {
            InitializeComponent();
            ICProductType = productType;
            flag = fflag;
            batchProduct = MMbatchProductID;
            productForBatch = productForBatchID;
            //stocks = stock;

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
        public void ConvertToProductType(string productType, bool flag)
        {
            if (!flag)
            {
                if (productType.Contains("Lumber"))
                {
                    fld_lkeICProductType.EditValue = ProductType.Lumber.ToString();
                }
                else if (productType.Contains("Roundwood") || productType.Contains("RoundWood"))
                {
                    fld_lkeICProductType.EditValue = ProductType.Roundwood.ToString();
                }
                else if (productType.Contains("Other"))
                {
                    fld_lkeICProductType.Properties.ReadOnly = false;
                }
                else
                {
                    fld_lkeICProductType.EditValue = productType;
                }
            }
            else
            {
                fld_lkeICProductType.Properties.ReadOnly = false;

                ProductTypeLookUpEditBindingSource();
                fld_lkeICProductType.EditValue = productType;

            }

        }
        public void ProductTypeLookUpEditBindingSource()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductType);
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //ConfigValuesList.Add(objConfigValuesInfo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    if (objConfigValuesInfo.ADConfigKeyValue == ProductType.Product.ToString()
                        || objConfigValuesInfo.ADConfigKeyValue == ProductType.SemiProduct.ToString())

                        ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            fld_lkeICProductType.Properties.Columns.Clear();
            fld_lkeICProductType.Properties.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));

            if (ConfigValuesList != null)
            {
                fld_lkeICProductType.BOSDataSource = "";
                fld_lkeICProductType.BOSDataMember = "";
                fld_lkeICProductType.Properties.DataSource = ConfigValuesList;
                fld_lkeICProductType.Properties.DisplayMember = "ADConfigText";
                fld_lkeICProductType.Properties.ValueMember = "ADConfigKeyValue";


            }

        }


        private void guiShowInventoryStock_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ConvertToProductType(ICProductType, flag);
            if (stocks > 0)
            {
                fld_lkeStocks.EditValue = stocks;
            }
            if (productForBatch > 0)
            {
                fld_lkeMMBatchProductID.EditValue = batchProduct;
                fld_lkeMMBatchProductID.Properties.ReadOnly = false;
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            if (fld_lkeFK_ICProductID1.EditValue != null)
            {
                ICProductID = int.Parse(fld_lkeFK_ICProductID1.EditValue.ToString());
            }
            if (fld_lkeICProductType.EditValue != null)
            {
                ICProductType = fld_lkeICProductType.EditValue.ToString();
            }
            if (fld_bedFK_ICProductGroupID.EditValue != null)
            {

                //FK_ICProductGroupID = int.Parse(fld_bedFK_ICProductGroupID.EditValue.ToString());
            }
            if (fld_lkeWoodType.EditValue != null)
            {
                FK_ICProductAttributeWoodTypeID = int.Parse(fld_lkeWoodType.EditValue.ToString());
            }
            if (fld_lkeStocks.EditValue != null)
            {
                stocks = int.Parse(fld_lkeStocks.EditValue.ToString());
            }
            //TNDLoc [ADD][16/05/2016][Filter by BatchProductID],START
            int batchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
            {
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            }
            //TNDLoc [ADD][16/05/2016][Filter by BatchProductID],END
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();

            ListSeries = objProductSeriesController.ShowguidInventoryStock(ICProductID, ICProductType, FK_ICProductAttributeWoodTypeID, FK_ICProductGroupID, stocks, batchProductID, 0);
            fld_dgcICProductSeries.DataSource = ListSeries;
            GridView gridView = (GridView)fld_dgcICProductSeries.MainView;
            gridView.BestFitColumns();

        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ///ProductEntities entity = (ProductEntities)CurrentModuleEntity;
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(objProductsInfo.FK_ICDepartmentID, objProductsInfo.FK_ICProductGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    //objProductsInfo.FK_ICDepartmentID = guiProductGroupTree.ICDepartmentID;
                    FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    //objProductsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;
                    //objProductsInfo.ICProductGroupName = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_bedFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    objProductsInfo.FK_ICProductGroupID = 0;
                    objProductsInfo.ICProductGroupName = string.Empty;
                }
                //  entity.UpdateMainObjectBindingSource();
            }
        }

        private void fld_lkeICProductType_EditValueChanged(object sender, EventArgs e)
        {
            //ICProductsInfo objProductsInfo = new ICProductsInfo();

            if (fld_lkeICProductType.EditValue != null)
            {
                ICProductType = fld_lkeICProductType.EditValue.ToString();
            }
            List<ICProductsForViewInfo> ListProduct = BOSApp.CurrentProductList.Where(p => p.ICProductType == ICProductType || ICProductType == string.Empty).ToList();
            fld_lkeFK_ICProductID1.Properties.DataSource = ListProduct;

            GridView gridView = (GridView)fld_dgcICProductSeries.MainView;

            // foreach (GridColumn column in gridView.Columns)
            {
                if (gridView.Columns["ICProductSerieNo"] != null)
                {
                    gridView.Columns["ICProductSerieNo"].Caption = "Mã kiện/Mã đầu lóng";
                }

                if (gridView.Columns["ICInventoryStockQuantity"] != null)
                {
                    if (ICProductType == ProductType.Verneer.ToString()
               || ICProductType == ProductType.Roundwood.ToString()
               || ICProductType == ProductType.Reuse.ToString()
               || ICProductType == ProductType.Lumber.ToString()
               || ICProductType == ProductType.ArtificialBoard.ToString())
                    {
                        gridView.Columns["ICInventoryStockQuantity"].Caption = "Khối lượng";
                    }
                    else
                    {
                        gridView.Columns["ICInventoryStockQuantity"].Caption = "Số lượng";
                    }
                    gridView.Columns["ICInventoryStockQuantity"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    gridView.Columns["ICInventoryStockQuantity"].DisplayFormat.FormatString = "{0:0.####}";
                }

                if (ICProductType == ProductType.Roundwood.ToString())
                {
                    if (gridView.Columns["FK_ICModelID"] != null)
                    {
                        gridView.Columns["FK_ICModelID"].Visible = true;
                    }
                    if (gridView.Columns["FK_ICModelDetailID"] != null)
                    {
                        gridView.Columns["FK_ICModelDetailID"].Visible = true;
                    }
                }

                if (ICProductType == ProductType.Roundwood.ToString())
                {
                    if (gridView.Columns["ICProductSerieProductHeight"] != null)
                    {
                        gridView.Columns["ICProductSerieProductHeight"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductPerimeter"] != null)
                    {
                        gridView.Columns["ICProductSerieProductPerimeter"].Visible = true;
                    }
                    if (gridView.Columns["ICProductSerieProductLength"] != null)
                    {
                        gridView.Columns["ICProductSerieProductLength"].Visible = true;
                    }
                    if (gridView.Columns["ICProductSerieProductLengthMax"] != null)
                    {
                        gridView.Columns["ICProductSerieProductLengthMax"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductWidth"] != null)
                    {
                        gridView.Columns["ICProductSerieProductWidth"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductWidthMax"] != null)
                    {
                        gridView.Columns["ICProductSerieProductWidthMax"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieNo"] != null)
                    {
                        gridView.Columns["ICProductSerieNo"].Caption = "Mã đầu lóng";
                    }

                }
                else if (ICProductType == ProductType.Lumber.ToString() || ICProductType == ProductType.Reuse.ToString())
                {
                    if (gridView.Columns["ICProductSerieProductHeight"] != null)
                    {
                        gridView.Columns["ICProductSerieProductHeight"].Visible = true;
                    }
                    if (gridView.Columns["ICProductSerieProductLength"] != null)
                    {
                        gridView.Columns["ICProductSerieProductLength"].Visible = true;
                    }
                    if (gridView.Columns["ICProductSerieProductWidth"] != null)
                    {
                        gridView.Columns["ICProductSerieProductWidth"].Visible = true;
                    }
                    if (gridView.Columns["ICProductSerieProductPerimeter"] != null)
                    {
                        gridView.Columns["ICProductSerieProductPerimeter"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductLengthMax"] != null)
                    {
                        gridView.Columns["ICProductSerieProductLengthMax"].Visible = true;
                    }
                    if (gridView.Columns["ICProductSerieProductWidthMax"] != null)
                    {
                        gridView.Columns["ICProductSerieProductWidthMax"].Visible = true;
                    }
                    if (gridView.Columns["ICProductSerieNo"] != null)
                    {
                        gridView.Columns["ICProductSerieNo"].Caption = "Mã kiện";
                    }
                }
                else
                {
                    if (gridView.Columns["ICProductSerieProductHeight"] != null)
                    {
                        gridView.Columns["ICProductSerieProductHeight"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductPerimeter"] != null)
                    {
                        gridView.Columns["ICProductSerieProductPerimeter"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductLength"] != null)
                    {
                        gridView.Columns["ICProductSerieProductLength"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductLengthMax"] != null)
                    {
                        gridView.Columns["ICProductSerieProductLengthMax"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductWidth"] != null)
                    {
                        gridView.Columns["ICProductSerieProductWidth"].Visible = false;
                    }
                    if (gridView.Columns["ICProductSerieProductWidthMax"] != null)
                    {
                        gridView.Columns["ICProductSerieProductWidthMax"].Visible = false;
                    }
                    if (gridView.Columns["ICInventoryStockWoodQuantity"] != null)
                    {
                        gridView.Columns["ICInventoryStockWoodQuantity"].Visible = false;
                    }
                    if (ICProductType == ProductType.IngredientPackaging.ToString())
                    {
                        if (gridView.Columns["ICProductSerieProductDesc"] != null)
                        {
                            gridView.Columns["ICProductSerieProductDesc"].Visible = true;
                        }
                    }
                    else
                    {
                        if (gridView.Columns["ICProductSerieProductDesc"] != null)
                        {
                            gridView.Columns["ICProductSerieProductDesc"].Visible = false;
                        }
                    }
                }
            }
            gridView.GroupFormat = "[#image]{1}: {2}";
            gridView.BestFitColumns();


        }

        private void fld_btnChosse_Click(object sender, EventArgs e)
        {
            //List<ICProductSeriesInfo> Listcheck = new List<ICProductSeriesInfo>();
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
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {

            //if (!fld_chkSelectAll.Checked)
            //{
            //    List<ICProductSeriesInfo> objects = (List<ICProductSeriesInfo>)fld_dgcICProductSeries.DataSource;
            //    if (objects != null)
            //    {
            //        foreach (ICProductSeriesInfo obj in objects)
            //        {
            //            obj.Selected = fld_chkSelectAll.Checked;
            //        }
            //        fld_dgcICProductSeries.RefreshDataSource();
            //    }
            //}
            //else
            {
                CheckedAllByFilterCondition(fld_chkSelectAll.Checked);
                fld_dgcICProductSeries.RefreshDataSource();
            }
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

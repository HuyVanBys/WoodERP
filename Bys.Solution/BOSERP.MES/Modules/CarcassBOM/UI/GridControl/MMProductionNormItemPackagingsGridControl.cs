using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class MMProductionNormItemPackagingsGridControl : BOSGridControl
    {
        public List<ICProductsInfo> packagingList;
        MMAllocationOperationConfigsInfo DefualtAOConfigs { get; set; }
        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionNormItemPackagingList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)gridView.GetFocusedRow();
                if (item != null)
                {
                    ((CarcassBOMModule)Screen.Module).RemoveSelectedItemFromProductionNormItemPackagingList(item);
                }
            }
        }

        private List<ICProductsInfo> GetPackagingList()
        {
            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> dataList = new List<ICProductsInfo>();
            dataList.Insert(0, new ICProductsInfo());
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.IngredientPackaging.ToString()).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                dataList.Add(newObj);
            });
            return dataList;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);



            GridView gridView = (GridView)sender;

            MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                string fieldName = e.Column.FieldName;

                if (fieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
                {
                    ((CarcassBOMModule)Screen.Module).SetMarketDimensionForMaterial(item);
                }

                ((CarcassBOMModule)Screen.Module).CalculateProductionNormItemPackaging(fieldName, item);
                ((CarcassBOMModule)Screen.Module).SetOperationForMaterial(item);
                ((CarcassBOMModule)Screen.Module).SetProductForMaterial(fieldName, item);

            }


        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "STT";
            column.FieldName = "MMProductionNormItemSortOrderString";
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();

            packagingList = GetPackagingList();

            gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;


            string[] colList = new string[] { "MMProductionNormItemSortOrderString"
                                            ,   "MMProductionNormItemNo"
                                            ,   "MMProductionNormItemProductName"
                                            ,   "MMProductionNormItemProductDesc"
                                            ,   "MMProductionNormItemProductInsideDimensionLength"
                                            ,   "MMProductionNormItemProductInsideDimensionWidth"
                                            ,   "MMProductionNormItemProductInsideDimensionHeight"
                                            ,   "FK_ICProdAttPackingMaterialSpecialityID"
                                            ,   "FK_ICProdAttPackingMaterialSizeID"
                                            ,   "FK_ICProdAttPackingMaterialWeightPerVolumeID"
                                            ,   "MMProductionNormItemProductMarketLength"
                                            ,   "MMProductionNormItemProductMarketWidth"
                                            ,   "MMProductionNormItemProductMarketHeight"
                                            ,   "MMProductionNormItemQuantity"
                                            ,   "MMProductionNormItemTotalQuantity"
                                            ,   "MMProductionNormItemComment"
                                            ,   "MMProductionNormItemProductSizeAndPacking"
                                            ,   "FK_ICMeasureUnitID"
                                            ,   "MMProductionNormItemPackagingNW"
                                            ,   "MMProductionNormItemPackagingGW"
                                            ,   "MMProductionNormItemProductOverallDimensionLength"
                                            ,   "MMProductionNormItemProductOverallDimensionWidth"
                                            ,   "MMProductionNormItemProductOverallDimensionHeight"
                                            ,   "FK_MMOperationID"
                                            ,   "ChooseProduct"
                                            };

            ReLocationColumn(colList, gridview);

            GridColumn col = gridview.Columns["MMProductionNormItemTotalQuantity"];
            if (col != null)
            {
                col.Caption = "Qty/box";
            }

            col = gridview.Columns["MMProductionNormItemNo"];
            if (col != null)
            {
                col.Caption = "Mã PLĐG";
            }

            col = gridview.Columns["MMProductionNormItemProductName"];
            if (col != null)
            {
                col.Caption = "Tên PLĐG";
            }

            col = gridview.Columns["FK_MMSemiProductID"];
            if (col != null)
            {
                List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(semiProductItemLookUpEdit_QueryPopUp);
                col.ColumnEdit = repositoryItemLookUpEdit;
                col.Caption = "Thuộc chi tiết";
                col.MinWidth = 150;
            }
            col = gridview.Columns["FK_ICProductIDPack"];
            if (col != null)
            {
                RepositoryItemBOSLookupEdit packLookUpEdit = new RepositoryItemBOSLookupEdit();
                packLookUpEdit.DisplayMember = "ICProductPackageNo";
                packLookUpEdit.ValueMember = "ICProductPackageID";
                packLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                packLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                packLookUpEdit.NullText = string.Empty;
                packLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductPackageNo", "Mã kiện", 150));
                packLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductPackageName", "Tên kiện", 300));
                packLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "QC đóng kiện", 300));
                packLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductPackageLength", "Dài", 300));
                packLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductPackageWidth", "Rộng", 300));
                packLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductPackageHeight", "Cao", 300));
                packLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductPackageVolumn", "Thể tích", 300));
                packLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(packageNo_QueryPopUp);
                col.ColumnEdit = packLookUpEdit;
                col.Caption = "Loại kiện";
                col.MinWidth = 150;
            }
            col = gridview.Columns["FK_MMOperationID"];
            if (col != null)
            {
                DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên công đoạn", 150));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);

                col.ColumnEdit = repositoryItemLookUpEdit;
                col.MinWidth = 150;
            }
            foreach (GridColumn column in gridview.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "MMProductionNormItemNo"
                    || column.FieldName == "MMProductionNormItemProductMarketHeight"
                    || column.FieldName == "MMProductionNormItemProductMarketLength"
                    || column.FieldName == "MMProductionNormItemProductMarketWidth"
                    || column.FieldName == "MMProductionNormItemProductDesc")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }


            FormatColumn(gridview);

            gridview.BestFitColumns();
            gridview.DoubleClick += new System.EventHandler(gridview_DoubleClick);
            gridview.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridview;
        }

        public void reqOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {
                MMOperationsController control = new MMOperationsController();
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<MMOperationsInfo> operationList = (List<MMOperationsInfo>)control.GetListFromDataSet(ds);
                    if (operationList != null) operationList = operationList.Where(o =>
                        (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlan.ToString() && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsStock.ToString() && o.MMOperationInOutStockCheck)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanAndStock.ToString() && o.MMOperationInOutStockCheck && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanOrStock.ToString() && (o.MMOperationInOutStockCheck || o.MMOperationIsPlan))
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.AllOperation.ToString())
                        || (DefualtAOConfigs == null)
                        ).ToList();
                    lookUpEdit.Properties.DataSource = operationList;
                }
            }
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
            e.Appearance.BackColor = Color.White;

            GridView gridView = (GridView)sender;

            MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
            {
                ICProductsInfo packaging = packagingList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductID && item.FK_ICProductID > 0);
                if (packaging == null)
                {
                    // e.Appearance.BackColor = Color.Red;
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
                    e.Appearance.BackColor = Color.SandyBrown;
                }
                else
                {
                    decimal diffFactor = item.MMProductionNormItemDiffFactor; // dung sai

                    bool isMatchProduct = true;

                    if (packaging.FK_ICProdAttPackingMaterialWeightPerVolumeID != item.FK_ICProdAttPackingMaterialWeightPerVolumeID
                        || packaging.FK_ICProdAttPackingMaterialSizeID != item.FK_ICProdAttPackingMaterialSizeID)
                    {
                        isMatchProduct = false;
                    }

                    if (!(packaging.ICProductInsideDimensionLength + diffFactor >= item.MMProductionNormItemProductInsideDimensionLength
                        && packaging.ICProductInsideDimensionLength - diffFactor <= item.MMProductionNormItemProductInsideDimensionLength)
                        || !(packaging.ICProductInsideDimensionWidth + diffFactor >= item.MMProductionNormItemProductInsideDimensionWidth
                        && packaging.ICProductInsideDimensionWidth - diffFactor <= item.MMProductionNormItemProductInsideDimensionWidth))
                    {
                        isMatchProduct = false;
                    }

                    if (!isMatchProduct)
                    {
                        // e.Appearance.BackColor = Color.Green;
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
                        e.Appearance.BackColor = Color.LightYellow;
                    }
                    if (item.AbstractParentID == 0 && entity.ProductionNormItemPackagingList.Any(o => o.FK_MMProductionNormItemRefID == item.MMProductionNormItemID))
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                    }
                }
            }
        }



        private RepositoryItemBOSLookupEdit CreateRepositoryLookUpEdit(string displayMember, string valueMember, Dictionary<string, string> lookUpCols)
        {
            RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            repositoryItemLookUpEdit.DisplayMember = displayMember;
            repositoryItemLookUpEdit.ValueMember = valueMember;
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            if (lookUpCols != null && lookUpCols.Count() > 0)
            {
                foreach (string key in lookUpCols.Keys)
                {
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(key, lookUpCols[key], 100));
                }
            }
            else
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(displayMember, string.Empty, 100));

            return repositoryItemLookUpEdit;
        }

        private List<ICProductAttributesInfo> GetAttributeValueByGroup(string group)
        {
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(group);
            list.Insert(0, objProductAttributesInfo);

            return list;
        }

        private List<MMPackingMaterialMarketDimensionsInfo> GetPackingMaterialMarketDimensions()
        {
            MMPackingMaterialMarketDimensionsController controller = new MMPackingMaterialMarketDimensionsController();
            List<MMPackingMaterialMarketDimensionsInfo> list = controller.GetAllAliveMarketDimension();
            return list;
        }

        private List<ICMeasureUnitsInfo> GetMeasureUnit()
        {
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> ds = objMeasureUnitsController.GetAllAliveMeasureUnit();

            return ds;
        }

        private void FormatColumn(GridView gridView)
        {
            GridColumn column = gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("ICProductAttributeValue", "Định lượng");
                dic.Add("MMPackingMaterialMarketDimensionProductLength", "Dài");
                dic.Add("MMPackingMaterialMarketDimensionProductWidth", "Rộng");
                dic.Add("MMPackingMaterialMarketDimensionProductHeight", "Cao");

                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
                    = CreateRepositoryLookUpEdit("ICProductAttributeValue", "ICProductAttributeID", dic);
                List<MMPackingMaterialMarketDimensionsInfo> collection = GetPackingMaterialMarketDimensions();
                repositoryItemLookUpEdit.DataSource = collection;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.BestFit();
                column.MinWidth = 100;

            }

            //column = gridView.Columns["FK_ICProdAttPackingMaterialSizeID"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    Dictionary<string, string> dic = new Dictionary<string, string>();
            //    dic.Add("ICProductAttributeValue", "Khổ màng foam");

            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
            //        = CreateRepositoryLookUpEdit("ICProductAttributeValue", "ICProductAttributeID", dic);
            //    repositoryItemLookUpEdit.DataSource = GetAttributeValueByGroup(ProductAttributeGroup.PackingMaterialSize.ToString());
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.MinWidth = 150;

            //}

            //column = gridView.Columns["FK_ICProdAttPackingMaterialSpecialityID"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    Dictionary<string, string> dic = new Dictionary<string, string>();
            //    dic.Add("ICProductAttributeValue", "Đặc tính");

            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
            //        = CreateRepositoryLookUpEdit("ICProductAttributeValue", "ICProductAttributeID", dic);
            //    repositoryItemLookUpEdit.DataSource = GetAttributeValueByGroup(ProductAttributeGroup.PackingMaterialSpeciality.ToString());
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.MinWidth = 150;

            //}

            //column = gridView.Columns[ProductionNormConst.FK_ICMeasureUnitID];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    Dictionary<string, string> dic = new Dictionary<string, string>();
            //    dic.Add("ICMeasureUnitName", "ĐVT");

            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
            //        = CreateRepositoryLookUpEdit("ICMeasureUnitName", "ICMeasureUnitID", dic);
            //    repositoryItemLookUpEdit.DataSource = GetMeasureUnit();
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.MinWidth = 50;

            //}


            column = gridView.Columns["ChooseProduct"];
            if (column != null)
            {
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                rpItemComponent.NullText = "Chọn PLĐG";
                rpItemComponent.Click += new System.EventHandler(rpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
            }

            column = this.Columns["MMProductionNormItemQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "N5");
            }
        }

        void rpItemComponent_Click(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)gridView.GetFocusedRow();
                if (item != null)
                {
                    ((CarcassBOMModule)Screen.Module).ChoosePackaging(item);
                }
            }

        }


        void gridview_DoubleClick(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {

                MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)gridView.GetFocusedRow();
                if (item != null)
                {
                    if (((CarcassBOMModule)Screen.Module).IsViewComponent())
                    {
                        ((CarcassBOMModule)Screen.Module).ShowGuiPackingComponent(item);
                    }
                    else
                    {
                        ((CarcassBOMModule)Screen.Module).ShowGuiPacking(item);
                    }
                }
            }
        }

        void gridview_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                ICProductsInfo product = (ICProductsInfo)gridView.GetFocusedRow();
                if (product != null)
                {
                    //if (string.IsNullOrEmpty(product.ICProductCode.Trim()))
                    //    MessageBox.Show("Mã code không được để trống");
                    if (!product.HasComponent)
                    {
                        bool isUnSpecifications = false;
                        if (product.FK_ICProductAttributeWoodTypeID > 0)
                        {
                            ICProductAttributesInfo obj = (ICProductAttributesInfo)(new ICProductAttributesController()).GetObjectByID(product.FK_ICProductAttributeWoodTypeID);
                            if (obj != null) isUnSpecifications = obj.ICProductAttributeUnSpecifications;
                        }
                        if (isUnSpecifications &&
                            (product.ICProductHeight == 0 ||
                            product.ICProductWidth == 0 ||
                            product.ICProductLength == 0))
                            MessageBox.Show("Quy cách BTP không được để trống");
                    }
                }
            }
        }

        public string[] columnArr;
        public void ReLocationColumn(string[] columns, GridView gridView)
        {
            columnArr = columns;
            InitDefaultGridColumnsVisibleIndex(gridView);
        }
        protected override void InitDefaultGridColumnsVisibleIndex(GridView gridView)
        {
            if (columnArr != null && columnArr.Length > 0)
            {
                foreach (GridColumn columnedit1 in gridView.Columns)
                {
                    columnedit1.Visible = false;
                }
                GridColumn columnedit;
                int index = 1;
                foreach (string column in columnArr)
                {
                    columnedit = gridView.Columns[column];
                    if (columnedit != null)
                    {
                        columnedit.AppearanceCell.Options.UseBackColor = true;
                        columnedit.Visible = true;
                        columnedit.VisibleIndex = index++;
                    }
                }

                gridView.BestFitColumns();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "FK_MMSemiProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((CarcassBOMModule)Screen.Module).GetSemiProductDisplayDisplayText(int.Parse(e.Value.ToString()));
                }
                else
                    e.DisplayText = string.Empty;
            }
            else if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", int.Parse(e.Value.ToString()), "MMOperationName");
                }
            }
        }

        private void semiProductItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
        }
        private void packageNo_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetPackageNoDataSource();
        }

    }
}

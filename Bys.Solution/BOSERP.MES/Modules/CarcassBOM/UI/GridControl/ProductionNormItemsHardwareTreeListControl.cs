using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductionNormItemsHardwareTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        MMAllocationOperationConfigsInfo DefualtAOConfigs { get; set; }
        #endregion

        protected override void InitTreeListDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductionNormItemHardwareList;
        }
        public override void InitializeControl()
        {
            this.BOSDisplayOption = false;
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = true;

            this.BestFitColumns();
            foreach (TreeListColumn column in this.Columns)
            {
                if (column.FieldName == "MMProductionNormItemQuantity")
                {
                    column.Caption = "Số lượng bao gồm tiêu hao";
                    FormatNumbericColumn(column, true, "N5");
                }
                if (column.FieldName == "MMProductionNormItemTotalQuantity")
                {
                    column.Caption = "Số lượng";
                    FormatNumbericColumn(column, true, "N5");
                }
                if (column.FieldName == "MMProductionNormItemDepreciationRate")
                {
                    column.Caption = "Tỉ lệ tiêu hao";
                    FormatNumbericColumn(column, true, "N2");
                }
                if (column.FieldName == "MMHardwareOperationType")
                {
                    column.Visible = true;
                    column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemTextEdit.ToString());
                    column.OptionsColumn.AllowEdit = true;
                }
                if (column.FieldName == "FK_ICProductAttributeSpecialityID" ||
                   column.FieldName == "FK_ICProductAttributeQualityID" ||
                   column.FieldName == "MMProductionNormItemComment" ||
                   column.FieldName == "MMProductionNormItemQuantity" ||
                   column.FieldName == "MMProductionNormItemTotalQuantity" ||
                   column.FieldName == "MMProductionNormItemDepreciationRate" ||
                   column.FieldName == "FK_MMSemiProductID" ||
                   column.FieldName == "FK_ICMeasureUnitID" ||
                   column.FieldName == "MMHardwareOperationType" ||
                   column.FieldName == "MMProductionNormItemProductSizeAndPacking")
                    column.OptionsColumn.AllowEdit = true;
                else if (column.FieldName == "FK_MMOperationID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                    repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã CĐ", 50));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên CĐ", 150));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.MinWidth = 100;
                }
                else column.OptionsColumn.AllowEdit = false;
            }
            //this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell);
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsHardwareTreeListControl_CellValueChanged);
            this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomColumnDisplayText += ProductionNormItemsHardwareTreeListControl_CustomColumnDisplayText;
        }

        private void ProductionNormItemsHardwareTreeListControl_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "FK_MMSemiProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((CarcassBOMModule)Screen.Module).GetSemiProductDisplayDisplayNameText(int.Parse(e.Value.ToString()));
                }
                else
                    e.DisplayText = string.Empty;
            }
            if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", int.Parse(e.Value.ToString()), "MMOperationName");
                }
            }
        }

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            //   MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            TreeListNode node = entity.ProductionNormItemHardwareList.TreeListControl.GetSelectedNode();
            if (node != null)
            {
                //MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                //if (objProductionNormItemsInfo != null)
                //{
                //    ICProductsController objProductsController = new ICProductsController();
                //    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormItemsInfo.FK_ICProductID);
                //    if (objProductsInfo != null)
                //    {
                //        mainObject.MMProductionNormsProductItemPicture = objProductsInfo.ICProductPicture;
                //        entity.UpdateMainObjectBindingSource();
                //    }

                //}
            }
        }
        void ProductionNormItemsHardwareTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            //throw new NotImplementedException();
            string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = entity.ProductionNormItemHardwareList.TreeListControl.GetSelectedNode();
            if (node != null)
            {
                if (columnName.Contains("Quantity") && e.Value.Equals(""))
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                    objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                    if (objProductionNormItemsInfo != null)
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, columnName, 0);
                }
                //else if (columnName == "MMHardwareOperationType")
                //{
                //    MMOperationAndHardwareOperationTypesController ctrl = new MMOperationAndHardwareOperationTypesController();
                //    List<MMOperationAndHardwareOperationTypesInfo> configList
                //        = ctrl.GetOperationByHardwareOperationType(e.Value.ToString());
                //    BOSDbUtil dbUtil = new BOSDbUtil();
                //    MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                //    objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                //    if (objProductionNormItemsInfo != null)
                //    {
                //        MMOperationAndHardwareOperationTypesInfo config = configList.FirstOrDefault();
                //        if (config != null)
                //        {
                //            dbUtil.SetPropertyValue(objProductionNormItemsInfo, "FK_MMOperationID", config.FK_MMOperationID);
                //        }
                //        else
                //        {
                //            dbUtil.SetPropertyValue(objProductionNormItemsInfo, "FK_MMOperationID", 0);
                //        }
                //    }
                //}
                else if (columnName == "FK_ICProductID")
                {
                    MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                    objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                    if (objProductionNormItemsInfo != null)
                    {
                        ICProductsInfo pInfo = BOSApp.GetProductFromCurrentProductList(objProductionNormItemsInfo.FK_ICProductID);

                        if (pInfo != null)
                        {
                            objProductionNormItemsInfo.MMProductionNormItemProductName = pInfo.ICProductName;
                            objProductionNormItemsInfo.MMProductionNormItemProductDesc = pInfo.ICProductDesc;
                            objProductionNormItemsInfo.MMProductionNormItemNo = pInfo.ICProductNo;
                            objProductionNormItemsInfo.FK_ICMeasureUnitID = pInfo.FK_ICProductBasicUnitID;
                            objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking = pInfo.ICProductSizeAndSpecifiCations;
                            this.RefreshDataSource();
                        }
                    }
                }
                else if (columnName == "FK_MMOperationID")
                {
                    MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                    objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                    if (objProductionNormItemsInfo != null)
                    {
                        MMOperationsInfo objOperationsInfo = (MMOperationsInfo)(new MMOperationsController()).GetObjectByID(objProductionNormItemsInfo.FK_MMOperationID);
                        if (objOperationsInfo != null)
                        {
                            objProductionNormItemsInfo.MMOperationName = objOperationsInfo.MMOperationName;
                        }
                    }
                }
                else if (columnName == "MMProductionNormItemDepreciationRate" || columnName == "MMProductionNormItemTotalQuantity")
                {
                    MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                    objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                    if (objProductionNormItemsInfo != null)
                    {
                        objProductionNormItemsInfo.MMProductionNormItemQuantity = objProductionNormItemsInfo.MMProductionNormItemTotalQuantity * objProductionNormItemsInfo.MMProductionNormItemDepreciationRate;
                    }
                    this.RefreshDataSource();
                }
                else if (columnName == "MMProductionNormItemQuantity")
                {
                    MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                    objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                    if (objProductionNormItemsInfo != null)
                    {
                        objProductionNormItemsInfo.MMProductionNormItemTotalQuantity = objProductionNormItemsInfo.MMProductionNormItemQuantity / (objProductionNormItemsInfo.MMProductionNormItemDepreciationRate == 0 ? 1 : objProductionNormItemsInfo.MMProductionNormItemDepreciationRate);
                    }
                    this.RefreshDataSource();
                }
                else if (e.Column.FieldName == "MMHardwareOperationType")
                {
                    MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
                    if (objProductionNormItemsInfo != null)
                    {
                        try
                        {
                            string mathString = objProductionNormItemsInfo.MMHardwareOperationType.Trim().Replace(" ", string.Empty).Replace("=", string.Empty);
                            DataTable dt = new DataTable();
                            objProductionNormItemsInfo.MMProductionNormItemTotalQuantity = Convert.ToDecimal(dt.Compute(mathString, String.Empty));
                            objProductionNormItemsInfo.MMProductionNormItemQuantity = objProductionNormItemsInfo.MMProductionNormItemTotalQuantity * objProductionNormItemsInfo.MMProductionNormItemDepreciationRate;
                        }
                        catch
                        {
                            MessageBox.Show("Công thức tính số lượng không đúng định dạng." + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
                        }
                    }
                    this.RefreshDataSource();
                }
            }
        }
        private void ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                if (e.CellValue != null)
                {
                    int measureUnitID = int.Parse(e.CellValue.ToString());
                    e.CellText = BOSApp.GetDisplayTextFromCatche(TableName.ICMeasureUnitsTableName, "ICMeasureUnitID", measureUnitID, "ICMeasureUnitName");
                }
            }

            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.CellValue != null)
                {
                    int productID = int.Parse(e.CellValue.ToString());
                    e.CellText = BOSApp.GetDisplayTextFromCatche(TableName.ICProductsTableName, "ICProductID", productID, "ICProductNo");

                }
            }
        }
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            //Columns.Clear();
            //#region InitTreeListColumns
            //AddTreeListColumns(1, ProductionNormConst.MMProductionNormItemSortOrder, false, true);
            //AddTreeListColumns(2, ProductionNormConst.MMProductionNormItemICProductName, false, false);
            //AddTreeListColumns(3, "FK_MMSemiProductID", false, true);
            //AddTreeListColumns(4, "FK_ICProductID", false, false);
            //AddTreeListColumns(5, "MMProductionNormItemProductSizeAndPacking", false, false);
            //AddTreeListColumns(6, "MMProductionNormItemProductDesc", false, false);
            //AddTreeListColumns(7, ProductionNormConst.FK_ICMeasureUnitID, false, true);
            //AddTreeListColumns(8, "FK_MMOperationID", false, true);
            //AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemQuantity, false, true);
            //#endregion
            TreeListColumn column = this.Columns["FK_MMSemiProductID"];
            if (column != null)
            {
                List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMProductionNormItemProductName";
                repositoryItemLookUpEdit.ValueMember = "MMProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductCode", "Mã code", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(semiProductItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Thuộc chi tiết";
                column.MinWidth = 150;
            }
            column = this.Columns["MMHardwareOperationType"];
            if (column != null)
            {
                column.Visible = true;
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemTextEdit.ToString());
                column.OptionsColumn.AllowEdit = true;
            }
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.ColumnByFieldName(fieldName);
            if (column == null)
            {
                column = Columns.Add();
            }

            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;

            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;
            if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 70;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemICProductName)
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNameHardware;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 250;
                column.BestFit();
            }

            if (fieldName == ProductionNormConst.MMProductionNormItemNo)
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoHardware;
                column.Width = 350;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                //column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemQuantity)
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n5}";
            }
            if (fieldName == "MMProductionNormItemHardware")
            {
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                column.Caption = "Chi tiết cấp phát";
                rpItemComponent.NullText = "Chi tiết";
                rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
                this.RepositoryItems.Add(rpItemComponent);
            }
            if (fieldName == "FK_MMSemiProductID")
            {
                List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMProductionNormItemProductName";
                repositoryItemLookUpEdit.ValueMember = "MMProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductCode", "Mã code", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(semiProductItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Thuộc chi tiết";
                column.MinWidth = 150;
            }
            if (fieldName == "FK_ICMeasureUnitID")
            {
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "Tên ĐVT", 300));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repMeasureUnit_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
            }
            //if (fieldName == "FK_MMOperationID")
            //{
            //    List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            //    repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
            //    repositoryItemLookUpEdit.ValueMember = "MMOperationID";
            //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //    repositoryItemLookUpEdit.NullText = string.Empty;
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã CĐ", 50));
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên CĐ", 150));
            //    repositoryItemLookUpEdit.DataSource = semiProductDatasource;
            //    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.MinWidth = 100;
            //}
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            //Get Caption
            List<AAColumnAliasInfo> listAlias = BOSApp.LstColumnAlias.Where(a => a.AATableName == TableName.MMProductionNormItemsTableName).ToList();
            if (listAlias != null)
            {
                foreach (AAColumnAliasInfo objAAColumnAliasInfo in listAlias)
                {
                    if (objAAColumnAliasInfo != null)
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                        {
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                        }
                        if (fieldName == "MMProductionNormItemComment")
                        {
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                            column.OptionsColumn.AllowEdit = true;
                            column.OptionsColumn.ReadOnly = false;
                        }
                        if (fieldName == "MMProductionNormItemHardwareAllocationQuantity")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareSubForSets;
                        if (fieldName == "MMProductionNormItemProductSizeAndPacking")
                            column.Caption = ProductionNormLocalizeResources.MMHardwareItemSpecification;
                        if (fieldName == "MMProductionNormItemProductDesc")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttributeCaption;
                        if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
                        {
                            column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                        }
                        if (fieldName == "MMProductionNormItemHardwareAssembleQuantity")
                        {
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareAssembleTotalQuantityCaption;
                        }
                    }

                }
            }
            if (fieldName == "FK_ICProductID")
            {
                column.Caption = "Mã vật tư";
            }
            if (fieldName == "MMProductionNormItemProductLength"
               || fieldName == "MMProductionNormItemProductHeight" || fieldName == "MMProductionNormItemProductWidth"
               || fieldName == ProductionNormConst.MMProductionNormItemTotalQuantity || fieldName == ProductionNormConst.MMProductionNormItemDepreciationRate
               || fieldName == ProductionNormConst.MMProductionNormItemActualDepreciationRate || fieldName == "MMProductionNormItemHardwareAssembleQuantity"
               || fieldName == "MMProductionNormItemHardwareAllocationQuantity" || fieldName == "MMProductionNormItemPackagingGW"
               || fieldName == "MMProductionNormItemPackagingNW" || fieldName == "MMProductionNormItemPackagingAllocationTotalQuantity"
               || fieldName == "MMProductionNormItemProductOverallDimensionHeight" || fieldName == "MMProductionNormItemProductOverallDimensionWidth"
               || fieldName == "MMProductionNormItemProductOverallDimensionLength" || fieldName == "MMProductionNormItemProductInsideDimensionHeight"
               || fieldName == "MMProductionNormItemProductInsideDimensionWidth" || fieldName == "MMProductionNormItemProductInsideDimensionLength"
               )
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
            }
            if (fieldName == "MMHardwareOperationType")
            {
                column.OptionsColumn.AllowEdit = true;
            }
            this.EndUpdate();
            this.Update();
        }
        void repMeasureUnit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.ICMeasureUnitsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.ICMeasureUnitsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    lookUpEdit.Properties.DataSource = ds.Tables[0];
                }
            }


        }

        void semiProductItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
        }
        public void reqOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    MMOperationsController control = new MMOperationsController();
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
        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
            ((CarcassBOMModule)Screen.Module).ShowProductionNormItemHardwareDetail(objProductionNormItemsInfo);
        }
        //void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
        //    List<ICMeasureUnitsInfo> ds = objMeasureUnitsController.GetAllAliveMeasureUnit();

        //    lookUpEdit.Properties.DataSource = ds;
        //}
        //private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

        //    TreeListNode node = entity.ProductionNormItemHardwareList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;

        //        if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            ((CarcassBOMModule)Screen.Module).InvalidateProductionNormInventoryStockGridControl(objProductionNormItemsInfo.FK_ICProductID, ProductType.Hardware.ToString());
        //    }
        //}
        //public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((CarcassBOMModule)Screen.Module).GetMeasureUnit();
        //    lookUpEdit.Properties.DataSource = dt;
        //}

    }
}

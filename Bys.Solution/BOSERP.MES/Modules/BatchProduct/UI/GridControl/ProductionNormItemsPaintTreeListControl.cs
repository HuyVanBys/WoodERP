using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.BatchProduct
{
    public partial class ProductionNormItemsPaintTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties

        #endregion

        protected override void InitTreeListDataSource()
        {
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductionNormItemPaintList;
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

            //  this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell);
            this.CustomColumnDisplayText += ProductionNormItemsPaintTreeListControl_CustomColumnDisplayText;
            #region Custome Col
            TreeListColumn column = this.Columns["FK_MMBPSemiProductID"];
            if (column != null)
            {
                List<MMBatchProductProductionNormItemsInfo> semiProductDatasource = ((BatchProductModule)Screen.Module).GetBPSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMBatchProductProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMBatchProductProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = this.Columns["MMBatchProductProductionNormItemWoodBlocks"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "N5");
            }
            column = this.Columns["MMBatchProductProductionNormItemBlocks"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "N5");
            }
            column = this.Columns["MMBatchProductProductionNormItemBlockPerOne"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "N5");
            }
            #endregion
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            //Columns.Clear();
            // #region InitTreeListColumns

            // AddTreeListColumns(1, "MMBatchProductProductionNormItemPackagingGW", true, false);
            // AddTreeListColumns(2, "MMBatchProductProductionNormItemPackagingNW", true, false);
            // AddTreeListColumns(3, "MMBatchProductProductionNormItemNo", true, false);
            // AddTreeListColumns(4, "FK_MMProductionNormItemID", true, false);
            // AddTreeListColumns(5, "FK_MMBPSemiProductID", true, false);
            // AddTreeListColumns(6, "MMBatchProductProductionNormItemProductName", true, false);
            //// AddTreeListColumns(3, ProductionNormConst.MMProductionNormItemPaintICDepartmentAttribute1, true, false);
            // AddTreeListColumns(7, "MMBatchProductProductionNormItemProductSupplierNumber", false, true);
            // AddTreeListColumns(8, "MMBatchProductProductionNormItemPaintMixRatio", false, true);
            // AddTreeListColumns(9, "MMBatchProductProductionNormItemQuantity", false, true);
            // AddTreeListColumns(10, ProductionNormConst.FK_ICMeasureUnitID, false, true);
            // AddTreeListColumns(11, "FK_MMOperationID", false, true);
            // AddTreeListColumns(12, ProductionNormConst.FK_APSupplierID, false, true);
            // AddTreeListColumns(13, "MMBatchProductProductionNormItemComment", false, true);
            // AddTreeListColumns(14, "MMBatchProductProductionNormItemModifiedStatus", false, true);
            // AddTreeListColumns(15, "MMBatchProductProductionNormItemNeededTime", true, true);
            // AddTreeListColumns(16, "AACreatedDate", false, true);

            // //AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemTotalQuantity, false, true);
            // //AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemNeededTime, false, false);

            // #endregion
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        {
            this.BeginUpdate();
            //TNDLoc [ADD][28/11/2015][Allow edit for only Qty],START
            readOnly = true;
            AllowEdit = false;
            //TNDLoc [ADD][28/11/2015][Allow edit for only Qty],END
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
            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> dsColumns = BOSApp.LstColumnAlias.Where(a => a.AATableName == TableName.MMBatchProductProductionNormItemsTableName).ToList();
            if (dsColumns.Count() > 0)
            {
                foreach (AAColumnAliasInfo objAAColumnAliasInfo in dsColumns)
                {
                    //AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    if (objAAColumnAliasInfo != null)
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                        {
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                        }
                        if (fieldName == "MMBatchProductProductionNormItemComment")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                        if (fieldName == "MMBatchProductProductionNormItemPaintMixRatio")
                            column.Caption = "Tỉ lệ pha";
                        if (fieldName == "MMBatchProductProductionNormItemModifiedStatus")
                            column.Caption = "Trạng thái thay đổi";
                        if (fieldName == "FK_MMProductionNormItemID")
                            column.Caption = "Mã tham chiếu BDM";
                        if (fieldName == "AACreatedDate")
                            column.Caption = "Ngày tạo";
                        if (fieldName == "MMBatchProductProductionNormItemPackagingGW")
                            column.Caption = "Quy trình sơn";

                        if (fieldName == "MMBatchProductProductionNormItemPackagingNW")
                            column.Caption = "Bước";

                    }
                }
            }

            //TNDLoc [ADD][28/11/2015][Allow edit for only Qty],START
            if (fieldName == "MMBatchProductProductionNormItemQuantity")
            {
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
            }
            //TNDLoc [ADD][28/11/2015][Allow edit for only Qty],END
            //if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
            //{
            //    column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
            //    column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            //    column.Width = 70;
            //    column.BestFit();
            //}
            if (fieldName == "MMBatchProductProductionNormItemPackagingGW")
            {

                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 200;
                column.BestFit();
            }
            if (fieldName == "MMBatchProductProductionNormItemPackagingNW")
            {

                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 200;
                column.BestFit();
            }
            if (fieldName == "FK_MMProductionNormItemID")
            {
                column.Caption = "Mã tham chiếu BDM";
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 200;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.FK_APSupplierID)
            {
                //column.VisibleIndex = visibleIndex;
                //column.FieldName = fieldName;
                //column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNamePaint;
                //column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                //column.BestFit();
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "APSupplierName";
                //repositoryItemLookUpEdit.ValueMember = "APSupplierID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("APSupplierName", "Tên NCC"));
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 100;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "MMBatchProductProductionNormItemNo")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoPaint;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == "MMBatchProductProductionNormItemProductSupplierNumber")
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductSupplierNumber;
            if (fieldName == "MMBatchProductProductionNormItemProductSupplierName")
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductSupplierName;

            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = false;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                //repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                //  repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 50;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "FK_MMBPSemiProductID")
            {
                List<MMBatchProductProductionNormItemsInfo> semiProductDatasource = ((BatchProductModule)Screen.Module).GetBPSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMBatchProductProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMBatchProductProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Thuộc chi tiết";
                column.MinWidth = 150;
            }
            this.EndUpdate();
            this.Update();
        }

        private void ProductionNormItemsPaintTreeListControl_CustomColumnDisplayText(object sender, DevExpress.XtraTreeList.CustomColumnDisplayTextEventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "FK_MMBPSemiProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((BatchProductModule)Screen.Module).GetBPSemiProductDisplayDisplayText(int.Parse(e.Value.ToString()));
                }
                else
                    e.DisplayText = string.Empty;
            }
        }
        //private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

        //    TreeListNode node = entity.ProductionNormItemPaintList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemPaintList.CurrentObject;

        //        if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            ((ProductionNormModule)Screen.Module).InvalidateProductionNormInventoryStockGridControl(objProductionNormItemsInfo.FK_ICProductID, ProductType.Hardware.ToString());
        //    }
        //}
        //public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((ProductionNormModule)Screen.Module).GetMeasureUnit();
        //    lookUpEdit.Properties.DataSource = dt;
        //}

        private void ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", value, "ICMeasureUnitName");
                    }
                }
            }
            if (e.Column.FieldName == ProductionNormConst.FK_APSupplierID)
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = BOSApp.GetDisplayTextFromCatche("APSuppliers", "APSupplierID", value, "APSupplierName");
                    }
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity")
            {
                if (e.CellValue != null)
                {
                    double value = 0;
                    if (Double.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = value.ToString("N5");
                    }
                }
            }
        }
    }
}

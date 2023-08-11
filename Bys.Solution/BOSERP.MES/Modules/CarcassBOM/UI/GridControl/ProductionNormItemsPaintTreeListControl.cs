using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductionNormItemsPaintTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        MMAllocationOperationConfigsInfo DefualtAOConfigs { get; set; }
        #endregion

        DataTable SupplierDataTable = null;

        protected override void InitTreeListDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductionNormItemPaintList;
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = false;
            this.BOSDisplayOption = true;
            this.ForceInitialize();
            this.BestFitColumns();
            this.FocusedColumnChanged += new DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(ProductionNormItemsPaintTreeListControl_FocusedColumnChanged);
            this.FocusedNodeChanged += new FocusedNodeChangedEventHandler(ProductionNormItemsPaintTreeListControl_FocusedNodeChanged);
            this.CustomColumnDisplayText += ProductionNormItemsPaintTreeListControl_CustomColumnDisplayText;
            this.CellValueChanged += new CellValueChangedEventHandler(ProductionNormItemsPaintTreeListControl_CellValueChanged);
            SupplierDataTable = ((CarcassBOMModule)Screen.Module).GetAPSupplier();
            DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
            TreeListColumn column = this.Columns["FK_MMOperationID"];
            if (column != null)
            {
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
        }
        private void ProductionNormItemsPaintTreeListControl_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
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
            if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", int.Parse(e.Value.ToString()), "MMOperationName");
                }
            }
        }

        private void ProductionNormItemsPaintTreeListControl_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            SetValueToList(e.Node, e.Column, e.Value);
        }

        public void SetValueToList(TreeListNode treeListNode, TreeListColumn treeListColumn, object value)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in treeListNode.Nodes)
            {
                Child.SetValue(treeListColumn, value);
                if (Child.HasChildren)
                {
                    SetValueToList(Child, treeListColumn, value);
                }
            }
        }

        void ProductionNormItemsPaintTreeListControl_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            //if (this.Columns["MMProductionNormItemPaint"] != null)
            //{
            //    if (((CarcassBOMModule)Screen.Module).IsPaintProcessNode())
            //    {
            //        this.Columns["MMProductionNormItemPaint"].OptionsColumn.AllowEdit = true;
            //        this.Columns["MMProductionNormItemPaint"].OptionsColumn.ReadOnly = false;
            //    }
            //    else
            //    {

            //        this.Columns["MMProductionNormItemPaint"].OptionsColumn.AllowEdit = false;
            //        this.Columns["MMProductionNormItemPaint"].OptionsColumn.ReadOnly = true;
            //    }
            //}
        }

        void ProductionNormItemsPaintTreeListControl_FocusedColumnChanged(object sender, DevExpress.XtraTreeList.FocusedColumnChangedEventArgs e)
        {
            //if (e.Column != null && e.Column.FieldName == "MMProductionNormItemPaint")
            //{
            //    if (((CarcassBOMModule)Screen.Module).IsPaintProcessNode())
            //    {
            //        e.Column.OptionsColumn.AllowEdit = true;
            //        e.Column.OptionsColumn.ReadOnly = false;
            //    }
            //    else
            //    {

            //        e.Column.OptionsColumn.AllowEdit = false;
            //        e.Column.OptionsColumn.ReadOnly = true;
            //    }


            //}
        }



        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            #region InitTreeListColumns
            EnableColumns(1, ProductionNormConst.MMProductionNormItemICProductName, true, false, false, string.Empty);
            EnableColumns(2, ProductionNormConst.MMProductionNormItemNo, true, false, false, string.Empty);
            EnableColumns(3, "FK_MMSemiProductID", false, true);
            EnableColumns(4, "MMProductionNormItemPaint", false, true, false, "{0:n5}");
            EnableColumns(5, "MMProductionNormItemProductSupplierNumber", false, true, false, string.Empty);
            EnableColumns(6, "MMProductionNormItemPaintMixRatio", false, true, false, string.Empty);
            //EnableColumns(7, ProductionNormConst.MMProductionNormItemTotalQuantity, false, true, false, "{0:n5}");
            EnableColumns(7, ProductionNormConst.MMProductionNormItemQuantity, false, true);
            //EnableColumns(7, ProductionNormConst.MMProductionNormItemDepreciationRate, false, true, false, "{0:n2}");
            EnableColumns(9, ProductionNormConst.FK_ICMeasureUnitID, false, true, true, string.Empty);
            EnableColumns(10, "FK_APSupplierID", false, true, false, string.Empty);
            EnableColumns(11, "FK_MMOperationID", false, true);
            EnableColumns(12, "MMProductionNormItemResourceType", false, true);
            EnableColumns(13, "MMProductionNormItemPaintExecuteMethod", false, true);
            #endregion
        }

        public void EnableColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
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
                            if (fieldName == ProductionNormConst.MMProductionNormItemDesc)
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                            //if (fieldName == "MMProductionNormItemProductAttributeValue1")
                            //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttributeCaption;
                        }
                    }
                }
            }
            if (fieldName == "FK_MMSemiProductID")
            {
                List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMProductionNormItemNo";
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
            if (fieldName == "FK_MMOperationID")
            {

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
            if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                //column.Width = 70;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemICProductName)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNamePaint;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemNo)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoPaint;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 350;
                //column.BestFit();
            }
            if (fieldName == "MMProductionNormItemProductSupplierNumber")
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductSupplierNumber;
            if (fieldName == "FK_APSupplierID")
            {
                column.OptionsColumn.AllowEdit = true;
            }
            if (fieldName == "MMProductionNormItemPaintMixRatio")
            {
                column.Caption = "Tỉ lệ pha";
            }
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemQuantity || fieldName == "MMProductionNormItemProductLength"
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
            if (fieldName == "MMProductionNormItemQuantity")
            {
                column.Caption = "Số lượng";
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n5}";
            }
            if (fieldName == "MMProductionNormItemPaintExecuteMethod")
            {
                column.Caption = "Phương pháp thực hiện";
            }    
            this.EndUpdate();
            this.Update();
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
        private void semiProductItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
        }

        private string GetOperationDisplayDisplayText(int operationID)
        {
            if (!BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
                return string.Empty;

            DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
            if (ds == null && ds.Tables.Count == 0)
                return string.Empty;

            MMOperationsController control = new MMOperationsController();
            List<MMOperationsInfo> operationList = (List<MMOperationsInfo>)control.GetListFromDataSet(ds);
            if (operationList == null)
                return string.Empty;

            MMOperationsInfo objOperationsInfo = operationList.FirstOrDefault(o => o.MMOperationIsPlan && o.MMOperationID == operationID);
            if (objOperationsInfo == null)
                return string.Empty;

            return objOperationsInfo.MMOperationName;
        }
    }
}

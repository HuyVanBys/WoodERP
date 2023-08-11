using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System.Data;

namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public partial class ProductionNormItemsPaintTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties

        #endregion

        protected override void InitTreeListDataSource()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.PaintList;
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = true;
            this.BOSDisplayOption = true;
            this.OptionsView.ShowSummaryFooter = true;
            this.BestFitColumns();
            this.FocusedColumnChanged += new DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(ProductionNormItemsPaintTreeListControl_FocusedColumnChanged);
            this.FocusedNodeChanged += new FocusedNodeChangedEventHandler(ProductionNormItemsPaintTreeListControl_FocusedNodeChanged);
            //  this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            //this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell);
        }

        void ProductionNormItemsPaintTreeListControl_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.Columns["MMCalculatorProductionNormItemPaint"] != null)
            {
                if (((CalculatorProductionNormCostModule)Screen.Module).IsPaintProcessNode())
                {
                    this.Columns["MMCalculatorProductionNormItemPaint"].OptionsColumn.AllowEdit = true;
                    this.Columns["MMCalculatorProductionNormItemPaint"].OptionsColumn.ReadOnly = false;
                }
                else
                {

                    this.Columns["MMCalculatorProductionNormItemPaint"].OptionsColumn.AllowEdit = false;
                    this.Columns["MMCalculatorProductionNormItemPaint"].OptionsColumn.ReadOnly = true;
                }
            }
        }

        void ProductionNormItemsPaintTreeListControl_FocusedColumnChanged(object sender, DevExpress.XtraTreeList.FocusedColumnChangedEventArgs e)
        {
            if (e.Column.FieldName == "MMCalculatorProductionNormItemPaint")
            {
                if (((CalculatorProductionNormCostModule)Screen.Module).IsPaintProcessNode())
                {
                    e.Column.OptionsColumn.AllowEdit = true;
                    e.Column.OptionsColumn.ReadOnly = false;
                }
                else
                {

                    e.Column.OptionsColumn.AllowEdit = false;
                    e.Column.OptionsColumn.ReadOnly = true;
                }


            }
        }



        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns
            // AddTreeListColumns(0, CalculationProductionNormConst.MMCalculatorProductionNormItemSortOrder, false, true);
            AddTreeListColumns(1, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName, true, false);
            AddTreeListColumns(2, CalculationProductionNormConst.MMCalculatorProductionNormItemNo, true, false);

            AddTreeListColumns(3, "MMCalculatorProductionNormItemPaint", false, true);
            // AddTreeListColumns(3, "MMCalculatorProductionNormItemProductAttributeValue1", true, false);
            AddTreeListColumns(4, "MMCalculatorProductionNormItemProductSupplierNumber", false, true);
            AddTreeListColumns(11, "MMCalculatorProductionNormItemPaintMixRatio", false, true);
            AddTreeListColumns(5, CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity, false, true);
            AddTreeListColumns(6, "MMCalculatorProductionNormItemProductUnitCost", false, true);
            AddTreeListColumns(7, "MMCalculatorProductionNormItemTotalCost", true, false);
            AddTreeListColumns(8, CalculationProductionNormConst.FK_ICMeasureUnitID, false, true);
            //AddTreeListColumns(7, "MMCalculatorProductionNormItemProductSupplierName", false, true);
            AddTreeListColumns(9, "FK_APSupplierID", false, true);
            //AddTreeListColumns(10, CalculationProductionNormConst.MMCalculatorProductionNormItemDesc, false, true);

            //AddTreeListColumns(11, CalculationProductionNormConst.MMCalculatorProductionNormItemPaintPerOne, false, true);
            //AddTreeListColumns(8, CalculationProductionNormConst.MMCalculatorProductionNormItemTotalQuantity, false, true);
            //AddTreeListColumns(9, CalculationProductionNormConst.MMCalculatorProductionNormItemNeededTime, false, false);

            #endregion
            this.OptionsView.ShowSummaryFooter = true;
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;

            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;
            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName("MMCalculatorProductionNormItems");
            if (dsColumns.Tables.Count > 0)
            {
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    if (objAAColumnAliasInfo != null)
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                        {
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemDesc)
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                            //if (fieldName == "MMCalculatorProductionNormItemProductAttributeValue1")
                            //    column.Caption = ProductionNormLocalizeResources.MMCalculatorProductionNormItemSemiProductDepartmentAttributeCaption;
                        }
                    }
                }
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemSortOrder)
            {
                column.Caption = CalculationProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                //column.Width = 70;
                column.BestFit();
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNamePaint;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemNo)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoPaint;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 350;
                //column.BestFit();
            }
            if (fieldName == "MMCalculatorProductionNormItemProductSupplierNumber")
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductSupplierNumber;
            if (fieldName == "FK_APSupplierID")
            {
                //column.Caption = ProductionNormLocalizeResources.APSupplierName;
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
                //column.MinWidth = 100;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "MMCalculatorProductionNormItemPaintMixRatio")
            {
                column.Caption = "Tỉ lệ pha";
            }
            if (fieldName == CalculationProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = true;
                //  RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //  repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                //  repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                //  repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //  repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //  repositoryItemLookUpEdit.NullText = string.Empty;
                //  repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                ////  repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                //  column.ColumnEdit = repositoryItemLookUpEdit;
                //  column.MinWidth = 50;
                //  this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity || fieldName == "MMCalculatorProductionNormItemProductLength"
               || fieldName == "MMCalculatorProductionNormItemProductHeight" || fieldName == "MMCalculatorProductionNormItemProductWidth"
               || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemTotalQuantity || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemDepreciationRate
               || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemActualDepreciationRate || fieldName == "MMCalculatorProductionNormItemHardwareAssembleQuantity"
               || fieldName == "MMCalculatorProductionNormItemHardwareAllocationQuantity" || fieldName == "MMCalculatorProductionNormItemPackagingGW"
               || fieldName == "MMCalculatorProductionNormItemPackagingNW" || fieldName == "MMCalculatorProductionNormItemPackagingAllocationTotalQuantity"
               || fieldName == "MMCalculatorProductionNormItemProductOverallDimensionHeight" || fieldName == "MMCalculatorProductionNormItemProductOverallDimensionWidth"
               || fieldName == "MMCalculatorProductionNormItemProductOverallDimensionLength" || fieldName == "MMCalculatorProductionNormItemProductInsideDimensionHeight"
               || fieldName == "MMCalculatorProductionNormItemProductInsideDimensionWidth" || fieldName == "MMCalculatorProductionNormItemProductInsideDimensionLength"
               )
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
                column.AllNodesSummary = true;
                column.SummaryFooter = SummaryItemType.Sum;
                column.RowFooterSummaryStrFormat = CalculationProductionNormConst.ProducttionNormFormatN4;
            }

            if (fieldName == "MMCalculatorProductionNormItemProductUnitCost"
                || fieldName == "MMCalculatorProductionNormItemTotalCost")
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
                column.AllNodesSummary = true;
                column.SummaryFooter = SummaryItemType.Sum;
                column.RowFooterSummaryStrFormat = CalculationProductionNormConst.ProducttionNormFormatN4;
            }

            dsColumns.Dispose();
            this.EndUpdate();
            this.Update();
        }
        //private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

        //    TreeListNode node = entity.ProductionNormItemPaintList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemPaintList.CurrentObject;

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
        public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataTable dt = ((CalculatorProductionNormCostModule)Screen.Module).GetAPSupplier();
            lookUpEdit.Properties.DataSource = dt;
        }
        //private void ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        //{
        //    if (e.Column.FieldName == CalculationProductionNormConst.FK_ICMeasureUnitID)
        //    {
        //        if (e.CellValue != null)
        //        {
        //            int value = 0;
        //            if (int.TryParse(e.CellValue.ToString(), out value))
        //            {
        //                ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
        //                ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(value);
        //                if (objMeasureUnitsInfo != null)
        //                    e.CellText = objMeasureUnitsInfo.ICMeasureUnitName;
        //            }
        //        }
        //    }
        //    if (e.Column.FieldName == "FK_APSupplierID")
        //    {
        //        if (e.CellValue != null)
        //        {
        //            int value = 0;
        //            if (int.TryParse(e.CellValue.ToString(), out value))
        //            {
        //                APSuppliersController objSuppliersController = new APSuppliersController();
        //                APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(value);
        //                if (objSuppliersInfo != null)
        //                    e.CellText = objSuppliersInfo.APSupplierName;
        //            }
        //        }
        //    }
        //}
    }
}

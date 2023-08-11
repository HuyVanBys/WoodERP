using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductionNormItemsPaintPopUpTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties

        #endregion

        DataTable SupplierDataTable = null;

        protected override void InitTreeListDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductionNormItemPaintPopUpList;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = true;
            this.BOSDisplayOption = true;
            this.BestFitColumns();
            this.FocusedColumnChanged += new DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(ProductionNormItemsPaintPopUpTreeListControl_FocusedColumnChanged);
            this.FocusedNodeChanged += new FocusedNodeChangedEventHandler(ProductionNormItemsPaintPopUpTreeListControl_FocusedNodeChanged);
            //  this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            //this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPaintPopUpTreeListControl_CustomDrawNodeCell);
            SupplierDataTable = ((CarcassBOMModule)Screen.Module).GetAPSupplier();
        }

        void ProductionNormItemsPaintPopUpTreeListControl_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.Columns["MMProductionNormItemPaint"] != null)
            {
                if (((CarcassBOMModule)Screen.Module).IsPaintProcessNodePopUp())
                {
                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.AllowEdit = true;
                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.ReadOnly = false;
                }
                else
                {

                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.AllowEdit = false;
                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.ReadOnly = true;
                }
            }
        }

        void ProductionNormItemsPaintPopUpTreeListControl_FocusedColumnChanged(object sender, DevExpress.XtraTreeList.FocusedColumnChangedEventArgs e)
        {
            if (e.Column.FieldName == "MMProductionNormItemPaint")
            {
                if (((CarcassBOMModule)Screen.Module).IsPaintProcessNodePopUp())
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
            //Columns.Clear();
            #region InitTreeListColumns
            // AddTreeListColumns(0, ProductionNormConst.MMProductionNormItemSortOrder, false, true);
            AddTreeListColumns(1, ProductionNormConst.MMProductionNormItemICProductName, true, false);
            AddTreeListColumns(2, ProductionNormConst.MMProductionNormItemNo, true, false);

            AddTreeListColumns(3, "MMProductionNormItemPaint", false, true);
            // AddTreeListColumns(3, "MMProductionNormItemProductAttributeValue1", true, false);
            AddTreeListColumns(4, "MMProductionNormItemProductSupplierNumber", false, true);
            AddTreeListColumns(9, "MMProductionNormItemPaintMixRatio", false, true);
            AddTreeListColumns(5, ProductionNormConst.MMProductionNormItemQuantity, false, true);
            AddTreeListColumns(6, ProductionNormConst.FK_ICMeasureUnitID, false, true);
            //AddTreeListColumns(7, "MMProductionNormItemProductSupplierName", false, true);
            AddTreeListColumns(7, "FK_APSupplierID", false, true);
            //AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemDesc, false, true);

            //AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemPaintPerOne, false, true);
            //AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemTotalQuantity, false, true);
            //AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemNeededTime, false, false);

            #endregion
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
            if (fieldName == "MMProductionNormItemPaintMixRatio")
            {
                column.Caption = "Tỉ lệ pha";
            }
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
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

            this.EndUpdate();
            this.Update();
        }

        //public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    lookUpEdit.Properties.DataSource = SupplierDataTable;
        //}
        //private void ProductionNormItemsPaintPopUpTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        //{
        //    if (e.Column.FieldName == ProductionNormConst.FK_ICMeasureUnitID)
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

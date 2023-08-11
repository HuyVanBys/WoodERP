using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public partial class ProductionNormItemsHardwareTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.HardwareList;
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

            //this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell);
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsHardwareTreeListControl_CellValueChanged);
            this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
        }

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            //   CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ////   MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            //   TreeListNode node = entity.ProductionNormItemHardwareList.TreeListControl.GetSelectedNode();
            //   if (node != null)
            //   {
            //       MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
            //       if (objProductionNormItemsInfo != null)
            //       {
            //           ICProductsController objProductsController = new ICProductsController();
            //           ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormItemsInfo.FK_ICProductID);
            //           if (objProductsInfo != null)
            //           {
            //               //mainObject.MMProductionNormsProductItemPicture = objProductsInfo.ICProductPicture;
            //               entity.UpdateMainObjectBindingSource();
            //           }

            //       }
            //   }
        }
        void ProductionNormItemsHardwareTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            ((CalculatorProductionNormCostModule)Screen.Module).UpdateTotalCostHW(true);
        }
        private void ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == CalculationProductionNormConst.FK_ICMeasureUnitID)
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                        ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(value);
                        if (objMeasureUnitsInfo != null)
                            e.CellText = objMeasureUnitsInfo.ICMeasureUnitName;
                    }
                }
            }
        }
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns
            AddTreeListColumns(1, CalculationProductionNormConst.MMCalculatorProductionNormItemSortOrder, false, true);
            AddTreeListColumns(2, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName, true, false);
            AddTreeListColumns(3, CalculationProductionNormConst.MMCalculatorProductionNormItemNo, true, false);
            AddTreeListColumns(4, "MMCalculatorProductionNormItemProductSizeAndPacking", true, false);
            AddTreeListColumns(5, "MMCalculatorProductionNormItemProductDesc", true, false);
            AddTreeListColumns(6, CalculationProductionNormConst.FK_ICMeasureUnitID, false, true);
            AddTreeListColumns(7, "MMHardwareOperationType", false, true);
            //AddTreeListColumns(8, "MMCalculatorProductionNormItemHardwareAllocationQuantity", false, true);
            AddTreeListColumns(8, CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity, false, true);
            //AddTreeListColumns(9, "MMCalculatorProductionNormItemHardwareAssembleQuantity", false, true);

            AddTreeListColumns(90, "MMCalculatorProductionNormItemProductUnitCost", false, true);
            AddTreeListColumns(10, "MMCalculatorProductionNormItemTotalCost", true, false);
            AddTreeListColumns(11, "MMCalculatorProductionNormItemComment", false, true);

            #endregion
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
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemSortOrder)
            {
                column.Caption = CalculationProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 70;
                column.BestFit();
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName)
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNameHardware;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 250;
                column.BestFit();
            }

            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemNo)
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoHardware;
                column.Width = 350;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                //column.BestFit();
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity)
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
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
            if (fieldName == "MMCalculatorProductionNormItemHardware")
            {
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                column.Caption = "Chi tiết cấp phát";
                rpItemComponent.NullText = "Chi tiết";
                rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
                this.RepositoryItems.Add(rpItemComponent);
            }
            if (fieldName == "MMHardwareOperationType")
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                //repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Công đoạn"));
                //// repositoryItemLookUpEdit.QueryPopUp +=new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                //ADReportsController reportCtrl = new ADReportsController();
                //List<ADConfigValuesInfo> configList = reportCtrl.GetObjectByADConfigKeyGroup(ConfigValueGroup.HardwareOperationType);
                //repositoryItemLookUpEdit.DataSource = configList;
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 50;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            if (fieldName == CalculationProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                //repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                // repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 50;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
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
                        }
                        if (fieldName == "MMCalculatorProductionNormItemComment")
                        {
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                            column.OptionsColumn.AllowEdit = true;
                            column.OptionsColumn.ReadOnly = false;
                        }
                        if (fieldName == "MMCalculatorProductionNormItemHardwareAllocationQuantity")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareSubForSets;
                        //if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity)
                        //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareQuantity;
                        if (fieldName == "MMCalculatorProductionNormItemProductSizeAndPacking")
                            column.Caption = ProductionNormLocalizeResources.MMHardwareItemSpecification;
                        if (fieldName == "MMCalculatorProductionNormItemProductDesc")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttributeCaption;
                        if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemSortOrder)
                        {
                            column.Caption = CalculationProductionNormConst.MMProductionNormOrderNoCaption;
                        }
                        if (fieldName == "MMCalculatorProductionNormItemHardwareAssembleQuantity")
                        {
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareAssembleTotalQuantityCaption;
                        }
                    }

                }
            }
            dsColumns.Dispose();
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
            }
            this.OptionsView.ShowSummaryFooter = true;
            this.EndUpdate();
            this.Update();
        }


        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            //CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((CalculatorProductionNormCostModule)Screen.Module).CurrentModuleEntity;
            //MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
            //((CalculatorProductionNormCostModule)Screen.Module).ShowProductionNormItemHardwareDetail(objProductionNormItemsInfo);
        }
        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> ds = objMeasureUnitsController.GetAllAliveMeasureUnit();

            lookUpEdit.Properties.DataSource = ds;
        }
        //private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

        //    TreeListNode node = entity.ProductionNormItemHardwareList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;

        //        if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            ((CalculatorProductionNormCostModule)Screen.Module).InvalidateProductionNormInventoryStockGridControl(objProductionNormItemsInfo.FK_ICProductID, ProductType.Hardware.ToString());
        //    }
        //}
        //public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((CalculatorProductionNormCostModule)Screen.Module).GetMeasureUnit();
        //    lookUpEdit.Properties.DataSource = dt;
        //}

    }
}

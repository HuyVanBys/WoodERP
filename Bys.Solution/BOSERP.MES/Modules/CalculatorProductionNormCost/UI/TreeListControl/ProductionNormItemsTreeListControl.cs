using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public partial class ProductionNormItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        DataSet dsFormulas;
        List<ICProductsInfo> objProductsInfoList;

        protected override void InitTreeListDataSource()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource = entity.ProductionNormItemList;
            DataSource = dataSource;
            dsFormulas = ((CalculatorProductionNormCostModule)entity.Module).GetAllFormulas();
            objProductsInfoList = ((CalculatorProductionNormCostModule)Screen.Module).GetWoodIngredient();
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsBehavior.DragNodes = true;
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.OptionsView.ShowSummaryFooter = true;
            this.BOSDisplayRoot = false;
            this.BOSDisplayOption = true;
            this.OptionsView.ShowSummaryFooter = true;
            this.ForceInitialize();
            this.BestFitColumns();
            this.ValidateNode += new ValidateNodeEventHandler(TreeList_ValidateNode);
            this.GetCustomSummaryValue += new GetCustomSummaryValueEventHandler(ProductionNormItemsTreeListControl_GetCustomSummaryValue);
            //   this.DoubleClick += new EventHandler(ProductionNormItemsTreeListControl_DoubleClick);
            //   this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsTreeListControl_CellValueChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell);
        }

        //void ProductionNormItemsTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        //{
        //    string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    TreeListNode node = entity.ProductionNormItemList.TreeListControl.GetSelectedNode();
        //    if (node != null && columnName == "FK_ICProductAttributeSpecialityID")
        //    {
        //        BOSDbUtil dbUtil = new BOSDbUtil();
        //        MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
        //        if (objProductionNormItemsInfo != null)
        //        {
        //            MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
        //            List<MMConsumableConfigsInfo> objConsumableConfigsInfo = (List<MMConsumableConfigsInfo>)objConsumableConfigsController.GetConsumableConfigsByProductAttributeID(objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
        //            if (objConsumableConfigsInfo != null && objConsumableConfigsInfo.Count > 0)
        //            {
        //                if (objProductionNormItemsInfo.MMCalculatorProductionNormItemIsComponent == false)
        //                {
        //                    objProductionNormItemsInfo.MMCalculatorProductionNormItemDepreciationRate = objConsumableConfigsInfo[0].MMConsumableConfigValue;
        //                    //objProductionNormItemsInfo = ((CalculatorProductionNormCostModule)Screen.Module).UpdateValueProductionNormItems(objProductionNormItemsInfo);
        //                }
        //            }
        //        }
        //        entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
        //    }

        //    if (node != null && (columnName == CalculationProductionNormConst.FK_MMFormulaIDPaintA || columnName == CalculationProductionNormConst.FK_MMFormulaIDPaintB))
        //    {
        //        ((CalculatorProductionNormCostModule)Screen.Module).UpdateAllCalculatedColumns();
        //        entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
        //    }
        //}
        //void ProductionNormItemsTreeListControl_DoubleClick(object sender, EventArgs e)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    TreeListNode node = entity.ProductionNormItemList.TreeListControl.GetSelectedNode();
        //    TreeList tree = sender as TreeList;
        //    if (node != null )
        //    {
        //        MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)tree.GetDataRecordByNode(node);

        //        if (objProductionNormItemsInfo != null)
        //        {
        //            if (objProductionNormItemsInfo.MMCalculatorProductionNormItemIsComponent == false && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            {
        //              BOSERP.Modules.WoodMaterialsProduct.WoodMaterialsProductModule SemiCalculatorProductionNormCostModule = (BOSERP.Modules.WoodMaterialsProduct.WoodMaterialsProductModule)BOSApp.ShowModule("WoodMaterialsProduct");
        //                if (SemiCalculatorProductionNormCostModule != null)
        //                {
        //                    SemiCalculatorProductionNormCostModule.isChangeBOM = true;
        //                    SemiCalculatorProductionNormCostModule.objProductionNormItemsInfo = objProductionNormItemsInfo;
        //                    SemiCalculatorProductionNormCostModule.ActionInvalidate(objProductionNormItemsInfo.FK_ICProductID);
        //                }     
        //            }
        //        }
        //    }
        //}

        void ProductionNormItemsTreeListControl_GetCustomSummaryValue(object sender, GetCustomSummaryValueEventArgs e)
        {
            if (e.IsSummaryFooter)
            {
                if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity)
                {
                    e.CustomValue = ((CalculatorProductionNormCostModule)Screen.Module).GetSumProductionNormItemQty();
                }
                if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemWoodBlocks)
                {
                    e.CustomValue = ((CalculatorProductionNormCostModule)Screen.Module).GetSumProductionNormItemBlocks();
                }
                if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemTotalWoodConsumable)
                {
                    e.CustomValue = ((CalculatorProductionNormCostModule)Screen.Module).GetSumProductionNormItemWoodConsumable();
                }
                if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemMDFBlocks)
                {
                    e.CustomValue = ((CalculatorProductionNormCostModule)Screen.Module).GetSumProductionNormItemMDFBlock();
                }
                if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPaintA)
                {
                    e.CustomValue = ((CalculatorProductionNormCostModule)Screen.Module).GetSumProductionNormItemPaintA();
                }
                if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPaintB)
                {
                    e.CustomValue = ((CalculatorProductionNormCostModule)Screen.Module).GetSumProductionNormItemPaintB();
                }
                if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemVeneer)
                {
                    e.CustomValue = ((CalculatorProductionNormCostModule)Screen.Module).GetSumProductionNormItemVeneer();
                }
            }
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns


            AddTreeListColumns(0, "MMCalculatorProductionNormItemSortOrderString", true, false);
            AddTreeListColumns(1, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName, true, false);
            //AddTreeListColumns(2, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductWoodType, false, true);
            //AddTreeListColumns(2, "FK_ICProductAttributeWoodTypeID", false, true);
            AddTreeListColumns(3, CalculationProductionNormConst.MMCalculatorProductionNormItemNo, true, false);
            AddTreeListColumns(4, "FK_ICProductAttributeSpecialityID", false, true);
            //AddTreeListColumns(5, "MMCalculatorProductionNormItemMeterial", false, true);
            AddTreeListColumns(5, "FK_ICProductWoodIngredientID", false, true);
            AddTreeListColumns(6, "FK_ICProductAttributeQualityID", false, true);
            AddTreeListColumns(7, "MMCalculatorProductionNormItemComment", false, true);
            AddTreeListColumns(8, CalculationProductionNormConst.MMCalculatorProductionNormItemDepreciationRate, false, true);
            AddTreeListColumns(9, CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity, false, true);
            AddTreeListColumns(10, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductLong, false, true);
            AddTreeListColumns(11, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductWidth, false, true);
            AddTreeListColumns(12, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductThick, false, true);
            AddTreeListColumns(13, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductJoinery, false, true);
            AddTreeListColumns(15, CalculationProductionNormConst.MMCalculatorProductionNormItemIsReuse, false, true);
            AddTreeListColumns(16, CalculationProductionNormConst.MMCalculatorProductionNormItemAcreage, true, false);
            AddTreeListColumns(17, CalculationProductionNormConst.MMCalculatorProductionNormItemWoodBlocks, true, false);
            AddTreeListColumns(18, CalculationProductionNormConst.MMCalculatorProductionNormItemMDFBlocks, true, false);
            AddTreeListColumns(19, CalculationProductionNormConst.MMCalculatorProductionNormItemVeneer, true, false);
            AddTreeListColumns(20, CalculationProductionNormConst.FK_MMFormulaIDPaintA, false, true);
            AddTreeListColumns(21, CalculationProductionNormConst.MMCalculatorProductionNormItemPaintA, true, false);
            AddTreeListColumns(22, CalculationProductionNormConst.FK_MMFormulaIDPaintB, false, true);
            AddTreeListColumns(23, CalculationProductionNormConst.MMCalculatorProductionNormItemPaintB, true, false);
            AddTreeListColumns(24, CalculationProductionNormConst.MMCalculatorProductionNormItemActualDepreciationRate, false, true);
            AddTreeListColumns(25, CalculationProductionNormConst.MMCalculatorProductionNormItemTotalWoodConsumable, false, true);


            #endregion
            if (Columns["MMCalculatorProductionNormItemSortOrder"] == null)
            {
                this.BeginUpdate();
                TreeListColumn column = Columns.Add();
                column.FieldName = "MMCalculatorProductionNormItemSortOrder";
                column.Caption = "SortOrder";
                column.Visible = false;
                this.EndUpdate();
                this.Update();
            }
            this.OptionsView.ShowSummaryFooter = true;
            this.OptionsBehavior.ImmediateEditor = true;
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
            this.OptionsView.AutoWidth = false;

            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductWoodType ||
                fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName ||
                fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemNo ||
                fieldName == "MMCalculatorProductionNormItemSortOrderString")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                if (fieldName == "MMCalculatorProductionNormItemSortOrderString")
                    column.MinWidth = 50;

                if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductWoodType)
                    column.MinWidth = 75;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                if (fieldName == "MMCalculatorProductionNormItemSortOrderString")
                {
                    column.Caption = CalculationProductionNormConst.MMProductionNormOrderNoCaption;
                }
            }

            if (fieldName == CalculationProductionNormConst.MMProductionNormICDepartmentAttribute)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Width = 100;
                column.Visible = false;
            }

            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPaintA || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPaintB
                || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemVeneer || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemMDFBlocks
                )
            {
                column.AllNodesSummary = true;
                column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
                column.RowFooterSummaryStrFormat = CalculationProductionNormConst.ProducttionNormFormatN4;
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemTotalWoodConsumable || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity
                || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemWoodBlocks)
            {
                column.AllNodesSummary = true;
                column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
                column.RowFooterSummaryStrFormat = CalculationProductionNormConst.ProducttionNormFormatN4;
                if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity)
                    column.RowFooterSummaryStrFormat = CalculationProductionNormConst.ProducttionNormFormatN0;
            }
            if (fieldName == CalculationProductionNormConst.FK_MMFormulaIDPaintA || fieldName == CalculationProductionNormConst.FK_MMFormulaIDPaintB)
            {
                column.OptionsColumn.AllowEdit = false;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
                //repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);                
                //repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 150;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            if (fieldName == "FK_ICProductAttributeSpecialityID")
            {
                column.OptionsColumn.AllowEdit = false;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWood6_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 150;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);

            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductWoodType)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại gỗ"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);

            }

            if (fieldName == "FK_ICProductAttributeQualityID")
            {
                column.OptionsColumn.AllowEdit = false;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEditAttributeQuality = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEditAttributeQuality.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEditAttributeQuality.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEditAttributeQuality.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEditAttributeQuality.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEditAttributeQuality.NullText = string.Empty;
                //repositoryItemLookUpEditAttributeQuality.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Chất lượng"));
                //repositoryItemLookUpEditAttributeQuality.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditAttributeQuality_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEditAttributeQuality;
                //column.MinWidth = 150;
                //this.RepositoryItems.Add(repositoryItemLookUpEditAttributeQuality);

            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemIsReuse)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
                column.ColumnEdit = rep;
                column.ColumnEdit.ReadOnly = false;
                this.RepositoryItems.Add(rep);

            }

            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemVeneer)
            {
                column.MinWidth = 150;
                column.OptionsColumn.AllowEdit = false;
                column.Caption = ProductionNormLocalizeResources.ProductionNormItemVeneerCaption;
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPaintA || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPaintB
               || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPaintPerOne || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemPlywood
               || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemWoodBlocks || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemAcreage
               || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemVeneer || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemMDFBlocks
               || fieldName == "MMCalculatorProductionNormItemBlockPerOne" || fieldName == "MMCalculatorProductionNormItemBlocks" || fieldName == "MMCalculatorProductionNormItemTotalWoodConsumable"
               )
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n5}";
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
            }
            //if (fieldName == "MMCalculatorProductionNormItemMeterial")
            //{
            //    RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            //    rpItemComponent.NullText = "Chi tiết";
            //    rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            //    column.ColumnEdit = rpItemComponent;
            //    this.RepositoryItems.Add(rpItemComponent);
            //}
            if (fieldName == "FK_ICProductWoodIngredientID")
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit1_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                column.ColumnEdit = repositoryItemLookUpEdit;
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
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;


                        if (fieldName == "MMCalculatorProductionNormItemComment")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescGraftCaption;
                        if (fieldName == "FK_ICProductAttributeSpecialityID")
                            column.Caption = "Đặc tính";
                        if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemVeneer)
                            column.Caption = ProductionNormLocalizeResources.ProductionNormItemVeneerCaption;
                        if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName)
                        {
                            column.MinWidth = 200;
                        }
                        if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemNo)
                        {
                            column.MinWidth = 200;
                            column.Caption = ProductionNormLocalizeResources.GEHistoryDetailColumnNameCaption;
                        }
                        if (fieldName == "FK_ICProductAttributeQualityID")
                        {
                            column.Caption = "Chất lượng";
                        }
                        if (fieldName == "MMCalculatorProductionNormItemMeterial")
                        {
                            column.Caption = "Nguyên liệu gỗ";
                        }

                    }
                }
            }
            dsColumns.Dispose();
            this.EndUpdate();
            this.Update();
        }

        //void repositoryItemLookUpEditAttributeQuality_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductsController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> objProductsInfoList = objProductsController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());
        //    if (objProductsInfoList != null && objProductsInfoList.Count > 0)
        //    {
        //        lookUpEdit.Properties.DataSource = objProductsInfoList;
        //    }
        //}

        private void TreeList_ValidateNode(object sender, ValidateNodeEventArgs e)
        {
            double num;
            if (!double.TryParse(e.Node[Columns["MMCalculatorProductionNormItemPaintA"]].ToString(), out num))
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                this.SetColumnError(Columns["MMCalculatorProductionNormItemPaintA"], ProductionNormLocalizeResources.InputNotCorrectFornat);
            }
            if (!double.TryParse(e.Node[Columns["MMCalculatorProductionNormItemQuantity"]].ToString(), out num))
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                this.SetColumnError(Columns["MMCalculatorProductionNormItemQuantity"], ProductionNormLocalizeResources.InputNotCorrectFornat);
            }
        }

        public void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (dsFormulas.Tables.Count > 0)
                lookUpEdit.Properties.DataSource = dsFormulas.Tables[0].DefaultView;
        }

        public void repositoryItemLookUpEdit1_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (dsFormulas.Tables.Count > 0)
                lookUpEdit.Properties.DataSource = objProductsInfoList;
        }

        public void repositoryItemLookUpEditWood6_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
            if (productAttribute != null && productAttribute.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttribute;
            }
        }
        public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
            if (productAttribute != null && productAttribute.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttribute;
            }
        }

        public void repositoryItemLookUpEditWood_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsInfoList = objProductsController.GetProductByDepartmentID(DepartmentID.Wood);
            if (objProductsInfoList != null && objProductsInfoList.Count > 0)
            {
                CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo
                    = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
                if (objProductionNormItemsInfo != null)
                {
                    string woodTypeSrt = objProductionNormItemsInfo.MMCalculatorProductionNormItemProductWoodType;
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo
                        = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(woodTypeSrt);

                    if (objProductAttributesInfo != null)
                    {
                        int woodTypeID = objProductAttributesInfo.ICProductAttributeID;
                        objProductsInfoList = objProductsInfoList.Where(t => t.ICProductType != ProductType.Roundwood.ToString()).ToList();
                        objProductsInfoList = objProductsInfoList.Where(t => t.FK_ICProductAttributeWoodTypeID == woodTypeID).ToList();
                        lookUpEdit.Properties.DataSource = objProductsInfoList;
                    }
                }
            }
        }
        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((CalculatorProductionNormCostModule)Screen.Module).CurrentModuleEntity;
            MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
            //if(!objProductionNormItemsInfo.MMCalculatorProductionNormItemIsComponent)
            ////((CalculatorProductionNormCostModule)Screen.Module).ShowProductionNormItemMeterial(objProductionNormItemsInfo);


        }

        private void ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID" ||
                e.Column.FieldName == "FK_ICProductAttributeQualityID"

                )
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        ICProductAttributesInfo objProductAttributesInfo
                            = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);

                        if (objProductAttributesInfo != null)
                            e.CellText = objProductAttributesInfo.ICProductAttributeValue;
                    }
                }
            }
            if (e.Column.FieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductWoodType)
            {
                if (e.CellValue != null)
                {
                    e.CellText = e.CellValue.ToString();
                    //int value = 0;
                    //if (int.TryParse(e.CellValue.ToString(), out value))
                    //{
                    //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    //    ICProductAttributesInfo objProductAttributesInfo
                    //        = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(value.ToString());

                    //    if (objProductAttributesInfo != null)
                    //        e.CellText = objProductAttributesInfo.ICProductAttributeValue;
                    //}
                }
            }
            if (e.Column.FieldName == CalculationProductionNormConst.FK_MMFormulaIDPaintA ||
                e.Column.FieldName == CalculationProductionNormConst.FK_MMFormulaIDPaintB)
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        MMFormulasController objSuppliersController = new MMFormulasController();
                        MMFormulasInfo objSuppliersInfo = (MMFormulasInfo)objSuppliersController.GetObjectByID(value);
                        if (objSuppliersInfo != null)
                            e.CellText = objSuppliersInfo.MMFormulaName;
                    }
                }
            }

            if (e.Column.FieldName == "FK_ICProductWoodIngredientID")
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        ICProductsController objSuppliersController = new ICProductsController();
                        ICProductsInfo objSuppliersInfo = (ICProductsInfo)objSuppliersController.GetObjectByID(value);
                        if (objSuppliersInfo != null)
                            e.CellText = objSuppliersInfo.ICProductName;
                    }
                }
            }
        }
    }
}

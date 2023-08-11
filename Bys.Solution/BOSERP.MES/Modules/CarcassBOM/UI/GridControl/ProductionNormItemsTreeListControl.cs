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
    public partial class ProductionNormItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        List<MMFormulasInfo> FormulasList { get; set; }

        protected override void InitTreeListDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource = entity.ProductionNormItemList;
            DataSource = dataSource;
        }

        public List<MMFormulasInfo> GetFormulasDataSource()
        {
            MMFormulasController objFormulasController = new MMFormulasController();
            List<MMFormulasInfo> formulasList = new List<MMFormulasInfo>();
            DataSet ds = (DataSet)BOSApp.LookupTables["MMFormulas"];
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData("MMFormulas");
            }
            formulasList = (List<MMFormulasInfo>)objFormulasController.GetListFromDataSet(ds);
            formulasList = formulasList.Where(o => o.MMFormulaType == "Paint").ToList();
            if (!formulasList.Exists(o => o.MMFormulaID == 0))
                formulasList.Insert(0, new MMFormulasInfo());

            return formulasList;
        }
        public override void InitializeControl()
        {
            this.BOSDisplayOption = false;
            base.InitializeControl();
            this.ExpandAll();
            //this.OptionsBehavior.DragNodes = true;
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            //this.OptionsView.ShowSummaryFooter = true;
            this.BOSDisplayRoot = false;
            this.BestFitColumns();
            this.ValidateNode += new ValidateNodeEventHandler(TreeList_ValidateNode);
            this.GetCustomSummaryValue += new GetCustomSummaryValueEventHandler(ProductionNormItemsTreeListControl_GetCustomSummaryValue);
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsTreeListControl_CellValueChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell);
            this.KeyUp += ProductionNormItemsTreeListControl_KeyUp;
            foreach (TreeListColumn column in this.Columns)
            {
                if (column.FieldName == "FK_ICProductAttributeSpecialityID" ||
                   column.FieldName == "FK_ICProductAttributeQualityID" ||
                   column.FieldName == "MMProductionNormItemComment" ||
                   column.FieldName == "MMProductionNormItemDepreciationRate" ||
                   column.FieldName == "MMProductionNormItemQuantity" ||
                   column.FieldName == "MMProductionNormItemProductSizeAndPacking" ||
                   column.FieldName == "FK_ICMeasureUnitID" ||
                   column.FieldName == "MMProductionNormItemProductLength" ||
                   column.FieldName == "MMProductionNormItemProductWidth" ||
                   column.FieldName == "MMProductionNormItemProductHeight" ||
                   column.FieldName == "MMProductionNormItemProductJoinery" ||
                   column.FieldName == "MMProductionNormItemProductDesc" ||
                   column.FieldName == "MMProductionNormItemHavePaint" ||
                   column.FieldName == "MMProductionNormItemFrontCNCImage" ||
                   column.FieldName == "MMProductionNormItemBacksideCNCImage" ||
                   column.FieldName == "MMProductionNormItemIsBurnishing" ||
                   column.FieldName == "MMProductionNormItemIsReuse" ||
                   column.FieldName == "FK_MMFormulaIDPaintC" ||
                   column.FieldName == "FK_MMFormulaIDPaintB" ||
                   column.FieldName == "FK_MMFormulaIDPaintA" ||
                   column.FieldName == "MMProductionNormItemColorDesc")
                    column.OptionsColumn.AllowEdit = true;
                else column.OptionsColumn.AllowEdit = false;
            }
        }

        private void ProductionNormItemsTreeListControl_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
                if (mainObject.MMProductionNormWoodStatus == Status.New.ToString() || mainObject.MMProductionNormWoodStatus == Status.Edit.ToString())
                {
                    MMProductionNormItemsInfo item = entity.ModuleObjects[TableName.MMProductionNormItemsTableName] as MMProductionNormItemsInfo;
                    entity.ProductionNormItemList.RemoveSelectedRowObjectFromList();
                    //((CarcassBOMModule)Screen.Module).ClearDeletedNodes(entity.ProductionNormItemList);
                    ((CarcassBOMModule)Screen.Module).UpdateAllCalculatedColumns();
                    entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
                }
            }
        }

        void ProductionNormItemsTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = entity.ProductionNormItemList.TreeListControl.GetSelectedNode();
            if (node != null && columnName == "FK_ICProductAttributeSpecialityID")
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
                if (objProductionNormItemsInfo != null)
                {
                    MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
                    List<MMConsumableConfigsInfo> objConsumableConfigsInfo = (List<MMConsumableConfigsInfo>)objConsumableConfigsController.GetConsumableConfigsByProductAttributeID(objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
                    if (objConsumableConfigsInfo != null && objConsumableConfigsInfo.Count > 0)
                    {
                        if (objProductionNormItemsInfo.MMProductionNormItemIsComponent == false)
                        {
                            objProductionNormItemsInfo.MMProductionNormItemDepreciationRate = objConsumableConfigsInfo[0].MMConsumableConfigValue;
                            //objProductionNormItemsInfo = ((CarcassBOMModule)Screen.Module).UpdateValueProductionNormItems(objProductionNormItemsInfo);
                        }
                    }
                }
                entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
            }

            if (node != null && (columnName == ProductionNormConst.FK_MMFormulaIDPaintA || columnName == ProductionNormConst.FK_MMFormulaIDPaintB))
            {
                ((CarcassBOMModule)Screen.Module).UpdateAllCalculatedColumns();
                entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
            }
        }

        void ProductionNormItemsTreeListControl_GetCustomSummaryValue(object sender, GetCustomSummaryValueEventArgs e)
        {
            try
            {
                if (e.IsSummaryFooter && e.Column != null)
                {
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemQuantity)
                    {
                        e.CustomValue = ((CarcassBOMModule)Screen.Module).GetSumProductionNormItemQty();
                    }
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemWoodBlocks)
                    {
                        e.CustomValue = ((CarcassBOMModule)Screen.Module).GetSumProductionNormItemBlocks();
                    }
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemTotalWoodConsumable)
                    {
                        e.CustomValue = ((CarcassBOMModule)Screen.Module).GetSumProductionNormItemWoodConsumable();
                    }
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemMDFBlocks)
                    {
                        e.CustomValue = ((CarcassBOMModule)Screen.Module).GetSumProductionNormItemMDFBlock();
                    }
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintA)
                    {
                        e.CustomValue = ((CarcassBOMModule)Screen.Module).GetSumProductionNormItemPaintA();
                    }
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintB)
                    {
                        e.CustomValue = ((CarcassBOMModule)Screen.Module).GetSumProductionNormItemPaintB();
                    }
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemVeneer)
                    {
                        e.CustomValue = ((CarcassBOMModule)Screen.Module).GetSumProductionNormItemVeneer();
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }

        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            TreeListColumn column = new TreeListColumn();
            AddTreeListColumns(0, "ICProductCode", true, false);
            column = this.Columns["ICProductCode"];
            if (column != null)
                column.Caption = "Mã Code";
            column = this.Columns["MMProductionNormItemProductName"];
            if (column != null)
                column.Caption = "Tên BTP";
            column = this.Columns["MMProductionNormItemNo"];
            if (column != null)
                column.Caption = "Mã BTP";
            column = this.Columns["MMProductionNormItemQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "N5");
            }
            //this.OptionsView.ShowSummaryFooter = true;
            //this.OptionsBehavior.ImmediateEditor = true;
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
            if (fieldName == ProductionNormConst.MMProductionNormItemICProductWoodType ||
                fieldName == ProductionNormConst.MMProductionNormItemICProductName ||
                fieldName == ProductionNormConst.MMProductionNormItemNo ||
                fieldName == "MMProductionNormItemSortOrderString")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                if (fieldName == "MMProductionNormItemSortOrderString")
                    column.MinWidth = 50;

                if (fieldName == ProductionNormConst.MMProductionNormItemICProductWoodType)
                    column.MinWidth = 75;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                if (fieldName == "MMProductionNormItemSortOrderString")
                {
                    column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                }
            }

            if (fieldName == ProductionNormConst.MMProductionNormICDepartmentAttribute)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Width = 100;
                column.Visible = false;
            }

            if (fieldName == ProductionNormConst.MMProductionNormItemPaintA || fieldName == ProductionNormConst.MMProductionNormItemPaintB
                || fieldName == ProductionNormConst.MMProductionNormItemVeneer || fieldName == ProductionNormConst.MMProductionNormItemMDFBlocks
                )
            {
                column.AllNodesSummary = true;
                column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
                column.RowFooterSummaryStrFormat = ProductionNormConst.ProducttionNormFormatN4;
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemTotalWoodConsumable || fieldName == ProductionNormConst.MMProductionNormItemQuantity
                || fieldName == ProductionNormConst.MMProductionNormItemWoodBlocks)
            {
                column.AllNodesSummary = true;
                column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
                column.RowFooterSummaryStrFormat = ProductionNormConst.ProducttionNormFormatN4;
                if (fieldName == ProductionNormConst.MMProductionNormItemQuantity)
                    column.RowFooterSummaryStrFormat = ProductionNormConst.ProducttionNormFormatN5;
            }
            if (fieldName == ProductionNormConst.FK_MMFormulaIDPaintA || fieldName == ProductionNormConst.FK_MMFormulaIDPaintB)
            {
                column.OptionsColumn.AllowEdit = true;

                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
                repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
                repositoryItemLookUpEdit.DataSource = FormulasList;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            if (fieldName == "FK_ICProductAttributeSpecialityID")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWood6_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);

            }
            if (fieldName == ProductionNormConst.FK_ICProductAttributeWoodTypeID)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại NL"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);

            }

            if (fieldName == "FK_ICProductAttributeQualityID")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEditAttributeQuality = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEditAttributeQuality.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEditAttributeQuality.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEditAttributeQuality.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEditAttributeQuality.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEditAttributeQuality.NullText = string.Empty;
                repositoryItemLookUpEditAttributeQuality.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Chất lượng"));
                repositoryItemLookUpEditAttributeQuality.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditAttributeQuality_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEditAttributeQuality;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEditAttributeQuality);

            }
            if (fieldName == "FK_MMOperationID")
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                //repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Công đoạn", 150));
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);
                //repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 150;
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemIsReuse)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
                column.ColumnEdit = rep;
                column.ColumnEdit.ReadOnly = false;
                this.RepositoryItems.Add(rep);

            }

            if (fieldName == "MMProductionNormItemHavePaint")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
                column.ColumnEdit = rep;
                column.ColumnEdit.ReadOnly = false;
                this.RepositoryItems.Add(rep);
            }

            if (fieldName == ProductionNormConst.MMProductionNormItemVeneer)
            {
                column.MinWidth = 150;
                column.OptionsColumn.AllowEdit = true;
                column.Caption = ProductionNormLocalizeResources.ProductionNormItemVeneerCaption;
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemPaintA || fieldName == ProductionNormConst.MMProductionNormItemPaintB
               || fieldName == ProductionNormConst.MMProductionNormItemPaintPerOne || fieldName == ProductionNormConst.MMProductionNormItemPlywood
               || fieldName == ProductionNormConst.MMProductionNormItemWoodBlocks || fieldName == ProductionNormConst.MMProductionNormItemAcreage
               || fieldName == ProductionNormConst.MMProductionNormItemVeneer || fieldName == ProductionNormConst.MMProductionNormItemMDFBlocks
               || fieldName == "MMProductionNormItemBlockPerOne" || fieldName == "MMProductionNormItemBlocks" || fieldName == "MMProductionNormItemTotalWoodConsumable"
               )
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n4}";
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
                column.Format.FormatString = "{0:n3}";
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
            if (fieldName == "FK_ICProductWoodIngredientID")
            {
                column.OptionsColumn.AllowEdit = true;
                //  RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                //repositoryItemLookUpEdit.ValueMember = "ICProductID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit1_QueryPopUp);
                //repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                //column.ColumnEdit = repositoryItemLookUpEdit;                
            }
            if (fieldName != "MMProductionNormItemOtherColor")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckedComboBoxEdit rpOhterColor = new RepositoryItemCheckedComboBoxEdit();
                rpOhterColor.DisplayMember = "ICProductAttributeValue";
                rpOhterColor.ValueMember = "ICProductAttributeID";
                rpOhterColor.NullText = string.Empty;
                rpOhterColor.DataSource = GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
                column.ColumnEdit = rpOhterColor;
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
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;


                        if (fieldName == "MMProductionNormItemComment")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescGraftCaption;
                        if (fieldName == "FK_ICProductAttributeSpecialityID")
                            column.Caption = "Đặc tính";
                        if (fieldName == ProductionNormConst.MMProductionNormItemVeneer)
                            column.Caption = ProductionNormLocalizeResources.ProductionNormItemVeneerCaption;
                        if (fieldName == ProductionNormConst.MMProductionNormItemICProductName)
                        {
                            column.MinWidth = 200;
                        }
                        if (fieldName == ProductionNormConst.MMProductionNormItemNo)
                        {
                            column.MinWidth = 200;
                            column.Caption = ProductionNormLocalizeResources.GEHistoryDetailColumnNameCaption;
                        }
                        if (fieldName == "FK_ICProductAttributeQualityID")
                        {
                            column.Caption = "Chất lượng";
                        }
                        if (fieldName == "MMProductionNormItemMeterial")
                        {
                            column.Caption = "Nguyên liệu";
                        }

                    }
                }
            }

            this.EndUpdate();
            this.Update();
        }
        public List<ICProductAttributesInfo> GetProductAttributeDatasource(string group)
        {
            List<ICProductAttributesInfo> woodTypeList = new List<ICProductAttributesInfo>();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            woodTypeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(group);
            ICProductAttributesInfo objProductAttributesDummyInfo = new ICProductAttributesInfo();
            woodTypeList.Insert(0, objProductAttributesDummyInfo);
            return woodTypeList;
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
        public void reqOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    lookUpEdit.Properties.DataSource = ds.Tables[0];
                }
            }
        }

        private void TreeList_ValidateNode(object sender, ValidateNodeEventArgs e)
        {
            try
            {
                double num;
                if (Columns["MMProductionNormItemPaintA"] != null && !double.TryParse(e.Node[Columns["MMProductionNormItemPaintA"]].ToString(), out num))
                {
                    e.Valid = false;
                    //Set errors with specific descriptions for the columns
                    this.SetColumnError(Columns["MMProductionNormItemPaintA"], ProductionNormLocalizeResources.InputNotCorrectFornat);
                }
                if (Columns["MMProductionNormItemQuantity"] != null && !double.TryParse(e.Node[Columns["MMProductionNormItemQuantity"]].ToString(), out num))
                {
                    e.Valid = false;
                    //Set errors with specific descriptions for the columns
                    this.SetColumnError(Columns["MMProductionNormItemQuantity"], ProductionNormLocalizeResources.InputNotCorrectFornat);
                }
            }
            catch (Exception)
            {
                return;
            }
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
        public void repositoryItemLookUpEditAttributeQuality_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeQualityColumnName);
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

        //public void repositoryItemLookUpEditWood_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductsController objProductsController = new ICProductsController();
        //    List<ICProductsInfo> objProductsInfoList = objProductsController.GetProductByDepartmentID(DepartmentID.Wood);
        //    if(objProductsInfoList!=null&& objProductsInfoList.Count>0)
        //    {
        //        CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //        MMProductionNormItemsInfo objProductionNormItemsInfo
        //            = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
        //        if (objProductionNormItemsInfo != null)
        //        {
        //            string woodTypeSrt = objProductionNormItemsInfo.MMProductionNormItemProductWoodType;
        //            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //            ICProductAttributesInfo objProductAttributesInfo
        //                = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(woodTypeSrt);

        //            if (objProductAttributesInfo != null)
        //            {
        //                int woodTypeID = objProductAttributesInfo.ICProductAttributeID;
        //                objProductsInfoList = objProductsInfoList.Where(t => t.ICProductType != ProductType.Roundwood.ToString()).ToList();
        //                objProductsInfoList = objProductsInfoList.Where(t => t.FK_ICProductAttributeWoodTypeID == woodTypeID).ToList();
        //                lookUpEdit.Properties.DataSource = objProductsInfoList;
        //            }
        //        }
        //    }
        //}
        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
            //if(!objProductionNormItemsInfo.MMProductionNormItemIsComponent)
            ////((CarcassBOMModule)Screen.Module).ShowProductionNormItemMeterial(objProductionNormItemsInfo);


        }

        private void ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == ProductionNormConst.FK_ICMeasureUnitID)
                {
                    if (e.CellValue != null)
                    {
                        int measureUnitID = int.Parse(e.CellValue.ToString());
                        e.CellText = BOSApp.GetDisplayTextFromCatche(TableName.ICMeasureUnitsTableName, "ICMeasureUnitID", measureUnitID, "ICMeasureUnitName");
                    }
                }
                if (e.Column.FieldName == "MMProductionNormItemResourceType")
                {
                    if (e.CellValue != null)
                    {
                        e.CellText = ADConfigValueUtility.GetConfigTextByGroupAndValue("ProductionNormItemResourceType", e.CellValue.ToString());
                    }
                }
                if (e.Column.FieldName == "FK_ICProductAttributeQualityID" || e.Column.FieldName == "FK_ICProductAttributeSpecialityID" || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
                {
                    if (e.CellValue != null)
                    {
                        e.CellText = e.CellValue.ToString();
                        int value = 0;
                        if (int.TryParse(e.CellValue.ToString(), out value))
                        {
                            e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", value, "ICProductAttributeValue");
                        }
                    }
                }
                //if (e.Column.FieldName == ProductionNormConst.FK_MMFormulaIDPaintA ||
                //    e.Column.FieldName == ProductionNormConst.FK_MMFormulaIDPaintB)
                //{
                //    if (e.CellValue != null)
                //    {
                //        int value = 0;
                //        if (int.TryParse(e.CellValue.ToString(), out value))
                //        {
                //            MMFormulasController objSuppliersController = new MMFormulasController();
                //            MMFormulasInfo objSuppliersInfo = (MMFormulasInfo)objSuppliersController.GetObjectByID(value);
                //            if (objSuppliersInfo != null)
                //                e.CellText = objSuppliersInfo.MMFormulaName;
                //        }
                //    }
                //}

                if (e.Column.FieldName == "FK_ICProductWoodIngredientID")
                {
                    if (e.CellValue != null)
                    {
                        int value = 0;
                        if (int.TryParse(e.CellValue.ToString(), out value))
                        {
                            ICProductsInfo iCProducts = BOSApp.GetProductFromCurrentProductList(value);
                            if (iCProducts != null)
                                e.CellText = iCProducts.ICProductName;
                        }
                    }
                }
                if (e.CellValue != null && e.Column.FieldName == "MMProductionNormItemOtherColor")
                {
                    e.CellText = GetColorDisplayText(e.CellText.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private string GetColorDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

            List<int> colorID = colorRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            DataSet ds = BOSApp.GetLookupTableData("ICProductAttributes");
            if (ds != null && ds.Tables.Count > 0)
            {
                List<ICProductAttributesInfo> ColorData = (List<ICProductAttributesInfo>)(new ICProductAttributesController()).GetListFromDataSet(ds);
                return string.Join(", ", ColorData.Where(o => colorID.Contains(o.ICProductAttributeID)).Select(o => o.ICProductAttributeValue).ToArray());
            }
            else return string.Empty;
        }
    }
}

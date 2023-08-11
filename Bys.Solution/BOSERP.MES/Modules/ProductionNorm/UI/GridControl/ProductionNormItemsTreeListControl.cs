using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using BOSLib;
using System.Linq;
using Localization;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            dataSource = entity.ProductionNormItemList;
            DataSource = dataSource;
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
            this.ForceInitialize();
            this.BestFitColumns();
            this.ValidateNode += new ValidateNodeEventHandler(TreeList_ValidateNode);
            this.GetCustomSummaryValue += new GetCustomSummaryValueEventHandler(ProductionNormItemsTreeListControl_GetCustomSummaryValue);
            this.DoubleClick += new EventHandler(ProductionNormItemsTreeListControl_DoubleClick);
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsTreeListControl_CellValueChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell);
        }

        void ProductionNormItemsTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
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
                            objProductionNormItemsInfo = ((ProductionNormModule)Screen.Module).UpdateValueProductionNormItems(objProductionNormItemsInfo);
                        }
                    }
                }
                entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
            }
        }
 		void ProductionNormItemsTreeListControl_DoubleClick(object sender, EventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = entity.ProductionNormItemList.TreeListControl.GetSelectedNode();
            TreeList tree = sender as TreeList;
            if (node != null )
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)tree.GetDataRecordByNode(node);

                if (objProductionNormItemsInfo != null)
                {
                    //if (objProductionNormItemsInfo.MMProductionNormItemIsComponent == false && objProductionNormItemsInfo.FK_ICProductID > 0)
                    //{
                    //    BOSERP.Modules.WoodMaterialsProduct.WoodMaterialsProductModule SemiProductModule = (BOSERP.Modules.WoodMaterialsProduct.WoodMaterialsProductModule)BOSApp.ShowModule("WoodMaterialsProduct");
                    //    if (SemiProductModule != null)
                    //    {
                    //        SemiProductModule.isChangeBOM = true;
                    //        SemiProductModule.objProductionNormItemsInfo = objProductionNormItemsInfo;
                    //        SemiProductModule.ActionInvalidate(objProductionNormItemsInfo.FK_ICProductID);
                    //    }     
                    //}
                }
            }
        }
        void ProductionNormItemsTreeListControl_GetCustomSummaryValue(object sender, GetCustomSummaryValueEventArgs e)
        {
            if (e.IsSummaryFooter)
            {
                if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemQuantity)
                {
                    e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemQty();
                }
                if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemWoodBlocks)
                {
                    e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemBlocks();
                }
                if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemTotalWoodConsumable)
                {
                    e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemWoodConsumable();
                }
                if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemMDFBlocks)
                {
                    e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemMDFBlock();
                }
                if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintA)
                {
                    e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemPaintA();
                }
                if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintB)
                {
                    e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemPaintB();
                }
                if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemVeneer)
                {
                    e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemVeneer();
                }
            }
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns

            
            AddTreeListColumns(0, "MMProductionNormItemSortOrderString", true, false);
            AddTreeListColumns(1, ProductionNormConst.MMProductionNormItemICProductName, true, false);
            AddTreeListColumns(2, ProductionNormConst.MMProductionNormItemICProductWoodType, false, true);
            AddTreeListColumns(3, ProductionNormConst.MMProductionNormItemNo, true, false);
            AddTreeListColumns(4, "FK_ICProductAttributeSpecialityID", false, true);
			AddTreeListColumns(5, "MMProductionNormItemMeterial", false, true);
            AddTreeListColumns(6, "FK_ICProductAttributeQualityID", false, true);
            AddTreeListColumns(7, "MMProductionNormItemComment", false, true);
            AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemDepreciationRate, false, true);
            AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemQuantity, false, true);
            AddTreeListColumns(10, ProductionNormConst.MMProductionNormItemICProductLong, false, true);
            AddTreeListColumns(11, ProductionNormConst.MMProductionNormItemICProductWidth, false, true);
            AddTreeListColumns(12, ProductionNormConst.MMProductionNormItemICProductThick, false, true);
            AddTreeListColumns(13, ProductionNormConst.MMProductionNormItemICProductJoinery, false, true);
            AddTreeListColumns(15, ProductionNormConst.MMProductionNormItemIsReuse, false, true);
            AddTreeListColumns(16, ProductionNormConst.MMProductionNormItemAcreage, true, false);
            AddTreeListColumns(17, ProductionNormConst.MMProductionNormItemWoodBlocks, true, false);
            AddTreeListColumns(18, ProductionNormConst.MMProductionNormItemMDFBlocks, true, false);
            AddTreeListColumns(19, ProductionNormConst.MMProductionNormItemVeneer, true, false);
            AddTreeListColumns(20, ProductionNormConst.FK_MMFormulaIDPaintA, false, true);
            AddTreeListColumns(21, ProductionNormConst.MMProductionNormItemPaintA, true, false);
            AddTreeListColumns(22, ProductionNormConst.FK_MMFormulaIDPaintB, false, true);
            AddTreeListColumns(23, ProductionNormConst.MMProductionNormItemPaintB, true, false);
            AddTreeListColumns(24, ProductionNormConst.MMProductionNormItemActualDepreciationRate, false, true);
            AddTreeListColumns(25, ProductionNormConst.MMProductionNormItemTotalWoodConsumable, false, true);
            
            
            #endregion
            if (Columns["MMProductionNormItemSortOrder"] == null)
            {
                this.BeginUpdate();
                TreeListColumn column = Columns.Add();
                column.FieldName = "MMProductionNormItemSortOrder";
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
                 if(fieldName == "MMProductionNormItemSortOrderString")
                column.MinWidth = 50;
                
                if(fieldName == ProductionNormConst.MMProductionNormItemICProductWoodType)
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
                    column.RowFooterSummaryStrFormat = ProductionNormConst.ProducttionNormFormatN0;
            }
            if (fieldName == ProductionNormConst.FK_MMFormulaIDPaintA || fieldName == ProductionNormConst.FK_MMFormulaIDPaintB)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
                repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            
            if (fieldName == "FK_ICProductAttributeSpecialityID")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
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
            if (fieldName == "MMProductionNormItemProductWoodType")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại nguyên liệu"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);

            }

            if (fieldName == "FK_ICProductAttributeQualityID")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEditAttributeQuality = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEditAttributeQuality.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEditAttributeQuality.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEditAttributeQuality.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEditAttributeQuality.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEditAttributeQuality.NullText = string.Empty;
                repositoryItemLookUpEditAttributeQuality.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Chất lượng"));
                repositoryItemLookUpEditAttributeQuality.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditAttributeQuality_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEditAttributeQuality;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEditAttributeQuality);

            }
            if (fieldName == ProductionNormConst.MMProductionNormItemIsReuse)
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
                column.Format.FormatString = "{0:n2}";
            }
			if (fieldName == "MMProductionNormItemMeterial")
            {
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                rpItemComponent.NullText = "Chi tiết";
                rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
                this.RepositoryItems.Add(rpItemComponent);
            }
            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.MMProductionNormItemsTableName);
            if (dsColumns.Tables.Count > 0)
            {
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
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
            dsColumns.Dispose();
            this.EndUpdate();
            this.Update();
        }

        void repositoryItemLookUpEditAttributeQuality_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductsController = new ICProductAttributesController();
            List<ICProductAttributesInfo> objProductsInfoList = objProductsController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());
            if (objProductsInfoList != null && objProductsInfoList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objProductsInfoList;
            }
        }
       
        private void TreeList_ValidateNode(object sender, ValidateNodeEventArgs e)
        {
            double num;
            if (!double.TryParse(e.Node[Columns["MMProductionNormItemPaintA"]].ToString(), out num))
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                this.SetColumnError(Columns["MMProductionNormItemPaintA"], ProductionNormLocalizeResources.InputNotCorrectFornat);
            }
            if (!double.TryParse(e.Node[Columns["MMProductionNormItemQuantity"]].ToString(), out num))
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                this.SetColumnError(Columns["MMProductionNormItemQuantity"], ProductionNormLocalizeResources.InputNotCorrectFornat);
            }
        }

        public void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataTable dt = ((ProductionNormModule)Screen.Module).GetFormulaTable();
            lookUpEdit.Properties.DataSource = dt;
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
            if(objProductsInfoList!=null&& objProductsInfoList.Count>0)
            {
                ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMProductionNormItemsInfo objProductionNormItemsInfo
                    = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
                if (objProductionNormItemsInfo != null)
                {
                    string woodTypeSrt = objProductionNormItemsInfo.MMProductionNormItemProductWoodType;
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
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
            if(!objProductionNormItemsInfo.MMProductionNormItemIsComponent)
            ((ProductionNormModule)Screen.Module).ShowProductionNormItemMeterial(objProductionNormItemsInfo);


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
            if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemICProductWoodType)
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
            if (e.Column.FieldName == ProductionNormConst.FK_MMFormulaIDPaintA ||
                e.Column.FieldName == ProductionNormConst.FK_MMFormulaIDPaintB)
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

using BOSComponent;
using DevExpress.XtraTreeList.Columns;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ProductItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductItemTreeList;
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
            this.KeyUp += new KeyEventHandler(ProductItemsTreeListControl_KeyUp);
            //this.ValidateNode += new ValidateNodeEventHandler(TreeList_ValidateNode);
            //this.GetCustomSummaryValue += new GetCustomSummaryValueEventHandler(ProductionNormItemsTreeListControl_GetCustomSummaryValue);
            //this.DoubleClick += new EventHandler(ProductionNormItemsTreeListControl_DoubleClick);
            //this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsTreeListControl_CellValueChanged);

        }

        void ProductItemsTreeListControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductModule)Screen.Module).RemoveProductItemNode();
            }
        }

        //void ProductionNormItemsTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        //{
        //    string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;
        //    ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    TreeListNode node = entity.ProductionNormItemList.TreeListControl.GetSelectedNode();
        //    if (node != null && columnName == "FK_ICProductAttributeSpecialityID")
        //    {
        //        BOSDbUtil dbUtil = new BOSDbUtil();
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
        //        if (objProductionNormItemsInfo != null)
        //        {
        //            MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
        //            List<MMConsumableConfigsInfo> objConsumableConfigsInfo = (List<MMConsumableConfigsInfo>)objConsumableConfigsController.GetConsumableConfigsByProductAttributeID(objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
        //            if (objConsumableConfigsInfo != null && objConsumableConfigsInfo.Count > 0)
        //            {
        //                if (objProductionNormItemsInfo.MMProductionNormItemIsComponent == false)
        //                {
        //                    objProductionNormItemsInfo.MMProductionNormItemDepreciationRate = objConsumableConfigsInfo[0].MMConsumableConfigValue;
        //                    objProductionNormItemsInfo = ((ProductionNormModule)Screen.Module).UpdateValueProductionNormItems(objProductionNormItemsInfo);
        //                }
        //            }
        //        }
        //        entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
        //    }
        //}
        //void ProductionNormItemsTreeListControl_DoubleClick(object sender, EventArgs e)
        //{
        //    ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    TreeListNode node = entity.ProductionNormItemList.TreeListControl.GetSelectedNode();
        //    TreeList tree = sender as TreeList;
        //    if (node != null )
        //    {
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMProductionNormItemsInfo)tree.GetDataRecordByNode(node);

        //        if (objProductionNormItemsInfo != null)
        //        {
        //            if (objProductionNormItemsInfo.MMProductionNormItemIsComponent == false && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            {
        //                BOSERP.Modules.WoodMaterialsProduct.WoodMaterialsProductModule SemiProductModule = (BOSERP.Modules.WoodMaterialsProduct.WoodMaterialsProductModule)BOSApp.ShowModule("WoodMaterialsProduct");
        //                if (SemiProductModule != null)
        //                {
        //                    SemiProductModule.isChangeBOM = true;
        //                    SemiProductModule.objProductionNormItemsInfo = objProductionNormItemsInfo;
        //                    SemiProductModule.ActionInvalidate(objProductionNormItemsInfo.FK_ICProductID);
        //                }     
        //            }
        //        }
        //    }
        //}
        //void ProductionNormItemsTreeListControl_GetCustomSummaryValue(object sender, GetCustomSummaryValueEventArgs e)
        //{
        //    if (e.IsSummaryFooter)
        //    {
        //        if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemQuantity)
        //        {
        //            e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemQty();
        //        }
        //        if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemWoodBlocks)
        //        {
        //            e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemBlocks();
        //        }
        //        if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemTotalWoodConsumable)
        //        {
        //            e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemWoodConsumable();
        //        }
        //        if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemMDFBlocks)
        //        {
        //            e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemMDFBlock();
        //        }
        //        if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintA)
        //        {
        //            e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemPaintA();
        //        }
        //        if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintB)
        //        {
        //            e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemPaintB();
        //        }
        //        if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemVeneer)
        //        {
        //            e.CustomValue = ((ProductionNormModule)Screen.Module).GetSumProductionNormItemVeneer();
        //        }
        //    }
        //}

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns
            AddTreeListColumns(0, "ICProductCode", "Mã code", true, false, string.Empty);
            AddTreeListColumns(1, "ICProductName", "Tên", true, false, string.Empty);
            AddTreeListColumns(2, "ICProductItemQty", "Số lượng", false, true, "{0:n0}");
            #endregion

            this.OptionsView.ShowSummaryFooter = true;
            this.OptionsBehavior.ImmediateEditor = true;
        }

        public void AddTreeListColumns(int visibleIndex, string fieldName, string caption, bool readOnly, bool AllowEdit, string formatNumber)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;
            column.Caption = caption;
            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;

            if (!string.IsNullOrEmpty(formatNumber))
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = formatNumber;
            }

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

        //private void TreeList_ValidateNode(object sender, ValidateNodeEventArgs e)
        //{
        //    double num;
        //    if (!double.TryParse(e.Node[Columns["MMProductionNormItemPaintA"]].ToString(), out num))
        //    {
        //        e.Valid = false;
        //        //Set errors with specific descriptions for the columns
        //        this.SetColumnError(Columns["MMProductionNormItemPaintA"], ProductionNormLocalizeResources.InputNotCorrectFornat);
        //    }
        //    if (!double.TryParse(e.Node[Columns["MMProductionNormItemQuantity"]].ToString(), out num))
        //    {
        //        e.Valid = false;
        //        //Set errors with specific descriptions for the columns
        //        this.SetColumnError(Columns["MMProductionNormItemQuantity"], ProductionNormLocalizeResources.InputNotCorrectFornat);
        //    }
        //}

        //public void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((ProductionNormModule)Screen.Module).GetFormulaTable();
        //    lookUpEdit.Properties.DataSource = dt;
        //}
        //public void repositoryItemLookUpEditWood6_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
        //    if (productAttribute != null && productAttribute.Count > 0)
        //    {
        //        lookUpEdit.Properties.DataSource = productAttribute;
        //    }
        //}
        //public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
        //    if (productAttribute != null && productAttribute.Count > 0)
        //    {
        //        lookUpEdit.Properties.DataSource = productAttribute;
        //    }
        //}

        //public void repositoryItemLookUpEditWood_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductsController objProductsController = new ICProductsController();
        //    List<ICProductsInfo> objProductsInfoList = objProductsController.GetProductByDepartmentID(DepartmentID.Wood);
        //    if(objProductsInfoList!=null&& objProductsInfoList.Count>0)
        //    {
        //        ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
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
        //private void RpItemComponent_Click(object sender, EventArgs e)
        //{
        //    ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Screen.Module).CurrentModuleEntity;
        //    MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
        //    if(!objProductionNormItemsInfo.MMProductionNormItemIsComponent)
        //    ((ProductionNormModule)Screen.Module).ShowProductionNormItemMeterial(objProductionNormItemsInfo);


        //}
    }
}

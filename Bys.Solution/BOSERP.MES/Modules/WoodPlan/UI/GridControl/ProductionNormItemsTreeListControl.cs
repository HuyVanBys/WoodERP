using BOSComponent;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;


namespace BOSERP.Modules.WoodPlan
{
    public partial class ProductionNormItemsTreeListControl : BOSTreeListControl
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        protected override void InitTreeListDataSource()
        {
            WoodPlanEntities entity = (WoodPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            dataSource = entity.BatchProductProductionNormItemList;
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

        }



        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns

            AddTreeListColumns(1, "MMBatchProductProductionNormItemNo", true, false);
            AddTreeListColumns(2, "MMBatchProductProductionNormItemProductName", true, false);
            AddTreeListColumns(3, "MMProductDryHeight", true, false);
            AddTreeListColumns(4, "MMBatchProductProductionNormItemProductHeight", true, false);
            AddTreeListColumns(5, "MMBatchProductProductionNormItemProductWidth", true, false);
            AddTreeListColumns(6, "MMBatchProductProductionNormItemProductLength", true, false);
            AddTreeListColumns(7, "MMBatchProductProductionNormItemProductJoinery", true, false);
            AddTreeListColumns(8, "DepartmentValue", true, false);
            AddTreeListColumns(9, "MMBatchProductProductionNormItemProductWoodType", true, false);
            AddTreeListColumns(10, "MMBatchProductProductionNormItemQuantity", true, false);
            AddTreeListColumns(11, "MMProductQty", true, false);
            AddTreeListColumns(12, "MMProductTotalQty", true, false);
            AddTreeListColumns(13, "MMBatchProductProductionNormItemBlocks", true, false);
            AddTreeListColumns(14, "MMProductDryBlocks", true, false);
            AddTreeListColumns(14, "MMBatchProductProductionNormItemComment", true, false);
            AddTreeListColumns(15, "MMProductIsReuse", true, false);
            #endregion


            this.OptionsView.ShowSummaryFooter = true;
            this.OptionsBehavior.ImmediateEditor = true;
            this.GetCustomSummaryValue += new GetCustomSummaryValueEventHandler(ProductionNormItemsTreeListControl_GetCustomSummaryValue);
        }

        void ProductionNormItemsTreeListControl_GetCustomSummaryValue(object sender, GetCustomSummaryValueEventArgs e)
        {
            if (e.IsSummaryFooter)
            {
                WoodPlanEntities entity = (WoodPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                if (e.Column.FieldName == "MMProductTotalQty")
                {
                    e.CustomValue = entity.SumProductTotalQty;
                }
                if (e.Column.FieldName == "MMBatchProductProductionNormItemBlocks")
                {
                    e.CustomValue = entity.SumBatchProductProductionNormItemBlock;
                }
                if (e.Column.FieldName == "MMProductDryBlocks")
                {
                    e.CustomValue = entity.SumProductDryBlock;
                }

            }
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

            //Mã vật tư
            if (fieldName == "MMBatchProductProductionNormItemNo")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Caption = "Mã vật tư";
            }
            if (fieldName == "MMBatchProductProductionNormItemProductName")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Caption = "Tên vật tư";
            }
            if (fieldName == "MMProductDryHeight")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Dày thô";
            }
            if (fieldName == "MMBatchProductProductionNormItemProductHeight")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Dày";
            }
            if (fieldName == "MMBatchProductProductionNormItemProductWidth")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Rộng";
            }
            if (fieldName == "MMBatchProductProductionNormItemProductLength")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Dài";
            }
            if (fieldName == "MMBatchProductProductionNormItemProductJoinery")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Mộng";
            }
            if (fieldName == "DepartmentValue")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Đặc tính";
            }
            if (fieldName == "MMBatchProductProductionNormItemProductWoodType")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Loại gỗ";
            }
            if (fieldName == "MMBatchProductProductionNormItemQuantity")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "SL chi tiết";
            }
            if (fieldName == "MMProductQty")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "SL sản phẩm";
            }
            if (fieldName == "MMProductTotalQty")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Tổng SL chi tiết";
            }
            if (fieldName == "MMBatchProductProductionNormItemBlocks")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Khối lượng tinh";
            }
            if (fieldName == "MMProductDryBlocks")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Khối lượng gỗ";
            }

            if (fieldName == "MMBatchProductProductionNormItemComment")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Ghi chú đặc tính";
            }

            if (fieldName == "MMProductIsReuse")
            {
                repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                repositoryItemCheckEdit.AutoHeight = false;
                repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";

                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = "Gỗ tận dụng";
                column.ColumnEdit = repositoryItemCheckEdit;
            }

            this.EndUpdate();
            this.Update();


        }

        private void TreeList_ValidateNode(object sender, ValidateNodeEventArgs e)
        {
            double num;

            if (!double.TryParse(e.Node[Columns["MMBatchProductProductionNormItemQuantity"]].ToString(), out num))
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                this.SetColumnError(Columns["MMBatchProductProductionNormItemQuantity"], ProductionNormLocalizeResources.InputNotCorrectFornat);
            }
        }

    }
}

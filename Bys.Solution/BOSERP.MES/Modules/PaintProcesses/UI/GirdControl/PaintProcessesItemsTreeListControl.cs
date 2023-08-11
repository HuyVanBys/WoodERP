using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraTreeList;
//using BOSERP.Modules.PaintProcesses.Localization;

namespace BOSERP.Modules.PaintProcesses
{
    public partial class PaintProcessesItemsTreeListControl : BOSTreeListControl
    {
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            PaintProcessesEntities entity = (PaintProcessesEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            MMPaintProcessesItemsController objPaintProcessesItemsController = new MMPaintProcessesItemsController();
            dataSource = entity.PaintProcessesItemList;
            DataSource = dataSource;
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
            this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(PaintProcessesItemsTreeListControl_CustomDrawNodeCell);
            this.GetCustomSummaryValue += new GetCustomSummaryValueEventHandler(PaintProcessesItemsTreeListControl_GetCustomSummaryValue);

        }

        void PaintProcessesItemsTreeListControl_GetCustomSummaryValue(object sender, GetCustomSummaryValueEventArgs e)
        {
            if (e.IsSummaryFooter)
            {
                if (e.Column.FieldName == "MMPaintProcessesItemProductQty")
                {
                    e.CustomValue = ((PaintProcessesModule)Screen.Module).GetSumPaintProcessesItemQty();
                }
                if (e.Column.FieldName == "MMPaintProcessesItemTotalCost")
                {
                    e.CustomValue = ((PaintProcessesModule)Screen.Module).GetSumPaintProcessesItemAmount();
                }
            }
        }
        private void PaintProcessesItemsTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.CellValue != null)
                {
                    ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                    ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(int.Parse(e.CellValue.ToString()));
                    if (objMeasureUnitsInfo != null && objMeasureUnitsInfo.ICMeasureUnitID > 0)
                        e.CellText = objMeasureUnitsInfo.ICMeasureUnitName;
                    else
                        e.CellText = string.Empty;
                }
                else
                {
                    e.CellText = string.Empty;
                }

            }
            //if (e.Column.FieldName == "FK_PackagingProductID")
            //{
            //    if (e.CellValue != null)
            //    {
            //        ICProductsInfo obj = BOSApp.CurrentProductList.Where(i => i.ICProductID == int.Parse(e.CellValue.ToString())).FirstOrDefault();
            //        if (obj != null)
            //            e.CellText = obj.ICProductName;
            //    }
            //}
        }

        //private void EnableColumns(int visibleIndex, string fieldName, bool readOnly, bool allowEdit)
        //{
        //    TreeListColumn column;

        //    column = this.Columns.ColumnByFieldName(fieldName);
        //    if (column != null)
        //    {
        //        column.VisibleIndex = visibleIndex;
        //        column.OptionsColumn.AllowEdit = allowEdit;
        //        column.OptionsColumn.ReadOnly = readOnly;
        //        this.OptionsView.AutoWidth = false;

        //        column.OptionsColumn.FixedWidth = false;                

        //        if (fieldName == "MMPaintProcessesItemTotalCost" || fieldName == "MMPaintProcessesItemProductQty")
        //        {
        //            column.AllNodesSummary = true;
        //            column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
        //            column.RowFooterSummaryStrFormat = "{0:0,####}";

        //        }
        //    }
        //}

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            //Columns.Clear();
            //#region InitTreeListColumns

            EnableColumns(0, "MMPaintProcessesItemGroupName", false, true, false, string.Empty);
            EnableColumns(1, "MMPaintProcessesItemNo", true, false, false, string.Empty);
            EnableColumns(2, "MMPaintProcessesItemDesc", true, false, false, string.Empty);
            EnableColumns(3, "MMPaintProcessesItemProductQty", false, true, true, "{0:0,####}");
            EnableColumns(4, ProductionNormConst.FK_ICMeasureUnitID, false, true, false, string.Empty);
            EnableColumns(5, "MMPaintProcessesItemProductUnitCost", false, true, false, string.Empty);
            EnableColumns(6, "MMPaintProcessesItemTotalCost", false, true, true, "{0:0,####}");
            EnableColumns(7, "MMPaintProcessesItemMixRatio", false, true, false, string.Empty);
            EnableColumns(8, "MMPaintProcessesItemWaitingTime", false, true, true, "{0:0,####}");
            EnableColumns(9, "FK_PackagingProductID", false, true, false, string.Empty);
            EnableColumns(10, "MMPaintProcessesItemPasNumber", false, true, false, "{0:0,####}");
            EnableColumns(11, "MMPaintProcessesItemViscosity", false, true, false, string.Empty);
            EnableColumns(12, "MMPaintProcessesItemSortOrder", false, true, false, string.Empty);
            EnableColumns(12, "MMPaintProcessesItemExecuteMethod", false, true, false, string.Empty);

            //AddTreeListColumns(0, "MMPaintProcessesItemGroupName", false, true);
            //AddTreeListColumns(1, "MMPaintProcessesItemNo", true, false);
            //AddTreeListColumns(2, "MMPaintProcessesItemDesc", true, false);
            //AddTreeListColumns(3, "MMPaintProcessesItemProductQty", false, true);
            //AddTreeListColumns(4, ProductionNormConst.FK_ICMeasureUnitID, false, true);
            //AddTreeListColumns(5, "MMPaintProcessesItemProductUnitCost", false, true);
            //AddTreeListColumns(6, "MMPaintProcessesItemTotalCost", false, true);
            //AddTreeListColumns(7, "MMPaintProcessesItemMixRatio", false, true);
            //AddTreeListColumns(8, "MMPaintProcessesItemWaitingTime", false, true);
            //AddTreeListColumns(9, "FK_PackagingProductID", false, true);
            //AddTreeListColumns(10, "MMPaintProcessesItemPasNumber", false, true);
            //AddTreeListColumns(11, "MMPaintProcessesItemViscosity", false, true);
            //#endregion
            ////this.ClearSorting();
            //if (Columns["MMPaintProcessesItemSortOrder"] == null)
            //{
            //    this.BeginUpdate();
            //    TreeListColumn column = Columns.Add();
            //    column.FieldName = "MMPaintProcessesItemSortOrder";
            //    column.Caption = "SortOrder";
            //    column.Visible = false;
            //    this.EndUpdate();
            //    this.Update();
            //}
            this.OptionsView.ShowSummaryFooter = true;
            this.OptionsBehavior.ImmediateEditor = true;
        }
        //public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        //{
        //    this.BeginUpdate();
        //    TreeListColumn column = Columns.Add();
        //    column.Visible = true;
        //    column.OptionsColumn.AllowEdit = AllowEdit;
        //    column.OptionsColumn.ReadOnly = readOnly;
        //    this.OptionsView.AutoWidth = false;

        //    column.OptionsColumn.FixedWidth = false;
        //    column.VisibleIndex = visibleIndex;
        //    column.FieldName = fieldName;

        //    if (fieldName == "MMPaintProcessesItemTotalCost" || fieldName == "MMPaintProcessesItemProductQty")
        //    {
        //        column.AllNodesSummary = true;
        //        column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
        //        column.RowFooterSummaryStrFormat = "{0:0,####}";

        //    }




        //    if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //        RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
        //        repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
        //        repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
        //        repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //        repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
        //        repositoryItemLookUpEdit.NullText = string.Empty;
        //        repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
        //        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
        //        column.ColumnEdit = repositoryItemLookUpEdit;
        //        column.MinWidth = 50;
        //        this.RepositoryItems.Add(repositoryItemLookUpEdit);
        //    }
        //    if (fieldName == "FK_PackagingProductID")
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //        RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
        //        repositoryItemLookUpEdit.DisplayMember = "ICProductName";
        //        repositoryItemLookUpEdit.ValueMember = "ICProductID";
        //        repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //        repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
        //        repositoryItemLookUpEdit.NullText = string.Empty;
        //        repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã"));
        //        repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên"));
        //        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(PackagingProductLookUpEdit_QueryPopUp);
        //        column.ColumnEdit = repositoryItemLookUpEdit;
        //        column.MinWidth = 50;
        //        this.RepositoryItems.Add(repositoryItemLookUpEdit);
        //    }
        //    //Get Caption
        //    AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
        //    DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.MMPaintProcessesItemTableName);
        //    if (dsColumns.Tables.Count > 0)
        //    {
        //        foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
        //        {
        //            AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
        //            if (objAAColumnAliasInfo != null)
        //            {
        //                if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
        //                    column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
        //            }
        //        }
        //    }
        //    this.EndUpdate();
        //    this.Update();
        //}
        //public void PackagingProductLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    //ICProductsController pController = new ICProductsController();
        //    List<ICProductsInfo> PList = ((PaintProcessesModule)Screen.Module).GetMaterialList();
        //    lookUpEdit.Properties.DataSource = PList;
        //}
        //public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((PaintProcessesModule)Screen.Module).GetMeasureUnit();
        //    lookUpEdit.Properties.DataSource = dt;
        //}
        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {

        }


    }
}
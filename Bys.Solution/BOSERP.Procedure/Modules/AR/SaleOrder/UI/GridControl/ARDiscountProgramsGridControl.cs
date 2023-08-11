using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARDiscountProgramsGridControl : BOSGridControl
    {
        List<ICProductsInfo> objProductsInfoList { get; set; }

        private bool IsDoubleClick = false;

        public void InvalidateDataSource(List<ARDiscountProgramsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            gridview.OptionsView.ShowDetailButtons = true;
            gridview.OptionsDetail.AllowExpandEmptyDetails = false;
            gridview.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            gridview.OptionsDetail.ShowDetailTabs = false;
            GridColumn column = gridview.Columns["Selected"];
            if (column != null)
            {
                column.VisibleIndex = 0;
            }
            objProductsInfoList = new List<ICProductsInfo>();
            BOSApp.CurrentProductList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                objProductsInfoList.Add(newObj);
            });
            gridview.EndGrouping += new EventHandler(gridView_EndGrouping);
            //gridview.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            gridview.MasterRowGetChildList += new MasterRowGetChildListEventHandler(gridview_MasterRowGetChildList);
            gridview.MasterRowGetRelationName += new MasterRowGetRelationNameEventHandler(gridview_MasterRowGetRelationName);
            gridview.MasterRowGetRelationCount += new MasterRowGetRelationCountEventHandler(gridview_MasterRowGetRelationCount);
            gridview.MasterRowExpanded += new CustomMasterRowEventHandler(gridview_MasterRowExpanded);
            gridview.MasterRowExpanding += new MasterRowCanExpandEventHandler(gridview_MasterRowExpanding);
            gridview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridview_FocusedRowChanged);
            gridview.ExpandAllGroups();
            return gridview;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        void gridview_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (gridview == null)
                return;

            ARDiscountProgramsInfo objDiscountProgramsInfo = (ARDiscountProgramsInfo)gridview.GetRow(e.RowHandle);
            if (objDiscountProgramsInfo == null)
                return;

            if (objDiscountProgramsInfo.ARDiscountProgramType == DiscountProgramType.BonusSales.ToString())
                e.ChildList = objDiscountProgramsInfo.DiscountProgramItemTargetList;
            else
                e.ChildList = objDiscountProgramsInfo.DiscountProgramItemList;
        }

        void gridview_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "FK_ARDiscountProgramID";
        }

        void gridview_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        void gridview_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView gridView = (GridView)sender;
            GridView detail = (GridView)gridView.GetDetailView(e.RowHandle, e.RelationIndex);
            if (detail == null)
                return;

            gridView.BeginUpdate();
            detail.OptionsView.ShowAutoFilterRow = false;
            detail.OptionsView.ShowFooter = false;
            detail.Columns.Clear();
            ARDiscountProgramsInfo objDiscountProgramsInfo = (ARDiscountProgramsInfo)gridView.GetRow(e.RowHandle);
            string tableName = TableName.ARDiscountProgramItemsTableName;
            if (objDiscountProgramsInfo != null && objDiscountProgramsInfo.ARDiscountProgramType == DiscountProgramType.BonusSales.ToString())
                tableName = TableName.ARDiscountProgramItemTargetsTableName;

            ADReportsController reportController = new ADReportsController();
            List<AAColumnAliasInfo> columnAlias = reportController.GetByTableNameWithNumberIntOrder(tableName);
            GridColumn column;
            int visibleIndex = 0;
            columnAlias.ForEach(o =>
            {
                column = new GridColumn();
                column.Caption = o.AAColumnAliasCaption;
                column.FieldName = o.AAColumnAliasName;
                column.Visible = true;
                column.VisibleIndex = visibleIndex++;
                column.OptionsColumn.AllowEdit = false;
                if (column.FieldName == "ARDiscountProgramItemCalMethod"
                    || column.FieldName == "ARDiscountProgramItemApplyOn"
                    || column.FieldName == "ARDiscountProgramItemTargetType")
                {
                    String strConfigValueTable = String.Empty;

                    if (o.AAColumnAliasName.EndsWith("Combo"))
                        strConfigValueTable = o.AAColumnAliasName.Substring(2, o.AAColumnAliasName.Length - 7);
                    else
                        strConfigValueTable = o.AAColumnAliasName.Substring(2, o.AAColumnAliasName.Length - 2);

                    if (ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable] != null)
                    {
                        RepositoryItemBOSLookupEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable], o.AAAllowDummy);
                        rep.ColumnName = o.AAColumnAliasName;
                        column.ColumnEdit = rep;
                    }
                    else
                    {
                        column.ColumnEdit = InitColumnRepositoryFromFieldFormatGroup(tableName, o.AAColumnAliasName);
                        if (column.ColumnEdit != null)
                            column.ColumnEdit.MouseWheel += new MouseEventHandler(ColumnEdit_MouseWheel);
                    }
                }
                if (column.FieldName == "FK_ICProductID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
                    repositoryItemLookUpEdit.ValueMember = "ICProductID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm", 150));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên sản phẩm", 300));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả", 300));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "ARDiscountProgramItemBasicPrice"
                    || column.FieldName == "ARDiscountProgramItemProductUnitPrice"
                    || column.FieldName == "ARDiscountProgramItemValue"
                    || column.FieldName == "ARDiscountProgramItemTargetRate"
                    || column.FieldName == "ARDiscountProgramItemTargetValue"
                    || column.FieldName == "ARDiscountProgramItemTargetBonus01"
                    || column.FieldName == "ARDiscountProgramItemTargetBonus02")
                {
                    FormatNumbericColumn(column, false, "n2");
                }
                detail.Columns.Add(column);
            });
            detail.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridview_CustomColumnDisplayText1);
            detail.BestFitColumns();
            gridView.EndUpdate();
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = objProductsInfoList;
        }

        void gridview_CustomColumnDisplayText1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.FieldName == "FK_ICProductID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == id);
                    if (iProduct != null)
                    {
                        e.DisplayText = iProduct.ICProductNo;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
        }

        void ColumnEdit_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        void gridview_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            if (IsDoubleClick)
            {
                e.Allow = false;
                IsDoubleClick = false;
            }
        }

        void gridview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridview = (GridView)MainView;
            gridview.CollapseAllDetails();
        }
    }
}

using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ChangeBOMInformation
{
    public class ChangeBOMInformationItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ChangeBOMInformationItemList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            gridView.GroupFormat = "[#image]{1} {2}";
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ChangeBOMInformationModule)Screen.Module).DeleteItemFromChangeBOMInformationItemList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column;

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemOrderNo;
            column.OptionsColumn.AllowEdit = false;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            column.UnboundExpression = gridView.RowCount.ToString();
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.HREmployeeNameCaption;
            column.FieldName = "MMChangeBOMInformationItemHREmployeeName";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.GEObjectHistoryActionCaption;
            column.FieldName = "MMChangeBOMInformationItemActionType";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemNoCaption;
            column.FieldName = "MMChangeBOMInformationItemNo";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemNameCaption;
            column.FieldName = "MMChangeBOMInformationItemName";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemDescCaption;
            column.FieldName = "MMChangeBOMInformationItemDesc";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemOldValueCaption;
            column.FieldName = "MMChangeBOMInformationItemOldValue";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemNewValueCaption;
            column.FieldName = "MMChangeBOMInformationItemNewValue";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemUpdateDateCaption;
            column.FieldName = "MMChangeBOMInformationItemUpdateDate";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Loai DM";
            column.FieldName = "GEObjectHistoryObjectName";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Giá trị LSX";
            column.FieldName = "MMChangeBOMInformationItemBPProductionNormValues";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMChangeBOMInformationItemsInfo objChangeBOMInformationItemsInfo = new MMChangeBOMInformationItemsInfo();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            if (e.Column.FieldName == "MMChangeBOMInformationItemActionType")
            {
                if (e.Value != null)
                {
                    if (e.Value.Equals(ProductionNormLocalizeResources.Change))
                        e.DisplayText = ProductionNormLocalizeResources.ChangeDispalyText;
                    if (e.Value.Equals(ProductionNormLocalizeResources.New))
                        e.DisplayText = ProductionNormLocalizeResources.NewDispalyText;
                    if (e.Value.Equals(ProductionNormLocalizeResources.Delete))
                        e.DisplayText = ProductionNormLocalizeResources.DeleteDispalyText;
                }
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                //BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                //BOSDbUtil dbUtil = new BOSDbUtil();
                //int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                //((BaseTransactionModule)Screen.Module).ShowInventory(productID, true, true);
            }
        }
    }
}

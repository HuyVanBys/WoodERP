using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.InvBalance
{
    public partial class ICInvBalancesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InvBalanceEntities entity = (InvBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvBalanceList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
            }


            GridColumn column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;

            }

            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            gridView.OptionsView.ShowFooter = true;
            return gridView;
        }

        private void repositoryLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            lookUpEdit.Properties.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = "Lưu";
            column.FieldName = "SaveItem";
            RepositoryItemHyperLinkEdit rpSaveItem = new RepositoryItemHyperLinkEdit();
            rpSaveItem.NullText = "Lưu";
            rpSaveItem.Click += new EventHandler(rpSaveItem_Click);
            column.ColumnEdit = rpSaveItem;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = "Tên sản phẩm";
            column.FieldName = "ICProductName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mô tả";
            column.FieldName = "ICProductDesc";
            gridView.Columns.Add(column);
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceDate", BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1));
            gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            gridView.SetRowCellValue(e.RowHandle, "FK_GECurrencyID", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            gridView.SetRowCellValue(e.RowHandle, "FK_HREmployeeID", BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceQty", 1);
            gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceFactor", 1);
            gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceExchangeQty", 1);
            gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceExchangeRate", 1);
        }

        private void rpSaveItem_Click(object sender, EventArgs e)
        {
            ((InvBalanceModule)Screen.Module).SaveItem();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InvBalanceModule)Screen.Module).DeleteItem();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            if (e.Column.FieldName == "FK_ICProductID")
            {
                ((InvBalanceModule)Screen.Module).ChangedProduct();
            }
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                ((InvBalanceModule)Screen.Module).ChangeItemMeasureUnit();
            }
            ((InvBalanceModule)Screen.Module).ChangedItem();
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICInvBalancesInfo item = (ICInvBalancesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                if (item.FK_ICProductID == 0)
                    return;
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
        }
    }
}

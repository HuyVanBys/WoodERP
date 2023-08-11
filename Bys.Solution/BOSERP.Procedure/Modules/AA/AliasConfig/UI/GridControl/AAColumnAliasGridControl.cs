using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AliasConfig
{
    public partial class AAColumnAliasGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AliasConfigEntities entity = (AliasConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ColumnAliasList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
            }

            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            gridView.OptionsView.ShowFooter = true;
            return gridView;
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

            Dictionary<string, string> columns = new Dictionary<string, string>()
            {
                {"AATableName","Tên bảng"},
                {"AAColumnAliasName","Tên trường"},
                {"AAColumnAliasCaption","Tiêu đề"},
                {"AAReferenceTable","Tên bảng liên kết"},
                {"AADisplayedMember","Cột hiển thị"},
                {"AAFilteredColumn","Bộ lọc"},
                {"AAFilteredValues","Giá trị lọc"},
                {"AAAllowDummy","Hiển thị trống"},
                {"AAColumnAliasIsSaveHistory","Lưu lịch sử thay đổi"},
            };

            for (int i = 0; i < columns.Count; i++)
            {
                var item = columns.ElementAt(i);
                column = new GridColumn();
                column.Caption = item.Value;
                column.FieldName = item.Key;
                gridView.Columns.Add(column);
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            //gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceDate", BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1));
            //gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            //gridView.SetRowCellValue(e.RowHandle, "FK_GECurrencyID", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            //gridView.SetRowCellValue(e.RowHandle, "FK_HREmployeeID", BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            //gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceQty", 1);
            //gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceFactor", 1);
            //gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceExchangeQty", 1);
            //gridView.SetRowCellValue(e.RowHandle, "ICInvBalanceExchangeRate", 1);
        }

        private void rpSaveItem_Click(object sender, EventArgs e)
        {
            ((AliasConfigModule)Screen.Module).SaveItem();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AliasConfigModule)Screen.Module).DeleteItem();
            }
        }
    }
}

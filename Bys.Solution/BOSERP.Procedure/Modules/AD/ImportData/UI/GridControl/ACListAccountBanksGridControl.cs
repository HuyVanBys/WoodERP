using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ImportData
{
    public partial class ACListAccountBanksGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            gridView.OptionsView.ShowFooter = true;
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            gridView.Columns.Clear();

            GridColumn column = new GridColumn();
            column.Caption = "Số tài khoản";
            column.FieldName = "ACListAccountBankAccount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Swift code";
            column.FieldName = "ACListAccountBankSwiftCode";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên ngân hàng";
            column.FieldName = "ACListAccountBankName";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chi nhánh";
            column.FieldName = "ACListAccountBankBranch";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tỉnh/TP";
            column.FieldName = "FK_ACListAccountBankBranchCityID";
            RepositoryItemLookUpEdit repository = new RepositoryItemLookUpEdit();
            List<GEStateProvincesInfo> ds = (new GEStateProvincesController()).getAllAliveStateProvinces();
            repository.DataSource = ds;
            repository.DisplayMember = "GEStateProvinceName";
            repository.ValueMember = "GEStateProvinceID";
            repository.NullText = string.Empty;
            repository.Columns.Add(new LookUpColumnInfo("GEStateProvinceName", "Tỉnh thành"));
            repository.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryCity_QueryPopUp);
            column.ColumnEdit = repository;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đối tượng trên ERP";
            column.FieldName = "ACObjectAccessKey";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Người thụ hưởng";
            column.FieldName = "ACListAccountBankAccountHolder";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số CMND người thụ hưởng";
            column.FieldName = "ACListAccountBankAccountHolderIDNumber";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày cấp";
            column.FieldName = "ACListAccountBankAccountHolderIDCardDate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nơi cấp";
            column.FieldName = "ACListAccountBankAccountHolderCity";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        private void repositoryCity_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<GEStateProvincesInfo> ds = (new GEStateProvincesController()).getAllAliveStateProvinces();
            lookUpEdit.Properties.DataSource = ds;
            lookUpEdit.Properties.DisplayMember = "GEStateProvinceName";
            lookUpEdit.Properties.ValueMember = "GEStateProvinceID";
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                gridView.DeleteSelectedRows();
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
        }
    }
}

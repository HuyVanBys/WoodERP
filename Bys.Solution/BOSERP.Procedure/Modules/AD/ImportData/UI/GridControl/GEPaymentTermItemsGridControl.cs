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
using BOSLib;

namespace BOSERP.Modules.ImportData
{
    public partial class GEPaymentTermItemsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            gridView.OptionsView.ShowFooter = true;

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            GridColumn column1 = gridView.Columns["GEPaymentTermItemPaymentDate"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                ADConfigValuesController controller = new ADConfigValuesController();
                DataSet ds = controller.GetActiveConfigValuesByADConfigKeyGroup("PaymentTermItemPaymentDate");
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "Text";
                repositoryItemLookUpEdit.ValueMember = "Value";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("Text", "Thời điểm thanh toán"));
                repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }

            return gridView;
        }

        private void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController controller = new ADConfigValuesController();
            DataSet ds = controller.GetActiveConfigValuesByADConfigKeyGroup("PaymentTermItemPaymentDate");
            lookUpEdit.Properties.DataSource = ds.Tables[0];
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã DKTT";
            column.FieldName = "GEPaymentTermNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên DKTT";
            column.FieldName = "GEPaymentTermName";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
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

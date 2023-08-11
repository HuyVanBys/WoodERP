using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRequest
{
    public class AdvanceRequestItemLoanDetailsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRAdvanceRequestItemLoanDetailsList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.FieldName = "HRAdvanceRequestItemLoanDetailDate";
            column.OptionsColumn.AllowEdit = true;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            column.DisplayFormat.FormatString = "MM/yyyy";
            column.Caption = "Tháng";
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.FieldName = "HRAdvanceRequestItemLoanDetailTotalAmount";
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Số tiền";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.FieldName = "HRAdvanceRequestItemLoanDetailStatus";
            column.OptionsColumn.AllowEdit = false;
            column.Caption = "Tình trạng trả";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Delete";
            column.Caption = "Xóa";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Xóa";
            rep1.Click += new EventHandler(repDelete_Click);
            column.ColumnEdit = rep1;
            gridView.Columns.Add(column);

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["HRAdvanceRequestItemLoanDetailDate"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 0;
            }
            column = gridView.Columns["HRAdvanceRequestItemLoanDetailTotalAmount"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 1;
            }
            column = gridView.Columns["HRAdvanceRequestItemLoanDetailStatus"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 2;
            }
            column = gridView.Columns["Delete"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 3;
            }

            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "HRAdvanceRequestItemLoanDetailStatus")
            {
                if (e.Value != null)
                {
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(ConfigValueGroup.AdvanceRequestItemLoanDetailStatus.ToString(), e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                HRAdvanceRequestItemLoanDetailsInfo item = (HRAdvanceRequestItemLoanDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "HRAdvanceRequestItemLoanDetailTotalAmount" && item.HRAdvanceRequestItemLoanDetailStatus == AdvanceRequestItemLoanDetailStatus.Paid.ToString())
                {
                    GridView gridView1 = (GridView)MainView;
                    if (item.HRAdvanceRequestItemLoanDetailTotalAmount != Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString()))
                    {
                        MessageBox.Show("Không thể sửa tháng đã trả", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        item.HRAdvanceRequestItemLoanDetailTotalAmount = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                    }
                }
                if (e.Column.FieldName == "HRAdvanceRequestItemLoanDetailDate" && item.HRAdvanceRequestItemLoanDetailStatus == AdvanceRequestItemLoanDetailStatus.Paid.ToString())
                {
                    GridView gridView1 = (GridView)MainView;
                    DateTime oldDate = Convert.ToDateTime(gridView1.ActiveEditor.OldEditValue.ToString());
                    if (oldDate.Month != item.HRAdvanceRequestItemLoanDetailDate.Month ||
                            oldDate.Year != item.HRAdvanceRequestItemLoanDetailDate.Year)
                    {
                        MessageBox.Show("Không thể sửa tháng đã trả", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        item.HRAdvanceRequestItemLoanDetailDate = Convert.ToDateTime(gridView1.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
        }

        void repDelete_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            HRAdvanceRequestItemLoanDetailsInfo item = (HRAdvanceRequestItemLoanDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (gridView.FocusedRowHandle >= 0 && item.HRAdvanceRequestItemLoanDetailStatus != AdvanceRequestItemLoanDetailStatus.Paid.ToString())
            {
                ((AdvanceRequestModule)Screen.Module).RemoveSelectedLoanDetailItem();
            }
        }
    }
}

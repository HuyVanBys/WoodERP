using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.AdvanceRequest
{
    public partial class AdvanceRequestItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AdvanceRequestItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Detail";
            column.Caption = "Chi tiết";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Chi tiết";
            rep1.Click += new EventHandler(repDetail_Click);
            column.ColumnEdit = rep1;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;

            GridColumn column = gridView.Columns["HRAdvanceRequestItemTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("HRAdvanceRequestItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            }

            //TNDLoc [ADD][01/08/2018][Advance request loan],START
            column = gridView.Columns["HRAdvanceRequestItemPaymentStartDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRAdvanceRequestItemPaymentMonthQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRAdvanceRequestItemPaymentPerMonthAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRAdvanceRequestTypeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            //TNDLoc [ADD][01/08/2018][Advance request loan],END
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AdvanceRequestModule)Screen.Module).RemoveSelectedItem();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            AdvanceRequestEntities entity = (AdvanceRequestEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;

            if (entity.AdvanceRequestItemList.CurrentIndex >= 0)
            {
                HRAdvanceRequestItemsInfo item = entity.AdvanceRequestItemList[entity.AdvanceRequestItemList.CurrentIndex];
                if (e.Column.FieldName == "HRAdvanceRequestItemTotalAmount")
                {
                    decimal totalItems = entity.AdvanceRequestItemList.Sum(o => o.HRAdvanceRequestItemTotalAmount);
                    mainObject.HRAdvanceRequestTotalAmount = totalItems;
                }

                if (e.Column.FieldName == "HRAdvanceRequestItemTotalAmount" || e.Column.FieldName == "HRAdvanceRequestItemPaymentMonthQty")
                {
                    item.HRAdvanceRequestItemPaymentPerMonthAmount = item.HRAdvanceRequestItemPaymentMonthQty == 0 ? 0 : item.HRAdvanceRequestItemTotalAmount / item.HRAdvanceRequestItemPaymentMonthQty;
                }

                ((AdvanceRequestModule)Screen.Module).CalPaymentPerMonthAmount(item);
            }
        }

        void repDetail_Click(object sender, EventArgs e)
        {
            ((AdvanceRequestModule)Screen.Module).ShowLoanDetail();
        }

        public void LoadGridViewByType(bool isComplete, bool isLoan)
        {
            GridView gridView = (GridView)MainView;

            foreach (GridColumn columnedit in gridView.Columns)
            {
                columnedit.OptionsColumn.AllowEdit = !isComplete;
            }

            GridColumn column = gridView.Columns["Detail"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = isLoan;
            }

            column = gridView.Columns["HRAdvanceRequestItemEmployeeNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["HRAdvanceRequestItemEmployeeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["HRAdvanceRequestTypeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            gridView.BestFitColumns();
        }
    }
}

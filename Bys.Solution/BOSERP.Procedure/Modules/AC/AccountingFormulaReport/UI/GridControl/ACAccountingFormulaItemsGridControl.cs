using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountingFormulaReport
{
    public class ACAccountingFormulaItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {

            AccountingFormulaReportEntities entity = (AccountingFormulaReportEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AccountingFormulaItemList;
            this.DataSource = bds;
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.Visible = false;
            }

            if (gridView.Columns["GEAccountingFormulaItemCategory"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemCategory"].Visible = true;
                gridView.Columns["GEAccountingFormulaItemCategory"].VisibleIndex = 1;
            }
            if (gridView.Columns["GEAccountingFormulaItemAccountNo"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemAccountNo"].Visible = true;
                gridView.Columns["GEAccountingFormulaItemAccountNo"].VisibleIndex = 2;
            }
            if (gridView.Columns["GEAccountingFormulaItemAccountDebit"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemAccountDebit"].Visible = true;
                gridView.Columns["GEAccountingFormulaItemAccountDebit"].VisibleIndex = 3;
            }
            if (gridView.Columns["GEAccountingFormulaItemAccountCredit"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemAccountCredit"].Visible = true;
                gridView.Columns["GEAccountingFormulaItemAccountCredit"].VisibleIndex = 4;
            }
            if (gridView.Columns["GEAccountingFormulaItemDemonstration"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemDemonstration"].Visible = true;
                gridView.Columns["GEAccountingFormulaItemDemonstration"].VisibleIndex = 5;
            }
            if (gridView.Columns["EndYearBalance"] != null)
            {
                gridView.Columns["EndYearBalance"].Visible = true;
                gridView.Columns["EndYearBalance"].VisibleIndex = 6;
                gridView.Columns["EndYearBalance"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["EndYearBalance"].DisplayFormat.FormatString = "{0:n}";
            }
            if (gridView.Columns["StartYearBalance"] != null)
            {
                gridView.Columns["StartYearBalance"].Visible = true;
                gridView.Columns["StartYearBalance"].VisibleIndex = 7;
                gridView.Columns["StartYearBalance"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["StartYearBalance"].DisplayFormat.FormatString = "{0:n}";
            }

            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Kỳ này";
            column.FieldName = "EndYearBalance";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Kỳ trước";
            column.FieldName = "StartYearBalance";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}

using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.SellStaff
{
    public partial class HREmployeeGridControl : BOSSearchResultsGridControl
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            // repositoryItemDateEdit
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "dd/MM/yyyy";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.EditFormat.FormatString = "dd/MM/yyyy";
            repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "dd/MM/yyyy";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";

            GridColumn column = gridView.Columns["HREmployeeStopWorkingDate"];
            if (column != null)
            {
                column.ColumnEdit = repositoryItemDateEdit;
            }

            return gridView;
        }
    }
}

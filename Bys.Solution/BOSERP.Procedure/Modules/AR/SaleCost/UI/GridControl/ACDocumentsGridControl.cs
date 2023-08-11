using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.SaleCost.UI
{
    public partial class ACDocumentsGridControl : BaseDocumentGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = gridView.Columns["FK_ACDocumentTypeID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }

            column = new GridColumn();
            column.Caption = "Loại chứng từ";
            column.FieldName = "CreateType";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            

        }
    }
}


using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Document.UI
{
    public partial class ACDocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            DocumentEntities entity = (DocumentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.DocumentEntryList.CurrentIndex >= 0)
            {
                ACDocumentEntrysInfo item = entity.DocumentEntryList[entity.DocumentEntryList.CurrentIndex];

                if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        item = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        ((DocumentModule)Screen.Module).UpdateAccountDebitDocumentEntrys(item);
                    }
                }
            }
        }
    }
}


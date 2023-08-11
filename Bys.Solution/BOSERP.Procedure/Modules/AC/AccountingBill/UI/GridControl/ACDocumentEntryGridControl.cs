using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.AccountingBill.UI
{
    public partial class ACDocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AccountingBillEntities entity = (AccountingBillEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.DocumentEntryList.CurrentIndex >= 0)
            {
                ACDocumentEntrysInfo item = entity.DocumentEntryList[entity.DocumentEntryList.CurrentIndex];

                if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        item = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        ((AccountingBillModule)Screen.Module).UpdateAccountDebitDocumentEntrys(item);
                    }
                }
            }
        }
    }
}


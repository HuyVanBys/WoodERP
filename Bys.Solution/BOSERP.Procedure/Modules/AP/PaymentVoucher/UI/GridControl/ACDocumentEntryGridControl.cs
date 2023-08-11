using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.PaymentVoucher.UI
{
    public partial class ACDocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            PaymentVoucherEntities entity = (PaymentVoucherEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.DocumentEntryList.CurrentIndex >= 0)
            {
                ACDocumentEntrysInfo item = entity.DocumentEntryList[entity.DocumentEntryList.CurrentIndex];

                if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        item = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        //((PaymentVoucherModule)Screen.Module).UpdateAccountDebitDocumentEntrys(item);
                    }
                }
            }
        }
    }
}


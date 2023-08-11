namespace BOSERP.Modules.CustomerPayment
{
    public partial class DocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            if (e.Column.FieldName == "ACDocumentEntryAmount" || e.Column.FieldName == "ACDocumentEntryExchangeAmount")
            {
                ((CustomerPaymentModule)Screen.Module).UpdateTotalAmount();
            }
        }
    }
}

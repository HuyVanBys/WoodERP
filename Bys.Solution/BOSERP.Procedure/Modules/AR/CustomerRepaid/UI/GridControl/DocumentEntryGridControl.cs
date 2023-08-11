using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.CustomerRepaid
{
    public partial class DocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            return gridView;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            if (e.Column.FieldName == "ACDocumentEntryAmount" || e.Column.FieldName == "ACDocumentEntryExchangeAmount")
            {
                ((CustomerRepaidModule)Screen.Module).UpdateTotalAmount();
            }
        }
        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            CustomerRepaidEntities entity = (CustomerRepaidEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARCustomerPaymentsInfo objARCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            ACDocumentEntrysInfo objACDocumentEntrysInfo = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objACDocumentEntrysInfo != null)
            {
                ARCustomersController objARCustomersController = new ARCustomersController();
                ARCustomersInfo objARCustomersInfo = (ARCustomersInfo)objARCustomersController.GetObjectByID(objARCustomerPaymentsInfo.FK_ARCustomerID);
                if (objARCustomersInfo != null && objARCustomersInfo.FK_ACAccountSaleID > 0)
                {
                    objACDocumentEntrysInfo.FK_ACDebitAccountID = objARCustomersInfo.FK_ACAccountSaleID;
                }
            }
        }
    }
}

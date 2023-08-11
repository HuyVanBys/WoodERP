using BOSCommon;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.CustomerPaymentTimePayment
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
                //((CustomerPaymentTimePaymentModule)Screen.Module).UpdateTotalAmount();
            }
        }
        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARCustomerPaymentsInfo objARCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            ACDocumentEntrysInfo objACDocumentEntrysInfo = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objACDocumentEntrysInfo != null)
            {
                if (objACDocumentEntrysInfo.ACEntryTypeName == AccEntryType.ChenhLechLai.ToString() || objACDocumentEntrysInfo.ACEntryTypeName == AccEntryType.ChenhLechLo.ToString())
                    return;
                ARCustomersController objARCustomersController = new ARCustomersController();
                ARCustomersInfo objARCustomersInfo = (ARCustomersInfo)objARCustomersController.GetObjectByID(objARCustomerPaymentsInfo.FK_ARCustomerID);
                if (objARCustomersInfo != null && objARCustomersInfo.FK_ACAccountSaleID > 0 && objACDocumentEntrysInfo.ACEntryTypeName != AccEntryType.ThuTienUngTruoc.ToString())
                {
                    objACDocumentEntrysInfo.FK_ACCreditAccountID = objARCustomersInfo.FK_ACAccountSaleID;
                }
                else if (objARCustomersInfo != null && objARCustomersInfo.FK_ACAccountDepositID > 0 && objACDocumentEntrysInfo.ACEntryTypeName == AccEntryType.ThuTienUngTruoc.ToString())
                {
                    objACDocumentEntrysInfo.FK_ACCreditAccountID = objARCustomersInfo.FK_ACAccountDepositID;
                }

            }
        }
    }
}
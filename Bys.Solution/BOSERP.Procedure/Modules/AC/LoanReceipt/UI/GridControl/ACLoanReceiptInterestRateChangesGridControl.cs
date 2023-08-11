using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.LoanReceipt
{
    public partial class ACLoanReceiptInterestRateChangesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LoanReceiptInterestRateChangesList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((LoanReceiptModule)Screen.Module).DeleteItemFromLoanReceiptInterestRateChangesList();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["ACLoanReceiptInterestRateChangeValue"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACLoanReceiptInterestRateChangeStartPeriodChange"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACLoanReceiptInterestRateChangeDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        //protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        //{
        //    base.GridView_ValidatingEditor(sender, e);
        //    LoanReceiptEntities entity = (LoanReceiptEntities)((LoanReceiptModule)Screen.Module).CurrentModuleEntity;
        //    ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
        //    GridView gridView = (GridView)sender;
        //    ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //    if (gridView.FocusedColumn.FieldName == "ACLoanReceiptPaymentPlanRootPayment")
        //    {
        //        if (mainObject.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OriginalPaypal.ToString())
        //        {
        //            if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment > 0)
        //            {
        //                e.ErrorText = "Không được thay đổi gốc vốn vì đã có nợ gốc đã trả";
        //                e.Valid = false;
        //            }
        //        }
        //        if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment < 0)
        //        {
        //            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
        //            e.ErrorText = "Bạn vui lòng nhập gốc vốn lớn hơn 0";
        //            e.Valid = false;
        //        }
        //    }
        //}


    }
}

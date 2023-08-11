using BOSLib;
using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.AllocationCost.UI
{
    /// <summary>
    /// Summary description for DMALC100
    /// </summary>
    public partial class DMALC100 : BOSERPScreen
    {

        public DMALC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();

            fld_dteReceiptFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteReceiptToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        private void fld_btnFindReceipt_Click(object sender, EventArgs e)
        {
            ((AllocationCostModule)Module).SearchReceipt(fld_dteReceiptFromDate.DateTime, fld_dteReceiptToDate.DateTime);
        }

        private void DMALC100_Load(object sender, EventArgs e)
        {

        }

        private void fld_btnRefresh_Click(object sender, EventArgs e)
        {
            ((AllocationCostModule)Module).RefreshInvoiceInData();
        }

        private void fld_lkeAPAllocationCostCriterion_EditValueChanged(object sender, EventArgs e)
        {
            ((AllocationCostModule)Module).RefreshInvoiceInData();
        }

        private void fld_lkeAPAllocationCostCriterion_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value && e.Value != null)
            {
                ((AllocationCostModule)Module).RefreshInvoiceInData(e.Value.ToString());
            }
        }

        private void fld_lkeAPAllocationCostType_EditValueChanged(object sender, EventArgs e)
        {
            string type = ((AllocationCostModule)Module).GetMainObjectType();

            //if (type == AllocationCostType.LumberOutSourcing.ToString())
            //{
            //    fld_gImport.Visible = false;
            //    fld_gLumberOutSourcing.Visible = true;
            //    fld_btnCalculate.Visible = true;
            //}
            //else
            //{
            //    fld_gImport.Visible = true;
            //    fld_gLumberOutSourcing.Visible = false;
            //    fld_btnCalculate.Visible = false;
            //}
            fld_gImport.Visible = false;
            fld_gLumberOutSourcing.Visible = true;
            fld_btnCalculate.Visible = true;
        }

        private void fld_lkeFK_APPurchaseOrderID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_APPurchaseOrderID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value && e.Value != null)
            {
                ((AllocationCostModule)Module).ChangePurchaseOrder((int)e.Value);
            }
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value && e.Value != null)
            {
                ((AllocationCostModule)Module).ChangeBatchProduct((int)e.Value);
            }
        }

        private void fld_btnFindInvoiceIn_Click(object sender, EventArgs e)
        {
            ((AllocationCostModule)Module).ChooseInvoiceIn(fld_dteReceiptFromDate.DateTime, fld_dteReceiptToDate.DateTime);
        }

        private void fld_btnFindShipment_Click(object sender, EventArgs e)
        {
            ((AllocationCostModule)Module).ChooseShipment(fld_dteReceiptFromDate.DateTime, fld_dteReceiptToDate.DateTime);
        }

        private void fld_btnCalculate_Click(object sender, EventArgs e)
        {
            ((AllocationCostModule)Module).CalculateReceipt();
        }

    }
}

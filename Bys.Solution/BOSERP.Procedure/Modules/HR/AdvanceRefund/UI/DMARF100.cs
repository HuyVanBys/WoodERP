using BOSComponent;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRefund.UI
{
    /// <summary>
    /// Summary description for DMARF100
    /// </summary>
    public partial class DMARF100 : BOSERPScreen
    {

        public DMARF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddAdvanceRequest_Click(object sender, EventArgs e)
        {
            ((AdvanceRefundModule)Module).AddAdvanceRequest();
        }

        private void fld_btnAddInvoice_Click(object sender, EventArgs e)
        {
            ((AdvanceRefundModule)Module).AddAdvanceInvoice();
        }

        private void fld_lkeHRAdvanceRefundType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            if (lke.OldEditValue != e.Value)
            {
                ((AdvanceRefundModule)Module).ChangeType(e.Value.ToString());
            }
        }

        private void fld_lkeACObjectAccessKey_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

        }

        private void fld_lkeEmployee_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            if (lke.OldEditValue != e.Value)
            {
                ((AdvanceRefundModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_PMProjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int projectID = 0;
                if (int.TryParse(e.Value.ToString(), out projectID))
                {
                    ((AdvanceRefundModule)Module).ChangeProject(projectID);
                }
            }
        }

        private void fld_dteHRAdvanceRefundDate_Validated(object sender, EventArgs e)
        {
            BOSDateEdit bde = (BOSDateEdit)sender;
            AdvanceRefundEntities entity = (AdvanceRefundEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            //HRAdvanceRefundsInfo advanceRefund = (HRAdvanceRefundsInfo)((BaseModuleERP)Module).CurrentModuleEntity.MainObject;
            if (entity.HRAdvanceRefundItemInvoiceHasInvoiceList.Count > 0)
            {
                bool isShowDialog = false;
                //advanceRefund.HRAdvanceRefundDate = (DateTime)bde.EditValue;
                var newList = (BOSList<HRAdvanceRefundItemInvoicesInfo>)entity.HRAdvanceRefundItemInvoiceHasInvoiceList.Clone();
                entity.HRAdvanceRefundItemInvoiceHasInvoiceList.Clear();
                foreach (HRAdvanceRefundItemInvoicesInfo item in newList)
                {
                    if (item.ACDocumentDate.Date.CompareTo(((DateTime)bde.EditValue).Date) <= 0)
                    {
                        entity.HRAdvanceRefundItemInvoiceHasInvoiceList.Add(item);
                    }
                    else
                    {
                        isShowDialog = true;
                    }
                }
                if (isShowDialog)
                {
                    DialogResult result = MessageBox.Show("Ngày chứng từ hóa đơn đã chọn lớn hơn ngày chứng từ, vui lòng chọn lại chứng từ mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        entity.HRAdvanceRefundItemInvoiceHasInvoiceList.GridControl.RefreshDataSource();
                        ((AdvanceRefundModule)Module).UpdateTotalAmount();
                    }
                }
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AdvanceRefundModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_medHRAdvanceRefundDesc_TextChanged(object sender, EventArgs e)
        {
            ((AdvanceRefundModule)Module).ChangeAdvanceRefundItemInvoiceObjectDesc();
        }
    }
}

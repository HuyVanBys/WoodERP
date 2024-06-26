using BOSCommon;
using System;

namespace BOSERP.Modules.JobTicket.UI
{
    /// <summary>
    /// Summary description for DMJT100
    /// </summary>
    public partial class DMJT100 : BOSERPScreen
    {

        public DMJT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_btnLoadDetailPlan_Click(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).ShowPlanDetail();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).ChangeJobTicketDate(fld_dteMMJobTicketFromDate.DateTime, Convert.ToDateTime(fld_dteMMJobTicketToDate.EditValue));
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).CheckedAllByFilterCondition(fld_chkSelectAll.Checked);
        }

        private void fld_btnApprove_Click(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).ApproveJobTicket();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).CancelJobTicket(null);
        }

        private void fld_btnCloseTicket_Click(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).CloseJobTicket();
        }

        private void fld_btnCapacityReceipt_Click(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).UpdateJobticketQty();
        }
        #region Filter Data

        private void fld_chkStatusNew_CheckedChanged(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).FilterData(fld_dgcMMJobTicketItems, fld_chkStatusNew.Checked, fld_chkStatusCanceled.Checked, fld_chkStatusApproved.Checked, fld_chkStatusClosed.Checked);
        }
        private void fld_chkStatusApproved_CheckStateChanged(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).FilterData(fld_dgcMMJobTicketItems, fld_chkStatusNew.Checked, fld_chkStatusCanceled.Checked, fld_chkStatusApproved.Checked, fld_chkStatusClosed.Checked);
        }

        private void fld_chkStatusClosed_CheckStateChanged(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).FilterData(fld_dgcMMJobTicketItems, fld_chkStatusNew.Checked, fld_chkStatusCanceled.Checked, fld_chkStatusApproved.Checked, fld_chkStatusClosed.Checked);
        }
        private void fld_chkStatusCanceled_CheckStateChanged(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).FilterData(fld_dgcMMJobTicketItems, fld_chkStatusNew.Checked, fld_chkStatusCanceled.Checked, fld_chkStatusApproved.Checked, fld_chkStatusClosed.Checked);
        }

        public bool IsTypeFilter(string type, MMJobTicketItemsInfo obj)
        {
            bool result = false;
            switch (type)
            {
                case "StatusNew":
                    if (obj.MMJobTicketItemStatus == Status.New.ToString())
                        result = true;
                    break;
                case "StatusApproved":
                    if (obj.MMJobTicketItemStatus == Status.Approved.ToString())
                        result = true;
                    break;
                case "StatusClosed":
                    if (obj.MMJobTicketItemStatus == Status.Closed.ToString())
                        result = true;
                    break;
                case "StatusCanceled":
                    if (obj.MMJobTicketItemStatus == Status.Canceled.ToString())
                        result = true;
                    break;
                default:
                    break;
            }
            return result;
        }

        #endregion

        private void fld_lblSelectAll_Click(object sender, EventArgs e)
        {
            fld_chkStatusNew.Checked = true;
            fld_chkStatusApproved.Checked = true;
            fld_chkStatusClosed.Checked = true;
            fld_chkStatusCanceled.Checked = true;
            ((JobTicketModule)Module).FilterData(fld_dgcMMJobTicketItems, fld_chkStatusNew.Checked, fld_chkStatusCanceled.Checked, fld_chkStatusApproved.Checked, fld_chkStatusClosed.Checked);
        }
        private void fld_btnTUpdateEmployee_Click(object sender, EventArgs e)
        {
            ((JobTicketModule)Module).UpdateEmployee();
        }

    }
}

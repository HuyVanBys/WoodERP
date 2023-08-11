using BOSComponent;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.EndingInProgressStatistic.UI
{
    /// <summary>
    /// Summary description for DMEIPS100
    /// </summary>
    public partial class DMEIPS100 : BOSERPScreen
    {

        public DMEIPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((EndingInProgressStatisticModule)Module).ChangeBatchProduct(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            string mess = ((EndingInProgressStatisticModule)Module).GetBatchProductStatus();
            if (!string.IsNullOrEmpty(mess))
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.ShowBalloonTip(10000, "Cảnh báo", mess, ToolTipIcon.Warning);
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void fld_btnEndUnfinished_Click(object sender, EventArgs e)
        {
            ((EndingInProgressStatisticModule)Module).EndUnfinished();
        }
    }
}

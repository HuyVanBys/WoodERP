using BOSCommon;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRequest
{
    public partial class guiLoanDetail : BOSERPScreen
    {
        #region Variables
        public decimal TotalAmount { get; set; }
        public HRAdvanceRequestItemsInfo ObjAdvanceRequestItemsInfo { get; set; }
        public bool IsEditing { get; set; }
        #endregion

        public guiLoanDetail(decimal totalAmount, bool isEditing)
        {
            InitializeComponent();
            TotalAmount = totalAmount;
            IsEditing = isEditing;
        }

        public guiLoanDetail(HRAdvanceRequestItemsInfo objAdvanceRequestItemsInfo)
        {
            InitializeComponent();
            ObjAdvanceRequestItemsInfo = objAdvanceRequestItemsInfo;
            TotalAmount = objAdvanceRequestItemsInfo.HRAdvanceRequestItemTotalAmount;
        }

        private void guiChooseItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcHRAdvanceRequestItemLoanDetailsGridControl.Screen = this;
            fld_dgcHRAdvanceRequestItemLoanDetailsGridControl.InitializeControl();
            //Bind grid control to their list
            AdvanceRequestEntities entity = (AdvanceRequestEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.HRAdvanceRequestItemLoanDetailsList.InitBOSListGridControl(fld_dgcHRAdvanceRequestItemLoanDetailsGridControl);
            //ObjAdvanceRequestItemsInfo.AdvanceRequestItemLoanDetailsList.InitBOSListGridControl(fld_dgcHRAdvanceRequestItemLoanDetailsGridControl);
            string totalAmount = TotalAmount.ToString("n2");
            string paidAmount = entity.HRAdvanceRequestItemLoanDetailsList.Where(o => o.HRAdvanceRequestItemLoanDetailStatus == AdvanceRequestItemLoanDetailStatus.Paid.ToString()).Sum(o => o.HRAdvanceRequestItemLoanDetailTotalAmount).ToString("n2");
            string remainAmount = (TotalAmount - entity.HRAdvanceRequestItemLoanDetailsList.Where(o => o.HRAdvanceRequestItemLoanDetailStatus == AdvanceRequestItemLoanDetailStatus.Paid.ToString()).Sum(o => o.HRAdvanceRequestItemLoanDetailTotalAmount)).ToString("n2");
            fld_txtTotalAmount.Text = totalAmount;
            fld_txtRemainAmount.Text = remainAmount;
            fld_txtPaidAmount.Text = paidAmount;
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
            if (TotalAmount != entity.HRAdvanceRequestItemLoanDetailsList.Sum(o => o.HRAdvanceRequestItemLoanDetailTotalAmount))
            {
                MessageBox.Show("Tổng số tiền trả dưới lưới không bằng Số tiền tạm ứng", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((mainObject.HRAdvanceRequestStatus == AdvanceRequestStatus.New.ToString()) && !IsEditing)
            {
                if (MessageBox.Show("Bạn muốn chắc chắn muốn lưu không?",
                                               CommonLocalizedResources.MessageBoxDefaultCaption,
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
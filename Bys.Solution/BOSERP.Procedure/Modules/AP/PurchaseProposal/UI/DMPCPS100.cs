using BOSComponent;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal.UI
{
    /// <summary>
    /// Summary description for DMPCPS100
    /// </summary>
    public partial class DMPCPS100 : BOSERPScreen
    {

        public DMPCPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductAttributeID.EditValue.ToString(), out productID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (!objProductsInfo.ICProductActiveCheck)
                {
                    MessageBox.Show(PurchaseProposalLocalizedResources.ProductNonActiveCheck, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ((PurchaseProposalModule)Module).AddItemToPurchaseProposalItemsList(productID);
            }
        }

        private void fld_lkeFK_BRBranchID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((PurchaseProposalModule)Module).ChangeBranch(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeAPPurchaseProposalType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((PurchaseProposalModule)Module).ChangeProposalType(e.Value.ToString());
            }
        }

        private void fld_lkeAPProposalAPTypeCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            string inputType = e.Value == null ? string.Empty : e.Value.ToString();
            ((PurchaseProposalModule)Module).ChangedInputType(inputType);
        }

        private void bosDateEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((PurchaseProposalModule)Module).ChangeNeedTime(dt);
                }
            }

        }

        private void bosDateEdit2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((PurchaseProposalModule)Module).ChangeNeedToTime(dt);
                }
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((PurchaseProposalModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void Fld_lkeAPProposalAPTypeCombo_CloseUp_1(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((PurchaseProposalModule)Module).ChangeProposalAPTypeCombo(e.Value.ToString());
            }
        }

        private void fld_btnChooseIngredients_Click(object sender, EventArgs e)
        {
            ((PurchaseProposalModule)Module).ShowBatchProductSchedule();
        }

        private void fld_btnUpdateInventoryStock_Click(object sender, EventArgs e)
        {
            ((PurchaseProposalModule)Module).GetInventoryQty();
        }

        private void fld_linkViewApproval_Click(object sender, EventArgs e)
        {
            ((PurchaseProposalModule)Module).ViewApprovalDetails();
        }

        private void bosLookupEdit3_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            APProposalsInfo mainObject = (APProposalsInfo)((PurchaseProposalModule)Module).CurrentModuleEntity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            lke.Properties.DataSource = objEmployeesController.GetEmployeeList(null, mainObject.FK_HRDepartmentID, mainObject.FK_HRDepartmentRoomID);
        }
    }
}

using BOSComponent;
using System;

namespace BOSERP.Modules.BugManagement.UI
{
    /// <summary>
    /// Summary description for DMBM100
    /// </summary>
    public partial class DMBM100 : BOSERPScreen
    {

        public DMBM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtHRBugManagementDetailQty_Validated(object sender, EventArgs e)
        {
            ((BugManagementModule)Module).UpdateHandleWaitQty();
        }

        private void fld_lkeFK_HRErrorTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                HRErrorTypesController objErrorTypesController = new HRErrorTypesController();
                HRErrorTypesInfo objErrorTypesInfo = (HRErrorTypesInfo)objErrorTypesController.GetObjectByID(objectID);
                if (objErrorTypesInfo != null)
                    fld_lkeHRBugManagementHandleType.EditValue = objErrorTypesInfo.HRBugManagementHandleType;
            }
        }

        private void fld_btnHandle_Click(object sender, EventArgs e)
        {
            ((BugManagementModule)Module).HandleBug();
        }

    }
}

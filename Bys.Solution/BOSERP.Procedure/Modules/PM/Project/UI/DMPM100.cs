using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Project.UI
{
    /// <summary>
    /// Summary description for DMPM100
    /// </summary>
    public partial class DMPM100 : BOSERPScreen
    {

        public DMPM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //((ProjectModule)Module).AddItemToTemplateItemsList();
            }
        }

        private void fld_bedGELocationName_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).ChooseLocation();
        }

        private void fld_btnAddLocation_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).AddProjectLocation();
        }

        private void fld_btnEditLocation_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).EditProjectLocation();
        }

        private void fld_btnDeleteLocation_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).DeleteProjectLocation();
        }

        private void fld_dtePMProjectEstimatedEndDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((ProjectModule)Module).ChangeProjectEstimatedEndDate(dt);
                }
            }
        }

        private void fld_dtePMProjectActualEndDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((ProjectModule)Module).ChangeProjectActualEndDate(dt);
                }
            }
        }

        private void fld_dtePMProjectActualStartDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((ProjectModule)Module).ChangeProjectActualStartDate(dt);
                }
            }
        }

        private void fld_dtePMProjectEstimatedStartDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((ProjectModule)Module).ChangeProjectEstimatedStartDate(dt);
                }
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((ProjectModule)Module).UpdateCustomerInfo(e.Value.ToString());
            }
        }

        private void fld_btnAddCustomers_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).AddNewCustomer();
        }
    }
}

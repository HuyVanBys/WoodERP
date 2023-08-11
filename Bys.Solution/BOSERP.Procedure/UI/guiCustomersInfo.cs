using System;

namespace BOSERP
{
    public partial class guiCustomersInfo : BOSERPScreen
    {
        private ARCustomersInfo CustomerObject;

        public guiCustomersInfo(object a)
        {
            InitializeComponent();
        }

        public guiCustomersInfo(ARCustomersInfo objCustomersInfo, bool showPriceLevelPanel)
        {
            InitializeComponent();

            CustomerObject = objCustomersInfo;
            fld_lblDOB.Text = CustomerObject.ARCustomerContactBirthday.ToShortDateString();
            fld_pnlPriceLevel.Visible = showPriceLevelPanel;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnEditCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            ((BaseModuleERP)Module).ActionEdit("Customer", CustomerObject.ARCustomerID);
        }

        private void guiCustomersInfo_Load(object sender, EventArgs e)
        {
            SetPermission();
            DisplayLabelText(CustomerObject, Controls);
        }
    }
}
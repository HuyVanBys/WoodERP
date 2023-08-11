using BOSComponent;
using System;

namespace BOSERP.Modules.CalculateDiscount.UI
{
    /// <summary>
    /// Summary description for DMDCT100
    /// </summary>
    public partial class DMDCT100 : BOSERPScreen
    {

        public DMDCT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            fld_dteARDiscountProgramBeginDate.DateTime = new DateTime(BOSApp.GetCurrentServerDate().Year, 1, 1);
            fld_dteARDiscountProgramEndDate.DateTime = new DateTime(BOSApp.GetCurrentServerDate().Year, 12, 31);
        }

        private void Fld_btnSearch_Click(object sender, EventArgs e)
        {
            SearchDiscountProgram();
        }

        private void SearchDiscountProgram()
        {

            string discountProgramNo = fld_txtARDiscountProgramNo.Text.Trim();
            string discountProgramName = fld_txtARDiscountProgramName.Text.Trim();

            int customerDistributionChannelID = 0;
            //if (fld_lkeFK_ARCustomerDistributionChannelID.EditValue != null)
            //{
            //    int.TryParse(fld_lkeFK_ARCustomerDistributionChannelID.EditValue.ToString(), out customerDistributionChannelID);
            //}
            string objectAccessKey = string.Empty;
            if (fld_lkeACObjectAccessKey.EditValue != null)
            {
                objectAccessKey = Convert.ToString(fld_lkeACObjectAccessKey.EditValue.ToString());
            }
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);

            DateTime beginDate = fld_dteARDiscountProgramBeginDate.DateTime;
            DateTime endDate = fld_dteARDiscountProgramEndDate.DateTime;
            ((CalculateDiscountModule)Module).SearchDiscountProgram(discountProgramNo, discountProgramName, customerDistributionChannelID, objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, beginDate, endDate);
        }

        private void Fld_btnLoadSalesTarget_Click(object sender, EventArgs e)
        {
            ((CalculateDiscountModule)Module).LoadSales();
        }

        private void Fld_btnSave_Click(object sender, EventArgs e)
        {
            ((CalculateDiscountModule)Module).SaveCalculateDiscount();
        }

        private void Fld_lkeARCalculateDiscountType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                string value = ((CalculateDiscountModule)Module).ChangeCalculateDiscountType(e.Value.ToString());
                e.Value = value;
            }
        }

        private void Fld_btnApprove_Click(object sender, EventArgs e)
        {
            ((CalculateDiscountModule)Module).ApprovedCalculateDiscount();
        }

        private void fld_btnReLoadSales_Click(object sender, EventArgs e)
        {
            ((CalculateDiscountModule)Module).UpdateSales();
        }
    }
}

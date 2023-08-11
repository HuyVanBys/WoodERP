using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.SaleContract.UI
{
    /// <summary>
    /// Summary description for DMPCS100
    /// </summary>
    public partial class DMSCS100 : BOSERPScreen
    {

        public DMSCS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMPCS100_Load(object sender, EventArgs e)
        {

        }

        private void fld_txtARSaleContractDiscountPercent_Validated(object sender, EventArgs e)
        {
            ((SaleContractModule)Module).UpdateTotalAmout();
        }

        private void ftd_txtARSaleContractGuaranteePercent_Validated(object sender, EventArgs e)
        {
            ((SaleContractModule)Module).UpdateTotalAmout();
        }

        private void fld_txtARSaleContractAnswerablePercent_Validated(object sender, EventArgs e)
        {
            ((SaleContractModule)Module).UpdateTotalAmout();
        }

        private void fld_txtARSaleContractDiscountAmount_Validated(object sender, EventArgs e)
        {
            ((SaleContractModule)Module).UpdateDiscountPercent();
        }

        private void fld_txtARSaleContractGuaranteeAmount_Validated(object sender, EventArgs e)
        {
            ((SaleContractModule)Module).UpdateGuaranteeAndAnswerablePercent();
        }

        private void fld_txtARSaleContractAnswerableAmount_Validated(object sender, EventArgs e)
        {
            ((SaleContractModule)Module).UpdateGuaranteeAndAnswerablePercent();
        }

        private void fld_lkeACObjectAccessKey_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((SaleContractModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeARSaleContractParrentiD_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;
            ARSaleContractsController objSaleContractsController = new ARSaleContractsController();
            List<ARSaleContractsInfo> saleContractList = objSaleContractsController.GetAllSaleContractByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            lke.Properties.DataSource = saleContractList;
        }

        private void fld_txtARSaleContractSubTotalAmount_Validated(object sender, EventArgs e)
        {
            ((SaleContractModule)Module).UpdateTotalAmout();
        }

    }
}

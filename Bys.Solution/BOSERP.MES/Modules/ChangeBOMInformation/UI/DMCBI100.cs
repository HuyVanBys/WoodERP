using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.ChangeBOMInformation.UI
{
    /// <summary>
    /// Summary description for DMCBI100
    /// </summary>
    public partial class DMCBI100 : BOSERPScreen
    {

        public DMCBI100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ARCustomerID_EditValueChanged(object sender, EventArgs e)
        {
            //int customerID = 0;
            //if(int.TryParse(fld_lkeFK_ARCustomerID.EditValue.ToString(), out customerID))
            //{
            //    ((ChangeBOMInformationModule)Module).ChangeCustomer(customerID);
            //}
        }

        private void fld_lkeFK_ARSaleOrderID_EditValueChanged(object sender, EventArgs e)
        {
            //int saleOrderID = 0;
            //if (int.TryParse(fld_lkeFK_ARSaleOrderID.EditValue.ToString(), out saleOrderID))
            //{
            //    ((ChangeBOMInformationModule)Module).ChangeSaleOrder(saleOrderID);
            //}
        }

        private void fld_ilkFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            //int batchProductID = 0;
            //if (int.TryParse(fld_lkeFK_MMBatchProductID.EditValue.ToString(), out batchProductID))
            //{
            //    ((ChangeBOMInformationModule)Module).ChangeBatchProduct(batchProductID);
            //}
        }

        private void fld_lkeFK_ICProductID_EditValueChanged(object sender, EventArgs e)
        {
            //int productID = 0;
            //if (int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID))
            //{
            //    ((ChangeBOMInformationModule)Module).ChangeProduct(productID);
            //}
        }

        private void fld_btnViewChangeInfo_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteChangeBOMInformationFromDate.DateTime;
            DateTime toDate = fld_dteChangeBOMInformationToDate.DateTime;
            ((ChangeBOMInformationModule)Module).ShowBOMChangeLog(fromDate, toDate);
        }

        private void DMCBI100_Load(object sender, EventArgs e)
        {
            fld_dteChangeBOMInformationFromDate.DateTime = DateTime.Now;
            fld_dteChangeBOMInformationToDate.DateTime = DateTime.Now;
        }

        private void fld_lkeFK_ICProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if (e.Value != null && e.Value != lke.OldEditValue)
            //{
            //    ((ChangeBOMInformationModule)Module).ResetItemList();
            //}
        }

        private void fld_lkeFK_MMProductionNormID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if (e.Value != null && e.Value != lke.OldEditValue)
            //{
            //    ((ChangeBOMInformationModule)Module).ResetItemList();
            //}
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int batchProductID = 0;
                int.TryParse(e.Value.ToString(), out batchProductID);
                ((ChangeBOMInformationModule)Module).ResetItemList(batchProductID);
            }
        }

        private void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSComponent.BOSLookupEdit lke = sender as BOSComponent.BOSLookupEdit;
            if (lke == null)
                return;
            List<MMBatchProductsInfo> batchProductList = ((ChangeBOMInformationModule)Module).GetDatasourceForLookupToProduction();
            lke.Properties.DataSource = batchProductList;
        }

    }
}

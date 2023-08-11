using BOSCommon;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    /// <summary>
    /// Summary description for DSSO100
    /// </summary>
    public partial class guiShippingInfo : BOSERPScreen
    {
        public guiShippingInfo()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ERPModuleEntities entity = (ERPModuleEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(entity.MainObject);
            String mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            dbUtil.SetPropertyValue(entity.MainObject, String.Format("{0}InvoiceAddressLine3", mainTablePrefix), BOSUtil.GenerateFullAddress(entity.MainObject, AddressType.Invoice.ToString()));
            dbUtil.SetPropertyValue(entity.MainObject, String.Format("{0}DeliveryAddressLine3", mainTablePrefix), BOSUtil.GenerateFullAddress(entity.MainObject, AddressType.Delivery.ToString()));
            dbUtil.SetPropertyValue(entity.MainObject, String.Format("{0}StockAddressLine3", mainTablePrefix), BOSUtil.GenerateFullAddress(entity.MainObject, AddressType.Stock.ToString()));
            dbUtil.SetPropertyValue(entity.MainObject, String.Format("{0}PaymentAddressLine3", mainTablePrefix), BOSUtil.GenerateFullAddress(entity.MainObject, AddressType.Payment.ToString()));
            entity.UpdateMainObjectBindingSource();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guiShippingInfo_Load(object sender, EventArgs e)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ERPModuleEntities entity = (ERPModuleEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(entity.MainObject);
            String mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();
            fld_lkeBranchDeliveryID.Properties.DataSource = branchList;
            fld_lkeBranchInvoiceID.Properties.DataSource = branchList;
            fld_lkeBRBranchPaymentID.Properties.DataSource = branchList;
            foreach (Control ctrl in fld_grcBillAddress.Controls)
            {
                String dataMemberSuffix = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                dbUtil.SetPropertyValue(ctrl, BOSScreen.cstDataMemberPropertyName, String.Format("{0}{1}", mainTablePrefix, dataMemberSuffix));
                dbUtil.SetPropertyValue(ctrl, BOSScreen.cstDataSourcePropertyName, mainTableName);
                BindingDataControl(ctrl);
            }
            foreach (Control ctrl in fld_grcShipAddress.Controls)
            {
                String dataMemberSuffix = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                dbUtil.SetPropertyValue(ctrl, BOSScreen.cstDataMemberPropertyName, String.Format("{0}{1}", mainTablePrefix, dataMemberSuffix));
                dbUtil.SetPropertyValue(ctrl, BOSScreen.cstDataSourcePropertyName, mainTableName);
                BindingDataControl(ctrl);
            }
            foreach (Control ctrl in fld_grcPaymentAddress.Controls)
            {
                String dataMemberSuffix = dbUtil.GetPropertyStringValue(ctrl, BOSERPScreen.cstDataMemberPropertyName);
                dbUtil.SetPropertyValue(ctrl, BOSScreen.cstDataMemberPropertyName, String.Format("{0}{1}", mainTablePrefix, dataMemberSuffix));
                dbUtil.SetPropertyValue(ctrl, BOSScreen.cstDataSourcePropertyName, mainTableName);
                BindingDataControl(ctrl);
            }
            entity.UpdateMainObjectBindingSource();
        }

        private void fld_lnkCopyBillAddress_Click(object sender, EventArgs e)
        {
            fld_txtDeliveryAddressLine1.Text = fld_txtInvoiceAddressLine1.Text;
            fld_txtDeliveryAddressCity.Text = fld_txtInvoiceAddressCity.Text;
            fld_txtDeliveryAddressStateProvince.Text = fld_txtInvoiceAddressStateProvince.Text;
            fld_txtDeliveryAddressCountry.Text = fld_txtInvoiceAddressCountry.Text;
            fld_txtDeliveryAddressPostalCode.Text = fld_txtInvoiceAddressPostalCode.Text;
        }

        private void fld_lnkCopyBillAddress1_Click(object sender, EventArgs e)
        {
            fld_txtPaymentAddressLine1.Text = fld_txtInvoiceAddressLine1.Text;
            fld_txtPaymentAddressCity.Text = fld_txtInvoiceAddressCity.Text;
            fld_txtPaymentAddressStateProvince.Text = fld_txtInvoiceAddressStateProvince.Text;
            fld_txtPaymentAddressCountry.Text = fld_txtInvoiceAddressCountry.Text;
            fld_txtPaymentAddressPostalCode.Text = fld_txtInvoiceAddressPostalCode.Text;
        }

        private void fld_lkeBranchInvoiceID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int branchID = 0;
                if (int.TryParse(e.Value.ToString(), out branchID))
                {
                    BRBranchsController objBranchsController = new BRBranchsController();
                    BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
                    if (objBranchsInfo != null)
                    {
                        fld_txtInvoiceAddressLine1.Text = objBranchsInfo.BRBranchContactAddressLine1;
                    }
                }
            }
        }

        private void fld_lkeBranchDeliveryID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int branchID = 0;
                if (int.TryParse(e.Value.ToString(), out branchID))
                {
                    BRBranchsController objBranchsController = new BRBranchsController();
                    BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
                    if (objBranchsInfo != null)
                    {
                        fld_txtDeliveryAddressLine1.Text = objBranchsInfo.BRBranchContactAddressLine1;
                    }
                }
            }
        }

        private void fld_lkeBRBranchPaymentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int branchID = 0;
                if (int.TryParse(e.Value.ToString(), out branchID))
                {
                    BRBranchsController objBranchsController = new BRBranchsController();
                    BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
                    if (objBranchsInfo != null)
                    {
                        fld_txtPaymentAddressLine1.Text = objBranchsInfo.BRBranchContactAddressLine1;
                    }
                }
            }
        }
    }
}

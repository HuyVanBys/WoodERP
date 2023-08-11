using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder.UI
{
    /// <summary>
    /// Summary description for DMSO100
    /// </summary>
    public partial class DMSO100 : BOSERPScreen
    {
        public DMSO100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ARCustomerID1_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).SetDefaultValuesFromCustomer();
        }

        private void fld_txtARSaleOrderDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).ChangeDiscountAmount();
            ((SaleOrderModule)Module).UpdatePaymentTime();
        }

        private void fld_txtARSaleOrderDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).ChangeDiscountPercent();
            ((SaleOrderModule)Module).UpdatePaymentTime();

        }

        private void fld_bedARSaleOrderPaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).ShowPaymentInfo();
        }

        private void fld_btnEditShippingInfo_Click(object sender, EventArgs e)
        {
            ((Modules.SaleOrder.SaleOrderModule)this.Module).ShowShippingInfo();
        }
        //Click ARCustomerID1
        //private void fld_lkeFK_ARCustomerID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        //{
        //    BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
        //    if (e.Value != lke.OldEditValue)
        //    {
        //        ((Modules.SaleOrder.SaleOrderModule)this.Module).ChangeCustomer(Convert.ToInt32(e.Value));
        //    }
        //}

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke != null && lke.OldEditValue != e.Value)
                ((Modules.SaleOrder.SaleOrderModule)this.Module).ChangePriceLevel(Convert.ToInt32(e.Value));
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (fld_lkeFK_ICProductAttributeID.EditValue != null)
                    Int32.TryParse(fld_lkeFK_ICProductAttributeID.EditValue.ToString(), out productID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo != null)
                {
                    if (objProductsInfo.ICProductLockedPurchaseOrder)
                    {
                        MessageBox.Show(SaleOrderLocalizedResources.ProductLockedErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (objProductsInfo.ICProductNonRetail)
                    {
                        MessageBox.Show(SaleOrderLocalizedResources.ProductNonRetailMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!objProductsInfo.ICProductActiveCheck)
                    {
                        MessageBox.Show(SaleOrderLocalizedResources.ProductNonActiveCheck, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                ((SaleOrderModule)Module).AddItemToSaleOrderItemsList(productID);
                }
                fld_lkeFK_ICProductAttributeID.EditValue = 0;
            }
        }

        private void fld_txtARSaleOrderTaxPercent_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeTaxPercent();
            ((SaleOrderModule)Module).UpdatePaymentTime();
        }

        private void fld_txtARSaleOrderTaxAmount_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeTaxAmount();
            ((SaleOrderModule)Module).UpdatePaymentTime();
        }

        private void fld_txtARSaleOrderDepositBalance_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeDeposit();
        }

        private void fld_txtARSaleOrderShippingFee_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeShippingFee();
            ((SaleOrderModule)Module).UpdatePaymentTime();
        }

        private void fld_lnkViewDiffPrice_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ViewDiffPrice();
        }

        private void fld_txtARSaleOrderCustomerCommissionPercent_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeCommissionPercent();
        }

        private void fld_txtARSaleOrderSOCommissionAmount_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeCommissionAmount();
        }

        private void fld_lkeFK_ARAssociatedSellerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderModule)Module).ChangeAssociatedSeller(Convert.ToInt32(e.Value));
            }
        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).GetCustomerContactInfo("Invoice");
        }

        private void fld_btnEditShippingInfo_Click_1(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).GetCustomerContactInfo("Delivery");
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ShownInventoryStocks();
        }

        private void fld_txtARSaleOrderExchangeRate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemFromSaleOrderExchangeRate();
        }

        private void fld_txtARSaleOrderExchangeRate2_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemFromSaleOrderExchangeRate();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderModule)Module).UpdateTotalAmountByCurrency(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderModule)Module).UpdateTotalAmountByCurrency2(Convert.ToInt32(e.Value));
            }
        }

        private void fld_dteARSaleOrderDate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangePaymentTimeDate();
        }

        private void fld_dteARSaleOrderDeliveryDate_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangePaymentTimeDate();
        }

        private void fld_lkeFK_GEPaymentTermID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                int paymentTimeID = Convert.ToInt32(e.Value);

                GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(paymentTimeID);
                if (objPaymentTermsInfo == null || (objPaymentTermsInfo != null && !objPaymentTermsInfo.GEPaymentTermActiveCheck))
                {
                    MessageBox.Show(SaleOrderLocalizedResources.PaymentTermNoActive, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.AcceptValue = false;
                    return;
                }
                ((SaleOrderModule)Module).GeneratePaymentTime(paymentTimeID);
            }
        }

        private void fld_btnShowProductCollection_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddCollectionToSaleOrder();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value == null)
            {
                ((SaleOrderModule)Module).ChangeObject(string.Empty);
            }
            else if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_btnAddCustomers_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddNewCustomer();
        }

        private void fld_btnAddProductWorkItem_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddWorkItemToSaleOrderItemCostList();
        }

        private void fld_btnAddProductMaterialItem_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddMaterialItemToSaleOrderItemCostList();
        }

        private void fld_chkARSaleOrderIsAcceptance_CheckedChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemBelongDeliveryMethod();
        }

        private void fld_lkeARSaleOrderDocumentType_EditValueChanged(object sender, EventArgs e)
        {
            if (((SaleOrderModule)Module).GetSaleOrderDocumentType()
                == SaleOrderDocumentType.Contract.ToString())
            {
                fld_btnShowInventoryStock.Visible = false;
            }
            else
            {
                fld_btnShowInventoryStock.Visible = true;
            }
        }

        private void fld_btnAddWork_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddItemWork();
        }

        private void fld_btnUpdateAcceptanceItem_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeIsAcceptanceAllItems();
        }

        private void fld_lkeARPaymentMethodCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((SaleOrderModule)Module).UpdatePaymentMethod(e.Value.ToString());
            }
        }

        private void fld_btnAddProductAssetItem_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddSaleOrderItemAsset();
        }

        private void fld_btnAddCost_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddItemCost();
        }

        private void fld_dteARSaleOrderDeliveryDate_EditValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
        }

        private void fld_txtARSaleOrderDiscountPerCentAllItem_Validated(object sender, EventArgs e)
        {
          //  ((SaleOrderModule)Module).UpdateSaleOrderDiscountPerCentAllItem();
        }

        private void fld_chkARSaleOrderPreDeliverySurveyTrue_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ckeDeliverySurvey = sender as CheckEdit;
            if (ckeDeliverySurvey.EditValue != null)
            {
                bool isChecked = false;
                Boolean.TryParse(ckeDeliverySurvey.EditValue.ToString(), out isChecked);
                fld_chkARSaleOrderPreDeliverySurveyFalse.EditValue = !isChecked;
                ((SaleOrderModule)Module).ChangePreDeliverySurvey(PreDeliverySurvey.PreDeliverySurveyTrue.ToString(), isChecked);
            }
        }

        private void fld_chkARSaleOrderPreDeliverySurveyFalse_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ckeDeliverySurvey = sender as CheckEdit;
            if (ckeDeliverySurvey.EditValue != null)
            {
                bool isChecked = false;
                Boolean.TryParse(ckeDeliverySurvey.EditValue.ToString(), out isChecked);
                fld_chkARSaleOrderPreDeliverySurveyTrue.EditValue = !isChecked;
                ((SaleOrderModule)Module).ChangePreDeliverySurvey(PreDeliverySurvey.PreDeliverySurveyFalse.ToString(), isChecked);
            }
        }

        private void fld_lkeARSalesOrderDeliveryFloorType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((SaleOrderModule)Module).ChangeSalesOrderDeliveryFloorType(e.Value.ToString());
            }
        }

        private void fld_dteARSalesOrderDeliveryTime_EditValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
        }

        private void fld_lkeFK_ICProductAttributeID_QueryPopUp(object sender, CancelEventArgs e)
        {
            //BOSLookupEdit lke = sender as BOSLookupEdit;
            //if (lke == null)
            //    return;
            //lke.Properties.DataSource = ((SaleOrderModule)Module).LoadProductList();
        }

        private void fld_dteARSaleOrderDeliveryActualDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderModule)Module).ChangeActualDeliveryDate(Convert.ToString(e.Value));
            }
        }

        private void fld_lnkChooseProspectCustomer_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((SaleOrderModule)Module).ChooseProspectCustomer();
        }

        private void fld_btnAddCommission_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).AddCommissions();
        }

        private void fld_lkeFK_ARDeliveryMethodID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SaleOrderModule)Module).ChangeDeliveryMethod(Convert.ToInt32(e.Value.ToString()));
            }
        }

        private void fld_ckeARSaleOrderIsDeliveryPlan_CheckedChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemBelongDeliveryMethod();
        }

        private void fld_ckeARSaleOrderIsSaleOrderShipment_CheckedChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemBelongDeliveryMethod();
        }

        private void fld_ckeARSaleOrderIsAcceptance_CheckedChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemBelongDeliveryMethod();
        }

        private void fld_ckeARSaleOrderIsInvoiceAndShipment_CheckedChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemBelongDeliveryMethod();
        }

        private void fld_ckeARSaleOrderIsVehicleAllocation_CheckedChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemBelongDeliveryMethod();
        }

        private void fld_lkeFK_PMProjectID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((SaleOrderModule)Module).GetProjectByObjectID();
        }

        private void fld_lkeFK_ARSaleContractID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((SaleOrderModule)Module).GetSaleContractByObjectIDAnProjectID();
        }

        private void Fld_bedARSalesman_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((SaleOrderModule)Module).ShowSalesman();
        }

        private void fld_bedFK_ARDiscountProgramID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((SaleOrderModule)Module).ApplyDiscountProgram();
        }

        private void fld_ckeARSaleOrderIsContainerLoader_CheckedChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemBelongDeliveryMethod();
        }

        private void fld_lkeSaleOrderProductType_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            lke.Properties.Columns.Clear();
            lke.Properties.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));
            lke.BOSDataSource = "";
            lke.BOSDataMember = "";
            lke.Properties.DisplayMember = "ADConfigText";
            lke.Properties.ValueMember = "ADConfigKeyValue";
            lke.Properties.DataSource = ((SaleOrderModule)Module).GetSaleOrderTypeForLookUpEdit();
        }

        private void fld_lkeFK_ICProductAttributeTTMTID_CloseUp(object sender, CloseUpEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            if (lke.OldEditValue != e.Value)
            {
                ((SaleOrderModule)Module).UpdateTTMTItem(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_lkeACCustomerObjectID_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            if (lke.OldEditValue != lke.EditValue)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(Convert.ToString(lke.EditValue));
                objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                if (objObjectsInfo != null)
                {
                    if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                    {
                        ARCommissionsController objCommissionsController = new ARCommissionsController();
                        List<ARCommissionsInfo> lstCommissions = objCommissionsController.GetListFromDataSet(objCommissionsController.GetDataByCustomerID(objObjectsInfo.ACObjectID)) as List<ARCommissionsInfo>;
                        if (lstCommissions != null && lstCommissions.FirstOrDefault() != null)
                            fld_txtARCommissionRate.EditValue = lstCommissions.FirstOrDefault().ARCommissionPercent;
                    }
                }
            }
        }

        private void Fld_txtARSaleOrderExchangeRate_Validated_1(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).UpdateTotalAmountByCurrency();
        }

        private void Fld_lkeARSaleOrderSaleType_Closed(object sender, ClosedEventArgs e)
        {
            //((SaleOrderModule)Module).UpdatePriceForSaleType();
            ((SaleOrderModule)Module).ChangeSaleType();
        }

        private void Fld_lkeSaleOrderProductType_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ((SaleOrderModule)Module).ChangeInputType(e.Value.ToString());
            }
        }

        private void fld_txtARSaleOrderExchangeRate21_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).UpdateTotalAmountByCurrency();
        }

        private void bosTextBox3_Validated(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ChangeItemPONo();
        }

        private void fld_btnUpdateInventoryStock_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).GetInventoryQty();
        }

        private void fld_lkeARSaleOrderItemGrantedFrom_CloseUp(object sender, CloseUpEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            if (lke.OldEditValue != e.Value)
            {
                ((SaleOrderModule)Module).UpdateGrantedFromItem(Convert.ToString(e.Value));
            }
        }

        private void fld_btnExportTemplate_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).ExportPriceSheetTemplate();
        }

        private void fld_btnImportTemplate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fld_lkeACObjectAccessKey.EditValue.ToString()))
            {
                if (BOSApp.ShowMessageYesNo("Bạn chưa chọn khách hàng, hệ thống sẽ KHÔNG tự động lấy giá theo bảng giá, bạn có muốn tiếp tục không?") == DialogResult.No) return;
            }
            ((SaleOrderModule)Module).ImportProductToItem();
        }

        private void fld_txtARSaleOrderTaxPercent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SaleOrderModule)Module).ChangeTaxPercent();
                ((SaleOrderModule)Module).UpdatePaymentTime();
            }
        }

        private void fld_btnItemDesc_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_Line3);
        }

        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom();
            host.MaximizeBox = false;
            host.MinimizeBox = false;
            // Save properties of control
            var loc = ctl.Location;
            var dock = ctl.Dock;
            var parent = ctl.Parent;
            var form = parent;
            
            var anchor = ctl.Anchor;
            
            var size = ctl.Size;
            while (!(form is Form)) form = form.Parent;
            // Move control to host
            //ctl.Parent = host;
            host.AddCtrl(ctl);
            ctl.Location = Point.Empty;
            ctl.Dock = DockStyle.Fill;
            //ctl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //ctl.Size = host.panelMain.Size;
            // Setup event handler to restore control back to form
            host.FormClosing += delegate
            {
                ctl.Parent = parent;
                ctl.Dock = dock;
                ctl.Location = loc;
                ctl.Anchor = anchor;
                ctl.Size = size;
                form.Refresh();
            };


            // Exit full screen with escape key
            host.KeyPreview = true;
            host.KeyDown += (KeyEventHandler)((s, e) =>
            {
                if (e.KeyCode == Keys.Escape) host.Close();
            });
            // And go full screen
            host.ShowDialog();
            //  form.Hide();
        }

        private void bosLabel6_Click(object sender, EventArgs e)
        {

        }

        private void fld_lkeACCustomerObjectID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_txtARSaleOrderDiscountPerCentAllItem_EditValueChanged(object sender, EventArgs e)
        {
            ((SaleOrderModule)Module).UpdateSaleOrderDiscountPerCentAllItem();
        }
    }
}

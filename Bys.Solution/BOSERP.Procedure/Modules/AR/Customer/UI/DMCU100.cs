using BOSCommon;
using BOSComponent;
using System;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU100
    /// </summary>
    public partial class DMCU100 : BOSERPScreen
    {
        private int stateProvinceSelected;
        private int districtSelected;
        private int wardSelected;
        private int streetSelected;

        public DMCU100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();

            #region Add collapsiblegroupbox
            this.collapsibleGroupBox1.Controls.Add(this.fld_txtARCustomerName3);
            this.collapsibleGroupBox1.Controls.Add(this.bosLabel14);
            this.collapsibleGroupBox1.Controls.Add(this.fld_txtARCustomerName21);
            this.collapsibleGroupBox1.Controls.Add(this.bosLabel13);
            this.collapsibleGroupBox1.Controls.Add(this.fld_txtARCustomerName1);
            this.collapsibleGroupBox1.Controls.Add(this.bosLabel12);
            this.collapsibleGroupBox1.Dock = System.Windows.Forms.DockStyle.None;
            this.collapsibleGroupBox1.Location = new System.Drawing.Point(3, 110);
            this.collapsibleGroupBox1.Size = new System.Drawing.Size(478, 91);
            this.collapsibleGroupBox1.TabIndex = 1;
            this.collapsibleGroupBox1.TabStop = false;
            this.collapsibleGroupBox1.Text = "Tên khác";
            #endregion
        }

        private void fld_bedARCustomerPaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CustomerModule)Module).ShowPaymentTerm();
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CustomerModule)Module).ChooseLocation();
        }

        private void fld_lnkCopyInvoiceAddress_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)((BaseModuleERP)Module).CurrentModuleEntity.MainObject;
            objCustomersInfo.ARCustomerInvoiceAddressLine1 = objCustomersInfo.ARCustomerContactAddressLine1;
            objCustomersInfo.ARCustomerInvoiceAddressCity = objCustomersInfo.ARCustomerContactAddressCity;
            objCustomersInfo.ARCustomerInvoiceAddressStateProvince = objCustomersInfo.ARCustomerContactAddressStateProvince;
            objCustomersInfo.ARCustomerInvoiceAddressCountry = objCustomersInfo.ARCustomerContactAddressCountry;
            objCustomersInfo.ARCustomerInvoiceAddressPostalCode = objCustomersInfo.ARCustomerContactAddressPostalCode;
            objCustomersInfo.FK_GELocationID1 = objCustomersInfo.FK_GELocationID;
            objCustomersInfo.GELocationName1 = objCustomersInfo.GELocationName;
            objCustomersInfo.ARCustomerInvoiceContactName = objCustomersInfo.ARCustomerContactName;
            objCustomersInfo.ARCustomerInvoiceAddressTel = objCustomersInfo.ARCustomerContactPhone;
            objCustomersInfo.ARCustomerInvoiceAddressFax = objCustomersInfo.ARCustomerContactFax;
            ((BaseModuleERP)Module).CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        private void fld_bedGELocationName1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CustomerModule)Module).ChooseLocationInvoice();
        }

        private void fld_bedGELocationName2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CustomerModule)Module).ChooseLocationDelivery();
        }

        private void fld_bedGELocationName3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CustomerModule)Module).ChooseLocationPayment();
        }

        private void fld_lnkCopyDeliveryAddress_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            //((CustomerModule)Module).UpdateLocationDelivery();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)((BaseModuleERP)Module).CurrentModuleEntity.MainObject;
            objCustomersInfo.ARCustomerDeliveryAddressLine1 = objCustomersInfo.ARCustomerContactAddressLine1;
            objCustomersInfo.ARCustomerDeliveryAddressCity = objCustomersInfo.ARCustomerContactAddressCity;
            objCustomersInfo.ARCustomerDeliveryAddressStateProvince = objCustomersInfo.ARCustomerContactAddressStateProvince;
            objCustomersInfo.ARCustomerDeliveryAddressCountry = objCustomersInfo.ARCustomerContactAddressCountry;
            objCustomersInfo.ARCustomerDeliveryAddressPostalCode = objCustomersInfo.ARCustomerContactAddressPostalCode;
            objCustomersInfo.ARCustomerDeliveryAddressEmail = objCustomersInfo.ARCustomerContactEmail1;
            objCustomersInfo.ARCustomerDeliveryContactName = objCustomersInfo.ARCustomerContactName;
            objCustomersInfo.GELocationName2 = objCustomersInfo.GELocationName;
            objCustomersInfo.FK_GELocationID2 = objCustomersInfo.FK_GELocationID;
            objCustomersInfo.ARCustomerDeliveryAddressFax = objCustomersInfo.ARCustomerContactFax;
            objCustomersInfo.ARCustomerDeliveryAddressTel = objCustomersInfo.ARCustomerContactPhone;
            ((BaseModuleERP)Module).CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        private void fld_lnkCopyPaymentAddress_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)((BaseModuleERP)Module).CurrentModuleEntity.MainObject;
            objCustomersInfo.ARCustomerPaymentAddressLine1 = objCustomersInfo.ARCustomerContactAddressLine1;
            objCustomersInfo.ARCustomerPaymentAddressCity = objCustomersInfo.ARCustomerContactAddressCity;
            objCustomersInfo.ARCustomerPaymentAddressStateProvince = objCustomersInfo.ARCustomerContactAddressStateProvince;
            objCustomersInfo.ARCustomerPaymentAddressCountry = objCustomersInfo.ARCustomerContactAddressCountry;
            objCustomersInfo.ARCustomerPaymentAddressPostalCode = objCustomersInfo.ARCustomerContactAddressPostalCode;
            objCustomersInfo.ARCustomerPaymentAddressEmail = objCustomersInfo.ARCustomerContactEmail1;
            objCustomersInfo.FK_GELocationID3 = objCustomersInfo.FK_GELocationID;
            objCustomersInfo.GELocationName3 = objCustomersInfo.GELocationName;
            objCustomersInfo.ARCustomerPaymentContactName = objCustomersInfo.ARCustomerContactName;
            objCustomersInfo.ARCustomerPaymentAddressTel = objCustomersInfo.ARCustomerContactPhone;
            objCustomersInfo.ARCustomerPaymentAddressFax = objCustomersInfo.ARCustomerContactFax;
            ((BaseModuleERP)Module).CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        private void fld_lkeARCustomerTypeCombo_EditValueChanged(object sender, EventArgs e)
        {
            string customerType = fld_lkeARCustomerTypeCombo.EditValue.ToString();
            if (customerType.Equals(CustomerType.Personal.ToString()))
            {
                this.fld_txtARCustomerCMND.Enabled = true;
            }
            else
            {
                this.fld_txtARCustomerCMND.Text = "";
                this.fld_txtARCustomerCMND.Enabled = false;
            }
        }

        private void fld_txtARCustomerPaymentAddressWard_Validated(object sender, EventArgs e)
        {
            ((CustomerModule)Module).GenarateDeliveryAddress();
        }

        private void fld_txtARCustomerDeliveryAddressStreet_Validated(object sender, EventArgs e)
        {

        }

        private void fld_txtARCustomerName2_Validated(object sender, EventArgs e)
        {
            BOSComponent.BOSTextBox txe = (BOSComponent.BOSTextBox)sender;
            if (txe.EditValue != txe.OldEditValue)
            {
                ((CustomerModule)Module).ChangeCustomerContactName(txe.EditValue.ToString());
            }
        }

        private void fld_lkeFK_GEDeliveryStateProvinceID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEDeliveryStateProvinceID.EditValue != null)
                ((CustomerModule)Module).PreStateProvinceSelected = int.Parse(fld_lkeFK_GEDeliveryStateProvinceID.EditValue.ToString());
        }

        private void fld_lkeFK_GEDeliveryDistrictID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEDeliveryDistrictID.EditValue != null)
                ((CustomerModule)Module).PreDisctrictSelected = int.Parse(fld_lkeFK_GEDeliveryDistrictID.EditValue.ToString());
        }

        private void fld_lkeFK_GEDeliveryWardID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEDeliveryWardID.EditValue != null)
                ((CustomerModule)Module).PreWardSelected = int.Parse(fld_lkeFK_GEDeliveryWardID.EditValue.ToString());
        }

        private void fld_lkeFK_GEDeliveryStreetID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEDeliveryStreetID.EditValue != null)
                ((CustomerModule)Module).PreStreetSelected = int.Parse(fld_lkeFK_GEDeliveryStreetID.EditValue.ToString());
        }

        private void fld_lkeFK_GEDeliveryStateProvinceID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (e.Value.ToString() == "-1")
                {
                    int result = ((CustomerModule)Module).CreateNewSateProvinceList();
                    if (result >= 0)
                    {
                        lke.EditValue = result;
                        fld_lkeFK_GEDeliveryStateProvinceID.Properties.DataSource = ((CustomerModule)Module).ProvinceList;
                    }
                    else
                        fld_lkeFK_GEDeliveryStateProvinceID.EditValue = ((CustomerModule)Module).PreStateProvinceSelected;
                    ((BaseModuleERP)Module).CurrentModuleEntity.UpdateMainObjectBindingSource();
                    return;
                }
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((CustomerModule)Module).GenarateDistrictByStateProvinceID(objectID);
            }
        }

        private void fld_lkeFK_GEDeliveryDistrictID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (e.Value.ToString() == "-1")
                {
                    int result = ((CustomerModule)Module).CreateNewDistrictList();
                    if (result >= 0)
                    {
                        lke.EditValue = result;
                        fld_lkeFK_GEDeliveryDistrictID.Properties.DataSource = ((CustomerModule)Module).DistrictList;
                    }
                    else
                        fld_lkeFK_GEDeliveryDistrictID.EditValue = ((CustomerModule)Module).PreDisctrictSelected;
                    ((BaseModuleERP)Module).CurrentModuleEntity.UpdateMainObjectBindingSource();
                    return;
                }
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((CustomerModule)Module).GenarateWardByDistrictID(objectID);
            }
        }

        private void fld_lkeFK_GEDeliveryWardID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (e.Value.ToString() == "-1")
                {
                    int result = ((CustomerModule)Module).CreateNewWardList();
                    fld_lkeFK_GEDeliveryWardID.Properties.DataSource = ((CustomerModule)Module).WardList;
                    if (result >= 0)
                    {
                        lke.EditValue = result;
                    }
                    else
                        fld_lkeFK_GEDeliveryWardID.EditValue = ((CustomerModule)Module).PreWardSelected;
                    ((BaseModuleERP)Module).CurrentModuleEntity.UpdateMainObjectBindingSource();
                    return;
                }
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((CustomerModule)Module).ChangeDeliveryWard(objectID);
            }
        }

        private void fld_lkeFK_GEDeliveryStreetID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (e.Value.ToString() == "-1")
                {
                    int result = ((CustomerModule)Module).CreateNewStreetList();
                    fld_lkeFK_GEDeliveryStreetID.Properties.DataSource = ((CustomerModule)Module).StreetList;
                    if (result >= 0)
                        lke.EditValue = result;
                    else
                        fld_lkeFK_GEDeliveryStreetID.EditValue = ((CustomerModule)Module).PreStreetSelected;
                }
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((CustomerModule)Module).ChangeDeliveryStreet(objectID);
            }
        }

        private void fld_lkeFK_GEDeliveryCountryID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                if (e.Value.ToString() == "-1")
                {
                    int result = ((CustomerModule)Module).CreateNewCountryList();
                    fld_lkeFK_GEDeliveryCountryID.Properties.DataSource = ((CustomerModule)Module).CountryList;
                    if (result >= 0)
                        lke.EditValue = result;
                    else
                        fld_lkeFK_GEDeliveryCountryID.EditValue = ((CustomerModule)Module).PreCountrySelected;
                }    
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((CustomerModule)Module).ChangeDeliveryCountry(objectID);
            }
        }

        private void fld_lkeFK_ARCustomerTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((CustomerModule)Module).ChangeCustomerTypeAccountConfig(objectID);
            }
        }

        private void Fld_lkeFK_GEDeliveryStateProvinceID_BeforePopup(object sender, EventArgs e)
        {
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)((BaseModuleERP)Module).CurrentModuleEntity.MainObject;
            ((CustomerModule)Module).InvalidateStateProvinceByCountryID(objCustomersInfo.FK_GEDeliveryCountryID);
        }

        private void Fld_lkeFK_GEDeliveryDistrictID_BeforePopup(object sender, EventArgs e)
        {
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)((BaseModuleERP)Module).CurrentModuleEntity.MainObject;
            ((CustomerModule)Module).InvalidateDeliveryDistricts(objCustomersInfo.FK_GEDeliveryStateProvinceID);
        }

        private void Fld_lkeFK_GEDeliveryWardID_BeforePopup(object sender, EventArgs e)
        {
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)((BaseModuleERP)Module).CurrentModuleEntity.MainObject;
            ((CustomerModule)Module).InvalidateDeliveryWard(objCustomersInfo.FK_GEDeliveryDistrictID);
        }

        private void Fld_txtARCustomerDeliveryHomeNumber_Validated(object sender, EventArgs e)
        {
            ((CustomerModule)Module).GenarateDeliveryAddress();
        }

        private void fld_txtARCustomerDeliveryHomeNumber_TextChanged(object sender, EventArgs e)
        {
            if (fld_txtARCustomerDeliveryHomeNumber.OldEditValue != null && !((CustomerModule)Module).isSaving && fld_txtARCustomerDeliveryHomeNumber.EditValue.ToString() != fld_txtARCustomerDeliveryHomeNumber.OldEditValue.ToString())
            {
                ((CustomerModule)Module).GenarateDeliveryAddress(fld_txtARCustomerDeliveryHomeNumber.EditValue.ToString());
            }
        }
    }
}

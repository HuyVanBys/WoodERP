using BOSComponent;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Supplier.UI
{
    /// <summary>
    /// Summary description for DMSP100
    /// </summary>
    public partial class DMSP100 : BOSERPScreen
    {
        private int stateProvinceSelected;

        public DMSP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            this.fld_clgName.Controls.Add(this.fld_txtAPSupplierName1);
            this.fld_clgName.Controls.Add(this.bosLabel3);
            this.fld_clgName.Controls.Add(this.bosLabel1);
            this.fld_clgName.Controls.Add(this.fld_txtAPSupplierName21);
            this.fld_clgName.Controls.Add(this.fld_txtAPSupplierName3);
            this.fld_clgName.Controls.Add(this.bosLabel2);
            this.fld_clgName.Dock = System.Windows.Forms.DockStyle.None;
            this.fld_clgName.Location = new System.Drawing.Point(0, 53);
            this.fld_clgName.Name = "fld_clgName";
            this.fld_clgName.Size = new System.Drawing.Size(507, 89);
            this.fld_clgName.TabIndex = 0;
            this.fld_clgName.TabStop = false;
            this.fld_clgName.Text = "Tên khác";
        }

        private void fld_bedAPSupplierPaymentTerm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((SupplierModule)Module).ShowPaymentTerm();
        }
        private void fld_lkeFK_GECountryID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GECountryID.EditValue != null && fld_lkeFK_GECountryID.EditValue.ToString() == "-1")
            {
                int result = ((SupplierModule)Module).CreateNewCountryList();
                if (result >= 0)
                {
                    fld_lkeFK_GECountryID.EditValue = result;
                    fld_lkeFK_GECountryID.Properties.DataSource = ((SupplierModule)Module).CountryList;
                }
                else
                    fld_lkeFK_GECountryID.EditValue = ((SupplierModule)Module).PreCountrySelected;

            }
            BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
            if (fld_lkeFK_GECountryID.EditValue != lke.OldEditValue)
            {
                stateProvinceSelected = int.Parse(fld_lkeFK_GECountryID.EditValue.ToString());
                List<GEStateProvincesInfo> provincesList = ((SupplierModule)Module).GetProvinceListByCountry(int.Parse(fld_lkeFK_GECountryID.EditValue.ToString()));
                if (provincesList != null)
                {
                    fld_lkeFK_GEStateProvinceID.Properties.DataSource = provincesList;
                }
            }
            else
            {
                if (!Module.Toolbar.IsNullOrNoneAction() && stateProvinceSelected > 0)
                {
                    fld_lkeFK_GECountryID.EditValue = stateProvinceSelected;
                }
            }
        }

        private void fld_lkeFK_GECountryID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GECountryID.EditValue != null)
                ((SupplierModule)Module).PreCountrySelected = int.Parse(fld_lkeFK_GECountryID.EditValue.ToString());
        }
        private void fld_lkeFK_GEStateProvinceID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEStateProvinceID.EditValue != null)
                ((SupplierModule)Module).PreStateProvinceSelected = int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString());
        }
        private void fld_lkeFK_GEStateProvinceID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEStateProvinceID.EditValue != null && fld_lkeFK_GEStateProvinceID.EditValue.ToString() == "-1")
            {
                int result = ((SupplierModule)Module).CreateNewSateProvinceList();
                if (result >= 0)
                {
                    fld_lkeFK_GEStateProvinceID.EditValue = result;
                    fld_lkeFK_GEStateProvinceID.Properties.DataSource = ((SupplierModule)Module).ProvinceList;
                }
                else
                    fld_lkeFK_GEStateProvinceID.EditValue = ((SupplierModule)Module).PreStateProvinceSelected;
            }
            List<GEDistrictsInfo> districtsList = ((SupplierModule)Module).GetDistrictListByStateProvinceID(int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString()));
            if (districtsList != null)
            {
                fld_lkeFK_GEDistrictID.Properties.DataSource = districtsList;
            }
        }
        private void fld_lkeFK_GEDistrictID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEDistrictID.EditValue != null && fld_lkeFK_GEDistrictID.EditValue.ToString() == "-1")
            {
                int result = ((SupplierModule)Module).CreateNewDistrictList();
                fld_lkeFK_GEDistrictID.Properties.DataSource = ((SupplierModule)Module).GetDistrictListByStateProvinceID(int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString()));
                if (result >= 0)
                    fld_lkeFK_GEDistrictID.EditValue = result;
                else
                    fld_lkeFK_GEDistrictID.EditValue = ((SupplierModule)Module).PreDisctrictSelected;
            }
        }
        private void fld_lkeFK_GEDistrictID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEDistrictID.EditValue != null)
                ((SupplierModule)Module).PreDisctrictSelected = int.Parse(fld_lkeFK_GEDistrictID.EditValue.ToString());
        }

        private void fld_lkeFK_APSupplierTypeAccountConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            int objectID = 0;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                Int32.TryParse(e.Value.ToString(), out objectID);
                ((SupplierModule)Module).ChangeSupplierTypeAccountConfig(objectID);
            }
        }
    }
}

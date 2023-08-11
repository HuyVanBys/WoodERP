using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Customer
{

    public partial class guiAddWard : BOSERPScreen//Form
    {
        private int CountryPrevSelectedIndex = 0;
        private int StateProvincePrevSelectedIndex = 0;
        private int DistrictPrevSelectedIndex = 0;
        public guiAddWard()
        {
            InitializeComponent();
        }

        public guiAddWard(String lblname, String lblcode, String txtname, String txtcode)
        {
            InitializeComponent();
            fld_txtName.Text = lblcode;
            fld_txtCode.Text = lblname;
            fld_lblCode.Text = txtcode;
            fld_lblName.Text = txtname;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fld_txtCode.Text))
            {
                MessageBox.Show(SupplierLocalizedResources.DisctrictNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void guiAttributeInput_Load(object sender, EventArgs e)
        {
            GetDistrict();
            GetCountry();
            GetCity();
            fld_txtCode.Focus();
        }
        private void GetCountry()
        {
            fld_cmbCountry.Properties.Items.Clear();
            GECountrysController objGECountrysController = new GECountrysController();
            DataSet ds = objGECountrysController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GECountrysInfo objGECountrysInfo = (GECountrysInfo)objGECountrysController.GetObjectFromDataRow(row);
                    fld_cmbCountry.Properties.Items.Add(objGECountrysInfo.GECountryName);
                }
            }
            CountryPrevSelectedIndex = 0;

        }
        private void GetCity()
        {
            fld_cmbStateProvince.Properties.Items.Clear();
            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            GECountrysController objGECountrysController = new GECountrysController();
            DataSet ds;
            if (fld_cmbCountry.SelectedIndex >= 0)
            {
                int newGECountrysInfoID;
                newGECountrysInfoID = objGECountrysController.GetObjectIDByName(fld_cmbCountry.Text);
                ds = objGEStateProvincesController.GetAllDataByForeignColumn("FK_GECountryID", newGECountrysInfoID);
                //ds = objGEStateProvincesController.GetAllDataByForeignColumn
            }
            else
            {
                ds = objGEStateProvincesController.GetAllObjects();
            }
            if (ds.Tables.Count > 0)
            {

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GEStateProvincesInfo objGEStateProvincesInfo = (GEStateProvincesInfo)objGEStateProvincesController.GetObjectFromDataRow(row);
                    fld_cmbStateProvince.Properties.Items.Add(objGEStateProvincesInfo.GEStateProvinceName);
                }
            }
            StateProvincePrevSelectedIndex = 0;
        }

        private void GetDistrict()
        {
            fld_cmbDistrict.Properties.Items.Clear();
            GEDistrictsController objGEDistrictsController = new GEDistrictsController();
            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            DataSet ds;
            if (fld_cmbStateProvince.SelectedIndex >= 0)
            {
                int newGEStateProvinceInfoID;
                newGEStateProvinceInfoID = objGEStateProvincesController.GetObjectIDByName(fld_cmbStateProvince.Text);
                ds = objGEDistrictsController.GetAllDataByForeignColumn("FK_GEStateProvinceID", newGEStateProvinceInfoID);
            }
            else
            {
                ds = objGEDistrictsController.GetAllObjects();
            }
            if (ds.Tables.Count > 0)
            {

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GEDistrictsInfo objGEDistrictsInfo = (GEDistrictsInfo)objGEDistrictsController.GetObjectFromDataRow(row);
                    fld_cmbDistrict.Properties.Items.Add(objGEDistrictsInfo.GEDistrictName);
                }
            }
            DistrictPrevSelectedIndex = 0;

        }

        private void fld_cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCity();
        }

        private void fld_cmbStateProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDistrict();
        }
    }
}
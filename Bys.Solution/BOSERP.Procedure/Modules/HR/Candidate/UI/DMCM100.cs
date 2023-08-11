using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Candidate.UI
{
    /// <summary>
    /// Summary description for DMCM100
    /// </summary>
    public partial class DMCM100 : BOSERPScreen
    {

        public DMCM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_GEDistrictID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEDistrictID.EditValue != null && fld_lkeFK_GEDistrictID.EditValue.ToString() == "-1")
            {
                int result = ((CandidateModule)Module).CreateNewDistrictList();
                fld_lkeFK_GEDistrictID.Properties.DataSource = ((CandidateModule)Module).GetDistrictListByStateProvinceID(int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString()));
                if (result >= 0)
                    fld_lkeFK_GEDistrictID.EditValue = result;
                else
                    fld_lkeFK_GEDistrictID.EditValue = ((CandidateModule)Module).PreDisctrictSelected;
            }
        }

        private void fld_lkeFK_GEStateProvinceID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEStateProvinceID.EditValue != null && fld_lkeFK_GEStateProvinceID.EditValue.ToString() == "-1")
            {
                int result = ((CandidateModule)Module).CreateNewSateProvinceList();
                fld_lkeFK_GEStateProvinceID.Properties.DataSource = ((CandidateModule)Module).ProvinceList;
                if (result >= 0)
                    fld_lkeFK_GEStateProvinceID.EditValue = result;
                else
                    fld_lkeFK_GEStateProvinceID.EditValue = ((CandidateModule)Module).PreStateProvinceSelected;
            }

            //if (fld_lkeFK_GEStateProvinceID.EditValue != null && !string.IsNullOrEmpty(fld_lkeFK_GEStateProvinceID.EditValue.ToString()))
            //{
            //    List<GEDistrictsInfo> districtsList = ((CandidateModule)Module).GetDistrictListByStateProvinceID(int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString()));
            //    if (districtsList != null)
            //    {
            //        fld_lkeFK_GEStateProvinceID.Properties.DataSource = districtsList;
            //    }
            //}
        }

        private void fld_lkeFK_GEDistrictID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEDistrictID.EditValue != null)
                ((CandidateModule)Module).PreDisctrictSelected = int.Parse(fld_lkeFK_GEDistrictID.EditValue.ToString());
        }

        private void fld_lkeFK_GEStateProvinceID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEStateProvinceID.EditValue != null && !string.IsNullOrEmpty(fld_lkeFK_GEStateProvinceID.EditValue.ToString()))
                ((CandidateModule)Module).PreStateProvinceSelected = int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString());
        }

        private void fld_lkeFK_GECountryID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GECountryID.EditValue != null && fld_lkeFK_GECountryID.EditValue.ToString() == "-1")
            {
                int result = ((CandidateModule)Module).CreateNewCountryList();
                fld_lkeFK_GECountryID.Properties.DataSource = ((CandidateModule)Module).CountryList;
                if (result >= 0)
                    fld_lkeFK_GECountryID.EditValue = result;
                else
                    fld_lkeFK_GECountryID.EditValue = ((CandidateModule)Module).PreCountrySelected;

            }
            List<GEStateProvincesInfo> provincesList = ((CandidateModule)Module).GetProvinceListByCountry(int.Parse(fld_lkeFK_GECountryID.EditValue.ToString()));
            if (provincesList != null)
            {
                fld_lkeFK_GEStateProvinceID.Properties.DataSource = provincesList;
            }
        }

        private void fld_lkeFK_GECountryID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GECountryID.EditValue != null)
                ((CandidateModule)Module).PreCountrySelected = int.Parse(fld_lkeFK_GECountryID.EditValue.ToString());
        }



        private void fld_lkeFK_GEIDCardStateProvinceID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEIDCardStateProvinceID.EditValue != null && fld_lkeFK_GEIDCardStateProvinceID.EditValue.ToString() == "-1")
            {
                int result = ((CandidateModule)Module).CreateNewCardSateProvinceList();
                fld_lkeFK_GEIDCardStateProvinceID.Properties.DataSource = ((CandidateModule)Module).ProvinceList;
                if (result >= 0)
                    fld_lkeFK_GEIDCardStateProvinceID.EditValue = result;
                else
                    fld_lkeFK_GEIDCardStateProvinceID.EditValue = ((CandidateModule)Module).PreStateProvinceSelected;
            }
            //List<GEDistrictsInfo> districtsList = ((CandidateModule)Module).GetDistrictListByStateProvinceID(int.Parse(fld_lkeFK_GEIDCardStateProvinceID.EditValue.ToString()));
            //if (districtsList != null)
            //{
            //    fld_lkeFK_GEIDCardStateProvinceID.Properties.DataSource = districtsList;
            //} 

        }

        private void fld_lkeFK_GEIDCardStateProvinceID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEIDCardStateProvinceID.EditValue != null)
                ((CandidateModule)Module).PreIDCardStateProvinceSelected = int.Parse(fld_lkeFK_GEIDCardStateProvinceID.EditValue.ToString());
        }

        private void fld_lkeFK_GENationalityID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GENationalityID.EditValue != null && fld_lkeFK_GENationalityID.EditValue.ToString() == "-1")
            {

                guiAddNationality guiAddNationality = new guiAddNationality();
                if (guiAddNationality.ShowDialog() == DialogResult.OK)
                {
                    GENationalitysController objGENationalitysController = new GENationalitysController();
                    GENationalitysInfo newGENationalitysInfo = new GENationalitysInfo();
                    newGENationalitysInfo = (GENationalitysInfo)objGENationalitysController.GetObjectByName(guiAddNationality.fld_txtAttributeName.Text);
                    if (newGENationalitysInfo != null && newGENationalitysInfo.GENationalityName != "")
                    {
                        MessageBox.Show(CandidateLocalizedResources.NationalityNameMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        newGENationalitysInfo = (GENationalitysInfo)objGENationalitysController.GetObjectByCode(guiAddNationality.fld_txtAttributeCode.Text);
                        if (newGENationalitysInfo != null && newGENationalitysInfo.GENationalityCode != "")
                        {
                            MessageBox.Show(CandidateLocalizedResources.NationalityCodeMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            newGENationalitysInfo = new GENationalitysInfo();
                            newGENationalitysInfo.GENationalityCode = guiAddNationality.fld_txtAttributeCode.Text;
                            newGENationalitysInfo.GENationalityName = guiAddNationality.fld_txtAttributeName.Text;
                            objGENationalitysController.CreateObject(newGENationalitysInfo);
                            ((CandidateModule)Module).RefeshNatinalityList(guiAddNationality.fld_txtAttributeName.Text);
                        }

                    }
                }
                else
                {
                    fld_lkeFK_GENationalityID.EditValue = ((CandidateModule)Module).PreNationalitySelected;
                }
            }
        }

        private void fld_lkeFK_GENationalityID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GENationalityID.EditValue != null)
                ((CandidateModule)Module).PreNationalitySelected = int.Parse(fld_lkeFK_GENationalityID.EditValue.ToString());

        }

        private void fld_lkeFK_GEReligionID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEReligionID.EditValue != null && fld_lkeFK_GEReligionID.EditValue.ToString() == "-1")
            {

                guiAddReligion guiAddReligion = new guiAddReligion();
                if (guiAddReligion.ShowDialog() == DialogResult.OK)
                {
                    GEReligionsController objGEReligionsController = new GEReligionsController();
                    GEReligionsInfo newGEReligionsInfo = new GEReligionsInfo();
                    newGEReligionsInfo = (GEReligionsInfo)objGEReligionsController.GetObjectByName(guiAddReligion.fld_txtAttributeName.Text);
                    if (newGEReligionsInfo != null && newGEReligionsInfo.GEReligionName != "")
                    {
                        MessageBox.Show(CandidateLocalizedResources.ReligionNameMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        newGEReligionsInfo = new GEReligionsInfo();
                        newGEReligionsInfo.GEReligionName = guiAddReligion.fld_txtAttributeName.Text;
                        objGEReligionsController.CreateObject(newGEReligionsInfo);
                        ((CandidateModule)Module).RefeshReligionList(guiAddReligion.fld_txtAttributeName.Text);
                    }
                }
                else
                {
                    fld_lkeFK_GEReligionID.EditValue = ((CandidateModule)Module).PreReligionSelected;
                }
            }
        }

        private void fld_lkeFK_GEReligionID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEReligionID.EditValue != null)
                ((CandidateModule)Module).PreReligionSelected = int.Parse(fld_lkeFK_GEReligionID.EditValue.ToString());
        }


    }


}

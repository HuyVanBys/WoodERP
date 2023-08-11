using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.SellStaff.UI
{
    /// <summary>
    /// Summary description for DMST100
    /// </summary>
    public partial class DMST100 : BOSERPScreen
    {

        public DMST100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HRLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((SellStaffModule)Module).ChangeLevel(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnAddContact_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).AddItemToContactList();
        }

        private void fld_btnEditContact_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeSelectedItemFromContactList();
        }

        private void fld_btnDeleteContact_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).RemoveSelectedItemFromContactList();
        }

        private void fld_lkeFK_GEDistrictID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEDistrictID.EditValue != null && fld_lkeFK_GEDistrictID.EditValue.ToString() == "-1")
            {
                int result = ((SellStaffModule)Module).CreateNewDistrictList();
                fld_lkeFK_GEDistrictID.Properties.DataSource = ((SellStaffModule)Module).DistrictList;
                fld_lkeFK_GEDistrictID.Properties.DataSource = ((SellStaffModule)Module).GetDistrictListByStateProvinceID(int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString()));
                if (result >= 0)
                    fld_lkeFK_GEDistrictID.EditValue = result;
                else
                    fld_lkeFK_GEDistrictID.EditValue = ((SellStaffModule)Module).PreDisctrictSelected;
            }
            int id = 0;
            if (fld_lkeFK_GEDistrictID.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_GEDistrictID.EditValue.ToString(), out id);
            }
            List<GEWardsInfo> wardsList = ((SellStaffModule)Module).GetWardListByDistrictID(id);
            if (wardsList != null)
            {
                fld_lkeFK_GEWardID.Properties.DataSource = wardsList;
            }
        }

        private void fld_lkeFK_GEStateProvinceID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEStateProvinceID.EditValue != null && fld_lkeFK_GEStateProvinceID.EditValue.ToString() == "-1")
            {
                int result = ((SellStaffModule)Module).CreateNewSateProvinceList();
                fld_lkeFK_GEStateProvinceID.Properties.DataSource = ((SellStaffModule)Module).ProvinceList;
                if (result >= 0)
                    fld_lkeFK_GEStateProvinceID.EditValue = result;
                else
                    fld_lkeFK_GEStateProvinceID.EditValue = ((SellStaffModule)Module).PreStateProvinceSelected;
            }
            int id = 0;
            if (fld_lkeFK_GEStateProvinceID.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_GEStateProvinceID.EditValue.ToString(), out id);
            }
            List<GEDistrictsInfo> districtsList = ((SellStaffModule)Module).GetDistrictListByStateProvinceID(id);
            if (districtsList != null)
            {
                fld_lkeFK_GEDistrictID.Properties.DataSource = districtsList;
            }

        }

        private void fld_lkeFK_GEDistrictID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEDistrictID.EditValue != null)
                ((SellStaffModule)Module).PreDisctrictSelected = int.Parse(fld_lkeFK_GEDistrictID.EditValue.ToString());
        }

        private void fld_lkeFK_GEStateProvinceID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEStateProvinceID.EditValue != null)
                ((SellStaffModule)Module).PreStateProvinceSelected = int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString());
        }

        private void fld_lkeFK_GECountryID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GECountryID.EditValue != null && fld_lkeFK_GECountryID.EditValue.ToString() == "-1")
            {
                int result = ((SellStaffModule)Module).CreateNewCountryList();
                fld_lkeFK_GECountryID.Properties.DataSource = ((SellStaffModule)Module).CountryList;
                if (result >= 0)
                    fld_lkeFK_GECountryID.EditValue = result;
                else
                    fld_lkeFK_GECountryID.EditValue = ((SellStaffModule)Module).PreCountrySelected;

            }
            int id = 0;
            if (fld_lkeFK_GECountryID.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_GECountryID.EditValue.ToString(), out id);
            }
            List<GEStateProvincesInfo> provincesList = ((SellStaffModule)Module).GetProvinceListByCountry(id);
            if (provincesList != null)
            {
                fld_lkeFK_GEStateProvinceID.Properties.DataSource = provincesList;
            }
        }

        private void fld_lkeFK_GECountryID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GECountryID.EditValue != null)
                ((SellStaffModule)Module).PreCountrySelected = int.Parse(fld_lkeFK_GECountryID.EditValue.ToString());
        }

        private void fld_lkeFK_GENativeStateProvinceID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GENativeStateProvinceID.EditValue != null && fld_lkeFK_GENativeStateProvinceID.EditValue.ToString() == "-1")
            {
                int result = ((SellStaffModule)Module).CreateNewSateProvinceList();
                fld_lkeFK_GENativeStateProvinceID.Properties.DataSource = ((SellStaffModule)Module).ProvinceList;
                if (result >= 0)
                    fld_lkeFK_GENativeStateProvinceID.EditValue = result;
                else
                    fld_lkeFK_GENativeStateProvinceID.EditValue = ((SellStaffModule)Module).PreNativeStateProvinceSelected;
            }
        }

        private void fld_lkeFK_GENativeStateProvinceID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEStateProvinceID.EditValue != null)
                ((SellStaffModule)Module).PreStateProvinceSelected = int.Parse(fld_lkeFK_GEStateProvinceID.EditValue.ToString());
        }

        private void fld_lkeFK_GEIDCardStateProvinceID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEIDCardStateProvinceID.EditValue != null && fld_lkeFK_GEIDCardStateProvinceID.EditValue.ToString() == "-1")
            {
                int result = ((SellStaffModule)Module).CreateNewSateProvinceList();
                fld_lkeFK_GEIDCardStateProvinceID.Properties.DataSource = ((SellStaffModule)Module).ProvinceList;
                if (result >= 0)
                    fld_lkeFK_GEIDCardStateProvinceID.EditValue = result;
                else
                    fld_lkeFK_GEIDCardStateProvinceID.EditValue = ((SellStaffModule)Module).PreIDCardStateProvinceSelected;
            }
        }

        private void fld_lkeFK_GEIDCardStateProvinceID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEIDCardStateProvinceID.EditValue != null)
                ((SellStaffModule)Module).PreIDCardStateProvinceSelected = int.Parse(fld_lkeFK_GEIDCardStateProvinceID.EditValue.ToString());
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
                        MessageBox.Show(SellStaffLocalizedResource.NationalityNameMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        newGENationalitysInfo = (GENationalitysInfo)objGENationalitysController.GetObjectByCode(guiAddNationality.fld_txtAttributeCode.Text);
                        if (newGENationalitysInfo != null && newGENationalitysInfo.GENationalityCode != "")
                        {
                            MessageBox.Show(SellStaffLocalizedResource.NationalityCodeMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            newGENationalitysInfo = new GENationalitysInfo();
                            newGENationalitysInfo.GENationalityCode = guiAddNationality.fld_txtAttributeCode.Text;
                            newGENationalitysInfo.GENationalityName = guiAddNationality.fld_txtAttributeName.Text;
                            objGENationalitysController.CreateObject(newGENationalitysInfo);
                            ((SellStaffModule)Module).RefeshNatinalityList(guiAddNationality.fld_txtAttributeName.Text);
                        }

                    }
                }
                else
                {
                    fld_lkeFK_GENationalityID.EditValue = ((SellStaffModule)Module).PreNationalitySelected;
                }
            }
        }

        private void fld_lkeFK_GENationalityID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GENationalityID.EditValue != null)
                ((SellStaffModule)Module).PreNationalitySelected = int.Parse(fld_lkeFK_GENationalityID.EditValue.ToString());

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
                        MessageBox.Show(SellStaffLocalizedResource.ReligionNameMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        newGEReligionsInfo = new GEReligionsInfo();
                        newGEReligionsInfo.GEReligionName = guiAddReligion.fld_txtAttributeName.Text;
                        objGEReligionsController.CreateObject(newGEReligionsInfo);
                        ((SellStaffModule)Module).RefeshReligionList(guiAddReligion.fld_txtAttributeName.Text);
                    }
                }
                else
                {
                    fld_lkeFK_GEReligionID.EditValue = ((SellStaffModule)Module).PreReligionSelected;
                }
            }
        }

        private void fld_lkeFK_GEReligionID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (fld_lkeFK_GEReligionID.EditValue != null)
                ((SellStaffModule)Module).PreReligionSelected = int.Parse(fld_lkeFK_GEReligionID.EditValue.ToString());
        }

        private void fld_lkeFK_HRDepartmentID_Validated(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentID.EditValue != fld_lkeFK_HRDepartmentID.OldEditValue)
            {
                //((SellStaffModule)Module).InvalidateDepartmentRoom(Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue.ToString()));
                int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
                if (departmentID != 0)
                    objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
                //fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
                //fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
                List<HRDepartmentRoomGroupItemsInfo> objDepartmentRoomGroupItemsInfo = new List<HRDepartmentRoomGroupItemsInfo>();
                fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.DataSource = objDepartmentRoomGroupItemsInfo;
                fld_lkeFK_HRDepartmentRoomGroupItemID1.EditValue = 0;
            }
        }

        //private void fld_lkeFK_HRDepartmentID_EditValueChanged(object sender, EventArgs e)
        //{
        //    int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
        //    HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
        //    List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
        //    if (departmentID != 0)
        //        objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
        //    fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
        //    fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
        //}

        private void fld_dteHREmployeeDob_Validated(object sender, EventArgs e)
        {
            if (fld_dteHREmployeeDob.EditValue != fld_dteHREmployeeDob.OldEditValue)
            {
                string dob = string.Empty;
                if (fld_dteHREmployeeDob.DateTime.Day == 1 && fld_dteHREmployeeDob.DateTime.Month == 1)
                {
                    dob = fld_dteHREmployeeDob.DateTime.Year.ToString();
                }
                else
                    dob = fld_dteHREmployeeDob.DateTime.ToString("dd") + "/" + fld_dteHREmployeeDob.DateTime.ToString("MM") + "/" + fld_dteHREmployeeDob.DateTime.ToString("yyyy");
                ((SellStaffModule)Module).ChangeEmployeeDob(dob);
            }
        }

        private void fld_lkeFK_HRDepartmentID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentID.EditValue != fld_lkeFK_HRDepartmentID.OldEditValue)
            {
                //((SellStaffModule)Module).EditValueChangedDeparment(Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue.ToString()));
                //int departmentID = Convert.ToInt32(fld_lkeFK_HRDepartmentID.EditValue);
                // HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                //List<HRDepartmentRoomsInfo> objDepartmentRoomsInfo = null;
                //if (departmentID != 0)
                //objDepartmentRoomsInfo = objDepartmentRoomsController.GetRoomList(departmentID);
                //fld_lkeFK_HRDepartmentRoomID.Properties.DataSource = objDepartmentRoomsInfo;
                //fld_lkeFK_HRDepartmentRoomID.EditValue = 0;
                //List<HRDepartmentRoomGroupItemsInfo> objDepartmentRoomGroupItemsInfo = new List<HRDepartmentRoomGroupItemsInfo>();
                //fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DataSource = objDepartmentRoomGroupItemsInfo;
                //fld_lkeFK_HRDepartmentRoomGroupItemID1.EditValue = 0;
                //fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            }
        }

        private void fld_dteHREmployeeDob_TextChanged(object sender, EventArgs e)
        {
            decimal EmployeeDobYear = (((decimal)(BOSApp.GetCurrentServerDate().Month + BOSApp.GetCurrentServerDate().Year * 12) - (fld_dteHREmployeeDob.DateTime.Month + fld_dteHREmployeeDob.DateTime.Year * 12)) / 12);
            fld_txtHREmployeeDobYear.Text = Math.Round(EmployeeDobYear, 1).ToString();
        }

        private void fld_lkdFK_GEStateProvinceBirthPlaceID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((SellStaffModule)Module).ChangeBirthPlace(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtFK_HRDepartmentRoomGroupteamItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int teamItemID = 0;
            Int32.TryParse(fld_lkeFK_HRDepartmentRoomGroupItemID1.EditValue.ToString(), out teamItemID);

            HRDepartmentRoomGroupTeamItemsController objDepartmentRoomGroupTeamItemsController = new HRDepartmentRoomGroupTeamItemsController();
            List<HRDepartmentRoomGroupTeamItemsInfo> departmentRoomGroupTeamItemsList = new List<HRDepartmentRoomGroupTeamItemsInfo>();

            departmentRoomGroupTeamItemsList = objDepartmentRoomGroupTeamItemsController.GetListFromHRDepartmentRoomGroupTeamItems(teamItemID);
            fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.DataSource = departmentRoomGroupTeamItemsList;
        }

        private void fld_txtHREmployeeDobString_TextChanged(object sender, EventArgs e)
        {
            //if (fld_txtHREmployeeDobString.EditValue != null && fld_txtHREmployeeDobString.EditValue.ToString().Length > 4)
            //{
            //    CultureInfo myCI = new CultureInfo("vi-VN", false);
            //    fld_txtHREmployeeDobString.Text = DateTime.ParseExact(fld_txtHREmployeeDobString.EditValue.ToString(), "d/M/yyyy", myCI).ToString("dd/MM/yyyy");
            //}
        }

        private void fld_lkeFK_GEWardID_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeFK_GEWardID.EditValue != null && fld_lkeFK_GEWardID.EditValue.ToString() == "-1")
            {
                int result = ((SellStaffModule)Module).CreateNewWardList();
                fld_lkeFK_GEWardID.Properties.DataSource = ((SellStaffModule)Module).GetWardListByDistrictID(int.Parse(fld_lkeFK_GEDistrictID.EditValue.ToString()));
                if (result >= 0)
                    fld_lkeFK_GEWardID.EditValue = result;
                else
                    fld_lkeFK_GEWardID.EditValue = ((SellStaffModule)Module).PreWardSelected;
            }
        }

        private void fld_lkeFK_GEWardID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int result = 0;
            if (fld_lkeFK_GEWardID.EditValue != null)
            {
                int.TryParse(fld_lkeFK_GEWardID.EditValue.ToString(), out result);
                ((SellStaffModule)Module).PreWardSelected = result;
            }
        }

        private void fld_lkeHREmployeeStatusCombo_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).InvalidateEmployeeStatus();
        }

        private void fld_lkeFK_HRTimeSheetParamID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRTimeSheetParamsInfo> list = (List<HRTimeSheetParamsInfo>)objTimeSheetParamsController.GetTimeSheetParamIsPause();
            if (list != null)
            {
                list.Insert(0, new HRTimeSheetParamsInfo());
            }
            fld_lkeFK_HRTimeSheetParamID.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID1_Validated(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentRoomGroupItemID1.EditValue != fld_lkeFK_HRDepartmentRoomGroupItemID1.OldEditValue)
            {
                fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            }
        }

        private void fld_lkeFK_HRDepartmentID_Validated_1(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentID.EditValue != fld_lkeFK_HRDepartmentID.OldEditValue)
            {
                fld_lkeFK_HRDepartmentroomID.EditValue = 0;
                fld_lkeFK_HRDepartmentRoomGroupItemID1.EditValue = 0;
                fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            }
        }

        private void fld_lkeFK_HRDepartmentroomID_Validated(object sender, EventArgs e)
        {
            if (fld_lkeFK_HRDepartmentroomID.EditValue != fld_lkeFK_HRDepartmentroomID.OldEditValue)
            {
                fld_lkeFK_HRDepartmentRoomGroupItemID1.EditValue = 0;
                fld_lkeFK_HRDepartmentRoomGroupTeamItemID.EditValue = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).AddEmployeeImage();
        }
    }

}

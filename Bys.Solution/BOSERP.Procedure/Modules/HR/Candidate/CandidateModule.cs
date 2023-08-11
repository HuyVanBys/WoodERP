using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Candidate
{
    public class CandidateModule : BaseModuleERP
    {
        private BOSGridControl CandidateTemplateGridControl;

        #region Constants

        public const string FilePathTextBoxName = "fld_txtFilePath";
        public const string CandiateTemplateGridControlName = "fld_dgcHRCandidateTemplates";
        public const string TemplateUserControlName = "fld_rtbTemplate";
        private string DocumentFileName = string.Empty;
        private const string SubFolder = "ProductionNormProposal";

        private const string StartRow = "\\trowd";
        private const string EndRow = "\\row";
        private const string StartCell = "\\cellx";
        private const string EndCell = "\\cell";
        private const string BackSlash = "\\";
        private const char SpaceChar = ' ';
        private const string SpecialTableString = "\\intbl";
        private const string ExpressionString = "exp";
        private const string Colon = ":";

        public const string CountryLookupEditControlName = "fld_lkeFK_GECountryID";
        public const string StateProvinceLookupEditControlName = "fld_lkeFK_GEStateProvinceID";
        public const string IDCardStateProvinceLookupEditControlName = "fld_lkeFK_GEIDCardStateProvinceID";
        public const string DistrictLookupEditControlName = "fld_lkeFK_GEDistrictID";
        public const string NationalityLookupEditControlName = "fld_lkeFK_GENationalityID";
        public const string ReligionLookupEditControlName = "fld_lkeFK_GEReligionID";
        public const string CandidateCertificatesGridControlName = "fld_dgcHRCandidateCertificates";

        #endregion Constants

        #region Private Properties

        private String TemplateServerPath { get; set; }

        #endregion Private Properties
        public List<GECountrysInfo> CountryList = new List<GECountrysInfo>();
        public List<GEStateProvincesInfo> ProvinceList = new List<GEStateProvincesInfo>();
        public int PreNativeStateProvinceSelected = 0;
        public int PreIDCardStateProvinceSelected = 0;
        public int PreStateProvinceSelected = 0;
        public int PreDisctrictSelected = 0;
        public int PreCountrySelected = 0;
        public int PreNationalitySelected = 0;
        public int PreReligionSelected = 0;
        public CandidateModule()
        {
            Name = "Candidate";
            CurrentModuleEntity = new CandidateEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            CandidateTemplateGridControl = (BOSGridControl)Controls[CandiateTemplateGridControlName];
        }
        public override int ActionSave()
        {
            int result = base.ActionSave();
            if (result > 0)
            {
                SaveFile();
            }
            return result;
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            HRCandidatesInfo objHRCandidatesInfo = (HRCandidatesInfo)entity.MainObject;
            if (objHRCandidatesInfo.HRCandidateDateStartProbationary != null && objHRCandidatesInfo.HRCandidateDateEndProbationary != DateTime.MaxValue)
            {
                DateTime curDate = BOSApp.GetCurrentServerDate();
                DateTime endDate = BOSApp.GetCurrentServerDate();
                if (objHRCandidatesInfo.HRCandidateDateEndProbationary != null && objHRCandidatesInfo.HRCandidateDateEndProbationary != DateTime.MaxValue)
                {
                    endDate = objHRCandidatesInfo.HRCandidateDateEndProbationary;
                }
                decimal days = Convert.ToDecimal((endDate - curDate).TotalDays);
                objHRCandidatesInfo.HRCandidateDateProbationaryRemain = days >= 0 ? days : 0;
                entity.UpdateMainObjectBindingSource();
            }
            InvalidateReligionList();
            InvalidateNatinalityList();
            InvalidateCountryList();
            InvalidateCardStateProvinceList();
            InvalidateStateProvinceList();

        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRCandidatesController objCandidatesController = new HRCandidatesController();
            HRCandidatesInfo searchObject = (HRCandidatesInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = objCandidatesController.GetCandidateList(
                                                            searchObject.HRCandidateNo,
                                                            BOSUtil.GetSearchString(searchObject.HRCandidateName),
                                                            searchObject.HRCandidateGenderCombo,
                                                            searchObject.HRCandidateID,
                                                            BOSUtil.GetSearchString(searchObject.HRCandidateContactAddressLine3),
                                                            searchObject.CandidateCreateFrom,
                                                            searchObject.CandidateCreateTo);
            return ds;
        }

        public void UpgradeEmployee()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn tạo nhân viên từ ứng viên này không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    HRCandidatesController objHRCandidatesController = new HRCandidatesController();
                    CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
                    HRCandidatesInfo objHRCandidatesInfo = (HRCandidatesInfo)entity.MainObject;
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    BOSUtil.CopyObject(objHRCandidatesInfo, objEmployeesInfo);
                    objEmployeesInfo.FK_BRBranchID = 1;
                    objEmployeesInfo.HREmployeeStatusCombo = EmployeeStatus.ThuViec.ToString();
                    objEmployeesInfo.HRPayRollCalculatedSalaryType = "Working";
                    objEmployeesInfo.HREmployeeNo = "";
                    GENumberingController objNumberingController = new GENumberingController();
                    GENumberingInfo obj = (GENumberingInfo)objNumberingController.GetObjectByName("SellStaff");
                    if (obj != null && string.IsNullOrEmpty(objEmployeesInfo.HREmployeeNo))
                    {
                        DateTime currentDate = BOSApp.GetCurrentServerDate();
                        string prefixYear = currentDate.Year.ToString().Substring(2, 2) + ".";
                        string no = string.Format("{0}{1}{2}", obj.GENumberingPrefix, (obj.GENumberingPrefixHaveYear ? prefixYear : ""), obj.GENumberingStart.ToString().PadLeft(obj.GENumberingLength, '0'));
                        obj.GENumberingStart++;
                        objNumberingController.UpdateObject(obj);
                        objEmployeesInfo.HREmployeeNo = no;
                    }
                    int flag = objEmployeesController.CreateObject(objEmployeesInfo);
                    if (flag > 0)
                    {
                        HREmployeeContactsController objEmployeeContactsController = new HREmployeeContactsController();
                        HREmployeeContactsInfo objContact = new HREmployeeContactsInfo();
                        objContact.FK_HREmployeeID = flag;
                        objContact.HREmployeeContactTypeCombo = objHRCandidatesInfo.HRCandidateContactType;
                        objContact.HREmployeeContactAddress = objHRCandidatesInfo.HRCandidateContactAddressLine1;
                        objContact.FK_GECountryID = objHRCandidatesInfo.FK_GECountryID;
                        objContact.FK_GEDistrictID = objHRCandidatesInfo.FK_GEDistrictID;
                        objContact.FK_GEStateProvinceID = objHRCandidatesInfo.FK_GEStateProvinceID;
                        objContact.HREmployeeContactPostalCode = objHRCandidatesInfo.HRCandidateContactAddressPostalCode;
                        objEmployeeContactsController.CreateObject(objContact);
                        MessageBox.Show("Cập nhật nhân viên đã hoàn tất!",
                                                                CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objHRCandidatesInfo.AAStatus = Status.Delete.ToString();
                        objHRCandidatesController.UpdateObject(objHRCandidatesInfo);
                        base.ActionCancel();
                    }

                }
            }
        }

        public int CreateNewDistrictList()
        {
            int result = -1;
            GEDistrictsController objGEDistrictsController = new GEDistrictsController();
            guiAddDistrict guiAddDistrict = new guiAddDistrict();
            if (guiAddDistrict.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(guiAddDistrict.fld_txtName.Text.Trim()))
                {
                    MessageBox.Show(CandidateLocalizedResources.DisctrictNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
                GEDistrictsInfo newGEDistrictsInfo = new GEDistrictsInfo();

                GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
                int newGEStateProvincesInfoID;
                newGEStateProvincesInfoID = objGEStateProvincesController.GetObjectIDByName(guiAddDistrict.fld_cmbStateProvince.Text);

                newGEDistrictsInfo.GEDistrictCode = guiAddDistrict.fld_txtCode.Text;
                newGEDistrictsInfo.GEDistrictName = guiAddDistrict.fld_txtName.Text;
                newGEDistrictsInfo.FK_GEStateProvinceID = newGEStateProvincesInfoID;
                result = objGEDistrictsController.CreateObject(newGEDistrictsInfo);
                //result = true;
            }
            return result;

        }
        public List<GEDistrictsInfo> GetDistrictListByStateProvinceID(int provinceID)
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            GEDistrictsController objGEDistrictsController = new GEDistrictsController();

            GEDistrictsInfo objGEDistrictAddnewInfo = new GEDistrictsInfo();
            objGEDistrictAddnewInfo.GEDistrictID = -1;
            objGEDistrictAddnewInfo.GEDistrictName = CandidateLocalizedResources.AddNew;

            GEDistrictsInfo objGEDistrictDummyInfo = new GEDistrictsInfo();
            objGEDistrictDummyInfo.GEDistrictID = 0;
            objGEDistrictDummyInfo.GEDistrictName = "";

            DataSet dsDisctrict = objGEDistrictsController.GetAllDataByForeignColumn("FK_GEStateProvinceID", provinceID);

            List<GEDistrictsInfo> districtsList = (List<GEDistrictsInfo>)objGEDistrictsController.GetListFromDataSet(dsDisctrict);
            if (dsDisctrict.Tables.Count == 0)
            {
                districtsList = new List<GEDistrictsInfo>();

            }
            districtsList.Insert(0, objGEDistrictDummyInfo);
            districtsList.Insert(1, objGEDistrictAddnewInfo);
            return districtsList;
        }
        public int CreateNewSateProvinceList()
        {
            int result = -1;
            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            List<GEStateProvincesInfo> StateProvinceList = new List<GEStateProvincesInfo>();
            guiAddStateProvince guiAddStateProvince = new guiAddStateProvince();
            if (guiAddStateProvince.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(guiAddStateProvince.fld_txtName.Text.Trim()))
                {
                    MessageBox.Show(CandidateLocalizedResources.StateProvinceNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
                GEStateProvincesInfo newGEStateProvincesInfo = new GEStateProvincesInfo();

                GECountrysController objGECountrysController = new GECountrysController();
                int newGECountrysInfo;
                newGECountrysInfo = objGECountrysController.GetObjectIDByName(guiAddStateProvince.fld_cmbCountry.Text);

                newGEStateProvincesInfo.FK_GECountryID = newGECountrysInfo;
                newGEStateProvincesInfo.GEStateProvinceCode = guiAddStateProvince.fld_txtCode.Text;
                newGEStateProvincesInfo.GEStateProvinceName = guiAddStateProvince.fld_txtName.Text;
                result = objGEStateProvincesController.CreateObject(newGEStateProvincesInfo);
                InvalidateStateProvinceList();
            }
            return result;
        }

        public void InvalidateStateProvinceList()
        {
            // invalidate country and province
            BOSLookupEdit StateProvinceLookupEdit = (BOSLookupEdit)Controls[CandidateModule.StateProvinceLookupEditControlName];

            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            GEStateProvincesInfo objGEStateProvinceAddnewInfo = new GEStateProvincesInfo();
            objGEStateProvinceAddnewInfo.GEStateProvinceID = -1;
            objGEStateProvinceAddnewInfo.GEStateProvinceName = CandidateLocalizedResources.AddNew;

            GEStateProvincesInfo objGEStateProvinceDummyInfo = new GEStateProvincesInfo();
            objGEStateProvinceDummyInfo.GEStateProvinceID = 0;
            objGEStateProvinceDummyInfo.GEStateProvinceName = "";
            DataSet dsStateProvince;
            dsStateProvince = objGEStateProvincesController.GetAllObjects();
            List<GEStateProvincesInfo> provincesList = (List<GEStateProvincesInfo>)objGEStateProvincesController.GetListFromDataSet(dsStateProvince);
            if (dsStateProvince.Tables.Count == 0)
            {
                provincesList = new List<GEStateProvincesInfo>();

            }
            provincesList.Insert(0, objGEStateProvinceDummyInfo);
            provincesList.Insert(1, objGEStateProvinceAddnewInfo);
            ProvinceList = provincesList;
            StateProvinceLookupEdit.Properties.DataSource = ProvinceList;
        }

        public int CreateNewCardSateProvinceList()
        {
            int result = -1;
            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            List<GEStateProvincesInfo> StateProvinceList = new List<GEStateProvincesInfo>();
            guiAddStateProvince guiAddStateProvince = new guiAddStateProvince();
            if (guiAddStateProvince.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(guiAddStateProvince.fld_txtName.Text.Trim()))
                {
                    MessageBox.Show(CandidateLocalizedResources.StateProvinceNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
                GEStateProvincesInfo newGEStateProvincesInfo = new GEStateProvincesInfo();

                GECountrysController objGECountrysController = new GECountrysController();
                int newGECountrysInfo;
                newGECountrysInfo = objGECountrysController.GetObjectIDByName(guiAddStateProvince.fld_cmbCountry.Text);

                newGEStateProvincesInfo.FK_GECountryID = newGECountrysInfo;
                newGEStateProvincesInfo.GEStateProvinceCode = guiAddStateProvince.fld_txtCode.Text;
                newGEStateProvincesInfo.GEStateProvinceName = guiAddStateProvince.fld_txtName.Text;
                result = objGEStateProvincesController.CreateObject(newGEStateProvincesInfo);
                InvalidateCardStateProvinceList();
            }
            return result;
        }

        public void InvalidateCardStateProvinceList()
        {
            // invalidate country and province
            BOSLookupEdit IDCardStateProvinceLookupEdit = (BOSLookupEdit)Controls[CandidateModule.IDCardStateProvinceLookupEditControlName];

            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            GEStateProvincesInfo objGEStateProvinceAddnewInfo = new GEStateProvincesInfo();
            objGEStateProvinceAddnewInfo.GEStateProvinceID = -1;
            objGEStateProvinceAddnewInfo.GEStateProvinceName = CandidateLocalizedResources.AddNew;

            GEStateProvincesInfo objGEStateProvinceDummyInfo = new GEStateProvincesInfo();
            objGEStateProvinceDummyInfo.GEStateProvinceID = 0;
            objGEStateProvinceDummyInfo.GEStateProvinceName = "";
            DataSet dsStateProvince;
            dsStateProvince = objGEStateProvincesController.GetAllObjects();
            List<GEStateProvincesInfo> provincesList = (List<GEStateProvincesInfo>)objGEStateProvincesController.GetListFromDataSet(dsStateProvince);
            if (dsStateProvince.Tables.Count == 0)
            {
                provincesList = new List<GEStateProvincesInfo>();

            }
            provincesList.Insert(0, objGEStateProvinceDummyInfo);
            provincesList.Insert(1, objGEStateProvinceAddnewInfo);
            ProvinceList = provincesList;
            IDCardStateProvinceLookupEdit.Properties.DataSource = ProvinceList;
        }
        public int CreateNewCountryList()
        {
            int result = -1;
            GECountrysController objGECountrysController = new GECountrysController();
            guiAddCountry guiAddCountry = new guiAddCountry();
            if (guiAddCountry.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(guiAddCountry.fld_txtAttributeName.Text.Trim()))
                {
                    MessageBox.Show(CandidateLocalizedResources.CountryNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return result;
                }
                GECountrysInfo newGECountrysInfo = new GECountrysInfo();
                newGECountrysInfo.GECountryCode = guiAddCountry.fld_txtAttributeCode.Text;
                newGECountrysInfo.GECountryName = guiAddCountry.fld_txtAttributeName.Text;
                result = objGECountrysController.CreateObject(newGECountrysInfo);
                InvalidateCountryList();
            }
            return result;
        }
        public List<GEStateProvincesInfo> GetProvinceListByCountry(int countryID)
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            GEStateProvincesController objGEStateProvincesController = new GEStateProvincesController();
            GEStateProvincesInfo objGEStateProvinceAddnewInfo = new GEStateProvincesInfo();
            objGEStateProvinceAddnewInfo.GEStateProvinceID = -1;
            objGEStateProvinceAddnewInfo.GEStateProvinceName = CandidateLocalizedResources.AddNew;

            GEStateProvincesInfo objGEStateProvinceDummyInfo = new GEStateProvincesInfo();
            objGEStateProvinceDummyInfo.GEStateProvinceID = 0;
            objGEStateProvinceDummyInfo.GEStateProvinceName = "";
            DataSet dsStateProvince;
            dsStateProvince = objGEStateProvincesController.GetAllDataByForeignColumn("FK_GECountryID", countryID);
            List<GEStateProvincesInfo> provincesList = (List<GEStateProvincesInfo>)objGEStateProvincesController.GetListFromDataSet(dsStateProvince);
            if (provincesList != null)
            {
                if (dsStateProvince.Tables.Count > 0)
                {
                    provincesList = (List<GEStateProvincesInfo>)objGEStateProvincesController.GetListFromDataSet(dsStateProvince);

                }
                provincesList.Insert(0, objGEStateProvinceDummyInfo);
                provincesList.Insert(1, objGEStateProvinceAddnewInfo);
            }
            return provincesList;

        }
        public void InvalidateReligionList()
        {
            BOSLookupEdit ReligionLookupEdit = (BOSLookupEdit)Controls[CandidateModule.ReligionLookupEditControlName];

            // invalidate Religon and province
            GEReligionsController objGEReligonsController = new GEReligionsController();
            GEReligionsInfo objGEReligionAddnewInfo = new GEReligionsInfo();
            objGEReligionAddnewInfo.GEReligionID = -1;
            objGEReligionAddnewInfo.GEReligionName = CandidateLocalizedResources.AddNew;

            GEReligionsInfo objGEReligionDummyInfo = new GEReligionsInfo();
            objGEReligionDummyInfo.GEReligionID = 0;
            objGEReligionDummyInfo.GEReligionName = "";
            DataSet dsReligion = objGEReligonsController.GetAllObjects();
            List<GEReligionsInfo> ReligionsList = (List<GEReligionsInfo>)objGEReligonsController.GetListFromDataSet(dsReligion);
            if (dsReligion.Tables.Count == 0)
            {
                ReligionsList = new List<GEReligionsInfo>();
            }
            ReligionsList.Insert(0, objGEReligionDummyInfo);
            ReligionsList.Insert(1, objGEReligionAddnewInfo);
            ReligionLookupEdit.Properties.DataSource = ReligionsList;
        }
        public void InvalidateNatinalityList()
        {
            BOSLookupEdit NationalityLookupEdit = (BOSLookupEdit)Controls[CandidateModule.NationalityLookupEditControlName];

            // invalidate Religon and province
            GENationalitysController objGEReligonsController = new GENationalitysController();
            GENationalitysInfo objGENationalityAddnewInfo = new GENationalitysInfo();
            objGENationalityAddnewInfo.GENationalityID = -1;
            objGENationalityAddnewInfo.GENationalityName = CandidateLocalizedResources.AddNew;

            GENationalitysInfo objGENationalityDummyInfo = new GENationalitysInfo();
            objGENationalityDummyInfo.GENationalityID = 0;
            objGENationalityDummyInfo.GENationalityName = "";
            DataSet dsNationality = objGEReligonsController.GetAllObjects();
            List<GENationalitysInfo> NationalitysList = (List<GENationalitysInfo>)objGEReligonsController.GetListFromDataSet(dsNationality);
            if (dsNationality.Tables.Count == 0)
            {
                NationalitysList = new List<GENationalitysInfo>();
            }
            NationalitysList.Insert(0, objGENationalityDummyInfo);
            NationalitysList.Insert(1, objGENationalityAddnewInfo);
            //NationalityList = ReligonsList;
            NationalityLookupEdit.Properties.DataSource = NationalitysList;
        }
        public void InvalidateCountryList()
        {
            BOSLookupEdit CountryLookupEdit = (BOSLookupEdit)Controls[CandidateModule.CountryLookupEditControlName];

            // invalidate country and province
            GECountrysController objGECountrysController = new GECountrysController();
            GECountrysInfo objGECountryAddnewInfo = new GECountrysInfo();
            objGECountryAddnewInfo.GECountryID = -1;
            objGECountryAddnewInfo.GECountryName = CandidateLocalizedResources.AddNew;

            GECountrysInfo objGECountryDummyInfo = new GECountrysInfo();
            objGECountryDummyInfo.GECountryID = 0;
            objGECountryDummyInfo.GECountryName = "";
            DataSet dscountry = objGECountrysController.GetAllObjects();
            List<GECountrysInfo> countrysList = (List<GECountrysInfo>)objGECountrysController.GetListFromDataSet(dscountry);
            if (dscountry.Tables.Count == 0)
            {
                countrysList = new List<GECountrysInfo>();
            }
            countrysList.Insert(0, objGECountryDummyInfo);
            countrysList.Insert(1, objGECountryAddnewInfo);
            CountryList = countrysList;
            CountryLookupEdit.Properties.DataSource = CountryList;
        }
        public void RefeshNatinalityList(string nationalityName)
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            GENationalitysController objGENationalitysController = new GENationalitysController();

            GENationalitysInfo objGENationalityAddnewInfo = new GENationalitysInfo();
            objGENationalityAddnewInfo.GENationalityID = -1;
            objGENationalityAddnewInfo.GENationalityName = CandidateLocalizedResources.AddNew;

            GENationalitysInfo objGENationalityDummyInfo = new GENationalitysInfo();
            objGENationalityDummyInfo.GENationalityID = 0;
            objGENationalityDummyInfo.GENationalityName = "";

            BOSLookupEdit NationalityLookupEdit = (BOSLookupEdit)Controls[CandidateModule.NationalityLookupEditControlName];
            DataSet dsNationality = objGENationalitysController.GetAllObjects();

            List<GENationalitysInfo> nationalitysList = (List<GENationalitysInfo>)objGENationalitysController.GetListFromDataSet(dsNationality);
            if (dsNationality.Tables.Count > 0)
            {
                nationalitysList.Insert(0, objGENationalityDummyInfo);
                nationalitysList.Insert(1, objGENationalityAddnewInfo);
                NationalityLookupEdit.Properties.DataSource = nationalitysList;
                if (nationalitysList != null)
                {
                    GENationalitysInfo objNationalitysInfo = nationalitysList.Where(x => x.GENationalityName == nationalityName).FirstOrDefault();
                    NationalityLookupEdit.EditValue = objNationalitysInfo.GENationalityID;
                }

            }
        }
        public void RefeshReligionList(string religionName)
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            GEReligionsController objGEReligionsController = new GEReligionsController();

            GEReligionsInfo objGEReligionAddnewInfo = new GEReligionsInfo();
            objGEReligionAddnewInfo.GEReligionID = -1;
            objGEReligionAddnewInfo.GEReligionName = CandidateLocalizedResources.AddNew;

            GEReligionsInfo objGEReligionDummyInfo = new GEReligionsInfo();
            objGEReligionDummyInfo.GEReligionID = 0;
            objGEReligionDummyInfo.GEReligionName = "";

            BOSLookupEdit religionLookupEdit = (BOSLookupEdit)Controls[CandidateModule.ReligionLookupEditControlName];
            DataSet dsReligion = objGEReligionsController.GetAllObjects();

            List<GEReligionsInfo> religionsList = (List<GEReligionsInfo>)objGEReligionsController.GetListFromDataSet(dsReligion);
            if (dsReligion.Tables.Count > 0)
            {
                religionsList.Insert(0, objGEReligionDummyInfo);
                religionsList.Insert(1, objGEReligionAddnewInfo);
                religionLookupEdit.Properties.DataSource = religionsList;
                if (religionsList != null)
                {
                    GEReligionsInfo objReligionsInfo = religionsList.Where(x => x.GEReligionName == religionName).FirstOrDefault();
                    religionLookupEdit.EditValue = objReligionsInfo.GEReligionID;
                }

            }
        }
        /// <summary>
        /// Add Employee Certificate  item to Employee Certificate list
        /// </summary>
        public void AddItemToCertificateList()
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            HRCandidateCertificatesInfo objHREmployeeCertificatesInfo = (HRCandidateCertificatesInfo)entity.ModuleObjects[TableName.HRCadidateCertificatesTableName];
            if (string.IsNullOrEmpty(objHREmployeeCertificatesInfo.HRCandidateCertificateType))
            {
                MessageBox.Show(CandidateLocalizedResources.HRCandidateCertificateName,
                                                            CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            entity.HRCandidateCertificateList.AddObjectToList();

        }
        public void ChangeSelectedItemFromCertificateList()
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            entity.HRCandidateCertificateList.ChangeObjectFromList();
        }
        public void RemoveSelectedItemFromCertificateList()
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            entity.HRCandidateCertificateList.RemoveSelectedRowObjectFromList();
        }
        ///// <summary>
        ///// Save proposal document file on server
        ///// </summary>
        //public void SaveProposalDocumentOnServer()
        //{
        //    BOSTextBox filePathTextBox = (BOSTextBox)Controls[FilePathTextBoxName];
        //    if (!String.IsNullOrEmpty(filePathTextBox.Text))
        //    {
        //        bool flag = true;
        //        HRCandidatesInfo objCandidateInfo = (HRCandidatesInfo)CurrentModuleEntity.MainObject;
        //        string objectID = objCandidateInfo.HRCandidateID.ToString();
        //        string newFileName = objCandidateInfo.HRCandidateID.ToString() + "_" + DocumentFileName;
        //        foreach (HRCandidateTemplatesInfo objCandidateTemplatesInfo in ((CandidateEntities)CurrentModuleEntity).CandidateTemplateList)
        //        {
        //            if (objCandidateTemplatesInfo.HRCandidateTemplateName == DocumentFileName)
        //            {
        //                if (MessageBox.Show(CandidateLocalizedResources.ConfirmOverrideFile, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //                {
        //                    BOSApp.UploadFileFTP(objectID, filePathTextBox.Text.Trim(), SubFolder);
        //                    MessageBox.Show(CandidateLocalizedResources.UploadFileSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    InvalidateTemplateGridControl();
        //                }
        //                flag = false;
        //                break;
        //            }
        //        }
        //        if (flag)
        //        {
        //            if (BOSApp.UploadFileFTP(objectID, filePathTextBox.Text.Trim(), SubFolder))
        //            {
        //                CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
        //                HRCandidateTemplatesInfo objCandidateTemplatesInfo = new HRCandidateTemplatesInfo();
        //                objCandidateTemplatesInfo.HRCandidateTemplateName = newFileName;
        //                entity.SaveTemplate(objCandidateTemplatesInfo);
        //                //entity.ProposalTemplateList.SetDefaultListAndRefreshGridControl();
        //                //entity.ProposalTemplateList.GridControl.RefreshDataSource();
        //                MessageBox.Show(CandidateLocalizedResources.UploadFileSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                InvalidateTemplateGridControl();
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// Browse proposal document file 
        ///// </summary>
        //public void BrowseFile()
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Title = "Save file as...";
        //    //dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //    dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
        //    dialog.RestoreDirectory = true;
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        BOSTextBox filePathTextBox = (BOSTextBox)Controls[FilePathTextBoxName];
        //        filePathTextBox.Text = dialog.FileName;
        //        DocumentFileName = dialog.SafeFileName;
        //    }
        //}

        //public void InvalidateTemplateGridControl()
        //{
        //    CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
        //    HRCandidatesInfo objCandidatesInfo = (HRCandidatesInfo)CurrentModuleEntity.MainObject;
        //    entity.CandidateTemplateList.Invalidate(objCandidatesInfo.HRCandidateID);
        //    foreach (HRCandidateTemplatesInfo objCandidateTemplatesInfo in entity.CandidateTemplateList)
        //    {
        //        BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
        //        HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objBaseTransactionModule.GetEmployeeByUsername(objCandidateTemplatesInfo.AACreatedUser);
        //        string candidateID = objCandidateTemplatesInfo.FK_HRCandidateID.ToString();
        //        objCandidateTemplatesInfo.HRCandidateTemplateName = objCandidateTemplatesInfo.HRCandidateTemplateName.Replace(candidateID + "_", "");
        //        //objProposalTemplatesInfo.UserCreatedFullname = objEmployeesInfo.HREmployeeName;
        //    }
        //    CandidateTemplateGridControl.RefreshDataSource();
        //}

        ///// <summary>
        ///// Delete proposal document file 
        ///// </summary>
        //public void DeleteFile()
        //{
        //    GridView gridView = (GridView)CandidateTemplateGridControl.MainView;
        //    if (gridView.FocusedRowHandle >= 0)
        //    {
        //        if (MessageBox.Show(PurchaseProposalLocalizedResources.ConfirmDeleteFile, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            MMProposalsInfo objProposalInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
        //            string objectID = objProposalInfo.MMProposalID.ToString();
        //            MMProposalTemplatesInfo objProposalTemplatesInfo = (MMProposalTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //            string PurchaseProposalTemplateName = string.Empty;
        //            PurchaseProposalTemplateName += objectID + "_" + objProposalTemplatesInfo.MMProposalTemplateName.ToString();
        //            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //            BOSApp.DeleteFile(PurchaseProposalTemplateName, SubFolder);
        //            ProductionNormProposalEntities entity = (ProductionNormProposalEntities)CurrentModuleEntity;
        //            entity.ProposalTemplateList.Remove(objProposalTemplatesInfo);
        //            entity.ProposalTemplateList.SaveItemObjects();
        //            ProposalTemplateGridControl.RefreshDataSource();
        //        }
        //    }
        //}

        ///// <summary>
        ///// View proposal document file 
        ///// </summary>
        //public void ViewFile()
        //{
        //    try
        //    {
        //        GridView gridView = (GridView)ProposalTemplateGridControl.MainView;
        //        if (gridView.FocusedRowHandle >= 0)
        //        {
        //            MMProposalsInfo objProposalInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
        //            string objectID = objProposalInfo.MMProposalID.ToString();
        //            MMProposalTemplatesInfo objProposalTemplatesInfo = (MMProposalTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //            string proposalTemplateName = string.Empty;
        //            proposalTemplateName += objectID + "_" + objProposalTemplatesInfo.MMProposalTemplateName.ToString();
        //            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //            string localPath = BOSApp.DownloadFileFTP(proposalTemplateName, SubFolder);
        //            if (!string.IsNullOrEmpty(localPath))
        //            {
        //                System.Diagnostics.Process.Start(localPath);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show(ProductionNormProposalLocalizedResources.SelectTemplateToView, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        ///// <summary>
        ///// Add a new template
        ///// </summary>
        ///// <param name="templateType">Template type</param>
        //public void AddTemplate(TemplateType templateType)
        //{
        //    System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    guiChooseTemplate guiChooseTemplate = new guiChooseTemplate(templateType);
        //    guiChooseTemplate.Module = this;
        //    if (guiChooseTemplate.ShowDialog() == DialogResult.OK && guiChooseTemplate.SelectedTemplate != null)
        //    {
        //        //string localPath = BOSApp.DownloadFileFTP(guiChooseTemplate.SelectedTemplate.GETemplateNo + ".rtf", "TEMPLATE");
        //        //LoadTemplate(localPath);

        //        string fileName = string.Format(@"{0}\Template\{1}.rtf", TemplateServerPath, guiChooseTemplate.SelectedTemplate.GETemplateNo);
        //        LoadTemplate(fileName);
        //    }
        //}

        ///// <summary>
        ///// Load a template from file and insert patient info
        ///// </summary>
        ///// <param name="fileName"></param>
        //public void LoadTemplate(string fileName)
        //{
        //    if (File.Exists(fileName))
        //    {
        //        RichTextBoxExtended templateUserControl = (RichTextBoxExtended)Controls[TemplateUserControlName];
        //        templateUserControl.LoadFile(fileName);

        //        if (IsContainTableAndExpression(templateUserControl.rtb1.Rtf))
        //        {
        //            CodeTextBox rtb = new CodeTextBox();
        //            rtb.Rtf = templateUserControl.rtb1.Rtf;
        //            rtb.Rtf = DeleteExpression(rtb.Rtf);
        //            templateUserControl.rtb1.Rtf = rtb.Rtf;
        //        }

        //        APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;


        //        //Set general info to template
        //        RichTextboxHelper.SetTemplateGeneralInfo(templateUserControl.RichTextBox);

        //        //Set employee info to template 
        //        HREmployeesController objEmployeesController = new HREmployeesController();
        //        HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
        //        if (objEmployeesInfo != null)
        //        {
        //            RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[HREmployeeName]", objEmployeesInfo.HREmployeeName);
        //            RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[HREmployeeTel2]", objEmployeesInfo.HREmployeeTel2);
        //        }

        //        //Set customer info to template
        //        /*
        //        ARCustomersController objCustomersController = new ARCustomersController();
        //        ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objProposalsInfo.FK_ARCustomerID);
        //        if (objCustomersInfo != null)
        //        {
        //            RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[ARCustomerName]", objCustomersInfo.ARCustomerName);
        //            RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[ARCustomerContactAddressLine1]", objCustomersInfo.ARCustomerContactAddressLine1);
        //            RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[ARCustomerContactPhone]", objCustomersInfo.ARCustomerContactPhone);
        //            RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[ARCustomerContactName]", objCustomersInfo.ARCustomerContactName);
        //            RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[ARCustomerTaxNumber]", objCustomersInfo.ARCustomerTaxNumber);
        //        }*/

        //        //Date time
        //        RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[DateTime.Day]", DateTime.Now.Day.ToString());
        //        RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[DateTime.Month]", DateTime.Now.Month.ToString());
        //        RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[DateTime.Year]", DateTime.Now.Year.ToString());
        //        RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[DateTime.Hour]", DateTime.Now.Hour.ToString());
        //        RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[DateTime.Minute]", DateTime.Now.Minute.ToString());
        //        RichTextboxHelper.Replace(templateUserControl.RichTextBox, "[DateTime.Second]", DateTime.Now.Second.ToString());

        //    }
        //}

        ///// <summary>
        ///// Check rtf string contains table and expression or not
        ///// </summary>
        ///// <param name="rtf">Rtf string</param>
        ///// <returns>True or false</returns>
        //public bool IsContainTableAndExpression(string rtf)
        //{
        //    if (rtf.Contains(StartRow))
        //    {
        //        if (rtf.Contains(ExpressionString))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        ///// <summary>
        ///// Delete expression in richtextbox
        ///// </summary>
        ///// <param name="rtf">Rtf string</param>
        ///// <returns>Rtf string after remove expression</returns>
        //public string DeleteExpression(string rtf)
        //{
        //    string result = rtf;
        //    RtfTable rtfTable = new RtfTable();
        //    RtfCell rtfCell = new RtfCell();
        //    rtfTable = RtfTable.GetTable(result);

        //    //Get RtfTable
        //    CodeTextBox ctb = new CodeTextBox();
        //    ctb.Rtf = rtf;
        //    TemplateIntellisense.RtfTableTemplate = RtfTable.GetTable(result);

        //    //Delete expression in rtf;
        //    int rowCount = rtfTable.RowCount;
        //    for (int row = 0; row < rowCount; row++)
        //    {
        //        string rowContent = rtfTable.GetRow(result, row);
        //        int colCount = rtfTable.Rows[row].ColumnCount;
        //        for (int col = 0; col < colCount; col++)
        //        {
        //            object value = rtfTable.Rows[row].Cells[col].Value;
        //            if (value.ToString().Contains(ExpressionString))
        //            {
        //                string rtfResult = rtfCell.UpdateCellValue(result, rowContent, row, col, String.Empty);
        //                result = rtfResult;
        //                rowContent = rtfTable.GetRow(result, row);

        //            }
        //        }

        //    }
        //    return result;
        //}

        public void BrowseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            //dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[CandidateModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            HRCandidatesInfo objCandidatesInfo = (HRCandidatesInfo)entity.MainObject;

            if (entity.CandidateTemplateList.Exists(o => o.HRCandidateTemplateName.Equals(DocumentFileName)))
            {
                MessageBox.Show("File đinh kèm đã tồn tại. Vui lòng kiểm tra lại!",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRCandidateTemplatesInfo objCandidateTemplatesInfo = new HRCandidateTemplatesInfo();
            objCandidateTemplatesInfo.HRCandidateTemplateName = DocumentFileName;
            objCandidateTemplatesInfo.FK_HRCandidateID = objCandidatesInfo.HRCandidateID;
            objCandidateTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
            objCandidateTemplatesInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objCandidateTemplatesInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.CandidateTemplateList.Add(objCandidateTemplatesInfo);
            entity.CandidateTemplateList.GridControl.RefreshDataSource();
        }

        public void DownloadDocmenent()
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            HRCandidateTemplatesInfo objCandidateTemplatesInfo = entity.CandidateTemplateList[entity.CandidateTemplateList.CurrentIndex];
            if (objCandidateTemplatesInfo == null)
                return;

            if (string.IsNullOrEmpty(objCandidateTemplatesInfo.HRCandidateTemplateFileGUID))
            {
                MessageBox.Show("Không tìm thấy file!",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objCandidateTemplatesInfo.HRCandidateTemplateFileGUID, objCandidateTemplatesInfo.HRCandidateTemplateName);
        }

        public void SaveFile()
        {
            CandidateEntities entity = (CandidateEntities)CurrentModuleEntity;
            HRCandidatesInfo objCandidatesInfo = (HRCandidatesInfo)entity.MainObject;
            List<HRCandidateTemplatesInfo> candidateTemplatesList = entity.CandidateTemplateList.ToList();

            HRCandidateTemplatesController objCandidateTemplatesController = new HRCandidateTemplatesController();
            HRCandidateTemplatesInfo objCandidateTemplatesInfo = new HRCandidateTemplatesInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            candidateTemplatesList.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.HRCandidateTemplateFileGUID))
                    return;

                entity.CandidateTemplateURLDic.TryGetValue(o.HRCandidateTemplateID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.HRCandidateTemplateFileGUID = ApiClientHelper.UpdateFile(value);
                objCandidateTemplatesController.UpdateObject(o);
            });
            entity.CandidateTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.CandidateTemplateList.GridControl.RefreshDataSource();
        }
    }
}

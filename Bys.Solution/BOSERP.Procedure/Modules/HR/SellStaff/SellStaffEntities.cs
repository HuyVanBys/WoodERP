using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.SellStaff
{
    public class SellStaffEntities : ERPModuleEntities
    {
        #region Declare Constant
        /// <summary>
        /// Gets or sets the leave day list
        /// </summary>
        public BOSList<HRLeaveDaysInfo> LeaveDayList { get; set; }
        /// <summary>
        /// Gets or sets the employee working shift list
        /// </summary>
        public BOSList<HREmployeeWorkingShiftsInfo> EmployeeWorkingShiftList { get; set; }
        /// <summary>
        /// Gets or sets the history detail list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }
        /// <summary>
        /// Get or set the discipline list of employee
        /// </summary>
        public BOSList<HRDisciplinesInfo> DisciplineList { get; set; }
        public BOSList<HRAllowancesInfo> AllowanceList { get; set; }
        /// <summary>
        /// Gets or sets the employee evaluation list
        /// </summary>
        public BOSList<HREmployeeEvaluationsInfo> EmployeeEvaluationList { get; set; }
        /// <summary>
        /// Get or set the reward list of employee
        /// </summary>
        public BOSList<HRRewardsInfo> RewardList { get; set; }

        /// <summary>
        /// Gets or sets the list of overtime factors associating with the employee
        /// </summary>
        public BOSList<HREmployeeOTFactorsInfo> OTFactorList { get; set; }

        /// <summary>
        /// Gets or sets the proposal template list
        /// </summary>
        public BOSList<HREmployeeTemplatesInfo> HREmployeeTemplatesList { get; set; }
        public BOSList<HREmployeeContractsInfo> HREmployeeContractList { get; set; }
        public BOSList<HREmployeeTranfersInfo> HREmployeeTranferList { get; set; }
        public BOSList<HREmployeeContactsInfo> HREmployeeContactList { get; set; }
        public BOSList<HREmployeeCertificatesInfo> HREmployeeCertificateList { get; set; }
        public BOSList<HRAdvanceRequestItemsInfo> HRAdvanceRequestItemList { get; set; }
        public BOSList<ARDeliverysInfo> DeliverysList { get; set; }
        public BOSList<HREmployeeContactPersonsInfo> HREmployeeContactPersonList { get; set; }
        public BOSList<HRQuarterRewardsInfo> HRQuarterRewardList { get; set; }
        /// <summary>
        /// Gets or sets the list country list
        /// </summary>
        //public BOSList<GECountrysInfo> CountryList { get; set; }
        //public BOSList<GEStateProvincesInfo> ProviceList { get; set; }
        //public BOSList<GENationalitysInfo> NationalityList { get; set; }
        //public BOSList<GEReligionsInfo> ReligionList { get; set; }
        //public BOSList<ADConfigValuesInfo> LeaveDayOffList { get; set; }
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public SellStaffEntities()
            : base()
        {
            //CountryList = new BOSList<GECountrysInfo>();
            //ProviceList = new BOSList<GEStateProvincesInfo>();
            //NationalityList =new BOSList<GENationalitysInfo>();
            //ReligionList = new BOSList<GEReligionsInfo>();
            LeaveDayList = new BOSList<HRLeaveDaysInfo>();
            EmployeeWorkingShiftList = new BOSList<HREmployeeWorkingShiftsInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();
            DisciplineList = new BOSList<HRDisciplinesInfo>();
            AllowanceList = new BOSList<HRAllowancesInfo>();
            EmployeeEvaluationList = new BOSList<HREmployeeEvaluationsInfo>();
            RewardList = new BOSList<HRRewardsInfo>();
            OTFactorList = new BOSList<HREmployeeOTFactorsInfo>();
            //HREmployeeTemplatesList = new BOSList<HREmployeeTemplatesInfo>();
            HREmployeeContractList = new BOSList<HREmployeeContractsInfo>();
            HREmployeeTranferList = new BOSList<HREmployeeTranfersInfo>();
            HREmployeeContactList = new BOSList<HREmployeeContactsInfo>();
            HREmployeeCertificateList = new BOSList<HREmployeeCertificatesInfo>();
            HREmployeeContactPersonList = new BOSList<HREmployeeContactPersonsInfo>();
            HRAdvanceRequestItemList = new BOSList<HRAdvanceRequestItemsInfo>();
            //LeaveDayOffList = new BOSList<ADConfigValuesInfo>();
            HRQuarterRewardList = new BOSList<HRQuarterRewardsInfo>();
            DeliverysList = new BOSList<ARDeliverysInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions        
        public override void InitMainObject()
        {
            MainObject = new HREmployeesInfo();
            SearchObject = new HREmployeesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeOTFactorsTableName, new HREmployeeOTFactorsInfo());
            ModuleObjects.Add(TableName.HREmployeeTemplatesTableName, new HREmployeeTemplatesInfo());
            ModuleObjects.Add(TableName.HREmployeeContractsTableName, new HREmployeeContractsInfo());
            ModuleObjects.Add(TableName.HREmployeeTranfersTableName, new HREmployeeTranfersInfo());
            ModuleObjects.Add(TableName.HREmployeeContactsTableName, new HREmployeeContactsInfo());
            ModuleObjects.Add(TableName.HREmployeeCertificatesTableName, new HREmployeeCertificatesInfo());
            ModuleObjects.Add(TableName.HREmployeeContactPersonsTableName, new HREmployeeContactPersonsInfo());
            ModuleObjects.Add(TableName.HRAdvanceRequestItemsTableName, new HRAdvanceRequestItemsInfo());
            ModuleObjects.Add(TableName.HRQuarterRewardsTableName, new HRQuarterRewardsInfo());
            ModuleObjects.Add(TableName.ARDeliveryTableName, new ARDeliverysInfo());
        }

        public override void InitModuleObjectList()
        {
            LeaveDayList.InitBOSList(this,
                                            TableName.HREmployeesTableName,
                                            TableName.HRLeaveDaysTableName,
                                            BOSList<HRLeaveDaysInfo>.cstRelationForeign);
            LeaveDayList.ItemTableForeignKey = "FK_HREmployeeID";

            EmployeeWorkingShiftList.InitBOSList(
                                          this,
                                          TableName.HREmployeesTableName,
                                          TableName.HREmployeeWorkingShiftsTableName,
                                          BOSList<HREmployeeWorkingShiftsInfo>.cstRelationForeign);
            EmployeeWorkingShiftList.ItemTableForeignKey = "FK_HREmployeeID";

            HistoryDetailList.InitBOSList(this,
                                           TableName.GEObjectHistoryTableName,
                                           TableName.GEHistoryDetailsTableName,
                                           BOSList<GEHistoryDetailsInfo>.cstRelationForeign);
            HistoryDetailList.ItemTableForeignKey = "FK_GEObjectHistoryID";

            DisciplineList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRDisciplinesTableName,
                                           BOSList<HRDisciplinesInfo>.cstRelationNone);
            AllowanceList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRAllowancesTableName,
                                           BOSList<HRAllowancesInfo>.cstRelationNone);
            EmployeeEvaluationList.InitBOSList(this,
                                          TableName.HREmployeesTableName,
                                          TableName.HREmployeeEvaluationsTableName,
                                          BOSList<HREmployeeEvaluationsInfo>.cstRelationForeign);
            EmployeeEvaluationList.ItemTableForeignKey = "FK_HREmployeeID";
            RewardList.InitBOSList(this,
                                          String.Empty,
                                          TableName.HRRewardsTableName,
                                          BOSList<HRRewardsInfo>.cstRelationNone);

            OTFactorList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.HREmployeeOTFactorsTableName,
                                    BOSList<HREmployeeOTFactorsInfo>.cstRelationForeign);
            OTFactorList.ItemTableForeignKey = "FK_HREmployeeID";

            //HREmployeeTemplatesList.InitBOSList(
            //                            this,
            //                            TableName.HREmployeesTableName,
            //                            TableName.HREmployeeTemplatesTableName,
            //                            BOSList<HREmployeeTemplatesInfo>.cstRelationForeign);

            HREmployeeContractList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.HREmployeeContractsTableName,
                                    BOSList<HREmployeeContractsInfo>.cstRelationForeign);
            HREmployeeContractList.ItemTableForeignKey = "FK_HREmployeeID";
            HREmployeeContractList.FieldNameNotInChanged.Add("Selected");
            HREmployeeTranferList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.HREmployeeTranfersTableName,
                                    BOSList<HREmployeeTranfersInfo>.cstRelationForeign);
            HREmployeeTranferList.ItemTableForeignKey = "FK_HREmployeeID";
            HREmployeeTranferList.FieldNameNotInChanged.Add("Selected");
            HREmployeeContactList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.HREmployeeContactsTableName,
                                    BOSList<HREmployeeContactsInfo>.cstRelationForeign);
            HREmployeeContactList.ItemTableForeignKey = "FK_HREmployeeID";
            HREmployeeCertificateList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.HREmployeeCertificatesTableName,
                                    BOSList<HREmployeeCertificatesInfo>.cstRelationForeign);
            HREmployeeCertificateList.ItemTableForeignKey = "FK_HREmployeeID";
            HREmployeeContactPersonList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.HREmployeeContactPersonsTableName,
                                    BOSList<HREmployeeContactPersonsInfo>.cstRelationForeign);
            HREmployeeContactPersonList.ItemTableForeignKey = "FK_HREmployeeID";
            HRAdvanceRequestItemList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.HRAdvanceRequestItemsTableName,
                                    BOSList<HREmployeeContactsInfo>.cstRelationNone);
            HRAdvanceRequestItemList.ItemTableForeignKey = "FK_HREmployeeID";
            DeliverysList.InitBOSList(this,
                                    TableName.HREmployeesTableName,
                                    TableName.ARDeliveryTableName,
                                    BOSList<HREmployeeContactsInfo>.cstRelationNone);
            DeliverysList.ItemTableForeignKey = "FK_HREmployeeID";
            //LeaveDayOffList.InitBOSList(this,
            //                                String.Empty,
            //                                TableName.ADConfigValuesTableName,
            //                                BOSList<ADConfigValuesInfo>.cstRelationNone);
            HRQuarterRewardList.InitBOSList(this,
                                           TableName.HREmployeesTableName,
                                           TableName.HRQuarterRewardsTableName,
                                           BOSList<HRQuarterRewardsInfo>.cstRelationNone);
            HRQuarterRewardList.ItemTableForeignKey = "FK_HREmployeeID";
        }

        public override void InitGridControlInBOSList()
        {
            LeaveDayList.InitBOSListGridControl();
            //LeaveDayOffList.InitBOSListGridControl();
            EmployeeWorkingShiftList.InitBOSListGridControl();
            HistoryDetailList.InitBOSListGridControl();
            DisciplineList.InitBOSListGridControl();
            AllowanceList.InitBOSListGridControl();
            EmployeeEvaluationList.InitBOSListGridControl();
            RewardList.InitBOSListGridControl();
            OTFactorList.InitBOSListGridControl(SellStaffModule.EmployeeOTFactorGridControlName);
            //HREmployeeTemplatesList.InitBOSListGridControl(SellStaffModule.HREmployeeTemplateGridControlName);
            HREmployeeContractList.InitBOSListGridControl(SellStaffModule.EmployeeContractsGridControlName);
            HREmployeeTranferList.InitBOSListGridControl(SellStaffModule.EmployeeTranfersGridControlName);
            HREmployeeContactList.InitBOSListGridControl(SellStaffModule.EmployeeContactsGridControlName);
            HREmployeeCertificateList.InitBOSListGridControl(SellStaffModule.EmployeeCertificatesGridControlName);
            HREmployeeContactPersonList.InitBOSListGridControl(SellStaffModule.EmployeeContactPersonsGridControlName);
            HRAdvanceRequestItemList.InitBOSListGridControl();
            HRQuarterRewardList.InitBOSListGridControl("fld_dgcHRQuarterRewards");
            DeliverysList.InitBOSListGridControl();

        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)MainObject;
            // objEmployeesInfo.HREmployeeDob = DateTime.Now;
            //objEmployeesInfo.HREmployeeStartWorkingDate = DateTime.Now;
            objEmployeesInfo.HREmployeeEndWorkingDate = BOSUtil.GetYearEndDate();
            objEmployeesInfo.HREmployeeStatusCombo = EmployeeStatus.Working.ToString();
            objEmployeesInfo.HRInsCalculatedSalaryType = CalculatedSalaryType.Basic.ToString();
            objEmployeesInfo.HRPayRollCalculatedSalaryType = CalculatedSalaryType.Working.ToString();

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            decimal daysPerMonth = Convert.ToDecimal(objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.DaysPerMonth.ToString()).ADConfigKeyValue);
            decimal hoursPerDay = Convert.ToDecimal(objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.HoursPerDay.ToString()).ADConfigKeyValue);
            objEmployeesInfo.HREmployeeDaysPerMonth = daysPerMonth;
            objEmployeesInfo.HREmployeeHoursPerDay = hoursPerDay;

            objEmployeesInfo.HREmployeeStartWorkingTime = Convert.ToDateTime(App.EmployeeStartWorkingTime);
            objEmployeesInfo.HREmployeeEndWorkingTime = Convert.ToDateTime(App.EmployeeEndWorkingTime);
            objEmployeesInfo.HREmployeeSocialInsPaymentPercent = BOSApp.CurrentCompanyInfo.CSCompanySocialInsPercent;
            objEmployeesInfo.HREmployeeHealthInsPaymentPercent = BOSApp.CurrentCompanyInfo.CSCompanyHealthInsPercent;
            objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercent = BOSApp.CurrentCompanyInfo.CSCompanyOutOfWorkInsPercent;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeWorkingShiftList.SetDefaultListAndRefreshGridControl();
                LeaveDayList.SetDefaultListAndRefreshGridControl();
                //LeaveDayOffList.SetDefaultListAndRefreshGridControl();
                HistoryDetailList.SetDefaultListAndRefreshGridControl();
                DisciplineList.SetDefaultListAndRefreshGridControl();
                AllowanceList.SetDefaultListAndRefreshGridControl();
                EmployeeEvaluationList.SetDefaultListAndRefreshGridControl();
                RewardList.SetDefaultListAndRefreshGridControl();

                List<HREmployeeOTFactorsInfo> factors = GetDefaultOTFactors();
                OTFactorList.Invalidate(factors);
                //HREmployeeTemplatesList.SetDefaultListAndRefreshGridControl();
                HREmployeeContractList.SetDefaultListAndRefreshGridControl();
                HREmployeeTranferList.SetDefaultListAndRefreshGridControl();
                HREmployeeContactList.SetDefaultListAndRefreshGridControl();
                HREmployeeCertificateList.SetDefaultListAndRefreshGridControl();
                HREmployeeContactPersonList.SetDefaultListAndRefreshGridControl();
                HRQuarterRewardList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            SetPropertyChangeEventLock(false);
            EmployeeWorkingShiftList.Invalidate(iObjectID);
            HistoryDetailList.Invalidate(iObjectID);
            //HREmployeeTemplatesList.Invalidate(iObjectID);
            OTFactorList.Invalidate(iObjectID);
            HREmployeeContractList.Invalidate(iObjectID);
            HREmployeeContractList.Invalidate(HREmployeeContractList.OrderByDescending(x => x.HREmployeeContractDateFrom).ToList());
            HREmployeeTranferList.Invalidate(iObjectID);
            HREmployeeContactList.Invalidate(iObjectID);
            HREmployeeCertificateList.Invalidate(iObjectID);
            HREmployeeContactPersonList.Invalidate(iObjectID);

            //HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)MainObject; 
            //HREmployeeTranfersController objEmployeeTranfersController = new HREmployeeTranfersController();
            //foreach (var i in HREmployeeTranferList)
            //{
            //    //obj = objEmployeeTranfersController.GetOldEmployeeTranferByTranferID(i.HREmployeeTranferID, i.FK_HREmployeeID);
            //    //if (obj != null)
            //    //{
            //    //    i.BRBranchIDOld = obj.FK_BRBranchID;
            //    //    i.HRDepartmentIDOld = obj.FK_HRDepartmentID;
            //    //    i.HRDepartmentRoomIDOld = obj.FK_HRDepartmentRoomID;
            //    //    i.HRLevelIDOld = obj.FK_HRLevelID;
            //    //}
            //    //else
            //    {
            //        i.BRBranchIDOld = objEmployeesInfo.FK_BRBranchID;
            //        i.HRDepartmentIDOld = objEmployeesInfo.FK_HRDepartmentID;
            //        i.HRDepartmentRoomIDOld = objEmployeesInfo.FK_HRDepartmentRoomID;
            //        i.HRLevelIDOld = objEmployeesInfo.FK_HRLevelID;
            //        i.HRDepartmentRoomGroupItemIDOld = objEmployeesInfo.FK_HRDepartmentRoomGroupItemID;
            //        i.HRDepartmentRoomGroupTeamItemIDOld = objEmployeesInfo.FK_HRDepartmentRoomGroupTeamItemID;
            //    }
            //}
            if (OTFactorList.Count == 0)
            {
                List<HREmployeeOTFactorsInfo> factors = GetDefaultOTFactors();
                OTFactorList.Invalidate(factors);
            }

            //HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            //List<HRLeaveDaysInfo> objLeaveDaysList = new List<HRLeaveDaysInfo>();
            //objLeaveDaysList = objLeaveDaysController.GetListLeaveDayByHREmployeeID(iObjectID, null, null);
            //LeaveDayList.Invalidate(objLeaveDaysList);

            //HRQuarterRewardList.Invalidate(iObjectID);
            //HRQuarterRewardList.GridControl.RefreshDataSource();
            HRQuarterRewardsController objQuarterRewardsController = new HRQuarterRewardsController();
            List<HRQuarterRewardsInfo> QuarterRewardsList = new List<HRQuarterRewardsInfo>();
            QuarterRewardsList = objQuarterRewardsController.GetListFromDataSet(objQuarterRewardsController.GetAllDataByForeignColumn("FK_HREmployeeID", iObjectID));
            HRQuarterRewardList.Invalidate(QuarterRewardsList);
            //HRQuarterRewardList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Get the default overtime factors for the employee
        /// </summary>
        /// <returns>List of overtime factors</returns>
        private List<HREmployeeOTFactorsInfo> GetDefaultOTFactors()
        {
            HROTFactorsController objOTFactorsController = new HROTFactorsController();
            List<HROTFactorsInfo> factors = objOTFactorsController.GetAllOTFactors();
            List<HREmployeeOTFactorsInfo> employeeFactors = new List<HREmployeeOTFactorsInfo>();
            foreach (HROTFactorsInfo factor in factors)
            {
                HREmployeeOTFactorsInfo employeeFactor = new HREmployeeOTFactorsInfo();
                employeeFactor.HROTFactorType = factor.HROTFactorType;
                employeeFactor.HREmployeeOTFactorFromTime = factor.HROTFactorFromTime;
                employeeFactor.HREmployeeOTFactorToTime = factor.HROTFactorToTime;
                employeeFactor.HREmployeeOTFactorValue = factor.HROTFactorValue;
                employeeFactors.Add(employeeFactor);
            }
            return employeeFactors;
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)MainObject;
            //objEmployeesInfo.HREmployeeContactAddressLine3 = BOSUtil.GenerateFullAddress(objEmployeesInfo, AddressType.Contact.ToString());
            objEmployeesInfo.HREmployeeContactAddressLine3 = HREmployeeContactList.Where(x => x.HREmployeeContactTypeCombo == EmployeeContactType.DiaChiThuongTru.ToString()).Select(x => x.HREmployeeContactAddress).FirstOrDefault();
            if (objEmployeesInfo.HREmployeeIDNumber.Length != 9)
            {
                MessageBox.Show(Localization.SellStaffLocalizedResource.HREmployeeIDNumberErrorMessage, Localization.CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)MainObject;
            //LeaveDayList.SaveItemObjects();
            EmployeeWorkingShiftList.SaveItemObjects();
            OTFactorList.SaveItemObjects();

            GENumberingController objNumberingController = new GENumberingController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            //TNDLoc [ADD][28/12/2015][Generate Contract No (MSNV/HĐLĐ – LV)],START
            //foreach (var item in HREmployeeContractList)
            //{
            //    GENumberingInfo obj = (GENumberingInfo)objNumberingController.GetObjectByName("EmployeeContract");
            //    if (obj == null) break;
            //    if (string.IsNullOrEmpty(item.HREmployeeContractNo))
            //    {
            //        DateTime currentDate = dbUtil.GetCurrentServerDate();
            //        string prefixYear = currentDate.Year.ToString().Substring(2, 2) + ".";
            //        string no = string.Format("{0}{1}{2}", obj.GENumberingPrefix, (obj.GENumberingPrefixHaveYear ? prefixYear : ""), obj.GENumberingStart.ToString().PadLeft(obj.GENumberingLength, '0'));
            //        obj.GENumberingStart++;
            //        objNumberingController.UpdateObject(obj);
            //        item.HREmployeeContractNo = no;
            //    }
            //}
            //TNDLoc [ADD][28/12/2015][Generate Contract No (MSNV/HĐLĐ – LV)],END
            //TNDLoc [ADD][28/12/2015][Generate Transfer No (MSNV/PLHĐ – LV)],START
            //foreach (var item in HREmployeeTranferList)
            //{
            //    GENumberingInfo obj = (GENumberingInfo)objNumberingController.GetObjectByName("EmployeeTransfer");
            //    if (obj == null) break;
            //    if (string.IsNullOrEmpty(item.HREmployeeTranferNo))
            //    {
            //        DateTime currentDate = dbUtil.GetCurrentServerDate();
            //        string prefixYear = currentDate.Year.ToString().Substring(2, 2) + ".";
            //        string no = string.Format("{0}{1}{2}", obj.GENumberingPrefix, (obj.GENumberingPrefixHaveYear ? prefixYear : ""), obj.GENumberingStart.ToString().PadLeft(obj.GENumberingLength, '0'));
            //        obj.GENumberingStart++;
            //        objNumberingController.UpdateObject(obj);
            //        item.HREmployeeTranferNo = no;
            //    }
            //}


            //-----------------------------------------------------------------------------------------------
            //KhanhHuy 14/08/2019

            //int count = 0;
            //int countHV = 0;
            //string prefixNo = "/HĐLĐ–LV";
            //string prefixHocViecNo = "/HĐĐTN-LV";
            //List<HREmployeeContractsInfo> listHocViec = HREmployeeContractList.Where(x => x.HREmployeeContractType == EmployeeContractType.HocViec.ToString()).ToList();

            //List<HREmployeeContractsInfo> listOtherContract = HREmployeeContractList.Where(x => x.HREmployeeContractType != EmployeeContractType.HocViec.ToString()).ToList();

            //foreach (var item in listOtherContract)
            //{
            //    if (string.IsNullOrEmpty(item.HREmployeeContractNo))
            //    {
            //        string no = string.Empty;
            //        if (count == 0)
            //        {
            //            no = objEmployeesInfo.HREmployeeNo + prefixNo;
            //        }
            //        else
            //        {

            //            no = objEmployeesInfo.HREmployeeNo + prefixNo + count;
            //        }
            //        item.HREmployeeContractNo = no;
            //    }
            //    count++;
            //}
            //foreach (var item in listHocViec)
            //{
            //    GENumberingInfo obj = (GENumberingInfo)objNumberingController.GetObjectByName("EmployeeContract");
            //    if (obj == null) break;
            //    if (string.IsNullOrEmpty(item.HREmployeeContractNo))
            //    {
            //        string no = string.Empty;
            //        if (countHV == 0)
            //        {

            //            prefixNo = "/" + DateTime.Now.Year.ToString() + prefixHocViecNo;
            //            no = objEmployeesInfo.HREmployeeNo + prefixNo;
            //        }
            //        else
            //        {

            //            prefixNo = "/" + DateTime.Now.Year.ToString() + prefixHocViecNo + "/";
            //            no = objEmployeesInfo.HREmployeeNo + prefixNo + countHV;
            //        }
            //        item.HREmployeeContractNo = no;
            //    }
            //    countHV++;
            //}

            //End
            //------------------------------------------------------------------------------------------------------


            int countTransfer = 0;
            foreach (var item in HREmployeeTranferList)
            {
                if (string.IsNullOrEmpty(item.HREmployeeTranferNo))
                {
                    string no = string.Empty;
                    if (countTransfer == 0)
                    {
                        no = objEmployeesInfo.HREmployeeNo + "/PLHĐ–LV";
                    }
                    else
                    {
                        no = objEmployeesInfo.HREmployeeNo + "/PLHĐ–LV/" + countTransfer;
                    }
                    item.HREmployeeTranferNo = no;
                }
                countTransfer++;
            }
            //TNDLoc [ADD][28/12/2015][Generate Transfer No (MSNV/PLHĐ – LV)],END

            HREmployeeContractsController objEmployeeContractsController = new HREmployeeContractsController();
            HREmployeeContractList.SaveItemObjects();

            HREmployeeContractList.ForEach(o =>
            {
                if (o.HREmployeeContractType == EmployeeContractType.HocViec.ToString() && objEmployeesInfo.HREmployeeDob.AddYears(18) >= DateTime.Now)
                {
                    objEmployeeContractsController.DeleteObject(o.HREmployeeContractID);
                }
            });
            HREmployeeContractList.Invalidate(objEmployeesInfo.HREmployeeID);

            HREmployeeTranferList.SaveItemObjects();
            HREmployeeContactList.SaveItemObjects();
            HREmployeeCertificateList.SaveItemObjects();
            HREmployeeContactPersonList.SaveItemObjects();
            HRQuarterRewardList.SaveItemObjects();
            if (HREmployeeContractList.CurrentIndex > -1)
            {
                InvalidateModuleObject(HREmployeeContractList[HREmployeeContractList.CurrentIndex]);
            }
        }

        public override void AfterSaveTransaction()
        {
            base.AfterSaveTransaction();
            BOSApp.InitAccountingObjects();
        }
        #endregion

        public void SaveTemplate(HREmployeeTemplatesInfo objEmployeeTemplatesInfo)
        {
            HREmployeesInfo objSupplierProposalsInfo = (HREmployeesInfo)MainObject;
            HREmployeeTemplatesController objEmployeeTemplatesController = new HREmployeeTemplatesController();
            if (objEmployeeTemplatesInfo.HREmployeeTemplateID == 0)
            {
                objEmployeeTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
                objEmployeeTemplatesInfo.AACreatedDate = DateTime.Now;
                objEmployeeTemplatesInfo.FK_HREmployeeID = objSupplierProposalsInfo.HREmployeeID;
                objEmployeeTemplatesController.CreateObject(objEmployeeTemplatesInfo);
            }
            else
            {
                objEmployeeTemplatesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objEmployeeTemplatesInfo.AAUpdatedDate = DateTime.Now;
                objEmployeeTemplatesController.UpdateObject(objEmployeeTemplatesInfo);
            }
        }

        public string GetNoSellStaff(string type)
        {
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)MainObject;
            string contractNo = string.Empty;
            string prefixNo = "/HĐLĐ–LV";
            string prefixHocViecNo = "/HĐĐTN-LV";
            List<HREmployeeContractsInfo> listHocViec = HREmployeeContractList.Where(x => x.HREmployeeContractType == EmployeeContractType.HocViec.ToString()).ToList();

            List<HREmployeeContractsInfo> listOtherContract = HREmployeeContractList.Where(x => x.HREmployeeContractType != EmployeeContractType.HocViec.ToString()).ToList();

            if (type != EmployeeContractType.HocViec.ToString())
            {
                //if (listOtherContract.Count > 0)
                //{
                //    contractNo = objEmployeesInfo.HREmployeeNo + prefixNo + (listOtherContract.Count + 1).ToString();
                //}
                //else
                //{
                contractNo = objEmployeesInfo.HREmployeeNo + prefixNo;
                //}
            }
            else
            {
                //if (listHocViec.Count > 0)
                //{
                //    prefixNo = "/" + DateTime.Now.Year.ToString() + prefixHocViecNo + "/";
                //    contractNo = objEmployeesInfo.HREmployeeNo + prefixNo + (listHocViec.Count + 1).ToString();
                //}
                //else
                //{
                prefixNo = "/" + DateTime.Now.Year.ToString() + prefixHocViecNo;
                contractNo = objEmployeesInfo.HREmployeeNo + prefixNo;
                //}
            }

            return contractNo;
        }
    }
}

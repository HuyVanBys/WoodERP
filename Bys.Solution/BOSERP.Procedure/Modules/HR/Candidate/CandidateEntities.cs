using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Candidate
{
    public class CandidateEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRCandidateTemplatesInfo> CandidateTemplateList { get; set; }
        public BOSList<HRCandidateCertificatesInfo> HRCandidateCertificateList { get; set; }
        public Dictionary<int, string> CandidateTemplateURLDic { get; set; }
        #endregion

        #region Constructor
        public CandidateEntities()
            : base()
        {
            CandidateTemplateList = new BOSList<HRCandidateTemplatesInfo>();
            HRCandidateCertificateList = new BOSList<HRCandidateCertificatesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRCandidatesInfo();
            SearchObject = new HRCandidatesInfo();
            //HRCalendarEntryList = new BOSList<HRCalendarEntrysInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRCandidateTemplatesTableName, new HRCandidateTemplatesInfo());
            ModuleObjects.Add(TableName.HRCadidateCertificatesTableName, new HRCandidateCertificatesInfo());
        }

        public override void InitModuleObjectList()
        {
            CandidateTemplateList.InitBOSList(
                                            this,
                                            TableName.HRCandidatesTableName,
                                            TableName.HRCandidateTemplatesTableName,
                                            BOSList<HRCandidateTemplatesInfo>.cstRelationForeign);
            CandidateTemplateList.ItemTableForeignKey = "FK_HRCandidateID";
            HRCandidateCertificateList.InitBOSList(this,
                                    TableName.HRCandidatesTableName,
                                    TableName.HRCadidateCertificatesTableName,
                                    BOSList<HRCandidateCertificatesInfo>.cstRelationForeign);
            HRCandidateCertificateList.ItemTableForeignKey = "FK_HRCandidateID";
        }

        public override void InitGridControlInBOSList()
        {
            CandidateTemplateList.InitBOSListGridControl();
            HRCandidateCertificateList.InitBOSListGridControl(CandidateModule.CandidateCertificatesGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            //HRCalendarsInfo objCalendarsInfo = (HRCalendarsInfo)MainObject;
            //objCalendarsInfo.HRCalendarType = CalendarType.Holiday.ToString();
            //objCalendarsInfo.HRCalendarYear = DateTime.Now.Year;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CandidateTemplateList.SetDefaultListAndRefreshGridControl();
                HRCandidateCertificateList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            CandidateTemplateList.Invalidate(iObjectID);
            HRCandidateCertificateList.Invalidate(iObjectID);

            foreach (HRCandidateTemplatesInfo objCandidateTemplatesInfo in CandidateTemplateList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objBaseTransactionModule.GetEmployeeByUsername(objCandidateTemplatesInfo.AACreatedUser);
                string SaleForecastID = objCandidateTemplatesInfo.FK_HRCandidateID.ToString();
                objCandidateTemplatesInfo.HRCandidateTemplateName = objCandidateTemplatesInfo.HRCandidateTemplateName.Replace(SaleForecastID + "_", "");
                objCandidateTemplatesInfo.UserCreatedFullname = objEmployeesInfo.HREmployeeName;
            }
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            //HRCalendarsInfo objCalendarsInfo = (HRCalendarsInfo)MainObject;
            //foreach (HRCalendarEntrysInfo objCalendarEntrysInfo in HRCalendarEntryList)
            //{
            //    objCalendarEntrysInfo.HRCalendarEntryDate = Convert.ToDateTime(String.Format("{0}/{1}/{2}", objCalendarsInfo.HRCalendarYear, objCalendarEntrysInfo.HRCalendarEntryDate.Month, objCalendarEntrysInfo.HRCalendarEntryDate.Day));
            //}
            CandidateTemplateList.SaveItemObjects();
            HRCandidateCertificateList.SaveItemObjects();
            CandidateTemplateURLDic = CandidateTemplateList.ToDictionary(o => o.HRCandidateTemplateID, o => o.FullPathFile);
        }
        #endregion

        public void SaveTemplate(HRCandidateTemplatesInfo objCandidateTemplatesInfo)
        {
            HRCandidatesInfo objCandiatesInfo = (HRCandidatesInfo)MainObject;
            HRCandidateTemplatesController objCandidateTemplatesController = new HRCandidateTemplatesController();
            if (objCandidateTemplatesInfo.HRCandidateTemplateID == 0)
            {
                objCandidateTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
                objCandidateTemplatesInfo.AACreatedDate = DateTime.Now;
                objCandidateTemplatesInfo.FK_HRCandidateID = objCandiatesInfo.HRCandidateID;
                objCandidateTemplatesController.CreateObject(objCandidateTemplatesInfo);
            }
            else
            {
                objCandidateTemplatesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objCandidateTemplatesInfo.AAUpdatedDate = DateTime.Now;
                objCandidateTemplatesController.UpdateObject(objCandidateTemplatesInfo);
            }
        }
    }
}

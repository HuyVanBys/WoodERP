using BOSCommon;
using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BOSERP.Modules.ConfigSalesTarget
{
    public class ConfigSalesTargetEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<HRConfigSalesTargetItemsInfo> ConfigSalesTargetItemList { get; set; }

        #endregion

        #region Constructor
        public ConfigSalesTargetEntities()
            : base()
        {
            ConfigSalesTargetItemList = new BOSList<HRConfigSalesTargetItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRConfigSalesTargetsInfo();
            SearchObject = new HRConfigSalesTargetsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRConfigSalesTargetItemsTableName, new HRConfigSalesTargetItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ConfigSalesTargetItemList.InitBOSList(this,
                                            TableName.HRConfigSalesTargetsTableName,
                                            TableName.HRConfigSalesTargetItemsTableName,
                                            BOSList<ARCanceledDeliveryPlanItemsInfo>.cstRelationForeign);
            ConfigSalesTargetItemList.ItemTableForeignKey = "FK_HRConfigSalesTargetID";
        }

        public override void InitGridControlInBOSList()
        {
            ConfigSalesTargetItemList.InitBOSListGridControl(ConfigSalesTargetModule.HRConfigSalesTargetItemsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ConfigSalesTargetItemList.SetDefaultListAndRefreshGridControl();
                ConfigSalesTargetItemList.GridControl.InitializeControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)MainObject;
            mainObject.HRConfigSalesTargetDate = BOSApp.GetCurrentServerDate();
            mainObject.HRConfigSalesTargetApplyFromDate = BOSApp.GetCurrentServerDate();
            mainObject.HRConfigSalesTargetApplyToDate = BOSApp.GetCurrentServerDate();
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ConfigSalesTargetItemList.Invalidate(iObjectID);

            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)MainObject;
            if (mainObject.HRConfigSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Company.ToString())
            {
                CSCompanysController objCompanysController = new CSCompanysController();
                List<CSCompanysInfo> companys = (List<CSCompanysInfo>)objCompanysController.GetListFromDataSet(objCompanysController.GetAllObjects());
                ConfigSalesTargetItemList.ForEach(o =>
                    {
                        CSCompanysInfo objCompanysInfo = companys.FirstOrDefault(x => x.CSCompanyID == o.FK_HRObjectID);
                        if (objCompanysInfo != null)
                            o.HRObjectName = objCompanysInfo.CSCompanyDesc;
                    });
            }
            else if (mainObject.HRConfigSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString())
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchs = objBranchsController.GetAllBranches();
                ConfigSalesTargetItemList.ForEach(o =>
                    {
                        BRBranchsInfo objBranchsInfo = branchs.FirstOrDefault(x => x.BRBranchID == o.FK_HRObjectID);
                        o.HRObjectName = objBranchsInfo.BRBranchName;
                    });
            }
            else if (mainObject.HRConfigSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                List<HREmployeesInfo> employees = (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController.GetEmployeeListByBranchID(mainObject.FK_BRBranchID));
                ConfigSalesTargetItemList.ForEach(o =>
                {
                    HREmployeesInfo objEmployeesInfo = employees.FirstOrDefault(x => x.HREmployeeID == o.FK_HRObjectID);
                    if (objEmployeesInfo != null)
                        o.HRObjectName = objEmployeesInfo.HREmployeeName;
                });
            }
        }

        public override void SaveModuleObjects()
        {
            ConfigSalesTargetItemList.SaveItemObjects();
        }

        public override bool CompleteTransaction()
        {
            return base.CompleteTransaction();
        }

        public void GenarateConfigSalesTargetItems(string configSalesTargetType, string configSalesTargetApplicableSubjects, DateTime configSalesTargetApplyFromDate, DateTime configSalesTargetApplyToDate)
        {
            ConfigSalesTargetItemList.Clear();
            HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)MainObject;
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;
            switch ((ConfigSalesTargetType)Enum.Parse(typeof(ConfigSalesTargetType), configSalesTargetType))
            {
                case ConfigSalesTargetType.Week:
                    if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Company.ToString())
                    {
                        CSCompanysController objCompanysController = new CSCompanysController();
                        List<CSCompanysInfo> companys = (List<CSCompanysInfo>)objCompanysController.GetListFromDataSet(objCompanysController.GetAllObjects());
                        if (companys.Count <= 0)
                            return;

                        companys.ForEach(o =>
                            {
                                int index = 0;
                                DateTime fromDate = configSalesTargetApplyFromDate.Date;
                                DateTime toDay = configSalesTargetApplyToDate.Date;
                                while (fromDate < toDay)
                                {
                                    index = cal.GetWeekOfYear(fromDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                                    ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.CSCompanyID
                                                                                                , configSalesTargetApplicableSubjects
                                                                                                , index
                                                                                                , configSalesTargetType
                                                                                                , o.CSCompanyDesc
                                                                                                , string.Empty));
                                    fromDate = fromDate.AddDays(7);
                                };
                            });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString())
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        List<BRBranchsInfo> branchs = (List<BRBranchsInfo>)objBranchsController.GetListFromDataSet(objBranchsController.GetAllObjects());
                        if (branchs.Count <= 0)
                            return;

                        branchs.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = cal.GetWeekOfYear(fromDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.BRBranchID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.BRBranchName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddDays(7);
                            };
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        List<HREmployeesInfo> employees = (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController.GetEmployeeListByBranchID(mainObject.FK_BRBranchID));
                        if (employees.Count <= 0)
                            return;

                        employees.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = cal.GetWeekOfYear(fromDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.HREmployeeID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.HREmployeeName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddDays(7);
                            };
                        });

                    }
                    break;

                case ConfigSalesTargetType.Month:
                    if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Company.ToString())
                    {
                        CSCompanysController objCompanysController = new CSCompanysController();
                        List<CSCompanysInfo> companys = (List<CSCompanysInfo>)objCompanysController.GetListFromDataSet(objCompanysController.GetAllObjects());
                        if (companys.Count <= 0)
                            return;

                        companys.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = fromDate.Date.Month;
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.CSCompanyID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.CSCompanyDesc
                                                                                            , string.Empty));
                                fromDate = fromDate.AddMonths(1);
                            };
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString())
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        List<BRBranchsInfo> branchs = (List<BRBranchsInfo>)objBranchsController.GetListFromDataSet(objBranchsController.GetAllObjects());
                        if (branchs.Count <= 0)
                            return;

                        branchs.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                //index = cal.GetWeekOfYear(fromDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                                index = fromDate.Date.Month;
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.BRBranchID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.BRBranchName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddMonths(1);
                            };
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        List<HREmployeesInfo> employees = (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController.GetEmployeeListByBranchID(mainObject.FK_BRBranchID));
                        employees.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = fromDate.Date.Month;
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.HREmployeeID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.HREmployeeName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddMonths(1);
                            };
                        });

                    }
                    break;

                case ConfigSalesTargetType.Quarterly:
                    if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Company.ToString())
                    {
                        CSCompanysController objCompanysController = new CSCompanysController();
                        List<CSCompanysInfo> companys = (List<CSCompanysInfo>)objCompanysController.GetListFromDataSet(objCompanysController.GetAllObjects());
                        if (companys.Count <= 0)
                            return;

                        companys.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = GetQuarter(fromDate);
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.CSCompanyID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.CSCompanyDesc
                                                                                            , string.Empty));
                                fromDate = fromDate.AddMonths(3);
                            };
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString())
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        List<BRBranchsInfo> branchs = (List<BRBranchsInfo>)objBranchsController.GetListFromDataSet(objBranchsController.GetAllObjects());
                        if (branchs.Count <= 0)
                            return;

                        branchs.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                //index = cal.GetWeekOfYear(fromDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                                index = GetQuarter(fromDate);
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.BRBranchID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.BRBranchName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddMonths(3);
                            };
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        List<HREmployeesInfo> employees = (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController.GetEmployeeListByBranchID(mainObject.FK_BRBranchID));
                        employees.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = GetQuarter(fromDate);
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.HREmployeeID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.HREmployeeName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddMonths(3);
                            };
                        });

                    }
                    break;

                case ConfigSalesTargetType.Year:
                    if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Company.ToString())
                    {
                        CSCompanysController objCompanysController = new CSCompanysController();
                        List<CSCompanysInfo> companys = (List<CSCompanysInfo>)objCompanysController.GetListFromDataSet(objCompanysController.GetAllObjects());
                        if (companys.Count <= 0)
                            return;

                        companys.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = fromDate.Date.Year;
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.CSCompanyID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.CSCompanyDesc
                                                                                            , string.Empty));
                                fromDate = fromDate.AddYears(1);
                            };
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString())
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        List<BRBranchsInfo> branchs = (List<BRBranchsInfo>)objBranchsController.GetListFromDataSet(objBranchsController.GetAllObjects());
                        if (branchs.Count <= 0)
                            return;

                        branchs.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                //index = cal.GetWeekOfYear(fromDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                                index = fromDate.Date.Year;
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.BRBranchID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.BRBranchName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddYears(1);
                            };
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        List<HREmployeesInfo> employees = (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController.GetEmployeeListByBranchID(mainObject.FK_BRBranchID));
                        employees.ForEach(o =>
                        {
                            int index = 0;
                            DateTime fromDate = configSalesTargetApplyFromDate.Date;
                            DateTime toDay = configSalesTargetApplyToDate.Date;
                            while (fromDate < toDay)
                            {
                                index = fromDate.Date.Year;
                                ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.HREmployeeID
                                                                                            , configSalesTargetApplicableSubjects
                                                                                            , index
                                                                                            , configSalesTargetType
                                                                                            , o.HREmployeeName
                                                                                            , string.Empty));
                                fromDate = fromDate.AddYears(1);
                            };
                        });

                    }
                    break;
                case ConfigSalesTargetType.FromDateToDate:
                    if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Company.ToString())
                    {
                        CSCompanysController objCompanysController = new CSCompanysController();
                        List<CSCompanysInfo> companys = (List<CSCompanysInfo>)objCompanysController.GetListFromDataSet(objCompanysController.GetAllObjects());
                        if (companys.Count <= 0)
                            return;

                        companys.ForEach(o =>
                        {
                            int index = 0;
                            ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.CSCompanyID
                                                                                        , configSalesTargetApplicableSubjects
                                                                                        , index
                                                                                        , configSalesTargetType
                                                                                        , o.CSCompanyDesc
                                                                                        , string.Format(ConfigSalesTargetLocalizedResources.FomatConfigSalesTargetItemNameForFromDateToDate, configSalesTargetApplyFromDate.ToString("dd/MM/yyyy"), configSalesTargetApplyToDate.Date.ToString("dd/MM/yyyy"))));
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Branch.ToString())
                    {
                        BRBranchsController objBranchsController = new BRBranchsController();
                        List<BRBranchsInfo> branchs = (List<BRBranchsInfo>)objBranchsController.GetListFromDataSet(objBranchsController.GetAllObjects());
                        if (branchs.Count <= 0)
                            return;

                        branchs.ForEach(o =>
                        {
                            int index = 0;
                            ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.BRBranchID
                                                                                    , configSalesTargetApplicableSubjects
                                                                                    , index
                                                                                    , configSalesTargetType
                                                                                    , o.BRBranchName
                                                                                    , string.Format(ConfigSalesTargetLocalizedResources.FomatConfigSalesTargetItemNameForFromDateToDate, configSalesTargetApplyFromDate.ToString("dd/MM/yyyy"), configSalesTargetApplyToDate.Date.ToString("dd/MM/yyyy"))));
                        });
                    }
                    else if (configSalesTargetApplicableSubjects == ConfigSalesTargetApplicableSubjects.Employee.ToString())
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        List<HREmployeesInfo> employees = (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController.GetEmployeeListByBranchID(mainObject.FK_BRBranchID));
                        employees.ForEach(o =>
                        {
                            int index = 0;
                            ConfigSalesTargetItemList.Add(ToConfigSalesTargetItemsInfo(o.HREmployeeID
                                                                                        , configSalesTargetApplicableSubjects
                                                                                        , index
                                                                                        , configSalesTargetType
                                                                                        , o.HREmployeeName
                                                                                        , string.Format(ConfigSalesTargetLocalizedResources.FomatConfigSalesTargetItemNameForFromDateToDate, configSalesTargetApplyFromDate.ToString("dd/MM/yyyy"), configSalesTargetApplyToDate.Date.ToString("dd/MM/yyyy"))));
                        });

                    }
                    break;
            }
            ConfigSalesTargetItemList.GridControl.InitializeControl();
        }
        public HRConfigSalesTargetItemsInfo ToConfigSalesTargetItemsInfo(int objectID, string objectType, int index, string configSalesTargetType, string objectName, string str)
        {
            HRConfigSalesTargetItemsInfo objConfigSalesTargetItemsInfo = new HRConfigSalesTargetItemsInfo();
            objConfigSalesTargetItemsInfo.FK_HRObjectID = objectID;
            objConfigSalesTargetItemsInfo.HRObjectType = objectType;
            objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemIndex = index;
            if (configSalesTargetType == ConfigSalesTargetType.Week.ToString())
                objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemName = string.Format("{0}{1}", ConfigSalesTargetLocalizedResources.Week, index);
            else if (configSalesTargetType == ConfigSalesTargetType.Month.ToString())
                objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemName = string.Format("{0}{1}", ConfigSalesTargetLocalizedResources.Month, index);
            else if (configSalesTargetType == ConfigSalesTargetType.Quarterly.ToString())
                objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemName = string.Format("{0}{1}", ConfigSalesTargetLocalizedResources.Quarterly, index);
            else if (configSalesTargetType == ConfigSalesTargetType.Year.ToString())
                objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemName = string.Format("{0}{1}", ConfigSalesTargetLocalizedResources.Year, index);
            else if (configSalesTargetType == ConfigSalesTargetType.FromDateToDate.ToString())
            {
                objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemName = string.IsNullOrEmpty(str) ? string.Empty : str;
            }
            objConfigSalesTargetItemsInfo.HRObjectName = objectName;
            objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemValue = 0;

            return objConfigSalesTargetItemsInfo;
        }

        private int GetQuarter(DateTime date)
        {
            if (date.Month >= 4 && date.Month <= 6)
                return 2;
            else if (date.Month >= 7 && date.Month <= 9)
                return 3;
            else if (date.Month >= 10 && date.Month <= 12)
                return 4;
            else
                return 1;
        }

        public bool Approve()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                HRConfigSalesTargetsInfo mainObject = (HRConfigSalesTargetsInfo)MainObject;
                mainObject.HRConfigSalesTargetStatus = TemplateStatus.Approved.ToString();
                mainObject.FK_HREmployeeApprovedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                UpdateMainObject();

                SetPropertyChangeEventLock(true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.KPIEvaluation
{
    public class KPIEvaluationEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSItemsEntityList<HRKPIEvaluationItemsInfo> KPIEvaluationItemsList { get; set; }
        public BOSItemsEntityList<HREmployeeKPIEvaluationItemsInfo> EmployeeKPIEvaluationItemsList { get; set; }
        public BOSItemsEntityList<HRKPIEvaluationItemTargetsInfo> KPIEvaluationItemTargetsList { get; set; }
        #endregion

        #region Constructor
        public KPIEvaluationEntities()
            : base()
        {
            KPIEvaluationItemsList = new BOSItemsEntityList<HRKPIEvaluationItemsInfo>();
            EmployeeKPIEvaluationItemsList = new BOSItemsEntityList<HREmployeeKPIEvaluationItemsInfo>();
            KPIEvaluationItemTargetsList = new BOSItemsEntityList<HRKPIEvaluationItemTargetsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new HRKPIEvaluationsInfo();
            MainObject = new HRKPIEvaluationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRKPIEvaluationItemsTableName, new HRKPIEvaluationItemsInfo());
            ModuleObjects.Add(TableName.HREmployeeKPIEvaluationItemsTableName, new HREmployeeKPIEvaluationItemsInfo());
            ModuleObjects.Add(TableName.HRKPIEvaluationItemTargetsTableName, new HRKPIEvaluationItemTargetsInfo());
        }

        public override void InitModuleObjectList()
        {
            KPIEvaluationItemsList.InitBOSList(this,
                                            TableName.HRKPIEvaluationsTableName,
                                            TableName.HRKPIEvaluationItemsTableName,
                                            BOSList<HRKPIEvaluationItemsInfo>.cstRelationForeign);
            EmployeeKPIEvaluationItemsList.InitBOSList(this,
                                            TableName.HRKPIEvaluationsTableName,
                                            TableName.HREmployeeKPIEvaluationItemsTableName,
                                            BOSList<HREmployeeKPIEvaluationItemsInfo>.cstRelationForeign);
            KPIEvaluationItemTargetsList.InitBOSList(this,
                                            TableName.HRKPIEvaluationsTableName,
                                            TableName.HRKPIEvaluationItemTargetsTableName,
                                            BOSList<HRKPIEvaluationItemTargetsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            KPIEvaluationItemsList.InitBOSListGridControl();
            EmployeeKPIEvaluationItemsList.InitBOSListGridControl();
            KPIEvaluationItemTargetsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                KPIEvaluationItemsList.SetDefaultListAndRefreshGridControl();
                EmployeeKPIEvaluationItemsList.SetDefaultListAndRefreshGridControl();
                KPIEvaluationItemTargetsList.SetDefaultListAndRefreshGridControl();
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

            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)MainObject;
            objKPIEvaluationsInfo.HRKPIEvaluationDate = BOSApp.GetCurrentServerDate();
            objKPIEvaluationsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objKPIEvaluationsInfo.HRKPIEvaluationStatus = KPIEvaluationStatus.New.ToString();

            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            //KPIEvaluationItemsList.Invalidate(iObjectID);
            HRKPIEvaluationItemsController objKPIEvaluationItemsController = new HRKPIEvaluationItemsController();

            List<HRKPIEvaluationItemsInfo> kPIEvaluationItemsList = new List<HRKPIEvaluationItemsInfo>();

            EmployeeKPIEvaluationItemsList.Invalidate(iObjectID);
            EmployeeKPIEvaluationItemsList.ForEach(o =>
            {
                if (o.HRKPIEvaluationItemsList == null)
                {
                    o.HRKPIEvaluationItemsList = new BOSList<HRKPIEvaluationItemsInfo>();
                    o.HRKPIEvaluationItemsList.InitBOSList(this,
                                        TableName.HRKPIEvaluationsTableName,
                                        TableName.HRKPIEvaluationItemsTableName,
                                        BOSList<HRKPIEvaluationItemsInfo>.cstRelationForeign);
                }
                kPIEvaluationItemsList = (List<HRKPIEvaluationItemsInfo>)objKPIEvaluationItemsController.GetKPIEvaluationItemsByEmployeeID(o.HREmployeeKPIEvaluationItemID);
                o.HRKPIEvaluationItemsList.Invalidate(kPIEvaluationItemsList);
            });
            KPIEvaluationItemsList.Invalidate(iObjectID);
            KPIEvaluationItemTargetsList.Invalidate(iObjectID);
        }

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            //KPIEvaluationItemsList.SaveItemObjects();
            EmployeeKPIEvaluationItemsList.SaveItemObjects();
            EmployeeKPIEvaluationItemsList.ForEach(o =>
            {
                foreach (HRKPIEvaluationItemsInfo objKPIEvaluationItemsInfo in o.HRKPIEvaluationItemsList)
                {
                    objKPIEvaluationItemsInfo.FK_HREmployeeKPIEvaluationItemID = o.HREmployeeKPIEvaluationItemID;
                }
                o.HRKPIEvaluationItemsList.SaveItemObjects();
            });
            KPIEvaluationItemTargetsList.SaveItemObjects();
        }
        #endregion 

        public void InvalidateKPIEvaluationItem(HREmployeeKPIEvaluationItemsInfo objEmployeeKPIEvaluationItemsInfo, List<HRKPIEvaluationItemsInfo> kPIEvaluationItemList)
        {
            objEmployeeKPIEvaluationItemsInfo.HRKPIEvaluationItemsList.Invalidate(kPIEvaluationItemList);
        }

        public void GenerateEntityFromKPIRegistration(HRKPIRegistrationsInfo objKPIRegistrationsInfo)
        {
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)MainObject;

            HRKPIRegistrationItemsController objKPIRegistrationItemsController = new HRKPIRegistrationItemsController();
            List<HRKPIRegistrationItemsInfo> kPIRegistrationItems = objKPIRegistrationItemsController.GetKPIRegistrationItemsByKPIRegistrationID(objKPIRegistrationsInfo.HRKPIRegistrationID);
            HREmployeeKPIRegistrationItemsController objEmployeeKPIRegistrationItemsController = new HREmployeeKPIRegistrationItemsController();
            List<HREmployeeKPIRegistrationItemsInfo> list = (List<HREmployeeKPIRegistrationItemsInfo>)objEmployeeKPIRegistrationItemsController.GetEmployeeKPIRegistrationItemsByKPIRegistrationID(objKPIRegistrationsInfo.HRKPIRegistrationID);

            List<HRKPIRegistrationItemsInfo> kPIRegistrationItemsByEmployee = new List<HRKPIRegistrationItemsInfo>();
            foreach (HREmployeeKPIRegistrationItemsInfo item in list)
            {
                if (kPIRegistrationItems.Count() > 0)
                {
                    kPIRegistrationItemsByEmployee = kPIRegistrationItems.Where(o => o.FK_HREmployeeKPIRegistrationItemID == item.HREmployeeKPIRegistrationItemID).ToList();
                }
                HREmployeeKPIEvaluationItemsInfo objEmployeeKPIEvaluationItemsInfo = ToEmployeeKPIEvaluationItems(item, kPIRegistrationItemsByEmployee);
                EmployeeKPIEvaluationItemsList.Add(objEmployeeKPIEvaluationItemsInfo);
            }

            EmployeeKPIEvaluationItemsList.GridControl.RefreshDataSource();
            HREmployeeKPIEvaluationItemsInfo employee = ModuleObjects[TableName.HREmployeeKPIEvaluationItemsTableName] as HREmployeeKPIEvaluationItemsInfo;
            if (employee != null)
            {
                UpdateAmountKPIResult(EmployeeKPIEvaluationItemsList);
                KPIEvaluationItemsList.Invalidate(employee.HRKPIEvaluationItemsList);
            }
            KPIEvaluationItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmountKPI();
        }

        public HREmployeeKPIEvaluationItemsInfo ToEmployeeKPIEvaluationItems(HREmployeeKPIRegistrationItemsInfo item, List<HRKPIRegistrationItemsInfo> kPIRegistrationItems)
        {
            HREmployeeKPIEvaluationItemsInfo objEmployeeKPIEvaluationItemsInfo = new HREmployeeKPIEvaluationItemsInfo();
            objEmployeeKPIEvaluationItemsInfo.FK_HRDepartmentID = item.FK_HRDepartmentID;
            objEmployeeKPIEvaluationItemsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
            objEmployeeKPIEvaluationItemsInfo.FK_HREmployeeID = item.FK_HREmployeeID;
            objEmployeeKPIEvaluationItemsInfo.FK_HRKPIRegistrationID = item.FK_HRKPIRegistrationID;
            objEmployeeKPIEvaluationItemsInfo.FK_HREmployeeKPIRegistrationItemID = item.HREmployeeKPIRegistrationItemID;
            objEmployeeKPIEvaluationItemsInfo.HREmployeeKPIEvaluationItemName = item.HREmployeeKPIRegistrationItemName;
            objEmployeeKPIEvaluationItemsInfo.HREmployeeKPIEvaluationItemNo = item.HREmployeeKPIRegistrationItemNo;
            objEmployeeKPIEvaluationItemsInfo.IsExcessReward = item.IsExcessReward;
            objEmployeeKPIEvaluationItemsInfo.HREmployeeKPIEvaluationItemTotalAmountBonus = item.HREmployeeKPIRegistrationItemTotalAmountBonus;

            objEmployeeKPIEvaluationItemsInfo.HRKPIEvaluationItemsList = new BOSList<HRKPIEvaluationItemsInfo>();
            objEmployeeKPIEvaluationItemsInfo.HRKPIEvaluationItemsList.InitBOSList(this,
                        TableName.HRKPIEvaluationsTableName,
                        TableName.HRKPIEvaluationItemsTableName,
                        BOSList<HRKPIEvaluationItemsInfo>.cstRelationForeign);

            foreach (HRKPIRegistrationItemsInfo itemlist in kPIRegistrationItems)
            {
                HRKPIEvaluationItemsInfo objKPIEvaluationItemsInfo = ToKPIEvaluationItems(itemlist);
                objEmployeeKPIEvaluationItemsInfo.HRKPIEvaluationItemsList.Add(objKPIEvaluationItemsInfo);
            }

            return objEmployeeKPIEvaluationItemsInfo;

        }

        public HRKPIEvaluationItemsInfo ToKPIEvaluationItems(HRKPIRegistrationItemsInfo o)
        {
            HRKPIEvaluationItemsInfo objKPIEvaluationItemsInfo = new HRKPIEvaluationItemsInfo();
            objKPIEvaluationItemsInfo.HRKPIEvaluationItemName = o.HRKPIRegistrationItemName;
            objKPIEvaluationItemsInfo.HRKPIEvaluationItemWeight = o.HRKPIRegistrationItemWeight;
            objKPIEvaluationItemsInfo.HRKPIEvaluationItemWeightBouns = o.HRKPIRegistrationItemWeightBouns;
            objKPIEvaluationItemsInfo.HRKPIEvaluationItemMeasurementMethod = o.HRKPIRegistrationItemMeasurementMethod;
            objKPIEvaluationItemsInfo.FK_HRKPIRegistrationID = o.FK_HRKPIRegistrationID;
            objKPIEvaluationItemsInfo.FK_HRKPIRegistrationItemID = o.HRKPIRegistrationItemID;
            objKPIEvaluationItemsInfo.FK_HRKPIID = o.FK_HRKPIID;
            objKPIEvaluationItemsInfo.FK_HRKPIFormID = o.FK_HRKPIFormID;
            objKPIEvaluationItemsInfo.FK_HRKPIFormItemID = o.FK_HRKPIFormItemID;
            objKPIEvaluationItemsInfo.HRKPIEvaluationItemTarget = o.HRKPIRegistrationItemTarget;
            objKPIEvaluationItemsInfo.IsReverseTarget = o.IsReverseTarget;
            objKPIEvaluationItemsInfo.HRKPIEvaluationItemGuide = o.HRKPIRegistrationItemGuide;

            return objKPIEvaluationItemsInfo;
        }

        public void UpdateTotalAmountKPI()
        {
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)MainObject;
            objKPIEvaluationsInfo.HRKPIEvaluationTotalAmount = 0;
            HREmployeeKPIEvaluationItemsInfo employee = ModuleObjects[TableName.HREmployeeKPIEvaluationItemsTableName] as HREmployeeKPIEvaluationItemsInfo;
            if (employee != null && employee.HRKPIEvaluationItemsList != null)
            {
                foreach (HRKPIEvaluationItemsInfo item in employee.HRKPIEvaluationItemsList)
                {
                    employee.HREmployeeKPIEvaluationItemTotalAmount += item.HRKPIEvaluationItemAmount;
                }
            }
            EmployeeKPIEvaluationItemsList.GridControl.RefreshDataSource();
            UpdateMainObjectBindingSource();
        }

        public void UpdateAmountKPIResult(List<HREmployeeKPIEvaluationItemsInfo> employeeKPIEvaluationItemsList)
        {
            HRKPIEvaluationsInfo objKPIEvaluationsInfo = (HRKPIEvaluationsInfo)MainObject;
            HRKPIsController objKPIsController = new HRKPIsController();
            if (employeeKPIEvaluationItemsList != null && employeeKPIEvaluationItemsList.Count() > 0)
            {
                employeeKPIEvaluationItemsList.ForEach(o =>
                {
                    if (o.HRKPIEvaluationItemsList != null)
                    {
                        foreach (HRKPIEvaluationItemsInfo item in o.HRKPIEvaluationItemsList)
                        {
                            item.HRKPIEvaluationItemResult += (decimal)objKPIsController.GetKPIEvaluationResult(o.FK_HREmployeeID, item.FK_HRKPIID, objKPIEvaluationsInfo.HRKPIEvaluationStartDate, objKPIEvaluationsInfo.HRKPIEvaluationFinishedDate);
                        }
                    }
                });
            }
            EmployeeKPIEvaluationItemsList.GridControl.RefreshDataSource();
        }
    }
}

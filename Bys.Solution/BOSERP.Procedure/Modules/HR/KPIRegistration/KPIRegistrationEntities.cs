using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.KPIRegistration
{
    public class KPIRegistrationEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSItemsEntityList<HRKPIRegistrationItemsInfo> KPIRegistrationItemsList { get; set; }
        public BOSItemsEntityList<HREmployeeKPIRegistrationItemsInfo> EmployeeKPIRegistrationItemsList { get; set; }
        public BOSItemsEntityList<HRKPIRegistrationItemTargetsInfo> KPIRegistrationItemTargetsList { get; set; }
        #endregion

        #region Constructor
        public KPIRegistrationEntities()
            : base()
        {
            KPIRegistrationItemsList = new BOSItemsEntityList<HRKPIRegistrationItemsInfo>();
            EmployeeKPIRegistrationItemsList = new BOSItemsEntityList<HREmployeeKPIRegistrationItemsInfo>();
            KPIRegistrationItemTargetsList = new BOSItemsEntityList<HRKPIRegistrationItemTargetsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new HRKPIRegistrationsInfo();
            MainObject = new HRKPIRegistrationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRKPIRegistrationItemsTableName, new HRKPIRegistrationItemsInfo());
            ModuleObjects.Add(TableName.HREmployeeKPIRegistrationItemsTableName, new HREmployeeKPIRegistrationItemsInfo());
            ModuleObjects.Add(TableName.HRKPIRegistrationItemTargetsTableName, new HRKPIRegistrationItemTargetsInfo());
        }

        public override void InitModuleObjectList()
        {
            KPIRegistrationItemsList.InitBOSList(this,
                                            TableName.HRKPIRegistrationsTableName,
                                            TableName.HRKPIRegistrationItemsTableName,
                                            BOSList<HRKPIRegistrationItemsInfo>.cstRelationForeign);
            EmployeeKPIRegistrationItemsList.InitBOSList(this,
                                            TableName.HRKPIRegistrationsTableName,
                                            TableName.HREmployeeKPIRegistrationItemsTableName,
                                            BOSList<HREmployeeKPIRegistrationItemsInfo>.cstRelationForeign);
            KPIRegistrationItemTargetsList.InitBOSList(this,
                                            TableName.HRKPIRegistrationsTableName,
                                            TableName.HRKPIRegistrationItemTargetsTableName,
                                            BOSList<HRKPIRegistrationItemTargetsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            KPIRegistrationItemsList.InitBOSListGridControl();
            EmployeeKPIRegistrationItemsList.InitBOSListGridControl();
            KPIRegistrationItemTargetsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                KPIRegistrationItemsList.SetDefaultListAndRefreshGridControl();
                EmployeeKPIRegistrationItemsList.SetDefaultListAndRefreshGridControl();
                KPIRegistrationItemTargetsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRKPIRegistrationsInfo objKPIRegistsInfo = (HRKPIRegistrationsInfo)MainObject;
            objKPIRegistsInfo.HRKPIRegistrationDate = BOSApp.GetCurrentServerDate();
            objKPIRegistsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objKPIRegistsInfo.HRKPIRegistrationStatus = KPIRegistrationStatus.New.ToString();

            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRKPIRegistrationItemsController objKPIRegistrationItemsController = new HRKPIRegistrationItemsController();
            List<HRKPIRegistrationItemsInfo> kPIRegistrationItemsList = new List<HRKPIRegistrationItemsInfo>();

            EmployeeKPIRegistrationItemsList.Invalidate(iObjectID);
            EmployeeKPIRegistrationItemsList.ForEach(o =>
                {
                    if (o.HRKPIRegistrationItemsList == null)
                    {
                        o.HRKPIRegistrationItemsList = new BOSList<HRKPIRegistrationItemsInfo>();
                        o.HRKPIRegistrationItemsList.InitBOSList(this,
                                            TableName.HRKPIRegistrationsTableName,
                                            TableName.HRKPIRegistrationItemsTableName,
                                            BOSList<HRKPIRegistrationItemsInfo>.cstRelationForeign);
                    }
                    kPIRegistrationItemsList = (List<HRKPIRegistrationItemsInfo>)objKPIRegistrationItemsController.GetKPIRegistrationItemsByEmployeeID(o.HREmployeeKPIRegistrationItemID);
                    o.HRKPIRegistrationItemsList.Invalidate(kPIRegistrationItemsList);
                });
            KPIRegistrationItemsList.Invalidate(iObjectID);
            KPIRegistrationItemTargetsList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            EmployeeKPIRegistrationItemsList.SaveItemObjects();
            EmployeeKPIRegistrationItemsList.ForEach(o =>
                {
                    foreach (HRKPIRegistrationItemsInfo objKPIRegistrationItemsInfo in o.HRKPIRegistrationItemsList)
                    {
                        objKPIRegistrationItemsInfo.FK_HREmployeeKPIRegistrationItemID = o.HREmployeeKPIRegistrationItemID;
                    }
                    o.HRKPIRegistrationItemsList.SaveItemObjects();
                });
            KPIRegistrationItemTargetsList.SaveItemObjects();
        }
        #endregion 

        public void InvalidateKPIRegistrationItem(HREmployeeKPIRegistrationItemsInfo objEmployeeKPIRegistrationItemsInfo, List<HRKPIRegistrationItemsInfo> kPIRegistrationItemList)
        {
            List<HRKPIRegistrationItemsInfo> list = new List<HRKPIRegistrationItemsInfo>();
            kPIRegistrationItemList.ForEach(o =>
            {
                HRKPIRegistrationItemsInfo objKPIRegistrationItemsInfo = new HRKPIRegistrationItemsInfo();
                BOSUtil.CopyObject(o, objKPIRegistrationItemsInfo);
                objKPIRegistrationItemsInfo.FK_HREmployeeKPIRegistrationItemID = 0;
                list.Add(objKPIRegistrationItemsInfo);
            });
            objEmployeeKPIRegistrationItemsInfo.HRKPIRegistrationItemsList.Invalidate(list);
        }
    }
}

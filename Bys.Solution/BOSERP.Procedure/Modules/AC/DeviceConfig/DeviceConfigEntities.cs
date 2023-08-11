using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSCommon;
using BOSLib;

namespace BOSERP.Modules.DeviceConfig
{
    public class DeviceConfigEntities : ERPModuleEntities
    {
        #region Declare Constant
        
        #endregion
        
        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of asset receipt items
        /// </summary>
        public BOSList<ACDeviceItemsInfo> ACDeviceItemsList { get; set; }
        public BOSList<ACDeviceItemPlansInfo> ACDeviceItemPlansList { get; set; }
        
        #endregion

        #region Constructor
        public DeviceConfigEntities()
            : base()
        {
            ACDeviceItemsList = new BOSList<ACDeviceItemsInfo>();
            ACDeviceItemPlansList = new BOSList<ACDeviceItemPlansInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACDevicesInfo();
            SearchObject = new ACDevicesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACDeviceItemsTableName, new ACDeviceItemsInfo());
            ModuleObjects.Add(TableName.ACDeviceItemPlansTableName, new ACDeviceItemPlansInfo());
        }

        public override void InitModuleObjectList()
        {
            ACDeviceItemsList.InitBOSList(this,
                                            TableName.ACDevicesTableName,
                                            TableName.ACDeviceItemsTableName,
                                            BOSList<ACDeviceItemsInfo>.cstRelationForeign);
            ACDeviceItemsList.ItemTableForeignKey = "FK_ACDeviceID";
            ACDeviceItemPlansList.InitBOSList(this,
                                           TableName.ACDevicesTableName,
                                           TableName.ACDeviceItemPlansTableName,
                                           BOSList<ACDeviceItemPlansInfo>.cstRelationForeign);
            ACDeviceItemPlansList.ItemTableForeignKey = "FK_ACDeviceID";
        }

        public override void InitGridControlInBOSList()
        {
            ACDeviceItemsList.InitBOSListGridControl("fld_dgcACDeviceItems");
            ACDeviceItemPlansList.InitBOSListGridControl("fld_dgcACDeviceItemPlans");
           
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACDevicesInfo mainObject = (ACDevicesInfo)MainObject;
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.ACDeviceDate = DateTime.Now;
            mainObject.ACDeviceEffectDate = DateTime.Now;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACDeviceItemsList.SetDefaultListAndRefreshGridControl();
                ACDeviceItemPlansList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACDeviceItemsList.Invalidate(iObjectID);
            foreach (ACDeviceItemsInfo item in ACDeviceItemsList)
            {
                if (item.ACDeviceItemMaintainEndDate.Date != DateTime.MaxValue.Date && item.ACDeviceItemMaintainEndDate.Date != DateTime.MinValue.Date)
                    item.ACDeviceItemPlanDate = item.ACDeviceItemMaintainEndDate.AddDays((double)item.ACDeviceItemGuaranteeNumber);
                else
                    item.ACDeviceItemPlanDate = item.ACDeviceEffectDate.AddDays((double)item.ACDeviceItemGuaranteeNumber);
            }
            ACDeviceItemsList.GridControl.RefreshDataSource();
            ACDeviceItemPlansList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ACDevicesInfo mainObject = (ACDevicesInfo)MainObject;

            ICProductsController pController = new ICProductsController();
            ICProductsInfo pInfo;
            ACDeviceItemsList.ForEach(item =>
            {
                if (item.FK_ICProductID == 0)
                {
                    pInfo = new ICProductsInfo();
                    pInfo.ICProductNo = item.ACDeviceItemNo;
                    pInfo.ICProductName = item.ACDeviceItemName;
                    pInfo.FK_ICProductBasicUnitID = item.FK_ICMeasureUnitID;
                    pInfo.FK_ICProductGroupID = item.FK_ICProductGroupID;
                    pInfo.FK_ICDepartmentID = item.FK_ICDepartmentID;
                    pInfo.ICProductType = item.ACProductType;
                    pController.CreateObject(pInfo);
                    BOSApp.CurrentProductList.Add(pInfo);
                    item.FK_ICProductID = pInfo.ICProductID;

                }

                item.FK_ICParentProductID = mainObject.FK_ICProductID;
                item.FK_HREmployeeID = mainObject.FK_HREmployeeID;
                item.ACDeviceNo = mainObject.ACDeviceNo;
                item.ACDeviceName = mainObject.ACDeviceName;
                item.ACDeviceIdentifierType = mainObject.ACDeviceIdentifierType;
                item.ACDeviceEffectDate = mainObject.ACDeviceEffectDate;
            });


            ACDeviceItemsList.SaveItemObjects();
            foreach (ACDeviceItemsInfo item in ACDeviceItemsList)
            {
                ACDeviceItemPlansInfo objDIPInfo = ACDeviceItemPlansList.Where(i => i.FK_ACDeviceTemPlateItemID == item.FK_ACDeviceTemPlateItemID).FirstOrDefault();
                if (objDIPInfo != null)
                    objDIPInfo.FK_ACDeviceItemID = item.ACDeviceItemID;
            }
            ACDeviceItemPlansList.SaveItemObjects();

        }

        
      
        #endregion        

       
    }
}

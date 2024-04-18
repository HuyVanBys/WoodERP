using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;

namespace BOSERP.Modules.RevenueForecast
{
    public class RevenueForecastEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ARRevenueForecastItemsInfo> RevenueForecastItemList { get; set; }
        #endregion

        #region Constructor
        public RevenueForecastEntities()
            : base()
        {
            RevenueForecastItemList = new BOSList<ARRevenueForecastItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARRevenueForecastsInfo();
            SearchObject = new ARRevenueForecastsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARRevenueForecastsTableName, new ARRevenueForecastsInfo());
            ModuleObjects.Add(TableName.ARRevenueForecastItemsTableName, new ARRevenueForecastItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            RevenueForecastItemList.InitBOSList(this,
                                                TableName.ARRevenueForecastsTableName,
                                                TableName.ARRevenueForecastItemsTableName,
                                                BOSList<ARRevenueForecastItemsInfo>.cstRelationForeign);
            RevenueForecastItemList.ItemTableForeignKey = "FK_ARRevenueForecastID";
        }

        public override void InitGridControlInBOSList()
        {
            RevenueForecastItemList.InitBOSListGridControl("fld_dgcARRevenueForecastItems");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ARRevenueForecastsInfo objRevenueForecastsInfo = (ARRevenueForecastsInfo)MainObject;
            objRevenueForecastsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objRevenueForecastsInfo.ARRevenueForecastStatus = SaleOrderStatus.New.ToString();
            objRevenueForecastsInfo.ARRevenueForecastYear = DateTime.Now.Year;
            objRevenueForecastsInfo.ARRevenueForecastDate = DateTime.Now;
            objRevenueForecastsInfo.ARRoundingNumber = "1";
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                RevenueForecastItemList.SetDefaultListAndRefreshGridControl();
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
            ARRevenueForecastItemsController objRevenueForecastItemsController = new ARRevenueForecastItemsController();
            DataSet ds = objRevenueForecastItemsController.GetRevenueForecastItemsByRevenueForecastID(iObjectID);
            RevenueForecastItemList.Invalidate(ds);
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            RevenueForecastItemList.SaveItemObjects();
        }
        public override bool CompleteTransaction()
        {
            ARRevenueForecastsInfo mainObject = (ARRevenueForecastsInfo)MainObject;
            //Update the this's status
            mainObject.ARRevenueForecastStatus = SaleOrderStatus.Confirmed.ToString();
            UpdateMainObject();
            return true;
        }
            #endregion
        }
}

using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.ProductConversion
{
    public class ProductConversionEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSItemsEntityList<ICProductConversionItemsInfo> ProductConversionItemsList { get; set; }

        public BOSItemsEntityList<ICProductConversionItemsInfo> ProductConversionItemTargetList { get; set; }

        public List<ICProductConversionItemsInfo> DelectedList { get; set; }

        public List<ICProductConversionItemsInfo> CurrentConversionItemList { get; set; }
        #endregion

        #region Constructor
        public ProductConversionEntities()
            : base()
        {
            ProductConversionItemsList = new BOSItemsEntityList<ICProductConversionItemsInfo>();
            ProductConversionItemTargetList = new BOSItemsEntityList<ICProductConversionItemsInfo>();
            DelectedList = new List<ICProductConversionItemsInfo>();
            CurrentConversionItemList = new List<ICProductConversionItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductConversionsInfo();
            SearchObject = new ICProductConversionsInfo();
        }

        public override void InitModuleObjectList()
        {
            ProductConversionItemsList.InitBOSList(this,
                                                   TableName.ICProductConversionsTableName,
                                                   TableName.ICProductConversionItemsTableName,
                                                   BOSItemsEntityList<ICProductConversionItemsInfo>.cstRelationForeign);
            ProductConversionItemsList.ItemTableForeignKey = "FK_ICProductConversionID";

            ProductConversionItemTargetList.InitBOSList(this,
                                                        TableName.ICProductConversionsTableName,
                                                        TableName.ICProductConversionItemsTableName,
                                                        BOSItemsEntityList<ICProductConversionItemsInfo>.cstRelationForeign);
            ProductConversionItemTargetList.ItemTableForeignKey = "FK_ICProductConversionID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ProductConversionItemsList.InitBOSListGridControl("fld_dgcICProductConversionItems");
            ProductConversionItemTargetList.InitBOSListGridControl("fld_dgcICProductConversionItemTargetsGridControl");
            DocumentEntryList.InitBOSListGridControl(ProductConversionModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductConversionItemsList.SetDefaultListAndRefreshGridControl();
                ProductConversionItemTargetList.SetDefaultListAndRefreshGridControl();
                CurrentConversionItemList.Clear();
                DelectedList.Clear();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICProductConversionsInfo mainobject = (ICProductConversionsInfo)MainObject;
            ICProductConversionItemsController objProductConversionItemsController = new ICProductConversionItemsController();
            CurrentConversionItemList = objProductConversionItemsController.GetProductConversionItemByProductConversionID(iObjectID);
            if (mainobject.ICProductConversionType == ProductConversionType.OnlyTarget.ToString())
                ProductConversionItemsList.Invalidate(CurrentConversionItemList.Where(o => o.ICProductConversionItemType == ProductConversionItemType.Target.ToString()).ToList());
            else
                ProductConversionItemsList.Invalidate(CurrentConversionItemList.Where(o => o.ICProductConversionItemType == ProductConversionItemType.Source.ToString()).ToList());
            DelectedList.Clear();
        }

        public override void SaveModuleObjects()
        {
            ICProductConversionsInfo mainobject = (ICProductConversionsInfo)MainObject;
            SaveItemWithDataTableType.SaveItemWithoutDelete<ICProductConversionItemsInfo>(CurrentConversionItemList
                        , "ICProductConversionItemID", "ICProductConversionItems", mainobject.ICProductConversionID, BOSApp.CurrentUsersInfo.ADUserName);

            if (DelectedList.Where(o => o.ICProductConversionItemID > 0).Any())
                SaveItemWithDataTableType.DeleteItem<ICProductConversionItemsInfo>(DelectedList.Where(o => o.ICProductConversionItemID > 0).ToList(), "ICProductConversionItems", BOSApp.CurrentUsersInfo.ADUserName);

            ICProductConversionItemsController objProductConversionItemsController = new ICProductConversionItemsController();
            objProductConversionItemsController.UpdateItemParent(mainobject.ICProductConversionID);
            CurrentConversionItemList = objProductConversionItemsController.GetProductConversionItemByProductConversionID(mainobject.ICProductConversionID);
            DelectedList.Clear();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICProductConversionsInfo mainobject = (ICProductConversionsInfo)MainObject;
            mainobject.ICProductConversionDate = BOSApp.GetCurrentServerDate();
            mainobject.ICProductConversionStatus = ProductConversionStatus.New.ToString();
            mainobject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainobject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            UpdateMainObjectBindingSource();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICProductConversionItemsTableName, new ICProductConversionItemsInfo());
        }

        public override bool CompleteTransaction()
        {
            ICProductConversionsInfo mainobject = (ICProductConversionsInfo)MainObject;
            //ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            //CurrentConversionItemList.Where(o=>o.ICProductConversionItemType == ProductConversionItemType.Target.ToString()).ForEach(o =>
            //{
            //    objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(o.FK_ICProductID, o.ICProductConversionItemProductSerialNo);
            //    if (objProductSeriesInfo == null)
            //    {
            //        objProductSeriesInfo = new ICProductSeriesInfo();
            //        objProductSeriesInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            //        objProductSeriesInfo.FK_ICProductID = o.FK_ICProductID;
            //        objProductSeriesInfo.ICProductSerieNo = o.ICProductConversionItemProductSerialNo;
            //        objProductSeriesInfo.ICProductSerieLotNo = o.ICProductConversionItemLotNo;
            //        objProductSeriesInfo.ICProductSerieReceiptDate = mainobject.ICProductConversionDate;
            //        objProductSeriesInfo.ICProductSerieProductLength = o.ICProductConversionItemProductLength;
            //        objProductSeriesInfo.ICProductSerieProductWidth = o.ICProductConversionItemProductWidth;
            //        objProductSeriesInfo.ICProductSerieProductHeight = o.ICProductConversionItemProductHeight;
            //        objProductSeriesInfo.ICProductSerieProductLengthMax = o.ICProductConversionItemLengthMax;
            //        objProductSeriesInfo.ICProductSerieProductWidthMax = o.ICProductConversionItemWidthMax;
            //        objProductSeriesInfo.ICProductSerieProductPerimeter = o.ICProductConversionItemPerimeter;
            //        objProductSeriesInfo.FK_ICProductAttributeQualityID = o.FK_ICProductAttributeQualityID;
            //        objProductSeriesController.CreateObject(objProductSeriesInfo);
            //    }
            //    o.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
            //});
            //SaveItemWithDataTableType.SaveItemWithoutDelete<ICProductConversionItemsInfo>(CurrentConversionItemList
            //            , "ICProductConversionItemID", "ICProductConversionItems", mainobject.ICProductConversionID, BOSApp.CurrentUsersInfo.ADUserName);
            bool isSuccess = base.CompleteTransaction();
            if (!isSuccess)
                return false;

            mainobject.ICProductConversionStatus = ProductConversionStatus.Complete.ToString();
            mainobject.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainobject.ICProductConversionCompletedDate = BOSApp.GetCurrentServerDate();
            UpdateMainObject();
            return isSuccess;
        }

        public override bool CancelCompleteTransaction()
        {
            ICProductConversionsInfo mainobject = (ICProductConversionsInfo)MainObject;
            bool isSuccess = base.CancelCompleteTransaction();
            if (!isSuccess)
                return false;

            mainobject.ICProductConversionStatus = ProductConversionStatus.New.ToString();
            UpdateMainObject();
            return isSuccess;
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                if (CurrentConversionItemList.Where(o => o.ICProductConversionItemID > 0).Any())
                    SaveItemWithDataTableType.DeleteItem<ICProductConversionItemsInfo>(CurrentConversionItemList.Where(o => o.ICProductConversionItemID > 0).ToList(), "ICProductConversionItems", BOSApp.CurrentUsersInfo.ADUserName);

                CurrentConversionItemList.Clear();
                DelectedList.Clear();
            }
        }
    }
}

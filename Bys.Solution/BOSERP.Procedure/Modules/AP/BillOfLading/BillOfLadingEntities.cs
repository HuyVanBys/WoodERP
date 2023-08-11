using BOSCommon;
using BOSLib;
using System;

namespace BOSERP.Modules.BillOfLading
{
    public class BillOfLadingEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        public BOSList<APBillOfLadingItemsInfo> BillOfLadingItemList { get; set; }
        #endregion

        #region Constructor
        public BillOfLadingEntities()
            : base()
        {
            BillOfLadingItemList = new BOSList<APBillOfLadingItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APBillOfLadingsInfo();
            SearchObject = new APBillOfLadingsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("APBillOfLadingItems", new APBillOfLadingItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            BillOfLadingItemList.InitBOSList(
                                    this,
                                    "APBillOfLadings",
                                    "APBillOfLadingItems",
                                    BOSList<APBillOfLadingItemsInfo>.cstRelationForeign);
            BillOfLadingItemList.ItemTableForeignKey = "FK_APBillOfLadingID";
        }

        public override void InitGridControlInBOSList()
        {
            BillOfLadingItemList.InitBOSListGridControl("fld_dgcAPBillOfLadingItems");
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            APBillOfLadingsInfo mainObject = (APBillOfLadingsInfo)MainObject;
            mainObject.APBillOfLadingDate = BOSApp.GetCurrentServerDate();
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BillOfLadingItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion
        public override bool SaveAccountingData()
        {
            APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objBillOfLadingsInfo, objDocumentsInfo);
            }
            return base.SaveAccountingData();
        }

        public override void SaveModuleObjects()
        {
            BillOfLadingItemList.SaveItemObjects();
            SaveAccountingData();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            BillOfLadingItemList.Invalidate(iObjectID);
        }

        public override bool CompleteTransaction()
        {
            APBillOfLadingsInfo objBillOfLadingsInfo = (APBillOfLadingsInfo)MainObject;
            objBillOfLadingsInfo.APBillOfLadingStatus = BillOfLadingStatus.Complete.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                BillOfLadingItemList.DeleteItemObjects();
            }
        }
    }
}

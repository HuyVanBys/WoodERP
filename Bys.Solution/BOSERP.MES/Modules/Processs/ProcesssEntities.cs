using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Processs
{
    class ProcesssEntities : BaseTransactionEntities
    {
        #region Public Properties

        ///// <summary>
        ///// Gets or sets the Process item list
        ///// </summary>
        public BOSList<ICProductAttributeItemsInfo> ProductAttributeItemList { get; set; }
        public BOSList<MMProcessProductsInfo> ProcessProductList { get; set; }

        #endregion

        #region Contructors
        public ProcesssEntities()
            : base()
        {
            ProductAttributeItemList = new BOSList<ICProductAttributeItemsInfo>();
            ProcessProductList = new BOSList<MMProcessProductsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMProcesssInfo();
            SearchObject = new MMProcesssInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMProcesssTableName, new MMProcesssInfo());
            ModuleObjects.Add(TableName.ICProductAttributeItemsTableName, new ICProductAttributeItemsInfo());
            ModuleObjects.Add(TableName.MMProcessProductsTableName, new MMProcessProductsInfo());
        }

        public override void InitModuleObjectList()
        {

            ProductAttributeItemList.InitBOSList(
                                        this,
                                        TableName.MMProcesssTableName,
                                        TableName.ICProductAttributeItemsTableName,
                                        BOSList<ICProductAttributeItemsInfo>.cstRelationForeign);
            ProductAttributeItemList.ItemTableForeignKey = "FK_MMProcessID";

            ProcessProductList.InitBOSList(
                                        this,
                                        TableName.MMProcesssTableName,
                                        TableName.MMProcessProductsTableName,
                                        BOSList<MMProcessProductsInfo>.cstRelationForeign);
            ProcessProductList.ItemTableForeignKey = "FK_MMProcessID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductAttributeItemList.InitBOSListGridControl("fld_dgcICProductAttributeItems");
            ProcessProductList.InitBOSListGridControl("fld_dgcMMProcessProducts");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)MainObject;
            objProcesssInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductAttributeItemList.SetDefaultListAndRefreshGridControl();
                ProcessProductList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)MainObject;
            ICProductAttributeItemsController objProductAttributeItemsController = new ICProductAttributeItemsController();
            List<ICProductAttributeItemsInfo> itemsList = objProductAttributeItemsController.GetMMOperationsByProcessID(iObjectID);
            ProductAttributeItemList.Invalidate(itemsList);
            ProcessProductList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)MainObject;
            ProductAttributeItemList.SaveItemObjects();
            ProcessProductList.SaveItemObjects();
        }
        public void SaveProcessProduct()
        {
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)MainObject;
            if (objProcesssInfo.MMProcessID == 0) return;
            ProcessProductList.ForEach(p => { if (p.FK_MMProcessID == 0) p.FK_MMProcessID = objProcesssInfo.MMProcessID; });
            ProcessProductList.SaveItemObjects();
        }
        public void ApproveProcess()
        {
            SetPropertyChangeEventLock(false);
            //Update the this's status
            MMProcesssInfo objProcesssInfo = (MMProcesssInfo)MainObject;
            objProcesssInfo.MMProcessStatus = BatchProductPlanStatus.Approved.ToString();
            UpdateMainObject();
        }

        #endregion Override BaseTransactionEntities
    }
}

using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;


namespace BOSERP.Modules.ContainerLoader
{
    public class ContainerLoaderEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSItemsEntityList<ARContainerLoaderItemsInfo> ContainerLoaderItemList { get; set; }

        #endregion

        #region Constructor
        public ContainerLoaderEntities()
            : base()
        {
            ContainerLoaderItemList = new BOSItemsEntityList<ARContainerLoaderItemsInfo>();

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARContainerLoadersInfo();
            SearchObject = new ARContainerLoadersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARContainerLoaderItemsTableName, new ARContainerLoaderItemsInfo());
            ModuleObjects.Add(TableName.ARContainerLoaderItemDetailsTableName, new ARContainerLoaderItemDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            ContainerLoaderItemList.InitBOSList(this,
                                                              TableName.ARContainerLoadersTableName,
                                                              TableName.ARContainerLoaderItemsTableName,
                                                              BOSItemsEntityList<ARContainerLoaderItemsInfo>.cstRelationForeign);
            ContainerLoaderItemList.ItemTableForeignKey = "FK_ARContainerLoaderID";


        }

        public override void InitGridControlInBOSList()
        {
            ContainerLoaderItemList.InitBOSListGridControl(ContainerLoaderModule.ReceiptItemGridControlName);

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ContainerLoaderItemList.SetDefaultListAndRefreshGridControl();

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

            ARContainerLoadersInfo ContainerLoadersInfo = (ARContainerLoadersInfo)MainObject;
            ContainerLoadersInfo.ARContainerLoaderDate = DateTime.Now;
            ContainerLoadersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARContainerLoadersInfo ContainerLoadersInfo = (ARContainerLoadersInfo)MainObject;

            ARContainerLoaderItemsController objContainerLoaderItemsController = new ARContainerLoaderItemsController();
            List<ARContainerLoaderItemsInfo> list = objContainerLoaderItemsController.GetListByContainerLoaderID(iObjectID);
            ContainerLoaderItemList.Invalidate(list);

            ContainerLoaderItemList.BackupList.Clear();
            if (ContainerLoadersInfo.ARContainerLoaderStatus == ContainerLoaderStatus.Complete.ToString())
            {
                foreach (ARContainerLoaderItemsInfo item in ContainerLoaderItemList)
                {
                    ContainerLoaderItemList.BackupList.Add((ARContainerLoaderItemsInfo)item.Clone());
                }
            }
        }
        #endregion

        #region Save Module Objects Functions        
        public override void SaveModuleObjects()
        {
            //Update status of stock receipt
            ARContainerLoadersInfo receipt = (ARContainerLoadersInfo)MainObject;
            //receipt.ARContainerLoaderstatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            ContainerLoaderItemList.SaveItemObjects();
        }


        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ARContainerLoaderItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ARContainerLoaderItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ARContainerLoadersInfo objARContainerLoadersInfo = (ARContainerLoadersInfo)MainObject;
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                ARContainerLoaderItemsInfo receiptItem = (ARContainerLoaderItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(productID, receiptItem);
                SetProductCost(receiptItem);
                // receiptItem.FK_ICStockID = objARContainerLoadersInfo.FK_ICStockID;
                receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
            }
        }
    }
}

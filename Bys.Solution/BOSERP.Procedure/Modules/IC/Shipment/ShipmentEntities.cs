using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Shipment
{
    public class ShipmentEntities : GLShipmentEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets shipment item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICShipmentItemsInfo> ComponentShipmentItemList { get; set; }
        public int CountItemsInShipmentPackageItemList = 0;
        public BOSList<ICShipmentPackageItemsInfo> ShipmentPackageItemList { get; set; }
        public BOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailShowList { get; set; }
        public BOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailList { get; set; }
        public BOSList<ICShipmentPackageItemDetailsInfo> DeleteShipmentPackageItemDetailList { get; set; }
        public BOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailReportList { get; set; }
        #endregion

        #region Constructor
        public ShipmentEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            ComponentShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            ShipmentPackageItemList = new BOSList<ICShipmentPackageItemsInfo>();
            ShipmentPackageItemDetailShowList = new BOSList<ICShipmentPackageItemDetailsInfo>();
            ShipmentPackageItemDetailList = new BOSList<ICShipmentPackageItemDetailsInfo>();
            DeleteShipmentPackageItemDetailList = new BOSList<ICShipmentPackageItemDetailsInfo>();
            ShipmentPackageItemDetailReportList = new BOSList<ICShipmentPackageItemDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICShipmentsInfo();
            SearchObject = new ICShipmentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICShipmentItemsTableName, new ICShipmentItemsInfo());
            ModuleObjects.Add(TableName.ICShipmentPackageItemsTableName, new ICShipmentPackageItemsInfo());
            ModuleObjects.Add(TableName.ICShipmentPackageItemDetailsTableName, new ICShipmentPackageItemDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            ShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ComponentShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ComponentShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ShipmentPackageItemList.InitBOSList(this,
                                               TableName.ICShipmentsTableName,
                                               TableName.ICShipmentPackageItemsTableName,
                                               BOSList<ICShipmentPackageItemsInfo>.cstRelationForeign);
            ShipmentPackageItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ShipmentPackageItemDetailShowList.InitBOSList(this,
                                               TableName.ICShipmentPackageItemsTableName,
                                               TableName.ICShipmentPackageItemDetailsTableName,
                                               BOSList<ICShipmentPackageItemDetailsInfo>.cstRelationForeign);
            ShipmentPackageItemDetailShowList.ItemTableForeignKey = "FK_ICShipmentPackageItemID";

            ShipmentPackageItemDetailList.InitBOSList(this,
                                               TableName.ICShipmentPackageItemsTableName,
                                               TableName.ICShipmentPackageItemDetailsTableName,
                                               BOSList<ICShipmentPackageItemDetailsInfo>.cstRelationForeign);
            ShipmentPackageItemDetailList.ItemTableForeignKey = "FK_ICShipmentPackageItemID";

            DeleteShipmentPackageItemDetailList.InitBOSList(this,
                                               TableName.ICShipmentPackageItemsTableName,
                                               TableName.ICShipmentPackageItemDetailsTableName,
                                               BOSList<ICShipmentPackageItemDetailsInfo>.cstRelationForeign);
            DeleteShipmentPackageItemDetailList.ItemTableForeignKey = "FK_ICShipmentPackageItemID";

            ShipmentPackageItemDetailReportList.InitBOSList(this,
                                               TableName.ICShipmentPackageItemsTableName,
                                               TableName.ICShipmentPackageItemDetailsTableName,
                                               BOSList<ICShipmentPackageItemDetailsInfo>.cstRelationForeign);
            ShipmentPackageItemDetailReportList.ItemTableForeignKey = "FK_ICShipmentPackageItemID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(ShipmentModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(ShipmentModule.DocumentEntryGridControlName);
            ShipmentPackageItemList.InitBOSListGridControl("fld_dgcICShipmentPackageItems");
            ShipmentPackageItemDetailShowList.InitBOSListGridControl("fld_dgcICShipmentPackageItemDetails");
            ShipmentPackageItemDetailList.InitBOSListGridControl();
            ShipmentPackageItemDetailReportList.InitBOSListGridControl("fld_dgcICShipmentPackageItemDetails2");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
                ComponentShipmentItemList.SetDefaultListAndRefreshGridControl();
                ShipmentPackageItemList.SetDefaultListAndRefreshGridControl();
                ShipmentPackageItemDetailShowList.SetDefaultListAndRefreshGridControl();
                ShipmentPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                DeleteShipmentPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                ShipmentPackageItemDetailReportList.SetDefaultListAndRefreshGridControl();
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

            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentDate = BOSApp.GetCurrentServerDate();
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.Shipment.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
            CountItemsInShipmentPackageItemList = 0;
        }

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = objShipmentItemsController.GetItemByShipmentID(iObjectID);
            ShipmentItemList.Invalidate(shipmentItemList.OrderBy(o => o.Id).ToList());

            //Invalidate item components
            //InvalidateItemComponents();

            //CountItemsInShipmentPackageItemList = ShipmentPackageItemList.Count();
            //ShipmentPackageItemList.Clear();

            //bool isEditing = false;
            //ShipmentPackageItemList.Invalidate(iObjectID);
            //ShipmentPackageItemList.ForEach(o =>
            //{
            //    if (o.ICShipmentPackageItemID == 0)
            //    {
            //        isEditing = true;
            //    }
            //});
            //if (!isEditing)
            //{
            //    ShipmentPackageItemDetailShowList.Clear();
            //    ShipmentPackageItemList.ForEach(o =>
            //    {
            //        ICShipmentPackageItemDetailsController objShipmentPackageItemDetailsController = new ICShipmentPackageItemDetailsController();
            //        List<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailList = objShipmentPackageItemDetailsController.GetPackageItemDetailsListByPackageItemID(o.ICShipmentPackageItemID);
            //        ShipmentPackageItemDetailList.ForEach(x =>
            //        {
            //            ShipmentPackageItemDetailShowList.Add(x);
            //        });
            //    });
            //}
            //ShipmentPackageItemDetailShowList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Save Module Objects functions        
        public override void SaveModuleObjects()
        {
            //Update shipment status
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            objShipmentsInfo.STToolbarActionName = "New";
            UpdateMainObject();

            ShipmentItemList.SaveItemObjects();

        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICShipmentItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICShipmentItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
                ICShipmentItemsInfo shipmentItem = (ICShipmentItemsInfo)item;
                shipmentItem.FK_ICProductID = objProductsInfo.ICProductID;
                shipmentItem.ICShipmentItemProductFactor = 1;
                shipmentItem.ICShipmentItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                SetDefaultValuesFromProduct(objProductsInfo.ICProductID, shipmentItem);
                shipmentItem.ICShipmentItemProductQty = 0M;
                shipmentItem.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                if (objProductsInfo.FK_ICProductSaleUnitID != 0)
                {
                    shipmentItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                }
                else
                {
                    shipmentItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                }
            }
        }

        public void UpdateTotalAmount()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            foreach (ICShipmentItemsInfo entItem in ShipmentItemList)
            {
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
            }
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            BOSApp.RoundByCurrency(objShipmentsInfo, objShipmentsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Invalidate item components of the shipment items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            List<ICShipmentItemsInfo> items = objShipmentItemsController.GetComponentItemsByShipmentID(objShipmentsInfo.ICShipmentID);
            ComponentShipmentItemList.Clear();
            ComponentShipmentItemList.OriginalList.Clear();
            ComponentShipmentItemList.BackupList.Clear();
            foreach (ICShipmentItemsInfo item in items)
            {
                ComponentShipmentItemList.Add((ICShipmentItemsInfo)item.Clone());
            }

            foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
            {
                ComponentShipmentItemList.OriginalList.Add((ICShipmentItemsInfo)item.Clone());
            }

            foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
            {
                ComponentShipmentItemList.BackupList.Add((ICShipmentItemsInfo)item.Clone());
            }
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);
            }
            return base.SaveAccountingData();
        }
        #endregion

        public void RemoveOldShipmentPackageItemDetailItem(IBOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailsList)
        {
            List<ICShipmentPackageItemDetailsInfo> RemovePackageItemDetailsList = (List<ICShipmentPackageItemDetailsInfo>)ShipmentPackageItemDetailsList;
            RemovePackageItemDetailsList.ForEach(o =>
            {
                ShipmentPackageItemDetailShowList.ForEach(x =>
                {
                    if (x.FK_ICShipmentPackageItemID == o.FK_ICShipmentPackageItemID)
                        ShipmentPackageItemDetailShowList.Remove(x);
                });
            });
        }

        public override void DuplicateModuleObjectList()
        {
            base.DuplicateModuleObjectList();
            ShipmentItemList.Duplicate();
        }
    }
}

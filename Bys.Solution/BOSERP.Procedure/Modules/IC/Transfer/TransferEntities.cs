using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.Transfer
{
    public class TransferEntities : GLTransferEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the shipment transfer list for selection to create a receipt transfer
        /// </summary>
        public BOSList<ICTransfersInfo> ShipmentTransferList { get; set; }

        /// <summary>
        /// Gets or sets the item list of a shipment transfer that the receipt transfer
        /// has been created from        
        /// </summary>
        public BOSItemsEntityList<ICTransferItemsInfo> ShipmentTransferItemList { get; set; }

        /// <summary>
        /// Gets or sets the item list of a transfer including the item's components
        /// </summary>
        public BOSItemsEntityList<ICTransferItemsInfo> ComponentTransferItemList { get; set; }
        #endregion

        #region Constructor
        public TransferEntities()
            : base()
        {
            TransferItemList = new BOSItemsEntityList<ICTransferItemsInfo>();
            ShipmentTransferItemList = new BOSItemsEntityList<ICTransferItemsInfo>();
            ComponentTransferItemList = new BOSItemsEntityList<ICTransferItemsInfo>();
            ShipmentTransferList = new BOSList<ICTransfersInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICTransfersInfo();
            SearchObject = new ICTransfersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICTransferItemPackagesTableName, new ICTransferItemPackagesInfo());
            ModuleObjects.Add(TableName.ICTransferItemsTableName, new ICTransferItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            TransferItemList.InitBOSList(
                                        this,
                                        TableName.ICTransfersTableName,
                                        TableName.ICTransferItemsTableName,
                                        BOSList<ICTransferItemsInfo>.cstRelationForeign);
            TransferItemList.ItemTableForeignKey = "FK_ICTransferID";

            ComponentTransferItemList.InitBOSList(
                                        this,
                                        TableName.ICTransfersTableName,
                                        TableName.ICTransferItemsTableName,
                                        BOSList<ICTransferItemsInfo>.cstRelationForeign);
            ComponentTransferItemList.ItemTableForeignKey = "FK_ICTransferID";

            ShipmentTransferItemList.InitBOSList(
                                        this,
                                        TableName.ICTransfersTableName,
                                        TableName.ICTransferItemsTableName,
                                        BOSList<ICTransferItemsInfo>.cstRelationForeign);
            ShipmentTransferItemList.ItemTableForeignKey = "FK_ICTransferID";

            ShipmentTransferList.InitBOSList(
                                        this,
                                        string.Empty,
                                        TableName.ICTransfersTableName,
                                        BOSList<ICTransferItemsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            TransferItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                TransferItemList.SetDefaultListAndRefreshGridControl();
                ComponentTransferItemList.SetDefaultListAndRefreshGridControl();
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
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            List<ICTransferItemsInfo> transferItemList = objTransferItemsController.GetTransferItemsByTransferID(iObjectID);
            TransferItemList.Invalidate(transferItemList.OrderBy(o => o.ICTransferItemID).ToList());

            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
            foreach (ICTransferItemsInfo item in TransferItemList)
            {
                if (objTransfersInfo.ICTransferType == TransferType.Transfer.ToString())
                {
                    item.FK_ICStockID = item.FK_ICFromStockID;
                }
                else
                {
                    item.FK_ICStockID = item.FK_ICToStockID;
                }
            }

            foreach (ICTransferItemsInfo objTransferItemsInfo in TransferItemList)
            {
                objTransferItemsInfo.TransferItemPackageList = new BOSList<ICTransferItemPackagesInfo>();
                objTransferItemsInfo.TransferItemPackageList.InitBOSList(this,
                                                                                TableName.ICTransferItemsTableName,
                                                                                TableName.ICTransferItemPackagesTableName,
                                                                                BOSList<ICTransferItemPackagesInfo>.cstRelationForeign);
                objTransferItemsInfo.TransferItemPackageList.Invalidate(objTransferItemsInfo.ICTransferItemID);
            }

            //Invalidate item components
            //InvalidateItemComponents();

            //Update the back-up component item list for rolling back
            //ComponentTransferItemList.BackupList.Clear();
            //if (objTransfersInfo.ICTransferStatus != TransferStatus.New.ToString())
            //{
            //    foreach (ICTransferItemsInfo item in ComponentTransferItemList)
            //    {
            //        ComponentTransferItemList.BackupList.Add((ICTransferItemsInfo)item.Clone());
            //    }
            //}
        }
        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICTransfersInfo transfer = (ICTransfersInfo)MainObject;
            transfer.ICTransferDate = DateTime.Now;
            transfer.ICTransferType = TransferType.Transfer.ToString();
            transfer.ICTransferStatus = TransferStatus.New.ToString();
            transfer.FK_ICFromStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            transfer.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GECurrencyID;
            transfer.ICTransferTransferType = TransferTransferType.Transfer.ToString();
            transfer.FK_ICToStockID = 0;

            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.TransitOut.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objStocksInfo != null)
            {
                transfer.FK_ICTransitStockID = objStocksInfo.ICStockID;
            }

            if (BOSApp.CurrentCompanyInfo != null)
            {
                transfer.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            }

            if (transfer.ICTransferType == TransferType.Transfer.ToString())
            {
                transfer.ICTransferDesc = TransferLocalizedResources.TransferDefaultDesc;
            }
            else if (transfer.ICTransferType == TransferType.TransferReceipt.ToString())
            {
                transfer.ICTransferDesc = TransferLocalizedResources.TransferReceiptDefaultDesc;
            }
            UpdateMainObjectBindingSource();

            SaveAccountingData();
        }

        #region Save Module Objects functions
        public override string GetMainObjectNo(ref int numberingStart)
        {
            //[NUThao][Delete][Duplicate No issue] [26-09-2014][START]

            //String mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            //GENumberingController objNumberingController = new GENumberingController();

            ////NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], START
            ////GENumberingInfo objNumberingInfo = (GENumberingInfo)objNumberingController.GetObjectByName(Module.Name);
            //GENumberingInfo objNumberingInfo;
            //objNumberingInfo = objNumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            ////List<GENumberingInfo> nuberingList = objNumberingController.GetNumberingListByName(Module.Name);
            ////if (nuberingList.Count == 1)
            ////{
            ////    objNumberingInfo = nuberingList[0];
            ////}
            ////else
            ////{
            ////    objNumberingInfo = nuberingList.Where(i => i.FK_BRBranchID == BOSApp.CurrentCompanyInfo.FK_BRBranchID).FirstOrDefault();
            ////}
            ////NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], END

            //String prefix = String.Empty;
            //if (objNumberingInfo != null)
            //{
            //    ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
            //    prefix = objNumberingInfo.GENumberingPrefix;
            //    if (objTransfersInfo.ICTransferType == TransferType.Transfer.ToString())
            //    {
            //        mainObjectNo = "X" + mainObjectNo;
            //    }
            //    else if (objTransfersInfo.ICTransferType == TransferType.TransferReceipt.ToString())
            //    {
            //        mainObjectNo = "N" + mainObjectNo;
            //    }
            //}

            //[NUThao][Delete][Duplicate No issue] [26-09-2014][END]

            //[NUThao][ADD][Duplicate No issue] [26-09-2014][START]
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            String prefix = String.Empty;

            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo != null)
            {
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");

                ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
                prefix = objGENumberingInfo.GENumberingPrefix;

                if (objTransfersInfo.ICTransferType == TransferType.Transfer.ToString())
                {
                    prefix = "X" + prefix;
                }
                else if (objTransfersInfo.ICTransferType == TransferType.TransferReceipt.ToString())
                {
                    prefix = "N" + prefix;
                }

                if (objMainObjectController != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    DateTime currentDate = BOSApp.GetCurrentServerDate();
                    if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                    {
                        objGENumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
                    }
                    strMainObjectNo = String.Format("{0}{1}.{2}.{3}",
                                                    prefix,
                                                    currentDate.Year.ToString().Substring(2, 2),
                                                    currentDate.Month.ToString().PadLeft(2, '0'),
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = String.Format("{0}{1}.{2}.{3}",
                                                    prefix,
                                                    currentDate.Year.ToString().Substring(2, 2),
                                                    currentDate.Month.ToString().PadLeft(2, '0'),
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            //[NUThao][ADD][Duplicate No issue] [26-09-2014][END]
            return strMainObjectNo;
        }

        public override void SaveModuleObjects()
        {
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
            if (objTransfersInfo.ICTransferType == TransferType.TransferReceipt.ToString())
            {
                foreach (ICTransferItemsInfo item in TransferItemList)
                {
                    //Create serie if not exist
                    SynProductSerie(item);
                    item.ICTransferItemReceiptedQty = item.ICTransferItemProductQty;
                }
            }
            TransferItemList.SaveItemObjects();
            if (objTransfersInfo.ICTransferType == TransferType.Transfer.ToString())
            {
                UpdateTransferProposalReferenceByTransfer();
            }
        }

        public void UpdateTransferProposalReferenceByTransfer()
        {
            ICTransferProposalItemsController objTransferProposalItemsController = new ICTransferProposalItemsController();
            ICTransferProposalItemsInfo objTransferProposalItemsInfo = new ICTransferProposalItemsInfo();
            foreach (ICTransferItemsInfo item in TransferItemList)
            {
                if (item.FK_ICTransferProposalItemID == 0)
                    continue;
                objTransferProposalItemsInfo = (ICTransferProposalItemsInfo)objTransferProposalItemsController.GetObjectByID(item.FK_ICTransferProposalItemID);
                objTransferProposalItemsInfo.ICTransferProposalItemStatus = TransferProposalStatus.Transferring.ToString();
                objTransferProposalItemsController.UpdateObject(objTransferProposalItemsInfo);
            }
            ICTransferProposalsController objTransferProposalsController = new ICTransferProposalsController();
            if (objTransferProposalItemsInfo == null)
                return;

            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)objTransferProposalsController.GetObjectByID(objTransferProposalItemsInfo.FK_ICTransferProposalID);
            if (objTransferProposalsInfo == null)
                return;

            objTransferProposalsInfo.ICTransferProposalStatus = TransferProposalStatus.Transferring.ToString();
            objTransferProposalsController.UpdateObject(objTransferProposalsInfo);
        }

        public void UpdateTransferProposalReferenceByTransferReceipt()
        {
            ICTransferProposalItemsController objTransferProposalItemsController = new ICTransferProposalItemsController();
            ICTransferProposalItemsInfo objTransferProposalItemsInfo = new ICTransferProposalItemsInfo();
            foreach (ICTransferItemsInfo item in TransferItemList)
            {
                if (item.FK_ICTransferProposalItemID == 0)
                    continue;
                objTransferProposalItemsInfo = (ICTransferProposalItemsInfo)objTransferProposalItemsController.GetObjectByID(item.FK_ICTransferProposalItemID);
                objTransferProposalItemsInfo.ICTransferProposalItemProductTransferredQty = item.ICTransferItemProductQty;
                if (objTransferProposalItemsInfo.ICTransferProposalItemProductTransferredQty == objTransferProposalItemsInfo.ICTransferProposalItemProductQty)
                    objTransferProposalItemsInfo.ICTransferProposalItemStatus = TransferProposalStatus.Completed.ToString();
                objTransferProposalItemsController.UpdateObject(objTransferProposalItemsInfo);
            }
            ICTransferProposalsController objTransferProposalsController = new ICTransferProposalsController();
            if (objTransferProposalItemsInfo == null)
                return;
            objTransferProposalsController.UpdateTransferProposalStatusReferenceByTransferProposalID(objTransferProposalItemsInfo.FK_ICTransferProposalID);
        }

        /// <summary>
        /// Save transfer item package list
        /// </summary>
        /// <param name="transferItemList">The transfer item list</param>
        public void SaveTransferItemPackageList(BOSItemsEntityList<ICTransferItemsInfo> transferItemList)
        {
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
            ICPackagesController objPackagesController = new ICPackagesController();
            if (transferItemList != null)
            {
                foreach (ICTransferItemsInfo item in transferItemList)
                {
                    if (item.TransferItemPackageList != null)
                    {
                        foreach (ICTransferItemPackagesInfo objTransferItemPackagesInfo in item.TransferItemPackageList)
                        {
                            if (objTransfersInfo.ICTransferType == TransferType.TransferReceipt.ToString())
                            {
                                //Create package first if it has not existed
                                if (!string.IsNullOrEmpty(objTransferItemPackagesInfo.ICPackageNo))
                                {
                                    ICPackagesInfo objPackagesInfo = (ICPackagesInfo)objPackagesController.GetObjectByNo(objTransferItemPackagesInfo.ICPackageNo);
                                    if (objPackagesInfo != null)
                                    {
                                        objTransferItemPackagesInfo.FK_ICPackageID = objPackagesInfo.ICPackageID;
                                    }
                                    else
                                    {
                                        objPackagesInfo = (ICPackagesInfo)item.PackageList.Where(p => p.ICPackageNo == objTransferItemPackagesInfo.ICPackageNo).FirstOrDefault();
                                        if (objPackagesInfo != null)
                                        {
                                            objPackagesInfo.AACreatedDate = DateTime.Now;
                                            objPackagesInfo.AACreatedUser = BOSApp.CurrentUser;
                                            int packageID = objPackagesController.CreateObject(objPackagesInfo);

                                            objTransferItemPackagesInfo.FK_ICPackageID = packageID;
                                        }
                                    }
                                }
                            }
                            objTransferItemPackagesInfo.FK_ICTransferItemID = item.ICTransferItemID;
                        }
                        item.TransferItemPackageList.SaveItemObjects();
                    }
                }
            }
        }

        #endregion

        public override void SetDefaultValuesFromProduct(int iICProductID)
        {
            ICTransferItemsInfo item = (ICTransferItemsInfo)ModuleObjects[TableName.ICTransferItemsTableName];
            SetDefaultValuesFromProduct(iICProductID, item);
        }

        public override void SetDefaultValuesFromProduct(int productID, BusinessObject item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                base.SetDefaultValuesFromProduct(productID, item);

                ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
                ICTransferItemsInfo transferItem = (ICTransferItemsInfo)item;
                transferItem.FK_ICFromStockID = objTransfersInfo.FK_ICFromStockID;
                transferItem.FK_ICToStockID = objTransfersInfo.FK_ICToStockID;
                transferItem.FK_ICTransitStockID = objTransfersInfo.FK_ICTransitStockID;
                transferItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                transferItem.ICTransferItemReceiptedQty = 0;
                if (objTransfersInfo.ICTransferType == TransferType.Transfer.ToString())
                {
                    transferItem.FK_ICStockID = objTransfersInfo.FK_ICFromStockID;
                }
                else
                {
                    transferItem.FK_ICStockID = objTransfersInfo.FK_ICToStockID;
                }
                transferItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                UpdateModuleObjectBindingSource(TableName.ICTransferItemsTableName);
            }
        }

        /// <summary>
        /// Generate receipt transfer from shipment one
        /// </summary>
        /// <param name="objShipmentTransfersInfo">Shipment transfer</param>
        public void GenerateReceiptTransferFromShipmentTransfer(ICTransfersInfo objShipmentTransfersInfo)
        {
            ICTransfersInfo receiptTransfer = (ICTransfersInfo)MainObject;
            receiptTransfer.ICTransferReference = objShipmentTransfersInfo.ICTransferNo;
            receiptTransfer.FK_ICFromStockID = objShipmentTransfersInfo.FK_ICFromStockID;
            receiptTransfer.FK_ICToStockID = objShipmentTransfersInfo.FK_ICToStockID;
            UpdateMainObjectBindingSource();

            GetShipmentTransferItems(objShipmentTransfersInfo);
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            foreach (ICTransferItemsInfo item in ShipmentTransferItemList)
            {
                if (item.ICTransferItemProductQty - item.ICTransferItemReceiptedQty > 0)
                {
                    ICTransferItemsInfo receiptTransferItem = (ICTransferItemsInfo)item.Clone();
                    receiptTransferItem.ICTransferItemID = 0;
                    receiptTransferItem.ICTransferItemProductQty = item.ICTransferItemProductQty - item.ICTransferItemReceiptedQty - item.ICTransferItemWaitingReceiptQty;
                    receiptTransferItem.ICTransferItemProductExchangeQty = receiptTransferItem.ICTransferItemProductQty * receiptTransferItem.ICTransferItemProductFactor;
                    receiptTransferItem.ICTransferItemProductQtyOld = receiptTransferItem.ICTransferItemProductQty;
                    receiptTransferItem.ICTransferItemReceiptedQty = receiptTransferItem.ICTransferItemProductQty;

                    objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(receiptTransferItem.FK_ICProductID);
                    if (objMeasureUnitsInfo != null)
                    {
                        receiptTransferItem.ICMeasureUnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                    }
                    if (receiptTransferItem.ICTransferItemProductQty > 0)
                        TransferItemList.Add(receiptTransferItem);
                }
            }
            TransferItemList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Switch to the shipment branch and get the item list of the selected shipment transfer
        /// </summary>
        /// <param name="objShipmentTransfersInfo">Shipment transfer</param>
        private void GetShipmentTransferItems(ICTransfersInfo objShipmentTransfersInfo)
        {
            //NUThao [ADD] [08/04/2014] [DB centre] [SwitchConnection issue], START
            if (objShipmentTransfersInfo != null)
            {
                ICTransferItemsController objICTransferItemsController = new ICTransferItemsController();
                ICTransferItemPackagesController objTransferItemPackagesController = new ICTransferItemPackagesController();
                List<ICTransferItemsInfo> items = objICTransferItemsController.GetTransferItemsByTransferID(objShipmentTransfersInfo.ICTransferID);
                ShipmentTransferItemList.Invalidate(items);
                foreach (ICTransferItemsInfo item in ShipmentTransferItemList)
                {
                    item.TransferItemPackageList = new BOSList<ICTransferItemPackagesInfo>();
                    item.TransferItemPackageList.InitBOSList(
                                                            this,
                                                            TableName.ICTransferItemsTableName,
                                                            TableName.ICTransferItemPackagesTableName,
                                                            BOSItemsEntityList<ICTransferItemsInfo>.cstRelationForeign);
                    item.TransferItemPackageList.ItemTableForeignKey = "FK_ICTransferItemID";
                    DataSet ds = objTransferItemPackagesController.GetTransferItemPackagesByTransferItemID(item.ICTransferItemID);
                    item.TransferItemPackageList.Invalidate(ds);
                    item.TransferItemPackageList.OriginalList.Clear();
                    item.PackageList = objICTransferItemsController.GetPackagesByTransferItemID(item.ICTransferItemID);
                    foreach (ICTransferItemPackagesInfo objTransferItemPackagesInfo in item.TransferItemPackageList)
                    {
                        objTransferItemPackagesInfo.ICTransferItemPackageID = 0;
                    }
                }
            }

            //NUThao [ADD] [08/04/2014] [DB centre] [SwitchConnection issue], END
        }

        public override bool CompleteTransaction()
        {
            return CompleteShipment();
        }

        /// <summary>
        /// Update Transfer status to Post and update inventory stock from and stock transit
        /// </summary>
        private bool CompleteShipment()
        {
            ICTransfersInfo transfer = (ICTransfersInfo)MainObject;

            //Set inventory cost for transfer items
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            foreach (ICTransferItemsInfo item in TransferItemList)
            {
                item.ICTransferItemProductUnitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ICTransferItemProductSerialNo, transfer.ICTransferDate) * item.ICTransferItemProductFactor;
                item.ICTransferItemTotalCost = item.ICTransferItemProductUnitCost * item.ICTransferItemProductQty;
                objTransferItemsController.UpdateObject(item);
            }


            //Update transfer status                        
            if (transfer.ICTransferStatus == TransferStatus.New.ToString())
            {
                transfer.ICTransferStatus = TransferStatus.Post.ToString();
                UpdateMainObject();
            }
            if (transfer.ICTransferTransferType == TransferTransferType.TransferOutsourcing.ToString())
                return true;

            if ((Module as TransferModule).EditAfterCompleting)
            {
                UpdateTransferReceipt();
            }
            else
            {
                GenerateTransferReceipt();
            }
            return true;
        }

        public void UpdateTransferReceipt()
        {
            ICTransfersInfo mainobject = (ICTransfersInfo)MainObject;
            ICTransfersController objTransfersController = new ICTransfersController();

            ICTransfersInfo objTransfersInfo = objTransfersController.GetTransferReceiptByTransferNo(mainobject.ICTransferNo);
            if (objTransfersInfo == null)
            {
                return;
            }
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(objTransfersInfo.FK_ICToStockID);
            if (objStocksInfo != null)
                objTransfersInfo.FK_BRBranchID = objStocksInfo.FK_BRBranchID;
            int objectID = objTransfersController.UpdateObject(objTransfersInfo);
            if (objectID > 0)
            {
                ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                List<ICTransferItemsInfo> transferReceiptList = objTransferItemsController.GetTransferItemsByTransferID(objectID);
                int itemID = 0;
                transferReceiptList.ForEach(o =>
                {
                    itemID = o.ICTransferItemID;
                    ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetObjectByID(o.ICTransferItemParentID);
                    if (objTransferItemsInfo == null)
                        return;
                    o = (ICTransferItemsInfo)objTransferItemsInfo.Clone();
                    o.ICTransferItemID = itemID;
                    o.FK_ICTransferID = objTransfersInfo.ICTransferID;
                    o.ICTransferItemProductQty = objTransferItemsInfo.ICTransferItemProductQty - -objTransferItemsInfo.ICTransferItemReceiptedQty;
                    o.ICTransferItemProductQtyOld = o.ICTransferItemProductQty;
                    o.ICTransferItemReceiptedQty = o.ICTransferItemProductQty;
                    objTransferItemsController.UpdateObject(o);
                });
            }
        }

        public string GenerateTransferReceiptNo()
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            String prefix = String.Empty;

            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo != null)
            {
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");

                ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
                prefix = objGENumberingInfo.GENumberingPrefix;


                prefix = "N" + prefix;


                if (objMainObjectController != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    DateTime currentDate = BOSApp.GetCurrentServerDate();
                    if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                    {
                        objGENumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
                    }
                    strMainObjectNo = String.Format("{0}{1}.{2}.{3}",
                                                    prefix,
                                                    currentDate.Year.ToString().Substring(2, 2),
                                                    currentDate.Month.ToString().PadLeft(2, '0'),
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    int numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = String.Format("{0}{1}.{2}.{3}",
                                                        prefix,
                                                        currentDate.Year.ToString().Substring(2, 2),
                                                        currentDate.Month.ToString().PadLeft(2, '0'),
                                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            //[NUThao][ADD][Duplicate No issue] [26-09-2014][END]
            return strMainObjectNo;
        }

        public void GenerateTransferReceipt()
        {
            ICTransfersInfo transfer = (ICTransfersInfo)MainObject;
            ICTransfersController objTransfersController = new ICTransfersController();
            ICTransfersInfo transferReceipt = new ICTransfersInfo();
            BOSUtil.CopyObject(transfer, transferReceipt);
            transferReceipt.ICTransferType = TransferType.TransferReceipt.ToString();
            transferReceipt.ICTransferReference = transfer.ICTransferNo;
            transferReceipt.ICTransferStatus = TransferStatus.New.ToString();
            transferReceipt.ICTransferNo = GenerateTransferReceiptNo();
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(transferReceipt.FK_ICToStockID);
            if (objStocksInfo != null)
                transferReceipt.FK_BRBranchID = objStocksInfo.FK_BRBranchID;
            int id = objTransfersController.CreateObject(transferReceipt);
            if (id > 0)
            {
                List<ICTransferItemsInfo> transferReceiptList = new List<ICTransferItemsInfo>();
                GenerateReceiptTransferFromShipmentTransfer(transferReceiptList);
                ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                foreach (ICTransferItemsInfo item in transferReceiptList)
                {
                    item.FK_ICTransferID = id;
                    objTransferItemsController.CreateObject(item);
                }
            }
        }

        public void GenerateReceiptTransferFromShipmentTransfer(List<ICTransferItemsInfo> transferReceiptList)
        {
            foreach (ICTransferItemsInfo item in TransferItemList)
            {
                if (item.ICTransferItemProductQty > 0)
                {
                    ICTransferItemsInfo receiptTransferItem = (ICTransferItemsInfo)item.Clone();
                    receiptTransferItem.ICTransferItemID = 0;
                    receiptTransferItem.ICTransferItemParentID = item.ICTransferItemID;
                    receiptTransferItem.ICTransferItemProductQty = item.ICTransferItemProductQty;
                    receiptTransferItem.ICTransferItemProductQtyOld = receiptTransferItem.ICTransferItemProductQty;
                    receiptTransferItem.ICTransferItemReceiptedQty = receiptTransferItem.ICTransferItemProductQty;
                    transferReceiptList.Add(receiptTransferItem);
                }
            }

        }
        /// <summary>
        /// Complete receipt transfer
        /// </summary>
        public bool CompleteReceipt()
        {
            bool isCompleted = true;
            ICTransfersInfo receiptTransfer = (ICTransfersInfo)MainObject;
            if (!string.IsNullOrEmpty(receiptTransfer.ICTransferReference))
            {
                isCompleted = UpdateShipmentTransfer();
            }
            ICTransfersController objTransfersController = new ICTransfersController();
            ICTransfersInfo transferReference = (ICTransfersInfo)objTransfersController.GetObjectByNo(receiptTransfer.ICTransferReference);
            if (transferReference != null && DateTime.Compare(transferReference.ICTransferDate, receiptTransfer.ICTransferDate) > 0)
            {
                MessageBox.Show("Ngày chứng từ hiện tại đang nhỏ hơn ngày xuất chuyển kho: \n"
                            + string.Format("{0} - {1}", transferReference.ICTransferNo, transferReference.ICTransferDate.ToShortDateString())
                            , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                isCompleted = false;
            }
            if (isCompleted)
            {
                isCompleted = false;
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    try
                    {
                        receiptTransfer = (ICTransfersInfo)MainObject;

                        //Update receipt transfer status                        
                        receiptTransfer.ICTransferStatus = TransferStatus.Complete.ToString();
                        receiptTransfer.ICTransferPostedStatus = PostedTransactionStatus.Posted.ToString();
                        UpdateMainObject();
                        GLHelper.PostedTransactions(this.Module.Name, receiptTransfer.ICTransferID, ModulePostingType.Accounting, ModulePostingType.Stock, ModulePostingType.SaleOrder, ModulePostingType.Purchase, ModulePostingType.Allocation, ModulePostingType.TransitIn, ModulePostingType.TransitOut);
                        scope.Complete();
                        isCompleted = true;
                    }
                    catch (Exception)
                    {
                        scope.Dispose();
                        isCompleted = false;
                    }
                }
            }
            return isCompleted;
        }

        /// <summary>
        /// Switch to shipment branch, update inventory of transit stock and shipment transfer status
        /// </summary>
        public bool UpdateShipmentTransfer()
        {
            bool isCompleted = false;
            ICTransfersInfo objReceiptTransfersInfo = (ICTransfersInfo)MainObject;
            ICTransfersController objTransfersController = new ICTransfersController();
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICTransfersInfo objShipmentTransfersInfo = (ICTransfersInfo)objTransfersController.GetObjectByNo(objReceiptTransfersInfo.ICTransferReference);
            if (objShipmentTransfersInfo != null)
            {
                //Update shipment transfer status
                if (objShipmentTransfersInfo.ICTransferStatus == TransferStatus.Post.ToString() ||
                    objShipmentTransfersInfo.ICTransferStatus == TransferStatus.Incomplete.ToString())
                {
                    BOSList<ICTransferItemsInfo> shipmentTransferItems = new BOSList<ICTransferItemsInfo>(TableName.ICTransferItemsTableName);
                    if (IsCompleteShipmentTransfer(objShipmentTransfersInfo, ref shipmentTransferItems))
                    {
                        objShipmentTransfersInfo.ICTransferStatus = TransferStatus.Complete.ToString();
                        objTransfersController.UpdateObject(objShipmentTransfersInfo);
                    }
                    else
                    {
                        objShipmentTransfersInfo.ICTransferStatus = TransferStatus.Incomplete.ToString();
                        objTransfersController.UpdateObject(objShipmentTransfersInfo);
                    }

                    //List<ICTransferItemsInfo> oldComponentShipmentTransferItems = objTransferItemsController.GetComponentItemsByTransferID(objShipmentTransfersInfo.ICTransferID);

                    //Update the receipted quantity of the shipment transfer's items
                    foreach (ICTransferItemsInfo objShipmentTransferItemsInfo in shipmentTransferItems)
                    {
                        objTransferItemsController.UpdateObject(objShipmentTransferItemsInfo);
                    }
                    isCompleted = true;
                }
                else
                {
                    MessageBox.Show(string.Format("Chứng từ xuất chuyển kho {0} đã hoàn tất, không thể hoàn tất chứng từ nhập chuyển kho này!", objReceiptTransfersInfo.ICTransferReference)
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Warning);
                    isCompleted = false;
                }
            }
            return isCompleted;
            //NUThao [ADD] [08/04/2014] [DB centre] [SwitchConnection issue], END
        }

        /// <summary>
        /// Check whether a shipment transfer is completed or not.
        /// A shipment transfer is completed when all its items have been received
        /// </summary>
        /// <param name="objShipmentTransfersInfo">Shipment transfer</param>
        /// <returns>True if completed, otherwise false</returns>
        private bool IsCompleteShipmentTransfer(ICTransfersInfo objShipmentTransfersInfo, ref BOSList<ICTransferItemsInfo> shipmentTransferItems)
        {
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            DataSet ds = objTransferItemsController.GetAllDataByForeignColumn("FK_ICTransferID", objShipmentTransfersInfo.ICTransferID);
            shipmentTransferItems.Invalidate(ds);
            bool isComplete = true;
            if (ds.Tables.Count > 0)
            {
                BOSItemsEntityList<ICTransferItemsInfo> receiptTransferItems = (BOSItemsEntityList<ICTransferItemsInfo>)TransferItemList.Clone();
                foreach (ICTransferItemsInfo shipmentTransferItem in shipmentTransferItems)
                {
                    decimal shippedQty = shipmentTransferItem.ICTransferItemProductQty - shipmentTransferItem.ICTransferItemReceiptedQty;
                    foreach (ICTransferItemsInfo receiptTransferItem in receiptTransferItems)
                    {
                        if (shipmentTransferItem.FK_ICProductID == receiptTransferItem.FK_ICProductID &&
                            shipmentTransferItem.ICTransferItemProductSerialNo == receiptTransferItem.ICTransferItemProductSerialNo)
                        {
                            decimal receiptedQty = Math.Min(shippedQty, receiptTransferItem.ICTransferItemProductQty);
                            shippedQty -= receiptedQty;
                            shipmentTransferItem.ICTransferItemReceiptedQty += receiptedQty;
                            receiptTransferItem.ICTransferItemProductQty -= receiptedQty;
                            if (shippedQty == 0)
                            {
                                break;
                            }
                        }
                    }
                    if (shippedQty > 0)
                    {
                        isComplete = false;
                    }
                }
            }
            return isComplete;
        }

        /// <summary>
        /// Invalidate item components of the transfer items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
            List<ICTransferItemsInfo> items = objTransferItemsController.GetComponentItemsByTransferID(objTransfersInfo.ICTransferID);
            ComponentTransferItemList.Clear();
            ComponentTransferItemList.OriginalList.Clear();
            foreach (ICTransferItemsInfo item in items)
            {
                ComponentTransferItemList.Add((ICTransferItemsInfo)item.Clone());
            }

            foreach (ICTransferItemsInfo item in ComponentTransferItemList)
            {
                ComponentTransferItemList.OriginalList.Add((ICTransferItemsInfo)item.Clone());
            }
        }

        #region Functions for logging
        protected void LogTransferReceipt()
        {
            //For consistency, Roll-back local Connection
            BOSApp.RollbackLocalConnection();

            int iICTransferLogID = CreateICTransferLogs();

            if (iICTransferLogID > 0)
            {
                CreateICTransferLogItems(iICTransferLogID);
            }

        }

        protected int CreateICTransferLogs()
        {
            ICTransferLogsController objICTransferLogsController = new ICTransferLogsController();

            ICTransferLogsInfo objICTransferLogsInfo = new ICTransferLogsInfo();
            objICTransferLogsInfo.ICTransferLogDate = ((ICTransfersInfo)MainObject).ICTransferDate;
            objICTransferLogsInfo.ICTransferReceiptNo = ((ICTransfersInfo)MainObject).ICTransferNo;
            //objICTransferLogsInfo.ICReferenceTransferNo = ((ICTransfersInfo)MainObject).ICTransferReferenceNo;
            objICTransferLogsInfo.FK_ICFromStockID = ((ICTransfersInfo)MainObject).FK_ICFromStockID;
            objICTransferLogsInfo.FK_ICToStockID = ((ICTransfersInfo)MainObject).FK_ICToStockID;
            objICTransferLogsInfo.FK_ICTransitStockID = ((ICTransfersInfo)MainObject).FK_ICTransitStockID;

            return objICTransferLogsController.CreateObject(objICTransferLogsInfo);
        }

        protected void CreateICTransferLogItems(int iICTransferLogID)
        {
            ICTransferLogItemsController objICTransferLogItemsController = new ICTransferLogItemsController();

            foreach (ICTransferItemsInfo objTransferItemsInfo in TransferItemList)
            {
                ICTransferLogItemsInfo objICTransferLogItemsInfo = new ICTransferLogItemsInfo();
                BOSUtil.CopyObject(objTransferItemsInfo, objICTransferLogItemsInfo);
                objICTransferLogItemsInfo.FK_ICTransferLogID = iICTransferLogID;

                objICTransferLogItemsController.CreateObject(objICTransferLogItemsInfo);
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);

            if (strTableName == TableName.ICTransfersTableName)
            {
                ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                objTransferItemsController.DeleteByForeignColumn("FK_ICTransferID", iObjectID);
            }
        }
        public override bool CancelCompleteTransaction()
        {
            ICTransfersInfo objTransfersInfo = (ICTransfersInfo)MainObject;
            objTransfersInfo.ICTransferStatus = TransferStatus.New.ToString();
            if (objTransfersInfo.ICTransferType == TransferType.TransferReceipt.ToString())
            {
                ICTransfersController objTransfersController = new ICTransfersController();
                ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                ICTransfersInfo objShipmentTransfersInfo = (ICTransfersInfo)objTransfersController.GetObjectByNo(objTransfersInfo.ICTransferReference);
                BOSList<ICTransferItemsInfo> shipmentTransferItems = new BOSList<ICTransferItemsInfo>(TableName.ICTransferItemsTableName);
                if (objShipmentTransfersInfo != null)
                {
                    objShipmentTransfersInfo.ICTransferStatus = TransferStatus.Incomplete.ToString();
                    objTransfersController.UpdateObject(objShipmentTransfersInfo);
                    DataSet ds = objTransferItemsController.GetAllDataByForeignColumn("FK_ICTransferID", objShipmentTransfersInfo.ICTransferID);
                    shipmentTransferItems.Invalidate(ds);
                    if (ds.Tables.Count > 0)
                    {
                        foreach (ICTransferItemsInfo shipmentTransferItem in shipmentTransferItems)
                        {
                            BOSItemsEntityList<ICTransferItemsInfo> receiptTransferItems = (BOSItemsEntityList<ICTransferItemsInfo>)TransferItemList.Clone();
                            foreach (ICTransferItemsInfo receiptTransferItem in receiptTransferItems)
                            {
                                if (shipmentTransferItem.FK_ICProductID == receiptTransferItem.FK_ICProductID &&
                                    shipmentTransferItem.ICTransferItemProductSerialNo == receiptTransferItem.ICTransferItemProductSerialNo)
                                {
                                    shipmentTransferItem.ICTransferItemReceiptedQty -= receiptTransferItem.ICTransferItemProductQty;
                                }
                            }
                            objTransferItemsController.UpdateObject(shipmentTransferItem);
                        }
                    }
                }
            }
            UpdateMainObject();
            return true;
        }

        public override void DuplicateModuleObjectList()
        {
            base.DuplicateModuleObjectList();
            TransferItemList.Duplicate();
            ComponentTransferItemList.Duplicate();
        }
    }
}



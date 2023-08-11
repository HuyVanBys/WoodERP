using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.GeneralAccounting
{
    public class GeneralAccountingEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of data locks
        /// </summary>
        public BOSList<ADLocksInfo> LockList { get; set; }

        /// <summary>
        /// Gets or sets the list of branches where the adjustment is performed
        /// </summary>
        public BOSList<BRBranchsInfo> BranchList { get; set; }

        /// <summary>
        /// Gets or sets the list of product series that are going to be adjusted
        /// </summary>
        public BOSList<ICReceiptItemsInfo> ProductSerieList { get; set; }

        public BOSList<ACDocumentEntrysInfo> BriefDocumentEntryList { get; set; }

        public BOSList<ACDepreciationAssetTransInfo> DepreciationAssetTranList { get; set; }

        public BOSList<ACAllocationEquipmentTransInfo> AllocationEquipmentTranList { get; set; }

        public BOSList<ACAllocationCostObjectTransInfo> AllocationCostObjectTranList { get; set; }
        #endregion

        #region Constructor
        public GeneralAccountingEntities()
            : base()
        {
            LockList = new BOSList<ADLocksInfo>(this, string.Empty, TableName.ADLocksTableName);
            BranchList = new BOSList<BRBranchsInfo>(this, string.Empty, TableName.BRBranchsTableName);
            ProductSerieList = new BOSList<ICReceiptItemsInfo>(this, string.Empty, TableName.ICReceiptItemsTableName);
            BriefDocumentEntryList = new BOSList<ACDocumentEntrysInfo>(this, string.Empty, TableName.ACDocumentEntrysTableName);
            DepreciationAssetTranList = new BOSList<ACDepreciationAssetTransInfo>();
            AllocationEquipmentTranList = new BOSList<ACAllocationEquipmentTransInfo>();
            AllocationCostObjectTranList = new BOSList<ACAllocationCostObjectTransInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACDocumentsInfo();
            SearchObject = new ACDocumentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ADLocksTableName, new ADLocksInfo());
        }

        public override void InitModuleObjectList()
        {
            DocumentEntryList.InitBOSList(
                                        this,
                                        TableName.ACDocumentsTableName,
                                        TableName.ACDocumentEntrysTableName,
                                        BOSList<ACDocumentEntrysInfo>.cstRelationForeign);
            DocumentEntryList.ItemTableForeignKey = "FK_ACDocumentID";

            BRBranchsController objBranchsController = new BRBranchsController();
            var branches = objBranchsController.GetAllBranches();
            //branches = branches.Where(b => b.BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID).ToList();
            branches.ForEach(b => b.Selected = true);
            BranchList.Invalidate(branches);

            BriefDocumentEntryList.InitBOSList(
                                        this,
                                        string.Empty,
                                        TableName.ACDocumentEntrysTableName,
                                        BOSList<ACDocumentEntrysInfo>.cstRelationNone);

            DepreciationAssetTranList.InitBOSList(
                                        this,
                                        TableName.ACDocumentsTableName,
                                        TableName.ACDepreciationAssetTransTableName,
                                        BOSList<ACDepreciationAssetTransInfo>.cstRelationForeign);
            DepreciationAssetTranList.ItemTableForeignKey = "FK_ACDocumentID";

            AllocationEquipmentTranList.InitBOSList(
                                        this,
                                        TableName.ACDocumentsTableName,
                                        TableName.ACAllocationEquipmentTransTableName,
                                        BOSList<ACAllocationEquipmentTransInfo>.cstRelationForeign);
            AllocationEquipmentTranList.ItemTableForeignKey = "FK_ACDocumentID";

            AllocationCostObjectTranList.InitBOSList(
                                        this,
                                        TableName.ACDocumentsTableName,
                                        TableName.ACAllocationCostObjectTransTableName,
                                        BOSList<ACAllocationCostObjectTransInfo>.cstRelationForeign);
            AllocationCostObjectTranList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            DocumentEntryList.InitBOSListGridControl(GeneralAccountingModule.DocumentEntryGridControlName);
            BriefDocumentEntryList.InitBOSListGridControl(GeneralAccountingModule.DocumentEntryGridControlName1);
            DepreciationAssetTranList.InitBOSListGridControl();
            AllocationEquipmentTranList.InitBOSListGridControl();
            AllocationCostObjectTranList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentDate = DateTime.Now;
            objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
                DepreciationAssetTranList.SetDefaultListAndRefreshGridControl();
                AllocationEquipmentTranList.SetDefaultListAndRefreshGridControl();
                AllocationCostObjectTranList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentTypeName = objDocumentTypesController.GetObjectNameByID(objDocumentsInfo.FK_ACDocumentTypeID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACDepreciationAssetTransController objDepreciationAssetTransController = new ACDepreciationAssetTransController();
            List<ACDepreciationAssetTransInfo> items = objDepreciationAssetTransController.GetDepreciationAssetTransByDocumentID(iObjectID);
            DepreciationAssetTranList.Invalidate(items);
            AllocationEquipmentTranList.Invalidate(iObjectID);
            ACAllocationCostObjectTransController objAllocationCostObjectTransController = new ACAllocationCostObjectTransController();
            List<ACAllocationCostObjectTransInfo> allocationCostItems = objAllocationCostObjectTransController.GetAllocationCostObjectTransByDocumentID(iObjectID);
            AllocationCostObjectTranList.Invalidate(allocationCostItems);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentTotalAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryAmount);
            objDocumentsInfo.ACDocumentExchangeAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryExchangeAmount);
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            DepreciationAssetTranList.SaveItemObjects();
            AllocationEquipmentTranList.SaveItemObjects();
            AllocationCostObjectTranList.SaveItemObjects();
            SaveDocumentEntrys(objDocumentsInfo);

            if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.KhauHaoTSCD.ToString())
            {
                UpdateAssetDepreciatedAmount();
            }
            else if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.PhanBoCCDC.ToString())
            {
                UpdateEquipmentDepreciatedAmount();
            }
            else if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.PhanBoChiPhi.ToString())
            {
                UpdateCostObjectAllocatedAmount();
                ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
                objCostObjectItemsController.UpdateCostObjectItemIsAllocated(objDocumentsInfo.ACDocumentNo, true);
            }
        }
        /// <summary>
        /// true: tang, false: giam
        /// </summary>
        /// <param name="check"></param>
        public void UpdateCostObjectItems(bool check)
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.PhanBoChiPhi.ToString())
            {
                if (AllocationCostObjectTranList != null && AllocationCostObjectTranList.Count > 0)
                {
                    foreach (ACAllocationCostObjectTransInfo item in AllocationCostObjectTranList)
                    {
                        if (item.FK_ACCostObjectItemID > 0)
                        {
                            ACCostObjectItemsInfo objCostObjectItemsInfo = (ACCostObjectItemsInfo)objCostObjectItemsController.GetObjectByID(item.FK_ACCostObjectItemID);
                            if (objCostObjectItemsInfo != null)
                            {
                                if (check == true)
                                {
                                    objCostObjectItemsInfo.ACCostObjectItemAllocatedAmount += item.ACAllocationCostObjectTranAmount;
                                }
                                else
                                {
                                    objCostObjectItemsInfo.ACCostObjectItemAllocatedAmount -= item.ACAllocationCostObjectTranAmount;
                                    if (objCostObjectItemsInfo.ACCostObjectItemAllocatedAmount < 0)
                                    {
                                        objCostObjectItemsInfo.ACCostObjectItemAllocatedAmount = 0;
                                    }
                                }
                                objCostObjectItemsController.UpdateObject(objCostObjectItemsInfo);
                            }
                        }

                    }

                }
            }
        }
        /// <summary>
        /// Update the depreciated amount of depreciated assets
        /// </summary>
        private void UpdateAssetDepreciatedAmount()
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            List<ACAssetsInfo> assets = new List<ACAssetsInfo>();
            foreach (ACDepreciationAssetTransInfo item in DepreciationAssetTranList.BackupList)
            {
                if (string.IsNullOrEmpty(item.ACDepreciationAssetTranAdjustType))
                {
                    ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(item.FK_ACAssetID);
                    if (objAssetsInfo != null)
                    {
                        objAssetsInfo.ACAssetDepreciatedAmount -= item.ACDepreciationAssetTranAmount;
                        objAssetsInfo.ACAssetRemainedAmount += item.ACDepreciationAssetTranAmount;
                        if (!DepreciationAssetTranList.Exists(e => e.FK_ACAssetID == objAssetsInfo.ACAssetID))
                        {
                            objAssetsController.UpdateObject(objAssetsInfo);
                        }
                        assets.Add(objAssetsInfo);
                    }
                }
            }

            foreach (ACDepreciationAssetTransInfo item in DepreciationAssetTranList)
            {
                if (string.IsNullOrEmpty(item.ACDepreciationAssetTranAdjustType))
                {
                    ACAssetsInfo objAssetsInfo = assets.Where(a => a.ACAssetID == item.FK_ACAssetID).FirstOrDefault();
                    if (objAssetsInfo == null)
                    {
                        objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(item.FK_ACAssetID);
                    }
                    if (objAssetsInfo != null)
                    {
                        objAssetsInfo.ACAssetDepreciatedAmount += item.ACDepreciationAssetTranAmount;
                        objAssetsInfo.ACAssetRemainedAmount -= item.ACDepreciationAssetTranAmount;
                        if (objAssetsInfo.ACAssetRemainedAmount == 0)
                        {
                            objAssetsInfo.ACAssetStatus = AssetStatus.UsingWithoutDepreciation.ToString();
                        }
                        objAssetsController.UpdateObject(objAssetsInfo);
                    }
                }
            }
        }

        /// <summary>
        /// Update the depreciated amount of depreciated equipments
        /// </summary>
        private void UpdateEquipmentDepreciatedAmount()
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
            List<ICProductIdentifiedEquipmentsInfo> pIEquipments = new List<ICProductIdentifiedEquipmentsInfo>();
            List<ACEquipmentTransferItemsInfo> transferItems = new List<ACEquipmentTransferItemsInfo>();

            ICProductIdentifiedEquipmentsController objPIEController = new ICProductIdentifiedEquipmentsController();
            foreach (ACAllocationEquipmentTransInfo item in AllocationEquipmentTranList.BackupList)
            {
                if (item.FK_ICProductIdentifiedEquipmentID > 0)
                {
                    ICProductIdentifiedEquipmentsInfo objPIEInfo = (ICProductIdentifiedEquipmentsInfo)objPIEController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                    if (objPIEInfo != null)
                    {
                        objPIEInfo.ICProductIdentifiedEquipmentDepriciatedAmount -= item.ACAllocationEquipmentTranAmount;

                        if (!AllocationEquipmentTranList.Exists(e => e.FK_ICProductIdentifiedEquipmentID == objPIEInfo.ICProductIdentifiedEquipmentID))
                        {
                            objPIEController.UpdateObject(objPIEInfo);
                        }
                        pIEquipments.Add(objPIEInfo);
                    }
                }
                //else if (item.ACEquipmentTransferItemID > 0)
                //{
                //    ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)objEquipmentTransferItemsController.GetObjectByID(entry.ACEquipmentTransferItemID);
                //    if (item != null)
                //    {
                //        if (entry.ICEquipmentDepreciatedQty > 0)
                //        {
                //            decimal depreciatedAmount = entry.ACDocumentEntryExchangeAmount / entry.ICEquipmentDepreciatedQty;
                //            item.ACEquipmentTransferItemDepreciatedAmount -= depreciatedAmount;
                //            if (!DocumentEntryList.Exists(e => e.ACEquipmentTransferItemID == item.ACEquipmentTransferItemID))
                //            {
                //                objEquipmentTransferItemsController.UpdateObject(item);
                //            }
                //        }
                //        transferItems.Add(item);
                //    }
                //}
            }

            foreach (ACAllocationEquipmentTransInfo item in AllocationEquipmentTranList)
            {
                if (item.FK_ICProductIdentifiedEquipmentID > 0)
                {
                    ICProductIdentifiedEquipmentsInfo objPIEInfo = pIEquipments.Where(i => i.ICProductIdentifiedEquipmentID == item.FK_ICProductIdentifiedEquipmentID).FirstOrDefault();
                    if (objPIEInfo == null)
                    {
                        objPIEInfo = (ICProductIdentifiedEquipmentsInfo)objPIEController.GetObjectByID(item.FK_ICProductIdentifiedEquipmentID);
                    }
                    if (objPIEInfo != null)
                    {
                        if (objPIEInfo != null)
                        {
                            objPIEInfo.ICProductIdentifiedEquipmentDepriciatedAmount += item.ACAllocationEquipmentTranAmount;
                            objPIEController.UpdateObject(objPIEInfo);
                        }
                    }
                }
                //else if (entry.ACEquipmentTransferItemID > 0)
                //{
                //    ACEquipmentTransferItemsInfo transferItem = transferItems.Where(i => i.ACEquipmentTransferItemID == entry.ACEquipmentTransferItemID).FirstOrDefault();
                //    if (transferItem == null)
                //    {
                //        transferItem = (ACEquipmentTransferItemsInfo)objEquipmentTransferItemsController.GetObjectByID(entry.ACEquipmentTransferItemID);
                //    }
                //    if (transferItem != null)
                //    {
                //        if (entry.ICEquipmentDepreciatedQty > 0)
                //        {
                //            decimal depreciatedAmount = entry.ACDocumentEntryExchangeAmount / entry.ICEquipmentDepreciatedQty;
                //            transferItem.ACEquipmentTransferItemDepreciatedAmount += depreciatedAmount;
                //            objEquipmentTransferItemsController.UpdateObject(transferItem);
                //        }
                //    }
                //}
            }
        }

        /// <summary>
        /// Update the allocated amount of cost objects
        /// </summary>
        private void UpdateCostObjectAllocatedAmount()
        {
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> allocatedEntries = new List<ACDocumentEntrysInfo>();
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList.BackupList)
            {
                ACDocumentEntrysInfo allocatedEntry = (ACDocumentEntrysInfo)objDocumentEntrysController.GetObjectByID(entry.ACAllocatedDocumentEntryID);
                if (allocatedEntry != null)
                {
                    allocatedEntry.ACDocumentEntryAllocatedAmount -= entry.ACDocumentEntryExchangeAmount;
                    if (!DocumentEntryList.Exists(e => e.ACDocumentEntryID == entry.ACDocumentEntryID))
                    {
                        objDocumentEntrysController.UpdateObject(allocatedEntry);
                    }
                    allocatedEntries.Add(allocatedEntry);
                }
            }

            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                ACDocumentEntrysInfo allocatedEntry = allocatedEntries.Where(e => e.ACDocumentEntryID == entry.ACAllocatedDocumentEntryID).FirstOrDefault();
                if (allocatedEntry == null)
                {
                    allocatedEntry = (ACDocumentEntrysInfo)objDocumentEntrysController.GetObjectByID(entry.ACAllocatedDocumentEntryID);
                }
                if (allocatedEntry != null)
                {
                    allocatedEntry.ACDocumentEntryAllocatedAmount += entry.ACDocumentEntryExchangeAmount;
                    objDocumentEntrysController.UpdateObject(allocatedEntry);
                }
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            if (strTableName == TableName.ACDocumentsTableName)
            {
                //Rollback relative data
                ACDocumentsInfo document = (ACDocumentsInfo)MainObject;
                DocumentEntryList.Clear();
                if (document.ACDocumentTypeName == AccDocumentType.KhauHaoTSCD.ToString())
                {
                    DepreciationAssetTranList.Clear();
                    UpdateAssetDepreciatedAmount();
                }
                else if (document.ACDocumentTypeName == AccDocumentType.PhanBoCCDC.ToString())
                {
                    AllocationEquipmentTranList.Clear();
                    UpdateEquipmentDepreciatedAmount();
                }
                else if (document.ACDocumentTypeName == AccDocumentType.PhanBoChiPhi.ToString())
                {
                    ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
                    objCostObjectItemsController.UpdateCostObjectItemIsAllocated(objDocumentsInfo.ACDocumentNo, false);
                    //PhanBoChiPhi
                    //UpdateCostObjectItems(false);
                    AllocationCostObjectTranList.Clear();
                    UpdateCostObjectAllocatedAmount();
                }

                //Delete the document
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                objDocumentsController.DeleteByID(document.ACDocumentID);
            }
        }

        public override void SaveDocumentEntrys(ACDocumentsInfo objDocumentsInfo)
        {
            //base.SaveDocumentEntrys(objDocumentsInfo);
            if (objDocumentsInfo != null)
            {
                if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.ChenhLechTyGia.ToString())
                {
                    foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
                    {
                        entry.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                        entry.FK_ACAssObjectID = objDocumentsInfo.FK_ACAssObjectID;
                        entry.ACAssObjectType = objDocumentsInfo.ACAssObjectType;
                        //entry.ACObjectType = objDocumentsInfo.ACObjectType;
                    }
                    DocumentEntryList.SaveItemObjects();
                }
                else if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.XacDinhKQKD.ToString())
                    DocumentEntryList.SaveItemObjects();
                else
                    base.SaveDocumentEntrys(objDocumentsInfo);
            }
        }
    }
}

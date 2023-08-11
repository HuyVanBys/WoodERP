using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Modules.BatchProduct.Localization;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    class BatchProductEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the batch product item list
        /// </summary>
        public BOSList<MMBatchProductItemsInfo> BatchProductItemList { get; set; }
        public BOSTreeList BatchProductProductionNormItemList { get; set; }
        public BOSTreeList ProductionNormItemHardwareList { get; set; }
        public BOSTreeList ProductionNormItemPackagingList { get; set; }
        public BOSTreeList ProductionNormItemPaintList { get; set; }
        public BOSTreeList ProductionNormItemGeneralMaterialList { get; set; }
        public BOSList<MMBatchProductProductionNormItemMeterialsInfo> batchProductProductionNormItemMeterialList { get; set; }
        public BOSList<MMBatchProductProductionNormItemHardwaresInfo> batchProductProductionNormItemHardwareDetailList { get; set; }
        //public BOSList<MMBPOperationDepartmentsInfo> BPOperationDepartmentList { get; set; }
        //public BOSList<MMBatchProductItemGeneralPlansInfo> BatchProductItemGeneralPlanList { get; set; }
        public BOSList<MMBatchProductItemOutSourcingsInfo> BatchProductItemOutSourcingList { get; set; }

        public List<TreeStructure> SemiProductStructure { get; set; }
        #endregion
        #region Contructors
        public BatchProductEntities()
            : base()
        {
            BatchProductItemList = new BOSList<MMBatchProductItemsInfo>();
            BatchProductProductionNormItemList = new BOSTreeList();
            ProductionNormItemHardwareList = new BOSTreeList();
            ProductionNormItemPackagingList = new BOSTreeList();
            ProductionNormItemPaintList = new BOSTreeList();
            ProductionNormItemGeneralMaterialList = new BOSTreeList();
            batchProductProductionNormItemMeterialList = new BOSList<MMBatchProductProductionNormItemMeterialsInfo>();
            batchProductProductionNormItemHardwareDetailList = new BOSList<MMBatchProductProductionNormItemHardwaresInfo>();
            //BPOperationDepartmentList = new BOSList<MMBPOperationDepartmentsInfo>();
            //BatchProductItemGeneralPlanList = new BOSList<MMBatchProductItemGeneralPlansInfo>();
            BatchProductItemOutSourcingList = new BOSList<MMBatchProductItemOutSourcingsInfo>();
            SemiProductStructure = new List<TreeStructure>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMBatchProductsInfo();
            SearchObject = new MMBatchProductsInfo();
        }

        public override void DuplicateModuleObjectList()
        {
            BatchProductProductionNormItemList.Duplicate();
            ProductionNormItemHardwareList.Duplicate();
            ProductionNormItemPackagingList.Duplicate();
            ProductionNormItemPaintList.Duplicate();
            ProductionNormItemGeneralMaterialList.Duplicate();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMBatchProductItemsTableName, new MMBatchProductItemsInfo());
            ModuleObjects.Add(TableName.MMBatchProductItemOperationsTableName, new MMBatchProductItemOperationsInfo());
            ModuleObjects.Add(TableName.MMBPOperationDepartmentsTableName, new MMBPOperationDepartmentsInfo());
        }

        public override void InitModuleObjectList()
        {
            BatchProductItemList.InitBOSList(
                                        this,
                                        TableName.MMBatchProductsTableName,
                                        TableName.MMBatchProductItemsTableName,
                                        BOSList<MMBatchProductItemsInfo>.cstRelationForeign);
            BatchProductItemList.ItemTableForeignKey = "FK_MMBatchProductID";

            BatchProductProductionNormItemList.InitBOSList(this,
                                                TableName.MMBatchProductsTableName,
                                                TableName.MMBatchProductProductionNormItemsTableName,
                                                BOSTreeList.cstRelationForeign);
            BatchProductProductionNormItemList.ItemTableForeignKey = "FK_MMBatchProductID";

            ProductionNormItemHardwareList.InitBOSList(this,
                                                TableName.MMBatchProductsTableName,
                                                TableName.MMBatchProductProductionNormItemsTableName,
                                                BOSTreeList.cstRelationForeign);
            ProductionNormItemHardwareList.ItemTableForeignKey = "FK_MMBatchProductID";

            ProductionNormItemGeneralMaterialList.InitBOSList(this,
                                                TableName.MMBatchProductsTableName,
                                                TableName.MMBatchProductProductionNormItemsTableName,
                                                BOSTreeList.cstRelationForeign);
            ProductionNormItemGeneralMaterialList.ItemTableForeignKey = "FK_MMBatchProductID";


            ProductionNormItemPackagingList.InitBOSList(this,
                                               TableName.MMBatchProductsTableName,
                                               TableName.MMBatchProductProductionNormItemsTableName,
                                               BOSTreeList.cstRelationForeign);
            ProductionNormItemPackagingList.ItemTableForeignKey = "FK_MMBatchProductID";
            ProductionNormItemPaintList.InitBOSList(this,
                                              TableName.MMBatchProductsTableName,
                                              TableName.MMBatchProductProductionNormItemsTableName,
                                              BOSTreeList.cstRelationForeign);
            ProductionNormItemPaintList.ItemTableForeignKey = "FK_MMBatchProductID";

            batchProductProductionNormItemMeterialList.InitBOSList(this,
                                                TableName.MMBatchProductProductionNormItemsTableName,
                                                TableName.MMBatchProductProductionNormItemMeterialsTableName,
                                                BOSList<MMBatchProductProductionNormItemMeterialsInfo>.cstRelationForeign);
            batchProductProductionNormItemMeterialList.ItemTableForeignKey = "FK_MMBatchProductProductionNormItemID";
            batchProductProductionNormItemHardwareDetailList.InitBOSList(this,
                                               TableName.MMBatchProductProductionNormItemsTableName,
                                               TableName.MMBatchProductProductionNormItemHardwaresTableName,
                                               BOSList<MMBatchProductProductionNormItemHardwaresInfo>.cstRelationForeign);
            batchProductProductionNormItemHardwareDetailList.ItemTableForeignKey = "FK_MMBatchProductProductionNormItemID";

            //BPOperationDepartmentList.InitBOSList(this,
            //                                    TableName.MMBatchProductsTableName,
            //                                    TableName.MMBPOperationDepartmentsTableName,
            //                                    BOSList<MMBatchProductItemOperationsInfo>.cstRelationForeign);
            //BPOperationDepartmentList.ItemTableForeignKey = "FK_MMBatchProductID";

            //BatchProductItemGeneralPlanList.InitBOSList(this,
            //                                    TableName.MMBatchProductsTableName,
            //                                    "MMBatchProductItemGeneralPlans",
            //                                    BOSList<MMBatchProductItemGeneralPlansInfo>.cstRelationForeign);
            //BatchProductItemGeneralPlanList.ItemTableForeignKey = "FK_MMBatchProductID";

            BatchProductItemOutSourcingList.InitBOSList(this,
                                               TableName.MMBatchProductsTableName,
                                               "MMBatchProductItemOutSourcings",
                                               BOSList<MMBatchProductItemOutSourcingsInfo>.cstRelationForeign);
            BatchProductItemOutSourcingList.ItemTableForeignKey = "FK_MMBatchProductID";
        }

        public override void InitGridControlInBOSList()
        {
            BatchProductItemList.InitBOSListGridControl();
            BatchProductProductionNormItemList.InitBOSTreeListControl();
            ProductionNormItemHardwareList.InitBOSTreeListControl("fld_trlMMProductionNormItemsHardware");
            ProductionNormItemPackagingList.InitBOSTreeListControl("fld_trlMMProductionNormItemsPackaging");
            ProductionNormItemPaintList.InitBOSTreeListControl("fld_trlMMProductionNormItemsPaint");
            ProductionNormItemGeneralMaterialList.InitBOSTreeListControl("fld_trlMMProductionNormItemsGeneralMaterial");
            //BatchProductItemGeneralPlanList.InitBOSListGridControl("fld_dgcMMBatchProductItemGeneralPlans");
            BatchProductItemOutSourcingList.InitBOSListGridControl("fld_dgcMMBatchProductItemOutSourcings");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            objBatchProductsInfo.MMBatchProductDate = BOSApp.GetCurrentServerDate();
            objBatchProductsInfo.MMBatchProductStatus = BatchProductStatus.New.ToString();
            objBatchProductsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BatchProductItemList.SetDefaultListAndRefreshGridControl();
                BatchProductProductionNormItemList.SetDefaultListAndRefreshTreeListControl();
                ProductionNormItemHardwareList.SetDefaultListAndRefreshTreeListControl();
                ProductionNormItemPackagingList.SetDefaultListAndRefreshTreeListControl();
                ProductionNormItemPaintList.SetDefaultListAndRefreshTreeListControl();
                ProductionNormItemGeneralMaterialList.SetDefaultListAndRefreshGridControl();
                BatchProductItemOutSourcingList.SetDefaultListAndRefreshGridControl();
                SemiProductStructure.Clear();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Override BaseTransactionEntities

        public override int CreateMainObject()
        {
            return base.CreateMainObject();
        }

        public void GroupBatchProductProductionNormItem(BOSTreeList BatchProductProductionNormItemListGroup)
        {
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            ICProductsController objProductsController = new ICProductsController();
            List<int> productIDList = new List<int>();

        Stamp:
            foreach (MMBatchProductProductionNormItemsInfo item in BatchProductProductionNormItemListGroup)
            {
                if (!productIDList.Contains(item.FK_MMBatchProductItemID) && item.FK_ICProductForBatchID > 0)
                {
                    productIDList.Add(item.FK_MMBatchProductItemID);
                    MMBatchProductProductionNormItemsInfo parent = new MMBatchProductProductionNormItemsInfo();
                    parent.MMBatchProductProductionNormItemNo = item.ICProductNo;
                    parent.MMBatchProductProductionNormItemProductName = item.ICProductName;
                    parent.SubList = new BOSTreeList();
                    foreach (MMBatchProductProductionNormItemsInfo subItem in BatchProductProductionNormItemListGroup)
                    {
                        if (subItem.FK_MMProductionNormID == item.FK_MMProductionNormID
                            && subItem.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID)
                        {
                            parent.SubList.Add(subItem);

                        }
                    }
                    //parent.SubList.Add(item);
                    BatchProductProductionNormItemListGroup.Add(parent);
                    goto Stamp;
                }
            }


            for (int i = 0; i < BatchProductProductionNormItemListGroup.Count; i++)
            {
                MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)BatchProductProductionNormItemListGroup[i];
                if (item.FK_MMProductionNormID != 0)
                {
                    BatchProductProductionNormItemListGroup.RemoveAt(i--);
                }
            }

        }
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            MMBatchProductsInfo mainObject = (MMBatchProductsInfo)MainObject;
            if (mainObject.ACObjectAccessKey == null || mainObject.ACObjectAccessKey == string.Empty)
            {
                if (mainObject.FK_ACObjectID > 0 && mainObject.MMObjectType != string.Empty)
                    mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.MMObjectType;
            }
        }
        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMBatchProductItemsController batchProductItemController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> collection = batchProductItemController.GetBatchProductItemsByBatchProductID(iObjectID);
            BatchProductItemList.Invalidate(collection);
            //((BatchProductModule)Module).InvalidateBPOperationDepartment();
            MMBatchProductItemGeneralPlansController planCtrl = new MMBatchProductItemGeneralPlansController();
            List<MMBatchProductItemGeneralPlansInfo> planList = planCtrl.GetGeneralPlanByBatchProductID(iObjectID);
            //BatchProductItemGeneralPlanList.Invalidate(planList);
            BatchProductItemOutSourcingList.Invalidate(iObjectID);
            SemiProductStructure.Clear();
        }

        public void RefreshTreeView(BOSTreeList treeList)
        {
            if (treeList != null && treeList.TreeListControl != null)
            {
                treeList.TreeListControl.RefreshDataSource();
                treeList.TreeListControl.ExpandAll();
                treeList.TreeListControl.BestFitColumns();
            }
        }

        public void InvalidateListHaveParent(BOSTreeList list)
        {

            foreach (MMBatchProductProductionNormItemsInfo item in list)
            {
                if (item.MMBatchProductProductionNormItemGroup == ProductType.Product.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo noneProductItem in list)
                    {
                        if (noneProductItem.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                            && noneProductItem.MMBatchProductProductionNormItemGroup != ProductType.Product.ToString())
                        {
                            if (item.SubList == null)
                            {
                                item.SubList = new BOSTreeList();
                            }
                            item.SubList.Add(noneProductItem);
                        }
                    }
                }
            }

            //remove trash var
            for (int i = 0; i < list.Count; i++)
            {
                MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)list[i];
                if (item.MMBatchProductProductionNormItemParentID > 0)
                {
                    list.RemoveAt(i--);
                }
            }
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            String currentYear = DateTime.Now.ToString("yy");
            if (objBatchProductsInfo.MMBatchProductType == "MassProduction")
            {
                mainObjectNo = mainObjectNo.Replace(".S-", ".M-");
            }
            else
            {
                mainObjectNo = mainObjectNo.Replace(".S-", ".S-");
            }
            if (objBatchProductsInfo.FK_ARSaleOrderID > 0 && objBatchProductsInfo.MMBatchProductSaleOrderNo != string.Empty)
            {
                //get PI no 
                string PI = string.Empty;
                if (objBatchProductsInfo.MMBatchProductSaleOrderNo.Length > 6)
                    PI = objBatchProductsInfo.MMBatchProductSaleOrderNo.Substring(objBatchProductsInfo.MMBatchProductSaleOrderNo.Length - 6);
                if (PI != string.Empty)
                {
                    if (objBatchProductsInfo.MMBatchProductType == "MassProduction")
                    {
                        mainObjectNo = mainObjectNo = "LSX.M-" + PI;
                    }
                    else
                    {
                        mainObjectNo = mainObjectNo = "LSX.S-" + PI;
                    }
                }
            }

            return mainObjectNo;
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();


            BatchProductItemList.SaveItemObjects();

            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductWoodStatus != BatchProductStatus.Approved.ToString())
            {
                if (((BatchProductModule)Module).HaveFocusWood)
                {
                    SaveBatchProductProductionNorm(BatchProductProductionNormItemList, true);
                }
            }
            if (objBatchProductsInfo.MMBatchProductHWStatus != BatchProductStatus.Approved.ToString())
            {
                if (((BatchProductModule)Module).HaveFocusHardware)
                {
                    SaveBatchProductProductionNorm(ProductionNormItemHardwareList, false);
                }
            }
            if (objBatchProductsInfo.MMBatchProductPackagingStatus != BatchProductStatus.Approved.ToString())
            {
                if (((BatchProductModule)Module).HaveFocusPackaging)
                {
                    SaveBatchProductProductionNorm(ProductionNormItemPackagingList, false);
                }
            }
            if (objBatchProductsInfo.MMBatchProductPaintStatus != BatchProductStatus.Approved.ToString())
            {
                if (((BatchProductModule)Module).HaveFocusPaint)
                {
                    SaveBatchProductProductionNorm(ProductionNormItemPaintList, false);
                }
            }

            SaveBatchProductProductionNorm(ProductionNormItemGeneralMaterialList, false);
            if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.New.ToString()
                && objBatchProductsInfo.MMBatchProductID > 0)

                ((BatchProductModule)Module).UpdateProposalBatchStatus();
        }

        public void SaveBatchProductProductionNorm(IBOSTreeList treeListObjects, bool isHaveParent)
        {
            if (treeListObjects.Count() == 0)
                return;

            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            foreach (MMBatchProductProductionNormItemsInfo item in treeListObjects)
            {
                isHaveParent = item.HasChildren();
                if (isHaveParent)
                {
                    SaveBatchProductProductionNorm(item.SubList, isHaveParent);
                }
                if (item.MMBatchProductProductionNormItemID > 0)
                {
                    objBatchProductProductionNormItemsController.UpdateObject(item);
                }
                else
                {
                    objBatchProductProductionNormItemsController.CreateObject(item);
                }
            }
        }

        public bool ValidateBatchProduct()
        {
            SetPropertyChangeEventLock(false);

            //Update the proposal's status
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.New.ToString()
                && objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Verified.ToString()
                && objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Verified.ToString())
            {
                objBatchProductsInfo.MMBatchProductStatus = BatchProductStatus.Verified.ToString();
            }
            else
                return false;
            objBatchProductsInfo.FK_HREmployeeIDValidated = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.MMBatchProductValidatedDate = DateTime.Now;
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        #region Wood
        public bool ApproveBatchProduct()
        {
            SetPropertyChangeEventLock(false);
            //Update the proposal's status
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductStatus != BatchProductStatus.Approved.ToString())
            {
                if (objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.Verified.ToString() ||
                    objBatchProductsInfo.MMBatchProductStatus == BatchProductStatus.New.ToString())
                    objBatchProductsInfo.MMBatchProductStatus = BatchProductStatus.Approved.ToString();
                objBatchProductsInfo.FK_HREmployeeWoodApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objBatchProductsInfo.MMBatchProductWoodApproveDate = BOSApp.GetCurrentServerDate();
            }
            SetPropertyChangeEventLock(true);
            return true;
        }
        public string GetSerialNo(MMBatchProductItemsInfo item, int order)
        {
            string result = string.Empty;
            string soNo = string.Empty;
            string soEndOfNo = string.Empty;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (item.FK_ARSaleOrderID > 0)
            {
                soNo = BOSApp.GetDisplayTextFromCatche("ARSaleOrders", "ARSaleOrderID", item.FK_ARSaleOrderID, "ARSaleOrderNo");
            }
            if (!string.IsNullOrEmpty(soNo))
            {
                string[] soSpl = soNo.Split('.');
                if (soSpl.Length > 0)
                {
                    soEndOfNo = "." + soSpl[soSpl.Length - 1];
                }
            }

            result = objBatchProductsInfo.MMBatchProductNo + (!string.IsNullOrEmpty(soEndOfNo) ? soEndOfNo : "") + "." + order.ToString().PadLeft(2, '0');
            return result;
        }
        public bool ApproveWood()
        {
            if (((BatchProductModule)Module).CanApprove(ProductType.SemiProduct.ToString()))
            {
                if (ApproveBatchProduct())
                {
                    SetPropertyChangeEventLock(false);
                    int order = 0;
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
                    foreach (MMBatchProductItemsInfo item in BatchProductItemList)
                    {
                        order++;

                        if (item.MMBatchProductItemProductSerial == string.Empty)
                        {
                            string serial = objBatchProductsInfo.MMBatchProductNo + "." + order.ToString().PadLeft(2, '0');
                            if (serial != string.Empty)
                            {
                                item.MMBatchProductItemProductSerial = serial;
                            }
                        }
                    }
                    GeneralBarcode(objBatchProductsInfo.MMBatchProductID);
                    if (objBatchProductsInfo.MMBatchProductWoodStatus == BatchProductStatus.Verified.ToString())
                        objBatchProductsInfo.MMBatchProductWoodStatus = BatchProductStatus.Approved.ToString();
                    else
                    {
                        SetPropertyChangeEventLock(true);
                        return false;
                    }
                    objBatchProductsInfo.FK_HREmployeeWoodApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objBatchProductsInfo.MMBatchProductWoodApproveDate = DateTime.Now;
                    BatchProductItemList.SaveItemObjects();
                    UpdateMainObject();
                    SetPropertyChangeEventLock(true);
                }
                else
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void GeneralBarcode(int batchProductID)
        {
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            objBatchProductProductionNormItemsController.GenaralBarcode(batchProductID);
        }

        #endregion Wood

        /// <summary>
        /// Approve all items of the proposal
        /// </summary>
        public bool ApproveHW()
        {
            if (!((BatchProductModule)Module).CanApprove(ProductType.Hardware.ToString()))
                return false;

            if (!ApproveBatchProduct())
                return false;

            SetPropertyChangeEventLock(false);
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductHWStatus == BatchProductStatus.Verified.ToString())
                objBatchProductsInfo.MMBatchProductHWStatus = BatchProductStatus.Approved.ToString();
            else
            {
                SetPropertyChangeEventLock(true);
                return false;
            }
            objBatchProductsInfo.FK_HREmployeeHWApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.MMBatchProductHWApproveDate = BOSApp.GetCurrentServerDate();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        public bool ApproveGeneralMaterial()
        {
            if (!((BatchProductModule)Module).CanApprove(ProductType.GeneralMaterial.ToString()))
                return false;

            if (!ApproveBatchProduct())
                return false;

            SetPropertyChangeEventLock(false);
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductGeneralMaterialStatus == BatchProductStatus.Verified.ToString())
                objBatchProductsInfo.MMBatchProductGeneralMaterialStatus = BatchProductStatus.Approved.ToString();
            else
            {
                SetPropertyChangeEventLock(true);
                return false;
            }
            objBatchProductsInfo.FK_HREmployeeGeneralMaterialApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.MMBatchProductGeneralMaterialApproveDate = BOSApp.GetCurrentServerDate();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        /// <summary>
        /// Approve all items of the proposal
        /// </summary>
        public bool ApprovePackaging()
        {
            if (!((BatchProductModule)Module).CanApprove(ProductType.IngredientPackaging.ToString()))
                return false;

            if (!ApproveBatchProduct())
                return false;

            SetPropertyChangeEventLock(false);
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductPackagingStatus == BatchProductStatus.Verified.ToString())
                objBatchProductsInfo.MMBatchProductPackagingStatus = BatchProductStatus.Approved.ToString();
            else
            {
                SetPropertyChangeEventLock(true);
                return false;
            }
            objBatchProductsInfo.FK_HREmployeePackagingApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.MMBatchProductPackagingApproveDate = BOSApp.GetCurrentServerDate();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        public bool ApproveOperation()
        {
            if (!ApproveBatchProduct())
                return false;

            SetPropertyChangeEventLock(false);
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductOperationStatus == BatchProductStatus.New.ToString())
                objBatchProductsInfo.MMBatchProductOperationStatus = BatchProductStatus.Approved.ToString();
            else
            {
                SetPropertyChangeEventLock(true);
                return false;
            }
            objBatchProductsInfo.FK_HREmployeeOperationApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.MMBatchProductOperationApproveDate = BOSApp.GetCurrentServerDate();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        public bool CheckCanApproveOperation()
        {
            bool result = true;
            MMBatchProductItemOperationInfosController objBatchProductItemOperationInfosController = new MMBatchProductItemOperationInfosController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            MMBatchProductItemOperationInfosInfo objMMBatchProductItemOperationInfos = objBatchProductItemOperationInfosController.GetOperationProcesssByBatchProduct(objBatchProductsInfo.MMBatchProductID);
            if (objMMBatchProductItemOperationInfos == null || objMMBatchProductItemOperationInfos.MMBatchProductItemOperationInfoID == 0)
            {
                result = false;
                if (MessageBox.Show(BatchProductLocalizedResources.CannotApprovedOperationMessageError, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo,
                         MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool ApprovePaint()
        {
            if (!((BatchProductModule)Module).CanApprove(ProductType.IngredientPaint.ToString()))
                return false;

            if (!ApproveBatchProduct())
                return false;

            SetPropertyChangeEventLock(false);
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)MainObject;
            if (objBatchProductsInfo.MMBatchProductPaintStatus == BatchProductStatus.Verified.ToString())
                objBatchProductsInfo.MMBatchProductPaintStatus = BatchProductStatus.Approved.ToString();
            else
            {
                SetPropertyChangeEventLock(true);
                return false;
            }
            objBatchProductsInfo.FK_HREmployeePaintApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBatchProductsInfo.MMBatchProductPaintApproveDate = DateTime.Now;
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                objBatchProductsController.DeleteBatchProduct(iObjectID, BOSApp.CurrentUser);
            }
        }
    }
}

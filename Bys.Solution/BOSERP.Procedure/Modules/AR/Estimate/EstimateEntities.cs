using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BOSERP.Modules.Estimate
{
    public class EstimateEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSTreeList EstimateItemsList { get; set; }

        public BOSList<AREstimateItemsInfo> EstimateItemMaterialsList { get; set; }

        public BOSList<AREstimateItemsInfo> EstimateItemCostsList { get; set; }
        #endregion

        #region Constructor
        public EstimateEntities()
            : base()
        {
            EstimateItemsList = new BOSTreeList();
            EstimateItemMaterialsList = new BOSList<AREstimateItemsInfo>();
            EstimateItemCostsList = new BOSList<AREstimateItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new AREstimatesInfo();
            SearchObject = new AREstimatesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.AREstimateItemsTableName, new AREstimateItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            EstimateItemsList.InitBOSList(this,
                                               TableName.AREstimatesTableName,
                                               TableName.AREstimateItemsTableName,
                                               BOSList<AREstimateItemsInfo>.cstRelationForeign);
            EstimateItemsList.ItemTableForeignKey = "FK_AREstimateID";

            EstimateItemMaterialsList.InitBOSList(this,
                                               TableName.AREstimatesTableName,
                                               TableName.AREstimateItemsTableName,
                                               BOSList<AREstimateItemsInfo>.cstRelationForeign);
            EstimateItemMaterialsList.ItemTableForeignKey = "FK_AREstimateID";

            EstimateItemCostsList.InitBOSList(this,
                                               TableName.AREstimatesTableName,
                                               TableName.AREstimateItemsTableName,
                                               BOSList<AREstimateItemsInfo>.cstRelationForeign);
            EstimateItemCostsList.ItemTableForeignKey = "FK_AREstimateID";
        }

        public override void InitGridControlInBOSList()
        {
            EstimateItemsList.InitBOSTreeListControl(EstimateModule.EstimateItemsTreeListControlName);
            EstimateItemMaterialsList.InitBOSListGridControl(EstimateModule.EstimateItemMaterialsGridControlName);
            EstimateItemCostsList.InitBOSListGridControl(EstimateModule.EstimateItemCostsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            EstimateItemsList.SetDefaultListAndRefreshTreeListControl();
            EstimateItemMaterialsList.SetDefaultListAndRefreshGridControl();
            EstimateItemCostsList.SetDefaultListAndRefreshGridControl();
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            AREstimatesInfo mainObject = (AREstimatesInfo)MainObject;
            mainObject.AREstimateDate = BOSApp.GetCurrentServerDate();
        }

        #region Invalidate Module Objects functions


        public override void InvalidateModuleObjects(int iObjectID)
        {
            AREstimateItemsController objEstimateItemsController = new AREstimateItemsController();
            List<AREstimateItemsInfo> estimateItemsList = new List<AREstimateItemsInfo>();
            estimateItemsList = objEstimateItemsController.GetEstimateItemsByEstimateID(iObjectID);
            EstimateItemMaterialsList.Invalidate(estimateItemsList.Where(o => o.AREstimateItemProductType == EstimateItemProductType.Material.ToString()).ToList());
            EstimateItemCostsList.Invalidate(estimateItemsList.Where(o => o.AREstimateItemProductType == EstimateItemProductType.Cost.ToString()).ToList());

            List<AREstimateItemsInfo> estimateItemWorksList = new List<AREstimateItemsInfo>();
            estimateItemWorksList = estimateItemsList.Where(o => o.AREstimateItemProductType == EstimateItemProductType.Section.ToString()
                                                                      || o.AREstimateItemProductType == EstimateItemProductType.Work.ToString()).ToList();
            InvalidateTreeList(EstimateItemsList, estimateItemWorksList, estimateItemWorksList.Min(o => o.AREstimateItemParentID));
            RefreshTreeView(EstimateItemsList);
        }

        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            EstimateItemsList.SaveItemObjects();
            EstimateItemMaterialsList.SaveItemObjects();
            EstimateItemCostsList.SaveItemObjects();
        }
        #endregion

        public void GenerateEstimateItemFromProjectNorm(PMProjectsInfo objProjectsInfo)
        {
            AREstimatesInfo mainObject = (AREstimatesInfo)MainObject;

            PMProjectNormsController objProjectNormsController = new PMProjectNormsController();
            List<PMProjectNormsInfo> projectNorms = objProjectNormsController.GetProjectNormsByProjectID(objProjectsInfo.PMProjectID);
            if (projectNorms.Count <= 0)
                return;

            PMProjectNormItemsController objProjectNormItemsController = new PMProjectNormItemsController();
            List<PMProjectNormItemsInfo> projectNormItemList = objProjectNormItemsController.GetProjectNormItemsByProjectID(objProjectsInfo.PMProjectID);

            mainObject.FK_PMProjectID = objProjectsInfo.PMProjectID;
            mainObject.FK_ARCustomerID = objProjectsInfo.FK_ARCustomerID;
            UpdateMainObjectBindingSource();

            AddProjectNormToEstimateItemList(EstimateItemsList, projectNorms, projectNorms.Min(o => o.PMProjectNormParentID));

            projectNormItemList = projectNormItemList.Where(o => o.PMProjectNormItemProductType == EstimateItemProductType.Material.ToString()).ToList();
            List<AREstimateItemsInfo> estimateItemMaterials = projectNormItemList
                                                                             .GroupBy(o => o.PMProjectNormItemProductNo)
                                                                             .Select(i => new PMProjectNormItemsInfo
                                                                             {
                                                                                 PMProjectNormItemProductNo = i.First().PMProjectNormItemProductNo,
                                                                                 PMProjectNormItemProductName = i.First().PMProjectNormItemProductName,
                                                                                 PMProjectNormItemProductDesc = i.First().PMProjectNormItemProductDesc,
                                                                                 PMProjectNormItemQty = i.Sum(n => n.PMProjectNormItemQty),
                                                                                 FK_ICProductID = i.First().FK_ICProductID,
                                                                                 FK_ICMeasureUnitID = i.First().FK_ICMeasureUnitID,
                                                                                 FK_PMProjectID = i.First().FK_PMProjectID,
                                                                                 FK_PMProjectNormID = i.First().FK_PMProjectNormID,
                                                                                 PMProjectNormItemType = i.First().PMProjectNormItemType,
                                                                                 PMProjectNormItemProductType = i.First().PMProjectNormItemProductType,
                                                                             })
                                                                             .Select(x => ToEstimateItemsInfo(x)).ToList();
            RefreshTreeView(EstimateItemsList);

            EstimateItemMaterialsList.Invalidate(estimateItemMaterials);
            UpdateTotalAmount();
        }

        private void AddProjectNormToEstimateItemList(IBOSTreeList treeList, List<PMProjectNormsInfo> projectNorms, int parentID)
        {
            if (treeList != null && projectNorms != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();

                foreach (PMProjectNormsInfo item in projectNorms)
                {
                    if (item.PMProjectNormParentID == parentID)
                    {
                        AREstimateItemsInfo objEstimateItemsInfo = ToEstimateItemsInfo(item);
                        treeList.Add(objEstimateItemsInfo);
                        if (item.NumberOfChild > 0)
                        {
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            objEstimateItemsInfo.SubList = (BOSTreeList)objType;
                            objEstimateItemsInfo.SubList.InitBOSList(Module.CurrentModuleEntity, TableName.AREstimateItemsTableName, TableName.AREstimateItemsTableName);
                            this.AddProjectNormToEstimateItemList(objEstimateItemsInfo.SubList, projectNorms, item.PMProjectNormID);
                        }
                    }
                }
            }
        }

        public void RefreshTreeView(BOSTreeList treeList)
        {
            if (treeList != null && treeList.TreeListControl != null)
            {
                treeList.TreeListControl.RefreshDataSource();
                treeList.TreeListControl.ExpandAll();
            }
        }

        private AREstimateItemsInfo ToEstimateItemsInfo(PMProjectNormsInfo objProjectNormsInfo)
        {
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == objProjectNormsInfo.FK_ICProductID).FirstOrDefault();
            if (objProductsInfo == null)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objSourceProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProjectNormsInfo.FK_ICProductID);
                objProductsInfo = new ICProductsForViewInfo();
                if (objSourceProductsInfo != null) BOSUtil.CopyViewObject(objSourceProductsInfo, objProductsInfo);
            }
            AREstimateItemsInfo objEstimateItemsInfo;
            objEstimateItemsInfo = new AREstimateItemsInfo
            {
                FK_ICDepartmentID = objProjectNormsInfo.FK_ICDepartmentID,
                FK_ICProductGroupID = objProjectNormsInfo.FK_ICProductGroupID,
                FK_ICProductID = objProjectNormsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objProjectNormsInfo.FK_ICMeasureUnitID,
                FK_PMProjectID = objProjectNormsInfo.FK_PMProjectID,
                FK_PMProjectNormID = objProjectNormsInfo.PMProjectNormID,
                FK_APSupplierID = objProductsInfo.FK_APSupplierID,
                FK_PMPhaseTypeID = objProjectNormsInfo.FK_PMPhaseTypeID,
                AREstimateItemProductType = objProjectNormsInfo.PMProjectNormProductType,
                AREstimateItemProductNo = objProjectNormsInfo.PMProjectNormProductNo,
                AREstimateItemType = objProjectNormsInfo.PMProjectNormType,
                AREstimateItemProductName = objProjectNormsInfo.PMProjectNormProductName,
                AREstimateItemProductDesc = objProjectNormsInfo.PMProjectNormProductDesc,
                AREstimateItemProductUnitPrice = objProductsInfo.ICProductPrice01,
                AREstimateItemProductQty = objProjectNormsInfo.PMProjectNormProductQty,
                AREstimateItemTotalAmount = objProjectNormsInfo.PMProjectNormType == "Phase" ? 0 : (objProductsInfo.ICProductPrice01 * objProjectNormsInfo.PMProjectNormProductQty),
            };
            objEstimateItemsInfo.AREstimateItemTotalCost = objEstimateItemsInfo.AREstimateItemTotalAmount + objEstimateItemsInfo.AREstimateItemTaxAmount - objEstimateItemsInfo.AREstimateItemDiscountAmount;
            return objEstimateItemsInfo;
        }

        private AREstimateItemsInfo ToEstimateItemsInfo(PMProjectNormItemsInfo objProjectNormItemsInfo)
        {
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == objProjectNormItemsInfo.FK_ICProductID).FirstOrDefault();
            if (objProductsInfo == null)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objSourceProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProjectNormItemsInfo.FK_ICProductID);
                objProductsInfo = new ICProductsForViewInfo();
                if (objSourceProductsInfo != null) BOSUtil.CopyViewObject(objSourceProductsInfo, objProductsInfo);
            }

            AREstimateItemsInfo objEstimateItemsInfo;

            objEstimateItemsInfo = new AREstimateItemsInfo
            {
                FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID,
                FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID,
                FK_ICProductID = objProjectNormItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objProjectNormItemsInfo.FK_ICMeasureUnitID,
                FK_PMProjectID = objProjectNormItemsInfo.FK_PMProjectID,
                FK_PMProjectNormID = objProjectNormItemsInfo.FK_PMProjectNormID,
                FK_APSupplierID = objProductsInfo.FK_APSupplierID,
                AREstimateItemProductNo = objProjectNormItemsInfo.PMProjectNormItemProductNo,
                AREstimateItemType = objProjectNormItemsInfo.PMProjectNormItemType,
                AREstimateItemProductType = objProjectNormItemsInfo.PMProjectNormItemProductType,
                AREstimateItemProductName = objProjectNormItemsInfo.PMProjectNormItemProductName,
                AREstimateItemProductDesc = objProjectNormItemsInfo.PMProjectNormItemProductDesc,
                AREstimateItemProductUnitPrice = objProductsInfo.ICProductPrice01,
                AREstimateItemProductQty = objProjectNormItemsInfo.PMProjectNormItemQty,
                AREstimateItemTotalAmount = objProductsInfo.ICProductPrice01 * objProjectNormItemsInfo.PMProjectNormItemQty,
                AREstimateItemProductWorkUnitPrice = objProductsInfo.ICProductWorkUnitPrice,
                AREstimateItemProductMaterialUnitPrice = objProductsInfo.ICProductMaterialUnitPrice,
                AREstimateItemProductEquipmentUnitPrice = objProductsInfo.ICProductEquipmentUnitPrice,
                AREstimateItemWorkTotalAmount = objProductsInfo.ICProductWorkUnitPrice * objProjectNormItemsInfo.PMProjectNormItemQty,
                AREstimateItemMaterialTotalAmount = objProductsInfo.ICProductMaterialUnitPrice * objProjectNormItemsInfo.PMProjectNormItemQty,
                AREstimateItemEquipmentTotalAmount = objProductsInfo.ICProductEquipmentUnitPrice * objProjectNormItemsInfo.PMProjectNormItemQty,
            };
            objEstimateItemsInfo.AREstimateItemTotalCost = objEstimateItemsInfo.AREstimateItemTotalAmount + objEstimateItemsInfo.AREstimateItemTaxAmount - objEstimateItemsInfo.AREstimateItemDiscountAmount;
            return objEstimateItemsInfo;
        }

        public void UpdateTotalAmount()
        {
            AREstimatesInfo mainObject = (AREstimatesInfo)MainObject;
            List<AREstimateItemsInfo> estimateItemsList = new List<AREstimateItemsInfo>();
            EstimateItemsList.ConvertToList(estimateItemsList);
            mainObject.AREstimateSubTotalAmount = estimateItemsList.Where(o => o.AREstimateItemProductType == EstimateItemProductType.Work.ToString()).Sum(o => o.AREstimateItemTotalAmount)
                                                  + EstimateItemMaterialsList.Sum(o => o.AREstimateItemTotalAmount)
                                                  + EstimateItemCostsList.Sum(o => o.AREstimateItemTotalAmount);

            mainObject.AREstimateDiscountFix = mainObject.AREstimateSubTotalAmount * mainObject.AREstimateDiscountPercent / 100;

            mainObject.AREstimateTaxAmount = (mainObject.AREstimateSubTotalAmount - mainObject.AREstimateDiscountFix) * mainObject.AREstimateTaxPercent / 100;

            mainObject.AREstimateTotalAmount = mainObject.AREstimateSubTotalAmount
                                               + mainObject.AREstimateTaxAmount
                                               - mainObject.AREstimateDiscountFix;
            UpdateMainObjectBindingSource();
        }

        public bool ApproveEstimate()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                SaveModuleObjects();

                AREstimatesInfo objAREstimatesInfo = (AREstimatesInfo)MainObject;
                objAREstimatesInfo.AREstimateStatus = EstimateStatus.Approved.ToString();
                UpdateMainObject();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void InvalidateTreeList(IBOSTreeList treeList, List<AREstimateItemsInfo> collections, int parentID)
        {
            if (treeList != null && collections != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();

                foreach (AREstimateItemsInfo item in collections)
                {
                    if (item.AREstimateItemParentID == parentID)
                    {
                        AREstimateItemsInfo objEstimateItemsInfo = (AREstimateItemsInfo)item.Clone();
                        if (objEstimateItemsInfo.NumberOfChild == 0)
                            objEstimateItemsInfo.NumberOfChild = collections.Where(s => s.AREstimateItemParentID == objEstimateItemsInfo.AREstimateItemID).Count();

                        objEstimateItemsInfo.BackupObject = (AREstimateItemsInfo)objEstimateItemsInfo.Clone();
                        treeList.Add(objEstimateItemsInfo);
                        if (objEstimateItemsInfo.NumberOfChild > 0)
                        {
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            objEstimateItemsInfo.SubList = (BOSTreeList)objType;
                            objEstimateItemsInfo.SubList.InitBOSList(Module.CurrentModuleEntity, TableName.AREstimateItemsTableName, TableName.AREstimateItemsTableName);
                            this.InvalidateTreeList(objEstimateItemsInfo.SubList, collections, objEstimateItemsInfo.AREstimateItemID);
                        }
                        objEstimateItemsInfo = (AREstimateItemsInfo)item.Clone();
                        treeList.OriginalList.Add(objEstimateItemsInfo);
                        objEstimateItemsInfo = (AREstimateItemsInfo)item.Clone();
                        treeList.BackupList.Add(objEstimateItemsInfo);
                    }
                }
            }
        }
    }
}
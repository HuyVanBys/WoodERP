using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSERP.Modules.ProductionNorm.UI;
using BOSCommon;

using System.Windows.Forms;
using Localization;
using System.Data;
using DevExpress.XtraTreeList;
using BOSLib;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormModule : BaseTransactionModule
    {

        public void AddHardware()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsList = objProductsController.GetProductByProductType(ProductType.Hardware.ToString());
            if (objProductsList != null && objProductsList.Count > 0)
            {
                guiFind<ICProductsInfo> guiChooseHardware = new guiFind<ICProductsInfo>(TableName.ICProductsTableName,
                                                                                        objProductsList,
                                                                                        this,
                                                                                        true);
                guiChooseHardware.Module = this;
                if (guiChooseHardware.ShowDialog() == DialogResult.OK)
                {
                    foreach (ICProductsInfo objProductsInfo in guiChooseHardware.SelectedObjects)
                    {
                        AddItemToHardwareItemsList(objProductsInfo);
                    }
                }
            }
        }

        public void AddHardware(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                AddItemToHardwareItemsList(objProductsInfo);
                ResetHardwareListSortOrder();
            }
        }

        //TNDLoc [ADD][20/11/2015][Fix bug Hardware Sort Order],START
        public void ResetHardwareListSortOrder()
        { 
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            int sortOrder = 1;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemHardwareList)
            {
                item.MMProductionNormItemSortOrder = sortOrder++;
            }
            if (entity.ProductionNormItemHardwareList.TreeListControl != null)
            {
                entity.ProductionNormItemHardwareList.TreeListControl.RefreshDataSource();
            }
        }
        //TNDLoc [ADD][20/11/2015][Fix bug Hardware Sort Order],END

        public MMProductionNormItemsInfo AddItemToHardwareItemsList(ICProductsInfo productObject)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.Hardware.ToString());
            ICProductsController objProductsController = new ICProductsController();

            if (productObject != null)
            {
                //if (CheckValidHardware(productObject))
                //{
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = SetValueHardwareItemFromProduct(productObject);
                if (entity.ProductionNormItemHardwareList != null && entity.ProductionNormItemHardwareList.Count > 0)
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemHardwareList.Count + 1;
                else
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = 1;
                entity.ProductionNormItemHardwareList.Add(objProductionNormItemsInfo);
                entity.ProductionNormItemHardwareList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemHardwareList.TreeListControl.ExpandAll();
                entity.ProductionNormItemHardwareList.TreeListControl.BestFitColumns();
                return objProductionNormItemsInfo;
                //}
                //else
                //{
                //    MessageBox.Show(ProductionNormLocalizeResources.MatchHardwareNo, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            return null;

        }

        public bool CheckValidHardware(ICProductsInfo objProductsInfo)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemHardwareList)
            {
                if (item.MMProductionNormItemNo == objProductsInfo.ICProductNo)
                {
                    return false;
                }
            }
            return true;
        }

        public MMProductionNormItemsInfo SetValueHardwareItemFromProduct(ICProductsInfo objProductsInfo)
        {
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            objProductionNormItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProductionNormItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProductionNormItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProductionNormItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICProductName;
            objProductionNormItemsInfo.MMProductionNormItemNo = objProductsInfo.ICProductNo;
            objProductionNormItemsInfo.MMProductionNormItemNeededTime = DateTime.Now;
            objProductionNormItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            objProductionNormItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.Hardware.ToString();
            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
                objProductionNormItemsInfo.MMProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;

           // objProductionNormItemsInfo.MMProductionNormItemProductAttributeValue1 = objProductsInfo.ICProductSizeAndSpecifiCations;
            objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
            objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
           if (objProductionNormItemsInfo.SubList == null)
                objProductionNormItemsInfo.SubList = new BOSTreeList();
            return objProductionNormItemsInfo;
        }

        public void RemoveSelectedItemFromProductionNormItemHardwareList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.ProductionNormItemHardwareList.TreeListControl != null)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = entity.ProductionNormItemHardwareList.TreeListControl.GetSelectedNode();
                if (currentNode != null)
                {
                    if (currentNode.Level == 0)
                        entity.ProductionNormItemHardwareList.TreeListControl.Nodes.Remove(currentNode);
                    else
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                entity.ProductionNormItemHardwareList.TreeListControl.RefreshDataSource();
                ResetHardwareListSortOrder();
                ChangestatusToEdit(ProductType.Hardware.ToString());
            }
        }
        public void ChangeHardwareAlternative()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                if (entity.ProductionNormItemHardwareList.Count > 0)
                {
                    BOSList<MMProductionNormItemsInfo> hardwareItem = new BOSList<MMProductionNormItemsInfo>();
                    entity.ProductionNormItemHardwareList.ConvertToList(hardwareItem);
                    if (hardwareItem != null)
                    {
                        using (guiChangeHardware guiForm = new guiChangeHardware(hardwareItem))
                        {
                            guiForm.Module = this;
                            guiForm.ShowDialog();
                        }
                        HaveFocusHardware = false;
                        InvalidateProductionNormItemByProductType(ProductType.Hardware);
                    }
                }
            }
        }
		#region Hardware detail
        public void ShowProductionNormItemHardwareDetail(MMProductionNormItemsInfo objProductionNormItemsInfo, bool isView)
        {
            if (!isView)
            {
                if (Toolbar.IsNullOrNoneAction())
                {
                    MessageBox.Show("Vui lòng click sửa trước khi thực hiện!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.ProductionNormItemHardwareDetailList.Clear();
            if (!isView)
            {
                if (objProductionNormItemsInfo.MMProductionNormItemID == 0)
                {
                    MessageBox.Show("Vui lòng lưu trước khi thêm chi tiết!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (objProductionNormItemsInfo.FK_ICProductID == 0)
                {
                    MessageBox.Show("Vui lòng chọn hardware để bổ sung số lượng chi tiết!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ICProductsController objProductsController = new ICProductsController();
            if (objProductionNormItemsInfo != null)
            {
                if (!isView)
                {
                    if (Toolbar.IsNullOrNoneAction())
                        ActionEdit();
                }
                MMOperationsController objOperationsController = new MMOperationsController();
                List<MMOperationsInfo> operationList = objOperationsController.GetOperationsByGroupAndInOutStockCheck("Product", true);

                MMProductionNormItemHardwaresController objProductionNormItemHardwaresController = new MMProductionNormItemHardwaresController();
                List<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwaresInfoList = objProductionNormItemHardwaresController.
                    GetProductionNormItemHardwaresByProductionNormItemID(objProductionNormItemsInfo.MMProductionNormItemID);

                if (ProductionNormItemHardwaresInfoList == null || ProductionNormItemHardwaresInfoList.Count == 0)
                {
                    foreach (MMOperationsInfo item in operationList)
                    {
                        if (objProductionNormItemsInfo != null)
                        {
                            MMProductionNormItemHardwaresInfo objProductionNormItemMeterialsInfo = new MMProductionNormItemHardwaresInfo();
                            objProductionNormItemMeterialsInfo.FK_ICProductID = objProductionNormItemsInfo.FK_ICProductID;
                            objProductionNormItemMeterialsInfo.MMProductionNormItemHardwareProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                            objProductionNormItemMeterialsInfo.MMProductionNormItemHardwareProductDesc = objProductionNormItemsInfo.MMProductionNormItemProductDesc;
                            objProductionNormItemMeterialsInfo.FK_ICMeasureUnitID = objProductionNormItemsInfo.FK_ICMeasureUnitID;
                            objProductionNormItemMeterialsInfo.FK_MMOperationID = item.MMOperationID;
                            objProductionNormItemMeterialsInfo.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                            ProductionNormItemHardwaresInfoList.Add(objProductionNormItemMeterialsInfo);

                        }
                    }
                }
                if (ProductionNormItemHardwaresInfoList != null && ProductionNormItemHardwaresInfoList.Count > 0)
                {
                    foreach (MMProductionNormItemHardwaresInfo objProductionNormItemHardwaresInfo in ProductionNormItemHardwaresInfoList)
                    {
                        entity.ProductionNormItemHardwareDetailList.Add(objProductionNormItemHardwaresInfo);
                    }
                }
                guiProductionNormItemHardware guiForm = new guiProductionNormItemHardware(entity.ProductionNormItemHardwareDetailList, isView);
                guiForm.objProductionNormItemsInfo = objProductionNormItemsInfo;
                guiForm.Module = this;
                if (guiForm.ShowDialog() == DialogResult.OK)
                {
                    if (!isView)
                    {
                        objProductionNormItemsInfo.MMProductionNormItemQuantity = guiForm.totalQty;
                        BOSDbUtil dbUtil = new BOSDbUtil();
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, ProductionNormConst.MMProductionNormItemQuantity, objProductionNormItemsInfo.MMProductionNormItemQuantity);
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, "MMProductionNormItemHardwareAllocationQuantity", (decimal)0);
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, "MMProductionNormItemHardwareAssembleQuantity", (decimal)0);
                        entity.ProductionNormItemHardwareList.TreeListControl.RefreshDataSource();
                    }
                }
            }
        }
        #endregion

        public void InvalidateBOMHardware()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            entity.ProductionNormItemHardwareCarcassList.Clear();

            if (mainObject.FK_ICProductID != mainObject.FK_ICProductCarcassID)
            {
                MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> collection = productItemController.GetCarcassByProductIDHardware(mainObject.FK_ICProductCarcassID);

                if (collection != null && collection.Any())
                {
                    entity.ProductionNormItemHardwareCarcassList.Invalidate(collection, 0);
                }

            }
            RefreshProductItemTreeListView(entity.ProductionNormItemHardwareCarcassList);
        }
    }
}

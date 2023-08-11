using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSERP.MES.Modules.ProductionNorm.UI;
using BOSCommon;
using BOSERP.MES.Modules.MM.ProductionNorm.Localization;
using System.Windows.Forms;
using Localization;
using System.Data;
using DevExpress.XtraTreeList;
using BOSLib;

namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class ProductionNormModule : BaseTransactionModule
    {
        public void InvalidateEquipmentLookupEditDataSource()
        {
            ICProductsController objProductsController = new ICProductsController();
            EquipmentLookupEditControl.Properties.DataSource = objProductsController.GetListProductByProductType(ProductType.Equipment.ToString());
            EquipmentLookupEditControl.Properties.DisplayMember = "ICProductName";
            EquipmentLookupEditControl.Properties.ValueMember = "ICProductID";
        }

        public void AddProductEquipment(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                AddItemToEquipmentItemsList(objProductsInfo);
                ResetEquipmentListSortOrder();
            }
        }

        public MMProductionNormItemsInfo AddItemToEquipmentItemsList(ICProductsInfo productObject)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.Equipment.ToString());
            ICProductsController objProductsController = new ICProductsController();

            if (productObject != null)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = SetValueEquipmentItemFromProduct(productObject);
                if (entity.ProductionNormItemEquipmentList != null && entity.ProductionNormItemEquipmentList.Count > 0)
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemEquipmentList.Count + 1;
                else
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = 1;
                entity.ProductionNormItemEquipmentList.Add(objProductionNormItemsInfo);
                entity.ProductionNormItemEquipmentList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemEquipmentList.TreeListControl.ExpandAll();
                entity.ProductionNormItemEquipmentList.TreeListControl.BestFitColumns();
                return objProductionNormItemsInfo;
            }
            return null;

        }

        public void ResetEquipmentListSortOrder()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            int sortOrder = 1;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemEquipmentList)
            {
                item.MMProductionNormItemSortOrder = sortOrder++;
            }
            if (entity.ProductionNormItemEquipmentList.TreeListControl != null)
            {
                entity.ProductionNormItemEquipmentList.TreeListControl.RefreshDataSource();
            }
        }

        public MMProductionNormItemsInfo SetValueEquipmentItemFromProduct(ICProductsInfo objProductsInfo)
        {
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            objProductionNormItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProductionNormItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProductionNormItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProductionNormItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICProductName;
            objProductionNormItemsInfo.MMProductionNormItemNo = objProductsInfo.ICProductNo;
            objProductionNormItemsInfo.MMProductionNormItemNeededTime = BOSApp.GetCurrentServerDate();
            objProductionNormItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            objProductionNormItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.Equipment.ToString();
            
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
                objProductionNormItemsInfo.MMProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;

            objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
            objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            if (objProductionNormItemsInfo.SubList == null)
                objProductionNormItemsInfo.SubList = new BOSTreeList();
            return objProductionNormItemsInfo;
        }

        #region Hardware detail
        public void ShowProductionNormItemEquipmentDetail(MMProductionNormItemsInfo objProductionNormItemsInfo)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.ProductionNormItemEquipmentDetailList.Clear();
            if (objProductionNormItemsInfo.MMProductionNormItemID == 0)
            {
                MessageBox.Show("Vui lòng lưu trước khi thêm chi tiết!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (objProductionNormItemsInfo.FK_ICProductID == 0)
            {
                MessageBox.Show("Vui lòng chọn vật tư để bổ sung số lượng chi tiết!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ICProductsController objProductsController = new ICProductsController();
            if (objProductionNormItemsInfo != null)
            {
                if (Toolbar.IsNullOrNoneAction())
                    ActionEdit();
                MMOperationsController objOperationsController = new MMOperationsController();
                List<MMOperationsInfo> operationList = objOperationsController.GetOperationsByGroupAndInOutStockCheck("Product", true);

                MMProductionNormItemEquipmentsController objProductionNormItemEquipmentsController = new MMProductionNormItemEquipmentsController();
                List<MMProductionNormItemEquipmentsInfo> productionNormItemEquipmentsList = objProductionNormItemEquipmentsController.GetProductionNormItemEquipmentsByProductionNormItemID(objProductionNormItemsInfo.MMProductionNormItemID);

                if (productionNormItemEquipmentsList == null || productionNormItemEquipmentsList.Count == 0)
                {
                    foreach (MMOperationsInfo item in operationList)
                    {
                        if (objProductionNormItemsInfo != null)
                        {
                            MMProductionNormItemEquipmentsInfo objMMProductionNormItemEquipmentsInfo = new MMProductionNormItemEquipmentsInfo();
                            objMMProductionNormItemEquipmentsInfo.FK_ICProductID = objProductionNormItemsInfo.FK_ICProductID;
                            objMMProductionNormItemEquipmentsInfo.MMProductionNormItemEquipmentProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                            objMMProductionNormItemEquipmentsInfo.MMProductionNormItemEquipmentProductDesc = objProductionNormItemsInfo.MMProductionNormItemProductDesc;
                            objMMProductionNormItemEquipmentsInfo.FK_ICMeasureUnitID = objProductionNormItemsInfo.FK_ICMeasureUnitID;
                            objMMProductionNormItemEquipmentsInfo.FK_MMOperationID = item.MMOperationID;
                            objMMProductionNormItemEquipmentsInfo.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                            productionNormItemEquipmentsList.Add(objMMProductionNormItemEquipmentsInfo);

                        }
                    }
                }

                if (productionNormItemEquipmentsList != null && productionNormItemEquipmentsList.Count > 0)
                {
                    foreach (MMProductionNormItemEquipmentsInfo objMMProductionNormItemEquipmentsInfo in productionNormItemEquipmentsList)
                    {
                        entity.ProductionNormItemEquipmentDetailList.Add(objMMProductionNormItemEquipmentsInfo);
                    }
                }

                guiProductionNormItemEquipment guiForm = new guiProductionNormItemEquipment(entity.ProductionNormItemEquipmentDetailList);
                guiForm.Module = this;
                if (guiForm.ShowDialog() == DialogResult.OK)
                {
                    objProductionNormItemsInfo.MMProductionNormItemQuantity = guiForm.totalQty;
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    dbUtil.SetPropertyValue(objProductionNormItemsInfo, ProductionNormConst.MMProductionNormItemQuantity, objProductionNormItemsInfo.MMProductionNormItemQuantity);
                    entity.ProductionNormItemEquipmentList.TreeListControl.RefreshDataSource();
                }
            }
        }
        #endregion

        public void RemoveSelectedItemFromProductionNormItemEquipmentList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.ProductionNormItemEquipmentList.TreeListControl != null)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = entity.ProductionNormItemEquipmentList.TreeListControl.GetSelectedNode();
                if (currentNode != null)
                {
                    if (currentNode.Level == 0)
                        entity.ProductionNormItemEquipmentList.TreeListControl.Nodes.Remove(currentNode);
                    else
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                entity.ProductionNormItemEquipmentList.TreeListControl.RefreshDataSource();
                ResetEquipmentListSortOrder();
                ChangestatusToEdit(ProductType.Equipment.ToString());
            }
        }

        public void ChangeStatusEquipmentToReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangeStatusEquipment, MMProductionNormStatus.Validated);
        }

        public void ChangeStatusEquipmentUnReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangeStatusEquipment, MMProductionNormStatus.UnValidated);
        }

        public void ChangeStatusEquipmentReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangeStatusEquipment, MMProductionNormStatus.Approved);
        }

        public void ChangeStatusEquipmentUnReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangeStatusEquipment, MMProductionNormStatus.UnApproved);
        }
    }
}

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

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormModule : BaseTransactionModule
    {
        public void AddPLDGParent(string productIDList)
        {
            ICProductsController objProductsController = new ICProductsController();
            string[] productIDs = productIDList.Split(',');
            //reset repeat: variable to check exit
            repeat = false;
            foreach (string productIDStr in productIDs)
            {
                int productID = 0;
                if (int.TryParse(productIDStr.Trim(), out productID))
                {
                    //Change by FromNormProduct
                    //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                    //if (objProductsInfo != null)
                    //{
                    //    AddPLDGParentToPackagingItemsList(objProductsInfo);
                    //}
                   
                    AddPLDGFromNormProduct(productID, true);
                }
            }
        }
        public bool repeat = false;
        public void AddPLDGFromNormProduct(int productID, bool isPackProduct)
        {
            if (IsEditable())
                ActionEdit();
            ChangestatusToEdit(ProductType.IngredientPackaging.ToString());
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
           
            ICPackagingNormItemsController objPackagingNormItemsController = new ICPackagingNormItemsController();
            if (productID > 0)
            {
                List<ICPackagingNormItemsInfo> packList;
                    if(!isPackProduct)
                        packList  = objPackagingNormItemsController.GetPackagingNormItemByParentProduct(productID);
                    else
                        packList = objPackagingNormItemsController.GetPackagingNormItemByPackProduct(productID);
                if (packList != null && packList.Count > 0)
                {
                    List<ICPackagingNormItemsInfo> packParentList = packList.Where(p => p.FK_ICProductID == p.FK_ICProductParentID).ToList();
                    packParentList.ForEach(p => 
                    {
                        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                        bool updateParent = false;
                        
                        //Check Exits Parent
                        entity.ProductionNormItemPackagingList.ForEach(pack =>
                            {
                                MMProductionNormItemsInfo objExit = (MMProductionNormItemsInfo)pack;
                                if (objExit.FK_ICProductID == p.FK_ICProductID)
                                {
                                    
                                    DialogResult dlgResult = DialogResult.No;
                                    if (!repeat)
                                    {
                                        dlgResult = MessageBox.Show(string.Format(ProductionNormLocalizeResources.MaterialExitsInListMessage, p.ICPackagingNormItemProductDesc)
                                               + Environment.NewLine + "Cancel: Cập nhật và không hỏi lại"
                                               + Environment.NewLine + "Yes: Thêm mới"
                                               + Environment.NewLine + "No: Thoát"
                                              , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                    }
                                    if (dlgResult == DialogResult.Cancel)
                                    {
                                        objProductionNormItemsInfo = objExit;
                                        repeat = true;
                                        updateParent = true;
                                    }
                                    else if (dlgResult == DialogResult.No)
                                    {
                                        return;
                                    }
                                }
                            }
                            );

                        SetValuePackagingItemFromNormProduct(p, p.ICPackagingNormItemProductName,objProductionNormItemsInfo);
                        objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
                        objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemPackagingList.Count;
                        objProductionNormItemsInfo.MMProductionNormItemQuantity = p.ICPackagingNormItemProductQty;
                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = true;
                        
                        List<ICPackagingNormItemsInfo> packChilrentList = packList.Where(c => c.FK_ICProductParentID == p.FK_ICProductID
                                                                                        && c.FK_ICProductID != p.FK_ICProductID).ToList();
                        if (packChilrentList != null && packChilrentList.Count > 0)
                        {
                            packChilrentList.ForEach(c =>
                                {
                                    if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.SubList == null)
                                    {
                                        objProductionNormItemsInfo.SubList = new BOSTreeList();
                                        objProductionNormItemsInfo.HasChildren();
                                    }

                                    MMProductionNormItemsInfo objProductionNormItemChildsInfo = new MMProductionNormItemsInfo();
                                    bool existChild = false;
                                    if (updateParent )
                                    {
                                        if (objProductionNormItemsInfo.SubList != null && objProductionNormItemsInfo.SubList.Count > 0)
                                        {
                                            foreach (MMProductionNormItemsInfo itemChild in objProductionNormItemsInfo.SubList)
                                            {
                                                if (itemChild.FK_ICProductID == c.FK_ICProductID)
                                                {
                                                    objProductionNormItemChildsInfo = itemChild;
                                                    existChild = true;
                                                    break;
                                                }
                                            } 
                                        }
                                    }
                                    SetValuePackagingItemFromNormProduct(c, p.ICPackagingNormItemProductName, objProductionNormItemChildsInfo);
                                    objProductionNormItemChildsInfo.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
                                    objProductionNormItemChildsInfo.MMProductionNormItemIsComponent = false;
                                    objProductionNormItemChildsInfo.MMProductionNormItemSortOrder = objProductionNormItemsInfo.SubList.Count;
                                    objProductionNormItemChildsInfo.MMProductionNormItemQuantity = c.ICPackagingNormItemProductQty;
                                    if (!existChild)
                                        objProductionNormItemsInfo.SubList.Add(objProductionNormItemChildsInfo);
                                }
                            );
                        }
                        if (!updateParent)
                            entity.ProductionNormItemPackagingList.Add(objProductionNormItemsInfo);
                    }
                    );
                }
            }
            RefreshPackagingItemList();
        }
        public void AddPLDGChild(string productIDList)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.ProductionNormItemPackagingList.CurrentObject != null)
            {
                MMProductionNormItemsInfo currentItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemPackagingList.CurrentObject;
                if (currentItemsInfo.MMProductionNormItemIsComponent)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    string[] productIDs = productIDList.Split(',');
                    foreach (string productIDStr in productIDs)
                    {
                        int productID = 0;
                        if (int.TryParse(productIDStr.Trim(), out productID))
                        {
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                            if (objProductsInfo != null)
                            {
                                AddPLDGChildToPackagingItemsList(objProductsInfo);
                            }
                        }
                    }
                }
            }

        }

        public MMProductionNormItemsInfo SetValuePackagingItemFromProduct(ICProductsInfo objProductsInfo, string ProductName)
        {
            MMProductionNormItemsInfo objPackagingItemsInfo = new MMProductionNormItemsInfo();
            MMProductionNormItemsInfo objToGetPackagingItemsInfo = new MMProductionNormItemsInfo();
            string heightOrThick = string.Empty;
            objPackagingItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objPackagingItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICProductName;
            objPackagingItemsInfo.MMProductionNormItemNo = objProductsInfo.ICProductNo;
            objPackagingItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc.Trim();
            objPackagingItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objPackagingItemsInfo.MMProductionNormItemProductLength = objProductsInfo.ICProductLength;
            objPackagingItemsInfo.MMProductionNormItemProductWidth = objProductsInfo.ICProductWidth;
            objPackagingItemsInfo.MMProductionNormItemPackagingNW = objProductsInfo.ICProductNetWeight;
            objPackagingItemsInfo.MMProductionNormItemPackagingGW = objProductsInfo.ICProductGrossWeight;
            objPackagingItemsInfo.MMProductionNormItemProductInsideDimensionLength = objProductsInfo.ICProductInsideDimensionLength;
            objPackagingItemsInfo.MMProductionNormItemProductInsideDimensionWidth = objProductsInfo.ICProductInsideDimensionWidth;
            objPackagingItemsInfo.MMProductionNormItemProductInsideDimensionHeight = objProductsInfo.ICProductInsideDimensionHeight;
            objPackagingItemsInfo.MMProductionNormItemProductOverallDimensionLength = objProductsInfo.ICProductOverallDimensionLength;
            objPackagingItemsInfo.MMProductionNormItemProductOverallDimensionWidth = objProductsInfo.ICProductOverallDimensionWidth;
            objPackagingItemsInfo.MMProductionNormItemProductOverallDimensionHeight = objProductsInfo.ICProductOverallDimensionHeight;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSpecialityID = objProductsInfo.FK_ICProdAttPackingMaterialSpecialityID;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSizeID = objProductsInfo.FK_ICProdAttPackingMaterialSizeID;
            objPackagingItemsInfo.MMProductionNormItemNeededTime = DateTime.Now;
            objPackagingItemsInfo.MMProductionNormItemParentOrderName = ProductName;
            objPackagingItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objPackagingItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            if (objProductsInfo.ICProductHeight != 0)
                objPackagingItemsInfo.MMProductionNormItemProductHeight = objProductsInfo.ICProductHeight;

            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
            {
                objPackagingItemsInfo.MMProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;
                objPackagingItemsInfo.FK_ICMeasureUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }

            objPackagingItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc.Trim();
            //  objPackagingItemsInfo.MMProductionNormItemPackagingGW = objProductsInfo.ICProductGW.ToString();
            // objPackagingItemsInfo.MMProductionNormItemPackagingNW = objProductsInfo.ICProductNW.ToString();
            objPackagingItemsInfo.MMProductionNormItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
            //   objPackagingItemsInfo.MMProductionNormItemProductAttributeValue3 = objProductsInfo.ICProductOverallDimension;
            //objPackagingItemsInfo.MMProductionNormItemProductAttributeValue6 = objProductsInfo.ICProductInsideDimension;

            if (objPackagingItemsInfo.SubList == null)
                objPackagingItemsInfo.SubList = new BOSTreeList();
            return objPackagingItemsInfo;
        }

        public MMProductionNormItemsInfo SetValuePackagingItemFromNormProduct(ICPackagingNormItemsInfo objProductsInfo, string ProductName,MMProductionNormItemsInfo objPackagingItemsInfo)
        {
            objPackagingItemsInfo.FK_ICProductID = objProductsInfo.FK_ICProductID;
            objPackagingItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICPackagingNormItemProductName;
            objPackagingItemsInfo.MMProductionNormItemNo = objProductsInfo.ICPackagingNormItemNo;
            objPackagingItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICPackagingNormItemProductDesc.Trim();
            objPackagingItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objPackagingItemsInfo.MMProductionNormItemPackagingNW = objProductsInfo.ICPackagingNormItemPackagingNW;
            objPackagingItemsInfo.MMProductionNormItemPackagingGW = objProductsInfo.ICPackagingNormItemPackagingGW;
            objPackagingItemsInfo.MMProductionNormItemProductSizeAndPacking = objProductsInfo.ICPackagingNormItemProductSizeAndPacking;
            objPackagingItemsInfo.MMProductionNormItemComment = objProductsInfo.ICPackagingNormItemComment;
            objPackagingItemsInfo.MMProductionNormItemProductInsideDimensionLength = objProductsInfo.ICPackagingNormItemProductInsideDimensionLength;
            objPackagingItemsInfo.MMProductionNormItemProductInsideDimensionWidth = objProductsInfo.ICPackagingNormItemProductInsideDimensionWidth;
            objPackagingItemsInfo.MMProductionNormItemProductInsideDimensionHeight = objProductsInfo.ICPackagingNormItemProductInsideDimensionHeight;
            objPackagingItemsInfo.MMProductionNormItemProductOverallDimensionLength = objProductsInfo.ICPackagingNormItemProductOverallDimensionLength;
            objPackagingItemsInfo.MMProductionNormItemProductOverallDimensionWidth = objProductsInfo.ICPackagingNormItemProductOverallDimensionWidth;
            objPackagingItemsInfo.MMProductionNormItemProductOverallDimensionHeight = objProductsInfo.ICPackagingNormItemProductOverallDimensionHeight;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSpecialityID = objProductsInfo.FK_ICProdAttPackingMaterialSpecialityID;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSizeID = objProductsInfo.FK_ICProdAttPackingMaterialSizeID;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID = objProductsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID;
            objPackagingItemsInfo.MMProductionNormItemNeededTime = DateTime.Now;
            objPackagingItemsInfo.MMProductionNormItemParentOrderName = ProductName;
            objPackagingItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objPackagingItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objPackagingItemsInfo.MMProductionNormItemUnit = objProductsInfo.ICMeasureUnitName;
            objPackagingItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICMeasureUnitID;
            if (objPackagingItemsInfo.SubList == null)
                objPackagingItemsInfo.SubList = new BOSTreeList();
            return objPackagingItemsInfo;
        }

        public List<MMProductionNormItemsInfo> GetProductionNormItemPackagingListFromProductHasComponent(ICProductsInfo objProductsInfo)
        {
            List<MMProductionNormItemsInfo> productionNormItemList = new List<MMProductionNormItemsInfo>();
            ICProductItemsController productItemController = new ICProductItemsController();
            List<ICProductItemsInfo> productItems = productItemController.GetProductItemListByProductID(objProductsInfo.ICProductID);
            ICProductsController objProductsController = new ICProductsController();
            if (productItems.Count > 0)
            {
                foreach (ICProductItemsInfo productItem in productItems)
                {
                    ICProductsInfo productComponentObject = new ICProductsInfo();
                    productComponentObject = (ICProductsInfo)objProductsController.GetObjectByID(productItem.FK_ICProductItemChildID);
                    if (productComponentObject != null)
                    {
                        MMProductionNormItemsInfo objProductionNormItemsHasComponentInfo = new MMProductionNormItemsInfo();
                        MMProductionNormItemsInfo objToGetProductionNormItemsInfo = new MMProductionNormItemsInfo();

                        objProductionNormItemsHasComponentInfo = SetValuePackagingItemFromProduct(productComponentObject, objProductsInfo.ICProductName);
                        objProductionNormItemsHasComponentInfo.MMProductionNormItemQuantity = productItem.ICProductItemQty;
                        objProductionNormItemsHasComponentInfo.MMProductionNormItemParentNo = objProductsInfo.ICProductNo;
                        productionNormItemList.Add(objProductionNormItemsHasComponentInfo);
                    }
                }
            }

            return productionNormItemList;
        }

        public void RefreshPackagingItemList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;

            entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
            entity.ProductionNormItemPackagingList.TreeListControl.ForceInitialize();
            entity.ProductionNormItemPackagingList.TreeListControl.DragNodesMode = TreeListDragNodesMode.Advanced;
            entity.ProductionNormItemPackagingList.TreeListControl.OptionsBehavior.CanCloneNodesOnDrop = false;
            entity.ProductionNormItemPackagingList.TreeListControl.OptionsBehavior.AutoChangeParent = false;
            entity.ProductionNormItemPackagingList.TreeListControl.ClearSorting();
            entity.ProductionNormItemPackagingList.TreeListControl.Columns["MMProductionNormItemSortOrder"].SortOrder = SortOrder.Ascending;
            entity.ProductionNormItemPackagingList.TreeListControl.ExpandAll();
            entity.ProductionNormItemPackagingList.TreeListControl.BestFitColumns();

            //SetDefaultCartonDemesion();
            CalculateProductionNormItemPackaging(string.Empty);
        }

        public void AddPLDGParentToPackagingItemsList(ICProductsInfo productObject)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.IngredientPackaging.ToString());
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            decimal productItemQty = productObject.ICProductItemQty;
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            objProductionNormItemsInfo = SetValuePackagingItemFromProduct(productObject, productObject.ICProductName);
            objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
            objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemPackagingList.Count;
            objProductionNormItemsInfo.MMProductionNormItemIsComponent = true;
            if (productItemQty > 0)
            {
                objProductionNormItemsInfo.MMProductionNormItemQuantity = productItemQty;
            }
            entity.ProductionNormItemPackagingList.Add(objProductionNormItemsInfo);
            RefreshPackagingItemList();
        }

        public void AddPLDGChildToPackagingItemsList(ICProductsInfo productObject)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.IngredientPackaging.ToString());
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            List<MMProductionNormItemsInfo> currentPackagingItemsList = new List<MMProductionNormItemsInfo>();

            if (entity.ProductionNormItemPackagingList.CurrentObject != null && entity.ProductionNormItemPackagingList.CurrentObject.SubList == null)
            {
                entity.ProductionNormItemPackagingList.CurrentObject.SubList = new BOSTreeList();
                entity.ProductionNormItemPackagingList.CurrentObject.HasChildren();
            }

            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            objProductionNormItemsInfo = SetValuePackagingItemFromProduct(productObject, productObject.ICProductName);
            objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
            objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
            objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemPackagingList.CurrentObject.SubList.Count;
            entity.ProductionNormItemPackagingList.CurrentObject.SubList.Add(objProductionNormItemsInfo);
            RefreshPackagingItemList();

        }

        //public void AddItemToPackagingItemsList(ICProductsInfo productObject)
        //{
        //    if (IsEditable())
        //        ActionEdit();
        //    ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
        //    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;

        //    List<MMProductionNormItemsInfo> currentPackagingItemsList = new List<MMProductionNormItemsInfo>();

        //    if (productObject != null)
        //    {
        //        decimal productItemQty = productObject.ICProductItemQty;
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = SetValuePackagingItemFromProduct(productObject, productObject.ICProductName);
        //        objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
        //       // UpdateValuePackagingItems(objProductionNormItemsInfo);

        //        //Add group
        //        if (productObject.FK_ICProductGroupParentID == 0)
        //        {
        //            MMProductionNormItemsInfo objProductionNormItemParentsInfo = new MMProductionNormItemsInfo();
        //            List<MMProductionNormItemsInfo> productionNormItemList = GetProductionNormItemPackagingListFromProductHasComponent(productObject);
        //            if (productionNormItemList != null && productionNormItemList.Count > 0)
        //            {

        //                if (objProductionNormItemParentsInfo.SubList == null)
        //                    objProductionNormItemParentsInfo.SubList = new BOSTreeList();
        //            }
        //            objProductionNormItemParentsInfo = SetValuePackagingItemFromProduct(productObject, productObject.ICProductName);
        //            objProductionNormItemParentsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemPackagingList.Count;
        //            objProductionNormItemParentsInfo.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();

        //            if (productObject.HasComponent)
        //                objProductionNormItemParentsInfo.MMProductionNormItemIsComponent = true;
        //            else
        //                objProductionNormItemParentsInfo.MMProductionNormItemIsComponent = false;
        //            if (productItemQty > 0)
        //            {
        //                objProductionNormItemParentsInfo.MMProductionNormItemQuantity = productItemQty;
        //            }


        //            //if (ProductionNormComponentNo != string.Empty)
        //            //{
        //            //    foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
        //            //    {
        //            //        //if(item.MMProductionNormItemNo == currentItem.MMProductionNormItemNo)
        //            //        if (item.MMProductionNormItemNo == ProductionNormComponentNo)
        //            //        {
        //            //            if (item.SubList == null)
        //            //                item.SubList = new BOSTreeList();
        //            //            objProductionNormItemParentsInfo.MMProductionNormItemSortOrder = item.SubList.Count;
        //            //            objProductionNormItemParentsInfo.MMProductionNormItemIsComponent = false;
        //            //            item.SubList.Add(objProductionNormItemParentsInfo);
        //            //        }
        //            //    }
        //            //    ProductionNormItemGroupLookupEdit.EditValue = string.Empty;
        //            //}
        //            //else
        //                entity.ProductionNormItemPackagingList.Add(objProductionNormItemParentsInfo);

        //            if (entity.ProductionNormItemPackagingList.CurrentObject != null && entity.ProductionNormItemPackagingList.CurrentObject.SubList == null)
        //            {
        //                entity.ProductionNormItemPackagingList.CurrentObject.SubList = new BOSTreeList();
        //                entity.ProductionNormItemPackagingList.CurrentObject.HasChildren();
        //            }
        //            int sortOrder = 0;
        //            foreach (MMProductionNormItemsInfo item in productionNormItemList)
        //            {
        //                foreach (MMProductionNormItemsInfo parentItem in entity.ProductionNormItemPackagingList)
        //                {
        //                    if (item.MMProductionNormItemParentNo == parentItem.MMProductionNormItemNo)
        //                    {
        //                        if (item.SubList == null)
        //                            item.SubList = new BOSTreeList();
        //                        if (parentItem.SubList == null)
        //                            parentItem.SubList = new BOSTreeList();
        //                        item.MMProductionNormItemSortOrder = sortOrder;
        //                        item.MMProductionNormItemIsComponent = false;
        //                        item.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
        //                        parentItem.SubList.Add(item);

        //                    }
        //                }
        //                sortOrder++;
        //            }

        //        }
        //        //Add detail
        //        else
        //        {
        //            //Get Product groups 

        //            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
        //            objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(productObject.FK_ICProductGroupID);

        //            if (objProductionNormItemsInfo.SubList == null)
        //                objProductionNormItemsInfo.SubList = new BOSTreeList();

        //            //if (ProductionNormComponentNo != string.Empty)
        //            //{
        //            //    if (productObject.FK_ICProductGroupParentID > 0)
        //            //    {
        //            //        foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
        //            //        {
        //            //            //if(item.MMProductionNormItemNo == currentItem.MMProductionNormItemNo)
        //            //            if (item.MMProductionNormItemNo == ProductionNormComponentNo)
        //            //            {
        //            //                if (item.SubList == null)
        //            //                    item.SubList = new BOSTreeList();
        //            //                objProductionNormItemsInfo.MMProductionNormItemSortOrder = item.SubList.Count;
        //            //                objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
        //            //                objProductionNormItemsInfo.MMProductionNormItemParentOrderName = item.MMProductionNormItemICProductName;
        //            //                objProductionNormItemsInfo.MMProductionNormItemParentNo = item.MMProductionNormItemNo;
        //            //                item.SubList.Add(objProductionNormItemsInfo);
        //            //            }
        //            //        }
        //            //        ProductionNormItemGroupPackagingLookupEdit.EditValue = string.Empty;
        //            //    }
        //            //}
        //            //else
        //            //{
        //                if (productObject.FK_ICProductGroupParentID == 0)
        //                {
        //                    if (productObject.HasComponent)
        //                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = true;
        //                    else
        //                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
        //                    objProductionNormItemsInfo.MMProductionNormItemParentNo = productObject.ICProductName;
        //                    entity.ProductionNormItemPackagingList.Add(objProductionNormItemsInfo);
        //                }
        //                else
        //                {
        //                    objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
        //                    objProductionNormItemsInfo.MMProductionNormItemParentNo = productObject.ICProductName;
        //                    entity.ProductionNormItemPackagingList.Add(objProductionNormItemsInfo);
        //                }
        //            //}

        //        }
        //        entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
        //        entity.ProductionNormItemPackagingList.TreeListControl.ForceInitialize();
        //        entity.ProductionNormItemPackagingList.TreeListControl.DragNodesMode = TreeListDragNodesMode.Advanced;
        //        entity.ProductionNormItemPackagingList.TreeListControl.OptionsBehavior.CanCloneNodesOnDrop = false;
        //        entity.ProductionNormItemPackagingList.TreeListControl.OptionsBehavior.AutoChangeParent = false;
        //        entity.ProductionNormItemPackagingList.TreeListControl.ClearSorting();
        //        entity.ProductionNormItemPackagingList.TreeListControl.Columns["MMProductionNormItemSortOrder"].SortOrder = SortOrder.Ascending;
        //        entity.ProductionNormItemPackagingList.TreeListControl.ExpandAll();
        //        entity.ProductionNormItemPackagingList.TreeListControl.BestFitColumns();

        //        SetDefaultCartonDemesion();
        //        CalculateProductionNormItemPackaging();

        //    }

        //}
        public int ProductGroupParent(ICProductGroupsInfo objProductGroupsInfo)
        {
            int result = 0;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductGroupsInfo objICProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductGroupsInfo.ICProductGroupParentID);

            if (objICProductGroupsInfo != null && objICProductGroupsInfo.ICProductGroupParentID > 0)
            {
                result = ProductGroupParent(objICProductGroupsInfo);

                if (result > 0)
                {
                    return result;
                }
            }
            else if (objICProductGroupsInfo != null && objICProductGroupsInfo.ICProductGroupParentID == 0)
                result = objICProductGroupsInfo.ICProductGroupID;
            else
            {
                result = objProductGroupsInfo.ICProductGroupID;
            }

            return result;
        }
        //public void SetDefaultCartonDemesion()
        //{
        //    ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
        //    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
        //    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
        //    ICProductsController objProductsController = new ICProductsController();
        //    ICProductsInfo productObject = new ICProductsInfo();
        //    objProductionNormsInfo.MMProductionNormOverallDimension = string.Empty;
        //    objProductionNormsInfo.MMProductionNormInsideDimension = string.Empty;
        //    //Set default Carton demension
        //    foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
        //    {
        //        productObject = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
        //        if (productObject != null)
        //        {
        //            ICProductGroupsInfo objICProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(productObject.FK_ICProductGroupID);
        //            if (objICProductGroupsInfo != null)
        //            {
        //                int productGroup = ProductGroupParent(objICProductGroupsInfo);
        //                if (productGroup == BOSCommon.ProductGroup.ProductGroupCartonID)
        //                {
        //                    if (objProductionNormsInfo.MMProductionNormOverallDimension != string.Empty)
        //                    {
        //                        // if (item.MMProductionNormItemProductAttributeValue3 != string.Empty)
        //                        objProductionNormsInfo.MMProductionNormOverallDimension = objProductionNormsInfo.MMProductionNormOverallDimension + ";" +
        //                            GetOverallDimension(item);
        //                    }
        //                    else
        //                        objProductionNormsInfo.MMProductionNormOverallDimension = GetOverallDimension(item);

        //                    if (objProductionNormsInfo.MMProductionNormInsideDimension != string.Empty)
        //                    {

        //                        objProductionNormsInfo.MMProductionNormInsideDimension = objProductionNormsInfo.MMProductionNormInsideDimension + ";" +
        //                            GetInsideDimension(item);
        //                    }
        //                    else
        //                        objProductionNormsInfo.MMProductionNormInsideDimension = GetInsideDimension(item);
        //                }
        //            }
        //        }
        //    }
        //}
        public string GetOverallDimension(MMProductionNormItemsInfo item)
        {
            string result = string.Empty;
            result += (int)item.MMProductionNormItemProductOverallDimensionLength + "x";
            result += (int)item.MMProductionNormItemProductOverallDimensionWidth + "x";
            result += (int)item.MMProductionNormItemProductOverallDimensionHeight;
            return result;
        }
        public string GetInsideDimension(MMProductionNormItemsInfo item)
        {
            string result = string.Empty;
            result += (int)item.MMProductionNormItemProductInsideDimensionLength + "x";
            result += (int)item.MMProductionNormItemProductInsideDimensionWidth + "x";
            result += (int)item.MMProductionNormItemProductInsideDimensionHeight;
            return result;
        }

        public void InitPackagingList(bool isRefreshChildList)
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (objProductionNormsInfo.FK_ICProductID > 0)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    string productNo = string.Empty;
                    int getLength = 0;
                    string[] productNos = objProductsInfo.ICProductNo.Split('.');
                    if (productNos.Length > 0)
                    {
                        productNo = productNos[0];

                    }

                    if (!string.IsNullOrEmpty(productNo))
                    {
                        productNo = BOSCommon.ProductGroup.PackagingNo + "." + productNo;
                        getLength = productNo.Length;
                        List<ICProductsInfo> semiProductsList = objProductsController.GetSemiProductByProductNo(productNo, ProductType.IngredientPackaging.ToString());

                        List<ICProductsInfo> semiProductsListNotMatch = new List<ICProductsInfo>();

                        #region Filter match item
                        foreach (ICProductsInfo item in semiProductsList)
                        {
                            bool isExist = false;
                            foreach (ICProductsInfo objProduct in semiProductsListNotMatch)
                            {
                                if (objProduct.ICProductID == item.ICProductID)
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                            if (!isExist)
                            {
                                semiProductsListNotMatch.Add(item);
                            }
                        }
                        #endregion

                        entity.SemiProductList.Invalidate(semiProductsListNotMatch);
                        entity.SemiProductList.OrderBy(t => t.ICProductNo);
                        entity.SemiProductList.GridControl.RefreshDataSource();
                        //
                        if (isRefreshChildList)
                        {
                            entity.SemiProductListChild.Invalidate(semiProductsListNotMatch);

                            entity.SemiProductListChild.OrderBy(t => t.ICProductNo);
                            if (entity.SemiProductListChild.GridControl != null)
                            {
                                entity.SemiProductListChild.GridControl.RefreshDataSource();
                            }
                        }
                    }
                }
            }

        }

        public void AddNewPackagingItem()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (objProductionNormsInfo.FK_ICProductID > 0)
            {
                guiAddSemiProduct guiAddNew = new guiAddSemiProduct(objProductionNormsInfo.FK_ICProductID);
                guiAddNew.Module = this;
                guiAddNew.ObjectType = ProductType.IngredientPackaging.ToString();
                guiAddNew.ShowDialog();
            }
        }

        public void InitPackagingProduct()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.SemiProductListParent.Clear();

            foreach (ICProductsInfo semiProductsInfo in entity.SemiProductList)
            {
                if (semiProductsInfo.FK_ICProductGroupID == ProductionNormConst.MMProductionNormCum)
                {
                    entity.SemiProductListParent.Add(semiProductsInfo);
                }
            }
            entity.SemiProductListParent.GridControl.RefreshDataSource();

        }

        public void AddNewPackagingProductParent()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsInfo objSemiProductParentsInfo = new ICProductsInfo();
            objSemiProductParentsInfo.FK_ICDepartmentID = ProductionNormConst.MMProductionNormPackagingProductDepartment;
            objSemiProductParentsInfo.HasComponent = true;
            objSemiProductParentsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormCum;
            objSemiProductParentsInfo.ICProductType = ProductType.IngredientPackaging.ToString();
            entity.SemiProductListParent.Add(objSemiProductParentsInfo);
            entity.SemiProductListParent.GridControl.RefreshDataSource();

        }

        public void SavePackagingProductDetail()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            ICProductItemsController objProductItemsController = new ICProductItemsController();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            ICProductsInfo objMainProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
            foreach (ICProductsInfo objProductsInfo in entity.SemiProductListChild)
            {
                if (objProductsInfo.FK_ICProductGroupID == ProductionNormConst.MMProductionNormChitiet)
                {

                    #region Cập nhật chi tiết
                    if (objProductsInfo.ICProductID > 0)
                    {
                        //Cập nhật chi tiết
                        objProductsController.UpdateObject(objProductsInfo);
                        //Cập nhật productitems
                        ICProductItemsInfo objProductItemsInfo = objProductItemsController.GetProductItemByParentIDAndChildID(objProductsInfo.ICProductParentID, objProductsInfo.ICProductID);
                        if (objProductItemsInfo != null)
                        {
                            objProductItemsInfo.ICProductItemQty = objProductsInfo.ICProductItemQty;
                            objProductItemsInfo.ICProductItemSortOrder = objProductsInfo.ICProductOrderID;
                            objProductItemsController.UpdateObject(objProductItemsInfo);
                        }
                    }
                    #endregion
                    #region Tạo mới chi tiết
                    else
                    {
                        //Tạo mới chi tiết thuộc cụm
                        if (objProductsInfo.ICProductParentID > 0)
                        {
                            ICProductsInfo objProductGroupsInfo = entity.SemiProductList.FirstOrDefault(g => g.ICProductID == objProductsInfo.ICProductParentID);
                            if (objProductGroupsInfo != null)
                            {
                                string childProductNo = string.Empty;
                                childProductNo = ProductionNormLocalizeResources.SemiProductGroupDefaultNo.Replace("{0}", objProductGroupsInfo.ICProductNo);
                                int count = objProductsController.GetCountAllSemiProductGroup(objProductGroupsInfo.ICProductNo + ".", ProductionNormConst.MMProductionNormChitiet, ProductType.IngredientPackaging.ToString());
                                count++;
                                childProductNo = childProductNo.Replace("{1}", count.ToString().PadLeft(2, '0'));
                                objProductsInfo.ICProductNo = childProductNo;
                                //Tạo mới chi tiết
                                objProductsController.CreateObject(objProductsInfo);
                                //Tạo productItem của chi tiết
                                ICProductItemsInfo item = new ICProductItemsInfo();
                                item.FK_ICProductItemParentID = objProductsInfo.ICProductParentID;
                                item.FK_ICProductItemChildID = objProductsInfo.ICProductID;
                                item.ICProductItemQty = objProductsInfo.ICProductItemQty;
                                item.ICProductItemSortOrder = objProductsInfo.ICProductOrderID;
                                objProductItemsController.CreateObject(item);
                            }

                        }
                        else //Tạo mới chi tiết không cụm
                        {
                            string productNoDefault = GetProductDefaultNo(objMainProductsInfo.ICProductNo);
                            string productNo = BOSCommon.ProductGroup.PackagingNo + "." + productNoDefault;
                            int count = objProductsController.GetCountAllSemiProductGroup(productNo + ".", ProductionNormConst.MMProductionNormCum, ProductType.IngredientPackaging.ToString());
                            count++;
                            string newSemiProductGroupNo = ProductionNormLocalizeResources.SemiProductGroupDefaultNo.Replace("{0}", productNo);
                            newSemiProductGroupNo = newSemiProductGroupNo.Replace("{1}", count.ToString().PadLeft(2, '0'));

                            objProductsInfo.ICProductNo = newSemiProductGroupNo;
                            objProductsController.CreateObject(objProductsInfo);
                            //create relation
                            List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(productNoDefault, productNoDefault.Length);

                            foreach (ICProductsInfo productsInfo in sameNoProduct)
                            {
                                ICProductItemsInfo item = new ICProductItemsInfo();
                                item.FK_ICProductItemParentID = productsInfo.ICProductID;
                                item.FK_ICProductItemChildID = objProductsInfo.ICProductID;
                                item.ICProductItemQty = objProductsInfo.ICProductItemQty;
                                objProductItemsController.CreateObject(item);
                            }
                        }

                    }
                    #endregion

                }

            }
            MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitPackagingList(true);
            entity.SemiProductList.GridControl.RefreshDataSource();

        }

        public void AddNewPackagingProductChild()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.SemiProductListParent.CurrentIndex >= 0)
            {
                int currentGroupIndex = entity.SemiProductListParent.CurrentIndex;
                ICProductsInfo objProductsInfo = entity.SemiProductListParent[currentGroupIndex];
                if (objProductsInfo != null)
                {
                    if (objProductsInfo.ICProductID > 0)
                    {

                        ICProductsInfo objSemiProductParentsInfo = new ICProductsInfo();
                        objSemiProductParentsInfo.FK_ICDepartmentID = ProductionNormConst.MMProductionNormPackagingProductDepartment;
                        objSemiProductParentsInfo.HasComponent = false;
                        objSemiProductParentsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormChitiet;
                        objSemiProductParentsInfo.ICProductType = ProductType.IngredientPackaging.ToString();
                        objSemiProductParentsInfo.ICProductParentID = objProductsInfo.ICProductID;
                        int sortOrder = 1;
                        foreach (ICProductsInfo child in entity.SemiProductListChild)
                        {
                            if (child.FK_ICDepartmentID == ProductionNormConst.MMProductionNormPackagingProductDepartment
                                && child.FK_ICProductGroupID == ProductionNormConst.MMProductionNormChitiet
                                && child.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                sortOrder++;
                            }
                        }
                        objSemiProductParentsInfo.ICProductOrderID = sortOrder;

                        entity.SemiProductListChild.Add(objSemiProductParentsInfo);
                        entity.SemiProductListChild.GridControl.RefreshDataSource();

                    }
                    else
                    {
                        MessageBox.Show(ProductionNormLocalizeResources.GroupRequireMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void RemoveSelectedItemFromProductionNormItemPackagingList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo item = entity.ModuleObjects[TableName.MMProductionNormItemsTableName] as MMProductionNormItemsInfo;
            entity.ProductionNormItemPackagingList.RemoveSelectedRowObjectFromList();
            CalculateProductionNormItemPackaging(string.Empty);
            ChangestatusToEdit(ProductType.IngredientPackaging.ToString());
        }


        public decimal CalculateOverallDimension(MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo, decimal insideDimension)
        {
            decimal overallDimension = 0;
            if (insideDimension > 0)
            {
                int value = objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationValue;
                if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Plus.ToString())
                {
                    overallDimension = insideDimension + value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Minus.ToString())
                {
                    overallDimension = insideDimension - value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Multi.ToString())
                {
                    overallDimension = insideDimension * value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Split.ToString())
                {
                    if (value != 0)
                    {
                        overallDimension = insideDimension / value;
                    }
                }
            }
            return overallDimension;
        }

        public void SetDefaultPackagingDescription()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;

            if (entity.ProductionNormItemList != null && entity.ProductionNormItemPackagingList.Count > 0)
            {
                ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
                {
                    item.MMProductionNormItemProductDesc = string.Empty;
                    if (!string.IsNullOrEmpty(item.MMProductionNormItemProductName))
                    {
                        item.MMProductionNormItemProductDesc += item.MMProductionNormItemProductName.Trim();
                    }
                    if (!(item.MMProductionNormItemProductInsideDimensionWidth == 0
                        && item.MMProductionNormItemProductInsideDimensionLength == 0
                        && item.MMProductionNormItemProductInsideDimensionHeight == 0))
                    {
                        if (!string.IsNullOrEmpty(item.MMProductionNormItemProductDesc))
                        {
                            item.MMProductionNormItemProductDesc += ", ";
                        }
                        item.MMProductionNormItemProductDesc += item.MMProductionNormItemProductInsideDimensionLength.ToString("n0").Trim()
                            + "x" + item.MMProductionNormItemProductInsideDimensionWidth.ToString("n0").Trim()
                            + "x" + item.MMProductionNormItemProductInsideDimensionHeight.ToString("n0").Trim();
                    }
                    if (!(item.MMProductionNormItemProductOverallDimensionWidth == 0
                        && item.MMProductionNormItemProductOverallDimensionLength == 0
                        && item.MMProductionNormItemProductOverallDimensionHeight == 0))
                    {
                        if (!string.IsNullOrEmpty(item.MMProductionNormItemProductDesc))
                        {
                            item.MMProductionNormItemProductDesc += ", ";
                        }
                        item.MMProductionNormItemProductDesc += item.MMProductionNormItemProductOverallDimensionLength.ToString("n0").Trim()
                            + "x" + item.MMProductionNormItemProductOverallDimensionWidth.ToString("n0").Trim()
                            + "x" + item.MMProductionNormItemProductOverallDimensionHeight.ToString("n0").Trim();
                    }
                    if (!string.IsNullOrEmpty(item.MMProductionNormItemProductSizeAndPacking))
                    {
                        if (!string.IsNullOrEmpty(item.MMProductionNormItemProductDesc))
                        {
                            item.MMProductionNormItemProductDesc += ", ";
                        }
                        item.MMProductionNormItemProductDesc += item.MMProductionNormItemProductSizeAndPacking.Trim();
                    }
                    if (item.FK_ICProdAttPackingMaterialSpecialityID > 0)
                    {
                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSpecialityID);
                        if (objAttribute != null)
                        {
                            if (!string.IsNullOrEmpty(item.MMProductionNormItemProductDesc))
                            {
                                item.MMProductionNormItemProductDesc += ", ";
                            }
                            item.MMProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                        }
                    }
                    if (item.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                    {
                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                        if (objAttribute != null)
                        {
                            if (!string.IsNullOrEmpty(item.MMProductionNormItemProductDesc))
                            {
                                item.MMProductionNormItemProductDesc += ", ";
                            }
                            item.MMProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                        }
                    }
                    if (item.FK_ICProdAttPackingMaterialSizeID > 0)
                    {

                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSizeID);
                        if (objAttribute != null)
                        {
                            if (!string.IsNullOrEmpty(item.MMProductionNormItemProductDesc))
                            {
                                item.MMProductionNormItemProductDesc += ", ";
                            }
                            item.MMProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                        }
                    }
                    if (!string.IsNullOrEmpty(item.MMProductionNormItemComment))
                    {
                        if (!string.IsNullOrEmpty(item.MMProductionNormItemProductDesc))
                        {
                            item.MMProductionNormItemProductDesc += ", ";
                        }
                        item.MMProductionNormItemProductDesc += item.MMProductionNormItemComment.Trim();
                    }
                    if (item.SubList != null)
                    {
                        foreach (MMProductionNormItemsInfo subItem in item.SubList)
                        {
                            subItem.MMProductionNormItemProductDesc = string.Empty;
                            if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductName))
                            {
                                subItem.MMProductionNormItemProductDesc += subItem.MMProductionNormItemProductName.Trim();
                            }
                            if (!(subItem.MMProductionNormItemProductInsideDimensionWidth == 0
                                && subItem.MMProductionNormItemProductInsideDimensionLength == 0
                                && subItem.MMProductionNormItemProductInsideDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductDesc))
                                {
                                    subItem.MMProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMProductionNormItemProductDesc += subItem.MMProductionNormItemProductInsideDimensionLength.ToString("n0").Trim()
                                    + "x" + subItem.MMProductionNormItemProductInsideDimensionWidth.ToString("n0").Trim()
                                    + "x" + subItem.MMProductionNormItemProductInsideDimensionHeight.ToString("n0").Trim();
                            }
                            if (!(subItem.MMProductionNormItemProductOverallDimensionWidth == 0
                                && subItem.MMProductionNormItemProductOverallDimensionLength == 0
                                && subItem.MMProductionNormItemProductOverallDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductDesc))
                                {
                                    subItem.MMProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMProductionNormItemProductDesc += subItem.MMProductionNormItemProductOverallDimensionLength.ToString("n0").Trim()
                                    + "x" + subItem.MMProductionNormItemProductOverallDimensionWidth.ToString("n0").Trim()
                                    + "x" + subItem.MMProductionNormItemProductOverallDimensionHeight.ToString("n0").Trim();
                            }
                            if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductSizeAndPacking))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductDesc))
                                {
                                    subItem.MMProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMProductionNormItemProductDesc += subItem.MMProductionNormItemProductSizeAndPacking.Trim();
                            }
                            if (subItem.FK_ICProdAttPackingMaterialSpecialityID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(subItem.FK_ICProdAttPackingMaterialSpecialityID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductDesc))
                                    {
                                        subItem.MMProductionNormItemProductDesc += ", ";
                                    }
                                    subItem.MMProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (subItem.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(subItem.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductDesc))
                                    {
                                        subItem.MMProductionNormItemProductDesc += ", ";
                                    }
                                    subItem.MMProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (subItem.FK_ICProdAttPackingMaterialSizeID > 0)
                            {

                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(subItem.FK_ICProdAttPackingMaterialSizeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductDesc))
                                    {
                                        subItem.MMProductionNormItemProductDesc += ", ";
                                    }
                                    subItem.MMProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (!string.IsNullOrEmpty(subItem.MMProductionNormItemComment))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMProductionNormItemProductDesc))
                                {
                                    subItem.MMProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMProductionNormItemProductDesc += subItem.MMProductionNormItemComment.Trim();
                            }
                        }
                    }
                }
                entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemPackagingList.TreeListControl.ExpandAll();
                entity.ProductionNormItemPackagingList.TreeListControl.BestFitColumns();
            }
        }



        public void CalculateProductionNormItemPackaging(string editColumnName)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (editColumnName == "MMProductionNormItemProductInsideDimensionHeight"
                || editColumnName == "MMProductionNormItemProductInsideDimensionWidth"
                || editColumnName == "MMProductionNormItemProductInsideDimensionLength"
                || editColumnName == "FK_ICProdAttPackingMaterialSpecialityID")
            {

                if (entity.ProductionNormItemList != null && entity.ProductionNormItemPackagingList.Count > 0)
                {

                    MMProductionNormItemsInfo productionNormItem = (MMProductionNormItemsInfo)entity.ProductionNormItemPackagingList.CurrentObject;
                    if (productionNormItem != null)
                    {

                        MMOverallInsideDimensionConfigsController objOverallInsideDimensionConfigsController = new MMOverallInsideDimensionConfigsController();
                        List<MMOverallInsideDimensionConfigsInfo> overallInsideDimensionConfigsList = new List<MMOverallInsideDimensionConfigsInfo>();
                        MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo = new MMOverallInsideDimensionConfigsInfo();


                        productionNormItem.MMProductionNormItemProductOverallDimensionHeight = 0;
                        productionNormItem.MMProductionNormItemProductOverallDimensionWidth = 0;
                        productionNormItem.MMProductionNormItemProductOverallDimensionLength = 0;
                        if (productionNormItem.FK_ICProdAttPackingMaterialSpecialityID > 0)
                        {
                            #region Height
                            overallInsideDimensionConfigsList
                                = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(productionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Height.ToString());
                            objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                            if (objOverallInsideDimensionConfigsInfo != null)
                            {
                                productionNormItem.MMProductionNormItemProductOverallDimensionHeight = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                                   productionNormItem.MMProductionNormItemProductInsideDimensionHeight);
                            }
                            #endregion
                            #region Width
                            overallInsideDimensionConfigsList
                                = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(productionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Width.ToString());
                            objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                            if (objOverallInsideDimensionConfigsInfo != null)
                            {
                                productionNormItem.MMProductionNormItemProductOverallDimensionWidth = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                                   productionNormItem.MMProductionNormItemProductInsideDimensionWidth);
                            }
                            #endregion
                            #region Length
                            overallInsideDimensionConfigsList
                                = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(productionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Length.ToString());
                            objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                            if (objOverallInsideDimensionConfigsInfo != null)
                            {
                                productionNormItem.MMProductionNormItemProductOverallDimensionLength = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                                   productionNormItem.MMProductionNormItemProductInsideDimensionLength);
                            }
                            #endregion
                        }
                    }
                }
            }

            #region Desc
            //KT phủ bì
            string productionNormOverallDimension = string.Empty;
            //KT lọt lòng
            string productionNormInsideDimension = string.Empty;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
            {
                #region Desc
                if (!string.IsNullOrEmpty(GetOverallDimension(item)))
                {
                    if (!string.IsNullOrEmpty(productionNormOverallDimension))
                    {
                        productionNormOverallDimension += ";" + GetOverallDimension(item);
                    }
                    else
                    {
                        productionNormOverallDimension += GetOverallDimension(item);
                    }
                }

                if (!string.IsNullOrEmpty(GetInsideDimension(item)))
                {
                    if (!string.IsNullOrEmpty(productionNormInsideDimension))
                    {
                        productionNormInsideDimension += ";" + GetInsideDimension(item);
                    }
                    else
                    {
                        productionNormInsideDimension += GetInsideDimension(item);
                    }
                }
                #endregion


                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo subItem in item.SubList)
                    {
                        #region Desc
                        if (!string.IsNullOrEmpty(GetOverallDimension(subItem)))
                        {
                            if (!string.IsNullOrEmpty(productionNormOverallDimension))
                            {
                                productionNormOverallDimension += ";" + GetOverallDimension(subItem);
                            }
                            else
                            {
                                productionNormOverallDimension += GetOverallDimension(subItem);
                            }

                            if (!string.IsNullOrEmpty(GetInsideDimension(subItem)))
                            {
                                if (!string.IsNullOrEmpty(productionNormInsideDimension))
                                {
                                    productionNormInsideDimension += ";" + GetInsideDimension(subItem);
                                }
                                else
                                {
                                    productionNormInsideDimension += GetInsideDimension(subItem);
                                }
                            }
                        }
                        #endregion
                    }
                }
            }

            #region Desc
            //KT phủ bì
            objProductionNormsInfo.MMProductionNormOverallDimension = productionNormOverallDimension;
            //KT lọt lòng
            objProductionNormsInfo.MMProductionNormInsideDimension = productionNormInsideDimension;
            #endregion
            #endregion

            entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
            entity.ProductionNormItemPackagingList.TreeListControl.ExpandAll();
            entity.ProductionNormItemPackagingList.TreeListControl.BestFitColumns();
        }

    }
}

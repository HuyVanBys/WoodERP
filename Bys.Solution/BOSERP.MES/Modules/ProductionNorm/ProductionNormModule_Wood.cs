using System;
using System.Collections.Generic;
using System.Linq;
using BOSERP.Modules.ProductionNorm.UI;
using BOSCommon;
using System.Windows.Forms;
using Localization;
using System.Data;
using DevExpress.XtraTreeList;
using System.Reflection;
using BOSLib;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;
using System.Net;
using Microsoft.Office.Interop.Excel;


namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormModule : BaseTransactionModule
    {
        private string DocumentFileName = string.Empty;
        private string FilePath = string.Empty;
        private string FileType = string.Empty;
        private const string SubFolder = "Products";

        #region Private variable
        private Microsoft.Office.Interop.Excel.Application App;
        private Workbook WorkBook;
        private Worksheet WorkSheet;
        #endregion

        public void InitSemiProductList(bool isRefreshChildList)
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
                        getLength = productNo.Length;
                    }

                    if (!string.IsNullOrEmpty(productNo))
                    {

                        List<ICProductsInfo> semiProductsList = objProductsController.GetSemiProductByProductNo(productNo, ProductType.SemiProduct.ToString());

                        List<ICProductsInfo> semiProductsListNotMatch = new List<ICProductsInfo>();
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

                        entity.SemiProductList.Invalidate(semiProductsListNotMatch);
                        entity.SemiProductList.OrderBy(t => t.ICProductNo);
                        entity.SemiProductList.GridControl.RefreshDataSource();
                        semiProductBackupList = new List<ICProductsInfo>();
                        semiProductBackupList = (List<ICProductsInfo>)entity.SemiProductList.Clone();
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

        public List<ICProductsInfo> semiProductBackupList;
        public void ShowMoreProducts()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo currentItem = (MMProductionNormItemsInfo)entity.ModuleObjects[TableName.MMProductionNormItemsTableName];
            guiChooseSemiProduct guiChooseProduct = new guiChooseSemiProduct();
            guiChooseProduct.Module = this;
            if (guiChooseProduct.ShowDialog() == DialogResult.OK)
            {
                foreach (ICProductsInfo objProductsInfo in entity.SemiProductList)
                {
                    if (objProductsInfo.Selected)
                    {
                        AddItemToProductionNormItemsList(objProductsInfo);
                    }
                }
            }

        }

        public string GetDepartmentAttributeValueByDepartmentAttributeValueID(string productAttributeValue, string attributeType)
        {
            string[] departmentAttributeValue = productAttributeValue.Split(';');
            string[] departmentAttributeType;
            if (departmentAttributeValue.Length > 0)
            {
                foreach (string item in departmentAttributeValue)
                {
                    if (item.ToLower().Contains(attributeType.ToLower()))
                    {
                        departmentAttributeType = item.Split(':');
                        if (departmentAttributeType.Length > 1)
                        {
                            return departmentAttributeType[1];
                        }
                    }
                    else if (item != string.Empty)
                    {
                        return item;
                    }
                }
            }

            return "";
        }

        public MMProductionNormItemsInfo SetValueProductionNormItemFromProduct(ICProductsInfo objProductsInfo, string ProductName, ICProductsInfo productParentObject)
        {
            MMReuseSpecificateConfigsController objReuseSpecificateConfigsController = new MMReuseSpecificateConfigsController();
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            MMProductionNormItemsInfo objToGetProductionNormItemsInfo = new MMProductionNormItemsInfo();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo;
            objProductionNormItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProductionNormItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProductionNormItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProductionNormItemsInfo.MMProductionNormItemNo = objProductsInfo.ICProductNo;
            objProductionNormItemsInfo.MMProductionNormItemProductLength = objProductsInfo.ICProductLength;
            objProductionNormItemsInfo.MMProductionNormItemProductHeight = objProductsInfo.ICProductHeight;
            objProductionNormItemsInfo.MMProductionNormItemProductWidth = objProductsInfo.ICProductWidth;
            objProductionNormItemsInfo.MMProductionNormItemProductJoinery = objProductsInfo.ICProductJoinery;
            objProductionNormItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICProductName;
            objProductionNormItemsInfo.MMProductionNormItemParentOrderName = ProductName;
            objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            //objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID = objProductsInfo.FK_ICProductAttributeSpecialityID;
            //objProductionNormItemsInfo.FK_ICProductAttributeQualityID = objProductsInfo.FK_ICProductAttributeQualityID;
            //objProductionNormItemsInfo.FK_MMFormulaIDPaintA = objProductsInfo.FK_MMFormulaIDPaintA;
            //objProductionNormItemsInfo.MMProductionNormItemIsReuse = objProductsInfo.MMProductionNormItemIsReuse;
            //objProductionNormItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            //objProductionNormItemsInfo.MMProductionNormItemProductJoinery = objProductsInfo.MMProductionNormProductJoinery;
            //objProductionNormItemsInfo.MMProductionNormItemComment = objProductsInfo.MMProductionNormItemComment;
            if (objProductsInfo.FK_ICProductAttributeSemiProductSpecialityID > 0)
            {
                objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID = objProductsInfo.FK_ICProductAttributeSemiProductSpecialityID;
            }
            MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
            List<MMConsumableConfigsInfo> objConsumableConfigsInfo = (List<MMConsumableConfigsInfo>)objConsumableConfigsController.GetConsumableConfigsByProductAttributeID(objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
            if (objConsumableConfigsInfo != null && objConsumableConfigsInfo.Count > 0)
            {
                objProductionNormItemsInfo.MMProductionNormItemDepreciationRate = objConsumableConfigsInfo[0].MMConsumableConfigValue;
            }
            //Get wood type from match codes             
            objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeWoodTypeID);
            if (objProductAttributesInfo != null)
            {
                objProductionNormItemsInfo.MMProductionNormItemProductWoodType = objProductAttributesInfo.ICProductAttributeValue;
            }
            bool isReuse = IsReUseItem(objProductionNormItemsInfo.MMProductionNormItemProductWoodType,
                         objProductionNormItemsInfo.MMProductionNormItemProductHeight, objProductionNormItemsInfo.MMProductionNormItemProductWidth,
                         objProductionNormItemsInfo.MMProductionNormItemProductLength, objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
            objProductionNormItemsInfo.MMProductionNormItemIsReuse = isReuse;
            return objProductionNormItemsInfo;
        }
        public MMProductionNormItemsInfo SetValueProductionNormItemFromProductForImport(ICProductsInfo objProductsInfo, string ProductName, ICProductsInfo productParentObject)
        {
            MMReuseSpecificateConfigsController objReuseSpecificateConfigsController = new MMReuseSpecificateConfigsController();
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            MMProductionNormItemsInfo objToGetProductionNormItemsInfo = new MMProductionNormItemsInfo();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo;
            objProductionNormItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProductionNormItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProductionNormItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProductionNormItemsInfo.MMProductionNormItemNo = objProductsInfo.ICProductNo;
            objProductionNormItemsInfo.MMProductionNormItemProductLength = objProductsInfo.ICProductLength;
            objProductionNormItemsInfo.MMProductionNormItemProductHeight = objProductsInfo.ICProductHeight;
            objProductionNormItemsInfo.MMProductionNormItemProductWidth = objProductsInfo.ICProductWidth;
            objProductionNormItemsInfo.MMProductionNormItemProductJoinery = objProductsInfo.ICProductJoinery;
            objProductionNormItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICProductName;
            objProductionNormItemsInfo.MMProductionNormItemParentOrderName = ProductName;
            objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            //objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID = objProductsInfo.FK_ICProductAttributeSpecialityID;
            //objProductionNormItemsInfo.FK_ICProductAttributeQualityID = objProductsInfo.FK_ICProductAttributeQualityID;
            //objProductionNormItemsInfo.FK_MMFormulaIDPaintA = objProductsInfo.FK_MMFormulaIDPaintA;
            //objProductionNormItemsInfo.MMProductionNormItemIsReuse = objProductsInfo.MMProductionNormItemIsReuse;
            //objProductionNormItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            //objProductionNormItemsInfo.MMProductionNormItemProductJoinery = objProductsInfo.MMProductionNormProductJoinery;
            //objProductionNormItemsInfo.MMProductionNormItemComment = objProductsInfo.MMProductionNormItemComment;
            if (objProductsInfo.FK_ICProductAttributeSemiProductSpecialityID > 0)
            {
                objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID = objProductsInfo.FK_ICProductAttributeSemiProductSpecialityID;
            }
            MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
            List<MMConsumableConfigsInfo> objConsumableConfigsInfo = (List<MMConsumableConfigsInfo>)objConsumableConfigsController.GetConsumableConfigsByProductAttributeID(objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
            if (objConsumableConfigsInfo != null && objConsumableConfigsInfo.Count > 0)
            {
                objProductionNormItemsInfo.MMProductionNormItemDepreciationRate = objConsumableConfigsInfo[0].MMConsumableConfigValue;
            }
            //Get wood type from match codes             
            objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeWoodTypeID);
            if (objProductAttributesInfo != null)
            {
                objProductionNormItemsInfo.MMProductionNormItemProductWoodType = objProductAttributesInfo.ICProductAttributeValue;
            }
            return objProductionNormItemsInfo;
        }
        public bool IsReUseItem(string woodType, decimal productHeight, decimal productWidth, decimal productLength, int specialityID)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(woodType);
            int woodTypeID = 0;
            if (objProductAttributesInfo != null)
                woodTypeID = objProductAttributesInfo.ICProductAttributeID;

            MMReuseSpecificateConfigsController objReuseSpecificateConfigsController = new MMReuseSpecificateConfigsController();
            List<MMReuseSpecificateConfigsInfo> ReuseSpecificateConfigList =
                         objReuseSpecificateConfigsController.GetReuseSpecificateConfigSomeCriteria(woodTypeID, productHeight, specialityID);
            if (ReuseSpecificateConfigList != null)
            {
                //ReuseSpecificateConfigList = ReuseSpecificateConfigList.Where(x => x.FK_ICProductAttributeWoodTypeID == woodTypeID).ToList();
                if (ReuseSpecificateConfigList != null && ReuseSpecificateConfigList.Count > 0)
                {
                    ReuseSpecificateConfigList = ReuseSpecificateConfigList.Where(x =>                                       //dài
                                                                                             (x.MMReuseSpecificateConfigHeightMax == 0 ?
                                                                                                            x.MMReuseSpecificateConfigHeightMin <= productLength :
                                                                                                             x.MMReuseSpecificateConfigHeightMin <= productLength
                                                                                                             && x.MMReuseSpecificateConfigHeightMax >= productLength)
                                                                                                 //Rộng
                                                                                            && (x.MMReuseSpecificateConfigWidthMax == 0 ?
                                                                                                            x.MMReuseSpecificateConfigWidthMin <= productWidth :
                                                                                                             x.MMReuseSpecificateConfigWidthMin <= productWidth
                                                                                                             && x.MMReuseSpecificateConfigWidthMax >= productWidth)
                                                                                     ).ToList();
                }
                if (ReuseSpecificateConfigList != null && ReuseSpecificateConfigList.Count > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public void GetProductionNormItemDepreciationRate(MMProductionNormItemsInfo objProductionNormItemsInfo)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (objProductionNormItemsInfo == null)
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
            if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.MMProductionNormItemDepreciationRate > 0)
                return;
            MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
            List<MMConsumableConfigsInfo> consumableConfigList = new List<MMConsumableConfigsInfo>();
            MMConsumableConfigsInfo objConsumableConfigsInfo = new MMConsumableConfigsInfo();
            DataSet ds = objConsumableConfigsController.GetAllObjects();

            if (ds != null && ds.Tables.Count > 0)
            {
                consumableConfigList = (List<MMConsumableConfigsInfo>)objConsumableConfigsController.GetListFromDataSet(ds);
            }

            if (objProductionNormItemsInfo != null)
            {
                if (consumableConfigList != null)
                {
                    objConsumableConfigsInfo = consumableConfigList.Where(x => x.FK_ICProductAttributeID
                           == objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID).FirstOrDefault();
                    if (objConsumableConfigsInfo != null)
                        objProductionNormItemsInfo.MMProductionNormItemDepreciationRate = objConsumableConfigsInfo.MMConsumableConfigValue;
                }
            }
            ds.Dispose();
        }

        public List<MMProductionNormItemsInfo> GetProductionNormItemListFromProductHasComponent(ICProductsInfo objProductsInfo)
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

                        objProductionNormItemsHasComponentInfo = SetValueProductionNormItemFromProduct(productComponentObject, objProductsInfo.ICProductName, productComponentObject);
                        objProductionNormItemsHasComponentInfo.MMProductionNormItemQuantity = productItem.ICProductItemQty;
                        objProductionNormItemsHasComponentInfo.MMProductionNormItemParentNo = objProductsInfo.ICProductNo;
                        productionNormItemList.Add(objProductionNormItemsHasComponentInfo);
                    }
                }
            }

            return productionNormItemList;
        }

        public void AddItemToProductionNormItemsList(ICProductsInfo objProductsInfo)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.SemiProduct.ToString());
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            if (objProductsInfo != null)
            {
                if (!objProductsInfo.HasComponent)
                {
                    //Get Product groups 
                    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                    ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
                    objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);

                    objProductionNormItemsInfo = SetValueProductionNormItemFromProduct(objProductsInfo, string.Empty, objProductsInfo);
                    objProductionNormItemsInfo.MMProductionNormItemQuantity = objProductsInfo.ICProductItemQty;
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemList.Count;
                    if (objProductionNormItemsInfo.SubList == null)
                        objProductionNormItemsInfo.SubList = new BOSTreeList();
                    objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
                    objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();

                    if (!entity.ProductionNormItemList.Exists("MMProductionNormItemNo", objProductionNormItemsInfo.MMProductionNormItemNo))
                    {
                        ICProductItemsController objProductItemsController = new ICProductItemsController();
                        List<ICProductItemsInfo> productItemsList = objProductItemsController.GetProductItemByChildID(objProductsInfo.ICProductID);

                        if (productItemsList != null && productItemsList.Count > 0)
                        {
                            bool isMatchParent = false;
                            foreach (ICProductItemsInfo childItem in productItemsList)
                            {
                                if (childItem.FK_ICProductItemParentID == ((MMProductionNormsInfo)entity.MainObject).FK_ICProductID)
                                {
                                    isMatchParent = true;
                                    break;
                                }
                            }
                            if (isMatchParent)//Chi tiết rời
                            {
                                objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
                                GetProductionNormItemDepreciationRate(objProductionNormItemsInfo);
                                entity.ProductionNormItemList.Add(objProductionNormItemsInfo);
                            }
                            else//Chi tiết thuộc cụm
                            {
                                bool isParentExist = false;
                                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                                {
                                    bool isParentNo = false;
                                    string[] arrayNo = objProductionNormItemsInfo.MMProductionNormItemNo.Split('.');
                                    string[] arrayParenNo = item.MMProductionNormItemNo.Split('.');
                                    if (arrayNo != null && arrayNo.Length == 3 && arrayParenNo != null && arrayParenNo.Length == 2)
                                    {
                                        if (arrayNo[0] == arrayParenNo[0] && arrayParenNo[1] == arrayNo[1])
                                        {
                                            isParentNo = true;
                                        }
                                    }
                                    if (isParentNo)
                                    {
                                        if (item.SubList == null)
                                        {
                                            item.SubList = new BOSTreeList();
                                        }
                                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
                                        objProductionNormItemsInfo.MMProductionNormItemParentNo = item.MMProductionNormItemNo;
                                        objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                                        GetProductionNormItemDepreciationRate(objProductionNormItemsInfo);
                                        item.SubList.Add(objProductionNormItemsInfo);
                                        int count = 1;
                                        foreach (MMProductionNormItemsInfo subItem in item.SubList)
                                        {
                                            subItem.MMProductionNormItemSortOrder = count++;
                                        }
                                        isParentExist = true;
                                        break;
                                    }
                                }
                                if (!isParentExist)//Chưa có cụm
                                {
                                    List<ICProductItemsInfo> parentsList = objProductItemsController.GetProductItemByChildID(objProductsInfo.ICProductID);
                                    if (parentsList != null && parentsList.Count > 0)
                                    {
                                        ICProductItemsInfo parentsInfo = parentsList.FirstOrDefault();
                                        if (parentsInfo != null)
                                        {
                                            ICProductsController objProductsController = new ICProductsController();
                                            ICProductsInfo objParentProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(parentsInfo.FK_ICProductItemParentID);
                                            if (objParentProductsInfo != null)
                                            {
                                                #region thêm cụm (chỉ cụm)
                                                List<MMProductionNormItemsInfo> productionNormItemList = GetProductionNormItemListFromProductHasComponent(objParentProductsInfo);

                                                MMProductionNormItemsInfo objProductionNormItemParentsInfo = new MMProductionNormItemsInfo();
                                                objProductionNormItemParentsInfo = SetValueProductionNormItemFromProduct(objParentProductsInfo, string.Empty, objParentProductsInfo);
                                                objProductionNormItemParentsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemList.Count;
                                                objProductionNormItemParentsInfo.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                                                objProductionNormItemParentsInfo.MMProductionNormItemIsComponent = true;
                                                //objProductionNormItemParentsInfo.MMProductionNormItemIsReuse = false;
                                                bool isReuse = IsReUseItem(objProductionNormItemsInfo.MMProductionNormItemProductWoodType,
                                                                                objProductionNormItemsInfo.MMProductionNormItemProductHeight,
                                                                                objProductionNormItemsInfo.MMProductionNormItemProductWidth,
                                                                                objProductionNormItemsInfo.MMProductionNormItemProductLength,
                                                                                objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
                                                objProductionNormItemsInfo.MMProductionNormItemIsReuse = isReuse;
                                                ///  objProductionNormItemParentsInfo.MMProductionNormItemQuantity = 1;
                                                // if (objProductsInfo.ICProductItemQty > 0)
                                                // {
                                                objProductionNormItemParentsInfo.MMProductionNormItemQuantity = objProductsInfo.ICProductItemQty;
                                                //  }
                                                if (objProductionNormItemParentsInfo.SubList == null)
                                                    objProductionNormItemParentsInfo.SubList = new BOSTreeList();
                                                if (!entity.ProductionNormItemList.Exists("MMProductionNormItemNo", objProductionNormItemParentsInfo.MMProductionNormItemNo))
                                                {
                                                    //GetProductionNormItemDepreciationRate(objProductionNormItemParentsInfo);
                                                    entity.ProductionNormItemList.Add(objProductionNormItemParentsInfo);
                                                }
                                                else
                                                {
                                                    MessageBox.Show(ProductionNormLocalizeResources.GroupExistInListMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    return;
                                                }
                                                if (entity.ProductionNormItemList.CurrentObject != null && entity.ProductionNormItemList.CurrentObject.SubList == null)
                                                {
                                                    entity.ProductionNormItemList.CurrentObject.SubList = new BOSTreeList();
                                                    entity.ProductionNormItemList.CurrentObject.HasChildren();
                                                }
                                                #endregion
                                                AddItemToProductionNormItemsList(objProductsInfo);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    #region Thêm cụm với đầy đủ con
                    List<MMProductionNormItemsInfo> productionNormItemList = GetProductionNormItemListFromProductHasComponent(objProductsInfo);

                    MMProductionNormItemsInfo objProductionNormItemParentsInfo = new MMProductionNormItemsInfo();
                    objProductionNormItemParentsInfo = SetValueProductionNormItemFromProduct(objProductsInfo, string.Empty, objProductsInfo);
                    objProductionNormItemParentsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemList.Count;
                    objProductionNormItemParentsInfo.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                    objProductionNormItemParentsInfo.MMProductionNormItemIsComponent = true;
                    bool isReuse = IsReUseItem(objProductionNormItemsInfo.MMProductionNormItemProductWoodType,
                                                                               objProductionNormItemsInfo.MMProductionNormItemProductHeight,
                                                                               objProductionNormItemsInfo.MMProductionNormItemProductWidth,
                                                                               objProductionNormItemsInfo.MMProductionNormItemProductLength,
                                                                               objProductionNormItemsInfo.FK_ICProductAttributeSpecialityID);
                    objProductionNormItemsInfo.MMProductionNormItemIsReuse = isReuse;
                    objProductionNormItemParentsInfo.MMProductionNormItemQuantity = 1;
                    if (objProductsInfo.ICProductItemQty > 0)
                    {
                        objProductionNormItemParentsInfo.MMProductionNormItemQuantity = objProductsInfo.ICProductItemQty;
                    }
                    if (objProductionNormItemParentsInfo.SubList == null)
                        objProductionNormItemParentsInfo.SubList = new BOSTreeList();
                    if (!entity.ProductionNormItemList.Exists("MMProductionNormItemNo", objProductionNormItemParentsInfo.MMProductionNormItemNo))
                    {
                        //GetProductionNormItemDepreciationRate(objProductionNormItemParentsInfo);
                        entity.ProductionNormItemList.Add(objProductionNormItemParentsInfo);
                    }
                    else
                    {
                        MessageBox.Show(ProductionNormLocalizeResources.GroupExistInListMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (entity.ProductionNormItemList.CurrentObject != null && entity.ProductionNormItemList.CurrentObject.SubList == null)
                    {
                        entity.ProductionNormItemList.CurrentObject.SubList = new BOSTreeList();
                        entity.ProductionNormItemList.CurrentObject.HasChildren();
                    }

                    int sortOrder = 0;
                    foreach (MMProductionNormItemsInfo item in productionNormItemList)
                    {
                        foreach (MMProductionNormItemsInfo parentItem in entity.ProductionNormItemList)
                        {
                            if (item.MMProductionNormItemParentNo == parentItem.MMProductionNormItemNo)
                            {
                                if (item.SubList == null)
                                    item.SubList = new BOSTreeList();
                                if (parentItem.SubList == null)
                                    parentItem.SubList = new BOSTreeList();
                                item.MMProductionNormItemSortOrder = sortOrder;
                                item.MMProductionNormItemIsComponent = false;
                                item.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                                GetProductionNormItemDepreciationRate(item);
                                parentItem.SubList.Add(item);

                            }
                        }
                        sortOrder++;
                    }
                    #endregion
                }

                entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemList.TreeListControl.ForceInitialize();
                entity.ProductionNormItemList.TreeListControl.DragNodesMode = TreeListDragNodesMode.Advanced;
                entity.ProductionNormItemList.TreeListControl.OptionsBehavior.CanCloneNodesOnDrop = false;
                entity.ProductionNormItemList.TreeListControl.OptionsBehavior.AutoChangeParent = false;
                entity.ProductionNormItemList.TreeListControl.ClearSorting();
                entity.ProductionNormItemList.TreeListControl.Columns["MMProductionNormItemSortOrder"].SortOrder = SortOrder.Ascending;
                entity.ProductionNormItemList.TreeListControl.ExpandAll();
                entity.ProductionNormItemList.TreeListControl.BestFitColumns();

                //add to semiproduct list
                AddItemToSemiProductList(objProductsInfo);
            }
            CalculateProductionNormItemWoodType();
            CalculateBlockPerOne();
        }

        private bool HasExistInSemiProducts(int productID)
        {
            ProductionNormEntities entity = CurrentModuleEntity as ProductionNormEntities;
            ICProductsInfo product = entity.SemiProductList.Where(item => item.ICProductID == productID).FirstOrDefault();
            if (product != null)
                return true;
            return false;
        }

        private void AddItemToSemiProductList(ICProductsInfo product)
        {
            if (product != null)
            {
                bool hasExist = HasExistInSemiProducts(product.ICProductID);
                if (!hasExist)
                {
                    ProductionNormEntities entity = CurrentModuleEntity as ProductionNormEntities;
                    ICProductItemsController productItemController = new ICProductItemsController();
                    ICProductsController productController = new ICProductsController();

                    List<ICProductItemsInfo> productItems = productItemController.GetProductItemListByProductID(product.ICProductID);
                    if (productItems != null)
                    {
                        foreach (ICProductItemsInfo productItem in productItems)
                        {
                            hasExist = HasExistInSemiProducts(productItem.FK_ICProductItemChildID);
                            if (!hasExist)
                            {
                                ICProductsInfo child = productController.GetObjectByID(productItem.FK_ICProductItemChildID) as ICProductsInfo;
                                if (child != null)
                                {
                                    //   child.ICProductHasBeenInProdNorm = true;
                                    entity.SemiProductList.Add(child);
                                }
                            }
                        }
                    }

                    //product.ICProductHasBeenInProdNorm = true;
                    entity.SemiProductList.Add(product);
                }
            }
        }

        public MMProductionNormItemsInfo UpdateValueProductionNormItems(MMProductionNormItemsInfo objProductionNormItemsInfo)
        {
            if (!objProductionNormItemsInfo.MMProductionNormItemIsComponent)
            {
                if (objProductionNormItemsInfo.MMProductionNormItemQuantity == 0)
                    objProductionNormItemsInfo.MMProductionNormItemQuantity = 1;
                //Production norm item acreage
                objProductionNormItemsInfo.MMProductionNormItemAcreage =

                   ((2 * (objProductionNormItemsInfo.MMProductionNormItemProductLength) * objProductionNormItemsInfo.MMProductionNormItemProductWidth)
                    + (2 * (objProductionNormItemsInfo.MMProductionNormItemProductLength) * objProductionNormItemsInfo.MMProductionNormItemProductHeight)
                    + (2 * objProductionNormItemsInfo.MMProductionNormItemProductWidth * objProductionNormItemsInfo.MMProductionNormItemProductHeight)
                    ) * objProductionNormItemsInfo.MMProductionNormItemQuantity / ProductionNormConst.ProducttionNormValue1000000;

                // Production norm item plywood & MDFBlocks
                if (objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormMDF.ToUpper()
                    || objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormPlywood.ToUpper()
                    || objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormOkal.ToUpper())
                {
                    objProductionNormItemsInfo.MMProductionNormItemMDFBlocks =
                        (objProductionNormItemsInfo.MMProductionNormItemProductLength)
                        * objProductionNormItemsInfo.MMProductionNormItemQuantity * objProductionNormItemsInfo.MMProductionNormItemProductWidth
                        * objProductionNormItemsInfo.MMProductionNormItemProductHeight / ProductionNormConst.ProducttionNormValue1000000000;

                    objProductionNormItemsInfo.MMProductionNormItemPlywood =
                        (objProductionNormItemsInfo.MMProductionNormItemProductLength)
                        * objProductionNormItemsInfo.MMProductionNormItemQuantity * objProductionNormItemsInfo.MMProductionNormItemProductWidth
                        / ProductionNormConst.ProducttionNormValue1000000;
                }
                else if (objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormOak.ToUpper() ||
                    //objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormOak4.ToUpper() ||
                    //objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormOak5.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormAcacia.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormTeak.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormPine.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormEucalyptus.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormWalnut.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormAsh.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormBeech.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormGoCung.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormRubber.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormHuynh.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormXoanDao.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormMahogany.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormGoWhiteOak.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormIroko.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormCedar.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormGothong.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormGoRedOak.ToUpper())
                {
                    objProductionNormItemsInfo.MMProductionNormItemWoodBlocks =
                         (objProductionNormItemsInfo.MMProductionNormItemProductLength)
                        * objProductionNormItemsInfo.MMProductionNormItemQuantity * objProductionNormItemsInfo.MMProductionNormItemProductHeight
                        * objProductionNormItemsInfo.MMProductionNormItemProductWidth / ProductionNormConst.ProducttionNormValue1000000000;
                }
                else
                {
                    objProductionNormItemsInfo.MMProductionNormItemWoodBlocks = 0;
                }

                if (objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerTeak.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerAcacia.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerOak.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerPine.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerWalnut.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerAsh.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerBeech.ToUpper() ||
                    objProductionNormItemsInfo.MMProductionNormItemProductWoodType.Trim().ToUpper() == ProductionNormConst.ProducttionNormVeneerRubber.ToUpper())
                {
                    objProductionNormItemsInfo.MMProductionNormItemVeneer =
                        (objProductionNormItemsInfo.MMProductionNormItemProductLength * objProductionNormItemsInfo.MMProductionNormItemQuantity
                        * objProductionNormItemsInfo.MMProductionNormItemProductWidth / ProductionNormConst.ProducttionNormValue1000000);
                }
                else
                {
                    objProductionNormItemsInfo.MMProductionNormItemVeneer = 0;
                }
                //Production norm total wood consumable
                int productQuantity = 1;
                objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable = objProductionNormItemsInfo.MMProductionNormItemWoodBlocks
                                                                                 * objProductionNormItemsInfo.MMProductionNormItemDepreciationRate
                                                                                 * productQuantity;
            }
            return objProductionNormItemsInfo;

        }

        public void AddNewSemiProductItem()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (objProductionNormsInfo.FK_ICProductID > 0)
            {
                guiAddSemiProduct guiAddNew = new guiAddSemiProduct(objProductionNormsInfo.FK_ICProductID);
                guiAddNew.Module = this;
                guiAddNew.ShowDialog();
            }
        }

        public void InitSemiProduct()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.SemiProductListParent.Clear();

            foreach (ICProductsInfo semiProductsInfo in entity.SemiProductList)
            {
                if (semiProductsInfo.HasComponent)
                {
                    entity.SemiProductListParent.Add(semiProductsInfo);
                }
            }
            entity.SemiProductListParent.GridControl.RefreshDataSource();

        }

        public void AddNewSemiProductParent()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsInfo objSemiProductParentsInfo = new ICProductsInfo();
            objSemiProductParentsInfo.FK_ICDepartmentID = ProductionNormConst.MMProductionNormSemiProductDepartment;
            objSemiProductParentsInfo.HasComponent = true;
            objSemiProductParentsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormCum;
            objSemiProductParentsInfo.ICProductType = ProductType.SemiProduct.ToString();
            entity.SemiProductListParent.Add(objSemiProductParentsInfo);
            entity.SemiProductListParent.GridControl.RefreshDataSource();

        }

        public void SaveSemiProductGroup(int currentIndex)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            ICProductsInfo objMainProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
            if (objMainProductsInfo != null)
            {
                if (currentIndex >= 0)
                {
                    ICProductsInfo objSemiProductGroupsInfo = entity.SemiProductListParent[currentIndex];
                    if (objSemiProductGroupsInfo != null)
                    {
                        //if (objSemiProductGroupsInfo.ICProductID == 0 && objSemiProductGroupsInfo.ICProductSemiGroupType == 0 && objSemiProductGroupsInfo.ICProductType != ProductType.IngredientPackaging.ToString())
                        //{
                        //    if (MessageBox.Show("Bạn chưa chọn Loại cụm, mã phát sinh sẽ theo thứ tự mã hệ thống. Bạn có chắc muốn lưu không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        //    {
                        //        return;
                        //    }
                        //}

                        string productNoDefault = GetProductDefaultNo(objMainProductsInfo.ICProductNo);

                        string productNo = string.Empty;
                        if (objSemiProductGroupsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                        {
                            productNo = BOSCommon.ProductGroup.PackagingNo + "." + productNoDefault;
                        }
                        else
                        {
                            productNo = productNoDefault;
                        }

                        int count = objProductsController.GetCountAllSemiProductGroup(productNo + ".", ProductionNormConst.MMProductionNormCum, objSemiProductGroupsInfo.ICProductType);
                        count++;
                        bool isSuccess = true;
                        if (objSemiProductGroupsInfo.ICProductID > 0)
                        {
                            objSemiProductGroupsInfo.ICProductDesc = objSemiProductGroupsInfo.ICProductName;
                            #region History
                            GEObjectHistoryController objObjectHistorysController = new GEObjectHistoryController();
                            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
                            //=> OldObject 
                            ICProductsInfo oldObject = (ICProductsInfo)semiProductBackupList.FirstOrDefault(t => t.ICProductID == objSemiProductGroupsInfo.ICProductID);
                            if (oldObject != null)
                            {
                                //=> objProductsInfo : newObject
                                ICProductsInfo newObject = (ICProductsInfo)objSemiProductGroupsInfo.Clone();
                                PropertyInfo[] props = oldObject.GetType().GetProperties();
                                string tableName = BOSUtil.GetTableNameFromBusinessObject(oldObject);
                                object oldValue;
                                object newValue;
                                List<GEHistoryDetailsInfo> historyDetailList = new List<GEHistoryDetailsInfo>();
                                foreach (PropertyInfo propInfo in props)
                                {
                                    if ((propInfo.Name.Substring(0, 2) != "AA"))
                                    {
                                        BOSDbUtil bosDbUtil = new BOSDbUtil();
                                        newValue = bosDbUtil.GetPropertyValue(newObject, propInfo.Name);
                                        oldValue = bosDbUtil.GetPropertyValue(oldObject, propInfo.Name);
                                        if (oldValue != null && newValue != null)
                                        {
                                            if (!oldValue.Equals(newValue))
                                            {
                                                GEHistoryDetailsInfo objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                                                //objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                                objHistoryDetailsInfo.GEHistoryDetailTableName = tableName;
                                                objHistoryDetailsInfo.GEHistoryDetailColumnName = propInfo.Name;
                                                //objHistoryDetailsInfo.GEHistoryDetailParentID = historyDetailParentID;
                                                if (oldValue != null)
                                                {
                                                    objHistoryDetailsInfo.GEHistoryDetailOldValue = oldValue.ToString().Trim();
                                                }
                                                if (newValue != null)
                                                {
                                                    objHistoryDetailsInfo.GEHistoryDetailNewValue = newValue.ToString().Trim();
                                                }
                                                historyDetailList.Add(objHistoryDetailsInfo);
                                            }
                                        }
                                    }
                                }

                                if (historyDetailList != null && historyDetailList.Count > 0)
                                {
                                    GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                                    objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                    objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                    objObjectHistoryInfo.GEObjectHistoryObjectName = "Product";
                                    objObjectHistoryInfo.GEObjectHistoryObjectID = objSemiProductGroupsInfo.ICProductID;
                                    objObjectHistoryInfo.GEObjectHistoryObjectNumber = objSemiProductGroupsInfo.ICProductNo;
                                    objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Change.ToString();
                                    BOSDbUtil dbUtil = new BOSDbUtil();
                                    DateTime currentDate = dbUtil.GetCurrentServerDate();
                                    objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                    int objectHistoryID = objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                    if (objectHistoryID > 0)
                                    {
                                        foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in historyDetailList)
                                        {
                                            objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                            objHistoryDetailsController.CreateObject(objHistoryDetailsInfo);
                                        }
                                    }
                                }
                            }
                            #endregion
                            objProductsController.UpdateObject(objSemiProductGroupsInfo);

                            List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(productNo, productNo.Length);
                            ICProductItemsController objProductItemsController = new ICProductItemsController();
                            foreach (ICProductsInfo productsInfo in sameNoProduct)
                            {
                                ICProductItemsInfo objProductItemsInfo = objProductItemsController.GetProductItemByParentIDAndChildID(productsInfo.ICProductID, objSemiProductGroupsInfo.ICProductID);
                                if (objProductItemsInfo != null)
                                {
                                    if (objProductItemsInfo.ICProductItemQty != objSemiProductGroupsInfo.ICProductItemQty)
                                    {
                                        //TNDLoc [ADD][28/04/2016][History ProductItem],START
                                        GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                                        objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                        objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                        objObjectHistoryInfo.GEObjectHistoryObjectName = "ProductItem";
                                        objObjectHistoryInfo.GEObjectHistoryObjectID = objProductItemsInfo.ICProductItemID;
                                        objObjectHistoryInfo.GEObjectHistoryObjectNumber = "";
                                        objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Change.ToString();
                                        BOSDbUtil dbUtil = new BOSDbUtil();
                                        DateTime currentDate = dbUtil.GetCurrentServerDate();
                                        objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                        int objectHistoryID = objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                        if (objectHistoryID > 0)
                                        {
                                            GEHistoryDetailsInfo objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                                            objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                            objHistoryDetailsInfo.GEHistoryDetailTableName = "ICProductItems";
                                            objHistoryDetailsInfo.GEHistoryDetailColumnName = "ICProductItemQty";
                                            objHistoryDetailsInfo.GEHistoryDetailOldValue = objProductItemsInfo.ICProductItemQty.ToString();
                                            objHistoryDetailsInfo.GEHistoryDetailNewValue = objSemiProductGroupsInfo.ICProductItemQty.ToString();
                                            objHistoryDetailsController.CreateObject(objHistoryDetailsInfo);

                                        }


                                        objProductItemsInfo.ICProductItemQty = objSemiProductGroupsInfo.ICProductItemQty;
                                        objProductItemsController.UpdateObject(objProductItemsInfo);
                                        //TNDLoc [ADD][28/04/2016][History ProductItem],END
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Create New Semi Product Group (Cụm)

                            if (!string.IsNullOrEmpty(productNo))
                            {
                                string newSemiProductGroupNo = string.Empty;
                                if (objSemiProductGroupsInfo.ICProductNo.Trim() == string.Empty)
                                {
                                    newSemiProductGroupNo = objProductsController.GetNextNoForGroupOrPieceSemiProduct(productNo, productNo.Length + 3);
                                    objSemiProductGroupsInfo.ICProductNo = newSemiProductGroupNo;
                                }
                                else
                                {
                                    newSemiProductGroupNo = objSemiProductGroupsInfo.ICProductNo.Trim();
                                }
                                if (objProductsController.IsExistProductNo(newSemiProductGroupNo))
                                {
                                    MessageBox.Show(ProductionNormLocalizeResources.MatchNoExceptionMessage.Replace("{0}", newSemiProductGroupNo),
                                                    MESLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    isSuccess = false;
                                    objSemiProductGroupsInfo.ICProductNo = string.Empty;
                                }
                                else
                                {
                                    objSemiProductGroupsInfo.ICProductDesc = objSemiProductGroupsInfo.ICProductName;
                                    objProductsController.CreateObject(objSemiProductGroupsInfo);
                                    #region History
                                    GEObjectHistoryController objObjectHistorysController = new GEObjectHistoryController();
                                    GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                                    objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                    objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                    objObjectHistoryInfo.GEObjectHistoryObjectName = "Product";
                                    objObjectHistoryInfo.GEObjectHistoryObjectID = objSemiProductGroupsInfo.ICProductID;
                                    objObjectHistoryInfo.GEObjectHistoryObjectNumber = objSemiProductGroupsInfo.ICProductNo;
                                    objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                                    BOSDbUtil dbUtil = new BOSDbUtil();
                                    DateTime currentDate = dbUtil.GetCurrentServerDate();
                                    objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                    objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                    #endregion
                                    //create relation
                                    List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(productNo, productNo.Length);
                                    ICProductItemsController objProductItemsController = new ICProductItemsController();
                                    foreach (ICProductsInfo productsInfo in sameNoProduct)
                                    {
                                        ICProductItemsInfo item = new ICProductItemsInfo();
                                        item.FK_ICProductItemParentID = productsInfo.ICProductID;
                                        item.FK_ICProductItemChildID = objSemiProductGroupsInfo.ICProductID;
                                        item.ICProductItemQty = objSemiProductGroupsInfo.ICProductItemQty;
                                        objProductItemsController.CreateObject(item);
                                        //TNDLoc [ADD][28/04/2016][History ProductItem],START
                                        objObjectHistoryInfo = new GEObjectHistoryInfo();
                                        objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                        objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                        objObjectHistoryInfo.GEObjectHistoryObjectName = "ProductItem";
                                        objObjectHistoryInfo.GEObjectHistoryObjectID = item.ICProductItemID;
                                        objObjectHistoryInfo.GEObjectHistoryObjectNumber = "";
                                        objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                                        currentDate = dbUtil.GetCurrentServerDate();
                                        objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                        objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                        //TNDLoc [ADD][28/04/2016][History ProductItem],END
                                    }
                                }
                            }
                        }
                        if (isSuccess)
                        {
                            MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (objSemiProductGroupsInfo.ICProductType == ProductType.SemiProduct.ToString())
                            {
                                InitSemiProductList(false);
                            }
                            else if (objSemiProductGroupsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
                            {
                                InitPackagingList(false);
                            }
                        }
                    }

                }
            }
        }

        public void AddNewSemiProductChild()
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
                        objSemiProductParentsInfo.FK_ICDepartmentID = ProductionNormConst.MMProductionNormSemiProductDepartment;
                        objSemiProductParentsInfo.HasComponent = false;
                        objSemiProductParentsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormChitiet;
                        objSemiProductParentsInfo.ICProductType = ProductType.SemiProduct.ToString();
                        objSemiProductParentsInfo.ICProductParentID = objProductsInfo.ICProductID;
                        int sortOrder = 1;
                        foreach (ICProductsInfo child in entity.SemiProductListChild)
                        {
                            if (child.FK_ICDepartmentID == ProductionNormConst.MMProductionNormSemiProductDepartment
                                && (child.FK_ICProductGroupID == ProductionNormConst.MMProductionNormChitiet || !child.HasComponent)
                                && child.ICProductType == ProductType.SemiProduct.ToString())
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

        #region Piece
        public void AddNewSemiProductPiece()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;

            ICProductsInfo objSemiProductParentsInfo = new ICProductsInfo();
            objSemiProductParentsInfo.FK_ICDepartmentID = ProductionNormConst.MMProductionNormSemiProductDepartment;
            objSemiProductParentsInfo.HasComponent = false;
            objSemiProductParentsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormChitiet;
            objSemiProductParentsInfo.ICProductType = ProductType.SemiProduct.ToString();
            objSemiProductParentsInfo.ICProductParentID = 0;
            int sortOrder = 1;
            foreach (ICProductsInfo child in entity.SemiProductListChild)
            {
                if (child.FK_ICDepartmentID == ProductionNormConst.MMProductionNormSemiProductDepartment
                    && (child.FK_ICProductGroupID == ProductionNormConst.MMProductionNormChitiet || !child.HasComponent)
                    && child.ICProductType == ProductType.SemiProduct.ToString())
                {
                    sortOrder++;
                }
            }
            objSemiProductParentsInfo.ICProductOrderID = sortOrder;

            entity.SemiProductListChild.Add(objSemiProductParentsInfo);
            entity.SemiProductListChild.GridControl.RefreshDataSource();
        }
        #endregion

        public void SaveSemiProductDetail()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            ICProductItemsController objProductItemsController = new ICProductItemsController();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            ICProductsInfo objMainProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
            bool isSuccess = true;
            foreach (ICProductsInfo objProductsInfo in entity.SemiProductListChild)
            {
                if (objProductsInfo.FK_ICProductGroupID == ProductionNormConst.MMProductionNormChitiet)
                {

                    #region Cập nhật chi tiết
                    if (objProductsInfo.ICProductID > 0)
                    {
                        objProductsInfo.ICProductDesc = objProductsInfo.ICProductName;
                        #region History
                        GEObjectHistoryController objObjectHistorysController = new GEObjectHistoryController();
                        GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
                        //=> OldObject 
                        ICProductsInfo oldObject = (ICProductsInfo)semiProductBackupList.FirstOrDefault(t => t.ICProductID == objProductsInfo.ICProductID);
                        if (oldObject != null)
                        {
                            //=> objProductsInfo : newObject
                            ICProductsInfo newObject = (ICProductsInfo)objProductsInfo.Clone();
                            PropertyInfo[] props = oldObject.GetType().GetProperties();
                            string tableName = BOSUtil.GetTableNameFromBusinessObject(oldObject);
                            object oldValue;
                            object newValue;
                            List<GEHistoryDetailsInfo> historyDetailList = new List<GEHistoryDetailsInfo>();
                            foreach (PropertyInfo propInfo in props)
                            {
                                if ((propInfo.Name.Substring(0, 2) != "AA"))
                                //&& (propInfo.Name != "ICProductOrderID")
                                //&& (propInfo.Name != "ICProductParentID")
                                //&& (propInfo.Name != "ICProductItemQty"))
                                {
                                    BOSDbUtil bosDbUtil = new BOSDbUtil();
                                    newValue = bosDbUtil.GetPropertyValue(newObject, propInfo.Name);
                                    oldValue = bosDbUtil.GetPropertyValue(oldObject, propInfo.Name);
                                    if (oldValue != null && newValue != null)
                                    {
                                        if (!oldValue.Equals(newValue))
                                        {
                                            GEHistoryDetailsInfo objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                                            //objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                            objHistoryDetailsInfo.GEHistoryDetailTableName = tableName;
                                            objHistoryDetailsInfo.GEHistoryDetailColumnName = propInfo.Name;
                                            //objHistoryDetailsInfo.GEHistoryDetailParentID = historyDetailParentID;
                                            if (oldValue != null)
                                            {
                                                objHistoryDetailsInfo.GEHistoryDetailOldValue = oldValue.ToString().Trim();
                                            }
                                            if (newValue != null)
                                            {
                                                objHistoryDetailsInfo.GEHistoryDetailNewValue = newValue.ToString().Trim();
                                            }
                                            historyDetailList.Add(objHistoryDetailsInfo);
                                        }
                                    }
                                }
                            }

                            if (historyDetailList != null && historyDetailList.Count > 0)
                            {
                                GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                                objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                objObjectHistoryInfo.GEObjectHistoryObjectName = "Product";
                                objObjectHistoryInfo.GEObjectHistoryObjectID = objProductsInfo.ICProductID;
                                objObjectHistoryInfo.GEObjectHistoryObjectNumber = objProductsInfo.ICProductNo;
                                objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Change.ToString();
                                BOSDbUtil dbUtil = new BOSDbUtil();
                                DateTime currentDate = dbUtil.GetCurrentServerDate();
                                objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                int objectHistoryID = objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                if (objectHistoryID > 0)
                                {
                                    foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in historyDetailList)
                                    {
                                        objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                        objHistoryDetailsController.CreateObject(objHistoryDetailsInfo);
                                    }
                                }
                            }
                        }
                        #endregion
                        //Cập nhật chi tiết
                        objProductsController.UpdateObject(objProductsInfo);
                        //Cập nhật productitems
                        ICProductItemsInfo objProductItemsInfo = objProductItemsController.GetProductItemByParentIDAndChildID(objProductsInfo.ICProductParentID, objProductsInfo.ICProductID);
                        if (objProductItemsInfo != null)
                        {
                            if (objProductItemsInfo.ICProductItemQty != objProductsInfo.ICProductItemQty)
                            {
                                //TNDLoc [ADD][28/04/2016][History ProductItem],START
                                GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                                objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                objObjectHistoryInfo.GEObjectHistoryObjectName = "ProductItem";
                                objObjectHistoryInfo.GEObjectHistoryObjectID = objProductItemsInfo.ICProductItemID;
                                objObjectHistoryInfo.GEObjectHistoryObjectNumber = "";
                                objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Change.ToString();
                                BOSDbUtil dbUtil = new BOSDbUtil();
                                DateTime currentDate = dbUtil.GetCurrentServerDate();
                                objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                int objectHistoryID = objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                if (objectHistoryID > 0)
                                {
                                    GEHistoryDetailsInfo objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                                    objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                    objHistoryDetailsInfo.GEHistoryDetailTableName = "ICProductItems";
                                    objHistoryDetailsInfo.GEHistoryDetailColumnName = "ICProductItemQty";
                                    objHistoryDetailsInfo.GEHistoryDetailOldValue = objProductItemsInfo.ICProductItemQty.ToString();
                                    objHistoryDetailsInfo.GEHistoryDetailNewValue = objProductsInfo.ICProductItemQty.ToString();
                                    objHistoryDetailsController.CreateObject(objHistoryDetailsInfo);

                                }


                                //objProductItemsInfo.ICProductItemQty = objSemiProductGroupsInfo.ICProductItemQty;
                                //objProductItemsController.UpdateObject(objProductItemsInfo);

                                objProductItemsInfo.ICProductItemQty = objProductsInfo.ICProductItemQty;
                                objProductItemsInfo.ICProductItemSortOrder = objProductsInfo.ICProductOrderID;
                                objProductItemsController.UpdateObject(objProductItemsInfo);
                                //TNDLoc [ADD][28/04/2016][History ProductItem],END
                            }
                            else
                            {
                                objProductItemsInfo.ICProductItemSortOrder = objProductsInfo.ICProductOrderID;
                                objProductItemsController.UpdateObject(objProductItemsInfo);
                            }
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
                                int count = objProductsController.GetCountAllSemiProductGroup(objProductGroupsInfo.ICProductNo + ".", ProductionNormConst.MMProductionNormChitiet, ProductType.SemiProduct.ToString());
                                count++;
                                childProductNo = childProductNo.Replace("{1}", count.ToString().PadLeft(2, '0'));
                                objProductsInfo.ICProductNo = childProductNo;
                                //Tạo mới chi tiết
                                if (objProductsController.IsExistProductNo(childProductNo))
                                {
                                    MessageBox.Show(ProductionNormLocalizeResources.MatchNoExceptionMessage.Replace("{0}", childProductNo),
                                                    MESLocalizedResources.MessageBoxDefaultCaption,
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    objProductsInfo.ICProductNo = string.Empty;
                                    isSuccess = false;
                                    break;
                                }
                                else
                                {
                                    objProductsInfo.ICProductDesc = objProductsInfo.ICProductName;
                                    objProductsController.CreateObject(objProductsInfo);

                                    #region History
                                    GEObjectHistoryController objObjectHistorysController = new GEObjectHistoryController();
                                    GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                                    objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                    objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                    objObjectHistoryInfo.GEObjectHistoryObjectName = "Product";
                                    objObjectHistoryInfo.GEObjectHistoryObjectID = objProductsInfo.ICProductID;
                                    objObjectHistoryInfo.GEObjectHistoryObjectNumber = objProductsInfo.ICProductNo;
                                    objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                                    BOSDbUtil dbUtil = new BOSDbUtil();
                                    DateTime currentDate = dbUtil.GetCurrentServerDate();
                                    objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                    objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                    #endregion
                                    //Tạo productItem của chi tiết
                                    ICProductItemsInfo item = new ICProductItemsInfo();
                                    item.FK_ICProductItemParentID = objProductsInfo.ICProductParentID;
                                    item.FK_ICProductItemChildID = objProductsInfo.ICProductID;
                                    item.ICProductItemQty = objProductsInfo.ICProductItemQty;
                                    item.ICProductItemSortOrder = objProductsInfo.ICProductOrderID;
                                    objProductItemsController.CreateObject(item);

                                    objObjectHistoryInfo = new GEObjectHistoryInfo();
                                    objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                    objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                    objObjectHistoryInfo.GEObjectHistoryObjectName = "ProductItem";
                                    objObjectHistoryInfo.GEObjectHistoryObjectID = item.ICProductItemID;
                                    objObjectHistoryInfo.GEObjectHistoryObjectNumber = "";
                                    objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                                    currentDate = dbUtil.GetCurrentServerDate();
                                    objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                    objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                }

                            }

                        }
                        else //Tạo mới chi tiết không cụm
                        {
                            string productNo = GetProductDefaultNo(objMainProductsInfo.ICProductNo);

                            //int count = objProductsController.GetCountAllSemiProductGroup(productNo + ".", ProductionNormConst.MMProductionNormCum, ProductType.SemiProduct.ToString());
                            //count++;
                            //string newSemiProductGroupNo = ProductionNormLocalizeResources.SemiProductGroupDefaultNo.Replace("{0}", productNo);
                            //newSemiProductGroupNo = newSemiProductGroupNo.Replace("{1}", count.ToString().PadLeft(2, '0'));

                            string newSemiProductGroupNo = objProductsController.GetNextNoForGroupOrPieceSemiProduct(productNo, productNo.Length + 3);

                            objProductsInfo.ICProductNo = newSemiProductGroupNo;
                            if (objProductsController.IsExistProductNo(newSemiProductGroupNo))
                            {
                                MessageBox.Show(ProductionNormLocalizeResources.MatchNoExceptionMessage.Replace("{0}", newSemiProductGroupNo),
                                                MESLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                objProductsInfo.ICProductNo = string.Empty;
                                isSuccess = false;
                                break;
                            }
                            else
                            {
                                objProductsInfo.ICProductDesc = objProductsInfo.ICProductName;
                                objProductsController.CreateObject(objProductsInfo);
                                #region History
                                GEObjectHistoryController objObjectHistorysController = new GEObjectHistoryController();
                                GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                                objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                objObjectHistoryInfo.GEObjectHistoryObjectName = "Product";
                                objObjectHistoryInfo.GEObjectHistoryObjectID = objProductsInfo.ICProductID;
                                objObjectHistoryInfo.GEObjectHistoryObjectNumber = objProductsInfo.ICProductNo;
                                objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                                BOSDbUtil dbUtil = new BOSDbUtil();
                                DateTime currentDate = dbUtil.GetCurrentServerDate();
                                objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                objObjectHistorysController.CreateObject(objObjectHistoryInfo);
                                #endregion
                                //create relation
                                List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(productNo, productNo.Length);

                                foreach (ICProductsInfo productsInfo in sameNoProduct)
                                {
                                    ICProductItemsInfo item = new ICProductItemsInfo();
                                    item.FK_ICProductItemParentID = productsInfo.ICProductID;
                                    item.FK_ICProductItemChildID = objProductsInfo.ICProductID;
                                    item.ICProductItemQty = objProductsInfo.ICProductItemQty;
                                    objProductItemsController.CreateObject(item);

                                    objObjectHistoryInfo = new GEObjectHistoryInfo();
                                    objObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                                    objObjectHistoryInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                                    objObjectHistoryInfo.GEObjectHistoryObjectName = "ProductItem";
                                    objObjectHistoryInfo.GEObjectHistoryObjectID = item.ICProductItemID;
                                    objObjectHistoryInfo.GEObjectHistoryObjectNumber = "";
                                    objObjectHistoryInfo.GEObjectHistoryAction = ObjectHistoryAction.Create.ToString();
                                    currentDate = dbUtil.GetCurrentServerDate();
                                    objObjectHistoryInfo.GEObjectHistoryDate = currentDate;
                                    objObjectHistorysController.CreateObject(objObjectHistoryInfo);

                                }
                            }
                        }

                    }
                    #endregion

                }

            }
            if (isSuccess)
            {
                MessageBox.Show(ProductionNormLocalizeResources.SaveSuccessMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                InitSemiProductList(true);
                entity.SemiProductList.GridControl.RefreshDataSource();
            }
        }

        public void RemoveSelectedItemFromProductionNormItemList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo item = entity.ModuleObjects[TableName.MMProductionNormItemsTableName] as MMProductionNormItemsInfo;
            entity.ProductionNormItemList.RemoveSelectedRowObjectFromList();
            CalculateProductionNormItemWoodType();
            CalculateBlockPerOne();
            ChangestatusToEdit(ProductType.SemiProduct.ToString());
        }

        #region Calculate item's informations

        public void CalculateBlockPerOne()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            decimal productBPO = 0; // ProductionNormBlockPerOne : Thành phẩm

            if (entity.ProductionNormItemList != null && entity.ProductionNormItemList.Count > 0)
            {
                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                {
                    decimal groupBPO = 0;// ProductionNormItemBlockPerOne : Cụm & chi tiết rời


                    if (item.SubList != null && item.SubList.Count > 0)
                    {
                        foreach (MMProductionNormItemsInfo itemDetail in item.SubList)
                        {
                            decimal detailBPO = 0;// ProductionNormItemBlockPerOne : chi tiết
                            detailBPO = GetBlockPerOne(itemDetail);
                            itemDetail.MMProductionNormItemBlockPerOne = detailBPO;

                            groupBPO += detailBPO * itemDetail.MMProductionNormItemQuantity;
                        }
                    }
                    else
                    {
                        groupBPO = GetBlockPerOne(item);

                    }
                    item.MMProductionNormItemBlockPerOne = groupBPO;
                    productBPO += groupBPO * item.MMProductionNormItemQuantity;
                }
            }
            objProductionNormsInfo.MMProductionNormBlockPerOne = productBPO;
            objProductionNormsInfo.MMProductionNormBlock = productBPO;
        }

        public decimal GetBlockPerOne(MMProductionNormItemsInfo item)
        {
            decimal BPO = 0;
            BPO = (item.MMProductionNormItemProductLength
                   * item.MMProductionNormItemProductHeight
                   * item.MMProductionNormItemProductWidth) / ProductionNormConst.ProducttionNormValue1000000000;
            return BPO;
        }
        public void CalculateProductionNormItemWoodType()
        {
            #region Controller
            ICProductsController objProductsController = new ICProductsController();
            ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
            //Công thức khối tinh, m2, m3
            MMProductionNormItemConfigsController objProductionNormItemConfigsController = new MMProductionNormItemConfigsController();
            //Hệ số tiêu hao
            MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
            MMFormulaConfigurationsController objFormulasController = new MMFormulaConfigurationsController();
            #endregion
            #region Catch data
            List<MMProductionNormItemConfigsInfo> productionNormItemConfigsList = objProductionNormItemConfigsController.GetProductionNormItemConfigList();
            List<MMFormulaConfigurationsInfo> FormulaConfigList = (List<MMFormulaConfigurationsInfo>)objFormulasController.GetListFromDataSet(objFormulasController.GetAllObjects());
            List<ICDepartmentAttributeValuesInfo> dpAttributeValueList = objDepartmentAttributeValuesController.GetDepartmentAttributeValuesList();
            List<MMConsumableConfigsInfo> ConsumableConfigsList = (List<MMConsumableConfigsInfo>)objConsumableConfigsController.GetListFromDataSet(objConsumableConfigsController.GetAllObjects());
            #endregion
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (entity.ProductionNormItemList != null && entity.ProductionNormItemList.Count > 0)
            {
                decimal productionNormItemTotalWoodConsumable = 0;
                decimal productionNormItemBlocks = 0;
                decimal totalPaint = 0;
                int parentCount = 0;
                int detailCount = 1;
                string[] alpha = AlphaString;
                

                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                {
                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductID == item.FK_ICProductID).FirstOrDefault();
                    if (objProductsInfo == null)
                    {
                        ICProductsInfo objSourceInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objSourceInfo != null) BOSUtil.CopyViewObject(objSourceInfo, objProductsInfo);

                    }
                    if (objProductsInfo != null && objProductsInfo.FK_ICProductGroupID == ProductionNormConst.MMProductionNormChitiet)
                    {

                        MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = 
                            productionNormItemConfigsList.Where( c => c.FK_ICProductAttributeID == objProductsInfo.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
                        if (objProductionNormItemConfigsInfo != null)
                        {
                            item.MMProductionNormItemWoodBlocks = 0;
                            item.MMProductionNormItemBlocks = 0;
                            item.MMProductionNormItemPlywood = 0;
                            item.MMProductionNormItemVeneer = 0;
                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks)
                            {
                                item.MMProductionNormItemWoodBlocks = (item.MMProductionNormItemProductLength *
                                    item.MMProductionNormItemProductWidth * item.MMProductionNormItemProductHeight * item.MMProductionNormItemQuantity)
                                    / ProductionNormConst.ProducttionNormValue1000000000;
                                item.MMProductionNormItemBlocks = item.MMProductionNormItemWoodBlocks;

                            }

                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks)
                            {
                                item.MMProductionNormItemMDFBlocks = (item.MMProductionNormItemProductLength * item.MMProductionNormItemProductWidth
                                    * item.MMProductionNormItemProductHeight * item.MMProductionNormItemQuantity) / ProductionNormConst.ProducttionNormValue1000000000;
                                item.MMProductionNormItemBlocks = item.MMProductionNormItemMDFBlocks;

                            }

                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood)
                            {
                                item.MMProductionNormItemPlywood = (item.MMProductionNormItemProductLength * item.MMProductionNormItemProductWidth
                                    * item.MMProductionNormItemQuantity) / ProductionNormConst.ProducttionNormValue1000000;

                            }

                            if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer)
                            {
                                item.MMProductionNormItemVeneer = (item.MMProductionNormItemProductLength * item.MMProductionNormItemProductWidth
                                    * item.MMProductionNormItemQuantity) / ProductionNormConst.ProducttionNormValue1000000;

                            }
                        }
                        #region SP (M2)
                        item.MMProductionNormItemAcreage = item.MMProductionNormItemQuantity * (2 * (item.MMProductionNormItemProductLength * item.MMProductionNormItemProductWidth)
                            + 2 * (item.MMProductionNormItemProductLength * item.MMProductionNormItemProductHeight)
                            + 2 * (item.MMProductionNormItemProductHeight * item.MMProductionNormItemProductWidth)) / ProductionNormConst.ProducttionNormValue1000000;
                        #endregion

                        #region DT Sơn A (M2) - MMProductionNormItemPaintA
                        //=> sum (MMProductionNormItemPaintA) subList
                        MMFormulaConfigurationsInfo objFormulasInfo = new MMFormulaConfigurationsInfo();
                        decimal surFace = CalSurFace(item);
                        decimal longEdge = CalLongEdge(item);
                        decimal shortEdge = CalShortEdge(item);
                        item.MMProductionNormItemPaintA = 0;
                        if (item.FK_MMFormulaIDPaintA > 0)
                        {
                            objFormulasInfo = FormulaConfigList.Where(f => f.FK_MMFormulaID == item.FK_MMFormulaIDPaintA).FirstOrDefault();
                            if (objFormulasInfo == null)
                                objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(item.FK_MMFormulaIDPaintA);
                            if (objFormulasInfo != null)
                            {
                                item.MMProductionNormItemPaintA = (item.MMProductionNormItemQuantity
                                    * (objFormulasInfo.MMFormulaConfigurationTopQty * surFace
                                    + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdge
                                    + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdge)) / ProductionNormConst.ProducttionNormValue1000000;

                            }
                        }
                        #endregion

                        #region DT Sơn B (M2) - MMProductionNormItemPaintB

                        //=> sum(MMProductionNormItemPaintB) subList
                        item.MMProductionNormItemPaintB = 0;
                        if (item.FK_MMFormulaIDPaintB > 0)
                        {
                            objFormulasInfo = FormulaConfigList.Where(f => f.FK_MMFormulaID == item.FK_MMFormulaIDPaintA).FirstOrDefault();
                            if (objFormulasInfo == null)
                            objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(item.FK_MMFormulaIDPaintB);
                            if (objFormulasInfo != null)
                            {
                                item.MMProductionNormItemPaintB = (item.MMProductionNormItemQuantity
                                    * (objFormulasInfo.MMFormulaConfigurationTopQty * surFace
                                    + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdge
                                    + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdge)) / ProductionNormConst.ProducttionNormValue1000000;

                            }
                        }


                        #endregion


                        #region SortOrder
                        item.MMProductionNormItemSortOrder = parentCount;
                        if (alpha.Length > parentCount)
                        {
                            item.MMProductionNormItemSortOrderString = alpha[parentCount++].ToString();
                        }
                        #endregion
                    }
                    else
                    {

                        #region Khối tinh - MMProductionNormItemWoodBlocks
                        item.MMProductionNormItemWoodBlocks = 0;
                        item.MMProductionNormItemMDFBlocks = 0;
                        item.MMProductionNormItemPlywood = 0;
                        item.MMProductionNormItemVeneer = 0;
                        item.MMProductionNormItemBlocks = 0;

                        #endregion

                        #region SP (M2)
                        item.MMProductionNormItemAcreage = item.MMProductionNormItemQuantity *
                            (2 * (item.MMProductionNormItemProductLength * item.MMProductionNormItemProductWidth)
                            + 2 * (item.MMProductionNormItemProductLength * item.MMProductionNormItemProductHeight)
                            + 2 * (item.MMProductionNormItemProductHeight * item.MMProductionNormItemProductWidth)) / ProductionNormConst.ProducttionNormValue1000000;
                        #endregion

                        #region DT Sơn A (M2) - MMProductionNormItemPaintA
                        //=> sum (MMProductionNormItemPaintA) subList
                        MMFormulaConfigurationsInfo objFormulasInfo = new MMFormulaConfigurationsInfo();

                        item.MMProductionNormItemPaintA = 0;

                        #endregion

                        #region DT Sơn B (M2) - MMProductionNormItemPaintB

                        //=> sum(MMProductionNormItemPaintB) subList
                        item.MMProductionNormItemPaintB = 0;


                        #endregion


                        #region SortOrder
                        item.MMProductionNormItemSortOrder = parentCount;
                        if (alpha.Length > parentCount)
                        {
                            item.MMProductionNormItemSortOrderString = alpha[parentCount].ToString();
                        }
                        #endregion

                        if (item.SubList != null && item.SubList.Count > 0)
                        {

                            foreach (MMProductionNormItemsInfo subItem in item.SubList)
                            {
                                #region SortOrder
                                subItem.MMProductionNormItemSortOrder = detailCount;
                                subItem.MMProductionNormItemSortOrderString = alpha[parentCount] + "." + detailCount.ToString();
                                detailCount++;
                                #endregion

                                #region Khối tinh - MMProductionNormItemWoodBlocks
                                ICProductsForViewInfo objSubProductsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductID == subItem.FK_ICProductID).FirstOrDefault();
                                if (objSubProductsInfo == null)
                                {
                                    ICProductsInfo sourceObj = (ICProductsInfo)objProductsController.GetObjectByID(subItem.FK_ICProductID);
                                    if (sourceObj != null) BOSUtil.CopyViewObject(sourceObj, objSubProductsInfo);
                                }
                                if (objSubProductsInfo != null)
                                {

                                    MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo =
                                        productionNormItemConfigsList.Where(c => c.FK_ICProductAttributeID == objSubProductsInfo.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
                                    if (objProductionNormItemConfigsInfo != null)
                                    {
                                        subItem.MMProductionNormItemBlocks = 0;
                                        subItem.MMProductionNormItemWoodBlocks = 0;
                                        subItem.MMProductionNormItemMDFBlocks = 0;
                                        subItem.MMProductionNormItemPlywood = 0;
                                        subItem.MMProductionNormItemVeneer = 0;
                                        if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks)
                                        {
                                            subItem.MMProductionNormItemWoodBlocks = (subItem.MMProductionNormItemProductLength *
                                                subItem.MMProductionNormItemProductWidth * subItem.MMProductionNormItemProductHeight * subItem.MMProductionNormItemQuantity)
                                                / ProductionNormConst.ProducttionNormValue1000000000;
                                            subItem.MMProductionNormItemBlocks = subItem.MMProductionNormItemWoodBlocks;

                                            item.MMProductionNormItemWoodBlocks += subItem.MMProductionNormItemWoodBlocks;
                                            item.MMProductionNormItemBlocks += subItem.MMProductionNormItemBlocks;
                                        }

                                        if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks)
                                        {
                                            subItem.MMProductionNormItemMDFBlocks = (subItem.MMProductionNormItemProductLength * subItem.MMProductionNormItemProductWidth
                                                * subItem.MMProductionNormItemProductHeight * subItem.MMProductionNormItemQuantity) / ProductionNormConst.ProducttionNormValue1000000000;
                                            subItem.MMProductionNormItemBlocks = subItem.MMProductionNormItemMDFBlocks;

                                            item.MMProductionNormItemMDFBlocks += subItem.MMProductionNormItemMDFBlocks;
                                            item.MMProductionNormItemBlocks += subItem.MMProductionNormItemBlocks;
                                        }

                                        if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood)
                                        {
                                            subItem.MMProductionNormItemPlywood = (subItem.MMProductionNormItemProductLength * subItem.MMProductionNormItemProductWidth
                                                * subItem.MMProductionNormItemQuantity) / ProductionNormConst.ProducttionNormValue1000000;
                                            subItem.MMProductionNormItemBlocks = subItem.MMProductionNormItemPlywood;

                                            item.MMProductionNormItemPlywood += subItem.MMProductionNormItemPlywood;
                                            item.MMProductionNormItemBlocks += subItem.MMProductionNormItemBlocks;
                                        }

                                        if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer)
                                        {
                                            subItem.MMProductionNormItemVeneer = (subItem.MMProductionNormItemProductLength * subItem.MMProductionNormItemProductWidth
                                                * subItem.MMProductionNormItemQuantity) / ProductionNormConst.ProducttionNormValue1000000;
                                            subItem.MMProductionNormItemBlocks = subItem.MMProductionNormItemVeneer;

                                            item.MMProductionNormItemVeneer += subItem.MMProductionNormItemVeneer;
                                            item.MMProductionNormItemBlocks += subItem.MMProductionNormItemBlocks;
                                        }
                                    }
                                }
                                #endregion

                                #region SP (M2)
                                subItem.MMProductionNormItemAcreage = subItem.MMProductionNormItemQuantity *
                                    (2 * (subItem.MMProductionNormItemProductLength * subItem.MMProductionNormItemProductWidth)
                                    + 2 * (subItem.MMProductionNormItemProductLength * subItem.MMProductionNormItemProductHeight)
                                    + 2 * (subItem.MMProductionNormItemProductHeight * subItem.MMProductionNormItemProductWidth)) / ProductionNormConst.ProducttionNormValue1000000;
                                #endregion

                                #region MMProductionNormItemTotalWoodConsumable - KL gỗ tiêu hao
                                subItem.MMProductionNormItemTotalWoodConsumable = subItem.MMProductionNormItemWoodBlocks * subItem.MMProductionNormItemDepreciationRate;
                                #endregion

                                #region Hệ số tiêu hao - MMProductionNormItemDepreciationRate

                                ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfoSub = new ICDepartmentAttributeValuesInfo();
                                if(dpAttributeValueList != null)
                                    objDepartmentAttributeValuesInfoSub = dpAttributeValueList.Where(a => a.ICDepartmentAttributeValueID == subItem.FK_ICProductAttributeSpecialityID).FirstOrDefault();
                                if (objDepartmentAttributeValuesInfoSub != null)
                                {
                                    List<MMConsumableConfigsInfo> objConsumableConfigsInfoSubList = new List<MMConsumableConfigsInfo>();
                                    if(ConsumableConfigsList != null)
                                    objConsumableConfigsInfoSubList = ConsumableConfigsList.Where(c =>
                                        c.MMConsumableConfigAttributeValue == objDepartmentAttributeValuesInfoSub.ICDepartmentAttributeValueValue).ToList();

                                    if (objConsumableConfigsInfoSubList != null && objConsumableConfigsInfoSubList.Count > 0)
                                    {
                                        MMConsumableConfigsInfo objConsumableConfigsInfo = objConsumableConfigsInfoSubList.FirstOrDefault();
                                        subItem.MMProductionNormItemDepreciationRate = objConsumableConfigsInfo.MMConsumableConfigValue;
                                    }
                                }
                                #endregion

                                decimal surFaceSub = CalSurFace(subItem);
                                decimal longEdgeSub = CalLongEdge(subItem);
                                decimal shortEdgeSub = CalShortEdge(subItem);

                                #region DT Sơn A (M2) - MMProductionNormItemPaintA
                                subItem.MMProductionNormItemPaintA = 0;
                                if (subItem.FK_MMFormulaIDPaintA > 0)
                                {
                                    objFormulasInfo = FormulaConfigList.Where(f => f.FK_MMFormulaID == item.FK_MMFormulaIDPaintA).FirstOrDefault();
                                    if (objFormulasInfo == null)
                                        objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(subItem.FK_MMFormulaIDPaintA);
                                    if (objFormulasInfo != null)
                                    {
                                        subItem.MMProductionNormItemPaintA = (subItem.MMProductionNormItemQuantity
                                            * (objFormulasInfo.MMFormulaConfigurationTopQty * surFaceSub
                                            + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdgeSub
                                            + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdgeSub)) / ProductionNormConst.ProducttionNormValue1000000;
                                        item.MMProductionNormItemPaintA += subItem.MMProductionNormItemPaintA;
                                    }
                                }
                                #endregion

                                #region DT Sơn B (M2) - MMProductionNormItemPaintB
                                subItem.MMProductionNormItemPaintB = 0;
                                if (subItem.FK_MMFormulaIDPaintB > 0)
                                {
                                    objFormulasInfo = FormulaConfigList.Where(f => f.FK_MMFormulaID == item.FK_MMFormulaIDPaintA).FirstOrDefault();
                                    if (objFormulasInfo == null)
                                        objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(subItem.FK_MMFormulaIDPaintB);
                                    if (objFormulasInfo != null)
                                    {
                                        subItem.MMProductionNormItemPaintB = (subItem.MMProductionNormItemQuantity
                                            * (objFormulasInfo.MMFormulaConfigurationTopQty * surFaceSub
                                            + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdgeSub
                                            + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdgeSub)) / ProductionNormConst.ProducttionNormValue1000000;

                                        item.MMProductionNormItemPaintB += subItem.MMProductionNormItemPaintB;
                                    }
                                }
                                #endregion

                            }
                            parentCount++;
                            detailCount = 1;
                        }
                    }
                    productionNormItemTotalWoodConsumable += item.MMProductionNormItemTotalWoodConsumable;
                    productionNormItemBlocks += item.MMProductionNormItemWoodBlocks;
                    totalPaint += (item.MMProductionNormItemPaintA + item.MMProductionNormItemPaintB);


                    #region MMProductionNormItemTotalWoodConsumable - KL gỗ tiêu hao
                    item.MMProductionNormItemTotalWoodConsumable = item.MMProductionNormItemWoodBlocks * item.MMProductionNormItemDepreciationRate;
                    #endregion

                    #region Hệ số tiêu hao - MMProductionNormItemDepreciationRate
                    ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = new ICDepartmentAttributeValuesInfo();
                    if (dpAttributeValueList != null)
                        objDepartmentAttributeValuesInfo = dpAttributeValueList.Where(a => a.ICDepartmentAttributeValueID == item.FK_ICProductAttributeSpecialityID).FirstOrDefault();
                    
                    if (objDepartmentAttributeValuesInfo != null)
                    {
                        List<MMConsumableConfigsInfo> objConsumableConfigsInfoList = new List<MMConsumableConfigsInfo>();
                        if (ConsumableConfigsList != null)
                            objConsumableConfigsInfoList = ConsumableConfigsList.Where(c =>
                                c.MMConsumableConfigAttributeValue == objDepartmentAttributeValuesInfo.ICDepartmentAttributeValueValue).ToList();
                        if (objConsumableConfigsInfoList != null && objConsumableConfigsInfoList.Count > 0)
                        {
                            MMConsumableConfigsInfo objConsumableConfigsInfo = objConsumableConfigsInfoList.FirstOrDefault();
                            item.MMProductionNormItemDepreciationRate = objConsumableConfigsInfo.MMConsumableConfigValue;
                        }
                    }
                    #endregion

                }
                //DT sơn [MainObject]
                objProductionNormsInfo.MMProductionNormTotalPaint = totalPaint;

                #region Hệ số tiêu hao - [MMProductionNormDepreciationRate]
                if (productionNormItemBlocks != 0)
                {
                    objProductionNormsInfo.MMProductionNormDepreciationRate = Math.Round(productionNormItemTotalWoodConsumable / productionNormItemBlocks, 2, MidpointRounding.AwayFromZero);
                }
                #endregion

                #region Tổng m3 tinh
                objProductionNormsInfo.MMProductionNormBlock = Math.Round(productionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
                #endregion

                entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemList.TreeListControl.BestFitColumns();
                entity.ProductionNormItemList.TreeListControl.ExpandAll();
            }
        }
        #endregion

        #region Summary
        public decimal GetSumProductionNormItemQty()
        {
            decimal result = 0;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null && !objProductsInfo.HasComponent)
                {
                    result += item.MMProductionNormItemQuantity;
                }
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMProductionNormItemQuantity;
                    }
                }
            }
            return result;
        }

        public decimal GetSumProductionNormItemBlocks()
        {
            decimal result = 0;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMProductionNormItemWoodBlocks;
            }
            return result;
        }
        public decimal GetSumProductionNormItemWoodConsumable()
        {
            decimal result = 0;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                if (!item.MMProductionNormItemIsComponent)
                {
                    result += item.MMProductionNormItemTotalWoodConsumable;
                }
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo itemChild in item.SubList)
                    {
                        result += itemChild.MMProductionNormItemTotalWoodConsumable;
                    }
                }
            }
            return result;
        }
        public decimal GetSumProductionNormItemMDFBlock()
        {
            decimal result = 0;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMProductionNormItemMDFBlocks;
            }
            return result;
        }
        public decimal GetSumProductionNormItemPaintA()
        {
            decimal result = 0;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMProductionNormItemPaintA;
            }
            return result;
        }
        public decimal GetSumProductionNormItemPaintB()
        {
            decimal result = 0;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMProductionNormItemPaintB;
            }
            return result;
        }
        public decimal GetSumProductionNormItemVeneer()
        {
            decimal result = 0;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMProductionNormItemVeneer;
            }
            return result;
        }
        #endregion

        public System.Data.DataTable GetFormulaTable()
        {
            MMFormulasController objFormulasController = new MMFormulasController();
            DataSet ds = objFormulasController.GetFormulaData();
            System.Data.DataTable dt = new System.Data.DataTable();
            if (ds != null)
                dt = ds.Tables[0];
            return dt;
        }

        #region Cell Value Changed
        public void ChangeItemFromProductionNormItemsList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
            CalculateProductionNormItemWoodType();
            CalculateBlockPerOne();
            entity.ProductionNormItemList.TreeListControl.ExpandAll();
            entity.ProductionNormItemList.TreeListControl.BestFitColumns();
            entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
        }
        public void ChangestatusToEdit(string productionType)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (productionType == ProductType.SemiProduct.ToString())
            {
                if (objProductionNormsInfo.MMProductionNormWoodStatus != MMProductionNormStatus.New.ToString()
                    && objProductionNormsInfo.MMProductionNormWoodStatus != MMProductionNormStatus.Edit.ToString())
                {
                    objProductionNormsInfo.MMProductionNormWoodStatus = MMProductionNormStatus.Edit.ToString();
                    objProductionNormsInfo.MMProductionNormOperationStatus = MMProductionNormStatus.Edit.ToString();
                    EnableToolbar(ProductionNormConst.ChangestatusSemiProduct);
                }
            }

            if (productionType == ProductType.Hardware.ToString())
            {
                if (objProductionNormsInfo.MMProductionNormHardwareStatus != MMProductionNormStatus.New.ToString()
                    && objProductionNormsInfo.MMProductionNormHardwareStatus != MMProductionNormStatus.Edit.ToString())
                {
                    objProductionNormsInfo.MMProductionNormHardwareStatus = MMProductionNormStatus.Edit.ToString();
                    EnableToolbar(ProductionNormConst.ChangestatusHardware);
                }
            }
            if (productionType == ProductType.IngredientPackaging.ToString())
            {
                if (objProductionNormsInfo.MMProductionNormPackingMaterialStatus != MMProductionNormStatus.New.ToString()
                    && objProductionNormsInfo.MMProductionNormPackingMaterialStatus != MMProductionNormStatus.Edit.ToString())
                {
                    objProductionNormsInfo.MMProductionNormPackingMaterialStatus = MMProductionNormStatus.Edit.ToString();
                    EnableToolbar(ProductionNormConst.ChangestatusComponent);
                }
            }

            if (productionType == ProductType.IngredientPaint.ToString())
            {
                if (objProductionNormsInfo.MMProductionNormPaintStatus != MMProductionNormStatus.New.ToString()
                    && objProductionNormsInfo.MMProductionNormPaintStatus != MMProductionNormStatus.Edit.ToString())
                {
                    objProductionNormsInfo.MMProductionNormPaintStatus = MMProductionNormStatus.Edit.ToString();
                    EnableToolbar(ProductionNormConst.ChangestatusPaint);
                }
            }
            if (productionType == ProductType.GeneralMaterial.ToString())
            {
                if (objProductionNormsInfo.MMProductionNormGeneralMaterialStatus != MMProductionNormStatus.New.ToString()
                    && objProductionNormsInfo.MMProductionNormGeneralMaterialStatus != MMProductionNormStatus.Edit.ToString())
                {
                    objProductionNormsInfo.MMProductionNormGeneralMaterialStatus = MMProductionNormStatus.Edit.ToString();
                    EnableToolbar(ProductionNormConst.ChangestatusGeneralMaterial);
                }
            }
        }
        #endregion

        #region Picture BOM
        public void ChooseProduct()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo currentItem = (MMProductionNormItemsInfo)entity.ModuleObjects[TableName.MMProductionNormItemsTableName];
            guiChoosePictureProduct guiChoosePicture = new guiChoosePictureProduct();
            guiChoosePicture.Module = this;
            if (guiChoosePicture.ShowDialog() == DialogResult.OK)
            {
                if (entity.SemiProductList.CurrentIndex > 0)
                {
                    ICProductsInfo objProductsInfo = entity.SemiProductList[entity.SemiProductList.CurrentIndex];
                }
            }
        }

        public void BrowseFile()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Duyệt file...";
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }
            dialog.Filter = codecFilter;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (entity.SemiProductList.CurrentIndex > 0)
                {
                    ICProductsController objICProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = entity.SemiProductList[entity.SemiProductList.CurrentIndex];
                    string fileName = objProductsInfo.ICProductNo + Path.GetExtension(dialog.SafeFileName);
                    try
                    {
                        UploadFileFTP(dialog.FileName, fileName, SubFolder, objProductsInfo);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ProductionNormLocalizeResources.FTPError, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    objProductsInfo.ICProductImageFile = fileName;
                    objICProductsController.UpdateObject(objProductsInfo);
                    MessageBox.Show(ProductionNormLocalizeResources.UploadFileSuccessfullyMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void DefualtFileName(string fileExtension)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsController objICProductsController = new ICProductsController();
            foreach (ICProductsInfo item in entity.SemiProductList)
            {
                item.ICProductImageFile = item.ICProductNo + "." + fileExtension;
                objICProductsController.UpdateObject(item);
            }

            MessageBox.Show(ProductionNormLocalizeResources.UploadFileSuccessfullyMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteFile()
        {

        }

        private bool CreateFTPDirectory(string directoryPath, string ftpUser, string ftpPassword)
        {
            try
            {
                //create the directory
                FtpWebRequest requestDir = (FtpWebRequest)FtpWebRequest.Create(new Uri(directoryPath));
                requestDir.Method = WebRequestMethods.Ftp.MakeDirectory;
                requestDir.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                requestDir.UsePassive = true;
                requestDir.UseBinary = true;
                requestDir.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)requestDir.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();

                return true;
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    response.Close();
                    return true;
                }
                else
                {
                    response.Close();
                    return false;
                }
            }
        }

        public bool UploadFileFTP(string filePath, string fileName, string subFolder, ICProductsInfo objProductsInfo)
        {
            bool flag = false;
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();

                FileInfo fileInfo = new FileInfo(filePath);
                WebRequest requestFTP;

                if (!String.IsNullOrEmpty(ftp_homedir))
                {
                    //Create home dir if not exists
                    if (CreateFTPDirectory("ftp://" + ftp_host + "/" + ftp_homedir, ftp_username, ftp_password) == false)
                    {
                        return false;
                    }

                    subFolder = ftp_homedir + "/" + subFolder;
                }

                //Create sub folder if not exists
                if (!String.IsNullOrEmpty(subFolder))
                {
                    if (CreateFTPDirectory("ftp://" + ftp_host + "/" + subFolder, ftp_username, ftp_password) == false)
                    {
                        return false;
                    }
                }

                if (String.IsNullOrEmpty(subFolder))
                {
                    requestFTP = WebRequest.Create("ftp://" + ftp_host + "/" + fileName);
                }
                else
                {
                    requestFTP = WebRequest.Create("ftp://" + ftp_host + "/" + subFolder + "/" + fileName);
                }

                requestFTP.Credentials = new NetworkCredential(ftp_username, ftp_password);
                requestFTP.Method = WebRequestMethods.Ftp.UploadFile;
                FileStream fStream = fileInfo.OpenRead();
                int bufferLength = 2048;
                byte[] buffer = new byte[bufferLength];

                Stream uploadStream = null;
                try
                {
                    uploadStream = requestFTP.GetRequestStream();
                    objProductsInfo.ICProductPicture = buffer;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                int contentLength = fStream.Read(buffer, 0, bufferLength);

                while (contentLength != 0)
                {
                    uploadStream.Write(buffer, 0, contentLength);
                    contentLength = fStream.Read(buffer, 0, bufferLength);
                }
                uploadStream.Close();
                fStream.Close();
                requestFTP = null;
                flag = true;
            }
            catch (Exception ep)
            {
                MessageBox.Show("ERROR: " + ep.Message.ToString());

            }
            return flag;

        }
        #endregion

        public void ShowProductionNormItemMeterial(MMProductionNormItemsInfo objProductionNormItemsInfo)
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                //MessageBox.Show("Vui lòng click sửa trước khi thực hiện!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.ProductionNormItemMeterialList.Clear();
            if (objProductionNormItemsInfo.MMProductionNormItemID == 0)
            {
                MessageBox.Show("Bảng định mức chưa lưu, vui lòng lưu để thêm nguyên liệu!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (objProductionNormItemsInfo.MMProductionNormItemIsComponent)
            {
                return;
            }
            ICProductsController objProductsController = new ICProductsController();
            if (objProductionNormItemsInfo != null)
            {
                
                MMProductionNormItemMeterialsController objProductionNormItemMeterialsController = new MMProductionNormItemMeterialsController();
                List<MMProductionNormItemMeterialsInfo> ProductionNormItemMeterialsInfoList = objProductionNormItemMeterialsController.
                    GetProductionNormItemMeterialsByProductionNormItemID(objProductionNormItemsInfo.MMProductionNormItemID);
                if (ProductionNormItemMeterialsInfoList != null && ProductionNormItemMeterialsInfoList.Count > 0)
                {
                    foreach (MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo in ProductionNormItemMeterialsInfoList)
                    {
                        entity.ProductionNormItemMeterialList.Add(objProductionNormItemMeterialsInfo);
                    }
                }
                guiProductionNormItemMeterials guiForm = new guiProductionNormItemMeterials(entity.ProductionNormItemMeterialList);
                guiForm.Module = this;
                guiForm.objProductionNormItemsInfo = objProductionNormItemsInfo;
                guiForm.ShowDialog();
            }
        }

        public void SaveProductionNormItemMeterial()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.ProductionNormItemMeterialList != null && entity.ProductionNormItemMeterialList.Count > 0)
            {
                for (int i = 0; i < entity.ProductionNormItemMeterialList.Count - 1; i++)
                {
                    for (int j = i + 1; j < entity.ProductionNormItemMeterialList.Count; j++)
                    {
                        if (entity.ProductionNormItemMeterialList[i].FK_ICProductID == entity.ProductionNormItemMeterialList[j].FK_ICProductID)
                        {
                            MessageBox.Show("Nguyên liệu không được trùng. Vui lòng kiểm tra lại!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                entity.ProductionNormItemMeterialList.SaveItemObjects();
            }
        }
        public void ResetMeterialValue(MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo)
        {
            objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWidth = 0;
            objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialLength = 0;
            objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth = 0;

        }
        public void ValidateChangeMeterial(MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo, int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = objProductsController.GetProductByID(productID);
            if (objProductsInfo != null)
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;

                MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
                MMFormulaConfigurationsController objFormulaConfigurationsController = new MMFormulaConfigurationsController();
                MMExchangeMeasureUnitConfigsController objExchangeMeasureUnitConfigs = new MMExchangeMeasureUnitConfigsController();
                objProductionNormItemMeterialsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                if (objProductionNormItemsInfo != null)
                {

                    objProductionNormItemMeterialsInfo.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks = objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable;
                    objProductionNormItemMeterialsInfo.FK_ICProductAlternativeID = objProductsInfo.ICProductID;
                    objProductionNormItemMeterialsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    if (objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty == 0)
                        objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty = 1;
                    int woodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    MMExchangeRateConfigsController objExchangeRateConfigsController = new MMExchangeRateConfigsController();
                    MMExchangeRateConfigsInfo objExchangeRateConfigsInfo = (MMExchangeRateConfigsInfo)objExchangeRateConfigsController
                       .GetExchangeRateConfigLumberByThick(objProductionNormItemsInfo.MMProductionNormItemProductHeight);
                    //Loại gỗ phách
                    if (objExchangeRateConfigsInfo != null
                        && objProductsInfo.ICProductType == ProductType.Lumber.ToString())
                    {
                        objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth = objExchangeRateConfigsInfo.MMExchangeRateConfigThickExchange;
                    }
                    else if(objExchangeRateConfigsInfo == null
                        && objProductsInfo.ICProductType == ProductType.Lumber.ToString() && objProductsInfo.ICProductHeight > 0)
                    {
                        objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth = objProductsInfo.ICProductHeight;
                    }
                    if (objProductsInfo.ICProductHeight > 0 && objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth != objProductsInfo.ICProductHeight)
                    {
                        objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth = objProductsInfo.ICProductHeight;
                    }
                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks = objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable;

                    //Ván
                    if ((objProductsInfo.ICProductType == ProductType.Verneer.ToString() || objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString()))
                    {
                        if (objProductionNormItemsInfo.MMProductionNormItemVeneer > 0)
                        {
                            // Tính lại số ván cần cấp theo cấu hình
                            if (objProductionNormItemMeterialsInfo.FK_ICMeasureUnitID > 0)
                            {
                                List<MMExchangeMeasureUnitConfigsInfo> objExchangeMeasureUnitConfigList
                                = objExchangeMeasureUnitConfigs.GetExchangeMeasureUnitConfigsBySomeConditions(objProductsInfo.ICProductID, objProductionNormItemMeterialsInfo.FK_ICMeasureUnitID, 0);
                                if (objExchangeMeasureUnitConfigList != null && objExchangeMeasureUnitConfigList.Count > 0)
                                {
                                    if (objExchangeMeasureUnitConfigList[0].MMExchangeMeasureUnitConfigSize > 0)
                                        objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks =
                                                                                            objProductionNormItemsInfo.MMProductionNormItemVeneer 
                                                                                            * objProductionNormItemsInfo.MMProductionNormItemDepreciationRate;
                                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty =
                                                                                            objProductionNormItemsInfo.MMProductionNormItemVeneer 
                                                                                            * objProductionNormItemsInfo.MMProductionNormItemDepreciationRate /
                                                                                            objExchangeMeasureUnitConfigList[0].MMExchangeMeasureUnitConfigSize;
                                }
                                else
                                {
                                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty = objProductionNormItemsInfo.MMProductionNormItemQuantity;
                                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks = objProductionNormItemsInfo.MMProductionNormItemVeneer 
                                        * objProductionNormItemsInfo.MMProductionNormItemDepreciationRate;
                                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth = objProductionNormItemsInfo.MMProductionNormItemProductHeight;
                                }

                            }
                        }
                        else
                        {
                            ResetMeterialValue(objProductionNormItemMeterialsInfo);
                        }
                    }
                    objProductionNormItemsInfo.FK_ICProductWoodIngredientID = objProductsInfo.ICProductID;
                    objProductionNormItemsInfo.IsError = false;
                }
            }
        }
        public void ResetBlockByConfigWoodType(MMProductionNormItemMeterialsInfo item, ICProductsForViewInfo objProductsInfo)
        {
            MMProductionNormItemConfigsController objProductionNormItemConfigsController = new MMProductionNormItemConfigsController();
            MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = objProductionNormItemConfigsController.GetProductionNormItemConfigByWoodTypeID(objProductsInfo.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
            if (objProductionNormItemConfigsInfo != null)
            {
                
                if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks)
                {
                    item.MMProductionNormItemMeterialWoodBlocks = (item.MMProductionNormItemMeterialLength *
                        item.MMProductionNormItemMeterialWidth * item.MMProductionNormItemMeterialHeigth * item.MMProductionNormItemMeterialQty)
                        / (decimal)Math.Pow(10,9);
                }

                if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks)
                {
                    item.MMProductionNormItemMeterialWoodBlocks = (item.MMProductionNormItemMeterialLength * item.MMProductionNormItemMeterialWidth
                        * item.MMProductionNormItemMeterialHeigth * item.MMProductionNormItemMeterialQty) / (decimal)Math.Pow(10, 9);
                }

                if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood)
                {
                    item.MMProductionNormItemMeterialWoodBlocks = (item.MMProductionNormItemMeterialLength * item.MMProductionNormItemMeterialWidth
                        * item.MMProductionNormItemMeterialQty) / (decimal)Math.Pow(10, 6);

                }

                if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer)
                {
                    item.MMProductionNormItemMeterialWoodBlocks = (item.MMProductionNormItemMeterialLength * item.MMProductionNormItemMeterialWidth
                        * item.MMProductionNormItemMeterialQty) / (decimal)Math.Pow(10, 6);

                }
            }
        }
        public void UpdateMeterialConfig()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                MessageBox.Show("Vui lòng lưu chi tiết trước!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (objProductionNormsInfo.MMProductionNormWoodStatus == MMProductionNormStatus.Approved.ToString())
            {
              if(  MessageBox.Show("Bảng định mức BTP đã duyệt bạn thật sự muốn thay đổi?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.No)
                return;
            }
            MMProductionNormItemMeterialsController objProductionNormItemMeterialsController = new MMProductionNormItemMeterialsController();
            List<MMProductionNormItemMeterialsInfo> ProductionNormItemMeterialsInfoList = objProductionNormItemMeterialsController.
                GetAllMeterialsByProductionNormID(objProductionNormsInfo.MMProductionNormID);
            if (ProductionNormItemMeterialsInfoList != null && ProductionNormItemMeterialsInfoList.Count > 0)
            {
                if (MessageBox.Show("Bảng định mức BTP đã tồn tại nguyên liệu, bạn có muốn cập nhật không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.No)
                    return;
            }
            //Get all config
            MMExchangeRateConfigsController objExchangeRateConfigsController = new MMExchangeRateConfigsController();
            List<MMExchangeRateConfigsInfo> objExchangeRateConfigList = (List<MMExchangeRateConfigsInfo>)objExchangeRateConfigsController.GetListFromDataSet(objExchangeRateConfigsController.GetAllObjects());

            List<MMProductionNormItemMeterialsInfo> UpdateList = new List<MMProductionNormItemMeterialsInfo>();
            bool isSuccess = false;
            BOSProgressBar.Start("Đang cập dữ liệu...");
            string mess = string.Empty;
            string woodtype = string.Empty;
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo subItem in item.SubList)
                    {
                        MMProductionNormItemMeterialsInfo objItemMeterialsInfo =
                            ProductionNormItemMeterialsInfoList.Where(x => x.FK_MMProductionNormItemID == subItem.MMProductionNormItemID).FirstOrDefault();
                        if (objItemMeterialsInfo == null || objItemMeterialsInfo.MMProductionNormItemMeterialID == 0)
                        {
                            objItemMeterialsInfo = GetMeterialFromConfig(subItem, objExchangeRateConfigList, ref mess);
                            if (objItemMeterialsInfo != null && objItemMeterialsInfo.FK_ICProductID > 0)
                            {
                                objProductionNormItemMeterialsController.CreateObject(objItemMeterialsInfo);
                                subItem.IsError = false;
                                isSuccess = true;
                            }
                            else
                            {
                                subItem.IsError = true;
                                isSuccess = false;
                                if (!woodtype.Contains(subItem.MMProductionNormItemProductWoodType))
                                    woodtype += Environment.NewLine + subItem.MMProductionNormItemProductWoodType;
                            }
                        }
                        else
                        {
                            int ProductionNormItemMeterial = objItemMeterialsInfo.MMProductionNormItemMeterialID;

                            objItemMeterialsInfo = GetMeterialFromConfig(subItem, objExchangeRateConfigList, ref mess);
                            if (objItemMeterialsInfo != null && objItemMeterialsInfo.FK_ICProductID > 0)
                            {
                                objItemMeterialsInfo.MMProductionNormItemMeterialID = ProductionNormItemMeterial;
                                objProductionNormItemMeterialsController.UpdateObject(objItemMeterialsInfo);
                                subItem.IsError = false;
                                isSuccess = true;
                            }
                            else
                            {
                                subItem.IsError = true;
                                isSuccess = false;

                                if (!woodtype.Contains(subItem.MMProductionNormItemProductWoodType))
                                woodtype += Environment.NewLine + subItem.MMProductionNormItemProductWoodType;
                            }
                        }
                        
                    }
                }
            }
            if (isSuccess && mess == string.Empty)
                MessageBox.Show(ProductionNormLocalizeResources.UploadFileSuccessfullyMessage, MESLocalizedResources.MessageBoxDefaultCaption
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mess + woodtype, MESLocalizedResources.MessageBoxDefaultCaption
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
            BOSProgressBar.Close();

        }
        public MMProductionNormItemMeterialsInfo GetMeterialFromConfig(MMProductionNormItemsInfo objProductionNormItemsInfo
            , List<MMExchangeRateConfigsInfo> objExchangeRateConfigList,ref string mess)
        {

            MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo = new MMProductionNormItemMeterialsInfo();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductID == objProductionNormItemsInfo.FK_ICProductID).FirstOrDefault();
            if (objProductsInfo == null || objProductsInfo.ICProductID == 0)
            {
                ICProductsInfo objSourcesInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormItemsInfo.FK_ICProductID);
                if (objSourcesInfo != null) BOSUtil.CopyViewObject(objSourcesInfo, objProductsInfo);
            }
            if (objProductsInfo != null)
            {
                if (objProductionNormItemsInfo != null)
                {
                    MMExchangeRateConfigsInfo objExchangeRateConfigsInfo = objExchangeRateConfigList.Where(
                        x => x.MMExchangeRateConfigThickValue == objProductionNormItemsInfo.MMProductionNormItemProductHeight).FirstOrDefault();

                    if (objExchangeRateConfigsInfo == null || objExchangeRateConfigsInfo.MMExchangeRateConfigID == 0)
                    {
                        mess += Environment.NewLine + "Cấu hình quy đổi độ dày: " + objProductionNormItemsInfo.MMProductionNormItemProductHeight;
                        return null;
                    }
                    else
                    {
                        ICProductsForViewInfo objProductMeterialsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductHeight == objExchangeRateConfigsInfo.MMExchangeRateConfigThickExchange
                            && x.FK_ICProductAttributeWoodTypeID == objProductsInfo.FK_ICProductAttributeWoodTypeID).FirstOrDefault();

                        if (objProductMeterialsInfo != null)
                        {
                            objProductionNormItemMeterialsInfo = new MMProductionNormItemMeterialsInfo();
                            objProductionNormItemMeterialsInfo.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                            objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks = objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable;
                            objProductionNormItemMeterialsInfo.FK_ICProductAlternativeID = objProductMeterialsInfo.ICProductID;
                            objProductionNormItemMeterialsInfo.FK_ICProductID = objProductMeterialsInfo.ICProductID;
                            objProductionNormItemMeterialsInfo.FK_ICMeasureUnitID = objProductMeterialsInfo.FK_ICProductBasicUnitID;
                            objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth = objProductMeterialsInfo.ICProductHeight;
                            if (objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty == 0)
                                objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty = 1;
                            return objProductionNormItemMeterialsInfo;
                        }
                        else
                        {
                            mess += Environment.NewLine + "Không tìm thấy nguyên liệu dày: " + objExchangeRateConfigsInfo.MMExchangeRateConfigThickExchange;
                            return null;
                        }

                    }

                }
            }
            
            return null;
        }
        public bool CheckMeterialExit()
        {
            bool result = true;
            //ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            //MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            //MMProductionNormItemMeterialsController objProductionNormItemMeterialsController = new MMProductionNormItemMeterialsController();
            //List<MMProductionNormItemMeterialsInfo> ProductionNormItemMeterialsInfoList = objProductionNormItemMeterialsController.
            //    GetAllMeterialsByProductionNormID(objProductionNormsInfo.MMProductionNormID);

            //foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
            //{
            //    if (item.SubList != null && item.SubList.Count > 0)
            //    {
            //        foreach (MMProductionNormItemsInfo subItem in item.SubList)
            //        {
            //            if (ProductionNormItemMeterialsInfoList != null && ProductionNormItemMeterialsInfoList.Count > 0)
            //            {
            //                MMProductionNormItemMeterialsInfo objItemMeterialsInfo =
            //                ProductionNormItemMeterialsInfoList.Where(x => x.FK_MMProductionNormItemID == subItem.MMProductionNormItemID).FirstOrDefault();
            //                if (objItemMeterialsInfo == null || objItemMeterialsInfo.MMProductionNormItemMeterialID == 0)
            //                {
            //                    subItem.IsError = true;
            //                    result = false;
            //                }
            //            }
            //            else
            //            {
            //                subItem.IsError = true;
            //                result = false;
            //            }
            //        }
            //    }
            //}
            
            //if (!result)
            //    MessageBox.Show(ProductionNormLocalizeResources.MissProductWoodIngredientError, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }

        #region import
        public void ImportProductionNorm()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            try
            {
                ICProductsController objProductsController = new ICProductsController();

                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;

                if (mainObject.FK_ICProductID == 0)
                {
                    MessageBox.Show("Vui lòng chọn thành phẩm trước khi import", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ICProductsController productController = new ICProductsController();
                if (productController.IsHasBOM(mainObject.FK_ICProductID))
                {
                    MessageBox.Show("Thành phẩm đã có bản định mức. Vui lòng kiểm tra lại", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ICProductsInfo objMainProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(mainObject.FK_ICProductID);
                if (objMainProductsInfo == null)
                    return;

                List<ICProductsInfo> semiProductsList = objProductsController.GetSemiProductByProductNo(objMainProductsInfo.ICProductNo, ProductType.SemiProduct.ToString());

                if (semiProductsList != null && semiProductsList.Count > 0)
                {
                    if (MessageBox.Show(ProductionNormLocalizeResources.SemiProductExistConfirmMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                List<Range> ranges = InitializeDataImport();
                if (ranges == null)
                    return;
                if (MessageBox.Show(MESLocalizedResources.QuestionImportDataMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                BOSProgressBar.Start(MESLocalizedResources.ProgressBarMessage);

                Range woods = ranges[0];

                ImportProductionNormWoods(woods,objMainProductsInfo);

                Range hardwares = ranges[1];

                ImportProductionNormHardwares(hardwares);
                BOSApp.CurrentProductList = productController.GetListViewFromDataSet(BOSApp.GetLookupTableData(TableName.ICProductsTableName));

                BOSProgressBar.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lổi xãy ra:" + ex.Message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                BOSProgressBar.Close();
                return;
            }
        }

        public List<Range> InitializeDataImport()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = MESLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
                filePath = dialog.FileName;
            if (!String.IsNullOrEmpty(filePath))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                App = new ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                List<Range> result = new List<Range>();
                for (int i = 1; i <= WorkBook.Worksheets.Count; i++)
                {
                    WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(i);
                    Range range = WorkSheet.UsedRange;
                    result.Add(range);
                }
                return result;
            }
            return null;
        }

        public decimal GetDecimalFromString(object range)
        {
            decimal result = 0;
            if (range != null)
            {
                decimal.TryParse(range.ToString(), out result);
            }
            return result;
        }
        public int GetIntFromString(object range)
        {
            int result = 0;
            if (range != null)
            {
                int.TryParse(range.ToString(), out result);
            }
            return result;
        }

        public void ImportProductionNormWoods(Range range, ICProductsInfo objMainProductsInfo)
        {
            if (range == null)
                return;
            try
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
                ICProductItemsController objProductItemsController = new ICProductItemsController();
                ICProductsController objProductsController = new ICProductsController();
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();

                ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();

                ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.SemiProductNo.ToString()));
                if (objDepartmentsInfo == null)
                    return;

                List<ICProductAttributesInfo> productAttributes = new List<ICProductAttributesInfo>();
                productAttributes = (List<ICProductAttributesInfo>)objProductAttributesController.GetListFromDataSet(objProductAttributesController.GetAllObjects());
                MMFormulasController objMMFormulasController = new MMFormulasController();
                List<MMFormulasInfo> listFormulas = new List<MMFormulasInfo>();
                listFormulas = (List<MMFormulasInfo>)objMMFormulasController.GetListFromDataSet(objMMFormulasController.GetAllObjects());

                List<ICProductsInfo> productGroups = new List<ICProductsInfo>();
                List<ICProductsInfo> productDetails = new List<ICProductsInfo>();
                List<ICProductsInfo> productPieces = new List<ICProductsInfo>();
                ICProductsInfo objProductsInfo;
                MMFormulasInfo objMMFormulasInfo;
                ICProductAttributesInfo objProductAttributesInfo;
                MMProductionNormItemsInfo objProductionNormItemsInfo;
                MMProductionNormItemsInfo subProductionNormItem;
                MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> productionNormItems = new List<MMProductionNormItemsInfo>();
                List<ICProductItemsInfo> productItems = new List<ICProductItemsInfo>();

                for (int row = 2; row <= range.Rows.Count; row++)
                {
                    if (!string.IsNullOrEmpty((range.Cells[row, 2] as Range).Text.ToString().Trim()))
                    {
                        objProductsInfo = new ICProductsInfo();
                        objProductsInfo.ICProductCode = (range.Cells[row, 1] as Range).Text.ToString().Trim();
                        objProductsInfo.ICProductName = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                        objProductsInfo.ICProductTypeDetails = (range.Cells[row, 3] as Range).Text.ToString().Trim();
                        objProductsInfo.ICProductParentCode = (range.Cells[row, 4] as Range).Text.ToString().Trim();
                        objProductsInfo.ICProductHeight = GetDecimalFromString((range.Cells[row, 5] as Range).Value2);
                        objProductsInfo.ICProductWidth = GetDecimalFromString((range.Cells[row, 6] as Range).Value2);
                        objProductsInfo.ICProductLength = GetDecimalFromString((range.Cells[row, 7] as Range).Value2);
                        objProductsInfo.ICProductItemQty = GetDecimalFromString((range.Cells[row, 8] as Range).Value2);

                        objProductsInfo.FK_ICDepartmentID = objDepartmentsInfo.ICDepartmentID;
                        if (!string.IsNullOrEmpty((range.Cells[row, 9] as Range).Text.ToString().Trim()))
                        {
                            objProductAttributesInfo = productAttributes.FirstOrDefault(o => o.ICProductAttributeValue.ToUpper() == (range.Cells[row, 9] as Range).Text.ToString().Trim().ToUpper());
                            if (objProductAttributesInfo == null)
                            {
                                objProductAttributesInfo = new ICProductAttributesInfo();
                                objProductAttributesInfo.ICProductAttributeGroup = ProductAttributeGroup.WoodType.ToString();
                                objProductAttributesInfo.ICProductAttributeNo = (range.Cells[row, 9] as Range).Text.ToString().Trim();
                                objProductAttributesInfo.ICProductAttributeValue = (range.Cells[row, 9] as Range).Text.ToString().Trim();
                                objProductAttributesController.CreateObject(objProductAttributesInfo);
                            }
                            objProductsInfo.FK_ICProductAttributeWoodTypeID = objProductAttributesInfo != null ? objProductAttributesInfo.ICProductAttributeID : 0;
                        }
                        if (!string.IsNullOrEmpty((range.Cells[row, 10] as Range).Text.ToString().Trim()))
                        {
                            objProductAttributesInfo = productAttributes.FirstOrDefault(o => o.ICProductAttributeValue.ToUpper() == (range.Cells[row, 10] as Range).Text.ToString().Trim().ToUpper());
                            if (objProductAttributesInfo == null)
                            {
                                objProductAttributesInfo = new ICProductAttributesInfo();
                                objProductAttributesInfo.ICProductAttributeGroup = ProductAttributeGroup.Speciality.ToString();
                                objProductAttributesInfo.ICProductAttributeNo = (range.Cells[row, 10] as Range).Text.ToString().Trim();
                                objProductAttributesInfo.ICProductAttributeValue = (range.Cells[row, 10] as Range).Text.ToString().Trim();
                                objProductAttributesController.CreateObject(objProductAttributesInfo);
                            }
                            //objProductsInfo.FK_ICProductAttributeSpecialityID = objProductAttributesInfo != null ? objProductAttributesInfo.ICProductAttributeID : 0;
                            //objProductsInfo.FK_ICProductAttributeSemiProductSpecialityID = objProductsInfo.FK_ICProductAttributeSpecialityID;
                        }
                        if (!string.IsNullOrEmpty((range.Cells[row, 11] as Range).Text.ToString().Trim()))
                        {
                            objProductAttributesInfo = productAttributes.FirstOrDefault(o => o.ICProductAttributeValue.ToUpper() == (range.Cells[row, 11] as Range).Text.ToString().Trim().ToUpper());
                            if (objProductAttributesInfo == null)
                            {
                                objProductAttributesInfo = new ICProductAttributesInfo();
                                objProductAttributesInfo.ICProductAttributeGroup = ProductAttributeGroup.Quality.ToString();
                                objProductAttributesInfo.ICProductAttributeNo = (range.Cells[row, 11] as Range).Text.ToString().Trim();
                                objProductAttributesInfo.ICProductAttributeValue = (range.Cells[row, 11] as Range).Text.ToString().Trim();
                                objProductAttributesController.CreateObject(objProductAttributesInfo);
                            }
                            //objProductsInfo.FK_ICProductAttributeQualityID = objProductAttributesInfo != null ? objProductAttributesInfo.ICProductAttributeID : 0;
                        }
                        //objProductsInfo.MMProductionNormProductJoinery = (range.Cells[row, 12] as Range).Text.ToString().Trim();
                        //objProductsInfo.ICProductJoinery = objProductsInfo.MMProductionNormProductJoinery;
                        if (!string.IsNullOrEmpty((range.Cells[row, 13] as Range).Text.ToString().Trim()))
                        {
                            //if (GetIntFromString((range.Cells[row, 13] as Range).Value2) == 1)
                            //    objProductsInfo.MMProductionNormItemIsReuse = true;
                        }
                        if (!string.IsNullOrEmpty((range.Cells[row, 14] as Range).Text.ToString().Trim()))
                        {
                            objMMFormulasInfo = listFormulas.FirstOrDefault(o => o.MMFormulaNo.ToUpper() == (range.Cells[row, 14] as Range).Text.ToString().Trim().ToUpper());
                            if (objMMFormulasInfo == null)
                            {
                                objMMFormulasInfo = new MMFormulasInfo();
                                objMMFormulasInfo.MMFormulaNo = (range.Cells[row, 14] as Range).Text.ToString().Trim();
                                objMMFormulasInfo.MMFormulaName = (range.Cells[row, 14] as Range).Text.ToString().Trim();
                                objMMFormulasInfo.MMFormulaDesc = (range.Cells[row, 14] as Range).Text.ToString().Trim();
                                objMMFormulasController.CreateObject(objMMFormulasInfo);
                            }
                            //objProductsInfo.FK_MMFormulaIDPaintA = objMMFormulasInfo != null ? objMMFormulasInfo.MMFormulaID : 0;
                        }
                        //objProductsInfo.MMProductionNormItemComment = (range.Cells[row, 15] as Range).Text.ToString().Trim();

                        objProductsInfo.ICProductType = ProductType.SemiProduct.ToString();
                        if (String.Compare(objProductsInfo.ICProductTypeDetails.ToUpper(), "CỤM", true) == 0)
                        {
                            objProductsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormCum;
                            objProductsInfo.HasComponent = true;
                            productGroups.Add(objProductsInfo);
                        }
                        else
                        {
                            objProductsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormChitiet;
                            objProductsInfo.HasComponent = false;
                            if (String.Compare(objProductsInfo.ICProductTypeDetails.ToUpper(), "CHI TIẾT", true) == 0)
                                productDetails.Add(objProductsInfo);
                            else
                                productPieces.Add(objProductsInfo);
                        }
                    }
                }
                ICProductItemsInfo objProductItemsInfo;
                productGroups.ForEach(o =>
                {
                    o.HasComponent = true;
                    o.ICProductNo = objProductsController.GetNextNoForGroupOrPieceSemiProduct(objMainProductsInfo.ICProductNo, objMainProductsInfo.ICProductNo.Length + 3);
                    o.ICProductDesc = o.ICProductName;
                    objProductsController.CreateObject(o);
                    objProductItemsInfo = new ICProductItemsInfo();
                    objProductItemsInfo.FK_ICProductItemParentID = objMainProductsInfo.ICProductID;
                    objProductItemsInfo.FK_ICProductItemChildID = o.ICProductID;
                    objProductItemsInfo.ICProductItemQty = o.ICProductItemQty;
                    objProductItemsController.CreateObject(objProductItemsInfo);
                    int sortOrderDetail = 0;
                    int count = 1;
                    productDetails.Where(x => x.ICProductParentCode == o.ICProductCode).All(x =>
                    {
                        x.HasComponent = false;
                        x.ICProductParentID = o.ICProductID;
                        string childProductNo = ProductionNormLocalizeResources.SemiProductGroupDefaultNo.Replace("{0}", o.ICProductNo);
                        childProductNo = childProductNo.Replace("{1}", count++.ToString().PadLeft(2, '0'));
                        x.ICProductNo = childProductNo;
                        x.ICProductDesc = x.ICProductName;
                        x.ICProductOrderID = sortOrderDetail;
                        objProductsController.CreateObject(x);
                        objProductItemsInfo = new ICProductItemsInfo();
                        objProductItemsInfo.FK_ICProductItemParentID = o.ICProductID;
                        objProductItemsInfo.FK_ICProductItemChildID = x.ICProductID;
                        objProductItemsInfo.ICProductItemQty = x.ICProductItemQty;
                        objProductItemsInfo.ICProductItemSortOrder = x.ICProductOrderID;
                        objProductItemsController.CreateObject(objProductItemsInfo);
                        sortOrderDetail++;
                        productItems.Add(objProductItemsInfo);
                        return true;
                    });
                });
                productPieces.Where(o => String.IsNullOrEmpty(o.ICProductParentCode)).All(o =>
                {
                    o.HasComponent = false;
                    o.ICProductNo = objProductsController.GetNextNoForGroupOrPieceSemiProduct(objMainProductsInfo.ICProductNo, objMainProductsInfo.ICProductNo.Length + 3);
                    o.ICProductDesc = o.ICProductName;
                    objProductsController.CreateObject(o);
                    objProductItemsInfo = new ICProductItemsInfo();
                    objProductItemsInfo.FK_ICProductItemParentID = objMainProductsInfo.ICProductID;
                    objProductItemsInfo.FK_ICProductItemChildID = o.ICProductID;
                    objProductItemsInfo.ICProductItemQty = o.ICProductItemQty;
                    objProductItemsController.CreateObject(objProductItemsInfo);
                    return true;
                });
                List<ICProductsInfo> products = new List<ICProductsInfo>();
                products.AddRange(productGroups);
                products.AddRange(productPieces);

                products.ForEach(p =>
                {
                    objProductionNormItemsInfo = SetValueProductionNormItemFromProductForImport(p, string.Empty, p);
                    objProductionNormItemsInfo.MMProductionNormItemQuantity = p.ICProductItemQty;
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemList.Count;

                    if (objProductionNormItemsInfo.SubList == null)
                        objProductionNormItemsInfo.SubList = new BOSTreeList();
                    objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                    List<ICProductsInfo> items = productDetails.Where(o => o.ICProductParentID == p.ICProductID).ToList();
                    if (items.Count() > 0)
                    {
                        items.ForEach(pItem =>
                        {
                            subProductionNormItem = SetValueProductionNormItemFromProductForImport(pItem, string.Empty, pItem);
                            subProductionNormItem.MMProductionNormItemQuantity = pItem.ICProductItemQty;
                            subProductionNormItem.MMProductionNormItemSortOrder = entity.ProductionNormItemList.Count;
                            subProductionNormItem.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                            subProductionNormItem.MMProductionNormItemIsComponent = false;
                            objProductionNormItemsInfo.SubList.Add(subProductionNormItem);
                        });
                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = true;
                    }
                    else
                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
                    entity.ProductionNormItemList.Add(objProductionNormItemsInfo);
                });

                CalculateProductionNormItemWoodType();
                CalculateBlockPerOne();
                entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemList.TreeListControl.ForceInitialize();
                entity.ProductionNormItemList.TreeListControl.DragNodesMode = TreeListDragNodesMode.Advanced;
                entity.ProductionNormItemList.TreeListControl.OptionsBehavior.CanCloneNodesOnDrop = false;
                entity.ProductionNormItemList.TreeListControl.OptionsBehavior.AutoChangeParent = false;
                entity.ProductionNormItemList.TreeListControl.ClearSorting();
                entity.ProductionNormItemList.TreeListControl.Columns["MMProductionNormItemSortOrder"].SortOrder = SortOrder.Ascending;
                entity.ProductionNormItemList.TreeListControl.ExpandAll();
                entity.ProductionNormItemList.TreeListControl.BestFitColumns();
                RefreshTreeView(entity.ProductionNormItemList);
                ProductionNormItemOriginalList.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lổi xãy ra:" + ex.Message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                BOSProgressBar.Close();
                return;
            }

        }
        public void ImportProductionNormHardwares(Range range)
        {
            if (range == null)
                return;

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objMainProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(mainObject.FK_ICProductID);
            if (objMainProductsInfo == null)
                return;

         

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            InvalidateProductionNormItemByProductType(ProductType.Hardware);
            ICProductsInfo objProductsInfo;
            for (int row = 1; row <= range.Rows.Count; row++)
            {
                string pNo = (range.Cells[row, 1] as Range).Text.ToString().Trim();
                if (!string.IsNullOrEmpty(pNo))
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByNo(pNo);
                    if (objProductsInfo == null)
                        continue;
                    MMProductionNormItemsInfo objProductionNormItemsInfo = AddItemToHardwareItemsList(objProductsInfo);

                    objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
                    objProductionNormItemsInfo.MMProductionNormItemQuantity = GetDecimalFromString((range.Cells[row, 3] as Range).Value2);
                    objProductionNormItemsInfo.MMProductionNormItemComment = (range.Cells[row, 4] as Range).Text.ToString().Trim();
                   // if (!string.IsNullOrEmpty((range.Cells[row, 6] as Range).Text.ToString().Trim()))
                    {
                        ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByName((range.Cells[row, 2] as Range).Text.ToString().Trim());
                        if (objMeasureUnitsInfo == null)
                        {
                            objMeasureUnitsInfo = new ICMeasureUnitsInfo();
                            objMeasureUnitsInfo.ICMeasureUnitName = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                            objMeasureUnitsController.CreateObject(objMeasureUnitsInfo);
                        }
                        objProductionNormItemsInfo.FK_ICMeasureUnitID = objMeasureUnitsInfo != null ? objMeasureUnitsInfo.ICMeasureUnitID : 0;
                      //  objProductionNormItemsInfo.MMProductionNormItemQuantity = Convert.ToDecimal((range.Cells[row, 6] as Range).Text.ToString().Trim());
                    }
                }
            }
            ProductionNormItemHardwareOriginalList.Clear();
        }


        public void ExportProductionNorm()
        {
            try
            {
                //BOSProgressBar.Start(CommonLocalizedResources.ProgressBarExportExcelMessage);
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string filePath = System.Windows.Forms.Application.StartupPath + @"\Template\BOM.xlsx";//BOSApp.DownloadFileFTP("hoa_don_ban_hang180424.xls", "KAROT_TEMPLATE").Replace("\\\\", "\\");
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);
                // bind dữ liệu
                //ExportExcelInvoice(guiSearchInvoice.SelectedInvoiceItemList, worksheet, 1, "A", "AE");

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = @"Tệp Excel (*.xls)|*.xls|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = @"BOM.xls";
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fullFileName = saveDialog.FileName;

                    WorkBook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    WorkBook.Saved = true;
                    //BOSProgressBar.Close();
                    //MessageBox.Show(CommonLocalizedResources.Exportexcelfilesuccessfully
                    //                        , MESLocalizedResources.MessageBoxDefaultCaption
                    //                        , MessageBoxButtons.OK
                    //                        , MessageBoxIcon.Information);
                }
                ReleaseDataImport();
                BOSProgressBar.Close();
            }
            catch (Exception ex)
            {
                ReleaseDataImport();
                BOSProgressBar.Close();
                MessageBox.Show(ex.ToString()
                                            , MESLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
            }
        }

        public void ReleaseDataImport()
        {
            WorkBook.Close(false, null, null);
            App.Quit();
            ReleaseObject(WorkSheet);
            ReleaseObject(WorkBook);
            ReleaseObject(App);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion
    }
}

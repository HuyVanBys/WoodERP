using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.ProductApplyPrice
{
    public class ProductApplyPriceEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ICProductApplyPriceItemsInfo> ProductApplyPriceItemList { get; set; }
        #endregion

        #region Constructor
        public ProductApplyPriceEntities()
            : base()
        {
            ProductApplyPriceItemList = new BOSList<ICProductApplyPriceItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductApplyPricesInfo();
            SearchObject = new ICProductApplyPricesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICProductApplyPriceItemsTableName, new ICProductApplyPriceItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductApplyPriceItemList.InitBOSList(this,
                                            TableName.ICProductApplyPricesTableName,
                                            TableName.ICProductApplyPriceItemsTableName,
                                            BOSList<ICProductApplyPriceItemsInfo>.cstRelationForeign);
            ProductApplyPriceItemList.ItemTableForeignKey = "FK_ICProductApplyPriceID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductApplyPriceItemList.InitBOSListGridControl(ProductApplyPriceModule.ICProductApplyPriceItemsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductApplyPriceItemList.SetDefaultListAndRefreshGridControl();
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
            ICProductApplyPricesInfo mainObject = (ICProductApplyPricesInfo)MainObject;
            mainObject.ICProductApplyPriceDate = BOSApp.GetCurrentServerDate();
            mainObject.ICProductApplyPriceEndDate = BOSApp.GetCurrentServerDate();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.ICProductApplyPriceType = ProductApplyPriceType.SalePrice.ToString();
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ProductApplyPriceItemList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ProductApplyPriceItemList.SaveItemCDObjects();
        }

        public override bool CompleteTransaction()
        {

            return base.CompleteTransaction();
        }

        public void GenerateProductApplyPriceItems(List<ICProductsInfo> products)
        {
            products.ForEach(o =>
            {
                ProductApplyPriceItemList.Add(ToProductApplyPriceItemsInfo(o));
            });
        }

        public ICProductApplyPriceItemsInfo ToProductApplyPriceItemsInfo(ICProductsInfo objICProductsInfo)
        {
            return new ICProductApplyPriceItemsInfo()
            {
                FK_ICProductID = objICProductsInfo.ICProductID,
                ICProductApplyPriceItemProductNo = objICProductsInfo.ICProductNo,
                ICProductApplyPriceItemProductName = objICProductsInfo.ICProductName,
                ICProductApplyPriceItemProductDesc = objICProductsInfo.ICProductDesc,
                ICProductApplyPriceItemProductLength = objICProductsInfo.ICProductLength,
                ICProductApplyPriceItemProductWidth = objICProductsInfo.ICProductWidth,
                ICProductApplyPriceItemProductHeight = objICProductsInfo.ICProductHeight,
                ICProductApplyPriceItemQty = 1,
                ICProductApplyPriceItemInternalPrice = objICProductsInfo.ICProductPrice01,
                ICProductApplyPriceItemPrice = objICProductsInfo.ICProductPrice01,
                ICProductApplyPriceItemDiscountAmount = 0,
                ICProductApplyPriceItemDiscountPercent = 0,
                ICProductApplyPriceItemTaxAmount = 0,
                ICProductApplyPriceItemTaxPercent = 0,
                FK_ICProductAttributeWoodTypeID = objICProductsInfo.FK_ICProductAttributeWoodTypeID,
                ICProductApplyPriceItemProductWoodTypeAttribute = objICProductsInfo.ICProductWoodTypeAttribute,
                FK_ICMeasureUnitID = objICProductsInfo.FK_ICProductBasicUnitID,
                FK_ICProductFormulaPriceConfigID = objICProductsInfo.FK_ICProductFormulaPriceConfigID,
                ICProductApplyPriceItemTotalAmount = objICProductsInfo.ICProductPrice01,
                FK_ICProductAttributeColorID = objICProductsInfo.FK_ICProductAttributeColorID,
                ICProductApplyPriceItemProductColorAttribute = objICProductsInfo.ICProductColorAttribute,
                ICProductApplyPriceItemBasicPrice = objICProductsInfo.ICProductPrice01
            };
        }

        public bool Approve()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                ICProductApplyPricesInfo mainObject = (ICProductApplyPricesInfo)MainObject;
                mainObject.ICProductApplyPriceStatus = ProductApplyPriceStatus.Approved.ToString();
                UpdateMainObject();

                SetPropertyChangeEventLock(true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Validate()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                ICProductApplyPricesInfo mainObject = (ICProductApplyPricesInfo)MainObject;
                mainObject.ICProductApplyPriceStatus = ProductApplyPriceStatus.Verified.ToString();
                UpdateMainObject();

                ICProductApplyPricesController controller = new ICProductApplyPricesController();
                controller.ApplyPriceToProducts(mainObject.ICProductApplyPriceID);
                SetPropertyChangeEventLock(true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void EditAfterComplete()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                ICProductApplyPricesInfo mainObject = (ICProductApplyPricesInfo)MainObject;
                mainObject.ICProductApplyPriceStatus = ProductApplyPriceStatus.New.ToString();
                SetPropertyChangeEventLock(true);
            }
            catch (Exception ex)
            {
            }
        }

        public override void DuplicateModuleObjectList()
        {
            base.DuplicateModuleObjectList();
            ProductApplyPriceItemList.Duplicate();
        }
    }
}

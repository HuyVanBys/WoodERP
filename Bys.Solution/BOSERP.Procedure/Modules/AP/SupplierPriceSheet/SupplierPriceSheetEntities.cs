using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.SupplierPriceSheet
{
    public class SupplierPriceSheetEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<APPriceSheetItemsInfo> PriceSheetItemList { get; set; }
        #endregion

        #region Constructor
        public SupplierPriceSheetEntities()
            : base()
        {
            PriceSheetItemList = new BOSList<APPriceSheetItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APPriceSheetsInfo();
            SearchObject = new APPriceSheetsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APPriceSheetItemsTableName, new APPriceSheetItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            PriceSheetItemList.InitBOSList(this,
                                            TableName.APPriceSheetsTableName,
                                            TableName.APPriceSheetItemsTableName,
                                            BOSList<APPriceSheetItemsInfo>.cstRelationForeign);
            PriceSheetItemList.ItemTableForeignKey = "FK_APPriceSheetID";
        }

        public override void InitGridControlInBOSList()
        {
            PriceSheetItemList.InitBOSListGridControl(SupplierPriceSheetModule.APPriceSheetItemsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PriceSheetItemList.SetDefaultListAndRefreshGridControl();
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
            ARPriceLevelsController objPriceLevelsController = new ARPriceLevelsController();
            APPriceSheetsInfo mainObject = (APPriceSheetsInfo)MainObject;
            mainObject.APPriceSheetDate = BOSApp.GetCurrentServerDate();
            mainObject.APPriceSheetBeginDate = BOSApp.GetCurrentServerDate();
            mainObject.APPriceSheetEndDate = BOSApp.GetCurrentServerDate().AddMonths(1);
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            APPriceSheetItemsController objPriceSheetItemsController = new APPriceSheetItemsController();
            List<APPriceSheetItemsInfo> listPriceSheetItems = objPriceSheetItemsController.GetPriceSheetItemByPriceSheetID(iObjectID);
            PriceSheetItemList.Invalidate(listPriceSheetItems);
        }

        public override void SaveModuleObjects()
        {
            PriceSheetItemList.SaveItemCDObjects();
        }

        public override bool CompleteTransaction()
        {

            return base.CompleteTransaction();
        }

        public void GenerateSupplierPriceSheetItems(List<ICProductsInfo> products)
        {
            products.ForEach(o =>
            {
                PriceSheetItemList.Add(ToSupplierPriceSheetItemsInfo(o));
            });
        }

        public APPriceSheetItemsInfo ToSupplierPriceSheetItemsInfo(ICProductsInfo objICProductsInfo)
        {
            APPriceSheetsInfo objPriceSheetsInfo = (APPriceSheetsInfo)MainObject;
            GECurrenciesInfo currenciesInfo = (GECurrenciesInfo)(new GECurrenciesController()).GetObjectByID(objPriceSheetsInfo.FK_GECurrencyID);
            int objectID = objPriceSheetsInfo.FK_ACObjectID != 0 ? objPriceSheetsInfo.FK_ACObjectID : objICProductsInfo.FK_APSupplierID;
            string objectType = objPriceSheetsInfo.APObjectType != string.Empty ? objPriceSheetsInfo.APObjectType : ObjectType.Supplier.ToString();
            ACObjectsInfo objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == objectID && o.ACObjectType == objectType);
            ICProductAttributesInfo prodAttPackingMaterialSpeciality = (ICProductAttributesInfo)(new ICProductAttributesController()).GetObjectByID(objICProductsInfo.FK_ICProdAttPackingMaterialSpecialityID);
            return new APPriceSheetItemsInfo()
            {
                FK_ICProductID = objICProductsInfo.ICProductID,
                FK_ICMeasureUnitID = objICProductsInfo.FK_ICProductSaleUnitID,
                FK_ACObjectID = objectID,
                APObjectType = objectType,
                ACObjectAccessKey = objPriceSheetsInfo.ACObjectAccessKey != string.Empty ? objPriceSheetsInfo.ACObjectAccessKey : string.Format("{0};{1}", objICProductsInfo.FK_APSupplierID, ObjectType.Supplier.ToString()),
                APPriceSheetItemProductName = objICProductsInfo.ICProductName,
                APPriceSheetItemProductDesc = objICProductsInfo.ICProductDesc,
                APPriceSheetItemQty = 1,
                APPriceSheetItemBasicPrice = objICProductsInfo.ICProductSupplierPrice,
                APPriceSheetItemPrice = objICProductsInfo.ICProductSupplierPrice,
                APPriceSheetItemProductNo = objICProductsInfo.ICProductNo,
                APPriceSheetItemProductNoOfOldSys = objICProductsInfo.ICProductNoOfOldSys,
                APPriceSheetItemProductSupplierNumber = objICProductsInfo.ICProductSupplierNumber,
                ICMeasureUnitName = objICProductsInfo.ICMeasureUnitName,
                GECurrencyName = currenciesInfo != null ? currenciesInfo.GECurrencyName : string.Empty,
                ACObjectName = objectsInfo != null ? objectsInfo.ACObjectName : string.Empty,
                ACObjectNo = objectsInfo != null ? objectsInfo.ACObjectNo : string.Empty,
                FK_GECurrencyID = objPriceSheetsInfo.FK_GECurrencyID,
                ICProductBoxArea = objICProductsInfo.ICProductBoxArea,
                ICProdAttPackingMaterialSpecialityName = prodAttPackingMaterialSpeciality != null ? prodAttPackingMaterialSpeciality.ICProductAttributeValue : string.Empty
            };
        }

        public bool Approve()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                APPriceSheetsInfo mainObject = (APPriceSheetsInfo)MainObject;
                mainObject.APPriceSheetStatus = PriceSheetStatus.Approved.ToString();
                mainObject.FK_HRApprovedEmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                UpdateMainObject();

                SetPropertyChangeEventLock(true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override void DuplicateModuleObjectList()
        {
            base.DuplicateModuleObjectList();
            PriceSheetItemList.Duplicate();
        }
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);

            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                PriceSheetItemList.DeleteItemObjects();
            }
        }
    }
}

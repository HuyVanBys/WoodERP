using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.PriceSheet
{
    public class PriceSheetEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ARPriceSheetItemsInfo> PriceSheetItemList { get; set; }
        #endregion

        #region Constructor
        public PriceSheetEntities()
            : base()
        {
            PriceSheetItemList = new BOSList<ARPriceSheetItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARPriceSheetsInfo();
            SearchObject = new ARPriceSheetsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARPriceSheetItemsTableName, new ARPriceSheetItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            PriceSheetItemList.InitBOSList(this,
                                            TableName.ARPriceSheetsTableName,
                                            TableName.ARPriceSheetItemsTableName,
                                            BOSList<ARPriceSheetItemsInfo>.cstRelationForeign);
            PriceSheetItemList.ItemTableForeignKey = "FK_ARPriceSheetID";
        }

        public override void InitGridControlInBOSList()
        {
            PriceSheetItemList.InitBOSListGridControl(PriceSheetModule.ARPriceSheetItemsGridControlName);
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
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)MainObject;
            mainObject.ARPriceSheetDate = BOSApp.GetCurrentServerDate();          
            mainObject.ARPriceSheetStartDate = BOSApp.GetCurrentServerDate();
            mainObject.ARPriceSheetEndDate = BOSApp.GetCurrentServerDate().AddMonths(1);
            mainObject.ARPriceSheetStatus = PriceSheetStatus.New.ToString();
            mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.None.ToString();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GECurrencyID;
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARPriceSheetItemsController objPriceSheetItemsController = new ARPriceSheetItemsController();
            List<ARPriceSheetItemsInfo> priceSheetItemList = objPriceSheetItemsController.GetAllObjectByPriceSheetID(iObjectID);
            PriceSheetItemList.Invalidate(priceSheetItemList.Where(o => o.FK_ICProductParentID == 0).ToList());
        }

        public override void SaveModuleObjects()
        {
            PriceSheetItemList.SaveItemCDObjects();
        }

        public override bool CompleteTransaction()
        {

            return base.CompleteTransaction();
        }
        public override bool CancelCompleteTransaction()
        {
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)MainObject;
            mainObject.ARPriceSheetStatus = InvoiceStatus.New.ToString();
            UpdateMainObject();
            return true;
        }
        public void GeneratePriceSheetItems(List<ICProductsInfo> products)
        {
            products.ForEach(o =>
            {
                PriceSheetItemList.Add(ToPriceSheetItemsInfo(o));
            });
        }

        public ARPriceSheetItemsInfo ToPriceSheetItemsInfo(ICProductsInfo objICProductsInfo)
        {
            ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)MainObject;
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ICProductCustomersInfo objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomersController.GetProductCustomerByProductIDAndCustomerID(objICProductsInfo.ICProductID, mainObject.FK_ARCustomerID);
            return new ARPriceSheetItemsInfo()
            {
                FK_ICProductID = objICProductsInfo.ICProductID,
                ARPriceSheetItemProductNo = objICProductsInfo.ICProductNo,
                ARPriceSheetItemProductName = objICProductsInfo.ICProductName,
                ARPriceSheetItemProductDesc = objICProductsInfo.ICProductDesc,
                ARPriceSheetItemProductLength = objICProductsInfo.ICProductLength,
                ARPriceSheetItemProductWidth = objICProductsInfo.ICProductWidth,
                ARPriceSheetItemProductHeight = objICProductsInfo.ICProductHeight,
                ARPriceSheetItemProductCustomerNumber = objProductCustomersInfo != null? objProductCustomersInfo.ICProductCustomerNumber : string.Empty,
                ARPriceSheetItemProductSupplierNumber = objICProductsInfo.ICProductSupplierNumber,
                ARPriceSheetItemProductNoOfOldSys = objICProductsInfo.ICProductNoOfOldSys,
                ARPriceSheetItemQty = 1,
                ARPriceSheetItemPrice = objICProductsInfo.ICProductPrice01,
                ARPriceSheetItemDiscountAmount = 0,
                ARPriceSheetItemDiscountPercent = 0,
                ARPriceSheetItemTaxAmount = objICProductsInfo.ICProductPrice01 * objICProductsInfo.ICProductTaxPercent / 100,
                ARPriceSheetItemTaxPercent = objICProductsInfo.ICProductTaxPercent,
                FK_ICMeasureUnitID = objICProductsInfo.FK_ICProductBasicUnitID,
                ARPriceSheetItemTotalAmount = objICProductsInfo.ICProductPrice01 + (objICProductsInfo.ICProductPrice01 * objICProductsInfo.ICProductTaxPercent / 100),
                ARPriceSheetItemBasicPrice = objICProductsInfo.ICProductPrice01,
                ICMeasureUnitName = objICProductsInfo.ICMeasureUnitName
            };
        }

        public bool Approve()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)MainObject;
                mainObject.ARPriceSheetStatus = PriceSheetStatus.Approved.ToString();
                DateTime toDay = BOSApp.GetCurrentServerDate();
                if (mainObject.ARPriceSheetStartDate > toDay)
                {
                    mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.NotActive.ToString();
                }
                else if (mainObject.ARPriceSheetEndDate < toDay)
                {
                    mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.OutOfActive.ToString();
                }
                else
                {
                    mainObject.ARPriceSheetApprovedStatus = PriceSheetApprovedStatus.IsActive.ToString();
                }
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
                ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)MainObject;
                mainObject.ARPriceSheetStatus = PriceSheetStatus.Verified.ToString();
                UpdateMainObject();

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
                ARPriceSheetsInfo mainObject = (ARPriceSheetsInfo)MainObject;
                mainObject.ARPriceSheetStatus = PriceSheetStatus.New.ToString();
                SetPropertyChangeEventLock(true);
            }
            catch (Exception ex)
            {
            }
        }

        public override void DuplicateModuleObjectList()
        {
            base.DuplicateModuleObjectList();
            PriceSheetItemList.Duplicate();
            PriceSheetItemList.ForEach(o => o.FK_ARPriceSheetID = 0);
        }

        public void GenerateEntityFromProposal(ARProposalsInfo objProposalsInfo)
        {
            ARProposalItemsController objProposalItemsController = new ARProposalItemsController();
            List<ARProposalItemsInfo> proposalItemList = objProposalItemsController.GetProposalItemsByProposalID(objProposalsInfo.ARProposalID);
            if (proposalItemList != null && proposalItemList.Count > 0)
            {
                foreach (ARProposalItemsInfo objProposalItemsInfo in proposalItemList)
                {
                    ARPriceSheetItemsInfo objPriceSheetItemsInfo = GeneratePriceSheetItemFromProposalItem(objProposalItemsInfo);
                    PriceSheetItemList.Add(objPriceSheetItemsInfo);
                }
            }
        }

        public ARPriceSheetItemsInfo GeneratePriceSheetItemFromProposalItem(ARProposalItemsInfo objProposalItemsInfo)
        {
            ARPriceSheetsInfo objPriceSheetsInfo = (ARPriceSheetsInfo)MainObject;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ARPriceSheetItemsInfo objPriceSheetItemsInfo = new ARPriceSheetItemsInfo();
            BOSUtil.CopyObject(objProposalItemsInfo, objPriceSheetItemsInfo);

            objProposalItemsInfo.ARProposalItemProductQtyRemained = objProposalItemsInfo.ARProposalItemProductQty - objProposalItemsInfo.ARProposalItemProductQtyOld;
            objPriceSheetItemsInfo.ARPriceSheetItemQty = 1;
            objPriceSheetItemsInfo.ARPriceSheetItemPrice = objProposalItemsInfo.ARProposalItemProductUnitPrice;
            objPriceSheetItemsInfo.ARPriceSheetItemDiscountAmount = objProposalItemsInfo.ARProposalItemDiscountAmount;
            objPriceSheetItemsInfo.ARPriceSheetItemProductDesc = objProposalItemsInfo.ARProposalItemProductDesc;

            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(objProposalItemsInfo.FK_ICProductID);
            if (objProductsInfo != null)
            {
                objPriceSheetItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                objPriceSheetItemsInfo.ARPriceSheetItemProductNo = objProductsInfo.ICProductNo;
            }
            return objPriceSheetItemsInfo;
        }
    }
}

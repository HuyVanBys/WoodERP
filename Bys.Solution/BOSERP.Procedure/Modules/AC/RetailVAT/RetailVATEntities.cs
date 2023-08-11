using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.RetailVAT
{
    public class RetailVATEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSItemsEntityList<ACRetailVATItemsInfo> RetailVATItemsList { get; set; }
        #endregion

        #region Constructor
        public RetailVATEntities() : base()
        {
            RetailVATItemsList = new BOSItemsEntityList<ACRetailVATItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACRetailVATsInfo();
            SearchObject = new ACRetailVATsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACRetailVATItemsTableName, new ACRetailVATItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            RetailVATItemsList.InitBOSList(this,
                                           TableName.ACRetailVATsTableName,
                                           TableName.ACRetailVATItemsTableName,
                                           BOSItemsEntityList<ACRetailVATItemsInfo>.cstRelationForeign);
            RetailVATItemsList.ItemTableForeignKey = "FK_ACRetailVATID";
        }

        public override void InitGridControlInBOSList()
        {
            RetailVATItemsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                RetailVATItemsList.SetDefaultListAndRefreshGridControl();
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
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)MainObject;
            mainObject.ACRetailVATDate = BOSApp.GetCurrentServerDate();
            mainObject.ACRetailVATStatus = RetailVATStatus.New.ToString();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            mainObject.ACRetailVATExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            //mainObject.ACRetailVATDesc = InvoiceLocalizedResources.InvoiceDefaultDesc;

            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetInvoiceTypeNo();
            if (objEInvoiceTypesInfo != null)
            {
                mainObject.FK_ACEInvoiceTypeID = objEInvoiceTypesInfo.ACEInvoiceTypeID;
                mainObject.ACRetailVATVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                mainObject.ACRetailVATVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }
            ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
            List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
            if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
            {
                mainObject.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
            }
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            RetailVATItemsList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            RetailVATItemsList.SaveItemObjects();
        }
        #endregion

        public override bool CompleteTransaction()
        {
            if(base.CompleteTransaction())
            {
                ACRetailVATsInfo mainObject = (ACRetailVATsInfo)MainObject;
                mainObject.ACRetailVATStatus = RetailVATStatus.Completed.ToString();
                UpdateMainObject();
                return true;
            }
            return false;
        }

        public override bool CancelCompleteTransaction()
        {
            if (base.CancelCompleteTransaction())
            {
                ACRetailVATsInfo mainObject = (ACRetailVATsInfo)MainObject;
                mainObject.ACRetailVATStatus = RetailVATStatus.New.ToString();
                UpdateMainObject();
                return true;
            }
            return false;
        }

        public void UpdateTotalAmount()
        {
            ACRetailVATsInfo mainObject = (ACRetailVATsInfo)MainObject;
            mainObject.ACRetailVATSubTotalAmount = 0;
            mainObject.ACRetailVATTotalAmount = 0;
            foreach (ACRetailVATItemsInfo entItem in RetailVATItemsList)
            {
                BOSApp.RoundByCurrency(entItem, mainObject.FK_GECurrencyID);
                mainObject.ACRetailVATSubTotalAmount += entItem.ACRetailVATItemTotalAmount;
            }
            BOSApp.RoundByCurrency(mainObject, mainObject.FK_GECurrencyID);
            mainObject.ACRetailVATDiscountAmount = mainObject.ACRetailVATSubTotalAmount * mainObject.ACRetailVATDiscountPerCent / 100;
            BOSApp.RoundByCurrency(mainObject, "ACRetailVATDiscountAmount", mainObject.FK_GECurrencyID);
            mainObject.ACRetailVATTaxAmount = (mainObject.ACRetailVATSubTotalAmount - mainObject.ACRetailVATDiscountAmount) * mainObject.ACRetailVATTaxPercent / 100;
            BOSApp.RoundByCurrency(mainObject, "ACRetailVATTaxAmount", mainObject.FK_GECurrencyID);
            mainObject.ACRetailVATTotalAmount = mainObject.ACRetailVATSubTotalAmount - mainObject.ACRetailVATDiscountAmount + mainObject.ACRetailVATTaxAmount;
            BOSApp.RoundByCurrency(mainObject, "ACRetailVATTotalAmount", mainObject.FK_GECurrencyID);
            BOSApp.RoundByCurrency(mainObject, mainObject.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public void GenarateRetailVATItem(List<ARInvoiceItemsInfo> listPOSItems)
        {
            listPOSItems.ForEach(o =>
            {
                RetailVATItemsList.Add(ToRetailVATItemInfo(o));
            });
        }

        private ACRetailVATItemsInfo ToRetailVATItemInfo(ARInvoiceItemsInfo posItemsInfo)
        {
            ACRetailVATItemsInfo objRetailVATItemsInfo = new ACRetailVATItemsInfo()
            {
                FK_ICProductID = posItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = posItemsInfo.FK_ICMeasureUnitID,
                FK_ARInvoiceItemID = posItemsInfo.ARInvoiceItemID,
                ACRetailVATItemProductNo = posItemsInfo.ARInvoiceItemProductNo,
                ACRetailVATItemProductName = posItemsInfo.ARInvoiceItemProductName,
                ACRetailVATItemProductName2 = posItemsInfo.ARInvoiceItemProductName2,
                ACRetailVATItemProductDesc = posItemsInfo.ARInvoiceItemProductDesc,
                ACRetailVATItemProductNoOfOldSys = posItemsInfo.ARInvoiceItemProductNoOfOldSys,
                ACRetailVATItemProductQty = posItemsInfo.ARInvoiceItemProductQty,
                ACRetailVATItemProductUnitPrice = posItemsInfo.ARInvoiceItemProductUnitPrice,
                ACRetailVATItemProductDiscountPercent = posItemsInfo.ARInvoiceItemProductDiscount,                
                ACRetailVATItemProductTaxPercent = posItemsInfo.ARInvoiceItemProductTaxPercent,
                ACRetailVATItemComment = posItemsInfo.ARInvoiceItemComment,
                ACRetailVATItemReferenceNo = posItemsInfo.ARInvoiceNo,
                ACRetailVATItemSortOrder = RetailVATItemsList.Count > 0 ? RetailVATItemsList.Max(p => p.ACRetailVATItemSortOrder) + 1 : 1
            };
            SetProductCostByProductUnitCost(objRetailVATItemsInfo);
            decimal netAmount = objRetailVATItemsInfo.ACRetailVATItemProductUnitPrice * objRetailVATItemsInfo.ACRetailVATItemProductQty;
            objRetailVATItemsInfo.ACRetailVATItemDiscountAmount = netAmount * objRetailVATItemsInfo.ACRetailVATItemProductDiscountPercent / 100;
            objRetailVATItemsInfo.ACRetailVATItemTaxAmount = (netAmount - objRetailVATItemsInfo.ACRetailVATItemDiscountAmount) * objRetailVATItemsInfo.ACRetailVATItemProductTaxPercent / 100;
            objRetailVATItemsInfo.ACRetailVATItemTotalAmount = netAmount - objRetailVATItemsInfo.ACRetailVATItemDiscountAmount + objRetailVATItemsInfo.ACRetailVATItemTaxAmount;            
            return objRetailVATItemsInfo;
        }
    }
}

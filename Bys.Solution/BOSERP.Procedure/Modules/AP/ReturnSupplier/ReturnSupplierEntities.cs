using BOSCommon.Constants;
using BOSLib;
using System;
using System.Linq;
using BOSCommon;

namespace BOSERP.Modules.ReturnSupplier
{
    public class ReturnSupplierEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Public Properties
        public BOSItemsEntityList<APReturnSupplierItemsInfo> ReturnSupplierItemsList { get; set; }
        public BOSList<ICReceiptItemsInfo> ReferenceReceiptItemsList { get; set; }
        public BOSList<ICProductsInfo> ProductsList { get; set; }
        public BOSList<APInvoiceInItemsInfo> ReferenceInvoiceInItemsList { get; set; }
        #endregion

        #region Constructor
        public ReturnSupplierEntities()
            : base()
        {
            ReturnSupplierItemsList = new BOSItemsEntityList<APReturnSupplierItemsInfo>();
            ReferenceReceiptItemsList = new BOSList<ICReceiptItemsInfo>();
            ProductsList = new BOSList<ICProductsInfo>();
            ReferenceInvoiceInItemsList = new BOSList<APInvoiceInItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions

        public override void InitMainObject()
        {
            MainObject = new APReturnSuppliersInfo();
            SearchObject = new APReturnSuppliersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APReturnSupplierItemsTableName, new APReturnSupplierItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ReturnSupplierItemsList = new BOSItemsEntityList<APReturnSupplierItemsInfo>();
            ReturnSupplierItemsList.InitBOSList(this, BOSUtil.GetTableNameFromBusinessObjectType(typeof(APReturnSuppliersInfo)), BOSUtil.GetTableNameFromBusinessObjectType(typeof(APReturnSupplierItemsInfo)));
            ReferenceReceiptItemsList.InitBOSList(this, String.Empty, TableName.ICReceiptItemsTableName);
            ProductsList = new BOSList<ICProductsInfo>();
            ProductsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICProductsInfo)));
        }

        public override void InitGridControlInBOSList()
        {
            ReturnSupplierItemsList.InitBOSListGridControl();
            ProductsList.InitBOSListGridControl("fld_dgcICProducts");
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReturnSupplierItemsList.SetDefaultListAndRefreshGridControl();
                ProductsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APReturnSuppliersInfo objReturnSuppliersInfo = (APReturnSuppliersInfo)MainObject;
            objReturnSuppliersInfo.APReturnSupplierTypeCombo = string.Empty;
            objReturnSuppliersInfo.APReturnSupplierDate = DateTime.Now;
            objReturnSuppliersInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objReturnSuppliersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReturnSuppliersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GECurrencyID;
            objReturnSuppliersInfo.APReturnSupplierExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objReturnSuppliersInfo.APReturnSupplierStatusCombo = ReturnSupplierStatus.New.ToString();

            //ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            //ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetInvoiceTypeNo();
            //if (objEInvoiceTypesInfo != null)
            //{
            //    objReturnSuppliersInfo.FK_ACEInvoiceTypeID = objEInvoiceTypesInfo.ACEInvoiceTypeID;
            //    objReturnSuppliersInfo.APReturnSupplierVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
            //    objReturnSuppliersInfo.APReturnSupplierVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            //}
        }
        #endregion

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReturnSupplierItemsList.Invalidate(iObjectID);
            APReturnSuppliersInfo mainObject = (APReturnSuppliersInfo)MainObject;
            mainObject.APInvoiceInSupplierNo = string.Empty;
            mainObject.APInvoiceInVATDate = DateTime.MinValue;
            if (ReturnSupplierItemsList.Where(o => o.FK_APInvoiceInID > 0).Count() > 0 && ReturnSupplierItemsList.FirstOrDefault(o => o.FK_APInvoiceInID > 0).FK_APInvoiceInID > 0)
            {
                int invoiceInID = ReturnSupplierItemsList.FirstOrDefault(o => o.FK_APInvoiceInID > 0).FK_APInvoiceInID;
                APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)(new APInvoiceInsController()).GetObjectByID(invoiceInID);
                if (objInvoiceInsInfo != null)
                {
                    mainObject.APInvoiceInSupplierNo = objInvoiceInsInfo.APInvoiceInSupplierNo;
                    mainObject.APInvoiceInVATDate = objInvoiceInsInfo.APInvoiceInVATDate;
                }
            }
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            ReturnSupplierItemsList.EndCurrentEdit();
            UpdateTotalCost();
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ReturnSupplierItemsList.SaveItemObjects();
            SaveAccountingData();
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                APReturnSupplierItemsInfo objReturnSupplierItemsInfo = (APReturnSupplierItemsInfo)ModuleObjects[TableName.APReturnSupplierItemsTableName];
                objReturnSupplierItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(objReturnSupplierItemsInfo.FK_ICProductID);
                SetProductCostByProductUnitCost();

                objReturnSupplierItemsInfo.FK_ICStockID = (MainObject as APReturnSuppliersInfo).FK_ICStockID;
                objReturnSupplierItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                objReturnSupplierItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                objReturnSupplierItemsInfo.APReturnSupplierItemProductAttribute = objProductsInfo.ICProductAttribute;
                objReturnSupplierItemsInfo.APReturnSupplierItemProductSerialNo = objProductsInfo.ICProductBarCode;
                UpdateModuleObjectBindingSource(TableName.APReturnSupplierItemsTableName);
            }
        }

        public void UpdateTotalCost()
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
            {
                APReturnSuppliersInfo objReturnSuppliersInfo = (APReturnSuppliersInfo)MainObject;
                objReturnSuppliersInfo.APReturnSupplierSubTotalCost = 0;
                foreach (APReturnSupplierItemsInfo entItem in ReturnSupplierItemsList)
                {
                    objReturnSuppliersInfo.APReturnSupplierSubTotalCost += entItem.APReturnSupplierItemTotalCost;
                }
                objReturnSuppliersInfo.APReturnSupplierDiscountFix = objReturnSuppliersInfo.APReturnSupplierSubTotalCost * objReturnSuppliersInfo.APReturnSupplierDiscountPerCent / 100;
                BOSApp.RoundByCurrency(objReturnSuppliersInfo, "APReturnSupplierDiscountFix", objReturnSuppliersInfo.FK_GECurrencyID);
                objReturnSuppliersInfo.APReturnSupplierTaxAmount = (objReturnSuppliersInfo.APReturnSupplierSubTotalCost - objReturnSuppliersInfo.APReturnSupplierDiscountFix) * objReturnSuppliersInfo.APReturnSupplierTaxPercent /100;
                BOSApp.RoundByCurrency(objReturnSuppliersInfo, "APReturnSupplierTaxAmount", objReturnSuppliersInfo.FK_GECurrencyID);
                objReturnSuppliersInfo.APReturnSupplierTotalCost = objReturnSuppliersInfo.APReturnSupplierSubTotalCost - objReturnSuppliersInfo.APReturnSupplierDiscountFix + objReturnSuppliersInfo.APReturnSupplierTaxAmount;
                BOSApp.RoundByCurrency(objReturnSuppliersInfo, "APReturnSupplierTotalCost", objReturnSuppliersInfo.FK_GECurrencyID);
                UpdateMainObjectBindingSource();
            }
        }

        public override bool IsInvalidInventory()
        {
            return ReturnSupplierItemsList.IsInvalidInventory(TransactionUtil.cstInventoryShipment);
        }

        public override bool CompleteTransaction()
        {
            APReturnSuppliersInfo objReturnSuppliersInfo = (APReturnSuppliersInfo)MainObject;

            //Update supplier owing
            APSuppliersController objSuppliersController = new APSuppliersController();
            APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(objReturnSuppliersInfo.FK_APSupplierID);
            if (objSuppliersInfo != null)
            {
                objSuppliersInfo.APSupplierOwing -= objReturnSuppliersInfo.APReturnSupplierTotalCost;
                objSuppliersController.UpdateObject(objSuppliersInfo);
            }

            //Update status of return
            objReturnSuppliersInfo.APReturnSupplierStatusCombo = ReturnSupplierStatus.Complete.ToString();
            UpdateMainObject();

            return true;
        }
        #endregion
    }
}

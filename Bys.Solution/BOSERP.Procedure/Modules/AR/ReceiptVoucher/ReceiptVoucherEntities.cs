using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.ReceiptVoucher
{
    public class ReceiptVoucherEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        /// <summary>
        /// Get or set the receipt voucher item list 
        /// </summary>
        public BOSList<ARReceiptVoucherItemsInfo> ReceiptVoucherItemList { get; set; }
        #endregion

        #region Constructor
        public ReceiptVoucherEntities()
            : base()
        {
            ReceiptVoucherItemList = new BOSList<ARReceiptVoucherItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARReceiptVouchersInfo();
            SearchObject = new ARReceiptVouchersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARReceiptVoucherItemsTableName, new ARReceiptVoucherItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ReceiptVoucherItemList.InitBOSList(
                                                    this,
                                                    TableName.ARReceiptVouchersTableName,
                                                    TableName.ARReceiptVoucherItemsTableName,
                                                    BOSList<ARReceiptVoucherItemsInfo>.cstRelationForeign);
            ReceiptVoucherItemList.ItemTableForeignKey = "FK_ARReceiptVoucherID";
        }

        public override void InitGridControlInBOSList()
        {
            ReceiptVoucherItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARReceiptVouchersInfo objReceiptVouchersInfo = (ARReceiptVouchersInfo)MainObject;
            objReceiptVouchersInfo.ARReceiptVoucherDate = DateTime.Now;
            objReceiptVouchersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptVouchersInfo.ARReceiptVoucherExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptVouchersInfo.ARReceiptVoucherType = ReceiptVoucherType.Receipt.ToString();
            objReceiptVouchersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            List<CSCashFundsInfo> lstCSCashFundsInfo = objCSCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (lstCSCashFundsInfo != null && lstCSCashFundsInfo.Any(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())))
            {
                objReceiptVouchersInfo.FK_CSCashFundID = lstCSCashFundsInfo.Where(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())).FirstOrDefault().CSCashFundID;
            }
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptVoucherItemList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReceiptVoucherItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ARReceiptVouchersInfo objReceiptVouchersInfo = (ARReceiptVouchersInfo)MainObject;
            PMProjectsController objProjectsController = new PMProjectsController();
            PMProjectsInfo objProjectsInfo = (PMProjectsInfo)objProjectsController.GetObjectByID(objReceiptVouchersInfo.FK_PMProjectID);
            if (objProjectsInfo != null)
                objReceiptVouchersInfo.PMProjectNo = objProjectsInfo.PMProjectNo;
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            ReceiptVoucherItemList.SaveItemObjects();
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            while (objCustomerPaymentsController.IsExist(mainObjectNo))
            {
                UpdateObjectNumbering(numberingStart);
                mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            }
            return mainObjectNo;
        }
        #endregion

        #region Accounting
        //public override bool SaveAccountingData()
        //{
        //    ARReceiptVouchersInfo objReceiptVouchersInfo = (ARReceiptVouchersInfo)MainObject;
        //    foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
        //    {
        //        BOSUtil.CopyObject(MainObject, objDocumentsInfo);
        //        objDocumentsInfo.ACVATDocumentType = objReceiptVouchersInfo.AROutputVATDocumentType;
        //        objDocumentsInfo.ACDocumentVATFormNo = objReceiptVouchersInfo.ARReceiptVoucherFormNo;
        //        objDocumentsInfo.ACDocumentVATSymbol = objReceiptVouchersInfo.ARReceiptVoucherSymbol;
        //        objDocumentsInfo.ACDocumentDate = objReceiptVouchersInfo.ARReceiptVoucherDate;
        //        objDocumentsInfo.ACDocumentVoucherNo = objReceiptVouchersInfo.ARReceiptVoucherVoucherNo;
        //        objDocumentsInfo.ACVATInvoiceNoCombo = objReceiptVouchersInfo.AROutputVATInvoiceNoCombo;
        //        objDocumentsInfo.ACDocumentObjectTaxNumber = objReceiptVouchersInfo.ARReceiptVoucherObjectTaxNumber;

        //    }
        //    return base.SaveAccountingData();
        //}
        #endregion

        public override bool CompleteTransaction()
        {
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)MainObject;
            if (mainObject.ARReceiptVoucherStatus == ReceiptVoucherStatus.New.ToString())
            {
                SetPropertyChangeEventLock(false);
                mainObject.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                mainObject.ARReceiptVoucherStatus = ReceiptVoucherStatus.Completed.ToString();
                UpdateMainObject();
                SetPropertyChangeEventLock(true);
            }
            SaveAccountingData();
            return base.CompleteTransaction();
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ReceiptVoucherItemList.DeleteItemObjects();
            }
        }
    }
}

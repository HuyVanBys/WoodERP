using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BOSERP.Modules.PaymentVoucher
{
    public class PaymentVoucherEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        /// <summary>
        /// Get or set the payment voucher item list 
        /// </summary>
        public BOSList<APPaymentVoucherItemsInfo> PaymentVoucherItemList { get; set; }
        public BOSList<HRAdvanceRequestPaymentTimesInfo> AdvanceRequestPaymentTimeList { get; set; }
        public BOSList<APPaymentVoucherItemDetailsInfo> PaymentVoucherItemDetailList { get; set; }
        #endregion

        #region Constructor
        public PaymentVoucherEntities()
            : base()
        {
            PaymentVoucherItemList = new BOSList<APPaymentVoucherItemsInfo>();
            AdvanceRequestPaymentTimeList = new BOSList<HRAdvanceRequestPaymentTimesInfo>();
            PaymentVoucherItemDetailList = new BOSList<APPaymentVoucherItemDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APPaymentVouchersInfo();
            SearchObject = new APPaymentVouchersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APPaymentVoucherItemsTableName, new APPaymentVoucherItemsInfo());
            ModuleObjects.Add(TableName.HRAdvanceRequestPaymentTimesTableName, new HRAdvanceRequestPaymentTimesInfo());
            ModuleObjects.Add(TableName.APPaymentVoucherItemDetailsTableName, new APPaymentVoucherItemDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            PaymentVoucherItemList.InitBOSList(
                                                    this,
                                                    TableName.APPaymentVouchersTableName,
                                                    TableName.APPaymentVoucherItemsTableName,
                                                    BOSList<APPaymentVouchersInfo>.cstRelationForeign);
            PaymentVoucherItemList.ItemTableForeignKey = "FK_APPaymentVoucherID";
            AdvanceRequestPaymentTimeList.InitBOSList(
                                                    this,
                                                    TableName.APPaymentVouchersTableName,
                                                    TableName.HRAdvanceRequestPaymentTimesTableName,
                                                    BOSList<HRAdvanceRequestPaymentTimesInfo>.cstRelationForeign);
            AdvanceRequestPaymentTimeList.ItemTableForeignKey = "FK_APPaymentVoucherID";
            PaymentVoucherItemDetailList.InitBOSList(
                                                   this,
                                                   TableName.APPaymentVouchersTableName,
                                                   TableName.APPaymentVoucherItemDetailsTableName,
                                                   BOSList<HRAdvanceRequestPaymentTimesInfo>.cstRelationForeign);
            PaymentVoucherItemDetailList.ItemTableForeignKey = "FK_APPaymentVoucherID";
            DocumentEntryList.InitBOSList(this,
                                                    TableName.ACDocumentsTableName,
                                                    TableName.ACDocumentEntrysTableName,
                                                    BOSList<ACDocumentEntrysInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            PaymentVoucherItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)MainObject;
            objPaymentVouchersInfo.APPaymentVoucherDate = DateTime.Now;
            objPaymentVouchersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objPaymentVouchersInfo.APPaymentVoucherExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objPaymentVouchersInfo.APPaymentVoucherType = PaymentVoucherType.Payment.ToString();
            objPaymentVouchersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objPaymentVouchersInfo.APPaymentVoucherStatus = PaymentVoucherStatus.New.ToString();
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            List<CSCashFundsInfo> lstCSCashFundsInfo = objCSCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (lstCSCashFundsInfo != null && lstCSCashFundsInfo.Any(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())))
            {
                objPaymentVouchersInfo.FK_CSCashFundID = lstCSCashFundsInfo.Where(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())).FirstOrDefault().CSCashFundID;
            }
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PaymentVoucherItemList.SetDefaultListAndRefreshGridControl();
                AdvanceRequestPaymentTimeList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            PaymentVoucherItemList.Invalidate(iObjectID);
            PaymentVoucherItemList.ForEach(p => p.ACObjectAccessKey = p.FK_ACObjectID + ";" + p.APObjectType);
            HRAdvanceRequestPaymentTimesController arptController = new HRAdvanceRequestPaymentTimesController();
            List<HRAdvanceRequestPaymentTimesInfo> arptList = arptController.GetPaymentTimeByPaymentVoucherID(iObjectID);
            AdvanceRequestPaymentTimeList.Invalidate(arptList);
            PaymentVoucherItemDetailList.Invalidate(iObjectID);

            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)MainObject;
            ACDocumentEntrysController docEntryController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> docEntryList = new List<ACDocumentEntrysInfo>();
            if (objPaymentVouchersInfo.APPaymentVoucherPostedStatus == PostedTransactionStatus.Posted.ToString())
            {
                docEntryList = docEntryController.GetAccountingEntries(this.Module.Name, 0, objPaymentVouchersInfo.APPaymentVoucherNo);
            }
            DocumentEntryList.Invalidate(docEntryList);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            PaymentVoucherItemList.SaveItemObjects();
            AdvanceRequestPaymentTimeList.SaveItemObjects();
            PaymentVoucherItemDetailList.SaveItemObjects();
        }

        public void UpdateUnifinishedCost(bool isPosted)
        {
            ACUnfinishedConstructionCostsController unfinishedCostController = new ACUnfinishedConstructionCostsController();
            ACUnfinishedConstructionCostsInfo unfinishedCost = new ACUnfinishedConstructionCostsInfo();

            foreach (APPaymentVoucherItemsInfo paymentVoucherItem in PaymentVoucherItemList)
            {
                unfinishedCost = unfinishedCostController.GetObjectByID(paymentVoucherItem.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                if (unfinishedCost != null)
                {
                    unfinishedCost.ACUnfinishedConstructionCostValue += isPosted ? paymentVoucherItem.APPaymentVoucherItemExchangeAmount : -paymentVoucherItem.APPaymentVoucherItemExchangeAmount;
                    unfinishedCostController.UpdateObject(unfinishedCost);
                }
            }
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
            while (objSupplierPaymentsController.IsExist(mainObjectNo))
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
        //    APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)MainObject;
        //    foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
        //    {
        //        BOSUtil.CopyObject(MainObject, objDocumentsInfo);
        //        objDocumentsInfo.ACVATDocumentType = objPaymentVouchersInfo.APInputVATDocumentType;
        //        objDocumentsInfo.ACDocumentVATFormNo = objPaymentVouchersInfo.APPaymentVoucherFormNo;
        //        objDocumentsInfo.ACVATInvoiceNoCombo = objPaymentVouchersInfo.APInputVATInvoiceNoCombo;
        //        objDocumentsInfo.ACDocumentVATSymbol = objPaymentVouchersInfo.APPaymentVoucherSymbol;
        //    }
        //    return base.SaveAccountingData();
        //}
        #endregion

        public override bool CompleteTransaction()
        {
            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)MainObject;
            objPaymentVouchersInfo.APPaymentVoucherStatus = PaymentVoucherStatus.Completed.ToString();
            objPaymentVouchersInfo.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            UpdateMainObject();
            SaveAccountingData();
            if (objPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString())
            {
                ACLoanAgreementsController objLoanAgreementsController = new ACLoanAgreementsController();
                ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
                ACLoanReceiptPaymentPlansController lrppControler = new ACLoanReceiptPaymentPlansController();
                ACLoanReceiptsInfo objLoanReceiptsInfo = new ACLoanReceiptsInfo();
                ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                int noID = objEntryTypesController.GetEntryTypeIDByName(AccEntryName.TraTienNoGop);
                int laiID = objEntryTypesController.GetEntryTypeIDByName(AccEntryName.TraTienLaiVay);
                int phatID = objEntryTypesController.GetEntryTypeIDByName(AccEntryName.TraTienLaiPhatQuaHan);
                decimal tienno = 0;
                decimal tienlai = 0;
                decimal tienphat = 0;
                decimal tongtien = 0;
                if (PaymentVoucherItemList != null && PaymentVoucherItemList.Count > 0)
                {
                    tienno = PaymentVoucherItemList.Where(a => a.FK_ACEntryTypeID == noID).Sum(a => a.APPaymentVoucherItemAmount);
                    tienlai = PaymentVoucherItemList.Where(a => a.FK_ACEntryTypeID == laiID).Sum(a => a.APPaymentVoucherItemAmount);
                    tienphat = PaymentVoucherItemList.Where(a => a.FK_ACEntryTypeID == phatID).Sum(a => a.APPaymentVoucherItemAmount);
                    tongtien = PaymentVoucherItemList.Sum(a => a.APPaymentVoucherItemAmount);
                }
                //Update LoanReceipt
                objLoanReceiptsInfo = (ACLoanReceiptsInfo)objLoanReceiptsController.GetObjectByID(objPaymentVouchersInfo.FK_ACLoanReceiptID);
                if (objLoanReceiptsInfo != null)
                {
                    objLoanReceiptsInfo.ACLoanReceiptPaidAmount += tienno;
                    objLoanReceiptsInfo.ACLoanReceiptRemainAmount -= tienno;
                    objLoanReceiptsController.UpdateObject(objLoanReceiptsInfo);
                    objLoanAgreementsController.UpdateLoanAgreementForLoanAgreementReceiptAmount(objLoanReceiptsInfo.FK_ACLoanAgreementID);
                }
                //update LoanReceiptPaymentPlans
                ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)lrppControler.GetObjectByID(objPaymentVouchersInfo.FK_ACLoanReceiptPaymentPlanID);
                if (objLoanReceiptPaymentPlansInfo != null)
                {
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualPaymentDate = objPaymentVouchersInfo.APPaymentVoucherDate;
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment += tienno;
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment += tienlai;
                    lrppControler.UpdateObject(objLoanReceiptPaymentPlansInfo);
                }

                if (objLoanReceiptsInfo != null && (objLoanReceiptsInfo.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OriginalPaypal.ToString() || objLoanReceiptsInfo.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OutstandingDebtIncreasing.ToString()))
                {
                    ACLoanReceiptPaymentPlansController objLoanReceiptPaymentPlansController = new ACLoanReceiptPaymentPlansController();
                    BOSList<ACLoanReceiptPaymentPlansInfo> LoanReceiptPaymentPlanList = new BOSList<ACLoanReceiptPaymentPlansInfo>(TableName.ACLoanReceiptPaymentPlansTableName);
                    List<ACLoanReceiptPaymentPlansInfo> LRPPlanList = objLoanReceiptPaymentPlansController.GetLoanReceiptPaymentPlansByLoanReceiptID(objPaymentVouchersInfo.FK_ACLoanReceiptID);
                    objLoanReceiptPaymentPlansInfo = new ACLoanReceiptPaymentPlansInfo();
                    LoanReceiptPaymentPlanList.Invalidate(LRPPlanList);
                    if (LoanReceiptPaymentPlanList != null && LoanReceiptPaymentPlanList.Count > 0)
                    {

                        for (int i = 0; i <= LoanReceiptPaymentPlanList.Count() - 1; i++)
                        {
                            objLoanReceiptPaymentPlansInfo = LoanReceiptPaymentPlanList[i];
                            objLoanReceiptPaymentPlansInfo = Module.UpdateValueLoanReceiptPaymentPlanByIndex(objLoanReceiptPaymentPlansInfo, i, objLoanReceiptsInfo, LoanReceiptPaymentPlanList, true);
                            objLoanReceiptPaymentPlansController.UpdateObject(objLoanReceiptPaymentPlansInfo);
                        }
                    }
                }
            }
            return base.CompleteTransaction();
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                PaymentVoucherItemList.DeleteItemObjects();
            }
        }
    }
}

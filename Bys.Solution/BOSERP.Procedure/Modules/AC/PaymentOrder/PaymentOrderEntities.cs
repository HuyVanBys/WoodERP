using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.PaymentOrder
{
    public class PaymentOrderEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets bank transaction item list
        /// </summary>
        public BOSList<ACBankTransactionItemsInfo> BankTransactionItemList { get; set; }
        public BOSList<HRAdvanceRequestPaymentTimesInfo> AdvanceRequestPaymentTimeList { get; set; }
        #endregion

        #region Constructor
        public PaymentOrderEntities()
            : base()
        {
            BankTransactionItemList = new BOSList<ACBankTransactionItemsInfo>();
            AdvanceRequestPaymentTimeList = new BOSList<HRAdvanceRequestPaymentTimesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACBankTransactionsInfo();
            SearchObject = new ACBankTransactionsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACBankTransactionItemsTableName, new ACBankTransactionItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            BankTransactionItemList.InitBOSList(
                                                    this,
                                                    TableName.ACBankTransactionsTableName,
                                                    TableName.ACBankTransactionItemsTableName,
                                                    BOSList<ACBankTransactionsInfo>.cstRelationForeign);
            BankTransactionItemList.ItemTableForeignKey = "FK_ACBankTransactionID";
            AdvanceRequestPaymentTimeList.InitBOSList(
                                          this,
                                          TableName.ACBankTransactionsTableName,
                                          TableName.HRAdvanceRequestPaymentTimesTableName,
                                          BOSList<HRAdvanceRequestPaymentTimesInfo>.cstRelationForeign);
            AdvanceRequestPaymentTimeList.ItemTableForeignKey = "FK_ACBankTransactionID";
        }

        public override void InitGridControlInBOSList()
        {
            BankTransactionItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;
            objBankTransactionsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objBankTransactionsInfo.ACBankTransactionExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objBankTransactionsInfo.ACBankTransactionDate = DateTime.Now;
            objBankTransactionsInfo.ACBankTransactionType = BankTransactionType.PaymentOrder.ToString();
            objBankTransactionsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BankTransactionItemList.SetDefaultListAndRefreshGridControl();
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

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            BankTransactionItemList.Invalidate(iObjectID);
            HRAdvanceRequestPaymentTimesController arptController = new HRAdvanceRequestPaymentTimesController();
            List<HRAdvanceRequestPaymentTimesInfo> arptList = arptController.GetPaymentTimeByBankTransactionID(iObjectID);
            AdvanceRequestPaymentTimeList.Invalidate(arptList);
            PaymentOrderModule module = (PaymentOrderModule)this.Module;
            module.AllowEditBankTransactionItemGridControl(true);
            foreach (ACBankTransactionItemsInfo item in BankTransactionItemList)
            {
                if (item.FK_HRAdvanceRequestItemID > 0)
                {
                    module.AllowEditBankTransactionItemGridControl(false);
                    break;
                }
                item.ACObjectAccessKey = item.FK_ACObjectID + ";" + item.ACObjectType;
            }

            //ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;
            //ACDocumentEntrysController docEntryController = new ACDocumentEntrysController();
            //List<ACDocumentEntrysInfo> docEntryList = new List<ACDocumentEntrysInfo>();
            //if (objBankTransactionsInfo.ACBankTransactionPostedStatus == PostedTransactionStatus.Posted.ToString())
            //{
            //    docEntryList = docEntryController.GetAccountingEntries(this.Module.Name, 0, objBankTransactionsInfo.ACBankTransactionNo);
            //}
            //DocumentEntryList.Invalidate(docEntryList);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;

            BankTransactionItemList.SaveItemObjects();
            AdvanceRequestPaymentTimeList.SaveItemObjects();
            SaveAccountingData();

            UpdateUnifinishedCost();
        }

        private void UpdateUnifinishedCost()
        {
            ACUnfinishedConstructionCostsController unfinishedCostController = new ACUnfinishedConstructionCostsController();

            foreach (ACBankTransactionItemsInfo paymentVoucherItem in BankTransactionItemList)
            {
                ACUnfinishedConstructionCostsInfo unfinishedCost = unfinishedCostController.GetObjectByID(paymentVoucherItem.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                if (unfinishedCost != null)
                {
                    unfinishedCost.ACUnfinishedConstructionCostValue += paymentVoucherItem.ACBankTransactionItemExchangeAmount;
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
        #endregion

        public override bool CompleteTransaction()
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;
            objBankTransactionsInfo.ACBankTransactionStatus = BankTransactionStatus.Completed.ToString();
            UpdateMainObject();

            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();

            if (objBankTransactionsInfo.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
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
                if (BankTransactionItemList != null && BankTransactionItemList.Count > 0)
                {
                    tienno = BankTransactionItemList.Where(a => a.FK_ACEntryTypeID == noID).Sum(a => a.ACBankTransactionItemAmount);
                    tienlai = BankTransactionItemList.Where(a => a.FK_ACEntryTypeID == laiID).Sum(a => a.ACBankTransactionItemAmount);
                    tienphat = BankTransactionItemList.Where(a => a.FK_ACEntryTypeID == phatID).Sum(a => a.ACBankTransactionItemAmount);
                    tongtien = BankTransactionItemList.Sum(a => a.ACBankTransactionItemAmount);
                }
                //Update LoanReceipt
                objLoanReceiptsInfo = (ACLoanReceiptsInfo)objLoanReceiptsController.GetObjectByID(objBankTransactionsInfo.FK_ACLoanReceiptID);
                if (objLoanReceiptsInfo != null)
                {
                    objLoanReceiptsInfo.ACLoanReceiptPaidAmount += tienno;
                    objLoanReceiptsInfo.ACLoanReceiptRemainAmount -= tienno;
                    objLoanReceiptsController.UpdateObject(objLoanReceiptsInfo);
                    objLoanAgreementsController.UpdateLoanAgreementForLoanAgreementReceiptAmount(objLoanReceiptsInfo.FK_ACLoanAgreementID);
                }
                //update LoanReceiptPaymentPlans
                ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)lrppControler.GetObjectByID(objBankTransactionsInfo.FK_ACLoanReceiptPaymentPlanID);
                if (objLoanReceiptPaymentPlansInfo != null)
                {
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualPaymentDate = objBankTransactionsInfo.ACBankTransactionDate;
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment += tienno;
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment += tienlai;
                    lrppControler.UpdateObject(objLoanReceiptPaymentPlansInfo);
                }

            }

            return base.CompleteTransaction();
        }

        public override bool CancelCompleteTransaction()
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;
            objBankTransactionsInfo.ACBankTransactionStatus = BankTransactionStatus.New.ToString();
            UpdateMainObject();
            return true;
        }

        public void ModuleAfterCancelCompleted()
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;

            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();

            if (objBankTransactionsInfo.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
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

                if (BankTransactionItemList != null && BankTransactionItemList.Count > 0)
                {
                    tienno = BankTransactionItemList.Where(a => a.FK_ACEntryTypeID == noID).Sum(a => a.ACBankTransactionItemAmount);
                    tienlai = BankTransactionItemList.Where(a => a.FK_ACEntryTypeID == laiID).Sum(a => a.ACBankTransactionItemAmount);
                }
                //Update LoanReceipt
                objLoanReceiptsInfo = (ACLoanReceiptsInfo)objLoanReceiptsController.GetObjectByID(objBankTransactionsInfo.FK_ACLoanReceiptID);
                if (objLoanReceiptsInfo != null)
                {
                    objLoanReceiptsInfo.ACLoanReceiptPaidAmount -= tienno;
                    objLoanReceiptsInfo.ACLoanReceiptRemainAmount += tienno;
                    objLoanReceiptsController.UpdateObject(objLoanReceiptsInfo);
                    objLoanAgreementsController.UpdateLoanAgreementForLoanAgreementReceiptAmount(objLoanReceiptsInfo.FK_ACLoanAgreementID);
                }
                //update LoanReceiptPaymentPlans
                ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)lrppControler.GetObjectByID(objBankTransactionsInfo.FK_ACLoanReceiptPaymentPlanID);
                if (objLoanReceiptPaymentPlansInfo != null)
                {
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment -= tienno;
                    objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment -= tienlai;
                    lrppControler.UpdateObject(objLoanReceiptPaymentPlansInfo);
                }

            }
        }
    }
}

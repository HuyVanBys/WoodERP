using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentCash
{
    public class PaymentCashModule : BaseTransactionModule
    {
        #region Constant
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        public const string ToolbarButtonApprove = "Approve";
        public const string CSCashFundFromLookupEditControlName = "fld_lkeFK_CSCashFundID";
        public const string CSCompanyBankFromLookupEditControlName = "fld_lkeFK_CSCompanyBankID";
        public const string CSCashFundToLookupEditControlName = "fld_lkeFK_ToCSCashFundID";
        public const string CSCompanyBankToLookupEditControlName = "fld_lkeFK_ToCSCompanyBankID";

        public BOSLookupEdit CSCashFundFromLookupEditControl;
        public BOSLookupEdit CSCompanyBankFromLookupEditControl;
        public BOSLookupEdit CSCashFundToLookupEditControl;
        public BOSLookupEdit CSCompanyBankToLookupEditControl;
        public int CreditAccountID;
        public int DebitAccountID;
        #endregion

        #region Constructor
        public PaymentCashModule()
        {
            Name = ModuleName.PaymentCash;
            CurrentModuleEntity = new PaymentCashEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            CSCashFundsController objCashFundsController = new CSCashFundsController();
            CSCashFundFromLookupEditControl = (BOSLookupEdit)Controls[PaymentCashModule.CSCashFundFromLookupEditControlName];
            CSCashFundToLookupEditControl = (BOSLookupEdit)Controls[PaymentCashModule.CSCashFundToLookupEditControlName];
            CSCashFundFromLookupEditControl.Properties.DataSource = objCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            CSCashFundToLookupEditControl.Properties.DataSource = objCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBankFromLookupEditControl = (BOSLookupEdit)Controls[PaymentCashModule.CSCompanyBankFromLookupEditControlName];
            CSCompanyBankFromLookupEditControl.Properties.DataSource = objCompanyBanksController.GetListCompanyBanksByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            CSCompanyBankToLookupEditControl = (BOSLookupEdit)Controls[PaymentCashModule.CSCompanyBankToLookupEditControlName];
            CSCompanyBankToLookupEditControl.Properties.DataSource = objCompanyBanksController.GetListCompanyBanksByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            CreditAccountID = 0;
            DebitAccountID = 0;
        }
        #endregion

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #region Overrides
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACBankTransactionsInfo searchObject = (ACBankTransactionsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //DataSet ds = objBankTransactionsController.GetBankTransactionList(
            //                                                           searchObject.ACBankTransactionNo,
            //                                                           objObjectsInfo.ACObjectID,                                                                       
            //                                                           objObjectsInfo.ACObjectType,
            //                                                           BankTransactionType.PaymentCash.ToString(),
            //                                                           searchObject.FK_HREmployeeID,
            //                                                           searchObject.BankTransactionDateFrom,
            //                                                           searchObject.BankTransactionDateTo);
            //return ds;

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objBankTransactionsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = ds = objBankTransactionsController.GetBankTransactionList(
                                                                       searchObject.ACBankTransactionNo,
                                                                       BranchList,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       BankTransactionType.PaymentCash.ToString(),
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.BankTransactionDateFrom,
                                                                       searchObject.BankTransactionDateTo);
                }
            }
            else
            {
                ds = objBankTransactionsController.GetBankTransactionListByBranchID(
                                                                       searchObject.ACBankTransactionNo,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       BankTransactionType.PaymentCash.ToString(),
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.BankTransactionDateFrom,
                                                                       searchObject.BankTransactionDateTo,
                                                                       searchObject.FK_BRBranchID);
            }
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            return ds;
        }

        public override int ActionSave()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            entity.BankTransactionItemList.EndCurrentEdit();
            UpdateTotalAmount();
            int bankTransactionID = base.ActionSave();
            return bankTransactionID;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Called when user wants to change the bank
        /// </summary>
        /// <param name="companyBankID">The company bank ID.</param>
        //public void ChangeBank(int companyBankID)
        //{
        //    ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
        //    objBankTransactionsInfo.FK_CSCompanyBankID = companyBankID;
        //    CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
        //    CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(companyBankID);
        //    if (objCompanyBanksInfo != null)
        //    {
        //        objBankTransactionsInfo.ACBankTransactionSenderAccount = objCompanyBanksInfo.CSCompanyBankAccount;
        //        CurrentModuleEntity.UpdateMainObjectBindingSource();
        //    }

        //}

        /// <summary>
        /// Called when the user changes object
        /// </summary>
        /// <param name="objectAccessKey">Object access key</param>
        public void ChangeObject(string objectAccessKey)
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            objBankTransactionsInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objBankTransactionsInfo.ACBankTransactionReceiverName = objObjectsInfo.ACObjectName;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Updates the total amount.
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
                ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;

                objBankTransactionsInfo.ACBankTransactionTotalAmount = 0;
                objBankTransactionsInfo.ACBankTransactionExchangeAmount = 0;

                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemAmount", objBankTransactionsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    objBankTransactionsInfo.ACBankTransactionTotalAmount += item.ACBankTransactionItemAmount;
                    objBankTransactionsInfo.ACBankTransactionExchangeAmount += item.ACBankTransactionItemExchangeAmount;

                }
                //objBankTransactionsInfo.ACBankTransactionTotalAmount = entity.BankTransactionItemList.Sum(i => i.ACBankTransactionItemAmount);
                //objBankTransactionsInfo.ACBankTransactionExchangeAmount = entity.BankTransactionItemList.Sum(i => i.ACBankTransactionItemExchangeAmount);

                BOSApp.RoundByCurrency(objBankTransactionsInfo, "ACBankTransactionTotalAmount", objBankTransactionsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objBankTransactionsInfo, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);

                entity.UpdateMainObjectBindingSource();
                UpdateDocumentEntries();
            }
        }

        public void ChangeCurrency(int currencyID)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;

            objBankTransactionsInfo.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(objBankTransactionsInfo.FK_GECurrencyID, objBankTransactionsInfo.ACBankTransactionDate);
            objBankTransactionsInfo.ACBankTransactionExchangeRate = (dCurrencyExchangeRate > 0)
                                                               ? dCurrencyExchangeRate
                                                               : 1;
            UpdateTotalAmount();
        }
        /// <summary>
        /// Changes the payment cash item amount.
        /// </summary>        
        /// <param name="item">Changed item</param>
        public void ChangePaymentCashItemAmount(ACBankTransactionItemsInfo item)
        {
            ACBankTransactionsInfo paymentCash = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            item.ACBankTransactionItemExchangeAmount = item.ACBankTransactionItemAmount * paymentCash.ACBankTransactionExchangeRate;
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemAmount", paymentCash.FK_GECurrencyID);
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
        }

        public void ChangeExchangeRate()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            entity.BankTransactionItemList.ForEach(p =>
            {
                ChangePaymentCashItemAmount(p);
            });
            UpdateDocumentEntries();
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Remove the selected bank transaction item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            entity.BankTransactionItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }
        #endregion

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            if (objBankTransactionsInfo.ACBankTransactionReference != null && objBankTransactionsInfo.ACBankTransactionReference != String.Empty)
            {
                GetAccountID();
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    if (item.FK_ACDebitAccountID == null || item.FK_ACDebitAccountID == 0)
                    {
                        item.FK_ACDebitAccountID = DebitAccountID;
                    }
                }
                foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                {
                    ACBankTransactionItemsInfo item = entity.BankTransactionItemList.FirstOrDefault(x => x.FK_ACEntryTypeID == entry.FK_ACEntryTypeID);
                    if (item != null)
                    {
                        entry.FK_ACObjectID = objBankTransactionsInfo.FK_ACObjectID;
                        entry.ACObjectType = objBankTransactionsInfo.ACObjectType;
                        entry.ACDocumentEntryDesc = item.ACBankTransactionItemDesc;
                        entry.FK_ACDebitAccountID = item.FK_ACDebitAccountID;
                        entry.FK_ACCreditAccountID = item.FK_ACCreditAccountID;
                        entry.ACDocumentEntryAmount = item.ACBankTransactionItemAmount;
                        entry.ACDocumentEntryExchangeAmount = item.ACBankTransactionItemExchangeAmount;
                    }
                }
            }
            else
            {
                entity.DocumentEntryList.Clear();
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    SetItemDefaultAccount(item);
                    ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                    BOSUtil.CopyObject(item, entry);
                    entry.FK_ACDocumentTypeID = entity.DocumentTypeID;

                    BOSApp.RoundByCurrency(entry, "ACBankTransactionItemAmount", objBankTransactionsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    entity.DocumentEntryList.Add(entry);
                }
            }
            if (entity.DocumentEntryList.GridControl != null)
                entity.DocumentEntryList.GridControl.RefreshDataSource();
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }
        #endregion

        public void SetItemDefaultAccount(ACBankTransactionItemsInfo item)
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            item.ACBankTransactionItemDesc = mainObject.ACBankTransactionDesc;
            GetAccountID();
            if (item.FK_ACCreditAccountID == 0)
                item.FK_ACCreditAccountID = CreditAccountID;
            if (item.FK_ACDebitAccountID == 0)
                item.FK_ACDebitAccountID = DebitAccountID;
        }

        public void GetAccountID()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;

            CSCompanyBanksController cbController = new CSCompanyBanksController();
            CSCompanyBanksInfo cb;

            CSCashFundsController cfController = new CSCashFundsController();
            CSCashFundsInfo cf;

            int debitAccountID = 0;
            int creditAccountID = 0;
            // tu la co

            if (objBankTransactionsInfo.ACBankTransactionFromType == BankTransactionFromType.Bank.ToString())
            {
                cb = (CSCompanyBanksInfo)cbController.GetObjectByID(objBankTransactionsInfo.FK_CSCompanyBankID);
                if (cb != null)
                {
                    creditAccountID = cb.FK_ACAcountID;
                }
            }
            else if (objBankTransactionsInfo.ACBankTransactionFromType == BankTransactionFromType.CashFund.ToString())
            {
                cf = (CSCashFundsInfo)cfController.GetObjectByID(objBankTransactionsInfo.FK_CSCashFundID);
                if (cf != null)
                {
                    creditAccountID = cf.FK_ACAcountID;
                }
            }

            // den la no
            if (objBankTransactionsInfo.ACBankTransactionToType == BankTransactionToType.Bank.ToString())
            {
                cb = (CSCompanyBanksInfo)cbController.GetObjectByID(objBankTransactionsInfo.FK_ToCSCompanyBankID);
                if (cb != null)
                {
                    debitAccountID = cb.FK_ACAcountID;
                }
            }
            else if (objBankTransactionsInfo.ACBankTransactionToType == BankTransactionToType.CashFund.ToString())
            {
                cf = (CSCashFundsInfo)cfController.GetObjectByID(objBankTransactionsInfo.FK_ToCSCashFundID);
                if (cf != null)
                {
                    debitAccountID = cf.FK_ACAcountID;
                }
            }
            CreditAccountID = creditAccountID;
            DebitAccountID = debitAccountID;
        }

        public string GetFromType()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;

            return mainObject.ACBankTransactionFromType;
        }

        public string GetToType()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;

            return mainObject.ACBankTransactionToType;
        }

        public void ChangeFromType(string fromType)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;

            objBankTransactionsInfo.ACBankTransactionFromType = fromType;

            if (objBankTransactionsInfo.ACBankTransactionFromType == BankTransactionFromType.Bank.ToString())
            {
                objBankTransactionsInfo.FK_CSCashFundID = 0;
            }
            else if (objBankTransactionsInfo.ACBankTransactionFromType == BankTransactionFromType.CashFund.ToString())
            {
                objBankTransactionsInfo.FK_CSCompanyBankID = 0;
            }

            UpdateDocumentEntries();
        }

        public void ChangeToType(string toType)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;

            objBankTransactionsInfo.ACBankTransactionToType = toType;

            if (objBankTransactionsInfo.ACBankTransactionToType == BankTransactionToType.Bank.ToString())
            {
                objBankTransactionsInfo.FK_ToCSCashFundID = 0;
            }
            else if (objBankTransactionsInfo.ACBankTransactionToType == BankTransactionToType.CashFund.ToString())
            {
                objBankTransactionsInfo.FK_ToCSCompanyBankID = 0;
            }

            UpdateDocumentEntries();
        }

        public void ChangeCashFund(int cashFundID)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            objBankTransactionsInfo.FK_CSCashFundID = cashFundID;

            CSCashFundsController cfController = new CSCashFundsController();
            CSCashFundsInfo cf = (CSCashFundsInfo)cfController.GetObjectByID(cashFundID);
            int accountCreditID = 0;
            if (cf != null)
            {
                accountCreditID = cf.FK_ACAcountID;
            }

            entity.DocumentEntryList.ForEach(t => t.FK_ACCreditAccountID = accountCreditID);
            if (entity.DocumentEntryList.GridControl != null)
                entity.DocumentEntryList.GridControl.RefreshDataSource();

            entity.BankTransactionItemList.ForEach(t => t.FK_ACCreditAccountID = accountCreditID);
            entity.BankTransactionItemList.GridControl.RefreshDataSource();

        }

        public void ChangeToCashFund(int cashFundID)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            objBankTransactionsInfo.FK_ToCSCashFundID = cashFundID;

            CSCashFundsController cfController = new CSCashFundsController();
            CSCashFundsInfo cf = (CSCashFundsInfo)cfController.GetObjectByID(cashFundID);
            int accountDebitID = 0;
            if (cf != null)
            {
                accountDebitID = cf.FK_ACAcountID;
            }
            if (objBankTransactionsInfo.ACBankTransactionReference != null && objBankTransactionsInfo.ACBankTransactionReference != String.Empty)
            {
                foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                {
                    if (entry.FK_ACDebitAccountID == null || entry.FK_ACDebitAccountID == 0)
                    {
                        entry.FK_ACDebitAccountID = accountDebitID;
                    }
                }
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    if (item.FK_ACDebitAccountID == null || item.FK_ACDebitAccountID == 0)
                    {
                        item.FK_ACDebitAccountID = accountDebitID;
                    }
                }
            }
            else
            {
                entity.DocumentEntryList.ForEach(t => t.FK_ACDebitAccountID = accountDebitID);
                entity.BankTransactionItemList.ForEach(t => t.FK_ACDebitAccountID = accountDebitID);
            }
            if (entity.DocumentEntryList.GridControl != null)
                entity.DocumentEntryList.GridControl.RefreshDataSource();
            entity.BankTransactionItemList.GridControl.RefreshDataSource();

        }

        public void ChangeBank(int companyBankID)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            objBankTransactionsInfo.FK_CSCompanyBankID = companyBankID;


            int accountCreditID = 0;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(companyBankID);
            if (objCompanyBanksInfo != null)
            {
                objBankTransactionsInfo.ACBankTransactionSenderAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                CurrentModuleEntity.UpdateMainObjectBindingSource();

                accountCreditID = objCompanyBanksInfo.FK_ACAcountID;
            }

            entity.DocumentEntryList.ForEach(t => t.FK_ACCreditAccountID = accountCreditID);
            if (entity.DocumentEntryList.GridControl != null)
                entity.DocumentEntryList.GridControl.RefreshDataSource();

            entity.BankTransactionItemList.ForEach(t => t.FK_ACCreditAccountID = accountCreditID);
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }


        public void ChangeToBank(int companyBankID)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            objBankTransactionsInfo.FK_ToCSCompanyBankID = companyBankID;


            int accountDebitID = 0;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(companyBankID);
            if (objCompanyBanksInfo != null)
            {
                accountDebitID = objCompanyBanksInfo.FK_ACAcountID;
                objBankTransactionsInfo.ACBankTransactionReceiverBankName = objCompanyBanksInfo.CSCompanyBankName;
                objBankTransactionsInfo.ACBankTransactionReceiverAccount = objCompanyBanksInfo.CSCompanyBankAccount;
            }

            if (objBankTransactionsInfo.ACBankTransactionReference != null && objBankTransactionsInfo.ACBankTransactionReference != String.Empty)
            {
                foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                {
                    if (entry.FK_ACDebitAccountID == null || entry.FK_ACDebitAccountID == 0)
                    {
                        entry.FK_ACDebitAccountID = accountDebitID;
                    }
                }
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    if (item.FK_ACDebitAccountID == null || item.FK_ACDebitAccountID == 0)
                    {
                        item.FK_ACDebitAccountID = accountDebitID;
                    }
                }
            }
            else
            {
                entity.DocumentEntryList.ForEach(t => t.FK_ACDebitAccountID = accountDebitID);
                entity.BankTransactionItemList.ForEach(t => t.FK_ACDebitAccountID = accountDebitID);
            }
            if (entity.DocumentEntryList.GridControl != null)
                entity.DocumentEntryList.GridControl.RefreshDataSource();
            entity.BankTransactionItemList.GridControl.RefreshDataSource();


        }

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
                ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
                objBankTransactionsInfo.ACBankTransactionStatus = BankTransactionStatus.Approved.ToString();
                objBankTransactionsInfo.FK_HREmployeeApprovedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                entity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public override bool ActionComplete()
        {
            GenerateAccountingData();
            UpdateDocumentEntries();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            //objBankTransactionsInfo.ACBankTransactionStatus = BankTransactionStatus.Approved.ToString();
            objBankTransactionsInfo.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            return base.ActionComplete();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            entity.BankTransactionItemList.ForEach(x => x.ACDocumentNo = objBankTransactionsInfo.ACBankTransactionReference);
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(PaymentCashModule.ToolbarButtonApprove, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            if (objBankTransactionsInfo.ACBankTransactionID > 0)
            {
                if (objBankTransactionsInfo.ACBankTransactionStatus == BankTransactionStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(PaymentCashModule.ToolbarButtonApprove, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
                else if (objBankTransactionsInfo.ACBankTransactionStatus == BankTransactionStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(PaymentCashModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);

                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(PaymentCashModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                         objBankTransactionsInfo.ACBankTransactionPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        objBankTransactionsInfo.ACBankTransactionPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
            }
        }

        #region ActionNew
        public override void ActionNew()
        {
            base.ActionNew();
        }

        public void ActionNewReceivedTransfer()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionNew();
                PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
                ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                List<ACDocumentsInfo> ds = objDocumentsController.GetDocumentsForReceivedTransfer();
                BOSList<ACDocumentsInfo> documentsList = new BOSList<ACDocumentsInfo>();
                foreach (ACDocumentsInfo item in ds)
                {
                    documentsList.Add(item);
                }
                ShowDocumentsList(documentsList);
            }
        }

        private void ShowDocumentsList(BOSList<ACDocumentsInfo> documentsList)
        {
            guiChooseDocument guiDocument = new guiChooseDocument(documentsList);
            guiDocument.Module = this;
            if (guiDocument.ShowDialog() == DialogResult.OK)
            {
                List<ACDocumentsInfo> acDocumentsList = (List<ACDocumentsInfo>)guiDocument.SelectedObjects;
                ACDocumentsInfo objDocumentsInfo = acDocumentsList.FirstOrDefault();
                if (objDocumentsInfo != null)
                {
                    SetMainObjectReceivedTransfer(objDocumentsInfo);
                    SetModuleObjectReceivedTransfer(objDocumentsInfo);
                }
                else
                {
                    MessageBox.Show(PaymentCashLocalizedResources.ErrorDocument, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowDocumentsList(documentsList);
                }
            }
            else
                ActionCancel();
        }

        public void SetMainObjectReceivedTransfer(ACDocumentsInfo documentsInfo)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.FK_ACObjectID = documentsInfo.FK_ACObjectID;
            mainObject.ACObjectType = documentsInfo.ACObjectType;
            mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
            mainObject.FK_GECurrencyID = documentsInfo.FK_GECurrencyID;
            mainObject.ACBankTransactionExchangeRate = documentsInfo.ACDocumentExchangeRate;
            mainObject.ACBankTransactionDesc = documentsInfo.ACDocumentDesc;
            mainObject.FK_CSCashFundID = documentsInfo.FK_CSCashFundID;
            mainObject.FK_CSCompanyBankID = documentsInfo.FK_CSCompanyBankID;
            mainObject.ACBankTransactionReference = documentsInfo.ACDocumentNo;

            if (mainObject.FK_CSCompanyBankID != null && mainObject.FK_CSCompanyBankID > 0)
            {
                mainObject.ACBankTransactionFromType = BankTransactionFromType.Bank.ToString();
                CSCashFundFromLookupEditControl.Visible = false;
                CSCompanyBankFromLookupEditControl.Visible = true;
            }
            if (mainObject.FK_CSCashFundID != null && mainObject.FK_CSCashFundID > 0)
            {
                mainObject.ACBankTransactionFromType = BankTransactionFromType.CashFund.ToString();
                CSCashFundFromLookupEditControl.Visible = true;
                CSCompanyBankFromLookupEditControl.Visible = false;
            }
        }

        public void SetModuleObjectReceivedTransfer(ACDocumentsInfo documentsInfo)
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            GetDocumentTypeID();
            GenerateAccountingData();
            List<ACBankTransactionItemsInfo> listBankTransactionItemsInfo = new List<ACBankTransactionItemsInfo>();
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.TienChuyenDen.ToString())
                {
                    entry.FK_ACObjectID = mainObject.FK_ACObjectID;
                    entry.ACObjectType = mainObject.ACObjectType;
                    entry.FK_ACCreditAccountID = documentsInfo.FK_ACDebitAccountID;
                    entry.ACDocumentEntryAmount = documentsInfo.ACDocumentTotalAmount - documentsInfo.ACDocumentBankFee;
                    entry.ACDocumentEntryExchangeAmount = documentsInfo.ACDocumentCashToAmount;
                }
                if (entry.ACEntryTypeName == AccEntryType.PhiNganHang.ToString())
                {
                    entry.FK_ACObjectID = mainObject.FK_ACObjectID;
                    entry.ACObjectType = mainObject.ACObjectType;
                    entry.FK_ACCreditAccountID = documentsInfo.FK_ACDebitAccountID;
                    entry.ACDocumentEntryAmount = documentsInfo.ACDocumentBankFee;
                    entry.ACDocumentEntryExchangeAmount = documentsInfo.ACDocumentBankExchangeFee;
                }
                ACBankTransactionItemsInfo item = new ACBankTransactionItemsInfo();
                item.FK_ACBankTransactionID = mainObject.ACBankTransactionID;
                item.FK_ACEntryTypeID = entry.FK_ACEntryTypeID;
                item.ACBankTransactionItemDesc = documentsInfo.ACDocumentDesc;
                item.FK_ACDebitAccountID = entry.FK_ACDebitAccountID;
                item.FK_ACCreditAccountID = entry.FK_ACCreditAccountID;
                item.ACBankTransactionItemAmount = entry.ACDocumentEntryAmount;
                item.ACBankTransactionItemExchangeAmount = entry.ACDocumentEntryExchangeAmount;
                item.ACDocumentNo = documentsInfo.ACDocumentNo;
                listBankTransactionItemsInfo.Add(item);
            }
            entity.BankTransactionItemList.Invalidate(listBankTransactionItemsInfo);
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }
        #endregion

        #region ActionPrint
        public void ActionPrintPaymentCash()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ADReportsController objReportsController = new ADReportsController();
                RPPaymentCash report = new RPPaymentCash();
                List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(Toolbar.CurrentObjectID);

                report.DataSource = bankTransactionItemList;
                InitBankTransactionReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPPaymentCashPath, true);
                reviewer.Show();
            }
        }

        public void ActionPrintPaymentCashPayment()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ADReportsController objReportsController = new ADReportsController();
                ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
                RPPaymentCashPayment report = new RPPaymentCashPayment();
                List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(Toolbar.CurrentObjectID);
                report.ACBankTransactionItems.DataSource = bankTransactionItemList;

                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo objBankTransactionsInfo = objBankTransactionsController.GetBankTransactionByID(mainObject.ACBankTransactionID);
                report.ACBankTransactions.DataSource = objBankTransactionsInfo == null ? new ACBankTransactionsInfo() : objBankTransactionsInfo;
                InitPaymentCashReport(report, "Payment");
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPPaymentCashPath, true);
                reviewer.Show();
            }
        }

        public void ActionPrintPaymentCashReceipt()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ADReportsController objReportsController = new ADReportsController();
                ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
                RPPaymentCashReceipt report = new RPPaymentCashReceipt();
                List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(Toolbar.CurrentObjectID);

                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo objBankTransactionsInfo = objBankTransactionsController.GetBankTransactionByID(mainObject.ACBankTransactionID);
                report.ACBankTransactions.DataSource = objBankTransactionsInfo == null ? new ACBankTransactionsInfo() : objBankTransactionsInfo;
                report.ACBankTransactionItems.DataSource = bankTransactionItemList;
                InitPaymentCashReport(report, "Receipt");
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPPaymentCashPath, true);
                reviewer.Show();
            }
        }

        /// <summary>
        /// Inits the bank transaction report
        /// </summary>
        /// <param name="report">The report.</param>
        public void InitBankTransactionReport(XtraReport report)
        {
            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            XRLabel employeeNameLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblEmployeeName"];
            HREmployeesController objEmployessController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployessController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                employeeNameLabel.Text = objEmployeesInfo.HREmployeeName;
            }
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = objBankTransactionsController.GetBankTransactionByID(Toolbar.CurrentObjectID);

            XRLabel currentCompany = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["rp_xrlCurrentCompany"];
            currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
            if (objBankTransactionsInfo != null)
            {
                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblReadAmount"];
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(),
                                                                            objBankTransactionsInfo.FK_GECurrencyID);
                    }
                }
            }
        }

        public void InitPaymentCashReport(XtraReport report, string reportType)
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel taxNumber = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblMST"];
            if (taxNumber != null)
                taxNumber.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;
            XRLabel employeeName = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblHREmployeeName"];
            if (employeeName != null)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    employeeName.Text = objEmployeesInfo.HREmployeeName;
                }
            }
            ADReportsController objReportsController = new ADReportsController();
            List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(Toolbar.CurrentObjectID);
            decimal totalExchangeAmount = 0;
            string debitAccountNo = string.Empty;
            string creditAccountNo = string.Empty;
            if (reportType == "Payment")
            {
                foreach (ACBankTransactionItemsInfo item in bankTransactionItemList)
                {
                    totalExchangeAmount += item.ACBankTransactionItemExchangeAmount;
                    if (!debitAccountNo.Contains(item.DebitAccountNo))
                        debitAccountNo += string.Format(" {0},", item.DebitAccountNo);
                    if (!creditAccountNo.Contains(item.CreditAccountNo))
                        creditAccountNo += string.Format(" {0},", item.CreditAccountNo);
                }
            }
            else
            {
                ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                ACEntryTypesInfo objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.TienChuyenDen);
                foreach (ACBankTransactionItemsInfo item in bankTransactionItemList)
                {
                    if (item.FK_ACEntryTypeID == objEntryTypesInfo.ACEntryTypeID)
                    {
                        totalExchangeAmount += item.ACBankTransactionItemExchangeAmount;
                        if (!debitAccountNo.Contains(item.DebitAccountNo))
                            debitAccountNo += string.Format(" {0},", item.DebitAccountNo);
                        if (!creditAccountNo.Contains(item.CreditAccountNo))
                            creditAccountNo += string.Format(" {0},", item.CreditAccountNo);
                    }
                }
            }

            XRLabel totalAmount = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTotalAmount"];
            if (totalAmount != null)
            {
                if (mainObject.FK_GECurrencyID == GECurrencyID.VND)
                    totalAmount.Text = String.Format("{0:#,#}", totalExchangeAmount);
                else
                    totalAmount.Text = String.Format("{0:N}", totalExchangeAmount);
            }
            XRLabel totalAmountDebit = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTotalAmountDebit"];
            if (totalAmountDebit != null)
            {
                if (mainObject.FK_GECurrencyID == GECurrencyID.VND)
                    totalAmountDebit.Text = String.Format("{0:#,#}", totalExchangeAmount);
                else
                    totalAmountDebit.Text = String.Format("{0:N}", totalExchangeAmount);
            }
            XRLabel totalAmountCredit = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTotalAmountCredit"];
            if (totalAmountCredit != null)
            {
                if (mainObject.FK_GECurrencyID == GECurrencyID.VND)
                    totalAmountCredit.Text = String.Format("{0:#,#}", totalExchangeAmount);
                else
                    totalAmountCredit.Text = String.Format("{0:N}", totalExchangeAmount);
            }
            XRLabel accountDebitNo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAccountDebitNo"];
            if (accountDebitNo != null)
                accountDebitNo.Text = debitAccountNo.TrimEnd(',');
            XRLabel accountCreditNo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAccountCreditNo"];
            if (accountCreditNo != null)
                accountCreditNo.Text = creditAccountNo.TrimEnd(',');
            XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAmountWordTop"];
            if (amountWordTop != null)
                amountWordTop.Text = ConvertAmountToWord.ReadAmount(totalExchangeAmount.ToString(), mainObject.FK_GECurrencyID);
            XRLabel amountWordBottom = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWordBottom"];
            if (amountWordBottom != null)
                amountWordBottom.Text = ConvertAmountToWord.ReadAmount(totalExchangeAmount.ToString(), mainObject.FK_GECurrencyID);
        }
        #endregion

        public override void ModuleAfterCompleted()
        {
            ActionPosted();
            base.ModuleAfterCompleted();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.ACBankTransactionPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACBankTransactionID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, mainObject.ACBankTransactionID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.ACBankTransactionPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACBankTransactionID, PostedTransactionStatus.UnPosted.ToString());
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACBankTransactionID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ValidatedItemDesc()
        {
            PaymentCashEntities entity = (PaymentCashEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
            {
                item.ACBankTransactionItemDesc = mainObject.ACBankTransactionDesc;
            }
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }
    }
}

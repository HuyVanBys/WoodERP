using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountInitialBalance
{
    public class AccountInitialBalanceModule : BaseModuleERP
    {
        #region Constants
        public const string AccountTreeListControlName = "fld_trlACAccounts";
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public AccountInitialBalanceModule()
        {
            Name = "AccountInitialBalance";
            CurrentModuleEntity = new AccountInitialBalanceEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        #endregion

        #region Method
        /// <summary>
        /// Updates the initial balance for account parent
        /// </summary>
        /// <param name="objAccountsInfo">Given accounts info</param>
        public void UpdateInitialBalanceAccountParent(ACAccountsInfo objAccountsInfo)
        {
            if (objAccountsInfo.Parent != null)
            {
                ACAccountsInfo accountParent = (ACAccountsInfo)objAccountsInfo.Parent;
                accountParent.ACAccountInitialBalanceCredit = 0;
                accountParent.ACAccountInitialBalanceDebit = 0;
                BOSTreeList subList = (BOSTreeList)accountParent.SubList;
                if (subList.Count > 0)
                {
                    foreach (ACAccountsInfo accountChild in subList)
                    {
                        accountParent.ACAccountInitialBalanceCredit += accountChild.ACAccountInitialBalanceCredit;
                        accountParent.ACAccountInitialBalanceDebit += accountChild.ACAccountInitialBalanceDebit;
                    }
                }
                if (accountParent.Parent != null)
                    UpdateInitialBalanceAccountParent(accountParent);
            }
        }

        /// <summary>
        /// Saves the initial balance account
        /// </summary>
        public void SaveInitialBalanceAccount()
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)CurrentModuleEntity;
            BOSTreeListControl treeListControl = entity.AccountList.TreeListControl;
            treeListControl.EndCurrentEdit();
            foreach (ACAccountsInfo objAccountsInfo in entity.AccountList)
            {
                SetChildAccount(objAccountsInfo);
            }
            entity.AccountList.SaveItemObjects();
            MessageBox.Show(AccountInitialBalanceLocalizedResource.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Invalidates the account list for display
        /// </summary>
        public void InvalidateAccountList()
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)CurrentModuleEntity;
            foreach (ACAccountsInfo objAccountsInfo in entity.AccountList)
            {
                InvalidateChildAccount(objAccountsInfo);
            }
        }


        /// <summary>
        /// Sets the child account
        /// </summary>
        /// <param name="objAccountsInfo">Given accounts info</param>
        public void SetChildAccount(ACAccountsInfo objAccountsInfo)
        {
            SetAccountInitialBalance(objAccountsInfo);
            if (objAccountsInfo.HasChildren())
            {
                foreach (ACAccountsInfo currentAccount in objAccountsInfo.SubList)
                {
                    SetChildAccount(currentAccount);
                }
            }
        }


        /// <summary>
        /// Invalidate the child accounts for display
        /// </summary>
        /// <param name="objAccountsInfo">Given accounts info</param>
        public void InvalidateChildAccount(ACAccountsInfo objAccountsInfo)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            objAccountsInfo.ACAccountInitialBalance = objAccountsController.GetAccountInitialBalance(objAccountsInfo.ACAccountNo);
            InvalidateAccountInitialBalance(objAccountsInfo);
            if (objAccountsInfo.HasChildren())
            {
                foreach (ACAccountsInfo currentAccount in objAccountsInfo.SubList)
                {
                    InvalidateChildAccount(currentAccount);
                }
            }
        }

        /// <summary>
        /// Set the account initial balance
        /// </summary>
        /// <param name="objAccountsInfo">Given accounts info</param>
        public void SetAccountInitialBalance(ACAccountsInfo account)
        {
            if (account.ACAccountType == AccAccountType.DebitBalance.ToString())
            {
                account.ACAccountInitialBalance = account.ACAccountInitialBalanceDebit;
            }
            else if (account.ACAccountType == AccAccountType.CreditBalance.ToString())
            {
                account.ACAccountInitialBalance = account.ACAccountInitialBalanceCredit;
            }
            else if (account.ACAccountType == AccAccountType.DebitCreditBalance.ToString())
            {
                if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                {
                    if (account.ACAccountInitialBalanceDebit > 0)
                    {
                        account.ACAccountInitialBalance = account.ACAccountInitialBalanceDebit;
                    }
                    else
                    {
                        account.ACAccountInitialBalance = -account.ACAccountInitialBalanceCredit;
                    }
                }
                else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                {
                    if (account.ACAccountInitialBalanceCredit > 0)
                    {
                        account.ACAccountInitialBalance = account.ACAccountInitialBalanceCredit;
                    }
                    else
                    {
                        account.ACAccountInitialBalance = -account.ACAccountInitialBalanceDebit;
                    }
                }
            }
        }

        /// <summary>
        /// Invalidate the account initial balance for display
        /// </summary>
        /// <param name="objAccountsInfo">Given accounts info</param>
        public void InvalidateAccountInitialBalance(ACAccountsInfo account)
        {
            if (account.ACAccountType == AccAccountType.DebitBalance.ToString())
            {
                account.ACAccountInitialBalanceDebit = account.ACAccountInitialBalance;
            }
            else if (account.ACAccountType == AccAccountType.CreditBalance.ToString())
            {
                account.ACAccountInitialBalanceCredit = account.ACAccountInitialBalance;
            }
            else if (account.ACAccountType == AccAccountType.DebitCreditBalance.ToString())
            {
                if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                {
                    if (account.ACAccountInitialBalance > 0)
                    {
                        account.ACAccountInitialBalanceDebit = account.ACAccountInitialBalance;
                    }
                    else
                    {
                        account.ACAccountInitialBalanceCredit = Math.Abs(account.ACAccountInitialBalance);
                    }
                }
                else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                {
                    if (account.ACAccountInitialBalance > 0)
                    {
                        account.ACAccountInitialBalanceCredit = account.ACAccountInitialBalance;
                    }
                    else
                    {
                        account.ACAccountInitialBalanceDebit = Math.Abs(account.ACAccountInitialBalance);
                    }
                }
            }
        }
        #endregion

        #region Account details
        /// <summary>
        /// Show context menu when user clicks right button of mouse
        /// </summary>
        /// <param name="x">x-coordinator of mouse</param>
        /// <param name="y">y-coordinator of mouse</param>
        public void ShowContextMenu(int x, int y)
        {
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(AccountInitialBalanceLocalizedResource.InputDetails, new EventHandler(InputDetails_Click));
            BOSTreeListControl accountTreeListControl = (BOSTreeListControl)Controls[AccountInitialBalanceModule.AccountTreeListControlName];
            contextMenu.Show(accountTreeListControl, new Point(x, y));
        }

        private void InputDetails_Click(object sender, EventArgs e)
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)CurrentModuleEntity;
            ACAccountsInfo account = (ACAccountsInfo)entity.AccountList.CurrentObject;
            if (account != null)
            {
                guiAccountDetails guiAccountDetails = new guiAccountDetails();
                guiAccountDetails.Module = this;
                guiAccountDetails.ShowDialog();

                ACAccountsInfo parentAccount = account;
                while (parentAccount != null && parentAccount.Parent != null)
                {
                    parentAccount = (ACAccountsInfo)parentAccount.Parent;
                }

                if (parentAccount != null)
                {
                    InvalidateChildAccount(parentAccount);
                    entity.AccountList.TreeListControl.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// Invalidate the details of an account by some criteria
        /// </summary>
        /// <param name="objectID">Object id</param>
        /// <param name="objectType">Object type</param>
        /// <param name="currencyID">Currency id</param>        
        public void InvalidateAccountDetails(int objectID, string objectType, int currencyID)
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)CurrentModuleEntity;
            ACAccountsInfo account = (ACAccountsInfo)entity.AccountList.CurrentObject;
            if (account != null)
            {
                ACAccountDetailsController objAccountDetailsController = new ACAccountDetailsController();
                List<ACAccountDetailsInfo> accountDetails = objAccountDetailsController.GetAccountDetailList(
                                                                                            account.ACAccountID,
                                                                                            objectID,
                                                                                            objectType,
                                                                                            currencyID);
                if (account.ACAccountNo.StartsWith(AccAccount.Acc112))
                {
                    CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                    List<CSCompanyBanksInfo> banks = objCompanyBanksController.GetAllBanks();
                    foreach (CSCompanyBanksInfo bank in banks)
                    {
                        ACAccountDetailsInfo accountDetail = accountDetails.Where(ab => ab.FK_CSCompanyBankID == bank.CSCompanyBankID).FirstOrDefault();
                        if (accountDetail == null)
                        {
                            accountDetail = new ACAccountDetailsInfo();
                            accountDetail.FK_ACAccountID = account.ACAccountID;
                            accountDetail.ACAccountNo = account.ACAccountNo;
                            accountDetail.ACAccountName = account.ACAccountName;

                            ACObjectsController objObjectsController = new ACObjectsController();
                            ACObjectsInfo obj = objObjectsController.GetObjectByIDAndType(objectID, objectType);
                            if (obj != null)
                            {
                                accountDetail.FK_ACObjectID = objectID;
                                accountDetail.ACObjectType = objectType;
                                accountDetail.ACObjectName = obj.ACObjectName;
                            }

                            accountDetail.FK_CSCompanyBankID = bank.CSCompanyBankID;
                            accountDetail.FK_GECurrencyID = currencyID;
                            accountDetail.ACAccountDetailExchangeRate = 1;
                            accountDetails.Add(accountDetail);
                        }
                    }
                }

                if (accountDetails.Count == 0)
                {
                    ACAccountDetailsInfo accountDetail = new ACAccountDetailsInfo();
                    accountDetail.FK_ACAccountID = account.ACAccountID;
                    accountDetail.ACAccountNo = account.ACAccountNo;
                    accountDetail.ACAccountName = account.ACAccountName;

                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo obj = objObjectsController.GetObjectByIDAndType(objectID, objectType);
                    if (obj != null)
                    {
                        accountDetail.FK_ACObjectID = objectID;
                        accountDetail.ACObjectType = objectType;
                        accountDetail.ACObjectName = obj.ACObjectName;
                    }

                    accountDetail.FK_GECurrencyID = currencyID;
                    accountDetail.ACAccountDetailExchangeRate = 1;
                    accountDetails.Add(accountDetail);
                }

                foreach (ACAccountDetailsInfo accountDetail in accountDetails)
                {
                    InvalidateAccountInitialBalance(account, accountDetail);
                }
                entity.AccountDetailList.Invalidate(accountDetails);
            }
        }

        /// <summary>
        /// Save the details of an account
        /// </summary>
        public void SaveAccountDetails()
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)CurrentModuleEntity;
            ACAccountsInfo account = (ACAccountsInfo)entity.AccountList.CurrentObject;
            if (account != null)
            {
                foreach (ACAccountDetailsInfo accountDetail in entity.AccountDetailList)
                {
                    SetAccountInitialBalance(account, accountDetail);
                }

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    entity.AccountDetailList.SaveItemObjects();
                    MessageBox.Show(AccountInitialBalanceLocalizedResource.SaveSuccessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    scope.Complete();
                }
            }
        }

        /// <summary>
        /// Invalidate the balance of an account for displaying
        /// </summary>
        /// <param name="account">Given account</param>
        /// <param name="accountDetail">Account detail</param>
        private void InvalidateAccountInitialBalance(ACAccountsInfo account, ACAccountDetailsInfo accountDetail)
        {
            if (account.ACAccountType == AccAccountType.DebitBalance.ToString())
            {
                accountDetail.AccountDebitBalanceByCurrency = accountDetail.ACAccountDetailInitialBalanceByCurrency;
                accountDetail.AccountDebitBalance = accountDetail.ACAccountDetailInitialBalance;
            }
            else if (account.ACAccountType == AccAccountType.CreditBalance.ToString())
            {
                accountDetail.AccountCreditBalanceByCurrency = accountDetail.ACAccountDetailInitialBalanceByCurrency;
                accountDetail.AccountCreditBalance = accountDetail.ACAccountDetailInitialBalance;
            }
            else if (account.ACAccountType == AccAccountType.DebitCreditBalance.ToString())
            {
                if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                {
                    if (accountDetail.ACAccountDetailInitialBalance > 0)
                    {
                        accountDetail.AccountDebitBalanceByCurrency = accountDetail.ACAccountDetailInitialBalanceByCurrency;
                        accountDetail.AccountDebitBalance = accountDetail.ACAccountDetailInitialBalance;
                    }
                    else
                    {
                        accountDetail.AccountCreditBalanceByCurrency = Math.Abs(accountDetail.ACAccountDetailInitialBalanceByCurrency);
                        accountDetail.AccountCreditBalance = Math.Abs(accountDetail.ACAccountDetailInitialBalance);
                    }
                }
                else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                {
                    if (accountDetail.ACAccountDetailInitialBalance > 0)
                    {
                        accountDetail.AccountCreditBalanceByCurrency = accountDetail.ACAccountDetailInitialBalanceByCurrency;
                        accountDetail.AccountCreditBalance = accountDetail.ACAccountDetailInitialBalance;
                    }
                    else
                    {
                        accountDetail.AccountDebitBalanceByCurrency = Math.Abs(accountDetail.ACAccountDetailInitialBalanceByCurrency);
                        accountDetail.AccountDebitBalance = Math.Abs(accountDetail.ACAccountDetailInitialBalance);
                    }
                }
            }
            //TNDLoc [ADD][27/09/2016][Round by currency],START
            BOSApp.RoundByCurrency(accountDetail, "AccountDebitBalanceByCurrency", accountDetail.FK_GECurrencyID);
            BOSApp.RoundByCurrency(accountDetail, "AccountDebitBalance", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            //TNDLoc [ADD][27/09/2016][Round by currency],END
        }

        /// <summary>
        /// Set the balance of an account for saving
        /// </summary>
        /// <param name="account">Given account</param>
        /// <param name="accountDetail">Account detail</param>
        private void SetAccountInitialBalance(ACAccountsInfo account, ACAccountDetailsInfo accountDetail)
        {
            CSCompanysInfo objCompanysInfo = BOSApp.CurrentCompanyInfo;
            if (account.ACAccountType == AccAccountType.DebitBalance.ToString())
            {
                accountDetail.ACAccountDetailInitialBalanceByCurrency = accountDetail.AccountDebitBalanceByCurrency;
                accountDetail.ACAccountDetailInitialBalance = accountDetail.AccountDebitBalance;
                accountDetail.ACAccountDetailDate = objCompanysInfo.CSCompanyAccountingBeginDateConfig.AddDays(-1);
            }
            else if (account.ACAccountType == AccAccountType.CreditBalance.ToString())
            {
                accountDetail.ACAccountDetailInitialBalanceByCurrency = accountDetail.AccountCreditBalanceByCurrency;
                accountDetail.ACAccountDetailInitialBalance = accountDetail.AccountCreditBalance;
                accountDetail.ACAccountDetailDate = objCompanysInfo.CSCompanyAccountingBeginDateConfig.AddDays(-1);
            }
            else if (account.ACAccountType == AccAccountType.DebitCreditBalance.ToString())
            {
                if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                {
                    if (accountDetail.AccountDebitBalance > 0)
                    {
                        accountDetail.ACAccountDetailInitialBalanceByCurrency = accountDetail.AccountDebitBalanceByCurrency;
                        accountDetail.ACAccountDetailInitialBalance = accountDetail.AccountDebitBalance;
                        accountDetail.ACAccountDetailDate = objCompanysInfo.CSCompanyAccountingBeginDateConfig.AddDays(-1);
                    }
                    else
                    {
                        accountDetail.ACAccountDetailInitialBalanceByCurrency = -accountDetail.AccountCreditBalanceByCurrency;
                        accountDetail.ACAccountDetailInitialBalance = -accountDetail.AccountCreditBalance;
                        accountDetail.ACAccountDetailDate = objCompanysInfo.CSCompanyAccountingBeginDateConfig.AddDays(-1);
                    }
                }
                else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                {
                    if (accountDetail.AccountCreditBalance > 0)
                    {
                        accountDetail.ACAccountDetailInitialBalanceByCurrency = accountDetail.AccountCreditBalanceByCurrency;
                        accountDetail.ACAccountDetailInitialBalance = accountDetail.AccountCreditBalance;
                        accountDetail.ACAccountDetailDate = objCompanysInfo.CSCompanyAccountingBeginDateConfig.AddDays(-1);
                    }
                    else
                    {
                        accountDetail.ACAccountDetailInitialBalanceByCurrency = -accountDetail.AccountDebitBalanceByCurrency;
                        accountDetail.ACAccountDetailInitialBalance = -accountDetail.AccountDebitBalance;
                        accountDetail.ACAccountDetailDate = objCompanysInfo.CSCompanyAccountingBeginDateConfig.AddDays(-1);
                    }
                }
            }

            //TNDLoc [ADD][27/09/2016][Round by currency],START
            BOSApp.RoundByCurrency(accountDetail, "ACAccountDetailInitialBalanceByCurrency", accountDetail.FK_GECurrencyID);
            BOSApp.RoundByCurrency(accountDetail, "ACAccountDetailInitialBalance", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            //TNDLoc [ADD][27/09/2016][Round by currency],END
        }

        /// <summary>
        /// Called when the user changes the exchange info of an account detail
        /// </summary>
        /// <param name="accountDetail">Changed account detail</param>
        public void ChangeExchangeInfo(ACAccountDetailsInfo accountDetail)
        {
            accountDetail.AccountDebitBalance = accountDetail.AccountDebitBalanceByCurrency * accountDetail.ACAccountDetailExchangeRate;
            accountDetail.AccountCreditBalance = accountDetail.AccountCreditBalanceByCurrency * accountDetail.ACAccountDetailExchangeRate;

            //TNDLoc [ADD][27/09/2016][Round by currency],START
            BOSApp.RoundByCurrency(accountDetail, "AccountDebitBalance", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(accountDetail, "AccountCreditBalance", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            //TNDLoc [ADD][27/09/2016][Round by currency],END
        }
        #endregion
    }
}

using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.BankTransaction
{
    public class BankTransactionEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets bank transaction item list
        /// </summary>
        public BOSList<ACBankTransactionItemsInfo> BankTransactionItemList { get; set; }
        #endregion

        #region Constructor
        public BankTransactionEntities()
            : base()
        {
            BankTransactionItemList = new BOSList<ACBankTransactionItemsInfo>();
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
        }

        public override void InitGridControlInBOSList()
        {
            BankTransactionItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;
            objBankTransactionsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objBankTransactionsInfo.ACBankTransactionExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objBankTransactionsInfo.ACBankTransactionDate = DateTime.Now;
            objBankTransactionsInfo.ACBankTransactionType = BankTransactionType.BankTransfer.ToString();
            objBankTransactionsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BankTransactionItemList.SetDefaultListAndRefreshGridControl();
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
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ACBankTransactionsInfo bankTransfer = (ACBankTransactionsInfo)MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo bank = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankTransfer.FK_CSCompanyBankID);
            if (bank != null)
            {
                bankTransfer.ACBankTransactionReceiverBankName = bank.CSCompanyBankName;
            }
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            BankTransactionItemList.SaveItemObjects();
            SaveAccountingData();
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
        #endregion

        public override bool CompleteTransaction()
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;
            objBankTransactionsInfo.ACBankTransactionStatus = BankTransactionStatus.Completed.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }

        public override bool CancelCompleteTransaction()
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)MainObject;
            objBankTransactionsInfo.ACBankTransactionStatus = BankTransactionStatus.New.ToString();
            UpdateMainObject();
            return true;
        }
    }
}

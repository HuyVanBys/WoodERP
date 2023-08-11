using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Linq;

namespace BOSERP.Modules.AccountingBill
{
    public class AccountingBillEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        public BOSList<ACAccountingBillsInfo> AccountingBillsList { get; set; }
        #endregion

        #region Constructor
        public AccountingBillEntities()
            : base()
        {
            AccountingBillsList = new BOSList<ACAccountingBillsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACDocumentsInfo();
            SearchObject = new ACDocumentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACAccountingBillsTableName, new ICReceiptItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            DocumentEntryList.InitBOSList(
                                                    this,
                                                    TableName.ACDocumentsTableName,
                                                    TableName.ACDocumentEntrysTableName,
                                                    BOSList<ACDocumentEntrysInfo>.cstRelationForeign);
            DocumentEntryList.ItemTableForeignKey = "FK_ACDocumentID";
            AccountingBillsList.InitBOSList(
                                                    this,
                                                    TableName.ACDocumentsTableName,
                                                    TableName.ACAccountingBillsTableName,
                                                    BOSList<ACDocumentEntrysInfo>.cstRelationForeign);
            AccountingBillsList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            DocumentEntryList.InitBOSListGridControl();
            AccountingBillsList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.FK_ACDocumentTypeID = DefaultDocumentTypeID;
            objDocumentsInfo.ACDocumentDate = BOSApp.GetCurrentServerDate();
            objDocumentsInfo.FK_GECurrencyID = GECurrencyID.VND;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objDocumentsInfo.ACDocumentStatus = DocumentStatus.New.ToString();
            objDocumentsInfo.ACDocumentTaxEntryType = DocumentTaxEntryType.ThueGTGTDuocKhauTru.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
                AccountingBillsList.SetDefaultListAndRefreshGridControl();
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
            AccountingBillsList.Invalidate(iObjectID);
            AccountingBillsList.ForEach(o =>
            {
                o.ACObjectAccessKey = string.Join(";", new string[] { o.FK_ACDebitObjectID.ToString(), o.ACDebitObjectType });
                o.ACObjectCreditAccessKey = string.Join(";", new string[] { o.FK_ACCreditObjectID.ToString(), o.ACCreditObjectType });
            });
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentTotalAmount = AccountingBillsList.Sum(o => o.ACAccountingBillTotalAmount);
            objDocumentsInfo.ACDocumentExchangeAmount = objDocumentsInfo.ACDocumentTotalAmount * objDocumentsInfo.ACDocumentExchangeRate;

            BOSApp.RoundByCurrency(objDocumentsInfo, "ACDocumentTotalAmount", objDocumentsInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(objDocumentsInfo, "ACDocumentExchangeAmount", objDocumentsInfo.FK_GECurrencyID);
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            AccountingBillsList.SaveItemObjects();
            SaveDocumentEntrys((ACDocumentsInfo)MainObject);
            UpdateUnifinishedCost();
        }
        public void UpdateUnifinishedCost()
        {
            ACUnfinishedConstructionCostsController unfinishedCostController = new ACUnfinishedConstructionCostsController();
            if (AccountingBillsList.BackupList != null)
            {
                foreach (ACAccountingBillsInfo accountingbill in AccountingBillsList.BackupList)
                {
                    ACUnfinishedConstructionCostsInfo unfinishedCost = unfinishedCostController.GetObjectByID(accountingbill.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                    if (unfinishedCost != null)
                    {
                        unfinishedCost.ACUnfinishedConstructionCostValue -= accountingbill.ACAccountingBillExchangeAmount;
                        unfinishedCostController.UpdateObject(unfinishedCost);
                    }
                }
            }

            foreach (ACAccountingBillsInfo accountingbill in AccountingBillsList)
            {
                ACUnfinishedConstructionCostsInfo unfinishedCost = unfinishedCostController.GetObjectByID(accountingbill.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                if (unfinishedCost != null)
                {
                    unfinishedCost.ACUnfinishedConstructionCostValue += accountingbill.ACAccountingBillExchangeAmount;
                    unfinishedCostController.UpdateObject(unfinishedCost);
                }
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            if (strTableName == TableName.ACDocumentsTableName)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                objDocumentsController.DeleteByID(iObjectID);
            }
        }

        public override void DuplicateModuleObjectList()
        {
            base.DuplicateModuleObjectList();
            AccountingBillsList.Duplicate();
        }
    }
}

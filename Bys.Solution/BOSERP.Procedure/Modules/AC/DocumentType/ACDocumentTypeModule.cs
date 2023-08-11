using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.ACDocumentType
{
    public class ACDocumentTypeModule : BaseModuleERP
    {
        #region Constant
        public const string ACDocTypeEntrysGridControlName = "fld_dgcACDocTypeEntrys";
        #endregion

        #region Private Variables

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets document type id
        /// </summary>
        public int DocumentTypeID { get; set; }

        /// <summary>
        /// The name's bos textbox control
        /// </summary>
        public BOSTextBox DocumentTypeDescTextBox { get; set; }
        #endregion

        #region Constructor
        public ACDocumentTypeModule()
        {
            Name = "ACDocumentType";
            CurrentModuleEntity = new ACDocumentTypeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            InvalidateDocumentTypeList();
            InvalidateDocTypeEntryFunctionMappingList();
            InvalidateModulePostingList();
            InvalidateAccountTranferCost();
        }
        #endregion

        public override void ModuleAfterLoaded()
        {
            base.ModuleAfterLoaded();

            //Enable toolbar button save
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, true);
        }

        #region Method

        /// <summary>
        /// Invalidate document type list
        /// </summary>
        public void InvalidateDocumentTypeList()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            DataSet ds = objDocumentTypesController.GetAllObjects();
            entity.ACDocumentTypeList.Invalidate(ds);
        }

        public void InvalidateDocTypeEntryFunctionMappingList()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            ACDocTypeEntryFunctionMappingsController objDTEFMController = new ACDocTypeEntryFunctionMappingsController();
            DataSet dsDocTypeEntryFunctionMappings = objDTEFMController.GetAllObjects();
            entity.ACDocTypeEntryFunctionMappingList.Invalidate(dsDocTypeEntryFunctionMappings);
        }

        public void InvalidateModulePostingList()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            STModulePostingsController objModulePostingsController = new STModulePostingsController();
            DataSet dsModulePostings = objModulePostingsController.GetAllObjects();
            entity.STModulePostingList.Invalidate(dsModulePostings);
        }
        public void InvalidateAccountTranferCost()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            ACAccountTranferCostsController objAccountTranferCostsController = new ACAccountTranferCostsController();
            DataSet dsAccountTranferCost = objAccountTranferCostsController.GetAllObjects();
            entity.ACAccountTranferCostList.Invalidate(dsAccountTranferCost);
        }


        /// <summary>
        /// Show form to allow user to change the selected document type
        /// </summary>
        public void ChangeDocumentType()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            if (entity.ACDocumentTypeList.CurrentIndex >= 0)
            {
                guiDocumentType guiDocumentType = new guiDocumentType();
                guiDocumentType.Module = this;
                if (guiDocumentType.ShowDialog() == DialogResult.OK)
                {
                    ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                    ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByID(DocumentTypeID);
                    objDocumentTypesInfo.ACDocumentTypeDesc = DocumentTypeDescTextBox.Text;
                    entity.UpdateDocumentType(objDocumentTypesInfo);
                    entity.ACDocumentTypeList.Invalidate(DocumentTypeID);
                }
            }
        }

        /// <summary>
        /// Get document type description for textbox.
        /// </summary>
        /// <param name="fld_txtACDocumentTypeDesc">The name's textbox </param>
        public void GetDocumentTypeDescForTextBox(BOSTextBox fld_txtACDocumentTypeDesc)
        {
            DocumentTypeDescTextBox = fld_txtACDocumentTypeDesc;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByID(DocumentTypeID);
            fld_txtACDocumentTypeDesc.Text = objDocumentTypesInfo.ACDocumentTypeDesc;
            fld_txtACDocumentTypeDesc.Select(fld_txtACDocumentTypeDesc.Text.Length, fld_txtACDocumentTypeDesc.Text.Length);
        }

        /// <summary>
        /// Config entry type button for show entry type
        /// </summary>
        public void ConfigEntryType()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            if (entity.ACDocumentTypeList.CurrentIndex >= 0)
            {
                ShowEntryType(DocumentTypeID);
            }
        }

        public override int ActionSave()
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    CurrentModuleEntity.SaveModuleObjects();
                    scope.Complete();
                    MessageBox.Show(DocumentTypeLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
                return 0;
            }
        }

        /// <summary>
        /// Show entry type form when double click on grid document type.
        /// </summary>
        /// <param name="documentTypeID">The document type id.</param>
        public void ShowEntryType(int documentTypeID)
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            entity.ACDocTypeEntryList.Clear();
            guiEditDocumentType guiEditDocumentType = new guiEditDocumentType();
            guiEditDocumentType.Module = this;
            GetDocTypeEntrysByDocumentTypeID(documentTypeID);
            if (guiEditDocumentType.ShowDialog() == DialogResult.OK)
            {
                SaveDocTypeEntry(documentTypeID);
            }
        }

        /// <summary>
        /// Show account when click repository button edit
        /// </summary>
        /// <param name="accountType">The account type</param>
        public void ShowAccount(string accountType)
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
            objDocTypeEntrysInfo = entity.ACDocTypeEntryList[entity.ACDocTypeEntryList.CurrentIndex];
            guiAccount guiAccount = new guiAccount();
            guiAccount.Module = this;
            SetAccountByAccountType(accountType, objDocTypeEntrysInfo);
            if (guiAccount.ShowDialog() == DialogResult.OK)
            {
                AddAccountsToDocTypeEntryList(accountType, objDocTypeEntrysInfo);
            }
        }

        /// <summary>
        /// Set account by account type
        /// </summary>
        /// <param name="accountType">The account type</param>
        /// <param name="objDocTypeEntrysInfo">The doc type entry object</param>
        public void SetAccountByAccountType(string accountType, ACDocTypeEntrysInfo objDocTypeEntrysInfo)
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            ACAccountsController objAccountsController = new ACAccountsController();
            //Clear all checked accounts
            entity.ACAccountList.SetValueToList("Selected", false);

            if (accountType.Equals(AccPostingType.Credit.ToString()) && objDocTypeEntrysInfo.ACDocTypeEntryAccountCredit != null)
            {
                string[] credits = objDocTypeEntrysInfo.ACDocTypeEntryAccountCredit.Split(',');

                foreach (string creditItem in credits)
                {
                    int accountID = objAccountsController.GetObjectIDByNo(creditItem.Trim());
                    foreach (ACAccountsInfo objAccountsInfo in entity.ACAccountList)
                    {
                        if (objAccountsInfo.ACAccountID == accountID)
                        {
                            objAccountsInfo.Selected = true;
                        }
                        SetAccountSelectedForSubList(objAccountsInfo, accountID);
                    }
                }
            }
            if (accountType.Equals(AccPostingType.Debit.ToString()) && objDocTypeEntrysInfo.ACDocTypeEntryAccountDebit != null)
            {
                string[] debits = objDocTypeEntrysInfo.ACDocTypeEntryAccountDebit.Split(',');

                foreach (string debitItem in debits)
                {
                    int accountID = objAccountsController.GetObjectIDByNo(debitItem.Trim());
                    foreach (ACAccountsInfo objAccountsInfo in entity.ACAccountList)
                    {
                        if (objAccountsInfo.ACAccountID == accountID)
                        {
                            objAccountsInfo.Selected = true;
                        }
                        SetAccountSelectedForSubList(objAccountsInfo, accountID);
                    }
                }
            }
        }

        /// <summary>
        /// Set account selected value for sublist of account object
        /// </summary>
        /// <param name="objAccountsInfo">The account object</param>
        /// <param name="accountID">The account id</param>
        public void SetAccountSelectedForSubList(ACAccountsInfo objAccountsInfo, int accountID)
        {
            if (objAccountsInfo.SubList != null)
            {
                if (objAccountsInfo.SubList.Count > 0)
                {
                    foreach (ACAccountsInfo objAccountsItemInfo in objAccountsInfo.SubList)
                    {
                        if (objAccountsItemInfo.ACAccountID == accountID)
                        {
                            objAccountsItemInfo.Selected = true;
                        }
                        SetAccountSelectedForSubList(objAccountsItemInfo, accountID);
                    }
                }
            }
        }

        /// <summary>
        /// Add accounts to doc type entry list 
        /// </summary>
        /// <param name="accountType">The account type</param>
        /// <param name="objDocTypeEntrysInfo">The doc type entry object</param>
        public void AddAccountsToDocTypeEntryList(string accountType, ACDocTypeEntrysInfo objDocTypeEntrysInfo)
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            if (accountType.Trim().Equals(AccPostingType.Credit.ToString()))
            {
                string credit = string.Empty;
                foreach (ACAccountsInfo objAccountsItemInfo in entity.ACAccountList)
                {
                    if (objAccountsItemInfo.Selected)
                    {
                        credit += string.Format("{0}, ", objAccountsItemInfo.ACAccountNo);
                    }
                    GetAccountSelectedForSubList(objAccountsItemInfo, ref credit);
                }
                if (!string.IsNullOrEmpty(credit))
                {
                    credit = credit.Remove(credit.Length - 2, 2);
                }
                objDocTypeEntrysInfo.ACDocTypeEntryAccountCredit = credit;
            }

            if (accountType.Trim().Equals(AccPostingType.Debit.ToString()))
            {
                string debit = string.Empty;
                foreach (ACAccountsInfo objAccountsItemInfo in entity.ACAccountList)
                {
                    if (objAccountsItemInfo.Selected)
                    {
                        debit += string.Format("{0}, ", objAccountsItemInfo.ACAccountNo);
                    }
                    GetAccountSelectedForSubList(objAccountsItemInfo, ref debit);
                }
                if (!string.IsNullOrEmpty(debit))
                {
                    debit = debit.Remove(debit.Length - 2, 2);
                }
                objDocTypeEntrysInfo.ACDocTypeEntryAccountDebit = debit;
            }
            entity.ACDocTypeEntryList.GridView.RefreshRow(entity.ACDocTypeEntryList.GridView.FocusedRowHandle);
        }

        /// <summary>
        /// Get account selected value for sublist of account.
        /// </summary>
        /// <param name="objAccountsInfo">The account object</param>
        /// <param name="result">The account no.</param>
        public void GetAccountSelectedForSubList(ACAccountsInfo objAccountsInfo, ref string result)
        {
            string accountNo = string.Empty;
            if (objAccountsInfo.SubList != null)
            {
                if (objAccountsInfo.SubList.Count > 0)
                {
                    foreach (ACAccountsInfo objAccountsItemInfo in objAccountsInfo.SubList)
                    {
                        if (objAccountsItemInfo.Selected)
                        {
                            accountNo = string.Format("{0}, ", objAccountsItemInfo.ACAccountNo);
                            result += accountNo;
                        }
                        GetAccountSelectedForSubList(objAccountsItemInfo, ref result);
                    }
                }
            }
        }

        /// <summary>
        /// Get doc type entry by document type id
        /// </summary>
        /// <param name="documentTypeID">The document type id</param>
        public void GetDocTypeEntrysByDocumentTypeID(int documentTypeID)
        {
            List<ACDocTypeEntrysInfo> docTypeEntrysList = new List<ACDocTypeEntrysInfo>();
            DataSet dsResult = new DataSet();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntryAccountsController objDocTypeEntryAccountsController = new ACDocTypeEntryAccountsController();
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            if (documentTypeID > 0)
            {
                DataSet dsDocTypeEntrys = objDocTypeEntrysController.GetAllDataByForeignColumn("FK_ACDocumentTypeID", documentTypeID);
                entity.ACDocTypeEntryList.Invalidate(dsDocTypeEntrys);

                foreach (ACDocTypeEntrysInfo objDocTypeEntrysInfoItem in entity.ACDocTypeEntryList)
                {

                    objDocTypeEntrysInfoItem.ACEntryTypeDesc = GetEntryTypeDescByEntryTypeID(objDocTypeEntrysInfoItem.FK_ACEntryTypeID);
                    docTypeEntrysList.Add(ConstructCurrentDocTypeEntrys(objDocTypeEntrysInfoItem));
                }
            }
            docTypeEntrysList = entity.ACDocTypeEntryList.OrderBy(d => d.ACDocTypeEntrySortOrder).ToList();
            entity.ACDocTypeEntryList.Invalidate(docTypeEntrysList);
            entity.UpdateModuleObjectsBindingSource();
        }

        /// <summary>
        /// Construct current doc type entry to update doc type entry
        /// </summary>
        /// <param name="objDocTypeEntrysInfo">Doc type entry object</param>
        /// <returns>Doc type entry object</returns>
        public ACDocTypeEntrysInfo ConstructCurrentDocTypeEntrys(ACDocTypeEntrysInfo objDocTypeEntrysInfo)
        {
            string credit = string.Empty;
            string debit = string.Empty;
            if (objDocTypeEntrysInfo != null)
            {
                ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
                ACDocTypeEntryAccountsInfo objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
                ACDocTypeEntryAccountsController objDocTypeEntryAccountsController = new ACDocTypeEntryAccountsController();
                DataSet dsDocTypeEntryAccount = objDocTypeEntryAccountsController.GetAllDataByForeignColumn("FK_ACDocTypeEntryID", objDocTypeEntrysInfo.ACDocTypeEntryID);
                foreach (DataRow dataRow in dsDocTypeEntryAccount.Tables[0].Rows)
                {
                    objDocTypeEntryAccountsInfo = (ACDocTypeEntryAccountsInfo)objDocTypeEntryAccountsController.GetObjectFromDataRow(dataRow);
                    if (objDocTypeEntryAccountsInfo.ACPostingType.Equals(AccPostingType.Credit.ToString()))
                    {
                        credit += string.Format("{0}, ", GetAccountNoByAccountID(Convert.ToInt32(objDocTypeEntryAccountsInfo.FK_ACAccountID)));
                        if (objDocTypeEntryAccountsInfo.IsDefault)
                        {
                            objDocTypeEntrysInfo.ACDocTypeEntryAccountDefaultCredit = objDocTypeEntryAccountsInfo.FK_ACAccountID;
                        }
                    }
                    if (objDocTypeEntryAccountsInfo.ACPostingType.Equals(AccPostingType.Debit.ToString()))
                    {
                        debit += string.Format("{0}, ", GetAccountNoByAccountID(Convert.ToInt32(objDocTypeEntryAccountsInfo.FK_ACAccountID)));
                        if (objDocTypeEntryAccountsInfo.IsDefault)
                        {
                            objDocTypeEntrysInfo.ACDocTypeEntryAccountDefaultDebit = objDocTypeEntryAccountsInfo.FK_ACAccountID;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(credit))
                {
                    credit = credit.Remove(credit.Length - 2, 2);
                }
                if (!string.IsNullOrEmpty(debit))
                {
                    debit = debit.Remove(debit.Length - 2, 2);
                }
                objDocTypeEntrysInfo.ACDocTypeEntryAccountCredit = credit;
                objDocTypeEntrysInfo.ACDocTypeEntryAccountDebit = debit;
            }
            return objDocTypeEntrysInfo;
        }

        /// <summary>
        /// Get account no by account id.
        /// </summary>
        /// <param name="accountID">The account id.</param>
        /// <returns>The account no.</returns>
        public string GetAccountNoByAccountID(int accountID)
        {
            string accountNo = string.Empty;
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            accountNo = objAccountsController.GetObjectNoByID(accountID);
            return accountNo;
        }

        /// <summary>
        /// Save doc type entry and doc type entry account.
        /// </summary>
        /// <param name="documentTypeID">The document type id</param>
        public void SaveDocTypeEntry(int documentTypeID)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
                    entity.SaveDocTypeEntry(documentTypeID);
                    scope.Complete();
                    MessageBox.Show(DocumentTypeLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }

        /// <summary>
        /// Checks the type of the exist entry.
        /// </summary>
        /// <param name="entryTypeID">The entry type id.</param>
        /// <returns>True if entry type id exist else false.</returns>
        public bool CheckExistEntryType(int entryTypeID)
        {
            bool isExist = false;
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            isExist = entity.ACDocTypeEntryList.Exists("FK_ACEntryTypeID", entryTypeID);
            return isExist;
        }

        /// <summary>
        /// Check exist doc type entry account default credit.
        /// </summary>
        /// <param name="defaultCreditValue">The default credit.</param>
        /// <param name="credit">The credit.</param>
        /// <returns>False if default credit exist in credit else true.</returns>
        public bool CheckExistDefaultCredit(int defaultCreditValue, string credit)
        {
            bool isExist = true;
            string defaultCredit = GetAccountNoByAccountID(defaultCreditValue);

            if (!string.IsNullOrEmpty(credit))
            {
                string[] creditArray = credit.Split(',');
                foreach (string creditItem in creditArray)
                {
                    if (creditItem.Trim() == defaultCredit.Trim())
                    {
                        isExist = false;
                    }
                }
            }
            return isExist;
        }

        /// <summary>
        /// Check exist doc type entry account default debit.
        /// </summary>
        /// <param name="defaultDebitValue">The default debit.</param>
        /// <param name="debit">The debit.</param>
        /// <returns>False if default debit exist in debit else true.</returns>
        public bool CheckExistDefaultDebit(int defaultDebitValue, string debit)
        {
            bool isExist = true;
            string defaultDebit = GetAccountNoByAccountID(defaultDebitValue);

            if (!string.IsNullOrEmpty(debit))
            {
                string[] debitArray = debit.Split(',');
                foreach (string debitItem in debitArray)
                {
                    if (debitItem.Trim() == defaultDebit.Trim())
                    {
                        isExist = false;
                    }
                }
            }
            return isExist;
        }

        /// <summary>
        /// Remove doc type entry list selected. 
        /// </summary>
        public void RemoveDocTypeEntryList()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            entity.ACDocTypeEntryList.RemoveSelectedRowObjectFromList();
        }

        /// <summary>
        /// Adjust the input account string and make it standard
        /// </summary>
        /// <param name="accountString">Input account string</param>
        /// <returns>Standard account string or empty in case the account string is invalid</returns>
        public string AdjustAccountString(string accountString)
        {
            if (!string.IsNullOrEmpty(accountString))
            {
                ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
                string[] accountList = accountString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                accountString = string.Empty;
                for (int i = 0; i < accountList.Length; i++)
                {
                    string accountNo = accountList[i].Trim();
                    if (!string.IsNullOrEmpty(accountNo))
                    {
                        if (!entity.ACAccountList.Exists("ACAccountNo", accountNo))
                        {
                            return string.Empty;
                        }
                        accountString += string.Format("{0}, ", accountNo);
                    }
                }
                if (!string.IsNullOrEmpty(accountString))
                {
                    accountString = accountString.Remove(accountString.Length - 2, 2);
                }
            }
            return accountString;
        }

        /// <summary>
        /// Create new entry type
        /// </summary>
        /// <param name="entryTypeLookupEdit">The entry type lookup edit</param>
        public void CreateNewEntryType(BOSLookupEdit entryTypeLookupEdit)
        {
            guiCreateEntryType guiCreateEntryType = new guiCreateEntryType();
            if (guiCreateEntryType.ShowDialog() == DialogResult.OK)
            {
                ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
                entity.CreateEntryType(guiCreateEntryType.EntryTypeObject);
                entryTypeLookupEdit.InvalidateDataSourceToLookupEdit();
                entryTypeLookupEdit.EditValue = guiCreateEntryType.EntryTypeObject.ACEntryTypeID;
            }
        }

        /// <summary>
        /// Add entry type to doc type entry list
        /// </summary>
        public void AddItemToDocTypeEntryList()
        {

            int entryTypeID = 0;
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
            objDocTypeEntrysInfo = (ACDocTypeEntrysInfo)entity.ModuleObjects[TableName.ACDocTypeEntrysTableName];
            entryTypeID = objDocTypeEntrysInfo.FK_ACEntryTypeID;

            entity.SetDefaultModuleObject(TableName.ACDocTypeEntrysTableName);
            entity.UpdateModuleObjectBindingSource(TableName.ACDocTypeEntrysTableName);

            objDocTypeEntrysInfo = (ACDocTypeEntrysInfo)entity.ModuleObjects[TableName.ACDocTypeEntrysTableName];
            objDocTypeEntrysInfo.FK_ACEntryTypeID = entryTypeID;
            if (objDocTypeEntrysInfo.FK_ACEntryTypeID > 0)
            {
                if (!entity.ACDocTypeEntryList.Exists("FK_ACEntryTypeID", objDocTypeEntrysInfo.FK_ACEntryTypeID))
                {
                    objDocTypeEntrysInfo.ACEntryTypeDesc = GetEntryTypeDescByEntryTypeID(objDocTypeEntrysInfo.FK_ACEntryTypeID);
                    objDocTypeEntrysInfo.FK_ACDocumentTypeID = DocumentTypeID;
                    entity.ACDocTypeEntryList.AddObjectToList();
                }
                else
                {
                    MessageBox.Show(DocumentTypeLocalizedResources.EntryTypeNameDuplicateMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Get entry type description by entry type id
        /// </summary>
        /// <param name="entryTypeID">The entry type id</param>
        /// <returns>The entry type description</returns>
        public string GetEntryTypeDescByEntryTypeID(int entryTypeID)
        {
            ACEntryTypesInfo objEntryTypesInfo = new ACEntryTypesInfo();
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            if (entryTypeID > 0)
            {
                objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByID(entryTypeID);
                return objEntryTypesInfo.ACEntryTypeDesc;
            }
            return null;
        }
        #endregion

        public void SaveACDocTypeEntryFunctionMappings()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            entity.ACDocTypeEntryFunctionMappingList.EndCurrentEdit();
            entity.ACDocTypeEntryFunctionMappingList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteItemFromDocTypeEntryFunctionMappings()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            if (entity.ACDocTypeEntryFunctionMappingList.CurrentIndex < 0)
                return;
            entity.ACDocTypeEntryFunctionMappingList.RemoveSelectedRowObjectFromList();
        }
        public void DeleteItemFromAccountTranferCost()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            if (entity.ACAccountTranferCostList.CurrentIndex < 0)
                return;
            entity.ACAccountTranferCostList.RemoveSelectedRowObjectFromList();
        }
        public void SaveSTModulePostingList()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            entity.STModulePostingList.EndCurrentEdit();
            entity.STModulePostingList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SaveAccountTranferCost()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            entity.ACAccountTranferCostList.EndCurrentEdit();
            entity.ACAccountTranferCostList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteItemFromModulePostingList()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)CurrentModuleEntity;
            if (entity.STModulePostingList.CurrentIndex < 0)
                return;
            entity.STModulePostingList.RemoveSelectedRowObjectFromList();
        }
        public void SetDefualtDocumentType(ACAccountTranferCostsInfo item)
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = objDocumentTypesController.GetDocumentTypeByDocumentTypeName("KetChuyenChiPhi");
            if (objDocumentTypesInfo != null && item.FK_ACDocumentTypeID == 0)
                item.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
        }
    }
}
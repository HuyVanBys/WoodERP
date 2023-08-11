using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Data;

namespace BOSERP.Modules.ACDocumentType
{
    public class ACDocumentTypeEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACDocumentTypesInfo> ACDocumentTypeList { get; set; }
        public BOSList<ACDocTypeEntrysInfo> ACDocTypeEntryList { get; set; }
        public BOSList<ACDocTypeEntryFunctionMappingsInfo> ACDocTypeEntryFunctionMappingList { get; set; }
        public BOSList<STModulePostingsInfo> STModulePostingList { get; set; }
        public BOSList<ACAccountTranferCostsInfo> ACAccountTranferCostList { get; set; }
        /// <summary>
        /// Get or set account list
        /// </summary>
        public BOSTreeList ACAccountList { get; set; }
        #endregion

        #region Constructor
        public ACDocumentTypeEntities()
            : base()
        {
            ACDocumentTypeList = new BOSList<ACDocumentTypesInfo>();
            ACDocTypeEntryList = new BOSList<ACDocTypeEntrysInfo>();
            ACDocTypeEntryFunctionMappingList = new BOSList<ACDocTypeEntryFunctionMappingsInfo>();
            STModulePostingList = new BOSList<STModulePostingsInfo>();
            ACAccountList = new BOSTreeList();
            ACAccountTranferCostList = new BOSList<ACAccountTranferCostsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACDocumentTypesTableName, new ACDocumentTypesInfo());
            ModuleObjects.Add(TableName.ACDocTypeEntrysTableName, new ACDocTypeEntrysInfo());
            ModuleObjects.Add(TableName.ACAccountsTableName, new ACAccountsInfo());
            ModuleObjects.Add(TableName.ACDocTypeEntryFunctionMappingsTableName, new ACDocTypeEntryFunctionMappingsInfo());
            ModuleObjects.Add("ACAccountTranferCosts", new ACAccountTranferCostsInfo());
        }

        public override void InitModuleObjectList()
        {
            ACDocumentTypeList.InitBOSList(
                                         this,
                                         string.Empty,
                                         TableName.ACDocumentTypesTableName,
                                         BOSList<ACDocumentTypesInfo>.cstRelationNone);
            ACDocTypeEntryList.InitBOSList(
                                       this,
                                       string.Empty,
                                       TableName.ACDocTypeEntrysTableName,
                                       BOSList<ACDocTypeEntrysInfo>.cstRelationNone);
            ACAccountList.InitBOSList(this,
                                   String.Empty,
                                   TableName.ACAccountsTableName,
                                   BOSTreeList.cstRelationNone);
            ACAccountsController objAccountsController = new ACAccountsController();
            DataSet dsAccount = objAccountsController.GetAllObjects();
            ACAccountList.Invalidate(dsAccount);
            ACDocTypeEntryFunctionMappingList.InitBOSList(this,
                                                        String.Empty,
                                                        TableName.ACDocTypeEntryFunctionMappingsTableName,
                                                        BOSList<ACDocTypeEntryFunctionMappingsInfo>.cstRelationNone);
            STModulePostingList.InitBOSList(this,
                                            String.Empty,
                                            TableName.STModulePostingsTableName,
                                            BOSList<STModulePostingsInfo>.cstRelationNone);
            ACAccountTranferCostList.InitBOSList(this,
                                           String.Empty,
                                           "ACAccountTranferCosts",
                                           BOSList<ACAccountTranferCostsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ACDocumentTypeList.InitBOSListGridControl();
            ACDocTypeEntryList.InitBOSListGridControl();
            ACAccountList.InitBOSTreeListControl();
            ACDocTypeEntryFunctionMappingList.InitBOSListGridControl();
            STModulePostingList.InitBOSListGridControl();
            ACAccountTranferCostList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACDocumentTypeList.SetDefaultListAndRefreshGridControl();
                ACDocTypeEntryList.SetDefaultListAndRefreshGridControl();
                ACAccountList.SetDefaultListAndRefreshTreeListControl();
                ACDocTypeEntryFunctionMappingList.SetDefaultListAndRefreshGridControl();
                STModulePostingList.SetDefaultListAndRefreshGridControl();
                ACAccountTranferCostList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACAccountList.InvalidateTreeList(iObjectID);
        }


        public override void Invalidate(int iObjectID)
        {

        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ACDocumentTypeList.SaveItemObjects();
        }

        /// <summary>
        /// Delete all doc type entry account by document type id.
        /// </summary>
        /// <param name="documentTypeID">The document type id.</param>
        public void DeleteDocTypeEntrysAccounts(int documentTypeID)
        {
            ACDocTypeEntryAccountsController objDocTypeEntryAccountsController = new ACDocTypeEntryAccountsController();
            objDocTypeEntryAccountsController.DeleteAllDataByDocumentTypeID(documentTypeID);
        }

        #endregion

        #region Save Doc type entry account

        /// <summary>
        /// Save doc type entry list.
        /// </summary>
        /// <param name="documentTypeID">The document type id.</param>
        public void SaveDocTypeEntry(int documentTypeID)
        {
            //Save entry types
            ACEntryTypesInfo objEntryTypesInfo = new ACEntryTypesInfo();
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            int sortOrder = 0;
            foreach (ACDocTypeEntrysInfo objDocTypeEntrysInfo in ACDocTypeEntryList)
            {
                sortOrder++;
                objDocTypeEntrysInfo.FK_ACDocumentTypeID = documentTypeID;
                objDocTypeEntrysInfo.ACDocTypeEntrySortOrder = sortOrder;
                objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByID(objDocTypeEntrysInfo.FK_ACEntryTypeID);
                objEntryTypesInfo.ACEntryTypeDesc = objDocTypeEntrysInfo.ACEntryTypeDesc;
                objEntryTypesInfo.AAUpdatedDate = DateTime.Now;
                objEntryTypesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objEntryTypesController.UpdateObject(objEntryTypesInfo);
            }
            ACDocTypeEntryList.SaveItemObjects();
            DeleteDocTypeEntrysAccounts(documentTypeID);
            // Save doc type entry account list
            foreach (ACDocTypeEntrysInfo objDocTypeEntrysInfo in ACDocTypeEntryList)
            {
                ACDocTypeEntryAccountsController objDocTypeEntryAccountsController = new ACDocTypeEntryAccountsController();
                ACDocTypeEntryAccountsInfo objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
                ACAccountsController objAccountsController = new ACAccountsController();
                string credit = string.Empty;
                string debit = string.Empty;

                if (!string.IsNullOrEmpty(objDocTypeEntrysInfo.ACDocTypeEntryAccountCredit))
                {
                    string[] creditArray = objDocTypeEntrysInfo.ACDocTypeEntryAccountCredit.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string creditItem in creditArray)
                    {
                        objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
                        objDocTypeEntryAccountsInfo.FK_ACDocTypeEntryID = objDocTypeEntrysInfo.ACDocTypeEntryID;

                        ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(creditItem.Trim().ToString());
                        objDocTypeEntryAccountsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
                        objDocTypeEntryAccountsInfo.ACPostingType = AccPostingType.Credit.ToString();
                        objDocTypeEntryAccountsInfo.IsDefault = (objAccountsInfo.ACAccountID.Equals(objDocTypeEntrysInfo.ACDocTypeEntryAccountDefaultCredit))
                                                                                        ? true : false;
                        objDocTypeEntryAccountsController.CreateObject(objDocTypeEntryAccountsInfo);
                    }
                }
                else
                {
                    objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
                    objDocTypeEntryAccountsInfo.FK_ACDocTypeEntryID = objDocTypeEntrysInfo.ACDocTypeEntryID;
                    objDocTypeEntryAccountsInfo.FK_ACAccountID = 0;
                    objDocTypeEntryAccountsInfo.ACPostingType = AccPostingType.Credit.ToString();
                    objDocTypeEntryAccountsInfo.IsDefault = false;
                    objDocTypeEntryAccountsController.CreateObject(objDocTypeEntryAccountsInfo);
                }

                if (!string.IsNullOrEmpty(objDocTypeEntrysInfo.ACDocTypeEntryAccountDebit))
                {
                    string[] debitArray = objDocTypeEntrysInfo.ACDocTypeEntryAccountDebit.Split(',');
                    foreach (string debitItem in debitArray)
                    {
                        objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
                        objDocTypeEntryAccountsInfo.FK_ACDocTypeEntryID = objDocTypeEntrysInfo.ACDocTypeEntryID;
                        ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(debitItem.Trim().ToString());

                        objDocTypeEntryAccountsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
                        objDocTypeEntryAccountsInfo.ACPostingType = AccPostingType.Debit.ToString();
                        objDocTypeEntryAccountsInfo.IsDefault = (objAccountsInfo.ACAccountID.Equals(objDocTypeEntrysInfo.ACDocTypeEntryAccountDefaultDebit))
                                                                                        ? true : false;
                        objDocTypeEntryAccountsController.CreateObject(objDocTypeEntryAccountsInfo);
                    }
                }
                else
                {
                    objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
                    objDocTypeEntryAccountsInfo.FK_ACDocTypeEntryID = objDocTypeEntrysInfo.ACDocTypeEntryID;
                    objDocTypeEntryAccountsInfo.FK_ACAccountID = 0;
                    objDocTypeEntryAccountsInfo.ACPostingType = AccPostingType.Debit.ToString();
                    objDocTypeEntryAccountsInfo.IsDefault = false;
                    objDocTypeEntryAccountsController.CreateObject(objDocTypeEntryAccountsInfo);
                }
            }
        }
        #endregion

        /// <summary>
        /// Create an entry type 
        /// </summary>
        /// <param name="objEntryTypesInfo">Entry type object needs to be created</param>
        public void CreateEntryType(ACEntryTypesInfo objEntryTypesInfo)
        {
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            objEntryTypesInfo.AACreatedDate = DateTime.Now;
            objEntryTypesInfo.AACreatedUser = BOSApp.CurrentUser;
            objEntryTypesController.CreateObject(objEntryTypesInfo);
        }

        /// <summary>
        /// Update a document type
        /// </summary>
        /// <param name="objDocumentTypeInfo">Document type object needs to be updated</param>
        public void UpdateDocumentType(ACDocumentTypesInfo objDocumentTypeInfo)
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            objDocumentTypesController.UpdateObject(objDocumentTypeInfo);
        }
    }
}

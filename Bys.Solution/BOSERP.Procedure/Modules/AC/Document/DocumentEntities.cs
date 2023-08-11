using BOSCommon.Constants;
using System;
using System.Linq;

namespace BOSERP.Modules.Document
{
    public class DocumentEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public DocumentEntities()
            : base()
        {

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

        }

        public override void InitModuleObjectList()
        {
            DocumentEntryList.InitBOSList(
                                                    this,
                                                    TableName.ACDocumentsTableName,
                                                    TableName.ACDocumentEntrysTableName,
                                                    BOSList<ACDocumentEntrysInfo>.cstRelationForeign);
            DocumentEntryList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            DocumentEntryList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.FK_ACDocumentTypeID = DefaultDocumentTypeID;
            objDocumentsInfo.ACDocumentDate = DateTime.Now;
            objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
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

        }
        #endregion

        #region Save Module Objects and Main Object functions        
        public override int SaveMainObject()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentTotalAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryAmount);
            objDocumentsInfo.ACDocumentExchangeAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryExchangeAmount);

            BOSApp.RoundByCurrency(objDocumentsInfo, "ACDocumentTotalAmount", objDocumentsInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(objDocumentsInfo, "ACDocumentExchangeAmount", objDocumentsInfo.FK_GECurrencyID);
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            SaveDocumentEntrys((ACDocumentsInfo)MainObject);
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
    }
}

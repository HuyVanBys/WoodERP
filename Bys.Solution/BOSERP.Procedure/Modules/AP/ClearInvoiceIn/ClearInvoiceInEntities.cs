using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.ClearInvoiceIn
{
    public class ClearInvoiceInEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets bank transaction item list
        /// </summary>
        public BOSList<APClearInvoiceInDocumentsInfo> DocumentList { get; set; }

        public BOSList<APClearInvoiceInInvoiceInsInfo> InvoiceInItemList { get; set; }

        #endregion

        #region Constructor
        public ClearInvoiceInEntities()
            : base()
        {
            DocumentList = new BOSList<APClearInvoiceInDocumentsInfo>();
            InvoiceInItemList = new BOSList<APClearInvoiceInInvoiceInsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APClearInvoiceInsInfo();
            SearchObject = new APClearInvoiceInsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APClearInvoiceInDocumentsTableName, new APClearInvoiceInDocumentsInfo());
            ModuleObjects.Add(TableName.APClearInvoiceInInvoiceInsTableName, new APClearInvoiceInInvoiceInsInfo());
        }

        public override void InitModuleObjectList()
        {
            DocumentList.InitBOSList(
                                    this,
                                    TableName.APClearInvoiceInsTableName,
                                    TableName.APClearInvoiceInDocumentsTableName,
                                    BOSList<APClearInvoiceInDocumentsInfo>.cstRelationForeign);
            DocumentList.ItemTableForeignKey = "FK_APClearInvoiceInID";
            InvoiceInItemList.InitBOSList(
                                        this,
                                        TableName.APClearInvoiceInsTableName,
                                        TableName.APClearInvoiceInInvoiceInsTableName,
                                        BOSList<APClearInvoiceInInvoiceInsInfo>.cstRelationForeign);
            InvoiceInItemList.ItemTableForeignKey = "FK_APClearInvoiceInID";
        }

        public override void InitGridControlInBOSList()
        {
            DocumentList.InitBOSListGridControl();
            InvoiceInItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APClearInvoiceInsInfo objClearingDebtsInfo = (APClearInvoiceInsInfo)MainObject;
            objClearingDebtsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objClearingDebtsInfo.APClearInvoiceInExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objClearingDebtsInfo.APClearInvoiceInDate = DateTime.Now;
            objClearingDebtsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DocumentList.SetDefaultListAndRefreshGridControl();
                InvoiceInItemList.SetDefaultListAndRefreshGridControl();
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
            DocumentList.Invalidate(iObjectID);
            InvoiceInItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)MainObject;
            int id = base.SaveMainObject();
            return id;
        }

        public override void SaveModuleObjects()
        {
            DocumentList.SaveItemObjects();
            InvoiceInItemList.SaveItemObjects();
        }

        #endregion

        #region Complete
        public override bool CompleteTransaction()
        {
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)MainObject;
            mainObject.APClearInvoiceInStatus = PurchaseOrderStatus.Completed.ToString();
            UpdateMainObject();
            return true;
        }
        #endregion

        #region CancelComplete
        public override bool CancelCompleteTransaction()
        {
            APClearInvoiceInsInfo mainObject = (APClearInvoiceInsInfo)MainObject;
            if (mainObject.APClearInvoiceInStatus == PurchaseOrderStatus.Completed.ToString())
            {
                mainObject.APClearInvoiceInStatus = PurchaseOrderStatus.New.ToString();
                SaveMainObject();
            }
            return true;
        }
        #endregion
    }
}

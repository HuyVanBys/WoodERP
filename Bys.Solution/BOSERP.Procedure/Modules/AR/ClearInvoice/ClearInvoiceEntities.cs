using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.ClearInvoice
{
    public class ClearInvoiceEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets bank transaction item list
        /// </summary>
        public BOSList<ARClearInvoiceDocumentsInfo> DocumentList { get; set; }

        public BOSList<ARClearInvoiceInvoicesInfo> InvoiceItemList { get; set; }

        #endregion

        #region Constructor
        public ClearInvoiceEntities()
            : base()
        {
            DocumentList = new BOSList<ARClearInvoiceDocumentsInfo>();
            InvoiceItemList = new BOSList<ARClearInvoiceInvoicesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARClearInvoicesInfo();
            SearchObject = new ARClearInvoicesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARClearInvoiceDocumentsTableName, new ARClearInvoiceDocumentsInfo());
            ModuleObjects.Add(TableName.ARClearInvoiceInvoicesTableName, new ARClearInvoiceInvoicesInfo());
        }

        public override void InitModuleObjectList()
        {
            DocumentList.InitBOSList(
                                    this,
                                    TableName.ARClearInvoicesTableName,
                                    TableName.ARClearInvoiceDocumentsTableName,
                                    BOSList<ARClearInvoiceDocumentsInfo>.cstRelationForeign);
            DocumentList.ItemTableForeignKey = "FK_ARClearInvoiceID";
            InvoiceItemList.InitBOSList(
                                        this,
                                        TableName.ARClearInvoicesTableName,
                                        TableName.ARClearInvoiceInvoicesTableName,
                                        BOSList<ARClearInvoiceInvoicesInfo>.cstRelationForeign);
            InvoiceItemList.ItemTableForeignKey = "FK_ARClearInvoiceID";
        }

        public override void InitGridControlInBOSList()
        {
            DocumentList.InitBOSListGridControl();
            InvoiceItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARClearInvoicesInfo objClearInvoicesInfo = (ARClearInvoicesInfo)MainObject;
            objClearInvoicesInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objClearInvoicesInfo.ARClearInvoiceExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objClearInvoicesInfo.ARClearInvoiceDate = DateTime.Now;
            objClearInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DocumentList.SetDefaultListAndRefreshGridControl();
                InvoiceItemList.SetDefaultListAndRefreshGridControl();
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

            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)MainObject;
            if (mainObject.ARClearInvoiceStatus == PurchaseOrderStatus.Completed.ToString())
            {
                ARClearInvoiceInvoicesController objClearInvoiceInvoicesController = new ARClearInvoiceInvoicesController();
                List<ARClearInvoiceInvoicesInfo> listClearInvoiceInvoicesInfo = objClearInvoiceInvoicesController.GetListClearInvoiceInvoicesByClearInvoiceID(iObjectID);
                listClearInvoiceInvoicesInfo.ForEach(p => p.ARClearInvoiceInvoiceRemainAmount = p.ARClearInvoiceInvoiceAmount - p.ARClearInvoiceInvoicePaintAmount - p.ARClearInvoiceInvoiceWaitingPayment);
                InvoiceItemList.Invalidate(listClearInvoiceInvoicesInfo);
            }
            else
            {
                InvoiceItemList.Invalidate(iObjectID);
            }
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)MainObject;
            int id = base.SaveMainObject();
            return id;
        }

        public override void SaveModuleObjects()
        {
            DocumentList.SaveItemObjects();
            ARClearInvoiceInvoicesController objClearInvoiceInvoicesController = new ARClearInvoiceInvoicesController();
            for (int i = 0; i < InvoiceItemList.Count; i++)
            {
                if (InvoiceItemList[i].ARClearInvoiceInvoiceAllocationAmount <= 0)
                {
                    if (InvoiceItemList[i].ARClearInvoiceInvoiceID > 0)
                    {
                        objClearInvoiceInvoicesController.DeleteObject(InvoiceItemList[i].ARClearInvoiceInvoiceID);
                    }
                    InvoiceItemList.RemoveAt(i);
                    i--;
                }
            }
            InvoiceItemList.SaveItemObjects();
        }

        #endregion

        #region Complete
        public override bool CompleteTransaction()
        {
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)MainObject;
            mainObject.ARClearInvoiceStatus = SaleOrderStatus.Complete.ToString();
            UpdateMainObject();
            return true;
        }
        #endregion

        #region CancelComplete
        public override bool CancelCompleteTransaction()
        {
            ARClearInvoicesInfo mainObject = (ARClearInvoicesInfo)MainObject;
            if (mainObject.ARClearInvoiceStatus == SaleOrderStatus.Complete.ToString())
            {
                mainObject.ARClearInvoiceStatus = SaleOrderStatus.New.ToString();
                SaveMainObject();
            }
            return true;
        }
        #endregion

    }
}

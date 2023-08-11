using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP
{
    public class BaseTransactionEntities : ERPModuleEntities
    {
        #region Properties
        /// <summary>
        /// Gets or sets the transaction type
        /// </summary>
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// Gets or sets the document list, includes the current document and all its
        /// relative ones
        /// </summary>
        public List<ACDocumentsInfo> DocumentList { get; set; }

        /// <summary>
        /// Gets or sets all entries of all documents relating to the transaction
        /// </summary>
        public BOSList<ACDocumentEntrysInfo> DocumentEntryList { get; set; }

        /// <summary>
        /// Gets or sets the default document type id that associates with the transaction
        /// </summary>
        public int DefaultDocumentTypeID { get; set; }

        /// <summary>
        /// Gets or sets the type id of the current document
        /// </summary>
        public int DocumentTypeID { get; set; }
        #endregion

        public BaseTransactionEntities()
        {
            DocumentList = new List<ACDocumentsInfo>();
            DocumentEntryList = new BOSList<ACDocumentEntrysInfo>(this, string.Empty, TableName.ACDocumentEntrysTableName);

            ModuleObjects.Add(TableName.ACDocumentEntrysTableName, new ACDocumentEntrysInfo());
        }

        /// <summary>
        /// Call base.SetDefaultValuesFromCustomer() and set additional info from the customer
        /// </summary>
        /// <param name="objCustomersInfo">Given customer</param>
        public override void SetDefaultValuesFromCustomer(ARCustomersInfo objCustomersInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            //int priceLevelID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ARPriceLevelID"));
            //if (objCustomersInfo.FK_ARPriceLevelID != priceLevelID)
            //{
            //    if (MessageBox.Show(CommonLocalizedResources.ConfirmPriceLevelMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        UpdatePriceLevel(objCustomersInfo);
            //    }
            //}

            base.SetDefaultValuesFromCustomer(objCustomersInfo);

            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            dbUtil.SetPropertyValue(MainObject, String.Format("{0}InvoiceAddressLine3", mainTablePrefix), BOSUtil.GenerateFullAddress(objCustomersInfo, AddressType.Invoice.ToString()));
            dbUtil.SetPropertyValue(MainObject, String.Format("{0}DeliveryAddressLine3", mainTablePrefix), BOSUtil.GenerateFullAddress(objCustomersInfo, AddressType.Delivery.ToString()));
            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentAddressLine3", mainTablePrefix), BOSUtil.GenerateFullAddress(objCustomersInfo, AddressType.Payment.ToString()));
        }

        /// <summary>
        /// Update transaction's price level from the customer, will be overriden in a specific module        
        /// </summary>
        /// <param name="objCustomersInfo">Given customer</param>
        public virtual void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {

        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo != null)
            {
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
                if (objMainObjectController != null)
                {
                    DateTime currentDate = BOSApp.GetCurrentServerDate();
                    if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                    {
                        objGENumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
                    }

                    strMainObjectNo = GenarateObjectNo(objGENumberingInfo);
                    numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = GenarateObjectNo(objGENumberingInfo);
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            return strMainObjectNo;
        }

        protected string GenarateObjectNo(GENumberingInfo objGENumberingInfo)
        {
            string strMainObjectNo = objGENumberingInfo.GENumberingFormat;
            DateTime currentDate = BOSApp.GetCurrentServerDate();
            BOSDbUtil dbUtil = new BOSDbUtil();

            if ((objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year && objGENumberingInfo.GENumberingPrefixHaveYear)
                        || (objGENumberingInfo.AAUpdatedDate.Month < currentDate.Month && objGENumberingInfo.GENumberingPrefixHaveMonth)
                        || (objGENumberingInfo.AAUpdatedDate.Day < currentDate.Day && objGENumberingInfo.GENumberingPrefixHaveDay))
            {
                objGENumberingInfo.GENumberingStart = 1;
            }

            strMainObjectNo = strMainObjectNo.Replace("{1}", objGENumberingInfo.GENumberingPrefix);
            if (objGENumberingInfo.GENumberingPrefixHaveYear)
            {
                strMainObjectNo = strMainObjectNo.Replace("{2}", currentDate.Year.ToString().Substring(2, 2));
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{2}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveMonth)
            {
                strMainObjectNo = strMainObjectNo.Replace("{3}", currentDate.Month.ToString().PadLeft(2, '0'));
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{3}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveDay)
            {
                strMainObjectNo = strMainObjectNo.Replace("{4}", currentDate.Day.ToString().PadLeft(2, '0'));
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{4}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveStock)
            {
                int stockID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ICStockID"));
                ICStocksInfo objStocksInfo = (ICStocksInfo)(new ICStocksController()).GetObjectByID(stockID);
                strMainObjectNo = strMainObjectNo.Replace("{5}", objStocksInfo != null ? objStocksInfo.ICStockPrefix : string.Empty);
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{5}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveBankAbbreviation)
            {
                int companyBankID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_CSCompanyBankID"));
                CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)(new CSCompanyBanksController()).GetObjectByID(companyBankID);
                strMainObjectNo = strMainObjectNo.Replace("{6}", objCompanyBanksInfo != null ? objCompanyBanksInfo.CSCompanyBankAbbreviation : string.Empty);
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{6}", string.Empty);
            }

            objGENumberingInfo.GENumberingFormat = strMainObjectNo;
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
            if (objMainObjectController != null)
            {
                strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                int numberingStart = objGENumberingInfo.GENumberingStart;
                while (objMainObjectController.IsExist(strMainObjectNo))
                {
                    objGENumberingInfo.GENumberingStart++;
                    strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                }
            }
            return strMainObjectNo;
        }

        public virtual string GetMainObjectNo(ref int numberingStart, ICStocksInfo objStocksInfo)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo == null)
                return strMainObjectNo;

            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
            if (objMainObjectController == null)
                return strMainObjectNo;

            GEStockNumberingsController objStockNumberingsController = new GEStockNumberingsController();
            GEStockNumberingsInfo objGEStockNumberingsInfo = objStockNumberingsController.GetGEStockNumberingByModuleNameAndStockID(Module.Name, objStocksInfo.ICStockID);
            if (objGEStockNumberingsInfo == null)
            {
                objGEStockNumberingsInfo = new GEStockNumberingsInfo
                {
                    GEStockNumberingModuleName = Module.Name,
                    FK_ICStockID = objStocksInfo.ICStockID,
                    GEStockNumberingStart = 1,
                    AACreatedDate = BOSApp.GetCurrentServerDate(),
                };
                objStockNumberingsController.CreateObject(objGEStockNumberingsInfo);
            }

            BOSDbUtil dbUtil = new BOSDbUtil();
            DateTime currentDate = BOSApp.GetCurrentServerDate();
            if (objGEStockNumberingsInfo.AAUpdatedDate.Year < currentDate.Year)
                objGEStockNumberingsInfo.GEStockNumberingStart = 1;

            strMainObjectNo = String.Format("{0}{1}-{2}.{3}",
                                            objGENumberingInfo.GENumberingPrefix,
                                            objStocksInfo.ICStockPrefix,
                                            currentDate.Year.ToString().Substring(2, 2),
                                            objGEStockNumberingsInfo.GEStockNumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
            numberingStart = objGEStockNumberingsInfo.GEStockNumberingStart;
            strMainObjectNo = strMainObjectNo.Replace("--", "-");
            while (objMainObjectController.IsExist(strMainObjectNo))
            {
                objGEStockNumberingsInfo.GEStockNumberingStart++;
                strMainObjectNo = String.Format("{0}{1}-{2}.{3}",
                                           objGENumberingInfo.GENumberingPrefix,
                                           objStocksInfo.ICStockPrefix,
                                           currentDate.Year.ToString().Substring(2, 2),
                                           objGEStockNumberingsInfo.GEStockNumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                strMainObjectNo = strMainObjectNo.Replace("--", "-");
                numberingStart = objGEStockNumberingsInfo.GEStockNumberingStart;
            }
            return strMainObjectNo;
        }

        #region Accounting
        /// <summary>
        /// Save accounting data, includes documents, entries relating to
        /// the current transaction
        /// </summary>
        /// <returns>True if save successfully, otherwise false</returns>
        public virtual bool SaveAccountingData()
        {
            SaveDocuments();

            SaveDocumentRelationship();

            SaveDocumentEntrys();

            return true;
        }

        /// <summary>
        /// Save all documents relating to the transaction
        /// </summary>
        public virtual void SaveDocuments()
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (ACDocumentsInfo document in DocumentList)
            {
                List<ACDocumentEntrysInfo> entries = DocumentEntryList.Where(e => e.FK_ACDocumentTypeID == document.FK_ACDocumentTypeID &&
                                                                            (string.IsNullOrEmpty(e.ACDocumentNo) || e.ACDocumentNo == document.ACDocumentNo)).ToList();
                if (entries.Count > 0)
                {
                    document.ACDocumentTotalAmount = entries.Sum(e => e.ACDocumentEntryAmount);
                    document.ACDocumentExchangeAmount = entries.Sum(e => e.ACDocumentEntryExchangeAmount);
                }
                ACDocumentsInfo existingDocument = objDocumentsController.GetDocumentByDocumentTypeIDAndDocumentNo(document.FK_ACDocumentTypeID, document.ACDocumentNo);
                if (existingDocument == null)
                {
                    document.ACDocumentPostingDate = document.ACDocumentDate;
                    document.IsPosted = true;
                    document.AACreatedDate = BOSApp.GetCurrentServerDate();
                    objDocumentsController.CreateObject(document);
                }
                else
                {
                    document.ACDocumentID = existingDocument.ACDocumentID;
                    document.AAUpdatedDate = BOSApp.GetCurrentServerDate();
                    objDocumentsController.UpdateObject(document);
                }
            }
        }

        /// <summary>
        /// Save the relationship between documents
        /// </summary>
        public virtual void SaveDocumentRelationship()
        {
            if (DocumentList.Count > 0)
            {
                ACRelativeDocumentsController objRelativeDocumentsController = new ACRelativeDocumentsController();
                int documentID = DocumentList[0].ACDocumentID;
                objRelativeDocumentsController.DeleteByForeignColumn("FK_ACDocumentID", documentID);
                for (int i = 1; i < DocumentList.Count; i++)
                {
                    ACRelativeDocumentsInfo existingRelativeDocument = objRelativeDocumentsController.GetObjectByDocumentIDAndRelativeDocumentID(documentID, DocumentList[i].ACDocumentID);
                    if (existingRelativeDocument == null)
                    {
                        ACRelativeDocumentsInfo relativeDocument = new ACRelativeDocumentsInfo();
                        relativeDocument.FK_ACDocumentID = documentID;
                        relativeDocument.FK_ACRelativeDocumentID = DocumentList[i].ACDocumentID;
                        objRelativeDocumentsController.CreateObject(relativeDocument);
                    }
                }
            }
        }

        /// <summary>
        /// Save entries of all documents
        /// </summary>
        public virtual void SaveDocumentEntrys()
        {
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                ACDocumentsInfo objDocumentsInfo = DocumentList.Where(d => d.FK_ACDocumentTypeID == entry.FK_ACDocumentTypeID &&
                                                                    (string.IsNullOrEmpty(entry.ACDocumentNo) || entry.ACDocumentNo == d.ACDocumentNo)).FirstOrDefault();
                if (objDocumentsInfo != null)
                {
                    entry.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                    entry.FK_ACObjectID = objDocumentsInfo.FK_ACObjectID;
                    entry.FK_ACAssObjectID = objDocumentsInfo.FK_ACAssObjectID;
                    entry.ACObjectType = objDocumentsInfo.ACObjectType;
                    entry.ACAssObjectType = objDocumentsInfo.ACAssObjectType;
                }
            }
            DocumentEntryList.SaveItemObjects();
        }

        /// <summary>
        /// Save entries of a document
        /// </summary>
        /// <param name="objDocumentsInfo">Given document</param>
        public virtual void SaveDocumentEntrys(ACDocumentsInfo objDocumentsInfo)
        {
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                entry.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                if (entry.FK_ACObjectID == 0)
                    entry.FK_ACObjectID = objDocumentsInfo.FK_ACObjectID;
                entry.FK_ACAssObjectID = objDocumentsInfo.FK_ACAssObjectID;
                if (entry.ACObjectType == string.Empty)
                    entry.ACObjectType = objDocumentsInfo.ACObjectType;
                entry.ACAssObjectType = objDocumentsInfo.ACAssObjectType;
            }
            DocumentEntryList.SaveItemObjects();
        }
        #endregion

        public int GetAccountByStock(int stockID, int currentAccount)
        {
            return currentAccount;
            int account = 0;
            ICStocksInfo objStocksInfo = new ICStocksInfo();
            ICStocksController objStocksController = new ICStocksController();
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(stockID);
            if (objStocksInfo != null)
            {
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoVanNhanTao)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15224);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoSon)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1526);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.HW)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1527);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.PLDG)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1528);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.CCDCBT)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1531);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.CCDCDL)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1532);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.CCDCSX)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1534);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.VPP || objStocksInfo.ICStockNo == StockNoHardCode.MMTBVP)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1535);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.MMTB || objStocksInfo.ICStockNo == StockNoHardCode.MMTBCD || objStocksInfo.ICStockNo == StockNoHardCode.MMTBCT)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1536);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoPhoiXuong1 || objStocksInfo.ICStockNo == StockNoHardCode.KhoPhoiXuong2)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1551);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoSoCheXuong1 || objStocksInfo.ICStockNo == StockNoHardCode.KhoSoCheXuong2)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1552);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoTinhCheXuong1 || objStocksInfo.ICStockNo == StockNoHardCode.KhoTinhCheXuong2)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1553);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoLapRapXuong1 || objStocksInfo.ICStockNo == StockNoHardCode.KhoLapRapXuong2)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1554);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoHoanThienSon)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1555);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoDongGoi)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1556);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoGoTron)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc1521);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoLoSay)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15222);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoVanKho || objStocksInfo.ICStockNo == StockNoHardCode.KhoVanKhoKemChatLuong ||
                    objStocksInfo.ICStockNo == StockNoHardCode.KhoChiTietTanDungDaTaiChe || objStocksInfo.ICStockNo == StockNoHardCode.KhoGoBiaTanDung ||
                    objStocksInfo.ICStockNo == StockNoHardCode.KhoKienGoTanDungKhongXacDinhQuyCach)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15223);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }
                if (objStocksInfo.ICStockNo == StockNoHardCode.KhoVanTuoi)
                {
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15221);
                    if (objAccountsInfo != null)
                    {
                        account = objAccountsInfo.ACAccountID;
                    }
                }

            }
            if (account > 0)
                return account;
            else
                return currentAccount;

        }

    }
}

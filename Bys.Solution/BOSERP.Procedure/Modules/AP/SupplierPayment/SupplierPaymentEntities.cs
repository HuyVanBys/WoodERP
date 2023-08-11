using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.SupplierPayment
{
    public class SupplierPaymentEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or set the invoicein list of the supplier payment 
        /// in case the payment type is supplier payment
        /// </summary>
        public BOSList<APInvoiceInsInfo> APInvoiceInList { get; set; }

        /// <summary>
        /// Gets or sets the owing invoice list
        /// </summary>
        public BOSList<APInvoiceInsInfo> OwingInvoiceInList { get; set; }

        /// <summary>
        /// Gets or sets the payment details of the supplier payment
        /// </summary>
        public BOSList<APSupplierPaymentDetailsInfo> PaymentDetailList { get; set; }
        public BOSList<APPaymentProposalPaymentsInfo> PaymentProposalList { get; set; }

        public BOSList<APSupplierPaymentDocumentsInfo> SupplierPaymentDocumentList { get; set; }
        #endregion

        #region Constructor
        public SupplierPaymentEntities()
            : base()
        {
            APInvoiceInList = new BOSList<APInvoiceInsInfo>();
            OwingInvoiceInList = new BOSList<APInvoiceInsInfo>();
            PaymentDetailList = new BOSList<APSupplierPaymentDetailsInfo>();
            PaymentProposalList = new BOSList<APPaymentProposalPaymentsInfo>();
            SupplierPaymentDocumentList = new BOSList<APSupplierPaymentDocumentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APSupplierPaymentsInfo();
            SearchObject = new APSupplierPaymentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APInvoiceInsTableName, new APInvoiceInsInfo());
            ModuleObjects.Add(TableName.APSupplierPaymentDetailsTableName, new APSupplierPaymentDetailsInfo());
            ModuleObjects.Add(TableName.APPaymentProposalPaymentTableName, new APPaymentProposalPaymentsInfo());
            ModuleObjects.Add(TableName.APSupplierPaymentDocumentsTableName, new APSupplierPaymentDocumentsInfo());
        }

        public override void InitModuleObjectList()
        {
            APInvoiceInList.InitBOSList(
                                          this,
                                          string.Empty,
                                          TableName.APInvoiceInsTableName,
                                          BOSList<APInvoiceInsInfo>.cstRelationNone);
            OwingInvoiceInList.InitBOSList(
                                          this,
                                          string.Empty,
                                          TableName.APInvoiceInsTableName,
                                          BOSList<APInvoiceInsInfo>.cstRelationNone);
            PaymentDetailList.InitBOSList(
                                        this,
                                        TableName.APSupplierPaymentsTableName,
                                        TableName.APSupplierPaymentDetailsTableName,
                                        BOSList<APSupplierPaymentDetailsInfo>.cstRelationForeign);
            PaymentDetailList.ItemTableForeignKey = "FK_APSupplierPaymentID";

            PaymentProposalList.InitBOSList(
                                        this,
                                        TableName.APSupplierPaymentsTableName,
                                        TableName.APPaymentProposalPaymentTableName,
                                        BOSList<APPaymentProposalPaymentsInfo>.cstRelationForeign);
            PaymentProposalList.ItemTableForeignKey = "FK_APSupplierPaymentID";

            SupplierPaymentDocumentList.InitBOSList(
                                        this,
                                        TableName.APSupplierPaymentsTableName,
                                        TableName.APSupplierPaymentDocumentsTableName,
                                        BOSList<APSupplierPaymentDocumentsInfo>.cstRelationForeign);
            SupplierPaymentDocumentList.ItemTableForeignKey = "FK_APSupplierPaymentID";
        }

        public override void InitGridControlInBOSList()
        {
            APInvoiceInList.InitBOSListGridControl();
            OwingInvoiceInList.InitBOSListGridControl();
            PaymentDetailList.InitBOSListGridControl(SupplierPaymentModule.SupplierPaymentDetailsGridControlName);
            DocumentEntryList.InitBOSListGridControl(SupplierPaymentModule.DocumentEntryGridControlName);
            PaymentProposalList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)MainObject;
            objSupplierPaymentsInfo.APSupplierPaymentDate = DateTime.Now;
            objSupplierPaymentsInfo.APSupplierPaymentType = SupplierPaymentType.SupplierPayment.ToString();
            objSupplierPaymentsInfo.APPaymentMethodCombo = PaymentMethod.Cash.ToString();
            objSupplierPaymentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            objSupplierPaymentsInfo.APSupplierPaymentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objSupplierPaymentsInfo.APSupplierPaymentAssPostingExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objSupplierPaymentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSupplierPaymentsInfo.APSupplierPaymentStatus = SupplierPaymentStatus.New.ToString();
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            List<CSCashFundsInfo> lstCSCashFundsInfo = objCSCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (lstCSCashFundsInfo != null && lstCSCashFundsInfo.Any(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())))
            {
                objSupplierPaymentsInfo.FK_CSCashFundID = lstCSCashFundsInfo.Where(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())).FirstOrDefault().CSCashFundID;
            }
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                APInvoiceInList.SetDefaultListAndRefreshGridControl();
                OwingInvoiceInList.SetDefaultListAndRefreshGridControl();
                PaymentProposalList.SetDefaultListAndRefreshGridControl();
                List<APSupplierPaymentDetailsInfo> paymentDetails = GetDefaultPaymentMethods();
                PaymentDetailList.Invalidate(paymentDetails);
                SupplierPaymentDocumentList.SetDefaultListAndRefreshGridControl();
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
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)MainObject;
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            APInvoiceInsInfo objInvoiceInsInfo = new APInvoiceInsInfo();

            DataSet ds = objInvoiceInsController.GetInvoicesBySupplierPaymentID(iObjectID);
            APInvoiceInList.Invalidate(ds);

            APSupplierPaymentDetailsController objSupplierPaymentDetailsController = new APSupplierPaymentDetailsController();
            DataSet ds1 = objSupplierPaymentDetailsController.GetAllDataByForeignColumn("FK_APSupplierPaymentID", objSupplierPaymentsInfo.APSupplierPaymentID);
            PaymentDetailList.Invalidate(ds1);

            PaymentProposalList.Invalidate((new APPaymentProposalPaymentsController()).GetBySupplierPaymentID(iObjectID));
            SupplierPaymentDocumentList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions
        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = string.Empty;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)MainObject;
            if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.PaymentVoucher, objSupplierPaymentsInfo);
                APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
                while (objPaymentVouchersController.IsExist(mainObjectNo))
                {
                    BOSApp.UpdateObjectNumbering(ModuleName.PaymentVoucher);
                    mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.PaymentVoucher, objSupplierPaymentsInfo);
                }
            }
            else if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.PaymentOrder, objSupplierPaymentsInfo);
                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                while (objBankTransactionsController.IsExist(mainObjectNo))
                {
                    BOSApp.UpdateObjectNumbering(ModuleName.PaymentOrder);
                    mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.PaymentOrder, objSupplierPaymentsInfo);
                }
            }
            else
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.Document, objSupplierPaymentsInfo);
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                while (objDocumentsController.IsExist(mainObjectNo))
                {
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                    mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.Document, objSupplierPaymentsInfo);
                }
            }
            return mainObjectNo;
        }

        public override void UpdateObjectNumbering(int numberingStart)
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)MainObject;
            if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.PaymentVoucher);
            }
            else if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.PaymentOrder);
            }
            else
            {
                BOSApp.UpdateObjectNumbering(ModuleName.Document);
            }
        }

        public override void SaveModuleObjects()
        {
            PaymentDetailList.SaveItemObjects();
            PaymentProposalList.SaveItemObjects();
            SupplierPaymentDocumentList.SaveItemObjects();
        }

        /// <summary>
        /// Save invoices paid by the supplier payment
        /// </summary>
        private void SavePaidInvoices()
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)MainObject;
            //Delete document payments
            APDocumentPaymentsController objDocumentPaymentsController = new APDocumentPaymentsController();
            objDocumentPaymentsController.DeleteByForeignColumn("FK_APSupplierPaymentID", objSupplierPaymentsInfo.APSupplierPaymentID);
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrdersInfo objPurchaseOrdersInfo;
            foreach (APPaymentProposalPaymentsInfo objPaymentProposalPaymentsInfo in PaymentProposalList)
            {
                objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APPurchaseOrderID);
                if (objPurchaseOrdersInfo != null)
                {
                    APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
                    APOpenDocumentsInfo objOpenDocumentsInfo = (APOpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objPurchaseOrdersInfo.APPurchaseOrderNo);
                    if (objOpenDocumentsInfo == null)
                    {
                        objOpenDocumentsInfo = DataGenerator.GenerateOpenDocumentFromPurchaseOrder(objPurchaseOrdersInfo);
                        objOpenDocumentsController.CreateObject(objOpenDocumentsInfo);

                    }

                    SupplierPaymentModule.CreateDocumentPayments(objOpenDocumentsInfo,
                                                                objSupplierPaymentsInfo,
                                                                objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount);
                }
                //Set Remain Amount
                objPaymentProposalPaymentsInfo.APPaymentProposalPaymentRemainAmount =
                    objPaymentProposalPaymentsInfo.APPaymentProposalPaymentRemainAmount - objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount - objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDiscountFix;
                objPaymentProposalPaymentsInfo.APPaymentProposalPaymentPaidAmount = objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDiscountFix;



            }
            PaymentProposalList.GridControl.RefreshDataSource();

            APPaymentProposalPaymentsController PaymentProposalPaymentsController = new APPaymentProposalPaymentsController();
            APPurchaseOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo;
            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
            APPaymentProposalItemsController objPaymentProposalItemsController = new APPaymentProposalItemsController();
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            APInvoiceInsInfo objInvoiceInsInfo;
            foreach (APPaymentProposalPaymentsInfo objPaymentProposalPaymentsInfo in PaymentProposalList.BackupList)
            {
                APPaymentProposalItemsInfo objPaymentProposalItemsInfo = (APPaymentProposalItemsInfo)objPaymentProposalItemsController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APPaymentProposalItemID);

                decimal totalOfPaymentProposal = 0;
                decimal amountOfPaymentProposal = 0;
                decimal percentPayment = 0;
                if (objPaymentProposalItemsInfo != null)
                {
                    totalOfPaymentProposal = (objPaymentProposalItemsInfo.APPaymentProposalItemTotalAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    amountOfPaymentProposal = objPaymentProposalItemsInfo.APPaymentProposalItemProposalAmount;
                    objPaymentProposalItemsInfo.APPaymentProposalItemRemainAmount += (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    objPaymentProposalItemsInfo.APPaymentProposalItemPaidAmount -= (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    objPaymentProposalItemsController.UpdateObject(objPaymentProposalItemsInfo);
                }
                objPurchaseOrderPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)objPurchaseOrderPaymentTimesController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APPurchaseOrderPaymentTimeID);
                if (objPurchaseOrderPaymentTimesInfo != null)
                {

                    objPurchaseOrderPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue += (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount);
                    objPurchaseOrderPaymentTimesInfo.ARSaleOrderPaymentTimeDepositBalance -= (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount);
                    objPurchaseOrderPaymentTimesController.UpdateObject(objPurchaseOrderPaymentTimesInfo);

                }
                objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APPurchaseOrderID);
                if (objPurchaseOrdersInfo != null)
                {
                    if (objPurchaseOrderPaymentTimesInfo != null && objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Payment.ToString())
                    {
                        percentPayment = objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount / objPurchaseOrdersInfo.APPurchaseOrderTotalCost;
                    }
                    //=> Tiền đệ nghị max 
                    if (objPaymentProposalPaymentsInfo != null)
                    {
                        decimal maxOfProposalAmount = totalOfPaymentProposal * percentPayment;
                        //=> % đề nghị
                        decimal percentProposal = amountOfPaymentProposal / maxOfProposalAmount;
                        //=> % đề nghị thực tế
                        decimal realPercentPayment = percentProposal * ((objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount) / amountOfPaymentProposal);
                        objPurchaseOrdersInfo.APPurchaseOrderPaidAmount -= (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount);
                        if (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentType == PaymentProposalItemType.PurchaseOrder.ToString())
                        {

                            objPurchaseOrdersInfo.APPurchaseOrderInvoiceInAmount += (realPercentPayment * totalOfPaymentProposal);
                        }
                    }
                    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
                }
                objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APInvoiceInID);
                if (objInvoiceInsInfo != null)
                {
                    //objInvoiceInsInfo.APInvoiceInBalanceDue += (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    //objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
                }
            }
            foreach (APPaymentProposalPaymentsInfo objPaymentProposalPaymentsInfo in PaymentProposalList)
            {
                APPaymentProposalItemsInfo objPaymentProposalItemsInfo = (APPaymentProposalItemsInfo)objPaymentProposalItemsController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APPaymentProposalItemID);
                decimal totalOfPaymentProposal = 0;
                decimal amountOfPaymentProposal = 0;
                decimal percentPayment = 0;
                if (objPaymentProposalItemsInfo != null)
                {
                    totalOfPaymentProposal = (objPaymentProposalItemsInfo.APPaymentProposalItemTotalAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    amountOfPaymentProposal = objPaymentProposalItemsInfo.APPaymentProposalItemProposalAmount;
                    objPaymentProposalItemsInfo.APPaymentProposalItemRemainAmount -= (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    objPaymentProposalItemsInfo.APPaymentProposalItemPaidAmount += (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    if (objPaymentProposalItemsInfo.APPaymentProposalItemRemainAmount == 0)
                    {
                        //objPaymentProposalItemsInfo. = PurchaseOrderPaymentTimeStatus.Paid.ToString();
                    }

                    if (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentType == PaymentProposalItemType.PurchaseOrderInvoiceInDetail.ToString())
                    {
                        if (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount > 0)
                        {
                            objPaymentProposalItemsInfo.APPaymentProposalItemDepositAmount = objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount;
                        }
                    }
                    objPaymentProposalItemsController.UpdateObject(objPaymentProposalItemsInfo);
                    //}

                }
                objPurchaseOrderPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)objPurchaseOrderPaymentTimesController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APPurchaseOrderPaymentTimeID);
                if (objPurchaseOrderPaymentTimesInfo != null)
                {
                    objPurchaseOrderPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue -= (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount);
                    objPurchaseOrderPaymentTimesInfo.ARSaleOrderPaymentTimeDepositBalance += (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount);
                    objPurchaseOrderPaymentTimesController.UpdateObject(objPurchaseOrderPaymentTimesInfo);
                }
                objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APPurchaseOrderID);
                if (objPurchaseOrdersInfo != null)
                {
                    if (objPurchaseOrderPaymentTimesInfo != null && objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Payment.ToString())
                    {
                        percentPayment = (objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount) / objPurchaseOrdersInfo.APPurchaseOrderTotalCost;
                    }
                    //=> Tiền đệ nghị max 
                    if (objPaymentProposalPaymentsInfo != null)
                    {
                        decimal maxOfProposalAmount = totalOfPaymentProposal * percentPayment;
                        //=> % đề nghị
                        decimal percentProposal = amountOfPaymentProposal / maxOfProposalAmount;
                        //=> % đề nghị thực tế
                        decimal realPercentPayment = percentProposal * (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount / amountOfPaymentProposal);
                        objPurchaseOrdersInfo.APPurchaseOrderPaidAmount += (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount);
                        if (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentType == PaymentProposalItemType.PurchaseOrder.ToString())
                        {

                            objPurchaseOrdersInfo.APPurchaseOrderInvoiceInAmount -= (realPercentPayment * totalOfPaymentProposal);
                        }
                    }
                    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
                }
                objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(objPaymentProposalPaymentsInfo.FK_APInvoiceInID);
                if (objInvoiceInsInfo != null)
                {
                    objInvoiceInsInfo.APInvoiceInBalanceDue -= (objPaymentProposalPaymentsInfo.APPaymentProposalPaymentAmount + objPaymentProposalPaymentsInfo.APPaymentProposalPaymentDepositAmount);
                    objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
                }
            }


        }
        #endregion

        /// <summary>
        /// Get default payment methods for a supplier payment
        /// </summary>
        private List<APSupplierPaymentDetailsInfo> GetDefaultPaymentMethods()
        {
            APSupplierPaymentDetailsController objSupplierPaymentDetailsController = new APSupplierPaymentDetailsController();
            List<APSupplierPaymentDetailsInfo> paymentDetailList = objSupplierPaymentDetailsController.GetDefaultPaymentDetails();
            paymentDetailList = paymentDetailList.Where(p =>
                                    p.APPaymentMethodCombo == PaymentMethod.Cash.ToString() ||
                                    p.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString() ||
                                    p.APPaymentMethodCombo == PaymentMethod.CashSec.ToString() ||
                                    p.APPaymentMethodCombo == PaymentMethod.TransferSec.ToString()).ToList();
            return paymentDetailList;
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)MainObject;
            DocumentEntryList.Clear();
            ACDocumentsInfo objDocumentsInfo = DocumentList.FirstOrDefault();
            BOSUtil.CopyObject(supplierPayment, objDocumentsInfo);

            objDocumentsInfo.FK_ACObjectID = supplierPayment.FK_ACObjectID;
            objDocumentsInfo.FK_ACAssObjectID = supplierPayment.FK_ACAssObjectID;
            objDocumentsInfo.ACObjectType = supplierPayment.ACObjectType;
            objDocumentsInfo.ACAssObjectType = supplierPayment.APAssObjectType;
            objDocumentsInfo.STToolbarActionName = supplierPayment.STToolbarActionName;
            objDocumentsInfo.ACDocumentDate = supplierPayment.APSupplierPaymentDate;
            SupplierPaymentDocumentList.ForEach(o =>
            {
                ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                BOSUtil.CopyObject(o, entry);
                entry.FK_ACDocumentTypeID = objDocumentsInfo.FK_ACDocumentTypeID;
                DocumentEntryList.Add(entry);
            });

            bool isComplete = base.SaveAccountingData();
            if (isComplete)
            {
                if (supplierPayment.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
                {
                    CreateAssociatedDocument();
                }
            }
            return isComplete;
        }

        /// <summary>
        /// Create an own document for the associated payment
        /// in case its currency is different from the payment
        /// </summary>
        private void CreateAssociatedDocument()
        {
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)MainObject;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            if (supplierPayment.FK_GEAssCurrencyID > 0 && supplierPayment.FK_GEAssCurrencyID != supplierPayment.FK_GECurrencyID)
            {
                ACDocumentsInfo document = DocumentList.Where(d => d.ACDocumentNo == supplierPayment.APSupplierPaymentNo).FirstOrDefault();
                ACDocumentEntrysInfo entry = DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.CanTruCongNoNCC.ToString()).FirstOrDefault();
                if (document != null && entry != null)
                {
                    ACDocumentsInfo assDocument = objDocumentsController.GetDocumentByTypeAndReference(AccDocumentType.NghiepVuKhac.ToString(), supplierPayment.APSupplierPaymentNo);
                    if (assDocument == null)
                    {
                        assDocument = new ACDocumentsInfo();
                        BOSUtil.CopyObject(document, assDocument);
                        assDocument.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, assDocument);
                        assDocument.FK_ACDocumentTypeID = entry.FK_ACDocumentTypeID;
                        BOSApp.UpdateObjectNumbering(ModuleName.Document);
                    }
                    assDocument.FK_ACObjectID = supplierPayment.FK_APAssociatedSupplierID;
                    assDocument.FK_ACAssObjectID = 0;
                    assDocument.ACObjectType = ObjectType.Supplier.ToString();
                    assDocument.FK_GECurrencyID = supplierPayment.FK_GEAssCurrencyID;
                    assDocument.ACDocumentExchangeRate = supplierPayment.APSupplierPaymentAssPostingExchangeRate;
                    assDocument.ACDocumentReference = supplierPayment.APSupplierPaymentNo;
                    assDocument.ACDocumentTotalAmount = supplierPayment.APSupplierPaymentAssTotalAmount;
                    assDocument.ACDocumentExchangeAmount = assDocument.ACDocumentTotalAmount * assDocument.ACDocumentExchangeRate;
                    assDocument.STToolbarActionName = supplierPayment.STToolbarActionName;
                    if (assDocument.ACDocumentID > 0)
                    {
                        objDocumentsController.UpdateObject(assDocument);
                    }
                    else
                    {
                        objDocumentsController.CreateObject(assDocument);
                    }

                    //Create associated entry
                    ACAccountsController objAccountsController = new ACAccountsController();
                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    List<ACDocumentEntrysInfo> assEntries = objDocumentEntrysController.GetDocumentEntryByDocumentID(assDocument.ACDocumentID);
                    ACDocumentEntrysInfo assEntry = null;
                    if (assEntries.Count == 0)
                    {
                        assEntry = new ACDocumentEntrysInfo();
                        GECurrenciesController objCurrencysController = new GECurrenciesController();
                        string currencyName = objCurrencysController.GetObjectNameByID(document.FK_GECurrencyID);
                        string assCurrencyName = objCurrencysController.GetObjectNameByID(assDocument.FK_GECurrencyID);
                        assEntry.ACDocumentEntryDesc = string.Format(SupplierPaymentLocalizedResources.BuyForeignCurrency, currencyName, assCurrencyName);
                        assEntry.FK_ACDebitAccountID = objAccountsController.GetObjectIDByNo(AccAccount.Acc1388);
                        assEntry.FK_ACCreditAccountID = entry.FK_ACDebitAccountID;
                    }
                    else
                    {
                        assEntry = assEntries[0];
                        assEntry.FK_ACDebitAccountID = entry.FK_ACCreditAccountID;
                    }
                    assEntry.FK_ACDocumentID = assDocument.ACDocumentID;
                    assEntry.FK_ACObjectID = assDocument.FK_ACObjectID;
                    assEntry.ACObjectType = assDocument.ACObjectType;
                    assEntry.ACDocumentEntryAmount = supplierPayment.APSupplierPaymentAssTotalAmount;
                    assEntry.ACDocumentEntryExchangeAmount = assEntry.ACDocumentEntryAmount * assDocument.ACDocumentExchangeRate;
                    if (assEntry.ACDocumentEntryID > 0)
                    {
                        objDocumentEntrysController.UpdateObject(assEntry);
                    }
                    else
                    {
                        objDocumentEntrysController.CreateObject(assEntry);
                    }

                    //Update document
                    document.FK_ACAssObjectID = 0;
                    objDocumentsController.UpdateObject(document);


                    //Update owing entry
                    entry.FK_ACCreditAccountID = assEntry.FK_ACDebitAccountID;
                    entry.FK_ACAssObjectID = 0;
                    objDocumentEntrysController.UpdateObject(entry);
                }
            }
            else
            {
                ACDocumentsInfo assDocument = DocumentList.Where(d => d.ACDocumentReference == supplierPayment.APSupplierPaymentNo).FirstOrDefault();
                if (assDocument != null)
                {
                    objDocumentsController.DeleteByDocumentTypeIDAndDocumentNo(assDocument.FK_ACDocumentTypeID, assDocument.ACDocumentNo);
                }
            }
        }
        #endregion

        //public override bool CompleteTransaction()
        //{
        //    APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)MainObject;
        //    if (supplierPayment.APSupplierPaymentStatus == SupplierPaymentStatus.Approved.ToString())
        //    {
        //        supplierPayment.APSupplierPaymentStatus = SupplierPaymentStatus.Completed.ToString();
        //    }
        //    UpdateMainObject();

        //    //SaveAccountingData();
        //    return true;
        //}
        public override bool CancelCompleteTransaction()
        {
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)MainObject;
            if (supplierPayment.APSupplierPaymentStatus == SupplierPaymentStatus.Approved.ToString())
            {
                supplierPayment.APSupplierPaymentStatus = SupplierPaymentStatus.New.ToString();
                supplierPayment.APSupplierPaymentPostedStatus = SaleOrderStatus.New.ToString();
                SaveMainObject();
            }
            return true;
        }
        public void UpdateReferPaymentData(bool isRollBack)
        {
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)MainObject;
            (new APPaymentProposalItemsController()).UpdateReferPaymentDataBySupplierPayment(supplierPayment.APSupplierPaymentID, isRollBack);
        }
    }
}

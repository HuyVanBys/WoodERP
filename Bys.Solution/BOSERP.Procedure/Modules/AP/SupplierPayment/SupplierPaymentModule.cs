using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BOSReport;
using DevExpress.XtraReports.UI;
using BOSERP.Utilities;

namespace BOSERP.Modules.SupplierPayment
{
    public class SupplierPaymentModule : BaseTransactionModule
    {
        #region Constant
        public const string InvoiceInGridControlName = "fld_dgcAPInvoiceIns";
        public const string SupplierPaymentDetailsGridControlName = "fld_dgcAPSupplierPaymentDetails";
        public const string PurchaseOrderGridControlName = "fld_dgcPurchaseOrders";
        public const string InvoiceGroupControlName = "fld_grpInvoices";
        public const string PurchaseOrderGroupControlName = "fld_grpPurchaseOrders";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string ToolbarButtonApproveSupplierPayment = "ApproveSupplierPayment";
        public const string CompanyBankLookupEditName = "fld_lkeFK_CSCompanyBankID";
        public const string CashFundLookupEditName = "fld_lkeFK_CSCashFundID";
        public const string LoanReceiptLookupEditName = "fld_lkeFK_ACLoanReceiptID";
        public const string PaymentProposalPaymentGridControlName = "fld_dgcAPPaymentProposalPayments";
        public const string ToolbarButtonApprove = "Approve";
        public const string ListAccountBankLookUpEditControlName = "fld_lkeFK_ACListAccountBankID";
        public BOSTabControl ACTabControl;
        public const string ExchangeWayLookupEditName = "fld_lkeAPSupplierPaymentAssExchangeWay";
        private int OldCurrencyID = 0;
        #endregion

        #region Variables
        /// <summary>
        /// A variable indicates whether the user is creating a new payment voucher
        /// </summary>
        private bool CreatePaymentVoucher = false;

        /// <summary>
        /// A variable indicates whether the user is creating a new payment order
        /// </summary>
        private bool CreatePaymentOrder = false;

        /// <summary>
        /// A variable indicates whether the user is creating a new supplier payment
        /// through the intermediate payer
        /// </summary>
        private bool CreatePaymentByIntermediatePayer = false;
        private bool CreateClearing = false;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the document type id
        /// </summary>
        public int DocumentTypeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the document type.
        /// </summary>        
        public string DocumentTypeName { get; set; }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        public BOSLookupEdit ListAccountBankLookUpEditControl;
        public BOSGridControl PaymentProposalPaymentGridControl;
        public BOSLookupEdit CompanyBankLookupEditControl;
        public BOSLookupEdit CashFundLookupEditControl;
        public BOSLookupEdit LoanReceiptLookupEditControl;
        #endregion

        #region Constructor
        public SupplierPaymentModule()
        {
            Name = "SupplierPayment";
            CurrentModuleEntity = new SupplierPaymentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            PaymentProposalPaymentGridControl = (BOSGridControl)Controls[PaymentProposalPaymentGridControlName];

            ListAccountBankLookUpEditControl = (BOSLookupEdit)Controls[ListAccountBankLookUpEditControlName];
            ACListAccountBanksController objListAccountBanksController = new ACListAccountBanksController();
            DataSet listAccountBanks = objListAccountBanksController.GetListAcctountBanks();
            ListAccountBankLookUpEditControl.Properties.DataSource = listAccountBanks.Tables[0];

            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentDetailsGridControl gridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
            gridControl.SupplierPaymentDetailList = entity.PaymentDetailList;
            gridControl.InitGridControlDataSource();

            DocumentTypeName = string.Empty;

            CompanyBankLookupEditControl = (BOSLookupEdit)Controls[SupplierPaymentModule.CompanyBankLookupEditName];
            if(CompanyBankLookupEditControl != null)
            {
                CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                CompanyBankLookupEditControl.Properties.DataSource = objCompanyBanksController.GetListCompanyBanksByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }

            CashFundLookupEditControl = (BOSLookupEdit)Controls[SupplierPaymentModule.CashFundLookupEditName];
            if(CashFundLookupEditControl != null)
            {
                CSCashFundsController objCashFundsController = new CSCashFundsController();
                CashFundLookupEditControl.Properties.DataSource = objCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }

            LoanReceiptLookupEditControl = (BOSLookupEdit)Controls[SupplierPaymentModule.LoanReceiptLookupEditName];
            ACTabControl = (BOSTabControl)Controls["fld_TabThanhToan"];
        }
        #endregion

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            APSupplierPaymentsController supplierPaymentController = new APSupplierPaymentsController();
            APSupplierPaymentsInfo searchObject = CurrentModuleEntity.SearchObject as APSupplierPaymentsInfo;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACAssObjectAccessKey);

            DataSet ds = new DataSet();

            if ((SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null &&
                (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")))
            {
                if (BranchList.Count == 0)
                {
                    ds = supplierPaymentController.GetDataSetByID(-1);
                }
                else
                {
                    ds = supplierPaymentController.GetSupplierPaymentDataSetByListOfBranchID(searchObject.APSupplierPaymentNo,
                                                                                            objObjectsInfo.ACObjectID,
                                                                                            objObjectsInfo.ACObjectType,
                                                                                            searchObject.FK_HREmployeeID,
                                                                                            null,
                                                                                            SupplierPaymentType.SupplierPayment.ToString(),
                                                                                            searchObject.SupplierPaymentDateFrom,
                                                                                            searchObject.SupplierPaymentDateTo,
                                                                                            BranchList);
                }
            }
            else if (SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null)
            {
                ds = supplierPaymentController.GetSupplierPaymentDataSetByBranchID(searchObject.APSupplierPaymentNo,
                                                                                            objObjectsInfo.ACObjectID,
                                                                                            objObjectsInfo.ACObjectType,
                                                                                            searchObject.FK_HREmployeeID,
                                                                                            null,
                                                                                            SupplierPaymentType.SupplierPayment.ToString(),
                                                                                            searchObject.FK_BRBranchID,
                                                                                            searchObject.SupplierPaymentDateFrom,
                                                                                            searchObject.SupplierPaymentDateTo
                                                                                            );
            }
            return ds;
        }
        
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            objSupplierPaymentsInfo.ACObjectAccessKey = objSupplierPaymentsInfo.FK_ACObjectID + ";" + objSupplierPaymentsInfo.ACObjectType;
            objSupplierPaymentsInfo.ACAssObjectAccessKey = objSupplierPaymentsInfo.FK_ACAssObjectID + ";" + objSupplierPaymentsInfo.APAssObjectType;
            CurrentModuleEntity.UpdateMainObjectBindingSource();

            APSupplierPaymentDetailsGridControl supplierPaymentDetailsGridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
            supplierPaymentDetailsGridControl.PaymentAmount = objSupplierPaymentsInfo.APSupplierPaymentTotalAmount;

            entity.PaymentProposalList.GridControl.Visible = true;
            entity.PaymentProposalList.BackupList.Clear();
            foreach (APPaymentProposalPaymentsInfo PaymentProposalPaymentsInfo in entity.PaymentProposalList)
            {
                entity.PaymentProposalList.BackupList.Add((APPaymentProposalPaymentsInfo)PaymentProposalPaymentsInfo.Clone());
            }

            LoadInvoiceByObject(objSupplierPaymentsInfo.ACObjectAccessKey);
            InvalidateTabControl(objSupplierPaymentsInfo.APPaymentMethodCombo);

            if (OldCurrencyID != objSupplierPaymentsInfo.FK_GECurrencyID)
            {
                ExchangeWayLookupEdit lke = (ExchangeWayLookupEdit)Controls[SupplierPaymentModule.ExchangeWayLookupEditName];
                lke.InitDataSource(objSupplierPaymentsInfo.FK_GECurrencyID);
                OldCurrencyID = objSupplierPaymentsInfo.FK_GECurrencyID;
            }

        }

        public override void ActionNew()
        {
            base.ActionNew();
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            ExchangeWayLookupEdit lke = (ExchangeWayLookupEdit)Controls[SupplierPaymentModule.ExchangeWayLookupEditName];
            lke.InitDataSource(objSupplierPaymentsInfo.FK_GECurrencyID);
            APSupplierPaymentDetailsGridControl gridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
            gridControl.PaymentAmount = 0;
        }

        /// <summary>
        /// Called when the user create a new payment voucher for 
        /// a new supplier payment
        /// </summary>
        public void ActionCreatePaymentVoucher()
        {
            CreatePaymentVoucher = true;
            CreatePaymentOrder = false;
            CreatePaymentByIntermediatePayer = false;
            ActionNew();
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            supplierPayment.APPaymentMethodCombo = PaymentMethod.Cash.ToString();
            //supplierPayment.APSupplierPaymentDesc = SupplierPaymentLocalizedResources.PaymentVoucherDefaultDesc;
            APSupplierPaymentDetailsGridControl gridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
            CompanyBankLookupEditControl.Properties.ReadOnly = true;
            LoanReceiptLookupEditControl.Properties.ReadOnly = true;
            CashFundLookupEditControl.Properties.ReadOnly = false;
            gridControl.RequiredMethod = PaymentMethod.Cash.ToString();
            LoadInvoiceByObject(supplierPayment.ACObjectAccessKey);
            GeneratePaymentDocumentData();
            InvalidateTabControl(supplierPayment.APPaymentMethodCombo);
        }

        /// <summary>
        /// Called when the user create a new payment order for 
        /// a new supplier payment
        /// </summary>
        public void ActionCreatePaymentOrder()
        {
            CreatePaymentOrder = true;
            CreatePaymentVoucher = false;
            CreatePaymentByIntermediatePayer = false;
            ActionNew();
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            supplierPayment.APPaymentMethodCombo = PaymentMethod.PaymentOrder.ToString();
            //supplierPayment.APSupplierPaymentDesc = SupplierPaymentLocalizedResources.PaymentOrderDefaultDesc;
            APSupplierPaymentDetailsGridControl gridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
            CashFundLookupEditControl.Properties.ReadOnly = true;
            CompanyBankLookupEditControl.Properties.ReadOnly = false;
            LoanReceiptLookupEditControl.Properties.ReadOnly = false;
            gridControl.RequiredMethod = PaymentMethod.PaymentOrder.ToString();
            LoadInvoiceByObject(supplierPayment.ACObjectAccessKey);
            GeneratePaymentDocumentData();
            InvalidateTabControl(supplierPayment.APPaymentMethodCombo);
        }

        /// <summary>
        /// Called when the user create a new supplier payment order through
        /// the intermediate payer
        /// </summary>
        public void ActionCreatePaymentByIntermediatePayer()
        {
            CreatePaymentByIntermediatePayer = true;
            CreatePaymentOrder = false;
            CreatePaymentVoucher = false;

            ActionNew();
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            supplierPayment.APPaymentMethodCombo = PaymentMethod.OwingExchange.ToString();
            //supplierPayment.APSupplierPaymentDesc = SupplierPaymentLocalizedResources.PaymentByIntermediatePayerDefaultDesc;
            APSupplierPaymentDetailsGridControl gridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
            CashFundLookupEditControl.Properties.ReadOnly = true;
            CompanyBankLookupEditControl.Properties.ReadOnly = false;
            LoanReceiptLookupEditControl.Properties.ReadOnly = false;
            gridControl.RequiredMethod = PaymentMethod.Cash.ToString();
            LoadInvoiceByObject(supplierPayment.ACObjectAccessKey);
            GenerateAccountingData();
            GeneratePaymentDocumentData();
            InvalidateTabControl(supplierPayment.APPaymentMethodCombo);

        }

        public override int ActionSave()
        {
            //SetDefaultDesc();
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APPaymentProposalPaymentsController objPaymentProposalPaymentsController = new APPaymentProposalPaymentsController();
            entity.PaymentProposalList.EndCurrentEdit();
            if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                if (objSupplierPaymentsInfo.FK_CSCashFundID == 0)
                {
                    MessageBox.Show(SupplierPaymentLocalizedResources.ChooseCashFund
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return 0;
                }
            }
            if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                if (objSupplierPaymentsInfo.FK_CSCompanyBankID == 0 && objSupplierPaymentsInfo.FK_ACLoanReceiptID == 0)
                {
                    MessageBox.Show(SupplierPaymentLocalizedResources.ChooseCompanyBank
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return 0;
                }
            }
            if (objSupplierPaymentsInfo.FK_ACLoanReceiptID > 0)
            {
                if (!IsValidAmountLoanReceipt())
                    return 0;
            }
            if(!CheckPaymentDiscountFix())
            {
                return 0;
            }
            if (entity.PaymentProposalList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết hóa đơn thanh toán!"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            CreatePaymentVoucher = false;
            CreatePaymentOrder = false;
            foreach (APPaymentProposalPaymentsInfo item in entity.PaymentProposalList)
            {
                APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                APPaymentProposalsController objPaymentProposalsController = new APPaymentProposalsController();
                APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();

                if (item.FK_APPaymentProposalID > 0)
                {
                    APPaymentProposalsInfo objPP = (APPaymentProposalsInfo)objPaymentProposalsController.GetObjectByID(item.FK_APPaymentProposalID);
                    if (objPP != null)
                    {
                        if (string.IsNullOrEmpty(objSupplierPaymentsInfo.APSupplierPaymentDesc) && string.IsNullOrEmpty(objPP.APPaymentProposalDesc))
                        {
                            objSupplierPaymentsInfo.APSupplierPaymentDesc = string.Format("Chi tiền theo ĐNTT số {0}", objPP.APPaymentProposalNo);
                        }
                        else if (string.IsNullOrEmpty(objSupplierPaymentsInfo.APSupplierPaymentDesc))
                        {
                            objSupplierPaymentsInfo.APSupplierPaymentDesc = objPP.APPaymentProposalDesc;
                        }
                        else
                        {
                            if (objSupplierPaymentsInfo.APSupplierPaymentDesc.Contains(objPP.APPaymentProposalDesc))
                            {
                                objSupplierPaymentsInfo.APSupplierPaymentDesc = objSupplierPaymentsInfo.APSupplierPaymentDesc;
                            }
                            else if (string.IsNullOrWhiteSpace(objPP.APPaymentProposalDesc))
                            {
                                objSupplierPaymentsInfo.APSupplierPaymentDesc = objSupplierPaymentsInfo.APSupplierPaymentDesc;
                            }
                            else
                            {
                                objSupplierPaymentsInfo.APSupplierPaymentDesc = objPP.APPaymentProposalDesc + "; " + objSupplierPaymentsInfo.APSupplierPaymentDesc;
                            }
                        }

                        if (objPP.FK_ACObjectID != objSupplierPaymentsInfo.FK_ACObjectID
                            || objPP.APObjectType != objSupplierPaymentsInfo.ACObjectType)
                        {
                            MessageBox.Show(string.Format("Đối tượng ở đề nghị thanh toán {0} không trùng với đối tượng ở thông tin chung", objPP.APPaymentProposalNo)
                                            + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                            , CommonLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                    }
                }

                decimal totalAmount = objPaymentProposalPaymentsController.GetAllObjectsByPaymentProposalItemID(item.FK_APPaymentProposalItemID)
                                                                                                .Where(o => o.FK_APPaymentProposalItemID != item.FK_APPaymentProposalItemID)
                                                                                                .Sum(o => o.APPaymentProposalPaymentAmount);
                if ((totalAmount + item.APPaymentProposalPaymentAmount) > item.APPaymentProposalPaymentRemainAmount)
                {
                    MessageBox.Show(SupplierPaymentLocalizedResources.PaymentAmountErrorMessage + " Số tiền tối đa bạn có thể thanh toán trong đợt này là: " +
                                            (item.APPaymentProposalPaymentRemainAmount - totalAmount), CommonLocalizedResources.MessageBoxDefaultCaption,
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
            }

            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            ACObjectsController objObjectsController = new ACObjectsController();
            objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(objSupplierPaymentsInfo.ACObjectAccessKey);
            objSupplierPaymentsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
            objSupplierPaymentsInfo.ACObjectType = objObjectsInfo.ACObjectType;

            if (SupplierIsPaymentLocked())
            {
                return 0;
            }

            //TNDLoc [ADD][30/06/2015][Issue Payment Amount],START
            //Note: số tiền thanh toán không lớn hơn số tiền còn lại
            //if (objSupplierPaymentsInfo.APSupplierPaymentType == SupplierPaymentType.PaymentProposal.ToString())
            {
                bool isOverLimit = false;
                foreach (APPaymentProposalPaymentsInfo item in entity.PaymentProposalList)
                {
                    if (item.APPaymentProposalPaymentAmount > item.APPaymentProposalPaymentRemainAmount)
                    {
                        isOverLimit = true;
                        break;
                    }
                }
                if (isOverLimit)
                {
                    MessageBox.Show(CommonLocalizedResources.OwingExchangePaymentExceedsRemainedAmountMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            //TNDLoc [ADD][30/06/2015][Issue Payment Amount],END
            entity.APInvoiceInList.EndCurrentEdit();
            UpdateTotalAmount();

            int supplierPaymentID = base.ActionSave();
            if (supplierPaymentID > 0)
            {
                //Update backup list of PaymentProposa items
                entity.PaymentProposalList.BackupList.Clear();
                foreach (APPaymentProposalPaymentsInfo objPaymentProposalPaymentsInfo in entity.PaymentProposalList)
                {
                    entity.PaymentProposalList.BackupList.Add((APPaymentProposalPaymentsInfo)objPaymentProposalPaymentsInfo.Clone());
                }
                InvalidateAccountingEntries();
            }

            return supplierPaymentID;
        }

        public void ApproveSupplierPayment()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objSupplierPaymentsInfo.APSupplierPaymentStatus = SupplierPaymentStatus.Approved.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        private bool CheckPaymentDiscountFix()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APPaymentProposalItemsController objPaymentProposalItemsController = new APPaymentProposalItemsController();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(new DataColumn("PaymentID", typeof(int)));
            dt.Columns.Add(new DataColumn("ProposalItemID", typeof(int)));

            DataRow r;
            entity.PaymentProposalList.ForEach(o =>
            {
                r = dt.NewRow();
                r["PaymentID"] = o.APPaymentProposalPaymentID;
                r["ProposalItemID"] = o.FK_APPaymentProposalItemID;
                dt.Rows.Add(r);
            });
            List<APPaymentProposalItemsInfo> listPaymentProposalItemsInfo = objPaymentProposalItemsController.GetListProposalItemRemainDiscountFixByProposalItemID(dt);
            APPaymentProposalItemsInfo objPaymentProposalItemsInfo;

            foreach(APPaymentProposalPaymentsInfo o in entity.PaymentProposalList)
            {
                objPaymentProposalItemsInfo = listPaymentProposalItemsInfo.FirstOrDefault(i => i.APPaymentProposalItemID == o.FK_APPaymentProposalItemID);
                if(objPaymentProposalItemsInfo != null)
                {
                    if(o.APPaymentProposalPaymentDiscountFix > objPaymentProposalItemsInfo.APPaymentProposalItemDiscountFix)
                    {
                        MessageBox.Show(string.Format("Số tiền chiết khấu thanh toán cho đề nghị {0} vượt quá chiết khấu còn lại ({1})", objPaymentProposalItemsInfo.APPaymentProposalNo
                                                                                                                                        , objPaymentProposalItemsInfo.APPaymentProposalItemDiscountFix.ToString("N3"))
                                        + Environment.NewLine + "Vui lòng kiểm tra lại!" 
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                        return false;
                    }    
                }
                else
                {
                    if(o.APPaymentProposalPaymentDiscountFix > 0)
                    {
                        MessageBox.Show(string.Format("Hóa đơn {0} không có chiết khấu thanh toán", o.APPaymentProposalPaymentInvoiceInNo)
                                        + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                        return false;
                    }    
                }    
            }
            return true;
        }    

        public void ChangeDefaultDesc(int associatedSupplierID)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            APSuppliersController objSuppliersController = new APSuppliersController();
            if (objSupplierPaymentsInfo != null)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objSupplierPaymentsInfo.FK_ACObjectID, objSupplierPaymentsInfo.ACObjectType);
                if (objObjectsInfo != null)
                {
                    string invoiceNo = string.Empty;
                    foreach (APInvoiceInsInfo invoice in entity.APInvoiceInList)
                    {
                        invoiceNo += string.Format(" {0},", invoice.APInvoiceInNo);
                    }
                    if (!string.IsNullOrEmpty(invoiceNo))
                    {
                        invoiceNo = invoiceNo.Substring(0, invoiceNo.Length - 1);
                    }

                    if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
                    {
                        APSuppliersInfo associatedSupplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(associatedSupplierID);
                        if (associatedSupplier != null)
                        {
                            objSupplierPaymentsInfo.APSupplierPaymentDesc = SupplierPaymentLocalizedResources.PaymentByIntermediatePayerDefaultDesc;
                            objSupplierPaymentsInfo.APSupplierPaymentDesc = objSupplierPaymentsInfo.APSupplierPaymentDesc.Replace("{0}", associatedSupplier.APSupplierName);
                            objSupplierPaymentsInfo.APSupplierPaymentDesc = objSupplierPaymentsInfo.APSupplierPaymentDesc.Replace("{1}", objObjectsInfo.ACObjectName);
                            objSupplierPaymentsInfo.APSupplierPaymentDesc = objSupplierPaymentsInfo.APSupplierPaymentDesc.Replace("{2}", invoiceNo);
                        }
                    }
                }
            }
            entity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Set the default desc for the payment
        /// </summary>
        private void SetDefaultDesc()
        {
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            if (supplierPayment != null)
            {
                APSuppliersController objSuppliersController = new APSuppliersController();
                APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierPayment.FK_APSupplierID);
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(supplierPayment.FK_ACObjectID, supplierPayment.ACObjectType);
                if (objObjectsInfo != null)
                {
                    SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                    string invoiceNo = string.Empty;
                    foreach (APInvoiceInsInfo invoice in entity.APInvoiceInList)
                    {
                        invoiceNo += string.Format(" {0},", invoice.APInvoiceInNo);
                    }
                    if (!string.IsNullOrEmpty(invoiceNo))
                    {
                        invoiceNo = invoiceNo.Substring(0, invoiceNo.Length - 1);
                    }

                    if (supplierPayment.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
                    {
                        supplierPayment.APSupplierPaymentDesc = supplierPayment.APSupplierPaymentDesc.Replace("{0}", objObjectsInfo.ACObjectName);
                        supplierPayment.APSupplierPaymentDesc = supplierPayment.APSupplierPaymentDesc.Replace("{1}", invoiceNo);
                    }
                    else if (supplierPayment.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
                    {
                        supplierPayment.APSupplierPaymentDesc = supplierPayment.APSupplierPaymentDesc.Replace("{0}", objObjectsInfo.ACObjectName);
                        supplierPayment.APSupplierPaymentDesc = supplierPayment.APSupplierPaymentDesc.Replace("{1}", invoiceNo);
                    }
                    else if (supplierPayment.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
                    {
                        APSuppliersInfo associatedSupplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierPayment.FK_APAssociatedSupplierID);
                        if (associatedSupplier != null)
                        {
                            supplierPayment.APSupplierPaymentDesc = supplierPayment.APSupplierPaymentDesc.Replace("{0}", associatedSupplier.APSupplierName);
                            supplierPayment.APSupplierPaymentDesc = supplierPayment.APSupplierPaymentDesc.Replace("{1}", objObjectsInfo.ACObjectName);
                            supplierPayment.APSupplierPaymentDesc = supplierPayment.APSupplierPaymentDesc.Replace("{2}", invoiceNo);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Check supplier is payment locked.
        /// </summary>
        /// <returns>True if is payment locked is true else false</returns>
        public bool SupplierIsPaymentLocked()
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            APSuppliersController objSuppliersController = new APSuppliersController();
            APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(objSupplierPaymentsInfo.FK_APSupplierID);
            if (objSuppliersInfo != null)
            {
                if (objSuppliersInfo.IsPaymentLocked)
                {
                    MessageBox.Show(PurchaseOrderLocalizedResources.IsPaymentLockedErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Show owing invoices
        /// </summary>
        public void ShowOwingInvoiceIns(int supplierID)
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            if (objSupplierPaymentsInfo != null && objSupplierPaymentsInfo.APSupplierPaymentType == SupplierPaymentType.SupplierPayment.ToString())
            {
                guiOwingInvoiceIn guiOwingInvoice = new guiOwingInvoiceIn();
                guiOwingInvoice.Module = this;
                if (guiOwingInvoice.ShowDialog() == DialogResult.OK)
                {
                    AddItemToInvoiceList();
                }
            }
        }

        /// <summary>
        ///  Get all owing invoice ins
        /// </summary>
        /// <param name="invoiceInNo">The invoice no</param>
        /// <param name="searchFromInvoiceInDate">The search from invoice date</param>
        /// <param name="searchToInvoiceInDate">The search to invoice date</param>
        /// <param name="chkSelectAllOwingInvoice">The control check sellect owing invoice</param>
        /// <param name="invoiceInSupplierReference">The invoice supplier reference</param>
        /// <param name="invoicePackNo">Invoice pack no</param>
        public void GetAllOwingInvoiceIns(
                                    string invoiceInNo,
                                    DateTime searchFromInvoiceInDate,
                                    DateTime searchToInvoiceInDate,
                                    BOSCheckEdit chkSelectAllOwingInvoice,
                                    string invoiceInSupplierReference,
                                    string invoicePackNo)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<APInvoiceInsInfo> owingInvoices = objInvoiceInsController.GetOwingInvoices(
            //                                            objSupplierPaymentsInfo.FK_APSupplierID, 
            //                                            searchFromInvoiceInDate, 
            //                                            searchToInvoiceInDate, 
            //                                            invoiceInNo, 
            //                                            invoiceInSupplierReference,
            //                                            invoicePackNo);

            List<APInvoiceInsInfo> owingInvoices = objInvoiceInsController.GetOwingInvoicesByUserPermission(
                                                        objSupplierPaymentsInfo.FK_APSupplierID,
                                                        searchFromInvoiceInDate,
                                                        searchToInvoiceInDate,
                                                        invoiceInNo,
                                                        invoiceInSupplierReference,
                                                        invoicePackNo,
                                                        BOSApp.CurrentUsersInfo.ADUserID,
                                                        ModuleName.InvoiceIn,
                                                        ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START

            owingInvoices = owingInvoices.Where(i => i.APInvoiceInBalanceDue > 0).ToList();
            entity.OwingInvoiceInList.Invalidate(owingInvoices);
        }

        /// <summary>
        /// Select all owing invoice ins 
        /// </summary>
        /// <param name="selectAllOwingInvoiceCheckbox">The select all owing invoice ins check edit control</param>
        public void SelectAllOwingInvoices(BOSCheckEdit selectAllOwingInvoiceCheckbox)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            if (selectAllOwingInvoiceCheckbox.Checked == true)
                entity.OwingInvoiceInList.ForEach(invoice => invoice.Selected = true);
            else
                entity.OwingInvoiceInList.ForEach(invoice => invoice.Selected = false);
            entity.OwingInvoiceInList.GridControl.RefreshDataSource();
        }
        /// <summary>
        /// Add owing invoices after check to invoice list
        /// </summary>
        public void AddItemToInvoiceList()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            List<APInvoiceInsInfo> list = new List<APInvoiceInsInfo>();
            foreach (APInvoiceInsInfo objInvoicesInfo in entity.OwingInvoiceInList)
            {
                if (objInvoicesInfo.Selected && !entity.APInvoiceInList.Exists(i => i.APInvoiceInID == objInvoicesInfo.APInvoiceInID))
                {
                    objSupplierPaymentsInfo.FK_ACObjectID = objInvoicesInfo.FK_ACAssObjectID;
                    entity.APInvoiceInList.Add(objInvoicesInfo);
                }
            }
            //force to store a backup list for invoicein list
            list = entity.APInvoiceInList.ToList();
            entity.APInvoiceInList.Invalidate(list);
            entity.APInvoiceInList.GridControl.InvalidateLookupEditColumns();
            entity.APInvoiceInList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Called when user changes the payment amount of an invoice
        /// </summary>
        /// <param name="objInvoicesInfo">Info of invoice</param>
        public void ChangeInvoicePaymentAmount(APInvoiceInsInfo objInvoicesInfo)
        {
            UpdateTotalAmount();
        }
        public void ChangeProposalPaymentAmount(APPaymentProposalPaymentsInfo objPaymentProposalsInfo)
        {
            UpdateTotalAmount();
        }

        public bool ChangeProposalPaymentAmount(APPaymentProposalPaymentsInfo objPaymentProposalsInfo, bool isFromPercent)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            if (entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentAmount >
                entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentRemainAmount)
            {
                MessageBox.Show(SupplierPaymentLocalizedResources.PaymentAmountCheckMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentPercent > 100)
            {
                MessageBox.Show(SupplierPaymentLocalizedResources.PercentCheckMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (isFromPercent)
                {
                    entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentAmount
                        = (entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentPercent / 100) * (entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentRemainAmount)
                        - entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentDepositAmount
                        - entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentDiscountFix;
                    entity.PaymentProposalList.GridControl.RefreshDataSource();
                }
                else
                {
                    entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentPercent
                        = ((entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentAmount + entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentDepositAmount
                            + entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentDiscountFix) / (entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentRemainAmount)) * 100;
                    entity.PaymentProposalList.GridControl.RefreshDataSource();
                }
                BOSApp.RoundByCurrency(objPaymentProposalsInfo, objSupplierPaymentsInfo.FK_GECurrencyID);
                UpdateTotalAmount();
                return true;
            }
        }

        /// <summary>
        /// Update the total amount of the supplier payment
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                UpdateDocumentEntries();

                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
                objSupplierPaymentsInfo.APSupplierPaymentTotalAmount = entity.SupplierPaymentDocumentList.Sum(e => e.APSupplierPaymentDocumentAmount);
                objSupplierPaymentsInfo.APSupplierPaymentExchangeAmount = objSupplierPaymentsInfo.APSupplierPaymentTotalAmount * objSupplierPaymentsInfo.APSupplierPaymentExchangeRate;
                UpdateAssociatedPaymentAmount();
                BOSApp.RoundByCurrency(objSupplierPaymentsInfo, objSupplierPaymentsInfo.FK_GECurrencyID);
                entity.UpdateMainObjectBindingSource();

                APSupplierPaymentDetailsGridControl gridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
                gridControl.PaymentAmount = objSupplierPaymentsInfo.APSupplierPaymentTotalAmount;
                gridControl.ProposeRemainingAmount();
            }
        }
        public void updateTotalAmountbyCurrecy()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            foreach (APPaymentProposalPaymentsInfo item in entity.PaymentProposalList)
            {
                BOSApp.RoundByCurrency(item, objSupplierPaymentsInfo.FK_GECurrencyID);
            }
            foreach (APSupplierPaymentDetailsInfo item in entity.PaymentDetailList)
            {
                BOSApp.RoundByCurrency(item, objSupplierPaymentsInfo.FK_GECurrencyID);
            }
            BOSApp.RoundByCurrency(objSupplierPaymentsInfo, objSupplierPaymentsInfo.FK_GECurrencyID);
            entity.PaymentDetailList.GridControl.RefreshDataSource();
            entity.PaymentProposalList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
            entity.UpdateMainObjectBindingSource();
        }
        /// <summary>
        /// Update the amount of the associated payment
        /// </summary>
        public void UpdateAssociatedPaymentAmount()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            if (objSupplierPaymentsInfo.APSupplierPaymentAssExchangeRate > 1)
                objSupplierPaymentsInfo.APSupplierPaymentAssTotalAmount = (objSupplierPaymentsInfo.APSupplierPaymentTotalAmount * objSupplierPaymentsInfo.APSupplierPaymentExchangeRate) / objSupplierPaymentsInfo.APSupplierPaymentAssExchangeRate;
            //BOSApp.RoundByCurrency(objSupplierPaymentsInfo, "APSupplierPaymentAssTotalAmount", objSupplierPaymentsInfo.FK_GEAssCurrencyID);
        }


        /// <summary>
        /// Delete selected invoice from invoice list
        /// </summary>
        public void DeleteSelectedInvoice()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                entity.APInvoiceInList.RemoveSelectedRowObjectFromList();
                UpdateTotalAmount();
            }
        }

        public void DeleteSelectedProposal()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                entity.PaymentProposalList.RemoveSelectedRowObjectFromList();
                UpdateTotalAmount();
            }
        }
        /// <summary>
        /// Called when user wants to change the bank
        /// </summary>
        public void ChangeBank(int bankID)
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            objSupplierPaymentsInfo.FK_CSCompanyBankID = bankID;
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankID);
            if (objCompanyBanksInfo != null)
            {
                objSupplierPaymentsInfo.APSupplierPaymentBankAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
            UpdateDocumentEntries();
        }

        /// <summary>
        /// Called when user wants to change the cash fund
        /// </summary>
        public void ChangeCashFund(int cashFundID)
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            objSupplierPaymentsInfo.FK_CSCashFundID = cashFundID;
            GenerateAccountingData();
            UpdateDocumentEntries();
        }

        /// <summary>
        /// Called when user changes the total amount
        /// </summary>
        public void ChangeTotalAmount()
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            APSupplierPaymentDetailsGridControl gridControl = (APSupplierPaymentDetailsGridControl)Controls[SupplierPaymentModule.SupplierPaymentDetailsGridControlName];
            gridControl.PaymentAmount = objSupplierPaymentsInfo.APSupplierPaymentTotalAmount;
            UpdateAssociatedPaymentAmount();
        }

        /// <summary>
        /// Called when the user changes the supplier
        /// </summary>        
        /// <param name="supplierID">Selected supplier id</param>
        public void ChangeSupplier(int supplierID)
        {
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            supplierPayment.FK_APSupplierID = supplierID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                APSuppliersController objSuppliersController = new APSuppliersController();
                APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierID);
                if (supplier != null)
                {
                    //supplierPayment.FK_GECurrencyID = supplier.FK_GECurrencyID;
                }
            }
            UpdateDocumentEntries();
        }

        /// <summary>
        /// Called when user changes the currency of the supplier payment
        /// </summary>
        /// <param name="currencyID">Target currency id</param>
        public void ChangeCurrency(int currencyID)
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            objSupplierPaymentsInfo.FK_GECurrencyID = currencyID;
            GECurrencyExchangeRatesController objCurrencyExchangeRatesController = new GECurrencyExchangeRatesController();
            ExchangeWayLookupEdit lke = (ExchangeWayLookupEdit)Controls[SupplierPaymentModule.ExchangeWayLookupEditName];
            decimal exchangeRateValue = objCurrencyExchangeRatesController.GetCurrencyExchangeRateByCurrencyIDAndDate(currencyID, objSupplierPaymentsInfo.APSupplierPaymentDate);
            if (exchangeRateValue > 0)
            {
                objSupplierPaymentsInfo.APSupplierPaymentExchangeRate = exchangeRateValue;
            }
            if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                if (objSupplierPaymentsInfo.APSupplierPaymentExchangeRate > 0)
                    objSupplierPaymentsInfo.APSupplierPaymentAssPostingExchangeRate = objSupplierPaymentsInfo.APSupplierPaymentExchangeRate;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
            lke.InitDataSource(objSupplierPaymentsInfo.FK_GECurrencyID);
        }

        /// <summary>
        /// Called when user changes the exchange info of the associated payment
        /// </summary>
        public void ChangeAssociatedExchangeInfo()
        {
            if (!Toolbar.IsNullOrNoneAction())
                UpdateAssociatedPaymentAmount();
        }

        /// <summary>
        /// Called when user changes the curreny of the associated payment
        /// </summary>
        /// <param name="associatedCurrencyID">Target associated currency id</param>
        public void ChangeAssociatedCurrency(int associatedCurrencyID)
        {
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            objSupplierPaymentsInfo.FK_GEAssCurrencyID = associatedCurrencyID;
            if (objSupplierPaymentsInfo.FK_GEAssCurrencyID > 0)
            {
                if (objSupplierPaymentsInfo.FK_GEAssCurrencyID == objSupplierPaymentsInfo.FK_GECurrencyID)
                {
                    objSupplierPaymentsInfo.APSupplierPaymentAssPostingExchangeRate = objSupplierPaymentsInfo.APSupplierPaymentExchangeRate;
                    objSupplierPaymentsInfo.APSupplierPaymentAssExchangeRate = objSupplierPaymentsInfo.APSupplierPaymentExchangeRate;
                }
                else
                {
                    decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(associatedCurrencyID, objSupplierPaymentsInfo.APSupplierPaymentDate);
                    objSupplierPaymentsInfo.APSupplierPaymentAssExchangeRate = dCurrencyExchangeRate > 0 ? dCurrencyExchangeRate : 1;
                }
                objSupplierPaymentsInfo.APSupplierPaymentAssExchangeWay = string.Format("{0}{1}", objSupplierPaymentsInfo.FK_GEAssCurrencyID, objSupplierPaymentsInfo.FK_GECurrencyID);
                UpdateAssociatedPaymentAmount();
            }
        }

        /// <summary>
        /// Check whether the selected owing invoices is valid
        /// </summary>
        /// <returns>True if valid, otherwise false</returns>
        public bool CheckForValidOwingInvoices()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            if (!entity.OwingInvoiceInList.Exists(i => i.Selected == true))
            {
                MessageBox.Show(SupplierPaymentLocalizedResources.ChooseOwingInvoiceMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            int supplierID = 0;
            APInvoiceInsInfo firstOwingInvoice = entity.OwingInvoiceInList.Where(i => i.Selected == true).FirstOrDefault();
            if (firstOwingInvoice != null)
            {
                supplierID = firstOwingInvoice.FK_APSupplierID;
            }
            if (supplierID > 0 && entity.OwingInvoiceInList.Exists(i => i.Selected == true && i.FK_APSupplierID != supplierID))
            {
                MessageBox.Show(SupplierPaymentLocalizedResources.SelectedInvoicesNotSameSupplierMessage,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #region Accounting
        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.PhieuChi.ToString());
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            if (supplierPayment.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.UyNhiemChi.ToString());
            }
            else if (supplierPayment.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.NghiepVuKhac.ToString());
            }
            else if (supplierPayment.APPaymentMethodCombo == PaymentMethod.Clearing.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.CanTru.ToString());
            }
            return documentTypeID;
        }

        public override void GenerateAccountingData()
        {
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            if (supplierPayment.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.PhieuChi.ToString() });
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.TraTienNCC.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
            else if (supplierPayment.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.UyNhiemChi.ToString() });
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.TraTienNCC.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
            else if (supplierPayment.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.NghiepVuKhac.ToString() });
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.CanTruCongNoNCC.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
            else if (supplierPayment.APPaymentMethodCombo == PaymentMethod.Clearing.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.CanTru.ToString() });
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.CanTru.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
        }

        protected override void UpdateDocumentEntries()
        {
            GenerateAccountingData();
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objSupplierPaymentsInfo.FK_ACObjectID, objSupplierPaymentsInfo.ACObjectType);
            ACObjectsInfo objObjectsInfo2 = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objSupplierPaymentsInfo.FK_ACAssObjectID, objSupplierPaymentsInfo.APAssObjectType);

            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objSupplierPaymentsInfo.FK_GECurrencyID);

            int creditAccountID = 0;
            if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString() && objSupplierPaymentsInfo.FK_CSCashFundID > 0)
            {
                CSCashFundsInfo cashFunds = (CSCashFundsInfo)(new CSCashFundsController()).GetObjectByID(objSupplierPaymentsInfo.FK_CSCashFundID);
                if (cashFunds != null)
                {
                    creditAccountID = cashFunds.FK_ACAcountID;
                }
            }
            else
            {
                if (objSupplierPaymentsInfo.FK_CSCompanyBankID > 0)
                {
                    CSCompanyBanksInfo companyBank = (CSCompanyBanksInfo)(new CSCompanyBanksController()).GetObjectByID(objSupplierPaymentsInfo.FK_CSCompanyBankID);
                    if (companyBank != null)
                    {
                        creditAccountID = companyBank.FK_ACAcountID;
                    }
                }
                else if (objSupplierPaymentsInfo.FK_ACLoanReceiptID > 0)
                {
                    ACLoanReceiptsInfo loanReceiptsInfo = (new ACLoanReceiptsController()).GetLoanReceiptByID(objSupplierPaymentsInfo.FK_ACLoanReceiptID);
                    if (loanReceiptsInfo != null)
                    {
                        creditAccountID = loanReceiptsInfo.FK_ACAccountID;
                    }
                }
            }



            ACAccountsController objAccountsController = new ACAccountsController();

            #region Tinh chenh lech ti gia
            decimal tienLai = 0;
            decimal tienLo = 0;
            decimal tienConLai = 0;
            decimal tienConLaiQD = 0;
            decimal tyGiaTB = 0;
            decimal tyGiaTT = 0;
            if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString()
                || objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                if (objCurrenciesInfo != null)
                {
                    if (objCurrenciesInfo.GECurrencyNo != CurrencyNo.VND.ToString()
                        || objSupplierPaymentsInfo.APSupplierPaymentExchangeRate != 1)
                    {
                        List<APPaymentProposalPaymentsInfo> invoiceinList = entity.PaymentProposalList.Where(a => a.FK_APInvoiceInID > 0).ToList();
                        APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                        APInvoiceInTransactionsController objPOPTIIDController = new APInvoiceInTransactionsController();
                        List<APInvoiceInTransactionsInfo> pOPaymentTimeInvoiceInDetails = null;
                        APInvoiceInTransactionsInfo objPOPaymentTimeInvoiceInDetailsInfo = null;
                        if (invoiceinList != null && invoiceinList.Count > 0)
                        {
                            invoiceinList.ForEach(a =>
                            {
                                pOPaymentTimeInvoiceInDetails = objPOPTIIDController.GetClearingInfoByInvoiceInID(a.FK_APInvoiceInID, a.APPaymentProposalPaymentInvoiceInNo, objSupplierPaymentsInfo.FK_ACObjectID, objSupplierPaymentsInfo.ACObjectType);
                                objPOPaymentTimeInvoiceInDetailsInfo = objPOPTIIDController.GetInvoiceInInfoByInvoiceInID(a.FK_APInvoiceInID, a.APPaymentProposalPaymentInvoiceInNo, objSupplierPaymentsInfo.FK_ACObjectID, objSupplierPaymentsInfo.ACObjectType) as APInvoiceInTransactionsInfo;

                                if (objPOPaymentTimeInvoiceInDetailsInfo != null)
                                {
                                    tienConLai = objPOPaymentTimeInvoiceInDetailsInfo.APInvoiceInAmount - pOPaymentTimeInvoiceInDetails.Sum(o => o.APInvoiceInPaymentAmount);
                                    tienConLaiQD = objPOPaymentTimeInvoiceInDetailsInfo.APInvoiceInAmountExchange - pOPaymentTimeInvoiceInDetails.Sum(o => o.APInvoiceInPaymentAmountExchange);
                                    if (tienConLai > 0)
                                    {
                                        tyGiaTB = tienConLaiQD / tienConLai;
                                    }
                                    tyGiaTT = Math.Min(tyGiaTB, objSupplierPaymentsInfo.APSupplierPaymentExchangeRate);
                                    if (tyGiaTB > objSupplierPaymentsInfo.APSupplierPaymentExchangeRate)
                                    {
                                        tienLai += a.APPaymentProposalPaymentAmount * Math.Abs(tyGiaTB - objSupplierPaymentsInfo.APSupplierPaymentExchangeRate);
                                    }
                                    if (tyGiaTB < objSupplierPaymentsInfo.APSupplierPaymentExchangeRate)
                                    {
                                        tienLo += a.APPaymentProposalPaymentAmount * Math.Abs(tyGiaTB - objSupplierPaymentsInfo.APSupplierPaymentExchangeRate);
                                    }
                                }
                            });
                            if (tienLai > 0)
                            {
                                ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                                ACEntryTypesInfo objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.ChenhLechLai);
                                if (objEntryTypesInfo != null)
                                {
                                    ACDocumentEntrysInfo objDocumentEntrysInfo = new ACDocumentEntrysInfo();
                                    objDocumentEntrysInfo.FK_ACEntryTypeID = objEntryTypesInfo.ACEntryTypeID;
                                    objDocumentEntrysInfo.ACEntryTypeName = objEntryTypesInfo.ACEntryTypeName;
                                    objDocumentEntrysInfo.ACDocumentEntryDesc = objEntryTypesInfo.ACEntryTypeDesc;
                                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLai);
                                    if (entry == null)
                                    {
                                        entity.DocumentEntryList.Add(objDocumentEntrysInfo);
                                    }
                                }
                            }
                            else
                            {
                                ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLai);
                                if (entry != null)
                                {
                                    entity.DocumentEntryList.Remove(entry);
                                }
                            }
                            if (tienLo > 0)
                            {
                                ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                                ACEntryTypesInfo objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.ChenhLechLo);
                                if (objEntryTypesInfo != null)
                                {
                                    ACDocumentEntrysInfo objDocumentEntrysInfo = new ACDocumentEntrysInfo();
                                    objDocumentEntrysInfo.FK_ACEntryTypeID = objEntryTypesInfo.ACEntryTypeID;
                                    objDocumentEntrysInfo.ACEntryTypeName = objEntryTypesInfo.ACEntryTypeName;
                                    objDocumentEntrysInfo.ACDocumentEntryDesc = objEntryTypesInfo.ACEntryTypeDesc;
                                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLo);
                                    if (entry == null)
                                    {
                                        entity.DocumentEntryList.Add(objDocumentEntrysInfo);
                                    }
                                }
                            }
                            else
                            {
                                ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLo);
                                if (entry != null)
                                {
                                    entity.DocumentEntryList.Remove(entry);
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region Chiết khấu thanh toán
            if(entity.PaymentProposalList.FirstOrDefault(o => o.APPaymentProposalPaymentDiscountFix > 0) != null)
            {
                ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                ACEntryTypesInfo objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.ChietKhauThanhToan);
                if (objEntryTypesInfo != null)
                {
                    ACDocumentEntrysInfo objDocumentEntrysInfo = new ACDocumentEntrysInfo();
                    objDocumentEntrysInfo.FK_ACEntryTypeID = objEntryTypesInfo.ACEntryTypeID;
                    objDocumentEntrysInfo.ACEntryTypeName = objEntryTypesInfo.ACEntryTypeName;
                    objDocumentEntrysInfo.ACDocumentEntryDesc = objEntryTypesInfo.ACEntryTypeDesc;
                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChietKhauThanhToan);
                    if (entry == null)
                    {
                        entity.DocumentEntryList.Add(objDocumentEntrysInfo);
                    }
                }
            }    
            #endregion
            if (creditAccountID != 0)
                entity.PaymentProposalList.ForEach(p => p.FK_ACCreditAccountID = creditAccountID);

            APPaymentProposalPaymentsInfo objPaymentProposalPaymentsInfo = entity.PaymentProposalList.Where(p => p.FK_ACCreditAccountID > 0).FirstOrDefault();
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.TraTienNCC.ToString())
                {
                    entry.FK_ACCreditAccountID = creditAccountID;
                    if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountPurchaseID != 0)
                    {
                        entry.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
                    }
                }
                if (entry.ACEntryTypeName == AccEntryType.CanTruCongNoNCC.ToString())
                {
                    if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountPurchaseID != 0)
                    {
                        entry.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
                    }
                    if (objPaymentProposalPaymentsInfo != null)
                    {
                        entry.FK_ACCreditAccountID = objPaymentProposalPaymentsInfo.FK_ACCreditAccountID;
                    }
                    else if (objObjectsInfo2 != null && objObjectsInfo2.FK_ACAccountSaleID != 0)
                    {
                        entry.FK_ACCreditAccountID = objObjectsInfo2.FK_ACAccountSaleID;
                    }

                }
                if (entry.ACEntryTypeName == AccEntryType.TraTienNCC.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.CanTruCongNoNCC.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.CanTru.ToString())
                {
                    entry.ACDocumentEntryAmount = entity.PaymentProposalList.Sum(i => i.APPaymentProposalPaymentAmount);
                    entry.ACDocumentEntryAmount += entity.PaymentProposalList.Sum(i => i.APPaymentProposalPaymentDepositAmount);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objSupplierPaymentsInfo.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objSupplierPaymentsInfo.APSupplierPaymentExchangeRate;
                    if (tienLo > 0 || tienLai > 0)
                    {
                        entry.ACDocumentEntryExchangeAmount = tyGiaTT * entry.ACDocumentEntryAmount;
                    }
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }

                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentEntrysInfo defaultDocumentEntrysInfo;
                if (entry.ACEntryTypeName == AccEntryType.ChenhLechLai.ToString())
                {
                    defaultDocumentEntrysInfo = objDocumentEntrysController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.ChenhLechTyGia.ToString(), AccEntryType.ChenhLechLai.ToString());
                    if (defaultDocumentEntrysInfo != null)
                    {
                        entry.FK_ACCreditAccountID = defaultDocumentEntrysInfo.FK_ACCreditAccountID;
                    }
                    else if (objPaymentProposalPaymentsInfo != null)
                    {
                        entry.FK_ACCreditAccountID = objPaymentProposalPaymentsInfo.FK_ACCreditAccountID;
                    }

                    if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountPurchaseID != 0)
                    {
                        entry.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
                    }
                    entry.ACDocumentEntryAmount = 0;
                    entry.ACDocumentEntryExchangeAmount = tienLai;
                    entry.ACDocumentEntryDebitExchangeAmount = tienLai;
                }
                if (entry.ACEntryTypeName == AccEntryType.ChenhLechLo.ToString())
                {
                    defaultDocumentEntrysInfo = objDocumentEntrysController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.ChenhLechTyGia.ToString(), AccEntryType.ChenhLechLo.ToString());
                    if (defaultDocumentEntrysInfo != null)
                    {
                        entry.FK_ACDebitAccountID = defaultDocumentEntrysInfo.FK_ACDebitAccountID;
                    }
                    else if (objPaymentProposalPaymentsInfo != null && objPaymentProposalPaymentsInfo.FK_ACDebitAccountID > 0)
                    {
                        entry.FK_ACDebitAccountID = objPaymentProposalPaymentsInfo.FK_ACDebitAccountID;
                    }
                    entry.FK_ACCreditAccountID = creditAccountID;
                    entry.ACDocumentEntryAmount = 0;
                    entry.ACDocumentEntryExchangeAmount = tienLo;
                    entry.ACDocumentEntryCreditExchangeAmount = tienLo;
                }
                if (entry.ACEntryTypeName == AccEntryType.ChietKhauThanhToan.ToString())
                {
                    defaultDocumentEntrysInfo = objDocumentEntrysController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.MuaHangCongNoNhapKhau.ToString(), AccEntryType.ChietKhauThanhToan.ToString());
                    if (defaultDocumentEntrysInfo != null)
                    {
                        entry.FK_ACCreditAccountID = defaultDocumentEntrysInfo.FK_ACCreditAccountID;
                    }
                    else if (objPaymentProposalPaymentsInfo != null)
                    {
                        entry.FK_ACCreditAccountID = objPaymentProposalPaymentsInfo.FK_ACCreditAccountID;
                    }

                    if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountPurchaseID != 0)
                    {
                        entry.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
                    }                    
                    entry.ACDocumentEntryAmount = entity.PaymentProposalList.Sum(i => i.APPaymentProposalPaymentDiscountFix);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objSupplierPaymentsInfo.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objSupplierPaymentsInfo.APSupplierPaymentExchangeRate;
                    if (tienLo > 0 || tienLai > 0)
                    {
                        entry.ACDocumentEntryExchangeAmount = tyGiaTT * entry.ACDocumentEntryAmount;
                    }
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }
            GeneratePaymentDocumentData();
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Utility Functions
        public static void TakePayment(APOpenDocumentsInfo objOpenDocumentsInfo, decimal totalAmount)
        {
            if (objOpenDocumentsInfo.APOpenDocumentID > 0)
            {
                APSupplierPaymentsInfo objSupplierPaymentsInfo = CreateSupplierPayments(objOpenDocumentsInfo.FK_APSupplierID, totalAmount);
                if (objSupplierPaymentsInfo.APSupplierPaymentID > 0)
                {
                    APDocumentPaymentsInfo objDocumentPaymentsInfo = CreateDocumentPayments(objOpenDocumentsInfo, objSupplierPaymentsInfo, totalAmount);
                }
            }
        }

        public static APSupplierPaymentsInfo CreateSupplierPayments(int supplierID, decimal totalAmount)
        {
            APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
            APSupplierPaymentsInfo objSupplierPaymentsInfo = new APSupplierPaymentsInfo();
            objSupplierPaymentsInfo.FK_APSupplierID = supplierID;
            objSupplierPaymentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSupplierPaymentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objSupplierPaymentsInfo.AACreatedDate = DateTime.Now;
            objSupplierPaymentsInfo.APSupplierPaymentDate = DateTime.Now;
            objSupplierPaymentsInfo.APSupplierPaymentTotalAmount = totalAmount;
            objSupplierPaymentsController.CreateObject(objSupplierPaymentsInfo);
            return objSupplierPaymentsInfo;
        }

        public static APDocumentPaymentsInfo CreateDocumentPayments(APOpenDocumentsInfo objOpenDocumentsInfo, APSupplierPaymentsInfo objSupplierPaymentsInfo, decimal totalAmount)
        {
            APDocumentPaymentsController objDocumentPaymentsController = new APDocumentPaymentsController();
            APDocumentPaymentsInfo objDocumentPaymentsInfo = new APDocumentPaymentsInfo();

            objDocumentPaymentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objDocumentPaymentsInfo.AACreatedDate = DateTime.Now;
            objDocumentPaymentsInfo.APDocumentPaymentDate = DateTime.Now;
            objDocumentPaymentsInfo.FK_APOpenDocumentID = objOpenDocumentsInfo.APOpenDocumentID;
            objDocumentPaymentsInfo.FK_APSupplierPaymentID = objSupplierPaymentsInfo.APSupplierPaymentID;
            objDocumentPaymentsInfo.APDocumentPaymentAmount = totalAmount;
            objDocumentPaymentsController.CreateObject(objDocumentPaymentsInfo);
            return objDocumentPaymentsInfo;
        }

        /// <summary>
        /// Create document payment detail
        /// </summary>
        /// <param name="objOpenDocumentsInfo">Info of open document</param>
        /// <param name="objSupplierPaymentsInfo">Info of supplier payment</param>
        /// <param name="objDocumentPaymentsInfo">Info of document payment</param>
        /// <param name="lstPaymentDetails">Payment detail list</param>
        public static void CreateSupplierPaymentDetails(APOpenDocumentsInfo objOpenDocumentsInfo, APSupplierPaymentsInfo objSupplierPaymentsInfo, APDocumentPaymentsInfo objDocumentPaymentsInfo, BOSList<APSupplierPaymentDetailsInfo> lstPaymentDetails)
        {
            APSupplierPaymentDetailsController objSupplierPaymentDetailsController = new APSupplierPaymentDetailsController();
            foreach (APSupplierPaymentDetailsInfo objSupplierPaymentDetailsInfo in lstPaymentDetails)
            {
                objSupplierPaymentDetailsInfo.FK_APSupplierPaymentID = objSupplierPaymentsInfo.APSupplierPaymentID;
                objSupplierPaymentDetailsController.CreateObject(objSupplierPaymentDetailsInfo);
            }
        }
        #endregion

        public void NewFromPaymentProposal()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return;
            }
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;

            APPaymentProposalItemsController objPaymentProposalItemsController = new APPaymentProposalItemsController();
            List<APPaymentProposalItemsInfo> paymentProposalItemsList = objPaymentProposalItemsController.GetPaymentProposalItemForPayment();

            if (objSupplierPaymentsInfo.FK_ACObjectID > 0)
            {
                paymentProposalItemsList = paymentProposalItemsList.Where(o => o.FK_ACObjectID == objSupplierPaymentsInfo.FK_ACObjectID && o.APObjectType == objSupplierPaymentsInfo.ACObjectType).ToList();
            }

            guiFind<APPaymentProposalItemsInfo> guiFind = new guiFind<APPaymentProposalItemsInfo>(TableName.APPaymentProposalItemsTableName, paymentProposalItemsList, this, true);
            guiFind.Module = this;
        Stamp:
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                if (guiFind.SelectedObjects.Count() > 0)
                {
                    APPaymentProposalItemsInfo invalidPaymentProposalItem = guiFind.SelectedObjects.FirstOrDefault(t => t.ACObjectName != guiFind.SelectedObjects[0].ACObjectName);
                    if (invalidPaymentProposalItem != null)
                    {
                        MessageBox.Show(SupplierPaymentLocalizedResources.ErrorObject,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                        goto Stamp;
                    }

                    invalidPaymentProposalItem = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_GECurrencyID != guiFind.SelectedObjects[0].FK_GECurrencyID);
                    if (invalidPaymentProposalItem != null)
                    {
                        MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        goto Stamp;
                    }

                    objSupplierPaymentsInfo.FK_GECurrencyID = guiFind.SelectedObjects[0].FK_GECurrencyID;
                    decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(objSupplierPaymentsInfo.FK_GECurrencyID, objSupplierPaymentsInfo.APSupplierPaymentDate);
                    objSupplierPaymentsInfo.APSupplierPaymentExchangeRate = dCurrencyExchangeRate > 0 ? dCurrencyExchangeRate : 1;
                    objSupplierPaymentsInfo.APSupplierPaymentProject = String.Join(", ", guiFind.SelectedObjects.Select(o => o.APPaymentProposalProject).Distinct().ToArray());
                    objSupplierPaymentsInfo.APSupplierPaymentDesc = String.Join("; ", guiFind.SelectedObjects.Select(o => o.APPaymentProposalDesc).Distinct().ToArray());
                    if (objSupplierPaymentsInfo.FK_ACAssObjectID == 0)
                    {
                        objSupplierPaymentsInfo.FK_ACObjectID = guiFind.SelectedObjects[0].FK_ACAssObjectID;
                        objSupplierPaymentsInfo.ACObjectType = guiFind.SelectedObjects[0].APAssObjectType;
                        objSupplierPaymentsInfo.ACObjectAccessKey = objSupplierPaymentsInfo.FK_ACObjectID + ";" + objSupplierPaymentsInfo.ACObjectType;
                        if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
                            objSupplierPaymentsInfo.APSupplierPaymentObjectReceiptName = guiFind.SelectedObjects[0].ACObjectName;
                    }
                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objSupplierPaymentsInfo.FK_ACObjectID, objSupplierPaymentsInfo.ACObjectType);

                    int creditAccountID = 0;
                    if(objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString() && objSupplierPaymentsInfo.FK_CSCashFundID > 0)
                    {
                        CSCashFundsInfo cashFunds = (CSCashFundsInfo)(new CSCashFundsController()).GetObjectByID(objSupplierPaymentsInfo.FK_CSCashFundID);
                        if(cashFunds != null)
                        {
                            creditAccountID = cashFunds.FK_ACAcountID;
                        }    
                    }
                    else
                    {
                        if(objSupplierPaymentsInfo.FK_CSCompanyBankID > 0)
                        {
                            CSCompanyBanksInfo companyBank = (CSCompanyBanksInfo)(new CSCompanyBanksController()).GetObjectByID(objSupplierPaymentsInfo.FK_CSCompanyBankID);
                            if (companyBank != null)
                            {
                                creditAccountID = companyBank.FK_ACAcountID;
                            }
                        }
                        else if (objSupplierPaymentsInfo.FK_ACLoanReceiptID > 0)
                        {
                            ACLoanReceiptsInfo loanReceiptsInfo = (new ACLoanReceiptsController()).GetLoanReceiptByID(objSupplierPaymentsInfo.FK_ACLoanReceiptID);
                            if (loanReceiptsInfo != null)
                            {
                                creditAccountID = loanReceiptsInfo.FK_ACAccountID;
                            }
                        }
                    }

                    APPaymentProposalsController objPaymentProposalsController = new APPaymentProposalsController();
                    APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)objPaymentProposalsController.GetObjectByID(guiFind.SelectedObjects[0].FK_APPaymentProposalID);
                    if (objPaymentProposalsInfo != null)
                    {
                        objSupplierPaymentsInfo.FK_PMProjectID = objPaymentProposalsInfo.FK_PMProjectID;
                        ChangeListAccountBank(objPaymentProposalsInfo.FK_ACListAccountBankID);
                    }
                    APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                    APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                    APPOPaymentTimeInvoiceInDetailsController objDetailsController = new APPOPaymentTimeInvoiceInDetailsController();
                    APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
                    List<APPaymentProposalPaymentsInfo> listPayments = new List<APPaymentProposalPaymentsInfo>();
                    string invoiceVATNo = string.Empty;
                    foreach (APPaymentProposalItemsInfo item in guiFind.SelectedObjects)
                    {
                        if (entity.PaymentProposalList.Select(o => o.FK_APPaymentProposalItemID).Contains(item.APPaymentProposalItemID))
                            return;
                        APPaymentProposalPaymentsInfo proposalItem = new APPaymentProposalPaymentsInfo();
                        BOSUtil.CopyObject(item, proposalItem);
                        proposalItem.APPaymentProposalPaymentRemainAmount = item.APPaymentProposalItemRemainAmount;
                        proposalItem.APPaymentProposalPaymentAmount = item.APPaymentProposalItemRemainAmount - item.APPaymentProposalItemDiscountFix;
                        proposalItem.APPaymentProposalPaymentID = 0;
                        proposalItem.APPaymentProposalPaymentApproveStatus = "New";
                        proposalItem.FK_APPaymentProposalItemID = item.APPaymentProposalItemID;
                        proposalItem.FK_APPurchaseOrderID = item.FK_APPurchaseOrderID;
                        proposalItem.FK_APPurchaseOrderPaymentTimeID = item.FK_APPurchaseOrderPaymentTimeID;
                        proposalItem.APPaymentProposalPaymentDate = item.APPaymentProposalInvoiceInDate;
                        proposalItem.APPaymentProposalPaymentDepositAmount = 0;
                        proposalItem.APPaymentProposalPaymentPaidAmount = item.APPaymentProposalItemPaidAmount;
                        proposalItem.APPaymentProposalPaymentPurchaseOrderNo = item.APPaymentProposalItemPurchaseOrderNo;
                        proposalItem.APPaymentProposalPaymentInvoiceInNo = item.APPaymentProposalItemInvoiceInNo;
                        proposalItem.APPaymentProposalPaymentHTT = item.ARSaleOrderPaymentTimeDueDate;
                        proposalItem.APPurchaseOrderPaymentTimeType = item.APPaymentProposalItemType;
                        proposalItem.APInvoiceInExchangeRate = item.APPaymentProposalItemExchangeRate;
                        proposalItem.APPaymentProposalPaymentDiscountFix = item.APPaymentProposalItemDiscountFix;
                        proposalItem.FK_ACCreditAccountID = creditAccountID;
                        if (objObjectsInfo != null)
                        {
                            proposalItem.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
                        }

                        if (!string.IsNullOrWhiteSpace(item.APInvoiceInSupplierNo) && !invoiceVATNo.Contains(item.APInvoiceInSupplierNo))
                        {
                            invoiceVATNo += string.Format(" {0},", item.APInvoiceInSupplierNo);
                        }

                        if (item.APPaymentProposalItemType == PaymentProposalItemType.PurchaseOrderInvoiceInDetail.ToString())
                        {
                            if ((item.APPaymentProposalItemDepositAmount == 0))
                            {
                                // Tính còn lại của PO = (Sum( (slg - slg Hủy)* Giá) + Thuế - CK) - ( Đã thanh toán = Tiền - còn lại)

                                APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(item.FK_APPurchaseOrderID);
                                List<APPurchaseOrderItemsInfo> poItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemsByPurchaseOrderID(item.FK_APPurchaseOrderID);
                                if (objPurchaseOrdersInfo != null && poItemList != null)
                                {
                                    decimal itemAmount = 0;
                                    decimal poAmount = 0;
                                    decimal itemqty = 0;

                                    foreach (APPurchaseOrderItemsInfo poItem in poItemList)
                                    {
                                        itemqty = (poItem.APPurchaseOrderItemProductQty - poItem.APPurchaseOrderItemProductCanceledQty);
                                        itemAmount = itemqty * poItem.APPurchaseOrderItemProductUnitCost;
                                        itemAmount -= (itemAmount * poItem.APPurchaseOrderItemProductDiscount / 100);
                                        itemAmount += (itemAmount * poItem.APPurchaseOrderItemProductTaxPercent / 100);

                                        poAmount += itemAmount;
                                    }

                                    decimal paymentAmount = 0;
                                    List<APPOPaymentTimeInvoiceInDetailsInfo> detailList = objDetailsController.GetItemByPurchaseOrderID(item.FK_APPurchaseOrderID);
                                    if (detailList != null && detailList.Count > 0)
                                    {
                                        paymentAmount = detailList.Sum(t => (t.APPOPaymentTimeInvoiceInDetailAmount - t.APPOPaymentTimeInvoiceInDetailBalanceDue));
                                    }

                                    decimal POAmount = poAmount - paymentAmount;//Còn lại của PO

                                    decimal amountPercent = item.APPaymentProposalItemProposalAmount / POAmount; //% tỉ lệ

                                    APPurchaseOrderPaymentTimesInfo depositPayment = objPurchaseOrderPaymentTimesController.GetByPurchaeOrderIDAndPaymentType(item.FK_APPurchaseOrderID, PurchaseOrderPaymentTimePaymentType.Deposit.ToString()).FirstOrDefault();
                                    if (depositPayment != null)
                                    {
                                        List<APPaymentProposalItemsInfo> paymentProposalItemList = objPaymentProposalItemsController.GetItemByPurchaseOrderIDAndType(item.FK_APPurchaseOrderID, PaymentProposalItemType.PurchaseOrderInvoiceInDetail.ToString());
                                        decimal depositUsed = 0;
                                        if (paymentProposalItemList != null)
                                        {
                                            depositUsed = paymentProposalItemList.Sum(t => t.APPaymentProposalItemDepositAmount);
                                        }
                                        proposalItem.APPaymentProposalPaymentDepositAmount = amountPercent * (depositPayment.ARSaleOrderPaymentTimeDepositBalance - depositUsed);
                                        proposalItem.APPaymentProposalPaymentAmount -= proposalItem.APPaymentProposalPaymentDepositAmount;
                                    }
                                }
                            }
                        }
                        listPayments.Add(proposalItem);
                    }

                    if (!string.IsNullOrWhiteSpace(invoiceVATNo))
                    {
                        objSupplierPaymentsInfo.APSupplierPaymentDesc = objSupplierPaymentsInfo.APSupplierPaymentDesc.Replace("{1}", invoiceVATNo.TrimEnd(','));
                    }

                    listPayments.ForEach(o => o.APPaymentProposalPaymentPercent = o.APPaymentProposalPaymentRemainAmount <= 0 ? 0 : ((o.APPaymentProposalPaymentAmount + o.APPaymentProposalPaymentDiscountFix)/ (o.APPaymentProposalPaymentRemainAmount)) * 100);

                    if (objSupplierPaymentsInfo.APSupplierPaymentID > 0)
                    {
                        entity.PaymentProposalList.AddRange(listPayments);
                    }
                    else
                    {
                        entity.PaymentProposalList.Invalidate(listPayments);
                    }

                    entity.PaymentProposalList.GridControl.RefreshDataSource();
                    entity.PaymentProposalList.GridControl.Visible = true;
                    entity.UpdateMainObjectBindingSource();
                    UpdateTotalAmount();
                }
                else
                {
                    goto Stamp;
                }
            }
        }

        public override void InvalidateToolbar()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
            ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
            ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
            ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApprove, false);
            ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApproveSupplierPayment, false);
            if (objSupplierPaymentsInfo.APSupplierPaymentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApproveSupplierPayment, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton("CancelDocument", true);
                CompanyBankLookupEditControl.Properties.ReadOnly = false;
                LoanReceiptLookupEditControl.Properties.ReadOnly = false;
                CashFundLookupEditControl.Properties.ReadOnly = false;
                if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Cash.ToString())
                {
                    CompanyBankLookupEditControl.Properties.ReadOnly = true;
                    LoanReceiptLookupEditControl.Properties.ReadOnly = true;
                }    
                    
                if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
                    CashFundLookupEditControl.Properties.ReadOnly = true;
                if (objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString() || objSupplierPaymentsInfo.APPaymentMethodCombo == PaymentMethod.Clearing.ToString())
                {
                    CashFundLookupEditControl.Properties.ReadOnly = true;
                    CompanyBankLookupEditControl.Properties.ReadOnly = false;
                    LoanReceiptLookupEditControl.Properties.ReadOnly = false;
                }
                if (objSupplierPaymentsInfo.APSupplierPaymentStatus == SupplierPaymentStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApproveSupplierPayment, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApprove, true);
                    //ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
                if (objSupplierPaymentsInfo.APSupplierPaymentStatus == SupplierPaymentStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApprove, false);
                    //ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                }
                if (objSupplierPaymentsInfo.APSupplierPaymentStatus == SupplierPaymentStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApproveSupplierPayment, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(SupplierPaymentModule.ToolbarButtonApprove, false);
                    //ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);

                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        objSupplierPaymentsInfo.APSupplierPaymentPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        objSupplierPaymentsInfo.APSupplierPaymentPostedStatus == PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", true);
                }
            }
            base.InvalidateToolbar();
        }

        public void LoadInvoiceByObject(string ObjectAccessKey)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            GridView gridView = (GridView)PaymentProposalPaymentGridControl.MainView;

            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            ACObjectsController objObjectsController = new ACObjectsController();
            if (!string.IsNullOrEmpty(ObjectAccessKey))
            {
                objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(ObjectAccessKey);
                mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
            }
            else
            {
                mainObject.FK_ACObjectID = 0;
            }
            if (mainObject.APPaymentMethodCombo == PaymentMethod.Clearing.ToString())
            {
                gridView.Columns["FK_APInvoiceInID"].OptionsColumn.AllowEdit = true;
                gridView.Columns["FK_APInvoiceInID"].Visible = true;
            }
            else
            {
                gridView.Columns["FK_APInvoiceInID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["FK_APInvoiceInID"].Visible = false;
            }
        }

        public void ActionNewToClearing()
        {
            CreateClearing = true;
            ActionNew();
            APSupplierPaymentsInfo supplierPayment = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            supplierPayment.APPaymentMethodCombo = PaymentMethod.Clearing.ToString();
            CashFundLookupEditControl.Properties.ReadOnly = true;
            CompanyBankLookupEditControl.Properties.ReadOnly = true;
            LoanReceiptLookupEditControl.Properties.ReadOnly = true;
            LoadInvoiceByObject(supplierPayment.ACObjectAccessKey);
            CreateClearing = false;
        }

        public void ChangeAssObject(string acAssObjectAccessKey)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            objSupplierPaymentInfo.ACAssObjectAccessKey = acAssObjectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acAssObjectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objSupplierPaymentInfo.FK_ACAssObjectID = objObjectsInfo.ACObjectID;
                objSupplierPaymentInfo.APAssObjectType = objObjectsInfo.ACObjectType;
                objSupplierPaymentInfo.ACAssObjectName = objObjectsInfo.ACObjectName;
                if (objObjectsInfo.FK_ACAccountSaleID > 0)
                {
                    entity.PaymentProposalList.ForEach(p => p.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID);
                    entity.SupplierPaymentDocumentList.ForEach(p => p.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID);
                }
                ACObjectsInfo obj = objObjectsController.GetObjectByAccessKey(acAssObjectAccessKey);
                if (obj != null)
                {
                    if (obj.ACObjectType == ObjectType.Supplier.ToString())
                    {
                        APSuppliersController objSuppliersController = new APSuppliersController();
                        APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(obj.ACObjectID);
                        if (supplier != null)
                        {
                            objSupplierPaymentInfo.FK_GEAssCurrencyID = supplier.FK_GECurrencyID;
                        }

                    }
                    else if (obj.ACObjectType == ObjectType.Customer.ToString())
                    {
                        ARCustomersController objcustomerController = new ARCustomersController();
                        ARCustomersInfo customer = (ARCustomersInfo)objcustomerController.GetObjectByID(obj.ACObjectID);
                        if (customer != null)
                        {
                            objSupplierPaymentInfo.FK_GEAssCurrencyID = customer.FK_GECurrencyID;
                        }
                    }
                    if (objSupplierPaymentInfo.FK_GEAssCurrencyID == 0)
                    {
                        objSupplierPaymentInfo.FK_GEAssCurrencyID = objSupplierPaymentInfo.FK_GECurrencyID;
                        objSupplierPaymentInfo.APSupplierPaymentAssExchangeRate = objSupplierPaymentInfo.APSupplierPaymentExchangeRate;
                    }
                }
                entity.PaymentProposalList.GridControl.RefreshDataSource();
                UpdateDocumentEntries();
            }
        }

        public bool ChangeObject(string acObjectAccessKey)
        {
            APSupplierPaymentsInfo objSupplierPaymentInfo = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            if (entity.PaymentProposalList.Count > 0)
            {
                MessageBox.Show("Không thể thay đổi đối tượng!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return false;
            }
            
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acObjectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            objSupplierPaymentInfo.ACObjectAccessKey = acObjectAccessKey;            
            ACListAccountBanksController objListAccountBanksController = new ACListAccountBanksController();
            ACListAccountBanksInfo objListAccountBanksInfo = objListAccountBanksController.GetAccountBankByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objListAccountBanksInfo != null)
            {
                objSupplierPaymentInfo.FK_ACListAccountBankID = objListAccountBanksInfo.ACListAccountBankID;
                objSupplierPaymentInfo.APSupplierPaymentObjectReceiptName = objListAccountBanksInfo.ACListAccountBankAccountHolder;
                objSupplierPaymentInfo.FK_ACObjectID = objListAccountBanksInfo.FK_ACObjectID;
                objSupplierPaymentInfo.ACObjectType = objListAccountBanksInfo.ACObjectType;
                objSupplierPaymentInfo.APSupplierPaymentReceiptAddress = objListAccountBanksInfo.ACListAccountBankObjectAddress;
                objSupplierPaymentInfo.APSupplierPaymentReceiverBankName = objListAccountBanksInfo.ACListAccountBankBranch;
                objSupplierPaymentInfo.APSupplierPaymentReceiverAccount = objListAccountBanksInfo.ACListAccountBankAccount;
                objSupplierPaymentInfo.APSupplierPaymentReceiverBankCode = objListAccountBanksInfo.ACListAccountBankNo;
                if (objObjectsInfo.FK_ACAccountPurchaseID > 0)
                {
                    entity.PaymentProposalList.ForEach(p => p.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID);
                    entity.SupplierPaymentDocumentList.ForEach(p => p.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID);
                }
                entity.PaymentProposalList.GridControl.RefreshDataSource();
                CurrentModuleEntity.UpdateMainObjectBindingSource();
                UpdateDocumentEntries();
            }
            else if (objObjectsInfo != null && objListAccountBanksInfo == null)
            {
                objSupplierPaymentInfo.FK_ACListAccountBankID = 0;
                objSupplierPaymentInfo.APSupplierPaymentObjectReceiptName = objObjectsInfo.ACObjectName;
                objSupplierPaymentInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objSupplierPaymentInfo.ACObjectType = objObjectsInfo.ACObjectType;
                objSupplierPaymentInfo.APSupplierPaymentReceiptAddress = objObjectsInfo.ACObjectDeliveryAddressLine1;
                if (objObjectsInfo.ACObjectType == ObjectType.Supplier.ToString())
                {
                    APSuppliersController objSuppliersController = new APSuppliersController();
                    APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(objObjectsInfo.ACObjectID);
                    if (supplier != null)
                    {
                        objSupplierPaymentInfo.APSupplierPaymentReceiverBankName = supplier.APSupplierBankName;
                        objSupplierPaymentInfo.APSupplierPaymentReceiverAccount = supplier.APSupplierBankAccount1;
                        objSupplierPaymentInfo.APSupplierPaymentReceiverBankCode = supplier.APSupplierBankCode;
                    }
                }
                else if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(objObjectsInfo.ACObjectID);
                    if (customer != null)
                    {
                        objSupplierPaymentInfo.APSupplierPaymentReceiverBankName = customer.ARCustomerBankName;
                        objSupplierPaymentInfo.APSupplierPaymentReceiverAccount = customer.ARCustomerBankAccount1;
                    }
                }
                if (objObjectsInfo.FK_ACAccountPurchaseID > 0)
                {
                    entity.PaymentProposalList.ForEach(p => p.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID);
                    entity.SupplierPaymentDocumentList.ForEach(p => p.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID);
                }
                entity.PaymentProposalList.GridControl.RefreshDataSource();
                CurrentModuleEntity.UpdateMainObjectBindingSource();
                UpdateDocumentEntries();
            }
            else
            {
                objSupplierPaymentInfo.FK_ACObjectID = 0;
                objSupplierPaymentInfo.ACObjectType = string.Empty;
                entity.PaymentProposalList.GridControl.RefreshDataSource();
                UpdateDocumentEntries();
            }
            LoadInvoiceByObject(acObjectAccessKey);
            return true;
        }

        public override bool ActionComplete()
        {
            GenerateAccountingData();
            UpdateDocumentEntries();
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentInfo = (APSupplierPaymentsInfo)entity.MainObject;
            objSupplierPaymentInfo.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            if (objSupplierPaymentInfo.FK_ACLoanReceiptID > 0)
            {
                if (!IsValidAmountLoanReceipt())
                    return false;
            }    
            bool isComplete = base.ActionComplete();
            if (isComplete)
            {
                APPaymentProposalPaymentsController objPaymentProposalPaymentsController = new APPaymentProposalPaymentsController();
                entity.PaymentProposalList.ForEach(o =>
                {
                    o.APPaymentProposalPaymentPaidAmount += (o.APPaymentProposalPaymentAmount + o.APPaymentProposalPaymentDiscountFix);
                    o.APPaymentProposalPaymentRemainAmount -= (o.APPaymentProposalPaymentAmount + o.APPaymentProposalPaymentDiscountFix);
                    objPaymentProposalPaymentsController.UpdateObject(o);
                });
                entity.PaymentProposalList.GridControl.RefreshDataSource();
            }
            return isComplete;
        }
        public override bool ActionCancelComplete()
        {
            if (!CheckLock()) return false;
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            if (mainObject.APSupplierPaymentStatus != SupplierPaymentStatus.Approved.ToString())
                return false;
            base.ActionCancelComplete();

            APPaymentProposalPaymentsController objPaymentProposalPaymentsController = new APPaymentProposalPaymentsController();
            entity.PaymentProposalList.ForEach(o =>
            {
                o.APPaymentProposalPaymentPaidAmount -= (o.APPaymentProposalPaymentAmount + o.APPaymentProposalPaymentDiscountFix);
                o.APPaymentProposalPaymentRemainAmount += (o.APPaymentProposalPaymentAmount + o.APPaymentProposalPaymentDiscountFix);
                objPaymentProposalPaymentsController.UpdateObject(o);
            });
            entity.PaymentProposalList.GridControl.RefreshDataSource();
            ActionUnPosted();
            entity.UpdateReferPaymentData(true);
            return true;
        }
        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                APSupplierPaymentsInfo objSupplierPaymentInfo = (APSupplierPaymentsInfo)entity.MainObject;
                if (objSupplierPaymentInfo.APSupplierPaymentStatus == SupplierPaymentStatus.New.ToString())
                {
                    objSupplierPaymentInfo.APSupplierPaymentStatus = SupplierPaymentStatus.Approved.ToString();
                    objSupplierPaymentInfo.FK_HREmployeeApprovedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                }
                entity.UpdateMainObject();
                ActionComplete();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
            }
        }

        public void ShowPaymentProposalScreen(int paymentProposalID)
        {
            Modules.PaymentProposal.PaymentProposalModule paymentProposalModule;
            if (BOSApp.IsOpenedModule(ModuleName.PaymentProposal))
            {
                paymentProposalModule = (Modules.PaymentProposal.PaymentProposalModule)BOSApp.OpenModules[ModuleName.PaymentProposal];
                paymentProposalModule.ParentScreen.Activate();
            }
            else
                paymentProposalModule = (Modules.PaymentProposal.PaymentProposalModule)BOSApp.ShowModule(ModuleName.PaymentProposal);
            if (paymentProposalModule == null)
                return;

            paymentProposalModule.ActionInvalidate(paymentProposalID);
        }

        private void GeneratePaymentDocumentData()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo objSupplierPaymentInfo = (APSupplierPaymentsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();

            if (objSupplierPaymentInfo.APSupplierPaymentID > 0 && entity.DocumentEntryList.Count == 0)
                return;

            entity.SupplierPaymentDocumentList.Clear();
            entity.DocumentEntryList.ForEach(o =>
            {
                APSupplierPaymentDocumentsInfo objSupplierPaymentDocumentsInfo = new APSupplierPaymentDocumentsInfo()
                {
                    FK_APSupplierPaymentID = objSupplierPaymentInfo.APSupplierPaymentID,
                    FK_ACEntryTypeID = o.FK_ACEntryTypeID,
                    FK_ACDebitAccountID = o.FK_ACDebitAccountID,
                    FK_ACCreditAccountID = o.FK_ACCreditAccountID,
                    FK_ACCostObjectID = o.FK_ACCostObjectID,
                    APSupplierPaymentDocumentDesc = o.ACDocumentEntryDesc,
                    APSupplierPaymentDocumentAmount = o.ACDocumentEntryAmount,
                    APSupplierPaymentDocumentExchangeAmount = o.ACDocumentEntryExchangeAmount,
                    FK_ACUnfinishedConstructionCostID = o.FK_ACUnfinishedConstructionCostID,
                    ACEntryTypeName = o.ACEntryTypeName,
                };
                entity.SupplierPaymentDocumentList.Add(objSupplierPaymentDocumentsInfo);
            });
        }

        public void ChangeExchangeRate()
        {
            UpdateTotalAmount();
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.APPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                if (mainObject.APSupplierPaymentExchangeRate > 0)
                    mainObject.APSupplierPaymentAssPostingExchangeRate = mainObject.APSupplierPaymentExchangeRate;
            }
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;

            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.APSupplierPaymentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.APSupplierPaymentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.APSupplierPaymentID, ModulePostingType.Accounting, ModulePostingType.InvoiceInTrans);
            if (mainObject.FK_ACLoanReceiptID > 0)
            {
                ACLoanReceiptItemsController objLoanReceiptItemsController = new ACLoanReceiptItemsController();
                objLoanReceiptItemsController.InsertLoanReceiptItemByTransactionNo(mainObject.APSupplierPaymentNo, true);
            }
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.APSupplierPaymentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.APSupplierPaymentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.APSupplierPaymentID, ModulePostingType.Accounting, ModulePostingType.InvoiceInTrans);
            if (mainObject.FK_ACLoanReceiptID > 0)
            {
                ACLoanReceiptItemsController objLoanReceiptItemsController = new ACLoanReceiptItemsController();
                objLoanReceiptItemsController.InsertLoanReceiptItemByTransactionNo(mainObject.APSupplierPaymentNo, false);
            }
            InvalidateToolbar();
        }

        public override void ModuleAfterCompleted()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.APSupplierPaymentPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            entity.UpdateReferPaymentData(false);
            entity.SaveAccountingData();
            GLHelper.PostedTransactions(this.Name, mainObject.APSupplierPaymentID, ModulePostingType.Accounting, ModulePostingType.InvoiceInTrans);
            entity.SetPropertyChangeEventLock(true);
            if (mainObject.FK_ACLoanReceiptID > 0)
            {
                ACLoanReceiptItemsController objLoanReceiptItemsController = new ACLoanReceiptItemsController();
                objLoanReceiptItemsController.InsertLoanReceiptItemByTransactionNo(mainObject.APSupplierPaymentNo, true);
            }
            base.ModuleAfterCompleted();
        }

        public void ActionCancelDocument()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
                if (mainObject.APSupplierPaymentPostedStatus == PostedTransactionStatus.Posted.ToString())
                    ActionUnPosted();
                entity.SetPropertyChangeEventLock(false);
                mainObject.APSupplierPaymentStatus = SupplierPaymentStatus.Canceled.ToString();
                entity.UpdateMainObject();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void GetDSForListAccountBankLookUpEditControl()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            if (mainObject.FK_ACObjectID > 0 && mainObject.ACObjectType != string.Empty)
            {
                ACListAccountBanksController objListAccountBanksController = new ACListAccountBanksController();
                List<ACListAccountBanksInfo> listAccountBanks =
                    objListAccountBanksController.GetListByACObject(mainObject.FK_ACObjectID, mainObject.ACObjectType);
                ListAccountBankLookUpEditControl.Properties.DataSource = listAccountBanks;
            }
            else
            {
                ListAccountBankLookUpEditControl.Properties.DataSource = null;
            }
        }

        void InvalidateTabControl(string methodCombo)
        {
            ACTabControl.TabPages[0].PageVisible = true;
            ACTabControl.TabPages[1].PageVisible = false;
            ACTabControl.Visible = true;
            if (methodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                ACTabControl.Visible = true;
                ACTabControl.TabPages[0].PageVisible = true;
                ACTabControl.TabPages[1].PageVisible = false;
            }
            else if (methodCombo == PaymentMethod.OwingExchange.ToString())
            {
                ACTabControl.Visible = true;
                ACTabControl.TabPages[0].PageVisible = false;
                ACTabControl.TabPages[1].PageVisible = true;
            }
        }

        public void ChangeListAccountBank(int listAccountBankID)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            mainObject.FK_ACListAccountBankID = listAccountBankID;
            ACListAccountBanksController objListAccountBanksController = new ACListAccountBanksController();
            ACListAccountBanksInfo objListAccountBanksInfo = (ACListAccountBanksInfo)objListAccountBanksController.GetObjectByID(listAccountBankID);
            if (objListAccountBanksInfo != null)
            {
                mainObject.APSupplierPaymentReceiverAccount = objListAccountBanksInfo.ACListAccountBankAccount;
                mainObject.APSupplierPaymentReceiverBankName = objListAccountBanksInfo.ACListAccountBankBranch;
                mainObject.APSupplierPaymentReceiverIDNumber = objListAccountBanksInfo.ACListAccountBankAccountHolderIDNumber;
                mainObject.APSupplierPaymentObjectReceiptName = objListAccountBanksInfo.ACListAccountBankAccountHolder;
                mainObject.APSupplierPaymentReceiverIDDate = objListAccountBanksInfo.ACListAccountBankAccountHolderIDCardDate;
                mainObject.APSupplierPaymentReceiptAddress = objListAccountBanksInfo.ACListAccountBankObjectAddress;
                mainObject.APSupplierPaymentReceiverIDPlace = objListAccountBanksInfo.ACListAccountBankAccountHolderCity;
                mainObject.APSupplierPaymentReceiverBankCode = objListAccountBanksInfo.ACListAccountBankNo;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        public void ChangeLoanReceipt(int loanReceiptID)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)(new ACLoanReceiptsController()).GetLoanReceiptByID(loanReceiptID);
            if (objLoanReceiptsInfo != null)
            {
                mainObject.FK_ACLoanReceiptID = objLoanReceiptsInfo.ACLoanReceiptID;
                entity.PaymentProposalList.ForEach(o => o.FK_ACCreditAccountID = objLoanReceiptsInfo.FK_ACAccountID);
                entity.UpdateMainObjectBindingSource();
            }
        }

        public bool IsValidAmountLoanReceipt()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)objLoanReceiptsController.GetLoanReceiptForSupplierPayment(mainObject.FK_ACLoanReceiptID, mainObject.APSupplierPaymentID);
            if (objLoanReceiptsInfo != null)
            {
                //entity.PaymentProposalList.FirstOrDefault(o => o.FK_ge)
                if(objLoanReceiptsInfo.FK_GECurrencyID != mainObject.FK_GECurrencyID)
                {
                    MessageBox.Show("Loại tiền tệ của chứng từ khác với Loại tiền tệ của Khế ước." + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }    
                decimal amount = entity.PaymentProposalList.Sum(o => o.APPaymentProposalPaymentAmount);
                if (amount * mainObject.APSupplierPaymentExchangeRate > objLoanReceiptsInfo.ACLoanReceiptExchangeAmount)
                {
                    MessageBox.Show("Tổng tiền thanh toán lớn hơn số tiền quy đổi của khế ước.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }    
            }    
            return true;
        }

        public void PrintUNCVietTinBank()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(mainObject.APSupplierPaymentNo);
                if (paymentOrder == null)
                    return;
                ADReportsController objReportsController = new ADReportsController();

                RPPaymentOrderVietinbank report = new RPPaymentOrderVietinbank();
                List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrder.ACBankTransactionID);
                report.DataSource = bankTransactionItemList;
                InitPrintUNCVietTinBank(report, paymentOrder.ACBankTransactionID);
                guiReportPreview reviewer = new guiReportPreview(report, null, true);
                reviewer.Show();
            }
        }

        private void InitPrintUNCVietTinBank(XtraReport report, int ACBankTransactionID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionVietcombankByID(ACBankTransactionID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);

                XRLabel currencies = (XRLabel)report.FindControl("xr_lbCurrency", false);
                if (currencies != null)
                {
                    currencies.Text = currency.GECurrencyName;
                }
                XRLabel totalAmount = (XRLabel)report.FindControl("rp_xrlTotalAmount", false);
                if (totalAmount != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount.Text = string.Format(amount);
                }
                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }
            }
        }

        public void PrintVietcombank()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
                PrintVietcombank(mainObject.APSupplierPaymentID);
            }
        }

        public void PrintVietcombank(int supplierPaymentID)
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                SupplierPaymentEntities entity = (SupplierPaymentEntities)CurrentModuleEntity;
                APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(mainObject.APSupplierPaymentNo);
                if (paymentOrder == null)
                    return;
                ADReportsController objReportsController = new ADReportsController();

                RPPaymentOrderVietcombank report = new RPPaymentOrderVietcombank();
                List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrder.ACBankTransactionID);
                report.DataSource = bankTransactionItemList;
                InitPrintVietcombank(report, paymentOrder.ACBankTransactionID);
                XRLabel contact = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabelL1"];
                XRLabel contact2 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabelL2"];
                if (contact != null)
                    contact.Text = PaymentOrderLocalizedResources.copy;
                if (contact2 != null)
                    contact2.Text = PaymentOrderLocalizedResources.copy;
                guiReportPreview reviewer = new guiReportPreview(report, null, true);
                reviewer.Show();
            }
        }

        private static void InitPrintVietcombank(XtraReport report, int ACBankTransactionID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionVietcombankByID(ACBankTransactionID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);

                XRLabel currencies = (XRLabel)report.FindControl("xr_lbCurrency", false);
                if (currencies != null)
                {
                    currencies.Text = currency.GECurrencyName;
                }

                XRLabel totalAmount = (XRLabel)report.FindControl("rp_xrlTotalAmount", false);
                if (totalAmount != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount.Text = string.Format(amount);
                }

                XRLabel currentCompany = (XRLabel)report.FindControl("rp_xrlCurrentCompany", false);
                if (currentCompany != null)
                {
                    currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }

                //Lien 2
                XRLabel currencies1 = (XRLabel)report.FindControl("xr_lbCurrency1", false);
                if (currencies1 != null)
                {
                    currencies1.Text = currency.GECurrencyName;
                }

                XRLabel totalAmount1 = (XRLabel)report.FindControl("rp_xrlTotalAmount1", false);
                if (totalAmount1 != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount1.Text = string.Format(amount);
                }

                XRLabel currentCompany1 = (XRLabel)report.FindControl("rp_xrlCurrentCompany1", false);
                if (currentCompany1 != null)
                {
                    currentCompany1.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop1 = (XRLabel)report.FindControl("xr_lblReadAmount1", false);
                    if (amountWordTop1 != null)
                    {
                        amountWordTop1.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }
            }
        }
    }
}

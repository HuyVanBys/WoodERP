using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentProposal
{
    public class PaymentProposalModule : BaseTransactionModule
    {
        #region Constants
        public const string ACObjectAccessKeyControlName = "fld_lkeFK_ACObjectID";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string ListAccountBankLookupEditControlName = "fld_lkeFK_ACListAccountBankID";
        public const string FilePathTextBoxName = "fld_txtFilePath";
        public const string PaymentProposalTemplateGridControlName = "fld_dgcPaymentProposalTemplates";
        private string DocumentFileName = string.Empty;
        #endregion

        #region Public properties
        List<string> listControlName;
        public BOSLookupEdit SearchBranchLookupEditControl;
        public BOSLookupEdit ListAccountBankLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        private List<ACListAccountBanksInfo> ListAccountBanks;
        #endregion

        private BOSLookupEdit ACObjectAccessKeyControl;

        public PaymentProposalModule()
        {
            Name = "PaymentProposal";
            CurrentModuleEntity = new PaymentProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[PaymentProposalModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            ListAccountBanks = (new ACListAccountBanksController()).GetAllListAcctountBanks();
            ListAccountBankLookupEditControl = (BOSLookupEdit)Controls[PaymentProposalModule.ListAccountBankLookupEditControlName];
            if(ListAccountBankLookupEditControl != null)
            {
                ListAccountBankLookupEditControl.Properties.DataSource = ListAccountBanks;
            }
            listControlName = new List<string>();
            ACObjectAccessKeyControl = (BOSLookupEdit)Controls[ACObjectAccessKeyControlName];
        }

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
            APPaymentProposalsController paymentProposalController = new APPaymentProposalsController();
            APPaymentProposalsInfo searchObject = (APPaymentProposalsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACAssObjectAccessKey);
            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = paymentProposalController.GetDataSetByID(-1);
                }
                else
                {

                    ds = paymentProposalController.GetPaymentProposalListByListOfBranchID(
                                                                            searchObject.APPaymentProposalNo,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.APPaymentProposalTypeCombo,
                                                                            searchObject.FK_HRDepartmentID,
                                                                            objObjectsInfo.ACObjectID,
                                                                            objObjectsInfo.ACObjectType,
                                                                            searchObject.APPaymentProposalStatusCombo,
                                                                            searchObject.APPriority,
                                                                            searchObject.PaymentProposalDateFrom,
                                                                            searchObject.PaymentProposalDateTo,
                                                                            BranchList);
                }
            }
            else
            {
                ds = paymentProposalController.GetPaymentProposalListByBranchID(
                                                                            searchObject.APPaymentProposalNo,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.APPaymentProposalTypeCombo,
                                                                            searchObject.FK_HRDepartmentID,
                                                                            objObjectsInfo.ACObjectID,
                                                                            objObjectsInfo.ACObjectType,
                                                                            searchObject.APPaymentProposalStatusCombo,
                                                                            searchObject.APPriority,
                                                                            searchObject.PaymentProposalDateFrom,
                                                                            searchObject.PaymentProposalDateTo,
                                                                            searchObject.FK_BRBranchID);
            }
            return ds;
        }

        public override void InvalidateToolbar()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)entity.MainObject;
            if (objPaymentProposalsInfo.APPaymentProposalID <= 0)
            {
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton("Reject", false);
                ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton("Reject", true);
                ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", true);
                ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
                if (objPaymentProposalsInfo.APPaymentProposalStatusCombo == PaymentProposalApproveStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Reject", true);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
                if (objPaymentProposalsInfo.APPaymentProposalStatusCombo == PaymentProposalApproveStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("Reject", true);
                    ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", true);
                }
                if (objPaymentProposalsInfo.APPaymentProposalStatusCombo == PaymentProposalApproveStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Reject", false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
                if (objPaymentProposalsInfo.APPaymentProposalStatusCombo == PaymentProposalApproveStatus.Checked.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Reject", true);
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                    ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", true);
                }
            }

            base.InvalidateToolbar();
        }

        public void ResetAmount()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalItemsInfo item = (APPaymentProposalItemsInfo)entity.ModuleObjects[TableName.APPaymentProposalItemsTableName];
            item.APPaymentProposalItemRemainAmount = item.APPaymentProposalItemTotalAmount - item.APPaymentProposalItemPaidAmount;
            entity.UpdateTotalAmount();
        }

        public override void ActionNew()
        {
            base.ActionNew();
        }

        public override void ActionCancel()
        {
            base.ActionCancel();
        }

        public void ConfirmPaymentProposal()
        {
            if (IsEditable())
                ActionEdit();
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)entity.MainObject;

            if (objPaymentProposalsInfo != null)
            {
                objPaymentProposalsInfo.FK_HREmployeeHeadDepartmentID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objPaymentProposalsInfo.APPaymentProposalConfirmDate = DateTime.Now;
                objPaymentProposalsInfo.APPaymentProposalStatusCombo = PaymentProposalStatus.Confirmed.ToString();
            }
        }

        public void CheckedPaymentProposal()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objPaymentProposalsInfo.APPaymentProposalStatusCombo = PaymentProposalApproveStatus.Checked.ToString();
            objPaymentProposalsInfo.APPaymentProposalApproveStatus = ApproveStatus.NeedApprove;
            entity.UpdateTotalAmount();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void CheckPaymentProposal()
        {
            if (IsEditable())
                ActionEdit();
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)entity.MainObject;

            if (objPaymentProposalsInfo != null)
            {
                objPaymentProposalsInfo.FK_HREmployeeAccountantID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objPaymentProposalsInfo.APPaymentProposalCheckDate = DateTime.Now;
                objPaymentProposalsInfo.APPaymentProposalStatusCombo = PaymentProposalStatus.Checked.ToString();
            }
        }

        public void AddItemToPaymentProposalItemsList()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalItemsInfo item = (APPaymentProposalItemsInfo)entity.ModuleObjects[TableName.APPaymentProposalItemsTableName];

            APPaymentProposalItemsInfo objPaymentProposalItemsInfo = new APPaymentProposalItemsInfo();
            BOSUtil.CopyObject(item, objPaymentProposalItemsInfo);
            entity.UpdateTotalAmount();
            entity.PaymentProposalItemsList.AddObjectToList();
            entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
        }

        public void RemoveItemFromPaymentProposalItemsList()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            entity.PaymentProposalItemsList.RemoveSelectedRowObjectFromList();
            entity.UpdateTotalAmount();
        }

        public void EditItemPaymentProposalItemsList()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            entity.PaymentProposalItemsList.ChangeObjectFromList();
            entity.UpdateTotalAmount();
        }

        public bool IsValidAmount()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            foreach (APPaymentProposalItemsInfo item in entity.PaymentProposalItemsList)
            {
                if (item.APPaymentProposalItemProposalAmount > item.APPaymentProposalItemRemainAmount)
                {
                    string documentNo = string.Empty;
                    if (item.FK_APInvoiceInID > 0)
                    {
                        APInvoiceInsController iiController = new APInvoiceInsController();
                        APInvoiceInsInfo ii = (APInvoiceInsInfo)iiController.GetObjectByID(item.FK_APInvoiceInID);
                        if (ii != null)
                        {
                            documentNo = ii.APInvoiceInNo;
                        }
                    }
                    else if (item.FK_APPurchaseOrderID > 0)
                    {
                        APPurchaseOrdersController iiController = new APPurchaseOrdersController();
                        APPurchaseOrdersInfo ii = (APPurchaseOrdersInfo)iiController.GetObjectByID(item.FK_APPurchaseOrderID);
                        if (ii != null)
                        {
                            documentNo = ii.APPurchaseOrderNo;
                        }
                    }
                    else if (item.FK_ACDocumentID > 0)
                    {
                        ACDocumentsController iiController = new ACDocumentsController();
                        ACDocumentsInfo ii = (ACDocumentsInfo)iiController.GetObjectByID(item.FK_ACDocumentID);
                        if (ii != null)
                        {
                            documentNo = ii.ACDocumentNo;
                        }
                    }

                    if (string.IsNullOrEmpty(documentNo))
                    {
                        MessageBox.Show("Số tiền đề nghị " + item.APPaymentProposalItemProposalAmount.ToString("N0")
                                        + " không hợp lệ."
                                        + Environment.NewLine + "Số tiền có thể đề nghị là " + item.APPaymentProposalItemRemainAmount.ToString("N0")
                                        + Environment.NewLine + "Vui lòng kiểm tra lại"
                                        , "Thông báo"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Số tiền đề nghị của " + documentNo
                                        + " không hợp lệ."
                                        + Environment.NewLine + "Số tiền có thể đề nghị là " + item.APPaymentProposalItemRemainAmount.ToString("N0")
                                        + Environment.NewLine + "Vui lòng kiểm tra lại"
                                        , "Thông báo"
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        public override int ActionSave()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)entity.MainObject;
            //APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            //APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            //objPaymentProposalsInfo.APPaymentProposalDesc = String.Empty;
            //List<APPaymentProposalItemsInfo> PaymentProposalItemForPOList = new List<APPaymentProposalItemsInfo>();
            //PaymentProposalItemForPOList = entity.PaymentProposalItemsList.Where(o => o.FK_APPurchaseOrderID > 0).ToList();
            //if (PaymentProposalItemForPOList.Count > 0)
            //{
            //    foreach (APPaymentProposalItemsInfo item in PaymentProposalItemForPOList)
            //    {
            //        APPurchaseOrdersInfo objPO = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(item.FK_APPurchaseOrderID);
            //        if (objPO != null)
            //        {
            //            if (string.IsNullOrEmpty(objPaymentProposalsInfo.APPaymentProposalDesc))
            //            {
            //                objPaymentProposalsInfo.APPaymentProposalDesc = String.Format("ĐNTT cho đơn mua hàng: {0}", objPO.APPurchaseOrderNo);
            //            }
            //            else
            //            {
            //                if (objPaymentProposalsInfo.APPaymentProposalDesc.Contains(objPO.APPurchaseOrderNo))
            //                {
            //                    objPaymentProposalsInfo.APPaymentProposalDesc = objPaymentProposalsInfo.APPaymentProposalDesc;
            //                }
            //                else
            //                {
            //                    objPaymentProposalsInfo.APPaymentProposalDesc = objPaymentProposalsInfo.APPaymentProposalDesc + "; " + objPO.APPurchaseOrderNo;
            //                }
            //            }
            //        }
            //    }
            //    objPaymentProposalsInfo.APPaymentProposalDesc += "\r\n";
            //}
            //String InvoiceNo = String.Empty;
            //List<APPaymentProposalItemsInfo> PaymentProposalItemForIVList = new List<APPaymentProposalItemsInfo>();
            //PaymentProposalItemForIVList = entity.PaymentProposalItemsList.Where(o => o.FK_APInvoiceInID > 0).ToList();
            //if (PaymentProposalItemForIVList.Count > 0)
            //{
            //    foreach (APPaymentProposalItemsInfo item in PaymentProposalItemForIVList)
            //    {
            //        APInvoiceInsInfo objIV = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(item.FK_APInvoiceInID);
            //        if (objIV != null)
            //        {
            //            if (string.IsNullOrEmpty(InvoiceNo))
            //            {
            //                InvoiceNo = objIV.APInvoiceInSupplierNo;
            //            }
            //            else
            //            {
            //                if (InvoiceNo.Contains(objIV.APInvoiceInSupplierNo))
            //                {
            //                    InvoiceNo = InvoiceNo;
            //                }
            //                else
            //                {
            //                    InvoiceNo = InvoiceNo + "; " + objIV.APInvoiceInSupplierNo;
            //                }
            //            }
            //        }
            //    }
            //    objPaymentProposalsInfo.APPaymentProposalDesc = objPaymentProposalsInfo.APPaymentProposalDesc + String.Format("ĐNTT cho HĐ số: {0}", InvoiceNo);
            //}
            entity.PaymentProposalItemsList.EndCurrentEdit();
            BOSList<APPaymentProposalItemsInfo> paymentProposalItemList = (BOSList<APPaymentProposalItemsInfo>)entity.PaymentProposalItemsList.Clone();
            // APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;

            decimal totalAmount = 0, paidAmount = 0, remainAmount = 0;
            foreach (APPaymentProposalItemsInfo item in paymentProposalItemList)
            {
                totalAmount += item.APPaymentProposalItemProposalAmount;
                paidAmount += item.APPaymentProposalItemPaidAmount;
                remainAmount += item.APPaymentProposalItemRemainAmount;
            }
            objPaymentProposalsInfo.APPaymentProposalTotalAmount = totalAmount;
            objPaymentProposalsInfo.APPaymentProposalPaidAmount = paidAmount;
            objPaymentProposalsInfo.APPaymentProposalRemainAmount = remainAmount;
            entity.UpdateTotalAmount();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objPaymentProposalsInfo.FK_ACObjectID, objPaymentProposalsInfo.APObjectType);
            if (objObjectsInfo != null)
                objPaymentProposalsInfo.ACObjectName = objObjectsInfo.ACObjectName;
            else
            {
                MessageBox.Show(PaymentProposalLocalizedResources.ACObjectNotNull, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            if (!IsValidAmount())
            {
                return 0;
            }
            if (entity.PaymentProposalItemsList.Where(o => o.APPaymentProposalItemDiscountFix < 0).Count() > 0)
            {
                MessageBox.Show("Chiết khấu thanh toán không được phép âm!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }    
            entity.UpdateMainObjectBindingSource();

            int PaymentProposalID = base.ActionSave();
            if (PaymentProposalID > 0)
            {
                SaveDocumentFile();
                ResetSearchObject();
            }
            return PaymentProposalID;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                InitProposalReport();
            }
        }

        private void InitProposalReport()
        {
            RPPaymentProposal report = new RPPaymentProposal();
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objCompanyInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrThue"].Controls["xr_tbcThue"].Controls["lblthue"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyTaxNumber;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrThue"].Controls["xr_tbcThue"].Controls["lbldchd"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine1;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrAddress"].Controls["xrtbcdiachinhamay"].Controls["lbldcnm"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyAddressLine2;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrAddress"].Controls["xrtbcdiachinhamay"].Controls["lblWeb"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyWebsite;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrEmail"].Controls["xr_tbcEmail"].Controls["lblEmail"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyEmail;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrEmail"].Controls["xr_tbcEmail"].Controls["lbldd"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyCellPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrEmail"].Controls["xr_tbcEmail"].Controls["lbldtb"];
                if (label != null)
                {
                    label.Text += objCompanyInfo.CSCompanyPhone;
                }
                XRLabel companyName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrTableRow7"].Controls["xr_tbcCompanyName"];
                if (companyName != null)
                {
                    companyName.Text = objCompanyInfo.CSCompanyDesc;
                }
            }

            APPaymentProposalsInfo objProposalsInfo = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;

            APPaymentProposalsInfo objPaymentProposalsInfo = new APPaymentProposalsInfo();
            objPaymentProposalsInfo = (APPaymentProposalsInfo)objProposalsInfo.Clone();
            if (objPaymentProposalsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["lblDate"];
                if (label != null)
                {
                    label.Text = "Ngày " + objPaymentProposalsInfo.APPaymentProposalDate.ToString("dd")
                                + " tháng " + objPaymentProposalsInfo.APPaymentProposalDate.ToString("MM")
                                + " năm " + objPaymentProposalsInfo.APPaymentProposalDate.ToString("yyyy");
                }
            }

            //Get Employee Controller
            HREmployeesController objEmployeesController = new HREmployeesController();

            //Get employee
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objPaymentProposalsInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
                objPaymentProposalsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;

            //Get department
            HRDepartmentRoomsController objDepartmentController = new HRDepartmentRoomsController();
            HRDepartmentRoomsInfo objDepartmentsInfo = (HRDepartmentRoomsInfo)objDepartmentController.GetObjectByID(objPaymentProposalsInfo.FK_HRDepartmentRoomID);
            if (objDepartmentsInfo != null)
                objPaymentProposalsInfo.HRDepartmentRoomName = objDepartmentsInfo.HRDepartmentRoomName;


            //Get list PaymentProposalItem
            objPaymentProposalsInfo.APPaymentProposalReference = string.Empty;
            BOSList<APPaymentProposalItemsInfo> paymentProposalItemList = (BOSList<APPaymentProposalItemsInfo>)entity.PaymentProposalItemsList.Clone();
            foreach (APPaymentProposalItemsInfo item in paymentProposalItemList)
            {

                APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(item.FK_APInvoiceInID);
                if (objInvoiceInsInfo != null)
                {
                    objPaymentProposalsInfo.FK_GECurrencyID = objInvoiceInsInfo.FK_GECurrencyID;
                    if (objPaymentProposalsInfo.APPaymentProposalReference == string.Empty)
                    {
                        objPaymentProposalsInfo.APPaymentProposalReference = objInvoiceInsInfo.APInvoiceInNo;
                        objPaymentProposalsInfo.APPaymentProposalDocAttachDesc = "Hóa đơn";
                    }
                    else
                    {
                        objPaymentProposalsInfo.APPaymentProposalReference += "; " + objInvoiceInsInfo.APInvoiceInNo;
                    }
                }

                ICReceiptsController objReceiptsController = new ICReceiptsController();
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(item.FK_ICReceiptID);
                if (objReceiptsInfo != null)
                {
                    objPaymentProposalsInfo.FK_GECurrencyID = objReceiptsInfo.FK_GECurrencyID;
                    if (objPaymentProposalsInfo.APPaymentProposalReference == string.Empty)
                    {
                        objPaymentProposalsInfo.APPaymentProposalReference = objReceiptsInfo.ICReceiptNo;
                        objPaymentProposalsInfo.APPaymentProposalDocAttachDesc = "Phiếu nhập kho";
                    }
                    else
                    {
                        objPaymentProposalsInfo.APPaymentProposalReference += "; " + objReceiptsInfo.ICReceiptNo;
                    }
                }

                APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(item.FK_APPurchaseOrderID);
                if (objPurchaseOrdersInfo != null)
                {
                    objPaymentProposalsInfo.FK_GECurrencyID = objPurchaseOrdersInfo.FK_GECurrencyID;
                    if (objPaymentProposalsInfo.APPaymentProposalReference == string.Empty)
                    {
                        objPaymentProposalsInfo.APPaymentProposalReference = objPurchaseOrdersInfo.APPurchaseOrderNo;
                        objPaymentProposalsInfo.APPaymentProposalDocAttachDesc = "Đơn hàng";
                    }
                    else
                    {
                        objPaymentProposalsInfo.APPaymentProposalReference += "; " + objPurchaseOrdersInfo.APPurchaseOrderNo;
                    }
                }
            }
            if (objPaymentProposalsInfo.FK_GECurrencyID == 0)
            {
                objPaymentProposalsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            }
            objPaymentProposalsInfo.APPaymentProposalTotalAmountWord = ConvertAmountToWord.ReadAmount(objPaymentProposalsInfo.APPaymentProposalTotalAmount.ToString(), objPaymentProposalsInfo.FK_GECurrencyID);

            if (objPaymentProposalsInfo.APPaymentProposalDocAttachDesc == string.Empty)
            {
                objPaymentProposalsInfo.APPaymentProposalDocAttachDesc = "Loại khác";
            }
            List<APPaymentProposalsInfo> list = new List<APPaymentProposalsInfo>();
            list.Add(objPaymentProposalsInfo);
            report.DataSource = list;
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();

        }

        public string GetConfigTextByGroupAndValue(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }

        public void DeleteItemFromPaymentProposalItemsList()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            entity.PaymentProposalItemsList.RemoveSelectedRowObjectFromList();
            entity.UpdateTotalAmount();

        }

        #region Approve, Reject
        //TNDLoc [ADD][24/06/2015][Issue Approve, Reject],START
        public void Approve()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo paymentProposal = (APPaymentProposalsInfo)entity.MainObject;

            entity.SetPropertyChangeEventLock(false);
            paymentProposal.APPaymentProposalStatusCombo = PaymentProposalApproveStatus.Approved.ToString();
            paymentProposal.APPaymentProposalApproveDate = BOSApp.GetCurrentServerDate();
            paymentProposal.APPaymentProposalApproveStatus = ApproveStatus.Approved;
            foreach (APPaymentProposalItemsInfo item in entity.PaymentProposalItemsList)
            {
                item.APPaymentProposalItemApproveStatus = PaymentProposalApproveStatus.Approved.ToString();
                item.APPaymentProposalItemRemainAmount = item.APPaymentProposalItemProposalAmount;
            }
            entity.UpdateTotalAmount();
            entity.UpdateMainObject();
            entity.SaveModuleObjects();
            entity.PaymentProposalItemsList.GridControl.RefreshDataSource();

            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton("Reject", true);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            entity.SetPropertyChangeEventLock(true);
        }

        public void Reject()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo paymentProposal = (APPaymentProposalsInfo)entity.MainObject;
            if (paymentProposal.APPaymentProposalStatusCombo == PaymentProposalApproveStatus.New.ToString())
            {
                paymentProposal.APPaymentProposalStatusCombo = PaymentProposalApproveStatus.Canceled.ToString();
                paymentProposal.APPaymentProposalApproveStatus = ApproveStatus.RejectionApproved;
                entity.PaymentProposalItemsList.ForEach(o => o.APPaymentProposalItemApproveStatus = PaymentProposalApproveStatus.Canceled.ToString());

                entity.UpdateMainObject();
                entity.SaveModuleObjects();
                entity.PaymentProposalItemsList.GridControl.RefreshDataSource();

                ParentScreen.SetEnableOfToolbarButton("Reject", false);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ActionCancel();
            }
            else
            {
                APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
                List<APSupplierPaymentsInfo> List = objSupplierPaymentsController.GetSupplierPayments(paymentProposal.APPaymentProposalID);
                if (List != null && List.Count > 0)
                {
                    MessageBox.Show("Đề nghị thanh toán đã làm trả tiền NCC nên không thể hủy!"
                        + Environment.NewLine + string.Join(",", List.Select(p => p.APSupplierPaymentNo).Distinct().ToArray())
                        , CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paymentProposal.APPaymentProposalStatusCombo = PaymentProposalApproveStatus.Canceled.ToString();
                    paymentProposal.APPaymentProposalApproveStatus = ApproveStatus.RejectionApproved;
                    entity.PaymentProposalItemsList.ForEach(o => o.APPaymentProposalItemApproveStatus = PaymentProposalApproveStatus.Canceled.ToString());

                    entity.UpdateMainObject();
                    entity.SaveModuleObjects();
                    entity.PaymentProposalItemsList.GridControl.RefreshDataSource();

                    ParentScreen.SetEnableOfToolbarButton("Reject", true);
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ActionCancel();
                }
            }
        }
        public override bool ActionCancelComplete()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo paymentProposal = (APPaymentProposalsInfo)entity.MainObject;
            if (paymentProposal.APPaymentProposalID > 0)
            {

                APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
                List<APSupplierPaymentsInfo> List = objSupplierPaymentsController.GetSupplierPayments(paymentProposal.APPaymentProposalID);
                if (List != null && List.Count > 0)
                {
                    MessageBox.Show("Đề nghị thanh toán đã làm trả tiền NCC nên không thể mở!"
                        + Environment.NewLine + string.Join(",", List.Select(p => p.APSupplierPaymentNo).Distinct().ToArray())
                        , CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            base.ActionCancelComplete();
            entity.UpdateTotalAmount();
            InvalidateToolbar();
            return true;
        }
        #endregion

        public void GetPaymentTerm()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return;
            }
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo paymentProposal = (APPaymentProposalsInfo)entity.MainObject;
            if (paymentProposal.FK_ACObjectID == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            APPaymentProposalItemsController objPaymentProposalItemsController = new APPaymentProposalItemsController();
            List<APPaymentProposalItemsInfo> paymentProposalItemList = objPaymentProposalItemsController.GetPaymentProposalItemsForPaymentProposalFromInvoiceInTransactions(paymentProposal.FK_ACObjectID, paymentProposal.APObjectType);

            guiFind<APPaymentProposalItemsInfo> guiFind = new guiFind<APPaymentProposalItemsInfo>(TableName.APPaymentProposalItemsTableName, paymentProposalItemList, this, true);
            guiFind.Module = this;
        Stamp:
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                if (guiFind.SelectedObjects.Count > 0)
                {
                    if (guiFind.SelectedObjects.Count > 1)
                    {
                        if (guiFind.SelectedObjects.FirstOrDefault(s => (s.FK_ACAssObjectID != guiFind.SelectedObjects[0].FK_ACAssObjectID && s.APAssObjectType != guiFind.SelectedObjects[0].APAssObjectType)
                                                                        || (s.FK_ACAssObjectID != guiFind.SelectedObjects[0].FK_ACAssObjectID && s.APAssObjectType == guiFind.SelectedObjects[0].APAssObjectType)
                                                                        || (s.FK_ACAssObjectID == guiFind.SelectedObjects[0].FK_ACAssObjectID && s.APAssObjectType != guiFind.SelectedObjects[0].APAssObjectType)) != null)
                        {
                            MessageBox.Show(PaymentProposalLocalizedResources.NotMatchSupplier, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                            goto Stamp;
                        }

                        if (guiFind.SelectedObjects.FirstOrDefault(s => s.FK_GECurrencyID != guiFind.SelectedObjects[0].FK_GECurrencyID) != null)
                        {
                            MessageBox.Show("Các chứng từ đã chọn không cùng loại tiền tệ.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            goto Stamp;
                        }
                    }
                    paymentProposal.FK_GECurrencyID = guiFind.SelectedObjects[0].FK_GECurrencyID;
                    paymentProposal.APPaymentProposalProject = String.Join(", ", guiFind.SelectedObjects.Select(o => o.APPaymentProposalProject).Distinct().ToArray());
                    if (paymentProposal.FK_ACObjectID == 0)
                    {
                        paymentProposal.FK_ACObjectID = guiFind.SelectedObjects[0].FK_ACAssObjectID;
                        paymentProposal.APObjectType = guiFind.SelectedObjects[0].APAssObjectType;
                        //  paymentProposal.ACAssObjectAccessKey = paymentProposal.FK_ACObjectID + ";" + paymentProposal.APObjectType;
                        paymentProposal.ACObjectAccessKey = paymentProposal.FK_ACObjectID + ";" + paymentProposal.APObjectType;
                        paymentProposal.APPaymentProposalDesc = String.Empty;
                        entity.UpdateMainObjectBindingSource();
                    }
                    foreach (APPaymentProposalItemsInfo item in guiFind.SelectedObjects)
                    {
                        item.APPaymentProposalItemProposalAmount = item.APPaymentProposalItemRemainAmount;
                        paymentProposal.APPaymentProposalPayDate = item.ARSaleOrderPaymentTimeDueEndDate;
                        APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
                        APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
                        if (item.APPaymentProposalItemType == PaymentProposalItemType.PODeposit.ToString())
                        {
                            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
                            APPurchaseOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)objPurchaseOrderPaymentTimesController.GetObjectByID(item.FK_APPurchaseOrderPaymentTimeID);
                            if (objPurchaseOrderPaymentTimesInfo != null)
                            {
                                //paymentProposal.APPaymentProposalPayDate = objPurchaseOrderPaymentTimesInfo.ARSaleOrderPaymentTimeDueEndDate;      
                                paymentProposal.FK_APPurchaseOrderID = objPurchaseOrderPaymentTimesInfo.FK_APPurchaseOrderID;
                                APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByID(objPurchaseOrderPaymentTimesInfo.FK_APPurchaseOrderID);
                                if (objPurchaseOrdersInfo != null)
                                {
                                    item.FK_GECurrencyID = objPurchaseOrdersInfo.FK_GECurrencyID;
                                }
                            }
                            entity.UpdateMainObjectBindingSource();
                        }
                        else if (item.APPaymentProposalItemType == PaymentProposalItemType.Order.ToString())
                        {
                            APPOPaymentTimeInvoiceInDetailsController objPOPaymentTimeInvoiceInDetailsController = new APPOPaymentTimeInvoiceInDetailsController();
                            List<APPOPaymentTimeInvoiceInDetailsInfo> paymentTimeInvoiceInDetailsList = objPOPaymentTimeInvoiceInDetailsController.GetItemByPurchaseOrderID(item.FK_APPurchaseOrderID);
                            foreach (APPOPaymentTimeInvoiceInDetailsInfo Item in paymentTimeInvoiceInDetailsList)
                            {
                                paymentProposal.APPaymentProposalPayDate = Item.APPOPaymentTimeInvoiceInDetailEndDate;
                            }
                            entity.UpdateMainObjectBindingSource();
                        }
                        else if (item.APPaymentProposalItemType == PaymentProposalItemType.InvoiceIn.ToString())
                        {
                            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(item.FK_APInvoiceInID);
                            if (objInvoiceInsInfo != null)
                            {
                                paymentProposal.APPaymentProposalPayDate = objInvoiceInsInfo.APInvoiceInValidateDate;
                                paymentProposal.FK_APInvoiceInID = objInvoiceInsInfo.APInvoiceInID;
                                item.FK_GECurrencyID = objInvoiceInsInfo.FK_GECurrencyID;
                                item.APPaymentProposalItemDepositAmount = objInvoiceInsInfo.APInvoiceInDepositBalance;
                            }
                            entity.UpdateMainObjectBindingSource();
                        }
                        else if (item.APPaymentProposalItemType == PaymentProposalItemType.FeePayment.ToString() || item.APPaymentProposalItemType == PaymentProposalItemType.NghiepVuKhac.ToString())
                        {
                            ACDocumentsController objDocumentsController = new ACDocumentsController();
                            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetObjectByID(item.FK_ACDocumentID);
                            if (objDocumentsInfo != null)
                            {
                                paymentProposal.APPaymentProposalPayDate = objDocumentsInfo.ACDocumentDate;
                                item.FK_GECurrencyID = objDocumentsInfo.FK_GECurrencyID;
                            }
                            entity.UpdateMainObjectBindingSource();
                        }
                        BOSApp.RoundByCurrency(item, item.FK_GECurrencyID);
                        //if (item.FK_APPurchaseOrderID > 0)
                        //{
                        //    paymentProposal.APPaymentProposalDesc += item.APPaymentProposalItemRemark + "\r\n";
                        //}
                        //if (item.FK_APInvoiceInID > 0)
                        //{
                        //    paymentProposal.APPaymentProposalDesc += item.APPaymentProposalItemRemark + "\r\n";
                        //}
                        entity.PaymentProposalItemsList.Add(item);
                    }
                    entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
                    entity.UpdateTotalAmount();
                }
            }
        }

        public bool CheckQtyChange()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            int index = entity.PaymentProposalItemsList.CurrentIndex;
            APPaymentProposalItemsInfo currentPaymentProposalItem = entity.PaymentProposalItemsList[index];
            if (currentPaymentProposalItem != null)
            {
                if (currentPaymentProposalItem.APPaymentProposalItemProposalAmount > currentPaymentProposalItem.APPaymentProposalItemRemainAmount)
                {
                    MessageBox.Show(PaymentProposalLocalizedResources.PaymentProposalCheckAmount, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            BOSApp.RoundByCurrency(currentPaymentProposalItem, "APPaymentProposalItemProposalAmount", currentPaymentProposalItem.FK_GECurrencyID);
            entity.UpdateTotalAmount();
            return true;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo objPaymentProposals = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            List<APPaymentProposalItemsInfo> paymentProposalItemList = entity.PaymentProposalItemsList;
            if (objPaymentProposals.FK_ACObjectID > 0)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objPaymentProposals.FK_ACObjectID, objPaymentProposals.APObjectType);
                if (paymentProposalItemList != null)
                {
                    paymentProposalItemList.ForEach(o =>
                    {
                        o.ACObjectName = objObjectsInfo.ACObjectName;
                    });
                }
            }
            if(ListAccountBankLookupEditControl != null)
            {
                ListAccountBankLookupEditControl.Properties.DataSource = ListAccountBanks;
            }
        }

        public bool ChangeObject(string objectAccessKey)
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            if (entity.PaymentProposalItemsList.Count > 0)
            {
                MessageBox.Show("Không thể thay đổi đối tượng!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return false;
            }

            objPaymentProposalsInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objPaymentProposalsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objPaymentProposalsInfo.APObjectType = objObjectsInfo.ACObjectType;
                objPaymentProposalsInfo.ACObjectName = objObjectsInfo.ACObjectName;
            }
            else
            {
                objPaymentProposalsInfo.FK_ACObjectID = 0;
                objPaymentProposalsInfo.APObjectType = string.Empty;
                objPaymentProposalsInfo.ACObjectName = string.Empty;
            }
            entity.UpdateMainObjectBindingSource();
            return true;
        }

        public void PrintPaymentProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
                APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
                RPPaymentlProposal report = new RPPaymentlProposal();
                InitPrintPaymentProposalReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        public void InitPrintPaymentProposalReport(RPPaymentlProposal report)
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo mainobject = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;

            APPaymentProposalsController objPaymentProposalsController = new APPaymentProposalsController();
            APPaymentProposalsInfo objPaymentProposalsInfo = objPaymentProposalsController.GetPaymentProposalByID(mainobject.APPaymentProposalID);
            APPaymentProposalItemsController objPaymentProposalItemsController = new APPaymentProposalItemsController();
            List<APPaymentProposalItemsInfo> paymentProposalItemsList = objPaymentProposalItemsController.GetPaymentProposalItemByPaymentProposalID(objPaymentProposalsInfo.APPaymentProposalID);
            Boolean isNotAllVND = true;
            if (paymentProposalItemsList.Where(p => p.FK_GECurrencyID != GECurrencyID.VND).ToList().Count == 0) isNotAllVND = false;
            paymentProposalItemsList.ForEach(p =>
                {
                    p.PaymentItemProposalAmountShowReport = p.FK_GECurrencyID == GECurrencyID.VND ? Math.Round(p.APPaymentProposalItemProposalAmount, 0, MidpointRounding.AwayFromZero).ToString("n0") : p.APPaymentProposalItemProposalAmount.ToString("n2");
                });
            report.bsAPPaymentProposalItems.DataSource = paymentProposalItemsList;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetEmployeeForReportByID(objPaymentProposalsInfo.FK_HREmployeeID);
            report.bsEmployeesInfo.DataSource = objEmployeesInfo;
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["pnlTitlePaymentProposal"].Controls["xr_lblPaymentProposalDate"];
            if (label != null)
            {
                label.Text = string.Format(label.Text
                                           , objPaymentProposalsInfo.APPaymentProposalDate.Day
                                           , objPaymentProposalsInfo.APPaymentProposalDate.Month
                                           , objPaymentProposalsInfo.APPaymentProposalDate.Year);
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["pnlTitlePaymentProposal"].Controls["xr_lblPaymentProposalNo"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, objPaymentProposalsInfo.APPaymentProposalNo);
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectName"];
            if (label != null)
            {
                label.Text = objPaymentProposalsInfo.ACObjectName;
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblPaymentProposalDesc"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, objPaymentProposalsInfo.APPaymentProposalDesc);
            }
            decimal totalAmount = paymentProposalItemsList.Select(o => o.APPaymentProposalItemProposalAmount).Sum();
            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblPaymentProposalTotalAmount"];
            if (label != null)
            {
                if (isNotAllVND) label.Text = totalAmount.ToString("n2");
                else
                {
                    label.Text = Math.Round(totalAmount, 0, MidpointRounding.AwayFromZero).ToString("n0");
                }
            }
            int defaultCurrencyID = paymentProposalItemsList[0].FK_GECurrencyID;
            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblProposalPaymenttAmountString"];
            if (label != null)
            {
                label.Text = ConvertAmountToWord.ReadAmount(totalAmount.ToString("n3"), defaultCurrencyID);
            }
        }

        public void PrintPaymentProposalA5()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
                APPaymentProposalsInfo objPaymentProposalsInfo = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
                RPPaymentlProposalA5 report = new RPPaymentlProposalA5();
                InitPrintPaymentProposalReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        private void InitPrintPaymentProposalReport(RPPaymentlProposalA5 report)
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo mainobject = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;

            APPaymentProposalsController objPaymentProposalsController = new APPaymentProposalsController();
            APPaymentProposalsInfo objPaymentProposalsInfo = objPaymentProposalsController.GetPaymentProposalByID(mainobject.APPaymentProposalID);
            APPaymentProposalItemsController objPaymentProposalItemsController = new APPaymentProposalItemsController();
            List<APPaymentProposalItemsInfo> paymentProposalItemsList = objPaymentProposalItemsController.GetPaymentProposalItemByPaymentProposalID(objPaymentProposalsInfo.APPaymentProposalID);
            Boolean isNotAllVND = true;
            if (paymentProposalItemsList.Where(p => p.FK_GECurrencyID != GECurrencyID.VND).ToList().Count == 0) isNotAllVND = false;
            paymentProposalItemsList.ForEach(p =>
            {
                p.PaymentItemProposalAmountShowReport = p.FK_GECurrencyID == GECurrencyID.VND ? Math.Round(p.APPaymentProposalItemProposalAmount, 0, MidpointRounding.AwayFromZero).ToString("n0") : p.APPaymentProposalItemProposalAmount.ToString("n2");
            });
            report.bsAPPaymentProposalItems.DataSource = paymentProposalItemsList;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetEmployeeForReportByID(objPaymentProposalsInfo.FK_HREmployeeID);
            report.bsEmployeesInfo.DataSource = objEmployeesInfo;
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["pnlTitlePaymentProposal"].Controls["xr_lblPaymentProposalDate"];
            if (label != null)
            {
                label.Text = string.Format(label.Text
                                           , objPaymentProposalsInfo.APPaymentProposalDate.Day
                                           , objPaymentProposalsInfo.APPaymentProposalDate.Month
                                           , objPaymentProposalsInfo.APPaymentProposalDate.Year);
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["pnlTitlePaymentProposal"].Controls["xr_lblPaymentProposalNo"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, objPaymentProposalsInfo.APPaymentProposalNo);
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblACObjectName"];
            if (label != null)
            {
                label.Text = objPaymentProposalsInfo.ACObjectName;
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblPaymentProposalDesc"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, objPaymentProposalsInfo.APPaymentProposalDesc);
            }
            decimal totalAmount = paymentProposalItemsList.Select(o => o.APPaymentProposalItemProposalAmount).Sum();
            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblPaymentProposalTotalAmount"];
            if (label != null)
            {
                if (isNotAllVND) label.Text = totalAmount.ToString("n2");
                else
                {
                    label.Text = Math.Round(totalAmount, 0, MidpointRounding.AwayFromZero).ToString("n0");
                }
            }
            int defaultCurrencyID = paymentProposalItemsList[0].FK_GECurrencyID;
            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblProposalPaymenttAmountString"];
            if (label != null)
            {
                label.Text = ConvertAmountToWord.ReadAmount(totalAmount.ToString("n3"), defaultCurrencyID);
            }
        }

        public void ShowPurchaseOrderScreen(int purchaseOrderID)
        {
            Modules.PurchaseOrder.PurchaseOrderModule purchaseOrderModule;
            if (BOSApp.IsOpenedModule(ModuleName.PurchaseOrder))
            {
                purchaseOrderModule = (Modules.PurchaseOrder.PurchaseOrderModule)BOSApp.OpenModules[ModuleName.PurchaseOrder];
                purchaseOrderModule.ParentScreen.Activate();
            }
            else
                purchaseOrderModule = (Modules.PurchaseOrder.PurchaseOrderModule)BOSApp.ShowModule(ModuleName.PurchaseOrder);
            if (purchaseOrderModule == null)
                return;

            purchaseOrderModule.ActionInvalidate(purchaseOrderID);
        }

        public void ShowInvoiceInScreen(int invoiceInID)
        {
            Modules.InvoiceIn.InvoiceInModule invoiceInModule;
            if (BOSApp.IsOpenedModule(ModuleName.InvoiceIn))
            {
                invoiceInModule = (Modules.InvoiceIn.InvoiceInModule)BOSApp.OpenModules[ModuleName.InvoiceIn];
                invoiceInModule.ParentScreen.Activate();
            }
            else
                invoiceInModule = (Modules.InvoiceIn.InvoiceInModule)BOSApp.ShowModule(ModuleName.InvoiceIn);
            if (invoiceInModule == null)
                return;

            invoiceInModule.ActionInvalidate(invoiceInID);
        }

        /// <summary>
        /// Phân bổ tiền đề nghị
        /// </summary>
        /// <param name="SelectedIndex">Tieu chi phan bổ
        /// 0:% giá trị/Tổng tiền
        /// 1:Ngày thanh toán(tăng dần)
        /// 2:Phân bổ đều
        /// </param>
        /// <param name="ProposalTotalAmount"></param>
        public void AllocationProposalAmount(int SelectedIndex, decimal ProposalTotalAmount)
        {
            if(Toolbar.IsNullOrNoneAction())
            {
                return;
            }    
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)entity.MainObject;
            if (entity.PaymentProposalItemsList == null || entity.PaymentProposalItemsList.Count == 0) return;
            decimal totalAmount = entity.PaymentProposalItemsList.Sum(p => p.APPaymentProposalItemRemainAmount);
            if (totalAmount == 0)
            {
                mainObject.APPaymentProposalTotalAmount = 0;
                MessageBox.Show(PaymentProposalLocalizedResources.ProposalTotalAmountIsZero,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SelectedIndex < 0)
            {
                MessageBox.Show(PaymentProposalLocalizedResources.ErrorAllocationType,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Tien de nghị <= tien con lại can thanh toán
            if (ProposalTotalAmount > totalAmount)
                ProposalTotalAmount = totalAmount;
            mainObject.APPaymentProposalTotalAmount = ProposalTotalAmount;
            switch (SelectedIndex)
            {
                case 0: //Ngày đến hạn
                    entity.PaymentProposalItemsList.OrderBy(o => o.ARSaleOrderPaymentTimeDueDate)
                                                   .ToList()
                                                   .ForEach(o =>
                                                   {
                                                       if (ProposalTotalAmount >= 0)
                                                       {
                                                           o.APPaymentProposalItemProposalAmount = Math.Min(o.APPaymentProposalItemRemainAmount, ProposalTotalAmount);
                                                           BOSApp.RoundByCurrency(o, "APPaymentProposalItemProposalAmount", o.FK_GECurrencyID);
                                                           ProposalTotalAmount -= o.APPaymentProposalItemProposalAmount;
                                                       }
                                                   });

                    break;
                case 1:// % giá trị/Tổng tiền
                    entity.PaymentProposalItemsList.ForEach(o =>
                    {
                        o.APPaymentProposalItemProposalAmount = (o.APPaymentProposalItemRemainAmount / totalAmount) * ProposalTotalAmount;
                        BOSApp.RoundByCurrency(o, "APPaymentProposalItemProposalAmount", o.FK_GECurrencyID);
                    });
                    break;

                case 2: //Phân bổ đều
                    entity.PaymentProposalItemsList.ForEach(o =>
                    {
                        if (ProposalTotalAmount > 0)
                        {
                            decimal AllocationAmount = ProposalTotalAmount / entity.PaymentProposalItemsList.Count;
                            if (AllocationAmount > o.APPaymentProposalItemRemainAmount)
                                AllocationAmount = o.APPaymentProposalItemRemainAmount;
                            o.APPaymentProposalItemProposalAmount = AllocationAmount;
                            BOSApp.RoundByCurrency(o, "APPaymentProposalItemProposalAmount", o.FK_GECurrencyID);
                        }
                    });
                    break;
                default:
                    break;
            }

            //Phan bo chenh lech tong tien de nghi
            decimal diff = mainObject.APPaymentProposalTotalAmount - entity.PaymentProposalItemsList.Sum(p => p.APPaymentProposalItemProposalAmount);
            if (diff != 0)
            {
                entity.PaymentProposalItemsList.ForEach(o =>
                {
                    if (diff != 0)
                    {
                        decimal mnus = Math.Min(o.APPaymentProposalItemRemainAmount - o.APPaymentProposalItemProposalAmount, diff);
                        o.APPaymentProposalItemProposalAmount += mnus;
                        diff -= mnus;
                    }
                });
            }
            entity.UpdateTotalAmount();
            entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
        }
		
		public void ViewApprovalDetails()
        {
            APPaymentProposalsInfo mainobject = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            APPaymentProposalApprovalsController controller = new APPaymentProposalApprovalsController();
            List<APPaymentProposalApprovalsInfo> approvalDetails = controller.GetItemByProposalID(mainobject.APPaymentProposalID);
            if (!approvalDetails.Any())
            {
                MessageBox.Show("Chứng từ không có thông tin xét duyệt.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            guiProposalApprovals guiView = new guiProposalApprovals(approvalDetails);
            guiView.Module = this;
            guiView.ShowDialog();
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            APPaymentProposalsInfo mainobject = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            mainobject.APPaymentProposalApproveStatus = ApproveStatus.NeedApprove;
        }

        public void GetListAccountBankForLookUpEditControl()
        {
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.FK_ACObjectID > 0 && mainObject.APObjectType != string.Empty)
            {
                ListAccountBankLookupEditControl.Properties.DataSource = ListAccountBanks.Where(o => o.FK_ACObjectID == mainObject.FK_ACObjectID && o.ACObjectType == mainObject.APObjectType).ToList();
            }
            else
            {
                ListAccountBankLookupEditControl.Properties.DataSource = null;
            }
        }

        public void ChangeListAccountBank(int listAccountBankID)
        {
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_ACListAccountBankID = listAccountBankID;
            ACListAccountBanksController objListAccountBanksController = new ACListAccountBanksController();
            ACListAccountBanksInfo objListAccountBanksInfo = (ACListAccountBanksInfo)objListAccountBanksController.GetObjectByID(listAccountBankID);
            if (objListAccountBanksInfo != null)
            {
                mainObject.APPaymentProposalReceiverAccount = objListAccountBanksInfo.ACListAccountBankAccount;
                mainObject.APPaymentProposalReceiverBankName = objListAccountBanksInfo.ACListAccountBankBranch;
                mainObject.APPaymentProposalObjectReceiptName = objListAccountBanksInfo.ACListAccountBankAccountHolder;
                mainObject.APPaymentProposalReceiptAddress = objListAccountBanksInfo.ACListAccountBankObjectAddress;
                mainObject.APPaymentProposalReceiverBankCode = objListAccountBanksInfo.ACListAccountBankNo;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        public void ChangeDiscountPercent()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)entity.MainObject;
            entity.PaymentProposalItemsList.ForEach(item =>
            {
                item.APPaymentProposalItemDiscountFix = item.APPaymentProposalItemProposalAmount * mainObject.APPaymentProposalDiscountPercent / 100;
                BOSApp.RoundByCurrency(item, "APPaymentProposalItemDiscountFix", mainObject.FK_GECurrencyID);
            });
            entity.UpdateTotalAmount();
            entity.PaymentProposalItemsList.GridControl?.RefreshDataSource();
        }
        public void ChangeDiscountAmount()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)entity.MainObject;
            decimal totalAmount = 0, taxAmount = 0;
            foreach (APPaymentProposalItemsInfo item in entity.PaymentProposalItemsList)
            {
                totalAmount += item.APPaymentProposalItemProposalAmount;
                taxAmount += item.APPaymentProposalItemTaxAmount;
            }
            mainObject.APPaymentProposalDiscountPercent = totalAmount - taxAmount != 0 ? mainObject.APPaymentProposalDiscountFix / (totalAmount - taxAmount) * 100 : 0;
            entity.PaymentProposalItemsList.ForEach(item =>
            {
                item.APPaymentProposalItemDiscountFix = (item.APPaymentProposalItemProposalAmount / totalAmount) * mainObject.APPaymentProposalDiscountFix;
                BOSApp.RoundByCurrency(item, "APPaymentProposalItemDiscountFix", mainObject.FK_GECurrencyID);
            });
            entity.UpdateTotalAmount();
            entity.PaymentProposalItemsList.GridControl?.RefreshDataSource();
        }
        #region Đính Kèm File
        public void SaveDocumentFile()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)entity.MainObject;
            List<APFileAttachmentsInfo> documentTemplateList = entity.PaymentProposalTemplateList.ToList();

            APFileAttachmentsController objFileAttachmentsController = new APFileAttachmentsController();
            APFileAttachmentsInfo objFileAttachmentsInfo = new APFileAttachmentsInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            documentTemplateList.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.APFileAttachmentFileGUID))
                    return;

                entity.PaymentProposalTemplateURLDic.TryGetValue(o.APFileAttachmentID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.APFileAttachmentFileGUID = ApiClientHelper.UpdateFile(value);
                o.APFileAttachmentObjectID = mainObject.APPaymentProposalID;
                objFileAttachmentsController.UpdateObject(o);
            });
            entity.PaymentProposalTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.PaymentProposalTemplateList.GridControl?.RefreshDataSource();
        }

        public void BrowseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[PaymentProposalModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddFileTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[PaymentProposalModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
            {
                return;
            }

            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)entity.MainObject;

            if (entity.PaymentProposalTemplateList.Exists(o => o.APFileAttachmentName.Equals(DocumentFileName)))
            {
                MessageBox.Show(SaleOrderLocalizedResources.DuplicateFileName,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            APFileAttachmentsInfo objFileAttachmentsInfo = new APFileAttachmentsInfo();
            objFileAttachmentsInfo.APFileAttachmentName = DocumentFileName;
            objFileAttachmentsInfo.APFileAttachmentTableName = BOSUtil.GetTableNameFromBusinessObject(mainObject);
            objFileAttachmentsInfo.APFileAttachmentObjectID = mainObject.APPaymentProposalID;
            objFileAttachmentsInfo.APFileAttachmentObjectItemID = 0;
            objFileAttachmentsInfo.APFileAttachmentModuleName = this.Name;
            objFileAttachmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objFileAttachmentsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objFileAttachmentsInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objFileAttachmentsInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.PaymentProposalTemplateList.Add(objFileAttachmentsInfo);
            entity.PaymentProposalTemplateList.GridControl?.RefreshDataSource();
        }

        public void RemoveFileTemplateList()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            entity.PaymentProposalTemplateList.RemoveSelectedRowObjectFromList();
            entity.PaymentProposalTemplateList.GridControl?.RefreshDataSource();
        }

        public void DownloadDocument()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)CurrentModuleEntity;
            APFileAttachmentsInfo objFileAttachmentsInfo = entity.PaymentProposalTemplateList[entity.PaymentProposalTemplateList.CurrentIndex];
            if (objFileAttachmentsInfo == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(objFileAttachmentsInfo.APFileAttachmentFileGUID))
            {
                MessageBox.Show(SaleOrderLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objFileAttachmentsInfo.APFileAttachmentFileGUID, objFileAttachmentsInfo.APFileAttachmentName);
        }

        internal void ViewFile()
        {
            throw new NotImplementedException();
        }

        internal void DeleteFile()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

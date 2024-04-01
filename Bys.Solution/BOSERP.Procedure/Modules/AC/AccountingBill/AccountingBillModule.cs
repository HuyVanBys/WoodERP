using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Localization;
using System;

namespace BOSERP.Modules.AccountingBill
{
    public class AccountingBillModule : BaseTransactionModule
    {
        #region Constants
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;

        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;

        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        // bool clearingDebts = false;
        #region Constructor
        public AccountingBillModule()
        {
            Name = "AccountingBill";
            CurrentModuleEntity = new AccountingBillEntities();
            CurrentModuleEntity.Module = this;

            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        }
        #endregion
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
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
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDocumentsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objDocumentsController.GetDocumentListForAccountingBillByBranchIDs(searchObject.ACDocumentNo,
                                                                searchObject.FK_ACDocumentTypeID,
                                                                objObjectsInfo.ACObjectID,
                                                                objObjectsInfo.ACObjectType,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.DocumentDateFrom,
                                                                searchObject.DocumentDateTo,
                                                                searchObject.FK_BRBranchID,
                                                                BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetDocumentListForAccountingBillByBranchID(searchObject.ACDocumentNo,
                                                                searchObject.FK_ACDocumentTypeID,
                                                                objObjectsInfo.ACObjectID,
                                                                objObjectsInfo.ACObjectType,
                                                                searchObject.FK_HREmployeeID,
                                                                searchObject.DocumentDateFrom,
                                                                searchObject.DocumentDateTo,
                                                                searchObject.FK_BRBranchID);
            }
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            return ds;
        }

        public override int GetDocumentTypeID()
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            int documentTypeID;
            if (mainObject.ACDocumentID == 0)
            {
                ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.NghiepVuKhac.ToString());
            }
            else
                documentTypeID = mainObject.FK_ACDocumentTypeID;
            return documentTypeID;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintAccountingBill(Toolbar.CurrentObjectID);
            }
        }

        /// <summary>
        /// Print the report of a common document
        /// </summary>
        /// <param name="documentID">Document id</param>
        public static void PrintDocument(int documentID)
        {
            RPDocument report = new RPDocument();
            InitDocumentReport(report, documentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        /// <summary>
        /// Init a report of common accounting document
        /// </summary>
        /// <param name="report">Given report</param>
        /// <param name="documentID">Document id</param>
        private static void InitDocumentReport(RPDocument report, int documentID)
        {
            //Set current branch info
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            List<ACDocumentEntrysInfo> entries = objReportsController.GetEntriesByDocumentID(documentID);
            report.DataSource = entries;
        }

        public void ChangeFK_ACObjectID(string objectAccessKey)
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            AccountingBillModule module = (AccountingBillModule)entity.Module;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            ACObjectsController objObjectsController = new ACObjectsController();
            objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(objectAccessKey);
            if (objObjectsInfo != null)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                mainObject.ACDocumentObjectTaxNumber = objDocumentsController.GetTaxNumber(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                entity.AccountingBillsList.ForEach(p =>
                {
                    p.FK_ACDebitObjectID = objObjectsInfo.ACObjectID;
                    p.ACDebitObjectType = objObjectsInfo.ACObjectType;
                    p.ACObjectAccessKey = objectAccessKey;
                });
                entity.UpdateMainObjectBindingSource();
            }
        }

        public void ChangeCurrency(int currencyID)
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;

            mainObject.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACDocumentDate);
            mainObject.ACDocumentExchangeRate = dCurrencyExchangeRate > 0 ? dCurrencyExchangeRate : 1;
            mainObject.ACDocumentTotalAmount = entity.AccountingBillsList.Sum(o => o.ACAccountingBillTotalAmount);
            mainObject.ACDocumentExchangeAmount = mainObject.ACDocumentTotalAmount * mainObject.ACDocumentExchangeRate;

            BOSApp.RoundByCurrency(mainObject, "ACDocumentExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(mainObject, "ACDocumentTotalAmount", currencyID);
            entity.UpdateMainObjectBindingSource();
        }

        public override int ActionSave()
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (string.IsNullOrEmpty(mainObject.ACObjectAccessKey))
            {
                MessageBox.Show("Vui lòng chọn đối tượng.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            entity.AccountingBillsList.EndCurrentEdit();
            if (entity.AccountingBillsList != null
                && entity.AccountingBillsList.Count > 0
                && entity.AccountingBillsList.Where(x => x.ACAccountingBillAmount > 0 && (x.FK_ACCreditAccountID == 0 || x.FK_ACDebitAccountID == 0)).ToList().Count() > 0)
            {
                BOSApp.ShowMessage("Vui lòng nhập đủ tài khoản nợ hoặc có ở dưới lưới!");
                return 0;
            }
            if (entity.AccountingBillsList != null
                && entity.AccountingBillsList.Count > 0
                && entity.AccountingBillsList.Where(x => x.ACAccountingBillTaxAmount > 0).ToList().Count() > 0
                && string.IsNullOrWhiteSpace(mainObject.ACDocumentTaxEntryType))
            {
                BOSApp.ShowMessage("Vui lòng chọn Loại thuế cho chứng từ này!");
                return 0;
            }
            String VATInfo = string.Empty;
            if (mainObject.ACDocumentTaxEntryType == DocumentTaxEntryType.ThueGTGTDuocKhauTru.ToString())
            {
                APInvoiceInTransactionsController objInvoiceInTransactionsController = new APInvoiceInTransactionsController();
                foreach (ACAccountingBillsInfo item in entity.AccountingBillsList)
                {
                    List<APInvoiceInTransactionsInfo> transactionList = objInvoiceInTransactionsController.CheckAvailableVATInfo(item.ACAccountingBillVoucherNo, item.ACAccountingBillInvoiceDate, item.ACAccountingBillVATSymbol, item.ACAccountingBillTaxNumber);
                    if (transactionList != null && transactionList.Count() > 0)
                    {
                        VATInfo += String.Format("(Số hoá đơn: {0}, số seri: {1}, mã số thuế: {2})", item.ACAccountingBillVoucherNo, item.ACAccountingBillVATSymbol, item.ACAccountingBillTaxNumber);
                        VATInfo += Environment.NewLine;
                    }    
                }
                if (!string.IsNullOrEmpty(VATInfo))
                {
                    if (MessageBox.Show(String.Format("Hoá đơn kê khai đã tồn tại /n {0}, có lưu lại chứng từ không?", VATInfo), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return 0;
                    }
                }    
            }    
            int documentID = base.ActionSave();

            ActionPosted();
            //Update ngay lai cho tat ca cac chung tu lien quan
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            objDocumentsController.UpdateReferenceFromDocument(mainObject.ACDocumentNo, mainObject.ACDocumentDate);
            return documentID;
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.CancelDocument, true);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, true);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
            if (mainObject.ACDocumentID > 0)
            {
                if (mainObject.ACDocumentStatus == DocumentStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.CancelDocument, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                }
                else if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.CancelDocument, false);
                }
                else if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.UnPosted.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, true);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.CancelDocument, true);
                }
            }
            if (!(Toolbar.IsNullOrNoneAction()))
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.CancelDocument, false);
            }
        }

        public void ActionNewClearingDebts()
        {
            base.ActionNew();
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = objDocumentTypesController.GetDocumentTypeByDocumentTypeName(DocumentTypeName.BuTroCongNo.ToString());
            if (objDocumentTypesInfo != null)
            {
                mainObject.FK_ACDocumentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void UpdateAccountDebitDocumentEntrys(ACDocumentEntrysInfo objDocumentEntrysInfo)
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(objDocumentEntrysInfo.FK_ACUnfinishedConstructionCostID);
            objDocumentEntrysInfo.FK_ACDebitAccountID = objUnfinishedConstructionCostsInfo.FK_ACAccountID;
            entity.DocumentEntryList.GridControl?.RefreshDataSource();
        }

        public void RemoveSelectedAccountingBill()
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            entity.AccountingBillsList.RemoveSelectedRowObjectFromList();
        }

        public void UpdateAccountingBillList()
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.AccountingBillsList.ForEach(p =>
            {
                p.ACAccountingBillExchangeAmount = p.ACAccountingBillAmount * mainObject.ACDocumentExchangeRate;
                p.ACAccountingBillTotalAmount = p.ACAccountingBillAmount + p.ACAccountingBillTaxAmount;
            });
            entity.AccountingBillsList.GridControl.RefreshDataSource();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            entity.DocumentEntryList.ForEach(p =>
            {
                objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == p.FK_ACObjectID && o.ACObjectType == p.ACObjectType);
                if (objObjectsInfo != null)
                {
                    p.ACObjectNo = objObjectsInfo.ACObjectNo;
                    p.ACObjectName = objObjectsInfo.ACObjectName;
                }
            });
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.InvoiceInTrans);

            #region Update CostObjectItems
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            foreach (ACAccountingBillsInfo item in entity.AccountingBillsList)
            {
                objCostObjectItemsController.InsertCostObjectItemByModuleNameAndItemID(this.Name, item.ACAccountingBillID, true);
            }
            #endregion
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            if (!CheckRelativeDocument())
            {
                return;
            }
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans, ModulePostingType.InvoiceInTrans);

            #region Update CostObjectItems
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            foreach (ACAccountingBillsInfo item in entity.AccountingBillsList)
            {
                objCostObjectItemsController.InsertCostObjectItemByModuleNameAndItemID(this.Name, item.ACAccountingBillID, false);
            }
            #endregion
            InvalidateToolbar();
        }

        public override void ModuleAfterCompleted()
        {
            ActionPosted();
            base.ModuleAfterCompleted();
        }

        public void ChangeProject(int projectID)
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.FK_PMProjectID = projectID;

            entity.AccountingBillsList.ForEach(o =>
            {
                o.FK_PMProjectID = mainObject.FK_PMProjectID;
            });
            entity.AccountingBillsList.GridControl.RefreshDataSource();
        }

        public void ChangeSegment(int segmentID)
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            mainObject.FK_ACSegmentID = segmentID;

            entity.AccountingBillsList.ForEach(o =>
            {
                o.FK_ACSegmentID = mainObject.FK_ACSegmentID;
            });
            entity.AccountingBillsList.GridControl.RefreshDataSource();
        }

        public static void PrintAccountingBill(int documentID)
        {
            RPAccountingBill report = new RPAccountingBill();
            InitAccountingBillReport(report, documentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        private static void InitAccountingBillReport(RPAccountingBill report, int documentID)
        {
            //Set current branch info
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo mainObject = (ACDocumentsInfo)objDocumentsController.GetObjectByID(documentID);
            if (mainObject != null)
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                XRLabel label = (XRLabel)report.FindControl("xr_lblBRBranchAddressLine3", false);
                if (label != null)
                    label.Text = objBranchsInfo.BRBranchContactAddressLine3;
                label = (XRLabel)report.FindControl("xr_lblBRBranchPhone", false);
                if (label != null)
                    label.Text = objBranchsInfo.BRBranchContactPhone;
                label = (XRLabel)report.FindControl("xr_lblBRBranchFax", false);
                if (label != null)
                    label.Text = objBranchsInfo.BRBranchContactFax;
                ACAccountingBillsController objAccountingBillsController = new ACAccountingBillsController();
                List<ACAccountingBillsInfo> listAccountingBills = objAccountingBillsController.GetAllAccountingBillsFromDocumentID(documentID);
                decimal totalAmount = listAccountingBills.Sum(p => p.ACAccountingBillExchangeAmount);
                XRLabel amountWord = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                if (amountWord != null)
                    amountWord.Text = ConvertAmountToWord.ReadAmount(totalAmount.ToString(), mainObject.FK_GECurrencyID);
                report.DataSource = listAccountingBills;
            }
        }

        public void ActionCancelDocument()
        {
            if (!CheckLock()) return;
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (mainObject.ACDocumentPostedStatus == PostedTransactionStatus.UnPosted.ToString())
                ActionUnPosted();
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentStatus = DocumentStatus.Canceled.ToString();
            entity.UpdateMainObject();
            entity.AccountingBillsList.Clear();
            entity.UpdateUnifinishedCost();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();

            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACDocumentStatus = DocumentStatus.New.ToString();
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            mainObject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            ToolbarNewActionName = mainObject.STToolbarActionName;
        }

        public void UpdateItemDesc()
        {
            AccountingBillEntities entity = (AccountingBillEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            if(!string.IsNullOrWhiteSpace(mainObject.ACDocumentDesc))
            {
                entity.AccountingBillsList.ForEach(o => o.ACAccountingBillDesc = mainObject.ACDocumentDesc);
            }
        }

        private bool CheckRelativeDocument()
        {
            ACDocumentsInfo mainObject = (ACDocumentsInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByAccountingBillID(mainObject.ACDocumentID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

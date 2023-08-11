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

namespace BOSERP.Modules.AdvanceRequest
{
    public class AdvanceRequestModule : BaseModuleERP
    {
        private AdvanceRequestItemsGridControl AdvanceRequestItemsGridControl;

        #region Constants

        public const string AdvanceRequestItemsGridControlName = "fld_dgcHRAdvanceRequestItems";
        public const string EmployeeLookupEditControlName = "fld_lkeHREmployeeID";
        public const string AdvanceRequestDateEditControlName = "fld_dteHRAdvanceRequestDate";

        #endregion Constants

        #region Private Properties
        BOSLookupEdit EmployeeLookupEditControl;
        BOSDateEdit AdvanceRequestDateEditControl;
        #endregion Private Properties

        public AdvanceRequestModule()
        {
            Name = "AdvanceRequest";
            CurrentModuleEntity = new AdvanceRequestEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            AdvanceRequestItemsGridControl = (AdvanceRequestItemsGridControl)Controls[AdvanceRequestItemsGridControlName];
            EmployeeLookupEditControl = (BOSLookupEdit)Controls[EmployeeLookupEditControlName];
            AdvanceRequestDateEditControl = (BOSDateEdit)Controls[AdvanceRequestDateEditControlName];
            AdvanceRequestDateEditControl.DateTime = DateTime.Now;
        }
        /// <summary>
        /// Remove selected item
        /// </summary>
        public void RemoveSelectedItem()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            entity.AdvanceRequestItemList.RemoveSelectedRowObjectFromList();
        }
        /// <summary>
        /// Add item to advance request item list
        /// </summary>
        public void AddItemToAdvanceRequestItemList()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRAdvanceRequestItemsInfo objAdvanceRequestItemsInfo = (HRAdvanceRequestItemsInfo)CurrentModuleEntity.ModuleObjects[TableName.HRAdvanceRequestItemsTableName];

            guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
            guiSearchEmployee.Module = this;
            if (guiSearchEmployee.ShowDialog() != DialogResult.OK)
                return;
            guiSearchEmployee.SelectedEmployeeList.ToList().ForEach(o =>
            {
                if (!IsExit(o))
                {
                    objAdvanceRequestItemsInfo = new HRAdvanceRequestItemsInfo();
                    objAdvanceRequestItemsInfo.HRAdvanceRequestItemStatus = AdvanceRequestStatus.New.ToString();
                    objAdvanceRequestItemsInfo.FK_HREmployeeID = o.HREmployeeID;
                    objAdvanceRequestItemsInfo.HRAdvanceRequestItemEmployeeNo = o.HREmployeeNo;
                    objAdvanceRequestItemsInfo.HRAdvanceRequestItemEmployeeName = o.HREmployeeName;
                    objAdvanceRequestItemsInfo.HREmployeeCardNumber = o.HREmployeeCardNumber;
                    objAdvanceRequestItemsInfo.HRAdvanceRequestItemDesc = mainObject.HRAdvanceRequestDesc;
                    entity.AdvanceRequestItemList.Add(objAdvanceRequestItemsInfo);
                }
            });
            entity.AdvanceRequestItemList.GridControl.RefreshDataSource();
        }
        //public void AddItemToAdvanceRequestItemList()
        //{
        //    AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
        //    HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
        //    HREmployeesController objEmployeesController = new HREmployeesController();
        //    HRAdvanceRequestItemsInfo objAdvanceRequestItemsInfo = (HRAdvanceRequestItemsInfo)CurrentModuleEntity.ModuleObjects[TableName.HRAdvanceRequestItemsTableName];
        //    int employeeID = 0;
        //    if (EmployeeLookupEditControl.EditValue != null)
        //    {
        //        employeeID = int.Parse(EmployeeLookupEditControl.EditValue.ToString());
        //        HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeID);

        //        bool isExitEmployee = false;
        //        if (objEmployeesInfo != null)
        //        {
        //            isExitEmployee = IsExit(objEmployeesInfo);
        //            if (!isExitEmployee)
        //            {
        //                objAdvanceRequestItemsInfo.HRAdvanceRequestItemStatus = AdvanceRequestStatus.New.ToString();
        //                objAdvanceRequestItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
        //                objAdvanceRequestItemsInfo.HRAdvanceRequestItemEmployeeNo = objEmployeesInfo.HREmployeeNo;
        //                objAdvanceRequestItemsInfo.HRAdvanceRequestItemEmployeeName = objEmployeesInfo.HREmployeeName;
        //                objAdvanceRequestItemsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
        //                objAdvanceRequestItemsInfo.HRAdvanceRequestItemDesc = mainObject.HRAdvanceRequestDesc;
        //                entity.AdvanceRequestItemList.AddObjectToList();
        //            }
        //            else
        //            {
        //                MessageBox.Show(AdvanceRequestLocalizedResources.EmployeeIsExistMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //}
        /// <summary>
        /// Check is exit employee in list
        /// </summary>
        /// <param name="objEmployeesInfo"></param>
        /// <returns></returns>
        public bool IsExit(HREmployeesInfo objEmployeesInfo)
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            foreach (HRAdvanceRequestItemsInfo item in entity.AdvanceRequestItemList)
            {
                if (objEmployeesInfo.HREmployeeID == item.FK_HREmployeeID)
                    return true;
            }
            return false;
        }
        public override int ActionSave()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
            if (mainObject.HRAdvanceRequestType == AdvanceRequestType.Construction.ToString() && mainObject.FK_PMProjectID <= 0)
            {
                MessageBox.Show(AdvanceRequestLocalizedResources.ErrorPMProjectID, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            entity.AdvanceRequestItemList.ForEach(o =>
                {
                    if (String.IsNullOrEmpty(o.HRAdvanceRequestItemDesc))
                        o.HRAdvanceRequestItemDesc = mainObject.HRAdvanceRequestDesc;
                });
            entity.AdvanceRequestItemList.EndCurrentEdit();

            bool validLoan = true;
            if (mainObject.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString())
            {
                if (entity.AdvanceRequestItemList.Count > 0)
                {
                    entity.AdvanceRequestItemList.ForEach(o =>
                    {
                        if (o.AdvanceRequestItemLoanDetailsList == null)
                            validLoan = false;
                        else if (o.HRAdvanceRequestItemTotalAmount != o.AdvanceRequestItemLoanDetailsList.Sum(s => s.HRAdvanceRequestItemLoanDetailTotalAmount))
                            validLoan = false;
                    });
                }
            }
            if (!validLoan)
            {
                MessageBox.Show(AdvanceRequestLocalizedResources.ErrorLoan, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            return base.ActionSave();
        }

        public override bool ActionComplete()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsController objAdvanceRequestsController = new HRAdvanceRequestsController();
            bool isCompleted = base.ActionComplete();
            if (isCompleted)
            {
                entity.SetPropertyChangeEventLock(false);
                HRAdvanceRequestsInfo objAdvanceRequestsInfo = (HRAdvanceRequestsInfo)entity.MainObject;
                objAdvanceRequestsInfo.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objAdvanceRequestsInfo.HRAdvanceRequestStatus = AdvanceRequestStatus.Complete.ToString();
                objAdvanceRequestsController.UpdateObject(objAdvanceRequestsInfo);
                //Set status AdvanceRequestItem               
                foreach (HRAdvanceRequestItemsInfo item in entity.AdvanceRequestItemList)
                {
                    item.HRAdvanceRequestItemStatus = AdvanceRequestStatus.Complete.ToString();
                }
                entity.AdvanceRequestItemList.SaveItemObjects();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
            return isCompleted;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRAdvanceRequestsInfo objAdvanceRequestsInfo = (HRAdvanceRequestsInfo)CurrentModuleEntity.MainObject;
            objAdvanceRequestsInfo.HRAdvanceRequestStatus = AdvanceRequestStatus.New.ToString();
            objAdvanceRequestsInfo.HRAdvanceRequestExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;

            LoadAdvanceRequestItemGridView(false, false);
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            HRAdvanceRequestsInfo objAdvanceRequestsInfo = (HRAdvanceRequestsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (objAdvanceRequestsInfo.HRAdvanceRequestID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (objAdvanceRequestsInfo.HRAdvanceRequestStatus == AdvanceRequestStatus.Advanced.ToString()
                    || objAdvanceRequestsInfo.HRAdvanceRequestStatus == AdvanceRequestStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
            if (!Toolbar.IsNullOrNoneAction())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            }
        }

        public void PrintAdvanceRequest()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPAdvancePayment report = new RPAdvancePayment();
                InitPrintAdvancePaymentReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        public void InitPrintAdvancePaymentReport(RPAdvancePayment report)
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsInfo objAdvanceRequestsInfo = (HRAdvanceRequestsInfo)entity.MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objCurrenciesInfo = objCurrenciesController.GetObjectByID(objAdvanceRequestsInfo.FK_GECurrencyID) as GECurrenciesInfo;
            List<HRAdvanceRequestItemsInfo> advanceRequestItemsList = entity.AdvanceRequestItemList.ToList();
            HRAdvanceRequestItemsInfo defaultAdvanceRequestItemsInfo = advanceRequestItemsList.FirstOrDefault();
            if (defaultAdvanceRequestItemsInfo == null)
                defaultAdvanceRequestItemsInfo = new HRAdvanceRequestItemsInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetEmployeeForReportByID(defaultAdvanceRequestItemsInfo.FK_HREmployeeID);
            report.bsEmployeesInfo.DataSource = objEmployeesInfo;
            report.bsHRAdvanceRequestsInfo.DataSource = objAdvanceRequestsInfo;
            decimal totalAmount = advanceRequestItemsList.Select(o => o.HRAdvanceRequestItemTotalAmount).Sum();
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["pnlToDate"].Controls["xr_lblProposalToDate"];
            if (label != null)
            {
                label.Text = BOSApp.GetCurrentServerDate().ToString("dd/MM/yyyy");
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRAdvanceRequestDesc"];
            if (label != null)
            {
                label.Text = objAdvanceRequestsInfo.HRAdvanceRequestDesc;
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["pnlTitleAdvanceRequest"].Controls["xr_lblAdvanceRequestDate"];
            if (label != null)
            {
                label.Text = string.Format(label.Text
                                           , objAdvanceRequestsInfo.HRAdvanceRequestDate.Day
                                           , objAdvanceRequestsInfo.HRAdvanceRequestDate.Month
                                           , objAdvanceRequestsInfo.HRAdvanceRequestDate.Year);
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAdvanceRequestTotalAmount"];
            if (label != null)
            {
                if (objCurrenciesInfo != null)
                {
                    if (objCurrenciesInfo.GECurrencyNo == "VND")
                        label.Text = string.Format(label.Text, totalAmount.ToString("n0")) + string.Format(" {0}", "đồng");
                    else
                        label.Text = string.Format(label.Text, totalAmount.ToString("n2")) + string.Format(" {0}", objCurrenciesInfo.GECurrencyNo);
                }
                else
                    label.Text = string.Format(label.Text, totalAmount.ToString("n2"));
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAdvanceRequestTotalAmountString"];
            if (label != null)
            {
                label.Text = ConvertAmountToWord.ReadAmount(totalAmount.ToString("n3"), objAdvanceRequestsInfo.FK_GECurrencyID);
            }
        }

        public void CalPaymentPerMonthAmount(HRAdvanceRequestItemsInfo item)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
                HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;

                if (mainObject.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString())
                {
                    if (item.HRAdvanceRequestItemPaymentMonthQty > 0)
                    {
                        item.HRAdvanceRequestItemPaymentPerMonthAmount
                            = item.HRAdvanceRequestItemTotalAmount / item.HRAdvanceRequestItemPaymentMonthQty;

                        BOSApp.RoundByCurrency(item, "HRAdvanceRequestItemPaymentPerMonthAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    }
                    else
                    {
                        item.HRAdvanceRequestItemPaymentPerMonthAmount = 0;
                    }
                    entity.AdvanceRequestItemList.GridControl.RefreshDataSource();
                    GenerateLoadDetail(item);
                }
            }
        }

        public void ChangeAdvanceRequestType(string type)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
                HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
                mainObject.HRAdvanceRequestType = type;
                string advanceRequestTypeName = string.Empty;
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo typeDesc = objConfigValuesController.GetObjectByGroupAndValue("AdvanceRequestType", mainObject.HRAdvanceRequestType);
                if (typeDesc != null)
                    advanceRequestTypeName = typeDesc.ADConfigText;
                if (mainObject.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString())
                {
                    entity.AdvanceRequestItemList.ForEach(o =>
                    {
                        o.HRAdvanceRequestItemPaymentType = AdvanceRequestItemPaymentType.AddToSalary.ToString();
                        o.HRAdvanceRequestTypeName = typeDesc.ADConfigText;
                    });
                }
                else
                {
                    entity.AdvanceRequestItemList.ForEach(o =>
                    {
                        o.HRAdvanceRequestItemPaymentType = string.Empty;
                        o.HRAdvanceRequestTypeName = typeDesc.ADConfigText;
                    });
                }
                LoadAdvanceRequestItemGridView(false, mainObject.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString());
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRAdvanceRequestsController objAdvanceRequestsController = new HRAdvanceRequestsController();
            return objAdvanceRequestsController.GetAdvanceRequestsList();
        }

        public void ChangeCurrency(int currency)
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currency;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.HRAdvanceRequestDate);
            mainObject.HRAdvanceRequestExchangeRate = (dCurrencyExchangeRate > 0)
                                                               ? dCurrencyExchangeRate
                                                               : 1;
            entity.UpdateMainObjectBindingSource();
        }

        #region Chi tiết Tạm ứng vay
        public void LoadAdvanceRequestItemGridView(bool isComplete, bool isLoan)
        {
            if (AdvanceRequestItemsGridControl != null)
            {
                AdvanceRequestItemsGridControl.LoadGridViewByType(isComplete, isLoan);
            }
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)CurrentModuleEntity.MainObject;
            LoadAdvanceRequestItemGridView(mainObject.HRAdvanceRequestStatus == AdvanceRequestStatus.Complete.ToString(), mainObject.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString());
        }

        public void ShowLoanDetail()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
            int index = entity.AdvanceRequestItemList.CurrentIndex;
            if (mainObject.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString() && index >= 0)
            {
                HRAdvanceRequestItemsInfo item = (HRAdvanceRequestItemsInfo)entity.AdvanceRequestItemList[index];
                if (item != null)
                {
                    if (Toolbar.IsNullOrNoneAction())
                    {
                        item.AdvanceRequestItemLoanDetailsList = new BOSList<HRAdvanceRequestItemLoanDetailsInfo>();
                        item.AdvanceRequestItemLoanDetailsList.InitBOSList(
                                                            CurrentModuleEntity,
                                                            TableName.HRAdvanceRequestItemsTableName,
                                                            TableName.HRAdvanceRequestItemLoanDetailsTableName,
                                                            BOSList<HRAdvanceRequestItemLoanDetailsInfo>.cstRelationForeign);
                        item.AdvanceRequestItemLoanDetailsList.ItemTableForeignKey = "FK_HRAdvanceRequestItemID";
                        item.AdvanceRequestItemLoanDetailsList.Invalidate(item.HRAdvanceRequestItemID);
                    }

                    if (item.AdvanceRequestItemLoanDetailsList == null)
                    {
                        item.AdvanceRequestItemLoanDetailsList = new BOSList<HRAdvanceRequestItemLoanDetailsInfo>();
                        item.AdvanceRequestItemLoanDetailsList.InitBOSList(
                                                            CurrentModuleEntity,
                                                            TableName.HRAdvanceRequestItemsTableName,
                                                            TableName.HRAdvanceRequestItemLoanDetailsTableName,
                                                            BOSList<HRAdvanceRequestItemLoanDetailsInfo>.cstRelationForeign);
                        item.AdvanceRequestItemLoanDetailsList.ItemTableForeignKey = "FK_HRAdvanceRequestItemID";
                    }
                    entity.HRAdvanceRequestItemLoanDetailsList.Invalidate(item.AdvanceRequestItemLoanDetailsList);
                    guiLoanDetail guiLoanDetail = new guiLoanDetail(item.HRAdvanceRequestItemTotalAmount, !Toolbar.IsNullOrNoneAction());
                    guiLoanDetail.Module = this;
                    if (guiLoanDetail.ShowDialog() == DialogResult.OK)
                    {
                        item.AdvanceRequestItemLoanDetailsList.Invalidate(entity.HRAdvanceRequestItemLoanDetailsList);
                        if (mainObject.HRAdvanceRequestStatus == AdvanceRequestStatus.New.ToString())
                        {
                            item.HRAdvanceRequestItemPaymentMonthQty = item.AdvanceRequestItemLoanDetailsList.Count();
                            item.HRAdvanceRequestItemPaymentPerMonthAmount = item.HRAdvanceRequestItemPaymentMonthQty == 0 ? 0 : item.HRAdvanceRequestItemTotalAmount / item.HRAdvanceRequestItemPaymentMonthQty;
                            if (Toolbar.IsNullOrNoneAction())
                                entity.SaveSingleLoanDetail(item);
                        }
                    };
                }
            }
        }

        public void GenerateLoadDetail(HRAdvanceRequestItemsInfo item)
        {
            if (item.AdvanceRequestItemLoanDetailsList == null)
            {
                item.AdvanceRequestItemLoanDetailsList = new BOSList<HRAdvanceRequestItemLoanDetailsInfo>();
                item.AdvanceRequestItemLoanDetailsList.InitBOSList(
                                                    CurrentModuleEntity,
                                                    TableName.HRAdvanceRequestItemsTableName,
                                                    TableName.HRAdvanceRequestItemLoanDetailsTableName,
                                                    BOSList<HRAdvanceRequestItemLoanDetailsInfo>.cstRelationForeign);
                item.AdvanceRequestItemLoanDetailsList.ItemTableForeignKey = "FK_HRAdvanceRequestItemID";
            }

            item.AdvanceRequestItemLoanDetailsList.Clear();
            DateTime startDate = new DateTime(item.HRAdvanceRequestItemPaymentStartDate.Year, item.HRAdvanceRequestItemPaymentStartDate.Month, 1);

            for (int i = 0; i < item.HRAdvanceRequestItemPaymentMonthQty; i++)
            {
                HRAdvanceRequestItemLoanDetailsInfo objARILDsInfo = new HRAdvanceRequestItemLoanDetailsInfo();
                objARILDsInfo.HRAdvanceRequestItemLoanDetailDate = startDate;
                objARILDsInfo.HRAdvanceRequestItemLoanDetailTotalAmount = item.HRAdvanceRequestItemPaymentPerMonthAmount;
                startDate = startDate.AddMonths(1);
                item.AdvanceRequestItemLoanDetailsList.Add(objARILDsInfo);
            }

            if (item.AdvanceRequestItemLoanDetailsList.Count() == 0)
            {
                HRAdvanceRequestItemLoanDetailsInfo objARILDsInfo = new HRAdvanceRequestItemLoanDetailsInfo();
                objARILDsInfo.HRAdvanceRequestItemLoanDetailDate = item.HRAdvanceRequestItemPaymentStartDate;
                objARILDsInfo.HRAdvanceRequestItemLoanDetailTotalAmount = item.HRAdvanceRequestItemTotalAmount;
                item.AdvanceRequestItemLoanDetailsList.Add(objARILDsInfo);
            }
        }

        public void RemoveSelectedLoanDetailItem()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)entity.MainObject;
            if (mainObject.HRAdvanceRequestStatus == AdvanceRequestStatus.New.ToString())
            {
                if (MessageBox.Show("Bạn muốn chắc chắn muốn xóa không?",
                                               CommonLocalizedResources.MessageBoxDefaultCaption,
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                entity.HRAdvanceRequestItemLoanDetailsList.RemoveObjectFromList(entity.HRAdvanceRequestItemLoanDetailsList.CurrentIndex);
            }
        }
        #endregion

        #region Mở - Xóa chứng từ
        public override bool ActionCancelComplete()
        {
            AdvanceRequestEntities entity = (AdvanceRequestEntities)CurrentModuleEntity;
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.HRAdvanceRequestID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                mainObject.HRAdvanceRequestStatus = AdvanceRequestStatus.New.ToString();
                entity.AdvanceRequestItemList.ForEach(o => o.HRAdvanceRequestItemStatus = AdvanceRequestStatus.New.ToString());
                entity.AdvanceRequestItemList.SaveItemObjects();
                CurrentModuleEntity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                base.ActionCancelComplete();
                InvalidateToolbar();
            }
            return true;
        }

        public override void ActionDelete()
        {
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)CurrentModuleEntity.MainObject.Clone();
            if (mainObject.HRAdvanceRequestID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                base.ActionDelete();
            }
        }
        
        private bool CheckRelativeDocument()
        {
            HRAdvanceRequestsInfo mainObject = (HRAdvanceRequestsInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByAdvanceRequestID(mainObject.HRAdvanceRequestID);
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
        #endregion
    }
}

using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.LoanReceipt
{
    public class LoanReceiptModule : BaseModuleERP
    {
        #region Constants
        public const string LoanReceiptItemGridControlName = "fld_dgcACLoanReceiptItems";
        public const string LoanReceiptPayDocsGridControlName = "fld_dgcACLoanReceiptPayDocs";
        public const string LoanReceiptInterestRateChangesGridControlName = "fld_dgcACLoanReceiptInterestRateChanges";
        public const string ACLoanReceiptPaymentPlansGridControlName = "fld_dgcACLoanReceiptPaymentPlans";
        public const string ACLoanReceiptPaymentForMonthTexboxControlName = "fld_txtACLoanReceiptPaymentForMonth";
        #endregion

        #region Properties
        //LoanReceipt Template
        public const string FilePathTextBoxName = "fld_txtFilePath";
        private string LoanReceiptFileName = string.Empty;
        public const string LoanReceiptTemplateGridControlName = "fld_dgcLoanReceiptTemplates";
        private BOSGridControl LoanReceiptTemplateGridControl;
        private string DocumentFileName = string.Empty;
        public BOSTextBox ACLoanReceiptPaymentForMonthTexboxControl { get; set; }
        #endregion

        #region Constructor
        public LoanReceiptModule()
        {
            Name = "LoanReceipt";
            CurrentModuleEntity = new LoanReceiptEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            ACLoanReceiptPaymentForMonthTexboxControl = (BOSTextBox)Controls[ACLoanReceiptPaymentForMonthTexboxControlName];
            InvalidatePaymentForMonth(string.Empty);
            LoanReceiptTemplateGridControl = (BOSGridControl)Controls[LoanReceiptModule.LoanReceiptTemplateGridControlName];
            GetCurrentModuleDataViewPermission();
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

        public override void ActionNew()
        {
            base.ActionNew();
        }

        public override int ActionSave()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            ACLoanAgreementsController objLoanAgreementsController = new ACLoanAgreementsController();
            UpdatePaymentPlanByInterestRateChanges();
            ACLoanAgreementsInfo objLoanAgreementsInfo = (ACLoanAgreementsInfo)objLoanAgreementsController.GetObjectByID(objLoanReceiptsInfo.FK_ACLoanAgreementID);
            decimal loanReceiptAmount = objLoanReceiptsInfo.ACLoanReceiptAmount;
            if (objLoanAgreementsInfo != null && objLoanAgreementsInfo.FK_GECurrencyID == GECurrencyID.VND)
            {
                loanReceiptAmount = objLoanReceiptsInfo.ACLoanReceiptAmount * objLoanReceiptsInfo.ACLoanReceiptExchangeRate;
            }

            if (objLoanReceiptsInfo.ACLoanReceiptID > 0)
            {
                decimal loanAgreementRemainAmount = objLoanAgreementsController.GetRemainAmountByLoanGreementIDAndLoanReceiptID(objLoanReceiptsInfo.FK_ACLoanAgreementID, objLoanReceiptsInfo.ACLoanReceiptID);

                if (loanAgreementRemainAmount < loanReceiptAmount)
                {
                    MessageBox.Show(LoanReceiptLocalizedResources.LoanReceiptAmountNotbigLoanArgeementRemainAmount
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            else
            {
                if (objLoanAgreementsInfo != null)
                {
                    if (objLoanAgreementsInfo.ACLoanAgreementRemainAmount < loanReceiptAmount)
                    {
                        MessageBox.Show(LoanReceiptLocalizedResources.LoanReceiptAmountNotbigLoanArgeementRemainAmount
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
            }
            if (objLoanReceiptsInfo.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OutstandingDebtIncreasing.ToString())
            {
                if (entity.LoanReceiptPaymentPlanList != null && entity.LoanReceiptPaymentPlanList.Count > 0)
                {
                    if (entity.LoanReceiptPaymentPlanList.Any(o => o.ACLoanReceiptPaymentPlanRootPayment < 0))
                    {
                        MessageBox.Show("Giá trị gốc nộp không được âm"
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
            }
            else
            {
                if (entity.LoanReceiptPaymentPlanList != null && entity.LoanReceiptPaymentPlanList.Count > 0)
                {
                    decimal totalAmount = entity.LoanReceiptPaymentPlanList.Sum(a => a.ACLoanReceiptPaymentPlanRootPayment);
                    if (totalAmount > objLoanReceiptsInfo.ACLoanReceiptAmount)
                    {
                        MessageBox.Show(LoanReceiptLocalizedResources.TotalRootAmountNotBigLoanReceiptAmount
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
            }

            if(objLoanReceiptsInfo.FK_ACLoanReceiptTypeID <= 0)
            {
                MessageBox.Show("Vui lòng chọn Loại khế ước trước khi Lưu!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }    

            bool check = ChangeLoanReceiptExchangeAmount();
            if (!check)
            {
                MessageBox.Show("Số tiền quy đổi lệch quá nhiều so với tính toán theo Tỷ giá" + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }    

            UpdateTotalCost();
            int LoanReceiptID = base.ActionSave();
            if (LoanReceiptID > 0)
            {
                SaveDocumentFile();
                ResetSearchObject();
            }
            return LoanReceiptID;
        }

        /// <summary>
        /// Delete item from LoanReceipt Item List
        /// </summary>
        public void DeleteItemFromLoanReceiptItemsList()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            entity.LoanReceiptItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalCost();
        }
        /// <summary>
        /// Delete item from LoanReceipt Item List
        /// </summary>
        public void DeleteItemFromLoanReceiptPayDocsList()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            entity.LoanReceiptPayDocList.RemoveSelectedRowObjectFromList();
            UpdateTotalCost();
        }

        public void UpdateTotalCost()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
                entity.UpdateTotalCost();
            }
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            entity.LoanReceiptItemList.BackupList = new List<ACLoanReceiptItemsInfo>();
            foreach (ACLoanReceiptItemsInfo item in entity.LoanReceiptItemList)
            {
                entity.LoanReceiptItemList.BackupList.Add((ACLoanReceiptItemsInfo)item.Clone());
            }
        }

        public void ChangeExchangeAmount()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            if (objLoanReceiptsInfo.ACLoanReceiptAmount > 0 || objLoanReceiptsInfo.ACLoanReceiptExchangeRate > 0)
            {
                objLoanReceiptsInfo.ACLoanReceiptExchangeAmount = objLoanReceiptsInfo.ACLoanReceiptExchangeRate * objLoanReceiptsInfo.ACLoanReceiptAmount;
                BOSApp.RoundByCurrency(objLoanReceiptsInfo, "ACLoanReceiptExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeCurrency(int currencyID)
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            objLoanReceiptsInfo.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(objLoanReceiptsInfo.FK_GECurrencyID, objLoanReceiptsInfo.ACLoanReceiptDate);
            objLoanReceiptsInfo.ACLoanReceiptExchangeRate = (dCurrencyExchangeRate > 0)
                                                               ? dCurrencyExchangeRate
                                                               : 1;
            foreach (ACLoanReceiptItemsInfo item in entity.LoanReceiptItemList)
            {
                BOSApp.RoundByCurrency(item, currencyID);
            }

            BOSApp.RoundByCurrency(objLoanReceiptsInfo, currencyID);
            BOSApp.RoundByCurrency(objLoanReceiptsInfo, "ACLoanReceiptExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
        }

        public void ChangeLoanAgreementID(int loanAgreementID)
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            ACLoanAgreementsController objLoanAgreementsController = new ACLoanAgreementsController();
            ACLoanAgreementsInfo objLoanAgreementsInfo = (ACLoanAgreementsInfo)objLoanAgreementsController.GetObjectByID(loanAgreementID);
            if (objLoanAgreementsInfo == null)
                return;
            objLoanReceiptsInfo.FK_CSCompanyBankID = objLoanAgreementsInfo.FK_CSCompanyBankID;
            objLoanReceiptsInfo.FK_GECurrencyID = objLoanAgreementsInfo.FK_GECurrencyID;
            objLoanReceiptsInfo.FK_PMProjectID = objLoanAgreementsInfo.FK_PMProjectID;
            GECurrenciesInfo objCurrenciesInfo = BOSApp.RealTimeExchageRateByCurrency(objLoanReceiptsInfo.FK_GECurrencyID);
            if (objLoanReceiptsInfo.ACLoanReceiptID == 0 && objCurrenciesInfo != null)
            {
                objLoanReceiptsInfo.ACLoanReceiptExchangeRate = objCurrenciesInfo.BuyExchangeRate;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void DeleteItemFromLoanReceiptPaymentPlanList()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            entity.LoanReceiptPaymentPlanList.RemoveSelectedRowObjectFromList();
        }

        public void GenarateLoanReceiptPaymentPlans()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            if (objLoanReceiptsInfo.ACLoanReceiptID > 0)
            {
                ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
                List<ACLoanReceiptsInfo> LoanReceiptList = objLoanReceiptsController.CheckPaymentVoucherAndACBankTransactionByLoanReceiptID(objLoanReceiptsInfo.ACLoanReceiptID);
                if (LoanReceiptList != null && LoanReceiptList.Count > 0)
                {
                    MessageBox.Show("Khế ước vay này đã tạo chứng từ ở phiếu chi, báo nợ nên không thể tạo mới lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (string.IsNullOrEmpty(objLoanReceiptsInfo.ACLoanReceiptProfitMethod))
            {
                MessageBox.Show(LoanReceiptLocalizedResources.ValidateLoanReceiptProfitMethodMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (objLoanReceiptsInfo.ACLoanReceiptLimit <= 0)
            {
                MessageBox.Show(LoanReceiptLocalizedResources.ValidateLoanReceiptLimitMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entity.LoanReceiptPaymentPlanList.Clear();
            ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = null;
            for (int i = 1; i <= objLoanReceiptsInfo.ACLoanReceiptLimit; i++)
            {
                switch ((LoanReceiptProfitMethod)Enum.Parse(typeof(LoanReceiptProfitMethod), objLoanReceiptsInfo.ACLoanReceiptProfitMethod))
                {
                    case LoanReceiptProfitMethod.OriginalDebt:
                        objLoanReceiptPaymentPlansInfo = new ACLoanReceiptPaymentPlansInfo()
                        {
                            ACLoanReceiptPaymentPlanPeriod = i.ToString(),
                            ACLoanReceiptPaymentPlanDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i),
                            //ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - (entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment)),

                        };
                        if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPeriod == objLoanReceiptsInfo.ACLoanReceiptLimit.ToString())
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount - entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment);
                        }
                        else
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = (objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount) / objLoanReceiptsInfo.ACLoanReceiptLimit;
                        }
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptsInfo.ACLoanReceiptAmount * objLoanReceiptsInfo.ACLoanReceiptInterestRate / 100 / 12;
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptsInfo.FK_GECurrencyID);


                        if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPeriod == "1")
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount;
                        else
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount
                                                                                                    - (entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment));
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment
                                                                                         + objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment;

                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i - 1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        //[HuyNN][Tất cả các đợt trả: ngày hết hạn = ngày kế hoạch = ngày của ngày nhận nợ - 1 / tháng của ngày nhận nợ + 1][End]
                        break;

                    case LoanReceiptProfitMethod.OutstandingDebt:
                        objLoanReceiptPaymentPlansInfo = new ACLoanReceiptPaymentPlansInfo()
                        {
                            ACLoanReceiptPaymentPlanPeriod = i.ToString(),
                            ACLoanReceiptPaymentPlanDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i),
                        };
                        if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPeriod == objLoanReceiptsInfo.ACLoanReceiptLimit.ToString())
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount - entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment);
                        }
                        else
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = (objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount) / objLoanReceiptsInfo.ACLoanReceiptLimit;
                        }
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPeriod == "1")
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount;
                        }   
                        else
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount
                                                                                                    - (entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment));
                        }

                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i - 1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay = Convert.ToDecimal((objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate).Days + 1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance
                                                                                                * objLoanReceiptsInfo.ACLoanReceiptInterestRate / 100 / 12;
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment
                                                                                         + objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment;
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        break;

                    case LoanReceiptProfitMethod.FixedNeedles:
                        objLoanReceiptPaymentPlansInfo = new ACLoanReceiptPaymentPlansInfo()
                        {
                            ACLoanReceiptPaymentPlanPeriod = i.ToString(),
                            ACLoanReceiptPaymentPlanDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i),
                            //ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - (entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment)),
                            ACLoanReceiptPaymentPlanPayment = objLoanReceiptsInfo.ACLoanReceiptPaymentForMonth,

                        };
                        if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPeriod == "1")
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount;
                        else
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount
                                                                                                    - (entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment));
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance
                                                                                            * (objLoanReceiptsInfo.ACLoanReceiptInterestRate / 100 / 12);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment
                                                                                            - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment;
                        //objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate;
                        //objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate;
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptsInfo.FK_GECurrencyID);

                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i - 1);
                        //[HuyNN][Đợt trả 1: ngày bắt đầu = ngày nhận nợ][End]
                        //[HuyNN][Tất cả các đợt trả: ngày hết hạn = ngày kế hoạch = ngày của ngày nhận nợ - 1 / tháng của ngày nhận nợ + 1][Start]
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        //[HuyNN][Tất cả các đợt trả: ngày hết hạn = ngày kế hoạch = ngày của ngày nhận nợ - 1 / tháng của ngày nhận nợ + 1][End]
                        break;

                    case LoanReceiptProfitMethod.OriginalPaypal:
                        objLoanReceiptPaymentPlansInfo = new ACLoanReceiptPaymentPlansInfo()
                        {
                            ACLoanReceiptPaymentPlanPeriod = i.ToString(),
                            ACLoanReceiptPaymentPlanDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i),
                            ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount
                                                                    - (entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment)) - entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanActualRootPayment),
                            ACLoanReceiptPaymentPlanPayment = objLoanReceiptsInfo.ACLoanReceiptPaymentForMonth,

                        };
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptsInfo.ACLoanReceiptAmount * (objLoanReceiptsInfo.ACLoanReceiptInterestRate / 100 / 12);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = 0;
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment
                                                                                       + objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment;

                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i - 1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);

                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        break;
                    case LoanReceiptProfitMethod.OutstandingDebtIncreasing:
                        objLoanReceiptPaymentPlansInfo = new ACLoanReceiptPaymentPlansInfo()
                        {
                            ACLoanReceiptPaymentPlanPeriod = i.ToString(),
                            ACLoanReceiptPaymentPlanDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i),
                            ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount
                                                                - (entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanRootPayment)) - entity.LoanReceiptPaymentPlanList.Sum(o => o.ACLoanReceiptPaymentPlanActualRootPayment),
                            ACLoanReceiptPaymentPlanPayment = objLoanReceiptsInfo.ACLoanReceiptPaymentForMonth,

                        };
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptsInfo.ACLoanReceiptAmount * (objLoanReceiptsInfo.ACLoanReceiptInterestRate / 100 / 12);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = 0;
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment
                                                                                       + objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment;

                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = objLoanReceiptsInfo.ACLoanReceiptDate.AddMonths(i - 1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(+1);

                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        BOSApp.RoundByCurrency(objLoanReceiptPaymentPlansInfo, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptsInfo.FK_GECurrencyID);
                        break;
                }
                entity.LoanReceiptPaymentPlanList.Add(objLoanReceiptPaymentPlansInfo);
            }
            if (objLoanReceiptsInfo.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OriginalPaypal.ToString() || objLoanReceiptsInfo.ACLoanReceiptProfitMethod == LoanReceiptProfitMethod.OutstandingDebtIncreasing.ToString())
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                for (int j = 0; j <= entity.LoanReceiptPaymentPlanList.Count() - 1; j++)
                {
                    objLoanReceiptPaymentPlansInfo = entity.LoanReceiptPaymentPlanList[j];
                    objLoanReceiptPaymentPlansInfo = UpdateValueLoanReceiptPaymentPlanByIndex(objLoanReceiptPaymentPlansInfo, j, objLoanReceiptsInfo, entity.LoanReceiptPaymentPlanList, false);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanActualRootPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanOpeningBalance", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanBeginDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanEndDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentDay", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment);
                }
            }
            entity.LoanReceiptPaymentPlanList.GridControl.RefreshDataSource();

            if (entity.LoanReceiptPaymentPlanList.Where(o => o.ACLoanReceiptPaymentPlanOpeningBalance < 0).Count() > 0)
                MessageBox.Show(LoanReceiptLocalizedResources.ValidateLoanReceiptPaymentForMonthMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ChangeACLoanReceiptPaymentPlansByRootPayment(decimal oldRootPayment, decimal valueRootPayment, int index)
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
            if (entity.LoanReceiptPaymentPlanList != null && entity.LoanReceiptPaymentPlanList.Count > 0)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                //int index = entity.LoanReceiptPaymentPlanList.CurrentIndex;
                ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = entity.LoanReceiptPaymentPlanList[index];
                //Kiểm tra giá trị nhập lớn hơn
                //Số liệu mới dòng cuối
                if (index == (entity.LoanReceiptPaymentPlanList.Count() - 1))
                {
                    decimal nextRootPayment = mainObject.ACLoanReceiptAmount - entity.LoanReceiptPaymentPlanList.Sum(x => x.ACLoanReceiptPaymentPlanRootPayment) - (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment == 0 ? 0 : -objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment);
                    decimal value = entity.LoanReceiptPaymentPlanList.Sum(x => x.ACLoanReceiptPaymentPlanRootPayment) - entity.LoanReceiptPaymentPlanList[entity.LoanReceiptPaymentPlanList.Count - 1].ACLoanReceiptPaymentPlanRootPayment + nextRootPayment;
                    if (mainObject.ACLoanReceiptAmount < value)
                    {
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment = oldRootPayment;
                        dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment);
                        entity.LoanReceiptPaymentPlanList.GridControl.RefreshDataSource();
                        MessageBox.Show("Tổng tiền ở gốc vốn không được lớn hơn số tiền nhận nợ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance < valueRootPayment)
                {
                    MessageBox.Show("Tổng tiền ở gốc vốn không được lớn hơn số tiền nhận nợ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = index; i <= entity.LoanReceiptPaymentPlanList.Count() - 1; i++)
                {
                    objLoanReceiptPaymentPlansInfo = entity.LoanReceiptPaymentPlanList[i];

                    objLoanReceiptPaymentPlansInfo = UpdateValueLoanReceiptPaymentPlanByIndex(objLoanReceiptPaymentPlansInfo, i, mainObject, entity.LoanReceiptPaymentPlanList, false);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanActualRootPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanOpeningBalance", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanBeginDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanEndDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentDay", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment);
                }
                entity.LoanReceiptPaymentPlanList.GridControl.RefreshDataSource();
            }
        }

        public void ChangeACLoanReceiptPaymentPlanEndDate(int index)
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
            if (entity.LoanReceiptPaymentPlanList != null && entity.LoanReceiptPaymentPlanList.Count > 0)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = null;
                for (int i = index; i <= entity.LoanReceiptPaymentPlanList.Count() - 1; i++)
                {
                    objLoanReceiptPaymentPlansInfo = entity.LoanReceiptPaymentPlanList[i];

                    objLoanReceiptPaymentPlansInfo = UpdateValueLoanReceiptPaymentPlanByIndex(objLoanReceiptPaymentPlansInfo, i, mainObject, entity.LoanReceiptPaymentPlanList, false);
                    if (i != index)
                    {
                        if (i == 0)
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = mainObject.ACLoanReceiptDate;
                        }
                        else
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = entity.LoanReceiptPaymentPlanList[i - 1].ACLoanReceiptPaymentPlanEndDate.AddDays(1);
                        }
                        //Ngày hết hạn
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate.AddDays(-1).AddMonths(1);
                    }
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanActualRootPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanRootPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanOpeningBalance", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanBeginDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanEndDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanDate", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentDay", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay);
                    dbUtil.SetPropertyValue(entity.LoanReceiptPaymentPlanList, "ACLoanReceiptPaymentPlanProfitsPayment", objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment);
                }
                entity.LoanReceiptPaymentPlanList.GridControl.RefreshDataSource();
            }
        }

        public void InvalidatePaymentForMonth(string profitMethod)
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            if (string.IsNullOrEmpty(profitMethod))
                profitMethod = objLoanReceiptsInfo.ACLoanReceiptProfitMethod;
            ACLoanReceiptPaymentForMonthTexboxControl.Properties.ReadOnly = profitMethod != LoanReceiptProfitMethod.FixedNeedles.ToString();
        }

        public void UpdatePlant()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            BOSList<ACLoanReceiptPaymentPlansInfo> PaymentPlanList = entity.LoanReceiptPaymentPlanList;
            for (int i = 0; i < objLoanReceiptsInfo.ACLoanReceiptLimit; i++)
            {
                ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = PaymentPlanList[i];
                switch ((LoanReceiptProfitMethod)Enum.Parse(typeof(LoanReceiptProfitMethod), objLoanReceiptsInfo.ACLoanReceiptProfitMethod))
                {
                    case LoanReceiptProfitMethod.OriginalDebt:
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate;
                        if (i > 0)
                        {
                            objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = PaymentPlanList[i - 1].ACLoanReceiptPaymentPlanDate.AddDays(1);
                        }
                        break;

                    case LoanReceiptProfitMethod.OutstandingDebt:
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanDate;
                        if (i > 0) objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate = PaymentPlanList[i - 1].ACLoanReceiptPaymentPlanDate.AddDays(1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay = Convert.ToDecimal((objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanEndDate - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanBeginDate).Days + 1);
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount
                                                                                            - (entity.LoanReceiptPaymentPlanList.Take(i).Sum(o => o.ACLoanReceiptPaymentPlanRootPayment));
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanOpeningBalance
                                                                                                * objLoanReceiptsInfo.ACLoanReceiptInterestRate / 100
                                                                                                * objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentDay / 360;
                        objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment + objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment;
                        break;

                    case LoanReceiptProfitMethod.FixedNeedles:
                        break;
                }
            }
            entity.LoanReceiptPaymentPlanList.GridControl.RefreshDataSource();
        }

        public void SetNumberFormat()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
            if (mainObject.FK_GECurrencyID != null && mainObject.FK_GECurrencyID != GECurrencyID.VND)
            {
                foreach (ACLoanReceiptPaymentPlansInfo item in entity.LoanReceiptPaymentPlanList)
                {
                    item.ACLoanReceiptPaymentPlanProfitsPayment = Math.Round(item.ACLoanReceiptPaymentPlanProfitsPayment, 2, MidpointRounding.AwayFromZero);
                }

            }
            entity.LoanReceiptPaymentPlanList.GridControl.RefreshDataSource();
        }

        public void InvalidateNumberFormat()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            (entity.LoanReceiptPaymentPlanList.GridControl as LoanReceiptPaymentPlansGridControl).FormatNumbering();
        }

        public void ShowDocuments()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ActionEdit();
            }
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
            ACLoanReceiptItemsInfo objLoanReceiptItemsInfo;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentList = objDocumentsController.GetDocumentsForLoanReceipt(BOSApp.CurrentCompanyInfo.FK_BRBranchID, mainObject.FK_ACLoanReceiptTypeID);
            documentList = documentList.Where(o => o.FK_GECurrencyID == mainObject.FK_GECurrencyID).ToList();
            guiFind<ACDocumentsInfo> guiFind = new guiFind<ACDocumentsInfo>(TableName.ACDocumentsTableName,
                                                                            documentList,
                                                                            this,
                                                                            true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<ACDocumentsInfo> documentsList = (List<ACDocumentsInfo>)guiFind.SelectedObjects;
                if (guiFind.SelectedObjects.Count > 0)
                {
                    foreach (ACDocumentsInfo objDocumentInfo in documentsList)
                    {
                        objLoanReceiptItemsInfo = new ACLoanReceiptItemsInfo();
                        objLoanReceiptItemsInfo.FK_BRBranchID = mainObject.FK_BRBranchID;
                        objLoanReceiptItemsInfo.FK_ACLoanReceiptID = mainObject.ACLoanReceiptID;
                        objLoanReceiptItemsInfo.ACLoanReceiptItemDocumentNo = objDocumentInfo.ACDocumentNo;
                        objLoanReceiptItemsInfo.FK_GECurrencyID = objDocumentInfo.FK_GECurrencyID;
                        objLoanReceiptItemsInfo.ACLoanReceiptItemTotalAmount = objDocumentInfo.ACDocumentTotalAmount;
                        objLoanReceiptItemsInfo.ACLoanReceiptItemComment = objDocumentInfo.ACDocumentDesc;
                        objLoanReceiptItemsInfo.ACLoanReceiptItemDocumentDate = objDocumentInfo.ACDocumentDate;
                        BOSApp.RoundByCurrency(objLoanReceiptItemsInfo, "ACLoanReceiptItemTotalAmount", objDocumentInfo.FK_GECurrencyID);
                        entity.LoanReceiptItemList.Add(objLoanReceiptItemsInfo);
                    }
                    mainObject.FK_PMProjectID = documentsList[0].FK_PMProjectID;
                }
                entity.LoanReceiptItemList.GridControl.RefreshDataSource();
                UpdateTotalCost();

            }
            else
                ActionCancel();
        }

        public void DeleteItemFromLoanReceiptInterestRateChangesList()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            entity.LoanReceiptInterestRateChangesList.RemoveSelectedRowObjectFromList();
            UpdateTotalCost();
        }

        protected void UpdatePaymentPlanByInterestRateChanges()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)entity.MainObject;
            entity.LoanReceiptPaymentPlanList.EndCurrentEdit();
            entity.LoanReceiptInterestRateChangesList.EndCurrentEdit();
            List<ACLoanReceiptInterestRateChangesInfo> listInterestRateChanges = entity.LoanReceiptInterestRateChangesList.OrderBy(p => p.ACLoanReceiptInterestRateChangeStartPeriodChange).ToList();

            for (int i = 0; i < listInterestRateChanges.Count; i++)
            {
                entity.LoanReceiptPaymentPlanList.ForEach(p =>
                {
                    try
                    {
                        if (Convert.ToInt32(p.ACLoanReceiptPaymentPlanPeriod) >= listInterestRateChanges[i].ACLoanReceiptInterestRateChangeStartPeriodChange)
                        {
                            switch ((LoanReceiptProfitMethod)Enum.Parse(typeof(LoanReceiptProfitMethod), objLoanReceiptsInfo.ACLoanReceiptProfitMethod))
                            {
                                case LoanReceiptProfitMethod.OriginalDebt:
                                    p.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptsInfo.ACLoanReceiptAmount * listInterestRateChanges[i].ACLoanReceiptInterestRateChangeValue / 100 / 12;
                                    p.ACLoanReceiptPaymentPlanPayment = p.ACLoanReceiptPaymentPlanRootPayment + p.ACLoanReceiptPaymentPlanProfitsPayment;
                                    break;
                                case LoanReceiptProfitMethod.OutstandingDebt:
                                    p.ACLoanReceiptPaymentPlanProfitsPayment = p.ACLoanReceiptPaymentPlanOpeningBalance
                                                                                                * listInterestRateChanges[i].ACLoanReceiptInterestRateChangeValue / 100
                                                                                                * p.ACLoanReceiptPaymentDay / 360;
                                    p.ACLoanReceiptPaymentPlanPayment = p.ACLoanReceiptPaymentPlanRootPayment + p.ACLoanReceiptPaymentPlanProfitsPayment;
                                    break;
                                case LoanReceiptProfitMethod.FixedNeedles:
                                    p.ACLoanReceiptPaymentPlanProfitsPayment = p.ACLoanReceiptPaymentPlanOpeningBalance
                                                                                            * (listInterestRateChanges[i].ACLoanReceiptInterestRateChangeValue / 100 / 12);
                                    p.ACLoanReceiptPaymentPlanRootPayment = p.ACLoanReceiptPaymentPlanPayment - p.ACLoanReceiptPaymentPlanProfitsPayment;
                                    break;
                                case LoanReceiptProfitMethod.OriginalPaypal:
                                    p.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptsInfo.ACLoanReceiptAmount * (listInterestRateChanges[i].ACLoanReceiptInterestRateChangeValue / 100 / 12);
                                    p.ACLoanReceiptPaymentPlanPayment = p.ACLoanReceiptPaymentPlanProfitsPayment + p.ACLoanReceiptPaymentPlanRootPayment;
                                    break;
                                case LoanReceiptProfitMethod.OutstandingDebtIncreasing:
                                    p.ACLoanReceiptPaymentPlanProfitsPayment = objLoanReceiptsInfo.ACLoanReceiptAmount * (listInterestRateChanges[i].ACLoanReceiptInterestRateChangeValue / 100 / 12);
                                    p.ACLoanReceiptPaymentPlanPayment = p.ACLoanReceiptPaymentPlanProfitsPayment + p.ACLoanReceiptPaymentPlanRootPayment;
                                    break;
                            }
                        }
                    }
                    catch (Exception e)
                    {

                    }
                });
            }
            entity.LoanReceiptPaymentPlanList.GridControl.RefreshDataSource();
        }

        public void UpdateLoanReceiptDeadline()
        {
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)CurrentModuleEntity.MainObject;
            if(mainObject.ACLoanReceiptLimit <= 0 && mainObject.ACLoanReceiptDate.Year < 9000)
            {
                mainObject.ACLoanReceiptDeadline = mainObject.ACLoanReceiptDate.AddMonths(1);
            }
            else
            {
                mainObject.ACLoanReceiptDeadline = mainObject.ACLoanReceiptDate.AddMonths(mainObject.ACLoanReceiptLimit);
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public bool ChangeLoanReceiptExchangeAmount()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return true;
            }

            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)CurrentModuleEntity.MainObject;
            decimal chenhlech = Math.Abs(mainObject.ACLoanReceiptExchangeRate * mainObject.ACLoanReceiptAmount - mainObject.ACLoanReceiptExchangeAmount);
            if(chenhlech > 0 && mainObject.ACLoanReceiptExchangeRate * mainObject.ACLoanReceiptAmount > 0)
            {
                decimal phantram = chenhlech / (mainObject.ACLoanReceiptExchangeRate * mainObject.ACLoanReceiptAmount) * 100;
                if(phantram > 5)
                {
                    return false;
                }    
            }
            return true;
        }

        #region Đính Kèm File
        public void SaveDocumentFile()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;
            List<ACFileAttachmentsInfo> documentTemplateList = entity.LoanReceiptTemplateList.ToList();

            ACFileAttachmentsController objFileAttachmentsController = new ACFileAttachmentsController();
            ACFileAttachmentsInfo objFileAttachmentsInfo = new ACFileAttachmentsInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            documentTemplateList.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.ACFileAttachmentFileGUID))
                    return;

                entity.LoanReceiptTemplateURLDic.TryGetValue(o.ACFileAttachmentID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.ACFileAttachmentFileGUID = ApiClientHelper.UpdateFile(value);
                o.ACFileAttachmentObjectID = mainObject.ACLoanReceiptID;
                objFileAttachmentsController.UpdateObject(o);
            });
            entity.LoanReceiptTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.LoanReceiptTemplateList.GridControl.RefreshDataSource();
        }

        public void BrowseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
            //dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[LoanReceiptModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddLoanReceiptTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[LoanReceiptModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)entity.MainObject;

            if (entity.LoanReceiptTemplateList.Exists(o => o.ACFileAttachmentName.Equals(DocumentFileName)))
            {
                MessageBox.Show(SaleOrderLocalizedResources.DuplicateFileName,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            ACFileAttachmentsInfo objFileAttachmentsInfo = new ACFileAttachmentsInfo();
            objFileAttachmentsInfo.ACFileAttachmentName = DocumentFileName;
            objFileAttachmentsInfo.ACFileAttachmentTableName = BOSUtil.GetTableNameFromBusinessObject(mainObject);
            objFileAttachmentsInfo.ACFileAttachmentObjectID = mainObject.ACLoanReceiptID;
            objFileAttachmentsInfo.ACFileAttachmentObjectItemID = 0;
            objFileAttachmentsInfo.ACFileAttachmentModuleName = this.Name;
            objFileAttachmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objFileAttachmentsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objFileAttachmentsInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objFileAttachmentsInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.LoanReceiptTemplateList.Add(objFileAttachmentsInfo);
            entity.LoanReceiptTemplateList.GridControl.RefreshDataSource();
        }

        public void RemoveLoanReceiptTemplateList()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            entity.LoanReceiptTemplateList.RemoveSelectedRowObjectFromList();
            entity.LoanReceiptTemplateList.GridControl.RefreshDataSource();
        }

        public void DownloadDocument()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACFileAttachmentsInfo objFileAttachmentsInfo = entity.LoanReceiptTemplateList[entity.LoanReceiptTemplateList.CurrentIndex];
            if (objFileAttachmentsInfo == null)
                return;

            if (string.IsNullOrEmpty(objFileAttachmentsInfo.ACFileAttachmentFileGUID))
            {
                MessageBox.Show(SaleOrderLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objFileAttachmentsInfo.ACFileAttachmentFileGUID, objFileAttachmentsInfo.ACFileAttachmentName);
        }

        internal void ViewFile()
        {
            throw new NotImplementedException();
        }

        internal void DeleteFile()
        {
            throw new NotImplementedException();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            ACLoanReceiptsInfo searchObject = (ACLoanReceiptsInfo)CurrentModuleEntity.SearchObject;
            ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
            DataSet ds;
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objLoanReceiptsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objLoanReceiptsController.GetDataSetLoanReceiptListByListBranch(
                                                                            searchObject.ACLoanAgreementNo,
                                                                            searchObject.FK_ACLoanAgreementID,
                                                                            searchObject.FK_GECurrencyID,
                                                                            searchObject.LoanReceiptFromDate,
                                                                            searchObject.LoanReceiptToDate,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objLoanReceiptsController.GetDataSetLoanReceiptListByBranchID(
                                                                        searchObject.ACLoanAgreementNo,
                                                                        searchObject.FK_ACLoanAgreementID,
                                                                        searchObject.FK_GECurrencyID,
                                                                        searchObject.LoanReceiptFromDate,
                                                                        searchObject.LoanReceiptToDate,
                                                                        searchObject.FK_BRBranchID);
            }
            return ds;
        }

        #region Show Ref Document
        public void ShowLoanReceiptItemReffModule()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            if (entity.LoanReceiptItemList.CurrentIndex < 0)
                return;
            ACLoanReceiptItemsInfo objLoanReceiptItemsInfo = entity.LoanReceiptItemList[entity.LoanReceiptItemList.CurrentIndex];
            if (objLoanReceiptItemsInfo == null)
                return;

            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo refDocument = objDocumentsController.GetDocumentsInfoFromTransactionByDocumentNo(objLoanReceiptItemsInfo.ACLoanReceiptItemDocumentNo);
            if (refDocument == null)
                return;

            BaseModuleERP currModule = BOSApp.IsOpenedModule(refDocument.APClearInvoiceInDocumentReferenceModuleName)
                                       ? ((BaseModuleERP)BOSApp.OpenModules[refDocument.APClearInvoiceInDocumentReferenceModuleName])
                                       : (BaseModuleERP)BOSApp.ShowModule(refDocument.APClearInvoiceInDocumentReferenceModuleName);
            if (currModule == null)
                return;
            currModule.ActionInvalidate(refDocument.APClearInvoiceInDocumentReferenceID);
            currModule.Invalidate(refDocument.APClearInvoiceInDocumentReferenceID);
            currModule.ParentScreen.Activate();
        }

        public void ShowLoanReceiptPayDocReffModule()
        {
            LoanReceiptEntities entity = (LoanReceiptEntities)CurrentModuleEntity;
            if (entity.LoanReceiptPayDocList.CurrentIndex < 0)
                return;
            ACLoanReceiptPayDocsInfo objLoanReceiptPayDocsInfo = entity.LoanReceiptPayDocList[entity.LoanReceiptPayDocList.CurrentIndex];
            if (objLoanReceiptPayDocsInfo == null)
                return;

            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo refDocument = objDocumentsController.GetDocumentsInfoFromTransactionByDocumentNo(objLoanReceiptPayDocsInfo.ACLoanReceiptPayDocNo);
            if (refDocument == null)
                return;

            BaseModuleERP currModule = BOSApp.IsOpenedModule(refDocument.APClearInvoiceInDocumentReferenceModuleName)
                                       ? ((BaseModuleERP)BOSApp.OpenModules[refDocument.APClearInvoiceInDocumentReferenceModuleName])
                                       : (BaseModuleERP)BOSApp.ShowModule(refDocument.APClearInvoiceInDocumentReferenceModuleName);
            if (currModule == null)
                return;
            currModule.ActionInvalidate(refDocument.APClearInvoiceInDocumentReferenceID);
            currModule.Invalidate(refDocument.APClearInvoiceInDocumentReferenceID);
            currModule.ParentScreen.Activate();
        }
        #endregion

        #endregion
    }
}

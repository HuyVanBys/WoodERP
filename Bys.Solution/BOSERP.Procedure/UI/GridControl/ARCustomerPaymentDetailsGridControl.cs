using BOSCommon;
using BOSCommon.Constants;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class ARCustomerPaymentDetailsGridControl : BOSComponent.BOSGridControl
    {
        /// <summary>
        /// Gets or sets the payment details binding to the grid control
        /// </summary>
        public List<ARCustomerPaymentDetailsInfo> CustomerPaymentDetailList { get; set; }

        /// <summary>
        /// Gets or sets the payment amount
        /// </summary>
        public decimal PaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the grid allows multiple-payment
        /// </summary>
        public bool AllowMultiplePayment { get; set; }

        /// <summary>
        /// Gets or sets the required method in case the grid do not allow multiple-payment
        /// </summary>
        public string RequiredMethod { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the gird allows take payment by currencies
        /// </summary>
        public bool AllowPaymentByCurrency { get; set; }


        public override void InitializeControl()
        {
            base.InitializeControl();
            this.Enter += new EventHandler(GridControl_Enter);
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_CSCompanyBankID")
            {
                if (e.Value != null)
                {
                    int companyBankID = int.Parse(e.Value.ToString());
                    CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                    CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(companyBankID);
                    if (objCompanyBanksInfo != null)
                        e.DisplayText = objCompanyBanksInfo.CSCompanyBankCode;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_CSCashFundID")
            {
                if (e.Value != null)
                {
                    int cashFundID = int.Parse(e.Value.ToString());
                    CSCashFundsController objCashFundController = new CSCashFundsController();
                    CSCashFundsInfo objCashFundsInfo = (CSCashFundsInfo)objCashFundController.GetObjectByID(cashFundID);
                    if (objCashFundsInfo != null)
                        e.DisplayText = objCashFundsInfo.CSCashFundName;
                    else
                        e.DisplayText = string.Empty;
                }
                else
                    e.DisplayText = string.Empty;
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ARPaymentMethodCombo"];
            if (column != null)
            {
                column.AppearanceCell.BackColor = Color.WhiteSmoke;
            }

            column = gridView.Columns["ARCustomerPaymentDetailAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

                if (AllowPaymentByCurrency)
                {
                    RepositoryItemButtonEdit rep = new RepositoryItemButtonEdit();
                    rep.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(RepositoryItemButtonEditAmount_ButtonClick);
                    column.ColumnEdit = rep;
                    InitColumnRepositoryFormat(column, TableName.ARCustomerPaymentDetailsTableName, "ARCustomerPaymentDetailAmount");
                }
            }

            column = gridView.Columns["ARCustomerPaymentDetailInfo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_CSCompanyBankID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "CSCompanyBankCode";
                repositoryItemLookUpEdit.ValueMember = "CSCompanyBankID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("CSCompanyBankCode", 200, "Mã ngân hàng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("CSCompanyBankName", 400, "Tên ngân hàng"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditSaleCost_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_CSCashFundID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "CSCashFundName";
                repositoryItemLookUpEdit.ValueMember = "CSCashFundID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("CSCashFundNo", 200, "Mã quỹ tiền mặt"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("CSCashFundName", 400, "Tên quỹ tiền mặt"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditCashFund_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            return gridView;
        }

        public void repositoryItemLookUpEditSaleCost_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARCustomerPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objCustomerPaymentDetailsInfo != null)
                    if (objCustomerPaymentDetailsInfo.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()
                        || objCustomerPaymentDetailsInfo.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString())
                    {
                        LookUpEdit lookUpEdit = (LookUpEdit)sender;
                        CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                        List<CSCompanyBanksInfo> companyBankList = objCompanyBanksController.GetAllBanks();
                        if (companyBankList != null && companyBankList.Count > 0)
                        {
                            lookUpEdit.Properties.DataSource = companyBankList;
                        }
                        lookUpEdit.Properties.DisplayMember = "CSCompanyBankCode";
                        lookUpEdit.Properties.ValueMember = "CSCompanyBankID";
                    }
            }
        }

        public void repositoryItemLookUpEditCashFund_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARCustomerPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objCustomerPaymentDetailsInfo != null)
                    if (objCustomerPaymentDetailsInfo.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
                    {
                        LookUpEdit lookUpEdit = (LookUpEdit)sender;
                        CSCashFundsController objCashFundsController = new CSCashFundsController();
                        List<CSCashFundsInfo> cashFundList = objCashFundsController.GetAllCashFunds();
                        if (cashFundList != null && cashFundList.Count > 0)
                        {
                            lookUpEdit.Properties.DataSource = cashFundList;
                        }
                        lookUpEdit.Properties.DisplayMember = "CSCashFundName";
                        lookUpEdit.Properties.ValueMember = "CSCashFundID";
                    }
            }
        }

        private void RepositoryItemButtonEditAmount_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ((Screen.Module as BaseModuleERP).IsEditable())
            {
                (Screen.Module as BaseModuleERP).ActionEdit();
            }

            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARCustomerPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                guiPaymentCurrency guiPaymentCurrency = new guiPaymentCurrency(objCustomerPaymentDetailsInfo);
                guiPaymentCurrency.Module = Screen.Module;
                guiPaymentCurrency.ShowDialog();
            }
        }

        public override void InitGridControlDataSource()
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = CustomerPaymentDetailList;
            DataSource = bds;
            RefreshDataSource();
        }

        #region GridControl Event Handlers
        private void GridControl_Enter(object sender, EventArgs e)
        {
            ProposeRemainingAmount();
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            ProposeRemainingAmount();
        }
        #endregion

        public void ProposeRemainingAmount()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARCustomerPaymentDetailsInfo currentPayment = null;
                if (!AllowMultiplePayment && !string.IsNullOrEmpty(RequiredMethod))
                {
                    currentPayment = CustomerPaymentDetailList.Where(cpd => cpd.ARPaymentMethodCombo == RequiredMethod).FirstOrDefault();
                }
                else
                {
                    currentPayment = (ARCustomerPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                }

                if (AllowMultiplePayment)
                {
                    decimal amount = 0;
                    foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in CustomerPaymentDetailList)
                        if (objCustomerPaymentDetailsInfo.ARPaymentMethodCombo != currentPayment.ARPaymentMethodCombo)
                            amount += objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailAmount;

                    if (PaymentAmount >= amount)
                        currentPayment.ARCustomerPaymentDetailAmount = PaymentAmount - amount;
                }
                else
                {
                    ARCustomerPaymentDetailsInfo previousPayment = CustomerPaymentDetailList.Where(cpd => cpd.ARCustomerPaymentDetailID > 0 &&
                                                                                                   cpd.ARCustomerPaymentDetailAmount > 0).FirstOrDefault();
                    if (previousPayment != null)
                    {
                        currentPayment = previousPayment;
                    }
                    CustomerPaymentDetailList.ForEach(cpd => cpd.ARCustomerPaymentDetailAmount = 0);
                    currentPayment.ARCustomerPaymentDetailAmount = PaymentAmount;
                }
                this.RefreshDataSource();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ARCustomerPaymentDetailAmount")
            {
                if (e.Value != null)
                {
                    ARCustomerPaymentDetailsInfo currentPayment = (ARCustomerPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (!AllowMultiplePayment)
                    {
                        if (CustomerPaymentDetailList.Exists(cpd => cpd.ARCustomerPaymentDetailAmount > 0 && cpd.ARPaymentMethodCombo != currentPayment.ARPaymentMethodCombo))
                        {
                            e.ErrorText = CommonLocalizedResources.CannotTakeMultiplePayment;
                            e.Valid = false;
                            return;
                        }
                    }
                    decimal amount = 0;
                    foreach (ARCustomerPaymentDetailsInfo objDocumentPaymentDetaisInfo in CustomerPaymentDetailList)
                    {
                        if (objDocumentPaymentDetaisInfo.ARPaymentMethodCombo != currentPayment.ARPaymentMethodCombo)
                        {
                            amount += objDocumentPaymentDetaisInfo.ARCustomerPaymentDetailAmount;
                        }
                    }
                    amount += Convert.ToDecimal(e.Value);
                    if (amount > PaymentAmount)
                    {
                        e.ErrorText = CommonLocalizedResources.TotalAmountCannotBeGreaterThanPaymentAmountMessage;
                        e.Valid = false;
                    }
                }
            }
        }
    }
}

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

namespace BOSERP.Modules.POS
{
    public partial class ARPOSPaymentDetailsGridControl : BOSComponent.BOSGridControl
    {
        /// <summary>
        /// Gets or sets the payment details binding to the grid control
        /// </summary>
        public List<ARPOSPaymentDetailsInfo> POSPaymentDetailList { get; set; }

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
                        e.DisplayText = objCompanyBanksInfo.CSCompanyBankName;
                    else
                        e.DisplayText = string.Empty;
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

            GridColumn column = gridView.Columns["ARPOSPaymentMethodCombo"];
            if (column != null)
            {
                column.AppearanceCell.BackColor = Color.WhiteSmoke;
                column.FieldName = "ARPaymentMethodDisplayText";
                column.VisibleIndex = 0;
                column.Width = 150;
            }

            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARPOSPaymentDetailAmount"];
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

            column = gridView.Columns["ARPOSPaymentDetailInfo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_CSCompanyBankID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "CSCompanyBankName";
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
            column = gridView.Columns["ARPOSPaymentDetailDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            return gridView;
        }

        public void repositoryItemLookUpEditSaleCost_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARPOSPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARPOSPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objCustomerPaymentDetailsInfo != null)
                    if (objCustomerPaymentDetailsInfo.ARPOSPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()
                        || objCustomerPaymentDetailsInfo.ARPOSPaymentMethodCombo == PaymentMethod.CreditCard.ToString()
                        || objCustomerPaymentDetailsInfo.ARPOSPaymentMethodCombo == PaymentMethod.CreditNote.ToString())
                    {
                        LookUpEdit lookUpEdit = (LookUpEdit)sender;
                        CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                        List<CSCompanyBanksInfo> companyBankList = objCompanyBanksController.GetAllBanks();
                        if (companyBankList != null && companyBankList.Count > 0)
                        {
                            lookUpEdit.Properties.DataSource = companyBankList;
                        }
                        lookUpEdit.Properties.DisplayMember = "CSCompanyBankName";
                        lookUpEdit.Properties.ValueMember = "CSCompanyBankID";
                    }
            }
        }

        public void repositoryItemLookUpEditCashFund_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARPOSPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARPOSPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objCustomerPaymentDetailsInfo != null)
                    if (objCustomerPaymentDetailsInfo.ARPOSPaymentMethodCombo == PaymentMethod.Cash.ToString())
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
                ARPOSPaymentDetailsInfo objCustomerPaymentDetailsInfo = (ARPOSPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            }
        }

        public override void InitGridControlDataSource()
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = POSPaymentDetailList;
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
                ARPOSPaymentDetailsInfo currentPayment = null;
                if (!AllowMultiplePayment && !string.IsNullOrEmpty(RequiredMethod))
                {
                    currentPayment = POSPaymentDetailList.Where(cpd => cpd.ARPOSPaymentMethodCombo == RequiredMethod).FirstOrDefault();
                }
                else
                {
                    currentPayment = (ARPOSPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                }

                if (AllowMultiplePayment)
                {
                    decimal amount = 0;
                    foreach (ARPOSPaymentDetailsInfo objCustomerPaymentDetailsInfo in POSPaymentDetailList)
                        if (objCustomerPaymentDetailsInfo.ARPOSPaymentMethodCombo != currentPayment.ARPOSPaymentMethodCombo)
                            amount += objCustomerPaymentDetailsInfo.ARPOSPaymentDetailAmount;

                    if (PaymentAmount >= amount)
                        currentPayment.ARPOSPaymentDetailAmount = PaymentAmount - amount;
                }
                else
                {
                    ARPOSPaymentDetailsInfo previousPayment = POSPaymentDetailList.Where(cpd => cpd.ARPOSPaymentDetailID > 0 &&
                                                                                                   cpd.ARPOSPaymentDetailAmount > 0).FirstOrDefault();
                    if (previousPayment != null)
                    {
                        currentPayment = previousPayment;
                    }
                    POSPaymentDetailList.ForEach(cpd => cpd.ARPOSPaymentDetailAmount = 0);
                    currentPayment.ARPOSPaymentDetailAmount = PaymentAmount;
                }
                this.RefreshDataSource();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ARPOSPaymentDetailAmount")
            {
                if (e.Value != null)
                {
                    ARPOSPaymentDetailsInfo currentPayment = (ARPOSPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (!AllowMultiplePayment)
                    {
                        if (POSPaymentDetailList.Exists(cpd => cpd.ARPOSPaymentDetailAmount > 0 && cpd.ARPOSPaymentMethodCombo != currentPayment.ARPOSPaymentMethodCombo))
                        {
                            e.ErrorText = CommonLocalizedResources.CannotTakeMultiplePayment;
                            e.Valid = false;
                            return;
                        }
                    }
                    decimal amount = 0;
                    foreach (ARPOSPaymentDetailsInfo objPOSPaymentDetaisInfo in POSPaymentDetailList)
                    {
                        if (objPOSPaymentDetaisInfo.ARPOSPaymentMethodCombo != currentPayment.ARPOSPaymentMethodCombo)
                        {
                            amount += objPOSPaymentDetaisInfo.ARPOSPaymentDetailAmount;
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

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (e.Value != null)
            {
                ARPOSPaymentDetailsInfo currentPayment = (ARPOSPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "FK_CSCashFundID")
                {
                    CSCashFundsController objCashFundsController = new CSCashFundsController();
                    CSCashFundsInfo objCashFundsInfo = (CSCashFundsInfo)objCashFundsController.GetObjectByID(currentPayment.FK_CSCashFundID);
                    if (objCashFundsInfo != null)
                        currentPayment.FK_ACAccountID = objCashFundsInfo.FK_ACAcountID;
                }
                if (e.Column.FieldName == "FK_CSCompanyBankID")
                {
                    CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                    CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(currentPayment.FK_CSCompanyBankID);
                    if (objCompanyBanksInfo != null)
                        currentPayment.FK_ACAccountID = objCompanyBanksInfo.FK_ACAcountID;
                }
            }
        }
    }
}

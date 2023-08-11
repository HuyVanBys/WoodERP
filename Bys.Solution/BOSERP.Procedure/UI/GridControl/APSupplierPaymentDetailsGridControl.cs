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
    public partial class APSupplierPaymentDetailsGridControl : BOSComponent.BOSGridControl
    {
        /// <summary>
        /// Gets or sets the payment details binding to the grid control
        /// </summary>
        public List<APSupplierPaymentDetailsInfo> SupplierPaymentDetailList { get; set; }

        /// <summary>
        /// Gets or sets the payment amount that needs to be paid
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

        public override void InitializeControl()
        {
            base.InitializeControl();
            this.Enter += new EventHandler(GridControl_Enter);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["APPaymentMethodCombo"] != null)
                gridView.Columns["APPaymentMethodCombo"].AppearanceCell.BackColor = Color.WhiteSmoke;
            if (gridView.Columns["APSupplierPaymentDetailAmount"] != null)
                gridView.Columns["APSupplierPaymentDetailAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APSupplierPaymentDetailInfo"] != null)
                gridView.Columns["APSupplierPaymentDetailInfo"].OptionsColumn.AllowEdit = true;
            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            return gridView;
        }

        public override void InitGridControlDataSource()
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = SupplierPaymentDetailList;
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
                APSupplierPaymentDetailsInfo currentPayment = null;
                if (!AllowMultiplePayment && !string.IsNullOrEmpty(RequiredMethod))
                {
                    currentPayment = SupplierPaymentDetailList.Where(cpd => cpd.APPaymentMethodCombo == RequiredMethod).FirstOrDefault();
                }
                else
                {
                    currentPayment = (APSupplierPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                }

                if (AllowMultiplePayment)
                {
                    decimal amount = 0;
                    foreach (APSupplierPaymentDetailsInfo objSupplierPaymentDetailsInfo in SupplierPaymentDetailList)
                        if (objSupplierPaymentDetailsInfo.APPaymentMethodCombo != currentPayment.APPaymentMethodCombo)
                            amount += objSupplierPaymentDetailsInfo.APSupplierPaymentDetailAmount;

                    if (PaymentAmount >= amount)
                        currentPayment.APSupplierPaymentDetailAmount = PaymentAmount - amount;
                }
                else
                {
                    APSupplierPaymentDetailsInfo previousPayment = SupplierPaymentDetailList.Where(spd => spd.APSupplierPaymentDetailID > 0 &&
                                                                                                spd.APSupplierPaymentDetailAmount > 0).FirstOrDefault();
                    if (previousPayment != null)
                    {
                        currentPayment = previousPayment;
                    }
                    SupplierPaymentDetailList.ForEach(spd => spd.APSupplierPaymentDetailAmount = 0);
                    if (currentPayment != null)
                        currentPayment.APSupplierPaymentDetailAmount = PaymentAmount;
                }
                this.RefreshDataSource();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "APSupplierPaymentDetailAmount")
            {
                if (e.Value != null)
                {
                    APSupplierPaymentDetailsInfo currentPayment = (APSupplierPaymentDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (!AllowMultiplePayment)
                    {
                        if (SupplierPaymentDetailList.Exists(spd => spd.APSupplierPaymentDetailAmount > 0 && spd.APPaymentMethodCombo != currentPayment.APPaymentMethodCombo))
                        {
                            e.ErrorText = CommonLocalizedResources.CannotTakeMultiplePayment;
                            e.Valid = false;
                            return;
                        }
                    }
                    decimal amount = 0;
                    foreach (APSupplierPaymentDetailsInfo objDocumentPaymentDetaisInfo in SupplierPaymentDetailList)
                    {
                        if (objDocumentPaymentDetaisInfo.APPaymentMethodCombo != currentPayment.APPaymentMethodCombo)
                        {
                            amount += objDocumentPaymentDetaisInfo.APSupplierPaymentDetailAmount;
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

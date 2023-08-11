using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.SupplierPayment
{
    public class APPaymentProposalPaymentsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaymentProposalList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            GridColumn column = gridView.Columns["APPaymentProposalPaymentPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPaymentProposalPaymentAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPaymentProposalPaymentFee"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPaymentProposalPaymentDiscountFix"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACCostObjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPaymentProposalPaymentPaymentTimeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemTextEdit = new RepositoryItemLookUpEdit();
                //  repositoryItemTextEdit.EditValueChanged += new EventHandler(repositoryItemTextEdit2_EditValueChanged);
                // column.ColumnEdit.EditValueChanged += new EventHandler(repositoryItemTextEdit2_EditValueChanged);
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("PurchaseOrderPaymentTimeName");

                List<ADConfigValuesInfo> configValuesList = new List<ADConfigValuesInfo>();
                if (ds.Tables.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ADConfigValuesInfo configValuesInfo = new ADConfigValuesInfo();
                        configValuesInfo.ADConfigKeyValue = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        configValuesInfo.ADConfigText = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        configValuesList.Add(configValuesInfo);
                    }
                }
                repositoryItemTextEdit.DisplayMember = "ADConfigText";
                repositoryItemTextEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemTextEdit.DataSource = configValuesList;


                LookUpColumnInfoCollection coll = repositoryItemTextEdit.Columns;

                coll.Add(new LookUpColumnInfo("ADConfigText", 0, "Payment Time"));

                column.ColumnEdit = repositoryItemTextEdit;
            }

            column = gridView.Columns["FK_ARInvoiceID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemTextEdit = new RepositoryItemLookUpEdit();
                repositoryItemTextEdit.DisplayMember = "ARInvoiceNo";
                repositoryItemTextEdit.ValueMember = "ARInvoiceID";
                repositoryItemTextEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemTextEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemTextEdit.NullText = string.Empty;
                repositoryItemTextEdit.Columns.Add(new LookUpColumnInfo("ARInvoiceNo", "Mã phiếu giao"));
                repositoryItemTextEdit.QueryPopUp += new CancelEventHandler(repositoryItemTextEdit_QueryPopUp);
                gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
                column.ColumnEdit = repositoryItemTextEdit;
            }

            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo info = gridView.CalcHitInfo(ea.Location);
            if (gridView.FocusedRowHandle >= 0)
            {
                APPaymentProposalPaymentsInfo objPaymentProposalPaymentsInfo = (APPaymentProposalPaymentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objPaymentProposalPaymentsInfo != null && info.Column != null)
                {
                    if (info.Column.FieldName == "FK_APPaymentProposalID" && objPaymentProposalPaymentsInfo.FK_APPaymentProposalID > 0)
                        ((SupplierPaymentModule)Screen.Module).ShowPaymentProposalScreen(objPaymentProposalPaymentsInfo.FK_APPaymentProposalID);
                }
            }
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARInvoiceID")
            {
                if (e.Value != null)
                {
                    int invoiceID = int.Parse(e.Value.ToString());
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    ARInvoicesInfo objInvoicesInfo = new ARInvoicesInfo();
                    objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(invoiceID);
                    if (objInvoicesInfo != null)
                    {
                        e.DisplayText = objInvoicesInfo.ARInvoiceNo;
                    }
                }
            }
        }
        void repositoryItemTextEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            APSupplierPaymentsInfo mainObject = (APSupplierPaymentsInfo)entity.MainObject;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            if (mainObject != null)
            {
                List<ARInvoicesInfo> list = objInvoicesController.GetInvoiceByObjectID(mainObject.FK_ACObjectID);
                lookUpEdit.Properties.DataSource = list;
                //  lookUpEdit.Properties.DisplayMember = "ARInvoiceNo";
                // lookUpEdit.Properties.ValueMember = "ARInvoiceID";
            }
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((SupplierPaymentModule)Screen.Module).DeleteSelectedProposal();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.Caption = SupplierPaymentLocalizedResources.APDocumentPaymentAmountCaption;
            //column.FieldName = "APPaymentProposalPaymentAmount";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Add(column);
            GridColumn column = new GridColumn();
            column.Caption = "Số hóa đơn";
            column.FieldName = "APInvoiceInSupplierNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            SupplierPaymentEntities entity = (SupplierPaymentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (gridView.FocusedRowHandle >= 0)
            {

                APPaymentProposalPaymentsInfo objInvoiceInsInfo = (APPaymentProposalPaymentsInfo)gridView.GetRow(e.RowHandle);

                ARInvoicesController objInvoicesController = new ARInvoicesController();
                if (objInvoiceInsInfo != null)
                {
                    if (e.Column.FieldName == "FK_ARInvoiceID")
                    {
                        ARInvoicesInfo objIV = (ARInvoicesInfo)objInvoicesController.GetObjectByID(objInvoiceInsInfo.FK_ARInvoiceID);
                        if (objIV != null)
                        {
                            objInvoiceInsInfo.APPaymentProposalPaymentAmount = objIV.ARInvoiceTotalAmount;
                            objInvoiceInsInfo.APPaymentProposalPaymentRemainAmount = objInvoiceInsInfo.APPaymentProposalPaymentTotalAmount - objInvoiceInsInfo.APPaymentProposalPaymentAmount;
                        }
                        bool isValid = ((SupplierPaymentModule)Screen.Module).ChangeProposalPaymentAmount(objInvoiceInsInfo, false);
                        if (!isValid)
                        {
                            MessageBox.Show("Phiếu giao không hợp lệ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].FK_ARInvoiceID = int.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentRemainAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                    if (e.Column.FieldName == "APPaymentProposalPaymentAmount")
                    {
                        bool isValid = ((SupplierPaymentModule)Screen.Module).ChangeProposalPaymentAmount(objInvoiceInsInfo, false);
                        if (!isValid)
                        {
                            entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                    else if (e.Column.FieldName == "APPaymentProposalPaymentPercent")
                    {
                        bool isValid = ((SupplierPaymentModule)Screen.Module).ChangeProposalPaymentAmount(objInvoiceInsInfo, true);
                        if (!isValid)
                        {
                            entity.PaymentProposalList[entity.PaymentProposalList.CurrentIndex].APPaymentProposalPaymentPercent = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }

                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                APPaymentProposalPaymentsInfo item = (APPaymentProposalPaymentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (gridView.FocusedColumn.FieldName == "APPaymentProposalPaymentDiscountFix")
                {
                    decimal discountFix = Convert.ToDecimal(e.Value);
                    if (discountFix < 0)
                    {
                        e.Valid = false;
                        e.ErrorText = "Bạn không được chiết khấu số tiền âm";
                    }
                    else if (discountFix + item.APPaymentProposalPaymentAmount > item.APPaymentProposalPaymentRemainAmount)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số tiền Thanh toán + chiết khấu không được vượt quá số tiền còn lại";
                    }
                }
                else if (gridView.FocusedColumn.FieldName == "APPaymentProposalPaymentAmount")
                {
                    decimal paymentAmount = Convert.ToDecimal(e.Value);
                    if (paymentAmount < 0)
                    {
                        e.Valid = false;
                        e.ErrorText = "Bạn không được thanh toán số tiền âm";
                    }
                    else if (paymentAmount + item.APPaymentProposalPaymentDiscountFix > item.APPaymentProposalPaymentRemainAmount)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số tiền Thanh toán + chiết khấu không được vượt quá số tiền còn lại";
                    }
                }
            }
        }
    }
}
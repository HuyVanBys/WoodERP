using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.PaymentProposal
{
    public partial class PaymentProposalItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PaymentProposalEntities entity = (PaymentProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaymentProposalItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["APInvoiceInItemProductQty"] != null)
                gridView.Columns["APInvoiceInItemProductQty"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["APPaymentProposalInvoiceInDate"] != null)
                gridView.Columns["APPaymentProposalInvoiceInDate"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["FK_APPurchaseOrderID"] != null)
            {
                gridView.Columns["FK_APPurchaseOrderID"].OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "APPurchaseOrderNo";
                repositoryItemLookUpEdit.ValueMember = "APPurchaseOrderID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.APPurchaseOrdersTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.APPurchaseOrdersTableName);
                    BOSApp.LookupTables[TableName.APPurchaseOrdersTableName] = ds;
                }
                repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                gridView.Columns["FK_APPurchaseOrderID"].ColumnEdit = repositoryItemLookUpEdit;
            }

            if (gridView.Columns["FK_ICReceiptID"] != null)
                gridView.Columns["FK_ICReceiptID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_APInvoiceInID"] != null)
                gridView.Columns["FK_APInvoiceInID"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["APPaymentProposalItemDesc"] != null)
                gridView.Columns["APPaymentProposalItemDesc"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["APPaymentProposalItemPaidAmount"] != null)
                gridView.Columns["APPaymentProposalItemPaidAmount"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["APPaymentProposalItemTotalAmount"] != null)
                gridView.Columns["APPaymentProposalItemTotalAmount"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["APPaymentProposalItemBookNo"] != null)
                gridView.Columns["APPaymentProposalItemBookNo"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["APPaymentProposalItemProposalAmount"] != null)
                gridView.Columns["APPaymentProposalItemProposalAmount"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["APPaymentProposalItemDiscountFix"] != null)
                gridView.Columns["APPaymentProposalItemDiscountFix"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["APPaymentProposalItemPaymentTimeName"] != null)
            {
                gridView.Columns["APPaymentProposalItemPaymentTimeName"].OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemTextEdit = new RepositoryItemLookUpEdit();

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

                gridView.Columns["APPaymentProposalItemPaymentTimeName"].ColumnEdit = repositoryItemTextEdit;

            }
            //TNDLoc [ADD][14/04/2015][Set Allow],END
            GridColumn column = gridView.Columns["APInvoiceInItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemButtonEdit buttonEdit = new RepositoryItemButtonEdit();
                //buttonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(RepositoryUnitCostButtonEdit_ButtonClick);
                column.ColumnEdit = buttonEdit;
                InitColumnRepositoryFormat(column, TableName.APInvoiceInItemsTableName, "APInvoiceInItemProductUnitCost");
            }

            gridView.KeyDown += new KeyEventHandler(GridView_KeyDown);
            gridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(GridView_CustomDrawCell);
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
                APPaymentProposalItemsInfo objPaymentProposalItemsInfo = (APPaymentProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objPaymentProposalItemsInfo != null && info.Column != null)
                {
                    if (info.Column.FieldName == "FK_APPurchaseOrderID" && objPaymentProposalItemsInfo.FK_APPurchaseOrderID > 0)
                        ((PaymentProposalModule)Screen.Module).ShowPurchaseOrderScreen(objPaymentProposalItemsInfo.FK_APPurchaseOrderID);
                    if ((info.Column.FieldName == "FK_APInvoiceInID" || info.Column.FieldName == "APPaymentProposalItemInvoiceInNo") && objPaymentProposalItemsInfo.FK_APInvoiceInID > 0)
                        ((PaymentProposalModule)Screen.Module).ShowInvoiceInScreen(objPaymentProposalItemsInfo.FK_APInvoiceInID);
                }
            }
        }
        //TNDLoc [ADD][14/04/2015][Calculate Remain Amount],END
        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PaymentProposalModule)Screen.Module).DeleteItemFromPaymentProposalItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            PaymentProposalEntities entity = (PaymentProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)entity.MainObject;
            if (entity.PaymentProposalItemsList.CurrentIndex >= 0)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    if (e.Column.FieldName == "APPaymentProposalItemProposalAmount")
                    {
                        mainObject.APPaymentProposalTotalAmount = entity.PaymentProposalItemsList.Sum(o => o.APPaymentProposalItemProposalAmount);
                        entity.UpdateTotalAmount();
                        entity.UpdateMainObjectBindingSource();
                    }
                    else if (e.Column.FieldName == "APPaymentProposalItemDiscountFix")
                    {
                        entity.UpdateTotalAmount();
                        entity.UpdateMainObjectBindingSource();
                    }
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
            GridView gridView = (GridView)sender;
            PaymentProposalEntities entity = (PaymentProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APPaymentProposalsInfo mainObject = (APPaymentProposalsInfo)entity.MainObject;

            if (gridView.FocusedRowHandle >= 0)
            {
                APPaymentProposalItemsInfo item = (APPaymentProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (gridView.FocusedColumn.FieldName == "APPaymentProposalItemProposalAmount")
                {
                    decimal oldProposalAmount = Convert.ToDecimal(e.Value);
                    if (oldProposalAmount < 0)
                    {
                        e.Valid = false;
                        e.ErrorText = "Bạn không được đề nghị số tiền âm";
                    }
                    else if(oldProposalAmount > item.APPaymentProposalItemRemainAmount)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số tiền đề nghị không được vượt quá số tiền còn lại!";
                    }    
                }
                else if (gridView.FocusedColumn.FieldName == "APPaymentProposalItemDiscountFix")
                {
                    decimal discountFix = Convert.ToDecimal(e.Value);
                    if (discountFix < 0)
                    {
                        e.Valid = false;
                        e.ErrorText = "Bạn không được chiết khấu số tiền âm";
                    }
                    else if (discountFix > mainObject.APPaymentProposalDiscountFix)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số tiền chiết khấu không được vượt quá tổng chiết khấu thanh toán";
                    }
                    if (discountFix > item.APPaymentProposalItemProposalAmount)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số tiền chiết khấu không được vượt quá số tiền đề nghị!";
                    }
                }
            }
        }
    }
}

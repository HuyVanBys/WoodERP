using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace BOSERP.Modules.CustomerPaymentProposal
{
    public partial class ARPaymentProposalItemsGridControl : BOSGridControl
    {
        private string NewType { get; set; }

        public override void InitGridControlDataSource()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaymentProposalItemsList;
            this.DataSource = bds;
        }
        //protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);
        //    gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

        //}

        void repositoryItemTextEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //LookUpEdit objItem = (LookUpEdit)sender;
            //((ProposalModule)Screen.Module).ChangeSaleOrderItemPackageFee(objItem.EditValue.ToString());
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);            

            if (gridView.Columns["FK_ARSaleContractID"] != null)
                gridView.Columns["FK_ARSaleContractID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARInvoiceItemProductQty"] != null)
                gridView.Columns["ARInvoiceItemProductQty"].OptionsColumn.AllowEdit = true;
            //TNDLoc [ADD][14/04/2015][Set Allow],START
            if (gridView.Columns["FK_ARSaleOrderID"] != null)
                gridView.Columns["FK_ARSaleOrderID"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["FK_ICShipmentID"] != null)
                gridView.Columns["FK_ICShipmentID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_ARInvoiceID"] != null)
                gridView.Columns["FK_ARInvoiceID"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARPaymentProposalItemDesc"] != null)
                gridView.Columns["ARPaymentProposalItemDesc"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARPaymentProposalItemPaidAmount"] != null)
                gridView.Columns["ARPaymentProposalItemPaidAmount"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARPaymentProposalItemTotalAmount"] != null)
                gridView.Columns["ARPaymentProposalItemTotalAmount"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["ARPaymentProposalItemBookNo"] != null)
                gridView.Columns["ARPaymentProposalItemBookNo"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARPaymentProposalItemProposalAmount"] != null)
                gridView.Columns["ARPaymentProposalItemProposalAmount"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ARPaymentProposalItemPaymentTimeName"] != null)
            {
                gridView.Columns["ARPaymentProposalItemPaymentTimeName"].OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemTextEdit = new RepositoryItemLookUpEdit();
                repositoryItemTextEdit.EditValueChanged += new EventHandler(repositoryItemTextEdit2_EditValueChanged);
                // column.ColumnEdit.EditValueChanged += new EventHandler(repositoryItemTextEdit2_EditValueChanged);
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("SaleOrderPaymentTimeName");

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

                gridView.Columns["ARPaymentProposalItemPaymentTimeName"].ColumnEdit = repositoryItemTextEdit;

            }
            //TNDLoc [ADD][14/04/2015][Set Allow],END
            GridColumn column = gridView.Columns["ARInvoiceItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemButtonEdit buttonEdit = new RepositoryItemButtonEdit();
                //buttonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(RepositoryUnitCostButtonEdit_ButtonClick);
                column.ColumnEdit = buttonEdit;
                InitColumnRepositoryFormat(column, TableName.ARInvoiceItemsTableName, "ARInvoiceItemProductUnitCost");
            }

            gridView.KeyDown += new KeyEventHandler(GridView_KeyDown);
            gridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(GridView_CustomDrawCell);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            if (NewType == CustomerPaymentProposalNewType.FromPaymentTerm.ToString())
                return gridView;
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemSaleOrder = new RepositoryItemBOSLookupEdit();
                repositoryItemSaleOrder.DataSource = ((CustomerPaymentProposalModule)Screen.Module).GetAllSaleOrderForPaymentProposal();
                repositoryItemSaleOrder.DisplayMember = "ARSaleOrderNo";
                repositoryItemSaleOrder.ValueMember = "ARSaleOrderID";
                repositoryItemSaleOrder.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemSaleOrder.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemSaleOrder.NullText = string.Empty;
                repositoryItemSaleOrder.Columns.Add(new LookUpColumnInfo("ARSaleOrderNo", "Mã đơn hàng"));
                repositoryItemSaleOrder.Columns.Add(new LookUpColumnInfo("ARSaleOrderDate", "Ngày chứng từ"));
                repositoryItemSaleOrder.Columns.Add(new LookUpColumnInfo("ACObjectName", "Đối tượng"));
                repositoryItemSaleOrder.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemSaleOrder_QueryPopUp);
                //repositoryItemSaleOrder.CloseUp += new CloseUpEventHandler(repositoryItemSaleOrder_CloseUp);
                column.ColumnEdit = repositoryItemSaleOrder;
            }
            column = gridView.Columns["FK_ARInvoiceID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemInvoice = new RepositoryItemBOSLookupEdit();
                repositoryItemInvoice.DataSource = ((CustomerPaymentProposalModule)Screen.Module).GetAllInvoiceForPaymentProposal();
                repositoryItemInvoice.DisplayMember = "ARInvoiceNo";
                repositoryItemInvoice.ValueMember = "ARInvoiceID";
                repositoryItemInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemInvoice.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemInvoice.NullText = string.Empty;
                repositoryItemInvoice.Columns.Add(new LookUpColumnInfo("ARInvoiceNo", "Mã hóa đơn"));
                repositoryItemInvoice.Columns.Add(new LookUpColumnInfo("ARInvoiceDate", "Ngày chứng từ"));
                repositoryItemInvoice.Columns.Add(new LookUpColumnInfo("ACObjectName", "Đối tượng"));
                repositoryItemInvoice.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemInvoice_QueryPopUp);
                //repositoryItemInvoice.CloseUp += new CloseUpEventHandler(repositoryItemInvoice_CloseUp);
                column.ColumnEdit = repositoryItemInvoice;
            }
            if (gridView.Columns["ARPaymentProposalItemPaidAmount"] != null)
                gridView.Columns["ARPaymentProposalItemPaidAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARPaymentProposalItemRemainAmount"] != null)
                gridView.Columns["ARPaymentProposalItemRemainAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARPaymentProposalItemDepositAmount"] != null)
                gridView.Columns["ARPaymentProposalItemDepositAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARPaymentProposalItemTotalAmount"] != null)
                gridView.Columns["ARPaymentProposalItemTotalAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleOrderPaymentTimeDueDate"] != null)
                gridView.Columns["ARSaleOrderPaymentTimeDueDate"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARPaymentProposalItemGuaranteeToDate"] != null)
                gridView.Columns["ARPaymentProposalItemGuaranteeToDate"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARPaymentProposalItemGuaranteeFromDate"] != null)
                gridView.Columns["ARPaymentProposalItemGuaranteeFromDate"].OptionsColumn.AllowEdit = true;

            return gridView;
        }

        private void repositoryItemSaleOrder_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CustomerPaymentProposalModule)Screen.Module).GetAllSaleOrderForPaymentProposal();
            lookUpEdit.Properties.DisplayMember = "ARSaleOrderNo";
            lookUpEdit.Properties.ValueMember = "ARSaleOrderID";
        }

        private void repositoryItemInvoice_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CustomerPaymentProposalModule)Screen.Module).GetAllInvoiceForPaymentProposal();
            lookUpEdit.Properties.DisplayMember = "ARInvoiceNo";
            lookUpEdit.Properties.ValueMember = "ARInvoiceID";
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARSaleOrderID")
            {
                if (e.Value != null)
                {
                    int saleOrderID = int.Parse(e.Value.ToString());
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(saleOrderID);
                    if (objSaleOrdersInfo != null)
                        e.DisplayText = objSaleOrdersInfo.ARSaleOrderNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        //TNDLoc [ADD][14/04/2015][Calculate Remain Amount],START
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.PaymentProposalItemsList.CurrentIndex >= 0)
            {
                //if (e.Column.FieldName == "APPaymentProposalItemPaidAmount" || e.Column.FieldName == "APPaymentProposalItemTotalAmount")
                //{
                //    entity.PaymentProposalItemsList[entity.PaymentProposalItemsList.CurrentIndex].APPaymentProposalItemRemainAmount
                //        = entity.PaymentProposalItemsList[entity.PaymentProposalItemsList.CurrentIndex].APPaymentProposalItemTotalAmount
                //         - entity.PaymentProposalItemsList[entity.PaymentProposalItemsList.CurrentIndex].APPaymentProposalItemPaidAmount;
                //}
                //TNDLoc [ADD][08/07/2015][Issue check qty],START
                GridView gridView = sender as GridView;
                if (e.Column.FieldName == "ARPaymentProposalItemProposalAmount")
                {
                    bool isValid = ((CustomerPaymentProposalModule)Screen.Module).CheckQtyChange();
                    if (!isValid)
                    {
                        entity.PaymentProposalItemsList[entity.PaymentProposalItemsList.CurrentIndex].ARPaymentProposalItemProposalAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }

                if (e.Column.FieldName == "FK_ARSaleOrderID")
                {
                    //ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
                    ARPaymentProposalItemsInfo objPaymentProposalItemsInfo = entity.PaymentProposalItemsList[entity.PaymentProposalItemsList.CurrentIndex];
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objPaymentProposalItemsInfo.FK_ARSaleOrderID);
                    if (objPaymentProposalItemsInfo != null)
                    {
                        ((CustomerPaymentProposalModule)Screen.Module).ChangItemFromPaymentProposalItem(objSaleOrdersInfo.FK_ACObjectID, objSaleOrdersInfo.ARObjectType);
                    }
                }

                if (e.Column.FieldName == "FK_ARInvoiceID")
                {
                    //ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle);
                    ARPaymentProposalItemsInfo objPaymentProposalItemsInfo = entity.PaymentProposalItemsList[entity.PaymentProposalItemsList.CurrentIndex];
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(objPaymentProposalItemsInfo.FK_ARInvoiceID);
                    if (objPaymentProposalItemsInfo != null)
                    {
                        ((CustomerPaymentProposalModule)Screen.Module).ChangItemFromPaymentProposalItem(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
                    }
                }
                //TNDLoc [ADD][08/07/2015][Issue check qty],END
            }
        }
        //TNDLoc [ADD][14/04/2015][Calculate Remain Amount],END
        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CustomerPaymentProposalModule)Screen.Module).DeleteItemFromPaymentProposalItemsList();
            }
        }

        public void EnableControl(string newType)
        {
            NewType = newType;
            InitializeGridView();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = CustomerPaymentProposalLocalizedResources.WaitingPayment;
            column.FieldName = "ARPaymentProposalItemWaitingPayment";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}

using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptFreshLumber
{
    public class ICBatchReceiptFreshLumberItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "FK_ICProductSerieID")
                {
                    ((BatchReceiptFreshLumberModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else if (e.Column.FieldName == "ICReceiptItemProductQty" || e.Column.FieldName == "ICReceiptItemWoodQty" || e.Column.FieldName == "ICReceiptItemProductLength")
                {
                    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                    ((BatchReceiptFreshLumberModule)Screen.Module).ChangeItemFromReceiptItemsListQty(item);
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((BatchReceiptFreshLumberModule)Screen.Module).ChangeStock(item);
                }
                else
                {
                    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                    ((BatchReceiptFreshLumberModule)Screen.Module).ChangeItemFromReceiptItemsList();
                }
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACAccountID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    // ICProductIdentifiedEquipmentsController objPIEsController = new ICProductIdentifiedEquipmentsController();
                    ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
                    ACAccountsController objAccountsController = new ACAccountsController();
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(matchCodeID);
                    if (objAccountsInfo != null)
                        e.DisplayText = objAccountsInfo.ACAccountNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = ReceiptFreshLumberLocalizedResources.ICSerialNo;
            column.FieldName = "SerialNo";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit SerialNo = new RepositoryItemHyperLinkEdit();
            SerialNo.NullText = ReceiptFreshLumberLocalizedResources.ICSerialNo;
            SerialNo.Click += new EventHandler(SerialNo_Click);
            column.ColumnEdit = SerialNo;
            gridView.Columns.Add(column);

        }
        private void SerialNo_Click(object sender, EventArgs e)
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            if ((long)objReceiptItemsInfo.ICReceiptItemWoodQty > 0)
            {
                long ReceiptItemWoodQty = (long)objReceiptItemsInfo.ICReceiptItemWoodQty;
                ((BatchReceiptFreshLumberModule)Screen.Module).ChangeQTyFromReceiptItemsList(ReceiptItemWoodQty);
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                ((BatchReceiptFreshLumberModule)Screen.Module).ChangeItemFromReceiptItemsList();
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((BatchReceiptFreshLumberModule)Screen.Module).DeleteItemFromReceiptItemsList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = ReceiptFreshLumberLocalizedResources.FK_GECountryID;
            }

            column = gridView.Columns["FK_ICProductSerieID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = ReceiptFreshLumberLocalizedResources.ICReceiptItemProductSerialNo;
            }
            column = gridView.Columns["ICReceiptItemLotNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLenghtMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemWidthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = ReceiptFreshLumberLocalizedResources.ICReceiptItemWoodQty;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemWidthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLenghtMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
                column.Caption = ReceiptFreshLumberLocalizedResources.ICReceiptItemProductQty;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeQualityLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeTTMTLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICReceiptItemProductQty", DevExpress.Data.SummaryItemType.Sum);

            return gridView;
        }

        void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptFreshLumberModule)Screen.Module).GetProductItemAttributeQuality();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptFreshLumberModule)Screen.Module).GetProductItemAttributeWoodType();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeTTMTLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptFreshLumberModule)Screen.Module).GetProductItemAttributeTTMT();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //ShowInventory();
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }
    }
}

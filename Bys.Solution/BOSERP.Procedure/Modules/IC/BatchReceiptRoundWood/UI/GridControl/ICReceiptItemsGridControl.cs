using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using BOSCommon;
using Localization;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Data;
using BOSERP.Modules.IC.BatchReceiptRoundWood.Localization;

namespace BOSERP.Modules.BatchReceiptRoundWood
{
    public class ICReceiptItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            BatchReceiptRoundWoodEntities entity = (BatchReceiptRoundWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            BatchReceiptRoundWoodEntities entity = (BatchReceiptRoundWoodEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                //if (e.Column.FieldName == "ICReceiptItemProductSerialNo")
                //{
                //    ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemSerieNo(item);
                //}
                if (e.Column.FieldName == "ICReceiptItemProductPerimeter" || e.Column.FieldName == "ICReceiptItemProductLength"  )
                {
                    ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemSize(item);
                }
                //else if(e.Column.FieldName=="ICReceiptItemProductQty")
                //{
                    
                //    ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemQty(item);
                //}
                else
                {
                    ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemFromReceiptItemsList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((BatchReceiptRoundWoodModule)Screen.Module).DeleteItemFromReceiptItemsList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = InvoiceInLocalizedResources.LotNoCaption;
            column.FieldName = "ICReceiptItemLotNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.ICSerialNo;
            column.FieldName = "SerialNo";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit SerialNo = new RepositoryItemHyperLinkEdit();
            SerialNo.NullText = PurchaseReceiptLocalizedResources.ICSerialNo;
            SerialNo.Click += new EventHandler(SerialNo_Click);
            column.ColumnEdit = SerialNo;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = PurchaseReceiptLocalizedResources.RoundWoodSplitMessage;
            column.FieldName = "RoundWoodSplit";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 12;
            RepositoryItemHyperLinkEdit SplitWood = new RepositoryItemHyperLinkEdit();
            SplitWood.NullText = PurchaseReceiptLocalizedResources.RoundWoodSplitMessage;
            SplitWood.Click += new EventHandler(SplitWood_Click);
            column.ColumnEdit = SplitWood;
            gridView.Columns.Add(column);

            if (gridView.Columns["ICReceiptItemProductPerimeter"] != null)
                gridView.Columns["ICReceiptItemProductPerimeter"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["FK_ICProductAttributeWoodTypeID"] != null)
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["FK_ICMeasureUnitID"] != null)
                gridView.Columns["FK_ICMeasureUnitID"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["FK_GECountryID"] != null)
                gridView.Columns["FK_GECountryID"].OptionsColumn.AllowEdit = false;
        }
        private void SerialNo_Click(object sender, EventArgs e)
        {
            BatchReceiptRoundWoodEntities entity = (BatchReceiptRoundWoodEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            //if ((long)objICReceiptItemsInfo.ICReceiptItemProductQty > 0)
            //{
            //    long receiptItemProductQty = (long)objICReceiptItemsInfo.ICReceiptItemProductQty;
            //    ((BatchReceiptRoundWoodModule)Screen.Module).ChangeQTyFromReceiptItemsList(receiptItemProductQty);
            //    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
            //    ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemFromReceiptItemsList();
            //}

            if ((long)objICReceiptItemsInfo.ICReceiptItemWoodQty > 0)
            {
                long ReceiptItemWoodQty = (long)objICReceiptItemsInfo.ICReceiptItemWoodQty;
                ((BatchReceiptRoundWoodModule)Screen.Module).ChangeQTyFromReceiptItemsList(ReceiptItemWoodQty);
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemFromReceiptItemsList();
            }
        }
        private void SplitWood_Click(object sender, EventArgs e)
        {
            BatchReceiptRoundWoodEntities entity = (BatchReceiptRoundWoodEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptItemsInfo objICReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            if ((long)objICReceiptItemsInfo.ICReceiptItemWoodQty > 0)
            {
                long receiptItemWoodQty = (long)objICReceiptItemsInfo.ICReceiptItemWoodQty;
                ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemFromReceiptItemsList(receiptItemWoodQty);
                entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                ((BatchReceiptRoundWoodModule)Screen.Module).ChangeItemFromReceiptItemsList();
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                gridView.Columns["ICReceiptItemProductQty"].OptionsColumn.AllowEdit = true;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatString = "{0:n4}";
                gridView.Columns["ICReceiptItemProductQty"].Caption = BatchReceiptRoundWoodLocalizedResources.BLockCaptionMessage;
            }
            if (gridView.Columns["ICReceiptItemProductPerimeter"] != null)
                gridView.Columns["ICReceiptItemProductPerimeter"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductLength"] != null)
                gridView.Columns["ICReceiptItemProductLength"].OptionsColumn.AllowEdit = true;
 
            if (gridView.Columns["ICReceiptItemComment"] != null)
                gridView.Columns["ICReceiptItemComment"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductWidth"] != null)
                gridView.Columns["ICReceiptItemProductWidth"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductHeight"] != null)
                gridView.Columns["ICReceiptItemProductHeight"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemHeightMax"] != null)
                gridView.Columns["ICReceiptItemHeightMax"].Visible = false;

            if (gridView.Columns["ICReceiptItemLengthMax"] != null)
                gridView.Columns["ICReceiptItemLengthMax"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemWidthMax"] != null)
                gridView.Columns["ICReceiptItemWidthMax"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemWidthMin"] != null)
                gridView.Columns["ICReceiptItemWidthMin"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemWoodQty"] != null)
                gridView.Columns["ICReceiptItemWoodQty"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemContainerNo"] != null)
                gridView.Columns["ICReceiptItemContainerNo"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductUnitCost"] != null)
                gridView.Columns["ICReceiptItemProductUnitCost"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = PurchaseReceiptLocalizedResources.RoundWoodSerialNo;
            }

            if (gridView.Columns["ICReceiptItemLotNo"] != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 1;
            }
            column = gridView.Columns["ICReceiptItemContainerNo"];
            if (column != null)
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
           
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Mã"));
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
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeTTMTLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
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
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeQualityLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICReceiptItemTotalCost", DevExpress.Data.SummaryItemType.Sum);
            //gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptRoundWoodModule)Screen.Module).GetProductItemAttributeQuality();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptRoundWoodModule)Screen.Module).GetProductItemAttributeWoodType();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeTTMTLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptRoundWoodModule)Screen.Module).GetProductItemAttributeTTMT();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
       
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
           // ShowInventory();
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
                BatchReceiptRoundWoodEntities entity = (BatchReceiptRoundWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                //((BaseTransactionModule)Screen.Module).ShowInventory(productID,true,true);
                string woodType = dbUtil.GetPropertyStringValue(objReceiptsInfo, "ICReceiptPurchaseTypeCombo");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                if (woodType == ReceiptPurchaseType.Roundwood.ToString())
                {
                  
                    
                    ((BaseTransactionModule)Screen.Module).ShowInventory(productID, true, true, desc, modelID, modelDetailID);
                }
                else
                {
                    ((BaseTransactionModule)Screen.Module).ShowInventory(productID, true, false, desc, modelID, modelDetailID);
                }
            }
        }

        public void LoadGridViewForRoundWood()
        {
            BatchReceiptRoundWoodEntities entity = (BatchReceiptRoundWoodEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;

            }
        }
        public void LoadGridViewForLumber()
        {
            BatchReceiptRoundWoodEntities entity = (BatchReceiptRoundWoodEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

            }
        }

    }
}
    
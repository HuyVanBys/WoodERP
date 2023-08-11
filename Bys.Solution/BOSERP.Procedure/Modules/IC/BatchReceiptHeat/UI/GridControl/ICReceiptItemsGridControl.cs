using BOSCommon.Constants;
using BOSERP.Modules.IC.BatchReceiptRoundWood.Localization;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
//using BOSERP.Modules.IC.BatchReceiptDryLumber.Localization;
//using BOSERP.Modules.MM.BatchReceiptLumber.Localization;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptHeat
{
    public class ICReceiptItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            BatchReceiptHeatEntities entity = (BatchReceiptHeatEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                if (e.Column.FieldName == "ICReceiptItemProductSerialNo")
                {
                    ((BatchReceiptHeatModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else
                {
                    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                    ((BatchReceiptHeatModule)Screen.Module).ChangeItemFromReceiptItemsList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((BatchReceiptHeatModule)Screen.Module).DeleteItemFromReceiptItemsList();
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
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                gridView.Columns["ICReceiptItemProductQty"].OptionsColumn.AllowEdit = true;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatString = "{0:n4}";
                gridView.Columns["ICReceiptItemProductQty"].Caption = BatchReceiptRoundWoodLocalizedResources.BLockCaptionMessage;
            }
            if (gridView.Columns["ICReceiptItemWoodQty"] != null)
                gridView.Columns["ICReceiptItemWoodQty"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemComment"] != null)
                gridView.Columns["ICReceiptItemComment"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductLength"] != null)
                gridView.Columns["ICReceiptItemProductLength"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductHeight"] != null)
                gridView.Columns["ICReceiptItemProductHeight"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductWidth"] != null)
                gridView.Columns["ICReceiptItemProductWidth"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemLenghtMax"] != null)
                gridView.Columns["ICReceiptItemLenghtMax"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemHeightMax"] != null)
                gridView.Columns["ICReceiptItemHeightMax"].Visible = false;

            if (gridView.Columns["ICReceiptItemWidthMax"] != null)
                gridView.Columns["ICReceiptItemWidthMax"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductWith"] != null)
                gridView.Columns["ICReceiptItemProductWith"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;

            //if (gridView.Columns["FK_ICProductSerieID"] != null)
            //    gridView.Columns["FK_ICProductSerieID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductPerimeter"] != null)
                gridView.Columns["ICReceiptItemProductPerimeter"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemContainerNo"] != null)
                gridView.Columns["ICReceiptItemContainerNo"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductQty"] != null)
                gridView.Columns["ICReceiptItemProductQty"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_MMOperationID"] != null)
                gridView.Columns["FK_MMOperationID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductUnitCost"] != null)
                gridView.Columns["ICReceiptItemProductUnitCost"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.Caption = WoodPurchaseReceiptLocalizedResources.LumberSerialNoCaption;
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 4;
            }

            column = gridView.Columns["ICReceiptItemLotNo"];
            if (column != null)
            {
                column.Visible = true;
                column.Caption = WoodPurchaseReceiptLocalizedResources.LotNo;
                column.VisibleIndex = 1;
            }
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICReceiptItemTotalCost", DevExpress.Data.SummaryItemType.Sum);

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

            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //ShowInventory();
        }
        void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptHeatModule)Screen.Module).GetProductItemAttributeQuality();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptHeatModule)Screen.Module).GetProductItemAttributeWoodType();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeTTMTLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchReceiptHeatModule)Screen.Module).GetProductItemAttributeTTMT();
            lookUpEdit.Properties.DataSource = productAttributesList;
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace BOSERP.Modules.BatchShipmentRoundWood
{
    public class ICShipmentItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            column.FieldName = "AddNewRow";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            AddNewRow.NullText = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            AddNewRow.Click += new EventHandler(AddNewRow_Click);
            column.ColumnEdit = AddNewRow;

            gridView.Columns.Add(column);
        }
        private void AddNewRow_Click(object sender, EventArgs e)
        {
            BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)(this.Screen.Module as BatchShipmentRoundWoodModule).CurrentModuleEntity;
            ICShipmentsInfo ShipmentItemsInfo = (ICShipmentsInfo)entity.MainObject;
            if (ShipmentItemsInfo.ICShipmentStatus != ShipmentStatus.Complete.ToString())
            {
                (this.Screen.Module as BatchShipmentRoundWoodModule).ActionEdit();
            }
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex].Clone();
            objShipmentItemsInfo.ICShipmentItemID = 0;
            entity.ShipmentItemList.Add(objShipmentItemsInfo);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column1 in gridView.Columns)
            {
                column1.OptionsColumn.AllowEdit = true;
            }
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.VisibleIndex = 1;
            }
            column = gridView.Columns["ICShipmentItemProductDesc"];
            if (column != null)
            {
                column.VisibleIndex = 2;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.VisibleIndex = 3;
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.VisibleIndex = 4;
            }

            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.VisibleIndex = 5;
            }

            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.VisibleIndex = 6;
            }

            column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
                column.Caption = BatchShipmentRoundWoodLocalizedResources.ICShipmentItemProductQty;
            }
            column = gridView.Columns["FK_ICProductSerieID"];
            if (column != null)
            {
                column.Visible = false;
            }
            //column = gridView.Columns["ICShipmentItemWoodQty"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = BatchShipmentRoundWoodLocalizedResources.MMBatchProductID;
            }
            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = BatchShipmentRoundWoodLocalizedResources.MMOperationID;
            }
            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = BatchShipmentRoundWoodLocalizedResources.SeriNoCaption;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
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
            InitColumnSummary("ICShipmentItemProductQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                //ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                //if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                //{
                //    ((BatchShipmentRoundWoodModule)Screen.Module).ChangeItemlist(item);
                //}
                //else
                //{
                //    BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                //    entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                //((BatchShipmentRoundWoodModule)Screen.Module).ChangeItemFromShipmentItemsList();
                //}

                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                    {
                        ((BatchShipmentRoundWoodModule)Screen.Module).ChangeItemSerieNo(item);
                    }

                    else if (e.Column.FieldName == "FK_ICStockID")
                    {
                        ((BatchShipmentRoundWoodModule)Screen.Module).SelectSeriesNoDefault();
                        ((BatchShipmentRoundWoodModule)Screen.Module).ChangeItemSerieNo(item);
                    }
                    else
                    {
                        BatchShipmentRoundWoodEntities entity = (BatchShipmentRoundWoodEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                        entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                        ((BatchShipmentRoundWoodModule)Screen.Module).ChangeItemFromShipmentItemsList();
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((BatchShipmentRoundWoodModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }
        void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchShipmentRoundWoodModule)Screen.Module).GetProductItemAttributeQuality();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchShipmentRoundWoodModule)Screen.Module).GetProductItemAttributeWoodType();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
        void repositoryItemAttributeTTMTLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchShipmentRoundWoodModule)Screen.Module).GetProductItemAttributeTTMT();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }
    }
}

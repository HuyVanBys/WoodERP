using BOSCommon;
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
namespace BOSERP.Modules.AssembleProduct
{
    public class ICAssembleProductDetailsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            AssembleProductEntities entity = (AssembleProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICAssembleProductDetailsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "InventoryQty";
            column.Caption = "Tồn kho chi tiết";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n4}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


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
            AssembleProductEntities entity = (AssembleProductEntities)(this.Screen.Module as AssembleProductModule).CurrentModuleEntity;
            ICAssembleProductsInfo AssembleProductsInfo = (ICAssembleProductsInfo)entity.MainObject;
            if (AssembleProductsInfo.ICAssembleProductStatus != AssembleProductStatus.Approved.ToString())
            {
                if (this.Screen.Module.Toolbar.IsNullOrNoneAction())
                {
                    (this.Screen.Module as AssembleProductModule).ActionEdit();
                }
            }
            ICAssembleProductDetailsInfo detail = new ICAssembleProductDetailsInfo();
            detail = (ICAssembleProductDetailsInfo)entity.ICAssembleProductDetailsList[entity.ICAssembleProductDetailsList.CurrentIndex].Clone();
            detail.ICAssembleProductDetailID = 0;
            detail.FK_ICProductSerieID = 0;
            detail.FK_ICStockID = 0;
            detail.ICAssembleProductDetailMixQty = 0;
            detail.ICAssembleProductDetailProductQty = 0;
            entity.ICAssembleProductDetailsList.Add(detail);
            entity.ICAssembleProductDetailsList.GridControl.RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ICAssembleProductDetailProductQty"];
            if (column != null)
            {
                // column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICAssembleProductDetailMixQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICAssembleProductDetailIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICProductSerieID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductSerieNo";
                repositoryItemLookUpEdit.ValueMember = "ICProductSerieID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductSerieNo", "Mã lô"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.FieldName == "FK_ICProductSerieID")
                {
                    int valueID = 0;
                    if (int.TryParse(e.Value.ToString(), out valueID))
                    {
                        ICProductSeriesController psController = new ICProductSeriesController();
                        ICProductSeriesInfo psInfo = (ICProductSeriesInfo)psController.GetObjectByID(valueID);
                        if (psInfo != null)
                        {
                            e.DisplayText = psInfo.ICProductSerieNo;
                        }
                    }
                }
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridView = (GridView)MainView;
            AssembleProductEntities entity = (AssembleProductEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICAssembleProductsInfo main = (ICAssembleProductsInfo)entity.MainObject;
            ICAssembleProductDetailsInfo item = (ICAssembleProductDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            ICProductSeriesController psController = new ICProductSeriesController();

            ICProductsController productController = new ICProductsController();
            ICProductsInfo product = (ICProductsInfo)productController.GetObjectByID(item.FK_ICProductID);

            List<ICProductSeriesInfo> series = new List<ICProductSeriesInfo>();
            if (item.ICAssembleProductDetailIsSpecificCalculation || product.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString())
                series = psController.GetSeriesByProductIDAndStockID(item.FK_ICProductID, item.FK_ICStockID, null, main.ICAssembleProductDate);
            lookUpEdit.Properties.DataSource = series;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                AssembleProductEntities entity = (AssembleProductEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ICAssembleProductsInfo main = (ICAssembleProductsInfo)entity.MainObject;
                ICAssembleProductDetailsInfo item = (ICAssembleProductDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    item.FK_ICProductSerieID = 0;
                    item.InventoryQty = 0;
                    item.ICAssembleProductDetailCanAssembleQty = 0;
                }
                else if (e.Column.FieldName == "FK_ICProductSerieID")
                {
                    ICInventoryStocksController ivController = new ICInventoryStocksController();
                    ICInventoryStocksInfo iv = ivController.GetInventoryStockByStockIDAndProductIDAndSerieID(item.FK_ICStockID
                                                                                                            , item.FK_ICProductID
                                                                                                            , item.FK_ICProductSerieID);
                    if (iv != null)
                    {
                        item.InventoryQty = iv.ICInventoryStockQuantity;
                    }
                    else
                    {
                        item.InventoryQty = 0;
                    }
                }
                else if (e.Column.FieldName == "ICAssembleProductDetailMixQty")
                {
                    item.ICAssembleProductDetailProductQty = item.ICAssembleProductDetailMixQty * main.ICAssembleProductQty;
                }
                else if (e.Column.FieldName == "ICAssembleProductDetailIsSpecificCalculation")
                {
                    item.FK_ICProductSerieID = !item.ICAssembleProductDetailIsSpecificCalculation ? 0 : item.FK_ICProductSerieID;
                }
                this.RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AssembleProductModule)Screen.Module).DeleteItemFromAssembleProductDetailsList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }
    }
}

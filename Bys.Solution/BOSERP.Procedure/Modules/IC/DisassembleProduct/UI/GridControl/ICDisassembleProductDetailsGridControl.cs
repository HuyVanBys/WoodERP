using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace BOSERP.Modules.DisassembleProduct
{
    public class ICDisassembleProductDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DisassembleProductEntities entity = (DisassembleProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICDisassembleProductDetailsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.FieldName = "InventoryQty";
            //column.Caption = "Tồn kho chi tiết";
            //column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //column.DisplayFormat.FormatString = "{0:n4}";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);


            //column = new GridColumn();
            //column.Caption = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            //column.FieldName = "AddNewRow";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            //AddNewRow.NullText = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            //AddNewRow.Click += new EventHandler(AddNewRow_Click);
            //column.ColumnEdit = AddNewRow;
            //gridView.Columns.Add(column);
        }

        private void AddNewRow_Click(object sender, EventArgs e)
        {
            DisassembleProductEntities entity = (DisassembleProductEntities)(this.Screen.Module as DisassembleProductModule).CurrentModuleEntity;
            ICDisassembleProductsInfo DisassembleProductsInfo = (ICDisassembleProductsInfo)entity.MainObject;
            if (DisassembleProductsInfo.ICDisassembleProductStatus != DisassembleProductStatus.Approved.ToString())
            {
                if (this.Screen.Module.Toolbar.IsNullOrNoneAction())
                {
                    (this.Screen.Module as DisassembleProductModule).ActionEdit();
                }
            }
            ICDisassembleProductDetailsInfo detail = new ICDisassembleProductDetailsInfo();
            detail = (ICDisassembleProductDetailsInfo)entity.ICDisassembleProductDetailsList[entity.ICDisassembleProductDetailsList.CurrentIndex].Clone();
            detail.ICDisassembleProductDetailID = 0;
            detail.FK_ICProductSerieID = 0;
            detail.FK_ICStockID = 0;
            detail.ICDisassembleProductDetailMixQty = 0;
            detail.ICDisassembleProductDetailProductQty = 0;
            entity.ICDisassembleProductDetailsList.Add(detail);
            entity.ICDisassembleProductDetailsList.GridControl.RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ICDisassembleProductDetailProductQty"];

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICDisassembleProductDetailIsAverageCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
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
            ICDisassembleProductDetailsInfo item = (ICDisassembleProductDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            ICProductSeriesController psController = new ICProductSeriesController();
            List<ICProductSeriesInfo> psList = psController.GetProductSerieByStockIDAndProductID(item.FK_ICStockID, item.FK_ICProductID);
            lookUpEdit.Properties.DataSource = psList;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                DisassembleProductEntities entity = (DisassembleProductEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ICDisassembleProductsInfo main = (ICDisassembleProductsInfo)entity.MainObject;
                ICDisassembleProductDetailsInfo item = (ICDisassembleProductDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    if (MessageBox.Show("Bạn có muốn mặc định kho này cho các chi tiết còn lại?"
                                        , "Thông báo"
                                        , MessageBoxButtons.YesNo
                                        , MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int stockID = item.FK_ICStockID;
                        entity.ICDisassembleProductDetailsList.ForEach(t => t.FK_ICStockID = stockID);
                    }
                }

                this.RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                // ((DisassembleProductModule)Screen.Module).DeleteItemFromDisassembleProductDetailsList();
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

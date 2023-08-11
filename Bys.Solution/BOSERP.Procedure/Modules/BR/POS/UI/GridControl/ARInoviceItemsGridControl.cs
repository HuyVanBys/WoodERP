using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace BOSERP.Modules.POS
{
    public class ARInoviceItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            POSEntities entity = (POSEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = POSLocalizedResources.InvoiceItemComponent;
            column.FieldName = "InvoiceItemComponent";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpChooseItemComponent = new RepositoryItemHyperLinkEdit();
            rpChooseItemComponent.NullText = InvoiceLocalizedResources.InvoiceItemComponentList;
            rpChooseItemComponent.Click += new EventHandler(RpChooseItemComponent_Click);
            column.ColumnEdit = rpChooseItemComponent;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã vạch";
            column.FieldName = "ARInvoiceItemProductBarCode";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã SP đối tác";
            column.FieldName = "ARInvoiceItemProductCustomerNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            if (gridView.Columns["ARInvoiceItemProductQty"] != null)
                gridView.Columns["ARInvoiceItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARInvoiceItemProductUnitPrice"] != null)
                gridView.Columns["ARInvoiceItemProductUnitPrice"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ARInvoiceItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemDiscountAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARInvoiceItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds1 = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds1.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                rpMeasureUnit.CloseUp += new CloseUpEventHandler(rpMeasureUnit_CloseUp);
                column.ColumnEdit = rpMeasureUnit;
            }

            column = gridView.Columns["ARInvoiceItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARInvoiceItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARInvoiceItemProductName2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            POSEntities entity = (POSEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARInvoicesInfo mainObject = (ARInvoicesInfo)entity.MainObject;
            if (entity.InvoiceItemList.CurrentIndex >= 0)
            {
                ARInvoiceItemsInfo item = entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex];
                //entity.ModuleObjects[TableName.ARInvoiceItemsTableName] = (ARInvoiceItemsInfo)entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].Clone();
                if (e.Column.FieldName == "ARInvoiceItemProductQty")
                {    
                    (entity.Module as POSModule).ChangeItemFromInvoiceItemList(true);
                    ((POSModule)Screen.Module).ChangeComponentItemQty();
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((POSModule)Screen.Module).ChangeStockOfInvoiceItem();
                }
                else if (e.Column.FieldName == "ARInvoiceItemProductSerialNo")
                {
                    ((POSModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo product = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (product != null)
                    {
                        item.ARInvoiceItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(product,
                                                                                    item.ARInvoiceItemProductUnitPrice,
                                                                                    item.ARInvoiceItemProductQty,
                                                                                    item.FK_ICMeasureUnitID,
                                                                                    objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                    mainObject.ARInvoiceDate,
                                                                                    mainObject.FK_GECurrencyID);
                    }
                    ((POSModule)Screen.Module).ChangeItemMeasureUnit();
                }
                (entity.Module as POSModule).ChangeItemFromInvoiceItemList(false);
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((POSModule)Screen.Module).DeleteItemFromInvoiceItemList();
            }
        }

        private void RpChooseItemComponent_Click(object sender, EventArgs e)
        {
            ((POSModule)Screen.Module).ShowItemComponent();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(matchCodeID);
                    if (objProductsInfo != null)
                        e.DisplayText = objProductsInfo.ICProductNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            POSEntities entity = (POSEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.InvoiceItemList.CurrentIndex >= 0)
            {
                ((POSModule)Screen.Module).InitProductPictureImage(entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].FK_ICProductID);
            }
        }

        public void LoadGridViewBySourceSelling(string sourceSellingType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = new GridColumn();
            if (sourceSellingType == ADConfigValueUtility.cstSourceSellingPriceMethodPriceSheet)
            {
                column = gridView.Columns["ARInvoiceItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            else
            {
                column = gridView.Columns["ARInvoiceItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARInvoiceItemsInfo item = (ARInvoiceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
        }

        private void rpMeasureUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                POSEntities entity = (POSEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARInvoiceItemsInfo item = (ARInvoiceItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                GeneralHelper.ChangeSaleItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
            }
        }


    }
}

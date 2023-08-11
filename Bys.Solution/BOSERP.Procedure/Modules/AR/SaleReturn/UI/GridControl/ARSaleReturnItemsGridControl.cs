using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleReturn
{
    partial class ARSaleReturnItemsGridControl : BOSComponent.BOSGridControl
    {
        public List<ARInvoiceItemsInfo> ListInvoiceItemsInfo { get; set; }

        public override void InitGridControlDataSource()
        {
            SaleReturnEntities entity = (SaleReturnEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleReturnItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SaleReturnLocalizedResources.SaleReturnItemComponent;
            column.FieldName = "SaleReturnItemComponent";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = SaleReturnLocalizedResources.SaleReturnItemComponent;
            rep.Click += new EventHandler(ChooseItemComponent_Click);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã hóa đơn";
            column.FieldName = "FK_ARInvoiceID";
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            List<ARInvoiceItemsInfo> listInvoiceItems = objInvoiceItemsController.GetAllInvoiceItem();
            RepositoryItemLookUpEdit rpInvoiceItem = new RepositoryItemLookUpEdit();
            rpInvoiceItem.DisplayMember = "ARInvoiceNo";
            rpInvoiceItem.ValueMember = "FK_ARInvoiceID";
            rpInvoiceItem.NullText = string.Empty;
            rpInvoiceItem.Columns.Add(new LookUpColumnInfo("ARInvoiceNo", "Mã hóa đơn"));
            rpInvoiceItem.DataSource = listInvoiceItems;
            rpInvoiceItem.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpInvoiceItem_QueryPopUp);
            rpInvoiceItem.CloseUp += new CloseUpEventHandler(rpInvoiceItem_CloseUp);
            column.ColumnEdit = rpInvoiceItem;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "CopyLine";
            column.Caption = "Thêm dòng";
            rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = "Thêm dòng";
            rep.Click += new EventHandler(repCopyLine_Click);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);
        }

        private void ChooseItemComponent_Click(object sender, EventArgs e)
        {
            ((SaleReturnModule)Screen.Module).ShowItemComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["ARSaleReturnItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleReturnItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleReturnItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleReturnItemDiscountAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleReturnItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleReturnItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleReturnItemProductSerialNo"];
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

            column = gridView.Columns["ARSaleReturnItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ARSaleReturnItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                FormatNumbericColumn(column, true, "n5");
            }

            column = gridView.Columns["FK_ARSaleReturnID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            SaleReturnEntities entity = (SaleReturnEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.SaleReturnItemsList.CurrentIndex >= 0)
            {
                ARSaleReturnItemsInfo objSaleReturnItemsInfo = entity.SaleReturnItemsList[entity.SaleReturnItemsList.CurrentIndex];
                if (e.Column.FieldName == "ARSaleReturnItemProductQty")
                {
                    ((SaleReturnModule)Screen.Module).CheckSaleReturnProductQty();
                    ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
                    if (mainObject.FK_ARInvoiceID == 0)
                    {
                        ARCustomersController objCustomersController = new ARCustomersController();
                        ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo product = (ICProductsInfo)objProductsController.GetObjectByID(objSaleReturnItemsInfo.FK_ICProductID);
                        if (product != null)
                        {
                            objSaleReturnItemsInfo.ARSaleReturnItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(product,
                                                                                                                    objSaleReturnItemsInfo.ARSaleReturnItemProductUnitPrice,
                                                                                                                    objSaleReturnItemsInfo.ARSaleReturnItemProductQty,
                                                                                                                    objSaleReturnItemsInfo.FK_ICMeasureUnitID,
                                                                                                                    objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                                                    mainObject.ARSaleReturnGetPriceDate,
                                                                                                                    mainObject.FK_GECurrencyID);
                            entity.SetProductPriceByProductUnitPrice(objSaleReturnItemsInfo);
                        }
                    }
                    ((SaleReturnModule)Screen.Module).ChangeSaleReturnItemProductQty(objSaleReturnItemsInfo);
                    ((SaleReturnModule)Screen.Module).ChangeComponentItemQty();
                }
                else if (e.Column.FieldName == "ARSaleReturnItemProductSerialNo" || e.Column.FieldName == "ARSaleReturnItemLotNo")
                {
                    ((SaleReturnModule)Screen.Module).ChangeSaleReturnItemSerieNo(objSaleReturnItemsInfo);
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((SaleReturnModule)Screen.Module).ChangeItemMeasureUnit();
                }
                entity.ModuleObjects[TableName.ARSaleReturnItemsTableName] = (ARSaleReturnItemsInfo)entity.SaleReturnItemsList[entity.SaleReturnItemsList.CurrentIndex].Clone();
                (entity.Module as SaleReturnModule).ChangeItemFromSaleReturnItemsList();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleReturnModule)Screen.Module).DeleteItemFromSaleReturnItemsList();
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
                //dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductDesc);
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                /*  TNDLoc : T?n kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : T?n kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            SaleReturnEntities entity = (SaleReturnEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.SaleReturnItemsList.CurrentIndex >= 0)
            {
                ((SaleReturnModule)Screen.Module).InitProductPictureImage(entity.SaleReturnItemsList[entity.SaleReturnItemsList.CurrentIndex].FK_ICProductID);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

            if (e.Column.FieldName == "ARListOfSalesChannelType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ListOfSalesChannelType", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
        }

        private void rpMeasureUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleReturnItemsInfo item = (ARSaleReturnItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                GeneralHelper.ChangeSaleItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARSaleReturnItemsInfo item = (ARSaleReturnItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        private void rpInvoiceItem_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            SaleReturnEntities entity = (SaleReturnEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
            ARSaleReturnItemsInfo item = (ARSaleReturnItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                List<ARInvoiceItemsInfo> listInvoiceItem = ListInvoiceItemsInfo.Where(o => o.FK_ICProductID == item.FK_ICProductID).Distinct().ToList();
                if (!string.IsNullOrEmpty(mainObject.ACObjectAccessKey))
                {
                    listInvoiceItem = listInvoiceItem.Where(o => o.FK_ACObjectID == mainObject.FK_ACObjectID && o.ARObjectType == mainObject.ARObjectType).Distinct().ToList();
                }    
                if (listInvoiceItem != null)
                {
                    lookUpEdit.Properties.DataSource = listInvoiceItem;
                    lookUpEdit.Properties.DisplayMember = "ARInvoiceNo";
                    lookUpEdit.Properties.ValueMember = "FK_ARInvoiceID";
                }
            }
        }

        private void rpInvoiceItem_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleReturnItemsInfo item = (ARSaleReturnItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ((SaleReturnModule)Screen.Module).ChangeItemInvoice(item);
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ARSaleReturnItemsInfo item = (ARSaleReturnItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "FK_ARInvoiceID")
                {
                    SaleReturnEntities entity = (SaleReturnEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)entity.MainObject;
                    if (mainObject.STToolbarActionName == "FromInvoice")
                    {
                        e.ErrorText = "Bạn không được chọn lại Hóa đơn cho trường hợp Tạo mới từ Hóa đơn";
                        e.Valid = false;
                    }
                }
            }
        }

        void repCopyLine_Click(object sender, EventArgs e)
        {
            if (!((SaleReturnModule)Screen.Module).Toolbar.IsNullOrNoneAction())
            {
                ((SaleReturnModule)Screen.Module).CopyLine();
            }
        }
    }
}

using BOSCommon;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleForecast
{
    public class ARSaleForecastItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            SaleForecastEntities entity = (SaleForecastEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleForecastItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = SaleForecastLocalizedResources.ARSaleForecastItemRemainedQty;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.FieldName = "ARSaleForecastItemRemainedQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleForecastLocalizedResources.SFItemComponent;
            column.FieldName = "ARSFItemComponent";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = SaleForecastLocalizedResources.ItemComponentList;
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SaleForecastLocalizedResources.ARSaleForecastItemWoods;
            column.FieldName = "ARSaleForecastItemWoods";
            column.OptionsColumn.AllowEdit = false;
            column.ImageAlignment = StringAlignment.Center;
            gridView.Columns.Add(column);
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((SaleForecastModule)Screen.Module).ShowItemComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            if (gridView.Columns["ARSaleForecastItemProductQty"] != null)
                gridView.Columns["ARSaleForecastItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemProductUnitPrice"] != null)
                gridView.Columns["ARSaleForecastItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemDiscountAmount"] != null)
                gridView.Columns["ARSaleForecastItemDiscountAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemProductDiscount"] != null)
                gridView.Columns["ARSaleForecastItemProductDiscount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemProductDesc"] != null)
                gridView.Columns["ARSaleForecastItemProductDesc"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemTaxAmount"] != null)
                gridView.Columns["ARSaleForecastItemTaxAmount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemProductTaxPercent"] != null)
                gridView.Columns["ARSaleForecastItemProductTaxPercent"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemDeliveryDate"] != null)
                gridView.Columns["ARSaleForecastItemDeliveryDate"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemDeliveryTime"] != null)
                gridView.Columns["ARSaleForecastItemDeliveryTime"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemProductDesc"] != null)
                gridView.Columns["ARSaleForecastItemProductDesc"].OptionsColumn.AllowEdit = false;

            if (gridView.Columns["FK_ICStockID"] != null)
            {
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleForecastItemPONo"] != null)
                gridView.Columns["ARSaleForecastItemPONo"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ARSaleForecastItemProductUnitPrice2"] != null)
                gridView.Columns["ARSaleForecastItemProductUnitPrice2"].OptionsColumn.AllowEdit = true;
            GridColumn column = gridView.Columns["ARSaleForecastItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(GridView_CustomDrawCell);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ARProposalsController objProposalsController = new ARProposalsController();
            if (e.Column.FieldName == "ARSaleForecastItemStatus" && e.Value != null)
            {
                e.DisplayText = BOSApp.GetDisplayTextFromConfigValue("SaleForecastItemStatus", e.Value.ToString());
            }

            if (e.Column.FieldName == "FK_ARProposalID")
            {
                if (e.Value != null && int.Parse(e.Value.ToString()) > 0)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ARProposals", "ARProposalID", int.Parse(e.Value.ToString()), "ARProposalNo");
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            SaleForecastEntities entity = (SaleForecastEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleForecastsInfo mainObject = (ARSaleForecastsInfo)entity.MainObject;
            GridView gridView = (GridView)sender;

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> lstSaleOrderItems = new List<ARSaleOrderItemsInfo>();

            if (entity.ARSaleForecastItemsList.CurrentIndex >= 0)
            {
                ARSaleForecastItemsInfo item = entity.ARSaleForecastItemsList[entity.ARSaleForecastItemsList.CurrentIndex];
                //entity.ModuleObjects[TableName.ARSaleForecastItemsTableName] = (ARSaleForecastItemsInfo)item.Clone();
                //(entity.Module as SaleForecastModule).ChangeItemFromSaleForecastItemsList();

                if (e.Column.FieldName == "ARSaleForecastItemProductQty")
                {
                    //Check IsValid SOQty
                    if (item.ARSaleForecastItemID > 0)
                    {
                        lstSaleOrderItems = objSaleOrderItemsController.GetListFromDataSet(objSaleOrderItemsController.GetAllDataByForeignColumn("FK_ARSaleForecastItemID", item.ARSaleForecastItemID)) as List<ARSaleOrderItemsInfo>;
                        if (lstSaleOrderItems != null && lstSaleOrderItems.Count > 0)
                        {
                            if (item.ARSaleForecastItemProductQty < lstSaleOrderItems.Sum(o => o.ARSaleOrderItemProductQty))
                            {
                                MessageBox.Show(string.Format("Số lượng chỉnh sửa không được nhỏ hơn SL đã làm ĐBH: {0}!", lstSaleOrderItems.Sum(o => o.ARSaleOrderItemProductQty)), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                item.ARSaleForecastItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            }
                        }
                    }
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                    ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                    item.ARSaleForecastItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo,
                                                                                item.ARSaleForecastItemProductUnitPrice,
                                                                                item.ARSaleForecastItemProductQty,
                                                                                item.FK_ICMeasureUnitID,
                                                                                objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                mainObject.ARSaleForecastDate,
                                                                                mainObject.FK_GECurrencyID);

                    item.ARSaleForecastItemProductUnitPrice2 = mainObject.ARSaleForecastExchangeRate2 > 0 ? item.ARSaleForecastItemProductUnitPrice * mainObject.ARSaleForecastExchangeRate / mainObject.ARSaleForecastExchangeRate2 : 0;
                    entity.SetProductPriceByProductUnitPrice(item);
                    //((SaleForecastModule)Screen.Module).UpdatePriceForSaleType(item);
                    ((SaleForecastModule)Screen.Module).ChangeComponentItemQty();
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(mainObject.FK_ARCustomerID);
                    ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                    item.ARSaleForecastItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo,
                                                                                item.ARSaleForecastItemProductUnitPrice,
                                                                                item.ARSaleForecastItemProductQty,
                                                                                item.FK_ICMeasureUnitID,
                                                                                objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0,
                                                                                mainObject.ARSaleForecastDate,
                                                                                mainObject.FK_GECurrencyID);
                    item.ARSaleForecastItemProductUnitPrice2 = mainObject.ARSaleForecastExchangeRate2 > 0 ? item.ARSaleForecastItemProductUnitPrice * mainObject.ARSaleForecastExchangeRate / mainObject.ARSaleForecastExchangeRate2 : 0;
                    entity.SetProductPriceByProductUnitPrice(item);
                    //((SaleForecastModule)Screen.Module).UpdatePriceForSaleType(item);
                }    
                else if (e.Column.FieldName == "ARSaleForecastItemProductDiscount")
                {
                    ((SaleForecastModule)Screen.Module).ChangeDiscountPercent(item);
                }
                else if (e.Column.FieldName == "ARSaleForecastItemProductUnitPrice2")
                {
                    if (mainObject.ARSaleForecastSaleType == SaleType.National.ToString())
                    {
                        entity.RoundByCurrency(item);
                        item.ARSaleForecastItemProductUnitPrice = item.ARSaleForecastItemProductUnitPrice2 * mainObject.ARSaleForecastExchangeRate2 / mainObject.ARSaleForecastExchangeRate;
                        item.ARSaleForecastItemTotalAmount2 = item.ARSaleForecastItemProductUnitPrice2 * item.ARSaleForecastItemProductQty;
                        entity.SetProductPriceByProductUnitPrice(item);
                        entity.UpdateTotalAmount();
                        entity.ARSaleForecastItemsList.GridControl.RefreshDataSource();
                    }
                    else
                    {
                        if (MessageBox.Show(SaleForecastLocalizedResources.ChangeItemProductUnitPrice2,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (mainObject.ARSaleForecastExchangeRate > 0)
                            {
                                entity.RoundByCurrency(item);
                                item.ARSaleForecastItemProductUnitPrice = item.ARSaleForecastItemProductUnitPrice2 * mainObject.ARSaleForecastExchangeRate2 / mainObject.ARSaleForecastExchangeRate;
                                item.ARSaleForecastItemTotalAmount2 = item.ARSaleForecastItemProductUnitPrice2 * item.ARSaleForecastItemProductQty;
                                entity.UpdateTotalAmount();
                                entity.ARSaleForecastItemsList.GridControl.RefreshDataSource();
                            }
                        }
                        else
                        {
                            item.ARSaleForecastItemProductUnitPrice2 = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                }
                else if (e.Column.FieldName == "ARSaleForecastItemProductUnitPrice")
                {
                    if (mainObject.ARSaleForecastSaleType == SaleType.International.ToString())
                    {
                        ((SaleForecastModule)Screen.Module).UpdatePriceForSaleType(item);
                    }
                    else
                    {
                        if (MessageBox.Show(SaleForecastLocalizedResources.ChangeItemProductUnitPrice,
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (mainObject.ARSaleForecastExchangeRate2 > 0)
                            {
                                entity.RoundByCurrency(item);
                                item.ARSaleForecastItemProductUnitPrice2 = item.ARSaleForecastItemProductUnitPrice * mainObject.ARSaleForecastExchangeRate / mainObject.ARSaleForecastExchangeRate2;
                                entity.UpdateTotalAmount();
                                entity.ARSaleForecastItemsList.GridControl.RefreshDataSource();
                            }
                        }
                        else
                        {
                            item.ARSaleForecastItemProductUnitPrice = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_ICStockID" || e.Column.FieldName == "ARSaleForecastItemProductSerialNo")
                {
                    ((SaleForecastModule)Screen.Module).ChangeItemComponentStock(item);
                }
                (entity.Module as SaleForecastModule).ChangeItemFromSaleForecastItemsList(item);
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleForecastModule)Screen.Module).DeleteItemFromSaleForecastItemsList();
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            SaleForecastEntities entity = (SaleForecastEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ARSaleForecastItemsList.CurrentIndex >= 0)
            {
                ((SaleForecastModule)Screen.Module).InitProductPictureImage(entity.ARSaleForecastItemsList[entity.ARSaleForecastItemsList.CurrentIndex].FK_ICProductID);
            }
        }
        public void LoadGridViewBySourceSelling(string sourceSellingType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = new GridColumn();
            if (sourceSellingType == ADConfigValueUtility.cstSourceSellingPriceMethodPriceSheet)
            {
                column = gridView.Columns["ARSaleForecastItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                column = gridView.Columns["ARSaleForecastItemProductUnitPrice2"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            else
            {
                column = gridView.Columns["ARSaleForecastItemProductUnitPrice"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                column = gridView.Columns["ARSaleForecastItemProductUnitPrice2"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
        }
    }
}

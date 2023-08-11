using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AP.CancelPurchaseOrder.Localization;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseOrder
{
    public class APCancelPurchaseOrderItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CancelPurchaseOrderItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["APCancelPurchaseOrderItemProductQty"] != null)
                gridView.Columns["APCancelPurchaseOrderItemProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APCancelPurchaseOrderItemProductUnitPrice"] != null)
                gridView.Columns["APCancelPurchaseOrderItemProductUnitPrice"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["APCancelPurchaseOrderItemProductDiscount"] != null)
                gridView.Columns["APCancelPurchaseOrderItemProductDiscount"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APCancelPurchaseOrderItemDiscountAmount"] != null)
                gridView.Columns["APCancelPurchaseOrderItemDiscountAmount"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["APCancelPurchaseOrderItemProductTaxPercent"] != null)
                gridView.Columns["APCancelPurchaseOrderItemProductTaxPercent"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_ARSaleOrderID"] != null)
                gridView.Columns["FK_ARSaleOrderID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_ACCostCenterID"] != null)
                gridView.Columns["FK_ACCostCenterID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_PMProjectID"] != null)
                gridView.Columns["FK_PMProjectID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_MMBatchProductID"] != null)
                gridView.Columns["FK_MMBatchProductID"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["APCancelPurchaseOrderItemTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.CancelPurchaseOrderItemList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                entity.ModuleObjects[TableName.APCancelPurchaseOrderItemsTableName] = (APCancelPurchaseOrderItemsInfo)entity.CancelPurchaseOrderItemList[entity.CancelPurchaseOrderItemList.CurrentIndex];
                APCancelPurchaseOrderItemsInfo item = (APCancelPurchaseOrderItemsInfo)entity.CancelPurchaseOrderItemList[entity.CancelPurchaseOrderItemList.CurrentIndex];
                if (gridView.FocusedColumn.FieldName == "APCancelPurchaseOrderItemProductQty")
                {
                    if (!((CancelPurchaseOrderModule)Screen.Module).IsValidCanceledQty(item, decimal.Parse(e.Value.ToString())))
                    {
                        MessageBox.Show(string.Format(CancelPurchaseOrderLocalizedResources.CanceledQtyCannotBeGreaterThanOrderedQty), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        entity.CancelPurchaseOrderItemList[entity.CancelPurchaseOrderItemList.CurrentIndex].APCancelPurchaseOrderItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
                (entity.Module as CancelPurchaseOrderModule).ChangeItemFromCancelVoucherItemList();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CancelPurchaseOrderModule)Screen.Module).DeleteItemFromCancelVoucherItemList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                //ShowInventory();
            }
        }

        public void LoadGridViewForRoundWood(string productType)
        {
            GridView gridView = (GridView)MainView;
            CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            APCancelPurchaseOrdersInfo mainObject = (APCancelPurchaseOrdersInfo)entity.MainObject;
            APCancelPurchaseOrdersController objCancelPurchaseOrdersController = new APCancelPurchaseOrdersController();

            if (mainObject.APCancelPurchaseOrderID > 0)
                mainObject = (APCancelPurchaseOrdersInfo)objCancelPurchaseOrdersController.GetObjectByID(mainObject.APCancelPurchaseOrderID);

            GridColumn column = gridView.Columns["APCancelPurchaseOrderItemWoodQty"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemWoodQty")
            {
                column.OptionsColumn.AllowEdit = false;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString() || productType == "FreshLumber" || productType == "WoodMDFOutSourcing" || productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = 7;
                    column.Caption = "Khối lượng đặt mua";
                }
                else
                {
                    //column.Visible = false;
                    column.Caption = "Số lượng đặt mua";
                }
            }
            column = gridView.Columns["APCancelPurchaseOrderItemProductHeight"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemProductHeight")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 8;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APCancelPurchaseOrderItemProductWidth"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemProductWidth")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 9;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APCancelPurchaseOrderItemProductWidthMax"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemProductWidthMax")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 10;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APCancelPurchaseOrderItemProductLenght"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemProductLenght")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 11;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APCancelPurchaseOrderItemProductLenghtMax"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemProductLenghtMax")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 12;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APCancelPurchaseOrderItemProductPerimeter"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemProductPerimeter")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 10;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APCancelPurchaseOrderItemProductQty"];
            if (column != null && column.FieldName == "APCancelPurchaseOrderItemProductQty")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    if (productType == ProductType.Verneer.ToString())
                    {
                        column.Caption = PurchaseOrderLocalizedResources.VerneerM2;
                    }
                    else
                    {
                        column.Caption = "Khối lượng hủy(m3)";
                    }
                    column.Visible = true;
                    column.VisibleIndex = 5;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                }
                else
                {
                    column.Caption = "Số lượng hủy";
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Mã đơn hàng nội bộ";
            newColumn.FieldName = "MMBatchProductSOName";
            newColumn.Visible = true;
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);
        }
    }
}

using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class APPurchaseOrderItemOutSourcingsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PurchaseOrderItemOutSourcingList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["APPurchaseOrderItemOutSourcingProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemOutSourcingProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["APPurchaseOrderItemOutSourcingGroup"];
            if (column != null)
            {
                column.Group();
            }
            gridView.EndGrouping += GridView_EndGrouping;
            return gridView;
        }

        private void GridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            gridView.ExpandAllGroups();
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView == null)
                return;

            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            APPurchaseOrderItemOutSourcingsInfo item = (APPurchaseOrderItemOutSourcingsInfo)gridView.GetRow(e.RowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "APPurchaseOrderItemOutSourcingProductQty")
            {
                MMBatchProductProductionNormItemsController pniController = new MMBatchProductProductionNormItemsController();
                List<MMBatchProductProductionNormItemsInfo> checkList = pniController.GetRemainMaterialProductQtyByPniIDAndGroup(item.FK_MMBatchProductProductionNormItemID, item.APPurchaseOrderItemOutSourcingGroup, item.APPurchaseOrderItemOutSourcingID);
                MMBatchProductProductionNormItemsInfo checkItem = checkList.Where(o => o.FK_MMBatchProductID == item.FK_MMBatchProductID
                                                                                       && o.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                                                                                       && o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                                                       && o.FK_ICProductID == item.FK_ICProductID
                                                                                       && o.MMBatchProductProductionNormItemProductLength == item.APPurchaseOrderItemOutSourcingProductLength
                                                                                       && o.MMBatchProductProductionNormItemProductHeight == item.APPurchaseOrderItemOutSourcingProductHeight
                                                                                       && o.MMBatchProductProductionNormItemProductWidth == item.APPurchaseOrderItemOutSourcingProductWidth
                                                                                       ).FirstOrDefault();

                if (checkItem != null && item.APPurchaseOrderItemOutSourcingProductQty > checkItem.MMBatchProductProductionNormItemQuantity - checkItem.MMBatchProductProductionNormItemPurchaseQty)
                {
                    MessageBox.Show(string.Format("Nguyên liệu {0} có SL: {1}. SL ĐM: {2}. SL kế hoạch: {3}. SL còn lại {4}"
                                                   , item.APPurchaseOrderItemOutSourcingProductName
                                                   , item.APPurchaseOrderItemOutSourcingProductQty.ToString("n4")
                                                   , checkItem.MMBatchProductProductionNormItemQuantity.ToString("n4")
                                                   , checkItem.MMBatchProductProductionNormItemPurchaseQty.ToString("n4")
                                                   , (checkItem.MMBatchProductProductionNormItemQuantity - checkItem.MMBatchProductProductionNormItemPurchaseQty).ToString("n4"))
                                    , BaseLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                    try
                    {
                        item.APPurchaseOrderItemOutSourcingProductQty = Convert.ToDecimal(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                    catch (Exception) { }
                }
            }
            ((PurchaseOrderModule)Screen.Module).UpdatePurchaseOrderItemOutSourcing();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PurchaseOrderModule)Screen.Module).DeletePurchaseOrderItemOutSourcing();
            }
        }
    }
}

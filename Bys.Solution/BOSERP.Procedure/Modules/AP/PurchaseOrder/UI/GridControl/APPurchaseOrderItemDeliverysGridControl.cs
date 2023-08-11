using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class APPurchaseOrderItemDeliverysGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.APPurchaseOrderItemDeliveryList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn col = new GridColumn();
            col.Caption = "Tách dòng";
            RepositoryItemHyperLinkEdit item = new RepositoryItemHyperLinkEdit();
            item.NullText = "Tách dòng";
            item.Click += new EventHandler(item_Click);
            col.ColumnEdit = item;
            col.OptionsColumn.AllowEdit = true;
            col.Visible = true;
            col.VisibleIndex = 1;
            gridView.Columns.Insert(0, col);
        }

        void item_Click(object sender, EventArgs e)
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            int index = entity.APPurchaseOrderItemDeliveryList.CurrentIndex;
            if (index >= 0)
            {
                entity.APPurchaseOrderItemDeliveryList[index].APPurchaseOrderItemDeliveryProductQty = entity.APPurchaseOrderItemDeliveryList[index].APPurchaseOrderItemDeliveryProductQty / 2;
                APPurchaseOrderItemDeliverysInfo item = (APPurchaseOrderItemDeliverysInfo)entity.APPurchaseOrderItemDeliveryList[index].Clone();
                item.APPurchaseOrderItemDeliveryID = 0;
                entity.APPurchaseOrderItemDeliveryList.Insert(index + 1, item);
                entity.APPurchaseOrderItemDeliveryList.GridControl.RefreshDataSource();
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["APPurchaseOrderItemDeliveryProductQty"] != null)
                gridView.Columns["APPurchaseOrderItemDeliveryProductQty"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICMeasureUnitID"] != null)
                gridView.Columns["FK_ICMeasureUnitID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["APPurchaseOrderItemDeliveryDate"] != null)
                gridView.Columns["APPurchaseOrderItemDeliveryDate"].OptionsColumn.AllowEdit = true;

            gridView.KeyUp += new KeyEventHandler(gridView_KeyUp);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            return gridView;
        }

        void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                entity.APPurchaseOrderItemDeliveryList.RemoveSelectedRowObjectFromList();
            }
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.Value != null)
            {
                PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                APPurchaseOrderItemDeliverysInfo item = (APPurchaseOrderItemDeliverysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                APPurchaseOrderItemsInfo purchaseOrderItem = entity.PurchaseOrderItemList?.FirstOrDefault(p => p.APPurchaseOrderItemID == item.FK_APPurchaseOrderItemID);

                if (item == null || purchaseOrderItem == null)
                    return;

                if (gridView.FocusedColumn.FieldName == "APPurchaseOrderItemDeliveryProductQty")
                {
                    string value = e.Value.ToString().Trim();
                    if (new ICReceiptItemsController().IsReceiptedComplete(item.FK_APPurchaseOrderItemID, purchaseOrderItem.APPurchaseOrderItemProductQty))
                    {
                        e.ErrorText = PurchaseOrderLocalizedResources.ThisItemIsReceiptedCompletion;
                        e.Valid = false;
                    }
                }
            }
        }
    }
}

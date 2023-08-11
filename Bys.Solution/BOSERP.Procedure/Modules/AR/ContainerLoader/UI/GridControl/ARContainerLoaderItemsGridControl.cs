using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ContainerLoader
{
    public class ARContainerLoaderItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {

            ContainerLoaderEntities entity = (ContainerLoaderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ContainerLoaderItemList;
            this.DataSource = bds;
        }





        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ContainerLoaderEntities entity = (ContainerLoaderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARContainerLoadersInfo mainObject = (ARContainerLoadersInfo)entity.MainObject;
            if (entity.ContainerLoaderItemList.CurrentIndex >= 0)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ARContainerLoaderItemsInfo items = (ARContainerLoaderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);

                    if ((e.Column.FieldName == "ARContainerLoaderItemLength"
                        || e.Column.FieldName == "ARContainerLoaderItemWidth"
                        || e.Column.FieldName == "ARContainerLoaderItemHeight"
                        || e.Column.FieldName == "ARContainerLoaderItemNetWeight"
                        || e.Column.FieldName == "ARContainerLoaderItemGrossWeight") && items != null)
                    {
                        ((ContainerLoaderModule)Screen.Module).ChangeQtyFromContainerLoaderItemList(items);
                    }
                    if ((e.Column.FieldName == "ARContainerLoaderItemProductQty") && items != null)
                    {
                        if (((ContainerLoaderModule)Screen.Module).IsEditAfterCompleting)
                            if (!((ContainerLoaderModule)Screen.Module).CheckInvoiceQty(items, false)) return;

                        if (((ContainerLoaderModule)Screen.Module).CheckProductionPlanningItemQty(items) && ((ContainerLoaderModule)Screen.Module).CheckSaleOrderItemQty(items))
                            ((ContainerLoaderModule)Screen.Module).ChangeQtyFromContainerLoaderItemList(items);
                        else
                        {
                            entity.ContainerLoaderItemList[entity.ContainerLoaderItemList.CurrentIndex].ARContainerLoaderItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                        /*if (!((ContainerLoaderModule)Screen.Module).IsValidContainerQty(item, decimal.Parse(e.Value.ToString())))
                    {
                        MessageBox.Show(string.Format(ContainerLoaderLocalizedResources.ContainerLoaderQtyCannotBeGreaterThanSaleOrderQty), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        entity.ContainerLoaderItemList[entity.ContainerLoaderItemList.CurrentIndex].ARContainerLoaderItemProductQty = int.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }*/
                    }
                }
            }
            //(entity.Module as ContainerLoaderModule).ChangeItemFromCancelContainerLoaderItemList();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ARContainerLoaderItemsInfo item = (ARContainerLoaderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        if (((ContainerLoaderModule)Screen.Module).IsEditAfterCompleting)
                        {
                            if (!((ContainerLoaderModule)Screen.Module).CheckInvoiceQty(item, true)) return;
                        }
                    }
                    ((ContainerLoaderModule)Screen.Module).DeleteItemFromContainerLoaderItemList();
                }
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ARContainerLoaderItemProductQty"] != null)
            {
                gridView.Columns["ARContainerLoaderItemProductQty"].OptionsColumn.AllowEdit = true;
                SetFormat("ARContainerLoaderItemProductQty", "n2", gridView);
            }
            if (gridView.Columns["ARContainerLoaderItemLength"] != null)
            {
                gridView.Columns["ARContainerLoaderItemLength"].OptionsColumn.AllowEdit = true;
                SetFormat("ARContainerLoaderItemLength", "n", gridView);
            }
            if (gridView.Columns["ARContainerLoaderItemWidth"] != null)
            {
                gridView.Columns["ARContainerLoaderItemWidth"].OptionsColumn.AllowEdit = true;
                SetFormat("ARContainerLoaderItemWidth", "n", gridView);
            }
            if (gridView.Columns["ARContainerLoaderItemHeight"] != null)
            {
                gridView.Columns["ARContainerLoaderItemHeight"].OptionsColumn.AllowEdit = true;
                SetFormat("ARContainerLoaderItemHeight", "n", gridView);
            }
            if (gridView.Columns["ARContainerLoaderItemNetWeight"] != null)
            {
                gridView.Columns["ARContainerLoaderItemNetWeight"].OptionsColumn.AllowEdit = true;
                SetFormat("ARContainerLoaderItemNetWeight", "n2", gridView);
            }
            if (gridView.Columns["ARContainerLoaderItemGrossWeight"] != null)
            {
                gridView.Columns["ARContainerLoaderItemGrossWeight"].OptionsColumn.AllowEdit = true;
                SetFormat("ARContainerLoaderItemGrossWeight", "n2", gridView);
            }
            if (gridView.Columns["FK_ICStockID"] != null)
            {
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            }

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "ARContainerLoaderItemProductQty")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            ARContainerLoaderItemsInfo objARContainerLoaderItemsInfo = (ARContainerLoaderItemsInfo)gridView.GetRow(e.RowHandle);
                            if (objARContainerLoaderItemsInfo.IsError)
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
            }
        }
    }
}

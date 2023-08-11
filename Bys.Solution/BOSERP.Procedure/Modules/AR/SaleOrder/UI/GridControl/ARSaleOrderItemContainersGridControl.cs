using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderItemContainersGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleOrderItemContainerList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            if (gridView.Columns["FK_GEContainerID"] != null)
            {
                gridView.Columns["FK_GEContainerID"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemContainerProductQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemContainerProductQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemContainerComment"] != null)
            {
                gridView.Columns["ARSaleOrderItemContainerComment"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemContainersList();
            }
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_GEContainerID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    GEContainersController objContainersController = new GEContainersController();
                    GEContainersInfo objContainersInfo = (GEContainersInfo)objContainersController.GetObjectByID(matchCodeID);
                    if (objContainersInfo != null)
                        e.DisplayText = objContainersInfo.GEContainerName;
                }

            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)entity.MainObject;
            if (entity.ARSaleOrderPaymentTimesList.CurrentIndex >= 0)
            {
                if (e.Column.FieldName == "FK_GEContainerID")
                {
                    ((SaleOrderModule)Screen.Module).AllocationQtyCont();
                }
                entity.UpdateContQty();
            }
        }

    }
}

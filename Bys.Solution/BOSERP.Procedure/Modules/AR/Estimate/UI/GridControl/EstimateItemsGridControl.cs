using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.Estimate
{
    public class EstimateItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            EstimateEntities entity = (EstimateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EstimateItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["AREstimateItemProductQty"] != null)
            {
                gridView.Columns["AREstimateItemProductQty"].OptionsColumn.AllowEdit = true;
                SetFormat("AREstimateItemProductQty", "n2", gridView);
            }

            if (gridView.Columns["AREstimateItemProductUnitPrice"] != null)
            {
                gridView.Columns["AREstimateItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
                SetFormat("AREstimateItemProductUnitPrice", "n0", gridView);
            }

            if (gridView.Columns["AREstimateItemTotalAmount"] != null)
            {
                gridView.Columns["AREstimateItemTotalAmount"].OptionsColumn.AllowEdit = false;
                SetFormat("AREstimateItemTotalAmount", "n0", gridView);
            }

            if (gridView.Columns["AREstimateItemTotalCost"] != null)
            {
                gridView.Columns["AREstimateItemTotalCost"].OptionsColumn.AllowEdit = false;
                SetFormat("AREstimateItemTotalCost", "n0", gridView);
            }

            if (gridView.Columns["FK_APSupplierID"] != null)
            {
                gridView.Columns["FK_APSupplierID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_ICMeasureUnitID"] != null)
            {
                gridView.Columns["FK_ICMeasureUnitID"].OptionsColumn.AllowEdit = true;
            }

            return gridView;
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

            if (e.Column.FieldName == "AREstimateItemProductQty"
                || e.Column.FieldName == "AREstimateItemProductUnitPrice")
                ((EstimateModule)Screen.Module).ChangeEstimateItemQty();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            //if (e.KeyCode == Keys.Delete)
            //{
            //    ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
            //}
        }


        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "FK_ICProductEquipmentID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ICProductsController objProductsController = new ICProductsController();
            //        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(matchCodeID);
            //        if (objProductsInfo != null)
            //            e.DisplayText = objProductsInfo.ICProductDesc;
            //        else
            //            e.DisplayText = "";
            //    }
            //    else
            //        e.DisplayText = "";
            //}
            //if (e.Column.FieldName == "FK_ACAssetID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ACAssetsController objAssetsController = new ACAssetsController();
            //        ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(matchCodeID);
            //        if (objAssetsInfo != null)
            //            e.DisplayText = objAssetsInfo.ACAssetDesc;
            //        else
            //            e.DisplayText = "";
            //    }
            //    else
            //        e.DisplayText = "";
            //}
            //if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            //        ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
            //        if (objProductAttributesInfo != null)
            //            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
            //    }

            //}
        }
    }
}

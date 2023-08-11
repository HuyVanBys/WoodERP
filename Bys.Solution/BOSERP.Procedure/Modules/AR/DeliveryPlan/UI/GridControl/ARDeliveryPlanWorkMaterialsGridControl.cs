using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public class ARDeliveryPlanWorkMaterialsGridControl : ItemGridControl
    {
        public enum DeliveryPlanWorkColumn
        {
            ARDeliveryPlanWorkProductNo,
            ARDeliveryPlanWorkProductName,
            ARDeliveryPlanWorkProductDesc,
            ARDeliveryPlanWorkProductQty
        };

        public override void InitGridControlDataSource()
        {
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARDeliveryPlanWorkMaterialsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkAssetsProductNoCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductNo.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkAssetsProductNameCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductName.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkProductDescCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductDesc.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            new DeliveryPlanWorkColumn[]
            {
                DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductQty
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

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
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((DeliveryPlanModule)Screen.Module).DeleteItemFromDeliveryPlanWorkMaterialsList();
            }
        }
    }
}

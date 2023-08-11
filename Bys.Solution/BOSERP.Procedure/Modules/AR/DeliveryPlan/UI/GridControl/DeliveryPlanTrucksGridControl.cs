using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public class DeliveryPlanTrucksGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARDeliveryPlanTrucksInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        public enum DeliveryPlanTrucksColumnName
        {
            Selected,
            ARDeliveryPlanTruckNumber,
            ARDeliveryPlanTruckDriver,
            ARDeliveryPlanTruckGrossTon,
            ARDeliveryPlanTruckCapacity,
            ARDeliveryPlanTruckDeliveryPlanItem,
            FK_HREmployeeID,
            ARDeliveryPlanTruckSource,
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.TruckItemList;
            column.FieldName = DeliveryPlanTrucksColumnName.ARDeliveryPlanTruckDeliveryPlanItem.ToString();
            column.OptionsColumn.AllowEdit = true;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = DeliveryPlanTrucksColumnName.Selected.ToString();
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            new DeliveryPlanTrucksColumnName[]
            {
                DeliveryPlanTrucksColumnName.ARDeliveryPlanTruckNumber,
                DeliveryPlanTrucksColumnName.ARDeliveryPlanTruckDriver,
                DeliveryPlanTrucksColumnName.ARDeliveryPlanTruckGrossTon,
                DeliveryPlanTrucksColumnName.ARDeliveryPlanTruckCapacity,
                DeliveryPlanTrucksColumnName.FK_HREmployeeID,
                DeliveryPlanTrucksColumnName.ARDeliveryPlanTruckSource,
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

            //if (e.KeyCode == Keys.Delete)
            //{
            //    ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
            //}
        }
    }
}

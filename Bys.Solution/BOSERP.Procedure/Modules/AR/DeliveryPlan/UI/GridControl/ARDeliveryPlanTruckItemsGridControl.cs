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
    public class ARDeliveryPlanTruckItemsGridControl : BOSGridControl
    {
        public List<ARDeliveryPlanTruckItemsInfo> DeliveryPlanTruckItemsList { get; set; }

        public void InvalidateDataSource(List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = deliveryPlanTruckItems;
            DataSource = bds;
            RefreshDataSource();
            DeliveryPlanTruckItemsList = new List<ARDeliveryPlanTruckItemsInfo>();
            DeliveryPlanTruckItemsList = deliveryPlanTruckItems;
        }

        public enum DeliveryPlanTruckItemsColumnName
        {
            Selected,
            ARDeliveryPlanTruckItemDeliveryQty,
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            //GridColumn column = new GridColumn();
            //column.Caption = DeliveryPlanLocalizedResources.VMVehicleChooseDeliveryPlanItemCaption;
            //column.FieldName = DeliveryPlanTrucksColumnName.ARDeliveryPlanTruckDeliveryPlanItem.ToString();
            //column.OptionsColumn.AllowEdit = true;
            //RepositoryItemHyperLinkEdit rpItem = new RepositoryItemHyperLinkEdit();
            //rpItem.NullText = string.Empty;
            //rpItem.Click += new EventHandler(RpItem_Click);
            //column.ColumnEdit = rpItem;
            //gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = DeliveryPlanTruckItemsColumnName.Selected.ToString();
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            new DeliveryPlanTruckItemsColumnName[]
            {
                DeliveryPlanTruckItemsColumnName.ARDeliveryPlanTruckItemDeliveryQty,
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

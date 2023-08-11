using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.Vehicle
{
    public partial class VehicleCustomersGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            VehicleEntities entity = (VehicleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.VehicleEmployeeList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            //gridView.OptionsView.ShowFooter = true;
            //foreach (GridColumn column in gridView.Columns)
            //{
            //    column.OptionsColumn.AllowEdit = false;
            //    if (column.FieldName == "VMVehicleFuelLogQty")
            //    {
            //        column.SummaryItem.FieldName = column.FieldName;
            //        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //        column.SummaryItem.DisplayFormat = "{0:n2}";
            //    }
            //    else if (column.FieldName == "VMVehicleFuelLogTotalCost")
            //    {
            //        column.SummaryItem.FieldName = column.FieldName;
            //        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //        column.SummaryItem.DisplayFormat = "{0:n2}";
            //    }
            //    else if (column.FieldName == "VMVehicleFuelLogDistanceCovered")
            //    {
            //        column.SummaryItem.FieldName = column.FieldName;
            //        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //    }
            //    else if (column.FieldName == "VMVehicleFuelLogConsumption1")
            //    {
            //        column.SummaryItem.FieldName = column.FieldName;
            //        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;
            //        column.SummaryItem.DisplayFormat = "{0:n2}";

            //    }
            //    else if (column.FieldName == "VMVehicleFuelLogConsumption2")
            //    {
            //        column.SummaryItem.FieldName = column.FieldName;
            //        column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;
            //        column.SummaryItem.DisplayFormat = "{0:n2}";
            //    }
            //}
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((VehicleModule)Screen.Module).RemoveSelectedFromVehicleEmployeeList();
            }
            base.GridView_KeyUp(sender, e);
        }
    }
}

using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class MMQuantityAllocationPercentConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.QuantityAllocationPercentConfigsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
                if (item.FieldName == "MMQuantityAllocationPercentConfigDate")
                {
                    item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    item.DisplayFormat.FormatString = "MM/yyyy";
                }
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            return gridView;
        }


        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectQuantityAllocationPercentConfigList();
            }
        }

        public MMQuantityAllocationPercentConfigsInfo GetCurrentModel()
        {
            GridView gridView = (GridView)MainView;
            MMQuantityAllocationPercentConfigsInfo objQuantityAllocationPercentConfigsInfo = (MMQuantityAllocationPercentConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            return objQuantityAllocationPercentConfigsInfo;
        }
    }
}

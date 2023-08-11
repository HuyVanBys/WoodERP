using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class MMLabourProductivityTargetConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LabourProductivityTargetConfigsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
                if (item.FieldName == "MMLabourProductivityTargetConfigDate")
                {
                    item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    item.DisplayFormat.FormatString = "MM/yyyy";
                }
                if (item.FieldName == "MMLabourProductivityTargetConfigSoChe" ||
                    item.FieldName == "MMLabourProductivityTargetConfigDinhHinh" ||
                    item.FieldName == "MMLabourProductivityTargetConfigLapRap" ||
                    item.FieldName == "MMLabourProductivityTargetConfigSon" ||
                    item.FieldName == "MMLabourProductivityTargetConfigDongGoi")
                {
                    item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    item.DisplayFormat.FormatString = "{0:n}";
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
                ((ProductConstantModule)Screen.Module).RemoveSelectLabourProductivityTargetConfigList();
            }
        }

        public MMLabourProductivityTargetConfigsInfo GetCurrentModel()
        {
            GridView gridView = (GridView)MainView;
            MMLabourProductivityTargetConfigsInfo objLabourProductivityTargetConfigsInfo = (MMLabourProductivityTargetConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            return objLabourProductivityTargetConfigsInfo;
        }
    }
}

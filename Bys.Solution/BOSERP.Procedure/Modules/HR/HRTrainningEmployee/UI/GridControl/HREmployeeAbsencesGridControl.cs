using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;
namespace BOSERP.Modules.HRTrainningEmployee
{
    class HREmployeeAbsencesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRTrainningEmployeeEntities entity = (HRTrainningEmployeeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRTrainningEmployees1List;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = TrainningEmployeeLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TrainningEmployeeLocalizedResources.IsPresent;
            column.FieldName = "IsPresent";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }
    }
}

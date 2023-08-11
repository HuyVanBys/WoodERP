using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADTimesheetConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ADTimesheetConfigList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["ADTimesheetConfigYear"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit.DisplayFormat.FormatString = "yyyy";
                column.ColumnEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            }
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridView_CellValueChanging);
            return gridView;
        }

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName != "ADTimesheetConfigYear")
            {
                if (MessageBox.Show("Bạn có muốn áp dụng cho tất cả các tháng khác?",
                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ADTimesheetConfigsInfo obj = (ADTimesheetConfigsInfo)gridView.GetRow(e.RowHandle);
                    obj.ADTimesheetConfigJan = obj.ADTimesheetConfigFeb = obj.ADTimesheetConfigApr = obj.ADTimesheetConfigAug =
                        obj.ADTimesheetConfigDec = obj.ADTimesheetConfigJul = obj.ADTimesheetConfigJun = obj.ADTimesheetConfigMar =
                        obj.ADTimesheetConfigMay = obj.ADTimesheetConfigNov = obj.ADTimesheetConfigOct = obj.ADTimesheetConfigSep = int.Parse(e.Value.ToString());
                }
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedADTimesheetConfigs();
            }
        }
    }
}

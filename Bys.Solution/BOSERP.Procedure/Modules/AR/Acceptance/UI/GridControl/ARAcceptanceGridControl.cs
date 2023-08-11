using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Acceptance
{
    public class ARAcceptanceGridControl : BOSGridControl
    {
        public void InitGridControlDataSource(List<ARAcceptancesInfo> ARAcceptancesList)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = ARAcceptancesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }
    }
}

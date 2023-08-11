using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public class ARSaleContractsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleContractsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            //GridColumn column = new GridColumn();
            //column.Caption = BaseLocalizedResources.Select;
            //column.FieldName = "Selected";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Insert(0, column);
            //column.VisibleIndex = 0;
            //gridView.ExpandAllGroups();
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}

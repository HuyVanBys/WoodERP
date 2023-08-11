using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public class ACDepreciationAssetTransGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DepreciationAssetTranList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((ACDocumentTypeModule)Screen.Module).DeleteItemFromDocTypeEntryFunctionMappings();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ACDepreciationAssetTranAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            if (e.Column.FieldName == "ACDepreciationAssetTranAmount")
                ((GeneralAccountingModule)Screen.Module).ChangeDepreciationAssetTranAmount();
        }
    }
}

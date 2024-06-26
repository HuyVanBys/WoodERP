using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Collection
{
    public class ICCollectionItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            CollectionEntities entity = (CollectionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICCollectionItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICCollectionItemProductNo"] != null)
                gridView.Columns["ICCollectionItemProductNo"].Caption = CollectionLocalizedResources.ICCollectionItemProductNoCaption;
            if (gridView.Columns["ICCollectionItemProductName"] != null)
                gridView.Columns["ICCollectionItemProductName"].Caption = CollectionLocalizedResources.ICCollectionItemProductNameCaption;
            if (gridView.Columns["ICCollectionItemProductUnitPrice"] != null)
                gridView.Columns["ICCollectionItemProductUnitPrice"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICCollectionItemQty"] != null)
                gridView.Columns["ICCollectionItemQty"].OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CollectionModule)Screen.Module).DeleteItemCollectionItemsList();
            }
        }
    }
}

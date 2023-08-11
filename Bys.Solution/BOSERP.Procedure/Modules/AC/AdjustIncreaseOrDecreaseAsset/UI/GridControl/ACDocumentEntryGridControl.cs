using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.AdjustIncreaseOrDecreaseAsset.UI
{
    public partial class ACDocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdjustIncreaseOrDecreaseAssetEntities entity = (AdjustIncreaseOrDecreaseAssetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DocumentEntryList;
            this.DataSource = bds;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AdjustIncreaseOrDecreaseAssetEntities entity = (AdjustIncreaseOrDecreaseAssetEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.DocumentEntryList.CurrentIndex >= 0)
            {
                ACDocumentEntrysInfo item = entity.DocumentEntryList[entity.DocumentEntryList.CurrentIndex];

                if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        item = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        //((AdjustIncreaseOrDecreaseAssetModule)Screen.Module).UpdateAccountDebitDocumentEntrys(item);
                    }
                }
            }
        }
    }
}


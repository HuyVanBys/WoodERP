using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineUnit
{
    public partial class MMMachineItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineUnitEntities entity = (MachineUnitEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MachineUnitItemList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CellValueChanged += new CellValueChangedEventHandler(GridView_CellValueChanged);
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
                if (col.FieldName == "FK_MMMachineUnitID")
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((MachineUnitModule)Screen.Module).RemoveSelectMachineItem();
            }
        }
        void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            MachineUnitEntities entity = (MachineUnitEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACAssetsController objOperationsController = new ACAssetsController();

            MMMachineUnitItemsInfo item = (MMMachineUnitItemsInfo)gridView.GetFocusedRow();
            if (item != null && e.Column.FieldName == "FK_ACAssetID")
            {
                ACAssetsInfo objAssetsInfo = new ACAssetsInfo();
                int AssetID = 0;
                if (e.Value != null)
                    int.TryParse(e.Value.ToString(), out AssetID);
                if (((MachineUnitModule)Screen.Module).CheckExitAsesstInMachineUnit(item))
                {
                    DataRow row = BOSApp.GetObjectFromCatche("ACAssets", "ACAssetID", AssetID);
                    if (row != null) objAssetsInfo = (ACAssetsInfo)objOperationsController.GetObjectFromDataRow(row);
                    else objAssetsInfo = null;
                    if (objAssetsInfo != null)
                    {
                        item.MMMachineUnitItemName = objAssetsInfo.ACAssetName;
                    }
                }
                else
                {

                    item.FK_ACAssetID = gridView.ActiveEditor.OldEditValue != null ? int.Parse(gridView.ActiveEditor.OldEditValue.ToString()) : 0;
                }
            }
        }

    }
}

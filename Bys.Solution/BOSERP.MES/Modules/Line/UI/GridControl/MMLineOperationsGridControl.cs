using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.Line
{
    public partial class MMLineOperationGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            LineEntities entity = (LineEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LineOperationsList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((LineModule)Screen.Module).RemoveSelectRow();
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            LineEntities entity = (LineEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMLinesController objLinesController = new MMLinesController();
            foreach (MMLineOperationsInfo item in entity.LineOperationsList)
            {
                MMLinesInfo objLinesInfo = (MMLinesInfo)objLinesController.GetObjectByID(item.FK_MMLineID);
                if (objLinesInfo != null)
                {
                    item.FK_MMWorkShopID = objLinesInfo.FK_MMWorkShopID;
                }
            }
        }
    }
}

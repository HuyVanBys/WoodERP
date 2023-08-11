using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.OtherProduct
{
    public partial class ICProductOperationsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OtherProductEntities entity = (OtherProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductOperationList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CellValueChanged += new CellValueChangedEventHandler(GridView_CellValueChanged);
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((OtherProductModule)Screen.Module).RemoveSelectOperation();
            }
        }

        void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            OtherProductEntities entity = (OtherProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMOperationsController objOperationsController = new MMOperationsController();
            ICProductOperationsInfo item = (ICProductOperationsInfo)gridView.GetFocusedRow();
            if (item != null && e.Column.FieldName == "FK_MMOperationID")
            {
                MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                int OperationID = 0;
                if (e.Value != null)
                    int.TryParse(e.Value.ToString(), out OperationID);
                DataRow row = BOSApp.GetObjectFromCatche("MMOperations", "MMOperationID", OperationID);
                if (row != null) objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectFromDataRow(row);
                else objOperationsInfo = null;
                if (objOperationsInfo != null)
                {
                    item.ICProductOperationNo = objOperationsInfo.MMOperationNo;
                    item.ICProductOperationName = objOperationsInfo.MMOperationName;
                }
            }
        }
    }
}

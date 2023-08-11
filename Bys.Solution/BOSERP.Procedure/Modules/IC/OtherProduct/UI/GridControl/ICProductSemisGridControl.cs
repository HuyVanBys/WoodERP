using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.OtherProduct
{
    public partial class ICProductSemisGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OtherProductEntities entity = (OtherProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductSemiList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CellValueChanged += new CellValueChangedEventHandler(GridView_CellValueChanged);
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["FK_ICProductSemiID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["ICProductSemiDesc"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((OtherProductModule)Screen.Module).RemoveSelectSemi();
            }
        }

        void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            OtherProductEntities entity = (OtherProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            ICProductSemisInfo item = (ICProductSemisInfo)gridView.GetFocusedRow();
            if (item != null && e.Column.FieldName == "FK_ICProductSemiID")
            {
                ICProductsInfo objProductInfo = new ICProductsInfo();
                int Productid = 0;
                if (e.Value != null)
                    int.TryParse(e.Value.ToString(), out Productid);
                DataRow row = BOSApp.GetObjectFromCatche("ICProducts", "ICProductID", Productid);
                if (row != null) objProductInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(row);
                else objProductInfo = null;
                if (objProductInfo != null)
                {
                    item.ICProductSemiNo = objProductInfo.ICProductNo;
                    item.ICProductSemiName = objProductInfo.ICProductName;
                }
            }
        }
    }
}

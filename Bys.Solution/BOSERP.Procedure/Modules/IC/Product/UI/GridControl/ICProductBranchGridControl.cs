using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ICProductBranchGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductBranchList;
            this.DataSource = bds;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ICProductBranchsInfo item = (ICProductBranchsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "FK_BRBranchID")
                {
                    ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    List<ICProductBranchsInfo> exit = entity.ProductBranchList.Where(t => t.FK_BRBranchID == item.FK_BRBranchID).ToList();
                    if (exit != null && exit.Count > 1)
                    {
                        BOSApp.ShowMessage("Đã tồn tại chi nhánh này trong danh sách!");
                        item.FK_BRBranchID = 0;
                    }
                }
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductModule)Screen.Module).RemoveProductBranchList();
                }
            }
        }
    }
}

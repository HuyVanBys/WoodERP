using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculateDiscount
{
    public class ARDiscountProgramsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DiscountProgramsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView == null)
                return;

            ARDiscountProgramsInfo objDiscountProgramsInfo = (ARDiscountProgramsInfo)gridView.GetFocusedRow();
            if (objDiscountProgramsInfo == null)
                return;

            ((CalculateDiscountModule)Screen.Module).ShowCalculateDiscount(objDiscountProgramsInfo);
        }
    }
}

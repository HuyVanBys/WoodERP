using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.NormTemplate
{
    public class MMNormTemplateProductsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            NormTemplateEntities entity = (NormTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.NormTemplateProductList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsForViewInfo ICProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductID == int.Parse(e.Value.ToString())).FirstOrDefault();
                    if (ICProductsInfo != null)
                        e.DisplayText = ICProductsInfo.ICProductName;
                }
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((NormTemplateModule)Screen.Module).DeleteItemFromNormTemplateProductList();
            }
        }
    }
}

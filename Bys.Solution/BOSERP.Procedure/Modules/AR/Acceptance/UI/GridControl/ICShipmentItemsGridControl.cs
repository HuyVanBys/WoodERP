using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;

namespace BOSERP.Modules.Acceptance
{
    public class ICShipmentItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ICShipmentItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductsController objProductsController = new ICProductsController();
                    e.DisplayText = objProductsController.GetObjectNoByID(matchCodeID);
                }
                else
                    e.DisplayText = "";
            }
        }
    }
}

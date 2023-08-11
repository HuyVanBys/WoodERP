using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialReceipt
{
    public class IPShipmentItemsGridControl : BOSGridControl
    {
        public List<IPShipmentItemsInfo> ListImport { get; set; }
        public void InvalidateDataSource(List<IPShipmentItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            ListImport = dataSource;
            ListImport.ForEach(o =>
            {
                (this.Screen as guiChooseShipmentItems).ValidateShipmentItemImport(o);
            });
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            if (gridView.Columns["ICShipmentNo"] != null)
            {
                gridView.Columns["ICShipmentNo"].Group();
            }

            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == matchCodeID);
                    e.DisplayText = objProductsInfo != null ? objProductsInfo.ICProductNo : string.Empty;
                }
                else
                    e.DisplayText = string.Empty;
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)MainView;
            IPShipmentItemsInfo itemImport = (IPShipmentItemsInfo)gridView.GetRow(e.RowHandle);
            if (itemImport == null)
                return;

            //(this.Screen as guiImportProductGroups).ValidateProductGroupImport(itemImport);
            if (string.IsNullOrWhiteSpace(itemImport.MessageError))
            {
                e.Appearance.BackColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.Tomato;
            }
        }
    }
}

using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class IPImportProductsGridControl : BOSGridControl
    {
        private string ModuleName { get; set; }

        public void InvalidateDataSource(List<IPImportProductsInfo> dataSource, string moduleName)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            ModuleName = moduleName;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            foreach(GridColumn col in gridview.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }    
            return gridview;
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPImportProductsInfo itemImport = (IPImportProductsInfo)gridView.GetRow(e.RowHandle);
            if (itemImport == null)
                return;

            DateTime shipmentDate = BOSApp.GetCurrentServerDate();
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductNo.Trim().ToLower() == itemImport.ICProductNo.Trim().ToLower());
            if (objProductsInfo != null)
            {
                e.Appearance.BackColor = Color.OrangeRed;
            }
            else if (!string.IsNullOrWhiteSpace(itemImport.MessageError))
            {
                e.Appearance.BackColor = Color.Yellow;
            }
        }
    }
}

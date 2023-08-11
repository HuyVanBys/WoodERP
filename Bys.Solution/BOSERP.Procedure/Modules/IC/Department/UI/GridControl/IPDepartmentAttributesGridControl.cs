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

namespace BOSERP.Modules.Department
{
    public partial class IPDepartmentAttributesGridControl : BOSGridControl
    {
        public List<IPDepartmentAttributesInfo> ListImport { get; set; }

        public void InvalidateDataSource(List<IPDepartmentAttributesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            ListImport = dataSource;
            ListImport.ForEach(o =>
            {
                (this.Screen as guiImportProductGroups).ValidateDepartmentAttributeImport(o);
            });
            bds.DataSource = ListImport;
            DataSource = bds;
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            IPDepartmentAttributesInfo item = (IPDepartmentAttributesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item != null)
            {
                (this.Screen as guiImportProductGroups).ValidateDepartmentAttributeImport(item);
                RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                if (gridView != null && gridView.FocusedRowHandle >= 0)
                {
                    IPDepartmentAttributesInfo item = (IPDepartmentAttributesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ListImport.Remove(item);
                    RefreshDataSource();
                }
            }
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPDepartmentAttributesInfo itemImport = (IPDepartmentAttributesInfo)gridView.GetRow(e.RowHandle);
            if (itemImport == null)
                return;

            //(this.Screen as guiImportProductGroups).ValidateDepartmentAttributeImport(itemImport);
            if(string.IsNullOrWhiteSpace(itemImport.MessageError))
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

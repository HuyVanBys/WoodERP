﻿using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Supplier
{
    public partial class IPSuppliersGridControl : BOSGridControl
    {
        public List<IPSuppliersInfo> ListImport { get; set; }

        public void InvalidateDataSource(List<IPSuppliersInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            ListImport = dataSource;
            ListImport.ForEach(o =>
            {
                (this.Screen as guiImportSuppliers).ValidateSupplierImport(o);
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
            IPSuppliersInfo item = (IPSuppliersInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item != null)
            {
                (this.Screen as guiImportSuppliers).ValidateSupplierImport(item);
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
                    IPSuppliersInfo item = (IPSuppliersInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ListImport.Remove(item);
                    RefreshDataSource();
                }
            }
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPSuppliersInfo itemImport = (IPSuppliersInfo)gridView.GetRow(e.RowHandle);
            if (itemImport == null)
                return;

            //(this.Screen as guiImportSuppliers).ValidateSupplierImport(itemImport);
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

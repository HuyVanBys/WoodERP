using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using System.Data;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using Localization;
using BOSCommon;

namespace BOSERP.Modules.Report
{
    public partial class ARRP076ARInvoiceItemsGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.OptionsView.ShowFooter = true;
      
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView); 
            
            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARInvoiceItemProductNo;
            column.FieldName = "ARInvoiceItemProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}

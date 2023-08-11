using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormsSearchResultGridControl : BOSSearchResultsGridControl
    {

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.GroupFormat = "[#image]{1} {2}";
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
                if (column.FieldName == "MMProductionNormOriginNo")
                {
                    column.Group();
                    column.GroupIndex = 0;
                }
                
                //if (column.FieldName == "MMProductionNormType")
                //{
                //    column.Group();
                //    column.GroupIndex = 1;
                //}
              
            }
          
            return gridView;
        }
    }
}

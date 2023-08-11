using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AliasConfig
{
    public partial class CurrencysGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            AliasConfigEntities entity = (AliasConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CurrencyList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if(gridView.Columns[i].FieldName == "FK_STFieldFormatGroupID" || gridView.Columns[i].FieldName == "GECurrencyDecimalNumber")
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
                else gridView.Columns[i].OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }
       
    }
}

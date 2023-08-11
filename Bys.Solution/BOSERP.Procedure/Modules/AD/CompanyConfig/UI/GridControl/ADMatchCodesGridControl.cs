using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BOSLib;

namespace BOSERP.Modules.CompanyConfig
{
    public class ADMatchCodesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConfigEntities entity = (CompanyConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ADMatchCodesList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;

            return gridView;
        }

        protected override void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
            String strMatchCodeColumnName = (Screen.Controls[CompanyConfigModule.cstOptionalFieldsLookupEditOptionalFieldsControlName] as DevExpress.XtraEditors.LookUpEdit).EditValue.ToString();
            gridView.SetRowCellValue(e.RowHandle, "ADMatchCodeColumnName", strMatchCodeColumnName);
        }
    }
}

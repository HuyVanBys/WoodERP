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
    public partial class DepartmentFormatGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            AliasConfigEntities entity = (AliasConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DepartmentFormatList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if(gridView.Columns[i].FieldName == "FK_STFieldFormatGroupID" || gridView.Columns[i].FieldName == "ICDepartmentFormatDecimalNumber" || gridView.Columns[i].FieldName == "ICProductType")
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
                else gridView.Columns[i].OptionsColumn.AllowEdit = false;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            return gridView;
        }
       
    }
}

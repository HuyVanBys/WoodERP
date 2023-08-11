using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.SellStaff
{
    public partial class EmployeeOTFactorGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SellStaffEntities entity = (SellStaffEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OTFactorList;
            DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["HROTFactorType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREmployeeOTFactorFromTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemDateEdit rep = new RepositoryItemDateEdit();
                rep.Mask.EditMask = "HH:mm:ss";
                rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                rep.Mask.UseMaskAsDisplayFormat = true;
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["HREmployeeOTFactorToTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemDateEdit rep = new RepositoryItemDateEdit();
                rep.Mask.EditMask = "HH:mm:ss";
                rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                rep.Mask.UseMaskAsDisplayFormat = true;
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["HREmployeeOTFactorValue"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SellStaffModule)Screen.Module).RemoveSelectedOTFactor();
            }
        }
    }
}

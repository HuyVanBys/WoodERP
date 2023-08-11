using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.EmloyeePayRollFormula
{
    public class HRBreakTimesGridControl : BOSGridControl
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        public override void InitGridControlDataSource()
        {
            EmloyeePayRollFormulaEntities entity = (EmloyeePayRollFormulaEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRBreakTimeList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            // repositoryItemDateEdit
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.EditFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";

            GridColumn column = gridView.Columns["HRBreakTimeName"];
            if (column != null)

                column.OptionsColumn.AllowEdit = true;

            column = gridView.Columns["HRBreakTimeFromTime"];
            if (column != null)
            {

                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRBreakTimeToTime"];
            if (column != null)
            {

                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }
            column = gridView.Columns["HRBreakTimeMaxOutTime"];
            if (column != null)
            {

                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRBreakTimeMinRegisterOverTime"];
            if (column != null)
            {

                column.OptionsColumn.AllowEdit = true;
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        private void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {

                    ((EmloyeePayRollFormulaModule)Screen.Module).RemoveSelectedBreakTime();
                }
            }
        }


    }
}

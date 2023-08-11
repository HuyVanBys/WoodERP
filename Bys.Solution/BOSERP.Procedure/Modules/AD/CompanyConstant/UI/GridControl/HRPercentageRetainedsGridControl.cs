using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class HRPercentageRetainedsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRPercentageRetainedsList;
            this.DataSource = bds;

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.Columns.AddVisible("ADConfigText");
            //gridView.OptionsView.ShowColumnHeaders = false;
            //gridView.OptionsView.ShowGroupPanel = false;
            GridColumn column = gridView.Columns["HRPercentageRetainedType"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;

            column = gridView.Columns["HRPercentageRetainedRate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "n2";
            }

            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(GridView_KeyUp);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            return gridView;
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {

            e.ExceptionMode = ExceptionMode.DisplayError;

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedPercentageRetaineds();
            }
        }
    }
}

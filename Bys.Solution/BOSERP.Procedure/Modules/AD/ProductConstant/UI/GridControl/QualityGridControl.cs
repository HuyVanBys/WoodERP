using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class QualityGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.QualityList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã";
            column.FieldName = "ICProductAttributeNo";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chất lượng";
            column.FieldName = "ICProductAttributeValue";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            //gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            //  gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }
        //protected override GridView InitializeGridView()
        //{
        //    GridView gridView = new GridView();
        //    gridView.Columns.AddVisible("ADConfigText");
        //    gridView.OptionsView.ShowColumnHeaders = false;
        //    gridView.OptionsView.ShowGroupPanel = false;
        //    gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
        //    gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(GridView_KeyUp);
        //    gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
        //    gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
        //    return gridView;
        //}

        //protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        //{

        //    e.ExceptionMode = ExceptionMode.DisplayError;

        //}

        //protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        //{
        //    GridView gridView = (GridView)sender;
        //    string configText = Convert.ToString(gridView.GetFocusedRowCellValue("ADConfigText"));

        //    if (e.Value != null)
        //    {
        //        if (gridView.FocusedColumn.FieldName == "ADConfigText")
        //        {
        //            if (string.IsNullOrEmpty(e.Value.ToString()))
        //            {
        //                e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyProductTypeMessage.ToString();
        //                e.Valid = false;
        //            }
        //            else
        //            {
        //                if (!configText.Equals(e.Value.ToString().Trim()))
        //                {
        //                    string configValuesType = "Product";
        //                    ((CompanyConstantModule)Screen.Module).CheckConfigValues(e.Value.ToString().Trim(), e, configValuesType);

        //                }
        //            }
        //        }
        //    }
        //}

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedQuality();
            }
        }
    }
}

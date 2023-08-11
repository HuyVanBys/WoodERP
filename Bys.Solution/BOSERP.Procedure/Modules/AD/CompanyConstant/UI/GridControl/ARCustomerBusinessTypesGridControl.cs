using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using BOSComponent;
using Localization;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ARCustomerBusinessTypesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CustomerBusinessTypeList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedCustomerBusinessType();
            }
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            string customerBusinessTypeName = gridView.GetFocusedRowCellValue("ARCustomerBusinessTypeName").ToString();

            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ARCustomerBusinessTypeName")
                {
                    if (string.IsNullOrWhiteSpace(e.Value.ToString().Trim()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyCustomerBusinessMessage;
                        e.Valid = false;
                    }
                    else
                    {
                        if (!customerBusinessTypeName.Equals(e.Value.ToString().Trim()))
                        {
                            ((CompanyConstantModule)Screen.Module).CheckCustomerBusinessTypes(e.Value.ToString().Trim(), e);
                        }
                    }
                }
                else if (gridView.FocusedColumn.FieldName == "ARCustomerBusinessTypeAbbreviation")
                {
                    if (string.IsNullOrWhiteSpace(customerBusinessTypeName.Trim()))
                    {
                        e.ErrorText = "Bạn chưa nhập Tên loại hình";
                        e.Valid = false;
                    }
                }
            }
        }
    }
}

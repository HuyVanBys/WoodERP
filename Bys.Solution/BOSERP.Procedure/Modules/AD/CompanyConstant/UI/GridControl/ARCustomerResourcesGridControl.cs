using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ARCustomerResourcesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CustomerResourcesList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
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
                ((CompanyConstantModule)Screen.Module).RemoveSelectedCustomerResourcest();
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
            if (gridView.FocusedColumn.FieldName == "ARCustomerResourceNo")
            {
                if (e.Value != null)
                {
                    string customerResourceNo = gridView.GetFocusedRowCellValue("ARCustomerResourceNo").ToString();
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.CustomerResourceNoIsNotNullMessages;
                        e.Valid = false;
                    }
                    else
                    {
                        if (!customerResourceNo.Equals(e.Value.ToString().Trim()))
                        {
                            ((CompanyConstantModule)Screen.Module).CheckCustomerResourceNo(e.Value.ToString().Trim(), e);

                        }
                    }
                }
            }

            if (gridView.FocusedColumn.FieldName == "ARCustomerResourceName")
            {
                if (e.Value != null)
                {
                    string customerResourceName = gridView.GetFocusedRowCellValue("ARCustomerResourceName").ToString();
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.CustomerResourceNameIsNotNullMessages;
                        e.Valid = false;
                    }
                    else
                    {
                        if (!customerResourceName.Equals(e.Value.ToString().Trim()))
                        {
                            ((CompanyConstantModule)Screen.Module).CheckCustomerResourceName(e.Value.ToString().Trim(), e);
                        }
                    }
                }
            }
        }
    }
}

using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ARCustomerSaleOrderTypeConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CustomerSaleOrderTypeConfigsList;
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
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            GridColumn column = new GridColumn();
            column.Caption = "Loại khách hàng";
            column.FieldName = "ARCustomerType";
            RepositoryItemLookUpEdit repLookUpEdit = new RepositoryItemLookUpEdit();
            repLookUpEdit.DataSource = objConfigValuesController.GetADConfigValuesByKeyGroup(ConfigValueGroup.CustomerType.ToString());
            repLookUpEdit.ValueMember = "ADConfigKeyValue";
            repLookUpEdit.DisplayMember = "ADConfigText";
            repLookUpEdit.NullText = string.Empty;
            repLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại khách hàng"));
            repLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            column.ColumnEdit = repLookUpEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại đơn hàng";
            column.FieldName = "ARSaleOrderType";
            repLookUpEdit = new RepositoryItemLookUpEdit();
            repLookUpEdit.DataSource = objConfigValuesController.GetADConfigValuesByKeyGroup("SaleOrderType");
            repLookUpEdit.ValueMember = "ADConfigKeyValue";
            repLookUpEdit.DisplayMember = "ADConfigText";
            repLookUpEdit.NullText = string.Empty;
            repLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại đơn hàng"));
            repLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            column.ColumnEdit = repLookUpEdit;
            gridView.Columns.Add(column);
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedCustomerSaleOrderTypeConfig();
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

            if (gridView.FocusedColumn.FieldName == "ARCustomerType")
            {
                if (e.Value != null)
                {
                    string customerTypeName = gridView.GetFocusedRowCellValue("ARCustomerType").ToString();
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyCustomerTypeMessage;
                        e.Valid = false;
                    }
                    else
                    {
                        if (!customerTypeName.Equals(e.Value.ToString().Trim()))
                        {
                            string configValuesType = "Customer";
                            ((CompanyConstantModule)Screen.Module).CheckConfigValues(e.Value.ToString().Trim(), e, configValuesType);
                        }
                    }
                }
            }
        }
    }
}

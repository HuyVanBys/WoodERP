using BOSCommon.Constants;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class GESaleCostsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.GESaleCostList;
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

            GridColumn column1 = gridView.Columns["ICFeeConfigVAT"];
            if (column1 != null)
            {
                column1.DisplayFormat.FormatType = FormatType.Numeric;
                column1.DisplayFormat.FormatString = "{0:n3}";
            }

            column1 = gridView.Columns["FK_ACAccountID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", CommonLocalizedResources.ACAccountNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));
                DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ACAccountsTableName);
                    BOSApp.LookupTables[TableName.ACAccountsTableName] = ds;
                }
                repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryAccount_QueryPopUp);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }
            return gridView;
        }

        public void repositoryAccount_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.ACAccountsTableName);
                BOSApp.LookupTables[TableName.ACAccountsTableName] = ds;
            }
            lookUpEdit.Properties.DataSource = ds.Tables[0];
            lookUpEdit.Properties.DisplayMember = "ACAccountNo";
            lookUpEdit.Properties.ValueMember = "ACAccountID";
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedGESaleCost();
            }
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            string vATNo = gridView.GetFocusedRowCellValue("ICFeeConfigNo").ToString();

            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICFeeConfigName")
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyGESaleCostName;
                        e.Valid = false;
                    }
                }
                if (gridView.FocusedColumn.FieldName == "ICFeeConfigVAT")
                {
                    decimal percentValue = Convert.ToDecimal(e.Value);
                    if (percentValue < 0 || percentValue > 100)
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.LimitOfPercentValueMessage;
                        e.Valid = false;

                    }
                }
            }
        }
    }
}

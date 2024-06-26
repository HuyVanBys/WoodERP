using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ProductionCostInProgressClassifyTypeGridControl : BOSComponent.BOSGridControl
    {
        #region Constants
        public const string ADConfigTextColumnName = "ADConfigText";
        public const string ProductionCostInProgressClassifyTypeColumnName = "ProductionCostInProgressClassifyType";
        #endregion
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostInProgressClassifyTypeList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            //GridView gridView = new GridView();
            GridView gridView = (GridView)this.ViewCollection[0];
            gridView.Columns.AddVisible(ADConfigTextColumnName);
            gridView.OptionsView.ShowColumnHeaders = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(GridView_KeyUp);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(gridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            return gridView;
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected void gridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            string configText = Convert.ToString(gridView.GetFocusedRowCellValue(ADConfigTextColumnName));

            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == ADConfigTextColumnName)
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotEmptyInProgressCalTypeMessage;
                        e.Valid = false;
                    }
                    else
                    {
                        if (!configText.Equals(e.Value.ToString().Trim()))
                        {
                            string configValuesType = ProductionCostInProgressClassifyTypeColumnName;
                            ((CompanyConstantModule)Screen.Module).CheckConfigValues(e.Value.ToString().Trim(), e, configValuesType);
                        }
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveProductionCostInProgressClassifyTypeList();
            }
        }
    }
}

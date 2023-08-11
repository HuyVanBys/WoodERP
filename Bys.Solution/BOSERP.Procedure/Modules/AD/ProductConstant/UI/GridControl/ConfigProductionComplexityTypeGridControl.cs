using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;
using BOSLib;
using DevExpress.XtraGrid.Views.Base;

namespace BOSERP.Modules.ProductConstant
{
    public partial class ConfigProductionComplexityTypeGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ConfigProductionComplexityTypeList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.Columns.AddVisible("ADConfigText").Caption = "Độ phức tạp sản xuất";
            gridView.Columns.AddVisible("ADConfigKeyDesc").Caption = "Hệ số";
            gridView.OptionsView.ShowColumnHeaders = true;
            gridView.OptionsView.ShowGroupPanel = false;
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

        protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            string configText = Convert.ToString(gridView.GetFocusedRowCellValue("ADConfigText"));
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ADConfigText")
                {
                    string value = e.Value.ToString().Trim();
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = "Độ phức tạp không thể rỗng.";
                        e.Valid = false;
                    }
                    else
                    {
                        if (!value.Equals(configText))
                        {
                            string configValuesType = "ConfigProductionComplexityType";
                            ((ProductConstantModule)Screen.Module).CheckConfigValues(e.Value.ToString().Trim(), e, configValuesType);
                        }
                    }
                }
                else if (gridView.FocusedColumn.FieldName == "ADConfigKeyDesc")
                {
                    configText = e.Value.ToString().Trim();
                    configText.Replace(",", ".");
                    decimal factor = 0;
                    try
                    {
                        factor = Convert.ToDecimal(configText);
                    }
                    catch (Exception k)
                    {
                        e.ErrorText = "Vui lòng nhập đúng định dạng số thập phân cho Hệ số";
                        e.Valid = false;
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (!e.Handled && e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedConfigProductionComplexityType();
            }
            e.Handled = true;
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)MainView;
            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if(objConfigValuesInfo != null)
            {
                objConfigValuesInfo.ADConfigKeyDesc = objConfigValuesInfo.ADConfigKeyDesc.Replace(",", ".");
                this.RefreshDataSource();
            }
        }
    }
}

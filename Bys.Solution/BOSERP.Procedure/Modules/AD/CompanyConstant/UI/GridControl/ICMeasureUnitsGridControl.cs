using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICMeasureUnitsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICMeasureUnitsList;
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
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                int measureUnitID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ICMeasureUnitID").ToString());
                bool isExist = (new ICMeasureUnitsController()).CheckMeasureUnitExistInICTransaction(measureUnitID);
                if (isExist)
                {
                    MessageBox.Show(CompanyConstantLocalizedResources.NoChangeMeasureUnit,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ((CompanyConstantModule)Screen.Module).RemoveSelectedMeasureUnit();
                }
            }
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            string measureUnitName = gridView.GetFocusedRowCellValue("ICMeasureUnitName").ToString();
            int measureUnitID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ICMeasureUnitID").ToString());

            if (measureUnitID > 0 && gridView.FocusedColumn.FieldName != "ICMeasureUnitRoundNum" && gridView.FocusedColumn.FieldName != "ICMeasureUnitRoundNumInBatchProduct" && gridView.FocusedColumn.FieldName != "ICMeasureUnitDesc")
            {
                bool isExist = (new ICMeasureUnitsController()).CheckMeasureUnitExistInICTransaction(measureUnitID);
                if (isExist)
                {
                    e.ErrorText = CompanyConstantLocalizedResources.NoChangeMeasureUnit;
                    e.Valid = false;
                    return;
                }
            }

            if (gridView.FocusedColumn.FieldName == "ICMeasureUnitName")
            {
                if (e.Value != null)
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyMeasureUnitListMessage;
                        e.Valid = false;
                    }
                    else
                    {
                        if (!measureUnitName.Equals(e.Value.ToString().Trim()))
                        {
                            ((CompanyConstantModule)Screen.Module).CheckMeasureUnits(e.Value.ToString().Trim(), e);
                        }
                    }
                }
            }
            else if (gridView.FocusedColumn.FieldName == "ICMeasureUnitRoundNum" || gridView.FocusedColumn.FieldName == "ICMeasureUnitRoundNumInBatchProduct")
            {
                if (e.Value != null)
                {
                    int roundNum = 0;
                    try
                    {
                        roundNum = Convert.ToInt32(e.Value.ToString());
                    }
                    catch(Exception ex)
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.ErrorRoundNum;
                        e.Valid = false;
                    }
                    if (roundNum < 0)
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.ErrorRoundNum;
                        e.Valid = false;
                    }
                }
            }
        }
    }
}

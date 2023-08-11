using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Department
{
    public partial class ICDepartmentAttributeValuesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            DepartmentEntities entity = (DepartmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICDepartmentAttributeValuesList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            //Set all column is enable
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        /// <summary>
        /// Validate row data
        /// </summary>
        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ICDepartmentAttributeValueNo")
            {
                if (e.Value == null || String.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.ErrorText = ICDepartmentLocalizedResources.AttributeNumberRequiredMessage;
                    e.Valid = false;
                    return;
                }

                DepartmentEntities entity = (DepartmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                BOSList<ICDepartmentAttributeValuesInfo> lstAttribute = entity.lstICDeparmtneAttributeValues;
                foreach (ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo in lstAttribute)
                {
                    DevExpress.XtraGrid.Columns.GridColumn col = gridView.FocusedColumn;
                    if (lstAttribute.PosOf("ICDepartmentAttributeValueNo", e.Value) != -1 && col.FieldName == "ICDepartmentAttributeValueNo" && !gridView.FocusedValue.Equals(e.Value))
                    {
                        e.ErrorText = ICDepartmentLocalizedResources.AttributeNumberExistsMessage;
                        e.Valid = false;
                        return;
                    }
                }
            }
            else if (gridView.FocusedColumn.FieldName == "ICDepartmentAttributeValueValue")
            {
                if (e.Value == null || String.IsNullOrEmpty(e.Value.ToString()))
                {
                    e.ErrorText = ICDepartmentLocalizedResources.AttributeValueRequiredMessage;
                    e.Valid = false;
                    return;
                }
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            DepartmentEntities entity = (DepartmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            String number = gridView.RowCount.ToString();
            while (number.Length < 2)
                number = '0' + number;
            if (String.IsNullOrEmpty(gridView.GetRowCellValue(e.RowHandle, "ICDepartmentAttributeValueNo").ToString()))
                gridView.SetRowCellValue(e.RowHandle, "ICDepartmentAttributeValueNo", number);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((DepartmentModule)Screen.Module).DeleteAttributeValue();
            }
        }
    }
}

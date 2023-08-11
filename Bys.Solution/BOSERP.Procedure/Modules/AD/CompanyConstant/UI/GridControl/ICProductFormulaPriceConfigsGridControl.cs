using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICProductFormulaPriceConfigsGridControl : BOSGridControl
    {
        private enum ProductFormulaPriceConfigsColumnName
        {
            ICProductFormulaPriceConfigNo,
            ICProductFormulaPriceConfigName,
            ICProductFormulaPriceConfigDesc,
            ICProductFormulaPriceConfigType,
            ICProductFormulaPriceConfigHeightOperation,
            ICProductFormulaPriceConfigWidthOperation,
            ICProductFormulaPriceConfigLengthOperation,
            ICProductFormulaPriceConfigQtyOperation,
            ICProductFormulaPriceConfigUnitPriceOperation,
            ICProductFormulaPriceConfigComponentUnitPriceOperation,
        }

        private string[] RepositoryItemLookUpEditColumns = new string[]
            {
                ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigHeightOperation.ToString(),
                ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigWidthOperation.ToString(),
                ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigLengthOperation.ToString(),
                ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigQtyOperation.ToString(),
                ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigUnitPriceOperation.ToString(),
                ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigComponentUnitPriceOperation.ToString(),
            };

        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductFormulaPriceConfigsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            RepositoryItemLookUpEdit repositoryItemLookUpEdit;

            Enum.GetValues(typeof(ProductFormulaPriceConfigsColumnName))
                .Cast<ProductFormulaPriceConfigsColumnName>()
                .Select(o => gridView.Columns[o.ToString()])
                .Where(o => o != null)
                .ToList()
                .ForEach(o =>
                {
                    o.OptionsColumn.AllowEdit = true;
                    if (RepositoryItemLookUpEditColumns.Contains(o.FieldName))
                    {
                        repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                        repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                        repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                        repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                        repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                        repositoryItemLookUpEdit.NullText = string.Empty;
                        repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Công thức"));
                        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                        o.ColumnEdit = repositoryItemLookUpEdit;
                    }
                });

            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (RepositoryItemLookUpEditColumns.Contains(e.Column.FieldName))
            {
                if (e.Value == null)
                    return;
                ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString(), e.Value.ToString());
                if (objConfigValuesInfo != null)
                {
                    e.DisplayText = objConfigValuesInfo.ADConfigText;
                }
            }
        }

        private void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString());
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                ConfigValuesList.Add(objConfigValuesInfo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            if (ConfigValuesList != null)
            {
                lookUpEdit.Properties.DataSource = ConfigValuesList;
            }
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedProductFormulaPriceConfigs();
            }
        }

        protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            string productFormulaPriceConfigName = gridView.GetFocusedRowCellValue(ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigName.ToString()).ToString();

            if (gridView.FocusedColumn.FieldName == ProductFormulaPriceConfigsColumnName.ICProductFormulaPriceConfigName.ToString())
            {
                if (e.Value != null)
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyProductFormulaPriceConfigNameMessage;
                        e.Valid = false;
                    }
                    else
                    {
                        if (!productFormulaPriceConfigName.Equals(e.Value.ToString().Trim()))
                        {
                            ((CompanyConstantModule)Screen.Module).CheckProductFormulaPriceConfigs(e.Value.ToString().Trim(), e);
                        }
                    }
                }
            }
        }
    }
}

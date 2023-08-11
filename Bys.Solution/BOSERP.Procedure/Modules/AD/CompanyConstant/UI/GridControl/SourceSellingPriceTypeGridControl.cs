//using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
//using DevExpress.XtraGrid.Columns;
//using DevExpress.XtraGrid.Views.Base;
//using DevExpress.XtraGrid.Columns;
//using DevExpress.XtraGrid.Views.Base;
//using BOSLib;
//using DevExpress.XtraEditors;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class SourceSellingPriceTypeGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SourceSellingPriceTypeList;
            this.DataSource = bds;
        }

        //protected override GridView InitializeGridView()
        //{
        //    //GridView gridView = new GridView();
        //    GridView gridView = (GridView)this.ViewCollection[0];
        //    gridView.Columns.AddVisible("ADConfigText");
        //    gridView.OptionsView.ShowColumnHeaders = false;
        //    gridView.OptionsView.ShowGroupPanel = false;
        //    gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
        //    gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(GridView_KeyUp);
        //    gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
        //    gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);

        //    GridColumn column = new GridColumn();
        //    column = gridView.Columns["SourceSellingPriceType"];
        //    if (column != null)
        //    {
        //        ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
        //        column.OptionsColumn.AllowEdit = true;
        //        RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
        //        repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
        //        repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
        //        repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //        repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
        //        repositoryItemLookUpEdit.NullText = string.Empty;
        //        repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));
        //        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditCalculateType_QueryPopUp);
        //        column.ColumnEdit = repositoryItemLookUpEdit;
        //    }

        //    return gridView;
        //}

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = false;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = new GridColumn();

            column = gridView.Columns["SourceSellingPriceType"];
            if (column != null)
            {
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditCalculateType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "SourceSellingPriceType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(ConfigValueGroup.SourceSellingPriceType, e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                    else
                    {
                        e.DisplayText = "";
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }

        public void repositoryItemLookUpEditCalculateType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.SourceSellingPriceType);
            List<ADConfigValuesInfo> configValues = new List<ADConfigValuesInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ADConfigValuesInfo cv = new ADConfigValuesInfo();
                    cv = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(dr);
                    configValues.Add(cv);
                }
            }
            lookUpEdit.Properties.DataSource = configValues;

            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            //column.Caption = "Nguồn giá bán";
            column.FieldName = "SourceSellingPriceType";
            column.OptionsColumn.AllowEdit = true;
            //column.VisibleIndex = 2;
            gridView.Columns.Add(column);
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
                        e.ErrorText = "Nguồn giá bán không thể trống";
                        e.Valid = false;
                    }
                    else
                    {
                        if (!value.Equals(configText))
                        {
                            string configValuesType = "SourceSellingPriceType";
                            ((CompanyConstantModule)Screen.Module).CheckConfigValues(e.Value.ToString().Trim(), e, configValuesType);
                        }
                    }

                }
            }
        }



        //protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((CompanyConstantModule)Screen.Module).RemoveSelectedSourceSellingPriceType();
        //    }
        //}
    }
}

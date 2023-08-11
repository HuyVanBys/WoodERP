using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class ExchangeRateConfigGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ExchangeRateConfigList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "FK_ICProductAttributeID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                    //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                    //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    //repositoryItemLookUpEdit.NullText = string.Empty;
                    //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
                    //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại"));
                    //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                    //column.ColumnEdit = repositoryItemLookUpEdit;
                }

                if (column.FieldName == "FK_ICDepartmentID")
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }

                if (column.FieldName == "FK_ICProductGroupID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductGroupName";
                    repositoryItemLookUpEdit.ValueMember = "ICProductGroupID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", "Nhóm hàng"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditProductGroup_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }

                if (column.FieldName == "MMExchangeRateConfigLumberTypeCombo")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Loại phách"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryExchangeRateConfigLumberType_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "MMExchangeRateConfigThickOperationTypeCombo")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Phép tính"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryExchangeRateConfigThickOperationType_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "MMExchangeRateConfigBlockOperationTypeCombo")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Phép tính"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryExchangeRateConfigBlockOperationType_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "MMExchangeRateConfigWidthOperationTypeCombo")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Phép tính"));
                    List<ADConfigValuesInfo> datasource = GetOperationTypeDataSource();
                    repositoryItemLookUpEdit.DataSource = datasource;
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "MMExchangeRateConfigLengthOperationTypeCombo")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Phép tính"));
                    List<ADConfigValuesInfo> datasource = GetOperationTypeDataSource();
                    repositoryItemLookUpEdit.DataSource = datasource;
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }


        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            //if (e.Column.FieldName == "FK_ICProductAttributeID" || e.Column.FieldName == "FK_ICProductAttributeSpecialityID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            //        ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
            //        if (objProductAttributesInfo != null)
            //            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
            //        //else
            //        //    e.DisplayText = "";
            //    }
            //    //else
            //    //    e.DisplayText = "";
            //}
            if (e.Column.FieldName == "FK_ICProductGroupID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    int.TryParse(e.Value.ToString(), out value);
                    if (value > 0)
                    {
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductGroups", "ICProductGroupID", value, "ICProductGroupName");
                    }
                }
            }
            if (e.Column.FieldName == "MMExchangeRateConfigLumberTypeCombo")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ADConfigValueUtility.GetTextFromKey("ExchangeRateConfigLumberType", e.Value.ToString());
                }
            }
            if (e.Column.FieldName == "MMExchangeRateConfigThickOperationTypeCombo")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ADConfigValueUtility.GetTextFromKey("ExchangeRateConfigThickOperationType", e.Value.ToString());
                }
            }

            if (e.Column.FieldName == "MMExchangeRateConfigBlockOperationTypeCombo")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ADConfigValueUtility.GetTextFromKey("ExchangeRateConfigBlockOperationType", e.Value.ToString());
                }
            }
        }



        public void repositoryExchangeRateConfigLumberType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ExchangeRateConfigLumberType");
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
            ds.Dispose();
        }
        public void repositoryExchangeRateConfigThickOperationType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ExchangeRateConfigThickOperationType");
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
            ds.Dispose();
        }

        public void repositoryExchangeRateConfigBlockOperationType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ExchangeRateConfigBlockOperationType");
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
            ds.Dispose();
        }


        public void repositoryItemLookUpEditProductGroup_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            List<ICProductGroupsInfo> ProductGroupList = new List<ICProductGroupsInfo>();
            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
            objProductGroupsInfo.ICProductGroupID = 0;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo("01");
            if (objDepartmentsInfo == null)
                return;
            DataSet ds = objProductGroupsController.GetAllDataByForeignColumn("FK_ICDepartmentID", objDepartmentsInfo.ICDepartmentID);
            ProductGroupList = (List<ICProductGroupsInfo>)objProductGroupsController.GetListFromDataSet(ds);
            if (ProductGroupList != null)
            {
                ProductGroupList.Insert(0, objProductGroupsInfo);
                lookUpEdit.Properties.DataSource = ProductGroupList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductGroupName";
            lookUpEdit.Properties.ValueMember = "ICProductGroupID";
            ds.Dispose();
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ProductConstantEntities entity = (ProductConstantEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            MMExchangeRateConfigsInfo item = entity.ExchangeRateConfigList[entity.ExchangeRateConfigList.CurrentIndex];
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo("01");
            if (objDepartmentsInfo != null)
                item.FK_ICDepartmentID = objDepartmentsInfo.ICDepartmentID;
            entity.ModuleObjects[TableName.MMExchangeRateConfigsTableName] = item;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductConstantModule)Screen.Module).RemoveSelectExchangeRateConfig();
                }
            }
        }

        public void repositoryExchangeRateConfigWidthOperationType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ExchangeRateConfigWidthOperationType");
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

        public void repositoryExchangeRateConfigLengthOperationType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ExchangeRateConfigLengthOperationType");
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

        public List<ADConfigValuesInfo> GetOperationTypeDataSource()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ExchangeRateConfigLengthOperationType");
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    configValuesList.Add(objConfigValuesInfo);
                }
            }
            return configValuesList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BOSLib;

namespace BOSERP.Modules.CompanyConfig
{
    public class OptionalFieldsModulesLookupEdit : BOSComponent.BOSLookupEdit
    {
        protected override void InitObjectDataToLookupEdit()
        {
            AddModulesToLookupEdit();
        }

        public void AddModulesToLookupEdit()
        {
            DataTable tblModules = InitModulesTable();

            BOSDbUtil dbUtil = new BOSDbUtil();
            DataSet ds = dbUtil.GetTablesHaveMCode();
            foreach (DataRow rowTable in ds.Tables[0].Rows)
            {
                String strTableName = rowTable["TABLE_NAME"].ToString();
                String strModuleName = BOSUtil.GetModuleName(strTableName);
                STModulesController objSTModulesController = new STModulesController();
                if (objSTModulesController.IsExistObjectName(strModuleName))
                {
                    String strModuleDesc = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(strModuleName, BOSApp.CurrentLang);
                    if (!String.IsNullOrEmpty(strModuleDesc))
                        tblModules.Rows.Add(new object[2] { strTableName, strModuleDesc });
                }
            }

            this.Properties.DataSource = tblModules;
            this.Properties.DisplayMember = "ModuleDesc";
            this.Properties.ValueMember = "TableName";
        }

        public DataTable InitModulesTable()
        {
            DataTable tblModules = new DataTable();
            tblModules.TableName = "Modules";
            DataColumn colName = new DataColumn();
            colName.ColumnName = "TableName";
            colName.DataType = typeof(String);
            tblModules.Columns.Add(colName);

            DataColumn colDesc = new DataColumn();
            colDesc.ColumnName = "ModuleDesc";
            colDesc.DataType = typeof(String);
            tblModules.Columns.Add(colDesc);

            DataColumn[] primaryKeys = new DataColumn[1];
            primaryKeys[0] = colName;

            tblModules.PrimaryKey = primaryKeys;
            return tblModules;
        }

        protected override void  BOSLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            String strTableName = this.EditValue.ToString();
            OptionalFieldsOptionalFieldsLookupEdit fld_lkeOptionalFields = (OptionalFieldsOptionalFieldsLookupEdit)Screen.Module.Controls[CompanyConfigModule.cstOptionalFieldsLookupEditOptionalFieldsControlName];
            fld_lkeOptionalFields.AddMatchCodeColumnsToLookupEdit(strTableName);
        }
    }
}

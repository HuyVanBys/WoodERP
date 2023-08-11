using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BOSLib;

namespace BOSERP.Modules.CompanyConfig
{
    public class OptionalFieldsOptionalFieldsLookupEdit : BOSComponent.BOSLookupEdit
    {
        public void AddMatchCodeColumnsToLookupEdit(String strTableName)
        {
            DataTable tblMatchCodes = InitMatchCodeTable();
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataSet ds = dbUtil.GetMCodeColumnsFromTable(strTableName);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                String strColumnName = row["COLUMN_NAME"].ToString();
                String strColumnText = String.Empty;
                object objColumnText = ADConfigValueUtility.GetTextFromKey(strColumnName.Substring(2, strColumnName.Length - 7));
                if (objColumnText != null)
                    strColumnText = objColumnText.ToString();
                if (!String.IsNullOrEmpty(strColumnText))
                    tblMatchCodes.Rows.Add(new object[2] { strColumnName, strColumnText });
            }
            this.Properties.DataSource = tblMatchCodes;
            this.Properties.DisplayMember = "Text";
            this.Properties.ValueMember = "Name";
        }

        public DataTable InitMatchCodeTable()
        {
            DataTable tblMCode = new DataTable();
            tblMCode.TableName = "MatchCode";

            DataColumn colMCodeName = new DataColumn();
            colMCodeName.ColumnName = "Name";
            colMCodeName.DataType = typeof(string);
            tblMCode.Columns.Add(colMCodeName);

            DataColumn colMCodeText = new DataColumn();
            colMCodeText.ColumnName = "Text";
            colMCodeText.DataType = typeof(string);
            tblMCode.Columns.Add(colMCodeText);

            DataColumn[] primaryKeys = new DataColumn[1];
            primaryKeys[0] = colMCodeName;
            tblMCode.PrimaryKey = primaryKeys;

            return tblMCode;
        }

        protected override void BOSLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            CompanyConfigEntities entity = (CompanyConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            String strMCodeColumn = this.EditValue.ToString();
            ADMatchCodesController objADMatchCodesController = new ADMatchCodesController();
            DataSet ds = objADMatchCodesController.GetADMatchCodesByADMatchCodeColumnName(strMCodeColumn);
            entity.ADMatchCodesList.Invalidate(ds);
        }
    }
}

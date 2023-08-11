using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BOSLib;



namespace BOSERP.Modules.CompanyConfig
{
    public partial class guiConfigurationMatchCode : BOSERPScreen
    {
        private DataTable tblModules = new DataTable();
        private DataTable tblMatchCodes = new DataTable();
        public guiConfigurationMatchCode()
        {
            InitializeComponent();
            AddModulesToLookupEdit(fld_lkeModules);
        }

        #region Utilities function
        

        public void AddModulesToLookupEdit(DevExpress.XtraEditors.LookUpEdit lkeModules)
        {
            tblModules= InitModulesTable();

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
                    if(!String.IsNullOrEmpty(strModuleDesc))
                        tblModules.Rows.Add(new object[2] { strTableName, strModuleDesc });
                }
            }

            lkeModules.Properties.DataSource = tblModules;
            lkeModules.Properties.DisplayMember = "ModuleDesc";
            lkeModules.Properties.ValueMember = "TableName";
        }

        private DataTable InitModulesTable()
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

        public void AddMatchCodeColumnsToLookupEdit(DevExpress.XtraEditors.LookUpEdit lkeMatchCodes, String strTableName)
        {
            tblMatchCodes=InitMatchCodeTable();
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataSet ds = dbUtil.GetMCodeColumnsFromTable(strTableName);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                String strColumnName = row["COLUMN_NAME"].ToString();
                String strColumnText =String.Empty;
                object objColumnText= ADConfigValueUtility.GetTextFromKey(strColumnName.Substring(2,strColumnName.Length-7));
                if (objColumnText!=null)
                    strColumnText = objColumnText.ToString();
                if(!String.IsNullOrEmpty(strColumnText))
                    tblMatchCodes.Rows.Add(new object[2] { strColumnName, strColumnText });
            }
            lkeMatchCodes.Properties.DataSource = tblMatchCodes;
            lkeMatchCodes.Properties.DisplayMember = "Text";
            lkeMatchCodes.Properties.ValueMember = "Name";            
        }

        private DataTable InitMatchCodeTable()
        {
            DataTable tblMCode= new DataTable();
            tblMCode.TableName="MatchCode";

            DataColumn colMCodeName= new DataColumn();
            colMCodeName.ColumnName="Name";
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

        public void AddMCodeColumnsToComboBox(ComboBox cmbMCodes,String strTableName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataSet ds = dbUtil.GetMCodeColumnsFromTable(strTableName);
            if (ds.Tables.Count > 0)
            {
                cmbMCodes.DataSource = ds.Tables[0];
                cmbMCodes.ValueMember = "COLUMN_NAME";
                cmbMCodes.DisplayMember = "COLUMN_NAME";
            }
        }

        public void AddMCodeValueToGrid(DevExpress.XtraGrid.GridControl gridControl, String strMCodeColumn)
        {
            ADMatchCodesController objADMatchCodesController = new ADMatchCodesController();
            DataSet ds = objADMatchCodesController.GetADMatchCodesByADMatchCodeColumnName(strMCodeColumn);
            if (ds.Tables.Count > 0)
            {
                gridControl.DataSource = ds.Tables[0];
            }
        }

        #endregion     
     

        private void fld_dgvMCodeValue_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow row = fld_dgvMCodeValue.GetDataRow(e.RowHandle);
            ADMatchCodesController objADMatchCodesController = new ADMatchCodesController();
            ADMatchCodesInfo objADMatchCodesInfo = (ADMatchCodesInfo)objADMatchCodesController.GetObjectFromDataRow(row);
            
            if(objADMatchCodesController.IsExist(objADMatchCodesInfo.ADMatchCodeID))
            {
                objADMatchCodesController.UpdateObject(objADMatchCodesInfo);
            }
            else
            {
                objADMatchCodesController.CreateObject(objADMatchCodesInfo);
            }
        }

        private void fld_dgvMCodeValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ADMatchCodesController objADMatchCodesController = new ADMatchCodesController();
                DataRow row = fld_dgvMCodeValue.GetDataRow(fld_dgvMCodeValue.FocusedRowHandle);
                ADMatchCodesInfo objADMatchCodesInfo = (ADMatchCodesInfo)objADMatchCodesController.GetObjectFromDataRow(row);
                if (objADMatchCodesController.IsExist(objADMatchCodesInfo.ADMatchCodeID))
                {
                    objADMatchCodesController.DeleteObject(objADMatchCodesInfo.ADMatchCodeID);
                }
                AddMCodeValueToGrid(fld_dgcMCodeValue, fld_lkeTableMatchCodes.EditValue.ToString());
            }
        }

        private void fld_lkeModules_EditValueChanged(object sender, EventArgs e)
        {
            AddMatchCodeColumnsToLookupEdit(fld_lkeTableMatchCodes, fld_lkeModules.EditValue.ToString());
        }

        private void fld_lkeTableMatchCodes_EditValueChanged(object sender, EventArgs e)
        {
            AddMCodeValueToGrid(fld_dgcMCodeValue, fld_lkeTableMatchCodes.EditValue.ToString());
        }

        private void fld_dgvMCodeValue_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = fld_dgvMCodeValue.GetDataRow(e.RowHandle);
            row["ADMatchCodeID"] = new ADMatchCodesController().GetMaxID() + 1;
            row["ADMatchCodeColumnName"] = fld_lkeTableMatchCodes.EditValue.ToString();
        }
    }
}
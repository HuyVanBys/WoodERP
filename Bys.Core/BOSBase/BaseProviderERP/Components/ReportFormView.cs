using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Extensions;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class ReportFormView : BOSERPScreen
    {
        #region Private Properties
        private int CheckKey { get; set; }
        #endregion

        #region Variable
        protected int ContentStartYIndex;

        protected int ContentRowIndex;

        protected List<string> VisibleColumns;

        public DataSet DataSource { get; set; }
        public DataSet PrintDataSource { get; set; }

        public BOSReport.BaseReport report { get; set; }

        public string rptFile { get; set; }

        public object[] ArParam { get; set; }

        public int TemplateID { get; set; }

        List<string> listTableNameExcep = new List<string>() { "GECurrencies" };

        private Dictionary<string, DataTable> dicRptLookupTables = new Dictionary<string, DataTable>();

        public BOSList<ADTemplateParamsInfo> lstADTemplateParams = new BOSList<ADTemplateParamsInfo>();

        public BOSList<ADTemplateParamsInfo> lstADTemplateParamShow = new BOSList<ADTemplateParamsInfo>();

        public string TemplateName { get; set; }
        #endregion

        #region Properties

        public int SummaryRowIndex { get; set; }

        public List<BRBranchsInfo> BranchList { get; set; }

        private BOSGridControl GridControlResult;

        public string GridControlName { get; set; }

        public String DataSourceName { get; set; }

        #endregion

        public ReportFormView()
        {
            InitializeComponent();
            ContentStartYIndex = 1;
            base.Load += new EventHandler(ReportFormView_Load);
        }

        public void InitParam()
        {
            if (TemplateID == 0) return;
            ADTemplateParamsController objADTemplateParamsController = new ADTemplateParamsController();
            DataSet ds = objADTemplateParamsController.GetTemplateParam(TemplateID);

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ADTemplateParamsInfo objADTemplateParamsInfo = (ADTemplateParamsInfo)objADTemplateParamsController.GetObjectFromDataRow(dr);
                    string ADTemplateParamNo = objADTemplateParamsInfo.ADTemplateParamNo;
                    if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals(DataType.Date.ToString().ToLower())
                        || objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals(DataType.DateTime.ToString().ToLower()))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = DateTime.Now.Date.ToString("dd/MM/yyyy");
                    }
                    if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals(DataType.Number.ToString().ToLower()))
                    {
                        if (objADTemplateParamsInfo.ADTemplateParamNo.ToLower().Contains("year"))
                            objADTemplateParamsInfo.ADTemplateParamValue = DateTime.Now.Date.Year.ToString();
                        else if (ADTemplateParamNo.ToLower().Contains("month"))
                            objADTemplateParamsInfo.ADTemplateParamValue = DateTime.Now.Date.Month.ToString();
                    }
                    if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals(DataType.bit.ToString().ToLower()) ||
                        objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals(DataType.boolean.ToString().ToLower()))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = "False";
                    }
                    if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals(DataType.currentuser.ToString().ToLower()))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = BOSApp.CurrentUsersInfo.ADUserID.ToString();
                    }
                    if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals(DataType.currentbranch.ToString().ToLower()))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID.ToString();
                    }

                    if (ArParam != null && ArParam.Length > 0 && ArParam[objADTemplateParamsInfo.ADTemplateParamOrder] != null)
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = ArParam[objADTemplateParamsInfo.ADTemplateParamOrder].ToString();
                    }
                    lstADTemplateParams.Add(objADTemplateParamsInfo);
                }
                lstADTemplateParamShow.Invalidate(lstADTemplateParams.Where(p => p.ADTemplateParamIsDisplay == true).ToList());
                fld_dgcTemplateParamsGridControl.DataSource = lstADTemplateParamShow;
                fld_dgcTemplateParamsGridControl.DefaultView.RefreshData();

            }
            ParamGridView.CustomRowCellEdit += new CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "ADTemplateParamValue")
            {
                ADTemplateParamsInfo paramInfo = new ADTemplateParamsInfo();
                object value = ((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamValue.ToString());
                ADTemplateParamsInfo paramHandle = (ADTemplateParamsInfo)this.ParamGridView.GetRow(this.ParamGridView.FocusedRowHandle);
                paramInfo.ADTemplateParamDataType = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamDataType.ToString());
                //if (paramInfo.ADTemplateParamDataType.ToLower().Equals(DataType.bit.ToString().ToLower()) ||
                //    paramInfo.ADTemplateParamDataType.ToLower().Equals(DataType.boolean.ToString().ToLower()))
                //{
                //    RepositoryItemCheckEdit rep = (RepositoryItemCheckEdit)e.Column.ColumnEdit;
                //}
                paramInfo.ADTemplateParamValue = value != null ? value.ToString() : "";
                paramInfo.ADTemplateParamNo = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamNo.ToString());
                paramInfo.ADTemplateParamDataType = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamDataType.ToString());
                paramInfo.ADTemplateParamLookupEdit = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamLookupEdit.ToString());
                paramInfo.ADTemplateParamFilter = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamFilter.ToString());
                paramInfo.ADTemplateParamFieldRelation = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamFieldRelation.ToString());
                paramInfo.ADTemplateParamParentField = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamParentField.ToString());
                paramInfo.ADTemplateParamIsNotNull = (bool)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamIsNotNull.ToString());
                object temp = ((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamColumns.ToString());

                if (DBNull.Value.Equals(temp) == false)
                {
                    paramInfo.ADTemplateParamColumns = (String)((GridView)sender).GetRowCellValue(e.RowHandle, TemplateParamColumn.ADTemplateParamColumns.ToString());
                }   
                SetRepository(paramInfo, e);
            }
        }

        private void SetRepository(ADTemplateParamsInfo paramInfo, CustomRowCellEditEventArgs objCustomRow)
        {
            if (paramInfo.ADTemplateParamDataType.ToLower() == DataType.multiselect.ToString().ToLower())
            {
                BindingSource source = new BindingSource();
                DataTable dt = TryToInitLookupTable(paramInfo.ADTemplateParamLookupEdit, paramInfo.ADTemplateParamNo, paramInfo.ADTemplateParamFilter, paramInfo.ADTemplateParamColumns, paramInfo.ADTemplateParamParentField);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.NewRow();
                    foreach (DataColumn column in row.Table.Columns)
                    {
                        if (column.DataType == typeof(double) || column.DataType == typeof(float) || column.DataType == typeof(int) || column.DataType == typeof(decimal))
                            row[column.ColumnName] = 0;
                        else if (column.DataType == typeof(bool))
                            row[column.ColumnName] = false;
                        else if (column.DataType == typeof(DateTime))
                            row[column.ColumnName] = DateTime.MinValue;
                        else row[column.ColumnName] = string.Empty;
                    }
                    if ((string.Join(",", dt.Rows[0].ItemArray) == string.Join(",", row.ItemArray)))
                        dt.Rows.RemoveAt(0);
                    source.DataSource = dt;
                }
                RepositoryItemCheckedComboBoxEdit ccbe = new RepositoryItemCheckedComboBoxEdit();
                ccbe.DataSource = dt;
                ccbe.IncrementalSearch = true;
                ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                if (paramInfo.ADTemplateParamLookupEdit == TableName.ADConfigValuesTableName)
                {
                    ccbe.DisplayMember = "ADConfigText";
                    ccbe.ValueMember = "ADConfigKeyValue";
                }
                else
                {
                    string[] splCols = paramInfo.ADTemplateParamColumns.Split(',');
                    if (splCols.Length > 0)
                    {

                        ccbe.ValueMember = splCols[0];
                        if (splCols.Length > 1)
                            ccbe.DisplayMember = splCols[1];
                        else
                            ccbe.DisplayMember = splCols[0];
                    }
                    else
                    {
                        ccbe.DisplayMember = listTableNameExcep.Contains(paramInfo.ADTemplateParamLookupEdit) ? paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 3) + "yName"
                                                                                                                    : paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 1) + "Name";
                        ccbe.ValueMember = listTableNameExcep.Contains(paramInfo.ADTemplateParamLookupEdit) ? paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 3) + "yNo"
                                                                                                                            : paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 1) + "No";
                    }
                }

                ccbe.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);
                ccbe.CustomDisplayText += new CustomDisplayTextEventHandler(RepositoryItemCheckedComboBoxEdit_CustomDisplayText);
                objCustomRow.RepositoryItem = ccbe;
                return;
            }

            if (paramInfo.ADTemplateParamNo.EndsWith("Combo")
                || paramInfo.ADTemplateParamNo.EndsWith("Type")
                || paramInfo.ADTemplateParamNo.EndsWith("Status"))
            {
                String strConfigValueTable = String.Empty;
                if (paramInfo.ADTemplateParamNo.EndsWith("Combo"))
                    strConfigValueTable = paramInfo.ADTemplateParamNo.Substring(2, paramInfo.ADTemplateParamNo.Length - 7);
                else
                    strConfigValueTable = paramInfo.ADTemplateParamNo.Substring(2, paramInfo.ADTemplateParamNo.Length - 2);
                if (ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable] != null)
                {
                    RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
                    rep.DataSource = ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable];
                    rep.ValueMember = "Value";
                    rep.DisplayMember = "Text";
                    rep.NullText = String.Empty;
                    rep.TextEditStyle = TextEditStyles.Standard;
                    rep.SearchMode = SearchMode.AutoFilter;
                    rep.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);

                    LookUpColumnInfo repColumn = new LookUpColumnInfo();
                    repColumn.FieldName = "Text";
                    repColumn.Caption = string.Empty;
                    repColumn.Width = 100;
                    rep.Columns.Add(repColumn);
                    rep.PopupWidth = repColumn.Width;
                    objCustomRow.RepositoryItem = rep;
                    return;
                }
            }

            if (paramInfo.ADTemplateParamLookupEdit == string.Empty)
            {
                if (paramInfo.ADTemplateParamDataType.ToLower().Equals(DataType.Date.ToString().ToLower())
                    || paramInfo.ADTemplateParamDataType.ToLower().Equals(DataType.DateTime.ToString().ToLower()))
                {
                    objCustomRow.RepositoryItem = CreateRepositoryItemDate();
                }
                else if (paramInfo.ADTemplateParamDataType.ToLower().Contains(DataType.Number.ToString().ToLower()))
                {
                    if (paramInfo.ADTemplateParamNo.ToLower().Contains("month"))
                        objCustomRow.RepositoryItem = CreateRepositoryItemPeriod();
                    else if (paramInfo.ADTemplateParamNo.ToLower().Contains("quarter"))
                        objCustomRow.RepositoryItem = CreateRepositoryItemQuarter();
                    else if (paramInfo.ADTemplateParamNo.ToLower().Contains("year"))
                        objCustomRow.RepositoryItem = CreateRepositoryItemYear();
                    else
                        objCustomRow.RepositoryItem = new RepositoryItemSpinEdit();

                }
                else if (paramInfo.ADTemplateParamDataType.ToLower().Equals(DataType.bit.ToString().ToLower()) ||
                    paramInfo.ADTemplateParamDataType.ToLower().Equals(DataType.boolean.ToString().ToLower()))
                    objCustomRow.RepositoryItem = CreateRepositoryItemCheckEdit(paramInfo);
                else
                    objCustomRow.RepositoryItem = new RepositoryItemTextEdit();
                return;
            }

            if (paramInfo.ADTemplateParamLookupEdit.ToLower() == "acobjects")
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                List<ACObjectsInfo> dt = objObjectsController.GetAllObjects();
                if (dt != null)
                {
                    RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
                    rep.TextEditStyle = TextEditStyles.Standard;
                    rep.SearchMode = SearchMode.AutoFilter;
                    rep.NullText = String.Empty;
                    rep.DataSource = dt;
                    LookUpColumnInfo colLKE = new LookUpColumnInfo("ACObjectNo");
                    colLKE.Caption = "Mã đối tượng";
                    rep.Columns.Add(colLKE);
                    colLKE = new LookUpColumnInfo("ACObjectName");
                    colLKE.Caption = "Tên đối tượng";
                    rep.Columns.Add(colLKE);
                    rep.DisplayMember = "ACObjectName";
                    rep.ValueMember = "ACObjectAccessKey";
                    rep.BestFitMode = BestFitMode.BestFitResizePopup;
                    rep.BestFit();
                    rep.QueryPopUp += RepositoryItemLookupEdit_QueryPopup;
                    objCustomRow.RepositoryItem = rep;
                    return;
                }
            }
            else if (paramInfo.ADTemplateParamLookupEdit != string.Empty
                && !(paramInfo.ADTemplateParamNo.EndsWith("Combo")
                || paramInfo.ADTemplateParamNo.EndsWith("Type")
                || paramInfo.ADTemplateParamNo.EndsWith("Status"))
                && (paramInfo.ADTemplateParamDataType.ToLower() != DataType.multiselect.ToString().ToLower())
                )
            {
                DataTable dt = TryToInitLookupTable(paramInfo.ADTemplateParamLookupEdit, paramInfo.ADTemplateParamNo, paramInfo.ADTemplateParamFilter, paramInfo.ADTemplateParamColumns, paramInfo.ADTemplateParamParentField);
                if (dt != null)
                {
                    RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();

                    rep.TextEditStyle = TextEditStyles.Standard;
                    rep.SearchMode = SearchMode.AutoFilter;
                    rep.NullText = String.Empty;
                    rep.DataSource = dt;
                    string strKeyColumn = String.Empty;
                    if (listTableNameExcep.Contains(paramInfo.ADTemplateParamLookupEdit))
                        strKeyColumn = paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 3) + "yID";
                    else
                        strKeyColumn = paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 1) + "ID";

                    Boolean isExistCol = false;
                    String strNoCol = strKeyColumn.Substring(0, strKeyColumn.Length - 2) + "No";

                    if (!string.IsNullOrEmpty(paramInfo.ADTemplateParamColumns))
                    {
                        string[] strLKEColumns = paramInfo.ADTemplateParamColumns.Split(',');
                        foreach (string strCol in strLKEColumns)
                        {
                            AAColumnAliasInfo columnAliasInfo = BOSApp.LstColumnAlias.Where(o => o.AATableName == paramInfo.ADTemplateParamLookupEdit && o.AAColumnAliasName == strCol).FirstOrDefault();
                            LookUpColumnInfo colLKE = new LookUpColumnInfo(strCol);
                            colLKE.Caption = columnAliasInfo != null ? columnAliasInfo.AAColumnAliasCaption : strCol;
                            rep.Columns.Add(colLKE);
                            isExistCol = true;
                        }
                    }
                    else
                    {
                        LookUpColumnInfo colLKE = new LookUpColumnInfo(strNoCol);
                        colLKE.Caption = "Mã";
                        rep.Columns.Add(colLKE);
                        if (dt.Columns.Contains(strKeyColumn.Substring(0, strKeyColumn.Length - 2) + "Name"))
                        {
                            colLKE = new LookUpColumnInfo(strKeyColumn.Substring(0, strKeyColumn.Length - 2) + "Name");
                            colLKE.Caption = "Tên";
                            rep.Columns.Add(colLKE);
                        }
                    }

                    GELookupTablesInfo lookupTablesInfo = BOSApp.LookupTableList.Where(o => o.GELookupTableName == paramInfo.ADTemplateParamLookupEdit).FirstOrDefault();
                    rep.DisplayMember = lookupTablesInfo != null ? lookupTablesInfo.GELookupTableDisplayColumn : strNoCol;
                    rep.ValueMember = strKeyColumn;
                    rep.BestFitMode = BestFitMode.BestFitResizePopup;
                    rep.BestFit();
                    rep.QueryPopUp += RepositoryItemLookupEdit_QueryPopup;
                    rep.EditValueChanged += Rep_EditValueChanged;
                    objCustomRow.RepositoryItem = rep;
                }

            }
        }

        protected virtual void RepositoryItemCheckedComboBoxEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (e.Value == null) return;
            CheckedComboBoxEdit ccbe = sender as CheckedComboBoxEdit;
            string display = string.Empty;
            if (ccbe != null && (ccbe.Properties.DisplayMember.EndsWith("Combo")
                || ccbe.Properties.DisplayMember.EndsWith("Type")
                || ccbe.Properties.DisplayMember.EndsWith("Status")))
            {
                String strConfigValueTable = String.Empty;
                if (ccbe.Properties.DisplayMember.EndsWith("Combo"))
                    strConfigValueTable = ccbe.Properties.DisplayMember.Substring(2, ccbe.Properties.DisplayMember.Length - 7);
                else
                    strConfigValueTable = ccbe.Properties.DisplayMember.Substring(2, ccbe.Properties.DisplayMember.Length - 2);

                display = BOSApp.GetDisplayTextFromConfigValue(strConfigValueTable, e.Value.ToString());
            }
            if (!string.IsNullOrEmpty(display)) e.DisplayText = display;
        }

        protected virtual void RepositoryItemLookupEdit_QueryPopup(object sender, CancelEventArgs e)
        {
            string sADTemplateParamFilter = Convert.ToString(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, TemplateParamColumn.ADTemplateParamFilter.ToString()));
            string[] spliter = new string[] { "--" };
            string[] arsADTemplateParamFilter = sADTemplateParamFilter.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
            if (arsADTemplateParamFilter.Length >= 2)
            {
                sADTemplateParamFilter = arsADTemplateParamFilter[1];
                for (int i = 0; i < this.ParamGridView.RowCount; i++)
                {
                    DataRow dr = this.ParamGridView.GetDataRow(i);

                    string strParamNo = (String)this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamNo.ToString());
                    string strParamType = (String)this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamDataType.ToString());
                    string strParamValue = (String)this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamValue.ToString());

                    if (strParamType.Equals("Date"))
                        strParamValue = Convert.ToDateTime(strParamValue).Date.ToString("yyyyMMdd");
                    else if (strParamType.Equals("DateTime"))
                        strParamValue = Convert.ToDateTime(strParamValue).Date.ToString("yyyyMMdd HH:mm:ss");

                    sADTemplateParamFilter = sADTemplateParamFilter.Replace("@" + strParamNo, strParamValue);
                }
                try
                {
                    LookUpEdit lke = (LookUpEdit)sender;

                    if (lke.Properties is RepositoryItemLookUpEdit)
                        ((DataTable)((RepositoryItemLookUpEdit)lke.Properties).DataSource).DataSet.Tables[0].DefaultView.RowFilter = sADTemplateParamFilter;
                }
                catch (Exception)
                {
                }
            }
            string sParentField = Convert.ToString(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, TemplateParamColumn.ADTemplateParamParentField.ToString()));
            string sFieldRelation = Convert.ToString(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, TemplateParamColumn.ADTemplateParamFieldRelation.ToString()));
            if (!string.IsNullOrEmpty(sParentField) && !string.IsNullOrEmpty(sFieldRelation))
            {
                for (int i = 0; i < this.ParamGridView.RowCount; i++)
                {
                    DataRow dr = this.ParamGridView.GetDataRow(i);

                    string strParamNo = (String)this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamNo.ToString());
                    string strParamType = (String)this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamDataType.ToString());
                    string strParamValue = (String)this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamValue.ToString());
                    if (strParamNo.Trim().ToLower() == sParentField.Trim().ToLower() && !string.IsNullOrEmpty(strParamValue))
                    {
                        LookUpEdit lke = (LookUpEdit)sender;
                        if (lke.Properties is RepositoryItemLookUpEdit)
                        {
                            DataTable view = ((DataTable)((RepositoryItemLookUpEdit)lke.Properties).DataSource);
                            if (view.Columns[sFieldRelation] != null)
                            {
                                var data = view.Rows.Cast<DataRow>().Where(x => (x[sFieldRelation] != null ? x[sFieldRelation].ToString() == strParamValue : true) || view.Rows.IndexOf(x) == 0).AsEnumerable();
                                if (data != null && data.Any())
                                    ((RepositoryItemLookUpEdit)lke.Properties).DataSource = data.CopyToDataTable();
                            }
                        }
                    }
                }
            }
            return;
        }

        protected virtual void Rep_EditValueChanged(object sender, EventArgs e)
        {
            string strParamNo = Convert.ToString(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, TemplateParamColumn.ADTemplateParamNo.ToString()));
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke != null && (lke.EditValue == null || lke.EditValue.Equals(0)))
            {
                ResetDefualtValue(strParamNo);
                this.ParamGridView.RefreshData();
            }
        }

        public void ResetDefualtValue(string strParamNo)
        {
            for (int i = 0; i < this.ParamGridView.RowCount; i++)
            {
                DataRow dr = this.ParamGridView.GetDataRow(i);

                string sParentField = Convert.ToString(this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamParentField.ToString()));
                if (strParamNo.Trim().ToLower() == sParentField.Trim().ToLower())
                {
                    this.ParamGridView.SetRowCellValue(i, TemplateParamColumn.ADTemplateParamValue.ToString(), "0");
                    strParamNo = Convert.ToString(this.ParamGridView.GetRowCellValue(i, TemplateParamColumn.ADTemplateParamNo.ToString()));
                    ResetDefualtValue(strParamNo);
                }
            }
        }

        public DataTable TryToInitLookupTable(string psTableName, string psParaName, string psKey, string psCols, string parentField)
        {
            string psdicName = psTableName;
            if (psKey.Length > 0) psdicName = psdicName + "_" + psParaName;
            if (dicRptLookupTables.ContainsKey(psdicName) && dicRptLookupTables[psdicName] != null)
            {
                return dicRptLookupTables[psdicName];
            }
            DataTable dt = new DataTable();
            DataSet ds;
            string sPrefix = string.Empty;
            string strSQL = string.Empty;
            string sOrderBys = string.Empty;
            if (psTableName == TableName.ADConfigValuesTableName)
            {
                strSQL = " SELECT ADConfigKeyValue,ADConfigText FROM dbo.ADConfigValues";
            }
            string[] splCols = psCols.Split(',');
            bool isExit = true;
            if (splCols.Length > 0)
            {
                foreach (string col in splCols)
                {
                    if (!new BOSDbUtil().ColumnIsExist(psTableName, col))
                        isExit = false;
                }
            }
            if (psTableName == "ADCustomizeLookups")
            {
                strSQL = psKey;
            }
            else if (psTableName == "MMProductionNorms" && this.GridControlName == "RP_GetMaterialsAndIngredientsInBOM")
            {
                strSQL = "SELECT MMProductionNormID,MMProductionNormNo,MMProductionNormProductNo,MMProductionNormOldProductNo,ICProductName as MMProductionNormICProductName" +
                        " FROM dbo.MMProductionNorms" +
                        " OUTER APPLY (SELECT ICProductName FROM dbo.ICProducts WHERE AAStatus = 'Alive' AND ICProductID = MMProductionNorms.FK_ICProductID) AS p";
            }
            else if (isExit)
            {
                strSQL = "SELECT DISTINCT " + string.Join(", ", splCols);
                strSQL += " FROM " + psTableName + "";
            }
            else if (psTableName != TableName.ADConfigValuesTableName)
            {
                if (listTableNameExcep.Contains(psTableName)) sPrefix = psTableName.Substring(0, psTableName.Length - 3) + "y";
                else
                    sPrefix = psTableName.Substring(0, psTableName.Length - 1);
                strSQL = "SELECT DISTINCT CAST(" + sPrefix + "ID as varchar) as " + sPrefix + "ID,";

                if (new BOSDbUtil().ColumnIsExist(psTableName, sPrefix + "No"))
                {
                    if (!("," + psCols + ",").Contains("," + sPrefix + "No,"))
                        strSQL += "" + sPrefix + "No,";

                    sOrderBys += sPrefix + "No,";
                }
                if (new BOSDbUtil().ColumnIsExist(psTableName, psCols))
                {
                    strSQL += "" + psCols + ",";
                    sOrderBys += psCols + ",";
                }
                if (new BOSDbUtil().ColumnIsExist(psTableName, sPrefix + "Name"))
                {
                    if (!("," + psCols + ",").Contains("," + sPrefix + "Name,"))
                        strSQL += "" + sPrefix + "Name,";
                    sOrderBys += sPrefix + "Name,";
                }
                if (new BOSDbUtil().ColumnIsExist(psTableName, sPrefix + "Desc"))
                {
                    if (!("," + psCols + ",").Contains("," + sPrefix + "Desc,"))
                        strSQL += "" + sPrefix + "Desc,";
                    strSQL += "" + sPrefix + "Desc,";
                }
                if (new BOSDbUtil().ColumnIsExist(psTableName, "AASelected"))
                {
                    if (!("," + psCols + ",").Contains("," + sPrefix + "Desc,"))
                        strSQL += "" + sPrefix + "Desc,";
                    strSQL += "AASelected,";
                }
                strSQL = strSQL.Substring(0, strSQL.Length - 1);

                if (sOrderBys.Length > 0)
                    sOrderBys = sOrderBys.Substring(0, sOrderBys.Length - 1);

                strSQL += " FROM " + psTableName + "";
            }
            if (psTableName != "ADCustomizeLookups")
            {
                if (psKey.Length > 0)
                    psKey = " AND " + psKey;
                if (new BOSDbUtil().ColumnIsExist(psTableName, "AAStatus"))
                    psKey = "AAStatus IN ('Alive','Dummy')" + psKey;
                if (psKey.Length > 0)
                    strSQL += " WHERE " + psKey;

                if (sOrderBys.Length > 0)
                    strSQL += string.Format(@"ORDER BY {0}", sOrderBys);
            }
            IBusinessController MainCtrl = BusinessControllerFactory.GetBusinessController(psTableName + "Controller");
            if (BOSApp.LookupTables.Contains(psTableName) && psTableName != "ADCustomizeLookups"
                && psTableName != TableName.ADConfigValuesTableName || !string.IsNullOrEmpty(parentField))
            {
                if (BOSApp.LookupTables.Contains(psTableName))
                    ds = (DataSet)BOSApp.LookupTables[psTableName];
                else
                {
                    ds = BOSApp.GetLookupTableData(psTableName);
                    if (ds != null)
                    {
                        GELookupTablesController lookupTableController = new GELookupTablesController();
                        GELookupTablesInfo lookupTable = new GELookupTablesInfo();
                        if (BOSApp.LookupTableList != null && BOSApp.LookupTableList.Count > 0)
                            lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == psTableName).FirstOrDefault();
                        if (lookupTable == null || lookupTable.GELookupTableID == 0)
                            lookupTable = lookupTableController.GetObjectByTableName(psTableName);

                        if (!BOSApp.LookupTables.ContainsKey(psTableName) && !psTableName.IsNullOrWhiteSpace())
                            BOSApp.LookupTables.Add(psTableName, ds);
                        else
                        {
                            ((DataSet)BOSApp.LookupTables[psTableName]).Tables.Clear();
                            ((DataSet)BOSApp.LookupTables[psTableName]).Dispose();
                            ((DataSet)BOSApp.LookupTables[psTableName]).Tables.Add(ds.Tables[0].Copy());
                        }
                        if (!BOSApp.LookupTablesUpdatedDate.ContainsKey(psTableName))
                            BOSApp.LookupTablesUpdatedDate.Add(psTableName, BOSApp.GetCurrentServerDate());
                        if (!BOSApp.LookupTableObjects.ContainsKey(psTableName))
                            BOSApp.LookupTableObjects.Add(psTableName, lookupTable);
                    }
                }
            }
            else
                ds = MainCtrl.GetDataSet(strSQL);

            if (ds != null && ds.Tables.Count > 0)
                dt = ds.Tables[0];
            dicRptLookupTables[psdicName] = dt;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].NewRow();
                foreach (DataColumn column in row.Table.Columns)
                {
                    if (column.DataType == typeof(double) || column.DataType == typeof(float) || column.DataType == typeof(int) || column.DataType == typeof(decimal))
                        row[column.ColumnName] = 0;
                    else if (column.DataType == typeof(bool))
                        row[column.ColumnName] = false;
                    else if (column.DataType == typeof(DateTime))
                        row[column.ColumnName] = DateTime.MinValue;
                    else if (column.DataType == typeof(string))
                        row[column.ColumnName] = string.Empty;
                    else row[column.ColumnName] = null;
                }
                if (!(string.Join(",", dt.Rows[0].ItemArray) == string.Join(",", row.ItemArray)))
                    dt.Rows.InsertAt(row, 0);

            }
            return dt;
        }

        public RepositoryItemComboBox CreateRepositoryItemPeriod()
        {
            RepositoryItemComboBox rep = new RepositoryItemComboBox();
            rep.AutoHeight = false;
            rep.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            return rep;
        }

        public RepositoryItemComboBox CreateRepositoryItemQuarter()
        {
            RepositoryItemComboBox rep = new RepositoryItemComboBox();
            rep.AutoHeight = false;
            rep.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            return rep;
        }

        public RepositoryItemSpinEdit CreateRepositoryItemYear()
        {
            RepositoryItemSpinEdit rep = new RepositoryItemSpinEdit();
            rep.EditFormat.FormatString = "####";
            rep.EditMask = "####";
            return rep;
        }

        public RepositoryItemDateEdit CreateRepositoryItemDate()
        {
            RepositoryItemDateEdit rep = new RepositoryItemDateEdit();
            rep.EditMask = "d";
            rep.EditFormat.FormatString = "dd/MM/yyyy";
            rep.Leave += new EventHandler(repositoryItemDateEdit_Leave);
            rep.Enter += new EventHandler(repositoryItemDateEdit_Enter);
            rep.Click += new System.EventHandler(repositoryItemDateEdit_Click);
            rep.KeyUp += new System.Windows.Forms.KeyEventHandler(repositoryItemDateEdit_KeyUp);
            return rep;
        }

        void repositoryItemDateEdit_Leave(object sender, EventArgs e)
        {
            DateEdit dteSender = (DateEdit)sender;
            this.CheckKey = 0;
            this.ParamGridView.SetRowCellValue(this.ParamGridView.FocusedRowHandle, "ADTemplateParamValue", dteSender.DateTime.ToString("dd/MM/yyyy"));
        }

        private RepositoryItemCheckEdit CreateRepositoryItemCheckEdit(ADTemplateParamsInfo paramInfo)
        {
            RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
            //rep.ValueChecked = false;
            rep.AllowFocused = true;
            rep.CheckedChanged += new EventHandler(RepositoryItemCheckEdit_CheckedChanged);
            return rep;
        }

        private void RepositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit cbSender = (CheckEdit)sender;
            //cbSender.Checked = Convert.ToBoolean(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, TemplateParamColumn.ADTemplateParamValue.ToString()));
            ADTemplateParamsInfo paramHandle =  (ADTemplateParamsInfo)this.ParamGridView.GetRow(this.ParamGridView.FocusedRowHandle);
            if (paramHandle != null)
            {
                paramHandle.ADTemplateParamValue = cbSender.Checked.ToString();
                foreach (ADTemplateParamsInfo param in lstADTemplateParams)
                {
                    if (param.ADTemplateParamID == paramHandle.ADTemplateParamID)
                    {
                        param.ADTemplateParamValue = cbSender.Checked.ToString();
                    }
                }
                foreach (ADTemplateParamsInfo param in lstADTemplateParamShow)
                {
                    if (param.ADTemplateParamID == paramHandle.ADTemplateParamID)
                    {
                        param.ADTemplateParamValue = cbSender.Checked.ToString();
                    }
                }
                lstADTemplateParamShow.GridControl?.RefreshDataSource();
            }
        }

        void repositoryItemDateEdit_Enter(object sender, EventArgs e)
        {
            DateEdit dteSender = (DateEdit)sender;
            try
            {
                this.CheckKey = 0;
                dteSender.EditValue = Convert.ToDateTime(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, TemplateParamColumn.ADTemplateParamValue.ToString()));
            }
            catch
            {
            }
        }

        public void InitGridView()
        {
            string gridName = GridControlName;
            if (string.IsNullOrEmpty(gridName))
            {
                gridName = DataSourceName;
            }
            GridControlResult = BOSGridControl.Instance(gridName, this.Module.Name);
            GridControlResult.Name = "fld_dgc" + DataSourceName;
            GridControlResult.Screen = this;
            GridControlResult.BOSDataSource = DataSourceName;
            GridControlResult.Width = fld_pnlMainGroup.Width - 10;
            GridControlResult.Height = fld_pnlMainGroup.Height - 50;
            GridControlResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            GridControlResult.TabIndex = 0;
            GridControlResult.InitializeControl();

            //Init the grid view of the result grid control
            GridView gridView = (GridView)GridControlResult.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;//dòng autofilter để nhập trực tiếp
            GridColumn column = new GridColumn();
            List<AAColumnAliasInfo> AddColumnNames;
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet ds;
            if (!BOSApp.LookupTables.ContainsKey("AAColumnAlias"))
            {
                ds = objAAColumnAliasController.GetColumnPermissionByTableName(DataSourceName);
            }
            else
            {
                ds = BOSApp.LookupTables[DataSourceName] as DataSet;
            }
            AddColumnNames = (List<AAColumnAliasInfo>)objAAColumnAliasController.GetListFromDataSet(ds);
            int visibleIndex = 1;
            if (AddColumnNames != null && AddColumnNames.Count > 0)
            {
                foreach (AAColumnAliasInfo objColumnAliasInfo in AddColumnNames.Where(x => x.AAColumnAliasCaption != "").ToList())
                {
                    column = new GridColumn();
                    column.Caption = objColumnAliasInfo.AAColumnAliasCaption;
                    column.FieldName = objColumnAliasInfo.AAColumnAliasName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                    GridControlResult.InitColumnRepositoryFormat(column, DataSourceName, objColumnAliasInfo.AAColumnAliasName);
                }
                //BOSGridControl.InitColumnFormat(GridControlResult);
            }
            else if (DataSource != null && DataSource.Tables.Count > 0)
            {
                foreach (DataColumn col in DataSource.Tables[0].Columns)
                {
                    column = new GridColumn();
                    column.Caption = col.Caption;
                    column.FieldName = col.ColumnName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                }
            }
            gridView.DoubleClick += new EventHandler(gridView_DoubleClick);
            fld_pnlMainGroup.Controls.Add(GridControlResult);
        }

        void gridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item;
                string ColumnName = string.Empty, viewName = string.Empty;
                if (gridView.FocusedColumn != null)
                    ColumnName = gridView.FocusedColumn.FieldName;

                Type type = gridView.GetRow(gridView.FocusedRowHandle).GetType();
                ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByID(TemplateID);
                if (objADTemplatesInfo != null)
                {
                    viewName = objADTemplatesInfo.ADTemplateNo;
                }
                if (type.Name == "DataRowView")
                {
                    System.Data.DataRowView row = (System.Data.DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
                    XtraReportHelper.ShowRefByRow(lstADTemplateParamShow, row, (System.Windows.Forms.Form.ControlCollection)this.Controls, viewName != string.Empty ? viewName : this.Name, this.Module, ColumnName);
                }
                else
                {
                    item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        XtraReportHelper.ShowRef(lstADTemplateParamShow, item, (System.Windows.Forms.Form.ControlCollection)this.Controls, viewName != string.Empty ? viewName : this.Name, this.Module, ColumnName);
                    }
                }

            }
        }

        void ReportFormView_Load(object sender, EventArgs e)
        {
            ControlBox = true;
            MaximizeBox = true;
            MinimizeBox = true;
            if (TemplateName != string.Empty)
                this.Text = TemplateName;
            //Init the result grid control
            if (DataSource != null && DataSource.Tables.Count > 0 && DataSource.Tables[0].Rows.Count > 0)
                GridControlResult.DataSource = DataSource.Tables[0];
            else
            {
                ViewReport(true);
            }
            GridControlResult?.RefreshDataSource();



        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateBranchLookupControlDatasourceByUserPermission(this.Controls);

        }

        protected void UpdateBranchLookupControlDatasourceByUserPermission(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is IBOSControl && ctrl.Name.Contains("BranchID"))
                {
                    List<BRBranchsInfo> branches = new List<BRBranchsInfo>();
                    if (BranchList != null && BranchList.Count != 0)
                    {
                        branches.Add(new BRBranchsInfo());
                        branches.AddRange(BranchList);
                    }
                    ((BOSLookupEdit)ctrl).Properties.DataSource = branches;
                    return;
                }
                UpdateBranchLookupControlDatasourceByUserPermission(ctrl.Controls);
            }
        }

        public void GetBranchListByUserPermission()
        {
            BRBranchsController branchController = new BRBranchsController();
            BranchList = branchController.GetAllBranchesByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                            this.Name, ADDataViewPermissionType.Report);
            if (BranchList == null)
            {
                BranchList = new List<BRBranchsInfo>();
            }
        }

        public List<BRBranchsInfo> GetBranchsByLocation(int locationID)
        {
            List<BRBranchsInfo> result = new List<BRBranchsInfo>();

            if (BranchList != null)
            {
                List<GELocationsInfo> collection = new List<GELocationsInfo>();
                GetLocationsByLocationParentID(collection, locationID);
                result = BranchList.Where(item => item.FK_GELocationID == locationID ||
                                            collection.Any(location => location.GELocationID == item.FK_GELocationID)).ToList();

            }

            return result;
        }

        public string GetListOfBranchNosFromBranchList(List<BRBranchsInfo> branchList)
        {
            string branchNos = string.Empty;
            if (branchList != null)
            {
                foreach (BRBranchsInfo branch in branchList)
                {
                    if (!string.IsNullOrEmpty(branchNos))
                        branchNos += ", ";
                    branchNos += branch.BRBranchNo;
                }
            }
            return branchNos;
        }

        public List<BRBranchsInfo> GetSelectedBranchesByBranchID(int branchID)
        {
            List<BRBranchsInfo> selectedBranches;
            if (branchID != 0)
            {
                selectedBranches = new List<BRBranchsInfo>();
                BRBranchsInfo branch = BranchList.FirstOrDefault(item => item.BRBranchID == branchID);
                if (branch != null)
                {
                    selectedBranches.Add(branch);
                }
            }
            else
            {
                selectedBranches = BranchList;
            }
            return selectedBranches;
        }

        public List<BRBranchsInfo> GetSelectedBranchesByLocationIDAndBranchID(int locationID, int branchID)
        {
            List<BRBranchsInfo> selectedBranches;
            if (branchID != 0)
            {
                selectedBranches = new List<BRBranchsInfo>();
                BRBranchsInfo branch = BranchList.FirstOrDefault(item => item.BRBranchID == branchID);
                if (branch != null)
                {
                    selectedBranches.Add(branch);
                }
            }
            else
            {
                if (locationID != 0)
                {
                    selectedBranches = GetBranchsByLocation(locationID);
                }
                else
                    selectedBranches = BranchList;
            }
            return selectedBranches;
        }

        public string GetSelectedBranchNosByBranchID(int branchID)
        {
            string selectedBranchNos = string.Empty;
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    if (!string.IsNullOrEmpty(selectedBranchNos))
                        selectedBranchNos += ", ";
                    selectedBranchNos += branch.BRBranchNo;
                }
            }
            return selectedBranchNos;
        }

        public string GetSelectedBranchNosByLocationIDAndBranchID(int locationID, int branchID)
        {
            string selectedBranchNos = string.Empty;
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    if (!string.IsNullOrEmpty(selectedBranchNos))
                        selectedBranchNos += ", ";
                    selectedBranchNos += branch.BRBranchNo;
                }
            }
            return selectedBranchNos;
        }

        private void GetLocationsByLocationParentID(List<GELocationsInfo> collection, int locationParentID)
        {
            if (collection != null)
            {
                GELocationsController locationController = new GELocationsController();
                DataSet ds = locationController.GetAllObjectsByObjectParentID(locationParentID);
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GELocationsInfo location = locationController.GetObjectFromDataRow(row) as GELocationsInfo;
                    collection.Add(location);
                    GetLocationsByLocationParentID(collection, location.GELocationID);
                }

            }
        }

        protected virtual int SetContentRowIndex()
        {
            return 0;
        }

        protected virtual List<ExportExcelParameter> GetReportHeader()
        {
            return new List<ExportExcelParameter>();
        }

        protected virtual List<ExportExcelParameter> GetReportContent(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            DataTable table = GetDefaultTableFromGridView(gridView);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                DataRow row = table.NewRow();
                bool acceptNewRow = false;
                for (int j = 0; j < VisibleColumns.Count; j++)
                {
                    String value = gridView.GetRowCellDisplayText(i, gridView.Columns[table.Columns[j].ColumnName]);
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (table.Columns[j].DataType == typeof(double))
                            row[j] = double.Parse(value);
                        else if (table.Columns[j].DataType == typeof(float))
                            row[j] = float.Parse(value);
                        else
                            row[j] = value;
                        acceptNewRow = true;
                    }
                }
                if (acceptNewRow)
                {
                    table.Rows.Add(row);
                }
            }
            SummaryRowIndex = table.Rows.Count + ContentRowIndex + 1;
            List<ExportExcelParameter> lstContentParameter = new List<ExportExcelParameter>();
            lstContentParameter.Add(new ExportExcelParameter(ContentRowIndex, ContentStartYIndex, table));

            return lstContentParameter;
        }

        protected virtual List<ExportExcelParameter> GetReportSummary(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                if (column.SummaryItem.SummaryValue != null)
                {
                    if (column.SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None)
                    {
                        object summaryValue = null;

                        if (column.SummaryItem.DisplayFormat.Equals("{0:n2}"))
                            summaryValue = double.Parse(column.SummaryItem.SummaryValue.ToString());
                        else if (column.SummaryItem.DisplayFormat.Equals("{0:n0}"))
                            summaryValue = float.Parse(column.SummaryItem.SummaryValue.ToString());
                        else if (column.ColumnType == typeof(double))
                            summaryValue = double.Parse(column.SummaryItem.SummaryValue.ToString());
                        else
                            summaryValue = column.SummaryItem.SummaryValue;
                        lstParameter.Add(SetDefaultSummaryParameter(summaryValue, SummaryRowIndex, ContentStartYIndex + column.VisibleIndex));
                    }
                }
            }
            return lstParameter;
        }

        protected virtual List<ExportExcelParameter> GetReportFooter()
        {
            return new List<ExportExcelParameter>();
        }

        protected virtual void ExportToExcel(GridView gridView)
        {
            List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
            lstParameter.AddRange(GetReportHeader().ToArray());
            ContentRowIndex = lstParameter.Count + 2 + SetContentRowIndex();
            lstParameter.AddRange(GetReportContent(gridView).ToArray());
            lstParameter.AddRange(GetReportSummary(gridView).ToArray());
            lstParameter.AddRange(GetReportFooter().ToArray());
            ExcelExporter.ExportToExcel(lstParameter);
        }

        public virtual void ExportToXls(GridView gridView)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = App.ExcelDialogFilter;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    gridView.ExportToXls(sfd.FileName);
                    Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #region Set default display
        public ExportExcelParameter SetDefaultHeaderParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 16, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultSubHeaderParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 13, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultTableNameParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 13, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultSubTableNameParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 12, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultSummaryParameter(object value, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, value, Color.Black, Color.LightGray, new Font("Calibri", 11, FontStyle.Bold));
        }
        #endregion

        protected DataTable GetDefaultTableFromGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            DataTable table = new DataTable();
            VisibleColumns = new List<string>();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].VisibleIndex >= 0)
                {
                    VisibleColumns.Add(gridView.Columns[i].FieldName);
                    DataColumn col = new DataColumn();
                    table.Columns.Add(col);
                }
            }
            for (int i = 0; i < VisibleColumns.Count; i++)
            {
                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].Caption = gridView.Columns[VisibleColumns[i]].Caption;
                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].ColumnName = gridView.Columns[VisibleColumns[i]].FieldName;
                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DefaultValue = (gridView.Columns[VisibleColumns[i]].Width / 8).ToString();

                STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
                BOSComponent.BOSGridControl gridControl = (BOSComponent.BOSGridControl)gridView.GridControl;
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = objFieldFormatGroupsController.GetFieldFormatGroupByTableNameAndColumnName(gridControl.BOSDataSource, gridView.Columns[VisibleColumns[i]].FieldName);
                if (objFieldFormatGroupsInfo != null)
                {
                    if (objFieldFormatGroupsInfo.STFieldFormatGroupMaskType.Equals("Numeric"))
                    {
                        switch (objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit)
                        {
                            case "n":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(double);
                                break;
                            case "n0":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(float);
                                break;
                        }
                    }
                }
                else
                {
                    if (gridView.Columns[VisibleColumns[i]].DisplayFormat.FormatType == DevExpress.Utils.FormatType.Numeric)
                    {
                        switch (gridView.Columns[VisibleColumns[i]].DisplayFormat.FormatString)
                        {
                            case "{0:n2}":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(double);
                                break;
                            case "{0:n0}":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(float);
                                break;
                        }
                    }
                }
            }
            return table;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            if (report != null && rptFile != string.Empty)
            {
                if(PrintDataSource!= null && PrintDataSource.Tables.Count> 0) report.DataSource = PrintDataSource;
                else report.DataSource = DataSource;
                guiReportPreview reviewer = new guiReportPreview(report, rptFile, true);
                reviewer.Show();
            }
            else
            {
                InitTemplate();
            }
        }

        public void InitTemplate()
        {
            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByID(TemplateID);
            if (objADTemplatesInfo != null)
            {
                rptFile = System.IO.Path.Combine("Reports", objADTemplatesInfo.ADTemplateNo + ".repx");
                report = new BOSReport.BaseReport();
                bool bExists = System.IO.File.Exists(rptFile);
                if (bExists)
                {
                    report.LoadLayout(rptFile);
                    Utilities.XtraReportHelper.SetFormatField(report);
                    report.DataSource = DataSource;
                    guiReportPreview reviewer = new guiReportPreview(report, rptFile, true);
                    reviewer.Show();
                }
                else if (DevExpress.XtraEditors.XtraMessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bắt đầu thiết kế mới?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    guiReportDesigner designer = new guiReportDesigner(report, rptFile);
                    designer.Show();
                }
            }
        }

        public void ViewReport(bool isInit)
        {
            bool isNullCol = false;
            if (GridControlResult.Columns == null || GridControlResult.Columns.Count == 0) isNullCol = true;
            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByID(TemplateID);
            if (objADTemplatesInfo != null && !string.IsNullOrEmpty(objADTemplatesInfo.ADTemplateStoreProc))
            {
                foreach (ADTemplateParamsInfo param in lstADTemplateParams)
                {
                    foreach (ADTemplateParamsInfo paramShow in lstADTemplateParamShow)
                    {
                        if (param.ADTemplateParamID == paramShow.ADTemplateParamID) 
                            param.ADTemplateParamValue = paramShow.ADTemplateParamValue;
                    }
                }
                object[] arParam = new object[lstADTemplateParams.Count];
                try
                {
                    for (int i = 0; i < lstADTemplateParams.Count; i++)
                    {
                        if (lstADTemplateParams[i].ADTemplateParamDataType.Equals("Date") || lstADTemplateParams[i].ADTemplateParamDataType.Equals("DateTime"))
                        {
                            arParam[i] = DateTime.Parse(lstADTemplateParams[i].ADTemplateParamValue.ToString());
                        }
                        else if (lstADTemplateParams[i].ADTemplateParamDataType.Equals("Number"))
                        {
                            try
                            {
                                arParam[i] = Convert.ToInt32(lstADTemplateParams[i].ADTemplateParamValue);
                            }
                            catch (Exception)
                            {
                                arParam[i] = 0;
                            }

                        }
                        else if (lstADTemplateParams[i].ADTemplateParamDataType.ToLower().Equals("bit") ||
                            lstADTemplateParams[i].ADTemplateParamDataType.ToLower().Equals("boolean"))
                        {
                            if (Convert.ToBoolean(lstADTemplateParams[i].ADTemplateParamValue)) arParam[i] = 1; else arParam[i] = 0;
                        }
                        else if (lstADTemplateParams[i].ADTemplateParamDataType.ToLower().Equals("currentuser"))
                        {
                            arParam[i] = BOSApp.CurrentUsersInfo.ADUserID;
                        }
                        else if (lstADTemplateParams[i].ADTemplateParamDataType.ToLower().Equals("currentbranch"))
                        {
                            arParam[i] = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                        }
                        else
                            arParam[i] = lstADTemplateParams[i].ADTemplateParamValue;
                        if (!isInit
                            && lstADTemplateParams[i].ADTemplateParamIsNotNull
                            && (!lstADTemplateParams[i].ADTemplateParamDataType.Equals("Number") && string.IsNullOrEmpty(lstADTemplateParams[i].ADTemplateParamValue)
                                || (lstADTemplateParams[i].ADTemplateParamDataType.Equals("Number") && int.Parse(arParam[i].ToString()) == 0)
                                )
                            )
                        {
                            BOSApp.ShowMessage(lstADTemplateParams[i].ADTemplateParamName + " không thể trống!");
                            return;
                        }
                    }
                    if (objADTemplatesInfo.ADTemplateAutoLoad || !isInit)
                    {
                        BOSProgressBar.Start("Đang tải dữ liệu...");
                        try
                        {
                            ADReportsController objMainObjectController = new ADReportsController();
                            DataSource = objMainObjectController.GetTimeOutDataSet(objADTemplatesInfo.ADTemplateStoreProc, 500, arParam);
                            if(!string.IsNullOrEmpty(objADTemplatesInfo.ADTemplatePrintStoreProc) && objADTemplatesInfo.ADTemplateStoreProc != objADTemplatesInfo.ADTemplatePrintStoreProc)
                                PrintDataSource = objMainObjectController.GetTimeOutDataSet(objADTemplatesInfo.ADTemplatePrintStoreProc, 500, arParam);
                            if (DataSource != null & DataSource.Tables[0] != null)
                            {
                                if (GridControlResult.Columns.Count() == 0)
                                {
                                    GridColumn column;
                                    int visibleIndex = 1;
                                    foreach (DataColumn col in DataSource.Tables[0].Columns)
                                    {
                                        column = new GridColumn();
                                        column.Caption = col.Caption;
                                        column.FieldName = col.ColumnName;
                                        column.OptionsColumn.AllowEdit = false;
                                        column.VisibleIndex = visibleIndex;
                                        GridControlResult.Columns.Add(column);
                                        visibleIndex++;
                                        if (col.DataType == typeof(double) || col.DataType == typeof(float) || col.DataType == typeof(int) || col.DataType == typeof(decimal))
                                        {
                                            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                                            column.DisplayFormat.FormatString = "{0:N2}";
                                        }
                                    }
                                }
                                GridControlResult.DataSource = DataSource.Tables[0];
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            BOSProgressBar.Close();
                            DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Lỗi tải dữ liệu {0}!", objADTemplatesInfo.ADTemplateStoreProc, ex.Message));
                        }
                        BOSProgressBar.Close();
                    }
                    //Format Summary
                    foreach (GridColumn o in GridControlResult.Columns)
                    {
                        if (o.SummaryItem.SummaryValue != null)
                        {
                            if (o.SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None)
                            {
                                if (o.SummaryItem.DisplayFormat.Equals("SUM={0:0.##}"))
                                    o.SummaryItem.DisplayFormat = "SUM={0:0,###.##}";
                            }
                        }
                    }

                    GridControlResult?.RefreshDataSource();
                    if (isNullCol)
                        foreach (GridColumn o in GridControlResult.Columns)
                        {
                            o.OptionsColumn.AllowEdit = false;
                        }
                }
                catch (Exception ex)
                {
                    BOSProgressBar.Close();
                    DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Lỗi thiết lập tham số cho {0}!\n{1}", objADTemplatesInfo.ADTemplateStoreProc, ex.Message));
                }

            }

        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            ViewReport(false);
        }

        private void repositoryItemDateEdit_Click(object sender, EventArgs e)
        {
            this.CheckKey = 0;
        }

        private void repositoryItemDateEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0
                || e.KeyCode == Keys.NumPad1
                || e.KeyCode == Keys.NumPad2
                || e.KeyCode == Keys.NumPad3
                || e.KeyCode == Keys.NumPad4
                || e.KeyCode == Keys.NumPad5
                || e.KeyCode == Keys.NumPad6
                || e.KeyCode == Keys.NumPad7
                || e.KeyCode == Keys.NumPad8
                || e.KeyCode == Keys.NumPad9
                || e.KeyCode == Keys.D0
                || e.KeyCode == Keys.D1
                || e.KeyCode == Keys.D2
                || e.KeyCode == Keys.D3
                || e.KeyCode == Keys.D4
                || e.KeyCode == Keys.D5
                || e.KeyCode == Keys.D6
                || e.KeyCode == Keys.D7
                || e.KeyCode == Keys.D8
                || e.KeyCode == Keys.D9)
            {
                CheckKey++;
                if (CheckKey == 2)
                {
                    SendKeys.Send("{Right}");
                }
                else if (CheckKey == 4)
                {
                    SendKeys.Send("{Right}");
                }
                else if (CheckKey == 8)
                {
                    CheckKey = 0;
                    SendKeys.Send("{Left}");
                    SendKeys.Send("{Left}");
                }
            }
        }
    }
}
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class TemplateParamForm : BOSERPScreen
    {
        int TemplateID = 0;
        List<string> listTableNameExcep = new List<string>() { "GECurrencies" };
        private Dictionary<string, DataTable> dicRptLookupTables = new Dictionary<string, DataTable>();
        public BOSList<ADTemplateParamsInfo> lstADTemplateParams = new BOSList<ADTemplateParamsInfo>();
        public BOSList<ADTemplateParamsInfo> lstADTemplateParamShow = new BOSList<ADTemplateParamsInfo>();
        public TemplateParamForm(int pTemplateID)
        {
            InitializeComponent();
            TemplateID = pTemplateID;
            StartPosition = FormStartPosition.CenterScreen;
            base.Load += new EventHandler(ReportForm_Load);
            ADTemplateParamsController objADTemplateParamsController = new ADTemplateParamsController();
            DataSet ds = objADTemplateParamsController.GetTemplateParam(TemplateID);

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ADTemplateParamsInfo objADTemplateParamsInfo = (ADTemplateParamsInfo)objADTemplateParamsController.GetObjectFromDataRow(dr);
                    string ADTemplateParamNo = objADTemplateParamsInfo.ADTemplateParamNo;
                    if (objADTemplateParamsInfo.ADTemplateParamDataType.Equals("Date") || objADTemplateParamsInfo.ADTemplateParamDataType.Equals("DateTime"))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = DateTime.Now.Date.ToString("dd/MM/yyyy");
                    }
                    else if (objADTemplateParamsInfo.ADTemplateParamDataType.Equals("Number"))
                    {
                        if (objADTemplateParamsInfo.ADTemplateParamNo.ToLower().Contains("year"))
                            objADTemplateParamsInfo.ADTemplateParamValue = DateTime.Now.Date.Year.ToString();
                        else if (ADTemplateParamNo.ToLower().Contains("month"))
                            objADTemplateParamsInfo.ADTemplateParamValue = DateTime.Now.Date.Month.ToString();
                    }
                    else if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals("bit") ||
                        objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals("boolean"))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = "False";
                    }
                    else if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals("currentuser"))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = BOSApp.CurrentUsersInfo.ADUserID.ToString();
                    }
                    else if (objADTemplateParamsInfo.ADTemplateParamDataType.ToLower().Equals("currentbranch"))
                    {
                        objADTemplateParamsInfo.ADTemplateParamValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID.ToString();
                    }
                    lstADTemplateParams.Add(objADTemplateParamsInfo);
                }
                lstADTemplateParamShow.Invalidate(lstADTemplateParams.Where(p => p.ADTemplateParamIsDisplay == true).ToList());
                dataGridView1.DataSource = lstADTemplateParamShow;
                dataGridView1.DefaultView.RefreshData();

            }
            ParamGridView.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
        }

        void ReportForm_Load(object sender, EventArgs e)
        {
            ControlBox = true;
            MaximizeBox = true;
            MinimizeBox = true;
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "ADTemplateParamValue")
            {
                ADTemplateParamsController objADTemplateParamsController = new ADTemplateParamsController();
                ADTemplateParamsInfo paramInfo = new ADTemplateParamsInfo();
                object value = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRowCellValue(e.RowHandle, "ADTemplateParamValue");
                paramInfo.ADTemplateParamNo = (String)((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRowCellValue(e.RowHandle, "ADTemplateParamNo");
                paramInfo.ADTemplateParamDataType = (String)((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRowCellValue(e.RowHandle, "ADTemplateParamDataType");
                paramInfo.ADTemplateParamLookupEdit = (String)((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRowCellValue(e.RowHandle, "ADTemplateParamLookupEdit");
                paramInfo.ADTemplateParamFilter = (String)((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRowCellValue(e.RowHandle, "ADTemplateParamFilter");
                object temp = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRowCellValue(e.RowHandle, "ADTemplateParamColumns");


                if (DBNull.Value.Equals(temp) == false)
                    paramInfo.ADTemplateParamColumns = (String)((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRowCellValue(e.RowHandle, "ADTemplateParamColumns");
                SetRepository(paramInfo, e);

            }
        }
        private void SetRepository(ADTemplateParamsInfo paramInfo, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs objCustomRow)
        {
            if (paramInfo.ADTemplateParamDataType.ToLower() == "multiselect")
            {
                BindingSource source = new BindingSource();
                DataTable dt = TryToInitLookupTable(paramInfo.ADTemplateParamLookupEdit, paramInfo.ADTemplateParamNo, paramInfo.ADTemplateParamFilter, paramInfo.ADTemplateParamColumns);
                if (dt != null)
                {
                    source.DataSource = dt;
                }
                RepositoryItemCheckedComboBoxEdit ccbe = new RepositoryItemCheckedComboBoxEdit();
                ccbe.DataSource = dt;
                ccbe.DisplayMember = listTableNameExcep.Contains(paramInfo.ADTemplateParamLookupEdit) ? paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 3) + "yName"
                                                                                                                    : paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 1) + "Name";
                ccbe.ValueMember = listTableNameExcep.Contains(paramInfo.ADTemplateParamLookupEdit) ? paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 3) + "yNo"
                                                                                                                    : paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 1) + "No";
                ccbe.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);
                ccbe.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(RepositoryItemCheckedComboBoxEdit_CustomDisplayText);
                objCustomRow.RepositoryItem = ccbe;
                return;
            }

            if (paramInfo.ADTemplateParamNo.EndsWith("Combo") || paramInfo.ADTemplateParamNo.EndsWith("Type"))
            {
                String strConfigValueTable = String.Empty;
                if (paramInfo.ADTemplateParamNo.EndsWith("Combo"))
                    strConfigValueTable = paramInfo.ADTemplateParamNo.Substring(2, paramInfo.ADTemplateParamNo.Length - 7);
                else
                    strConfigValueTable = paramInfo.ADTemplateParamNo.Substring(2, paramInfo.ADTemplateParamNo.Length - 2);
                if (ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable] != null)
                {
                    RepositoryItemLookUpEdit rep = new RepositoryItemLookUpEdit();
                    rep.DataSource = ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable];
                    rep.ValueMember = "Value";
                    rep.DisplayMember = "Text";
                    rep.NullText = String.Empty;
                    rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    rep.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);

                    DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                    repColumn.FieldName = "Text";
                    repColumn.Width = 100;
                    rep.Columns.Add(repColumn);
                    rep.PopupWidth = repColumn.Width;
                    objCustomRow.RepositoryItem = rep;
                    return;
                }
            }
            if (paramInfo.ADTemplateParamLookupEdit == string.Empty)
            {
                if (paramInfo.ADTemplateParamDataType.ToLower().Equals("date") ||
                        paramInfo.ADTemplateParamDataType.ToLower().Equals("datetime"))
                {
                    objCustomRow.RepositoryItem = CreateRepositoryItemDate();
                }
                else if (paramInfo.ADTemplateParamDataType.ToLower().Contains("number"))
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
                else if (paramInfo.ADTemplateParamDataType.ToLower().Equals("bit") ||
                    paramInfo.ADTemplateParamDataType.ToLower().Equals("boolean"))
                    objCustomRow.RepositoryItem = new RepositoryItemCheckEdit();
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
                    RepositoryItemLookUpEdit rep = new RepositoryItemLookUpEdit();
                    rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    rep.NullText = String.Empty;
                    rep.DataSource = dt;
                    DevExpress.XtraEditors.Controls.LookUpColumnInfo colLKE = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo");
                    colLKE.Caption = "Mã đối tượng";
                    rep.Columns.Add(colLKE);
                    colLKE = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName");
                    colLKE.Caption = "Tên đối tượng";
                    rep.Columns.Add(colLKE);
                    rep.DisplayMember = "ACObjectName";
                    rep.ValueMember = "ACObjectAccessKey";
                    rep.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                    rep.BestFit();
                    rep.QueryPopUp += RepositoryItemLookupEdit_QueryPopup;
                    objCustomRow.RepositoryItem = rep;
                    return;
                }
            }

            else
            {
                DataTable dt = TryToInitLookupTable(paramInfo.ADTemplateParamLookupEdit, paramInfo.ADTemplateParamNo, paramInfo.ADTemplateParamFilter, paramInfo.ADTemplateParamColumns);
                //paramInfo.ADTemplateParamColumns = dicGLTranCfgLookupTableCols[paramInfo.ADTemplateParamLookupEdit];
                if (dt != null)
                {
                    RepositoryItemLookUpEdit rep = new RepositoryItemLookUpEdit();

                    rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    rep.NullText = String.Empty;
                    rep.DataSource = dt;
                    string strKeyColumn = String.Empty;
                    if (listTableNameExcep.Contains(paramInfo.ADTemplateParamLookupEdit))
                        strKeyColumn = paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 3) + "yID";
                    else
                        strKeyColumn = paramInfo.ADTemplateParamLookupEdit.Substring(0, paramInfo.ADTemplateParamLookupEdit.Length - 1) + "ID";
                    Boolean isExistCol = false;
                    if (!string.IsNullOrEmpty(paramInfo.ADTemplateParamColumns))
                    {
                        string[] strLKEColumns = paramInfo.ADTemplateParamColumns.Split(',');
                        foreach (string strCol in strLKEColumns)
                        {
                            //String strColAlias = BOSUtil.GetColumnAlias(strCol, paramInfo.ADTemplateParamLookupEdit);
                            //if (String.IsNullOrEmpty(strColAlias))
                            //    strColAlias = strCol;
                            DevExpress.XtraEditors.Controls.LookUpColumnInfo colLKE = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(strCol);
                            colLKE.Caption = strCol;
                            rep.Columns.Add(colLKE);
                            isExistCol = true;
                        }
                        rep.DisplayMember = strLKEColumns[0];
                    }
                    else
                    {
                        String strNoCol = strKeyColumn.Substring(0, strKeyColumn.Length - 2) + "No";
                        //String aliasCol = GMCUtil.GetColumnAlias(strNoCol, paramInfo.ADTemplateParamLookupEdit);
                        //if (String.IsNullOrEmpty(aliasCol))
                        //    aliasCol = strNoCol;
                        DevExpress.XtraEditors.Controls.LookUpColumnInfo colLKE = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(strNoCol);
                        colLKE.Caption = "Mã";
                        rep.Columns.Add(colLKE);
                        if (dt.Columns.Contains(strKeyColumn.Substring(0, strKeyColumn.Length - 2) + "Name"))
                        {
                            colLKE = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(strKeyColumn.Substring(0, strKeyColumn.Length - 2) + "Name");
                            colLKE.Caption = "Tên";
                            rep.Columns.Add(colLKE);
                        }

                        rep.DisplayMember = strNoCol;
                    }


                    rep.ValueMember = strKeyColumn;

                    rep.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                    //rep.KeyDown += rep_KeyDown;
                    //rep.EditValueChanged += rep_EditValueChanged;

                    //)
                    rep.BestFit();

                    rep.QueryPopUp += RepositoryItemLookupEdit_QueryPopup;

                    objCustomRow.RepositoryItem = rep;
                }

            }
        }

        protected virtual void RepositoryItemCheckedComboBoxEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {

        }

        protected virtual void RepositoryItemLookupEdit_QueryPopup(object sender, CancelEventArgs e)
        {
            string sADTemplateParamFilter = Convert.ToString(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, "ADTemplateParamFilter"));
            string[] spliter = new string[] { "--" };
            string[] arsADTemplateParamFilter = sADTemplateParamFilter.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
            if (arsADTemplateParamFilter.Length < 2) return;
            sADTemplateParamFilter = arsADTemplateParamFilter[1];
            for (int i = 0; i < this.ParamGridView.RowCount; i++)
            {
                DataRow dr = this.ParamGridView.GetDataRow(i);

                string strParamNo = (String)this.ParamGridView.GetRowCellValue(i, "ADTemplateParamNo");

                string strParamType = (String)this.ParamGridView.GetRowCellValue(i, "ADTemplateParamDataType");

                string strParamValue = (String)this.ParamGridView.GetRowCellValue(i, "ADTemplateParamValue");

                if (strParamType.Equals("Date"))
                    strParamValue = Convert.ToDateTime(strParamValue).Date.ToString("yyyyMMdd");
                else if (strParamType.Equals("DateTime"))
                    strParamValue = Convert.ToDateTime(strParamValue).Date.ToString("yyyyMMdd HH:mm:ss");

                sADTemplateParamFilter = sADTemplateParamFilter.Replace("@" + strParamNo, strParamValue);
            }
            try
            {
                DevExpress.XtraEditors.LookUpEdit lke = (DevExpress.XtraEditors.LookUpEdit)sender;

                if (lke.Properties is RepositoryItemLookUpEdit)
                    ((System.Data.DataTable)((RepositoryItemLookUpEdit)lke.Properties).DataSource).DataSet.Tables[0].DefaultView.RowFilter = sADTemplateParamFilter;
            }
            catch (Exception)
            {
            }

            return;

        }
        public DataTable TryToInitLookupTable(string psTableName, string psParaName, string psKey, string psCols)
        {
            string psdicName = psTableName;
            if (psKey.Length > 0) psdicName = psdicName + "_" + psParaName;
            if (dicRptLookupTables.ContainsKey(psdicName) && dicRptLookupTables[psdicName] != null)
            {
                return dicRptLookupTables[psdicName];
            }
            DataTable dt = new DataTable();
            DataSet ds;
            string sPrefix = String.Empty;
            if (listTableNameExcep.Contains(psTableName)) sPrefix = psTableName.Substring(0, psTableName.Length - 3) + "y";
            else
                sPrefix = psTableName.Substring(0, psTableName.Length - 1);
            string strSQL = "SELECT CAST(" + sPrefix + "ID as varchar) as " + sPrefix + "ID,";
            string sOrderBys = "";

            if (new BOSDbUtil().ColumnIsExist(psTableName, sPrefix + "No"))
            {
                if (!("," + psCols + ",").Contains("," + sPrefix + "No,"))
                    strSQL += "" + sPrefix + "No,";

                sOrderBys += sPrefix + "No,";
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

            if (psKey.Length > 0)
                psKey = " AND " + psKey;
            if (new BOSDbUtil().ColumnIsExist(psTableName, "AAStatus"))
                psKey = "AAStatus IN ('Alive','Dummy')" + psKey;
            if (psKey.Length > 0)
                strSQL += " WHERE " + psKey;

            if (sOrderBys.Length > 0)
                strSQL += string.Format(@" ORDER BY {0}", sOrderBys);

            IBusinessController MainCtrl = BusinessControllerFactory.GetBusinessController(psTableName + "Controller");
            ds = MainCtrl.GetDataSet(strSQL);

            if (ds != null && ds.Tables.Count > 0)
                dt = ds.Tables[0];
            dicRptLookupTables[psdicName] = dt;
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
            return rep;
        }
        void repositoryItemDateEdit_Leave(object sender, EventArgs e)
        {
            DateEdit dteSender = (DateEdit)sender;
            this.ParamGridView.SetRowCellValue(this.ParamGridView.FocusedRowHandle, "ADTemplateParamValue", dteSender.DateTime.ToString("dd/MM/yyyy"));
        }

        void repositoryItemDateEdit_Enter(object sender, EventArgs e)
        {
            DateEdit dteSender = (DateEdit)sender;
            try
            {
                dteSender.EditValue = Convert.ToDateTime(this.ParamGridView.GetRowCellValue(this.ParamGridView.FocusedRowHandle, "ADTemplateParamValue"));
            }
            catch
            {
            }
        }
    }
}
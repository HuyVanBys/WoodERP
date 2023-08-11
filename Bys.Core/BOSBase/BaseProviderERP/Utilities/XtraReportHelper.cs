using BOSComponent;
using BOSLib;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Utilities
{
    public class XtraReportHelper
    {
        /// <summary>
        /// Print a report to a printer
        /// </summary>
        /// <param name="report">Report</param>
        /// <param name="printerName">Printer name</param>
        public static void PrintToPrinter(XtraReport report, string printerName)
        {
            SetFormatField(report);

            report.Print(printerName);
        }

        /// <summary>
        /// Set format field for control in report
        /// </summary>
        /// <param name="report">Current report</param>
        public static void SetFormatField(XtraReport report)
        {
            foreach (Band band in report.Bands)
            {
                SetFormatField(band.Controls);
            }
        }

        public static void SetFormatField(XtraReport report, string fieldName, string formatString)
        {

        }

        /// <summary>
        /// Set the display format of data bound to the report's controls
        /// </summary>
        /// <param name="controls">Control collection</param>
        private static void SetFormatField(XRControlCollection controls)
        {
            foreach (XRControl control in controls)
            {
                if (control.GetType() == typeof(XRTable))
                {
                    XRTable table = (XRTable)control;
                    foreach (XRTableCell tableCell in table.Rows[0].Cells)
                    {
                        if (tableCell.DataBindings.Count > 0)
                        {
                            XRBinding binding = tableCell.DataBindings[0];
                            SetFormatControlBinding(tableCell, binding);
                        }
                    }
                }
                else
                {
                    if (control.DataBindings.Count > 0)
                    {
                        XRBinding binding = control.DataBindings[0];
                        SetFormatControlBinding(control, binding);
                    }
                }

                if (control.Controls.Count > 0)
                {
                    SetFormatField(control.Controls);
                }
            }
        }

        /// <summary>
        /// Set format for control binding
        /// </summary>
        /// <param name="ctrl">Control the data is bound to</param>
        /// <param name="binding">Data binding of the control</param>
        private static void SetFormatControlBinding(XRControl ctrl, XRBinding binding)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (binding.DataSource is DataSet || binding.DataSource is DataTable)
            {
                DataTable table = null;
                if (binding.DataSource is DataSet)
                {
                    table = ((DataSet)binding.DataSource).Tables[0];
                }
                else
                {
                    table = (DataTable)binding.DataSource;
                }
                string[] arr = binding.DataMember.ToString().Split('.');
                if (arr.Length > 1)
                {
                    string columnName = arr[1];
                    if (table.Rows.Count > 0)
                    {
                        string tableName = dbUtil.GetTableNameByColumnName(columnName);
                        if (string.IsNullOrEmpty(tableName))
                        {
                            STFieldColumnsController objFieldColumnsController = new STFieldColumnsController();
                            STFieldsInfo objFieldsInfo = objFieldColumnsController.GetFirstFieldByColumnFieldName(columnName);
                            if (objFieldsInfo != null)
                            {
                                tableName = objFieldsInfo.STFieldDataSource;
                            }
                        }
                        if (!string.IsNullOrEmpty(tableName))
                        {
                            //STFieldFormatGroupsInfo objFormatGroupsInfo = BOSUtil.GetColumnFormat(tableName, columnName);
                            STFieldFormatGroupsInfo objFormatGroupsInfo = BOSApp.FieldFormatList.Where(f => f.TableName == tableName
                                                                                            && f.ColumnName == columnName).FirstOrDefault();
                            if (objFormatGroupsInfo != null)
                            {
                                binding.FormatString = "{0:" + objFormatGroupsInfo.STFieldFormatGroupFormatString + "}";
                                if (ctrl is XRLabel)
                                {
                                    (ctrl as XRLabel).Summary.FormatString = binding.FormatString;
                                }
                            }
                        }
                    }
                }
            }
            else if (binding.DataSource is IList)
            {
                IList lst = (IList)binding.DataSource;
                if (lst.Count > 0)
                {
                    PropertyInfo prop = lst[0].GetType().GetProperty(binding.DataMember);
                    if (prop != null)
                    {
                        string tableName = BOSUtil.GetTableNameFromBusinessObject((BusinessObject)lst[0]);
                        if (!string.IsNullOrEmpty(tableName))
                        {
                            STFieldFormatGroupsInfo objFormatGroupsInfo = BOSApp.FieldFormatList.Where(f => f.TableName == tableName
                                                                                            && f.ColumnName == binding.DataMember).FirstOrDefault();
                            //STFieldFormatGroupsInfo objFormatGroupsInfo = BOSUtil.GetColumnFormat(tableName, binding.DataMember);
                            if (objFormatGroupsInfo != null)
                            {
                                binding.FormatString = "{0:" + objFormatGroupsInfo.STFieldFormatGroupFormatString + "}";
                                if (ctrl is XRLabel)
                                {
                                    (ctrl as XRLabel).Summary.FormatString = binding.FormatString;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void ShowRef(BOSList<ADTemplateParamsInfo> lstParam, BusinessObject item, System.Windows.Forms.Form.ControlCollection control, string ViewNo, BaseModule module, string fieldClickName)
        {
            ADReportViewRefsController objReportViewRefsController = new ADReportViewRefsController();
            ADReportViewRefParamsController objReportViewRefParamsController = new ADReportViewRefParamsController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataSet dsDataSource = new DataSet();
            ADReportViewRefsInfo objReportViewRefsInfo = objReportViewRefsController.GetViewRefByReportViewNo(ViewNo, fieldClickName);
            if (objReportViewRefsInfo != null)
            {
                List<ADReportViewRefParamsInfo> paraList = objReportViewRefParamsController.GetViewRefParamByReportViewID(objReportViewRefsInfo.ADReportViewRefID);
                if (paraList != null && paraList.Count > 0 || objReportViewRefsInfo.ADReportViewRefType == "Module")
                {
                    object[] arParam = new object[paraList.Count];
                    try
                    {
                        for (int i = 1; i < paraList.Count; i++)
                        {
                            string columnName = paraList[i].ADReportViewRefParamColumns;

                            if (paraList[i].ADReportViewRefParamDataType.Equals("Date") || paraList[i].ADReportViewRefParamDataType.Equals("DateTime"))
                            {
                                object result = null;
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    result = GetParamValueFromListParam(columnName, lstParam);
                                }
                                else if (columnName != string.Empty && dbUtil.GetPropertyValue(item, columnName) != null)
                                {
                                    result = dbUtil.GetPropertyValue(item, columnName);
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                }
                                if (result != null)
                                {
                                    arParam[i] = ConvertParamToDate(paraList[i].ADReportViewRefParamDataType, result);
                                }

                            }
                            else if (paraList[i].ADReportViewRefParamDataType.Equals("Number"))
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    arParam[i] = Convert.ToInt32(result != null && result != string.Empty ? result : "0");
                                }
                                else if (columnName != string.Empty)
                                {
                                    arParam[i] = Convert.ToInt32(dbUtil.GetPropertyValue(item, columnName));
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            if (!paraList[i].ADReportViewRefParamIsDisplay && Convert.ToInt32(result) == 0)
                                                arParam[i] = null;
                                            else
                                                arParam[i] = Convert.ToInt32(result);
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = 0;
                                        }
                                    }
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("bit") ||
                                paraList[i].ADReportViewRefParamDataType.ToLower().Equals("boolean"))
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    arParam[i] = Convert.ToBoolean(result);
                                }
                                else if (columnName != string.Empty)
                                {
                                    arParam[i] = Convert.ToBoolean(dbUtil.GetPropertyValue(item, columnName));
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            arParam[i] = Convert.ToBoolean(result);
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = false;
                                        }
                                    }
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("currentuser"))
                            {
                                arParam[i] = BOSApp.CurrentUsersInfo.ADUserID;
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("currentbranch"))
                            {
                                arParam[i] = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                            }
                            else
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    arParam[i] = result;
                                }
                                else if (columnName != string.Empty)
                                {
                                    arParam[i] = Convert.ToString(dbUtil.GetPropertyValue(item, columnName));
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            arParam[i] = Convert.ToString(result);
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = "";
                                        }
                                    }
                                }

                            }
                        }
                        if (objReportViewRefsInfo.ADReportViewRefStoreProc != string.Empty)
                            dsDataSource = SqlDatabaseHelper.RunStoredProcedure(objReportViewRefsInfo.ADReportViewRefStoreProc, arParam);
                        string fortmat = "BOSERP.Modules.Report.{0}";
                        ReportFormView form = null;
                        if (objReportViewRefsInfo.ADReportViewRefType == "Report" && objReportViewRefsInfo.ADReportViewRefName != string.Empty)
                            form = (ReportFormView)BaseClassFactory.GetClass(String.Format(fortmat, objReportViewRefsInfo.ADReportViewRefName.ToString()));

                        else if (objReportViewRefsInfo.ADReportViewRefType == "Module"
                            && (objReportViewRefsInfo.ADReportViewRefName != string.Empty || objReportViewRefsInfo.ADReportViewRefFieldModuleName != string.Empty))
                        {
                            string moduleName = string.Empty;
                            int referID = 0;
                            if (objReportViewRefsInfo.ADReportViewRefName != string.Empty)
                                moduleName = objReportViewRefsInfo.ADReportViewRefName;
                            else
                            {
                                moduleName = Convert.ToString(dbUtil.GetPropertyValue(item, objReportViewRefsInfo.ADReportViewRefFieldModuleName));
                            }
                            if (moduleName != string.Empty)
                            {
                                string columnName = objReportViewRefsInfo.ADReportViewRefCol;
                                if (objReportViewRefsInfo.ADReportViewRefDrillDownValue != string.Empty)
                                {
                                    referID = Convert.ToInt32(dbUtil.GetPropertyValue(item, objReportViewRefsInfo.ADReportViewRefDrillDownValue));
                                }
                                Type moduleType = null;
                                List<string> libraryModule = BOSLib.BysGateway.LibraryModule;
                                libraryModule.ForEach(libName =>
                                {
                                    if (moduleType != null)
                                        return;

                                    moduleType = Assembly.LoadFrom(Application.StartupPath + "\\" + libName).GetType("BOSERP.Modules." + moduleName + "." + moduleName + "Module");
                                });
                                if (moduleType != null)
                                {
                                    BaseModuleERP currModule = BOSApp.IsOpenedModule(moduleName) ? ((BaseModuleERP)BOSApp.OpenModules[moduleName]) : (BaseModuleERP)BOSApp.ShowModule(moduleName);
                                    if (currModule == null)
                                        return;
                                    currModule.Invalidate(referID);
                                    currModule.ParentScreen.Activate();
                                }
                                else
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Không tồn tại module: {0} trong hệ thống!", moduleName));
                                }
                            }
                        }
                        if (form == null && objReportViewRefsInfo.ADReportViewRefType == "Report")
                            form = new ReportFormView();
                        if (form != null)
                        {
                            form.DataSource = dsDataSource;
                            form.GridControlName = objReportViewRefsInfo.ADReportViewRefDataSource;
                            form.DataSourceName = objReportViewRefsInfo.ADReportViewRefDataSource;
                            form.Module = module;
                            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByNo(objReportViewRefsInfo.ADReportViewRefName);
                            if (objADTemplatesInfo != null)
                            {
                                form.TemplateID = objADTemplatesInfo.ADTemplateID;
                                form.TemplateName = objADTemplatesInfo.ADTemplateName;
                                form.ArParam = arParam;
                                form.InitParam();
                            }
                            form.GetBranchListByUserPermission();
                            form.InitGridView();
                            form.StartPosition = FormStartPosition.CenterScreen;
                            form.Top = 1;
                            form.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Lỗi thiết lập tham số cho {0}!\n{1}", objReportViewRefsInfo.ADReportViewRefStoreProc, ex.Message));
                    }
                }
            }
        }

        public static void ShowRefByRow(BOSList<ADTemplateParamsInfo> lstParam, System.Data.DataRowView row, System.Windows.Forms.Form.ControlCollection control, string ViewNo, BaseModule module, string fieldClickName)
        {
            ADReportViewRefsController objReportViewRefsController = new ADReportViewRefsController();
            ADReportViewRefParamsController objReportViewRefParamsController = new ADReportViewRefParamsController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataSet dsDataSource = new DataSet();
            ADReportViewRefsInfo objReportViewRefsInfo = objReportViewRefsController.GetViewRefByReportViewNo(ViewNo, fieldClickName);
            if (objReportViewRefsInfo != null)
            {

                List<ADReportViewRefParamsInfo> paraList = objReportViewRefParamsController.GetViewRefParamByReportViewID(objReportViewRefsInfo.ADReportViewRefID);
                if (paraList != null && paraList.Count > 0 || objReportViewRefsInfo.ADReportViewRefType == "Module")
                {
                    object[] arParam = new object[paraList.Count];
                    try
                    {
                        for (int i = 0; i < paraList.Count; i++)
                        {
                            string columnName = paraList[i].ADReportViewRefParamColumns;
                            if (paraList[i].ADReportViewRefParamDataType.Equals("Date") || paraList[i].ADReportViewRefParamDataType.Equals("DateTime"))
                            {
                                object result = null;
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    result = GetParamValueFromListParam(columnName, lstParam);
                                }
                                else if (columnName != string.Empty && row.Row.Table.Columns.Contains(columnName))
                                {
                                    result = row[columnName];
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                }
                                if (result != null)
                                {
                                    arParam[i] = ConvertParamToDate(paraList[i].ADReportViewRefParamDataType, result);
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.Equals("Number"))
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    arParam[i] = Convert.ToInt32(result != null && result != string.Empty ? result : "0");
                                }
                                else if (columnName != string.Empty && row.Row.Table.Columns.Contains(columnName))
                                {
                                    arParam[i] = Convert.ToInt32(row[columnName] != null ? row[columnName] : "0");
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            if (!paraList[i].ADReportViewRefParamIsDisplay && Convert.ToInt32(result) == 0)
                                                arParam[i] = null;
                                            else
                                                arParam[i] = Convert.ToInt32(result);
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = 0;
                                        }
                                    }
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("bit") ||
                                paraList[i].ADReportViewRefParamDataType.ToLower().Equals("boolean"))
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    arParam[i] = Convert.ToBoolean(result);
                                }
                                else if (columnName != string.Empty && row.Row.Table.Columns.Contains(columnName))
                                {
                                    arParam[i] = Convert.ToBoolean(row[columnName]);
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            arParam[i] = Convert.ToBoolean(result);
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = false;
                                        }
                                    }
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("currentuser"))
                            {
                                arParam[i] = BOSApp.CurrentUsersInfo.ADUserID;
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("currentbranch"))
                            {
                                arParam[i] = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                            }
                            else
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    arParam[i] = result;
                                }
                                else if (columnName != string.Empty && row.Row.Table.Columns.Contains(columnName))
                                {
                                    arParam[i] = row[columnName];
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromScreen(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            arParam[i] = result;
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = "";
                                        }
                                    }
                                }

                            }
                        }
                        if (objReportViewRefsInfo.ADReportViewRefStoreProc != string.Empty)
                            dsDataSource = SqlDatabaseHelper.RunStoredProcedure(objReportViewRefsInfo.ADReportViewRefStoreProc, arParam);
                        string fortmat = "BOSERP.Modules.Report.{0}";
                        ReportFormView form = null;
                        if (objReportViewRefsInfo.ADReportViewRefType == "Report" && objReportViewRefsInfo.ADReportViewRefName != string.Empty)
                            form = (ReportFormView)BaseClassFactory.GetClass(String.Format(fortmat, objReportViewRefsInfo.ADReportViewRefName.ToString()));

                        else if (objReportViewRefsInfo.ADReportViewRefType == "Module"
                            && (objReportViewRefsInfo.ADReportViewRefName != string.Empty || objReportViewRefsInfo.ADReportViewRefFieldModuleName != string.Empty))
                        {
                            string moduleName = string.Empty;
                            int referID = 0;
                            if (objReportViewRefsInfo.ADReportViewRefName != string.Empty)
                                moduleName = objReportViewRefsInfo.ADReportViewRefName;
                            else
                            {
                                moduleName = Convert.ToString(row[objReportViewRefsInfo.ADReportViewRefFieldModuleName]);
                            }
                            if (moduleName != string.Empty)
                            {
                                string columnName = objReportViewRefsInfo.ADReportViewRefCol;
                                if (objReportViewRefsInfo.ADReportViewRefDrillDownValue != string.Empty)
                                {
                                    referID = Convert.ToInt32(row[objReportViewRefsInfo.ADReportViewRefDrillDownValue]);
                                }
                                Type moduleType = null;
                                List<string> libraryModule = BOSLib.BysGateway.LibraryModule;
                                libraryModule.ForEach(libName =>
                                {
                                    if (moduleType != null)
                                        return;

                                    moduleType = Assembly.LoadFrom(Application.StartupPath + "\\" + libName).GetType("BOSERP.Modules." + moduleName + "." + moduleName + "Module");
                                });
                                if (moduleType != null)
                                {
                                    BaseModuleERP currModule = BOSApp.IsOpenedModule(moduleName) ? ((BaseModuleERP)BOSApp.OpenModules[moduleName]) : (BaseModuleERP)BOSApp.ShowModule(moduleName);
                                    if (currModule == null)
                                        return;
                                    currModule.Invalidate(referID);
                                    currModule.ParentScreen.Activate();
                                }
                                else
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Không tồn tại module: {0} trong hệ thống!", moduleName));
                                }

                            }
                        }
                        if (form == null && objReportViewRefsInfo.ADReportViewRefType == "Report")
                            form = new ReportFormView();
                        if (form != null)
                        {
                            form.DataSource = dsDataSource;
                            form.GridControlName = objReportViewRefsInfo.ADReportViewRefDataSource;
                            form.DataSourceName = objReportViewRefsInfo.ADReportViewRefDataSource;
                            form.Module = module;
                            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByNo(objReportViewRefsInfo.ADReportViewRefName);
                            if (objADTemplatesInfo != null)
                            {
                                form.TemplateName = objADTemplatesInfo.ADTemplateName;
                                form.TemplateID = objADTemplatesInfo.ADTemplateID;
                                form.ArParam = arParam;
                                form.InitParam();
                            }
                            form.GetBranchListByUserPermission();
                            form.InitGridView();
                            form.StartPosition = FormStartPosition.CenterScreen;
                            form.ViewReport(false);
                            form.Top = 1;
                            form.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Lỗi thiết lập tham số cho {0}!\n{1}", objReportViewRefsInfo.ADReportViewRefStoreProc, ex.Message));
                    }
                }
            }
        }
        public static void ShowRefFromModule(BOSList<ADTemplateParamsInfo> lstParam, BusinessObject item, ControlCollection control, string ViewNo, BaseModule module, string fieldClickName)
        {
            ADReportViewRefsController objReportViewRefsController = new ADReportViewRefsController();
            ADReportViewRefParamsController objReportViewRefParamsController = new ADReportViewRefParamsController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataSet dsDataSource = new DataSet();
            ADReportViewRefsInfo objReportViewRefsInfo = objReportViewRefsController.GetViewRefByReportViewNo(ViewNo, fieldClickName);
            if (objReportViewRefsInfo != null)
            {
                List<ADReportViewRefParamsInfo> paraList = objReportViewRefParamsController.GetViewRefParamByReportViewID(objReportViewRefsInfo.ADReportViewRefID);
                if (paraList != null && paraList.Count > 0 || objReportViewRefsInfo.ADReportViewRefType == "Module")
                {
                    object[] arParam = new object[paraList.Count];
                    try
                    {
                        for (int i = 0; i < paraList.Count; i++)
                        {
                            string columnName = paraList[i].ADReportViewRefParamColumns;
                            if (paraList[i].ADReportViewRefParamDataType.Equals("Date") || paraList[i].ADReportViewRefParamDataType.Equals("DateTime"))
                            {
                                object result = null;
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    result = GetParamValueFromListParam(columnName, lstParam);
                                }
                                else if (columnName != string.Empty && dbUtil.GetPropertyValue(item, columnName) != null)
                                {
                                    result = dbUtil.GetPropertyValue(item, columnName);
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    result = GetParamValueFromControl(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                }
                                if (result != null)
                                {
                                    arParam[i] = ConvertParamToDate(paraList[i].ADReportViewRefParamDataType, result);
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.Equals("Number"))
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    if (result != null)
                                    {
                                        arParam[i] = Convert.ToInt32(result != null && result != string.Empty ? result : "0");
                                    }
                                }
                                else if (columnName != string.Empty)
                                {
                                    arParam[i] = Convert.ToInt32(dbUtil.GetPropertyValue(item, columnName));
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromControl(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            if (!paraList[i].ADReportViewRefParamIsDisplay && Convert.ToInt32(result) == 0)
                                                arParam[i] = null;
                                            else
                                                arParam[i] = Convert.ToInt32(result);
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = 0;
                                        }
                                    }
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("bit") ||
                                paraList[i].ADReportViewRefParamDataType.ToLower().Equals("boolean"))
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    if (result != null)
                                    {
                                        arParam[i] = Convert.ToBoolean(result);
                                    }
                                }
                                else if (columnName != string.Empty)
                                {
                                    arParam[i] = Convert.ToBoolean(dbUtil.GetPropertyValue(item, columnName));
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromControl(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            arParam[i] = Convert.ToBoolean(result);
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = false;
                                        }
                                    }
                                }
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("currentuser"))
                            {
                                arParam[i] = BOSApp.CurrentUsersInfo.ADUserID;
                            }
                            else if (paraList[i].ADReportViewRefParamDataType.ToLower().Equals("currentbranch"))
                            {
                                arParam[i] = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                            }
                            else
                            {
                                if (paraList[i].ADReportViewRefParamLookupEdit == "ADTemplateParams")
                                {
                                    object result = GetParamValueFromListParam(columnName, lstParam);
                                    if (result != null)
                                    {
                                        arParam[i] = Convert.ToString(result);
                                    }
                                }
                                else if (columnName != string.Empty)
                                {
                                    arParam[i] = Convert.ToString(dbUtil.GetPropertyValue(item, columnName));
                                }
                                else if (paraList[i].ADReportViewRefParamLookupEdit != string.Empty)
                                {
                                    object result = GetParamValueFromControl(paraList[i].ADReportViewRefParamLookupEdit, paraList[i].ADReportViewRefParamValue, control);
                                    if (result != null)
                                    {
                                        try
                                        {
                                            arParam[i] = result;
                                        }
                                        catch (Exception)
                                        {
                                            arParam[i] = "";
                                        }
                                    }
                                }

                            }
                        }
                        if (objReportViewRefsInfo.ADReportViewRefStoreProc != string.Empty)
                            dsDataSource = SqlDatabaseHelper.RunStoredProcedure(objReportViewRefsInfo.ADReportViewRefStoreProc, arParam);
                        string fortmat = "BOSERP.Modules.Report.{0}";
                        ReportFormView form = null;
                        if (objReportViewRefsInfo.ADReportViewRefType == "Report" && objReportViewRefsInfo.ADReportViewRefName != string.Empty)
                            form = (ReportFormView)BaseClassFactory.GetClass(String.Format(fortmat, objReportViewRefsInfo.ADReportViewRefName.ToString()));

                        else if (objReportViewRefsInfo.ADReportViewRefType == "Module"
                            && (objReportViewRefsInfo.ADReportViewRefName != string.Empty || objReportViewRefsInfo.ADReportViewRefFieldModuleName != string.Empty))
                        {
                            string moduleName = string.Empty;
                            int referID = 0;
                            if (objReportViewRefsInfo.ADReportViewRefName != string.Empty)
                                moduleName = objReportViewRefsInfo.ADReportViewRefName;
                            else
                            {
                                moduleName = Convert.ToString(dbUtil.GetPropertyValue(item, objReportViewRefsInfo.ADReportViewRefFieldModuleName));
                            }
                            if (moduleName != string.Empty)
                            {
                                string columnName = objReportViewRefsInfo.ADReportViewRefCol;
                                if (objReportViewRefsInfo.ADReportViewRefDrillDownValue != string.Empty)
                                {
                                    referID = Convert.ToInt32(dbUtil.GetPropertyValue(item, objReportViewRefsInfo.ADReportViewRefDrillDownValue));
                                }
                                Type moduleType = null;
                                List<string> libraryModule = BOSLib.BysGateway.LibraryModule;
                                libraryModule.ForEach(libName =>
                                {
                                    if (moduleType != null)
                                        return;

                                    moduleType = Assembly.LoadFrom(Application.StartupPath + "\\" + libName).GetType("BOSERP.Modules." + moduleName + "." + moduleName + "Module");
                                });
                                if (moduleType != null)
                                {
                                    BaseModuleERP currModule = BOSApp.IsOpenedModule(moduleName) ? ((BaseModuleERP)BOSApp.OpenModules[moduleName]) : (BaseModuleERP)BOSApp.ShowModule(moduleName);
                                    if (currModule == null)
                                        return;

                                    currModule.Invalidate(referID);
                                    currModule.ParentScreen.Activate();
                                }
                                else
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Không tồn tại module: {0} trong hệ thống!", moduleName));
                                }
                            }
                        }
                        if (form == null && objReportViewRefsInfo.ADReportViewRefType == "Report")
                            form = new ReportFormView();
                        if (form != null)
                        {
                            form.DataSource = dsDataSource;
                            form.GridControlName = objReportViewRefsInfo.ADReportViewRefDataSource;
                            form.DataSourceName = objReportViewRefsInfo.ADReportViewRefDataSource;
                            form.Module = module;
                            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByNo(objReportViewRefsInfo.ADReportViewRefName);
                            if (objADTemplatesInfo != null)
                            {
                                form.TemplateID = objADTemplatesInfo.ADTemplateID;
                                form.TemplateName = objADTemplatesInfo.ADTemplateName;
                                form.ArParam = arParam;
                                form.InitParam();
                            }
                            form.GetBranchListByUserPermission();
                            form.InitGridView();
                            form.StartPosition = FormStartPosition.CenterScreen;
                            form.Top = 1;
                            form.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Lỗi thiết lập tham số cho {0}!\n{1}", objReportViewRefsInfo.ADReportViewRefStoreProc, ex.Message));
                    }
                }
            }
        }
        public static object GetParamValueFromScreen(string type, string controlName, System.Windows.Forms.Form.ControlCollection control)
        {
            object result = null;
            switch (type)
            {
                case "BOSDateEdit":
                    BOSDateEdit param = (BOSDateEdit)control.Find(controlName, true).FirstOrDefault();
                    if (param != null && param.EditValue != null)
                    {
                        result = param.DateTime;
                    }
                    break;
                case "BOSLookupEdit":
                    BOSLookupEdit paramlke = (BOSLookupEdit)control.Find(controlName, true).FirstOrDefault();
                    if (paramlke != null && paramlke.EditValue != null)
                    {
                        result = paramlke.EditValue;
                    }
                    break;
                case "AccObjectLookupEdit":
                    AccObjectLookupEdit paramAcclke = (AccObjectLookupEdit)control.Find(controlName, true).FirstOrDefault();
                    if (paramAcclke != null && paramAcclke.EditValue != null)
                    {
                        string[] obj = paramAcclke.EditValue.ToString().Split(';');
                        if (obj != null && obj.Length > 0)
                            result = obj[0];
                        else result = 0;
                    }
                    break;
                case "BOSTextBox":
                    BOSLookupEdit paramtxt = (BOSLookupEdit)control.Find(controlName, true).FirstOrDefault();
                    if (paramtxt != null && paramtxt.EditValue != null)
                    {
                        result = paramtxt.Text;
                    }
                    break;
                case "BOSMemoEdit":
                    BOSMemoEdit paramMemo = (BOSMemoEdit)control.Find(controlName, true).FirstOrDefault();
                    if (paramMemo != null && paramMemo.EditValue != null)
                    {
                        result = paramMemo.Text;
                    }
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
        public static object GetParamValueFromControl(string type, string controlName, ControlCollection control)
        {
            object result = null;
            switch (type)
            {
                case "BOSDateEdit":
                    BOSDateEdit param = (BOSDateEdit)control[controlName];
                    if (param != null && param.EditValue != null)
                    {
                        result = param.DateTime;
                    }
                    break;
                case "BOSLookupEdit":
                    BOSLookupEdit paramlke = (BOSLookupEdit)control[controlName];
                    if (paramlke != null && paramlke.EditValue != null)
                    {
                        result = paramlke.EditValue;
                    }
                    break;
                case "AccObjectLookupEdit":
                    AccObjectLookupEdit paramAcclke = (AccObjectLookupEdit)control[controlName];
                    if (paramAcclke != null && paramAcclke.EditValue != null)
                    {
                        string[] obj = paramAcclke.EditValue.ToString().Split(';');
                        if (obj != null && obj.Length > 0)
                            result = obj[0];
                        else result = 0;
                    }
                    break;
                case "BOSTextBox":
                    BOSLookupEdit paramtxt = (BOSLookupEdit)control[controlName];
                    if (paramtxt != null && paramtxt.EditValue != null)
                    {
                        result = paramtxt.Text;
                    }
                    break;
                case "BOSMemoEdit":
                    BOSMemoEdit paramMemo = (BOSMemoEdit)control[controlName];
                    if (paramMemo != null && paramMemo.EditValue != null)
                    {
                        result = paramMemo.Text;
                    }
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
        public static object GetParamValueFromListParam(string paramName, BOSList<ADTemplateParamsInfo> lstParam)
        {
            object result = null;
            lstParam.ForEach(o =>
            {
                if (o.ADTemplateParamNo == paramName)
                {
                    result = o.ADTemplateParamValue;
                }
            });
            return result;
        }
        public static DateTime ConvertParamToDate(string type, object value)
        {
            try
            {
                if (type.Equals("Date"))
                    //return DateTime.ParseExact(value.ToString(),
                    //                                  new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None);
                    return DateTime.Parse(value.ToString());
                else if (type.Equals("DateTime"))
                    return DateTime.Parse(value.ToString());
                //"dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                //new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None);
                else
                    return DateTime.MaxValue;
            }
            catch (Exception)
            {
                if (type.Equals("Date"))
                    return DateTime.MaxValue.Date;
                else
                    return DateTime.MaxValue;
            }
        }
    }
}

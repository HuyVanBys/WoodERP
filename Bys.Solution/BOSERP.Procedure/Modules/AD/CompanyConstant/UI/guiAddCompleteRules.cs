using BOSLib;
using BOSLib.Entities;
using DevExpress.Data.Filtering;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.Repository;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiAddCompleteRules : DevExpress.XtraEditors.XtraForm
    {
        string TableName { get; set; }

        public string WhereClause { get; set; }

        public string SqlWhereClause { get; set; }

        public string LinqWhereClause { get; set; }

        public List<GECurrenciesInfo> CurrencyDataSource { get; set; }

        public guiAddCompleteRules(string tableName, string whereClause)
        {
            TableName = tableName;
            WhereClause = whereClause;
            GECurrenciesController controller = new GECurrenciesController();
            DataSet ds = BOSApp.LookupTables[BOSCommon.Constants.TableName.GECurrenyTableName] as DataSet;
            if (ds == null)
            {
                BOSApp.GetLookupTableData(BOSCommon.Constants.TableName.GECurrenyTableName);
            }
            CurrencyDataSource = (List<GECurrenciesInfo>)controller.GetListFromDataSet(ds);
            InitializeComponent();
        }

        private void fld_flcCompleteRules_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            fld_txtViewResult.Text = fld_flcCompleteRules.FilterString;
        }

        private void guiAddCompleteRules_Load(object sender, EventArgs e)
        {
            List<BysTableColumn> schemaColumns = SqlDatabaseHelper.GetTableColumn(TableName).ToList();
            List<string> schemaColumnStrs = SqlDatabaseHelper.GetTableColumn(TableName).Select(o => o.ColumnName).ToList();
            List<AAColumnAliasInfo> aliasTable = BOSApp.LstColumnAlias
                                                       .Where(o => o.AATableName == TableName)
                                                       .ToList();

            FilterColumnCollection columns = new FilterColumnCollection();
            RepositoryItemTextEdit columnEditor = new RepositoryItemTextEdit();
            AAColumnAliasInfo alias = new AAColumnAliasInfo();
            string caption;
            schemaColumns.ForEach(o =>
            {
                caption = o.ColumnName;
                alias = aliasTable.Where(als => als.AAColumnAliasName == o.ColumnName).FirstOrDefault();
                if (alias == null)
                    return;

                caption = alias.AAColumnAliasCaption;
                Type columnType = o.GetAssemblyDbType();
                columns.Add(new UnboundFilterColumn(caption, o.ColumnName, columnType, columnEditor, FilterColumnClauseClass.Generic));
            });
            fld_flcCompleteRules.SetFilterColumnsCollection(columns);
            fld_flcCompleteRules.FilterString = WhereClause;
            fld_txtViewResult.Text = WhereClause;
            
        }

        private void fld_flcCompleteRules_BeforeShowValueEditor(object sender, ShowValueEditorEventArgs e)
        {

            var configValuePair = e.PropertyName.Substring(2, e.PropertyName.Length - 2);//e.. .FieldName;
            if (configValuePair.EndsWith("Combo"))
                configValuePair = configValuePair.Substring(0, configValuePair.Length - 5);

            if (ADConfigValueUtility.ConfigValues.Tables[configValuePair] != null)
            {
                RepositoryItemLookUpEdit columnEditor = new RepositoryItemLookUpEdit();
                columnEditor.DataSource = ADConfigValueUtility.ConfigValues.Tables[configValuePair];
                columnEditor.ValueMember = "Value";
                columnEditor.DisplayMember = "Text";
                columnEditor.NullText = "";
                LookUpColumnInfo column = new LookUpColumnInfo();
                column.Caption = ComponentLocalizedResources.Name;
                column.FieldName = "Text";
                column.Width = 100;
                LookUpColumnInfo exitCol = columnEditor.Columns.Where(o => o.FieldName == column.FieldName).FirstOrDefault();
                if (exitCol == null)
                    columnEditor.Columns.Add(column);
                columnEditor.PopupWidth = column.Width;
                columnEditor.ShowHeader = false;
                e.CustomRepositoryItem = columnEditor;
            }
            else if (e.PropertyType == typeof(DateTime))
            {
                e.CustomRepositoryItem = new RepositoryItemDateEdit();
            }
            else if(e.PropertyName == "FK_GECurrencyID")
            {
                RepositoryItemLookUpEdit columnEditor = new RepositoryItemLookUpEdit();
                columnEditor.DataSource = CurrencyDataSource;
                columnEditor.ValueMember = "GECurrencyID";
                columnEditor.DisplayMember = "GECurrencyName";
                columnEditor.NullText = "";
                LookUpColumnInfo column = new LookUpColumnInfo();
                column.Caption = "Loại tiền tệ";
                column.FieldName = "GECurrencyName";
                column.Width = 100;
                LookUpColumnInfo exitCol = columnEditor.Columns.Where(o => o.FieldName == column.FieldName).FirstOrDefault();
                if (exitCol == null)
                    columnEditor.Columns.Add(column);
                columnEditor.PopupWidth = column.Width;
                e.CustomRepositoryItem = columnEditor;
            }
        }

        private void fld_btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            WhereClause = fld_flcCompleteRules.FilterString;
            SqlWhereClause = CriteriaToWhereClauseHelper.GetMsSqlWhere(fld_flcCompleteRules.FilterCriteria);
            LinqWhereClause = CriteriaToWhereClauseHelper.GetDynamicLinqWhere(fld_flcCompleteRules.FilterCriteria);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
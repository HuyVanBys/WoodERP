using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AliasConfig
{
    public partial class STFieldFormatsGridControl : BOSGridControl
    {

        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public string CurrentTableFilter { get; set; }

        List<AAColumnAliasInfo> LstColumnName { get; set; }

        public override void InitGridControlDataSource()
        {
            AliasConfigEntities entity = (AliasConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FieldFormatList;
            DataSource = bds;
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "STFieldFormatTableName", "Tên bảng");
            AddGridColumn(strTableName, "STFieldFormatColumnName", "Tên cột(Hiển thị)");
            AddGridColumn(strTableName, "ColumnName", "Tên cột (Database)");
            AddGridColumn(strTableName, "STFieldFormatModuleName", "Tên Module", "STModules", "STModuleDescription", "STModuleName");
            AddGridColumn(strTableName, "STFieldFormatGroupID", "Kiểu hiển thị", "STFieldFormatGroups", "STFieldFormatGroupMaskEdit", "STFieldFormatGroupID");
            AddGridColumn(strTableName, "STChangeByCurrency", "Thay đổi theo tiền tệ");
            AddGridColumn(strTableName, "STChangeByDepartment", "Thay đổi theo loại hàng");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "", string filteredColumn = "", string filteredValues = "")
        {

            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAFilteredColumn = filteredColumn,
                AAFilteredValues = filteredValues,
                AAAllowDummy = true,
                Visible = true
            });
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            LstColumnName = GetColumnList();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
            }
            GridColumn gridColumn = gridView.Columns["STFieldFormatColumnName"];
            if (gridColumn != null)
            {
                RepositoryItemBOSLookupEdit repositoryItemLookupEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookupEdit.DisplayMember = "AAColumnAliasCaption";
                repositoryItemLookupEdit.ValueMember = "AAColumnAliasName";
                repositoryItemLookupEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookupEdit.SearchMode = SearchMode.AutoFilter;
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("AATableName", "Tên bảng"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("AAColumnAliasName", "Tên cột"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("AAColumnAliasCaption", "Hiển thị"));
                repositoryItemLookupEdit.NullText = string.Empty;
                repositoryItemLookupEdit.DataSource = LstColumnName;
                repositoryItemLookupEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(RepositoryItemLookupEdit_QueryPopUp);
                gridColumn.ColumnEdit = repositoryItemLookupEdit;
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ColumnName"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = false;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            gridView.OptionsView.ShowFooter = true;
            return gridView;
        }

        private void RepositoryItemLookupEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            RepositoryItemBOSLookupEdit lke = new RepositoryItemBOSLookupEdit();
            lke.DataSource = null;
            lke.DataSource = LstColumnName.Where(o => o.AATableName == CurrentTableFilter).ToList();
            lke.DisplayMember = "AAColumnAliasCaption";
            lke.ValueMember = "AAColumnAliasName";
        }

        public List<AAColumnAliasInfo> GetColumnList()
        {
            return BOSApp.LstColumnAlias.Select(o => new AAColumnAliasInfo() { AATableName = o.AATableName, AAColumnAliasName = o.AAColumnAliasName, AAColumnAliasCaption = o.AAColumnAliasCaption }).Distinct().ToList();
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, "STFieldFormatTableName", CurrentTableFilter);
            gridView.SetRowCellValue(e.RowHandle, "STChangeByCurrency", false);
            gridView.SetRowCellValue(e.RowHandle, "STChangeByDepartment", false);
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            STFieldFormatsInfo item = (STFieldFormatsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "STFieldFormatColumnName")
            {
                item.ColumnName = item.STFieldFormatColumnName;
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AliasConfigModule)Screen.Module).DeleteFeildFormatItem();
            }
        }
    }
}

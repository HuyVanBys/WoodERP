using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class ICAlternativeMaterialMultisGridControl : BOSGridControl
    {
        private List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        private List<MMMaterialDepartmentsInfo> MaterialDepartList { get; set; }
        private List<ICProductAlternativesInfo> ProductAlternativeList { get; set; }

        private string[] arrAllowChange = new string[] { "ICProductHeight", "ICProductLength", "ICProductWidth" };
        public int ICProductID { get; set; }
        public bool IsAlterOverConfigMaterial { get; set; }
        public void InvalidateDataSource(List<ICProductAlternativesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            ProductAlternativeList = dataSource;
            bds.DataSource = ProductAlternativeList;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "ICProductHeight", "Dày");
            AddGridColumn(strTableName, "ICProductWidth", "Rộng");
            AddGridColumn(strTableName, "ICProductLength", "Dài");
            AddGridColumn(strTableName, "ICProductAlternativeDepreciationRate", "Tỉ số tiêu hao");
            AddGridColumn(strTableName, "FK_ICProductAlternativeChildID", "Mã vật tư");
            AddGridColumn(strTableName, "ICProductAlternativeName", "Tên thay thế");
            AddGridColumn(strTableName, "ICProductAlternativeDesc", "Mô tả");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT");
            AddGridColumn(strTableName, "Selected", "Chọn");
            AddGridColumn(strTableName, "IsChangeAlternativeProduct", "Thay thế vật tư");
            AddGridColumn(strTableName, "ICProductAlternativeQty", "Tỉ lệ (1:?)");
            AddGridColumn(strTableName, "IsChangeDepreciationRate", "Thay đổi Tỉ số tiêu hao");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "ICProductAlternativeQty"
                    || e.Column.FieldName == "ICProductAlternativeDepreciationRate"
                    || e.Column.FieldName == "ICProductAlternativeProductQty")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                    e.Appearance.BackColor = Color.PaleTurquoise;
                    e.Appearance.BackColor2 = Color.PaleTurquoise;
                }
            }
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            MaterialDepartList = (new MMMaterialDepartmentsController()).GetAllMaterialDepartment();
            GridColumn gridColumn = gridView.Columns["FK_ICProductAlternativeChildID"];
            if (gridColumn != null)
            {
                RepositoryItemBOSLookupEdit repositoryItemLookupEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookupEdit.DisplayMember = "ICProductNo";
                repositoryItemLookupEdit.ValueMember = "ICProductID";
                repositoryItemLookupEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookupEdit.SearchMode = SearchMode.AutoFilter;
                repositoryItemLookupEdit.NullText = string.Empty;
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repositoryItemLookupEdit.DataSource = ((BatchProductSheduleModule)Screen.Module).GetWoodIngredient(MaterialDepartList);
                repositoryItemLookupEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                repositoryItemLookupEdit.MaxLength = 1000;
                gridColumn.ColumnEdit = repositoryItemLookupEdit;
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_ICMeasureUnitID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                gridColumn.ColumnEdit = rpMeasureUnit;
            }
            gridColumn = gridView.Columns["ICProductAlternativeQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, true, "n2");
            }
            gridColumn = gridView.Columns["Selected"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICProductAlternativeDepreciationRate"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, true, "n2");
            }
            gridColumn = gridView.Columns["ICProductHeight"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n2");
            }
            gridColumn = gridView.Columns["ICProductWidth"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n2");
            }
            gridColumn = gridView.Columns["ICProductLength"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n2");
            }
            gridColumn = gridView.Columns["IsChangeAlternativeProduct"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["IsChangeDepreciationRate"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = false;
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }

        public void UpdateView()
        {
            GridView gridView = (GridView)MainView;
            foreach (GridColumn column in gridView.Columns)
            {
                if (!arrAllowChange.Contains(column.FieldName))
                    continue;

                column.OptionsColumn.AllowEdit = IsAlterOverConfigMaterial;
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductAlternativesInfo item = (ICProductAlternativesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductAlternativeChildID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
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

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICProductAlternativesInfo item = (ICProductAlternativesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item != null && e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "FK_ICProductAlternativeChildID")
                {
                    if (ProductAlternativeList.Where(o => o.FK_ICProductAlternativeChildID == (int)e.Value).Any())
                    {
                        e.ErrorText = "Vật tư đã tồn tại trong danh sách";
                        e.Valid = false;
                    }
                }
                if (gridView.FocusedColumn.FieldName == "ICProductAlternativeQty" && !item.IsChangeAlternativeProduct)
                {
                    e.ErrorText = "Thông tin thay đổi không phù hợp.";
                    e.Valid = false;
                }
                if (gridView.FocusedColumn.FieldName == "ICProductAlternativeDepreciationRate" && !item.IsChangeDepreciationRate)
                {
                    e.ErrorText = "Thông tin thay đổi không phù hợp.";
                    e.Valid = false;
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)MainView;
            if (e.KeyCode == Keys.Delete)
            {
                gridView.DeleteSelectedRows();
                gridView.RefreshData();
            }
        }
    }
}

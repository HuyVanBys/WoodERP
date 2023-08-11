using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.EmployeeLeaveCalculate
{
    public partial class EmployeeLeaveCalculateGridControl : BOSGridControl
    {
        /// <summary>
        /// </summary>
        public int RowHandle { get; set; }

        /// <summary>
        /// </summary>
        public DateTime ViewDate { get; set; }
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }
        public override void InitGridControlDataSource()
        {
            EmployeeLeaveCalculateEntities entity = (EmployeeLeaveCalculateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeLRegList;
            DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();

        }

        public void UpdateDateAlias()
        {
        }


        private void BandedView_RowClick(object sender, RowClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                //HREmployeeLeaveCalculatesInfo objEmployeeLeaveCalculatesInfo = (HREmployeeLeaveCalculatesInfo)gridView.GetRow(e.RowHandle);
                ////Update time sheet total quantity
                //((EmployeeLeaveCalculateModule)Screen.Module).UpdateTotalEmployeeLeaveCalculates(objEmployeeLeaveCalculatesInfo);
            }
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;
            if (!bandedView.IsValidRowHandle(e.RowHandle))
                return;
            int parent = bandedView.GetParentRowHandle(e.RowHandle);
            if (bandedView.IsGroupRow(parent))
            {
                for (int i = 0; i < bandedView.GetChildRowCount(parent); i++)
                    if (bandedView.GetChildRowHandle(parent, i) == e.RowHandle)
                        e.Appearance.BackColor = i % 2 == 0 ? Color.White : Color.WhiteSmoke;
            }
            else e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.White : Color.WhiteSmoke;
            e.Appearance.ForeColor = Color.Black;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        public BandedGridColumn ConvertToBandedColumn(GridColumn gridColumn, bool isAllowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = gridColumn.Name;
            bandedColumn.FieldName = gridColumn.FieldName;
            bandedColumn.Caption = gridColumn.Caption;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Visible = true;
            bandedColumn.Width = gridColumn.Width;
            return bandedColumn;
        }

        /// <summary>
        /// Init the repository lookup edit for a banded column
        /// </summary>        
        /// <param name="column">Banded column</param>
        /// <param name="dataSource">Data source of repository</param>
        public void InitColumnRepository(BandedGridColumn column, List<HRTimeSheetParamsInfo> dataSource)
        {
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.DataSource = dataSource;
            rep.DisplayMember = "HRTimeSheetParamNo";
            rep.ValueMember = "HRTimeSheetParamNo";
            rep.ShowHeader = false;
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.NullText = string.Empty;
            LookUpColumnInfo lookupColumn = new LookUpColumnInfo();
            lookupColumn.FieldName = "HRTimeSheetParamNo";
            rep.Columns.Add(lookupColumn);
            column.ColumnEdit = rep;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HREmployeeStartWorkingDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HREmployeeLRegYear"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            return gridView;
        }
    }
}

using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRArrangementShift
{
    public partial class HREmployeeArrangementShiftsGridControl : BOSGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }
        /// <summary>
        /// Gets or sets the row hanle of current row selected
        /// </summary>
        public int RowHandle { get; set; }
        public override void InitGridControlDataSource()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeArrangementShiftList;
            DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            //Init banded view and make it the main view
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            ShowOnlyPredefinedDetails = true;
            UseEmbeddedNavigator = false;
        }

        /// <summary>
        /// Initialize BandedGridView
        /// </summary>
        /// <param name="gridView"></param>
        /// <returns></returns>
        private BandedGridView InitializeBandedGridView(GridView gridView)
        {
            //Creat a banded grid view
            BandedGridView bandedView = new BandedGridView();
            GridBand gridBand1 = new GridBand();
            GridBand gridBand2 = new GridBand();
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            gridBand1,
            gridBand2});
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedColumn(gridView.Columns[i], false)});
            }
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            //GridBand1
            gridBand1.Caption = TimeSheetLocalizedResources.EmployeesInfo;
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.Name = "gridBand1";

            //GridBand2
            gridBand2.Caption = TimeSheetLocalizedResources.DayList;
            gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand2.Name = "gridBand2";

            // Assigning columns to bands
            GridColumn column = gridView.Columns["HREmployeeCardNumber"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 40;
            }
            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                BandedGridColumn bandedColumn = ConvertToBandedColumn(column, false);
                bandedColumn.OwnerBand = gridBand1;
                bandedColumn.Width = 150;
            }

            column = gridView.Columns["HRDepartmentRoomName"];
            if (column != null)
                ConvertToBandedColumn(column, false).OwnerBand = gridBand1;

            column = gridView.Columns["HRDepartmentName"];
            if (column != null)
                ConvertToBandedColumn(column, false).OwnerBand = gridBand1;

            column = gridView.Columns["HRDepartmentRoomGroupName"];
            if (column != null)
                ConvertToBandedColumn(column, false).OwnerBand = gridBand1;

            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            List<HRWorkingShiftsInfo> commonParams = objWorkingShiftsController.GetWorkingShiftListFromDataSet(objWorkingShiftsController.GetAllAliveObjects()).Where(o => o.FK_HRWorkingShiftID == 0).ToList();
            commonParams.Insert(0, new HRWorkingShiftsInfo());

            for (int i = 1; i <= 31; i++)
            {
                column = gridView.Columns[String.Format("{0}{1}", "HREmployeeArrangementShiftDate", i.ToString())];
                if (column != null)
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepository(bandedColumn, commonParams);
                    bandedColumn.OwnerBand = gridBand2;
                    bandedColumn.Width = 50;
                }
            }

            bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            return bandedView;
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;
            if (!bandedView.IsValidRowHandle(e.RowHandle))
                return;
            // fill column if holiday
            List<string> columnFieldNameList = ((HRArrangementShiftModule)Screen.Module).GetColumnFieldNameByTypeEndOfWeek();
            if (columnFieldNameList.Count > 0)
            {
                for (int i = 0; i < columnFieldNameList.Count; i++)
                {
                    if (e.Column.FieldName.Equals(columnFieldNameList[i]))
                    {
                        // end of week and holiday
                        //if (e.Appearance.BackColor.Equals(Color.LightPink))
                        //    e.Appearance.BackColor = Color.Red;
                        //else
                        //    e.Appearance.BackColor = Color.LightGreen;
                        e.Appearance.BackColor = Color.Red;
                    }
                }
            }
        }

        public void InitColumnRepository(BandedGridColumn column, List<HRWorkingShiftsInfo> dataSource)
        {
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.DataSource = dataSource;
            rep.DisplayMember = "HRWorkingShiftName";
            rep.ValueMember = "HRWorkingShiftID";
            rep.ShowHeader = false;
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.NullText = string.Empty;
            LookUpColumnInfo lookupColumn = new LookUpColumnInfo();
            lookupColumn.FieldName = "HRWorkingShiftName";
            rep.Columns.Add(lookupColumn);
            column.ColumnEdit = rep;

            rep.EditValueChanged += new EventHandler(repositoryItemLookupEdit__EditValueChanged);
            this.RepositoryItems.Add(rep);
        }

        private void repositoryItemLookupEdit__EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo = (HREmployeeArrangementShiftsInfo)gridview.GetRow(gridview.FocusedRowHandle);
            int id = 0;
            //if (lke.OldEditValue != lke.EditValue)
            //{
            //    if (MessageBox.Show("Bạn có muốn thay đổi khoản thời gian xếp ca theo thời gian đã chọn không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        lke.EditValue = lke.OldEditValue;
            //        //Int32.TryParse(lke.EditValue.ToString(), out id);
            //        //objEmployeeArrangementShiftsInfo.FK_ = id;
            //    }
            //    //else
            //    //{
            //    //    Int32.TryParse(lke.OldEditValue.ToString(), out id);
            //    //    objEmployeeArrangementShiftsInfo.FK_HRArrangementShiftID = id;
            //    //    lke.EditValue = lke.OldEditValue;
            //    //}
            //}
            //((HRArrangementShiftModule)Screen.Module).UpdateArrangementShift(objEmployeeArrangementShiftsInfo);
        }

        private void BandedView_RowClick(object sender, RowClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }

        private void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((HRArrangementShiftModule)Screen.Module).RemoveEmployeeFromArrangementShiftList();
            }
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo = (HREmployeeArrangementShiftsInfo)gridView.GetRow(e.RowHandle);
                ((HRArrangementShiftModule)Screen.Module).UpdateArrangementShift(objEmployeeArrangementShiftsInfo);
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HRDepartmentRoomName;
            column.FieldName = "HRDepartmentRoomName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HRDepartmentName;
            column.FieldName = "HRDepartmentName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = TimeSheetLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổ";
            column.FieldName = "HRDepartmentRoomGroupName";
            gridView.Columns.Add(column);

            int numDays = ((HRArrangementShiftModule)Screen.Module).NumOfDayInMonth();
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            for (int i = 1; i <= numDays; i++)
            {
                GridColumn columnDays = new GridColumn();
                DateTime dt = objArrangementShiftsInfo.HRArrangementShiftFromDate.Date.AddDays(i - 1);
                columnDays.Caption = dt.ToString("dd/MM");
                columnDays.FieldName = String.Format("{0}{1}", "HREmployeeArrangementShiftDate", i.ToString());
                gridView.Columns.Add(columnDays);
            }
        }

        /// <summary>
        /// Convert GridColumn to BandedGridColumn
        /// </summary>
        /// <param name="gridColumn">Column of GridView</param>
        /// <param name="isAllowEdit">Allow column edit or not</param>
        /// <returns></returns>
        public BandedGridColumn ConvertToBandedColumn(GridColumn gridColumn, bool isAllowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = gridColumn.Name;
            bandedColumn.FieldName = gridColumn.FieldName;
            bandedColumn.Caption = gridColumn.Caption;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Visible = true;
            bandedColumn.Width = gridColumn.Width;
            if (isAllowEdit)
            {
                RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
                rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                rep.Mask.EditMask = "n2";
                rep.Mask.UseMaskAsDisplayFormat = true;
                bandedColumn.ColumnEdit = rep;
            }
            return bandedColumn;
        }
    }
}

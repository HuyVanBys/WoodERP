using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.DormitoryCost
{
    public class HRDormitoryCostItemsGridControl : BOSGridControl
    {
        public GridView GridViewMain { get; set; }

        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            DormitoryCostEntities entity = (DormitoryCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DormitoryCostItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            //foreach (GridColumn column in gridView.Columns)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    if (column.FieldName == "FK_HRDormitoryID")
            //        column.OptionsColumn.AllowEdit = false;
            //    if (column.FieldName == "HRDormitoryCostItemTotalAmount")
            //        column.OptionsColumn.AllowEdit = false;
            //    if (column.FieldName == "HRDormitoryCostItemNumberElectricity")
            //        column.OptionsColumn.AllowEdit = false;
            //    if (column.FieldName == "HRDormitoryCostItemDormitoryName")
            //        column.OptionsColumn.AllowEdit = false;
            //    if (column.FieldName == "HRDormitoryCostItemNumberWater")
            //        column.OptionsColumn.AllowEdit = false;


            //}
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            //Init banded view and make it the main view
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
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
            GridBand gridBand3 = new GridBand();
            GridBand gridBand4 = new GridBand();
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            gridBand1,
            gridBand2,
            gridBand3,
            gridBand4});
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedGridColumn(gridView.Columns[i], false)});
            }
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowChildrenInGroupPanel = false;
            //GridBand1
            gridBand1.Caption = "Thông tin nhân viên";
            //gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.Name = "gridBand1";

            //GridBand2
            gridBand2.Caption = "Tiền điện";
            gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand2.Name = "gridBand2";

            //GridBand3
            gridBand3.Caption = "Tiền nước";
            gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand3.Name = "gridBand3";

            //GridBand4
            gridBand4.Caption = "Khác";
            gridBand4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand4.Name = "gridBand4";

            // Assigning columns to bands
            GridColumn column;

            column = gridView.Columns["HRDormitoryNo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            column = gridView.Columns["HRDormitoryCostItemDormitoryName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, true);
            }

            column = gridView.Columns["HRDormitoryCostItemStartNumber"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand2, true, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemEndNumber"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand2, true, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemNumberElectricity"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand2, false, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemTotalAmount"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand2, false, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemWaterStartNumber"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand3, true, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemWaterEndNumber"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand3, true, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemNumberWater"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand3, false, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemWaterCost"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand3, false, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemDormitoryCost"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand4, true, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemGarbageCost"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand4, true, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemInternetCost"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand4, true, "n0");
            }

            column = gridView.Columns["HRDormitoryCostItemOrtherCost"];
            if (column != null)
            {
                CreateNewColumnAndFormat(column, gridBand4, true, "n0");
            }

            bandedView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(BandedView_CustomColumnDisplayText);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            return bandedView;
        }

        protected void BandedView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ((DormitoryCostModule)Screen.Module).ChangeItemFromDormitoryCostItemsList();
        }

        protected void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((DormitoryCostModule)Screen.Module).DeleteItemFromRegisterDormitoryItemsList();
            }
        }

        private void BandedView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HREmployeeID")
            {
                if (e.Value != null)
                {
                    int employeeID = int.Parse(e.Value.ToString());
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    string employeeNo = objEmployeesController.GetObjectNoByID(employeeID);
                    if (employeeNo != null)
                    {
                        e.DisplayText = employeeNo;
                    }
                }
            }
            if (e.Column.FieldName == "HRRegisterDormitoryItemEmployeeLevelID")
            {
                if (e.Value != null)
                {
                    int levelID = int.Parse(e.Value.ToString());
                    HRLevelsController objLevelsController = new HRLevelsController();
                    string levelName = objLevelsController.GetObjectNameByID(levelID);
                    if (levelName != null)
                    {
                        e.DisplayText = levelName;
                    }
                }
            }
        }

        public BandedGridColumn ConvertToBandedGridColumn(GridColumn gridColumn, bool isAllowEdit)
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

        private BandedGridColumn CreateNewColumn(GridColumn column, GridBand owner, bool allowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.Width = column.Width;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        private BandedGridColumn CreateNewColumnAndFormat(GridColumn column, GridBand owner, bool allowEdit, string format)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.Width = column.Width;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;
            RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = format;
            rep.Mask.UseMaskAsDisplayFormat = true;
            bandedColumn.ColumnEdit = rep;
            if (format != string.Empty)
            {
                bandedColumn.DisplayFormat.FormatType = FormatType.Numeric;
                bandedColumn.DisplayFormat.FormatString = format;
            }
            return bandedColumn;
        }
    }
}

using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.HREmployeeWorkSchedule
{
    public partial class HREmployeeWorkScheduleItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeWorkScheduleList;
            DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }

            GridColumn column = gridView.Columns["HREmployeeWorkScheduleItemDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit rep = (RepositoryItemBOSLookupEdit)column.ColumnEdit;
                //rep.Columns.Clear();
                //LookUpColumnInfo info = new LookUpColumnInfo();
                //info.FieldName = "HREmployeeNo";
                //info.Caption = "Mã nhân viên";
                //rep.Columns.Add(info);

                //info = new LookUpColumnInfo();
                //info.FieldName = "HREmployeeCardNumber";
                //info.Caption = "Mã ID";
                //rep.Columns.Add(info);

                //info = new LookUpColumnInfo();
                //info.FieldName = "HREmployeeName";
                //info.Caption = "Tên nhân viên";
                //rep.Columns.Add(info);
                //rep.BestFitMode = BestFitMode.BestFitResizePopup;
                //rep.BestFit();
            }

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã nhân viên";
            column.FieldName = "HREmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HREmployeeWorkScheduleModule)Screen.Module).RemoveEmployeeFromList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();
            if (e.Column.FieldName == "FK_HREmployeeID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(value);
                        if (objEmployeesInfo != null)
                        {
                            e.DisplayText = objEmployeesInfo.HREmployeeName;
                        }
                    }
                }
            }
        }
    }
}

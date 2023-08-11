using BOSCommon;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class ARSalesmansGridControl : BOSComponent.BOSGridControl
    {
        public List<ARSalesmansInfo> SalesmansList;

        public void InvalidateGridControlDataSource(List<ARSalesmansInfo> salesmansList)
        {
            SalesmansList = salesmansList;
            BindingSource bds = new BindingSource();
            bds.DataSource = SalesmansList;
            this.DataSource = bds;
            this.RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit HREmployeeIDLookUpEdit = new RepositoryItemLookUpEdit();
                HREmployeeIDLookUpEdit.DisplayMember = "HREmployeeName";
                HREmployeeIDLookUpEdit.ValueMember = "HREmployeeID";
                HREmployeeIDLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                HREmployeeIDLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                HREmployeeIDLookUpEdit.NullText = string.Empty;
                HREmployeeIDLookUpEdit.Columns.Add(new LookUpColumnInfo("HREmployeeName", "Tên người bán"));
                HREmployeeIDLookUpEdit.DataSource = GetDataSourceForEmployeeLookupEdit();
                HREmployeeIDLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(HREmployeeIDLookUpEdit_QueryPopUp);
                //HREmployeeIDLookUpEdit.CloseUp += new CloseUpEventHandler(HREmployeeIDLookUpEdit_CloseUp);
                column.ColumnEdit = HREmployeeIDLookUpEdit;
            }

            column = gridView.Columns["ARSalesmanCommissionPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            return gridView;
        }

        void HREmployeeIDLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (lookUpEdit != null)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                List<HREmployeesInfo> employees =
                    (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController
                        .GetAllEmployeesForLookupControl());
                lookUpEdit.Properties.DataSource = employees;
            }
        }

        public List<HREmployeesInfo> GetDataSourceForEmployeeLookupEdit()
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employees =
                (List<HREmployeesInfo>)objEmployeesController.GetListFromDataSet(objEmployeesController
                    .GetAllEmployeesForLookupControl());
            return employees;
        }

        public void HREmployeeIDLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;

            if (lookUpEdit != null && lookUpEdit.OldEditValue != e.Value)
            {
                ARSalesmansInfo item = (ARSalesmansInfo)gridView.GetRow(gridView.FocusedRowHandle);
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(Convert.ToInt32(e.Value));

                item.ARSalesmanName = objEmployeesInfo != null ? objEmployeesInfo.HREmployeeName : string.Empty;
                item.ARSalesmanType = SalesmanType.SubSeller.ToString();
                this.RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)MainView;
            if (e.KeyCode == Keys.Delete)
            {
                ARSalesmansInfo item = (ARSalesmansInfo)gridView.GetRow(gridView.FocusedRowHandle);
                SalesmansList.Remove(item);
                this.RefreshDataSource();
            }
        }

    }
}

using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.CompanyConstant
{
    public partial class EmployeeSalaryConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeSalaryConfigList;
            this.DataSource = bds;

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;

                //if (column.FieldName == "FK_HRDepartmentID")
                //{
                //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //    repositoryItemLookUpEdit.DisplayMember = "HRDepartmentName";
                //    repositoryItemLookUpEdit.ValueMember = "HRDepartmentID";
                //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //    repositoryItemLookUpEdit.NullText = string.Empty;
                //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban"));
                //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentName", "Tên phòng ban"));
                //    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                //    column.ColumnEdit = repositoryItemLookUpEdit;
                //}

                if (column.FieldName == "FK_HRDepartmentRoomID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "HRDepartmentRoomName";
                    repositoryItemLookUpEdit.ValueMember = "HRDepartmentRoomID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomNo", "Mã bộ phận"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomName", "Tên bộ phận"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repHRDepartmentRoomLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "FK_HRDepartmentRoomGroupItemID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "HRDepartmentRoomGroupItemName";
                    repositoryItemLookUpEdit.ValueMember = "HRDepartmentRoomGroupItemID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomGroupItemNo", "Mã tổ"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tên tổ"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repDepartmentRoomGroupItemLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }

                //if (column.FieldName == "FK_HRLevelID")
                //{
                //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //    repositoryItemLookUpEdit.DisplayMember = "HRLevelName";
                //    repositoryItemLookUpEdit.ValueMember = "HRLevelID";
                //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //    repositoryItemLookUpEdit.NullText = string.Empty;
                //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRLevelNo", "Mã vị trí"));
                //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRLevelName", "Tên vị trí"));
                //    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repLevelLookUpEdit_QueryPopUp);
                //    column.ColumnEdit = repositoryItemLookUpEdit;
                //}
            }
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HRDepartmentRoomGroupItemsController objDepartmenGroupItemtsController = new HRDepartmentRoomGroupItemsController();
            HRLevelsController objLevelsController = new HRLevelsController();
            if (e.Column.FieldName == "FK_HRDepartmentRoomGroupItemID")
            {
                if (e.Value != null)
                {
                    int DepartmentRoomGroupItemID = int.Parse(e.Value.ToString());
                    HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)objDepartmenGroupItemtsController.GetObjectByID(DepartmentRoomGroupItemID);
                    if (objDepartmentRoomGroupItemsInfo != null)
                        e.DisplayText = objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemName;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
            //if (e.Column.FieldName == "FK_HRDepartmentID")
            //{
            //    if (e.Value != null)
            //    {
            //        int departmentID = int.Parse(e.Value.ToString());
            //        HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(departmentID);
            //        if (objDepartmentsInfo != null)
            //            e.DisplayText = objDepartmentsInfo.HRDepartmentName;
            //        else
            //            e.DisplayText = "";
            //    }
            //    else
            //        e.DisplayText = "";
            //}
            if (e.Column.FieldName == "FK_HRDepartmentRoomID")
            {
                if (e.Value != null)
                {
                    int DepartmentRoomID = int.Parse(e.Value.ToString());
                    HRDepartmentRoomsInfo objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(DepartmentRoomID);
                    if (objDepartmentRoomsInfo != null)
                        e.DisplayText = objDepartmentRoomsInfo.HRDepartmentRoomName;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }

            //if (e.Column.FieldName == "FK_HRLevelID")
            //{
            //    if (e.Value != null)
            //    {
            //        int LevelID = int.Parse(e.Value.ToString());
            //        HRLevelsInfo objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(LevelID);
            //        if (objLevelsInfo != null)
            //            e.DisplayText = objLevelsInfo.HRLevelName;
            //        else
            //            e.DisplayText = "";
            //    }
            //    else
            //        e.DisplayText = "";
            //}
        }

        public void repDepartmentRoomGroupItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            HRDepartmentRoomGroupItemsController objDepartmentsController = new HRDepartmentRoomGroupItemsController();
            List<HRDepartmentRoomGroupItemsInfo> departmentList = new List<HRDepartmentRoomGroupItemsInfo>();

            if (departmentList != null)
            {
                int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                int DepartmentID = 0;
                int DepartmentRoomID = 0;
                if (gridView.FocusedRowHandle >= 0 && departmentList != null)
                {
                    HREmployeeSalaryConfigsInfo objEmployeeSalaryConfigsInfo = (HREmployeeSalaryConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objEmployeeSalaryConfigsInfo != null && objEmployeeSalaryConfigsInfo.FK_HRDepartmentID > 0)
                    {
                        branchID = objEmployeeSalaryConfigsInfo.FK_BRBranchID;
                        DepartmentID = objEmployeeSalaryConfigsInfo.FK_HRDepartmentID;
                        DepartmentRoomID = objEmployeeSalaryConfigsInfo.FK_HRDepartmentRoomID;

                    }
                }
                departmentList = objDepartmentsController.GetBySomeConditions(branchID, DepartmentID, DepartmentRoomID);
                if (departmentList != null) departmentList.Insert(0, new HRDepartmentRoomGroupItemsInfo());
                lookUpEdit.Properties.DataSource = departmentList;


            }
            lookUpEdit.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            lookUpEdit.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedEmployeeSalaryConfig();
            }
        }
        #region old code
        //public void repLevelLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    HRLevelsController objLevelsController = new HRLevelsController();
        //    List<HRLevelsInfo> LevelList = new List<HRLevelsInfo>();
        //    LevelList = objLevelsController.GetAllList();
        //    if (LevelList != null)
        //    {
        //        if (LevelList != null) LevelList.Insert(0, new HRLevelsInfo());
        //        lookUpEdit.Properties.DataSource = LevelList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "HRLevelName";
        //    lookUpEdit.Properties.ValueMember = "HRLevelID";
        //}
        //public void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
        //    List<HRDepartmentsInfo> departmentList = new List<HRDepartmentsInfo>();
        //    departmentList = objDepartmentsController.GetAllList();
        //    if (departmentList != null)
        //    {
        //        int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        //        if (branchID > 0)
        //            departmentList = departmentList.Where(x => x.FK_BRBranchID == branchID).ToList();
        //        if (departmentList != null) departmentList.Insert(0, new HRDepartmentsInfo());
        //        lookUpEdit.Properties.DataSource = departmentList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "HRDepartmentName";
        //    lookUpEdit.Properties.ValueMember = "HRDepartmentID";
        //}
        public void repHRDepartmentRoomLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            HRDepartmentRoomsController objDepartmentsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> departmentList = new List<HRDepartmentRoomsInfo>();
            departmentList = objDepartmentsController.GetRoomListForLookup();
            if (departmentList != null)
            {
                int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                if (branchID > 0)
                    departmentList = departmentList.Where(x => x.FK_BRBranchID == branchID).ToList();
                if (gridView.FocusedRowHandle >= 0 && departmentList != null)
                {
                    HREmployeeSalaryConfigsInfo objEmployeeSalaryConfigsInfo = (HREmployeeSalaryConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objEmployeeSalaryConfigsInfo != null && objEmployeeSalaryConfigsInfo.FK_HRDepartmentID > 0)
                    {
                        departmentList = departmentList.Where(x => x.FK_HRDepartmentID == objEmployeeSalaryConfigsInfo.FK_HRDepartmentID).ToList();
                    }
                }
                if (departmentList != null) departmentList.Insert(0, new HRDepartmentRoomsInfo());
                lookUpEdit.Properties.DataSource = departmentList;
            }
            lookUpEdit.Properties.DisplayMember = "HRDepartmentRoomName";
            lookUpEdit.Properties.ValueMember = "HRDepartmentRoomID";
        }

        #endregion

    }
}

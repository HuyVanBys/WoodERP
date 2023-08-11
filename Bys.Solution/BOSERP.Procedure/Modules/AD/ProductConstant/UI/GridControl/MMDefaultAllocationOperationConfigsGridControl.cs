using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class MMDefaultAllocationOperationConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DefaultAllocationOperationConfigList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.CellValueChanged += GridView_CellValueChanged;
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveDefaultAllocationOperationConfigList();
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Ngành hàng";
            column.FieldName = "FK_ICDepartmentID";
            column.VisibleIndex = 0;
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ICDepartmentName";
            repositoryItemLookUpEdit.ValueMember = "ICDepartmentID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICDepartmentNo", 200, "Mã ngành hàng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICDepartmentName", 400, "Tên ngành hàng"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditDepartment_QueryPopUp);
            //repositoryItemLookUpEdit.CloseUp += new CloseUpEventHandler(repositoryItemLookUpEditDepartment_CloseUp);
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm hàng";
            column.FieldName = "FK_ICProductGroupID";
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = true;
            repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ICProductGroupName";
            repositoryItemLookUpEdit.ValueMember = "ICProductGroupID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupNo", 200, "Mã nhóm hàng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", 400, "Tên nhóm hàng"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditProductGroup_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Công đoạn";
            column.FieldName = "FK_MMOperationID";
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = true;
            repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
            repositoryItemLookUpEdit.ValueMember = "MMOperationID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", 400, "Mã công đoạn"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditOperation_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);

        }

        void repositoryItemLookUpEditDepartment_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            List<ICDepartmentsInfo> departmentList = (List<ICDepartmentsInfo>)objDepartmentsController.GetallObjects();
            if (departmentList != null && departmentList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = departmentList;
            }
            lookUpEdit.Properties.DisplayMember = "ICDepartmentName";
            lookUpEdit.Properties.ValueMember = "ICDepartmentID";
        }
        void repositoryItemLookUpEditProductGroup_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (entity.DefaultAllocationOperationConfigList.CurrentIndex >= 0)
            {
                MMDefaultAllocationOperationConfigsInfo item = (MMDefaultAllocationOperationConfigsInfo)entity.DefaultAllocationOperationConfigList[entity.DefaultAllocationOperationConfigList.CurrentIndex];
                if (item.FK_ICDepartmentID > 0)
                {
                    LookUpEdit lookUpEdit = (LookUpEdit)sender;
                    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                    List<ICProductGroupsInfo> productGroupList = (List<ICProductGroupsInfo>)objProductGroupsController.GetProductGroupByDepartmentID(item.FK_ICDepartmentID);
                    if (productGroupList != null && productGroupList.Count > 0)
                    {
                        lookUpEdit.Properties.DataSource = productGroupList;
                    }
                    lookUpEdit.Properties.DisplayMember = "ICProductGroupName";
                    lookUpEdit.Properties.ValueMember = "ICProductGroupID";
                }
                else
                {
                    LookUpEdit lookUpEdit = (LookUpEdit)sender;
                    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                    List<ICProductGroupsInfo> productGroupList = (List<ICProductGroupsInfo>)objProductGroupsController.GetAllObjectList();
                    if (productGroupList != null && productGroupList.Count > 0)
                    {
                        lookUpEdit.Properties.DataSource = productGroupList;
                    }
                    lookUpEdit.Properties.DisplayMember = "ICProductGroupName";
                    lookUpEdit.Properties.ValueMember = "ICProductGroupID";
                }
            }
            else
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                List<ICProductGroupsInfo> productGroupList = (List<ICProductGroupsInfo>)objProductGroupsController.GetAllObjectList();
                if (productGroupList != null && productGroupList.Count > 0)
                {
                    lookUpEdit.Properties.DataSource = productGroupList;
                }
                lookUpEdit.Properties.DisplayMember = "ICProductGroupName";
                lookUpEdit.Properties.ValueMember = "ICProductGroupID";
            }    
        }
        void repositoryItemLookUpEditOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationList = (List<MMOperationsInfo>)objOperationsController.GetAllAliveOperation();
            if (operationList != null && operationList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = operationList;
            }
            lookUpEdit.Properties.DisplayMember = "MMOperationName";
            lookUpEdit.Properties.ValueMember = "MMOperationID";
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICDepartmentID")
            {
                if (e.Value != null)
                {
                    int departmentID = int.Parse(e.Value.ToString());
                    ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                    ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(departmentID);
                    if (objDepartmentsInfo != null)
                        e.DisplayText = objDepartmentsInfo.ICDepartmentName;
                    else
                        e.DisplayText = string.Empty;
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ICProductGroupID")
            {
                if (e.Value != null)
                {
                    int productGroupID = int.Parse(e.Value.ToString());
                    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                    ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(productGroupID);
                    if (objProductGroupsInfo != null)
                        e.DisplayText = objProductGroupsInfo.ICProductGroupName;
                    else
                        e.DisplayText = string.Empty;
                }
                else
                    e.DisplayText = string.Empty;
            }
            if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (e.Value != null)
                {
                    int operationID = int.Parse(e.Value.ToString());
                    MMOperationsController objOperationsController = new MMOperationsController();
                    MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(operationID);
                    if (objOperationsInfo != null)
                        e.DisplayText = objOperationsInfo.MMOperationName;
                    else
                        e.DisplayText = string.Empty;
                }
                else
                    e.DisplayText = string.Empty;
            }
        }
        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMDefaultAllocationOperationConfigsInfo item = (MMDefaultAllocationOperationConfigsInfo)entity.DefaultAllocationOperationConfigList[entity.DefaultAllocationOperationConfigList.CurrentIndex];
            if (gridView.FocusedColumn.FieldName == "FK_ICProductGroupID")
            {
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(item.FK_ICProductGroupID);
                if (objProductGroupsInfo != null)
                {
                    item.FK_ICDepartmentID = objProductGroupsInfo.FK_ICDepartmentID;
                }
            } 
            entity.DefaultAllocationOperationConfigList.GridControl?.RefreshDataSource();
        }
    }
}

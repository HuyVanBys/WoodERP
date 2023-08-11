using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Equipment
{
    public partial class IdentifyMenuGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EquipmentEntities entity = (EquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductIdentifiedEquipmentList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = "Mã CCDC";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName";
            column.Caption = "Tên CCDC";
            column.Visible = true;
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_ICDepartmentID";
            column.Caption = "Ngành hàng";
            column.Visible = true;
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_ICProductGroupID";
            column.Caption = "Nhóm hàng";
            column.Visible = true;
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductOriginalAmount";
            column.Caption = "Nguyên giá";
            column.Visible = true;
            column.VisibleIndex = 4;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductDepreciatedAmount";
            column.Caption = "Giá trị đã khấu hao";
            column.Visible = true;
            column.VisibleIndex = 5;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "ICProductDepreciationMonths";
            //column.Caption = "Số tháng phân bổ";
            //column.Visible = true;
            //column.VisibleIndex = 6;
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductDepreciationMethod";
            column.Caption = "Kiểu phân bổ";
            column.Visible = true;
            column.VisibleIndex = 7;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSupplierPrice";
            column.Caption = "Giá mua";
            column.Visible = true;
            column.VisibleIndex = 8;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_ACAccountID";
            column.Caption = "Tài khoản";
            column.Visible = true;
            column.VisibleIndex = 9;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_ACDepreciationAccountID";
            column.Caption = "Tài khoản phân bổ";
            column.Visible = true;
            column.VisibleIndex = 11;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductIsInventory";
            column.Caption = "Kiểm kê";
            column.Visible = true;
            column.VisibleIndex = 12;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = true;//dòng autofilter để nhập trực tiếp

            //GridColumn column = gridView.Columns["FK_ICProductSerieID"];
            //if (column != null)
            //{
            //    RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
            //    repositoryItemWoodLookUpEdit.DisplayMember = "ICProductSerieNo";
            //    repositoryItemWoodLookUpEdit.ValueMember = "ICProductSerieID";
            //    repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //    repositoryItemWoodLookUpEdit.NullText = string.Empty;

            //    repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductSerieNo", "Mã lô"));

            //    repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rep_QueryPopUp);
            //    column.ColumnEdit = repositoryItemWoodLookUpEdit;
            //    column.OptionsColumn.AllowEdit = true;
            //}

            GridColumn column = gridView.Columns["ICProductIdentifiedEquipmentOriginalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICProductIdentifiedEquipmentNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICProductIdentifiedEquipmentInitDepriciationMonths"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentRoomGroupItemID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMLineID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMWorkShopID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HREmployeeUserID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICProductIdentifiedEquipmentInitDepriciatedAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemWoodLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemWoodLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemWoodLookUpEdit.NullText = string.Empty;
                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã TK"));
                repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(Account_QueryPopUp);
                column.ColumnEdit = repositoryItemWoodLookUpEdit;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ICDepartmentID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemWoodLookUpEdit.DisplayMember = "ICDepartmentName";
                repositoryItemWoodLookUpEdit.ValueMember = "ICDepartmentID";
                repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemWoodLookUpEdit.NullText = string.Empty;
                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICDepartmentName", "Ngành hàng"));
                repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(Department_QueryPopUp);
                column.ColumnEdit = repositoryItemWoodLookUpEdit;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ICProductGroupID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemWoodLookUpEdit.DisplayMember = "ICProductGroupName";
                repositoryItemWoodLookUpEdit.ValueMember = "ICProductGroupID";
                repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemWoodLookUpEdit.NullText = string.Empty;
                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", "Nhóm hàng"));
                repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(Group_QueryPopUp);
                column.ColumnEdit = repositoryItemWoodLookUpEdit;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ACDepreciationCostAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACDepreciationAccountID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemWoodLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemWoodLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemWoodLookUpEdit.NullText = string.Empty;
                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã TK"));
                repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(Account_QueryPopUp);
                column.ColumnEdit = repositoryItemWoodLookUpEdit;
                column.OptionsColumn.AllowEdit = false;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName == "FK_ACAccountID")
            {
                if (e.Value != null)
                {
                    ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
                    ACAccountsController objAccountsController = new ACAccountsController();
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(Convert.ToInt32(e.Value));
                    if (objAccountsInfo != null)
                    {
                        e.DisplayText = objAccountsInfo.ACAccountNo;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ACDepreciationAccountID")
            {
                if (e.Value != null)
                {
                    ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
                    ACAccountsController objAccountsController = new ACAccountsController();
                    objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(Convert.ToInt32(e.Value));
                    if (objAccountsInfo != null)
                    {
                        e.DisplayText = objAccountsInfo.ACAccountNo;
                    }
                }
            }

            //if (e.Column.FieldName == "FK_ICProductSerieID")
            //{
            //    if (e.Value != null)
            //    {
            //        ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            //        ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //        objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(Convert.ToInt32(e.Value));
            //        if (objProductSeriesInfo != null)
            //        {
            //            e.DisplayText = objProductSeriesInfo.ICProductSerieNo;
            //        }
            //    }
            //}

            if (e.Column.FieldName == "FK_ICDepartmentID")
            {
                if (e.Value != null)
                {
                    ICDepartmentsController departmentController = new ICDepartmentsController();
                    ICDepartmentsInfo department = departmentController.GetObjectByID(Convert.ToInt32(e.Value)) as ICDepartmentsInfo;
                    if (department != null)
                    {
                        e.DisplayText = department.ICDepartmentName;
                    }
                }
            }

            if (e.Column.FieldName == "FK_ICProductGroupID")
            {
                if (e.Value != null)
                {
                    ICProductGroupsController productGroupController = new ICProductGroupsController();
                    ICProductGroupsInfo productGroup = productGroupController.GetObjectByID(Convert.ToInt32(e.Value)) as ICProductGroupsInfo;
                    if (productGroup != null)
                    {
                        e.DisplayText = productGroup.ICProductGroupName;
                    }
                }
            }
        }
        //void rep_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookup = (LookUpEdit)sender;
        //    EquipmentEntities entity = (EquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
        //    ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
        //    List<ICProductSeriesInfo> productSerieList = objProductSeriesController.GetProductSerieByProductID(objProductsInfo.ICProductID);


        //    lookup.Properties.DataSource = productSerieList;
        //    lookup.Properties.DisplayMember = "ICProductSerieNo";
        //    lookup.Properties.ValueMember = "ICProductSerieID";


        //}
        void Account_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            EquipmentEntities entity = (EquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACAccountsInfo> AccountList = objAccountsController.GetListAccountForShowIdentifyMenu();
            lookup.Properties.DataSource = AccountList;
            lookup.Properties.DisplayMember = "ACAccountNo";
            lookup.Properties.ValueMember = "ACAccountID";
        }
        void Department_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            EquipmentEntities entity = (EquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            List<ICDepartmentsInfo> List = objDepartmentsController.GetallObjects();
            lookup.Properties.DataSource = List;
        }
        void Group_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            EquipmentEntities entity = (EquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            DataSet ds = objProductGroupsController.GetAllObjects();
            List<ICProductGroupsInfo> List = new List<ICProductGroupsInfo>();
            if (ds != null && ds.Tables.Count != 0)
                List = objProductGroupsController.GetListFromDataSet(ds) as List<ICProductGroupsInfo>;
            lookup.Properties.DataSource = List;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EquipmentModule)Screen.Module).DeleteItemFromIdentifiedList();
            }

        }



        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            EquipmentEntities entity = (EquipmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ProductIdentifiedEquipmentList.CurrentIndex >= 0)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICProductIdentifiedEquipmentsInfo item = (ICProductIdentifiedEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (e.Column.FieldName == "ICProductIdentifiedEquipmentNo")
                    {
                        if (!((EquipmentModule)Screen.Module).CheckValidIdentifiedNo(e.Value.ToString(), gridView.FocusedRowHandle))
                        {
                            entity.ProductIdentifiedEquipmentList[entity.ProductIdentifiedEquipmentList.CurrentIndex].ICProductIdentifiedEquipmentNo = gridView.ActiveEditor.OldEditValue.ToString();
                        }

                    }

                }

            }
        }


    }
}

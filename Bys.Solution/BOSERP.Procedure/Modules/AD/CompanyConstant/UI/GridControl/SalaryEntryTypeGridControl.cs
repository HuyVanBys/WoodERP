using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class SalaryEntryTypeGridControl : BOSComponent.BOSGridControl
    {
        #region Constants
        #endregion
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SalaryEntryTypeList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_ACSalaryDocumentTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACSalaryDocumentTypeDesc";
                repositoryItemLookUpEdit.ValueMember = "ACSalaryDocumentTypeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACSalaryDocumentTypeName", "Mã loại hạch toán lương"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACSalaryDocumentTypeDesc", "Tên loại hạch toán lương"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditDocumentType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditAccount_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditAccount_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACCostCenterName";
                repositoryItemLookUpEdit.ValueMember = "ACCostCenterID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostCenterNo", "Mã TTCP"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostCenterName", "Tên TTCP"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditCostCenter_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACSegmentName";
                repositoryItemLookUpEdit.ValueMember = "ACSegmentID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACSegmentNo", "Mã KMCP"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACSegmentName", "Tên KMCP"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditSegment_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Mã loại bút toán";
            column.FieldName = "ACSalaryEntryTypeName";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên loại bút toán";
            column.FieldName = "ACSalaryEntryTypeDesc";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại hạch toán lương";
            column.FieldName = "FK_ACSalaryDocumentTypeID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tài khoản có";
            column.FieldName = "FK_ACCreditAccountID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tài khoản nợ";
            column.FieldName = "FK_ACDebitAccountID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trung tâm chi phí";
            column.FieldName = "FK_ACCostCenterID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khoản mục chi phí";
            column.FieldName = "FK_ACSegmentID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Delete";
            column.Caption = "Xóa";
            RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = "Xóa";
            rep.Click += new EventHandler(rep_DeleteClick);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm theo đơn vị";
            column.FieldName = "ACSalaryEntryTypeDetailIsGroupByBranch";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm theo phòng ban";
            column.FieldName = "ACSalaryEntryTypeDetailIsGroupByDepartment";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm theo bộ phận";
            column.FieldName = "ACSalaryEntryTypeDetailIsGroupByDepartmentGroup";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ChooseDepartment";
            column.Caption = "Chọn phòng ban";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Chọn phòng ban";
            rep1.Click += new EventHandler(rep_ChooseDepartment);
            column.ColumnEdit = rep1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ChooseDepartmentRoom";
            column.Caption = "Chọn bộ phận";
            RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
            rep2.NullText = "Chọn bộ phận";
            rep2.Click += new EventHandler(rep_ChooseDepartmentRoom);
            column.ColumnEdit = rep2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ChooseLevel";
            column.Caption = "Chọn chức vụ";
            RepositoryItemHyperLinkEdit rep3 = new RepositoryItemHyperLinkEdit();
            rep3.NullText = "Chọn chức vụ";
            rep3.Click += new EventHandler(rep_ChooseLevel);
            column.ColumnEdit = rep3;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACSalaryEntryTypesInfo objSalaryEntryTypesInfo = (ACSalaryEntryTypesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objSalaryEntryTypesInfo.ACSalaryEntryTypeName == string.Empty)
            {
                objSalaryEntryTypesInfo.ACSalaryEntryTypeName = ERPModuleEntities.cstNewObjectText;
            }
            entity.SalaryEntryTypeList.GridControl.RefreshDataSource();
        }

        public void repositoryItemLookUpEditDocumentType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACSalaryDocumentTypesController objSalaryDocumentTypesController = new ACSalaryDocumentTypesController();
            List<ACSalaryDocumentTypesInfo> salaryDocumentTypes = objSalaryDocumentTypesController.GetAllAliveSalaryDocumentTypes();
            if (salaryDocumentTypes != null)
            {
                salaryDocumentTypes.Insert(0, new ACSalaryDocumentTypesInfo());
                lookUpEdit.Properties.DataSource = salaryDocumentTypes;
            }
            lookUpEdit.Properties.DisplayMember = "ACSalaryDocumentTypeDesc";
            lookUpEdit.Properties.ValueMember = "ACSalaryDocumentTypeID";
        }

        void rep_DeleteClick(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Screen.Module).RemoveSelecteSalaryEntryType();
        }

        void rep_ChooseDepartment(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Screen.Module).ChangeSalaryEntryTypeDetailPartDepartment();
        }

        void rep_ChooseDepartmentRoom(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Screen.Module).ChangeSalaryEntryTypeDetailPartDepartmentRoom();
        }

        void rep_ChooseLevel(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Screen.Module).ChangeSalaryEntryTypeDetailPartLevel();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACSalaryDocumentTypeID")
            {
                if (e.Value != null)
                {
                    int documentTypeID = int.Parse(e.Value.ToString());
                    ACSalaryDocumentTypesController objSalaryDocumentTypesController = new ACSalaryDocumentTypesController();
                    ACSalaryDocumentTypesInfo objSalaryDocumentTypesInfo = (ACSalaryDocumentTypesInfo)objSalaryDocumentTypesController.GetObjectByID(documentTypeID);
                    if (objSalaryDocumentTypesInfo != null)
                    {
                        e.DisplayText = objSalaryDocumentTypesInfo.ACSalaryDocumentTypeDesc;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ACCreditAccountID")
            {
                if (e.Value != null)
                {
                    int accountID = int.Parse(e.Value.ToString());
                    ACAccountsController objAccountsController = new ACAccountsController();
                    ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(accountID);
                    if (objAccountsInfo != null)
                    {
                        e.DisplayText = objAccountsInfo.ACAccountNo;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ACDebitAccountID")
            {
                if (e.Value != null)
                {
                    int accountID = int.Parse(e.Value.ToString());
                    ACAccountsController objAccountsController = new ACAccountsController();
                    ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(accountID);
                    if (objAccountsInfo != null)
                    {
                        e.DisplayText = objAccountsInfo.ACAccountNo;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ACCostCenterID")
            {
                if (e.Value != null)
                {
                    int costCenterID = int.Parse(e.Value.ToString());
                    ACCostCentersController objCostCentersController = new ACCostCentersController();
                    ACCostCentersInfo objCostCenterInfo = (ACCostCentersInfo)objCostCentersController.GetObjectByID(costCenterID);
                    if (objCostCenterInfo != null)
                    {
                        e.DisplayText = objCostCenterInfo.ACCostCenterName;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ACSegmentID")
            {
                if (e.Value != null)
                {
                    int segmentID = int.Parse(e.Value.ToString());
                    ACSegmentsController objSegmentsController = new ACSegmentsController();
                    ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(segmentID);
                    if (objSegmentsInfo != null)
                    {
                        e.DisplayText = objSegmentsInfo.ACSegmentName;
                    }
                }
            }
        }

        public void repositoryItemLookUpEditDetailGroupType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.SalaryEntryTypeDetailGroupType);
            List<ADConfigValuesInfo> configValues = new List<ADConfigValuesInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ADConfigValuesInfo cv = new ADConfigValuesInfo();
                    cv = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(dr);
                    configValues.Add(cv);
                }
            }
            configValues.Insert(0, objConfigValuesInfo);
            lookUpEdit.Properties.DataSource = configValues;

            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        public void repositoryItemLookUpEditAccount_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACAccountsInfo> accounts = objAccountsController.GetAllAccountList();
            if (accounts != null)
            {
                accounts.Insert(0, new ACAccountsInfo());
                lookUpEdit.Properties.DataSource = accounts;
            }
            lookUpEdit.Properties.DisplayMember = "ACAccountNo";
            lookUpEdit.Properties.ValueMember = "ACAccountID";
        }

        public void repositoryItemLookUpEditCostCenter_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACCostCentersController objCostCentersController = new ACCostCentersController();
            List<ACCostCentersInfo> costCenters = objCostCentersController.GetAllAliveAndActiveCostCenter();
            if (costCenters != null)
            {
                costCenters.Insert(0, new ACCostCentersInfo());
                lookUpEdit.Properties.DataSource = costCenters;
            }
            lookUpEdit.Properties.DisplayMember = "ACCostCenterName";
            lookUpEdit.Properties.ValueMember = "ACCostCenterID";
        }

        public void repositoryItemLookUpEditSegment_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACSegmentsController objSegmentsController = new ACSegmentsController();
            List<ACSegmentsInfo> segments = objSegmentsController.GetAllSegmnets();
            if (segments != null)
            {
                segments.Insert(0, new ACSegmentsInfo());
                lookUpEdit.Properties.DataSource = segments;
            }
            lookUpEdit.Properties.DisplayMember = "ACSegmentName";
            lookUpEdit.Properties.ValueMember = "ACSegmentID";
        }
    }
}

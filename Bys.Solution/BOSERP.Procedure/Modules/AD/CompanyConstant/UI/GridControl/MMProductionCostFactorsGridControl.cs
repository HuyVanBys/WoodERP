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


namespace BOSERP.Modules.CompanyConstant
{
    public partial class MMProductionCostFactorsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMProductionCostFactorsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "CopyLine";
            column.Caption = "Thêm dòng";
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Thêm dòng";
            rep1.Click += new EventHandler(rep_Click);
            column.ColumnEdit = rep1;
            gridView.Columns.Add(column);
        }

        void rep_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Screen.Module).CopyLine();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }


            GridColumn column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = CreateRepositoryLookUpEditAccount();
            }

            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = CreateRepositoryLookUpEditAccount();
            }

            column = gridView.Columns["FK_ACInProgressAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = CreateRepositoryLookUpEditAccount();
            }

            column = gridView.Columns["FK_MMProductionCostFactorGroupID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = CreateRepositoryLookUpEditFactorGroup();
            }
            return gridView;
        }

        private RepositoryItemLookUpEdit CreateRepositoryLookUpEditFactorGroup()
        {
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "MMProductionCostFactorGroupNo";
            repositoryItemLookUpEdit.ValueMember = "MMProductionCostFactorGroupID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionCostFactorGroupNo", "Mã nhóm yếu tố"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionCostFactorGroupName", "Tên nhóm yếu tố"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            return repositoryItemLookUpEdit;
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            MMProductionCostFactorGroupsController fgController = new MMProductionCostFactorGroupsController();
            List<MMProductionCostFactorGroupsInfo> fgList = new List<MMProductionCostFactorGroupsInfo>();
            fgList.Add(new MMProductionCostFactorGroupsInfo());

            List<MMProductionCostFactorGroupsInfo> fgGetList = fgController.GetAllAliveFactorGroup();
            if (fgGetList != null && fgGetList.Count > 0)
            {
                fgList.AddRange(fgGetList);
            }

            lookUpEdit.Properties.DataSource = fgList;
        }

        private RepositoryItemLookUpEdit CreateRepositoryLookUpEditAccount()
        {
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
            repositoryItemLookUpEdit.ValueMember = "ACAccountID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã tài khoản"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên tài khoản"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditModelDetail_QueryPopUp);
            return repositoryItemLookUpEdit;
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController accountController = new ACAccountsController();
            List<ACAccountsInfo> accountList = new List<ACAccountsInfo>();
            accountList.Add(new ACAccountsInfo());

            List<ACAccountsInfo> accountGetList = accountController.GetAllAccountList();
            if (accountGetList != null && accountGetList.Count > 0)
            {
                accountList.AddRange(accountGetList);
            }

            lookUpEdit.Properties.DataSource = accountList;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACCreditAccountID"
                || e.Column.FieldName == "FK_ACDebitAccountID"
                || e.Column.FieldName == "FK_ACInProgressAccountID")
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
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                else
                {
                    e.DisplayText = string.Empty;
                }
            }
            else if (e.Column.FieldName == "FK_MMProductionCostFactorGroupID")
            {
                if (e.Value != null)
                {
                    int fgID = int.Parse(e.Value.ToString());
                    MMProductionCostFactorGroupsController fgController = new MMProductionCostFactorGroupsController();
                    MMProductionCostFactorGroupsInfo fgInfo = (MMProductionCostFactorGroupsInfo)fgController.GetObjectByID(fgID);
                    if (fgInfo != null)
                    {
                        e.DisplayText = fgInfo.MMProductionCostFactorGroupNo;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                else
                {
                    e.DisplayText = string.Empty;
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((CompanyConstantModule)Screen.Module).RemoveSelectedProductionCostFactor();
                }
            }
        }
    }
}

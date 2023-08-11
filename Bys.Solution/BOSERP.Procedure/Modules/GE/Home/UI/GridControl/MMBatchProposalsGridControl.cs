using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class MMBatchProposalsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BatchProposalList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.BatchProposalList.SetEndCurrentEdit();
            return;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            ACObjectsController objObjectsController = new ACObjectsController();
            if (gridView.Columns["ACObjectAccessKey"] != null)
            {
                GridColumn column = gridView.Columns["ACObjectAccessKey"];
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
                repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemEmployeeOwnerLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = HomeLocalizedResources.ShowDetailCaption;
            column.FieldName = "MMProposalShowDetail";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemAddNewRow = new RepositoryItemHyperLinkEdit();
            rpItemAddNewRow.NullText = HomeLocalizedResources.ShowDetailCaption;
            rpItemAddNewRow.Click += new EventHandler(rpItemAddNewRow_Click);
            column.ColumnEdit = rpItemAddNewRow;
            gridView.Columns.Add(column);

            GridColumn column1 = new GridColumn();
            column1.Caption = "Trạng thái";
            column1.FieldName = "MMProposalStatus";
            column1.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column1);
        }

        private void rpItemAddNewRow_Click(object sender, EventArgs e)
        {
            ((HomeModule)Screen.Module).ShowBatchProposalDetail();
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMProposalsInfo objProposalsInfo = (MMProposalsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objProposalsInfo != null)
                {
                    ((HomeModule)Screen.Module).ShowBatchProposalScreen(objProposalsInfo.MMProposalID);
                }
            }
        }
    }
}

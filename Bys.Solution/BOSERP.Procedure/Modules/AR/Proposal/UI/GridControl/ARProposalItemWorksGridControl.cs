using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public class ARProposalItemWorksGridControl : ItemGridControl
    {
        private DataTable ARProposalItemWorkTypeTable { get; set; }

        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARProposalItemWorkList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            //column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = SaleOrderLocalizedResources.ARSaleOrderItemWorkComponentCaption;
            //column.FieldName = "ARProposalItemWorkComponent";
            //column.OptionsColumn.AllowEdit = true;
            //column.MinWidth = 100;
            //RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            //rpItemComponent.NullText = SaleOrderLocalizedResources.ARSaleOrderItemWorkComponentCaption;
            //rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            //column.ColumnEdit = rpItemComponent;
            //gridView.Columns.Add(column);

            LookUpColumnInfo columnInfo;
            ARProposalItemWorkTypeTable = new DataTable();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("ProductItemWorkType");
            if (ds != null)
                ARProposalItemWorkTypeTable = ds.Tables[0];

            if (gridView.Columns["ARProposalItemWorkType"] != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                gridView.Columns["ARProposalItemWorkType"].MinWidth = 100;
                gridView.Columns["ARProposalItemWorkType"].OptionsColumn.AllowEdit = true;
                repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)ARProposalItemWorkTypeTable;
                repositoryItemLookUpEdit.ValueMember = "Value";
                repositoryItemLookUpEdit.DisplayMember = "Text";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.NullText = "Sản phẩm";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "Text";
                columnInfo.Width = 100;
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                gridView.Columns["ARProposalItemWorkType"].ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (gridView.Columns["ARProposalItemWorkProductQty"] != null)
            {
                gridView.Columns["ARProposalItemWorkProductQty"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARProposalItemWorkComment"] != null)
            {
                gridView.Columns["ARProposalItemWorkComment"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARProposalItemWorkProductChargeCheck"] != null)
            {
                gridView.Columns["ARProposalItemWorkProductChargeCheck"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["ARProposalItemWorkProductUnitPrice"] != null)
            {
                gridView.Columns["ARProposalItemWorkProductUnitPrice"].OptionsColumn.AllowEdit = true;
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARProposalItemWorkList.CurrentIndex >= 0)
            {
                ARProposalItemWorksInfo item = entity.ARProposalItemWorkList[entity.ARProposalItemWorkList.CurrentIndex];
                if (e.Column.FieldName == "ARProposalItemWorkProductQty")
                {
                    ((ProposalModule)Screen.Module).ChangeQty(item);
                }
                else if (e.Column.FieldName == "ARProposalItemWorkProductChargeCheck")
                {
                    ((ProposalModule)Screen.Module).ChangeChargeCheck(item);
                }
                if (e.Column.FieldName == "ARProposalItemWorkProductUnitPrice")
                {
                    ((ProposalModule)Screen.Module).ChangeQty(item);
                }
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.Columns["ARProposalItemWorkProductNo"].Caption = "Mã công việc";
            gridView.Columns["ARProposalItemWorkProductName"].Caption = "Tên công việc";
            return gridView;
        }

        //private void RpItemComponent_Click(object sender, EventArgs e)
        //{
        //    ((ProposalModule)Screen.Module).ShowWorkItemComponent();
        //}

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProposalModule)Screen.Module).DeleteItemFromProposalItemWorksList();
            }
        }
    }
}

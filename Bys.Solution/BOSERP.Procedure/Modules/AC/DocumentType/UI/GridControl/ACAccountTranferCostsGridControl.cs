using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ACDocumentType
{
    public class ACAccountTranferCostsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACAccountTranferCostList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            DataSet dsDocumentTypes = objDocumentTypesController.GetAllObjects();

            if (gridView.Columns["FK_ACDocumentTypeID"] != null)
            {
                GridColumn column = gridView.Columns["FK_ACDocumentTypeID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsDocumentTypes.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "ACDocumentTypeID";
                repositoryItemLookUpEdit.DisplayMember = "ACDocumentTypeDesc";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "ACDocumentTypeDesc";
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            ACEntryTypesController objACEntryTypesController = new ACEntryTypesController();
            DataSet dsACEntryType = objACEntryTypesController.GetAllObjects();

            if (gridView.Columns["FK_ACEntryTypeID"] != null)
            {
                GridColumn column = gridView.Columns["FK_ACEntryTypeID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsACEntryType.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "ACEntryTypeID";
                repositoryItemLookUpEdit.DisplayMember = "ACEntryTypeDesc";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "ACEntryTypeDesc";
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
        }


        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ACDocumentTypeModule)Screen.Module).DeleteItemFromAccountTranferCost();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
                //if (col.FieldName == "FK_ACDocumentTypeID")
                //    col.OptionsColumn.AllowEdit = false;
            }
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ACEntryTypeID" && e.Value != null)
            {
                int FK_ACEntryTypeID = 0;
                if (int.TryParse(e.Value.ToString(), out FK_ACEntryTypeID) && FK_ACEntryTypeID > 0)
                {
                    ACAccountTranferCostsInfo item = (ACAccountTranferCostsInfo)gridView.GetFocusedRow();

                    if (item != null)
                        ((ACDocumentTypeModule)Screen.Module).SetDefualtDocumentType(item);
                }
            }
        }
    }
}

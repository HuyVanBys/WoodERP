using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class CauHinhNhomCumGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SemiGroupTypeList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã nhóm cụm";
            column.FieldName = "ICProductAttributeNo";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên nhóm cụm";
            column.FieldName = "ICProductAttributeValue";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã phát sinh BOM";
            column.FieldName = "ICProductAttributeAbbreviation";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm hàng";
            column.FieldName = "FK_ICProductGroupID";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 4;
            RepositoryItemBOSLookupEdit repositorySemiGroupItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            repositorySemiGroupItemLookUpEdit.DisplayMember = "ICProductGroupName";
            repositorySemiGroupItemLookUpEdit.ValueMember = "ICProductGroupID";
            repositorySemiGroupItemLookUpEdit.NullText = string.Empty;
            repositorySemiGroupItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupNo", "Mã"));
            repositorySemiGroupItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", "Tên"));

            repositorySemiGroupItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositorySemiGroupTypeItemLookUpEdit_QueryPopUp);
            column.ColumnEdit = repositorySemiGroupItemLookUpEdit;
            gridView.Columns.Add(column);
        }
        void repositorySemiGroupTypeItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductAttributesInfo item = (ICProductAttributesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                //ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                //DataSet productGroups = objProductGroupsController.GetAllProductGroupsByDepartmentID( 1);
                //if (productGroups != null)
                //{
                //    lookUpEdit.Properties.DataSource = productGroups.Tables[0];
                //    lookUpEdit.Properties.DisplayMember = "ICProductGroupName";
                //    lookUpEdit.Properties.ValueMember = "ICProductGroupID";
                //}
                //productGroups.Dispose();
            }
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
            //gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            //  gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
        }

        //protected override GridView InitializeGridView()
        //{
        //    GridView gridView = new GridView();
        //   // gridView.Columns.AddVisible("ADConfigText");
        //    gridView.OptionsView.ShowColumnHeaders = false;
        //    gridView.OptionsView.ShowGroupPanel = false;
        //    gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
        //    gridView.KeyUp += new System.Windows.Forms.KeyEventHandler(GridView_KeyUp);
        //    gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
        //    //gridView.InvalidValueException += new InvalidValueExceptionEventHandler(GridView_InvalidValueException);
        //    return gridView;
        //}

        //protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        //{

        //    e.ExceptionMode = ExceptionMode.DisplayError;

        //}

        //protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        //{
        //    GridView gridView = (GridView)sender;
        //    string configText = Convert.ToString(gridView.GetFocusedRowCellValue("ADConfigText"));

        //    if (e.Value != null)
        //    {
        //        if (gridView.FocusedColumn.FieldName == "ADConfigText")
        //        {
        //            if (string.IsNullOrEmpty(e.Value.ToString()))
        //            {
        //                e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyProductTypeMessage.ToString();
        //                e.Valid = false;
        //            }
        //            else
        //            {
        //                if (!configText.Equals(e.Value.ToString().Trim()))
        //                {
        //                    string configValuesType = "Product";
        //                    ((CompanyConstantModule)Screen.Module).CheckConfigValues(e.Value.ToString().Trim(), e, configValuesType);

        //                }
        //            }
        //        }
        //    }
        //}

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedSemiGroupTypeList();
            }
        }
    }
}

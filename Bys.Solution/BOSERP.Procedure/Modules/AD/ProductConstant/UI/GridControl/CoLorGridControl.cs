using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class CoLorGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CoLorList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã loại sơn";
            column.FieldName = "ICProductAttributeNo";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên loại sơn";
            column.FieldName = "ICProductAttributeValue";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Viết tắt";
            column.FieldName = "ICProductAttributeAbbreviation";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);
            ////--------------Hoàn thiện
            //column = new GridColumn();
            //column.Caption = "Hoàn thiện";
            //column.FieldName = "FK_ICProductAttributeHTType";
            //column.OptionsColumn.AllowEdit = true;

            RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
            //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
            //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //repositoryItemLookUpEdit.NullText = string.Empty;
            //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
            //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại"));
            //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
            //column.ColumnEdit = repositoryItemLookUpEdit;

            //column.Visible = true;
            //column.VisibleIndex = 4;
            //gridView.Columns.Add(column);
            //--------------
            //--------------Hệ sơn
            column = new GridColumn();
            column.Caption = "Hệ sơn";
            column.FieldName = "FK_ICProductGroupID";
            column.OptionsColumn.AllowEdit = true;

            repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            repositoryItemLookUpEdit.DisplayMember = "ICProductGroupName";
            repositoryItemLookUpEdit.ValueMember = "ICProductGroupID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupNo", "Mã"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", "Loại"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditProductGroup_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;

            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);
            //--------------
            //--------------Khách hàng
            //column = new GridColumn();
            //column.Caption = "Khách hàng";
            //column.FieldName = "FK_ARCustomerID";
            //column.OptionsColumn.AllowEdit = true;

            //repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            //repositoryItemLookUpEdit.DisplayMember = "ARCustomerName";
            //repositoryItemLookUpEdit.ValueMember = "ARCustomerID";
            //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //repositoryItemLookUpEdit.NullText = string.Empty;
            //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ARCustomerNo", "Mã"));
            //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ARCustomerName", "Tên"));
            //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditCustomer_QueryPopUp);
            //column.ColumnEdit = repositoryItemLookUpEdit;

            //column.Visible = true;
            //column.VisibleIndex = 6;
            //gridView.Columns.Add(column);
            //--------------
            column = new GridColumn();
            column.Caption = "Dòng hàng";
            column.FieldName = "ICProductAttributeProductLine";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);
        }
        public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeHTTypeColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        public void repositoryItemLookUpEditProductGroup_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            List<ICProductGroupsInfo> productGroupList = new List<ICProductGroupsInfo>();
            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
            productGroupList = objProductGroupsController.GetProductGroupListByDepartmentNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.IngredientPaintNo.ToString()));
            if (productGroupList != null)
            {
                productGroupList.Insert(0, objProductGroupsInfo);
                lookUpEdit.Properties.DataSource = productGroupList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductGroupName";
            lookUpEdit.Properties.ValueMember = "ICProductGroupID";
        }
        //public void repositoryItemLookUpEditCustomer_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ARCustomersController objCustomersController = new ARCustomersController();
        //    List<ARCustomersInfo> customersList = new List<ARCustomersInfo>();
        //    ARCustomersInfo objCustomersInfo = new ARCustomersInfo();
        //    DataSet ds = objCustomersController.GetAllCustomersForLookupControl();
        //    customersList = (List<ARCustomersInfo>)objCustomersController.GetListFromDataSet(ds);
        //    if (customersList != null)
        //    {
        //        customersList.Insert(0, objCustomersInfo);
        //        lookUpEdit.Properties.DataSource = customersList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ARCustomerName";
        //    lookUpEdit.Properties.ValueMember = "ARCustomerID";
        //}
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

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

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedCoLor();
            }
        }
        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            //if (e.Column.FieldName == "FK_ICProductAttributeHTType")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            //        ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
            //        if (objProductAttributesInfo != null)
            //            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
            //    }
            //}
            if (e.Column.FieldName == "FK_ICProductGroupID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                    ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(matchCodeID);
                    if (objProductGroupsInfo != null)
                        e.DisplayText = objProductGroupsInfo.ICProductGroupName;
                }
            }
            //if (e.Column.FieldName == "FK_ARCustomerID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ARCustomersController objCustomersController = new ARCustomersController();
            //        ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(matchCodeID);
            //        if (objCustomersInfo != null)
            //            e.DisplayText = objCustomersInfo.ARCustomerName;
            //    }
            //}
        }

    }
}

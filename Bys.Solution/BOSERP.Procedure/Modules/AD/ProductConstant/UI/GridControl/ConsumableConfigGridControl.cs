using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class ConsumableConfigGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ConsumableConfigList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
                if (item.FieldName == "MMConsumableConfigNo")
                {
                    item.OptionsColumn.AllowEdit = false;
                }
                if (item.FieldName == "FK_ICProductID")
                {
                    item.OptionsColumn.AllowEdit = true;
                }
                if (item.FieldName == "FK_ICProductAttributeID")
                {
                    item.OptionsColumn.AllowEdit = true;
                    //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                    //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                    //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    //repositoryItemLookUpEdit.NullText = string.Empty;
                    //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
                    //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại"));
                    //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                    //item.ColumnEdit = repositoryItemLookUpEdit;
                }
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }



        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductConstantModule)Screen.Module).RemoveSelectConsumableConfig();
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            ProductConstantEntities entity = (ProductConstantEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            int index = entity.ConsumableConfigList.CurrentIndex;
            if (index >= 0)
            {

                if (e.Column.FieldName == "FK_ICProductAttributeID")
                {
                    if ((entity.Module as ProductConstantModule).IsMatchConsumableConfigNo(int.Parse(e.Value.ToString())))
                    {
                        entity.ConsumableConfigList[index].FK_ICProductAttributeID = 0;
                    }
                    else
                    {
                        MMConsumableConfigsInfo item = entity.ConsumableConfigList[entity.ConsumableConfigList.CurrentIndex];
                        entity.ModuleObjects[TableName.MMConsumableConfigsTableName] = (MMConsumableConfigsInfo)item.Clone();
                        (entity.Module as ProductConstantModule).ChangeItemFromConsumableConfigList(item);
                    }
                    //((ProductConstantModule).Screen.Module).IsMatchConsumableConfigNo();
                }
                else
                {

                    MMConsumableConfigsInfo item = entity.ConsumableConfigList[entity.ConsumableConfigList.CurrentIndex];
                    entity.ModuleObjects[TableName.MMConsumableConfigsTableName] = (MMConsumableConfigsInfo)item.Clone();
                    (entity.Module as ProductConstantModule).ChangeItemFromConsumableConfigList(item);
                }
            }

        }

        #region old code
        //private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        //{
        //    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
        //    if (e.Column.FieldName == "FK_ICProductAttributeID")
        //    {
        //        if (e.Value != null)
        //        {
        //            int matchCodeID = int.Parse(e.Value.ToString());
        //            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
        //            if (objProductAttributesInfo != null)
        //                e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
        //        }

        //    }
        //}
        //public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    objProductAttributesInfo.ICProductAttributeID = 0;
        //    productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
        //    if (productAttributeList != null)
        //    {
        //        //productAttributeList.Insert(0, objProductAttributesInfo);
        //        lookUpEdit.Properties.DataSource = productAttributeList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
        //    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        //}
        //void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        //{
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    ICProductAttributesInfo objProductAttributesInfo = null;

        //    if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
        //    {
        //        if (e.Value != null)
        //        {
        //            objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(int.Parse(e.Value.ToString()));
        //            if (objProductAttributesInfo != null)
        //            {
        //                e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
        //            }
        //        }
        //    }

        //    if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID")
        //    {
        //        if (e.Value != null)
        //        {
        //            objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(int.Parse(e.Value.ToString()));
        //            if (objProductAttributesInfo != null)
        //            {
        //                e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
        //            }
        //        }
        //    }
        //    //if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID")
        //    //{
        //    //    if (e.Value != null && e.Value != string.Empty)
        //    //    {
        //    //        int valueID = 0;
        //    //        if (int.TryParse(e.Value.ToString(), out valueID))
        //    //        {
        //    //            ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = new ICDepartmentAttributeValuesInfo();
        //    //            ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
        //    //            objDepartmentAttributeValuesInfo = (ICDepartmentAttributeValuesInfo)objDepartmentAttributeValuesController.GetObjectByID(valueID);
        //    //            if (objDepartmentAttributeValuesInfo != null)
        //    //            {
        //    //                e.DisplayText = objDepartmentAttributeValuesInfo.ICDepartmentAttributeValueValue.ToString();
        //    //            }
        //    //        }
        //    //    }
        //    //}

        //}

        //protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);

        //    DevExpress.XtraGrid.Columns.GridColumn column;

        //    column = new DevExpress.XtraGrid.Columns.GridColumn();
        //    column.Caption = "Loại gỗ";
        //    column.FieldName = "FK_ICProductAttributeWoodTypeID";
        //    column.OptionsColumn.AllowEdit = true;

        //    RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
        //    repositoryItemWoodLookUpEdit.DisplayMember = "ICProductAttributeValue";
        //    repositoryItemWoodLookUpEdit.ValueMember = "ICProductAttributeID";
        //    repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //    repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
        //    repositoryItemWoodLookUpEdit.NullText = string.Empty;
        //    repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
        //    repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại"));

        //    repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemProductWoodType_QueryPopUp);
        //    column.ColumnEdit = repositoryItemWoodLookUpEdit;
        //    gridView.Columns.Add(column);

        //    column = new DevExpress.XtraGrid.Columns.GridColumn();
        //    column.Caption = "Đặc tính";
        //    column.FieldName = "FK_ICProductAttributeSpecialityID";
        //    column.OptionsColumn.AllowEdit = true;

        //    RepositoryItemLookUpEdit repositoryItemAttributeLookUpEdit = new RepositoryItemLookUpEdit();
        //    repositoryItemAttributeLookUpEdit.DisplayMember = "ICProductAttributeValue";
        //    repositoryItemAttributeLookUpEdit.ValueMember = "ICProductAttributeID";
        //    repositoryItemAttributeLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //    repositoryItemAttributeLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
        //    repositoryItemAttributeLookUpEdit.NullText = string.Empty;
        //    repositoryItemAttributeLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
        //    repositoryItemAttributeLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

        //    repositoryItemAttributeLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeLookupEdit_QueryPopUp);
        //    column.ColumnEdit = repositoryItemAttributeLookUpEdit;
        //    gridView.Columns.Add(column);

        //}

        // public void repositoryItemProductWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> ProductAttributesList = new List<ICProductAttributesInfo>();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    objProductAttributesInfo.ICProductAttributeID = 0;


        //    ProductAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup("WoodType");

        //    if (ProductAttributesList != null)
        //    {
        //        ProductAttributesList.Insert(0, objProductAttributesInfo);
        //        lookUpEdit.Properties.DataSource = ProductAttributesList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ICProductAttributeName";
        //    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        //}

        // public void repositoryItemAttributeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        // {
        //     LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //     ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //     List<ICProductAttributesInfo> ProductAttributesList = new List<ICProductAttributesInfo>();
        //     ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //     objProductAttributesInfo.ICProductAttributeID = 0;


        //     ProductAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup("Speciality");

        //     if (ProductAttributesList != null)
        //     {
        //         ProductAttributesList.Insert(0, objProductAttributesInfo);
        //         lookUpEdit.Properties.DataSource = ProductAttributesList;
        //     }
        //     lookUpEdit.Properties.DisplayMember = "ICProductAttributeName";
        //     lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        // }
        //void repositoryItemAttributeLookupEdit_QueryPopUp(object sender, CancelEventArgs e)
        // {
        //     GridView gridView = (GridView)this.MainView;
        //     LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //     ICDepartmentAttributesController objDepartmentAttributesController = new ICDepartmentAttributesController();
        //     ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo = new ICDepartmentAttributeValuesInfo();
        //     List<ICDepartmentAttributesInfo> departmentAttributeList = new List<ICDepartmentAttributesInfo>();
        //     ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
        //     List<ICDepartmentAttributeValuesInfo> departmentAttributeValueList = new List<ICDepartmentAttributeValuesInfo>();
        //     DataSet ds1 = new DataSet();
        //     DataSet ds = objDepartmentAttributesController.GetAllAttributesByDepartmentID(2);
        //     if (ds != null)
        //     {
        //         departmentAttributeList = (List<ICDepartmentAttributesInfo>)objDepartmentAttributesController.GetListFromDataSet(ds);
        //         if (departmentAttributeList != null)
        //         {
        //             foreach (ICDepartmentAttributesInfo itemList in departmentAttributeList)
        //             {
        //                 DataSet dsItem = objDepartmentAttributeValuesController.GetAllDataByForeignColumn("FK_ICDepartmentAttributeID", itemList.ICDepartmentAttributeID);
        //                 ds1.Merge(dsItem);
        //             }
        //             if (ds1 != null && ds1.Tables.Count > 0)
        //             {
        //                 //Init the  grid DataSource
        //                 departmentAttributeValueList = (List<ICDepartmentAttributeValuesInfo>)objDepartmentAttributeValuesController.GetListFromDataSet(ds1);
        //                 if (departmentAttributeValueList != null)
        //                 {
        //                     departmentAttributeValueList.Insert(0, objDepartmentAttributeValuesInfo);
        //                     lookUpEdit.Properties.DataSource = departmentAttributeValueList;
        //                     lookUpEdit.Properties.DisplayMember = "ICDepartmentAttributeValueValue";
        //                     lookUpEdit.Properties.ValueMember = "ICDepartmentAttributeValueID";
        //                 }
        //             }
        //         }
        //     }
        // }

        //protected override GridView InitializeGridView()
        //{
        //    GridView gridView = base.InitializeGridView();
        //    gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

        //    GridColumn column = gridView.Columns["FK_GECurrenyID"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //    }

        //    column = gridView.Columns["CSCompanyBankCode"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //    }

        //    column = gridView.Columns["CSCompanyBankName"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //    }

        //    column = gridView.Columns["CSCompanyBankAccount"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //    }

        //    column = gridView.Columns["IsDefault"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //    }

        //    column = gridView.Columns["FK_BRBranchID"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = true;
        //    }

        //    gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridView_CellValueChanging);
        //    return gridView;
        //}

        //private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    GridView gridView = (GridView)MainView;
        //    if (e.Column.FieldName == "IsDefault" && e.Value != null)
        //    {
        //        if (gridView.FocusedRowHandle >= 0)
        //        {
        //            bool isDefault = Convert.ToBoolean(e.Value);
        //            if (isDefault)
        //            {
        //                CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //                ((CompanyConstantModule)Screen.Module).CheckDefaultCompanyBank(objCompanyBanksInfo);
        //            }
        //        }
        //    }
        //}

        #endregion

    }
}

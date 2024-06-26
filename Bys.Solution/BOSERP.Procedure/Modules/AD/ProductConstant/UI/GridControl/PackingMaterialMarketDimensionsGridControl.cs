using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;
namespace BOSERP.Modules.ProductConstant
{
    public partial class PackingMaterialMarketDimensionsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PackingMaterialMarketDimensionList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                    //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                    //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    //repositoryItemLookUpEdit.NullText = string.Empty;
                    //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", "Mã"));
                    //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại"));
                    //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                    //column.ColumnEdit = repositoryItemLookUpEdit;
                }
            }
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMPackingMaterialMarketDimensionsInfo item = (MMPackingMaterialMarketDimensionsInfo)gridView.GetRow(e.RowHandle);
                            if (item.IsError)
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        public void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                MMPackingMaterialMarketDimensionsInfo item = (MMPackingMaterialMarketDimensionsInfo)gridView.GetRow(e.RowHandle);
                if (item != null)
                {
                    ((ProductConstantModule)Screen.Module).ChangeItemMaterialMarketDimensions(item);
                }
            }
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedMaterialMarketDimensions();
            }
        }

        #region old code
        //public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataSet ds = (DataSet)BOSApp.LookupTables[TableName.ICProductattributesTableName];
        //    if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
        //    {
        //        ds = BOSApp.GetLookupTableData(TableName.ICProductattributesTableName);
        //        GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == TableName.ICProductattributesTableName).FirstOrDefault();

        //        if (lookupTable != null)
        //        {
        //            BOSApp.LookupTables.Add(TableName.ICProductattributesTableName, ds);
        //            BOSApp.LookupTablesUpdatedDate.Add(TableName.ICProductattributesTableName, DateTime.Now);
        //            BOSApp.LookupTableObjects.Add(TableName.ICProductattributesTableName, lookupTable);
        //        }
        //    }
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    objProductAttributesInfo.ICProductAttributeID = 0;
        //    productAttributeList = (List<ICProductAttributesInfo>)objProductAttributesController.GetListFromDataSet(ds);
        //    if (productAttributeList != null)
        //    {
        //        productAttributeList = productAttributeList.Where(p => p.ICProductAttributeGroup == MatchCodeConst.MatchCodePackingMaterialWeightPerVolumeColumnName).ToList();
        //        productAttributeList.Insert(0, objProductAttributesInfo);
        //        lookUpEdit.Properties.DataSource = productAttributeList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
        //    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        //}

        //private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        //{
        //    if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
        //    {
        //        if (e.Value != null)
        //        {
        //            e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ICProductattributesTableName, "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
        //        }
        //    }
        //}
        #endregion

    }
}

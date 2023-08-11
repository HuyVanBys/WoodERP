using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPlan
{
    public class MMWoodPlanItemDetailMainsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            WoodPlanEntities entity = (WoodPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.WoodPlanItemDetailMainList;
            this.DataSource = bds;
        }

        //protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);
        //}

        //protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    base.GridView_CellValueChanged(sender, e);
        //    GridView gridView = (GridView)sender;
        //    if (gridView.FocusedRowHandle >= 0)
        //    {
        //        MMWoodPlanItemDetailsInfo item = (MMWoodPlanItemDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //        if (item != null)
        //        {
        //            if (e.Column.FieldName == "MMWoodPlanItemDetailHeight" ||
        //                e.Column.FieldName == "MMWoodPlanItemDetailWidth" ||
        //                e.Column.FieldName == "MMWoodPlanItemDetailLength")
        //            {
        //                (Screen.Module as WoodPlanModule).CalculateDetailInfo(item);
        //            }
        //        }
        //    }
        //}


        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //    GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
            //    gridView.OptionsView.ShowFooter = true;


            //    if (gridView.Columns["MMWoodPlanItemDetailHeight"] != null)
            //    {
            //        gridView.Columns["MMWoodPlanItemDetailHeight"].OptionsColumn.AllowEdit = true;
            //    }

            //    if (gridView.Columns["MMWoodPlanItemDetailWidth"] != null)
            //    {
            //        gridView.Columns["MMWoodPlanItemDetailWidth"].OptionsColumn.AllowEdit = true;
            //    }

            if (gridView.Columns["FK_MMBatchProductID"] != null)
            {
                gridView.Columns["FK_MMBatchProductID"].Visible = true;
                gridView.Columns["FK_MMBatchProductID"].Group();
            }

            if (gridView.Columns["FK_ICProductForBatchID"] != null)
            {
                gridView.Columns["FK_ICProductForBatchID"].Visible = true;
            }


            //    gridView.EndGrouping += new EventHandler(gridView_EndGrouping);

            if (gridView.Columns["FK_ICProductAttributeQualityID"] != null)
            {
                gridView.Columns["FK_ICProductAttributeQualityID"].OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Chất lượng"));

                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                //gridView.Columns["FK_ICProductAttributeQualityID"].ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.ExpandAllGroups();
            return gridView;
        }


        //void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        //{

        //    if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
        //    {
        //        if (e.Value != null)
        //        {
        //            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //            objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(Convert.ToInt32(e.Value));
        //            if (objProductAttributesInfo != null)
        //            {
        //                e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
        //            }
        //        }
        //    }
        //}

        //void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    List<ICProductAttributesInfo> productAttributesList = ((WoodPlanModule)Screen.Module).GetProductItemAttributeQuality();
        //    lookUpEdit.Properties.DataSource = productAttributesList;
        //}
        //void gridView_EndGrouping(object sender, EventArgs e)
        //{
        //    GridView gridView = (GridView)MainView;
        //    gridView.ExpandAllGroups();
        //    gridView.BestFitColumns();
        //}

        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((WoodPlanModule)Screen.Module).DeleteItemFromList();
        //    }
        //}
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }
    }
}

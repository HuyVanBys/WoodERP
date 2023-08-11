using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostWood
{
    public class MMProductPriceIncompletesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductPriceIncompletesList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            gridView.GroupFormat = "[#image]{1} {2}";

            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 0;
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
        }

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
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductIDForBatch");
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

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMProductPriceBatchComponent")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ADMatchCodesController objMatchCodesController = new ADMatchCodesController();
                    ADMatchCodesInfo objMatchCodesInfo = (ADMatchCodesInfo)objMatchCodesController.GetObjectByID(matchCodeID);
                    if (objMatchCodesInfo != null)
                        e.DisplayText = objMatchCodesInfo.ADMatchCodeValue;
                    if (matchCodeID == 0)
                    {
                        e.DisplayText = "";
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
    }
}

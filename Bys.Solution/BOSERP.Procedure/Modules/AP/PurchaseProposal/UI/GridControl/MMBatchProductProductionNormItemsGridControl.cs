using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public class MMBatchProductProductionNormItemsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public void InvalidateDataSource(List<MMBatchProductProductionNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "MMBatchProductNo", "Mã LSX");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemNo", "Mã vật tư");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductName", "Tên vật tư");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductDesc", "Mô tả");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductLength", "Dài");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductWidth", "Rộng");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductHeight", "Dày");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantity", "SL cần mua");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemBPQty", "SL theo LSX");
            AddGridColumn(strTableName, "MMAllocationPlanItemPlanedQty", "SL đã KHSD");
            AddGridColumn(strTableName, "APProposalItemQty", "SL đã đề nghị");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantity", "SL cần mua");
            AddGridColumn(strTableName, "ICInventoryStockQty", "SL tồn kho");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemNeededTime", "Thời gian cần");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemSerial", "Mã lô SX");
            AddGridColumn(strTableName, "ICProductFBName", "Tên thành phẩm");
            AddGridColumn(strTableName, "ICProductFBDesc", "Mô tả thành phẩm");
            AddGridColumn(strTableName, "FK_MMOperationID", "Công đoạn", "MMOperations", "MMOperationName", "MMOperationID");
            AddGridColumn(strTableName, "FK_MMWorkShopID", "Xưởng", "MMWorkShops", "MMWorkShopName", "MMWorkShopID");
            AddGridColumn(strTableName, "FK_ICProductAttributeWoodTypeID", "Loại nguyên liệu", "ICProductAttributes", "ICProductAttributeValue", "ICProductAttributeID");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "")
        {

            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAAllowDummy = true,
                Visible = true
            });
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = new ICProductsInfo();
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductNo;
                    }
                }
            }
        }
    }
}

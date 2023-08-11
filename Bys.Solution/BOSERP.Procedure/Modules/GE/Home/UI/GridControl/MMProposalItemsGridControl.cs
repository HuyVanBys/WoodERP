using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public class MMProposalItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMProposalItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = HomeLocalizedResources.ProductionNormCaption;
            column.FieldName = "FK_MMProductionNormID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemLookUpEdit productionNormNoLookUpEdit = new RepositoryItemLookUpEdit();
            productionNormNoLookUpEdit.DisplayMember = "MMProductionNormNo";
            productionNormNoLookUpEdit.ValueMember = "MMProductionNormID";
            productionNormNoLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            productionNormNoLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            productionNormNoLookUpEdit.NullText = string.Empty;
            productionNormNoLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormNo", "Mã BĐM"));
            productionNormNoLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormName", "Tên BĐN"));
            productionNormNoLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductionNormNoLookUpEdit_QueryPopUp);
            column.ColumnEdit = productionNormNoLookUpEdit;
            gridView.Columns.Add(column);

            GridColumn column1 = new GridColumn();
            column1.Caption = "Trạng thái BOM";
            column1.FieldName = "MMProposalItemBOMStatus";
            column1.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column1);
        }

        void ProductionNormNoLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            GridView gridview = this.MainView as GridView;
            MMProposalItemsInfo objProposalItemsInfo = gridview.GetRow(gridview.FocusedRowHandle) as MMProposalItemsInfo;
            if (objProposalItemsInfo == null)
                objProposalItemsInfo = new MMProposalItemsInfo();
            List<MMProductionNormsInfo> productionNormList = objProductionNormsController.GetAllProductionNormByProductIDAndSaleOrderItemID(objProposalItemsInfo.FK_ICProductID, objProposalItemsInfo.FK_ARSaleOrderItemID);
            if (productionNormList == null)
                productionNormList = new List<MMProductionNormsInfo>();
            lookUpEdit.Properties.DataSource = productionNormList;
            if (productionNormList.Count() != 0)
                return;
            List<MMProductionNormsInfo> productionNormByProductList = objProductionNormsController.GetAllProductionNormByProductIDAndStyle(objProposalItemsInfo.FK_ICProductID
                                                                                                                                           , objProposalItemsInfo.MMProposalItemProductWidth
                                                                                                                                           , objProposalItemsInfo.MMProposalItemProductHeight
                                                                                                                                           , objProposalItemsInfo.MMProposalItemProductLength);
            productionNormByProductList = productionNormByProductList.Where(o => o.FK_ARSaleOrderItemID != objProposalItemsInfo.FK_ARSaleOrderItemID).ToList();
            if (productionNormByProductList.Count() > 0)
            {
                DialogResult rs = MessageBox.Show(HomeLocalizedResources.DuplicateProductionNormMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.Yes)
                    return;
                MMProductionNormsInfo objProductionNormLastVersionInfo = productionNormByProductList.LastOrDefault();
                if (objProductionNormLastVersionInfo == null)
                    objProductionNormLastVersionInfo = new MMProductionNormsInfo();
                BaseModuleERP productionNormModule = null;
                if (BOSApp.IsOpenedModule(ModuleName.ProductionNorm))
                {
                    productionNormModule = (BaseModuleERP)BOSApp.OpenModules[ModuleName.ProductionNorm];
                }
                else
                {
                    productionNormModule = BOSApp.ShowModule(ModuleName.ProductionNorm);
                }
                if (productionNormModule == null)
                    return;
                productionNormModule.Invalidate(objProductionNormLastVersionInfo.MMProductionNormID);
                //productionNormModule.ActionDuplicateSameNo(objProposalItemsInfo);
            }
            else
            {
                DialogResult rs = MessageBox.Show(HomeLocalizedResources.CreatedProductionNormMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.Yes)
                    return;
                BaseModuleERP productionNormModule = BOSApp.ShowModule(ModuleName.ProductionNorm);
                if (productionNormModule == null)
                    return;
                // productionNormModule.ActionNewFromProposalItem(objProposalItemsInfo);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

            if (e.Column.FieldName == "FK_ICProductAttributeTTMTID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "MMProposalItemPackagingRequimentType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProposalItemPackagingRequimentType", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }

            if (e.Column.FieldName == "FK_ICProductAttributeHTTypeID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAttributeColorID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
                        ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                        objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(value);
                        if (objProductAttributesInfo != null)
                        {
                            e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                        }
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductsInfo objProductsInfo = new ICProductsInfo();
                        ICProductsController objProductsController = new ICProductsController();
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(value);
                        if (objProductsInfo != null)
                        {
                            e.DisplayText = objProductsInfo.ICProductNo;
                        }
                    }
                }
            }
        }
    }
}

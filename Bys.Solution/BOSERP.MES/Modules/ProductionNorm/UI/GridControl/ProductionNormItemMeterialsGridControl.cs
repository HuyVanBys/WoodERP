using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using System.Collections.Generic;
using System.Linq;

using BOSERP.Modules.ProductionNorm.UI;
using System;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormItemMeterialGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMProductionNormItemMeterialsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemGridLookUpEdit repositoryItemLookUpEdit = new RepositoryItemGridLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductDesc";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;
                
                repositoryItemLookUpEdit.NullText = string.Empty;
                GetLookupDataSource(repositoryItemLookUpEdit);
                repositoryItemLookUpEdit.ImmediatePopup = true;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
              
                repositoryItemLookUpEdit.EditValueChanged += new EventHandler(repositoryItemProductWoodLookupEdit_EditValueChanged);
                //repositoryItemLookUpEdit.KeyPress += new KeyPressEventHandler(repositoryItemLookUpEdit_KeyPress);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ICProductAlternativeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemGridLookUpEdit repositoryItemLookUpEdit = new RepositoryItemGridLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductDesc";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.PopupFilterMode = PopupFilterMode.Contains;

                repositoryItemLookUpEdit.NullText = string.Empty;
                GetLookupDataSource(repositoryItemLookUpEdit);
                repositoryItemLookUpEdit.ImmediatePopup = true;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            if (gridView.Columns["MMProductionNormItemMeterialWoodBlocks"] != null)
            {
                gridView.Columns["MMProductionNormItemMeterialWoodBlocks"].OptionsColumn.AllowEdit = false;
                InitColumnSummary("MMProductionNormItemMeterialWoodBlocks", DevExpress.Data.SummaryItemType.Sum);
            }
           
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int ProductID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", ProductID, "ICProductDesc");
                }
            }
            if (e.Column.FieldName == "FK_ICProductAlternativeID")
            {
                if (e.Value != null)
                {
                    int ProductID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", ProductID, "ICProductDesc");
                }
            }
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemMeterialsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            MMProductionNormItemsInfo objProductionNormItemsInfo
                    = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductID == objProductionNormItemMeterialsInfo.FK_ICProductID).FirstOrDefault();
            if ((e.Column.FieldName == "MMProductionNormItemMeterialQty"))
            { 
                if (objProductsInfo != null && objProductsInfo.ICProductHeight > 0)
                {
                    if (objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth != objProductsInfo.ICProductHeight)
                    {
                        DialogResult dlgResult = 
                            MessageBox.Show(string.Format("Dày cấp đang khác với độ dày nguyên liệu: {0}, bạn có chắc muốn thay đổi không?", objProductsInfo.ICProductHeight)
                            , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlgResult == DialogResult.No)
                        {
                            objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth = objProductsInfo.ICProductHeight;
                        }
                    }
                }
            }

             if ((e.Column.FieldName == "MMProductionNormItemMeterialLength" || 
                 e.Column.FieldName == "MMProductionNormItemMeterialWidth" ||
                 e.Column.FieldName == "MMProductionNormItemMeterialHeigth" ||
                 e.Column.FieldName == "MMProductionNormItemMeterialQty"))
            {
                if (objProductionNormItemMeterialsInfo.FK_ICProductID > 0)
                {
                    
                    if (objProductsInfo != null &&  objProductsInfo.FK_ICProductAttributeWoodTypeID > 0)
                    {
                        if (objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialLength > 0
                            && objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWidth > 0
                            && objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth > 0)
                        {
                            if (objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty == 0)
                            {
                                DialogResult dlgResult = MessageBox.Show("Hệ thống sẽ mặc định số tấm cần cấp bằng số lượng chi tiết?"
                                          , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dlgResult == DialogResult.Yes)
                                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty = objProductionNormItemsInfo.MMProductionNormItemQuantity;
                                else
                                    objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialQty = 1;
                            }
                            ((ProductionNormModule)Screen.Module).ResetBlockByConfigWoodType(objProductionNormItemMeterialsInfo, objProductsInfo);
                        }
                        else
                        {
                            objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks = objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable;
                        }
                    }
                    else
                    {
                        objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks = objProductionNormItemsInfo.MMProductionNormItemTotalWoodConsumable;
                    }
                }
            }
 
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (objProductionNormItemMeterialsInfo == null || objProductionNormItemMeterialsInfo.FK_ICProductID == 0) return;
                ((ProductionNormModule)Screen.Module).ValidateChangeMeterial(objProductionNormItemMeterialsInfo, objProductionNormItemMeterialsInfo.FK_ICProductID);
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        public void GetLookupDataSource(RepositoryItemGridLookUpEdit lookUpEdit)
        {
            ICProductsController objProductsController = new ICProductsController();
            MMProductionNormItemsInfo objProductionNormItemsInfo
                    = ((guiProductionNormItemMeterials)this.Screen).objProductionNormItemsInfo;
            if (objProductionNormItemsInfo != null)
            {
                string woodTypeSrt = objProductionNormItemsInfo.MMProductionNormItemProductWoodType;
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                ICProductAttributesInfo objProductAttributesInfo
                    = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesProductAttributeValue(woodTypeSrt);

                if (objProductAttributesInfo != null)
                {
                    DataSet ds = objProductsController.GetDataProductByProductWoodTypeID(objProductAttributesInfo.ICProductAttributeID);
                    DevExpress.XtraGrid.Columns.GridColumn col1 = lookUpEdit.View.Columns["ICProductNo"];
                    DevExpress.XtraGrid.Columns.GridColumn col2 = lookUpEdit.View.Columns["ICProductDesc"];
                    if (col1 == null)
                        col1 = lookUpEdit.View.Columns.AddField("ICProductNo");
                    if (col2 == null)
                        col2 = lookUpEdit.View.Columns.AddField("ICProductDesc");
                    col1.Caption = "Mã nguyên liệu";
                    col1.VisibleIndex = 0;
                    col2.Caption = "Mô tả";
                    col2.VisibleIndex = 1;
                    lookUpEdit.DataSource = ds.Tables[0];
                    ds.Dispose();
                }
            }
        }

        protected void repositoryItemProductWoodLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit lke = sender as GridLookUpEdit;

            GridView gridView = (GridView)this.MainView;
            int productID = 0;
            if (int.TryParse(lke.EditValue.ToString(), out productID))
            {
                MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemMeterialsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objProductionNormItemMeterialsInfo == null) return;
                ((ProductionNormModule)Screen.Module).ValidateChangeMeterial(objProductionNormItemMeterialsInfo, productID);
            }
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemMeterialsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objProductionNormItemMeterialsInfo != null)
                    {
                        ((guiProductionNormItemMeterials)Screen).RemoveProductionNormItemMeterialsInfo(objProductionNormItemMeterialsInfo);
                        gridView.DeleteSelectedRows();
                    }
                }
                
            }
        }
    }
}

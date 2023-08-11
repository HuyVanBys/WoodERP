using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public class MMBatchProductItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BatchProductItemList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMBatchProductItemDesc" ||
                    column.FieldName == "MMBatchProductItemProductQty" ||
                    column.FieldName == "MMBatchProductItemProductSerial" ||
                    column.FieldName == "MMBatchProductItemIsNewProduct" ||
                    column.FieldName == "MMBatchProductItemIsJoinComponent" ||
                    column.FieldName == "MMBatchProductItemHardwareRemark" ||
                    column.FieldName == "MMBatchProductItemLabelCorlor" ||
                    column.FieldName == "MMBatchProductItemProductCard" ||
                    column.FieldName == "MMBatchProductItemProductFSCCard" ||
                    column.FieldName == "MMBatchProductItemProductLabel" ||
                    column.FieldName == "MMBatchProductItemProductHDLR" ||
                    column.FieldName == "MMBatchProductItemProductHDSD" ||
                    column.FieldName == "MMBatchProductItemProductBarcode" ||
                    column.FieldName == "MMBatchProductItemProductWarranty" ||
                    column.FieldName == "FK_MMProductionNormID" ||
                    column.FieldName == "MMBatchProductItemPeriod" ||
                    column.FieldName == "MMBatchProductItemDeliveryDate" ||
                    column.FieldName == "MMBatchProductItemNeededTime" ||
                    column.FieldName == "MMBatchProductItemResourceType" ||
                    column.FieldName == "MMBatchProductItemSemiProductRemark" ||
                    column.FieldName == "MMBatchProductItemProductRemark" ||
                    column.FieldName == "MMBatchProductItemWoodRemark" ||
                    column.FieldName == "MMBatchProductItemPackagingRemark" ||
                    column.FieldName == "MMBatchProductItemPaintRemark" ||
                    column.FieldName == "MMBatchProductItemGeneralMaterialRemark" ||
                     column.FieldName == "FK_ICProductAttributePaintTypeID")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                if (column.FieldName == "FK_MMProductionNormID")
                {

                    column.Caption = "BĐM sử dụng";

                    RepositoryItemBOSLookupEdit repProductionNorm = new RepositoryItemBOSLookupEdit();
                    repProductionNorm.DisplayMember = "MMProductionNormNo";
                    repProductionNorm.ValueMember = "MMProductionNormID";
                    repProductionNorm.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                    repProductionNorm.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repProductionNorm.NullText = string.Empty;
                    repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormNo", "Mã BDM"));
                    //repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormOldProductNo", "Mã SP HT cũ"));
                    repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormName", "Tên BOM"));
                    repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormDesc", "Mô tả"));
                    //repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormSemiProductDesc", "Mô tả ĐM BTP"));
                    //repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormHardwareDesc", "Mô tả ĐM Hardware"));
                    //repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormIngredientPaintDesc", "Mô tả ĐM Sơn"));
                    //repProductionNorm.Columns.Add(new LookUpColumnInfo("MMProductionNormIngredientPackagingDesc", "Mô tả ĐM PLDG"));
                    repProductionNorm.QueryPopUp += new System.ComponentModel.CancelEventHandler(repProductionNorm_QueryPopUp);
                    column.ColumnEdit = repProductionNorm;

                }
                if (column.FieldName == "MMBatchProductItemPackagingRequimentType")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                if (column.FieldName == "MMBatchProductItemProductQty")
                {
                    STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMBatchProductItems", "MMBatchProductItemProductQty", this.Screen.Module.ModuleID);
                    if (formatsInfo != null)
                    {
                        FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                    }                   
                }
                if (column.FieldName == "MMBatchProductItemProducedQty")
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMBatchProductItems", "MMBatchProductItemProductQty", this.Screen.Module.ModuleID);
                    if (formatsInfo != null)
                    {
                        FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                    }
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Chi tiết";
                    rep1.Click += new EventHandler(ViewResult);
                    column.ColumnEdit = rep1;
                }
                if (column.FieldName == "MMBatchProductItemRemainQty")
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMBatchProductItems", "MMBatchProductItemProductQty", this.Screen.Module.ModuleID);
                    if (formatsInfo != null)
                    {
                        FormatNumbericColumn(column, false, formatsInfo.STFieldFormatGroupFormatString);
                    }
                }
                else if (column.FieldName == "ChangeBOM")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Thay đổi định mức";
                    rep1.Click += new EventHandler(ViewBOMChange);
                    column.ColumnEdit = rep1;
                }
                else if (column.FieldName == "ChangeQty")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Thay đổi số lượng";
                    rep1.Click += new EventHandler(ViewChangeQty);
                    column.ColumnEdit = rep1;
                }
                else if (column.FieldName == "ChangeHistory")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Chi tiết";
                    rep1.Click += new EventHandler(ViewChangeHistory);
                    column.ColumnEdit = rep1;
                }
                else if (column.FieldName == "CloseStatus")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Chi tiết";
                    rep1.Click += new EventHandler(ViewChangeHistory);
                    column.ColumnEdit = rep1;
                }
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(gridView_ValidatingEditor);
            gridView.CustomColumnDisplayText += GridView_CustomColumnDisplayText;
            return gridView;
        }

        private void GridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_MMProductionNormID" && e.Value != null && e.Value != DBNull.Value)
            {
                int pnID = int.Parse(e.Value.ToString());
                if (pnID == 0)
                    return;

                MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                DataRow dr = BOSApp.GetObjectFromCatche("MMProductionNorms", "MMProductionNormID", pnID);
                MMProductionNormsInfo objProductionNormsInfo;
                if (dr != null)
                    objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectFromDataRow(dr);
                else
                    objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(pnID);

                e.DisplayText = objProductionNormsInfo?.MMProductionNormNo;
            }
        }

        private void ViewBOMChange(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMBatchProductItemsInfo obj = (MMBatchProductItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((BatchProductModule)Screen.Module).ViewBOMChange(obj, true);
                }
            }
        }

        private void ViewChangeQty(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMBatchProductItemsInfo obj = (MMBatchProductItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((BatchProductModule)Screen.Module).ViewBOMChange(obj, false);
                }
            }
        }

        private void ViewResult(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    XtraReportHelper.ShowRefFromModule(new BOSList<ADTemplateParamsInfo>(), item, this.Screen.Module.Controls, this.Screen.Module.Name, this.Screen.Module, gridView.FocusedColumn.FieldName);
                }
            }
        }

        private void ViewChangeHistory(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    XtraReportHelper.ShowRefFromModule(new BOSList<ADTemplateParamsInfo>(), item, this.Screen.Module.Controls, this.Screen.Module.Name, this.Screen.Module, gridView.FocusedColumn.FieldName);
                }
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMBatchProductItemProductQty")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)gridView.GetRow(e.RowHandle);
                            if (item != null && item.IsError)
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
                else if (e.Column.FieldName == "MMBatchProductItemIsNeedMergeWood"
                    || e.Column.FieldName == "MMBatchProductItemIsNeedMergeHW"
                    || e.Column.FieldName == "MMBatchProductItemIsNeedMergePaint"
                    || e.Column.FieldName == "MMBatchProductItemIsNeedMergePackaging"
                    || e.Column.FieldName == "MMBatchProductItemIsNeedMergeGeneralMaterial"
                    || e.Column.FieldName == "MMBatchProductItemIsNeedMergeCarcassProcess"
                    || e.Column.FieldName == "MMBatchProductItemIsNeedMergeColorProcess")
                {
                    if (e.CellValue != null)
                    {
                        bool isNeedMerge;
                        if (bool.TryParse(e.CellValue.ToString(), out isNeedMerge))
                        {
                            if (isNeedMerge)
                            {
                                e.Appearance.BackColor = Color.Orange;
                                e.Appearance.BackColor2 = Color.Orange;
                            }
                        }
                    }
                }
            }
        }

        void gridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)entity.MainObject;
            if (!(this.Screen.Module as BaseModuleERP).Toolbar.IsNullOrNoneAction())
            {
                if (objBatchProductsInfo.MMBatchProductOperationStatus != BatchProductStatus.New.ToString()
                   || objBatchProductsInfo.MMBatchProductHWStatus != BatchProductStatus.New.ToString()
                   || objBatchProductsInfo.MMBatchProductPackagingStatus != BatchProductStatus.New.ToString()
                   || objBatchProductsInfo.MMBatchProductPaintStatus != BatchProductStatus.New.ToString()
                   || objBatchProductsInfo.MMBatchProductWoodStatus != BatchProductStatus.New.ToString())
                {
                    e.ErrorText = "LSX đã kiểm tra hoặc duyệt. Không thể chỉnh sửa!" + Environment.NewLine + "Nhấn Esc để tiếp tục.";
                    e.Valid = false;

                }

            }
        }

        public void repProductionNorm_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridView = (GridView)MainView;
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            if (gridView.FocusedRowHandle >= 0)
            {
                objBatchProductItemsInfo = (MMBatchProductItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            }

            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            List<MMProductionNormsInfo> ProductionNormsList = new List<MMProductionNormsInfo>();
            MMProductionNormsInfo objProductionNormsInfo = new MMProductionNormsInfo();
            objProductionNormsInfo.MMProductionNormID = 0;
            int product = 0;
            if (objBatchProductItemsInfo != null)
            {
                product = objBatchProductItemsInfo.FK_ICProductID;
            }
            ProductionNormsList = objProductionNormsController.GetApprovedProductionNormByProductID(product);
            ProductionNormsList = ProductionNormsList.Where(pn => (pn.MMProductionNormHardwareStatus == "Approved"
                                                            || pn.MMProductionNormWoodStatus == "Approved"
                                                            || pn.MMProductionNormPackingMaterialStatus == "Approved"
                                                            || pn.MMProductionNormPaintStatus == "Approved"
                                                            || pn.MMProductionNormStatus == "Approved") && pn.MMProductionNormStatus != "Canceled").ToList();
            if (ProductionNormsList != null)
            {
                lookUpEdit.Properties.DataSource = ProductionNormsList;
            }
            lookUpEdit.Properties.DisplayMember = "MMProductionNormNo";
            lookUpEdit.Properties.ValueMember = "MMProductionNormID";

            lookUpEdit.Properties.BestFit();
            int width = 0;
            foreach (LookUpColumnInfo column in lookUpEdit.Properties.Columns)
                width += column.Width;
            lookUpEdit.Properties.PopupWidth = width + 4;
        }

        public void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeID" || e.Column.FieldName == "FK_ICProductAttributeColor" || e.Column.FieldName == "FK_ICProductAttributePaintType")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", value, "ICProductAttributeValue");
                    }
                }
            }
            //if (e.Column.FieldName == "MMBatchProductItemPackagingRequimentType")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = ADConfigValueUtility.GetTextFromKey(e.Value.ToString(), "BatchProductItemPackagingRequimentType");
            //    }
            //}
            if (e.Column.FieldName == "FK_MMProductionNormID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMProductionNorms", "MMProductionNormID", value, "MMProductionNormNo");
                    }
                }
            }

        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((BatchProductModule)Screen.Module).DeleteItemFromBatchProductItemList();
            }
        }

        public void repPriorityPackaging_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("BatchProductItemPackagingRequimentType");
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                ConfigValuesList.Add(objConfigValuesInfo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            if (ConfigValuesList != null)
            {
                lookUpEdit.Properties.DataSource = ConfigValuesList;
            }
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            BatchProductEntities entity = (BatchProductEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            //gridView.ActiveEditor.OldEditValue;
            if (entity.BatchProductItemList.CurrentIndex >= 0)
            {
                if (item != null) item.IsError = false;
                if (item.FK_ARProductionPlanningID > 0)
                {
                    if (e.Column.FieldName == "MMBatchProductItemResourceType")
                    {
                        if (e.Value != null)
                        {
                            ((BatchProductModule)Screen.Module).ChangeResourceTypeForProductionNormItem(e.Value.ToString());
                        }
                    }
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        if (e.Column.FieldName == "MMBatchProductItemProductQty")
                        {
                            if (e.Value != null && decimal.Parse(e.Value.ToString()) > item.MMBatchProductItemRemainQty)
                            {
                                MessageBox.Show(string.Format("Số lượng không được lớn hơn số lượng còn lại!"), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                entity.BatchProductItemList[entity.BatchProductItemList.CurrentIndex].MMBatchProductItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            }
                        }
                    }

                }
                else if (item.FK_ARProductionPlanningID == 0 && item.FK_MMProposalItemID == 0)
                {
                    if (e.Column.FieldName == "MMBatchProductItemProductQty")
                    {
                        if (!(entity.Module as BatchProductModule).CheckSORemainQuantity(item))
                        {
                            entity.BatchProductItemList[entity.BatchProductItemList.CurrentIndex].MMBatchProductItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                    }
                }
                if (gridView.FocusedColumn.FieldName == "MMBatchProductItemProductQty" && item.FK_MMProposalItemID != 0)
                {
                    if (decimal.Parse(e.Value.ToString()) > item.MMBatchProductItemRemainQty)
                    {
                        MessageBox.Show(string.Format("Số lượng không được lớn hơn số lượng đề nghị"), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        entity.BatchProductItemList[entity.BatchProductItemList.CurrentIndex].MMBatchProductItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
                entity.ModuleObjects[TableName.MMBatchProductItemsTableName] = (MMBatchProductItemsInfo)entity.BatchProductItemList[entity.BatchProductItemList.CurrentIndex].Clone();
                (entity.Module as BatchProductModule).ChangeItemFromBatchProductItemList();
            }

        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Tên SP tiếng Việt";
            newColumn.FieldName = "ICProductName2";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã HT cũ";
            newColumn.FieldName = "ICProductNoOfOldSys";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã đơn hàng nội bộ";
            newColumn.FieldName = "MMBatchProductItemSOName";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);
        }
    }
}

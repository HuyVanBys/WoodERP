using BOSCommon;
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
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class MMBPItemGeneralMaterialGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }


        public List<MMOperationsInfo> OperationDataSource = new List<MMOperationsInfo>();

        private ICProductsForViewInfo CurrentProductsInfo { get; set; }

        public void InvalidateDataSource(List<MMBatchProductProductionNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ICProductID"];
            {
                RepositoryItemBOSLookupEdit repositoryItemLookupEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookupEdit.DisplayMember = "ICProductNo";
                repositoryItemLookupEdit.ValueMember = "ICProductID";
                repositoryItemLookupEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookupEdit.SearchMode = SearchMode.AutoFilter;
                repositoryItemLookupEdit.NullText = string.Empty;
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repositoryItemLookupEdit.DataSource = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.GeneralMaterial.ToString()
                                                                                           || o.ICProductType == ProductType.IngredientPackaging.ToString()
                                                                                           || o.ICProductType == ProductType.ArtificialBoard.ToString()
                                                                                           || o.ICProductType == ProductType.IngredientPaint.ToString()
                                                                                           || o.ICProductType == ProductType.Equipment.ToString()
                                                                                           || o.ICProductType == ProductType.VVP.ToString()
                                                                                           || o.ICProductType == ProductType.Verneer.ToString()).ToList();
                repositoryItemLookupEdit.CloseUp += new CloseUpEventHandler(rpProduct_CloseUp);
                repositoryItemLookupEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                repositoryItemLookupEdit.MaxLength = 1000;
                column.ColumnEdit = repositoryItemLookupEdit;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;
            }
            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpOperation = new RepositoryItemLookUpEdit();
                rpOperation.DisplayMember = "MMOperationName";
                rpOperation.ValueMember = "MMOperationID";
                rpOperation.NullText = string.Empty;
                rpOperation.Columns.Add(new LookUpColumnInfo("MMOperationName", "Công đoạn"));
                rpOperation.DataSource = OperationDataSource;
                rpOperation.QueryPopUp += new CancelEventHandler(rpOperation_QueryPopUp);
                column.ColumnEdit = rpOperation;
            }
            column = gridView.Columns["MMBatchProductProductionNormItemQuantity"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductProductionNormItemNeededTime"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductProductionNormItemIsOverBTP"];
            if (column != null)
            {
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = false;
            gridView.ValidatingEditor += GridView_ValidatingEditor;
            return gridView;
        }

        private void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (((guiAddMaterialOverBOM)Screen).CurrentPniObjecs == null)
            {
                e.ErrorText = "Vui lòng xác định chi tiết trước khi thêm vật tư!";
                e.Valid = false;
            }
            MMAllocationPlanItemsInfo planItemsInfo = (new MMAllocationPlanItemsController()).GetRemainItemForAlternative(0, item.MMBatchProductProductionNormItemID, item.MMBatchProductProductionNormItemMeterialID, 0);
            if (planItemsInfo != null && planItemsInfo.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
            {
                e.ErrorText = "Vật tư ở trạng thái không thể sửa đổi. Vui lòng xóa vật tư đã kế hoạch!";
                e.Valid = false;
            }
            else if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "MMBatchProductProductionNormItemIsOverBTP" && !((guiAddMaterialOverBOM)Screen).CheckIsProduct())
                {
                    e.ErrorText = "Chi tiết đang chọn không phải thành phẩm";
                    e.Valid = false;
                }
            }
        }

        private void rpOperation_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            if (lke == null)
                return;

            GridView gridView = (GridView)MainView;
            MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            lke.Properties.DataSource = ((guiAddMaterialOverBOM)Screen).GetCurrenProcessList(item);
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "FK_ICProductID", "Mã vật tư");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductName", "Tên vật tư");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductDesc", "Mô tả");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductLength", "Dài");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductWidth", "Rộng");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductHeight", "Dày");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantity", "Số lượng");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemComment", "Ghi chú");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemNeededTime", "Thời gian cần");
            AddGridColumn(strTableName, "FK_MMOperationID", "Công đoạn", "MMOperations", "MMOperationName", "MMOperationID");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemIsOverBTP", "VT dùng chung");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
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

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)MainView;
            if (e.KeyCode == Keys.Delete)
            {
                MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item == null)
                    return;

                bool isSucess = ((guiAddMaterialOverBOM)Screen).DeteteItemMaterial(item);
                if (!isSucess)
                {
                    MessageBox.Show("Vật tư đã được kế hoạch không thể xoá. Vui lòng kiểm tra lại!", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridView.DeleteSelectedRows();
                gridView.RefreshData();
            }
        }

        private void rpProduct_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (lookUpEdit == null)
                return;

            CurrentProductsInfo = (ICProductsForViewInfo)lookUpEdit.Properties.GetDataSourceRowByKeyValue(e.Value);
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            MMBatchProductProductionNormItemsInfo item = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "FK_ICProductID")
            {
                ChangedProduct(CurrentProductsInfo, item);
            }
        }

        public void ChangedProduct(ICProductsForViewInfo productsInfo, MMBatchProductProductionNormItemsInfo item)
        {
            if (productsInfo == null)
                productsInfo = new ICProductsForViewInfo();

            if (productsInfo.ICProductID > 0)
            {
                item.MMBatchProductProductionNormItemNo = productsInfo.ICProductNo;
                item.MMBatchProductProductionNormItemProductName = productsInfo.ICProductName;
                item.MMBatchProductProductionNormItemProductDesc = productsInfo.ICProductDesc;
                item.MMBatchProductProductionNormItemProductLength = productsInfo.ICProductLength;
                item.MMBatchProductProductionNormItemProductWidth = productsInfo.ICProductWidth;
                item.MMBatchProductProductionNormItemProductHeight = productsInfo.ICProductHeight;
                item.FK_ICMeasureUnitID = productsInfo.FK_ICProductBasicUnitID;
            }
        }
    }
}

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
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class MMBPProductionNormItemMaterialsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public List<MMOperationsInfo> OperationDataSource { get; set; }

        private List<MMMaterialDepartmentsInfo> MaterialDepartList { get; set; }

        private ICProductsInfo CurrentProductsInfo { get; set; }

        public int BatchProductItemID { get; set; }

        public void InvalidateDataSource(List<MMBatchProductProductionNormItemMeterialsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            MaterialDepartList = (new MMMaterialDepartmentsController()).GetAllMaterialDepartment();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "FK_ICProductID", "Mã vật tư");
            AddGridColumn(strTableName, "ICProductName", "Tên vật tư");
            AddGridColumn(strTableName, "ICProductDesc", "Mô tả");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemMeterialDesc", "Ghi chú");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemMeterialLength", "Dài");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemMeterialWidth", "Rộng");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemMeterialHeigth", "Dày");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemMeterialQty", "Số lượng");
            //AddGridColumn(strTableName, "MMBatchProductProductionNormItemMeterialDepreciationRate", "Tỉ lệ tiêu hao");
            //AddGridColumn(strTableName, "MMBatchProductProductionNormItemMeterialDepreciationQty", "SL Tiêu hao");
            AddGridColumn(strTableName, "FK_MMOperationID", "Công đoạn", "MMOperations", "MMOperationName", "MMOperationID");
            AddGridColumn(strTableName, "FK_MMBatchProductProductionNormItemID", "Thuộc chi tiết");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            MMBatchProductProductionNormItemMeterialsInfo item = (MMBatchProductProductionNormItemMeterialsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "FK_ICProductID")
            {
                ChangedProduct(CurrentProductsInfo, item);
            }
        }

        private void rpProduct_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (lookUpEdit == null)
                return;

            CurrentProductsInfo = (ICProductsInfo)lookUpEdit.Properties.GetDataSourceRowByKeyValue(e.Value);
        }

        public void ChangedProduct(ICProductsInfo productsInfo, MMBatchProductProductionNormItemMeterialsInfo item)
        {
            if (productsInfo == null)
                productsInfo = new ICProductsInfo();

            if (productsInfo.ICProductID > 0)
            {
                item.ICProductName = productsInfo.ICProductName;
                item.ICProductDesc = productsInfo.ICProductDesc;
                item.MMBatchProductProductionNormItemMeterialLength = productsInfo.ICProductLength;
                item.MMBatchProductProductionNormItemMeterialWidth = productsInfo.ICProductWidth;
                item.MMBatchProductProductionNormItemMeterialHeigth = productsInfo.ICProductHeight;
                item.FK_ICMeasureUnitID = productsInfo.FK_ICProductBasicUnitID;
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ICProductID"];
            {
                MaterialDepartList = (new MMMaterialDepartmentsController()).GetAllMaterialDepartment();
                RepositoryItemBOSLookupEdit materialLookUpEdit = new RepositoryItemBOSLookupEdit();
                materialLookUpEdit.DisplayMember = "ICProductNo";
                materialLookUpEdit.ValueMember = "ICProductID";
                materialLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                materialLookUpEdit.SearchMode = SearchMode.AutoFilter;
                materialLookUpEdit.NullText = string.Empty;
                materialLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                materialLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                materialLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                materialLookUpEdit.DataSource = ((BatchProductSheduleModule)Screen.Module).GetWoodIngredient(MaterialDepartList);
                materialLookUpEdit.CloseUp += new CloseUpEventHandler(rpProduct_CloseUp);
                materialLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                materialLookUpEdit.MaxLength = 1000;
                column.ColumnEdit = materialLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductProductionNormItemMeterialQty"];
            if (column != null)
            {
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
            column = gridView.Columns["MMBatchProductProductionNormItemMeterialLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductProductionNormItemMeterialWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductProductionNormItemMeterialHeigth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = false;
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(gridView_ValidatingEditor);
            return gridView;
        }

        private void gridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            MMBatchProductProductionNormItemMeterialsInfo item = (MMBatchProductProductionNormItemMeterialsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;
            
            if (((guiAddMaterialOverBOM)Screen).CurrentPniObjecs == null)
            {
                e.ErrorText = "Vui lòng xác định chi tiết trước khi thêm vật tư!";
                e.Valid = false;
            }
            MMAllocationPlanItemsInfo planItemsInfo = (new MMAllocationPlanItemsController()).GetRemainItemForAlternative(0, item.FK_MMBatchProductProductionNormItemID, item.MMBatchProductProductionNormItemMeterialID, 0);
            if (planItemsInfo != null && planItemsInfo.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
            {
                e.ErrorText = "Vật tư ở trạng thái không thể sửa đổi. Vui lòng xóa vật tư đã kế hoạch!";
                e.Valid = false;
            }
            
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMBatchProductProductionNormItemMeterialsInfo item = (MMBatchProductProductionNormItemMeterialsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        private void rpOperation_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            if (lke == null)
                return;

            lke.Properties.DataSource = ((guiAddMaterialOverBOM)Screen).GetCurrenProcessList();
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
                MMBatchProductProductionNormItemMeterialsInfo item = (MMBatchProductProductionNormItemMeterialsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
    }
}

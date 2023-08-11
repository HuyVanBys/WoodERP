using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductionNormItemHardwareDetailsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMProductionNormItemHardwaresInfo> dataSource)
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
            //gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
                column.OptionsColumn.AllowEdit = false;

            column = gridView.Columns["FK_ICProductAlternativeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductDesc";
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã thay thế"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodAlternative_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            if (gridView.Columns["MMProductionNormItemHardwareQty"] != null)
            {
                gridView.Columns["MMProductionNormItemHardwareQty"].OptionsColumn.AllowEdit = true;
                InitColumnSummary("MMProductionNormItemHardwareQty", DevExpress.Data.SummaryItemType.Sum);
            }
            if (gridView.Columns["MMProductionNormItemHardwareDesc"] != null)
            {
                gridView.Columns["MMProductionNormItemHardwareDesc"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "FK_ICProductID")
            //{
            //    if (e.Value != null)
            //    {
            //        int ProductID = int.Parse(e.Value.ToString());
            //        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", ProductID, "ICProductNo");
            //    }
            //}
            if (e.Column.FieldName == "FK_ICProductAlternativeID")
            {
                if (e.Value != null)
                {
                    int ProductID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", ProductID, "ICProductNo");
                }
            }
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemHardwaresInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemHardwaresInfo)gridView.GetRow(gridView.FocusedRowHandle);
            MMProductionNormItemsInfo objProductionNormItemsInfo
                    = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;

            if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (objProductionNormItemsInfo != null)
                {
                    if (objProductionNormItemMeterialsInfo == null) objProductionNormItemMeterialsInfo = new MMProductionNormItemHardwaresInfo();
                    objProductionNormItemMeterialsInfo.FK_ICProductID = objProductionNormItemsInfo.FK_ICProductID;
                    objProductionNormItemMeterialsInfo.MMProductionNormItemHardwareProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                    objProductionNormItemMeterialsInfo.MMProductionNormItemHardwareProductDesc = objProductionNormItemsInfo.MMProductionNormItemProductDesc;
                    objProductionNormItemMeterialsInfo.FK_ICMeasureUnitID = objProductionNormItemsInfo.FK_ICMeasureUnitID;
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        public void repositoryItemLookUpEditWoodAlternative_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMProductionNormItemHardwaresInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemHardwaresInfo)gridView.GetRow(gridView.FocusedRowHandle);
            int ProductID = objProductionNormItemMeterialsInfo.FK_ICProductID;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(ProductID);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductsInfo> objProductsInfoList = objProductsController.GetProductByDepartmentID(DepartmentID.Hardware);
            if (objProductsInfoList != null && objProductsInfoList.Count > 0)
            {
                objProductsInfoList = objProductsInfoList.Where(t => t.ICProductType == objProductsInfo.ICProductType).ToList();
                lookUpEdit.Properties.DataSource = objProductsInfoList;
            }
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    MMProductionNormItemHardwaresInfo objProductionNormItemHardwaresInfo = (MMProductionNormItemHardwaresInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objProductionNormItemHardwaresInfo != null)
                    {
                        ((guiProductionNormItemHardware)Screen).RemoveProductionNormItemHardwaresInfo(objProductionNormItemHardwaresInfo);
                        gridView.DeleteSelectedRows();
                    }
                }

            }
        }
    }
}

using BOSCommon;
using BOSCommon.Constants;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public class ARDeliveryPlanItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARDeliveryPlanItemsList;
            this.DataSource = bds;
        }

        public enum DeliveryPlanItemsColumnName
        {
            ARDeliveryPlanItemProductQty,
            ARDeliveryPlanItemAddress,
            ARDeliveryPlanItemDeliveryActualDate,
            ARDeliveryPlanItemCommand,
            FK_ICStockID,
            ACObjectAccessKey,
            FK_ICMeasureUnitID,
            FK_ACCostCenterID,
            ARDeliveryPlanItemProductSerialNo,
            ARDeliveryPlanItemQuantityOfBox
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Hạng mục";
            column.FieldName = "ARProposalTemplateItemProductName";
            column.OptionsColumn.AllowEdit = false;

            RepositoryItemButtonEdit repoItemBtnEdit = new RepositoryItemButtonEdit();
            repoItemBtnEdit.AllowMouseWheel = false;
            repoItemBtnEdit.AutoHeight = false;
            repoItemBtnEdit.Name = "ARProposalTemplateItemProductName";
            repoItemBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repoItemBtnEdit.ButtonClick += RepoItemBtnEdit_ButtonClick;
            column.ColumnEdit = repoItemBtnEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thành phần";
            column.FieldName = "ARDeliveryPlanItemComponents";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit repoItemHyperLinkEdit = new RepositoryItemHyperLinkEdit();
            repoItemHyperLinkEdit.Click += new System.EventHandler(RepoItemHyperLinkEdit_ButtonClick);
            repoItemHyperLinkEdit.NullText = "Xác định thành phần";
            column.ColumnEdit = repoItemHyperLinkEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderName";
            column.Caption = "Mã đơn hàng nội bộ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
        private void RepoItemBtnEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ((DeliveryPlanModule)Screen.Module).ShowTemplateItemTree();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            ACObjectsController objObjectsController = new ACObjectsController();

            if (gridView.Columns[DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString()] != null)
            {
                GridColumn column = gridView.Columns[DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString()];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
                repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemEmployeeOwnerLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            new DeliveryPlanItemsColumnName[]
            {
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemProductQty,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemAddress,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemDeliveryActualDate,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemCommand,
                DeliveryPlanItemsColumnName.FK_ICStockID,
                DeliveryPlanItemsColumnName.ACObjectAccessKey,
                DeliveryPlanItemsColumnName.FK_ICMeasureUnitID,
                DeliveryPlanItemsColumnName.FK_ACCostCenterID,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemProductSerialNo,
                DeliveryPlanItemsColumnName.ARDeliveryPlanItemQuantityOfBox
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            if (gridView.Columns["FK_ICSectionProductID"] != null)
            {
                GridColumn column = gridView.Columns["FK_ICSectionProductID"];
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = GetAllSectionProduct();
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã hạng mục"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên hạng mục"));
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpSectionProduct_QueryPopUp);
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
            }

            GridColumn column1 = gridView.Columns["FK_ICMeasureUnitID"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds1 = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds1.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                rpMeasureUnit.CloseUp += new CloseUpEventHandler(rpMeasureUnit_CloseUp);
                column1.ColumnEdit = rpMeasureUnit;
            }

            column1 = gridView.Columns["ARDeliveryPlanItemProductSerialNo"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICProductSerieNo";
                rpMeasureUnit.ValueMember = "ICProductSerieNo";
                rpMeasureUnit.NullText = string.Empty;
                //DataSet ds1 = BOSApp.LookupTables[TableName.ICProductSeriesTableName] as DataSet;
                //if(ds1 == null)
                //{
                //    ds1 = BOSApp.GetLookupTableData(TableName.ICProductSeriesTableName);
                //    BOSApp.LookupTables[TableName.ICProductSeriesTableName] = ds1;
                //    LookupTablesUpdatedDate.Add(TableName.ICProductSeriesTableName, BOSApp.GetCurrentServerDate());
                //}                
                //rpMeasureUnit.DataSource = ds1.Tables[0];
                column1.ColumnEdit = rpMeasureUnit;
            }
            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (e.Column.FieldName == DeliveryPlanItemsColumnName.ARDeliveryPlanItemProductQty.ToString())
                ((DeliveryPlanModule)Screen.Module).CheckDeliveryPlanItemProductQty();
            if (e.Column.FieldName == DeliveryPlanItemsColumnName.ACObjectAccessKey.ToString())
                ((DeliveryPlanModule)Screen.Module).ChangeObjectItem();
            if (gridView.FocusedRowHandle >= 0)
            {
                ARDeliveryPlanItemsInfo item = (ARDeliveryPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((DeliveryPlanModule)Screen.Module).SelectSeriesNoDefault();
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((DeliveryPlanModule)Screen.Module).ChangeItemMeasureUnit();
                }
                if (e.Column.FieldName == "ARDeliveryPlanItemProductSerialNo")
                {
                    ((DeliveryPlanModule)Screen.Module).UpdateLotNoItem(item);
                    ((DeliveryPlanModule)Screen.Module).ChangeItemProductUnitCost(item);
                    gridView.RefreshData();
                }
                if (e.Column.FieldName == "ARDeliveryPlanItemProductQty")
                {
                    item.ARDeliveryPlanItemProductExchangeQty = item.ARDeliveryPlanItemProductQty * item.ARDeliveryPlanItemProductFactor;
                    gridView.RefreshData();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((DeliveryPlanModule)Screen.Module).DeleteItemFromDeliveryPlanItemsList();
            }
        }

        public List<ICProductsInfo> GetAllSectionProduct()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetAllSectionAndWorkProduct();
            return productList;
        }

        private void rpSectionProduct_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                if (lookUpEdit != null)
                    lookUpEdit.Properties.DataSource = ((DeliveryPlanModule)Screen.Module).GetAllSectionProductForLookUp();
                gridView.RefreshData();
            }
        }

        private void rpMeasureUnit_CloseUp(object sender, CloseUpEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                DeliveryPlanEntities entity = (DeliveryPlanEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARDeliveryPlanItemsInfo item = (ARDeliveryPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                decimal itemQty = item.ARDeliveryPlanItemProductQty;
                GeneralHelper.ChangeDeliveryItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                item.ARDeliveryPlanItemRemainedQty = item.ARDeliveryPlanItemRemainedQty * (item.ARDeliveryPlanItemProductQty / (itemQty == 0 ? 1 : itemQty));
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARDeliveryPlanItemsInfo item = (ARDeliveryPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        public void LoadGridViewByProductType(int iObjectID)
        {
            GridView gridView = (GridView)MainView;
            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            DeliveryPlanEntities entity = (DeliveryPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)entity.MainObject;

            if (iObjectID > 0)
                mainObject = (ARDeliveryPlansInfo)objDeliveryPlansController.GetObjectByID(iObjectID);
            string productType = mainObject.ARDeliveryPlanProductType;
            //foreach (GridColumn col in gridView.Columns)
            //{
            //    col.Visible = false;
            //}

            GridColumn column = gridView.Columns["ARDeliveryPlanItemProductNo"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = 1;
            }

            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = 2;
            }

            column = gridView.Columns["ARDeliveryPlanItemProductDesc"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = 3;
            }

            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = 15;
            }

            column = gridView.Columns["ARDeliveryPlanItemPONo"];
            if (column != null)
            {
                column.Visible = true;
                //column.VisibleIndex = 15;
            }

            if (productType == SaleOrderProductType.Roundwood.ToString() || productType == SaleOrderProductType.DryLumber.ToString()
                        || productType == SaleOrderProductType.FreshLumber.ToString() || productType == SaleOrderProductType.ArtificialBoard.ToString() || productType == SaleOrderProductType.Verneer.ToString())
            {
                column = gridView.Columns["FK_ICProductAttributeTTMTID"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 4;
                    column.OptionsColumn.AllowEdit = false;
                }
                column = gridView.Columns["FK_ICProductAttributeQualityID"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 5;
                    column.OptionsColumn.AllowEdit = true;
                }

                column = gridView.Columns["FK_ICStockID"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 6;
                }

                column = gridView.Columns["ARDeliveryPlanItemProductSerialNo"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 7;
                    column.OptionsColumn.AllowEdit = true;
                }

                column = gridView.Columns["ARDeliveryPlanItemProductQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 8;
                    column.Caption = "Khối lượng";
                }

                column = gridView.Columns["ARDeliveryPlanItemWoodQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 8;
                    column.Caption = CommonLocalizedResources.WoodQtyText;
                }

                column = gridView.Columns["ARDeliveryPlanItemShipmentQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 9;
                    column.Caption = "Khối lượng đã xuất";
                }

                column = gridView.Columns["ARDeliveryPlanItemRemainedQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 10;
                    column.Caption = "Khối lượng còn lại";
                }

                column = gridView.Columns["FK_ICMeasureUnitID"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 11;
                    column.OptionsColumn.AllowEdit = true;
                }

                column = gridView.Columns["ARDeliveryPlanItemProductTemplateType"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 12;
                    column.Caption = "Loại gỗ";
                    column.OptionsColumn.AllowEdit = true;
                }
                column = gridView.Columns["ARDeliveryPlanItemLotNo"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 13;
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                column = gridView.Columns["FK_ICMeasureUnitID"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 4;
                    column.OptionsColumn.AllowEdit = true;
                }

                column = gridView.Columns["ARDeliveryPlanItemProductQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 5;
                    column.Caption = "Số lượng";
                }
                column = gridView.Columns["ARDeliveryPlanItemWoodQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 5;
                    column.Caption = CommonLocalizedResources.WoodQtyText;
                }
                column = gridView.Columns["ARDeliveryPlanItemShipmentQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 6;
                    column.Caption = "Số lượng đã xuất";
                }

                column = gridView.Columns["ARDeliveryPlanItemRemainedQty"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 7;
                    column.Caption = "Số lượng còn lại";
                }

                column = gridView.Columns["FK_ICStockID"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 8;
                }

                column = gridView.Columns["ARDeliveryPlanItemProductSerialNo"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 9;
                    column.OptionsColumn.AllowEdit = true;
                }

                column = gridView.Columns["ARDeliveryPlanItemLotNo"];
                if (column != null)
                {
                    column.Visible = true;
                    //column.VisibleIndex = 10;
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            gridView.BestFitColumns();
        }
        private void RepoItemHyperLinkEdit_ButtonClick(object sender, System.EventArgs e)
        {
            ((DeliveryPlanModule)Screen.Module).ShowItemComponent();
        }
    }
}

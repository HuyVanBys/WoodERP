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
using BOSERP.MES.Modules.MM.ProductionNorm.Localization;
using BOSERP.MES.Modules.ProductionNorm.UI;
using System;

namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class ProductionNormItemEquipmentDetailsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMProductionNormItemEquipmentsInfo> dataSource)
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
                column.OptionsColumn.AllowEdit = false;

            column = gridView.Columns["FK_ICProductAlternativeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
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

            if (gridView.Columns["MMProductionNormItemEquipmentQty"] != null)
            {
                gridView.Columns["MMProductionNormItemEquipmentQty"].OptionsColumn.AllowEdit = true;
                InitColumnSummary("MMProductionNormItemEquipmentQty", DevExpress.Data.SummaryItemType.Sum);
            }
            if (gridView.Columns["MMProductionNormItemEquipmentDesc"] != null)
            {
                gridView.Columns["MMProductionNormItemEquipmentDesc"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductNo;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAlternativeID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductNo;
                    }
                }
            }
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemEquipmentsInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            MMProductionNormItemsInfo objProductionNormItemsInfo
                    = (MMProductionNormItemsInfo)entity.ProductionNormItemEquipmentList.CurrentObject;

            if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (objProductionNormItemsInfo != null)
                {
                    if (objProductionNormItemMeterialsInfo == null) objProductionNormItemMeterialsInfo = new MMProductionNormItemEquipmentsInfo();
                    objProductionNormItemMeterialsInfo.FK_ICProductID = objProductionNormItemsInfo.FK_ICProductID;
                    objProductionNormItemMeterialsInfo.MMProductionNormItemEquipmentProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                    objProductionNormItemMeterialsInfo.MMProductionNormItemEquipmentProductDesc = objProductionNormItemsInfo.MMProductionNormItemProductDesc;
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
            MMProductionNormItemEquipmentsInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            int ProductID = objProductionNormItemMeterialsInfo.FK_ICProductID;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(ProductID);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductsInfo> objProductsInfoList = objProductsController.GetProductByDepartmentNo(BOSCommon.Department.EquipmentNo);
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
                    MMProductionNormItemEquipmentsInfo objProductionNormItemEquipmentsInfo = (MMProductionNormItemEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objProductionNormItemEquipmentsInfo != null)
                    {
                        ((guiProductionNormItemEquipment)Screen).RemoveProductionNormItemEquipmentsInfo(objProductionNormItemEquipmentsInfo);
                        gridView.DeleteSelectedRows();
                    }
                }
                
            }
        }
    }
}

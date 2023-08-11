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
using BOSLib;

namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class ProductionNormItemPaintDetailsGridControl : BOSGridControl
    {
        private decimal TotalAcreage { get; set; }
        public void InvalidateDataSource(IBOSList<MMProductionNormItemPaintsInfo> dataSource, decimal totalAcreage)
        {
            this.TotalAcreage = totalAcreage;
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
            GridColumn column = gridView.Columns["FK_ICProductAttributeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemGridLookUpEdit rpProductAttributeColorID = new RepositoryItemGridLookUpEdit();
                rpProductAttributeColorID.DisplayMember = "ICProductAttributeValue";
                rpProductAttributeColorID.ValueMember = "ICProductAttributeID";
                rpProductAttributeColorID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rpProductAttributeColorID.PopupFilterMode = PopupFilterMode.Contains;
                rpProductAttributeColorID.NullText = string.Empty;
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                rpProductAttributeColorID.DataSource = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.COLOR.ToString());
                rpProductAttributeColorID.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpProductAttributeColor_QueryPopUp);
                column.ColumnEdit = rpProductAttributeColorID;
            }
            //column = gridView.Columns["MMProductionNormItemPaintQty"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    RepositoryItemTextEdit rpProductionNormItemPaintQty = new RepositoryItemTextEdit();
            //    rpProductionNormItemPaintQty.EditValueChanged += new EventHandler(rpProductionNormItemPaintQty_EditValueChanged);
            //    column.ColumnEdit = rpProductionNormItemPaintQty;
            //}
            if (gridView.Columns["MMProductionNormItemPaintQty"] != null)
            {
                gridView.Columns["MMProductionNormItemPaintQty"].OptionsColumn.AllowEdit = true;
                InitColumnSummary("MMProductionNormItemPaintQty", DevExpress.Data.SummaryItemType.Sum);
            }
            if (gridView.Columns["MMProductionNormItemPaintDesc"] != null)
            {
                gridView.Columns["MMProductionNormItemPaintDesc"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        private void rpProductionNormItemPaintQty_EditValueChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            TextEdit txtPaintQty = sender as TextEdit;
            decimal paintQty = 0;
            if (gridView.FocusedRowHandle < 0)
                return;
            MMProductionNormItemPaintsInfo objProductionNormItemPaintsInfo = (MMProductionNormItemPaintsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objProductionNormItemPaintsInfo == null)
                return;
            if (txtPaintQty.OldEditValue == txtPaintQty.EditValue)
                return;
            decimal.TryParse(txtPaintQty.OldEditValue.ToString(), out paintQty);
            objProductionNormItemPaintsInfo.MMProductionNormItemPaintOldQty = paintQty;
        }

        private void rpProductAttributeColor_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            GridLookUpEdit lookUpEdit = (GridLookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            lookUpEdit.Properties.DataSource = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.COLOR.ToString());
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeNo";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
            lookUpEdit.Properties.ImmediatePopup = true;
            lookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(100, 70);
            foreach (GridColumn column in lookUpEdit.Properties.View.Columns)
            {
                column.Visible = false;
                if (column.FieldName == "ICProductAttributeNo")
                {
                    column.Visible = true;
                    column.Caption = "Mã màu";
                    column.VisibleIndex = 0;
                    column.SortIndex = 1;
                    column.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
                }
                if (column.FieldName == "ICProductAttributeValue")
                {
                    column.Visible = true;
                    column.Caption = "Màu sơn";
                    column.VisibleIndex = 1;
                    column.SortIndex = 2;
                }
            }
            lookUpEdit.Properties.View.OptionsView.ShowIndicator = false;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeID")
            {
                if (e.Value != null)
                {
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductAttributesInfo != null)
                    {
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                    }
                }
            }
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemPaintsInfo objProductionNormItemPaintsInfo = (MMProductionNormItemPaintsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            MMProductionNormItemsInfo objProductionNormItemsInfo
                    = (MMProductionNormItemsInfo)entity.ProductionNormItemList.CurrentObject;
            int dataRowCount = gridView.DataRowCount;
            if (e.Column.FieldName == "FK_ICProductAttributeID")
            {
                if (objProductionNormItemsInfo != null)
                {
                    if (objProductionNormItemPaintsInfo == null) objProductionNormItemPaintsInfo = new MMProductionNormItemPaintsInfo();
                    objProductionNormItemPaintsInfo.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                    for (int i = 0; i < dataRowCount; i++)
                    {
                        if (i != e.RowHandle)
                        {
                            int cellValue = (int)gridView.GetRowCellValue(i, e.Column);
                            if (cellValue == objProductionNormItemPaintsInfo.FK_ICProductAttributeID)
                            {
                                MessageBox.Show(ProductionNormLocalizeResources.PaintColorExitsinListMessageError, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                                objProductionNormItemPaintsInfo.FK_ICProductAttributeID = 0;
                                return;
                            }
                        }
                    }
                    if (dataRowCount == 0)
                    {
                        objProductionNormItemPaintsInfo.MMProductionNormItemPaintQty = TotalAcreage;
                    }
                }
            }
            if (e.Column.FieldName == "MMProductionNormItemPaintQty")
            {
                decimal sumAmount = 0;
                for (int i = 1; i < dataRowCount; i++)
                {
                    decimal cellValue = (decimal)gridView.GetRowCellValue(i, e.Column);
                    sumAmount += cellValue;
                }
                MMProductionNormItemPaintsInfo objProductionNormItemPaintLastIndexInfo = new MMProductionNormItemPaintsInfo();
                objProductionNormItemPaintLastIndexInfo = (MMProductionNormItemPaintsInfo)gridView.GetRow(0);
                if (objProductionNormItemPaintLastIndexInfo == null)
                    return;
                decimal paintQty;
                if (e.RowHandle < 0)
                    paintQty = TotalAcreage - sumAmount - (decimal)e.Value;
                else
                    paintQty = TotalAcreage - sumAmount;
                if (paintQty < 0)
                {
                    MessageBox.Show(ProductionNormLocalizeResources.AreaHigherThanNormErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    objProductionNormItemPaintsInfo.MMProductionNormItemPaintQty = 0;
                    return;
                }
                objProductionNormItemPaintLastIndexInfo.MMProductionNormItemPaintQty = paintQty;
                RefreshDataSource();
            }
            gridView.FocusedRowHandle = -1;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    int dataRowCount = gridView.DataRowCount;
                    MMProductionNormItemPaintsInfo objProductionNormItemPaintsInfo = (MMProductionNormItemPaintsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objProductionNormItemPaintsInfo != null)
                    {
                        ((guiProductionNormItemPaint)Screen).RemoveProductionNormItemPaints(objProductionNormItemPaintsInfo);
                        gridView.DeleteSelectedRows();
                        if (dataRowCount == 2)
                        {
                            MMProductionNormItemPaintsInfo objProductionNormItemPaintLastIndexInfo = (MMProductionNormItemPaintsInfo)gridView.GetRow(0);
                            if (objProductionNormItemPaintLastIndexInfo != null)
                                objProductionNormItemPaintLastIndexInfo.MMProductionNormItemPaintQty = TotalAcreage;
                        }
                    }
                }
            }
        }
    }
}

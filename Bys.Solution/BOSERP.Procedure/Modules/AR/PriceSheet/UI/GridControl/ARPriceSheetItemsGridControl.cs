using BOSCommon;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using BOSLib;
using BOSCommon.Constants;
using System.Drawing;

namespace BOSERP.Modules.PriceSheet
{
    public class ARPriceSheetItemsGridControl : ItemGridControl
    {
        private List<ICProductAttributesInfo> ProductAttributesList { get; set; }
        public override void InitGridControlDataSource()
        {
            PriceSheetEntities entity = (PriceSheetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PriceSheetItemList;
            this.DataSource = bds;
            ProductAttributesList = new List<ICProductAttributesInfo>();
        }

        public enum PriceSheetItemsColumnName
        {
            ARPriceSheetItemProductNo,
            ARPriceSheetItemProductName,
            FK_ICMeasureUnitID,
            ARPriceSheetItemBasicPrice,
            ARPriceSheetItemPrice,
            ARPriceSheetItemNetPrice,
            ARPriceSheetItemCostingPrice,
            ARPriceSheetItemSOQ,
            ARPriceSheetItemDiscountPercent,
            ARPriceSheetItemDiscountAmount,
            ARPriceSheetItemCommand,
            ARPriceSheetItemQty
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ARPriceSheetItemSortOrder";
            column.Caption = "STT";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            STFieldFormatGroupsInfo formatsInfo = new STFieldFormatGroupsInfo();
            GridColumn column = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemDiscountAmount.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARPriceSheetItems", "ARPriceSheetItemDiscountAmount", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemPrice.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARPriceSheetItems", "ARPriceSheetItemPrice", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemQty.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARPriceSheetItems", "ARPriceSheetItemQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemBasicPrice.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARPriceSheetItems", "ARPriceSheetItemBasicPrice", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemNetPrice.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARPriceSheetItems", "ARPriceSheetItemNetPrice", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemCostingPrice.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARPriceSheetItems", "ARPriceSheetItemCostingPrice", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns[PriceSheetItemsColumnName.FK_ICMeasureUnitID.ToString()];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds1 = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds1.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);                
                column.ColumnEdit = rpMeasureUnit;
            }
            new PriceSheetItemsColumnName[]
            {
                PriceSheetItemsColumnName.ARPriceSheetItemCommand,
                PriceSheetItemsColumnName.ARPriceSheetItemDiscountPercent,
                PriceSheetItemsColumnName.ARPriceSheetItemPrice,
                PriceSheetItemsColumnName.ARPriceSheetItemCostingPrice,
                PriceSheetItemsColumnName.ARPriceSheetItemNetPrice,
                PriceSheetItemsColumnName.ARPriceSheetItemSOQ
            }
            .Select(o => gridView.Columns[o.ToString()])
            .Where(o => o != null)
            .ToList()
            .ForEach(o => o.OptionsColumn.AllowEdit = true);

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridview = (GridView)MainView;
            if (e.Column.FieldName == PriceSheetItemsColumnName.ARPriceSheetItemPrice.ToString()
                || e.Column.FieldName == PriceSheetItemsColumnName.ARPriceSheetItemDiscountPercent.ToString())
            {
                ARPriceSheetItemsInfo item = (ARPriceSheetItemsInfo)gridview.GetRow(gridview.FocusedRowHandle);
                ((PriceSheetModule)Screen.Module).UpdatePriceSheetItemPrice(item);
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            PriceSheetEntities entity = (PriceSheetEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.PriceSheetItemList.CurrentIndex > 0 && entity.PriceSheetItemList[entity.PriceSheetItemList.CurrentIndex] != null)
                ((PriceSheetModule)Screen.Module).InitProductPictureImage(entity.PriceSheetItemList[entity.PriceSheetItemList.CurrentIndex].FK_ICProductID);
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((PriceSheetModule)Screen.Module).DeleteItemFromPriceSheetItemList();
            }
        }

        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }

        private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (e.RowHandle >= 0)
            {
                ARPriceSheetItemsInfo item = (ARPriceSheetItemsInfo)gridview.GetRow(e.RowHandle);
                if (item != null)
                {
                    if (item.Selected)
                    {
                        e.Appearance.BackColor2 = Color.Yellow;
                        e.Appearance.BackColor = Color.Yellow;
                        e.HighPriority = true;
                    }
                    else
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARPriceSheetItemsInfo item = (ARPriceSheetItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
    }
}

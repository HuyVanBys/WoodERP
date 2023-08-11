using BOSCommon;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PriceSheet
{
    public class ARPriceSheetItemComponentsGridControl : BOSGridControl
    {
        private List<ICProductAttributesInfo> ProductAttributesList { get; set; }

        public void InvalidateDataSource(BOSList<ARPriceSheetItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        public enum PriceSheetItemsColumnName
        {
            ARPriceSheetItemQty,
            ARPriceSheetItemPrice,
            ARPriceSheetItemBasicPrice,
            ARPriceSheetItemProductLength,
            ARPriceSheetItemProductWidth,
            ARPriceSheetItemProductHeight,
            ARPriceSheetItemCommand
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ARPriceSheetItemProductArea";
            column.Caption = PriceSheetLocalizedResources.PriceSheetItemAreaCaption;
            column.OptionsColumn.AllowEdit = false;
            column.ColumnEdit = new RepositoryItemTextEdit();
            gridView.Columns.Add(column);
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ARPriceSheetItemsInfo objPriceSheetItemsInfo = (ARPriceSheetItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objPriceSheetItemsInfo != null)
                    {
                        ((guiAddProductComponent)Screen).RemovePriceSheetItemsInfo(objPriceSheetItemsInfo);
                        gridView.DeleteSelectedRows();
                    }
                }

            }
        }

        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            column.OptionsColumn.AllowEdit = true;
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
            column.OptionsColumn.AllowEdit = true;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);

            GridColumn column3 = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemQty.ToString()];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = true;
            }
            column3 = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemBasicPrice.ToString()];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = false;
            }
            column3 = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemPrice.ToString()];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = true;
            }
            column3 = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemProductHeight.ToString()];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = false;
            }
            column3 = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemProductLength.ToString()];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = false;
            }
            column3 = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemProductWidth.ToString()];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = false;
            }
            column3 = gridView.Columns[PriceSheetItemsColumnName.ARPriceSheetItemCommand.ToString()];
            if (column3 != null)
            {
                column3.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;

            if (gridView.FocusedRowHandle >= 0)
            {
                ARPriceSheetItemsInfo objPriceSheetItemsInfo = (ARPriceSheetItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == PriceSheetItemsColumnName.ARPriceSheetItemProductLength.ToString()
                    || e.Column.FieldName == PriceSheetItemsColumnName.ARPriceSheetItemProductWidth.ToString()
                    || e.Column.FieldName == PriceSheetItemsColumnName.ARPriceSheetItemProductHeight.ToString()
                    || e.Column.FieldName == PriceSheetItemsColumnName.ARPriceSheetItemQty.ToString()
                    || e.Column.FieldName == PriceSheetItemsColumnName.ARPriceSheetItemPrice.ToString())
                    ((guiAddProductComponent)Screen).UpdatePriceSheetItemComponentTotalAmount(objPriceSheetItemsInfo);
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
        }
    }
}

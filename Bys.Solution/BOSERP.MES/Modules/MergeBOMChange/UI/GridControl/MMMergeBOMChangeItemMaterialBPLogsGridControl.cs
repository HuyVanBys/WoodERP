using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MergeBOMChange
{
    public class MMMergeBOMChangeItemMaterialBPLogsGridControl : BOSGridControl
    {
        MergeBOMChangeEntities Entity;
        List<ICProductsInfo> objProductsInfoList;
        public override void InitGridControlDataSource()
        {
            Entity = (MergeBOMChangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = Entity.ItemMaterialBPLogList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
                if (col.FieldName == "FK_MMBatchProductID"
                    || col.FieldName == "FK_ICProductID")
                {
                    col.Group();
                }
            }

            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.Click += new EventHandler(gridView_Click);
            gridView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(gridView_FocusedColumnChanged);
            objProductsInfoList = ((MergeBOMChangeModule)Screen.Module).GetWoodIngredient();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.FieldName == "FK_ICProductMaterialID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == id);
                    if (iProduct != null)
                    {
                        e.DisplayText = iProduct.ICProductName;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
        }

        void gridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (Entity != null && Entity.ItemMaterialBOMLogList != null && Entity.ItemMaterialBOMLogList.GridControl != null && e.FocusedColumn != null)
            {
                GridView gridViewBOM = (GridView)Entity.ItemMaterialBOMLogList.GridControl.MainView;
                if (gridViewBOM != null)
                {
                    if (gridViewBOM.FocusedColumn != gridViewBOM.Columns[e.FocusedColumn.FieldName])
                    {
                        gridViewBOM.FocusedColumn = gridViewBOM.Columns[e.FocusedColumn.FieldName];
                    }
                }
            }
        }


        void gridView_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            GridView gridViewBP = (GridView)Entity.ItemMaterialBOMLogList.GridControl.MainView;
            MMMergeBOMChangeItemMaterialBPLogsInfo item = (MMMergeBOMChangeItemMaterialBPLogsInfo)gridView.GetFocusedRow();
            if (item != null)
            {

                for (int i = 0; i < gridViewBP.RowCount; i++)
                {
                    MMMergeBOMChangeItemMaterialBOMLogsInfo itemBP = (MMMergeBOMChangeItemMaterialBOMLogsInfo)gridViewBP.GetRow(i);
                    if (itemBP != null && itemBP.ICProductItemMaterialID == item.ICProductItemMaterialID && itemBP.FK_MMBatchProductID == item.FK_MMBatchProductID)
                    {
                        if (gridViewBP.FocusedRowHandle != i)
                        {
                            gridViewBP.FocusedRowHandle = i;
                        }

                        break;
                    }
                }
            }
            gridViewBP.RefreshRow(gridView.FocusedRowHandle);
            gridView.RefreshRow(gridView.FocusedRowHandle);
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;

            if (e.RowHandle == gridView.FocusedRowHandle)
            {
                bool isBold = true;
                MMMergeBOMChangeItemMaterialBPLogsInfo item = (MMMergeBOMChangeItemMaterialBPLogsInfo)gridView.GetFocusedRow();
                if (item != null)
                {
                    GridView gridViewBP = (GridView)Entity.ItemMaterialBOMLogList.GridControl.MainView;
                    MMMergeBOMChangeItemMaterialBOMLogsInfo itemBP = (MMMergeBOMChangeItemMaterialBOMLogsInfo)gridViewBP.GetFocusedRow();
                    if (itemBP.ICProductItemMaterialID != item.ICProductItemMaterialID
                        || itemBP.FK_MMBatchProductID != item.FK_MMBatchProductID)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
                        isBold = false;
                    }

                }
                if (isBold)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                    if (e.Column == gridView.FocusedColumn)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    }
                }
            }
            else
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
            }


        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);

            e.Appearance.BackColor = Color.White;
            e.Appearance.BackColor2 = Color.White;

            GridView gridView = (GridView)MainView;
            MMMergeBOMChangeItemMaterialBPLogsInfo item = (MMMergeBOMChangeItemMaterialBPLogsInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
            {
                if (item.MMMergeBOMChangeActionType == MergeBOMChangeActionType.Delete.ToString())
                {
                    e.Appearance.BackColor = Color.LightGray;
                    e.Appearance.BackColor2 = Color.LightGray;
                }
                else if (item.MMMergeBOMChangeActionType == MergeBOMChangeActionType.New.ToString())
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.LightGreen;
                }
                else if (item.MMMergeBOMChangeActionType == MergeBOMChangeActionType.Update.ToString())
                {
                    MMMergeBOMChangeItemMaterialBOMLogsInfo itemBOM = Entity.ItemMaterialBOMLogList.FirstOrDefault(t => t.ICProductItemMaterialID == item.ICProductItemMaterialID && item.FK_MMBatchProductID == t.FK_MMBatchProductID);
                    if (itemBOM != null)
                    {
                        if (!BOSApp.IsEqualObjects(item, itemBOM, e.Column.FieldName))
                        {
                            e.Appearance.BackColor = Color.LightYellow;
                            e.Appearance.BackColor2 = Color.LightYellow;
                        }
                    }

                }
            }
        }
    }
}

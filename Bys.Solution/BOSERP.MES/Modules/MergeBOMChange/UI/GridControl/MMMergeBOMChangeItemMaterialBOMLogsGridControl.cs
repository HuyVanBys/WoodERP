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
    public class MMMergeBOMChangeItemMaterialBOMLogsGridControl : BOSGridControl
    {
        MergeBOMChangeEntities Entity;
        List<ICProductsInfo> objProductsInfoList;
        public override void InitGridControlDataSource()
        {
            Entity = (MergeBOMChangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = Entity.ItemMaterialBOMLogList;
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

            objProductsInfoList = ((MergeBOMChangeModule)Screen.Module).GetWoodIngredient();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.Click += new EventHandler(gridView_Click);
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            gridView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(gridView_FocusedColumnChanged);

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

        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.Refresh();
        }

        void gridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (Entity != null && Entity.ItemMaterialBPLogList != null && Entity.ItemMaterialBPLogList.GridControl != null && e.FocusedColumn != null)
            {
                GridView gridViewBP = (GridView)Entity.ItemMaterialBPLogList.GridControl.MainView;
                if (gridViewBP != null)
                {
                    if (gridViewBP.FocusedColumn != gridViewBP.Columns[e.FocusedColumn.FieldName])
                    {
                        gridViewBP.FocusedColumn = gridViewBP.Columns[e.FocusedColumn.FieldName];
                    }
                }
            }
        }

        void gridView_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            GridView gridViewBP = (GridView)Entity.ItemMaterialBPLogList.GridControl.MainView;
            MMMergeBOMChangeItemMaterialBOMLogsInfo item = (MMMergeBOMChangeItemMaterialBOMLogsInfo)gridView.GetFocusedRow();
            if (item != null)
            {

                for (int i = 0; i < gridViewBP.RowCount; i++)
                {
                    MMMergeBOMChangeItemMaterialBPLogsInfo itemBP = (MMMergeBOMChangeItemMaterialBPLogsInfo)gridViewBP.GetRow(i);
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

            gridViewBP.RefreshRow(gridViewBP.FocusedRowHandle);
            Entity.ItemMaterialBPLogList.GridControl?.RefreshDataSource();
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;

            if (e.RowHandle == gridView.FocusedRowHandle)
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                if (e.Column == gridView.FocusedColumn)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
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

            GridView gridView = (GridView)MainView;

            e.Appearance.BackColor = Color.White;
            e.Appearance.BackColor2 = Color.White;


            MMMergeBOMChangeItemMaterialBOMLogsInfo item = (MMMergeBOMChangeItemMaterialBOMLogsInfo)gridView.GetRow(e.RowHandle);
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
                    MMMergeBOMChangeItemMaterialBPLogsInfo itemBP = Entity.ItemMaterialBPLogList.FirstOrDefault(t => t.ICProductItemMaterialID == item.ICProductItemMaterialID && t.FK_MMBatchProductID == item.FK_MMBatchProductID);
                    if (itemBP != null)
                    {
                        if (!BOSApp.IsEqualObjects(item, itemBP, e.Column.FieldName))
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

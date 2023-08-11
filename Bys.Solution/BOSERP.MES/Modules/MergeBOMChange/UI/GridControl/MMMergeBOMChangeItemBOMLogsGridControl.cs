using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MergeBOMChange
{
    public class MMMergeBOMChangeItemBOMLogsGridControl : BOSGridControl
    {
        MergeBOMChangeEntities Entity;
        public override void InitGridControlDataSource()
        {
            Entity = (MergeBOMChangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = Entity.ItemBOMLogList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.Click += new EventHandler(gridView_Click);
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            gridView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(gridView_FocusedColumnChanged);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                RepositoryItemBOSLookupEdit lke = (RepositoryItemBOSLookupEdit)e.Column.ColumnEdit;
                if (lke != null)
                {
                    List<BusinessObject> objList = (List<BusinessObject>)lke.DataSource;
                    object value = BOSApp.GetDisplayTextByValue(objList, lke.ValueMember, lke.DisplayMember, e.Value);
                    if (value != null)
                    {
                        e.DisplayText = value.ToString();
                    }
                }
            }
            catch { }
        }

        void gridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (Entity != null && Entity.ItemBPLogList != null && Entity.ItemBPLogList.GridControl != null && e.FocusedColumn != null)
            {
                GridView gridViewBP = (GridView)Entity.ItemBPLogList.GridControl.MainView;
                if (gridViewBP != null)
                {
                    if (gridViewBP.FocusedColumn != gridViewBP.Columns[e.FocusedColumn.FieldName])
                    {
                        gridViewBP.FocusedColumn = gridViewBP.Columns[e.FocusedColumn.FieldName];
                    }
                }
            }
        }
        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.Refresh();
        }

        void gridView_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            GridView gridViewBP = (GridView)Entity.ItemBPLogList.GridControl.MainView;
            MMMergeBOMChangeItemBOMLogsInfo item = (MMMergeBOMChangeItemBOMLogsInfo)gridView.GetFocusedRow();
            if (item != null)
            {

                for (int i = 0; i < gridViewBP.RowCount; i++)
                {
                    MMMergeBOMChangeItemBPLogsInfo itemBP = (MMMergeBOMChangeItemBPLogsInfo)gridViewBP.GetRow(i);
                    if (itemBP != null && itemBP.MMProductionNormItemID == item.MMProductionNormItemID && itemBP.FK_MMBatchProductID == item.FK_MMBatchProductID)
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
            Entity.ItemBPLogList.GridControl?.RefreshDataSource();
        }


        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            e.Appearance.BorderColor = Color.White;
            if (e.RowHandle == gridView.FocusedRowHandle)
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                if (e.Column == gridView.FocusedColumn)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    e.Appearance.BorderColor = Color.Black;
                }
            }
            else
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
            }
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);

            GridView gridView = (GridView)MainView;

            e.Appearance.BackColor = Color.White;
            e.Appearance.BackColor2 = Color.White;


            MMMergeBOMChangeItemBOMLogsInfo item = (MMMergeBOMChangeItemBOMLogsInfo)gridView.GetRow(e.RowHandle);
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
                    MMMergeBOMChangeItemBPLogsInfo itemBP = Entity.ItemBPLogList.FirstOrDefault(t => t.MMProductionNormItemID == item.MMProductionNormItemID && t.FK_MMBatchProductID == item.FK_MMBatchProductID);
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

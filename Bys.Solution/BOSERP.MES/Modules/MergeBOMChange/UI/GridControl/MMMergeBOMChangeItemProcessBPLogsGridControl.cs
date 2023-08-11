using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MergeBOMChange
{
    public class MMMergeBOMChangeItemProcessBPLogsGridControl : BOSGridControl
    {
        MergeBOMChangeEntities Entity;
        public override void InitGridControlDataSource()
        {
            Entity = (MergeBOMChangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = Entity.ItemProcessBPLogList;
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
            return gridView;
        }



        void gridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (Entity != null && Entity.ItemProcessBOMLogList != null && Entity.ItemProcessBOMLogList.GridControl != null && e.FocusedColumn != null)
            {
                GridView gridViewBOM = (GridView)Entity.ItemProcessBOMLogList.GridControl.MainView;
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
            GridView gridViewBP = (GridView)Entity.ItemProcessBOMLogList.GridControl.MainView;
            MMMergeBOMChangeItemProcessBPLogsInfo item = (MMMergeBOMChangeItemProcessBPLogsInfo)gridView.GetFocusedRow();
            if (item != null)
            {

                for (int i = 0; i < gridViewBP.RowCount; i++)
                {
                    MMMergeBOMChangeItemProcessBOMLogsInfo itemBP = (MMMergeBOMChangeItemProcessBOMLogsInfo)gridViewBP.GetRow(i);
                    if (itemBP != null && itemBP.ICProductItemProcessID == item.ICProductItemProcessID && itemBP.FK_MMBatchProductID == item.FK_MMBatchProductID)
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
                MMMergeBOMChangeItemProcessBPLogsInfo item = (MMMergeBOMChangeItemProcessBPLogsInfo)gridView.GetFocusedRow();
                if (item != null)
                {
                    GridView gridViewBP = (GridView)Entity.ItemProcessBOMLogList.GridControl.MainView;
                    MMMergeBOMChangeItemProcessBOMLogsInfo itemBP = (MMMergeBOMChangeItemProcessBOMLogsInfo)gridViewBP.GetFocusedRow();
                    if (itemBP.ICProductItemProcessID != item.ICProductItemProcessID
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
            MMMergeBOMChangeItemProcessBPLogsInfo item = (MMMergeBOMChangeItemProcessBPLogsInfo)gridView.GetRow(e.RowHandle);
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
                    MMMergeBOMChangeItemProcessBOMLogsInfo itemBOM = Entity.ItemProcessBOMLogList.FirstOrDefault(t => t.ICProductItemProcessID == item.ICProductItemProcessID && item.FK_MMBatchProductID == t.FK_MMBatchProductID);
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

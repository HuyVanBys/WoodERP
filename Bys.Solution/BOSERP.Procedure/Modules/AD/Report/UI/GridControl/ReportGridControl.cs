using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.Report
{
    public partial class ReportGridControl : BOSGridControl
    {
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GridView_CustomDrawCell(sender, e);

            if (e.CellValue != null)
            {
                if (e.CellValue is DateTime)
                {
                    if (Convert.ToDateTime(e.CellValue).Date == DateTime.MaxValue.Date)
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                else if (e.CellValue is int)
                {
                    if (Convert.ToInt32(e.CellValue) == 0)
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                else if (e.CellValue is double)
                {
                    if (Convert.ToDouble(e.CellValue) == 0)
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
        }
        protected override void OnDoubleClick(EventArgs ev)
        {
            base.OnDoubleClick(ev);
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item;
                string ColumnName = string.Empty;
                if (gridView.FocusedColumn != null)
                    ColumnName = gridView.FocusedColumn.FieldName;
                Type type = gridView.GetRow(gridView.FocusedRowHandle).GetType();

                if (type.Name == "DataRowView")
                {
                    System.Data.DataRowView row = (System.Data.DataRowView)gridView.GetRow(gridView.FocusedRowHandle);
                    XtraReportHelper.ShowRefByRow(new BOSList<ADTemplateParamsInfo>(), row, (System.Windows.Forms.Form.ControlCollection)this.Screen.Controls, this.Screen.Name, this.Screen.Module, ColumnName);
                }
                else
                {
                    item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        XtraReportHelper.ShowRef(new BOSList<ADTemplateParamsInfo>(), item, (System.Windows.Forms.Form.ControlCollection)this.Screen.Controls, this.Screen.Name, this.Screen.Module, ColumnName);
                    }
                }

            }
        }
    }
}

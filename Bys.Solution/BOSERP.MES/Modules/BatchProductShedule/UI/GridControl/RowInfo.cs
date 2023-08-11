using BOSCommon.Enums;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.BatchProductShedule
{
    public class RowInfo
    {
        public GridView View { get; private set; }

        public int RowHandle { get; private set; }

        public ScheduleMenuTag TagName { get; private set; }

        public RowInfo(GridView view, int rowHandle)
        {
            this.RowHandle = rowHandle;
            this.View = view;
        }

        public RowInfo(GridView view, ScheduleMenuTag tagName, int rowHandle)
        {
            this.RowHandle = rowHandle;
            this.View = view;
            this.TagName = tagName;
        }
    }
}

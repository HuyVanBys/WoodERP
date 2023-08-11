using BOSComponent;
using DevExpress.XtraTreeList.Columns;
using Localization;

namespace BOSERP
{
    public partial class GELocationsTreeListControl : BOSTreeListControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            TreeListColumn column = Columns["GELocationName"];
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["Selected"];
            column.Caption = CommonLocalizedResources.Selected;
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = true;
        }
    }
}

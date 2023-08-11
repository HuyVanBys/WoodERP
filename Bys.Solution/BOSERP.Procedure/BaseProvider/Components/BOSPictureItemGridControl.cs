using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using BOSLib;

namespace BOSERP
{
    public partial class BOSPictureItemGridControl : ItemGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            return gridView;
        }

        protected virtual void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.FocusedRowHandle < 0)
                return;
            BusinessObject item = (BusinessObject)gridView.GetRow(e.FocusedRowHandle);
            ((BaseTransactionModule)Screen.Module).InvalidateItemProductPicture(item);
        }
    }
}

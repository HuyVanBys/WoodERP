using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.ProductConversion
{
    public partial class guiShowSimilarSerialNo : BOSERPScreen
    {
        #region Variables
        public ICProductSerialGridControl SimilarSerialNoGridControl
        {
            get { return fld_dgcShowAllSimilarSerialNo; }
        }
        #endregion

        public guiShowSimilarSerialNo()
        {
            InitializeComponent();
        }

        private void guiShowAll_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            GridView gridView = (GridView)fld_dgcShowAllSimilarSerialNo.MainView;
            gridView.BestFitColumns();
            gridView.ExpandAllGroups();
        }
    }
}
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.SaleOrder
{
    public partial class guiShowCollectionComponent<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<ICCollectionItemsInfo> CollectionItemList { get; set; }

        #endregion
        public guiShowCollectionComponent(List<ICCollectionItemsInfo> collectionItem)
        {
            InitializeComponent();
            CollectionItemList = new BOSList<ICCollectionItemsInfo>(TableName.ICCollectionItemsTableName);
            CollectionItemList.Invalidate(collectionItem);
        }

        private void guiShowCollectionComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcICColectionItemGridControl.InvalidateDataSource(CollectionItemList);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
    }
}
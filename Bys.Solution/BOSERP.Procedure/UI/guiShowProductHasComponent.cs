using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP
{
    public partial class guiShowProductHasComponent<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<ICProductsForViewInfo> CollectionItemList { get; set; }

        #endregion
        public guiShowProductHasComponent(List<ICProductsForViewInfo> collectionItem)
        {
            InitializeComponent();
            CollectionItemList = new BOSList<ICProductsForViewInfo>(TableName.ICProductsTableName);
            CollectionItemList.Invalidate(collectionItem);
        }

        private void guiShowProductHasComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcICProductsGridControl.DataSource = CollectionItemList;
            fld_dgcICProductsGridControl.RefreshDataSource();
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
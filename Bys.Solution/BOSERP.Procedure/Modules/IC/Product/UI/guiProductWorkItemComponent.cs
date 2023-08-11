using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class guiProductWorkItemComponent : BOSERPScreen
    {
        #region Variables

        public BOSList<ICProductTasksInfo> ProductWorkItemTaskList { get; set; }

        public BOSList<ICProductWorkItemsInfo> ProductWorkItemComponentsList { get; set; }

        public ICProductsInfo ProductsInfo { get; set; }
        #endregion

        public guiProductWorkItemComponent(ICProductsInfo productsInfo, List<ICProductWorkItemsInfo> productWorkItemComponents, List<ICProductTasksInfo> productWorkTasks)
        {
            InitializeComponent();
            ProductsInfo = productsInfo;
            ProductWorkItemComponentsList = new BOSList<ICProductWorkItemsInfo>(TableName.ICProductWorkItemsTableName);
            productWorkItemComponents.ForEach(o => ProductWorkItemComponentsList.Add(o));

            ProductWorkItemTaskList = new BOSList<ICProductTasksInfo>(TableName.ICProductTasksTableName);
            productWorkTasks.ForEach(o => ProductWorkItemTaskList.Add(o));
        }

        private void guiProductWorkItemComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcProductWorkItemComponentsGridControl.InvalidateDataSource(ProductWorkItemComponentsList);
            fld_dgcProductWorkItemTasksGridControl.InvalidateDataSource(ProductWorkItemTaskList);
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu chưa được cập nhật. Bạn chắn chắn muốn thoát.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            return;
        }
    }
}
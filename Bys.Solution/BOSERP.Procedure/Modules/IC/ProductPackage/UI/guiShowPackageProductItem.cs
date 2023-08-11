using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductPackage
{
    public partial class guiShowPackageProductItem : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets product branch price grid control 
        /// </summary>
        public List<ICProductPackageItemsInfo> ProductPackageItemsList { get; set; }
        public guiShowPackageProductItem()
        {
            InitializeComponent();

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
            if (ProductPackageItemsList == null) ProductPackageItemsList = new List<ICProductPackageItemsInfo>();
        }

        private void guiShowPackageProductItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcICProductPackageItems.InvalidateDataSource(ProductPackageItemsList);
            fld_dgcICProductPackageItems.RefreshDataSource();

        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

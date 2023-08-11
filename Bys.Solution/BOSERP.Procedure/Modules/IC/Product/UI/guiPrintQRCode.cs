using BOSComponent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class guiPrintQRCode : BOSERPScreen
    {
        public string PrintQCodeType { get; set; }

        public List<ICProductsInfo> SelectedObjects { get; set; }

        public guiPrintQRCode()
        {
            InitializeComponent();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.PrintQCodeItemsList.ForEach(o =>
            {
                List<ICProductsInfo> list = SelectedObjects.Where(s => s.Selected).Select(s => (ICProductsInfo)s.Clone()).ToList();
                ICProductsInfo product = list.Where(s => s.ICProductID == o.ICProductID).FirstOrDefault();
                if (product != null)
                {
                    o.ICProductPrintQty = product.ICProductPrintQty;
                    o.Selected = product.Selected;
                }
                else
                {
                    o.ICProductPrintQty = 1;
                    o.Selected = false;
                }
            });
            ((ProductModule)Module).PrintQRcode(PrintQCodeType);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guiPrintInventoryPackageBarcode_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            SelectedObjects = entity.PrintQCodeItemsList.Select(s => (ICProductsInfo)s.Clone()).ToList();
            fld_dgcPrintQRCodeGridControl.DataSource = SelectedObjects;
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

        private void fld_chkSellectAll_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            SelectedObjects.ForEach(o => o.Selected = selectAllCheckEdit.Checked);
            fld_dgcPrintQRCodeGridControl.DataSource = SelectedObjects;
            fld_dgcPrintQRCodeGridControl.RefreshDataSource();
        }

        private void fld_btnSearchProducts_Click(object sender, EventArgs e)
        {
            int deparmentID = fld_lkeICDepartmentID.EditValue != null ? Convert.ToInt32(fld_lkeICDepartmentID.EditValue) : 0;
            int productGroupID = fld_lkeICProductGroupID.EditValue != null ? Convert.ToInt32(fld_lkeICProductGroupID.EditValue) : 0;
            int productID = fld_lkeICProductID.EditValue != null ? Convert.ToInt32(fld_lkeICProductID.EditValue) : 0;
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            SelectedObjects = entity.PrintQCodeItemsList.Select(s =>
            {
                s.Selected = false;
                s.ICProductPrintQty = 1;
                return (ICProductsInfo)s.Clone();
            }).ToList();
            if (deparmentID > 0)
                SelectedObjects = SelectedObjects.Where(o => o.FK_ICDepartmentID == deparmentID).ToList();
            if (productGroupID > 0)
                SelectedObjects = SelectedObjects.Where(o => o.FK_ICProductGroupID == productGroupID).ToList();
            if (productID > 0)
                SelectedObjects = SelectedObjects.Where(o => o.ICProductID == productID).ToList();

            fld_dgcPrintQRCodeGridControl.DataSource = SelectedObjects;
            fld_dgcPrintQRCodeGridControl.RefreshDataSource();
        }
    }
}

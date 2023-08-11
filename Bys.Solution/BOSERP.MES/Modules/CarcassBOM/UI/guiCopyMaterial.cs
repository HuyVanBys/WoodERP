using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiCopyMaterial : BOSERPScreen
    {
        private GridControlHelper GridControlHelper;
        public List<ICProductItemMaterialsInfo> SelectedObjects { get; set; }
        public int ProductID = 0;
        public int BomID = 0;
        public List<ICProductItemMaterialsInfo> MaterialProduct { get; set; }
        public guiCopyMaterial(int productID, int bomID, List<ICProductItemMaterialsInfo> materialProduct)
        {
            InitializeComponent();
            ProductID = productID;
            BomID = bomID;
            MaterialProduct = new List<ICProductItemMaterialsInfo>();
            MaterialProduct = materialProduct;
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

        private void guiCopyMaterial_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_lkeICProductID1.EditValue = ProductID;
            if (ProductID > 0)
            {
                MaterialProduct = GetMaterialData(ProductID);
            }
            fld_dgcMaterialProduct.DataSource = MaterialProduct;
            fld_dgcMaterialProduct.RefreshDataSource();
            GridView gridView = (GridView)fld_dgcMaterialProduct.MainView;
            GridControlHelper = new GridControlHelper(gridView);
            gridView.ExpandAllGroups();
        }
        public List<ICProductItemMaterialsInfo> GetMaterialData(int productID)
        {
            List<ICProductItemMaterialsInfo> result = new List<ICProductItemMaterialsInfo>();
            result = (new ICProductItemMaterialsController()).GetByCarcassAndProductID(null, productID);
            return result;
        }
        private void fld_lkeICProductID1_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeICProductID1.EditValue != null)
            {
                MaterialProduct = GetMaterialData(int.Parse(fld_lkeICProductID1.EditValue.ToString()));
                fld_dgcMaterialProduct.DataSource = MaterialProduct;
                fld_dgcMaterialProduct.RefreshDataSource();
                GridView gridView = (GridView)fld_dgcMaterialProduct.MainView;
                gridView.ExpandAllGroups();
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<ICProductItemMaterialsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int count = SelectedObjects.Select(o => o.FK_MMProductionNormID).Distinct().Count();
            if (count > 1)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chọn nhiều nguyên liệu thuộc nhiều Bảng định mức của chi tiết BTP, bạn chắc chắn không?") == DialogResult.No)
                    return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PriceSheet
{
    public partial class guiAddProductComponent : BOSERPScreen
    {
        #region Variables
        private BOSList<ARPriceSheetItemsInfo> PriceSheetItemList { get; set; }

        public IList<ARPriceSheetItemsInfo> SelectedObjects { get; set; }

        public IList<ARPriceSheetItemsInfo> RemoveObjects { get; set; }
        #endregion

        public guiAddProductComponent(IBOSList<ARPriceSheetItemsInfo> priceSheetItemList)
        {
            InitializeComponent();
            PriceSheetItemList = (BOSList<ARPriceSheetItemsInfo>)priceSheetItemList.Clone();
        }

        private void guiAddProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            PriceSheetEntities entity = (PriceSheetEntities)((PriceSheetModule)Module).CurrentModuleEntity;
            fld_dgcARPriceSheetItemComponentsGridControl.InvalidateDataSource(PriceSheetItemList);
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

        public void RemovePriceSheetItemsInfo(ARPriceSheetItemsInfo objPriceSheetItemsInfo)
        {
            if (RemoveObjects == null)
                RemoveObjects = new List<ARPriceSheetItemsInfo>();
            RemoveObjects.Add(objPriceSheetItemsInfo);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                Int32.TryParse(fld_lkeFK_ICProductAttributeID.EditValue.ToString(), out productID);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo.ICProductLockedPurchaseOrder)
                {
                    MessageBox.Show(SaleOrderLocalizedResources.ProductLockedErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (objProductsInfo.ICProductNonRetail)
                {
                    MessageBox.Show(SaleOrderLocalizedResources.ProductNonRetailMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!objProductsInfo.ICProductActiveCheck)
                {
                    MessageBox.Show(SaleOrderLocalizedResources.ProductNonActiveCheck, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            SelectedObjects = PriceSheetItemList.ToList();
            if (SelectedObjects == null)
                SelectedObjects = new List<ARPriceSheetItemsInfo>();
            if (RemoveObjects == null)
                RemoveObjects = new List<ARPriceSheetItemsInfo>();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void UpdatePriceSheetItemComponentTotalAmount(ARPriceSheetItemsInfo objPriceSheetItemsInfo)
        {

            if (objPriceSheetItemsInfo == null)
                return;
            //decimal priceSheetItemFormulaPriceConfigQty = ((PriceSheetModule)Module).CalculatorProposalItemFormulaPriceConfigQty(objPriceSheetItemsInfo);
            //objPriceSheetItemsInfo.ARPriceSheetItemTotalAmount = priceSheetItemFormulaPriceConfigQty * objPriceSheetItemsInfo.ARPriceSheetItemPrice;

        }
    }
}
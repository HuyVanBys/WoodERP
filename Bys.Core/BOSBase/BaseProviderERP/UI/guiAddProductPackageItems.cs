using BOSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP
{
    public partial class guiAddProductPackageItems : BOSERPScreen
    {
        #region Variables
        //private GridControlHelper GridControlHelper;
        public List<ICProductPackageItemsInfo> ReceiptPackageItemsList { get; set; }
        public List<MMBatchProductProductionNormItemsInfo> pnList { get; set; }
        public List<MMBatchProductProductionNormItemsInfo> Result { get; set; }
        public List<ICProductPackageItemsInfo> SelectedObjects { get; set; }
        public int FK_MMBatchProductID { get; set; }
        public int FK_MMBatchProductItemID { get; set; }
        public int FK_MMOperationID { get; set; }
        public int FK_ICProductID { get; set; }
        public List<PackInfo> PackNoList { get; set; }
        public bool IsView { get; set; }
        public decimal PacQty { get; set; }
        public string PackNo { get; set; }
        public bool IsReceipt { get; set; }
        public List<ICShipmentItemsInfo> ShipmentItemList { get; set; }
        #endregion
        public guiAddProductPackageItems()
        {
            InitializeComponent();
            if (ReceiptPackageItemsList == null) ReceiptPackageItemsList = new List<ICProductPackageItemsInfo>();
            if (PackNoList != null) PackNoList = new List<PackInfo>();
        }

        private void guiAddProductPackageItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            MMBatchProductProductionNormItemsController objBPPNsController = new MMBatchProductProductionNormItemsController();
            pnList = new List<MMBatchProductProductionNormItemsInfo>();
            Result = new List<MMBatchProductProductionNormItemsInfo>();
            SelectedObjects = new List<ICProductPackageItemsInfo>();
            fld_txtPackQty.Text = 1.ToString();
            if (PacQty > 0) fld_txtPackQty.Text = (Convert.ToInt32(PacQty)).ToString();
            // GridView gridView = (GridView)fld_dgcICProductPackageItems.MainView;
            fld_dgcICProductPackageItems.InvalidateDataSource(ReceiptPackageItemsList);
            // GridControlHelper = new GridControlHelper(gridView);
            if (FK_MMBatchProductID > 0)
                pnList = objBPPNsController.GetAllItemByProductTypeAndBatchProductID(ProductType.SemiProduct.ToString(), FK_MMBatchProductID, FK_MMOperationID);
            if (FK_ICProductID > 0)
            {
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(FK_ICProductID);
                if (objProductsInfo != null)
                    fld_txtLotNo.Text = objProductsInfo.ICProductNo;

            }
            if (IsView)
            {
                fld_btnApply.Visible = false;
                fld_txtLotNo.Text = PackNo;
                FindPackage();
            }
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
            if (ReceiptPackageItemsList == null) ReceiptPackageItemsList = new List<ICProductPackageItemsInfo>();
        }

        private void fld_btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnFindPack_Click(object sender, EventArgs e)
        {
            FindPackage();
        }
        public void FindPackage()
        {
            if (fld_txtLotNo.Text != null && !string.IsNullOrEmpty(fld_txtLotNo.Text.Trim()))
            {
                string PackNo = fld_txtLotNo.Text.Trim();
                ICProductPackageItemsController objController = new ICProductPackageItemsController();
                ReceiptPackageItemsList = objController.GetPackageItemsListByPackageNoAndSomeCriteria(PackNo
                    , FK_MMBatchProductID
                    , FK_MMBatchProductItemID
                    , FK_ICProductID
                    , FK_MMOperationID);
                if (ReceiptPackageItemsList == null || ReceiptPackageItemsList.Count == 0)
                {
                    BOSApp.ShowMessage("Không tìm thấy kiện tương ứng!");
                    return;
                }
                foreach (ICProductPackageItemsInfo item in ReceiptPackageItemsList)
                {
                    item.ICProductPackageItemSerialNo = item.MMBatchProductItemProductSerial;
                    item.ICProductPackageQty = PacQty > 0 ? PacQty : 1;
                }
                fld_dgcICProductPackageItems.InvalidateDataSource(ReceiptPackageItemsList);
                fld_dgcICProductPackageItems.RefreshDataSource();
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng nhập mã kiện");
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = ReceiptPackageItemsList.Where(o => o.Selected).ToList();
            Result = new List<MMBatchProductProductionNormItemsInfo>();

            if (SelectedObjects == null || SelectedObjects.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn kiện!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ShipmentItemList != null && ShipmentItemList.Count > 0)
            {
                bool isConfligShipment = false;

                foreach (ICProductPackageItemsInfo item in SelectedObjects)
                {
                    ICShipmentItemsInfo shipmentProduct = ShipmentItemList.Where(o => o.FK_ICProductID == item.FK_ICProductParentID).FirstOrDefault();
                    if (shipmentProduct == null || shipmentProduct.FK_ICProductID == 0)
                    {
                        item.IsError = true;
                        isConfligShipment = true;

                    }
                }
                if (isConfligShipment)
                {
                    string messProduct = string.Empty;
                    ShipmentItemList.ForEach(o =>
                    {
                        messProduct += Environment.NewLine + o.ICShipmentItemProductName;
                    });
                    if (BOSApp.ShowMessageYesNo("Kiện bạn chọn không tương ứng chi tiết của chứng từ xuất! Bạn có muốn tiếp tục không?"
                        + Environment.NewLine + messProduct) == DialogResult.No)
                        return;
                }
            }
            if (SelectedObjects != null)
            {
                if (PackNoList != null)
                {
                    List<string> selectPackNoList = SelectedObjects.Select(o => o.ICProductPackageNo).Distinct().ToList();
                    if (selectPackNoList != null)
                    {
                        bool isError = false;
                        string mess = string.Empty;
                        selectPackNoList.ForEach(o =>
                        {
                            if (PackNoList.Exists(p => p.PackNo == o && p.BatchItemID == FK_MMBatchProductItemID))
                            {
                                isError = true;
                                ReceiptPackageItemsList.ForEach(r =>
                                {
                                    if (r.ICProductPackageNo == o)
                                    {
                                        r.IsError = true;
                                    }
                                });
                                mess += Environment.NewLine + o;
                            }
                        });
                        if (isError)
                        {
                            BOSApp.ShowMessage("Chứng đã tồn tại kiện này:" + Environment.NewLine + mess);
                            return;
                        }

                    }
                }
                if (pnList != null && pnList.Count > 0)
                {
                    foreach (ICProductPackageItemsInfo item in SelectedObjects)
                    {
                        MMBatchProductProductionNormItemsInfo findObj = pnList.Where(o => o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID).FirstOrDefault();
                        if (findObj != null)
                        {
                            MMBatchProductProductionNormItemsInfo resultItem = new MMBatchProductProductionNormItemsInfo();
                            resultItem = (MMBatchProductProductionNormItemsInfo)findObj.Clone();
                            resultItem.ICProductPackageNo = item.ICProductPackageNo;
                            resultItem.ICReceiptItemProductQty = item.ICProductPackageItemQty * item.ICProductPackageQty;
                            Result.Add(resultItem);
                        }
                    }
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnUpdatePlanDate_Click(object sender, EventArgs e)
        {
            if (fld_txtLotNo.Text != null && !string.IsNullOrEmpty(fld_txtLotNo.Text.Trim()))
            {
                int packQty = 0;
                if (fld_txtPackQty.Text != null && !string.IsNullOrEmpty(fld_txtPackQty.Text.Trim()))
                    int.TryParse(fld_txtPackQty.Text.Trim().ToString(), out packQty);
                if (packQty <= 0)
                {
                    BOSApp.ShowMessage("Vui lòng nhập số lượng kiện");
                    return;
                }
                else
                {

                    List<ICProductPackageItemsInfo> selectPack = ReceiptPackageItemsList.Where(o => o.Selected).ToList();
                    if (selectPack == null || selectPack.Count == 0)
                    {
                        BOSApp.ShowMessage("Vui lòng chọn kiện!");
                        return;
                    }
                    bool error = false;
                    ReceiptPackageItemsList.ForEach(o =>
                    {
                        //if (selectPack.Exists( ex => ex.FK_ICProductPackageID == o.FK_ICProductPackageID && ex.FK_ICProductID == o.FK_ICProductID))
                        if (o.Selected && IsReceipt)
                        {
                            if (o.ICProductPackageItemQty * packQty > o.MMBatchProductProductionNormItemQuantity)
                            {
                                o.IsError = true;
                                error = true;
                            }
                        }
                    });
                    fld_dgcICProductPackageItems.RefreshDataSource();
                    if (error)
                    {
                        BOSApp.ShowMessage("Số lượng kiện vượt định mức có thể nhập!");
                    }
                    else
                    {
                        ReceiptPackageItemsList.ForEach(o =>
                        {
                            //if (selectPack.Exists( ex => ex.FK_ICProductPackageID == o.FK_ICProductPackageID && ex.FK_ICProductID == o.FK_ICProductID))
                            if (o.Selected)
                            {
                                o.IsError = false;
                                o.ICProductPackageQty = packQty;
                            }
                        });
                    }
                }
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng nhập mã kiện");
            }

        }

        private void fld_txtLotNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindPackage();
        }

        private void fld_chkSelectAllPlan_CheckedChanged(object sender, EventArgs e)
        {
            ReceiptPackageItemsList.ForEach(o => o.Selected = fld_chkSelectAllPlan.Checked);
            fld_dgcICProductPackageItems.RefreshDataSource();
        }
    }
    public class PackInfo
    {
        public string PackNo { get; set; }
        public int BatchItemID { get; set; }
        public int PackID { get; set; }
        public decimal PackQty { get; set; }
    }
}
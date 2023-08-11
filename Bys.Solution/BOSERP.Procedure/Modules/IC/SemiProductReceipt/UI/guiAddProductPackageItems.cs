using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;

namespace BOSERP.Modules.SemiProductReceipt
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
        public List<string> PackNoList { get; set; }
        #endregion
        public guiAddProductPackageItems()
        {
            InitializeComponent();
            if (ReceiptPackageItemsList == null) ReceiptPackageItemsList = new List<ICProductPackageItemsInfo>();
            if (PackNoList != null) PackNoList = new List<string>();
        }

        private void guiAddProductPackageItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            MMBatchProductProductionNormItemsController objBPPNsController = new MMBatchProductProductionNormItemsController();
            pnList = new List<MMBatchProductProductionNormItemsInfo>();
            Result = new List<MMBatchProductProductionNormItemsInfo>();
            SelectedObjects = new List<ICProductPackageItemsInfo>();
            fld_txtPackQty.Text = 1.ToString();
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
            if(ReceiptPackageItemsList == null) ReceiptPackageItemsList = new List<ICProductPackageItemsInfo>();
        }

        private void fld_btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fld_btnFindPack_Click(object sender, EventArgs e)
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

                MMOperationsController objOperationsController = new MMOperationsController();
                MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                DataRow row = BOSApp.GetObjectFromCatche("MMOperations", "MMOperationID", FK_MMOperationID);
                if (row != null)
                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectFromDataRow(row);
                else
                    objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(FK_MMOperationID);

                foreach (ICProductPackageItemsInfo item in ReceiptPackageItemsList)
                {
                    if (objOperationsInfo != null && string.IsNullOrEmpty (item.MMBatchProductItemProductSerial))
                        item.ICProductPackageItemSerialNo = ((SemiProductReceiptModule)Module).GetSerialNo(item.MMBatchProductItemProductSerial, objOperationsInfo.MMOperationAcronym);
                    item.ICProductPackageQty = 1;
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
                MessageBox.Show("Vui lòng chọn kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                        selectPackNoList.ForEach(o => {
                            if (PackNoList.Exists(p => p == o))
                            {
                                isError = true;
                                ReceiptPackageItemsList.ForEach(r => {
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
                foreach (ICProductPackageItemsInfo item in SelectedObjects)
                {
                    MMBatchProductProductionNormItemsInfo resultItem = pnList.Where(o => o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID).FirstOrDefault();
                    if (resultItem != null)
                    {
                        resultItem.ICProductPackageNo = item.ICProductPackageNo;
                        resultItem.ICReceiptItemProductQty = item.ICProductPackageItemQty * item.ICProductPackageQty;
                        Result.Add(resultItem);
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
                        if (o.Selected)
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
    }
}
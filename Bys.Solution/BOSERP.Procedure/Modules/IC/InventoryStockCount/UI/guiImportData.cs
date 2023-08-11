using BOSCommon;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryStockCount.UI
{
    public partial class guiImportData : BOSERPScreen
    {
        public List<IPInventoryStockCountsInfo> DataSource { get; set; }
        public List<ICInventoryStockCountItemsInfo> inventoryStockCountItemList { get; set; } 

        private List<ICStocksInfo> StockList { get; set; }

        public guiImportData(List<IPInventoryStockCountsInfo> importData)
        {
            InitializeComponent();
            DataSource = importData;
            inventoryStockCountItemList = new List<ICInventoryStockCountItemsInfo>();
            StockList = (new ICStocksController()).GetAllStocks();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (InValidData())
            {
                MessageBox.Show("Dữ liệu Import không đúng. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool InValidData()
        {
            string messageError = string.Empty;
            string messSerialNoError = string.Empty;
            ICProductsForViewInfo objProductsInfo = new ICProductsForViewInfo();
            BRBranchsInfo branchsInfo = new BRBranchsInfo();
            ICStocksInfo stocksInfo = new ICStocksInfo();
            ICInventoryStockCountItemsInfo itemImport = new ICInventoryStockCountItemsInfo();
            DataSource.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.ProductNo))
                    return;

                objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo == o.ProductNo).FirstOrDefault();
                if (objProductsInfo == null)
                {
                    messageError += string.Format("Sản phẩm [{0}] không tồn tại trong hệ thống.", o.ProductNo);
                    messageError += Environment.NewLine;
                }
                else if (objProductsInfo.ICProductName.Trim() != o.ProductName)
                {
                    messageError += string.Format("Sản phẩm [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.ProductNo);
                    messageError += Environment.NewLine;
                }
                o.ProductID = objProductsInfo?.ICProductID ?? 0;
                stocksInfo = StockList.Where(s => s.ICStockNo == o.StockNo).FirstOrDefault();
                if (stocksInfo == null)
                {
                    messageError += string.Format("Kho [{0}] của sản phẩm [{1}] không tồn tại trong hệ thống.", o.StockNo, o.ProductNo);
                    messageError += Environment.NewLine;
                }
                else if (stocksInfo.ICStockName != o.StockName)
                {
                    messageError += string.Format("Kho [{0}] của sản phẩm [{1}] có tên khác với tên đã tồn tại trong hệ thống.", o.StockNo, o.ProductNo);
                    messageError += Environment.NewLine;
                }
                o.StockID = stocksInfo?.ICStockID ?? 0;

                itemImport = inventoryStockCountItemList.Where(im => im.FK_ICProductID  == o.ProductID
                                                && im.FK_ICStockID == o.StockID
                                                && im.ICInventoryStockCountItemProductSerialNo == o.ProductSerieNo).FirstOrDefault();
                if (itemImport == null)
                {
                    messSerialNoError += Environment.NewLine + o.ProductSerieNo;
                }
            });

            if (!string.IsNullOrWhiteSpace(messSerialNoError))
            {
                messSerialNoError += " Vui lòng kiểm tra lại!";
                MessageBox.Show( "Mã lô sau không thể tìm thấy trong danh sách kiểm kho: "+ Environment.NewLine + messSerialNoError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (string.IsNullOrWhiteSpace(messageError))
                return false;

            messageError += "Vui lòng kiểm tra lại!";
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        private void guiImportData_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcIPInvBalances.InvalidateDataSource(DataSource, StockList);
            BOSProgressBar.Close();
        }

        private void fld_btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

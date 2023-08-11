using BOSCommon;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiImportProductItems : BOSERPScreen
    {
        public List<IPProductsInfo> ProductsList { get; set; }

        private List<ICMeasureUnitsInfo> ListMeasureUnitsInfo { get; set; }

        private List<ICStocksInfo> ListStocksInfo { get; set; }

        private List<ICProductSeriesInfo> ListProductSeriesInfo { get; set; }

        private bool IsShipment { get; set; }

        public guiImportProductItems(List<IPProductsInfo> productionItemsList, bool isShipment)
        {
            InitializeComponent();
            ProductsList = productionItemsList;
            IsShipment = isShipment;

            ListMeasureUnitsInfo = new List<ICMeasureUnitsInfo>();
            if (BOSApp.LookupTables.Contains("ICMeasureUnits"))
            {
                ListMeasureUnitsInfo = (List<ICMeasureUnitsInfo>)(new ICMeasureUnitsController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICMeasureUnits"]);
            }    
            else
            {
                ListMeasureUnitsInfo = (new ICMeasureUnitsController()).GetAllAliveMeasureUnit();
            }

            ListStocksInfo = new List<ICStocksInfo>();
            if (BOSApp.LookupTables.Contains("ICStocks"))
            {
                ListStocksInfo = (List<ICStocksInfo>)(new ICStocksController()).GetListFromDataSet((DataSet)BOSApp.LookupTables["ICStocks"]);
            }
            else
            {
                ListStocksInfo = (new ICStocksController()).GetListRealStock();
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
        }

        private void guiImportBOM_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcProductsGridControl.InvalidateDataSource(ProductsList, IsShipment);
            fld_dgcProductsGridControl.Visible = true;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApproveImportBOM_Click(object sender, EventArgs e)
        {
            if (!IsValidSaveBOM())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool IsValidSaveBOM()
        {
            ICProductsForViewInfo objProductsInfo = new ICProductsForViewInfo();
            string messageError = string.Empty;

            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            ICStocksInfo objStocksInfo = new ICStocksInfo();
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            DateTime shipmentDate = BOSApp.GetCurrentServerDate();

            ProductsList.ForEach(o =>
            {
                if (!string.IsNullOrWhiteSpace(o.IPMeasureUnitName))
                {
                    objMeasureUnitsInfo = ListMeasureUnitsInfo.Where(f => f.ICMeasureUnitName.Trim() == o.IPMeasureUnitName.Trim()).FirstOrDefault();
                    o.FK_ICMeasureUnitID = objMeasureUnitsInfo == null ? 0 : objMeasureUnitsInfo.ICMeasureUnitID;
                }

                if(!string.IsNullOrWhiteSpace(o.IPStockNo))
                {
                    objStocksInfo = ListStocksInfo.Where(f => f.ICStockNo.Trim() == o.IPStockNo.Trim()).FirstOrDefault();
                    if (objStocksInfo == null)
                    {
                        objStocksInfo = ListStocksInfo.Where(f => f.ICStockName.Trim() == o.IPStockNo.Trim()).FirstOrDefault();
                    }
                    o.FK_ICStockID = objStocksInfo == null ? 0 : objStocksInfo.ICStockID;
                }   
                if (!string.IsNullOrWhiteSpace(o.IPProductNo))
                {
                    objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNo.Trim() == o.IPProductNo.Trim()).FirstOrDefault();
                    if (objProductsInfo == null)
                    {
                        messageError += string.Format("Mã sản phẩm [{0}] không tồn tại trong hệ thống.", o.IPProductNo);
                        messageError += Environment.NewLine;
                    }
                    else if (objProductsInfo.ICProductName.Trim() != o.IPProductName.Trim() && !string.IsNullOrWhiteSpace(o.IPProductName))
                    {
                        messageError += string.Format("Sản phẩm [{0}] có tên khác với tên đã tồn tại trong hệ thống.", o.IPProductNo);
                        messageError += Environment.NewLine;
                    }
                    else if (objProductsInfo.ICProductNoOfOldSys.Trim() != o.IPProductNoOfOldSys.Trim() && !string.IsNullOrWhiteSpace(o.IPProductNoOfOldSys))
                    {
                        messageError += string.Format("Sản phẩm [{0}] có Mã HT cũ khác với Mã HT cũ đã tồn tại trong hệ thống.", o.IPProductNo);
                        messageError += Environment.NewLine;
                    }
                    o.FK_ICProductID = objProductsInfo == null ? 0 : objProductsInfo.ICProductID;
                }
                if (string.IsNullOrWhiteSpace(o.IPProductNo) && !string.IsNullOrWhiteSpace(o.IPProductNoOfOldSys))
                {
                    objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductNoOfOldSys.Trim() == o.IPProductNoOfOldSys.Trim() && p.ICProductActiveCheck).FirstOrDefault();
                    if (objProductsInfo == null)
                    {
                        messageError += string.Format("Mã sản phẩm [{0}] không tồn tại trong hệ thống.", o.IPProductNoOfOldSys);
                        messageError += Environment.NewLine;
                    }
                    o.FK_ICProductID = objProductsInfo == null ? 0 : objProductsInfo.ICProductID;
                    o.IPProductNo = objProductsInfo == null ? string.Empty : objProductsInfo.ICProductNo;
                    o.IPProductName = objProductsInfo == null ? string.Empty : objProductsInfo.ICProductName;
                    o.IPProductDesc = objProductsInfo == null ? string.Empty : objProductsInfo.ICProductDesc;
                }

                if (IsShipment && !string.IsNullOrWhiteSpace(o.IPProductSerieNo))
                {
                    ListProductSeriesInfo = (new ICProductSeriesController()).GetSeriesByProductIDAndStockID(o.FK_ICProductID, o.FK_ICStockID, null, shipmentDate);
                    objProductSeriesInfo = ListProductSeriesInfo.Where(f => f.ICProductSerieNo == o.IPProductSerieNo.Trim()).FirstOrDefault();
                    o.FK_ICProductSerieID = objProductSeriesInfo == null ? 0 : objProductSeriesInfo.ICProductSerieID;
                }

                if (objMeasureUnitsInfo == null && !string.IsNullOrWhiteSpace(o.IPMeasureUnitName))
                {
                    messageError += string.Format("Đơn vị tính [{0}] không tồn tại trong hệ thống.", o.IPMeasureUnitName);
                    messageError += Environment.NewLine;
                    return;
                }
                List<ICMeasureUnitsInfo> listProductMeasureUnit = (List<ICMeasureUnitsInfo>)(new ICMeasureUnitsController()).GetListFromDataSet((new ICMeasureUnitsController()).GetMeasureUnitByProductID(o.FK_ICProductID));
                ICMeasureUnitsInfo objProductMeasureUnitsInfo = listProductMeasureUnit.Where(f => f.ICMeasureUnitName.Trim() == o.IPMeasureUnitName.Trim()).FirstOrDefault();
                if (objProductMeasureUnitsInfo == null)
                {
                    messageError += string.Format("Đơn vị tính [{0}] không trùng với ĐVT của sản phẩm.", o.IPMeasureUnitName);
                    messageError += Environment.NewLine;
                    return;
                }    

                if (objStocksInfo == null && !string.IsNullOrWhiteSpace(o.IPStockNo))
                {
                    messageError += string.Format("Kho [{0}] không tồn tại trong hệ thống.", o.IPStockNo);
                    messageError += Environment.NewLine;
                    return;
                }
                if (IsShipment)
                {
                    if (objProductSeriesInfo == null && !string.IsNullOrWhiteSpace(o.IPProductSerieNo))
                    {
                        messageError += string.Format("Mã lô hàng [{0}] thuộc kho [{1}] không tồn tại trong hệ thống.", o.IPProductSerieNo, o.IPStockNo);
                        messageError += Environment.NewLine;
                        return;
                    }
                }    
            });
            
            if (string.IsNullOrWhiteSpace(messageError))
                return true;

            messageError += "Vui lòng kiểm tra lại!";
            messageError += Environment.NewLine;
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
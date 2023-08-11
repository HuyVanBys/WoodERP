using BOSReport;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace BOSERP.Modules.ProductPackage
{
    public class ProductPackageModule : BaseTransactionModule
    {
        public const string ModuleName = "ProductPackage";

        public ProductPackageModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new ProductPackageEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void ViewPackageItem(ICProductPackagesInfo obj)
        {
            ProductPackageEntities entity = (ProductPackageEntities)CurrentModuleEntity;
            ICProductPackageItemsController objController = new ICProductPackageItemsController();
            List<ICProductPackageItemsInfo> listItem = objController.GetPackageItemsListByPackageID(obj.ICProductPackageID);
            if (listItem != null && listItem.Count > 0)
            {
                guiShowPackageProductItem guiFind = new guiShowPackageProductItem();
                guiFind.ProductPackageItemsList = listItem;
                guiFind.Module = this;
                guiFind.ShowDialog();
            }
            else
                BOSApp.ShowMessage("Không tìm thấy chi tiết kiện này!");

        }

        public void SetDefaultProductPackageItemList()
        {

            ProductPackageEntities entity = (ProductPackageEntities)CurrentModuleEntity;
            ICProductPackagesInfo objProductPackagesInfo = (ICProductPackagesInfo)entity.MainObject;
        }
        public void GetPackageData(string packNo, int productID, int supplierID
                                , string packName, string lotNo, string supplierLotNo
                                , int attributeID, int batchID, string barcodeNo, bool fld_ckeGetInfoFromBatch)
        {
            ProductPackageEntities entity = (ProductPackageEntities)CurrentModuleEntity;
            ICProductPackagesController controler = new ICProductPackagesController();
            List<ICProductPackagesInfo> listData = controler.GetPackageDataByBatchAndSomeCriteria(packNo, productID, supplierID
                                                                                        , packName, lotNo, supplierLotNo
                                                                                        , attributeID, batchID, barcodeNo, fld_ckeGetInfoFromBatch);
            entity.ProductPackageList.Invalidate(listData);
            if (entity.ProductPackageList.GridControl != null)
                entity.ProductPackageList.GridControl.RefreshDataSource();
        }
        public void PrintBarcode(ICProductPackagesInfo obj)
        {
            RPReceiptPackageItemQRCode report = new RPReceiptPackageItemQRCode();
            ICReceiptPackageItemsController objReceiptPackageItemsController = new ICReceiptPackageItemsController();
            List<ICReceiptPackageItemsInfo> selected = new List<ICReceiptPackageItemsInfo>();
            List<ICReceiptPackageItemsInfo> duplicate = new List<ICReceiptPackageItemsInfo>();
            ICReceiptPackageItemsInfo item = new ICReceiptPackageItemsInfo();
            item.ICReceiptPackageItemBarCode = obj.ICProductPackageBarcodeNo;
            item.ICReceiptPackageItemQty = obj.ICProductPackageProductQty;
            item.ICReceiptPackageItemNo = obj.ICProductPackageNo;
            item.ICReceiptPackageItemName = obj.ICProductPackageName;
            item.ICProductPackageProductQty = obj.ICProductPackageQty;
            item.ICProductDesc = obj.ICProductPackageDesc;
            item.ICReceiptPackageItemProductSerieNo = obj.ICProductPackageSerialNo;
            item.MMBatchProductItemNeededTime = obj.MMBatchProductItemNeededTime;
            item.PMProjectNo = obj.PMProjectNo;
            item.ICProductDesc = obj.ICProductDesc;
            item.ICReceiptPackageDesc = "Dx" + Math.Round(obj.ICProductPackageLength, 0) + "Rx" + Math.Round(obj.ICProductPackageWidth, 0) + "Cx" + Math.Round(obj.ICProductPackageHeight, 0);
            selected.Add(item);

            selected.ForEach(o =>
            {
                o.BarcodeImage = (System.Drawing.Image)EncodingQR(250, 250, o.ICReceiptPackageItemBarCode);
                for (int i = 1; i < o.ICReceiptPackageItemQty; i++)
                {
                    ICReceiptPackageItemsInfo objReceiptPackageItemsInfo = (ICReceiptPackageItemsInfo)o.Clone();
                    duplicate.Add(objReceiptPackageItemsInfo);
                }
            });
            selected = selected.Union(duplicate).OrderBy(o => o.ICReceiptPackageItemBarCode).ToList();
            report.bsReceiptPackageItems.DataSource = selected;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
            reviewer.ShowDialog();
        }
        public void PrintMultiBarcode(ICProductPackagesInfo objcall)
        {
            ProductPackageEntities entity = (ProductPackageEntities)CurrentModuleEntity;
            List<ICProductPackagesInfo> selectedList = new List<ICProductPackagesInfo>();
            if (objcall != null) selectedList.Add(objcall);
            else selectedList = GetSelectedList();
            if (selectedList == null || selectedList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RPReceiptPackageItemQRCode report = new RPReceiptPackageItemQRCode();
            ICReceiptPackageItemsController objReceiptPackageItemsController = new ICReceiptPackageItemsController();
            List<ICReceiptPackageItemsInfo> selected = new List<ICReceiptPackageItemsInfo>();
            List<ICReceiptPackageItemsInfo> duplicate = new List<ICReceiptPackageItemsInfo>();
            foreach (ICProductPackagesInfo obj in selectedList)
            {
                ICReceiptPackageItemsInfo item = new ICReceiptPackageItemsInfo();
                item.ICReceiptPackageItemBarCode = obj.ICProductPackageBarcodeNo;
                item.ICReceiptPackageItemQty = obj.ICProductPackageProductQty;
                item.ICReceiptPackageItemNo = obj.ICProductPackageNo;
                item.ICReceiptPackageItemName = obj.ICProductPackageName;
                item.ICProductPackageProductQty = obj.ICProductPackageQty;
                item.ICReceiptPackageItemProductSerieNo = obj.ICProductPackageSerialNo;
                item.MMBatchProductItemNeededTime = obj.MMBatchProductItemNeededTime;
                item.PMProjectNo = obj.PMProjectNo;
                item.ICProductDesc = obj.ICProductDesc;
                item.ICReceiptPackageDesc = "Dx" + Math.Round(obj.ICProductPackageLength, 0) + "Rx" + Math.Round(obj.ICProductPackageWidth, 0) + "Cx" + Math.Round(obj.ICProductPackageHeight, 0);
                selected.Add(item);
            }
            selected.ForEach(o =>
            {
                o.BarcodeImage = (System.Drawing.Image)EncodingQR(250, 250, o.ICReceiptPackageItemBarCode);
                for (int i = 1; i < o.ICReceiptPackageItemQty; i++)
                {
                    ICReceiptPackageItemsInfo objReceiptPackageItemsInfo = (ICReceiptPackageItemsInfo)o.Clone();
                    duplicate.Add(objReceiptPackageItemsInfo);
                }
            });
            selected = selected.Union(duplicate).OrderBy(o => o.ICReceiptPackageItemBarCode).ToList();
            report.bsReceiptPackageItems.DataSource = selected;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
            reviewer.ShowDialog();
        }
        public List<ICProductPackagesInfo> GetSelectedList()
        {
            ProductPackageEntities entity = (ProductPackageEntities)CurrentModuleEntity;
            if (entity.ProductPackageList.GridControl == null) return null;
            GridView gridView = (GridView)entity.ProductPackageList.GridControl.MainView;
            List<ICProductPackagesInfo> listView = new List<ICProductPackagesInfo>();

            List<ICProductPackagesInfo> objects = new List<ICProductPackagesInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(j);
                if (obj != null && obj.Selected)
                {
                    objects.Add(obj);
                }
            }
            return objects;
        }
        public Bitmap EncodingQR(int width, int height, string inputStringToBarcode)
        {
            BarcodeWriter bw = new BarcodeWriter();
            bw.Format = ZXing.BarcodeFormat.QR_CODE;
            EncodingOptions encOptions = new EncodingOptions() { Width = width, Height = height, Margin = 0 };
            bw.Options = encOptions;
            if (string.IsNullOrEmpty(inputStringToBarcode))
                inputStringToBarcode = " ";
            Bitmap result = new Bitmap(bw.Write(inputStringToBarcode));
            return result;
        }
        public void CheckedAllByFilterItem(bool isChecked)
        {
            ProductPackageEntities entity = (ProductPackageEntities)CurrentModuleEntity;
            if (entity.ProductPackageList.GridControl == null) return;
            GridView gridView = (GridView)entity.ProductPackageList.GridControl.MainView;
            List<ICProductPackagesInfo> listView = new List<ICProductPackagesInfo>();

            List<ICProductPackagesInfo> objects = new List<ICProductPackagesInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(j);
                if (obj != null)
                {
                    objects.Add(obj);
                }
            }
            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    ICProductPackagesInfo obj = (ICProductPackagesInfo)gridView.GetRow(j);
                    if (obj != null)
                    {
                        listView.Add(obj);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                            objects[i].IsError = false;
                        }
                    }
                }
            }
            entity.ProductPackageList.GridControl.RefreshDataSource();
        }
    }
}

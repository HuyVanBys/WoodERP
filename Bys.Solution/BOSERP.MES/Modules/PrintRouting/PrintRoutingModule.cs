using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSReport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.PrintRouting
{
    public class PrintRoutingModule : BaseModuleERP
    {
        List<MMBatchProductProductionNormItemsInfo> BatchProductProductionNormItemsList;
        public int BatchProductID = 0;
        public int OperationID = 0;
        public ICProductsInfo objProductInfo = new ICProductsInfo();
        public int AutoBarcode = 0;
        public string TypeFilter = string.Empty;
        public PrintRoutingModule()
        {
            Name = ModuleName.PrintRouting;
            CurrentModuleEntity = new PrintRoutingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            MMPrintRoutingsController objCOntroller = new MMPrintRoutingsController();
            AutoBarcode = objCOntroller.GetBarcodeMax();
        }
        public void SeachData()
        {
            if (TypeFilter == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn loại trước!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TypeFilter == "Cụm xác định thành phẩm" && objProductInfo.ICProductID == 0)
            {
                MessageBox.Show("Vui lòng chọn thành phẩm/ Carcass theo loại này!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PrintRoutingEntities entity = (PrintRoutingEntities)CurrentModuleEntity;
            MMBatchProductProductionNormItemsController objController = new MMBatchProductProductionNormItemsController();
            if (TypeFilter == "Thành Phẩm")
                BatchProductProductionNormItemsList = objController.GetListByBatchProductAndExistOperation(BatchProductID, OperationID, ProductType.Product.ToString());
            else if (TypeFilter == "Cụm")
                BatchProductProductionNormItemsList = objController.GetListByBatchProductAndExistOperation(BatchProductID, OperationID, ProductType.Component.ToString());
            else if (TypeFilter == "Cụm xác định thành phẩm")
                BatchProductProductionNormItemsList = objController.GetListByBatchProductAndExistOperation(BatchProductID, OperationID, ProductType.SemiProductForSyncProduct.ToString());
            else
                BatchProductProductionNormItemsList = objController.GetListByBatchProductAndExistOperation(BatchProductID, OperationID, ProductType.SemiProduct.ToString());

            if (objProductInfo.ICProductID != 0)
            {
                if (objProductInfo.ICProductCheckCarcass)
                    BatchProductProductionNormItemsList = BatchProductProductionNormItemsList.Where(i => i.FK_ICProductCarcassID == objProductInfo.ICProductID).ToList();
                else
                    BatchProductProductionNormItemsList = BatchProductProductionNormItemsList.Where(i => i.FK_ICProductForBatchID == objProductInfo.ICProductID).ToList();
            }
            MMBatchProductItemsController objBIController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> objBatchProductItemList = objBIController.GetitemisCarcassByBatchProductID(BatchProductID);
            BatchProductProductionNormItemsList = GroupProductionNormItem(BatchProductProductionNormItemsList, objBatchProductItemList);
            entity.PrintRoutingList.BackupList.Clear();
            entity.PrintRoutingList.OriginalList.Clear();
            entity.PrintRoutingList.Clear();
            foreach (MMBatchProductProductionNormItemsInfo item in BatchProductProductionNormItemsList)
            {
                MMPrintRoutingsInfo objPrinRouting = new MMPrintRoutingsInfo();
                BOSUtil.CopyObject(item, objPrinRouting);
                objPrinRouting.FK_MMBatchProductProductionNormItemID = item.MMBatchProductProductionNormItemID;
                objPrinRouting.FK_ICProductForBatchID = item.FK_ICProductCarcassID;
                objPrinRouting.MMPrintRoutingProductForBatchName = item.ProductForBatchName;
                objPrinRouting.MMPrintRoutingID = item.MMPrintRoutingID;
                objPrinRouting.MMPrintRoutingProductionNormItemQuantity = item.MMBatchProductProductionNormItemQuantity;
                if (objPrinRouting.MMPrintRoutingProductQty < 0)
                    objPrinRouting.MMPrintRoutingProductQty = 0;
                if (objPrinRouting.MMPrintRoutingProductQty != objPrinRouting.MMPrintRoutingProductionNormItemQuantity)
                    UpdateQualityForItems(objPrinRouting);

                if (item.MMBatchProductProductionNormItemBarcode == string.Empty)
                {
                    AutoBarcode++;
                    objPrinRouting.MMPrintRoutingBarcode = String.Format("{0}", AutoBarcode.ToString().PadLeft(10, '0')); ;
                    item.MMBatchProductProductionNormItemBarcode = objPrinRouting.MMPrintRoutingBarcode;
                }
                entity.PrintRoutingList.Add(objPrinRouting);
            }
            entity.PrintRoutingList.GridControl?.RefreshDataSource();
        }
        public void SaveItemList()
        {
            PrintRoutingEntities entity = (PrintRoutingEntities)CurrentModuleEntity;
            entity.PrintRoutingList.SaveItemObjects();
            MessageBox.Show("Lưu thành công!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void PrintRouting()
        {
            PrintRoutingEntities entity = (PrintRoutingEntities)CurrentModuleEntity;
            if (entity.PrintRoutingList.Where(i => i.MMPrintRoutingID == 0).FirstOrDefault() != null)
            {
                MessageBox.Show("Vui lòng lưu trước khi in!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<MMBatchProductProductionNormItemsInfo> fillterList = new List<MMBatchProductProductionNormItemsInfo>();
            foreach (MMPrintRoutingsInfo item in entity.PrintRoutingList.Where(i => i.Selected).ToList())
            {
                fillterList.Add(BatchProductProductionNormItemsList.Where(i => i.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID).FirstOrDefault());
            }
            InitRoutingDataList(fillterList);
        }
        public void InitRoutingDataList(List<MMBatchProductProductionNormItemsInfo> dataList)
        {
            MMBatchProductProductionNormItemProcesssController objProcessCOnrtroller = new MMBatchProductProductionNormItemProcesssController();
            MMBatchProductProductionNormItemMeterialsController objMaterialController = new MMBatchProductProductionNormItemMeterialsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<MMBatchProductProductionNormItemMeterialsInfo> materialList = new List<MMBatchProductProductionNormItemMeterialsInfo>();
            string strEmployeeName = string.Empty;
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID) as HREmployeesInfo;
            if (objEmployeesInfo != null)
                strEmployeeName = objEmployeesInfo.HREmployeeName;
            foreach (MMBatchProductProductionNormItemsInfo item in dataList)
            {
                item.KTTinh = string.Format("{0}x{1}x{2}", item.MMBatchProductProductionNormItemProductLength.ToString("n0")
                                                       , item.MMBatchProductProductionNormItemProductWidth.ToString("n0")
                                                       , item.MMBatchProductProductionNormItemProductHeight.ToString("n0"));

                if (item.ICProductPicture != null)
                {
                    MemoryStream stream = new MemoryStream(item.ICProductPicture);
                    item.ProductImage = System.Drawing.Bitmap.FromStream(stream);
                    //item.ProductImage = GetImageForSemiProduct(item.FK_ICProductID);
                }

                try
                {
                    item.ProductItemImage = GetImageForSemiProduct(item.FK_ICProductID);
                }
                catch
                {
                    BOSApp.ShowMessage(string.Format("Link ảnh hoặc định dạng hình ảnh của mã {0} - {1} không hợp lệ!" + Environment.NewLine + "Vui lòng kiểm tra lại!", item.MMBatchProductProductionNormItemNo, item.MMBatchProductProductionNormItemProductName));
                }
                //item.ProductItemImage = GetImageForSemiProduct(item);
                item.ProductBarcodeImage = BOSERP.Utilities.Code128Rendering.MakeBarcodeLargeImage(item.MMBatchProductProductionNormItemBarcode, 1, false);
                item.ProcessList = new List<MMBatchProductProductionNormItemProcesssInfo>();
                if (TypeFilter == "Cụm xác định thành phẩm")
                    item.ProcessList.AddRange(objProcessCOnrtroller.GetListForPrintRouting(item.FK_MMBatchProductID, item.FK_ICProductID, true));
                else
                    item.ProcessList.AddRange(objProcessCOnrtroller.GetListForPrintRouting(item.FK_MMBatchProductID, item.FK_ICProductID, false));
                materialList = objMaterialController.GetListByBatchProductProductionNormItemID(item.MMBatchProductProductionNormItemID);
                item.MaterialItemDesc = string.Join("\n", materialList.Where(i => i.MMBatchProductProductionNormItemMeterialQty != 0).ToList().Select(i => i.ICProductDesc).ToArray());
                item.MaterialItemQty = string.Join("\n", materialList.Where(i => i.MMBatchProductProductionNormItemMeterialQty != 0).ToList().Select(i => i.MMBatchProductProductionNormItemMeterialQty.ToString("n0")).ToArray());

                item.PrintByAndDate = strEmployeeName + "/" + BOSApp.GetCurrentServerDate().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            dataList.ForEach(o =>
            {
                o.PrintByAndDate = strEmployeeName + "/" + BOSApp.GetCurrentServerDate().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            });

            BatchProductRoutingNew report = new BatchProductRoutingNew();
            report.MMBatchProductProductionNormItems.DataSource = dataList;
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.Show();
        }

        public Image GetImageForSemiProduct(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = objProductsController.GetObjectByID(productID) as ICProductsInfo;
            if (objProductsInfo != null && !string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(objProductsInfo.ICProductImageFile);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                return img;
            }
            return null;
        }

        public List<MMBatchProductProductionNormItemsInfo> GroupProductionNormItem(List<MMBatchProductProductionNormItemsInfo> dataList, List<MMBatchProductItemsInfo> objBatchProductItemList)
        {
            List<MMBatchProductProductionNormItemsInfo> filterList = new List<MMBatchProductProductionNormItemsInfo>();

            foreach (MMBatchProductProductionNormItemsInfo item in dataList)
            {
                MMBatchProductProductionNormItemsInfo obj = filterList.Where(i => i.FK_ICProductID == item.FK_ICProductID
                                                                                 && i.ProductForBatchNo == item.ProductForBatchNo).FirstOrDefault();
                if (obj != null)
                {

                    obj.MMBatchProductProductionNormItemQuantityPerOne = item.MMBatchProductProductionNormItemQuantityPerOne;
                    obj.MMBatchProductProductionNormItemQuantity += item.MMBatchProductProductionNormItemQuantity;
                    obj.MMPrintRoutingProductQty += item.MMPrintRoutingProductQty;
                }
                else
                    filterList.Add(item);
            }
            filterList.ForEach(i =>
                {
                    i.MMBatchProductItemProductQty = objBatchProductItemList.Where(t => t.ICProductNo == i.ProductForBatchNo).ToList().Sum(h => h.MMBatchProductItemProductQty);
                });

            return filterList;
        }

        public void UpdateQualityForItems(decimal mMBatchProductItemQty)
        {
            PrintRoutingEntities entity = (PrintRoutingEntities)CurrentModuleEntity;
            foreach (MMBatchProductProductionNormItemsInfo item in BatchProductProductionNormItemsList)
            {
                item.MMBatchProductItemProductQty = mMBatchProductItemQty;
                item.MMBatchProductProductionNormItemQuantity = item.MMBatchProductItemProductQty * item.MMBatchProductProductionNormItemQuantityPerOne;
                item.MMPrintRoutingProductQty = item.MMBatchProductProductionNormItemQuantity;
            }
            decimal qty = 0;
            foreach (MMPrintRoutingsInfo item in entity.PrintRoutingList)
            {
                qty = BatchProductProductionNormItemsList.Where(i => i.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID).FirstOrDefault().MMPrintRoutingProductQty;
                if (item.MMPrintRoutingProductQty != qty)
                {
                    item.MMPrintRoutingProductQty = qty;
                    item.MMPrintRoutingID = 0;
                }
            }
            entity.PrintRoutingList.GridControl?.RefreshDataSource();
            entity.PrintRoutingList.SaveItemObjects();
        }
        public void UpdateQualityForItems(MMPrintRoutingsInfo item)
        {
            PrintRoutingEntities entity = (PrintRoutingEntities)CurrentModuleEntity;
            if (item.MMPrintRoutingProductQty > item.MMPrintRoutingProductionNormItemQuantity)
            {
                MessageBox.Show("Số lượng không được lớn hơn số lượng định mức!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                item.MMPrintRoutingProductQty = item.MMPrintRoutingProductionNormItemQuantity;
                return;
            }
            foreach (MMBatchProductProductionNormItemsInfo obj in BatchProductProductionNormItemsList.Where(i => i.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID).ToList())
            {
                //obj.MMBatchProductItemProductQty = item.MMPrintRoutingProductQty;
                //obj.MMBatchProductProductionNormItemQuantity = obj.MMBatchProductItemProductQty * obj.MMBatchProductProductionNormItemQuantityPerOne;
                //obj.MMPrintRoutingProductQty = obj.MMBatchProductProductionNormItemQuantity;
                obj.MMBatchProductProductionNormItemQuantity = item.MMPrintRoutingProductQty;
                obj.MMBatchProductItemProductQty = obj.MMBatchProductProductionNormItemQuantity / obj.MMBatchProductProductionNormItemQuantityPerOne;
                obj.MMPrintRoutingProductQty = obj.MMBatchProductProductionNormItemQuantity;
            }
            item.MMPrintRoutingID = 0;
            //entity.PrintRoutingList.GridControl.RefreshDataSource();
            //entity.PrintRoutingList.SaveItemObjects();
        }
        public List<ImageWithName> CurrentImageList;
        public class ImageWithName
        {
            public Image Img { get; set; }
            public string ImgName { get; set; }
            public string ImgPath { get; set; }

            public ImageWithName(Image img, string imgName, string imgPath)
            {
                Img = img;
                ImgName = imgName;
                ImgPath = imgPath;
            }
        }
        public Image GetImageForSemiProduct(MMBatchProductProductionNormItemsInfo objBPPNIInfo)
        {
            CurrentImageList = new List<ImageWithName>();
            List<Image> imgList = new List<Image>();
            List<string> fileName = BOSApp.GetFilesInFtpDirectory(ImageFolderType.TechnicalDrawing.ToString(), objBPPNIInfo.ProductForBatchNo, imgList);
            if (fileName != null)
            {
                ImageWithName imgWN;
                for (int i = 0; i < fileName.Count; i++)
                {
                    imgWN = new ImageWithName(imgList[i], fileName[i], string.Empty);
                    CurrentImageList.Add(imgWN);
                }
            }
            ImageWithName iwn = CurrentImageList.FirstOrDefault(t => t.ImgName == objBPPNIInfo.ProductImageName);
            Image img = null;
            if (iwn != null)
            {
                img = iwn.Img;
            }
            else
            {
                foreach (ImageWithName item in CurrentImageList)
                {
                    string[] nameSplit = item.ImgName.Split('.');
                    if (nameSplit != null)
                    {
                        string name = string.Empty;

                        for (int i = 0; i < nameSplit.Length - 1; i++)
                        {
                            name += nameSplit[i];
                        }

                        if (name == objBPPNIInfo.ICProductCode)
                        {
                            img = item.Img;
                            break;
                        }
                    }
                }
            }
            return img;

        }


    }
}

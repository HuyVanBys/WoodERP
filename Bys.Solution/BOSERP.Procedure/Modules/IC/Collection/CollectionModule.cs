using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace BOSERP.Modules.Collection
{
    public class CollectionModule : BaseTransactionModule
    {
        public const string ModuleName = "Collection";

        public CollectionModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new CollectionEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void AddProductToCollectionItemsList()
        {
            CollectionEntities entity = (CollectionEntities)CurrentModuleEntity;
            ICCollectionsInfo objCollectionsInfo = (ICCollectionsInfo)CurrentModuleEntity.MainObject;

            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productWorkList = (List<ICProductsInfo>)objProductsController.GetListFromDataSet(objProductsController.GetAllObjects());
            productWorkList = productWorkList.Where(o => o.ICProductActiveCheck
                                                        && o.ICProductType != ProductType.SemiProduct.ToString()
                                                        && o.FK_ICDepartmentID != 0
                                                        && !o.ICProductNonRetail).ToList();
            List<string> productNoList = entity.ICCollectionItemList.Select(o => o.ICCollectionItemProductNo).ToList();
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(productWorkList, productNoList);
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            IList<ICProductsInfo> results = guiAddProduct.SelectedObjects;
            if (results.Count == 0)
                return;

            if (!Toolbar.IsEditAction() && !Toolbar.IsNewAction())
                ActionEdit();

            List<ICCollectionItemsInfo> collectionItems = results.Select(o => ToCollectionItemsInfo(o, CollectionItemType.Product.ToString())).ToList();
            if (entity.ICCollectionItemList == null)
            {
                entity.ICCollectionItemList.InitBOSList(this,
                                               TableName.ICCollectionsTableName,
                                               TableName.ICCollectionItemsTableName,
                                               BOSList<ICCollectionItemsInfo>.cstRelationForeign);
                entity.ICCollectionItemList.ItemTableForeignKey = "FK_ICCollectionID";
            }
            if (entity.ICCollectionItemList.Count > 0)
                //collectionItems = collectionItems.Union(entity.ICCollectionItemList.ToList()).ToList();
                collectionItems = entity.ICCollectionItemList.Union(collectionItems.ToList()).ToList();
            entity.ICCollectionItemList.Invalidate(collectionItems);
        }

        private ICCollectionItemsInfo ToCollectionItemsInfo(ICProductsInfo objProductsInfo, string productType)
        {
            return new ICCollectionItemsInfo
            {
                FK_ICProductID = objProductsInfo.ICProductID,
                FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID,
                ICCollectionItemProductNo = objProductsInfo.ICProductNo,
                ICCollectionItemProductName = objProductsInfo.ICProductName,
                ICCollectionItemProductDesc = objProductsInfo.ICProductDesc,
                ICCollectionItemProductType = productType,
                ICCollectionItemProductUnitPrice = objProductsInfo.ICProductPrice01,
                ICCollectionItemQty = 1,
                ICCollectionItemBasicQty = 1,
            };
        }

        public void DeleteItemCollectionItemsList()
        {
            CollectionEntities entity = (CollectionEntities)CurrentModuleEntity;
            entity.ICCollectionItemList.RemoveSelectedRowObjectFromList();
        }

        public void DeleteItemCollectionItemWorksList()
        {
            CollectionEntities entity = (CollectionEntities)CurrentModuleEntity;
            entity.ICCollectionItemWorkList.RemoveSelectedRowObjectFromList();
        }

        public void DeleteItemCollectionItemMaterialsList()
        {
            CollectionEntities entity = (CollectionEntities)CurrentModuleEntity;
            entity.ICCollectionItemMaterialList.RemoveSelectedRowObjectFromList();
        }

        public override int ActionSave()
        {
            CollectionEntities entity = (CollectionEntities)CurrentModuleEntity;
            entity.ICCollectionItemList.EndCurrentEdit();
            return base.ActionSave();
        }

        public void AddProductToCollectionItemWorksList()
        {
            CollectionEntities entity = (CollectionEntities)CurrentModuleEntity;
            ICCollectionsInfo objCollectionsInfo = (ICCollectionsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productWorkList = objProductsController.GetListProductByProductType(ProductType.Work.ToString())
                                                                        .Where(o => o.ICProductActiveCheck).ToList();
            List<string> productNoList = entity.ICCollectionItemWorkList.Select(o => o.ICCollectionItemProductNo).ToList();
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(productWorkList, productNoList);
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            IList<ICProductsInfo> results = guiAddProduct.SelectedObjects;
            if (results.Count == 0)
                return;

            if (!Toolbar.IsEditAction() && !Toolbar.IsNewAction())
                ActionEdit();
            List<ICCollectionItemsInfo> collectionItems = results.Select(o => ToCollectionItemsInfo(o, CollectionItemType.Work.ToString())).ToList();
            if (entity.ICCollectionItemWorkList == null)
            {
                entity.ICCollectionItemWorkList.InitBOSList(this,
                                               TableName.ICCollectionsTableName,
                                               TableName.ICCollectionItemsTableName,
                                               BOSList<ICCollectionItemsInfo>.cstRelationForeign);
                entity.ICCollectionItemWorkList.ItemTableForeignKey = "FK_ICCollectionID";
            }
            if (entity.ICCollectionItemWorkList.Count > 0)
                collectionItems = collectionItems.Union(entity.ICCollectionItemWorkList.ToList()).ToList();
            ICProductWorkItemsController objProductWorkItemsController = new ICProductWorkItemsController();
            List<ICProductWorkItemsInfo> productWorkItemList = new List<ICProductWorkItemsInfo>();
            foreach (ICProductsInfo item in results)
            {
                productWorkItemList.AddRange(objProductWorkItemsController.GetProductWorkItemsByProductWorkItemParentIDAndParentType(item.ICProductID, item.ICProductType));
            }

            List<ICCollectionItemsInfo> collectionItemMaterial = new List<ICCollectionItemsInfo>();
            collectionItemMaterial.AddRange(productWorkItemList.Select(o => ToCollectionItemsFormProductMaterial(o)).ToList());
            if (entity.ICCollectionItemMaterialList.Count > 0)
            {
                collectionItemMaterial = entity.ICCollectionItemMaterialList.Union(collectionItemMaterial).ToList();
            }
            entity.ICCollectionItemWorkList.Invalidate(collectionItems.GroupBy(o => o.FK_ICProductID).Select(o => o.First()).ToList());
            entity.ICCollectionItemMaterialList.Invalidate(collectionItemMaterial.GroupBy(o => o.ICCollectionItemProductNo).Select(o => o.First()).ToList());
        }

        public void AddProductToCollectionItemMaterialList()
        {
            CollectionEntities entity = (CollectionEntities)CurrentModuleEntity;
            ICCollectionsInfo objCollectionsInfo = (ICCollectionsInfo)CurrentModuleEntity.MainObject;
            List<string> productTypes = new List<string>();
            productTypes = Enum.GetNames(typeof(ProductType)).Where(s => s != ProductType.Work.ToString()
                                                                         && s != ProductType.SemiProduct.ToString()
                                                                         && s != ProductType.Equipment.ToString()
                                                                         && s != ProductType.VVP.ToString()
                                                                         && s != ProductType.MMTB.ToString()
                                                                         && s != ProductType.Car.ToString()).ToList();
            ICCollectionsInfo objProductsInfo = (ICCollectionsInfo)CurrentModuleEntity.MainObject;
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(p => productTypes.Contains(p.ICProductType)).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                productList.Add(newObj);
            });
            List<string> productNoList = entity.ICCollectionItemMaterialList.Select(o => o.ICCollectionItemProductNo).ToList();
            guiAddProduct<ICProductsInfo> guiAddProduct = new guiAddProduct<ICProductsInfo>(productList, productNoList);
            guiAddProduct.Module = this;
            guiAddProduct.ShowDialog();
            if (guiAddProduct.DialogResult != DialogResult.OK)
                return;

            IList<ICProductsInfo> results = guiAddProduct.SelectedObjects;
            if (results.Count == 0)
                return;

            if (!Toolbar.IsEditAction() && !Toolbar.IsNewAction())
                ActionEdit();

            List<ICCollectionItemsInfo> collectionItems = results.Select(o => ToCollectionItemsInfo(o, CollectionItemType.Material.ToString())).ToList();
            if (entity.ICCollectionItemMaterialList == null)
            {
                entity.ICCollectionItemMaterialList.InitBOSList(this,
                                               TableName.ICCollectionsTableName,
                                               TableName.ICCollectionItemsTableName,
                                               BOSList<ICCollectionItemsInfo>.cstRelationForeign);
                entity.ICCollectionItemMaterialList.ItemTableForeignKey = "FK_ICCollectionID";
            }
            if (entity.ICCollectionItemMaterialList.Count > 0)
            {
                collectionItems = entity.ICCollectionItemMaterialList.Union(collectionItems).ToList();
            }
            entity.ICCollectionItemMaterialList.Invalidate(collectionItems.GroupBy(o => o.ICCollectionItemProductNo).Select(o => o.First()).ToList());
        }

        public ICCollectionItemsInfo ToCollectionItemsFormProductMaterial(ICProductWorkItemsInfo objProductsInfo)
        {
            return new ICCollectionItemsInfo
            {
                FK_ICProductID = objProductsInfo.FK_ICProductWorkItemParentID,
                FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID,
                ICCollectionItemProductNo = objProductsInfo.ICProductWorkItemProductNo,
                ICCollectionItemProductName = objProductsInfo.ICProductWorkItemProductName,
                ICCollectionItemProductDesc = objProductsInfo.ICProductWorkItemProductDesc,
                ICCollectionItemProductType = CollectionItemType.Material.ToString(),
                ICCollectionItemProductUnitPrice = objProductsInfo.ICProductPrice01,
                ICCollectionItemQty = 1,
                ICCollectionItemBasicQty = 1,
            };
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPProductCollection report = new RPProductCollection();
                InitProductCollectionReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevInvoiceItemReportPath, true);
                reviewer.Show();
            }
        }

        private void InitProductCollectionReport(RPProductCollection report)
        {
            ICCollectionsInfo objCollectionsInfo = (ICCollectionsInfo)CurrentModuleEntity.MainObject;
            ICCollectionItemsController objCollectionItemsController = new ICCollectionItemsController();
            List<ICCollectionItemsInfo> collectionItemsList = objCollectionItemsController.GetAllObjectForRPProductCollectionByCollectionID(objCollectionsInfo.ICCollectionID);
            if (collectionItemsList == null)
                collectionItemsList = new List<ICCollectionItemsInfo>();
            List<string> productSizeList = new List<string>();
            ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
            List<ICDepartmentAttributeValuesInfo> departmentAttributeValuesList = new List<ICDepartmentAttributeValuesInfo>();
            List<int> productIDs = new List<int>();
            System.ComponentModel.ComponentResourceManager resourceImgDefault = new System.ComponentModel.ComponentResourceManager(typeof(RPProductCollection));
            Image imgDefault = ((System.Drawing.Image)(resourceImgDefault.GetObject("xrPictureBox4.Image")));
            collectionItemsList.ForEach(o =>
            {
                productSizeList.Clear();
                departmentAttributeValuesList.Clear();
                if (o.ICProductLength > 0 || o.ICProductWidth > 0 || o.ICProductHeight > 0)
                {
                    if (o.ICProductLength != 0)
                        productSizeList.Add(ToString(o.ICProductLength));
                    if (o.ICProductWidth != 0)
                        productSizeList.Add(ToString(o.ICProductWidth));
                    if (o.ICProductHeight != 0)
                        productSizeList.Add(ToString(o.ICProductHeight));
                    o.ICProductSize = string.Join("*", productSizeList.ToArray());
                }

                if (!string.IsNullOrEmpty(o.ICProductAttributeKey))
                {
                    departmentAttributeValuesList = objDepartmentAttributeValuesController.GetDepartmentAttributeByDepartmentAttributeReference(o.ICProductAttributeKey);
                    if (departmentAttributeValuesList != null)
                    {
                        o.ICProductAttributeMaterialText = string.Join("+", departmentAttributeValuesList.Where(o2 => o2.FK_ICDepartmentID == o.FK_ICDepartmentID
                                                                                                                            && o2.ICDepartmentAttributeLevel == DepartmentAttributeColorLevel.Material)
                                                                                                                    .Select(o2 => o2.ICDepartmentAttributeValueValue).ToArray());
                        o.ICProductAttributeColorText = string.Join("+", departmentAttributeValuesList.Where(o2 => o2.FK_ICDepartmentID == o.FK_ICDepartmentID
                                                                                                                            && o2.ICDepartmentAttributeLevel == DepartmentAttributeColorLevel.Color)
                                                                                                                       .Select(o2 => o2.ICDepartmentAttributeValueValue).ToArray());
                    }
                }
                productIDs.Add(o.FK_ICProductID);
            });
            List<ICProductFilesInfo> productFiles = ApiClientHelper.GetPrimaryImages(productIDs.ToArray());
            ICProductFilesInfo objProductFilesInfo = new ICProductFilesInfo();
            collectionItemsList.ForEach(o =>
            {
                objProductFilesInfo = productFiles.Where(o1 => o1.FK_ICProductID == o.FK_ICProductID).FirstOrDefault();
                o.ICProductImage = objProductFilesInfo == null ? imgDefault : objProductFilesInfo.ICProductFileImage;
            });
            XRLabel lblCollectionName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCollectionName"];
            if (lblCollectionName != null)
            {
                lblCollectionName.Text = objCollectionsInfo.ICCollectionName.ToUpper();
            }
            XRPictureBox collectionBarcode = (XRPictureBox)report.Bands[BandKind.PageFooter].Controls["xrCollectionBarcode"];
            if (collectionBarcode != null)
            {
                collectionBarcode.Image = (System.Drawing.Image)EncodingQR((int)collectionBarcode.WidthF, (int)collectionBarcode.HeightF, objCollectionsInfo.ICCollectionNo);
            }
            report.bsProductCollections.DataSource = collectionItemsList;
        }

        private string ToString(decimal number)
        {
            if (number == 0)
                return "0";
            return number / Convert.ToInt32(number) != 1 ? number.ToString("N3") : number.ToString("N0");
        }

        public Bitmap EncodingQR(int width, int height, string inputStringToBarcode)
        {
            BarcodeWriter bw = new BarcodeWriter();
            bw.Format = ZXing.BarcodeFormat.QR_CODE;
            EncodingOptions encOptions = new EncodingOptions() { Width = width, Height = height, Margin = 0 };
            bw.Options = encOptions;
            Bitmap result = new Bitmap(bw.Write(inputStringToBarcode));
            return result;
        }
    }
}

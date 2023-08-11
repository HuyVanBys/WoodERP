using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.ChangeBOMInformation.UI;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.ChangeBOMInformation
{
    public class ChangeBOMInformationModule : BaseTransactionModule
    {
        #region Constants
        public const string CustomerLookupEditControlName = "fld_lkeFK_ARCustomerID";
        public const string SaleOrderLookupEditControlName = "fld_lkeFK_ARSaleOrderID";
        public const string BatchProductLookupEditControlName = "fld_lkeFK_MMBatchProductID";
        public const string ProductLookupEditControlName = "fld_lkeFK_ICProductID";
        public const string ProductionNormLookupEditControlName = "fld_lkeFK_MMProductionNormID";
        #endregion Constants

        #region Private Properties
        public BOSLookupEdit CustomerLookupEditControl = null;
        public BOSLookupEdit SaleOrderLookupEditControl = null;
        public BOSLookupEdit BatchProductLookupEditControl = null;
        public BOSLookupEdit ProductLookupEditControl = null;
        public BOSLookupEdit ProductionNormLookupEditControl = null;
        #endregion Private Properties

        #region Public methods

        public ChangeBOMInformationModule()
        {
            Name = "ChangeBOMInformation";
            CurrentModuleEntity = new ChangeBOMInformationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            InvalidateToolbar();

            CustomerLookupEditControl = (BOSLookupEdit)Controls[CustomerLookupEditControlName];

            SaleOrderLookupEditControl = (BOSLookupEdit)Controls[SaleOrderLookupEditControlName];
            SaleOrderLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(SaleOrderLookupEditControl_QueryPopUp);

            BatchProductLookupEditControl = (BOSLookupEdit)Controls[BatchProductLookupEditControlName];
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductList = objBatchProductsController.GetAllBatchProductForLookupToProduction();
            BatchProductLookupEditControl.Properties.DataSource = batchProductList;

            ProductLookupEditControl = (BOSLookupEdit)Controls[ProductLookupEditControlName];
            ProductLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductLookupEditControl_QueryPopUp);

            ProductionNormLookupEditControl = (BOSLookupEdit)Controls[ProductionNormLookupEditControlName];
            ProductionNormLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductionNormLookupEditControl_QueryPopUp);
        }

        public List<MMBatchProductsInfo> GetDatasourceForLookupToProduction()
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductList = objBatchProductsController.GetAllBatchProductForLookupToProduction(objChangeBOMInformationsInfo.FK_ARSaleOrderID);
            return batchProductList;
        }

        void ProductionNormLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;

            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            List<MMProductionNormsInfo> productionNormsList = new List<MMProductionNormsInfo>();
            productionNormsList.Add(new MMProductionNormsInfo());
            if (objChangeBOMInformationsInfo.FK_ICProductID > 0)
            {
                productionNormsList.AddRange(objProductionNormsController.GetApprovedProductionNormByProductID(objChangeBOMInformationsInfo.FK_ICProductID));

                ProductionNormLookupEditControl.Properties.DataSource = productionNormsList;
            }
            else
            {

                productionNormsList.AddRange(objProductionNormsController.GetAllAliveProductionNorm());

                ProductionNormLookupEditControl.Properties.DataSource = productionNormsList;
            }

        }

        void ProductLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;

            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productsList = new List<ICProductsInfo>();
            productsList.Add(new ICProductsInfo());
            if (objChangeBOMInformationsInfo.FK_MMBatchProductID > 0)
            {
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                List<MMBatchProductItemsInfo> batchProductItemList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(objChangeBOMInformationsInfo.FK_MMBatchProductID);

                foreach (MMBatchProductItemsInfo item in batchProductItemList)
                {
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        productsList.Add(objProductsInfo);
                    }
                }
                ProductLookupEditControl.Properties.DataSource = productsList;
            }
            else
            {
                //productsList.AddRange(objProductsController.GetProductByProductType(ProductType.Product.ToString()));
                ProductLookupEditControl.Properties.DataSource = productsList;
            }

        }


        void SaleOrderLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrderList = new List<ARSaleOrdersInfo>();
            saleOrderList.Add(new ARSaleOrdersInfo());
            saleOrderList.AddRange(objSaleOrdersController.GetSaleOrderByCustomerIDAndSaleOrderStatus(objChangeBOMInformationsInfo.FK_ARCustomerID, SaleOrderBatchStatus.Producing.ToString()));
            SaleOrderLookupEditControl.Properties.DataSource = saleOrderList;


        }

        #region Lookup Datasource
        public void ChangeCustomer(int customerID)
        {

        }

        public void ChangeSaleOrder(int saleOrderID)
        {

        }

        public void ChangeBatchProduct(int batchProductID)
        {

        }

        public void ChangeProduct(int productID)
        {

        }
        #endregion

        #region Choose Histoy Log
        public void ShowBOMChangeLog(DateTime fromDate, DateTime toDate)
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;

            GEObjectHistoryController objObjectHistoryController = new GEObjectHistoryController();
            List<GEObjectHistoryInfo> objGEObjectHistoryList = new List<GEObjectHistoryInfo>();
            objGEObjectHistoryList = objObjectHistoryController.GetProfileManagementItemFromHistory(objChangeBOMInformationsInfo.FK_MMProductionNormID);
            objGEObjectHistoryList = objGEObjectHistoryList.Where(t => !t.GEHistoryDetailTableName.Equals("A" + ProductType.Product.ToString())).ToList();
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(objChangeBOMInformationsInfo.FK_MMProductionNormID);
            if (objProductionNormsInfo != null)
            {
                objGEObjectHistoryList = objGEObjectHistoryList.Where(t => t.MMProfileManagementItemUpdateDate.Date <= toDate.Date
                                                                            && t.MMProfileManagementItemUpdateDate.Date >= fromDate.Date).ToList();

                objGEObjectHistoryList = objGEObjectHistoryList.Where(t => (t.MMProfileManagementItemUpdateDate.Date <= objProductionNormsInfo.MMProductionNormPaintApproveDate && t.GEHistoryDetailTableName.Equals("E" + ProductType.IngredientPaint.ToString()))
                                                                            || (t.MMProfileManagementItemUpdateDate.Date <= objProductionNormsInfo.MMProductionNormPackingMaterialApproveDate && t.GEHistoryDetailTableName.Equals("D" + ProductType.IngredientPackaging.ToString()))
                                                                            || (t.MMProfileManagementItemUpdateDate.Date <= objProductionNormsInfo.MMProductionNormWoodApproveDate && t.GEHistoryDetailTableName.Equals("B" + ProductType.SemiProduct.ToString()))
                                                                            || (t.MMProfileManagementItemUpdateDate.Date <= objProductionNormsInfo.MMProductionNormHardwareApproveDate && t.GEHistoryDetailTableName.Equals("C" + ProductType.Hardware.ToString()))).ToList();

            }
            entity.ProfileManagementHistoryList.Invalidate(objGEObjectHistoryList);
            guiChooseHistoryLog guiChooseHistory = new guiChooseHistoryLog();
            guiChooseHistory.Module = this;
            if (guiChooseHistory.ShowDialog() == DialogResult.OK)
            {
                MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
                DataSet ds = objBatchProductProductionNormItemsController.GetAllItemByBatchProductID(objChangeBOMInformationsInfo.FK_MMBatchProductID);

                foreach (GEObjectHistoryInfo objectHistoryInfo in entity.ProfileManagementHistoryList)
                {
                    if (objectHistoryInfo.Selected)
                    {
                        MMChangeBOMInformationItemsInfo item = new MMChangeBOMInformationItemsInfo();
                        item = ConvertObjectHistoryToChangeBOMInformationItem(objectHistoryInfo, ds);
                        if (item != null)
                        {
                            item.FK_MMBatchProductID = objChangeBOMInformationsInfo.FK_MMBatchProductID;
                            item.FK_ICProductForBatchID = objChangeBOMInformationsInfo.FK_ICProductID;
                            item.FK_MMProductionNormID = objChangeBOMInformationsInfo.FK_MMProductionNormID;
                            item.MMChangeBOMInformationItemProductDesc = objectHistoryInfo.MMProfileManagementItemProductDesc;
                            entity.ChangeBOMInformationItemList.Add(item);
                        }
                    }
                }
                entity.ChangeBOMInformationItemList.GridControl?.RefreshDataSource();
            }
        }

        public MMChangeBOMInformationItemsInfo ConvertObjectHistoryToChangeBOMInformationItem(GEObjectHistoryInfo objObjectHistoryInfo, DataSet ds)
        {
            MMChangeBOMInformationItemsInfo objChangeBOMInformationItemsInfo = new MMChangeBOMInformationItemsInfo();
            MMProductionNormItemsController productionNormItemsController = new MMProductionNormItemsController();
            MMChangeBOMInformationItemsController objChangeBOMInformationItemsController = new MMChangeBOMInformationItemsController();

            objChangeBOMInformationItemsInfo = objChangeBOMInformationItemsController.GetChangeBOMInformationByGEObjectHistoryID(objObjectHistoryInfo.GEHistoryDetailID);
            if (objChangeBOMInformationItemsInfo != null)
            {

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (row["FK_MMProductionNormItemID"] != null)
                        {
                            int productionNormID = 0;
                            if (int.TryParse(row["FK_MMProductionNormItemID"].ToString(), out productionNormID))
                            {
                                //MMProductionNormItemsInfo pnitem = (MMProductionNormItemsInfo)productionNormItemsController.GetObjectByID(productionNormID);
                                //if (pnitem != null)
                                //{
                                //    objChangeBOMInformationItemsInfo.MMChangeBOMInformationItemProductDesc = pnitem.MMProductionNormItemProductDesc;
                                //}
                                if (productionNormID == objChangeBOMInformationItemsInfo.FK_MMProductionNormItemID)
                                {

                                    if (row["MMBatchProductProductionNormItemID"] != null)
                                    {
                                        objChangeBOMInformationItemsInfo.FK_MMBatchProductProductionNormItemID = int.Parse(row["MMBatchProductProductionNormItemID"].ToString());
                                    }
                                    string columnName = objChangeBOMInformationItemsInfo.MMChangeBOMInformationItemPNItemColumnName.Substring(2);
                                    foreach (DataColumn column in ds.Tables[0].Columns)
                                    {
                                        if (column.ColumnName.Contains(columnName))
                                        {
                                            columnName = column.ColumnName;
                                            break;
                                        }
                                    }
                                    if (ds.Tables[0].Columns[columnName] != null)
                                    {
                                        objChangeBOMInformationItemsInfo.MMChangeBOMInformationItemBPPNItemColumnName = columnName;
                                        objChangeBOMInformationItemsInfo.MMChangeBOMInformationItemBPProductionNormValues = row[columnName].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return objChangeBOMInformationItemsInfo;
        }

        public void HistoryCheckedChange(bool isChecked)
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;

            foreach (GEObjectHistoryInfo item in entity.ProfileManagementHistoryList)
            {
                item.Selected = isChecked;
            }
            entity.ProfileManagementHistoryList.GridControl?.RefreshDataSource();
        }
        #endregion

        #region Validate & Approve

        #region CreateNew
        public void CreateNewWoodParent(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo)
        {

            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo matchObject = objBPPNIsController.GetItemByBatchProductItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (matchObject == null)
            {

                MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
                BOSUtil.CopyObject(objProductionNormItemsInfo, obj);

                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();

                obj.AACreatedDate = currentDate;
                obj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;

                obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
                obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
                obj.MMBatchProductProductionNormItemResourceType = BatchProductProductionNormItemResourceType.Manafacturing.ToString();
                obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
                obj.MMBatchProductProductionNormItemBlockPerOne = ((obj.MMBatchProductProductionNormItemProductLength
                                                                  * obj.MMBatchProductProductionNormItemProductWidth
                                                                  * obj.MMBatchProductProductionNormItemProductHeight) / 1000000000);
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                obj.MMBatchProductProductionNormItemBlocks = Math.Round(obj.MMBatchProductProductionNormItemBlocks, 5, MidpointRounding.AwayFromZero);
                obj.MMBatchProductProductionNormItemPaintA = Math.Round(obj.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
                obj.MMBatchProductProductionNormItemPaintB = Math.Round(obj.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
                obj.MMBatchProductProductionNormItemBlockPerOne = obj.MMBatchProductProductionNormItemBlockPerOne;
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                obj.FK_MMBatchProductID = objBatchProductItemsInfo.FK_MMBatchProductID;
                //set ParentID
                MMBatchProductProductionNormItemsInfo parentObject = objBPPNIsController.GetItemByBatchProductItemIDAndProductIDAndGroupIsProduct(objBatchProductItemsInfo.MMBatchProductItemID, objBatchProductItemsInfo.FK_ICProductID);
                if (parentObject != null)
                {
                    obj.MMBatchProductProductionNormItemParentID = obj.MMBatchProductProductionNormItemID;
                }

                objBPPNIsController.CreateObject(obj);
            }

        }
        public void CreateNewWoodChild(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo)
        {
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo matchObject = objBPPNIsController.GetItemByBatchProductItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (matchObject == null)
            {
                MMBatchProductProductionNormItemsInfo subIObj = new MMBatchProductProductionNormItemsInfo();
                BOSUtil.CopyObject(objProductionNormItemsInfo, subIObj);


                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();

                subIObj.AACreatedDate = currentDate;
                subIObj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;


                subIObj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                subIObj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                subIObj.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                subIObj.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                subIObj.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                subIObj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                subIObj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
                subIObj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;

                subIObj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
                subIObj.MMBatchProductProductionNormItemBlockPerOne = ((subIObj.MMBatchProductProductionNormItemProductLength
                                                             * subIObj.MMBatchProductProductionNormItemProductWidth
                                                             * subIObj.MMBatchProductProductionNormItemProductHeight) / 1000000000);
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                subIObj.MMBatchProductProductionNormItemBlocks = Math.Round(subIObj.MMBatchProductProductionNormItemBlocks, 5, MidpointRounding.AwayFromZero);
                subIObj.MMBatchProductProductionNormItemPaintA = Math.Round(subIObj.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
                subIObj.MMBatchProductProductionNormItemPaintB = Math.Round(subIObj.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
                subIObj.MMBatchProductProductionNormItemBlockPerOne = subIObj.MMBatchProductProductionNormItemBlockPerOne;
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END


                List<MMBatchProductProductionNormItemsInfo> parentList = objBPPNIsController.GetItemByPNIParentIDAndBPItemID(objProductionNormItemsInfo.MMProductionNormItemParentID, objBatchProductItemsInfo.MMBatchProductItemID);
                if (parentList != null)
                {
                    MMBatchProductProductionNormItemsInfo parent = parentList.FirstOrDefault();
                    if (parent != null)
                    {
                        subIObj.MMBatchProductProductionNormItemParentID = parent.MMBatchProductProductionNormItemID;
                        subIObj.MMBatchProductProductionNormItemParentNo = parent.MMBatchProductProductionNormItemNo;
                        subIObj.MMBatchProductProductionNormItemResourceType = parent.MMBatchProductProductionNormItemResourceType;
                        parent.MMBatchProductProductionNormItemBlockPerOne += (subIObj.MMBatchProductProductionNormItemBlockPerOne *
                                                                                subIObj.MMBatchProductProductionNormItemQuantity / objBatchProductItemsInfo.MMBatchProductItemProductQty);
                        parent.MMBatchProductProductionNormItemBlocks += subIObj.MMBatchProductProductionNormItemBlocks;

                        parent.MMBatchProductProductionNormItemBlockPerOne = parent.MMBatchProductProductionNormItemBlockPerOne;
                        parent.MMBatchProductProductionNormItemBlocks = Math.Round(parent.MMBatchProductProductionNormItemBlocks, 5, MidpointRounding.AwayFromZero);
                        objBPPNIsController.UpdateObject(parent);
                    }
                }
                objBPPNIsController.CreateObject(subIObj);
            }
        }

        public void CreateNewHardware(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo)
        {
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo matchObject = objBPPNIsController.GetItemByBatchProductItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (matchObject == null)
            {
                MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
                BOSUtil.CopyObject(objProductionNormItemsInfo, obj);


                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();

                obj.AACreatedDate = currentDate;
                obj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;

                obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemHardwareAssembleQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemHardwareAllocationQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
                obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
                obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
                obj.FK_MMBatchProductID = objBatchProductItemsInfo.FK_MMBatchProductID;
                //MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
                objBPPNIsController.CreateObject(obj);
            }
        }
        public void CreateNewPaint(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo)
        {
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo matchObject = objBPPNIsController.GetItemByBatchProductItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (matchObject == null)
            {
                MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
                BOSUtil.CopyObject(objProductionNormItemsInfo, obj);

                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();

                obj.AACreatedDate = currentDate;
                obj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;

                obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                obj.MMBatchProductProductionNormItemQuantity = Math.Round(obj.MMBatchProductProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
                obj.MMBatchProductProductionNormItemTotalQuantity = Math.Round(obj.MMBatchProductProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                obj.MMBatchProductProductionNormItemProductDesc = objProductionNormItemsInfo.MMProductionNormItemProductDesc;
                obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
                obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
                obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
                obj.FK_MMBatchProductID = objBatchProductItemsInfo.FK_MMBatchProductID;

                obj.MMBatchProductProductionNormItemParentID = 0;
                //MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
                objBPPNIsController.CreateObject(obj);
            }
        }
        public void CreateParentPackaging(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo)
        {
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo matchObject = objBPPNIsController.GetItemByBatchProductItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (matchObject == null)
            {
                ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
                BOSUtil.CopyObject(objProductionNormItemsInfo, obj);


                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();

                obj.AACreatedDate = currentDate;
                obj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;


                #region Mô tả
                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductName))
                {

                    obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductName.Trim();
                }
                if (!(objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight == 0))
                {
                    if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
                    {
                        obj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength.ToString().Trim() + "x"
                    + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim() + "x"
                    + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
                }
                if (!(objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight == 0))
                {
                    if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
                    {
                        obj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength.ToString().Trim() + "x"
                        + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim() + "x"
                        + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
                }
                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking))
                {
                    if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
                    {
                        obj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking.Trim();
                }
                if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
                {
                    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID);
                    if (objAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
                        {
                            obj.MMBatchProductProductionNormItemProductDesc += ", ";
                        }
                        obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                    }
                }
                if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                {
                    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                    if (objAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
                        {
                            obj.MMBatchProductProductionNormItemProductDesc += ", ";
                        }
                        obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                    }
                }
                if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID > 0)
                {

                    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID);
                    if (objAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
                        {
                            obj.MMBatchProductProductionNormItemProductDesc += ", ";
                        }
                        obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                    }
                }
                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemComment))
                {
                    if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
                    {
                        obj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemComment.Trim();
                }
                #endregion

                obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
                obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
                obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
                obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
                obj.FK_MMBatchProductID = objBatchProductItemsInfo.FK_MMBatchProductID;

                objBPPNIsController.CreateObject(obj);
            }
        }
        public void CreateChildPackaging(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo)
        {
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo matchObject = objBPPNIsController.GetItemByBatchProductItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (matchObject == null)
            {
                ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                MMBatchProductProductionNormItemsInfo subIObj = new MMBatchProductProductionNormItemsInfo();
                BOSUtil.CopyObject(objProductionNormItemsInfo, subIObj);

                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();

                subIObj.AACreatedDate = currentDate;
                subIObj.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;

                #region Mô tả
                subIObj.MMBatchProductProductionNormItemProductDesc = string.Empty;
                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductName))
                {
                    subIObj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductName.Trim();
                }
                if (!(objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight == 0))
                {
                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
                    {
                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    subIObj.MMBatchProductProductionNormItemProductDesc +=
                        objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength.ToString().Trim()
                        + "x" + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim()
                        + "x" + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
                }
                if (!(objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength == 0
                    && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight == 0))
                {
                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
                    {
                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    subIObj.MMBatchProductProductionNormItemProductDesc +=
                        objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength.ToString().Trim()
                        + "x" + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim()
                        + "x" + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
                }
                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking))
                {
                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
                    {
                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    subIObj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking.Trim();
                }
                if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
                {
                    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID);
                    if (objAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
                        {
                            subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
                        }
                        subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                    }
                }
                if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                {
                    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                    if (objAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
                        {
                            subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
                        }
                        subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                    }
                }
                if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID > 0)
                {

                    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID);
                    if (objAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
                        {
                            subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
                        }
                        subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                    }
                }
                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemComment))
                {
                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
                    {
                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
                    }
                    subIObj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemComment.Trim();
                }

                #endregion

                subIObj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                subIObj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                subIObj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
                subIObj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
                subIObj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
                subIObj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();

                //  MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();
                List<MMBatchProductProductionNormItemsInfo> parentList = objBPPNIsController.GetItemByPNIParentIDAndBPItemID(objProductionNormItemsInfo.MMProductionNormItemParentID, objBatchProductItemsInfo.MMBatchProductItemID);
                if (parentList != null)
                {
                    MMBatchProductProductionNormItemsInfo parent = parentList.FirstOrDefault();
                    if (parent != null)
                    {
                        subIObj.MMBatchProductProductionNormItemParentID = parent.MMBatchProductProductionNormItemID;
                        subIObj.MMBatchProductProductionNormItemParentNo = parent.MMBatchProductProductionNormItemNo;


                    }
                }
                objBPPNIsController.CreateObject(subIObj);

            }
        }
        #endregion

        #region Update
        public void UpdateBatchProductProductionNormItem(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo, MMChangeBOMInformationItemsInfo item)
        {
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> objBatchProductProductionNormItemsInfoList = objBatchProductProductionNormItemsController.GetItemByBPItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (objBatchProductProductionNormItemsInfoList != null && objBatchProductProductionNormItemsInfoList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo in objBatchProductProductionNormItemsInfoList)
                {
                    if (objBatchProductProductionNormItemsInfo != null)
                    {
                        if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.SemiProduct.ToString())
                        {
                            #region Wood
                            decimal backupBlockPerOne = (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlockPerOne *
                                                                                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity / objBatchProductItemsInfo.MMBatchProductItemProductQty);
                            decimal backupBlock = objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks;

                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB /= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                            UpdateReferenceObject(item, objBatchProductProductionNormItemsInfo);

                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks = Math.Round(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA = Math.Round(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB = Math.Round(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END

                            if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemParentID > 0)
                            {
                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlockPerOne = ((objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductLength
                                                                 * objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductWidth
                                                                 * objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductHeight) / 1000000000);
                                List<MMBatchProductProductionNormItemsInfo> parentList = objBatchProductProductionNormItemsController.GetItemByPNIParentIDAndBPItemID(objProductionNormItemsInfo.MMProductionNormItemParentID, objBatchProductItemsInfo.MMBatchProductItemID);
                                if (parentList != null)
                                {
                                    MMBatchProductProductionNormItemsInfo parent = parentList.FirstOrDefault();
                                    if (parent != null)
                                    {
                                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemParentID = parent.MMBatchProductProductionNormItemID;
                                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemParentNo = parent.MMBatchProductProductionNormItemNo;
                                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemResourceType = parent.MMBatchProductProductionNormItemResourceType;
                                        parent.MMBatchProductProductionNormItemBlockPerOne -= backupBlockPerOne;
                                        parent.MMBatchProductProductionNormItemBlockPerOne += (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlockPerOne *
                                                                                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity / objBatchProductItemsInfo.MMBatchProductItemProductQty);
                                        parent.MMBatchProductProductionNormItemBlocks -= backupBlock;
                                        parent.MMBatchProductProductionNormItemBlocks += objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks;
                                        parent.MMBatchProductProductionNormItemBlockPerOne = Math.Round(parent.MMBatchProductProductionNormItemBlockPerOne, 4, MidpointRounding.AwayFromZero);
                                        parent.MMBatchProductProductionNormItemBlocks = Math.Round(parent.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
                                        objBatchProductProductionNormItemsController.UpdateObject(parent);
                                    }
                                }

                            }
                            else
                            {
                                decimal blockPerOne = ((objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductLength
                                                                 * objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductWidth
                                                                 * objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductHeight) / 1000000000);
                                if (blockPerOne > 0)
                                {
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlockPerOne = blockPerOne;
                                }
                            }
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Modified.ToString();
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlockPerOne = objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlockPerOne;
                            objBatchProductProductionNormItemsController.UpdateObject(objBatchProductProductionNormItemsInfo);
                            #endregion
                        }
                        else if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.Hardware.ToString())
                        {

                            #region Hardware
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAssembleQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAllocationQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;


                            UpdateReferenceObject(item, objBatchProductProductionNormItemsInfo);

                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAssembleQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAllocationQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Modified.ToString();
                            objBatchProductProductionNormItemsController.UpdateObject(objBatchProductProductionNormItemsInfo);
                            #endregion

                        }
                        else if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.IngredientPaint.ToString())
                        {
                            #region Paint
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                            UpdateReferenceObject(item, objBatchProductProductionNormItemsInfo);
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity = Math.Round(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity = Math.Round(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Modified.ToString();
                            objBatchProductProductionNormItemsController.UpdateObject(objBatchProductProductionNormItemsInfo);
                            #endregion
                        }
                        else if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.IngredientPackaging.ToString())
                        {
                            #region Packaging
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            UpdateReferenceObject(item, objBatchProductProductionNormItemsInfo);
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc = string.Empty;
                            if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductName))
                            {
                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductName.Trim();
                            }
                            if (!(objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth == 0
                                && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength == 0
                                && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength.ToString().Trim() + "x"
                                + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim() + "x"
                                + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
                            }
                            if (!(objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth == 0
                                && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength == 0
                                && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength.ToString().Trim() + "x"
                                    + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim() + "x"
                                    + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
                            }
                            if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking))
                            {
                                if (!string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking.Trim();
                            }
                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                    {
                                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                    }
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                    {
                                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                    }
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID > 0)
                            {

                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                    {
                                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                    }
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemComment))
                            {
                                if (!string.IsNullOrEmpty(objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemComment.Trim();
                            }

                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Modified.ToString();
                            objBatchProductProductionNormItemsController.UpdateObject(objBatchProductProductionNormItemsInfo);
                            #endregion
                        }
                    }
                }
            }
        }
        #endregion

        #region Delete
        public void DeleteBatchProductProductionNormItem(MMProductionNormItemsInfo objProductionNormItemsInfo, MMBatchProductItemsInfo objBatchProductItemsInfo, MMChangeBOMInformationItemsInfo item)
        {
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> objBatchProductProductionNormItemsInfoList = objBatchProductProductionNormItemsController.GetItemByBPItemIDAndProductionNormItemID(objBatchProductItemsInfo.MMBatchProductItemID, objProductionNormItemsInfo.MMProductionNormItemID);
            if (objBatchProductProductionNormItemsInfoList != null && objBatchProductProductionNormItemsInfoList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo in objBatchProductProductionNormItemsInfoList)
                {
                    if (objBatchProductProductionNormItemsInfo != null)
                    {
                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();
                        objBatchProductProductionNormItemsController.UpdateObject(objBatchProductProductionNormItemsInfo);

                        List<MMBatchProductProductionNormItemsInfo> parentList = objBatchProductProductionNormItemsController.GetItemByPNIParentIDAndBPItemID(objProductionNormItemsInfo.MMProductionNormItemParentID, objBatchProductItemsInfo.MMBatchProductItemID);
                        if (parentList != null)
                        {
                            MMBatchProductProductionNormItemsInfo parent = parentList.FirstOrDefault();
                            if (parent != null)
                            {

                                parent.MMBatchProductProductionNormItemBlockPerOne -= (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlockPerOne *
                                                                                        objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity / objBatchProductItemsInfo.MMBatchProductItemProductQty);
                                parent.MMBatchProductProductionNormItemBlocks -= objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks;
                                parent.MMBatchProductProductionNormItemBlockPerOne = parent.MMBatchProductProductionNormItemBlockPerOne;
                                parent.MMBatchProductProductionNormItemBlocks = Math.Round(parent.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
                                objBatchProductProductionNormItemsController.UpdateObject(parent);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        public void CreateBatchProductItemAndDependent(List<MMChangeBOMInformationItemsInfo> changeBOMInformationItemList)
        {
            if (changeBOMInformationItemList.Count() == 0)
                return;
            MMChangeBOMInformationsInfo mainobject = (MMChangeBOMInformationsInfo)CurrentModuleEntity.MainObject;

            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();

            List<MMProductionNormItemsInfo> productionNormItemParentList = new List<MMProductionNormItemsInfo>();
            List<MMProductionNormItemsInfo> productionNormItemChildList = new List<MMProductionNormItemsInfo>();
            changeBOMInformationItemList.ForEach(o =>
            {
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(o.FK_MMProductionNormItemID);
                if (objProductionNormItemsInfo == null)
                    return;
                if (objProductionNormItemsInfo.MMProductionNormItemParentID == 0)
                    productionNormItemParentList.Add(objProductionNormItemsInfo);
                else
                    productionNormItemChildList.Add(objProductionNormItemsInfo);
            });
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            objBatchProductProductionNormItemsController.InsertBPProductionNormItemRootNode(mainobject.FK_MMBatchProductID
                                                                                            , string.Join(",", productionNormItemParentList.Select(o => o.MMProductionNormItemID.ToString()).ToArray())
                                                                                            , BOSApp.CurrentUser);

            objBatchProductProductionNormItemsController.InsertBPProductionNormItemChildNode(mainobject.FK_MMBatchProductID
                                                                                             , string.Join(",", productionNormItemChildList.Select(o => o.MMProductionNormItemID.ToString()).ToArray())
                                                                                             , BOSApp.CurrentUser);
        }

        public void UpdateBatchProductItemAndDependent(List<MMChangeBOMInformationItemsInfo> changeBOMInformationItemList)
        {
            if (changeBOMInformationItemList.Count() == 0)
                return;
            List<string> productionNormItemRef = changeBOMInformationItemList.Select(o => o.FK_MMBatchProductProductionNormItemID.ToString()).Distinct().ToList();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            objBatchProductProductionNormItemsController.UpdateBatchProductProductionNormItemFromProductionNormItemRef(string.Join(",", productionNormItemRef.ToArray()), BOSApp.CurrentUser);
        }

        public void DeleteBatchProductItemAndDependent(List<MMChangeBOMInformationItemsInfo> changeBOMInformationItemList)
        {
            if (changeBOMInformationItemList.Count() == 0)
                return;
            List<string> productionNormItemRef = changeBOMInformationItemList.Select(o => o.FK_MMBatchProductProductionNormItemID.ToString()).Distinct().ToList();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            objBatchProductProductionNormItemsController.DeleteBatchProductProductionNormItemFromProductionNormItemRef(string.Join(",", productionNormItemRef.ToArray()), BOSApp.CurrentUser);
        }

        public void ApproveChange()
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;
            entity.InvalidateBatchProductItemList(objChangeBOMInformationsInfo.FK_MMBatchProductID);
            SetDefaultBPProductionNormItemModifiedStatus(string.Empty, entity);
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> batchProductItemList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(objChangeBOMInformationsInfo.FK_MMBatchProductID);
            List<MMBatchProductItemsInfo> foundBatchProductItemList = null;
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> ProductionNormItemList = new List<MMProductionNormItemsInfo>();
            if (objChangeBOMInformationsInfo.MMChangeBOMInformationStatus != ChangeBOMInformationStatus.Validated.ToString())
                return;
            if (!ValidateChangeBoomInfomation())
            {
                ActionCancel();
                return;
            }

            List<int> batchProductIDList = new List<int>();
            List<MMChangeBOMInformationItemsInfo> finalList = new List<MMChangeBOMInformationItemsInfo>();
            List<MMChangeBOMInformationItemsInfo> finalListParent = new List<MMChangeBOMInformationItemsInfo>();
            List<MMChangeBOMInformationItemsInfo> newList = entity.ChangeBOMInformationItemList.Where(t => t.MMChangeBOMInformationItemActionType == ProductionNormLocalizeResources.New).ToList();
            List<MMChangeBOMInformationItemsInfo> updateList = entity.ChangeBOMInformationItemList.Where(t => t.MMChangeBOMInformationItemActionType == ProductionNormLocalizeResources.Change).ToList();
            List<MMChangeBOMInformationItemsInfo> deleteList = entity.ChangeBOMInformationItemList.Where(t => t.MMChangeBOMInformationItemActionType == ProductionNormLocalizeResources.Delete).ToList();
            List<int> BatchProductItemIDList = new List<int>();

            DeleteBatchProductItemAndDependent(deleteList);
            CreateBatchProductItemAndDependent(newList);
            UpdateBatchProductItemAndDependent(updateList);

            objChangeBOMInformationsInfo.MMChangeBOMInformationStatus = ChangeBOMInformationStatus.Approved.ToString();
            objChangeBOMInformationsInfo.FK_HREmployeeIDApproved = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objChangeBOMInformationsInfo.MMChangeBOMInformationApprovedDate = BOSApp.GetCurrentServerDate();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public void UpdateBlockPerOneByBatchProduct(int batchProductID)
        {
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();

            List<MMBatchProductProductionNormItemsInfo> productList = objBPPNIsController.GetProductByBatchProductID(batchProductID);
            foreach (MMBatchProductProductionNormItemsInfo product in productList)
            {
                product.MMBatchProductProductionNormItemBlockPerOne = 0;
                List<MMBatchProductProductionNormItemsInfo> groupList = objBPPNIsController.GetSemiProductByBatchProductItemIDAndBatchProductID(product.FK_MMBatchProductItemID, product.FK_MMBatchProductID);
                foreach (MMBatchProductProductionNormItemsInfo group in groupList)
                {
                    group.MMBatchProductProductionNormItemBlockPerOne = 0;
                    List<MMBatchProductProductionNormItemsInfo> itemList = objBPPNIsController.GetSemiProductByProductID(group.MMBatchProductProductionNormItemID);
                    if (itemList != null && itemList.Count > 0)
                    {
                        foreach (MMBatchProductProductionNormItemsInfo item in itemList)
                        {
                            item.MMBatchProductProductionNormItemBlockPerOne = ((item.MMBatchProductProductionNormItemProductLength
                                                                                     * item.MMBatchProductProductionNormItemProductWidth
                                                                                     * item.MMBatchProductProductionNormItemProductHeight) / 1000000000);
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                            item.MMBatchProductProductionNormItemBlockPerOne = item.MMBatchProductProductionNormItemBlockPerOne;
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                            objBPPNIsController.UpdateObject(item);
                            group.MMBatchProductProductionNormItemBlockPerOne += item.MMBatchProductProductionNormItemBlockPerOne;
                        }
                    }
                    else
                    {
                        group.MMBatchProductProductionNormItemBlockPerOne = ((group.MMBatchProductProductionNormItemProductLength
                                                                                     * group.MMBatchProductProductionNormItemProductWidth
                                                                                     * group.MMBatchProductProductionNormItemProductHeight) / 1000000000);

                    }
                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                    group.MMBatchProductProductionNormItemBlockPerOne = group.MMBatchProductProductionNormItemBlockPerOne;
                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                    objBPPNIsController.UpdateObject(group);
                    product.MMBatchProductProductionNormItemBlockPerOne += group.MMBatchProductProductionNormItemBlockPerOne;
                }
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                product.MMBatchProductProductionNormItemBlockPerOne = product.MMBatchProductProductionNormItemBlockPerOne;
                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                objBPPNIsController.UpdateObject(product);
            }

        }

        public void SetDefaultBPProductionNormItemBatchProductID(int batchProductID, ChangeBOMInformationEntities entity)
        {
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                item.FK_MMBatchProductID = batchProductID;

            }
            foreach (MMBatchProductProductionNormItemsInfo item in entity.ProductionNormItemHardwareList)
            {
                item.FK_MMBatchProductID = batchProductID;
            }
            foreach (MMBatchProductProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
            {
                item.FK_MMBatchProductID = batchProductID;
            }
            foreach (MMBatchProductProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
            {
                item.FK_MMBatchProductID = batchProductID;
            }
        }

        public void SetDefaultBPProductionNormItemModifiedStatus(string status, ChangeBOMInformationEntities entity)
        {
            foreach (MMBatchProductProductionNormItemsInfo item in entity.BatchProductProductionNormItemList)
            {
                if (item.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                {
                    item.MMBatchProductProductionNormItemModifiedStatus = status;
                }
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo subItem in item.SubList)
                    {
                        if (subItem.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                        {
                            subItem.MMBatchProductProductionNormItemModifiedStatus = status;
                        }
                    }
                }
            }

            foreach (MMBatchProductProductionNormItemsInfo item in entity.ProductionNormItemHardwareList)
            {
                if (item.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                {
                    item.MMBatchProductProductionNormItemModifiedStatus = status;
                }
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo subItem in item.SubList)
                    {
                        if (subItem.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                        {
                            subItem.MMBatchProductProductionNormItemModifiedStatus = status;
                        }
                    }
                }
            }

            foreach (MMBatchProductProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
            {
                if (item.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                {
                    item.MMBatchProductProductionNormItemModifiedStatus = status;
                }
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo subItem in item.SubList)
                    {
                        if (subItem.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                        {
                            subItem.MMBatchProductProductionNormItemModifiedStatus = status;
                        }
                    }
                }
            }

            foreach (MMBatchProductProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
            {
                if (item.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                {
                    item.MMBatchProductProductionNormItemModifiedStatus = status;
                }
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMBatchProductProductionNormItemsInfo subItem in item.SubList)
                    {
                        if (subItem.MMBatchProductProductionNormItemModifiedStatus != ModifiedStatus.Delete.ToString())
                        {
                            subItem.MMBatchProductProductionNormItemModifiedStatus = status;
                        }
                    }
                }
            }
        }

        public void SaveBPProductionNormItem(ChangeBOMInformationEntities entity)
        {
            entity.ProductionNormItemHardwareList.SaveItemObjects();
            entity.ProductionNormItemPackagingList.SaveItemObjects();
            entity.ProductionNormItemPaintList.SaveItemObjects();
            entity.BatchProductProductionNormItemList.SaveItemObjects();
        }

        public void UpdateDeleteReferenceBPProductionNormItem(MMChangeBOMInformationItemsInfo item, ChangeBOMInformationEntities entity)
        {
            MMBatchProductProductionNormItemsController objProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(item.FK_MMBatchProductProductionNormItemID);
            if (objProductionNormItemsInfo != null)
            {
                if (objProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.SemiProduct.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo pnItem in entity.BatchProductProductionNormItemList)
                    {
                        bool isMatch = false;
                        if (pnItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.FK_MMProductionNormItemID)
                        {
                            pnItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();
                            isMatch = true;

                        }
                        if (pnItem.SubList != null && pnItem.SubList.Count > 0)
                        {
                            if (isMatch)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo subItem in pnItem.SubList)
                                {
                                    subItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();
                                }
                            }
                            else
                            {
                                foreach (MMBatchProductProductionNormItemsInfo subItem in pnItem.SubList)
                                {
                                    if (subItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.FK_MMProductionNormItemID)
                                    {
                                        subItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                else if (objProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.Hardware.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo pnItem in entity.ProductionNormItemHardwareList)
                    {

                        if (pnItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.FK_MMProductionNormItemID)
                        {
                            pnItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();

                            break;
                        }

                    }
                }
                else if (objProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.IngredientPackaging.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo pnItem in entity.ProductionNormItemPackagingList)
                    {
                        bool isMatch = false;
                        if (pnItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.FK_MMProductionNormItemID)
                        {
                            pnItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();
                            isMatch = true;

                        }
                        if (pnItem.SubList != null && pnItem.SubList.Count > 0)
                        {
                            if (isMatch)
                            {
                                foreach (MMBatchProductProductionNormItemsInfo subItem in pnItem.SubList)
                                {
                                    subItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();
                                }
                            }
                            else
                            {
                                foreach (MMBatchProductProductionNormItemsInfo subItem in pnItem.SubList)
                                {
                                    if (subItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.FK_MMProductionNormItemID)
                                    {
                                        subItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                else if (objProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.IngredientPaint.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo pnItem in entity.ProductionNormItemPaintList)
                    {

                        if (pnItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.FK_MMProductionNormItemID)
                        {
                            pnItem.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Delete.ToString();

                            break;
                        }

                    }
                }
            }
        }

        //public void UpdateNewReferenceBPProductionNormItem(MMChangeBOMInformationItemsInfo item, ChangeBOMInformationEntities entity, MMBatchProductItemsInfo objBatchProductItemsInfo)
        //{
        //    MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
        //    MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(item.FK_MMProductionNormItemID);
        //    ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
        //    if (objProductionNormItemsInfo != null)
        //    {
        //        ICProductsController objProductsController = new ICProductsController();
        //        ICProductsInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(t=>t.ICProductID == objProductionNormItemsInfo.FK_ICProductID);
        //        if (objProductsInfo != null)
        //        {
        //            #region gỗ
        //            if (objProductionNormItemsInfo.MMProductionNormItemGroup == ProductType.SemiProduct.ToString())
        //            {
        //                if (!objProductsInfo.HasComponent) // chi tiết
        //                {
        //                    #region Chi tiết có cụm
        //                    bool isExistParent = false;
        //                    foreach (MMBatchProductProductionNormItemsInfo pmItem in entity.BatchProductProductionNormItemList)
        //                    {
        //                        if (pmItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.MMProductionNormItemParentID)
        //                        {
        //                            if (pmItem.SubList == null)
        //                            {
        //                                pmItem.SubList = new BOSTreeList();
        //                            }
        //                            bool isExist = false;
        //                            foreach (MMBatchProductProductionNormItemsInfo subItem in pmItem.SubList)
        //                            {
        //                                if (subItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.MMProductionNormItemID)
        //                                {
        //                                    isExist = true;
        //                                    break;
        //                                }
        //                            }
        //                            if (!isExist)
        //                            {
        //                                MMBatchProductProductionNormItemsInfo subIObj = new MMBatchProductProductionNormItemsInfo();
        //                                BOSUtil.CopyObject(objProductionNormItemsInfo, subIObj);
        //                                subIObj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                                subIObj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                                subIObj.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                                subIObj.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                                subIObj.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;

        //                                subIObj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                                subIObj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                                subIObj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                                subIObj.MMBatchProductProductionNormItemResourceType = pmItem.MMBatchProductProductionNormItemResourceType;
        //                                subIObj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                                subIObj.MMBatchProductProductionNormItemBlockPerOne = ((subIObj.MMBatchProductProductionNormItemProductLength
        //                                                                             * subIObj.MMBatchProductProductionNormItemProductWidth
        //                                                                             * subIObj.MMBatchProductProductionNormItemProductHeight) / 1000000000);
        //                                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
        //                                subIObj.MMBatchProductProductionNormItemBlocks = Math.Round(subIObj.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
        //                                subIObj.MMBatchProductProductionNormItemPaintA = Math.Round(subIObj.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
        //                                subIObj.MMBatchProductProductionNormItemPaintB = Math.Round(subIObj.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
        //                                subIObj.MMBatchProductProductionNormItemBlockPerOne = Math.Round(subIObj.MMBatchProductProductionNormItemBlockPerOne, 4, MidpointRounding.AwayFromZero);
        //                                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
        //                                pmItem.SubList.Add(subIObj);
        //                            }
        //                            isExistParent = true;
        //                            break;

        //                        }
        //                    }
        //                    #endregion
        //                    #region Chi tiết ko cụm
        //                    if (!isExistParent)
        //                    {
        //                        MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
        //                        BOSUtil.CopyObject(objProductionNormItemsInfo, obj);
        //                        obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                        obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                        obj.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                        obj.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                        obj.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                        obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
        //                        obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                        obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                        obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                        obj.MMBatchProductProductionNormItemResourceType = BatchProductProductionNormItemResourceType.Manafacturing.ToString();
        //                        obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                        obj.MMBatchProductProductionNormItemBlockPerOne = ((obj.MMBatchProductProductionNormItemProductLength
        //                                                                          * obj.MMBatchProductProductionNormItemProductWidth
        //                                                                          * obj.MMBatchProductProductionNormItemProductHeight) / 1000000000);
        //                        //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
        //                        obj.MMBatchProductProductionNormItemBlocks = Math.Round(obj.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
        //                        obj.MMBatchProductProductionNormItemPaintA = Math.Round(obj.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
        //                        obj.MMBatchProductProductionNormItemPaintB = Math.Round(obj.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
        //                        obj.MMBatchProductProductionNormItemBlockPerOne = Math.Round(obj.MMBatchProductProductionNormItemBlockPerOne, 4, MidpointRounding.AwayFromZero);
        //                        //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
        //                        entity.BatchProductProductionNormItemList.Add(obj);
        //                    }
        //                    #endregion
        //                }
        //                else // cụm
        //                {
        //                    #region tạo cụm và chi tiết con
        //                    MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
        //                    BOSUtil.CopyObject(objProductionNormItemsInfo, obj);
        //                    obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                    obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                    obj.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                    obj.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                    obj.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                    obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
        //                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
        //                    obj.MMBatchProductProductionNormItemBlocks = Math.Round(obj.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
        //                    obj.MMBatchProductProductionNormItemPaintA = Math.Round(obj.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
        //                    obj.MMBatchProductProductionNormItemPaintB = Math.Round(obj.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);

        //                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
        //                    obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                    obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                    obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                    obj.MMBatchProductProductionNormItemResourceType = BatchProductProductionNormItemResourceType.Manafacturing.ToString();
        //                    obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                    if (obj.SubList == null)
        //                    {
        //                        obj.SubList = new BOSTreeList();
        //                    }
        //                    MMProductionNormItemsController objPNItemsController = new MMProductionNormItemsController();
        //                    List<MMProductionNormItemsInfo> objProductionNormItemsList = objPNItemsController.GetProductionNormItemsByProductionNormItemParentID(objProductionNormItemsInfo.MMProductionNormItemID);
        //                    if (objProductionNormItemsList != null && objProductionNormItemsList.Count > 0)
        //                    {
        //                        foreach (MMProductionNormItemsInfo pnItem in objProductionNormItemsList)
        //                        {
        //                            MMBatchProductProductionNormItemsInfo subIObj = new MMBatchProductProductionNormItemsInfo();
        //                            BOSUtil.CopyObject(pnItem, subIObj);
        //                            subIObj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            subIObj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            subIObj.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            obj.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            obj.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            subIObj.FK_MMProductionNormItemID = pnItem.MMProductionNormItemID;
        //                            subIObj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                            subIObj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                            subIObj.MMBatchProductProductionNormItemResourceType = obj.MMBatchProductProductionNormItemResourceType;
        //                            subIObj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                            subIObj.MMBatchProductProductionNormItemBlockPerOne = ((subIObj.MMBatchProductProductionNormItemProductLength
        //                                                                        * subIObj.MMBatchProductProductionNormItemProductWidth
        //                                                                        * subIObj.MMBatchProductProductionNormItemProductHeight) / 1000000000);
        //                            obj.SubList.Add(subIObj);
        //                            obj.MMBatchProductProductionNormItemBlockPerOne += subIObj.MMBatchProductProductionNormItemBlockPerOne;
        //                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
        //                            subIObj.MMBatchProductProductionNormItemBlocks = Math.Round(subIObj.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
        //                            subIObj.MMBatchProductProductionNormItemPaintA = Math.Round(subIObj.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
        //                            subIObj.MMBatchProductProductionNormItemPaintB = Math.Round(subIObj.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
        //                            subIObj.MMBatchProductProductionNormItemBlockPerOne = Math.Round(subIObj.MMBatchProductProductionNormItemBlockPerOne, 4, MidpointRounding.AwayFromZero);
        //                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
        //                        }
        //                    }
        //                    else
        //                    {
        //                        obj.MMBatchProductProductionNormItemBlockPerOne = ((obj.MMBatchProductProductionNormItemProductLength
        //                                                                     * obj.MMBatchProductProductionNormItemProductWidth
        //                                                                     * obj.MMBatchProductProductionNormItemProductHeight) / 1000000000);
        //                    }
        //                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START

        //                    obj.MMBatchProductProductionNormItemBlockPerOne = Math.Round(obj.MMBatchProductProductionNormItemBlockPerOne, 4, MidpointRounding.AwayFromZero);
        //                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
        //                    entity.BatchProductProductionNormItemList.Add(obj);
        //                    #endregion
        //                }
        //            }
        //            #endregion

        //            #region hardware
        //            else if (objProductionNormItemsInfo.MMProductionNormItemGroup == ProductType.Hardware.ToString())
        //            {

        //                MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
        //                BOSUtil.CopyObject(objProductionNormItemsInfo, obj);
        //                obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                obj.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                obj.MMBatchProductProductionNormItemHardwareAssembleQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                obj.MMBatchProductProductionNormItemHardwareAllocationQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
        //                obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                if (obj.SubList == null)
        //                    obj.SubList = new BOSTreeList();
        //                entity.ProductionNormItemHardwareList.Add(obj);

        //            }
        //            #endregion

        //            #region PLDG
        //            else if (objProductionNormItemsInfo.MMProductionNormItemGroup == ProductType.IngredientPackaging.ToString())
        //            {
        //                if (objProductionNormItemsInfo.MMProductionNormItemParentID > 0) // Chi tiết
        //                {
        //                    bool isExistParent = false;

        //                    #region chi tiết có cụm
        //                    foreach (MMBatchProductProductionNormItemsInfo pmItem in entity.ProductionNormItemPackagingList)
        //                    {
        //                        if (pmItem.FK_MMProductionNormItemID == objProductionNormItemsInfo.MMProductionNormItemParentID)
        //                        {
        //                            if (pmItem.SubList == null)
        //                            {
        //                                pmItem.SubList = new BOSTreeList();
        //                            }
        //                            MMBatchProductProductionNormItemsInfo subIObj = new MMBatchProductProductionNormItemsInfo();
        //                            BOSUtil.CopyObject(objProductionNormItemsInfo, subIObj);

        //                            subIObj.MMBatchProductProductionNormItemProductDesc = string.Empty;
        //                            if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductName))
        //                            {
        //                                subIObj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductName.Trim();
        //                            }
        //                            if (!(objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth == 0
        //                                && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength == 0
        //                                && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight == 0))
        //                            {
        //                                if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc +=
        //                                    objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength.ToString().Trim()
        //                                    + "x" + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim()
        //                                    + "x" + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
        //                            }
        //                            if (!(objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth == 0
        //                                && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength == 0
        //                                && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight == 0))
        //                            {
        //                                if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc +=
        //                                    objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength.ToString().Trim()
        //                                    + "x" + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim()
        //                                    + "x" + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
        //                            }
        //                            if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking))
        //                            {
        //                                if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking.Trim();
        //                            }
        //                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
        //                            {
        //                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID);
        //                                if (objAttribute != null)
        //                                {
        //                                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                    {
        //                                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                    }
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                                }
        //                            }
        //                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
        //                            {
        //                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID);
        //                                if (objAttribute != null)
        //                                {
        //                                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                    {
        //                                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                    }
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                                }
        //                            }
        //                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID > 0)
        //                            {

        //                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID);
        //                                if (objAttribute != null)
        //                                {
        //                                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                    {
        //                                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                    }
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                                }
        //                            }
        //                            if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemComment))
        //                            {
        //                                if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemComment.Trim();
        //                            }


        //                            subIObj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            subIObj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            subIObj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                            subIObj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                            subIObj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                            subIObj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                            pmItem.SubList.Add(subIObj);

        //                            isExistParent = true;
        //                            break;
        //                        }
        //                    }
        //                    #endregion

        //                    #region chi tiết ko cụm
        //                    if (!isExistParent)
        //                    {
        //                        MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
        //                        BOSUtil.CopyObject(objProductionNormItemsInfo, obj);
        //                        if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductName))
        //                        {

        //                            obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductName.Trim();
        //                        }
        //                        if (!(objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth == 0
        //                            && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength == 0
        //                            && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight == 0))
        //                        {
        //                            if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                            {
        //                                obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                            }
        //                            obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength.ToString().Trim() + "x"
        //                            + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim() + "x"
        //                            + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
        //                        }
        //                        if (!(objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth == 0
        //                            && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength == 0
        //                            && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight == 0))
        //                        {
        //                            if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                            {
        //                                obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                            }
        //                            obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength.ToString().Trim() + "x"
        //                                + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim() + "x"
        //                                + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
        //                        }
        //                        if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking))
        //                        {
        //                            if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                            {
        //                                obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                            }
        //                            obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking.Trim();
        //                        }
        //                        if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
        //                        {
        //                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID);
        //                            if (objAttribute != null)
        //                            {
        //                                if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                            }
        //                        }
        //                        if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
        //                        {
        //                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID);
        //                            if (objAttribute != null)
        //                            {
        //                                if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                            }
        //                        }
        //                        if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID > 0)
        //                        {

        //                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID);
        //                            if (objAttribute != null)
        //                            {
        //                                if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                            }
        //                        }
        //                        if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemComment))
        //                        {
        //                            if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                            {
        //                                obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                            }
        //                            obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemComment.Trim();
        //                        }

        //                        obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                        obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                        obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
        //                        obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                        obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                        obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                        obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                        if (obj.SubList == null)
        //                            obj.SubList = new BOSTreeList();
        //                        entity.ProductionNormItemPackagingList.Add(obj);
        //                    }
        //                    #endregion
        //                }
        //                else // cụm
        //                {
        //                    #region cụm và chi tiết con
        //                    MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
        //                    BOSUtil.CopyObject(objProductionNormItemsInfo, obj);
        //                    obj.MMBatchProductProductionNormItemProductDesc = string.Empty;
        //                    if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductName))
        //                    {

        //                        obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductName.Trim();
        //                    }
        //                    if (!(objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth == 0
        //                        && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength == 0
        //                        && objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight == 0))
        //                    {
        //                        if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                        {
        //                            obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                        }
        //                        obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionLength.ToString().Trim() + "x"
        //                        + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim() + "x"
        //                        + objProductionNormItemsInfo.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
        //                    }
        //                    if (!(objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth == 0
        //                        && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength == 0
        //                        && objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight == 0))
        //                    {
        //                        if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                        {
        //                            obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                        }
        //                        obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionLength.ToString().Trim() + "x"
        //                            + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim() + "x"
        //                            + objProductionNormItemsInfo.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
        //                    }
        //                    if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking))
        //                    {
        //                        if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                        {
        //                            obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                        }
        //                        obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking.Trim();
        //                    }
        //                    if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
        //                    {
        //                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID);
        //                        if (objAttribute != null)
        //                        {
        //                            if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                            {
        //                                obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                            }
        //                            obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                        }
        //                    }
        //                    if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
        //                    {
        //                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID);
        //                        if (objAttribute != null)
        //                        {
        //                            if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                            {
        //                                obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                            }
        //                            obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                        }
        //                    }
        //                    if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID > 0)
        //                    {

        //                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSizeID);
        //                        if (objAttribute != null)
        //                        {
        //                            if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                            {
        //                                obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                            }
        //                            obj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                        }
        //                    }
        //                    if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemComment))
        //                    {
        //                        if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                        {
        //                            obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                        }
        //                        obj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemComment.Trim();
        //                    }

        //                    obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                    obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                    obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
        //                    obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                    obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                    obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                    obj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                    if (obj.SubList == null)
        //                        obj.SubList = new BOSTreeList();
        //                    MMProductionNormItemsController objPNItemsController = new MMProductionNormItemsController();
        //                    List<MMProductionNormItemsInfo> objProductionNormItemsList = objPNItemsController.GetProductionNormItemsByProductionNormItemParentID(objProductionNormItemsInfo.MMProductionNormItemID);
        //                    if (objProductionNormItemsList != null && objProductionNormItemsList.Count > 0)
        //                    {
        //                        foreach (MMProductionNormItemsInfo pnItem in objProductionNormItemsList)
        //                        {
        //                            MMBatchProductProductionNormItemsInfo subIObj = new MMBatchProductProductionNormItemsInfo();
        //                            BOSUtil.CopyObject(pnItem, subIObj);

        //                            subIObj.MMBatchProductProductionNormItemProductDesc = string.Empty;
        //                            if (!string.IsNullOrEmpty(pnItem.MMProductionNormItemProductName))
        //                            {

        //                                subIObj.MMBatchProductProductionNormItemProductDesc += pnItem.MMProductionNormItemProductName.Trim();
        //                            }
        //                            if (!(pnItem.MMProductionNormItemProductInsideDimensionWidth == 0
        //                                && pnItem.MMProductionNormItemProductInsideDimensionLength == 0
        //                                && pnItem.MMProductionNormItemProductInsideDimensionHeight == 0))
        //                            {
        //                                if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc += pnItem.MMProductionNormItemProductInsideDimensionLength.ToString().Trim() + "x"
        //                                + pnItem.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim() + "x"
        //                                + pnItem.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
        //                            }
        //                            if (!(pnItem.MMProductionNormItemProductOverallDimensionWidth == 0
        //                                && pnItem.MMProductionNormItemProductOverallDimensionLength == 0
        //                                && pnItem.MMProductionNormItemProductOverallDimensionHeight == 0))
        //                            {
        //                                if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc += pnItem.MMProductionNormItemProductOverallDimensionLength.ToString().Trim() + "x"
        //                                    + pnItem.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim() + "x"
        //                                    + pnItem.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
        //                            }
        //                            if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking))
        //                            {
        //                                if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc += objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking.Trim();
        //                            }
        //                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialSpecialityID > 0)
        //                            {
        //                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(pnItem.FK_ICProdAttPackingMaterialSpecialityID);
        //                                if (objAttribute != null)
        //                                {
        //                                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                    {
        //                                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                    }
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                                }
        //                            }
        //                            if (objProductionNormItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
        //                            {
        //                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(pnItem.FK_ICProdAttPackingMaterialWeightPerVolumeID);
        //                                if (objAttribute != null)
        //                                {
        //                                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                    {
        //                                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                    }
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                                }
        //                            }
        //                            if (pnItem.FK_ICProdAttPackingMaterialSizeID > 0)
        //                            {

        //                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(pnItem.FK_ICProdAttPackingMaterialSizeID);
        //                                if (objAttribute != null)
        //                                {
        //                                    if (!string.IsNullOrEmpty(subIObj.MMBatchProductProductionNormItemProductDesc))
        //                                    {
        //                                        subIObj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                    }
        //                                    subIObj.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
        //                                }
        //                            }
        //                            if (!string.IsNullOrEmpty(pnItem.MMProductionNormItemComment))
        //                            {
        //                                if (!string.IsNullOrEmpty(obj.MMBatchProductProductionNormItemProductDesc))
        //                                {
        //                                    obj.MMBatchProductProductionNormItemProductDesc += ", ";
        //                                }
        //                                subIObj.MMBatchProductProductionNormItemProductDesc += pnItem.MMProductionNormItemComment.Trim();
        //                            }


        //                            subIObj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            subIObj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                            subIObj.FK_MMProductionNormItemID = pnItem.MMProductionNormItemID;
        //                            subIObj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                            subIObj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                            subIObj.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.New.ToString();
        //                            obj.SubList.Add(subIObj);
        //                        }
        //                    }
        //                    entity.ProductionNormItemPackagingList.Add(obj);

        //                    #endregion
        //                }
        //            }
        //            #endregion

        //            #region Sơn
        //            else if (objProductionNormItemsInfo.MMProductionNormItemGroup == ProductType.IngredientPaint.ToString())
        //            {
        //                MMBatchProductProductionNormItemsInfo obj = new MMBatchProductProductionNormItemsInfo();
        //                BOSUtil.CopyObject(objProductionNormItemsInfo, obj);
        //                obj.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                obj.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
        //                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
        //                obj.MMBatchProductProductionNormItemQuantity = Math.Round(obj.MMBatchProductProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
        //                obj.MMBatchProductProductionNormItemTotalQuantity = Math.Round(obj.MMBatchProductProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
        //                //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
        //                obj.MMBatchProductProductionNormItemProductName = objProductionNormItemsInfo.MMProductionNormItemProductName;
        //                obj.MMBatchProductProductionNormItemProductDesc = objProductionNormItemsInfo.MMProductionNormItemProductDesc;
        //                obj.FK_MMProductionNormItemID = objProductionNormItemsInfo.MMProductionNormItemID;
        //                obj.FK_MMBatchProductItemID = objBatchProductItemsInfo.MMBatchProductItemID;
        //                obj.FK_ICProductForBatchID = objBatchProductItemsInfo.FK_ICProductID;
        //                if (obj.SubList == null)
        //                    obj.SubList = new BOSTreeList();
        //                entity.ProductionNormItemPaintList.Add(obj);
        //            }
        //            #endregion
        //        }
        //    }
        //}

        public void UpdateReferenceObject(MMChangeBOMInformationItemsInfo item, MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo)
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                string typeName = dbUtil.GetColumnDataType(TableName.MMBatchProductProductionNormItemsTableName, item.MMChangeBOMInformationItemBPPNItemColumnName);

                if (typeName == "varchar" || typeName == "nvarchar")
                {
                    dbUtil.SetPropertyValue(objProductionNormItemsInfo, item.MMChangeBOMInformationItemBPPNItemColumnName, item.MMChangeBOMInformationItemNewValue);
                }
                else if (typeName == "int")
                {
                    int newValue = 0;
                    if (int.TryParse(item.MMChangeBOMInformationItemNewValue.ToString(), out newValue))
                    {
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, item.MMChangeBOMInformationItemBPPNItemColumnName, newValue);

                    }
                }
                else if (typeName == "bool" || typeName == "bit")
                {
                    if (item.MMChangeBOMInformationItemNewValue == "1" || item.MMChangeBOMInformationItemNewValue == "true")
                    {
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, item.MMChangeBOMInformationItemBPPNItemColumnName, true);
                    }
                    else
                    {
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, item.MMChangeBOMInformationItemBPPNItemColumnName, false);
                    }
                }
                else if (typeName == "decimal" || typeName == "float")
                {
                    decimal newValue = 0;
                    if (decimal.TryParse(item.MMChangeBOMInformationItemNewValue.ToString(), out newValue))
                    {
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, item.MMChangeBOMInformationItemBPPNItemColumnName, newValue);
                    }
                }
                else if (typeName == "datetime")
                {
                    DateTime newValue = new DateTime();
                    if (DateTime.TryParse(item.MMChangeBOMInformationItemNewValue.ToString(), out newValue))
                    {
                        dbUtil.SetPropertyValue(objProductionNormItemsInfo, item.MMChangeBOMInformationItemBPPNItemColumnName, newValue);
                    }
                }

                objProductionNormItemsInfo.MMBatchProductProductionNormItemModifiedStatus = ModifiedStatus.Modified.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        public void UpdateModifiedReferenceBPProductionNormItem(MMChangeBOMInformationItemsInfo item, ChangeBOMInformationEntities entity, MMBatchProductItemsInfo objBatchProductItemsInfo)
        {
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(item.FK_MMBatchProductProductionNormItemID);
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            MMProductionNormItemsInfo objProductionNormItems = (MMProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(item.FK_MMProductionNormItemID);
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            if (objBatchProductProductionNormItemsInfo != null)
            {
                #region Wood
                if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.SemiProduct.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo in entity.BatchProductProductionNormItemList)
                    {
                        if (objProductionNormItemsInfo.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                        {
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB /= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                            UpdateReferenceObject(item, objProductionNormItemsInfo);

                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks = Math.Round(objProductionNormItemsInfo.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA = Math.Round(objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB = Math.Round(objProductionNormItemsInfo.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                            break;
                        }
                        if (objProductionNormItemsInfo.SubList != null && objProductionNormItemsInfo.SubList.Count > 0)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo subItem in objProductionNormItemsInfo.SubList)
                            {
                                if (subItem.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                                {
                                    subItem.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemBlocks /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemPaintA /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemPaintB /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    UpdateReferenceObject(item, subItem);
                                    subItem.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemBlocks *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemPaintA *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemPaintB *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                                    subItem.MMBatchProductProductionNormItemBlocks = Math.Round(subItem.MMBatchProductProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
                                    subItem.MMBatchProductProductionNormItemPaintA = Math.Round(subItem.MMBatchProductProductionNormItemPaintA, 4, MidpointRounding.AwayFromZero);
                                    subItem.MMBatchProductProductionNormItemPaintB = Math.Round(subItem.MMBatchProductProductionNormItemPaintB, 4, MidpointRounding.AwayFromZero);
                                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                                    break;
                                }
                            }
                        }
                    }
                }
                #endregion

                #region Hardware
                if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.Hardware.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo in entity.ProductionNormItemHardwareList)
                    {
                        if (objProductionNormItemsInfo.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                        {

                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAssembleQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAllocationQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;


                            UpdateReferenceObject(item, objProductionNormItemsInfo);

                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAssembleQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemHardwareAllocationQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            break;
                        }
                        if (objProductionNormItemsInfo.SubList != null && objProductionNormItemsInfo.SubList.Count > 0)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo subItem in objProductionNormItemsInfo.SubList)
                            {
                                if (subItem.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                                {
                                    subItem.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemHardwareAssembleQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemHardwareAllocationQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                                    UpdateReferenceObject(item, subItem);
                                    subItem.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemPackagingAllocationTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemHardwareAssembleQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemHardwareAllocationQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    break;
                                }
                            }
                        }
                    }
                }
                #endregion

                #region Packaging
                if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.IngredientPackaging.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo in entity.ProductionNormItemPackagingList)
                    {
                        if (objProductionNormItemsInfo.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                        {
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            UpdateReferenceObject(item, objProductionNormItemsInfo);
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc = string.Empty;
                            if (!string.IsNullOrEmpty(objProductionNormItems.MMProductionNormItemProductName))
                            {
                                objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductName.Trim();
                            }
                            if (!(objProductionNormItems.MMProductionNormItemProductInsideDimensionWidth == 0
                                && objProductionNormItems.MMProductionNormItemProductInsideDimensionLength == 0
                                && objProductionNormItems.MMProductionNormItemProductInsideDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductInsideDimensionLength.ToString().Trim() + "x"
                                + objProductionNormItems.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim() + "x"
                                + objProductionNormItems.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
                            }
                            if (!(objProductionNormItems.MMProductionNormItemProductOverallDimensionWidth == 0
                                && objProductionNormItems.MMProductionNormItemProductOverallDimensionLength == 0
                                && objProductionNormItems.MMProductionNormItemProductOverallDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductOverallDimensionLength.ToString().Trim() + "x"
                                    + objProductionNormItems.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim() + "x"
                                    + objProductionNormItems.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
                            }
                            if (!string.IsNullOrEmpty(objProductionNormItems.MMProductionNormItemProductSizeAndPacking))
                            {
                                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductSizeAndPacking.Trim();
                            }
                            if (objProductionNormItems.FK_ICProdAttPackingMaterialSpecialityID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItems.FK_ICProdAttPackingMaterialSpecialityID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                    {
                                        objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                    }
                                    objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (objProductionNormItems.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItems.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                    {
                                        objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                    }
                                    objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (objProductionNormItems.FK_ICProdAttPackingMaterialSizeID > 0)
                            {

                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItems.FK_ICProdAttPackingMaterialSizeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                    {
                                        objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                    }
                                    objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (!string.IsNullOrEmpty(objProductionNormItems.MMProductionNormItemComment))
                            {
                                if (!string.IsNullOrEmpty(objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc))
                                {
                                    objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                objProductionNormItemsInfo.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemComment.Trim();
                            }

                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            break;
                        }
                        if (objProductionNormItemsInfo.SubList != null && objProductionNormItemsInfo.SubList.Count > 0)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo subItem in objProductionNormItemsInfo.SubList)
                            {
                                if (subItem.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                                {
                                    subItem.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                                    UpdateReferenceObject(item, subItem);
                                    subItem.MMBatchProductProductionNormItemProductDesc = string.Empty;
                                    if (!string.IsNullOrEmpty(objProductionNormItems.MMProductionNormItemProductName))
                                    {
                                        subItem.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductName.Trim();
                                    }
                                    if (!(objProductionNormItems.MMProductionNormItemProductInsideDimensionWidth == 0
                                        && objProductionNormItems.MMProductionNormItemProductInsideDimensionLength == 0
                                        && objProductionNormItems.MMProductionNormItemProductInsideDimensionHeight == 0))
                                    {
                                        if (!string.IsNullOrEmpty(subItem.MMBatchProductProductionNormItemProductDesc))
                                        {
                                            subItem.MMBatchProductProductionNormItemProductDesc += ", ";
                                        }
                                        subItem.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductInsideDimensionLength.ToString().Trim() + "x"
                                        + objProductionNormItems.MMProductionNormItemProductInsideDimensionWidth.ToString().Trim() + "x"
                                        + objProductionNormItems.MMProductionNormItemProductInsideDimensionHeight.ToString().Trim();
                                    }
                                    if (!(objProductionNormItems.MMProductionNormItemProductOverallDimensionWidth == 0
                                        && objProductionNormItems.MMProductionNormItemProductOverallDimensionLength == 0
                                        && objProductionNormItems.MMProductionNormItemProductOverallDimensionHeight == 0))
                                    {
                                        if (!string.IsNullOrEmpty(subItem.MMBatchProductProductionNormItemProductDesc))
                                        {
                                            subItem.MMBatchProductProductionNormItemProductDesc += ", ";
                                        }
                                        subItem.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductOverallDimensionLength.ToString().Trim() + "x"
                                            + objProductionNormItems.MMProductionNormItemProductOverallDimensionWidth.ToString().Trim() + "x"
                                            + objProductionNormItems.MMProductionNormItemProductOverallDimensionHeight.ToString().Trim();
                                    }
                                    if (!string.IsNullOrEmpty(objProductionNormItems.MMProductionNormItemProductSizeAndPacking))
                                    {
                                        if (!string.IsNullOrEmpty(subItem.MMBatchProductProductionNormItemProductDesc))
                                        {
                                            subItem.MMBatchProductProductionNormItemProductDesc += ", ";
                                        }
                                        subItem.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemProductSizeAndPacking.Trim();
                                    }
                                    if (objProductionNormItems.FK_ICProdAttPackingMaterialSpecialityID > 0)
                                    {
                                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItems.FK_ICProdAttPackingMaterialSpecialityID);
                                        if (objAttribute != null)
                                        {
                                            if (!string.IsNullOrEmpty(subItem.MMBatchProductProductionNormItemProductDesc))
                                            {
                                                subItem.MMBatchProductProductionNormItemProductDesc += ", ";
                                            }
                                            subItem.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                        }
                                    }
                                    if (objProductionNormItems.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                                    {
                                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItems.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                                        if (objAttribute != null)
                                        {
                                            if (!string.IsNullOrEmpty(subItem.MMBatchProductProductionNormItemProductDesc))
                                            {
                                                subItem.MMBatchProductProductionNormItemProductDesc += ", ";
                                            }
                                            subItem.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                        }
                                    }
                                    if (objProductionNormItems.FK_ICProdAttPackingMaterialSizeID > 0)
                                    {

                                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(objProductionNormItems.FK_ICProdAttPackingMaterialSizeID);
                                        if (objAttribute != null)
                                        {
                                            if (!string.IsNullOrEmpty(subItem.MMBatchProductProductionNormItemProductDesc))
                                            {
                                                subItem.MMBatchProductProductionNormItemProductDesc += ", ";
                                            }
                                            subItem.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                        }
                                    }
                                    if (!string.IsNullOrEmpty(objProductionNormItems.MMProductionNormItemComment))
                                    {
                                        if (!string.IsNullOrEmpty(subItem.MMBatchProductProductionNormItemProductDesc))
                                        {
                                            subItem.MMBatchProductProductionNormItemProductDesc += ", ";
                                        }
                                        subItem.MMBatchProductProductionNormItemProductDesc += objProductionNormItems.MMProductionNormItemComment.Trim();
                                    }

                                    subItem.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    break;
                                }
                            }
                        }
                    }
                }
                #endregion

                #region Paint
                if (objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemGroup == ProductType.IngredientPaint.ToString())
                {
                    foreach (MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo in entity.ProductionNormItemPaintList)
                    {
                        if (objProductionNormItemsInfo.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                        {
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                            UpdateReferenceObject(item, objProductionNormItemsInfo);
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity = Math.Round(objProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
                            objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity = Math.Round(objProductionNormItemsInfo.MMBatchProductProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);

                            //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                            break;
                        }
                        if (objProductionNormItemsInfo.SubList != null && objProductionNormItemsInfo.SubList.Count > 0)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo subItem in objProductionNormItemsInfo.SubList)
                            {
                                if (subItem.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID)
                                {
                                    subItem.MMBatchProductProductionNormItemQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity /= objBatchProductItemsInfo.MMBatchProductItemProductQty;

                                    UpdateReferenceObject(item, subItem);
                                    subItem.MMBatchProductProductionNormItemQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    subItem.MMBatchProductProductionNormItemTotalQuantity *= objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                                    subItem.MMBatchProductProductionNormItemQuantity = Math.Round(subItem.MMBatchProductProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
                                    subItem.MMBatchProductProductionNormItemTotalQuantity = Math.Round(subItem.MMBatchProductProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);

                                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],END
                                    break;
                                }
                            }
                        }
                    }
                }
                #endregion
            }
        }

        public void ValidateChange()
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;
            if (objChangeBOMInformationsInfo.MMChangeBOMInformationStatus == ChangeBOMInformationStatus.New.ToString())
            {
                if (!ValidateChangeBoomInfomation())
                {
                    ActionCancel();
                }
                else
                {
                    objChangeBOMInformationsInfo.MMChangeBOMInformationStatus = ChangeBOMInformationStatus.Validated.ToString();
                    objChangeBOMInformationsInfo.FK_HREmployeeIDValidated = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objChangeBOMInformationsInfo.MMChangeBOMInformationValidatedDate = DateTime.Now;
                    entity.UpdateMainObject();
                    ActionCancel();
                }
            }
        }
        #endregion

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo objChangeBOMInformationsInfo = (MMChangeBOMInformationsInfo)entity.MainObject;
            if (objChangeBOMInformationsInfo.MMChangeBOMInformationID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Validate", true);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                if (objChangeBOMInformationsInfo.MMChangeBOMInformationStatus == ChangeBOMInformationStatus.Validated.ToString()

                    || objChangeBOMInformationsInfo.MMChangeBOMInformationStatus == ChangeBOMInformationStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Validate", false);
                }
                if (objChangeBOMInformationsInfo.MMChangeBOMInformationStatus == ChangeBOMInformationStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                }

                if (objChangeBOMInformationsInfo.MMChangeBOMInformationStatus == ChangeBOMInformationStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                }
            }
        }

        public void DeleteItemFromChangeBOMInformationItemList()
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            entity.ChangeBOMInformationItemList.RemoveSelectedRowObjectFromList();

        }
        #endregion

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            MMChangeBOMInformationsController changeBOMInformationController = new MMChangeBOMInformationsController();
            MMChangeBOMInformationsInfo searchObject = (MMChangeBOMInformationsInfo)CurrentModuleEntity.SearchObject;
            //DataSet ds = objBatchProductsController.GetBatchProductDatasetExceptType("Lumber",
            //                                            searchObject.MMBatchProductNo,
            //                                            searchObject.FK_HREmployeeID,
            //                                            searchObject.MMBatchProductStatus,
            //                                            searchObject.FK_ARSaleOrderID,
            //                                            searchObject.FK_ARCustomerID,
            //                                            searchObject.BatchProductDateFrom,
            //                                            searchObject.BatchProductDateTo);

            DataSet ds = changeBOMInformationController.GetChangeBOMInformationsBySomeCriteria(
                                                     searchObject.MMChangeBOMInformationNo,
                                                     searchObject.MMChangeBOMInformationStatus,
                                                     searchObject.FK_ARCustomerID,
                                                     searchObject.FK_MMBatchProductID,
                                                     searchObject.FK_ARSaleOrderID,
                                                     searchObject.FK_HREmployeeID,
                                                     searchObject.MMChangeBOMInformationDateFrom,
                                                     searchObject.MMChangeBOMInformationDateTo);
            return ds;
        }

        public void ResetItemList(int batchProductID)
        {
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo mainobject = (MMChangeBOMInformationsInfo)entity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(batchProductID);
            if (objBatchProductsInfo != null)
            {
                mainobject.FK_ARCustomerID = objBatchProductsInfo.FK_ARCustomerID;
                mainobject.FK_ACObjectID = objBatchProductsInfo.FK_ACObjectID;
                mainobject.MMObjectType = objBatchProductsInfo.MMObjectType;
                mainobject.ACObjectAccessKey = string.Format("{0};{1}", mainobject.FK_ACObjectID, mainobject.MMObjectType);
                mainobject.FK_ARSaleOrderID = objBatchProductsInfo.FK_ARSaleOrderID;
            }
            entity.UpdateMainObjectBindingSource();
            entity.ChangeBOMInformationItemList.Clear();
            entity.ChangeBOMInformationItemList.GridControl?.RefreshDataSource();
        }
        public override int ActionSave()
        {

            if (!ValidateChangeBoomInfomation())
            {
                return 0;
            }
            //if (!ValidateWoodChangBoomInfomation())
            //{
            //    return 0;
            //}
            return base.ActionSave();
        }
        public bool ValidateChangeBoomInfomation()
        {
            bool flag = true;
            int countTrue = 0;
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> ListValidate = new List<MMAllocationPlanItemsInfo>();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            foreach (MMChangeBOMInformationItemsInfo item in entity.ChangeBOMInformationItemList)
            {

                if (item.MMChangeBOMInformationItemActionType == ObjectHistoryAction.Delete.ToString())
                {
                    //Buộc phải hủy các chứng từ có liên quan
                    objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(item.FK_MMBatchProductProductionNormItemID);
                    if (objBatchProductProductionNormItemsInfo != null)
                    {
                        ListValidate.AddRange(objAllocationPlanItemsController.ValidateChangeBoomInfomation(item.FK_MMBatchProductID, objBatchProductProductionNormItemsInfo.FK_MMBatchProductItemID, item.FK_MMBatchProductProductionNormItemID, objBatchProductProductionNormItemsInfo.FK_ICProductID));

                    }
                }
                else if (item.MMChangeBOMInformationItemActionType == ObjectHistoryAction.Change.ToString())
                {
                    //Chỉ bắt thay đổi số lượng
                    if (item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemTotalQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemHardwareAllocationQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemPackagingReservesQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemPackagingAllocationTotalQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemHardwareBuyTotalQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemPackagingBuyTotalQuantity"
                        || item.MMChangeBOMInformationItemPNItemColumnName == "MMProductionNormItemHardwareAssembleQuantity"
                        )
                    {
                        List<MMAllocationPlanItemsInfo> ListTepm = new List<MMAllocationPlanItemsInfo>();
                        decimal soluongKH = 0, soluongHuyKH = 0, Qty = 0, QtyBatchProduct = 0;
                        decimal.TryParse(item.MMChangeBOMInformationItemNewValue, out Qty);
                        //decimal.TryParse(item.MMChangeBOMInformationItemBPProductionNormValues, out QtyBatchProduct);

                        objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(item.FK_MMBatchProductProductionNormItemID);
                        if (objBatchProductProductionNormItemsInfo != null)
                        {
                            ListTepm = objAllocationPlanItemsController.ValidateChangeBoomInfomation(item.FK_MMBatchProductID, objBatchProductProductionNormItemsInfo.FK_MMBatchProductItemID, item.FK_MMBatchProductProductionNormItemID, objBatchProductProductionNormItemsInfo.FK_ICProductID);
                            soluongKH = ListTepm.Sum(x => x.MMAllocationPlanItemQty);
                            soluongHuyKH = ListTepm.Sum(x => x.MMAllocationPlanItemCanceledQty);
                            objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(objBatchProductProductionNormItemsInfo.FK_MMBatchProductItemID);

                        }
                        if (Qty * objBatchProductItemsInfo.MMBatchProductItemProductQty >= (soluongKH - soluongHuyKH))
                        {
                            //Điếm số dòng đúng nếu trong list ChangeBOMInformationItemList đúng hết thì cho lưu
                            countTrue++;
                        }
                        else
                        {
                            ListValidate.AddRange(ListTepm);
                        }

                    }
                    else //Thay đổi những thứ # số lượng buộc hủy các chứng từ có liên quan
                    {

                        objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(item.FK_MMBatchProductProductionNormItemID);
                        if (objBatchProductProductionNormItemsInfo != null)
                        {
                            ListValidate.AddRange(objAllocationPlanItemsController.ValidateChangeBoomInfomation(item.FK_MMBatchProductID, objBatchProductProductionNormItemsInfo.FK_MMBatchProductItemID, item.FK_MMBatchProductProductionNormItemID, objBatchProductProductionNormItemsInfo.FK_ICProductID));

                        }

                    }

                }
                else
                {
                    //Nothing todo
                }
            }
            if (ListValidate != null && ListValidate.Count > 0)
            {
                guiShowError guidError = new guiShowError(ListValidate);
                guidError.Module = this;
                if (guidError.ShowDialog() == DialogResult.OK)
                {
                    flag = false;

                    //MessageBox.Show(mess, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                flag = false;
            }
            if (countTrue == entity.ChangeBOMInformationItemList.Count)
            {
                flag = true;
            }
            return flag;
        }
        public bool ValidateWoodChangBoomInfomation()
        {
            bool flagF = true;
            bool flag = false;
            ChangeBOMInformationEntities entity = (ChangeBOMInformationEntities)CurrentModuleEntity;
            MMChangeBOMInformationsInfo mainobject = (MMChangeBOMInformationsInfo)entity.MainObject;
            MMWoodPlansController objWoodPlansController = new MMWoodPlansController();
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            flag = objWoodPlansController.GetWoodPlanByBatchProduct(mainobject.FK_MMBatchProductID);
            if (!flag)
            {
                foreach (MMChangeBOMInformationItemsInfo item in entity.ChangeBOMInformationItemList)
                {
                    objProductionNormItemsInfo = (MMProductionNormItemsInfo)objProductionNormItemsController.GetObjectByID(item.FK_MMProductionNormItemID);
                    if (objProductionNormItemsInfo != null)
                    {
                        if (objProductionNormItemsInfo.MMProductionNormItemGroup == ProductType.SemiProduct.ToString())
                        {
                            MessageBox.Show("Không thể làm xác nhận thay đổi cho các lệnh sản xuất đã làm hoạch định chi tiết nguyên liệu", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flagF = false;
                            break;
                        }
                    }
                }
            }

            return flagF;
        }
    }
}

using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.TransferPlan
{
    public class TransferPlanEntities : BaseTransactionEntities
    {
        #region Declare Constant

        public const string GoogleApiKey = "AIzaSyBEibktv7Y_NYCCijnajWX1Wj_E_73G9TQ";

        public const string GoogleApiUrl = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key={1}";
        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties

        public BOSList<ARDeliveryPlanItemsInfo> ARDeliveryPlanItemsList { get; set; }

        public BOSList<ARDeliveryPlanTrucksInfo> ARDeliveryPlanTrucksList { get; set; }

        public BOSList<ARDeliveryPlanTruckPointsInfo> DeliveryPlanTruckPointsList { get; set; }

        public List<ARDeliveryPlanTruckItemsInfo> DeliveryPlanTruckItemsList { get; set; }

        #endregion

        #region Constructor
        public TransferPlanEntities()
            : base()
        {
            ARDeliveryPlanItemsList = new BOSList<ARDeliveryPlanItemsInfo>();
            ARDeliveryPlanTrucksList = new BOSList<ARDeliveryPlanTrucksInfo>();
            DeliveryPlanTruckPointsList = new BOSList<ARDeliveryPlanTruckPointsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARDeliveryPlansInfo();
            SearchObject = new ARDeliveryPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARDeliveryPlanItemsTableName, new ARDeliveryPlanItemsInfo());
            ModuleObjects.Add(TableName.ARDeliveryPlanTrucksTableName, new ARDeliveryPlanTrucksInfo());
            ModuleObjects.Add(TableName.ARDeliveryPlanWorksTableName, new ARDeliveryPlanWorksInfo());
            ModuleObjects.Add(TableName.ARDeliveryPlanTruckPointsTableName, new ARDeliveryPlanTruckPointsInfo());
            ModuleObjects.Add(TableName.PMTasksTableName, new PMTasksInfo());
        }

        public override void InitModuleObjectList()
        {
            ARDeliveryPlanItemsList.InitBOSList(this,
                                               TableName.ARDeliveryPlansTableName,
                                               TableName.ARDeliveryPlanItemsTableName,
                                               BOSList<ARDeliveryPlanItemsInfo>.cstRelationForeign);
            ARDeliveryPlanItemsList.ItemTableForeignKey = "FK_ARDeliveryPlanID";

            ARDeliveryPlanTrucksList.InitBOSList(this,
                                               TableName.ARDeliveryPlansTableName,
                                               TableName.ARDeliveryPlanTrucksTableName,
                                               BOSList<ARDeliveryPlanTrucksInfo>.cstRelationForeign);
            ARDeliveryPlanTrucksList.ItemTableForeignKey = "FK_ARDeliveryPlanID";

            DeliveryPlanTruckPointsList.InitBOSList(this,
                                              TableName.ARDeliveryPlansTableName,
                                              TableName.ARDeliveryPlanTruckPointsTableName,
                                              BOSList<ARDeliveryPlanTruckPointsInfo>.cstRelationForeign);
            DeliveryPlanTruckPointsList.ItemTableForeignKey = "FK_ARDeliveryPlanID";
        }

        public override void InitGridControlInBOSList()
        {
            ARDeliveryPlanItemsList.InitBOSListGridControl(TransferPlanModule.ARDeliveryPlanItemsGridControlName);
            ARDeliveryPlanTrucksList.InitBOSListGridControl(TransferPlanModule.ARDeliveryPlanTrucksGridControlName);
            DeliveryPlanTruckPointsList.InitBOSListGridControl(TransferPlanModule.ARDeliveryPlanTruckPointsGridControlName);

        }

        public override void SetDefaultModuleObjectsList()
        {
            ARDeliveryPlanItemsList.SetDefaultListAndRefreshGridControl();
            ARDeliveryPlanTrucksList.SetDefaultListAndRefreshGridControl();
            DeliveryPlanTruckPointsList.SetDefaultListAndRefreshGridControl();
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
            mainObject.ARDeliveryPlanDate = BOSApp.GetCurrentServerDate();
            mainObject.ARDeliveryPlanStatus = DeliveryPlanStatus.New.ToString();
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.ARDeliveryPlanType = DeliveryPlanType.Transfer.ToString();
        }

        #region Invalidate Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {

            ARDeliveryPlanTrucksList.Invalidate(iObjectID);
            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)objDeliveryPlansController.GetObjectByID(iObjectID);
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            ARDeliveryPlanItemsList.Invalidate(objDeliveryPlanItemsController.GetTransferPlanItemByTransferPlanID(iObjectID));
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            DeliveryPlanTruckItemsList = new List<ARDeliveryPlanTruckItemsInfo>();
            DeliveryPlanTruckItemsList = objDeliveryPlanTruckItemsController.GetDeliveryPlanTruckItemsByDeliveryPlanID(iObjectID);

            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
            List<ARDeliveryPlanTruckPointsInfo> deliveryPlanTruckPointsList = objDeliveryPlanTruckPointsController.GetDeliveryPlanTruckPointsByDeliveryPlanID(iObjectID);
            deliveryPlanTruckPointsList.ForEach(o =>
                {
                    ARDeliveryPlanTruckItemsInfo objDeliveryPlanTruckItemsInfo = DeliveryPlanTruckItemsList.FirstOrDefault(y => y.FK_ARDeliveryPlanTruckPointID == o.ARDeliveryPlanTruckPointID);
                    if (objDeliveryPlanTruckItemsInfo != null)
                    {
                        if (objDeliveryPlansInfo.ARDeliveryPlanFromType == DeliveryPlanFromType.SaleReturn.ToString())
                        {
                            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList
                           .FirstOrDefault(x => x.FK_ARSaleReturnItemID == objDeliveryPlanTruckItemsInfo.FK_ARSaleReturnItemID);
                            if (objDeliveryPlanItemsInfo != null)
                            {
                                o.ARDeliveryPlanTruckPointCustomerName = objDeliveryPlanItemsInfo.ACObjectName;
                            }
                        }
                        else
                        {
                            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList
                           .FirstOrDefault(x => x.FK_ICTransferItemID == objDeliveryPlanTruckItemsInfo.FK_ICTransferItemID);
                            if (objDeliveryPlanItemsInfo != null)
                            {
                                o.ARDeliveryPlanTruckPointCustomerName = objDeliveryPlanItemsInfo.ACObjectName;
                            }
                        }
                    }
                });
            DeliveryPlanTruckPointsList.Invalidate(deliveryPlanTruckPointsList);

            ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    if (o.DeliveryPlanTruckItemsList == null)
                        o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                    o.DeliveryPlanTruckItemsList.Invalidate(DeliveryPlanTruckItemsList.Where(x => x.FK_ARDeliveryPlanTruckID == o.ARDeliveryPlanTruckID).ToList());
                    if (o.DeliveryPlanTruckPointsList == null)
                        o.DeliveryPlanTruckPointsList = new BOSList<ARDeliveryPlanTruckPointsInfo>(TableName.ARDeliveryPlanTruckPointsTableName);
                    o.DeliveryPlanTruckPointsList.Invalidate(deliveryPlanTruckPointsList.Where(x => x.FK_ARDeliveryPlanTruckID == o.ARDeliveryPlanTruckID).ToList());
                });
        }

        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
            ARDeliveryPlanItemsList.ForEach(o =>
                {
                    if (o.ARDeliveryPlanItemID == 0)
                        o.FK_ARDeliveryPlanID = 0;
                });
            ARDeliveryPlanItemsList.SaveItemObjects();
            ARDeliveryPlanTrucksList.SaveItemObjects();
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
            ARDeliveryPlanTrucksList.ForEach(o =>
                {
                    if (o.DeliveryPlanTruckPointsList != null && o.DeliveryPlanTruckPointsList.Count > 0)
                    {
                        if (o.DeliveryPlanTruckPointsList.Any(x => x.ARDeliveryPlanTruckPointID == 0))
                            objDeliveryPlanTruckPointsController.DeleteDeliveryPlanTruckPointsByDeliveryPlanTruckID(o.ARDeliveryPlanTruckID);
                        o.DeliveryPlanTruckPointsList.All(p =>
                        {
                            p.FK_ARDeliveryPlanTruckID = o.ARDeliveryPlanTruckID;
                            p.FK_ARDeliveryPlanID = o.FK_ARDeliveryPlanID;

                            return true;
                        });
                        o.DeliveryPlanTruckPointsList.SaveItemObjects();
                    }
                    if (o.DeliveryPlanTruckItemsList != null && o.DeliveryPlanTruckItemsList.Count > 0)
                    {
                        if (o.DeliveryPlanTruckItemsList.Any(x => x.ARDeliveryPlanTruckItemID == 0))
                            objDeliveryPlanTruckItemsController.DeleteDeliveryPlanTruckItemsByDeliveryPlanTruckID(o.ARDeliveryPlanTruckID);
                        o.DeliveryPlanTruckItemsList.All(s =>
                            {
                                if (mainObject.ARDeliveryPlanFromType == DeliveryPlanFromType.SaleReturn.ToString())
                                {
                                    ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList.FirstOrDefault(x => x.FK_ARSaleReturnItemID == s.FK_ARSaleReturnItemID);
                                    s.FK_ARDeliveryPlanID = objDeliveryPlanItemsInfo.FK_ARDeliveryPlanID;
                                    s.FK_ARDeliveryPlanItemID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID;
                                    s.FK_ARDeliveryPlanTruckID = o.ARDeliveryPlanTruckID;
                                    s.FK_ARDeliveryPlanTruckPointID = o.DeliveryPlanTruckPointsList.Where(x => x.ARDeliveryPlanTruckPointAddress == objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress)
                                                                                                    .FirstOrDefault().ARDeliveryPlanTruckPointID;
                                    return true;
                                }
                                else
                                {
                                    ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList.FirstOrDefault(x => x.FK_ICTransferItemID == s.FK_ICTransferItemID);
                                    s.FK_ARDeliveryPlanID = objDeliveryPlanItemsInfo.FK_ARDeliveryPlanID;
                                    s.FK_ARDeliveryPlanItemID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID;
                                    s.FK_ARDeliveryPlanTruckID = o.ARDeliveryPlanTruckID;
                                    s.FK_ARDeliveryPlanTruckPointID = o.DeliveryPlanTruckPointsList.Where(x => x.ARDeliveryPlanTruckPointAddress == objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress)
                                                                                                    .FirstOrDefault().ARDeliveryPlanTruckPointID;
                                    return true;
                                }
                            });
                        o.DeliveryPlanTruckItemsList.SaveItemObjects();
                    }
                });
        }
        #endregion

        public void GenarateDeliveryPlanItems(List<ARSaleReturnItemsInfo> saleReturnItems)
        {
            saleReturnItems.ForEach(o =>
            {
                ARDeliveryPlanItemsList.Add(ToDeliveryPlanItemsInfo(o));
            });
        }

        public void GenarateDeliveryPlanItems(List<ICTransferItemsInfo> transferItems)
        {
            transferItems.ForEach(o =>
            {
                ARDeliveryPlanItemsList.Add(ToDeliveryPlanItemsInfo(o));
            });
        }

        private ARDeliveryPlanItemsInfo ToDeliveryPlanItemsInfo(ARSaleReturnItemsInfo objSaleReturnItemsInfo)
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objSaleReturnItemsInfo.FK_ACObjectID, objSaleReturnItemsInfo.ARObjectType);
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
            return new ARDeliveryPlanItemsInfo()
            {
                FK_ARSaleReturnID = objSaleReturnItemsInfo.FK_ARSaleReturnID,
                FK_ARSaleReturnItemID = objSaleReturnItemsInfo.ARSaleReturnItemID,
                FK_ICProductID = objSaleReturnItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objSaleReturnItemsInfo.FK_ICMeasureUnitID,
                FK_ICStockID = objSaleReturnItemsInfo.FK_ICStockID,
                ARDeliveryPlanItemDeliveryActualDate = mainObject.ARDeliveryPlanBeginDate,
                ARDeliveryPlanItemProductNo = objSaleReturnItemsInfo.ICProductNo,
                ARDeliveryPlanReferenceNo = objSaleReturnItemsInfo.ARSaleReturnNo,
                ARDeliveryPlanItemProductName = objSaleReturnItemsInfo.ARSaleReturnItemProductName,
                ARDeliveryPlanItemProductDesc = objSaleReturnItemsInfo.ARSaleReturnItemProductDesc,
                ARDeliveryPlanItemProductQty = objSaleReturnItemsInfo.ARSaleReturnItemProductQty,
                ARDeliveryPlanItemNetWeight = objSaleReturnItemsInfo.ICProductWidth * objSaleReturnItemsInfo.ICProductLength * objSaleReturnItemsInfo.ICProductHeight,
                ARDeliveryPlanItemSource = string.Empty,
                ARDeliveryPlanItemStatus = DeliveryPlanItemStatus.New.ToString(),
                //ARDeliveryPlanItemAddress =  objSaleReturnItemsInfo.ACObjectContactAddressLine3,
                ARDeliveryPlanItemAddress = objObjectsInfo != null ? objObjectsInfo.ACObjectDeliveryAddressLine1 : objSaleReturnItemsInfo.ACObjectContactAddressLine3,
                ARDeliveryPlanItemDeliveryAddressStreet = objSaleReturnItemsInfo.ARCustomerDeliveryAddressStreet,
                ARDeliveryPlanItemDeliveryAddressWard = objSaleReturnItemsInfo.ARCustomerDeliveryAddressWard,
                ARDeliveryPlanItemCommand = objSaleReturnItemsInfo.ARSaleReturnItemComment,
                FK_GEDeliveryDistrictID = objSaleReturnItemsInfo.FK_GEDeliveryDistrictID,
                FK_GEDeliveryStateProvinceID = objSaleReturnItemsInfo.FK_GEDeliveryStateProvinceID,
                ARDeliveryPlanItemProductHeight = objSaleReturnItemsInfo.ICProductHeight,
                ARDeliveryPlanItemProductWidth = objSaleReturnItemsInfo.ICProductWidth,
                ARDeliveryPlanItemProductLength = objSaleReturnItemsInfo.ICProductLength,
                ACObjectName = objSaleReturnItemsInfo.ACObjectName,
                FK_ACObjectID = objSaleReturnItemsInfo.FK_ACObjectID,
                ARObjectType = objSaleReturnItemsInfo.ARObjectType,
                ACObjectAccessKey = objSaleReturnItemsInfo.FK_ACObjectID + ";" + objSaleReturnItemsInfo.ARObjectType,
                ARDeliveryPlanItemSaleOrderNo = objSaleReturnItemsInfo.ARSaleReturnNo,
            };
        }

        private ARDeliveryPlanItemsInfo ToDeliveryPlanItemsInfo(ICTransferItemsInfo objTransferItemsInfo)
        {
            ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(objTransferItemsInfo.FK_ICToStockID);
            return new ARDeliveryPlanItemsInfo()
            {
                FK_ICTransferID = objTransferItemsInfo.FK_ICTransferID,
                FK_ICTransferItemID = objTransferItemsInfo.ICTransferItemID,
                FK_ICProductID = objTransferItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objTransferItemsInfo.FK_ICMeasureUnitID,
                FK_ICStockID = objTransferItemsInfo.FK_ICStockID,
                ARDeliveryPlanItemDeliveryActualDate = mainObject.ARDeliveryPlanBeginDate,
                ARDeliveryPlanItemProductNo = objTransferItemsInfo.ICProductNo,
                ARDeliveryPlanReferenceNo = objTransferItemsInfo.ICTransferNo,
                ARDeliveryPlanItemCommand = objTransferItemsInfo.ICTransferItemComment,
                ARDeliveryPlanItemProductName = objTransferItemsInfo.ICTransferItemProductName,
                ARDeliveryPlanItemProductDesc = objTransferItemsInfo.ICTransferItemProductDesc,
                ARDeliveryPlanItemProductQty = objTransferItemsInfo.ICTransferItemProductQty,
                ARDeliveryPlanItemNetWeight = objTransferItemsInfo.ICProductWidth * objTransferItemsInfo.ICProductLength * objTransferItemsInfo.ICProductHeight,
                ARDeliveryPlanItemSource = string.Empty,
                ARDeliveryPlanItemStatus = DeliveryPlanItemStatus.New.ToString(),
                ARDeliveryPlanItemProductHeight = objTransferItemsInfo.ICProductHeight,
                ARDeliveryPlanItemProductWidth = objTransferItemsInfo.ICProductWidth,
                ARDeliveryPlanItemProductLength = objTransferItemsInfo.ICProductLength,
                ARDeliveryPlanItemAddress = objStocksInfo.ICStockContactAddressLine1,
                ARDeliveryPlanItemDeliveryAddressStreet = objStocksInfo.ICStockContactAddressStreet,
                ARDeliveryPlanItemSaleOrderNo = objTransferItemsInfo.ICTransferNo,
            };
        }

        public ARDeliveryPlanTrucksInfo ToARDeliveryPlanTrucksInfo(ICProductsInfo objProductsInfo)
        {
            return new ARDeliveryPlanTrucksInfo()
            {
                ARDeliveryPlanTruckName = objProductsInfo.ICProductName,
                FK_ICProductID = objProductsInfo.ICProductID,
                ARDeliveryPlanTruckDeliveryPlanItem = DeliveryPlanLocalizedResources.TruckItemList,
                ARDeliveryPlanTruckNumber = objProductsInfo.ICProductLicensePlate,
                ARDeliveryPlanTruckGrossTon = objProductsInfo.ICProductBulk,
                ARDeliveryPlanTruckCapacity = objProductsInfo.ICProductCapacity,
                FK_HREmployeeID = objProductsInfo.FK_HREmployeeID,
                ARDeliveryPlanTruckDriver = String.Empty,
                ARDeliveryPlanTruckSource = DeliveryPlanTruckSource.Company.ToString(),

            };
        }

        public void GenarateDeliveryPlanTruckPoints(List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems, ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo)
        {
            deliveryPlanTruckItems.ForEach(o =>
                {
                    if (objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList == null)
                        objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList = new BOSList<ARDeliveryPlanTruckPointsInfo>(TableName.ARDeliveryPlanTruckPointsTableName);
                    ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = ToDeliveryPlanTruckPointsInfo(o, objDeliveryPlanTrucksInfo);

                    if (!(objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList.Any(s => s.ARDeliveryPlanTruckPointAddress == objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress && s.FK_ICProductTruckID == objDeliveryPlanTruckPointsInfo.FK_ICProductTruckID)))
                        objDeliveryPlanTrucksInfo.DeliveryPlanTruckPointsList.Add(objDeliveryPlanTruckPointsInfo);

                    if (!(DeliveryPlanTruckPointsList.Any(s => s.ARDeliveryPlanTruckPointAddress == objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress && s.FK_ICProductTruckID == objDeliveryPlanTruckPointsInfo.FK_ICProductTruckID)))
                        DeliveryPlanTruckPointsList.Add(objDeliveryPlanTruckPointsInfo);
                });
        }

        public ARDeliveryPlanTruckPointsInfo ToDeliveryPlanTruckPointsInfo(ARDeliveryPlanTruckItemsInfo objDeliveryPlanTruckItemsInfo, ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo)
        {
            ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = objDeliveryPlanTruckItemsInfo.FK_ARSaleReturnItemID > 0
                ? ARDeliveryPlanItemsList.Where(o => o.FK_ARSaleReturnItemID == objDeliveryPlanTruckItemsInfo.FK_ARSaleReturnItemID).FirstOrDefault()
                : ARDeliveryPlanItemsList.Where(o => o.FK_ICTransferItemID == objDeliveryPlanTruckItemsInfo.FK_ICTransferItemID).FirstOrDefault();
            List<string> itemDesc = new List<string>();
            if (objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList != null)
            {
                List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems = objDeliveryPlanTrucksInfo.DeliveryPlanTruckItemsList.Where(o => o.ARDeliveryPlanTruckItemAddress == objDeliveryPlanTruckItemsInfo.ARDeliveryPlanTruckItemAddress).ToList();
                deliveryPlanTruckItems.ForEach(o => itemDesc.Add(string.Format("{0} {1}", Convert.ToInt32(o.ARDeliveryPlanTruckItemDeliveryQty).ToString(), o.ARDeliveryPlanTruckItemProductDesc)));
            }

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objDeliveryPlanItemsInfo.FK_ACObjectID, objDeliveryPlanItemsInfo.ARObjectType);

            ARDeliveryPlanTruckPointsInfo objDeliveryPlanTruckPointsInfo = new ARDeliveryPlanTruckPointsInfo()
            {
                FK_ARDeliveryPlanTruckID = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckID,
                FK_ARDeliveryPlanID = objDeliveryPlanTrucksInfo.FK_ARDeliveryPlanID,
                FK_ICProductTruckID = objDeliveryPlanTrucksInfo.FK_ICProductID,
                ARDeliveryPlanTruckPointEstimateDate = objDeliveryPlanItemsInfo != null ? objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryDate : BOSApp.GetCurrentServerDate(),
                ARDeliveryPlanTruckPointActualDate = objDeliveryPlanItemsInfo != null ? objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryActualDate : BOSApp.GetCurrentServerDate(),
                ARDeliveryPlanTruckPointNo = BOSApp.GetMainObjectNo(ModuleName.DeliveryPlanTruckPoint, new ARDeliveryPlanTruckPointsInfo()),
                ARDeliveryPlanTruckPointAddress = objDeliveryPlanItemsInfo != null ? objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress : string.Empty,
                ARDeliveryPlanTruckPointNote = objDeliveryPlanItemsInfo.ARDeliveryPlanItemCommand,
                ARDeliveryPlanTruckPointStreet = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryAddressStreet,
                ARDeliveryPlanTruckPointWard = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryAddressWard,
                FK_GEDeliveryDistrictID = objDeliveryPlanItemsInfo.FK_GEDeliveryDistrictID,
                FK_GEDeliveryStateProvinceID = objDeliveryPlanItemsInfo.FK_GEDeliveryStateProvinceID,
                ARDeliveryPlanTruckName = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckName,
                ARDeliveryPlanTruckNumber = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckNumber,
                ARDeliveryPlanTruckPointCustomerName = objObjectsInfo != null ? objObjectsInfo.ACObjectName : string.Empty,
                FK_ARSaleReturnID = objDeliveryPlanItemsInfo.FK_ARSaleReturnID,
                FK_ICTransferID = objDeliveryPlanItemsInfo.FK_ICTransferID,
                FK_ARCustomerID = objDeliveryPlanItemsInfo.FK_ARCustomerID,
                ARDeliveryPlanTruckPointDesc = string.Join("; ", itemDesc.ToArray()),
                ARDeliveryPlanTruckSource = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckSource,
            };
            BOSApp.UpdateObjectNumbering(ModuleName.DeliveryPlanTruckPoint);
            string addressEncode = System.Uri.EscapeUriString(!String.IsNullOrEmpty(objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress) ? objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointAddress : String.Empty);
            string url = String.Format(GoogleApiUrl, addressEncode, GoogleApiKey);
            try
            {
                NetHttp net = new NetHttp(string.Empty);
                var headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/json"},
                };
                Geocoding result = net.Get<Geocoding>(url, headers);
                if (result != null && result.results.Count != 0)
                {
                    objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointLatitude = Convert.ToDecimal(result.results[0].geometry.location.lat);
                    objDeliveryPlanTruckPointsInfo.ARDeliveryPlanTruckPointLongitude = Convert.ToDecimal(result.results[0].geometry.location.lng);
                }
            }
            catch
            {
            }
            return objDeliveryPlanTruckPointsInfo;
        }

        public override bool CompleteTransaction()
        {
            base.CompleteTransaction();
            UpdateSaleOrderItem();
            return true;
        }

        public void UpdateSaleOrderItem()
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<int> saleOrderIDs = ARDeliveryPlanItemsList.Select(o => o.FK_ARSaleOrderID).Distinct().ToList();
            List<ARSaleOrderItemsInfo> saleOrderItems = new List<ARSaleOrderItemsInfo>();
            saleOrderIDs.ForEach(o => saleOrderItems = saleOrderItems.Concat(objSaleOrderItemsController.GetSaleOrderItemBySaleOrderID(o)).ToList());

            saleOrderItems.ForEach(o =>
            {
                ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo = ARDeliveryPlanItemsList.Where(s => s.FK_ARSaleOrderItemID == o.ARSaleOrderItemID).FirstOrDefault();
                if (objDeliveryPlanItemsInfo != null)
                {
                    o.ARSaleOrderItemPlanQty += objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty;
                    objSaleOrderItemsController.UpdateObject(o);
                }
            });
        }

        public void GenarateDeliveryPlanItems(List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)MainObject;
            ARDeliveryPlanTrucksController objDeliveryPlanTrucksController = new ARDeliveryPlanTrucksController();
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();

            string[] deliveryPlanItemIDs = deliveryPlanItems.Select(o => o.ARDeliveryPlanItemID.ToString()).ToArray();
            string deliveryPlanItemID = string.Join(",", deliveryPlanItemIDs);

            List<ARDeliveryPlanTrucksInfo> deliveryPlanTrucks = objDeliveryPlanTrucksController.GetDeliveryPlanTrucksByDeliveryPlanItemIDs(deliveryPlanItemID);

            string[] deliveryPlanTruckIDs = deliveryPlanTrucks.Select(o => o.ARDeliveryPlanTruckID.ToString()).Distinct().ToArray();
            string deliveryPlanTruckID = string.Join(",", deliveryPlanTruckIDs);

            List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems = objDeliveryPlanTruckItemsController.GetDeliveryPlanTruckItemsByDeliveryPlanTruckIDs(deliveryPlanTruckID);
            deliveryPlanTruckItems = deliveryPlanTruckItems.Where(o => deliveryPlanItems.Any(x => x.ARDeliveryPlanItemID == o.FK_ARDeliveryPlanItemID)).ToList();

            deliveryPlanItems.ForEach(o => ARDeliveryPlanItemsList.Add((ARDeliveryPlanItemsInfo)o.Clone()));

            deliveryPlanTrucks = deliveryPlanTrucks.GroupBy(o => o.FK_ICProductID).Select(x => x.First()).ToList();
            deliveryPlanTrucks.ForEach(o => ARDeliveryPlanTrucksList.Add((ARDeliveryPlanTrucksInfo)o.Clone()));

            deliveryPlanTruckItems.ForEach(o =>
            {
                o.ARDeliveryPlanTruckItemID = 0;
            });

            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                if (o.DeliveryPlanTruckItemsList == null)
                    o.DeliveryPlanTruckItemsList = new BOSList<ARDeliveryPlanTruckItemsInfo>(TableName.ARDeliveryPlanTruckItemsTableName);
                deliveryPlanTruckItems.Where(x => x.FK_ICProductTruckID == o.FK_ICProductID).All(x =>
                {
                    o.DeliveryPlanTruckItemsList.Add(x);
                    return true;
                });
            });
            ARDeliveryPlanItemsList.ForEach(o =>
            {
                o.ARDeliveryPlanItemReferenceID = o.ARDeliveryPlanItemID;
                o.ARDeliveryPlanItemID = 0;
                o.ARDeliveryPlanItemDeliveryActualDate = objDeliveryPlansInfo.ARDeliveryPlanBeginDate;
            });
            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                o.ARDeliveryPlanTruckID = 0;
                o.FK_ARDeliveryPlanID = 0;
            });
            deliveryPlanTruckItems.ForEach(o =>
            {
                o.FK_ARDeliveryPlanItemID = 0;
                o.FK_ARDeliveryPlanTruckID = 0;
                o.FK_ARDeliveryPlanID = 0;
                o.FK_ARDeliveryPlanTruckPointID = 0;
            });
            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                o.ARDeliveryPlanTruckTotalQty = o.DeliveryPlanTruckItemsList.Sum(x => x.ARDeliveryPlanTruckItemDeliveryQty);
                o.ARDeliveryPlanTruckTotalM3 = o.DeliveryPlanTruckItemsList.Sum(x => (x.ARDeliveryPlanTruckItemProductHeight * x.ARDeliveryPlanTruckItemProductWidth * x.ARDeliveryPlanTruckItemProductLength) * x.ARDeliveryPlanTruckItemDeliveryQty / 1000000000); // mm3 => m3
                GenarateDeliveryPlanTruckPoints(o.DeliveryPlanTruckItemsList.ToList(), o);
            });
            UpdateDeliveryPlanTruckPoint();
            objDeliveryPlansInfo.ARDeliveryPlanTotalTruck = ARDeliveryPlanTrucksList.Count();
            objDeliveryPlansInfo.ARDeliveryPlanTotalM3 = ARDeliveryPlanTrucksList.Sum(o => o.ARDeliveryPlanTruckTotalM3);
        }

        private ARDeliveryPlanItemsInfo ToDeliveryPlanItemsInfo(ARDeliveryPlanItemsInfo objDeliveryPlanItemsInfo)
        {
            return new ARDeliveryPlanItemsInfo()
            {
                FK_ARSaleReturnID = objDeliveryPlanItemsInfo.FK_ARSaleReturnID,
                FK_ICTransferID = objDeliveryPlanItemsInfo.FK_ICTransferID,
                FK_ARSaleReturnItemID = objDeliveryPlanItemsInfo.FK_ARSaleReturnItemID,
                FK_ICTransferItemID = objDeliveryPlanItemsInfo.FK_ICTransferItemID,
                FK_ARCustomerID = objDeliveryPlanItemsInfo.FK_ARCustomerID,
                FK_ICProductID = objDeliveryPlanItemsInfo.FK_ICProductID,
                FK_ICMeasureUnitID = objDeliveryPlanItemsInfo.FK_ICMeasureUnitID,
                ARDeliveryPlanItemSaleOrderNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemSaleOrderNo,
                ARDeliveryPlanItemSaleOrderDate = objDeliveryPlanItemsInfo.ARDeliveryPlanItemSaleOrderDate,
                ARDeliveryPlanItemDeliveryDate = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryDate,
                ARDeliveryPlanItemDeliveryActualDate = objDeliveryPlanItemsInfo.ARDeliveryPlanItemDeliveryActualDate,
                ARDeliveryPlanItemProductNo = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductNo,
                ARDeliveryPlanItemProductName = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductName,
                ARDeliveryPlanItemProductDesc = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductDesc,
                ARDeliveryPlanItemProductType = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductType,
                ARDeliveryPlanItemProductQty = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty,
                ARDeliveryPlanItemNetWeight = objDeliveryPlanItemsInfo.ARDeliveryPlanItemProductQty,
                ARDeliveryPlanItemAddress = objDeliveryPlanItemsInfo.ARDeliveryPlanItemAddress,
                ARDeliveryPlanItemCommand = objDeliveryPlanItemsInfo.ARDeliveryPlanItemCommand,
                ARDeliveryPlanItemSource = string.Empty,
                ARDeliveryPlanItemStatus = DeliveryPlanItemStatus.New.ToString(),
                ARDeliveryPlanItemReferenceID = objDeliveryPlanItemsInfo.ARDeliveryPlanItemID,
                FK_ACObjectID = objDeliveryPlanItemsInfo.FK_ACObjectID,
                ARObjectType = objDeliveryPlanItemsInfo.ARObjectType,
                ACObjectAccessKey = objDeliveryPlanItemsInfo.FK_ACObjectID + ";" + objDeliveryPlanItemsInfo.ARObjectType,
            };
        }

        public ARDeliveryPlanTrucksInfo ToARDeliveryPlanTrucksInfo(ARDeliveryPlanTrucksInfo objDeliveryPlanTrucksInfo)
        {
            return new ARDeliveryPlanTrucksInfo()
            {
                FK_ICMeasureUnitID = objDeliveryPlanTrucksInfo.FK_ICMeasureUnitID,
                ARDeliveryPlanTruckName = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckName,
                FK_ICProductID = objDeliveryPlanTrucksInfo.FK_ICProductID,
                ARDeliveryPlanTruckDeliveryPlanItem = DeliveryPlanLocalizedResources.TruckItemList,
                ARDeliveryPlanTruckNumber = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckNumber,
                ARDeliveryPlanTruckGrossTon = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckGrossTon,
                ARDeliveryPlanTruckCapacity = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckCapacity,
                ARDeliveryPlanTruckDriver = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckDriver,
                ARDeliveryPlanTruckSource = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckSource,
                ARDeliveryPlanTruckTotalQty = objDeliveryPlanTrucksInfo.ARDeliveryPlanTruckTotalQty,
            };
        }

        public override void DeleteObjectRelations(String strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            ARDeliveryPlanTruckItemsController objDeliveryPlanTruckItemsController = new ARDeliveryPlanTruckItemsController();
            switch (strTableName)
            {
                case TableName.ARDeliveryPlanTrucksTableName:
                    objDeliveryPlanTruckItemsController.DeleteDeliveryPlanTruckItemsByDeliveryPlanTruckID(iObjectID);

                    ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
                    objDeliveryPlanTruckPointsController.DeleteDeliveryPlanTruckPointsByDeliveryPlanTruckID(iObjectID);
                    break;
                case TableName.ARDeliveryPlanWorksTableName:
                    ARDeliveryPlanWorksController objDeliveryPlanWorksController = new ARDeliveryPlanWorksController();
                    objDeliveryPlanWorksController.DeleteAllObjectsByObjectParentID(iObjectID);

                    PMTasksController objTasksController = new PMTasksController();
                    objTasksController.DeleteTasksByDeliveryPlanWorkID(iObjectID);

                    break;
                case TableName.ARDeliveryPlanItemsTableName:
                    objDeliveryPlanTruckItemsController.DeleteDeliveryPlanTruckItemsByDeliveryPlanItemID(iObjectID);
                    break;
            }
        }

        public void UpdateDeliveryPlanTruckPoint()
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            ARDeliveryPlanTrucksList.ForEach(o =>
            {
                string employeeName = objEmployeesController.GetObjectNameByID(o.FK_HREmployeeID);
                if (String.IsNullOrEmpty(employeeName))
                    return;
                o.ARDeliveryPlanTruckDriver = employeeName;
                DeliveryPlanTruckPointsList.Where(x => x.ARDeliveryPlanTruckNumber == o.ARDeliveryPlanTruckNumber).All(i =>
                {
                    i.ARDeliveryPlanTruckPointEmployeeDeliveryName = employeeName;
                    return true;
                });
                DeliveryPlanTruckPointsList.GridControl.RefreshDataSource();
            });
        }

        public bool Validate()
        {
            try
            {
                SetPropertyChangeEventLock(false);
                ARDeliveryPlansInfo mainObject = (ARDeliveryPlansInfo)MainObject;
                mainObject.ARDeliveryPlanStatus = DeliveryPlanStatus.Verified.ToString();
                UpdateMainObject();

                SetPropertyChangeEventLock(true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
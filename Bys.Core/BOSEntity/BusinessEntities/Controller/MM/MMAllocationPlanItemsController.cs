﻿using BOSLib;
using BOSLib.Extensions;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP
{
    #region MMAllocationPlanItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMAllocationPlanItemsController
    //Created Date:Tuesday, November 24, 2015
    //-----------------------------------------------------------

    public class MMAllocationPlanItemsController : BaseBusinessController
    {
        public MMAllocationPlanItemsController()
        {
            dal = new DALBaseProvider("MMAllocationPlanItems", typeof(MMAllocationPlanItemsInfo));
        }
        public DataSet GetAllMMAllocationPlanItemsForLookupControl()
        {

            DataSet ds = dal.GetDataSet("MMAllocationProposalItems_GetAllMMAllocationProposalItemsForLookupControl");
            return ds;
        }
        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemHWsByBatchProductProductionNormItems(int producttionNorm, decimal ProductQty)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemHWsByBatchProductProductionNormItems", producttionNorm, ProductQty);
            List<MMAllocationPlanItemsInfo> components = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    components.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return components;
        }

        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemPaintsByBatchProductProductionNormItems(int productionNorm, decimal productQty)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemPaintsByBatchProductProductionNormItems", productionNorm, productQty);
            List<MMAllocationPlanItemsInfo> components = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    components.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return components;
        }
        public List<MMAllocationPlanItemsInfo> GetrequestforAllocationProposal(string MAllocationPlanType)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlans_GetrequestforAllocationProposal", MAllocationPlanType);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetAvailableAllocationProposal(int batproductID, string proposalProductType, int workShopID, int lineID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlans_GetAvailableAllocationProposal", batproductID, proposalProductType, workShopID, lineID, fromDate, toDate);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> MMAllocationPlans_GetrequestforHWPackagingCCDC(string MAllocationPlanType)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlans_GetrequestforHWPackagingCCDC", MAllocationPlanType);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> MMAllocationPlans_GetrequestforHWPackagingCCDCAndNotExistsAllocationProposalItem(string MAllocationPlanType)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlans_GetrequestforHWPackagingCCDCAndNotExistsAllocationProposalItem", MAllocationPlanType);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetAvailableMaterialToProposal(int batproductID, string proposalProductType, int workShopID, int lineID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlans_GetAvailableMaterialToProposal", batproductID, proposalProductType, workShopID, lineID, fromDate, toDate);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMAllocationPlanItemsInfo> products = new List<MMAllocationPlanItemsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objProductsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    products.Add(objProductsInfo);
                }
                ds.Dispose();
            }
            return products;
        }
        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemPackagingsByBatchProductProductionNormItems(int productionNormID, decimal productQty)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemPackagingsByBatchProductProductionNormItems", productionNormID, productQty);
            List<MMAllocationPlanItemsInfo> components = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    components.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return components;
        }

        public List<MMAllocationPlanItemsInfo> GetItemsByAllocationPlanID(int allocationPlanID, string group = "")
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemsByAllocationPlanID", allocationPlanID, group);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public decimal GetTotalAllocationPlanItemQuantityBySomeCriteria(int batchProductID, int woodPlanID, int productID,
                                                                                    int measureUnitID, int productAttributeWoodTypeID,
                                                                                decimal productHeight, decimal productLength, decimal productWidth,
                                                                                string productName, string productDesc)
        {
            decimal result = 0;
            var obj = (decimal)dal.GetSingleValue("MMAllocationPlanItems_GetTotalAllocationPlanItemQuantityBySomeCriteria", batchProductID, woodPlanID, productID,
                                                                                                    measureUnitID, productAttributeWoodTypeID,
                                                                                                    productHeight, productLength, productWidth,
                                                                                                    productName, productDesc);
            if (obj != null)
            {
                result = (decimal)obj;
            }
            return result;
        }

        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemQuantityBySomeCriteria(int MMPurchasePlanID)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemQuantityBySomeCriteria", MMPurchasePlanID);
            List<MMAllocationPlanItemsInfo> AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    AllocationPlanItemList.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return AllocationPlanItemList;
        }
        public decimal GetAllocatedQuantityBySomeCriteria(int? batchProductID
                                                         , int? BatchProductItemID
                                                         , int? ProductForBatchID
                                                         , int? ProductID
                                                         , string ProductDesc
                                                         , int? MeasureUnit)
        {
            decimal result = 0;
            var obj = dal.GetSingleValue("MMAllocationPlanItems_GetAllocatedQuantityBySomeCriteria", batchProductID, BatchProductItemID, ProductForBatchID, ProductID, ProductDesc, MeasureUnit);
            if (obj != null)
            {
                result = (decimal)obj;
            }
            return result;
        }
        public List<MMAllocationPlanItemsInfo> GetCancelAllocationPlanForAllocationPlan()
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlans_GetCancelAllocationPlanForAllocationPlan");
            List<MMAllocationPlanItemsInfo> AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    AllocationPlanItemList.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return AllocationPlanItemList;
        }
        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemWoodForReport(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemWoodForReport", batchProductID);
            List<MMAllocationPlanItemsInfo> AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    AllocationPlanItemList.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return AllocationPlanItemList;
        }

        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemWoodDetailForReport(int batchProductID, int ProductForBatchID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemWoodDetailForReport", batchProductID, ProductForBatchID);
            List<MMAllocationPlanItemsInfo> AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    AllocationPlanItemList.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return AllocationPlanItemList;
        }
        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemForReport(int batchProductItemID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemForReport", batchProductItemID);
            List<MMAllocationPlanItemsInfo> AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    AllocationPlanItemList.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return AllocationPlanItemList;
        }
        public List<MMAllocationPlanItemsInfo> GetAllocationPlanIngredientPackagingItemForReport(int batchProductItemID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanIngredientPackagingItemForReport", batchProductItemID);
            List<MMAllocationPlanItemsInfo> AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);
                    AllocationPlanItemList.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return AllocationPlanItemList;
        }
        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemForSaleOrder(string productType)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemForSaleOrder", productType);
            List<MMAllocationPlanItemsInfo> AllocationPlanItemList = new List<MMAllocationPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)GetObjectFromDataRow(row);

                    objAllocationPlanItemsInfo.MMAllocationPlanItemQty -= objAllocationPlanItemsInfo.MMAllocationPlanItemSaleOrderQty;
                    objAllocationPlanItemsInfo.MMAllocationPlanItemWoodQty -= objAllocationPlanItemsInfo.MMAllocationPlanItemSaleOrderWoodQty;
                    AllocationPlanItemList.Add(objAllocationPlanItemsInfo);
                }
            }
            ds.Dispose();
            return AllocationPlanItemList;
        }
        public decimal GetQtyForWoodPlan(int WoodPlanID, int ProductID, int WoodTypeID, decimal Height)
        {
            MMAllocationPlanItemsInfo obj = new MMAllocationPlanItemsInfo();
            decimal result = 0;
            obj = (MMAllocationPlanItemsInfo)dal.GetDataObject("MMAllocationPlanItems_GetQtyForWoodPlan", WoodPlanID, ProductID, WoodTypeID, Height);
            if (obj != null)
            {
                result = obj.MMAllocationPlanItemQty;
            }
            return result;

        }

        public decimal GetAllocatedQty(int batchProductItemID, int ProductID, string hwSource, string productDesc, int allocationPlanItemID, int woodPlanID, decimal height)
        {

            decimal result = 0;
            var obj = dal.GetSingleValue("MMAllocationPlanItems_GetAllocatedQty", batchProductItemID, ProductID, hwSource, productDesc, allocationPlanItemID, woodPlanID, height);
            if (obj != null)
            {
                result = (decimal)obj;
            }
            return result;

        }
        public decimal GetAllocatedQtyForCheckDryLumber(int allocationPlanItemID
                                                    , int batchProductID
                                                    , string batchProductItemProductSerial
                                                    , int saleOrderID
                                                    , int saleOrderItemID
                                                    , int productID
                                                    , int batchProductItemID
                                                    , decimal height
                                                    , decimal length
                                                    , decimal width)
        {

            decimal result = 0;
            var obj = dal.GetSingleValue("MMAllocationPlanItems_GetAllocatedQtyForCheckDryLumber", allocationPlanItemID
                                                                                                , batchProductID
                                                                                                , batchProductItemProductSerial
                                                                                                , saleOrderID
                                                                                                , saleOrderItemID
                                                                                                , productID
                                                                                                , batchProductItemID
                                                                                                , height
                                                                                                , length
                                                                                                , width);
            if (obj != null)
            {
                result = (decimal)obj;
            }
            return result;

        }

        public decimal GetAllocatedQtyForOther(int batchProductItemID, int ProductID, string hwSource, string productDesc, int allocationPlanItemID, int woodPlanID, decimal height, int BatchProductProductionNormItemID)
        {

            decimal result = 0;
            var obj = dal.GetSingleValue("MMAllocationPlanItems_GetAllocatedQtyForOther", batchProductItemID, ProductID, hwSource, productDesc, allocationPlanItemID, woodPlanID, height, BatchProductProductionNormItemID);
            if (obj != null)
            {
                result = (decimal)obj;
            }
            return result;

        }
        public List<MMAllocationPlanItemsInfo> ValidateChangeBoomInfomation(int batchProductID, int batchProductItemID, int BatchProductProductionNormItemID, int productID)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_ValidateChangeBoomInfomation", batchProductID, batchProductItemID, BatchProductProductionNormItemID, productID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetMMAllocationPlanItemPackagingByBatchProductAndProductDesc(int batchProductID, string ProductDesc)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetMMAllocationPlanItemPackagingByBatchProductAndProductDesc", batchProductID, ProductDesc);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetAllocatedQtyByBatchProductID(int batchProductID, string allocationPlanType, int allocationPlanItemID)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocatedQtyByBatchProductID", batchProductID, allocationPlanType, allocationPlanItemID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetAllocatedQtyByOperationDetailPlanID(int operationDetailPlanID, string allocationPlanType, int allocationPlanItemID)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocatedQtyByOperationDetailPlanID", operationDetailPlanID, allocationPlanType, allocationPlanItemID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public decimal GetAllocationPlanHardwareQtyAvailable(int? batchProductItemID
            , int ProductID, int allocationPlanItemID, int BatchProductProductionNormItemID, int OperationID)
        {

            decimal result = 0;
            var obj = dal.GetSingleValue("MMAllocationPlanItems_GetAllocationPlanHardwareQtyAvailable",
                                                                                             batchProductItemID
                                                                                            , ProductID
                                                                                            , allocationPlanItemID
                                                                                            , BatchProductProductionNormItemID
                                                                                            , OperationID);
            if (obj != null)
            {
                result = (decimal)obj;
            }
            return result;

        }
        public List<MMAllocationPlanItemsInfo> GetAllocatedDryLumberAvailable(string batchProductListID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocatedDryLumberAvailable", batchProductListID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetOperationPlanAllocatedDryLumberAvailable(int operationDetailPlanID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetOperationPlanAllocatedDryLumberAvailable", operationDetailPlanID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetListAllocationPlanHardwareQtyAvailable(int? allocationPlanID)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetListAllocationPlanHardwareQtyAvailable", allocationPlanID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public void UpdateAllocationPlanItemProposedBy(int ProposalID, string UpdateUser)
        {
            dal.ExecuteStoredProcedure("MMAllocationPlanItems_UpdateAllocationPlanItemProposed", ProposalID, UpdateUser);
        }
        public List<MMAllocationPlanItemsInfo> GetAllocationPlanQtyAvailable(int? BatchProductID
            , int? ProductID
            , int? allocationPlanID
            , int? MMOperationID)
        {

            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanQtyAvailable", BatchProductID, ProductID, allocationPlanID, MMOperationID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetListForCheckInventoryQty(int? allocationPlanID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetListForCheckInventoryQty", allocationPlanID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetAllAllocationPlanItemsForTransferOutsourcing()
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllAllocationPlanItemsForTransferOutsourcing");
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetAllocationPlanItemsForTransferOutsourcing(int batchProductID
                                                                                            , int operationID
                                                                                            , int saleOrderID
                                                                                            , int objectID
                                                                                            , string objectType
                                                                                            , string allocationPlanType
                                                                                            , DateTime? fromDate
                                                                                            , DateTime? toDate)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetAllocationPlanItemsForTransferOutsourcing", batchProductID
                                                                                                            , operationID
                                                                                                            , saleOrderID
                                                                                                            , objectID
                                                                                                            , objectType
                                                                                                            , allocationPlanType
                                                                                                            , fromDate
                                                                                                            , toDate);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetListForCheckUnAllocationPlan(string allocationPlanItemRef)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetListForCheckUnAllocationPlan", allocationPlanItemRef);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetItemForShipmentByItemGroup(string allocationPlanItemGroup, int batchProductID, int allocationPlanID, int workShopID, int lineID, int departmentRoomGroupItemID, int employeeReceiveID, DateTime fromDate, DateTime toDate, int userID, string moduleName, string dataViewPermissionType, int branchID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemForShipmentByItemGroup", allocationPlanItemGroup, batchProductID, allocationPlanID, workShopID, lineID, departmentRoomGroupItemID, employeeReceiveID, fromDate, toDate, userID, moduleName, dataViewPermissionType, branchID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetItemForConversionProposalByItemGroup(string allocationPlanItemGroup, int batchProductID, int allocationPlanID, int workShopID, int lineID, int departmentRoomGroupItemID, int employeeReceiveID, DateTime fromDate, DateTime toDate, int userID, string moduleName, string dataViewPermissionType, int branchID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemForConversionProposalByItemGroup", allocationPlanItemGroup, batchProductID, allocationPlanID, workShopID, lineID, departmentRoomGroupItemID, employeeReceiveID, fromDate, toDate, userID, moduleName, dataViewPermissionType, branchID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public MMAllocationPlanItemsInfo GetRemainQtyForShipmentByID(int allocationPlanItemID, int shipmentItemID)
        {
            return (MMAllocationPlanItemsInfo)dal.GetDataObject("MMAllocationPlanItems_GetRemainQtyForShipmentByID", allocationPlanItemID, shipmentItemID);
        }

        public List<MMAllocationPlanItemsInfo> GetRemainQtyForShipment(List<int> planItemIds, List<int> shipmentItemIds)
        {
            DataTable planItemDt = planItemIds.ToDataTableIds();
            DataTable shipmentDts = shipmentItemIds.ToDataTableIds();
            var parameters = new DynamicParameters();
            parameters.Add("@PlanItemIDs", planItemDt.AsTableValuedParameter("Type_ObjectID"), DbType.Object, ParameterDirection.Input);
            parameters.Add("@ShipmentItemIds", shipmentDts.AsTableValuedParameter("Type_ObjectID"), DbType.Object, ParameterDirection.Input);
            var results = dal.Connection.ExecuteReader("MMAllocationPlanItems_GetRemainQtyForShipment", parameters, commandType: CommandType.StoredProcedure);
            DataSet ds = new DataSet();
            int readIndex = 0;
            do
            {
                DataTable dr = new DataTable();
                dr.TableName = string.Format("Table{0}", readIndex == 0 ? "" : readIndex.ToString());
                dr.Load(results);
                ds.Tables.Add(dr);
                readIndex++;
            } while (!results.IsClosed);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetRemainQtyForProductConversion(List<int> planItemIds)
        {
            DataTable planItemDt = planItemIds.ToDataTableIds();
            var parameters = new DynamicParameters();
            parameters.Add("@PlanItemIDs", planItemDt.AsTableValuedParameter("Type_ObjectID"), DbType.Object, ParameterDirection.Input);
            var results = dal.Connection.ExecuteReader("MMAllocationPlanItems_GetRemainQtyForProductConversion", parameters, commandType: CommandType.StoredProcedure);
            DataSet ds = new DataSet();
            int readIndex = 0;
            do
            {
                DataTable dr = new DataTable();
                dr.TableName = string.Format("Table{0}", readIndex == 0 ? "" : readIndex.ToString());
                dr.Load(results);
                ds.Tables.Add(dr);
                readIndex++;
            } while (!results.IsClosed);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetRemainQtyForShipmentByItemGroup(int allocationPlanID, string allocationPlanItemGroup, string shipmentItemRef)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetRemainQtyForShipmentByItemGroup", allocationPlanID, allocationPlanItemGroup, shipmentItemRef);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetItemForCloseByAllocationPlanID(int allocationPlanID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemForCloseByAllocationPlanID", allocationPlanID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetItemForPurchaseProposal(string group, int batchProductID, DateTime fromDate, DateTime toDate, int userID, string moduleName, string permissionType, int branchID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemForPurchaseProposal", group, batchProductID, fromDate, toDate, userID, moduleName, permissionType, branchID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public decimal GetRemainItemForPurchaseProposal(string group, string batchProductRef, string batchProductItemRef, string pniItemRef, string allocationPlanRef, string allocationPlanItemRef, int proprosalItemID)
        {
            return (decimal)dal.GetSingleValue("MMAllocationPlanItems_GetRemainItemForPurchaseProposal", group, batchProductRef, batchProductItemRef, pniItemRef, allocationPlanRef, allocationPlanItemRef, proprosalItemID);
        }

        public void AdjustPostedAllocationPlanItems(string moduleName, int allocationPlanID, bool isPosted = true)
        {
            dal.ExecuteStoredProcedure("IC_AdjustPostedAllocationPlanItems", moduleName, allocationPlanID, isPosted);
        }

        public List<MMAllocationPlanItemsInfo> GetItemsInstrumentListForEquipmentShipment(int branchID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemsInstrumentListForEquipmentShipment", branchID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMAllocationPlanItemsInfo> GetInvalidateItemMaterialByBatchProductID(int batchProductID, string itemGroup)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemMaterialByBatchProductID", batchProductID, itemGroup);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        
        public List<MMAllocationPlanItemsInfo> GetInvalidateItemByBatchProductID(int batchProductID, string itemGroup)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemByBatchProductID", batchProductID, itemGroup);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        
        public List<MMAllocationPlanItemsInfo> GetInvalidateItemInventoryByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetInvalidateItemInventoryByBatchProductID", batchProductID);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public MMAllocationPlanItemsInfo GetRemainItemForAlternative(int allocationPlanItemID, int normPniID, int normPniMaterialID, int outsourcingID)
        {
            return (MMAllocationPlanItemsInfo)dal.GetDataObject("MMAllocationPlanItemsInfo_GetRemainItemForAlternative", allocationPlanItemID, normPniID, normPniMaterialID, outsourcingID);
        }
        public List<MMAllocationPlanItemsInfo> GetItemForShipmentByProductConversion(int allocationPlanID, int productForBatchID, string AllocationPlanItemGroup)
        {
            DataSet ds = dal.GetDataSet("MMAllocationPlanItems_GetItemForShipmentByProductConversion", allocationPlanID, productForBatchID, AllocationPlanItemGroup);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMAllocationPlanItemsInfo> GetItemForShipmentByProductConversion(List<int> allocationPlanID, List<int> productForBatchID, string AllocationPlanItemGroup)
        {
            //DataTable planItemDt = productForBatchID.ToDataTableIds();
            var parameters = new DynamicParameters();
            parameters.Add("@AllocationPlanID", string.Join(",", allocationPlanID.Distinct().ToArray()), DbType.String, ParameterDirection.Input);
            parameters.Add("@ProductForBatchIDs",string.Join(",", productForBatchID.Distinct().ToArray()), DbType.String, ParameterDirection.Input);
            parameters.Add("@AllocationPlanItemGroup", AllocationPlanItemGroup, DbType.String, ParameterDirection.Input);
            var results = dal.Connection.ExecuteReader("MMAllocationPlanItems_GetProductConversionItemForShipmentBySomeCreteriaList", parameters, commandType: CommandType.StoredProcedure);
            DataSet ds = new DataSet();
            int readIndex = 0;
            do
            {
                DataTable dr = new DataTable();
                dr.TableName = string.Format("Table{0}", readIndex == 0 ? "" : readIndex.ToString());
                dr.Load(results);
                ds.Tables.Add(dr);
                readIndex++;
            } while (!results.IsClosed);
            return (List<MMAllocationPlanItemsInfo>)GetListFromDataSet(ds);
        }
        #endregion
    }
}
﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductSeries
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductSeriesController
    //Created Date:Friday, October 14, 2011
    //-----------------------------------------------------------

    public class ICProductSeriesController : BaseBusinessController
    {
        public ICProductSeriesController()
        {
            dal = new DALBaseProvider("ICProductSeries", typeof(ICProductSeriesInfo));
        }

        /// <summary>
        /// Get serie of a product by serie no
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="serieNo">Serie no</param>
        /// <returns>Serie object</returns>
        public ICProductSeriesInfo GetSerieByProductIDAndSerieNo(int productID, string serieNo)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetSerieByProductIDAndSerieNo", productID, serieNo);
        }

        public ICProductSeriesInfo GetSerieByProductIDAndLotNo(int productID, string lotNo)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetSerieByProductIDAndLotNo", productID, lotNo);
        }

        /// <summary>
        /// Get series of a product that remain in a stock
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <returns>List of series</returns>
        public List<ICProductSeriesInfo> GetSeriesByProductIDAndStockID(int productID, int stockID, string desc, DateTime date)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetSeriesByProductIDAndStockID", productID, stockID, desc, date);
            List<ICProductSeriesInfo> series = new List<ICProductSeriesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)GetObjectFromDataRow(row);
                    series.Add(objProductSeriesInfo);
                }
            }
            return series;
        }

        /// <summary>
        /// Get all series of an equipment in a room
        /// </summary>
        /// <param name="equipmentID">Equipment id</param>
        /// <param name="roomID">Room id</param>
        /// <returns>List of series</returns>
        public List<ICProductSeriesInfo> GetSeriesByEquipmentIDAndRoomID(int equipmentID, int roomID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetSeriesByEquipmentIDAndRoomID", equipmentID, roomID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICProductSeriesInfo> series = new List<ICProductSeriesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)GetObjectFromDataRow(row);
                    series.Add(objProductSeriesInfo);
                }
            }
            ds.Dispose();
            return series;
        }

        public ICProductSeriesInfo GetSerieBySerieNoAndProductType(string serieNo, string productType)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetSerieBySerieNoAndProductType", serieNo, productType);
        }

        public ICProductSeriesInfo GetSerieBySerieNo(string serieNo)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetSerieBySerieNo", serieNo);
        }

        public ICProductSeriesInfo GetICProductSeries_ByProductIDAnddryLumberHeight(int prodictID, decimal dryLumberHeight)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetSerieByProductIDAnddryLumberHeight", prodictID, dryLumberHeight);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)GetObjectFromDataRow(row);
                    return objProductSeriesInfo;
                }
            }
            return null;
        }

        public List<ICProductSeriesInfo> ShowguidInventoryStock(int ICProductID, string ICProductType, int FK_ICProductAttributeWoodTypeID, int FK_ICProductGroupID, int FK_ICStockID, int batchProductID, int ProductForBatch)
        {
            DataSet ds = dal.GetDataSet("ShowguidInventoryStock", ICProductID, ICProductType, FK_ICProductAttributeWoodTypeID, FK_ICProductGroupID, FK_ICStockID, batchProductID, ProductForBatch);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public ICProductSeriesInfo GetSerieByProductIDAndSerieNoAndDesc(int productID, string serieNo, string Desc)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetSerieByProductIDAndSerieNoAndDesc", productID, serieNo, Desc);
        }

        public ICProductSeriesInfo GetProductSerieForEquipment(int productID, string serieNo, int modelID, int modelDetailID)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetProductSerieForEquipment", productID, serieNo, modelID, modelDetailID);
        }

        public ICProductSeriesInfo GetSeriesNoByStockAndProduct(int StockID, int ProductID, string Desc, decimal Qty)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetSeriesNoByStockAndProduct", StockID, ProductID, Desc, Qty);
        }

        public List<ICProductSeriesInfo> GetProductSerieByProductID(int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetProductSerieByProductID", productID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetProductSerieByManyParamForImport(int FK_MMBatchProductID, int FK_MMOperationID, int FK_ICProductForBatchID, int FK_ICProductID, int FK_ICStock, decimal qty)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetListObjectForImport", FK_MMBatchProductID, FK_MMOperationID, FK_ICProductForBatchID, FK_ICProductID, FK_ICStock, qty);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetListInventoryStockForImport(int FK_MMBatchProductID, int FK_MMOperationID, int FK_ICProductForBatchID, int FK_ICProductID, int FK_ICStock)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetListInventoryStockForImport", FK_MMBatchProductID, FK_MMOperationID, FK_ICProductForBatchID, FK_ICProductID, FK_ICStock);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetListItemForEdit()
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetListItemForEdit");
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetListItemForEditByProductType(string productType)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetListItemForEditByProductType", productType);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForEditByQtyAndSeriesIDAndStockIDAndProductID(decimal qty, int seriesID, int stockID, int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForEditByQtyAndSeriesIDAndStockIDAndProductID", qty, seriesID, stockID, productID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForIngredientPackaging(string desc, int seriesID, int stockID, int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForIngredientPackaging", desc, seriesID, stockID, productID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForSemiProduct(int seriesID, int stockID, int productID, int batchProductID, int operationID, int ICProductForBatchID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForSemiProduct", seriesID, stockID, productID, batchProductID, operationID, ICProductForBatchID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForEditByproductAttributeIDAndProductheight(int productAttributeWoodTypeID, int height)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForEditByproductAttributeIDAndProductheight", productAttributeWoodTypeID, height);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForProduct(int seriesID, int stockID, int productID, int batchProductID, int operationID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForProduct", seriesID, stockID, productID, batchProductID, operationID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForLumber(int seriesID, int stockID, int productID, decimal Height, decimal LengthMin, decimal WidthMin, decimal LengthMax, decimal WidthMax)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForLumber", seriesID, stockID, productID, Height, LengthMin, WidthMin, LengthMax, WidthMax);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForRoundWood(int seriesID, int stockID, int productID, decimal Height, decimal Perimeter)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForEditByQtyAndSeriesIDAndStockIDAndProductIDForRounWood", seriesID, stockID, productID, Height, Perimeter);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetListObjectForLookupReport127()
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetListObjectForLookupReport127");
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetItemForReport127(int APSupplierID, int ICProductSerieID, DateTime FromDate, DateTime ToDate, int AttributeID)
        {
            List<ICProductSeriesInfo> series = new List<ICProductSeriesInfo>();
            DataSet ds = dal.GetDataSet("ICProductSeries_GetItemForReport127", APSupplierID, ICProductSerieID, FromDate, ToDate, AttributeID);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {


                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)GetObjectFromDataRow(row);
                    if (objProductSeriesInfo.ICProductSerieProductPerimeter < 800)
                    {
                        objProductSeriesInfo.ICProductSerieProductPerimeter80 = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    }
                    else if (objProductSeriesInfo.ICProductSerieProductPerimeter >= 800 && objProductSeriesInfo.ICProductSerieProductPerimeter < 1100)
                    {
                        objProductSeriesInfo.ICProductSerieProductPerimeter80110 = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    }
                    else
                    {
                        objProductSeriesInfo.ICProductSerieProductPerimeter110 = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    }
                    series.Add(objProductSeriesInfo);
                }
            }
            return series;
        }

        public DataSet GetAllProductSeriesForLookupControl()
        {
            return dal.GetDataSet("ICProductSeries_GetAllProductSeriesForLookupControl");
        }

        public List<ICProductSeriesInfo> GetProductSeriesForReportDetail(int woodTypeID, int QualityTypeID, decimal productHeight)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetProductSeriesForReportDetail", woodTypeID, QualityTypeID, productHeight);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetProductSeriesForEdit(int Product, DateTime FromDate, DateTime ToDate)
        {
            List<ICProductSeriesInfo> series = new List<ICProductSeriesInfo>();
            DataSet ds = dal.GetDataSet("ICProductSeries_EditInvestoryStock", Product, FromDate, ToDate);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {


                    ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)GetObjectFromDataRow(row);
                    if (objProductSeriesInfo.ICInventoryStockQuantity > 0)
                        series.Add(objProductSeriesInfo);

                }
            }
            return series;

        }

        public List<ICProductSeriesInfo> GetProductSerieByStockIDAndProductID(int stockID, int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetProductSerieByStockIDAndProductID", stockID, productID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetProductSerieForDisassemble(int productID, int stockID)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetProductSerieForDisassemble", productID, stockID);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetSeriesByProductIDAndProductDescAndStockID(int productID, int stockID, string desc)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetSeriesByProductIDAndProductDescAndStockID", productID, stockID, desc);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductSeriesInfo> GetProductSeriesByProductHeight(int productID, int stockID, decimal productHeight)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetProductSeriesByProductHeight", productID, stockID, productHeight);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public ICProductSeriesInfo GetProductSeriesByNoAndProductHeight(int productID, int stockID, string productSerieNo, decimal productHeight)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetProductSeriesByNoAndProductHeight", productID, stockID, productSerieNo, productHeight);
        }

        public List<ICProductSeriesInfo> GetProductSeriesByProductSize(int productID, int stockID, decimal productLenght, decimal productWidth, decimal productHeight)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetProductSeriesByProductSize", productID, stockID, productLenght, productWidth, productHeight);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public ICProductSeriesInfo GetProductSeriesByNoAndProductSize(int productID, int stockID, string productSerieNo, decimal productLenght, decimal productWidth, decimal productHeight)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetProductSeriesByNoAndProductSize", productID, stockID, productSerieNo, productLenght, productWidth, productHeight);
        }

        public ICProductSeriesInfo GetProductSeriesByNoAndStock(int productID, int stockID, string productSerieNo)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetProductSeriesByNoAndStock", productID, stockID, productSerieNo);
        }

        public List<ICProductSeriesInfo> GetProductSeriesByProductIDAndLotNo(int productID, string lotNo)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetProductSeriesByProductIDAndLotNo", productID, lotNo);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }

        public void GenerateProductSerieByReceiptID(int receiptID)
        {
            dal.ExecuteStoredProcedure("ICProductSeries_GenerateProductSerieByReceiptID", receiptID);
        }
        public void DeleteReferSeries(int receiptID)
        {
            dal.ExecuteStoredProcedure("ICProductSeries_DeleteReferSeries", receiptID);
        }
        public void GenerateProductSerieByProductConversionID(int productConversionID)
        {
            dal.ExecuteStoredProcedure("ICProductSeries_GenerateProductSerieByProductConversionID", productConversionID);
        }

        public void GenerateProductSerieByInvBalanceID(int invBalanceID)
        {
            dal.ExecuteStoredProcedure("ICProductSeries_GenerateProductSerieByInvBalanceID", invBalanceID);
        }

        public List<ICProductSeriesInfo> ShowInventoryStockProductSeries(DateTime date, int? departmentID, int? productGroupID, int? productAttributeWoodTypeID, string stockIDs, decimal productHeight, decimal productWidth, decimal productLength)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_ShowInventoryStockProductSeries", date, departmentID, productGroupID, productAttributeWoodTypeID, stockIDs, productHeight, productWidth, productLength);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }
        public List<ICProductSeriesInfo> GetSimilarProductSerieByNo(int? productID, string productSerieNo)
        {
            DataSet ds = dal.GetDataSet("ICProductSeries_GetSimilarProductSerieByNo", productID, productSerieNo);
            return (List<ICProductSeriesInfo>)GetListFromDataSet(ds);
        }
        public ICProductSeriesInfo GetStockAndObjectByProductSerieID(int productID, int stockID, string productSerieNo, DateTime shipmentDate)
        {
            return (ICProductSeriesInfo)dal.GetDataObject("ICProductSeries_GetStockAndObjectByProductSerieID", productID, stockID, productSerieNo, shipmentDate);
        }
    }
    #endregion
}
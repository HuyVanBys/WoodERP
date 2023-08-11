using BOSLib;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BOSLib.Interfaces;
using BOSCommon.Constants;
using System.Drawing;
using System.Net;
using System.IO;

namespace BOSERP
{
    partial class BOSApp
    {
        public static string GetProductNo(ICProductsInfo objProductsInfo, String strModuleName)
        {
            string productNo = GetMainObjectNo(strModuleName, objProductsInfo);
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objProductsInfo.FK_ICDepartmentID);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(objProductsInfo.FK_ICProductAttributeColorID);
            if (objProductGroupsInfo != null)
            {
                objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                productNo = string.Format("{0}{1}", objProductGroupsInfo.ICProductGroupNo, productNo);
            }
            if (objDepartmentsInfo != null)
            {
                productNo = string.Format("{0}{1}", objDepartmentsInfo.ICDepartmentNo, productNo);
            }
            //if (objProductAttributesInfo != null)
            //{
            //    if (!string.IsNullOrEmpty(objProductAttributesInfo.ICProductAttributeAbbreviation) || !string.IsNullOrEmpty(objProductsInfo.ICProductColorAttribute))
            //    {
            //        productNo = string.Format("{0}.{1}", productNo, objProductAttributesInfo.ICProductAttributeAbbreviation);
            //        string[] arrListColor = objProductsInfo.ICProductColorAttribute.Split(',');
            //        string temp = string.Empty;
            //        if (arrListColor.Length > 0 && arrListColor[0] != string.Empty)
            //        {
            //            for (int i = 0; i < arrListColor.Length; i++)
            //            {
            //                objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(int.Parse(arrListColor[i]));
            //                temp = temp + "." + objProductAttributesInfo.ICProductAttributeAbbreviation;
            //            }
            //        }
            //        productNo = productNo + temp;
            //    }
            //}
            return productNo;
        }

        public static String GetMainObjectNo(String strModuleName, BusinessObject MainObject)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(strModuleName, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo != null)
            {
                strMainObjectNo = objGENumberingInfo.GENumberingFormat;
                DateTime currentDate = BOSApp.GetCurrentServerDate();
                BOSDbUtil dbUtil = new BOSDbUtil();

                if ((objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year && objGENumberingInfo.GENumberingPrefixHaveYear)
                            || (objGENumberingInfo.AAUpdatedDate.Month < currentDate.Month && objGENumberingInfo.GENumberingPrefixHaveMonth)
                            || (objGENumberingInfo.AAUpdatedDate.Day < currentDate.Day && objGENumberingInfo.GENumberingPrefixHaveDay))
                {
                    objGENumberingInfo.GENumberingStart = 1;
                }

                strMainObjectNo = strMainObjectNo.Replace("{1}", objGENumberingInfo.GENumberingPrefix);
                if (objGENumberingInfo.GENumberingPrefixHaveYear)
                {
                    strMainObjectNo = strMainObjectNo.Replace("{2}", currentDate.Year.ToString().Substring(2, 2));
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{2}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveMonth)
                {
                    strMainObjectNo = strMainObjectNo.Replace("{3}", currentDate.Month.ToString().PadLeft(2, '0'));
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{3}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveDay)
                {
                    strMainObjectNo = strMainObjectNo.Replace("{4}", currentDate.Day.ToString().PadLeft(2, '0'));
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{4}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveStock)
                {
                    int stockID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ICStockID"));
                    ICStocksInfo objStocksInfo = (ICStocksInfo)(new ICStocksController()).GetObjectByID(stockID);
                    strMainObjectNo = strMainObjectNo.Replace("{5}", objStocksInfo != null ? objStocksInfo.ICStockPrefix : String.Empty);   
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{5}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveBankAbbreviation)
                {
                    int companyBankID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_CSCompanyBankID"));
                    CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)(new CSCompanyBanksController()).GetObjectByID(companyBankID);
                    strMainObjectNo = strMainObjectNo.Replace("{6}", objCompanyBanksInfo != null ? objCompanyBanksInfo.CSCompanyBankAbbreviation : String.Empty);
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{6}", string.Empty);
                }

                objGENumberingInfo.GENumberingFormat = strMainObjectNo;
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
                if (objMainObjectController != null)
                {
                    strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    int numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            return strMainObjectNo;
        }

        public static void UpdateObjectNumbering(String strModuleName)
        {
            GENumberingController objGENumberingController = new GENumberingController();

            //NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], START
            //GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName(strModuleName);
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(strModuleName, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            //List<GENumberingInfo> nuberingList = objGENumberingController.GetNumberingListByName(strModuleName);
            //if (nuberingList.Count == 1)
            //{
            //    objGENumberingInfo = nuberingList[0];
            //}
            //else
            //{
            //    objGENumberingInfo = nuberingList.Where(i => i.FK_BRBranchID == BOSApp.CurrentCompanyInfo.FK_BRBranchID).FirstOrDefault();
            //}
            //NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], END

            if (objGENumberingInfo != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();
                //Reset numberingStart number at the begining of a year                    
                if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                {
                    objGENumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
                }
                objGENumberingInfo.GENumberingStart++;
                objGENumberingInfo.AAUpdatedDate = currentDate;
                objGENumberingController.UpdateObject(objGENumberingInfo);
            }
        }

        #region Database connection
        public static void SwitchConnection(int iBranchID)
        {
            SwitchConnection(iBranchID, false);
        }

        public static void SwitchConnection(int iBranchID, Boolean bDecrypt)
        {
            BRBranchsController branchController = new BRBranchsController();
            BRBranchsInfo objCurrentBranchsInfo = (BRBranchsInfo)branchController.GetObjectByID(iBranchID);

            if (objCurrentBranchsInfo != null)
            {
                if (BOSApp.CurrentCompanyInfo != null)
                {
                    if (objCurrentBranchsInfo.BRBranchID != CurrentCompanyInfo.FK_BRBranchID)
                    {
                        String strDatabase = objCurrentBranchsInfo.BRBranchDatabase;
                        String strServer = objCurrentBranchsInfo.BRBranchServerName;
                        String strUser = objCurrentBranchsInfo.BRBranchDatabaseUser;
                        string strPassword = objCurrentBranchsInfo.BRBranchDatabasePassword;

                        if (bDecrypt)
                        {
                            Crypto cryp = new Crypto();
                            strPassword = cryp.Decrypt(strPassword);
                        }

                        String strBranchConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", strServer, strDatabase, strUser, strPassword);
                        SqlDatabaseHelper.SwitchConnection(strBranchConnectionString);
                    }
                }
            }
        }

        public static void RollbackLocalConnection()
        {
            SqlDatabaseHelper.RollbackToLocalConnection();
        }

        public static bool TestCurrentConnection()
        {
            return SqlDatabaseHelper.TestConnection();
        }

        /// <summary>
        /// Test a connection whether it's available
        /// </summary>
        /// <param name="database">Database object contains the connection</param>
        /// <returns>True if the connection is available, otherwise false</returns>
        public static bool TestConnection(Database database)
        {
            return SqlDatabaseHelper.TestConnection((SqlDatabase)database);
        }

        /// <summary>
        /// Create a connection to a branch, seperate from the current connection
        /// </summary>
        /// <param name="branchID">Branch id</param>
        /// <returns>Database object contains the connection</returns>
        public static SqlDatabase CreateConnectionToBranch(int branchID)
        {
            BRBranchsController objBranchController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchController.GetObjectByID(branchID);
            if (objBranchsInfo != null)
            {
                string strDatabase = objBranchsInfo.BRBranchDatabase;
                string strServer = objBranchsInfo.BRBranchServerName;
                string strUser = objBranchsInfo.BRBranchDatabaseUser;
                string strPassword = objBranchsInfo.BRBranchDatabasePassword;

                string connectionstring = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", strServer, strDatabase, strUser, strPassword);
                return SqlDatabaseHelper.CreateConnection(connectionstring);
            }
            return null;
        }
        #endregion

        /// <summary>
        /// Get the displayed text of a value stored in a table by id or values from system configuration
        /// </summary>
        /// <param name="tableName">Table name contains the value</param>
        /// <param name="columnName">Column name contains the value</param>
        /// <returns>Displayed text</returns>
        public static string GetDisplayedTextByValue(string tableName, string columnName, object value)
        {
            string displayedText = string.Empty;
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (IsForeignKey(tableName, columnName))
            {
                string primaryTableName = GetPrimaryTableWhichForeignColumnReferenceTo(tableName, columnName);
                string primaryKey = GetTablePrimaryColumn(primaryTableName);
                string displayedColumn = String.Format("{0}{1}", primaryKey.Substring(0, primaryKey.Length - 2), "Name");
                try
                {
                    //displayedText = dbUtil.GetPropertyValue(obj, displayedColumn).ToString();
                    displayedText = GetDisplayTextFromCatche(primaryTableName, primaryKey, Convert.ToInt32(value), displayedColumn);
                }
                catch (Exception e)
                {

                }
            }
            else
            {
                string configKeyGroup = string.Empty;
                if (columnName.EndsWith("Combo"))
                {
                    configKeyGroup = columnName.Substring(2, columnName.Length - 7);
                }
                else if (columnName.Length > 2)
                {
                    configKeyGroup = columnName.Substring(2, columnName.Length - 2);
                }
                if (!String.IsNullOrEmpty(configKeyGroup) && ADConfigValueUtility.ConfigValues.Tables[configKeyGroup] != null)
                {
                    displayedText = ADConfigValueUtility.GetConfigTextByGroupAndValue(configKeyGroup, Convert.ToString(value));
                }
                else
                {
                    displayedText = value.ToString();
                }
            }
            return displayedText;
        }

        public static void RoundByCurrency(BusinessObject obj, int currencyID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            GETablesController tableController = new GETablesController();
            List<GETablesInfo> tables = new List<GETablesInfo>();
            if (currencyID > 0 && obj != null)
            {
                string tableName = BOSUtil.GetTableNameFromBusinessObject(obj);

                if (!BOSApp.RoundColTable.ContainsKey(tableName))
                {
                    DataSet ds = tableController.GetTableColumnNamesByTableName(tableName);
                    tables = (List<GETablesInfo>)tableController.GetListFromDataSet(ds);
                    BOSApp.RoundColTable.Add(tableName, ds);
                }
                else
                {
                    DataSet ds = (DataSet)RoundColTable[tableName];
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            GETablesInfo objTablesInfo = new GETablesInfo();
                            objTablesInfo = (GETablesInfo)SqlDatabaseHelper.GetObjectFromDataRow(dr, typeof(GETablesInfo));
                            tables.Add(objTablesInfo);
                        }
                    }
                    ds.Dispose();
                }
                if (tables != null)
                {
                    foreach (GETablesInfo table in tables)
                    {
                        object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                        decimal amount = 0;
                        if (value != null)
                        {
                            if (table != null && table.ColumnName != null)
                            {
                                amount = Convert.ToDecimal(value);
                                if (table.ColumnName.ToString().ToLower().Trim().Contains("unitcost") ||
                                    table.ColumnName.ToString().ToLower().Trim().Contains("totalcost"))
                                {
                                    amount = Math.Round(amount, RoundingNumber.FormatN5, MidpointRounding.AwayFromZero);
                                }
                                else if(table.ColumnName.ToString().ToLower().Trim().Contains("shipmentitemproductqty"))
                                {
                                    amount = Math.Round(amount, RoundingNumber.FormatN6, MidpointRounding.AwayFromZero);
                                }    
                                else
                                {
                                    amount = Math.Round(amount, GetDecimalNumberByCurrencyID(currencyID), MidpointRounding.AwayFromZero);
                                }
                                dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                            }
                        }
                    }
                }
            }
        }


        public static void RoundByCurrency(BusinessObject obj, string columnName, int currencyID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (obj != null)
            {
                object value = dbUtil.GetPropertyValue(obj, columnName);
                decimal amount = 0;
                if (value != null)
                {
                    amount = Convert.ToDecimal(value);
                    amount = Math.Round(amount, GetDecimalNumberByCurrencyID(currencyID), MidpointRounding.AwayFromZero);
                    dbUtil.SetPropertyValue(obj, columnName, amount);
                }
            }
        }

        public static int GetDecimalNumberByCurrencyID(int currencyID)
        {
            int number = 0;
            GECurrenciesController currencyController = new GECurrenciesController();
            GETablesController tableController = new GETablesController();
            List<GECurrenciesInfo> listCrr = new List<GECurrenciesInfo>();
            GECurrenciesInfo currency = new GECurrenciesInfo();

            DataSet ds = (DataSet)BOSApp.LookupTables[TableName.GECurrenyTableName];            
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.GECurrenyTableName);
                BOSApp.LookupTables.Add(TableName.GECurrenyTableName, ds);
            }
            if (ds != null && ds.Tables.Count > 0)
            {
                listCrr = currencyController.GetListDataSet(ds);
                if (listCrr != null)
                {
                    currency = listCrr.Where(x => x.GECurrencyID == currencyID).FirstOrDefault();
                    if (currency != null)
                        number = currency.GECurrencyDecimalNumber;
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return number;
        }
        public static string  GetStringFormatByCurrencyID(int currencyID, bool isGetFormat)
        {
            string FormatString = "N2";
            GECurrenciesController currencyController = new GECurrenciesController();
            GETablesController tableController = new GETablesController();
            List<GECurrenciesInfo> listCrr = new List<GECurrenciesInfo>();
            GECurrenciesInfo currency = new GECurrenciesInfo();

            DataSet ds = (DataSet)BOSApp.LookupTables[TableName.GECurrenyTableName];
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.GECurrenyTableName);
                BOSApp.LookupTables.Add(TableName.GECurrenyTableName, ds);
            }
            if (ds != null && ds.Tables.Count > 0)
            {
                listCrr = currencyController.GetListDataSet(ds);
                if (listCrr != null)
                {
                    currency = listCrr.Where(x => x.GECurrencyID == currencyID).FirstOrDefault();
                    if (currency != null)
                         FormatString = isGetFormat ? currency.STFieldFormatGroupFormatString: currency.STFieldFormatGroupMaskEdit;
                }
            }
            if (string.IsNullOrEmpty(FormatString)) FormatString = "N6";
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            return FormatString;
        }
        public static Image GetProductPictureImageByProductID(int productID)
        {
            if (productID > 0)
            {
                if (BOSApp.CurrentProductList.Count <= 0)
                {
                    ICProductsController productController = new ICProductsController();
                    DataSet ds = productController.GetAllProductsForLookupControl(BOSApp.CurrentCompanyInfo.CSCompanyID);
                    BOSApp.CurrentProductList = productController.GetListViewFromDataSet(ds);
                }

                if (BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == productID) != null)
                {
                    string image = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == productID).ICProductImageFile;

                    return GetProductPictureImageByLink(image);
                }
                else
                    return null;
            }
            else
            {
                return null;
            }    
        }

        public static Image GetProductPictureImageByLink(string linkImage)
        {
            if (string.IsNullOrEmpty(linkImage))
                return null;
            linkImage = linkImage.Replace("/view?usp=sharing", "").Replace("https://drive.google.com/file/d/", "https://drive.google.com/uc?id=");
            Image image = null;
            try
            {
                WebClient webclient = new WebClient();
                webclient.Headers.Add("User-Agent: Other");
                byte[] bytes = webclient.DownloadData(linkImage);
                MemoryStream ms = new MemoryStream(bytes);
                image = Image.FromStream(ms);
            }
            catch
            {
                image = null;
            }
            return image;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSLib
{
    public class ADConfigValueUtility
    {
        #region constant for ADConfigValue
        public const string ADConfigValueAll = "All";
        public const string ADConfigValueSellPrice = "SellPrice";
        public const string ADConfigValueBuyPrice = "BuyPrice";
        public const string ADConfigValuePaymentMethod = "PaymentMethod";
        public const string ADConfigValueCustomerType = "CustomerType";
        public const string ADConfigValueConfigProductionComplexityType = "ConfigProductionComplexityType";
        public const string ADConfigValueCustomerInvoiceType = "CustomerInvoiceType";
        public const string ADConfigValueCustomerOrderType = "CustomerOrderType";
        public const string ADConfigValueSupplierType = "SupplierType";
        public const string ADConfigValueProductCostingMethod = "ProductCostingMethod";
        public const string ADConfigValueProductType = "ProductType";
        public const string ADConfigValueStockType = "StockType";
        public const string ADConfigValueContactType = "ContactType";
        public const string ADConfigValueSellOrderItemType = "SellOrderItemType";
        public const string ADConfigValueShipmentType = "ShipmentType";
        public const string ADConfigValueReceiptType = "ReceiptType";

        public const string ADConfigValuePOSType = "POSType";
        public const string ADConfigValuePOSStatus = "POSStatus";
        public const string ADConfigValueTransferType = "TransferType";

        public const string ADConfigValueLayBy = "LayBy";
        public const string ADConfigValueWorkingShift = "EmployeeWorkingShift";
        public const string ADConfigValueCreditNote = "CreditNote";

        public const string ADConfigValueRegionState = "AddressStateProvince";
        public const string ADConfigValueRegionPostCode = "AddressPostalCode";
        public const string ADConfigValueListOfSalesChannelType = "ListOfSalesChannelType";
        public const string ADConfigValueSourceSellingPriceType = "SourceSellingPriceType";
        public const string ADConfigValueProductStorageCondition = "ProductStorageCondition";
        public const string ADConfigValueProductTrademark = "ProductTrademark";
        public const string ADConfigValueProductCollection = "ProductCollection";
        #endregion     

        #region ContactType Constant
        public const string cstContactTypeInvoice = "Invoice";
        public const string cstContactTypeProposal = "Proposal";
        public const string cstContactTypeSaleOrder = "SaleOrder";
        public const string cstContactTypePurchaseOrder = "PurchaseOrder";
        public const string cstContactTypeDelivery = "Delivery";
        public const string cstContactTypeReceipt = "Receipt";
        public const string cstContactTypeSaleReturn = "SaleReturn";
        public const string cstContactTypeCreditNote = "CreditNote";
        public const string cstContactTypeInvoiceCopy = "InvoiceCopy";
        public const string cstContactTypeProposalCopy = "ProposalCopy";
        public const string cstContactTypeSaleOrderCopy = "SaleOrderCopy";
        public const string cstContactTypeDeliveryCopy = "DeliveryCopy";
        public const string cstContactTypeReceiptCopy = "ReceiptCopy";
        public const string cstContactTypeSaleReturnCopy = "SaleReturnCopy";
        public const string cstContactTypeCreditNoteCopy = "CreditNoteCopy";
        #endregion

        #region Constant HistoryAction
        public const string cstHistoryActionCreate = "Create";
        public const string cstHistoryActionChange = "Change";
        public const string cstHistoryActionGenerate = "Generate";
        #endregion

        #region Constant for Proposal
        #region ProposalType Constant
        public const string cstProposalTypeManual = "Manual";
        #endregion

        #region ProposalStatus Constant
        public const string cstProposalStatusNew = "New";
        public const string cstProposalStatusIncomplete = "Incomplete";
        public const string cstProposalStatusComplete = "Complete";
        #endregion

        #region ProposalRelate Constant
        public const string cstProposalRelateManual = "Manual";
        public const string cstProposalRelateSellOrder = "SellOrder";
        #endregion        
        #endregion

        #region Constant for Commission

        #region CommissionType Constant
        public const string cstCommissionTypeManual = "Manual";
        public const string cstCommissionTypeFromSellOrder = "FromSellOrder";
        #endregion

        #region CommissionStatus Constant
        public const string cstCommissionStatusNew = "New";
        public const string cstCommissionStatusIncomplete = "Incomplete";
        public const string cstCommissionStatusComplete = "Complete";
        #endregion

        #region CommissionRelate Constant
        public const string cstCommissionRelateManual = "Manual";
        public const string cstCommissionRelateSellOrder = "SellOrder";
        public const string cstCommissionRelateShipment = "Shipment";
        #endregion

        #endregion

        #region Constant for SellReturn

        #region SellReturnType Constant
        public const string cstSellReturnTypeManual = "Manual";
        public const string cstSellReturnTypeFromInvoice = "FromInvoice";
        public const string cstSellReturnTypeFromCreditNote = "FromCreditNote";
        #endregion

        #region SellReturnStatus Constant
        public const string cstSellReturnStatusNew = "New";
        public const string cstSellReturnStatusIncomplete = "Incomplete";
        public const string cstSellReturnStatusComplete = "Complete";
        #endregion

        #region SellReturnRelate Constant
        public const string cstSellReturnRelateManual = "Manual";
        public const string cstSellReturnRelateInvoice = "Invoice";
        public const string cstSellReturnRelateCreditNote = "CreditNote";
        public const string cstSellReturnRelateReceipt = "Receipt";
        #endregion
        #endregion

        #region Constant for CreditNote
        #region CreditNoteType constant
        public const string cstCreditNoteTypeManual = "Manual";
        public const string cstCreditNoteTypeFromSellReturn = "FromSellReturn";
        public const string cstCreditNoteTypeFromInvoice = "FromInvoice";
        public const string cstCreditNoteTypeFromInvoiceAffectStock = "FromInvoiceAffectStock";
        #endregion

        #region CreditNoteStatus constant
        public const string cstCreditNoteStatusNew = "New";
        public const string cstCreditNoteStatusIncomplete = "Incomplete";
        public const string cstCreditNoteStatusComplete = "Complete";
        #endregion

        #region CreditNoteRelate Constant
        public const string cstCreditNoteRelateManual = "Manual";
        public const string cstCreditNoteRelateReceipt = "Receipt";
        public const string cstCreditNoteRelateInvoice = "Invoice";
        #endregion        
        #endregion

        #region Constant for Transaction Type
        public const string cstTransactionTypeProposal = "Proposal";
        public const string cstTransactionTypeSellOrder = "SellOrder";
        public const string cstTransactionTypeCommission = "Commission";
        public const string cstTransactionTypeShipment = "Shipment";
        public const string cstTransactionTypeInvoice = "Invoice";
        public const string cstTransactionTypePurchaseOrder = "PurchaseOrder";
        public const string cstTransactionTypeReceipt = "Receipt";
        public const string cstTransactionTypeSellReturn = "SellReturn";
        public const string cstTransactionTypeCreditNote = "CreditNote";
        public const string cstTransactionTypeTransfer = "Transfer";
        public const string cstTransactionTypeTransferStockIn = "TransferStockIn";
        public const string cstTransactionTypeTransferStockOut = "TransferStockOut";
        public const string cstTransactionTypeZerlegung = "Zerlegung";
        public const string cstTransactionTypeRezeptur = "Rezeptur";

        #endregion

        #region Constant for SupplierType
        public const string cstStatusActiv = "StatusActiv";
        public const string cstStatusInActiv = "StatusInActiv";
        #endregion

        #region Constant ItemType
        public const string cstItemTypeProduct = "Product";
        public const string cstItemTypeText = "Text";
        #endregion

        #region Constant for Open Document
        public const string cstOpenDocumentTypeSaleReceipt = "SaleReceipt";
        public const string cstOpenDocumentTypeGoodsRefund = "GoodsRefund";
        public const string cstOpenDocumentTypeLayBy = "LayBy";
        public const string cstOpenDocumentTypeSaleOrder = "SaleOrder";
        public const string cstOpenDocumentTypeServiceReceipt = "ServiceReceipt";
        public const string cstOpenDocumentTypeMedicationReceipt = "MedicationReceipt";

        public const string cstOpenDocumentStatusNew = "New";
        public const string cstOpenDocumentStatusCancel = "Cancel";
        public const string cstOpenDocumentStatusComplete = "Complete";
        #endregion

        #region Constant for Payment Method
        public const String cstPaymentMethodCash = "Cash";
        public const String cstPaymentMethodEFTPOS = "EFTPOS";
        public const String cstPaymentMethodCheck = "Check";
        public const String cstPaymentMethodCreditCard = "CreditCard";
        public const String cstPaymentMethodAccount = "Account";
        public const String cstPaymentMethodCreditNote = "CreditNote";
        public const String cstPaymentMethodGiftVoucher = "GiftVoucher";
        #endregion

        #region Constant for Stock Type
        public const string cstStockTypeCentral = "Central";
        public const string cstStockTypeBranch = "Branch";
        public const string cstStockTypeMaintenance = "Maintenance";
        public const string cstStockTypeRedemption = "Redemption";
        public const string cstStockTypeTransit = "Transit";
        #endregion

        #region Constant for Source Selling Price Method
        public const string cstSourceSellingPriceMethodMasterData = "MasterData";
        public const string cstSourceSellingPriceMethodPriceSheet = "PriceSheet";
        #endregion

        /// <summary>
        /// Gets or sets all config values of the application
        /// </summary>
        public static DataSet ConfigValues { get; set; }

        public static readonly String ADConfigValueTable = "ADConfigValues";

        static ADConfigValueUtility()
        {
            ConfigValues = new DataSet();
        }

        public static void UpdateValueToADConfigValueTable(String strKey, String strText)
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                String strUpdateQuery = String.Format("UPDATE [ADConfigValues] SET [ADConfigText]='{0}' WHERE [ADConfigKey]='{1}'", strText, strKey);
                dbUtil.ExecuteQuery(strUpdateQuery);
            }
            catch (Exception)
            {
                MessageBox.Show("CommonLocalizedResources.MessageBoxDefaultCaption Exception");
            }
        }

        public static DataTable InitConfigValueTableStructure(String strConfigKey)
        {
            DataTable tbl = new DataTable(strConfigKey);
            DataColumn columnKey = new DataColumn();
            DataColumn[] Keys = new DataColumn[1];
            columnKey.ColumnName = "Key";
            columnKey.DataType = typeof(string);

            tbl.Columns.Add(columnKey);
            //Keys[0] = columnKey;

            DataColumn columnKeyValue = new DataColumn();
            columnKeyValue.ColumnName = "Value";
            columnKeyValue.DataType = typeof(string);
            tbl.Columns.Add(columnKeyValue);


            DataColumn columnText = new DataColumn();
            columnText.ColumnName = "Text";
            columnText.DataType = typeof(string);

            tbl.Columns.Add(columnText);
            //tbl.PrimaryKey = Keys;

            return tbl;
        }

        public static DataTable InitConfigValueTable(String strADConfigValueGroup)
        {
            //[NUThao] [Improve Speed] [2014-09-09]
            //DataTable tbl = InitConfigValueTableStructure(strADConfigValueGroup);
            //if (strADConfigValueGroup == ADConfigValueAll)
            //{
            //    strADConfigValueGroup = string.Empty;
            //}
            //BOSDbUtil dbUtil = new BOSDbUtil(); 
            //ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            //DataSet dsADConfigValues = objConfigValuesController.GetADConfigValuesByGroup(strADConfigValueGroup);

            //if (dsADConfigValues.Tables.Count > 0)
            //{                
            //    foreach (DataRow row in dsADConfigValues.Tables[0].Rows)
            //    {
            //        ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
            //        if (objConfigValuesInfo.IsActive)
            //        {
            //            tbl.Rows.Add(new object[3] { objConfigValuesInfo.ADConfigKey, objConfigValuesInfo.ADConfigKeyValue, objConfigValuesInfo.ADConfigText });
            //        }
            //    }
            //}
            //return tbl;

            //[NUThao] [Improve Speed] [2014-09-09]

            DataTable tbl = null;
            if (strADConfigValueGroup == ADConfigValueAll)
            {
                strADConfigValueGroup = string.Empty;
            }
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet dsADConfigValues = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(strADConfigValueGroup);
            if (dsADConfigValues.Tables.Count > 0)
            {
                tbl = dsADConfigValues.Tables[0].Copy();
                if (tbl != null)
                {
                    tbl.TableName = strADConfigValueGroup;
                    tbl.PrimaryKey = new DataColumn[] { tbl.Columns[0] };
                }
            }
            return tbl;
        }
        public static DataTable InitConfigValueTable(String strADConfigValueGroup, DataSet dsADConfigValues)
        {
            DataTable tbl = new DataTable();
            if (strADConfigValueGroup == ADConfigValueAll)
            {
                strADConfigValueGroup = string.Empty;
            }
            if (dsADConfigValues.Tables.Count > 0)
            {

                var obj = (from row in dsADConfigValues.Tables[0].AsEnumerable()
                           where row.Field<String>("ADConfigKeyGroup") == strADConfigValueGroup
                           select new String[]
                           {
                              row.Field<String>("ADConfigKey")
                               ,
                              row.Field<String>("ADConfigKeyValue")
                               ,
                              row.Field<String>("ADConfigText")
                           }).ToArray();
                if (obj != null && obj.Length > 0)
                {
                    try
                    {
                        tbl.Columns.Add(new DataColumn("Key"));
                        tbl.Columns.Add(new DataColumn("Value"));
                        tbl.Columns.Add(new DataColumn("Text"));

                        var iFila = obj.GetLongLength(0);
                        var iCol = 3;

                        for (var f = 0; f < iFila; f++)
                        {
                            var row = tbl.Rows.Add();
                            for (var c = 0; c < iCol; c++)
                            {
                                row[c] = obj[f][c];
                            }
                        }
                        tbl.TableName = strADConfigValueGroup;
                        tbl.PrimaryKey = new DataColumn[] { tbl.Columns[0] };
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                }
            }
            return tbl;
        }

        public static String GetTextFromKey(String strKey, String strConfigValueTableName)
        {
            if (ConfigValues.Tables[strConfigValueTableName] != null)
                foreach (DataRow row in ConfigValues.Tables[strConfigValueTableName].Rows)
                {
                    if (row["Key"] != null && row["Key"].ToString() == strKey)
                        return row["Text"].ToString();
                }
            return String.Empty;
        }


        public static String GetTextFromKey(String strKey)
        {
            foreach (DataTable tblConfigValues in ConfigValues.Tables)
            {
                foreach (DataRow row in tblConfigValues.Rows)
                {
                    if (row["Key"].ToString() == strKey)
                        return row["Text"].ToString();
                }
            }

            return String.Empty;
        }

        public static void InitGlobalConfigValueTables()
        {
            ConfigValues.Tables.Clear();
            ConfigValues.Clear();

            ADConfigValuesController objADConfigValuesController = new ADConfigValuesController();
            List<String> lstADConfigValueGroups = objADConfigValuesController.GetADConfigValueGroups();
            DataSet dsConfig = objADConfigValuesController.GetAllActiveConfigValues();
            foreach (String strADConfigValueGroup in lstADConfigValueGroups)
            {
                if (!String.IsNullOrEmpty(strADConfigValueGroup))
                {
                    DataTable tbl = InitConfigValueTable(strADConfigValueGroup, dsConfig);
                    if (tbl != null)
                    {
                        ConfigValues.Tables.Add(tbl);
                        DataTable tblSearch = tbl.Copy();
                        tblSearch.TableName = strADConfigValueGroup + "Search";
                        DataRow dummyRow = tblSearch.NewRow();
                        dummyRow["Key"] = String.Empty;
                        dummyRow["Value"] = String.Empty;
                        dummyRow["Text"] = String.Empty;
                        tblSearch.Rows.InsertAt(dummyRow, 0);
                        ConfigValues.Tables.Add(tblSearch);
                    }
                }
            }
        }

        /// <summary>
        /// Get first config value of a group
        /// </summary>
        /// <param name="group">Group name</param>
        /// <returns>Value in string format</returns>
        public static string GetFirstConfigValueByGroup(string group)
        {
            if (ConfigValues.Tables[group] != null && ConfigValues.Tables[group].Rows.Count > 0)
            {
                return ConfigValues.Tables[group].Rows[0]["Value"].ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// Get a config displayed text by its group and value
        /// </summary>
        /// <param name="group">Group</param>
        /// <param name="value">Value</param>
        /// <returns>Displayed text of the config value</returns>
        public static string GetConfigTextByGroupAndValue(string group, string value)
        {
            if (ConfigValues.Tables[group] != null)
            {
                foreach (DataRow row in ConfigValues.Tables[group].Rows)
                {
                    if (value == Convert.ToString(row["Value"]))
                    {
                        return Convert.ToString(row["Text"]);
                    }
                }
            }
            return string.Empty;
        }
    }
}




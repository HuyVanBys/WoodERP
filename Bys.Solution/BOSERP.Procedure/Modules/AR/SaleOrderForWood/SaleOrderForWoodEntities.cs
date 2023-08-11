using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Transactions;

namespace BOSERP.Modules.SaleOrderForWood
{
    public class SaleOrderForWoodEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets history detail list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        public BOSItemsEntityList<ARSaleOrderItemsInfo> ARSaleOrderItemsList { get; set; }

        public BOSList<ARCustomerPaymentDetailsInfo> ARCustomerPaymentDetailsList { get; set; }

        public SortedList<int, ARProposalItemsInfo> ARReferenceProposalItems { get; set; }

        public BOSList<ARSaleOrderTemplatesInfo> SaleOrderTemplatesList { get; set; }

        /// <summary>
        /// Gets or sets document payment list
        /// </summary>
        public BOSList<ARDocumentPaymentsInfo> DocumentPaymentList { get; set; }

        /// <summary>
        /// Gets or sets sale order item list including the item's components
        /// </summary>
        public BOSItemsEntityList<ARSaleOrderItemsInfo> ComponentSaleOrderItemList { get; set; }

        //TNDLoc [ADD][07/11/2015][Sale Payment Process],START
        public BOSList<ARSaleOrderPaymentTimesInfo> ARSaleOrderPaymentTimesList { get; set; }
        //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
        //NNGIANG [ADD][20/01/2016],START
        public BOSList<ARSaleOrderItemsInfo> LumberWoodList { get; set; }
        public BOSList<ARSaleOrderItemsInfo> RoundWoodList { get; set; }
        //NNGIANG [ADD][20/01/2016],END

        #endregion

        #region Constructor
        public SaleOrderForWoodEntities()
            : base()
        {
            ARSaleOrderItemsList = new BOSItemsEntityList<ARSaleOrderItemsInfo>();

            ARReferenceProposalItems = new SortedList<int, ARProposalItemsInfo>();

            SaleOrderTemplatesList = new BOSList<ARSaleOrderTemplatesInfo>();

            DocumentPaymentList = new BOSList<ARDocumentPaymentsInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();

            ComponentSaleOrderItemList = new BOSItemsEntityList<ARSaleOrderItemsInfo>();

            //TNDLoc [ADD][07/11/2015][Sale Payment Process],START
            ARSaleOrderPaymentTimesList = new BOSList<ARSaleOrderPaymentTimesInfo>();
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
            //NNGIANG [ADD][20/01/2016],START
            LumberWoodList = new BOSList<ARSaleOrderItemsInfo>();
            RoundWoodList = new BOSList<ARSaleOrderItemsInfo>();
            //NNGIANG [ADD][20/01/2016],END
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

            MainObject = new ARSaleOrdersInfo();
            SearchObject = new ARSaleOrdersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARSaleOrderItemsTableName, new ARSaleOrderItemsInfo());
            ModuleObjects.Add(TableName.ARDocumentPaymentsTableName, new ARDocumentPaymentsInfo());
            ModuleObjects.Add(TableName.ARSaleOrderTemplatesTableName, new ARSaleOrderTemplatesInfo());
        }

        public override void InitModuleObjectList()
        {
            ARSaleOrderItemsList = new BOSItemsEntityList<ARSaleOrderItemsInfo>();
            ARSaleOrderItemsList.InitBOSList(this, TableName.ARSaleOrdersTableName, TableName.ARSaleOrderItemsTableName);

            DocumentPaymentList.InitBOSList(
                                          this,
                                          string.Empty,
                                          TableName.ARDocumentPaymentsTableName,
                                          BOSList<ARInvoicesInfo>.cstRelationNone);
            HistoryDetailList.InitBOSList(this,
                                           TableName.GEObjectHistoryTableName,
                                           TableName.GEHistoryDetailsTableName,
                                           BOSList<GEHistoryDetailsInfo>.cstRelationForeign);

            ComponentSaleOrderItemList.InitBOSList(
                                                this,
                                                TableName.ARSaleOrdersTableName,
                                                TableName.ARSaleOrderItemsTableName,
                                                BOSList<ARSaleOrderItemsInfo>.cstRelationForeign);
            ComponentSaleOrderItemList.ItemTableForeignKey = "FK_ARSaleOrderID";

            SaleOrderTemplatesList.InitBOSList(this,
                                                TableName.ARSaleOrdersTableName,
                                                TableName.ARSaleOrderTemplatesTableName,
                                                BOSList<ARSaleOrderTemplatesInfo>.cstRelationForeign);
            SaleOrderTemplatesList.ItemTableForeignKey = "FK_ARSaleOrderID";
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],START
            ARSaleOrderPaymentTimesList.InitBOSList(
                                              this,
                                              TableName.ARSaleOrdersTableName,
                                              TableName.ARSaleOrderPaymentTimesTableName,
                                              BOSList<ARSaleOrderPaymentTimesInfo>.cstRelationForeign);
            ARSaleOrderPaymentTimesList.ItemTableForeignKey = "FK_ARSaleOrderID";
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
            //NNGIANG [ADD][20/01/2016],START
            LumberWoodList.InitBOSList(
                                                this,
                                                TableName.ARSaleOrdersTableName,
                                                TableName.ARSaleOrderItemsTableName,
                                                BOSList<ARSaleOrderItemsInfo>.cstRelationForeign);
            LumberWoodList.ItemTableForeignKey = "FK_ARSaleOrderID";
            RoundWoodList.InitBOSList(
                                               this,
                                               TableName.ARSaleOrdersTableName,
                                               TableName.ARSaleOrderItemsTableName,
                                               BOSList<ARSaleOrderItemsInfo>.cstRelationForeign);
            RoundWoodList.ItemTableForeignKey = "FK_ARSaleOrderID";
            //NNGIANG [ADD][20/01/2016],END
        }

        public override void InitGridControlInBOSList()
        {
            ARSaleOrderItemsList.InitBOSListGridControl();
            HistoryDetailList.InitBOSListGridControl();
            DocumentPaymentList.InitBOSListGridControl();
            SaleOrderTemplatesList.InitBOSListGridControl();
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],START
            ARSaleOrderPaymentTimesList.InitBOSListGridControl();
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
            //NNGIANG [ADD][20/01/2016],START
            LumberWoodList.InitBOSListGridControl("LumberGridControl");
            RoundWoodList.InitBOSListGridControl("RoundWoodGridControl");
            //NNGIANG [ADD][20/01/2016],END
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ARSaleOrderItemsList.SetDefaultListAndRefreshGridControl();
                DocumentPaymentList.SetDefaultListAndRefreshGridControl();
                ComponentSaleOrderItemList.SetDefaultListAndRefreshGridControl();
                SaleOrderTemplatesList.SetDefaultListAndRefreshGridControl();
                //TNDLoc [ADD][07/11/2015][Sale Payment Process],START
                ARSaleOrderPaymentTimesList.SetDefaultListAndRefreshGridControl();
                //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
                //NNGIANG [ADD][20/01/2016],START
                RoundWoodList.SetDefaultListAndRefreshGridControl();
                LumberWoodList.SetDefaultListAndRefreshGridControl();
                //NNGIANG [ADD][20/01/2016],END
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            objSaleOrdersInfo.ARSaleOrderTypeCombo = SaleOrderType.SaleOrder.ToString();
            objSaleOrdersInfo.ARSaleOrderBatchStatus = string.Empty;
            objSaleOrdersInfo.ARSaleOrderDate = DateTime.Now;
            objSaleOrdersInfo.ARSaleOrderDeliveryDate = DateTime.Now;
            objSaleOrdersInfo.ARSaleOrderValidateDate = DateTime.Now;
            objSaleOrdersInfo.ARSaleOrderStatus = SaleOrderStatus.New.ToString();
            objSaleOrdersInfo.FK_ARPriceLevelID = 1;
            objSaleOrdersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSaleOrdersInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objSaleOrdersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objSaleOrdersInfo.ARSaleOrderExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objSaleOrdersInfo.ARSaleOrderMainSellerCommissionPercent = 100;
            objSaleOrdersInfo.ARSaleOrderType = SaleOrderType.MassProduction.ToString();
            string a = objSaleOrdersInfo.ARSaleOrderProductType;
            objSaleOrdersInfo.FK_GEPaymentTermID = 1;
            objSaleOrdersInfo.FK_GECurrencyID2 = 100001;
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions


        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARSaleOrderItemsController objPurchaseOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            DataSet ds = objPurchaseOrderItemsController.GetAllDataBySaleOrderID(iObjectID);
            if (objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Hardware.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.IngredientPackaging.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.IngredientPaint.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.SemiProduct.ToString() ||
                     objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Other.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == string.Empty)
            {
                ARSaleOrderItemsList.Invalidate(ds);
            }
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in ARSaleOrderItemsList)
            {
                objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                objSaleOrderItemsInfo.ARSOItemComponentList.InitBOSList(
                                                                    this,
                                                                    TableName.ARSaleOrderItemsTableName,
                                                                    TableName.ARSOItemComponentsTableName,
                                                                    BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                objSaleOrderItemsInfo.ARSOItemComponentList.ItemTableForeignKey = "FK_ARSaleOrderItemID";

                ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
                List<ARSOItemComponentsInfo> components = objSOItemComponentsController.GetSOItemComponentListBySOItemID(objSaleOrderItemsInfo.ARSaleOrderItemID);
                objSaleOrderItemsInfo.ARSOItemComponentList.Invalidate(components);
            }

            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            {
                entItem.ARSaleOrderItemRemainedQty = entItem.ARSaleOrderItemProductQty - entItem.ARSaleOrderItemCanceledQty - entItem.ARSaleOrderItemShippedQty;
            }

            //Invalidate document payment list by sale order no
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            //ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            List<ARDocumentPaymentsInfo> payments = objDocumentPaymentsController.GetDocumentPaymentsBySaleOrderNo(objSaleOrdersInfo.ARSaleOrderNo);
            DocumentPaymentList.Invalidate(payments);

            //Invalidate item components
            InvalidateItemComponents();

            ComponentSaleOrderItemList.BackupList.Clear();
            if (objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Confirmed.ToString() ||
                objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Incomplete.ToString())
            {
                foreach (ARSaleOrderItemsInfo item in ComponentSaleOrderItemList)
                {
                    ComponentSaleOrderItemList.BackupList.Add((ARSaleOrderItemsInfo)item.Clone());
                }
            }

            //Invalidate sale order templates list
            SaleOrderTemplatesList.Invalidate(iObjectID);
            foreach (ARSaleOrderTemplatesInfo objSaleOrderTemplatesInfo in SaleOrderTemplatesList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objBaseTransactionModule.GetEmployeeByUsername(objSaleOrderTemplatesInfo.AACreatedUser);
                string SaleOrderID = objSaleOrderTemplatesInfo.FK_ARSaleOrderID.ToString();
                objSaleOrderTemplatesInfo.ARSaleOrderTemplateName = objSaleOrderTemplatesInfo.ARSaleOrderTemplateName.Replace(SaleOrderID + "_", "");
                objSaleOrderTemplatesInfo.UserCreatedFullname = objEmployeesInfo.HREmployeeName;
            }

            //TNDLoc [ADD][07/11/2015][Sale Payment Process],START
            ARSaleOrderPaymentTimesList.Invalidate(iObjectID);
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
            //NNGIANG [ADD][20/01/2016],START
            if (objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.DryLumber.ToString() ||
                objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.FreshLumber.ToString() ||
                objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Verneer.ToString() ||
                objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.ArtificialBoard.ToString())
            {
                LumberWoodList.Invalidate(iObjectID);
            }
            foreach (ARSaleOrderItemsInfo entItem in LumberWoodList)
            {
                entItem.ARSaleOrderItemRemainedQty = entItem.ARSaleOrderItemProductQty - entItem.ARSaleOrderItemCanceledQty - entItem.ARSaleOrderItemShippedQty;
            }
            if (objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Roundwood.ToString())
            {
                RoundWoodList.Invalidate(iObjectID);
            }
            foreach (ARSaleOrderItemsInfo entItem in RoundWoodList)
            {
                entItem.ARSaleOrderItemRemainedQty = entItem.ARSaleOrderItemProductQty - entItem.ARSaleOrderItemCanceledQty - entItem.ARSaleOrderItemShippedQty;
            }
            //NNGIANG [ADD][20/01/2016],END
            //NHAnh [ADD][5/12/2015] START
            if (objSaleOrdersInfo.ARSaleOrderTypeCombo == SaleOrderType.SaleForecast.ToString())
            {
                ((SaleOrderForWoodModule)Module).OrderTypeLookupEditControl.Enabled = true;
                ((SaleOrderForWoodModule)Module).TTMTLookupEditControl.Enabled = true;
                ((SaleOrderForWoodModule)Module).OrderPONoTextBoxControl.Enabled = true;
            }
            else
            {
                ((SaleOrderForWoodModule)Module).OrderTypeLookupEditControl.Enabled = false;
                ((SaleOrderForWoodModule)Module).TTMTLookupEditControl.Enabled = false;
                ((SaleOrderForWoodModule)Module).OrderPONoTextBoxControl.Enabled = false;
            }
            //NHAnh [ADD][5/12/2015] END

        }

        #endregion

        #region Save Module Objects functions

        public string GetMainObjectNo()
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            int numberingStart = 0;
            //NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], START
            //GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName(Module.Name);
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID("SaleOrder", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            //List<GENumberingInfo> nuberingList = objGENumberingController.GetNumberingListByName(Module.Name);
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
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
                if (objMainObjectController != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    DateTime currentDate = BOSApp.GetCurrentServerDate();

                    //Reset numberingStart number at the begining of a year                    
                    //int numberStart = objGENumberingInfo.GENumberingStart;

                    if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                    {
                        objGENumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
                    }

                    strMainObjectNo = String.Format("{0}{1}.{2}",
                                                    objGENumberingInfo.GENumberingPrefix,
                                                    currentDate.Year.ToString().Substring(2, 2),
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = String.Format("{0}{1}.{2}",
                                                        objGENumberingInfo.GENumberingPrefix,
                                                        currentDate.Year.ToString().Substring(2, 2),
                                                        objGENumberingInfo.GENumberingStart);
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            objGENumberingInfo.GENumberingStart++;
            objGENumberingController.UpdateObject(objGENumberingInfo);
            return strMainObjectNo;
        }
        public override string GetMainObjectNo(ref int numberingStart)
        {
            //  string mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            string mainObjectNo = GetMainObjectNo();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            string[] objectNo = mainObjectNo.Split('-');
            if (objectNo != null && objectNo.Length > 1)
            {
                //if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.FOCSample.ToString() ||
                //    objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.PaymentSample.ToString() ||
                //    objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.PaymentSpareSample.ToString() ||
                //    objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.SpareFOCSample.ToString() ||
                //    objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.Proposal.ToString() ||
                //    objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.MassProduction.ToString())
                //{

                //    mainObjectNo = "PI." + objSaleOrdersInfo.ARSaleOrderType + "-" + objectNo[1];
                //}
                if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.MassProduction.ToString())
                {
                    mainObjectNo = "PI." + "M" + "-" + objectNo[1];
                }
                if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.PaymentSample.ToString())
                {
                    mainObjectNo = "PI." + "S" + "-" + objectNo[1];
                }
                if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.FOCSample.ToString())
                {
                    mainObjectNo = "PI." + "SF" + "-" + objectNo[1];
                }
                if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.PaymentSpareSample.ToString())
                {
                    mainObjectNo = "PI." + "SP" + "-" + objectNo[1];
                }
                if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderType == SaleOrderType.SpareFOCSample.ToString())
                {
                    mainObjectNo = "PI." + "SPF" + "-" + objectNo[1];
                }


            }
            return mainObjectNo;
        }
        public override void SaveModuleObjects()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            if (objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Hardware.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.IngredientPackaging.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.IngredientPaint.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.SemiProduct.ToString() ||
                     objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Other.ToString() ||
                    objSaleOrdersInfo.ARSaleOrderProductType == string.Empty)
            {
                ARSaleOrderItemsList.SaveItemObjects();
            }

            // Save sale order item component list
            SaveSOItemComponentList(ARSaleOrderItemsList);
            SaleOrderTemplatesList.SaveItemObjects();
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],START
            foreach (var item in ARSaleOrderPaymentTimesList)
            {
                item.ARSaleOrderPaymentTimeDueDate = DateTime.Parse(item.ARSaleOrderPaymentTimeDueDate.ToShortDateString());
                item.ARSaleOrderPaymentTimeDate = DateTime.Parse(item.ARSaleOrderPaymentTimeDate.ToShortDateString());
            }
            ARSaleOrderPaymentTimesList.SaveItemObjects();
            //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
            if (objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.DryLumber.ToString() ||
                objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.FreshLumber.ToString() ||
                objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Verneer.ToString() ||
                objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.ArtificialBoard.ToString())
            {
                LumberWoodList.SaveItemObjects();
            }
            if (objSaleOrdersInfo.ARSaleOrderProductType == SaleOrderProductType.Roundwood.ToString())
            {
                RoundWoodList.SaveItemObjects();
            }
        }

        /// <summary>
        /// Save sale order item component list
        /// </summary>
        /// <param name="saleOrderItems">List of sale order item component</param>
        public void SaveSOItemComponentList(BOSItemsEntityList<ARSaleOrderItemsInfo> saleOrderItems)
        {
            foreach (ARSaleOrderItemsInfo itemEntity in saleOrderItems)
            {
                if (itemEntity.ARSOItemComponentList != null)
                {
                    foreach (ARSOItemComponentsInfo objSOItemComponentsInfo in itemEntity.ARSOItemComponentList)
                    {
                        objSOItemComponentsInfo.FK_ARSaleOrderItemID = itemEntity.ARSaleOrderItemID;
                    }
                    itemEntity.ARSOItemComponentList.SaveItemObjects();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void GenerateEntitiesFromSaleForecast(ARSaleForecastsInfo objSaleForecastsInfo, List<ARSaleForecastItemsInfo> saleForecastItemList)
        {

            //Generate SaleOrder            
            GenerateSaleOrderFromSaleForecast(objSaleForecastsInfo);

            //Generate SaleOrder items
            GenerateSaleOrderItemsFromSaleForecast(saleForecastItemList);

            UpdateTotalAmount(ARSaleOrderItemsList);
        }

        /// <summary>
        /// Generate an SaleOrder from a given sale order and set to main object
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale forecast</param>
        private void GenerateSaleOrderFromSaleForecast(ARSaleForecastsInfo objSaleForecastsInfo)
        {
            //Copy SaleOrder
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ARSaleOrdersInfo oldSaleOrder = (ARSaleOrdersInfo)MainObject.Clone();
            BOSUtil.CopyObject(objSaleForecastsInfo, objSaleOrdersInfo);

            //Recalculate deposit balance of the SaleOrder
            ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
            decimal totalSaleOrderDeposit = objSaleForecastsController.GetTotalInvoiceDeposit(objSaleForecastsInfo.ARSaleForecastID);
            //decimal owingExchangeAmount = objSaleForecastsController.GetTotalDeposit(objSaleForecastsInfo.ARSaleForecastID, PaymentMethod.OwingExchange.ToString());
            //owingExchangeAmount = Math.Max(owingExchangeAmount - totalSaleOrderDeposit, 0);
            objSaleOrdersInfo.ARSaleOrderDepositBalance = objSaleForecastsInfo.ARSaleForecastDepositBalance - totalSaleOrderDeposit;
            // objSaleOrdersInfo.ARSaleOrderOwingExchangeAmount = Math.Min(objSaleOrdersInfo.ARSaleOrderDepositBalance - totalSaleOrderDeposit, owingExchangeAmount);
            objSaleOrdersInfo.FK_ICProductAttributeTTMTID = oldSaleOrder.FK_ICProductAttributeTTMTID;
            //Restore some its own properties
            objSaleOrdersInfo.ARSaleOrderBatchStatus = string.Empty;
            objSaleOrdersInfo.ARSaleOrderNo = oldSaleOrder.ARSaleOrderNo;
            objSaleOrdersInfo.ARSaleOrderName = oldSaleOrder.ARSaleOrderName;
            objSaleOrdersInfo.ARSaleOrderDesc = oldSaleOrder.ARSaleOrderDesc;
            // objSaleOrdersInfo.ARSaleOrderComment = oldSaleOrder.ARSaleOrderComment;
            //objSaleOrdersInfo.ARSaleOrderTypeCombo = oldSaleOrder.ARSaleOrderTypeCombo;
            objSaleOrdersInfo.ARSaleOrderStatus = oldSaleOrder.ARSaleOrderStatus;
            objSaleOrdersInfo.ARSaleOrderDate = oldSaleOrder.ARSaleOrderDate;
            objSaleOrdersInfo.ARSaleOrderValidateDate = oldSaleOrder.ARSaleOrderValidateDate;
            objSaleOrdersInfo.ARSaleOrderReference = objSaleForecastsInfo.ARSaleForecastNo;
            objSaleOrdersInfo.ARSaleOrderPONo = objSaleForecastsInfo.ARSaleForecastPONo;
            objSaleOrdersInfo.ARSaleOrderDeliveryDate = objSaleForecastsInfo.ARSaleForecastDeliveryDate;
            objSaleOrdersInfo.FK_HREmployeeID = objSaleForecastsInfo.FK_HREmployeeID;
            objSaleOrdersInfo.ARSaleOrderEmployeePicture = oldSaleOrder.ARSaleOrderEmployeePicture;
            objSaleOrdersInfo.FK_ARAssociatedSellerID = objSaleForecastsInfo.FK_ARAssociatedSellerID;
            objSaleOrdersInfo.ARSaleOrderSOContactName = objSaleForecastsInfo.ARSaleForecastSFContactName;
            objSaleForecastsInfo.ARSaleForecastDeliveryContactName = objSaleForecastsInfo.ARSaleForecastDeliveryContactName;
            objSaleOrdersInfo.ARSaleOrderComment = objSaleForecastsInfo.ARSaleForecastComment;
            objSaleOrdersInfo.ARSaleOrderType = objSaleForecastsInfo.ARSaleForecastType;
            //objSaleOrdersInfo.ARSaleOrderType = objSaleForecastsInfo.ARSaleForecastType;
            if (BOSApp.CurrentCompanyInfo != null)
            { objSaleOrdersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID; }
            objSaleOrdersInfo.ARSaleOrderTotalProduct = 0;


        }

        /// <summary>
        /// Generate invoice items from a given sale order and add them to the current invoice item list        
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale order</param>
        private void GenerateSaleOrderItemsFromSaleForecast(List<ARSaleForecastItemsInfo> saleForecastItemList)
        {
            //Copy item list
            BOSList<ARSaleForecastItemsInfo> saleForecastItems = new BOSList<ARSaleForecastItemsInfo>();
            saleForecastItems.InitBOSList(null, TableName.ARSaleForecastsTableName, TableName.ARSaleForecastItemsTableName, BOSList<ARSaleForecastItemsInfo>.cstRelationForeign);
            saleForecastItems.Invalidate(saleForecastItemList);
            ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo saleOrderItemsInfo;
            foreach (ARSaleForecastItemsInfo objSaleForecastItemsInfo in saleForecastItems)
            {
                saleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetSaleOrderItemBySaleForecastItemID(objSaleForecastItemsInfo.ARSaleForecastItemID);
                if (saleOrderItemsInfo != null && saleOrderItemsInfo.ARSaleOrderItemProductQty - saleOrderItemsInfo.ARSaleOrderItemCanceledQty == objSaleForecastItemsInfo.ARSaleForecastItemProductQty)
                {
                }
                else
                {

                    ///////////////// LOC Remove ShippedQty ////////
                    objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty = objSaleForecastItemsInfo.ARSaleForecastItemProductQty - objSaleForecastItemsInfo.ARSaleForecastItemCanceledQty - objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty;
                    ////////////////////////////////////////////////////
                    if (objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty > 0)
                    {
                        ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
                        BOSUtil.CopyObject(objSaleForecastItemsInfo, objSaleOrderItemsInfo);
                        objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty = 0;
                        objSaleOrderItemsInfo.FK_ARSaleForecastItemID = objSaleForecastItemsInfo.ARSaleForecastItemID;
                        objSaleOrderItemsInfo.FK_ICMeasureUnitID = objSaleForecastItemsInfo.FK_ICMeasureUnitID;
                        //objSaleOrderItemsInfo.FK_ARSaleOrderID = objSaleForecastItemsInfo.ARSaleOrderItemID;
                        objSaleOrderItemsInfo.ARSaleOrderItemProductQty = objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty;
                        objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate = objSaleForecastItemsInfo.ARSaleForecastItemDeliveryDate;
                        RoundByCurrency(objSaleOrderItemsInfo);
                        SetProductPriceByProductUnitPrice(objSaleOrderItemsInfo);

                        objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                        objSaleOrderItemsInfo.ARSOItemComponentList.InitBOSList(
                                                            this,
                                                            TableName.ARSaleOrderItemsTableName,
                                                            TableName.ARSOItemComponentsTableName,
                                                            BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                        objSaleOrderItemsInfo.ARSOItemComponentList.ItemTableForeignKey = "FK_ARSaleOrderItemID";

                        //Generate invoice item component from sale order item
                        objSaleForecastItemsInfo.ARSFItemComponentList = new BOSList<ARSFItemComponentsInfo>();
                        objSaleForecastItemsInfo.ARSFItemComponentList.InitBOSList(null,
                                                                TableName.ARSaleForecastItemsTableName,
                                                                TableName.ARSFItemComponentsTableName,
                                                                BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                        ARSFItemComponentsController objSFItemComponentsController = new ARSFItemComponentsController();
                        //List<ARSFItemComponentsInfo> components = objSFItemComponentsController.GetSFItemComponentListBySOItemID(objSaleForecastItemsInfo.ARSaleForecastItemID);
                        //objSaleForecastItemsInfo.ARSFItemComponentList.Invalidate(components);
                        if (objSaleForecastItemsInfo.ARSFItemComponentList.Count > 0)
                        {
                            objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                            objSaleOrderItemsInfo.ARSOItemComponentList.InitBOSList(this,
                                                                TableName.ARSaleOrderItemsTableName,
                                                                TableName.ARSOItemComponentsTableName,
                                                                BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                            objSaleOrderItemsInfo.ARSOItemComponentList.ItemTableForeignKey = "FK_ARSaleOrderItemID";
                            foreach (ARSFItemComponentsInfo objSFItemComponentsInfo in objSaleForecastItemsInfo.ARSFItemComponentList)
                            {
                                ARSOItemComponentsInfo objSOItemComponentsInfo = new ARSOItemComponentsInfo();
                                BOSUtil.CopyObject(objSFItemComponentsInfo, objSOItemComponentsInfo);
                                objSOItemComponentsInfo.ARSOItemComponentQty = objSFItemComponentsInfo.ARSFItemComponentQty - objSOItemComponentsInfo.ARSOItemComponentShippedQty;
                                ICProductsController objProductsController1 = new ICProductsController();
                                ICProductsInfo objProductsInfo1 = (ICProductsInfo)objProductsController1.GetObjectByID(objSFItemComponentsInfo.FK_ICProductID);
                                if (objProductsInfo1 != null)
                                {
                                    if (objProductsInfo1.ICProductType == ProductType.IngredientPaint.ToString() ||
                                           objProductsInfo1.ICProductType == ProductType.Roundwood.ToString() ||
                                           objProductsInfo1.ICProductType == ProductType.Reuse.ToString() ||
                                           objProductsInfo1.ICProductType == ProductType.Lumber.ToString() ||
                                           objProductsInfo1.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                           objProductsInfo1.ICProductType == ProductType.Verneer.ToString())
                                    {
                                        objSOItemComponentsInfo.ARSOItemComponentQty = Math.Round(objSOItemComponentsInfo.ARSOItemComponentQty, 4, MidpointRounding.AwayFromZero);
                                    }
                                    else
                                    {
                                        objSOItemComponentsInfo.ARSOItemComponentQty = Math.Round(objSOItemComponentsInfo.ARSOItemComponentQty, 2, MidpointRounding.AwayFromZero);
                                    }
                                }
                                objSaleOrderItemsInfo.ARSOItemComponentList.Add(objSOItemComponentsInfo);
                            }
                        }

                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleForecastItemsInfo.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                            {
                                objSaleOrderItemsInfo.ARSaleOrderItemProductQty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemProductQty, 4, MidpointRounding.AwayFromZero);
                            }
                            else
                            {
                                objSaleOrderItemsInfo.ARSaleOrderItemProductQty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemProductQty, 2, MidpointRounding.AwayFromZero);
                            }
                        }
                        ARSaleOrderItemsList.Add(objSaleOrderItemsInfo);
                    }
                }
            }
        }


        public void UpdateReferenceProposal()
        {
            ARProposalItemsController objProposalItemsController = new ARProposalItemsController();
            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            {
                if (ARReferenceProposalItems.ContainsKey(entItem.FK_ARProposalItemID))
                {
                    //Decrease quantity of the reference proposal
                    ARProposalItemsInfo objProposalItemsInfo = ARReferenceProposalItems[entItem.FK_ARProposalItemID];

                    //Update ordered quantity of the proposal's item
                    objProposalItemsInfo.ARProposalItemProductQtyOld += Math.Min(entItem.ARSaleOrderItemProductQty, objProposalItemsInfo.ARProposalItemProductQtyRemained);
                    objProposalItemsInfo.ARProposalItemProductQtyRemained = objProposalItemsInfo.ARProposalItemProductQty - objProposalItemsInfo.ARProposalItemProductQtyOld;
                    objProposalItemsController.UpdateObject(objProposalItemsInfo);
                }
            }

            //Update the proposal's status
            bool isRemained = false;
            foreach (ARProposalItemsInfo objProposalItemsInfo in ARReferenceProposalItems.Values)
            {
                if (objProposalItemsInfo.ARProposalItemProductQtyRemained > 0)
                {
                    isRemained = true;
                    break;
                }
            }

            if (!isRemained)
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                if (!String.IsNullOrEmpty(objSaleOrdersInfo.ARSaleOrderReference))
                {
                    ARProposalsController objProposalsController = new ARProposalsController();
                    ARProposalsInfo objProposalsInfo = (ARProposalsInfo)objProposalsController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderReference);
                    if (objProposalsInfo != null)
                    {
                        objProposalsInfo.ARProposalStatus = ProposalStatus.Ordered.ToString();
                        objProposalsController.UpdateObject(objProposalsInfo);
                    }
                }
            }
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)ModuleObjects[TableName.ARSaleOrderItemsTableName];
                objSaleOrderItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objSaleOrderItemsInfo.ARSaleOrderItemProductCustomerNumber = objProductsInfo.ICProductSupplierNumber;
                objSaleOrderItemsInfo.FK_ICStockID = 5;
                objSaleOrderItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate = objSaleOrdersInfo.ARSaleOrderDeliveryDate;
                objSaleOrderItemsInfo.ARSaleOrderItemDeliveryTime = objSaleOrdersInfo.ARSaleOrderDeliveryTime;
                objSaleOrderItemsInfo.ICProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice;
                objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty = 0;
                objSaleOrderItemsInfo.ARSaleOrderItemShippedQty = 0;
                UpdateModuleObjectBindingSource(TableName.ARSaleOrderItemsTableName);
            }
        }

        public override void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {
            //Update price level of proposal
            ((ARSaleOrdersInfo)MainObject).FK_ARPriceLevelID = objCustomersInfo.FK_ARPriceLevelID;
            UpdateMainObjectBindingSource();

            //Update all item price based on price level
            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            {
                SetProductPrice(entItem, TableName.ARSaleOrderItemsTableName);
            }
            ARSaleOrderItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmount(ARSaleOrderItemsList);
        }

        public void UpdateTotalAmount(List<ARSaleOrderItemsInfo> list)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            objSaleOrdersInfo.ARSaleOrderNetAmount = 0;
            objSaleOrdersInfo.ARSaleOrderSubTotalAmount = 0;
            foreach (ARSaleOrderItemsInfo entItem in list)
            {
                RoundByCurrency(entItem);
                objSaleOrdersInfo.ARSaleOrderNetAmount += entItem.ARSaleOrderItemNetAmount;
                //objSaleOrdersInfo.ARSaleOrderSubTotalAmount += entItem.ARSaleOrderItemTotalAmount;
                objSaleOrdersInfo.ARSaleOrderSubTotalAmount += entItem.ARSaleOrderItemPrice;
            }
            BOSApp.RoundByCurrency(objSaleOrdersInfo, objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderDiscountFix = objSaleOrdersInfo.ARSaleOrderSubTotalAmount * objSaleOrdersInfo.ARSaleOrderDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderDiscountFix", objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderTaxAmount = (objSaleOrdersInfo.ARSaleOrderSubTotalAmount - objSaleOrdersInfo.ARSaleOrderDiscountFix) * objSaleOrdersInfo.ARSaleOrderTaxPercent / 100;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderTaxAmount", objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderTotalAmount = objSaleOrdersInfo.ARSaleOrderSubTotalAmount -
                                                        objSaleOrdersInfo.ARSaleOrderDiscountFix +
                                                        objSaleOrdersInfo.ARSaleOrderTaxAmount;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderTotalAmount", objSaleOrdersInfo.FK_GECurrencyID);
            objSaleOrdersInfo.ARSaleOrderBalanceDue = objSaleOrdersInfo.ARSaleOrderTotalAmount - objSaleOrdersInfo.ARSaleOrderDepositBalance;
            BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderBalanceDue", objSaleOrdersInfo.FK_GECurrencyID);
            //Calculate customer comission
            decimal subTotalAmount = 0;
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in list)
            {
                subTotalAmount += objSaleOrderItemsInfo.ARSaleOrderItemNetAmount - objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount;
            }
            decimal totalAmount = subTotalAmount - objSaleOrdersInfo.ARSaleOrderDiscountFix;
            objSaleOrdersInfo.ARSaleOrderSOCommissionAmount = totalAmount * objSaleOrdersInfo.ARSaleOrderSOCommissionPercent / 100;
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in list)
            {
                if (objSaleOrdersInfo.ARSaleOrderExchangeRate2 > 0)
                {
                    RoundByCurrency(objSaleOrderItemsInfo);
                    objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice * objSaleOrdersInfo.ARSaleOrderExchangeRate / objSaleOrdersInfo.ARSaleOrderExchangeRate2;
                }
                else
                    RoundByCurrency(objSaleOrderItemsInfo);
                objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice * objSaleOrdersInfo.ARSaleOrderExchangeRate;
                RoundByCurrency(objSaleOrderItemsInfo);
                objSaleOrderItemsInfo.ARSaleOrderItemTotalAmount2 = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice2 * objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                RoundByCurrency(objSaleOrderItemsInfo);
                if (objSaleOrderItemsInfo.ICProductUnitPrice == 0)
                {
                    objSaleOrderItemsInfo.ICProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice;
                }
            }
            BOSApp.RoundByCurrency(objSaleOrdersInfo, objSaleOrdersInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }


        public void RoundByCurrency(ARSaleOrderItemsInfo obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            GECurrenciesController currencyController = new GECurrenciesController();
            //GECurrenciesInfo currency = currencyController.GetObjectByID(currencyID) as GECurrenciesInfo;
            GETablesController tableController = new GETablesController();
            if (obj != null)
            {
                string tableName = BOSUtil.GetTableNameFromBusinessObject(obj);
                List<GETablesInfo> tables = tableController.GetColumnNamesByTableName(tableName);

                if (tables != null)
                {
                    foreach (GETablesInfo table in tables)
                    {
                        if (table.ColumnName != "ICProductUnitPrice")
                        {
                            if (table.ColumnName == "ARSaleOrderItemProductUnitPrice2" || table.ColumnName == "ARSaleOrderItemTotalAmount2")
                            {
                                GECurrenciesInfo currency = currencyController.GetObjectByID(objSaleOrdersInfo.FK_GECurrencyID2) as GECurrenciesInfo;
                                if (currency != null)
                                {
                                    object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                    decimal amount = 0;
                                    if (value != null)
                                    {
                                        amount = Convert.ToDecimal(value);
                                        amount = Math.Round(amount, currency.GECurrencyDecimalNumber);
                                        dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                    }
                                }
                            }
                            else
                            {
                                GECurrenciesInfo currency = currencyController.GetObjectByID(objSaleOrdersInfo.FK_GECurrencyID) as GECurrenciesInfo;
                                if (currency != null)
                                {
                                    object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                    decimal amount = 0;
                                    if (value != null)
                                    {
                                        amount = Convert.ToDecimal(value);
                                        amount = Math.Round(amount, currency.GECurrencyDecimalNumber);
                                        dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        public void SetProductPriceByProductUnitPrice(ARSaleOrderItemsInfo item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
            //Math Round Start
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo(); objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);




            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Math Round Qty
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                {
                    qty = Math.Round(qty, 4, MidpointRounding.AwayFromZero);
                }
                else
                {
                    qty = Math.Round(qty, 2, MidpointRounding.AwayFromZero);
                }
            }
            //End




            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
            dbUtil.SetPropertyValue(item, columnName, extPrice);

            //Set Item Net Amount
            columnName = itemTablePrefix + "NetAmount";
            decimal netAmount = extPrice;
            dbUtil.SetPropertyValue(item, columnName, netAmount);

            //Get or set item discount percent and amount
            string discountPercentColumnName = itemTablePrefix + "ProductDiscount";
            string discountAmountColumnName = itemTablePrefix + "DiscountAmount";
            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountPercentColumnName));
            decimal discountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountAmountColumnName));
            decimal oldDiscountAmount = 0;
            if (item.OldObject == null)
            {
                item.OldObject = (BusinessObject)item.Clone();
            }
            if (item.OldObject != null)
            {
                oldDiscountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, discountAmountColumnName));
            }
            if (discountAmount != oldDiscountAmount)
            {
                if (extPrice > 0)
                {
                    discountPercent = discountAmount / extPrice * 100;
                    dbUtil.SetPropertyValue(item, discountPercentColumnName, discountPercent);
                }
            }
            else
            {
                discountAmount = extPrice * discountPercent / 100;
                dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
            }

            //Get or set tax percent and amount
            string taxPercentColumnName = itemTablePrefix + "ProductTaxPercent";
            string taxAmountColumnName = itemTablePrefix + "TaxAmount";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxPercentColumnName));
            decimal taxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxAmountColumnName));
            decimal oldTaxAmount = 0;
            if (item.OldObject != null)
            {
                oldTaxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, taxAmountColumnName));
            }
            if (taxAmount != oldTaxAmount)
            {
                //if (netAmount - discountAmount > 0)
                //{
                //    taxPercent = taxAmount / (netAmount - discountAmount) * 100;
                //    dbUtil.SetPropertyValue(item, taxPercentColumnName, taxPercent);
                //}            
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }
            else
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);

            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            RoundByCurrency(item);


            item.OldObject = (BusinessObject)item.Clone();
        }

        /// <summary>
        /// Take a deposit
        /// </summary>
        /// <param name="paymentDate">Payment date</param>
        /// <param name="paymentDesc">Payment desc</param>
        /// <param name="bankID">Bank id</param>
        /// <param name="bankAccount">Bank account</param>
        /// <param name="paymentAmount">Payment amount</param>
        /// <returns>Id of payment object</returns>
        public int TakePayment(DateTime paymentDate, string paymentDesc, int bankID, string bankAccount, decimal paymentAmount)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //Generate open document if it's the first payment
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    AROpenDocumentsInfo objOpenDocumentsInfo = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderNo);
                    if (objOpenDocumentsInfo == null)
                    {
                        objOpenDocumentsInfo = DataGenerator.GenerateOpenDocumentFromSaleOrder((ARSaleOrdersInfo)MainObject);
                        objOpenDocumentsController.CreateObject(objOpenDocumentsInfo);
                    }
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARCustomerPaymentsInfo objCustomerPaymentsInfo = CustomerPayment.CustomerPaymentModule.TakePayment(objOpenDocumentsInfo, paymentAmount, ARCustomerPaymentDetailsList);
                    objCustomerPaymentsInfo.ARCustomerPaymentNo = BOSApp.GetMainObjectNo(ModuleName.Deposit, objCustomerPaymentsInfo);
                    objCustomerPaymentsInfo.ARCustomerPaymentType = CustomerPaymentType.Deposit.ToString();
                    objCustomerPaymentsInfo.ARCustomerPaymentDate = paymentDate;
                    objCustomerPaymentsInfo.ARCustomerPaymentDesc = paymentDesc;
                    objCustomerPaymentsInfo.FK_CSCompanyBankID = bankID;
                    objCustomerPaymentsInfo.ARCustomerPaymentBankAccount = bankAccount;
                    objCustomerPaymentsController.UpdateObject(objCustomerPaymentsInfo);
                    BOSApp.UpdateObjectNumbering(ModuleName.Deposit);

                    //Update sale order
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    objSaleOrdersInfo.ARSaleOrderDepositBalance += Math.Min(paymentAmount, objSaleOrdersInfo.ARSaleOrderBalanceDue);
                    objSaleOrdersInfo.ARSaleOrderBalanceDue -= Math.Min(paymentAmount, objSaleOrdersInfo.ARSaleOrderBalanceDue);
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);

                    SavePaymentEntries(objCustomerPaymentsInfo);

                    scope.Complete();
                    return objCustomerPaymentsInfo.ARCustomerPaymentID;
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    return 0;
                }
            }
        }


        /// <summary>
        /// Save a template to database
        /// </summary>
        /// <param name="objVisitTemplatesInfo">Visit template object needs to be saved</param>
        public void SaveTemplate(ARSaleOrderTemplatesInfo objSaleSaleOrderTemplatesInfo)
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ARSaleOrderTemplatesController objSaleOrderTemplatesController = new ARSaleOrderTemplatesController();
            if (objSaleSaleOrderTemplatesInfo.ARSaleOrderTemplateID == 0)
            {
                objSaleSaleOrderTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
                objSaleSaleOrderTemplatesInfo.AACreatedDate = DateTime.Now;
                objSaleSaleOrderTemplatesInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                objSaleOrderTemplatesController.CreateObject(objSaleSaleOrderTemplatesInfo);
            }
            else
            {
                objSaleSaleOrderTemplatesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objSaleSaleOrderTemplatesInfo.AAUpdatedDate = DateTime.Now;
                objSaleOrderTemplatesController.UpdateObject(objSaleSaleOrderTemplatesInfo);
            }

        }

        /// <summary>
        /// Update a deposit
        /// </summary>
        /// <param name="customerPayment">Deposit object</param>
        /// <param name="objDocumentPaymentsInfo">Payment document of the deposit</param>
        public void UpdatePayment(ARCustomerPaymentsInfo customerPayment, ARDocumentPaymentsInfo objDocumentPaymentsInfo)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();

                    //Update document payment
                    objDocumentPaymentsInfo.ARDocumentPaymentAmount = customerPayment.ARCustomerPaymentTotalAmount;
                    objDocumentPaymentsController.UpdateObject(objDocumentPaymentsInfo);

                    //Update open document
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    ARSaleOrdersInfo saleOrder = (ARSaleOrdersInfo)MainObject;
                    AROpenDocumentsInfo openDocument = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(saleOrder.ARSaleOrderNo);
                    if (openDocument != null)
                    {
                        int openDocumentID = openDocument.AROpenDocumentID;
                        openDocument = DataGenerator.GenerateOpenDocumentFromSaleOrder(saleOrder);
                        openDocument.AROpenDocumentID = openDocumentID;
                        objOpenDocumentsController.UpdateObject(openDocument);
                    }

                    //Update customer payment                    
                    customerPayment.FK_ARCustomerID = saleOrder.FK_ARCustomerID;
                    customerPayment.FK_GECurrencyID = saleOrder.FK_GECurrencyID;
                    objCustomerPaymentsController.UpdateObject(customerPayment);

                    //Update customer payment detail
                    CustomerPayment.CustomerPaymentModule.UpdateCustomerPaymentDetails(customerPayment, ARCustomerPaymentDetailsList);

                    //Update the deposit and balance due of the current sale order
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    saleOrder.ARSaleOrderDepositBalance += Math.Min(customerPayment.ARCustomerPaymentTotalAmount, saleOrder.ARSaleOrderBalanceDue);
                    saleOrder.ARSaleOrderBalanceDue -= Math.Min(customerPayment.ARCustomerPaymentTotalAmount, saleOrder.ARSaleOrderBalanceDue);
                    objSaleOrdersController.UpdateObject(saleOrder);

                    SavePaymentEntries(customerPayment);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                }
            }
        }

        public void UpdateContQty()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            decimal contQty = 0;
            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo products = objProductsController.GetProductByID(entItem.FK_ICProductID);

                contQty += (entItem.ARSaleOrderItemProductQty * products.ICProductLength * products.ICProductWidth * products.ICProductHeight) * Convert.ToDecimal((Math.Pow(10, -9)));
            }
            if (contQty != 0)
            {
                contQty = (contQty) / 60;
            }

            objSaleOrdersInfo.ARSaleOrderContQty = contQty; //decimal.Parse(String.Format("{0:0.00}", contQty));
            objSaleOrdersInfo.ARSaleOrderContQty = Math.Round(objSaleOrdersInfo.ARSaleOrderContQty, 4, MidpointRounding.AwayFromZero);

            UpdateMainObjectBindingSource();
        }
        public void UpdateContQtyForLumber()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            decimal contQty = 0;
            foreach (ARSaleOrderItemsInfo entItem in LumberWoodList)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo products = objProductsController.GetProductByID(entItem.FK_ICProductID);

                contQty += (entItem.ARSaleOrderItemProductQty * products.ICProductLength * products.ICProductWidth * products.ICProductHeight) * Convert.ToDecimal((Math.Pow(10, -9)));
            }
            if (contQty != 0)
            {
                contQty = (contQty) / 60;
            }

            objSaleOrdersInfo.ARSaleOrderContQty = contQty; //decimal.Parse(String.Format("{0:0.00}", contQty));
            objSaleOrdersInfo.ARSaleOrderContQty = Math.Round(objSaleOrdersInfo.ARSaleOrderContQty, 4, MidpointRounding.AwayFromZero);

            UpdateMainObjectBindingSource();
        }
        public void UpdateContQtyForRoundWood()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            decimal contQty = 0;
            foreach (ARSaleOrderItemsInfo entItem in RoundWoodList)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo products = objProductsController.GetProductByID(entItem.FK_ICProductID);

                contQty += (entItem.ARSaleOrderItemProductQty * products.ICProductLength * products.ICProductWidth * products.ICProductHeight) * Convert.ToDecimal((Math.Pow(10, -9)));
            }
            if (contQty != 0)
            {
                contQty = (contQty) / 60;
            }

            objSaleOrdersInfo.ARSaleOrderContQty = contQty; //decimal.Parse(String.Format("{0:0.00}", contQty));
            objSaleOrdersInfo.ARSaleOrderContQty = Math.Round(objSaleOrdersInfo.ARSaleOrderContQty, 4, MidpointRounding.AwayFromZero);
            UpdateMainObjectBindingSource();
        }


        /// <summary>
        /// Delete payment
        /// </summary>
        /// <param name="objDocumentPaymentsInfo">Info of document payment</param>
        public void DeletePayment(ARDocumentPaymentsInfo objDocumentPaymentsInfo)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
                    ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)objCustomerPaymentsController.GetObjectByID(objDocumentPaymentsInfo.FK_ARCustomerPaymentID);
                    if (objCustomerPaymentsInfo != null)
                    {
                        List<ARCustomerPaymentDetailsInfo> oldPaymentDetails = objCustomerPaymentDetailsController.GetDetailsByPaymentID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        foreach (ARCustomerPaymentDetailsInfo oldPaymentDetail in oldPaymentDetails)
                        {
                            CustomerPayment.CustomerPaymentModule.RollbackRelativeDataOfPaymentDetail((ARCustomerPaymentDetailsInfo)oldPaymentDetail);
                        }
                        objCustomerPaymentsController.DeleteByID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objCustomerPaymentsController.DeletePaymentEntriesByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
                    }

                    //Update the deposit and balance due of the current sale order
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                    objSaleOrdersInfo.ARSaleOrderDepositBalance -= objDocumentPaymentsInfo.ARDocumentPaymentAmount;
                    objSaleOrdersInfo.ARSaleOrderBalanceDue += objDocumentPaymentsInfo.ARDocumentPaymentAmount;
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);

                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }

        public void GenerateEntityFromProposal(ARProposalsInfo objProposalsInfo)
        {
            //Copy sale order
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            ARSaleOrdersInfo objOldSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersInfo.Clone();
            BOSUtil.CopyObject(objProposalsInfo, objSaleOrdersInfo);

            //Restore some its own properties
            objSaleOrdersInfo.ARSaleOrderNo = objOldSaleOrdersInfo.ARSaleOrderNo;
            objSaleOrdersInfo.ARSaleOrderName = objOldSaleOrdersInfo.ARSaleOrderName;
            objSaleOrdersInfo.ARSaleOrderTypeCombo = objOldSaleOrdersInfo.ARSaleOrderTypeCombo;
            objSaleOrdersInfo.ARSaleOrderStatus = objOldSaleOrdersInfo.ARSaleOrderStatus;
            objSaleOrdersInfo.ARSaleOrderDate = objOldSaleOrdersInfo.ARSaleOrderDate;
            objSaleOrdersInfo.ARSaleOrderDeliveryDate = objOldSaleOrdersInfo.ARSaleOrderDeliveryDate;
            objSaleOrdersInfo.ARSaleOrderValidateDate = objOldSaleOrdersInfo.ARSaleOrderValidateDate;
            objSaleOrdersInfo.ARSaleOrderDesc = objOldSaleOrdersInfo.ARSaleOrderDesc;
            objSaleOrdersInfo.ARSaleOrderReference = objProposalsInfo.ARProposalNo;
            objSaleOrdersInfo.FK_HREmployeeID = objOldSaleOrdersInfo.FK_HREmployeeID;
            objSaleOrdersInfo.ARSaleOrderEmployeePicture = objOldSaleOrdersInfo.ARSaleOrderEmployeePicture;
            objSaleOrdersInfo.ARSaleOrderBalanceDue = objSaleOrdersInfo.ARSaleOrderTotalAmount - objSaleOrdersInfo.ARSaleOrderDepositBalance;

            //Copy item list
            BOSList<ARProposalItemsInfo> lstProposalItems = new BOSList<ARProposalItemsInfo>();
            lstProposalItems.InitBOSList(null, TableName.ARProposalsTableName, TableName.ARProposalItemsTableName, BOSList<ARProposalItemsInfo>.cstRelationForeign);
            lstProposalItems.Invalidate(objProposalsInfo.ARProposalID);
            ARReferenceProposalItems.Clear();
            foreach (ARProposalItemsInfo objProposalItemsInfo in lstProposalItems)
            {
                objProposalItemsInfo.ARProposalItemProductQtyRemained = objProposalItemsInfo.ARProposalItemProductQty - objProposalItemsInfo.ARProposalItemProductQtyOld;
                if (objProposalItemsInfo.ARProposalItemProductQtyRemained > 0)
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
                    BOSUtil.CopyObject(objProposalItemsInfo, objSaleOrderItemsInfo);
                    objSaleOrderItemsInfo.FK_ARProposalID = objProposalsInfo.ARProposalID;
                    objSaleOrderItemsInfo.FK_ARProposalItemID = objProposalItemsInfo.ARProposalItemID;
                    objSaleOrderItemsInfo.ARSaleOrderItemProductQty = objProposalItemsInfo.ARProposalItemProductQtyRemained;
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProposalItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                               objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                        {
                            objSaleOrderItemsInfo.ARSaleOrderItemProductQty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemProductQty, 4, MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            objSaleOrderItemsInfo.ARSaleOrderItemProductQty = Math.Round(objSaleOrderItemsInfo.ARSaleOrderItemProductQty, 2, MidpointRounding.AwayFromZero);
                        }
                    }
                    SetProductPriceByProductUnitPrice(objSaleOrderItemsInfo);
                    ARSaleOrderItemsList.Add(objSaleOrderItemsInfo);

                    ARReferenceProposalItems.Add(objProposalItemsInfo.ARProposalItemID, objProposalItemsInfo);
                }
            }

            UpdateTotalAmount(ARSaleOrderItemsList);
        }

        public ARInvoicesInfo GenerateInvoiceFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            ARInvoicesInfo objInvoicesInfo = new ARInvoicesInfo();
            BOSUtil.CopyObject(objSaleOrdersInfo, objInvoicesInfo);

            //Set own properties of invoice
            objInvoicesInfo.AACreatedUser = BOSApp.CurrentUser;
            objInvoicesInfo.AACreatedDate = DateTime.Now;
            objInvoicesInfo.ARInvoiceReference = objSaleOrdersInfo.ARSaleOrderNo;
            objInvoicesInfo.ARInvoiceStatus = BOSCommon.InvoiceStatus.Complete.ToString();
            if (BOSApp.CurrentCompanyInfo != null)
                objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            return objInvoicesInfo;
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
        }

        public override bool CompleteTransaction()
        {
            //Update sale order's status
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            if (objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.New.ToString())
            {
                //TNDLoc [MOD][24/11/2015][Issue sale order status],START
                objSaleOrdersInfo.ARSaleOrderStatus = SaleOrderStatus.Confirmed.ToString();
                //TNDLoc [MOD][24/11/2015][Issue sale order status],END
                UpdateMainObject();
                //UpdateModuleObjectBatchStatus();
            }

            int saleOrderStockID = 0;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.SaleOrder.ToString(), objSaleOrdersInfo.FK_BRBranchID);
            if (objStocksInfo != null)
            {
                saleOrderStockID = objStocksInfo.ICStockID;
            }

            //TNDLoc [ADD][25/01/2016][Update Allocation Qty Stock],START
            int allocationPlanStockID = 0;

            ICStocksInfo objAllocationPlanStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.AllocationPlan.ToString(), objSaleOrdersInfo.FK_BRBranchID);
            if (objAllocationPlanStocksInfo != null)
            {
                allocationPlanStockID = objAllocationPlanStocksInfo.ICStockID;
            }
            //TNDLoc [ADD][25/01/2016][Update Allocation Qty Stock],END
            //Rollback ordered quantity
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            foreach (ARSaleOrderItemsInfo entItem in ComponentSaleOrderItemList.BackupList)
            {
                if (entItem.FK_MMAllocationPlanItemID > 0)
                {
                    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)objAllocationPlanItemsController.GetObjectByID(entItem.FK_MMAllocationPlanItemID);
                    if (objAllocationPlanItemsInfo != null)
                    {
                        objAllocationPlanItemsInfo.MMAllocationPlanItemSaleOrderQty -= (entItem.ARSaleOrderItemProductQty - entItem.ARSaleOrderItemCanceledQty - entItem.ARSaleOrderItemShippedQty);
                        objAllocationPlanItemsInfo.MMAllocationPlanItemSaleOrderWoodQty -= (entItem.ARSaleOrderItemWoodQty);
                        objAllocationPlanItemsController.UpdateObject(objAllocationPlanItemsInfo);
                    }
                }

            }
            //Update reference sale order
            if (!string.IsNullOrEmpty(objSaleOrdersInfo.ARSaleOrderReference))
            {
                UpdateReferenceSaleForecastItems();
            }
            return true;
        }


        /// <summary>
        /// Update reference sale forecasts that the current sale order has been created from
        /// </summary>
        //[TNDLOC][Update Reference Sale Forecast Items ][10/11/2015] BEGIN
        public void UpdateReferenceSaleForecastItems()
        {
            ICStocksController objStocksController = new ICStocksController();
            ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();
            ARSFItemComponentsController objSFItemComponentsController = new ARSFItemComponentsController();
            List<ARSaleForecastsInfo> saleForecasts = new List<ARSaleForecastsInfo>();
            List<ARSaleForecastItemsInfo> allSaleForecastItems = new List<ARSaleForecastItemsInfo>();
            ARSaleOrdersInfo SaleOrder = (ARSaleOrdersInfo)MainObject;
            string[] saleForecastNos = SaleOrder.ARSaleOrderReference.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < saleForecastNos.Length; i++)
            {
                string saleForecastNo = saleForecastNos[i].Trim();
                ARSaleForecastsInfo saleForecast = saleForecasts.Where(so => so.ARSaleForecastNo == saleForecastNo).FirstOrDefault();
                if (saleForecast == null)
                {
                    saleForecast = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByNo(saleForecastNo);
                    if (saleForecast != null)
                    {
                        List<ARSaleForecastItemsInfo> saleForecastItems = objSaleForecastItemsController.GetComponentItemsBySaleForecastID(saleForecast.ARSaleForecastID);
                        //Set remained quantity for items
                        foreach (ARSaleForecastItemsInfo saleForecastItem in saleForecastItems)
                        {
                            saleForecastItem.ARSaleForecastItemRemainedQty = saleForecastItem.ARSaleForecastItemProductQty - saleForecastItem.ARSaleForecastItemCanceledQty - saleForecastItem.ARSaleForecastItemProductSOQty;
                        }
                        allSaleForecastItems.AddRange(saleForecastItems);
                        saleForecasts.Add(saleForecast);
                    }
                }
            }


            //Rollback ordered quantity of the reference sale order
            foreach (ARSaleOrderItemsInfo SaleOrderItem in ComponentSaleOrderItemList.BackupList)
            {
                decimal SaleOrderItemQty = SaleOrderItem.ARSaleOrderItemProductQty;
                while (SaleOrderItemQty > 0)
                {
                    ARSaleForecastsInfo objSOInfo = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByNo(saleForecastNos[0]);
                    List<ARSaleForecastItemsInfo> lst = new List<ARSaleForecastItemsInfo>();
                    if (objSOInfo != null)
                    {
                        lst = objSaleForecastItemsController.GetItemsBySaleForecastID(objSOInfo.ARSaleForecastID);
                    }

                    ARSaleForecastItemsInfo SaleForecastItem = lst.Where(i => i.FK_ICProductID == SaleOrderItem.FK_ICProductID &&
                                                                                      i.ARSaleForecastItemProductSOQty > 0).FirstOrDefault();
                    decimal shippedQty = 0;
                    if (SaleForecastItem != null)
                    {
                        shippedQty = Math.Min(SaleOrderItemQty, SaleForecastItem.ARSaleForecastItemProductSOQty);
                    }
                    else
                    {
                        SaleForecastItem = allSaleForecastItems.Where(i => i.FK_ICProductID == SaleOrderItem.FK_ICProductID).FirstOrDefault();
                        shippedQty = SaleOrderItemQty;
                    }

                    if (SaleForecastItem != null)
                    {
                        //Rollback shipped quantity
                        SaleForecastItem.ARSaleForecastItemProductSOQty -= shippedQty;
                        SaleForecastItem.ARSaleForecastItemRemainedQty = SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemCanceledQty - SaleForecastItem.ARSaleForecastItemProductSOQty;
                        //In case user removes an SaleOrder item, the shipped quantity of the reference sale order one needs to be updated as well
                        if (ComponentSaleOrderItemList.Exists(i => i.ARSaleOrderItemID == SaleOrderItem.ARSaleOrderItemID))
                        {
                            if (!SaleForecastItem.IsSubItem)
                            {
                                objSaleForecastItemsController.UpdateSOQty(SaleForecastItem.ARSaleForecastItemID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                            }
                            else
                            {
                                objSFItemComponentsController.UpdateSOQty(SaleForecastItem.ARSFItemComponentID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                            }
                        }

                        ARSaleForecastsInfo SaleForecast = saleForecasts.Where(so => so.ARSaleForecastID == SaleForecastItem.FK_ARSaleForecastID).FirstOrDefault();

                        SaleOrderItemQty -= shippedQty;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Update new ordered quantity
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            foreach (ARSaleOrderItemsInfo SaleOrderItem in ComponentSaleOrderItemList)
            {
                decimal SaleOrderItemQty = SaleOrderItem.ARSaleOrderItemProductQty;
                while (SaleOrderItemQty > 0)
                {
                    ARSaleForecastsInfo objSOInfo = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByNo(saleForecastNos[0]);
                    List<ARSaleForecastItemsInfo> lst = new List<ARSaleForecastItemsInfo>();
                    if (objSOInfo != null)
                    {
                        lst = objSaleForecastItemsController.GetItemsBySaleForecastID(objSOInfo.ARSaleForecastID);
                    }
                    ARSaleForecastItemsInfo SaleForecastItem = new ARSaleForecastItemsInfo();
                    foreach (ARSaleForecastItemsInfo i in allSaleForecastItems.OrderBy(a => a.ARSaleForecastItemID).ToList())
                    {
                        ARSaleForecastItemsInfo SaleForecastItems = new ARSaleForecastItemsInfo();
                        ARSaleForecastItemsInfo objSFIInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(i.ARSaleForecastItemID);
                        if (objSFIInfo != null)
                        {
                            SaleForecastItems = objSFIInfo;
                        }
                        if ((SaleForecastItems.FK_ICProductID == SaleOrderItem.FK_ICProductID) && (SaleForecastItems.ARSaleForecastItemProductQty - SaleForecastItems.ARSaleForecastItemProductSOQty > 0))
                        {
                            SaleForecastItem = SaleForecastItems;
                            break;
                        }
                    }

                    decimal shippedQty = 0;
                    if (SaleForecastItem != null)
                    {
                        if (SaleForecastItem.ARSaleForecastItemProductQty > 0)
                            shippedQty = Math.Min(SaleOrderItemQty, SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemProductSOQty);
                        else
                            shippedQty = SaleOrderItemQty;
                    }
                    else
                    {
                        SaleForecastItem = lst.Where(i => i.FK_ICProductID == SaleOrderItem.FK_ICProductID).FirstOrDefault();
                        if (SaleForecastItem != null && SaleForecastItem.ARSaleForecastItemProductQty > 0)
                            shippedQty = Math.Min(SaleOrderItemQty, SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemProductSOQty);
                        else
                            shippedQty = SaleOrderItemQty;
                    }

                    if (SaleForecastItem != null)
                    {
                        //Update new shipped quantity
                        ARSaleForecastItemsInfo objSFIInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(SaleForecastItem.ARSaleForecastItemID);
                        if (objSFIInfo != null)
                        {
                            SaleForecastItem = objSFIInfo;
                        }
                        SaleForecastItem.ARSaleForecastItemProductSOQty += shippedQty;
                        foreach (ARSaleForecastItemsInfo asoi in allSaleForecastItems.OrderBy(a => a.ARSaleForecastItemID))
                        {
                            if (asoi.ARSaleForecastItemID == SaleForecastItem.ARSaleForecastItemID)
                            {
                                asoi.ARSaleForecastItemProductSOQty += shippedQty;
                                break;
                            }
                        }

                        SaleForecastItem.ARSaleForecastItemRemainedQty = SaleForecastItem.ARSaleForecastItemProductQty - SaleForecastItem.ARSaleForecastItemCanceledQty - SaleForecastItem.ARSaleForecastItemProductSOQty;

                        if (!SaleForecastItem.IsSubItem)
                        {
                            if (SaleForecastItem.ARSaleForecastItemProductSOQty > 0)
                            {

                                objSaleForecastItemsController.UpdateSOQty(SaleForecastItem.ARSaleForecastItemID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                            }
                        }
                        else
                        {
                            objSFItemComponentsController.UpdateSOQty(SaleForecastItem.ARSFItemComponentID, SaleForecastItem.ARSaleForecastItemProductSOQty);
                        }

                        ARSaleForecastsInfo SaleForecast = saleForecasts.Where(so => so.ARSaleForecastID == SaleForecastItem.FK_ARSaleForecastID).FirstOrDefault();


                        SaleOrderItemQty -= shippedQty;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Update the sale order's status
            foreach (ARSaleForecastsInfo SaleForecast in saleForecasts)
            {
                bool isRemained = true;
                foreach (ARSaleForecastItemsInfo SaleForecastItem in allSaleForecastItems)
                {
                    ARSaleForecastItemsInfo SaleForecastItems = new ARSaleForecastItemsInfo();
                    ARSaleForecastItemsInfo objSFIInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(SaleForecastItem.ARSaleForecastItemID);
                    if (objSFIInfo != null)
                    {
                        SaleForecastItems = objSFIInfo;
                    }
                    if (SaleForecastItems.FK_ARSaleForecastID == SaleForecast.ARSaleForecastID &&
                        SaleForecastItems.FK_ICProductID > 0 &&
                        (SaleForecastItems.ARSaleForecastItemProductSOQty + SaleForecastItems.ARSaleForecastItemCanceledQty) < SaleForecastItems.ARSaleForecastItemProductQty)
                    {
                        isRemained = false;
                        break;
                    }
                }

                if (isRemained)
                {
                    SaleForecast.ARSaleForecastStatus = SaleForecastStatus.Complete.ToString();
                    SaleForecast.AAUpdatedUser = BOSApp.CurrentUser;
                    SaleForecast.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(SaleForecast);
                }
                else
                {
                    SaleForecast.ARSaleForecastStatus = SaleForecastStatus.Incomplete.ToString();
                    SaleForecast.AAUpdatedUser = BOSApp.CurrentUser;
                    SaleForecast.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(SaleForecast);
                }
            }
        }
        //[TNDLOC][Update Reference Sale Forecast Items ][10/11/2015] END

        /// <summary>
        /// Invalidate item components of the sale order items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            List<ARSaleOrderItemsInfo> items = objSaleOrderItemsController.GetComponentItemsBySaleOrderID(objSaleOrdersInfo.ARSaleOrderID);
            ComponentSaleOrderItemList.Clear();
            ComponentSaleOrderItemList.OriginalList.Clear();
            foreach (ARSaleOrderItemsInfo item in items)
            {
                ComponentSaleOrderItemList.Add((ARSaleOrderItemsInfo)item.Clone());
            }

            foreach (ARSaleOrderItemsInfo item in ComponentSaleOrderItemList)
            {
                ComponentSaleOrderItemList.OriginalList.Add((ARSaleOrderItemsInfo)item.Clone());
            }
        }

        #region Accounting
        /// <summary>
        /// Save entries for the payment of the sale receipt
        /// </summary>
        /// <param name="customerPayment">Payment object</param>
        private void SavePaymentEntries(ARCustomerPaymentsInfo customerPayment)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)MainObject;
            string oldReceiptVoucherNo = string.Empty;
            string oldBankTransferNo = string.Empty;
            //Delete all payment data first
            if (!string.IsNullOrEmpty(customerPayment.ARCustomerPaymentNo))
            {
                ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                ARReceiptVouchersInfo receiptVoucher = objReceiptVouchersController.GetReceiptVoucherByReference(customerPayment.ARCustomerPaymentNo);
                if (receiptVoucher != null)
                {
                    oldReceiptVoucherNo = receiptVoucher.ARReceiptVoucherNo;
                }

                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo bankTransfer = objBankTransactionsController.GetBankTransactionByReference(customerPayment.ARCustomerPaymentNo);
                if (bankTransfer != null)
                {
                    oldBankTransferNo = bankTransfer.ACBankTransactionNo;
                }
                objCustomerPaymentsController.DeletePaymentEntriesByNo(customerPayment.ARCustomerPaymentNo);
            }

            //Add new payment entries 
            DocumentEntryList.SetDefaultListAndRefreshGridControl();
            decimal cashAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.Cash.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (cashAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                ARCustomerPaymentDetailsInfo cashDetail = ARCustomerPaymentDetailsList.Where(d => d.ARPaymentMethodCombo == PaymentMethod.Cash.ToString()).FirstOrDefault();
                if (cashDetail != null)
                {
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (cashDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = cashDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        cashAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.PhieuThu.ToString(),
                                                                        AccEntryType.ThuTienUngTruoc.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = cashAmount;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", mainObject.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    ARReceiptVouchersInfo receiptVoucher = CreateReceiptVoucher(customerPayment, oldReceiptVoucherNo, cashAmount, currencyID, exchangeRate);
                    if (receiptVoucher != null)
                    {
                        entry.ACDocumentNo = receiptVoucher.ARReceiptVoucherNo;
                    }
                }
            }

            decimal bankTransferAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (bankTransferAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                ARCustomerPaymentDetailsInfo bankTransferDetail = ARCustomerPaymentDetailsList.Where(d => d.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()).FirstOrDefault();
                if (bankTransferDetail != null)
                {
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (bankTransferDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = bankTransferDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        bankTransferAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NopTienVaoTaiKhoan.ToString(),
                                                                        AccEntryType.ThuTienUngTruoc.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = bankTransferAmount;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", mainObject.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    ACBankTransactionsInfo bankTransfer = CreateBankTransfer(customerPayment, oldBankTransferNo, bankTransferAmount, currencyID, exchangeRate);
                    if (bankTransfer != null)
                    {
                        entry.ACDocumentNo = bankTransfer.ACBankTransactionNo;
                    }
                }
            }

            decimal creditCardAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (creditCardAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                ARCustomerPaymentDetailsInfo creditCardDetail = ARCustomerPaymentDetailsList.Where(d => d.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).FirstOrDefault();
                if (creditCardDetail != null)
                {
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (creditCardDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = creditCardDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        creditCardAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NghiepVuKhac.ToString(),
                                                                        AccEntryType.ThuCocBangTheTinDung.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = creditCardAmount;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", mainObject.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    entry.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, new ACDocumentsInfo());
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                }
            }

            decimal giftVoucherAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (giftVoucherAmount > 0)
            {
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NghiepVuKhac.ToString(),
                                                                        AccEntryType.ThuCocBangPhieuGhiCo.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, new ACDocumentsInfo());
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                    entry.ACDocumentEntryAmount = giftVoucherAmount;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", mainObject.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * customerPayment.ARCustomerPaymentExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }

            //Add new payment documents that have relative entries            
            DocumentList.Clear();
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.ThuTienUngTruoc.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuCocBangPhieuGhiCo.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuCocBangTheTinDung.ToString())
                {
                    ACDocumentsInfo document = DocumentList.Where(d => d.ACDocumentTypeName == entry.ACDocumentTypeName &&
                                                                (string.IsNullOrEmpty(entry.ACDocumentNo) || entry.ACDocumentNo == d.ACDocumentNo)).FirstOrDefault();
                    if (document == null)
                    {
                        document = new ACDocumentsInfo();
                        document.FK_ACDocumentTypeID = entry.FK_ACDocumentTypeID;
                        document.ACDocumentTypeName = entry.ACDocumentTypeName;
                        DocumentList.Add(document);
                    }
                    BOSUtil.CopyObject(customerPayment, document);
                    if (!string.IsNullOrEmpty(entry.ACDocumentNo))
                    {
                        document.ACDocumentNo = entry.ACDocumentNo;
                    }
                    if (entry.FK_GECurrencyID > 0)
                    {
                        document.FK_GECurrencyID = entry.FK_GECurrencyID;
                        document.ACDocumentExchangeRate = entry.ACDocumentExchangeRate;
                    }
                    document.ACDocumentReference = customerPayment.ARCustomerPaymentNo;
                    document.FK_ACObjectID = customerPayment.FK_ARCustomerID;
                    document.ACObjectType = ObjectType.Customer.ToString();
                }
            }
            SaveAccountingData();
        }

        public override bool SaveAccountingData()
        {
            SaveDocuments();

            SaveDocumentEntrys();

            return true;
        }

        /// <summary>
        /// Create a receipt voucher associating with the customer payment
        /// </summary>
        /// <param name="customerPayment">Customer payment</param>
        /// <param name="oldReceiptVoucherNo">Old receipt voucher no</param>
        /// <param name="amount">Receipted amount</param>
        /// <param name="currencyID">Currency id</param>
        /// <param name="exchangeRate">Exchange rate</param>
        /// <returns>Receipt voucher object</returns>
        private ARReceiptVouchersInfo CreateReceiptVoucher(ARCustomerPaymentsInfo customerPayment, string oldReceiptVoucherNo, decimal amount, int currencyID, decimal exchangeRate)
        {
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();

            ARReceiptVouchersInfo receiptVoucher = new ARReceiptVouchersInfo();
            BOSUtil.CopyObject(customerPayment, receiptVoucher);
            if (string.IsNullOrEmpty(oldReceiptVoucherNo))
            {
                receiptVoucher.ARReceiptVoucherNo = BOSApp.GetMainObjectNo(ModuleName.ReceiptVoucher, receiptVoucher);
                BOSApp.UpdateObjectNumbering(ModuleName.ReceiptVoucher);
            }
            else
            {
                receiptVoucher.ARReceiptVoucherNo = oldReceiptVoucherNo;
            }
            receiptVoucher.FK_ACObjectID = customerPayment.FK_ARCustomerID;
            receiptVoucher.ARObjectType = ObjectType.Customer.ToString();
            receiptVoucher.ARReceiptVoucherType = ReceiptVoucherType.Deposit.ToString();
            receiptVoucher.ARReceiptVoucherReference = customerPayment.ARCustomerPaymentNo;
            receiptVoucher.FK_GECurrencyID = currencyID;
            receiptVoucher.ARReceiptVoucherExchangeRate = exchangeRate;
            receiptVoucher.ARReceiptVoucherTotalAmount = amount;
            receiptVoucher.ARReceiptVoucherExchangeAmount = receiptVoucher.ARReceiptVoucherTotalAmount * receiptVoucher.ARReceiptVoucherExchangeRate;
            int receiptVoucherID = objReceiptVouchersController.CreateObject(receiptVoucher);

            objReceiptVoucherItemsController.DeleteByForeignColumn("FK_ARReceiptVoucherID", receiptVoucher.ARReceiptVoucherID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.PhieuThu.ToString())
                {
                    ARReceiptVoucherItemsInfo item = new ARReceiptVoucherItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ARReceiptVoucherID = receiptVoucher.ARReceiptVoucherID;
                    objReceiptVoucherItemsController.CreateObject(item);
                }
            }
            return receiptVoucher;
        }

        /// <summary>
        /// Create a bank transfer associating with the customer payment
        /// </summary>
        /// <param name="customerPayment">Customer payment</param>        
        /// <param name="oldBankTransferNo">Old bank transfer no</param>
        /// <param name="amount">Transferred amount</param>
        /// <param name="currencyID">Currency id</param>
        /// <param name="exchangeRate">Exchange rate</param>
        /// <returns>Bank transaction object</returns>
        private ACBankTransactionsInfo CreateBankTransfer(ARCustomerPaymentsInfo customerPayment, string oldBankTransferNo, decimal amount, int currencyID, decimal exchangeRate)
        {
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            string bankName = objCompanyBanksController.GetObjectNameByID(customerPayment.FK_CSCompanyBankID);

            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            ACBankTransactionsInfo bankTransfer = new ACBankTransactionsInfo();
            BOSUtil.CopyObject(customerPayment, bankTransfer);
            if (string.IsNullOrEmpty(oldBankTransferNo))
            {
                bankTransfer.ACBankTransactionNo = BOSApp.GetMainObjectNo(ModuleName.BankTransaction, bankTransfer);
                BOSApp.UpdateObjectNumbering(ModuleName.BankTransaction);
            }
            else
            {
                bankTransfer.ACBankTransactionNo = oldBankTransferNo;
            }
            bankTransfer.FK_ACObjectID = customerPayment.FK_ARCustomerID;
            bankTransfer.ACObjectType = ObjectType.Customer.ToString();
            bankTransfer.ACBankTransactionType = BankTransactionType.BankTransfer.ToString();
            bankTransfer.ACBankTransactionReference = customerPayment.ARCustomerPaymentNo;
            bankTransfer.ACBankTransactionReceiverBankName = bankName;
            bankTransfer.ACBankTransactionReceiverAccount = customerPayment.ARCustomerPaymentBankAccount;
            bankTransfer.FK_GECurrencyID = currencyID;
            bankTransfer.ACBankTransactionExchangeRate = exchangeRate;
            bankTransfer.ACBankTransactionTotalAmount = amount;
            bankTransfer.ACBankTransactionExchangeAmount = bankTransfer.ACBankTransactionTotalAmount * bankTransfer.ACBankTransactionExchangeRate;
            int bankTransferID = objBankTransactionsController.CreateObject(bankTransfer);

            objBankTransactionItemsController.DeleteByForeignColumn("FK_ACBankTransactionID", bankTransfer.ACBankTransactionID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.NopTienVaoTaiKhoan.ToString())
                {
                    ACBankTransactionItemsInfo item = new ACBankTransactionItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ACBankTransactionID = bankTransfer.ACBankTransactionID;
                    objBankTransactionItemsController.CreateObject(item);
                }
            }

            return bankTransfer;
        }
        #endregion
    }
}

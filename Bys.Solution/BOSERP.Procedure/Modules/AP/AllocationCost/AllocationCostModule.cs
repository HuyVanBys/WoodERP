using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.AllocationCost
{
    public class AllocationCostModule : BaseTransactionModule
    {
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchIDSearch";
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<BRBranchsInfo> BranchList;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public const string PurchaseOrderControlName = "fld_lkeFK_APPurchaseOrderID";
        public BOSLookupEdit PurchaseOrderControl;
        public AllocationCostModule()
        {
            Name = "AllocationCost";
            CurrentModuleEntity = new AllocationCostEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            BOSApp.InvalidateProductList();

            PurchaseOrderControl = (BOSLookupEdit)Controls[PurchaseOrderControlName];
            PurchaseOrderControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(PurchaseOrderControl_QueryPopUp);
        }

        void PurchaseOrderControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo allocationCost = (APAllocationCostsInfo)entity.MainObject;

            APPurchaseOrdersController poCtrl = new APPurchaseOrdersController();
            List<APPurchaseOrdersInfo> poList = poCtrl.GetPurchaseOrderByBatchProductID(allocationCost.FK_MMBatchProductID);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = poList;

        }

        public void SearchReceipt(DateTime fromDate, DateTime toDate)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo allocationCost = (APAllocationCostsInfo)entity.MainObject;
                ICReceiptsController receiptController = new ICReceiptsController();
                List<ICReceiptsInfo> receiptList = new List<ICReceiptsInfo>();
                if (allocationCost.APAllocationCostType == AllocationCostType.Import.ToString())
                {
                    receiptList = receiptController.GetReceiptForAllocateCost(fromDate, toDate,
                                                                                                  BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                  ModuleName.PurchaseReceipt,
                                                                                                  ADDataViewPermissionType.Module,
                                                                                                  allocationCost.FK_ACObjectID,
                                                                                                  allocationCost.APObjectType);
                }
                else
                {
                    receiptList = receiptController.GetOutSourcingReceiptForAllocateCost(fromDate, toDate, allocationCost.FK_APPurchaseOrderID);
                }
                guiFind<ICReceiptsInfo> guiFindReceipt = new guiFind<ICReceiptsInfo>(TableName.ICReceiptsTableName
                                                                                    , receiptList
                                                                                    , this
                                                                                    , true);
            stampp:
                if (guiFindReceipt.ShowDialog() == DialogResult.OK)
                {
                    if (allocationCost.APAllocationCostType == AllocationCostType.Import.ToString())
                    {
                        ICReceiptsInfo invalidReceipt = guiFindReceipt.SelectedObjects.FirstOrDefault(t => t.FK_ACObjectID != guiFindReceipt.SelectedObjects[0].FK_ACObjectID
                                                                                                        || t.ICObjectType != guiFindReceipt.SelectedObjects[0].ICObjectType);

                        if (invalidReceipt != null)
                        {
                            MessageBox.Show("Vui lòng chọn các phiếu nhập kho cùng đối tượng"
                                            , "Thông báo"
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Information);
                            goto stampp;
                        }

                        if (allocationCost.FK_ACObjectID == 0)
                        {
                            allocationCost.FK_ACObjectID = guiFindReceipt.SelectedObjects[0].FK_ACObjectID;
                            allocationCost.APObjectType = guiFindReceipt.SelectedObjects[0].ICObjectType;

                            allocationCost.ACObjectAccessKey = allocationCost.FK_ACObjectID + ";" + allocationCost.APObjectType;
                        }
                    }
                    APAllocationCostItemsController aciController = new APAllocationCostItemsController();
                    APAllocationCostItemsInfo allocationCostItem;
                    List<APAllocationCostItemsInfo> aciList = new List<APAllocationCostItemsInfo>();

                    foreach (ICReceiptsInfo receipt in guiFindReceipt.SelectedObjects)
                    {
                        allocationCostItem = entity.ReceiptItemList.FirstOrDefault(t => t.FK_ICReceiptID == receipt.ICReceiptID);
                        if (allocationCostItem == null)
                        {
                            aciList = aciController.GetItemByReceiptID(receipt.ICReceiptID);

                            entity.ReceiptItemList.AddRange(aciList);

                            if (allocationCost.APAllocationCostType == AllocationCostType.Import.ToString())
                            {
                                AddInvoiceItem(receipt.ICReceiptID);
                            }
                        }
                    }
                    if (allocationCost.APAllocationCostType == AllocationCostType.Import.ToString())
                    {
                        UpdateAmount();
                    }
                    else
                    {
                        entity.ReceiptItemList.GridControl.RefreshDataSource();
                    }

                    entity.UpdateMainObjectBindingSource();
                }
            }
        }


        public void ChooseInvoiceIn(DateTime fromDate, DateTime toDate)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo allocationCost = (APAllocationCostsInfo)entity.MainObject;

                APInvoiceInsController iiController = new APInvoiceInsController();
                List<APInvoiceInsInfo> iiList = iiController.GetInvoiceInForAllocationCost(fromDate, toDate, allocationCost.FK_APPurchaseOrderID);

                guiFind<APInvoiceInsInfo> guiChoose = new guiFind<APInvoiceInsInfo>(TableName.APInvoiceInsTableName
                                                                                    , iiList
                                                                                    , this
                                                                                    , true);
                if (guiChoose.ShowDialog() == DialogResult.OK)
                {
                    if (guiChoose.SelectedObjects != null
                        && guiChoose.SelectedObjects.Any())
                    {
                        APAllocationCostItemInvoiceInsInfo i;
                        foreach (APInvoiceInsInfo t in guiChoose.SelectedObjects)
                        {
                            i = entity.ACIInvoiceInList.FirstOrDefault(ii => ii.FK_APInvoiceInID == t.APInvoiceInID);
                            if (i == null)
                            {
                                i = new APAllocationCostItemInvoiceInsInfo();
                                i.FK_APInvoiceInID = t.APInvoiceInID;
                                i.APAllocationCostItemInvoiceInTotalCost = t.APInvoiceInTotalCost * t.APInvoiceInExchangeRate;
                                entity.ACIInvoiceInList.Add(i);
                            }
                        }
                        entity.ACIInvoiceInList.GridControl.RefreshDataSource();
                    }
                }

            }

        }

        public void ChooseShipment(DateTime fromDate, DateTime toDate)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo allocationCost = (APAllocationCostsInfo)entity.MainObject;

                ICShipmentsController shipmentCtrl = new ICShipmentsController();
                List<ICShipmentsInfo> shipmentList = shipmentCtrl.GetShipmentForAllocationCost(fromDate, toDate, allocationCost.FK_APPurchaseOrderID);

                guiFind<ICShipmentsInfo> guiChoose = new guiFind<ICShipmentsInfo>(TableName.ICShipmentsTableName
                                                                                    , shipmentList
                                                                                    , this
                                                                                    , true);
                if (guiChoose.ShowDialog() == DialogResult.OK)
                {
                    if (guiChoose.SelectedObjects != null
                        && guiChoose.SelectedObjects.Any())
                    {
                        List<ICShipmentsInfo> lstShipment;
                        APAllocationCostItemShipmentsInfo filterItem;
                        foreach (ICShipmentsInfo shipment in guiChoose.SelectedObjects)
                        {
                            filterItem = entity.ACIShipmentList.FirstOrDefault(t => t.FK_ICShipmentID == shipment.ICShipmentID);
                            if (filterItem == null)
                            {
                                lstShipment = shipmentCtrl.GetShipmentForAllocationCostDetail(shipment.ICShipmentID, allocationCost.FK_APPurchaseOrderID);
                                if (lstShipment != null
                                    && lstShipment.Any())
                                {
                                    shipmentList.ForEach(t =>
                                    {
                                        filterItem = new APAllocationCostItemShipmentsInfo();
                                        filterItem.FK_ICShipmentID = t.ICShipmentID;
                                        filterItem.APAllocationCostItemShipmentTotalAmount = t.ICShipmentTotalAmount;
                                        filterItem.FK_ICProductAttributeValueQualityID = t.FK_ICProductAttributeQualityID;
                                        entity.ACIShipmentList.Add(filterItem);
                                    });
                                }
                            }
                        }
                        entity.ACIShipmentList.GridControl.RefreshDataSource();
                    }
                }

            }

        }


        public void CalculateReceipt()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo allocationCost = (APAllocationCostsInfo)entity.MainObject;

                MMOperationsController operationController = new MMOperationsController();
                MMOperationsInfo operationSay = (MMOperationsInfo)operationController.GetObjectByNo(OperationNo.Say);
                int sayId = 0;
                if (operationSay != null)
                {
                    sayId = operationSay.MMOperationID;
                }


                ICProductAttributesController paController = new ICProductAttributesController();
                List<ICProductAttributesInfo> qualityList = paController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());

                int qualityAID = 0;
                int qualityBID = 0;
                int qualityCID = 0;

                qualityList.ForEach(t =>
                {
                    if (t.ICProductAttributeValue == "A")
                    {
                        qualityAID = t.ICProductAttributeID;
                    }
                    else if (t.ICProductAttributeValue == "B")
                    {
                        qualityBID = t.ICProductAttributeID;
                    }
                    else if (t.ICProductAttributeValue == "C")
                    {
                        qualityCID = t.ICProductAttributeID;
                    }
                });

                decimal qytA = 0;
                decimal qytB = 0;
                decimal qytC = 0;


                entity.ReceiptItemList.ForEach(t =>
                {
                    if (t.FK_ICProductAttributeQualityID != 0)
                    {
                        if (t.FK_ICProductAttributeQualityID == qualityAID)
                        {
                            qytA += t.APAllocationCostItemProductQty;
                        }
                        else if (t.FK_ICProductAttributeQualityID == qualityBID)
                        {
                            qytB += t.APAllocationCostItemProductQty;
                        }
                        else if (t.FK_ICProductAttributeQualityID == qualityCID)
                        {
                            qytC += t.APAllocationCostItemProductQty;
                        }
                    }
                });

                decimal unitcostavg = 0;
                decimal shipmentTotalA = 0;
                decimal shipmentTotalB = 0;
                decimal shipmentTotalC = 0;
                decimal shipmentTotalCost = 0;

                decimal unitcostAavg = 0;
                decimal unitcostBavg = 0;
                decimal unitcostCavg = 0;

                entity.ACIShipmentList.ForEach(t =>
                {

                    if (t.FK_ICProductAttributeValueQualityID == qualityAID)
                    {
                        shipmentTotalA += t.APAllocationCostItemShipmentTotalAmount;
                    }
                    else if (t.FK_ICProductAttributeValueQualityID == qualityBID)
                    {
                        shipmentTotalB += t.APAllocationCostItemShipmentTotalAmount;
                    }
                    else if (t.FK_ICProductAttributeValueQualityID == qualityCID)
                    {
                        shipmentTotalC += t.APAllocationCostItemShipmentTotalAmount;
                    }
                    shipmentTotalCost += t.APAllocationCostItemShipmentTotalAmount;
                });
                if (shipmentTotalCost > 0)
                {
                    if (sayId != allocationCost.FK_MMOperationID)
                    {
                        unitcostavg = shipmentTotalCost / (qytA + qytB + qytC);
                        unitcostAavg = unitcostavg;
                        unitcostBavg = unitcostavg;
                        unitcostCavg = unitcostavg;
                    }
                    else
                    {
                        if (qytA != 0)
                            unitcostAavg = shipmentTotalA / qytA;
                        if (qytB != 0)
                            unitcostBavg = shipmentTotalB / qytB;
                        if (qytC != 0)
                            unitcostCavg = shipmentTotalC / qytC;
                    }

                    if (qytA == 0
                        && (qytB * 100 / (qytA + qytB + qytC)) < 30)
                    {


                        unitcostCavg = unitcostCavg * 70 / 100;
                        if (qytB != 0)
                            unitcostBavg = (shipmentTotalCost - (unitcostCavg * qytC))
                                            / qytB;
                    }
                    else if
                        (qytA == 0
                            && (qytB * 100 / (qytA + qytB + qytC)) > 30)
                    {
                        unitcostCavg = unitcostCavg * 60 / 100;
                        if (qytB != 0)
                            unitcostBavg = (shipmentTotalCost - (unitcostCavg * qytC))
                                            / qytB;
                    }
                    else if (qytA > 0)
                    {
                        unitcostBavg = unitcostBavg * 110 / 100;
                        unitcostCavg = unitcostCavg * 40 / 100;
                        unitcostAavg = (shipmentTotalCost - (unitcostCavg * qytC) - (unitcostBavg * qytB))
                                        / qytA;
                    }

                    decimal totalInvoiceInAmount = entity.ACIInvoiceInList.Sum(t => t.APAllocationCostItemInvoiceInTotalCost);
                    decimal outsourcingCost = totalInvoiceInAmount / (qytA + qytB + qytC);

                    entity.ReceiptItemList.ForEach(t =>
                    {

                        if (t.FK_ICProductAttributeQualityID != 0)
                        {
                            t.APAllocationCostItemOutSourcingFeeAmt = outsourcingCost;
                            if (t.FK_ICProductAttributeQualityID == qualityAID)
                            {
                                t.APAllocationCostItemFeeAmount = unitcostAavg;

                            }
                            else if (t.FK_ICProductAttributeQualityID == qualityBID)
                            {
                                t.APAllocationCostItemFeeAmount = unitcostBavg;
                            }
                            else if (t.FK_ICProductAttributeQualityID == qualityCID)
                            {
                                t.APAllocationCostItemFeeAmount = unitcostCavg;
                            }

                            t.APAllocationCostItemProductUnitCost = t.APAllocationCostItemOutSourcingFeeAmt + t.APAllocationCostItemFeeAmount;
                            t.APAllocationCostItemTotalCost = t.APAllocationCostItemProductUnitCost * t.APAllocationCostItemProductQty;
                        }
                    });


                    entity.ReceiptItemList.GridControl.RefreshDataSource();

                }
            }
        }

        public void UpdateAmount()
        {
            CalInvoiceFeeAmount();
            CalReceiptFeeAmount();
            UpdateDocumentEntries();
        }

        public void AddInvoiceItem(int receiptID)
        {
            APAllocationCostItemInvoicesController aciInvoiceController = new APAllocationCostItemInvoicesController();
            APAllocationCostItemInvoicesInfo allocationCostItemInvoice;
            List<APAllocationCostItemInvoicesInfo> aciInvoiceList = new List<APAllocationCostItemInvoicesInfo>();

            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            aciInvoiceList = aciInvoiceController.GetItemByReceiptID(receiptID);

            aciInvoiceList.ForEach(t =>
            {
                allocationCostItemInvoice = entity.InvoiceInItemList.FirstOrDefault(i => i.FK_ACDocumentID == t.FK_ACDocumentID
                                                                             && i.FK_APInvoiceInID == t.FK_APInvoiceInID);
                if (allocationCostItemInvoice != null)
                {
                    //co roi thi remove de add lai (update du lieu moi nhat)
                    entity.InvoiceInItemList.Remove(allocationCostItemInvoice);
                }

                entity.InvoiceInItemList.Add(t);
            });

            entity.InvoiceInItemList.GridControl.RefreshDataSource();
        }

        public void RefreshInvoiceInData()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;

                List<int> receiptIDList = entity.ReceiptItemList.Select(t => t.FK_ICReceiptID).Distinct().ToList();

                if (receiptIDList != null && receiptIDList.Count > 0)
                {
                    receiptIDList.ForEach(id =>
                    {
                        AddInvoiceItem(id);
                    });
                }

                UpdateAmount();
            }
        }

        public void RefreshInvoiceInData(string criterion)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;

                mainObject.APAllocationCostCriterion = criterion;

                List<int> receiptIDList = entity.ReceiptItemList.Select(t => t.FK_ICReceiptID).Distinct().ToList();

                if (receiptIDList != null && receiptIDList.Count > 0)
                {
                    receiptIDList.ForEach(id =>
                    {
                        AddInvoiceItem(id);
                    });
                }

                UpdateAmount();
            }
        }

        public void CalInvoiceFeeAmount()
        {
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo allocationCost = (APAllocationCostsInfo)entity.MainObject;

            entity.InvoiceInItemList.ForEach(t =>
            {
                if (allocationCost.APAllocationCostCriterion == "Qty")
                {
                    if (t.APAllocationCostItemInvoiceDocumentTotalInvoiceQty > 0)
                        t.APAllocationCostItemInvoiceFeeAmount = t.APAllocationCostItemInvoiceProductQty
                                                            * t.APAllocationCostItemInvoiceDocumentAmount
                                                            / t.APAllocationCostItemInvoiceDocumentTotalInvoiceQty;
                    else
                        t.APAllocationCostItemInvoiceFeeAmount = 0;
                }
                else
                {
                    if (t.APAllocationCostItemInvoiceDocumentTotalInvoiceCost > 0)
                        t.APAllocationCostItemInvoiceFeeAmount = t.APAllocationCostItemInvoiceTotalCost
                                                            * t.APAllocationCostItemInvoiceDocumentAmount
                                                            / t.APAllocationCostItemInvoiceDocumentTotalInvoiceCost;
                    else
                        t.APAllocationCostItemInvoiceFeeAmount = 0;
                }
            });

            entity.InvoiceInItemList.GridControl.RefreshDataSource();
        }


        public void CalReceiptFeeAmount()
        {
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo allocationCost = (APAllocationCostsInfo)entity.MainObject;

            List<int> invoiceIDs = entity.ReceiptItemList.Select(o => o.FK_APInvoiceInID).Distinct().ToList();
            APBillOfLadingItemsController controller = new APBillOfLadingItemsController();
            List<APBillOfLadingItemsInfo> billOfLadingItems = new List<APBillOfLadingItemsInfo>();
            invoiceIDs.ForEach(o =>
            {
                billOfLadingItems = billOfLadingItems.Concat(controller.GetItemByInvoiceInID(o)).ToList();
            });
            decimal sumFeeInvoice = 0;
            APAllocationCostItemInvoicesInfo invoiceInInfo;
            entity.ReceiptItemList.ForEach(t =>
            {
                sumFeeInvoice = entity.InvoiceInItemList
                                    .Where(i => i.FK_APInvoiceInID == t.FK_APInvoiceInID)
                                    .Sum(i => i.APAllocationCostItemInvoiceFeeAmount);

                invoiceInInfo = entity.InvoiceInItemList
                                    .FirstOrDefault(i => i.FK_APInvoiceInID == t.FK_APInvoiceInID);

                if (invoiceInInfo != null)
                {
                    if (allocationCost.APAllocationCostCriterion == AllocationCostCriterion.Qty.ToString())
                    {
                        t.APAllocationCostItemFeeAmount = t.APAllocationCostItemProductQty
                                                                * sumFeeInvoice
                                                                / invoiceInInfo.APAllocationCostItemInvoiceReceiptedQty;
                    }
                    else
                    {
                        t.APAllocationCostItemFeeAmount = t.APAllocationCostItemTotalCost
                                                                * sumFeeInvoice
                                                                / invoiceInInfo.APAllocationCostItemInvoiceReceiptedCost;
                    }
                    t.APAllocationCostItemBOLFeeAmount = billOfLadingItems
                                                            .Where(o => o.FK_ICProductID == t.FK_ICProductID && o.FK_APInvoiceInID == t.FK_APInvoiceInID)
                                                            .Sum(o => o.APBillOfLadingItemEnviromentTaxAmount + o.APBillOfLadingItemConsumptionTaxAmount + o.APBillOfLadingItemImportTaxAmount);
                    t.APAllocationCostItemTotalFee = t.APAllocationCostItemFeeAmount + t.APAllocationCostItemBOLFeeAmount;
                }
                else
                {
                    t.APAllocationCostItemFeeAmount = 0;
                }
            });

            entity.ReceiptItemList.GridControl.RefreshDataSource();
        }

        //public void GetCurrentModuleDataViewPermission()
        //{
        //    CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

        //    List<int> branchIDList = new List<int>();
        //    foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
        //    {
        //        branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
        //    }

        //    if (branchIDList.Count == 0)
        //    {
        //        BranchList = new List<BRBranchsInfo>();
        //    }
        //    else
        //    {
        //        BRBranchsController objBranchsController = new BRBranchsController();
        //        List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

        //        BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
        //    }
        //}

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            APAllocationCostsController objAllocationCostsController = new APAllocationCostsController();
            APAllocationCostsInfo searchObject = (APAllocationCostsInfo)CurrentModuleEntity.SearchObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds;
            if (SearchBranchLookupEditControl != null && (
                SearchBranchLookupEditControl.EditValue.ToString() == ""
                || SearchBranchLookupEditControl.EditValue.ToString() == "0"))
            {
                if (BranchList.Count == 0)
                {
                    ds = objAllocationCostsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objAllocationCostsController.GetAllocationCostListByListOfBranchID(
                                                    searchObject.APAllocationCostNo,
                                                    objObjectsInfo.ACObjectID,
                                                    objObjectsInfo.ACObjectType,
                                                    searchObject.FK_BRBranchID,
                                                    searchObject.APAllocationCostSearchFromDate,
                                                    searchObject.APAllocationCostSearchToDate,
                                                    BranchList);
                }
            }
            else
            {
                ds = objAllocationCostsController.GetAllocationCostListByBranchID(searchObject.APAllocationCostNo,
                                                                            objObjectsInfo.ACObjectID,
                                                                            objObjectsInfo.ACObjectType,
                                                                            searchObject.FK_BRBranchID,
                                                                            searchObject.APAllocationCostSearchFromDate,
                                                                            searchObject.APAllocationCostSearchToDate);
            }
            return ds;
        }

        public override void InvalidateToolbar()
        {
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)CurrentModuleEntity.MainObject;

            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            ParentScreen.SetEnableOfToolbarButton("ChangeToNew", false);
            ParentScreen.SetEnableOfToolbarButton(BOSCommon.Constants.ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(BOSCommon.Constants.ToolbarButtons.UnPostedTransactions, false);
            if (mainObject.APAllocationCostID > 0)
            {

                if (mainObject.APAllocationCostStatus == AllocationCostStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton("ChangeToNew", true);
                    ParentScreen.SetEnableOfToolbarButton(BOSCommon.Constants.ToolbarButtons.PostedTransactions,
                        mainObject.APAllocationCostPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(BOSCommon.Constants.ToolbarButtons.UnPostedTransactions,
                        mainObject.APAllocationCostPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    ParentScreen.SetEnableOfToolbarButton("ChangeToNew", false);

                }
            }


            base.InvalidateToolbar();
        }


        private ACDocTypeEntrysInfo GetDefaultDocumentTypeEntry(string documentType, string entryType)
        {
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            if (defaultEntry == null)
                defaultEntry = new ACDocTypeEntrysInfo();
            return defaultEntry;
        }

        private void SetReceiptItemAccountID(APAllocationCostItemsInfo receiptItem, ACDocTypeEntrysInfo defaultEntry, List<ICStocksInfo> stocks)
        {
            if (receiptItem == null)
                return;

            ICStocksInfo stock = null;
            ICProductsForViewInfo product = null;

            if (stocks != null)
                stock = stocks.FirstOrDefault(item => item.ICStockID == receiptItem.FK_ICStockID);

            if (BOSApp.CurrentProductList != null)
                product = BOSApp.CurrentProductList.FirstOrDefault(item => item.ICProductID == receiptItem.FK_ICProductID);

            if (stock != null && stock.FK_ACAccountID != 0)
                receiptItem.FK_ACAccountID = stock.FK_ACAccountID;
            else if (product != null && product.FK_ACAccountID != 0)
                receiptItem.FK_ACAccountID = product.FK_ACAccountID;
            else if (defaultEntry != null)
                receiptItem.FK_ACAccountID = defaultEntry.ACDocTypeEntryAccountDefaultCredit;
            else
                receiptItem.FK_ACAccountID = 0;
        }

        protected override void UpdateDocumentEntries()
        {
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo objllocationCostsInfo = (APAllocationCostsInfo)entity.MainObject;
            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string accDocumentType = AccDocumentType.PhanBoChiPhiNhapKhau.ToString();

            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        accDocumentType,
                                                                        accDocumentType);

            //get stock list
            ICStocksController stockController = new ICStocksController();
            List<ICStocksInfo> stocks = null;
            if (BOSApp.LookupTables.ContainsKey(TableName.ICStocksTableName))
            {
                DataSet ds = BOSApp.LookupTables[TableName.ICStocksTableName] as DataSet;
                stocks = stockController.GetListFromDataSet(ds) as List<ICStocksInfo>;
                ds.Dispose();
            }
            if (stocks == null || stocks.Count == 0)
            {
                DataSet ds = stockController.GetAllObjects();
                stocks = stockController.GetListFromDataSet(ds) as List<ICStocksInfo>;
                ds.Dispose();
            }

            Dictionary<ACDocumentEntrysInfo, List<APAllocationCostItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<APAllocationCostItemsInfo>>();
            ACDocumentEntrysInfo foundItem;

            if (entity.ReceiptItemList != null)
            {
                foreach (APAllocationCostItemsInfo receiptItem in entity.ReceiptItemList)
                {
                    SetReceiptItemAccountID(receiptItem, defaultEntry, stocks);
                    foundItem = documentEntryAccounts.Keys.FirstOrDefault(item => item.FK_ACCreditAccountID == defaultEntry.ACDocTypeEntryAccountDefaultCredit
                                                                                && item.FK_ACDebitAccountID == receiptItem.FK_ACAccountID
                                                                                && item.ACEntryTypeName == accDocumentType);
                    if (foundItem == null)
                    {
                        foundItem = new ACDocumentEntrysInfo();
                        foundItem.FK_ACDebitAccountID = receiptItem.FK_ACAccountID;
                        foundItem.FK_ACCreditAccountID = defaultEntry.ACDocTypeEntryAccountDefaultCredit;
                        foundItem.ACEntryTypeName = defaultEntry.ACEntryTypeName;
                        documentEntryAccounts.Add(foundItem, new List<APAllocationCostItemsInfo>());
                    }
                    documentEntryAccounts[foundItem].Add(receiptItem);
                }
            }

            //update document entry amount
            if (documentEntryAccounts.Count != 0)
            {
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    foundItem = entity.DocumentEntryList.FirstOrDefault(item => item.FK_ACDebitAccountID == entry.FK_ACDebitAccountID
                                                                            && item.FK_ACCreditAccountID == entry.FK_ACCreditAccountID
                                                                            && item.ACEntryTypeName == entry.ACEntryTypeName);
                    if (foundItem == null)
                    {
                        foundItem = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                        foundItem.FK_ACDebitAccountID = entry.FK_ACDebitAccountID;
                        foundItem.FK_ACCreditAccountID = entry.FK_ACCreditAccountID;
                    }

                    foundItem.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.APAllocationCostItemFeeAmount);
                    foundItem.ACDocumentEntryExchangeAmount = foundItem.ACDocumentEntryAmount;
                    BOSApp.RoundByCurrency(foundItem, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(foundItem, "ACDocumentEntryAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }

            // remove redundant document entrys
            List<ACDocumentEntrysInfo> removedItems = null;

            if (documentEntryAccounts == null
                    || documentEntryAccounts.Keys == null
                    || documentEntryAccounts.Keys.Count == 0)
            {
                removedItems = new List<ACDocumentEntrysInfo>();
                removedItems.AddRange(entity.DocumentEntryList);
            }
            else
                removedItems = entity.DocumentEntryList.
                                    Where(item => documentEntryAccounts.Keys.Any(item1 => item.FK_ACCreditAccountID == item1.FK_ACCreditAccountID
                                                                                    && item.FK_ACDebitAccountID == item1.FK_ACDebitAccountID
                                                                                    && item.ACEntryTypeName == item1.ACEntryTypeName) == false).ToList();

            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                {
                    entity.DocumentEntryList.Remove(item);
                    if (entity.DocumentEntryList.Count == 0)
                        break;
                }
                if (entity.DocumentEntryList.Count == 0)
                {
                    GenerateAccountingData();
                }
            }


            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        public override bool ActionComplete()
        {
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;
            int allocationCostID = mainObject.APAllocationCostID;

            bool result = base.ActionComplete();

            if (result)
            {
                ICInventoryStocksController inventoryStockController = new ICInventoryStocksController();
                inventoryStockController.UpdateCostAndReferenceDocsByAllocationCostID(allocationCostID);
            }

            return result;
        }

        public void ChangeToNew()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;

                if (mainObject.APAllocationCostStatus == AllocationCostStatus.Complete.ToString())
                {
                    mainObject.APAllocationCostStatus = AllocationCostStatus.New.ToString();
                }

                entity.UpdateMainObject();
                InvalidateToolbar();

                //revert inventory stock unit cost
                ICInventoryStocksController inventoryStockController = new ICInventoryStocksController();
                inventoryStockController.UpdateCostAndReferenceDocsByAllocationCostIDToOri(mainObject.APAllocationCostID);

            }
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;
            mainObject.APAllocationCostPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.APAllocationCostID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, mainObject.APAllocationCostID, ModulePostingType.Accounting, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;
            mainObject.APAllocationCostPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.APAllocationCostID, PostedTransactionStatus.UnPosted.ToString());
            GLHelper.UnPostedTransactions(this.Name, mainObject.APAllocationCostID, ModulePostingType.Accounting, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public override void ModuleAfterCompleted()
        {
            base.ModuleAfterCompleted();
            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;
            mainObject.APAllocationCostPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            GLHelper.PostedTransactions(this.Name, mainObject.APAllocationCostID, ModulePostingType.Accounting, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public string GetMainObjectType()
        {
            string type = string.Empty;

            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;

            type = mainObject.APAllocationCostType;

            return type;
        }

        public override void ActionNew()
        {
            base.ActionNew();

            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;

            mainObject.APAllocationCostType = AllocationCostType.Import.ToString();
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionNewOutSourcing()
        {
            base.ActionNew();

            AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
            APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;

            mainObject.APAllocationCostType = AllocationCostType.LumberOutSourcing.ToString();
            entity.UpdateMainObjectBindingSource();
        }


        public void ChangePurchaseOrder(int purchaseOrderID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;

                mainObject.FK_APPurchaseOrderID = purchaseOrderID;

                entity.ReceiptItemList.Clear();
                entity.ACIInvoiceInList.Clear();
                entity.ACIShipmentList.Clear();

                entity.ReceiptItemList.GridControl.RefreshDataSource();
                entity.ACIInvoiceInList.GridControl.RefreshDataSource();
                entity.ACIShipmentList.GridControl.RefreshDataSource();

            }
        }

        public void ChangeBatchProduct(int batchProductID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AllocationCostEntities entity = (AllocationCostEntities)CurrentModuleEntity;
                APAllocationCostsInfo mainObject = (APAllocationCostsInfo)entity.MainObject;

                mainObject.FK_MMBatchProductID = batchProductID;

                MMBatchProductsController bpCtrl = new MMBatchProductsController();
                MMBatchProductsInfo bp = (MMBatchProductsInfo)bpCtrl.GetObjectByID(batchProductID);
                if (bp != null)
                {
                    mainObject.FK_MMOperationID = bp.FK_MMOperationID;
                }

                ChangePurchaseOrder(0);
            }
        }
    }
}

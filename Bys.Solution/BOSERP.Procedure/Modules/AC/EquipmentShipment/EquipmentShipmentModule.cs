using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.GenaralLeadger;
using BOSLib;
using DevExpress.XtraEditors;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentShipment
{
    public class EquipmentShipmentModule : GLShipmentModule
    {
        #region Constants
        public const string ShipmentItemGridControlName = "fld_dgcShipmentItems";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        #region Variables
        /// <summary>
        /// A variable to store the template entry for a non-allocated equipment
        /// </summary>

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public List<ICProductsInfo> CCDCList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        public BOSLookupEdit CCDCLookupEditControl;
        public const string CCDCLookupEditControlName = "fld_lkeFK_ICProductID";
        public EquipmentShipmentModule()
        {
            Name = ModuleName.EquipmentShipment;
            CurrentModuleEntity = new EquipmentShipmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCCDCList();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            CCDCLookupEditControl = (BOSLookupEdit)Controls[CCDCLookupEditControlName];
            CCDCLookupEditControl.Properties.DataSource = CCDCList;
            CCDCLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(CCDCLookupEditControl_QueryPopUp);
        }

        public void GetCCDCList()
        {
            ICProductsController objProductController = new ICProductsController();
            CCDCList = (List<ICProductsInfo>)objProductController.GetListFromDataSet(objProductController.GetProductListByDepreciationMonthAndIdentifiedEquipments(null, null, null));
        }

        private void CCDCLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = CCDCList;
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICShipmentsController shipmentController = new ICShipmentsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = shipmentController.GetDataSetByID(-1);
                }
                else
                {
                    ds = shipmentController.GetEquipmentByListOfBranchID(searchObject.ICShipmentNo,
                                                            searchObject.FK_HREmployeeID,
                                                            null,
                                                            ShipmentType.EquipmentShipment.ToString(),
                                                            searchObject.ShipmentDateFrom,
                                                            searchObject.ShipmentDateTo,
                                                            BranchList);
                }
            }
            else
            {
                ds = shipmentController.GetEquipmentListDataSet(searchObject.ICShipmentNo,
                                                            searchObject.FK_HREmployeeID,
                                                            null,
                                                            searchObject.FK_BRBranchID,
                                                            ShipmentType.EquipmentShipment.ToString(),
                                                            searchObject.ShipmentDateFrom,
                                                            searchObject.ShipmentDateTo);
            }

            return ds;
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();
                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        public void AddItemToShipmentItemsList()
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            item.ICShipmentItemDepriciationDate = BOSApp.GetCurrentServerDate();
            if (item.FK_ICProductID > 0)
            {
                item.ICShipmentItemProductUnitPrice = 0;
                item.ICShipmentItemTotalAmount = 0;
                item.ICShipmentItemPrice = 0;
                item.ICShipmentItemProductIdentifiedEquipmentNo = string.Empty;
                item.ICShipmentItemProductIdentifiedEquipmentNo = entity.GenerateProductIdentifiedEquipmentNo(item);
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                entity.ShipmentItemList.AddObjectToList();
                int index = 0;
                entity.ShipmentItemList.ForEach(o =>
                {
                    o.STT = ++index;
                });
                UpdateTotalAmount();
            }
        }

        public void ChangeItemFromShipmentItemsList()
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            if (entity.ShipmentItemList.CurrentIndex < 0)
                return;

            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
            item.ICShipmentItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate) * item.ICShipmentItemProductFactor;
            entity.SetProductPriceByProductUnitPrice(item);
            entity.ShipmentItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        public void ChangeItemSerieNo(ICShipmentItemsInfo item)
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            item.ICShipmentItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate) * item.ICShipmentItemProductFactor;
            item.ICShipmentItemTotalCost = item.ICShipmentItemProductUnitCost * item.ICShipmentItemProductQty;
            /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
            ICProductSeriesController productSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo productSeriesInfo = (ICProductSeriesInfo)productSeriesController.GetObjectByID(item.FK_ICProductSerieID);
            if (productSeriesInfo != null)
            {
                item.FK_ICModelID = productSeriesInfo.FK_ICModelID;
                item.FK_ICModelDetailID = productSeriesInfo.FK_ICModelDetailID;
            }
            /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
            CurrentModuleEntity.SetProductPriceByProductUnitPrice(item);
        }

        public void ChangeItemQty()
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICShipmentItemsInfo item = entity.ModuleObjects[TableName.ICShipmentItemsTableName] as ICShipmentItemsInfo;
            if (item != null)
            {
                ICShipmentItemsInfo oldObj = null;
                if (entity.ShipmentItemList.BackupList != null)
                    oldObj = entity.ShipmentItemList.BackupList.FirstOrDefault(si => si.Id == item.Id);

                item.ICShipmentItemRemainedAmount = item.ICShipmentItemProductUnitPrice - item.ICShipmentItemDepreciatedAmount;
                if (oldObj == null)
                    item.ICShipmentItemProductRemainedQty = item.ICShipmentItemProductQty;
                else
                    item.ICShipmentItemProductRemainedQty = item.ICShipmentItemProductRemainedQty + (item.ICShipmentItemProductQty - oldObj.ICShipmentItemProductQty);

                entity.ShipmentItemList.ChangeObjectFromList();
                UpdateTotalAmount();
            }
        }

        public void DeleteItemFromShipmentItemsList()
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void ChangeStock(int stockID)
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ShipmentItemList.Count > 0)
                {
                    if (MessageBox.Show(EquipmentShipmentLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                        {
                            item.FK_ICStockID = stockID;
                            ChangeItemSerieNo(item);
                        }
                        entity.ShipmentItemList.GridControl.RefreshDataSource();
                    }
                }
            }
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                objShipmentsInfo.ICShipmentSubTotalAmount = 0;
                foreach (ICShipmentItemsInfo entItem in entity.ShipmentItemList)
                {
                    entItem.ICShipmentItemTotalCost = entItem.ICShipmentItemProductUnitCost * entItem.ICShipmentItemProductQty;
                    BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
                    objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                }

                objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;

                BOSApp.RoundByCurrency(objShipmentsInfo, "ICShipmentSubTotalAmount", objShipmentsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objShipmentsInfo, "ICShipmentTotalAmount", objShipmentsInfo.FK_GECurrencyID);
                entity.UpdateMainObjectBindingSource();

                UpdateDocumentEntries();
            }
        }

        public bool IsValidItemList()
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICProductIdentifiedEquipmentsController pieController = new ICProductIdentifiedEquipmentsController();
            ICProductIdentifiedEquipmentsInfo pieInfo;

            int i = 1;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
            {
                if (shipmentItem.FK_ACDepreciationCostAccountID <= 0 || shipmentItem.ICShipmentItemDepreciationMonths <= 0)
                {
                    MessageBox.Show(string.Format(EquipmentShipmentLocalizedResources.DepreciationCostAccountIsRequiredMessage, shipmentItem.ICShipmentItemProductName),
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return false;
                }
                if (shipmentItem.FK_ICProductSerieID == 0)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(shipmentItem.FK_ICProductID);
                    if (objProductsInfo != null && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString())
                    {
                        MessageBox.Show(string.Format(EquipmentShipmentLocalizedResources.SerieNoIsRequiredMessage, shipmentItem.ICShipmentItemProductName),
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        return false;
                    }
                }
                if ((entity.ShipmentItemList.Where(o => o.FK_ICProductID == shipmentItem.FK_ICProductID && o.STT < shipmentItem.STT).Count()) <= 0)
                {
                    string lastIdentifiedEquipmentNo = pieController.GetProductIdentifiedEquipmentNo(shipmentItem.FK_ICProductID);
                    if (lastIdentifiedEquipmentNo.Contains("."))
                    {
                        lastIdentifiedEquipmentNo = lastIdentifiedEquipmentNo.Substring(lastIdentifiedEquipmentNo.LastIndexOf(".") + 1, lastIdentifiedEquipmentNo.Length - lastIdentifiedEquipmentNo.LastIndexOf(".") - 1);
                        try
                        {
                            i = Convert.ToInt32(lastIdentifiedEquipmentNo) + 1;
                        }
                        catch (Exception ex) { }
                    }
                }
            }

            ICShipmentItemsInfo invalidItem = entity.ShipmentItemList.FirstOrDefault(t => string.IsNullOrEmpty(t.ICShipmentItemProductIdentifiedEquipmentNo));
            if (invalidItem != null)
            {
                MessageBox.Show("Mã định danh không được để trống!",
                                   CommonLocalizedResources.MessageBoxDefaultCaption,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return false;
            }

            List<string> lst = entity.ShipmentItemList.Select(t => t.ICShipmentItemProductIdentifiedEquipmentNo).ToList();
            var query = lst.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            if (query != null && query.Count > 0)
            {
                MessageBox.Show("Trùng mã định danh trong danh sách."
                                + Environment.NewLine + "Vui lòng kiểm tra lại!",
                                  CommonLocalizedResources.MessageBoxDefaultCaption,
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                return false;
            }

            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                pieInfo = (ICProductIdentifiedEquipmentsInfo)pieController.GetObjectByNo(item.ICShipmentItemProductIdentifiedEquipmentNo);
                if (pieInfo != null && pieInfo.ICProductIdentifiedEquipmentID != item.FK_ICProductIdentifiedEquipmentID)
                {
                    MessageBox.Show("Mã định danh " + item.ICShipmentItemProductIdentifiedEquipmentNo + " đã tồn tại."
                                + Environment.NewLine + "Vui lòng kiểm tra lại!",
                                  CommonLocalizedResources.MessageBoxDefaultCaption,
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return false;
                }
            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            return true;
        }

        public override int ActionSave()
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;

            entity.ShipmentItemList.EndCurrentEdit();

            if (!IsValidItemList())
            {
                return 0;
            }
            UpdateTotalAmount();

            return base.ActionSave();
        }

        public List<ICProductIdentifiedEquipmentsInfo> GetIdentifiedEquipmentList()
        {
            List<ICProductIdentifiedEquipmentsInfo> identifiedEquipmentList = new List<ICProductIdentifiedEquipmentsInfo>();
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            EquipmentShipmentEntities entity = CurrentModuleEntity as EquipmentShipmentEntities;
            ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
            if (item != null)
            {
                identifiedEquipmentList = objProductIdentifiedEquipmentsController.GetItemByProductIDAndProductSerieID(item.FK_ICProductID, item.FK_ICProductSerieID);
            }
            return identifiedEquipmentList;
        }

        public void ResetModelDetail(ICShipmentItemsInfo item)
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            List<ICModelDetailsInfo> ModelDetailsList = new List<ICModelDetailsInfo>();
            if (item != null)
            {
                ModelDetailsList = objModelDetailsController.GetModelDetailByModelID(item.FK_ICModelID);
            }
            if (ModelDetailsList.Count > 0)
            {
                item.FK_ICModelDetailID = ModelDetailsList.FirstOrDefault().ICModelDetailID;
            }
            else
            {
                item.FK_ICModelDetailID = 0;
            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void ActionNewFromAllocationProposal()
        {
            ActionNew();
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            //objShipmentsInfo.ICShipmentType
            MMAllocationPlanItemsController objController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> listAllocationPlanItemsInfo = objController.GetItemsInstrumentListForEquipmentShipment(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            guiFind<MMAllocationPlanItemsInfo> guifind = new guiFind<MMAllocationPlanItemsInfo>(TableName.MMAllocationPlanItemsTableName,
                                                                                                        listAllocationPlanItemsInfo
                                                                                                        , this, true, true);
        stampp:
            if (guifind.ShowDialog() == DialogResult.OK)
            {
                List<MMAllocationPlanItemsInfo> selectedObjectLists = (List<MMAllocationPlanItemsInfo>)guifind.SelectedObjects;

                if (selectedObjectLists != null && selectedObjectLists.Count > 0)
                {
                    MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)(new MMAllocationPlansController()).GetObjectByID(selectedObjectLists[0].FK_MMAllocationPlanID);
                    if (objAllocationPlansInfo != null)
                    {
                        objShipmentsInfo.FK_MMBatchProductID = objAllocationPlansInfo.FK_MMBatchProductID;
                        objShipmentsInfo.FK_MMOperationID = objAllocationPlansInfo.FK_MMOperationID;
                        objShipmentsInfo.FK_MMOperationID = objAllocationPlansInfo.FK_MMOperationID;
                        objShipmentsInfo.FK_ICProductAttributeTTMTID = objAllocationPlansInfo.FK_ICProductAttributeTTMTID;
                        objShipmentsInfo.ICShipmentPONo = objAllocationPlansInfo.MMAllocationPlanPONo;
                        objShipmentsInfo.ICShipmentDesc = objAllocationPlansInfo.MMAllocationPlanDesc;
                        HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objAllocationPlansInfo.FK_HREmployeeIDReceive);
                        if (objEmployeesInfo != null)
                        {
                            objShipmentsInfo.ICShipmentDeliveryContactName = objEmployeesInfo.HREmployeeName;
                        }
                        objShipmentsInfo.FK_HRDepartmentRoomGroupItemID = objAllocationPlansInfo.FK_HRDepartmentRoomGroupItemID;
                    }

                    ICProductsController objProductsController = new ICProductsController();
                    List<ICShipmentItemsInfo> resultLists = new List<ICShipmentItemsInfo>();
                    foreach (MMAllocationPlanItemsInfo item in selectedObjectLists)
                    {
                        ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                        BOSUtil.CopyObject(item, objShipmentItemsInfo);
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            objShipmentItemsInfo.ICShipmentItemDepreciationMonths = objProductsInfo.ICProductDepreciationMonths;
                            objShipmentItemsInfo.FK_ACDepreciationCostAccountID = objProductsInfo.FK_ACDepreciationCostAccountID;
                        }
                        objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(item.MMAllocationPlanItemQty - item.MMAllocationProposalItemQty, 4, MidpointRounding.AwayFromZero);
                        objShipmentItemsInfo.ICShipmentItemProductRemainedQty = objShipmentItemsInfo.ICShipmentItemProductQty;
                        objShipmentItemsInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
                        objShipmentItemsInfo.ICShipmentItemBatchProductItemProductSerial = item.MMAllocationPlanItemBatchProductItemProductSerial;
                        objShipmentItemsInfo.FK_MMAllocationPlanItemID = item.Id;
                        objShipmentItemsInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                        objShipmentItemsInfo.FK_MMLineID = item.FK_MMLineID;
                        objShipmentItemsInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                        objShipmentItemsInfo.FK_HREmployeeUserID = item.FK_HREmployeeIDReceive;
                        objShipmentItemsInfo.ICShipmentItemDepriciationDate = BOSApp.GetCurrentServerDate();
                        objShipmentItemsInfo.FK_HREmployeeReceverID = item.FK_HREmployeeIDReceive;
                        objShipmentItemsInfo.ICShipmentItemComment = item.MMAllocationPlanItemComment;
                        resultLists.Add(objShipmentItemsInfo);
                    }

                    ICShipmentItemsInfo objCloneShipmentItemsInfo = new ICShipmentItemsInfo();
                    int soLuong = 0;
                    for (int i = 0; i < resultLists.Count; i++)
                    {
                        soLuong = Convert.ToInt32(resultLists[i].ICShipmentItemProductQty);
                        if (soLuong > 1)
                        {
                            resultLists[i].ICShipmentItemProductQty = 1;
                            entity.SetProductCost(resultLists[i]);
                        }

                        objCloneShipmentItemsInfo = (ICShipmentItemsInfo)resultLists[i].Clone();
                        objCloneShipmentItemsInfo.Id = 0;
                        objCloneShipmentItemsInfo.ICShipmentItemProductQty = 1;
                        if (soLuong > 1)
                        {
                            for (int j = 0; j < soLuong - 1; j++)
                            {
                                resultLists.Add((ICShipmentItemsInfo)objCloneShipmentItemsInfo.Clone());
                            }
                        }
                    }

                    entity.ShipmentItemList.Invalidate(resultLists.OrderBy(o => o.FK_MMAllocationPlanItemID).ToList());
                    int index = 0;
                    entity.ShipmentItemList.ForEach(o =>
                    {
                        o.STT = ++index;
                        o.ICShipmentItemProductIdentifiedEquipmentNo = string.Empty;
                        o.ICShipmentItemProductIdentifiedEquipmentNo = entity.GenerateProductIdentifiedEquipmentNo(o);
                    });
                    UpdateTotalAmount();
                    entity.UpdateMainObjectBindingSource();
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
                else
                {
                    MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    goto stampp;
                }
            }
            else
            {
                ActionCancel();
            }
        }

        public void ApproveEquipmentShipment()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                if (IsValidItemList())
                {
                    EquipmentShipmentEntities entity = (EquipmentShipmentEntities)CurrentModuleEntity;
                    ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                    if (entity.ShipmentItemList.BackupList != null && entity.ShipmentItemList.BackupList.Count > 0)
                    {
                        entity.ShipmentItemList.BackupList.Clear();
                    }
                    if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                    {
                        return;
                    }
                    ActionComplete();
                }
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (objShipmentsInfo.ICShipmentID > 0)
            {
                if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
        }

        #region Mở chứng từ
        public override bool ActionCancelComplete()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ICShipmentID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                if (mainObject.ICShipmentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                mainObject.ICShipmentStatus = ShipmentStatus.New.ToString();
                CurrentModuleEntity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                base.ActionCancelComplete();
                InvalidateToolbar();
            }
            return true;
        }
        #endregion

        #region Xóa chứng từ
        public override void ActionDelete()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject.Clone();
            if (mainObject.ICShipmentID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                if (mainObject.ICShipmentPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                base.ActionDelete();
            }
        }
        #endregion

        private bool CheckRelativeDocument()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)CurrentModuleEntity.MainObject.Clone();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByEquipmentShipmentID(mainObject.ICShipmentID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}


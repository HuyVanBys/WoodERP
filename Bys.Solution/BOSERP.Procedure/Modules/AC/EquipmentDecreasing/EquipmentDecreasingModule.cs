using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentDecreasing
{
    public class EquipmentDecreasingModule : BaseTransactionModule
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
        /// Gets or sets the default entry of the equipment decreasing
        /// </summary>
        private ACDocTypeEntrysInfo EquipmentDecreasingDefaultEntry;
        public BOSLookupEdit CCDCLookupEditControl;
        public const string CCDCLookupEditControlName = "fld_lkFK_ICProductID";
        #endregion
        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion
        public EquipmentDecreasingModule()
        {
            Name = ModuleName.EquipmentDecreasing;
            CurrentModuleEntity = new EquipmentDecreasingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[EquipmentDecreasingModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            EquipmentDecreasingDefaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                                                AccDocumentType.GiamCCDC.ToString(),
                                                                                                AccEntryType.GhiGiamCCDC.ToString());
            CCDCLookupEditControl = (BOSLookupEdit)Controls[CCDCLookupEditControlName];
            CCDCLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(CCDCLookupEditControl_QueryPopUp);
        }

        void CCDCLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {

            LookUpEdit lke = (LookUpEdit)sender;

            ICProductsController objProductController = new ICProductsController();
            List<ICProductsForViewInfo> CCDCList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Equipment.ToString()).ToList();
            //   objProductController.GetProductByProductType(ProductType.Equipment.ToString());
            lke.Properties.DataSource = CCDCList;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
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
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //DataSet ds = objShipmentsController.GetEquipmentShipmentList(
            //                                                        searchObject.ICShipmentNo,
            //                                                        searchObject.FK_HREmployeeID,
            //                                                        searchObject.HRDepartmentRoomID,
            //                                                        ShipmentType.EquipmentDecreasing.ToString(),
            //                                                        searchObject.ShipmentDateFrom,
            //                                                        searchObject.ShipmentDateTo);
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objShipmentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objShipmentsController.GetEquipmentShipmentListDataSetByListOfBranchID(
                                                                                searchObject.ICShipmentNo,
                                                                                searchObject.FK_HREmployeeID,
                                                                                searchObject.HRDepartmentRoomID,
                                                                                ShipmentType.EquipmentDecreasing.ToString(),
                                                                                searchObject.ShipmentDateFrom,
                                                                                searchObject.ShipmentDateTo,
                                                                                BranchList);
                }
            }
            else
            {
                ds = objShipmentsController.GetEquipmentShipmentListDataSet(
                                                                   searchObject.ICShipmentNo,
                                                                   searchObject.FK_HREmployeeID,
                                                                   searchObject.HRDepartmentRoomID,
                                                                   searchObject.FK_BRBranchID,
                                                                   ShipmentType.EquipmentDecreasing.ToString(),
                                                                   searchObject.ShipmentDateFrom,
                                                                   searchObject.ShipmentDateTo);
            }
            return ds;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        }

        /// <summary>
        /// Add the selected item to the item list
        /// </summary>
        public void AddItemToShipmentItemsList()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            if (item.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                entity.ShipmentItemList.AddObjectToList();
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Change the selected item to the item list
        /// </summary>
        public void ChangeItemFromShipmentItemsList()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            entity.ShipmentItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Delete the selected item from the item list
        /// </summary>
        public void DeleteItemFromShipmentItemsList()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Check for valid shipped quantity of an item
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="qty">Shipped quantity</param>
        /// <returns>Empty string if valid, otherwise the error description</returns>
        public string CheckForValidDecreasedQty(ICShipmentItemsInfo item, decimal qty)
        {
            string errorMsg = string.Empty;
            if (qty > item.EquipmentReceiptedQty + item.ICShipmentItemProductQty)
            {
                errorMsg = EquipmentDecreasingLocalizedResources.DecreasedQtyCannotBeGreaterThanReceiptedQtyMessage;
            }
            else
            {
                item.EquipmentReceiptedQty = item.EquipmentReceiptedQty + item.ICShipmentItemProductQty - qty;
                //item.ICShipmentItemProductRemainedQty = qty;
            }
            return errorMsg;
        }

        /// <summary>
        /// Update the total amounts of the shipment
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                objShipmentsInfo.ICShipmentSubTotalAmount = 0;
                foreach (ICShipmentItemsInfo entItem in entity.ShipmentItemList)
                {
                    BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
                    objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;

                }


                objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;

                BOSApp.RoundByCurrency(objShipmentsInfo, "ICShipmentSubTotalAmount", objShipmentsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objShipmentsInfo, "ICShipmentTotalAmount", objShipmentsInfo.FK_GECurrencyID);

                entity.ShipmentItemList.GridControl.RefreshDataSource();

                entity.UpdateMainObjectBindingSource();

                UpdateDocumentEntries();
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetEquipmentItemsForDecreasing();
            guiFind<ICShipmentItemsInfo> guiFind = new guiFind<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName, shipmentItems, this, true);
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
                entity.ShipmentItemList.Clear();
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                ICProductSeriesController productSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo productSeriesInfo;
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                foreach (ICShipmentItemsInfo item in guiFind.SelectedObjects)
                {
                    //item.ICShipmentItemProductRemainedQty = item.ICShipmentItemProductRemainedQty - item.ICShipmentItemProductQty;
                    item.EquipmentReceiptedQty = item.EquipmentReceiptedQty - item.ICShipmentItemProductQty;
                    /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                    productSeriesInfo = (ICProductSeriesInfo)productSeriesController.GetObjectByID(item.FK_ICProductSerieID);
                    if (productSeriesInfo != null)
                    {
                        item.FK_ICModelID = productSeriesInfo.FK_ICModelID;
                        item.FK_ICModelDetailID = productSeriesInfo.FK_ICModelDetailID;
                    }
                    /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                    item.ICShipmentItemTotalAmount = item.ICShipmentItemProductQty * item.ICShipmentItemProductUnitPrice;
                    entity.ShipmentItemList.Add(item);
                }
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                UpdateTotalAmount();
            }
            else
            {
                ActionCancel();
            }
        }

        public override int ActionSave()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            //TNDLoc [EDIT][23/06/2018][Bỏ ràng buộc chọn mã lô],START
            //foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            //{
            //    if (string.IsNullOrEmpty(item.ICShipmentItemProductSerialNo))
            //    {
            //        MessageBox.Show(string.Format(EquipmentDecreasingLocalizedResources.SerieNoIsRequiredMessage, item.ICShipmentItemProductName),
            //                        CommonLocalizedResources.MessageBoxDefaultCaption,
            //                        MessageBoxButtons.OK,
            //                        MessageBoxIcon.Error);
            //        return 0;
            //    }
            //}
            //TNDLoc [EDIT][23/06/2018][Bỏ ràng buộc chọn mã lô],END
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            if (objShipmentsInfo.FK_ACObjectID == 0)
            {
                List<ACAccountsInfo> accountList = new List<ACAccountsInfo>();
                ACAccountsController objAccountsController = new ACAccountsController();
                List<ACAccountsInfo> accountList331 = objAccountsController.GetListAccountAndParentByACAccountID(AccAccount.Acc331);
                if (accountList331 != null && accountList331.Count > 0)
                {
                    accountList.AddRange(accountList331);
                }
                List<ACAccountsInfo> accountList131 = objAccountsController.GetListAccountAndParentByACAccountID(AccAccount.Acc131);
                if (accountList131 != null && accountList131.Count > 0)
                {
                    accountList.AddRange(accountList131);
                }
                if (entity.DocumentEntryList != null && entity.DocumentEntryList.Count > 0)
                {
                    bool checkaccount = false;
                    entity.DocumentEntryList.ForEach(a =>
                        {
                            if (accountList.FirstOrDefault(b => b.ACAccountID == a.FK_ACDebitAccountID) != null)
                            {
                                checkaccount = true;
                            };
                        });
                    if (checkaccount)
                    {
                        MessageBox.Show(EquipmentDecreasingLocalizedResources.ACobjectNotnull, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }
                }
            }
            entity.ShipmentItemList.EndCurrentEdit();
            UpdateTotalAmount();
            return base.ActionSave();
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
                ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
                RPEquipmentDecreasing report = new RPEquipmentDecreasing(mainObject.FK_GECurrencyID);
                InitEquipmentDecreasingReport(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }
        public List<ICProductIdentifiedEquipmentsInfo> GetIdentifiedEquipmentList()
        {
            List<ICProductIdentifiedEquipmentsInfo> identifiedEquipmentList = new List<ICProductIdentifiedEquipmentsInfo>();
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            EquipmentDecreasingEntities entity = CurrentModuleEntity as EquipmentDecreasingEntities;
            ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
            if (item != null)
            {
                identifiedEquipmentList = objProductIdentifiedEquipmentsController.GetItemByProductIDAndProductSerieID(item.FK_ICProductID, item.FK_ICProductSerieID);

            }
            return identifiedEquipmentList;
        }
        /// <summary>
        /// Init an equipment decreasing report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        /// <param name="shipmentID">Equipment decreasing id</param>
        private void InitEquipmentDecreasingReport(RPEquipmentDecreasing report, int shipmentID)
        {
            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            List<ICShipmentItemsInfo> items = objReportsController.GetEquipmentItemsByShipmentID(shipmentID);
            report.DataSource = items;
        }

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            entity.DocumentEntryList.Clear();


            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            ICProductsInfo product;

            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(EquipmentDecreasingDefaultEntry, entity.DocumentEntryList);
                // entry.FK_ACCreditAccountID = item.FK_ACDepreciationAccountID;
                //  entry.FK_ACDebitAccountID = item.FK_ACDepreciationCostAccountID;
                product = productList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductID);
                if (product == null)
                {
                    product = (ICProductsInfo)productController.GetObjectByID(item.FK_ICProductID);
                    if (product != null)
                    {
                        productList.Add(product);
                    }
                }

                if (product != null && product.FK_ACDepreciationAccountID != 0)
                {
                    entry.FK_ACCreditAccountID = product.FK_ACDepreciationAccountID;
                }

                if (entry.FK_ACCreditAccountID == 0)
                {
                    if (EquipmentDecreasingDefaultEntry != null)
                    {
                        entry.FK_ACCreditAccountID = EquipmentDecreasingDefaultEntry.ACDocTypeEntryAccountDefaultCredit;
                    }
                }

                entry.ACDocumentEntryDesc += string.Format(" {0} {1} {2}", item.ICShipmentItemProductName, EquipmentDecreasingLocalizedResources.Room, item.HRDepartmentRoomName);
                entry.ACDocumentEntryAmount = item.ICShipmentItemRemainedAmount * item.ICShipmentItemProductQty;
                entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount;

                BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objShipmentsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion

        public void ResetModelDetail(ICShipmentItemsInfo item)
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
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
        public void ChangeObject()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(mainObject.ACObjectAccessKey);
            if (objObjectsInfo != null)
            {
                mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                mainObject.ICObjectType = objObjectsInfo.ACObjectType;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ICShipmentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICShipmentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ICShipmentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICShipmentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);
            ActionPosted();
        }

        public override void InvalidateToolbar()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            if (mainObject.ICShipmentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit,
                    mainObject.ICShipmentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                    mainObject.ICShipmentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                    mainObject.ICShipmentPostedStatus == PostedTransactionStatus.Posted.ToString());
            }
            base.InvalidateToolbar();
        }
    }
}

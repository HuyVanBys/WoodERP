using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetDecreasing
{
    public class AssetDecreasingModule : BaseTransactionModule
    {
        #region Constants
        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItems";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string ProductControlName = "fld_lkeFK_ICProductID";
        #endregion

        #region Variables
        /// <summary>
        /// A variable to store the template entry for a non-allocated equipment
        /// </summary>
        //private ACDocTypeEntrysInfo EquipmentTemplateEntry;

        /// <summary>
        /// A variable to store the template entry for an allocated equipment
        /// </summary>
        //private ACDocTypeEntrysInfo AllocatedEquipmentTemplateEntry;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSLookupEdit ProductLookUpEdit;
        public BOSGridControl GridControl;
        public int productid = 0;
        #endregion

        public AssetDecreasingModule()
        {
            Name = ModuleName.AssetDecreasing;
            CurrentModuleEntity = new AssetDecreasingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            //ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            //EquipmentTemplateEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
            //                                                                                AccDocumentType.XuatCCDC.ToString(),
            //                                                                                AccEntryType.XuatCCDC.ToString());  
            //AllocatedEquipmentTemplateEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
            //                                                                                AccDocumentType.XuatCCDC.ToString(),
            //                                                                                AccEntryType.XuatCCDCPhanBo.ToString());
            ProductLookUpEdit = (BOSLookupEdit)Controls[ProductControlName];
            ProductLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductLookUpEdit_QueryPopUp);
            GridControl = (BOSGridControl)Controls[ShipmentItemGridControlName];
        }
        void ProductLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetProductForAssetIncreasing();
            ProductLookUpEdit.Properties.DataSource = productList;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START

        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    string query = base.GenerateSearchQuery(strTableName);
        //    query += string.Format(" and ICShipmentTypeCombo = '{0}'", ShipmentType.EquipmentShipment.ToString());                                
        //    return query;
        //}

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
                    ds = shipmentController.GetEquipmentShipmentListDataSetByListOfBranchID(searchObject.ICShipmentNo,
                                                            searchObject.FK_HREmployeeID,
                                                            null,
                                                            ShipmentType.AssetShipment.ToString(),
                                                            searchObject.ShipmentDateFrom,
                                                            searchObject.ShipmentDateTo,
                                                            BranchList);
                }
            }
            else
            {
                ds = shipmentController.GetEquipmentShipmentListDataSet(searchObject.ICShipmentNo,
                                                            searchObject.FK_HREmployeeID,
                                                            null,
                                                            searchObject.FK_BRBranchID,
                                                            ShipmentType.AssetShipment.ToString(),
                                                            searchObject.ShipmentDateFrom,
                                                            searchObject.ShipmentDateTo);
            }

            return ds;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

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

        /// <summary>
        /// Add the selected item to the item list
        /// </summary>
        public void AddItemToShipmentItemsList()
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            if (item.FK_ICProductID > 0)
            {
                productid = item.FK_ICProductID;
                item.ICShipmentItemProductUnitPrice = 0;
                item.ICShipmentItemTotalAmount = 0;
                item.ICShipmentItemPrice = 0;
                item.FK_ACAssetID = 0;
                item.ICShipmentItemProductSerialNo = "";
                GridView gridView = (GridView)GridControl.MainView;
                GridColumn gridColumn = new GridColumn();
                gridColumn = gridView.Columns["FK_ACAssetID"];
                if (gridColumn != null)
                {
                    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ACAssetNo";
                    repositoryItemLookUpEdit.ValueMember = "ACAssetID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAssetNo", "Mã định danh"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeQualityLookupEdit_QueryPopUp);
                    gridColumn.ColumnEdit = repositoryItemLookUpEdit;
                }
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                entity.ShipmentItemList.Add(item);
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                UpdateTotalAmount();
            }
        }
        void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAssetsController objAssetsController = new ACAssetsController();
            List<ACAssetsInfo> assetList = objAssetsController.GetAssetsByProductID(productid);

            lookUpEdit.Properties.DataSource = assetList;
        }
        /// <summary>
        /// Change the selected item to the item list
        /// </summary>
        public void ChangeItemFromShipmentItemsList()
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            entity.ShipmentItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called from the screen, when the user changes the serie no of an item
        /// </summary>
        /// <param name="item">Given item</param>
        public void ChangeItemSerieNo(ICShipmentItemsInfo item)
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            item.ICShipmentItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);
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
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            ICShipmentItemsInfo item = entity.ModuleObjects[TableName.ICShipmentItemsTableName] as ICShipmentItemsInfo;


            ////just for updating old data
            //item.ICShipmentItemDepreciatedAmount = 0;



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

        /// <summary>
        /// Delete the selected item from the item list
        /// </summary>
        public void DeleteItemFromShipmentItemsList()
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            //Delete ACAssetShipmentItems, START
            ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
            ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetObjectByNo(objShipmentsInfo.ICShipmentNo);
            if (objDocumentsInfo != null)
            {
                if (item != null)
                {
                    ACAssetShipmentItemsInfo objAssetShipmentItemsInfo = (ACAssetShipmentItemsInfo)objAssetShipmentItemsController.GetItemsByDocumentIDAndAssetID(objDocumentsInfo.ACDocumentID, item.FK_ACAssetID);
                    if (objAssetShipmentItemsInfo != null)
                    {
                        objAssetShipmentItemsController.DeleteObject(objAssetShipmentItemsInfo.ACAssetShipmentItemID);
                    }
                }
            }
            //Delete ACAssetShipmentItems, END
            entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when the user changes the stock
        /// </summary>
        /// <param name="stockID">Selected stock id</param>
        public void ChangeStock(int stockID)
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
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
                        }
                        entity.ShipmentItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        /// <summary>
        /// Update the total amounts of the shipment
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                objShipmentsInfo.ICShipmentSubTotalAmount = 0;
                foreach (ICShipmentItemsInfo entItem in entity.ShipmentItemList)
                {
                    BOSApp.RoundByCurrency(entItem, "ICShipmentItemTotalAmount", objShipmentsInfo.FK_GECurrencyID);
                    objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;

                }
                objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
                BOSApp.RoundByCurrency(objShipmentsInfo, "ICShipmentTotalAmount", objShipmentsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objShipmentsInfo, "ICShipmentSubTotalAmount", objShipmentsInfo.FK_GECurrencyID);

                entity.UpdateMainObjectBindingSource();

                UpdateDocumentEntries();
            }
        }

        public override int ActionSave()
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;

            entity.ShipmentItemList.EndCurrentEdit();
            foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
            {
                if (shipmentItem.FK_ACAssetID == 0)
                {
                    MessageBox.Show("Vui lòng chọn Mã định danh cho " + shipmentItem.ICProductName, "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }

            }
            UpdateTotalAmount();

            int shipmentID = 0;
            {
                shipmentID = base.ActionSave();
            }
            return shipmentID;
        }

        /// <summary>
        /// Called when the user prints the shipment
        /// </summary>
        public void ActionPrintShipment()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintShipment(Toolbar.CurrentObjectID);
            }
        }
        public static void PrintShipment(int shipmentID)
        {
            RP_Shipment_CCDC report = new RP_Shipment_CCDC();
            InitShipmentReport(report, shipmentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }
        private static void InitShipmentReport(XtraReport report, int shipmentID)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactAddressLine3;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactFax;
                }
            }

            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo shipment = (ICShipmentsInfo)objShipmentsController.GetObjectByID(shipmentID);
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            if (shipment != null)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentsInfo document = null;
                if (shipment.ICShipmentTypeCombo == ShipmentType.Shipment.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatKho.ToString(), shipment.ICShipmentNo);
                }
                else if (shipment.ICShipmentTypeCombo == ShipmentType.AssetShipment.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.TangTSCD.ToString(), shipment.ICShipmentNo);
                }
                if (document != null)
                {
                    entries = objDocumentEntrysController.GetDocumentEntryByDocumentID(document.ACDocumentID);
                }
            }

            XRLabel accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDebitAccountNo"];
            if (accLabel != null)
            {
                string debitAccountNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (!debitAccountNo.Contains(entry.ACDocumentDebitAccount))
                    {
                        debitAccountNo += string.Format(" {0},", entry.ACDocumentDebitAccount);
                    }
                }
                if (!string.IsNullOrEmpty(debitAccountNo))
                {
                    debitAccountNo = debitAccountNo.Substring(0, debitAccountNo.Length - 1);
                }
                accLabel.Text = debitAccountNo;
            }

            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCreditAccountNo"];
            if (accLabel != null)
            {
                string creditAccountNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (entry.ACDocumentCreditAccount != null)
                    {
                        if (!creditAccountNo.Contains(entry.ACDocumentCreditAccount))
                        {
                            creditAccountNo += string.Format(" {0},", entry.ACDocumentCreditAccount);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(creditAccountNo))
                {
                    creditAccountNo = creditAccountNo.Substring(0, creditAccountNo.Length - 1);
                }
                accLabel.Text = creditAccountNo;
            }

            ADReportsController objReportsController = new ADReportsController();
            report.DataSource = objReportsController.GetShipmentItemsByShipmentID(shipmentID);
        }

        #region Accounting
        //public override int GetDocumentTypeID()
        //{
        //    ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
        //    int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.XuatKhoTaiSan.ToString());
        //    return documentTypeID;
        //}

        //public override void GenerateAccountingData()
        //{
        //    GenerateAccountingData(new string[] { AccDocumentType.XuatKhoTaiSan.ToString() });

        //    //AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;            
        //    //entity.DocumentEntryList.SetDefaultListAndRefreshGridControl();
        //}

        //protected override void UpdateDocumentEntries()
        //{
        //    AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
        //    ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
        //    //entity.DocumentEntryList.Clear();
        //    ICProductsController productController = new ICProductsController();
        //    ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
        //    ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
        //    ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
        //                                                           AccDocumentType.XuatKhoTaiSan.ToString(),
        //                                                           AccEntryType.XuatKhoTaiSan.ToString());
        //    ACDocumentEntrysInfo foundItem = entity.DocumentEntryList.FirstOrDefault(p => p.FK_ACDebitAccountID == objShipmentItemsInfo.FK_ACAccountID);

        //    if (foundItem == null)
        //    {
        //        if (defaultEntry != null)
        //        {
        //            ACDocumentEntrysInfo newObj = AccountHelper.GetDocumentEntryFromDefaultEntry(defaultEntry);
        //            newObj.FK_ACDebitAccountID = objShipmentItemsInfo.FK_ACAccountID;
        //            entity.DocumentEntryList.Add(newObj);
        //        }
        //    }
        //    //###

        //    foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
        //    {
        //        //[NNTien] [ADD] [07/07/2013] [Issue seperate acount 211, 213], START
        //        //get sum of account
        //        if (entry.ACEntryTypeName == AccEntryType.XuatKhoTaiSan.ToString() && entry.FK_ACDebitAccountID == objShipmentItemsInfo.FK_ACAccountID)
        //        {
        //            decimal sum = 0;
        //            foreach (var item in entity.ShipmentItemList)
        //            {
        //                if (item.FK_ACAccountID == entry.FK_ACDebitAccountID)
        //                {
        //                    sum +=item.ICShipmentItemProductUnitPrice * item.ICShipmentItemProductQty;
        //                }
        //            }
        //            entry.ACDocumentEntryAmount = sum;
        //            entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
        //            BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", objShipmentsInfo.FK_GECurrencyID);
        //            BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
        //        }
        //        //if (entry.ACEntryTypeName == AccEntryType.TangTSCD.ToString() && entry.FK_ACDebitAccountID == objShipmentItemsInfo.FK_ACAccountID)
        //        //{
        //        //    decimal sum = 0;
        //        //    foreach (var item in entity.ShipmentItemList)
        //        //    {
        //        //        if (item.FK_ACAccountID == entry.FK_ACDebitAccountID)
        //        //        {
        //        //            sum += item.ICShipmentItemProductUnitPrice * item.ICShipmentItemProductQty;
        //        //        }
        //        //    }
        //        //    entry.ACDocumentEntryAmount = sum;
        //        //    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
        //        //}
        //        //###
        //        else if (entry.ACEntryTypeName == AccEntryType.ThueGTGTDuocKhauTru.ToString())
        //        {
        //            entry.ACDocumentEntryAmount = entity.ShipmentItemList.Sum(i => i.ICShipmentItemTaxAmount) + objShipmentsInfo.ICShipmentTaxAmount;
        //            entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
        //            BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", objShipmentsInfo.FK_GECurrencyID);
        //            BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
        //        }
        //    }
        //    entity.DocumentEntryList.GridControl.RefreshDataSource();
        //}
        #endregion

        public List<ICProductIdentifiedEquipmentsInfo> GetIdentifiedEquipmentList()
        {
            List<ICProductIdentifiedEquipmentsInfo> identifiedEquipmentList = new List<ICProductIdentifiedEquipmentsInfo>();
            ICProductIdentifiedEquipmentsController objProductIdentifiedEquipmentsController = new ICProductIdentifiedEquipmentsController();
            AssetDecreasingEntities entity = CurrentModuleEntity as AssetDecreasingEntities;
            ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
            if (item != null)
            {
                identifiedEquipmentList = objProductIdentifiedEquipmentsController.GetItemByProductIDAndProductSerieID(item.FK_ICProductID, item.FK_ICProductSerieID);

            }
            return identifiedEquipmentList;
        }
        public void ResetModelDetail(ICShipmentItemsInfo item)
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
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
        public void ApproveAssetDecreasing()
        {

            if (Toolbar.IsNullOrNoneAction())
            {
                AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();


                foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                    if (objProductsInfo.ICProductType != ProductType.Service.ToString() && objProductsInfo.IsAsset)
                    {
                        if (!objShipmentItemsInfo.HasComponent && objShipmentItemsInfo.FK_ICProductSerieID == 0)
                        {
                            MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (objShipmentItemsInfo.FK_HRDepartmentRoomID == 0)
                        {
                            MessageBox.Show(string.Format("Vui lòng chọn xuất cho bộ phận nào", objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
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
        public override void InvalidateToolbar()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
            }

            else
            {
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
            }
        }
        public void GeneralAssetReceipt()
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            #region Create MainObject
            string No = string.Empty;
            ACAssetReceiptsInfo objAssetReceiptsInfo = new ACAssetReceiptsInfo();
            ACAssetReceiptsController objAssetReceiptsController = new ACAssetReceiptsController();
            List<ACAssetReceiptItemsInfo> ListAssetReceiptItems = new List<ACAssetReceiptItemsInfo>();
            //BOSDbUtil dbUtil = new BOSDbUtil();
            //DateTime currentDate = dbUtil.GetCurrentServerDate();
            //GENumberingInfo objNumberingInfo = new GENumberingInfo();
            //GENumberingController objNumberingController = new GENumberingController();
            //objNumberingInfo = (GENumberingInfo)objNumberingController.GetObjectByName("AssetReceipt");
            //if (objNumberingInfo != null)
            //{
            //    No = objNumberingInfo.GENumberingPrefix + currentDate.ToString("yy") + "." + objNumberingInfo.GENumberingStart;
            //    objNumberingInfo.GENumberingStart = objNumberingInfo.GENumberingStart + 1;
            //    objNumberingController.UpdateObject(objNumberingInfo);
            //}
            objAssetReceiptsInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
            objAssetReceiptsInfo.ACAssetReceiptNo = objShipmentsInfo.ICShipmentNo;
            objAssetReceiptsInfo.ACAssetReceiptDate = objShipmentsInfo.ICShipmentDate;
            objAssetReceiptsInfo.ACAssetReceiptStatus = AssetReceiptStatus.Complete.ToString();
            objAssetReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAssetReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objAssetReceiptsInfo.ACAssetReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objAssetReceiptsInfo.APInputVATDocumentType = objShipmentsInfo.ICOutputVATDocumentType;
            objAssetReceiptsInfo.ACAssetReceiptFormNo = objShipmentsInfo.ICShipmentFormNo;
            objAssetReceiptsInfo.ACAssetReceiptSymbol = objShipmentsInfo.ICShipmentSymbol;
            objAssetReceiptsInfo.APInputVATInvoiceNoCombo = objShipmentsInfo.ICOutputVATInvoiceNoCombo;
            objAssetReceiptsController.CreateObject(objAssetReceiptsInfo);
            #endregion
            #region Create ModuleObject

            ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
            decimal TotalCost = 0;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                ACAssetReceiptItemsInfo objAssetReceiptItemsInfo = new ACAssetReceiptItemsInfo();
                BOSUtil.CopyObject(item, objAssetReceiptItemsInfo);
                //objAssetReceiptItemsInfo. = BOSApp.CurrentUsersInfo.ADUserName;
                objAssetReceiptItemsInfo.FK_ACAssetID = item.FK_ACAssetID;
                objAssetReceiptItemsInfo.ACAssetReceiptItemQty = 1;
                objAssetReceiptItemsInfo.ACAssetReceiptItemProductName = item.ICShipmentItemProductName;
                objAssetReceiptItemsInfo.ACAssetReceiptItemProductDesc = item.ICShipmentItemProductDesc;
                objAssetReceiptItemsInfo.FK_ACAssetReceiptID = objAssetReceiptsInfo.ACAssetReceiptID;
                objAssetReceiptItemsInfo.ACAssetReceiptItemUnitCost = item.ICShipmentItemProductUnitPrice;
                objAssetReceiptItemsInfo.ACAssetReceiptItemOriginalAmount = item.ICShipmentItemProductUnitPrice;
                objAssetReceiptItemsInfo.FK_HRDepartmentRoomID = item.FK_HRDepartmentRoomID;
                objAssetReceiptItemsInfo.ACAssetReceiptItemTotalCost = item.ICShipmentItemProductUnitPrice * objAssetReceiptItemsInfo.ACAssetReceiptItemQty;
                TotalCost += objAssetReceiptItemsInfo.ACAssetReceiptItemTotalCost;
                objAssetReceiptItemsController.CreateObject(objAssetReceiptItemsInfo);
                ListAssetReceiptItems.Add(objAssetReceiptItemsInfo);
            }
            objAssetReceiptsInfo.ACAssetReceiptTotalCost = TotalCost;
            objAssetReceiptsInfo.ACAssetReceiptSubTotalCost = TotalCost;
            objAssetReceiptsController.UpdateObject(objAssetReceiptsInfo);

            #endregion
            #region Create Accounting
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo objDocumentsInfo = new ACDocumentsInfo();
            ACDocumentEntrysInfo objDocumentEntrysInfo = new ACDocumentEntrysInfo();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            ACEntryTypesInfo objEntryTypesInfo = new ACEntryTypesInfo();
            ACDocumentTypesInfo objDocumentTypesInfo = new ACDocumentTypesInfo();
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocTypeEntryAccountsController objDocTypeEntryAccountsController = new ACDocTypeEntryAccountsController();
            List<ACDocTypeEntryAccountsInfo> ListAccount = new List<ACDocTypeEntryAccountsInfo>();
            ACDocTypeEntryAccountsInfo objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
            objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.TangTSCD.ToString());
            objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryType.TangTSCD.ToString());
            int documentTypeID = 0, entryTypeID = 0, accountCredit = 0, accountDebit = 0;
            string desc = string.Empty;
            if (objDocumentTypesInfo != null && objEntryTypesInfo != null)
            {
                documentTypeID = objDocumentTypesInfo.ACDocumentTypeID;
                entryTypeID = objEntryTypesInfo.ACEntryTypeID;
                desc = objEntryTypesInfo.ACEntryTypeDesc;
            }
            objDocumentsInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objDocumentsInfo.ACDocumentNo = objShipmentsInfo.ICShipmentNo;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objDocumentsInfo.FK_ACDocumentTypeID = documentTypeID;
            objDocumentsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objDocumentsInfo.ACDocumentDate = objShipmentsInfo.ICShipmentDate;
            objDocumentsInfo.ACDocumentTotalAmount = TotalCost;
            objDocumentsInfo.ACDocumentExchangeAmount = TotalCost;
            objDocumentsInfo.ACVATDocumentType = objShipmentsInfo.ICOutputVATDocumentType;
            objDocumentsInfo.ACDocumentVATFormNo = objShipmentsInfo.ICShipmentFormNo;
            objDocumentsInfo.ACDocumentVATSymbol = objShipmentsInfo.ICShipmentSymbol;
            objDocumentsInfo.ACVATInvoiceNoCombo = objShipmentsInfo.ICOutputVATInvoiceNoCombo;

            objDocumentsController.CreateObject(objDocumentsInfo);

            List<ACAssetReceiptItemsInfo> ListItemGroupByAccount = new List<ACAssetReceiptItemsInfo>();
            ListItemGroupByAccount = objAssetReceiptItemsController.GetItemGroupByAssetReceiptAndAccount(objAssetReceiptsInfo.ACAssetReceiptID);
            ListAccount = objDocTypeEntryAccountsController.GetAccountIDByTypeDocument(AccDocumentType.TangTSCD.ToString(), AccEntryType.TangTSCD.ToString());
            objDocTypeEntryAccountsInfo = ListAccount.Where(x => x.ACPostingType == "Credit").FirstOrDefault();
            if (objDocTypeEntryAccountsInfo != null)
            {
                accountCredit = objDocTypeEntryAccountsInfo.FK_ACAccountID;
            }
            foreach (ACAssetReceiptItemsInfo item in ListItemGroupByAccount)
            {
                objDocumentEntrysInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                objDocumentEntrysInfo.FK_ACEntryTypeID = entryTypeID;
                objDocumentEntrysInfo.FK_ACCreditAccountID = accountCredit;
                objDocumentEntrysInfo.FK_ACDebitAccountID = item.FK_ACAccountID;
                objDocumentEntrysInfo.ACDocumentEntryDesc = desc;
                objDocumentEntrysInfo.ACDocumentEntryAmount = item.ACAssetReceiptItemTotalCost;
                objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = item.ACAssetReceiptItemTotalCost;
                objDocumentEntrysController.CreateObject(objDocumentEntrysInfo);
            }




            //ListAccount = objDocTypeEntryAccountsController.GetAccountIDByTypeDocument(AccDocumentType.TangTSCD.ToString(), AccEntryType.TangTSCD.ToString());
            //objDocTypeEntryAccountsInfo = ListAccount.Where(x => x.ACPostingType == "Debit").FirstOrDefault();
            //if (objDocTypeEntryAccountsInfo != null)
            //{
            //    accountDebit = objDocTypeEntryAccountsInfo.FK_ACAccountID;
            //}

            //objDocumentEntrysInfo. = BOSApp.CurrentUsersInfo.ADUserName;


            #endregion
        }
        public void ChangeCurrency(int currencyID)
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            objShipmentsInfo.FK_GECurrencyID = currencyID;
            UpdateTotalAmount();
        }
        public void ActionNormal()
        {
            ActionNew();
        }
        public void ActionFromAllocationProposal()
        {
            ActionNew();
            ActionNewForm(AllocationProposalType.Other.ToString());
        }
        public void ActionNewForm(string MMAllocationProposalType)
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;

            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            MMAllocationProposalsController objAllocationProposalsController = new MMAllocationProposalsController();
            ICProductsController objProductsController = new ICProductsController();

            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsCheck = new List<MMAllocationProposalItemsInfo>();
            List<MMAllocationProposalItemsInfo> allocationProposalItemsList = objAllocationProposalItemsController.GetNewProposalFromWood(MMAllocationProposalType,
                                                                                                                                            BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                                                            ModuleName.AllocationProposal,
                                                                                                                                            ADDataViewPermissionType.Module,
                                                                                                                                            BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            guiFind<MMAllocationProposalItemsInfo> guifind = new guiFind<MMAllocationProposalItemsInfo>(TableName.MMAllocationProposalItemsTableName,
                                                                                                        allocationProposalItemsList
                                                                                                        , this, true, true);
            guifind.ShowDialog();
            if (guifind.DialogResult == DialogResult.OK)
            {
                //ChangeAllocationProposalProductType(MMAllocationProposalType);
                /// UpdateProductLookupEditControlDataSource(MMAllocationProposalType, string.Empty);
                List<MMAllocationProposalItemsInfo> AllocationProposalItemsList = (List<MMAllocationProposalItemsInfo>)guifind.SelectedObjects;

                if (guifind.SelectedObjects != null && guifind.SelectedObjects.Count > 0)
                {
                    objAllocationProposalItemsCheck = (List<MMAllocationProposalItemsInfo>)AllocationProposalItemsList.Where(x => x.FK_MMAllocationProposalID != guifind.SelectedObjects[0].FK_MMAllocationProposalID).ToList();
                }
                if (objAllocationProposalItemsCheck != null && objAllocationProposalItemsCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(MaterialShipmentLocalizedResources.ChooseMulltiSaleOrderMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewForm(MMAllocationProposalType);
                }
                else
                {
                    MMAllocationProposalsInfo objAllocationProposalsInfo = (MMAllocationProposalsInfo)objAllocationProposalsController.GetObjectByID(guifind.SelectedObjects[0].FK_MMAllocationProposalID);
                    if (objAllocationProposalsInfo != null)
                    {
                        objShipmentsInfo.FK_ICProductID = objAllocationProposalsInfo.FK_ICProductID;
                        objShipmentsInfo.FK_MMBatchProductID = objAllocationProposalsInfo.FK_MMBatchProductID;
                        /* Không gán công đoạn - Người dùng chọn lại*/
                        //objShipmentsInfo.FK_MMOperationID = objAllocationProposalsInfo.FK_MMOperationID;
                        /* Không gán công đoạn - Người dùng chọn lại*/
                        objShipmentsInfo.ICShipmentShipmentType = MMAllocationProposalType;
                        /* Không gán công đoạn - Người dùng chọn lại*/
                        //objShipmentsInfo.FK_MMOperationID = objAllocationProposalsInfo.FK_MMOperationID;
                        /* Không gán công đoạn - Người dùng chọn lại*/
                        objShipmentsInfo.FK_ICProductAttributeTTMTID = objAllocationProposalsInfo.FK_ICProductAttributeTTMTID;
                        objShipmentsInfo.FK_MMAllocationProposalID = objAllocationProposalsInfo.MMAllocationProposalID;
                        //TKChinh Add PO No
                        objShipmentsInfo.ICShipmentPONo = objAllocationProposalsInfo.MMAllocationProposalPONo;
                        HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objAllocationProposalsInfo.MMAllocationProposalProposedEmployeeID);
                        if (objEmployeesInfo != null)
                        {
                            objShipmentsInfo.ICShipmentDeliveryContactName = objEmployeesInfo.HREmployeeName;
                        }
                        objShipmentsInfo.FK_HRDepartmentRoomID = objAllocationProposalsInfo.FK_HRDepartmentRoomID;
                        /* Không gán công đoạn - Người dùng chọn lại*/
                        objShipmentsInfo.FK_MMOperationID = 0;
                        /* Không gán công đoạn - Người dùng chọn lại*/
                        entity.UpdateMainObjectBindingSource();
                    }
                    if (AllocationProposalItemsList != null)
                    {
                        //if (MMAllocationProposalType == AllocationProposalProductType.Wood.ToString())
                        //{
                        //    foreach (MMAllocationProposalItemsInfo item in AllocationProposalItemsList)
                        //    {
                        //        ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                        //        BOSUtil.CopyObject(item, objShipmentItemsInfo);
                        //        objShipmentItemsInfo.ICShipmentItemProductQty = item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty;
                        //        objShipmentItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                        //        objShipmentItemsInfo.ICShipmentItemWoodQty = item.MMAllocationProposalItemWoodQty - item.MMAllocationProposalItemShippedWoodQty;
                        //        objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                        //        entity.ShipmentItemList.Add(objShipmentItemsInfo);
                        //        entity.ShipmentItemList.GridControl.RefreshDataSource();
                        //        // UpdateTotalAmount();
                        //    }
                        //}
                        //if (MMAllocationProposalType == AllocationProposalProductType.Hardware.ToString()
                        //    || MMAllocationProposalType == AllocationPlanType.IngredientPackaging.ToString()
                        //    || MMAllocationProposalType == AllocationPlanType.IngredientPaint.ToString()
                        //    //|| MMAllocationProposalType == AllocationPlanType.Wood.ToString()
                        //    || MMAllocationProposalType == AllocationPlanType.DryLumber.ToString()
                        //     || MMAllocationProposalType == AllocationPlanType.Other.ToString()
                        //    )
                        {
                            foreach (MMAllocationProposalItemsInfo item in AllocationProposalItemsList)
                            {
                                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                                BOSUtil.CopyObject(item, objShipmentItemsInfo);
                                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                                if (objProductsInfo != null)
                                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                                objShipmentItemsInfo.ICShipmentItemProductQty = item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty - item.MMAllocationProposalItemCanceledQty;
                                objShipmentItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                                //TNDLoc [ADD][02/01/2016][FK_MMBatchProductionNormItemID, MMAllocationPlanItemBatchProductionNormItemProductSerial],START
                                objShipmentItemsInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
                                objShipmentItemsInfo.ICShipmentItemBatchProductItemProductSerial = item.MMAllocationProposalItemBatchProductItemProductSerial;
                                if (MMAllocationProposalType == AllocationPlanType.IngredientPaint.ToString())
                                {
                                    objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(objShipmentItemsInfo.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);

                                }
                                else
                                //else if (MMAllocationProposalType == AllocationProposalProductType.Hardware.ToString()
                                //    || MMAllocationProposalType == AllocationPlanType.IngredientPackaging.ToString()
                                //    || MMAllocationProposalType == AllocationPlanType.DryLumber.ToString()
                                //     || MMAllocationProposalType == AllocationPlanType.Other.ToString())
                                {
                                    objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(objShipmentItemsInfo.ICShipmentItemProductQty, 2, MidpointRounding.AwayFromZero);
                                }
                                // GeneralAccountInShipmentItemByStock(objShipmentItemsInfo);
                                /* Không gán công đoạn - Người dùng chọn lại*/
                                objShipmentItemsInfo.FK_MMOperationID = 0;
                                /* Không gán công đoạn - Người dùng chọn lại*/
                                entity.ShipmentItemList.Add(objShipmentItemsInfo);
                                entity.ShipmentItemList.GridControl.RefreshDataSource();
                                // UpdateTotalAmount();
                            }
                        }

                    }
                    UpdateTotalAmount();
                }

            }
            else
                ActionCancel();
        }
        public void UpdateAAlocationProposalItemQty()
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
                MMAllocationProposalItemsInfo objAllocationProposalItemsInfo = (MMAllocationProposalItemsInfo)objAllocationProposalItemsController.GetObjectByID(item.FK_MMAllocationProposalItemID);
                if (objAllocationProposalItemsInfo != null)
                {
                    objAllocationProposalItemsInfo.MMAllocationProposalItemShippedQty += item.ICShipmentItemProductQty;
                    objAllocationProposalItemsController.UpdateObject(objAllocationProposalItemsInfo);
                }
            }
        }
    }


}



using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetShipment
{
    public class AssetShipmentModule : BaseTransactionModule
    {
        #region Constants
        public const string AssetShipmentItemGridControlName = "fld_dgcAssetShipmentItems";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        public const string AssetShipmentTemplatesGridControlName = "fld_dgcACAssetShipmentTemplatesGridControl";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string FilePathTextBoxName = "fld_txtFilePath";
        #endregion

        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        private string DocumentFileName = string.Empty;
        public BOSLookupEdit AssetLookupEditControl;
        #endregion
        public AssetShipmentModule()
        {
            Name = ModuleName.AssetShipment;
            CurrentModuleEntity = new AssetShipmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[AssetShipmentModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            AssetLookupEditControl = (BOSLookupEdit)Controls["fld_lkeFK_ACAssetID"];
            BindingDataSourceForAssetLookupEdit();
        }

        public void BindingDataSourceForAssetLookupEdit()
        {
            ACAssetsController controller = new ACAssetsController();
            List<ACAssetsInfo> assets = controller.GetAssetsForStopDepreciationAsset();
            AssetLookupEditControl.Properties.DataSource = assets;
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
        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    string query = base.GenerateSearchQuery(strTableName);
        //    int documentTypeID = GetDocumentTypeID();
        //    query += string.Format(" and FK_ACDocumentTypeID = {0}", documentTypeID);
        //    return query;
        //}
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo searchObject = (ACDocumentsInfo)CurrentModuleEntity.SearchObject;
            int documentTypeID = GetDocumentTypeID();
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objDocumentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objDocumentsController.GetDocumentListDataSetByListOfBranchID(searchObject.ACDocumentNo,
                                                                                documentTypeID,
                                                                                searchObject.FK_HREmployeeID,
                                                                                searchObject.DocumentDateFrom,
                                                                                searchObject.DocumentDateTo,
                                                                                BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetDocumentListDataSet(searchObject.ACDocumentNo,
                                                            documentTypeID,
                                                            searchObject.FK_HREmployeeID,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.DocumentDateFrom,
                                                            searchObject.DocumentDateTo);
            }

            return ds;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public override int ActionSave()
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            entity.AssetShipmentItemList.EndCurrentEdit();
            UpdateDocumentEntries();

            int objectID = base.ActionSave();
            if (objectID > 0)
            {
                SaveDocumentFile();
            }
            return objectID;
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);
            ActionPosted();
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPAssetDecreasing report = new RPAssetDecreasing();
                InitAssetDecreasingReport(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }

        /// <summary>
        /// Init an asset decreasing report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        /// <param name="assetShipmentID">Asset shipment id</param>
        private void InitAssetDecreasingReport(RPAssetDecreasing report, int assetShipmentID)
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
            List<ACAssetShipmentItemsInfo> items = objReportsController.GetItemsByAssetShipmentID(assetShipmentID);
            report.DataSource = items;
        }

        /// <summary>
        /// Add an item to its list
        /// </summary>
        public void AddItemToList()
        {
            ACAssetsController assetController = new ACAssetsController();
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACAssetShipmentItemsInfo objAssetShipmentItemsInfo = (ACAssetShipmentItemsInfo)entity.ModuleObjects[TableName.ACAssetShipmentItemsTableName];
            List<int> listAssetID = entity.AssetShipmentItemList.Select(i => i.FK_ACAssetID).ToList();

            if (listAssetID.Contains(objAssetShipmentItemsInfo.FK_ACAssetID) == true)
            {
                MessageBox.Show("Tài sản cố định này đã tồn tại trên lưới", "Thông báo");
                return;
            }

            if (objAssetShipmentItemsInfo.FK_ACAssetID > 0)
            {
                ACAssetsInfo asset = assetController.GetObjectByID(objAssetShipmentItemsInfo.FK_ACAssetID) as ACAssetsInfo;
                objAssetShipmentItemsInfo.FK_ACAccountID = asset.FK_ACAccountID;
                objAssetShipmentItemsInfo.FK_ACDepreciationAccountID = asset.FK_ACDepreciationAccountID;
                objAssetShipmentItemsInfo.FK_HRDepartmentID = asset.FK_HRDepartmentID;
                entity.SetValuesAfterValidatingAsset(objAssetShipmentItemsInfo);
                entity.AssetShipmentItemList.AddObjectToList();
                UpdateDocumentEntries();
            }
        }

        /// <summary>
        /// Remove the selected item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACAssetShipmentItemsInfo removedItem = (ACAssetShipmentItemsInfo)entity.ModuleObjects[TableName.ACAssetShipmentItemsTableName];
            if (removedItem != null)
                removedItem = removedItem.Clone() as ACAssetShipmentItemsInfo;
            entity.AssetShipmentItemList.RemoveSelectedRowObjectFromList();
            ACAssetShipmentItemsInfo currentItem = (ACAssetShipmentItemsInfo)entity.ModuleObjects[TableName.ACAssetShipmentItemsTableName];
            entity.ModuleObjects[TableName.ACAssetShipmentItemsTableName] = removedItem;
            UpdateDocumentEntries();
            entity.ModuleObjects[TableName.ACAssetShipmentItemsTableName] = currentItem;
        }

        /// <summary>
        /// Called when the user changes the room of an asset
        /// </summary>        
        /// <param name="item">Item contains the asset</param>
        public void ChangeAssetRoom(ACAssetShipmentItemsInfo item)
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACAssetsController objAssetsController = new ACAssetsController();
            ACAssetsInfo objAssetsInfo = objAssetsController.GetAssetByAssetIDAndRoomID(item.FK_ACAssetID, item.FK_HRDepartmentRoomID);
            if (objAssetsInfo != null)
            {
                item.ACAssetShipmentItemQty = objAssetsInfo.AssetReceiptedQty - objAssetsInfo.AssetShippedQty;
                item.AssetReceiptedQty = objAssetsInfo.AssetReceiptedQty;
                item.AssetShippedQty = objAssetsInfo.AssetShippedQty;
                entity.AssetShipmentItemList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Check for valid shipped quantity of an item
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="qty">Shipped quantity</param>
        /// <returns>Empty string if valid, otherwise the error description</returns>
        public string CheckForValidShippedQty(ACAssetShipmentItemsInfo item, decimal qty)
        {
            string errorMsg = string.Empty;
            if (item.AssetShippedQty + qty > item.AssetReceiptedQty)
            {
                errorMsg = AssetShipmentLocalizedResources.ShippedQtyCannotBeGreaterThanReceiptedQtyMessage;
            }
            return errorMsg;
        }

        #region Accounting
        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.GiamTSCD.ToString());
            return documentTypeID;
        }

        public override void GenerateAccountingData()
        {
            GenerateAccountingData(new string[] { AccDocumentType.GiamTSCD.ToString() });
        }

        protected override void UpdateDocumentEntries()
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAssetShipmentItemsInfo objAssetShipmentItemsInfo = (ACAssetShipmentItemsInfo)entity.ModuleObjects[TableName.ACAssetShipmentItemsTableName];

            //[NNTien] [ADD] [07/07/2013] [Issue seperate acount 211, 213], START
            //add new an acount if not exists

            ACDocumentEntrysInfo foundItem = entity.DocumentEntryList.FirstOrDefault(p => p.FK_ACCreditAccountID == objAssetShipmentItemsInfo.FK_ACAccountID);
            if (foundItem == null)
            {
                ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(item => item.ACEntryTypeName == AccEntryType.GiamTSCDHaoMon.ToString());
                if (entry != null)
                {
                    ACDocumentEntrysInfo newObj = (ACDocumentEntrysInfo)entry.Clone();
                    newObj.FK_ACCreditAccountID = objAssetShipmentItemsInfo.FK_ACAccountID;
                    newObj.FK_ACDebitAccountID = objAssetShipmentItemsInfo.FK_ACDepreciationAccountID;
                    int index = entity.DocumentEntryList.IndexOf(entry);
                    entity.DocumentEntryList.Insert(index + 1, newObj);
                }

                entry = entity.DocumentEntryList.FirstOrDefault(item => item.ACEntryTypeName == AccEntryType.GiamTSCDGiaTriConLai.ToString());
                if (entry != null)
                {
                    ACDocumentEntrysInfo newObj = (ACDocumentEntrysInfo)entry.Clone();
                    newObj.FK_ACCreditAccountID = objAssetShipmentItemsInfo.FK_ACAccountID;
                    int index = entity.DocumentEntryList.IndexOf(entry);
                    entity.DocumentEntryList.Insert(index + 1, newObj);
                }

            }
            //##

            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                //[NNTien] [ADD] [07/07/2013] [Issue seperate acount 211, 213], START
                //khấu hao tài sản cố điịnh 
                if (entry.ACEntryTypeName == AccEntryType.GiamTSCDHaoMon.ToString()
                    && entry.FK_ACCreditAccountID == objAssetShipmentItemsInfo.FK_ACAccountID)
                {
                    decimal sum = 0;
                    //get sum of account
                    foreach (var item in entity.AssetShipmentItemList)
                    {
                        if (item.FK_ACAccountID == objAssetShipmentItemsInfo.FK_ACAccountID)
                        {
                            sum += item.ACAssetShipmentItemDepreciatedAmount * item.ACAssetShipmentItemQty;
                        }
                    }
                    entry.ACDocumentEntryAmount = sum;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;

                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objDocumentsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }

                //###
                else if (entry.ACEntryTypeName == AccEntryType.GiamTSCDGiaTriConLai.ToString()
                    && entry.FK_ACCreditAccountID == objAssetShipmentItemsInfo.FK_ACAccountID)
                {
                    entry.ACDocumentEntryAmount = entity.AssetShipmentItemList.Where(item => item.FK_ACAccountID ==
                                                                                            objAssetShipmentItemsInfo.FK_ACAccountID)
                                                                            .Sum(i => i.ACAssetRemainedAmount * i.ACAssetShipmentItemQty);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objDocumentsInfo.ACDocumentExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objDocumentsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }
            List<int> productAccountID = new List<int>();
            productAccountID = entity.AssetShipmentItemList.Select(o => o.FK_ACAccountID).ToList();
            new String[]
            {
                AccEntryType.GiamTSCDHaoMon.ToString(),
                AccEntryType.GiamTSCDGiaTriConLai.ToString()
            }.ToList().ForEach(o =>
            {
                List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(x => x.ACEntryTypeName == o && !productAccountID.Any(accountID => accountID == x.FK_ACCreditAccountID)).ToList();
                if (removedItems != null && removedItems.Count > 0)
                    removedItems.ForEach(i => entity.DocumentEntryList.Remove(i));
            });

            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateAssetStatus(mainObject.ACDocumentPostedStatus);
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACDocumentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            entity.UpdateAssetStatus(mainObject.ACDocumentPostedStatus);
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACDocumentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACDocumentID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            if (mainObject.ACDocumentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit,
                    mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                    mainObject.ACDocumentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                    mainObject.ACDocumentPostedStatus == PostedTransactionStatus.Posted.ToString());
            }
            base.InvalidateToolbar();
        }

        #region Đính Kèm File
        public void SaveDocumentFile()
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;
            List<ACFileAttachmentsInfo> documentTemplateList = entity.AssetShipmentTemplateList.ToList();

            ACFileAttachmentsController objFileAttachmentsController = new ACFileAttachmentsController();
            ACFileAttachmentsInfo objFileAttachmentsInfo = new ACFileAttachmentsInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            documentTemplateList.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.ACFileAttachmentFileGUID))
                    return;

                entity.AssetShipmentTemplateURLDic.TryGetValue(o.ACFileAttachmentID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.ACFileAttachmentFileGUID = ApiClientHelper.UpdateFile(value);
                o.ACFileAttachmentObjectID = mainObject.ACDocumentID;
                objFileAttachmentsController.UpdateObject(o);
            });
            entity.AssetShipmentTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.AssetShipmentTemplateList.GridControl.RefreshDataSource();
        }

        public void BrowseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
            //dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BOSTextBox filePathTextBox = (BOSTextBox)Controls[AssetShipmentModule.FilePathTextBoxName];
                filePathTextBox.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        public void AddAssetShipmentTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[AssetShipmentModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACDocumentsInfo mainObject = (ACDocumentsInfo)entity.MainObject;

            if (entity.AssetShipmentTemplateList.Exists(o => o.ACFileAttachmentName.Equals(DocumentFileName)))
            {
                MessageBox.Show(SaleOrderLocalizedResources.DuplicateFileName,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            ACFileAttachmentsInfo objFileAttachmentsInfo = new ACFileAttachmentsInfo();
            objFileAttachmentsInfo.ACFileAttachmentName = DocumentFileName;
            objFileAttachmentsInfo.ACFileAttachmentTableName = BOSUtil.GetTableNameFromBusinessObject(mainObject);
            objFileAttachmentsInfo.ACFileAttachmentObjectID = mainObject.ACDocumentID;
            objFileAttachmentsInfo.ACFileAttachmentObjectItemID = 0;
            objFileAttachmentsInfo.ACFileAttachmentModuleName = this.Name;
            objFileAttachmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objFileAttachmentsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objFileAttachmentsInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objFileAttachmentsInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.AssetShipmentTemplateList.Add(objFileAttachmentsInfo);
            entity.AssetShipmentTemplateList.GridControl.RefreshDataSource();
        }

        public void RemoveAssetShipmentTemplateList()
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            entity.AssetShipmentTemplateList.RemoveSelectedRowObjectFromList();
            entity.AssetShipmentTemplateList.GridControl.RefreshDataSource();
        }

        public void DownloadDocument()
        {
            AssetShipmentEntities entity = (AssetShipmentEntities)CurrentModuleEntity;
            ACFileAttachmentsInfo objFileAttachmentsInfo = entity.AssetShipmentTemplateList[entity.AssetShipmentTemplateList.CurrentIndex];
            if (objFileAttachmentsInfo == null)
                return;

            if (string.IsNullOrEmpty(objFileAttachmentsInfo.ACFileAttachmentFileGUID))
            {
                MessageBox.Show(SaleOrderLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objFileAttachmentsInfo.ACFileAttachmentFileGUID, objFileAttachmentsInfo.ACFileAttachmentName);
        }

        #endregion
    }
}

using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetTransfer
{
    public class AssetTransferModule : BaseTransactionModule
    {
        #region Constants
        public const string AssetTransferItemGridControlName = "fld_dgcAssetTransferItems";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSLookupEdit AssetLookupEditControl;

        #endregion

        public AssetTransferModule()
        {
            Name = ModuleName.AssetTransfer;
            CurrentModuleEntity = new AssetTransferEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[AssetTransferModule.SearchBranchLookupEditControlName];
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
                    ds = objDocumentsController.GetDocumentListDataSetByListOfBranchIDForAssetTransfer(searchObject.ACDocumentNo,
                                                                                documentTypeID,
                                                                                searchObject.FK_HREmployeeID,
                                                                                searchObject.DocumentDateFrom,
                                                                                searchObject.DocumentDateTo,
                                                                                BranchList);
                }
            }
            else
            {
                ds = objDocumentsController.GetDocumentListDataSetForAssetTransfer(searchObject.ACDocumentNo,
                                                            documentTypeID,
                                                            searchObject.FK_HREmployeeID,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.DocumentDateFrom,
                                                            searchObject.DocumentDateTo);
            }

            return ds;
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.DieuChuyenTSCD.ToString());
            return documentTypeID;
        }

        /// <summary>
        /// Add an item to its list
        /// </summary>
        public void AddItemToList()
        {
            AssetTransferEntities entity = (AssetTransferEntities)CurrentModuleEntity;
            ACAssetTransferItemsInfo objAssetTransferItemsInfo = (ACAssetTransferItemsInfo)entity.ModuleObjects[TableName.ACAssetTransferItemsTableName];
            List<int> listAssetID = entity.AssetTransferItemList.Select(i => i.FK_ACAssetID).ToList();

            if (listAssetID.Contains(objAssetTransferItemsInfo.FK_ACAssetID))
            {
                MessageBox.Show("Tài sản cố định này đã tồn tại trên lưới", "Thông báo");
                return;
            }
            if (objAssetTransferItemsInfo.FK_ACAssetID > 0)
            {
                entity.SetValuesAfterValidatingAsset(objAssetTransferItemsInfo);
                entity.AssetTransferItemList.AddObjectToList();
            }
        }
        public override int ActionSave()
        {
            AssetTransferEntities entity = (AssetTransferEntities)CurrentModuleEntity;
            entity.AssetTransferItemList.EndCurrentEdit();
            List<int> listHRFromRoomID = entity.AssetTransferItemList.Select(i => i.FK_HRFromRoomID).ToList();
            List<int> listHRToRoomID = entity.AssetTransferItemList.Select(i => i.FK_HRToRoomID).ToList();
            if (listHRToRoomID.Contains(0) == true || listHRFromRoomID.Contains(0) == true)
            {
                MessageBox.Show("Các cột từ bộ phận, đến bộ phận không được để trống", "Thông báo");
                return 0;
            }

            return base.ActionSave();
        }
        /// <summary>
        /// Remove the selected item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            AssetTransferEntities entity = (AssetTransferEntities)CurrentModuleEntity;
            entity.AssetTransferItemList.RemoveSelectedRowObjectFromList();
        }

        /// <summary>
        /// Called when the user changes the room of an asset
        /// </summary>        
        /// <param name="item">Item contains the asset</param>
        public void ChangeAssetRoom(ACAssetTransferItemsInfo item)
        {
            //AssetTransferEntities entity = (AssetTransferEntities)CurrentModuleEntity;
            //ACAssetsController objAssetsController = new ACAssetsController();
            //ACAssetsInfo objAssetsInfo = objAssetsController.GetAssetByAssetIDAndRoomID(item.FK_ACAssetID, item.FK_HRFromRoomID);
            //if (objAssetsInfo != null)
            //{
            //    item.ACAssetTransferItemQty = objAssetsInfo.AssetReceiptedQty - objAssetsInfo.AssetShippedQty;
            //    item.AssetReceiptedQty = objAssetsInfo.AssetReceiptedQty;
            //    item.AssetShippedQty = objAssetsInfo.AssetShippedQty;
            //    entity.AssetTransferItemList.GridControl.RefreshDataSource();
            //}
        }

        /// <summary>
        /// Check for valid shipped quantity of an item
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="qty">Shipped quantity</param>
        /// <returns>Empty string if valid, otherwise the error description</returns>
        public string CheckForValidShippedQty(ACAssetTransferItemsInfo item, decimal qty)
        {
            string errorMsg = string.Empty;
            if (item.AssetShippedQty + qty > item.AssetReceiptedQty)
            {
                errorMsg = AssetTransferLocalizedResources.ShippedQtyCannotBeGreaterThanReceiptedQtyMessage;
            }
            return errorMsg;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPAssetTransfer report = new RPAssetTransfer();
                InitAssetTransferReport(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }

        /// <summary>
        /// Init an asset transfer report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        /// <param name="assetTransferID">Asset transfer id</param>
        private void InitAssetTransferReport(RPAssetTransfer report, int assetTransferID)
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
            List<ACAssetTransferItemsInfo> items = objReportsController.GetItemsByAssetTransferID(assetTransferID);
            report.DataSource = items;
        }
    }
}

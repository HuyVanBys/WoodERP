using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentIncreasing
{
    public class EquipmentIncreasingModule : BaseTransactionModule
    {
        #region Constants
        public const string ShipmentItemGridControlName = "fld_dgcShipmentItems";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion

        #region Variables

        #endregion

        #region Public Properties

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSLookupEdit CCDCLookupEditControl;
        public const string CCDCLookupEditControlName = "fld_lkeFK_ICProductID";
        #endregion
        public EquipmentIncreasingModule()
        {
            Name = ModuleName.EquipmentIncreasing;
            CurrentModuleEntity = new EquipmentIncreasingEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            CCDCLookupEditControl = (BOSLookupEdit)Controls[CCDCLookupEditControlName];
            CCDCLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(CCDCLookupEditControl_QueryPopUp);
        }

        void CCDCLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ICProductsController objProductController = new ICProductsController();
            List<ICProductsForViewInfo> CCDCList = BOSApp.CurrentProductList.Where(p => p.ICProductUsingMethod == ProductUsingMethod.SpecificEquipment.ToString()).ToList();
            lke.Properties.DataSource = CCDCList;
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;
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
                                                                                ShipmentType.EquipmentIncreasing.ToString(),
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
                                                                   ShipmentType.EquipmentIncreasing.ToString(),
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
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            item.ICShipmentItemDepriciationDate = BOSApp.GetCurrentServerDate();
            if (item.FK_ICProductID > 0)
            {
                item.ICShipmentItemProductIdentifiedEquipmentNo = string.Empty;
                item.ICShipmentItemProductIdentifiedEquipmentNo = entity.GenerateProductIdentifiedEquipmentNo(item);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null)
                    item.ICShipmentItemDepreciationMonths = objProductsInfo.ICProductDepreciationMonths;
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                entity.ShipmentItemList.AddObjectToList();
                UpdateTotalAmount();
            }
        }

        public void ChangeItemFromShipmentItemsList()
        {
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];

            ICShipmentItemsInfo oldObj = null;
            if (entity.ShipmentItemList.BackupList != null)
                oldObj = entity.ShipmentItemList.BackupList.FirstOrDefault(si => si.Id == item.Id);

            item.ICShipmentItemRemainedAmount = item.ICShipmentItemProductUnitPrice - item.ICShipmentItemDepreciatedAmount;
            if (oldObj == null)
                item.ICShipmentItemProductRemainedQty = item.ICShipmentItemProductQty;
            else
                item.ICShipmentItemProductRemainedQty = oldObj.ICShipmentItemProductRemainedQty + (item.ICShipmentItemProductQty - oldObj.ICShipmentItemProductQty);

            entity.ShipmentItemList.ChangeObjectFromList();
            UpdateTotalAmount();

        }

        public string CheckForValidShippedQty(ICShipmentItemsInfo item, decimal qty)
        {
            string errorMsg = string.Empty;

            if (item.Id > 0)
            {
                ICShipmentItemsController shipmentItemController = new ICShipmentItemsController();
                decimal shippedQty = shipmentItemController.GetShippedEquipmentQtyByShipmentItemID(item.Id);
                if (shippedQty > item.ICShipmentItemProductQty)
                {
                    errorMsg = EquipmentIncreasingLocalizedResources.CannotUpdateEquipmentQtyWhichIsLessThanTransferedQtyAndDecreasedQty;
                }
            }

            return errorMsg;
        }

        public void DeleteItemFromShipmentItemsList()
        {
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
            entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
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
            }
        }

        public bool IsValidItemList()
        {
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
            entity.ShipmentItemList.EndCurrentEdit();
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

            ICProductIdentifiedEquipmentsController pieController = new ICProductIdentifiedEquipmentsController();
            ICProductIdentifiedEquipmentsInfo pieInfo;

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
            return true;
        }

        public override int ActionSave()
        {
            if (!IsValidItemList())
            {
                return 0;
            }
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                if (string.IsNullOrEmpty(item.ICShipmentItemProductIdentifiedEquipmentNo))
                {
                    MessageBox.Show(string.Format(EquipmentIncreasingLocalizedResources.IdentifiedNoMessage, item.ICShipmentItemProductName),
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return 0;
                }
            }
            UpdateTotalAmount();
            return base.ActionSave();
        }

        public void ResetModelDetail(ICShipmentItemsInfo item)
        {
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
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

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
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
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ICShipmentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICShipmentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            if (mainObject.ICShipmentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                    mainObject.ICShipmentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                    mainObject.ICShipmentPostedStatus == PostedTransactionStatus.Posted.ToString());
            }
            base.InvalidateToolbar();
        }
    }
}

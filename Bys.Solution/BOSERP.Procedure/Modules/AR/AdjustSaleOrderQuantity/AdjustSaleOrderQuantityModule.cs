using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AdjustSaleOrderQuantity
{
    public class AdjustSaleOrderQuantityModule : BaseTransactionModule
    {
        #region Constant
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion

        #region Constructor
        public AdjustSaleOrderQuantityModule()
        {
            Name = "AdjustSaleOrderQuantity";
            CurrentModuleEntity = new AdjustSaleOrderQuantityEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        #endregion

        //#region Methods
        public override void ActionNew()
        {
            base.ActionNew();
            AdjustSaleOrderQuantityEntities entity = (AdjustSaleOrderQuantityEntities)CurrentModuleEntity;
            ARAdjustSaleOrderQuantitysInfo mainObject = (ARAdjustSaleOrderQuantitysInfo)entity.MainObject;
            ARAdjustSaleOrderQuantityItemsInfo objAdjustSaleOrderQuantityItemsInfo = new ARAdjustSaleOrderQuantityItemsInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrderItemsInfo> saleOrderItemList = objSaleOrderItemsController.GetSaleOrderItemByNotinInvoice();
            guiFind<ARSaleOrderItemsInfo> guiFind = new guiFind<ARSaleOrderItemsInfo>(TableName.ARSaleOrderItemsTableName, saleOrderItemList, this, true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<ARSaleOrderItemsInfo> templateListSaleOrderItems = (List<ARSaleOrderItemsInfo>)guiFind.SelectedObjects;
                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    saleOrderItemList = templateListSaleOrderItems.Where(x => x.FK_ARSaleOrderID != guiFind.SelectedObjects[0].FK_ARSaleOrderID).ToList();
                }
                if (saleOrderItemList != null && saleOrderItemList.Count > 0)
                {
                    MessageBox.Show(AdjustSaleOrderQuantityLocalizedResources.ChooseMultiSaleOrder,
                                      CommonLocalizedResources.MessageBoxDefaultCaption,
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNew();
                }
                else
                {
                    objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(guiFind.SelectedObjects[0].FK_ARSaleOrderID);
                    if (objSaleOrdersInfo != null)
                    {
                        BOSUtil.CopyObject(objSaleOrdersInfo, mainObject);
                        mainObject.ARAdjustSaleOrderQuantityDate = DateTime.Now;
                        mainObject.ARAdjustSaleOrderQuantityStatus = AdjustSaleOrderQuantityStatus.New.ToString();
                        mainObject.ARAdjustSaleOrderQuantityNo = "***NEW***";
                        mainObject.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                        entity.UpdateMainObjectBindingSource();
                    }
                    foreach (ARSaleOrderItemsInfo item in guiFind.SelectedObjects)
                    {
                        objAdjustSaleOrderQuantityItemsInfo = new ARAdjustSaleOrderQuantityItemsInfo();
                        BOSUtil.CopyObject(item, objAdjustSaleOrderQuantityItemsInfo);
                        objAdjustSaleOrderQuantityItemsInfo.ARAdjustSaleOrderQuantityItemProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                        objAdjustSaleOrderQuantityItemsInfo.ARAdjustSaleOrderQuantityItemTotalAmount = item.ARSaleOrderItemTotalAmount;
                        objAdjustSaleOrderQuantityItemsInfo.ARAdjustSaleOrderQuantityItemProductQty = item.ARSaleOrderItemProductQty;
                        objAdjustSaleOrderQuantityItemsInfo.FK_ARSaleOrderItemID = item.ARSaleOrderItemID;
                        objAdjustSaleOrderQuantityItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
                        objAdjustSaleOrderQuantityItemsInfo.ARAdjustSaleOrderQuantityItemProductOldQty = item.ARSaleOrderItemProductQty;
                        entity.AdjustSaleOrderQuantityItemList.Add(objAdjustSaleOrderQuantityItemsInfo);
                    }
                    entity.AdjustSaleOrderQuantityItemList.GridControl.RefreshDataSource();
                }
            }
            else
            {
                ActionCancel();
            }
        }
        public bool IsValidAdjustQty(ARAdjustSaleOrderQuantityItemsInfo item, decimal qty)
        {
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> saleOrderItemList = objSaleOrderItemsController.GetSaleOrderItemForCheckingAdjustSaleOrderValidQty(item.FK_ARSaleOrderItemID);
            decimal remainQty = 0;
            if (saleOrderItemList != null && saleOrderItemList.Count > 0)
            {
                remainQty = saleOrderItemList.Sum(i => i.ARSaleOrderItemRemainedQty);
            }
            if (qty < remainQty)
            {
                return false;
            }
            return true;
        }
        //public override int ActionSave()
        //{
        //    int cancelSaleForecastID = base.ActionSave();
        //    if (cancelSaleForecastID > 0)
        //    {
        //        CancelSaleForecastEntities entity = (CancelSaleForecastEntities)CurrentModuleEntity;
        //        entity.CancelSaleForecastItemList.BackupList.Clear();
        //        foreach (ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo in entity.CancelSaleForecastItemList)
        //        {
        //            entity.CancelSaleForecastItemList.BackupList.Add((ARCancelSaleForecastItemsInfo)objCancelSaleForecastItemsInfo.Clone());
        //        }
        //    }
        //    return cancelSaleForecastID;
        //}

        public void ApprovedAdjust()
        {
            base.ActionComplete();
            // InvalidateToolbar();
            ParentScreen.SetEnableOfToolbarButton("ApprovedAdjust", false);
        }

        public void DeleteItemFromCancelSaleOrderQuantityItemList()
        {
            AdjustSaleOrderQuantityEntities entity = (AdjustSaleOrderQuantityEntities)CurrentModuleEntity;
            entity.AdjustSaleOrderQuantityItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AdjustSaleOrderQuantityEntities entity = (AdjustSaleOrderQuantityEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
            }
        }

        public override void InvalidateToolbar()
        {
            ARAdjustSaleOrderQuantitysInfo objAdjustSaleOrderQuantitysInfo = (ARAdjustSaleOrderQuantitysInfo)CurrentModuleEntity.MainObject;
            if (objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("ApprovedAdjust", false);
                if (objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityStatus == AdjustSaleOrderQuantityStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton("ApprovedAdjust", true);
                }

                if (objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityStatus == AdjustSaleOrderQuantityStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("ApprovedAdjust", false);
                }
            }
            base.InvalidateToolbar();
        }
        public void ChangeItemFromAdjustSaleOrderQuantityItemList()
        {
            AdjustSaleOrderQuantityEntities entity = (AdjustSaleOrderQuantityEntities)CurrentModuleEntity;
            ARAdjustSaleOrderQuantityItemsInfo objAdjustSaleOrderQuantityItemsInfo = (ARAdjustSaleOrderQuantityItemsInfo)entity.ModuleObjects[TableName.ARAdjustSaleOrderQuantityItemsTableName];
            entity.SetProductPriceByProductUnitPrice();
            entity.AdjustSaleOrderQuantityItemList.ChangeObjectFromList();
            UpdateTotalAmount();
        }
        public void UpdateTotalAmountByCurrency(int currencieID)
        {
            AdjustSaleOrderQuantityEntities entity = (AdjustSaleOrderQuantityEntities)CurrentModuleEntity;
            ARAdjustSaleOrderQuantitysInfo mainObject = (ARAdjustSaleOrderQuantitysInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;
            foreach (ARAdjustSaleOrderQuantityItemsInfo item in entity.AdjustSaleOrderQuantityItemList)
            {
                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            }
            entity.UpdateTotalAmount();
            entity.AdjustSaleOrderQuantityItemList.GridControl.RefreshDataSource();

            entity.UpdateMainObjectBindingSource();
        }
    }
}
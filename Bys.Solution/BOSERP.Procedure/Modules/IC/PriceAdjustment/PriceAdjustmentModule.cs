using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PriceAdjustment
{
    #region ReceiptCDModule
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ReceiptCDModule
    //Created Date:Saturday, May 31, 2008
    //-----------------------------------------------------------

    public class PriceAdjustmentModule : BaseTransactionModule
    {
        #region Constants
        public const string ReceiptItemGridControlName = "fld_dgcReceiptCDItems";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string ProductLookupEditControlName = "fld_lkeFK_ICProductID1";


        #endregion

        #region Variable
        #endregion

        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public BOSLookupEdit ProductLookupEditControl;
        public BOSGridControl GridControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public List<ICProductsInfo> ListProduct;

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        public PriceAdjustmentModule()
        {
            Name = "PriceAdjustment";
            CurrentModuleEntity = new PriceAdjustmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            StartGettingInventoryThread();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            ProductLookupEditControl = (BOSLookupEdit)Controls[ProductLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            GridControl = (BOSGridControl)Controls[ReceiptItemGridControlName];

        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ICPriceAdjustmentsInfo receipt = (ICPriceAdjustmentsInfo)CurrentModuleEntity.MainObject;


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


        public override void InvalidateToolbar()
        {
            ICPriceAdjustmentsInfo receipt = (ICPriceAdjustmentsInfo)CurrentModuleEntity.MainObject;
            if (receipt.ICPriceAdjustmentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);

            }
            if (receipt.ICPriceAdjustmentStatus == ReceiptStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(ReceiptCDConst.CompleteReceiptCD, false);
            }

            base.InvalidateToolbar();
        }





        /// <summary>
        /// Delete an item from the item list
        /// </summary>
        public void DeleteItemFromPriceAdjustmentList()
        {
            PriceAdjustmentEntities entity = (PriceAdjustmentEntities)CurrentModuleEntity;
            entity.PriceAdjustmentList.RemoveSelectedRowObjectFromList();

        }




        public override int ActionSave()
        {
            PriceAdjustmentEntities entity = (PriceAdjustmentEntities)CurrentModuleEntity;
            ICPriceAdjustmentsInfo objPriceAdjustmentsInfo = (ICPriceAdjustmentsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            entity.PriceAdjustmentList.EndCurrentEdit();
            ICPriceAdjustmentsInfo PriceAdjustments = (ICPriceAdjustmentsInfo)CurrentModuleEntity.MainObject;
            decimal TotalCost = entity.PriceAdjustmentList.Sum(x => x.ICPriceAdjustmentItemTotalCost);
            foreach (ICPriceAdjustmentItemsInfo objPriceAdjustmentItemsInfo in entity.PriceAdjustmentList)
            {
                if (TotalCost != 0)
                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemInventoryCostNew = objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemInventoryCostOld + ((objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemProductUnitCost / TotalCost) * objPriceAdjustmentsInfo.ICPriceAdjustmentTotalCost);
            }
            entity.PriceAdjustmentList.GridControl.RefreshDataSource();
            int receiptID = base.ActionSave();
            return receiptID;
        }


        public void CompletePriceAdjustment()
        {
            PriceAdjustmentEntities entity = (PriceAdjustmentEntities)CurrentModuleEntity;
            ICPriceAdjustmentsInfo objReceiptInfo = (ICPriceAdjustmentsInfo)CurrentModuleEntity.MainObject;
            ICPriceAdjustmentsController objReceiptCDsController = new ICPriceAdjustmentsController();
            objReceiptInfo.ICPriceAdjustmentStatus = ReceiptStatus.Complete.ToString();
            objReceiptCDsController.UpdateObject(objReceiptInfo);
            ActionComplete();
        }
        public void ShowFilter()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                PriceAdjustmentEntities entity = (PriceAdjustmentEntities)CurrentModuleEntity;
                ICPriceAdjustmentsInfo objPriceAdjustmentsInfo = (ICPriceAdjustmentsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                List<ICProductsInfo> ListProduct = new List<ICProductsInfo>();
                List<ICReceiptItemsInfo> ListReceiptItem = new List<ICReceiptItemsInfo>();
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                guiFilter Filter = new guiFilter();
                Filter.Module = this;
                Filter.ShowDialog();
                if (Filter.DialogResult == DialogResult.OK)
                {
                    int StockID, DepartmentID, ProductGroupID;
                    DateTime fromDate, toDate;
                    StockID = Filter.ICStockID;
                    DepartmentID = Filter.FK_ICDepartmentID;
                    ProductGroupID = Filter.FK_ICProductGroupID;
                    fromDate = Filter.FromDate;
                    toDate = Filter.ToDate;
                    ListProduct = objProductsController.GetListProductByProductGroupAndDepartment(DepartmentID, ProductGroupID);
                    if (ListProduct != null)
                    {
                        guiFind<ICProductsInfo> guiFind = new guiFind<ICProductsInfo>(TableName.ICProductsTableName,
                                                                                                           ListProduct,
                                                                                                           this,
                                                                                                           true,
                                                                                                           true,
                                                                                                           new string[] { "ICProductType", },
                                                                                                           null,
                                                                                                           true);
                        guiFind.ShowDialog();
                        if (guiFind.DialogResult == DialogResult.OK)
                        {
                            List<ICProductsInfo> ListProductSelect = guiFind.SelectedObjects as List<ICProductsInfo>;

                            foreach (ICProductsInfo item in ListProductSelect)
                            {
                                ListReceiptItem = objReceiptItemsController.GetItemByProductIDAndStockID(item.ICProductID, StockID, fromDate, toDate);
                                decimal TotalCost = ListReceiptItem.Sum(x => x.ICReceiptItemTotalCost);
                                foreach (ICReceiptItemsInfo obj in ListReceiptItem)
                                {
                                    ICPriceAdjustmentItemsInfo objPriceAdjustmentItemsInfo = new ICPriceAdjustmentItemsInfo();


                                    objPriceAdjustmentItemsInfo.FK_ICProductID = item.ICProductID;
                                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemProductName = item.ICProductName;
                                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemProductType = item.ICProductType;
                                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemProductDesc = item.ICProductDesc;
                                    objPriceAdjustmentItemsInfo.FK_ICMeasureUnitID = item.FK_ICProductBasicUnitID;
                                    objPriceAdjustmentItemsInfo.FK_ICProductGroupID = item.FK_ICProductGroupID;
                                    objPriceAdjustmentItemsInfo.FK_ICDepartmentID = item.FK_ICDepartmentID;
                                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemProductQty = obj.ICReceiptItemProductQty;
                                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemTotalCost = obj.ICReceiptItemTotalCost;
                                    objPriceAdjustmentItemsInfo.FK_ICProductSerieID = obj.FK_ICProductSerieID;
                                    objPriceAdjustmentItemsInfo.FK_ICStockID = obj.FK_ICStockID;
                                    objPriceAdjustmentItemsInfo.FK_ICInventoryStockID = obj.FK_ICInventoryStockID;
                                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemProductUnitCost = obj.ICReceiptItemProductUnitCost;
                                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemInventoryCostOld = obj.ICInventoryStockUnitCost;
                                    if (TotalCost != 0)
                                        objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemInventoryCostNew = obj.ICInventoryStockUnitCost + ((obj.ICReceiptItemProductUnitCost / TotalCost) * objPriceAdjustmentsInfo.ICPriceAdjustmentTotalCost);

                                    entity.PriceAdjustmentList.Add(objPriceAdjustmentItemsInfo);

                                }


                            }
                            entity.PriceAdjustmentList.GridControl.RefreshDataSource();


                        }
                        else
                            ActionCancel();
                    }

                }
                else
                    ActionCancel();
            }

        }
        public override void ActionNew()
        {
            base.ActionNew();
            ShowFilter();
        }
        public void ValidatedTotalCost()
        {
            PriceAdjustmentEntities entity = (PriceAdjustmentEntities)CurrentModuleEntity;
            ICPriceAdjustmentsInfo objPriceAdjustmentsInfo = (ICPriceAdjustmentsInfo)CurrentModuleEntity.MainObject;
            decimal TotalCost = entity.PriceAdjustmentList.Sum(x => x.ICPriceAdjustmentItemTotalCost);
            foreach (ICPriceAdjustmentItemsInfo objPriceAdjustmentItemsInfo in entity.PriceAdjustmentList)
            {
                if (TotalCost != 0)
                    objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemInventoryCostNew = objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemInventoryCostOld + ((objPriceAdjustmentItemsInfo.ICPriceAdjustmentItemProductUnitCost / TotalCost) * objPriceAdjustmentsInfo.ICPriceAdjustmentTotalCost);
            }
            entity.PriceAdjustmentList.GridControl.RefreshDataSource();
        }








    }
    #endregion
}
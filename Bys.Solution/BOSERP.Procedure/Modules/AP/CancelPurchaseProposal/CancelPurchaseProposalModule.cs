using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseProposal
{
    public class CancelPurchaseProposalModule : BaseTransactionModule
    {
        #region Constant
        public const string ProposalItemGridControlName = "fld_dgcAPCancelPurchaseProposalItems";
        public const string ToolbarButtonApprove = "Approve";
        public const string ToolbarButtonDiscard = "Discard";
        public const string ToolbarButtonUnApprove = "UnApprove";
        public const string APCancelPurchaseProposalAPTypeComboControlName = "fld_lkeAPCancelPurchaseProposalAPTypeCombo";
        public const string SearchBranchLookupEditControlName1 = "fld_lkeFK_BRBranchID";
        public const string ProductPicturePictureBoxName = "fld_pteAPCancelPurchaseProposalItemProductPicture";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl1;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSLookupEdit APCancelPurchaseProposalAPTypeComboControl;
        public BOSGridControl APCancelPurchaseProposalItemsGridControl;
        private BOSPictureEdit ProductPicturePictureBox;
        public bool IsSupplier { get; set; }
        public bool IsBranch { get; set; }
        #endregion

        #region Constructor
        public CancelPurchaseProposalModule()
        {
            Name = ModuleName.CancelPurchaseProposal;
            CurrentModuleEntity = new CancelPurchaseProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl1 = (BOSLookupEdit)Controls[CancelPurchaseProposalModule.SearchBranchLookupEditControlName1];
            SearchBranchLookupEditControl1.Properties.DataSource = BranchList;
            APCancelPurchaseProposalAPTypeComboControl = (BOSLookupEdit)Controls[APCancelPurchaseProposalAPTypeComboControlName];
            APCancelPurchaseProposalItemsGridControl = (BOSGridControl)Controls[ProposalItemGridControlName];
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
            StartGettingInventoryThread();
            IsSupplier = false;
            IsBranch = false;
        }
        #endregion

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            APCancelPurchaseProposalsController objAPCancelPurchaseProposalsController = new APCancelPurchaseProposalsController();
            APCancelPurchaseProposalsInfo searchObject = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl1.EditValue == null)
            {
                SearchBranchLookupEditControl1.EditValue = 0;
            }
            if (SearchBranchLookupEditControl1.EditValue.ToString() == "" || SearchBranchLookupEditControl1.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objAPCancelPurchaseProposalsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objAPCancelPurchaseProposalsController.GetCancelPurchaseProposalListDatasetByListOfBranchID(
                                                                       searchObject.APCancelPurchaseProposalNo,
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.CancelPurchaseProposalDateFrom,
                                                                       searchObject.CancelPurchaseProposalDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objAPCancelPurchaseProposalsController.GetCancelPurchaseProposalListDataset(
                                                                       searchObject.APCancelPurchaseProposalNo,
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.CancelPurchaseProposalDateFrom,
                                                                       searchObject.CancelPurchaseProposalDateTo,
                                                                       searchObject.FK_BRBranchID);
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
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            InvalidateToolbar();
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.MainObject;
            objCancelPurchaseProposalsInfo.MMBatchProductSOName = string.Join(", ", entity.CancelPurchaseProposalItemList.Where(o => !string.IsNullOrWhiteSpace(o.MMBatchProductSOName)).Select(o => o.MMBatchProductSOName).Distinct().ToArray());
            entity.UpdateMainObjectBindingSource();
            ChangedInputType(objCancelPurchaseProposalsInfo.APCancelPurchaseProposalAPTypeCombo);
            FormatCaptionOfQuantityColumnItemlist();

        }
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();

            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.MainObject;
            if (objCancelPurchaseProposalsInfo.APCancelPurchaseProposalID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                if (
                    objCancelPurchaseProposalsInfo.APCancelPurchaseProposalStatus == CancelPurchaseProposalStatus.Approved.ToString() ||
                    objCancelPurchaseProposalsInfo.APCancelPurchaseProposalStatus == CancelPurchaseProposalStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }

                ParentScreen.SetEnableOfToolbarButton(CancelPurchaseProposalModule.ToolbarButtonApprove, true);
                if (objCancelPurchaseProposalsInfo.APCancelPurchaseProposalStatus == CancelPurchaseProposalStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(CancelPurchaseProposalModule.ToolbarButtonApprove, false);
                }

                if (objCancelPurchaseProposalsInfo.APCancelPurchaseProposalStatus == CancelPurchaseProposalStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(CancelPurchaseProposalModule.ToolbarButtonApprove, false);
                }

                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonTransfer, true);
                if (objCancelPurchaseProposalsInfo.IsTransferred)
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonTransfer, false);
                }
            }
        }

        #region Local
        /// <summary>
        /// Add item to purchase proposal item list
        /// </summary>
        public void AddItemToCancelPurchaseProposalItemsList()
        {
            if (MessageBox.Show(CancelPurchaseProposalLocalizedResources.ConfirmAddNewProposalItemsMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
                APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)entity.MainObject;
                APCancelPurchaseProposalItemsInfo item = (APCancelPurchaseProposalItemsInfo)entity.ModuleObjects[TableName.APCancelPurchaseProposalItemsTableName];
                if (item.FK_ICProductID > 0)
                {
                    ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
                    List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(item.FK_ICProductID);
                    if (components.Count > 0)
                    {
                        foreach (ICProductComponentsInfo component in components)
                        {
                            item = new APCancelPurchaseProposalItemsInfo();
                            entity.SetValuesAfterValidateProduct(component.FK_ICProductComponentChildID, item);
                            item.APCancelPurchaseProposalItemProductQty = item.APCancelPurchaseProposalItemProductQty * component.ICProductComponentQty;
                            ICProductsController objProductsController = new ICProductsController();
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
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
                                    item.APCancelPurchaseProposalItemProductQty = Math.Round(item.APCancelPurchaseProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                                }
                                else
                                {
                                    item.APCancelPurchaseProposalItemProductQty = Math.Round(item.APCancelPurchaseProposalItemProductQty, 2, MidpointRounding.AwayFromZero);
                                }
                            }
                            entity.CancelPurchaseProposalItemList.Add(item);
                        }
                        entity.CancelPurchaseProposalItemList.GridControl.RefreshDataSource();
                    }
                    else
                    {
                        entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                        entity.CancelPurchaseProposalItemList.AddObjectToList();
                    }
                    UpdateTotalCost();
                }
            }
        }

        /// <summary>
        /// Called when user changes the item from the item list
        /// </summary>
        public void ChangeItemFromProposalItemList()
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            entity.SetProductCostByProductUnitCost();
            entity.CancelPurchaseProposalItemList.ChangeObjectFromList();
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when the user changes the branch
        /// </summary>
        /// <param name="branchID">Changed branch id</param>
        public void ChangeBranch(int branchID)
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            APCancelPurchaseProposalsInfo proposal = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.MainObject;
            proposal.FK_BRBranchID = branchID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show(CancelPurchaseProposalLocalizedResources.ConfirmChangeBranchForProposalItemsMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (APCancelPurchaseProposalItemsInfo item in entity.CancelPurchaseProposalItemList)
                    {
                        item.FK_BRBranchID = branchID;
                    }
                    entity.CancelPurchaseProposalItemList.GridControl.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// Called when the user changes the proposal type
        /// </summary>
        /// <param name="proposalType">Selected proposal type</param>
        public void ChangeProposalType(string proposalType)
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            APCancelPurchaseProposalsInfo proposal = (APCancelPurchaseProposalsInfo)entity.MainObject;
            proposal.APCancelPurchaseProposalType = proposalType;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.CancelPurchaseProposalItemList.Count > 0)
                {
                    if (MessageBox.Show(CancelPurchaseProposalLocalizedResources.ConfirmChangeItemProposalTypeMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (APCancelPurchaseProposalItemsInfo item in entity.CancelPurchaseProposalItemList)
                        {
                            item.APCancelPurchaseProposalItemType = proposalType;
                        }
                        entity.CancelPurchaseProposalItemList.GridControl.RefreshDataSource();
                    }
                }
            }
        }

        /// <summary>
        /// Changed input type
        /// </summary>
        /// <param name="inputType"></param>
        public void ChangedInputType()
        {
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.MainObject;
            ChangedInputType(objCancelPurchaseProposalsInfo.APCancelPurchaseProposalAPTypeCombo);
        }

        /// <summary>
        /// Changed input type
        /// </summary>
        /// <param name="inputType"></param>
        public void ChangedInputType(string inputType)
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.MainObject;
            APCancelPurchaseProposalItemsGridControl ProposalItemsGridControl = (APCancelPurchaseProposalItemsGridControl)Controls["fld_dgcAPCancelPurchaseProposalItems"];
            if (ProposalItemsGridControl != null)
            {
                ProposalItemsGridControl.LoadGridViewForRoundWood(inputType);
            }
            ICProductsController objICProductsController = new ICProductsController();
            List<ICProductsForViewInfo> productList = new List<ICProductsForViewInfo>();
            if (inputType == ProductType.Roundwood.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Roundwood.ToString()).ToList();

            }
            else if (inputType == ProductType.Lumber.ToString()
                || inputType == ProductType.Verneer.ToString()
                || inputType == ProductType.ArtificialBoard.ToString())
            {
                //ICProductType <> 'SemiProduct'
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType != ProductType.SemiProduct.ToString()).ToList();// objICProductsController.GetProductByProductWoodType();
            }
            else
            {
                //productList = objICProductsController.GetDataProductForPurchase();
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType != ProductType.SemiProduct.ToString() && p.ICProductType != ProductType.Section.ToString()).ToList();
            }
            if (entity.CancelPurchaseProposalItemList.Count > 0)
            {
                foreach (APCancelPurchaseProposalItemsInfo item in entity.CancelPurchaseProposalItemList)
                {
                    if (item.APCancelPurchaseProposalItemType == ProductType.OutSourcing.ToString())
                    {
                        ProposalItemsGridControl.LoadGridViewForPurchasePlanOutSourcing();
                        break;
                    }
                }
            }

        }
        public override void ActionNew()
        {
            base.ActionNew();
        }
        /// <summary>
        /// Action new from purchase proposal item.
        /// </summary>
        public void ActionNewFromProposalItem()
        {
            ActionNew();

            APCancelPurchaseProposalItemsController objCancelPurchaseProposalItemsController = new APCancelPurchaseProposalItemsController();
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)entity.MainObject;
            objCancelPurchaseProposalsInfo.APCancelPurchaseProposalStatus = CancelPurchaseProposalStatus.New.ToString();
            guiChooseCancelPurchaseProposalItem guiProductsOfProposalItem = new guiChooseCancelPurchaseProposalItem();
            guiProductsOfProposalItem.Module = this;
            int proposalID = 0;
            List<APProposalItemsInfo> proposalItemList = objProposalItemsController.GetActiveProposalItemByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.CancelPurchaseProposal,
                                                                                        ADDataViewPermissionType.Module);
            if (proposalItemList != null && proposalItemList.Count > 0)
            {

                List<APCancelPurchaseProposalItemsInfo> cancelPurchaseProposalItemList = new List<APCancelPurchaseProposalItemsInfo>();
                foreach (APProposalItemsInfo item in proposalItemList)
                {
                    APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo = new APCancelPurchaseProposalItemsInfo();
                    objCancelPurchaseProposalItemsInfo = SetValueFromProposalItem(item);
                    //Reset value PurchaseOrderQty by purchase order qty in status new and purchase
                    //objCancelPurchaseProposalItemsInfo.APCancelPurchaseProposalItemPurchaseOrderQty = item.APCancelPurchaseProposalItemPurchaseOrderQtyByNewAndPurchased;
                    cancelPurchaseProposalItemList.Add(objCancelPurchaseProposalItemsInfo);
                    proposalID = item.FK_APProposalID;
                }
                entity.ReferredProposalItemList.Invalidate(cancelPurchaseProposalItemList);
            }

            if (guiProductsOfProposalItem.ShowDialog() == DialogResult.OK)
            {
                List<APCancelPurchaseProposalItemsInfo> SelectedPurchaseProposalItemList = new List<APCancelPurchaseProposalItemsInfo>();
                SelectedPurchaseProposalItemList = entity.ReferredProposalItemList.Where(e => e.Selected == true).ToList();

                AddCheckedItemsToCancelPurchaseProposalItemList();

                if (SelectedPurchaseProposalItemList != null && SelectedPurchaseProposalItemList.Count > 0)
                {
                    APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(SelectedPurchaseProposalItemList.FirstOrDefault().FK_APProposalItemID);
                    if (objProposalItemsInfo != null)
                    {
                        proposalID = objProposalItemsInfo.FK_APProposalID;

                        if (proposalID > 0)
                        {
                            APProposalsController objProposalsController = new APProposalsController();
                            APProposalsInfo objProposalsInfo = (APProposalsInfo)objProposalsController.GetObjectByID(proposalID);
                            if (objProposalsInfo != null)
                            {
                                objCancelPurchaseProposalsInfo.APCancelPurchaseProposalAPTypeCombo = objProposalsInfo.APProposalAPTypeCombo;
                                objCancelPurchaseProposalsInfo.APCancelPurchaseProposalType = objProposalsInfo.APPurchaseProposalType;
                                objCancelPurchaseProposalsInfo.APCancelPurchaseProposalPONo = objProposalsInfo.APProposalPONo;
                            }
                        }
                    }
                    objCancelPurchaseProposalsInfo.MMBatchProductSOName = string.Join(", ", SelectedPurchaseProposalItemList.Where(o => !string.IsNullOrWhiteSpace(o.MMBatchProductSOName)).Select(o => o.MMBatchProductSOName).Distinct().ToArray());
                }
                ChangedInputType(objCancelPurchaseProposalsInfo.APCancelPurchaseProposalAPTypeCombo);
                List<String> List = new List<String>();

                if (SelectedPurchaseProposalItemList != null && SelectedPurchaseProposalItemList.Count > 0)
                {
                    foreach (APCancelPurchaseProposalItemsInfo item in SelectedPurchaseProposalItemList)
                    {
                        APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(item.FK_APProposalItemID);
                        if (objProposalItemsInfo != null)
                        {
                            APProposalsController objProposalsController = new APProposalsController();
                            APProposalsInfo objProposalsInfo = (APProposalsInfo)objProposalsController.GetObjectByID(objProposalItemsInfo.FK_APProposalID);
                            if (objProposalsInfo != null)
                            {
                                if (!List.Contains(objProposalsInfo.APProposalNo))
                                {
                                    List.Add(objProposalsInfo.APProposalNo);
                                }
                            }
                        }
                    }
                    objCancelPurchaseProposalsInfo.APCancelPurchaseProposalReference = string.Empty;
                    for (int i = 0; i < List.Count; i++)
                    {
                        objCancelPurchaseProposalsInfo.APCancelPurchaseProposalReference += List[i];
                        if (i < List.Count - 1)
                        {
                            objCancelPurchaseProposalsInfo.APCancelPurchaseProposalReference += ", ";
                        }
                    }
                    entity.UpdateMainObjectBindingSource();
                    FormatCaptionOfQuantityColumnItemlist();
                }
            }
            else
            {
                ActionCancel();
            }
        }

        public APCancelPurchaseProposalItemsInfo SetValueFromProposalItem(APProposalItemsInfo objProposalItemsInfo)
        {
            APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo = new APCancelPurchaseProposalItemsInfo();
            BOSUtil.CopyObject(objProposalItemsInfo, objCancelPurchaseProposalItemsInfo);
            objCancelPurchaseProposalItemsInfo.FK_APProposalItemID = objProposalItemsInfo.APProposalItemID;
            objCancelPurchaseProposalItemsInfo.APPurchaseProposalTypeVN = objProposalItemsInfo.APPurchaseProposalTypeVN;
            objCancelPurchaseProposalItemsInfo.APCancelPurchaseProposalAPTypeCombo = objProposalItemsInfo.APProposalAPTypeCombo;
            objCancelPurchaseProposalItemsInfo.APCancelPurchaseProposalItemProductQtyOld = objProposalItemsInfo.APProposalItemProductQtyOld;
            objCancelPurchaseProposalItemsInfo.APCancelPurchaseProposalItemPurchasedQty = objProposalItemsInfo.APCancelPurchaseProposalItemPurchaseOrderQtyByNewAndPurchased;
            objCancelPurchaseProposalItemsInfo.MMBatchProductSOName = objProposalItemsInfo.MMBatchProductSOName;
            return objCancelPurchaseProposalItemsInfo;
        }

        /// <summary>
        /// Check whether the selected proposal items is valid
        /// </summary>
        /// <returns>True if valid, otherwise false</returns>
        public bool CheckSelectedProposalItems()
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            IList<APCancelPurchaseProposalItemsInfo> proposalItems = entity.ReferredProposalItemList.Where(proposalItem => proposalItem.Selected == true).ToList();
            if (proposalItems.Count == 0)
            {
                MessageBox.Show(CancelPurchaseProposalLocalizedResources.ChooseProposalItemsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public override int ActionSave()
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;

            foreach (APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo in entity.CancelPurchaseProposalItemList)
            {
                //string productName = CheckProductActive(objCancelPurchaseProposalItemsInfo);
                //if (productName != string.Empty)
                //{
                //    if (MessageBox.Show(string.Format(CancelPurchaseProposalLocalizedResources.ProductActiveCheckFalseMessage, productName),
                //                CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                //    {
                //        return 0;
                //    }
                //}
                if (!(entity.CheckCancelQty(objCancelPurchaseProposalItemsInfo)))
                {
                    return 0;
                }
            }
            if (entity.CancelPurchaseProposalItemList.Count == 0)
            {

                MessageBox.Show(CancelPurchaseProposalLocalizedResources.ChoseProduct,
                                       CommonLocalizedResources.MessageBoxDefaultCaption,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                return 0;
            }


            return base.ActionSave();
        }

        public string CheckProductActive(APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            if (objCancelPurchaseProposalItemsInfo.FK_ICProductID > 0)
            {
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(objCancelPurchaseProposalItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    if (!objProductsInfo.ICProductActiveCheck)
                    {
                        return objProductsInfo.ICProductName;
                    }
                }
            }
            return string.Empty;
        }


        /// <summary>
        /// Add items to be checked to purchase proposal item list
        /// </summary>
        public void AddCheckedItemsToCancelPurchaseProposalItemList()
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            IList<APCancelPurchaseProposalItemsInfo> proposalItems = entity.ReferredProposalItemList.Where(proposalItem => proposalItem.Selected == true).ToList();
            if (proposalItems.Count > 0)
            {
                entity.CancelPurchaseProposalItemList.Invalidate(proposalItems);
                foreach (APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo in entity.CancelPurchaseProposalItemList)
                {
                    objCancelPurchaseProposalItemsInfo.APCancelPurchaseProposalItemID = 0;
                    // objCancelPurchaseProposalItemsInfo.FK_MMBatchProductID
                }
                entity.CancelPurchaseProposalItemList.GridControl.RefreshDataSource();

            }

        }

        /// <summary>
        /// Check all proposal item
        /// </summary>
        /// <param name="isChecked">Check all or not</param>
        public void CheckAllProposalItems(bool isChecked)
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            foreach (APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo in entity.ReferredProposalItemList)
            {
                objCancelPurchaseProposalItemsInfo.Selected = isChecked;
            }
            entity.ReferredProposalItemList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Delete item from proposal item list
        /// </summary>
        public void DeleteItemFromProposalItemList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
                entity.CancelPurchaseProposalItemList.RemoveSelectedRowObjectFromList();
                UpdateTotalCost();
            }
        }

        /// <summary>
        /// Update the total costs of the proposal
        /// </summary>
        public void UpdateTotalCost()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
                entity.UpdateTotalCost();
            }
        }
        #endregion

        #region Override
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPProposal report = new RPProposal();
                InitCancelPurchaseProposalReport(report);
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }
        #endregion

        /// <summary>
        /// Init purchase proposal report for displaying
        /// </summary>
        /// <param name="report">Report</param>
        private void InitCancelPurchaseProposalReport(XtraReport report)
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

            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.MainObject;
            ADReportsController objReportsController = new ADReportsController();
            report.DataSource = objReportsController.GetCancelPurchaseProposalItemByID(objCancelPurchaseProposalsInfo.APCancelPurchaseProposalID);
            report.DataMember = BOSCommon.Constants.Report.DevProposalItemReportName;
        }

        /// <summary>
        /// Approve all items of the proposal
        /// </summary>
        public void ApproveProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
                if (entity.ApproveProposal())
                {
                    entity.CancelPurchaseProposalItemList.GridControl.RefreshDataSource();
                    InvalidateToolbar();
                }

            }
        }



        #region Data Exchange
        public override void ActionTransfer(string defaultBranchConfigKey)
        {
            base.ActionTransfer(ConfigValueKey.DataExchangeDefaultBranchPurchaseProposal);
        }

        /// <summary>
        /// Transfer the proposal to a branch
        /// </summary>
        /// <param name="objBranchsInfo">Branch object</param>
        protected override bool TransferData(BRBranchsInfo objBranchsInfo)
        {
            APCancelPurchaseProposalsController objAPCancelPurchaseProposalsController = new APCancelPurchaseProposalsController();
            APCancelPurchaseProposalItemsController objProposalItemsController = new APCancelPurchaseProposalItemsController();
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)CurrentModuleEntity.MainObject;
            BOSList<APCancelPurchaseProposalItemsInfo> proposalItems = new BOSList<APCancelPurchaseProposalItemsInfo>(null, string.Empty, TableName.APCancelPurchaseProposalItemsTableName);
            DataSet ds = objProposalItemsController.GetAllDataByForeignColumn("FK_APCancelPurchaseProposalID", objCancelPurchaseProposalsInfo.APCancelPurchaseProposalID);
            proposalItems.Invalidate(ds);

            bool isCompleted = false;

            APCancelPurchaseProposalsInfo branchProposal = (APCancelPurchaseProposalsInfo)objAPCancelPurchaseProposalsController.GetObjectByNo(objCancelPurchaseProposalsInfo.APCancelPurchaseProposalNo);
            int branchProposalID;
            if (branchProposal != null)
            {
                branchProposalID = branchProposal.APCancelPurchaseProposalID;
                branchProposal = (APCancelPurchaseProposalsInfo)objCancelPurchaseProposalsInfo.Clone();
                branchProposal.APCancelPurchaseProposalID = branchProposalID;
                branchProposal.APCancelPurchaseProposalTransferredDate = BOSApp.GetCurrentServerDate();
                branchProposalID = objAPCancelPurchaseProposalsController.UpdateObject(branchProposal);
            }
            else
            {
                branchProposal = (APCancelPurchaseProposalsInfo)objCancelPurchaseProposalsInfo.Clone();
                branchProposal.AAUpdatedDate = DateTime.MaxValue;
                branchProposalID = objAPCancelPurchaseProposalsController.CreateObject(branchProposal);
            }

            if (branchProposalID > 0)
            {
                //Transfer proposal items
                TransferProposalItemsToBranch(proposalItems, branchProposalID);
            }

            isCompleted = true;
            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (isCompleted)
            {
                objCancelPurchaseProposalsInfo.IsTransferred = true;
                objCancelPurchaseProposalsInfo.APCancelPurchaseProposalTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objAPCancelPurchaseProposalsController.UpdateObject(objCancelPurchaseProposalsInfo);
            }
            //NUThao [ADD] [08/04/2014] [DB centre] [SwitchConnection issue], END

            return isCompleted;
        }

        /// <summary>
        /// Transfer the proposal items to a branch
        /// </summary>
        /// <param name="proposalItems">Proposal item list</param>
        /// <param name="branchProposalID">Proposal id at the target branch</param>
        private void TransferProposalItemsToBranch(BOSList<APCancelPurchaseProposalItemsInfo> proposalItems, int branchProposalID)
        {
            APCancelPurchaseProposalItemsController objProposalItemsController = new APCancelPurchaseProposalItemsController();

            objProposalItemsController.DeleteByForeignColumn("FK_APCancelPurchaseProposalID", branchProposalID);

            foreach (APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo in proposalItems)
            {
                APCancelPurchaseProposalItemsInfo objBranchProposalItemInfo = (APCancelPurchaseProposalItemsInfo)objCancelPurchaseProposalItemsInfo.Clone();
                objBranchProposalItemInfo.FK_APCancelPurchaseProposalID = branchProposalID;
                objProposalItemsController.CreateObject(objBranchProposalItemInfo);
            }
        }
        #endregion

        /// <summary>
        /// No need to lock purchase proposal, the function will override the
        /// base behaviour and return false all the time
        /// </summary>
        /// <returns></returns>
        protected override bool IsTransactionLocked()
        {
            return false;
        }
        public decimal CalculateOverallDimension(MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo, decimal insideDimension)
        {
            decimal overallDimension = 0;
            if (insideDimension > 0)
            {
                int value = objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationValue;
                if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Plus.ToString())
                {
                    overallDimension = insideDimension + value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Minus.ToString())
                {
                    overallDimension = insideDimension - value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Multi.ToString())
                {
                    overallDimension = insideDimension * value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Split.ToString())
                {
                    if (value != 0)
                    {
                        overallDimension = insideDimension / value;
                    }
                }
            }
            return overallDimension;
        }
        public void CalculateProductionNormItemPackaging()
        {

            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            if (entity.CancelPurchaseProposalItemList != null && entity.CancelPurchaseProposalItemList.Count > 0)
            {

                MMOverallInsideDimensionConfigsController objOverallInsideDimensionConfigsController = new MMOverallInsideDimensionConfigsController();
                List<MMOverallInsideDimensionConfigsInfo> overallInsideDimensionConfigsList = new List<MMOverallInsideDimensionConfigsInfo>();
                MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo = new MMOverallInsideDimensionConfigsInfo();
                foreach (APCancelPurchaseProposalItemsInfo item in entity.CancelPurchaseProposalItemList)
                {
                    #region dimension

                    item.APCancelPurchaseProposalItemOverallDemensionHeight = 0;
                    item.APCancelPurchaseProposalItemOverallDemensionWitdh = 0;
                    item.APCancelPurchaseProposalItemOverallDemensionLength = 0;
                    if (item.FK_ICProdAttPackingMaterialSpecialityID > 0)
                    {
                        #region Height
                        overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(item.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Height.ToString(), item.FK_ICProductGroupID);
                        objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                        if (objOverallInsideDimensionConfigsInfo != null)
                        {
                            item.APCancelPurchaseProposalItemOverallDemensionHeight = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                               item.APCancelPurchaseProposalItemInsideDemensionHeight);
                        }
                        #endregion
                        #region Width
                        overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(item.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Width.ToString(), item.FK_ICProductGroupID);
                        objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                        if (objOverallInsideDimensionConfigsInfo != null)
                        {
                            item.APCancelPurchaseProposalItemOverallDemensionWitdh = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                               item.APCancelPurchaseProposalItemInsideDemensionWitdh);
                        }
                        #endregion
                        #region Length
                        overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(item.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Length.ToString(), item.FK_ICProductGroupID);
                        objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                        if (objOverallInsideDimensionConfigsInfo != null)
                        {
                            item.APCancelPurchaseProposalItemOverallDemensionLength = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                               item.APCancelPurchaseProposalItemInsideDemensionLength);
                        }
                        #endregion
                    }

                    #endregion

                    #region mô tả
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);

                    if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString() &&
                        item.FK_MMAllocationProposalID == 0 &&
                        item.FK_MMAllocationProposalItemID == 0 &&
                        item.FK_MMPurchasePlanID == 0 &&
                        item.FK_MMPurchasePlanItemID == 0) // Không tạo từ KHMH or LCP
                    {
                        item.APCancelPurchaseProposalItemProductDesc = string.Empty;
                        if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductName))
                        {
                            item.APCancelPurchaseProposalItemProductDesc += item.APCancelPurchaseProposalItemProductName.Trim();
                        }
                        if (!(item.APCancelPurchaseProposalItemInsideDemensionWitdh == 0
                            && item.APCancelPurchaseProposalItemInsideDemensionLength == 0
                            && item.APCancelPurchaseProposalItemInsideDemensionHeight == 0))
                        {
                            if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductDesc))
                            {
                                item.APCancelPurchaseProposalItemProductDesc += ", ";
                            }
                            item.APCancelPurchaseProposalItemProductDesc += item.APCancelPurchaseProposalItemInsideDemensionLength.ToString().Trim()
                                + "x" + item.APCancelPurchaseProposalItemInsideDemensionWitdh.ToString().Trim()
                                + "x" + item.APCancelPurchaseProposalItemInsideDemensionHeight.ToString().Trim();
                        }
                        if (!(item.APCancelPurchaseProposalItemOverallDemensionWitdh == 0
                            && item.APCancelPurchaseProposalItemOverallDemensionLength == 0
                            && item.APCancelPurchaseProposalItemOverallDemensionHeight == 0))
                        {
                            if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductDesc))
                            {
                                item.APCancelPurchaseProposalItemProductDesc += ", ";
                            }
                            item.APCancelPurchaseProposalItemProductDesc += item.APCancelPurchaseProposalItemOverallDemensionLength.ToString().Trim()
                                + "x" + item.APCancelPurchaseProposalItemOverallDemensionWitdh.ToString().Trim()
                                + "x" + item.APCancelPurchaseProposalItemOverallDemensionHeight.ToString().Trim();
                        }
                        if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductSizeAndPacking))
                        {
                            if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductDesc))
                            {
                                item.APCancelPurchaseProposalItemProductDesc += ", ";
                            }
                            item.APCancelPurchaseProposalItemProductDesc += item.APCancelPurchaseProposalItemProductSizeAndPacking.Trim();
                        }
                        if (item.FK_ICProdAttPackingMaterialSpecialityID > 0)
                        {
                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSpecialityID);
                            if (objAttribute != null)
                            {
                                if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductDesc))
                                {
                                    item.APCancelPurchaseProposalItemProductDesc += ", ";
                                }
                                item.APCancelPurchaseProposalItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                            }
                        }
                        if (item.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                        {
                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                            if (objAttribute != null)
                            {
                                if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductDesc))
                                {
                                    item.APCancelPurchaseProposalItemProductDesc += ", ";
                                }
                                item.APCancelPurchaseProposalItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                            }
                        }
                        if (item.FK_ICProdAttPackingMaterialSizeID > 0)
                        {

                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSizeID);
                            if (objAttribute != null)
                            {
                                if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductDesc))
                                {
                                    item.APCancelPurchaseProposalItemProductDesc += ", ";
                                }
                                item.APCancelPurchaseProposalItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                            }
                        }
                        if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemComment))
                        {
                            if (!string.IsNullOrEmpty(item.APCancelPurchaseProposalItemProductDesc))
                            {
                                item.APCancelPurchaseProposalItemProductDesc += ", ";
                            }
                            item.APCancelPurchaseProposalItemProductDesc += item.APCancelPurchaseProposalItemComment.Trim();
                        }


                        #endregion
                    }
                }
            }


            entity.CancelPurchaseProposalItemList.GridControl.RefreshDataSource();


        }

        public void FormatCaptionOfQuantityColumnItemlist()
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)CurrentModuleEntity;

            APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo = entity.CancelPurchaseProposalItemList.FirstOrDefault(o1 => o1.FK_APProposalID != 0);
            if (objCancelPurchaseProposalItemsInfo != null)
            {
                APProposalsController objProposalsController = new APProposalsController();
                APProposalsInfo objProposalsInfo = (APProposalsInfo)objProposalsController.GetObjectByID(objCancelPurchaseProposalItemsInfo.FK_APProposalID);
                if (objProposalsInfo != null)
                {
                    List<string> lumberGroups = new List<string>() { ProposalAPType.Lumber.ToString(),
                                                            ProposalAPType.Roundwood.ToString()};

                    if (APCancelPurchaseProposalItemsGridControl != null)
                    {
                        GridView gridView = (GridView)APCancelPurchaseProposalItemsGridControl.MainView;
                        if (gridView != null)
                        {
                            GridColumn qtyColumn = gridView.Columns["APCancelPurchaseOrderItemProductQty"];
                            if (lumberGroups.Contains(objProposalsInfo.APProposalAPTypeCombo))
                            {
                                if (qtyColumn != null)
                                {
                                    qtyColumn.Caption = "Khối lượng hủy";
                                }
                            }
                            else
                            {
                                if (qtyColumn != null)
                                {
                                    qtyColumn.Caption = "Số lượng hủy";
                                }
                            }
                        }
                    }
                }
            }

        }

        public void InitProductPictureImage(int productID)
        {
            if (productID > 0 && ProductPicturePictureBox != null)
            {
                ProductPicturePictureBox.Image = BOSApp.GetProductPictureImageByProductID(productID);
                ProductPicturePictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
        }
    }
}
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

namespace BOSERP.Modules.PurchaseProposal
{
    public class PurchaseProposalModule : BaseTransactionModule
    {
        #region Constant
        public const string ProposalItemGridControlName = "fld_dgcAPProposalItems";
        public const string ToolbarButtonApprove = "Approve";
        public const string ToolbarButtonConfirm = "Confirm";
        public const string ToolbarButtonDiscardPurchaseProposal = "DiscardPurchaseProposal";
        public const string ToolbarButtonDiscard = "Discard";
        public const string ToolbarButtonUnApprove = "UnApprove";
        public const string ToolbarButtonCancelApprove = "CancelApprove";
        public const string APProposalAPTypeComboControlName = "fld_lkeAPProposalAPTypeCombo";
        public const string ProductItemLookUpEditControlName = "fld_lkeFK_ICProductAttributeID";
        //public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string SearchBranchLookupEditControlName1 = "fld_lkeFK_BRBranchID";
        public const string ProductPicturePictureBoxName = "fld_pteAPProposalItemProductPicture";
        public const decimal PriceLevelToApprove = 5000000;
        #endregion

        #region Public properties
        //public BOSLookupEdit SearchBranchLookupEditControl;
        public BOSLookupEdit SearchBranchLookupEditControl1;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSLookupEdit APProposalAPTypeComboControl;
        public BOSLookupEdit ProductItemLookUpEditControl;
        public BOSGridControl ProposalItemGridControl;
        public APProposalItemsGridControl APProposalItemsGridControl;
        public APProposalItemsGridControl ProposalItemsGridControl;
        private BOSPictureEdit ProductPicturePictureBox;
        #endregion

        #region Constructor
        public PurchaseProposalModule()
        {
            Name = ModuleName.PurchaseProposal;
            CurrentModuleEntity = new PurchaseProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            //SearchBranchLookupEditControl = (BOSLookupEdit)Controls[PurchaseProposalModule.SearchBranchLookupEditControlName];
            //SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            SearchBranchLookupEditControl1 = (BOSLookupEdit)Controls[PurchaseProposalModule.SearchBranchLookupEditControlName1];
            SearchBranchLookupEditControl1.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            APProposalAPTypeComboControl = (BOSLookupEdit)Controls[APProposalAPTypeComboControlName];
            ProductItemLookUpEditControl = (BOSLookupEdit)Controls[ProductItemLookUpEditControlName];
            ProposalItemGridControl = (BOSGridControl)Controls[ProposalItemGridControlName];

            APProposalItemsGridControl = (APProposalItemsGridControl)Controls[ProposalItemGridControlName];
            ProposalItemsGridControl = (APProposalItemsGridControl)Controls[ProposalItemGridControlName];
            ProductPicturePictureBox = (BOSPictureEdit)Controls[ProductPicturePictureBoxName];
            StartGettingInventoryThread();
        }
        #endregion

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            APProposalsController objProposalsController = new APProposalsController();
            APProposalsInfo searchObject = (APProposalsInfo)CurrentModuleEntity.SearchObject;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START

            DataSet ds = new DataSet();
            if (searchObject.FK_BRBranchID == 0)
            {
                if (BranchList.Count == 0)
                {
                    ds = objProposalsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objProposalsController.GetPurchaseProposalListDatasetByListOfBranchID(
                                                                       searchObject.APProposalNo,
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.ProposalDateFrom,
                                                                       searchObject.ProposalDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objProposalsController.GetPurchaseProposalListDataset(
                                                                       searchObject.APProposalNo,
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.ProposalDateFrom,
                                                                       searchObject.ProposalDateTo,
                                                                       searchObject.FK_BRBranchID);
            }

            return ds;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
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
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            InvalidateToolbar();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            objProposalsInfo.MMBatchProductSOName = string.Join(", ", entity.PurchaseProposalItemList.Where(o => !string.IsNullOrWhiteSpace(o.MMBatchProductSOName)).Select(o => o.MMBatchProductSOName).Distinct().ToArray());
            entity.UpdateMainObjectBindingSource();
            ChangedInputType(objProposalsInfo.APProposalAPTypeCombo);
            FormatCaptionOfQuantityColumnItemlist();
            if (entity.PurchaseProposalItemList != null && entity.PurchaseProposalItemList.Count > 0)
            {
                APProposalItemsGridControl grid = (APProposalItemsGridControl)Controls["fld_dgcAPProposalItems"];
                ICProductsController objProductsController = new ICProductsController();
                APProposalItemsInfo item = entity.PurchaseProposalItemList.FirstOrDefault();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (grid != null)
                {
                    if (objProductsInfo != null)
                    {
                        grid.FormatQuantity(objProductsInfo.ICProductType);
                    }
                }
            }
            ChangeDisplayColumnByWoodType(entity.PurchaseProposalItemList.GridControl, objProposalsInfo.APProposalAPTypeCombo);
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (objProposalsInfo.APProposalID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonUnApprove, false);
                ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonConfirm, false);
                ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonApprove, false);
                ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscardPurchaseProposal, false);
                ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscard, false);
                if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonConfirm, true);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscardPurchaseProposal, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonUnApprove, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                }
                if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Confirmed.ToString() ||
                    objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Approved.ToString() ||
                    objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonSave, false);
                }
                if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonConfirm, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscardPurchaseProposal, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonUnApprove, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                    //ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscard, true);
                }
                if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Confirmed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonApprove, true);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonConfirm, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonUnApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscardPurchaseProposal, true);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscard, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonConfirm, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonUnApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscardPurchaseProposal, false);
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscard, false);
                }
                if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(PurchaseProposalModule.ToolbarButtonDiscard, true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
        }

        #region Local
        /// <summary>
        /// Add item to purchase proposal item list
        /// </summary>
        public void AddItemToPurchaseProposalItemsList(int productID)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            //APProposalItemsInfo item = (APProposalItemsInfo)entity.ModuleObjects[TableName.APProposalItemsTableName];
            APProposalItemsInfo item = new APProposalItemsInfo();
            item.FK_ICProductID = productID;
            if (productID > 0)
            {
                entity.SetValuesAfterValidateProduct(item);
                //entity.PurchaseProposalItemList.Add(item);
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
                List<ICProductComponentsInfo> components = objProductComponentsController.GetProductComponentListByProductID(item.FK_ICProductID);
                if (components.Count > 0)
                {
                    foreach (ICProductComponentsInfo component in components)
                    {
                        item = new APProposalItemsInfo();
                        entity.SetValuesAfterValidateProduct(component.FK_ICProductComponentChildID, item);
                        item.APProposalItemProductQty = item.APProposalItemProductQty * component.ICProductComponentQty;
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

                                item.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                                item.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                            }
                        }
                        if (objProposalsInfo.APProposalAPTypeCombo == ProposalAPType.IngredientPaint.ToString())
                            item.APProposalItemProductQty = Math.Round(item.APProposalItemProductQty, 5, MidpointRounding.AwayFromZero);
                        else
                            item.APProposalItemProductQty = Math.Round(item.APProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                        item.APProposalItemProductFactor = 1;
                        item.APProposalItemProductExchangeQty = item.APProposalItemProductQty;
                        APProposalItemsGridControl grid = (APProposalItemsGridControl)Controls["fld_dgcAPProposalItems"];
                        if (grid != null)
                        {
                            grid.FormatQuantity(objProductsInfo.ICProductType);
                        }
                        item.APProposalItemNeedTime = objProposalsInfo.APProposalNeedTime;
                        item.APProposalItemNeedToTime = objProposalsInfo.APProposalNeedToTime;
                        entity.PurchaseProposalItemList.Add(item);
                    }
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                }
                else
                {
                    entity.SetValuesAfterValidateProduct(item.FK_ICProductID);
                    item.APProposalItemNeedTime = objProposalsInfo.APProposalNeedTime;
                    item.APProposalItemNeedToTime = objProposalsInfo.APProposalNeedToTime;
                    entity.PurchaseProposalItemList.Add(item);
                    //entity.PurchaseProposalItemList.AddObjectToList();
                }
                UpdateTotalCost();
            }
        }

        /// <summary>
        /// Called when user changes the item from the item list
        /// </summary>
        public void ChangeProposalItem(APProposalItemsInfo item)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            entity.SetProductCostByProductUnitCost(item);
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when user changes the item from the item list
        /// </summary>
        public void ChangeItemFromProposalItemTotalList()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            entity.SetProductCostByProductUnitCost();
            entity.PurchaseProposalItemTotalList.ChangeObjectFromList();
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when the user changes the branch
        /// </summary>
        /// <param name="branchID">Changed branch id</param>
        public void ChangeBranch(int branchID)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo proposal = (APProposalsInfo)CurrentModuleEntity.MainObject;
            proposal.FK_BRBranchID = branchID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show(PurchaseProposalLocalizedResources.ConfirmChangeBranchForProposalItemsMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (APProposalItemsInfo item in entity.PurchaseProposalItemList)
                    {
                        item.FK_BRBranchID = branchID;
                    }
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();

                    if (entity.PurchaseProposalItemTotalList != null && entity.PurchaseProposalItemTotalList.Count > 0)
                    {
                        foreach (APProposalItemTotalsInfo itemTotal in entity.PurchaseProposalItemTotalList)
                        {
                            itemTotal.FK_BRBranchID = branchID;
                        }
                        entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
                    }

                }
            }
        }

        /// <summary>
        /// Called when the user changes the proposal type
        /// </summary>
        /// <param name="proposalType">Selected proposal type</param>
        public void ChangeProposalType(string proposalType)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo proposal = (APProposalsInfo)entity.MainObject;
            proposal.APPurchaseProposalType = proposalType;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.PurchaseProposalItemList.Count > 0)
                {
                    if (MessageBox.Show(PurchaseProposalLocalizedResources.ConfirmChangeItemProposalTypeMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (APProposalItemsInfo item in entity.PurchaseProposalItemList)
                        {
                            item.APPurchaseProposalItemType = proposalType;
                        }
                        entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                        if (entity.PurchaseProposalItemTotalList != null && entity.PurchaseProposalItemTotalList.Count > 0)
                        {
                            foreach (APProposalItemTotalsInfo itemTotal in entity.PurchaseProposalItemTotalList)
                            {
                                itemTotal.APPurchaseProposalItemType = proposalType;
                            }
                            entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
                        }
                    }
                }
            }
        }

        public void ChangeProposalAPTypeCombo(string proposalAPTypeCombo)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo proposal = (APProposalsInfo)entity.MainObject;
            proposal.APProposalAPTypeCombo = proposalAPTypeCombo;
            ChangedInputType(proposalAPTypeCombo);
            entity.UpdateMainObjectBindingSource();
            FormatCaptionOfQuantityColumnItemlist();
            ChangeDisplayColumnByWoodType(entity.PurchaseProposalItemList.GridControl, proposal.APProposalAPTypeCombo);
        }

        public void FormatCaptionOfQuantityColumnItemlist()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo proposal = (APProposalsInfo)entity.MainObject;
            List<string> lumberGroups = new List<string>() { ProposalAPType.Lumber.ToString(),
                                                            ProposalAPType.Roundwood.ToString()};

            if (APProposalItemsGridControl != null)
            {
                GridView gridView = (GridView)APProposalItemsGridControl.MainView;
                if (gridView != null)
                {
                    GridColumn qtyColumn = gridView.Columns["APProposalItemProductQty"];
                    if (lumberGroups.Contains(proposal.APProposalAPTypeCombo))
                    {
                        if (qtyColumn != null)
                        {
                            qtyColumn.Caption = "Khối lượng";
                        }
                    }
                    else
                    {
                        if (qtyColumn != null)
                        {
                            qtyColumn.Caption = "Số lượng";
                        }
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
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            ChangedInputType(objProposalsInfo.APProposalAPTypeCombo);
        }

        /// <summary>
        /// Changed input type
        /// </summary>
        /// <param name="inputType"></param>
        public void ChangedInputType(string inputType)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            APProposalItemsGridControl ProposalItemsGridControl = (APProposalItemsGridControl)Controls["fld_dgcAPProposalItems"];
            if (ProposalItemsGridControl == null)
                return;

            bool isChangeInputType = false;
            if (ProposalItemsGridControl != null)
            {
                isChangeInputType = true;
            }
            ICProductsController objICProductsController = new ICProductsController();
            List<ICProductsForViewInfo> productList = new List<ICProductsForViewInfo>();
            if (string.IsNullOrWhiteSpace(inputType))
            {
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType != ProductType.SemiProduct.ToString() && p.ICProductType != ProductType.Section.ToString()).ToList();
            }
            else if (inputType == ProductType.Roundwood.ToString()
                || inputType == ProductType.Lumber.ToString()
                || inputType == ProductType.Verneer.ToString()
                || inputType == ProductType.ArtificialBoard.ToString())
            {
                //ICProductType <> 'SemiProduct'
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType != ProductType.SemiProduct.ToString() && p.ICProductType == inputType).ToList();// objICProductsController.GetProductByProductWoodType();
            }
            else if (inputType == "dichvuvagiacong")
            {
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Service.ToString()).ToList();
                //objICProductsController.GetProductByProductType(ProductType.Service.ToString());
            }
            else if (inputType == ProductType.Other.ToString())
            {
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Equipment.ToString()
                                                                   || p.ICProductType == ProductType.VVP.ToString()
                                                                   || p.ICProductType == ProductType.MMTB.ToString()
                                                                   || p.ICProductType == ProductType.Service.ToString()
                                                                   || p.ICProductType == ProductType.Electric.ToString()
                                                                   || p.ICProductType == ProductType.BuildingMaterials.ToString()
                                                                   || p.ICProductType == ProductType.Asset.ToString()
                                                                   ).ToList();
                //objICProductsController.GetProductByProductType(ProductType.Service.ToString());
            }
            else
            {
                //productList = objICProductsController.GetLookupEditProductByProductType(inputType);
                productList = BOSApp.CurrentProductList.Where(p => p.ICProductType != ProductType.SemiProduct.ToString() && p.ICProductType != ProductType.Section.ToString() && p.ICProductType == inputType).ToList();
            }

            ProductItemLookUpEditControl.Properties.DataSource = productList;
            if (objProposalsInfo.FK_MMPurchasePlanID > 0)
                ProductItemLookUpEditControl.Enabled = false;
            else
                ProductItemLookUpEditControl.Enabled = true;
        }
        public override void ActionNew()
        {
            base.ActionNew();
            ProductItemLookUpEditControl.Enabled = true;
            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(mainobject.FK_HREmployeeID);
            mainobject.FK_HRDepartmentRoomID = objEmployeesInfo == null ? 0 : objEmployeesInfo.FK_HRDepartmentRoomID;
            ChangedInputType();
            FormatCaptionOfQuantityColumnItemlist();
        }

        public void ActionNewFromPurchasePlanTotalHW()
        {
            ActionNew();
            ShowPurchasePlaneTotalByType(ProductType.Hardware.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanTotalPackaging()
        {
            ActionNew();
            ShowPurchasePlaneTotalByType(ProductType.IngredientPackaging.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }


        public void ActionNewFromPurchasePlanTotalPaint()
        {
            ActionNew();
            ShowPurchasePlaneTotalByType(ProductType.IngredientPaint.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
            APProposalItemsGridControl grid = (APProposalItemsGridControl)Controls["fld_dgcAPProposalItems"];
            if (grid != null)
            {
                grid.FormatQuantity(ProductType.IngredientPaint.ToString());
            }
        }

        public void ActionNewFromPurchasePlanTotalInstrument()
        {
            ActionNew();
            //ShowPurchasePlaneTotalByType(ProductType.Instrument.ToString());
            ShowPurchasePlaneTotalByType(null);
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ShowPurchasePlaneTotalByType(string type)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            MMPurchasePlanItemTotalsController oPurchasePlanItemTotalsController = new MMPurchasePlanItemTotalsController();
            MMPurchasePlanItemTotalsInfo objPurchasePlanItemTotalsInfo = new MMPurchasePlanItemTotalsInfo();
            List<MMPurchasePlanItemTotalsInfo> PurchasePlanItemTotalList = oPurchasePlanItemTotalsController.GetPurchasePlanItemTotalWoodForPurchaseProposal(type);
        abc:
            guiFind<MMPurchasePlanItemTotalsInfo> guiFind = new guiFind<MMPurchasePlanItemTotalsInfo>(TableName.MMPurchasePlanItemTotalsTableName,
                                                                                            PurchasePlanItemTotalList,
                                                                                            this,
                                                                                            true,
                                                                                            true);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<MMPurchasePlanItemTotalsInfo> selectedBatchProductPlanTotalWoods = guiFind.SelectedObjects as List<MMPurchasePlanItemTotalsInfo>;
                int purchasePlanID = guiFind.SelectedObjects[0].FK_MMPurchasePlanID;
                foreach (MMPurchasePlanItemTotalsInfo item in selectedBatchProductPlanTotalWoods)
                {
                    if (item.FK_MMPurchasePlanID != purchasePlanID)
                    {
                        MessageBox.Show(PurchaseProposalLocalizedResources.NotMatchPurchasePlanIDMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        goto abc;
                    }
                }
                objPurchasePlanItemTotalsInfo = (MMPurchasePlanItemTotalsInfo)guiFind.SelectedObjects[0];
                if (objPurchasePlanItemTotalsInfo != null)
                {
                    MMPurchasePlansController objPurchasePlansController = new MMPurchasePlansController();
                    MMPurchasePlansInfo objPurchasePlansInfo = (MMPurchasePlansInfo)objPurchasePlansController.GetObjectByID(objPurchasePlanItemTotalsInfo.FK_MMPurchasePlanID);
                    if (objPurchasePlansInfo != null)
                    {
                        objProposalsInfo.APPurchaseProposalType = objPurchasePlansInfo.MMPurchasePlanType;
                        objProposalsInfo.APProposalPONo = objPurchasePlansInfo.MMPurchasePlanPONo;
                        entity.UpdateMainObjectBindingSource();
                    }
                    if (type == "Roundwood")
                        objProposalsInfo.APProposalAPTypeCombo = ProductType.Roundwood.ToString();
                    else if (type == "FreshLumber")
                        objProposalsInfo.APProposalAPTypeCombo = ProductType.Lumber.ToString();
                    else if (type == "DryLumber")
                        objProposalsInfo.APProposalAPTypeCombo = ProductType.Lumber.ToString();
                    else
                        objProposalsInfo.APProposalAPTypeCombo = ProductType.Product.ToString();
                    if (!GetSelectedBatchProductPlanTotalWoodSelected(selectedBatchProductPlanTotalWoods, purchasePlanID, type))
                    {
                        ActionCancel();
                    }
                }
            }
            else
                ActionCancel();
        }

        public bool GetSelectedBatchProductPlanTotalWoodSelected(List<MMPurchasePlanItemTotalsInfo> selectedBatchProductPlanTotalWoods, int purchasePlanID, string woodType)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            List<MMPurchasePlanItemsInfo> purchasePlanItemList = objPurchasePlanItemsController.GetPurchasePlanItemByProposal(purchasePlanID);
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (MMPurchasePlanItemTotalsInfo itemTotal in selectedBatchProductPlanTotalWoods)
            {
                APProposalItemTotalsInfo objProposalItemTotalsInfo = new APProposalItemTotalsInfo();
                BOSUtil.CopyObject(itemTotal, objProposalItemTotalsInfo);
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(itemTotal.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objProposalItemTotalsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    objProposalItemTotalsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                    objProposalItemTotalsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                    objProposalItemTotalsInfo.APProposalItemTotalProductType = objProductsInfo.ICProductType;
                }
                objProposalItemTotalsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.New.ToString();
                objProposalItemTotalsInfo.APPurchaseProposalItemType = woodType;
                objProposalItemTotalsInfo.FK_MMPurchasePlanItemTotalID = itemTotal.MMPurchasePlanItemTotalID;
                objProposalItemTotalsInfo.APProposalItemTotalProductSupplierNo = itemTotal.MMPurchasePlanItemTotalProductSupplierNumber;
                objProposalItemTotalsInfo.FK_BRBranchID = objProposalsInfo.FK_BRBranchID;
                //itemTotal.MMPurchasePlanItemTotalQuantity = itemTotal.MMPurchasePlanItemTotalQuantity + itemTotal.MMPurchasePlanItemTotalPurchaseOutsideQty - itemTotal.MMPurchasePlanItemTotalCanceledQuantity;
                //if (itemTotal.MMPurchasePlanItemTotalQuantity > itemTotal.MMPurchasePlanItemTotalPurchaseProposalQty)
                //    objProposalItemTotalsInfo.APProposalItemTotalProductQty = itemTotal.MMPurchasePlanItemTotalQuantity - itemTotal.MMPurchasePlanItemTotalPurchaseProposalQty;
                //else
                objProposalItemTotalsInfo.APProposalItemTotalProductQty = itemTotal.MMPurchasePlanItemTotalQuantity;

                APProposalItemTotalsInfo proposalItemTotal = entity.PurchaseProposalItemTotalList.Where(x => x.FK_ICProductID == objProposalItemTotalsInfo.FK_ICProductID && x.FK_MMPurchasePlanID == objProposalItemTotalsInfo.FK_MMPurchasePlanID).FirstOrDefault();
                if (proposalItemTotal != null)
                {
                    proposalItemTotal.APProposalItemTotalProductQty += objProposalItemTotalsInfo.APProposalItemTotalProductQty;
                    dbUtil.SetPropertyValue(entity.PurchaseProposalItemTotalList, "APProposalItemTotalProductQty", proposalItemTotal.APProposalItemTotalProductQty);
                }
                else
                {
                    entity.PurchaseProposalItemTotalList.Add(objProposalItemTotalsInfo);
                }

                List<MMPurchasePlanItemsInfo> PurchasePlanItems = purchasePlanItemList.Where(x => x.FK_ICProductID == itemTotal.FK_ICProductID && x.FK_MMPurchasePlanID == itemTotal.FK_MMPurchasePlanID && x.FK_MMBatchProductID == itemTotal.FK_MMBatchProductID).ToList();
                if (PurchasePlanItems != null)
                {
                    foreach (MMPurchasePlanItemsInfo item in PurchasePlanItems)
                    {
                        APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
                        if (objProductsInfo != null)
                        {
                            objProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                            objProposalItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                            objProposalItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                            objProposalItemsInfo.APProposalItemProductType = objProductsInfo.ICProductType;
                        }
                        BOSUtil.CopyObject(item, objProposalItemsInfo);
                        objProposalItemsInfo.APProposalItemProductSupplierNo = item.MMPurchasePlanItemProductSupplierNumber;
                        objProposalItemsInfo.FK_BRBranchID = objProposalsInfo.FK_BRBranchID;

                        objProposalItemsInfo.FK_MMPurchasePlanID = item.FK_MMPurchasePlanID;
                        objProposalItemsInfo.FK_MMPurchasePlanItemID = item.MMPurchasePlanItemID;
                        objProposalItemsInfo.APProposalItemProductionNormItemTotalPaint = Math.Round(objProposalItemsInfo.APProposalItemProductionNormItemTotalPaint, 4, MidpointRounding.AwayFromZero);
                        objProposalItemsInfo.APProposalItemProductionNormItemTotalBlocks = Math.Round(objProposalItemsInfo.APProposalItemProductionNormItemTotalBlocks, 4, MidpointRounding.AwayFromZero);
                        objProposalItemsInfo.APProposalItemProductionNormItemPaint = Math.Round(objProposalItemsInfo.APProposalItemProductionNormItemPaint, 4, MidpointRounding.AwayFromZero);
                        objProposalItemsInfo.APProposalItemProductionNormItemBlocks = Math.Round(objProposalItemsInfo.APProposalItemProductionNormItemBlocks, 4, MidpointRounding.AwayFromZero);
                        objProposalItemsInfo.FK_MMPurchasePlanItemID = item.MMPurchasePlanItemID;
                        ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                        ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                        objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("BatchProductPlanWoodPurchaseType", item.MMPurchasePlanItemPurchaseType);
                        if (objConfigValuesInfo != null)
                        {
                            objProposalItemsInfo.APProposalItemComment = objConfigValuesInfo.ADConfigText;
                        }
                        //item.MMPurchasePlanItemQuantity = item.MMPurchasePlanItemQuantity - item.MMPurchasePlanItemCanceledQuantity;
                        //if (item.MMPurchasePlanItemQuantity > item.MMPurchasePlanItemPurchaseProposalQty)
                        //{
                        // objProposalItemsInfo.APProposalItemProductQty = item.MMPurchasePlanItemQuantity - item.MMPurchasePlanItemPurchaseProposalQty;
                        objProposalItemsInfo.APProposalItemProductQty = item.MMPurchasePlanItemQuantity;
                        if (woodType == "FreshLumber")
                            objProposalItemsInfo.APProposalItemProductHeight = item.MMPurchasePlanItemFreshLumberHeight;

                        else if (woodType == "DryLumber")
                            objProposalItemsInfo.APProposalItemProductHeight = item.MMPurchasePlanItemDryLumberHeight;
                        objProposalItemsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.New.ToString();
                        objProposalItemsInfo.APPurchaseProposalItemType = woodType;
                        if (objProductsInfo != null)
                        {
                            if (
                                   objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                                   objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                            {
                                objProposalItemsInfo.APProposalItemProductQty = Math.Round(objProposalItemsInfo.APProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                            }
                            else if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString())
                            {
                                objProposalItemsInfo.APProposalItemProductQty = Math.Round(objProposalItemsInfo.APProposalItemProductQty, 5, MidpointRounding.AwayFromZero);
                            }
                            else
                            {
                                objProposalItemsInfo.APProposalItemProductQty = Math.Round(objProposalItemsInfo.APProposalItemProductQty, 2, MidpointRounding.AwayFromZero);
                            }
                        }
                        entity.PurchaseProposalItemList.Add(objProposalItemsInfo);
                    }
                }
            }
            entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
            return true;
        }

        /// <summary>
        /// Action new from purchase proposal item.
        /// </summary>
        public void ActionNewFromProposalItem()
        {
            ActionNew();

            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            entity.CancelUnselectedProposalItems = false;

            guiProductsOfProposalItem guiProductsOfProposalItem = new guiProductsOfProposalItem();
            guiProductsOfProposalItem.Module = this;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //DataSet ds = objProposalItemsController.GetAllProposalItem();
            DataSet ds = objProposalItemsController.GetAllProposalItemByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.PurchaseProposal,
                                                                                        ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            if (ds.Tables[0].Rows.Count > 0)
            {
                List<APProposalItemsInfo> proposalItemList = new List<APProposalItemsInfo>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectFromDataRow(dr);
                    proposalItemList.Add(objProposalItemsInfo);
                }
                entity.ReferredProposalItemList.Invalidate(proposalItemList);
            }

            if (guiProductsOfProposalItem.ShowDialog() == DialogResult.OK)
            {
                AddCheckedItemsToPurchaseProposalItemList();
                ChangedInputType(objProposalsInfo.APProposalAPTypeCombo);
            }
            else
            {
                ActionCancel();
            }
        }

        public void ActionNewFromPurchasePlanWoodFreshLumber()
        {
            ActionNew();
            ShowPurchasePlaneByType("ArtificialBoard");
            ChangedInputType(ProductType.Lumber.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanWoodDryLumber()
        {
            ActionNew();
            ShowPurchasePlaneByType("DryLumber");
            ChangedInputType(ProductType.Lumber.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanWoodRoundWood()
        {
            ActionNew();
            ShowPurchasePlaneByType("AddMaterial");
            ChangedInputType(ProductType.Lumber.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanHW()
        {
            ActionNew();
            ShowPurchasePlaneByType(PurchasePlanType.Hardware.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanPackaging()
        {
            ActionNew();
            ShowPurchasePlaneByType(PurchasePlanType.IngredientPackaging.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanPaint()
        {
            ActionNew();
            ShowPurchasePlaneByType(PurchasePlanType.IngredientPaint.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
            APProposalItemsGridControl grid = (APProposalItemsGridControl)Controls["fld_dgcAPProposalItems"];
            if (grid != null)
            {
                grid.FormatQuantity(ProductType.IngredientPaint.ToString());
            }
        }

        public void ActionNewFromPurchasePlanInstrument()
        {
            ActionNew();
            ShowPurchasePlaneByType(ProductType.GeneralMaterial.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanOutSourcing()
        {
            ActionNew();
            ShowPurchasePlaneByType(ProductType.OutSourcing.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromAllocationProposal()
        {
            ActionNew();
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            MMAllocationProposalItemsInfo objAllocationProposalItemsInfo = new MMAllocationProposalItemsInfo();
            MMAllocationProposalsController objAllocationProposalsController = new MMAllocationProposalsController();
            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsCheck = new List<MMAllocationProposalItemsInfo>();
            List<MMAllocationProposalItemsInfo> allocationProposalItemsList = objAllocationProposalItemsController.GetQtyMissAllocationProposalItems();
            guiFind<MMAllocationProposalItemsInfo> guiFind = new guiFind<MMAllocationProposalItemsInfo>(TableName.MMAllocationProposalItemsTableName,
                                                                                                                  allocationProposalItemsList,
                                                                                                                  this, true, true,
                                                                                                                  null, new string[] { "MMAllocationProposalNo" });
            guiFind.ShowDialog();

            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<MMAllocationProposalItemsInfo> AllocationProposalItemsList = (List<MMAllocationProposalItemsInfo>)guiFind.SelectedObjects;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    objAllocationProposalItemsCheck = (List<MMAllocationProposalItemsInfo>)AllocationProposalItemsList.Where(x => x.FK_MMAllocationProposalID != guiFind.SelectedObjects[0].FK_MMAllocationProposalID).ToList();
                }
                if (objAllocationProposalItemsCheck != null && objAllocationProposalItemsCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(MaterialShipmentLocalizedResources.ChooseMulltiSaleOrderMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewFromAllocationProposal();
                }
                else
                {
                    MMAllocationProposalsInfo objAllocationProposalsInfo = (MMAllocationProposalsInfo)objAllocationProposalsController.GetObjectByID(guiFind.SelectedObjects[0].FK_MMAllocationProposalID);
                    if (objAllocationProposalsInfo != null)
                    {
                        objProposalsInfo.FK_HRDepartmentRoomID = objAllocationProposalsInfo.FK_HRDepartmentRoomID;
                        objProposalsInfo.APProposalReference = objAllocationProposalsInfo.MMAllocationProposalNo;
                        objProposalsInfo.APProposalProposedEmployeeID = objAllocationProposalsInfo.MMAllocationProposalProposedEmployeeID;
                        objProposalsInfo.FK_HRDepartmentID = objAllocationProposalsInfo.FK_HRDepartmentID;
                        //TKChinh Add PO No
                        objProposalsInfo.APProposalPONo = objAllocationProposalsInfo.MMAllocationProposalPONo;
                    }
                    if (AllocationProposalItemsList != null)
                    {
                        foreach (MMAllocationProposalItemsInfo item in AllocationProposalItemsList)
                        {
                            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
                            BOSUtil.CopyObject(item, objProposalItemsInfo);
                            objProposalItemsInfo.FK_BRBranchID = objProposalsInfo.FK_BRBranchID;
                            objProposalItemsInfo.FK_MMAllocationProposalID = item.FK_MMAllocationProposalID;
                            objProposalItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                            objProposalItemsInfo.APProposalItemProductQty = item.MMAllocationProposalItemQty - (item.MMAllocationProposalItemShippedQty + item.MMAllocationProposalItemCanceledQty);
                            objProposalItemsInfo.APProposalItemProductHeight = item.MMAllocationProposalItemHeight;
                            objProposalItemsInfo.APProposalItemProductLenght = item.MMAllocationProposalItemLength;
                            objProposalItemsInfo.APProposalItemProductLenghtMax = item.MMAllocationProposalItemLengthMax;
                            objProposalItemsInfo.APProposalItemProductWidth = item.MMAllocationProposalItemWidth;
                            objProposalItemsInfo.APProposalItemProductWidthMax = item.MMAllocationProposalItemWidthMax;
                            objProposalItemsInfo.APProposalItemProductSupplierNo = item.MMAllocationProposalItemProductSupplierNumber;
                            objProposalItemsInfo.APProposalItemCanceledQty = 0;
                            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            objProposalItemsInfo.APProposalItemProductQty = Math.Round(objProposalItemsInfo.APProposalItemProductQty, 5, MidpointRounding.AwayFromZero);
                            APProposalItemsGridControl grid = (APProposalItemsGridControl)Controls["fld_dgcAPProposalItems"];
                            if (grid != null && objProductsInfo != null)
                            {
                                grid.FormatQuantity(objProductsInfo.ICProductType);
                            }
                            entity.PurchaseProposalItemList.Add(objProposalItemsInfo);
                        }
                        entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                    }
                }
            }
            else
                ActionCancel();
        }

        public void ActionNewFromBatchProduct()
        {
            ActionNew();
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            APProposalsInfo oldProposals = (APProposalsInfo)CurrentModuleEntity.MainObject.Clone();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> ProductionNormItemList = objBatchProductProductionNormItemsController.GetProductionNormItemByBatchProduct();
            if (ProductionNormItemList.Count > 0)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in ProductionNormItemList)
                {
                    if (item.FK_MMBatchProductID == 0 || item.FK_MMProductionNormID == 0)
                    {
                        item.FK_MMBatchProductID = item.MMBatchProductID;
                        item.FK_MMProductionNormID = item.MMProductionNormID;
                    }
                }
            }
            List<MMBatchProductProductionNormItemsInfo> CheckList = new List<MMBatchProductProductionNormItemsInfo>();
            guiFind<MMBatchProductProductionNormItemsInfo> guiFind = new guiFind<MMBatchProductProductionNormItemsInfo>(TableName.MMBatchProductProductionNormItemsTableName,
                                                                                                                         ProductionNormItemList,
                                                                                                                         this,
                                                                                                                         true,
                                                                                                                         true
                                                                                                                         );
        Stamp:
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<MMBatchProductProductionNormItemsInfo> ProductionNormItemCheckList = (List<MMBatchProductProductionNormItemsInfo>)guiFind.SelectedObjects;
                foreach (MMBatchProductProductionNormItemsInfo item in guiFind.SelectedObjects)
                {
                    if (item.FK_MMBatchProductID == 0)
                    {
                        MMBatchProductProductionNormItemsInfo parentItem = (MMBatchProductProductionNormItemsInfo)objBatchProductProductionNormItemsController.GetObjectByID(item.MMBatchProductProductionNormItemParentID);
                        if (parentItem != null)
                        {
                            item.FK_MMBatchProductID = parentItem.FK_MMBatchProductID;
                        }
                    }
                }
                if (ProductionNormItemCheckList != null && ProductionNormItemCheckList.Count > 0)
                {
                    CheckList = ProductionNormItemCheckList.Where(x => x.FK_MMBatchProductID != guiFind.SelectedObjects[0].FK_MMBatchProductID).ToList();
                }
                if (CheckList != null && CheckList.Count > 0)
                {
                    MessageBox.Show(PurchaseProposalLocalizedResources.ChooseMultiBatchProductMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    //ActionCancel();
                    //ActionNewFromBatchProduct();
                    goto Stamp;
                }
                else
                {
                    MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                    MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(guiFind.SelectedObjects[0].FK_MMBatchProductItemID);
                    if (objBatchProductsInfo != null)
                    {
                        BOSUtil.CopyObject(objBatchProductsInfo, objProposalsInfo);
                        objProposalsInfo.APProposalNo = "***NEW***";
                        objProposalsInfo.FK_MMBatchProductID = objBatchProductsInfo.MMBatchProductID;
                        objProposalsInfo.APProposalDate = DateTime.Now;
                        //TKChinh Add PO No
                        objProposalsInfo.APProposalPONo = objBatchProductsInfo.MMBatchProductPONo;
                        DisplayLabelText(objProposalsInfo);
                        CurrentModuleEntity.UpdateMainObjectBindingSource();
                    }
                    foreach (MMBatchProductProductionNormItemsInfo item in guiFind.SelectedObjects)
                    {
                        if (item != null)
                        {
                            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
                            BOSUtil.CopyObject(item, objProposalItemsInfo);
                            ICProductsController objProductsController = new ICProductsController();

                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                objProposalItemsInfo.APProposalItemProductName = objProductsInfo.ICProductName;
                                objProposalItemsInfo.APProposalItemProductDesc = objProductsInfo.ICProductDesc;

                                objProposalItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                                objProposalItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                                objProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;

                            }

                            objProposalItemsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;


                            objProposalItemsInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
                            objProposalItemsInfo.FK_MMBatchProductProductionNormItemID = item.MMBatchProductProductionNormItemID;
                            objProposalItemsInfo.APProposalItemProductLenght = item.MMBatchProductProductionNormItemProductLength;
                            objProposalItemsInfo.APProposalItemProductQty = item.MMBatchProductProductionNormItemQuantity;
                            objProposalItemsInfo.APProposalItemProductionNormItemTotalPaint = item.MMBatchProductProductionNormItemPaintA + item.MMBatchProductProductionNormItemPaintB;
                            objProposalItemsInfo.APProposalItemProductionNormItemTotalBlocks = item.MMBatchProductProductionNormItemBlocks;
                            objProposalItemsInfo.APProposalItemProductSupplierNo = item.MMBatchProductProductionNormItemProductSupplierNumber;
                            objProposalItemsInfo.APProposalItemProductQty = Math.Round(objProposalItemsInfo.APProposalItemProductQty, 5, MidpointRounding.AwayFromZero);
                            APProposalItemsGridControl grid = (APProposalItemsGridControl)Controls["fld_dgcAPProposalItems"];
                            if (grid != null)
                            {
                                grid.FormatQuantity(objProductsInfo.ICProductType);
                            }
                            entity.PurchaseProposalItemList.Add(objProposalItemsInfo);
                        }

                    }
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                    UpdateTotalCost();
                }
            }
            else ActionCancel();
        }
        public void ShowPurchasePlaneByType(string planType)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            guiChoosePurchasePlanItem guiFind = new guiChoosePurchasePlanItem();
            guiFind.PlanType = planType;
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<MMPurchasePlanItemsInfo> purchasePlanItemList = guiFind.SelectedObjects;
            MMPurchasePlanItemsInfo objPurchasePlanItemsInfo = purchasePlanItemList.FirstOrDefault();
            mainobject.APProposalAPTypeCombo = ProposalAPType.Material.ToString(); ;
            List<APProposalItemsInfo> proposalItemsList = new List<APProposalItemsInfo>();
            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            purchasePlanItemList.ForEach(o =>
            {
                objProposalItemsInfo = ToProposalItems(o);
                entity.SetProductPriceByProductUnitPrice(objProposalItemsInfo);
                proposalItemsList.Add(objProposalItemsInfo);
            });
            entity.PurchaseProposalItemList.Invalidate(proposalItemsList);
        }

        public APProposalItemsInfo ToProposalItems(MMPurchasePlanItemsInfo item)
        {
            return new APProposalItemsInfo()
            {
                FK_ICProductID = item.FK_ICProductID,
                FK_MMBatchProductID = item.FK_MMBatchProductID,
                FK_MMBatchProductItemID = item.FK_MMBatchProductItemID,
                FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID,
                FK_ARSaleOrderID = item.FK_ARSaleOrderID,
                FK_ICMeasureUnitID = item.FK_ICMeasureUnitID,
                FK_MMPurchasePlanID = item.FK_MMPurchasePlanID,
                FK_MMPurchasePlanItemID = item.MMPurchasePlanItemID,
                APProposalItemProductName = item.MMPurchasePlanItemProductName,
                APProposalItemProductDesc = item.MMPurchasePlanItemProductDesc,
                APProposalItemProductHeight = item.MMPurchasePlanItemProductHeight,
                APProposalItemProductWidth = item.MMPurchasePlanItemProductWidth,
                APProposalItemProductLenght = item.MMPurchasePlanItemProductLength,
                APProposalItemProductQty = item.MMPurchasePlanItemQuantity,
                APProposalItemProductType = item.MMPurchasePlanType,
                APProposalItemProductFactor = item.MMPurchasePlanItemProductFactor,
                APProposalItemProductExchangeQty = item.MMPurchasePlanItemQuantity * item.MMPurchasePlanItemProductFactor,
                APPriority = item.MMPriority,
                FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeWoodTypeID,
                APProposalItemProductSupplierNo = item.MMPurchasePlanItemProductSupplierNumber,
                APProposalItemNeedTime = item.MMPurchasePlanItemNeededTime
            };
        }

        public bool CheckSelectedProposalItems()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            IList<APProposalItemsInfo> proposalItems = entity.ReferredProposalItemList.Where(proposalItem => proposalItem.Selected == true).ToList();
            if (proposalItems.Count == 0)
            {
                MessageBox.Show(PurchaseProposalLocalizedResources.ChooseProposalItemsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public override int ActionSave()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo proposal = (APProposalsInfo)entity.MainObject;
            entity.PurchaseProposalItemList.EndCurrentEdit();
            if (string.IsNullOrEmpty(proposal.APProposalAPTypeCombo))
            {
                MessageBox.Show("Vui lòng chọn loại hàng hóa", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (entity.ReferredProposalItemList.Count > 0)
            {
                int unselectedCount = 0;
                foreach (APProposalItemsInfo objProposalItemsInfo in entity.ReferredProposalItemList)
                {
                    if (!objProposalItemsInfo.Selected)
                    {
                        unselectedCount++;
                    }
                }

                if (unselectedCount > 0)
                {
                    if (MessageBox.Show(PurchaseProposalLocalizedResources.ConfirmCancelUnselectedProposalItemsMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        entity.CancelUnselectedProposalItems = true;
                    }
                }
            }
            foreach (APProposalItemsInfo objProposalItemsInfo in entity.PurchaseProposalItemList)
            {
                string productName = CheckProductActive(objProposalItemsInfo);
                if (productName != string.Empty)
                {
                    if (MessageBox.Show(string.Format(PurchaseProposalLocalizedResources.ProductActiveCheckFalseMessage, productName),
                                CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return 0;
                    }
                }
            }
            if (entity.PurchaseProposalItemList.Count() == 0)
            {
                MessageBox.Show(PurchaseProposalLocalizedResources.ChoseProduct, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            //if (!IsValidProposalListItem())
            //    return 0;

            return base.ActionSave();
        }

        public bool IsValidProposalListItem()
        {
            bool isValid = true;
            if (!IsValidProposalFromPurchasePlan())
                return false;

            if (!CheckProposalOutSourcingProductQty())
                return false;

            if (!CheckProposalFromBatchProductProductQty())
                return false;

            return isValid;
        }

        public bool CheckProposalFromBatchProductProductQty()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainObject = (APProposalsInfo)entity.MainObject;
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            MMBatchProductProductionNormItemsController pnisController = new MMBatchProductProductionNormItemsController();
            List<APProposalItemsInfo> checkProposalList = entity.PurchaseProposalItemList.Where(o => o.FK_MMBatchProductProductionNormItemID > 0).ToList();
            if (checkProposalList.Count() == 0)
                return true;

            string pniRef = string.Join(",", checkProposalList.Select(o => o.FK_MMBatchProductProductionNormItemID.ToString()).Distinct().ToArray());
            string purchaseProposalItemRef = string.Join(",", checkProposalList.Select(o => o.APProposalItemID.ToString()).Distinct().ToArray());
            string messageError = string.Empty;
            List<MMBatchProductProductionNormItemsInfo> purchaseItemList = pnisController.GetRemainQtyForPurchaseProsalRef(pniRef, mainObject.APProposalAPTypeCombo, purchaseProposalItemRef);

            decimal sumProposal = 0;
            purchaseItemList.ForEach(o =>
            {
                sumProposal = checkProposalList.Where(pro => pro.FK_MMBatchProductProductionNormItemID == o.MMBatchProductProductionNormItemID
                                                        && pro.FK_ICProductID == o.FK_ICProductID)
                                               .Sum(pro => pro.APProposalItemProductExchangeQty);
                if (o.MMBatchProductProductionNormItemRemainQty - sumProposal >= 0)
                    return;

                messageError += string.Format("Sản phẩm {0} có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể để nghị là {1}", o.MMBatchProductProductionNormItemProductName, o.MMBatchProductProductionNormItemRemainQty.ToString("n3"));
                messageError += Environment.NewLine;
            });
            if (string.IsNullOrWhiteSpace(messageError))
                return true;

            messageError += "Vui long kiểm tra lại!";
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool CheckProposalOutSourcingProductQty()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainobject = (APProposalsInfo)entity.MainObject;
            List<APProposalItemsInfo> checkProposalList = entity.PurchaseProposalItemList.Where(o => o.FK_MMBatchProductItemOutSourcingID > 0).ToList();
            if (checkProposalList.Count() == 0)
                return true;

            string outSourcingRef = string.Join(",", checkProposalList.Select(o => o.FK_MMBatchProductItemOutSourcingID).ToArray());
            string proposalItemRef = string.Join(",", checkProposalList.Select(o => o.APProposalItemID).ToArray());
            MMBatchProductItemOutSourcingsController controller = new MMBatchProductItemOutSourcingsController();
            List<MMBatchProductItemOutSourcingsInfo> remainItemList = controller.GetBPRemainQtyForPurchaseProposal(outSourcingRef, proposalItemRef);
            MMBatchProductItemOutSourcingsInfo objBatchProductItemOutSourcingsInfo = new MMBatchProductItemOutSourcingsInfo();
            string messageError = string.Empty;
            string keyPair = string.Empty;

            Dictionary<string, decimal> operationCompare = new Dictionary<string, decimal>();
            Dictionary<string, decimal> operationSourcingCompare = new Dictionary<string, decimal>();
            Dictionary<string, decimal> operationProposalCompare = new Dictionary<string, decimal>();
            List<int> operaionSourcingList = new List<int>();
            remainItemList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.MMBatchProductItemOutSourcingOperation))
                {
                    keyPair = o.MMBatchProductItemOutSourcingID + ";" + 0;
                    if (operationCompare.ContainsKey(keyPair))
                        operationCompare[keyPair] = operationCompare[keyPair] + o.MMBatchProductItemOutSourcingProductQty;
                    else
                        operationCompare.Add(keyPair, o.MMBatchProductItemOutSourcingProductQty);
                }
                else
                {
                    operaionSourcingList = o.MMBatchProductItemOutSourcingOperation.Split(',').Select(oper => Int32.Parse(oper)).ToList();
                    operaionSourcingList.ForEach(oper =>
                    {
                        keyPair = o.MMBatchProductItemOutSourcingID + ";" + oper;
                        if (operationCompare.ContainsKey(keyPair))
                            operationCompare[keyPair] = operationCompare[keyPair] + o.MMBatchProductItemOutSourcingProductQty;
                        else
                            operationCompare.Add(keyPair, o.MMBatchProductItemOutSourcingProductQty);
                    });
                }
                if (string.IsNullOrWhiteSpace(o.APProposalItemOperation))
                {
                    keyPair = o.MMBatchProductItemOutSourcingID + ";" + 0;
                    if (operationSourcingCompare.ContainsKey(keyPair))
                        operationSourcingCompare[keyPair] = operationSourcingCompare[keyPair] + o.APProposalItemProductExchangeQty;
                    else
                        operationSourcingCompare.Add(keyPair, o.APProposalItemProductExchangeQty);
                }
                else
                {
                    operaionSourcingList = o.APProposalItemOperation.Split(',').Select(oper => Int32.Parse(oper)).ToList();
                    operaionSourcingList.ForEach(oper =>
                    {
                        keyPair = o.MMBatchProductItemOutSourcingID + ";" + oper;
                        if (operationSourcingCompare.ContainsKey(keyPair))
                            operationSourcingCompare[keyPair] = operationSourcingCompare[keyPair] + o.APProposalItemProductExchangeQty;
                        else
                            operationSourcingCompare.Add(keyPair, o.APProposalItemProductExchangeQty);
                    });
                }
            });
            checkProposalList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.APProposalItemOperation))
                {
                    keyPair = o.FK_MMBatchProductItemOutSourcingID + ";" + 0;
                    if (operationProposalCompare.ContainsKey(keyPair))
                        operationProposalCompare[keyPair] = operationProposalCompare[keyPair] + o.APProposalItemProductExchangeQty;
                    else
                        operationProposalCompare.Add(keyPair, o.APProposalItemProductExchangeQty);
                }
                else
                {
                    operaionSourcingList = o.APProposalItemOperation.Split(',').Select(oper => Int32.Parse(oper)).ToList();
                    operaionSourcingList.ForEach(oper =>
                    {
                        keyPair = o.FK_MMBatchProductItemOutSourcingID + ";" + oper;
                        if (operationProposalCompare.ContainsKey(keyPair))
                            operationProposalCompare[keyPair] = operationProposalCompare[keyPair] + o.APProposalItemProductExchangeQty;
                        else
                            operationProposalCompare.Add(keyPair, o.APProposalItemProductExchangeQty);
                    });
                }
            });
            decimal sumProposal = 0;
            decimal remainQty = 0;
            decimal operationQty = 0;
            int outsourcingItemID = 0;
            int operationID = 0;
            foreach (KeyValuePair<string, decimal> dic in operationProposalCompare)
            {
                outsourcingItemID = 0;
                Int32.TryParse(dic.Key.Split(';').First(), out outsourcingItemID);
                operationID = 0;
                Int32.TryParse(dic.Key.Split(';').Last(), out operationID);
                if (outsourcingItemID == 0)
                    continue;

                objBatchProductItemOutSourcingsInfo = remainItemList.Where(o => o.MMBatchProductItemOutSourcingID == outsourcingItemID).FirstOrDefault();
                if (objBatchProductItemOutSourcingsInfo == null)
                    continue;

                operationQty = 0;
                if (operationCompare.ContainsKey(dic.Key))
                {
                    operationQty = operationCompare[dic.Key];
                    sumProposal = 0;
                    operationSourcingCompare.TryGetValue(dic.Key, out sumProposal);
                    remainQty = operationQty - sumProposal;
                    if (remainQty - dic.Value >= 0)
                        continue;

                    if (operationID == 0)
                        messageError += string.Format("Sản phẩm {0} có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể để nghị là {1}", objBatchProductItemOutSourcingsInfo.MMBatchProductItemOutSourcingProductName, remainQty.ToString("n5"));
                    else
                        messageError += string.Format("Sản phẩm {0}, công đoạn {1} có số lượng lớn hơn số lượng đã kế hoạch. Số lượng có thể đề nghị: {2}", objBatchProductItemOutSourcingsInfo.MMBatchProductItemOutSourcingProductName, BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", operationID, "MMOperationName"), remainQty.ToString("n5"));

                    messageError += Environment.NewLine;

                }
                else
                {
                    messageError += string.Format("Sản phẩm {0} có công đoạn khác với kế hoạch.", objBatchProductItemOutSourcingsInfo.MMBatchProductItemOutSourcingProductName);
                    messageError += Environment.NewLine;
                    continue;
                }
            }
            if (string.IsNullOrWhiteSpace(messageError))
                return true;

            messageError += "Vui lòng kiểm tra lại!";
            MessageBox.Show(messageError, BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool IsValidProposalFromPurchasePlan()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainObject = (APProposalsInfo)entity.MainObject;
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            List<APProposalItemsInfo> checkProposalList = entity.PurchaseProposalItemList.Where(o => o.FK_MMPurchasePlanItemID > 0).ToList();
            if (checkProposalList.Count() == 0)
                return true;

            string purchasePlanItemRef = string.Join(",", checkProposalList.Select(o => o.FK_MMPurchasePlanItemID.ToString()).Distinct().ToArray());
            string purchaseProposalItemRef = string.Join(",", checkProposalList.Select(o => o.APProposalItemID.ToString()).Distinct().ToArray());
            string messageError = string.Empty;
            List<MMPurchasePlanItemsInfo> purchaseItemList = objPurchasePlanItemsController.GetRemainQtyForPurchaseProsal(purchasePlanItemRef, purchaseProposalItemRef);
            decimal sumProposal = 0;
            purchaseItemList.ForEach(o =>
            {
                sumProposal = checkProposalList.Where(pro => pro.FK_MMPurchasePlanItemID == o.MMPurchasePlanItemID).Sum(pro => pro.APProposalItemProductExchangeQty);
                if (o.MMPurchasePlanItemRemainQty - sumProposal >= 0)
                    return;

                messageError += string.Format("Sản phẩm {0} có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể để nghị là {1}", o.MMPurchasePlanItemProductName, o.MMPurchasePlanItemRemainQty.ToString("n5"));
                messageError += Environment.NewLine;
            });

            if (string.IsNullOrWhiteSpace(messageError))
                return true;

            messageError += "Vui long kiểm tra lại!";
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public string CheckProductActive(APProposalItemsInfo objProposalItemsInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            if (objProposalItemsInfo.FK_ICProductID > 0)
            {
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(objProposalItemsInfo.FK_ICProductID);
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

        public override void ActionDuplicate()
        {
            base.ActionDuplicate();

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo proposal = (APProposalsInfo)entity.MainObject;
            proposal.APPurchaseProposalStatus = PurchaseProposalStatus.New.ToString();
            proposal.APProposalApproveStatus = ApproveStatus.NeedApprove;
            entity.PurchaseProposalItemList.ForEach(o=> {
                o.APProposalItemCanceledQty = 0;
            });
            entity.UpdateMainObjectBindingSource();

            entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Add items to be checked to purchase proposal item list
        /// </summary>
        public void AddCheckedItemsToPurchaseProposalItemList()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            IList<APProposalItemsInfo> proposalItems = entity.ReferredProposalItemList.Where(proposalItem => proposalItem.Selected == true).ToList();
            if (proposalItems.Count > 0)
            {
                entity.PurchaseProposalItemList.Invalidate(proposalItems);
                foreach (APProposalItemsInfo objProposalItemsInfo in entity.PurchaseProposalItemList)
                {
                    objProposalItemsInfo.APProposalItemID = 0;
                    // objProposalItemsInfo.FK_MMBatchProductID
                }
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Check all proposal item
        /// </summary>
        /// <param name="isChecked">Check all or not</param>
        public void CheckAllProposalItems(bool isChecked)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            foreach (APProposalItemsInfo objProposalItemsInfo in entity.ReferredProposalItemList)
            {
                objProposalItemsInfo.Selected = isChecked;
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
                PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                if (entity.PurchaseProposalItemList.CurrentIndex >= 0)
                {
                    APProposalItemsInfo objProposalItemsInfo = entity.PurchaseProposalItemList[entity.PurchaseProposalItemList.CurrentIndex];
                    //Xóa chi tiết
                    entity.PurchaseProposalItemList.RemoveSelectedRowObjectFromList();
                    //Xóa tổng
                    APProposalItemTotalsInfo objProposalItemTotalsInfo = entity.PurchaseProposalItemTotalList.Where(x => x.FK_ICProductID == objProposalItemsInfo.FK_ICProductID && x.FK_MMPurchasePlanID == objProposalItemsInfo.FK_MMPurchasePlanID).FirstOrDefault();
                    if (objProposalItemTotalsInfo != null)
                    {
                        objProposalItemTotalsInfo.APProposalItemTotalProductQty -= objProposalItemsInfo.APProposalItemProductQty;
                        if (objProposalItemTotalsInfo.APProposalItemTotalProductQty > 0)
                        {
                            BOSDbUtil dbUtil = new BOSDbUtil();
                            dbUtil.SetPropertyValue(entity.PurchaseProposalItemTotalList, "APProposalItemTotalProductQty", objProposalItemTotalsInfo.APProposalItemTotalProductQty);
                        }
                        else
                        {
                            entity.PurchaseProposalItemTotalList.Remove(objProposalItemTotalsInfo);
                        }
                    }
                    entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
                }
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
                PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                entity.UpdateTotalCost();
            }
        }
        #endregion

        #region Override Print
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                APProposalsInfo proposal = (APProposalsInfo)entity.MainObject;
                if (proposal.APProposalAPTypeCombo == ProposalAPType.ArtificialBoard.ToString()
                   || proposal.APProposalAPTypeCombo == ProposalAPType.Verneer.ToString())
                {
                    RPProposalWood report = new RPProposalWood();
                    InitPurchaseProposalReport(report);
                    guiReportPreview reviewer = new guiReportPreview(report);
                    reviewer.Show();
                }
                else if (proposal.APProposalAPTypeCombo == ProposalAPType.Lumber.ToString()
                   || proposal.APProposalAPTypeCombo == ProposalAPType.Roundwood.ToString())
                {
                    RPProposalWoodLBRW report = new RPProposalWoodLBRW();
                    InitPurchaseProposalReport(report);
                    guiReportPreview reviewer = new guiReportPreview(report);
                    reviewer.Show();
                }
                else
                {
                    RPProposal report = new RPProposal();
                    InitPurchaseProposalReport(report);
                    guiReportPreview reviewer = new guiReportPreview(report);
                    reviewer.Show();
                }
            }
        }

        private void InitPurchaseProposalReport(XtraReport report)
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

            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            ADReportsController objReportsController = new ADReportsController();
            List<APProposalItemsInfo> list = (List<APProposalItemsInfo>)objReportsController.GetProposalItemForPrint(objProposalsInfo.APProposalID);
            if (objProposalsInfo.APProposalAPTypeCombo == ProposalAPType.ArtificialBoard.ToString()
                   || objProposalsInfo.APProposalAPTypeCombo == ProposalAPType.Verneer.ToString())
            {
                foreach (APProposalItemsInfo item in list)
                {
                    item.ICMeasureUnitName = "Tấm";
                }
            }
            else if (objProposalsInfo.APProposalAPTypeCombo == ProposalAPType.Lumber.ToString()
                   || objProposalsInfo.APProposalAPTypeCombo == ProposalAPType.Roundwood.ToString())
            {
                foreach (APProposalItemsInfo item in list)
                {
                    item.ICMeasureUnitName = "m3";
                }
            }
            report.DataSource = list;
            if (objProposalsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["lblDate"];
                if (label != null)
                {
                    label.Text = "Ngày " + objProposalsInfo.APProposalDate.ToString("dd")
                                + " tháng " + objProposalsInfo.APProposalDate.ToString("MM")
                                + " năm " + objProposalsInfo.APProposalDate.ToString("yyyy");
                }
            }
            //report.DataMember = BOSCommon.Constants.Report.DevProposalItemReportName;
        }
        #endregion
        /// <summary>
        /// Approve all items of the proposal
        /// </summary>
        public void ApproveProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                if (entity.ApproveProposal())
                {
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                    entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
                    InvalidateToolbar();
                }

            }
        }

        public void ConfirmProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                if (entity.ConfirmProposal())
                {
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                    InvalidateToolbar();
                }

            }
        }

        //NHAnh[ADD][27/01/2016][CancelApprove][START]
        /// <summary>
        /// CancelApprove all items of the proposal
        /// </summary>
        public void CancelApproveProposal()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0 && objProposalsInfo.APPurchaseProposalStatus == PurchaseOrderStatus.Approved.ToString())
            {
                List<APPurchaseOrderItemsInfo> purchaseOrderItemList = new List<APPurchaseOrderItemsInfo>();
                APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                //Kiểm tra đơn mua hàng
                purchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByProposalID(objProposalsInfo.APProposalID);
                if (purchaseOrderItemList != null && purchaseOrderItemList.Count > 0)
                {
                    List<string> purchaseOrderNoList = purchaseOrderItemList.Select(x => Convert.ToString(x.APPurchaseOrderNo)).Distinct().ToList();
                    string listProposalID = string.Join(Environment.NewLine + "  * ", purchaseOrderNoList.ToArray());
                    MessageBox.Show(PurchaseProposalLocalizedResources.PleaseCancelTheFollowingPurchasesBeforeCanceling + Environment.NewLine + "  * " + listProposalID, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra số lượng đã mua
                List<APProposalItemsInfo> proposalItemList = new List<APProposalItemsInfo>();
                proposalItemList = entity.PurchaseProposalItemList.Where(x => x.APProposalItemPurchaseOrderQty > 0).ToList();
                if (proposalItemList != null && proposalItemList.Count > 0)
                {
                    List<string> productDesc = proposalItemList.Select(x => Convert.ToString(x.APProposalItemProductDesc + " : " + Math.Round(x.APProposalItemPurchaseOrderQty, 5, MidpointRounding.AwayFromZero))).ToList();
                    string listProposalID = string.Join(Environment.NewLine + "  * ", productDesc.ToArray());
                    MessageBox.Show(PurchaseProposalLocalizedResources.TheQuantitiesPurchasedInTheProductsBelowAreGreaterThan0AndCanNotBeCanceled + Environment.NewLine + "  * " + listProposalID, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (entity.UpdateValueCancelApproveProposal())
                {
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                    entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
                    InvalidateToolbar();
                }
            }
        }
        //NHAnh[ADD][27/01/2016][CancelApprove][END]

        /// <summary>
        /// Discard all items of the prosal
        /// </summary>
        public void DiscardProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                //[NKVung]  [Discard Error Message]   [START]
                APProposalsInfo proposal = (APProposalsInfo)entity.MainObject;
                List<APPurchaseOrderItemsInfo> PurchaseOrderItemList = new List<APPurchaseOrderItemsInfo>();
                APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                PurchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByProposalIDAndPurchaseOrderStatus(proposal.APProposalID, PurchaseOrderStatus.New.ToString());
                if (PurchaseOrderItemList.Count > 0)
                {
                    MessageBox.Show(PurchaseProposalLocalizedResources.DiscardErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else if (entity.DiscardProposal())
                {
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                    entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
                    InvalidateToolbar();

                }
                else
                {
                    MessageBox.Show(PurchaseProposalLocalizedResources.CannotDiscardPurchasedOrderItem,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                //[NKVung]  [Discard Error Message]   [END]
            }
        }

        /// <summary>
        /// Discard a proposal item
        /// </summary>
        /// <param name="item">Given item</param>
        public void DiscardProposalItem(APProposalItemsInfo item)
        {
            if (item.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Approved.ToString())
            {

                List<APPurchaseOrderItemsInfo> PurchaseOrderItemList = new List<APPurchaseOrderItemsInfo>();
                APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                PurchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByProposalItemIDAndPurchaseOrderStatus(item.APProposalItemID, PurchaseOrderStatus.New.ToString());
                if (PurchaseOrderItemList.Count > 0)
                {
                    MessageBox.Show(PurchaseProposalLocalizedResources.DiscardItemErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                }
                else if (item.APProposalItemProductQty > (item.APProposalItemPurchaseOrderQty + item.APProposalItemCanceledQty))
                {
                    PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                    APProposalItemsController objProposalItemsController = new APProposalItemsController();
                    item.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Canceled.ToString();
                    item.APProposalItemCanceledQty = item.APProposalItemProductQty - item.APProposalItemPurchaseOrderQty;
                    item.APProposalItemCanceledWoodQty = item.APProposalItemWoodQty - item.APProposalItemPurchaseOrderWoodQty;
                    entity.UpdateReferencePurchasePlan(item);
                    objProposalItemsController.UpdateObject(item);
                    entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
                }
                else
                    MessageBox.Show(PurchaseProposalLocalizedResources.CannotDiscardPurchasedOrderItem,
                               CommonLocalizedResources.MessageBoxDefaultCaption,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            else if (item.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Purchased.ToString())
            {
                MessageBox.Show(PurchaseProposalLocalizedResources.CannotDiscardPurchasedItem,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (item.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Canceled.ToString())
            {
                MessageBox.Show(PurchaseProposalLocalizedResources.CancelProposalitem,
                                               CommonLocalizedResources.MessageBoxDefaultCaption,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(PurchaseProposalLocalizedResources.CannotDiscardDisapprovedItem,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void ApproveProposalItem(APProposalItemsInfo item)
        {
            if (item.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.New.ToString() || item.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Confirmed.ToString())
            {
                APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
                PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
                item.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Approved.ToString();
                if (entity.PurchaseProposalItemList.Where(p => p.APPurchaseProposalItemStatus != PurchaseProposalItemStatus.Approved.ToString()).Count() == 0)
                {
                    objProposalsInfo.APPurchaseProposalStatus = PurchaseProposalItemStatus.Approved.ToString();
                }
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            }
            else if (item.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Canceled.ToString())
            {
                MessageBox.Show(PurchaseProposalLocalizedResources.CannotApprovedCanceledItem,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (item.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Purchased.ToString())
            {
                MessageBox.Show(PurchaseProposalLocalizedResources.CannotApprovedPurchasedItem,
                                               CommonLocalizedResources.MessageBoxDefaultCaption,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
            }
        }

        #region Data Exchange
        public override void ActionTransfer(string defaultBranchConfigKey)
        {
            base.ActionTransfer(ConfigValueKey.DataExchangeDefaultBranchPurchaseProposal);
        }

        protected override bool TransferData(BRBranchsInfo objBranchsInfo)
        {
            APProposalsController objProposalsController = new APProposalsController();
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            BOSList<APProposalItemsInfo> proposalItems = new BOSList<APProposalItemsInfo>(null, string.Empty, TableName.APProposalItemsTableName);
            DataSet ds = objProposalItemsController.GetAllDataByForeignColumn("FK_APProposalID", objProposalsInfo.APProposalID);
            proposalItems.Invalidate(ds);

            bool isCompleted = false;

            APProposalsInfo branchProposal = (APProposalsInfo)objProposalsController.GetObjectByNo(objProposalsInfo.APProposalNo);
            int branchProposalID;
            if (branchProposal != null)
            {
                branchProposalID = branchProposal.APProposalID;
                branchProposal = (APProposalsInfo)objProposalsInfo.Clone();
                branchProposal.APProposalID = branchProposalID;
                branchProposal.APProposalTransferredDate = BOSApp.GetCurrentServerDate();
                branchProposalID = objProposalsController.UpdateObject(branchProposal);
            }
            else
            {
                branchProposal = (APProposalsInfo)objProposalsInfo.Clone();
                branchProposal.AAUpdatedDate = DateTime.MaxValue;
                branchProposalID = objProposalsController.CreateObject(branchProposal);
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
                objProposalsInfo.IsTransferred = true;
                objProposalsInfo.APProposalTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objProposalsController.UpdateObject(objProposalsInfo);
            }


            return isCompleted;
        }

        private void TransferProposalItemsToBranch(BOSList<APProposalItemsInfo> proposalItems, int branchProposalID)
        {
            APProposalItemsController objProposalItemsController = new APProposalItemsController();

            objProposalItemsController.DeleteByForeignColumn("FK_APProposalID", branchProposalID);

            foreach (APProposalItemsInfo objProposalItemsInfo in proposalItems)
            {
                APProposalItemsInfo objBranchProposalItemInfo = (APProposalItemsInfo)objProposalItemsInfo.Clone();
                objBranchProposalItemInfo.FK_APProposalID = branchProposalID;
                objProposalItemsController.CreateObject(objBranchProposalItemInfo);
            }
        }
        #endregion

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

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            if (entity.PurchaseProposalItemList != null && entity.PurchaseProposalItemList.Count > 0)
            {

                MMOverallInsideDimensionConfigsController objOverallInsideDimensionConfigsController = new MMOverallInsideDimensionConfigsController();
                List<MMOverallInsideDimensionConfigsInfo> overallInsideDimensionConfigsList = new List<MMOverallInsideDimensionConfigsInfo>();
                MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo = new MMOverallInsideDimensionConfigsInfo();
                foreach (APProposalItemsInfo item in entity.PurchaseProposalItemList)
                {
                    #region dimension

                    item.APProposalItemOverallDemensionHeight = 0;
                    item.APProposalItemOverallDemensionWitdh = 0;
                    item.APProposalItemOverallDemensionLength = 0;
                    if (item.FK_ICProdAttPackingMaterialSpecialityID > 0)
                    {
                        #region Height
                        overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(item.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Height.ToString(), item.FK_ICProductGroupID);
                        objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                        if (objOverallInsideDimensionConfigsInfo != null)
                        {
                            item.APProposalItemOverallDemensionHeight = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                               item.APProposalItemInsideDemensionHeight);
                        }
                        else
                            item.APProposalItemOverallDemensionHeight = 0;
                        #endregion
                        #region Width
                        overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(item.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Width.ToString(), item.FK_ICProductGroupID);
                        objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                        if (objOverallInsideDimensionConfigsInfo != null)
                        {
                            item.APProposalItemOverallDemensionWitdh = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                               item.APProposalItemInsideDemensionWitdh);
                        }
                        else
                            item.APProposalItemOverallDemensionWitdh = 0;
                        #endregion
                        #region Length
                        overallInsideDimensionConfigsList
                            = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(item.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Length.ToString(), item.FK_ICProductGroupID);
                        objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                        if (objOverallInsideDimensionConfigsInfo != null)
                        {
                            item.APProposalItemOverallDemensionLength = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                               item.APProposalItemInsideDemensionLength);
                        }
                        else
                            item.APProposalItemOverallDemensionLength = 0;
                        #endregion
                    }

                    #endregion

                }
            }


            entity.PurchaseProposalItemList.GridControl.RefreshDataSource();


        }

        public void ChangeNeedTime(DateTime needTime)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;

            if (Toolbar.IsNullOrNoneAction())
                return;

            DialogResult rs = MessageBox.Show(PurchaseProposalLocalizedResources.ConfirmChangeNeedTimeMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            entity.PurchaseProposalItemList.ForEach(o =>
            {
                o.APProposalItemNeedTime = needTime;
            });

            if (entity.PurchaseProposalItemList.GridControl != null)
            {
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            }
        }

        public void ChangeNeedToTime(DateTime needToTime)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;

            if (Toolbar.IsNullOrNoneAction())
                return;

            DialogResult rs = MessageBox.Show(PurchaseProposalLocalizedResources.ConfirmChangeNeedTimeMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            entity.PurchaseProposalItemList.ForEach(o =>
            {
                o.APProposalItemNeedToTime = needToTime;
            });

            if (entity.PurchaseProposalItemList.GridControl != null)
            {
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            }
        }

        public void ChangeItemAPProposalItemTotalProductQty()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            BOSDbUtil dbUtil = new BOSDbUtil();
            int index = entity.PurchaseProposalItemList.CurrentIndex;
            if (index >= 0)
            {
                APProposalItemsInfo objProposalItemsInfo = entity.PurchaseProposalItemList[index];
                List<APProposalItemsInfo> proposalItemsList = entity.PurchaseProposalItemList.Where(x => x.FK_MMPurchasePlanID == objProposalItemsInfo.FK_MMPurchasePlanID && x.FK_ICProductID == objProposalItemsInfo.FK_ICProductID).ToList();
                if (proposalItemsList != null && proposalItemsList.Count > 0)
                {
                    decimal productQty = proposalItemsList.Sum(x => x.APProposalItemProductQty);
                    if (entity.PurchaseProposalItemTotalList.Count > 0)
                    {
                        APProposalItemTotalsInfo objProposalItemTotalsInfo = entity.PurchaseProposalItemTotalList.Where(x => x.FK_MMPurchasePlanID == objProposalItemsInfo.FK_MMPurchasePlanID && x.FK_ICProductID == objProposalItemsInfo.FK_ICProductID).FirstOrDefault();
                        if (objProposalItemTotalsInfo != null)
                        {
                            objProposalItemTotalsInfo.APProposalItemTotalProductQty = productQty;
                            dbUtil.SetPropertyValue(entity.PurchaseProposalItemTotalList, "APProposalItemTotalProductQty", objProposalItemTotalsInfo.APProposalItemTotalProductQty);
                            entity.PurchaseProposalItemTotalList.GridControl.RefreshDataSource();
                        }
                    }
                }
            }
        }

        public void NewFromSaleOrder()
        {
            ActionNew();
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            //objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            //ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            //List<ARSaleOrderItemsInfo> saleOrderItemList = ShowFindSaleOrder();

            guiProductsOfSaleOrder guiProductsOfSaleOrder = new guiProductsOfSaleOrder();
            guiProductsOfSaleOrder.Module = this;
            guiProductsOfSaleOrder.ShowDialog();

            if (guiProductsOfSaleOrder.DialogResult != DialogResult.OK)
            {
                ActionCancel();
                return;
            }

            List<ARSaleOrderItemsInfo> results = guiProductsOfSaleOrder.SelectedObjects.ToList();
            if (results.Count <= 0)
            {
                ActionCancel();
                return;
            }
            GenarateProposalItem(results);
            objProposalsInfo.MMBatchProductSOName = string.Join(",", results.Select(o => o.ARSaleOrderName).Distinct().ToArray());
            APProposalItemsGridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionNewFromProductSpecific(List<MMProductionNormItemsInfo> listItem, ARProductionPlanningsInfo objARProductionPlannings)
        {
            ActionNew();
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainObject = (APProposalsInfo)entity.MainObject;
            mainObject.APPurchaseProposalType = "Specific";
            mainObject.APProposalReference = objARProductionPlannings.ARProductionPlanningNo;
            mainObject.FK_ARCustomerID = objARProductionPlannings.FK_ARCustomerID;
            mainObject.APProposalAPTypeCombo = listItem[0].MMProductionNormItemGroup;
            foreach (MMProductionNormItemsInfo item in listItem)
            {
                APProposalItemsInfo objAPProposalItemsInfo = new APProposalItemsInfo();
                entity.SetValuesAfterValidateProduct(item.FK_ICProductID, objAPProposalItemsInfo);
                objAPProposalItemsInfo.APProposalItemProductQty = item.MMProductionNormItemQuantity;
                objAPProposalItemsInfo.APProposalItemTotalCost = objAPProposalItemsInfo.APProposalItemProductQty * objAPProposalItemsInfo.APProposalItemProductUnitCost;
                objAPProposalItemsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                objAPProposalItemsInfo.APProposalItemNeedTime = item.NgayHangVe;
                objAPProposalItemsInfo.APProposalItemSaleOrderNo = item.ARSaleOrderNo;
                objAPProposalItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
                objAPProposalItemsInfo.FK_ARSaleOrderItemID = item.FK_ARSaleOrderItemID;
                entity.PurchaseProposalItemList.Add(objAPProposalItemsInfo);
            }
            List<string> listSaleOrderNo = entity.PurchaseProposalItemList.Select(s => s.APProposalItemSaleOrderNo).Distinct().ToList();
            string messReferenceNo = string.Empty;
            foreach (string item in listSaleOrderNo)
            {
                messReferenceNo += item;
                if (item != listSaleOrderNo[listSaleOrderNo.Count - 1])
                    messReferenceNo += ", ";
            }
            mainObject.APProposalDesc = messReferenceNo;
            UpdateTotalCost();
            entity.PurchaseProposalItemList.GridControl.RefreshDataSource();

        }

        private void GenarateProposalItem(List<ARSaleOrderItemsInfo> saleOrderItems)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            List<string> arSaleOrderNoList = new List<string>();
            string strSaleOrderSaleAgreement = string.Empty;
            saleOrderItems.Where(s => s.FK_ICProductID > 0).ToList().ForEach(i =>
            {
                ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
                List<ARSOItemComponentsInfo> components = objSOItemComponentsController.GetSOItemComponentListBySOItemID(i.ARSaleOrderItemID);
                if (components.Count > 0)
                {
                    AddItemComponentToPurchaseProposalItemsList(i, components);
                }
                else
                {
                    APProposalItemsInfo item = new APProposalItemsInfo();
                    item.FK_ICMeasureUnitID = i.FK_ICMeasureUnitID;
                    item.APProposalItemProductFactor = i.ARSaleOrderItemProductFactor;
                    item.APProposalItemProductQty = i.ARSaleOrderItemProductQty;
                    entity.SetValuesAfterValidateProduct(i.FK_ICProductID, item);
                    item.APProposalItemNeedTime = objProposalsInfo.APProposalNeedTime;
                    item.APProposalItemNeedToTime = objProposalsInfo.APProposalNeedToTime;
                    item.FK_ARSaleOrderItemID = i.ARSaleOrderItemID;
                    item.FK_ARSaleOrderID = i.FK_ARSaleOrderID;
                    item.FK_ACObjectID = i.FK_ACObjectID;
                    item.APObjectType = i.ARObjectType;
                    item.ACObjectName = i.ACObjectName;
                    item.MMBatchProductSOName = i.ARSaleOrderName;
                    entity.PurchaseProposalItemList.Add(item);
                }
                arSaleOrderNoList.Add(i.ARSaleOrderNo);
            });
            arSaleOrderNoList = arSaleOrderNoList.Distinct().ToList();
            objProposalsInfo.APProposalReference = string.Join(",", arSaleOrderNoList.ToArray());
            ARSaleOrdersController objARSaleOrderController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrderList = new List<ARSaleOrdersInfo>();
            arSaleOrderNoList.ForEach(o =>
            {
                saleOrderList.Add((ARSaleOrdersInfo)objARSaleOrderController.GetObjectByNo(o));
            });
            strSaleOrderSaleAgreement = string.Join(",", saleOrderList.Select(o => o.ARSaleOrderSaleAgreement).Where(o => !string.IsNullOrEmpty(o)).ToArray());
            objProposalsInfo.APProposalPONo = strSaleOrderSaleAgreement;
            objProposalsInfo.ACObjectAccessKey = saleOrderItems[0].FK_ACObjectID + ";" + saleOrderItems[0].ARObjectType;
            entity.UpdateMainObjectBindingSource();
        }

        private void AddItemComponentToPurchaseProposalItemsList(ARSaleOrderItemsInfo objSaleOrderItemsInfo, List<ARSOItemComponentsInfo> productComponents)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objProposalsInfo = (APProposalsInfo)entity.MainObject;
            productComponents.ForEach(o =>
            {
                APProposalItemsInfo item = new APProposalItemsInfo();
                entity.SetValuesAfterValidateProduct(o.FK_ICProductID, item);
                item.APProposalItemProductQty = o.ARSOItemComponentQty;
                item.APProposalItemNeedTime = objProposalsInfo.APProposalNeedTime;
                item.APProposalItemNeedToTime = objProposalsInfo.APProposalNeedToTime;
                item.FK_ARSaleOrderID = objSaleOrderItemsInfo.FK_ARSaleOrderID;
                item.FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID;
                item.FK_ACObjectID = objSaleOrderItemsInfo.FK_ACObjectID;
                item.APObjectType = objSaleOrderItemsInfo.ARObjectType;
                item.ACObjectName = objSaleOrderItemsInfo.ACObjectName;
                item.APProposalItemProductQty = Math.Round(item.APProposalItemProductQty, 5, MidpointRounding.AwayFromZero);
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

                        item.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                        item.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    }
                    APProposalItemsGridControl.FormatQuantity(objProductsInfo.ICProductType);
                    entity.PurchaseProposalItemList.Add(item);
                }
            });
        }

        public void ChangeCollumnQtyName()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainObject = (APProposalsInfo)entity.MainObject;
            GridColumn col = entity.PurchaseProposalItemList.GridView.Columns["APProposalItemProductQty"];
            if (col != null)
            {
                if (mainObject.FK_MMBatchProductID != 0)
                    col.Caption = "Khối lượng";
                else
                    col.Caption = "Số lượng";
            }
        }

        public void ChangeObject(string objectAccessKey)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo objAPProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objAPProposalsInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objAPProposalsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objAPProposalsInfo.APObjectType = objObjectsInfo.ACObjectType;
                objAPProposalsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                entity.UpdateMainObjectBindingSource();
            }
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            mainobject.APProposalApproveStatus = ApproveStatus.NeedApprove;
        }

        public bool IsValidCanceledQty(APProposalItemsInfo item)
        {
            if (item.FK_ARSaleOrderItemID == 0)
                return true;

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = objSaleOrderItemsController.GetSaleOrderProductQtyAllowToProposal(item.FK_ARSaleOrderItemID, item.APProposalItemID);
            if (objSaleOrderItemsInfo == null)
                return true;

            if (item.APProposalItemProductQty * item.APProposalItemProductFactor > objSaleOrderItemsInfo.ARSaleOrderItemProductQty)
            {
                MessageBox.Show(string.Format("Sản phẩm {0} có số lượng lớn hơn số lượng đơn bán hàng. Số lượng có thể đề nghị: {1}", objSaleOrderItemsInfo.ARSaleOrderItemProductName, objSaleOrderItemsInfo.ARSaleOrderItemProductQty.ToString("n3")));
                return false;
            }
            return true;
        }

        public void ActionNewFromPurchasePlanOtherMaterial()
        {
            ActionNew();
            ShowPurchasePlaneByType(PurchasePlanType.OtherMaterial.ToString());
            ChangedInputType(PurchasePlanType.OtherMaterial.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromPurchasePlanMaterial()
        {
            ActionNew();
            ShowPurchasePlaneByType(PurchasePlanType.Material.ToString());
            ChangedInputType(PurchasePlanType.Material.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void ActionNewFromBatchProductBoard()
        {
            ActionNew();
            ShowPurchasePlaneByType(ProductType.ArtificialBoard.ToString());
            ChangedInputType(ProductType.Product.ToString());
            ProductItemLookUpEditControl.Enabled = false;
        }

        public void NewFromInventoryStock()
        {
            ActionNew();
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainobject = (APProposalsInfo)entity.MainObject;
            guiChooseInventoryStocks guiChooseInventoryStocks = new guiChooseInventoryStocks();
            guiChooseInventoryStocks.Module = this;
            if (guiChooseInventoryStocks.ShowDialog() != DialogResult.OK)
                return;

            if (guiChooseInventoryStocks.SelectedObjects.Count <= 0)
                return;

            List<ICInventoryStocksInfo> results = guiChooseInventoryStocks.SelectedObjects;
            ICInventoryStocksInfo objInventoryStocksInfo = results.FirstOrDefault();
            if (objInventoryStocksInfo == null)
                objInventoryStocksInfo = new ICInventoryStocksInfo();
            mainobject.APProposalNeedTime = objInventoryStocksInfo.ICInventoryStockNeedDate;
            mainobject.APProposalNeedToTime = objInventoryStocksInfo.ICInventoryStockNeedDate;
            results.ForEach(o =>
            {
                entity.PurchaseProposalItemList.Add(ToProposalItems(o));
            });
            entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            entity.UpdateLookupTableDataSource();
        }

        public APProposalItemsInfo ToProposalItems(ICInventoryStocksInfo objInventoryStocksInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objInventoryStocksInfo.FK_ICProductID);
            if (objProductsInfo == null)
                objProductsInfo = new ICProductsInfo();
            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            objProposalItemsInfo.APProposalItemProductFactor = 1;
            objProposalItemsInfo.APProposalItemProductQty = objInventoryStocksInfo.ICInventoryStockProposalQuantity;
            objProposalItemsInfo.APProposalItemProductExchangeQty = objProposalItemsInfo.APProposalItemProductQty * objProposalItemsInfo.APProposalItemProductFactor;
            objProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProposalItemsInfo.FK_ICProductID = objInventoryStocksInfo.FK_ICProductID;
            objProposalItemsInfo.APProposalItemNeedTime = objInventoryStocksInfo.ICInventoryStockNeedDate;
            objProposalItemsInfo.APProposalItemProductDesc = objProductsInfo.ICProductDesc;
            objProposalItemsInfo.APProposalItemProductName = objProductsInfo.ICProductName;
            objProposalItemsInfo.APProposalItemProductLenght = objProductsInfo.ICProductLength;
            objProposalItemsInfo.APProposalItemProductWidth = objProductsInfo.ICProductWidth;
            objProposalItemsInfo.APProposalItemProductHeight = objProductsInfo.ICProductHeight;
            objProposalItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProposalItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProposalItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
            objProposalItemsInfo.APProposalItemProductUnitPrice = objProductsInfo.ICProductPrice01;
            objProposalItemsInfo.APProposalItemProductUnitCost = objProductsInfo.ICProductSupplierPrice;
            objProposalItemsInfo.APProposalItemTotalCost = objProposalItemsInfo.APProposalItemProductUnitCost * objProposalItemsInfo.APProposalItemProductQty;
            objProposalItemsInfo.APProposalItemNeedTime = objInventoryStocksInfo.ICInventoryStockNeedDate;
            objProposalItemsInfo.APProposalItemNeedToTime = objInventoryStocksInfo.ICInventoryStockNeedDate;
            return objProposalItemsInfo;
        }

        public void NewFromBPSemiProductOutsourcing()
        {
            ActionNew();
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainobject = (APProposalsInfo)entity.MainObject;

            guiChooseBPSemiProduct guiFind = new guiChooseBPSemiProduct();
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<MMBatchProductItemOutSourcingsInfo> bpItemOutSourcingList = guiFind.SelectedObjects;
            MMBatchProductItemOutSourcingsInfo bpPnisInfo = bpItemOutSourcingList.FirstOrDefault();
            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            List<APProposalItemsInfo> proposalItemsList = new List<APProposalItemsInfo>();
            MMBatchProductsInfo objBatchProductsInfo
                = bpPnisInfo != null
                ? (MMBatchProductsInfo)(new MMBatchProductsController()).GetObjectByID(bpPnisInfo.FK_MMBatchProductID)
                : new MMBatchProductsInfo();
            if (bpPnisInfo == null)
            {
                return;
            }
            mainobject.FK_MMBatchProductID = bpPnisInfo.FK_MMBatchProductID;
            mainobject.APPurchaseProposalType = PurchaseProposalType.OutSourcing.ToString();
            bpItemOutSourcingList.ForEach(o =>
            {
                objProposalItemsInfo = ToPurchaseProposalItems(o, objBatchProductsInfo);
                proposalItemsList.Add(objProposalItemsInfo);
            });
            entity.PurchaseProposalItemList.Invalidate(proposalItemsList);
            mainobject.MMBatchProductSOName = string.Join(",", proposalItemsList.Select(o => o.MMBatchProductSOName).Distinct().ToArray()); 
            if (entity.PurchaseProposalItemList.GridControl != null)
            {
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            }
            entity.UpdateMainObjectBindingSource();
        }

        public APProposalItemsInfo ToPurchaseProposalItems(MMBatchProductItemOutSourcingsInfo item, MMBatchProductsInfo objBatchProductsInfo)
        {
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == item.FK_ICProductID).FirstOrDefault();
            if (objProductsInfo == null)
                objProductsInfo = new ICProductsForViewInfo();

            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            BOSUtil.CopyObject(objProductsInfo, objProposalItemsInfo);
            objProposalItemsInfo.FK_ICProductID = item.FK_ICProductID;
            objProposalItemsInfo.FK_MMBatchProductItemOutSourcingID = item.MMBatchProductItemOutSourcingID;
            objProposalItemsInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
            objProposalItemsInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
            objProposalItemsInfo.FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID;
            objProposalItemsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
            objProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProposalItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProposalItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProposalItemsInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
            objProposalItemsInfo.APProposalItemProductName = item.MMBatchProductItemOutSourcingProductName;
            objProposalItemsInfo.APProposalItemProductDesc = item.MMBatchProductItemOutSourcingProductDesc;
            objProposalItemsInfo.APProposalItemProductHeight = item.MMBatchProductItemOutSourcingProductHeight;
            objProposalItemsInfo.APProposalItemProductWidth = item.MMBatchProductItemOutSourcingProductWidth;
            objProposalItemsInfo.APProposalItemProductLenght = item.MMBatchProductItemOutSourcingProductLength;
            objProposalItemsInfo.APProposalItemProductQty = item.MMBatchProductItemOutSourcingProductQty;
            objProposalItemsInfo.APProposalItemProductFactor = 1;
            objProposalItemsInfo.APProposalItemProductExchangeQty = item.MMBatchProductItemOutSourcingProductQty;
            objProposalItemsInfo.APProposalItemNeedTime = item.MMBatchProductItemOutSourcingNeedDate;
            objProposalItemsInfo.APProposalItemNeedToTime = item.MMBatchProductItemOutSourcingNeedDate;
            objProposalItemsInfo.APProposalItemOperation = item.MMBatchProductItemOutSourcingOperation;
            objProposalItemsInfo.FK_ICProductAttributeTTMTID = objBatchProductsInfo.FK_ICProductAttributeTTMTID;
            objProposalItemsInfo.MMBatchProductSOName = item.MMBatchProductSOName;
            return objProposalItemsInfo;
        }

        public List<MMOperationsInfo> GetOperationDataSourceOfSemiProduct(int outSourcingItemID)
        {
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operationsList = objOperationsController.GetOperationByBPOutSourcingItemID(outSourcingItemID);
            return operationsList;
        }

        public bool IsValidOutSourcingQty(APProposalItemsInfo item)
        {
            if (item.FK_MMBatchProductItemOutSourcingID == 0)
                return true;

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            MMBatchProductItemOutSourcingsController objBatchProductItemOutSourcingsController = new MMBatchProductItemOutSourcingsController();
            List<MMBatchProductItemOutSourcingsInfo> checkOutSourcingList = objBatchProductItemOutSourcingsController.GetBPRemainQtyForPurchaseProposalByID(item.FK_MMBatchProductItemOutSourcingID, item.APProposalItemID);
            if (checkOutSourcingList.Count() == 0)
                return true;

            List<APProposalItemsInfo> sameOutSourcingItems = entity.PurchaseProposalItemList.Where(o => o.FK_MMBatchProductItemOutSourcingID > 0 && o.FK_MMBatchProductItemOutSourcingID == item.FK_MMBatchProductItemOutSourcingID).ToList();
            MMBatchProductItemOutSourcingsInfo defaultItem = checkOutSourcingList.FirstOrDefault();
            string messageError = string.Empty;
            List<int> operationProposalList = new List<int>();
            if (!string.IsNullOrWhiteSpace(item.APProposalItemOperation))
                operationProposalList = item.APProposalItemOperation.Split(',').Select(o => Int32.Parse(o)).ToList();
            else
                operationProposalList.Add(0);

            List<int> operationOutSourcingList = new List<int>();
            if (!string.IsNullOrWhiteSpace(defaultItem.MMBatchProductItemOutSourcingOperation))
                operationOutSourcingList = defaultItem.MMBatchProductItemOutSourcingOperation.Split(',').Select(o => Int32.Parse(o)).ToList();
            else
                operationOutSourcingList.Add(0);

            List<int> operationList = new List<int>();
            Dictionary<int, decimal> operationCompare = new Dictionary<int, decimal>();
            checkOutSourcingList.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.APProposalItemOperation))
                {
                    if (operationCompare.ContainsKey(0))
                        operationCompare[0] = operationCompare[0] + o.APProposalItemProductExchangeQty;
                    else
                        operationCompare.Add(0, o.APProposalItemProductExchangeQty);

                    return;
                }
                operationList = o.APProposalItemOperation.Split(',').Select(oper => Int32.Parse(oper)).ToList();
                operationList.ForEach(oprer =>
                {
                    if (operationCompare.ContainsKey(oprer))
                        operationCompare[oprer] = operationCompare[oprer] + o.APProposalItemProductExchangeQty;
                    else
                        operationCompare.Add(oprer, o.APProposalItemProductExchangeQty);
                });
            });
            Dictionary<int, decimal> operationSameItem = new Dictionary<int, decimal>();
            sameOutSourcingItems.ForEach(o =>
            {
                if (string.IsNullOrWhiteSpace(o.APProposalItemOperation))
                {
                    if (operationSameItem.ContainsKey(0))
                        operationSameItem[0] = operationCompare[0] + o.APProposalItemProductQty * o.APProposalItemProductFactor;
                    else
                        operationSameItem.Add(0, o.APProposalItemProductQty * o.APProposalItemProductFactor);

                    return;
                }
                operationList = o.APProposalItemOperation.Split(',').Select(oper => Int32.Parse(oper)).ToList();
                operationList.ForEach(oprer =>
                {
                    if (operationSameItem.ContainsKey(oprer))
                        operationSameItem[oprer] = operationSameItem[oprer] + o.APProposalItemProductQty * o.APProposalItemProductFactor;
                    else
                        operationSameItem.Add(oprer, o.APProposalItemProductQty * o.APProposalItemProductFactor);
                });
            });
            decimal proposalQty = 0;
            decimal remainQty = 0;
            decimal sumSameOperationQty = 0;
            operationProposalList.ForEach(oper =>
            {
                if (!operationOutSourcingList.Contains(oper))
                {
                    messageError += string.Format("Sản phẩm {0} có công đoạn khác với kế hoạch.", defaultItem.MMBatchProductItemOutSourcingProductName);
                    messageError += Environment.NewLine;
                    return;
                }
                proposalQty = 0;
                if (operationCompare.ContainsKey(oper))
                    proposalQty = operationCompare[oper];

                sumSameOperationQty = item.APProposalItemProductQty * item.APProposalItemProductFactor;
                if (operationSameItem.ContainsKey(oper))
                    sumSameOperationQty = operationSameItem[oper];

                if (defaultItem.MMBatchProductItemOutSourcingProductQty - proposalQty - sumSameOperationQty >= 0)
                    return;

                remainQty = defaultItem.MMBatchProductItemOutSourcingProductQty - proposalQty;
                if (oper == 0)
                    messageError += string.Format("Sản phẩm {0} có số lượng lớn hơn số lượng đã kế hoạch. Số lượng có thể đề nghị: {1}", defaultItem.MMBatchProductItemOutSourcingProductName, remainQty.ToString("n5"));
                else
                    messageError += string.Format("Sản phẩm {0}, công đoạn {1} có số lượng lớn hơn số lượng đã kế hoạch. Số lượng có thể đề nghị: {2}", defaultItem.MMBatchProductItemOutSourcingProductName, BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", oper, "MMOperationName"), remainQty.ToString("n5"));

                messageError += Environment.NewLine;
            });
            if (string.IsNullOrWhiteSpace(messageError))
                return true;

            messageError += "Vui lòng kiểm tra lại!";
            messageError += Environment.NewLine;
            MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        //public bool IsValidProposalQty(APProposalItemsInfo item, string columnName)
        //{
        //    decimal oldProductFactor = item.APProposalItemProductFactor;
        //    if (columnName == "FK_ICMeasureUnitID")
        //    {
        //        ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
        //        ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
        //        item.APProposalItemProductFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0) ? measureUnit.ICProductMeasureUnitFactor : 1;
        //    }
        //    bool isValid = true;
        //    isValid = IsValidCanceledQty(item);
        //    if (!isValid)
        //    {
        //        item.APProposalItemProductFactor = oldProductFactor;
        //        return false;
        //    }

        //    isValid = IsValidAllocationPlanQty(item);
        //    if (!isValid)
        //    {
        //        item.APProposalItemProductFactor = oldProductFactor;
        //        return false;
        //    }

        //    isValid = IsValidBatchProductQty(item);
        //    if (!isValid)
        //    {
        //        item.APProposalItemProductFactor = oldProductFactor;
        //        return false;
        //    }

        //    isValid = IsValidOutSourcingQty(item);
        //    if (!isValid)
        //    {
        //        item.APProposalItemProductFactor = oldProductFactor;
        //        return false;
        //    }
        //    return isValid;
        //}

        public void DiscardPurchaseProposal()
        {
            if (!Toolbar.IsNullOrNoneAction())
                return;

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn hủy chứng từ này?", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (rs != DialogResult.Yes)
                return;

            entity.SetPropertyChangeEventLock(false);
            mainobject.APPurchaseProposalStatus = PurchaseProposalStatus.Canceled.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void ActionNewFromBatchProductScheduleHW()
        {
            ActionNew();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objProposalsInfo.APProposalAPTypeCombo = PurchasePlanType.Hardware.ToString();
        }

        public void ActionNewFromBatchProductScheduleOtherMaterial()
        {
            ActionNew();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objProposalsInfo.APProposalAPTypeCombo = PurchasePlanType.OtherMaterial.ToString();
        }

        public void ActionNewFromBatchProductScheduleMaterial()
        {
            ActionNew();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objProposalsInfo.APProposalAPTypeCombo = PurchasePlanType.Material.ToString();
        }

        public void ActionNewFromBatchProductScheduleGeneralMaterial()
        {
            ActionNew();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objProposalsInfo.APProposalAPTypeCombo = PurchasePlanType.GeneralMaterial.ToString();
        }

        public void ActionNewFromBatchProductSchedulePackaging()
        {
            ActionNew();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objProposalsInfo.APProposalAPTypeCombo = PurchasePlanType.IngredientPackaging.ToString();
        }

        public void ActionNewFromBatchProductSchedulePaint()
        {
            ActionNew();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objProposalsInfo.APProposalAPTypeCombo = PurchasePlanType.IngredientPaint.ToString();
        }

        public void ShowBatchProductSchedule()
        {
            if (Toolbar.IsNullOrNoneAction())
                return;

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            guiAllocationPlanItems guiFind = new guiAllocationPlanItems();
            guiFind.AllocationPlanItemGroup = mainobject.APProposalAPTypeCombo;
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
            {
                return;
            }
            List<MMAllocationPlanItemsInfo> allocationPlanItemList = guiFind.SelectedObjects;
            MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = allocationPlanItemList.FirstOrDefault();
            List<APProposalItemsInfo> proposalItemList = new List<APProposalItemsInfo>();
            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            MMBatchProductsInfo objBatchProductsInfo
                = objAllocationPlanItemsInfo != null
                ? (MMBatchProductsInfo)(new MMBatchProductsController()).GetObjectByID(objAllocationPlanItemsInfo.FK_MMBatchProductID)
                : new MMBatchProductsInfo();
            allocationPlanItemList.ForEach(o =>
            {
                objProposalItemsInfo = ToPurchasePlanItems(o, objBatchProductsInfo);
                proposalItemList.Add(objProposalItemsInfo);
            });
            mainobject.MMBatchProductSOName = string.Join(",", allocationPlanItemList.Select(o => o.MMBatchProductItemSOName).Distinct().ToArray());
            entity.PurchaseProposalItemList.AddRange(proposalItemList);
            if (entity.PurchaseProposalItemList.GridControl != null)
            {
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            }
            entity.UpdateMainObjectBindingSource();
        }

        public APProposalItemsInfo ToPurchasePlanItems(MMAllocationPlanItemsInfo item, MMBatchProductsInfo objBatchProductsInfo)
        {
            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            ICProductsForViewInfo objProductsForViewInfo = BOSApp.CurrentProductList.Where(o => o.ICProductID == item.FK_ICProductID).FirstOrDefault();
            if (objProductsForViewInfo == null)
                objProductsForViewInfo = new ICProductsForViewInfo();
            if (objBatchProductsInfo == null)
                objBatchProductsInfo = new MMBatchProductsInfo();

            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            BOSUtil.CopyObject(objProductsForViewInfo, objProposalItemsInfo);
            objProposalItemsInfo.FK_ICProductID = item.FK_ICProductID;
            objProposalItemsInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
            objProposalItemsInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
            objProposalItemsInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
            objProposalItemsInfo.FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID;
            objProposalItemsInfo.FK_ICMeasureUnitID = item.FK_ICMeasureUnitID;
            objProposalItemsInfo.FK_ICProductAttributeTTMTID = objBatchProductsInfo.FK_ICProductAttributeTTMTID;
            objProposalItemsInfo.APProposalItemNormQty = item.MMAllocationPlanItemBPQty;
            objProposalItemsInfo.ICInventoryStockQty = item.ICInventoryStockQty;
            objProposalItemsInfo.APProposalItemProductQty = item.MMAllocationPlanItemQty;
            objProposalItemsInfo.APProposalItemProductFactor = item.ICProductMeasureUnitFactor;
            objProposalItemsInfo.APProposalItemProductExchangeQty = item.MMAllocationPlanItemQty * item.ICProductMeasureUnitFactor;
            objProposalItemsInfo.APProposalItemProductName = item.MMAllocationPlanItemProductName;
            objProposalItemsInfo.APProposalItemProductDesc = item.MMAllocationPlanItemProductDesc;
            objProposalItemsInfo.APProposalItemNeedTime = item.MMAllocationPlanItemDeliveryDate;
            objProposalItemsInfo.APProposalItemNeedToTime = item.MMAllocationPlanItemDeliveryDate;
            objProposalItemsInfo.APProposalItemProductHeight = item.MMAllocationPlanItemHeight;
            objProposalItemsInfo.APProposalItemProductWidth = item.MMAllocationPlanItemWidth;
            objProposalItemsInfo.APProposalItemProductLenght = item.MMAllocationPlanItemLength;
            objProposalItemsInfo.APProposalItemProductType = item.MMAllocationPlanItemGroup;
            objProposalItemsInfo.APProposalItemCode01Combo = item.MMAllocationPlanItemCode01Combo;
            objProposalItemsInfo.APProposalItemCode02Combo = item.MMAllocationPlanItemCode02Combo;
            objProposalItemsInfo.APProposalItemCode03Combo = item.MMAllocationPlanItemCode03Combo;
            objProposalItemsInfo.APProposalItemCode04Combo = item.MMAllocationPlanItemCode04Combo;
            objProposalItemsInfo.APProposalItemCode05Combo = item.MMAllocationPlanItemCode05Combo;
            objProposalItemsInfo.APProposalItemComment = item.MMAllocationPlanItemComment;
            objProposalItemsInfo.MMBatchProductSOName = item.MMBatchProductItemSOName;
            //objProposalItemsInfo.APProposalItemPurchaseProposalQty = item.APProposalItemPurchaseProposalQty;
            //objProposalItemsInfo.APProposalItemRemainQty = objProposalItemsInfo.APProposalItemBPProductionNormItemQty - objProposalItemsInfo.APProposalItemQuantity - objProposalItemsInfo.APProposalItemPurchaseProposalQty;
            return objProposalItemsInfo;
        }

        public void GetInventoryQty()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            if (entity.PurchaseProposalItemList.Count() == 0)
                return;

            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<int> productIds = entity.PurchaseProposalItemList.Select(o => o.FK_ICProductID).Distinct().ToList();
            List<ICTransactionsInfo> inventoryStocks = objTransactionsController.GetInventoryStockListByProductRef(productIds);
            ICTransactionsInfo objTransactionsInfo = new ICTransactionsInfo();
            decimal availableQty = 0;
            entity.PurchaseProposalItemList.ForEach(o =>
            {
                o.IsCheckInventory = true;
                objTransactionsInfo = inventoryStocks.Where(iv => iv.FK_ICProductID == o.FK_ICProductID).FirstOrDefault();
                if (objTransactionsInfo == null)
                    objTransactionsInfo = new ICTransactionsInfo();

                availableQty = objTransactionsInfo.ICInventoryStockQuantity - objTransactionsInfo.ICTransactionReceiptQty;
                if (availableQty < 0)
                    availableQty = 0;

                o.ICInventoryStockQty = availableQty / (o.APProposalItemProductFactor == 0 ? 1 : o.APProposalItemProductFactor);
                o.ICInventoryStockQty = Math.Round(o.ICInventoryStockQty, 5, MidpointRounding.AwayFromZero);

                objTransactionsInfo.ICTransactionReceiptQty += o.APProposalItemProductQty * (o.APProposalItemProductFactor == 0 ? 1 : o.APProposalItemProductFactor);
                objTransactionsInfo.ICTransactionReceiptQty = Math.Round(objTransactionsInfo.ICTransactionReceiptQty, 5, MidpointRounding.AwayFromZero);
            });
            if (entity.PurchaseProposalItemList.GridControl != null)
            {
                entity.PurchaseProposalItemList.GridControl.RefreshDataSource();
            }
        }

        public bool IsValidAllocationPlanQty(APProposalItemsInfo item)
        {
            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrWhiteSpace(item.APProposalItemCode05Combo))
                return true;

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            MMAllocationPlanItemsController pnisController = new MMAllocationPlanItemsController();
            decimal remainQty = pnisController.GetRemainItemForPurchaseProposal(mainobject.APProposalAPTypeCombo
                                                                                , item.APProposalItemCode01Combo
                                                                                , item.APProposalItemCode02Combo
                                                                                , item.APProposalItemCode03Combo
                                                                                , item.APProposalItemCode04Combo
                                                                                , item.APProposalItemCode05Combo
                                                                                , item.APProposalItemID);
            if (item.APProposalItemProductQty * item.APProposalItemProductFactor > remainQty)
            {
                MessageBox.Show(string.Format("Sản phẩm [{0}] có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể đề nghị: {1}", item.APProposalItemProductName, remainQty.ToString("n5")));
                return false;
            }
            return true;
        }

        public bool IsValidBatchProductQty(APProposalItemsInfo item)
        {
            if (item.FK_MMBatchProductProductionNormItemID == 0 || item.FK_MMBatchProductItemOutSourcingID != 0)
                return true;

            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            MMBatchProductProductionNormItemsController pnisController = new MMBatchProductProductionNormItemsController();
            decimal remainQty = pnisController.GetRemainItemForPurchaseProposal(item.FK_MMBatchProductProductionNormItemID, item.APProposalItemProductType, item.APProposalItemID);
            if (item.APProposalItemProductQty * item.APProposalItemProductFactor > remainQty)
            {
                MessageBox.Show(string.Format("Sản phẩm [{0}] có số lượng lớn hơn số lượng kế hoạch. Số lượng có thể đề nghị: {1}", item.APProposalItemProductName, remainQty.ToString("n5")));
                return false;
            }
            return true;
        }

        public void ViewApprovalDetails()
        {
            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            APProposalApprovalsController controller = new APProposalApprovalsController();
            List<APProposalApprovalsInfo> approvalDetails = controller.GetItemByProposalID(mainobject.APProposalID);
            if (!approvalDetails.Any())
            {
                MessageBox.Show("Chứng từ không có thông tin xét duyệt.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            guiProposalApprovals guiView = new guiProposalApprovals(approvalDetails);
            guiView.Module = this;
            guiView.ShowDialog();
        }

        public void InitProductPictureImage(int productID)
        {
            if (productID > 0 && ProductPicturePictureBox != null)
            {
                ProductPicturePictureBox.Image = BOSApp.GetProductPictureImageByProductID(productID);
                ProductPicturePictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
        }

        public void ChangeDisplayColumnByWoodType(BOSGridControl gridControl, string woodType)
        {
            if (gridControl == null)
                return;
            GridView gridView = (GridView)gridControl.MainView;
            if (gridView == null)
                return;

            APProposalsInfo mainobject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            List<string> n3Groups = new List<string>() { ProposalAPType.Other.ToString(),
                                                         ProposalAPType.Equipment.ToString(),
                                                         ProposalAPType.Hardware.ToString(),
                                                         ProposalAPType.IngredientPaint.ToString()};

            if (n3Groups.Contains(woodType))
            {
                GridColumn column = gridView.Columns["APProposalItemProductQty"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, true, "n3");
              
                column = gridView.Columns["APProposalItemProductFactor"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, false, "n3");
               

                column = gridView.Columns["APProposalItemProductExchangeQty"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, true, "n3");
                

                column = gridView.Columns["APProposalItemNormQty"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, true, "n3");
            }
            else
            {
                GridColumn column = gridView.Columns["APProposalItemProductQty"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, true, "n5");

                column = gridView.Columns["APProposalItemProductFactor"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, false, "n3");


                column = gridView.Columns["APProposalItemProductExchangeQty"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, true, "n5");


                column = gridView.Columns["APProposalItemNormQty"];
                if (column != null)
                    APProposalItemsGridControl.FormatNumbericColumn(column, true, "n5");
            }    
        }

        #region Mở - Xóa chứng từ
        public override bool ActionCancelComplete()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainObject = (APProposalsInfo)entity.MainObject;
            if (mainObject.APProposalID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                entity.SetPropertyChangeEventLock(false);
                mainObject.APPurchaseProposalStatus = PurchaseProposalStatus.New.ToString();
                mainObject.APProposalApproveStatus = ApproveStatus.NeedApprove;
                entity.UpdateMainObject();
                entity.SetPropertyChangeEventLock(true);
                bool result = base.ActionCancelComplete();
                InvalidateToolbar();
                return result;
            }
            return true;
        }

        public override void ActionDelete()
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)CurrentModuleEntity;
            APProposalsInfo mainObject = (APProposalsInfo)CurrentModuleEntity.MainObject.Clone();
            if (mainObject.APProposalID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                base.ActionDelete();
            }  
        }

        private bool CheckRelativeDocument()
        {
            APProposalsInfo mainObject = (APProposalsInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByProposalID(mainObject.APProposalID);

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
        #endregion
    }
}
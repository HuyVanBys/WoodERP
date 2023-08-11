using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.BatchProposal.Localization;
using BOSERP.Utilities;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProposal
{
    public partial class BatchProposalModule : BaseModuleERP
    {
        #region Constants
        public const string ProductLookupEditName = "fld_lkeFK_ICProductID";
        public const string ProductLookupEditName2 = "fld_lkeFK_ICProductID2";
        public const string PurchasePlanTabControlName = "fld_tabWoodItems";
        //[TTLoi][Add Document][06/11/2014] BEGIN

        public const string FilePathTextBoxName = "fld_txtFilePath";
        public const string BatchProposalTemplateGridControlName = "fld_dgcMMProposalTemplates";

        public const string TemplateUserControlName = "fld_rtbTemplate";
        private string DocumentFileName = string.Empty;
        private const string SubFolder = "BatchProposal";

        private const string StartRow = "\\trowd";
        private const string EndRow = "\\row";
        private const string StartCell = "\\cellx";
        private const string EndCell = "\\cell";
        private const string BackSlash = "\\";
        private const char SpaceChar = ' ';
        private const string SpecialTableString = "\\intbl";
        private const string ExpressionString = "exp";
        private const string Colon = ":";

        private BOSGridControl BatchProposalTemplateGridControl;

        //[TTLoi][Add Document][06/11/2014] END
        public const string BatchProposalItemsGridControlName = "fld_dgcMMProposalItemsGridControl2";
        #endregion

        //[TTLoi][Add Document][06/11/2014] BEGIN
        private String TemplateServerPath { get; set; }
        //[TTLoi][Add Document][06/11/2014] END

        #region Property
        //List<MMBatchItemsInfo> BatchItemListOriginalList { get; set; }
        //List<MMBatchItemsInfo> OldBatchItemList { get; set; }
        LookUpEdit ProductLookupEdit;
        BOSLookupEdit ProductLookupEdit2;
        public BOSTabControl purchasePlanTabControl;
        #endregion
        public BatchProposalModule()
        {
            Name = "BatchProposal";
            CurrentModuleEntity = new BatchProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            ProductLookupEdit = (LookUpEdit)Controls[ProductLookupEditName];
            EnableToolbar();
            ProductLookupEdit2 = (BOSLookupEdit)Controls[ProductLookupEditName2];
            BatchProposalTemplateGridControl = (BOSGridControl)Controls[BatchProposalModule.BatchProposalTemplateGridControlName];
            purchasePlanTabControl = (BOSTabControl)Controls[PurchasePlanTabControlName];
        }

        public override void ActionNew()
        {
            base.ActionNew();
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            objProposalsInfo.MMProposalBatchStatus = MMProposalBatchStatus.New.ToString();
            objProposalsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public void ActionNewFromSaleOrder()
        {
            ActionNew();
            ShowSaleOrder();
        }

        public string GetConfigTextByGroupAndValue(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }

        public void ApproveBatchProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
                MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
                ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                //MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                MMProposalsController objProposalsController = new MMProposalsController();
                //if (objProposalsController.CheckApprovedProposal())
                objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    if (objSaleOrdersInfo.ARSaleOrderStatus != SaleOrderStatus.Canceled.ToString() && CheckItemQtyInSaleOrder() == true)
                    {
                        entity.ApproveProposal();
                        UpdateSaleOrderBatchStatus(MMProposalBatchStatus.Approved.ToString());
                        EnableToolbar();
                    }
                    else
                    {
                        MessageBox.Show(BatchProposalLocalizeResources.ProposalApproveErrror,
                                          MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (objSaleOrdersInfo == null)
                {
                    entity.ApproveProposal();
                    UpdateSaleOrderBatchStatus(MMProposalBatchStatus.Approved.ToString());
                    EnableToolbar();
                }
            }
        }
        public bool CheckItemQtyInSaleOrder()
        {
            int error = 0;
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            MMProposalItemsInfo objProposalItemsInfo = new MMProposalItemsInfo();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ICProductsController objProductsController = new ICProductsController();
            if (entity.ProposalItemList.Count > 0)
            {
                foreach (MMProposalItemsInfo item in entity.ProposalItemList)
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
                    ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                    objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                    if (objSaleOrderItemsInfo != null)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleOrderItemsInfo.FK_ICProductID);
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

                                if (Math.Round(item.MMProposalItemProductQty, 4, MidpointRounding.AwayFromZero) > Math.Round((objSaleOrderItemsInfo.ARSaleOrderItemProductQty - (objSaleOrderItemsInfo.ARSaleOrderItemShippedQty + objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty)), 4, MidpointRounding.AwayFromZero))
                                    error++;

                            }
                            else
                            {
                                if (item.MMProposalItemProductQty > (objSaleOrderItemsInfo.ARSaleOrderItemProductQty - (objSaleOrderItemsInfo.ARSaleOrderItemShippedQty + objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty)))
                                    error++;
                            }
                        }
                    }
                }
            }

            if (error > 0)
            { return false; }
            else
            { return true; }
        }


        public void UpdateSaleOrderBatchStatus(string proposalStatus)
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)entity.MainObject;
            //Update SaleOrder batch status
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            if (objProposalsInfo.FK_ARSaleOrderID > 0)
            {
                objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    //Change status to Proposed
                    objSaleOrdersInfo.ARSaleOrderBatchStatus = SaleOrderBatchStatus.Proposed.ToString();
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
                }
            }
        }

        /// <summary>
        /// Discard approved batch proposal
        /// </summary>
        public void DiscardApproveBatchProposal()
        {
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = new MMBatchProductsInfo();
            List<MMBatchProductsInfo> proposalList = new List<MMBatchProductsInfo>();
            proposalList = objBatchProductsController.CheckexistBatchProposal(objProposalsInfo.MMProposalID);
            if (objProposalsInfo.MMProposalID > 0 && proposalList.Count == 0)
            {
                //Update sale order batch status 
                BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
                if (objProposalsInfo.MMProposalBatchStatus != MMProposalBatchStatus.Completed.ToString())
                {
                    if (objProposalsInfo.FK_ARSaleOrderID > 0)
                    {
                        ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                        ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
                        objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
                        if (objSaleOrdersInfo != null)
                        {
                            objSaleOrdersInfo.ARSaleOrderBatchStatus = string.Empty;
                            objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
                        }
                    }
                    objProposalsInfo.MMProposalBatchStatus = MMProposalBatchStatus.New.ToString();
                    entity.SetPropertyChangeEventLock(false);
                    entity.UpdateMainObject();
                }
                else
                {
                    //Proposal item inprocessed
                    MessageBox.Show(BatchProposalLocalizeResources.ProposalItemInprocessed,
                                   MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EnableToolbar();
            }
            if (proposalList.Count > 0)
            {
                MessageBox.Show(BatchProposalLocalizeResources.ProposalItemInprocessed,
               MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null)
            {
                objProposalsInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
                ARSaleOrderItemsController objSOController = new ARSaleOrderItemsController();
                List<ARSaleOrderItemsInfo> ListItem = objSOController.GetAllitemBySaleOrderID(objSaleOrdersInfo.ARSaleOrderID);
                if (ListItem != null)
                {
                    foreach (ARSaleOrderItemsInfo item in ListItem)
                    {
                        ARSaleForecastsController objSFController = new ARSaleForecastsController();
                        ARSaleForecastsInfo objSFInfo = (ARSaleForecastsInfo)objSFController.GetObjectByID(item.FK_ARSaleForecastID);
                        if (objSFInfo != null)
                        {
                            objProposalsInfo.ARSaleForecastNo = objSFInfo.ARSaleForecastNo;
                        }
                    }
                }


            }
            //Set Readonly quantity
            //bool isEdit = true;
            //if (objProposalsInfo.MMProposalType == MMProposalType.SaleOrder.ToString())
            //{
            //    isEdit = false;
            //}
            EnableToolbar();
            //SetReadonlyQuantity(isEdit);
            entity.UpdateMainObjectBindingSource();
        }

        //public void SetReadonlyQuantity(bool isEdit)
        //{
        //    BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
        //    GridView gridView = entity.ProposalItemList.GridControl.MainView as GridView;
        //    foreach (GridColumn column in gridView.Columns)
        //    {
        //        if (column.FieldName == "MMProposalItemProductQty")
        //        {
        //            column.OptionsColumn.AllowEdit = isEdit;
        //        }
        //    }
        //}

        public override int ActionSave()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            entity.ProposalItemList.EndCurrentEdit();
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Canceled.ToString())
            {
                MessageBox.Show(BatchProposalLocalizeResources.ProposalApproveErrror,
                                  MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            List<MMProposalItemsInfo> ListProposalItemsOld = new List<MMProposalItemsInfo>();
            List<string> data = entity.ProposalItemList.Select(x => x.FK_ARSaleOrderItemID.ToString()).Distinct().ToList();
            if (data != null && data.Count > 0)
            {
                MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
                ListProposalItemsOld = objProposalItemsController.GetProposalItemsByARSaleOrderItemIDList(string.Join(",", data.ToArray()));
            }
            foreach (MMProposalItemsInfo objProposalItemInfo in entity.ProposalItemList)
            {
                if (!CheckProposalItemProductQty(objProposalItemInfo, ListProposalItemsOld))
                {
                    return 0;
                }
                string productName = CheckProductActive(objProposalItemInfo);
                if (productName != string.Empty)
                {
                    if (MessageBox.Show(string.Format(BatchProposalLocalizeResources.ProductActiveCheckFalseMessage, productName),
                                MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return 0;
                    }
                }
            }
            if (CheckItemQtyInSaleOrder() == false)
            {
                MessageBox.Show(BatchProposalLocalizeResources.ProposalItemSave,
                                  MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            int result = base.ActionSave();
            if (result > 0)
            {
                SaveProposalFile();
                EnableToolbar();
                ResetSearchObject();
            }
            return result;
        }

        public void SaveProposalFile()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            List<MMProposalTemplatesInfo> proposalTemplatesList = entity.ProposalTemplatesList.ToList();

            MMProposalTemplatesController objProposalTemplatesController = new MMProposalTemplatesController();
            MMProposalTemplatesInfo objProposalTemplatesInfo = new MMProposalTemplatesInfo();
            entity.SetPropertyChangeEventLock(true);
            string value = string.Empty;
            proposalTemplatesList.ForEach(o =>
            {
                if (!string.IsNullOrEmpty(o.MMProposalTemplateFileGUID))
                    return;

                entity.ProposalTemplateURLDic.TryGetValue(o.MMProposalTemplateID, out value);
                if (string.IsNullOrEmpty(value))
                    return;

                o.MMProposalTemplateFileGUID = ApiClientHelper.UpdateFile(value);
                objProposalTemplatesController.UpdateObject(o);
            });
            entity.ProposalTemplateURLDic.Clear();
            entity.SetPropertyChangeEventLock(false);
            entity.UpdateMainObjectBindingSource();
            entity.ProposalTemplatesList.GridControl?.RefreshDataSource();
        }

        public void DownloadDocmenent()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalTemplatesInfo objProposalTemplatesInfo = entity.ProposalTemplatesList[entity.ProposalTemplatesList.CurrentIndex];
            if (objProposalTemplatesInfo == null)
                return;

            if (string.IsNullOrEmpty(objProposalTemplatesInfo.MMProposalTemplateFileGUID))
            {
                MessageBox.Show(MESLocalizedResources.FileNotFoundErrorMessage,
                                MESLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objProposalTemplatesInfo.MMProposalTemplateFileGUID, objProposalTemplatesInfo.MMProposalTemplateName);
        }

        public override void ActionCancel()
        {
            base.ActionCancel();
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            entity.ProposalTemplateURLDic.Clear();
        }

        public string GetAttributeText(string productAttributeRefence)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = objProductAttributesController.GetProductAttributeByProductAttributeReferenceByCharater(productAttributeRefence, ",");
            if (productAttributeList == null)
                productAttributeList = new List<ICProductAttributesInfo>();
            return string.Join(", ", productAttributeList.Select(o => o.ICProductAttributeNo).ToArray());
        }

        public void AddItemToProposalItemsList(int productID)
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            if (productID <= 0)
                return;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo == null)
                return;
            MMProposalItemsInfo objProposalItemsInfo = new MMProposalItemsInfo();
            objProposalItemsInfo = ToProposalItemFromProduct(objProductsInfo);
            objProposalItemsInfo.MMProposalItemProductQty = 1;
            objProposalItemsInfo.MMProposalItemDeliveryDate = objProposalsInfo.MMProposalSaleOrderDeliveryDate;
            objProposalItemsInfo.MMProposalItemStatus = MMProposalItemStatus.New.ToString();

            entity.ProposalItemList.Add(objProposalItemsInfo);
            entity.ProposalItemList.GridControl?.RefreshDataSource();
            entity.ProposalItemList.GridView.ExpandAllGroups();
        }

        public MMProposalItemsInfo ToProposalItemFromProduct(ICProductsInfo objProductsInfo)
        {
            return new MMProposalItemsInfo()
            {
                FK_ICProductAttributeColorID = objProductsInfo.FK_ICProductAttributeColorID,
                FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID,
                MMProposalItemProductHeight = objProductsInfo.ICProductHeight,
                MMProposalItemProductWidth = objProductsInfo.ICProductWidth,
                MMProposalItemProductLength = objProductsInfo.ICProductLength,
                FK_ICProductID = objProductsInfo.ICProductID,
                FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID,
                FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID,
                FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID,
                MMProposalItemProductName = objProductsInfo.ICProductName,
                MMProposalItemProductDesc = objProductsInfo.ICProductDesc,
                MMProposalItemProductNo = objProductsInfo.ICProductNo,
                MMProposalItemProductType = objProductsInfo.ICProductType,
                MMProposalItemStatus = MMProposalItemStatus.New.ToString(),
                MMProposalItemProductMinLength = objProductsInfo.ICProductMinLength,
                MMProposalItemProductMaxHeight = objProductsInfo.ICProductMaxHeight,
                MMProposalItemHTID = objProductsInfo.ICProductAttributeFinishing,
                MMProposalItemProductUnitPrice = objProductsInfo.ICProductPrice01,
                MMProposalItemProductAttributeHTType = objProductsInfo.ICProductAttributeFinishingText,
                FK_ICProductAttributeHTTypeID = objProductsInfo.FK_ICProductAttributeFinishingID,
                MMProposalItemWoodTypeID = objProductsInfo.ICProductWoodTypeAttribute,
                MMProposalItemColorID = objProductsInfo.ICProductColorAttribute,
                MMProposalItemWoodTypeText = GetAttributeText(objProductsInfo.ICProductWoodTypeAttribute),
                MMProposalItemProductAttributeColor = GetAttributeText(objProductsInfo.ICProductColorAttribute),
                MMProposalItemIsNewProduct = false,
                MMProposalItemLabelCorlor = false,
                MMProposalItemProductBarcode = false,
                MMProposalItemProductCard = false,
                MMProposalItemProductFSCCard = false,
                MMProposalItemProductHDLR = false,
                MMProposalItemProductHDSD = false,
                MMProposalItemProductWarranty = false,
                MMProposalItemIsJoinComponent = false,
                MMProposalItemProductLabel = false
            };
        }

        public List<MMProposalItemsInfo> GenerateProposalItemFormSaleOrderItem(ARSaleOrderItemsInfo objSaleOrderItemsInfo, int saleOrderID)
        {
            List<MMProposalItemsInfo> proposalItemList = new List<MMProposalItemsInfo>();
            MMProposalItemsInfo objProposalItemsInfo = new MMProposalItemsInfo();
            if (objSaleOrderItemsInfo.FK_ICProductID < 0)
                return null;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleOrderItemsInfo.FK_ICProductID);
            if (objProductsInfo == null)
                return null;
            // List<ARSaleOrderItemsInfo> saleOrderItemsList

            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICProductComponentsInfo> productComponentList = objProductComponentsController.GetProductComponentListByProductID(objProductsInfo.ICProductID);
            if (productComponentList != null && productComponentList.Count > 0)
            {
                productComponentList.ForEach(o =>
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(o.FK_ICProductComponentChildID);
                    if (objProductsInfo != null)
                    {
                        objProposalItemsInfo = ToProposalItemFromProduct(objProductsInfo);
                        objProposalItemsInfo.MMProposalItemProductQty = o.ICProductComponentQty * objSaleOrderItemsInfo.ARSaleOrderItemProductRemainedQty;
                        objProposalItemsInfo.MMProposalItemStatus = MMProposalItemStatus.New.ToString();
                        objProposalItemsInfo.MMProposalItemProductQty = (objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty) * o.ICProductComponentQty;
                        objProposalItemsInfo.MMProposalItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice;
                        objProposalItemsInfo.MMProposalItemTotalAmount = objProposalItemsInfo.MMProposalItemProductQty * objProposalItemsInfo.MMProposalItemProductUnitPrice;
                        objProposalItemsInfo.FK_ARSaleOrderID = saleOrderID;
                        proposalItemList.Add(objProposalItemsInfo);
                    }
                });
            }
            else
            {
                objProposalItemsInfo = ToProposalItemFromProduct(objProductsInfo);
                objProposalItemsInfo.MMProposalItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemProductRemainedQty;
                objProposalItemsInfo.MMProposalItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice;
                objProposalItemsInfo.MMProposalItemTotalAmount = objProposalItemsInfo.MMProposalItemProductQty * objProposalItemsInfo.MMProposalItemProductUnitPrice;
                objProposalItemsInfo.MMProposalItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName;
                objProposalItemsInfo.MMProposalItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc;
                objProposalItemsInfo.MMProposalItemProductNo = objSaleOrderItemsInfo.ARSaleOrderItemProductNo;
                objProposalItemsInfo.MMProposalItemProductHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeight;
                objProposalItemsInfo.MMProposalItemProductWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth;
                objProposalItemsInfo.MMProposalItemProductLength = objSaleOrderItemsInfo.ARSaleOrderItemLength;
                objProposalItemsInfo.MMProposalItemStatus = MMProposalItemStatus.New.ToString();
                objProposalItemsInfo.FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID;
                objProposalItemsInfo.FK_ARSaleOrderID = saleOrderID;
                proposalItemList.Add(objProposalItemsInfo);
            }

            proposalItemList.ForEach(o =>
            {
                o.FK_ICProductAttributeQualityID = objSaleOrderItemsInfo.FK_ICProductAttributeQualityID;
                o.MMProposalItemDeliveryDate = objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate;
                o.MMProposalItemPONo = objSaleOrderItemsInfo.ARSaleOrderItemPONo;
                o.FK_ICProductAttributeColorID = objSaleOrderItemsInfo.FK_ICProductAttributeColorID;
                o.FK_ICProductAttributeWoodTypeID = objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID;
                o.MMProposalItemHTID = objSaleOrderItemsInfo.ARSaleOrderItemHTID;
                o.MMProposalItemProductAttributeHTType = objSaleOrderItemsInfo.ARSaleOrderItemHTText;
                o.MMProposalItemColorID = objSaleOrderItemsInfo.ARSaleOrderItemColorID;
                o.MMProposalItemProductAttributeColor = objSaleOrderItemsInfo.ARSaleOrderItemColorText;
                o.MMProposalItemWoodTypeID = objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID;
                o.MMProposalItemWoodTypeText = objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeText;
            });
            return proposalItemList;
        }

        public void EnableToolbar()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objBatchProposalsInfo = (MMProposalsInfo)entity.MainObject;
            string status = objBatchProposalsInfo.MMProposalBatchStatus;
            ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.ApproveBatchProposal, false);
            ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.DiscardBatchProposal, false);
            if (status == MMProposalItemStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.ApproveBatchProposal, true);
                ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.DiscardBatchProposal, false);
            }
            if (status == MMProposalItemStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.ApproveBatchProposal, false);
                ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.DiscardBatchProposal, true);
            }
            if (status == MMProposalItemStatus.InProcess.ToString() ||
                status == MMProposalItemStatus.Processed.ToString() ||
                status == MMProposalItemStatus.Completed.ToString() ||
                status == MMProposalItemStatus.Cancel.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.ApproveBatchProposal, false);
                ParentScreen.SetEnableOfToolbarButton(BatchProposalConst.DiscardBatchProposal, false);
            }
        }
        /// <summary>
        /// Show saleorder form
        /// </summary>
        public void ShowSaleOrder()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)entity.MainObject;
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrdersController objSaleOrderController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrderList = objSaleOrderController.GetSaleOrderForBatchProposal();
            guiFind<ARSaleOrdersInfo> guiFind = new guiFind<ARSaleOrdersInfo>(TableName.ARSaleOrdersTableName,
                                                                                             saleOrderList,
                                                                                             this,
                                                                                             false,
                                                                                             true
                                                                                             );
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
            {
                base.ActionCancel();
                return;
            }
            objSaleOrdersInfo = (ARSaleOrdersInfo)guiFind.SelectedObjects.FirstOrDefault();
            if (objSaleOrdersInfo != null)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
                ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                List<ARSaleOrderItemsInfo> saleOrderItemsList = objSaleOrderItemsController.GetItemsByProductionSaleOrderID(objSaleOrdersInfo.ARSaleOrderID);
                objProposalsInfo.FK_ARCustomerID = objSaleOrdersInfo.FK_ARCustomerID;
                objProposalsInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                objProposalsInfo.MMProposalDate = BOSApp.GetCurrentServerDate();
                objProposalsInfo.MMProposalSaleOrderDeliveryDate = objSaleOrdersInfo.ARSaleOrderDeliveryDate;
                objProposalsInfo.FK_ICProductAttributeTTMTID = objSaleOrdersInfo.FK_ICProductAttributeTTMTID;
                objProposalsInfo.MMProposalBatchStatus = MMProposalBatchStatus.New.ToString();
                objProposalsInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
                objProposalsInfo.MMProposalType = objSaleOrdersInfo.ARSaleOrderType;
                objProposalsInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                objProposalsInfo.MMShippingType = objSaleOrdersInfo.ARShippingType;
                objProposalsInfo.MMProposalType = objSaleOrdersInfo.ARSaleOrderProductType;
                objProposalsInfo.MMProposalPONo = objSaleOrdersInfo.ARSaleOrderSaleAgreement;
                objProposalsInfo.FK_ACObjectID = objSaleOrdersInfo.FK_ACObjectID;
                objProposalsInfo.MMObjectType = objSaleOrdersInfo.ARObjectType;
                objProposalsInfo.MMProposalDesc = objSaleOrdersInfo.ARProposalName;
                objProposalsInfo.ACObjectAccessKey = string.Format("{0};{1}", objProposalsInfo.FK_ACObjectID.ToString(), objProposalsInfo.MMObjectType);
                entity.ProposalItemList.Clear();
                MMProposalItemsInfo objProposalItemsInfo = new MMProposalItemsInfo();
                List<MMProposalItemsInfo> proposalItemList = new List<MMProposalItemsInfo>();
                saleOrderItemsList.ForEach(o =>
                {
                    objProposalItemsInfo = ToProposalItemFromSaleOrderItem(o);
                    proposalItemList.Add(objProposalItemsInfo);
                });
                entity.ProposalItemList.Invalidate(proposalItemList);
                entity.UpdateMainObjectBindingSource();
                entity.ProposalItemList.GridControl?.RefreshDataSource();
                entity.ProposalItemList.GridView.ExpandAllGroups();
            }
        }


        public MMProposalItemsInfo ToProposalItemFromSaleOrderItem(ARSaleOrderItemsInfo objSaleOrderItemsInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objSaleOrderItemsInfo.FK_ICProductID);
            if (objProductsInfo == null)
                objProductsInfo = new ICProductsInfo();
            return new MMProposalItemsInfo
            {
                FK_ARSaleOrderID = objSaleOrderItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID,
                FK_ICProductGroupID = objSaleOrderItemsInfo.FK_ICProductGroupID,
                FK_ICMeasureUnitID = objSaleOrderItemsInfo.FK_ICMeasureUnitID,
                FK_ICProductAttributeHTTypeID = objProductsInfo.FK_ICProductAttributeFinishingID,
                FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID,
                FK_ICProductAttributeColorID = objSaleOrderItemsInfo.FK_ICProductAttributeColorID,
                FK_ICProductAttributeWoodTypeID = objSaleOrderItemsInfo.FK_ICProductAttributeWoodTypeID,
                MMProposalItemProductNo = objProductsInfo.ICProductNo,
                MMProposalItemProductName = objSaleOrderItemsInfo.ARSaleOrderItemProductName,
                MMProposalItemProductDesc = objSaleOrderItemsInfo.ARSaleOrderItemProductDesc,
                MMProposalItemProductHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeight,
                MMProposalItemProductWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth,
                MMProposalItemProductLength = objSaleOrderItemsInfo.ARSaleOrderItemLength,
                MMProposalItemProductAttributeHTType = objProductsInfo.ICProductAttributeFinishingText,
                MMProposalItemProductType = objProductsInfo.ICProductType,
                MMProposalItemProductMinLength = objSaleOrderItemsInfo.ARSaleOrderItemLengthMin,
                MMProposalItemProductMaxHeight = objSaleOrderItemsInfo.ARSaleOrderItemHeightMax,
                MMProposalItemStatus = MMProposalItemStatus.New.ToString(),
                MMProposalItemWoodTypeID = objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID,
                MMProposalItemColorID = objSaleOrderItemsInfo.ARSaleOrderItemColorID,
                MMProposalItemWoodTypeText = GetAttributeText(objSaleOrderItemsInfo.ARSaleOrderItemWoodTypeID),
                MMProposalItemProductAttributeColor = GetAttributeText(objSaleOrderItemsInfo.ARSaleOrderItemColorID),
                MMProposalItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice,
                MMProposalItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemProductRemainedQty,
                MMProposalItemTotalAmount = (objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty) * objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice,
                MMProposalItemDeliveryDate = objSaleOrderItemsInfo.ARSaleOrderItemDeliveryDate,
            };
        }

        /// <summary>
        /// Convert to proposal items info
        /// </summary>
        /// <param name="saleOrderItem"></param>
        /// <returns></returns>
        private MMProposalItemsInfo ConvertToBatchProposalItemsInfo(ARSaleOrderItemsInfo saleOrderItem)
        {
            MMProposalItemsInfo proposalItem = new MMProposalItemsInfo();
            ICProductsController objProductsController = new ICProductsController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            if (saleOrderItem.FK_ARSaleOrderID > 0)
            {
                objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(saleOrderItem.FK_ARSaleOrderID);
            }
            proposalItem.FK_ARSaleOrderID = saleOrderItem.FK_ARSaleOrderID;
            proposalItem.FK_ARSaleOrderItemID = saleOrderItem.ARSaleOrderItemID;
            proposalItem.FK_ICProductID = saleOrderItem.FK_ICProductID;
            proposalItem.MMProposalItemStatus = MMProposalItemStatus.New.ToString();
            proposalItem.MMProposalItemProductDesc = saleOrderItem.ARSaleOrderItemProductDesc;
            proposalItem.MMProposalItemProductName = saleOrderItem.ARSaleOrderItemProductName;
            proposalItem.FK_ICMeasureUnitID = saleOrderItem.FK_ICMeasureUnitID;

            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(saleOrderItem.FK_ICProductID);
            if (objProductsInfo != null)
                proposalItem.MMProposalItemProductNo = objProductsInfo.ICProductNo;

            proposalItem.MMProposalItemProductQty = (int)saleOrderItem.ARSaleOrderItemProductQty;
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(proposalItem.FK_ICProductID);
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
                    proposalItem.MMProposalItemProductQty = Math.Round(proposalItem.MMProposalItemProductQty, 4, MidpointRounding.AwayFromZero);
                }
            }
            return proposalItem;
        }

        /// <summary>
        /// Has exist in list
        /// </summary>
        /// <param name="saleOrderItem"></param>
        /// <returns></returns>
        private bool HasExistInTheList(ARSaleOrderItemsInfo saleOrderItem)
        {
            bool hasExist = false;

            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            IEnumerable<MMProposalItemsInfo> foundItem = entity.ProposalItemList.Where(
                                                        batItem => batItem.FK_ARSaleOrderID == saleOrderItem.FK_ARSaleOrderID
                                                        && batItem.FK_ICProductID == saleOrderItem.FK_ICProductID);

            if (foundItem != null && foundItem.Any())
                hasExist = true;

            return hasExist;
        }



        /// <summary>
        /// Add saleorder items to batch proposal item list
        /// </summary>
        /// <param name="saleOrderItems"></param>
        private void AddSaleOrderItemsToBatchProposalItemList(List<ARSaleOrderItemsInfo> saleOrderItems)
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            if (saleOrderItems != null)
            {
                foreach (ARSaleOrderItemsInfo saleOrderItem in saleOrderItems)
                {
                    //bool hasExist = HasExistInTheList(saleOrderItem);
                    MMProposalItemsInfo proposalItem = ConvertToBatchProposalItemsInfo(saleOrderItem);
                    entity.ProposalItemList.Add(proposalItem);
                }
                entity.ProposalItemList.GridControl?.RefreshDataSource();
            }
        }

        /// <summary>
        /// Remove batch proposal item list
        /// </summary>
        public void RemoveBatchItemList()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalItemsInfo objProposalItemsInfo = entity.ProposalItemList[entity.ProposalItemList.CurrentIndex];
            entity.ProposalItemList.RemoveSelectedRowObjectFromList();
        }

        /// <summary>
        /// Check proposal item product qty
        /// </summary>
        /// <param name="objProposalItemInfo">objProposalItemInfo</param>
        /// <returns>true/false</returns>
        public bool CheckProposalItemProductQty(MMProposalItemsInfo objProposalItemInfo, List<MMProposalItemsInfo> ListProposalItemsOld)
        {
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();

            if (objProposalItemInfo.FK_ARSaleOrderItemID > 0)
            {
                List<MMProposalItemsInfo> ListItemOld = ListProposalItemsOld.Where(x => x.FK_ARSaleOrderItemID == objProposalItemInfo.FK_ARSaleOrderItemID).ToList();
                if (ListItemOld != null && ListItemOld.Count > 0)
                {
                    decimal qtyProposal = ListItemOld.Where(x => x.MMProposalItemProductQty > 0 && x.MMProposalItemID != objProposalItemInfo.MMProposalItemID).Sum(x => x.MMProposalItemProductQty);
                    decimal saleOrderItemProductQty = ListItemOld[0].ARSaleOrderItemProductQty - ListItemOld[0].ARSaleOrderItemCanceledQty;
                    //TNDLoc [ADD][19/05/2016][Round Paint/Wood 4],START
                    if (ListItemOld[0].ICProductType == ProductType.IngredientPaint.ToString() ||
                           ListItemOld[0].ICProductType == ProductType.Roundwood.ToString() ||
                           ListItemOld[0].ICProductType == ProductType.Reuse.ToString() ||
                           ListItemOld[0].ICProductType == ProductType.Lumber.ToString() ||
                           ListItemOld[0].ICProductType == ProductType.ArtificialBoard.ToString() ||
                           ListItemOld[0].ICProductType == ProductType.Verneer.ToString() ||
                           ListItemOld[0].ICProductType == ProductType.ArtificialBoard.ToString())
                    {
                        if (Math.Round(objProposalItemInfo.MMProposalItemProductQty, 4, MidpointRounding.AwayFromZero) > Math.Round(saleOrderItemProductQty - qtyProposal, 4, MidpointRounding.AwayFromZero))
                        {
                            BOSApp.ShowMessage("Số lượng của sản phẩm '" + objProposalItemInfo.MMProposalItemProductDesc + "' lớn hơn số lượng đơn bán hàng!" + Environment.NewLine + " * "
                                                                        + "Số lượng đơn bán hàng: " + saleOrderItemProductQty.ToString("n4") + Environment.NewLine + " * "
                                                                        + "Số lượng đã đề nghị: " + qtyProposal.ToString("n4") + Environment.NewLine + " * "
                                                                        + "Số lượng có thể đề nghị: " + (saleOrderItemProductQty - qtyProposal).ToString("n4")
                                    );
                            return false;
                        }
                    }
                    else
                    {
                        if (objProposalItemInfo.MMProposalItemProductQty > saleOrderItemProductQty - qtyProposal)
                        {
                            BOSApp.ShowMessage("Số lượng của sản phẩm '" + objProposalItemInfo.MMProposalItemProductDesc + "' lớn hơn số lượng đơn bán hàng!" + Environment.NewLine + " * "
                                                                       + "Số lượng đơn bán hàng: " + saleOrderItemProductQty.ToString("n5") + Environment.NewLine + " * "
                                                                       + "Số lượng đã đề nghị: " + qtyProposal.ToString("n5") + Environment.NewLine + " * "
                                                                       + "Số lượng có thể đề nghị: " + (saleOrderItemProductQty - qtyProposal).ToString("n5")
                                   );
                            return false;
                        }
                    }

                }
            }
            return true;
        }

        public string CheckProductActive(MMProposalItemsInfo objProposalItemInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            if (objProposalItemInfo.FK_ICProductID > 0)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProposalItemInfo.FK_ICProductID);
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
        /// Check rtf string contains table and expression or not
        /// </summary>
        /// <param name="rtf">Rtf string</param>
        /// <returns>True or false</returns>
        public bool IsContainTableAndExpression(string rtf)
        {
            if (rtf.Contains(StartRow))
            {
                if (rtf.Contains(ExpressionString))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddProposalTemplate()
        {
            BOSTextBox filePathTextBox = (BOSTextBox)Controls[BatchProposalModule.FilePathTextBoxName];
            if (string.IsNullOrEmpty(filePathTextBox.Text))
                return;

            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            if (entity.ProposalTemplatesList.Exists(o => o.MMProposalTemplateName.Equals(DocumentFileName)))
            {
                MessageBox.Show(MESLocalizedResources.DuplicateFileName,
                                MESLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            MMProposalTemplatesInfo objProposalTemplatesInfo = new MMProposalTemplatesInfo();
            objProposalTemplatesInfo.MMProposalTemplateName = DocumentFileName;
            objProposalTemplatesInfo.FK_MMProposalID = objProposalInfo.MMProposalID;
            objProposalTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
            objProposalTemplatesInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objProposalTemplatesInfo.FullPathFile = filePathTextBox.Text.Trim();
            entity.ProposalTemplatesList.Add(objProposalTemplatesInfo);
            entity.ProposalTemplatesList.GridControl?.RefreshDataSource();
        }
        /// <summary>
        /// Save proposal document file on server
        /// </summary>
        //public void SaveProposalDocumentOnServer()
        //{
        //    BOSTextBox filePathTextBox = (BOSTextBox)Controls[BatchProposalModule.FilePathTextBoxName];
        //    if (!String.IsNullOrEmpty(filePathTextBox.Text))
        //    {
        //        bool flag = true;
        //        MMProposalsInfo objProposalInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
        //        string objectID = objProposalInfo.MMProposalID.ToString();
        //        string newFileName = objProposalInfo.MMProposalID.ToString() + "_" + DocumentFileName;
        //        foreach (MMProposalTemplatesInfo objProposalTemplatesInfo1 in ((BatchProposalEntities)CurrentModuleEntity).ProposalTemplatesList)
        //        {
        //            if (objProposalTemplatesInfo1.MMProposalTemplateName == DocumentFileName)
        //            {
        //                if (MessageBox.Show(BatchProposalLocalizeResources.ConfirmOverrideFile, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //                {
        //                    if (BOSApp.UploadFileFTP(objectID, filePathTextBox.Text.Trim(), SubFolder))
        //                    {
        //                        MessageBox.Show(BatchProposalLocalizeResources.UploadFileSuccessfullyMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        InvalidateTemplateGridControl();
        //                    }
        //                    flag = false;
        //                    break;
        //                }
        //                else
        //                {
        //                    flag = false;
        //                    break;
        //                }
        //            }
        //        }
        //        if (flag)
        //        {
        //            if (BOSApp.UploadFileFTP(objectID, filePathTextBox.Text.Trim(), SubFolder))
        //            {
        //                BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
        //                MMProposalTemplatesInfo objProposalTemplatesInfo = new MMProposalTemplatesInfo();
        //                objProposalTemplatesInfo.MMProposalTemplateName = newFileName;
        //                entity.SaveTemplate(objProposalTemplatesInfo);
        //                entity.ProposalTemplatesList.SetDefaultListAndRefreshGridControl();
        //                entity.ProposalTemplatesList.GridControl.RefreshDataSource();
        //                MessageBox.Show(BatchProposalLocalizeResources.UploadFileSuccessfullyMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                InvalidateTemplateGridControl();
        //            }
        //        }
        //    }
        //}

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)entity.MainObject;
            if (objProposalsInfo.MMProposalID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                if (objProposalsInfo.MMProposalBatchStatus == MMProposalBatchStatus.Approved.ToString()
                    || objProposalsInfo.MMProposalBatchStatus == MMProposalBatchStatus.Canceled.ToString()
                    || objProposalsInfo.MMProposalBatchStatus == MMProposalBatchStatus.InProcess.ToString()
                    || objProposalsInfo.MMProposalBatchStatus == MMProposalBatchStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }

                if (objProposalsInfo.MMProposalBatchStatus == MMProposalBatchStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton("ApproveBatchProposal", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApproveBatchProposal", false);
                    ParentScreen.SetEnableOfToolbarButton("DiscardVoucher", false);
                }
            }
        }

        public override void ActionEdit()
        {
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            Invalidate(objProposalsInfo.MMProposalID);
            MMProposalsInfo objProposalsInfoTemp = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            if (objProposalsInfoTemp.MMProposalID > 0 && objProposalsInfoTemp.MMProposalBatchStatus == SaleOrderStatus.New.ToString())
            {
                base.ActionEdit();
            }
        }

        public void InvalidateTemplateGridControl()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
            entity.ProposalTemplatesList.Invalidate(objProposalsInfo.MMProposalID);
            foreach (MMProposalTemplatesInfo objProposalTemplatesInfo in entity.ProposalTemplatesList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objBaseTransactionModule.GetEmployeeByUsername(objProposalTemplatesInfo.AACreatedUser);
                string proposalID = objProposalTemplatesInfo.FK_MMProposalID.ToString();
                objProposalTemplatesInfo.MMProposalTemplateName = objProposalTemplatesInfo.MMProposalTemplateName.Replace(proposalID + "_", "");
                objProposalTemplatesInfo.UserCreatedFullname = objEmployeesInfo.HREmployeeName;
            }
            BatchProposalTemplateGridControl?.RefreshDataSource();
        }


        /// <summary>
        /// View proposal document file 
        /// </summary>
        public void ViewFile()
        {
            try
            {
                GridView gridView = (GridView)BatchProposalTemplateGridControl.MainView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    MMProposalsInfo objProposalInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
                    string objectID = objProposalInfo.MMProposalID.ToString();
                    MMProposalTemplatesInfo objProposalTemplatesInfo = (MMProposalTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    string proposalTemplateName = string.Empty;
                    proposalTemplateName += objectID + "_" + objProposalTemplatesInfo.MMProposalTemplateName.ToString();
                    System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string localPath = BOSApp.DownloadFileFTP(proposalTemplateName, SubFolder);
                    if (!string.IsNullOrEmpty(localPath))
                    {
                        System.Diagnostics.Process.Start(localPath);
                    }
                }
            }
            catch
            {
                MessageBox.Show(BatchProposalLocalizeResources.SelectTemplateToView, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        /// <summary>
        /// Delete proposal document file 
        /// </summary>
        public void DeleteFile()
        {
            try
            {
                GridView gridView = (GridView)BatchProposalTemplateGridControl.MainView;
                if (gridView.FocusedRowHandle >= 0)
                {
                    if (MessageBox.Show(BatchProposalLocalizeResources.ConfirmDeleteFile, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MMProposalsInfo objProposalInfo = (MMProposalsInfo)CurrentModuleEntity.MainObject;
                        string objectID = objProposalInfo.MMProposalID.ToString();
                        MMProposalTemplatesInfo objProposalTemplatesInfo = (MMProposalTemplatesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        string proposalTemplateName = string.Empty;
                        proposalTemplateName += objectID + "_" + objProposalTemplatesInfo.MMProposalTemplateName.ToString();
                        System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        BOSApp.DeleteFile(proposalTemplateName, SubFolder);
                        BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
                        entity.ProposalTemplatesList.Remove(objProposalTemplatesInfo);
                        entity.ProposalTemplatesList.SaveItemObjects();
                        BatchProposalTemplateGridControl?.RefreshDataSource();
                    }
                }
            }
            catch
            {
                MessageBox.Show(BatchProposalLocalizeResources.SelectTemplateToView, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Browse proposal document file 
        /// </summary>
        public void BrowseFile()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Save file as...";
            dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            BOSTextBox filePathTextBox = (BOSTextBox)Controls[BatchProposalModule.FilePathTextBoxName];
            filePathTextBox.Text = dialog.FileName;
            DocumentFileName = dialog.SafeFileName;
        }


        //[TTLoi][Add Document][06/11/2014] END

        //[TKChinh][Add][27/05/2016]
        public void ConfirmChangeItem(string fileName, bool value)
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)entity.MainObject;
            if (entity.ProposalItemList.Count > 0)
            {
                if (MessageBox.Show(MESLocalizedResources.ConfirmChangeItemMessage, MESLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (fileName == "MMProposalItemIsNewProduct")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemIsNewProduct = value;
                        }
                    }
                    if (fileName == "MMProposalItemIsJoinComponent")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemIsJoinComponent = value;
                        }
                    }
                    if (fileName == "MMProposalItemProductBarcode")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemProductBarcode = value;
                        }
                    }
                    if (fileName == "MMProposalItemProductHDLR")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemProductHDLR = value;
                        }
                    }
                    if (fileName == "MMProposalItemProductHDSD")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemProductHDSD = value;
                        }
                    }
                    if (fileName == "MMProposalItemProductLabel")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemProductLabel = value;
                        }
                    }
                    if (fileName == "MMProposalItemLabelCorlor")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemLabelCorlor = value;
                        }
                    }
                    if (fileName == "MMProposalItemProductWarranty")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemProductWarranty = value;
                        }
                    }
                    if (fileName == "MMProposalItemProductCard")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemProductCard = value;
                        }
                    }
                    if (fileName == "MMProposalItemProductFSCCard")
                    {
                        foreach (MMProposalItemsInfo objProposalItemsInfo in entity.ProposalItemList)
                        {
                            objProposalItemsInfo.MMProposalItemProductFSCCard = value;
                        }
                    }
                    entity.ProposalItemList.GridControl?.RefreshDataSource();
                }
            }
        }

        //[TKChinh] [End]

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            MMProposalsController objProposalController = new MMProposalsController();
            MMProposalsInfo searchObject = CurrentModuleEntity.SearchObject as MMProposalsInfo;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = new DataSet();

            ds = objProposalController.GetBatchProposalDataSet(searchObject.MMProposalNo,
                                                    searchObject.MMProposalName,
                                                    searchObject.MMProposalType,
                                                    objObjectsInfo.ACObjectID,
                                                    objObjectsInfo.ACObjectType,
                                                    searchObject.FK_ARSaleOrderID,
                                                    searchObject.FK_HREmployeeID,
                                                    searchObject.MMProposalBatchStatus,
                                                    searchObject.MMProposalDateFrom,
                                                    searchObject.MMProposalDateTo);
            return ds;
        }

        public void ChangeObject(String acAssetKey)
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)entity.MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acAssetKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            objProposalsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
            objProposalsInfo.MMObjectType = objObjectsInfo.ACObjectType;
            objProposalsInfo.ACObjectName = objObjectsInfo.ACObjectName;
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeItemTotalAmount()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            if (entity.ProposalItemList.CurrentIndex < 0)
                return;
            MMProposalItemsInfo objProposalItemsInfo = entity.ProposalItemList[entity.ProposalItemList.CurrentIndex];
            objProposalItemsInfo.MMProposalItemTotalAmount = objProposalItemsInfo.MMProposalItemProductQty * objProposalItemsInfo.MMProposalItemProductUnitPrice;
            entity.ProposalItemList.GridControl?.RefreshDataSource();
        }

        public void DiscardVoucher()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)entity.MainObject;
            if (!Toolbar.IsNullOrNoneAction() && !(Toolbar.CurrentObjectID > 0))
                return;
            DialogResult rs = MessageBox.Show(MESLocalizedResources.DiscardVoucherMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs != DialogResult.Yes)
                return;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            int count = objBatchProductsController.GetCountBatchProductByBatchProposalID(objProposalsInfo.MMProposalID);
            if (count > 0)
            {
                MessageBox.Show(MESLocalizedResources.DiscardVoucherErrorMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MMProposalsController objProposalsController = new MMProposalsController();
            entity.SetPropertyChangeEventLock(false);
            objProposalsInfo.MMProposalBatchStatus = ProposalStatus.Canceled.ToString();
            if (objProposalsInfo.FK_ARSaleOrderID != 0)
            {
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    objSaleOrdersInfo.ARSaleOrderBatchStatus = string.Empty;
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
                }
            }
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        public void RemoveProposalTemplateList()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            entity.ProposalTemplatesList.RemoveSelectedRowObjectFromList();
            entity.ProposalTemplatesList.GridControl?.RefreshDataSource();
        }

        public void UpdateProposalSaleOrderDeliveryDate()
        {
            BatchProposalEntities entity = (BatchProposalEntities)CurrentModuleEntity;
            MMProposalsInfo mainobject = (MMProposalsInfo)entity.MainObject;
            DialogResult rs = MessageBox.Show("Bạn có muốn thay đổi ngày giao cho toàn bộ sản phẩm không?", BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            entity.ProposalItemList.ForEach(o =>
            {
                o.MMProposalItemDeliveryDate = mainobject.MMProposalSaleOrderDeliveryDate;
            });
            entity.ProposalItemList.GridControl?.RefreshDataSource();
        }
    }
}

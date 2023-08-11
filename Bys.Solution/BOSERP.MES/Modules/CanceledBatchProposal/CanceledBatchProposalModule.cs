using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Modules.BatchProposal.Localization;
using BOSLib;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CanceledBatchProposal
{
    public partial class CanceledBatchProposalModule : BaseModuleERP
    {
        #region Constants

        #endregion

        #region Property
        #endregion
        public CanceledBatchProposalModule()
        {
            Name = "CanceledBatchProposal";
            CurrentModuleEntity = new CanceledBatchProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            //EnableToolbar();
        }



        public override void ActionNew()
        {
            base.ActionNew();
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)CurrentModuleEntity.MainObject;
            objCanceledProposalsInfo.MMCanceledProposalBatchStatus = MMProposalBatchStatus.New.ToString();
            objCanceledProposalsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objCanceledProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            ShowProposals();
            //SetReadonlyQuantity(true);
        }

        /// <summary>
        /// Get config text by group and value
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public string GetConfigTextByGroupAndValue(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }
        /// <summary>
        /// Approved batch proposal
        /// </summary>
        public void ApproveCanceledBatchProposal()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)CurrentModuleEntity.MainObject;
            entity.ApproveProposal();
            UpdateProposalItemStatus();
            EnableToolbar();
        }

        public void UpdateProposalItemStatus()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)entity.MainObject;
            //Update SaleOrder batch status
            MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
            MMProposalItemsInfo objProposalItemsInfo = new MMProposalItemsInfo();
            foreach (MMCanceledProposalItemsInfo item in entity.CanceledProposalItemList)
            {
                objProposalItemsInfo = (MMProposalItemsInfo)objProposalItemsController.GetObjectByID(item.FK_MMProposalItemID);
                if (objProposalItemsInfo != null)
                {
                    if (item.MMCanceledProposalItemProductQty == (objProposalItemsInfo.MMProposalItemProductQty - objProposalItemsInfo.MMProposalItemProductCanceledQty))
                    {
                        objProposalItemsInfo.MMProposalItemStatus = ProposalItemStatus.Canceled.ToString();
                    }
                    objProposalItemsInfo.MMProposalItemProductCanceledQty += item.MMCanceledProposalItemProductQty;
                    objProposalItemsController.UpdateObject(objProposalItemsInfo);
                }
            }
            List<MMProposalItemsInfo> proposalItemList = objProposalItemsController.GetProposalItemsByProposalID(objCanceledProposalsInfo.FK_MMProposalID);
            MMProposalsController objProposalsController = new MMProposalsController();
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)objProposalsController.GetObjectByID(objCanceledProposalsInfo.FK_MMProposalID);
            string status = objProposalsInfo.MMProposalBatchStatus;
            foreach (MMProposalItemsInfo item in proposalItemList)
            {
                if (item.MMProposalItemStatus != ProposalItemStatus.Canceled.ToString())
                {
                    if (objProposalsInfo != null)
                    {
                        objProposalsInfo.MMProposalBatchStatus = status;
                    }
                    break;
                }
                else
                {
                    if (objProposalsInfo != null)
                    {
                        objProposalsInfo.MMProposalBatchStatus = ProposalItemStatus.Canceled.ToString();
                    }
                }
            }
            objProposalsController.UpdateObject(objProposalsInfo);
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)CurrentModuleEntity.MainObject;
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objCanceledProposalsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null)
            {
                objCanceledProposalsInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
            }
            EnableToolbar();
            entity.UpdateMainObjectBindingSource();
        }

        public override int ActionSave()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            entity.CanceledProposalItemList.EndCurrentEdit();
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)CurrentModuleEntity.MainObject;
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objCanceledProposalsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null && objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.Canceled.ToString())
            {
                MessageBox.Show(BatchProposalLocalizeResources.ProposalApproveErrror,
                                  MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            int result = base.ActionSave();
            EnableToolbar();
            return result;
        }
        public void EnableToolbar()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            MMCanceledProposalsInfo objCanceledBatchProposalsInfo = (MMCanceledProposalsInfo)entity.MainObject;
            string status = objCanceledBatchProposalsInfo.MMCanceledProposalBatchStatus;
            ParentScreen.SetEnableOfToolbarButton(CanceledbatchProposal.ApproveCanceledBatchProposal, false);

            //New
            if (status == MMProposalItemStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(CanceledbatchProposal.ApproveCanceledBatchProposal, true);
            }
            //Approved
            if (status == MMProposalItemStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(CanceledbatchProposal.ApproveCanceledBatchProposal, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }
            //}
        }
        /// <summary>
        /// Show saleorder form
        /// </summary>
        public void ShowProposals()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)entity.MainObject;
            MMProposalsInfo objProposalsInfo = new MMProposalsInfo();
            MMProposalsController objProposalsController = new MMProposalsController();
            MMProposalItemsInfo objProposalItemsInfo = new MMProposalItemsInfo();
            MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<MMProposalItemsInfo> proposalList = objProposalItemsController.GetProposalItemsNotInBatchProductItems();

            guiFind<MMProposalItemsInfo> guiFind = new guiFind<MMProposalItemsInfo>(TableName.MMProposalItemsTableName,
                                                                                             proposalList,
                                                                                             this,
                                                                                             true,
                                                                                             true,
                                                                                             new string[] { "MMProposalNo" }
                                                                                             );
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                List<MMProposalItemsInfo> proposalItem = (List<MMProposalItemsInfo>)guiFind.SelectedObjects;
                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    proposalList = proposalItem.Where(x => x.FK_MMProposalID != guiFind.SelectedObjects[0].FK_MMProposalID).ToList();
                }
                if (proposalList != null && proposalList.Count > 0)
                {
                    MessageBox.Show(CanceledProposalLocalizedResources.ChooseMultiProposal,
                                    MESLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    ShowProposals();
                    //ActionCancel();
                }
                else
                {
                    objProposalsInfo = (MMProposalsInfo)objProposalsController.GetObjectByID(guiFind.SelectedObjects[0].FK_MMProposalID);
                    if (objProposalsInfo != null)
                    {
                        objCanceledProposalsInfo.MMCanceledProposalPONo = objProposalsInfo.MMProposalPONo;
                        objCanceledProposalsInfo.FK_ARCustomerID = objProposalsInfo.FK_ARCustomerID;
                        objCanceledProposalsInfo.FK_MMOperationID = objProposalsInfo.FK_MMOperationID;
                        objCanceledProposalsInfo.FK_ARSaleOrderID = objProposalsInfo.FK_ARSaleOrderID;
                        objCanceledProposalsInfo.MMCanceledProposalDesc = objProposalsInfo.MMProposalDesc;
                        objCanceledProposalsInfo.FK_MMProposalID = objProposalsInfo.MMProposalID;
                        objCanceledProposalsInfo.FK_ICProductAttributeTTMTID = objProposalsInfo.FK_ICProductAttributeTTMTID;
                        ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
                        if (objSaleOrdersInfo != null)
                        {
                            objCanceledProposalsInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
                        }
                        entity.UpdateMainObjectBindingSource();
                    }
                    foreach (MMProposalItemsInfo item in guiFind.SelectedObjects)
                    {
                        GetSelectedItemFromProposalItems(item);
                    }
                }
                entity.CanceledProposalItemList.GridControl?.RefreshDataSource();
            }
            else
            {
                base.ActionCancel();
            }
        }

        public void GetSelectedItemFromProposalItems(MMProposalItemsInfo objProposalItemsInfo)
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            if (objProposalItemsInfo != null)
            {
                MMCanceledProposalItemsInfo objCanceledProposalItemsInfo = new MMCanceledProposalItemsInfo();
                BOSUtil.CopyObject(objProposalItemsInfo, objCanceledProposalItemsInfo);
                objCanceledProposalItemsInfo.FK_MMProposalItemID = objProposalItemsInfo.MMProposalItemID;
                entity.CanceledProposalItemList.Add(objCanceledProposalItemsInfo);
            }

        }
        public bool IsValidCanceledQty(MMCanceledProposalItemsInfo item, decimal qty)
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            MMCanceledProposalItemsInfo objPurchaseOrderItemsInfo = new MMCanceledProposalItemsInfo();
            MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
            List<MMProposalItemsInfo> proposalItemsList = objProposalItemsController.GetProposalItemsForCheckingRemainProposalValidQty(item.FK_MMProposalItemID, item.MMCanceledProposalItemID);
            decimal remainQty = 0;
            if (proposalItemsList != null && proposalItemsList.Count > 0)
            {
                remainQty = proposalItemsList.Sum(i => i.MMProposalItemProductQty);
            }
            if (qty > remainQty)
            {
                return false;
            }
            return true;
        }
        public void ChangeItemFromCancelProposalItemList()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            entity.CanceledProposalItemList.ChangeObjectFromList();
        }
        public void RemoveCanceledProposalItemList()
        {
            CanceledBatchProposalEntities entity = (CanceledBatchProposalEntities)CurrentModuleEntity;
            entity.CanceledProposalItemList.RemoveSelectedRowObjectFromList();
        }
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
        }

    }
}

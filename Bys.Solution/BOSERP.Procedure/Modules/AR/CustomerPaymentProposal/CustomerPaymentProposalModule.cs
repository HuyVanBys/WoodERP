using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.CustomerPaymentProposal
{
    public class CustomerPaymentProposalModule : BaseTransactionModule
    {

        #region Constants

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string PaymentProposalItemsGridControlName = "fld_dgcARPaymentProposalItems";
        public const string SelectPaymentTermButtonName = "fld_btnSelectPaymentTerm";
        public const string ACObjectLookupControlName = "fld_lkeFK_ACObjectID";
        public const string HyperlinkChooseProspectCustomerName = "fld_lnkChooseProspectCustomer";
        #endregion

        #region Public properties
        List<string> listControlName;

        public List<BRBranchsInfo> BranchList;

        public BOSLookupEdit SearchBranchLookupEditControl;

        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;

        public ARPaymentProposalItemsGridControl PaymentProposalItemsGridControl;

        public BOSButton SelectPaymentTermButton;

        public BOSLookupEdit ACObjectLookupEdit;
        public HyperLinkEdit HyperLinkEditChooseProspectCustomer;
        #endregion

        public CustomerPaymentProposalModule()
        {

            Name = "CustomerPaymentProposal";
            CurrentModuleEntity = new CustomerPaymentProposalEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();

            listControlName = new List<string>();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CustomerPaymentProposalModule.SearchBranchLookupEditControlName];
            PaymentProposalItemsGridControl = (ARPaymentProposalItemsGridControl)Controls[CustomerPaymentProposalModule.PaymentProposalItemsGridControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            SelectPaymentTermButton = (BOSButton)Controls[SelectPaymentTermButtonName];
            ACObjectLookupEdit = (BOSLookupEdit)Controls[CustomerPaymentProposalModule.ACObjectLookupControlName];
            HyperLinkEditChooseProspectCustomer = (HyperLinkEdit)Controls[HyperlinkChooseProspectCustomerName];
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

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARPaymentProposalsController paymentProposalController = new ARPaymentProposalsController();
            ARPaymentProposalsInfo searchObject = (ARPaymentProposalsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACAssObjectAccessKey);
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = paymentProposalController.GetDataSetByID(-1);
                }
                else
                {

                    ds = paymentProposalController.GetPaymentProposalsByListOfBranchID(searchObject.ARPaymentProposalNo,
                                                                                    searchObject.FK_HREmployeeID,
                                                                                    searchObject.ARPaymentProposalTypeCombo,
                                                                                    searchObject.FK_HRDepartmentID,
                                                                                    objObjectsInfo.ACObjectID,
                                                                                    objObjectsInfo.ACObjectType,
                                                                                    searchObject.ARPaymentProposalStatusCombo,
                                                                                    searchObject.ARPriority,
                                                                                    searchObject.PaymentProposalDateFrom,
                                                                                    searchObject.PaymentProposalDateTo,
                                                                                    BranchList);
                }
            }
            else
            {
                ds = paymentProposalController.GetPaymentProposalsByBranchID(searchObject.ARPaymentProposalNo,
                                                                                    searchObject.FK_HREmployeeID,
                                                                                    searchObject.ARPaymentProposalTypeCombo,
                                                                                    searchObject.FK_HRDepartmentID,
                                                                                    objObjectsInfo.ACObjectID,
                                                                                    objObjectsInfo.ACObjectType,
                                                                                    searchObject.ARPaymentProposalStatusCombo,
                                                                                    searchObject.ARPriority,
                                                                                    searchObject.PaymentProposalDateFrom,
                                                                                    searchObject.PaymentProposalDateTo,
                                                                                    searchObject.FK_BRBranchID);
            }
            return ds;
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)entity.MainObject;

            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            ParentScreen.SetEnableOfToolbarButton("Approve", true);
            ParentScreen.SetEnableOfToolbarButton("Reject", true);
            ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", true);
            if (objPaymentProposalsInfo.ARPaymentProposalStatusCombo == PaymentProposalApproveStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("Reject", true);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                if (Toolbar.IsNewAction() || Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton("Reject", false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }
            if (objPaymentProposalsInfo.ARPaymentProposalStatusCombo == PaymentProposalApproveStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton("Reject", true);
                ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }

            if (objPaymentProposalsInfo.ARPaymentProposalStatusCombo == PaymentProposalApproveStatus.Canceled.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("Reject", false);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }

            if (objPaymentProposalsInfo.ARPaymentProposalStatusCombo == PaymentProposalApproveStatus.Checked.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("Reject", true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton("CheckedPaymentProposal", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            }
        }

        public void ResetAmount()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalItemsInfo item = (ARPaymentProposalItemsInfo)entity.ModuleObjects[TableName.ARPaymentProposalItemsTableName];

            item.ARPaymentProposalItemRemainAmount = item.ARPaymentProposalItemTotalAmount - item.ARPaymentProposalItemPaidAmount;
        }

        /// <summary>
        /// Approve PaymentProposal
        /// </summary>
        public void ConfirmPaymentProposal()
        {
            if (IsEditable())
                ActionEdit();
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)entity.MainObject;

            if (objPaymentProposalsInfo != null)
            {
                objPaymentProposalsInfo.FK_HREmployeeHeadDepartmentID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objPaymentProposalsInfo.ARPaymentProposalConfirmDate = DateTime.Now;
                objPaymentProposalsInfo.ARPaymentProposalStatusCombo = PaymentProposalStatus.Confirmed.ToString();

            }
            //entity.UpdateMainObject();
            //entity.UpdateMainObjectBindingSource();
        }


        public void CheckedPaymentProposal()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objPaymentProposalsInfo.ARPaymentProposalStatusCombo = PaymentProposalApproveStatus.Checked.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);
            InvalidateToolbar();
        }

        /// <summary>
        /// Check PaymentProposal
        /// </summary>
        public void CheckPaymentProposal()
        {
            if (IsEditable())
                ActionEdit();
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)entity.MainObject;

            if (objPaymentProposalsInfo != null)
            {
                objPaymentProposalsInfo.FK_HREmployeeAccountantID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objPaymentProposalsInfo.ARPaymentProposalCheckDate = DateTime.Now;
                objPaymentProposalsInfo.ARPaymentProposalStatusCombo = PaymentProposalStatus.Checked.ToString();

            }
            //entity.UpdateMainObject();
            //entity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Add Item To PaymentProposalItemsList
        /// </summary>
        public void AddItemToPaymentProposalItemsList()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalItemsInfo item = (ARPaymentProposalItemsInfo)entity.ModuleObjects[TableName.ARPaymentProposalItemsTableName];

            ARPaymentProposalItemsInfo objPaymentProposalItemsInfo = new ARPaymentProposalItemsInfo();
            BOSUtil.CopyObject(item, objPaymentProposalItemsInfo);

            entity.PaymentProposalItemsList.AddObjectToList();
            entity.PaymentProposalItemsList.GridControl.RefreshDataSource();

        }

        /// <summary>
        /// Remove Item From PaymentProposalItemsList
        /// </summary>
        public void RemoveItemFromPaymentProposalItemsList()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalItemsInfo item = (ARPaymentProposalItemsInfo)entity.ModuleObjects[TableName.ARPaymentProposalItemsTableName];

            entity.PaymentProposalItemsList.RemoveSelectedRowObjectFromList();
        }


        public void EditItemPaymentProposalItemsList()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            entity.PaymentProposalItemsList.ChangeObjectFromList();
        }

        /// <summary>
        /// override ActionSave
        /// </summary>
        public override int ActionSave()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)entity.MainObject;
            ARInvoicesController objInvoiceInsController = new ARInvoicesController();
            //foreach (ARPaymentProposalItemsInfo item in entity.PaymentProposalItemsList)
            //{
            //    item.ARPaymentProposalItemRemainAmount = item.ARPaymentProposalItemProposalAmount;
            //}
            BOSList<ARPaymentProposalItemsInfo> paymentProposalItemList = (BOSList<ARPaymentProposalItemsInfo>)entity.PaymentProposalItemsList.Clone();
            if (paymentProposalItemList.Count() > 0)
                objPaymentProposalsInfo.ARPaymentProposalDesc = objPaymentProposalsInfo.ARPaymentProposalDesc.Replace("{0}", paymentProposalItemList[0].ARSaleOrderSaleAgreement);
            decimal totalAmount = 0, paidAmount = 0, remainAmount = 0;
            foreach (ARPaymentProposalItemsInfo item in paymentProposalItemList)
            {

                totalAmount += item.ARPaymentProposalItemTotalAmount;
                paidAmount += item.ARPaymentProposalItemPaidAmount;
                remainAmount += item.ARPaymentProposalItemRemainAmount;
            }
            objPaymentProposalsInfo.ARPaymentProposalTotalAmount = totalAmount;
            objPaymentProposalsInfo.ARPaymentProposalPaidAmount = paidAmount;
            objPaymentProposalsInfo.ARPaymentProposalRemainAmount = remainAmount;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objPaymentProposalsInfo.FK_ACAssObjectID, objPaymentProposalsInfo.ARAssObjectType);
            if (objObjectsInfo != null)
            {
                objPaymentProposalsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                objPaymentProposalsInfo.ARPaymentProposalDesc = objPaymentProposalsInfo.ARPaymentProposalDesc.Replace("{1}", objPaymentProposalsInfo.ACObjectName);
            }

            entity.UpdateMainObjectBindingSource();
            SelectPaymentTermButton.Visible = true;
            int objectID = base.ActionSave();
            CreateCustomer(objPaymentProposalsInfo);
            entity.UpdateMainObjectBindingSource();
            return objectID;
        }

        /// <summary>
        /// Print advance proposal report
        /// </summary>
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                //InitProposalReport();
            }
        }

        public string GetConfigTextByGroupAndValue(string group, string value)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objADConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(group, value);
            if (objADConfigValuesInfo != null)
                return objADConfigValuesInfo.ADConfigText;
            return string.Empty;
        }

        public void DeleteItemFromPaymentProposalItemsList()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            entity.PaymentProposalItemsList.RemoveSelectedRowObjectFromList();

        }

        #region Approve, Reject
        public void Approve()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo paymentProposal = (ARPaymentProposalsInfo)entity.MainObject;

            bool isComplete = base.ActionComplete();
            if (!isComplete)
                return;

            paymentProposal.ARPaymentProposalStatusCombo = PaymentProposalApproveStatus.Approved.ToString();

            foreach (ARPaymentProposalItemsInfo item in entity.PaymentProposalItemsList)
            {
                item.ARPaymentProposalItemApproveStatus = PaymentProposalApproveStatus.Approved.ToString();
            }
            entity.UpdateMainObject();
            entity.SaveModuleObjects();
            entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
            //InvalidateToolbar();

            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton("Reject", true);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            ActionCancel();
        }

        public void Reject()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo paymentProposal = (ARPaymentProposalsInfo)entity.MainObject;
            if (paymentProposal.ARPaymentProposalStatusCombo == PaymentProposalApproveStatus.New.ToString())
            {
                paymentProposal.ARPaymentProposalStatusCombo = PaymentProposalApproveStatus.Canceled.ToString();
                paymentProposal.ARPaymentProposalApproveStatus = PaymentProposalApproveStatus.Canceled.ToString();
                foreach (ARPaymentProposalItemsInfo item in entity.PaymentProposalItemsList)
                {
                    item.ARPaymentProposalItemApproveStatus = PaymentProposalApproveStatus.Canceled.ToString();
                }

                entity.UpdateMainObject();
                entity.SaveModuleObjects();
                entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
                //InvalidateToolbar();

                ParentScreen.SetEnableOfToolbarButton("Reject", false);
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ActionCancel();
            }
            else
            {
                ARCustomerPaymentTimePaymentsController objCustomerPaymentTimePaymentsController = new ARCustomerPaymentTimePaymentsController();
                List<ARCustomerPaymentTimePaymentsInfo> List = objCustomerPaymentTimePaymentsController.GetCustomerPaymentTimePaymentsByPaymentProposalID(paymentProposal.ARPaymentProposalID);
                if (List != null && List.Count > 0)
                {
                    MessageBox.Show(CustomerPaymentProposalLocalizedResources.PaymentTimeError, CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paymentProposal.ARPaymentProposalStatusCombo = PaymentProposalApproveStatus.Canceled.ToString();

                    foreach (ARPaymentProposalItemsInfo item in entity.PaymentProposalItemsList)
                    {
                        item.ARPaymentProposalItemApproveStatus = PaymentProposalApproveStatus.Canceled.ToString();
                    }

                    entity.UpdateMainObject();
                    entity.SaveModuleObjects();
                    entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
                    //InvalidateToolbar();

                    ParentScreen.SetEnableOfToolbarButton("Reject", false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ActionCancel();
                }
            }


        }
        //TNDLoc [ADD][24/06/2015][Issue Approve, Reject],END
        #endregion

        //TNDLoc [ADD][24/06/2015][Issue select Payment Term],START
        public void GetPaymentTerm()
        {
            ARPaymentProposalItemsController objPaymentProposalItemsController = new ARPaymentProposalItemsController();
            List<ARPaymentProposalItemsInfo> paymentProposalItemList = objPaymentProposalItemsController.GetPaymentProposalItemsForPaymentProposal();

            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo paymentProposal = (ARPaymentProposalsInfo)entity.MainObject;

            if (paymentProposal.FK_ACAssObjectID > 0)
            {
                paymentProposalItemList = paymentProposalItemList.Where(o => o.ACObjectID == paymentProposal.FK_ACAssObjectID && o.ACObjectType == paymentProposal.ARAssObjectType).ToList();
            }

            guiChoosePaymentProposalItem guiFind = new guiChoosePaymentProposalItem(paymentProposalItemList);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
                return;

            if (guiFind.SelectedObjects.Count() == 0)
                return;

            if (guiFind.SelectedObjects[0].ACObjectID != paymentProposal.FK_ACAssObjectID)
            {
                paymentProposal.FK_ACAssObjectID = guiFind.SelectedObjects[0].ACObjectID;
                paymentProposal.ARAssObjectType = guiFind.SelectedObjects[0].ACObjectType;
                paymentProposal.ACAssObjectAccessKey = paymentProposal.FK_ACAssObjectID + ";" + paymentProposal.ARAssObjectType;
            }

            foreach (ARPaymentProposalItemsInfo item in guiFind.SelectedObjects)
            {
                item.ARPaymentProposalItemProposalAmount = item.ARPaymentProposalItemRemainAmount;
                ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();
                ARSaleOrderPaymentTimesInfo objSaleOrderPaymentTimesInfo = (ARSaleOrderPaymentTimesInfo)objSaleOrderPaymentTimesController.GetObjectByID(item.FK_ARSaleOrderPaymentTimeID);
                if (objSaleOrderPaymentTimesInfo != null)
                {
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    paymentProposal.ARPaymentProposalPayDate = objSaleOrderPaymentTimesInfo.ARSaleOrderPaymentTimeDueDate;
                    paymentProposal.FK_ARSaleOrderID = objSaleOrderPaymentTimesInfo.FK_ARSaleOrderID;
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objSaleOrderPaymentTimesInfo.FK_ARSaleOrderID);
                    if (objSaleOrdersInfo != null)
                    {
                        item.FK_GECurrencyID = objSaleOrdersInfo.FK_GECurrencyID;
                    }
                }
                paymentProposal.FK_PMProjectID = item.FK_PMProjectID;

                BOSApp.RoundByCurrency(item, item.FK_GECurrencyID);
            }
            string paymentTimeRef = string.Join(",", guiFind.SelectedObjects.Where(o => o.FK_ARSaleOrderPaymentTimeID > 0)
                                                            .Select(o => o.FK_ARSaleOrderPaymentTimeID.ToString())
                                                            .ToArray());
            ARSaleOrderPaymentTimeTemplatesController objSOTemplatesController = new ARSaleOrderPaymentTimeTemplatesController();
            List<ARSaleOrderPaymentTimeTemplatesInfo> soPaymentTimeTemplateList = objSOTemplatesController.GetTemplateByPaymentTimeRef(paymentTimeRef);

            entity.UpdateMainObjectBindingSource();
            entity.PaymentProposalItemsList.Invalidate(guiFind.SelectedObjects);
            entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
            entity.SaleOrderPaymentTimeTemplateList.AddRange(soPaymentTimeTemplateList);
            entity.SaleOrderPaymentTimeTemplateList.GridControl.RefreshDataSource();
        }

        //TNDLoc [ADD][24/06/2015][Issue select Payment Term],END
        public bool CheckQtyChange()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            int index = entity.PaymentProposalItemsList.CurrentIndex;
            ARPaymentProposalItemsInfo currentPaymentProposalItem = entity.PaymentProposalItemsList[index];
            if (currentPaymentProposalItem != null)
            {
                if (currentPaymentProposalItem.ARPaymentProposalItemProposalAmount > currentPaymentProposalItem.ARPaymentProposalItemRemainAmount)
                {
                    if (SelectPaymentTermButton.Visible == true)
                    {
                        MessageBox.Show(PaymentProposalLocalizedResources.PaymentProposalCheckAmount, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    currentPaymentProposalItem.ARPaymentProposalItemRemainAmount = currentPaymentProposalItem.ARPaymentProposalItemProposalAmount;
                    currentPaymentProposalItem.ARPaymentProposalItemTotalAmount = currentPaymentProposalItem.ARPaymentProposalItemProposalAmount;
                }
            }
            BOSApp.RoundByCurrency(currentPaymentProposalItem, "ARPaymentProposalItemProposalAmount", currentPaymentProposalItem.FK_GECurrencyID);
            return true;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposals = (ARPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            List<ARPaymentProposalItemsInfo> paymentProposalItemList = entity.PaymentProposalItemsList;
            if (objPaymentProposals.FK_ACAssObjectID > 0)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objPaymentProposals.FK_ACAssObjectID, objPaymentProposals.ARAssObjectType);
                if (paymentProposalItemList != null)
                {
                    paymentProposalItemList.ForEach(o =>
                    {
                        o.ARCustomerName = objObjectsInfo.ACObjectName;
                        o.ACObjectName = objObjectsInfo.ACObjectName;
                    });
                }
            }
        }

        public string ChangeObject(string objectAccessKey)
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)CurrentModuleEntity.MainObject;

            if (objPaymentProposalsInfo.CustomersInfo != null && objPaymentProposalsInfo.CustomersInfo.FK_ARProspectCustomerID != 0)
            {
                MessageBox.Show(SaleOrderLocalizedResources.ObjectIsExistMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objPaymentProposalsInfo.ACAssObjectAccessKey = string.Empty;
                entity.UpdateMainObjectBindingSource();
                DisplayLabelText(objPaymentProposalsInfo);
                return string.Empty;
            }
            objPaymentProposalsInfo.ACAssObjectAccessKey = objectAccessKey;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objPaymentProposalsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                objPaymentProposalsInfo.ARAssObjectType = objObjectsInfo.ACObjectType;
                objPaymentProposalsInfo.FK_ACAssObjectID = objObjectsInfo.ACObjectID;
                if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                    objPaymentProposalsInfo.FK_ARCustomerID = objObjectsInfo.ACObjectID;
            }
            else
            {
                objPaymentProposalsInfo.FK_ACAssObjectID = 0;
                objPaymentProposalsInfo.ARAssObjectType = string.Empty;
                objPaymentProposalsInfo.ACObjectName = string.Empty;

            }
            entity.UpdateMainObjectBindingSource();
            return objPaymentProposalsInfo.ACAssObjectAccessKey;
        }

        public void ChangeEmployeeCreation(int employeeID)
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            objPaymentProposalsInfo.FK_HREmployeeID = employeeID;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objPaymentProposalsInfo.FK_HREmployeeID);
            if (objEmployeesInfo == null)
                return;
            objPaymentProposalsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
            objPaymentProposalsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
            entity.UpdateMainObjectBindingSource();
        }

        public void PrintPaymentProposal()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPPaymentProposalVoucher report = new RPPaymentProposalVoucher();
                InitPaymentProposalVoucherReport(report);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevReceiptVoucherPath, true);
                reviewer.Show();
            }
        }

        public void PrintAdvancePayment()
        {
            RPAdvancePaymentVoucher report = new RPAdvancePaymentVoucher();
            InitAdvancePaymentVoucherReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevReceiptVoucherPath, true);
            reviewer.Show();
        }

        public void PrintReferralPayment()
        {
            RPReferralPaymentVoucher report = new RPReferralPaymentVoucher();
            InitReferralPaymentVoucherReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevReceiptVoucherPath, true);
            reviewer.Show();
        }

        private void InitPaymentProposalVoucherReport(RPPaymentProposalVoucher report)
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            List<ARPaymentProposalItemsInfo> paymentProposalItemsList = entity.PaymentProposalItemsList.ToList();
            Boolean isFullVND = true;
            paymentProposalItemsList.ForEach(p =>
            {
                p.PaymentItemProposalAmountShowReport = p.FK_GECurrencyID == GECurrencyID.VND || p.FK_GECurrencyID == 0 ? Math.Round(p.ARPaymentProposalItemProposalAmount, 0, MidpointRounding.AwayFromZero).ToString("n0") : p.ARPaymentProposalItemProposalAmount.ToString("n2");
                if (p.FK_GECurrencyID != GECurrencyID.VND && p.FK_GECurrencyID != 0) isFullVND = false;
            });
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARPaymentProposalItemsInfo objPaymentProposalItemsInfo = paymentProposalItemsList.FirstOrDefault();
            if (objPaymentProposalItemsInfo == null)
                objPaymentProposalItemsInfo = new ARPaymentProposalItemsInfo();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objPaymentProposalItemsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo == null)
            {
                objSaleOrdersInfo = new ARSaleOrdersInfo();
            }
            objPaymentProposalItemsInfo.ARPaymentProposalDesc = objPaymentProposalsInfo.ARPaymentProposalDesc;
            objPaymentProposalItemsInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;

            ACObjectsController objACObjectsController = new ACObjectsController();
            ACObjectsInfo objACObjectsInfo = objACObjectsController.GetObjectByIDAndType(objSaleOrdersInfo.FK_ACObjectID, objSaleOrdersInfo.ARObjectType);
            report.bsACObjects.DataSource = objACObjectsInfo;

            CSCompanysController objCompanyController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanyController.GetObjectByID(1);
            report.bsCompanys.DataSource = objCompanysInfo;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            report.bsCompanyBanks.DataSource = (CSCompanyBanksInfo)objCompanyBanksController.GetAllBanks().FirstOrDefault(o => o.CSCompanyBankCode == BankCode.VCB1121103);

            XRLabel label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblSaleOrderPaymentTotal"];
            if (label != null)
            {
                label.Text = objPaymentProposalItemsInfo.ARPaymentProposalItemProposalAmount.ToString("n2");
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDate"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, objPaymentProposalsInfo.ARPaymentProposalDate.Day, objPaymentProposalsInfo.ARPaymentProposalDate.Month, objPaymentProposalsInfo.ARPaymentProposalDate.Year);
            }

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblProposalPaymentTitle1"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, objCompanysInfo.CSCompanyDesc);
            }
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblProposalPaymentTitle2"];
            if (label != null)
            {
                label.Text = string.Format(label.Text, objSaleOrdersInfo.ARSaleOrderNo, objSaleOrdersInfo.ARSaleOrderDate.ToString("dd/MM/yyyy"));
            }
            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblProposalPaymenttAmountString"];
            if (label != null)
            {
                string totalAmount = ConvertAmountToWord.ReadAmount(objPaymentProposalItemsInfo.ARPaymentProposalItemProposalAmount.ToString("n2"), objSaleOrdersInfo.FK_GECurrencyID);
                label.Text = totalAmount;
            }
            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblSaleOrderPaymentTotal"];
            if (label != null)
            {
                if (paymentProposalItemsList.Count > 0)
                {
                    ARPaymentProposalItemsInfo firstItem = paymentProposalItemsList[0];
                    label.Text = isFullVND ? Math.Round(firstItem.ARPaymentProposalItemProposalAmount, 0, MidpointRounding.AwayFromZero).ToString("n0") : firstItem.ARPaymentProposalItemProposalAmount.ToString("n2");
                }
            }

            report.bsARSaleOrderPaymentTimes.DataSource = paymentProposalItemsList;
        }

        private void InitAdvancePaymentVoucherReport(RPAdvancePaymentVoucher report)
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            report.bsPaymentProposals.DataSource = objPaymentProposalsInfo;

            ARPaymentProposalItemsController objPaymentProposalItemsController = new ARPaymentProposalItemsController();
            //Set default current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (label != null)
                label.Text = objBranchsInfo.BRBranchContactAddressLine3;
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (label != null)
                label.Text = objBranchsInfo.BRBranchContactPhone;
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (label != null)
                label.Text = objBranchsInfo.BRBranchContactFax;

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblMST"];
            if (label != null)
                label.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;

            decimal totalAmount = entity.PaymentProposalItemsList.Select(o => o.ARPaymentProposalItemProposalAmount).Sum();
            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblPaymentProposalTotalAmount"];
            if (label != null)
                label.Text = totalAmount.ToString("n0");

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTotalAmount"];
            if (label != null)
                label.Text = totalAmount.ToString("n0");

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTotalAmount2"];
            if (label != null)
                label.Text = totalAmount.ToString("n0");

            label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAmountWordTop"];
            if (label != null)
                label.Text = ConvertAmountToWord.ReadAmount(totalAmount.ToString(), GECurrencyID.VND);

            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWordBottom"];
            if (label != null)
            {
                label.Text = ConvertAmountToWord.ReadAmount(totalAmount.ToString(), GECurrencyID.VND);
            }

            label = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblHREmployeeName"];
            if (label != null)
            {
                HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                HREmployeesController objEmployeesController = new HREmployeesController();
                objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objPaymentProposalsInfo.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    label.Text = objEmployeesInfo.HREmployeeName;
                }
            }
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objPaymentProposalsInfo.FK_ACAssObjectID, objPaymentProposalsInfo.ARAssObjectType);
            if (objObjectsInfo == null)
                objObjectsInfo = new ACObjectsInfo();
            report.bsACObjects.DataSource = objObjectsInfo;
        }

        private void InitReferralPaymentVoucherReport(RPReferralPaymentVoucher report)
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)CurrentModuleEntity.MainObject;
            objPaymentProposalsInfo.ARPaymentProposalDate = DateTime.Now.Date;
            report.bsPaymentProposals.DataSource = objPaymentProposalsInfo;

            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objPaymentProposalsInfo.FK_HREmployeeReceipt);
            if (objEmployeesInfo != null)
            {
                HRLevelsController objLevelsController = new HRLevelsController();
                HRLevelsInfo objLevelsInfo = new HRLevelsInfo();
                objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                if (objLevelsInfo != null)
                {
                    objEmployeesInfo.HRLevelName = objLevelsInfo.HRLevelName;
                }
                report.bsHREmployees.DataSource = objEmployeesInfo;
            }
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objPaymentProposalsInfo.FK_ACAssObjectID, objPaymentProposalsInfo.ARAssObjectType);
            if (objObjectsInfo != null)
            {
                report.bsACObjects.DataSource = objObjectsInfo;
            }
        }

        public List<ARSaleOrdersInfo> GetAllSaleOrderForPaymentProposal()
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            return objSaleOrdersController.GetAllSaleOrderForPaymentProposal();
        }

        public List<ARInvoicesInfo> GetAllInvoiceForPaymentProposal()
        {
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            return objInvoicesController.GetAllInvoiceForPaymentProposal();
        }

        public void ChangItemFromPaymentProposalItem(int objectID, string objectType)
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objectID, objectType);
            ARPaymentProposalsInfo objPaymentProposalsInfo = (ARPaymentProposalsInfo)entity.MainObject;
            objPaymentProposalsInfo.FK_ACAssObjectID = objectID;
            objPaymentProposalsInfo.ARAssObjectType = objectType;
            objPaymentProposalsInfo.FK_ARCustomerID = objectID;
            objPaymentProposalsInfo.ACAssObjectAccessKey = objPaymentProposalsInfo.FK_ACAssObjectID + ";" + objPaymentProposalsInfo.ARAssObjectType;
            entity.UpdateMainObjectBindingSource();
            entity.PaymentProposalItemsList[entity.PaymentProposalItemsList.CurrentIndex].ACObjectName = objObjectsInfo.ACObjectName;
            entity.PaymentProposalItemsList.GridControl.RefreshDataSource();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HyperLinkEditChooseProspectCustomer.Visible = true;
        }

        public void ActionNewFromManual()
        {
            PaymentProposalItemsGridControl.EnableControl(CustomerPaymentProposalNewType.FromManual.ToString());
            SelectPaymentTermButton.Visible = false;
            ActionNew();
        }

        public void ActionNewFromPaymentTerm()
        {
            PaymentProposalItemsGridControl.EnableControl(CustomerPaymentProposalNewType.FromPaymentTerm.ToString());
            SelectPaymentTermButton.Visible = true;
            ActionNew();
        }

        public override void ActionCancel()
        {
            SelectPaymentTermButton.Visible = true;
            HyperLinkEditChooseProspectCustomer.Visible = true;
            base.ActionCancel();
        }

        public void ChooseProspectCustomer()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARPaymentProposalsInfo mainObject = (ARPaymentProposalsInfo)entity.MainObject;

            if (mainObject.FK_ACAssObjectID != 0)
                return;

            if (IsEditable())
            {
                ActionEdit();
            }
            ARProspectCustomersController objProspectCustomersController = new ARProspectCustomersController();
            List<ARProspectCustomersInfo> prospectCustomersList = (List<ARProspectCustomersInfo>)objProspectCustomersController.GetListFromDataSet(objProspectCustomersController.GetAllObjects());
            guiFind<ARProspectCustomersInfo> guiFind = new guiFind<ARProspectCustomersInfo>(TableName.ARProspectCustomersTableName,
                                                                                   prospectCustomersList, this, false);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
                return;
            ARProspectCustomersInfo objProspectCustomersInfo = guiFind.SelectedObjects[0];
            if (objProspectCustomersInfo == null)
            {
                return;
            }
            entity.GenerateCustomerFromProspectCustomer(objProspectCustomersInfo);
            if (!string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerLastName) && !string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerFirstName))
            {
                mainObject.ARPaymentProposalProspectCustomer = string.Format("{0}{1}{2}", objProspectCustomersInfo.ARProspectCustomerLastName, " ",
                                                                                    objProspectCustomersInfo.ARProspectCustomerFirstName);
            }
            else if (!string.IsNullOrEmpty(objProspectCustomersInfo.ARProspectCustomerCompany))
            {
                mainObject.ARPaymentProposalProspectCustomer = objProspectCustomersInfo.ARProspectCustomerCompany;
            }
            entity.UpdateMainObjectBindingSource();
            DisplayLabelText(mainObject);
        }
        public string GetARCustomerNo()
        {
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(ModuleName.Customer, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            string strMainObjectNo = string.Empty;
            if (objGENumberingInfo != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = BOSApp.GetCurrentServerDate();
                int numberStart = objGENumberingInfo.GENumberingStart;
                if (objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                {
                    numberStart = Convert.ToInt32(Math.Pow(10, objGENumberingInfo.GENumberingLength - 1)) + 1;
                }
                string prefix = objGENumberingInfo.GENumberingPrefix.Substring(0, objGENumberingInfo.GENumberingPrefix.Length - 1);
                strMainObjectNo = String.Format("{0}{1}-{2}",
                                                       prefix,
                                                       currentDate.Year.ToString().Substring(2, 2),
                                                       numberStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                objGENumberingInfo.GENumberingStart = objGENumberingInfo.GENumberingStart + 1;
                objGENumberingInfo.AAUpdatedDate = currentDate;
                objGENumberingController.UpdateObject(objGENumberingInfo);
            }
            return strMainObjectNo;
        }
        public void CreateCustomer(ARPaymentProposalsInfo objPaymentProposalsInfo)
        {
            if (objPaymentProposalsInfo.CustomersInfo != null)
            {
                CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
                ARPaymentProposalsController objPaymentProposalsController = new ARPaymentProposalsController();
                ARCustomersController objCustomersController = new ARCustomersController();
                ARPaymentProposalsInfo mainObject = (ARPaymentProposalsInfo)entity.MainObject;
                string no = GetARCustomerNo();
                objPaymentProposalsInfo.CustomersInfo.ARCustomerNo = no;
                int customerID = objCustomersController.CreateObject(objPaymentProposalsInfo.CustomersInfo);
                //Create Opportunity BEGIN
                AROpportunitysController objOpportunitysController = new AROpportunitysController();
                AROpportunitysInfo objOpportunitysInfo = new AROpportunitysInfo();
                objOpportunitysInfo.AROpportunityCustomerName = objPaymentProposalsInfo.CustomersInfo.ARCustomerName;
                objOpportunitysInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objOpportunitysInfo.AROpportunityExpectedValue = objPaymentProposalsInfo.ARPaymentProposalTotalAmount;
                objOpportunitysInfo.AROpportunityName = objPaymentProposalsInfo.ARPaymentProposalDesc;
                objOpportunitysInfo.FK_ARCustomerID = customerID;
                objOpportunitysInfo.AROpportunityStep = "Success";
                int opportunityID = objOpportunitysController.CreateObject(objOpportunitysInfo);
                objPaymentProposalsInfo.FK_AROpportunityID = opportunityID;
                //END
                ARProspectCustomersController objProspectCustomersController = new ARProspectCustomersController();
                objProspectCustomersController.DeleteObject(objPaymentProposalsInfo.CustomersInfo.FK_ARProspectCustomerID);
                objPaymentProposalsInfo.FK_ARCustomerID = customerID;
                objPaymentProposalsInfo.FK_ACAssObjectID = customerID;
                objPaymentProposalsInfo.ARAssObjectType = ObjectType.Customer.ToString();
                objPaymentProposalsInfo.ACAssObjectAccessKey = string.Format("{0};{1}", objPaymentProposalsInfo.FK_ACAssObjectID, objPaymentProposalsInfo.ARAssObjectType);
                objPaymentProposalsController.UpdateObject(objPaymentProposalsInfo);
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectLookupEdit.Properties.DataSource = objObjectsController.GetAllObjects();
            }
        }

        public void DownloadDocument()
        {
            CustomerPaymentProposalEntities entity = (CustomerPaymentProposalEntities)CurrentModuleEntity;
            ARSaleOrderPaymentTimeTemplatesInfo objSaleOrderPaymentTimeTemplatesInfo = entity.SaleOrderPaymentTimeTemplateList[entity.SaleOrderPaymentTimeTemplateList.CurrentIndex];
            if (objSaleOrderPaymentTimeTemplatesInfo == null)
                return;

            if (string.IsNullOrEmpty(objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateFileGUID))
            {
                MessageBox.Show(SaleOrderLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateFileGUID, objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateName);
        }
    }
}

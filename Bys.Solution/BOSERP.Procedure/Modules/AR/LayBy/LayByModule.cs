using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.LayBy
{
    public class LayByModule : BaseTransactionModule
    {
        #region Constants
        public const String cstLayByStatusNew = "New";
        public const String cstLayByStatusCancel = "Cancel";
        public const String cstLayByStatusComplete = "Complete";

        public const String cstLayByConfigInitialDeposit = "LayByInitialDeposit";
        public const String cstLayByConfigDueDays = "LayByDueDays";
        #endregion

        public LayByModule()
        {
            Name = "LayBy";
            CurrentModuleEntity = new LayByEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public override string GenerateSearchQuery(string strTableName)
        {
            String query = base.GenerateSearchQuery(strTableName);
            query += String.Format("AND ARSaleOrderTypeCombo = '{0}'", SaleOrderType.LayBy.ToString());
            return query;
        }

        public override void ActionEdit()
        {
            String status = String.Empty;
            switch (((ARSaleOrdersInfo)CurrentModuleEntity.MainObject).ARSaleOrderStatus)
            {
                case LayByModule.cstLayByStatusCancel:
                    status = "canceled";
                    break;
                case LayByModule.cstLayByStatusComplete:
                    status = "completed";
                    break;
            }
            if (!String.IsNullOrEmpty(status))
            {
                MessageBox.Show(String.Format("The lay-by has been {0} and can not modified", status), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                return;
            }

            base.ActionEdit();
        }

        public override int ActionSave()
        {
            if (!IsInvalidInventory())
            {
                int objectID = base.ActionSave();
                if (objectID > 0)
                    TakePayment();
                return objectID;
            }
            return 0;
        }

        public void AddItemToSaleOrderItemsList()
        {
            LayByEntities entity = (LayByEntities)CurrentModuleEntity;
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)entity.ModuleObjects[TableName.ARSaleOrderItemsTableName];
            if (objSaleOrderItemsInfo.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(objSaleOrderItemsInfo.FK_ICProductID);
                entity.ARSaleOrderItemsList.AddObjectToList();
                entity.UpdateTotalAmount();
            }
        }

        public void ChangeItemFromSaleOrderItemsList()
        {
            LayByEntities entity = (LayByEntities)CurrentModuleEntity;
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)entity.ModuleObjects[TableName.ARSaleOrderItemsTableName];
            entity.SetProductPriceByProductUnitPrice();
            entity.ARSaleOrderItemsList.ChangeObjectFromList();
            entity.UpdateTotalAmount();
        }

        public void DeleteItemFromSaleOrderItemsList()
        {
            LayByEntities entity = (LayByEntities)CurrentModuleEntity;
            entity.ARSaleOrderItemsList.RemoveSelectedRowObjectFromList();
            entity.UpdateTotalAmount();
        }

        public void ChangeCustomer(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
                if (e.Value != lke.OldEditValue)
                {
                    LayByEntities entity = (LayByEntities)CurrentModuleEntity;
                    ((ARSaleOrdersInfo)entity.MainObject).FK_ARCustomerID = Convert.ToInt32(e.Value);
                    SetDefaultValuesFromCustomer();
                }
            }
        }

        public void ChangePriceLevel(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
                if (e.Value != lke.OldEditValue)
                {
                    LayByEntities entity = (LayByEntities)CurrentModuleEntity;
                    ((ARSaleOrdersInfo)entity.MainObject).FK_ARPriceLevelID = Convert.ToInt32(e.Value);
                    if (entity.ARSaleOrderItemsList.Count > 0)
                    {
                        if (MessageBox.Show("Do you want to update new price level to the listed items?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (ARSaleOrderItemsInfo entItem in entity.ARSaleOrderItemsList)
                                entity.SetProductPrice(entItem, TableName.ARSaleOrderItemsTableName);
                            entity.ARSaleOrderItemsList.GridControl.RefreshDataSource();
                            entity.UpdateTotalAmount();
                        }
                    }
                }
            }
        }

        public void ChangeDiscountPercent()
        {
            ((LayByEntities)CurrentModuleEntity).UpdateTotalAmount();
        }

        public void ChangeDiscountAmount()
        {
            LayByEntities entity = (LayByEntities)CurrentModuleEntity;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;
            if (objSaleOrdersInfo.ARSaleOrderSubTotalAmount > 0)
                objSaleOrdersInfo.ARSaleOrderDiscountPerCent = objSaleOrdersInfo.ARSaleOrderDiscountFix / objSaleOrdersInfo.ARSaleOrderSubTotalAmount * 100;
            entity.UpdateTotalAmount();
        }

        public void TakePayment()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                Invalidate(Toolbar.CurrentObjectID);
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)CurrentModuleEntity.MainObject;
                if (objSaleOrdersInfo.ARSaleOrderStatus == LayByModule.cstLayByStatusCancel)
                {
                    MessageBox.Show("Can not take payment on canceled lay-by", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (objSaleOrdersInfo.ARSaleOrderStatus == LayByModule.cstLayByStatusComplete)
                {
                    MessageBox.Show("Can not take payment on complete lay-by", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (objSaleOrdersInfo.ARSaleOrderBalanceDue > 0)
                {
                    guiTakeDeposit guiTakeDeposit = new guiTakeDeposit(objSaleOrdersInfo);
                    if (guiTakeDeposit.ShowDialog() == DialogResult.OK)
                    {
                        decimal paymentAmount = Convert.ToDecimal(guiTakeDeposit.Tag);
                        if (paymentAmount > 0)
                        {
                            guiPaymentDetails guiPaymentDetails = new guiPaymentDetails(this, objSaleOrdersInfo.FK_ARCustomerID, paymentAmount);
                            if (guiPaymentDetails.ShowDialog() == DialogResult.OK)
                            {
                                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                                LayByEntities entity = (LayByEntities)CurrentModuleEntity;
                                entity.ARCustomerPaymentDetailsList = guiPaymentDetails.PaymentDetailList;
                                entity.TakePayment(paymentAmount);

                                bool firstPayment = false;
                                if (objSaleOrdersInfo.ARSaleOrderDepositBalance == 0)
                                    firstPayment = true;

                                objSaleOrdersInfo.ARSaleOrderDepositBalance += Math.Min(paymentAmount, objSaleOrdersInfo.ARSaleOrderBalanceDue);
                                objSaleOrdersInfo.ARSaleOrderBalanceDue -= Math.Min(paymentAmount, objSaleOrdersInfo.ARSaleOrderBalanceDue);
                                objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
                                entity.UpdateMainObjectBindingSource();
                                CurrentModuleEntity.SetPropertyChangeEventLock(true);

                                if (guiPaymentDetails.Tag.ToString() == "SavePrint")
                                {
                                    //If the payment is first one, print lay-by
                                    if (firstPayment)
                                        PrintLayBy();
                                    else
                                    {
                                        //Print lay-by payment
                                        //PrintLayByPayment(invoiceID);
                                    }
                                }

                                if (objSaleOrdersInfo.ARSaleOrderBalanceDue == 0)
                                {
                                    ActionComplete();
                                }
                            }
                        }
                    }
                }
                else
                    ActionComplete();
            }
        }

        public override bool ActionComplete()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                if (MessageBox.Show("The balance due has been paid completely. Do you want to complete the lay-by?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                    {
                        try
                        {
                            CurrentModuleEntity.SetPropertyChangeEventLock(false);
                            bool isComplete = CurrentModuleEntity.CompleteTransaction();
                            scope.Complete();
                            MessageBox.Show("Complete successfully", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        catch (Exception)
                        {
                            scope.Dispose();
                        }
                        finally
                        {
                            CurrentModuleEntity.SetPropertyChangeEventLock(true);
                        }
                    }
                }
            }
            return false;
        }

        public void CancelLayBy()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                Invalidate(Toolbar.CurrentObjectID);
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)CurrentModuleEntity.MainObject;
                if (objSaleOrdersInfo.ARSaleOrderStatus == LayByModule.cstLayByStatusCancel)
                {
                    MessageBox.Show("The lay-by has been canceled", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (objSaleOrdersInfo.ARSaleOrderStatus == LayByModule.cstLayByStatusComplete)
                {
                    MessageBox.Show("Can not cancel on completed lay-by", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Do you want to cancel this lay-by?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((LayByEntities)CurrentModuleEntity).CancelLayBy();
                }
            }
        }

        /// <summary>
        /// Print layby
        /// </summary>
        public void PrintLayBy()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                String strReportFileName = System.Windows.Forms.Application.StartupPath + "\\Reports\\" + this.Name + "\\" + "Layby.rpt";
                ReportHelper.FileName = strReportFileName;
                Hashtable reportParams = new Hashtable();
                reportParams.Add("prARSaleOrderID", Toolbar.CurrentObjectID);
                reportParams.Add("prBRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                ReportHelper.DisplayReport(reportParams);
                ReportHelper.ReportDoc.PrintToPrinter(1, false, 1, 1);
            }
        }

        public void PrintLayByPayment(int invoiceID)
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                String strReportFileName = System.Windows.Forms.Application.StartupPath + "\\Reports\\" + this.Name + "\\" + "LaybyPayment.rpt";
                ReportHelper.FileName = strReportFileName;
                Hashtable reportParams = new Hashtable();
                reportParams.Add("prARSaleOrderID", Toolbar.CurrentObjectID);
                reportParams.Add("prBRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                reportParams.Add("prARInvoiceID", invoiceID);
                ReportHelper.DisplayReport(reportParams);
                ReportHelper.ReportDoc.PrintToPrinter(1, false, 1, 1);
            }
        }
    }
}

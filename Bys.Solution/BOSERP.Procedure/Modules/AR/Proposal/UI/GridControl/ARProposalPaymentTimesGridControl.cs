using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public class ARProposalPaymentTimesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARProposalPaymentTimesList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARProposalsInfo objProposalsInfo = (ARProposalsInfo)entity.MainObject;
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "ARProposalPaymentTimeAmount")
                {
                    RepositoryItemCalcEdit repositoryItemCalcEdit = new RepositoryItemCalcEdit();
                    repositoryItemCalcEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    repositoryItemCalcEdit.NullText = "0";
                    repositoryItemCalcEdit.Mask.EditMask = "n2";
                    repositoryItemCalcEdit.Mask.UseMaskAsDisplayFormat = true;
                    column.ColumnEdit = repositoryItemCalcEdit;
                }
                else if (column.FieldName == "ARPaymentMethodCombo")
                {
                    column.ColumnEdit.KeyPress += new KeyPressEventHandler(ColumnEdit_KeyPress);
                }
                //else if (column.FieldName == "ARSaleOrderPaymentTimePaymentType")
                //{
                //    column.ColumnEdit.KeyPress += new KeyPressEventHandler(ColumnEdit_KeyPress);
                //}
                else if (column.FieldName == "ARProposalPaymentTimeDepositBalance" || column.FieldName == "ARProposalPaymentTimeBalanceDue")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                else if (column.FieldName == "ARProposalPaymentTimeStatus")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
        }

        //TNDLoc [ADD][13/04/2015][Default values when add new row],START
        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            ARProposalsInfo objProposalsInfo = (ARProposalsInfo)entity.MainObject;
            ARProposalPaymentTimesInfo objProposalPaymentTimesInfo = (ARProposalPaymentTimesInfo)view.GetRow(e.RowHandle);
            if (objProposalPaymentTimesInfo != null)
            {
                if (((ProposalModule)Screen.Module).Toolbar.IsNullOrNoneAction() && objProposalsInfo.ARProposalStatus == ProposalStatus.New.ToString())
                {
                    ((ProposalModule)Screen.Module).ActionEdit();
                    entity.ARProposalPaymentTimesList.Add(objProposalPaymentTimesInfo);
                    entity.ARProposalPaymentTimesList.GridControl.RefreshDataSource();
                    view.FocusedRowHandle = e.RowHandle;
                }
            }

            // view.SetRowCellValue(e.RowHandle, view.Columns["ARSaleOrderPaymentTimeDate"], objSaleOrdersInfo.ARSaleOrderSentContract);  
        }
        //TNDLoc [ADD][13/04/2015][Default values when add new row],END



        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ProposalEntities entity = (ProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            ARProposalsInfo mainObject = (ARProposalsInfo)entity.MainObject;
            if (entity.ARProposalPaymentTimesList.CurrentIndex >= 0)
            {
                ARProposalPaymentTimesInfo item = entity.ARProposalPaymentTimesList[entity.ARProposalPaymentTimesList.CurrentIndex];
                if (item.FK_GEPaymentTermID == 0 && mainObject.FK_GEPaymentTermID > 0)
                {
                    item.FK_GEPaymentTermID = mainObject.FK_GEPaymentTermID;
                    ((ProposalModule)Screen.Module).ChangePaymentTimeAmount(mainObject.FK_GEPaymentTermID);
                    //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                    //GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(mainObject.FK_GEPaymentTermID);
                    //if (item.ARSaleOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Deposit.ToString())
                    //{
                    //    if (objPaymentTermsInfo != null)
                    //    {
                    //        item.ARSaleOrderPaymentTimeAmount = mainObject.ARSaleOrderTotalAmount * objPaymentTermsInfo.GEPaymentTermPercentPayment / 100;
                    //    }
                    //}
                }

                if (string.IsNullOrEmpty(item.ARPaymentMethodCombo) && !string.IsNullOrEmpty(mainObject.ARPaymentMethodCombo))
                {
                    item.ARPaymentMethodCombo = mainObject.ARPaymentMethodCombo;
                }

                if (e.Column.FieldName == "FK_GEPaymentTermID" || e.Column.FieldName == "ARProposalPaymentTimePaymentType")
                {
                    //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                    //GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                    List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
                    GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
                    ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(item.FK_GEPaymentTermID);

                    if (item.ARProposalPaymentTimePaymentType == ProposalPaymentTimePaymentType.Deposit.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                    }
                    if (item.ARProposalPaymentTimePaymentType == ProposalPaymentTimePaymentType.Payment.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }
                    if (item.ARProposalPaymentTimePaymentType == "Final Payment")
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }

                    if (objPaymentTermItemsInfo != null && objPaymentTermItemsInfo.GEPaymentTermItemType == PaymentTermType.Day.ToString())
                    {
                        try
                        {
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsContract.ToString())
                            {
                                if (mainObject.ARProposalDate != DateTime.MaxValue && mainObject.ARProposalDate != DateTime.MinValue)
                                {
                                    item.ARProposalPaymentTimeDate = mainObject.ARProposalDate;
                                    item.ARProposalPaymentTimeDueDate = mainObject.ARProposalDate;
                                }
                            }
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsBeforeDelivery.ToString())
                            {
                                if (mainObject.ARProposalDeliveryDate != DateTime.MaxValue && mainObject.ARProposalDeliveryDate != DateTime.MinValue)
                                {
                                    item.ARProposalPaymentTimeDate = mainObject.ARProposalDeliveryDate.AddDays(-objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    item.ARProposalPaymentTimeDueDate = mainObject.ARProposalDeliveryDate.AddDays(-objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                }
                            }
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsAfterDelivery.ToString())
                            {
                                if (mainObject.ARProposalDeliveryDate != DateTime.MaxValue && mainObject.ARProposalDeliveryDate != DateTime.MinValue)
                                {
                                    item.ARProposalPaymentTimeDate = mainObject.ARProposalDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    item.ARProposalPaymentTimeDueDate = mainObject.ARProposalDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                }
                            }
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsInvoiceIn.ToString())
                            {
                                if (mainObject.ARProposalDeliveryDate != DateTime.MaxValue && mainObject.ARProposalDeliveryDate != DateTime.MinValue)
                                {
                                    item.ARProposalPaymentTimeDate = mainObject.ARProposalDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    item.ARProposalPaymentTimeDueDate = mainObject.ARProposalDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                }
                            }
                        }
                        catch (Exception ex)
                        { }

                    }

                    if (objPaymentTermItemsInfo != null)
                    {
                        //TNDLoc [ADD][04/09/2015][Issue default payment method],START
                        //item.ARPaymentMethodCombo = objPaymentTermsInfo.GEPaymentTermPaymentMethodCombo;
                        //TNDLoc [ADD][04/09/2015][Issue default payment method],END
                    }
                    //TKChinh Add [04/07/2016] Percent Payment 
                    if (objPaymentTermItemsInfo != null)
                    {
                        ((ProposalModule)Screen.Module).ChangePaymentTimeAmount(item.FK_GEPaymentTermID);
                        // item.ARSaleOrderPaymentTimeAmount = mainObject.ARSaleOrderTotalAmount * objPaymentTermsInfo.GEPaymentTermPercentPayment / 100;
                    }
                    //TKChinh End
                }
                else if (e.Column.FieldName == "ARProposalPaymentTimeDate")
                {
                    //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                    DateTime PaymentTimeDate = DateTime.Parse(e.Value.ToString());
                    // GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                    GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                    List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
                    GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
                    ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(item.FK_GEPaymentTermID);

                    if (item.ARProposalPaymentTimePaymentType == ProposalPaymentTimePaymentType.Deposit.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                    }
                    if (item.ARProposalPaymentTimePaymentType == ProposalPaymentTimePaymentType.Payment.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }
                    if (item.ARProposalPaymentTimePaymentType == "Final Payment")
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }


                    if (objPaymentTermItemsInfo != null && objPaymentTermItemsInfo.GEPaymentTermItemType == PaymentTermType.Day.ToString())
                    {
                        try
                        {
                            item.ARProposalPaymentTimeDueDate = PaymentTimeDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                        }
                        catch (Exception ex)
                        { }

                    }
                }
                if (e.Column.FieldName == "ARProposalPaymentTimeAmount")
                {
                    if (!(((ProposalModule)Screen.Module).IsValidPaymentTimeAmount()))
                    {
                        entity.ARProposalPaymentTimesList[entity.ARProposalPaymentTimesList.CurrentIndex].ARProposalPaymentTimeAmount = Decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
        }
        public void ColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProposalModule)Screen.Module).DeleteItemFromPaymentTimeItemsList();
            }
        }
        public void LoadGridViewEditPrice(bool IsEditPrice)
        {
            GridView gridView = (GridView)MainView;
            if (IsEditPrice == true)
            {

                foreach (GridColumn columnedit in gridView.Columns)
                {
                    columnedit.OptionsColumn.AllowEdit = false;
                }
                GridColumn column = gridView.Columns["ARProposalPaymentTimeAmount"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                foreach (GridColumn column in gridView.Columns)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                if (gridView.Columns["ARProposalPaymentTimeDepositBalance"] != null)
                {
                    gridView.Columns["ARProposalPaymentTimeDepositBalance"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARProposalPaymentTimeBalanceDue"] != null)
                {
                    gridView.Columns["ARProposalPaymentTimeBalanceDue"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARProposalPaymentTimeStatus"] != null)
                {
                    gridView.Columns["ARProposalPaymentTimeStatus"].OptionsColumn.AllowEdit = false;
                }
            }
        }
        public void repositoryItemLookUpEditACAcount_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARProposalsInfo objProposalsInfo = (ARProposalsInfo)entity.MainObject;
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            List<ARCustomerPaymentsInfo> customerPayments = objCustomerPaymentsController.GetCustomerPaymentsWithTypeAdvancePayment();
            customerPayments = customerPayments.Where(o => o.FK_ACObjectID == objProposalsInfo.FK_ACObjectID
                                                                && o.ARObjectType == objProposalsInfo.ARObjectType
                                                                && o.ARCustomerPaymentTotalAmount > 0)
                                               .ToList();
            List<int> usedCustomerPayment = entity.ARProposalPaymentTimesList.Select(o => o.FK_ARCustomerPaymentID).ToList();
            customerPayments = customerPayments.Where(o => !usedCustomerPayment.Contains(o.ARCustomerPaymentID))
                                               .ToList();
            if (customerPayments != null)
            {
                lookUpEdit.Properties.DataSource = customerPayments;
            }
            lookUpEdit.Properties.DisplayMember = "ARCustomerPaymentNo";
            lookUpEdit.Properties.ValueMember = "ARCustomerPaymentID";
        }
    }
}
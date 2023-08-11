using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class APPurchaseOrderPaymentTimesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.APPurchaseOrderPaymentTimesList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "APPurchaseOrderPaymentTimeAmount")
                {
                    RepositoryItemCalcEdit repositoryItemCalcEdit = new RepositoryItemCalcEdit();
                    repositoryItemCalcEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    repositoryItemCalcEdit.NullText = "0";
                    repositoryItemCalcEdit.Mask.EditMask = "n0";
                    repositoryItemCalcEdit.Mask.UseMaskAsDisplayFormat = true;
                    column.ColumnEdit = repositoryItemCalcEdit;
                }
                if (column.FieldName == "APPaymentMethodCombo")
                {
                    column.ColumnEdit.KeyPress += new KeyPressEventHandler(ColumnEdit_KeyPress);
                    column.ColumnEdit.NullText = String.Empty;
                }
                if (column.FieldName == "APPurchaseOrderPaymentTimeStatus")
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.ColumnEdit.NullText = String.Empty;
                }
                if (column.FieldName == "ARSaleOrderPaymentTimeDepositBalance")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "ARSaleOrderPaymentTimeBalanceDue")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "APPurchaseOrderPaymentTimeName")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                if (column.FieldName == "APPurchaseOrderPaymentTimePaymentType" && column.ColumnEdit != null)
                {
                    column.ColumnEdit.NullText = String.Empty;
                }

            }

            //GridColumn col = new GridColumn();
            //col.Caption = "Đã cấn trừ";
            //col.FieldName = "APPurchaseOrderPaymentTimeClearCreditAmount";
            //col.OptionsColumn.AllowEdit = false;
            //col.Visible = true;
            //gridView.Columns.Add(col);
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
        }
        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            APPurchaseOrdersInfo mainObject = (APPurchaseOrdersInfo)entity.MainObject;
            APPurchaseOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)view.GetRow(e.RowHandle);
            if (objPurchaseOrderPaymentTimesInfo != null)
            {
                if (((PurchaseOrderModule)Screen.Module).Toolbar.IsNullOrNoneAction() && mainObject.APPurchaseOrderStatus == PurchaseOrderStatus.New.ToString())
                {
                    ((PurchaseOrderModule)Screen.Module).ActionEdit();

                    entity.APPurchaseOrderPaymentTimesList.Add(objPurchaseOrderPaymentTimesInfo);
                    entity.APPurchaseOrderPaymentTimesList.GridControl.RefreshDataSource();
                    view.FocusedRowHandle = e.RowHandle;
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            PurchaseOrderEntities entity = (PurchaseOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APPurchaseOrdersInfo mainObject = (APPurchaseOrdersInfo)entity.MainObject;
            if (entity.APPurchaseOrderPaymentTimesList.CurrentIndex >= 0)
            {
                if (mainObject.APPurchaseOrderPaymentTermRequest != PurchaseOrderPaymentTermRequest.Other.ToString())
                {
                    APPurchaseOrderPaymentTimesInfo item = entity.APPurchaseOrderPaymentTimesList[entity.APPurchaseOrderPaymentTimesList.CurrentIndex];
                    if (item.FK_GEPaymentTermID == 0 && mainObject.FK_GEPaymentTermID > 0)
                    {
                        item.FK_GEPaymentTermID = mainObject.FK_GEPaymentTermID;
                    }
                    item.APPaymentMethodCombo = mainObject.APPaymentMethodCombo;
                    if (e.Column.FieldName == "FK_GEPaymentTermID")
                    {
                        // GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                        //GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(int.Parse(e.Value.ToString()));
                        GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                        List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
                        GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
                        ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(int.Parse(e.Value.ToString()));

                        if (item.APPurchaseOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Deposit.ToString())
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                        }
                        if (item.APPurchaseOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Payment.ToString())
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                        }
                        if (item.APPurchaseOrderPaymentTimePaymentType == "Final Payment")
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                        }

                        if (objPaymentTermItemsInfo != null && objPaymentTermItemsInfo.GEPaymentTermItemType == PaymentTermType.Day.ToString())
                        {
                            try
                            {

                                if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsContract.ToString())
                                {
                                    if (mainObject.APPurchaseOrderContractDate != DateTime.MaxValue && mainObject.APPurchaseOrderContractDate != DateTime.MinValue)
                                    {
                                        item.APPurchaseOrderPaymentTimeDate = mainObject.APPurchaseOrderContractDate;
                                        item.ARSaleOrderPaymentTimeDueDate = mainObject.APPurchaseOrderContractDate;
                                    }

                                }
                                if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsBeforeDelivery.ToString())
                                {
                                    if (mainObject.APPurchaseOrderDeliveryDate != DateTime.MaxValue && mainObject.APPurchaseOrderDeliveryDate != DateTime.MinValue)
                                    {
                                        item.APPurchaseOrderPaymentTimeDate = mainObject.APPurchaseOrderDeliveryDate.AddDays(-objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                        item.ARSaleOrderPaymentTimeDueDate = mainObject.APPurchaseOrderDeliveryDate.AddDays(-objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    }
                                }
                                if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsAfterDelivery.ToString())
                                {
                                    if (mainObject.APPurchaseOrderDeliveryDate != DateTime.MaxValue && mainObject.APPurchaseOrderDeliveryDate != DateTime.MinValue)
                                    {
                                        item.APPurchaseOrderPaymentTimeDate = mainObject.APPurchaseOrderDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                        item.ARSaleOrderPaymentTimeDueDate = mainObject.APPurchaseOrderDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    }
                                }

                            }
                            catch (Exception ex)
                            { }

                        }
                        //TKChinh Add [04/07/2016] Percent Payment 
                        if (objPaymentTermItemsInfo != null)
                        {
                            if (item.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Deposit.ToString())
                            {
                                item.APPurchaseOrderPaymentTimeAmount = mainObject.APPurchaseOrderTotalCost * objPaymentTermItemsInfo.GEPaymentTermItemPercentPayment / 100;
                                foreach (APPurchaseOrderPaymentTimesInfo poPaymentTime in entity.APPurchaseOrderPaymentTimesList)
                                {
                                    if (poPaymentTime.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Payment.ToString())
                                    {
                                        poPaymentTime.APPurchaseOrderPaymentTimeAmount = mainObject.APPurchaseOrderTotalCost - item.APPurchaseOrderPaymentTimeAmount;
                                        break;
                                    }

                                }
                            }
                            else
                            {
                                bool isExistDeposit = false;
                                decimal depositAmount = 0;
                                foreach (APPurchaseOrderPaymentTimesInfo poPaymentTime in entity.APPurchaseOrderPaymentTimesList)
                                {
                                    if (poPaymentTime.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Deposit.ToString())
                                    {
                                        depositAmount = poPaymentTime.APPurchaseOrderPaymentTimeAmount;
                                        isExistDeposit = true;
                                        break;
                                    }
                                }

                                if (isExistDeposit)
                                {
                                    item.APPurchaseOrderPaymentTimeAmount = mainObject.APPurchaseOrderTotalCost - depositAmount;
                                }
                                else
                                {
                                    item.APPurchaseOrderPaymentTimeAmount = mainObject.APPurchaseOrderTotalCost * objPaymentTermItemsInfo.GEPaymentTermItemPercentPayment / 100;
                                }
                            }
                        }
                        //TKChinh End
                    }


                    if (e.Column.FieldName == "APPurchaseOrderPaymentTimeDate")
                    {
                        //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                        //GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                        GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                        List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
                        GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
                        ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(item.FK_GEPaymentTermID);

                        if (item.APPurchaseOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Deposit.ToString())
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                        }
                        if (item.APPurchaseOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Payment.ToString())
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                        }
                        if (item.APPurchaseOrderPaymentTimePaymentType == "Final Payment")
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                        }




                        if (objPaymentTermItemsInfo != null && objPaymentTermItemsInfo.GEPaymentTermItemType == PaymentTermType.Day.ToString())
                        {
                            try
                            {
                                item.ARSaleOrderPaymentTimeDueDate = item.APPurchaseOrderPaymentTimeDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                            }
                            catch (Exception ex)
                            { }

                        }
                    }

                    if (e.Column.FieldName == "APPurchaseOrderPaymentTimePaymentType")
                    {
                        item.APPurchaseOrderPaymentTimeDate = mainObject.APPurchaseOrderDate;
                        //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                        //GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                        GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                        List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
                        GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
                        ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(item.FK_GEPaymentTermID);

                        if (item.APPurchaseOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Deposit.ToString())
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                        }
                        if (item.APPurchaseOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Payment.ToString())
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                        }
                        if (item.APPurchaseOrderPaymentTimePaymentType == "Final Payment")
                        {
                            objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                        }



                        if (objPaymentTermItemsInfo != null && objPaymentTermItemsInfo.GEPaymentTermItemType == PaymentTermType.Day.ToString())
                        {
                            try
                            {
                                item.ARSaleOrderPaymentTimeDueDate = item.APPurchaseOrderPaymentTimeDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                            }
                            catch (Exception ex)
                            { }
                        }
                    }
                    foreach (APPurchaseOrderPaymentTimesInfo poPaymentTime in entity.APPurchaseOrderPaymentTimesList)
                    {
                        BOSApp.RoundByCurrency(poPaymentTime, mainObject.FK_GECurrencyID);
                    }
                }
            }
        }

        protected override void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            // GridLocalizer.Active = new MyLocalizer();
            APPurchaseOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)e.Row;

            if (objPurchaseOrderPaymentTimesInfo != null)
            {
                PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                APPurchaseOrdersInfo mainObject = (APPurchaseOrdersInfo)entity.MainObject;
                if (mainObject.APPurchaseOrderPaymentTermRequest != PurchaseOrderPaymentTermRequest.Other.ToString())
                {

                    if (objPurchaseOrderPaymentTimesInfo.FK_GEPaymentTermID == 0)
                    {
                        e.ErrorText = PurchaseOrderLocalizedResources.SelectPaymentTerm;
                        e.Valid = false;
                    }
                    else if (string.IsNullOrEmpty(objPurchaseOrderPaymentTimesInfo.APPaymentMethodCombo))
                    {
                        e.ErrorText = PurchaseOrderLocalizedResources.SelectPaymentMethod;
                        e.Valid = false;
                    }
                }

            }
            base.GridView_ValidateRow(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PurchaseOrderModule)Screen.Module).RemoveSelectedPaymentTimes();
            }
        }

        void ColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

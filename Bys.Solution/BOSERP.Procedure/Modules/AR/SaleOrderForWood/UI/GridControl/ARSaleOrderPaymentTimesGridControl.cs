using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrderForWood
{
    public class ARSaleOrderPaymentTimesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleOrderForWoodEntities entity = (SaleOrderForWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderPaymentTimesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "ARSaleOrderPaymentTimeAmount")
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
                else if (column.FieldName == "ARSaleOrderPaymentTimeDepositBalance" || column.FieldName == "ARSaleOrderPaymentTimeBalanceDue")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                else if (column.FieldName == "ARSaleOrderPaymentTimeStatus")
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
            SaleOrderForWoodEntities entity = (SaleOrderForWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;
            ARSaleOrderPaymentTimesInfo objSaleOrderPaymentTimesInfo = (ARSaleOrderPaymentTimesInfo)view.GetRow(e.RowHandle);
            if (objSaleOrderPaymentTimesInfo != null)
            {
                if (((SaleOrderForWoodModule)Screen.Module).Toolbar.IsNullOrNoneAction() && objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.New.ToString())
                {
                    ((SaleOrderForWoodModule)Screen.Module).ActionEdit();
                    entity.ARSaleOrderPaymentTimesList.Add(objSaleOrderPaymentTimesInfo);
                    entity.ARSaleOrderPaymentTimesList.GridControl.RefreshDataSource();
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
            SaleOrderForWoodEntities entity = (SaleOrderForWoodEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)entity.MainObject;
            if (entity.ARSaleOrderPaymentTimesList.CurrentIndex >= 0)
            {
                ARSaleOrderPaymentTimesInfo item = entity.ARSaleOrderPaymentTimesList[entity.ARSaleOrderPaymentTimesList.CurrentIndex];
                if (item.FK_GEPaymentTermID == 0 && mainObject.FK_GEPaymentTermID > 0)
                {
                    item.FK_GEPaymentTermID = mainObject.FK_GEPaymentTermID;
                    ((SaleOrderForWoodModule)Screen.Module).ChangePaymentTimeAmount(mainObject.FK_GEPaymentTermID);
                    //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                    //GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(mainObject.FK_GEPaymentTermID);
                    //if (objPaymentTermsInfo != null)
                    //{
                    //    item.ARSaleOrderPaymentTimeAmount = mainObject.ARSaleOrderTotalAmount * objPaymentTermsInfo.GEPaymentTermPercentPayment / 100;
                    //}

                }

                if (string.IsNullOrEmpty(item.ARPaymentMethodCombo) && !string.IsNullOrEmpty(mainObject.ARPaymentMethodCombo))
                {
                    item.ARPaymentMethodCombo = mainObject.ARPaymentMethodCombo;
                }

                if (e.Column.FieldName == "FK_GEPaymentTermID" || e.Column.FieldName == "ARSaleOrderPaymentTimePaymentType")
                {
                    //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                    //GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                    List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
                    GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
                    ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(item.FK_GEPaymentTermID);
                    if (item.ARSaleOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Deposit.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                    }
                    if (item.ARSaleOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Payment.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }
                    if (item.ARSaleOrderPaymentTimePaymentType == "Final Payment")
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }

                    if (objPaymentTermItemsInfo != null && objPaymentTermItemsInfo.GEPaymentTermItemType == PaymentTermType.Day.ToString())
                    {
                        try
                        {
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsContract.ToString())
                            {
                                if (mainObject.ARSaleOrderDate != DateTime.MaxValue && mainObject.ARSaleOrderDate != DateTime.MinValue)
                                {
                                    item.ARSaleOrderPaymentTimeDate = mainObject.ARSaleOrderDate;
                                    item.ARSaleOrderPaymentTimeDueDate = mainObject.ARSaleOrderDate;
                                }
                            }
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsBeforeDelivery.ToString())
                            {
                                if (mainObject.ARSaleOrderDeliveryDate != DateTime.MaxValue && mainObject.ARSaleOrderDeliveryDate != DateTime.MinValue)
                                {
                                    item.ARSaleOrderPaymentTimeDate = mainObject.ARSaleOrderDeliveryDate.AddDays(-objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    item.ARSaleOrderPaymentTimeDueDate = mainObject.ARSaleOrderDeliveryDate.AddDays(-objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                }
                            }
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsAfterDelivery.ToString())
                            {
                                if (mainObject.ARSaleOrderDeliveryDate != DateTime.MaxValue && mainObject.ARSaleOrderDeliveryDate != DateTime.MinValue)
                                {
                                    item.ARSaleOrderPaymentTimeDate = mainObject.ARSaleOrderDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    item.ARSaleOrderPaymentTimeDueDate = mainObject.ARSaleOrderDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                }
                            }
                            if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsInvoiceIn.ToString())
                            {
                                if (mainObject.ARSaleOrderDeliveryDate != DateTime.MaxValue && mainObject.ARSaleOrderDeliveryDate != DateTime.MinValue)
                                {
                                    item.ARSaleOrderPaymentTimeDate = mainObject.ARSaleOrderDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                    item.ARSaleOrderPaymentTimeDueDate = mainObject.ARSaleOrderDeliveryDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
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
                        ((SaleOrderForWoodModule)Screen.Module).ChangePaymentTimeAmount(item.FK_GEPaymentTermID);
                        // item.ARSaleOrderPaymentTimeAmount = mainObject.ARSaleOrderTotalAmount * objPaymentTermsInfo.GEPaymentTermPercentPayment / 100;
                    }
                    //TKChinh End
                }
                else if (e.Column.FieldName == "ARSaleOrderPaymentTimeDate")
                {
                    //GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                    DateTime PaymentTimeDate = DateTime.Parse(e.Value.ToString());
                    // GEPaymentTermsInfo objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                    GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                    List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
                    GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
                    ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(item.FK_GEPaymentTermID);

                    if (item.ARSaleOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Deposit.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                    }
                    if (item.ARSaleOrderPaymentTimePaymentType == SaleOrderPaymentTimePaymentType.Payment.ToString())
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }
                    if (item.ARSaleOrderPaymentTimePaymentType == "Final Payment")
                    {
                        objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                    }


                    if (objPaymentTermItemsInfo != null && objPaymentTermItemsInfo.GEPaymentTermItemType == PaymentTermType.Day.ToString())
                    {
                        try
                        {
                            item.ARSaleOrderPaymentTimeDueDate = PaymentTimeDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                        }
                        catch (Exception ex)
                        { }

                    }
                }
                //if (e.Column.FieldName == "ARSaleOrderPaymentTimeAmount")
                //{
                //if (!(((SaleOrderForWoodModule)Screen.Module).IsValidAmount()))
                //{
                //entity.ARSaleOrderPaymentTimesList[entity.ARSaleOrderPaymentTimesList.CurrentIndex].ARSaleOrderPaymentTimeAmount = double.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                //}
                //}
            }
        }

        protected override void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridLocalizer.Active = new MyLocalizer1();
            ARSaleOrderPaymentTimesInfo objSaleOrderPaymentTimesInfo = (ARSaleOrderPaymentTimesInfo)e.Row;

            if (objSaleOrderPaymentTimesInfo != null)
            {
                SaleOrderForWoodEntities entity = (SaleOrderForWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;
                //if (string.IsNullOrEmpty(objSaleOrderPaymentTimesInfo.ARSaleOrderPaymentTimeName))
                //{
                //    e.ErrorText = SaleOrderLocalizedResources.ARSaleOrderPaymentTimeNameIsNullMessage;
                //    e.Valid = false;
                //}
                //else 
                if (string.IsNullOrEmpty(objSaleOrderPaymentTimesInfo.ARPaymentMethodCombo))
                {
                    e.ErrorText = SaleOrderLocalizedResources.ARPaymentMethodComboIsNullMessage;
                    e.Valid = false;
                }

            }
            base.GridView_ValidateRow(sender, e);
        }



        void ColumnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderForWoodModule)Screen.Module).DeleteItemFromPaymentTimeItemsList();
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
                GridColumn column = gridView.Columns["ARSaleOrderPaymentTimeAmount"];
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
                if (gridView.Columns["ARSaleOrderPaymentTimeDepositBalance"] != null)
                {
                    gridView.Columns["ARSaleOrderPaymentTimeDepositBalance"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARSaleOrderPaymentTimeBalanceDue"] != null)
                {
                    gridView.Columns["ARSaleOrderPaymentTimeBalanceDue"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["ARSaleOrderPaymentTimeStatus"] != null)
                {
                    gridView.Columns["ARSaleOrderPaymentTimeStatus"].OptionsColumn.AllowEdit = false;
                }
            }
        }

    }
}
public class MyLocalizer1 : DevExpress.XtraGrid.Localization.GridLocalizer
{
    public override string GetLocalizedString(DevExpress.XtraGrid.Localization.GridStringId id)
    {
        if (id == DevExpress.XtraGrid.Localization.GridStringId.ColumnViewExceptionMessage)
            return string.Empty;
        return base.GetLocalizedString(id);
    }
}
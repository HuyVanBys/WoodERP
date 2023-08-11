using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderPaymentTimesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderPaymentTimesList;
            this.DataSource = bds;
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Screen.Module).ShowClearingDetail();
        }

        protected override GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            return gridView;
        }

        private void RrpItemFile_Click(object sender, EventArgs e)
        {
            ((SaleOrderModule)Screen.Module).ShowAttachFile();
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;
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
                else if (column.FieldName == "ARSaleOrderPaymentTimeDepositBalance" || column.FieldName == "ARSaleOrderPaymentTimeBalanceDue")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                else if (column.FieldName == "ARSaleOrderPaymentTimeStatus")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
                if (column.FieldName == "FK_ARCustomerPaymentID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ARCustomerPaymentNo";
                    repositoryItemLookUpEdit.ValueMember = "ARCustomerPaymentID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ARCustomerPaymentNo", "Mã phiếu thu"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ARCustomerPaymentDesc", "Mô tả"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Đối tượng"));
                    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemCustomerPaymentsLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
            }
            GridColumn gridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn = new GridColumn();
            gridColumn.Caption = "Thu tạm ứng";
            gridColumn.FieldName = "ARItemComponent";
            gridColumn.OptionsColumn.AllowEdit = true;

            RepositoryItemButtonEdit rpItemComponent = new RepositoryItemButtonEdit();
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            gridColumn.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(gridColumn);

            //Add Attach File
            gridColumn = new GridColumn();
            gridColumn.Caption = SaleOrderLocalizedResources.AttachFileCaption;
            gridColumn.FieldName = "AttachFileCaption";
            gridColumn.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemFile = new RepositoryItemHyperLinkEdit();
            rpItemFile.NullText = SaleOrderLocalizedResources.ChooseFileCaption;
            rpItemFile.Click += new EventHandler(RrpItemFile_Click);
            gridColumn.ColumnEdit = rpItemFile;
            gridColumn.Visible = true;
            gridView.Columns.Add(gridColumn);
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
        }

        void repositoryItemCustomerPaymentsLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;
            ARCustomerPaymentsController objCustomerPaymentsControlle = new ARCustomerPaymentsController();
            List<ARCustomerPaymentsInfo> customerPaymentList = new List<ARCustomerPaymentsInfo>();
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = new ARCustomerPaymentsInfo();
            objCustomerPaymentsInfo.ARCustomerPaymentID = 0;
            customerPaymentList = objCustomerPaymentsControlle.GetCustomerPaymentsForRepositoryItemLookUpEdit(objSaleOrdersInfo.FK_ACObjectID, objSaleOrdersInfo.ARObjectType);
            if (customerPaymentList == null)
                customerPaymentList = new List<ARCustomerPaymentsInfo>();
            lookUpEdit.Properties.DataSource = customerPaymentList;
            lookUpEdit.Properties.DisplayMember = "ARCustomerPaymentNo";
            lookUpEdit.Properties.ValueMember = "ARCustomerPaymentID";
        }

        //TNDLoc [ADD][13/04/2015][Default values when add new row],START
        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;
            ARSaleOrderPaymentTimesInfo objSaleOrderPaymentTimesInfo = (ARSaleOrderPaymentTimesInfo)view.GetRow(e.RowHandle);
            if (objSaleOrderPaymentTimesInfo != null)
            {
                if (((SaleOrderModule)Screen.Module).Toolbar.IsNullOrNoneAction() && objSaleOrdersInfo.ARSaleOrderStatus == SaleOrderStatus.New.ToString())
                {
                    ((SaleOrderModule)Screen.Module).ActionEdit();
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
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            ARSaleOrdersInfo mainObject = (ARSaleOrdersInfo)entity.MainObject;
            if (entity.ARSaleOrderPaymentTimesList.CurrentIndex >= 0)
            {
                ARSaleOrderPaymentTimesInfo item = entity.ARSaleOrderPaymentTimesList[entity.ARSaleOrderPaymentTimesList.CurrentIndex];
                if (item.FK_GEPaymentTermID == 0 && mainObject.FK_GEPaymentTermID > 0)
                {
                    item.FK_GEPaymentTermID = mainObject.FK_GEPaymentTermID;
                    ((SaleOrderModule)Screen.Module).ChangePaymentTimeAmount(mainObject.FK_GEPaymentTermID);
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
                        ((SaleOrderModule)Screen.Module).ChangePaymentTimeAmount(item.FK_GEPaymentTermID);
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
                if (e.Column.FieldName == "FK_ARCustomerPaymentID")
                {
                    ((SaleOrderModule)Screen.Module).ChangeCustomerPayment(item);
                    entity.UpdateTotalAmount(entity.ARSaleOrderItemsList);
                }
                if (e.Column.FieldName == "ARSaleOrderPaymentTimeAmount")
                {
                    if (!(((SaleOrderModule)Screen.Module).IsValidAmount()))
                    {
                        entity.ARSaleOrderPaymentTimesList[entity.ARSaleOrderPaymentTimesList.CurrentIndex].ARSaleOrderPaymentTimeAmount = Decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
        }

        protected override void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridLocalizer.Active = new MyLocalizer();
            ARSaleOrderPaymentTimesInfo objSaleOrderPaymentTimesInfo = (ARSaleOrderPaymentTimesInfo)e.Row;

            if (objSaleOrderPaymentTimesInfo != null)
            {
                SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
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
                ((SaleOrderModule)Screen.Module).DeleteItemFromPaymentTimeItemsList();
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
                //GridColumn column = gridView.Columns["ARSaleOrderPaymentTimeAmount"];
                //if (column != null)
                //{
                //    column.OptionsColumn.AllowEdit = true;
                //}
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
        public void repositoryItemLookUpEditACAcount_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)entity.MainObject;
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            List<ARCustomerPaymentsInfo> customerPayments = objCustomerPaymentsController.GetCustomerPaymentsWithTypeAdvancePayment();
            customerPayments = customerPayments.Where(o => o.FK_ACObjectID == objSaleOrdersInfo.FK_ACObjectID
                                                                && o.ARObjectType == objSaleOrdersInfo.ARObjectType
                                                                && o.ARCustomerPaymentTotalAmount > 0)
                                               .ToList();
            List<int> usedCustomerPayment = entity.ARSaleOrderPaymentTimesList.Select(o => o.FK_ARCustomerPaymentID).ToList();
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
public class MyLocalizer : DevExpress.XtraGrid.Localization.GridLocalizer
{
    public override string GetLocalizedString(DevExpress.XtraGrid.Localization.GridStringId id)
    {
        if (id == DevExpress.XtraGrid.Localization.GridStringId.ColumnViewExceptionMessage)
            return string.Empty;
        return base.GetLocalizedString(id);
    }
}
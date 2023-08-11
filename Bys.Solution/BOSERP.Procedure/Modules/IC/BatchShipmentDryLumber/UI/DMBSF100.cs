using BOSCommon;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.BatchShipmentDryLumber.UI
{
    /// <summary>
    /// Summary description for DMBSF100
    /// </summary>
    public partial class DMBSF100 : BOSERPScreen
    {

        public DMBSF100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchShipmentDryLumberModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchShipmentDryLumberModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int stockID = 0;
                if (int.TryParse(e.Value.ToString(), out stockID))
                {
                    ((BatchShipmentDryLumberModule)Module).ChangeStock(stockID);
                    ((BatchShipmentDryLumberModule)Module).SetCreditAccountID(stockID);
                }
            }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((BatchShipmentDryLumberModule)Module).ShownInventoryStocks();
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int bathproduct = 0;
                if (int.TryParse(e.Value.ToString(), out bathproduct))
                {
                    ((BatchShipmentDryLumberModule)Module).ChangeBatchProduct(bathproduct);
                }
            }

        }

        private void fld_lkeFK_HRDepartmentRoomID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int departmentRoomID = 0;
                if (int.TryParse(e.Value.ToString(), out departmentRoomID))
                {
                    ((BatchShipmentDryLumberModule)Module).SetDepartmentRoom(departmentRoomID);
                }
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((BatchShipmentDryLumberModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
                ((BatchShipmentDryLumberModule)Module).SetDebitAccountID(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp_1(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((BatchShipmentDryLumberModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_APPurchaseOrderID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;

            List<APPurchaseOrdersInfo> purchareOrderList = ((BatchShipmentDryLumberModule)Module).GetPurcharseOrderOfBatchProduct();
            lke.Properties.DataSource = purchareOrderList;
        }
        private void fld_lkeICShipmentTypeCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null)
            {
                ((BatchShipmentDryLumberModule)Module).ChangeShipmentType(e.Value.ToString());
                if (fld_lkeFK_ICProductID != null)
                {
                    fld_lkeFK_ICProductID.Properties.DataSource =
                            BOSApp.CurrentProductList.Where(p => p.ICProductType ==
                                (e.Value.ToString() == ShipmentType.RoundwoodShipment.ToString() ? ProductType.Roundwood.ToString() : ProductType.Lumber.ToString())).ToList();
                }
            }
        }

        private void fld_lkeICShipmentTypeCombo_QueryPopUp(object sender, CancelEventArgs e)
        {
            DataTable tb = ADConfigValueUtility.ConfigValues.Tables["ShipmentType"];
            if (tb != null)
            {
                DataTable datafilter = tb.Clone();
                var data = tb.Rows.Cast<DataRow>().Where(x => ((string)x["Value"] == ShipmentType.RoundwoodShipment.ToString()
                                                            || (string)x["Value"] == ShipmentType.DryLumber.ToString())).AsEnumerable();
                if (data != null && data.Any())
                {
                    datafilter.Merge(data.CopyToDataTable());
                    fld_lkeICShipmentTypeCombo.Properties.DataSource = datafilter;
                }
            }
        }

        private void fld_lkeICShipmentTypeCombo_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if (e. != null && e.Value != lke.OldEditValue)
            //{
            //    ((BatchShipmentDryLumberModule)Module).ChangeShipmentType(e.Value.ToString());
            //    if (fld_lkeFK_ICProductID != null)
            //    {
            //        fld_lkeFK_ICProductID.Properties.DataSource =
            //                BOSApp.CurrentProductList.Where(p => p.ICProductType ==
            //                    (e.Value.ToString() == ShipmentType.RoundwoodShipment.ToString() ? ProductType.Roundwood.ToString() : ProductType.Lumber.ToString())).ToList();
            //    }
            //}
        }

        private void fld_lkeFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if (Convert.ToInt32(lke.EditValue != DBNull.Value ? lke.EditValue : 0) != 0)
            //{
            //    ((BatchShipmentDryLumberModule)Module).DisableWorkShopLookUpEdit(false, Convert.ToInt32(lke.EditValue));
            //}
            //else
            //{
            //    ((BatchShipmentDryLumberModule)Module).DisableWorkShopLookUpEdit(true, 0);
            //}
        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchShipmentDryLumberModule)Module).ChangeWorkShop(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_LineID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchShipmentDryLumberModule)Module).ChangeLine(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchShipmentDryLumberModule)Module).ChangeOperation(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnAutoSelectProductSerialNo_Click(object sender, EventArgs e)
        {
            ((BatchShipmentDryLumberModule)Module).AutoSelectProductSerialNo();
        }
    }
}

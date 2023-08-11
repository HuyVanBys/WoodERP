using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt.UI
{
    /// <summary>
    /// Summary description for DMSPRC100
    /// </summary>
    public partial class DMSPRC100 : BOSERPScreen
    {
        public List<ICProductsInfo> ListProduct = new List<ICProductsInfo>();
        public DMSPRC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnShowReceiptList_Click(object sender, EventArgs e)
        {
            ((SemiProductReceiptModule)Module).ShowShipmentList();
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SemiProductReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductReceiptModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeICReceiptTypeCombo_EditValueChanged(object sender, EventArgs e)
        {
            ((SemiProductReceiptModule)Module).ChangeProductAddLookupEditDataSource();
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((SemiProductReceiptModule)Module).ChangePackNo();
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                // ((SemiProductReceiptModule)Module).ChangeOperation(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductReceiptModule)Module).ChangeBatchProduct();
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((SemiProductReceiptModule)Module).ChangeGECurrency(e.Value.ToString());
            }
        }

        private void fld_dteICReceiptDate_Validated(object sender, EventArgs e)
        {
            ((SemiProductReceiptModule)Module).ChangeReceiptDate();
        }

        private void fld_txtICReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((SemiProductReceiptModule)Module).ChangeExchangeRate();
        }

        private void fld_lkeFK_MMBatchProductItemID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                string result = ((SemiProductReceiptModule)Module).ChangeBatchProductItem(int.Parse(e.Value.ToString()));
            }
        }


        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            ((SemiProductReceiptModule)Module).ShowGuiPackage();
        }

        private void fld_lkeFK_MMBatchProductItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeFK_MMBatchProductItemID.Properties.DataSource = ((SemiProductReceiptModule)Module).GetBatchProductItemSerialDataSource();
        }

        private void fld_lkeFK_LineID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int workShopID = 0;
            if (fld_lkeFK_MMWorkShopID.EditValue != null) int.TryParse(fld_lkeFK_MMWorkShopID.EditValue.ToString(), out workShopID);
            DataSet ds = new DataSet();
            if (BOSApp.LookupTables.ContainsKey("MMLines"))
                ds = (DataSet)BOSApp.LookupTables["MMLines"];
            if (workShopID > 0)
            {
                if (!BOSApp.LookupTables.ContainsKey("MMLines"))
                {
                    List<MMLinesInfo> line = (List<MMLinesInfo>)(new MMLinesController()).GetAllAliveAndActiveLine();
                    if (line != null)
                    {
                        line = line.Where(o => o.FK_MMWorkShopID == workShopID).ToList();
                        if (line != null)
                        {
                            line.Insert(0, new MMLinesInfo());
                            fld_lkeFK_LineID.Properties.DataSource = line;
                        }
                    }
                }
            }
            else
            {
                if (ds != null && ds.Tables.Count > 0)
                    fld_lkeFK_LineID.Properties.DataSource = ds.Tables[0];
                else
                    fld_lkeFK_LineID.Properties.DataSource = ds.Tables;
            }
        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductReceiptModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 2);
            }
        }

        private void fld_lkeFK_LineID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductReceiptModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 3);
            }
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductReceiptModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 4);
            }
        }

        private void fld_lkeFK_MMOperationID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((SemiProductReceiptModule)Module).InitializeOperationlookupDataSource();
        }

        private void fld_lkeFK_MMWorkShopID_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (BOSApp.LookupTables.ContainsKey("MMWorkShops"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["MMWorkShops"];
                if (ds != null)
                    fld_lkeFK_MMWorkShopID.Properties.DataSource = ds.Tables[0];
            }
        }

        private void fld_lkeFK_MMMachineUnitID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductReceiptModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 5);
            }
        }

        private void fld_lkeFK_MMMachineUnitID_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (BOSApp.LookupTables.ContainsKey("MMMachineUnits"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["MMMachineUnits"];
                if (ds != null)
                    fld_lkeFK_MMMachineUnitID.Properties.DataSource = ds.Tables[0];
            }
        }
    }
}

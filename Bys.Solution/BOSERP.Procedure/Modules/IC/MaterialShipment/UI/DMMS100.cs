using BOSCommon.Constants;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialShipment.UI
{
    /// <summary>
    /// Summary description for DMMS100
    /// </summary>
    public partial class DMMS100 : BOSERPScreen
    {

        public DMMS100()
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
                ((MaterialShipmentModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((MaterialShipmentModule)Module).AdditemtoShipmentItemList();
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeObjectItemList((int)e.Value);
            }
        }

        private void fld_lkeFK_ICStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((MaterialShipmentModule)Module).ShownInventoryStocks();
        }

        private void fld_btnShowAllocationProposal_Click(object sender, EventArgs e)
        {
            ((MaterialShipmentModule)Module).ShowAllocationPlanItem();
        }

        private void fld_lkeICShipmentShipmentType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeAllocationProposalProductType(e.Value.ToString());
            }
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeOperation(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_HRDepartmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeDepartment(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductAttributeWoodTypeID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributes = new List<ICProductAttributesInfo>();
            productAttributes = objProductAttributesController.GetProductAttributeValueByWoodType();
            if (productAttributes == null)
                productAttributes = new List<ICProductAttributesInfo>();
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.DataSource = productAttributes;
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns.Clear();
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Loại nguyên liệu")});
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.DisplayMember = "ICProductAttributeValue";
            fld_lkeFK_ICProductAttributeWoodTypeID.Properties.ValueMember = "ICProductAttributeID";
        }

        private void fld_lkeICShipmentShipmentType_Validated(object sender, EventArgs e)
        {
            ((MaterialShipmentModule)Module).UpdateTotalAmount();
        }

        private void Fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (fld_lkeICShipmentShipmentType.EditValue != null)
            {
                ((MaterialShipmentModule)Module).UpdateProductLookupEditControlDataSource(string.Empty, fld_lkeICShipmentShipmentType.EditValue.ToString());
            }
        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeWorkShop(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_LineID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentModule)Module).ChangeLine(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID1_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeFK_ICProductID1.Properties.DataSource = ((MaterialShipmentModule)Module).GetBatchProductItemSerialDataSource();
        }

        private void fld_lkeFK_ICProductID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ICProductsForViewInfo dataRow = (ICProductsForViewInfo)fld_lkeFK_ICProductID1.GetSelectedDataRow();
                ((MaterialShipmentModule)Module).ChangeBatchItemList(dataRow);
            }
        }

        private void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke != null)
            {
                List<MMBatchProductsInfo> batchProducts = new List<MMBatchProductsInfo>();
                batchProducts.Add(new MMBatchProductsInfo());
                batchProducts.AddRange((new MMBatchProductsController()).GetBatchProductForMaterialShipment(BOSApp.CurrentUsersInfo.ADUserID
                                                                                                                , ModuleName.BatchProduct
                                                                                                                , ADDataViewPermissionType.Module
                                                                                                                , BOSApp.CurrentCompanyInfo.FK_BRBranchID));
                lke.Properties.DataSource = batchProducts;
            }
        }

        private void fld_lkeFK_APPurchaseOrderID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;

            List<APPurchaseOrdersInfo> purchareOrderList = ((MaterialShipmentModule)Module).GetPurcharseOrderOfBatchProduct();
            lke.Properties.DataSource = purchareOrderList;
        }

        private void fld_lkeFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if(Convert.ToInt32(lke.EditValue != DBNull.Value ? lke.EditValue : 0) != 0)
            //{
            //    ((MaterialShipmentModule)Module).DisableWorkShopLookUpEdit(false, Convert.ToInt32(lke.EditValue));
            //}    
            //else
            //{
            //    ((MaterialShipmentModule)Module).DisableWorkShopLookUpEdit(true, 0);
            //}    
        }

        private void fld_btnAutoSelectProductSerialNo_Click(object sender, EventArgs e)
        {
            ((MaterialShipmentModule)Module).AutoSelectProductSerialNo();
        }
    }
}

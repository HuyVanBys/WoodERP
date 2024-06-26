using BOSCommon;
using BOSComponent;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculatorProductionNormCost.UI
{
    /// <summary>
    /// Summary description for SMNTS100
    /// </summary>
    public partial class DMCPNC100 : BOSERPScreen
    {

        public DMCPNC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CalculatorProductionNormCostModule)Module).ShowCategoryTree();
        }

        private void fld_lkeFK_MMProcessID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int productID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            List<MMProcesssInfo> listData = ((CalculatorProductionNormCostModule)Module).GetProcessDataSource(productID);
            fld_lkeFK_MMProcessID.Properties.DataSource = listData;
            fld_lkeFK_MMProcessID.Properties.ValueMember = "MMProcessID";
            fld_lkeFK_MMProcessID.Properties.DisplayMember = "MMProcessName";
        }

        private void bosLookupEdit4_QueryPopUp(object sender, CancelEventArgs e)
        {
            int productID = 0;
            int customerID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (fld_lkeFK_ARCustomerID.EditValue != null)
                int.TryParse(fld_lkeFK_ARCustomerID.EditValue.ToString(), out customerID);
            List<MMProductionNormsInfo> listData = ((CalculatorProductionNormCostModule)Module).GetProductionNormDataSource(productID, customerID);
            fld_lkeFK_MMProductionNormID.Properties.DataSource = listData;
            fld_lkeFK_MMProductionNormID.Properties.ValueMember = "MMProductionNormID";
            fld_lkeFK_MMProductionNormID.Properties.DisplayMember = "MMProductionNormNo";
        }

        private void fld_btnCalculate_Click(object sender, EventArgs e)
        {
            string priceType = string.Empty;
            if (fld_lkeMMPriceType.EditValue == null)
            {
                MessageBox.Show("Vui lòng tính giá theo!"
                                                     , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            priceType = fld_lkeMMPriceType.EditValue.ToString();
            int productID = 0;
            int bomID = 0;
            int batchProductID = 0;
            if (priceType == PriceType.Product.ToString())
            {
                if (fld_lkeFK_ICProductID.EditValue == null)
                {
                    MessageBox.Show("Vui lòng chọn hàng hóa!"
                                          , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fld_lkeFK_MMProductionNormID.EditValue == null)
                {
                    MessageBox.Show("Vui lòng chọn bảng định mức!"
                                          , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (fld_lkeFK_MMBatchProductID.EditValue == null)
                {
                    MessageBox.Show("Vui lòng chọn LSX!"
                                              , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int processID = 0;
            if (fld_lkeFK_MMProcessID.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn quy trình sản xuất!"
                                      , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int currencyID = 0;
            if (fle_lkeFK_GECurrencyID.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn tỷ giá!"
                                      , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime effectiveDate = fld_dteMMCalculatorProductionNormCostEffectiveDate.DateTime;
            int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            int.TryParse(fld_lkeFK_MMProductionNormID.EditValue.ToString(), out bomID);
            int.TryParse(fld_lkeFK_MMProcessID.EditValue.ToString(), out processID);
            int.TryParse(fle_lkeFK_GECurrencyID.EditValue.ToString(), out currencyID);
            int.TryParse(fld_lkeFK_MMBatchProductID.EditValue.ToString(), out batchProductID);
            ((CalculatorProductionNormCostModule)Module).CalculateCost(productID, bomID, processID, currencyID, effectiveDate, priceType, batchProductID);
        }

        private void fle_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CalculatorProductionNormCostModule)Module).UpdateExchangeAmount(Convert.ToInt32(e.Value));


            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((CalculatorProductionNormCostModule)Module).RecalCost();
        }

        private void fle_lkeFK_GECurrencyID_TextChanged(object sender, EventArgs e)
        {
            ((CalculatorProductionNormCostModule)Module).ChangeCostGridFormat();
        }

        private void fld_lkeICProductHardwareID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductHardwareID.EditValue.ToString(), out productID))
                {
                    ((CalculatorProductionNormCostModule)Module).AddHardware(productID);
                }
            }
        }

        private void fld_trlHardwareList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CalculatorProductionNormCostModule)Module).RemoveSelectedItemFromProductionNormItemHardwareList();
            }
        }

        private void fld_lkeICProductMaterialID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductMaterialID.EditValue.ToString(), out productID))
                {
                    ((CalculatorProductionNormCostModule)Module).AddGeneralMaterial(productID);
                }
            }
        }

        private void fld_btnPLDGAddParent_Click(object sender, EventArgs e)
        {
            if (fld_lkePackaging.EditValue != null)
            {
                string value = fld_lkePackaging.EditValue.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    ((CalculatorProductionNormCostModule)Module).AddPLDGParent(value);
                }
            }
        }

        private void fld_btnPLDGAddChild_Click(object sender, EventArgs e)
        {
            if (fld_lkePackaging.EditValue != null)
            {
                string value = fld_lkePackaging.EditValue.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    ((CalculatorProductionNormCostModule)Module).AddPLDGChild(value);
                }
            }
        }

        private void fld_trlIngredientPackaging_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            ((CalculatorProductionNormCostModule)Module).CalculateProductionNormItemPackaging(e.Column.FieldName);

            ((CalculatorProductionNormCostModule)Module).SetDefaultPackagingDescription();
        }

        private void fld_trlIngredientPackaging_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID"
                || e.Column.FieldName == "FK_ICProdAttPackingMaterialSizeID"
                || e.Column.FieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                if (e.CellValue != null)
                    e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.CellValue.ToString()), "ICProductAttributeValue");
                else
                    e.CellText = "";
            }
        }

        private void fld_trlIngredientPackaging_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CalculatorProductionNormCostModule)Module).RemoveSelectedItemFromProductionNormItemPackagingList();
            }
        }

        private void fld_trlIngredientPackaging_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);

                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.MMCalculatorProductionNormItemIsComponent)
                {
                    if (e.Column.FieldName == "MMCalculatorProductionNormItemICProductName" ||
                        e.Column.FieldName == "MMCalculatorProductionNormItemNo" ||
                        e.Column.FieldName == "MMCalculatorProductionNormItemQuantity")
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void fld_lkeICProductIngredientPaintID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductIngredientPaintID.EditValue.ToString(), out productID))
                {
                    ((CalculatorProductionNormCostModule)Module).AddPaint(productID);
                }
            }
        }

        private void fld_trlPaint_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((CalculatorProductionNormCostModule)Module).CurrentModuleEntity;
            if (e.Column.FieldName == "MMCalculatorProductionNormItemPaint")
            {
                ((CalculatorProductionNormCostModule)Module).ChangeItemPaint();
            }
            else
            {
                ((CalculatorProductionNormCostModule)Module).ChangeItemFromPaintItemsList();
            }
        }

        private void fld_trlPaint_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CalculatorProductionNormCostModule)Module).RemoveSelectedItemFromProductionNormItemPaintList();
            }
        }

        private void bosTabControl2_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.Name == "fld_tpPaint")
            {
                CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((CalculatorProductionNormCostModule)Module).CurrentModuleEntity;
                ((CalculatorProductionNormCostModule)Module).RefreshProductItemTreeListView(entity.PaintList);
            }
        }

        private void fld_lkeFK_MMProductionNormID_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = string.Empty;

            int pnID = 0;

            if (e.Value != null)
            {
                int.TryParse(e.Value.ToString(), out pnID);
            }

            if (pnID > 0)
            {
                MMProductionNormsController pnCtrl = new MMProductionNormsController();
                MMProductionNormsInfo pn = (MMProductionNormsInfo)pnCtrl.GetObjectByID(pnID);
                if (pn != null)
                {
                    e.DisplayText = pn.MMProductionNormNo;
                }

            }
        }

        private void bosTextBox1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {


        }

        private void fld_lkeFK_ICProductID_TextChanged(object sender, EventArgs e)
        {
            int productID = 0;

            bosTextBox1.Text = string.Empty;

            if (fld_lkeFK_ICProductID.EditValue != null)
            {
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            }

            if (productID > 0)
            {
                ICProductsForViewInfo product = BOSApp.CurrentProductList.FirstOrDefault(t => t.ICProductID == productID);
                if (product != null)
                {
                    bosTextBox1.Text = product.ICProductDesc;
                }
            }
        }

        private void fld_ChartControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((CalculatorProductionNormCostModule)Module).ChangeCustomer(Convert.ToInt32(e.Value.ToString()));
            }
        }
    }
}

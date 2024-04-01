using BOSCommon;
using BOSLib;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace BOSERP.Modules.BatchProduct.UI
{
    /// <summary>
    /// Summary description for DMBP101
    /// </summary>
    public partial class DMBP101 : BOSERPScreen
    {

        public DMBP101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_trlMMBatchProductProductionNormItems_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null
                    && objProductionNormItemsInfo.MMBatchProductProductionNormItemParentID == 0
                    && objProductionNormItemsInfo.FK_ICProductID == objProductionNormItemsInfo.FK_ICProductForBatchID)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void fld_trlMMProductionNormItemsHardware_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_MMProductionNormID == 0)
                {

                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void fld_trlMMProductionNormItemsPackaging_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_MMProductionNormID == 0)
                {

                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void fld_trlMMProductionNormItemsPaint_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMBatchProductProductionNormItemsInfo objProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_MMProductionNormID == 0)
                {

                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void fld_btnUpdateWood_Click(object sender, EventArgs e)
        {
            string status = ((BatchProductModule)Module).GetBatchProductStatus(ProductType.SemiProduct.ToString());
            if (status == BatchProductStatus.Verified.ToString())
            {
                ((BatchProductModule)Module).ValidateBatchProductWood();
            }
            else
            {
                string mess;
                if (status == BatchProductStatus.New.ToString())
                {
                    mess = "Vui lòng kiểm tra BTP trước!";
                }
                else
                    mess = "LSX đã duyệt BTP!";
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void fld_btnUpdateHardware_Click(object sender, EventArgs e)
        {
            string status = ((BatchProductModule)Module).GetBatchProductStatus(ProductType.Hardware.ToString());
            if (((BatchProductModule)Module).GetBatchProductStatus(ProductType.Hardware.ToString()) == BatchProductStatus.Verified.ToString())
            {
                ((BatchProductModule)Module).ValidateBatchProductHW();

            }
            else
            {
                string mess;
                if (status == BatchProductStatus.New.ToString())
                {
                    mess = "Vui lòng kiểm tra Hardware trước!";
                }
                else
                    mess = "LSX đã duyệt Hardware!";
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void fld_btnUpdatePackaging_Click(object sender, EventArgs e)
        {
            string status = ((BatchProductModule)Module).GetBatchProductStatus(ProductType.IngredientPackaging.ToString());
            if (((BatchProductModule)Module).GetBatchProductStatus(ProductType.IngredientPackaging.ToString()) == BatchProductStatus.Verified.ToString())
            {
                ((BatchProductModule)Module).ValidateBatchProductPackaging();
            }
            else
            {
                string mess;
                if (status == BatchProductStatus.New.ToString())
                {
                    mess = "Vui lòng kiểm tra PLDG trước!";
                }
                else
                    mess = "LSX đã duyệt PLDG!";
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void fld_btnUpdatePaint_Click(object sender, EventArgs e)
        {
            string status = ((BatchProductModule)Module).GetBatchProductStatus(ProductType.IngredientPaint.ToString());
            if (((BatchProductModule)Module).GetBatchProductStatus(ProductType.IngredientPaint.ToString()) == BatchProductStatus.Verified.ToString())
            {
                ((BatchProductModule)Module).ValidateBatchProductPaint();
            }
            else
            {
                string mess;
                if (status == BatchProductStatus.New.ToString())
                {
                    mess = "Vui lòng kiểm tra Sơn trước!";
                }
                else
                    mess = "LSX đã duyệt Sơn!";
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //private void fld_trlMMBatchProductProductionNormItems_CellValueChanged(object sender, CellValueChangedEventArgs e)
        //{
        //    if (e.Column.FieldName == "MMBatchProductProductionNormItemResourceType")
        //    {
        //        ((BatchProductModule)Module).EditBatchProducProductionNormItemWoodResourceType();
        //    }
        //    else
        //    {
        //        ((BatchProductModule)Module).EditBatchProducProductionNormItemWood();
        //    }
        //}

        private void fld_trlMMProductionNormItemsHardware_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ((BatchProductModule)Module).EditBatchProducProductionNormItemHW();
        }

        private void fld_trlMMProductionNormItemsPackaging_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ((BatchProductModule)Module).EditBatchProducProductionNormItemPackaging();
        }

        private void fld_trlMMProductionNormItemsPaint_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ((BatchProductModule)Module).EditBatchProducProductionNormItemPaint();
        }

        private void fld_trlMMBatchProductProductionNormItems_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "FK_MMFormulaIDPaintA" || e.Column.FieldName == "FK_MMFormulaIDPaintB" || e.Column.FieldName == "FK_MMFormulaIDPaintC")
            {
                string value = "0";
                if (e.CellValue != null)
                    value = e.CellValue.ToString();
                if (value != string.Empty)
                    e.CellText = BOSApp.GetDisplayTextFromCatche("MMFormulas", "MMFormulaID", int.Parse(value), "MMFormulaName");
            }
            if (e.Column.FieldName == "FK_ICProductWoodIngredientID")
            {
                string value = "0";
                if (e.CellValue != null)
                    value = e.CellValue.ToString();
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(int.Parse(value));
                if (value != string.Empty && objProductsInfo != null)
                    e.CellText = objProductsInfo.ICProductName;
                else
                    e.CellText = "";
            }
            if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID")
            {
                string value = "0";
                if (e.CellValue != null)
                    value = e.CellValue.ToString();
                if (value != string.Empty)
                    e.CellText = BOSApp.GetDisplayTextFromCatche("ICDepartmentAttributeValues", "ICDepartmentAttributeValueID", int.Parse(value), "ICDepartmentAttributeValueValue");
            }
            if (e.Column.FieldName == "FK_ICProductIDReuse" || e.Column.FieldName == "FK_ICProductIDPack")
            {
                int value = 0;
                if (e.CellValue != null)
                    int.TryParse(e.CellValue.ToString(), out value);
                ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(value);
                if (value > 0 && objProductsInfo != null)
                    e.CellText = objProductsInfo.ICProductNo;
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemTotalWoodConsumable" ||
                e.Column.FieldName == "MMBatchProductProductionNormItemMDFBlocks" ||
                e.Column.FieldName == "MMBatchProductProductionNormItemPaintA" ||
                e.Column.FieldName == "MMBatchProductProductionNormItemPaintB" ||
                e.Column.FieldName == "MMBatchProductProductionNormItemVeneer")
            {
                double value = 0;
                if (e.CellValue != null)
                    double.TryParse(e.CellValue.ToString(), out value);
                if (value > 0)
                    e.CellText = Math.Round(value, 4).ToString();
                else
                    e.CellText = "-";
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemResourceType")
            {
                if (e.CellValue != null)
                {
                    e.CellText = ADConfigValueUtility.GetTextFromKey(e.CellValue.ToString(), "BatchProductProductionNormItemResourceType");
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity")
            {
                if (e.CellValue != null)
                {
                    double value = 0;
                    if (double.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = value.ToString("N2");
                    }
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemModifiedStatus")
            {
                if (e.CellValue != null)
                {
                    e.CellText = ADConfigValueUtility.GetTextFromKey(e.CellValue.ToString(), "BatchProductProductionNormItemModifiedStatus");
                }
            }
        }

        private void fld_trlMMProductionNormItemsHardware_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "MMBatchProductProductionNormItemModifiedStatus")
            {
                if (e.CellValue != null)
                {
                    e.CellText = ADConfigValueUtility.GetTextFromKey(e.CellValue.ToString(), "BatchProductProductionNormItemModifiedStatus");
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity")
            {
                if (e.CellValue != null)
                {
                    double value = 0;
                    if (double.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = value.ToString("N2");
                    }
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemHardwareAssembleQuantity")
            {
                if (e.CellValue != null)
                {
                    double value = 0;
                    if (double.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = value.ToString("N2");
                    }
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemHardwareAllocationQuantity")
            {
                if (e.CellValue != null)
                {
                    double value = 0;
                    if (double.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = value.ToString("N2");
                    }
                }
            }
        }

        private void fld_trlMMProductionNormItemsPaint_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "MMBatchProductProductionNormItemModifiedStatus")
            {
                if (e.CellValue != null)
                {
                    e.CellText = ADConfigValueUtility.GetTextFromKey(e.CellValue.ToString(), "BatchProductProductionNormItemModifiedStatus");
                }

            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity")
            {
                if (e.CellValue != null)
                {
                    double value = 0;
                    if (double.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = value.ToString("N2");
                    }
                }
            }
        }

        private void fld_trlMMProductionNormItemsPackaging_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "MMBatchProductProductionNormItemModifiedStatus")
            {
                if (e.CellValue != null)
                {
                    e.CellText = ADConfigValueUtility.GetTextFromKey(e.CellValue.ToString(), "BatchProductProductionNormItemModifiedStatus");
                }
            }
            if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity")
            {
                if (e.CellValue != null)
                {
                    double value = 0;
                    if (double.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = value.ToString("N2");
                    }
                }
            }
        }

        private void fld_tabProductionNorm_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                ((BatchProductModule)Module).RefreshTreeView(e.Page.Name);
            }
            catch (Exception ex)
            {

                return;
            }

        }

        private void DMBP101_Enter(object sender, EventArgs e)
        {
            // ((BatchProductModule)Module).RefreshWood();
        }

        private void DMBP101_Click(object sender, EventArgs e)
        {
            //((BatchProductModule)Module).RefreshWood();
        }

        private void DMBP101_MouseClick(object sender, MouseEventArgs e)
        {
            // ((BatchProductModule)Module).RefreshWood();
        }

        private void DMBP101_Load(object sender, EventArgs e)
        {

        }

        private void bosButton4_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).RefreshPackaging();
        }

        private void bosButton3_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).RefreshPaint();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).RefreshHardware();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((BatchProductModule)Module).RefreshWood();
        }

        private void fld_btnGeneralMaterial_Click(object sender, EventArgs e)
        {
            string status = ((BatchProductModule)Module).GetBatchProductStatus(ProductType.GeneralMaterial.ToString());
            if (((BatchProductModule)Module).GetBatchProductStatus(ProductType.GeneralMaterial.ToString()) == BatchProductStatus.Verified.ToString())
            {
                ((BatchProductModule)Module).ValidateGeneralMaterial();
            }
            else
            {
                string mess;
                if (status == BatchProductStatus.New.ToString())
                {
                    mess = "Vui lòng kiểm tra VTC trước!";
                }
                else
                    mess = "LSX đã duyệt VTC!";
                MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

        }

        private void fld_trlMMBatchProductProductionNormItems_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (tree == null)
                return;

            MMBatchProductProductionNormItemsInfo bppni = new MMBatchProductProductionNormItemsInfo();
            bppni = (MMBatchProductProductionNormItemsInfo)tree.GetDataRecordByNode(tree.FocusedNode);
            if (bppni != null)
            {
                if (fld_radPropertiesOrProcess.SelectedIndex == 0)
                {
                    ((BatchProductModule)Module).ShowItemMaterial(bppni);
                }
                else
                {
                    ((BatchProductModule)Module).ShowItemProcess(bppni);
                }
                //if (tree.FocusedNode != null) 
                //    tree.FocusedNode.Expand();
            }
        }
    }
}

using BOSCommon;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public partial class guiAlternative : BOSERPScreen
    {
        #region Variables
        public bool IsAlterOverConfigMaterial { get; set; }
        public MMAllocationPlanItemsInfo SourceAlternativeObj { get; set; }
        public List<ICProductAlternativesInfo> SelectedObjects { get; set; }
        public List<MMMaterialDepartmentsInfo> MaterialDepartList { get; set; }
        #endregion

        public guiAlternative(List<ICProductAlternativesInfo> products, bool _IsAlterOverConfigMaterial)
        {
            IsAlterOverConfigMaterial = _IsAlterOverConfigMaterial;
            InitializeComponent();
            SelectedObjects = products;
            SourceAlternativeObj = new MMAllocationPlanItemsInfo();
            MaterialDepartList = new List<MMMaterialDepartmentsInfo>();
        }
        public List<ICProductsForViewInfo> GetMaterialByMaterialDepart()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsForViewInfo> objProductsInfoList = new List<ICProductsForViewInfo>();
            ICProductsForViewInfo iCProductsInfo = BOSApp.GetProductFromCurrentViewProductList(SourceAlternativeObj.FK_ICProductID);
            objProductsInfoList.Add(new ICProductsForViewInfo());
            if (MaterialDepartList != null && iCProductsInfo != null)
            {
                List<ICProductsForViewInfo> result = BOSApp.CurrentProductList.Where(o => MaterialDepartList.Any(dp => dp.FK_ICDepartmentID == o.FK_ICDepartmentID
                                                                                                          && (dp.ICProducType == string.Empty || (dp.ICProducType == o.ICProductType)
                                                                                                              || (dp.MMMaterialDepartmentOtherCol1.Contains(o.ICProductType)))
                )).ToList();
                if (result != null)
                    objProductsInfoList.AddRange(result);
            }
            else
                objProductsInfoList.AddRange(BOSApp.CurrentProductList);

            return objProductsInfoList;
        }
        private void guiAlternative_Load(object sender, EventArgs e)
        {
            fld_dgcProductsGridControl.IsAlterOverConfigMaterial = IsAlterOverConfigMaterial;
            InitializeControls(Controls);
            fld_dgcProductsGridControl.SourceAlternative = SourceAlternativeObj;
            fld_txtProductName.Text = SourceAlternativeObj.MMBatchProductProductionNormItemNo;
            fld_txtProductNo.Text = SourceAlternativeObj.MMBatchProductProductionNormItemNo;
            fld_txtQty.Text = SourceAlternativeObj.MMBatchProductProductionNormItemQuantity.ToString();
            fld_txtHeigth.Text = SourceAlternativeObj.MMBatchProductProductionNormItemProductHeight.ToString();
            fld_txtWidth.Text = SourceAlternativeObj.MMBatchProductProductionNormItemProductWidth.ToString();
            fld_txtLength.Text = SourceAlternativeObj.MMBatchProductProductionNormItemProductLength.ToString();
        }
        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            if (SelectedObjects.Where(s => s.Selected == true).ToList().Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public void CalculateDetailInfo(ICProductAlternativesInfo alternativesInfo, bool isCalBlock, MMAllocationPlanItemsInfo bppni)
        {
            MMProductionNormItemConfigsController objProductionNormItemConfigsController = new MMProductionNormItemConfigsController();
            MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = objProductionNormItemConfigsController.GetProductionNormItemConfigByWoodTypeID(bppni.FK_ICProductAttributeWoodTypeID).FirstOrDefault();
            #region Khối tinh
            if (isCalBlock)
            {
                alternativesInfo.ICProductAlternativeProductQty = 0;
                if (objProductionNormItemConfigsInfo != null)
                {
                    if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks || objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks)
                    {
                        alternativesInfo.ICProductAlternativeProductQty = (
                            alternativesInfo.ICProductLength
                            * alternativesInfo.ICProductWidth
                            * alternativesInfo.ICProductHeight
                            * alternativesInfo.ICProductAlternativeCountProductQty) / (decimal)Math.Pow(10, 9);
                    }
                    else if (objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood || objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer)
                        alternativesInfo.ICProductAlternativeProductQty =
                            (alternativesInfo.ICProductLength
                            * alternativesInfo.ICProductWidth
                            * alternativesInfo.ICProductAlternativeCountProductQty) / (decimal)Math.Pow(10, 6);

                    alternativesInfo.ICProductAlternativeProductQty = Math.Round(alternativesInfo.ICProductAlternativeProductQty, 5, MidpointRounding.AwayFromZero);
                }
            }
            #endregion
            #region Phách
            MMExchangeRateConfigsController objExchangeRateConfigsController = new MMExchangeRateConfigsController();
            int productGroupID = 0;
            ICProductsForViewInfo found = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Lumber.ToString() && o.FK_ICProductGroupID > 0).FirstOrDefault();
            if (found != null) productGroupID = found.FK_ICProductGroupID;
            decimal productDryThick = alternativesInfo.ICProductHeight;
            decimal productBlocks = alternativesInfo.ICProductAlternativeProductQty;


            MMExchangeRateConfigsInfo objExchangeRateConfigsInfo = objExchangeRateConfigsController.GetExchangeRateConfigSomeCriteria(productGroupID, alternativesInfo.FK_ICProductAttributeWoodTypeID, ExchangeRateConfigLumberType.Dry.ToString());
            alternativesInfo.ICProductAlternativeProductQty = Math.Round(productBlocks * alternativesInfo.ICProductAlternativeDepreciationRate, 5, MidpointRounding.AwayFromZero);
            #endregion

        }
    }
}
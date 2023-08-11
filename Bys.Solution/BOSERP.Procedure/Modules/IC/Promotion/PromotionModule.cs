using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSLib;
using Localization;

namespace BOSERP.Modules.Promotion
{
    public class PromotionModule : BaseModuleERP
    {
        #region Declare Constant
        //promotion type
        public const String cstPromotionTypePctOff = "PercentOff";
        public const String cstPromotionTypeAmtOff = "AmountOff";
        public const String cstPromotionTypeBuyXTogetPctOff = "BuyXTogetPctOff";
        public const String cstPromotionTypeBuyXTogetAmtOff = "BuyXTogetAmtOff";
        #endregion

        public PromotionModule()
        {
            Name = "Promotion";
            CurrentModuleEntity = new PromotionEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            EnableDisableControlsByPromotionType(cstPromotionTypePctOff);
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ICPromotionsInfo objMainPromotionsInfo = (ICPromotionsInfo)CurrentModuleEntity.MainObject;
            objMainPromotionsInfo.ICPromotionEndDate = objMainPromotionsInfo.ICPromotionStartDate.AddDays(7);
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public override int ActionSave()
        {
            CalculateDiscountPriceByPromotiontype();
            return base.ActionSave();
        }

        #region--validate controls--
        public void PromotionType_Validated(object sender, EventArgs e)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                PromotionEntities entity = (PromotionEntities)CurrentModuleEntity;
                BOSComponent.BOSLookupEdit lke = (BOSComponent.BOSLookupEdit)sender;
                if (lke != null)
                {
                    if (lke.EditValue != lke.OldEditValue)
                    {
                        String strPromotionType = Convert.ToString(lke.EditValue);
                        EnableDisableControlsByPromotionType(strPromotionType);

                        //Reset relative fields
                        ICPromotionsInfo objPromotionsInfo = (ICPromotionsInfo)entity.MainObject;
                        objPromotionsInfo.ICPromotionDiscountPercent = 0;
                        objPromotionsInfo.ICPromotionDiscountAmount = 0;
                        objPromotionsInfo.ICPromotionDiscountQty = 1;
                        objPromotionsInfo.ICPromotionBuyX = 0;
                        objPromotionsInfo.ICPromotionTogetPctOff = 0;
                        objPromotionsInfo.ICPromotionTogetAmtOff = 0;
                        entity.UpdateMainObjectBindingSource();

                        //Recalculate product discount price
                        CalculateDiscountPriceByPromotiontype();
                    }
                }
            }
        }
        #endregion

        #region--calculate product promotion--
        /// <summary>
        /// Calculate product price following promotion type
        /// </summary>
        public double CalculateDiscountPriceByPromotiontype(double dbProductPrice)
        {
            double dbDiscountPrice = dbProductPrice;
            PromotionEntities entity = (PromotionEntities)CurrentModuleEntity;
            ICPromotionsInfo objPromotionsInfo = (ICPromotionsInfo)entity.MainObject;
            if (objPromotionsInfo.ICPromotionTypeCombo == PromotionModule.cstPromotionTypeBuyXTogetPctOff || objPromotionsInfo.ICPromotionTypeCombo == PromotionModule.cstPromotionTypeBuyXTogetAmtOff)
            {
                objPromotionsInfo.ICPromotionDiscountQty = objPromotionsInfo.ICPromotionBuyX;
                objPromotionsInfo.ICPromotionDiscountPercent = objPromotionsInfo.ICPromotionTogetPctOff;
                objPromotionsInfo.ICPromotionDiscountAmount = objPromotionsInfo.ICPromotionTogetAmtOff;
            }
            if (objPromotionsInfo.ICPromotionDiscountPercent > 0)
                dbDiscountPrice = dbProductPrice * objPromotionsInfo.ICPromotionDiscountQty * (1 - objPromotionsInfo.ICPromotionDiscountPercent / 100);
            else
                dbDiscountPrice = dbProductPrice * objPromotionsInfo.ICPromotionDiscountQty - objPromotionsInfo.ICPromotionDiscountAmount;
            return dbDiscountPrice;
        }

        /// <summary>
        /// Recalculate product discount when validate controls promotion
        /// </summary>
        /// 
        public void CalculateDiscountPriceByPromotiontype()
        {
            PromotionEntities entity = (PromotionEntities)CurrentModuleEntity;
            foreach (ICPromotionItemsInfo objPromotionItemsInfo in entity.ICPromotionItemsList)
                objPromotionItemsInfo.ICPromotionItemDiscountPrice = CalculateDiscountPriceByPromotiontype(objPromotionItemsInfo.ICPromotionItemRegularePrice);
            entity.ICPromotionItemsList.GridControl.RefreshDataSource();
        }
        #endregion

        #region--Enable Disable controls
        public void EnableDisableControlsByPromotionType(String strPromotionType)
        {
            if (strPromotionType.Equals(cstPromotionTypeAmtOff))
            {
                DisplayFieldGroupControls("DiscAmt", true);
                DisplayFieldGroupControls("BuyX", false);
                DisplayFieldGroupControls("DiscPct", false);
            }
            else if (strPromotionType.Equals(cstPromotionTypePctOff))
            {
                DisplayFieldGroupControls("DiscPct", true);
                DisplayFieldGroupControls("DiscAmt", false);
                DisplayFieldGroupControls("BuyX", false);
            }
            else if (strPromotionType.Equals(cstPromotionTypeBuyXTogetAmtOff))
            {
                DisplayFieldGroupControls("BuyX", true);
                DisplayFieldGroupControls("DiscAmt", false);
                DisplayFieldGroupControls("DiscPct", false);
                foreach (Control ctrl in FieldGroupControls["BuyX"].Values)
                {
                    if (ctrl.Name.Contains("Pct"))
                        ctrl.Visible = false;
                }
            }
            else if (strPromotionType.Equals(cstPromotionTypeBuyXTogetPctOff))
            {
                DisplayFieldGroupControls("BuyX", true);
                DisplayFieldGroupControls("DiscAmt", false);
                DisplayFieldGroupControls("DiscPct", false);
                foreach (Control ctrl in FieldGroupControls["BuyX"].Values)
                {
                    if (ctrl.Name.Contains("Amt"))
                        ctrl.Visible = false;
                }
            }
            else
            {
                DisplayFieldGroupControls("BuyX", true);
                DisplayFieldGroupControls("DiscAmt", false);
                DisplayFieldGroupControls("DiscPct", false);
            }
        }
        #endregion

        #region--Action click button--
        public void ChooseItems()
        {
            PromotionEntities entity = (PromotionEntities)CurrentModuleEntity;
            guiItemList<ICPromotionItemsInfo> guiItemList = new guiItemList<ICPromotionItemsInfo>(true, entity.ICPromotionItemsList);
            guiItemList.Module = this;
            guiItemList.ShowDialog();
            if (guiItemList.DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(((ICPromotionsInfo)entity.MainObject).ICPromotionTypeCombo))
                {
                    MessageBox.Show(PromotionLocalizedResources.PromotionTypeIsRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                entity.ICPromotionItemsList.Clear();
                foreach (ICProductsInfo objProductsInfo in guiItemList.ProductList)
                    if (objProductsInfo.Selected)
                    {
                        ICPromotionItemsInfo objICPromotionItemsInfo = new ICPromotionItemsInfo();
                        BOSUtil.CopyObject(objProductsInfo, objICPromotionItemsInfo);
                        objICPromotionItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                        objICPromotionItemsInfo.ICPromotionItemProductDesc = objProductsInfo.ICProductDesc;
                        objICPromotionItemsInfo.ICPromotionItemProductAttribute = objProductsInfo.ICProductAttribute;
                        objICPromotionItemsInfo.ICPromotionItemRegularePrice = objProductsInfo.ICProductPrice01;
                        objICPromotionItemsInfo.ICPromotionItemDiscountPrice = CalculateDiscountPriceByPromotiontype(objICPromotionItemsInfo.ICPromotionItemRegularePrice);
                        entity.ICPromotionItemsList.Add(objICPromotionItemsInfo);
                    }
                entity.ICPromotionItemsList.GridControl.InvalidateLookupEditColumns();
                entity.ICPromotionItemsList.GridControl.RefreshDataSource();
            }
        }

        // remove product promotion in item list
        public void DeleteProductFromPromotionItemList()
        {
            PromotionEntities entity = (PromotionEntities)CurrentModuleEntity;
            entity.ICPromotionItemsList.RemoveSelectedRowObjectFromList();
        }
        #endregion

        /// <summary>
        /// Delete a selected promotion item from its list
        /// </summary>
        public void DeleteSelectedPromotionItem()
        {
            PromotionEntities entity = (PromotionEntities)CurrentModuleEntity;
            entity.ICPromotionItemsList.RemoveSelectedRowObjectFromList();
        }
    }
}

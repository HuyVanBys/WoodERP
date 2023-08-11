using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Promotion.UI
{
	/// <summary>
	/// Summary description for DMPR100
	/// </summary>
	public partial class DMPR100 : BOSERPScreen
	{

		public DMPR100()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}
        
        private void fld_lkeICPromotionTypeCombo_Validated(object sender, EventArgs e)
        {
            ((Modules.Promotion.PromotionModule)this.Module).PromotionType_Validated(sender, e);
        }

        private void fld_txtICPromotionDiscountPercent_Validated(object sender, EventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
                ((PromotionModule)Module).CalculateDiscountPriceByPromotiontype();
        }

        private void fld_txtICPromotionDiscountAmount_Validated(object sender, EventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
                ((PromotionModule)Module).CalculateDiscountPriceByPromotiontype();
        }

        private void fld_txtICPromotionBuyX_Validated(object sender, EventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
                ((PromotionModule)Module).CalculateDiscountPriceByPromotiontype();
        }

        private void fld_txtICPromotionTogetAmtOff1_Validated(object sender, EventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
                ((PromotionModule)Module).CalculateDiscountPriceByPromotiontype();
        }

        private void fld_txtICPromotionTogetPctOff_Validated(object sender, EventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
                ((PromotionModule)Module).CalculateDiscountPriceByPromotiontype();
        }

        private void fld_btnChooseItems_Click(object sender, EventArgs e)
        {
            ((PromotionModule)Module).ChooseItems();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((PromotionModule)Module).DeleteProductFromPromotionItemList();
        }       
	}
}

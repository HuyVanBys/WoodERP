using BOSLib;


namespace BOSERP
{
    #region ICPromotionItemDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICPromotionItemDetailsController
    //Created Date:Tuesday, May 20, 2008
    //-----------------------------------------------------------

    public class ICPromotionItemDetailsController : BaseBusinessController
    {
        public ICPromotionItemDetailsController()
        {
            dal = new DALBaseProvider("ICPromotionItemDetails", typeof(ICPromotionItemDetailsInfo));
        }
    }
    #endregion
}
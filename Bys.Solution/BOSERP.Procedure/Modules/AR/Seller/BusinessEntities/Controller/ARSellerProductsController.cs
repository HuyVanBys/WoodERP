using BOSLib;


namespace BOSERP
{
    #region ARSellerProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSellerProductsController
    //Created Date:Friday, March 14, 2008
    //-----------------------------------------------------------

    public class ARSellerProductsController : BaseBusinessController
    {
        public ARSellerProductsController()
        {
            dal = new DALBaseProvider("ARSellerProducts", typeof(ARSellerProductsInfo));
        }
    }
    #endregion
}
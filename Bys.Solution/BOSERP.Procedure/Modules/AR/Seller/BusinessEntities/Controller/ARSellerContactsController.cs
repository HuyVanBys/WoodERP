using BOSLib;


namespace BOSERP
{
    #region ARSellerContacts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSellerContactsController
    //Created Date:Friday, March 14, 2008
    //-----------------------------------------------------------

    public class ARSellerContactsController : BaseBusinessController
    {
        public ARSellerContactsController()
        {
            dal = new DALBaseProvider("ARSellerContacts", typeof(ARSellerContactsInfo));
        }
    }
    #endregion
}
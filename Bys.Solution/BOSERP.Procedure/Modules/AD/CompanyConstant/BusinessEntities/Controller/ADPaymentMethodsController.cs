using BOSLib;


namespace BOSERP
{
    #region ADPaymentMethods
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADPaymentMethodsController
    //Created Date:Sunday, April 01, 2007
    //-----------------------------------------------------------

    public class ADPaymentMethodsController : BaseBusinessController
    {
        public ADPaymentMethodsController()
        {
            dal = new DALBaseProvider("ADPaymentMethods", typeof(ADPaymentMethodsInfo));
        }
    }
    #endregion
}
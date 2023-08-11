using BOSLib;
using System;
using System.Data;


namespace BOSERP
{
    #region ARPriceListDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARPriceListDetailsController
    //Created Date:Monday, March 10, 2008
    //-----------------------------------------------------------

    public class ARPriceListDetailsController : BaseBusinessController
    {
        private readonly string spGetPriceListDetailsByPriceListAndPriceListDateAndProductAndProductQtyAndCurrency =
                                "ARPriceListDetails_SelectByPriceListAndPriceListDateAndProductAndProductQtyAndAndCurrency";
        public ARPriceListDetailsController()
        {
            dal = new DALBaseProvider("ARPriceListDetails", typeof(ARPriceListDetailsInfo));
        }

        public DataSet GetPriceListDetailsByPriceListAndPriceListDateAndProductAndProductQtyAndCurrency(
                        int iARPriceListID, DateTime dtARPriceListDetailDate, int iICProductID, double dbARProductQty, int iGECurrencyID)
        {
            return (DataSet)dal.GetDataSet(spGetPriceListDetailsByPriceListAndPriceListDateAndProductAndProductQtyAndCurrency,
                                            iARPriceListID, dtARPriceListDetailDate, iICProductID, dbARProductQty, iGECurrencyID);
        }
    }
    #endregion
}
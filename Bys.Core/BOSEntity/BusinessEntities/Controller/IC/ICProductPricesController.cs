using BOSLib;
using System;
using System.Data;


namespace BOSERP
{
    #region ICProductPrices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductPricesController
    //Created Date:Wednesday, March 17, 2010
    //-----------------------------------------------------------

    public class ICProductPricesController : BaseBusinessController
    {
        public ICProductPricesController()
        {
            dal = new DALBaseProvider("ICProductPrices", typeof(ICProductPricesInfo));
        }

        public ICProductPricesInfo GetProductPriceByProductIDAndPriceLevelID(int productID, int priceLevelID)
        {
            String query = String.Format("SELECT * FROM ICProductPrices WHERE AAStatus = 'Alive' AND FK_ICProductID = {0} AND FK_ARPriceLevelID = {1}", productID, priceLevelID);
            DataSet ds = GetDataSet(query);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ICProductPricesInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
    }
    #endregion
}
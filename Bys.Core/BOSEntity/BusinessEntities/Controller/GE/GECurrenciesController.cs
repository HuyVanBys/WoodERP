using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region GECurrencies
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GECurrenciesController
    //Created Date:Monday, March 10, 2008
    //-----------------------------------------------------------

    public class GECurrenciesController : BaseBusinessController
    {
        public GECurrenciesController()
        {
            dal = new DALBaseProvider("GECurrencies", typeof(GECurrenciesInfo));
        }

        /// <summary>
        /// Get all currencies
        /// </summary>
        /// <returns>List of currencies</returns>
        public List<GECurrenciesInfo> GetAllCurrencys()
        {
            DataSet ds = GetAllObjects();
            List<GECurrenciesInfo> currencys = new List<GECurrenciesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GECurrenciesInfo objCurrencyInfo = (GECurrenciesInfo)GetObjectFromDataRow(row);
                    currencys.Add(objCurrencyInfo);
                }
            }
            ds.Dispose();
            return currencys;
        }
        public DataSet GetFormatCurrencys()
        {
            DataSet ds = dal.GetDataSet("GECurrencies_GetFormatCurrencys");
            return ds;
        }
        public GECurrenciesInfo GetDefaultCurrency()
        {
            DataSet ds = dal.GetDataSet("GECurrencies_GetDefaultCurrency");
            if (ds.Tables[0].Rows.Count > 0)
            {
                GECurrenciesInfo objCurrencysInfo = (GECurrenciesInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objCurrencysInfo;
            }
            ds.Dispose();
            return null;
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<GECurrenciesInfo> Currencies = new List<GECurrenciesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)GetObjectFromDataRow(row);
                    Currencies.Add(objCurrenciesInfo);
                }
            }
            ds.Dispose();
            return Currencies;
        }
        public List<GECurrenciesInfo> GetListDataSet(DataSet ds)
        {
            List<GECurrenciesInfo> Currencies = new List<GECurrenciesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)GetObjectFromDataRow(row);
                    Currencies.Add(objCurrenciesInfo);
                }
            }
            ds.Dispose();
            return Currencies;
        }
    }
    #endregion
}
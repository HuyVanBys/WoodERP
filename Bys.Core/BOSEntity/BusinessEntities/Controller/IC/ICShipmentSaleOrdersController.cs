using BOSLib;
using System.Data;


namespace BOSERP
{
    #region ICShipmentSaleOrders
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICShipmentSaleOrdersController
    //Created Date:Monday, April 14, 2008
    //-----------------------------------------------------------

    public class ICShipmentSaleOrdersController : BaseBusinessController
    {
        public ICShipmentSaleOrdersController()
        {
            dal = new DALBaseProvider("ICShipmentSaleOrders", typeof(ICShipmentSaleOrdersInfo));
        }

        public DataSet GetShipmentSaleOrderByCurrentDate()
        {
            DataSet ds = dal.GetDataSet("ICShipments_GetShipmentSaleOrderByCurrentDate");
            return ds;
        }
    }
    #endregion
}
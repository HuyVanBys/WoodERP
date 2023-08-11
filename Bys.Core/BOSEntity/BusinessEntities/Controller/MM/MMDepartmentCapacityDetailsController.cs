using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMDepartmentCapacityDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMDepartmentCapacityDetailsController
    //Created Date:Saturday, April 06, 2019
    //-----------------------------------------------------------

    public class MMDepartmentCapacityDetailsController : BaseBusinessController
    {
        public MMDepartmentCapacityDetailsController()
        {
            dal = new DALBaseProvider("MMDepartmentCapacityDetails", typeof(MMDepartmentCapacityDetailsInfo));
        }
        public List<MMDepartmentCapacityDetailsInfo> GetAllDetail()
        {
            DataSet ds = dal.GetDataSet("MMDepartmentCapacityDetails_GetAllDetail");
            return (List<MMDepartmentCapacityDetailsInfo>)GetListFromDataSet(ds);

        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMDepartmentCapacityDetailsInfo> products = new List<MMDepartmentCapacityDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMDepartmentCapacityDetailsInfo objProductsInfo = (MMDepartmentCapacityDetailsInfo)GetObjectFromDataRow(row);
                    products.Add(objProductsInfo);
                }
            }
            ds.Dispose();
            return products;
        }
    }
    #endregion
}
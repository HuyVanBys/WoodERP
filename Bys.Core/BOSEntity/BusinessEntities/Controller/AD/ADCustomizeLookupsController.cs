using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    public class ADCustomizeLookupsController : BaseBusinessController
    {
        public ADCustomizeLookupsController()
        {
            dal = new DALBaseProvider("ADCustomizeLookups", typeof(ADCustomizeLookupsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ADCustomizeLookupsInfo> customizeLookupList = new List<ADCustomizeLookupsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADCustomizeLookupsInfo objCustomizeLookupsInfo = (ADCustomizeLookupsInfo)GetObjectFromDataRow(row);
                    customizeLookupList.Add(objCustomizeLookupsInfo);
                }
            }
            ds.Dispose();
            return customizeLookupList;
        }

        public List<ADCustomizeLookupsInfo> GetDataSourceForProductTempalteByType(string productTemplateItemType)
        {
            DataSet ds = dal.GetDataSet("ADCustomizeLookups_GetDataSourceForProductTempalteByType", productTemplateItemType);
            return (List<ADCustomizeLookupsInfo>)GetListFromDataSet(ds);
        }
    }
}

using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARCustomerContacts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCustomerContactsController
    //Created Date:Saturday, March 15, 2008
    //-----------------------------------------------------------

    public class ARCustomerContactsController : BaseBusinessController
    {
        public ARCustomerContactsController()
        {
            dal = new DALBaseProvider("ARCustomerContacts", typeof(ARCustomerContactsInfo));
        }

        public List<ARCustomerContactsInfo> GetARCustomerContactsListByARCustomerIDAndARCustomerContactType(int iARCustomerID, String strARCustomerContactType)
        {
            List<ARCustomerContactsInfo> lstARCustomerContactsInfo = new List<ARCustomerContactsInfo>();

            DataSet dsARCustomerContacts = GetAllDataByForeignColumn("FK_ARCustomerID", iARCustomerID);
            if (dsARCustomerContacts.Tables.Count > 0)
            {
                foreach (DataRow rowARCustomerContact in dsARCustomerContacts.Tables[0].Rows)
                {
                    ARCustomerContactsInfo objARCustomerContactsInfo = (ARCustomerContactsInfo)GetObjectFromDataRow(rowARCustomerContact);
                    if (objARCustomerContactsInfo.ARContactType.Contains(strARCustomerContactType))
                        lstARCustomerContactsInfo.Add(objARCustomerContactsInfo);
                }
            }

            return lstARCustomerContactsInfo;
        }

        public List<ARCustomerContactsInfo> GetARCustomerContactsListByARCustomerID(int iARCustomerID)
        {
            DataSet dsARCustomerContacts = dal.GetDataSet("ARCustomerContacts_GetListCustomer", iARCustomerID);
            List<ARCustomerContactsInfo> lstARCustomerContactsInfo = new List<ARCustomerContactsInfo>();
            //DataSet dsARCustomerContacts = dal.GetAllDataByForeignColumn("FK_ARCustomerID", iARCustomerID);
            if (dsARCustomerContacts.Tables.Count > 0)
            {
                foreach (DataRow rowARCustomerContact in dsARCustomerContacts.Tables[0].Rows)
                {
                    ARCustomerContactsInfo objARCustomerContactsInfo = (ARCustomerContactsInfo)GetObjectFromDataRow(rowARCustomerContact);
                    lstARCustomerContactsInfo.Add(objARCustomerContactsInfo);
                }
            }

            return lstARCustomerContactsInfo;
        }
    }
    #endregion
}
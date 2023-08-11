using System;

namespace BOSLib
{
    public class BusinessObjectFactory
    {
        public static BusinessObject GetBusinessObject(String strBusinessObjectName)
        {
            object businessObject = BaseClassFactory.GetClass("BOSERP." + strBusinessObjectName);
            if (businessObject == null)
                businessObject = BaseClassFactory.GetClass("BOSLib." + strBusinessObjectName);
            return (BusinessObject)businessObject;
        }

        public static Type GetBusinessObjectType(String strBusinessObjectName)
        {
            BusinessObject objBusinessObject = GetBusinessObject(strBusinessObjectName);
            if (objBusinessObject != null)
                return objBusinessObject.GetType();
            return null;
        }


    }
}

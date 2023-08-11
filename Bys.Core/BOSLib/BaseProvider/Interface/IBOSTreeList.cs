using System;
using System.Collections;

namespace BOSLib
{
    public interface IBOSTreeList : IBOSList<BOSTreeListObject>
    {
        bool CheckAll { get; set; }
        BOSTreeListObject CurrentObject { get; set; }

        void InvalidateTreeList(int iObjectID);
        void InvalidateTreeList(int iObjectID, bool checkAll);
        BOSTreeListObject GetSelectedObject();
        BOSTreeListObject GetObjectByPropertyNameAndValue(string strPropertyName, object objPropertyValue);
        BOSTreeListObject GetObjectByTemplateObject(BOSTreeListObject objTemplateObject, params String[] propertyNames);
        void GetLastNodes(IBOSList<BOSTreeListObject> lst);
        void Invalidate(IList lst, int parentID);
        void SetValueToList(string propertyName, object value);
        void ConvertToList(IList list);
        void SaveItemObjectsNoneReference();
    }
}

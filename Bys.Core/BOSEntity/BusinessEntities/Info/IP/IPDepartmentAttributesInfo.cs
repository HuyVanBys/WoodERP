using BOSLib;

namespace BOSERP
{
    public class IPDepartmentAttributesInfo : BusinessObject
    {
        public string ICDepartmentAttributeName { get; set; }       //Tên thuộc tính

        public string ICDepartmentAttributeValueNo { get; set; }    //Mã giá trị

        public string ICDepartmentAttributeValueValue { get; set; }  //Giá trị

        public int FK_ICDepartmentAttributeID { get; set; }

        #region Extra
        public string MessageError { get; set; }
        #endregion
    }
}


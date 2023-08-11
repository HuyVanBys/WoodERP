using BOSLib;

namespace BOSERP
{
    public class IPProductGroupsInfo : BusinessObject
    {
        public string IPProductGroupParentNo { get; set; }                  //Mã nhóm hàng cha

        public string IPProductGroupParentName { get; set; }                //Tên nhóm hàng cha

        public string IPProductGroupNo { get; set; }                        //Mã nhóm hàng

        public string IPProductGroupName { get; set; }                      //Tên nhóm hàng

        public int IPProductGroupConfigStart { get; set; } = 0;             //Số tự động

        public int IPProductGroupConfigLength { get; set; } = 0;            //Độ dài số

        public int IPProductGroupConfigGroupNoLength { get; set; } = 0;     //Độ dài ký tự Nhóm hàng

        public string IPProductTypeAccountConfigName { get; set; }          //Nhóm tài khoản

        public int FK_ICProductTypeAccountConfigID { get; set; } = 0;

        #region Extra
        public string MessageError { get; set; }
        #endregion
    }
}


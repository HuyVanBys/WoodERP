using BOSLib;

namespace BOSERP
{
    public class EmployeeSaleDetailController : BaseBusinessController
    {
        public EmployeeSaleDetailController()
        {
            dal = new DALBaseProvider("EmployeeSaleDetail", typeof(EmployeeSaleDetailInfo));
        }
    }
}

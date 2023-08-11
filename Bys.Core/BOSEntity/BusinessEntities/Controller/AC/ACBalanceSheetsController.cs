using BOSLib;

namespace BOSERP
{
    public class ACBalanceSheetsController : BaseBusinessController
    {
        public ACBalanceSheetsController()
        {
            dal = new DALBaseProvider("ACBalanceSheets", typeof(ACBalanceSheetsInfo));
        }
    }
}

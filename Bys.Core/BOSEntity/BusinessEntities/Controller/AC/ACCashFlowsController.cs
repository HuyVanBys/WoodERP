using BOSLib;

namespace BOSERP
{
    public class ACCashFlowsController : BaseBusinessController
    {
        public ACCashFlowsController()
        {
            dal = new DALBaseProvider("ACCashFlows", typeof(ACCashFlowsInfo));
        }
    }
}

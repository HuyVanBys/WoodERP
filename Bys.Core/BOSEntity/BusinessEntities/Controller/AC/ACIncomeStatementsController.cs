using BOSLib;

namespace BOSERP
{
    public class ACIncomeStatementsController : BaseBusinessController
    {
        public ACIncomeStatementsController()
        {
            dal = new DALBaseProvider("ACIncomeStatements", typeof(ACIncomeStatementsInfo));
        }
    }
}

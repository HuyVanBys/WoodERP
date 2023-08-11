using BOSLib;

namespace BOSERP
{
    public class OwingDetailsController : BaseBusinessController
    {
        public OwingDetailsController()
        {
            dal = new DALBaseProvider(string.Empty, typeof(OwingDetailsInfo));
        }
    }
}

using BOSLib;


namespace BOSERP
{
    #region ICTransferLogs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICTransferLogsController
    //Created Date:Friday, July 11, 2008
    //-----------------------------------------------------------

    public class ICTransferLogsController : BaseBusinessController
    {
        public ICTransferLogsController()
        {
            dal = new DALBaseProvider("ICTransferLogs", typeof(ICTransferLogsInfo));
        }
    }
    #endregion
}
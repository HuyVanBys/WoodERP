namespace BOSLib
{
    #region GEMessages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEMessagesController
    //Created Date:Sunday, April 13, 2008
    //-----------------------------------------------------------

    public class GEMessagesController : BaseBusinessController
    {
        public GEMessagesController()
        {
            dal = new DALBaseProvider("GEMessages", typeof(GEMessagesInfo));
        }
    }
    #endregion
}
using BOSLib;


namespace BOSERP
{
    #region HRProductPieceWages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRProductPieceWagesController
    //Created Date:Monday, October 16, 2017
    //-----------------------------------------------------------

    public class HRProductPieceWagesController : BaseBusinessController
    {
        public HRProductPieceWagesController()
        {
            dal = new DALBaseProvider("HRProductPieceWages", typeof(HRProductPieceWagesInfo));
        }
    }
    #endregion
}
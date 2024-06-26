using System;

namespace BOSLib
{
    #region STToolbarFunctionParameters
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STToolbarFunctionParametersController
    //Created Date:Thursday, March 29, 2007
    //-----------------------------------------------------------

    public class STToolbarFunctionParametersController : BaseBusinessController
    {
        private readonly string spGetSTToolbarFunctionParametersBySTToolbarFunctionIDAndSTToolbarFunctionParameterName =
                                "STToolbarFunctionParameters_SelectBySTToolbarFunctionIDAndSTToolbarFunctionParameterName";
        public STToolbarFunctionParametersController()
        {
            dal = new DALBaseProvider("STToolbarFunctionParameters", typeof(STToolbarFunctionParametersInfo));
        }

        public STToolbarFunctionParametersInfo GetToolbarFunctionParameterByToolbarIDAndToolbarFunctionParameterName(int iToolbarFunctionID, String strToolbarFunctionParameterName)
        {
            return (STToolbarFunctionParametersInfo)dal.GetDataObject(spGetSTToolbarFunctionParametersBySTToolbarFunctionIDAndSTToolbarFunctionParameterName,
                                                                         iToolbarFunctionID, strToolbarFunctionParameterName);
        }
    }
    #endregion
}
﻿using BOSLib;


namespace BOSERP
{
    #region MMProductionCostFormulas
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostFormulasController
    //Created Date:Thursday, September 20, 2018
    //-----------------------------------------------------------

    public class MMProductionCostFormulasController : BaseBusinessController
    {
        public MMProductionCostFormulasController()
        {
            dal = new DALBaseProvider("MMProductionCostFormulas", typeof(MMProductionCostFormulasInfo));

        }

        public MMProductionCostFormulasInfo GetFormulaByBatchProductID(int batchProductID)
        {
            MMProductionCostFormulasInfo batchProduct = dal.GetDataObject("MMProductionCostFormulas_GetFormulaByBatchProductID", batchProductID) as MMProductionCostFormulasInfo;
            return batchProduct;
        }

    }
    #endregion
}
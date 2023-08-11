using System.Data;

namespace BOSERP.Modules.HRProductPieceWage
{
    public class HRProductPieceWageModule : BaseModuleERP
    {
        public HRProductPieceWageModule()
        {
            Name = "HRProductPieceWage";
            CurrentModuleEntity = new HRProductPieceWageEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        public override int ActionSave()
        {
            HRProductPieceWageEntities entity = (HRProductPieceWageEntities)CurrentModuleEntity;
            HRProductPieceWagesInfo obj = (HRProductPieceWagesInfo)entity.MainObject;

            return base.ActionSave();
        }
        public override void ActionEdit()
        {
            if (!isInvalidate)
            {
                base.ActionEdit();
            }
        }

        public bool isInvalidate = false;
        public override void Invalidate(int iObjectID)
        {
            isInvalidate = true;
            base.Invalidate(iObjectID);
            HRProductPieceWageEntities entity = (HRProductPieceWageEntities)CurrentModuleEntity;
            HRProductPieceWagesInfo objEmployeePieceWagesInfo = (HRProductPieceWagesInfo)entity.MainObject;
            isInvalidate = false;
        }

        public override void ActionNew()
        {
            base.ActionNew();
        }

        /// <summary>
        /// Search employee from query
        /// </summary>
        /// <param name="searchQuery"></param>
        public void SearchEmployee(string searchQuery)
        {
            HRProductPieceWageEntities entity = (HRProductPieceWageEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet ds = objEmployeesController.GetDataSet(searchQuery);
        }
    }
}

using System.Windows.Forms;

namespace BOSERP.Modules.Branch
{
    class BranchModule : BaseModuleERP
    {
        public BranchModule()
        {
            Name = "Branch";
            CurrentModuleEntity = new BranchEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        /// <summary>
        /// Choose location for branch
        /// </summary>
        public void ChooseLocation()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            BranchEntities entity = (BranchEntities)CurrentModuleEntity;
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)entity.MainObject;
            guiChooseLocation locationForm = new guiChooseLocation(objBranchsInfo.FK_GELocationID);
            locationForm.Module = this;
            if (locationForm.ShowDialog() == DialogResult.OK)
            {
                GELocationsController objLocationsController = new GELocationsController();
                GELocationsInfo objLocationsInfo = (GELocationsInfo)locationForm.LocationTreeList.GetSelectedObject();
                if (objLocationsInfo != null && objLocationsInfo.Selected)
                {
                    objBranchsInfo.FK_GELocationID = objLocationsInfo.GELocationID;
                    objBranchsInfo.GELocationName = objLocationsController.GetFullLocationNameByID(objLocationsInfo.GELocationID);
                }
                else
                {
                    objBranchsInfo.FK_GELocationID = 0;
                    objBranchsInfo.GELocationName = string.Empty;
                }
                entity.UpdateMainObjectBindingSource();
            }
        }
    }
}

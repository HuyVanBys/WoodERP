using BOSCommon.Constants;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Location
{
    public class LocationModule : BaseModuleERP
    {
        public LocationModule()
        {
            Name = "Location";
            CurrentModuleEntity = new LocationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        /// <summary>
        /// Add location to the location list
        /// </summary>
        public void AddLocation()
        {
            string[] arrLocationType = { "Country", "Region", "StateProvince", "District", "Ward", "Street" };
            LocationEntities entity = (LocationEntities)CurrentModuleEntity;
            GELocationsInfo objLocationsInfo = (GELocationsInfo)entity.ModuleObjects[TableName.GELocationsTableName];
            int locationParentID = objLocationsInfo.GELocationID;
            int locationIndex = Array.IndexOf(arrLocationType, objLocationsInfo.GELocationType);
            string locationType = "";
            if (locationIndex >= arrLocationType.Length - 2)
            {
                MessageBox.Show(CustomerLocalizedResources.LocationLevelInCorrect, CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            locationType = arrLocationType[locationIndex + 1];
            entity.SetDefaultModuleObject(TableName.GELocationsTableName);
            guiAddLocation addLocationForm = new guiAddLocation();
            addLocationForm.Module = this;
            if (addLocationForm.ShowDialog() == DialogResult.OK)
            {
                objLocationsInfo = (GELocationsInfo)entity.ModuleObjects[TableName.GELocationsTableName];
                objLocationsInfo.GELocationParentID = locationParentID;
                objLocationsInfo.GELocationType = locationType;
                // Save the current location to database
                objLocationsInfo.GELocationID = entity.SaveLocation(objLocationsInfo);
                if (entity.LocationTreeList.CurrentObject.SubList == null)
                    entity.LocationTreeList.CurrentObject.SubList = new BOSTreeList();
                entity.LocationTreeList.CurrentObject.SubList.Add(objLocationsInfo);
                entity.LocationTreeList.TreeListControl.RefreshDataSource();
            }
            else
            {
                entity.LocationTreeList.TreeListControl.RefreshDataSource();
                base.ActionCancel();
            }
        }

        /// <summary>
        /// Edit location item from location tree list control
        /// </summary>
        public void EditLocation()
        {
            LocationEntities entity = (LocationEntities)CurrentModuleEntity;
            GELocationsInfo objLocationsInfo = (GELocationsInfo)entity.ModuleObjects[TableName.GELocationsTableName];
            objLocationsInfo.BackupObject = (GELocationsInfo)objLocationsInfo.Clone();
            guiAddLocation addLocationForm = new guiAddLocation();
            addLocationForm.Module = this;
            if (addLocationForm.ShowDialog() == DialogResult.OK)
            {
                entity.LocationTreeList.ChangeObjectFromList();
                entity.SaveLocation(objLocationsInfo);
            }
            else
            {
                objLocationsInfo = (GELocationsInfo)objLocationsInfo.BackupObject;
                entity.LocationTreeList.TreeListControl.RefreshDataSource();
                base.ActionCancel();
            }    
        }

        public void DeleteSelectedLocation()
        {
            if (MessageBox.Show(LocationLocalizedResources.ConfirmDeleteLocation, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LocationEntities entity = (LocationEntities)CurrentModuleEntity;
                GELocationsInfo objLocationsInfo = (GELocationsInfo)entity.ModuleObjects[TableName.GELocationsTableName];
                entity.LocationTreeList.RemoveSelectedRowObjectFromList();
                entity.DeleteSelectedItemFromLocationList(objLocationsInfo);
            }
        }

        /// <summary>
        /// Check whether the inputed location info is valid or not
        /// </summary>
        /// <returns>True if the location info is valid, otherwise false</returns>
        public bool CheckForValidLocation()
        {
            LocationEntities entity = (LocationEntities)CurrentModuleEntity;
            GELocationsInfo objLocationsInfo = (GELocationsInfo)entity.ModuleObjects[TableName.GELocationsTableName];
            if (string.IsNullOrEmpty(objLocationsInfo.GELocationName))
            {
                MessageBox.Show(LocationLocalizedResources.LocationNameIsNullErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

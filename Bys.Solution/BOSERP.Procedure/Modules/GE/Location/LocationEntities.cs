using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.Location
{
    public class LocationEntities : ERPModuleEntities
    {
        #region Properties
        /// <summary>
        /// Gets or sets location tree list
        /// </summary>
        public BOSTreeList LocationTreeList { get; set; }
        #endregion

        public LocationEntities()
            : base()
        {
            LocationTreeList = new BOSTreeList();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.GELocationsTableName, new GELocationsInfo());
        }

        public override void InitModuleObjectList()
        {
            LocationTreeList.InitBOSList(this,
                                    String.Empty,
                                    TableName.GELocationsTableName,
                                    BOSTreeList.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            LocationTreeList.InitBOSTreeListControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                LocationTreeList.SetDefaultListAndRefreshTreeListControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// Save location
        /// </summary>
        /// <param name="objLocationsInfo"></param>
        /// <returns></returns>
        public int SaveLocation(GELocationsInfo objLocationsInfo)
        {
            switch (objLocationsInfo.GELocationType)
            {
                case "Country":
                    return SaveCountryLocation(objLocationsInfo);
                case "Region":
                    return SaveRegionLocation(objLocationsInfo);
                case "StateProvince":
                    return SaveStateProvinceLocation(objLocationsInfo);
                case "District":
                    return SaveDistrictLocation(objLocationsInfo);
                case "Ward":
                    return SaveWardLocation(objLocationsInfo);
                case "Street":
                    return SaveStreetLocation(objLocationsInfo);
            }
            return 0;
        }

        private int SaveCountryLocation(GELocationsInfo objLocationsInfo)
        {
            int countrysID = 0;
            int locationID = 0;
            GELocationsController objLocationsController = new GELocationsController();
            GECountrysController objCountrysController = new GECountrysController();
            GECountrysInfo objCountrysInfo = new GECountrysInfo();
            if (objLocationsInfo.FK_GEObjectID > 0)
                objCountrysInfo = (GECountrysInfo)objCountrysController.GetObjectByID(objLocationsInfo.FK_GEObjectID);
            objCountrysInfo.GECountryName = objLocationsInfo.GELocationName;
            objCountrysInfo.GECountryCode = objLocationsInfo.GELocationCode;
            if (objCountrysInfo.GECountryID > 0)
                countrysID = objCountrysController.UpdateObject(objCountrysInfo);
            else
                countrysID = objCountrysController.CreateObject(objCountrysInfo);

            objLocationsInfo.FK_GEObjectID = countrysID;
            if (objLocationsInfo.GELocationID == 0)
            {
                locationID = objLocationsController.CreateObject(objLocationsInfo);
            }
            else
                locationID = objLocationsController.UpdateObject(objLocationsInfo);
            return locationID;
        }

        private int SaveRegionLocation(GELocationsInfo objLocationsInfo)
        {
            int regionID = 0;
            int locationID = 0;
            GELocationsController objLocationsController = new GELocationsController();
            GELocationsInfo objLocationParentInfo = (GELocationsInfo)objLocationsController.GetObjectByID(objLocationsInfo.GELocationParentID);
            GERegionsController objRegionsController = new GERegionsController();
            GERegionsInfo objRegionsInfo = new GERegionsInfo();
            if (objLocationsInfo.FK_GEObjectID > 0)
                objRegionsInfo = (GERegionsInfo)objRegionsController.GetObjectByID(objLocationsInfo.FK_GEObjectID);
            objRegionsInfo.GERegionName = objLocationsInfo.GELocationName;
            objRegionsInfo.GERegionCode = objLocationsInfo.GELocationCode;
            if (objLocationParentInfo != null && objLocationParentInfo.FK_GEObjectID > 0)
                objRegionsInfo.FK_GECountryID = objLocationParentInfo.FK_GEObjectID;

            if (objRegionsInfo.GERegionID > 0)
                regionID = objRegionsController.UpdateObject(objRegionsInfo);
            else
                regionID = objRegionsController.CreateObject(objRegionsInfo);
            objLocationsInfo.FK_GEObjectID = regionID;
            if (objLocationsInfo.GELocationID == 0)
            {
                locationID = objLocationsController.CreateObject(objLocationsInfo);
            }
            else
                locationID = objLocationsController.UpdateObject(objLocationsInfo);
            return locationID;
        }

        private int SaveStateProvinceLocation(GELocationsInfo objLocationsInfo)
        {
            int stateProvinceID = 0;
            int locationID = 0;
            GELocationsController objLocationsController = new GELocationsController();
            GELocationsInfo objLocationParentInfo = (GELocationsInfo)objLocationsController.GetObjectByID(objLocationsInfo.GELocationParentID);

            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            GEStateProvincesInfo objStateProvincesInfo = new GEStateProvincesInfo();

            if (objLocationsInfo.FK_GEObjectID > 0)
                objLocationParentInfo = (GELocationsInfo)objStateProvincesController.GetObjectByID(objLocationsInfo.FK_GEObjectID);
            objStateProvincesInfo.GEStateProvinceName = objLocationsInfo.GELocationName;
            objStateProvincesInfo.GEStateProvinceCode = objLocationsInfo.GELocationCode;
            if (objLocationParentInfo != null && objLocationParentInfo.FK_GEObjectID > 0)
                objStateProvincesInfo.FK_GERegionID = objLocationParentInfo.FK_GEObjectID;

            if (objStateProvincesInfo.GEStateProvinceID > 0)
                stateProvinceID = objStateProvincesController.UpdateObject(objStateProvincesInfo);
            else
                stateProvinceID = objStateProvincesController.CreateObject(objStateProvincesInfo);
            objLocationsInfo.FK_GEObjectID = stateProvinceID;
            if (objLocationsInfo.GELocationID == 0)
            {
                locationID = objLocationsController.CreateObject(objLocationsInfo);
            }
            else
                locationID = objLocationsController.UpdateObject(objLocationsInfo);
            return locationID;
        }

        private int SaveDistrictLocation(GELocationsInfo objLocationsInfo)
        {
            int districtID = 0;
            int locationID = 0;
            GELocationsController objLocationsController = new GELocationsController();
            GELocationsInfo objLocationParentInfo = (GELocationsInfo)objLocationsController.GetObjectByID(objLocationsInfo.GELocationParentID);
            GEDistrictsController objDistrictsController = new GEDistrictsController();
            GEDistrictsInfo objDistrictsInfo = new GEDistrictsInfo();
            if (objLocationsInfo.FK_GEObjectID > 0)
                objDistrictsInfo = (GEDistrictsInfo)objDistrictsController.GetObjectByID(objLocationsInfo.FK_GEObjectID);
            objDistrictsInfo.GEDistrictName = objLocationsInfo.GELocationName;
            objDistrictsInfo.GEDistrictCode = objLocationsInfo.GELocationCode;
            if (objLocationParentInfo != null && objLocationParentInfo.FK_GEObjectID > 0)
                objDistrictsInfo.FK_GEStateProvinceID = objLocationParentInfo.FK_GEObjectID;

            if (objDistrictsInfo.GEDistrictID > 0)
                districtID = objDistrictsController.UpdateObject(objDistrictsInfo);
            else
                districtID = objDistrictsController.CreateObject(objDistrictsInfo);
            objLocationsInfo.FK_GEObjectID = districtID;
            if (objLocationsInfo.GELocationID == 0)
            {
                locationID = objLocationsController.CreateObject(objLocationsInfo);
            }
            else
                locationID = objLocationsController.UpdateObject(objLocationsInfo);
            return locationID;
        }

        private int SaveWardLocation(GELocationsInfo objLocationsInfo)
        {
            int wardID = 0;
            int locationID = 0;
            GELocationsController objLocationsController = new GELocationsController();
            GELocationsInfo objLocationParentInfo = (GELocationsInfo)objLocationsController.GetObjectByID(objLocationsInfo.GELocationParentID);
            GEWardsController objWardsController = new GEWardsController();
            GEWardsInfo objWardsInfo = new GEWardsInfo();
            if (objLocationsInfo.FK_GEObjectID > 0)
                objWardsInfo = (GEWardsInfo)objWardsController.GetObjectByID(objLocationsInfo.FK_GEObjectID);
            objWardsInfo.GEWardName = objLocationsInfo.GELocationName;
            objWardsInfo.GEWardCode = objLocationsInfo.GELocationCode;
            if (objLocationParentInfo != null && objLocationParentInfo.FK_GEObjectID > 0)
                objWardsInfo.FK_GEDistrictID = objLocationParentInfo.FK_GEObjectID;

            if (objWardsInfo.GEWardID > 0)
                wardID = objWardsController.UpdateObject(objWardsInfo);
            else
                wardID = objWardsController.CreateObject(objWardsInfo);
            objLocationsInfo.FK_GEObjectID = wardID;
            if (objLocationsInfo.GELocationID == 0)
            {
                locationID = objLocationsController.CreateObject(objLocationsInfo);
            }
            else
                locationID = objLocationsController.UpdateObject(objLocationsInfo);
            return locationID;
        }

        private int SaveStreetLocation(GELocationsInfo objLocationsInfo)
        {
            int streetsID = 0;
            int locationID = 0;
            GELocationsController objLocationsController = new GELocationsController();
            GELocationsInfo objLocationParentInfo = (GELocationsInfo)objLocationsController.GetObjectByID(objLocationsInfo.GELocationParentID);
            GEStreetsController objStreetsController = new GEStreetsController();
            GEStreetsInfo objStreetsInfo = new GEStreetsInfo();
            if (objLocationsInfo.FK_GEObjectID > 0)
                objStreetsInfo = (GEStreetsInfo)objStreetsController.GetObjectByID(objLocationsInfo.FK_GEObjectID);
            objStreetsInfo.GEStreetName = objLocationsInfo.GELocationName;
            objStreetsInfo.GEStreetCode = objLocationsInfo.GELocationCode;
            if (objStreetsInfo.GEStreetID > 0)
                streetsID = objStreetsController.UpdateObject(objStreetsInfo);
            else
                streetsID = objStreetsController.CreateObject(objStreetsInfo);
            objLocationsInfo.FK_GEObjectID = streetsID;
            if (objLocationsInfo.GELocationID == 0)
            {
                locationID = objLocationsController.CreateObject(objLocationsInfo);
            }
            else
                locationID = objLocationsController.UpdateObject(objLocationsInfo);
            return locationID;
        }
        /// <summary>
        /// Delete selected item from location list
        /// </summary>
        /// <param name="objLocationsInfo"></param>
        public void DeleteSelectedItemFromLocationList(GELocationsInfo objLocationsInfo)
        {
            GELocationsController objLocationsController = new GELocationsController();
            objLocationsController.DeleteObject(objLocationsInfo.GELocationID);
        }
    }
}

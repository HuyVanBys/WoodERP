using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiChooseLocation : BOSERPScreen
    {
        /// <summary>
        /// A variable to store ID of the previous selected location
        /// </summary>
        private int LocationID;
        /// <summary>
        /// Gets or sets the tree list binded to the location tree list control
        /// </summary>
        public BOSTreeList LocationTreeList { get; set; }

        public guiChooseLocation()
        {
            InitializeComponent();
            LocationTreeList = new BOSTreeList();
        }

        public guiChooseLocation(int locationID)
        {
            InitializeComponent();
            LocationID = locationID;
            LocationTreeList = new BOSTreeList();
        }

        private void guiChooseLocation_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            BOSTreeList dataSource = new BOSTreeList();
            dataSource.Add(new GELocationsInfo("Địa chỉ"));
            GELocationsController objLocationsController = new GELocationsController();
            DataSet ds = objLocationsController.GetAllParentOjects();
            LocationTreeList.InitBOSList(null, string.Empty, TableName.GELocationsTableName);
            LocationTreeList.Invalidate(ds);
            dataSource[0].SubList = LocationTreeList;
            LocationTreeList.TreeListControl = fld_trlGELocations;
            fld_trlGELocations.DataSource = dataSource;
            fld_trlGELocations.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(fld_trlGELocations_CellValueChanging);
            LocationTreeList.TreeListControl.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(rowClickEventHandler);
            fld_lkeGELocationID.EditValue = LocationID;
            if (LocationID > 0)
                CheckPreviousLocation();
            else
                LocationTreeList.Invalidate(ds);
            LocationTreeList.TreeListControl.RefreshDataSource();
            LocationTreeList.TreeListControl.ExpandAll();
        }

        private void rowClickEventHandler(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            BOSTreeListObject currentObject = LocationTreeList.CurrentObject;
            if (currentObject != null && currentObject.SubList == null)
                InvalidateSubList(currentObject);
            LocationTreeList.TreeListControl.RefreshDataSource();
            LocationTreeList.TreeListControl.ExpandAll();
        }

        public void InvalidateSubList(BOSTreeListObject obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            //Make the type of sub list same as its parent
            obj.SubList = new BOSTreeList();
            obj.SubList.InitBOSList(null, string.Empty, TableName.GELocationsTableName);

            int parentObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, "GELocationID"));
            obj.SubList.CheckAll = false;
            Invalidate((BOSTreeList)obj.SubList, parentObjectID);
            foreach (BOSTreeListObject objSub in obj.SubList)
                objSub.Parent = obj;
        }

        public void Invalidate(BOSTreeList list, int parentID)
        {
            GELocationsController objLocationsController = new GELocationsController();
            DataSet ds = objLocationsController.GetChildLocationByParentID(parentID);
            list.InvalidateLoadMore(ds);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Check the previous selected location
        /// </summary>
        private void CheckPreviousLocation()
        {
            GELocationsController objLocationsController = new GELocationsController();
            List<GELocationsInfo> allLocationList = objLocationsController.GetAllLocationList();
            GELocationsInfo objLocationsInfo = allLocationList.FirstOrDefault(p => p.GELocationID == LocationID);
            List<int> locationIDs = new List<int>();
            List<GELocationsInfo> loadLocationList = new List<GELocationsInfo>();
            int parentLocationID = objLocationsInfo.GELocationParentID;
            allLocationList.ForEach(o =>
            {
                if (parentLocationID > 0)
                {
                    GELocationsInfo objFindLocationsInfo = new GELocationsInfo();
                    objFindLocationsInfo = allLocationList.FirstOrDefault(p => p.GELocationID == parentLocationID);
                    locationIDs.Add(objFindLocationsInfo.GELocationID);
                    loadLocationList.Add(objFindLocationsInfo);
                    parentLocationID = objFindLocationsInfo.GELocationParentID;
                }
            });
            locationIDs.Sort();
            loadLocationList = loadLocationList.OrderBy(o => o.GELocationID).ToList();
            if (loadLocationList.Count > 0)
            {
                loadLocationList.ForEach(o =>
                {
                    BOSTreeListObject objTreeListObject = (GELocationsInfo)LocationTreeList.GetObjectByPropertyNameAndValue("GELocationID", o.GELocationID);
                    if (objTreeListObject != null)
                        InvalidateSubList(objTreeListObject);
                });
                BOSTreeListObject obj = LocationTreeList.GetObjectByPropertyNameAndValue("GELocationID", LocationID);
                if (obj != null)
                {
                    obj.Selected = true;
                }
            }
        }

        private void fld_trlGELocations_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Selected")
            {
                BOSTreeListObject currentObject = LocationTreeList.CurrentObject;
                if (currentObject != null && !currentObject.Selected)
                {
                    LocationTreeList.SetValueToList("Selected", false);
                    currentObject.Selected = true;
                    fld_trlGELocations.RefreshDataSource();
                }
            }
        }

        private void fld_lkeGELocationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int locationID = Convert.ToInt32(e.Value);
                GELocationsController objLocationsController = new GELocationsController();
                GELocationsInfo objLocationsInfo = (GELocationsInfo)objLocationsController.GetObjectByID(locationID);
                if (objLocationsInfo != null)
                {
                    if (objLocationsInfo.GELocationID != LocationID)
                    {
                        LocationID = objLocationsInfo.GELocationID;
                        fld_lkeGELocationID.EditValue = objLocationsInfo.GELocationID;
                    }

                    LocationTreeList.SetValueToList("Selected", false);
                    objLocationsInfo = (GELocationsInfo)LocationTreeList.GetObjectByPropertyNameAndValue("GELocationID", locationID);
                    if (objLocationsInfo != null)
                    {
                        objLocationsInfo.Selected = true;
                    }
                    fld_trlGELocations.RefreshDataSource();
                }
            }
        }
    }
}

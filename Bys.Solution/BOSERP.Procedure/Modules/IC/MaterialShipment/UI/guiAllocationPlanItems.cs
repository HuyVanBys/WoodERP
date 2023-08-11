using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialShipment
{
    public partial class guiAllocationPlanItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<MMAllocationPlanItemsInfo> SelectedObjects { get; set; }

        private BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemsList { get; set; }

        public string AllocationPlanItemGroup { get; set; }

        private int Count = 0;

        public int MMBatchProductID { get; set; }

        public int MMAllocationPlanID { get; set; }
        #endregion

        public guiAllocationPlanItems()
        {
            InitializeComponent();
        }

        private void guiAllocationPlanItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            LoadLookupDataSource();
            fld_lkeFK_MMBatchProductID.EditValue = MMBatchProductID;
            EnableLookupEdit(fld_lkeFK_MMBatchProductID, MMBatchProductID > 0 ? false : true);
            fld_lkeFK_MMAllocationPlanID.EditValue = MMAllocationPlanID;
            EnableLookupEdit(fld_lkeFK_MMAllocationPlanID, MMBatchProductID > 0 ? false : true);
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(MMBatchProductID);

            DateTime toDate = ((BaseModuleERP)Module).GetServerDate();
            DateTime fromDate = objBatchProductsInfo == null ? toDate : objBatchProductsInfo.MMBatchProductDate;

            fld_dteFromDate.EditValue = fromDate;
            fld_dteToDate.EditValue = fromDate.Year == 9999 ? toDate.AddMonths(1) : fromDate.AddMonths(1);

            fld_dgcMMAllocationPlanItemsGridControl.InvalidateDataSource(AllocationPlanItemsList);
            SelectedObjects = new List<MMAllocationPlanItemsInfo>();
            GridView gridView = (GridView)fld_dgcMMAllocationPlanItemsGridControl.MainView;
            GridControlHelper = new GridControlHelper(gridView);
        }

        public void LoadLookupDataSource()
        {
            if (fld_lkeHRDepartmentRoomGroupItemID != null)
            {
                HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
                List<HRDepartmentRoomGroupItemsInfo> datasource = objDepartmentRoomGroupItemsController.GetAllDepartmentRoomGroupItemList();
                datasource.Insert(0, new HRDepartmentRoomGroupItemsInfo());
                fld_lkeHRDepartmentRoomGroupItemID.Properties.DataSource = datasource;
            }

            if (fld_lkeFK_HREmployeeIDReceive != null)
            {
                List<HREmployeesInfo> employeeReceiveList = (List<HREmployeesInfo>)(new HREmployeesController())
                    .GetListFromDataSet(new HREmployeesController()
                    .GetAllEmployeesForLookupControl());
                if (employeeReceiveList != null)
                    employeeReceiveList.Insert(0, new HREmployeesInfo());
                fld_lkeFK_HREmployeeIDReceive.Properties.DataSource = employeeReceiveList;
            }
        }

        private void EnableLookupEdit(BOSLookupEdit lookupEdit, bool isEnable)
        {
            if (lookupEdit == null)
                return;

            lookupEdit.Enabled = isEnable;
            lookupEdit.ReadOnly = !isEnable;
            lookupEdit.BackColor = isEnable ? Color.White : Color.WhiteSmoke;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMAllocationPlanItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                BOSApp.ShowMessage(BaseLocalizedResources.ChooseObjectMessage);
                return;
            }
            //Count = SelectedObjects.Select(o => o.FK_MMBatchProductID).Distinct().Count();
            //if (Count > 1)
            //{
            //    BOSApp.ShowMessage(TransferOutsourcingLocalizedResources.DuplicateBatchProductErrorMessages);
            //    return;
            //}
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            int batchProductID = fld_lkeFK_MMBatchProductID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMBatchProductID.EditValue.ToString());
            int allocationPlanID = fld_lkeFK_MMAllocationPlanID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMAllocationPlanID.EditValue.ToString());
            int workShopID = fld_lkeFK_MMWorkShopID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMWorkShopID.EditValue.ToString());
            int lineID = fld_lkeFK_MMLineID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMLineID.EditValue.ToString());
            int departmentRoomGroupItemID = fld_lkeHRDepartmentRoomGroupItemID.EditValue == null ? 0 : int.Parse(fld_lkeHRDepartmentRoomGroupItemID.EditValue.ToString());
            int employeeReceiveID = fld_lkeFK_HREmployeeIDReceive.EditValue == null ? 0 : int.Parse(fld_lkeFK_HREmployeeIDReceive.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> planItemList = objAllocationPlanItemsController.GetItemForShipmentByItemGroup(AllocationPlanItemGroup
                                                                                                                          , batchProductID
                                                                                                                          , allocationPlanID
                                                                                                                          , workShopID
                                                                                                                          , lineID
                                                                                                                          , departmentRoomGroupItemID
                                                                                                                          , employeeReceiveID
                                                                                                                          , fromDate
                                                                                                                          , toDate
                                                                                                                          , BOSApp.CurrentUsersInfo.ADUserID
                                                                                                                          , ModuleName.BatchProductShedule
                                                                                                                          , ADDataViewPermissionType.Module
                                                                                                                          , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            MaterialShipmentEntities entity = (MaterialShipmentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ShipmentItemList.ForEach(o =>
            {
                planItemList.RemoveAll(item => item.Id == o.FK_MMAllocationPlanItemID);
            });
            fld_dgcMMAllocationPlanItemsGridControl.DataSource = planItemList;
            fld_dgcMMAllocationPlanItemsGridControl.RefreshDataSource();
        }

        private void Fld_lkeFK_MMLineID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int workShopID = 0;
            if (fld_lkeFK_MMWorkShopID.EditValue != null) int.TryParse(fld_lkeFK_MMWorkShopID.EditValue.ToString(), out workShopID);
            DataSet ds = new DataSet();
            if (BOSApp.LookupTables.ContainsKey("MMLines"))
                ds = (DataSet)BOSApp.LookupTables["MMLines"];
            if (workShopID > 0)
            {
                if (BOSApp.LookupTables.ContainsKey("MMLines"))
                {
                    if (ds != null && ds.Tables[0] != null)
                    {
                        List<MMLinesInfo> line = (List<MMLinesInfo>)(new MMLinesController()).GetListFromDataSet(ds);
                        if (line != null)
                        {
                            line = line.Where(o => o.FK_MMWorkShopID == workShopID).ToList();
                            if (line != null)
                            {
                                line.Insert(0, new MMLinesInfo());
                                fld_lkeFK_MMLineID.Properties.DataSource = line;
                            }
                        }
                    }
                }
            }
            else
            {
                if (ds != null)
                    fld_lkeFK_MMLineID.Properties.DataSource = ds.Tables[0];
            }
        }
    }
}

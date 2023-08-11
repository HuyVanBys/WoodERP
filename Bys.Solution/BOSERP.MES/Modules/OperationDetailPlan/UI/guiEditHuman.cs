using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiEditHuman : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>

        public List<MMOperationDetailPlanItemChildsInfo> HumanDetailPlanItemsList { get; set; }
        public List<HRDepartmentRoomGroupItemsInfo> RoomGroupItemDataList { get; set; }
        List<MMDetailPlanHumanUnitsInfo> HumanUnitList = new List<MMDetailPlanHumanUnitsInfo>();
        public List<HRDepartmentRoomGroupItemsInfo> ResultList { get; set; }
        public guiEditHuman()
        {
            InitializeComponent();
        }

        public guiEditHuman(DateTime fromdate, DateTime todate)
        {
            InitializeComponent();
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
            if (HumanDetailPlanItemsList == null) HumanDetailPlanItemsList = new List<MMOperationDetailPlanItemChildsInfo>();
            if (HumanDetailPlanItemsList == null) RoomGroupItemDataList = new List<HRDepartmentRoomGroupItemsInfo>();

        }
        #region Event   
        private void guiEditHuman_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_trlHumanUnits.InitializeControl();
            fld_trlHumanUnits.Module = this.Module;
            ResultList = new List<HRDepartmentRoomGroupItemsInfo>();
            List<string> opID = HumanDetailPlanItemsList.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
            string operationList = string.Join(",", opID.ToArray());
            HumanUnitList = new List<MMDetailPlanHumanUnitsInfo>();
            foreach (MMOperationDetailPlanItemChildsInfo item in HumanDetailPlanItemsList)
            {
                if (item.HumanFocusedList != null && item.HumanFocusedList.Count > 0)
                {
                    item.HumanFocusedList.ForEach(o =>
                    {
                        MMDetailPlanHumanUnitsInfo found = HumanUnitList.Where(h => h.FK_HREmployeeID == o.FK_HREmployeeID ||
                        (o.FK_HREmployeeID == 0 && o.FK_HRDepartmentRoomGroupItemID == h.FK_HRDepartmentRoomGroupItemID)).FirstOrDefault();
                        if (found == null || found.FK_HRDepartmentRoomGroupItemID == 0)
                            HumanUnitList.Add((MMDetailPlanHumanUnitsInfo)o.Clone());
                    });
                }
            }
            GetTreeHumanDataSource(operationList);
            InvalidateSelectNode();
        }
        public void InvalidateSelectNode()
        {
            TreeListColumn col = fld_trlHumanUnits.Columns["Selected"];
            if (fld_trlHumanUnits.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlHumanUnits.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlHumanUnits.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.HREmployeeID > 0)
                        if (HumanUnitList.Count > 0)
                        {
                            MMDetailPlanHumanUnitsInfo found = HumanUnitList.Where(o => o.FK_HREmployeeID == childNote.HREmployeeID).FirstOrDefault();
                            if (found != null && found.FK_HREmployeeID > 0)
                                Child.SetValue(col, true);
                        }
                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueValidateNode(Child, col);
                }
        }
        public void SetValueValidateNode(DevExpress.XtraTreeList.Nodes.TreeListNode node, TreeListColumn col)
        {
            if (node.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlHumanUnits.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.HREmployeeID > 0)
                        if (HumanDetailPlanItemsList != null)
                            HumanDetailPlanItemsList.ForEach(o =>
                            {
                                if (o.HumanFocusedList != null && o.HumanFocusedList.Count > 0
                                    && o.HumanFocusedList.Any(h => h.FK_HREmployeeID == childNote.HREmployeeID)
                                )
                                    Child.SetValue(col, true);
                            });

                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueValidateNode(Child, col);
                }
        }
        public void GetTreeHumanDataSource(string operationList)
        {
            if (fld_trlHumanUnits != null)
            {
                fld_trlHumanUnits.GetTreeDataSource(0, 0, operationList);
                fld_trlHumanUnits.bindingListSource = new BindingList<HRDepartmentRoomGroupItemsInfo>();
                if (fld_trlHumanUnits.RoomGroupItemDataList != null)
                    fld_trlHumanUnits.RoomGroupItemDataList.ForEach(o => fld_trlHumanUnits.bindingListSource.Add(o));
                fld_trlHumanUnits.DataSource = fld_trlHumanUnits.bindingListSource;
                fld_trlHumanUnits.RefreshDataSource();
            }
        }
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            ResultList = GetHumanSelectedNote();
            if (ResultList.Count() == 0)
                if (BOSApp.ShowMessageYesNo("Bạn chưa chọn nhân công, bạn có chắc chắn không?") == DialogResult.No)
                    return;

            HumanDetailPlanItemsList.ForEach(s =>
            {
                s.HumanFocusedList = new List<MMDetailPlanHumanUnitsInfo>();
                if (ResultList.Count() > 0)
                    ResultList.ForEach(hu =>
                    {
                        MMDetailPlanHumanUnitsInfo hUnit = new MMDetailPlanHumanUnitsInfo();
                        hUnit.FK_HREmployeeID = hu.HREmployeeID;
                        hUnit.FK_HRDepartmentRoomGroupItemID = hu.HRDepartmentRoomGroupItemParentID;
                        hUnit.FK_MMOperationID = s.FK_MMOperationID;
                        hUnit.FK_MMBatchProductProductionNormItemID = s.FK_MMBatchProductProductionNormItemID;
                        hUnit.FK_MMOperationDetailPlanItemChildID = s.FK_MMOperationDetailPlanItemChildID;
                        hUnit.MMDetailPlanHumanUnitAbstract = s.MMOperationDetailPlanItemChildAbstract;
                        s.HumanFocusedList.Add(hUnit);
                    });
            });
            DialogResult = DialogResult.OK;
            Close();
        }
        public List<HRDepartmentRoomGroupItemsInfo> GetHumanSelectedNote()
        {
            List<HRDepartmentRoomGroupItemsInfo> result = new List<HRDepartmentRoomGroupItemsInfo>();
            if (fld_trlHumanUnits != null)
            {
                fld_trlHumanUnits.ResultList = new List<HRDepartmentRoomGroupItemsInfo>();
                if (fld_trlHumanUnits.Nodes != null)
                    foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in fld_trlHumanUnits.Nodes)
                    {
                        HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlHumanUnits.GetDataRecordByNode(item);
                        if (childNote != null && childNote.Selected && childNote.HREmployeeID > 0)
                        {
                            fld_trlHumanUnits.ResultList.Add((HRDepartmentRoomGroupItemsInfo)childNote.Clone());
                        }
                        fld_trlHumanUnits.GetSelectedValueFromTree(item);
                    }
                if (fld_trlHumanUnits.ResultList != null)
                    result.AddRange(fld_trlHumanUnits.ResultList);
            }
            return result;
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region Data & Ultility

        #endregion
        private void fld_ckeViewByOperation_CheckedChanged(object sender, EventArgs e)
        {
            List<string> opID = HumanDetailPlanItemsList.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
            string operationList = string.Join(",", opID.ToArray());
            if (!fld_ckeViewByOperation.Checked) operationList = string.Empty;
            GetTreeHumanDataSource(operationList);


            if (HumanUnitList.Count() > 0)
                InvalidateSelectNode();
        }
    }
}

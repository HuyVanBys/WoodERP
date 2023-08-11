using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiEditMachine : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>

        public List<MMOperationDetailPlanItemChildsInfo> MachineDetailPlanItemsList { get; set; }
        public List<MMMachineUnitsInfo> MachineUnitDataList { get; set; }
        List<MMDetailPlanMachineUnitsInfo> MachineUnitList = new List<MMDetailPlanMachineUnitsInfo>();
        public List<MMMachineUnitsInfo> ResultList { get; set; }

        public guiEditMachine()
        {
            InitializeComponent();
        }

        public guiEditMachine(DateTime fromdate, DateTime todate)
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
            if (MachineDetailPlanItemsList == null) MachineDetailPlanItemsList = new List<MMOperationDetailPlanItemChildsInfo>();
            if (MachineUnitList == null) MachineUnitList = new List<MMDetailPlanMachineUnitsInfo>();

        }
        #region Event   
        private void guiEditMachine_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_trlMachineUnits.InitializeControl();
            fld_trlMachineUnits.Module = this.Module;
            ResultList = new List<MMMachineUnitsInfo>();
            List<string> opID = MachineDetailPlanItemsList.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
            string operationList = string.Join(",", opID.ToArray());
            MachineUnitList = new List<MMDetailPlanMachineUnitsInfo>();
            foreach (MMOperationDetailPlanItemChildsInfo item in MachineDetailPlanItemsList)
            {
                if (item.MachineFocusedList != null && item.MachineFocusedList.Count > 0)
                {
                    item.MachineFocusedList.ForEach(o =>
                    {
                        MMDetailPlanMachineUnitsInfo found = MachineUnitList.Where(h => h.FK_ACAssetID == o.FK_ACAssetID ||
                        (o.FK_ACAssetID == 0 && o.FK_MMMachineUnitID == h.FK_MMMachineUnitID)).FirstOrDefault();
                        if (found == null || found.FK_MMMachineUnitID == 0)
                            MachineUnitList.Add((MMDetailPlanMachineUnitsInfo)o.Clone());
                    });
                }
            }
            GetTreeMachineDataSource(operationList, true);
            InvalidateSelectNode();
        }
        public void InvalidateSelectNode()
        {
            TreeListColumn col = fld_trlMachineUnits.Columns["Selected"];
            if (fld_trlMachineUnits.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlMachineUnits.Nodes)
                {
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlMachineUnits.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.FK_ACAssetID > 0)
                        if (MachineUnitList.Count > 0)
                        {
                            MMDetailPlanMachineUnitsInfo found = MachineUnitList.Where(o => o.FK_ACAssetID == childNote.FK_ACAssetID).FirstOrDefault();
                            if (found != null && found.FK_ACAssetID > 0)
                            {
                                Child.SetValue(col, true);
                                col = fld_trlMachineUnits.Columns["MMMachineUnitCapacity"];
                                if (col != null)
                                    Child.SetValue(col, found.MMDetailPlanMachineUnitCapacity);
                                col = fld_trlMachineUnits.Columns["MMCapacityUnit"];
                                if (col != null)
                                    Child.SetValue(col, found.MMCapacityUnit);

                                col = fld_trlMachineUnits.Columns["MMMachineUnitQty"];
                                if (col != null)
                                    Child.SetValue(col, found.MMDetailPlanMachineUnitQty);

                                col = fld_trlMachineUnits.Columns["MMMachineUnitSetupTime"];
                                if (col != null)
                                    Child.SetValue(col, found.MMDetailPlanMachineUnitSetupTime);

                            }
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
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlMachineUnits.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.FK_ACAssetID > 0)
                    {
                        MMDetailPlanMachineUnitsInfo found = MachineUnitList.Where(o => o.FK_ACAssetID == childNote.FK_ACAssetID).FirstOrDefault();
                        if (found != null && found.FK_ACAssetID > 0)
                        {
                            Child.SetValue(col, true);
                            col = fld_trlMachineUnits.Columns["MMMachineUnitCapacity"];
                            if (col != null)
                                Child.SetValue(col, found.MMDetailPlanMachineUnitCapacity);
                            col = fld_trlMachineUnits.Columns["MMCapacityUnit"];
                            if (col != null)
                                Child.SetValue(col, found.MMCapacityUnit);

                            col = fld_trlMachineUnits.Columns["MMMachineUnitQty"];
                            if (col != null)
                                Child.SetValue(col, found.MMDetailPlanMachineUnitQty);

                            col = fld_trlMachineUnits.Columns["MMMachineUnitSetupTime"];
                            if (col != null)
                                Child.SetValue(col, found.MMDetailPlanMachineUnitSetupTime);
                        }
                        //if (MachineDetailPlanItemsList != null)
                        //    MachineDetailPlanItemsList.ForEach(o =>
                        //    {
                        //        if (o.MachineFocusedList != null && o.MachineFocusedList.Count > 0
                        //            && o.MachineFocusedList.Any(h => h.FK_ACAssetID == childNote.FK_ACAssetID))
                        //        {
                        //            Child.SetValue(col, true);
                        //        }
                        //    });
                    }

                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueValidateNode(Child, col);
                }
        }
        public void GetTreeMachineDataSource(string operationList, bool isGetBySemi)
        {
            if (fld_trlMachineUnits != null)
            {
                string listSemiID = string.Empty;
                if (MachineDetailPlanItemsList.Count() > 0 && isGetBySemi)
                {
                    listSemiID = string.Join(",", MachineDetailPlanItemsList.Where(o => o.FK_ICProductID > 0).Select(o => o.FK_ICProductID.ToString()).Distinct().ToArray());
                }
                fld_trlMachineUnits.GetTreeDataSource(0, 0, operationList, listSemiID);
                fld_trlMachineUnits.bindingListSource = new BindingList<MMMachineUnitsInfo>();
                if (fld_trlMachineUnits.MachineGroupItemDataList != null)
                {
                    fld_trlMachineUnits.MachineGroupItemDataList.ForEach(o => fld_trlMachineUnits.bindingListSource.Add(o));

                }
                fld_trlMachineUnits.DataSource = fld_trlMachineUnits.bindingListSource;
                fld_trlMachineUnits.RefreshDataSource();
            }
        }
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            ResultList = GetMachineSelectedNote();
            if (ResultList.Count() == 0)
                if (BOSApp.ShowMessageYesNo("Bạn chưa chọn nguồn lực, bạn có chắc chắn không?") == DialogResult.No)
                    return;

            MachineDetailPlanItemsList.ForEach(s =>
            {
                s.MachineFocusedList = new List<MMDetailPlanMachineUnitsInfo>();
                if (s.Selected)
                {
                    if (ResultList.Count() > 0)
                        ResultList.ForEach(hu =>
                        {
                            MMDetailPlanMachineUnitsInfo hUnit = new MMDetailPlanMachineUnitsInfo();
                            hUnit.FK_ACAssetID = hu.FK_ACAssetID;
                            hUnit.FK_MMMachineUnitID = hu.FK_MMMachineUnitID;
                            hUnit.MMMachineUnitName = hu.MMMachineUnitName;
                            hUnit.FK_MMOperationID = s.FK_MMOperationID;
                            hUnit.MMDetailPlanMachineUnitSetupTime = hu.MMMachineUnitSetupTime;
                            hUnit.MMDetailPlanMachineUnitCapacity = hu.MMMachineUnitCapacity;
                            hUnit.MMDetailPlanMachineUnitQty = hu.MMMachineUnitQty;
                            hUnit.MMCapacityUnit = hu.MMCapacityUnit;
                            hUnit.FK_MMBatchProductProductionNormItemID = s.FK_MMBatchProductProductionNormItemID;
                            hUnit.FK_MMOperationDetailPlanItemChildID = s.FK_MMOperationDetailPlanItemChildID;
                            hUnit.MMDetailPlanMachineUnitAbstract = s.MMOperationDetailPlanItemChildAbstract;
                            s.MachineFocusedList.Add(hUnit);
                        });
                }
            });
            DialogResult = DialogResult.OK;
            Close();
        }
        public List<MMMachineUnitsInfo> GetMachineSelectedNote()
        {
            List<MMMachineUnitsInfo> result = new List<MMMachineUnitsInfo>();
            if (fld_trlMachineUnits != null)
            {
                fld_trlMachineUnits.ResultList = new List<MMMachineUnitsInfo>();
                if (fld_trlMachineUnits.Nodes != null)
                    foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in fld_trlMachineUnits.Nodes)
                    {
                        MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlMachineUnits.GetDataRecordByNode(item);
                        if (childNote != null && childNote.Selected && childNote.FK_ACAssetID > 0)
                        {
                            fld_trlMachineUnits.ResultList.Add((MMMachineUnitsInfo)childNote.Clone());
                        }
                        fld_trlMachineUnits.GetSelectedValueFromTree(item);
                    }
                if (fld_trlMachineUnits.ResultList != null)
                    result.AddRange(fld_trlMachineUnits.ResultList);
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
            List<string> opID = MachineDetailPlanItemsList.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
            string operationList = string.Join(",", opID.ToArray());
            bool getBySemi = true;
            if (!fld_ckeViewByOperation.Checked)
            {
                operationList = string.Empty;
                getBySemi = false;
            }

            GetTreeMachineDataSource(operationList, getBySemi);

            if (MachineUnitList.Count() > 0)
                InvalidateSelectNode();
        }
    }
}

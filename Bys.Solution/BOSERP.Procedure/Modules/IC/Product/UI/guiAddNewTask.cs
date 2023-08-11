using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;

namespace BOSERP.Modules.Product
{
    public partial class guiAddNewTask<T> : BOSERPScreen where T : BusinessObject
    {
        private const string ModuleName = "Task";
        #region Variables
        public ICTasksInfo TasksInfo { get; set; }

        #endregion

        public guiAddNewTask()
        {
            InitializeComponent();
            TasksInfo = new ICTasksInfo();
        }

        private void guiAddPhase_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_txtICTaskNo.Text = "***NEW***";
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            TasksInfo.ICTaskNo = GetTaskNo();
            TasksInfo.FK_ICMeasureUnitID = (int)fld_lkeFK_ICMeasureUnitID.EditValue;
            TasksInfo.ICTaskName = fld_txtICTaskName.Text;
            TasksInfo.FK_PMProjectTypeID = (int)fld_lkeFK_PMProjectTypeID.EditValue;
            TasksInfo.FK_HREmployeeID = (int)fld_lkeFK_HREmployeeID.EditValue;
            TasksInfo.FK_HRDepartmentID = (int)fld_lkeFK_HRDepartmentID.EditValue;
            TasksInfo.FK_HRDepartmentRoomID = (int)fld_lkeFK_HRDepartmentRoomID.EditValue;
            TasksInfo.ICTaskInfo = fld_medICTaskInfo.Text;
            TasksInfo.ICTaskTotalEstimatedHours = decimal.Parse(fld_txtICTaskTotalEstimatedHours.Text);
            TasksInfo.ICTaskTotalEstimatedDays = decimal.Parse(fld_txtICTaskTotalEstimatedDays.Text);
            TasksInfo.ICTaskEstimatedTotalCost = decimal.Parse(fld_txtICTaskEstimatedTotalCost.Text);

            if (String.IsNullOrEmpty(TasksInfo.ICTaskName))
            {
                MessageBox.Show(WorkProductLocalizedResources.TaskNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(TasksInfo.FK_HRDepartmentID > 0))
            {
                MessageBox.Show(WorkProductLocalizedResources.HRDepartmentRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(TasksInfo.FK_HRDepartmentRoomID > 0))
            {
                MessageBox.Show(WorkProductLocalizedResources.HRDepartmentRoomRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ICTasksController objICTasksController = new ICTasksController();
            objICTasksController.CreateObject(TasksInfo);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string GetTaskNo()
        {
            String TaskNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(ModuleName, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo != null)
            {
                BaseBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(TableName.PMPhaseTypesTableName + "Controller");
                if (objMainObjectController != null)
                {
                    TaskNo = String.Format("{0}{1}",
                                                    objGENumberingInfo.GENumberingPrefix,
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    objGENumberingInfo.GENumberingStart++;
                    while (objMainObjectController.IsExist(TaskNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        TaskNo = String.Format("{0}{1}",
                                                        objGENumberingInfo.GENumberingPrefix,
                                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    }
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
            }
            return TaskNo;
        }
    }
}
using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Template
{
    public partial class guiAddNewPhase<T> : BOSERPScreen where T : BusinessObject
    {
        private const string ModuleName = "PhaseType";
        #region Variables
        public PMPhaseTypesInfo PhaseTypesInfo { get; set; }

        #endregion

        public guiAddNewPhase()
        {
            InitializeComponent();
            PhaseTypesInfo = new PMPhaseTypesInfo();
        }

        private void guiAddPhase_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_txtPMPhaseTypeNo.Text = "***NEW***";
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
            PhaseTypesInfo.PMPhaseTypeName = fld_txtPMPhaseTypeName.Text;
            PhaseTypesInfo.PMPhaseTypeDesc = fld_medPMPhaseTypeDesc.Text;
            PhaseTypesInfo.FK_PMProjectTypeID = (int)fld_lkeFK_PMProjectTypeID.EditValue;
            PhaseTypesInfo.AACreatedUser = BOSApp.CurrentUser;
            PhaseTypesInfo.PMPhaseTypeNo = GetPhaseTypeNo();

            if (String.IsNullOrEmpty(PhaseTypesInfo.PMPhaseTypeName))
            {
                MessageBox.Show(PMPhaseTypeLocalizedResources.PhaseTypeNameRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PMPhaseTypesController objPMPhaseTypesController = new PMPhaseTypesController();
            objPMPhaseTypesController.CreateObject(PhaseTypesInfo);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string GetPhaseTypeNo()
        {
            String phaseTypeNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(ModuleName, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objGENumberingInfo != null)
            {
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(TableName.PMPhaseTypesTableName + "Controller");
                if (objMainObjectController != null)
                {
                    phaseTypeNo = String.Format("{0}{1}",
                                                    objGENumberingInfo.GENumberingPrefix,
                                                    objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    objGENumberingInfo.GENumberingStart++;
                    while (objMainObjectController.IsExist(phaseTypeNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        phaseTypeNo = String.Format("{0}{1}",
                                                        objGENumberingInfo.GENumberingPrefix,
                                                        objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    }
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
            }
            return phaseTypeNo;
        }
    }
}
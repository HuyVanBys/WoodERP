using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Project
{
    public partial class guiAddPhase<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<PMPhaseTypesInfo> PhaseTypeList { get; set; }

        public IList<PMPhaseTypesInfo> SelectedObjects { get; set; }

        public int ProjectTypeID { get; set; }

        #endregion

        public guiAddPhase(List<PMPhaseTypesInfo> phaseTypes, int projectTypeID)
        {
            InitializeComponent();
            PhaseTypeList = new BOSList<PMPhaseTypesInfo>(TableName.PMPhaseTypesTableName);
            PhaseTypeList.Invalidate(phaseTypes);
            ProjectTypeID = projectTypeID;
        }

        private void guiAddPhase_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lkeFK_PMProjectTypeID.EditValue = ProjectTypeID;
            fld_lkeFK_PMProjectTypeID_KeyUp(null, null);
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
            SelectedObjects = PhaseTypeList.Where(s => s.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_lkeFK_PMProjectTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            int value = Convert.ToInt32(fld_lkeFK_PMProjectTypeID.EditValue.ToString());
            if (value > 0)
            {
                SearchData(value.ToString());
            }
            else
            {
                SearchData(string.Empty);
            }
        }

        private void SearchData(String keyWord)
        {
            fld_dgcPhaseTypesGridControl.DataSource = PhaseTypeList;
            fld_dgcPhaseTypesGridControl.RefreshDataSource();

            if (string.IsNullOrEmpty(keyWord))
                return;

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcPhaseTypesGridControl.MainView;

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["FK_PMProjectTypeID"]);
            lstColVisible.Add(gridView.Columns["PMPhaseTypeNo"]);
            lstColVisible.Add(gridView.Columns["PMPhaseTypeName"]);

            List<PMPhaseTypesInfo> bindingList = new List<PMPhaseTypesInfo>();

            for (int i = 0; i < PhaseTypeList.Count; i++)
            {
                PMPhaseTypesInfo obj = PhaseTypeList[i];
                bool isExist = false;
                foreach (GridColumn column in lstColVisible)
                {
                    int rowHandle = gridView.GetRowHandle(i);
                    string value = gridView.GetRowCellDisplayText(rowHandle, column);
                    isExist = IsExistKeyWord(value, keyWord);
                    if (isExist)
                        break;
                }
                if (isExist)
                {
                    bindingList.Add(obj);
                }
            }
            fld_dgcPhaseTypesGridControl.DataSource = bindingList;
            fld_dgcPhaseTypesGridControl.RefreshDataSource();
        }

        private bool IsExistKeyWord(String value, String keyWord)
        {
            value = value.ToLower();
            keyWord = keyWord.ToLower();
            String[] arrElement = keyWord.Split(new char[] { ' ' });
            bool isExist = false;
            foreach (String element in arrElement)
            {
                if (value.Contains(element))
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                value = BOSUtil.ConvertUnicodeStringToUnSign(value);
                foreach (String element in arrElement)
                {
                    if (value.Contains(element))
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }
    }
}
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.WorkProduct
{
    public partial class guiAddTask<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<ICTasksInfo> TaskList { get; set; }

        public IList<ICTasksInfo> SelectedObjects { get; set; }

        #endregion

        public guiAddTask(List<ICTasksInfo> productWorks, int productWorkGroupID)
        {
            InitializeComponent();
            TaskList = new BOSList<ICTasksInfo>(TableName.ICTasksTableName);
            TaskList.Invalidate(productWorks);
        }

        private void guiAddTask_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcICTasksGridControl.InvalidateDataSource(TaskList);
            fld_txtFind.Tag = 0;
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
            SelectedObjects = TaskList.Where(s => s.Selected == true).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                keyWord = fld_txtFind.Text;
            SearchData(keyWord);
        }

        private void SearchData(String keyWord)
        {
            fld_dgcICTasksGridControl.DataSource = TaskList;
            fld_dgcICTasksGridControl.RefreshDataSource();

            if (string.IsNullOrEmpty(keyWord))
                return;

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcICTasksGridControl.MainView;

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["ICTaskNo"]);
            lstColVisible.Add(gridView.Columns["ICTaskName"]);
            lstColVisible.Add(gridView.Columns["ICTaskInfo"]);

            List<ICTasksInfo> bindingList = new List<ICTasksInfo>();

            for (int i = 0; i < TaskList.Count; i++)
            {
                ICTasksInfo obj = TaskList[i];
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
            fld_dgcICTasksGridControl.DataSource = bindingList;
            fld_dgcICTasksGridControl.RefreshDataSource();
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

        private void fld_txtFind_Click(object sender, EventArgs e)
        {
            int tag = int.Parse(fld_txtFind.Tag.ToString());
            if (tag == 0)
                fld_txtFind.Text = String.Empty;
            fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
        }

        private void fld_txtFind_Leave(object sender, EventArgs e)
        {
            int tag = int.Parse(fld_txtFind.Tag.ToString());
            if (String.IsNullOrEmpty(fld_txtFind.Text) || tag == 0)
            {
                fld_txtFind.Text = BaseLocalizedResources.TypeKeyWordMessage;
                fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
                fld_txtFind.Tag = 0;
            }
            else
            {
                fld_txtFind.Tag = 1;
                fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void fld_txtFind_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int tag = int.Parse(fld_txtFind.Tag.ToString());
            if (!String.IsNullOrEmpty(fld_txtFind.Text))
            {
                fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
                fld_txtFind.Tag = 1;
            }
        }

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fld_btnFind_Click(null, null);
            }
        }

        private void fld_btnAddNewTask_Click(object sender, EventArgs e)
        {
            guiAddNewTask<ICTasksInfo> guiAddNewTask = new guiAddNewTask<ICTasksInfo>();
            guiAddNewTask.Module = this.Module;
            guiAddNewTask.ShowDialog();
            if (guiAddNewTask.DialogResult != DialogResult.OK)
                return;
            TaskList.Add(guiAddNewTask.TasksInfo);
            fld_dgcICTasksGridControl.DataSource = TaskList;
            fld_dgcICTasksGridControl.RefreshDataSource();
        }
    }
}
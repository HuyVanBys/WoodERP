using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductCriteria
{
    public partial class guiAddProduct<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        public BOSList<ICProductsInfo> ProductsList { get; set; }

        public IList<ICProductsInfo> SelectedObjects { get; set; }


        #endregion

        public guiAddProduct(List<ICProductsInfo> productsList)
        {
            InitializeComponent();
            ProductsList = new BOSList<ICProductsInfo>(TableName.ICProductsTableName);
            ProductsList.Invalidate(productsList);
        }

        private void guiAddProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_txtFind.Tag = 0;
            fld_btnFind_Click(null, null);
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
            SelectedObjects = ProductsList.Where(s => s.Selected == true).ToList();
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
            SearchData(keyWord, false);
        }

        private void SearchData(String keyWord, bool isUseProductWorkGroupID)
        {
            fld_dgcProductsGridControl.DataSource = ProductsList;
            fld_dgcProductsGridControl.RefreshDataSource();

            if (string.IsNullOrEmpty(keyWord))
                return;

            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcProductsGridControl.MainView;

            List<GridColumn> lstColVisible = new List<GridColumn>();
            if (isUseProductWorkGroupID)
            {
                lstColVisible.Add(gridView.Columns["FK_ICProductWorkGroupID"]);
            }
            else
            {
                lstColVisible.Add(gridView.Columns["ICProductNo"]);
                lstColVisible.Add(gridView.Columns["ICProductName"]);
                lstColVisible.Add(gridView.Columns["ICProductDesc"]);
                lstColVisible.Add(gridView.Columns["ICProductNoOfOldSys"]);
            }

            List<ICProductsInfo> bindingList = new List<ICProductsInfo>();

            for (int i = 0; i < ProductsList.Count; i++)
            {
                ICProductsInfo obj = ProductsList[i];
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
            fld_dgcProductsGridControl.DataSource = bindingList;
            fld_dgcProductsGridControl.RefreshDataSource();
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

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            ProductsList.ForEach(o => o.Selected = fld_chkSelectAll.Checked);
            fld_dgcProductsGridControl.RefreshDataSource();
        }
    }
}
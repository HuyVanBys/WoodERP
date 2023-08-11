using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiChooseProductAttributes : BOSERPScreen
    {
        #region Variables

        public List<ICProductAttributesInfo> SelectedObjects { get; set; }

        public BOSList<ICProductAttributesInfo> ProductAttributesList { get; set; }

        private int Count = 0;

        #endregion

        public guiChooseProductAttributes(List<ICProductAttributesInfo> productAttributesList)
        {
            InitializeComponent();
            ProductAttributesList = new BOSList<ICProductAttributesInfo>(TableName.ICProductattributesTableName);
            ProductAttributesList.Invalidate(productAttributesList);
        }

        private void guiChooseProductAttributes_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcICProductAttributesGridControl.InvalidateDataSource(ProductAttributesList);
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
            SelectedObjects = ProductAttributesList.Where(s => s.Selected == true).ToList();
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
            String keyWord = String.Empty;
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, ProductAttributesList);
        }
        public void SearchData(String keyWord, BOSList<ICProductAttributesInfo> productAttributesList)
        {
            GridView gridView = (GridView)fld_dgcICProductAttributesGridControl.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                    {
                        lstColVisible.Add(gridView.Columns[i]);
                    }
                }
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<ICProductAttributesInfo> bindingList = new List<ICProductAttributesInfo>();

                fld_dgcICProductAttributesGridControl.DataSource = productAttributesList;
                fld_dgcICProductAttributesGridControl.RefreshDataSource();

                for (int i = 0; i < productAttributesList.Count; i++)
                {
                    ICProductAttributesInfo obj = productAttributesList[i];
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
                fld_dgcICProductAttributesGridControl.DataSource = bindingList;
                fld_dgcICProductAttributesGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcICProductAttributesGridControl.DataSource = ProductAttributesList;
                fld_dgcICProductAttributesGridControl.RefreshDataSource();
            }
        }
        public bool IsExistKeyWord(String value, String keyWord)
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

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String keyWord = String.Empty;
                //if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                keyWord = fld_txtFind.Text;
                SearchData(keyWord, ProductAttributesList);
            }
        }
    }
}

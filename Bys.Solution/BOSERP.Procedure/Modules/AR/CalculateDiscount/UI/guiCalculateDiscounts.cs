using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculateDiscount
{
    public partial class guiCalculateDiscounts : BOSERPScreen
    {
        #region Variables

        public List<ARCalculateDiscountsInfo> SelectedObjects { get; set; }

        public List<ARCalculateDiscountsInfo> CalculateDiscountList { get; set; }

        private ARDiscountProgramsInfo ARDiscountProgramsInfo { get; set; }

        #endregion
        private int Count = 0;

        public guiCalculateDiscounts(List<ARCalculateDiscountsInfo> calculateDiscountList, ARDiscountProgramsInfo objDiscountProgramsInfo)
        {
            InitializeComponent();
            CalculateDiscountList = calculateDiscountList;
            SelectedObjects = new List<ARCalculateDiscountsInfo>();
            ARDiscountProgramsInfo = objDiscountProgramsInfo;
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

        private void guiCalculateDiscounts_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            GridView gridView = (GridView)fld_dgcARCalculateDiscounts.MainView;
            fld_dgcARCalculateDiscounts.InvalidateDataSource(CalculateDiscountList);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcARCalculateDiscounts.MainView;
            ARCalculateDiscountsInfo objCalculateDiscountsInfo = (ARCalculateDiscountsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objCalculateDiscountsInfo == null)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SelectedObjects.Add(objCalculateDiscountsInfo);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_chkChooseBranch_Click(object sender, EventArgs e)
        {
            Count = 0;
        }

        private void fld_chkChooseSupplier_Click(object sender, EventArgs e)
        {
            Count = 0;
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, CalculateDiscountList);
        }

        public void SearchData(String keyWord, List<ARCalculateDiscountsInfo> calculateDiscountList)
        {
            GridView gridView = (GridView)fld_dgcARCalculateDiscounts.MainView;
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
                List<ARCalculateDiscountsInfo> bindingList = new List<ARCalculateDiscountsInfo>();

                fld_dgcARCalculateDiscounts.DataSource = calculateDiscountList;
                fld_dgcARCalculateDiscounts.RefreshDataSource();

                for (int i = 0; i < calculateDiscountList.Count; i++)
                {
                    ARCalculateDiscountsInfo obj = calculateDiscountList[i];
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
                fld_dgcARCalculateDiscounts.DataSource = bindingList;
                fld_dgcARCalculateDiscounts.RefreshDataSource();
            }
            else
            {
                fld_dgcARCalculateDiscounts.DataSource = calculateDiscountList;
                fld_dgcARCalculateDiscounts.RefreshDataSource();
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

        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcARCalculateDiscounts.MainView;
            List<APProposalItemsInfo> listView = new List<APProposalItemsInfo>();

            List<APProposalItemsInfo> objects = new List<APProposalItemsInfo>();
            //(List<APProposalItemsInfo>)fld_dgcAPProposalItems.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                APProposalItemsInfo objDataViewPermissionsInfo = (APProposalItemsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    APProposalItemsInfo objDataViewPermissionsInfo = (APProposalItemsInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }

                }
            }
        }

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String keyWord = String.Empty;
                keyWord = fld_txtFind.Text;
                SearchData(keyWord, CalculateDiscountList);
            }
        }

        private void Fld_btnCreate_Click(object sender, EventArgs e)
        {
            ARCalculateDiscountsInfo objCalculateDiscountsInfo = new ARCalculateDiscountsInfo()
            {
                ARCalculateDiscountNo = CalculateDiscountEntities.cstNewObjectText,
                ARCalculateDiscountDate = BOSApp.GetCurrentServerDate(),
                ARDiscountProgramNo = ARDiscountProgramsInfo.ARDiscountProgramNo,
                ARDiscountProgramName = ARDiscountProgramsInfo.ARDiscountProgramName,
                ARCalculateDiscountStatus = BusinessObject.DefaultStatus,
                FK_ARDiscountProgramID = ARDiscountProgramsInfo.ARDiscountProgramID,
                FK_ARCustomerDistributionChannelID = ARDiscountProgramsInfo.FK_ARCustomerDistributionChannelID,
                FK_ACObjectID = ARDiscountProgramsInfo.FK_ACObjectID,
                ARObjectType = ARDiscountProgramsInfo.ARObjectType,
                ACObjectAccessKey = string.Join(";", new string[2] { ARDiscountProgramsInfo.FK_ACObjectID.ToString(), ARDiscountProgramsInfo.ARObjectType }),
            };
            SelectedObjects.Add(objCalculateDiscountsInfo);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

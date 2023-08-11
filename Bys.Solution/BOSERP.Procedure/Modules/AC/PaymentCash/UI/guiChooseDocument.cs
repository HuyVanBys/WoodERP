using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentCash
{
    public partial class guiChooseDocument : BOSERPScreen
    {
        #region Variables
        public BOSList<ACDocumentsInfo> DocumentsList { get; set; }

        public IList<ACDocumentsInfo> SelectedObjects { get; set; }
        #endregion

        public guiChooseDocument(BOSList<ACDocumentsInfo> documentsList)
        {
            InitializeComponent();
            DocumentsList = documentsList;
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

        private void guiChooseDocument_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcACDocuments.InvalidateDataSource(DocumentsList);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = new List<ACDocumentsInfo>();
            GridView gridview = (GridView)fld_dgcACDocuments.MainView;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (objDocumentsInfo != null)
            {
                SelectedObjects.Add(objDocumentsInfo);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ((PaymentCashModule)Module).ActionCancel();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, DocumentsList);
        }

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String keyWord = String.Empty;
                keyWord = fld_txtFind.Text;
                SearchData(keyWord, DocumentsList);
            }
        }

        public void SearchData(String keyWord, BOSList<ACDocumentsInfo> documentsList)
        {
            GridView gridView = (GridView)fld_dgcACDocuments.MainView;
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
                BOSList<ACDocumentsInfo> bindingList = new BOSList<ACDocumentsInfo>();
                fld_dgcACDocuments.DataSource = documentsList;
                fld_dgcACDocuments.RefreshDataSource();

                for (int i = 0; i < documentsList.Count; i++)
                {
                    ACDocumentsInfo objDocumentsInfo = documentsList[i];
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
                        bindingList.Add(objDocumentsInfo);
                    }
                }
                fld_dgcACDocuments.DataSource = bindingList;
                fld_dgcACDocuments.RefreshDataSource();
            }
            else
            {
                fld_dgcACDocuments.DataSource = documentsList;
                fld_dgcACDocuments.RefreshDataSource();
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
        /*
        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {           
            Count = 1;
            GridView gridView = (GridView)fld_dgcAPProposalItems.MainView;
            APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objProposalItemsInfo != null)
            {
                fld_chkChooseSupplier.Checked = objProposalItemsInfo.Selected;
                fld_chkChooseBranch.Checked = objProposalItemsInfo.Selected;
            }
        }*/
    }
}

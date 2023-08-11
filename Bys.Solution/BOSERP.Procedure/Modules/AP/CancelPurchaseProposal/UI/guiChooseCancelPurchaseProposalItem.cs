using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseProposal
{
    public partial class guiChooseCancelPurchaseProposalItem : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public guiChooseCancelPurchaseProposalItem()
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
        }

        private void guiChooseCancelPurchaseProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ReferredProposalItemList.InitBOSListGridControl(fld_dgcAPProductsOfProposalItemsGridControl);
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();

            GridColumn gridColumn = (GridColumn)gridView.Columns["Selected"];
            if (gridColumn != null)
            {
                gridColumn.Visible = false;
            }
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Count = 1;
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo = (APCancelPurchaseProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            IList<APCancelPurchaseProposalItemsInfo> proposalItems = gridControlHelper.Selection.OfType<APCancelPurchaseProposalItemsInfo>().ToList();
            foreach (APCancelPurchaseProposalItemsInfo proposalItem in proposalItems)
            {
                proposalItem.Selected = true;
            }
            if (!((CancelPurchaseProposalModule)Module).CheckSelectedProposalItems())
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            String keyWord = String.Empty;
            ///if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, entity.ReferredProposalItemList);
        }
        public void SearchData(String keyWord, BOSList<APCancelPurchaseProposalItemsInfo> CancelPurchaseProposalItemList)
        {
            //DevExpress.XtraGrid.Views.Grid.GridView gridView = ((GridView)fld_dgcAPCancelPurchaseProposalItems.MainView;
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                //BOSList<BusinessObject> lstObject = new BOSList<BusinessObject>();
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    //TNDLoc [MOD][08/12/2015][Issue search in group],START
                    if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                    //TNDLoc [MOD][08/12/2015][Issue search in group],END
                    {
                        lstColVisible.Add(gridView.Columns[i]);
                    }
                }
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<APCancelPurchaseProposalItemsInfo> bindingList = new List<APCancelPurchaseProposalItemsInfo>();

                //Bind object list to grid for searching
                fld_dgcAPProductsOfProposalItemsGridControl.DataSource = CancelPurchaseProposalItemList;
                fld_dgcAPProductsOfProposalItemsGridControl.RefreshDataSource();

                for (int i = 0; i < CancelPurchaseProposalItemList.Count; i++)
                {
                    APCancelPurchaseProposalItemsInfo obj = CancelPurchaseProposalItemList[i];
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
                fld_dgcAPProductsOfProposalItemsGridControl.DataSource = bindingList;
                fld_dgcAPProductsOfProposalItemsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcAPProductsOfProposalItemsGridControl.DataSource = CancelPurchaseProposalItemList;
                fld_dgcAPProductsOfProposalItemsGridControl.RefreshDataSource();
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
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            List<APCancelPurchaseProposalItemsInfo> listView = new List<APCancelPurchaseProposalItemsInfo>();
            List<APCancelPurchaseProposalItemsInfo> objects = new List<APCancelPurchaseProposalItemsInfo>();
            //(List<APCancelPurchaseProposalItemsInfo>)fld_dgcAPCancelPurchaseProposalItems.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                APCancelPurchaseProposalItemsInfo objDataViewPermissionsInfo = (APCancelPurchaseProposalItemsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    APCancelPurchaseProposalItemsInfo objDataViewPermissionsInfo = (APCancelPurchaseProposalItemsInfo)gridView.GetRow(j);
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
                CancelPurchaseProposalEntities entity = (CancelPurchaseProposalEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                String keyWord = String.Empty;
                //if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                keyWord = fld_txtFind.Text;
                SearchData(keyWord, entity.CancelPurchaseProposalItemList);
            }
        }
    }
}

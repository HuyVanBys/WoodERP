using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    public partial class guiChooseOperationDetailPlanItemOperation : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        private int Count = 0;

        public guiChooseOperationDetailPlanItemOperation()
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

        private void guiChooseOperationDetailPlanItemOperation_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.OperationDetailPlanItemChildsList.InitBOSListGridControl(fld_dgcMMOperationDetailPlanItemChildsGridControl);
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();

        }

        private void fld_chkSelectAllOperationDetailPlanItemOperation_CheckedChanged(object sender, EventArgs e)
        {
            ((OperationDetailPlanCapacityModule)Module).CheckAllOperationDetailPlanItemOperations(fld_chkSelectAllOperationDetailPlanItemOperation.Checked);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (!((OperationDetailPlanCapacityModule)Module).CheckSelectedOperationDetailPlanItemOperations())
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
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            String keyWord = String.Empty;
            ///if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, entity.OperationDetailPlanItemChildsList);
        }
        public void SearchData(String keyWord, BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanCapacityItemList)
        {
            //DevExpress.XtraGrid.Views.Grid.GridView gridView = ((GridView)fld_dgcMMOperationDetailPlanItems.MainView;
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;
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
                List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();

                //Bind object list to grid for searching
                fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = OperationDetailPlanCapacityItemList;
                fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();

                for (int i = 0; i < OperationDetailPlanCapacityItemList.Count; i++)
                {
                    MMOperationDetailPlanItemChildsInfo obj = OperationDetailPlanCapacityItemList[i];
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
                fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = bindingList;
                fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcMMOperationDetailPlanItemChildsGridControl.DataSource = OperationDetailPlanCapacityItemList;
                fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
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
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChildsGridControl.MainView;
            List<MMOperationDetailPlanItemChildsInfo> listView = new List<MMOperationDetailPlanItemChildsInfo>();

            List<MMOperationDetailPlanItemChildsInfo> objects = new List<MMOperationDetailPlanItemChildsInfo>();
            //(List<MMOperationDetailPlanItemsInfo>)fld_dgcMMOperationDetailPlanItems.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMOperationDetailPlanItemChildsInfo objDataViewPermissionsInfo = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo objDataViewPermissionsInfo = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
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
                OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                String keyWord = String.Empty;
                //if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                keyWord = fld_txtFind.Text;
                SearchData(keyWord, entity.OperationDetailPlanItemChildsList);
            }
        }

        private void fld_chkSelectAllBatchProductItemOperation_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkSelectAllOperationDetailPlanItemOperation.Checked);
            fld_dgcMMOperationDetailPlanItemChildsGridControl.RefreshDataSource();
        }

    }
}

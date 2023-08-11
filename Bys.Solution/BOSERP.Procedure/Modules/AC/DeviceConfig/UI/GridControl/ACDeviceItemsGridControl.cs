using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Linq;

namespace BOSERP.Modules.DeviceConfig
{
    public class ACDeviceItemsGridControl : BOSComponent.BOSGridControl
    {
        List<ICProductGroupsInfo> ProductGroupList;
        List<ICDepartmentsInfo> DepartmentList;

        public override void InitGridControlDataSource()
        {
            DeviceConfigEntities entity = (DeviceConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACDeviceItemsList;
            this.DataSource = bds;
        }

       
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            ICProductGroupsController pgCtrl = new ICProductGroupsController();
            ProductGroupList = pgCtrl.GetAllObjectList();

            //ICDepartmentsController dCtrl = new ICDepartmentsController();
            //DepartmentList = dCtrl.GetallObjects();

            GridColumn column = gridView.Columns["FK_ICProductID"];
            //if (column != null)
            //{
            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            //    repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
            //    repositoryItemLookUpEdit.ValueMember = "ICProductID";
            //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //    repositoryItemLookUpEdit.NullText = string.Empty;
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm"));
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên sản phẩm"));
            //    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //}

            column = gridView.Columns["FK_ICProductGroupID"];
            if (column != null)
            {
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductGroupName";
                repositoryItemLookUpEdit.ValueMember = "ICProductGroupID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", "Nhóm hàng"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUpPG);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            //column = gridView.Columns["FK_ICDepartmentID"];
            //if (column != null)
            //{
            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            //    repositoryItemLookUpEdit.DisplayMember = "ICDepartmentName";
            //    repositoryItemLookUpEdit.ValueMember = "ICDepartmentID";
            //    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //    repositoryItemLookUpEdit.NullText = string.Empty;
            //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICDepartmentName", "Ngành hàng"));
            //    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUpD);
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //}


            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);


            return gridView;
        }

        //void repositoryItemLookUpEdit_QueryPopUpD(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //    LookUpEdit lke = (LookUpEdit)sender;
        //    lke.Properties.DataSource = DepartmentList;
        //}

        void repositoryItemLookUpEdit_QueryPopUpPG(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ACDeviceItemsInfo deviceTemplateItem = (ACDeviceItemsInfo)gridView.GetFocusedRow();

            int departmentID = 0;
            if (deviceTemplateItem != null) departmentID = deviceTemplateItem.FK_ICDepartmentID;

            LookUpEdit lke = (LookUpEdit)sender;



            List<ICProductGroupsInfo> pgList = ProductGroupList.Where(t => departmentID == 0 || t.FK_ICDepartmentID == departmentID).ToList();
            lke.Properties.DataSource = pgList;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ACDeviceItemsInfo item = (ACDeviceItemsInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
            {
                //if (e.Column.FieldName == "FK_ICProductID")
                //{
                //    ICProductsInfo product = BOSApp.CurrentProductList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductID);
                //    if (product != null)
                //    {
                //        e.DisplayText = product.ICProductNo;
                //    }
                //    else
                //    {
                //        e.DisplayText = string.Empty;
                //    }
                //}
                 if (e.Column.FieldName == "FK_ICProductGroupID")
                {
                    ICProductGroupsInfo pg = ProductGroupList.FirstOrDefault(t => t.ICProductGroupID == item.FK_ICProductGroupID);
                    if (pg != null)
                    {
                        e.DisplayText = pg.ICProductGroupName;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                //else if (e.Column.FieldName == "FK_ICDepartmentID")
                //{
                //    ICDepartmentsInfo d = DepartmentList.FirstOrDefault(t => t.ICDepartmentID == item.FK_ICDepartmentID);
                //    if (d != null)
                //    {
                //        e.DisplayText = d.ICDepartmentName;
                //    }
                //    else
                //    {
                //        e.DisplayText = string.Empty;
                //    }
                //}
            }
        }

        //void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lke = (LookUpEdit)sender;

        //    List<string> filterType = new List<string>(){ProductType.Equipment.ToString()
        //                                                ,   ProductType.VVP.ToString()
        //                                                ,   ProductType.MMTB.ToString()
        //                                                ,   ProductType.Car.ToString()
        //                                                };

        //    List<ICProductsInfo> productList = BOSApp.CurrentProductList.Where(t => filterType.Contains(t.ICProductType)).ToList();
        //    lke.Properties.DataSource = productList;
        //}

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((DeviceConfigModule)Screen.Module).RemoveSelectedItemsList();
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ACDeviceItemsInfo item = (ACDeviceItemsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    item.FK_ICModelDetailID = 0;
                }
                else if (e.Column.FieldName == "FK_ICModelDetailID")
                {
                    ICModelDetailsController modelDetailController = new ICModelDetailsController();
                    ICModelDetailsInfo detail = (ICModelDetailsInfo)modelDetailController.GetObjectByID(item.FK_ICModelDetailID);
                    if (detail != null)
                    {
                        item.FK_ICModelID = detail.FK_ICModelID;
                    }
                    else
                    {
                        item.FK_ICModelID = 0;
                    }
                }
                else if (e.Column.FieldName == "FK_ICProductID")
                {
                    ICProductsController pController = new ICProductsController();
                    ICProductsInfo pInfo = (ICProductsInfo)pController.GetObjectByID(item.FK_ICProductID);

                    if (pInfo != null)
                    {
                        item.FK_ICDepartmentID = pInfo.FK_ICDepartmentID;
                        item.FK_ICProductGroupID = pInfo.FK_ICProductGroupID;
                        item.ACDeviceItemNo = pInfo.ICProductNo;
                        item.ACDeviceItemName = pInfo.ICProductName;
                        item.ACProductType = pInfo.ICProductType;
                        item.FK_ICMeasureUnitID = pInfo.FK_ICProductBasicUnitID;
                    }
                    else
                    {
                        item.FK_ICDepartmentID = 0;
                        item.FK_ICProductGroupID = 0;
                        item.ACDeviceItemNo = string.Empty;
                        item.ACDeviceItemName = string.Empty;
                        item.ACProductType = string.Empty;
                        item.FK_ICMeasureUnitID = 0;
                    }
                }
                else if (e.Column.FieldName == "ACDeviceTemplateItemNo")
                {
                    ICProductsController pController = new ICProductsController();
                    ICProductsInfo pInfo = (ICProductsInfo)pController.GetObjectByNo(item.ACDeviceItemNo);

                    if (pInfo != null)
                    {
                        item.FK_ICDepartmentID = pInfo.FK_ICDepartmentID;
                        item.FK_ICProductGroupID = pInfo.FK_ICProductGroupID;
                        item.FK_ICProductID = pInfo.ICProductID;
                        item.ACDeviceItemName = pInfo.ICProductName;
                        item.ACProductType = pInfo.ICProductType;
                        item.FK_ICMeasureUnitID = pInfo.FK_ICProductBasicUnitID;
                    }
                }
                else if (e.Column.FieldName == "FK_ICProductGroupID")
                {
                    ICProductGroupsInfo pg = ProductGroupList.FirstOrDefault(t => t.ICProductGroupID == item.FK_ICProductGroupID);
                    if (pg != null)
                    {
                        item.FK_ICDepartmentID = pg.FK_ICDepartmentID;
                    }

                }
                else if (e.Column.FieldName == "FK_ICDepartmentID")
                {
                    item.FK_ICProductGroupID = 0;

                }
                else if (e.Column.FieldName == "FK_ACMaintainGroupConfigID")
                {
                    ((DeviceConfigModule)Screen.Module).ChangeItemMaintainGroup(item);
                }

                this.RefreshDataSource();
            }

        }
    }
}

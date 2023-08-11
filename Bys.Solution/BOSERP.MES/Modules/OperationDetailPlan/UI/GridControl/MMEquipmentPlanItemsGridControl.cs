using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class MMEquipmentPlanItemsGridControl : BOSGridControl
    {
        public List<ICProductsInfo> EquipmentList;
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMDetailPlanEquipmentQty" ||
                    column.FieldName == "MMDetailPlanEquipmentPlanQty")
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    if (column.FieldName == "MMDetailPlanEquipmentQty")
                        column.OptionsColumn.AllowEdit = true;
                }
                if (column.FieldName == "FK_ICEquipmentID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit rpi = new RepositoryItemBOSLookupEdit();
                    rpi.DisplayMember = "ICProductName";
                    rpi.ValueMember = "ICProductID";
                    rpi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    rpi.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    rpi.NullText = string.Empty;
                    rpi.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã"));
                    rpi.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên"));
                    List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Equipment.ToString()).ToList();
                    if (productViewList.Count() > 0)
                    {
                        EquipmentList = new List<ICProductsInfo>();
                        productViewList.ForEach(o =>
                         {

                             ICProductsInfo newObj = new ICProductsInfo();
                             BOSUtil.CopyViewObject(o, newObj);
                             EquipmentList.Add(newObj);
                         });
                    }
                    rpi.DataSource = EquipmentList;
                    rpi.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    column.ColumnEdit = rpi;
                }
                else if (column.FieldName == "Registration")
                {
                    column.VisibleIndex = 2;
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Đăng ký";
                    rep1.Click += new EventHandler(Registration);
                    column.ColumnEdit = rep1;
                }
                else if (column.FieldName == "Machine")
                {
                    RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
                    rep2.NullText = "Chi tiết";
                    column.OptionsColumn.AllowEdit = true;
                    rep2.Click += new EventHandler(ViewMachine);
                    column.ColumnEdit = rep2;
                }
            }
            InitColumnSummary("MMDetailPlanEquipmentQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("MMDetailPlanEquipmentPlanQty", DevExpress.Data.SummaryItemType.Sum);


            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.CellValueChanging += new CellValueChangedEventHandler(GridView_CellValueChanging);
            gridView.RowCellStyle += gridView_RowCellStyle;
            gridView.DoubleClick += GridView_DoubleClick;
            gridView.CustomColumnDisplayText += GridView_CustomColumnDisplayText;
            return gridView;
        }

        private void GridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "Registration" && e.ListSourceRowIndex >= 0)
            {
                int dataSourceIndex = e.ListSourceRowIndex;
                string status = (string)gridView.GetListSourceRowCellValue(dataSourceIndex, "MMDetailPlanEquipmentStatus");
                if (status == Status.Approved.ToString())
                {
                    e.DisplayText = "Hủy đăng ký";
                }
            }
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMDetailPlanEquipmentsInfo item = (MMDetailPlanEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    ((OperationDetailPlanModule)Screen.Module).ShowRegisttrationPlandata(item);
                }
            }
        }

        private void ViewMachine(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMDetailPlanEquipmentsInfo obj = (MMDetailPlanEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    MMOperationDetailPlanItemChildsInfo ticket = entity.OperationDetailPlanItemChildsList.Where(o => o.MMOperationDetailPlanItemChildID == obj.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if (ticket != null)
                        ((OperationDetailPlanModule)Screen.Module).ShowDataMachine(ticket, true);
                }
            }
        }
        private void Registration(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMDetailPlanEquipmentsInfo obj = (MMDetailPlanEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    if (obj.FK_ICEquipmentID > 0 || obj.MMDetailPlanEquipmentStatus == Status.Approved.ToString())
                    {
                        if (obj.MMDetailPlanEquipmentStatus == Status.Approved.ToString())
                            ((OperationDetailPlanModule)Screen.Module).CancelRegistrationEquipment(entity.EquipmentDetailPlansList, obj);
                        else if (obj.MMDetailPlanEquipmentStatus == Status.New.ToString())
                            ((OperationDetailPlanModule)Screen.Module).RegistrationEquipment(entity.EquipmentDetailPlansList, obj);
                    }
                    else
                        BOSApp.ShowMessage("Bạn chưa chọn khuôn!");

                }
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView == null) return;
            MMDetailPlanEquipmentsInfo obj = (MMDetailPlanEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);

            ICProductSemisController objSemiCtroll = new ICProductSemisController();
            List<ICProductSemisInfo> listSemi = new List<ICProductSemisInfo>();
            if (obj != null)
                listSemi = objSemiCtroll.GetAllEquipmentBySemiProduct(obj.FK_ICProductID);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (listSemi != null && listSemi.Count > 0)
            {
                EquipmentList = new List<ICProductsInfo>();
                foreach (ICProductSemisInfo item in listSemi)
                {
                    ICProductsForViewInfo sourceObj = BOSApp.CurrentProductList.Where(o => o.ICProductID == item.FK_ICProductID).FirstOrDefault();
                    if (sourceObj != null)
                    {
                        ICProductsInfo objEquipmentSemi = new ICProductsInfo();
                        BOSUtil.CopyViewObject(sourceObj, objEquipmentSemi);
                        if (objEquipmentSemi != null)
                            EquipmentList.Add(objEquipmentSemi);
                    }

                }
            }
            else
            {
                List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Equipment.ToString()).ToList();
                if (productViewList.Count() > 0) productViewList.ForEach(o =>
                {
                    ICProductsInfo newObj = new ICProductsInfo();
                    BOSUtil.CopyViewObject(o, newObj);
                    EquipmentList.Add(newObj);
                });
            }
            lookUpEdit.Properties.DataSource = EquipmentList;
        }
        private void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)sender;
                MMDetailPlanEquipmentsInfo obj = (MMDetailPlanEquipmentsInfo)gridView.GetRow(e.RowHandle);
                if (obj != null)
                {
                    OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    obj = (MMDetailPlanEquipmentsInfo)entity.ModuleObjects["MMDetailPlanEquipments"];
                    if (obj != null && e.Column.FieldName == "Selected" || obj.MMDetailPlanEquipmentStatus == Status.Approved.ToString())
                        obj.AllowPropertyChangedEvent = false;

                }
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                MMDetailPlanEquipmentsInfo obj = (MMDetailPlanEquipmentsInfo)gridView.GetRow(e.RowHandle);
                if (obj != null)
                {
                    if (e.Column.FieldName == "MMDetailPlanEquipmentQty" && obj.IsError)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }
                    else if (e.Column.FieldName == "Registration" && obj.MMDetailPlanEquipmentStatus == Status.Approved.ToString())
                    {
                        e.Appearance.BackColor = Color.Gainsboro;
                        e.Appearance.BackColor2 = Color.Gainsboro;

                    }
                    else if (e.Column.FieldName == "Registration" && obj.MMDetailPlanEquipmentStatus == Status.New.ToString())
                    {
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                    else if (e.Column.FieldName == "Machine" && obj.Machine > 0)
                    {
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                }

            }
        }
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EquipmentDetailPlansList;
            this.DataSource = bds;
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.RowHandle < 0) return;

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMDetailPlanEquipmentsInfo obj = (MMDetailPlanEquipmentsInfo)gridView.GetRow(e.RowHandle);
            if (obj != null)
            {
                obj.IsError = false;
                if (e.Column.FieldName == "Selected") return;
                bool existError = false;
                if (obj.MMDetailPlanEquipmentStatus == Status.Approved.ToString())
                {
                    BOSApp.ShowMessage("Chi tiết đã đăng ký, bạn không thể thay đổi");
                    existError = true;
                }
                else
                {
                    if (e.Column.FieldName == "FK_ICEquipmentID" || e.Column.FieldName == "MMDetailPlanEquipmentQty")
                    {
                        if (obj.FK_ICEquipmentID > 0)
                        {
                            bool result = ((OperationDetailPlanModule)this.Screen.Module).ValidateRegisterEquipment(entity.EquipmentDetailPlansList, obj);
                            if (!result)
                            {
                                if (BOSApp.ShowMessageYesNo("Số lượng đăng ký vượt số lượng có, bạn có muốn tiếp tục không?") == DialogResult.Yes)
                                {
                                    result = true;
                                }
                            }
                            if (!result)
                                existError = true;
                        }
                        else
                            BOSApp.ShowMessage("Bạn chưa chọn khuôn!");
                    }
                }
                if (existError)
                {
                    if (e.Column.FieldName == "MMDetailPlanEquipmentQty")
                    {
                        obj.MMDetailPlanEquipmentQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                    else if (e.Column.FieldName == "FK_ICEquipmentID")
                        obj.FK_ICEquipmentID = int.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                }
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                MMDetailPlanEquipmentsInfo item = (MMDetailPlanEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                    ((OperationDetailPlanModule)Screen.Module).DeleteItemEquipment(item);
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "Selected";
            column.Caption = "Chọn";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Đăng ký";
            column.FieldName = "Registration";
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Máy móc";
            column.FieldName = "Machine";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

        }
    }
}

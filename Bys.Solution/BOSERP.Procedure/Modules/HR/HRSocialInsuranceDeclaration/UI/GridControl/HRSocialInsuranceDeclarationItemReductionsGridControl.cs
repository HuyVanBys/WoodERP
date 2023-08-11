using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRSocialInsuranceDeclaration
{
    public partial class HRSocialInsuranceDeclarationItemReductionsGridControl : BOSGridControl
    {
        BandedGridView BandedMainView { get; set; }
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }
        /// <summary>
        /// Gets or sets the row hanle of current row selected
        /// </summary>
        public int RowHandle { get; set; }

        ADInsurranceConditionsController objInsurranceConditionsController = new ADInsurranceConditionsController();
        ADInsurrancePapersController objInsurrancePapersController = new ADInsurrancePapersController();
        ADInsurrancePlansController objInsurrancePlansController = new ADInsurrancePlansController();

        List<ADInsurrancePlansInfo> InsurrancePlanList;
        List<ADInsurrancePapersInfo> InsurrancePaperList;
        List<ADInsurranceConditionsInfo> InsurranceConditionList;

        List<ADInsurrancePlansInfo> InsurrancePlanListAll;
        List<ADInsurrancePapersInfo> InsurrancePaperListAll;
        List<ADInsurranceConditionsInfo> InsurranceConditionListAll;

        List<ADConfigValuesInfo> listConfigValue;
        ADConfigValuesController objConfigValuesController = new ADConfigValuesController();

        public override void InitGridControlDataSource()
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReductionSocialInsuranceDeclarationItemList;
            DataSource = bds;
        }

        public override void InitializeControl()
        {
            listConfigValue = objConfigValuesController.GetADConfigValuesByKeyGroup("SocialInsuranceDeclarationItemObject");

            InsurrancePlanListAll = (List<ADInsurrancePlansInfo>)objInsurrancePlansController.GetListFromDataSet(objInsurrancePlansController.GetAllObjects());
            InsurrancePaperListAll = (List<ADInsurrancePapersInfo>)objInsurrancePapersController.GetListFromDataSet(objInsurrancePapersController.GetAllObjects());
            InsurranceConditionListAll = (List<ADInsurranceConditionsInfo>)objInsurranceConditionsController.GetListFromDataSet(objInsurranceConditionsController.GetAllObjects());

            GridViewMain = new GridView();
            this.EmbeddedNavigator.Buttons.CustomButtons.Clear();
            base.InitializeControl();
            //Init banded view and make it the main view
            BandedMainView = InitializeBandedGridView(GridViewMain);
            MainView = BandedMainView;
            ViewCollection.Clear();
            ViewCollection.AddRange(new BaseView[] { BandedMainView });
            ShowOnlyPredefinedDetails = false;
            //UseEmbeddedNavigator = false;
        }

        /// <summary>
        /// Initialize BandedGridView
        /// </summary>
        /// <param name="gridView"></param>
        /// <returns></returns>
        private BandedGridView InitializeBandedGridView(GridView gridView)
        {
            //Creat a banded grid view
            BandedGridView bandedView = new BandedGridView();
            //Check loại bhxh
            ReloadGridColumnReduction(bandedView, gridView);

            //bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            //bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            bandedView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return bandedView;
        }

        private void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController controller = new ADConfigValuesController();
            List<ADConfigValuesInfo> list = (List<ADConfigValuesInfo>)controller.GetADConfigValuesByKeyGroup("EmployeeContractType");
            if (list != null && list.Count > 0)
            {
                list.Insert(0, new ADConfigValuesInfo());
                lookUpEdit.Properties.DataSource = list;
            }
        }

        private void repositoryItemLookUpEditInsurrancePlan_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo objSocialInsuranceDeclarationsInfo = (HRSocialInsuranceDeclarationsInfo)entity.MainObject;
            InsurrancePlanList = objInsurrancePlansController.GetInsurrancePlanListByType(objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationType);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (InsurrancePlanList != null && InsurrancePlanList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = InsurrancePlanList;
            }
        }

        private void repositoryItemLookUpEditInsurranceCondition_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo objSocialInsuranceDeclarationsInfo = (HRSocialInsuranceDeclarationsInfo)entity.MainObject;
            InsurranceConditionList = objInsurranceConditionsController.GetInsurranceConditionListByType(objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationType);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (InsurranceConditionList != null && InsurranceConditionList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = InsurranceConditionList;
            }
        }

        private void repositoryItemLookUpEditInsurrancePaper_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRSocialInsuranceDeclarationEntities entity = (HRSocialInsuranceDeclarationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            HRSocialInsuranceDeclarationsInfo objSocialInsuranceDeclarationsInfo = (HRSocialInsuranceDeclarationsInfo)entity.MainObject;
            InsurrancePaperList = objInsurrancePapersController.GetInsurrancePaperListByType(objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationType);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (InsurrancePaperList != null && InsurrancePaperList.Count > 0)
            {
                lookUpEdit.Properties.DataSource = InsurrancePaperList;
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "HREmployeeContractType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesController controller = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)controller.GetObjectByGroupAndValue("EmployeeContractType", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            else if (e.Column.FieldName == "FK_ADInsurrancePaperID")
            {
                if (e.Value != null)
                {
                    int id = 0;
                    Int32.TryParse(e.Value.ToString(), out id);
                    ADInsurrancePapersInfo objInsurrancePapersInfo = (ADInsurrancePapersInfo)InsurrancePaperListAll.FirstOrDefault(o => o.ADInsurrancePaperID == id);
                    if (objInsurrancePapersInfo != null)
                    {
                        e.DisplayText = objInsurrancePapersInfo.ADInsurrancePaperNo;
                    }
                }
            }
            else if (e.Column.FieldName == "FK_ADInsurranceConditionID")
            {
                if (e.Value != null)
                {
                    int id = 0;
                    Int32.TryParse(e.Value.ToString(), out id);
                    ADInsurranceConditionsInfo objInsurranceConditionsInfo = (ADInsurranceConditionsInfo)InsurranceConditionListAll.FirstOrDefault(o => o.ADInsurranceConditionID == id);
                    if (objInsurranceConditionsInfo != null)
                    {
                        e.DisplayText = objInsurranceConditionsInfo.ADInsurranceConditionNo;
                    }
                }
            }
            else if (e.Column.FieldName == "FK_ADInsurrancePlanID")
            {
                if (e.Value != null)
                {
                    int id = 0;
                    Int32.TryParse(e.Value.ToString(), out id);
                    ADInsurrancePlansInfo objInsurrancePlansInfo = (ADInsurrancePlansInfo)InsurrancePlanListAll.FirstOrDefault(o => o.ADInsurrancePlanID == id);
                    if (objInsurrancePlansInfo != null)
                    {
                        e.DisplayText = objInsurrancePlansInfo.ADInsurrancePlanNo;
                    }
                }
            }
        }

        private void BandedView_RowClick(object sender, RowClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }

        private void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((HRSocialInsuranceDeclarationModule)Screen.Module).RemoveReductionSocialInsuranceDeclarationItemFromList();
            }
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "HRSocialInsuranceDeclarationItemObject")
                {
                    GridView gridView = (GridView)MainView;
                    HRSocialInsuranceDeclarationItemsInfo objSocialInsuranceDeclarationItemsInfo = (HRSocialInsuranceDeclarationItemsInfo)gridView.GetRow(e.RowHandle);
                    ((HRSocialInsuranceDeclarationModule)Screen.Module).UpdateTyLeDong(objSocialInsuranceDeclarationItemsInfo);
                }
            }
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;
            if (!bandedView.IsValidRowHandle(e.RowHandle))
                return;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridViewMain = gridView;
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            //GridColumn column = new GridColumn();
            //column.Caption = TimeSheetLocalizedResources.HREmployeeNo;
            //column.FieldName = "HREmployeeNo";
            //gridView.Columns.Add(column);
        }

        /// <summary>
        /// Create a new banded column from a grid one
        /// </summary>
        /// <param name="column">Given grid column</param>
        /// <param name="owner">The grid band</param>
        /// <param name="allowEdit">A variable indicates whether the column is editable</param>
        /// <returns>The banded grid column</returns>
        private BandedGridColumn CreateNewColumn(GridColumn column, GridBand owner, bool allowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.ColumnEdit = column.ColumnEdit;
            //bandedColumn.Width = column.Width;
            bandedColumn.Width = 80;

            bandedColumn.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;

            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;

            return bandedColumn;
        }

        /// <summary>
        /// Create a new banded column from a grid one
        /// </summary>
        /// <param name="column">Given grid column</param>
        /// <param name="owner">The grid band</param>
        /// <param name="allowEdit">A variable indicates whether the column is editable</param>
        /// <returns>The banded grid column</returns>
        private BandedGridColumn CreateNewColumnLookup(GridColumn column, GridBand owner, bool allowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.Width = 80;

            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;

            return bandedColumn;
        }

        /// <summary>
        /// Create a new banded column from a grid one in numeric format
        /// </summary>
        /// <param name="column">Given grid column</param>
        /// <param name="owner">The grid band</param>
        /// <param name="allowEdit">A variable indicates whether the column is editable</param>
        /// <returns>The banded grid column</returns>
        private BandedGridColumn CreateNumericColumn(GridColumn column, GridBand owner, bool allowEdit, string formatType)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = column.Name;
            bandedColumn.Caption = column.Caption;
            bandedColumn.FieldName = column.FieldName;
            bandedColumn.Visible = true;
            bandedColumn.Width = 80;
            bandedColumn.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            RepositoryItemTextEdit rep = new RepositoryItemTextEdit();
            rep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            rep.Mask.EditMask = "n2";
            rep.Mask.UseMaskAsDisplayFormat = true;
            bandedColumn.ColumnEdit = rep;
            bandedColumn.OwnerBand = owner;

            return bandedColumn;
        }

        public void ReloadGridColumnReduction(BandedGridView bandedView, GridView gridView)
        {
            //Thông tin chung
            GridBand gridBand1 = new GridBand();
            //Tiền lương
            GridBand gridBand2 = new GridBand();
            //Hiệu lực quyết định
            GridBand gridBand3 = new GridBand();
            //Ghi chú
            GridBand gridBand4 = new GridBand();
            //Tình trạng sổ
            GridBand gridBand5 = new GridBand();
            //Nơi đang ký KCB ban đầu
            GridBand gridBand6 = new GridBand();
            //Nơi cấp giấy khai sinh
            GridBand gridBand8 = new GridBand();
            //Địa chỉ liên hệ(nơi sinh sống)
            GridBand gridBand10 = new GridBand();
            //Thông tin chủ hộ
            GridBand gridBand12 = new GridBand();
            //-------------------------------------------------
            //Tiền lương
            GridBand gridBand14 = new GridBand();
            //Phụ cấp tiền lương theo hệ số
            GridBand gridBand15 = new GridBand();

            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            gridBand1,
            gridBand2,
            gridBand3,
            gridBand4,
            gridBand5,
            gridBand6,
            gridBand8,
            gridBand10,
            gridBand12});

            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ShowAutoFilterRow = true;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsCustomization.AllowSort = true;
            bandedView.OptionsView.ShowChildrenInGroupPanel = false;
            bandedView.OptionsView.ShowDetailButtons = false;
            bandedView.OptionsView.RowAutoHeight = true;

            //GridBand1
            gridBand1.Caption = "Thông tin chung";
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand1.Name = "gridBand1";

            //GridBand2
            gridBand2.Caption = "Tiền lương";
            gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand2.Name = "gridBand2";

            //GridBand3
            gridBand3.Caption = String.Empty;
            gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand3.Name = "gridBand3";

            //GridBand4
            gridBand4.Caption = "Ghi chú";
            gridBand4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand4.Name = "gridBand4";

            //GridBand5
            gridBand5.Caption = String.Empty;
            gridBand5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand5.Name = "gridBand5";

            //GridBand6
            gridBand6.Caption = "Nơi đăng ký KCB ban đầu(mã số)";
            gridBand6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand6.Name = "gridBand6";

            //GridBand8
            gridBand8.Caption = "Nơi cấp giấy khai sinh (quê quán)";
            gridBand8.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand8.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand8.Name = "gridBand8";

            //GridBand10
            gridBand10.Caption = "Địa chỉ liên hệ (nơi sinh sống)";
            gridBand10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand10.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand10.Name = "gridBand10";

            //GridBand12
            gridBand12.Caption = "Thông tin chủ hộ";
            gridBand12.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand12.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand12.Name = "gridBand12";

            //GridBand14
            gridBand14.Caption = "Tiền lương";
            gridBand14.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand14.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand14.Name = "gridBand14";

            //GridBand15
            gridBand15.Caption = "Phụ cấp";
            gridBand15.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand15.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridBand15.Name = "gridBand15";

            gridBand2.Children.Add(gridBand14);
            gridBand2.Children.Add(gridBand15);
            // Assigning columns to bands
            //==========Thông tin chung============
            //Họ và tên
            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            //Sổ định danh(Mã sổ BHXH)
            column = gridView.Columns["HRSocialInsuranceDeclarationItemBHXHNumber"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }

            //Chức vụ
            column = gridView.Columns["FK_HRLevelID"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand1, false);
            }
            //======================================================================
            //============Tiền lương==================================================
            //Tiền đồng
            column = gridView.Columns["HRSocialInsuranceDeclarationItemMucLuongBHXH"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand14, true, "n2");
            }

            //Hệ số
            column = gridView.Columns["HRSocialInsuranceDeclarationItemHeso"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand14, true, "n2");
            }

            //CV
            column = gridView.Columns["HRSocialInsuranceDeclarationItemPhucapCV"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, true, "n2");
            }

            //Thâm niên VK(%)
            column = gridView.Columns["HRSocialInsuranceDeclarationItemThamNienVK"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, true, "n2");
            }

            //Thâm niên nghề(%)
            column = gridView.Columns["HRSocialInsuranceDeclarationItemThamnienNghe"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, true, "n2");
            }

            column = gridView.Columns["HRSocialInsuranceDeclarationItemPhucapLuong"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, true, "n2");
            }

            //PC lương
            column = gridView.Columns["HRSocialInsuranceDeclarationItemCacKhoanBoSung"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, true, "n2");
            }

            //Phụ cấp chênh lệch bảo lưu
            column = gridView.Columns["HRSocialInsuranceDeclarationItemPCChenhLechOld"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand15, true, "n2");
            }
            //============================================================================
            //Hiệu lực QĐ từ ngày
            column = gridView.Columns["HRSocialInsuranceDeclarationItemDate"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand3, true);
            }

            //==================Ghi chú===============================================
            //Hiệu lực QĐ đến ngày
            column = gridView.Columns["HRSocialInsuranceDeclarationItemDateTo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand4, true);
            }

            //Phương án
            column = gridView.Columns["FK_ADInsurrancePlanID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADInsurrancePlanNo";
                repositoryItemLookUpEdit.ValueMember = "ADInsurrancePlanID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADInsurrancePlanNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADInsurrancePlanName", "Tên"));
                repositoryItemLookUpEdit.DataSource = InsurrancePlanListAll;
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditInsurrancePlan_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                CreateNewColumn(column, gridBand4, true);
            }

            //Số QĐ
            column = gridView.Columns["HRSocialInsuranceDeclarationItemEmployeeContractNo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand4, true);
            }

            //Ngày ký QĐ
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContractSignDate"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand4, true);
            }

            //Tỷ lệ đóng(%)
            column = gridView.Columns["HRSocialInsuranceDeclarationItemTyLeDong"];
            if (column != null)
            {
                CreateNumericColumn(column, gridBand4, true, "n2");
            }
            //==================================================================================

            //========Tab trống=============================================================
            //Đã báo giảm
            column = gridView.Columns["HRSocialInsuranceDeclarationItemHasDecreased"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //Nhập chi tiết trường hợp giảm
            column = gridView.Columns["HRSocialInsuranceDeclarationItemTHGiam"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }
            //========================================================================
            //Ngày mất
            column = gridView.Columns["HRSocialInsuranceDeclarationItemLostDay"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //"Mã Vùng(Nhập giá trị ở cột MAQH ở sheet MA_VUNG)"
            column = gridView.Columns["FK_GEDistrictID"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //Mã phòng ban
            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //Nữ(X)
            column = gridView.Columns["HRSocialInsuranceDeclarationItemIsFemale"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, false);
            }

            //Ngày sinh
            column = gridView.Columns["HRSocialInsuranceDeclarationItemEmployeeBirthday"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, false);
            }

            //Nội dung thay đổi
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContentChange"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //Tài liệu tham khảo
            column = gridView.Columns["HRSocialInsuranceDeclarationItemFileRefer"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //Quốc tịch
            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //Mã dân tộc
            column = gridView.Columns["FK_GENationalityID"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }

            //Số CMND
            column = gridView.Columns["HRSocialInsuranceDeclarationItemEmployeeIDNumber"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand5, true);
            }
            //===============================================================================================================
            //Mã tỉnh
            column = gridView.Columns["FK_GEIDCardStateProvinceID2"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand6, true);
            }

            //Mã bệnh viện
            column = gridView.Columns["HRSocialInsuranceDeclarationItemHospitalNo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand6, true);
            }

            //Xã/phường
            column = gridView.Columns["FK_GEWardIDKhaiSinh"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand8, true);
            }

            //Số nhà, đường phố, thôn xóm
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContactAddressLienHe"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand10, true);
            }

            //Xã/phường
            column = gridView.Columns["FK_GEWardIDLienHe"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand10, true);
            }

            //Mã hộ gia đình
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContactPersonCode"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand12, true);
            }

            //Tên chủ hộ
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContactPersonName"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand12, true);
            }

            //Điện thoại
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContactPersonPhone"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand12, true);
            }

            //Số sổ họ khẩu/ tạm trú
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContactPersonNumberBook"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand12, true);
            }

            //Loại giấy tờ
            column = gridView.Columns["FK_ADInsurrancePaperID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADInsurrancePaperNo";
                repositoryItemLookUpEdit.ValueMember = "ADInsurrancePaperID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADInsurrancePaperNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADInsurrancePaperName", "Tên"));
                repositoryItemLookUpEdit.DataSource = InsurrancePaperListAll;
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditInsurrancePaper_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                CreateNewColumn(column, gridBand12, true);
            }

            //Xã/phường
            column = gridView.Columns["FK_GEWardIDChuHo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand12, true);
            }

            //Số nhà, đường, thôn xóm
            column = gridView.Columns["HRSocialInsuranceDeclarationItemContactAddressChuHo"];
            if (column != null)
            {
                CreateNewColumn(column, gridBand12, true);
            }
        }
    }
}
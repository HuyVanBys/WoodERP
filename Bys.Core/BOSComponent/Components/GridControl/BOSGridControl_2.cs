using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using BOSCommon;
using BOSLib;
using Localization;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Linq;
using System.Runtime.InteropServices;
using BOSERP;

namespace BOSComponent
{
    public partial class BOSGridControl : DevExpress.XtraGrid.GridControl, ICloneable, IBOSControl
    {
        #region Variables
        protected BOSScreen _screen;
        protected String _BOSDataSource;
        protected String _BOSDataMember;
        protected String _BOSPropertyName;
        protected String _BOSFieldGroup;
        protected String _BOSFieldRelation;
        protected String _BOSComment;
        protected String _BOSError;
        protected DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = null;
        protected String _BOSPrivilege;
        protected String _BOSDescription;
        protected String _BOSGridType;
        protected SortedList LookupTables;
        protected SortedList LookupTablesUpdatedDate;
        protected SortedList<string, GELookupTablesInfo> LookupTableObjects;
        #endregion

        #region Public Properties
        [Category("Design")]
        [Browsable(true)]
        public new String Name
        {
            get
            {
                return base.Name;
            }

            set
            {
                base.Name = value;
            }
        }

        public BOSScreen Screen
        {
            get
            {
                return _screen;
            }
            set
            {
                _screen = value;
            }
        }

        [Category("BOS")]
        public String BOSFieldGroup
        {
            get
            {
                return _BOSFieldGroup;
            }
            set
            {
                _BOSFieldGroup = value;
            }
        }

        [Category("BOS")]
        public String BOSFieldRelation
        {
            get
            {
                return _BOSFieldRelation;
            }
            set
            {
                _BOSFieldRelation = value;
            }
        }

        [Category("BOS")]
        public String BOSDataSource
        {
            get
            {
                return _BOSDataSource;
            }
            set
            {
                _BOSDataSource = value;
            }
        }

        [Category("BOS")]
        public String BOSDataMember
        {
            get
            {
                return _BOSDataMember;
            }
            set
            {
                _BOSDataMember = value;
            }
        }

        [Category("BOS")]
        public String BOSPropertyName
        {
            get
            {
                return _BOSPropertyName;
            }
            set
            {
                _BOSPropertyName = value;
            }
        }

        [Category("BOS")]
        public String BOSComment
        {
            get
            {
                return _BOSComment;
            }
            set
            {
                _BOSComment = value;
            }
        }

        [Category("BOS")]
        public String BOSError
        {
            get
            {
                return _BOSError;
            }
            set
            {
                _BOSError = value;
            }
        }

        [Category("BOS")]
        public String BOSPrivilege
        {
            get
            {
                return _BOSPrivilege;
            }
            set
            {
                _BOSPrivilege = value;
            }
        }

        [Category("BOS")]
        public String BOSDescription
        {
            get
            {
                return _BOSDescription;
            }
            set
            {
                _BOSDescription = value;
            }
        }

        [Category("BOS")]
        public String BOSGridType
        {
            get
            {
                return _BOSGridType;
            }
            set
            {
                _BOSGridType = value;
            }
        }

        [Category("Design")]
        public GridColumnCollection Columns 
        {
            get
            {
                GridView gridView = (GridView)MainView;
                return gridView.Columns;
            }
        }        
        #endregion

        #region Constructor
        public BOSGridControl()
        {
            InitializeComponent();

            this.MainView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
        }

        public BOSGridControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.MainView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
        }
        #endregion

        #region Function for init GridControl        
        public virtual void InitializeControl(STFieldsInfo objFieldInfo)
        {
            this.BOSGridType = objFieldInfo.STFieldGridControlType;
        }

        /// <summary>
        /// Initialize grid control including view, columns, data source and events
        /// </summary>        
        public virtual void InitializeControl()
        {
            LookupTables = ((IBaseModuleERP)Screen.Module).GetLookupTableCollection();
            LookupTablesUpdatedDate = ((IBaseModuleERP)Screen.Module).GetLookupTableUpdatedDateCollection();
            LookupTableObjects = ((IBaseModuleERP)Screen.Module).GetLookupTableObjects();

            //Init Common Properties for GridControl Control
            InitializeCommonProperties();

            //Init GridControl View and columns     
            DevExpress.XtraGrid.Views.Grid.GridView gridView = InitializeGridView();            
            this.MainView = gridView;

            //Init DataSource
            InitGridControlDataSource();

            //Using embedded Navigator
            this.UseEmbeddedNavigator = true;
            this.EmbeddedNavigator.Name = "navigator_" + this.Name;
            NavigatorCustomButton customizeColumnButton = new NavigatorCustomButton(8, ComponentLocalizedResources.CustomizeColumn);
            customizeColumnButton.Tag = "CustomizeColumn";
            NavigatorCustomButton saveColumnCustomizationButton = new NavigatorCustomButton(9, ComponentLocalizedResources.SaveColumnCustomization);
            saveColumnCustomizationButton.Tag = "SaveColumnCustomization";
            this.EmbeddedNavigator.Buttons.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] { 
                                                                            customizeColumnButton,
                                                                            saveColumnCustomizationButton});
            this.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.EmbeddedNavigator.Buttons.Append.Visible = false;

            //Add events to navigator buttons
            this.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(NavigatorButton_Click);
            this.KeyUp += new KeyEventHandler(((IBaseModuleERP)Screen.Module).Control_KeyUp);

            //Add events to validate row before leave row
            gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(GridView_ValidateRow);
        }              

        protected void InitializeCommonProperties()
        {

        }

        public virtual void InitGridControlDataSource()
        {

        }

        #region Function for init GridControl View
        Point pt = new Point(0, 0);
        protected virtual DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.ViewCollection[0];
            gridView.Name = "fld_dgv" + this.Name.Substring(7);
            gridView.OptionsBehavior.Editable = true;
            gridView.OptionsView.ShowGroupPanel = false;
            
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsView.ShowDetailButtons = false;            

            gridView.OptionsNavigation.EnterMoveNextColumn = true;

            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsCustomization.AllowFilter = true;
            gridView.OptionsNavigation.UseTabKey = false;            

            gridView.GridControl = this;

            InitGridViewColumns(gridView);

            BOSDbUtil dbUtil = new BOSDbUtil();           
            try
            {
                gridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(GridView_CustomDrawCell);
                gridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(GridView_InitNewRow);
                gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
                gridView.Click += new EventHandler(GridView_Click);
                //gridView.DoubleClick += new EventHandler(gridView_DoubleClick);
                gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridView_CellValueChanged);
                gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
                gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(GridView_ValidateRow);
                gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(GridView_InvalidRowException);
                gridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            }
            catch (Exception)
            {
            }

            gridView.GridMenuItemClick += new GridMenuItemClickEventHandler(gridView_GridMenuItemClick);

            gridView.ShowGridMenu += new GridMenuEventHandler(gridView_ShowGridMenu);
            //gridView.GroupPanelText = "Kéo một cột vào đây để nhóm";
            gridView.CustomSummaryExists += new CustomSummaryExistEventHandler(gridView_CustomSummaryExists);
            InvalidateLookupEditColumns();
            return gridView;
        }

        //void gridView_DoubleClick(object sender, EventArgs e)
        //{
        //    GridView view = (GridView)sender;
        //    Point pt = view.GridControl.PointToClient(Control.MousePosition);
        //    GridHitInfo info = view.CalcHitInfo(pt);
        //    if (info != null && info.HitTest == GridHitTest.RowCell)
        //    {
        //        GridColumn col = info.Column;
        //        if (col != null)
        //        {
        //            ShowModule(col, view);
        //        }
        //    }
        //}

        private string GetTableName(string col)
        {
            string re = null;
            STModuleColumnsController objModuleColumnsController = new STModuleColumnsController();
            STModuleColumnsInfo objModuleColumnsInfo = objModuleColumnsController.GetByColumnName(col);
            if (objModuleColumnsInfo != null) return objModuleColumnsInfo.STModuleTableName;
            string[] endW = new string[] { "No" };
            if (col.ToLower().StartsWith("fk_"))
            {
                re = col.Substring(3);
                re = re.Substring(0, re.Length - 2) + "s";
                return re;
            }
            foreach (string s in endW)
            {
                if (col.ToLower().EndsWith(s.ToLower()))
                {
                    re = col.Substring(0, col.Length - s.Length) + "s";
                    return re;
                }
            }
            return re;
        }

        private void ShowModule(GridColumn col, GridView view)
        {
            try
            {
                string table = GetTableName(col.FieldName);
                if (!string.IsNullOrEmpty(table))
                {
                    STModuleColumnsController objModuleColumnsController = new STModuleColumnsController();
                    STModuleColumnsInfo objModuleColumnsInfo = objModuleColumnsController.GetByTableName(table);
                    if (objModuleColumnsInfo != null)
                    {
                        STModulesController objModulesController = new STModulesController();
                        STModulesInfo objModulesInfo = (STModulesInfo)objModulesController.GetObjectByID(objModuleColumnsInfo.STModuleID);
                        if (objModulesInfo != null)
                        {
                            if (!col.FieldName.ToLower().StartsWith("fk_"))
                            {
                                int ID = 0;
                                BaseBusinessController controller = BusinessControllerFactory.GetBusinessController(table + "Controller");
                                if (controller != null)
                                {
                                    ID = controller.GetObjectIDByNo(view.GetFocusedValue().ToString());
                                    ActiveModule(objModulesInfo.STModuleName, ID);
                                }
                            }
                            else
                            {
                                ActiveModule(objModulesInfo.STModuleName, int.Parse(view.GetFocusedValue().ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
        }
        //[DllImport("BOSERP.exe")]
        //extern static void ShowModule(String strModuleName, int ID);
        public virtual void ActiveModule(string moduleName, int ID)
        {
            if (Screen != null && ID > 0)
            {
                Type moduleType = Assembly.LoadFrom(Application.StartupPath + "\\BOSERP.exe").GetType("BOSERP.Modules." + moduleName + "." + moduleName + "Module");
                var methodInfo = moduleType.GetMethod("ShowModule", new Type[] { typeof(string), typeof(int) });
                var o = Activator.CreateInstance(moduleType, null);
                object[] parameters = new object[2];
                parameters[0] = moduleName;
                parameters[1] = ID;
                var r = methodInfo.Invoke(o, parameters);
            }
        }

        void gridView_CustomSummaryExists(object sender, CustomSummaryExistEventArgs e)
        {
            if (e.Item.GetType() == typeof(GridColumnSummaryItem))
            {
                GridColumnSummaryItem col = (GridColumnSummaryItem)e.Item;
                STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
                GridView gr = (GridView)sender;
                GridColumn gcol = gr.Columns[col.FieldName];
                if (gcol != null && gcol.RealColumnEdit != null && !string.IsNullOrEmpty(gcol.RealColumnEdit.DisplayFormat.FormatString))
                {
                    col.DisplayFormat = "{0:" + gcol.RealColumnEdit.DisplayFormat.FormatString + "}";//col.SummaryType.ToString().ToUpper() +
                }
            }
            else if (e.Item.GetType() == typeof(GridGroupSummaryItem))
            {
                GridGroupSummaryItem col = (GridGroupSummaryItem)e.Item;
                STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
                GridView gr = (GridView)sender;
                GridColumn gcol = gr.Columns[col.FieldName];
                if (gcol != null && gcol.RealColumnEdit != null && !string.IsNullOrEmpty(gcol.RealColumnEdit.DisplayFormat.FormatString))
                {
                    col.DisplayFormat = "{0:" + gcol.RealColumnEdit.DisplayFormat.FormatString + "}";
                }
            }
        }

        public bool PrintReport { get; set; }
        private enum DXMenuItemTag
        {
            ExportExcel,
            ReportPrint,
            SummarySubMenu,
            FooterGroup,
            AllGroup,
            CopyCell,
            CopyColumn,
            ExpandAllGroup,
            CollapseAllGroup,
            AutoFilter
        }

        private void AddMenu(GridView gr, GridViewMenu grm, bool isCreate)
        {
            if (!isCreate)
            {
                DXMenuItem menu = new DXMenuItem();
                menu.BeginGroup = true;
                menu.Caption = "Export to Excel";
                menu.Tag = DXMenuItemTag.ExportExcel.ToString();
                menu.Click += new EventHandler(excel_Click);
                grm.Items.Add(menu);

                menu = new DXMenuItem();
                menu.BeginGroup = true;
                menu.Caption = "In Report";
                menu.Tag = DXMenuItemTag.ReportPrint.ToString();
                menu.Visible = PrintReport;
                menu.Click += new EventHandler(menu_Click);
                grm.Items.Add(menu);

                DXSubMenuItem sub = new DXSubMenuItem();
                sub.BeginGroup = true;
                sub.Caption = "Summary";
                sub.Tag = DXMenuItemTag.SummarySubMenu.ToString();
                grm.Items.Add(sub);

                DXMenuCheckItem menu2 = new DXMenuCheckItem();
                menu2.Caption = "By Group";
                menu2.Tag = DXMenuItemTag.FooterGroup.ToString();
                menu2.Click += new EventHandler(menu2_Click);
                sub.Items.Add(menu2);

                menu2 = new DXMenuCheckItem();
                menu2.Caption = "All";
                menu2.Tag = DXMenuItemTag.AllGroup.ToString();
                menu2.Click += new EventHandler(menu21_Click);
                sub.Items.Add(menu2);

                DXMenuItem menu3 = new DXMenuItem();
                menu3.Caption = "Expand All Groups";
                menu3.BeginGroup = true;
                menu3.Tag = DXMenuItemTag.ExpandAllGroup.ToString();
                menu3.Click += new EventHandler(menu22_Click);
                sub.Items.Add(menu3);

                menu3 = new DXMenuItem();
                menu3.Caption = "Collapse All Groups";
                menu3.BeginGroup = false;
                menu3.Tag = DXMenuItemTag.CollapseAllGroup.ToString();
                menu3.Click += new EventHandler(menu3_Click);
                sub.Items.Add(menu3);

                int index = -1;
                bool hasFound = false;
                foreach (DXMenuItem item in grm.Items)
                {
                    index += 1;
                    if (item.Caption.Contains("Filter Editor"))
                    {
                        hasFound = true;
                        break;
                    }
                }
                if (hasFound == true)
                {
                    DXMenuCheckItem menu4 = new DXMenuCheckItem();
                    menu4.BeginGroup = false;
                    menu4.Caption = "Show Auto Filter";
                    menu4.Tag = DXMenuItemTag.AutoFilter.ToString();
                    menu4.Click += new EventHandler(menu4_Click);
                    grm.Items.Insert(index + 1, menu4);
                }
            }
            foreach (DXMenuItem i in grm.Items)
            {
                if (i.Visible != PrintReport && i.Tag.ToString().Equals(DXMenuItemTag.ReportPrint.ToString()))
                {
                    i.Visible = PrintReport;
                }
                else if (i.Tag.ToString().Equals(DXMenuItemTag.AutoFilter.ToString()))
                {
                    ((DXMenuCheckItem)i).Checked = gr.OptionsView.ShowAutoFilterRow;
                }
                else if (i.Tag.ToString().Equals(DXMenuItemTag.SummarySubMenu.ToString()))
                {
                    DXSubMenuItem sub = (DXSubMenuItem)i;
                    foreach (DXMenuItem item in sub.Items)
                    {
                        if (item.Tag.ToString().Equals(DXMenuItemTag.FooterGroup.ToString()))
                        {
                            if (gr.GroupFooterShowMode == GroupFooterShowMode.VisibleAlways)
                            {
                                ((DXMenuCheckItem)item).Checked = true;
                            }
                            else
                            {
                                ((DXMenuCheckItem)item).Checked = false;
                            }
                        }
                        else if (item.Tag.ToString().Equals(DXMenuItemTag.ExpandAllGroup.ToString()) ||
                            item.Tag.ToString().Equals(DXMenuItemTag.CollapseAllGroup.ToString()))
                        {
                            if (gr.GroupedColumns.Count <= 0) item.Enabled = false;
                            else item.Enabled = true;
                        }
                        else if (item.Tag.ToString().Equals(DXMenuItemTag.AllGroup.ToString()))
                        {
                            ((DXMenuCheckItem)item).Checked = gr.OptionsView.ShowFooter;
                        }
                    }
                }
            }
        }

        void menu4_Click(object sender, EventArgs e)
        {
            GridView gr = (GridView)this.DefaultView;
            DXMenuCheckItem dx = (DXMenuCheckItem)sender;
            gr.OptionsView.ShowAutoFilterRow = dx.Checked;
        }

        void menu3_Click(object sender, EventArgs e)
        {
            GridView gr = (GridView)this.DefaultView;
            DXMenuItem dx = (DXMenuItem)sender;
            gr.CollapseAllGroups();
        }

        void menu22_Click(object sender, EventArgs e)
        {
            GridView gr = (GridView)this.DefaultView;
            DXMenuItem dx = (DXMenuItem)sender;
            gr.ExpandAllGroups();
        }

        private void AddMenu2(GridView gr, GridViewMenu grm, bool isCreate)
        {
            if (!isCreate)
            {
                DXMenuItem menu = new DXMenuItem();
                menu.BeginGroup = true;
                menu.Caption = "Copy column";
                menu.Tag = DXMenuItemTag.CopyColumn.ToString();
                menu.Click += new EventHandler(menu234_Click);
                grm.Items.Add(menu);
            }
        }

        void menu234_Click(object sender, EventArgs e)
        {
            try
            {
                GridView gr = (GridView)this.DefaultView;
                if (pt != null)
                {
                    var hitInfo = gr.CalcHitInfo(pt);
                    GridColumn col = hitInfo.Column;
                    if (col != null)
                    {
                        string result = null;
                        int n = gr.RowCount;
                        for (int i = 0; i < gr.RowCount; i++)
                        {
                            if (gr.ViewRowHandleToDataSourceIndex(i) >= 0)
                            {
                                if (result != null) result += Environment.NewLine;
                                else result = "";
                                string s = gr.GetRowCellDisplayText(i, col);
                                result += s;
                            }
                        }
                        if (!string.IsNullOrEmpty(result)) Clipboard.SetText(result);
                    }
                }
            }
            catch (Exception) { }
        }

        void menu21_Click(object sender, EventArgs e)
        {
            GridView gr = (GridView)this.DefaultView;
            DXMenuCheckItem dx = (DXMenuCheckItem)sender;
            gr.OptionsView.ShowFooter = dx.Checked;
        }

        void menu2_Click(object sender, EventArgs e)
        {
            GridView gr = (GridView)this.DefaultView;
            DXMenuCheckItem dx = (DXMenuCheckItem)sender;
            if (dx.Checked)
            {
                gr.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            }
            else
            {
                gr.GroupFooterShowMode = GroupFooterShowMode.Hidden;
            }
        }

        void gridView_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            GridView gr = (GridView)sender;
            if (e.Menu == null) return;
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnPanel ||
                e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnEdge ||
                e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnFilterButton ||
                e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Column)
            {
                bool isExcel = false;
                foreach (DXMenuItem item in e.Menu.Items)
                {
                    if (item.Tag.ToString() == DXMenuItemTag.ExportExcel.ToString())
                    {
                        isExcel = true;
                        continue;
                    }
                }
                AddMenu(gr, e.Menu, isExcel);
                if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Column ||
                    e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnFilterButton)
                {
                    pt = e.Point;
                    AddMenu2(gr, e.Menu, isExcel);
                }
            }
            //else if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Column)
            //{
            //    bool isExcel = false;
            //    foreach (DXMenuItem item in e.Menu.Items)
            //    {
            //        if (item.Tag.ToString() == DXMenuItemTag.ExportExcel.ToString())
            //        {
            //            isExcel = true;
            //            continue;
            //        }
            //        switch ((GridStringId)item.Tag)
            //        {
            //            //case GridStringId.MenuColumnSortAscending:
            //            //    item.Caption = "Sắp xếp tăng dần";
            //            //    break;

            //            //case GridStringId.MenuColumnSortDescending:
            //            //    item.Caption = "Sắp xếp giảm dần";
            //            //    break;

            //            //case GridStringId.MenuColumnClearSorting:
            //            //    item.Caption = "Hủy bỏ sắp xếp";
            //            //    break;

            //            //case GridStringId.MenuColumnGroupBox:
            //            //    item.Caption = "Nhóm cột";
            //            //    break;

            //            //case GridStringId.MenuColumnRemoveColumn:
            //            //    item.Caption = "Xóa cột";
            //            //    break;

            //            //case GridStringId.MenuColumnColumnCustomization:
            //            //    item.Caption = "Tùy chỉnh cột";
            //            //    break;

            //            //case GridStringId.MenuColumnBestFit:
            //            //    item.Caption = "kéo giãn cột";
            //            //    break;

            //            //case GridStringId.MenuColumnBestFitAllColumns:
            //            //    item.Caption = "Tùy chỉnh cột";
            //            //    break;

            //            //case GridStringId.MenuColumnFilterEditor:
            //            //    item.Caption = "Tùy chỉnh cột";
            //            //    break;

            //            //case GridStringId.MenuColumnBestFitAllColumns:
            //            //    item.Caption = "Tùy chỉnh cột";
            //            //    break;

            //            default:
            //                //MessageBox.Show(item.Tag.ToString());
            //                break;
            //        }
            //    }
            //    AddMenu(gr, e.Menu, isExcel);
            //}
            //else if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Footer)
            //{
            //    foreach (DXMenuItem item in e.Menu.Items)
            //    {

            //        switch ((GridStringId)item.Tag)
            //        {
            //            case GridStringId.MenuFooterSum:
            //                //item.Caption = "Tính tổng";
            //                break;
            //            default:
            //                //MessageBox.Show(item.Tag.ToString());
            //                break;
            //        }
            //    }
            //}
            //else MessageBox.Show(e.HitInfo.HitTest.ToString());
        }
        //GridColumn ColumnClick = null;
        //int RowHandle = -1;
        //protected override void OnMouseDown(MouseEventArgs ev)
        //{
        //    base.OnMouseDown(ev);
        //    if (ev.Button == MouseButtons.Right)
        //    {
        //        GridView gr = (GridView)this.DefaultView;
        //        var hitInfo = gr.CalcHitInfo(ev.Location);
        //        if (hitInfo.InRowCell)
        //        {
        //            try
        //            {
        //                RowHandle = hitInfo.RowHandle;
        //                ColumnClick = hitInfo.Column;
        //            }
        //            catch (Exception)
        //            {

        //            }
        //        }
        //    }
        //}

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            try
            {
                if (e.Control && e.Shift && e.KeyCode == Keys.C)
                {
                    GridView gr = (GridView)this.DefaultView;
                    if (gr.GetFocusedValue() != null)
                    {
                        string str = gr.GetFocusedValue().ToString();
                        Clipboard.SetText(str);
                    }
                }
                else if (e.Control && e.KeyCode == Keys.C)
                {
                    GridView gr = (GridView)this.DefaultView;
                    Clipboard.SetText(gr.GetFocusedDisplayText());
                }
                else if (e.KeyCode == Keys.Insert)
                {
                    GridView gr = (GridView)this.DefaultView;
                    gr.CopyToClipboard();
                }
                else if ((e.KeyCode == Keys.F10) || (e.Control && e.KeyCode == Keys.F10))
                {
                    GridView gr = (GridView)this.DefaultView;
                    ShowModule(gr.FocusedColumn, gr);
                }
                else if (e.Control && e.Shift && e.KeyCode == Keys.D)
                {
                    GridView gr = (GridView)this.DefaultView;
                    Clipboard.SetText(gr.FocusedColumn.FieldName);
                }
            }
            catch (Exception) { }
        }

        protected virtual void GridView_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void menu_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = App.ExcelDialogFilter;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.ExportToXls(sfd.FileName);

                Process.Start(sfd.FileName);
            }
        }

        void gridView_GridMenuItemClick(object sender, GridMenuItemClickEventArgs e)
        {
            
        }

        protected virtual void InitGridViewColumns(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            gridView.Columns.Clear();
            InitDefaultGridViewColumns(gridView);

            //Add columns from databse to GridView
            AddColumnsToGridView(BOSDataSource, gridView);

            //Init column format
            InitColumnFormat(gridView);

            //Init GridControl Column visible index
            InitGridColumnsVisibleIndex(gridView);

        }

        protected virtual void InitDefaultGridViewColumns(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {

        }

        protected virtual void InitGridColumnsVisibleIndex(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            STFieldsInfo objSTFieldsInfo = GetAssociatedField();
            if (objSTFieldsInfo != null)
            {
                STFieldColumnsController objSTFieldColumnsController = new STFieldColumnsController();
                DataSet dsColumns = objSTFieldColumnsController.GetFieldColumnsByFieldID(objSTFieldsInfo.STFieldID);
                if (dsColumns.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                    {
                        STFieldColumnsInfo objSTFieldColumnsInfo = (STFieldColumnsInfo)objSTFieldColumnsController.GetObjectFromDataRow(rowColumn);
                        if (gridView.Columns[objSTFieldColumnsInfo.STFieldColumnFieldName] != null)
                        {
                            gridView.Columns[objSTFieldColumnsInfo.STFieldColumnFieldName].VisibleIndex = objSTFieldColumnsInfo.STFieldColumnVisibleIndex;
                            gridView.Columns[objSTFieldColumnsInfo.STFieldColumnFieldName].Width = objSTFieldColumnsInfo.STFieldColumnWidth;
                        }
                    }
                }
                else
                    InitDefaultGridColumnsVisibleIndex(gridView);
            }
            //Init Default Column visible index
            else
            {
                InitDefaultGridColumnsVisibleIndex(gridView);
            }
        }

        protected virtual void InitDefaultGridColumnsVisibleIndex(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {

        }

        #endregion
        #endregion

        #region Function for GridControl Event Handlers

        protected virtual void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        protected virtual void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        protected virtual void GridView_KeyUp(object sender, KeyEventArgs e)
        {

        }

        protected virtual void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            
        }

        protected virtual void GridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
 
        }

        protected virtual void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

        }

        protected virtual void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        protected void GridControl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        protected void GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl)sender;
            hitInfo = ((DevExpress.XtraGrid.Views.Grid.GridView)gridControl.ViewCollection[0]).CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.RowHandle < 0) hitInfo = null;
        }

        protected virtual object GetDataObject(object sender, IDataObject data, String strFieldName)
        {
            object[] objDrag = data.GetData(typeof(object[])) as object[];
            if (objDrag[0] is Int32 && objDrag[1] is DevExpress.XtraGrid.Views.Grid.GridView)
            {
                DevExpress.XtraGrid.Views.Grid.GridView gridView = objDrag[1] as DevExpress.XtraGrid.Views.Grid.GridView;
                return gridView.GetRowCellValue(Convert.ToInt32(objDrag[0]), strFieldName);
            }
            else
                return null;
        }

        protected virtual void GridControl_MouseMove(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl)sender;

            if (hitInfo == null)
                return;
            if (e.Button != MouseButtons.Left)
                return;
            Rectangle dragRect = new Rectangle(new Point(
            hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
            hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);

            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                if (hitInfo.InRowCell)
                {
                    gridControl.DoDragDrop(new object[] { hitInfo.RowHandle, gridControl.ViewCollection[0] }, DragDropEffects.All);
                }
            }
        }
        #endregion

        #region New Functions
        public static BOSGridControl Instance(String strInstanceName, String strModuleName)
        {
            if (!String.IsNullOrEmpty(strInstanceName))
            {
                Assembly BOSERPAssembly = Assembly.LoadFrom(Application.StartupPath + "\\BOSERP.exe");
                Type gridType = BOSERPAssembly.GetType("BOSERP.Modules." + strModuleName + "." + strInstanceName + "GridControl");
                if (gridType != null)
                {
                    return (BOSGridControl)gridType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                }
                else
                {
                    gridType = BOSERPAssembly.GetType("BOSERP." + strInstanceName + "GridControl");
                    if (gridType != null)
                        return (BOSGridControl)gridType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                    else
                        return new BOSGridControl();
                }
            }
            else
                return new BOSGridControl();
        }

        protected virtual DevExpress.XtraGrid.Columns.GridColumn InitGridColumn(String strTableName, int iVisibleIndex, String strFieldName, String strCaption, int iWidth)
        {
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Name = "col" + strFieldName;
            column.Caption = strCaption;
            column.FieldName = strFieldName;
            column.VisibleIndex = iVisibleIndex;
            column.Width = iWidth;
            return column;
        }

        protected virtual DevExpress.XtraGrid.Columns.GridColumn InitUnboundGridColumn(int iVisibleIndex, String strColumnName, String strColumnType, String strCaption, int iWidth)
        {
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Name = strColumnName;
            column.Caption = strCaption;
            column.FieldName = strColumnName;
            column.UnboundType = (DevExpress.Data.UnboundColumnType)Enum.Parse(typeof(DevExpress.Data.UnboundColumnType), strColumnType);
            column.VisibleIndex = iVisibleIndex;
            column.Width = iWidth;

            return column;
        }

        //protected virtual RepositoryItemLookUpEdit InitColumnLookupEdit(String strTableName, String strColumnName, string columnCaption)
        //{                        
        //    BOSDbUtil dbUtil = new BOSDbUtil();
        //    String lookupTableName = dbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
        //    RepositoryItemBOSLookupEdit rep = InitColumnLookupEdit(lookupTableName, columnCaption);
        //    return rep;
        //}

        protected virtual RepositoryItemBOSLookupEdit InitColumnLookupEdit(String strTableName, String strColumnName, string columnCaption)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String lookupTableName = dbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
            RepositoryItemBOSLookupEdit rep = InitColumnLookupEdit(lookupTableName, columnCaption);
            return rep;
        }


        protected virtual RepositoryItemBOSLookupEdit InitColumnLookupEdit(string lookupTableName, string columnCaption)
        {
            //[NUThao] [Improve Speed] [2014-09-09]
            if (!LookupTables.ContainsKey(lookupTableName))
            {
                GELookupTablesController lookupTableController = new GELookupTablesController();
                GELookupTablesInfo lookupTable = lookupTableController.GetObjectByTableName(lookupTableName);
                if (lookupTable != null)
                {
                    DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(lookupTableName);
                    LookupTables.Add(lookupTableName, ds);
                    LookupTablesUpdatedDate.Add(lookupTableName, DateTime.Now);
                    LookupTableObjects.Add(lookupTableName, lookupTable);
                }
            }
            //[NUThao] [Improve Speed] [2014-09-09]

            if (LookupTables[lookupTableName] == null)
            {
                return null;
            }            

            BOSDbUtil dbUtil = new BOSDbUtil();
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            rep.NullText = String.Empty;
            rep.BestFitMode = BestFitMode.BestFitResizePopup;            
            rep.Tag = lookupTableName;
            String strPrimaryColumn = dbUtil.GetTablePrimaryColumn(lookupTableName);
            String strDisplayColumn = GetLookupTableDisplayColumn(lookupTableName);
            rep.ValueMember = strPrimaryColumn;
            rep.DisplayMember = strDisplayColumn;
            rep.DataSource = ((DataSet)LookupTables[lookupTableName]).Tables[0];

            switch (lookupTableName)
            {
                case TableName.ICProductsTableName:
                    {
                        InitColumnsForItemLookupEdit(rep);
                    }
                    break;
                default:
                    {
                        LookUpColumnInfo colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                        colName.Caption = columnCaption;
                        colName.FieldName = rep.DisplayMember;
                        colName.Width = 100;
                        rep.Columns.Add(colName);
                    }
                    break;
            }

            rep.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);
            rep.Leave += new EventHandler(RepositoryItemBOSLookupEdit_Leave);
            rep.QueryCloseUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryCloseUp);
            rep.KeyDown += new KeyEventHandler(rep_KeyDown);
            return rep;
        }

        void rep_KeyDown(object sender, KeyEventArgs e)
        {
            //OnKeyDown(e);
            if ((e.KeyCode == Keys.F10) || (e.Control && e.KeyCode == Keys.F10))
            {
                GridView gr = (GridView)this.DefaultView;
                ShowModule(gr.FocusedColumn, gr);
            }
        }

        //private void InitColumnsForItemLookupEdit(RepositoryItemLookUpEdit rep)
        //{
        //    LookUpColumnInfo col = new LookUpColumnInfo();
        //    col.Caption = ComponentLocalizedResources.ICProductNo;
        //    col.FieldName = "ICProductNo";
        //    rep.Columns.Add(col);            

        //    col = new LookUpColumnInfo();
        //    col.Caption = ComponentLocalizedResources.ICProductSupplierNumber;
        //    col.FieldName = "ICProductSupplierNumber";
        //    rep.Columns.Add(col);

        //    col = new LookUpColumnInfo();
        //    col.Caption = ComponentLocalizedResources.ICProductDesc;
        //    col.FieldName = "ICProductDesc";
        //    rep.Columns.Add(col);

        //    col = new LookUpColumnInfo();
        //    col.Caption = ComponentLocalizedResources.ICProductAttribute;
        //    col.FieldName = "ICProductAttribute";
        //    rep.Columns.Add(col);
        //}

        private void InitColumnsForItemLookupEdit(RepositoryItemBOSLookupEdit rep)
        {
            LookUpColumnInfo col = new LookUpColumnInfo();
            col.Caption = ComponentLocalizedResources.ICProductNo;
            col.FieldName = "ICProductNo";
            rep.Columns.Add(col);

            col = new LookUpColumnInfo();
            col.Caption = ComponentLocalizedResources.ICProductSupplierNumber;
            col.FieldName = "ICProductSupplierNumber";
            rep.Columns.Add(col);

            col = new LookUpColumnInfo();
            col.Caption = ComponentLocalizedResources.ICProductDesc;
            col.FieldName = "ICProductDesc";
            rep.Columns.Add(col);

            col = new LookUpColumnInfo();
            col.Caption = ComponentLocalizedResources.ICProductAttribute;
            col.FieldName = "ICProductAttribute";
            rep.Columns.Add(col);
        }

        private void RepositoryItemBOSLookupEdit_Leave(object sender, EventArgs e)
        {
            //Reset filter
            BOSLookupEdit rep = (BOSLookupEdit)sender;
            object dataSource = rep.Properties.DataSource;
            rep.Properties.DataSource = null;
            rep.Properties.DataSource = dataSource;
        }

        protected virtual String GetLookupTableDisplayColumn(String strLookupTableName)
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                //Get GELookupTableDisplayColumn from GELookupTables            
                GELookupTablesInfo objLookupTablesInfo = null;
                if (LookupTableObjects.ContainsKey(strLookupTableName))
                {
                    objLookupTablesInfo = LookupTableObjects[strLookupTableName];
                }
                //[NUThao] [Improve Speed] [2014-09-09]
                else
                {
                    GELookupTablesController objGELookupTablesController = new GELookupTablesController();
                    objLookupTablesInfo = objGELookupTablesController.GetObjectByTableName(strLookupTableName);
                    LookupTableObjects.Add(strLookupTableName, objLookupTablesInfo);
                }
                //[NUThao] [Improve Speed] [2014-09-09]
                if (objLookupTablesInfo != null && !String.IsNullOrEmpty(objLookupTablesInfo.GELookupTableDisplayColumn))
                    return objLookupTablesInfo.GELookupTableDisplayColumn;

                //If not exist, get default display column            
                String strPrimaryColumn = dbUtil.GetTablePrimaryColumn(strLookupTableName);
                String prefix = strPrimaryColumn.Substring(0, strPrimaryColumn.Length - 2);
                if (dbUtil.ColumnIsExist(strLookupTableName, prefix + "Name"))
                    return prefix + "Name";
                else if (dbUtil.ColumnIsExist(strLookupTableName, prefix + "No"))
                    return prefix + "No";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        protected virtual void RepositoryItemLookupEdit_QueryPopup(object sender, CancelEventArgs e)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            LookUpEdit lke = (LookUpEdit)sender;
            string strLookupTable = lke.Properties.Tag.ToString();
            DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(strLookupTable);
            DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(strLookupTable);

            if (dtLastCreatedDate.CompareTo(((DateTime)LookupTablesUpdatedDate[strLookupTable])) > 0 ||
                dtLastUpdatedDate.CompareTo(((DateTime)LookupTablesUpdatedDate[strLookupTable])) > 0)
            {
                //Refesh Data Source
                BaseBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (objLookupTableController != null)
                {
                    DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(strLookupTable);
                    if (ds.Tables.Count > 0)
                    {
                        // Update Last Updated Date of Lookup Table
                        LookupTablesUpdatedDate[strLookupTable] = DateTime.Now;
                        ((DataSet)LookupTables[strLookupTable]).Tables.Clear();
                        ((DataSet)LookupTables[strLookupTable]).Tables.Add(ds.Tables[0].Copy());
                    }
                }
            }

            DataTable dataSource = ((DataSet)LookupTables[strLookupTable]).Tables[0];
            if (dataSource.Rows.Count == 0 || Convert.ToInt32(dataSource.Rows[0][lke.Properties.ValueMember]) != 0)
            {
                DataRow row = dataSource.NewRow();
                row[lke.Properties.ValueMember] = 0;
                dataSource.Rows.InsertAt(row, 0);                
            }
            lke.Properties.DataSource = dataSource;
        }

        protected virtual void RepositoryItemLookupEdit_QueryCloseUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            DataTable dataSource = (DataTable)lke.Properties.DataSource;
            if (dataSource.Rows.Count > 0)
            {
                dataSource.Rows.RemoveAt(0);
            }
        }

        protected virtual DevExpress.XtraEditors.Repository.RepositoryItemTextEdit InitColumnAmountTextEdit(int iDecimal)
        {
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            repItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repItemTextEdit.Mask.EditMask = String.Format("f{0}", iDecimal.ToString());
            repItemTextEdit.Mask.UseMaskAsDisplayFormat = true;

            return repItemTextEdit;
        }

        protected virtual void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {                        
            //Add bound columns
            BOSDbUtil dbUtil = new BOSDbUtil();
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            int userGroupID = ((IBaseModuleERP)Screen.Module).GetCurrentUserGroupID();
            DataSet dsColumns = objAAColumnAliasController.GetDisplayedColumnsByModuleNameAndTableNameAndUserGroupID(Screen.Module.Name, strTableName, userGroupID);
            if (dsColumns.Tables.Count > 0)
            {
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    if (objAAColumnAliasInfo != null)
                    {
                        if (gridView.Columns.ColumnByFieldName(objAAColumnAliasInfo.AAColumnAliasName) == null)
                        {
                            DevExpress.XtraGrid.Columns.GridColumn column = InitGridColumn(strTableName, -1, objAAColumnAliasInfo.AAColumnAliasName, objAAColumnAliasInfo.AAColumnAliasCaption, 50);
                            //Init RepositoryLookupEdit to grid column
                            if (dbUtil.IsForeignKey(strTableName, objAAColumnAliasInfo.AAColumnAliasName))
                            {
                                //DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookupEdit = InitColumnLookupEdit(strTableName, objAAColumnAliasInfo.AAColumnAliasName, objAAColumnAliasInfo.AAColumnAliasCaption);
                                RepositoryItemBOSLookupEdit repLookupEdit = InitColumnLookupEdit(strTableName, objAAColumnAliasInfo.AAColumnAliasName, objAAColumnAliasInfo.AAColumnAliasCaption);
                                if (repLookupEdit != null)
                                {
                                    column.ColumnEdit = repLookupEdit;
                                }
                            }
                            else
                            {
                                String strConfigValueTable = String.Empty;

                                if (objAAColumnAliasInfo.AAColumnAliasName.EndsWith("Combo"))
                                    strConfigValueTable = objAAColumnAliasInfo.AAColumnAliasName.Substring(2, objAAColumnAliasInfo.AAColumnAliasName.Length - 7);
                                else
                                    strConfigValueTable = objAAColumnAliasInfo.AAColumnAliasName.Substring(2, objAAColumnAliasInfo.AAColumnAliasName.Length - 2);

                                if (ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable] != null)
                                {
                                    //RepositoryItemLookUpEdit rep = rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable]);
                                    RepositoryItemBOSLookupEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable]);
                                    column.ColumnEdit = rep;
                                }
                                else if (objAAColumnAliasInfo.AAColumnAliasName.Contains("MatchCode"))
                                {
                                    //RepositoryItemLookUpEdit repLookupEdit = new RepositoryItemLookUpEdit();
                                    RepositoryItemBOSLookupEdit repLookupEdit = new RepositoryItemBOSLookupEdit();
                                    ADMatchCodesController objMatchCodesController = new ADMatchCodesController();
                                    DataSet ds = objMatchCodesController.GetADMatchCodesByADMatchCodeColumnName(objAAColumnAliasInfo.AAColumnAliasName);
                                    if (ds.Tables.Count > 0)
                                    {
                                        repLookupEdit.DataSource = ds.Tables[0];
                                    }
                                    repLookupEdit.ValueMember = "ADMatchCodeValue";
                                    repLookupEdit.DisplayMember = "ADMatchCodeValue";
                                    repLookupEdit.ShowHeader = false;
                                    repLookupEdit.TextEditStyle = TextEditStyles.Standard;
                                    LookUpColumnInfo repColumn = new LookUpColumnInfo();
                                    repColumn.FieldName = "ADMatchCodeValue";
                                    repColumn.Width = 100;
                                    repLookupEdit.Columns.Add(repColumn);
                                    repLookupEdit.PopupWidth = repColumn.Width;
                                    column.ColumnEdit = repLookupEdit;
                                }
                                else
                                {
                                    //Init column repository based on field format group
                                    column.ColumnEdit = InitColumnRepositoryFromFieldFormatGroup(strTableName, objAAColumnAliasInfo.AAColumnAliasName);
                                }
                            }                           
                            column.OptionsColumn.AllowEdit = false;
                            gridView.Columns.Add(column);
                        }
                        else
                        {
                            gridView.Columns[objAAColumnAliasInfo.AAColumnAliasName].Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Init repository to display config values
        /// </summary>
        /// <param name="dataSource">Data source of config values</param>
        /// <returns>Repository item</returns>
        //protected RepositoryItemLookUpEdit InitRepositoryForConfigValues(DataTable dataSource)
        //{
        //    RepositoryItemLookUpEdit repLookupEdit = new RepositoryItemLookUpEdit();
        //    repLookupEdit.DataSource = dataSource;
        //    repLookupEdit.ValueMember = "Value";
        //    repLookupEdit.DisplayMember = "Text";
        //    repLookupEdit.ShowHeader = false;
        //    repLookupEdit.TextEditStyle = TextEditStyles.Standard;
        //    DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
        //    repColumn.FieldName = "Text";
        //    repColumn.Width = 100;
        //    repLookupEdit.Columns.Add(repColumn);
        //    repLookupEdit.PopupWidth = repColumn.Width;
        //    return repLookupEdit;
        //}

        protected RepositoryItemBOSLookupEdit InitRepositoryForConfigValues(DataTable dataSource)
        {
            RepositoryItemBOSLookupEdit repLookupEdit = new RepositoryItemBOSLookupEdit();
            repLookupEdit.DataSource = dataSource;
            repLookupEdit.ValueMember = "Value";
            repLookupEdit.DisplayMember = "Text";
            repLookupEdit.ShowHeader = false;
            repLookupEdit.TextEditStyle = TextEditStyles.Standard;
            DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            repColumn.FieldName = "Text";
            repColumn.Width = 100;
            repLookupEdit.Columns.Add(repColumn);
            repLookupEdit.PopupWidth = repColumn.Width;
            return repLookupEdit;
        }

        /// <summary>
        /// Init format of all columns
        /// </summary>
        protected virtual void InitColumnFormat(GridView gridView)
        {
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.ColumnEdit != null)
                    InitColumnRepositoryFormat(column, BOSDataSource, column.FieldName);
                else
                {
                    Type type = BOSUtil.GetColumnDataType(BOSDataSource, column.FieldName);
                    if (type == typeof(DateTime))
                        column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemDateEdit.ToString());
                    else if (type == typeof(bool))
                        column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemCheckEdit.ToString());
                    else
                        column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemTextEdit.ToString());
                    InitColumnRepositoryFormat(column, BOSDataSource, column.FieldName);
                }
            }
        }
        
        /// <summary>
        /// Initialize column summary
        /// </summary>
        /// <param name="fieldName">Field name to specify the column</param>
        /// <param name="summaryType">Summary type</param>
        /// <param name="textPrefix">Text will be prefixed to summary value</param>
        public virtual void InitColumnSummary(String fieldName, SummaryItemType summaryType, String textPrefix)
        {
            GridView gridView = (GridView)ViewCollection[0];
            DevExpress.XtraGrid.Columns.GridColumn col = gridView.Columns[fieldName];
            if (col != null)
            {
                col.SummaryItem.FieldName = fieldName;
                col.SummaryItem.SummaryType = summaryType;
                                                
                STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Screen.Module.GetColumnFormat(BOSDataSource, fieldName);
                if (objFieldFormatGroupsInfo != null)
                {
                    col.SummaryItem.DisplayFormat = String.Format("{0}{1}", textPrefix, "{0:" + objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit + "}");
                }
                else
                {
                    col.SummaryItem.DisplayFormat = String.Format("{0}{1}", textPrefix, "{0:n2}");
                }
            }
        }

        /// <summary>
        /// Initialize column summary
        /// </summary>
        /// <param name="fieldName">Field name to specify the column</param>
        /// <param name="summaryType">Summary type</param>        
        public virtual void InitColumnSummary(String fieldName, SummaryItemType summaryType)
        {
            InitColumnSummary(fieldName, summaryType, String.Empty);
        }
              
        /// <summary>
        /// Init format of a specific column repository
        /// </summary>
        public void InitColumnRepositoryFormat(DevExpress.XtraGrid.Columns.GridColumn column, String strTableName, String strColumnName)
        {
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Screen.Module.GetColumnFormat(strTableName, strColumnName);
            if (objFieldFormatGroupsInfo != null)
            {
                DevExpress.XtraEditors.Repository.RepositoryItem rep = column.ColumnEdit;
                if (objFieldFormatGroupsInfo.STFieldFormatGroupBackColor > 0)
                {
                    rep.Appearance.BackColor = Color.FromArgb(objFieldFormatGroupsInfo.STFieldFormatGroupBackColor);
                    rep.Appearance.Options.UseBackColor = true;
                }
                if (objFieldFormatGroupsInfo.STFieldFormatGroupForeColor > 0)
                {
                    rep.Appearance.ForeColor = Color.FromArgb(objFieldFormatGroupsInfo.STFieldFormatGroupForeColor);
                    rep.Appearance.Options.UseForeColor = true;
                }

                String strDefaultFontName = "Tahoma";
                float fDefaultFontSize = 8.25F;
                if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFontName))
                    strDefaultFontName = objFieldFormatGroupsInfo.STFieldFormatGroupFontName;
                if (objFieldFormatGroupsInfo.STFieldFormatGroupFontSize > 0)
                    fDefaultFontSize = objFieldFormatGroupsInfo.STFieldFormatGroupFontSize;
                rep.Appearance.Font = new Font(strDefaultFontName, fDefaultFontSize);
                rep.Appearance.Options.UseFont = true;

                if (BOSUtil.IsEditRepository(rep))
                {
                    DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText = (DevExpress.XtraEditors.Repository.RepositoryItemTextEdit)rep;
                    if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupMaskType))
                    {
                        repText.Mask.MaskType = BOSUtil.GetMaskTypeFromText(objFieldFormatGroupsInfo.STFieldFormatGroupMaskType);
                        repText.Mask.EditMask = objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit;
                        repText.Mask.UseMaskAsDisplayFormat = true;
                    }
                    if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFormatType))
                    {
                        repText.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(objFieldFormatGroupsInfo.STFieldFormatGroupFormatType);
                        repText.DisplayFormat.FormatString = objFieldFormatGroupsInfo.STFieldFormatGroupFormatString;
                    }
                }
            }
        }

        public DevExpress.XtraEditors.Repository.RepositoryItem InitColumnRepositoryFromFieldFormatGroup(String strTableName, String strColumnName)
        {
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Screen.Module.GetColumnFormat(strTableName, strColumnName);
            if (objFieldFormatGroupsInfo != null)
            {
                if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupRepository))
                {
                    return BOSUtil.GetRepositoryItemFromText(objFieldFormatGroupsInfo.STFieldFormatGroupRepository);
                }
            }
            return null;
        }        
        #endregion

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
        /// <summary>
        /// Customize columns of BOSGridControl
        /// </summary>        
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void NavigatorButton_Click(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.Tag != null)
            {
                if (e.Button.Tag.ToString() == "CustomizeColumn")
                    CustomizeColumnGridControl();
                else
                    if (e.Button.Tag.ToString() == "SaveColumnCustomization")
                        SaveCustomizeColumnGridControl();
            }
        }

        /// <summary>
        /// Customize Column grid Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>
        /// <BOSparam name="GridControlName" type="String"></BOSparam>
        private void CustomizeColumnGridControl()
        {
            ((DevExpress.XtraGrid.Views.Grid.GridView)this.MainView).ColumnsCustomization();
        }

        /// <summary>
        /// Save customize columns of BOSGridControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>
        /// <BOSparam name="GridControlName" type="String"></BOSparam>
        private void SaveCustomizeColumnGridControl()
        {
            STFieldsInfo objSTFieldsInfo = GetAssociatedField();
            if (objSTFieldsInfo == null)
            {
                objSTFieldsInfo = new STFieldsInfo();
                objSTFieldsInfo.STFieldName = this.Name;
                objSTFieldsInfo.STFieldGroup = BOSScreen.cstFieldGroupSearch;
                objSTFieldsInfo.STScreenID = 0;
                objSTFieldsInfo.STFieldDataSource = BOSDataSource;
                new STFieldsController().CreateObject(objSTFieldsInfo);
            }

            if (objSTFieldsInfo != null)
            {
                STFieldColumnsController objSTFieldColumnsController = new STFieldColumnsController();
                objSTFieldColumnsController.DeleteByForeignColumn("STFieldID", objSTFieldsInfo.STFieldID);

                foreach (DevExpress.XtraGrid.Columns.GridColumn GridColumn in ((DevExpress.XtraGrid.Views.Grid.GridView)(this.ViewCollection[0])).Columns)
                {
                    if (GridColumn.Visible)
                    {
                        STFieldColumnsInfo objSTFieldColumnsInfo = new STFieldColumnsInfo();
                        objSTFieldColumnsInfo.STFieldID = objSTFieldsInfo.STFieldID;
                        objSTFieldColumnsInfo.STFieldColumnFieldName = GridColumn.FieldName;
                        objSTFieldColumnsInfo.STFieldColumnName = GridColumn.Name;
                        objSTFieldColumnsInfo.STFieldColumnCaption = GridColumn.Caption;
                        objSTFieldColumnsInfo.STFieldColumnWidth = GridColumn.Width;
                        objSTFieldColumnsInfo.STFieldColumnVisibleIndex = GridColumn.VisibleIndex;

                        objSTFieldColumnsController.CreateObject(objSTFieldColumnsInfo);
                    }
                }
                MessageBox.Show(ComponentLocalizedResources.SaveSuccessfully, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Invalidate lookup edit columns to reflect all changes of lookup table
        /// </summary>
        public virtual void InvalidateLookupEditColumns()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                if (column.ColumnEdit != null && (column.ColumnEdit is DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ||
                                                    column.ColumnEdit is RepositoryItemBOSLookupEdit))
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    
                    //DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rep = (DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)column.ColumnEdit;
                    //if(column.ColumnEdit is RepositoryItemBOSLookupEdit)
                     RepositoryItemBOSLookupEdit   rep = (RepositoryItemBOSLookupEdit)column.ColumnEdit;

                    String strLookupTable = dbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(BOSDataSource, column.FieldName);
                    if (!string.IsNullOrEmpty(strLookupTable))
                    {
                        //Update lookup table if there is any changes to it
                        DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(strLookupTable);
                        DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(strLookupTable);
                        if (dtLastCreatedDate.CompareTo(((DateTime)LookupTablesUpdatedDate[strLookupTable])) > 0 ||
                            dtLastUpdatedDate.CompareTo(((DateTime)LookupTablesUpdatedDate[strLookupTable])) > 0)
                        {
                            //Refesh Data Source
                            BaseBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                            if (objLookupTableController != null)
                            {
                                DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(strLookupTable);
                                if (ds.Tables.Count > 0)
                                {
                                    // Update Last Updated Date of Lookup Table
                                    LookupTablesUpdatedDate[strLookupTable] = DateTime.Now;
                                    ((DataSet)LookupTables[strLookupTable]).Tables.Clear();
                                    ((DataSet)LookupTables[strLookupTable]).Tables.Add(ds.Tables[0].Copy());
                                }
                            }
                        }

                        rep.DataSource = ((DataSet)LookupTables[strLookupTable]).Tables[0];
                    }
                }
            }
        }

        protected virtual void GridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (!gridView.IsValidRowHandle(e.RowHandle))
                return;
            int parent = gridView.GetParentRowHandle(e.RowHandle);
            if (gridView.IsGroupRow(parent))
            {
                for (int i = 0; i < gridView.GetChildRowCount(parent); i++)
                    if (gridView.GetChildRowHandle(parent, i) == e.RowHandle)
                        e.Appearance.BackColor = i % 2 == 0 ? Color.White : Color.WhiteSmoke;
            }
            else e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.White : Color.WhiteSmoke;
            e.Appearance.ForeColor = Color.Black;           
        }

        /// <summary>
        /// Get the field associating with the control
        /// </summary>
        /// <return>Field object</return>
        private STFieldsInfo GetAssociatedField()
        {
            STFieldsController objFieldsController = new STFieldsController();
            STFieldsInfo objSTFieldsInfo = null;
            if (Screen.Fields.ContainsKey(Name))
            {
                objSTFieldsInfo = Screen.Fields[Name];
            }
            if (objSTFieldsInfo == null)
            {
                objSTFieldsInfo = objFieldsController.GetFieldBySTModuleIDAndSTUserGroupIDAndSTFieldName(Screen.Module.ModuleID, UserGroup.Admin, Name);
                if (objSTFieldsInfo == null)
                {
                    //The grid control is generated by code behind and used for search screen
                    objSTFieldsInfo = objFieldsController.GetFieldByFieldNameAndFieldGroup(this.Name, BOSScreen.cstFieldGroupSearch);
                }
            }
            return objSTFieldsInfo;
        }
    }
}

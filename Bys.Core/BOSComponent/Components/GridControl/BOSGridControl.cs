using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
//using BOSERP;

namespace BOSComponent
{
    public class BOSGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "BOSGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new BOSGridView(grid as GridControl); }
    }

    public class BOSGridView : GridView
    {

        public BOSGridView()
            : this(null)
        {
            //this.CustomUnboundColumnData += BOSGridView_CustomUnboundColumnData;
        }
        public BOSGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

        protected override string ViewName { get { return "BOSGridView"; } }

        protected override DevExpress.Data.Filtering.CriteriaOperator CreateAutoFilterCriterion(
            DevExpress.XtraGrid.Columns.GridColumn column,
            DevExpress.XtraGrid.Columns.AutoFilterCondition condition, object _value, string strVal)
        {
            if (column.ColumnType == typeof(DateTime) && strVal.Length > 0)
            {
                BinaryOperatorType type = BinaryOperatorType.Equal;
                string operand = string.Empty;
                if (strVal.Length > 1)
                {
                    operand = strVal.Substring(0, 2);
                    if (operand.Equals(">="))
                        type = BinaryOperatorType.GreaterOrEqual;
                    else if (operand.Equals("<="))
                        type = BinaryOperatorType.LessOrEqual;
                }
                if (type == BinaryOperatorType.Equal)
                {
                    operand = strVal.Substring(0, 1);
                    if (operand.Equals(">"))
                        type = BinaryOperatorType.Greater;
                    else if (operand.Equals("<"))
                        type = BinaryOperatorType.Less;
                }
                if (type != BinaryOperatorType.Equal)
                {

                    string val = strVal.Replace(operand, string.Empty);
                    try
                    {
                        DateTime dt = DateTime.ParseExact(val, "d", column.RealColumnEdit.EditFormat.Format);
                        return new BinaryOperator(column.FieldName, dt, type);
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            else if (column.ColumnType == typeof(String) && strVal.Length > 0)
            {
                CriteriaOperator op = null;
                String[] words = strVal.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    String word = BOSUtil.GetSearchString(words[i].Replace("'", "''"));
                    word = String.Format("%{0}%", word);
                    op = GroupOperator.And(op, new BinaryOperator(column.FieldName, word, BinaryOperatorType.Like));
                }

                return op;

            }
            return base.CreateAutoFilterCriterion(column, condition, _value, strVal);
        }

    }
    public partial class BOSGridControl : DevExpress.XtraGrid.GridControl, ICloneable, IBOSControl
    {
        protected override BaseView CreateDefaultView()
        {
            //BOSGridView view = CreateView("BOSGridView") as BOSGridView;
            //return view;
            return CreateView("BOSGridView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new BOSGridViewInfoRegistrator());
        }
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
        protected SortedList IntLookupTablesUpdatedDate;
        protected SortedList<string, GELookupTablesInfo> LookupTableObjects;
        protected List<GELookupTablesInfo> LookupTableList;
        // protected SortedList FieldFormatGroups;
        //protected List<STFieldFormatGroupsInfo> FieldFormatList;
        protected List<STFieldsInfo> FieldList;
        //protected List<STFieldPermissionsInfo> LstFieldPermission;
        protected SortedList LstFieldColumnPermissions;
        protected List<AAColumnAliasInfo> LstColumnAlias;
        protected List<STFieldColumnsInfo> LstFieldColumn;
        private string _commodityType = string.Empty;
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

        public string CommodityType
        {
            get
            {
                return _commodityType;
            }
            set
            {
                if (_commodityType != value)
                {
                    _commodityType = value;
                    ChangeGridColumnsVisibleIndex();
                }
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
        private void InitCommonData()
        {
            LookupTables = ((IBaseModuleERP)Screen.Module).GetLookupTableCollection();
            LookupTablesUpdatedDate = ((IBaseModuleERP)Screen.Module).GetLookupTableUpdatedDateCollection();
            IntLookupTablesUpdatedDate = new SortedList();
            LookupTableObjects = ((IBaseModuleERP)Screen.Module).GetLookupTableObjects();
            LookupTableList = ((IBaseModuleERP)Screen.Module).GetLookupTableList();
            LstFieldColumnPermissions = ((IBaseModuleERP)Screen.Module).GetSystemFieldColumnPermissions();
            LstColumnAlias = ((IBaseModuleERP)Screen.Module).GetSystemAlias();
            FieldList = ((IBaseModuleERP)Screen.Module).GetSystemFields();
            LstFieldColumn = ((IBaseModuleERP)Screen.Module).GetSystemFieldColumns();
        }
        private void DisposeCommonData()
        {
            foreach (var item in LookupTables.Keys)
            {
                ((DataSet)LookupTables[item]).Dispose();
            }
        }
        /// <summary>
        /// Initialize grid control including view, columns, data source and events
        /// </summary>        
        public virtual void InitializeControl()
        {
            InitCommonData();
            //Init Common Properties for GridControl Control
            InitializeCommonProperties();

            //Init GridControl View and columns     
            DevExpress.XtraGrid.Views.Grid.GridView gridView = InitializeGridView();
            //this.MainView = gridView;
            BOSGridView mainView = (BOSGridView)gridView;
            this.MainView = mainView;

            //Init DataSource
            InitGridControlDataSource();

            //Using embedded Navigator
            this.UseEmbeddedNavigator = true;
            
            List<NavigatorCustomButton> btnList = new List<NavigatorCustomButton>();
            //this.EmbeddedNavigator.Name = "navigator_" + this.Name;
            if (BOSLib.BysGateway.CurrentUsersInfo.ADUserIsCustomizeColumn)
            {
                NavigatorCustomButton customizeColumnButton = new NavigatorCustomButton(8, ComponentLocalizedResources.CustomizeColumn);
                customizeColumnButton.Tag = "CustomizeColumn";
                btnList.Add(customizeColumnButton);
            }

            NavigatorCustomButton btnSaveColumnCustomization = new NavigatorCustomButton(9, ComponentLocalizedResources.SaveColumnCustomization);
            btnSaveColumnCustomization.Tag = "SaveColumnCustomization";
            btnList.Add(btnSaveColumnCustomization);

            NavigatorCustomButton recoveryDefaultColumn = new NavigatorCustomButton(10, ComponentLocalizedResources.RecoveryDefaultColumn);
            recoveryDefaultColumn.Tag = "RecoveryDefaultColumn";
            btnList.Add(recoveryDefaultColumn);
            if (this.EmbeddedNavigator.Buttons.CustomButtons != null && this.EmbeddedNavigator.Buttons.CustomButtons.Count == 0)
            {
                this.EmbeddedNavigator.Buttons.CustomButtons.AddRange(btnList.ToArray());
                this.EmbeddedNavigator.Buttons.Edit.Visible = false;
                this.EmbeddedNavigator.Buttons.Remove.Visible = false;
                this.EmbeddedNavigator.Buttons.Append.Visible = false;
                this.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
                this.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
                //Add events to navigator buttons
                this.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(NavigatorButton_Click);
            }
            this.KeyUp += new KeyEventHandler(((IBaseModuleERP)Screen.Module).Control_KeyUp);
            gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(GridView_ValidateRow);
            DisposeCommonData();
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
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsBehavior.AutoSelectAllInEditor = true;
            gridView.OptionsNavigation.EnterMoveNextColumn = true;
            gridView.OptionsNavigation.UseTabKey = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;

            gridView.OptionsCustomization.AllowFilter = true;
            gridView.OptionsCustomization.AllowQuickHideColumns = true;
            gridView.OptionsCustomization.AllowColumnResizing = true;

            gridView.GridControl = this;
            InitGridViewColumns(gridView);
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
                gridView.ShownEditor += new EventHandler(gridView_ShownEditor);
                gridView.PopupMenuShowing += new PopupMenuShowingEventHandler(gridView_PopupMenuShowing);
                gridView.CustomSummaryExists += new CustomSummaryExistEventHandler(gridView_CustomSummaryExists);
            }
            catch (Exception)
            {
            }
            //gridView.GridMenuItemClick += new GridMenuItemClickEventHandler(gridView_GridMenuItemClick);
            //gridView.ShowGridMenu += new GridMenuEventHandler(gridView_ShowGridMenu);
            //gridView.GroupPanelText = "Kéo một cột vào đây để nhóm";
            InvalidateLookupEditColumns();
            return gridView;
        }

        private void gridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView gr = (GridView)sender;
            if (e.Menu == null || e.HitInfo.HitTest != GridHitTest.ColumnPanel && e.HitInfo.HitTest != GridHitTest.ColumnEdge && e.HitInfo.HitTest != GridHitTest.ColumnFilterButton && e.HitInfo.HitTest != GridHitTest.Column)
                return;

            bool isCreate = false;
            foreach (DXMenuItem dxMenuItem in (CollectionBase)e.Menu.Items)
            {
                if (dxMenuItem.Caption == GridLocalizer.Active.GetLocalizedString(GridStringId.MenuColumnColumnCustomization)
                    || dxMenuItem.Caption == GridLocalizer.Active.GetLocalizedString(GridStringId.MenuColumnRemoveColumn))
                    dxMenuItem.Visible = false;

                if (dxMenuItem.Tag.ToString() == BOSGridControl.DXMenuItemTag.ExportExcel.ToString())
                    isCreate = true;
            }
            this.AddMenu(gr, e.Menu, isCreate);
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Column ||
                    e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnFilterButton)
            {
                pt = e.Point;
                this.AddMenuCopy(gr, e.Menu, isCreate);
            }
        }
        private void AddMenuCopy(GridView gr, GridViewMenu grm, bool isCreate)
        {
            if (!isCreate)
            {
                DXMenuItem menu = new DXMenuItem();
                menu.BeginGroup = true;
                menu.Caption = "Copy column";
                menu.Tag = DXMenuItemTag.CopyColumn.ToString();
                menu.Click += new EventHandler(menu234_Click);
                grm.Items.Add(menu);

                menu = new DXMenuItem();
                menu.BeginGroup = true;
                menu.Caption = "Paste column";
                menu.Tag = DXMenuItemTag.CopyColumn.ToString();
                menu.Click += new EventHandler(PassColum_Click);
                grm.Items.Add(menu);
            }
        }

        private DXMenuItem GetItemByStringId(DXPopupMenu menu, GridStringId id)
        {
            foreach (DXMenuItem item in menu.Items)
                if (item.Caption == GridLocalizer.Active.GetLocalizedString(id))
                    return item;
            return null;
        }

        protected virtual void GridControl_MouseMove(object sender, MouseEventArgs e)
        {
            GridControl gridControl = (GridControl)sender;
            if (this.hitInfo == null || e.Button != MouseButtons.Left || (new Rectangle(new Point(this.hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2, this.hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize).Contains(new Point(e.X, e.Y)) || !this.hitInfo.InRowCell))
                return;

            int num = (int)gridControl.DoDragDrop((object)new object[2]
            {
                (object) this.hitInfo.RowHandle,
                (object) gridControl.ViewCollection[0]
            }, DragDropEffects.All);
        }

        protected virtual void GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.hitInfo = ((GridView)((GridControl)sender).ViewCollection[0]).CalcHitInfo(new Point(e.X, e.Y));
            if (this.hitInfo.RowHandle >= 0)
                return;

            this.hitInfo = (GridHitInfo)null;
        }

        void gridView_ShownEditor(object sender, EventArgs e)
        {
            TextEdit edit = ((GridView)sender).ActiveEditor as TextEdit;
            if (edit != null)
            {
                edit.VisibleChanged += new EventHandler(edit_VisibleChanged);
                edit.Spin += new SpinEventHandler(edit_Spin);
                //edit.SelectionLength = edit.Text.Length;
                edit.SelectAll();
                //edit.SelectionStart = edit.Text.Length;
            }
        }

        void edit_VisibleChanged(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            if (!edit.Visible)
            {
                edit.VisibleChanged -= new EventHandler(edit_VisibleChanged);
                edit.Spin -= new SpinEventHandler(edit_Spin);
                edit.SelectAll();
                //edit.SelectionStart = edit.Text.Length;
            }
        }

        void edit_Spin(object sender, SpinEventArgs e)
        {
            if (!(sender is BOSComponent.BOSLookupEdit) && !(sender is DevExpress.XtraEditors.LookUpEdit))
            {
                e.Handled = true;
                gridView1.TopRowIndex += e.IsSpinUp ? -3 : 3;
            }
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
                                IBusinessController controller = BusinessControllerFactory.GetBusinessController(table + "Controller");
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
            AutoFilter,
            PassColumn
        }

        private void AddMenu(GridView gr, GridViewMenu grm, bool isCreate)
        {
            if (!isCreate)
            {
                DXMenuItem menu = null;
                if (BOSLib.BysGateway.CurrentUsersInfo.ADUserIsCustomizeColumn)
                {
                    menu = new DXMenuItem();
                    menu.BeginGroup = true;
                    menu.Caption = "Export to Excel";
                    menu.Tag = DXMenuItemTag.ExportExcel.ToString();
                    menu.Click += new EventHandler(excel_Click);
                    grm.Items.Add(menu);
                }
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

        private void menu234_Click(object sender, EventArgs e)
        {
            try
            {
                GridView defaultView = (GridView)this.DefaultView;
                GridColumn column = defaultView.CalcHitInfo(this.pt).Column;
                if (column == null)
                    return;
                string text = (string)null;
                int rowCount = defaultView.RowCount;
                for (int rowHandle = 0; rowHandle < defaultView.RowCount; ++rowHandle)
                {
                    if (defaultView.ViewRowHandleToDataSourceIndex(rowHandle) >= 0)
                        text = (text == null ? "" : text + Environment.NewLine) + defaultView.GetRowCellDisplayText(rowHandle, column);
                }
                if (!string.IsNullOrEmpty(text))
                    Clipboard.SetText(text);
            }
            catch (Exception ex)
            {
            }
        }
        private void PassColum_Click(object sender, EventArgs e)
        {
            try
            {
                GridView defaultView = (GridView)this.DefaultView;
                GridColumn column = defaultView.CalcHitInfo(this.pt).Column;
                if (column == null)
                    return;
                if (!defaultView.FocusedColumn.ReadOnly && column.OptionsColumn.AllowEdit == true)
                {
                    string st = Clipboard.GetText();
                    string[] rows = st.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    int rowHandle = defaultView.FocusedRowHandle;
                    if (rows.Length < 1) return;
                    int _coulumnIndex = 0;
                    foreach (string str in rows)
                    {
                        defaultView.FocusedRowHandle = _coulumnIndex;
                        if (!column.ReadOnly)
                            defaultView.SetRowCellValue(_coulumnIndex, column, str);
                       
                        _coulumnIndex++;

                        //defaultView.EndDataUpdate();
                    }
                    defaultView.FocusedRowHandle = rowHandle;

                    return;
                }

            }
            catch (Exception ex)
            {
            }
        }


        private void menu21_Click(object sender, EventArgs e)
        {
            ((GridView)this.DefaultView).OptionsView.ShowFooter = ((DXMenuCheckItem)sender).Checked;
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            GridView defaultView = (GridView)this.DefaultView;
            if (((DXMenuCheckItem)sender).Checked)
                defaultView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            else
                defaultView.GroupFooterShowMode = GroupFooterShowMode.Hidden;
        }

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
            //Add columns from databse to GridView
            AddColumnsToGridView(BOSDataSource, gridView);

            //Init column format
            InitColumnFormat(gridView);

            //Init GridControl Column visible index
            InitGridColumnsVisibleIndex(gridView);

            //Restore Grid Layout From User Config
            RestoreGridColumnsVisibleIndex(gridView);
        }

        protected virtual void RestoreGridColumnsVisibleIndex(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            string directoryPath = string.Empty;
            if (string.IsNullOrWhiteSpace(BOSLib.BysGateway.ProjectCode))
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";
            else
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + @"[" + BOSLib.BysGateway.ProjectCode + @"]\" + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";

            string filePath = directoryPath + string.Format("{0}.xml", this.Name);
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    gridView.RestoreLayoutFromXml(filePath);
                    gridView.ClearColumnsFilter();
                    gridView.ClearSorting();
                    gridView.ClearSelection();
                }
                catch (Exception) { }
            }
        }

        protected virtual void InitDefaultGridViewColumns(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {

        }

        protected virtual void InitGridColumnsVisibleIndex(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            STFieldsInfo objSTFieldsInfo = GetAssociatedField();
            if (objSTFieldsInfo != null)
            {
                List<STFieldColumnsInfo> lFieldColumn = LstFieldColumn.Where(fc => fc.STFieldID == objSTFieldsInfo.STFieldID
                                                                             && fc.STFieldColumnCommodityType == CommodityType)
                                                                      .OrderBy(x => x.STFieldColumnVisibleIndex)
                                                                      .ToList();
                if (lFieldColumn != null && lFieldColumn.Count > 0)
                {
                    foreach (STFieldColumnsInfo objSTFieldColumnsInfo in lFieldColumn)
                    {
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

        protected virtual void ChangeGridColumnsVisibleIndex()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.ViewCollection[0];
            if (gridView != null)
            {
                if (gridView.Columns.Count > 0)
                {
                    InitGridColumnsVisibleIndex(gridView);
                }
                //else
                //    InitGridViewColumns(gridView);
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

        //protected void GridControl_MouseDown(object sender, MouseEventArgs e)
        //{
        //    DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl)sender;
        //    hitInfo = ((DevExpress.XtraGrid.Views.Grid.GridView)gridControl.ViewCollection[0]).CalcHitInfo(new Point(e.X, e.Y));
        //    if (hitInfo.RowHandle < 0) hitInfo = null;
        //}

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

        //protected virtual void GridControl_MouseMove(object sender, MouseEventArgs e)
        //{
        //    DevExpress.XtraGrid.GridControl gridControl = (DevExpress.XtraGrid.GridControl)sender;

        //    if (hitInfo == null)
        //        return;
        //    if (e.Button != MouseButtons.Left)
        //        return;
        //    Rectangle dragRect = new Rectangle(new Point(
        //    hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
        //    hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);

        //    if (!dragRect.Contains(new Point(e.X, e.Y)))
        //    {
        //        if (hitInfo.InRowCell)
        //        {
        //            gridControl.DoDragDrop(new object[] { hitInfo.RowHandle, gridControl.ViewCollection[0] }, DragDropEffects.All);
        //        }
        //    }
        //}
        #endregion

        #region New Functions
        public static BOSGridControl Instance(String strInstanceName, String strModuleName)
        {
            if (!String.IsNullOrEmpty(strInstanceName))
            {
                Type type = null;
                BOSGridControl gridControl = null;
                BOSLib.BysGateway.LibraryModule.ForEach(libName =>
                {
                    if (type != null)
                        return;
                    Assembly assembly = Assembly.LoadFrom(Application.StartupPath + @"\\" + libName);
                    type = assembly.GetType("BOSERP.Modules." + strModuleName + "." + strInstanceName + "GridControl");
                    if (type != null)
                        gridControl = (BOSGridControl)type.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                });
                return gridControl ?? new BOSGridControl();
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

        private bool HasExistLookupTable(string tableName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
                return false;

            bool hasExist = false;
            GELookupTablesController lookupTableController = new GELookupTablesController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            GELookupTablesInfo lookupTable = new GELookupTablesInfo();

            if (LookupTableList != null && LookupTableList.Count > 0)
                lookupTable = LookupTableList.Where(t => t.GELookupTableName == tableName).FirstOrDefault();
            if (lookupTable == null || lookupTable.GELookupTableID == 0)
            {
                lookupTable = lookupTableController.GetObjectByTableName(tableName);
                if (lookupTable != null)
                {
                    if (!LookupTableObjects.Keys.Contains(tableName))
                        LookupTableObjects.Add(tableName, lookupTable);
                    hasExist = true;
                }
            }
            else
                hasExist = true;

            if (!LookupTablesUpdatedDate.ContainsKey(tableName))
                LookupTablesUpdatedDate.Add(tableName, ((IBaseModuleERP)Screen.Module).GetServerDate());
            //if (!IntLookupTablesUpdatedDate.ContainsKey(tableName))
            //    IntLookupTablesUpdatedDate.Add(tableName, DateTime.MinValue);
            return hasExist;
        }

        public void UpdateLookupTableDataSource(string strLookupTable)
        {

            bool hasExist = HasExistLookupTable(strLookupTable);
            if (!hasExist)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();
            DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(strLookupTable);
            DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(strLookupTable);
            double _creDate = dtLastCreatedDate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
            double _upddDate = dtLastUpdatedDate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
            double _lkUpddDate = ((DateTime)LookupTablesUpdatedDate[strLookupTable]).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;

            if (!LookupTables.ContainsKey(strLookupTable) || _creDate > _lkUpddDate || _upddDate > _lkUpddDate)
            {
                //Refesh Data Source
                IBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (objLookupTableController != null)
                {
                    //if (strLookupTable == "ICProducts")
                    //{
                    //    string mess = "Ngày tạo: " + dtLastCreatedDate.ToString()
                    //        + Environment.NewLine + "Ngày update: " + dtLastUpdatedDate.ToString()
                    //        + Environment.NewLine + "Ngày cập nhật: " + ((DateTime)LookupTablesUpdatedDate[strLookupTable]).ToString()
                    //        + Environment.NewLine + "Server Date: " + ((IBaseModuleERP)Screen.Module).GetServerDate().ToString();
                    //    MessageBox.Show(mess);
                    //}
                    DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(strLookupTable);
                    if (ds.Tables.Count > 0)
                    {
                        DateTime updatedDate = ((IBaseModuleERP)Screen.Module).GetServerDate();
                        // Update Last Updated Date of Lookup Table
                        if (LookupTablesUpdatedDate.ContainsKey(strLookupTable))
                            LookupTablesUpdatedDate[strLookupTable] = updatedDate;
                        else
                            LookupTablesUpdatedDate.Add(strLookupTable, updatedDate);
                        if (!LookupTables.ContainsKey(strLookupTable))
                        {
                            LookupTables.Add(strLookupTable, ds);
                        }
                        else
                        {
                            ((DataSet)LookupTables[strLookupTable]).Tables.Clear();
                            ((DataSet)LookupTables[strLookupTable]).Dispose();
                            ((DataSet)LookupTables[strLookupTable]).Tables.Add(ds.Tables[0].Copy());
                        }

                    }
                    ds.Dispose();
                    GC.Collect(0, GCCollectionMode.Forced);
                }
            }
        }

        private void AddLookupEditColumns(RepositoryItemBOSLookupEdit rep, string tableName, string lookupEditColumns)
        {
            if (rep == null)
                return;

            if (!string.IsNullOrEmpty(lookupEditColumns))
            {
                //LstColumnAlias.Where(a => a.AATableName == strTableName).ToList();
                List<string> columns = lookupEditColumns.Split(';').ToList();
                if (columns != null)
                {
                    LookUpColumnInfo colName;
                    foreach (string column in columns)
                    {
                        AAColumnAliasInfo alias = LstColumnAlias.Where(a => a.AATableName == tableName && a.AAColumnAliasName == column.Trim()).FirstOrDefault();
                        colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                        colName.Caption = alias == null ? column : alias.AAColumnAliasCaption;
                        colName.FieldName = column.Trim();
                        colName.Width = 100;
                        rep.Columns.Add(colName);
                    }
                }
            }
        }

        private void AddDefaultLookupEditColumns(RepositoryItemBOSLookupEdit rep, string fieldName, string caption)
        {
            if (rep == null)
                return;

            LookUpColumnInfo colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            colName.Caption = caption;
            colName.FieldName = fieldName;
            colName.Width = 100;
            rep.Columns.Add(colName);

        }

        private RepositoryItemBOSLookupEdit InitDefaultColumnLookupEdit(string valueMember, string displayMember, string columnName)
        {
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            rep.NullText = String.Empty;
            rep.BestFitMode = BestFitMode.BestFitResizePopup;
            rep.ColumnName = columnName;

            rep.ValueMember = valueMember;
            rep.DisplayMember = displayMember;
            rep.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);
            rep.Leave += new EventHandler(RepositoryItemBOSLookupEdit_Leave);
            rep.QueryCloseUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryCloseUp);
            rep.KeyDown += new KeyEventHandler(rep_KeyDown);
            return rep;
        }

        protected virtual RepositoryItemBOSLookupEdit InitColumnLookupEdit(AAColumnAliasInfo columnAlias)
        {
            if (columnAlias == null)
                return null;

            String strDisplayColumn = string.Empty;
            //if (!LookupTables.ContainsKey(columnAlias.AAReferenceTable))
            //{
            //    GELookupTablesController lookupTableController = new GELookupTablesController();
            //    BOSDbUtil dbUtil = new BOSDbUtil();
            //    GELookupTablesInfo lookupTable = new GELookupTablesInfo();

            //    if (LookupTableList != null && LookupTableList.Count > 0)
            //        lookupTable = LookupTableList.Where(t => t.GELookupTableName == columnAlias.AAReferenceTable).FirstOrDefault();
            //    if (lookupTable == null || lookupTable.GELookupTableID == 0)
            //        lookupTable = lookupTableController.GetObjectByTableName(columnAlias.AAReferenceTable);
            //    if (lookupTable != null)
            //    {
            //        DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(columnAlias.AAReferenceTable);
            //        LookupTables.Add(columnAlias.AAReferenceTable, ds);
            //        LookupTablesUpdatedDate.Add(columnAlias.AAReferenceTable, dbUtil.GetCurrentServerDate());
            //        LookupTableObjects.Add(columnAlias.AAReferenceTable, lookupTable);
            //        strDisplayColumn = lookupTable.GELookupTableDisplayColumn;
            //        ds.Dispose();
            //    }
            //}
            ////[NUThao] [Improve Speed] [2014-09-09]

            //if (LookupTables[columnAlias.AAReferenceTable] == null)
            //{
            //    return null;
            //}

            bool hasExist = HasExistLookupTable(columnAlias.AAReferenceTable);
            if (!hasExist)
                return null;

            //RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            //rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //rep.NullText = String.Empty;
            //rep.BestFitMode = BestFitMode.BestFitResizePopup;
            //rep.Tag = columnAlias.Id;

            ////String strPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(columnAlias.AAReferenceTable);
            ////if (strDisplayColumn.Equals(string.Empty))
            ////    strDisplayColumn = GetLookupTableDisplayColumn(columnAlias.AAReferenceTable);

            //rep.ValueMember = columnAlias.GELookupTableValueColumn;
            strDisplayColumn = string.Empty;
            if (!string.IsNullOrEmpty(columnAlias.AADisplayedMember))
                strDisplayColumn = columnAlias.AADisplayedMember;
            else
                strDisplayColumn = columnAlias.GELookupTableDisplayColumn;

            RepositoryItemBOSLookupEdit rep = InitDefaultColumnLookupEdit(columnAlias.GELookupTableValueColumn, strDisplayColumn, columnAlias.AAColumnAliasName);
            rep.Tag = columnAlias.Id;

            if (!string.IsNullOrEmpty(columnAlias.GELookupTableLookupColumns))
                AddLookupEditColumns(rep, columnAlias.AAReferenceTable, columnAlias.GELookupTableLookupColumns);
            else
                AddDefaultLookupEditColumns(rep, rep.DisplayMember, columnAlias.AAColumnAliasCaption);

            RefreshLookupEditDataSource(rep);
            return rep;
        }

        /// <summary>
        /// Init data source for lookup edit from a lookup table
        /// </summary>
        /// <param name="dataSource">Data source</param>
        /// <param name="tableName">Name of table the data source is gotten from</param>
        protected DataTable GetLookupTableByFilterCondition(DataTable ds, string tableName, string valueMember,
                                                    string filteredColumn, string filteredValues, bool allowDummy)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            //Get all data which column "BOSSelectType" contains BOSSelectTypeValue from look up table
            DataTable dataSource = ds;
            if (!String.IsNullOrEmpty(filteredColumn))
            {
                dataSource = ds.Copy();
                if (dbUtil.ColumnIsExist(tableName, filteredColumn))
                {
                    string[] selectTypeValues = filteredValues.Split(new char[] { ';' });
                    DataTable datafilter = ds.Clone();
                    foreach (string selectTypeValue in selectTypeValues)
                    {
                        if (dataSource != null && dataSource.Rows.Count > 0 && dataSource.Columns[filteredColumn] != null)
                        {
                            var data = dataSource.Rows.Cast<DataRow>().Where(x => (x[filteredColumn] != null ? x[filteredColumn].ToString().Trim().ToLower() : string.Empty)
                                                                        == selectTypeValue.Trim().ToLower()).AsEnumerable();
                            if (data != null && data.Any())
                                datafilter.Merge(data.CopyToDataTable());
                        }
                    }
                    dataSource = datafilter;
                }
            }

            bool hasDummyRow = false;
            if (allowDummy)
            {
                try
                {
                    if (dataSource.Rows.Count > 0)
                    {
                        object value = dataSource.Rows[0][valueMember];
                        if (value is int)
                        {
                            if (Convert.ToInt32(value) > 0)
                            {
                                DataRow row = dataSource.NewRow();
                                foreach (DataColumn column in row.Table.Columns)
                                {
                                    if (column.ColumnName != valueMember)
                                    {
                                        Type type = column.DataType;
                                        switch (Type.GetTypeCode(type))
                                        {
                                            case TypeCode.Boolean:
                                                row[column.ColumnName] = false;
                                                break;

                                            case TypeCode.Int16:
                                            case TypeCode.Int32:
                                            case TypeCode.Int64:
                                                row[column.ColumnName] = 0;
                                                break;
                                            case TypeCode.Char:
                                            case TypeCode.String:
                                                row[column.ColumnName] = string.Empty;
                                                break;
                                        };
                                    }
                                }
                                row[valueMember] = 0;
                                dataSource.Rows.InsertAt(row, 0);
                                hasDummyRow = true;
                            }
                        }
                        else if (value is string)
                        {
                            if (!string.IsNullOrEmpty(value.ToString()))
                            {
                                DataRow row = dataSource.NewRow();
                                foreach (DataColumn column in row.Table.Columns)
                                {
                                    if (column.ColumnName != valueMember)
                                    {
                                        Type type = column.DataType;
                                        switch (Type.GetTypeCode(type))
                                        {
                                            case TypeCode.Boolean:
                                                row[column.ColumnName] = false;
                                                break;

                                            case TypeCode.Int16:
                                            case TypeCode.Int32:
                                            case TypeCode.Int64:
                                                row[column.ColumnName] = 0;
                                                break;
                                            case TypeCode.Char:
                                            case TypeCode.String:
                                                row[column.ColumnName] = string.Empty;
                                                break;
                                        };
                                    }
                                }
                                row[valueMember] = string.Empty;
                                row["key"] = string.Empty;
                                dataSource.Rows.InsertAt(row, 0);
                                hasDummyRow = true;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return dataSource;
                }
            }
            return dataSource;
        }

        protected virtual RepositoryItemBOSLookupEdit InitColumnLookupEdit(string strTableName, string columnCaption, string columnName)
        {
            String lookupTableName = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(strTableName, columnName);
            String strDisplayColumn = string.Empty;
            BOSDbUtil dbUtil = new BOSDbUtil();
            bool hasExist = HasExistLookupTable(lookupTableName);
            if (!hasExist)
                return null;

            String strPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(lookupTableName);
            if (strDisplayColumn.Equals(string.Empty))
                strDisplayColumn = GetLookupTableDisplayColumn(lookupTableName);
            //rep.ValueMember = strPrimaryColumn;
            //rep.DisplayMember = strDisplayColumn;

            RepositoryItemBOSLookupEdit rep = InitDefaultColumnLookupEdit(strPrimaryColumn, strDisplayColumn, columnName);
            rep.Tag = lookupTableName;

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

            //UpdateLookupTableDataSource(lookupTableName); => đã có trong RefreshLookupEditDataSource
            RefreshLookupEditDataSource(rep);

            string fieldName = rep.ColumnName;
            if (string.IsNullOrEmpty(rep.ColumnName))
            {
                fieldName = lookupTableName;
            }
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            TimeSpan uDDate = LookupTables.ContainsKey(lookupTableName) ? ((DateTime)LookupTablesUpdatedDate[lookupTableName] - epoch) : (((IBaseModuleERP)Screen.Module).GetServerDate() - epoch);
            TimeSpan lKDate = ((DateTime)LookupTablesUpdatedDate[lookupTableName] - epoch);
            if (!LookupTables.ContainsKey(lookupTableName) || uDDate.TotalSeconds > lKDate.TotalSeconds)
            {

                DataSet dsTable = ((DataSet)LookupTables[lookupTableName]);
                rep.DataSource = dsTable.Tables[0];
                if (IntLookupTablesUpdatedDate.ContainsKey(fieldName))
                    IntLookupTablesUpdatedDate[fieldName] = LookupTablesUpdatedDate[lookupTableName];
                else
                    IntLookupTablesUpdatedDate.Add(fieldName, LookupTablesUpdatedDate[lookupTableName]);
                dsTable.Dispose();
                GC.Collect(0, GCCollectionMode.Forced);
            }
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
                else
                {
                    GELookupTablesController objGELookupTablesController = new GELookupTablesController();
                    if (LookupTableList != null && LookupTableList.Count > 0)
                        objLookupTablesInfo = LookupTableList.Where(t => t.GELookupTableName == strLookupTableName).FirstOrDefault();
                    LookupTableObjects.Add(strLookupTableName, objLookupTablesInfo);
                }
                if (objLookupTablesInfo != null && !String.IsNullOrEmpty(objLookupTablesInfo.GELookupTableDisplayColumn))
                    return objLookupTablesInfo.GELookupTableDisplayColumn;

                //If not exist, get default display column            
                String strPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(strLookupTableName);
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
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            RepositoryItemBOSLookupEdit rep = (RepositoryItemBOSLookupEdit)lke.Properties;
            //RefreshLookupEditDataSource(rep);
        }

        protected virtual string GetLookupTableInLookupEditCtrl(BOSLookupEdit lke)
        {
            if (lke == null || lke.Properties == null || lke.Properties.Tag == null)
                return string.Empty;

            int id = 0;
            if (lke.Properties.Tag != null)
            {
                int.TryParse(lke.Properties.Tag.ToString(), out id);
            }

            string strLookupTable = string.Empty;
            AAColumnAliasInfo alias = null;
            if (id > 0)
            {
                alias = LstColumnAlias.FirstOrDefault(a => a.Id == id);
                if (alias != null)
                    strLookupTable = alias.AAReferenceTable;
            }
            else
            {
                string valueMember = lke.Properties.ValueMember;
                if (!string.IsNullOrEmpty(valueMember))
                    strLookupTable = valueMember.Substring(0, valueMember.Length - 2);
            }
            return strLookupTable;

        }

        protected virtual string GetFieldColumnInLookupEditCtrl(BOSLookupEdit lke)
        {
            if (lke == null || lke.Properties == null || lke.Properties.Tag == null)
                return string.Empty;

            int id = 0;
            if (lke.Properties.Tag != null)
            {
                int.TryParse(lke.Properties.Tag.ToString(), out id);
            }

            string fieldColumn = string.Empty;
            AAColumnAliasInfo alias = null;
            if (id > 0)
            {
                alias = LstColumnAlias.FirstOrDefault(a => a.Id == id);
                if (alias != null)
                    fieldColumn = alias.AAColumnAliasName;
            }

            return fieldColumn;

        }

        protected virtual AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            if (lke == null || lke.Tag == null)
                return null;

            int id = 0;
            if (lke.Tag != null)
            {
                int.TryParse(lke.Tag.ToString(), out id);
            }

            string strLookupTable = string.Empty;
            AAColumnAliasInfo alias = null;
            if (id > 0)
            {
                alias = LstColumnAlias.FirstOrDefault(a => a.Id == id);
                if (alias != null)
                    strLookupTable = alias.AAReferenceTable;
            }
            return alias;

        }

        private void RefreshLookupEditDataSource(RepositoryItemBOSLookupEdit lke)
        {

            if (lke == null)
                return;
            BOSDbUtil dbUtil = new BOSDbUtil();
            string strLookupTable = string.Empty;
            AAColumnAliasInfo alias = GetColumnAliasInLookupEditCtrl(lke);
            if (alias != null)
                strLookupTable = alias.AAReferenceTable;

            bool hasExist = HasExistLookupTable(strLookupTable);
            if (!hasExist)
                return;
            try
            {
                UpdateLookupTableDataSource(strLookupTable);
                string fieldName = lke.ColumnName;
                if (string.IsNullOrEmpty(lke.ColumnName))
                    fieldName = strLookupTable;
                DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
                DateTime minUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0).ToLocalTime();
                TimeSpan uDDate = LookupTablesUpdatedDate.ContainsKey(strLookupTable) ? ((DateTime)LookupTablesUpdatedDate[strLookupTable] - epoch) : (((IBaseModuleERP)Screen.Module).GetServerDate() - epoch);
                TimeSpan lKDate = IntLookupTablesUpdatedDate.ContainsKey(strLookupTable) ? ((DateTime)IntLookupTablesUpdatedDate[strLookupTable] - epoch) : (minUpdate - epoch);
                if (uDDate.TotalSeconds > lKDate.TotalSeconds)
                {
                    #region Recatche
                    DataTable dataSource = ((DataSet)LookupTables[strLookupTable]) != null
                                            && ((DataSet)LookupTables[strLookupTable]).Tables != null
                                            && ((DataSet)LookupTables[strLookupTable]).Tables.Count > 0 ? ((DataSet)LookupTables[strLookupTable]).Tables[0] : new DataTable();

                    if (!string.Empty.Equals(alias.AAFilteredValues.Trim()))
                    {
                        DataTable dt = GetLookupTableByFilterCondition(dataSource, alias.AAReferenceTable, alias.GELookupTableValueColumn,
                                                       alias.AAFilteredColumn, alias.AAFilteredValues, true);

                        DataTable dt1;
                        if (lke.DataSource != null && lke.DataSource.GetType() == typeof(DataView))
                            dt1 = ((DataView)lke.DataSource).ToTable();
                        else dt1 = (DataTable)lke.DataSource;
                        if (dt1 != null)
                        {
                            dt1.Rows.Clear();
                            if (dt != null && dt.Rows.Count != 0)
                            {
                                for (int index = 0; index < dt.Rows.Count; index++)
                                {
                                    DataRow row = dt.Rows[index];
                                    dt1.ImportRow(row);
                                }
                                lke.DataSource = dt1;
                                dt1.Dispose();
                                GC.Collect(0, GCCollectionMode.Forced);
                            }
                        }
                        else
                            lke.DataSource = dt;
                        dt.Dispose();
                    }
                    else
                    {
                        lke.DataSource = dataSource;
                    }
                    dataSource.Dispose();
                    GC.Collect(0, GCCollectionMode.Forced);
                    #endregion
                    if (IntLookupTablesUpdatedDate.ContainsKey(fieldName))
                        IntLookupTablesUpdatedDate[fieldName] = LookupTablesUpdatedDate[strLookupTable];
                    else
                        IntLookupTablesUpdatedDate.Add(fieldName, LookupTablesUpdatedDate[strLookupTable]);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        protected virtual void RepositoryItemLookupEdit_QueryCloseUp(object sender, CancelEventArgs e)
        {
        }

        protected virtual DevExpress.XtraEditors.Repository.RepositoryItemTextEdit InitColumnAmountTextEdit(int iDecimal)
        {
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            repItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repItemTextEdit.Mask.EditMask = String.Format("f{0}", iDecimal.ToString());
            repItemTextEdit.Mask.UseMaskAsDisplayFormat = true;

            return repItemTextEdit;
        }
        protected List<AAColumnAliasInfo> GetColumnAliasFieldPermission(string ModuleName, string strTableName, int userGroupID)
        {
            List<AAColumnAliasInfo> lstColumnAlias = new List<AAColumnAliasInfo>();
            lstColumnAlias = LstColumnAlias.Where(a => a.AATableName == strTableName).ToList();
            List<AAColumnAliasInfo> lstColumnAliasDisplay = new List<AAColumnAliasInfo>();
            List<STFieldColumnPermissionsInfo> fieldPermission = new List<STFieldColumnPermissionsInfo>();
            //IList fP = LstFieldColumnPermissions.GetValueList();
            foreach (STFieldColumnPermissionsInfo item in LstFieldColumnPermissions.Values)
            {
                if (item.STModuleName == ModuleName && item.STTableName == strTableName && item.FK_ADUserGroupID == userGroupID)
                    fieldPermission.Add(item);
            }
            if (lstColumnAlias != null)
            {
                foreach (AAColumnAliasInfo item in lstColumnAlias)
                {
                    bool display = true;
                    if (fieldPermission != null && fieldPermission.Count > 0)
                    {
                        STFieldColumnPermissionsInfo objFcp = fieldPermission.Where(f => f.STColumnName == item.AAColumnAliasName).FirstOrDefault();
                        if (objFcp != null && objFcp.STFieldColumnPermissionType == Convert.ToByte(1))
                            display = false;
                    }
                    if (display) lstColumnAliasDisplay.Add(item);
                }
            }
            return lstColumnAliasDisplay;
        }
        protected virtual void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            //Add bound columns
            BOSDbUtil dbUtil = new BOSDbUtil();
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            int userGroupID = BOSLib.BysGateway.CurrentUsersInfo.ADUserGroupID;
            List<AAColumnAliasInfo> lstColumnAlias = GetColumnAliasFieldPermission(Screen.Module.Name, strTableName, userGroupID);
            lstColumnAlias = GetListVisibleToInit(lstColumnAlias);
            AddColumnsFromColumnAlias(strTableName, gridView, lstColumnAlias);
        }
        public List<AAColumnAliasInfo> GetListVisibleToInit(List<AAColumnAliasInfo> lstColumnAlias)
        {
            STFieldsInfo objSTFieldsInfo = GetAssociatedField();
            if (objSTFieldsInfo != null)
            {
                List<STFieldColumnsInfo> lFieldColumn = LstFieldColumn.Where(fc => fc.STFieldID == objSTFieldsInfo.STFieldID
                                                                             && fc.STFieldColumnCommodityType == CommodityType)
                                                                      .OrderBy(x => x.STFieldColumnVisibleIndex)
                                                                      .ToList();
                if (lFieldColumn != null && lFieldColumn.Count > 0)
                {
                    lstColumnAlias.ForEach(a =>
                    {
                        if (lFieldColumn.Any(f => f.STFieldColumnFieldName == a.AAColumnAliasName))
                            a.Visible = true;
                        else a.Visible = false;

                    });
                }
            }
            return lstColumnAlias;
        }
        protected virtual void AddColumnsFromColumnAlias(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            if (lstColumnAlias != null && lstColumnAlias.Count > 0)
            {
                foreach (AAColumnAliasInfo objAAColumnAliasInfo in lstColumnAlias)
                {
                    if (gridView.Columns.ColumnByFieldName(objAAColumnAliasInfo.AAColumnAliasName) == null ||
                        (gridView.Columns.ColumnByFieldName(objAAColumnAliasInfo.AAColumnAliasName) != null && gridView.Columns.ColumnByFieldName(objAAColumnAliasInfo.AAColumnAliasName).GroupIndex >= 0))
                    {
                        DevExpress.XtraGrid.Columns.GridColumn column = InitGridColumn(strTableName, -1, objAAColumnAliasInfo.AAColumnAliasName, objAAColumnAliasInfo.AAColumnAliasCaption, 50);
                        if (objAAColumnAliasInfo.Visible)
                        {
                            if (!string.IsNullOrEmpty(objAAColumnAliasInfo.AAReferenceTable))
                            {
                                RepositoryItemBOSLookupEdit repLookupEdit = InitColumnLookupEdit(objAAColumnAliasInfo);
                                if (repLookupEdit != null)
                                {
                                    if (gridView.GridControl != null)
                                        gridView.GridControl.RepositoryItems.Add(repLookupEdit);
                                    column.ColumnEdit = repLookupEdit;
                                }
                            }
                            else if (((IBaseModuleERP)Screen.Module).IsForeignKey(strTableName, objAAColumnAliasInfo.AAColumnAliasName))
                            {
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
                                    RepositoryItemBOSLookupEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable], objAAColumnAliasInfo.AAAllowDummy);
                                    rep.ColumnName = objAAColumnAliasInfo.AAColumnAliasName;
                                    column.ColumnEdit = rep;
                                }
                                else if (objAAColumnAliasInfo.AAColumnAliasName.Contains("MatchCode"))
                                {
                                    RepositoryItemBOSLookupEdit repLookupEdit = new RepositoryItemBOSLookupEdit();
                                    ADMatchCodesController objMatchCodesController = new ADMatchCodesController();
                                    DataSet ds = objMatchCodesController.GetADMatchCodesByADMatchCodeColumnName(objAAColumnAliasInfo.AAColumnAliasName);
                                    if (ds.Tables.Count > 0)
                                    {
                                        if (objAAColumnAliasInfo.AAAllowDummy)
                                        {
                                            DataTable dt = ds.Tables[0].Copy();
                                            DataRow row = dt.NewRow();
                                            dt.Rows.InsertAt(row, 0);
                                            repLookupEdit.DataSource = dt;
                                            dt.Dispose();
                                        }
                                        else
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
                                    repLookupEdit.ColumnName = objAAColumnAliasInfo.AAColumnAliasName;
                                    column.ColumnEdit = repLookupEdit;
                                    ds.Dispose();
                                    GC.Collect(0, GCCollectionMode.Forced);
                                }
                                else
                                {
                                    //Init column repository based on field format group
                                    column.ColumnEdit = InitColumnRepositoryFromFieldFormatGroup(strTableName, objAAColumnAliasInfo.AAColumnAliasName);
                                    if (column.ColumnEdit != null)
                                        column.ColumnEdit.MouseWheel += new MouseEventHandler(ColumnEdit_MouseWheel);
                                }
                            }
                        }
                        column.OptionsColumn.AllowEdit = false;
                        column.OptionsFilter.FilterPopupMode = FilterPopupMode.CheckedList;
                        gridView.Columns.Add(column);
                    }
                    else
                    {
                        gridView.Columns[objAAColumnAliasInfo.AAColumnAliasName].Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                    }

                }
            }
        }

        void ColumnEdit_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }


        /// <summary>
        /// Init repository to display config values
        /// </summary>
        /// <param name="dataSource">Data source of config values</param>
        /// <returns>Repository item</returns>
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
        /// Init repository to display config values
        /// </summary>
        /// <param name="dataSource">Data source of config values</param>
        /// <returns>Repository item</returns>
        protected RepositoryItemBOSLookupEdit InitRepositoryForConfigValues(DataTable dataSource, bool allowDummy)
        {
            RepositoryItemBOSLookupEdit repLookupEdit = new RepositoryItemBOSLookupEdit();
            repLookupEdit.ValueMember = "Value";
            repLookupEdit.DisplayMember = "Text";
            repLookupEdit.ShowHeader = false;
            repLookupEdit.TextEditStyle = TextEditStyles.Standard;
            DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            repColumn.FieldName = "Text";
            repColumn.Width = 100;
            repLookupEdit.Columns.Add(repColumn);
            repLookupEdit.PopupWidth = repColumn.Width;
            repLookupEdit.NullText = string.Empty;
            if (dataSource != null)
            {
                DataTable dt = dataSource;
                if (allowDummy)
                {
                    dt = GetLookupTableByFilterCondition(dataSource, "ADConfigValues", "Value", string.Empty, string.Empty, allowDummy);
                }

                repLookupEdit.DataSource = dt;
                if (dt != null)
                    dt.Dispose();
                GC.Collect(0, GCCollectionMode.Forced);
            }
            else
                repLookupEdit.DataSource = null;

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
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Screen.Module.GetColumnFormat(BOSDataSource, fieldName, this.Screen.Module.ModuleID);
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
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Screen.Module.GetColumnFormat(strTableName, strColumnName, this.Screen.Module.ModuleID);
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

                    if (rep is RepositoryItemTextEdit)
                    {
                        rep.MouseWheel += new MouseEventHandler(rep_MouseWheel);
                    }
                }
            }
        }

        void rep_MouseWheel(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        public DevExpress.XtraEditors.Repository.RepositoryItem InitColumnRepositoryFromFieldFormatGroup(String strTableName, String strColumnName)
        {
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = Screen.Module.GetColumnFormat(strTableName, strColumnName, this.Screen.Module.ModuleID);
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
        protected virtual void NavigatorButton_Click(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            string btnTag = e.Button.Tag == null ? string.Empty : e.Button.Tag.ToString();
            switch (btnTag)
            {
                case "CustomizeColumn":
                    CustomizeColumnGridControl();
                    break;
                case "SaveColumnCustomization":
                    SaveCustomizeColumnGridControl();
                    break;
                case "RecoveryDefaultColumn":
                    RecoveryDefaultColumnGridControl();
                    break;
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
            GridView gridView = (GridView)this.MainView;
            if (BOSLib.BysGateway.CurrentUsersInfo.ADUserIsCustomizeColumn)
            {
                DialogResult rs = MessageBox.Show(ComponentLocalizedResources.SaveConfigForSystemMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    SaveDefaultColumnSystem();
                }
            }
            SaveUserDataColumnGridControl(gridView);
            MessageBox.Show(ComponentLocalizedResources.SaveSuccessfully, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected virtual void SaveUserDataColumnGridControl(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            string directoryPath = string.Empty;
            if (string.IsNullOrWhiteSpace(BOSLib.BysGateway.ProjectCode))
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";
            else
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + @"[" + BOSLib.BysGateway.ProjectCode + @"]\" + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";

            string filePath = directoryPath + string.Format("{0}.xml", this.Name);
            if (!System.IO.Directory.Exists(directoryPath))
                System.IO.Directory.CreateDirectory(directoryPath);

            gridView.SaveLayoutToXml(filePath);
        }

        protected virtual void SaveDefaultColumnSystem()
        {
            STFieldsInfo objSTFieldsInfo = GetAssociatedField();
            if (objSTFieldsInfo == null)
            {
                objSTFieldsInfo = new STFieldsInfo();
                objSTFieldsInfo.STFieldName = this.Name;
                objSTFieldsInfo.STFieldGroup = BOSScreen.cstFieldGroupSearch;
                objSTFieldsInfo.STScreenID = Screen == null ? 0 : Screen.ScreenID;
                objSTFieldsInfo.STFieldDataSource = BOSDataSource;
                objSTFieldsInfo.STModuleID = Screen == null ? 0 : (Screen.Module == null ? 0 : Screen.Module.ModuleID);
                new STFieldsController().CreateObject(objSTFieldsInfo);
                ((IBaseModuleERP)Screen.Module).AddSystemField(objSTFieldsInfo);
            }
            if (objSTFieldsInfo != null)
            {
                STFieldColumnsController objSTFieldColumnsController = new STFieldColumnsController();
                objSTFieldColumnsController.DeleteBySTFieldIDAndCommodityType(objSTFieldsInfo.STFieldID, CommodityType);
                ((IBaseModuleERP)Screen.Module).RemoveSystemFieldColumnsByFieldID(objSTFieldsInfo.STFieldID, CommodityType);
                List<STFieldColumnsInfo> fieldColumns = new List<STFieldColumnsInfo>();
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
                        objSTFieldColumnsInfo.STFieldColumnCommodityType = CommodityType;

                        objSTFieldColumnsController.CreateObject(objSTFieldColumnsInfo);
                        fieldColumns.Add(objSTFieldColumnsInfo);
                    }
                }
                ((IBaseModuleERP)Screen.Module).AddSystemFieldColumns(fieldColumns);
            }
        }
        protected virtual void RecoveryDefaultColumnGridControl()
        {
            GridView gridView = (GridView)this.MainView;
            InitGridColumnsVisibleIndex(gridView);
            string directoryPath = string.Empty;
            if (string.IsNullOrWhiteSpace(BOSLib.BysGateway.ProjectCode))
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";
            else
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + @"[" + BOSLib.BysGateway.ProjectCode + @"]\" + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";

            string filePath = directoryPath + string.Format("{0}.xml", this.Name);
            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
        }
        /// <summary>
        /// Invalidate lookup edit columns to reflect all changes of lookup table
        /// </summary>
        public virtual void InvalidateLookupEditColumns()
        {
            if (this.MainView == null) return;
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                if (column.ColumnEdit != null && (column.ColumnEdit is RepositoryItemBOSLookupEdit))
                {
                    RepositoryItemBOSLookupEdit rep = (RepositoryItemBOSLookupEdit)column.ColumnEdit;

                    RefreshLookupEditDataSource(rep);

                }
            }
        }
        /// <summary>
        /// Invalidate lookup edit columns to reflect all changes of lookup table
        /// </summary>
        public virtual void RefreshBindingDataLookupEdit()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.MainView;
            if (Screen == null || Screen.Module == null) return;
            int userGroupID =  ((IBaseModuleERP)Screen.Module).GetCurrentUserGroupID();
            List<AAColumnAliasInfo> lstColumnAlias = GetColumnAliasFieldPermission(Screen.Module.Name, BOSDataSource, userGroupID);
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                if (column.ColumnEdit != null && (column.ColumnEdit is RepositoryItemBOSLookupEdit))
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();

                    RepositoryItemBOSLookupEdit rep = (RepositoryItemBOSLookupEdit)column.ColumnEdit;
                    String strLookupTable = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(BOSDataSource, column.FieldName);
                    string filterValue = string.Empty;
                    string filterColumn = string.Empty;
                    string tableValueColumn = string.Empty;

                    AAColumnAliasInfo colAliasInfo = lstColumnAlias != null ?
                        lstColumnAlias.Where(a => a.AATableName == BOSDataSource && a.AAColumnAliasName == column.FieldName).FirstOrDefault() : null;

                    if (colAliasInfo != null && colAliasInfo.AAReferenceTable.Trim() != string.Empty)
                    {
                        strLookupTable = colAliasInfo.AAReferenceTable;
                        if (colAliasInfo.AAFilteredColumn.Trim() != string.Empty)
                        {
                            filterValue = colAliasInfo.AAFilteredValues;
                            filterColumn = colAliasInfo.AAFilteredColumn;
                            tableValueColumn = colAliasInfo.GELookupTableValueColumn;
                        }
                    }
                    String configValueGroup = GetConfigValueGroup(column.FieldName);
                    if (!String.IsNullOrEmpty(configValueGroup) && ADConfigValueUtility.ConfigValues.Tables[configValueGroup] != null)
                    {
                        DataTable dataSource = ADConfigValueUtility.ConfigValues.Tables[configValueGroup];
                        rep.DataSource = dataSource;
                    }
                    else if (string.IsNullOrEmpty(filterValue) && !string.IsNullOrEmpty(strLookupTable) && LookupTables.ContainsKey(strLookupTable))
                    {
                        rep.DataSource = ((DataSet)LookupTables[strLookupTable]).Tables[0];
                    }
                    else if (((DataSet)LookupTables[strLookupTable]) != null)
                    {
                        DataTable dt = GetLookupTableByFilterCondition(((DataSet)LookupTables[strLookupTable]).Tables[0], strLookupTable, tableValueColumn,
                                                   filterColumn, filterValue, true);
                        try
                        {
                            DataTable dt1 = (DataTable)rep.DataSource;
                            if (dt1 != null)
                            {
                                dt1.Rows.Clear();
                                if (dt != null && dt.Rows.Count != 0)
                                {
                                    for (int index = 0; index < dt.Rows.Count; index++)
                                    {
                                        DataRow row = dt.Rows[index];
                                        dt1.ImportRow(row);
                                    }
                                    rep.DataSource = dt1;
                                    dt1.Dispose();
                                    GC.Collect(0, GCCollectionMode.Forced);
                                }
                            }
                            else
                                rep.DataSource = dt;
                        }
                        catch (Exception)
                        {

                            dt.Dispose();
                        }
                        dt.Dispose();
                    }
                }
            }
            gridView.RefreshData();
        }
        public void ReInitFormat(string formatString, string MarkString)
        {
            GridView gridView = (GridView) this.MainView;
            string ProductType = string.Empty;
            if (gridView != null && gridView.RowCount > 0)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                BusinessObject row = (BusinessObject)gridView.GetRow(0);
                int FK_ICProductID = dbUtil.GetPropertyIntValue(row, "FK_ICProductID");
                
                if (FK_ICProductID > 0)
                {
                    ProductType = ((IBaseModuleERP)Screen.Module).GetProductType(FK_ICProductID);
                }
            }
            foreach (GridColumn column in gridView.Columns)
            {
                ReInitColumnFormat(column, BOSDataSource, column.FieldName, formatString, MarkString, ProductType);
            }
        }
        public void ReInitColumnFormat(GridColumn column, String strTableName, String strColumnName, string formatString, string MarkString, string ProductType)
        {
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = new STFieldFormatGroupsInfo();
            if (Screen != null)
                 objFieldFormatGroupsInfo = Screen.Module.GetColumnFormat(strTableName, strColumnName, this.Screen.Module.ModuleID);
            bool changeFormat = false;
            if (objFieldFormatGroupsInfo != null && (objFieldFormatGroupsInfo.STFieldFormatGroupFormatType == "Numeric" || objFieldFormatGroupsInfo.STFieldFormatGroupMaskType == "Numeric") 
                && objFieldFormatGroupsInfo.STChangeByCurrency)
            {
                changeFormat = true;
            }
            else if (objFieldFormatGroupsInfo != null && (objFieldFormatGroupsInfo.STFieldFormatGroupFormatType == "Numeric" || objFieldFormatGroupsInfo.STFieldFormatGroupMaskType == "Numeric")
                && objFieldFormatGroupsInfo.STChangeByDepartment && !string.IsNullOrEmpty( ProductType))
            {
                changeFormat = true;
                formatString = GetDepartmentStringFormat(ProductType, false);
                MarkString = GetDepartmentStringFormat(ProductType, true);
            }
            if (changeFormat && !string.IsNullOrEmpty(MarkString) && !string.IsNullOrEmpty(formatString))
            {
                DevExpress.XtraEditors.Repository.RepositoryItem rep = column.ColumnEdit;
                if (BOSUtil.IsEditRepository(rep))
                {
                    RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
                    {
                        Mask =
                    {
                        MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                        EditMask = MarkString,
                        UseMaskAsDisplayFormat = true
                    }
                    };
                    repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
                    repositoryItemTextEdit.DisplayFormat.FormatString = formatString;
                    column.ColumnEdit = repositoryItemTextEdit;
                }
            }
        }
        public string GetDepartmentStringFormat(string ProductType,bool isGetMark)
        {
            string FormatString = "N2";
            string fieldget = "STFieldFormatGroupFormatString";
            if (isGetMark) fieldget = "STFieldFormatGroupMaskEdit";
            DataSet ds = (DataSet)LookupTables[TableName.ICDepartmentFormatsTableName];
            if (ds != null && ds.Tables.Count > 0)
            {
                var result = ds.Tables[0].Rows.Cast<DataRow>().Where(x => (x["ICProductType"] != null ? x["ICProductType"].ToString() : string.Empty)
                                                                            == ProductType).Select(r => r[fieldget]).FirstOrDefault();
                if (result != null)
                    FormatString = result.ToString();
            }
            if (string.IsNullOrEmpty(FormatString)) FormatString = "N6";
            return FormatString;
        }
        private String GetConfigValueGroup(string dataMember)
        {
            string configValueTable = string.Empty;
            if (!string.IsNullOrEmpty(dataMember))
            {
                if (dataMember.Contains("Combo"))
                {
                    configValueTable = dataMember.Substring(2, dataMember.Length - 7);
                }
                else
                {
                    configValueTable = dataMember.Substring(2, dataMember.Length - 2);
                }
            }
            return configValueTable;
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
            STFieldsInfo objSTFieldsInfo = null;
            if (Screen.Fields.ContainsKey(Name))
            {
                objSTFieldsInfo = Screen.Fields[Name];
            }
            if (Name == "fld_dgcARDeliveryPlans")
            { 
            
            }
            if (objSTFieldsInfo == null)
            {
                objSTFieldsInfo = FieldList.Where(f => f.STModuleID == Screen.Module.ModuleID && f.STUserGroupID == UserGroup.Admin && f.STFieldName == Name).FirstOrDefault();
                if (objSTFieldsInfo == null)
                {
                    //The grid control is generated by code behind and used for search screen
                    objSTFieldsInfo = FieldList.Where(f => f.STFieldName == this.Name && f.STFieldGroup == BOSScreen.cstFieldGroupSearch).FirstOrDefault();
                }
            }
            return objSTFieldsInfo;
        }
        public virtual void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
        public override void RefreshDataSource()
        {

            base.RefreshDataSource();
            GridView gridView = (GridView)this.MainView;
            string ProductType = string.Empty;
            if (gridView != null && gridView.RowCount > 0 )
            {
                try
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    BusinessObject row = (BusinessObject)gridView.GetRow(0);
                    int FK_ICProductID = dbUtil.GetPropertyIntValue(row, "FK_ICProductID");

                    if (FK_ICProductID > 0)
                    {
                        ProductType = ((IBaseModuleERP)Screen.Module).GetProductType(FK_ICProductID);
                    }
                }
                catch {
                    return;
                }
            }
            foreach (GridColumn column in gridView.Columns)
            {
                ReInitColumnFormat(column, BOSDataSource, column.FieldName, string.Empty, string.Empty, ProductType);
            }
        }
    }
}
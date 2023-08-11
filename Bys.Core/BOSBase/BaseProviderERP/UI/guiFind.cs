using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiFind<T> : BOSERPScreen where T : BusinessObject
    {
        #region Variables
        /// <summary>
        /// The grid control contains search result
        /// </summary>
        private BOSGridControl GridControlResult;

        /// <summary>
        /// The control causes this screen to show up
        /// </summary>
        private Control Owner;

        /// <summary>
        /// The name of table is searched on
        /// </summary>
        private String SearchTableName;

        /// <summary>
        /// List of objects is used to bind to the search grid control        
        /// </summary>
        private IList<T> ObjectList;

        /// <summary>
        /// List of objects is used to bind to the search grid control        
        /// </summary>
        private IList<T> searchObjectList;

        /// <summary>
        /// A value indicates whether the screen allows multiple selection
        /// </summary>
        private bool AllowMultipleSelect;

        /// <summary>
        /// A value indicates whether the screen shows the object list when it's shown
        /// </summary>
        private bool ShowData;

        //TNDLoc [ADD][21/05/2015][Issue checked all with Filter],START
        private bool isFilterChecked = true;
        //TNDLoc [ADD][21/05/2015][Issue checked all with Filter],END
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of selected objects
        /// </summary>
        public IList<T> SelectedObjects { get; set; }

        /// <summary>
        /// Gets or sets the name of the grid control that its component
        /// will be instantiated and used in this form
        /// </summary>
        public string GridControlName { get; set; }
        public string[] GroupedColumnNames { get; set; }
        public string[] AddColumnNames { get; set; }

        public bool IsRoundWood = false;
        public string MessageInfo { get; set; }
        public string[] ColumnArr;
        #endregion

        public guiFind()
        {
            InitializeComponent();
        }

        //public guiFind(string searchTableName, IList<T> objectList, BaseModule module, bool allowMultipleSelect, bool showData, string[] groupedColumnNames, string[] addColumnNames, bool isRoundWood)
        //{
        //    InitializeComponent();

        //    SearchTableName = searchTableName;
        //    ObjectList = objectList;
        //    Module = module;
        //    AllowMultipleSelect = allowMultipleSelect;
        //    SelectedObjects = new List<T>();
        //    this.searchObjectList = objectList;
        //    ShowData = showData;
        //    GroupedColumnNames = groupedColumnNames;
        //    AddColumnNames = addColumnNames;
        //    IsRoundWood = isRoundWood;
        //}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchTableName">Name of the table is searched on</param>
        /// <param name="objectList">Object list is used to be a data source for search</param>
        /// <param name="owner">Control causes the screen to show up</param>
        /// <param name="module">Module the screen belongs to</param>
        public guiFind(String searchTableName, IList<T> objectList, Control owner, BaseModule module)
        {
            InitializeComponent();

            this.SearchTableName = searchTableName;
            this.ObjectList = objectList;
            this.Owner = owner;
            this.Module = module;
            AllowMultipleSelect = false;
            ShowData = true;
            SelectedObjects = new List<T>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchTableName">Name of the table is searched on</param>
        /// <param name="objectList">Object list is used to be a data source for search</param>        
        /// <param name="module">Module the screen belongs to</param>
        public guiFind(String searchTableName, IList<T> objectList, BaseModule module)
        {
            InitializeComponent();

            this.SearchTableName = searchTableName;
            this.ObjectList = objectList;
            this.Module = module;
            AllowMultipleSelect = false;
            ShowData = true;
            SelectedObjects = new List<T>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchTableName">Name of the table is searched on</param>
        /// <param name="objectList">Object list is used to be a data source for search</param>        
        /// <param name="module">Module the screen belongs to</param>
        /// <param name="allowMultipleSelect">A value indicates whether the screen allows multiple selection</param>
        public guiFind(string searchTableName, IList<T> objectList, BaseModule module, bool allowMultipleSelect)
        {
            InitializeComponent();

            SearchTableName = searchTableName;
            ObjectList = objectList;
            Module = module;
            AllowMultipleSelect = allowMultipleSelect;
            ShowData = true;
            SelectedObjects = new List<T>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchTableName">Name of the table is searched on</param>
        /// <param name="objectList">Object list is used to be a data source for search</param>        
        /// <param name="module">Module the screen belongs to</param>
        /// <param name="allowMultipleSelect">A value indicates whether the screen allows multiple selection</param>
        /// <param name="showData">A value indicates whether the screen shows the object list when it's shown</param>
        public guiFind(string searchTableName, IList<T> objectList, BaseModule module, bool allowMultipleSelect, bool showData)
        {
            InitializeComponent();

            SearchTableName = searchTableName;
            ObjectList = objectList;
            Module = module;
            AllowMultipleSelect = allowMultipleSelect;
            ShowData = showData;
            SelectedObjects = new List<T>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchTableName">Name of the table is searched on</param>
        /// <param name="objectList">Object list is used to be a data source for search</param>        
        /// <param name="module">Module the screen belongs to</param>
        /// <param name="allowMultipleSelect">A value indicates whether the screen allows multiple selection</param>
        /// <param name="groupColumnNames">Grouped column name colection which the gridview is grouped by</param>
        public guiFind(string searchTableName, IList<T> objectList, BaseModule module, bool allowMultipleSelect, bool showData, string[] groupedColumnNames)
        {
            InitializeComponent();

            SearchTableName = searchTableName;
            ObjectList = objectList;
            //this.searchObjectList = objectList;
            Module = module;
            AllowMultipleSelect = allowMultipleSelect;
            SelectedObjects = new List<T>();
            ShowData = showData;
            GroupedColumnNames = groupedColumnNames;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchTableName">Name of the table is searched on</param>
        /// <param name="objectList">Object list is used to be a data source for search</param>        
        /// <param name="module">Module the screen belongs to</param>
        /// <param name="allowMultipleSelect">A value indicates whether the screen allows multiple selection</param>
        /// <param name="groupColumnNames">Grouped column name colection which the gridview is grouped by</param>
        public guiFind(string searchTableName, IList<T> objectList, BaseModule module, bool allowMultipleSelect, bool showData, string[] groupedColumnNames, string[] addColumnNames)
        {
            InitializeComponent();

            SearchTableName = searchTableName;
            ObjectList = objectList;
            this.searchObjectList = objectList;
            Module = module;
            AllowMultipleSelect = allowMultipleSelect;
            SelectedObjects = new List<T>();
            ShowData = showData;
            GroupedColumnNames = groupedColumnNames;
            AddColumnNames = addColumnNames;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchTableName">Name of the table is searched on</param>
        /// <param name="objectList">Object list is used to be a data source for search</param>        
        /// <param name="module">Module the screen belongs to</param>
        /// <param name="allowMultipleSelect">A value indicates whether the screen allows multiple selection</param>
        /// <param name="groupColumnNames">Grouped column name colection which the gridview is grouped by</param>
        public guiFind(string searchTableName, IList<T> objectList, BaseModule module, bool allowMultipleSelect, bool showData, string[] groupedColumnNames, string[] addColumnNames, bool isRoundWood)
        {
            InitializeComponent();

            SearchTableName = searchTableName;
            ObjectList = objectList;
            Module = module;
            AllowMultipleSelect = allowMultipleSelect;
            SelectedObjects = new List<T>();
            this.searchObjectList = objectList;
            ShowData = showData;
            GroupedColumnNames = groupedColumnNames;
            AddColumnNames = addColumnNames;
            IsRoundWood = isRoundWood;
        }
        private void guiFind_Load(object sender, EventArgs e)
        {
            //Init the result grid control
            string gridName = GridControlName;
            if (string.IsNullOrEmpty(gridName))
            {
                gridName = SearchTableName;
            }
            if (MessageInfo != string.Empty)
            {
                fld_lblMessageInfo.Text = MessageInfo;
            }
            GridControlResult = BOSGridControl.Instance(gridName, this.Module.Name);
            GridControlResult.Name = "fld_dgc" + SearchTableName;
            GridControlResult.Screen = this;
            GridControlResult.BOSDataSource = SearchTableName;
            GridControlResult.Width = fld_pnlMainGroup.Width - 10;
            GridControlResult.Height = fld_pnlMainGroup.Height - 50;
            GridControlResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            GridControlResult.TabIndex = 0;
            GridControlResult.InitializeControl();

            //Init the grid view of the result grid control
            GridView gridView = (GridView)GridControlResult.MainView;
            if (AllowMultipleSelect)
            {
                if (gridView.Columns["Selected"] != null)
                {
                    gridView.Columns["Selected"].OptionsColumn.AllowEdit = true;
                }
                else
                {
                    GridColumn column = new GridColumn();
                    column.Caption = BaseLocalizedResources.Select;
                    column.FieldName = "Selected";
                    column.OptionsColumn.AllowEdit = true;
                    gridView.Columns.Insert(0, column);
                    column.VisibleIndex = 0;
                    fld_chkSelectAll.Visible = true;
                }
                GridControlResult.Height = GridControlResult.Height - 30;
            }
            gridView.OptionsView.ShowAutoFilterRow = true;//dòng autofilter để nhập trực tiếp
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanging);

            if (GroupedColumnNames != null && GroupedColumnNames.Length != 0)
            {
                foreach (string columnName in GroupedColumnNames)
                {
                    string caption = "";
                    GridColumn column = gridView.Columns[columnName];
                    if (column != null)
                    {
                        AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
                        AAColumnAliasInfo objColumnAliasInfo = BOSApp.LstColumnAlias.Where(a => a.AAColumnAliasName == columnName).FirstOrDefault();
                        if (objColumnAliasInfo != null)
                            caption = objColumnAliasInfo.AAColumnAliasCaption;
                        if (caption != string.Empty)
                            column.Caption = caption;
                        column.Group();
                    }
                    else
                    {

                        AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
                        AAColumnAliasInfo objColumnAliasInfo = BOSApp.LstColumnAlias.Where(a => a.AAColumnAliasName == columnName).FirstOrDefault();
                        if (objColumnAliasInfo != null)
                            caption = objColumnAliasInfo.AAColumnAliasCaption;
                        column = new GridColumn();
                        if (caption != string.Empty)
                            column.Caption = caption;
                        column.FieldName = columnName;
                        column.OptionsColumn.AllowEdit = false;
                        gridView.Columns.Add(column);
                        column.Group();
                    }
                }
            }
            if (AddColumnNames != null && AddColumnNames.Length != 0)
            {
                GridColumn column = new GridColumn();
                int visibleIndex = 1;
                foreach (string columnName in AddColumnNames)
                {
                    string caption = "";
                    AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
                    AAColumnAliasInfo objColumnAliasInfo = BOSApp.LstColumnAlias.Where(a => a.AAColumnAliasName == columnName).FirstOrDefault();
                    if (objColumnAliasInfo != null)
                        caption = objColumnAliasInfo.AAColumnAliasCaption;

                    column = new GridColumn();
                    if (caption != string.Empty)
                        column.Caption = caption;
                    column.FieldName = columnName;
                    column.OptionsColumn.AllowEdit = false;
                    column.VisibleIndex = visibleIndex;
                    gridView.Columns.Add(column);
                    visibleIndex++;
                }
            }
            if (IsRoundWood)
            {
                GridColumn column = new GridColumn();
                column = gridView.Columns["ICReceiptItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng(M3)";
                    column.DisplayFormat.FormatString = "{0:####}";
                }

                column = gridView.Columns["ICReceiptItemWoodQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng";
                    column.DisplayFormat.FormatString = "{0:####}";
                }
                column = gridView.Columns["ICReceiptItemProductSerialNo"];
                if (column != null)
                {
                    column.Caption = "Mã đầu lóng/ mã kiện";
                }
                column = gridView.Columns["ICReceiptItemLotNo"];
                if (column != null)
                {
                    column.Caption = "Mã lô";
                }
                column = gridView.Columns["ICShipmentItemProductSerialNo"];
                if (column != null)
                {
                    column.Caption = "Mã đầu lóng/ mã kiện";
                }
                column = gridView.Columns["ICShipmentItemPackNo"];
                if (column != null)
                {
                    column.Caption = "Mã lô";
                }

                column = gridView.Columns["APInvoiceInItemProductQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng(M3)";
                    column.DisplayFormat.FormatString = "{0:####}";
                }

                column = gridView.Columns["APInvoiceInItemWoodQty"];
                if (column != null)
                {
                    column.Caption = "Số lượng";
                    column.DisplayFormat.FormatString = "{0:####}";
                }

                column = gridView.Columns["APInvoiceInItemQty1"];
                if (column != null)
                {
                    column.Caption = "Số lượng đã nhận";
                    column.DisplayFormat.FormatString = "{0:####}";
                }

                column = gridView.Columns["APInvoiceInItemReceiptedQty"];
                if (column != null)
                {
                    column.Caption = "Khối lượng đã nhận";
                    column.DisplayFormat.FormatString = "{0:####}";
                }
            }
            fld_pnlMainGroup.Controls.Add(GridControlResult);
            fld_txtFind.Tag = 0;
            if (ShowData)
            {
                SearchData(null);
            }
            gridView.ExpandAllGroups();
            RelocateGridViewColumns(ColumnArr);
        }

        public void RelocateGridViewColumns(string[] columnArr)
        {

            if (columnArr != null && columnArr.Length > 0)
            {
                GridView gridView = (GridView)GridControlResult.MainView;
                foreach (GridColumn columnedit1 in gridView.Columns)
                {
                    columnedit1.Visible = false;
                }
                GridColumn columnedit;
                int index = 1;
                foreach (string column in columnArr)
                {
                    columnedit = gridView.Columns[column];
                    if (columnedit != null)
                    {
                        columnedit.Visible = true;
                        columnedit.VisibleIndex = index++;
                    }
                    else
                    {
                        AAColumnAliasInfo objColumnAliasInfo = BOSApp.LstColumnAlias.Where(x => x.AAColumnAliasName == column).FirstOrDefault();
                        if (objColumnAliasInfo != null)
                        {

                            GridColumn columnNew = new GridColumn();
                            columnNew.Caption = objColumnAliasInfo.AAColumnAliasCaption;
                            columnNew.FieldName = column;
                            columnNew.OptionsColumn.AllowEdit = false;
                            columnNew.VisibleIndex = index++;
                            gridView.Columns.Add(columnNew);
                        }
                    }
                }

                gridView.BestFitColumns();
            }

        }
        void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)GridControlResult.MainView;
            if (e.Column.FieldName == "Selected")
            {
                T obj = (T)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {

                    if (e.Value != null)
                    {
                        bool bvalue = false;
                        bool.TryParse(e.Value.ToString(), out bvalue);
                        obj.Selected = bvalue;
                    }
                }

            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ChooseObjects();
        }

        private void fld_lblSearch_Click(object sender, EventArgs e)
        {
            SearchData(fld_txtFind.Text);
        }

        private void fld_txtFind_Click(object sender, EventArgs e)
        {
            int tag = int.Parse(fld_txtFind.Tag.ToString());
            if (tag == 0)
                fld_txtFind.Text = String.Empty;
            fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
        }

        private void fld_txtFind_Leave(object sender, EventArgs e)
        {
            int tag = int.Parse(fld_txtFind.Tag.ToString());
            if (String.IsNullOrEmpty(fld_txtFind.Text) || tag == 0)
            {
                fld_txtFind.Text = BaseLocalizedResources.TypeKeyWordMessage;
                fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
                fld_txtFind.Tag = 0;
            }
            else
            {
                fld_txtFind.Tag = 1;
                fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void fld_txtFind_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int tag = int.Parse(fld_txtFind.Tag.ToString());
            if (!String.IsNullOrEmpty(fld_txtFind.Text))
            {
                fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
                fld_txtFind.Tag = 1;
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                keyWord = fld_txtFind.Text;
            SearchData(keyWord);
        }

        /// <summary>
        /// Check existence of keyword in each row
        /// </summary>
        protected bool IsExistKeyWord(String value, String keyWord)
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

        /// <summary>
        /// Search data to show on gridview
        /// </summary>
        protected void SearchData(String keyWord)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)GridControlResult.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                BOSList<BusinessObject> lstObject = new BOSList<BusinessObject>();
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
                List<T> bindingList = new List<T>();

                //Bind object list to grid for searching
                GridControlResult.DataSource = ObjectList;
                GridControlResult.RefreshDataSource();

                for (int i = 0; i < ObjectList.Count; i++)
                {
                    T obj = ObjectList[i];
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
                GridControlResult.DataSource = bindingList;
                GridControlResult.RefreshDataSource();
                gridView.ExpandAllGroups();
            }
            else
            {
                GridControlResult.DataSource = ObjectList;
                GridControlResult.RefreshDataSource();
            }
        }

        private void fld_btnSelect_Click(object sender, EventArgs e)
        {
            ChooseObjects();
        }

        /// <summary>
        /// Called when user selected objects. The formed will be closed
        /// and let user continue
        /// </summary>
        private void ChooseObjects()
        {
            GridView gridView = (GridView)GridControlResult.MainView;
            bool isSelected = false;
            if (!AllowMultipleSelect)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    T obj = (T)gridView.GetRow(gridView.FocusedRowHandle);
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    String primaryColumn = BOSApp.GetTablePrimaryColumn(SearchTableName);
                    int objectID = dbUtil.GetPropertyIntValue(obj, primaryColumn);
                    if (Owner != null)
                        dbUtil.SetPropertyValue(Owner, "EditValue", objectID);
                    else
                        this.Tag = objectID;
                    obj.Selected = true;
                    isSelected = true;
                    SelectedObjects.Clear();
                    SelectedObjects.Add(obj);
                }
            }
            else
            {
                if (!AllowMultipleSelect && gridView.FocusedRowHandle >= 0)
                {
                    T obj = (T)gridView.GetRow(gridView.FocusedRowHandle);
                    obj.Selected = true;
                }

                SelectedObjects.Clear();
                foreach (T obj in ObjectList)
                {
                    if (obj.Selected)
                    {
                        SelectedObjects.Add(obj);
                        isSelected = true;
                    }
                }
            }

            bool isValid = ((BaseModuleERP)Module).CheckSelectedSearchObjects(SearchTableName, SelectedObjects);
            if (!isValid)
            {
                return;
            }

            if (!isSelected)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!isFilterChecked)
            {
                List<T> objects = (List<T>)GridControlResult.DataSource;
                foreach (T obj in objects)
                {
                    obj.Selected = fld_chkSelectAll.Checked;
                }
                GridControlResult.RefreshDataSource();
            }
            else
            {
                CheckedAllByFilterCondition(fld_chkSelectAll.Checked);
                GridControlResult.RefreshDataSource();
            }
        }
        //TNDLoc [ADD][2015/05/21][Checked all by Filter Condition],START
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)GridControlResult.MainView;
            List<T> listView = new List<T>();
            List<T> objects = (List<T>)GridControlResult.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                T objDataViewPermissionsInfo = (T)gridView.GetRow(j);
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

        public guiFind(string searchTableName, IList<T> objectList, BaseModule module, bool allowMultipleSelect, bool showData, string[] groupedColumnNames, bool isFilterCheck, bool isRoundWood)
        {
            InitializeComponent();

            SearchTableName = searchTableName;
            ObjectList = objectList;
            Module = module;
            AllowMultipleSelect = allowMultipleSelect;
            SelectedObjects = new List<T>();
            ShowData = showData;
            GroupedColumnNames = groupedColumnNames;
            isFilterChecked = isFilterCheck;
            IsRoundWood = isRoundWood;
        }
        //TNDLoc [ADD][2015/05/21][Checked all by Filter Condition],END
    }
}
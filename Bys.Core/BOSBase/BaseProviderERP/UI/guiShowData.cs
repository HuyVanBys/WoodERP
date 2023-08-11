using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiShowData<T> : BOSERPScreen where T : BusinessObject
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
        #endregion

        public guiShowData()
        {
            InitializeComponent();
        }


        public guiShowData(string searchTableName, IList<T> objectList, BaseModule module, string screenName)
        {
            InitializeComponent();

            SearchTableName = searchTableName;
            ObjectList = objectList;
            Module = module;

            SelectedObjects = new List<T>();
            this.Text = screenName;
        }


        private void guiShowData_Load(object sender, EventArgs e)
        {
            //Init the result grid control
            string gridName = GridControlName;
            if (string.IsNullOrEmpty(gridName))
            {
                gridName = SearchTableName;
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

            gridView.OptionsView.ShowAutoFilterRow = true;//dòng autofilter để nhập trực tiếp


            if (GroupedColumnNames != null && GroupedColumnNames.Length != 0)
            {
                foreach (string columnName in GroupedColumnNames)
                {
                    string caption = "";
                    GridColumn column = gridView.Columns[columnName];
                    if (column != null)
                    {
                        AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
                        AAColumnAliasInfo objColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectByName(columnName);
                        if (objColumnAliasInfo != null)
                            caption = objColumnAliasInfo.AAColumnAliasCaption;
                        if (caption != string.Empty)
                            column.Caption = caption;
                        column.Group();
                    }
                    else
                    {

                        AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
                        AAColumnAliasInfo objColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectByName(columnName);
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
                    AAColumnAliasInfo objColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectByName(columnName);
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

            fld_pnlMainGroup.Controls.Add(GridControlResult);

            gridView.ExpandAllGroups();
        }




        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }





    }
}
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiChooseColor<T> : BOSERPScreen where T : BusinessObject
    {
        private GridControlHelper GridControlHelper;
        public IList<T> SelectedObjects { get; set; }
        private String SearchTableName;

        /// <summary>
        /// List of objects is used to bind to the search grid control        
        /// </summary>
        private IList<T> ObjectList;

        public string[] ColumnArr;
        public guiChooseColor()
        {
            InitializeComponent();
        }
        public guiChooseColor(string searchTableName, IList<T> objectList, BaseModule module)
        {
            InitializeComponent();
            SearchTableName = searchTableName;
            ObjectList = objectList;
            Module = module;
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

        private void guiChooseColor_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcData.Screen = this;
            fld_dgcData.BOSDataSource = SearchTableName;
            fld_dgcData.TabIndex = 0;
            fld_dgcData.InitializeControl();

            //Init the grid view of the result grid control
            GridView gridView = (GridView)fld_dgcData.MainView;
            //if (gridView.Columns["Selected"] != null)
            //{
            //    gridView.Columns["Selected"].OptionsColumn.AllowEdit = true;
            //}
            //else
            //{
            //    GridColumn column = new GridColumn();
            //    column.Caption = BaseLocalizedResources.Select;
            //    column.FieldName = "Selected";
            //    column.OptionsColumn.AllowEdit = true;
            //    gridView.Columns.Insert(0, column);
            //    column.VisibleIndex = 0;
            //}
            RelocateGridViewColumns(ColumnArr);
            fld_dgcData.DataSource = ObjectList;
            fld_dgcData.RefreshDataSource();
            
            GridControlHelper = new GridControlHelper(gridView);
        }
        public void RelocateGridViewColumns(string[] columnArr)
        {

            if (columnArr != null && columnArr.Length > 0)
            {
                GridView gridView = (GridView)fld_dgcData.MainView;
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
        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<T>().ToList();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

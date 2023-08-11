using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class guiChooseProducts : BOSERPScreen
    {
        #region Private variables
        /// <summary>
        /// The grid control contains search result
        /// </summary>
        private BOSGridControl GridControlResult;

        /// <summary>
        /// List of objects is used to bind to the search grid control        
        /// </summary>
        private IList<ICProductsInfo> ObjectList;

        /// <summary>
        /// Gets or sets the list of selected objects
        /// </summary>
        public IList<ICProductsInfo> SelectedObjects { get; set; }

        private string SearchTableName;


        #endregion

        private bool hasChangedValue = true;

        public guiChooseProducts(string searchTableName)
        {
            InitializeComponent();
            SelectedObjects = new List<ICProductsInfo>();
            SearchTableName = searchTableName;
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

        private void guiChooseProducts_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitializeBosGridControl();
            GetAllProducts();
        }

        private void fld_btnOk_Click(object sender, EventArgs e)
        {
            ChooseObjects();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GetAllProducts()
        {
            if (hasChangedValue)
            {
                bool isShowAll = fld_chkSelectAllDeposits.Checked;
                ObjectList = ((ProductModule)Module).GetAllProducts(isShowAll);
                hasChangedValue = false;
            }

            String keyWord = String.Empty;
            if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                keyWord = fld_txtFind.Text;
            SearchData(keyWord);

        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void fld_chkSelectAllDeposits_CheckedChanged(object sender, EventArgs e)
        {
            hasChangedValue = true;
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
                    if (gridView.Columns[i].VisibleIndex >= 0)
                        lstColVisible.Add(gridView.Columns[i]);
                }
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<ICProductsInfo> bindingList = new List<ICProductsInfo>();

                //Bind object list to grid for searching
                GridControlResult.DataSource = ObjectList;
                GridControlResult.RefreshDataSource();

                for (int i = 0; i < ObjectList.Count; i++)
                {
                    ICProductsInfo obj = ObjectList[i];
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
            }
            else
            {
                GridControlResult.DataSource = ObjectList;
                GridControlResult.RefreshDataSource();
            }

            gridView.ExpandAllGroups();
        }


        private void InitializeBosGridControl()
        {
            //Init the result grid control
            string gridName = SearchTableName;
            //if (string.IsNullOrEmpty(gridName))
            //{
            //    gridName = SearchTableName;
            //}
            GridControlResult = BOSGridControl.Instance(gridName, this.Module.Name);
            GridControlResult.Name = "fld_dgc" + SearchTableName;
            GridControlResult.Screen = this;
            GridControlResult.BOSDataSource = SearchTableName;
            GridControlResult.Width = fld_Line2.Width;
            GridControlResult.Height = fld_Line2.Height;
            GridControlResult.Margin = new Padding(0, 20, 0, 0);
            GridControlResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            GridControlResult.InitializeControl();

            //Init the grid view of the result grid control
            GridView gridView = (GridView)GridControlResult.MainView;
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            fld_Line2.Controls.Add(GridControlResult);
            fld_txtFind.Tag = 0;

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

        /// <summary>
        /// Called when user selected objects. The formed will be closed
        /// and let user continue
        /// </summary>
        private void ChooseObjects()
        {
            GridView gridView = (GridView)GridControlResult.MainView;
            bool isSelected = false;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductsInfo obj = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                obj.Selected = true;
            }

            SelectedObjects.Clear();
            foreach (ICProductsInfo obj in ObjectList)
            {
                if (obj.Selected)
                {
                    SelectedObjects.Add(obj);
                    isSelected = true;
                }
            }

            bool isValid = ((BaseModuleERP)Module).CheckSelectedSearchObjects(SearchTableName, SelectedObjects);
            if (!isValid)
            {
                return;
            }

            if (gridView.FocusedRowHandle >= 0)
            {
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
        }
    }

}
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class guiChoosePayRollColumn : BOSERPScreen
    {
        #region Variables
        public List<AAPayRollColumnAliasInfo> SelectedObjects { get; set; }

        public List<AAPayRollColumnAliasInfo> PayRollColumns { get; set; }
        #endregion

        public guiChoosePayRollColumn(List<AAPayRollColumnAliasInfo> payRollColumns)
        {
            InitializeComponent();
            PayRollColumns = payRollColumns;
        }

        private void guiChoosePayRollColumn_Load_1(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<AAPayRollColumnAliasInfo>();
            fld_dgcAAPayRollColumnAlias.InvalidateDataSource(PayRollColumns);
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = PayRollColumns.Where(o => o.Selected).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcAAPayRollColumnAlias.MainView;
            List<AAPayRollColumnAliasInfo> listView = new List<AAPayRollColumnAliasInfo>();
            BindingSource bds = (BindingSource)fld_dgcAAPayRollColumnAlias.DataSource;

            List<AAPayRollColumnAliasInfo> objects = (List<AAPayRollColumnAliasInfo>)bds.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                AAPayRollColumnAliasInfo objPayRollColumnAliasInfo = (AAPayRollColumnAliasInfo)gridView.GetRow(j);
                if (objPayRollColumnAliasInfo != null)
                {
                    listView.Add(objPayRollColumnAliasInfo);
                }
            }
            for (int i = 0; i < objects.Count; i++)
            {
                foreach (var dataViewItem in listView)
                {
                    if (objects[i] == dataViewItem)
                    {
                        objects[i].Selected = fld_chkSelectedAll.Checked;
                    }
                }
            }
            fld_dgcAAPayRollColumnAlias.RefreshDataSource();
        }
    }
}
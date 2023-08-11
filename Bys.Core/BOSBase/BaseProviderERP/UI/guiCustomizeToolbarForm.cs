using BOSLib;
using System;
using System.Data;

namespace BOSERP
{
    public partial class guiCustomizeToolbarForm : BOSERPScreen
    {
        private BOSList<STToolbarsInfo> lstMainFormToolbar;

        public guiCustomizeToolbarForm()
        {
            InitializeComponent();
            lstMainFormToolbar = new BOSList<STToolbarsInfo>();
            CustomizeMainFormToolbar();
        }

        private void CustomizeMainFormToolbar()
        {
            STToolbarsController objToolbarsController = new STToolbarsController();
            DataSet ds = objToolbarsController.GetMainToolbar();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                STToolbarsInfo objToolbarsInfo = (STToolbarsInfo)objToolbarsController.GetObjectFromDataRow(row);
                lstMainFormToolbar.Add(objToolbarsInfo);
            }

            fld_dgvMainFormToolbar.OptionsView.ShowGroupPanel = false;
            fld_dgcMainFormToolbar.DataSource = lstMainFormToolbar;
            fld_dgvMainFormToolbar.RefreshData();
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            STToolbarsController objToolbarsController = new STToolbarsController();

            foreach (STToolbarsInfo objToolbarsInfo in lstMainFormToolbar)
            {
                objToolbarsController.UpdateObject(objToolbarsInfo);
            }

            BOSApp.InitToolbarOfMainForm();
            this.Close();
        }

    }
}
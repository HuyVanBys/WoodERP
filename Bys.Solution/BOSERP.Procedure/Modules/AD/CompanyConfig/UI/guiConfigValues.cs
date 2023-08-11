using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using BOSLib;

namespace BOSERP.Modules.CompanyConfig
{
    public partial class guiConfigValues : BOSERPScreen
    {
        BindingList<ADConfigValuesInfo> lstADConfigValuesInfo = new BindingList<ADConfigValuesInfo>();
        int iDeletedRowHandle = -1;
        public guiConfigValues()
        {
            InitializeComponent();
        }

        private void InitADConfigValuesList()
        {
            ADConfigValuesController objADConfigValuesController = new ADConfigValuesController();
            DataSet dsConfigValues = objADConfigValuesController.GetAllObjects();
            if (dsConfigValues.Tables.Count > 0)
            {
                foreach (DataRow rowADConfigValue in dsConfigValues.Tables[0].Rows)
                {
                    ADConfigValuesInfo objADConfigValuesInfo = (ADConfigValuesInfo)objADConfigValuesController.GetObjectFromDataRow(rowADConfigValue);
                    if (String.IsNullOrEmpty(objADConfigValuesInfo.ADConfigKeyDesc))
                        objADConfigValuesInfo.ADConfigKeyDesc = objADConfigValuesInfo.ADConfigKey;

                    lstADConfigValuesInfo.Add(objADConfigValuesInfo);
                }
            }
        }

        private void guiConfigValues_Load(object sender, EventArgs e)
        {
            InitADConfigValuesList();
            
            fld_dgcADConfigValues.DataSource = lstADConfigValuesInfo;
        }

        private void fld_dgvADConfigValues_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            iDeletedRowHandle = e.FocusedRowHandle;
            if (e.FocusedRowHandle >= 0)
            {
                colADConfigKeyDesc.OptionsColumn.AllowEdit = false;
                colADConfigKeyGroup.OptionsColumn.AllowEdit = false;
            }
            else
            {
                colADConfigKeyDesc.OptionsColumn.AllowEdit = true;
                colADConfigKeyGroup.OptionsColumn.AllowEdit = true;
            }
        }

        public void SaveConfigValues()
        {
            ADConfigValuesController objADConfigValuesController = new ADConfigValuesController();
            foreach (ADConfigValuesInfo objADConfigValuesInfo in lstADConfigValuesInfo)
            {

                int iADConfigValues = objADConfigValuesInfo.ADConfigValueID;
                if (iADConfigValues > 0)
                {
                    objADConfigValuesController.UpdateObject(objADConfigValuesInfo);
                }
                else
                {
                    objADConfigValuesInfo.ADConfigValueID = objADConfigValuesController.CreateObject(objADConfigValuesInfo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveConfigValues();
            MessageBox.Show("Saved successfully!", "#Message#");
        }

        private void fld_dgvADConfigValues_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //DataRow newRow = fld_dgvADConfigValues.GetDataRow(e.RowHandle);
            //newRow["ADConfigValueID"] = 0;
            //String strADConfigValueText=fld_dgvADConfigValues.GetRowCellValue(e.RowHandle,colADConfigText).ToString();
            //Debug.WriteLine(strADConfigValueText);
        }

        private void fld_dgvADConfigValues_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (iDeletedRowHandle >= 0)
                {
                    ADConfigValuesController objADConfigValuesController = new ADConfigValuesController();
                    int iADConfigValueID = Convert.ToInt32(fld_dgvADConfigValues.GetRowCellValue(iDeletedRowHandle, colADConfigValueID));
                    fld_dgvADConfigValues.DeleteRow(iDeletedRowHandle);
                    objADConfigValuesController.DeleteObject(iADConfigValueID);
                    MessageBox.Show("Deleted successfully!", "#Message#");
                }
                else
                {
                    MessageBox.Show("Can not delete this row!", "#Message#");
                }
            }
        }

        private void fld_dgvADConfigValues_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            
        }
    }
}
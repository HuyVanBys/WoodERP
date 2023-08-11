using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;

namespace BOSERP.Modules.CompanyConfig
{
    public partial class guiConfigurationNumbering : BOSERPScreen
    {
        private DataTable tblNumberingModus = new DataTable();
        private DataTable tblModule = new DataTable();
        DataSet dsGENumberings = new DataSet();
        public guiConfigurationNumbering()
        {
            InitializeComponent();
            InitNumberingModusColumn();
            InitNumberingNameColumn();
            AddNumberingToGrid(fld_dgcNumbering);
        }

        #region Utility Functions
        private void InitNumberingModusColumn()
        {
            tblNumberingModus.TableName = "Modus";

            DataColumn columnModusNumber = new DataColumn();
            columnModusNumber.ColumnName = "Number";
            columnModusNumber.DataType = typeof(int);
            tblNumberingModus.Columns.Add(columnModusNumber);

            DataColumn columnModusText = new DataColumn();
            columnModusText.ColumnName = "Text";
            columnModusText.DataType = typeof(String);
            tblNumberingModus.Columns.Add(columnModusText);

            tblNumberingModus.Rows.Add(new object[2] {0,"Automatic"});
            tblNumberingModus.Rows.Add(new object[2] {1,"Manual"});

            repItemLookupModus.DataSource = tblNumberingModus;
            repItemLookupModus.DisplayMember = "Text";
            repItemLookupModus.ValueMember = "Number";
        }

        private void InitNumberingNameColumn()
        {
            tblModule.TableName = "Module";

            DataColumn columnModuleName = new DataColumn();
            columnModuleName.ColumnName = "Name";
            columnModuleName.DataType = typeof(string);
            tblModule.Columns.Add(columnModuleName);

            DataColumn columnModuleDesc = new DataColumn();
            columnModuleDesc.ColumnName = "Desc";
            columnModuleDesc.DataType = typeof(string);
            tblModule.Columns.Add(columnModuleDesc);

            DataSet dsModules = new STModulesController().GetAllObjects();
            foreach (DataRow rowModule in dsModules.Tables[0].Rows)
            {
                STModulesInfo objSTModulesInfo = (STModulesInfo)new STModulesController().GetObjectFromDataRow(rowModule);
                if (objSTModulesInfo != null)
                {
                    
                    String strModuleDesc = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(objSTModulesInfo.STModuleName, BOSApp.CurrentLang);
                    if (!String.IsNullOrEmpty(strModuleDesc))
                    {
                        tblModule.Rows.Add(new object[2] { objSTModulesInfo.STModuleName, strModuleDesc });
                    }
                    
                }
            }

            repItemLookupModuleName.DataSource = tblModule;
            repItemLookupModuleName.DisplayMember = "Desc";
            repItemLookupModuleName.ValueMember = "Name";
        }

        private void AddNumberingToGrid(DevExpress.XtraGrid.GridControl gridControl)
        {
            GENumberingController objGENumberingController = new GENumberingController();
            dsGENumberings = objGENumberingController.GetAllObjects();
            gridControl.DataSource = dsGENumberings.Tables[0];            
        }

       
        #endregion

        private void fld_dgvNumbering_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = fld_dgvNumbering.GetDataRow(e.RowHandle);
            GENumberingController objGENumberingController = new GENumberingController();
            row[0] = objGENumberingController.GetMaxID();
            row["GENumberingModus"] = 0;

        }

        private void fld_dgvNumbering_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
           
            
        }

        private void guiConfigurationNumbering_Load(object sender, EventArgs e)
        {

        }

        //private void fld_dgvNumbering_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    try
        //    {
        //        if (e.Column == colGENumberingLength)
        //        {
        //            int iLength = Convert.ToInt32(e.Value);
        //            if (iLength > 9)
        //            {
        //                MessageBox.Show("Numbering must less than 9", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                fld_dgvNumbering.SetRowCellValue(e.RowHandle, colGENumberingLength, 9);
        //            }
        //        }
        //        if (e.Column == colGENumberingStart)
        //        {
        //            object objLength = fld_dgvNumbering.GetRowCellValue(e.RowHandle, colGENumberingLength);                   
        //            bool isError = true;

        //            int iLength = Convert.ToInt32(objLength);
        //            int iNumberingStart = Convert.ToInt32(e.Value);
        //            int iMaxValue = GetMaxValueByLength(iLength);
        //            int iMinValue = GetMinValueByLength(iLength);
        //            if (iNumberingStart >= iMinValue && iNumberingStart <= iMaxValue)
        //                isError = false;
        //            if (isError)
        //            {
        //                MessageBox.Show(String.Format("Numbering must be between {0} and {1}", iMinValue, iMaxValue), "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                fld_dgvNumbering.SetRowCellValue(e.RowHandle, e.Column, GetCurrentNumberingStart(fld_dgvNumbering.GetRowCellValue(e.RowHandle, colGENumberingName).ToString(), iLength));
        //                fld_dgvNumbering.FocusedRowHandle = e.RowHandle;
        //                fld_dgvNumbering.FocusedColumn = colGENumberingStart;
        //            }                   
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Input Length first", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        fld_dgvNumbering.FocusedRowHandle = e.RowHandle;
        //        fld_dgvNumbering.FocusedColumn = colGENumberingLength;
        //    }
            
        //}

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GENumberingController objGENumberingController = new GENumberingController();            
            foreach (DataRow rowGENumbering in dsGENumberings.Tables[0].Rows)
            {
                GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectFromDataRow(rowGENumbering);
                if (objGENumberingInfo != null)
                {
                    if (objGENumberingController.IsExist(objGENumberingInfo.GENumberingID))
                    {
                        objGENumberingController.UpdateObject(objGENumberingInfo);
                    }
                    else
                    {
                        objGENumberingController.CreateObject(objGENumberingInfo);
                    }
                }
            }

            MessageBox.Show("Save Sucessfully","#Message#",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConfig
{
    public partial class guiConfigFiscalYear : BOSERPScreen
    {
        #region Variables
       
        Boolean bMustMoveToPreviousRow = false;
        BindingList<GEFiscalPeriodsInfo> lstGEFiscalPeriodsInfo = new BindingList<GEFiscalPeriodsInfo>();
        #endregion


        #region Constructor
        public guiConfigFiscalYear()
        {
            InitializeComponent();

        }
        #endregion

        #region Utility functions

        private void InitFiscalPeriodStatusColumn()
        {
            repItemGEFiscalPeriodStatus.Items.Add("Unlock");
            repItemGEFiscalPeriodStatus.Items.Add("Lock");
        }

        private void InitFiscalYears()
        {
            int iMaxFiscalYear = GetMaxFiscalYear();

            if (iMaxFiscalYear == 0)
            {
                fld_txtFiscalYear.Text = "0000";
                fld_btnSave.Enabled = false;
            }
            else
            {
                fld_txtFiscalYear.Text = iMaxFiscalYear.ToString();
                fld_btnSave.Enabled = true;

                GEFiscalYearsController objGEFiscalYearsController = new GEFiscalYearsController();
                GEFiscalYearsInfo objGEFiscalYearsInfo = (GEFiscalYearsInfo)objGEFiscalYearsController.GetObjectByNo(iMaxFiscalYear.ToString());

                InitFiscalPeriods(objGEFiscalYearsInfo.GEFiscalYearID);

            }
        }

        private void InitFiscalPeriods(int iFiscalYearID)
        {
            
                GEFiscalPeriodsController objGEFiscalPeriodsController = new GEFiscalPeriodsController();
                DataSet dsFiscalPeriods = objGEFiscalPeriodsController.GetAllDataByForeignColumn("FK_GEFiscalYearID", iFiscalYearID);
                foreach (DataRow rowGEFiscalPeriods in dsFiscalPeriods.Tables[0].Rows)
                {
                    GEFiscalPeriodsInfo objGEFiscalPeriodsInfo = (GEFiscalPeriodsInfo)objGEFiscalPeriodsController.GetObjectFromDataRow(rowGEFiscalPeriods);
                    lstGEFiscalPeriodsInfo.Add(objGEFiscalPeriodsInfo);
                }
                fld_dgcGEFiscalPeriods.DataSource = lstGEFiscalPeriodsInfo;
        }


        public void SaveFiscalPeriods(int iFKFiscalYearID)
        {
            GEFiscalPeriodsController objGEFiscalPeriodsController = new GEFiscalPeriodsController();
            foreach (GEFiscalPeriodsInfo objGEFiscalPeriodsInfo in lstGEFiscalPeriodsInfo)
            {
                objGEFiscalPeriodsInfo.FK_GEFiscalYearID = iFKFiscalYearID;
                int iFiscalPeriodsID = objGEFiscalPeriodsInfo.GEFiscalPeriodID;
                if (iFiscalPeriodsID > 0)
                    objGEFiscalPeriodsController.UpdateObject(objGEFiscalPeriodsInfo);
                else
                    objGEFiscalPeriodsInfo.GEFiscalPeriodID = objGEFiscalPeriodsController.CreateObject(objGEFiscalPeriodsInfo);
            }
        }

        public void SaveFiscalYears(string strFiscalYearNo,ref int iFiscalYearID)
        {

            GEFiscalYearsController objGEFiscalYearsController = new GEFiscalYearsController();
            GEFiscalYearsInfo objGEFiscalYearsInfo = (GEFiscalYearsInfo) objGEFiscalYearsController.GetObjectByNo(strFiscalYearNo);
            if (objGEFiscalYearsInfo != null)
            {
                objGEFiscalYearsController.DeleteObject(objGEFiscalYearsInfo.GEFiscalYearID);
     
                objGEFiscalYearsInfo.GEFiscalYearNo = strFiscalYearNo;
                objGEFiscalYearsInfo.AAStatus = "Alive";
                objGEFiscalYearsInfo.GEFiscalYearID = objGEFiscalYearsController.CreateObject(objGEFiscalYearsInfo);
                iFiscalYearID = objGEFiscalYearsInfo.GEFiscalYearID;

            }
            else
            {
                GEFiscalYearsInfo objGEFiscalYearsInfo2 = new GEFiscalYearsInfo();
                objGEFiscalYearsInfo2.GEFiscalYearNo = strFiscalYearNo;
                objGEFiscalYearsInfo2.AAStatus = "Alive";
                objGEFiscalYearsInfo2.GEFiscalYearID = objGEFiscalYearsController.CreateObject(objGEFiscalYearsInfo2);
                iFiscalYearID = objGEFiscalYearsInfo2.GEFiscalYearID;
            }
        }


        private DateTime GetCurrentDateFrom(int iRowHandle)
        {
            DateTime temp = new DateTime();
            GEFiscalPeriodsController objGEFiscalPeriodsController = new GEFiscalPeriodsController();
            int iFiscalPeriodID = Convert.ToInt32(fld_dgvGEFiscalPeriods.GetRowCellValue(iRowHandle, colGEFiscalPeriodID));
            GEFiscalPeriodsInfo objGEFiscalPeriodsInfo = (GEFiscalPeriodsInfo)objGEFiscalPeriodsController.GetObjectByID(iFiscalPeriodID);
            temp = objGEFiscalPeriodsInfo.GEFiscalPeriodDateFrom;
            return temp;
        }

        private DateTime GetCurrentDateTo(int iRowHandle)
        {
            DateTime temp = new DateTime();
            GEFiscalPeriodsController objGEFiscalPeriodsController = new GEFiscalPeriodsController();
            int iFiscalPeriodID = Convert.ToInt32(fld_dgvGEFiscalPeriods.GetRowCellValue(iRowHandle, colGEFiscalPeriodID));
            GEFiscalPeriodsInfo objGEFiscalPeriodsInfo = (GEFiscalPeriodsInfo)objGEFiscalPeriodsController.GetObjectByID(iFiscalPeriodID);
            temp = objGEFiscalPeriodsInfo.GEFiscalPeriodDateTo;
            return temp;
        }

        private int GetMaxFiscalYear()
        {
            int iMaxFiscalYear=0;
            GEFiscalYearsController objGEFiscalYearsController = new GEFiscalYearsController();
            DataSet dsFiscalYears = objGEFiscalYearsController.GetAllObjects();
            if (dsFiscalYears.Tables.Count > 0)
            {
                int iRowCount = dsFiscalYears.Tables[0].Rows.Count;
                if (iRowCount > 0)
                {
                    GEFiscalYearsInfo objGEFiscalYearsInfo = (GEFiscalYearsInfo)objGEFiscalYearsController.GetObjectFromDataRow(dsFiscalYears.Tables[0].Rows[iRowCount - 1]);
                    if (objGEFiscalYearsInfo != null)
                        iMaxFiscalYear = Convert.ToInt32(objGEFiscalYearsInfo.GEFiscalYearNo);
                }
            }

            return iMaxFiscalYear;
        }
        #endregion


        #region Event Handler functions

        private void guiConfigFiscalYear_Load(object sender, EventArgs e)
        {
            InitFiscalPeriodStatusColumn();
            InitFiscalYears();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fld_btnSave.Enabled = true;
            //Get Max Fiscal Year from database

            int iMaxFiscalYear = GetMaxFiscalYear();
            if (iMaxFiscalYear == 0)
            {
                iMaxFiscalYear = DateTime.Today.Year;
                fld_txtFiscalYear.Text = iMaxFiscalYear.ToString();
                for (int i = 1; i < 13; i++)
                {
                    GEFiscalPeriodsInfo objGEFiscalPeriodsInfo = new GEFiscalPeriodsInfo();
                    objGEFiscalPeriodsInfo.GEFiscalPeriodNo = i.ToString();
                    objGEFiscalPeriodsInfo.GEFiscalPeriodStatus = "Unlock";
                    objGEFiscalPeriodsInfo.GEFiscalPeriodDateFrom = new DateTime(iMaxFiscalYear, i, 1);
                    objGEFiscalPeriodsInfo.GEFiscalPeriodDateTo = new DateTime(iMaxFiscalYear, i, DateTime.DaysInMonth(iMaxFiscalYear, i));

                    lstGEFiscalPeriodsInfo.Add(objGEFiscalPeriodsInfo);
                }
                fld_dgcGEFiscalPeriods.DataSource = lstGEFiscalPeriodsInfo;
                int iFK_FiscalYearID = -1;
                SaveFiscalYears(iMaxFiscalYear.ToString(), ref iFK_FiscalYearID);
                SaveFiscalPeriods(iFK_FiscalYearID);
            }
            else
            {
                iMaxFiscalYear++;
                fld_txtFiscalYear.Text = iMaxFiscalYear.ToString();
                for (int i = 0; i < lstGEFiscalPeriodsInfo.Count;)
                    lstGEFiscalPeriodsInfo.RemoveAt(i);
                for (int i = 1; i < 13; i++)
                {
                    GEFiscalPeriodsInfo objGEFiscalPeriodsInfo = new GEFiscalPeriodsInfo();
                    objGEFiscalPeriodsInfo.GEFiscalPeriodNo = i.ToString();
                    objGEFiscalPeriodsInfo.GEFiscalPeriodStatus = "Unlock";
                    objGEFiscalPeriodsInfo.GEFiscalPeriodDateFrom = new DateTime(iMaxFiscalYear, i, 1);
                    objGEFiscalPeriodsInfo.GEFiscalPeriodDateTo = new DateTime(iMaxFiscalYear, i, DateTime.DaysInMonth(iMaxFiscalYear, i));

                    lstGEFiscalPeriodsInfo.Add(objGEFiscalPeriodsInfo);
                }
                
                fld_dgcGEFiscalPeriods.DataSource = lstGEFiscalPeriodsInfo;
                int iFK_FiscalYearID = -1;
                SaveFiscalYears(iMaxFiscalYear.ToString(), ref iFK_FiscalYearID);
                SaveFiscalPeriods(iFK_FiscalYearID);
            }
            fld_btnSave.Enabled = true;
        }
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int iFK_FiscalYearID = -1;
            SaveFiscalYears(fld_txtFiscalYear.Text,ref iFK_FiscalYearID);
            SaveFiscalPeriods(iFK_FiscalYearID);
            
            MessageBox.Show("Save successfully!", "#Message#");
        }

        private void fld_dgvGEFiscalPeriods_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            colGEFiscalPeriodNo.OptionsColumn.AllowEdit = false;
            if (bMustMoveToPreviousRow)
            {
                bMustMoveToPreviousRow = false;
                fld_dgvGEFiscalPeriods.FocusedRowHandle = e.PrevFocusedRowHandle;
            }
        }

        private void fld_dgvGEFiscalPeriods_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DateTime dtDateFrom = Convert.ToDateTime(fld_dgvGEFiscalPeriods.GetRowCellValue(e.RowHandle,colGEFiscalPeriodDateFrom));
            DateTime dtDateUntil = Convert.ToDateTime(fld_dgvGEFiscalPeriods.GetRowCellValue(e.RowHandle,colGEFiscalPeriodDateTo));
            if (dtDateFrom.Year != Convert.ToInt32(fld_txtFiscalYear.Text) || dtDateUntil.Year != Convert.ToInt32(fld_txtFiscalYear.Text))
            {
                MessageBox.Show("The year is not correct!");
                fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle, colGEFiscalPeriodDateFrom, GetCurrentDateFrom(e.RowHandle));
                fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle, colGEFiscalPeriodDateTo, GetCurrentDateTo(e.RowHandle));
                return;
            }
            if (e.RowHandle != 0)
            {
                if (e.RowHandle == 11)
                {
                    DateTime dtPreviousDateTo = Convert.ToDateTime(fld_dgvGEFiscalPeriods.GetRowCellValue(e.RowHandle - 1, colGEFiscalPeriodDateTo));
                    if (DateTime.Compare(dtDateFrom, dtDateUntil) > 0 || DateTime.Compare(dtPreviousDateTo, dtDateFrom) > 0)
                    {
                        MessageBox.Show("The date time is wrong,Date From must be less than Date To and more than previous Date To!", "#Message#");
                        bMustMoveToPreviousRow = true;
                        int iRowHandle = e.RowHandle;
                        fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle, colGEFiscalPeriodDateFrom, GetCurrentDateFrom(iRowHandle));
                        fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle, colGEFiscalPeriodDateTo, GetCurrentDateTo(iRowHandle));
                    }
                }
                else
                {
                    DateTime dtPreviousDateTo = Convert.ToDateTime(fld_dgvGEFiscalPeriods.GetRowCellValue(e.RowHandle - 1, colGEFiscalPeriodDateTo));
                    DateTime dtNextDateFrom = Convert.ToDateTime(fld_dgvGEFiscalPeriods.GetRowCellValue(e.RowHandle + 1, colGEFiscalPeriodDateFrom));
                    if (DateTime.Compare(dtDateFrom, dtDateUntil) > 0 || DateTime.Compare(dtPreviousDateTo, dtDateFrom) > 0 || DateTime.Compare(dtDateUntil, dtNextDateFrom) > 0)
                    {
                        MessageBox.Show("The date time is wrong,Date From must be less than Date To and more than previous Date To,and Date To must be less than next Date From!", "#Message#");
                        bMustMoveToPreviousRow = true;
                        int iRowHandle = e.RowHandle;
                        fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle, colGEFiscalPeriodDateFrom, GetCurrentDateFrom(iRowHandle));
                        fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle, colGEFiscalPeriodDateTo, GetCurrentDateTo(iRowHandle));
                    }
                }
                
            }
            else
            {
                DateTime dtNextDateFrom = Convert.ToDateTime(fld_dgvGEFiscalPeriods.GetRowCellValue(e.RowHandle + 1, colGEFiscalPeriodDateFrom));
                if (DateTime.Compare(dtDateFrom, dtDateUntil) > 0 || DateTime.Compare(dtDateUntil, dtNextDateFrom) > 0)
                {
                    MessageBox.Show("The date time is wrong,Date From must be less than Date To and Date To must be less than next Date From!", "#Message#");
                    bMustMoveToPreviousRow = true;
                    int iRowHandle = e.RowHandle;
                    fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle,colGEFiscalPeriodDateFrom,GetCurrentDateFrom(iRowHandle));
                    fld_dgvGEFiscalPeriods.SetRowCellValue(e.RowHandle, colGEFiscalPeriodDateTo, GetCurrentDateTo(iRowHandle));
                }
            }     
        }

        

        private void textEdit1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
      
        private void textEdit1_Validated(object sender, EventArgs e)
        {            
            int iCurrentFiscalYear = Convert.ToInt32(fld_txtFiscalYear.EditValue);

            GEFiscalYearsController objGEFiscalYearsController = new GEFiscalYearsController();
            GEFiscalYearsInfo objGEFiscalYearsInfo = (GEFiscalYearsInfo)objGEFiscalYearsController.GetObjectByNo(iCurrentFiscalYear.ToString());

            //If is not exist Fiscal Year, set Save button is not enable, return.
            if (objGEFiscalYearsInfo == null)
            {
                fld_btnSave.Enabled = false;
                for (int i = 0; i < lstGEFiscalPeriodsInfo.Count; i++)
                        fld_dgvGEFiscalPeriods.DeleteRow(i);
                for (int i = 0; i < lstGEFiscalPeriodsInfo.Count; )
                        lstGEFiscalPeriodsInfo.RemoveAt(i);
                return;
            }

            else
            {
                fld_btnSave.Enabled = true;

                for (int i = 0; i < lstGEFiscalPeriodsInfo.Count; )
                    lstGEFiscalPeriodsInfo.RemoveAt(i);
                InitFiscalPeriods(objGEFiscalYearsInfo.GEFiscalYearID);

            }

            //If Exist fiscal Year,get all fiscal periods from this fiscal year.In case of Save button is not enable, set Save button is enable






        }
        #endregion
    }
}
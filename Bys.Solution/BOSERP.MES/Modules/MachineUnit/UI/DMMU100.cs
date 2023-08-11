using BOSCommon.Constants;
using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.MachineUnit.UI
{
    /// <summary>
    /// Summary description for DMMU100
    /// </summary>
    public partial class DMMU100 : BOSERPScreen
    {

        public DMMU100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void Fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((MachineUnitModule)Module).GetDataOperation();
        }

        private void fld_lkeFK_MMLineID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int workShopID = Convert.ToInt32(fld_lkeFK_MMWorkShopID.EditValue);
            MMLinesController objLinesController = new MMLinesController();
            List<MMLinesInfo> LinesList = new List<MMLinesInfo>();
            if (workShopID != 0)
            {
                LinesList = objLinesController.GetAllAliveAndActiveLineByWorkShopID(workShopID
                                                    , BOSApp.CurrentUsersInfo.ADUserID
                                                    , ModuleName.Line
                                                    , ADDataViewPermissionType.Module
                                                    , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                LinesList.Insert(0, new MMLinesInfo());
                fld_lkeFK_MMLineID.Properties.DataSource = LinesList;
            }
            else
            {
                LinesList.Insert(0, new MMLinesInfo());
                fld_lkeFK_MMLineID.Properties.DataSource = LinesList;
            }
        }

        private void Fld_lkeFK_MMWorkShopID_QueryPopUp(object sender, CancelEventArgs e)
        {
            MMWorkShopsController objWorkShopsController = new MMWorkShopsController();
            List<MMWorkShopsInfo> WorkShopsList = new List<MMWorkShopsInfo>();
            WorkShopsList = objWorkShopsController.GetDataSourceForWorkShopByCurrentBranch(BOSApp.CurrentUsersInfo.ADUserID
                                                                                        , ModuleName.WorkShop
                                                                                        , ADDataViewPermissionType.Module
                                                                                        , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            WorkShopsList.Insert(0, new MMWorkShopsInfo());
            fld_lkeFK_MMWorkShopID.Properties.DataSource = WorkShopsList;
        }

        private void Fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                MMLinesController objLinesController = new MMLinesController();
                List<MMLinesInfo> LinesList = new List<MMLinesInfo>();
                fld_lkeFK_MMLineID.EditValue = Convert.ToInt32(e.Value);
                int workShopID = Convert.ToInt32(e.Value);
                if (workShopID != 0)
                {
                    LinesList = objLinesController.GetAllAliveAndActiveLineByWorkShopID(workShopID
                                                        , BOSApp.CurrentUsersInfo.ADUserID
                                                        , ModuleName.Line
                                                        , ADDataViewPermissionType.Module
                                                        , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                    int lineID = Convert.ToInt32(fld_lkeFK_MMLineID.EditValue);
                    if (!LinesList.Exists(o => o.MMLineID == lineID))
                    {
                        MMMachineUnitsInfo mainObject = ((MachineUnitModule)Module).GetMainObject();
                        mainObject.FK_MMLineID = 0;
                        fld_lkeFK_MMLineID.EditValue = 0;
                    }
                }
            }
        }

        private void fld_txtMMMachineUnitCapacity_Validated(object sender, EventArgs e)
        {
            BOSTextBox tbe = (BOSTextBox)sender;
            if (tbe != null && tbe.EditValue != tbe.OldEditValue)
            {
                ((MachineUnitModule)Module).ChangeCapacity(tbe);
            }    
        }
    }
}

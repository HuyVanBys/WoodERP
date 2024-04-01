using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Receipt
{
    public partial class guiAddUpdatePositionItems : BOSERPScreen
    {
        #region Variables

        public int ICStockID;

        #endregion

        public guiAddUpdatePositionItems(int stockID)
        {
            InitializeComponent();
            ICStockID = stockID;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void fld_btnAdd_Click_1(object sender, EventArgs e)
        {
            int wsPositionID = 0;
            int rangePositionID = 0;
            int rowPositionID = 0;
            int.TryParse(fld_lkeFK_MMWSPositionID.EditValue.ToString(), out wsPositionID);
            int.TryParse(fld_lkeFK_MMRangePositionID.EditValue.ToString(), out rangePositionID);
            int.TryParse(fld_lkeFK_MMRowPositionID.EditValue.ToString(), out rowPositionID);
            if (ICStockID > 0)
            {
                MMUpdatePositionItemsController objUpdatePositionItemsController = new MMUpdatePositionItemsController();
                MMUpdatePositionsController objUpdatePositionsController = new MMUpdatePositionsController();
                MMUpdatePositionsInfo objUpdatePositionsInfo = (MMUpdatePositionsInfo)objUpdatePositionsController.GetUpdatePositionByStockID(ICStockID);
                int updatePositionID = 0;
                if (objUpdatePositionsInfo != null)
                {
                    objUpdatePositionsInfo = new MMUpdatePositionsInfo();
                    objUpdatePositionsInfo.AACreatedDate = DateTime.Now;
                    objUpdatePositionsInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                    objUpdatePositionsInfo.MMUpdatePositionDate = DateTime.Now;
                    objUpdatePositionsInfo.MMUpdatePositionStatus = UpdatePositionStatus.New.ToString();
                    objUpdatePositionsInfo.FK_ICStockID = ICStockID;
                    updatePositionID = objUpdatePositionsController.CreateObject(objUpdatePositionsInfo);
                }
                updatePositionID = objUpdatePositionsInfo.MMUpdatePositionID;
                MMUpdatePositionItemsInfo objUpdatePositionItemsInfo = new MMUpdatePositionItemsInfo();
                objUpdatePositionItemsInfo.AACreatedDate = DateTime.Now;
                objUpdatePositionItemsInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                objUpdatePositionItemsInfo.FK_MMUpdatePositionID = updatePositionID;
                objUpdatePositionItemsInfo.FK_MMWSPositionID = wsPositionID;
                objUpdatePositionItemsInfo.FK_MMRangePositionID = rangePositionID;
                MMPositionsController objPositionsController = new MMPositionsController();
                MMPositionsInfo objWSPositionsInfo = (MMPositionsInfo)objPositionsController.GetObjectByID(objUpdatePositionItemsInfo.FK_MMWSPositionID);
                MMPositionsInfo objRangePositionsInfo = (MMPositionsInfo)objPositionsController.GetObjectByID(objUpdatePositionItemsInfo.FK_MMRangePositionID);
                MMPositionsInfo objRowPositionsInfo = (MMPositionsInfo)objPositionsController.GetObjectByID(objUpdatePositionItemsInfo.FK_MMRowPositionID);
                objUpdatePositionItemsInfo.MMUpdatePositionItemPositionName = String.Format("{0} - {1} - {2}",
                                                                objWSPositionsInfo != null ? objWSPositionsInfo.MMPositionNo : string.Empty,
                                                                objRangePositionsInfo != null ? objRangePositionsInfo.MMPositionNo : string.Empty,
                                                                objRowPositionsInfo != null ? objRowPositionsInfo.MMPositionNo : string.Empty);
                objUpdatePositionItemsController.CreateObject(objUpdatePositionItemsInfo);
            }    
        }

        private void fld_btnClosed_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_lkeFK_MMWSPositionID_QueryPopUp(object sender, CancelEventArgs e)
        {
            MMPositionsController objPositionsController = new MMPositionsController();
            List<MMPositionsInfo> listPositions = objPositionsController.GetAllPositionList();
            if (listPositions == null || listPositions.Count == 0)
                return;
            listPositions = listPositions.Where(o => o.MMPositionType == PositionType.Line.ToString()).ToList();
            fld_lkeFK_MMWSPositionID.Properties.DataSource = listPositions;
        }

        private void fld_lkeFK_MMRangePositionID_QueryPopUp(object sender, CancelEventArgs e)
        {
            MMPositionsController objPositionsController = new MMPositionsController();
            List<MMPositionsInfo> listPositions = objPositionsController.GetAllPositionList();
            if (listPositions == null || listPositions.Count == 0)
                return;
            listPositions = listPositions.Where(o => o.MMPositionType == PositionType.Range.ToString()).ToList();
            fld_lkeFK_MMRangePositionID.Properties.DataSource = listPositions;
        }

        private void fld_lkeFK_MMRowPositionID_QueryPopUp(object sender, CancelEventArgs e)
        {
            MMPositionsController objPositionsController = new MMPositionsController();
            List<MMPositionsInfo> listPositions = objPositionsController.GetAllPositionList();
            if (listPositions == null || listPositions.Count == 0)
                return;
            listPositions = listPositions.Where(o => o.MMPositionType == PositionType.Wire.ToString()).ToList();
            fld_lkeFK_MMRowPositionID.Properties.DataSource = listPositions;
        }
    }
}
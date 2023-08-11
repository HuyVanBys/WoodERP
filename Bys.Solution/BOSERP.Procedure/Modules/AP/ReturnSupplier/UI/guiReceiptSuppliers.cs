using BOSCommon.Constants;
using BOSLib;
using System;
using System.Data;
using System.Windows.Forms;
namespace BOSERP.Modules.ReturnSupplier
{
    public partial class guiReceiptSuppliers : BOSERPScreen
    {
        public guiReceiptSuppliers()
        {
            InitializeComponent();
        }

        private void guiReceiptSuppliers_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.EditValue = BOSUtil.GetYearBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetYearEndDate();

            fld_lkeFK_APSupplierID.Screen = this;
            fld_lkeFK_APSupplierID.InitializeControl();

            fld_btnSearch_Click(new object(), new EventArgs());
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            String query = GenerateSearchQuery(TableName.ICReceiptsTableName);
            DataSet ds = objReceiptsController.GetDataSet(query);
            BOSList<ICReceiptsInfo> lstReceipts = new BOSList<ICReceiptsInfo>();
            lstReceipts.InitBOSList(null, String.Empty, TableName.ICReceiptsTableName);
            lstReceipts.Invalidate(ds);
            fld_dgcICReceipts.DataSource = lstReceipts;
        }

        public bool SelectReceipt()
        {
            if (fld_dgvICReceipts.FocusedRowHandle >= 0)
            {
                ReturnSupplierEntities entity = (ReturnSupplierEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                ICReceiptsInfo objICReceiptsInfo = (ICReceiptsInfo)fld_dgvICReceipts.GetRow(fld_dgvICReceipts.FocusedRowHandle);
                APReturnSuppliersInfo objReturnSuppliersInfo = (APReturnSuppliersInfo)entity.MainObject;
                objReturnSuppliersInfo.APReturnSupplierReference = objICReceiptsInfo.ICReceiptNo;
                objReturnSuppliersInfo.FK_ACObjectID = objICReceiptsInfo.FK_ACObjectID;
                objReturnSuppliersInfo.APObjectType = objICReceiptsInfo.ICAssObjectType;
                //((ReturnSupplierModule)Module).SetDefaultSupplierContactInformation();
                entity.UpdateMainObjectBindingSource();
                GenerateReferenceReceiptItems(objICReceiptsInfo.ICReceiptID);
                return true;
            }
            return false;
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            if (SelectReceipt())
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_dgcICReceipts_DoubleClick(object sender, EventArgs e)
        {
            if (SelectReceipt())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void GenerateReferenceReceiptItems(int receiptID)
        {
            ReturnSupplierEntities entity = (ReturnSupplierEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            ICReceiptItemsController objICReceiptItemsController = new ICReceiptItemsController();
            DataSet dsReceiptItems = objICReceiptItemsController.GetAllDataByForeignColumn("FK_ICReceiptID", receiptID);
            entity.ReferenceReceiptItemsList.Invalidate(dsReceiptItems);
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guiReceiptSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                ((BaseModuleERP)Module).ActionCancel();
        }
    }
}
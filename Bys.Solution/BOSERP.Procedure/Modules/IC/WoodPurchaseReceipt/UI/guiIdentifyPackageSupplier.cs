using BOSCommon.Constants;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPurchaseReceipt
{
    public partial class guiIdentifyPackageSupplier : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets receipt item entity object
        /// </summary>
        public ICReceiptComponentItemsInfo ReceiptComponentItemsObject { get; set; }

        public guiIdentifyPackageSupplier(ICReceiptComponentItemsInfo objReceiptComponentItemsInfo)
        {
            InitializeComponent();
            ReceiptComponentItemsObject = objReceiptComponentItemsInfo;
        }


        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            ((WoodPurchaseReceiptModule)Module).RollbackReceiptItemPackageList(ReceiptComponentItemsObject);
            Close();
        }

        private void guiIdentifyPackageSupplier_Load(object sender, EventArgs e)
        {
            // Initialize controls
            InitializeControls(Controls);

            //Bind the grid control to the entity's list
            if (ReceiptComponentItemsObject.ReceiptItemPackageList == null)
            {
                WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                ReceiptComponentItemsObject.ReceiptItemPackageList = new BOSList<ICReceiptItemPackagesInfo>();
                ReceiptComponentItemsObject.ReceiptItemPackageList.InitBOSList(entity,
                                                                    TableName.ICReceiptComponentItemsTableName,
                                                                    TableName.ICReceiptItemPackagesTableName,
                                                                    BOSList<ICReceiptItemPackagesInfo>.cstRelationForeign);
                ReceiptComponentItemsObject.ReceiptItemPackageList.ItemTableForeignKey = "FK_ICReceiptComponentItemID";
            }

            ((BOSList<ICReceiptItemPackagesInfo>)ReceiptComponentItemsObject.ReceiptItemPackageList).InitBOSListGridControl(fld_dgcICReceiptItemPackages);
            fld_dgcICReceiptItemPackages.InvalidateDataSource(ReceiptComponentItemsObject.ReceiptItemPackageList);
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

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (!((WoodPurchaseReceiptModule)Module).CheckSumReceiptItemPackageQty(ReceiptComponentItemsObject))
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

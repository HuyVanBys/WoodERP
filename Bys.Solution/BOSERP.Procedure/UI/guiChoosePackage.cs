using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiChoosePackage<T> : BOSERPScreen where T : BusinessObject
    {
        #region Public properties
        /// <summary>
        /// Gets or sets the item object used to get and set package info
        /// </summary>
        public BusinessObject ItemObject { get; set; }

        /// <summary>
        /// Gets or sets the table name of the item object
        /// </summary>
        public string ItemTableName { get; set; }

        /// <summary>
        /// Gets or sets package list
        /// </summary>
        public BOSList<ICPackagesInfo> PackageList { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public guiChoosePackage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="objItem">Item object is used to get and set package info</param>
        /// <param name="itemPackageList">Package list associates with the item</param>
        public guiChoosePackage(BusinessObject objItem, string itemTableName, IList<T> itemPackageList)
        {
            InitializeComponent();

            PackageList = new BOSList<ICPackagesInfo>();
            PackageList.InitBOSList(null,
                                            string.Empty,
                                            TableName.ICPackagesTableName,
                                            BOSList<ICPackagesInfo>.cstRelationNone);
            ItemObject = objItem;
            ItemTableName = itemTableName;

            ICPackagesController objPackagesController = new ICPackagesController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            int stockID = dbUtil.GetPropertyIntValue(ItemObject, "FK_ICStockID");
            int productID = dbUtil.GetPropertyIntValue(ItemObject, "FK_ICProductID");
            foreach (T obj in itemPackageList)
            {
                int packageID = dbUtil.GetPropertyIntValue(obj, "FK_ICPackageID");
                string itemTablePrefix = ItemTableName.Substring(0, ItemTableName.Length - 1);
                decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(obj, itemTablePrefix + "PackageQty"));
                ICPackagesInfo objPackagesInfo = (ICPackagesInfo)objPackagesController.GetObjectByID(packageID);
                if (objPackagesInfo != null)
                {
                    objPackagesInfo.FK_ICStockID = stockID;
                    objPackagesInfo.FK_ICProductID = productID;
                    objPackagesInfo.ICPackageProductQty = qty;

                    ICInventoryPackagesController objInventoryPackagesController = new ICInventoryPackagesController();
                    ICInventoryPackagesInfo objInventoryPackagesInfo = objInventoryPackagesController.GetInventoryPackageByPackageIDAndStockIDAndProductID(packageID, stockID, productID);
                    if (objInventoryPackagesInfo != null)
                    {
                        objPackagesInfo.ICPackageProductOnHandQty = objInventoryPackagesInfo.ICInventoryPackageQty;
                    }
                    PackageList.Add(objPackagesInfo);
                }
            }
            fld_dgcICPackages.InvalidatePackageGridControl(PackageList);

            List<ICPackagesInfo> packages = objPackagesController.GetPackagesByProductIDAndStockID(productID, stockID);
            fld_lkeFK_ICPackageID.Properties.DataSource = packages;
        }
        #endregion

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

        private void guiChoosePackage_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_lkeFK_ICPackageID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BOSLookupEdit lookupEdit = (BOSLookupEdit)sender;
                if (lookupEdit.EditValue != null)
                {
                    AddItemToPackageList(Convert.ToInt32(lookupEdit.EditValue));
                }
            }
        }

        private void fld_btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Add item to transfer package list.
        /// </summary>
        /// <param name="packageID">The package id.</param>
        public void AddItemToPackageList(int packageID)
        {
            ICPackagesController objPackagesController = new ICPackagesController();
            ICPackagesInfo objPackagesInfo = (ICPackagesInfo)objPackagesController.GetObjectByID(packageID);
            if (objPackagesInfo != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(ItemObject, "FK_ICProductID");
                int stockID = dbUtil.GetPropertyIntValue(ItemObject, "FK_ICStockID");
                string itemTablePrefix = ItemTableName.Substring(0, ItemTableName.Length - 1);
                decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(ItemObject, itemTablePrefix + "ProductQty"));

                ICPackageProductsController objPackageProductsController = new ICPackageProductsController();
                ICPackageProductsInfo objPackageProductsInfo = objPackageProductsController.GetDataByPackageIDAndProductID(packageID, productID);
                if (objPackageProductsInfo == null)
                {
                    MessageBox.Show(CommonLocalizedResources.SynPackageAndProductMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ICInventoryPackagesController objInventoryPackagesController = new ICInventoryPackagesController();
                ICInventoryPackagesInfo objInventoryPackagesInfo = objInventoryPackagesController.GetInventoryPackageByPackageIDAndStockIDAndProductID(packageID, stockID, productID);
                if (objInventoryPackagesInfo == null)
                {
                    MessageBox.Show(CommonLocalizedResources.PackageIsNotEnoughQtyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ICPackagesInfo objExistingPackagesInfo = PackageList.Where(p => p.ICPackageNo == objPackagesInfo.ICPackageNo).FirstOrDefault();
                if (objExistingPackagesInfo != null)
                {
                    MessageBox.Show(CommonLocalizedResources.PackageAlreadyExistsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                objPackagesInfo.FK_ICStockID = stockID;
                objPackagesInfo.FK_ICProductID = productID;
                objPackagesInfo.ICPackageProductOnHandQty = objInventoryPackagesInfo.ICInventoryPackageQty;
                objPackagesInfo.ICPackageProductQty = Math.Min(objInventoryPackagesInfo.ICInventoryPackageQty, itemQty);
                PackageList.Add(objPackagesInfo);
                fld_dgcICPackages.RefreshDataSource();
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

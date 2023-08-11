using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiItemComponent<T> : BOSERPScreen where T : BusinessObject
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the component list of the current item
        /// </summary>
        public BOSList<ICProductComponentsInfo> ItemComponentList { get; set; }

        /// <summary>
        /// Gets or sets the item that the components belong to
        /// </summary>
        public BusinessObject ItemObject { get; set; }
        #endregion

        public guiItemComponent(IList<T> itemComponents)
        {
            InitializeComponent();

            ItemComponentList = new BOSList<ICProductComponentsInfo>(TableName.ICProductComponentsTableName);
            BOSDbUtil dbUtil = new BOSDbUtil();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            string tableName = BOSUtil.GetTableNameFromBusinessObjectType(typeof(T));
            string tablePrefix = tableName.Substring(0, tableName.Length - 1);
            string tablePrimaryKey = BOSApp.GetTablePrimaryColumn(tableName);
            foreach (T itemComponent in itemComponents)
            {
                ICProductComponentsInfo objProductComponentsInfo = new ICProductComponentsInfo();
                objProductComponentsInfo.ItemComponentID = dbUtil.GetPropertyIntValue(itemComponent, tablePrimaryKey);
                objProductComponentsInfo.FK_ICProductComponentChildID = dbUtil.GetPropertyIntValue(itemComponent, "FK_ICProductID");
                objProductComponentsInfo.ICProductNo = dbUtil.GetPropertyStringValue(itemComponent, "ICProductNo");
                objProductComponentsInfo.ICProductName = dbUtil.GetPropertyStringValue(itemComponent, "ICProductName");
                objProductComponentsInfo.FK_ICProductID = objProductComponentsInfo.FK_ICProductComponentChildID;
                objProductComponentsInfo.ICProductSupplierNo = dbUtil.GetPropertyStringValue(itemComponent, "ICProductSupplierNo");
                objProductComponentsInfo.ICProductDesc = dbUtil.GetPropertyStringValue(itemComponent, "ICProductDesc");
                objProductComponentsInfo.ICProductComponentDesc = dbUtil.GetPropertyStringValue(itemComponent, "ICProductComponentDesc");
                objProductComponentsInfo.FK_ICStockID = dbUtil.GetPropertyIntValue(itemComponent, "FK_ICStockID");
                objProductComponentsInfo.FK_ICProductSerieID = dbUtil.GetPropertyIntValue(itemComponent, "FK_ICProductSerieID");
                objProductComponentsInfo.ICProductSerialNo = objProductSeriesController.GetObjectNoByID(objProductComponentsInfo.FK_ICProductSerieID);
                objProductComponentsInfo.ICProductComponentQty = Convert.ToDecimal(dbUtil.GetPropertyValue(itemComponent, tablePrefix + "Qty"));
                ItemComponentList.Add(objProductComponentsInfo);
            }
        }

        private void guiSOItemComponent_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcItemComponents.InvalidateDataSource(ItemComponentList);
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

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo != null)
                {
                    ICProductComponentsInfo objProductComponentsInfo = new ICProductComponentsInfo();
                    objProductComponentsInfo.FK_ICProductComponentChildID = productID;
                    objProductComponentsInfo.FK_ICProductID = productID;
                    objProductComponentsInfo.ICProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
                    objProductComponentsInfo.ICProductDesc = objProductsInfo.ICProductDesc;
                    objProductComponentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
                    ItemComponentList.Add(objProductComponentsInfo);
                    fld_dgcItemComponents.RefreshDataSource();
                }
            }
        }
    }
}

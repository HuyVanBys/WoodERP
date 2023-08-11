using BOSCommon.Constants;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant.UI
{
    public partial class guiProductAttributeItems : BOSERPScreen
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the component list of the current item
        /// </summary>
        public BOSList<ICProductAttributeItemsInfo> productAttributeItemList { get; set; }
        public BOSList<ICProductAttributeItemsInfo> RemoteProductAttributeItemList { get; set; }
        public int ICProductAttributeID { get; set; }
        #endregion

        public guiProductAttributeItems(int objectID)
        {
            InitializeComponent();
            ICProductAttributeID = objectID;
            ICProductAttributeItemsController objProductAttributeItemsController = new ICProductAttributeItemsController();
            List<ICProductAttributeItemsInfo> productAttributeItemsList = objProductAttributeItemsController.GetMMOperationsByFK_ICProductAttributeID(ICProductAttributeID);
            productAttributeItemList = new BOSList<ICProductAttributeItemsInfo>(TableName.ICProductAttributeItemsTableName);
            RemoteProductAttributeItemList = new BOSList<ICProductAttributeItemsInfo>(TableName.ICProductAttributeItemsTableName);
            foreach (ICProductAttributeItemsInfo item in productAttributeItemsList)
            {
                productAttributeItemList.Add(item);
            }
        }

        private void guiProductAttributeItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcProductAttributeItems.InvalidateDataSource(productAttributeItemList);
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

        private void fld_lkeMMOperationID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int operationID = Convert.ToInt32(fld_lkeMMOperationID.EditValue);
                MMOperationsController objOperationsController = new MMOperationsController();
                ICProductAttributeItemsInfo productAttributeItem = productAttributeItemList.Where(x => x.FK_MMOperationID == operationID).FirstOrDefault();
                if (productAttributeItem == null)
                {
                    MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(operationID);
                    if (objOperationsInfo != null)
                    {
                        int count = productAttributeItemList.Count + 1;
                        ICProductAttributeItemsInfo objProductAttributeItemsInfo = new ICProductAttributeItemsInfo();
                        objProductAttributeItemsInfo.FK_ICProductAttributeID = ICProductAttributeID;
                        objProductAttributeItemsInfo.FK_MMOperationID = objOperationsInfo.MMOperationID;
                        objProductAttributeItemsInfo.MMOperationNo = objOperationsInfo.MMOperationNo;
                        objProductAttributeItemsInfo.MMOperationName = objOperationsInfo.MMOperationName;
                        objProductAttributeItemsInfo.ICProductAttributeItemPeriod = count;
                        productAttributeItemList.Add(objProductAttributeItemsInfo);
                        fld_dgcProductAttributeItems.RefreshDataSource();
                    }
                }

            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<ICProductAttributeItemsInfo> check = productAttributeItemList.Where(x => x.ICProductAttributeItemPeriod == 0).ToList();
                if (check != null && check.Count > 0)
                {
                    MessageBox.Show("Danh sách tồn tại công đoạn có Thứ tự SX 0!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!productAttributeItemList.GroupBy(n => n.ICProductAttributeItemPeriod).Any(c => c.Count() > 1))
                {

                    productAttributeItemList.SaveItemObjects();
                    RemoteProductAttributeItemList.DeleteItemObjects();
                    MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Close();
                }
                else
                {
                    MessageBox.Show("Thứ tự công đoạn trong danh sách bị trùng nhau!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveProductAttributeItem(int index)
        {
            ICProductAttributeItemsInfo objProductAttributeItemsInfo = new ICProductAttributeItemsInfo();
            objProductAttributeItemsInfo = productAttributeItemList[index];
            RemoteProductAttributeItemList.Add(objProductAttributeItemsInfo);
            productAttributeItemList.RemoveAt(index);
            fld_dgcProductAttributeItems.RefreshDataSource();
        }

    }
}

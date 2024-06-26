using BOSCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    public partial class guiProcess : BOSERPScreen
    {
        public int ProductID;
        List<MMOperationsInfo> OperationList;
        bool ReadOnly = false;
        public int ParentProductID;
        public int ProductionNormItemID;
        public int ProducDetailID;
        bool PaintProcessReadOnly = false;
        public bool isParent = false;
        bool IsReload = false;
        public guiProcess(string info, int productID, Image img, bool isReadOnly, int parentProductID, int productionNormItemID, bool isPaintProcessReadOnly, int producDetailID)
        {
            InitializeComponent();

            fld_lblInfo.Text = info;
            ProductID = productID;
            if (img != null)
            {
                bosPictureEdit1.Image = img;
            }

            bosPictureEdit1.EditValueChanged += new EventHandler(bosPictureEdit1_EditValueChanged);
            ReadOnly = isReadOnly;
            ParentProductID = isParent ? 0 : parentProductID;
            ProductionNormItemID = productionNormItemID;
            PaintProcessReadOnly = isPaintProcessReadOnly;
            ProducDetailID = producDetailID;
        }

        public void ReloadData(string info, int productID, Image img, bool isReadOnly, int parentProductID, int productionNormItemID, bool isPaintProcessReadOnly, int producDetailID)
        {
            IsReload = true;
            fld_lblInfo.Text = info;
            ProductID = productID;
            if (img != null)
            {
                bosPictureEdit1.Image = img;
            }
            ReadOnly = isReadOnly;
            ParentProductID = isParent ? 0 : parentProductID;
            ProductionNormItemID = productionNormItemID;
            PaintProcessReadOnly = isPaintProcessReadOnly;
            ProducDetailID = producDetailID;
            InvalidateDataControls();
        }

        private void bosPictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).UploadImageFromPictureEditCtrl(bosPictureEdit1.FileName, bosPictureEdit1.FilePath);
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

        private void guiProcess_Load(object sender, EventArgs e)
        {
            if (IsReload)
                return;

            InitializeControls(Controls);
            InvalidateDataControls();
        }

        private void InvalidateDataControls()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
            MMProductionNormsInfo pn = (MMProductionNormsInfo)entity.MainObject;
            
            entity.ProductInProcessList.InitBOSListGridControl(fld_dgcProductInProcessForm);
            entity.ProductInProcessList.GridControl?.RefreshDataSource();

            entity.PIProcessList.InitBOSListGridControl(fld_dgcICProductItemProcess);
            entity.PIProcessList.GridControl?.RefreshDataSource();

            OperationList = ((CarcassBOMModule)Module).GetProcessOperation();
            fld_lkeMMOperationID.Properties.DataSource = OperationList;

            fld_lkeCarcassForCopy.Properties.DataSource = ((CarcassBOMModule)Module).GetAnotherCarcass(false);

            fld_lkeMMProcessID.Enabled = !ReadOnly;
            fld_lkeMMOperationID.Enabled = !ReadOnly;
            fld_btnCopyProcess.Enabled = !ReadOnly;
            bosPictureEdit1.Enabled = !ReadOnly;
            fld_btnSave.Enabled = !ReadOnly;
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (!ReadOnly)
            {
                CarcassBOMEntities entity = (CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity;
                entity.PIProcessList.ForEach(p => p.FK_ICProductDetailID = ProducDetailID);
                if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
                if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
                ((CarcassBOMModule)Module).SaveProductProcess(ProductID);
            }
        }

        private void fld_lkeMMOperationID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int processID = 0;

                if (fld_lkeMMOperationID.EditValue != null)
                {
                    int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out processID);
                }
                if (isParent) ParentProductID = 0;
                ((CarcassBOMModule)Module).ChooseProcessOperation(ProductID, processID, OperationList, ParentProductID, ProducDetailID);
            }
        }

        private void fld_lkeMMProcessID_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int processID = 0;

                if (fld_lkeMMProcessID.EditValue != null)
                {
                    int.TryParse(fld_lkeMMProcessID.EditValue.ToString(), out processID);
                }
                if (isParent) ParentProductID = 0;
                ((CarcassBOMModule)Module).ChooseProcess(ProductID, processID, OperationList, ParentProductID, ProducDetailID);
            }
        }

        private void bosLookupEdit1_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            if (fld_lkeCarcassForCopy.EditValue != null)
            {
                DataRowView dataRow = (DataRowView)fld_lkeCarcassForCopy.GetSelectedDataRow();
                if (dataRow != null)
                    objProductsInfo = (ICProductsInfo)(new ICProductsController()).GetObjectFromDataRow(dataRow.Row);
            }
            List<ICProductsInfo> semiProductList = ((CarcassBOMModule)Module).GetSemiProductByCarcassID(objProductsInfo.ICProductID, objProductsInfo.MMProductionNormID);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = semiProductList;
        }

        private void fld_btnCopyProcess_Click(object sender, EventArgs e)
        {
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            if (fld_lkeCarcassForCopy.EditValue != null)
            {
                DataRowView dataRow = (DataRowView)fld_lkeCarcassForCopy.GetSelectedDataRow();
                if (dataRow != null)
                    objProductsInfo = (ICProductsInfo)(new ICProductsController()).GetObjectFromDataRow(dataRow.Row);
            }

            int productID = 0;
            if (bosLookupEdit1.EditValue != null)
            {
                int.TryParse(bosLookupEdit1.EditValue.ToString(), out productID);
            }
            if (isParent) ParentProductID = 0;
            ((CarcassBOMModule)Module).CopyProcess(objProductsInfo, productID, ProductID, ParentProductID, ProducDetailID);
        }

        private void fld_lkeCarcassForCopy_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            bosLookupEdit1.EditValue = null;
        }

        private void bosLookupEdit1_CloseUp(object sender, CloseUpEventArgs e)
        {
            int carcassID = 0;
            if (fld_lkeCarcassForCopy.EditValue != null)
            {
                int.TryParse(fld_lkeCarcassForCopy.EditValue.ToString(), out carcassID);
            }

            int productID = 0;
            if (e.Value != null)
            {
                int.TryParse(e.Value.ToString(), out productID);
            }

            if (carcassID != 0 && productID != 0)
            {
                bosPictureEdit2.Visible = true;
                Image img = ((CarcassBOMModule)Module).GetCopiedProductImage(carcassID, productID);
                bosPictureEdit2.Image = img;
            }
            else
            {
                bosPictureEdit2.Visible = false;
            }
        }

        private void Fld_btnProcessPanel_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_bolProcessPanel);
        }

        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom(string.Empty, string.Empty);

            host.fld_txtICProductNo.Visible = false;
            host.fld_lblLabel15.Visible = false;
            host.fld_txtICProductName.Visible = false;
            host.bosLabel3.Visible = false;
            //host.FormBorderStyle = FormBorderStyle.Fixed3D;
            //host.WindowState = FormWindowState.Maximized;
            //host.ShowInTaskbar = true;
            host.MaximizeBox = false;
            host.MinimizeBox = false;
            // Save properties of control
            var loc = ctl.Location;
            var dock = ctl.Dock;
            var parent = ctl.Parent;
            var form = parent;
            var anchor = ctl.Anchor;
            var size = ctl.Size;
            while (!(form is Form)) form = form.Parent;
            // Move control to host
            //ctl.Parent = host;
            host.AddCtrl(ctl);
            ctl.Location = Point.Empty;
            ctl.Dock = DockStyle.Fill;
            // Setup event handler to restore control back to form
            host.FormClosing += delegate
            {
                ctl.Parent = parent;
                ctl.Dock = dock;
                ctl.Location = loc;
                ctl.Anchor = anchor;
                ctl.Size = size;
                form.Refresh();
            };


            // Exit full screen with escape key
            host.KeyPreview = true;
            host.KeyDown += (KeyEventHandler)((s, e) =>
            {
                if (e.KeyCode == Keys.Escape) host.Close();
            });
            // And go full screen
            host.ShowDialog();
            //  form.Hide();
        }
    }
}

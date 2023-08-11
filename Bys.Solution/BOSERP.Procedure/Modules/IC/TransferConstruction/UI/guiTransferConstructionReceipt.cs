using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferConstruction
{
    /// <summary>
    /// Summary description for guiSelectTransfer.
    /// </summary>
    public class guiTransferConstructionReceipt : BOSERPScreen
    {
        public guiTransferConstructionReceipt()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private SimpleButton fld_btnOK;
        private SimpleButton fld_btnCancel;
        private IContainer components;
        private Label label1;
        private SimpleButton fld_btnSearch;
        private Label label5;
        private Label label6;
        private Label label2;
        private BOSComponent.BOSLine BOSLine1;
        private BOSComponent.BOSLine BOSLine2;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSTextBox fld_txtICTransferNo;
        private BOSComponent.BOSDateEdit fld_dteICTransferDateFrom;
        private ICTransfersGridControl fld_dgcShipmentTransfers;
        private BOSComponent.BOSDateEdit fld_dteICTransferDateTo;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiTransferConstructionReceipt));
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fld_btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BOSLine1 = new BOSComponent.BOSLine(this.components);
            this.BOSLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICTransferNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICTransferDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICTransferDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcShipmentTransfers = new BOSERP.Modules.TransferConstruction.ICTransfersGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentTransfers)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Location = new System.Drawing.Point(569, 524);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 6;
            this.fld_btnOK.Text = "Chọn ";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(650, 524);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 7;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã phiếu xuất";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSearch.Location = new System.Drawing.Point(579, 15);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSearch.TabIndex = 5;
            this.fld_btnSearch.Text = "Tim kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_txtSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Từ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Chi nhánh";
            // 
            // BOSLine1
            // 
            this.BOSLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSLine1.BOSComment = null;
            this.BOSLine1.BOSDataMember = null;
            this.BOSLine1.BOSDataSource = null;
            this.BOSLine1.BOSDescription = null;
            this.BOSLine1.BOSError = null;
            this.BOSLine1.BOSFieldGroup = null;
            this.BOSLine1.BOSFieldRelation = null;
            this.BOSLine1.BOSPrivilege = null;
            this.BOSLine1.BOSPropertyName = null;
            this.BOSLine1.Location = new System.Drawing.Point(2, 68);
            this.BOSLine1.Name = "BOSLine1";
            this.BOSLine1.Screen = null;
            this.BOSLine1.Size = new System.Drawing.Size(722, 10);
            this.BOSLine1.TabIndex = 27;
            this.BOSLine1.TabStop = false;
            // 
            // BOSLine2
            // 
            this.BOSLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSLine2.BOSComment = null;
            this.BOSLine2.BOSDataMember = null;
            this.BOSLine2.BOSDataSource = null;
            this.BOSLine2.BOSDescription = null;
            this.BOSLine2.BOSError = null;
            this.BOSLine2.BOSFieldGroup = null;
            this.BOSLine2.BOSFieldRelation = null;
            this.BOSLine2.BOSPrivilege = null;
            this.BOSLine2.BOSPropertyName = null;
            this.BOSLine2.Location = new System.Drawing.Point(4, 502);
            this.BOSLine2.Name = "BOSLine2";
            this.BOSLine2.Screen = null;
            this.BOSLine2.Size = new System.Drawing.Size(722, 10);
            this.BOSLine2.TabIndex = 27;
            this.BOSLine2.TabStop = false;
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = false;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(106, 12);
            this.fld_lkeBRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 1;
            // 
            // fld_txtICTransferNo
            // 
            this.fld_txtICTransferNo.BOSComment = null;
            this.fld_txtICTransferNo.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICTransferNo.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICTransferNo.BOSDescription = null;
            this.fld_txtICTransferNo.BOSError = null;
            this.fld_txtICTransferNo.BOSFieldGroup = null;
            this.fld_txtICTransferNo.BOSFieldRelation = null;
            this.fld_txtICTransferNo.BOSPrivilege = null;
            this.fld_txtICTransferNo.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICTransferNo.Location = new System.Drawing.Point(377, 12);
            this.fld_txtICTransferNo.MenuManager = this.screenToolbar;
            this.fld_txtICTransferNo.Name = "fld_txtICTransferNo";
            this.fld_txtICTransferNo.Screen = null;
            this.fld_txtICTransferNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICTransferNo.TabIndex = 2;
            // 
            // fld_dteICTransferDateFrom
            // 
            this.fld_dteICTransferDateFrom.BOSComment = null;
            this.fld_dteICTransferDateFrom.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteICTransferDateFrom.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteICTransferDateFrom.BOSDescription = null;
            this.fld_dteICTransferDateFrom.BOSError = null;
            this.fld_dteICTransferDateFrom.BOSFieldGroup = null;
            this.fld_dteICTransferDateFrom.BOSFieldRelation = null;
            this.fld_dteICTransferDateFrom.BOSPrivilege = null;
            this.fld_dteICTransferDateFrom.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteICTransferDateFrom.EditValue = null;
            this.fld_dteICTransferDateFrom.Location = new System.Drawing.Point(106, 38);
            this.fld_dteICTransferDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteICTransferDateFrom.Name = "fld_dteICTransferDateFrom";
            this.fld_dteICTransferDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICTransferDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferDateFrom.Screen = null;
            this.fld_dteICTransferDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICTransferDateFrom.TabIndex = 3;
            // 
            // fld_dteICTransferDateTo
            // 
            this.fld_dteICTransferDateTo.BOSComment = null;
            this.fld_dteICTransferDateTo.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteICTransferDateTo.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteICTransferDateTo.BOSDescription = null;
            this.fld_dteICTransferDateTo.BOSError = null;
            this.fld_dteICTransferDateTo.BOSFieldGroup = null;
            this.fld_dteICTransferDateTo.BOSFieldRelation = null;
            this.fld_dteICTransferDateTo.BOSPrivilege = null;
            this.fld_dteICTransferDateTo.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteICTransferDateTo.EditValue = null;
            this.fld_dteICTransferDateTo.Location = new System.Drawing.Point(377, 38);
            this.fld_dteICTransferDateTo.Name = "fld_dteICTransferDateTo";
            this.fld_dteICTransferDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICTransferDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICTransferDateTo.Screen = null;
            this.fld_dteICTransferDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICTransferDateTo.TabIndex = 4;
            // 
            // fld_dgcShipmentTransfers
            // 
            this.fld_dgcShipmentTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcShipmentTransfers.BOSComment = null;
            this.fld_dgcShipmentTransfers.BOSDataMember = null;
            this.fld_dgcShipmentTransfers.BOSDataSource = "ICTransfers";
            this.fld_dgcShipmentTransfers.BOSDescription = null;
            this.fld_dgcShipmentTransfers.BOSError = null;
            this.fld_dgcShipmentTransfers.BOSFieldGroup = null;
            this.fld_dgcShipmentTransfers.BOSFieldRelation = null;
            this.fld_dgcShipmentTransfers.BOSGridType = null;
            this.fld_dgcShipmentTransfers.BOSPrivilege = null;
            this.fld_dgcShipmentTransfers.BOSPropertyName = null;
            this.fld_dgcShipmentTransfers.Location = new System.Drawing.Point(4, 82);
            this.fld_dgcShipmentTransfers.MenuManager = this.screenToolbar;
            this.fld_dgcShipmentTransfers.Name = "fld_dgcShipmentTransfers";
            this.fld_dgcShipmentTransfers.PrintReport = false;
            this.fld_dgcShipmentTransfers.Screen = null;
            this.fld_dgcShipmentTransfers.Size = new System.Drawing.Size(721, 420);
            this.fld_dgcShipmentTransfers.TabIndex = 31;
            // 
            // guiTransferConstructionReceipt
            // 
            this.AcceptButton = this.fld_btnSearch;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(728, 557);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcShipmentTransfers);
            this.Controls.Add(this.fld_dteICTransferDateTo);
            this.Controls.Add(this.fld_dteICTransferDateFrom);
            this.Controls.Add(this.fld_txtICTransferNo);
            this.Controls.Add(this.fld_lkeBRBranchID);
            this.Controls.Add(this.BOSLine2);
            this.Controls.Add(this.BOSLine1);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.Name = "guiTransferConstructionReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SS";
            this.Text = "Tìm kiếm phiếu xuất";
            this.Load += new System.EventHandler(this.guiSelectTransfer_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.fld_btnSearch, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.BOSLine1, 0);
            this.Controls.SetChildIndex(this.BOSLine2, 0);
            this.Controls.SetChildIndex(this.fld_lkeBRBranchID, 0);
            this.Controls.SetChildIndex(this.fld_txtICTransferNo, 0);
            this.Controls.SetChildIndex(this.fld_dteICTransferDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteICTransferDateTo, 0);
            this.Controls.SetChildIndex(this.fld_dgcShipmentTransfers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTransferNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICTransferDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentTransfers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void guiSelectTransfer_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            if (BOSApp.CurrentCompanyInfo != null)
            {
                fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            }

            fld_dteICTransferDateFrom.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteICTransferDateTo.DateTime = BOSUtil.GetYearEndDate();
            fld_dteICTransferDateFrom.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteICTransferDateTo.DateTime = BOSUtil.GetYearEndDate();

            TransferConstructionEntities entity = (TransferConstructionEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ShipmentTransferList.InitBOSListGridControl(fld_dgcShipmentTransfers);
            entity.ShipmentTransferList.SetDefaultListAndRefreshGridControl();
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
            this.Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            if (!((TransferConstructionModule)Module).GenerateReceiptTransfer())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_dgcTransfers_DoubleClick(object sender, EventArgs e)
        {
            if (!((TransferConstructionModule)Module).GenerateReceiptTransfer())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_txtSearch_Click(object sender, EventArgs e)
        {
            ((TransferConstructionModule)Module).ShowBranchTransfers(
                                                    Convert.ToInt32(fld_lkeBRBranchID.EditValue),
                                                    fld_txtICTransferNo.Text,
                                                    fld_dteICTransferDateFrom.DateTime,
                                                    fld_dteICTransferDateTo.DateTime);
        }
    }
}


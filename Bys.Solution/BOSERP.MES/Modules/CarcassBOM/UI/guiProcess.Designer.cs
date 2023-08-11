namespace BOSERP.Modules.CarcassBOM.UI
{
    partial class guiProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fld_dgcICProductItemProcess = new BOSERP.Modules.CarcassBOM.ICProductItemProcesssGridControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fld_dgcProductInProcessForm = new BOSERP.Modules.CarcassBOM.ProductInProcesssGridControl();
            this.fld_lblInfo = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_bolProcessPanel = new BOSComponent.BOSLine(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnProcessPanel = new BOSComponent.BOSButton(this.components);
            this.fld_lkeMMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnCopyProcess = new BOSComponent.BOSButton(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeCarcassForCopy = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProcessID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosPictureEdit1 = new BOSComponent.BOSPictureEdit(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bosPictureEdit2 = new BOSComponent.BOSPictureEdit(this.components);
            this.splitter2 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItemProcess)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductInProcessForm)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.bosLine1.SuspendLayout();
            this.fld_bolProcessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCarcassForCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProcessID.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICProductItemProcess
            // 
            this.fld_dgcICProductItemProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductItemProcess.BOSComment = null;
            this.fld_dgcICProductItemProcess.BOSDataMember = null;
            this.fld_dgcICProductItemProcess.BOSDataSource = "ICProductItemProcesss";
            this.fld_dgcICProductItemProcess.BOSDescription = null;
            this.fld_dgcICProductItemProcess.BOSError = null;
            this.fld_dgcICProductItemProcess.BOSFieldGroup = null;
            this.fld_dgcICProductItemProcess.BOSFieldRelation = null;
            this.fld_dgcICProductItemProcess.BOSGridType = null;
            this.fld_dgcICProductItemProcess.BOSPrivilege = null;
            this.fld_dgcICProductItemProcess.BOSPropertyName = null;
            this.fld_dgcICProductItemProcess.CommodityType = "";
            this.fld_dgcICProductItemProcess.Location = new System.Drawing.Point(6, 95);
            this.fld_dgcICProductItemProcess.MenuManager = this.screenToolbar;
            this.fld_dgcICProductItemProcess.Name = "fld_dgcICProductItemProcess";
            this.fld_dgcICProductItemProcess.PrintReport = false;
            this.fld_dgcICProductItemProcess.Screen = null;
            this.fld_dgcICProductItemProcess.Size = new System.Drawing.Size(1135, 260);
            this.fld_dgcICProductItemProcess.TabIndex = 402;
            this.fld_dgcICProductItemProcess.Tag = "DC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fld_dgcProductInProcessForm);
            this.panel2.Controls.Add(this.fld_lblInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 169);
            this.panel2.TabIndex = 403;
            // 
            // fld_dgcProductInProcessForm
            // 
            this.fld_dgcProductInProcessForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductInProcessForm.BOSComment = null;
            this.fld_dgcProductInProcessForm.BOSDataMember = null;
            this.fld_dgcProductInProcessForm.BOSDataSource = "ICProducts";
            this.fld_dgcProductInProcessForm.BOSDescription = null;
            this.fld_dgcProductInProcessForm.BOSError = null;
            this.fld_dgcProductInProcessForm.BOSFieldGroup = null;
            this.fld_dgcProductInProcessForm.BOSFieldRelation = null;
            this.fld_dgcProductInProcessForm.BOSGridType = null;
            this.fld_dgcProductInProcessForm.BOSPrivilege = null;
            this.fld_dgcProductInProcessForm.BOSPropertyName = null;
            this.fld_dgcProductInProcessForm.CommodityType = "";
            this.fld_dgcProductInProcessForm.Location = new System.Drawing.Point(3, 31);
            this.fld_dgcProductInProcessForm.MenuManager = this.screenToolbar;
            this.fld_dgcProductInProcessForm.Name = "fld_dgcProductInProcessForm";
            this.fld_dgcProductInProcessForm.PrintReport = false;
            this.fld_dgcProductInProcessForm.Screen = null;
            this.fld_dgcProductInProcessForm.Size = new System.Drawing.Size(1162, 135);
            this.fld_dgcProductInProcessForm.TabIndex = 403;
            this.fld_dgcProductInProcessForm.Tag = "DC";
            // 
            // fld_lblInfo
            // 
            this.fld_lblInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblInfo.Appearance.Options.UseFont = true;
            this.fld_lblInfo.BOSComment = null;
            this.fld_lblInfo.BOSDataMember = null;
            this.fld_lblInfo.BOSDataSource = null;
            this.fld_lblInfo.BOSDescription = null;
            this.fld_lblInfo.BOSError = null;
            this.fld_lblInfo.BOSFieldGroup = null;
            this.fld_lblInfo.BOSFieldRelation = null;
            this.fld_lblInfo.BOSPrivilege = null;
            this.fld_lblInfo.BOSPropertyName = null;
            this.fld_lblInfo.Location = new System.Drawing.Point(12, 12);
            this.fld_lblInfo.Name = "fld_lblInfo";
            this.fld_lblInfo.Screen = null;
            this.fld_lblInfo.Size = new System.Drawing.Size(248, 13);
            this.fld_lblInfo.TabIndex = 4;
            this.fld_lblInfo.Text = "Mã hàng trắng: 0001 - Mã Cụm && Chi tiết: A1";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(1077, 704);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSave.TabIndex = 3;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.panel2);
            this.bosPanel1.Controls.Add(this.fld_btnSave);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1168, 737);
            this.bosPanel1.TabIndex = 406;
            // 
            // bosPanel2
            // 
            this.bosPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosLine1);
            this.bosPanel2.Controls.Add(this.splitter2);
            this.bosPanel2.Location = new System.Drawing.Point(3, 172);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1162, 529);
            this.bosPanel2.TabIndex = 405;
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_bolProcessPanel);
            this.bosLine1.Controls.Add(this.bosLine2);
            this.bosLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosLine1.Location = new System.Drawing.Point(0, 0);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(1159, 529);
            this.bosLine1.TabIndex = 421;
            this.bosLine1.TabStop = false;
            // 
            // fld_bolProcessPanel
            // 
            this.fld_bolProcessPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_bolProcessPanel.BOSComment = null;
            this.fld_bolProcessPanel.BOSDataMember = null;
            this.fld_bolProcessPanel.BOSDataSource = null;
            this.fld_bolProcessPanel.BOSDescription = null;
            this.fld_bolProcessPanel.BOSError = null;
            this.fld_bolProcessPanel.BOSFieldGroup = null;
            this.fld_bolProcessPanel.BOSFieldRelation = null;
            this.fld_bolProcessPanel.BOSPrivilege = null;
            this.fld_bolProcessPanel.BOSPropertyName = null;
            this.fld_bolProcessPanel.Controls.Add(this.bosLabel1);
            this.fld_bolProcessPanel.Controls.Add(this.fld_btnProcessPanel);
            this.fld_bolProcessPanel.Controls.Add(this.fld_lkeMMOperationID);
            this.fld_bolProcessPanel.Controls.Add(this.fld_btnCopyProcess);
            this.fld_bolProcessPanel.Controls.Add(this.bosLookupEdit1);
            this.fld_bolProcessPanel.Controls.Add(this.bosLabel3);
            this.fld_bolProcessPanel.Controls.Add(this.bosLabel4);
            this.fld_bolProcessPanel.Controls.Add(this.fld_lkeCarcassForCopy);
            this.fld_bolProcessPanel.Controls.Add(this.bosLabel2);
            this.fld_bolProcessPanel.Controls.Add(this.fld_lkeMMProcessID);
            this.fld_bolProcessPanel.Controls.Add(this.fld_dgcICProductItemProcess);
            this.fld_bolProcessPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_bolProcessPanel.Location = new System.Drawing.Point(6, 26);
            this.fld_bolProcessPanel.Name = "fld_bolProcessPanel";
            this.fld_bolProcessPanel.Screen = null;
            this.fld_bolProcessPanel.Size = new System.Drawing.Size(1147, 361);
            this.fld_bolProcessPanel.TabIndex = 404;
            this.fld_bolProcessPanel.TabStop = false;
            this.fld_bolProcessPanel.Text = "Thông tin Quy trình sản xuất";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(18, 46);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 418;
            this.bosLabel1.Text = "Công đoạn";
            // 
            // fld_btnProcessPanel
            // 
            this.fld_btnProcessPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnProcessPanel.BOSComment = null;
            this.fld_btnProcessPanel.BOSDataMember = null;
            this.fld_btnProcessPanel.BOSDataSource = null;
            this.fld_btnProcessPanel.BOSDescription = null;
            this.fld_btnProcessPanel.BOSError = null;
            this.fld_btnProcessPanel.BOSFieldGroup = null;
            this.fld_btnProcessPanel.BOSFieldRelation = null;
            this.fld_btnProcessPanel.BOSPrivilege = null;
            this.fld_btnProcessPanel.BOSPropertyName = null;
            this.fld_btnProcessPanel.Location = new System.Drawing.Point(1119, 11);
            this.fld_btnProcessPanel.Name = "fld_btnProcessPanel";
            this.fld_btnProcessPanel.Screen = null;
            this.fld_btnProcessPanel.Size = new System.Drawing.Size(22, 22);
            this.fld_btnProcessPanel.TabIndex = 420;
            this.fld_btnProcessPanel.Text = "❐";
            this.fld_btnProcessPanel.Click += new System.EventHandler(this.Fld_btnProcessPanel_Click);
            // 
            // fld_lkeMMOperationID
            // 
            this.fld_lkeMMOperationID.BOSAllowAddNew = false;
            this.fld_lkeMMOperationID.BOSAllowDummy = false;
            this.fld_lkeMMOperationID.BOSComment = "";
            this.fld_lkeMMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeMMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationID.BOSDescription = null;
            this.fld_lkeMMOperationID.BOSError = null;
            this.fld_lkeMMOperationID.BOSFieldGroup = "";
            this.fld_lkeMMOperationID.BOSFieldParent = "";
            this.fld_lkeMMOperationID.BOSFieldRelation = "";
            this.fld_lkeMMOperationID.BOSPrivilege = "";
            this.fld_lkeMMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationID.BOSSelectType = "";
            this.fld_lkeMMOperationID.BOSSelectTypeValue = "";
            this.fld_lkeMMOperationID.CurrentDisplayText = "";
            this.fld_lkeMMOperationID.Location = new System.Drawing.Point(138, 43);
            this.fld_lkeMMOperationID.Name = "fld_lkeMMOperationID";
            this.fld_lkeMMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationID.Properties.ColumnName = null;
            this.fld_lkeMMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMMachineGroup", "Nhóm máy")});
            this.fld_lkeMMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMOperationID.Properties.NullText = "";
            this.fld_lkeMMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationID, true);
            this.fld_lkeMMOperationID.Size = new System.Drawing.Size(208, 20);
            this.fld_lkeMMOperationID.TabIndex = 419;
            this.fld_lkeMMOperationID.Tag = "DC";
            this.fld_lkeMMOperationID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMOperationID_KeyUp);
            // 
            // fld_btnCopyProcess
            // 
            this.fld_btnCopyProcess.BOSComment = null;
            this.fld_btnCopyProcess.BOSDataMember = null;
            this.fld_btnCopyProcess.BOSDataSource = null;
            this.fld_btnCopyProcess.BOSDescription = null;
            this.fld_btnCopyProcess.BOSError = null;
            this.fld_btnCopyProcess.BOSFieldGroup = null;
            this.fld_btnCopyProcess.BOSFieldRelation = null;
            this.fld_btnCopyProcess.BOSPrivilege = null;
            this.fld_btnCopyProcess.BOSPropertyName = null;
            this.fld_btnCopyProcess.Location = new System.Drawing.Point(613, 69);
            this.fld_btnCopyProcess.Name = "fld_btnCopyProcess";
            this.fld_btnCopyProcess.Screen = null;
            this.fld_btnCopyProcess.Size = new System.Drawing.Size(75, 20);
            this.fld_btnCopyProcess.TabIndex = 416;
            this.fld_btnCopyProcess.Text = "Sao chép";
            this.fld_btnCopyProcess.Click += new System.EventHandler(this.fld_btnCopyProcess_Click);
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = null;
            this.bosLookupEdit1.BOSDataSource = null;
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = null;
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(392, 69);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductCode", "Mã code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã BTP")});
            this.bosLookupEdit1.Properties.DisplayMember = "ICProductNo";
            this.bosLookupEdit1.Properties.ValueMember = "ICProductID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(208, 20);
            this.bosLookupEdit1.TabIndex = 415;
            this.bosLookupEdit1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit1_QueryPopUp);
            this.bosLookupEdit1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit1_CloseUp);
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(359, 72);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(18, 13);
            this.bosLabel3.TabIndex = 414;
            this.bosLabel3.Text = "BTP";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(18, 72);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(108, 13);
            this.bosLabel4.TabIndex = 412;
            this.bosLabel4.Text = "Sao chép từ hàng mẫu";
            // 
            // fld_lkeCarcassForCopy
            // 
            this.fld_lkeCarcassForCopy.BOSAllowAddNew = false;
            this.fld_lkeCarcassForCopy.BOSAllowDummy = false;
            this.fld_lkeCarcassForCopy.BOSComment = null;
            this.fld_lkeCarcassForCopy.BOSDataMember = null;
            this.fld_lkeCarcassForCopy.BOSDataSource = null;
            this.fld_lkeCarcassForCopy.BOSDescription = null;
            this.fld_lkeCarcassForCopy.BOSError = null;
            this.fld_lkeCarcassForCopy.BOSFieldGroup = null;
            this.fld_lkeCarcassForCopy.BOSFieldParent = null;
            this.fld_lkeCarcassForCopy.BOSFieldRelation = null;
            this.fld_lkeCarcassForCopy.BOSPrivilege = null;
            this.fld_lkeCarcassForCopy.BOSPropertyName = null;
            this.fld_lkeCarcassForCopy.BOSSelectType = null;
            this.fld_lkeCarcassForCopy.BOSSelectTypeValue = null;
            this.fld_lkeCarcassForCopy.CurrentDisplayText = null;
            this.fld_lkeCarcassForCopy.Location = new System.Drawing.Point(138, 69);
            this.fld_lkeCarcassForCopy.MenuManager = this.screenToolbar;
            this.fld_lkeCarcassForCopy.Name = "fld_lkeCarcassForCopy";
            this.fld_lkeCarcassForCopy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCarcassForCopy.Properties.ColumnName = null;
            this.fld_lkeCarcassForCopy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Bảng định mức"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã hàng mẫu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeCarcassForCopy.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeCarcassForCopy.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeCarcassForCopy.Screen = null;
            this.fld_lkeCarcassForCopy.Size = new System.Drawing.Size(208, 20);
            this.fld_lkeCarcassForCopy.TabIndex = 413;
            this.fld_lkeCarcassForCopy.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeCarcassForCopy_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(18, 20);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(90, 13);
            this.bosLabel2.TabIndex = 410;
            this.bosLabel2.Text = "Quy trình sản xuất";
            // 
            // fld_lkeMMProcessID
            // 
            this.fld_lkeMMProcessID.BOSAllowAddNew = false;
            this.fld_lkeMMProcessID.BOSAllowDummy = true;
            this.fld_lkeMMProcessID.BOSComment = "";
            this.fld_lkeMMProcessID.BOSDataMember = "MMProcessID";
            this.fld_lkeMMProcessID.BOSDataSource = "MMProcesss";
            this.fld_lkeMMProcessID.BOSDescription = null;
            this.fld_lkeMMProcessID.BOSError = null;
            this.fld_lkeMMProcessID.BOSFieldGroup = "";
            this.fld_lkeMMProcessID.BOSFieldParent = "";
            this.fld_lkeMMProcessID.BOSFieldRelation = "";
            this.fld_lkeMMProcessID.BOSPrivilege = "";
            this.fld_lkeMMProcessID.BOSPropertyName = "EditValue";
            this.fld_lkeMMProcessID.BOSSelectType = "MMProcessStatus";
            this.fld_lkeMMProcessID.BOSSelectTypeValue = "Approved";
            this.fld_lkeMMProcessID.CurrentDisplayText = "";
            this.fld_lkeMMProcessID.Location = new System.Drawing.Point(138, 17);
            this.fld_lkeMMProcessID.Name = "fld_lkeMMProcessID";
            this.fld_lkeMMProcessID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProcessID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProcessID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProcessID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProcessID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProcessID.Properties.ColumnName = null;
            this.fld_lkeMMProcessID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProcessNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProcessName", "Tên")});
            this.fld_lkeMMProcessID.Properties.DisplayMember = "MMProcessName";
            this.fld_lkeMMProcessID.Properties.NullText = "";
            this.fld_lkeMMProcessID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProcessID.Properties.ValueMember = "MMProcessID";
            this.fld_lkeMMProcessID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProcessID, true);
            this.fld_lkeMMProcessID.Size = new System.Drawing.Size(208, 20);
            this.fld_lkeMMProcessID.TabIndex = 411;
            this.fld_lkeMMProcessID.Tag = "DC";
            this.fld_lkeMMProcessID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMProcessID_KeyUp_1);
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosPictureEdit1);
            this.bosLine2.Controls.Add(this.splitter1);
            this.bosLine2.Controls.Add(this.bosPictureEdit2);
            this.bosLine2.Location = new System.Drawing.Point(6, 393);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(1147, 130);
            this.bosLine2.TabIndex = 417;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Hình ảnh";
            // 
            // bosPictureEdit1
            // 
            this.bosPictureEdit1.BOSComment = null;
            this.bosPictureEdit1.BOSDataMember = null;
            this.bosPictureEdit1.BOSDataSource = null;
            this.bosPictureEdit1.BOSDescription = null;
            this.bosPictureEdit1.BOSError = null;
            this.bosPictureEdit1.BOSFieldGroup = null;
            this.bosPictureEdit1.BOSFieldRelation = null;
            this.bosPictureEdit1.BOSPrivilege = null;
            this.bosPictureEdit1.BOSPropertyName = null;
            this.bosPictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPictureEdit1.FileName = null;
            this.bosPictureEdit1.FilePath = null;
            this.bosPictureEdit1.Location = new System.Drawing.Point(3, 17);
            this.bosPictureEdit1.MenuManager = this.screenToolbar;
            this.bosPictureEdit1.Name = "bosPictureEdit1";
            this.bosPictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit1.Screen = null;
            this.bosPictureEdit1.Size = new System.Drawing.Size(922, 110);
            this.bosPictureEdit1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(925, 17);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 110);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // bosPictureEdit2
            // 
            this.bosPictureEdit2.BOSComment = null;
            this.bosPictureEdit2.BOSDataMember = null;
            this.bosPictureEdit2.BOSDataSource = null;
            this.bosPictureEdit2.BOSDescription = null;
            this.bosPictureEdit2.BOSError = null;
            this.bosPictureEdit2.BOSFieldGroup = null;
            this.bosPictureEdit2.BOSFieldRelation = null;
            this.bosPictureEdit2.BOSPrivilege = null;
            this.bosPictureEdit2.BOSPropertyName = null;
            this.bosPictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bosPictureEdit2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bosPictureEdit2.FileName = null;
            this.bosPictureEdit2.FilePath = null;
            this.bosPictureEdit2.Location = new System.Drawing.Point(928, 17);
            this.bosPictureEdit2.MenuManager = this.screenToolbar;
            this.bosPictureEdit2.Name = "bosPictureEdit2";
            this.bosPictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bosPictureEdit2.Screen = null;
            this.bosPictureEdit2.Size = new System.Drawing.Size(216, 110);
            this.bosPictureEdit2.TabIndex = 1;
            this.bosPictureEdit2.Visible = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1159, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 529);
            this.splitter2.TabIndex = 406;
            this.splitter2.TabStop = false;
            // 
            // guiProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 737);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Quy trình sản xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.guiProcess_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItemProcess)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductInProcessForm)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            this.fld_bolProcessPanel.ResumeLayout(false);
            this.fld_bolProcessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCarcassForCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProcessID.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICProductItemProcesssGridControl fld_dgcICProductItemProcess;
        private System.Windows.Forms.Panel panel2;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSPanel bosPanel1;
        private ProductInProcesssGridControl fld_dgcProductInProcessForm;
        private BOSComponent.BOSLabel fld_lblInfo;
        private BOSComponent.BOSLine fld_bolProcessPanel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeMMProcessID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeCarcassForCopy;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSButton fld_btnCopyProcess;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSPictureEdit bosPictureEdit1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationID;
        private BOSComponent.BOSPictureEdit bosPictureEdit2;
        private System.Windows.Forms.Splitter splitter1;
        private BOSComponent.BOSPanel bosPanel2;
        private System.Windows.Forms.Splitter splitter2;
        private BOSComponent.BOSButton fld_btnProcessPanel;
        private BOSComponent.BOSLine bosLine1;
    }
}
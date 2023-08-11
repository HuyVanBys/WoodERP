namespace BOSERP.Modules.Report
{
    partial class RP198
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_MMProposalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblSubTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRP198MMProposalItems = new BOSERP.Modules.Report.RP198MMProposalItemsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProposalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP198MMProposalItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.panelControl1.Controls.Add(this.fld_lkeFK_MMProposalID);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(866, 72);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = null;
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "MMProposals";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = null;
            this.fld_lkeACObjectAccessKey.BOSFieldParent = null;
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = null;
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = null;
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = null;
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(288, 38);
            this.fld_lkeACObjectAccessKey.MenuManager = this.screenToolbar;
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 4;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // fld_lkeFK_MMProposalID
            // 
            this.fld_lkeFK_MMProposalID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProposalID.BOSAllowDummy = true;
            this.fld_lkeFK_MMProposalID.BOSComment = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSDataMember = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSDataSource = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSDescription = null;
            this.fld_lkeFK_MMProposalID.BOSError = null;
            this.fld_lkeFK_MMProposalID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProposalID.BOSSelectType = string.Empty;
            this.fld_lkeFK_MMProposalID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_MMProposalID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProposalID.Location = new System.Drawing.Point(78, 38);
            this.fld_lkeFK_MMProposalID.Name = "fld_lkeFK_MMProposalID";
            this.fld_lkeFK_MMProposalID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMProposalID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMProposalID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMProposalID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMProposalID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProposalID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProposalNo", "Mã đề nghị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProposalName", "Tên đề nghị")});
            this.fld_lkeFK_MMProposalID.Properties.DisplayMember = "MMProposalNo";
            this.fld_lkeFK_MMProposalID.Properties.NullText = string.Empty;
            this.fld_lkeFK_MMProposalID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMProposalID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProposalID.Properties.ValueMember = "MMProposalID";
            this.fld_lkeFK_MMProposalID.Screen = null;
            this.fld_lkeFK_MMProposalID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMProposalID.TabIndex = 3;
            this.fld_lkeFK_MMProposalID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 121;
            this.bosLabel1.Text = "Mã đề nghị";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = string.Empty;
            this.fld_dteSearchToDate.BOSDataSource = string.Empty;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(288, 12);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 1;
            this.fld_dteSearchToDate.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = string.Empty;
            this.bosLabel4.BOSDataMember = string.Empty;
            this.bosLabel4.BOSDataSource = string.Empty;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = string.Empty;
            this.bosLabel4.BOSFieldRelation = string.Empty;
            this.bosLabel4.BOSPrivilege = string.Empty;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(234, 39);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 91;
            this.bosLabel4.Tag = string.Empty;
            this.bosLabel4.Text = "Đối tượng";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(234, 13);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = string.Empty;
            this.fld_dteSearchFromDate.BOSDataSource = string.Empty;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(78, 12);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 0;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(12, 13);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 10;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(448, 33);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(84, 27);
            this.fld_btnApply.TabIndex = 5;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.Location = new System.Drawing.Point(779, 639);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblTitle.Appearance.Options.UseFont = true;
            this.fld_lblTitle.BOSComment = null;
            this.fld_lblTitle.BOSDataMember = null;
            this.fld_lblTitle.BOSDataSource = null;
            this.fld_lblTitle.BOSDescription = null;
            this.fld_lblTitle.BOSError = null;
            this.fld_lblTitle.BOSFieldGroup = null;
            this.fld_lblTitle.BOSFieldRelation = null;
            this.fld_lblTitle.BOSPrivilege = null;
            this.fld_lblTitle.BOSPropertyName = null;
            this.fld_lblTitle.Location = new System.Drawing.Point(311, 80);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(263, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Text = "DANH SÁCH ĐỀ NGHỊ SẢN XUẤT";
            // 
            // fld_lblSubTitle
            // 
            this.fld_lblSubTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblSubTitle.Appearance.Options.UseFont = true;
            this.fld_lblSubTitle.BOSComment = null;
            this.fld_lblSubTitle.BOSDataMember = string.Empty;
            this.fld_lblSubTitle.BOSDataSource = string.Empty;
            this.fld_lblSubTitle.BOSDescription = null;
            this.fld_lblSubTitle.BOSError = null;
            this.fld_lblSubTitle.BOSFieldGroup = null;
            this.fld_lblSubTitle.BOSFieldRelation = null;
            this.fld_lblSubTitle.BOSPrivilege = null;
            this.fld_lblSubTitle.BOSPropertyName = null;
            this.fld_lblSubTitle.Location = new System.Drawing.Point(529, 96);
            this.fld_lblSubTitle.Name = "fld_lblSubTitle";
            this.fld_lblSubTitle.Screen = null;
            this.fld_lblSubTitle.Size = new System.Drawing.Size(0, 19);
            this.fld_lblSubTitle.TabIndex = 2;
            this.fld_lblSubTitle.Tag = "HD";
            // 
            // fld_lblFromdateTodate
            // 
            this.fld_lblFromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblFromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lblFromdateTodate.BOSComment = null;
            this.fld_lblFromdateTodate.BOSDataMember = string.Empty;
            this.fld_lblFromdateTodate.BOSDataSource = string.Empty;
            this.fld_lblFromdateTodate.BOSDescription = null;
            this.fld_lblFromdateTodate.BOSError = null;
            this.fld_lblFromdateTodate.BOSFieldGroup = null;
            this.fld_lblFromdateTodate.BOSFieldRelation = null;
            this.fld_lblFromdateTodate.BOSPrivilege = null;
            this.fld_lblFromdateTodate.BOSPropertyName = null;
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(287, 121);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(0, 16);
            this.fld_lblFromdateTodate.TabIndex = 3;
            this.fld_lblFromdateTodate.Tag = "HD";
            // 
            // fld_dgcRP198MMProposalItems
            // 
            this.fld_dgcRP198MMProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP198MMProposalItems.BOSComment = null;
            this.fld_dgcRP198MMProposalItems.BOSDataMember = null;
            this.fld_dgcRP198MMProposalItems.BOSDataSource = "MMProposalItems";
            this.fld_dgcRP198MMProposalItems.BOSDescription = null;
            this.fld_dgcRP198MMProposalItems.BOSError = null;
            this.fld_dgcRP198MMProposalItems.BOSFieldGroup = null;
            this.fld_dgcRP198MMProposalItems.BOSFieldRelation = null;
            this.fld_dgcRP198MMProposalItems.BOSGridType = null;
            this.fld_dgcRP198MMProposalItems.BOSPrivilege = null;
            this.fld_dgcRP198MMProposalItems.BOSPropertyName = null;
            this.fld_dgcRP198MMProposalItems.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_dgcRP198MMProposalItems.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_dgcRP198MMProposalItems.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_dgcRP198MMProposalItems.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_dgcRP198MMProposalItems.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_dgcRP198MMProposalItems.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_dgcRP198MMProposalItems.Location = new System.Drawing.Point(0, 105);
            this.fld_dgcRP198MMProposalItems.MenuManager = this.screenToolbar;
            this.fld_dgcRP198MMProposalItems.Name = "fld_dgcRP198MMProposalItems";
            this.fld_dgcRP198MMProposalItems.PrintReport = false;
            this.fld_dgcRP198MMProposalItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP198MMProposalItems, false);
            this.fld_dgcRP198MMProposalItems.Size = new System.Drawing.Size(866, 528);
            this.fld_dgcRP198MMProposalItems.TabIndex = 6;
            // 
            // RP198
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 674);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcRP198MMProposalItems);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_lblSubTitle);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Name = "RP198";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đề nghị sản xuất";
            this.Load += new System.EventHandler(this.RP198_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblSubTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_dgcRP198MMProposalItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProposalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP198MMProposalItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSLabel fld_lblSubTitle;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProposalID;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private RP198MMProposalItemsGridControl fld_dgcRP198MMProposalItems;
    }
}
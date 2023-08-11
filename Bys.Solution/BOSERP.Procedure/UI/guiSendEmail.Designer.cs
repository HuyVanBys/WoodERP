namespace BOSERP
{
    partial class guiSendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiSendEmail));
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_linklblAdd = new System.Windows.Forms.LinkLabel();
            this.fld_chklstHRMailAttachment = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fld_lkeHRMailPriority = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblMailPriority = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnSend = new BOSComponent.BOSButton(this.components);
            this.fld_rtbContent = new BOSERP.RichTextBoxExtended();
            this.fld_lblContent = new BOSComponent.BOSLabel(this.components);
            this.fld_lblAttachment = new BOSComponent.BOSLabel(this.components);
            this.fld_txtSubject = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblSubject = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMEPatientContactEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblMailTo = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMailPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMEPatientContactEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_linklblAdd);
            this.bosGroupControl1.Controls.Add(this.fld_chklstHRMailAttachment);
            this.bosGroupControl1.Controls.Add(this.pictureBox1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeHRMailPriority);
            this.bosGroupControl1.Controls.Add(this.fld_lblMailPriority);
            this.bosGroupControl1.Controls.Add(this.fld_btnCancel);
            this.bosGroupControl1.Controls.Add(this.fld_btnSend);
            this.bosGroupControl1.Controls.Add(this.fld_rtbContent);
            this.bosGroupControl1.Controls.Add(this.fld_lblContent);
            this.bosGroupControl1.Controls.Add(this.fld_lblAttachment);
            this.bosGroupControl1.Controls.Add(this.fld_txtSubject);
            this.bosGroupControl1.Controls.Add(this.fld_lblSubject);
            this.bosGroupControl1.Controls.Add(this.fld_txtMEPatientContactEmail);
            this.bosGroupControl1.Controls.Add(this.fld_lblMailTo);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.ShowCaption = false;
            this.bosGroupControl1.Size = new System.Drawing.Size(770, 543);
            this.bosGroupControl1.TabIndex = 6;
            // 
            // fld_linklblAdd
            // 
            this.fld_linklblAdd.AutoSize = true;
            this.fld_linklblAdd.Location = new System.Drawing.Point(144, 166);
            this.fld_linklblAdd.Name = "fld_linklblAdd";
            this.fld_linklblAdd.Size = new System.Drawing.Size(85, 13);
            this.fld_linklblAdd.TabIndex = 69;
            this.fld_linklblAdd.TabStop = true;
            this.fld_linklblAdd.Tag = "DC";
            this.fld_linklblAdd.Text = "Đính kèm tập tin";
            this.fld_linklblAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fld_linklblAdd_LinkClicked);
            // 
            // fld_chklstHRMailAttachment
            // 
            this.fld_chklstHRMailAttachment.BackColor = System.Drawing.SystemColors.Window;
            this.fld_chklstHRMailAttachment.FormattingEnabled = true;
            this.fld_chklstHRMailAttachment.Location = new System.Drawing.Point(118, 86);
            this.fld_chklstHRMailAttachment.Name = "fld_chklstHRMailAttachment";
            this.fld_chklstHRMailAttachment.Size = new System.Drawing.Size(342, 68);
            this.fld_chklstHRMailAttachment.TabIndex = 68;
            this.fld_chklstHRMailAttachment.Tag = "DC";
            this.fld_chklstHRMailAttachment.SelectedIndexChanged += new System.EventHandler(this.fld_chklstHRMailAttachment_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(118, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // fld_lkeHRMailPriority
            // 
            this.fld_lkeHRMailPriority.BOSAllowAddNew = false;
            this.fld_lkeHRMailPriority.BOSAllowDummy = false;
            this.fld_lkeHRMailPriority.BOSComment = null;
            this.fld_lkeHRMailPriority.BOSDataMember = "HRMailPriority";
            this.fld_lkeHRMailPriority.BOSDataSource = "HRMails";
            this.fld_lkeHRMailPriority.BOSDescription = null;
            this.fld_lkeHRMailPriority.BOSError = null;
            this.fld_lkeHRMailPriority.BOSFieldGroup = null;
            this.fld_lkeHRMailPriority.BOSFieldParent = null;
            this.fld_lkeHRMailPriority.BOSFieldRelation = null;
            this.fld_lkeHRMailPriority.BOSPrivilege = null;
            this.fld_lkeHRMailPriority.BOSPropertyName = "Edit Value";
            this.fld_lkeHRMailPriority.BOSSelectType = null;
            this.fld_lkeHRMailPriority.BOSSelectTypeValue = null;
            this.fld_lkeHRMailPriority.CurrentDisplayText = null;
            this.fld_lkeHRMailPriority.Location = new System.Drawing.Point(118, 60);
            this.fld_lkeHRMailPriority.MenuManager = this.screenToolbar;
            this.fld_lkeHRMailPriority.Name = "fld_lkeHRMailPriority";
            this.fld_lkeHRMailPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRMailPriority.Properties.DisplayMember = "HRMailPriority";
            this.fld_lkeHRMailPriority.Properties.NullText = "";
            this.fld_lkeHRMailPriority.Properties.Tag = "";
            this.fld_lkeHRMailPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRMailPriority.Properties.ValueMember = "HRMailPriority";
            this.fld_lkeHRMailPriority.Screen = null;
            this.fld_lkeHRMailPriority.Size = new System.Drawing.Size(342, 20);
            this.fld_lkeHRMailPriority.TabIndex = 67;
            this.fld_lkeHRMailPriority.Tag = "DC";
            // 
            // fld_lblMailPriority
            // 
            this.fld_lblMailPriority.BOSComment = null;
            this.fld_lblMailPriority.BOSDataMember = null;
            this.fld_lblMailPriority.BOSDataSource = null;
            this.fld_lblMailPriority.BOSDescription = null;
            this.fld_lblMailPriority.BOSError = null;
            this.fld_lblMailPriority.BOSFieldGroup = null;
            this.fld_lblMailPriority.BOSFieldRelation = null;
            this.fld_lblMailPriority.BOSPrivilege = null;
            this.fld_lblMailPriority.BOSPropertyName = null;
            this.fld_lblMailPriority.Location = new System.Drawing.Point(17, 63);
            this.fld_lblMailPriority.Name = "fld_lblMailPriority";
            this.fld_lblMailPriority.Screen = null;
            this.fld_lblMailPriority.Size = new System.Drawing.Size(76, 13);
            this.fld_lblMailPriority.TabIndex = 66;
            this.fld_lblMailPriority.Text = "Mức độ ưu tiên:";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(199, 511);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 65;
            this.fld_btnCancel.Text = "Cancel";
            // 
            // fld_btnSend
            // 
            this.fld_btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnSend.BOSComment = null;
            this.fld_btnSend.BOSDataMember = null;
            this.fld_btnSend.BOSDataSource = null;
            this.fld_btnSend.BOSDescription = null;
            this.fld_btnSend.BOSError = null;
            this.fld_btnSend.BOSFieldGroup = null;
            this.fld_btnSend.BOSFieldRelation = null;
            this.fld_btnSend.BOSPrivilege = null;
            this.fld_btnSend.BOSPropertyName = null;
            this.fld_btnSend.Location = new System.Drawing.Point(118, 511);
            this.fld_btnSend.Name = "fld_btnSend";
            this.fld_btnSend.Screen = null;
            this.fld_btnSend.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSend.TabIndex = 64;
            this.fld_btnSend.Text = "Send";
            this.fld_btnSend.Click += new System.EventHandler(this.fld_btnSend_Click);
            // 
            // fld_rtbContent
            // 
            this.fld_rtbContent.AcceptsTab = true;
            this.fld_rtbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_rtbContent.AutoWordSelection = true;
            this.fld_rtbContent.DetectURLs = false;
            this.fld_rtbContent.Location = new System.Drawing.Point(118, 193);
            this.fld_rtbContent.Name = "fld_rtbContent";
            this.fld_rtbContent.ReadOnly = false;
            // 
            // 
            // 
            this.fld_rtbContent.RichTextBox.AcceptsTab = true;
            this.fld_rtbContent.RichTextBox.AutoWordSelection = true;
            this.fld_rtbContent.RichTextBox.CodeColor_Comment = System.Drawing.Color.Green;
            this.fld_rtbContent.RichTextBox.CodeColor_Function = System.Drawing.Color.CornflowerBlue;
            this.fld_rtbContent.RichTextBox.CodeColor_Keyword = System.Drawing.Color.Blue;
            this.fld_rtbContent.RichTextBox.CodeColor_PlainText = System.Drawing.Color.Black;
            this.fld_rtbContent.RichTextBox.CodeColor_Type = System.Drawing.Color.CornflowerBlue;
            this.fld_rtbContent.RichTextBox.CodeImage_Class = ((System.Drawing.Image)(resources.GetObject("fld_rtbContent.RichTextBox.CodeImage_Class")));
            this.fld_rtbContent.RichTextBox.CodeImage_Event = ((System.Drawing.Image)(resources.GetObject("fld_rtbContent.RichTextBox.CodeImage_Event")));
            this.fld_rtbContent.RichTextBox.CodeImage_Interface = ((System.Drawing.Image)(resources.GetObject("fld_rtbContent.RichTextBox.CodeImage_Interface")));
            this.fld_rtbContent.RichTextBox.CodeImage_Method = ((System.Drawing.Image)(resources.GetObject("fld_rtbContent.RichTextBox.CodeImage_Method")));
            this.fld_rtbContent.RichTextBox.CodeImage_Namespace = ((System.Drawing.Image)(resources.GetObject("fld_rtbContent.RichTextBox.CodeImage_Namespace")));
            this.fld_rtbContent.RichTextBox.CodeImage_Property = ((System.Drawing.Image)(resources.GetObject("fld_rtbContent.RichTextBox.CodeImage_Property")));
            this.fld_rtbContent.RichTextBox.CodeWords_Comments = ((System.Collections.Generic.List<string>)(resources.GetObject("fld_rtbContent.RichTextBox.CodeWords_Comments")));
            this.fld_rtbContent.RichTextBox.CodeWords_Functions = ((System.Collections.Generic.List<string>)(resources.GetObject("fld_rtbContent.RichTextBox.CodeWords_Functions")));
            this.fld_rtbContent.RichTextBox.CodeWords_Keywords = ((System.Collections.Generic.List<string>)(resources.GetObject("fld_rtbContent.RichTextBox.CodeWords_Keywords")));
            this.fld_rtbContent.RichTextBox.CodeWords_ScopeOperators = ((System.Collections.Generic.List<string>)(resources.GetObject("fld_rtbContent.RichTextBox.CodeWords_ScopeOperators")));
            this.fld_rtbContent.RichTextBox.CodeWords_Types = ((System.Collections.Generic.List<string>)(resources.GetObject("fld_rtbContent.RichTextBox.CodeWords_Types")));
            this.fld_rtbContent.RichTextBox.DetectUrls = false;
            this.fld_rtbContent.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_rtbContent.RichTextBox.Font = new System.Drawing.Font("Courier New", 8F);
            this.fld_rtbContent.RichTextBox.IntellisenseKey = System.Windows.Forms.Keys.Space;
            // 
            // 
            // 
            this.fld_rtbContent.RichTextBox.IntellisenseTree.LineColor = System.Drawing.Color.Empty;
            this.fld_rtbContent.RichTextBox.IntellisenseTree.Location = new System.Drawing.Point(0, 0);
            this.fld_rtbContent.RichTextBox.IntellisenseTree.Name = "";
            this.fld_rtbContent.RichTextBox.IntellisenseTree.TabIndex = 0;
            this.fld_rtbContent.RichTextBox.Location = new System.Drawing.Point(0, 26);
            this.fld_rtbContent.RichTextBox.Name = "rtb1";
            this.fld_rtbContent.RichTextBox.Size = new System.Drawing.Size(632, 286);
            this.fld_rtbContent.RichTextBox.TabIndex = 1;
            this.fld_rtbContent.RichTextBox.WordWrap = false;
            this.fld_rtbContent.ShowBold = true;
            this.fld_rtbContent.ShowCenterJustify = true;
            this.fld_rtbContent.ShowColors = true;
            this.fld_rtbContent.ShowCopy = true;
            this.fld_rtbContent.ShowCut = true;
            this.fld_rtbContent.ShowFont = true;
            this.fld_rtbContent.ShowFontSize = true;
            this.fld_rtbContent.ShowItalic = true;
            this.fld_rtbContent.ShowLeftJustify = true;
            this.fld_rtbContent.ShowOpen = true;
            this.fld_rtbContent.ShowPaste = true;
            this.fld_rtbContent.ShowRedo = true;
            this.fld_rtbContent.ShowRightJustify = true;
            this.fld_rtbContent.ShowSave = true;
            this.fld_rtbContent.ShowStamp = true;
            this.fld_rtbContent.ShowStrikeout = true;
            this.fld_rtbContent.ShowToolBarText = false;
            this.fld_rtbContent.ShowUnderline = true;
            this.fld_rtbContent.ShowUndo = true;
            this.fld_rtbContent.Size = new System.Drawing.Size(632, 312);
            this.fld_rtbContent.StampAction = BOSERP.StampActions.EditedBy;
            this.fld_rtbContent.StampColor = System.Drawing.Color.Blue;
            this.fld_rtbContent.TabIndex = 63;
            // 
            // 
            // 
            this.fld_rtbContent.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.fld_rtbContent.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.fld_rtbContent.Toolbar.Divider = false;
            this.fld_rtbContent.Toolbar.DropDownArrows = true;
            this.fld_rtbContent.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.fld_rtbContent.Toolbar.Name = "tb1";
            this.fld_rtbContent.Toolbar.ShowToolTips = true;
            this.fld_rtbContent.Toolbar.Size = new System.Drawing.Size(632, 26);
            this.fld_rtbContent.Toolbar.TabIndex = 0;
            // 
            // fld_lblContent
            // 
            this.fld_lblContent.BOSComment = null;
            this.fld_lblContent.BOSDataMember = null;
            this.fld_lblContent.BOSDataSource = null;
            this.fld_lblContent.BOSDescription = null;
            this.fld_lblContent.BOSError = null;
            this.fld_lblContent.BOSFieldGroup = null;
            this.fld_lblContent.BOSFieldRelation = null;
            this.fld_lblContent.BOSPrivilege = null;
            this.fld_lblContent.BOSPropertyName = null;
            this.fld_lblContent.Location = new System.Drawing.Point(12, 205);
            this.fld_lblContent.Name = "fld_lblContent";
            this.fld_lblContent.Screen = null;
            this.fld_lblContent.Size = new System.Drawing.Size(46, 13);
            this.fld_lblContent.TabIndex = 62;
            this.fld_lblContent.Text = "Nội dung:";
            // 
            // fld_lblAttachment
            // 
            this.fld_lblAttachment.BOSComment = null;
            this.fld_lblAttachment.BOSDataMember = null;
            this.fld_lblAttachment.BOSDataSource = null;
            this.fld_lblAttachment.BOSDescription = null;
            this.fld_lblAttachment.BOSError = null;
            this.fld_lblAttachment.BOSFieldGroup = null;
            this.fld_lblAttachment.BOSFieldRelation = null;
            this.fld_lblAttachment.BOSPrivilege = null;
            this.fld_lblAttachment.BOSPropertyName = null;
            this.fld_lblAttachment.Location = new System.Drawing.Point(17, 95);
            this.fld_lblAttachment.Name = "fld_lblAttachment";
            this.fld_lblAttachment.Screen = null;
            this.fld_lblAttachment.Size = new System.Drawing.Size(82, 13);
            this.fld_lblAttachment.TabIndex = 61;
            this.fld_lblAttachment.Text = "Tập tin đình kèm:";
            // 
            // fld_txtSubject
            // 
            this.fld_txtSubject.BOSComment = null;
            this.fld_txtSubject.BOSDataMember = "HRMailSubject";
            this.fld_txtSubject.BOSDataSource = "HRMails";
            this.fld_txtSubject.BOSDescription = null;
            this.fld_txtSubject.BOSError = null;
            this.fld_txtSubject.BOSFieldGroup = null;
            this.fld_txtSubject.BOSFieldRelation = null;
            this.fld_txtSubject.BOSPrivilege = null;
            this.fld_txtSubject.BOSPropertyName = "Text";
            this.fld_txtSubject.Location = new System.Drawing.Point(118, 34);
            this.fld_txtSubject.Name = "fld_txtSubject";
            this.fld_txtSubject.Screen = null;
            this.fld_txtSubject.Size = new System.Drawing.Size(632, 20);
            this.fld_txtSubject.TabIndex = 60;
            this.fld_txtSubject.Tag = "DC";
            // 
            // fld_lblSubject
            // 
            this.fld_lblSubject.BOSComment = null;
            this.fld_lblSubject.BOSDataMember = null;
            this.fld_lblSubject.BOSDataSource = null;
            this.fld_lblSubject.BOSDescription = null;
            this.fld_lblSubject.BOSError = null;
            this.fld_lblSubject.BOSFieldGroup = null;
            this.fld_lblSubject.BOSFieldRelation = null;
            this.fld_lblSubject.BOSPrivilege = null;
            this.fld_lblSubject.BOSPropertyName = null;
            this.fld_lblSubject.Location = new System.Drawing.Point(17, 37);
            this.fld_lblSubject.Name = "fld_lblSubject";
            this.fld_lblSubject.Screen = null;
            this.fld_lblSubject.Size = new System.Drawing.Size(41, 13);
            this.fld_lblSubject.TabIndex = 59;
            this.fld_lblSubject.Text = "Chủ đề: ";
            // 
            // fld_txtMEPatientContactEmail
            // 
            this.fld_txtMEPatientContactEmail.BOSComment = null;
            this.fld_txtMEPatientContactEmail.BOSDataMember = "MEPatientContactEmail";
            this.fld_txtMEPatientContactEmail.BOSDataSource = "MEPatients";
            this.fld_txtMEPatientContactEmail.BOSDescription = null;
            this.fld_txtMEPatientContactEmail.BOSError = null;
            this.fld_txtMEPatientContactEmail.BOSFieldGroup = null;
            this.fld_txtMEPatientContactEmail.BOSFieldRelation = null;
            this.fld_txtMEPatientContactEmail.BOSPrivilege = null;
            this.fld_txtMEPatientContactEmail.BOSPropertyName = "Text";
            this.fld_txtMEPatientContactEmail.Location = new System.Drawing.Point(118, 8);
            this.fld_txtMEPatientContactEmail.Name = "fld_txtMEPatientContactEmail";
            this.fld_txtMEPatientContactEmail.Screen = null;
            this.fld_txtMEPatientContactEmail.Size = new System.Drawing.Size(632, 20);
            this.fld_txtMEPatientContactEmail.TabIndex = 58;
            this.fld_txtMEPatientContactEmail.Tag = "DC";
            // 
            // fld_lblMailTo
            // 
            this.fld_lblMailTo.BOSComment = null;
            this.fld_lblMailTo.BOSDataMember = null;
            this.fld_lblMailTo.BOSDataSource = null;
            this.fld_lblMailTo.BOSDescription = null;
            this.fld_lblMailTo.BOSError = null;
            this.fld_lblMailTo.BOSFieldGroup = null;
            this.fld_lblMailTo.BOSFieldRelation = null;
            this.fld_lblMailTo.BOSPrivilege = null;
            this.fld_lblMailTo.BOSPropertyName = null;
            this.fld_lblMailTo.Location = new System.Drawing.Point(17, 11);
            this.fld_lblMailTo.Name = "fld_lblMailTo";
            this.fld_lblMailTo.Screen = null;
            this.fld_lblMailTo.Size = new System.Drawing.Size(41, 13);
            this.fld_lblMailTo.TabIndex = 57;
            this.fld_lblMailTo.Text = "Gửi đến:";
            // 
            // guiSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(770, 543);
            this.ControlBox = true;
            this.Controls.Add(this.bosGroupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiSendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gửi Email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.guiSendEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRMailPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMEPatientContactEmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSGroupControl bosGroupControl1;
        private System.Windows.Forms.LinkLabel fld_linklblAdd;
        private System.Windows.Forms.CheckedListBox fld_chklstHRMailAttachment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BOSComponent.BOSLookupEdit fld_lkeHRMailPriority;
        private BOSComponent.BOSLabel fld_lblMailPriority;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnSend;
        private RichTextBoxExtended fld_rtbContent;
        private BOSComponent.BOSLabel fld_lblContent;
        private BOSComponent.BOSLabel fld_lblAttachment;
        private BOSComponent.BOSTextBox fld_txtSubject;
        private BOSComponent.BOSLabel fld_lblSubject;
        private BOSComponent.BOSTextBox fld_txtMEPatientContactEmail;
        private BOSComponent.BOSLabel fld_lblMailTo;



    }
}
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PriceAdjustment.UI
{
	/// <summary>
	/// Summary description for DMPAJ100
	/// </summary>
	partial class DMPAJ100
    {


		/// <summary>
		/// Clean up any resources being used
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
				if (components != null)
					components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcReceiptCDItems = new BOSERP.Modules.PriceAdjustment.ICReceiptItemsGridControl();
            this.fld_pteICReceiptEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICReceiptStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).BeginInit();
            this.fld_tabReceiptItems.SuspendLayout();
            this.fld_tabPageReceiptItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptCDItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_tabReceiptItems);
            this.bosPanel1.Controls.Add(this.fld_pteICReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.BOSLabel2);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptStatus);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(931, 567);
            this.bosPanel1.TabIndex = 534;
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.Location = new System.Drawing.Point(756, 96);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(93, 27);
            this.fld_btnOK.TabIndex = 551;
            this.fld_btnOK.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnOK.Text = "Thêm sản phẩm";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.bosLabel4.Location = new System.Drawing.Point(397, 44);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 550;
            this.bosLabel4.Text = "Tiền";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ICPriceAdjustmentTotalCost";
            this.bosTextBox2.BOSDataSource = "ICPriceAdjustments";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(495, 41);
            this.bosTextBox2.MenuManager = this.screenToolbar;
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(173, 20);
            this.bosTextBox2.TabIndex = 549;
            this.bosTextBox2.Tag = "DC";
            this.bosTextBox2.Validated += new System.EventHandler(this.bosTextBox2_Validated);
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
            this.bosLabel3.Location = new System.Drawing.Point(127, 44);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(65, 13);
            this.bosLabel3.TabIndex = 548;
            this.bosLabel3.Text = "Tên chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICPriceAdjustmentName";
            this.bosTextBox1.BOSDataSource = "ICPriceAdjustments";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(211, 41);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 547;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_medICReceiptDesc
            // 
            this.fld_medICReceiptDesc.BOSComment = null;
            this.fld_medICReceiptDesc.BOSDataMember = "ICPriceAdjustmentDesc";
            this.fld_medICReceiptDesc.BOSDataSource = "ICPriceAdjustments";
            this.fld_medICReceiptDesc.BOSDescription = null;
            this.fld_medICReceiptDesc.BOSError = null;
            this.fld_medICReceiptDesc.BOSFieldGroup = null;
            this.fld_medICReceiptDesc.BOSFieldRelation = null;
            this.fld_medICReceiptDesc.BOSPrivilege = null;
            this.fld_medICReceiptDesc.BOSPropertyName = "Text";
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(211, 67);
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(457, 56);
            this.fld_medICReceiptDesc.TabIndex = 10;
            this.fld_medICReceiptDesc.Tag = "DC";
            // 
            // fld_tabReceiptItems
            // 
            this.fld_tabReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabReceiptItems.BOSComment = null;
            this.fld_tabReceiptItems.BOSDataMember = null;
            this.fld_tabReceiptItems.BOSDataSource = null;
            this.fld_tabReceiptItems.BOSDescription = null;
            this.fld_tabReceiptItems.BOSError = null;
            this.fld_tabReceiptItems.BOSFieldGroup = null;
            this.fld_tabReceiptItems.BOSFieldRelation = null;
            this.fld_tabReceiptItems.BOSPrivilege = null;
            this.fld_tabReceiptItems.BOSPropertyName = null;
            this.fld_tabReceiptItems.Location = new System.Drawing.Point(0, 129);
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.fld_tabReceiptItems.Size = new System.Drawing.Size(928, 435);
            this.fld_tabReceiptItems.TabIndex = 10;
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_dgcReceiptCDItems);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.fld_tabPageReceiptItems.Size = new System.Drawing.Size(921, 406);
            this.fld_tabPageReceiptItems.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcReceiptCDItems
            // 
            this.fld_dgcReceiptCDItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcReceiptCDItems.BOSComment = null;
            this.fld_dgcReceiptCDItems.BOSDataMember = null;
            this.fld_dgcReceiptCDItems.BOSDataSource = "ICPriceAdjustmentItems";
            this.fld_dgcReceiptCDItems.BOSDescription = null;
            this.fld_dgcReceiptCDItems.BOSError = null;
            this.fld_dgcReceiptCDItems.BOSFieldGroup = null;
            this.fld_dgcReceiptCDItems.BOSFieldRelation = null;
            this.fld_dgcReceiptCDItems.BOSGridType = null;
            this.fld_dgcReceiptCDItems.BOSPrivilege = null;
            this.fld_dgcReceiptCDItems.BOSPropertyName = null;
            this.fld_dgcReceiptCDItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcReceiptCDItems.MenuManager = this.screenToolbar;
            this.fld_dgcReceiptCDItems.Name = "fld_dgcReceiptCDItems";
            this.fld_dgcReceiptCDItems.PrintReport = false;
            this.fld_dgcReceiptCDItems.Screen = null;
            this.fld_dgcReceiptCDItems.Size = new System.Drawing.Size(915, 400);
            this.fld_dgcReceiptCDItems.TabIndex = 1;
            // 
            // fld_pteICReceiptEmployeePicture
            // 
            this.fld_pteICReceiptEmployeePicture.BOSComment = null;
            this.fld_pteICReceiptEmployeePicture.BOSDataMember = "ICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.BOSDataSource = "ICReceipts";
            this.fld_pteICReceiptEmployeePicture.BOSDescription = null;
            this.fld_pteICReceiptEmployeePicture.BOSError = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICReceiptEmployeePicture.BOSPrivilege = null;
            this.fld_pteICReceiptEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICReceiptEmployeePicture.Name = "fld_pteICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptEmployeePicture.Screen = null;
            this.fld_pteICReceiptEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICReceiptEmployeePicture.TabIndex = 0;
            this.fld_pteICReceiptEmployeePicture.Tag = "DC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(397, 15);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel2.TabIndex = 508;
            this.BOSLabel2.Text = "Ngày chứng từ";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = null;
            this.fld_Lablel2.BOSDataMember = null;
            this.fld_Lablel2.BOSDataSource = null;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = null;
            this.fld_Lablel2.BOSFieldRelation = null;
            this.fld_Lablel2.BOSPrivilege = null;
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(690, 15);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 478;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(127, 70);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 482;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_dteICReceiptDate
            // 
            this.fld_dteICReceiptDate.BOSComment = null;
            this.fld_dteICReceiptDate.BOSDataMember = "ICPriceAdjustmentDate";
            this.fld_dteICReceiptDate.BOSDataSource = "ICPriceAdjustments";
            this.fld_dteICReceiptDate.BOSDescription = null;
            this.fld_dteICReceiptDate.BOSError = null;
            this.fld_dteICReceiptDate.BOSFieldGroup = null;
            this.fld_dteICReceiptDate.BOSFieldRelation = null;
            this.fld_dteICReceiptDate.BOSPrivilege = null;
            this.fld_dteICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptDate.EditValue = null;
            this.fld_dteICReceiptDate.Location = new System.Drawing.Point(495, 12);
            this.fld_dteICReceiptDate.MenuManager = this.screenToolbar;
            this.fld_dteICReceiptDate.Name = "fld_dteICReceiptDate";
            this.fld_dteICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate.Screen = null;
            this.fld_dteICReceiptDate.Size = new System.Drawing.Size(173, 20);
            this.fld_dteICReceiptDate.TabIndex = 2;
            this.fld_dteICReceiptDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 103);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(127, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 510;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_lkeICReceiptStatus
            // 
            this.fld_lkeICReceiptStatus.BOSAllowAddNew = false;
            this.fld_lkeICReceiptStatus.BOSAllowDummy = false;
            this.fld_lkeICReceiptStatus.BOSComment = null;
            this.fld_lkeICReceiptStatus.BOSDataMember = "ICPriceAdjustmentStatus";
            this.fld_lkeICReceiptStatus.BOSDataSource = "ICPriceAdjustments";
            this.fld_lkeICReceiptStatus.BOSDescription = null;
            this.fld_lkeICReceiptStatus.BOSError = null;
            this.fld_lkeICReceiptStatus.BOSFieldGroup = null;
            this.fld_lkeICReceiptStatus.BOSFieldParent = null;
            this.fld_lkeICReceiptStatus.BOSFieldRelation = null;
            this.fld_lkeICReceiptStatus.BOSPrivilege = null;
            this.fld_lkeICReceiptStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptStatus.BOSSelectType = null;
            this.fld_lkeICReceiptStatus.BOSSelectTypeValue = null;
            this.fld_lkeICReceiptStatus.CurrentDisplayText = null;
            this.fld_lkeICReceiptStatus.Location = new System.Drawing.Point(756, 12);
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.fld_lkeICReceiptStatus.Size = new System.Drawing.Size(173, 20);
            this.fld_lkeICReceiptStatus.TabIndex = 3;
            this.fld_lkeICReceiptStatus.Tag = "DC";
            // 
            // fld_txtICReceiptNo
            // 
            this.fld_txtICReceiptNo.BOSComment = null;
            this.fld_txtICReceiptNo.BOSDataMember = "ICPriceAdjustmentNo";
            this.fld_txtICReceiptNo.BOSDataSource = "ICPriceAdjustments";
            this.fld_txtICReceiptNo.BOSDescription = null;
            this.fld_txtICReceiptNo.BOSError = null;
            this.fld_txtICReceiptNo.BOSFieldGroup = null;
            this.fld_txtICReceiptNo.BOSFieldRelation = null;
            this.fld_txtICReceiptNo.BOSPrivilege = null;
            this.fld_txtICReceiptNo.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptNo.Location = new System.Drawing.Point(211, 12);
            this.fld_txtICReceiptNo.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptNo.Name = "fld_txtICReceiptNo";
            this.fld_txtICReceiptNo.Screen = null;
            this.fld_txtICReceiptNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptNo.TabIndex = 1;
            this.fld_txtICReceiptNo.Tag = "DC";
            // 
            // DMPAJ100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(931, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPAJ100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).EndInit();
            this.fld_tabReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptCDItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
        private BOSComponent.BOSTabControl fld_tabReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReceiptItems;
        private BOSERP.Modules.PriceAdjustment.ICReceiptItemsGridControl fld_dgcReceiptCDItems;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteICReceiptDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptStatus;
        private BOSComponent.BOSTextBox fld_txtICReceiptNo;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSButton fld_btnOK;
	}
}

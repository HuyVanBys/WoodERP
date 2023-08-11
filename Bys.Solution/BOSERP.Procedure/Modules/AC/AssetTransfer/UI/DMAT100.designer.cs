using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AssetTransfer.UI
{
	/// <summary>
	/// Summary description for DMAT100
	/// </summary>
	partial class DMAT100
	{
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSTextBox fld_txtACDocumentNo1;
		private BOSComponent.BOSDateEdit fld_dteACDocumentDate2;
		private BOSComponent.BOSMemoEdit fld_medACDocumentDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;


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
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACDocumentDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medACDocumentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteACDocumentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ACAssetID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAssetTransferItems = new BOSERP.Modules.AssetTransfer.AssetTransferItemGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssetTransferItems)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(122, 11);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 4;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(400, 11);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel5.TabIndex = 5;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(122, 37);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(35, 13);
            this.fld_lblLabel6.TabIndex = 6;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_txtACDocumentNo1
            // 
            this.fld_txtACDocumentNo1.BOSComment = "";
            this.fld_txtACDocumentNo1.BOSDataMember = "ACDocumentNo";
            this.fld_txtACDocumentNo1.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentNo1.BOSDescription = null;
            this.fld_txtACDocumentNo1.BOSError = null;
            this.fld_txtACDocumentNo1.BOSFieldGroup = "";
            this.fld_txtACDocumentNo1.BOSFieldRelation = "";
            this.fld_txtACDocumentNo1.BOSPrivilege = "";
            this.fld_txtACDocumentNo1.BOSPropertyName = "Text";
            this.fld_txtACDocumentNo1.EditValue = "";
            this.fld_txtACDocumentNo1.Location = new System.Drawing.Point(205, 8);
            this.fld_txtACDocumentNo1.Name = "fld_txtACDocumentNo1";
            this.fld_txtACDocumentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentNo1.Screen = null;
            this.fld_txtACDocumentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentNo1.TabIndex = 1;
            this.fld_txtACDocumentNo1.Tag = "DC";
            // 
            // fld_dteACDocumentDate2
            // 
            this.fld_dteACDocumentDate2.BOSComment = "";
            this.fld_dteACDocumentDate2.BOSDataMember = "ACDocumentDate";
            this.fld_dteACDocumentDate2.BOSDataSource = "ACDocuments";
            this.fld_dteACDocumentDate2.BOSDescription = null;
            this.fld_dteACDocumentDate2.BOSError = null;
            this.fld_dteACDocumentDate2.BOSFieldGroup = "";
            this.fld_dteACDocumentDate2.BOSFieldRelation = "";
            this.fld_dteACDocumentDate2.BOSPrivilege = "";
            this.fld_dteACDocumentDate2.BOSPropertyName = "EditValue";
            this.fld_dteACDocumentDate2.EditValue = null;
            this.fld_dteACDocumentDate2.Location = new System.Drawing.Point(498, 8);
            this.fld_dteACDocumentDate2.Name = "fld_dteACDocumentDate2";
            this.fld_dteACDocumentDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACDocumentDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACDocumentDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACDocumentDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACDocumentDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACDocumentDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACDocumentDate2.Screen = null;
            this.fld_dteACDocumentDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACDocumentDate2.TabIndex = 2;
            this.fld_dteACDocumentDate2.Tag = "DC";
            // 
            // fld_medACDocumentDesc
            // 
            this.fld_medACDocumentDesc.BOSComment = "";
            this.fld_medACDocumentDesc.BOSDataMember = "ACDocumentDesc";
            this.fld_medACDocumentDesc.BOSDataSource = "ACDocuments";
            this.fld_medACDocumentDesc.BOSDescription = null;
            this.fld_medACDocumentDesc.BOSError = null;
            this.fld_medACDocumentDesc.BOSFieldGroup = "";
            this.fld_medACDocumentDesc.BOSFieldRelation = "";
            this.fld_medACDocumentDesc.BOSPrivilege = "";
            this.fld_medACDocumentDesc.BOSPropertyName = "Text";
            this.fld_medACDocumentDesc.EditValue = "";
            this.fld_medACDocumentDesc.Location = new System.Drawing.Point(205, 34);
            this.fld_medACDocumentDesc.Name = "fld_medACDocumentDesc";
            this.fld_medACDocumentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACDocumentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACDocumentDesc.Screen = null;
            this.fld_medACDocumentDesc.Size = new System.Drawing.Size(605, 42);
            this.fld_medACDocumentDesc.TabIndex = 3;
            this.fld_medACDocumentDesc.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 102);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 7;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_pteACDocumentEmployeePicture
            // 
            this.fld_pteACDocumentEmployeePicture.BOSComment = null;
            this.fld_pteACDocumentEmployeePicture.BOSDataMember = "ACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.BOSDataSource = "ACDocuments";
            this.fld_pteACDocumentEmployeePicture.BOSDescription = null;
            this.fld_pteACDocumentEmployeePicture.BOSError = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACDocumentEmployeePicture.BOSPrivilege = null;
            this.fld_pteACDocumentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACDocumentEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteACDocumentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACDocumentEmployeePicture.Name = "fld_pteACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.Screen = null;
            this.fld_pteACDocumentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACDocumentEmployeePicture.TabIndex = 8;
            this.fld_pteACDocumentEmployeePicture.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAssetID);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_dgcAssetTransferItems);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 128);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(855, 347);
            this.bosGroupControl1.TabIndex = 6;
            this.bosGroupControl1.Text = "Danh sách tài sản";
            // 
            // fld_lkeFK_ACAssetID
            // 
            this.fld_lkeFK_ACAssetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ACAssetID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssetID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAssetID.BOSComment = null;
            this.fld_lkeFK_ACAssetID.BOSDataMember = "FK_ACAssetID";
            this.fld_lkeFK_ACAssetID.BOSDataSource = "ACAssetTransferItems";
            this.fld_lkeFK_ACAssetID.BOSDescription = null;
            this.fld_lkeFK_ACAssetID.BOSError = null;
            this.fld_lkeFK_ACAssetID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAssetID.BOSFieldParent = null;
            this.fld_lkeFK_ACAssetID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAssetID.BOSPrivilege = null;
            this.fld_lkeFK_ACAssetID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssetID.BOSSelectType = "ACAssetStatus";
            this.fld_lkeFK_ACAssetID.BOSSelectTypeValue = "Purchased;Using;UsingWithoutDepreciation";
            this.fld_lkeFK_ACAssetID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssetID.Location = new System.Drawing.Point(78, 27);
            this.fld_lkeFK_ACAssetID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACAssetID.Name = "fld_lkeFK_ACAssetID";
            this.fld_lkeFK_ACAssetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssetID.Properties.DisplayMember = "ACAssetName";
            this.fld_lkeFK_ACAssetID.Properties.ValueMember = "ACAssetID";
            this.fld_lkeFK_ACAssetID.Screen = null;
            this.fld_lkeFK_ACAssetID.Size = new System.Drawing.Size(767, 20);
            this.fld_lkeFK_ACAssetID.TabIndex = 1;
            this.fld_lkeFK_ACAssetID.Tag = "DC";
            this.fld_lkeFK_ACAssetID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ACAssetID_KeyUp);
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
            this.bosLabel1.Location = new System.Drawing.Point(20, 30);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(34, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Tài sản";
            // 
            // fld_dgcAssetTransferItems
            // 
            this.fld_dgcAssetTransferItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAssetTransferItems.BOSComment = null;
            this.fld_dgcAssetTransferItems.BOSDataMember = null;
            this.fld_dgcAssetTransferItems.BOSDataSource = "ACAssetTransferItems";
            this.fld_dgcAssetTransferItems.BOSDescription = null;
            this.fld_dgcAssetTransferItems.BOSError = null;
            this.fld_dgcAssetTransferItems.BOSFieldGroup = null;
            this.fld_dgcAssetTransferItems.BOSFieldRelation = null;
            this.fld_dgcAssetTransferItems.BOSGridType = null;
            this.fld_dgcAssetTransferItems.BOSPrivilege = null;
            this.fld_dgcAssetTransferItems.BOSPropertyName = null;
            this.fld_dgcAssetTransferItems.Location = new System.Drawing.Point(5, 58);
            this.fld_dgcAssetTransferItems.MenuManager = this.screenToolbar;
            this.fld_dgcAssetTransferItems.Name = "fld_dgcAssetTransferItems";
            this.fld_dgcAssetTransferItems.Screen = null;
            this.fld_dgcAssetTransferItems.Size = new System.Drawing.Size(845, 284);
            this.fld_dgcAssetTransferItems.TabIndex = 2;
            this.fld_dgcAssetTransferItems.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_pteACDocumentEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_medACDocumentDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteACDocumentDate2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentNo1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 483);
            this.bosPanel1.TabIndex = 13;
            // 
            // DMAT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 483);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssetTransferItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteACDocumentEmployeePicture;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private AssetTransferItemGridControl fld_dgcAssetTransferItems;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAssetID;
        private BOSComponent.BOSPanel bosPanel1;
	}
}

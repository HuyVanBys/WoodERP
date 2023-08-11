using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ShipmentProposal.UI
{
	/// <summary>
	/// Summary description for DMSP100
	/// </summary>
	partial class DMSP100
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
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICShipmentProposalProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabelSaleOrderType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICShipmentProposalType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICShipmentProposalActualDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICShipmentProposalDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICShipmentProposalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICShipmentProposalName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICShipmentProposalEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICShipmentStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICShipmentProposalDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtICShipmentProposalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICShipmentProposalItems = new BOSERP.Modules.ShipmentProposal.ICShipmentProposalItemsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvICShipmentProposalItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProposalProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProposalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalActualDeliveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalActualDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDeliveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentProposalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentProposalEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentProposalDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentProposalNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentProposalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosTextBox3);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentProposalProductType);
            this.bosPanel1.Controls.Add(this.fld_lblLabelSaleOrderType);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentProposalType);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentProposalActualDeliveryDate);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentProposalDeliveryDate);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentProposalDate);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentProposalName);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_pteICShipmentProposalEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_lkeICShipmentStatus);
            this.bosPanel1.Controls.Add(this.fld_medICShipmentProposalDesc);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentProposalNo);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(1218, 590);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(124, 68);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel10.TabIndex = 585;
            this.fld_lblLabel10.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(214, 64);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 9;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(983, 68);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(46, 13);
            this.bosLabel19.TabIndex = 583;
            this.bosLabel19.Text = "Số PO.No";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSDataMember = "ICShipmentProposalPONo";
            this.bosTextBox3.BOSDataSource = "ICShipmentProposals";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.Location = new System.Drawing.Point(1044, 65);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.Properties.ReadOnly = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox3, true);
            this.bosTextBox3.Size = new System.Drawing.Size(149, 20);
            this.bosTextBox3.TabIndex = 12;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ICStockID";
            this.bosLookupEdit1.BOSDataSource = "ICShipmentProposals";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "ICProductAttributeGroup";
            this.bosLookupEdit1.BOSSelectTypeValue = "TTMT";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(1043, 39);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.bosLookupEdit1.Properties.DisplayMember = "ICStockName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ICStockID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 8;
            this.bosLookupEdit1.Tag = "DC";
            this.bosLookupEdit1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.bosLookupEdit1_CloseUp);
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(983, 42);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(18, 13);
            this.bosLabel13.TabIndex = 115;
            this.bosLabel13.Text = "Kho";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(1043, 12);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 4;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(983, 15);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(26, 13);
            this.bosLabel12.TabIndex = 113;
            this.bosLabel12.Text = "TTMT";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(393, 93);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(34, 13);
            this.bosLabel11.TabIndex = 111;
            this.bosLabel11.Text = "Mã LSX";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(495, 90);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMBatchProductID, true);
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 14;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(679, 68);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(67, 13);
            this.bosLabel8.TabIndex = 109;
            this.bosLabel8.Text = "Loại hàng hóa";
            // 
            // fld_lkeICShipmentProposalProductType
            // 
            this.fld_lkeICShipmentProposalProductType.BOSAllowAddNew = false;
            this.fld_lkeICShipmentProposalProductType.BOSAllowDummy = false;
            this.fld_lkeICShipmentProposalProductType.BOSComment = null;
            this.fld_lkeICShipmentProposalProductType.BOSDataMember = "ICShipmentProposalProductType";
            this.fld_lkeICShipmentProposalProductType.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeICShipmentProposalProductType.BOSDescription = null;
            this.fld_lkeICShipmentProposalProductType.BOSError = null;
            this.fld_lkeICShipmentProposalProductType.BOSFieldGroup = null;
            this.fld_lkeICShipmentProposalProductType.BOSFieldParent = null;
            this.fld_lkeICShipmentProposalProductType.BOSFieldRelation = null;
            this.fld_lkeICShipmentProposalProductType.BOSPrivilege = null;
            this.fld_lkeICShipmentProposalProductType.BOSPropertyName = "EditValue";
            this.fld_lkeICShipmentProposalProductType.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICShipmentProposalProductType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICShipmentProposalProductType.CurrentDisplayText = null;
            this.fld_lkeICShipmentProposalProductType.Location = new System.Drawing.Point(801, 65);
            this.fld_lkeICShipmentProposalProductType.Name = "fld_lkeICShipmentProposalProductType";
            this.fld_lkeICShipmentProposalProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICShipmentProposalProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICShipmentProposalProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICShipmentProposalProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICShipmentProposalProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentProposalProductType.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICShipmentProposalProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICShipmentProposalProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICShipmentProposalProductType, true);
            this.fld_lkeICShipmentProposalProductType.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeICShipmentProposalProductType.TabIndex = 11;
            this.fld_lkeICShipmentProposalProductType.Tag = "DC";
            this.fld_lkeICShipmentProposalProductType.EditValueChanged += new System.EventHandler(this.fld_lkeICShipmentProposalProductType_EditValueChanged);
            // 
            // fld_lblLabelSaleOrderType
            // 
            this.fld_lblLabelSaleOrderType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelSaleOrderType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabelSaleOrderType.Appearance.Options.UseBackColor = true;
            this.fld_lblLabelSaleOrderType.Appearance.Options.UseForeColor = true;
            this.fld_lblLabelSaleOrderType.BOSComment = null;
            this.fld_lblLabelSaleOrderType.BOSDataMember = null;
            this.fld_lblLabelSaleOrderType.BOSDataSource = null;
            this.fld_lblLabelSaleOrderType.BOSDescription = null;
            this.fld_lblLabelSaleOrderType.BOSError = null;
            this.fld_lblLabelSaleOrderType.BOSFieldGroup = null;
            this.fld_lblLabelSaleOrderType.BOSFieldRelation = null;
            this.fld_lblLabelSaleOrderType.BOSPrivilege = null;
            this.fld_lblLabelSaleOrderType.BOSPropertyName = null;
            this.fld_lblLabelSaleOrderType.Location = new System.Drawing.Point(393, 67);
            this.fld_lblLabelSaleOrderType.Name = "fld_lblLabelSaleOrderType";
            this.fld_lblLabelSaleOrderType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabelSaleOrderType, true);
            this.fld_lblLabelSaleOrderType.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabelSaleOrderType.TabIndex = 107;
            this.fld_lblLabelSaleOrderType.Text = "Loại đơn hàng";
            // 
            // fld_lkeICShipmentProposalType
            // 
            this.fld_lkeICShipmentProposalType.BOSAllowAddNew = false;
            this.fld_lkeICShipmentProposalType.BOSAllowDummy = false;
            this.fld_lkeICShipmentProposalType.BOSComment = null;
            this.fld_lkeICShipmentProposalType.BOSDataMember = "ICShipmentProposalType";
            this.fld_lkeICShipmentProposalType.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeICShipmentProposalType.BOSDescription = null;
            this.fld_lkeICShipmentProposalType.BOSError = null;
            this.fld_lkeICShipmentProposalType.BOSFieldGroup = null;
            this.fld_lkeICShipmentProposalType.BOSFieldParent = null;
            this.fld_lkeICShipmentProposalType.BOSFieldRelation = null;
            this.fld_lkeICShipmentProposalType.BOSPrivilege = null;
            this.fld_lkeICShipmentProposalType.BOSPropertyName = "EditValue";
            this.fld_lkeICShipmentProposalType.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICShipmentProposalType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICShipmentProposalType.CurrentDisplayText = null;
            this.fld_lkeICShipmentProposalType.Location = new System.Drawing.Point(495, 64);
            this.fld_lkeICShipmentProposalType.Name = "fld_lkeICShipmentProposalType";
            this.fld_lkeICShipmentProposalType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICShipmentProposalType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICShipmentProposalType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICShipmentProposalType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICShipmentProposalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentProposalType.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeICShipmentProposalType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICShipmentProposalType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICShipmentProposalType, true);
            this.fld_lkeICShipmentProposalType.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeICShipmentProposalType.TabIndex = 10;
            this.fld_lkeICShipmentProposalType.Tag = "DC";
            this.fld_lkeICShipmentProposalType.EditValueChanged += new System.EventHandler(this.fld_lkeICShipmentProposalType_EditValueChanged);
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ICShipmentProposalVehicle";
            this.bosTextBox2.BOSDataSource = "ICShipmentProposals";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(801, 90);
            this.bosTextBox2.MenuManager = this.screenToolbar;
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, false);
            this.bosTextBox2.Size = new System.Drawing.Size(142, 20);
            this.bosTextBox2.TabIndex = 15;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(679, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(108, 13);
            this.bosLabel6.TabIndex = 24;
            this.bosLabel6.Text = "Phương tiện giao hàng";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICShipmentProposalReference";
            this.bosTextBox1.BOSDataSource = "ICShipmentProposals";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(214, 90);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, false);
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 13;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(124, 93);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(61, 13);
            this.bosLabel4.TabIndex = 22;
            this.bosLabel4.Text = "Mã SaleOder";
            // 
            // fld_dteICShipmentProposalActualDeliveryDate
            // 
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSDataMember = "ICShipmentProposalActualDeliveryDate";
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSDataSource = "ICShipmentProposals";
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSDescription = null;
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSError = null;
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalActualDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentProposalActualDeliveryDate.EditValue = null;
            this.fld_dteICShipmentProposalActualDeliveryDate.Location = new System.Drawing.Point(801, 39);
            this.fld_dteICShipmentProposalActualDeliveryDate.Name = "fld_dteICShipmentProposalActualDeliveryDate";
            this.fld_dteICShipmentProposalActualDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentProposalActualDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentProposalActualDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentProposalActualDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentProposalActualDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentProposalActualDeliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentProposalActualDeliveryDate.Screen = null;
            this.fld_dteICShipmentProposalActualDeliveryDate.Size = new System.Drawing.Size(142, 20);
            this.fld_dteICShipmentProposalActualDeliveryDate.TabIndex = 7;
            this.fld_dteICShipmentProposalActualDeliveryDate.Tag = "DC";
            // 
            // fld_dteICShipmentProposalDeliveryDate
            // 
            this.fld_dteICShipmentProposalDeliveryDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDeliveryDate.BOSDataMember = "ICShipmentProposalDeliveryDate";
            this.fld_dteICShipmentProposalDeliveryDate.BOSDataSource = "ICShipmentProposals";
            this.fld_dteICShipmentProposalDeliveryDate.BOSDescription = null;
            this.fld_dteICShipmentProposalDeliveryDate.BOSError = null;
            this.fld_dteICShipmentProposalDeliveryDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDeliveryDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDeliveryDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentProposalDeliveryDate.EditValue = null;
            this.fld_dteICShipmentProposalDeliveryDate.Location = new System.Drawing.Point(495, 38);
            this.fld_dteICShipmentProposalDeliveryDate.Name = "fld_dteICShipmentProposalDeliveryDate";
            this.fld_dteICShipmentProposalDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentProposalDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentProposalDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentProposalDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentProposalDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentProposalDeliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentProposalDeliveryDate.Screen = null;
            this.fld_dteICShipmentProposalDeliveryDate.Size = new System.Drawing.Size(142, 20);
            this.fld_dteICShipmentProposalDeliveryDate.TabIndex = 6;
            this.fld_dteICShipmentProposalDeliveryDate.Tag = "DC";
            // 
            // fld_dteICShipmentProposalDate
            // 
            this.fld_dteICShipmentProposalDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDate.BOSDataMember = "ICShipmentProposalDate";
            this.fld_dteICShipmentProposalDate.BOSDataSource = "ICShipmentProposals";
            this.fld_dteICShipmentProposalDate.BOSDescription = null;
            this.fld_dteICShipmentProposalDate.BOSError = null;
            this.fld_dteICShipmentProposalDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteICShipmentProposalDate.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentProposalDate.EditValue = null;
            this.fld_dteICShipmentProposalDate.Location = new System.Drawing.Point(495, 12);
            this.fld_dteICShipmentProposalDate.Name = "fld_dteICShipmentProposalDate";
            this.fld_dteICShipmentProposalDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentProposalDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentProposalDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentProposalDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentProposalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentProposalDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentProposalDate.Screen = null;
            this.fld_dteICShipmentProposalDate.Size = new System.Drawing.Size(142, 20);
            this.fld_dteICShipmentProposalDate.TabIndex = 2;
            this.fld_dteICShipmentProposalDate.Tag = "DC";
            // 
            // fld_txtICShipmentProposalName
            // 
            this.fld_txtICShipmentProposalName.BOSComment = null;
            this.fld_txtICShipmentProposalName.BOSDataMember = "ICShipmentProposalName";
            this.fld_txtICShipmentProposalName.BOSDataSource = "ICShipmentProposals";
            this.fld_txtICShipmentProposalName.BOSDescription = null;
            this.fld_txtICShipmentProposalName.BOSError = null;
            this.fld_txtICShipmentProposalName.BOSFieldGroup = null;
            this.fld_txtICShipmentProposalName.BOSFieldRelation = null;
            this.fld_txtICShipmentProposalName.BOSPrivilege = null;
            this.fld_txtICShipmentProposalName.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentProposalName.Location = new System.Drawing.Point(214, 38);
            this.fld_txtICShipmentProposalName.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentProposalName.Name = "fld_txtICShipmentProposalName";
            this.fld_txtICShipmentProposalName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICShipmentProposalName, false);
            this.fld_txtICShipmentProposalName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentProposalName.TabIndex = 5;
            this.fld_txtICShipmentProposalName.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(124, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(65, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Text = "Tên chứng từ";
            // 
            // fld_pteICShipmentProposalEmployeePicture
            // 
            this.fld_pteICShipmentProposalEmployeePicture.BOSComment = null;
            this.fld_pteICShipmentProposalEmployeePicture.BOSDataMember = "ICShipmentProposalEmployeePicture";
            this.fld_pteICShipmentProposalEmployeePicture.BOSDataSource = "ICShipmentProposals";
            this.fld_pteICShipmentProposalEmployeePicture.BOSDescription = null;
            this.fld_pteICShipmentProposalEmployeePicture.BOSError = null;
            this.fld_pteICShipmentProposalEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICShipmentProposalEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICShipmentProposalEmployeePicture.BOSPrivilege = null;
            this.fld_pteICShipmentProposalEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentProposalEmployeePicture.Location = new System.Drawing.Point(12, 10);
            this.fld_pteICShipmentProposalEmployeePicture.Name = "fld_pteICShipmentProposalEmployeePicture";
            this.fld_pteICShipmentProposalEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteICShipmentProposalEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteICShipmentProposalEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteICShipmentProposalEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteICShipmentProposalEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentProposalEmployeePicture.Screen = null;
            this.fld_pteICShipmentProposalEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICShipmentProposalEmployeePicture.TabIndex = 14;
            this.fld_pteICShipmentProposalEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(12, 112);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_lkeICShipmentStatus
            // 
            this.fld_lkeICShipmentStatus.BOSAllowAddNew = false;
            this.fld_lkeICShipmentStatus.BOSAllowDummy = false;
            this.fld_lkeICShipmentStatus.BOSComment = null;
            this.fld_lkeICShipmentStatus.BOSDataMember = "ICShipmentProposalStatus";
            this.fld_lkeICShipmentStatus.BOSDataSource = "ICShipmentProposals";
            this.fld_lkeICShipmentStatus.BOSDescription = null;
            this.fld_lkeICShipmentStatus.BOSError = null;
            this.fld_lkeICShipmentStatus.BOSFieldGroup = null;
            this.fld_lkeICShipmentStatus.BOSFieldParent = null;
            this.fld_lkeICShipmentStatus.BOSFieldRelation = null;
            this.fld_lkeICShipmentStatus.BOSPrivilege = null;
            this.fld_lkeICShipmentStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICShipmentStatus.BOSSelectType = null;
            this.fld_lkeICShipmentStatus.BOSSelectTypeValue = null;
            this.fld_lkeICShipmentStatus.CurrentDisplayText = null;
            this.fld_lkeICShipmentStatus.Location = new System.Drawing.Point(801, 12);
            this.fld_lkeICShipmentStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICShipmentStatus.Name = "fld_lkeICShipmentStatus";
            this.fld_lkeICShipmentStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeICShipmentStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICShipmentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICShipmentProposalStatus", "Tình trạng")});
            this.fld_lkeICShipmentStatus.Properties.ReadOnly = true;
            this.fld_lkeICShipmentStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICShipmentStatus, true);
            this.fld_lkeICShipmentStatus.Size = new System.Drawing.Size(142, 20);
            this.fld_lkeICShipmentStatus.TabIndex = 3;
            this.fld_lkeICShipmentStatus.Tag = "DC";
            // 
            // fld_medICShipmentProposalDesc
            // 
            this.fld_medICShipmentProposalDesc.BOSComment = null;
            this.fld_medICShipmentProposalDesc.BOSDataMember = "ICShipmentProposalDesc";
            this.fld_medICShipmentProposalDesc.BOSDataSource = "ICShipmentProposals";
            this.fld_medICShipmentProposalDesc.BOSDescription = null;
            this.fld_medICShipmentProposalDesc.BOSError = null;
            this.fld_medICShipmentProposalDesc.BOSFieldGroup = null;
            this.fld_medICShipmentProposalDesc.BOSFieldRelation = null;
            this.fld_medICShipmentProposalDesc.BOSPrivilege = null;
            this.fld_medICShipmentProposalDesc.BOSPropertyName = "EditValue";
            this.fld_medICShipmentProposalDesc.Location = new System.Drawing.Point(214, 118);
            this.fld_medICShipmentProposalDesc.MenuManager = this.screenToolbar;
            this.fld_medICShipmentProposalDesc.Name = "fld_medICShipmentProposalDesc";
            this.fld_medICShipmentProposalDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICShipmentProposalDesc, false);
            this.fld_medICShipmentProposalDesc.Size = new System.Drawing.Size(729, 37);
            this.fld_medICShipmentProposalDesc.TabIndex = 16;
            this.fld_medICShipmentProposalDesc.Tag = "DC";
            // 
            // fld_txtICShipmentProposalNo
            // 
            this.fld_txtICShipmentProposalNo.BOSComment = null;
            this.fld_txtICShipmentProposalNo.BOSDataMember = "ICShipmentProposalNo";
            this.fld_txtICShipmentProposalNo.BOSDataSource = "ICShipmentProposals";
            this.fld_txtICShipmentProposalNo.BOSDescription = null;
            this.fld_txtICShipmentProposalNo.BOSError = null;
            this.fld_txtICShipmentProposalNo.BOSFieldGroup = null;
            this.fld_txtICShipmentProposalNo.BOSFieldRelation = null;
            this.fld_txtICShipmentProposalNo.BOSPrivilege = null;
            this.fld_txtICShipmentProposalNo.BOSPropertyName = "EditValue";
            this.fld_txtICShipmentProposalNo.Location = new System.Drawing.Point(214, 12);
            this.fld_txtICShipmentProposalNo.MenuManager = this.screenToolbar;
            this.fld_txtICShipmentProposalNo.Name = "fld_txtICShipmentProposalNo";
            this.fld_txtICShipmentProposalNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICShipmentProposalNo, false);
            this.fld_txtICShipmentProposalNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICShipmentProposalNo.TabIndex = 1;
            this.fld_txtICShipmentProposalNo.Tag = "DC";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcICShipmentProposalItems);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel20);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 161);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, true);
            this.bosGroupControl2.Size = new System.Drawing.Size(1212, 426);
            this.bosGroupControl2.TabIndex = 10;
            this.bosGroupControl2.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcICShipmentProposalItems
            // 
            this.fld_dgcICShipmentProposalItems.AllowDrop = true;
            this.fld_dgcICShipmentProposalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentProposalItems.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcICShipmentProposalItems.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcICShipmentProposalItems.BOSDataSource = "ICShipmentProposalItems";
            this.fld_dgcICShipmentProposalItems.BOSDescription = null;
            this.fld_dgcICShipmentProposalItems.BOSError = null;
            this.fld_dgcICShipmentProposalItems.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcICShipmentProposalItems.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcICShipmentProposalItems.BOSGridType = null;
            this.fld_dgcICShipmentProposalItems.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcICShipmentProposalItems.BOSPropertyName = null;
            this.fld_dgcICShipmentProposalItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICShipmentProposalItems.Location = new System.Drawing.Point(10, 51);
            this.fld_dgcICShipmentProposalItems.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcICShipmentProposalItems.Name = "fld_dgcICShipmentProposalItems";
            this.fld_dgcICShipmentProposalItems.PrintReport = false;
            this.fld_dgcICShipmentProposalItems.Screen = null;
            this.fld_dgcICShipmentProposalItems.Size = new System.Drawing.Size(1202, 375);
            this.fld_dgcICShipmentProposalItems.TabIndex = 1;
            this.fld_dgcICShipmentProposalItems.Tag = "DC";
            this.fld_dgcICShipmentProposalItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcICShipmentProposalItems;
            this.fld_dgvICShipmentItems.Name = "fld_dgvICShipmentItems";
            this.fld_dgvICShipmentItems.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.BOSPropertyName = null;
            this.fld_lblLabel20.Location = new System.Drawing.Point(10, 28);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel20, true);
            this.fld_lblLabel20.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel20.TabIndex = 0;
            this.fld_lblLabel20.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel20.Text = "Sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICShipmentProposalItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(63, 25);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeSerialNo", "No")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID, true);
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(1144, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
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
            this.bosLabel1.Location = new System.Drawing.Point(124, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosLabel10.Location = new System.Drawing.Point(679, 41);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(88, 13);
            this.bosLabel10.TabIndex = 4;
            this.bosLabel10.Text = "Ngày xuất thực tế";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(124, 121);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 12;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel9.Location = new System.Drawing.Point(393, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(96, 13);
            this.bosLabel9.TabIndex = 4;
            this.bosLabel9.Text = "Ngày xuất kế hoạch";
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
            this.bosLabel3.Location = new System.Drawing.Point(679, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(393, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Ngày chứng từ";
            // 
            // fld_dgvICShipmentProposalItems
            // 
            this.fld_dgvICShipmentProposalItems.Name = "fld_dgvICShipmentProposalItems";
            this.fld_dgvICShipmentProposalItems.PaintStyleName = "Office2003";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // DMSP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1218, 590);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProposalProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentProposalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalActualDeliveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalActualDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDeliveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentProposalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentProposalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentProposalEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentProposalDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentProposalNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentProposalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentStatus;
        private BOSComponent.BOSMemoEdit fld_medICShipmentProposalDesc;
        private BOSComponent.BOSTextBox fld_txtICShipmentProposalNo;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentProposalItemProductPicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel7;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentProposalItems;
        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ICShipmentProposalItemsGridControl fld_dgcICShipmentProposalItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentProposalEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSTextBox fld_txtICShipmentProposalName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteICShipmentProposalActualDeliveryDate;
        private BOSComponent.BOSDateEdit fld_dteICShipmentProposalDeliveryDate;
        private BOSComponent.BOSDateEdit fld_dteICShipmentProposalDate;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_lblLabelSaleOrderType;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentProposalType;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentProposalProductType;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
	}
}

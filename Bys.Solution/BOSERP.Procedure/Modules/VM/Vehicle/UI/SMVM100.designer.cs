using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Vehicle.UI
{
	/// <summary>
	/// Summary description for SMVM100
	/// </summary>
	partial class SMVM100
	{
		private BOSComponent.BOSLookupEdit fld_lkeFK_VMVehicleGroupID1;
		private BOSComponent.BOSTextBox fld_txtVMVehicleNo1;
		private BOSComponent.BOSTextBox fld_txtVMVehicleName1;
        private BOSComponent.BOSTextBox fld_txtVMVehicleNoPlate1;
        private BOSComponent.BOSDateEdit fld_dteVMVehiclePurchaseDate1;


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
            this.fld_lkeFK_VMVehicleGroupID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtVMVehicleNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleNoPlate1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteVMVehiclePurchaseDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcVMVehicle = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_VMVehicleGroupID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNoPlate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_VMVehicleGroupID1
            // 
            this.fld_lkeFK_VMVehicleGroupID1.BOSAllowAddNew = false;
            this.fld_lkeFK_VMVehicleGroupID1.BOSAllowDummy = true;
            this.fld_lkeFK_VMVehicleGroupID1.BOSComment = "";
            this.fld_lkeFK_VMVehicleGroupID1.BOSDataMember = "FK_VMVehicleGroupID";
            this.fld_lkeFK_VMVehicleGroupID1.BOSDataSource = "VMVehicles";
            this.fld_lkeFK_VMVehicleGroupID1.BOSDescription = null;
            this.fld_lkeFK_VMVehicleGroupID1.BOSError = null;
            this.fld_lkeFK_VMVehicleGroupID1.BOSFieldGroup = "";
            this.fld_lkeFK_VMVehicleGroupID1.BOSFieldParent = "";
            this.fld_lkeFK_VMVehicleGroupID1.BOSFieldRelation = "";
            this.fld_lkeFK_VMVehicleGroupID1.BOSPrivilege = "";
            this.fld_lkeFK_VMVehicleGroupID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_VMVehicleGroupID1.BOSSelectType = "";
            this.fld_lkeFK_VMVehicleGroupID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_VMVehicleGroupID1.CurrentDisplayText = null;
            this.fld_lkeFK_VMVehicleGroupID1.Location = new System.Drawing.Point(135, 91);
            this.fld_lkeFK_VMVehicleGroupID1.Name = "fld_lkeFK_VMVehicleGroupID1";
            this.fld_lkeFK_VMVehicleGroupID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_VMVehicleGroupID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_VMVehicleGroupID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_VMVehicleGroupID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_VMVehicleGroupID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_VMVehicleGroupID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VMVehicleGroupNo", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VMVehicleGroupDesc", "Mô tả")});
            this.fld_lkeFK_VMVehicleGroupID1.Properties.DisplayMember = "VMVehicleGroupNo";
            this.fld_lkeFK_VMVehicleGroupID1.Properties.NullText = "";
            this.fld_lkeFK_VMVehicleGroupID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_VMVehicleGroupID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_VMVehicleGroupID1.Properties.ValueMember = "VMVehicleGroupID";
            this.fld_lkeFK_VMVehicleGroupID1.Screen = null;
            this.fld_lkeFK_VMVehicleGroupID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_VMVehicleGroupID1.TabIndex = 4;
            this.fld_lkeFK_VMVehicleGroupID1.Tag = "SC";
            // 
            // fld_txtVMVehicleNo1
            // 
            this.fld_txtVMVehicleNo1.BOSComment = "";
            this.fld_txtVMVehicleNo1.BOSDataMember = "VMVehicleNo";
            this.fld_txtVMVehicleNo1.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleNo1.BOSDescription = null;
            this.fld_txtVMVehicleNo1.BOSError = null;
            this.fld_txtVMVehicleNo1.BOSFieldGroup = "";
            this.fld_txtVMVehicleNo1.BOSFieldRelation = "";
            this.fld_txtVMVehicleNo1.BOSPrivilege = "";
            this.fld_txtVMVehicleNo1.BOSPropertyName = "Text";
            this.fld_txtVMVehicleNo1.EditValue = "";
            this.fld_txtVMVehicleNo1.Location = new System.Drawing.Point(135, 63);
            this.fld_txtVMVehicleNo1.Name = "fld_txtVMVehicleNo1";
            this.fld_txtVMVehicleNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleNo1.Screen = null;
            this.fld_txtVMVehicleNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleNo1.TabIndex = 5;
            this.fld_txtVMVehicleNo1.Tag = "SC";
            // 
            // fld_txtVMVehicleName1
            // 
            this.fld_txtVMVehicleName1.BOSComment = "";
            this.fld_txtVMVehicleName1.BOSDataMember = "VMVehicleName";
            this.fld_txtVMVehicleName1.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleName1.BOSDescription = null;
            this.fld_txtVMVehicleName1.BOSError = null;
            this.fld_txtVMVehicleName1.BOSFieldGroup = "";
            this.fld_txtVMVehicleName1.BOSFieldRelation = "";
            this.fld_txtVMVehicleName1.BOSPrivilege = "";
            this.fld_txtVMVehicleName1.BOSPropertyName = "Text";
            this.fld_txtVMVehicleName1.EditValue = "";
            this.fld_txtVMVehicleName1.Location = new System.Drawing.Point(135, 119);
            this.fld_txtVMVehicleName1.Name = "fld_txtVMVehicleName1";
            this.fld_txtVMVehicleName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleName1.Screen = null;
            this.fld_txtVMVehicleName1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleName1.TabIndex = 6;
            this.fld_txtVMVehicleName1.Tag = "SC";
            // 
            // fld_txtVMVehicleNoPlate1
            // 
            this.fld_txtVMVehicleNoPlate1.BOSComment = "";
            this.fld_txtVMVehicleNoPlate1.BOSDataMember = "VMVehicleNoPlate";
            this.fld_txtVMVehicleNoPlate1.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleNoPlate1.BOSDescription = null;
            this.fld_txtVMVehicleNoPlate1.BOSError = null;
            this.fld_txtVMVehicleNoPlate1.BOSFieldGroup = "";
            this.fld_txtVMVehicleNoPlate1.BOSFieldRelation = "";
            this.fld_txtVMVehicleNoPlate1.BOSPrivilege = "";
            this.fld_txtVMVehicleNoPlate1.BOSPropertyName = "Text";
            this.fld_txtVMVehicleNoPlate1.EditValue = "";
            this.fld_txtVMVehicleNoPlate1.Location = new System.Drawing.Point(135, 147);
            this.fld_txtVMVehicleNoPlate1.Name = "fld_txtVMVehicleNoPlate1";
            this.fld_txtVMVehicleNoPlate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleNoPlate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleNoPlate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleNoPlate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleNoPlate1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleNoPlate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleNoPlate1.Screen = null;
            this.fld_txtVMVehicleNoPlate1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleNoPlate1.TabIndex = 7;
            this.fld_txtVMVehicleNoPlate1.Tag = "SC";
            // 
            // fld_dteVMVehiclePurchaseDate1
            // 
            this.fld_dteVMVehiclePurchaseDate1.BOSComment = "";
            this.fld_dteVMVehiclePurchaseDate1.BOSDataMember = "VMVehiclePurchaseDate";
            this.fld_dteVMVehiclePurchaseDate1.BOSDataSource = "VMVehicles";
            this.fld_dteVMVehiclePurchaseDate1.BOSDescription = null;
            this.fld_dteVMVehiclePurchaseDate1.BOSError = null;
            this.fld_dteVMVehiclePurchaseDate1.BOSFieldGroup = "";
            this.fld_dteVMVehiclePurchaseDate1.BOSFieldRelation = "";
            this.fld_dteVMVehiclePurchaseDate1.BOSPrivilege = "";
            this.fld_dteVMVehiclePurchaseDate1.BOSPropertyName = "EditValue";
            this.fld_dteVMVehiclePurchaseDate1.EditValue = null;
            this.fld_dteVMVehiclePurchaseDate1.Location = new System.Drawing.Point(135, 231);
            this.fld_dteVMVehiclePurchaseDate1.Name = "fld_dteVMVehiclePurchaseDate1";
            this.fld_dteVMVehiclePurchaseDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteVMVehiclePurchaseDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteVMVehiclePurchaseDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteVMVehiclePurchaseDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteVMVehiclePurchaseDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteVMVehiclePurchaseDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteVMVehiclePurchaseDate1.Screen = null;
            this.fld_dteVMVehiclePurchaseDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteVMVehiclePurchaseDate1.TabIndex = 10;
            this.fld_dteVMVehiclePurchaseDate1.Tag = "SC";
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
            this.bosLabel1.Location = new System.Drawing.Point(41, 66);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(29, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã xe";
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
            this.bosLabel2.Location = new System.Drawing.Point(41, 94);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(42, 13);
            this.bosLabel2.TabIndex = 16;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Nhóm xe";
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
            this.bosLabel3.Location = new System.Drawing.Point(41, 122);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(33, 13);
            this.bosLabel3.TabIndex = 16;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Tên xe";
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
            this.bosLabel4.Location = new System.Drawing.Point(41, 150);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(34, 13);
            this.bosLabel4.TabIndex = 16;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Biển số";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "VMVehicleType";
            this.bosLookupEdit1.BOSDataSource = "VMVehicles";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(135, 173);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 17;
            this.bosLookupEdit1.Tag = "SC";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "VMVehicleFuelType";
            this.bosLookupEdit2.BOSDataSource = "VMVehicles";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(135, 199);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.PopupWidth = 40;
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit2.TabIndex = 17;
            this.bosLookupEdit2.Tag = "SC";
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
            this.bosLabel5.Location = new System.Drawing.Point(41, 176);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(34, 13);
            this.bosLabel5.TabIndex = 16;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Loại xe";
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
            this.bosLabel6.Location = new System.Drawing.Point(41, 202);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 16;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Loại nhiên liệu";
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
            this.bosLabel7.Location = new System.Drawing.Point(41, 234);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(48, 13);
            this.bosLabel7.TabIndex = 16;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Ngày mua";
            // 
            // fld_dgcVMVehicle
            // 
            this.fld_dgcVMVehicle.BOSComment = null;
            this.fld_dgcVMVehicle.BOSDataMember = null;
            this.fld_dgcVMVehicle.BOSDataSource = "VMVehicles";
            this.fld_dgcVMVehicle.BOSDescription = null;
            this.fld_dgcVMVehicle.BOSError = null;
            this.fld_dgcVMVehicle.BOSFieldGroup = null;
            this.fld_dgcVMVehicle.BOSFieldRelation = null;
            this.fld_dgcVMVehicle.BOSPrivilege = null;
            this.fld_dgcVMVehicle.BOSPropertyName = null;
            this.fld_dgcVMVehicle.Location = new System.Drawing.Point(225, 315);
            this.fld_dgcVMVehicle.MenuManager = this.screenToolbar;
            this.fld_dgcVMVehicle.Name = "fld_dgcVMVehicle";
            this.fld_dgcVMVehicle.Screen = null;
            this.fld_dgcVMVehicle.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcVMVehicle.TabIndex = 18;
            this.fld_dgcVMVehicle.Tag = "SR";
            // 
            // SMVM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcVMVehicle);
            this.Controls.Add(this.bosLookupEdit2);
            this.Controls.Add(this.bosLookupEdit1);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_VMVehicleGroupID1);
            this.Controls.Add(this.fld_txtVMVehicleNo1);
            this.Controls.Add(this.fld_txtVMVehicleName1);
            this.Controls.Add(this.fld_txtVMVehicleNoPlate1);
            this.Controls.Add(this.fld_dteVMVehiclePurchaseDate1);
            this.Name = "SMVM100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteVMVehiclePurchaseDate1, 0);
            this.Controls.SetChildIndex(this.fld_txtVMVehicleNoPlate1, 0);
            this.Controls.SetChildIndex(this.fld_txtVMVehicleName1, 0);
            this.Controls.SetChildIndex(this.fld_txtVMVehicleNo1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_VMVehicleGroupID1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit1, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit2, 0);
            this.Controls.SetChildIndex(this.fld_dgcVMVehicle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_VMVehicleGroupID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNoPlate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSSearchResultsGridControl fld_dgcVMVehicle;
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CreditNote.UI
{
	/// <summary>
	/// Summary description for DMCN100
	/// </summary>
	partial class DMCN100
	{
		private BOSComponent.BOSLabel fld_Lablel;
        private BOSComponent.BOSMemoEdit fld_medARCreditNoteDesc;
        private BOSComponent.BOSLabel fld_lblLabel31;
		private BOSComponent.BOSLabel fld_lblLabel23;
		private BOSComponent.BOSLabel fld_lblLabel24;
        private BOSComponent.BOSTextBox fld_txtARCreditNoteTotalAmount1;
		private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSLookupEdit fld_lkeARCreditNoteType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID2;
		private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSDateEdit fld_dteARCreditNoteValidateDate;


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
            this.fld_Lablel = new BOSComponent.BOSLabel(this.components);
            this.fld_medARCreditNoteDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCreditNoteTotalAmount1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCreditNoteType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARCreditNoteValidateDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCreditNoteTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.BOSDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCreditNoteDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteTotalAmount1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCreditNoteType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCreditNoteValidateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCreditNoteValidateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSGroupControl1)).BeginInit();
            this.BOSGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSDateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_Lablel
            // 
            this.fld_Lablel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_Lablel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_Lablel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel.Appearance.Options.UseBackColor = true;
            this.fld_Lablel.Appearance.Options.UseFont = true;
            this.fld_Lablel.Appearance.Options.UseForeColor = true;
            this.fld_Lablel.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel.BOSDescription = null;
            this.fld_Lablel.BOSError = null;
            this.fld_Lablel.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel.BOSPropertyName = null;
            this.fld_Lablel.Location = new System.Drawing.Point(34, 213);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(41, 13);
            this.fld_Lablel.TabIndex = 6;
            this.fld_Lablel.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel.Text = "Diễn giải";
            // 
            // fld_medARCreditNoteDesc
            // 
            this.fld_medARCreditNoteDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_medARCreditNoteDesc.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medARCreditNoteDesc.BOSDataMember = "ARCreditNoteDesc";
            this.fld_medARCreditNoteDesc.BOSDataSource = "ARCreditNotes";
            this.fld_medARCreditNoteDesc.BOSDescription = null;
            this.fld_medARCreditNoteDesc.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medARCreditNoteDesc.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medARCreditNoteDesc.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medARCreditNoteDesc.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medARCreditNoteDesc.BOSPropertyName = "Text";
            this.fld_medARCreditNoteDesc.Location = new System.Drawing.Point(111, 210);
            this.fld_medARCreditNoteDesc.Name = "fld_medARCreditNoteDesc";
            this.fld_medARCreditNoteDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARCreditNoteDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARCreditNoteDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARCreditNoteDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARCreditNoteDesc.Screen = null;
            this.fld_medARCreditNoteDesc.Size = new System.Drawing.Size(436, 93);
            this.fld_medARCreditNoteDesc.TabIndex = 6;
            this.fld_medARCreditNoteDesc.Tag = "DC";
            // 
            // fld_lblLabel31
            // 
            this.fld_lblLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel31.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel31.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel31.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel31.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel31.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel31.BOSDescription = null;
            this.fld_lblLabel31.BOSError = null;
            this.fld_lblLabel31.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel31.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel31.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel31.BOSPropertyName = null;
            this.fld_lblLabel31.Location = new System.Drawing.Point(188, 373);
            this.fld_lblLabel31.Name = "fld_lblLabel31";
            this.fld_lblLabel31.Screen = null;
            this.fld_lblLabel31.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel31.TabIndex = 372;
            this.fld_lblLabel31.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel23.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseFont = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel23.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel23.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel23.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel23.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel23.BOSPropertyName = null;
            this.fld_lblLabel23.Location = new System.Drawing.Point(315, 109);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel23.TabIndex = 450;
            this.fld_lblLabel23.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel23.Text = "TỔNG TIỀN";
            // 
            // fld_lblLabel24
            // 
            this.fld_lblLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel24.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel24.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel24.Appearance.Options.UseFont = true;
            this.fld_lblLabel24.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel24.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel24.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel24.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel24.BOSDescription = null;
            this.fld_lblLabel24.BOSError = null;
            this.fld_lblLabel24.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel24.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel24.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel24.BOSPropertyName = null;
            this.fld_lblLabel24.Location = new System.Drawing.Point(301, 136);
            this.fld_lblLabel24.Name = "fld_lblLabel24";
            this.fld_lblLabel24.Screen = null;
            this.fld_lblLabel24.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel24.TabIndex = 451;
            this.fld_lblLabel24.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel24.Text = "TIỀN CÒN LẠI";
            // 
            // fld_txtARCreditNoteTotalAmount1
            // 
            this.fld_txtARCreditNoteTotalAmount1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount1.BOSDataMember = "ARCreditNoteRemainedAmount";
            this.fld_txtARCreditNoteTotalAmount1.BOSDataSource = "ARCreditNotes";
            this.fld_txtARCreditNoteTotalAmount1.BOSDescription = null;
            this.fld_txtARCreditNoteTotalAmount1.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount1.BOSPropertyName = "Text";
            this.fld_txtARCreditNoteTotalAmount1.Location = new System.Drawing.Point(397, 132);
            this.fld_txtARCreditNoteTotalAmount1.Name = "fld_txtARCreditNoteTotalAmount1";
            this.fld_txtARCreditNoteTotalAmount1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARCreditNoteTotalAmount1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtARCreditNoteTotalAmount1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCreditNoteTotalAmount1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCreditNoteTotalAmount1.Properties.Appearance.Options.UseFont = true;
            this.fld_txtARCreditNoteTotalAmount1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCreditNoteTotalAmount1.Properties.Mask.EditMask = "n";
            this.fld_txtARCreditNoteTotalAmount1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCreditNoteTotalAmount1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCreditNoteTotalAmount1.Properties.ReadOnly = true;
            this.fld_txtARCreditNoteTotalAmount1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCreditNoteTotalAmount1.Screen = null;
            this.fld_txtARCreditNoteTotalAmount1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCreditNoteTotalAmount1.TabIndex = 5;
            this.fld_txtARCreditNoteTotalAmount1.Tag = "DC";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel28.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel28.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel28.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel28.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel28.BOSPropertyName = null;
            this.fld_lblLabel28.Location = new System.Drawing.Point(34, 135);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel28.TabIndex = 455;
            this.fld_lblLabel28.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel28.Text = "Loại";
            // 
            // fld_lkeARCreditNoteType
            // 
            this.fld_lkeARCreditNoteType.BOSAllowAddNew = false;
            this.fld_lkeARCreditNoteType.BOSAllowDummy = false;
            this.fld_lkeARCreditNoteType.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSDataMember = "ARCreditNoteType";
            this.fld_lkeARCreditNoteType.BOSDataSource = "ARCreditNotes";
            this.fld_lkeARCreditNoteType.BOSDescription = null;
            this.fld_lkeARCreditNoteType.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSPropertyName = "EditValue";
            this.fld_lkeARCreditNoteType.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.Location = new System.Drawing.Point(111, 132);
            this.fld_lkeARCreditNoteType.Name = "fld_lkeARCreditNoteType";
            this.fld_lkeARCreditNoteType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeARCreditNoteType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCreditNoteType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCreditNoteType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCreditNoteType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCreditNoteType.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCreditNoteType.Screen = null;
            this.fld_lkeARCreditNoteType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCreditNoteType.TabIndex = 1;
            this.fld_lkeARCreditNoteType.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID2
            // 
            this.fld_lkeFK_HREmployeeID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID2.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID2.BOSDataSource = "ARCreditNotes";
            this.fld_lkeFK_HREmployeeID2.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID2.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID2.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.Location = new System.Drawing.Point(111, 106);
            this.fld_lkeFK_HREmployeeID2.Name = "fld_lkeFK_HREmployeeID2";
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID2.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID2.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID2.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID2.Screen = null;
            this.fld_lkeFK_HREmployeeID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID2.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID2.Tag = "DC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel8.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel8.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(34, 187);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel8.TabIndex = 470;
            this.fld_lblLabel8.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel8.Text = "Ngày hết hạn";
            // 
            // fld_dteARCreditNoteValidateDate
            // 
            this.fld_dteARCreditNoteValidateDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteARCreditNoteValidateDate.BOSDataMember = "ARCreditNoteExpiryDate";
            this.fld_dteARCreditNoteValidateDate.BOSDataSource = "ARCreditNotes";
            this.fld_dteARCreditNoteValidateDate.BOSDescription = null;
            this.fld_dteARCreditNoteValidateDate.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteARCreditNoteValidateDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteARCreditNoteValidateDate.BOSFieldRelation = null;
            this.fld_dteARCreditNoteValidateDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteARCreditNoteValidateDate.BOSPropertyName = "EditValue";
            this.fld_dteARCreditNoteValidateDate.EditValue = null;
            this.fld_dteARCreditNoteValidateDate.Location = new System.Drawing.Point(111, 184);
            this.fld_dteARCreditNoteValidateDate.Name = "fld_dteARCreditNoteValidateDate";
            this.fld_dteARCreditNoteValidateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARCreditNoteValidateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARCreditNoteValidateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARCreditNoteValidateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARCreditNoteValidateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCreditNoteValidateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCreditNoteValidateDate.Screen = null;
            this.fld_dteARCreditNoteValidateDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARCreditNoteValidateDate.TabIndex = 3;
            this.fld_dteARCreditNoteValidateDate.Tag = "DC";
            // 
            // BOSGroupControl1
            // 
            this.BOSGroupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.BOSGroupControl1.AppearanceCaption.Options.UseFont = true;
            this.BOSGroupControl1.BOSComment = null;
            this.BOSGroupControl1.BOSDataMember = null;
            this.BOSGroupControl1.BOSDataSource = null;
            this.BOSGroupControl1.BOSDescription = null;
            this.BOSGroupControl1.BOSError = null;
            this.BOSGroupControl1.BOSFieldGroup = null;
            this.BOSGroupControl1.BOSFieldRelation = null;
            this.BOSGroupControl1.BOSPrivilege = null;
            this.BOSGroupControl1.BOSPropertyName = null;
            this.BOSGroupControl1.CaptionImage = global::BOSERP.Procedure.Properties.Resources.Candy_Vivian_Icon_12;
            this.BOSGroupControl1.Controls.Add(this.bosTextBox1);
            this.BOSGroupControl1.Controls.Add(this.bosLabel3);
            this.BOSGroupControl1.Controls.Add(this.fld_txtARCustomerNo1);
            this.BOSGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.BOSGroupControl1.Controls.Add(this.fld_txtARCreditNoteTotalAmount);
            this.BOSGroupControl1.Controls.Add(this.BOSDateEdit1);
            this.BOSGroupControl1.Controls.Add(this.fld_dteARCreditNoteValidateDate);
            this.BOSGroupControl1.Controls.Add(this.fld_lkeFK_HREmployeeID2);
            this.BOSGroupControl1.Controls.Add(this.fld_lblLabel23);
            this.BOSGroupControl1.Controls.Add(this.fld_lblLabel24);
            this.BOSGroupControl1.Controls.Add(this.BOSLabel2);
            this.BOSGroupControl1.Controls.Add(this.fld_lblLabel8);
            this.BOSGroupControl1.Controls.Add(this.fld_txtARCreditNoteTotalAmount1);
            this.BOSGroupControl1.Controls.Add(this.fld_Lablel);
            this.BOSGroupControl1.Controls.Add(this.BOSLabel1);
            this.BOSGroupControl1.Controls.Add(this.fld_lkeARCreditNoteType);
            this.BOSGroupControl1.Controls.Add(this.fld_medARCreditNoteDesc);
            this.BOSGroupControl1.Controls.Add(this.fld_lblLabel31);
            this.BOSGroupControl1.Controls.Add(this.fld_lblLabel28);
            this.BOSGroupControl1.Location = new System.Drawing.Point(12, 12);
            this.BOSGroupControl1.Name = "BOSGroupControl1";
            this.BOSGroupControl1.Screen = null;
            this.BOSGroupControl1.Size = new System.Drawing.Size(560, 494);
            this.BOSGroupControl1.TabIndex = 0;
            this.BOSGroupControl1.Text = "Phiếu quà tặng";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox1.BOSDataMember = "ARCreditNoteCondition";
            this.bosTextBox1.BOSDataSource = "ARCreditNotes";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = " ";
            this.bosTextBox1.Location = new System.Drawing.Point(397, 80);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.EditMask = "n";
            this.bosTextBox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 475;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(272, 84);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(101, 13);
            this.bosLabel3.TabIndex = 474;
            this.bosLabel3.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.Text = "Điều kiện áp dụng";
            // 
            // fld_txtARCustomerNo1
            // 
            this.fld_txtARCustomerNo1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCustomerNo1.BOSDataMember = "ARCreditNoteNo";
            this.fld_txtARCustomerNo1.BOSDataSource = "ARCreditNotes";
            this.fld_txtARCustomerNo1.BOSDescription = null;
            this.fld_txtARCustomerNo1.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCustomerNo1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCustomerNo1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCustomerNo1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCustomerNo1.BOSPropertyName = "Text";
            this.fld_txtARCustomerNo1.Location = new System.Drawing.Point(111, 80);
            this.fld_txtARCustomerNo1.Name = "fld_txtARCustomerNo1";
            this.fld_txtARCustomerNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerNo1.Screen = null;
            this.fld_txtARCustomerNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerNo1.TabIndex = 473;
            this.fld_txtARCustomerNo1.Tag = "DC";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseFont = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(34, 83);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel16.TabIndex = 472;
            this.fld_lblLabel16.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.Text = "Mã chứng từ";
            // 
            // fld_txtARCreditNoteTotalAmount
            // 
            this.fld_txtARCreditNoteTotalAmount.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount.BOSDataMember = "ARCreditNoteTotalAmount";
            this.fld_txtARCreditNoteTotalAmount.BOSDataSource = "ARCreditNotes";
            this.fld_txtARCreditNoteTotalAmount.BOSDescription = null;
            this.fld_txtARCreditNoteTotalAmount.BOSError = null;
            this.fld_txtARCreditNoteTotalAmount.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteTotalAmount.BOSPropertyName = "Text";
            this.fld_txtARCreditNoteTotalAmount.EditValue = " ";
            this.fld_txtARCreditNoteTotalAmount.Location = new System.Drawing.Point(397, 105);
            this.fld_txtARCreditNoteTotalAmount.Name = "fld_txtARCreditNoteTotalAmount";
            this.fld_txtARCreditNoteTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCreditNoteTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCreditNoteTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCreditNoteTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCreditNoteTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCreditNoteTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCreditNoteTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCreditNoteTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCreditNoteTotalAmount.Screen = null;
            this.fld_txtARCreditNoteTotalAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCreditNoteTotalAmount.TabIndex = 471;
            this.fld_txtARCreditNoteTotalAmount.Tag = "DC";
            // 
            // BOSDateEdit1
            // 
            this.BOSDateEdit1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSDateEdit1.BOSDataMember = "ARCreditNoteDate";
            this.BOSDateEdit1.BOSDataSource = "ARCreditNotes";
            this.BOSDateEdit1.BOSDescription = null;
            this.BOSDateEdit1.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSDateEdit1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSDateEdit1.BOSFieldRelation = null;
            this.BOSDateEdit1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSDateEdit1.BOSPropertyName = "EditValue";
            this.BOSDateEdit1.EditValue = null;
            this.BOSDateEdit1.Location = new System.Drawing.Point(111, 158);
            this.BOSDateEdit1.Name = "BOSDateEdit1";
            this.BOSDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.BOSDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.BOSDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BOSDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BOSDateEdit1.Screen = null;
            this.BOSDateEdit1.Size = new System.Drawing.Size(150, 20);
            this.BOSDateEdit1.TabIndex = 2;
            this.BOSDateEdit1.Tag = "DC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel2.Appearance.Options.UseBackColor = true;
            this.BOSLabel2.Appearance.Options.UseForeColor = true;
            this.BOSLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(34, 161);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(44, 13);
            this.BOSLabel2.TabIndex = 470;
            this.BOSLabel2.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel2.Text = "Ngày tạo";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(34, 109);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(48, 13);
            this.BOSLabel1.TabIndex = 468;
            this.BOSLabel1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.BOSLabel1.Text = "Nhân viên";
            // 
            // DMCN100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(584, 520);
            this.Controls.Add(this.BOSGroupControl1);
            this.Name = "DMCN100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.BOSGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCreditNoteDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteTotalAmount1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCreditNoteType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCreditNoteValidateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCreditNoteValidateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSGroupControl1)).EndInit();
            this.BOSGroupControl1.ResumeLayout(false);
            this.BOSGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSDateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl BOSGroupControl1;
        private BOSComponent.BOSDateEdit BOSDateEdit1;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSTextBox fld_txtARCreditNoteTotalAmount;
        private BOSComponent.BOSTextBox fld_txtARCustomerNo1;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel3;
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRLevel.UI
{
	/// <summary>
	/// Summary description for SMHRLV100
	/// </summary>
	partial class SMHRLV100
	{
		private BOSSearchResultsGridControl fld_dgcHRLevel;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRLevel;
		private BOSComponent.BOSTextBox fld_txtHRLevelNo;
		private BOSComponent.BOSTextBox fld_txtHRLevelName;
		private BOSComponent.BOSTextBox fld_txtHRLevelContractSlrAmt;
		private BOSComponent.BOSTextBox fld_txtHRLevelSalaryFactor;
		private BOSComponent.BOSTextBox fld_txtHRLevelWorkingSlrAmt;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		/// <summary>
		/// Required designer variable
		/// </summary>
		private System.ComponentModel.Container components = null;


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
			this.fld_dgcHRLevel = new BOSSearchResultsGridControl();
			this.fld_dgvHRLevel = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.fld_txtHRLevelNo = new BOSComponent.BOSTextBox();
			this.fld_txtHRLevelName = new BOSComponent.BOSTextBox();
			this.fld_txtHRLevelContractSlrAmt = new BOSComponent.BOSTextBox();
			this.fld_txtHRLevelSalaryFactor = new BOSComponent.BOSTextBox();
			this.fld_txtHRLevelWorkingSlrAmt = new BOSComponent.BOSTextBox();
			this.fld_lblLabel = new BOSComponent.BOSLabel();
			this.fld_lblLabel1 = new BOSComponent.BOSLabel();
			this.fld_lblLabel2 = new BOSComponent.BOSLabel();
			this.fld_lblLabel3 = new BOSComponent.BOSLabel();
			this.fld_lblLabel4 = new BOSComponent.BOSLabel();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelContractSlrAmt.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelSalaryFactor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelWorkingSlrAmt.Properties)).BeginInit();
			this.SuspendLayout();
			//
			// fld_dgcHRLevel
			//
			this.fld_dgcHRLevel.Location = new System.Drawing.Point(23, 210);
			this.fld_dgcHRLevel.Name = "fld_dgcHRLevel";
			this.fld_dgcHRLevel.Size = new System.Drawing.Size(400,200);
			this.fld_dgcHRLevel.TabIndex = 4;
			this.fld_dgcHRLevel.Text = "";
			this.fld_dgcHRLevel.BackColor = Color.FromArgb(-986896);
			this.fld_dgcHRLevel.ForeColor = Color.FromArgb(-16777216);
			this.fld_dgcHRLevel.Enabled = true;
			this.fld_dgcHRLevel.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_dgcHRLevel.Tag = "SR";
			this.fld_dgcHRLevel.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_dgcHRLevel.BOSFieldGroup = "";
			this.fld_dgcHRLevel.BOSFieldRelation = "";
			this.fld_dgcHRLevel.BOSDataSource = "HRLevels";
			this.fld_dgcHRLevel.BOSDataMember = "";
			this.fld_dgcHRLevel.BOSComment = "";
			this.fld_dgcHRLevel.BOSPrivilege = "";
			this.fld_dgcHRLevel.BOSPropertyName = "";
			this.fld_dgcHRLevel.EmbeddedNavigator.Name = "";
			this.fld_dgcHRLevel.MainView = this.fld_dgvHRLevel;
			this.fld_dgcHRLevel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.fld_dgvHRLevel});
			this.fld_dgcHRLevel.AllowDrop = true;
			//
			//fld_dgvHRLevel
			//
			this.fld_dgvHRLevel.GridControl = this.fld_dgcHRLevel;
			this.fld_dgvHRLevel.Name = "fld_dgvHRLevel";
			this.fld_dgvHRLevel.PaintStyleName = "Office2003";
			//
			// fld_txtHRLevelNo
			//
			this.fld_txtHRLevelNo.Location = new System.Drawing.Point(144, 41);
			this.fld_txtHRLevelNo.Name = "fld_txtHRLevelNo";
			this.fld_txtHRLevelNo.Size = new System.Drawing.Size(150,20);
			this.fld_txtHRLevelNo.TabIndex = 5;
			this.fld_txtHRLevelNo.Text = "<HRLevelNo>";
			this.fld_txtHRLevelNo.Text = string.Empty;
			this.fld_txtHRLevelNo.BackColor = Color.FromArgb(-1);
			this.fld_txtHRLevelNo.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRLevelNo.Enabled = true;
			this.fld_txtHRLevelNo.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelNo.Tag = "SC";
			this.fld_txtHRLevelNo.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRLevelNo.BOSFieldGroup = "";
			this.fld_txtHRLevelNo.BOSFieldRelation = "";
			this.fld_txtHRLevelNo.BOSDataSource = "HRLevels";
			this.fld_txtHRLevelNo.BOSDataMember = "HRLevelNo";
			this.fld_txtHRLevelNo.BOSComment = "";
			this.fld_txtHRLevelNo.BOSPrivilege = "";
			this.fld_txtHRLevelNo.BOSPropertyName = "Text";
			this.fld_txtHRLevelNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			this.fld_txtHRLevelNo.Properties.Mask.EditMask = "";
			this.fld_txtHRLevelNo.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRLevelNo.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelNo.Enabled = true;
			this.fld_txtHRLevelNo.Properties.ReadOnly = false;
			this.fld_txtHRLevelNo.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRLevelNo.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRLevelNo.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_txtHRLevelName
			//
			this.fld_txtHRLevelName.Location = new System.Drawing.Point(144, 65);
			this.fld_txtHRLevelName.Name = "fld_txtHRLevelName";
			this.fld_txtHRLevelName.Size = new System.Drawing.Size(150,20);
			this.fld_txtHRLevelName.TabIndex = 6;
			this.fld_txtHRLevelName.Text = "<HRLevelName>";
			this.fld_txtHRLevelName.Text = string.Empty;
			this.fld_txtHRLevelName.BackColor = Color.FromArgb(-1);
			this.fld_txtHRLevelName.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRLevelName.Enabled = true;
			this.fld_txtHRLevelName.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelName.Tag = "SC";
			this.fld_txtHRLevelName.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRLevelName.BOSFieldGroup = "";
			this.fld_txtHRLevelName.BOSFieldRelation = "";
			this.fld_txtHRLevelName.BOSDataSource = "HRLevels";
			this.fld_txtHRLevelName.BOSDataMember = "HRLevelName";
			this.fld_txtHRLevelName.BOSComment = "";
			this.fld_txtHRLevelName.BOSPrivilege = "";
			this.fld_txtHRLevelName.BOSPropertyName = "Text";
			this.fld_txtHRLevelName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			this.fld_txtHRLevelName.Properties.Mask.EditMask = "";
			this.fld_txtHRLevelName.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRLevelName.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelName.Enabled = true;
			this.fld_txtHRLevelName.Properties.ReadOnly = false;
			this.fld_txtHRLevelName.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRLevelName.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRLevelName.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_txtHRLevelContractSlrAmt
			//
			this.fld_txtHRLevelContractSlrAmt.Location = new System.Drawing.Point(144, 89);
			this.fld_txtHRLevelContractSlrAmt.Name = "fld_txtHRLevelContractSlrAmt";
			this.fld_txtHRLevelContractSlrAmt.Size = new System.Drawing.Size(150,20);
			this.fld_txtHRLevelContractSlrAmt.TabIndex = 7;
			this.fld_txtHRLevelContractSlrAmt.Text = "0.00";
			this.fld_txtHRLevelContractSlrAmt.Text = string.Empty;
			this.fld_txtHRLevelContractSlrAmt.BackColor = Color.FromArgb(-1);
			this.fld_txtHRLevelContractSlrAmt.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRLevelContractSlrAmt.Enabled = true;
			this.fld_txtHRLevelContractSlrAmt.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelContractSlrAmt.Tag = "SC";
			this.fld_txtHRLevelContractSlrAmt.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRLevelContractSlrAmt.BOSFieldGroup = "";
			this.fld_txtHRLevelContractSlrAmt.BOSFieldRelation = "";
			this.fld_txtHRLevelContractSlrAmt.BOSDataSource = "HRLevels";
			this.fld_txtHRLevelContractSlrAmt.BOSDataMember = "HRLevelContractSlrAmt";
			this.fld_txtHRLevelContractSlrAmt.BOSComment = "";
			this.fld_txtHRLevelContractSlrAmt.BOSPrivilege = "";
			this.fld_txtHRLevelContractSlrAmt.BOSPropertyName = "Text";
			this.fld_txtHRLevelContractSlrAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.fld_txtHRLevelContractSlrAmt.Properties.Mask.EditMask = "n";
			this.fld_txtHRLevelContractSlrAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRLevelContractSlrAmt.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelContractSlrAmt.Enabled = true;
			this.fld_txtHRLevelContractSlrAmt.Properties.ReadOnly = false;
			this.fld_txtHRLevelContractSlrAmt.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRLevelContractSlrAmt.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRLevelContractSlrAmt.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_txtHRLevelSalaryFactor
			//
			this.fld_txtHRLevelSalaryFactor.Location = new System.Drawing.Point(144, 113);
			this.fld_txtHRLevelSalaryFactor.Name = "fld_txtHRLevelSalaryFactor";
			this.fld_txtHRLevelSalaryFactor.Size = new System.Drawing.Size(150,20);
			this.fld_txtHRLevelSalaryFactor.TabIndex = 8;
			this.fld_txtHRLevelSalaryFactor.Text = "0.00";
			this.fld_txtHRLevelSalaryFactor.Text = string.Empty;
			this.fld_txtHRLevelSalaryFactor.BackColor = Color.FromArgb(-1);
			this.fld_txtHRLevelSalaryFactor.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRLevelSalaryFactor.Enabled = true;
			this.fld_txtHRLevelSalaryFactor.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelSalaryFactor.Tag = "SC";
			this.fld_txtHRLevelSalaryFactor.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRLevelSalaryFactor.BOSFieldGroup = "";
			this.fld_txtHRLevelSalaryFactor.BOSFieldRelation = "";
			this.fld_txtHRLevelSalaryFactor.BOSDataSource = "HRLevels";
			this.fld_txtHRLevelSalaryFactor.BOSDataMember = "HRLevelSalaryFactor";
			this.fld_txtHRLevelSalaryFactor.BOSComment = "";
			this.fld_txtHRLevelSalaryFactor.BOSPrivilege = "";
			this.fld_txtHRLevelSalaryFactor.BOSPropertyName = "Text";
			this.fld_txtHRLevelSalaryFactor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.fld_txtHRLevelSalaryFactor.Properties.Mask.EditMask = "n";
			this.fld_txtHRLevelSalaryFactor.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRLevelSalaryFactor.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelSalaryFactor.Enabled = true;
			this.fld_txtHRLevelSalaryFactor.Properties.ReadOnly = false;
			this.fld_txtHRLevelSalaryFactor.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRLevelSalaryFactor.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRLevelSalaryFactor.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_txtHRLevelWorkingSlrAmt
			//
			this.fld_txtHRLevelWorkingSlrAmt.Location = new System.Drawing.Point(144, 137);
			this.fld_txtHRLevelWorkingSlrAmt.Name = "fld_txtHRLevelWorkingSlrAmt";
			this.fld_txtHRLevelWorkingSlrAmt.Size = new System.Drawing.Size(150,20);
			this.fld_txtHRLevelWorkingSlrAmt.TabIndex = 9;
			this.fld_txtHRLevelWorkingSlrAmt.Text = "0.00";
			this.fld_txtHRLevelWorkingSlrAmt.Text = string.Empty;
			this.fld_txtHRLevelWorkingSlrAmt.BackColor = Color.FromArgb(-1);
			this.fld_txtHRLevelWorkingSlrAmt.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRLevelWorkingSlrAmt.Enabled = true;
			this.fld_txtHRLevelWorkingSlrAmt.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelWorkingSlrAmt.Tag = "SC";
			this.fld_txtHRLevelWorkingSlrAmt.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRLevelWorkingSlrAmt.BOSFieldGroup = "";
			this.fld_txtHRLevelWorkingSlrAmt.BOSFieldRelation = "";
			this.fld_txtHRLevelWorkingSlrAmt.BOSDataSource = "HRLevels";
			this.fld_txtHRLevelWorkingSlrAmt.BOSDataMember = "HRLevelWorkingSlrAmt";
			this.fld_txtHRLevelWorkingSlrAmt.BOSComment = "";
			this.fld_txtHRLevelWorkingSlrAmt.BOSPrivilege = "";
			this.fld_txtHRLevelWorkingSlrAmt.BOSPropertyName = "Text";
			this.fld_txtHRLevelWorkingSlrAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.fld_txtHRLevelWorkingSlrAmt.Properties.Mask.EditMask = "n";
			this.fld_txtHRLevelWorkingSlrAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRLevelWorkingSlrAmt.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRLevelWorkingSlrAmt.Enabled = true;
			this.fld_txtHRLevelWorkingSlrAmt.Properties.ReadOnly = false;
			this.fld_txtHRLevelWorkingSlrAmt.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRLevelWorkingSlrAmt.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRLevelWorkingSlrAmt.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_lblLabel
			//
			this.fld_lblLabel.Location = new System.Drawing.Point(60, 44);
			this.fld_lblLabel.Name = "fld_lblLabel";
			this.fld_lblLabel.Size = new System.Drawing.Size(14,13);
			this.fld_lblLabel.TabIndex = 10;
			this.fld_lblLabel.Text = "Mã vị trí";
			this.fld_lblLabel.BackColor = Color.FromArgb(0);
			this.fld_lblLabel.ForeColor = Color.FromArgb(-16777216);
			this.fld_lblLabel.Enabled = true;
			this.fld_lblLabel.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_lblLabel.Tag = "SI";
			this.fld_lblLabel.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_lblLabel.BOSFieldGroup = "";
			this.fld_lblLabel.BOSFieldRelation = "";
			this.fld_lblLabel.BOSDataSource = "";
			this.fld_lblLabel.BOSDataMember = "";
			this.fld_lblLabel.BOSComment = "";
			this.fld_lblLabel.BOSPrivilege = "";
			this.fld_lblLabel.BOSPropertyName = "";
			this.fld_lblLabel.AutoSize = true;
			//
			// fld_lblLabel1
			//
			this.fld_lblLabel1.Location = new System.Drawing.Point(60, 68);
			this.fld_lblLabel1.Name = "fld_lblLabel1";
			this.fld_lblLabel1.Size = new System.Drawing.Size(18,13);
			this.fld_lblLabel1.TabIndex = 11;
			this.fld_lblLabel1.Text = "Tên vị trí";
			this.fld_lblLabel1.BackColor = Color.FromArgb(0);
			this.fld_lblLabel1.ForeColor = Color.FromArgb(-16777216);
			this.fld_lblLabel1.Enabled = true;
			this.fld_lblLabel1.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_lblLabel1.Tag = "SI";
			this.fld_lblLabel1.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_lblLabel1.BOSFieldGroup = "";
			this.fld_lblLabel1.BOSFieldRelation = "";
			this.fld_lblLabel1.BOSDataSource = "";
			this.fld_lblLabel1.BOSDataMember = "";
			this.fld_lblLabel1.BOSComment = "";
			this.fld_lblLabel1.BOSPrivilege = "";
			this.fld_lblLabel1.BOSPropertyName = "";
			this.fld_lblLabel1.AutoSize = true;
			//
			// fld_lblLabel2
			//
			this.fld_lblLabel2.Location = new System.Drawing.Point(60, 92);
			this.fld_lblLabel2.Name = "fld_lblLabel2";
			this.fld_lblLabel2.Size = new System.Drawing.Size(71,13);
			this.fld_lblLabel2.TabIndex = 12;
			this.fld_lblLabel2.Text = "Lương căn bản";
			this.fld_lblLabel2.BackColor = Color.FromArgb(0);
			this.fld_lblLabel2.ForeColor = Color.FromArgb(-16777216);
			this.fld_lblLabel2.Enabled = true;
			this.fld_lblLabel2.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_lblLabel2.Tag = "SI";
			this.fld_lblLabel2.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_lblLabel2.BOSFieldGroup = "";
			this.fld_lblLabel2.BOSFieldRelation = "";
			this.fld_lblLabel2.BOSDataSource = "";
			this.fld_lblLabel2.BOSDataMember = "";
			this.fld_lblLabel2.BOSComment = "";
			this.fld_lblLabel2.BOSPrivilege = "";
			this.fld_lblLabel2.BOSPropertyName = "";
			this.fld_lblLabel2.AutoSize = true;
			//
			// fld_lblLabel3
			//
			this.fld_lblLabel3.Location = new System.Drawing.Point(60, 116);
			this.fld_lblLabel3.Name = "fld_lblLabel3";
			this.fld_lblLabel3.Size = new System.Drawing.Size(57,13);
			this.fld_lblLabel3.TabIndex = 13;
			this.fld_lblLabel3.Text = "Hệ số lương";
			this.fld_lblLabel3.BackColor = Color.FromArgb(0);
			this.fld_lblLabel3.ForeColor = Color.FromArgb(-16777216);
			this.fld_lblLabel3.Enabled = true;
			this.fld_lblLabel3.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_lblLabel3.Tag = "SI";
			this.fld_lblLabel3.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_lblLabel3.BOSFieldGroup = "";
			this.fld_lblLabel3.BOSFieldRelation = "";
			this.fld_lblLabel3.BOSDataSource = "";
			this.fld_lblLabel3.BOSDataMember = "";
			this.fld_lblLabel3.BOSComment = "";
			this.fld_lblLabel3.BOSPrivilege = "";
			this.fld_lblLabel3.BOSPropertyName = "";
			this.fld_lblLabel3.AutoSize = true;
			//
			// fld_lblLabel4
			//
			this.fld_lblLabel4.Location = new System.Drawing.Point(60, 140);
			this.fld_lblLabel4.Name = "fld_lblLabel4";
			this.fld_lblLabel4.Size = new System.Drawing.Size(78,13);
			this.fld_lblLabel4.TabIndex = 14;
			this.fld_lblLabel4.Text = "Lương công việc";
			this.fld_lblLabel4.BackColor = Color.FromArgb(0);
			this.fld_lblLabel4.ForeColor = Color.FromArgb(-16777216);
			this.fld_lblLabel4.Enabled = true;
			this.fld_lblLabel4.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_lblLabel4.Tag = "SI";
			this.fld_lblLabel4.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_lblLabel4.BOSFieldGroup = "";
			this.fld_lblLabel4.BOSFieldRelation = "";
			this.fld_lblLabel4.BOSDataSource = "";
			this.fld_lblLabel4.BOSDataMember = "";
			this.fld_lblLabel4.BOSComment = "";
			this.fld_lblLabel4.BOSPrivilege = "";
			this.fld_lblLabel4.BOSPropertyName = "";
			this.fld_lblLabel4.AutoSize = true;
			//
			// Form
			//
			this.ClientSize = new System.Drawing.Size(0, 0);
			this.Controls.Add(this.fld_dgcHRLevel);
			this.Controls.Add(this.fld_txtHRLevelNo);
			this.Controls.Add(this.fld_txtHRLevelName);
			this.Controls.Add(this.fld_txtHRLevelContractSlrAmt);
			this.Controls.Add(this.fld_txtHRLevelSalaryFactor);
			this.Controls.Add(this.fld_txtHRLevelWorkingSlrAmt);
			this.Controls.Add(this.fld_lblLabel);
			this.Controls.Add(this.fld_lblLabel1);
			this.Controls.Add(this.fld_lblLabel2);
			this.Controls.Add(this.fld_lblLabel3);
			this.Controls.Add(this.fld_lblLabel4);
			this.Name = "guiHRLevelSearch";
			this.Text = "Tìm Kiếm";
			this.ClientSize = new System.Drawing.Size(862, 567);
			this.BackColor = Color.FromArgb(-526863);
			this.ForeColor = Color.FromArgb(-16777216);
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelContractSlrAmt.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelSalaryFactor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelWorkingSlrAmt.Properties)).EndInit();
			this.ResumeLayout(false);
		}
		#endregion
	}
}

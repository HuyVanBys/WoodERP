using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRCalender.UI
{
	/// <summary>
	/// Summary description for SMHRCL100
	/// </summary>
	partial class SMHRCL100
	{
		private BOSSearchResultsGridControl fld_dgcHRCalendar;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRCalendar;
		private BOSComponent.BOSTextBox fld_txtHRCalendarNo;
		private BOSComponent.BOSTextBox fld_txtHRCalendarName;
		private BOSComponent.BOSTextBox fld_txtHRCalendarYear;
		private BOSComponent.BOSLookupEdit fld_lkeLookupEdit;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
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
			this.fld_dgcHRCalendar = new BOSSearchResultsGridControl();
			this.fld_dgvHRCalendar = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.fld_txtHRCalendarNo = new BOSComponent.BOSTextBox();
			this.fld_txtHRCalendarName = new BOSComponent.BOSTextBox();
			this.fld_txtHRCalendarYear = new BOSComponent.BOSTextBox();
			this.fld_lkeLookupEdit = new BOSComponent.BOSLookupEdit();
			this.fld_lblLabel = new BOSComponent.BOSLabel();
			this.fld_lblLabel1 = new BOSComponent.BOSLabel();
			this.fld_lblLabel2 = new BOSComponent.BOSLabel();
			this.fld_lblLabel3 = new BOSComponent.BOSLabel();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCalendar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRCalendar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarYear.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_lkeLookupEdit.Properties)).BeginInit();
			this.SuspendLayout();
			//
			// fld_dgcHRCalendar
			//
			this.fld_dgcHRCalendar.Location = new System.Drawing.Point(26, 166);
			this.fld_dgcHRCalendar.Name = "fld_dgcHRCalendar";
			this.fld_dgcHRCalendar.Size = new System.Drawing.Size(400,200);
			this.fld_dgcHRCalendar.TabIndex = 4;
			this.fld_dgcHRCalendar.Text = "";
			this.fld_dgcHRCalendar.BackColor = Color.FromArgb(-986896);
			this.fld_dgcHRCalendar.ForeColor = Color.FromArgb(-16777216);
			this.fld_dgcHRCalendar.Enabled = true;
			this.fld_dgcHRCalendar.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_dgcHRCalendar.Tag = "SR";
			this.fld_dgcHRCalendar.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_dgcHRCalendar.BOSFieldGroup = "";
			this.fld_dgcHRCalendar.BOSFieldRelation = "";
			this.fld_dgcHRCalendar.BOSDataSource = "HRCalendars";
			this.fld_dgcHRCalendar.BOSDataMember = "";
			this.fld_dgcHRCalendar.BOSComment = "";
			this.fld_dgcHRCalendar.BOSPrivilege = "";
			this.fld_dgcHRCalendar.BOSPropertyName = "";
			this.fld_dgcHRCalendar.EmbeddedNavigator.Name = "";
			this.fld_dgcHRCalendar.MainView = this.fld_dgvHRCalendar;
			this.fld_dgcHRCalendar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.fld_dgvHRCalendar});
			this.fld_dgcHRCalendar.AllowDrop = true;
			//
			//fld_dgvHRCalendar
			//
			this.fld_dgvHRCalendar.GridControl = this.fld_dgcHRCalendar;
			this.fld_dgvHRCalendar.Name = "fld_dgvHRCalendar";
			this.fld_dgvHRCalendar.PaintStyleName = "Office2003";
			//
			// fld_txtHRCalendarNo
			//
			this.fld_txtHRCalendarNo.Location = new System.Drawing.Point(141, 54);
			this.fld_txtHRCalendarNo.Name = "fld_txtHRCalendarNo";
			this.fld_txtHRCalendarNo.Size = new System.Drawing.Size(125,20);
			this.fld_txtHRCalendarNo.TabIndex = 5;
			this.fld_txtHRCalendarNo.Text = "<HRCalendarNo>";
			this.fld_txtHRCalendarNo.Text = string.Empty;
			this.fld_txtHRCalendarNo.BackColor = Color.FromArgb(-1);
			this.fld_txtHRCalendarNo.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRCalendarNo.Enabled = true;
			this.fld_txtHRCalendarNo.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRCalendarNo.Tag = "SC";
			this.fld_txtHRCalendarNo.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRCalendarNo.BOSFieldGroup = "";
			this.fld_txtHRCalendarNo.BOSFieldRelation = "";
			this.fld_txtHRCalendarNo.BOSDataSource = "HRCalendars";
			this.fld_txtHRCalendarNo.BOSDataMember = "HRCalendarNo";
			this.fld_txtHRCalendarNo.BOSComment = "";
			this.fld_txtHRCalendarNo.BOSPrivilege = "";
			this.fld_txtHRCalendarNo.BOSPropertyName = "Text";
			this.fld_txtHRCalendarNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			this.fld_txtHRCalendarNo.Properties.Mask.EditMask = "";
			this.fld_txtHRCalendarNo.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRCalendarNo.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRCalendarNo.Enabled = true;
			this.fld_txtHRCalendarNo.Properties.ReadOnly = false;
			this.fld_txtHRCalendarNo.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRCalendarNo.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRCalendarNo.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_txtHRCalendarName
			//
			this.fld_txtHRCalendarName.Location = new System.Drawing.Point(141, 78);
			this.fld_txtHRCalendarName.Name = "fld_txtHRCalendarName";
			this.fld_txtHRCalendarName.Size = new System.Drawing.Size(125,20);
			this.fld_txtHRCalendarName.TabIndex = 6;
			this.fld_txtHRCalendarName.Text = "<HRCalendarName>";
			this.fld_txtHRCalendarName.Text = string.Empty;
			this.fld_txtHRCalendarName.BackColor = Color.FromArgb(-1);
			this.fld_txtHRCalendarName.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRCalendarName.Enabled = true;
			this.fld_txtHRCalendarName.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRCalendarName.Tag = "SC";
			this.fld_txtHRCalendarName.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRCalendarName.BOSFieldGroup = "";
			this.fld_txtHRCalendarName.BOSFieldRelation = "";
			this.fld_txtHRCalendarName.BOSDataSource = "HRCalendars";
			this.fld_txtHRCalendarName.BOSDataMember = "HRCalendarName";
			this.fld_txtHRCalendarName.BOSComment = "";
			this.fld_txtHRCalendarName.BOSPrivilege = "";
			this.fld_txtHRCalendarName.BOSPropertyName = "Text";
			this.fld_txtHRCalendarName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			this.fld_txtHRCalendarName.Properties.Mask.EditMask = "";
			this.fld_txtHRCalendarName.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRCalendarName.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRCalendarName.Enabled = true;
			this.fld_txtHRCalendarName.Properties.ReadOnly = false;
			this.fld_txtHRCalendarName.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRCalendarName.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRCalendarName.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_txtHRCalendarYear
			//
			this.fld_txtHRCalendarYear.Location = new System.Drawing.Point(141, 126);
			this.fld_txtHRCalendarYear.Name = "fld_txtHRCalendarYear";
			this.fld_txtHRCalendarYear.Size = new System.Drawing.Size(125,20);
			this.fld_txtHRCalendarYear.TabIndex = 8;
			this.fld_txtHRCalendarYear.Text = "0";
			this.fld_txtHRCalendarYear.Text = string.Empty;
			this.fld_txtHRCalendarYear.BackColor = Color.FromArgb(-1);
			this.fld_txtHRCalendarYear.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRCalendarYear.Enabled = true;
			this.fld_txtHRCalendarYear.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRCalendarYear.Tag = "SC";
			this.fld_txtHRCalendarYear.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRCalendarYear.BOSFieldGroup = "";
			this.fld_txtHRCalendarYear.BOSFieldRelation = "";
			this.fld_txtHRCalendarYear.BOSDataSource = "HRCalendars";
			this.fld_txtHRCalendarYear.BOSDataMember = "HRCalendarYear";
			this.fld_txtHRCalendarYear.BOSComment = "";
			this.fld_txtHRCalendarYear.BOSPrivilege = "";
			this.fld_txtHRCalendarYear.BOSPropertyName = "Text";
			this.fld_txtHRCalendarYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.fld_txtHRCalendarYear.Properties.Mask.EditMask = "n0";
			this.fld_txtHRCalendarYear.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRCalendarYear.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRCalendarYear.Enabled = true;
			this.fld_txtHRCalendarYear.Properties.ReadOnly = false;
			this.fld_txtHRCalendarYear.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRCalendarYear.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRCalendarYear.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_lkeLookupEdit
			//
			this.fld_lkeLookupEdit.Location = new System.Drawing.Point(141, 102);
			this.fld_lkeLookupEdit.Name = "fld_lkeLookupEdit";
			this.fld_lkeLookupEdit.Size = new System.Drawing.Size(125,20);
			this.fld_lkeLookupEdit.TabIndex = 9;
			this.fld_lkeLookupEdit.Text = "[EditValue is null]";
			this.fld_lkeLookupEdit.BackColor = Color.FromArgb(-1);
			this.fld_lkeLookupEdit.ForeColor = Color.FromArgb(-16777216);
			this.fld_lkeLookupEdit.Enabled = true;
			this.fld_lkeLookupEdit.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_lkeLookupEdit.Tag = "SC";
			this.fld_lkeLookupEdit.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_lkeLookupEdit.BOSFieldGroup = "";
			this.fld_lkeLookupEdit.BOSFieldRelation = "";
			this.fld_lkeLookupEdit.BOSDataSource = "HRCalendars";
			this.fld_lkeLookupEdit.BOSDataMember = "HRCalendarType";
			this.fld_lkeLookupEdit.BOSComment = "";
			this.fld_lkeLookupEdit.BOSPrivilege = "";
			this.fld_lkeLookupEdit.BOSPropertyName = "EditValue";
			this.fld_lkeLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fld_lkeLookupEdit.Properties.DisplayMember = "";
			this.fld_lkeLookupEdit.Properties.ValueMember = "";
			this.fld_lkeLookupEdit.Properties.NullText = String.Empty;
			this.fld_lkeLookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.fld_lkeLookupEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
			this.fld_lkeLookupEdit.BOSFieldParent = "";
			this.fld_lkeLookupEdit.BOSAllowDummy = true;
			this.fld_lkeLookupEdit.BOSSelectType = "";
			this.fld_lkeLookupEdit.BOSSelectTypeValue = "";
			//
			// fld_lblLabel
			//
			this.fld_lblLabel.Location = new System.Drawing.Point(66, 57);
			this.fld_lblLabel.Name = "fld_lblLabel";
			this.fld_lblLabel.Size = new System.Drawing.Size(14,13);
			this.fld_lblLabel.TabIndex = 10;
			this.fld_lblLabel.Text = "Mã danh sách";
			this.fld_lblLabel.BackColor = Color.FromArgb(16777215);
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
			this.fld_lblLabel1.Location = new System.Drawing.Point(66, 81);
			this.fld_lblLabel1.Name = "fld_lblLabel1";
			this.fld_lblLabel1.Size = new System.Drawing.Size(18,13);
			this.fld_lblLabel1.TabIndex = 11;
			this.fld_lblLabel1.Text = "Tên danh sách";
			this.fld_lblLabel1.BackColor = Color.FromArgb(16777215);
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
			this.fld_lblLabel2.Location = new System.Drawing.Point(66, 105);
			this.fld_lblLabel2.Name = "fld_lblLabel2";
			this.fld_lblLabel2.Size = new System.Drawing.Size(19,13);
			this.fld_lblLabel2.TabIndex = 12;
			this.fld_lblLabel2.Text = "Loại";
			this.fld_lblLabel2.BackColor = Color.FromArgb(16777215);
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
			this.fld_lblLabel3.Location = new System.Drawing.Point(66, 129);
			this.fld_lblLabel3.Name = "fld_lblLabel3";
			this.fld_lblLabel3.Size = new System.Drawing.Size(21,13);
			this.fld_lblLabel3.TabIndex = 13;
			this.fld_lblLabel3.Text = "Năm";
			this.fld_lblLabel3.BackColor = Color.FromArgb(16777215);
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
			// Form
			//
			this.ClientSize = new System.Drawing.Size(0, 0);
			this.Controls.Add(this.fld_dgcHRCalendar);
			this.Controls.Add(this.fld_txtHRCalendarNo);
			this.Controls.Add(this.fld_txtHRCalendarName);
			this.Controls.Add(this.fld_txtHRCalendarYear);
			this.Controls.Add(this.fld_lkeLookupEdit);
			this.Controls.Add(this.fld_lblLabel);
			this.Controls.Add(this.fld_lblLabel1);
			this.Controls.Add(this.fld_lblLabel2);
			this.Controls.Add(this.fld_lblLabel3);
			this.Name = "guiHRCalenderSearch";
			this.Text = "Tìm kiếm";
			this.ClientSize = new System.Drawing.Size(862, 567);
			this.BackColor = Color.FromArgb(-526863);
			this.ForeColor = Color.FromArgb(-16777216);
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCalendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRCalendar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarYear.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_lkeLookupEdit.Properties)).EndInit();
			this.ResumeLayout(false);
		}
		#endregion
	}
}

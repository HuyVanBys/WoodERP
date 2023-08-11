using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTrainningCourse.UI
{
	/// <summary>
	/// Summary description for SMHRTC100
	/// </summary>
	partial class SMHRTC100
	{
		private BOSComponent.BOSTextBox fld_txtHRTrainningCourseNo;
		private BOSComponent.BOSTextBox fld_txtHRTrainningCourseName;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSSearchResultsGridControl fld_dgcHRTrainningCourse;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTrainningCourse;
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
			this.fld_txtHRTrainningCourseNo = new BOSComponent.BOSTextBox();
			this.fld_txtHRTrainningCourseName = new BOSComponent.BOSTextBox();
			this.fld_lblLabel = new BOSComponent.BOSLabel();
			this.fld_lblLabel1 = new BOSComponent.BOSLabel();
			this.fld_dgcHRTrainningCourse = new BOSSearchResultsGridControl();
			this.fld_dgvHRTrainningCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningCourse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningCourse)).BeginInit();
			this.SuspendLayout();
			//
			// fld_txtHRTrainningCourseNo
			//
			this.fld_txtHRTrainningCourseNo.Location = new System.Drawing.Point(179, 35);
			this.fld_txtHRTrainningCourseNo.Name = "fld_txtHRTrainningCourseNo";
			this.fld_txtHRTrainningCourseNo.Size = new System.Drawing.Size(150,20);
			this.fld_txtHRTrainningCourseNo.TabIndex = 4;
			this.fld_txtHRTrainningCourseNo.Text = "<HRTrainningCourseNo>";
			this.fld_txtHRTrainningCourseNo.Text = string.Empty;
			this.fld_txtHRTrainningCourseNo.BackColor = Color.FromArgb(-1);
			this.fld_txtHRTrainningCourseNo.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRTrainningCourseNo.Enabled = true;
			this.fld_txtHRTrainningCourseNo.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRTrainningCourseNo.Tag = "SC";
			this.fld_txtHRTrainningCourseNo.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRTrainningCourseNo.BOSFieldGroup = "";
			this.fld_txtHRTrainningCourseNo.BOSFieldRelation = "";
			this.fld_txtHRTrainningCourseNo.BOSDataSource = "HRTrainningCourses";
			this.fld_txtHRTrainningCourseNo.BOSDataMember = "HRTrainningCourseNo";
			this.fld_txtHRTrainningCourseNo.BOSComment = "";
			this.fld_txtHRTrainningCourseNo.BOSPrivilege = "";
			this.fld_txtHRTrainningCourseNo.BOSPropertyName = "Text";
			this.fld_txtHRTrainningCourseNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			this.fld_txtHRTrainningCourseNo.Properties.Mask.EditMask = "";
			this.fld_txtHRTrainningCourseNo.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRTrainningCourseNo.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRTrainningCourseNo.Enabled = true;
			this.fld_txtHRTrainningCourseNo.Properties.ReadOnly = false;
			this.fld_txtHRTrainningCourseNo.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRTrainningCourseNo.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRTrainningCourseNo.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_txtHRTrainningCourseName
			//
			this.fld_txtHRTrainningCourseName.Location = new System.Drawing.Point(179, 59);
			this.fld_txtHRTrainningCourseName.Name = "fld_txtHRTrainningCourseName";
			this.fld_txtHRTrainningCourseName.Size = new System.Drawing.Size(150,20);
			this.fld_txtHRTrainningCourseName.TabIndex = 5;
			this.fld_txtHRTrainningCourseName.Text = "<HRTrainningCourseName>";
			this.fld_txtHRTrainningCourseName.Text = string.Empty;
			this.fld_txtHRTrainningCourseName.BackColor = Color.FromArgb(-1);
			this.fld_txtHRTrainningCourseName.ForeColor = Color.FromArgb(-16777216);
			this.fld_txtHRTrainningCourseName.Enabled = true;
			this.fld_txtHRTrainningCourseName.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRTrainningCourseName.Tag = "SC";
			this.fld_txtHRTrainningCourseName.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_txtHRTrainningCourseName.BOSFieldGroup = "";
			this.fld_txtHRTrainningCourseName.BOSFieldRelation = "";
			this.fld_txtHRTrainningCourseName.BOSDataSource = "HRTrainningCourses";
			this.fld_txtHRTrainningCourseName.BOSDataMember = "HRTrainningCourseName";
			this.fld_txtHRTrainningCourseName.BOSComment = "";
			this.fld_txtHRTrainningCourseName.BOSPrivilege = "";
			this.fld_txtHRTrainningCourseName.BOSPropertyName = "Text";
			this.fld_txtHRTrainningCourseName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			this.fld_txtHRTrainningCourseName.Properties.Mask.EditMask = "";
			this.fld_txtHRTrainningCourseName.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtHRTrainningCourseName.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_txtHRTrainningCourseName.Enabled = true;
			this.fld_txtHRTrainningCourseName.Properties.ReadOnly = false;
			this.fld_txtHRTrainningCourseName.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), "No");
			this.fld_txtHRTrainningCourseName.Properties.BorderStyle = (DevExpress.XtraEditors.Controls.BorderStyles)Enum.Parse(typeof(DevExpress.XtraEditors.Controls.BorderStyles), "Default");
			this.fld_txtHRTrainningCourseName.Properties.CharacterCasing = (CharacterCasing)Enum.Parse(typeof(CharacterCasing), "Normal");
			//
			// fld_lblLabel
			//
			this.fld_lblLabel.Location = new System.Drawing.Point(96, 38);
			this.fld_lblLabel.Name = "fld_lblLabel";
			this.fld_lblLabel.Size = new System.Drawing.Size(60,13);
			this.fld_lblLabel.TabIndex = 6;
			this.fld_lblLabel.Text = "Mã khóa học";
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
			this.fld_lblLabel1.Location = new System.Drawing.Point(96, 62);
			this.fld_lblLabel1.Name = "fld_lblLabel1";
			this.fld_lblLabel1.Size = new System.Drawing.Size(64,13);
			this.fld_lblLabel1.TabIndex = 7;
			this.fld_lblLabel1.Text = "Tên khóa học";
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
			// fld_dgcHRTrainningCourse
			//
			this.fld_dgcHRTrainningCourse.Location = new System.Drawing.Point(101, 102);
			this.fld_dgcHRTrainningCourse.Name = "fld_dgcHRTrainningCourse";
			this.fld_dgcHRTrainningCourse.Size = new System.Drawing.Size(400,200);
			this.fld_dgcHRTrainningCourse.TabIndex = 8;
			this.fld_dgcHRTrainningCourse.Text = "";
			this.fld_dgcHRTrainningCourse.BackColor = Color.FromArgb(-986896);
			this.fld_dgcHRTrainningCourse.ForeColor = Color.FromArgb(-16777216);
			this.fld_dgcHRTrainningCourse.Enabled = true;
			this.fld_dgcHRTrainningCourse.Font = new Font("Tahoma", (float)8.25, (FontStyle)Enum.Parse(typeof(FontStyle), "Regular"));
			this.fld_dgcHRTrainningCourse.Tag = "SR";
			this.fld_dgcHRTrainningCourse.Dock = (DockStyle)Enum.Parse(typeof(DockStyle), "None");
			this.fld_dgcHRTrainningCourse.BOSFieldGroup = "";
			this.fld_dgcHRTrainningCourse.BOSFieldRelation = "";
			this.fld_dgcHRTrainningCourse.BOSDataSource = "HRTrainningCourses";
			this.fld_dgcHRTrainningCourse.BOSDataMember = "";
			this.fld_dgcHRTrainningCourse.BOSComment = "";
			this.fld_dgcHRTrainningCourse.BOSPrivilege = "";
			this.fld_dgcHRTrainningCourse.BOSPropertyName = "";
			this.fld_dgcHRTrainningCourse.EmbeddedNavigator.Name = "";
			this.fld_dgcHRTrainningCourse.MainView = this.fld_dgvHRTrainningCourse;
			this.fld_dgcHRTrainningCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.fld_dgvHRTrainningCourse});
			this.fld_dgcHRTrainningCourse.AllowDrop = true;
			//
			//fld_dgvHRTrainningCourse
			//
			this.fld_dgvHRTrainningCourse.GridControl = this.fld_dgcHRTrainningCourse;
			this.fld_dgvHRTrainningCourse.Name = "fld_dgvHRTrainningCourse";
			this.fld_dgvHRTrainningCourse.PaintStyleName = "Office2003";
			//
			// Form
			//
			this.ClientSize = new System.Drawing.Size(0, 0);
			this.Controls.Add(this.fld_txtHRTrainningCourseNo);
			this.Controls.Add(this.fld_txtHRTrainningCourseName);
			this.Controls.Add(this.fld_lblLabel);
			this.Controls.Add(this.fld_lblLabel1);
			this.Controls.Add(this.fld_dgcHRTrainningCourse);
			this.Name = "guiHRTrainningCourseSearch";
			this.Text = "Tìm kiếm";
			this.ClientSize = new System.Drawing.Size(862, 567);
			this.BackColor = Color.FromArgb(-526863);
			this.ForeColor = Color.FromArgb(-16777216);
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningCourse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningCourse)).EndInit();
			this.ResumeLayout(false);
		}
		#endregion
	}
}

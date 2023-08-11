using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.TimeSheetScale.UI
{
	/// <summary>
	/// Summary description for DMTSS100
	/// </summary>
	partial class DMTSS100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtHRTimeSheetScaleNo;
		private BOSComponent.BOSMemoEdit fld_medHRTimeSheetScaleDesc;
		private TimeSheetLevelGridControl fld_dgcTimeSheetLevels;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvTimeSheetLevels;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRTimeSheetScaleNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRTimeSheetScaleDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dgcTimeSheetLevels = new BOSERP.Modules.TimeSheetScale.TimeSheetLevelGridControl();
            this.fld_dgvTimeSheetLevels = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetScaleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRTimeSheetScaleDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTimeSheetLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvTimeSheetLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = "";
            this.fld_lblLabel.Location = new System.Drawing.Point(14, 39);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(99, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Mã thang chấm công";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(14, 65);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Diễn giải";
            // 
            // fld_txtHRTimeSheetScaleNo
            // 
            this.fld_txtHRTimeSheetScaleNo.BOSComment = "";
            this.fld_txtHRTimeSheetScaleNo.BOSDataMember = "HRTimeSheetScaleNo";
            this.fld_txtHRTimeSheetScaleNo.BOSDataSource = "HRTimeSheetScales";
            this.fld_txtHRTimeSheetScaleNo.BOSDescription = null;
            this.fld_txtHRTimeSheetScaleNo.BOSError = null;
            this.fld_txtHRTimeSheetScaleNo.BOSFieldGroup = "";
            this.fld_txtHRTimeSheetScaleNo.BOSFieldRelation = "";
            this.fld_txtHRTimeSheetScaleNo.BOSPrivilege = "";
            this.fld_txtHRTimeSheetScaleNo.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetScaleNo.EditValue = "";
            this.fld_txtHRTimeSheetScaleNo.Location = new System.Drawing.Point(137, 36);
            this.fld_txtHRTimeSheetScaleNo.Name = "fld_txtHRTimeSheetScaleNo";
            this.fld_txtHRTimeSheetScaleNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetScaleNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetScaleNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetScaleNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetScaleNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetScaleNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetScaleNo.Screen = null;
            this.fld_txtHRTimeSheetScaleNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRTimeSheetScaleNo.TabIndex = 1;
            this.fld_txtHRTimeSheetScaleNo.Tag = "DC";
            // 
            // fld_medHRTimeSheetScaleDesc
            // 
            this.fld_medHRTimeSheetScaleDesc.BOSComment = "";
            this.fld_medHRTimeSheetScaleDesc.BOSDataMember = "HRTimeSheetScaleDesc";
            this.fld_medHRTimeSheetScaleDesc.BOSDataSource = "HRTimeSheetScales";
            this.fld_medHRTimeSheetScaleDesc.BOSDescription = null;
            this.fld_medHRTimeSheetScaleDesc.BOSError = null;
            this.fld_medHRTimeSheetScaleDesc.BOSFieldGroup = "";
            this.fld_medHRTimeSheetScaleDesc.BOSFieldRelation = "";
            this.fld_medHRTimeSheetScaleDesc.BOSPrivilege = "";
            this.fld_medHRTimeSheetScaleDesc.BOSPropertyName = "Text";
            this.fld_medHRTimeSheetScaleDesc.EditValue = "";
            this.fld_medHRTimeSheetScaleDesc.Location = new System.Drawing.Point(137, 62);
            this.fld_medHRTimeSheetScaleDesc.Name = "fld_medHRTimeSheetScaleDesc";
            this.fld_medHRTimeSheetScaleDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRTimeSheetScaleDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRTimeSheetScaleDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRTimeSheetScaleDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRTimeSheetScaleDesc.Screen = null;
            this.fld_medHRTimeSheetScaleDesc.Size = new System.Drawing.Size(552, 41);
            this.fld_medHRTimeSheetScaleDesc.TabIndex = 2;
            this.fld_medHRTimeSheetScaleDesc.Tag = "DC";
            // 
            // fld_dgcTimeSheetLevels
            // 
            this.fld_dgcTimeSheetLevels.AllowDrop = true;
            this.fld_dgcTimeSheetLevels.BOSComment = "";
            this.fld_dgcTimeSheetLevels.BOSDataMember = "";
            this.fld_dgcTimeSheetLevels.BOSDataSource = "HRTimeSheetLevels";
            this.fld_dgcTimeSheetLevels.BOSDescription = null;
            this.fld_dgcTimeSheetLevels.BOSError = null;
            this.fld_dgcTimeSheetLevels.BOSFieldGroup = "";
            this.fld_dgcTimeSheetLevels.BOSFieldRelation = "";
            this.fld_dgcTimeSheetLevels.BOSGridType = null;
            this.fld_dgcTimeSheetLevels.BOSPrivilege = "";
            this.fld_dgcTimeSheetLevels.BOSPropertyName = "";
            this.fld_dgcTimeSheetLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcTimeSheetLevels.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcTimeSheetLevels.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcTimeSheetLevels.MainView = this.fld_dgvTimeSheetLevels;
            this.fld_dgcTimeSheetLevels.Name = "fld_dgcTimeSheetLevels";
            this.fld_dgcTimeSheetLevels.Screen = null;
            this.fld_dgcTimeSheetLevels.Size = new System.Drawing.Size(838, 280);
            this.fld_dgcTimeSheetLevels.TabIndex = 0;
            this.fld_dgcTimeSheetLevels.Tag = "DC";
            this.fld_dgcTimeSheetLevels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvTimeSheetLevels});
            // 
            // fld_dgvTimeSheetLevels
            // 
            this.fld_dgvTimeSheetLevels.GridControl = this.fld_dgcTimeSheetLevels;
            this.fld_dgvTimeSheetLevels.Name = "fld_dgvTimeSheetLevels";
            this.fld_dgvTimeSheetLevels.PaintStyleName = "Office2003";
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcTimeSheetLevels);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 132);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(842, 304);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Text = "Thang chấm công";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel);
            this.bosGroupControl2.Controls.Add(this.fld_medHRTimeSheetScaleDesc);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel1);
            this.bosGroupControl2.Controls.Add(this.fld_txtHRTimeSheetScaleNo);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(842, 123);
            this.bosGroupControl2.TabIndex = 0;
            this.bosGroupControl2.Text = "Thông tin chung";
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
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 452);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMTSS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 452);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMTSS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetScaleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRTimeSheetScaleDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTimeSheetLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvTimeSheetLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPanel bosPanel1;
	}
}

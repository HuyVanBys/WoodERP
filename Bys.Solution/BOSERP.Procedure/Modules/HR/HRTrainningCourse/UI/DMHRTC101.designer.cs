using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTrainningCourse.UI
{
	/// <summary>
	/// Summary description for DMHRTC101
	/// </summary>
	partial class DMHRTC101
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl2;
		private HRTrainningClassGridControl fld_dgcHRTrainningClass;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTrainningClass;
		private BOSComponent.BOSGroupControl fld_grcGroupControl3;
		private HRClassSchedulesGridControl fld_dgcHRClassSchedules;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRClassSchedules;


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
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRTrainningClass = new BOSERP.Modules.HRTrainningCourse.HRTrainningClassGridControl();
            this.fld_dgvHRTrainningClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRClassSchedules = new BOSERP.Modules.HRTrainningCourse.HRClassSchedulesGridControl();
            this.fld_dgvHRClassSchedules = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRClassSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRClassSchedules)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl2.BOSComment = "";
            this.fld_grcGroupControl2.BOSDataMember = "";
            this.fld_grcGroupControl2.BOSDataSource = "";
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = "";
            this.fld_grcGroupControl2.BOSFieldRelation = "";
            this.fld_grcGroupControl2.BOSPrivilege = "";
            this.fld_grcGroupControl2.BOSPropertyName = "";
            this.fld_grcGroupControl2.Controls.Add(this.fld_dgcHRTrainningClass);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(730, 282);
            this.fld_grcGroupControl2.TabIndex = 4;
            this.fld_grcGroupControl2.Tag = "";
            this.fld_grcGroupControl2.Text = "Danh sách lớp học";
            // 
            // fld_dgcHRTrainningClass
            // 
            this.fld_dgcHRTrainningClass.AllowDrop = true;
            this.fld_dgcHRTrainningClass.BOSComment = "";
            this.fld_dgcHRTrainningClass.BOSDataMember = "";
            this.fld_dgcHRTrainningClass.BOSDataSource = "HRTrainningClass";
            this.fld_dgcHRTrainningClass.BOSDescription = null;
            this.fld_dgcHRTrainningClass.BOSError = null;
            this.fld_dgcHRTrainningClass.BOSFieldGroup = "";
            this.fld_dgcHRTrainningClass.BOSFieldRelation = "";
            this.fld_dgcHRTrainningClass.BOSGridType = null;
            this.fld_dgcHRTrainningClass.BOSPrivilege = "";
            this.fld_dgcHRTrainningClass.BOSPropertyName = "";
            this.fld_dgcHRTrainningClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRTrainningClass.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTrainningClass.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRTrainningClass.MainView = this.fld_dgvHRTrainningClass;
            this.fld_dgcHRTrainningClass.Name = "fld_dgcHRTrainningClass";
            this.fld_dgcHRTrainningClass.Screen = null;
            this.fld_dgcHRTrainningClass.Size = new System.Drawing.Size(726, 258);
            this.fld_dgcHRTrainningClass.TabIndex = 5;
            this.fld_dgcHRTrainningClass.Tag = "DC";
            this.fld_dgcHRTrainningClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTrainningClass});
            // 
            // fld_dgvHRTrainningClass
            // 
            this.fld_dgvHRTrainningClass.GridControl = this.fld_dgcHRTrainningClass;
            this.fld_dgvHRTrainningClass.Name = "fld_dgvHRTrainningClass";
            this.fld_dgvHRTrainningClass.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = "";
            this.fld_grcGroupControl3.BOSDataMember = "";
            this.fld_grcGroupControl3.BOSDataSource = "";
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = "";
            this.fld_grcGroupControl3.BOSFieldRelation = "";
            this.fld_grcGroupControl3.BOSPrivilege = "";
            this.fld_grcGroupControl3.BOSPropertyName = "";
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHRClassSchedules);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(-1, 291);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(732, 264);
            this.fld_grcGroupControl3.TabIndex = 6;
            this.fld_grcGroupControl3.Tag = "";
            this.fld_grcGroupControl3.Text = "Thời gian biểu";
            // 
            // fld_dgcHRClassSchedules
            // 
            this.fld_dgcHRClassSchedules.AllowDrop = true;
            this.fld_dgcHRClassSchedules.BOSComment = "";
            this.fld_dgcHRClassSchedules.BOSDataMember = "";
            this.fld_dgcHRClassSchedules.BOSDataSource = "HRClassSchedules";
            this.fld_dgcHRClassSchedules.BOSDescription = null;
            this.fld_dgcHRClassSchedules.BOSError = null;
            this.fld_dgcHRClassSchedules.BOSFieldGroup = "";
            this.fld_dgcHRClassSchedules.BOSFieldRelation = "";
            this.fld_dgcHRClassSchedules.BOSGridType = null;
            this.fld_dgcHRClassSchedules.BOSPrivilege = "";
            this.fld_dgcHRClassSchedules.BOSPropertyName = "";
            this.fld_dgcHRClassSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRClassSchedules.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRClassSchedules.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRClassSchedules.MainView = this.fld_dgvHRClassSchedules;
            this.fld_dgcHRClassSchedules.Name = "fld_dgcHRClassSchedules";
            this.fld_dgcHRClassSchedules.Screen = null;
            this.fld_dgcHRClassSchedules.Size = new System.Drawing.Size(728, 240);
            this.fld_dgcHRClassSchedules.TabIndex = 7;
            this.fld_dgcHRClassSchedules.Tag = "DC";
            this.fld_dgcHRClassSchedules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRClassSchedules});
            // 
            // fld_dgvHRClassSchedules
            // 
            this.fld_dgvHRClassSchedules.GridControl = this.fld_dgcHRClassSchedules;
            this.fld_dgvHRClassSchedules.Name = "fld_dgvHRClassSchedules";
            this.fld_dgvHRClassSchedules.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(740, 567);
            this.bosPanel1.TabIndex = 7;
            // 
            // DMHRTC101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(740, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRTC101";
            this.Text = "Thông tin lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRClassSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRClassSchedules)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}

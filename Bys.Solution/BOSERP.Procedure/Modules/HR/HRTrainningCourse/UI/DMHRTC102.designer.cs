using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTrainningCourse.UI
{
	/// <summary>
	/// Summary description for DMHRTC102
	/// </summary>
	partial class DMHRTC102
    {
		private HRTrainningSchedulesGridControl fld_dgcHRTrainningSchedules;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTrainningSchedules;
		private BOSComponent.BOSButton fld_btnCreateSchedule;
        private BOSComponent.BOSButton fld_btnArangeSchedule;


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
            this.fld_dgcHRTrainningSchedules = new BOSERP.Modules.HRTrainningCourse.HRTrainningSchedulesGridControl();
            this.fld_dgvHRTrainningSchedules = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnCreateSchedule = new BOSComponent.BOSButton(this.components);
            this.fld_btnArangeSchedule = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningSchedules)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcHRTrainningSchedules
            // 
            this.fld_dgcHRTrainningSchedules.AllowDrop = true;
            this.fld_dgcHRTrainningSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRTrainningSchedules.BOSComment = "";
            this.fld_dgcHRTrainningSchedules.BOSDataMember = "";
            this.fld_dgcHRTrainningSchedules.BOSDataSource = "HRTrainningSchedules";
            this.fld_dgcHRTrainningSchedules.BOSDescription = null;
            this.fld_dgcHRTrainningSchedules.BOSError = null;
            this.fld_dgcHRTrainningSchedules.BOSFieldGroup = "";
            this.fld_dgcHRTrainningSchedules.BOSFieldRelation = "";
            this.fld_dgcHRTrainningSchedules.BOSGridType = null;
            this.fld_dgcHRTrainningSchedules.BOSPrivilege = "";
            this.fld_dgcHRTrainningSchedules.BOSPropertyName = "";
            this.fld_dgcHRTrainningSchedules.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTrainningSchedules.Location = new System.Drawing.Point(3, 39);
            this.fld_dgcHRTrainningSchedules.MainView = this.fld_dgvHRTrainningSchedules;
            this.fld_dgcHRTrainningSchedules.Name = "fld_dgcHRTrainningSchedules";
            this.fld_dgcHRTrainningSchedules.Screen = null;
            this.fld_dgcHRTrainningSchedules.Size = new System.Drawing.Size(847, 522);
            this.fld_dgcHRTrainningSchedules.TabIndex = 4;
            this.fld_dgcHRTrainningSchedules.Tag = "DC";
            this.fld_dgcHRTrainningSchedules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTrainningSchedules});
            // 
            // fld_dgvHRTrainningSchedules
            // 
            this.fld_dgvHRTrainningSchedules.GridControl = this.fld_dgcHRTrainningSchedules;
            this.fld_dgvHRTrainningSchedules.Name = "fld_dgvHRTrainningSchedules";
            this.fld_dgvHRTrainningSchedules.PaintStyleName = "Office2003";
            // 
            // fld_btnCreateSchedule
            // 
            this.fld_btnCreateSchedule.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCreateSchedule.Appearance.Options.UseForeColor = true;
            this.fld_btnCreateSchedule.BOSComment = "";
            this.fld_btnCreateSchedule.BOSDataMember = "";
            this.fld_btnCreateSchedule.BOSDataSource = "";
            this.fld_btnCreateSchedule.BOSDescription = null;
            this.fld_btnCreateSchedule.BOSError = null;
            this.fld_btnCreateSchedule.BOSFieldGroup = "";
            this.fld_btnCreateSchedule.BOSFieldRelation = "";
            this.fld_btnCreateSchedule.BOSPrivilege = "";
            this.fld_btnCreateSchedule.BOSPropertyName = "";
            this.fld_btnCreateSchedule.Location = new System.Drawing.Point(3, 3);
            this.fld_btnCreateSchedule.Name = "fld_btnCreateSchedule";
            this.fld_btnCreateSchedule.Screen = null;
            this.fld_btnCreateSchedule.Size = new System.Drawing.Size(100, 30);
            this.fld_btnCreateSchedule.TabIndex = 6;
            this.fld_btnCreateSchedule.Tag = "";
            this.fld_btnCreateSchedule.Text = "Tạo thời khóa biểu";
            this.fld_btnCreateSchedule.Click += new System.EventHandler(this.fld_btnCreateSchedule_Click);
            // 
            // fld_btnArangeSchedule
            // 
            this.fld_btnArangeSchedule.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnArangeSchedule.Appearance.Options.UseForeColor = true;
            this.fld_btnArangeSchedule.BOSComment = "";
            this.fld_btnArangeSchedule.BOSDataMember = "";
            this.fld_btnArangeSchedule.BOSDataSource = "";
            this.fld_btnArangeSchedule.BOSDescription = null;
            this.fld_btnArangeSchedule.BOSError = null;
            this.fld_btnArangeSchedule.BOSFieldGroup = "";
            this.fld_btnArangeSchedule.BOSFieldRelation = "";
            this.fld_btnArangeSchedule.BOSPrivilege = "";
            this.fld_btnArangeSchedule.BOSPropertyName = "";
            this.fld_btnArangeSchedule.Location = new System.Drawing.Point(109, 3);
            this.fld_btnArangeSchedule.Name = "fld_btnArangeSchedule";
            this.fld_btnArangeSchedule.Screen = null;
            this.fld_btnArangeSchedule.Size = new System.Drawing.Size(100, 30);
            this.fld_btnArangeSchedule.TabIndex = 7;
            this.fld_btnArangeSchedule.Tag = "";
            this.fld_btnArangeSchedule.Text = "Sắp TKB tự động";
            this.fld_btnArangeSchedule.Click += new System.EventHandler(this.fld_btnArangeSchedule_Click);
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
            this.bosPanel1.Controls.Add(this.fld_btnCreateSchedule);
            this.bosPanel1.Controls.Add(this.fld_btnArangeSchedule);
            this.bosPanel1.Controls.Add(this.fld_dgcHRTrainningSchedules);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 8;
            // 
            // DMHRTC102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRTC102";
            this.Text = "Thời khóa biểu";
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningSchedules)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}

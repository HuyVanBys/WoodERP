using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREvaluationStandard.UI
{
	/// <summary>
	/// Summary description for DMHRES101
	/// </summary>
	partial class DMHRES101
	{
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;


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
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREvaluationRanks = new BOSERP.Modules.HREvaluationStandard.HREvaluationRanksGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluationRanks)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHREvaluationRanks);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(857, 519);
            this.fld_grcGroupControl3.TabIndex = 4;
            this.fld_grcGroupControl3.Tag = "";
            this.fld_grcGroupControl3.Text = "Cấu hình thang đánh giá";
            // 
            // fld_dgcHREvaluationRanks
            // 
            this.fld_dgcHREvaluationRanks.BOSComment = null;
            this.fld_dgcHREvaluationRanks.BOSDataMember = null;
            this.fld_dgcHREvaluationRanks.BOSDataSource = "HREvaluationRanks";
            this.fld_dgcHREvaluationRanks.BOSDescription = null;
            this.fld_dgcHREvaluationRanks.BOSError = null;
            this.fld_dgcHREvaluationRanks.BOSFieldGroup = null;
            this.fld_dgcHREvaluationRanks.BOSFieldRelation = null;
            this.fld_dgcHREvaluationRanks.BOSGridType = null;
            this.fld_dgcHREvaluationRanks.BOSPrivilege = null;
            this.fld_dgcHREvaluationRanks.BOSPropertyName = null;
            this.fld_dgcHREvaluationRanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREvaluationRanks.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHREvaluationRanks.MenuManager = this.screenToolbar;
            this.fld_dgcHREvaluationRanks.Name = "fld_dgcHREvaluationRanks";
            this.fld_dgcHREvaluationRanks.Screen = null;
            this.fld_dgcHREvaluationRanks.Size = new System.Drawing.Size(853, 495);
            this.fld_dgcHREvaluationRanks.TabIndex = 1;
            this.fld_dgcHREvaluationRanks.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_btnSave);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(775, 529);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 5;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // DMHRES101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRES101";
            this.Text = "Cấu hình thang đánh giá";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluationRanks)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSButton fld_btnSave;
        private HREvaluationRanksGridControl fld_dgcHREvaluationRanks;
	}
}

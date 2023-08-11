using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
    /// Summary description for DMCS112
	/// </summary>
    partial class DMCS112
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
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grpGroupControl5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcPMProjectTypesGridControl = new BOSERP.Modules.CompanyConstant.PMProjectTypesGridControl();
            this.fld_dgvADFengShuisGenarals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcPMPhaseTypesGridControl = new BOSERP.Modules.CompanyConstant.PMPhaseTypesGridControl();
            this.panel1.SuspendLayout();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectTypesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADFengShuisGenarals)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMPhaseTypesGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.fld_grpGroupControl5);
            this.panel1.Controls.Add(this.bosLine2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(822, 688);
            this.panel1.TabIndex = 6;
            // 
            // fld_grpGroupControl5
            // 
            this.fld_grpGroupControl5.BOSComment = null;
            this.fld_grpGroupControl5.BOSDataMember = null;
            this.fld_grpGroupControl5.BOSDataSource = null;
            this.fld_grpGroupControl5.BOSDescription = null;
            this.fld_grpGroupControl5.BOSError = null;
            this.fld_grpGroupControl5.BOSFieldGroup = null;
            this.fld_grpGroupControl5.BOSFieldRelation = null;
            this.fld_grpGroupControl5.BOSPrivilege = null;
            this.fld_grpGroupControl5.BOSPropertyName = null;
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcPMProjectTypesGridControl);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(16, 8);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(785, 316);
            this.fld_grpGroupControl5.TabIndex = 12;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Loại dự án";
            // 
            // fld_dgcPMProjectTypesGridControl
            // 
            this.fld_dgcPMProjectTypesGridControl.AllowDrop = true;
            this.fld_dgcPMProjectTypesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMProjectTypesGridControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcPMProjectTypesGridControl.BOSDataMember = null;
            this.fld_dgcPMProjectTypesGridControl.BOSDataSource = "PMProjectTypes";
            this.fld_dgcPMProjectTypesGridControl.BOSDescription = null;
            this.fld_dgcPMProjectTypesGridControl.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcPMProjectTypesGridControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcPMProjectTypesGridControl.BOSFieldRelation = null;
            this.fld_dgcPMProjectTypesGridControl.BOSGridType = null;
            this.fld_dgcPMProjectTypesGridControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcPMProjectTypesGridControl.BOSPropertyName = null;
            this.fld_dgcPMProjectTypesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcPMProjectTypesGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcPMProjectTypesGridControl.MainView = this.fld_dgvADFengShuisGenarals;
            this.fld_dgcPMProjectTypesGridControl.Name = "fld_dgcPMProjectTypesGridControl";
            this.fld_dgcPMProjectTypesGridControl.PrintReport = false;
            this.fld_dgcPMProjectTypesGridControl.Screen = null;
            this.fld_dgcPMProjectTypesGridControl.Size = new System.Drawing.Size(774, 290);
            this.fld_dgcPMProjectTypesGridControl.TabIndex = 4;
            this.fld_dgcPMProjectTypesGridControl.Tag = "DC";
            this.fld_dgcPMProjectTypesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvADFengShuisGenarals});
            // 
            // fld_dgvADFengShuisGenarals
            // 
            this.fld_dgvADFengShuisGenarals.GridControl = this.fld_dgcPMProjectTypesGridControl;
            this.fld_dgvADFengShuisGenarals.Name = "fld_dgvADFengShuisGenarals";
            this.fld_dgvADFengShuisGenarals.PaintStyleName = "Office2003";
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcPMPhaseTypesGridControl);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(16, 330);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(785, 346);
            this.bosLine2.TabIndex = 14;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Giai đoạn";
            // 
            // fld_dgcPMPhaseTypesGridControl
            // 
            this.fld_dgcPMPhaseTypesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMPhaseTypesGridControl.BOSComment = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSDataMember = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSDataSource = "PMPhaseTypes";
            this.fld_dgcPMPhaseTypesGridControl.BOSDescription = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSError = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSFieldGroup = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSFieldRelation = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSGridType = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSPrivilege = null;
            this.fld_dgcPMPhaseTypesGridControl.BOSPropertyName = null;
            this.fld_dgcPMPhaseTypesGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcPMPhaseTypesGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPMPhaseTypesGridControl.Name = "fld_dgcPMPhaseTypesGridControl";
            this.fld_dgcPMPhaseTypesGridControl.PrintReport = false;
            this.fld_dgcPMPhaseTypesGridControl.Screen = null;
            this.fld_dgcPMPhaseTypesGridControl.Size = new System.Drawing.Size(773, 320);
            this.fld_dgcPMPhaseTypesGridControl.TabIndex = 0;
            // 
            // DMCS112
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 688);
            this.Controls.Add(this.panel1);
            this.Name = "DMCS112";
            this.Text = "Cấu hình dự án";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectTypesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADFengShuisGenarals)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMPhaseTypesGridControl)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private PMProjectTypesGridControl fld_dgcPMProjectTypesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvADFengShuisGenarals;
        private BOSComponent.BOSLine bosLine2;
        private PMPhaseTypesGridControl fld_dgcPMPhaseTypesGridControl;
	}
}

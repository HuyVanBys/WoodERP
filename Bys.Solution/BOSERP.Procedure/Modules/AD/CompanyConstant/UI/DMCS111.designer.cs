using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
    /// Summary description for DMCS111
	/// </summary>
    partial class DMCS111
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
            this.fld_dgcADTargetReportBudgetsGridControl = new BOSERP.Modules.CompanyConstant.ADTargetReportBudgetsGridControl();
            this.fld_dgcADTargetReportBudgets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTargetReportBudgetsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTargetReportBudgets)).BeginInit();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(822, 688);
            this.panel1.TabIndex = 6;
            // 
            // fld_grpGroupControl5
            // 
            this.fld_grpGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpGroupControl5.BOSComment = null;
            this.fld_grpGroupControl5.BOSDataMember = null;
            this.fld_grpGroupControl5.BOSDataSource = null;
            this.fld_grpGroupControl5.BOSDescription = null;
            this.fld_grpGroupControl5.BOSError = null;
            this.fld_grpGroupControl5.BOSFieldGroup = null;
            this.fld_grpGroupControl5.BOSFieldRelation = null;
            this.fld_grpGroupControl5.BOSPrivilege = null;
            this.fld_grpGroupControl5.BOSPropertyName = null;
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcADTargetReportBudgetsGridControl);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(16, 8);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(785, 337);
            this.fld_grpGroupControl5.TabIndex = 12;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Chỉ tiêu báo cáo theo dõi ngân sách";
            // 
            // fld_dgcADTargetReportBudgetsGridControl
            // 
            this.fld_dgcADTargetReportBudgetsGridControl.AllowDrop = true;
            this.fld_dgcADTargetReportBudgetsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADTargetReportBudgetsGridControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSDataMember = null;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSDataSource = "ADTargetReportBudgets";
            this.fld_dgcADTargetReportBudgetsGridControl.BOSDescription = null;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSFieldRelation = null;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSGridType = null;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADTargetReportBudgetsGridControl.BOSPropertyName = null;
            this.fld_dgcADTargetReportBudgetsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcADTargetReportBudgetsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADTargetReportBudgetsGridControl.MainView = this.fld_dgcADTargetReportBudgets;
            this.fld_dgcADTargetReportBudgetsGridControl.Name = "fld_dgcADTargetReportBudgetsGridControl";
            this.fld_dgcADTargetReportBudgetsGridControl.PrintReport = false;
            this.fld_dgcADTargetReportBudgetsGridControl.Screen = null;
            this.fld_dgcADTargetReportBudgetsGridControl.Size = new System.Drawing.Size(774, 308);
            this.fld_dgcADTargetReportBudgetsGridControl.TabIndex = 4;
            this.fld_dgcADTargetReportBudgetsGridControl.Tag = "DC";
            this.fld_dgcADTargetReportBudgetsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgcADTargetReportBudgets});
            // 
            // fld_dgcADTargetReportBudgets
            // 
            this.fld_dgcADTargetReportBudgets.GridControl = this.fld_dgcADTargetReportBudgetsGridControl;
            this.fld_dgcADTargetReportBudgets.Name = "fld_dgcADTargetReportBudgets";
            this.fld_dgcADTargetReportBudgets.PaintStyleName = "Office2003";
            // 
            // DMCS111
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 688);
            this.Controls.Add(this.panel1);
            this.Name = "DMCS111";
            this.Text = "Ngân sách";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTargetReportBudgetsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTargetReportBudgets)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private ADTargetReportBudgetsGridControl fld_dgcADTargetReportBudgetsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgcADTargetReportBudgets;
	}
}

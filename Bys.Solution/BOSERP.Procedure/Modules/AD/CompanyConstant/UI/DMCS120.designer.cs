using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS120
    /// </summary>
    partial class DMCS120
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
            this.fld_dgcADReportViewRefs = new BOSERP.Modules.CompanyConstant.ADReportViewRefsGridControl();
            this.fld_dgvADTemplatesGenarals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcADReportViewRefParams = new BOSERP.Modules.CompanyConstant.ADReportViewRefParamsGridControl();
            this.panel1.SuspendLayout();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportViewRefs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADTemplatesGenarals)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportViewRefParams)).BeginInit();
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
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcADReportViewRefs);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(16, 8);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(785, 316);
            this.fld_grpGroupControl5.TabIndex = 12;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Report && module";
            // 
            // fld_dgcADReportViewRefs
            // 
            this.fld_dgcADReportViewRefs.AllowDrop = true;
            this.fld_dgcADReportViewRefs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADReportViewRefs.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportViewRefs.BOSDataMember = null;
            this.fld_dgcADReportViewRefs.BOSDataSource = "ADReportViewRefs";
            this.fld_dgcADReportViewRefs.BOSDescription = null;
            this.fld_dgcADReportViewRefs.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportViewRefs.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportViewRefs.BOSFieldRelation = null;
            this.fld_dgcADReportViewRefs.BOSGridType = null;
            this.fld_dgcADReportViewRefs.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportViewRefs.BOSPropertyName = null;
            this.fld_dgcADReportViewRefs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcADReportViewRefs.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADReportViewRefs.MainView = this.fld_dgvADTemplatesGenarals;
            this.fld_dgcADReportViewRefs.Name = "fld_dgcADReportViewRefs";
            this.fld_dgcADReportViewRefs.PrintReport = false;
            this.fld_dgcADReportViewRefs.Screen = null;
            this.fld_dgcADReportViewRefs.Size = new System.Drawing.Size(774, 290);
            this.fld_dgcADReportViewRefs.TabIndex = 4;
            this.fld_dgcADReportViewRefs.Tag = "DC";
            this.fld_dgcADReportViewRefs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvADTemplatesGenarals});
            // 
            // fld_dgvADTemplatesGenarals
            // 
            this.fld_dgvADTemplatesGenarals.GridControl = this.fld_dgcADReportViewRefs;
            this.fld_dgvADTemplatesGenarals.Name = "fld_dgvADTemplatesGenarals";
            this.fld_dgvADTemplatesGenarals.PaintStyleName = "Office2003";
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcADReportViewRefParams);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(16, 330);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(785, 346);
            this.bosLine2.TabIndex = 14;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Tham số";
            // 
            // fld_dgcADReportViewRefParams
            // 
            this.fld_dgcADReportViewRefParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADReportViewRefParams.BOSComment = null;
            this.fld_dgcADReportViewRefParams.BOSDataMember = null;
            this.fld_dgcADReportViewRefParams.BOSDataSource = "ADReportViewRefParams";
            this.fld_dgcADReportViewRefParams.BOSDescription = null;
            this.fld_dgcADReportViewRefParams.BOSError = null;
            this.fld_dgcADReportViewRefParams.BOSFieldGroup = null;
            this.fld_dgcADReportViewRefParams.BOSFieldRelation = null;
            this.fld_dgcADReportViewRefParams.BOSGridType = null;
            this.fld_dgcADReportViewRefParams.BOSPrivilege = null;
            this.fld_dgcADReportViewRefParams.BOSPropertyName = null;
            this.fld_dgcADReportViewRefParams.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADReportViewRefParams.MenuManager = this.screenToolbar;
            this.fld_dgcADReportViewRefParams.Name = "fld_dgcADReportViewRefParams";
            this.fld_dgcADReportViewRefParams.PrintReport = false;
            this.fld_dgcADReportViewRefParams.Screen = null;
            this.fld_dgcADReportViewRefParams.Size = new System.Drawing.Size(773, 320);
            this.fld_dgcADReportViewRefParams.TabIndex = 0;
            // 
            // DMCS117
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 688);
            this.Controls.Add(this.panel1);
            this.Name = "DMCS117";
            this.Text = "Chức năng truy ngược chứng từ gốc";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportViewRefs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADTemplatesGenarals)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportViewRefParams)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private ADReportViewRefsGridControl fld_dgcADReportViewRefs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvADTemplatesGenarals;
        private BOSComponent.BOSLine bosLine2;
        private ADReportViewRefParamsGridControl fld_dgcADReportViewRefParams;
    }
}

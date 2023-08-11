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
    partial class DMCS115
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
            this.fld_dgcADReportTemplatesGridControl = new BOSERP.Modules.CompanyConstant.ADReportTemplatesGridControl();
            this.fld_dgvADReportTemplatesGenarals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcADTemplateToolbarsGridControl = new BOSERP.Modules.CompanyConstant.ADTemplateToolbarsGridControl();
            this.panel1.SuspendLayout();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportTemplatesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADReportTemplatesGenarals)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTemplateToolbarsGridControl)).BeginInit();
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
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcADReportTemplatesGridControl);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(16, 8);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(785, 316);
            this.fld_grpGroupControl5.TabIndex = 12;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Mẫu in báo cáo";
            // 
            // fld_dgcADReportTemplatesGridControl
            // 
            this.fld_dgcADReportTemplatesGridControl.AllowDrop = true;
            this.fld_dgcADReportTemplatesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADReportTemplatesGridControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportTemplatesGridControl.BOSDataMember = null;
            this.fld_dgcADReportTemplatesGridControl.BOSDataSource = "ADReportTemplates";
            this.fld_dgcADReportTemplatesGridControl.BOSDescription = null;
            this.fld_dgcADReportTemplatesGridControl.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportTemplatesGridControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportTemplatesGridControl.BOSFieldRelation = null;
            this.fld_dgcADReportTemplatesGridControl.BOSGridType = null;
            this.fld_dgcADReportTemplatesGridControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADReportTemplatesGridControl.BOSPropertyName = null;
            this.fld_dgcADReportTemplatesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcADReportTemplatesGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADReportTemplatesGridControl.MainView = this.fld_dgvADReportTemplatesGenarals;
            this.fld_dgcADReportTemplatesGridControl.Name = "fld_dgcADReportTemplatesGridControl";
            this.fld_dgcADReportTemplatesGridControl.PrintReport = false;
            this.fld_dgcADReportTemplatesGridControl.Screen = null;
            this.fld_dgcADReportTemplatesGridControl.Size = new System.Drawing.Size(774, 290);
            this.fld_dgcADReportTemplatesGridControl.TabIndex = 4;
            this.fld_dgcADReportTemplatesGridControl.Tag = "DC";
            this.fld_dgcADReportTemplatesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvADReportTemplatesGenarals});
            // 
            // fld_dgvADReportTemplatesGenarals
            // 
            this.fld_dgvADReportTemplatesGenarals.GridControl = this.fld_dgcADReportTemplatesGridControl;
            this.fld_dgvADReportTemplatesGenarals.Name = "fld_dgvADReportTemplatesGenarals";
            this.fld_dgvADReportTemplatesGenarals.PaintStyleName = "Office2003";
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
            this.bosLine2.Controls.Add(this.fld_dgcADTemplateToolbarsGridControl);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(16, 330);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(785, 346);
            this.bosLine2.TabIndex = 14;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Tham số";
            // 
            // fld_dgcADTemplateToolbarsGridControl
            // 
            this.fld_dgcADTemplateToolbarsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADTemplateToolbarsGridControl.BOSComment = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSDataMember = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSDataSource = "ADTemplateToolbars";
            this.fld_dgcADTemplateToolbarsGridControl.BOSDescription = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSError = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSFieldGroup = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSFieldRelation = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSGridType = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSPrivilege = null;
            this.fld_dgcADTemplateToolbarsGridControl.BOSPropertyName = null;
            this.fld_dgcADTemplateToolbarsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADTemplateToolbarsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcADTemplateToolbarsGridControl.Name = "fld_dgcADTemplateToolbarsGridControl";
            this.fld_dgcADTemplateToolbarsGridControl.PrintReport = false;
            this.fld_dgcADTemplateToolbarsGridControl.Screen = null;
            this.fld_dgcADTemplateToolbarsGridControl.Size = new System.Drawing.Size(773, 320);
            this.fld_dgcADTemplateToolbarsGridControl.TabIndex = 0;
            // 
            // DMCS112
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 688);
            this.Controls.Add(this.panel1);
            this.Name = "DMCS114";
            this.Text = "Cấu hình mẫu in";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportTemplatesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADReportTemplatesGenarals)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTemplateToolbarsGridControl)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private ADReportTemplatesGridControl fld_dgcADReportTemplatesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvADReportTemplatesGenarals;
        private BOSComponent.BOSLine bosLine2;
        private ADTemplateToolbarsGridControl fld_dgcADTemplateToolbarsGridControl;
    }
}

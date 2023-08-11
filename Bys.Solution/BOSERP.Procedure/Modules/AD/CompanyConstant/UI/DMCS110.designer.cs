using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS110
	/// </summary>
	partial class DMCS110
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
            this.fld_dgcADFengShuisGenaralsGridControl = new BOSERP.Modules.CompanyConstant.ADFengShuisGenaralsGridControl();
            this.fld_dgvADFengShuisGenarals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcADFengShuisDirectionsGridControl = new BOSERP.Modules.CompanyConstant.ADFengShuisDirectionsGridControl();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcADFengShuisColorsGridControl = new BOSERP.Modules.CompanyConstant.ADFengShuisColorsGridControl();
            this.panel1.SuspendLayout();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADFengShuisGenaralsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADFengShuisGenarals)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADFengShuisDirectionsGridControl)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADFengShuisColorsGridControl)).BeginInit();
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
            this.panel1.Controls.Add(this.bosLine1);
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
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcADFengShuisGenaralsGridControl);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(16, 8);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(785, 196);
            this.fld_grpGroupControl5.TabIndex = 12;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Tổng quan";
            // 
            // fld_dgcADFengShuisGenaralsGridControl
            // 
            this.fld_dgcADFengShuisGenaralsGridControl.AllowDrop = true;
            this.fld_dgcADFengShuisGenaralsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADFengShuisGenaralsGridControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSDataMember = null;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSDataSource = "ADFengShuisGenarals";
            this.fld_dgcADFengShuisGenaralsGridControl.BOSDescription = null;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSFieldRelation = null;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSGridType = null;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcADFengShuisGenaralsGridControl.BOSPropertyName = null;
            this.fld_dgcADFengShuisGenaralsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcADFengShuisGenaralsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADFengShuisGenaralsGridControl.MainView = this.fld_dgvADFengShuisGenarals;
            this.fld_dgcADFengShuisGenaralsGridControl.Name = "fld_dgcADFengShuisGenaralsGridControl";
            this.fld_dgcADFengShuisGenaralsGridControl.PrintReport = false;
            this.fld_dgcADFengShuisGenaralsGridControl.Screen = null;
            this.fld_dgcADFengShuisGenaralsGridControl.Size = new System.Drawing.Size(774, 167);
            this.fld_dgcADFengShuisGenaralsGridControl.TabIndex = 4;
            this.fld_dgcADFengShuisGenaralsGridControl.Tag = "DC";
            this.fld_dgcADFengShuisGenaralsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvADFengShuisGenarals});
            // 
            // fld_dgvADFengShuisGenarals
            // 
            this.fld_dgvADFengShuisGenarals.GridControl = this.fld_dgcADFengShuisGenaralsGridControl;
            this.fld_dgvADFengShuisGenarals.Name = "fld_dgvADFengShuisGenarals";
            this.fld_dgvADFengShuisGenarals.PaintStyleName = "Office2003";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcADFengShuisDirectionsGridControl);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(16, 447);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(785, 216);
            this.bosLine1.TabIndex = 13;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Hướng";
            // 
            // fld_dgcADFengShuisDirectionsGridControl
            // 
            this.fld_dgcADFengShuisDirectionsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADFengShuisDirectionsGridControl.BOSComment = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSDataMember = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSDataSource = "ADFengShuisDirections";
            this.fld_dgcADFengShuisDirectionsGridControl.BOSDescription = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSError = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSFieldGroup = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSFieldRelation = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSGridType = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSPrivilege = null;
            this.fld_dgcADFengShuisDirectionsGridControl.BOSPropertyName = null;
            this.fld_dgcADFengShuisDirectionsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADFengShuisDirectionsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcADFengShuisDirectionsGridControl.Name = "fld_dgcADFengShuisDirectionsGridControl";
            this.fld_dgcADFengShuisDirectionsGridControl.PrintReport = false;
            this.fld_dgcADFengShuisDirectionsGridControl.Screen = null;
            this.fld_dgcADFengShuisDirectionsGridControl.Size = new System.Drawing.Size(773, 190);
            this.fld_dgcADFengShuisDirectionsGridControl.TabIndex = 0;
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
            this.bosLine2.Controls.Add(this.fld_dgcADFengShuisColorsGridControl);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(16, 210);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(785, 231);
            this.bosLine2.TabIndex = 14;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Màu";
            // 
            // fld_dgcADFengShuisColorsGridControl
            // 
            this.fld_dgcADFengShuisColorsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADFengShuisColorsGridControl.BOSComment = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSDataMember = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSDataSource = "ADFengShuisColors";
            this.fld_dgcADFengShuisColorsGridControl.BOSDescription = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSError = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSFieldGroup = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSFieldRelation = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSGridType = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSPrivilege = null;
            this.fld_dgcADFengShuisColorsGridControl.BOSPropertyName = null;
            this.fld_dgcADFengShuisColorsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADFengShuisColorsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcADFengShuisColorsGridControl.Name = "fld_dgcADFengShuisColorsGridControl";
            this.fld_dgcADFengShuisColorsGridControl.PrintReport = false;
            this.fld_dgcADFengShuisColorsGridControl.Screen = null;
            this.fld_dgcADFengShuisColorsGridControl.Size = new System.Drawing.Size(773, 205);
            this.fld_dgcADFengShuisColorsGridControl.TabIndex = 0;
            // 
            // DMCS110
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 688);
            this.Controls.Add(this.panel1);
            this.Name = "DMCS110";
            this.Text = "Cấu hình phong thủy";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADFengShuisGenaralsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADFengShuisGenarals)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADFengShuisDirectionsGridControl)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADFengShuisColorsGridControl)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private ADFengShuisGenaralsGridControl fld_dgcADFengShuisGenaralsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvADFengShuisGenarals;
        private BOSComponent.BOSLine bosLine1;
        private ADFengShuisDirectionsGridControl fld_dgcADFengShuisDirectionsGridControl;
        private BOSComponent.BOSLine bosLine2;
        private ADFengShuisColorsGridControl fld_dgcADFengShuisColorsGridControl;
	}
}

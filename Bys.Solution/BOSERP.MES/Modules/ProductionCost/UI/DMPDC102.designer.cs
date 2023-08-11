using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for DMPDC102
	/// </summary>
	partial class DMPDC102
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
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox16 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox17 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox18 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcMMProductionCostOveralls622 = new BOSERP.Modules.ProductionCost.MMProductionCostOverallsGridControl();
            this.fld_dgvMMProductionCostOveralls6271 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox18.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls622)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseFont = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(13, 62);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(32, 13);
            this.bosLabel23.TabIndex = 106;
            this.bosLabel23.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.Text = "Còn lại";
            // 
            // bosTextBox16
            // 
            this.bosTextBox16.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox16.BOSDataMember = "OverallProductionCostFor6278BalanceAmount";
            this.bosTextBox16.BOSDataSource = "MMProductionCosts";
            this.bosTextBox16.BOSDescription = null;
            this.bosTextBox16.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox16.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox16.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox16.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox16.BOSPropertyName = "Text";
            this.bosTextBox16.Enabled = false;
            this.bosTextBox16.Location = new System.Drawing.Point(112, 59);
            this.bosTextBox16.Name = "bosTextBox16";
            this.bosTextBox16.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox16.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox16.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox16.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox16.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox16.Screen = null;
            this.bosTextBox16.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox16.TabIndex = 100;
            this.bosTextBox16.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel24.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseFont = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(13, 36);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(92, 13);
            this.bosLabel24.TabIndex = 104;
            this.bosLabel24.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.Text = "Chi phí đã phân bổ";
            // 
            // bosTextBox17
            // 
            this.bosTextBox17.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox17.BOSDataMember = "OverallProductionCostFor6278AppropriationAmount";
            this.bosTextBox17.BOSDataSource = "MMProductionCosts";
            this.bosTextBox17.BOSDescription = null;
            this.bosTextBox17.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox17.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox17.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox17.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox17.BOSPropertyName = "Text";
            this.bosTextBox17.Enabled = false;
            this.bosTextBox17.Location = new System.Drawing.Point(112, 33);
            this.bosTextBox17.Name = "bosTextBox17";
            this.bosTextBox17.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox17.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox17.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox17.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox17.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox17.Screen = null;
            this.bosTextBox17.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox17.TabIndex = 101;
            this.bosTextBox17.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel25.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseFont = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(13, 10);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(61, 13);
            this.bosLabel25.TabIndex = 105;
            this.bosLabel25.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.Text = "Tổng chi phí";
            // 
            // bosTextBox18
            // 
            this.bosTextBox18.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox18.BOSDataMember = "OverallProductionCostFor6278TotalAmount";
            this.bosTextBox18.BOSDataSource = "MMProductionCosts";
            this.bosTextBox18.BOSDescription = null;
            this.bosTextBox18.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox18.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox18.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox18.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox18.BOSPropertyName = "Text";
            this.bosTextBox18.Enabled = false;
            this.bosTextBox18.Location = new System.Drawing.Point(112, 7);
            this.bosTextBox18.Name = "bosTextBox18";
            this.bosTextBox18.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox18.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox18.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox18.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox18.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox18.Screen = null;
            this.bosTextBox18.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox18.TabIndex = 102;
            this.bosTextBox18.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_dgcMMProductionCostOveralls622);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosTextBox4);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosTextBox5);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosTextBox6);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_dgcMMProductionCostOveralls622
            // 
            this.fld_dgcMMProductionCostOveralls622.AllowDrop = true;
            this.fld_dgcMMProductionCostOveralls622.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostOveralls622.BOSComment = null;
            this.fld_dgcMMProductionCostOveralls622.BOSDataMember = null;
            this.fld_dgcMMProductionCostOveralls622.BOSDataSource = "MMProductionCostOveralls";
            this.fld_dgcMMProductionCostOveralls622.BOSDescription = "622";
            this.fld_dgcMMProductionCostOveralls622.BOSError = null;
            this.fld_dgcMMProductionCostOveralls622.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostOveralls622.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostOveralls622.BOSGridType = null;
            this.fld_dgcMMProductionCostOveralls622.BOSPrivilege = null;
            this.fld_dgcMMProductionCostOveralls622.BOSPropertyName = null;
            this.fld_dgcMMProductionCostOveralls622.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostOveralls622.Location = new System.Drawing.Point(12, 90);
            this.fld_dgcMMProductionCostOveralls622.MainView = this.fld_dgvMMProductionCostOveralls6271;
            this.fld_dgcMMProductionCostOveralls622.Name = "fld_dgcMMProductionCostOveralls622";
            this.fld_dgcMMProductionCostOveralls622.PrintReport = false;
            this.fld_dgcMMProductionCostOveralls622.Screen = null;
            this.fld_dgcMMProductionCostOveralls622.Size = new System.Drawing.Size(838, 474);
            this.fld_dgcMMProductionCostOveralls622.TabIndex = 375;
            this.fld_dgcMMProductionCostOveralls622.Tag = "DC";
            this.fld_dgcMMProductionCostOveralls622.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMProductionCostOveralls6271});
            // 
            // fld_dgvMMProductionCostOveralls6271
            // 
            this.fld_dgvMMProductionCostOveralls6271.GridControl = this.fld_dgcMMProductionCostOveralls622;
            this.fld_dgvMMProductionCostOveralls6271.Name = "fld_dgvMMProductionCostOveralls6271";
            this.fld_dgvMMProductionCostOveralls6271.PaintStyleName = "Office2003";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(16, 67);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(32, 13);
            this.bosLabel10.TabIndex = 374;
            this.bosLabel10.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.Text = "Còn lại";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSDataMember = "DirectLaborCostFor622BalanceAmount";
            this.bosTextBox4.BOSDataSource = "MMProductionCosts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.Enabled = false;
            this.bosTextBox4.Location = new System.Drawing.Point(115, 64);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox4.TabIndex = 369;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(16, 41);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(92, 13);
            this.bosLabel11.TabIndex = 372;
            this.bosLabel11.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.Text = "Chi phí đã phân bổ";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSDataMember = "DirectLaborCostFor622AppropriationAmount";
            this.bosTextBox5.BOSDataSource = "MMProductionCosts";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.Enabled = false;
            this.bosTextBox5.Location = new System.Drawing.Point(115, 38);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox5.TabIndex = 370;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(16, 15);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(61, 13);
            this.bosLabel12.TabIndex = 373;
            this.bosLabel12.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.Text = "Tổng chi phí";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSDataMember = "DirectLaborCostFor622TotalAmount";
            this.bosTextBox6.BOSDataSource = "MMProductionCosts";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.Enabled = false;
            this.bosTextBox6.Location = new System.Drawing.Point(115, 12);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox6.TabIndex = 371;
            this.bosTextBox6.Tag = "DC";
            // 
            // DMPDC102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPDC102";
            this.Text = "Chi phí nhân công";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox18.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls622)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox bosTextBox16;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox bosTextBox17;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSTextBox bosTextBox18;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox bosTextBox6;
        private MMProductionCostOverallsGridControl fld_dgcMMProductionCostOveralls622;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMProductionCostOveralls6271;
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.VehicleGroup.UI
{
	/// <summary>
	/// Summary description for DMVM100
	/// </summary>
	partial class DMVM100
	{
		private BOSComponent.BOSTextBox fld_txtVMVehicleGroupNo;
        private BOSComponent.BOSMemoEdit fld_medVMVehicleGroupDesc;


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
            this.fld_txtVMVehicleGroupNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_medVMVehicleGroupDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcVMVehicles = new BOSERP.Modules.VehicleGroup.VehiclesGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleGroupNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleGroupDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicles)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_txtVMVehicleGroupNo
            // 
            this.fld_txtVMVehicleGroupNo.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtVMVehicleGroupNo.BOSDataMember = "VMVehicleGroupNo";
            this.fld_txtVMVehicleGroupNo.BOSDataSource = "VMVehicleGroups";
            this.fld_txtVMVehicleGroupNo.BOSDescription = null;
            this.fld_txtVMVehicleGroupNo.BOSError = null;
            this.fld_txtVMVehicleGroupNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtVMVehicleGroupNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtVMVehicleGroupNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtVMVehicleGroupNo.BOSPropertyName = "Text";
            this.fld_txtVMVehicleGroupNo.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtVMVehicleGroupNo.Location = new System.Drawing.Point(97, 35);
            this.fld_txtVMVehicleGroupNo.Name = "fld_txtVMVehicleGroupNo";
            this.fld_txtVMVehicleGroupNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleGroupNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleGroupNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleGroupNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleGroupNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleGroupNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleGroupNo.Screen = null;
            this.fld_txtVMVehicleGroupNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleGroupNo.TabIndex = 0;
            this.fld_txtVMVehicleGroupNo.Tag = "DC";
            // 
            // fld_medVMVehicleGroupDesc
            // 
            this.fld_medVMVehicleGroupDesc.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medVMVehicleGroupDesc.BOSDataMember = "VMVehicleGroupDesc";
            this.fld_medVMVehicleGroupDesc.BOSDataSource = "VMVehicleGroups";
            this.fld_medVMVehicleGroupDesc.BOSDescription = null;
            this.fld_medVMVehicleGroupDesc.BOSError = null;
            this.fld_medVMVehicleGroupDesc.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medVMVehicleGroupDesc.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medVMVehicleGroupDesc.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medVMVehicleGroupDesc.BOSPropertyName = "Text";
            this.fld_medVMVehicleGroupDesc.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medVMVehicleGroupDesc.Location = new System.Drawing.Point(97, 61);
            this.fld_medVMVehicleGroupDesc.Name = "fld_medVMVehicleGroupDesc";
            this.fld_medVMVehicleGroupDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medVMVehicleGroupDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medVMVehicleGroupDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medVMVehicleGroupDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medVMVehicleGroupDesc.Screen = null;
            this.fld_medVMVehicleGroupDesc.Size = new System.Drawing.Size(382, 57);
            this.fld_medVMVehicleGroupDesc.TabIndex = 1;
            this.fld_medVMVehicleGroupDesc.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleGroupNo);
            this.bosGroupControl1.Controls.Add(this.fld_medVMVehicleGroupDesc);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 10);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 138);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(15, 64);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(27, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Mô tả";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(15, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(58, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Text = "Mã nhóm xe";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcVMVehicles);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 154);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(856, 410);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Danh sách xe";
            // 
            // fld_dgcVMVehicles
            // 
            this.fld_dgcVMVehicles.BOSComment = null;
            this.fld_dgcVMVehicles.BOSDataMember = null;
            this.fld_dgcVMVehicles.BOSDataSource = "VMVehicles";
            this.fld_dgcVMVehicles.BOSDescription = null;
            this.fld_dgcVMVehicles.BOSError = null;
            this.fld_dgcVMVehicles.BOSFieldGroup = null;
            this.fld_dgcVMVehicles.BOSFieldRelation = null;
            this.fld_dgcVMVehicles.BOSGridType = null;
            this.fld_dgcVMVehicles.BOSPrivilege = null;
            this.fld_dgcVMVehicles.BOSPropertyName = null;
            this.fld_dgcVMVehicles.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcVMVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcVMVehicles.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcVMVehicles.MenuManager = this.screenToolbar;
            this.fld_dgcVMVehicles.Name = "fld_dgcVMVehicles";
            this.fld_dgcVMVehicles.PrintReport = false;
            this.fld_dgcVMVehicles.Screen = null;
            this.fld_dgcVMVehicles.Size = new System.Drawing.Size(852, 386);
            this.fld_dgcVMVehicles.TabIndex = 0;
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
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 8;
            // 
            // DMVM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMVM100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleGroupNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleGroupDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicles)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private VehiclesGridControl fld_dgcVMVehicles;
	}
}

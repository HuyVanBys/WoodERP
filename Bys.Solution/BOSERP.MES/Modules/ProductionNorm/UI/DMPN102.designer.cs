using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionNorm.UI
{
	/// <summary>
	/// Summary description for DMPN102
	/// </summary>
	partial class DMPN102
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeMMProductionNormOperationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOperationApprove = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductionNormItemOperations = new BOSComponent.BOSGridControl(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormOperationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemOperations)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_dgcProductionNormItemOperations);
            this.bosPanel1.Controls.Add(this.fld_lkeMMProductionNormOperationStatus);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_btnOperationApprove);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_lkeMMProductionNormOperationStatus
            // 
            this.fld_lkeMMProductionNormOperationStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormOperationStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormOperationStatus.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSDataMember = "MMProductionNormOperationStatus";
            this.fld_lkeMMProductionNormOperationStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormOperationStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormOperationStatus.BOSError = null;
            this.fld_lkeMMProductionNormOperationStatus.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormOperationStatus.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormOperationStatus.Location = new System.Drawing.Point(75, 12);
            this.fld_lkeMMProductionNormOperationStatus.Name = "fld_lkeMMProductionNormOperationStatus";
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormOperationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormOperationStatus.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormOperationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormOperationStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProductionNormOperationStatus, true);
            this.fld_lkeMMProductionNormOperationStatus.Size = new System.Drawing.Size(174, 20);
            this.fld_lkeMMProductionNormOperationStatus.TabIndex = 92;
            this.fld_lkeMMProductionNormOperationStatus.Tag = "DC";
            this.fld_lkeMMProductionNormOperationStatus.Validated += new System.EventHandler(this.fld_lkeMMProductionNormOperationStatus_Validated);
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(9, 15);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 91;
            this.bosLabel11.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.Text = "Trạng thái";
            // 
            // fld_btnOperationApprove
            // 
            this.fld_btnOperationApprove.BOSComment = null;
            this.fld_btnOperationApprove.BOSDataMember = null;
            this.fld_btnOperationApprove.BOSDataSource = null;
            this.fld_btnOperationApprove.BOSDescription = null;
            this.fld_btnOperationApprove.BOSError = null;
            this.fld_btnOperationApprove.BOSFieldGroup = null;
            this.fld_btnOperationApprove.BOSFieldRelation = null;
            this.fld_btnOperationApprove.BOSPrivilege = null;
            this.fld_btnOperationApprove.BOSPropertyName = null;
            this.fld_btnOperationApprove.Location = new System.Drawing.Point(265, 5);
            this.fld_btnOperationApprove.Name = "fld_btnOperationApprove";
            this.fld_btnOperationApprove.Screen = null;
            this.fld_btnOperationApprove.Size = new System.Drawing.Size(83, 27);
            this.fld_btnOperationApprove.TabIndex = 75;
            this.fld_btnOperationApprove.Text = "Duyệt";
            this.fld_btnOperationApprove.Click += new System.EventHandler(this.fld_btnOperationApprove_Click);
            // 
            // fld_dgcProductionNormItemOperations
            // 
            this.fld_dgcProductionNormItemOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionNormItemOperations.BOSComment = null;
            this.fld_dgcProductionNormItemOperations.BOSDataMember = null;
            this.fld_dgcProductionNormItemOperations.BOSDataSource = null;
            this.fld_dgcProductionNormItemOperations.BOSDescription = null;
            this.fld_dgcProductionNormItemOperations.BOSError = null;
            this.fld_dgcProductionNormItemOperations.BOSFieldGroup = null;
            this.fld_dgcProductionNormItemOperations.BOSFieldRelation = null;
            this.fld_dgcProductionNormItemOperations.BOSGridType = null;
            this.fld_dgcProductionNormItemOperations.BOSPrivilege = null;
            this.fld_dgcProductionNormItemOperations.BOSPropertyName = null;
            this.fld_dgcProductionNormItemOperations.Location = new System.Drawing.Point(3, 38);
            this.fld_dgcProductionNormItemOperations.MenuManager = this.screenToolbar;
            this.fld_dgcProductionNormItemOperations.Name = "fld_dgcProductionNormItemOperations";
            this.fld_dgcProductionNormItemOperations.PrintReport = false;
            this.fld_dgcProductionNormItemOperations.Screen = null;
            this.fld_dgcProductionNormItemOperations.Size = new System.Drawing.Size(856, 526);
            this.fld_dgcProductionNormItemOperations.TabIndex = 93;
            // 
            // DMPN102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPN102";
            this.Text = "Định mức công đoạn";
            this.Load += new System.EventHandler(this.DMPN102_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormOperationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemOperations)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSButton fld_btnOperationApprove;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormOperationStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSGridControl fld_dgcProductionNormItemOperations;
	}
}

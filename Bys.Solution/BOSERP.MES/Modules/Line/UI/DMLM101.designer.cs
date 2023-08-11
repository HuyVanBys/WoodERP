using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Line.UI
{
	/// <summary>
	/// Summary description for DMLM101
	/// </summary>
	partial class DMLM101
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
            this.fld_dgcMMLineOperations = new BOSERP.Modules.Line.MMLineOperationGridControl();
            this.fld_dgvGridControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLineOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_dgcMMLineOperations);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(884, 562);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_dgcMMLineOperations
            // 
            this.fld_dgcMMLineOperations.AllowDrop = true;
            this.fld_dgcMMLineOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMLineOperations.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMLineOperations.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMLineOperations.BOSDataSource = "MMLineOperations";
            this.fld_dgcMMLineOperations.BOSDescription = null;
            this.fld_dgcMMLineOperations.BOSError = null;
            this.fld_dgcMMLineOperations.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMLineOperations.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMLineOperations.BOSGridType = null;
            this.fld_dgcMMLineOperations.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMLineOperations.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMLineOperations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMLineOperations.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMLineOperations.MainView = this.fld_dgvGridControl1;
            this.fld_dgcMMLineOperations.Name = "fld_dgcMMLineOperations";
            this.fld_dgcMMLineOperations.PrintReport = false;
            this.fld_dgcMMLineOperations.Screen = null;
            this.fld_dgcMMLineOperations.Size = new System.Drawing.Size(878, 556);
            this.fld_dgcMMLineOperations.TabIndex = 8;
            this.fld_dgcMMLineOperations.Tag = "DC";
            this.fld_dgcMMLineOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl1});
            // 
            // fld_dgvGridControl1
            // 
            this.fld_dgvGridControl1.GridControl = this.fld_dgcMMLineOperations;
            this.fld_dgvGridControl1.Name = "fld_dgvGridControl1";
            this.fld_dgvGridControl1.PaintStyleName = "Office2003";
            // 
            // DMLM101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMLM101";
            this.Tag = "DM";
            this.Text = "Danh sách công đoạn";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLineOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSERP.Modules.Line.MMLineOperationGridControl fld_dgcMMLineOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl1;
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AssembleProduct.UI
{
	/// <summary>
	/// Summary description for SMAP100
	/// </summary>
	partial class SMAP100
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
            this.fld_dgcICAssembleProducts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICAssembleProductNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAssembleProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICAssembleProducts
            // 
            this.fld_dgcICAssembleProducts.BOSComment = null;
            this.fld_dgcICAssembleProducts.BOSDataMember = null;
            this.fld_dgcICAssembleProducts.BOSDataSource = "ICAssembleProducts";
            this.fld_dgcICAssembleProducts.BOSDescription = null;
            this.fld_dgcICAssembleProducts.BOSError = null;
            this.fld_dgcICAssembleProducts.BOSFieldGroup = null;
            this.fld_dgcICAssembleProducts.BOSFieldRelation = null;
            this.fld_dgcICAssembleProducts.BOSPrivilege = null;
            this.fld_dgcICAssembleProducts.BOSPropertyName = null;
            this.fld_dgcICAssembleProducts.Location = new System.Drawing.Point(107, 174);
            this.fld_dgcICAssembleProducts.MenuManager = this.screenToolbar;
            this.fld_dgcICAssembleProducts.Name = "fld_dgcICAssembleProducts";
            this.fld_dgcICAssembleProducts.Screen = null;
            this.fld_dgcICAssembleProducts.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcICAssembleProducts.TabIndex = 15;
            this.fld_dgcICAssembleProducts.Tag = "SR";
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
            this.bosLabel1.Location = new System.Drawing.Point(22, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtICAssembleProductNo1
            // 
            this.fld_txtICAssembleProductNo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICAssembleProductNo1.BOSDataMember = "ICAssembleProductNo";
            this.fld_txtICAssembleProductNo1.BOSDataSource = "ICAssembleProducts";
            this.fld_txtICAssembleProductNo1.BOSDescription = null;
            this.fld_txtICAssembleProductNo1.BOSError = null;
            this.fld_txtICAssembleProductNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICAssembleProductNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICAssembleProductNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICAssembleProductNo1.BOSPropertyName = "Text";
            this.fld_txtICAssembleProductNo1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICAssembleProductNo1.Location = new System.Drawing.Point(107, 9);
            this.fld_txtICAssembleProductNo1.Name = "fld_txtICAssembleProductNo1";
            this.fld_txtICAssembleProductNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICAssembleProductNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICAssembleProductNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICAssembleProductNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICAssembleProductNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICAssembleProductNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICAssembleProductNo1.Screen = null;
            this.fld_txtICAssembleProductNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICAssembleProductNo1.TabIndex = 0;
            this.fld_txtICAssembleProductNo1.Tag = "SC";
            // 
            // SMAP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(511, 387);
            this.Controls.Add(this.fld_dgcICAssembleProducts);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtICAssembleProductNo1);
            this.Name = "SMAP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICAssembleProductNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcICAssembleProducts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAssembleProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICAssembleProductNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcICAssembleProducts;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICAssembleProductNo1;
        private IContainer components;
	}
}

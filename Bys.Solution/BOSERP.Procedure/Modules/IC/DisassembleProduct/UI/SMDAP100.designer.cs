using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DisassembleProduct.UI
{
	/// <summary>
	/// Summary description for SMDAP100
	/// </summary>
	partial class SMDAP100
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
            this.fld_dgcICDisassembleProducts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICDisassembleProductNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDisassembleProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICDisassembleProducts
            // 
            this.fld_dgcICDisassembleProducts.BOSComment = null;
            this.fld_dgcICDisassembleProducts.BOSDataMember = null;
            this.fld_dgcICDisassembleProducts.BOSDataSource = "ICDisassembleProducts";
            this.fld_dgcICDisassembleProducts.BOSDescription = null;
            this.fld_dgcICDisassembleProducts.BOSError = null;
            this.fld_dgcICDisassembleProducts.BOSFieldGroup = null;
            this.fld_dgcICDisassembleProducts.BOSFieldRelation = null;
            this.fld_dgcICDisassembleProducts.BOSPrivilege = null;
            this.fld_dgcICDisassembleProducts.BOSPropertyName = null;
            this.fld_dgcICDisassembleProducts.Location = new System.Drawing.Point(107, 174);
            this.fld_dgcICDisassembleProducts.MenuManager = this.screenToolbar;
            this.fld_dgcICDisassembleProducts.Name = "fld_dgcICDisassembleProducts";
            this.fld_dgcICDisassembleProducts.Screen = null;
            this.fld_dgcICDisassembleProducts.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcICDisassembleProducts.TabIndex = 15;
            this.fld_dgcICDisassembleProducts.Tag = "SR";
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
            // fld_txtICDisassembleProductNo1
            // 
            this.fld_txtICDisassembleProductNo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICDisassembleProductNo1.BOSDataMember = "ICDisassembleProductNo";
            this.fld_txtICDisassembleProductNo1.BOSDataSource = "ICDisassembleProducts";
            this.fld_txtICDisassembleProductNo1.BOSDescription = null;
            this.fld_txtICDisassembleProductNo1.BOSError = null;
            this.fld_txtICDisassembleProductNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICDisassembleProductNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICDisassembleProductNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICDisassembleProductNo1.BOSPropertyName = "Text";
            this.fld_txtICDisassembleProductNo1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICDisassembleProductNo1.Location = new System.Drawing.Point(107, 9);
            this.fld_txtICDisassembleProductNo1.Name = "fld_txtICDisassembleProductNo1";
            this.fld_txtICDisassembleProductNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDisassembleProductNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDisassembleProductNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDisassembleProductNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDisassembleProductNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDisassembleProductNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDisassembleProductNo1.Screen = null;
            this.fld_txtICDisassembleProductNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICDisassembleProductNo1.TabIndex = 0;
            this.fld_txtICDisassembleProductNo1.Tag = "SC";
            // 
            // SMDAP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(511, 387);
            this.Controls.Add(this.fld_dgcICDisassembleProducts);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtICDisassembleProductNo1);
            this.Name = "SMDAP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICDisassembleProductNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcICDisassembleProducts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDisassembleProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDisassembleProductNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcICDisassembleProducts;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICDisassembleProductNo1;
        private IContainer components;
	}
}

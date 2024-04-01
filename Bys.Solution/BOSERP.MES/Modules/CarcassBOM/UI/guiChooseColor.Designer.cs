using BOSComponent;

namespace BOSERP.Modules.CarcassBOM.UI
{
    partial class guiChooseColor<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fld_dgcData = new BOSComponent.BOSGridControl(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcData)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcData
            // 
            this.fld_dgcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcData.BOSComment = null;
            this.fld_dgcData.BOSDataMember = null;
            this.fld_dgcData.BOSDataSource = "";
            this.fld_dgcData.BOSDescription = null;
            this.fld_dgcData.BOSError = null;
            this.fld_dgcData.BOSFieldGroup = null;
            this.fld_dgcData.BOSFieldRelation = null;
            this.fld_dgcData.BOSGridType = null;
            this.fld_dgcData.BOSPrivilege = null;
            this.fld_dgcData.BOSPropertyName = null;
            this.fld_dgcData.CommodityType = "";
            this.fld_dgcData.Location = new System.Drawing.Point(5, 3);
            this.fld_dgcData.MenuManager = this.screenToolbar;
            this.fld_dgcData.Name = "fld_dgcData";
            this.fld_dgcData.PrintReport = false;
            this.fld_dgcData.Screen = null;
            this.fld_dgcData.Size = new System.Drawing.Size(723, 520);
            this.fld_dgcData.TabIndex = 402;
            this.fld_dgcData.Tag = "DC";
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_btnClose);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Controls.Add(this.fld_dgcData);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(731, 557);
            this.bosPanel1.TabIndex = 406;
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(642, 527);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 405;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(553, 527);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 404;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // guiChooseColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(731, 557);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.MaximizeBox = false;
            this.MdiChildCaptionFormatString = "";
            this.MinimizeBox = false;
            this.Name = "guiChooseColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SS";
            this.Load += new System.EventHandler(this.guiChooseColor_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcData)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public BOSGridControl fld_dgcData;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
    }
}
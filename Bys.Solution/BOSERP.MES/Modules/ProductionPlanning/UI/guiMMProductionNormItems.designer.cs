namespace BOSERP.Modules.ProductionPlanning
{
    partial class guiMMProductionNormItems
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
            this.fld_btnLamDeNghi = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcMMProductionNormItems = new BOSERP.Modules.ProductionPlanning.MMProductionNormItemsGridControl();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosCheckEdit1 = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_BtnShowTonKho = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItems)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnLamDeNghi
            // 
            this.fld_btnLamDeNghi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnLamDeNghi.BOSComment = null;
            this.fld_btnLamDeNghi.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_btnLamDeNghi.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_btnLamDeNghi.BOSDescription = null;
            this.fld_btnLamDeNghi.BOSError = null;
            this.fld_btnLamDeNghi.BOSFieldGroup = null;
            this.fld_btnLamDeNghi.BOSFieldRelation = null;
            this.fld_btnLamDeNghi.BOSPrivilege = null;
            this.fld_btnLamDeNghi.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_btnLamDeNghi.Location = new System.Drawing.Point(546, 16);
            this.fld_btnLamDeNghi.Name = "fld_btnLamDeNghi";
            this.fld_btnLamDeNghi.Screen = null;
            this.fld_btnLamDeNghi.Size = new System.Drawing.Size(122, 27);
            this.fld_btnLamDeNghi.TabIndex = 2;
            this.fld_btnLamDeNghi.Tag = global::Localization.MESLocalizedResources.String1;
            this.fld_btnLamDeNghi.Text = "Làm đề nghị mua hàng";
            this.fld_btnLamDeNghi.Click += new System.EventHandler(this.fld_btnLamDeNghi_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(785, 16);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_dgcMMProductionNormItems);
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(881, 523);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_dgcMMProductionNormItems
            // 
            this.fld_dgcMMProductionNormItems.BOSComment = null;
            this.fld_dgcMMProductionNormItems.BOSDataMember = null;
            this.fld_dgcMMProductionNormItems.BOSDataSource = "MMProductionNormItems";
            this.fld_dgcMMProductionNormItems.BOSDescription = null;
            this.fld_dgcMMProductionNormItems.BOSError = null;
            this.fld_dgcMMProductionNormItems.BOSFieldGroup = null;
            this.fld_dgcMMProductionNormItems.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItems.BOSGridType = null;
            this.fld_dgcMMProductionNormItems.BOSPrivilege = null;
            this.fld_dgcMMProductionNormItems.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionNormItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionNormItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionNormItems.Name = "fld_dgcMMProductionNormItems";
            this.fld_dgcMMProductionNormItems.PrintReport = false;
            this.fld_dgcMMProductionNormItems.Screen = null;
            this.fld_dgcMMProductionNormItems.Size = new System.Drawing.Size(881, 523);
            this.fld_dgcMMProductionNormItems.TabIndex = 9;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosCheckEdit1);
            this.bosPanel2.Controls.Add(this.fld_BtnShowTonKho);
            this.bosPanel2.Controls.Add(this.fld_btnCancel);
            this.bosPanel2.Controls.Add(this.fld_btnLamDeNghi);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel2.Location = new System.Drawing.Point(0, 523);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(881, 55);
            this.bosPanel2.TabIndex = 7;
            // 
            // bosCheckEdit1
            // 
            this.bosCheckEdit1.BOSComment = null;
            this.bosCheckEdit1.BOSDataMember = null;
            this.bosCheckEdit1.BOSDataSource = null;
            this.bosCheckEdit1.BOSDescription = null;
            this.bosCheckEdit1.BOSError = null;
            this.bosCheckEdit1.BOSFieldGroup = null;
            this.bosCheckEdit1.BOSFieldRelation = null;
            this.bosCheckEdit1.BOSPrivilege = null;
            this.bosCheckEdit1.BOSPropertyName = null;
            this.bosCheckEdit1.Location = new System.Drawing.Point(23, 14);
            this.bosCheckEdit1.MenuManager = this.screenToolbar;
            this.bosCheckEdit1.Name = "bosCheckEdit1";
            this.bosCheckEdit1.Properties.Caption = "Chọn tất cả";
            this.bosCheckEdit1.Screen = null;
            this.bosCheckEdit1.Size = new System.Drawing.Size(147, 19);
            this.bosCheckEdit1.TabIndex = 5;
            this.bosCheckEdit1.CheckedChanged += new System.EventHandler(this.bosCheckEdit1_CheckedChanged);
            // 
            // fld_BtnShowTonKho
            // 
            this.fld_BtnShowTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_BtnShowTonKho.BOSComment = null;
            this.fld_BtnShowTonKho.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_BtnShowTonKho.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_BtnShowTonKho.BOSDescription = null;
            this.fld_BtnShowTonKho.BOSError = null;
            this.fld_BtnShowTonKho.BOSFieldGroup = null;
            this.fld_BtnShowTonKho.BOSFieldRelation = null;
            this.fld_BtnShowTonKho.BOSPrivilege = null;
            this.fld_BtnShowTonKho.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_BtnShowTonKho.Location = new System.Drawing.Point(689, 16);
            this.fld_BtnShowTonKho.Name = "fld_BtnShowTonKho";
            this.fld_BtnShowTonKho.Screen = null;
            this.fld_BtnShowTonKho.Size = new System.Drawing.Size(75, 27);
            this.fld_BtnShowTonKho.TabIndex = 4;
            this.fld_BtnShowTonKho.Tag = global::Localization.MESLocalizedResources.String1;
            this.fld_BtnShowTonKho.Text = "Xem tồn kho";
            this.fld_BtnShowTonKho.Click += new System.EventHandler(this.fld_BtnShowTonKho_Click);
            // 
            // guiMMProductionNormItems
            // 
            this.AcceptButton = this.fld_btnLamDeNghi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(881, 578);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel2);
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiMMProductionNormItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách vật tư đặc biệt";
            this.Load += new System.EventHandler(this.guiMMProductionNormItems_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItems)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnLamDeNghi;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSButton fld_BtnShowTonKho;
        private BOSComponent.BOSCheckEdit bosCheckEdit1;
        private MMProductionNormItemsGridControl fld_dgcMMProductionNormItems;
    }
}
namespace BOSERP.Modules.CarcassBOM.UI
{
    partial class guiChooseBOM
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
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lkeFK_MMProductionNormID = new BOSComponent.BOSLookupEdit(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(261, 94);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(86, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.bosPanel1.Controls.Add(this.label1);
            this.bosPanel1.Controls.Add(this.labelControl2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMProductionNormID);
            this.bosPanel1.Controls.Add(this.labelControl1);
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(383, 145);
            this.bosPanel1.TabIndex = 406;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vui lòng xác định bảng định mức để tiếp tục!";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(363, 18);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Sản phẩm có nhiều bảng định mức cho hàng mẫu. ";
            // 
            // fld_lkeFK_MMProductionNormID
            // 
            this.fld_lkeFK_MMProductionNormID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionNormID.BOSAllowDummy = false;
            this.fld_lkeFK_MMProductionNormID.BOSComment = null;
            this.fld_lkeFK_MMProductionNormID.BOSDataMember = "MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.BOSDataSource = "MMProductionNorms";
            this.fld_lkeFK_MMProductionNormID.BOSDescription = null;
            this.fld_lkeFK_MMProductionNormID.BOSError = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionNormID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionNormID.BOSPropertyName = null;
            this.fld_lkeFK_MMProductionNormID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionNormID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionNormID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionNormID.Location = new System.Drawing.Point(116, 65);
            this.fld_lkeFK_MMProductionNormID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMProductionNormID.Name = "fld_lkeFK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionNormID.Properties.ColumnName = null;
            this.fld_lkeFK_MMProductionNormID.Screen = null;
            this.fld_lkeFK_MMProductionNormID.Size = new System.Drawing.Size(231, 20);
            this.fld_lkeFK_MMProductionNormID.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Bảng định mức";
            // 
            // guiChooseBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 145);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiChooseBOM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.guiChooseBOM_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionNormID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
    }
}
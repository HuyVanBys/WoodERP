namespace BOSERP.Modules.Report
{
    partial class guiRP046CurrencyShowDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiRP046CurrencyShowDetail));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_dgcRP046CurrencyACDocumentEntrys = new BOSERP.Modules.Report.RP046CurrencyACDocumentEntrysGridControl();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP046CurrencyACDocumentEntrys)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Controls.Add(this.fld_dgcRP046CurrencyACDocumentEntrys);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(832, 332);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(743, 302);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(86, 27);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đóng";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_dgcRP046CurrencyACDocumentEntrys
            // 
            this.fld_dgcRP046CurrencyACDocumentEntrys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSComment = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSDataMember = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSDescription = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSError = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSFieldGroup = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSFieldRelation = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSGridType = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSPrivilege = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.BOSPropertyName = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.Location = new System.Drawing.Point(0, 3);
            this.fld_dgcRP046CurrencyACDocumentEntrys.MenuManager = this.screenToolbar;
            this.fld_dgcRP046CurrencyACDocumentEntrys.Name = "fld_dgcRP046CurrencyACDocumentEntrys";
            this.fld_dgcRP046CurrencyACDocumentEntrys.PrintReport = false;
            this.fld_dgcRP046CurrencyACDocumentEntrys.RowHandle = 0;
            this.fld_dgcRP046CurrencyACDocumentEntrys.Screen = null;
            this.fld_dgcRP046CurrencyACDocumentEntrys.Size = new System.Drawing.Size(832, 293);
            this.fld_dgcRP046CurrencyACDocumentEntrys.TabIndex = 0;
            // 
            // guiRP046IShowDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 332);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiRP046IShowDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết";
            this.Load += new System.EventHandler(this.guiRP046IShowDetail_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP046CurrencyACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private RP046CurrencyACDocumentEntrysGridControl fld_dgcRP046CurrencyACDocumentEntrys;
        private BOSComponent.BOSButton fld_btnOK;
    }
}
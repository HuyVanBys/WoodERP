namespace BOSERP.Modules.ChangeBOMInformation.UI
{
    partial class guiChooseHistoryLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseHistoryLog));
            this.fld_dgcGEObjectHistorys = new BOSERP.Modules.ChangeBOMInformation.ProfileManagementHistoryGridControl();
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEObjectHistorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcGEObjectHistorys
            // 
            this.fld_dgcGEObjectHistorys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcGEObjectHistorys.BOSComment = null;
            this.fld_dgcGEObjectHistorys.BOSDataMember = null;
            this.fld_dgcGEObjectHistorys.BOSDataSource = "GEObjectHistorys";
            this.fld_dgcGEObjectHistorys.BOSDescription = null;
            this.fld_dgcGEObjectHistorys.BOSError = null;
            this.fld_dgcGEObjectHistorys.BOSFieldGroup = null;
            this.fld_dgcGEObjectHistorys.BOSFieldRelation = null;
            this.fld_dgcGEObjectHistorys.BOSGridType = null;
            this.fld_dgcGEObjectHistorys.BOSPrivilege = null;
            this.fld_dgcGEObjectHistorys.BOSPropertyName = null;
            this.fld_dgcGEObjectHistorys.Location = new System.Drawing.Point(1, 1);
            this.fld_dgcGEObjectHistorys.MenuManager = this.screenToolbar;
            this.fld_dgcGEObjectHistorys.Name = "fld_dgcGEObjectHistorys";
            this.fld_dgcGEObjectHistorys.PrintReport = false;
            this.fld_dgcGEObjectHistorys.Screen = null;
            this.fld_dgcGEObjectHistorys.Size = new System.Drawing.Size(860, 471);
            this.fld_dgcGEObjectHistorys.TabIndex = 1;
            this.fld_dgcGEObjectHistorys.Tag = "DC";
            // 
            // fld_chkSellectAll
            // 
            this.fld_chkSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAll.BOSComment = null;
            this.fld_chkSellectAll.BOSDataMember = null;
            this.fld_chkSellectAll.BOSDataSource = null;
            this.fld_chkSellectAll.BOSDescription = null;
            this.fld_chkSellectAll.BOSError = null;
            this.fld_chkSellectAll.BOSFieldGroup = null;
            this.fld_chkSellectAll.BOSFieldRelation = null;
            this.fld_chkSellectAll.BOSPrivilege = null;
            this.fld_chkSellectAll.BOSPropertyName = null;
            this.fld_chkSellectAll.Location = new System.Drawing.Point(12, 489);
            this.fld_chkSellectAll.MenuManager = this.screenToolbar;
            this.fld_chkSellectAll.Name = "fld_chkSellectAll";
            this.fld_chkSellectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAll.Screen = null;
            this.fld_chkSellectAll.Size = new System.Drawing.Size(144, 19);
            this.fld_chkSellectAll.TabIndex = 6;
            this.fld_chkSellectAll.Tag = "DC";
            this.fld_chkSellectAll.CheckedChanged += new System.EventHandler(this.fld_chkSellectAll_CheckedChanged);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(776, 478);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 8;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnChoose
            // 
            this.fld_btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnChoose.BOSComment = null;
            this.fld_btnChoose.BOSDataMember = null;
            this.fld_btnChoose.BOSDataSource = null;
            this.fld_btnChoose.BOSDescription = null;
            this.fld_btnChoose.BOSError = null;
            this.fld_btnChoose.BOSFieldGroup = null;
            this.fld_btnChoose.BOSFieldRelation = null;
            this.fld_btnChoose.BOSPrivilege = null;
            this.fld_btnChoose.BOSPropertyName = null;
            this.fld_btnChoose.Location = new System.Drawing.Point(695, 478);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 7;
            this.fld_btnChoose.Text = "Chọn";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // guiChooseHistoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnChoose);
            this.Controls.Add(this.fld_chkSellectAll);
            this.Controls.Add(this.fld_dgcGEObjectHistorys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseHistoryLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Lịch sử thay đổi";
            this.Load += new System.EventHandler(this.guiChooseHistoryLog_Load);
            this.Controls.SetChildIndex(this.fld_dgcGEObjectHistorys, 0);
            this.Controls.SetChildIndex(this.fld_chkSellectAll, 0);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEObjectHistorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProfileManagementHistoryGridControl fld_dgcGEObjectHistorys;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnChoose;
    }
}
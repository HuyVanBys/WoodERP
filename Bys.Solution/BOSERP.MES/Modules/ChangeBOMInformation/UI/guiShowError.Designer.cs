namespace BOSERP.Modules.ChangeBOMInformation.UI
{
    partial class guiShowError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowError));
            this.fld_dgcAllocationPlanItems = new BOSERP.Modules.ChangeBOMInformation.ErrorGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItems)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAllocationPlanItems
            // 
            this.fld_dgcAllocationPlanItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItems.BOSComment = null;
            this.fld_dgcAllocationPlanItems.BOSDataMember = null;
            this.fld_dgcAllocationPlanItems.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItems.BOSDescription = null;
            this.fld_dgcAllocationPlanItems.BOSError = null;
            this.fld_dgcAllocationPlanItems.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItems.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItems.BOSGridType = null;
            this.fld_dgcAllocationPlanItems.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItems.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItems.Location = new System.Drawing.Point(1, 37);
            this.fld_dgcAllocationPlanItems.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItems.Name = "fld_dgcAllocationPlanItems";
            this.fld_dgcAllocationPlanItems.PrintReport = false;
            this.fld_dgcAllocationPlanItems.Screen = null;
            this.fld_dgcAllocationPlanItems.Size = new System.Drawing.Size(860, 435);
            this.fld_dgcAllocationPlanItems.TabIndex = 1;
            this.fld_dgcAllocationPlanItems.Tag = "DC";
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
            this.fld_btnChoose.Location = new System.Drawing.Point(786, 478);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 7;
            this.fld_btnChoose.Text = "OK";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(612, 19);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Text = "Không thể làm xác nhận thay đổi - Vui lòng kiểm tra các chứng từ liên quan";
            // 
            // guiShowError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_btnChoose);
            this.Controls.Add(this.fld_dgcAllocationPlanItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiShowError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.guiChooseHistoryLog_Load);
            this.Controls.SetChildIndex(this.fld_dgcAllocationPlanItems, 0);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorGridControl fld_dgcAllocationPlanItems;
        private BOSComponent.BOSButton fld_btnChoose;
        private BOSComponent.BOSLabel bosLabel1;
    }
}
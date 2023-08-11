namespace BOSERP.Modules.OperationDetailPlan
{
    partial class guiSearchEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiSearchEmployee));
            this.fld_dgcMMDetailPlanHumanUnits = new BOSERP.Modules.OperationDetailPlan.ChooseHumanUnitGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDetailPlanHumanUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMDetailPlanHumanUnits
            // 
            this.fld_dgcMMDetailPlanHumanUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMDetailPlanHumanUnits.BOSComment = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSDataMember = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSDataSource = "MMDetailPlanHumanUnits";
            this.fld_dgcMMDetailPlanHumanUnits.BOSDescription = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSError = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSFieldGroup = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSFieldRelation = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSGridType = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSPrivilege = null;
            this.fld_dgcMMDetailPlanHumanUnits.BOSPropertyName = null;
            this.fld_dgcMMDetailPlanHumanUnits.CommodityType = "";
            this.fld_dgcMMDetailPlanHumanUnits.Location = new System.Drawing.Point(5, 1);
            this.fld_dgcMMDetailPlanHumanUnits.MenuManager = this.screenToolbar;
            this.fld_dgcMMDetailPlanHumanUnits.Name = "fld_dgcMMDetailPlanHumanUnits";
            this.fld_dgcMMDetailPlanHumanUnits.PrintReport = false;
            this.fld_dgcMMDetailPlanHumanUnits.Screen = null;
            this.fld_dgcMMDetailPlanHumanUnits.Size = new System.Drawing.Size(879, 540);
            this.fld_dgcMMDetailPlanHumanUnits.TabIndex = 1;
            this.fld_dgcMMDetailPlanHumanUnits.Tag = "DC";
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
            this.fld_btnChoose.Location = new System.Drawing.Point(729, 547);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 2;
            this.fld_btnChoose.Text = "Đồng ý";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
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
            this.fld_chkSellectAll.Location = new System.Drawing.Point(11, 547);
            this.fld_chkSellectAll.MenuManager = this.screenToolbar;
            this.fld_chkSellectAll.Name = "fld_chkSellectAll";
            this.fld_chkSellectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAll.Screen = null;
            this.fld_chkSellectAll.Size = new System.Drawing.Size(144, 19);
            this.fld_chkSellectAll.TabIndex = 4;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(809, 547);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(885, 580);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcMMDetailPlanHumanUnits);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_chkSellectAll);
            this.Controls.Add(this.fld_btnChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiSearchEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Chọn nhân viên";
            this.Load += new System.EventHandler(this.guiSearchEmployee_Load);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.fld_chkSellectAll, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMDetailPlanHumanUnits, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDetailPlanHumanUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnChoose;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private ChooseHumanUnitGridControl fld_dgcMMDetailPlanHumanUnits;
        private BOSComponent.BOSButton fld_btnCancel;
    }
}
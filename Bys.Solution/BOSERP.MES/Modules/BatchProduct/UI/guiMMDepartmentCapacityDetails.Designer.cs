namespace BOSERP.Modules.BatchProduct
{
    partial class guiMMDepartmentCapacityDetails
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
            this.fld_dgcMMDepartmentCapacityDetails = new BOSERP.Modules.BatchProduct.MMDepartmentCapacityDetailsGridControl();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDepartmentCapacityDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMDepartmentCapacityDetails
            // 
            this.fld_dgcMMDepartmentCapacityDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMDepartmentCapacityDetails.BOSComment = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSDataMember = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSDataSource = "MMDepartmentCapacityDetails";
            this.fld_dgcMMDepartmentCapacityDetails.BOSDescription = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSError = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSFieldGroup = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSFieldRelation = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSGridType = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSPrivilege = null;
            this.fld_dgcMMDepartmentCapacityDetails.BOSPropertyName = null;
            this.fld_dgcMMDepartmentCapacityDetails.CommodityType = string.Empty;
            this.fld_dgcMMDepartmentCapacityDetails.Location = new System.Drawing.Point(2, 43);
            this.fld_dgcMMDepartmentCapacityDetails.MenuManager = this.screenToolbar;
            this.fld_dgcMMDepartmentCapacityDetails.Name = "fld_dgcMMDepartmentCapacityDetails";
            this.fld_dgcMMDepartmentCapacityDetails.PrintReport = false;
            this.fld_dgcMMDepartmentCapacityDetails.Screen = null;
            this.fld_dgcMMDepartmentCapacityDetails.Size = new System.Drawing.Size(890, 543);
            this.fld_dgcMMDepartmentCapacityDetails.TabIndex = 6;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(2, 10);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(109, 27);
            this.fld_btnSave.TabIndex = 7;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // guiMMDepartmentCapacityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 587);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_dgcMMDepartmentCapacityDetails);
            this.Name = "guiMMDepartmentCapacityDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết năng suất Phân xưởng theo ngày";
            this.Load += new System.EventHandler(this.guiProductionNormProcessInfos_Load);
            this.Controls.SetChildIndex(this.fld_dgcMMDepartmentCapacityDetails, 0);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDepartmentCapacityDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MMDepartmentCapacityDetailsGridControl fld_dgcMMDepartmentCapacityDetails;
        private BOSComponent.BOSButton fld_btnSave;
    }
}
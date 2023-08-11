namespace BOSERP.Modules.Location
{
    partial class guiAddLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddLocation));
            this.fld_lblName = new BOSComponent.BOSLabel(this.components);
            this.fld_txtGELocationName = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnAddLocation = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_medGELocationDesc = new BOSComponent.BOSMemoEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGELocationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGELocationDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblName
            // 
            this.fld_lblName.BOSComment = null;
            this.fld_lblName.BOSDataMember = null;
            this.fld_lblName.BOSDataSource = null;
            this.fld_lblName.BOSDescription = null;
            this.fld_lblName.BOSError = null;
            this.fld_lblName.BOSFieldGroup = null;
            this.fld_lblName.BOSFieldRelation = null;
            this.fld_lblName.BOSPrivilege = null;
            this.fld_lblName.BOSPropertyName = null;
            this.fld_lblName.Location = new System.Drawing.Point(13, 13);
            this.fld_lblName.Name = "fld_lblName";
            this.fld_lblName.Screen = null;
            this.fld_lblName.Size = new System.Drawing.Size(51, 13);
            this.fld_lblName.TabIndex = 6;
            this.fld_lblName.Text = "Tên địa chỉ";
            // 
            // fld_txtGELocationName
            // 
            this.fld_txtGELocationName.BOSComment = null;
            this.fld_txtGELocationName.BOSDataMember = "GELocationName";
            this.fld_txtGELocationName.BOSDataSource = "GELocations";
            this.fld_txtGELocationName.BOSDescription = null;
            this.fld_txtGELocationName.BOSError = null;
            this.fld_txtGELocationName.BOSFieldGroup = null;
            this.fld_txtGELocationName.BOSFieldRelation = null;
            this.fld_txtGELocationName.BOSPrivilege = null;
            this.fld_txtGELocationName.BOSPropertyName = "Text";
            this.fld_txtGELocationName.Location = new System.Drawing.Point(13, 32);
            this.fld_txtGELocationName.MenuManager = this.screenToolbar;
            this.fld_txtGELocationName.Name = "fld_txtGELocationName";
            this.fld_txtGELocationName.Screen = null;
            this.fld_txtGELocationName.Size = new System.Drawing.Size(383, 20);
            this.fld_txtGELocationName.TabIndex = 1;
            this.fld_txtGELocationName.Tag = "DC";
            // 
            // fld_btnAddLocation
            // 
            this.fld_btnAddLocation.BOSComment = null;
            this.fld_btnAddLocation.BOSDataMember = null;
            this.fld_btnAddLocation.BOSDataSource = null;
            this.fld_btnAddLocation.BOSDescription = null;
            this.fld_btnAddLocation.BOSError = null;
            this.fld_btnAddLocation.BOSFieldGroup = null;
            this.fld_btnAddLocation.BOSFieldRelation = null;
            this.fld_btnAddLocation.BOSPrivilege = null;
            this.fld_btnAddLocation.BOSPropertyName = null;
            this.fld_btnAddLocation.Location = new System.Drawing.Point(238, 157);
            this.fld_btnAddLocation.Name = "fld_btnAddLocation";
            this.fld_btnAddLocation.Screen = null;
            this.fld_btnAddLocation.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddLocation.TabIndex = 3;
            this.fld_btnAddLocation.Text = "Lưu";
            this.fld_btnAddLocation.Click += new System.EventHandler(this.fld_btnAddLocation_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(319, 157);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 58);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(27, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Text = "Mô tả";
            // 
            // fld_medGELocationDesc
            // 
            this.fld_medGELocationDesc.BOSComment = null;
            this.fld_medGELocationDesc.BOSDataMember = "GELocationDesc";
            this.fld_medGELocationDesc.BOSDataSource = "GELocations";
            this.fld_medGELocationDesc.BOSDescription = null;
            this.fld_medGELocationDesc.BOSError = null;
            this.fld_medGELocationDesc.BOSFieldGroup = null;
            this.fld_medGELocationDesc.BOSFieldRelation = null;
            this.fld_medGELocationDesc.BOSPrivilege = null;
            this.fld_medGELocationDesc.BOSPropertyName = "Text";
            this.fld_medGELocationDesc.Location = new System.Drawing.Point(13, 77);
            this.fld_medGELocationDesc.MenuManager = this.screenToolbar;
            this.fld_medGELocationDesc.Name = "fld_medGELocationDesc";
            this.fld_medGELocationDesc.Screen = null;
            this.fld_medGELocationDesc.Size = new System.Drawing.Size(383, 67);
            this.fld_medGELocationDesc.TabIndex = 2;
            this.fld_medGELocationDesc.Tag = "DC";
            // 
            // guiAddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 196);
            this.ControlBox = true;
            this.Controls.Add(this.fld_medGELocationDesc);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblName);
            this.Controls.Add(this.fld_txtGELocationName);
            this.Controls.Add(this.fld_btnAddLocation);
            this.Controls.Add(this.fld_btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/Chỉnh sửa địa chỉ";
            this.Load += new System.EventHandler(this.guiAddLocation_Load);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_btnAddLocation, 0);
            this.Controls.SetChildIndex(this.fld_txtGELocationName, 0);
            this.Controls.SetChildIndex(this.fld_lblName, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_medGELocationDesc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGELocationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGELocationDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel fld_lblName;
        private BOSComponent.BOSTextBox fld_txtGELocationName;
        private BOSComponent.BOSButton fld_btnAddLocation;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSMemoEdit fld_medGELocationDesc;
    }
}
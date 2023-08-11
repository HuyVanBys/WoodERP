namespace BOSERP.Modules.EndingInProgressStatistic
{
    partial class guiClassifyType
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
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeProductionCostInProgressClassifyType = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductionCostInProgressClassifyType.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosLabel1.Location = new System.Drawing.Point(8, 18);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Loại dở dang";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnOK.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnOK.Location = new System.Drawing.Point(121, 66);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 2;
            this.fld_btnOK.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnOK.Text = "Chọn";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
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
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(202, 66);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Thoát";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(44, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(187, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "(Vui lòng chọn loại dở dang khi tạo mới)";
            // 
            // fld_lkeProductionCostInProgressClassifyType
            // 
            this.fld_lkeProductionCostInProgressClassifyType.BOSAllowAddNew = false;
            this.fld_lkeProductionCostInProgressClassifyType.BOSAllowDummy = true;
            this.fld_lkeProductionCostInProgressClassifyType.BOSComment = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSDataMember = "ProductionCostInProgressClassifyType";
            this.fld_lkeProductionCostInProgressClassifyType.BOSDataSource = "ADConfigValues";
            this.fld_lkeProductionCostInProgressClassifyType.BOSDescription = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSError = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSFieldGroup = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSFieldParent = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSFieldRelation = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSPrivilege = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSPropertyName = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSSelectType = null;
            this.fld_lkeProductionCostInProgressClassifyType.BOSSelectTypeValue = null;
            this.fld_lkeProductionCostInProgressClassifyType.CurrentDisplayText = null;
            this.fld_lkeProductionCostInProgressClassifyType.Location = new System.Drawing.Point(84, 15);
            this.fld_lkeProductionCostInProgressClassifyType.MenuManager = this.screenToolbar;
            this.fld_lkeProductionCostInProgressClassifyType.Name = "fld_lkeProductionCostInProgressClassifyType";
            this.fld_lkeProductionCostInProgressClassifyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeProductionCostInProgressClassifyType.Properties.ColumnName = null;
            this.fld_lkeProductionCostInProgressClassifyType.Screen = null;
            this.fld_lkeProductionCostInProgressClassifyType.Size = new System.Drawing.Size(173, 20);
            this.fld_lkeProductionCostInProgressClassifyType.TabIndex = 6;
            // 
            // guiClassifyType
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(285, 99);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeProductionCostInProgressClassifyType);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiClassifyType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn loại dở dang";
            this.Load += new System.EventHandler(this.guiChooseDate_Load);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_lkeProductionCostInProgressClassifyType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductionCostInProgressClassifyType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeProductionCostInProgressClassifyType;
    }
}
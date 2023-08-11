using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREvaluationStandard.UI
{
	/// <summary>
	/// Summary description for DMHRES100
	/// </summary>
	partial class DMHRES100
    {
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private HREvaluationStandardsTreeListControl fld_trlHREvaluationStandards;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREvaluationQuestionID;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private HRStandardQuestionsGridControl fld_dgcHRStandardQuestions;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRStandardQuestions;


		/// <summary>
		/// Clean up any resources being used
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
				if (components != null)
					components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_trlHREvaluationStandards = new BOSERP.Modules.HREvaluationStandard.HREvaluationStandardsTreeListControl();
            this.fld_lkeFK_HREvaluationQuestionID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRStandardQuestions = new BOSERP.Modules.HREvaluationStandard.HRStandardQuestionsGridControl();
            this.fld_dgvHRStandardQuestions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHREvaluationStandards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREvaluationQuestionID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRStandardQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRStandardQuestions)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnSave);
            this.fld_grcGroupControl1.Controls.Add(this.fld_trlHREvaluationStandards);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_HREvaluationQuestionID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRStandardQuestions);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(4, 3);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(1035, 594);
            this.fld_grcGroupControl1.TabIndex = 8;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Danh sách tiêu chí đánh giá";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(952, 559);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 17;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // fld_trlHREvaluationStandards
            // 
            this.fld_trlHREvaluationStandards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlHREvaluationStandards.BOSComment = "";
            this.fld_trlHREvaluationStandards.BOSDataMember = "";
            this.fld_trlHREvaluationStandards.BOSDataSource = "HREvaluationStandards";
            this.fld_trlHREvaluationStandards.BOSDescription = null;
            this.fld_trlHREvaluationStandards.BOSDisplayOption = false;
            this.fld_trlHREvaluationStandards.BOSDisplayRoot = false;
            this.fld_trlHREvaluationStandards.BOSError = null;
            this.fld_trlHREvaluationStandards.BOSFieldGroup = "";
            this.fld_trlHREvaluationStandards.BOSFieldRelation = "";
            this.fld_trlHREvaluationStandards.BOSPrivilege = "";
            this.fld_trlHREvaluationStandards.BOSPropertyName = "";
            this.fld_trlHREvaluationStandards.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlHREvaluationStandards.Location = new System.Drawing.Point(1, 21);
            this.fld_trlHREvaluationStandards.Name = "fld_trlHREvaluationStandards";
            this.fld_trlHREvaluationStandards.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlHREvaluationStandards.OptionsView.ShowColumns = false;
            this.fld_trlHREvaluationStandards.Screen = null;
            this.fld_trlHREvaluationStandards.Size = new System.Drawing.Size(530, 568);
            this.fld_trlHREvaluationStandards.TabIndex = 9;
            this.fld_trlHREvaluationStandards.Tag = "DC";
            // 
            // fld_lkeFK_HREvaluationQuestionID
            // 
            this.fld_lkeFK_HREvaluationQuestionID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_HREvaluationQuestionID.BOSAllowAddNew = true;
            this.fld_lkeFK_HREvaluationQuestionID.BOSAllowDummy = false;
            this.fld_lkeFK_HREvaluationQuestionID.BOSComment = "";
            this.fld_lkeFK_HREvaluationQuestionID.BOSDataMember = "FK_HREvaluationQuestionID";
            this.fld_lkeFK_HREvaluationQuestionID.BOSDataSource = "HRStandardQuestions";
            this.fld_lkeFK_HREvaluationQuestionID.BOSDescription = null;
            this.fld_lkeFK_HREvaluationQuestionID.BOSError = null;
            this.fld_lkeFK_HREvaluationQuestionID.BOSFieldGroup = "";
            this.fld_lkeFK_HREvaluationQuestionID.BOSFieldParent = "";
            this.fld_lkeFK_HREvaluationQuestionID.BOSFieldRelation = "";
            this.fld_lkeFK_HREvaluationQuestionID.BOSPrivilege = "";
            this.fld_lkeFK_HREvaluationQuestionID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREvaluationQuestionID.BOSSelectType = "";
            this.fld_lkeFK_HREvaluationQuestionID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREvaluationQuestionID.CurrentDisplayText = null;
            this.fld_lkeFK_HREvaluationQuestionID.Location = new System.Drawing.Point(592, 29);
            this.fld_lkeFK_HREvaluationQuestionID.Name = "fld_lkeFK_HREvaluationQuestionID";
            this.fld_lkeFK_HREvaluationQuestionID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREvaluationQuestionID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREvaluationQuestionID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREvaluationQuestionID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREvaluationQuestionID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREvaluationQuestionID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREvaluationQuestionDesc", "Desc")});
            this.fld_lkeFK_HREvaluationQuestionID.Properties.DisplayMember = "HREvaluationQuestionDesc";
            this.fld_lkeFK_HREvaluationQuestionID.Properties.NullText = "";
            this.fld_lkeFK_HREvaluationQuestionID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREvaluationQuestionID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREvaluationQuestionID.Properties.ValueMember = "HREvaluationQuestionID";
            this.fld_lkeFK_HREvaluationQuestionID.Screen = null;
            this.fld_lkeFK_HREvaluationQuestionID.Size = new System.Drawing.Size(438, 20);
            this.fld_lkeFK_HREvaluationQuestionID.TabIndex = 14;
            this.fld_lkeFK_HREvaluationQuestionID.Tag = "DC";
            this.fld_lkeFK_HREvaluationQuestionID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_HREvaluationQuestionID_KeyUp);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(537, 32);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(36, 13);
            this.fld_lblLabel5.TabIndex = 15;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Câu hỏi";
            // 
            // fld_dgcHRStandardQuestions
            // 
            this.fld_dgcHRStandardQuestions.AllowDrop = true;
            this.fld_dgcHRStandardQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRStandardQuestions.BOSComment = "";
            this.fld_dgcHRStandardQuestions.BOSDataMember = "";
            this.fld_dgcHRStandardQuestions.BOSDataSource = "HRStandardQuestions";
            this.fld_dgcHRStandardQuestions.BOSDescription = null;
            this.fld_dgcHRStandardQuestions.BOSError = null;
            this.fld_dgcHRStandardQuestions.BOSFieldGroup = "";
            this.fld_dgcHRStandardQuestions.BOSFieldRelation = "";
            this.fld_dgcHRStandardQuestions.BOSGridType = null;
            this.fld_dgcHRStandardQuestions.BOSPrivilege = "";
            this.fld_dgcHRStandardQuestions.BOSPropertyName = "";
            this.fld_dgcHRStandardQuestions.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRStandardQuestions.Location = new System.Drawing.Point(537, 55);
            this.fld_dgcHRStandardQuestions.MainView = this.fld_dgvHRStandardQuestions;
            this.fld_dgcHRStandardQuestions.Name = "fld_dgcHRStandardQuestions";
            this.fld_dgcHRStandardQuestions.Screen = null;
            this.fld_dgcHRStandardQuestions.Size = new System.Drawing.Size(496, 493);
            this.fld_dgcHRStandardQuestions.TabIndex = 16;
            this.fld_dgcHRStandardQuestions.Tag = "DC";
            this.fld_dgcHRStandardQuestions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRStandardQuestions});
            // 
            // fld_dgvHRStandardQuestions
            // 
            this.fld_dgvHRStandardQuestions.GridControl = this.fld_dgcHRStandardQuestions;
            this.fld_dgvHRStandardQuestions.Name = "fld_dgvHRStandardQuestions";
            this.fld_dgvHRStandardQuestions.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1043, 600);
            this.bosPanel1.TabIndex = 10;
            // 
            // DMHRES100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1043, 600);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRES100";
            this.Text = "Tiêu chí đánh giá";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHREvaluationStandards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREvaluationQuestionID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRStandardQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRStandardQuestions)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnSave;
	}
}

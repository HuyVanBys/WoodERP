using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;


namespace BOSERP.Modules.Home
{
    public partial class ICProductProfilesGridControl : BOSGridControl
    {


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = "Thư mục";
            column.FieldName = "Folder";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit SerialNo = new RepositoryItemHyperLinkEdit();
            SerialNo.NullText = "Mở thư mục";
            SerialNo.Click += new EventHandler(SerialNo_Click);
            column.ColumnEdit = SerialNo;
            gridView.Columns.Add(column);

        }
        private void SerialNo_Click(object sender, EventArgs e)
        {

            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductProfilesInfo ICProductProfiles = (ICProductProfilesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (ICProductProfiles != null)
                {
                    try
                    {
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = ICProductProfiles.ICProductProfileLink;
                        prc.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể mở được thư mục hoặc thư mục không tồn tại- Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }



        }





        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["Folder"] != null)
            {
                gridView.Columns["Folder"].Visible = true;
                gridView.Columns["Folder"].VisibleIndex = 13;
            }
            return gridView;
        }




    }
}

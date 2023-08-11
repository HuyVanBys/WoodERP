using BOSCommon.Constants;
using BOSComponent;
using System.ComponentModel;
using System.Data;

namespace BOSERP
{
    public partial class DepGroupItemPopUpLookupEdit : BOSLookupEdit
    {
        [Category("BOS")]
        public int DepartmentID = 0;
        public int DepartmentroomID = 0;
        public DepGroupItemPopUpLookupEdit()
        {
            InitializeComponent();
        }

        public DepGroupItemPopUpLookupEdit(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
        }
        protected override void BOSLookupEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            base.BOSLookupEdit_QueryPopUp(null, null);
            GetCustomeDataDource();
        }
        public void GetCustomeDataDource()
        {
            DataSet ds = new DataSet();
            if (!BOSApp.LookupTables.Contains(TableName.HRDepartmentRoomGroupItemsTableName))
            {
                BOSApp.GetLookupTableData(TableName.HRDepartmentRoomGroupItemsTableName);
            }
            if (BOSApp.LookupTables.Contains(TableName.HRDepartmentRoomGroupItemsTableName))
                ds = (DataSet)BOSApp.LookupTables[TableName.HRDepartmentRoomGroupItemsTableName];
            if (DepartmentID > 0 || DepartmentroomID > 0)
            {

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0].Copy();
                    DataTable dataSource = table.Clone();
                    foreach (DataRow row in table.Rows)
                    {
                        int value = 0;
                        int roomID = 0;
                        if (row["FK_HRDepartmentID"] != null)
                            int.TryParse(row["FK_HRDepartmentID"].ToString(), out value);
                        if (row["FK_HRDepartmentRoomID"] != null)
                            int.TryParse(row["FK_HRDepartmentRoomID"].ToString(), out roomID);
                        if ((DepartmentID == 0 || value == DepartmentID) &&
                            (DepartmentroomID == 0 || roomID == DepartmentroomID))
                        {
                            dataSource.Rows.Add(row.ItemArray);
                        }
                    }
                    if (dataSource != null && dataSource.Rows.Count > 0)
                        this.Properties.DataSource = dataSource;
                    table.Dispose();
                    dataSource.Dispose();
                }
            }
            else
                this.Properties.DataSource = ds.Tables[0];

        }
    }
}

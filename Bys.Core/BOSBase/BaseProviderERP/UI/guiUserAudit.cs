using BOSLib;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiUserAudit : Form
    {
        public guiUserAudit()
        {
            InitializeComponent();
        }

        private void guiUserAudit_Load(object sender, EventArgs e)
        {
            InitUserAuditGridControl();
        }

        private void InitUserAuditGridControl()
        {
            GEUserAuditsController objGEUserAuditsController = new GEUserAuditsController();
            DataSet dsUserAudits = objGEUserAuditsController.GetAllObjects();
            fld_dgcUserAudits.DataSource = dsUserAudits;
            fld_dgcUserAudits.DataMember = dsUserAudits.Tables[0].TableName;
            dsUserAudits.Dispose();
        }
    }
}
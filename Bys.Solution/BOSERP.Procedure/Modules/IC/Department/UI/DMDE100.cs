using DevExpress.XtraTreeList.Nodes;
using System;

namespace BOSERP.Modules.Department.UI
{
    /// <summary>
    /// Summary description for DMDE100
    /// </summary>
    public partial class DMDE100 : BOSERPScreen
    {

        public DMDE100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnButton1_Click(object sender, EventArgs e)
        {
            ((Modules.Department.DepartmentModule)this.Module).AddProductGroupToTreeList();
        }

        private void fld_btnButton_Click(object sender, EventArgs e)
        {

            TreeListNode node = fld_trlICProductGroups.GetSelectedNode();
            if (node != null)
            {
                TreeListNode parentNode = node.ParentNode;
                ICProductGroupsInfo objParentProductGroupsInfo = (ICProductGroupsInfo)fld_trlICProductGroups.GetDataRecordByNode(parentNode);
                ((Modules.Department.DepartmentModule)this.Module).ChangeProductGroupToTreeList(objParentProductGroupsInfo);
            }
        }

        private void fld_btnButton2_Click(object sender, EventArgs e)
        {
            ((Modules.Department.DepartmentModule)this.Module).DeleteProductGroupFromTreeList();
        }

        private void fld_btnButton4_Click(object sender, EventArgs e)
        {
            ((Modules.Department.DepartmentModule)this.Module).ChangeAttribute();
        }

        private void fld_btnButton5_Click(object sender, EventArgs e)
        {
            ((Modules.Department.DepartmentModule)this.Module).DeleteAttribute();
        }
    }
}

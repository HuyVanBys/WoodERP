using BOSComponent;
using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.PaintProcesses.UI
{
    /// <summary>
    /// Summary description for DMPP100
    /// </summary>
    public partial class DMPP100 : BOSERPScreen
    {

        public DMPP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductAttributeColorID_Validated(object sender, EventArgs e)
        {
            if (fld_lkeFK_ICProductAttributeColorID.EditValue != null &&
                fld_lkeFK_ICProductAttributeColorID.OldEditValue != fld_lkeFK_ICProductAttributeColorID.EditValue)
            {
                int ProductAttributeColorID = 0;
                string groupName = string.Empty;
                if (int.TryParse(fld_lkeFK_ICProductAttributeColorID.EditValue.ToString(), out ProductAttributeColorID))
                    groupName = ((PaintProcessesModule)Module).UpdatePaintProcessesColor(ProductAttributeColorID);
                fld_bedFK_ICProductGroupID.Text = groupName;
                fld_bedFK_ICProductGroupID.Refresh();
            }
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((PaintProcessesModule)Module).ShowCategoryTree();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((PaintProcessesModule)Module).SetDefaultDesc();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            int productID = 0;
            int groupID = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (fld_lkeFK_ICProductID.EditValue != null)
                {
                    if (fld_lkeMMPaintProcessesItemGroup.EditValue != null)
                    {
                        int.TryParse(fld_lkeMMPaintProcessesItemGroup.EditValue.ToString(), out groupID);
                    }
                }
                if (int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID))
                    ((PaintProcessesModule)Module).AddItemToPaintProcesesItemList(productID, groupID);
            }
        }

        private void fld_lkeMMPaintProcessesItemGroup_KeyUp(object sender, KeyEventArgs e)
        {
            int productID = 0;
            int groupID = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (fld_lkeFK_ICProductID.EditValue != null)
                {
                    if (fld_lkeMMPaintProcessesItemGroup.EditValue != null)
                    {
                        int.TryParse(fld_lkeMMPaintProcessesItemGroup.EditValue.ToString(), out groupID);
                    }
                    if (int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID))
                        ((PaintProcessesModule)Module).AddItemToPaintProcesesItemList(productID, groupID);
                }
            }
        }

        private void fld_lkeMMPaintProcessesItemGroup_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeMMPaintProcessesItemGroup.Properties.DataSource = ((PaintProcessesModule)Module).InvalidatePaintProcessesGroupLookUp();
            fld_lkeMMPaintProcessesItemGroup.Properties.DisplayMember = "MMPaintProcessesItemGroupName";
            fld_lkeMMPaintProcessesItemGroup.Properties.ValueMember = "MMPaintProcessesItemID";
        }

        private void fld_btnAddGroup_Click(object sender, EventArgs e)
        {
            ((PaintProcessesModule)Module).AddNewGroup();
        }

        private void fld_trlMMPaintProcessesItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PaintProcessesModule)Module).RemoveSelectedItemFromPaintProcessesItem();
            }
        }

        private void fld_trlMMPaintProcessesItems_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null)
            {
                MMPaintProcessesItemsInfo objPaintProcessesItemsInfo = new MMPaintProcessesItemsInfo();
                objPaintProcessesItemsInfo = (MMPaintProcessesItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objPaintProcessesItemsInfo != null)
                {
                    if (e.Column.FieldName == "MMPaintProcessesItemProductQty")
                    {
                        ((PaintProcessesModule)Module).AllocationProductQty(objPaintProcessesItemsInfo);
                    }
                    ((PaintProcessesModule)Module).ChangeItemFromPaintProcessesItemsList(objPaintProcessesItemsInfo);
                }
            }
        }
    }
}

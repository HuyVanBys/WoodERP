using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM.UI
{
    /// <summary>
    /// Summary description for DMCCB100
    /// </summary>
    public partial class DMCCB100 : BOSERPScreen
    {

        public DMCCB100()
        {
            InitializeComponent();
            var data = new[] 
            {
                new {Value = "New", Display = "Tạo mới" },
                new {Value = "Approved", Display = "Đã duyệt"},
                new {Value = "Edit", Display = "Chỉnh sửa"},
                new {Value = "None", Display = "Chưa tạo"},
                new {Value = "Canceled", Display = "Ngưng sử dụng" },
            };

            this.fld_cbbBOMStatus.Properties.DataSource = data;
            this.fld_cbbBOMStatus.Properties.ValueMember = "Value";
            this.fld_cbbBOMStatus.Properties.DisplayMember = "Display";
            this.fld_cbbBOMStatus.EditValue = "New,Approved,None";
            this.fld_cbbBOMStatus.RefreshEditValue();
        }

        public void SearchCarcassList()
        {
            int branchID = fld_lkeBRBranchID.EditValue == null ? 0 : (int)fld_lkeBRBranchID.EditValue;
            string typeGet = fld_cbbBOMType.SelectedIndex == 1 ? CarcassBOMGetType.Carcass.ToString() : CarcassBOMGetType.Color.ToString();
            string statusGet = fld_cbbBOMStatus.EditValue.ToString();
            int productGroupID = fld_lkeICProductGroup.EditValue == null ? 0 : (int)fld_lkeICProductGroup.EditValue;
            int batchProductID = fld_lkeMMBatchProductID.EditValue == null ? 0 : (int)fld_lkeMMBatchProductID.EditValue;
            int productID = fld_lkeProductID.EditValue == null ? 0 : (int)fld_lkeProductID.EditValue;
            string objectAccessKey = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            bool isHasBOM = fld_lkeShowProductHasBOM.Checked;
            bool isNotBOM = fld_lkeShowProductNotBOM.Checked;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);

            ((CarcassBOMModule)Module).SearchCarcass(productID, productGroupID, branchID, typeGet, batchProductID, objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, isHasBOM, isNotBOM, statusGet);
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            SearchCarcassList();
            //*********************will it soon remove*********************//
            //((CarcassBOMModule)Module).GenerateAllProductItemCode();
            //*************************************************************//
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            ((CarcassBOMModule)Module).SaveSemiProductList(false);
        }

        private void fld_btnCreateBOM_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            ((CarcassBOMModule)this.Module).CreateBOM();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            ((CarcassBOMModule)this.Module).SaveProductItemTreeList(true);
        }

        private void fld_btnSaveBOM_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)this.Module).UpdateBOM();
        }

        private void fld_lkeICProductHardwareID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (fld_lkeICProductHardwareID.EditValue != null && int.TryParse(fld_lkeICProductHardwareID.EditValue.ToString(), out productID))
                {
                    ((CarcassBOMModule)Module).AddHardware(productID);
                }
            }
        }

        private void fld_trlMMProductionNormItemsHardware_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CarcassBOMModule)Module).RemoveSelectedItemFromProductionNormItemHardwareList();
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                ((CarcassBOMModule)Module).AddNodeProductionNormItemHardwareList();
            }
        }

        private void fld_btnChangeHardware_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ChangeHardwareAlternative();
        }

        private void bosButton3_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SaveProductionNormItemHardware();
        }

        private void fld_lkeICProductMaterialID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductMaterialID.EditValue.ToString(), out productID))
                {
                    int operationID = 0;
                    if (fld_lkeOperationGeneralMaterial.EditValue != null)
                    {
                        int.TryParse(fld_lkeOperationGeneralMaterial.EditValue.ToString(), out operationID);
                    }

                    ((CarcassBOMModule)Module).AddGeneralMaterial(productID, operationID);
                }
            }
        }

        private void fld_btnUpdateFromConfigMaterial_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).UpdateGeneralMaterialQty();
        }

        private void bosButton4_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SaveGeneralMaterial();
        }

        private void fld_btnCoppyCarcassSemiProduct_Click(object sender, EventArgs e)
        {
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            if (fld_lkeCarcassForCopy.EditValue != null)
            {
                DataRowView dataRow = (DataRowView)fld_lkeCarcassForCopy.GetSelectedDataRow();
                if (dataRow != null)
                    objProductsInfo = (ICProductsInfo)(new ICProductsController()).GetObjectFromDataRow(dataRow.Row);
            }
            int btpID = 0;
            if (fld_lkeChooseSemi.EditValue != null)
            {
                int.TryParse(fld_lkeChooseSemi.EditValue.ToString(), out btpID);
            }
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            ((CarcassBOMModule)Module).CopySemiProduct(objProductsInfo, btpID);
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).BrowseFile(true);
        }

        private void fld_lvImageList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem focusItem = fld_lvImageList.FocusedItem;
            ((CarcassBOMModule)Module).ShowZoomImg(focusItem.Text);
        }

        private void fld_lvImageList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ListViewItem focusItem = fld_lvImageList.FocusedItem;
                ((CarcassBOMModule)Module).DeleteImg(focusItem.Index, imageList1, fld_lvImageList);
            }
        }

        private void fld_btnUploadProposalTemplate_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SaveImage(true);
        }

        private void DMCCB100_Load(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SetReferenceImageControl(imageList1, fld_lvImageList);
        }

        private void DMCCB100_Shown(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SetReferenceImageControl(imageList1, fld_lvImageList);
        }

        private void DMCCB100_Validated(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SetReferenceImageControl(imageList1, fld_lvImageList);
        }

        private void DMCCB100_Activated(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SetReferenceImageControl(imageList1, fld_lvImageList);
        }

        private void bosTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            XtraTabPage page = e.Page;
            try
            {
                ((CarcassBOMModule)Module).SetReferenceImageControl(imageList1, fld_lvImageList);
            }
            catch (Exception)
            {

                return;
            }
            ((CarcassBOMModule)Module).RefeshDataControlWithActivateScreen(page.Controls);
        }

        private void fld_txtCarcassNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchCarcassList();
            }
        }

        private void fld_txtCarcassName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchCarcassList();
            }
        }

        private void fld_trlICProductItems_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;

            if (e.Node != null)
            {
                ICProductItemsInfo objProductionNormItemsInfo = new ICProductItemsInfo();
                objProductionNormItemsInfo = (ICProductItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null
                    && objProductionNormItemsInfo.SubList != null
                    && objProductionNormItemsInfo.SubList.Count > 0)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }

            }
        }

        private void fld_trlProductionNormItemTreeList_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;

            if (e.Node != null && tree != null)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null
                    && objProductionNormItemsInfo.SubList != null
                    && objProductionNormItemsInfo.SubList.Count > 0)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }

            }
        }

        private void bosLookupEdit1_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            if (fld_lkeCarcassForCopy.EditValue != null)
            {
                DataRowView dataRow = (DataRowView)fld_lkeCarcassForCopy.GetSelectedDataRow();
                if (dataRow != null)
                {
                    objProductsInfo = (ICProductsInfo)(new ICProductsController()).GetObjectFromDataRow(dataRow.Row);
                }
            }
            List<ICProductsInfo> semiProductList = ((CarcassBOMModule)Module).GetSemiProductByCarcassID(objProductsInfo.ICProductID, objProductsInfo.MMProductionNormID);
            List<ICProductsInfo> finalList = new List<ICProductsInfo>();
            finalList.Add(new ICProductsInfo());
            finalList.AddRange(semiProductList);
            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = finalList;
        }

        private void fld_lkeCarcassForCopy_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            fld_lkeChooseSemi.EditValue = null;
        }

        private void fld_btnApproveBOM_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ApproveBOM();
        }

        private void fld_btnEditBOM_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).EditBOM();
        }

        private void bosTabControl3_SizeChanged(object sender, EventArgs e)
        {

        }

        private void fld_lkeMMPaintProcessesID_KeyUp(object sender, KeyEventArgs e)
        {
            int paintProcessesID = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (fld_lkeMMPaintProcessesID.EditValue != null && int.TryParse(fld_lkeMMPaintProcessesID.EditValue.ToString(), out paintProcessesID))
                {
                    int operationID = 0;
                    if (fld_lkeMMOperationID.EditValue != null)
                    {
                        int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
                    }
                    ((CarcassBOMModule)Module).AddPaintProcessesToPaintItemsList(paintProcessesID, operationID);
                }
            }
        }

        private void fld_lkeICProductIngredientPaintID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (fld_lkeICProductIngredientPaintID.EditValue != null && int.TryParse(fld_lkeICProductIngredientPaintID.EditValue.ToString(), out productID))
                {
                    int operationID = 0;
                    if (fld_lkeMMOperationID.EditValue != null)
                    {
                        int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
                    }

                    ((CarcassBOMModule)Module).AddPaint(productID, operationID);
                }
            }
        }

        private void fld_trlMMProductionNormItemsPaint_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            BOSTreeListControl treeList = sender as BOSTreeListControl;
            if (treeList == null)
                return;

            if (e.Column.FieldName == "MMProductionNormItemPaint")
            {
                SetQtyChildNode(treeList, e.Node, e.Value);
            }
            else
            {
                ((CarcassBOMModule)Module).ChangeItemFromPaintItemsList();
            }
        }

        public void SetQtyChildNode(BOSTreeListControl treeListControl, TreeListNode treeNode, object value)
        {
            if (treeListControl == null || treeNode == null)
                return;

            MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)treeListControl.GetDataRecordByNode(treeNode);
            if (objProductionNormItemsInfo == null)
                return;

            if (value == null)
                value = 0m;

            decimal paint = (decimal)value;
            decimal paintPerOne = objProductionNormItemsInfo == null ? 0 : objProductionNormItemsInfo.MMProductionNormItemPaintPerOne;
            objProductionNormItemsInfo.MMProductionNormItemPaint = paint;
            objProductionNormItemsInfo.MMProductionNormItemTotalQuantity = paint * paintPerOne;
            objProductionNormItemsInfo.MMProductionNormItemQuantity = paint * paintPerOne;

            treeListControl.BeginUpdate();
            TreeListColumn column = treeListControl.Columns["MMProductionNormItemPaint"];
            treeNode.SetValue(column, value);
            column = treeListControl.Columns["MMProductionNormItemTotalQuantity"];
            if (column != null)
            {
                treeNode.SetValue(column, paint * paintPerOne);
            }
            column = treeListControl.Columns["MMProductionNormItemQuantity"];
            if (column != null)
            {
                treeNode.SetValue(column, paint * paintPerOne);
            }
            treeListControl.EndUpdate();
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode child in treeNode.Nodes)
                SetQtyChildNode(treeListControl, child, value);
        }

        private void fld_trlMMProductionNormItemsPaint_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CarcassBOMModule)Module).RemoveSelectedItemFromProductionNormItemPaintList();
            }
        }

        private void fld_btnSavePaint_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SavePaint();
        }

        private void fld_btnPLDGAddParent_Click(object sender, EventArgs e)
        {
            //if (fld_lkePackaging.EditValue != null)
            //{
            //    string value = fld_lkePackaging.EditValue.ToString();
            //    if (!string.IsNullOrEmpty(value))
            //    {
            //        ((CarcassBOMModule)Module).AddPLDGParent(value);
            //    }
            //}
        }

        private void fld_btnPLDGAddChild_Click(object sender, EventArgs e)
        {
            //if (fld_lkePackaging.EditValue != null)
            //{
            //    string value = fld_lkePackaging.EditValue.ToString();
            //    if (!string.IsNullOrEmpty(value))
            //    {
            //        ((CarcassBOMModule)Module).AddPLDGChild(value);
            //    }
            //}
        }

        private void fld_trlMMProductionNormItemsPackaging_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //  ((CarcassBOMModule)Module).CalculateProductionNormItemPackaging(e.Column.FieldName);

            ((CarcassBOMModule)Module).SetDefaultPackagingDescription();
        }

        private void fld_trlMMProductionNormItemsPackaging_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID"
                || e.Column.FieldName == "FK_ICProdAttPackingMaterialSizeID"
                || e.Column.FieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                if (e.CellValue != null)
                    e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.CellValue.ToString()), "ICProductAttributeValue");
                else
                    e.CellText = "";
            }
        }

        private void fld_trlMMProductionNormItemsPackaging_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //((CarcassBOMModule)Module).RemoveSelectedItemFromProductionNormItemPackagingList();
            }
        }

        private void bosButton6_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SavePackaging();
        }

        private void fld_txtMMProductionNormNo_EditValueChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(fld_txtMMProductionNormNo.Text)
            //    || fld_txtMMProductionNormNo.Text == CarcassBOMModule.NewNo)
            //{
            //    fld_btnApproveBOM.Enabled = false;
            //    fld_btnEditBOM.Enabled = false;
            //}
            //else
            //{
            //    if (fld_lkeMMProductionNormStatus.EditValue.ToString() == ProductionNormStatus.New.ToString())
            //    {
            //        fld_btnApproveBOM.Enabled = true;
            //        fld_btnEditBOM.Enabled = false;
            //    }
            //    else
            //    {
            //        fld_btnApproveBOM.Enabled = false;
            //        fld_btnEditBOM.Enabled = true;

            //    }
            //}

        }

        private void fld_lkeMMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke.OldEditValue != e.Value && e.Value != null)
            {
                ((CarcassBOMModule)Module).ChangePaintOperation(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_lkeMMOperationPackaging_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((CarcassBOMModule)Module).ChangePackagingOperation(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_lkeOperationGeneralMaterial_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((CarcassBOMModule)Module).ChangeGeneralMaterialOperation(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_trlProductionNormItemTreeList_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;

            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            objProductionNormItemsInfo = (MMProductionNormItemsInfo)tree.GetDataRecordByNode(tree.FocusedNode);
            if (objProductionNormItemsInfo == null)
                return;

            ((CarcassBOMModule)Module).ShowProcessSemiProduct(objProductionNormItemsInfo);
        }

        private void fld_btnMainProductProcess_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ShowProcessMainProduct();
        }

        private void fld_lkeMMProductionNormHardwareStatus_EditValueChanged(object sender, EventArgs e)
        {
            RefreshStatusControl();
        }

        private void RefreshStatusControl()
        {
            ((CarcassBOMModule)Module).SetControlEnable();
        }

        private void fld_btnEditMMProductionNormHardwareStatus_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.Hardware.ToString())) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.HardwareStatus.ToString()
                                                                    , Status.Edit.ToString());
        }

        private void fld_btnApproveMMProductionNormHardwareStatus_Click(object sender, EventArgs e)
        {
            if (BOSApp.ShowMessageYesNo("Bạn có chắc chắn đã lưu các thay đổi và muốn duyệt tab chi tiết này?") == DialogResult.No) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.HardwareStatus.ToString()
                                                                   , Status.Approved.ToString());
        }

        private void fld_lkeMMProductionNormPaintStatus_EditValueChanged(object sender, EventArgs e)
        {
            RefreshStatusControl();
        }

        private void fld_btnApproveMMProductionNormPaintStatus_Click(object sender, EventArgs e)
        {
            if (BOSApp.ShowMessageYesNo("Bạn có chắc chắn đã lưu các thay đổi và muốn duyệt tab chi tiết này?") == DialogResult.No) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.PaintStatus.ToString()
                                                                   , Status.Approved.ToString());
        }

        private void fld_btnEditMMProductionNormPaintStatus_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.IngredientPaint.ToString())) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.PaintStatus.ToString()
                                                                    , Status.Edit.ToString());
        }

        private void fld_lkeMMProductionNormPackingMaterialStatus_EditValueChanged(object sender, EventArgs e)
        {
            RefreshStatusControl();
        }

        private void fld_btnApproveMMProductionNormPackingMaterialStatus_Click(object sender, EventArgs e)
        {
            if (BOSApp.ShowMessageYesNo("Bạn có chắc chắn đã lưu các thay đổi và muốn duyệt tab chi tiết này?") == DialogResult.No) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.PackingMaterialStatus.ToString()
                                                                             , Status.Approved.ToString());
        }

        private void fld_btnEditMMProductionNormPackingMaterialStatus_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.IngredientPackaging.ToString())) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.PackingMaterialStatus.ToString()
                                                                    , Status.Edit.ToString());
        }

        private void fld_lkeMMProductionNormGeneralMaterialStatus_EditValueChanged(object sender, EventArgs e)
        {
            RefreshStatusControl();
        }

        private void fld_btnApproveMMProductionNormGeneralMaterialStatus_Click(object sender, EventArgs e)
        {
            if (BOSApp.ShowMessageYesNo("Bạn có chắc chắn đã lưu các thay đổi và muốn duyệt tab chi tiết này?") == DialogResult.No) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.GeneralMaterialStatus.ToString()
                                                                             , Status.Approved.ToString());
        }

        private void fld_btnEditMMProductionNormGeneralMaterialStatus_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.GeneralMaterial.ToString())) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.GeneralMaterialStatus.ToString()
                                                                   , Status.Edit.ToString());
        }

        private void fld_lkeMMProductionNormCarcassProccessStatus_EditValueChanged(object sender, EventArgs e)
        {
            RefreshStatusControl();
        }

        private void fld_lkeMMProductionNormColorProccessStatus_EditValueChanged(object sender, EventArgs e)
        {
            RefreshStatusControl();
        }

        private void fld_btnApproveMMProductionNormCarcassProccessStatus_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.CarcassProccessStatus.ToString()
                                                                             , Status.Approved.ToString());
        }

        private void fld_btnEditMMProductionNormCarcassProccessStatus_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.CarcassProccessStatus.ToString()
                                                                           , Status.Edit.ToString());
        }

        private void fld_btnApproveMMProductionNormColorProccessStatus_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.ColorProccessStatus.ToString()
                                                                           , Status.Approved.ToString());
        }

        private void fld_btnEditMMProductionNormColorProccessStatus_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.ColorProccessStatus.ToString()
                                                                           , Status.Edit.ToString());
        }

        private void fld_lkeMMProductionNormWoodStatus_EditValueChanged(object sender, EventArgs e)
        {
            RefreshStatusControl();
        }

        private void fld_btnApproveMMProductionNormWoodStatus_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.WoodStatus.ToString()
                                                                           , Status.Approved.ToString());
        }

        private void fld_btnEditMMProductionNormWoodStatus_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.SemiProduct.ToString())) return;
            ((CarcassBOMModule)Module).ChangeProductionNormStatus(ProductionNormStatusType.WoodStatus.ToString()
                                                                           , Status.Edit.ToString());
        }

        private void bosButton2_Click_1(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).RefreshHavePaintList();
        }

        private void fld_lkeICProductPackaging_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (fld_lkeICProductPackaging.EditValue != null)
                {
                    if (int.TryParse(fld_lkeICProductPackaging.EditValue.ToString(), out productID))
                    {
                        ((CarcassBOMModule)Module).AddItemToIngredientPackaging(productID);
                    }
                }
            }


        }

        private void bosButton3_Click_1(object sender, EventArgs e)
        {
            ShowFullScreen(fld_tcDetailInfo);
        }

        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom(fld_txtICProductNo.Text, fld_txtICProductName.Text);
            //host.FormBorderStyle = FormBorderStyle.Fixed3D;
            //host.WindowState = FormWindowState.Maximized;
            //host.ShowInTaskbar = true;
            host.MaximizeBox = false;
            host.MinimizeBox = false;
            // Save properties of control
            var loc = ctl.Location;
            var dock = ctl.Dock;
            var parent = ctl.Parent;
            var form = parent;
            var anchor = ctl.Anchor;
            var size = ctl.Size;
            while (!(form is Form)) form = form.Parent;
            // Move control to host
            //ctl.Parent = host;
            host.AddCtrl(ctl);
            ctl.Location = Point.Empty;
            ctl.Dock = DockStyle.Fill;
            // Setup event handler to restore control back to form
            host.FormClosing += delegate
            {
                ctl.Parent = parent;
                ctl.Dock = dock;
                ctl.Location = loc;
                ctl.Anchor = anchor;
                ctl.Size = size;
                form.Refresh();
            };


            // Exit full screen with escape key
            host.KeyPreview = true;
            host.KeyDown += (KeyEventHandler)((s, e) =>
            {
                if (e.KeyCode == Keys.Escape) host.Close();
            });
            // And go full screen
            host.ShowDialog();
            //  form.Hide();
        }

        private void Fld_btnViewDetailPain_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ShowDetailPain();
        }

        private void Fld_lkeMMPaintProcessesID_QueryPopUp(object sender, CancelEventArgs e)
        {
            List<MMPaintProcessessInfo> ProcessList = ((CarcassBOMModule)Module).GetPainProcessByProduct();
            if (ProcessList != null)
            {
                fld_lkeMMPaintProcessesID.Properties.DataSource = ProcessList;
            }
        }

        //private void Fld_btnCoppyCarcassHW_Click(object sender, EventArgs e)
        //{
        //    int productID = 0;
        //    if (fld_CarcassHW.EditValue != null)
        //    {
        //        int.TryParse(fld_CarcassHW.EditValue.ToString(), out productID);
        //    }
        //    if (productID > 0)
        //        ((CarcassBOMModule)Module).CopyHWFromCarcass(productID);
        //}

        //private void Fld_CarcassHW_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    fld_CarcassHW.Properties.DataSource = ((CarcassBOMModule)Module).GetAnotherCarcass(true);
        //}

        //private void Fld_lkeCarcassPackCopy_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    fld_lkeCarcassPackCopy.Properties.DataSource = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.Product.ToString());
        //}

        //private void Fld_btnCopyPackFromCarcass_Click(object sender, EventArgs e)
        //{
        //    int productID = 0;
        //    if (fld_lkeCarcassPackCopy.EditValue != null)
        //    {
        //        int.TryParse(fld_lkeCarcassPackCopy.EditValue.ToString(), out productID);
        //    }
        //    if (productID > 0)
        //        ((CarcassBOMModule)Module).CopyPackFromCarcass(productID);
        //}

        private void Fld_btnCreatePackage_Click(object sender, EventArgs e)
        {
            // ((CarcassBOMModule)Module).ShowGuiPacking(null);
        }

        private void Fld_tcDetailInfo_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            XtraTabPage page = e.Page;
            if (page == null)
                return;

            if (page.Name == "fld_tabPackageNo")
            {
                try
                {
                    ((CarcassBOMModule)Module).ShowPackageNo(true);
                }
                catch (Exception)
                {
                    return;
                }

            }
            else if (page.Name == "tpProductStructure")
            {
                ((CarcassBOMEntities)((CarcassBOMModule)Module).CurrentModuleEntity).InvalidateProductItemTreeList();
            }
        }

        private void Fld_btnSavePackeNo_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SavePackageNo();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).CancelBOM();
        }

        private void fld_lkeBRBranchID_QueryPopUp(object sender, CancelEventArgs e)
        {

        }
        private void fld_btnPrintSemiProduct_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ShowPackageNo(true);
        }
        private void fld_lnkExportBOMTeamplate_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).ExportTemplateBOM();
        }

        private void fld_btnApprovedAll_Click(object sender, EventArgs e)
        {
            if (BOSApp.ShowMessageYesNo("Bạn có chắc chắn đã lưu các thay đổi và muốn duyệt tất cả chi tiết bảng định mức này?") == DialogResult.No) return;
            MMProductionNormsInfo mainObject = ((CarcassBOMModule)Module).GetMainObject();
            if (mainObject.MMProductionNormStatus == Status.Canceled.ToString())
            {
                BOSApp.ShowMessage("BOM ở trạng thái không thể duyệt. Vui lòng kiểm tra lại!");
                return;
            }
            ((CarcassBOMModule)Module).ApprovedAllBOM();
            ((CarcassBOMModule)Module).Invalidate(mainObject.MMProductionNormID);
        }

        private void fld_lkeShowProductHasBOM_CheckedChanged(object sender, EventArgs e)
        {
            if (fld_lkeShowProductHasBOM.Checked)
                fld_lkeShowProductNotBOM.Checked = !fld_lkeShowProductHasBOM.Checked;
        }

        private void fld_lkeShowProductNotBOM_CheckedChanged(object sender, EventArgs e)
        {
            if (fld_lkeShowProductNotBOM.Checked)
                fld_lkeShowProductHasBOM.Checked = !fld_lkeShowProductNotBOM.Checked;
        }

        private void fld_lkeOperationGeneralMaterial_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            UpdateOpoerationDatasource(lookUpEdit);
        }

        private void fld_lkeMMOperationPackaging_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            UpdateOpoerationDatasource(lookUpEdit);
        }
        private void UpdateOpoerationDatasource(LookUpEdit lookUpEdit)
        {
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {

                MMOperationsController control = new MMOperationsController();
                MMAllocationOperationConfigsInfo DefualtAOConfigs = ((CarcassBOMModule)Module).DefualtAOConfigs;
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<MMOperationsInfo> operationList = (List<MMOperationsInfo>)control.GetListFromDataSet(ds);
                    if (operationList != null) operationList = operationList.Where(o =>
                        (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlan.ToString() && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsStock.ToString() && o.MMOperationInOutStockCheck)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanAndStock.ToString() && o.MMOperationInOutStockCheck && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanOrStock.ToString() && (o.MMOperationInOutStockCheck || o.MMOperationIsPlan))
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.AllOperation.ToString())
                        || (DefualtAOConfigs == null)
                        ).ToList();
                    lookUpEdit.Properties.DataSource = operationList;
                }
            }
        }

        private void fld_lkeMMOperationID_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            UpdateOpoerationDatasource(lookUpEdit);
        }

        private void bosButton4_Click_1(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.All.ToString());
        }

        private void Fld_btnPrintVTK_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.GeneralMaterial.ToString());
        }

        private void Fld_btnPrintPLDG_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.IngredientPackaging.ToString());
        }

        private void Fld_btnPrintPaint_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.IngredientPaint.ToString());
        }

        private void Fld_btnHardware_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.Hardware.ToString());
        }

        private void Fld_btnPrintSemiProduct_Click_1(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.SemiProduct.ToString());
        }

        private void fld_btnGetDefualtProcess_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).DefualtProcessOperation();
        }

        private void fld_btnUnCanceled_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).UnCancelBOM();
        }

        private void bosButton5_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_pnlPaint);
        }
        private void fld_btnSaveProfile_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).SaveProfile();
        }

        private void fld_lkeHWBomTemp_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeHWBomTemp.Properties.DataSource = ((CarcassBOMModule)Module).GetAnotherCarcass(false);
        }
        private void fld_btnCopyHW_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.Hardware.ToString())) return;
            int bomID = 0;
            if (fld_lkeHWBomTemp.EditValue != null)
            {
                int.TryParse(fld_lkeHWBomTemp.EditValue.ToString(), out bomID);
            }
            if (bomID > 0)
                ((CarcassBOMModule)Module).CopyHWFromCarcass(bomID);
        }

        private void fld_lkePackTemp_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkePackTemp.Properties.DataSource = ((CarcassBOMModule)Module).GetAnotherCarcass(false);
        }

        private void fld_btnPackCopy_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.IngredientPackaging.ToString())) return;
            int bomID = 0;
            if (fld_lkePackTemp.EditValue != null)
            {
                int.TryParse(fld_lkePackTemp.EditValue.ToString(), out bomID);
            }
            if (bomID > 0)
                ((CarcassBOMModule)Module).CopyPackFromCarcass(bomID);
        }

        private void fld_lkePaintTemp_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkePaintTemp.Properties.DataSource = ((CarcassBOMModule)Module).GetAnotherCarcass(false);
        }

        private void fld_btnCopyPaint_Click(object sender, EventArgs e)
        {
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.IngredientPaint.ToString())) return;
            int bomID = 0;
            if (fld_lkePaintTemp.EditValue != null)
            {
                int.TryParse(fld_lkePaintTemp.EditValue.ToString(), out bomID);
            }
            if (bomID > 0)
                ((CarcassBOMModule)Module).CopyPaintFromCarcass(bomID);
        }

        private void bosButton6_Click_1(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.SemiProduct.ToString(), true);
        }

        private void bosButton7_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.All.ToString(), true);
        }

        private void fld_lkeICProductIdentifyWoodType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((CarcassBOMModule)Module).ChangeWoodType(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductBasicUnitID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((CarcassBOMModule)Module).ChangeMeasureUnit(Convert.ToInt32(e.Value));
            }
        }

        private void bosLookupEdit1_QueryPopUp_1(object sender, CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = ((CarcassBOMModule)Module).GetConfigProductionComplexityType();
            
        }

        private void bosLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((CarcassBOMModule)Module).ChangeConfigProductionComplexityType(e.Value.ToString());
            }
        }

        private void fld_btnUpdatePaint_Click(object sender, EventArgs e)
        {
           // if (!((CarcassBOMModule)Module).GetUsingBOMStatus(ProductionNormItemGroup.IngredientPaint.ToString())) return;
            if (!((CarcassBOMModule)Module).GetBOMBlockStatus(ProductionNormItemGroup.IngredientPaint.ToString())) return;
            ((CarcassBOMModule)Module).SaveSemiProductList(true);
        }

        private void bosButton8_Click(object sender, EventArgs e)
        {
            ((CarcassBOMModule)Module).PrintByType(ProductionNormPrintType.Material.ToString());
        }
    }
}

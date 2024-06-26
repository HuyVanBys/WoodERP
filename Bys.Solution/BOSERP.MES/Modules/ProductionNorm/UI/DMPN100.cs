using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSCommon;
using System.Reflection;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraEditors.Repository;

namespace BOSERP.Modules.ProductionNorm.UI
{
	/// <summary>
	/// Summary description for DMPN100
	/// </summary>
	public partial class DMPN100 : BOSERPScreen
	{

		public DMPN100()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}

        private void fld_btnCreateNewDetail_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).ShowMoreProducts();
        }

        private void fld_trlMMProductionNormItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionNormModule)Module).RemoveSelectedItemFromProductionNormItemList();
            }
        }

        private void fld_btnShowmoreHardware_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).AddHardware();
        }

        private void fld_btnShowMorePackagings_Click(object sender, EventArgs e)
        {
        }

        private void fld_trlMMProductionNormItemsPackaging_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionNormModule)Module).RemoveSelectedItemFromProductionNormItemPackagingList();
            }
        }

        private void fld_trlMMProductionNormItemsHardware_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionNormModule)Module).RemoveSelectedItemFromProductionNormItemHardwareList();
            }
        }

        private void fld_lkeFK_ICProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            int productID = 0;
            if(int.TryParse(e.Value.ToString(), out productID))
            {
                ((ProductionNormModule)Module).ChangeProduct(productID);
            }
        }

        private void fld_lkeMMPaintProcessesID_KeyUp(object sender, KeyEventArgs e)
        {
            int paintProcessesID = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(fld_lkeMMPaintProcessesID.EditValue.ToString(), out paintProcessesID))
                {
                    ((ProductionNormModule)Module).AddPaintProcessesToPaintItemsList(paintProcessesID);
                }
            }
        }

        private void fld_btnShowMorePaint_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).AddNewPaint();
        }

        private void fld_trlMMProductionNormItemsPaint_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionNormModule)Module).RemoveSelectedItemFromProductionNormItemPaintList();
            }
        }
       
        private void fld_trlMMProductionNormItems_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            (entity.Module as ProductionNormModule).GetProductionNormItemDepreciationRate(null);
            (entity.Module as ProductionNormModule).ChangeItemFromProductionNormItemsList();
            (entity.Module as ProductionNormModule).ChangestatusToEdit(ProductType.SemiProduct.ToString());
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItems, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                si.HScrollPos = hScrollPos;
        }

        private void fld_trlMMProductionNormItems_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.MMProductionNormItemIsComponent)
                {
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemICProductName ||
                        e.Column.FieldName == ProductionNormConst.MMProductionNormItemNo ||
                        e.Column.FieldName == ProductionNormConst.MMProductionNormItemICProductWoodType ||
                        e.Column.FieldName == ProductionNormConst.MMProductionNormItemQuantity ||
                         e.Column.FieldName == "MMProductionNormItemSortOrderString" )
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
               
            }
            if (e.Node != null && e.Node.Level == 1)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);
                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.IsError)
                {
                    if (e.Column.FieldName == "MMProductionNormItemMeterial")
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }
                }
            }
        }
        private TreeListHitInfo downHitInfo;
        private void fld_trlMMProductionNormItems_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.MousePoint.X - dragSize.Width / 2,
                    downHitInfo.MousePoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    fld_trlMMProductionNormItems.DoDragDrop(downHitInfo, DragDropEffects.Move);
                }
                else
                {
                    fld_trlMMProductionNormItems.DoDragDrop(downHitInfo, DragDropEffects.Move);
                }
            }
        }

        private void fld_trlMMProductionNormItems_MouseDown(object sender, MouseEventArgs e)
        {
            downHitInfo = null;
            TreeListHitInfo hitInfo = fld_trlMMProductionNormItems.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left)
                downHitInfo = hitInfo;
        }
        private int hScrollPos = 0;
        private void fld_trlMMProductionNormItems_LeftCoordChanged(object sender, EventArgs e)
        {
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItems, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                hScrollPos = si.HScrollPos;
        }

        private void fld_trlMMProductionNormItems_InvalidNodeException(object sender, InvalidNodeExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        private TreeListNode GetDragNode(IDataObject data)
        {
            return data.GetData(typeof(TreeListNode)) as TreeListNode;
        }
        private void fld_trlMMProductionNormItems_DragOver(object sender, DragEventArgs e)
        {
      
            TreeListHitInfo hi = fld_trlMMProductionNormItems.CalcHitInfo(fld_trlMMProductionNormItems.PointToClient(new Point(e.X, e.Y)));
            TreeListNode node = GetDragNode(e.Data);
            if (node == null)
            {
                if (hi.HitInfoType == HitInfoType.Empty || hi.Node != null)
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.Move;
            }
       
        }

        private void fld_trlMMProductionNormItems_DragDrop(object sender, DragEventArgs e)
        {
            TreeListHitInfo hitInfo = fld_trlMMProductionNormItems.CalcHitInfo(fld_trlMMProductionNormItems.PointToClient(new Point(e.X, e.Y)));
            TreeListNode targetNode = hitInfo.Node;
            TreeListNode sourceNode = downHitInfo.Node;

            if (targetNode != null)
            {
                if (((targetNode.Level == 0 && sourceNode.Level == 0) || (targetNode.Level == 1 && sourceNode.Level == 1)) && targetNode.ParentNode == sourceNode.ParentNode)
                {
                    MMProductionNormItemsInfo objProductionNormItemsInfoSource = (MMProductionNormItemsInfo)sourceNode.TreeList.GetDataRecordByNode(sourceNode);
                    MMProductionNormItemsInfo objProductionNormItemsInfoTarget = (MMProductionNormItemsInfo)targetNode.TreeList.GetDataRecordByNode(targetNode);

                    MMProductionNormItemsInfo objProductionNormItemsInfoParent = new MMProductionNormItemsInfo();
                    if (targetNode.ParentNode != null)
                        objProductionNormItemsInfoParent = (MMProductionNormItemsInfo)targetNode.ParentNode.TreeList.GetDataRecordByNode(targetNode.ParentNode);
                    ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
                    int indexTarget = 0;
                    if (objProductionNormItemsInfoParent != null && objProductionNormItemsInfoParent.SubList != null && targetNode.ParentNode != null)
                    {
                        indexTarget = objProductionNormItemsInfoParent.SubList.IndexOf(objProductionNormItemsInfoTarget);
                        objProductionNormItemsInfoParent.SubList.Remove(objProductionNormItemsInfoSource);
                        objProductionNormItemsInfoParent.SubList.Insert(indexTarget, objProductionNormItemsInfoSource);
                    }
                    else
                    {
                        indexTarget = entity.ProductionNormItemList.IndexOf(objProductionNormItemsInfoTarget);
                        entity.ProductionNormItemList.Remove(objProductionNormItemsInfoSource);
                        entity.ProductionNormItemList.Insert(indexTarget, objProductionNormItemsInfoSource);
                    }
                    if (((ProductionNormModule)Module).IsEditable())
                        ((ProductionNormModule)Module).ActionEdit();
                    entity.ProductionNormItemList.TreeListControl.ClearSorting();
                    entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
                    entity.ProductionNormItemList.TreeListControl.ExpandAll();
                    entity.ProductionNormItemList.TreeListControl.BestFitColumns();
                }
            }
            e.Effect = DragDropEffects.None;
            downHitInfo = null;
        }

        private void fld_trlMMProductionNormItems_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == ProductionNormConst.FK_MMFormulaIDPaintA || e.Column.FieldName == ProductionNormConst.FK_MMFormulaIDPaintB)
            {
                if (e.CellValue != null)
                    e.CellText = BOSApp.GetDisplayTextFromCatche("MMFormulas", "MMFormulaID", int.Parse(e.CellValue.ToString()), "MMFormulaName");
                else
                    e.CellText = "";
            }
            if (e.Column.FieldName == "MMProductionNormItemProductWoodType")
            {
                string value = "";
                if (e.CellValue != null)
                    value = e.CellValue.ToString();
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetProductAttributesByGroupAndValue(MatchCodeConst.MatchCodeWoodTypeColumnName, value);
                if (value != string.Empty && objProductAttributesInfo != null)
                    e.CellText = objProductAttributesInfo.ICProductAttributeValue;
                else
                    e.CellText = "";
            }
            if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID" ||
                e.Column.FieldName == "FK_ICProductAttributeQualityID" )
            {
                if (e.CellValue != null)
                    e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.CellValue.ToString()), "ICProductAttributeValue");
                else
                    e.CellText = "";
            }
            if (e.Column.FieldName == ProductionNormConst.FK_ICProductIDReuse || e.Column.FieldName == ProductionNormConst.FK_ICProductIDPack)
            {
                int value = 0;
                if (e.CellValue != null)
                {
                    int.TryParse(e.CellValue.ToString(), out value);
                    e.CellText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", value, "ICProductNo");
                }
                else
                    e.CellText = "";
            }
            if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemWoodBlocks ||
                e.Column.FieldName == ProductionNormConst.MMProductionNormItemTotalWoodConsumable ||
                e.Column.FieldName == ProductionNormConst.MMProductionNormItemMDFBlocks ||
                e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintA ||
                e.Column.FieldName == ProductionNormConst.MMProductionNormItemPaintB ||
                e.Column.FieldName == ProductionNormConst.MMProductionNormItemVeneer )
            {
                double value = 0;
                if (e.CellValue != null)
                    double.TryParse(e.CellValue.ToString(), out value);
                if (value > 0)
                    e.CellText = Math.Round(value, 4).ToString();
                else
                    e.CellText = "-";
            }
        }
        private int hScrollPosHardware = 0;
        private void fld_trlMMProductionNormItemsHardware_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;

            
            (entity.Module as ProductionNormModule).ChangestatusToEdit(ProductType.Hardware.ToString());
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItemsHardware, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                si.HScrollPos = hScrollPosHardware;
        }

        private void fld_trlMMProductionNormItemsHardware_LeftCoordChanged(object sender, EventArgs e)
        {
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItemsHardware, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                hScrollPosHardware = si.HScrollPos;
        }
        private int hScrollPosPackaging = 0;
        private int hScrollPosPaint = 0;
        private void fld_trlMMProductionNormItemsPackaging_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            (entity.Module as ProductionNormModule).ChangestatusToEdit(ProductType.IngredientPackaging.ToString());
            
            (entity.Module as ProductionNormModule).CalculateProductionNormItemPackaging(e.Column.FieldName);
            
            (entity.Module as ProductionNormModule).SetDefaultPackagingDescription();
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItemsPackaging, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                si.HScrollPos = hScrollPosPackaging;
        }

        private void fld_trlMMProductionNormItemsPackaging_LeftCoordChanged(object sender, EventArgs e)
        {
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItemsPackaging, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                hScrollPosPackaging = si.HScrollPos;
        }

        private void fld_trlMMProductionNormItemsPackaging_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            TreeList tree = sender as TreeList;
            if (e.Node != null && e.Node.Level == 0)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)tree.GetDataRecordByNode(e.Node);

                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.MMProductionNormItemIsComponent)
                {
                    if (e.Column.FieldName == ProductionNormConst.MMProductionNormItemICProductName ||
                        e.Column.FieldName == ProductionNormConst.MMProductionNormItemNo ||
                        e.Column.FieldName == ProductionNormConst.MMProductionNormItemQuantity)
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void fld_trlMMProductionNormItemsPaint_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            if (e.Column.FieldName == "MMProductionNormItemPaint")
            {
                (entity.Module as ProductionNormModule).ChangeItemPaint();
            }
            else
            {
                (entity.Module as ProductionNormModule).ChangeItemFromPaintItemsList();
            }
            (entity.Module as ProductionNormModule).ChangestatusToEdit(ProductType.IngredientPaint.ToString());
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItemsPaint, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                si.HScrollPos = hScrollPosPaint;
        }

        private void fld_trlMMProductionNormItemsPaint_LeftCoordChanged(object sender, EventArgs e)
        {
            PropertyInfo pi = typeof(DevExpress.XtraTreeList.TreeList).GetProperty("ScrollInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            DevExpress.XtraTreeList.Scrolling.ScrollInfo si =
                pi.GetValue(fld_trlMMProductionNormItemsPaint, null) as DevExpress.XtraTreeList.Scrolling.ScrollInfo;
            if (si != null)
                hScrollPosPaint = si.HScrollPos;
        }

        private void fld_tabProductionNorm_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Module).CurrentModuleEntity;
            if (fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabSemiProduct" || fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabHardware")
            {

                if (fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabSemiProduct")
                {
                    ((ProductionNormModule)Module).EnableToolbar(ProductionNormConst.ChangestatusSemiProduct);
                    //(entity.Module as ProductionNormModule).InvalidateProductionNormItemByProductType(ProductType.SemiProduct);
                    (entity.Module as ProductionNormModule).InvalidateWoodTreeList();
                }
                else
                {
                    ((ProductionNormModule)Module).EnableToolbar(ProductionNormConst.ChangestatusHardware);
                    (entity.Module as ProductionNormModule).InvalidateProductionNormItemByProductType(ProductType.Hardware);
                }
            }
            else if (fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabPackaging" 
                || fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabPaint" 
                || fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabOperation")
            {

                if (fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabPackaging")
                {
                    ((ProductionNormModule)Module).EnableToolbar(ProductionNormConst.ChangestatusComponent);
                    (entity.Module as ProductionNormModule).InvalidateProductionNormItemByProductType(ProductType.IngredientPackaging);
                }
                else if (fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabOperation")
                {
                    ((ProductionNormModule)Module).EnableToolbar(ProductionNormConst.ChangestatusOperation);
                }
                else
                {
                    ((ProductionNormModule)Module).EnableToolbar(ProductionNormConst.ChangestatusPaint);
                    (entity.Module as ProductionNormModule).InvalidateProductionNormItemByProductType(ProductType.IngredientPaint);
                }
            }
            else if (fld_tabProductionNorm.SelectedTabPage.Name == "fld_tabGeneralMaterial")
            {
                ((ProductionNormModule)Module).EnableToolbar(ProductionNormConst.ChangestatusGeneralMaterial);
                    (entity.Module as ProductionNormModule).InvalidateProductionNormItemByProductType(ProductType.GeneralMaterial);
            }
        }

        private void fld_btnCreateNewDetails_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).GenerateNewDetail();
        }

        private void fld_btnPLDGAddParent_Click(object sender, EventArgs e)
        {
          //string value =  fld_ccbePLDG.EditValue.ToString();
            if (fld_lkePackaging.EditValue != null)
            {
                string value = fld_lkePackaging.EditValue.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    ((ProductionNormModule)Module).AddPLDGParent(value);
                }
            }
        }

        private void fld_btnPLDGAddChild_Click(object sender, EventArgs e)
        {
            //string value = fld_ccbePLDG.EditValue.ToString();
            if (fld_lkePackaging.EditValue != null)
            {
                string value = fld_lkePackaging.EditValue.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    ((ProductionNormModule)Module).AddPLDGChild(value);
                }
            }
        }

        private void fld_lkeICProductHardwareID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductHardwareID.EditValue.ToString(), out productID))
                {
                    ((ProductionNormModule)Module).AddHardware(productID);
                }
            }
        }

        private void fld_lkeICProductIngredientPaintID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductIngredientPaintID.EditValue.ToString(), out productID))
                {
                    ((ProductionNormModule)Module).AddPaint(productID);
                }
            }
        }

        private void fld_btnShowMoreProduct1s_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).ShowProductDetails();
        }

        private void fld_trlMMProductionNormItemsPackaging_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID"
                || e.Column.FieldName == "FK_ICProdAttPackingMaterialSizeID"
                || e.Column.FieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                if (e.CellValue != null)
                    e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes","ICProductAttributeID", int.Parse(e.CellValue.ToString()), "ICProductAttributeValue");
                else
                    e.CellText = "";
            }
        }

        private void fld_ccbePLDG_Popup(object sender, EventArgs e)
        {
            //PopupContainerForm form = (sender as IPopupControl).PopupWindow as PopupContainerForm;
            //EnableIncrementalSearch(form);
        }
        private static void EnableIncrementalSearch(PopupContainerForm form)
        {
            foreach (Control ctrl in form.Controls)
                if (ctrl is PopupContainerControl)
                {
                    foreach (Control c in ctrl.Controls)
                        if (c is CheckedListBoxControl)
                        {
                            (c as CheckedListBoxControl).IncrementalSearch = true;
                            break;
                        }
                    break;
                }
        }

        private void fld_ccbePLDG_KeyDown(object sender, KeyEventArgs e)
        {
            CheckedListBoxControl listBox = sender as CheckedListBoxControl;
            if (listBox == null) return;
            if (e.KeyData == Keys.Space)
            {
                CheckedListBoxItem item = listBox.SelectedItem as CheckedListBoxItem;
                CheckState state = item.CheckState;
                item.CheckState = state == CheckState.Unchecked ? CheckState.Checked : CheckState.Unchecked;
                e.Handled = true;
            }
        }

        private void fld_lkeFK_ICProductID_Popup(object sender, EventArgs e)
        {
           // ((ProductionNormModule)Module).SetLookupProductControlDatasource();
        }
        
        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
        }

        private void fld_lkeICProductHardwareID_Popup(object sender, EventArgs e)
        {
         
        }

        private void fld_btnCreatePicture_Click(object sender, EventArgs e)
        {
            ((Modules.ProductionNorm.ProductionNormModule)this.Module).ChooseProduct();
        }

        private void fld_btnChoossePaintA_Click(object sender, EventArgs e)
        {
            ((Modules.ProductionNorm.ProductionNormModule)this.Module).ChangeItemFromProductionNormItemsList();
        }

        private void fld_btnUpdateFromConfig_Click(object sender, EventArgs e)
        {
            ((Modules.ProductionNorm.ProductionNormModule)this.Module).SaveProductionNormOperationByProductWoodApproved();
        }

        private void fld_btnUpdateWood_Click(object sender, EventArgs e)
        {
            ((Modules.ProductionNorm.ProductionNormModule)this.Module).UpdateMeterialConfig();
        }

        private void fld_ccbePLDG_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            CheckedComboBoxEdit form = sender as CheckedComboBoxEdit;
            //form.Properties.P
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((Modules.ProductionNorm.ProductionNormModule)this.Module).SaveSemiProductList();
        }

        private void fld_lkeICProductMaterialID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductMaterialID.EditValue.ToString(), out productID))
                {
                    ((ProductionNormModule)Module).AddGeneralMaterial(productID);
                }
            }
        }

        private void fld_btnUpdateFromConfigMaterial_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).UpdateGeneralMaterialFromConfig();
        }

        private void fld_btnAddFromProduct_Click(object sender, EventArgs e)
        {
            int productID = 0;
            if (int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID))
            {
                ((ProductionNormModule)Module).repeat = false;
                ((ProductionNormModule)Module).AddPLDGFromNormProduct(productID, false);
            }
        }

        private void fld_btnChangeHardware_Click(object sender, EventArgs e)
        {
            ((ProductionNormModule)Module).ChangeHardwareAlternative();
        }

        private void fld_btnUpdateCarcass_Click(object sender, EventArgs e)
        {
            //((ProductionNormModule)Module).RefeshCarcass = true;
            //((ProductionNormModule)Module).HaveFocusWood = false;
            //((ProductionNormModule)Module).InvalidateProductionNormItemByProductType(ProductType.SemiProduct);

            ((ProductionNormModule)Module).InvalidateWoodTreeList();
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSERP.Modules.ProductionNorm.UI;
using BOSCommon;

using System.Windows.Forms;
using Localization;
using System.Data;
using DevExpress.XtraTreeList;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormModule : BaseTransactionModule
    {

        public bool IsExistPaintProcesses(int paintProcessesID)
        {
            bool isExist = false;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (MMProductionNormItemsInfo pnItem in entity.ProductionNormItemPaintList)
            {
                if (pnItem.SubList != null && pnItem.SubList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo item in pnItem.SubList)
                    {
                        if (item.FK_MMPaintProcessesID == paintProcessesID)
                        {
                            isExist = true;
                            MessageBox.Show("Quy trình sơn : " + item.MMProductionNormItemProductDesc +" đã tồn tại!"
                                            , "Thông báo"
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Information);
                            
                        }
                        break;
                    }
                    if (isExist)
                    {
                        break;
                    }
                }
            }

            return isExist;
        }

        public decimal GetPaintUsed()
        {
            decimal paintUsed = 0;

             ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
             List<int> paintProcessesIDs = new List<int>();
             foreach (MMProductionNormItemsInfo pnItem in entity.ProductionNormItemPaintList)
             {
                 if (pnItem.SubList != null && pnItem.SubList.Count > 0)
                 {
                     foreach (MMProductionNormItemsInfo item in pnItem.SubList)
                     {
                         if (!paintProcessesIDs.Contains(item.FK_MMPaintProcessesID))
                         {
                             paintUsed += item.MMProductionNormItemPaint;
                             paintProcessesIDs.Add(item.FK_MMPaintProcessesID);
                         }
                         break;
                     }
                 }
             }

            return paintUsed;
        }

        public void AddPaintProcessesToPaintItemsList(int paintProcessesID)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMPaintProcessesItemsController objPaintProcessesItemsController = new MMPaintProcessesItemsController();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (paintProcessesID > 0 && !IsExistPaintProcesses(paintProcessesID))
            {
               
                List<MMPaintProcessesItemsInfo> paintProcessItemList = objPaintProcessesItemsController.GetItemForProductionNorm(paintProcessesID);

                if (paintProcessItemList != null && paintProcessItemList.Count > 0)
                {
                    List<MMPaintProcessesItemsInfo> stepList = paintProcessItemList.Where(i => i.MMPaintProcessesItemParentID == 0).ToList();
                    List<MMPaintProcessesItemsInfo> paintList = paintProcessItemList.Where(i => i.MMPaintProcessesItemParentID > 0).ToList();
                    AddPaintProcesses(stepList, paintList);

                    entity.ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
                    entity.ProductionNormItemPaintList.TreeListControl.BestFitColumns();
                    entity.ProductionNormItemPaintList.TreeListControl.ExpandAll();
                }
            
            }
        }
        public void ReDrawPaintTreeList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            List<string> keys = new List<string>();

            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
            {
                if (!keys.Contains(item.MMProductionNormItemProductDesc))
                {
                    keys.Add(item.MMProductionNormItemProductDesc);
                }
            }

            foreach (string key in keys)
            {
                RebuildTreeList(entity.ProductionNormItemPaintList, key);
            }
            if (entity.ProductionNormItemPaintList.TreeListControl.Columns["MMProductionNormItemProductName"] != null)
            {
                entity.ProductionNormItemPaintList.TreeListControl.Columns["MMProductionNormItemProductName"].SortOrder = SortOrder.Ascending;
            }
        }

        public void RebuildTreeList(BOSTreeList treeList, string key)
        {
            if (treeList != null)
            {
                MMProductionNormItemsInfo parent = new MMProductionNormItemsInfo();

                parent.MMProductionNormItemProductName = key;
                parent.SubList = new BOSTreeList();
                int count = treeList.Count;
                for (int index = count - 1; index >= 0; index--)
                {
                    MMProductionNormItemsInfo subItem = treeList[index] as MMProductionNormItemsInfo;
                    if (subItem.MMProductionNormItemProductDesc == key)
                    {
                        parent.MMProductionNormItemPaint = subItem.MMProductionNormItemPaint;
                        parent.SubList.Add(subItem);
                        treeList.RemoveAt(index);
                    }
                }
                treeList.Add(parent);
               
            }
        }


        public void AddPaintProcesses(List<MMPaintProcessesItemsInfo> stepList, List<MMPaintProcessesItemsInfo> paintList)
        {
            if (IsEditable())
                ActionEdit();

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.IngredientPaint.ToString());
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormItemsInfo groupItem = new MMProductionNormItemsInfo();
            groupItem.SubList = new BOSTreeList();
            MMProductionNormItemsInfo productionNormItemStep;
            MMProductionNormItemsInfo productionNormItem;
            List<MMPaintProcessesItemsInfo> paintItemList;
            foreach (MMPaintProcessesItemsInfo step in stepList)
            {
                if (string.IsNullOrEmpty(groupItem.MMProductionNormItemProductName))
                {
                    groupItem.MMProductionNormItemProductName = step.MMPaintProcessesNo + " : " + step.MMPaintProcessesDesc;
                }

                productionNormItemStep = new MMProductionNormItemsInfo();
                productionNormItemStep.FK_MMPaintProcessesID = step.FK_MMPaintProcessesID;
                productionNormItemStep.FK_MMPaintProcessesItemID = step.MMPaintProcessesItemID;
                productionNormItemStep.MMProductionNormItemProductName = step.MMPaintProcessesItemGroupName;
                productionNormItemStep.MMProductionNormItemPaintPerOne = step.MMPaintProcessesItemProductQty;
                productionNormItemStep.MMProductionNormItemProductDesc = step.MMPaintProcessesNo + " : " + step.MMPaintProcessesDesc;
                productionNormItemStep.MMProductionNormItemGroup = ProductType.IngredientPaint.ToString();
                productionNormItemStep.SubList = new BOSTreeList();
                paintItemList = paintList.Where(i => i.MMPaintProcessesItemParentID == step.MMPaintProcessesItemID).ToList();
                if (paintItemList != null && paintItemList.Count > 0)
                {
                    foreach (MMPaintProcessesItemsInfo item in paintItemList)
                    {
                        productionNormItem = new MMProductionNormItemsInfo();
                        SetProductionNormItemInfoFromPaintProcessesesItem(productionNormItem, item);
                        productionNormItemStep.SubList.Add(productionNormItem);
                    }
                }

                groupItem.SubList.Add(productionNormItemStep);
            }
            entity.ProductionNormItemPaintList.Add(groupItem);
        }

        public void SetProductionNormItemInfoFromPaintProcessesesItem(MMProductionNormItemsInfo item, MMPaintProcessesItemsInfo paintItem)
        {
            item.MMProductionNormItemGroup = ProductType.IngredientPaint.ToString();
            item.MMProductionNormItemProductDesc = paintItem.MMPaintProcessesItemDesc;
            item.MMProductionNormItemProductName = paintItem.MMPaintProcessesItemName;
            item.FK_MMPaintProcessesID = paintItem.FK_MMPaintProcessesID;
            item.FK_MMPaintProcessesItemID = paintItem.MMPaintProcessesItemID;
            item.FK_ICProductID = paintItem.FK_ICProductID;
            item.FK_ICProductGroupID = paintItem.FK_ICProductGroupID;
            item.FK_ICDepartmentID = paintItem.FK_ICDepartmentID;
            item.MMProductionNormItemNo = paintItem.MMPaintProcessesItemNo;
            item.MMProductionNormItemProductSupplierNumber = paintItem.ICProductSupplierNumber;
            item.MMProductionNormItemPaintMixRatio = paintItem.MMPaintProcessesItemMixRatio;
            item.MMProductionNormItemUnit = paintItem.ICMeasureUnitName;
            item.FK_ICMeasureUnitID = paintItem.FK_ICMeasureUnitID;
            item.FK_APSupplierID = paintItem.FK_APSupplierID;
            item.MMProductionNormItemProductSupplierName = paintItem.APSupplierName;

            item.MMProductionNormItemPaintPerOne = paintItem.MMPaintProcessesItemProductQty;
           
        }
        public DataTable GetAPSupplier()
        {
            APSuppliersController objSuppliersController = new APSuppliersController();
            DataSet ds = objSuppliersController.GetAllObjects();
            DataTable dt = new DataTable();
            if (ds != null)
                dt = ds.Tables[0];
            return dt;
        }
        public void AddPaintProcessesToPaintItemsList(int productID, decimal qty, int supplierid)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.IngredientPaint.ToString());
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
             MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            ICProductsInfo productObject = new ICProductsInfo();
            if (productID > 0)
            {
                productObject = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (productObject != null)
                {
                   
                    objProductionNormItemsInfo = SetValuePaintItemFromProduct(productObject);
                    objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.IngredientPaint.ToString();
                    UpdateValuePaintItems(objProductionNormItemsInfo);
                    objProductionNormItemsInfo.MMProductionNormItemProductDesc = productObject.ICProductDesc;
                    if (qty > 0)
                    {
                        if (objProductionNormsInfo.MMProductionNormTotalPaint > 0)
                        {
                            objProductionNormItemsInfo.MMProductionNormItemQuantity = qty * objProductionNormsInfo.MMProductionNormTotalPaint;
                        }
                        else
                        {
                            objProductionNormItemsInfo.MMProductionNormItemQuantity = qty;
                        }
                        //TNDLoc [ADD][19/05/2016][Round Paint 4],START
                        objProductionNormItemsInfo.MMProductionNormItemQuantity = Math.Round(objProductionNormItemsInfo.MMProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
                        //TNDLoc [ADD][19/05/2016][Round Paint 4],END
                    }
                   // entity.ProductionNormItemPaintList.Add(objProductionNormItemsInfo);

                }
                if (supplierid > 0)
                {
                    APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierid);
                    if (objSuppliersInfo != null)
                    {
                        objProductionNormItemsInfo.MMProductionNormItemProductSupplierName = objSuppliersInfo.APSupplierName;
                        objProductionNormItemsInfo.FK_APSupplierID = objSuppliersInfo.APSupplierID;
                    }
                }
                entity.ProductionNormItemPaintList.Add(objProductionNormItemsInfo);
            }
            CalculateProductionNormItemPaint();
        }
        public MMProductionNormItemsInfo UpdateValuePaintItems(MMProductionNormItemsInfo objPaintItemsInfo)
        {
            int productQuantity = 1;
            objPaintItemsInfo.MMProductionNormItemTotalQuantity = objPaintItemsInfo.MMProductionNormItemQuantity * productQuantity;
            //TNDLoc [ADD][19/05/2016][Round Paint 4],START
            objPaintItemsInfo.MMProductionNormItemTotalQuantity = Math.Round(objPaintItemsInfo.MMProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
            //TNDLoc [ADD][19/05/2016][Round Paint 4],END
            return objPaintItemsInfo;
        }
        public MMProductionNormItemsInfo SetValuePaintItemFromProduct(ICProductsInfo objProductsInfo)
        {
            MMProductionNormItemsInfo objPaintItemsInfo = new MMProductionNormItemsInfo();
            MMProductionNormItemsInfo objToGetPaintItemsInfo = new MMProductionNormItemsInfo();
            APSuppliersController objSuppliersController = new APSuppliersController();
            APSuppliersInfo objSuppliersInfo = new APSuppliersInfo();
            objPaintItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            objPaintItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objPaintItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objPaintItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objPaintItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICProductName;
            objPaintItemsInfo.MMProductionNormItemNo = objProductsInfo.ICProductNo;
            objPaintItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            //if (objProductsInfo.FK_APSupplierID > 0)
            //{
            //    objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(objProductsInfo.FK_APSupplierID);
            //    if (objSuppliersInfo != null)
            //    {
            //        objPaintItemsInfo.MMProductionNormItemProductSupplierName = objSuppliersInfo.APSupplierName;
            //        objPaintItemsInfo.FK_APSupplierID = objSuppliersInfo.APSupplierID;
            //    }
            //}
            objPaintItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objPaintItemsInfo.MMProductionNormItemNeededTime = DateTime.Now;

            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
            {
                objPaintItemsInfo.MMProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;
                objPaintItemsInfo.FK_ICMeasureUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }



            //set attributes value to Packaging item
            //objPaintItemsInfo.MMProductionNormItemProductAttributeValue1 =
            //       GetDepartmentAttributeValueByDepartmentAttributeValueID(objProductsInfo.ICProductAttribute, AttributeType.DacTinh);
            if (objPaintItemsInfo.SubList == null)
                objPaintItemsInfo.SubList = new BOSTreeList();
            return objPaintItemsInfo;
        }
        public void AddNewPaint()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductList = objProductsController.GetProductForProductionNormPaint();
            guiFind<ICProductsInfo> guiChooseProduct = new guiFind<ICProductsInfo>(TableName.ICProductsTableName, objProductList, this, true);
            guiChooseProduct.Module = this;
            if (guiChooseProduct.ShowDialog() == DialogResult.OK)
            {
                foreach (ICProductsInfo item in guiChooseProduct.SelectedObjects)
                {
                    AddItemToPaintItemsList(item);
                }
            }

        }
        public void AddPaint(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                AddItemToPaintItemsList(objProductsInfo);
            }
        }
        public void AddItemToPaintItemsList(ICProductsInfo productObject)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.IngredientPaint.ToString());
            ICProductsController objProductsController = new ICProductsController();

            if (productObject != null)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = SetValuePaintItemFromProduct(productObject);
                objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.IngredientPaint.ToString();
                UpdateValuePaintItems(objProductionNormItemsInfo);
                entity.ProductionNormItemPaintList.Add(objProductionNormItemsInfo);
                entity.ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemPaintList.TreeListControl.BestFitColumns();
                entity.ProductionNormItemPaintList.TreeListControl.ExpandAll();
            }


        }
        public void RemoveSelectedItemFromProductionNormItemPaintList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.ProductionNormItemPaintList.TreeListControl != null)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = entity.ProductionNormItemPaintList.TreeListControl.GetSelectedNode();
                if (currentNode != null)
                {
                    if (currentNode.Level == 0)
                        entity.ProductionNormItemPaintList.TreeListControl.Nodes.Remove(currentNode);
                    else
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                entity.ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
                CalculateProductionNormItemPaint();
                ChangestatusToEdit(ProductType.IngredientPaint.ToString());
            }

        }


        public decimal CalSurFace(MMProductionNormItemsInfo item)
        {
            return item.MMProductionNormItemProductWidth * item.MMProductionNormItemProductLength;
        }
        public decimal CalLongEdge(MMProductionNormItemsInfo item)
        {
            return item.MMProductionNormItemProductHeight * item.MMProductionNormItemProductLength;
        }
        public decimal CalShortEdge(MMProductionNormItemsInfo item)
        {
            return item.MMProductionNormItemProductHeight * item.MMProductionNormItemProductWidth;
        }

        public void CalculateProductionNormItemPaint()
        {
            #region Controller
            ICProductsController objProductsController = new ICProductsController();

            //Công diện tích sơn
            MMFormulaConfigurationsController objFormulasController = new MMFormulaConfigurationsController();
            #endregion
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (entity.ProductionNormItemPaintList != null && entity.ProductionNormItemPaintList.Count > 0)
            {
                decimal totalPaint = 0;
                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
                {

                    //#region DT Sơn A (M2) - MMProductionNormItemPaintA

                    //MMFormulaConfigurationsInfo objFormulasInfo = new MMFormulaConfigurationsInfo();
                    //decimal surFace = CalSurFace(item);
                    //decimal longEdge = CalLongEdge(item);
                    //decimal shortEdge = CalShortEdge(item);
                    //objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(item.FK_MMFormulaIDPaintA);
                    //if (objFormulasInfo != null)
                    //{
                    //    item.MMProductionNormItemPaintA = (item.MMProductionNormItemQuantity
                    //        * (objFormulasInfo.MMFormulaConfigurationTopQty * surFace
                    //        + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdge
                    //        + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdge)) / 1000000;
                    //}
                    //#endregion

                    //#region DT Sơn B (M2) - MMProductionNormItemPaintB
                    //objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(item.FK_MMFormulaIDPaintB);
                    //if (objFormulasInfo != null)
                    //{
                    //    item.MMProductionNormItemPaintB = (item.MMProductionNormItemQuantity
                    //        * (objFormulasInfo.MMFormulaConfigurationTopQty * surFace
                    //        + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdge
                    //        + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdge)) / 1000000;
                    //}
                    //#endregion

                    #region Số lượng
                    item.MMProductionNormItemTotalQuantity = item.MMProductionNormItemQuantity;
                    //TNDLoc [ADD][19/05/2016][Round Paint 4],START
                    item.MMProductionNormItemTotalQuantity = Math.Round(item.MMProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
                    //TNDLoc [ADD][19/05/2016][Round Paint 4],END
                    #endregion

                    totalPaint += (item.MMProductionNormItemPaintA + item.MMProductionNormItemPaintB);

                    if (item.SubList != null && item.SubList.Count > 0)
                    {
                        foreach (MMProductionNormItemsInfo subItem in entity.ProductionNormItemPaintList)
                        {
                            decimal surFaceSub = CalSurFace(subItem);
                            decimal longEdgeSub = CalLongEdge(subItem);
                            decimal shortEdgeSub = CalShortEdge(subItem);

                            //#region DT Sơn A (M2) - MMProductionNormItemPaintA
                            //objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(subItem.FK_MMFormulaIDPaintA);
                            //if (objFormulasInfo != null)
                            //{
                            //    subItem.MMProductionNormItemPaintA = (subItem.MMProductionNormItemQuantity
                            //        * (objFormulasInfo.MMFormulaConfigurationTopQty * surFaceSub
                            //        + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdgeSub
                            //        + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdgeSub)) / 1000000;
                            //}

                            //#endregion

                            //#region DT Sơn B (M2) - MMProductionNormItemPaintB
                            //objFormulasInfo = (MMFormulaConfigurationsInfo)objFormulasController.GetFormulaConfigByFormulaID(subItem.FK_MMFormulaIDPaintB);
                            //if (objFormulasInfo != null)
                            //{
                            //    subItem.MMProductionNormItemPaintB = (subItem.MMProductionNormItemQuantity
                            //        * (objFormulasInfo.MMFormulaConfigurationTopQty * surFaceSub
                            //        + objFormulasInfo.MMFormulaConfigurationLongEdgeQty * longEdgeSub
                            //        + objFormulasInfo.MMFormulaConfigurationShortEdgeQty * shortEdgeSub)) / 1000000;
                            //}
                            //#endregion

                            #region Số lượng
                            subItem.MMProductionNormItemTotalQuantity = subItem.MMProductionNormItemQuantity;
                            //TNDLoc [ADD][19/05/2016][Round Paint 4],START
                            subItem.MMProductionNormItemTotalQuantity = Math.Round(subItem.MMProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
                            //TNDLoc [ADD][19/05/2016][Round Paint 4],END
                            #endregion

                            totalPaint += (subItem.MMProductionNormItemPaintA + subItem.MMProductionNormItemPaintB);
                        }
                    }
                }

                //DT sơn [MainObject]
              //  objProductionNormsInfo.MMProductionNormTotalPaint = totalPaint;
            }
        }

        public void SetPaintQty(MMProductionNormItemsInfo objPaintItemsInfo, decimal newPaint)
        {
            objPaintItemsInfo.MMProductionNormItemPaint = newPaint;
            objPaintItemsInfo.MMProductionNormItemTotalQuantity = objPaintItemsInfo.MMProductionNormItemPaint * objPaintItemsInfo.MMProductionNormItemPaintPerOne;
            objPaintItemsInfo.MMProductionNormItemQuantity = objPaintItemsInfo.MMProductionNormItemPaint * objPaintItemsInfo.MMProductionNormItemPaintPerOne;
            objPaintItemsInfo.MMProductionNormItemTotalQuantity = Math.Round(objPaintItemsInfo.MMProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
            objPaintItemsInfo.MMProductionNormItemQuantity = Math.Round(objPaintItemsInfo.MMProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
            if (objPaintItemsInfo.SubList != null && objPaintItemsInfo.SubList.Count > 0)
            {
                foreach (MMProductionNormItemsInfo item in objPaintItemsInfo.SubList)
                {
                    SetPaintQty(item, newPaint);
                }
            }
        }

        public bool IsPaintProcessNode()
        { 
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo objPaintItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemPaintList.CurrentObject;
            if (objPaintItemsInfo != null && objPaintItemsInfo.MMProductionNormItemGroup != ProductType.IngredientPaint.ToString())
            {
                return true;
            }
            return false;
        }

        public void ChangeItemPaint()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo objPaintItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemPaintList.CurrentObject;
            if (objPaintItemsInfo != null 
                && objPaintItemsInfo.MMProductionNormItemGroup != ProductType.IngredientPaint.ToString())
            {
                SetPaintQty(objPaintItemsInfo, objPaintItemsInfo.MMProductionNormItemPaint);
                entity.ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemPaintList.TreeListControl.BestFitColumns();
                entity.ProductionNormItemPaintList.TreeListControl.ExpandAll();
            }


        }

        public void ChangeItemFromPaintItemsList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsInfo objPaintItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemPaintList.CurrentObject;
            if (objPaintItemsInfo != null)
            {
                UpdateValuePaintItems(objPaintItemsInfo);
                CalculateProductionNormItemPaint();
            }

            
        }
    }
}

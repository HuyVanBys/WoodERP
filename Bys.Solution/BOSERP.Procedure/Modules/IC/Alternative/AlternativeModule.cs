﻿using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Alternative
{
    #region AlternativeModule
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:AlternativeModule
    //Created Date:Monday, March 01, 2010
    //-----------------------------------------------------------

    public class AlternativeModule : BaseModuleERP
    {
        #region Declare Constant

        #endregion

        #region Variables
        #endregion
        public ICAlternativeMaterialsGridControl fld_dgcMaterialAlternatives;
        public ICAlternativeProductsGridControl fld_dgcICProductAlternatives;
        public AlternativeModule()
        {
            Name = "Alternative";
            CurrentModuleEntity = new AlternativeEntities();
            CurrentModuleEntity.Module = this;

            InitializeModule();
            fld_dgcMaterialAlternatives = (ICAlternativeMaterialsGridControl)Controls["fld_dgcMaterialAlternatives"];
            fld_dgcICProductAlternatives = (ICAlternativeProductsGridControl)Controls["fld_dgcICProductAlternatives"];
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }
        public void DeleteItemFromProductAlternativesList(ICProductAlternativesInfo item)
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            int index = entity.ProductAlternativeList.IndexOf(item);
            if (index >= 0)
            {
                entity.ProductAlternativeList.RemoveAt(index);
                if (entity.ProductAlternativeList.GridControl != null)
                {
                    entity.ProductAlternativeList.GridControl.RefreshDataSource();
                }
            }

        }
        public void DeleteItemFromMaterialAlternativesList(ICProductAlternativesInfo item)
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            int index = entity.MaterialAlternativeList.IndexOf(item);
            if (index >= 0)
            {
                entity.MaterialAlternativeList.RemoveAt(index);
                if (entity.MaterialAlternativeList.GridControl != null)
                {
                    entity.MaterialAlternativeList.GridControl.RefreshDataSource();
                }
                fld_dgcMaterialAlternatives.RefreshDataSource();
            }

        }
        public void SearchSemiProduct(string carcassNo, string carcassName, string semiNo, string semiName
            , decimal heigth, decimal width, decimal length, int batchProductID, int productGroupID, int collectionID, int productMaterialID, int customerID)
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            ICProductsController productCtrl = new ICProductsController();
            List<ICProductsInfo> carcassList = productCtrl.GetSemiProductFromProductAndSomeCriteria(carcassNo, carcassName, semiNo, semiName
                                                            , heigth, width, length, batchProductID
                                                            , productGroupID, collectionID, productMaterialID, customerID);

            entity.ProductList.Invalidate(carcassList);
            if (entity.ProductList.GridControl != null)
            {
                GridView gridView = entity.ProductList.GridControl.MainView as GridView;
                if (gridView != null) gridView.ExpandAllGroups();
                entity.ProductList.GridControl.RefreshDataSource();
            }

        }
        public void SearchMaterialProduct(string productNo, string productName, string productType
           , decimal heigth, decimal width, decimal length, int productGroupID, int productMaterialID)
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            ICProductsController productCtrl = new ICProductsController();
            List<ICProductsInfo> materialList = productCtrl.GetMaterialProductBySomeCriteria(productNo, productName, productType
                                                            , heigth, width, length
                                                            , productGroupID, productMaterialID);

            entity.MaterialList.Invalidate(materialList);
            if (entity.MaterialList.GridControl != null)
            {
                GridView gridView = entity.MaterialList.GridControl.MainView as GridView;
                if (gridView != null) gridView.ExpandAllGroups();
                entity.MaterialList.GridControl.RefreshDataSource();
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICProductsInfo obj = (ICProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (obj != null)
                    {
                        ShowDetailAlternative(obj, true);
                    }
                }
            }
            fld_dgcMaterialAlternatives.RefreshDataSource();
        }
        public void ShowDetailAlternative(ICProductsInfo obj, bool isMaterial)
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            List<ICProductAlternativesInfo> listAlter = new List<ICProductAlternativesInfo>();
            ICProductAlternativesController iCProductAlternativesController = new ICProductAlternativesController();

            DataSet ds = iCProductAlternativesController.GetAllDataByForeignColumn("FK_ICProductAlternativeParentID", obj.ICProductID);
            if (ds != null && ds.Tables.Count > 0)
            {
                if (isMaterial)
                {
                    entity.MaterialAlternativeList.Invalidate(ds);
                    entity.MaterialAlternativeList.ForEach(a =>
                    {
                        ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(a.FK_ICProductAlternativeChildID);
                        if (found != null)
                        {
                            a.ICProductAlternativeName = found.ICProductName;
                            a.ICProductHeight = found.ICProductHeight;
                            a.ICProductWidth = found.ICProductWidth;
                            a.ICProductLength = found.ICProductLength;
                        }
                    });
                    if (entity.MaterialAlternativeList.GridControl != null)
                    {
                        if (entity.MaterialAlternativeList.GridControl.Columns["ICProductAlternativeQty"] != null)
                            entity.MaterialAlternativeList.GridControl.Columns["ICProductAlternativeQty"].OptionsColumn.AllowEdit = true;
                        entity.MaterialAlternativeList.GridControl.RefreshDataSource();
                    }
                    if (fld_dgcMaterialAlternatives != null)
                        fld_dgcMaterialAlternatives.RefreshDataSource();
                }
                else
                {
                    entity.ProductAlternativeList.Invalidate(ds);
                    entity.ProductAlternativeList.ForEach(a =>
                    {
                        ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(a.FK_ICProductAlternativeChildID);
                        if (found != null)
                        {
                            a.ICProductAlternativeName = found.ICProductName;
                            a.ICProductHeight = found.ICProductHeight;
                            a.ICProductWidth = found.ICProductWidth;
                            a.ICProductLength = found.ICProductLength;
                        }
                    });
                    if (entity.ProductAlternativeList.GridControl != null)
                    {
                        if (entity.ProductAlternativeList.GridControl.Columns["ICProductAlternativeQty"] != null)
                            entity.ProductAlternativeList.GridControl.Columns["ICProductAlternativeQty"].OptionsColumn.AllowEdit = true;
                        entity.ProductAlternativeList.GridControl.RefreshDataSource();
                    }
                    if (fld_dgcICProductAlternatives != null)
                        fld_dgcICProductAlternatives.RefreshDataSource();
                }

            }
        }
        public void SaveAlternative()
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            entity.ProductAlternativeList.SaveItemObjects();
            BOSApp.ShowMessage("Lưu thành công!");
        }
        public void SaveMaterialAlternative()
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            entity.MaterialAlternativeList.SaveItemObjects();
            BOSApp.ShowMessage("Lưu thành công!");
        }
        public void ShowListAlternative(ICProductsInfo obj, bool isMaterial)
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            List<ICProductAlternativesInfo> listAlter = new List<ICProductAlternativesInfo>();
            if (isMaterial)
            {
                listAlter = entity.MaterialAlternativeList.Where(x => x.FK_ICProductAlternativeParentID == obj.ICProductID).ToList();
            }
            else
            {
                listAlter = entity.ProductAlternativeList.Where(x => x.FK_ICProductAlternativeParentID == obj.ICProductID).ToList();
            }

            List<ICProductsInfo> products = new List<ICProductsInfo>();
            if (listAlter != null && listAlter.Any())
            {
                foreach (ICProductAlternativesInfo item in listAlter)
                {
                    ICProductsInfo found = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductAlternativeChildID);
                    if (found != null)
                    {
                        found.ICProductItemQty = item.ICProductAlternativeQty;
                        products.Add(found);
                    }
                }
            }
            if (isMaterial)
            {
                guiAddMaterial guiFind = new guiAddMaterial(products);
                guiFind.fld_dgcICProductAlternatives.DataSource = entity.MaterialAlternativeList;
                guiFind.Module = this;
                guiFind.Parent = obj;
                if (guiFind.ShowDialog() != DialogResult.OK)
                {
                    ShowDetailAlternative(obj, isMaterial);
                    return;
                }
            }
            else
            {
                guiAddProduct guiFind = new guiAddProduct(products);
                guiFind.fld_dgcICProductAlternatives.DataSource = entity.ProductAlternativeList;
                guiFind.Module = this;
                guiFind.Parent = obj;
                if (guiFind.ShowDialog() != DialogResult.OK)
                {
                    ShowDetailAlternative(obj, isMaterial);
                    return;
                }
            }

            if (isMaterial)
            {
                //if (entity.MaterialAlternativeList.Count() > 0)
                //    entity.MaterialAlternativeList.SaveItemObjects();

                //if (entity.MaterialAlternativeList.GridControl != null)
                //{
                //    if (entity.MaterialAlternativeList.GridControl.Columns["ICProductAlternativeQty"] != null)
                //        entity.MaterialAlternativeList.GridControl.Columns["ICProductAlternativeQty"].OptionsColumn.AllowEdit = true;
                //    entity.MaterialAlternativeList.GridControl.RefreshDataSource();
                //}
                if (fld_dgcMaterialAlternatives != null)
                {
                    entity.MaterialAlternativeList.GridControl = fld_dgcMaterialAlternatives;
                    fld_dgcMaterialAlternatives.RefreshDataSource();
                }

            }
            else
            {
                //if (entity.ProductAlternativeList.Count() > 0)
                //    entity.ProductAlternativeList.SaveItemObjects();
                if (fld_dgcICProductAlternatives != null)
                {
                    entity.ProductAlternativeList.GridControl = fld_dgcICProductAlternatives;
                    fld_dgcICProductAlternatives.RefreshDataSource();
                }
            }

            //ShowDetailAlternative(obj, isMaterial);
        }
        public void ChangeSelectAlternative(ICProductsInfo item, bool select, ICProductsInfo parent, bool isMaterial)
        {
            AlternativeEntities entity = (AlternativeEntities)CurrentModuleEntity;
            ICProductAlternativesInfo objProductAlternativesInfo = new ICProductAlternativesInfo();
            objProductAlternativesInfo = ToProductAlternativesInfo(item, parent);
            if (select)
            {
                if (isMaterial)
                {
                    if (!entity.MaterialAlternativeList.Any(s => s.FK_ICProductAlternativeChildID == item.ICProductID))
                        entity.MaterialAlternativeList.Add(objProductAlternativesInfo);
                    else
                        entity.MaterialAlternativeList.ForEach(o =>
                        {
                            if (o.FK_ICProductAlternativeChildID == item.ICProductID)
                            {
                                o.ICProductAlternativeName = item.ICProductName;
                                o.ICProductHeight = item.ICProductHeight;
                                o.ICProductWidth = item.ICProductWidth;
                                o.ICProductLength = item.ICProductLength;
                                if (item.ICProductItemQty == 0) item.ICProductItemQty = 1;
                                o.ICProductAlternativeQty = item.ICProductItemQty;
                            }
                        });
                }
                else
                {
                    if (!entity.ProductAlternativeList.Any(s => s.FK_ICProductAlternativeChildID == item.ICProductID))
                        entity.ProductAlternativeList.Add(objProductAlternativesInfo);
                    else
                        entity.ProductAlternativeList.ForEach(o =>
                        {
                            if (o.FK_ICProductAlternativeChildID == item.ICProductID)
                            {
                                o.ICProductAlternativeName = item.ICProductName;
                                o.ICProductHeight = item.ICProductHeight;
                                o.ICProductWidth = item.ICProductWidth;
                                o.ICProductLength = item.ICProductLength;
                                if (item.ICProductItemQty == 0) item.ICProductItemQty = 1;
                                o.ICProductAlternativeQty = item.ICProductItemQty;
                            }
                        });
                }
            }
            else
            {
                objProductAlternativesInfo = isMaterial ? entity.MaterialAlternativeList.Where(o => o.FK_ICProductAlternativeChildID == item.ICProductID).FirstOrDefault()
                    : entity.ProductAlternativeList.Where(o => o.FK_ICProductAlternativeChildID == item.ICProductID).FirstOrDefault();
                if (objProductAlternativesInfo != null)
                {
                    if (isMaterial)
                    {
                        int index = entity.MaterialAlternativeList.IndexOf(objProductAlternativesInfo);
                        if (index >= 0)
                            entity.MaterialAlternativeList.RemoveAt(index);
                        if (entity.MaterialAlternativeList.GridControl != null)
                        {
                            entity.MaterialAlternativeList.GridControl.RefreshDataSource();
                        }
                    }
                    else
                    {
                        int index = entity.ProductAlternativeList.IndexOf(objProductAlternativesInfo);
                        if (index >= 0)
                            entity.ProductAlternativeList.RemoveAt(index);
                        if (entity.ProductAlternativeList.GridControl != null)
                        {
                            entity.ProductAlternativeList.GridControl.RefreshDataSource();
                        }
                    }
                }
            }

        }
        private ICProductAlternativesInfo ToProductAlternativesInfo(ICProductsInfo objProductsInfo, ICProductsInfo parent)
        {
            return new ICProductAlternativesInfo()
            {
                ICProductAlternativeDesc = objProductsInfo.ICProductDesc,
                ICProductAlternativeName = objProductsInfo.ICProductName,
                FK_ICProductAlternativeChildID = objProductsInfo.ICProductID,
                FK_ICProductAlternativeParentID = parent.ICProductID,
                FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID,
                ICProductAlternativeQty = objProductsInfo.ICProductItemQty == 0 ? 1 : objProductsInfo.ICProductItemQty,
                ICProductHeight = objProductsInfo.ICProductHeight,
                ICProductWidth = objProductsInfo.ICProductWidth,
                ICProductLength = objProductsInfo.ICProductLength
            };
        }
    }
    #endregion
}
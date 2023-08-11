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
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using Microsoft.Office.Interop.Excel;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormModule : BaseTransactionModule
    {
        #region Constant
        string[] AlphaString =  {"1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26"
                                            ,"27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52"};
        public const String cstNewObjectText = "***NEW***";
        public const string ProductionNormViewTabEditName = "fld_tabProductionNorm";
        public const string CreateNewDetailButtonEditName = "fld_btnCreateNewDetails";
        public const string ProductionNormItemOperationsGridControlName = "fld_dgcProductionNormItemOperations";
        // public const string OperationApproveButtonName = "fld_btnOperationApprove";
        public const string LookUpProductName = "fld_lkeFK_ICProductID";
        public const string PLDGCheckedComboBoxEditName = "fld_ccbePLDG";
        public const string PLDGLookupEditName = "fld_lkePackaging";
        public const string IngredientPaintLookupEditName = "fld_lkeICProductIngredientPaintID";
        public const string HardwareLookupEditName = "fld_lkeICProductHardwareID";
        public const string MaterialLookupEditName = "fld_lkeICProductMaterialID";
        public const string tabSemiProduct = "fld_tabSemiProduct";
        public const string tabHardware = "fld_tabHardware";
        public const string tabPaint = "fld_tabPaint";
        public const string tabPackaging = "fld_tabPackaging";
        public const string tabOperation = "fld_tabOperation";
        public const string tabGeneralMaterial = "fld_tabGeneralMaterial";

        public bool isInit = false;

        #endregion
        #region Public properties
        BOSTabControl ProductionNormViewTabEdit;
        BOSButton CreateNewDetailEdit;
        //List<MMProductionNormItemsInfo> OldToCheckEditProductionNormItemsList { get; set; }
        List<MMProductionNormItemsInfo> OldPaintItemsList { get; set; }
        //List<MMProductionNormItemsInfo> OldToCheckEditHardwareItemsList { get; set; }
        //List<MMProductionNormItemsInfo> OldToCheckEditPackagingItemsList { get; set; }
        //List<MMProductionNormItemsInfo> OldToCheckEditPaintItemsList { get; set; }
        List<MMProductionNormItemsInfo> OldPackagingItemsList { get; set; }
        List<MMProductionNormItemsInfo> ProductionNormItemOriginalList { get; set; }
        List<MMProductionNormItemsInfo> ProductionNormItemOriginalBackupList { get; set; }
        List<MMProductionNormItemsInfo> ProductionNormItemHardwareOriginalList { get; set; }
        List<MMProductionNormItemsInfo> ProductionNormItemPackagingOriginalList { get; set; }
        List<MMProductionNormItemsInfo> ProductionNormItemPaintOriginalList { get; set; }
        List<GEObjectHistoryInfo> objectHistories;
        MMProductionNormsInfo OldProductionNormsInfo { get; set; }
        public BOSGridControl ProductionNormItemOperationsGridControl;
        // public BOSButton OperationApproveButton;
        public BOSLookupEdit LookUpProductControl;
        public bool IsCreateDetail = false;
        public BOSLookupEdit PLDGLookupEdit;
        public BOSLookupEdit DMSonLookupEdit;
        public BOSLookupEdit IngredientPaintLookupEditControl;
        public BOSLookupEdit HardwareLookupEditControl;
        public BOSLookupEdit MaterialProductLookupEditControl;
        public MMProductionNormsInfo ProductionNormBackUpObject = new MMProductionNormsInfo();
        BOSSearchResultsGridControl ProductionNormResultsGridControl;

        ProductionNormEntities entity;
        MMProductionNormsInfo mainObject;

        #region Improve Speed
        public bool HaveFocusWood = false;
        public bool HaveFocusHardware = false;
        public bool HaveFocusGeneralMaterial = false;
        public bool HaveFocusPaint = false;
        public bool HaveFocusPackaging = false;
        public bool IsDupplicate = false;
        public bool IsCoppyVersion = false;
        public int OldProductID = 0;
        public int OriProductID = 0;
        #endregion

        #endregion
        public ProductionNormModule()
        {
            Name = "ProductionNorm";
            CurrentModuleEntity = new ProductionNormEntities();
            CurrentModuleEntity.Module = this;
            isInit = true;
            InitializeModule();
            ProductionNormViewTabEdit = (BOSTabControl)Controls[ProductionNormViewTabEditName];
            CreateNewDetailEdit = (BOSButton)Controls[CreateNewDetailButtonEditName];
            ProductionNormResultsGridControl = (BOSSearchResultsGridControl)Controls["fld_dgcMMProductionNorms"];
            #region History
            ProductionNormItemOriginalList = new List<MMProductionNormItemsInfo>();
            ProductionNormItemOriginalBackupList = new List<MMProductionNormItemsInfo>();
            ProductionNormItemHardwareOriginalList = new List<MMProductionNormItemsInfo>();
            ProductionNormItemPackagingOriginalList = new List<MMProductionNormItemsInfo>();
            ProductionNormItemPaintOriginalList = new List<MMProductionNormItemsInfo>();
            #endregion

            ProductionNormItemOperationsGridControl = (BOSGridControl)Controls[ProductionNormItemOperationsGridControlName];
            LookUpProductControl = (BOSLookupEdit)Controls[LookUpProductName];
            LookUpProductControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(LookUpProductControl_QueryPopUp);
            PLDGLookupEdit = (BOSLookupEdit)Controls[PLDGLookupEditName];
            PLDGLookupEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(PLDGCheckedComboBoxEdit_QueryPopUp);
            IngredientPaintLookupEditControl = (BOSLookupEdit)Controls[IngredientPaintLookupEditName];
            IngredientPaintLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(IngredientPaintLookupEditControl_QueryPopUp);
            HardwareLookupEditControl = (BOSLookupEdit)Controls[HardwareLookupEditName];
            HardwareLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(HardwareLookupEditControl_QueryPopUp);
            DMSonLookupEdit = (BOSLookupEdit)Controls["fld_lkeMMPaintProcessesID"];
            DMSonLookupEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(DMSonLookupEdit_QueryPopUp);

            MaterialProductLookupEditControl = (BOSLookupEdit)Controls[MaterialLookupEditName];
            MaterialProductLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(MaterialProductLookupEditControl_QueryPopUp);

            entity = (ProductionNormEntities)CurrentModuleEntity;
            mainObject = (MMProductionNormsInfo)entity.MainObject;
            BOSApp.InvalidateProductList();
        }



        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            if (isInit)
            {
                DataSet dsr = new DataSet();
                dsr.Tables.Add(new System.Data.DataTable());
                dsr.Tables[0].Columns.Add("MMProductionNormID", typeof(int));
                dsr.Tables[0].Columns.Add("FK_ICProductID", typeof(int));
                dsr.Tables[0].Columns.Add("FK_HREmployeeID", typeof(int));
                dsr.Tables[0].Columns.Add("MMProductionNormNo", typeof(string));
                dsr.Tables[0].Columns.Add("MMProductionNormName", typeof(string));
                dsr.Tables[0].Columns.Add("MMProductionNormDesc", typeof(string));
                dsr.Tables[0].Columns.Add("MMProductionNormWoodStatus", typeof(string));
                dsr.Tables[0].Columns.Add("MMProductionNormHardwareStatus", typeof(string));
                dsr.Tables[0].Columns.Add("MMProductionNormPaintStatus", typeof(string));
                dsr.Tables[0].Columns.Add("MMProductionNormReferrence", typeof(string));
                dsr.Tables[0].Columns.Add("MMProductionNormPackingMaterialStatus", typeof(string));
                isInit = false;
                return dsr;
            }

            MMProductionNormsController productionNormController = new MMProductionNormsController();
            MMProductionNormsInfo searchObject = (MMProductionNormsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = productionNormController.GetProductionNormsBySomeCriteria(
                                                                        searchObject.MMProductionNormNo,
                                                                        searchObject.MMProductionNormName,
                                                                        searchObject.FK_ICProductID,
                                                                        searchObject.MMProductionNormOldProductNo,
                                                                        searchObject.MMProductionNormVersion,
                                                                        searchObject.MMProductionNormPromulgateDateFrom,
                                                                        searchObject.MMProductionNormPromulgateDateTo);


            return ds;
        }

        public override void ActionCancel()
        {
            if (IsCoppyVersion)
            {
                IsCoppyVersion = false;
            }
            base.ActionCancel();

        }
        void LookUpProductControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (LookUpProductControl != null)
            {
                //LookUpProductControl.Properties.DataSource = SetLookupProductControlDatasource();
                BOSApp.InvalidateProductList();
                List<ICProductsForViewInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Product.ToString()
                    || p.ICProductType == ProductType.SemiProduct.ToString()).ToList();
                dataList.Insert(0, new ICProductsForViewInfo());
                LookUpProductControl.Properties.DataSource = dataList;
            }
        }
        void DMSonLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSApp.ResetLookupTablesUpdatedDate(TableName.MMPaintProcessesTableName, 1);
            DMSonLookupEdit.InvalidateDataSourceToLookupEdit();
        }
        void PLDGCheckedComboBoxEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //IngredientPackaging;Verneer;ArtificialBoard;Equipment
            BOSApp.InvalidateProductList();
            List<ICProductsForViewInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.IngredientPackaging.ToString()
                                                                                || p.ICProductType == ProductType.Verneer.ToString()
                                                                                || p.ICProductType == ProductType.ArtificialBoard.ToString()
                                                                                || p.ICProductType == ProductType.Equipment.ToString()).ToList();
            dataList.Insert(0, new ICProductsForViewInfo());
            PLDGLookupEdit.Properties.DataSource = dataList;
        }

        void IngredientPaintLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //IngredientPaint;Equipment
            BOSApp.InvalidateProductList();
            List<ICProductsForViewInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.IngredientPaint.ToString()
                || p.ICProductType == ProductType.Equipment.ToString()).ToList();
            dataList.Insert(0, new ICProductsForViewInfo());
            IngredientPaintLookupEditControl.Properties.DataSource = dataList;
        }

        void HardwareLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Hardware;Equipment
            BOSApp.InvalidateProductList();
            List<ICProductsForViewInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Hardware.ToString()
                || p.ICProductType == ProductType.Equipment.ToString()).ToList();
            dataList.Insert(0, new ICProductsForViewInfo());
            HardwareLookupEditControl.Properties.DataSource = dataList;
        }
        void MaterialProductLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSApp.InvalidateProductList();
            List<ICProductsForViewInfo> dataList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Hardware.ToString()
                                                                                || p.ICProductType == ProductType.IngredientPackaging.ToString()
                                                                                || p.ICProductType == ProductType.Verneer.ToString()
                                                                                || p.ICProductType == ProductType.ArtificialBoard.ToString()
                                                                                 || p.ICProductType == ProductType.IngredientPaint.ToString()
                                                                                || p.ICProductType == ProductType.Equipment.ToString()).ToList();
            dataList.Insert(0, new ICProductsForViewInfo());
            MaterialProductLookupEditControl.Properties.DataSource = dataList;
        }
        public override void Invalidate(int iObjectID)
        {
            if (!IsCoppyVersion)
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                base.Invalidate(iObjectID);
                CreateNewDetailEdit.Visible = false;
                //ChangeProductionNormGroup(iObjectID);
                //if (entity.ProductionNormItemList != null)
                //{
                //    entity.ProductionNormItemList.Clear();
                //    RefreshTreeView(entity.ProductionNormItemList);
                //}
                if (entity.ProductionNormItemHardwareList != null)
                {
                    entity.ProductionNormItemHardwareList.Clear();
                    RefreshTreeView(entity.ProductionNormItemHardwareList);
                }
                if (entity.ProductionNormItemPackagingList != null)
                {
                    entity.ProductionNormItemPackagingList.Clear();
                    RefreshTreeView(entity.ProductionNormItemPackagingList);
                }
                if (entity.ProductionNormItemPaintList != null)
                {
                    entity.ProductionNormItemPaintList.Clear();
                    RefreshTreeView(entity.ProductionNormItemPaintList);
                }
                HaveFocusHardware = false;
                HaveFocusPackaging = false;
                HaveFocusPaint = false;
                HaveFocusWood = false;
                HaveFocusGeneralMaterial = false;
                IsDupplicate = false;

                IsCoppyVersion = false;

                if (ProductionNormItemHardwareOriginalList != null)
                    ProductionNormItemHardwareOriginalList.Clear();

                if (ProductionNormItemPaintOriginalList != null)
                    ProductionNormItemPaintOriginalList.Clear();

                if (ProductionNormItemPackagingOriginalList != null)
                    ProductionNormItemPackagingOriginalList.Clear();

                if (ProductionNormItemOriginalList != null)
                    ProductionNormItemOriginalList.Clear();

                EnableProductionNormType();


                OldProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject.Clone();
                OldProductID = OldProductionNormsInfo.FK_ICProductID;
                InvalidateProfileManagement();
                //InvalidateOperationBandedGrid();

            }
        }
        public void RefreshTreeView(BOSTreeList treeList)
        {
            if (treeList != null && treeList.TreeListControl != null)
            {
                treeList.TreeListControl.RefreshDataSource();
                treeList.TreeListControl.ExpandAll();
                treeList.TreeListControl.BestFitColumns();
                if (treeList.TreeListControl.Columns["MMProductionNormItemNo"] != null)
                    treeList.TreeListControl.Columns["MMProductionNormItemNo"].SortOrder = SortOrder.Ascending;
            }
        }
        public void InvalidateOperationBandedGrid()
        {
            if (!HaveFocusWood)
            {
                //InvalidateProductionNormItemByProductType(ProductType.SemiProduct);
                this.InvalidateWoodTreeList();
            }

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (objProductionNormsInfo.MMProductionNormWoodStatus != MMProductionNormStatus.New.ToString())
            {
                if (ProductionNormItemOperationsGridControl != null)
                {
                    ProductionNormItemOperationsGridControl.MainView = GenerateBandedGridView();

                    InitOperationDataRow(entity.ProductionNormItemOperationList);
                    ProductionNormItemOperationsGridControl.DataSource = OperationDataTable;
                    ProductionNormItemOperationsGridControl.RefreshDataSource();

                }
            }
            else
            {
                if (ProductionNormItemOperationsGridControl != null)
                {
                    OperationDataTable = new System.Data.DataTable();
                    ProductionNormItemOperationsGridControl.DataSource = OperationDataTable;
                    ProductionNormItemOperationsGridControl.RefreshDataSource();
                }
            }
        }
        public void EnableProductionNormType()
        {
            string configValues = string.Empty;
            if (ProductionNormViewTabEdit.SelectedTabPage.Name == tabSemiProduct)
            {
                EnableToolbar(ProductionNormConst.ChangestatusSemiProduct);
                //InvalidateProductionNormItemByProductType(ProductType.SemiProduct);
                InvalidateWoodTreeList();
            }
            else if (ProductionNormViewTabEdit.SelectedTabPage.Name == tabHardware)
            {
                EnableToolbar(ProductionNormConst.ChangestatusHardware);
                InvalidateProductionNormItemByProductType(ProductType.Hardware);
            }
            else if (ProductionNormViewTabEdit.SelectedTabPage.Name == tabPackaging)
            {
                EnableToolbar(ProductionNormConst.ChangestatusComponent);
                InvalidateProductionNormItemByProductType(ProductType.IngredientPackaging);
            }
            else if (ProductionNormViewTabEdit.SelectedTabPage.Name == tabPaint)
            {
                EnableToolbar(ProductionNormConst.ChangestatusPaint);
                InvalidateProductionNormItemByProductType(ProductType.IngredientPaint);
            }
            else if (ProductionNormViewTabEdit.SelectedTabPage.Name == tabOperation)
            {
                EnableToolbar(ProductionNormConst.ChangestatusOperation);
            }
            else if (ProductionNormViewTabEdit.SelectedTabPage.Name == tabGeneralMaterial)
            {
                EnableToolbar(ProductionNormConst.ChangestatusGeneralMaterial);
                InvalidateProductionNormItemByProductType(ProductType.GeneralMaterial);
            }
        }

        private bool CheckProductionNormItemNo(string pattern, IBOSTreeList treeList)
        {
            if (treeList != null)
            {
                foreach (MMProductionNormItemsInfo item in treeList)
                {
                    string[] itemNos = item.MMProductionNormItemNo.Split('.');
                    if (itemNos.Length > 0)
                    {
                        if (itemNos[0] != pattern)
                        {
                            return false;
                        }
                    }
                    if (item.TheNumberOfChild != 0)
                        CheckProductionNormItemNo(pattern, item.SubList);
                }
            }
            return true;
        }

        public bool CheckValidItemNo()
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
            if (objProductsInfo != null)
            {
                string[] mainProductNos = objProductsInfo.ICProductNo.Split('.');
                string mainProductNo = string.Empty;
                if (mainProductNos.Length > 0)
                {
                    mainProductNo = mainProductNos[0];
                }

                #region Wood
                bool isValid = CheckProductionNormItemNo(mainProductNo, entity.ProductionNormItemList);
                return isValid;
                //foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                //{
                //    string[] itemNos = item.MMProductionNormItemNo.Split('.');
                //    if (itemNos.Length > 0)
                //    {
                //        if (itemNos[0] != mainProductNo)
                //        {
                //            return false;
                //        }
                //    }

                //    if (item.SubList != null && item.SubList.Count > 0)
                //    {
                //        foreach (MMProductionNormItemsInfo subItem in item.SubList)
                //        {
                //            string[] subItemNos = subItem.MMProductionNormItemNo.Split('.');
                //            if (subItemNos.Length > 0)
                //            {
                //                if (subItemNos[0] != mainProductNo)
                //                {
                //                    return false;
                //                }
                //            }
                //        }
                //    }
                //}
                //}
                #endregion
            }
            else
            {
                return false;
            }
        }
        public override void ActionEdit()
        {
            base.ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject;
            OriProductID = objProductionNormsInfo.FK_ICProductID;
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)ProductionNormResultsGridControl.MainView;
            gridView.Columns.View.ActiveFilter.Clear();
            ProductionNormItemOriginalBackupList.Clear();
            ProductionNormItemOriginalList.ForEach(o => { ProductionNormItemOriginalBackupList.Add(o); });

        }
        public override void ActionNew()
        {
            base.ActionNew();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.ProductionNormItemList != null)
            {
                entity.ProductionNormItemList.Clear();
                ProductionNormItemOriginalList.Clear();
                ProductionNormItemOriginalBackupList.Clear();
                RefreshTreeView(entity.ProductionNormItemList);
            }
            if (entity.ProductionNormItemHardwareList != null)
            {
                entity.ProductionNormItemHardwareList.Clear();
                ProductionNormItemHardwareOriginalList.Clear();
                RefreshTreeView(entity.ProductionNormItemHardwareList);
            }
            if (entity.ProductionNormItemPackagingList != null)
            {
                entity.ProductionNormItemPackagingList.Clear();
                ProductionNormItemPackagingOriginalList.Clear();
                RefreshTreeView(entity.ProductionNormItemPackagingList);
            }
            if (entity.ProductionNormItemPaintList != null)
            {
                entity.ProductionNormItemPaintList.Clear();
                ProductionNormItemPaintOriginalList.Clear();
                RefreshTreeView(entity.ProductionNormItemPaintList);
            }
            //[NUThao] [Del] [Comment out for LV's version] [12-11-2018][Start]
            //guiNormTemplateItemInfos guiForm = new guiNormTemplateItemInfos();
            //guiForm.Module = this;
            //guiForm.WindowState = FormWindowState.Normal;
            ////guiForm.FormBorderStyle = FormBorderStyle.None;
            //guiForm.WindowState = FormWindowState.Maximized;
            //if (guiForm.ShowDialog() == DialogResult.OK)
            //{
            //    MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            //    objProductionNormsInfo.FK_ICProductID = guiForm.FK_ICProductID;
            //    ChangeProduct(objProductionNormsInfo.FK_ICProductID);
            //}
            //[NUThao] [Del] [Comment out for LV's version] [12-11-2018][End]
            mainObject = (MMProductionNormsInfo)entity.MainObject;
            OriProductID = 0;
        }

        public void GetEditHistory(IBOSTreeList treeList)
        {
            List<GEHistoryDetailsInfo> historyDetails;
            GEObjectHistoryInfo objGEObjectHistoryInfo;

            if (treeList != null && objectHistories != null)
            {
                foreach (MMProductionNormItemsInfo productionNormItem in treeList)
                {
                    if (productionNormItem.BackupObject != null)
                    {
                        historyDetails = CurrentModuleEntity.GetHistoryDetails(productionNormItem.BackupObject, productionNormItem);
                        if (historyDetails != null && historyDetails.Count != 0)
                        {
                            objGEObjectHistoryInfo = new GEObjectHistoryInfo();
                            //Get Object History Info
                            objGEObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            objGEObjectHistoryInfo.ADUserName = BOSApp.CurrentUser;
                            objGEObjectHistoryInfo.GEObjectHistoryAction = "Change";
                            objGEObjectHistoryInfo.GEObjectHistoryObjectID = productionNormItem.MMProductionNormItemID;
                            objGEObjectHistoryInfo.GEObjectHistoryObjectName = ProductionNormConst.ProductionNormItem;
                            objGEObjectHistoryInfo.GEObjectHistoryObjectNumber = productionNormItem.MMProductionNormItemNo;

                            if (objGEObjectHistoryInfo.HistoryDetails == null)
                                objGEObjectHistoryInfo.HistoryDetails = new List<GEHistoryDetailsInfo>();
                            objGEObjectHistoryInfo.HistoryDetails.AddRange(historyDetails);
                            if (objectHistories == null)
                                objectHistories = new List<GEObjectHistoryInfo>();
                            objectHistories.Add(objGEObjectHistoryInfo);
                        }
                    }

                    //if (productionNormItem.TheNumberOfChild != 0)
                    if (productionNormItem.SubList != null && productionNormItem.SubList.Count > 0)
                        GetEditHistory(productionNormItem.SubList);
                }
            }
        }


        public void GetDeleteHistory(IBOSTreeList treeList, List<MMProductionNormItemsInfo> originalList)
        {
            GEHistoryDetailsInfo objHistoryDetailsInfo;
            GEObjectHistoryInfo objGEObjectHistoryInfo;
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> currentProductionNormItems = new List<MMProductionNormItemsInfo>();

            if (treeList != null && originalList != null)
            {
                treeList.ConvertToList(currentProductionNormItems);

                List<MMProductionNormItemsInfo> deletedObjects = originalList.Where(item =>
                                                                            !currentProductionNormItems.Any(item1 =>
                                                                                item1.MMProductionNormItemID == item.MMProductionNormItemID)).ToList();

                if (deletedObjects != null)
                {
                    foreach (MMProductionNormItemsInfo productionNormItem in deletedObjects)
                    {
                        objGEObjectHistoryInfo = new GEObjectHistoryInfo();
                        //Get Object History Info
                        objGEObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objGEObjectHistoryInfo.ADUserName = BOSApp.CurrentUser;
                        objGEObjectHistoryInfo.GEObjectHistoryAction = "Delete";
                        productionNormItem.AAStatus = "Delete";
                        productionNormItem.AAUpdatedUser = BOSApp.CurrentUser;
                        objGEObjectHistoryInfo.GEObjectHistoryObjectID = productionNormItem.MMProductionNormItemID;
                        objGEObjectHistoryInfo.GEObjectHistoryObjectName = ProductionNormConst.ProductionNormItem;
                        objGEObjectHistoryInfo.GEObjectHistoryObjectNumber = productionNormItem.MMProductionNormItemNo;


                        string tableName = BOSUtil.GetTableNameFromBusinessObject(productionNormItem);
                        objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                        objHistoryDetailsInfo.GEHistoryDetailTableName = tableName;
                        objHistoryDetailsInfo.GEHistoryDetailColumnName = "MMProductionNormItemNo";
                        objHistoryDetailsInfo.GEHistoryDetailOldValue = productionNormItem.MMProductionNormItemProductName;
                        objHistoryDetailsInfo.GEHistoryDetailNewValue = string.Empty;

                        if (objGEObjectHistoryInfo.HistoryDetails == null)
                            objGEObjectHistoryInfo.HistoryDetails = new List<GEHistoryDetailsInfo>();
                        objGEObjectHistoryInfo.HistoryDetails.Add(objHistoryDetailsInfo);

                        if (objectHistories == null)
                            objectHistories = new List<GEObjectHistoryInfo>();
                        objectHistories.Add(objGEObjectHistoryInfo);
                        objProductionNormItemsController.UpdateObject(productionNormItem);
                    }
                }
            }
        }

        public void GetCreateHistory(IBOSTreeList treeList)
        {
            GEHistoryDetailsInfo objHistoryDetailsInfo;
            GEObjectHistoryInfo objGEObjectHistoryInfo;

            if (treeList != null && objectHistories != null)
            {
                foreach (MMProductionNormItemsInfo productionNormItem in treeList)
                {
                    if (productionNormItem.BackupObject == null)
                    {
                        objGEObjectHistoryInfo = new GEObjectHistoryInfo();
                        //Get Object History Info
                        objGEObjectHistoryInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objGEObjectHistoryInfo.ADUserName = BOSApp.CurrentUser;
                        objGEObjectHistoryInfo.GEObjectHistoryAction = "New";
                        objGEObjectHistoryInfo.GEObjectHistoryObjectID = productionNormItem.MMProductionNormItemID;
                        objGEObjectHistoryInfo.GEObjectHistoryObjectName = ProductionNormConst.ProductionNormItem;
                        objGEObjectHistoryInfo.GEObjectHistoryObjectNumber = productionNormItem.MMProductionNormItemNo;


                        string tableName = BOSUtil.GetTableNameFromBusinessObject(productionNormItem);
                        objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                        objHistoryDetailsInfo.GEHistoryDetailTableName = tableName;
                        objHistoryDetailsInfo.GEHistoryDetailColumnName = "MMProductionNormItemNo";
                        objHistoryDetailsInfo.GEHistoryDetailOldValue = string.Empty;
                        objHistoryDetailsInfo.GEHistoryDetailNewValue = productionNormItem.MMProductionNormItemProductName;

                        if (objGEObjectHistoryInfo.HistoryDetails == null)
                            objGEObjectHistoryInfo.HistoryDetails = new List<GEHistoryDetailsInfo>();
                        objGEObjectHistoryInfo.HistoryDetails.Add(objHistoryDetailsInfo);

                        if (objectHistories == null)
                            objectHistories = new List<GEObjectHistoryInfo>();
                        objectHistories.Add(objGEObjectHistoryInfo);
                    }

                    if (productionNormItem.SubList != null && productionNormItem.SubList.Count > 0)
                        GetCreateHistory(productionNormItem.SubList);
                }
            }
        }
        public bool isValidPaintQty()
        {
            bool isValid = true;

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject;
            StringBuilder sb = new StringBuilder();
            foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
            {
                //sumPaint += item.MMProductionNormItemPaint;
                if (item.MMProductionNormItemPaint > objProductionNormsInfo.MMProductionNormTotalPaint)
                {
                    if (sb.Length != 0)
                        sb.Append(Environment.NewLine);
                    if (sb.Length == 0)
                    {
                        sb.Append("Quy trình: ");
                        sb.Append(Environment.NewLine);
                    }
                    sb.Append(item.MMProductionNormItemProductName);
                }
            }
            if (sb.Length != 0)
            {
                sb.Append(Environment.NewLine);
                sb.Append(" có tổng diện tích ĐM sơn không hợp lệ. Vui lòng kiểm tra lại!");
                isValid = false;
                MessageBox.Show(sb.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isValid;
        }
        public override int ActionSave()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject;

            if (OriProductID != objProductionNormsInfo.FK_ICProductID)
            {
                if (IsProductHasBOM(objProductionNormsInfo.FK_ICProductID))
                {
                    return 0;
                }
            }
            if (!isValidPaintQty())
            {
                return 0;
            }
            //if (CheckValidItemNo())
            //{
            bool isNew = false;

            ProductionNormBackUpObject = (MMProductionNormsInfo)objProductionNormsInfo.Clone();
            if (objProductionNormsInfo.MMProductionNormNo == cstNewObjectText)
                isNew = true;

            #region History

            if (objectHistories == null)
                objectHistories = new List<GEObjectHistoryInfo>();
            objectHistories.Clear();

            GetEditHistory(entity.ProductionNormItemList);
            GetEditHistory(entity.ProductionNormItemHardwareList);
            GetEditHistory(entity.ProductionNormItemPaintList);
            GetEditHistory(entity.ProductionNormItemPackagingList);

            GetDeleteHistory(entity.ProductionNormItemList, ProductionNormItemOriginalList);
            GetDeleteHistory(entity.ProductionNormItemHardwareList, ProductionNormItemHardwareOriginalList);
            GetDeleteHistory(entity.ProductionNormItemPaintList, ProductionNormItemPaintOriginalList);
            GetDeleteHistory(entity.ProductionNormItemPackagingList, ProductionNormItemPackagingOriginalList);


            #endregion

            LoadProductImage();
            if (HaveFocusWood)
            {
                objProductionNormsInfo.MMProductionNormTotalPaint = Math.Round(objProductionNormsInfo.MMProductionNormTotalPaint, 4);
            }
            int result = base.ActionSave();
            if (isNew & result > 0)
            {
                entity.SetPropertyChangeEventLock(false);
                // filter bi loi nen phai lay lai doi tuong tu database len
                MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
                objProductionNormsInfo = (MMProductionNormsInfo)objProductionNormsController.GetObjectByID(result);
                if (objProductionNormsInfo != null)
                {
                    objProductionNormsInfo.MMProductionNormOriginNo = objProductionNormsInfo.MMProductionNormNo;
                    if (objProductionNormsInfo.MMProductionNormName == string.Empty)
                    {
                        if (objProductionNormsInfo.FK_ICProductID > 0)
                        {
                            ICProductsController objProductsController = new ICProductsController();
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                            if (objProductsInfo != null)
                            {
                                objProductionNormsInfo.MMProductionNormName = objProductsInfo.ICProductNo;
                            }
                        }
                    }
                    objProductionNormsController.UpdateObject(objProductionNormsInfo);
                }
                entity.SetPropertyChangeEventLock(true);
            }
            //if (result > 0)
            //    SaveChange();

            if (IsCoppyVersion)
            {
                IsCoppyVersion = false;
            }
            //#region History

            //InvalidateProfileManagement();

            //#endregion
            return result;
            //}
            //else
            //{
            //    MessageBox.Show(ProductionNormLocalizeResources.SaveDetailMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return 0;
            //}
        }
        #region History & Profile Management
        public void InvalidateProfileManagement()
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            GEObjectHistoryController objObjectHistoryController = new GEObjectHistoryController();
            List<GEObjectHistoryInfo> objGEObjectHistoryList = new List<GEObjectHistoryInfo>();
            objGEObjectHistoryList = objObjectHistoryController.GetProfileManagementItemFromHistory(objProductionNormsInfo.MMProductionNormID);
            if (objProductionNormsInfo.MMProductionNormID > 0)
                entity.ProfileManagementItemList.Invalidate(objProductionNormsInfo.MMProductionNormID);
            entity.ProfileManagementHistoryList.Invalidate(objGEObjectHistoryList);
            entity.SemiProductProfileManagementHistoryList.Invalidate(objGEObjectHistoryList.Where(i => i.GEHistoryDetailTableName.Equals("B" + ProductType.SemiProduct.ToString())).ToList());
            entity.HardwareProfileManagementHistoryList.Invalidate(objGEObjectHistoryList.Where(i => i.GEHistoryDetailTableName.Equals("C" + ProductType.Hardware.ToString())).ToList());
            entity.PackagingProfileManagementHistoryList.Invalidate(objGEObjectHistoryList.Where(i => i.GEHistoryDetailTableName.Equals("D" + ProductType.IngredientPackaging.ToString())).ToList());
            entity.PaintProfileManagementHistoryList.Invalidate(objGEObjectHistoryList.Where(i => i.GEHistoryDetailTableName.Equals("E" + ProductType.IngredientPaint.ToString())).ToList());

        }
        public void SaveDeleteHistoryDetail(BusinessObject currentObject, string productType)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            int objectHistoryID = 0;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;


            if (productType == ProductType.SemiProduct.ToString())
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)currentObject;
                if (objProductionNormItemsInfo != null)
                {
                    objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.Delete, objProductionNormItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objProductionNormItemsInfo.MMProductionNormItemNo);

                    //Save ProductionNormItems delete item to history details
                    entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID, objProductionNormItemsInfo,
                                                        objProductionNormItemsInfo.MMProductionNormItemProductName,
                                                        ProductionNormConst.MMProductionNormItemNo,
                                                        true);
                }
            }

            if (productType == ProductType.Hardware.ToString())
            {
                MMProductionNormItemsInfo objHardwareItemsInfo = (MMProductionNormItemsInfo)currentObject;
                if (objHardwareItemsInfo != null)
                {
                    objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.Delete, objHardwareItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objHardwareItemsInfo.MMProductionNormItemNo);

                    //Save HardwareItems delete item to history details
                    entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID, objHardwareItemsInfo,
                                                        objHardwareItemsInfo.MMProductionNormItemProductName,
                                                        ProductionNormConst.MMProductionNormItemNo,
                                                        true);
                }

            }
            if (productType == ProductType.IngredientPackaging.ToString())
            {
                MMProductionNormItemsInfo objPackagingItemsInfo = (MMProductionNormItemsInfo)currentObject;
                if (objPackagingItemsInfo != null)
                {
                    objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.Delete, objPackagingItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objPackagingItemsInfo.MMProductionNormItemNo);


                    //Save PackagingItems delete item to history details
                    entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID,
                                                        objPackagingItemsInfo,
                                                        objPackagingItemsInfo.MMProductionNormItemProductName,
                                                        ProductionNormConst.MMProductionNormItemNo,
                                                        true);
                    OldPackagingItemsList = new List<MMProductionNormItemsInfo>();
                    foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
                    {
                        OldPackagingItemsList.Add(item);
                        if (item.SubList != null && item.SubList.Count > 0)
                        {
                            foreach (MMProductionNormItemsInfo itemChild in item.SubList)
                            {
                                OldPackagingItemsList.Add(itemChild);
                            }
                        }
                    }
                }
            }
            if (productType == ProductType.IngredientPaint.ToString())
            {
                MMProductionNormItemsInfo objPaintItemsInfo = (MMProductionNormItemsInfo)currentObject;
                if (objPaintItemsInfo != null)
                {
                    objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.Delete, objPaintItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objPaintItemsInfo.MMProductionNormItemNo);


                    //Save PaintItems delete item to history details
                    entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID, objPaintItemsInfo
                                                    , objPaintItemsInfo.MMProductionNormItemProductName
                                                    , ProductionNormConst.MMProductionNormItemNo,
                                                    true);
                    OldPaintItemsList = new List<MMProductionNormItemsInfo>();
                    foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
                    {
                        OldPaintItemsList.Add(item);
                    }
                }
            }
        }
        public void RemoveSelectedItemFromProfileManagementItemList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.ProfileManagementItemList.RemoveSelectedRowObjectFromList();
        }
        public void DeleteNormTemplateItemFromList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.NormTemplateItemList.RemoveSelectedRowObjectFromList();
        }
        public System.Data.DataTable GetEmployee()
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet ds = objEmployeesController.GetAllObjects();
            System.Data.DataTable dt = new System.Data.DataTable();
            if (ds != null)
                dt = ds.Tables[0];
            ds.Dispose();
            return dt;
        }
        public void CheckAndSaveAddNewToHistoryDetail()
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (HaveFocusWood)
            {
                //if (objProductionNormsInfo.MMProductionNormWoodStatus == MMProductionNormStatus.Edit.ToString()
                //    || ProductionNormBackUpObject.MMProductionNormWoodStatus == MMProductionNormStatus.Edit.ToString())
                //{
                //SemiProduct
                if (entity.ProductionNormItemList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemList)
                    {
                        //if (newItem.MMProductionNormItemID == 0)
                        //    SaveAddNewToHistoryDetail(newItem, ProductType.SemiProduct.ToString());
                        //if (newItem.SubList != null && newItem.SubList.Count > 0)
                        //{
                        //    foreach (MMProductionNormItemsInfo itemChild in newItem.SubList)
                        //    {
                        //        if (itemChild.MMProductionNormItemID == 0)
                        //            SaveAddNewToHistoryDetail(itemChild, ProductType.SemiProduct.ToString());
                        //    }
                        //}
                        if (newItem.MMProductionNormItemID > 0
                            && ProductionNormItemOriginalList.FirstOrDefault
                            (t => t.MMProductionNormItemID == newItem.MMProductionNormItemID) == null)
                        {
                            SaveAddNewToHistoryDetail(newItem, ProductType.SemiProduct.ToString());
                        }
                        if (newItem.SubList != null && newItem.SubList.Count > 0)
                        {
                            foreach (MMProductionNormItemsInfo itemChild in newItem.SubList)
                            {
                                if (itemChild.MMProductionNormItemID > 0
                                    && ProductionNormItemOriginalList.FirstOrDefault
                                    (t => t.MMProductionNormItemID == itemChild.MMProductionNormItemID) == null)
                                {
                                    SaveAddNewToHistoryDetail(itemChild, ProductType.SemiProduct.ToString());
                                }
                            }
                        }
                    }
                }
                //}
            }
            if (HaveFocusHardware)
            {
                //if (objProductionNormsInfo.MMProductionNormHardwareStatus == MMProductionNormStatus.Edit.ToString()
                //    || ProductionNormBackUpObject.MMProductionNormHardwareStatus == MMProductionNormStatus.Edit.ToString())
                //{
                //Hardware
                if (entity.ProductionNormItemHardwareList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemHardwareList)
                    {
                        if (newItem.MMProductionNormItemID > 0
                           && ProductionNormItemHardwareOriginalList.FirstOrDefault
                           (t => t.MMProductionNormItemID == newItem.MMProductionNormItemID) == null)
                        {
                            SaveAddNewToHistoryDetail(newItem, ProductType.Hardware.ToString());
                        }
                    }
                }
                //}
            }
            if (HaveFocusPackaging)
            {
                //if (objProductionNormsInfo.MMProductionNormPackingMaterialStatus == MMProductionNormStatus.Edit.ToString()
                //     || ProductionNormBackUpObject.MMProductionNormPackingMaterialStatus == MMProductionNormStatus.Edit.ToString())
                //{
                //Packaging
                if (entity.ProductionNormItemPackagingList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemPackagingList)
                    {
                        if (newItem.MMProductionNormItemID > 0
                           && ProductionNormItemPackagingOriginalList.FirstOrDefault
                           (t => t.MMProductionNormItemID == newItem.MMProductionNormItemID) == null)
                        {
                            SaveAddNewToHistoryDetail(newItem, ProductType.IngredientPackaging.ToString());
                        }
                        if (newItem.SubList != null && newItem.SubList.Count > 0)
                        {
                            foreach (MMProductionNormItemsInfo itemChild in newItem.SubList)
                            {
                                if (itemChild.MMProductionNormItemID > 0
                                    && ProductionNormItemPackagingOriginalList.FirstOrDefault
                                    (t => t.MMProductionNormItemID == itemChild.MMProductionNormItemID) == null)
                                {
                                    SaveAddNewToHistoryDetail(itemChild, ProductType.IngredientPackaging.ToString());
                                }
                            }
                        }
                    }
                }

                //}
            }
            if (HaveFocusPaint)
            {
                //if (objProductionNormsInfo.MMProductionNormPaintStatus == MMProductionNormStatus.Edit.ToString()
                //     || ProductionNormBackUpObject.MMProductionNormPaintStatus == MMProductionNormStatus.Edit.ToString())
                //{
                //Paint
                if (entity.ProductionNormItemPaintList.Count > 0)
                {
                    foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemPaintList)
                    {
                        if (newItem.MMProductionNormItemID > 0
                          && ProductionNormItemPaintOriginalList.FirstOrDefault
                          (t => t.MMProductionNormItemID == newItem.MMProductionNormItemID) == null)
                        {
                            SaveAddNewToHistoryDetail(newItem, ProductType.IngredientPaint.ToString());
                        }
                    }
                }
                //}
            }
        }
        public void SaveAddNewToHistoryDetail(BusinessObject newObject, string productType)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            int objectHistoryID = 0;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;

            if (productType == ProductType.SemiProduct.ToString())
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)newObject;

                objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.New, objProductionNormItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objProductionNormItemsInfo.MMProductionNormItemNo);


                //Save ProductionNormItems delete item to history details
                entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID, objProductionNormItemsInfo,
                                                    objProductionNormItemsInfo.MMProductionNormItemProductName,
                                                    ProductionNormConst.MMProductionNormItemNo,
                                                    false);

            }

            if (productType == ProductType.Hardware.ToString())
            {
                MMProductionNormItemsInfo objHardwareItemsInfo = (MMProductionNormItemsInfo)newObject;

                objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.New, objHardwareItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objHardwareItemsInfo.MMProductionNormItemNo);


                //Save HardwareItems delete item to history details
                entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID, objHardwareItemsInfo,
                                                    objHardwareItemsInfo.MMProductionNormItemProductName,
                                                    ProductionNormConst.MMProductionNormItemNo,
                                                    false);


            }
            if (productType == ProductType.IngredientPackaging.ToString())
            {
                MMProductionNormItemsInfo objPackagingItemsInfo = (MMProductionNormItemsInfo)newObject;

                objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.New, objPackagingItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objPackagingItemsInfo.MMProductionNormItemNo);


                //Save PackagingItems delete item to history details
                entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID,
                                                    objPackagingItemsInfo,
                                                    objPackagingItemsInfo.MMProductionNormItemProductName,
                                                    ProductionNormConst.MMProductionNormItemNo,
                                                    false);
                OldPackagingItemsList = new List<MMProductionNormItemsInfo>();
                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
                {
                    OldPackagingItemsList.Add(item);
                    if (item.SubList != null && item.SubList.Count > 0)
                    {
                        foreach (MMProductionNormItemsInfo itemChild in item.SubList)
                        {
                            OldPackagingItemsList.Add(itemChild);
                        }
                    }
                }

            }
            if (productType == ProductType.IngredientPaint.ToString())
            {
                MMProductionNormItemsInfo objPaintItemsInfo = (MMProductionNormItemsInfo)newObject;

                objectHistoryID = entity.SaveObjectHistory(ProductionNormLocalizeResources.New, objPaintItemsInfo.MMProductionNormItemID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objPaintItemsInfo.MMProductionNormItemNo);


                //Save PaintItems delete item to history details
                entity.SaveDeleteOrNewToHistoryDetails(objectHistoryID, objectHistoryID, objPaintItemsInfo
                                                , objPaintItemsInfo.MMProductionNormItemProductName
                                                , ProductionNormConst.MMProductionNormItemNo,
                                                false);
                OldPaintItemsList = new List<MMProductionNormItemsInfo>();
                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPaintList)
                {
                    OldPaintItemsList.Add(item);
                }

            }

        }

        public void SaveChangeHistory(MMProductionNormItemsInfo oldItem, MMProductionNormItemsInfo newItem)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ADUsersController objADUsersController = new ADUsersController();
            int iADUserID = objADUsersController.GetObjectIDByName(BOSApp.CurrentUser);

            GEObjectHistoryController objGEObjectHistoryController = new GEObjectHistoryController();

            //Get Object History Info
            GEObjectHistoryInfo objGEObjectHistoryInfo = new GEObjectHistoryInfo();
            objGEObjectHistoryInfo.ADUserID = iADUserID;
            objGEObjectHistoryInfo.ADUserName = BOSApp.CurrentUser;
            objGEObjectHistoryInfo.GEObjectHistoryAction = "Change";
            objGEObjectHistoryInfo.GEObjectHistoryObjectID = oldItem.MMProductionNormItemID;
            objGEObjectHistoryInfo.GEObjectHistoryObjectName = ProductionNormConst.ProductionNormItem;
            objGEObjectHistoryInfo.GEObjectHistoryObjectNumber = oldItem.MMProductionNormItemNo;
            BOSDbUtil dbUtil = new BOSDbUtil();
            DateTime currentDate = dbUtil.GetCurrentServerDate();
            objGEObjectHistoryInfo.GEObjectHistoryDate = currentDate;

            int objectHistoryID = objGEObjectHistoryController.CreateObject(objGEObjectHistoryInfo);
            entity.SaveHistoryDetails(objectHistoryID, objGEObjectHistoryInfo.GEObjectHistoryID, oldItem, newItem);
        }


        public void SaveChangeHistory()
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            //SemiProduct 

            foreach (MMProductionNormItemsInfo oldItem in ProductionNormItemOriginalList)
            {
                foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemList)
                {
                    if (oldItem.MMProductionNormItemID == newItem.MMProductionNormItemID)
                    {
                        if (BOSApp.CheckChanged(oldItem, newItem))
                        {
                            SaveChangeHistory(oldItem, newItem);
                        }
                    }
                    else
                    {
                        if (newItem.SubList != null && newItem.SubList.Count > 0)
                        {
                            foreach (MMProductionNormItemsInfo newSubItem in newItem.SubList)
                            {
                                if (oldItem.MMProductionNormItemID == newSubItem.MMProductionNormItemID)
                                {
                                    if (BOSApp.CheckChanged(oldItem, newSubItem))
                                    {
                                        SaveChangeHistory(oldItem, newSubItem);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Packaging
            foreach (MMProductionNormItemsInfo oldItem in ProductionNormItemPackagingOriginalList)
            {
                foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemPackagingList)
                {
                    if (oldItem.MMProductionNormItemID == newItem.MMProductionNormItemID)
                    {
                        if (BOSApp.CheckChanged(oldItem, newItem))
                        {
                            SaveChangeHistory(oldItem, newItem);
                        }
                    }
                    else
                    {
                        if (newItem.SubList != null && newItem.SubList.Count > 0)
                        {
                            foreach (MMProductionNormItemsInfo newSubItem in newItem.SubList)
                            {
                                if (oldItem.MMProductionNormItemID == newSubItem.MMProductionNormItemID)
                                {
                                    if (BOSApp.CheckChanged(oldItem, newSubItem))
                                    {
                                        SaveChangeHistory(oldItem, newSubItem);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Paint
            foreach (MMProductionNormItemsInfo oldItem in ProductionNormItemPaintOriginalList)
            {
                foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemPaintList)
                {
                    if (oldItem.MMProductionNormItemID == newItem.MMProductionNormItemID)
                    {
                        if (BOSApp.CheckChanged(oldItem, newItem))
                        {
                            SaveChangeHistory(oldItem, newItem);
                        }
                    }
                }
            }
            // Hardware
            foreach (MMProductionNormItemsInfo oldItem in ProductionNormItemHardwareOriginalList)
            {
                foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemHardwareList)
                {
                    if (oldItem.MMProductionNormItemID == newItem.MMProductionNormItemID)
                    {
                        if (BOSApp.CheckChanged(oldItem, newItem))
                        {
                            SaveChangeHistory(oldItem, newItem);
                        }
                    }
                }
            }

        }

        public void SaveChange()
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;

            foreach (MMProductionNormItemsInfo oldItem in ProductionNormItemOriginalBackupList)
            {
                foreach (MMProductionNormItemsInfo newItem in entity.ProductionNormItemList)
                {
                    if (oldItem.MMProductionNormItemID == newItem.MMProductionNormItemID)
                    {
                        if (BOSApp.CheckChanged(oldItem, newItem))
                        {
                            entity.SaveChangeSemiProduct(oldItem, newItem);
                        }
                    }
                    else
                    {
                        if (newItem.SubList != null && newItem.SubList.Count > 0)
                        {
                            foreach (MMProductionNormItemsInfo newSubItem in newItem.SubList)
                            {
                                if (oldItem.MMProductionNormItemID == newSubItem.MMProductionNormItemID)
                                {
                                    if (BOSApp.CheckChanged(oldItem, newSubItem))
                                    {
                                        entity.SaveChangeSemiProduct(oldItem, newSubItem);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public override int SaveObjectHistory(string strUserAction, int iObjectID)
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            int objectHistoryID = 0;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
            if (strUserAction != ProductionNormLocalizeResources.Create)
            {
                if (objProductsInfo != null)
                {
                    //if (objProductionNormsInfo.MMProductionNormWoodStatus != MMProductionNormStatus.New.ToString()
                    //    || objProductionNormsInfo.MMProductionNormPackingMaterialStatus != MMProductionNormStatus.New.ToString()
                    //    || objProductionNormsInfo.MMProductionNormHardwareStatus != MMProductionNormStatus.New.ToString()
                    //    || objProductionNormsInfo.MMProductionNormPaintStatus != MMProductionNormStatus.New.ToString())
                    //{
                    objectHistoryID = entity.SaveObjectHistory(strUserAction, iObjectID, this.Name, ProductionNormConst.MMProductionNormsControllerName, objProductsInfo.ICProductNo);
                    //Save main object to detail history
                    if (BOSApp.CheckChanged(OldProductionNormsInfo, objProductionNormsInfo))
                        entity.SaveHistoryDetails(objectHistoryID, objectHistoryID, OldProductionNormsInfo, objProductionNormsInfo);
                    //}
                    #region cmt

                    #endregion
                }
            }
            return objectHistoryID;
        }
        #endregion

        public void SaveObjectHistory()
        {
            if (objectHistories != null)
            {
                GEObjectHistoryController objectHistoryController = new GEObjectHistoryController();
                GEHistoryDetailsController historyDetailController = new GEHistoryDetailsController();
                BOSDbUtil dbUtil = new BOSDbUtil();
                int id;
                foreach (GEObjectHistoryInfo objectHistory in objectHistories)
                {
                    DateTime currentDate = dbUtil.GetCurrentServerDate();
                    objectHistory.GEObjectHistoryDate = currentDate;

                    id = objectHistoryController.CreateObject(objectHistory);
                    if (id > 0 && objectHistory.HistoryDetails != null)
                    {
                        foreach (GEHistoryDetailsInfo historyDetail in objectHistory.HistoryDetails)
                        {
                            historyDetail.FK_GEObjectHistoryID = id;
                            historyDetail.GEHistoryDetailParentID = id;
                            historyDetailController.CreateObject(historyDetail);
                        }
                    }
                }
            }
        }
        public bool RefeshCarcass = false;
        public void ChangeProductionNormGroup(int iObjectID)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();

            int index = 0;
            List<MMProductionNormItemsInfo> collection;
            if (!RefeshCarcass)
                collection = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.SemiProduct.ToString(), iObjectID);
            //GetCarcass
            else
            {
                collection = objProductionNormItemsController.GetCarcassByProductID(mainObject.FK_ICProductCarcassID);
                RefeshCarcass = false;
            }
            this.InvalidateTreeList(entity.ProductionNormItemList, collection, 0, true, ref index, true);
            entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
            entity.ProductionNormItemList.TreeListControl.ExpandAll();
            entity.ProductionNormItemList.TreeListControl.BestFitColumns();

            int index1 = 0;
            collection = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.Hardware.ToString(), iObjectID);
            this.InvalidateTreeList(entity.ProductionNormItemHardwareList, collection, 0, true, ref index1, false);
            entity.ProductionNormItemHardwareList.TreeListControl.RefreshDataSource();
            entity.ProductionNormItemHardwareList.TreeListControl.ExpandAll();
            entity.ProductionNormItemHardwareList.TreeListControl.BestFitColumns();

            //Invalidate ProductionNormItemsPaint
            int index2 = 0;
            collection = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.IngredientPaint.ToString(), iObjectID);
            this.InvalidateTreeList(entity.ProductionNormItemPaintList, collection, 0, true, ref index2, false);
            entity.ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
            entity.ProductionNormItemPaintList.TreeListControl.ExpandAll();
            entity.ProductionNormItemPaintList.TreeListControl.BestFitColumns();

            int index3 = 0;
            collection = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.IngredientPackaging.ToString(), iObjectID);
            this.InvalidateTreeList(entity.ProductionNormItemPackagingList, collection, 0, true, ref index3, false);
            entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
            entity.ProductionNormItemPackagingList.TreeListControl.ExpandAll();
            entity.ProductionNormItemPackagingList.TreeListControl.BestFitColumns();

            HaveFocusHardware = true;
            HaveFocusPackaging = true;
            HaveFocusPaint = true;
            HaveFocusWood = true;
            HaveFocusGeneralMaterial = true;

        }

        public int OrderTreeListAsc(MMProductionNormItemsInfo item, int detailCount)
        {
            if (item.SubList != null)
            {
                if (item.SubList.OriginalList == null)
                {
                    item.SubList.OriginalList = new BOSTreeList();
                }
                item.SubList.OriginalList.Clear();
                List<MMProductionNormItemsInfo> subList = new List<MMProductionNormItemsInfo>();
                foreach (MMProductionNormItemsInfo subItem in item.SubList)
                {
                    subList.Add(subItem);
                }
                subList = subList.OrderBy(t => t.MMProductionNormItemID).ToList();
                item.SubList = new BOSTreeList();
                item.SubList.InitBOSList((ProductionNormEntities)CurrentModuleEntity, TableName.MMProductionNormItemsTableName, TableName.MMProductionNormItemsTableName);
                foreach (MMProductionNormItemsInfo subItem in subList)
                {
                    subItem.MMProductionNormItemSortOrder = detailCount;
                    subItem.MMProductionNormItemSortOrderString = detailCount.ToString();
                    detailCount++;

                    item.SubList.Add(subItem);
                    item.SubList.OriginalList.Add(subItem);
                }

            }
            return detailCount;
        }
        public void OrderTreeListAsc(MMProductionNormItemsInfo item)
        {
            if (item.SubList != null)
            {
                if (item.SubList.OriginalList == null)
                {
                    item.SubList.OriginalList = new BOSTreeList();
                }
                item.SubList.OriginalList.Clear();
                List<MMProductionNormItemsInfo> subList = new List<MMProductionNormItemsInfo>();
                foreach (MMProductionNormItemsInfo subItem in item.SubList)
                {
                    subList.Add(subItem);
                }
                subList = subList.OrderBy(t => t.MMProductionNormItemID).ToList();
                item.SubList = new BOSTreeList();
                item.SubList.InitBOSList((ProductionNormEntities)CurrentModuleEntity, TableName.MMProductionNormItemsTableName, TableName.MMProductionNormItemsTableName);
                foreach (MMProductionNormItemsInfo subItem in subList)
                {

                    item.SubList.Add(subItem);
                    item.SubList.OriginalList.Add(subItem);
                }

            }

        }
        public string GetProductDefaultNo(string productFullNo)
        {
            string productNo = string.Empty;

            string[] productNos = productFullNo.Split('.');
            if (productNos.Length > 0)
            {
                productNo = productNos[0];

            }
            return productNo;
        }

        public bool IsProductHasBOM(int productID)
        {

            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            List<MMProductionNormsInfo> productionNormsList = objProductionNormsController.GetProductionNormByProductID(productID);


            if (productionNormsList != null && productionNormsList.Count > 0)
            {
                string objBDMNos = string.Empty;
                foreach (MMProductionNormsInfo item in productionNormsList)
                {
                    if (objBDMNos != string.Empty)
                    {
                        objBDMNos += ", " + item.MMProductionNormNo;
                    }
                    else
                    {
                        objBDMNos += item.MMProductionNormNo;
                    }
                }
                MessageBox.Show("Thành phẩm đang chọn đã có bảng định mức (" + objBDMNos + ")", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        public void ChangeProduct(int productID)
        {
            if (IsDupplicate)
            {
                if (OldProductID != productID)
                {
                    IsProductHasBOM(productID);
                }
            }
            else
            {
                if (OriProductID != productID)
                {
                    IsProductHasBOM(productID);
                }
            }
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            mainObject.FK_ICProductID = productID;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                //Tên
                mainObject.MMProductionNormName = objProductsInfo.ICProductNo;
                //Mô tả
                //    objProductionNormsInfo.MMProductionNormDesc = objProductsInfo.ICProductDesc;
                //KT Tổng thể
                mainObject.MMProductionNormOverallSize = (int)objProductsInfo.ICProductLength + "x" + (int)objProductsInfo.ICProductWidth + "x" + (int)objProductsInfo.ICProductHeight;
                //Mã HT Cũ
                mainObject.MMProductionNormOldProductNo = objProductsInfo.ICProductNoOfOldSys;
                if (objProductsInfo.FK_ICProductCarcassID != 0)
                    mainObject.FK_ICProductCarcassID = objProductsInfo.FK_ICProductCarcassID;
                else
                    mainObject.FK_ICProductCarcassID = objProductsInfo.ICProductID;

                //invalidate product list
                objProductionNormsInfo.FK_ICProductCarcassID = mainObject.FK_ICProductCarcassID;
                objProductionNormsInfo.MMProductionNormBlock = objProductsInfo.MMProductionNormBlock;
                objProductionNormsInfo.MMProductionNormTotalPaint = objProductsInfo.MMProductionNormTotalPaint;
                //this.InvalidateProductList(mainObject.FK_ICProductCarcassID);
                this.InvalidateWoodTreeList();

                InvalidateBOMHardware();
                InvalidateBOMGeneralMaterial();
            }
        }

        public void EnableToolbar(string toolBarName)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (objProductionNormsInfo.MMProductionNormID > 0)
            {

                if (objProductionNormsInfo.MMProductionNormWoodStatus == MMProductionNormStatus.New.ToString()
                    || objProductionNormsInfo.MMProductionNormWoodStatus == MMProductionNormStatus.Edit.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusWoodToValidated, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusWoodToApproved, false);
                }
                else if (objProductionNormsInfo.MMProductionNormWoodStatus == MMProductionNormStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusWoodToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusWoodToApproved, true);
                }
                else if (objProductionNormsInfo.MMProductionNormWoodStatus == MMProductionNormStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusWoodToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusWoodToApproved, false);
                }

                if (objProductionNormsInfo.MMProductionNormHardwareStatus == MMProductionNormStatus.New.ToString()
                   || objProductionNormsInfo.MMProductionNormHardwareStatus == MMProductionNormStatus.Edit.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardwareToValidated, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardwareToApproved, false);
                }
                else if (objProductionNormsInfo.MMProductionNormHardwareStatus == MMProductionNormStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardwareToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardwareToApproved, true);
                }
                else if (objProductionNormsInfo.MMProductionNormHardwareStatus == MMProductionNormStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardwareToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardwareToApproved, false);
                }

                if (objProductionNormsInfo.MMProductionNormPackingMaterialStatus == MMProductionNormStatus.New.ToString()
                    || objProductionNormsInfo.MMProductionNormPackingMaterialStatus == MMProductionNormStatus.Edit.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponentValidated, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponentApproved, false);
                }
                else if (objProductionNormsInfo.MMProductionNormPackingMaterialStatus == MMProductionNormStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponentValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponentApproved, true);
                }
                else if (objProductionNormsInfo.MMProductionNormPackingMaterialStatus == MMProductionNormStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponentValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponentApproved, false);
                }


                if (objProductionNormsInfo.MMProductionNormPaintStatus == MMProductionNormStatus.New.ToString()
                    || objProductionNormsInfo.MMProductionNormPaintStatus == MMProductionNormStatus.Edit.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaintValidated, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaintApprove, false);
                }
                else if (objProductionNormsInfo.MMProductionNormPaintStatus == MMProductionNormStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaintValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaintApprove, true);
                }
                else if (objProductionNormsInfo.MMProductionNormPaintStatus == MMProductionNormStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaintValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaintApprove, false);
                }

                //TNDLoc [ADD][19/11/2015][Operation],START
                if (objProductionNormsInfo.MMProductionNormOperationStatus == MMProductionNormStatus.New.ToString()
                    || objProductionNormsInfo.MMProductionNormOperationStatus == MMProductionNormStatus.Edit.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperationToValidated, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperationToApproved, false);
                }
                else if (objProductionNormsInfo.MMProductionNormOperationStatus == MMProductionNormStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperationToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperationToApproved, true);
                }
                else if (objProductionNormsInfo.MMProductionNormOperationStatus == MMProductionNormStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperationToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperationToApproved, false);
                }

                if (objProductionNormsInfo.MMProductionNormGeneralMaterialStatus == MMProductionNormStatus.New.ToString()
                  || objProductionNormsInfo.MMProductionNormGeneralMaterialStatus == MMProductionNormStatus.Edit.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterialToValidated, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterialToApproved, false);
                }
                else if (objProductionNormsInfo.MMProductionNormGeneralMaterialStatus == MMProductionNormStatus.Validated.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterialToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterialToApproved, true);
                }
                else if (objProductionNormsInfo.MMProductionNormGeneralMaterialStatus == MMProductionNormStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterialToValidated, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterialToApproved, false);
                }


                if (toolBarName == ProductionNormConst.ChangestatusSemiProduct)
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
                }
                else if (toolBarName == ProductionNormConst.ChangestatusComponent)
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardware, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
                }
                else if (toolBarName == ProductionNormConst.ChangestatusHardware)
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardware, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
                }
                else if (toolBarName == ProductionNormConst.ChangestatusPaint)
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardware, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, true);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
                }
                else if (toolBarName == ProductionNormConst.ChangestatusOperation)
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardware, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, true);
                }
                else if (toolBarName == ProductionNormConst.ChangestatusGeneralMaterial)
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardware, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, true);
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardware, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, false);
                    ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
                }
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusSemiProduct, false);
                ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusComponent, false);
                ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusHardware, false);
                ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusPaint, false);
                ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusOperation, false);
                ParentScreen.SetEnableOfToolbarButton(ProductionNormConst.ChangestatusGeneralMaterial, false);
            }
        }

        #region Status

        public void ApproveProductionNorm(string changedSection, MMProductionNormStatus status)
        {
            if ((!Toolbar.IsNewAction()) && (!Toolbar.IsEditAction()))
            {

                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = dbUtil.GetCurrentServerDate();
                entity.SetPropertyChangeEventLock(false);

                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                if (changedSection == ProductionNormConst.ChangestatusComponent)
                {
                    objProductionNormsInfo.MMProductionNormPackingMaterialStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeePackingMaterialApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormPackingMaterialApproveDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusHardware)
                {
                    objProductionNormsInfo.MMProductionNormHardwareStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeHardwareApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormHardwareApproveDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusPaint)
                {
                    objProductionNormsInfo.MMProductionNormPaintStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeePaintApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormPaintApproveDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusSemiProduct)
                {
                    objProductionNormsInfo.MMProductionNormWoodStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeWoodApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormWoodApproveDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusOperation)
                {
                    objProductionNormsInfo.MMProductionNormOperationStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeOperationApprove = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormOperationApproveDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusGeneralMaterial)
                {
                    objProductionNormsInfo.MMProductionNormGeneralMaterialStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeGeneralMaterialApproved = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormGeneralMaterialApprovedDate = currentDate;
                }
                entity.UpdateMainObject();
                SaveObjectHistory("Change", objProductionNormsInfo.MMProductionNormID);


                entity.SetPropertyChangeEventLock(true);
                EnableToolbar(changedSection);
            }
        }

        public void ValidateProductionNorm(string changedSection, MMProductionNormStatus status)
        {
            if ((!Toolbar.IsNewAction()) && (!Toolbar.IsEditAction()))
            {

                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                BOSDbUtil dbUtil = new BOSDbUtil();
                DateTime currentDate = dbUtil.GetCurrentServerDate();
                entity.SetPropertyChangeEventLock(false);

                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                if (changedSection == ProductionNormConst.ChangestatusComponent)
                {
                    objProductionNormsInfo.MMProductionNormPackingMaterialStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeePackingMaterialValidate = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormPackingMaterialValidateDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusHardware)
                {
                    objProductionNormsInfo.MMProductionNormHardwareStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeHardwareValidate = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormHardwareValidateDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusPaint)
                {
                    objProductionNormsInfo.MMProductionNormPaintStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeePaintValidate = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormPaintValidateDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusSemiProduct)
                {
                    objProductionNormsInfo.MMProductionNormWoodStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeWoodValidate = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormWoodValidateDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusOperation)
                {
                    objProductionNormsInfo.MMProductionNormOperationStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeOperationValidate = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormOperationValidateDate = currentDate;
                }
                else if (changedSection == ProductionNormConst.ChangestatusGeneralMaterial)
                {
                    objProductionNormsInfo.MMProductionNormGeneralMaterialStatus = status.ToString();
                    objProductionNormsInfo.FK_HREmployeeGeneralMaterialValidate = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    objProductionNormsInfo.MMProductionNormGeneralMaterialValidateDate = currentDate;
                }
                entity.UpdateMainObject();
                SaveObjectHistory("Change", objProductionNormsInfo.MMProductionNormID);

                entity.SetPropertyChangeEventLock(true);
                EnableToolbar(changedSection);
            }
        }

        /// <summary>
        /// Change status wood to Validated
        /// </summary>
        public void ChangestatusWoodToReachedValidated()
        {
            if (CheckMeterialExit())
                ValidateProductionNorm(ProductionNormConst.ChangestatusSemiProduct, MMProductionNormStatus.Validated);
        }

        /// <summary>
        /// Change status wood to Validated
        /// </summary>
        public void ChangestatusWoodToUnReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangestatusSemiProduct, MMProductionNormStatus.UnValidated);
        }

        /// <summary>
        /// Change status wood to Approved
        /// </summary>
        public void ChangestatusWoodToReachedApproved()
        {
            if ((!Toolbar.IsNewAction()) && (!Toolbar.IsEditAction()))
            {
                if (!CheckMeterialExit()) return;
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                bool isValid = true;
                foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                {
                    //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    //if (item.SubList != null && item.SubList.Count > 0)
                    //{
                    //    foreach (MMProductionNormItemsInfo subItem in item.SubList)
                    //    {
                    //        if (subItem.FK_ICProductWoodIngredientID == 0)
                    //        {
                    //            isValid = false;
                    //            break;
                    //        }
                    //    }
                    //}
                }

                if (!isValid)
                {
                    MessageBox.Show(ProductionNormLocalizeResources.MissProductWoodIngredientError, CommonLocalizedResources.DepositDoesNotExistMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ApproveProductionNorm(ProductionNormConst.ChangestatusSemiProduct, MMProductionNormStatus.Approved);
                    InvalidateOperationBandedGrid();
                }

            }
        }

        /// <summary>
        /// Change status wood to Approved
        /// </summary>
        public void ChangestatusWoodToUnReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusSemiProduct, MMProductionNormStatus.UnApproved);
        }
        #region Hardware
        /// <summary>
        /// Change status wood to Validated
        /// </summary>
        public void ChangestatusHardwareToReachedValidated()
        {
            if ((!Toolbar.IsNewAction()) && (!Toolbar.IsEditAction()))
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                /*
                    Bước [Đạt]: Kiểm tra nếu khác mô tả với master data thì không cho Đạt
                 */
                MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> invalidList = objProductionNormItemsController.GetDescInValidListByProductTypeAndProductionNormID(objProductionNormsInfo.MMProductionNormID, ProductType.Hardware.ToString());
                if (invalidList != null && invalidList.Count > 0)
                {
                    string message = string.Empty;
                    message = "Các mã vật tư sau có mô tả khác mô tả với dữ liệu nguồn:";
                    int count = 1;
                    foreach (MMProductionNormItemsInfo item in invalidList)
                    {
                        message += Environment.NewLine;
                        message += count + ". " + item.MMProductionNormItemNo + " : " + item.MMProductionNormItemProductDesc;
                        count++;
                    }

                    MessageBox.Show(message, "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    ValidateProductionNorm(ProductionNormConst.ChangestatusHardware, MMProductionNormStatus.Validated);
                }
            }
        }

        /// <summary>
        /// Change status wood to Validated
        /// </summary>
        public void ChangestatusHardwareToUnReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangestatusHardware, MMProductionNormStatus.UnValidated);
        }

        /// <summary>
        /// Change status wood to Approved
        /// </summary>
        public void ChangestatusHardwareToReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusHardware, MMProductionNormStatus.Approved);
        }

        /// <summary>
        /// Change status wood to Approved
        /// </summary>
        public void ChangestatusHardwareToUnReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusHardware, MMProductionNormStatus.UnApproved);
        }
        #endregion
        #region GeneralMaterial
        /// <summary>
        /// Change status wood to Validated
        /// </summary>
        public void ChangeStatusGeneralMaterialToReachedValidated()
        {
            if ((!Toolbar.IsNewAction()) && (!Toolbar.IsEditAction()))
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                /*
                    Bước [Đạt]: Kiểm tra nếu khác mô tả với master data thì không cho Đạt
                 */
                MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> invalidList = objProductionNormItemsController.GetDescInValidListByProductTypeAndProductionNormID(objProductionNormsInfo.MMProductionNormID, ProductType.GeneralMaterial.ToString());
                if (invalidList != null && invalidList.Count > 0)
                {
                    string message = string.Empty;
                    message = "Các mã vật tư sau có mô tả khác mô tả với dữ liệu nguồn:";
                    int count = 1;
                    foreach (MMProductionNormItemsInfo item in invalidList)
                    {
                        message += Environment.NewLine;
                        message += count + ". " + item.MMProductionNormItemNo + " : " + item.MMProductionNormItemProductDesc;
                        count++;
                    }

                    MessageBox.Show(message, "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    ValidateProductionNorm(ProductionNormConst.ChangestatusGeneralMaterial, MMProductionNormStatus.Validated);
                }
            }
        }
        /// <summary>
        /// Change status wood to Validated
        /// </summary>
        public void ChangeStatusGeneralMaterialToUnReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangestatusGeneralMaterial, MMProductionNormStatus.UnValidated);
        }

        /// <summary>
        /// Change status wood to Approved
        /// </summary>
        public void ChangeStatusGeneralMaterialToReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusGeneralMaterial, MMProductionNormStatus.Approved);
        }

        /// <summary>
        /// Change status wood to Approved
        /// </summary>
        public void ChangeStatusGeneralMaterialToUnReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusGeneralMaterial, MMProductionNormStatus.UnApproved);
        }
        #endregion
        #region Paint
        /// <summary>
        /// Change status component Validated
        /// </summary>
        public void ChangestatusPaintReachedValidated()
        {
            if ((!Toolbar.IsNewAction()) && (!Toolbar.IsEditAction()))
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                /*
                    Bước [Đạt]: Kiểm tra nếu khác mô tả với master data thì không cho Đạt
                 */
                MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> invalidList = objProductionNormItemsController.GetDescInValidListByProductTypeAndProductionNormID(objProductionNormsInfo.MMProductionNormID, ProductType.IngredientPaint.ToString());
                if (invalidList != null && invalidList.Count > 0)
                {
                    string message = string.Empty;
                    message = "Các mã vật tư sau có mô tả khác mô tả với dữ liệu nguồn:";
                    int count = 1;
                    foreach (MMProductionNormItemsInfo item in invalidList)
                    {
                        message += Environment.NewLine;
                        message += count + ". " + item.MMProductionNormItemNo + " : " + item.MMProductionNormItemProductDesc;
                        count++;
                    }

                    MessageBox.Show(message, "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ValidateProductionNorm(ProductionNormConst.ChangestatusPaint, MMProductionNormStatus.Validated);
                }
            }
        }

        /// <summary>
        /// Change status component unValidated
        /// </summary>
        public void ChangestatusPaintUnReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangestatusPaint, MMProductionNormStatus.UnValidated);
        }
        /// <summary>
        /// Change status Paint Approved
        /// </summary>
        public void ChangestatusPaintReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusPaint, MMProductionNormStatus.Approved);
        }

        /// <summary>
        /// Change status Paint Approved
        /// </summary>
        public void ChangestatusPaintUnReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusPaint, MMProductionNormStatus.UnApproved);
        }

        #endregion

        /// <summary>
        /// Change status component Validated
        /// </summary>
        public void ChangestatusComponentReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangestatusComponent, MMProductionNormStatus.Validated);
        }

        /// <summary>
        /// Change status component unValidated
        /// </summary>
        public void ChangestatusComponentUnReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangestatusComponent, MMProductionNormStatus.UnValidated);
        }
        /// <summary>
        /// Change status component Approved
        /// </summary>
        public void ChangestatusComponentReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusComponent, MMProductionNormStatus.Approved);
        }

        /// <summary>
        /// Change status component Approved
        /// </summary>
        public void ChangestatusComponentUnReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusComponent, MMProductionNormStatus.UnApproved);
        }

        public void ChangestatusOperationToReachedValidated()
        {
            if (CheckOperationExit() && CheckProcessPeriod())
                ValidateProductionNorm(ProductionNormConst.ChangestatusOperation, MMProductionNormStatus.Validated);
        }

        public void ChangestatusOperationToUnReachedValidated()
        {
            ValidateProductionNorm(ProductionNormConst.ChangestatusOperation, MMProductionNormStatus.UnValidated);
        }

        public void ChangestatusOperationToReachedApproved()
        {
            if (CheckOperationExit() && CheckProcessPeriod())
                ApproveProductionNorm(ProductionNormConst.ChangestatusOperation, MMProductionNormStatus.Approved);
        }

        public void ChangestatusOperationToUnReachedApproved()
        {
            ApproveProductionNorm(ProductionNormConst.ChangestatusOperation, MMProductionNormStatus.UnApproved);
        }

        #endregion

        private void InvalidateTreeList(IBOSTreeList treeList, List<MMProductionNormItemsInfo> collection, int parentID, bool sortOrder, ref int startIndex, bool alphaOrder)
        {
            if (treeList != null && collection != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();
                int index = 1;
                //int index_orderNo = 1;
                string orderNo = string.Empty;

                foreach (MMProductionNormItemsInfo productionNormItem in collection)
                {
                    if (productionNormItem.MMProductionNormItemParentID == parentID)
                    {
                        if (sortOrder)
                        {
                            if (alphaOrder)
                            {
                                if (index < AlphaString.Length)
                                {
                                    orderNo = AlphaString[index - 1].ToString();
                                }
                            }
                            else
                            {
                                orderNo = (startIndex + 1) + "." + index.ToString();
                            }
                            index++;
                        }
                        MMProductionNormItemsInfo productionNormItem1 = productionNormItem.Clone() as MMProductionNormItemsInfo;
                        productionNormItem1.MMProductionNormItemSortOrderString = orderNo;
                        productionNormItem1.BackupObject = productionNormItem1.Clone() as MMProductionNormItemsInfo;
                        treeList.Add(productionNormItem1);
                        if (productionNormItem1.TheNumberOfChild != 0)
                        {
                            //Make the type of sub list same as its parent
                            object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            productionNormItem1.SubList = (BOSTreeList)objType;
                            productionNormItem1.SubList.InitBOSList(this.CurrentModuleEntity, TableName.MMProductionNormItemsTableName, TableName.MMProductionNormItemsTableName);
                            this.InvalidateTreeList(productionNormItem1.SubList, collection, productionNormItem1.MMProductionNormItemID, true, ref startIndex, false);
                        }

                        productionNormItem1 = productionNormItem.Clone() as MMProductionNormItemsInfo;
                        treeList.OriginalList.Add(productionNormItem1);
                        productionNormItem1 = productionNormItem.Clone() as MMProductionNormItemsInfo;
                        treeList.BackupList.Add(productionNormItem1);
                    }
                }
                startIndex++;
            }
        }

        public void InvalidateProductionNormItemByProductType(ProductType productype)
        {

            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            MMProductionNormsController productionNormController = new MMProductionNormsController();
            MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;
            if (objProductionNormsInfo == null)
                return;
            DataSet ds = new DataSet();
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            // if (!Toolbar.IsNewAction())
            {
                if (productype == ProductType.SemiProduct)
                {
                    if (!HaveFocusWood)
                    {
                        HaveFocusWood = true;
                        if (!RefeshCarcass)
                            ProductionNormItemOriginalList = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.SemiProduct.ToString(), objProductionNormsInfo.MMProductionNormID);
                        else
                        {
                            ProductionNormItemOriginalList = objProductionNormItemsController.GetCarcassByProductID(mainObject.FK_ICProductCarcassID);
                            RefeshCarcass = false;
                        }
                        int index = 0;
                        this.InvalidateTreeList(entity.ProductionNormItemList, ProductionNormItemOriginalList, 0, true, ref index, true);

                        entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
                        entity.ProductionNormItemList.TreeListControl.ExpandAll();
                        entity.ProductionNormItemList.TreeListControl.BestFitColumns();
                    }
                }
                else if (productype == ProductType.Hardware)
                {
                    if (!HaveFocusHardware)
                    {
                        HaveFocusHardware = true;

                        //Invalidate ProductionNormItemsHardware
                        ProductionNormItemHardwareOriginalList = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.Hardware.ToString(), objProductionNormsInfo.MMProductionNormID);
                        int index = 0;
                        this.InvalidateTreeList(entity.ProductionNormItemHardwareList, ProductionNormItemHardwareOriginalList, 0, true, ref index, false);

                        entity.ProductionNormItemHardwareList.TreeListControl.RefreshDataSource();
                        entity.ProductionNormItemHardwareList.TreeListControl.ExpandAll();
                        entity.ProductionNormItemHardwareList.TreeListControl.BestFitColumns();

                        InvalidateBOMHardware();
                    }
                    else
                    {
                        entity.ProductionNormItemHardwareList.TreeListControl.RefreshDataSource();

                    }
                }
                else if (productype == ProductType.IngredientPaint)
                {
                    if (!HaveFocusPaint)
                    {
                        HaveFocusPaint = true;
                        //Invalidate ProductionNormItemsPaint
                        ProductionNormItemPaintOriginalList = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.IngredientPaint.ToString(), objProductionNormsInfo.MMProductionNormID);
                        int index = 0;
                        this.InvalidateTreeList(entity.ProductionNormItemPaintList, ProductionNormItemPaintOriginalList, 0, true, ref index, false);
                        ReDrawPaintTreeList();
                        entity.ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
                        entity.ProductionNormItemPaintList.TreeListControl.ExpandAll();
                        entity.ProductionNormItemPaintList.TreeListControl.BestFitColumns();
                    }

                }
                else if (productype == ProductType.IngredientPackaging)
                {
                    if (!HaveFocusPackaging)
                    {
                        HaveFocusPackaging = true;

                        ProductionNormItemPackagingOriginalList = objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.IngredientPackaging.ToString(), objProductionNormsInfo.MMProductionNormID);
                        //entity.ProductionNormItemList.Invalidate(collection, 0);
                        int index = 0;
                        this.InvalidateTreeList(entity.ProductionNormItemPackagingList, ProductionNormItemPackagingOriginalList, 0, true, ref index, false);

                        entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
                        entity.ProductionNormItemPackagingList.TreeListControl.ExpandAll();
                        entity.ProductionNormItemPackagingList.TreeListControl.BestFitColumns();
                    }
                }
                else if (productype == ProductType.GeneralMaterial)
                {

                    if (!HaveFocusGeneralMaterial)
                    {
                        HaveFocusGeneralMaterial = true;
                        if (mainObject.MMProductionNormID > 0)
                            entity.GeneralMaterialList.Invalidate(objProductionNormItemsController.GetProductionNormItemsByProductionNormIDAndProductionNormItemGroup(ProductType.GeneralMaterial.ToString(), objProductionNormsInfo.MMProductionNormID));
                        entity.GeneralMaterialList.GridControl.RefreshDataSource();
                    }
                }
            }
            ds.Dispose();
        }

        public void ActionDuplicateSameNo()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                ChangeProductionNormGroup(Toolbar.CurrentObjectID);
                IsDupplicate = true;
                MMProductionNormsInfo objOldProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject.Clone();
                OriProductID = objOldProductionNormsInfo.FK_ICProductID;
                OldProductID = objOldProductionNormsInfo.FK_ICProductID;
                base.ActionDuplicate();
                if (ProductionNormItemHardwareOriginalList != null)
                    ProductionNormItemHardwareOriginalList.Clear();

                if (ProductionNormItemPaintOriginalList != null)
                    ProductionNormItemPaintOriginalList.Clear();

                if (ProductionNormItemPackagingOriginalList != null)
                    ProductionNormItemPackagingOriginalList.Clear();

                if (ProductionNormItemOriginalList != null)
                    ProductionNormItemOriginalList.Clear();
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject;

                //Set Referrence
                if (objOldProductionNormsInfo.MMProductionNormNo != string.Empty)
                {
                    string referrence = string.Empty;

                    objProductionNormsInfo.MMProductionNormReferrence = objOldProductionNormsInfo.MMProductionNormNo;
                    if (objOldProductionNormsInfo.MMProductionNormOriginNo != string.Empty)
                        objProductionNormsInfo.MMProductionNormOriginNo = objOldProductionNormsInfo.MMProductionNormOriginNo;
                    else
                        objProductionNormsInfo.MMProductionNormOriginNo = objOldProductionNormsInfo.MMProductionNormNo;
                    //Check exit
                    MMProductionNormsController objProductionNormsController = new MMProductionNormsController();

                    int count = objProductionNormsController.GetNextProductionNormVersionByOriginNo(objProductionNormsInfo.MMProductionNormOriginNo);

                    if (count == 0)
                        count++;

                    objProductionNormsInfo.MMProductionNormNo = objProductionNormsInfo.MMProductionNormOriginNo + "." + count;
                    objProductionNormsInfo.MMProductionNormVersion = count;
                }
                objProductionNormsInfo.MMProductionNormHardwareStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormPaintStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormWoodStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormOperationStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormPackingMaterialStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormGeneralMaterialStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            }
        }
        #region Bản sao
        public void CopyVersion()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                IsCoppyVersion = true;
                ChangeProductionNormGroup(Toolbar.CurrentObjectID);
                MMProductionNormsInfo objOldProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject.Clone();

                InvalidateProductionNormItemByProductType(ProductType.SemiProduct);
                InvalidateProductionNormItemByProductType(ProductType.IngredientPackaging);
                InvalidateProductionNormItemByProductType(ProductType.IngredientPaint);
                InvalidateProductionNormItemByProductType(ProductType.Hardware);
                base.ActionDuplicate();

                if (ProductionNormItemHardwareOriginalList != null)
                    ProductionNormItemHardwareOriginalList.Clear();

                if (ProductionNormItemPaintOriginalList != null)
                    ProductionNormItemPaintOriginalList.Clear();

                if (ProductionNormItemPackagingOriginalList != null)
                    ProductionNormItemPackagingOriginalList.Clear();

                if (ProductionNormItemOriginalList != null)
                    ProductionNormItemOriginalList.Clear();
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject;

                //Set Referrence
                objOldProductionNormsInfo.MMProductionNormNo = cstNewObjectText;
                //objProductionNormsInfo.MMProductionNormReferrence = objOldProductionNormsInfo.MMProductionNormNo;
                objProductionNormsInfo.MMProductionNormVersion = 1;

                objProductionNormsInfo.MMProductionNormWoodStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormHardwareStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormPackingMaterialStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormPaintStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormOperationStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.MMProductionNormGeneralMaterialStatus = MMProductionNormStatus.New.ToString();
                objProductionNormsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objProductionNormsInfo.MMProductionNormOriginNo = "";
                //Xóa TP khi tạo bản sao ,START
                objProductionNormsInfo.FK_ICProductID = 0;
                objProductionNormsInfo.MMProductionNormName = string.Empty;
                objProductionNormsInfo.MMProductionNormOverallSize = string.Empty;
                OriProductID = 0;
                //Xóa TP khi tạo bản sao ,END
                CreateNewDetailEdit.Visible = true;
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)ProductionNormResultsGridControl.MainView;
                gridView.Columns.View.ActiveFilter.Clear();
            }
        }

        public void ReplaceProductionNormItemNo(IBOSTreeList treeList, string oldValue, string newValue)
        {
            if (treeList != null)
            {
                foreach (MMProductionNormItemsInfo productionNormItem in treeList)
                {
                    productionNormItem.MMProductionNormItemNo = productionNormItem.MMProductionNormItemNo.Replace(oldValue, newValue);
                    productionNormItem.MMProductionNormItemParentNo = productionNormItem.MMProductionNormItemParentNo.Replace(oldValue, newValue);
                    if (productionNormItem.TheNumberOfChild != 0)
                        ReplaceProductionNormItemNo(productionNormItem.SubList, oldValue, newValue);
                }
            }
        }


        public void NewProductList(IBOSTreeList treeList, List<ICProductsInfo> parents, ICProductsController productController, ICProductItemsController productItemController)
        {
            if (treeList != null)
            {
                ICProductsInfo newProduct = null;
                ICProductsInfo oldProduct = null;
                foreach (MMProductionNormItemsInfo productionNormItem in treeList)
                {
                    newProduct = productController.GetObjectByNo(productionNormItem.MMProductionNormItemNo) as ICProductsInfo;
                    if (newProduct == null)
                    {
                        oldProduct = productController.GetObjectByID(productionNormItem.FK_ICProductID) as ICProductsInfo;
                        if (oldProduct != null)
                        {
                            //create a new product
                            newProduct = new ICProductsInfo();
                            BOSUtil.CopyObject(oldProduct, newProduct);
                            newProduct.ICProductNo = productionNormItem.MMProductionNormItemNo;
                            productController.CreateObject(newProduct);

                            //create productitem
                            if (parents != null)
                            {
                                foreach (ICProductsInfo productsInfo in parents)
                                {
                                    ICProductItemsInfo productItem = new ICProductItemsInfo();
                                    productItem.FK_ICProductItemParentID = productsInfo.ICProductID;
                                    productItem.FK_ICProductItemChildID = newProduct.ICProductID;
                                    productItem.ICProductItemQty = productionNormItem.MMProductionNormItemQuantity;
                                    productItemController.CreateObject(productItem);
                                }
                            }

                        }

                        if (productionNormItem.TheNumberOfChild != 0)
                        {
                            List<ICProductsInfo> subParents = new List<ICProductsInfo>();
                            subParents.Add(newProduct);
                            NewProductList(productionNormItem.SubList, subParents, productController, productItemController);
                        }
                    }
                    else
                    {
                        productionNormItem.FK_ICProductID = newProduct.ICProductID;

                        if (productionNormItem.TheNumberOfChild != 0)
                        {
                            List<ICProductsInfo> subParents = new List<ICProductsInfo>();
                            subParents.Add(newProduct);
                            NewProductList(productionNormItem.SubList, subParents, productController, productItemController);
                        }
                    }
                }
            }
        }

        public void GenerateNewDetail()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objOldProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject.Clone();
            List<ICProductsInfo> productComponentList = new List<ICProductsInfo>();
            List<ICProductsInfo> productItemList = new List<ICProductsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objParentProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objOldProductionNormsInfo.FK_ICProductID);
            ICProductItemsController objProductItemsController = new ICProductItemsController();

            string parentProductNo = string.Empty;
            #region Get Main Object Parent Product No
            string[] parentProductNos = objParentProductsInfo.ICProductNo.Split('.');
            if (parentProductNos.Length > 0)
            {
                parentProductNo = parentProductNos[0];
            }
            #endregion

            if (entity.ProductionNormItemList.Count > 0)
            {
                #region Check Change Main Object Product
                if (entity.ProductionNormItemList[0] != null)
                {
                    MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)entity.ProductionNormItemList[0];
                    if (item != null)
                    {
                        if (objParentProductsInfo != null & item.MMProductionNormItemNo.Contains(objParentProductsInfo.ICProductNo))
                        {
                            MessageBox.Show(ProductionNormLocalizeResources.NewProductMustBeChoose, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (objParentProductsInfo == null)
                        {
                            MessageBox.Show(ProductionNormLocalizeResources.NewProductMustBeChoose, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                #endregion


                //#region Wood
                #region Replace Item No
                MMProductionNormItemsInfo itemFirst = (MMProductionNormItemsInfo)entity.ProductionNormItemList[0];
                string oldNo = string.Empty;
                string[] itemFirstNos = itemFirst.MMProductionNormItemNo.Split('.');
                if (itemFirstNos.Length > 0)
                {
                    oldNo = itemFirstNos[0];
                }

                //Replace ProductionNormItemNo
                ReplaceProductionNormItemNo(entity.ProductionNormItemList, oldNo, parentProductNo);
                //foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                //{
                //    item.MMProductionNormItemNo = item.MMProductionNormItemNo.Replace(oldNo, parentProductNo);
                //    if (!string.IsNullOrEmpty(item.MMProductionNormItemParentNo))
                //    {
                //        item.MMProductionNormItemParentNo = item.MMProductionNormItemParentNo.Replace(oldNo, parentProductNo);
                //    }
                //    if (item.SubList != null && item.SubList.Count > 0)
                //    {
                //        foreach (MMProductionNormItemsInfo subItem in item.SubList)
                //        {
                //            subItem.MMProductionNormItemNo = subItem.MMProductionNormItemNo.Replace(oldNo, parentProductNo);
                //            if (!string.IsNullOrEmpty(subItem.MMProductionNormItemParentNo))
                //            {
                //                subItem.MMProductionNormItemParentNo = subItem.MMProductionNormItemParentNo.Replace(oldNo, parentProductNo);
                //            }
                //        }
                //    }
                //}
                #endregion



                //#region Tạo cụm


                List<ICProductsInfo> sameNoProducts = objProductsController.GetProductByProductNo(parentProductNo, parentProductNo.Length);
                NewProductList(entity.ProductionNormItemList, sameNoProducts, objProductsController, objProductItemsController);

                //foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                //{
                //    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                //    if (objProductsInfo != null)
                //    {
                //        if (objProductsInfo.HasComponent)
                //        {
                //            List<ICProductsInfo> objSameNoProducts = objProductsController.GetExactProductByProductNo(item.MMProductionNormItemNo);
                //            if (objSameNoProducts == null || objSameNoProducts.Count == 0)
                //            {
                //                ICProductsInfo objNewGroupProductsInfo = new ICProductsInfo();
                //                BOSUtil.CopyObject(objProductsInfo, objNewGroupProductsInfo);
                //                objNewGroupProductsInfo.ICProductNo = item.MMProductionNormItemNo;
                //                objProductsController.CreateObject(objNewGroupProductsInfo);
                //                //Product items 
                //                List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(parentProductNo, parentProductNo.Length);

                //                foreach (ICProductsInfo productsInfo in sameNoProduct)
                //                {
                //                    ICProductItemsInfo productItem = new ICProductItemsInfo();
                //                    productItem.FK_ICProductItemParentID = productsInfo.ICProductID;
                //                    productItem.FK_ICProductItemChildID = objNewGroupProductsInfo.ICProductID;
                //                    productItem.ICProductItemQty = item.MMProductionNormItemQuantity;
                //                    objProductItemsController.CreateObject(productItem);
                //                }

                //                //Set FK_ICProductID 
                //                item.FK_ICProductID = objNewGroupProductsInfo.ICProductID;

                //            }
                //            else
                //            {
                //                item.FK_ICProductID = objSameNoProducts[0].ICProductID;

                //                string message = ProductionNormLocalizeResources.GroupExist.Replace("{0}", item.MMProductionNormItemNo);
                //                MessageBox.Show(message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            }
                //        }

                //    }
                //}
                ////#endregion
                ////#region Tạo chi tiết & chi tiết rời
                //foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemList)
                //{
                //    CreateProductDetail(item, parentProductNo, oldNo);
                //    if (item.SubList != null && item.SubList.Count > 0)
                //    {
                //        foreach (MMProductionNormItemsInfo subItem in item.SubList)
                //        {
                //            CreateProductDetail(subItem, parentProductNo, oldNo);
                //        }
                //    }
                //}
                //#endregion
                //#endregion
            }
            //#region Packing Material
            //if (entity.ProductionNormItemPackagingList != null && entity.ProductionNormItemPackagingList.Count > 0)
            //{
            //    #region Replace Item No
            //    MMProductionNormItemsInfo itemFirst = (MMProductionNormItemsInfo)entity.ProductionNormItemPackagingList[0];
            //    string oldNo = string.Empty;
            //    string[] itemFirstNos = itemFirst.MMProductionNormItemNo.Split('.');
            //    if (itemFirstNos.Length > 1)
            //    {
            //        oldNo = itemFirstNos[1];
            //    }
            //    foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
            //    {
            //        item.MMProductionNormItemNo = item.MMProductionNormItemNo.Replace(oldNo, parentProductNo);
            //        if (!string.IsNullOrEmpty(item.MMProductionNormItemParentNo))
            //        {
            //            item.MMProductionNormItemParentNo = item.MMProductionNormItemParentNo.Replace(oldNo, parentProductNo);
            //        }
            //        if (item.SubList != null && item.SubList.Count > 0)
            //        {
            //            foreach (MMProductionNormItemsInfo subItem in item.SubList)
            //            {
            //                subItem.MMProductionNormItemNo = subItem.MMProductionNormItemNo.Replace(oldNo, parentProductNo);
            //                if (!string.IsNullOrEmpty(subItem.MMProductionNormItemParentNo))
            //                {
            //                    subItem.MMProductionNormItemParentNo = subItem.MMProductionNormItemParentNo.Replace(oldNo, parentProductNo);
            //                }
            //            }
            //        }
            //    }
            //    #endregion
            //    #region Tạo cụm

            //    foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
            //    {
            //        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            //        if (objProductsInfo != null)
            //        {
            //            if (objProductsInfo.HasComponent)
            //            {
            //                List<ICProductsInfo> objSameNoProducts = objProductsController.GetExactProductByProductNo(item.MMProductionNormItemNo);
            //                if (objSameNoProducts == null || objSameNoProducts.Count == 0)
            //                {
            //                    ICProductsInfo objNewGroupProductsInfo = new ICProductsInfo();
            //                    BOSUtil.CopyObject(objProductsInfo, objNewGroupProductsInfo);
            //                    objNewGroupProductsInfo.ICProductNo = item.MMProductionNormItemNo;
            //                    objProductsController.CreateObject(objNewGroupProductsInfo);
            //                    //Product items 
            //                    List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(parentProductNo, parentProductNo.Length);

            //                    foreach (ICProductsInfo productsInfo in sameNoProduct)
            //                    {
            //                        ICProductItemsInfo productItem = new ICProductItemsInfo();
            //                        productItem.FK_ICProductItemParentID = productsInfo.ICProductID;
            //                        productItem.FK_ICProductItemChildID = objNewGroupProductsInfo.ICProductID;
            //                        productItem.ICProductItemQty = item.MMProductionNormItemQuantity;
            //                        objProductItemsController.CreateObject(productItem);
            //                    }

            //                    //Set FK_ICProductID 
            //                    item.FK_ICProductID = objNewGroupProductsInfo.ICProductID;

            //                }
            //                else
            //                {
            //                    item.FK_ICProductID = objSameNoProducts[0].ICProductID;

            //                    string message = ProductionNormLocalizeResources.GroupExist.Replace("{0}", item.MMProductionNormItemNo);
            //                    MessageBox.Show(message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //            }

            //        }
            //    }
            //    //#endregion
            //    //#region Tạo chi tiết & chi tiết rời
            //    foreach (MMProductionNormItemsInfo item in entity.ProductionNormItemPackagingList)
            //    {
            //        CreateProductDetail(item, parentProductNo, oldNo);
            //        if (item.SubList != null && item.SubList.Count > 0)
            //        {
            //            foreach (MMProductionNormItemsInfo subItem in item.SubList)
            //            {
            //                CreateProductDetail(subItem, parentProductNo, oldNo);
            //            }
            //        }
            //    }
            //    #endregion
            //#endregion

            //}

            entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
            // entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
            CreateNewDetailEdit.Visible = false;
        }
        public void CreateProductDetail(MMProductionNormItemsInfo item, string parentProductNo, string oldNo)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductItemsController objProductItemsController = new ICProductItemsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            if (objProductsInfo != null)
            {
                if (!objProductsInfo.HasComponent)
                {

                    List<ICProductsInfo> objSameNoProducts = objProductsController.GetExactProductByProductNo(item.MMProductionNormItemNo);

                    if (objSameNoProducts == null || objSameNoProducts.Count == 0) // Chi tiết thuộc cụm
                    {
                        List<ICProductsInfo> objOldSameNoProducts = objProductsController.GetExactProductByProductNo(oldNo);
                        ICProductsInfo objOldProductsInfo = new ICProductsInfo();
                        foreach (ICProductsInfo objProduct in objOldSameNoProducts)
                        {
                            if (objProduct.ICProductType == ProductType.Product.ToString())
                            {
                                objOldProductsInfo = objProduct;
                                break;
                            }
                        }
                        ICProductItemsInfo objProductItemsInfo = objProductItemsController.GetProductItemByParentIDAndChildID(objOldProductsInfo.ICProductID, item.FK_ICProductID);
                        if (objProductItemsInfo == null)//Chi tiết thuộc cụm
                        {
                            ICProductsInfo newDetailProductsInfo = new ICProductsInfo();
                            BOSUtil.CopyObject(objProductsInfo, newDetailProductsInfo);
                            newDetailProductsInfo.ICProductNo = item.MMProductionNormItemNo;
                            objProductsController.CreateObject(newDetailProductsInfo);
                            //Tạo productItem của chi tiết
                            ICProductItemsInfo productItem = new ICProductItemsInfo();



                            productItem.FK_ICProductItemChildID = newDetailProductsInfo.ICProductID;
                            string[] newNos = item.MMProductionNormItemNo.Split('.');
                            string parentNo = string.Empty;
                            for (int i = 0; i < newNos.Length - 1; i++)
                            {
                                if (!string.IsNullOrEmpty(parentNo))
                                {
                                    parentNo += ".";
                                }
                                parentNo += newNos[i];
                            }
                            ICProductsInfo objParentProduct = (ICProductsInfo)objProductsController.GetObjectByNo(parentNo);
                            ICProductsInfo objOldParentProduct = new ICProductsInfo();
                            string[] oldNos = objProductsInfo.ICProductNo.Split('.');
                            string oldParentNo = string.Empty;
                            for (int i = 0; i < oldNos.Length - 1; i++)
                            {
                                if (!string.IsNullOrEmpty(oldParentNo))
                                {
                                    oldParentNo += ".";
                                }
                                oldParentNo += oldNos[i];
                            }
                            objOldParentProduct = (ICProductsInfo)objProductsController.GetObjectByNo(oldParentNo);
                            if (objParentProduct == null)
                            {
                                objParentProduct = new ICProductsInfo();
                                BOSUtil.CopyObject(objOldParentProduct, objParentProduct);
                                objParentProduct.ICProductNo = parentNo;
                                objProductsController.CreateObject(objParentProduct);

                                List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(parentProductNo, parentProductNo.Length);
                                List<ICProductsInfo> objOldSameNoProducts3 = objProductsController.GetExactProductByProductNo(oldNo);
                                if (objOldSameNoProducts3 != null && objOldSameNoProducts3.Count > 0)
                                {
                                    foreach (ICProductsInfo productsInfo in sameNoProduct)
                                    {
                                        ICProductItemsInfo productItem2 = new ICProductItemsInfo();
                                        productItem2.FK_ICProductItemParentID = productsInfo.ICProductID;
                                        productItem2.FK_ICProductItemChildID = objParentProduct.ICProductID;
                                        productItem2.ICProductItemQty = item.MMProductionNormItemQuantity;
                                        objProductItemsController.CreateObject(productItem2);
                                    }
                                }


                            }

                            if (objParentProduct != null)
                            {

                                productItem.FK_ICProductItemParentID = objParentProduct.ICProductID;

                                if (objOldParentProduct != null)
                                {
                                    ICProductItemsInfo objProductItemsInfo2 = objProductItemsController.GetProductItemByParentIDAndChildID(objOldParentProduct.ICProductID, item.FK_ICProductID);
                                    if (objProductItemsInfo2 != null)
                                    {
                                        productItem.ICProductItemQty = item.MMProductionNormItemQuantity;
                                        productItem.ICProductItemSortOrder = objProductItemsInfo2.ICProductItemSortOrder;
                                    }
                                }
                                objProductItemsController.CreateObject(productItem);
                            }




                            //FK_ICProductID
                            item.FK_ICProductID = newDetailProductsInfo.ICProductID;
                        }
                        else//Chi tiết rời
                        {
                            ICProductsInfo objNewGroupProductsInfo = new ICProductsInfo();
                            BOSUtil.CopyObject(objProductsInfo, objNewGroupProductsInfo);
                            objNewGroupProductsInfo.ICProductNo = item.MMProductionNormItemNo;
                            objProductsController.CreateObject(objNewGroupProductsInfo);
                            //Product items 
                            List<ICProductsInfo> sameNoProduct = objProductsController.GetProductByProductNo(parentProductNo, parentProductNo.Length);

                            foreach (ICProductsInfo productsInfo in sameNoProduct)
                            {
                                ICProductItemsInfo productItem = new ICProductItemsInfo();
                                productItem.FK_ICProductItemParentID = productsInfo.ICProductID;
                                productItem.FK_ICProductItemChildID = objNewGroupProductsInfo.ICProductID;
                                productItem.ICProductItemQty = item.MMProductionNormItemQuantity;
                                objProductItemsController.CreateObject(productItem);
                            }

                            //Set FK_ICProductID 
                            item.FK_ICProductID = objNewGroupProductsInfo.ICProductID;
                        }
                    }
                    else
                    {
                        item.FK_ICProductID = objSameNoProducts[0].ICProductID;
                        bool isExist = false;
                        ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                        if (item.MMProductionNormItemGroup == ProductType.IngredientPackaging.ToString())
                        {
                            foreach (MMProductionNormItemsInfo pItem in entity.ProductionNormItemPackagingList)
                            {
                                if (pItem.MMProductionNormItemNo == item.MMProductionNormItemNo)
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            foreach (MMProductionNormItemsInfo pItem in entity.ProductionNormItemList)
                            {
                                if (pItem.MMProductionNormItemNo == item.MMProductionNormItemNo)
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                        }
                        if (!isExist)
                        {
                            string message = ProductionNormLocalizeResources.DetailExist.Replace("{0}", item.MMProductionNormItemNo);
                            MessageBox.Show(message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
        #endregion

        public void CancelCreateItem()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.SemiProductListChild.GridControl != null)
            {
                if (entity.SemiProductListChild[entity.SemiProductListChild.CurrentIndex] != null)
                {
                    if (entity.SemiProductListChild[entity.SemiProductListChild.CurrentIndex].ICProductID == 0)
                    {
                        entity.SemiProductListChild.RemoveAt(entity.SemiProductListChild.CurrentIndex);
                    }
                }
                entity.SemiProductListChild.GridControl.RefreshDataSource();
            }
        }
        #region Report
        /// <summary>
        /// Print production norm
        /// </summary>
        /// <param name="productType">productType</param>
        public void PrintProductionNorm(string productType, bool diffModule)
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0) || diffModule)
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                List<MMProductionNormsInfo> productionNormList = new List<MMProductionNormsInfo>();
                //MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                MMProductionNormsController productionNormController = new MMProductionNormsController();
                MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;
                //init report display data
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    //ICProductNo
                    objProductionNormsInfo.MMProductionNormProductNo = objProductsInfo.ICProductNo;
                    //ICProductName
                    objProductionNormsInfo.MMProductionNormICProductName = objProductsInfo.ICProductName;

                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormComponentStatus, objProductionNormsInfo.MMProductionNormPackingMaterialStatus);
                    //set ProductionNorm component status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatusValue = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormStatus, objProductionNormsInfo.MMProductionNormWoodStatus);
                    //set ProductionNorm status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormWoodStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormWoodStatusText = GetProductioNormConfigText(objConfigValuesInfo);
                    }

                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set Create User
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormCreateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    if (productType == ProductType.SemiProduct.ToString())
                    {
                        //set validate user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeWoodValidate);
                        if (objEmployeesInfo != null)
                        {
                            objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                        }
                        //set approve user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeWoodApprove);
                        if (objEmployeesInfo != null)
                        {
                            objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                        }
                    }
                    else if (productType == ProductType.Hardware.ToString())
                    {
                        //set validate user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeHardwareValidate);
                        if (objEmployeesInfo != null)
                            objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                        //set Approve user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeHardwareApprove);
                        if (objEmployeesInfo != null)
                            objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }
                    else if (productType == ProductType.IngredientPackaging.ToString())
                    {
                        //set validate user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePackingMaterialValidate);
                        if (objEmployeesInfo != null)
                            objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                        //set Approve user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePackingMaterialApprove);
                        if (objEmployeesInfo != null)
                            objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }
                    else if (productType == ProductType.IngredientPaint.ToString())
                    {
                        //set validate user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePaintValidate);
                        if (objEmployeesInfo != null)
                            objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                        //set Approve user
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePaintApprove);
                        if (objEmployeesInfo != null)
                            objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }
                    else
                    {

                    }
                }

                List<MMProductionNormItemsInfo> productionNormItemList = new List<MMProductionNormItemsInfo>();
                List<MMProductionNormItemsInfo> productionNormItemDataSource = new List<MMProductionNormItemsInfo>();
                List<MMProductionNormItemsInfo> productionNormItemHardwareDataSource = new List<MMProductionNormItemsInfo>();
                List<MMProductionNormItemsInfo> productionNormItemPackagingDataSource = new List<MMProductionNormItemsInfo>();
                List<MMProductionNormItemsInfo> productionNormItemPaintDataSource = new List<MMProductionNormItemsInfo>();
                productionNormItemList = GetListFromProductionNormItemTreeList(entity.ProductionNormItemList);
                productionNormItemHardwareDataSource = GetListFromProductionNormItemTreeList(entity.ProductionNormItemHardwareList);
                productionNormItemPackagingDataSource = GetListFromProductionNormItemTreeList(entity.ProductionNormItemPackagingList);
                //productionNormItemPaintDataSource = GetListFromProductionNormItemTreeList(entity.ProductionNormItemPaintList);
                MMProductionNormItemsController itemController = new MMProductionNormItemsController();
                productionNormItemPaintDataSource = itemController.GetPaintForPrint(objProductionNormsInfo.MMProductionNormID);

                if (productionNormItemPackagingDataSource != null)
                {
                    ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                    foreach (MMProductionNormItemsInfo item in productionNormItemPackagingDataSource)
                    {
                        //MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                        if (!(item.MMProductionNormItemProductOverallDimensionWidth == 0
                            && item.MMProductionNormItemProductOverallDimensionLength == 0
                            && item.MMProductionNormItemProductOverallDimensionHeight == 0))
                        {
                            item.MMProductionNormItemProductOverallDimension = item.MMProductionNormItemProductOverallDimensionLength.ToString("N2") + "x"
                                + item.MMProductionNormItemProductOverallDimensionWidth.ToString("N2") + "x"
                                + item.MMProductionNormItemProductOverallDimensionHeight.ToString("N2");

                        }

                        if (!(item.MMProductionNormItemProductInsideDimensionWidth == 0
                            && item.MMProductionNormItemProductInsideDimensionLength == 0
                            && item.MMProductionNormItemProductInsideDimensionHeight == 0))
                        {
                            item.MMProductionNormItemProductInsideDimension = item.MMProductionNormItemProductInsideDimensionLength.ToString("N2") + "x"
                            + item.MMProductionNormItemProductInsideDimensionWidth.ToString("N2") + "x"
                            + item.MMProductionNormItemProductInsideDimensionHeight.ToString("N2");
                        }

                        #region Description
                        item.MMBatchProductProductionNormItemProductDesc = string.Empty;
                        if (!string.IsNullOrEmpty(item.MMProductionNormItemProductName))
                        {

                            item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductName;
                        }
                        if (!(item.MMProductionNormItemProductInsideDimensionWidth == 0
                            && item.MMProductionNormItemProductInsideDimensionLength == 0
                            && item.MMProductionNormItemProductInsideDimensionHeight == 0))
                        {
                            if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                            {
                                item.MMBatchProductProductionNormItemProductDesc += ", ";
                            }
                            item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductInsideDimensionLength + "x"
                            + item.MMProductionNormItemProductInsideDimensionWidth + "x"
                            + item.MMProductionNormItemProductInsideDimensionHeight;
                        }
                        if (!(item.MMProductionNormItemProductOverallDimensionWidth == 0
                            && item.MMProductionNormItemProductOverallDimensionLength == 0
                            && item.MMProductionNormItemProductOverallDimensionHeight == 0))
                        {
                            if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                            {
                                item.MMBatchProductProductionNormItemProductDesc += ", ";
                            }
                            item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductOverallDimensionLength + "x"
                                + item.MMProductionNormItemProductOverallDimensionWidth + "x"
                                + item.MMProductionNormItemProductOverallDimensionHeight;
                        }

                        if (item.MMProductionNormItemProductSizeAndPacking != null)
                        {
                            if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                            {
                                item.MMBatchProductProductionNormItemProductDesc += ", ";
                            }
                            item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductSizeAndPacking;
                        }
                        if (item.FK_ICProdAttPackingMaterialSpecialityID > 0)
                        {
                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSpecialityID);
                            if (objAttribute != null)
                            {
                                if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                                {
                                    item.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                item.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue;
                            }
                        }
                        if (item.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                        {
                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                            if (objAttribute != null)
                            {
                                if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                                {
                                    item.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                item.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue;
                            }
                        }
                        if (item.FK_ICProdAttPackingMaterialSizeID > 0)
                        {
                            ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSizeID);
                            if (objAttribute != null)
                            {
                                if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                                {
                                    item.MMBatchProductProductionNormItemProductDesc += ", ";
                                }
                                item.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue;
                            }
                        }
                        #endregion
                    }
                }
                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPProductionNorm report = new RPProductionNorm(productionNormItemTotalQty);
                //TNDLoc [ADD][06/01/2015][Set Attribute],START
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();

                productionNormItemList = productionNormItemList.OrderBy(x => x.MMProductionNormItemNo).ToList();
                int count = 1;
                foreach (MMProductionNormItemsInfo item in productionNormItemList)
                {
                    int order = 0;
                    if (int.TryParse(item.MMProductionNormItemSortOrderString, out order))
                    {
                        if (order > 0)
                        {
                            item.MMProductionNormItemSortOrderString = count.ToString();
                            count++;
                        }
                    }
                    ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(item.FK_ICProductAttributeSpecialityID);
                    if (objAttributesInfo != null)
                    {
                        item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                    }
                }
                //TNDLoc [ADD][06/01/2015][Set Attribute],END
                report.bindingSource1.DataSource = productionNormItemList;
                report.bindingSource2.DataSource = productionNormItemHardwareDataSource;
                report.bindingSource3.DataSource = productionNormItemPaintDataSource;
                report.bindingSource4.DataSource = productionNormItemPackagingDataSource;
                report.bindingSource6.DataSource = entity.GeneralMaterialList;
                if (objProductionNormsInfo != null)
                {
                    //set ProductionNorm type
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                    }
                    productionNormList.Add(objProductionNormsInfo);
                }
                report.bindingSource5.DataSource = productionNormList;
                //enable report detail
                // EnableReportDetail(report,productType);
                report.ProductionNormItemPaintA = GetSumProductionNormItemPaintA();
                report.ProductionNormItemPaintB = GetSumProductionNormItemPaintB();
                report.ProductionNormItemWoodBlocks = GetSumProductionNormItemBlocks();
                report.ProductionNormItemPaintTotalWoodConsumable = GetSumProductionNormItemWoodConsumable();

                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                //ActionCancel();
            }
        }
        public List<MMProductionNormItemsInfo> GetListFromProductionNormItemTreeList(BOSTreeList ProductionNormItemList)
        {
            List<MMProductionNormItemsInfo> productionNormItemsList = new List<MMProductionNormItemsInfo>();
            foreach (MMProductionNormItemsInfo item in ProductionNormItemList)
            {
                productionNormItemsList.Add(item);
                if (item.MMProductionNormItemIsComponent && item.SubList != null)
                {
                    item.MMProductionNormItemParentOrderName = item.MMProductionNormItemProductName;
                    foreach (MMProductionNormItemsInfo itemChild in item.SubList)
                    {
                        productionNormItemsList.Add(itemChild);
                    }
                }
            }
            return productionNormItemsList;
        }
        /// <summary>
        /// Print semi product
        /// </summary>
        public void PrintSemiProduct()
        {
            //PrintProductionNorm(ProductType.SemiProduct.ToString(), false);
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                if (!HaveFocusWood)
                {
                    //InvalidateProductionNormItemByProductType(ProductType.SemiProduct);
                    InvalidateWoodTreeList();
                }
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                List<MMProductionNormsInfo> productionNormList = new List<MMProductionNormsInfo>();
                MMProductionNormsController productionNormController = new MMProductionNormsController();
                MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;
                List<MMProductionNormItemsInfo> productionNormItemList = new List<MMProductionNormItemsInfo>();
                productionNormItemList = GetListFromProductionNormItemTreeList(entity.ProductionNormItemList);
                //init report display data
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    //ICProductNo
                    objProductionNormsInfo.MMProductionNormProductNo = objProductsInfo.ICProductNo;
                    //ICProductName
                    objProductionNormsInfo.MMProductionNormICProductName = objProductsInfo.ICProductName;

                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormComponentStatus, objProductionNormsInfo.MMProductionNormPackingMaterialStatus);
                    //set ProductionNorm component status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatusValue = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormStatus, objProductionNormsInfo.MMProductionNormWoodStatus);
                    //set ProductionNorm status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormWoodStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormWoodStatusText = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    //set ProductionNorm type
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                    }
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set Create User
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormCreateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set validate user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeWoodValidate);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set approve user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeWoodApprove);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }

                }

                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPProductionNorm report = new RPProductionNorm(productionNormItemTotalQty);
                //TNDLoc [ADD][06/01/2015][Set Attribute],START
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                productionNormItemList = productionNormItemList.OrderBy(x => x.MMProductionNormItemNo).ToList();
                int count = 1;
                foreach (MMProductionNormItemsInfo item in productionNormItemList)
                {
                    int order = 0;
                    if (int.TryParse(item.MMProductionNormItemSortOrderString, out order))
                    {
                        if (order > 0)
                        {
                            item.MMProductionNormItemSortOrderString = count.ToString();
                            count++;
                        }
                    }
                    ICProductAttributesInfo objAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(item.FK_ICProductAttributeSpecialityID);
                    if (objAttributesInfo != null)
                    {
                        item.AttributeName = objAttributesInfo.ICProductAttributeValue;
                    }
                }
                //TNDLoc [ADD][06/01/2015][Set Attribute],END
                report.bindingSource1.DataSource = productionNormItemList;
                report.bindingSource5.DataSource = objProductionNormsInfo;
                EnableReportDetail(report, ProductType.SemiProduct.ToString());
                report.ProductionNormItemPaintA = GetSumProductionNormItemPaintA();
                report.ProductionNormItemPaintB = GetSumProductionNormItemPaintB();
                report.ProductionNormItemWoodBlocks = GetSumProductionNormItemBlocks();
                report.ProductionNormItemPaintTotalWoodConsumable = GetSumProductionNormItemWoodConsumable();
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                //ActionCancel();
            }
        }
        /// <summary>
        /// Print semi hardware
        /// </summary>
        public void PrintHardware()
        {
            //PrintProductionNorm(ProductType.Hardware.ToString(), false);
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                if (!HaveFocusHardware)
                {
                    InvalidateProductionNormItemByProductType(ProductType.Hardware);
                }
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                List<MMProductionNormsInfo> productionNormList = new List<MMProductionNormsInfo>();
                MMProductionNormsController productionNormController = new MMProductionNormsController();
                MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;
                List<MMProductionNormItemsInfo> productionNormHardwareList = new List<MMProductionNormItemsInfo>();
                productionNormHardwareList = GetListFromProductionNormItemTreeList(entity.ProductionNormItemHardwareList);

                //init report display data
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    //ICProductNo
                    objProductionNormsInfo.MMProductionNormProductNo = objProductsInfo.ICProductNo;
                    //ICProductName
                    objProductionNormsInfo.MMProductionNormICProductName = objProductsInfo.ICProductName;

                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormComponentStatus, objProductionNormsInfo.MMProductionNormPackingMaterialStatus);
                    //set ProductionNorm component status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatusValue = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormStatus, objProductionNormsInfo.MMProductionNormWoodStatus);
                    //set ProductionNorm status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormWoodStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormWoodStatusText = GetProductioNormConfigText(objConfigValuesInfo);
                    }

                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set Create User
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormCreateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set validate user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeHardwareValidate);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set approve user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeHardwareApprove);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set ProductionNorm type
                    //objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                    //if (objConfigValuesInfo != null)
                    //{
                    //    objProductionNormsInfo.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                    //}

                }

                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPProductionNorm report = new RPProductionNorm(productionNormItemTotalQty);
                report.bindingSource2.DataSource = productionNormHardwareList;
                report.bindingSource5.DataSource = objProductionNormsInfo;
                //enablereport
                EnableReportDetail(report, ProductType.Hardware.ToString());
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                //ActionCancel();
            }
        }
        public void PrintMaterial()
        {
            //PrintProductionNorm(ProductType.Hardware.ToString(), false);
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                if (!HaveFocusGeneralMaterial)
                {
                    InvalidateProductionNormItemByProductType(ProductType.GeneralMaterial);
                }
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                List<MMProductionNormsInfo> productionNormList = new List<MMProductionNormsInfo>();
                MMProductionNormsController productionNormController = new MMProductionNormsController();
                MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;

                //init report display data
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    //ICProductNo
                    objProductionNormsInfo.MMProductionNormProductNo = objProductsInfo.ICProductNo;
                    //ICProductName
                    objProductionNormsInfo.MMProductionNormICProductName = objProductsInfo.ICProductName;

                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormComponentStatus, objProductionNormsInfo.MMProductionNormPackingMaterialStatus);
                    //set ProductionNorm component status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatusValue = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormStatus, objProductionNormsInfo.MMProductionNormWoodStatus);
                    //set ProductionNorm status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormWoodStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormWoodStatusText = GetProductioNormConfigText(objConfigValuesInfo);
                    }

                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set Create User
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormCreateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set validate user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeHardwareValidate);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set approve user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeHardwareApprove);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }
                }

                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPProductionNorm report = new RPProductionNorm(productionNormItemTotalQty);
                report.bindingSource6.DataSource = entity.GeneralMaterialList;
                report.bindingSource5.DataSource = objProductionNormsInfo;
                //enablereport
                EnableReportDetail(report, ProductType.GeneralMaterial.ToString());
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                //ActionCancel();
            }
        }
        /// <summary>
        /// Print semi paint
        /// </summary>
        public void PrintPaint()
        {
            //PrintProductionNorm(ProductType.IngredientPaint.ToString(), false);
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                if (!HaveFocusPaint)
                {
                    InvalidateProductionNormItemByProductType(ProductType.IngredientPaint);
                }
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                List<MMProductionNormsInfo> productionNormList = new List<MMProductionNormsInfo>();
                MMProductionNormsController productionNormController = new MMProductionNormsController();
                MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;
                List<MMProductionNormItemsInfo> productionNormPrintPaintList = new List<MMProductionNormItemsInfo>();
                MMProductionNormItemsController itemController = new MMProductionNormItemsController();
                productionNormPrintPaintList = itemController.GetPaintForPrint(objProductionNormsInfo.MMProductionNormID);
                //init report display data
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    //ICProductNo
                    objProductionNormsInfo.MMProductionNormProductNo = objProductsInfo.ICProductNo;
                    //ICProductName
                    objProductionNormsInfo.MMProductionNormICProductName = objProductsInfo.ICProductName;

                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormComponentStatus, objProductionNormsInfo.MMProductionNormPackingMaterialStatus);
                    //set ProductionNorm component status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatusValue = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormStatus, objProductionNormsInfo.MMProductionNormWoodStatus);
                    //set ProductionNorm status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormWoodStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormWoodStatusText = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    //set ProductionNorm type
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                    }
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set Create User
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormCreateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set validate user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePaintValidate);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set approve user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePaintApprove);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }

                }
                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPProductionNorm report = new RPProductionNorm(productionNormItemTotalQty);
                report.bindingSource3.DataSource = productionNormPrintPaintList;
                report.bindingSource5.DataSource = objProductionNormsInfo;
                //enablereport
                EnableReportDetail(report, ProductType.IngredientPaint.ToString());
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                //ActionCancel();
            }
        }
        /// <summary>
        /// Print semi packaging
        /// </summary>
        public void PrintPackaging()
        {
            //PrintProductionNorm(ProductType.IngredientPackaging.ToString(), false);
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                if (!HaveFocusPackaging)
                {
                    InvalidateProductionNormItemByProductType(ProductType.IngredientPackaging);
                }
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                List<MMProductionNormsInfo> productionNormList = new List<MMProductionNormsInfo>();
                MMProductionNormsController productionNormController = new MMProductionNormsController();
                MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;
                List<MMProductionNormItemsInfo> productionNormPrintPackagingList = new List<MMProductionNormItemsInfo>();
                productionNormPrintPackagingList = GetListFromProductionNormItemTreeList(entity.ProductionNormItemPackagingList);

                //init report display data
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    //ICProductNo
                    objProductionNormsInfo.MMProductionNormProductNo = objProductsInfo.ICProductNo;
                    //ICProductName
                    objProductionNormsInfo.MMProductionNormICProductName = objProductsInfo.ICProductName;

                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormComponentStatus, objProductionNormsInfo.MMProductionNormPackingMaterialStatus);
                    //set ProductionNorm component status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatusValue = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormStatus, objProductionNormsInfo.MMProductionNormWoodStatus);
                    //set ProductionNorm status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormWoodStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormWoodStatusText = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    //set ProductionNorm type
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormType = objConfigValuesInfo.ADConfigText;
                    }
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set Create User
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormCreateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set validate user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePackingMaterialValidate);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                    }
                    //set approve user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeePackingMaterialApprove);
                    if (objEmployeesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                    }

                }

                if (productionNormPrintPackagingList != null)
                {
                    ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                    foreach (MMProductionNormItemsInfo item in productionNormPrintPackagingList)
                    {
                        //MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                        if (!(item.MMProductionNormItemProductOverallDimensionWidth == 0
                            && item.MMProductionNormItemProductOverallDimensionLength == 0
                            && item.MMProductionNormItemProductOverallDimensionHeight == 0))
                        {
                            item.MMProductionNormItemProductOverallDimension = item.MMProductionNormItemProductOverallDimensionLength.ToString("N2") + "x"
                                + item.MMProductionNormItemProductOverallDimensionWidth.ToString("N2") + "x"
                                + item.MMProductionNormItemProductOverallDimensionHeight.ToString("N2");

                        }

                        if (!(item.MMProductionNormItemProductInsideDimensionWidth == 0
                            && item.MMProductionNormItemProductInsideDimensionLength == 0
                            && item.MMProductionNormItemProductInsideDimensionHeight == 0))
                        {
                            item.MMProductionNormItemProductInsideDimension = item.MMProductionNormItemProductInsideDimensionLength.ToString("N2") + "x"
                            + item.MMProductionNormItemProductInsideDimensionWidth.ToString("N2") + "x"
                            + item.MMProductionNormItemProductInsideDimensionHeight.ToString("N2");
                        }

                        #region Description
                        item.MMBatchProductProductionNormItemProductDesc = item.MMProductionNormItemProductDesc;
                        //if (!string.IsNullOrEmpty(item.MMProductionNormItemProductName))
                        //{

                        //    item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductName;
                        //}
                        //if (!(item.MMProductionNormItemProductInsideDimensionWidth == 0
                        //    && item.MMProductionNormItemProductInsideDimensionLength == 0
                        //    && item.MMProductionNormItemProductInsideDimensionHeight == 0))
                        //{
                        //    if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                        //    {
                        //        item.MMBatchProductProductionNormItemProductDesc += ", ";
                        //    }
                        //    item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductInsideDimensionLength + "x"
                        //    + item.MMProductionNormItemProductInsideDimensionWidth + "x"
                        //    + item.MMProductionNormItemProductInsideDimensionHeight;
                        //}
                        //if (!(item.MMProductionNormItemProductOverallDimensionWidth == 0
                        //    && item.MMProductionNormItemProductOverallDimensionLength == 0
                        //    && item.MMProductionNormItemProductOverallDimensionHeight == 0))
                        //{
                        //    if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                        //    {
                        //        item.MMBatchProductProductionNormItemProductDesc += ", ";
                        //    }
                        //    item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductOverallDimensionLength + "x"
                        //        + item.MMProductionNormItemProductOverallDimensionWidth + "x"
                        //        + item.MMProductionNormItemProductOverallDimensionHeight;
                        //}

                        //if (item.MMProductionNormItemProductSizeAndPacking != null)
                        //{
                        //    if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                        //    {
                        //        item.MMBatchProductProductionNormItemProductDesc += ", ";
                        //    }
                        //    item.MMBatchProductProductionNormItemProductDesc += item.MMProductionNormItemProductSizeAndPacking;
                        //}
                        //if (item.FK_ICProdAttPackingMaterialSpecialityID > 0)
                        //{
                        //    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSpecialityID);
                        //    if (objAttribute != null)
                        //    {
                        //        if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                        //        {
                        //            item.MMBatchProductProductionNormItemProductDesc += ", ";
                        //        }
                        //        item.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue;
                        //    }
                        //}
                        //if (item.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                        //{
                        //    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                        //    if (objAttribute != null)
                        //    {
                        //        if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                        //        {
                        //            item.MMBatchProductProductionNormItemProductDesc += ", ";
                        //        }
                        //        item.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue;
                        //    }
                        //}
                        //if (item.FK_ICProdAttPackingMaterialSizeID > 0)
                        //{
                        //    ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSizeID);
                        //    if (objAttribute != null)
                        //    {
                        //        if (!string.IsNullOrEmpty(item.MMBatchProductProductionNormItemProductDesc))
                        //        {
                        //            item.MMBatchProductProductionNormItemProductDesc += ", ";
                        //        }
                        //        item.MMBatchProductProductionNormItemProductDesc += objAttribute.ICProductAttributeValue;
                        //    }
                        //}
                        #endregion
                    }
                }
                //get total item Qty        
                decimal productionNormItemTotalQty = GetSumProductionNormItemQty();
                RPProductionNorm report = new RPProductionNorm(productionNormItemTotalQty);
                report.bindingSource4.DataSource = productionNormPrintPackagingList;
                report.bindingSource5.DataSource = objProductionNormsInfo;
                //enablereport
                EnableReportDetail(report, ProductType.IngredientPackaging.ToString());
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
                //ActionCancel();
            }
        }
        /// <summary>
        /// Print all
        /// </summary>
        public void PrintAll()
        {
            if (!HaveFocusWood)
                InvalidateProductionNormItemByProductType(ProductType.SemiProduct);
            if (!HaveFocusPackaging)
                InvalidateProductionNormItemByProductType(ProductType.IngredientPackaging);
            if (!HaveFocusPaint)
                InvalidateProductionNormItemByProductType(ProductType.IngredientPaint);
            if (!HaveFocusHardware)
                InvalidateProductionNormItemByProductType(ProductType.Hardware);
            if (!HaveFocusGeneralMaterial)
            {
                InvalidateProductionNormItemByProductType(ProductType.GeneralMaterial);
            }
            PrintProductionNorm(string.Empty, false);
        }
        /// <summary>
        /// Print profile
        /// </summary>
        public void PrintProfile()
        {
            if ((Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0))
            {
                RPProductionNormProfile report = new RPProductionNormProfile();
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsController productionNormController = new MMProductionNormsController();
                MMProductionNormsInfo objProductionNormsInfo = productionNormController.GetObjectByID(Toolbar.CurrentObjectID) as MMProductionNormsInfo;
                //init report display data
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    //ICproductNo
                    objProductionNormsInfo.MMProductionNormProductNo = objProductsInfo.ICProductNo;
                    //ICProductName
                    objProductionNormsInfo.MMProductionNormICProductName = objProductsInfo.ICProductName;
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormComponentStatus, objProductionNormsInfo.MMProductionNormPackingMaterialStatus);
                    //set product status
                    if (objConfigValuesInfo != null)
                    {
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatus = GetProductioNormConfigText(objConfigValuesInfo);
                        objProductionNormsInfo.MMProductionNormPackingMaterialStatusValue = GetProductioNormConfigText(objConfigValuesInfo);
                    }
                    //set productionnorm status
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormStatus, objProductionNormsInfo.MMProductionNormWoodStatus);
                    if (objConfigValuesInfo != null)
                        objProductionNormsInfo.MMProductionNormWoodStatus = GetProductioNormConfigText(objConfigValuesInfo);
                    //set Productionnorm Stype
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ProductionNormConst.ProductionNormType, objProductionNormsInfo.MMProductionNormType);
                    if (objConfigValuesInfo != null)
                        objProductionNormsInfo.MMProductionNormType = objConfigValuesInfo.ADConfigText;

                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set Create user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                        objProductionNormsInfo.MMProductionNormCreateUserName = objEmployeesInfo.HREmployeeName;
                    //Set Validate user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeWoodValidate);
                    if (objEmployeesInfo != null)
                        objProductionNormsInfo.MMProductionNormValidateUserName = objEmployeesInfo.HREmployeeName;
                    //set Approve user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objProductionNormsInfo.FK_HREmployeeWoodApprove);
                    if (objEmployeesInfo != null)
                        objProductionNormsInfo.MMProductionNormApproveUserName = objEmployeesInfo.HREmployeeName;
                }
                report.bindingSource5.DataSource = objProductionNormsInfo;
                if (objProductionNormsInfo.MMProductionNormID > 0)
                    entity.ProfileManagementItemList.Invalidate(objProductionNormsInfo.MMProductionNormID);
                foreach (MMProfileManagementItemsInfo item in entity.ProfileManagementItemList)
                {
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                    //set validate user
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                        item.HREmployeeName = objEmployeesInfo.HREmployeeName;
                }
                report.bindingSource1.DataSource = entity.ProfileManagementItemList;
                guiReportPreview vierwer = new guiReportPreview(report);
                vierwer.Show();
                //ActionCancel();
            }
        }
        /// <summary>
        /// Get production norm config text
        /// </summary>
        /// <param name="objConfigValuesInfo"></param>
        /// <returns></returns>
        public string GetProductioNormConfigText(ADConfigValuesInfo objConfigValuesInfo)
        {
            string configText = string.Empty;
            if (objConfigValuesInfo.ADConfigKeyValue == MMProductionNormStatus.New.ToString())
                configText = ProductionNormLocalizeResources.MMProductionNormStatusNew;
            if (objConfigValuesInfo.ADConfigKeyValue == MMProductionNormStatus.Validated.ToString())
                configText = ProductionNormLocalizeResources.MMProductionNormStatusUnValidated;
            if (objConfigValuesInfo.ADConfigKeyValue == MMProductionNormStatus.Approved.ToString())
                configText = ProductionNormLocalizeResources.MMProductionNormStatusApproved;
            if (objConfigValuesInfo.ADConfigKeyValue == MMProductionNormStatus.UnApproved.ToString())
                configText = ProductionNormLocalizeResources.MMProductionNormStatusUnApproved;
            if (objConfigValuesInfo.ADConfigKeyValue == MMProductionNormStatus.Edit.ToString())
                configText = ProductionNormLocalizeResources.MMProductionNormStatusEdit;

            return configText;
        }
        /// <summary>
        /// Enable report detail
        /// </summary>
        /// <param name="report">report</param>
        /// <param name="productType">productType</param>
        public void EnableReportDetail(XtraReport report, string productType)
        {

            report.Bands[ProductType.SemiProduct.ToString()].Visible = false;
            report.Bands[ProductType.Hardware.ToString()].Visible = false;
            report.Bands[ProductType.IngredientPackaging.ToString()].Visible = false;
            report.Bands[ProductType.IngredientPaint.ToString()].Visible = false;
            report.Bands[ProductType.GeneralMaterial.ToString()].Visible = false;

            XRLabel pageHeader = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblPageHeader"];

            if (productType == ProductType.SemiProduct.ToString())
            {
                report.Bands[ProductType.SemiProduct.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = ProductionNormLocalizeResources.SemiProductReportText;
            }
            else if (productType == ProductType.Hardware.ToString())
            {
                report.Bands[ProductType.Hardware.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = ProductionNormLocalizeResources.HardwareReportText;
            }
            else if (productType == ProductType.IngredientPackaging.ToString())
            {
                report.Bands[ProductType.IngredientPackaging.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = ProductionNormLocalizeResources.PackagingReportText;
            }
            else if (productType == ProductType.IngredientPaint.ToString())
            {
                report.Bands[ProductType.IngredientPaint.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = ProductionNormLocalizeResources.PaintReportText;
            }
            else if (productType == ProductType.GeneralMaterial.ToString())
            {
                report.Bands[ProductType.GeneralMaterial.ToString()].Visible = true;
                if (pageHeader != null)
                    pageHeader.Text = ProductionNormLocalizeResources.MaterialReportText;
            }
            else
            {
                report.Bands[ProductType.SemiProduct.ToString()].Visible = true;
                report.Bands[ProductType.Hardware.ToString()].Visible = true;
                report.Bands[ProductType.IngredientPackaging.ToString()].Visible = true;
                report.Bands[ProductType.IngredientPaint.ToString()].Visible = true;
                report.Bands[ProductType.GeneralMaterial.ToString()].Visible = true;
            }

        }

        /// <summary>
        /// Load product image
        /// </summary>
        public void LoadProductImage()
        {
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            if (objProductionNormsInfo.FK_ICProductID > 0)
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
            objProductionNormsInfo.MMProductionNormProductPicture = objProductsInfo.ICProductPicture;

        }
        #endregion

        public void ShowProductDetails()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (objProductionNormsInfo != null)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProducsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormsInfo.FK_ICProductID);
                if (objProducsInfo != null)
                {
                    guiProductDetails productDetailGUI = new guiProductDetails(objProducsInfo);
                    productDetailGUI.Module = this;
                    productDetailGUI.Show();
                }
            }
        }

        #region Copy ProductionNormItem
        public void CopyProductionNormItemPaint()
        {
            CopyProductionNormItem("fld_tabPaint");
        }
        public void CopyProductionNormItemPackaging()
        {
            CopyProductionNormItem("fld_tabPackaging");
        }
        public void CopyProductionNormItem(string tabName)
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ActionEdit();
            }
            //string  = ProductionNormViewTabEdit.SelectedTabPage.Name;

            if (tabName == "fld_tabPackaging")
            {
                if (!HaveFocusPackaging)
                    InvalidateProductionNormItemByProductType(ProductType.IngredientPackaging);
            }
            else if (tabName == "fld_tabPaint")
            {
                if (!HaveFocusPaint)
                    InvalidateProductionNormItemByProductType(ProductType.IngredientPaint);
            }
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            List<MMProductionNormsInfo> objProductionNormList = objProductionNormsController.GetAllAliveProductionNorm();
            guiFind<MMProductionNormsInfo> guiFind = new guiFind<MMProductionNormsInfo>(TableName.MMProductionNormsTableName,
                                                                                        objProductionNormList,
                                                                                        this,
                                                                                        false);
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            BOSTreeList objTreeListResult = new BOSTreeList();
            objTreeListResult.InitBOSList(entity,
                                                null,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                int productionNormID = 0;
                if (int.TryParse(guiFind.Tag.ToString(), out productionNormID))
                {
                    MMProductionNormsInfo objProductionNormsInfo = objProductionNormList.FirstOrDefault(t => t.MMProductionNormID == productionNormID);
                    if (objProductionNormsInfo != null)
                    {
                        DataSet ds = new DataSet();
                        if (tabName == "fld_tabPackaging")
                        {
                            ds = objProductionNormItemsController.GetParentOjects(productionNormID, ProductType.IngredientPackaging.ToString());
                        }
                        else if (tabName == "fld_tabPaint")
                        {
                            ds = objProductionNormItemsController.GetParentOjects(productionNormID, ProductType.IngredientPaint.ToString());
                        }
                        objTreeListResult.Invalidate(ds);
                        ds.Dispose();
                        bool isChanged = false;
                        if (objTreeListResult.Count > 0)
                        {
                            if (tabName == "fld_tabPackaging")
                            {

                                foreach (MMProductionNormItemsInfo item in objTreeListResult)
                                {
                                    MMProductionNormItemsInfo newItem = new MMProductionNormItemsInfo();
                                    BOSUtil.CopyObject(item, newItem);
                                    newItem.SubList = new BOSTreeList();
                                    if (item.SubList != null && item.SubList.Count > 0)
                                    {
                                        foreach (MMProductionNormItemsInfo subItem in item.SubList)
                                        {
                                            MMProductionNormItemsInfo newSubItem = new MMProductionNormItemsInfo();
                                            BOSUtil.CopyObject(subItem, newSubItem);
                                            newItem.SubList.Add(newSubItem);
                                        }
                                    }

                                    entity.ProductionNormItemPackagingList.Add(newItem);

                                    ChangestatusToEdit(ProductType.IngredientPackaging.ToString());

                                    entity.ProductionNormItemPackagingList.TreeListControl.RefreshDataSource();
                                    entity.ProductionNormItemPackagingList.TreeListControl.ExpandAll();
                                    entity.ProductionNormItemPackagingList.TreeListControl.BestFitColumns();
                                }
                            }
                            else if (tabName == "fld_tabPaint")
                            {

                                List<string> keys = new List<string>();

                                foreach (MMProductionNormItemsInfo item in objTreeListResult)
                                {
                                    if (!keys.Contains(item.MMProductionNormItemProductDesc))
                                    {
                                        keys.Add(item.MMProductionNormItemProductDesc);
                                    }
                                }
                                foreach (string key in keys)
                                {
                                    MMProductionNormItemsInfo parent = new MMProductionNormItemsInfo();
                                    parent.MMProductionNormItemProductName = key;
                                    parent.SubList = new BOSTreeList();
                                    foreach (MMProductionNormItemsInfo item in objTreeListResult)
                                    {
                                        if (item.MMProductionNormItemProductDesc == key)
                                        {
                                            parent.MMProductionNormItemPaint = item.MMProductionNormItemPaint;
                                            parent.FK_MMPaintProcessesID = item.FK_MMPaintProcessesID;
                                            MMProductionNormItemsInfo newItem = new MMProductionNormItemsInfo();
                                            BOSUtil.CopyObject(item, newItem);
                                            newItem.SubList = new BOSTreeList();
                                            if (item.SubList != null && item.SubList.Count > 0)
                                            {
                                                foreach (MMProductionNormItemsInfo subItem in item.SubList)
                                                {
                                                    MMProductionNormItemsInfo newSubItem = new MMProductionNormItemsInfo();
                                                    BOSUtil.CopyObject(subItem, newSubItem);
                                                    newItem.SubList.Add(newSubItem);
                                                }
                                            }
                                            parent.SubList.Add(newItem);
                                        }
                                    }
                                    if (!IsExistPaintProcesses(parent.FK_MMPaintProcessesID))
                                    {
                                        entity.ProductionNormItemPaintList.Add(parent);
                                    }
                                }

                                isChanged = true;
                                ChangestatusToEdit(ProductType.IngredientPaint.ToString());
                                entity.ProductionNormItemPaintList.TreeListControl.RefreshDataSource();
                                entity.ProductionNormItemPaintList.TreeListControl.ExpandAll();
                                entity.ProductionNormItemPaintList.TreeListControl.BestFitColumns();
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region New From Norm
        public void GeneralSourceData(GridView gridView)
        {
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName != "Selected"
                    && column.FieldName != "MMNormTemplateIsStruct"
                    && column.FieldName != "MMNormTemplateItemIsComponent"
                    && column.FieldName != "MMNormTemplateItemProductQty"
                    && column.FieldName != "MMNormTemplateItemProductWidth"
                     && column.FieldName != "MMNormTemplateItemProductLength"
                    && column.FieldName != "MMNormTemplateItemComment")
                {
                    if (column.FieldName == "MMNormTemplateItemProductWoodType")
                    {
                        List<object> dataList = new List<object>();
                        string tableName = TableName.ICProductattributesTableName;
                        string fieldName = "ICProductAttributeValue";
                        string getTypeField1 = "ICProductAttributeGroup";
                        string getValue1 = "WoodType";
                        string getTypeField2 = string.Empty;
                        bool getValue2 = false;
                        string DisplayColumn = "ICProductAttributeValue";
                        dataList = GetDataFromLookupTable(tableName, fieldName, getTypeField1, getValue1, getTypeField2, getValue2, DisplayColumn);
                        GenerateSearchChiTiet(column, dataList);
                    }
                    else
                    {
                        List<object> dataList = new List<object>();
                        dataList = GetDataFromTemplate(column.FieldName);
                        GenerateSearchChiTiet(column, dataList);
                    }
                }
            }
        }
        public void GeneralSourceGroupData(GridView gridView)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMNormTemplateItemParentName")
                {
                    List<string> dataList = new List<string>();
                    dataList = entity.NormTemplateItemDataList.Where(o => o.MMNormTemplateItemParentName != string.Empty).Select(n => n.MMNormTemplateItemParentName.Trim()).Distinct().ToList();
                    RepositoryItemMRUEdit repMruEdit = new RepositoryItemMRUEdit();
                    repMruEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repMruEdit.NullText = string.Empty;
                    repMruEdit.Items.Clear();
                    repMruEdit.Items.AddRange(dataList);
                    column.ColumnEdit = repMruEdit;
                }
            }
        }
        public void GeneralSourceSemiProductData(GridView gridView)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;

            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMNormTemplateItemProductName")
                {
                    List<string> dataList = new List<string>();
                    if (entity.NormTemplateItemGroupList != null && entity.NormTemplateItemGroupList.Count > 0 && entity.NormTemplateItemGroupList.CurrentIndex > 0)
                    {
                        MMNormTemplateItemsInfo objNormTemplateItemsInfo = entity.NormTemplateItemGroupList[entity.NormTemplateItemGroupList.CurrentIndex];
                        if (objNormTemplateItemsInfo != null)
                        {
                            dataList = entity.NormTemplateItemDataList.Where(o => o.MMNormTemplateItemProductParentName != objNormTemplateItemsInfo.MMNormTemplateItemParentName).Select(n => n.MMNormTemplateItemProductName.Trim()).Distinct().ToList();
                        }
                        else
                            dataList = entity.NormTemplateItemDataList.Where(o => o.MMNormTemplateItemProductName != string.Empty).Select(n => n.MMNormTemplateItemProductName.Trim()).Distinct().ToList();
                    }
                    else
                    {
                        dataList = entity.NormTemplateItemDataList.Where(o => o.MMNormTemplateItemProductName != string.Empty).Select(n => n.MMNormTemplateItemProductName.Trim()).Distinct().ToList();
                    }
                    RepositoryItemMRUEdit repMruEdit = new RepositoryItemMRUEdit();
                    repMruEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repMruEdit.NullText = string.Empty;
                    repMruEdit.Items.Clear();
                    repMruEdit.Items.AddRange(dataList);
                    column.ColumnEdit = repMruEdit;
                }
            }

        }

        public void AddGroupToNormTemplateItem(MMNormTemplateItemsInfo objNormTemplateItemsInfo)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            //Add group
            if (objNormTemplateItemsInfo == null)
            {
                foreach (MMNormTemplateItemsInfo item in entity.NormTemplateItemSemiProductList)
                {
                    if (item.Selected)
                    {

                        MMNormTemplateItemsInfo objNormGroupSemi = entity.NormTemplateItemList.Where(p => p.MMNormTemplateItemProductName.Trim() == item.MMNormTemplateItemParentName.Trim()).FirstOrDefault();
                        if (objNormGroupSemi == null && item.MMNormTemplateIsStruct && item.MMNormTemplateItemParentName.Trim() != string.Empty)
                        {
                            objNormGroupSemi = new MMNormTemplateItemsInfo();
                            objNormGroupSemi.MMNormTemplateItemIsComponent = true;
                            objNormGroupSemi.MMNormTemplateItemParentName = string.Empty;
                            objNormGroupSemi.MMNormTemplateItemParentNo = string.Empty;
                            objNormGroupSemi.MMNormTemplateItemNo = item.MMNormTemplateItemParentNo;
                            objNormGroupSemi.MMNormTemplateItemProductName = item.MMNormTemplateItemParentName;
                            objNormGroupSemi.MMNormTemplateItemProductHeight = 0;
                            objNormGroupSemi.MMNormTemplateItemProductWidth = 0;
                            objNormGroupSemi.MMNormTemplateItemProductLength = 0;
                            objNormGroupSemi.MMNormTemplateItemProductJoineryDesc = string.Empty;
                            objNormGroupSemi.MMNormTemplateItemProductWoodType = string.Empty;
                            objNormGroupSemi.MMNormTemplateItemAttributeQuality = string.Empty;
                            objNormGroupSemi.MMNormTemplateItemComment = string.Empty;
                            objNormGroupSemi.MMNormTemplateItemProductQty = 1;
                            entity.NormTemplateItemList.Add(objNormGroupSemi);
                        }

                        MMNormTemplateItemsInfo objNormSemi = entity.NormTemplateItemList.Where(p => p.MMNormTemplateItemProductName.Trim() == item.MMNormTemplateItemProductName.Trim()
                            && p.MMNormTemplateItemParentName.Trim() == item.MMNormTemplateItemParentName.Trim()).FirstOrDefault();
                        if (objNormSemi == null)
                        {
                            MMNormTemplateItemsInfo objNormItem = new MMNormTemplateItemsInfo();

                            objNormItem.MMNormTemplateItemParentName = item.MMNormTemplateItemParentName;
                            objNormItem.MMNormTemplateItemParentNo = item.MMNormTemplateItemParentNo;
                            objNormItem.MMNormTemplateItemNo = item.MMNormTemplateItemNo;
                            if (item.MMNormTemplateIsStruct && item.MMNormTemplateItemParentName.Trim() != string.Empty)
                                objNormItem.MMNormTemplateItemProductParentName = item.MMNormTemplateItemParentName;// xác định cấu trúc
                            objNormItem.MMNormTemplateItemProductName = item.MMNormTemplateItemProductName;
                            objNormItem.MMNormTemplateItemProductHeight = item.MMNormTemplateItemProductHeight;
                            objNormItem.MMNormTemplateItemProductWidth = item.MMNormTemplateItemProductWidth;
                            objNormItem.MMNormTemplateItemProductLength = item.MMNormTemplateItemProductLength;
                            objNormItem.MMNormTemplateItemProductJoineryDesc = item.MMNormTemplateItemProductJoineryDesc;
                            objNormItem.MMNormTemplateItemProductWoodType = item.MMNormTemplateItemProductWoodType;
                            objNormItem.MMNormTemplateItemAttributeQuality = item.MMNormTemplateItemAttributeQuality;
                            objNormItem.MMNormTemplateItemComment = string.Empty;
                            entity.NormTemplateItemList.Add(objNormItem);
                        }
                    }
                }
            }
            else // thêm cụm
            {
                MMNormTemplateItemsInfo objNormGroupSemi = entity.NormTemplateItemList.Where(p => p.MMNormTemplateItemProductName.Trim() == objNormTemplateItemsInfo.MMNormTemplateItemParentName.Trim()).FirstOrDefault();
                if (objNormGroupSemi == null)
                {
                    MMNormTemplateItemsInfo objNormItem = new MMNormTemplateItemsInfo();
                    objNormItem.MMNormTemplateItemIsComponent = true;
                    objNormItem.MMNormTemplateItemParentName = string.Empty;
                    objNormItem.MMNormTemplateItemParentNo = string.Empty;
                    objNormItem.MMNormTemplateItemNo = objNormTemplateItemsInfo.MMNormTemplateItemParentNo;
                    objNormItem.MMNormTemplateItemProductName = objNormTemplateItemsInfo.MMNormTemplateItemParentName;
                    objNormItem.MMNormTemplateItemProductHeight = 0;
                    objNormItem.MMNormTemplateItemProductWidth = 0;
                    objNormItem.MMNormTemplateItemProductLength = 0;
                    objNormItem.MMNormTemplateItemProductJoineryDesc = string.Empty;
                    objNormItem.MMNormTemplateItemProductWoodType = string.Empty;
                    objNormItem.MMNormTemplateItemAttributeQuality = string.Empty;
                    objNormItem.MMNormTemplateItemComment = string.Empty;
                    objNormItem.MMNormTemplateItemProductQty = 1;
                    entity.NormTemplateItemList.Add(objNormItem);
                }
            }
            entity.NormTemplateItemList.GridControl.RefreshDataSource();
        }
        public void AddSemiProductToNormTemplateItem(MMNormTemplateItemsInfo objNormTemplateItemsInfo)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            //Add Pieces
            MMNormTemplateItemsInfo objNormExits = entity.NormTemplateItemList.Where(p => p.MMNormTemplateItemProductName.Trim() == objNormTemplateItemsInfo.MMNormTemplateItemProductName.Trim()).FirstOrDefault();
            if (objNormExits == null)
            {
                MMNormTemplateItemsInfo objNormItem = new MMNormTemplateItemsInfo();
                objNormItem.MMNormTemplateItemParentName = string.Empty;
                objNormItem.MMNormTemplateItemParentNo = string.Empty;
                objNormItem.MMNormTemplateItemProductParentName = string.Empty;
                objNormItem.MMNormTemplateItemNo = objNormTemplateItemsInfo.MMNormTemplateItemNo;
                objNormItem.MMNormTemplateItemProductName = objNormTemplateItemsInfo.MMNormTemplateItemProductName;
                objNormItem.MMNormTemplateItemProductHeight = objNormTemplateItemsInfo.MMNormTemplateItemProductHeight;
                objNormItem.MMNormTemplateItemProductWidth = objNormTemplateItemsInfo.MMNormTemplateItemProductWidth;
                objNormItem.MMNormTemplateItemProductLength = objNormTemplateItemsInfo.MMNormTemplateItemProductLength;
                objNormItem.MMNormTemplateItemProductJoineryDesc = objNormTemplateItemsInfo.MMNormTemplateItemProductJoineryDesc;
                objNormItem.MMNormTemplateItemProductWoodType = objNormTemplateItemsInfo.MMNormTemplateItemProductWoodType;
                objNormItem.MMNormTemplateItemAttributeQuality = objNormTemplateItemsInfo.MMNormTemplateItemAttributeQuality;
                objNormItem.MMNormTemplateItemComment = string.Empty;
                entity.NormTemplateItemList.Add(objNormItem);
                entity.NormTemplateItemList.GridControl.RefreshDataSource();
            }
        }
        public void ChooseAllTemplate()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            bool isSelected = false;
            entity.NormTemplateItemSemiProductList.ForEach(t => { if (t.Selected == true) isSelected = true; });
            entity.NormTemplateItemSemiProductList.ForEach(t => { t.Selected = !isSelected; });
            entity.NormTemplateItemSemiProductList.GridControl.RefreshDataSource();
        }
        public List<object> GetDataFromLookupTable(string tableName, string colName, string getTypeField1
                                        , object objPropertyValue1, string getTypeField2, object objPropertyValue2, string DisplayColumn)
        {
            List<object> dataList = new List<object>();
            DataSet ds = null;
            if (!BOSApp.LookupTables.ContainsKey(tableName))
            {
                ds = GetLookupTableData(tableName);
                GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == tableName).FirstOrDefault();
                if (lookupTable == null)
                {
                    lookupTable = new GELookupTablesInfo();
                    lookupTable.GELookupTableName = tableName;
                    lookupTable.GELookupTableDisplayColumn = DisplayColumn;
                }
                if (lookupTable != null)
                {
                    BOSApp.LookupTables.Add(tableName, ds);
                    BOSApp.LookupTablesUpdatedDate.Add(tableName, DateTime.Now);
                    BOSApp.LookupTableObjects.Add(tableName, lookupTable);
                }
            }
            else
                ds = BOSApp.LookupTables[tableName] as DataSet;

            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                BaseBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(tableName + "Controller");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    object obj = objItemsController.GetObjectFromDataRow(row);
                    if (obj != null)
                    {
                        object objValue1 = dbUtil.GetPropertyValue(obj, getTypeField1);
                        object objResult = dbUtil.GetPropertyValue(obj, colName);
                        if (getTypeField1 == string.Empty)
                        {
                            if (!(dataList.IndexOf(objResult) > 0))
                                dataList.Add(objResult);
                        }
                        else
                        {
                            if (objPropertyValue1.Equals(objValue1))
                            {
                                if (getTypeField2 != string.Empty)
                                {
                                    object objValue2 = dbUtil.GetPropertyValue(obj, getTypeField2);
                                    if (objPropertyValue2.Equals(objValue2))
                                    {
                                        if (!(dataList.IndexOf(objResult) > 0))
                                            dataList.Add(objResult);
                                    }
                                }
                                else
                                    if (!(dataList.IndexOf(objResult) > 0))
                                    dataList.Add(objResult);
                            }

                        }
                    }
                }
            }

            ds.Dispose();
            return dataList;
        }

        public List<object> GetDataFromTemplate(string colName)
        {
            List<object> dataList = new List<object>();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.NormTemplateItemDataList == null || entity.NormTemplateItemDataList.Count == 0) return dataList;

            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (MMNormTemplateItemsInfo obj in entity.NormTemplateItemDataList)
            {
                object objResult = dbUtil.GetPropertyValue(obj, colName);
                if (!(dataList.IndexOf(objResult) > 0) && objResult.ToString() != string.Empty)
                    dataList.Add(objResult);
            }
            return dataList;
        }

        public void GenerateSearchChiTiet(GridColumn column, List<object> dataList)
        {
            RepositoryItemMRUEdit repMruEdit = new RepositoryItemMRUEdit();
            repMruEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repMruEdit.NullText = string.Empty;
            repMruEdit.Items.Clear();
            repMruEdit.Items.AddRange(dataList);
            column.ColumnEdit = repMruEdit;
        }
        public bool ChangeTempProduct(int productID)
        {
            bool result = false;
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMNormTemplateItemsController objNormTemplateItemsController = new MMNormTemplateItemsController();
            List<MMNormTemplateItemsInfo> dataItemList = new List<MMNormTemplateItemsInfo>();
            if (productID > 0)
            {
                dataItemList = objNormTemplateItemsController.GetNormTemplateByProduct(productID);
                entity.NormTemplateItemGroupList.Clear();
                entity.NormTemplateItemSemiProductList.Clear();

                if (dataItemList == null || dataItemList.Count == 0) result = false;
                entity.NormTemplateItemDataList.Invalidate(dataItemList);
            }

            List<MMNormTemplateItemsInfo> dataGroupList = new List<MMNormTemplateItemsInfo>();
            if (entity.NormTemplateItemDataList != null && entity.NormTemplateItemDataList.Count > 0)
            {
                if (productID == 0)
                    dataItemList = entity.NormTemplateItemDataList;
                dataGroupList = dataItemList.Where(d => d.MMNormTemplateItemParentName != string.Empty).ToList();
                if (dataGroupList != null)
                    dataGroupList.ForEach(x => { x.MMNormTemplateItemProductParentName = x.MMNormTemplateItemParentName; });
                result = true;
            }
            else
            {
                result = false;
            }

            entity.NormTemplateItemGroupList.Invalidate(dataGroupList);
            bool isStruct = false;
            dataItemList.ForEach(o => { if (o.MMNormTemplateIsStruct) { isStruct = true; } });
            if (isStruct && dataGroupList != null)
            {
                dataItemList = entity.NormTemplateItemDataList.Where(o => o.MMNormTemplateItemParentName.Trim() == dataGroupList[0].MMNormTemplateItemParentName.Trim()).ToList();
            }
            entity.NormTemplateItemSemiProductList.Invalidate(dataItemList);
            entity.NormTemplateItemList.Clear();
            entity.NormTemplateItemList.GridControl.RefreshDataSource();
            entity.NormTemplateItemGroupList.GridControl.RefreshDataSource();
            entity.NormTemplateItemSemiProductList.GridControl.RefreshDataSource();
            return result;
        }

        public void ChangeSourceSemiProductByGroup(MMNormTemplateItemsInfo objGroupsInfo)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.NormTemplateItemDataList != null && entity.NormTemplateItemDataList.Count > 0 && objGroupsInfo != null && objGroupsInfo.MMNormTemplateIsStruct)
            {
                List<MMNormTemplateItemsInfo> dataList = entity.NormTemplateItemDataList.Where(d => d.MMNormTemplateItemProductParentName == objGroupsInfo.MMNormTemplateItemProductParentName).ToList();
                if (dataList != null && dataList.Count > 0)
                {
                    dataList.ForEach(t => { t.MMNormTemplateItemParentName = objGroupsInfo.MMNormTemplateItemProductParentName; });
                }
                entity.NormTemplateItemSemiProductList.Invalidate(dataList);
                entity.NormTemplateItemSemiProductList.GridControl.RefreshDataSource();
            }
            else
            {
                List<MMNormTemplateItemsInfo> dataList = entity.NormTemplateItemDataList.Where(d => d.MMNormTemplateItemProductName != string.Empty).ToList();

                entity.NormTemplateItemSemiProductList.Invalidate(dataList);
                entity.NormTemplateItemSemiProductList.ForEach(o =>
                {
                    o.MMNormTemplateItemParentName = string.Empty;
                    o.MMNormTemplateItemParentNo = string.Empty;
                    o.MMNormTemplateItemProductParentName = string.Empty;
                });
                entity.NormTemplateItemSemiProductList.GridControl.RefreshDataSource();
            }
        }
        public void InsertNormItemWoods(int productID)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.NormTemplateItemList == null || entity.NormTemplateItemList.Count == 0)
                return;
            bool isInputQty = true;
            entity.NormTemplateItemList.ForEach(t =>
                {
                    if (t.MMNormTemplateItemProductQty <= 0)
                    {
                        t.IsError = true;
                        isInputQty = false;
                    }
                });
            if (!isInputQty)
            {
                if (MessageBox.Show("Chi tiết có số lượng <= 0."
                    + Environment.NewLine + "Bạn muốn lưu không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            try
            {
                MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
                ICProductItemsController objProductItemsController = new ICProductItemsController();
                ICProductsController objProductsController = new ICProductsController();
                ICProductAttributesController objProductAttributesController = new ICProductAttributesController();

                ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductsInfo objMainProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.SemiProductNo.ToString()));
                
                if (objDepartmentsInfo == null)
                    return;

                List<ICProductAttributesInfo> productAttributes = new List<ICProductAttributesInfo>();
                productAttributes = (List<ICProductAttributesInfo>)objProductAttributesController.GetListFromDataSet(objProductAttributesController.GetAllObjects());
                MMFormulasController objMMFormulasController = new MMFormulasController();
                List<MMFormulasInfo> listFormulas = new List<MMFormulasInfo>();
                listFormulas = (List<MMFormulasInfo>)objMMFormulasController.GetListFromDataSet(objMMFormulasController.GetAllObjects());

                List<ICProductsInfo> productGroups = new List<ICProductsInfo>();
                List<ICProductsInfo> productDetails = new List<ICProductsInfo>();
                List<ICProductsInfo> productPieces = new List<ICProductsInfo>();
                ICProductsInfo objProductsInfo;
                MMFormulasInfo objMMFormulasInfo;
                ICProductAttributesInfo objProductAttributesInfo;
                MMProductionNormItemsInfo objProductionNormItemsInfo;
                MMProductionNormItemsInfo subProductionNormItem;
                MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
                List<MMProductionNormItemsInfo> productionNormItems = new List<MMProductionNormItemsInfo>();
                List<ICProductItemsInfo> productItems = new List<ICProductItemsInfo>();

                foreach (MMNormTemplateItemsInfo item in entity.NormTemplateItemList)
                {
                    if (!string.IsNullOrEmpty(item.MMNormTemplateItemProductName.Trim()))
                    {
                        objProductsInfo = new ICProductsInfo();
                        objProductsInfo.ICProductCode = item.MMNormTemplateItemProductName.Trim();
                        objProductsInfo.ICProductName = item.MMNormTemplateItemProductName.Trim();
                        objProductsInfo.HasComponent = item.MMNormTemplateItemIsComponent;
                        objProductsInfo.ICProductParentCode = item.MMNormTemplateItemProductParentName.Trim();
                        objProductsInfo.ICProductHeight = item.MMNormTemplateItemProductHeight;
                        objProductsInfo.ICProductWidth = item.MMNormTemplateItemProductWidth;
                        objProductsInfo.ICProductLength = item.MMNormTemplateItemProductLength;
                        objProductsInfo.ICProductItemQty = item.MMNormTemplateItemProductQty;

                        objProductsInfo.FK_ICDepartmentID = objDepartmentsInfo.ICDepartmentID;
                        if (!string.IsNullOrEmpty(item.MMNormTemplateItemProductWoodType))
                        {
                            objProductAttributesInfo = productAttributes.FirstOrDefault(o => o.ICProductAttributeValue.ToUpper() == item.MMNormTemplateItemProductWoodType.Trim().ToUpper());
                            if (objProductAttributesInfo == null)
                            {
                                objProductAttributesInfo = new ICProductAttributesInfo();
                                objProductAttributesInfo.ICProductAttributeGroup = ProductAttributeGroup.WoodType.ToString();
                                objProductAttributesInfo.ICProductAttributeNo = item.MMNormTemplateItemProductWoodType.Trim();
                                objProductAttributesInfo.ICProductAttributeValue = item.MMNormTemplateItemProductWoodType.Trim();
                                objProductAttributesController.CreateObject(objProductAttributesInfo);
                            }
                            objProductsInfo.FK_ICProductAttributeWoodTypeID = objProductAttributesInfo != null ? objProductAttributesInfo.ICProductAttributeID : 0;
                        }
                        if (!string.IsNullOrEmpty(item.MMNormTemplateItemProductSpeciality.Trim()))
                        {
                            objProductAttributesInfo = productAttributes.FirstOrDefault(o => o.ICProductAttributeValue.ToUpper() == item.MMNormTemplateItemProductSpeciality.Trim().ToUpper());
                            if (objProductAttributesInfo == null)
                            {
                                objProductAttributesInfo = new ICProductAttributesInfo();
                                objProductAttributesInfo.ICProductAttributeGroup = ProductAttributeGroup.Speciality.ToString();
                                objProductAttributesInfo.ICProductAttributeNo = item.MMNormTemplateItemProductSpeciality.Trim();
                                objProductAttributesInfo.ICProductAttributeValue = item.MMNormTemplateItemProductSpeciality.Trim();
                                objProductAttributesController.CreateObject(objProductAttributesInfo);
                            }
                            //objProductsInfo.FK_ICProductAttributeSpecialityID = objProductAttributesInfo != null ? objProductAttributesInfo.ICProductAttributeID : 0;
                            //objProductsInfo.FK_ICProductAttributeSemiProductSpecialityID = objProductsInfo.FK_ICProductAttributeSpecialityID;
                        }
                        if (!string.IsNullOrEmpty(item.MMNormTemplateItemAttributeQuality.Trim()))
                        {
                            objProductAttributesInfo = productAttributes.FirstOrDefault(o => o.ICProductAttributeValue.ToUpper() == item.MMNormTemplateItemAttributeQuality.Trim().ToUpper());
                            if (objProductAttributesInfo == null)
                            {
                                objProductAttributesInfo = new ICProductAttributesInfo();
                                objProductAttributesInfo.ICProductAttributeGroup = ProductAttributeGroup.Quality.ToString();
                                objProductAttributesInfo.ICProductAttributeNo = item.MMNormTemplateItemAttributeQuality.Trim();
                                objProductAttributesInfo.ICProductAttributeValue = item.MMNormTemplateItemAttributeQuality.Trim();
                                objProductAttributesController.CreateObject(objProductAttributesInfo);
                            }
                            //objProductsInfo.FK_ICProductAttributeQualityID = objProductAttributesInfo != null ? objProductAttributesInfo.ICProductAttributeID : 0;
                        }
                        //objProductsInfo.MMProductionNormProductJoinery = item.MMNormTemplateItemProductJoineryDesc.Trim();
                        objProductsInfo.ICProductJoinery = item.MMNormTemplateItemProductJoineryDesc;

                        if (!string.IsNullOrEmpty(item.MMNormTemplateItemFormula.Trim()))
                        {
                            objMMFormulasInfo = listFormulas.FirstOrDefault(o => o.MMFormulaNo.ToUpper() == item.MMNormTemplateItemFormula.Trim().ToUpper());
                            if (objMMFormulasInfo == null)
                            {
                                objMMFormulasInfo = new MMFormulasInfo();
                                objMMFormulasInfo.MMFormulaNo = item.MMNormTemplateItemFormula.Trim();
                                objMMFormulasInfo.MMFormulaName = item.MMNormTemplateItemFormula.Trim();
                                objMMFormulasInfo.MMFormulaDesc = item.MMNormTemplateItemFormula.Trim();
                                objMMFormulasController.CreateObject(objMMFormulasInfo);
                            }
                            //objProductsInfo.FK_MMFormulaIDPaintA = objMMFormulasInfo != null ? objMMFormulasInfo.MMFormulaID : 0;
                        }
                        //objProductsInfo.MMProductionNormItemComment = item.MMNormTemplateItemComment.Trim();

                        objProductsInfo.ICProductType = ProductType.SemiProduct.ToString();
                        if (objProductsInfo.HasComponent)
                        {
                            objProductsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormCum;
                            objProductsInfo.HasComponent = true;
                            productGroups.Add(objProductsInfo);
                        }
                        else
                        {
                            objProductsInfo.FK_ICProductGroupID = ProductionNormConst.MMProductionNormChitiet;
                            objProductsInfo.HasComponent = false;
                            if (objProductsInfo.ICProductParentCode != string.Empty)
                                productDetails.Add(objProductsInfo);
                            else
                                productPieces.Add(objProductsInfo);
                        }
                    }
                }
                ICProductItemsInfo objProductItemsInfo;
                productGroups.ForEach(o =>
                {
                    o.HasComponent = true;
                    o.ICProductNo = objProductsController.GetNextNoForGroupOrPieceSemiProduct(objMainProductsInfo.ICProductNo, objMainProductsInfo.ICProductNo.Length + 3);
                    o.ICProductDesc = o.ICProductName;
                    objProductsController.CreateObject(o);
                    objProductItemsInfo = new ICProductItemsInfo();
                    objProductItemsInfo.FK_ICProductItemParentID = objMainProductsInfo.ICProductID;
                    objProductItemsInfo.FK_ICProductItemChildID = o.ICProductID;
                    objProductItemsInfo.ICProductItemQty = o.ICProductItemQty;
                    objProductItemsController.CreateObject(objProductItemsInfo);
                    int sortOrderDetail = 0;
                    int count = 1;
                    productDetails.Where(x => x.ICProductParentCode.ToUpper() == o.ICProductCode.ToUpper()).All(x =>
                    {
                        x.HasComponent = false;
                        x.ICProductParentID = o.ICProductID;
                        string childProductNo = ProductionNormLocalizeResources.SemiProductGroupDefaultNo.Replace("{0}", o.ICProductNo);
                        childProductNo = childProductNo.Replace("{1}", count++.ToString().PadLeft(2, '0'));
                        x.ICProductNo = childProductNo;
                        x.ICProductDesc = x.ICProductName;
                        x.ICProductOrderID = sortOrderDetail;
                        objProductsController.CreateObject(x);
                        objProductItemsInfo = new ICProductItemsInfo();
                        objProductItemsInfo.FK_ICProductItemParentID = o.ICProductID;
                        objProductItemsInfo.FK_ICProductItemChildID = x.ICProductID;
                        objProductItemsInfo.ICProductItemQty = x.ICProductItemQty;
                        objProductItemsInfo.ICProductItemSortOrder = x.ICProductOrderID;
                        objProductItemsController.CreateObject(objProductItemsInfo);
                        sortOrderDetail++;
                        productItems.Add(objProductItemsInfo);
                        return true;
                    });
                });
                productPieces.Where(o => String.IsNullOrEmpty(o.ICProductParentCode)).All(o =>
                {
                    o.HasComponent = false;
                    o.ICProductNo = objProductsController.GetNextNoForGroupOrPieceSemiProduct(objMainProductsInfo.ICProductNo, objMainProductsInfo.ICProductNo.Length + 3);
                    o.ICProductDesc = o.ICProductName;
                    objProductsController.CreateObject(o);
                    objProductItemsInfo = new ICProductItemsInfo();
                    objProductItemsInfo.FK_ICProductItemParentID = objMainProductsInfo.ICProductID;
                    objProductItemsInfo.FK_ICProductItemChildID = o.ICProductID;
                    objProductItemsInfo.ICProductItemQty = o.ICProductItemQty;
                    objProductItemsController.CreateObject(objProductItemsInfo);
                    return true;
                });
                List<ICProductsInfo> products = new List<ICProductsInfo>();
                products.AddRange(productGroups);
                products.AddRange(productPieces);

                products.ForEach(p =>
                {
                    objProductionNormItemsInfo = SetValueProductionNormItemFromProductForImport(p, string.Empty, p);
                    objProductionNormItemsInfo.MMProductionNormItemQuantity = p.ICProductItemQty;
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.ProductionNormItemList.Count;

                    if (objProductionNormItemsInfo.SubList == null)
                        objProductionNormItemsInfo.SubList = new BOSTreeList();
                    objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                    List<ICProductsInfo> items = productDetails.Where(o => o.ICProductParentID == p.ICProductID).ToList();
                    if (items.Count() > 0)
                    {
                        items.ForEach(pItem =>
                        {
                            subProductionNormItem = SetValueProductionNormItemFromProductForImport(pItem, string.Empty, pItem);
                            subProductionNormItem.MMProductionNormItemQuantity = pItem.ICProductItemQty;
                            subProductionNormItem.MMProductionNormItemSortOrder = entity.ProductionNormItemList.Count;
                            subProductionNormItem.MMProductionNormItemGroup = ProductType.SemiProduct.ToString();
                            subProductionNormItem.MMProductionNormItemIsComponent = false;
                            objProductionNormItemsInfo.SubList.Add(subProductionNormItem);
                        });
                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = true;
                    }
                    else
                        objProductionNormItemsInfo.MMProductionNormItemIsComponent = false;
                    entity.ProductionNormItemList.Add(objProductionNormItemsInfo);
                });

                CalculateProductionNormItemWoodType();
                CalculateBlockPerOne();
                entity.ProductionNormItemList.TreeListControl.RefreshDataSource();
                entity.ProductionNormItemList.TreeListControl.ForceInitialize();
                entity.ProductionNormItemList.TreeListControl.DragNodesMode = TreeListDragNodesMode.Advanced;
                entity.ProductionNormItemList.TreeListControl.OptionsBehavior.CanCloneNodesOnDrop = false;
                entity.ProductionNormItemList.TreeListControl.OptionsBehavior.AutoChangeParent = false;
                entity.ProductionNormItemList.TreeListControl.ClearSorting();
                entity.ProductionNormItemList.TreeListControl.Columns["MMProductionNormItemSortOrder"].SortOrder = SortOrder.Ascending;
                entity.ProductionNormItemList.TreeListControl.ExpandAll();
                entity.ProductionNormItemList.TreeListControl.BestFitColumns();
                RefreshTreeView(entity.ProductionNormItemList);
                ProductionNormItemOriginalList.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lổi xãy ra:" + ex.Message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                BOSProgressBar.Close();
                return;
            }

        }
        public void PasteNormTemplateItem(MMNormTemplateItemsInfo CopyTemplateItem, int indexFocus)
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            if (entity.NormTemplateItemList != null && entity.NormTemplateItemList.Count > 0)
            {
                if (indexFocus >= 0)
                    entity.NormTemplateItemList.Insert(indexFocus, CopyTemplateItem);
                else
                    entity.NormTemplateItemList.Add(CopyTemplateItem);
                entity.NormTemplateItemList.GridControl.RefreshDataSource();
            }
        }
        public bool ImportTemplate()
        {
            bool result = false;
            try
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                List<Range> ranges = InitializeDataImport();
                if (ranges == null)
                    return false;
                BOSProgressBar.Start(MESLocalizedResources.ProgressBarMessage);

                Range range = ranges[0];

                #region Process data
                MMNormTemplateItemsInfo objNormTemplateItemsInfo;
                for (int row = 2; row <= range.Rows.Count; row++)
                {
                    bool toAdd = false;
                    objNormTemplateItemsInfo = new MMNormTemplateItemsInfo();
                    objNormTemplateItemsInfo.MMNormTemplateItemParentName = (range.Cells[row, 1] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemParentName != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductName = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductName != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductHeight = GetDecimalFromString((range.Cells[row, 3] as Range).Value2);
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductHeight > 0) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductJoinery = GetDecimalFromString((range.Cells[row, 4] as Range).Value2);
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductJoinery > 0) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductJoineryDesc = (range.Cells[row, 5] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductJoineryDesc != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductSpeciality = (range.Cells[row, 6] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductSpeciality != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemAttributeQuality = (range.Cells[row, 7] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemAttributeQuality != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemProductAttribute = (range.Cells[row, 9] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemProductAttribute != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemOperation = (range.Cells[row, 10] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemOperation != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemPackagingName = (range.Cells[row, 11] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemPackagingName != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemPackagingType = (range.Cells[row, 12] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemPackagingType != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateItemUnit = (range.Cells[row, 13] as Range).Text.ToString().Trim();
                    if (objNormTemplateItemsInfo.MMNormTemplateItemUnit != string.Empty) toAdd = true;
                    objNormTemplateItemsInfo.MMNormTemplateIsStruct = false;
                    if (toAdd)
                        entity.NormTemplateItemDataList.Add(objNormTemplateItemsInfo);
                    else break;
                }
                #endregion
                result = true;
                BOSProgressBar.Close();
                ReleaseDataImport();
                return result;
            }
            catch (Exception ex)
            {
                ReleaseDataImport();
                MessageBox.Show("Có lổi xãy ra:" + ex.Message, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                BOSProgressBar.Close();
                return false;
            }
        }
        public bool SaveTemplate(int productID)
        {
            bool result = false;
            if (productID == 0)
            {
                MessageBox.Show(ProductionNormLocalizeResources.ChooseProductMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                bool isUseFinishTemp = false;


                if (entity.NormTemplateItemList != null && entity.NormTemplateItemList.Count > 0)
                {
                    if (MessageBox.Show("Bạn muốn lưu mẫu theo danh sách chi tiết đã hoàn thiện không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        isUseFinishTemp = true;
                }

                if (isUseFinishTemp)
                    result = Modules.NormTemplate.NormTemplateModule.ProductionNormSaveTemplate(entity.NormTemplateItemList, productID, true);
                else
                    result = Modules.NormTemplate.NormTemplateModule.ProductionNormSaveTemplate(entity.NormTemplateItemDataList, productID, false);
            }
            return result;
        }
        public void GetTemplateExcel()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string filePath = System.Windows.Forms.Application.StartupPath + @"\Template\TEMPBOM.xlsx";
                App = new ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = @"Tệp Excel (*.xls)|*.xls|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = @"TEMPBOM.xls";
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fullFileName = saveDialog.FileName;

                    WorkBook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    WorkBook.Saved = true;
                }
                ReleaseDataImport();
                BOSProgressBar.Close();
            }
            catch (Exception ex)
            {
                ReleaseDataImport();
                BOSProgressBar.Close();
                MessageBox.Show(ex.ToString()
                                            , MESLocalizedResources.MessageBoxDefaultCaption
                                            , MessageBoxButtons.OK
                                            , MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Add SemiProducts

        private bool CheckValidToAddNewSemiProducts()
        {
            bool isValid = true;

            //ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            //MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            if (mainObject.FK_ICProductID == 0)
            {
                MessageBox.Show("Vui lòng chọn thành phẩm trước khi lưu");
                isValid = false;
            }
            return isValid;
        }

        public void SaveSemiProductList()
        {
            bool isValid = CheckValidToAddNewSemiProducts();
            if (isValid)
            {
                UpdateProductInfo();
                if (entity.ProductList != null)
                {
                    entity.ProductList.SaveItemObjects();
                }

                CreateProductItemListByProductList(entity.ProductList);
            }
        }

        private void UpdateProductInfo()
        {
            string productCarcassNo = string.Empty;
            using (ICProductsController productController = new ICProductsController())
            {
                ICProductsInfo product = (ICProductsInfo)productController.GetObjectByID(mainObject.FK_ICProductCarcassID);
                if (product != null)
                    productCarcassNo = product.ICProductNo;
            }

            if (entity.ProductList != null)
            {
                foreach (ICProductsInfo item in entity.ProductList)
                {
                    item.ICProductNo = productCarcassNo + item.ICProductCode;
                    item.FK_ICProductCarcassID = mainObject.FK_ICProductCarcassID;
                    if (item.HasComponent)
                    {
                        item.FK_ICDepartmentID = ProductionNormConst.MMProductionNormSemiProductDepartment;
                        item.FK_ICProductGroupID = ProductionNormConst.MMProductionNormCum;
                    }
                    else
                    {
                        item.FK_ICDepartmentID = ProductionNormConst.MMProductionNormSemiProductDepartment;
                        item.FK_ICProductGroupID = ProductionNormConst.MMProductionNormChitiet;
                    }
                    item.ICProductType = ProductType.SemiProduct.ToString();
                }
            }

        }

        private void CreateProductItemListByProductList(BOSList<ICProductsInfo> products)
        {
            using (ICProductItemsController productItemController = new ICProductItemsController())
            {
                productItemController.DeleteByForeignColumn("FK_ICProductCarcassID", mainObject.FK_ICProductCarcassID);

                List<ICProductItemsInfo> productItems = ConvertToProductItemList(entity.ProductList);
                if (productItems != null && productItems.Count > 0)
                {
                    foreach (ICProductItemsInfo productItem in productItems)
                    {
                        productItemController.CreateObject(productItem);
                    }
                }
            }
        }

        private List<ICProductItemsInfo> ConvertToProductItemList(BOSList<ICProductsInfo> products)
        {
            List<ICProductItemsInfo> productItems = new List<ICProductItemsInfo>();
            if (products != null)
            {
                foreach (ICProductsInfo product in products)
                {
                    ICProductItemsInfo productItem = ConvertToProductItem(product);
                    if (productItem != null)
                        productItems.Add(productItem);

                }
            }
            return productItems;
        }

        private ICProductItemsInfo ConvertToProductItem(ICProductsInfo product)
        {
            if (product != null)
            {
                ICProductItemsInfo productItem = new ICProductItemsInfo();
                productItem.FK_ICProductCarcassID = product.FK_ICProductCarcassID;
                //productItem.FK_ICProductID = product.ICProductID;
                productItem.FK_ICProductItemChildID = product.ICProductID;
                productItem.ICProductItemQty = product.ICProductItemQty;
                productItem.ICProductItemSortOrder = product.ICProductOrderID;

                return productItem;
            }

            return null;
        }

        private void InvalidateProductList(int productCarcassID)
        {
            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> products = productController.GetProductsByProductCarcassID(productCarcassID);
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            entity.ProductList.Invalidate(products);
            entity.ProductList.GridControl.RefreshDataSource();
        }
        public void ShowProductStructureForm(ICProductsInfo product)
        {
            if (product != null)
            {
                var collection = entity.ProductList.Where(item => item.ICProductCode.Contains(product.ICProductCode)
                                                                && item.ICProductCode.Length > product.ICProductCode.Length);
                if (collection.Any())
                {
                    List<ICProductsInfo> semiProducts = new List<ICProductsInfo>();
                    foreach (ICProductsInfo item in collection)
                    {
                        semiProducts.Add(item);
                    }
                    entity.ProductItemList.Invalidate(semiProducts);
                    using (guiCreateProductStructure form = new guiCreateProductStructure(product.ICProductID))
                    {
                        form.Module = this;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            CreateProductStructure(product.ICProductID, entity.ProductItemList);
                        }
                    }
                }
            }
        }

        public void CreateProductStructure(int parentID, BOSList<ICProductsInfo> list)
        {
            if (list != null)
            {
                ICProductsInfo product = list.FirstOrDefault(item => item.Selected);
                if (product == null)
                    MessageBox.Show("Vui lòng chọn BTP con cho cụm được chọn");
                else
                {
                    ICProductItemsController productItemController = new ICProductItemsController();

                    foreach (ICProductsInfo item in list)
                    {
                        if (item.Selected)
                        {
                            productItemController.UpdateParentIDAndProductQty(item.FK_ICProductCarcassID, parentID, item.ICProductID, item.ICProductItemQty, item.ICProductOrderID);
                        }
                    }
                }
            }
        }

        #endregion Add SemiProducts

        #region General Material
        public void AddGeneralMaterial(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                AddItemToGeneralMaterialList(objProductsInfo);
                ResetGeneralMaterialSortOrder();
            }
        }
        public void UpdateGeneralMaterialFromConfig()
        {
            if (IsEditable())
                ActionEdit();
            ChangestatusToEdit(ProductType.GeneralMaterial.ToString());
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            ICProductsController pController = new ICProductsController();
            ICProductsInfo carcass = (ICProductsInfo)pController.GetObjectByID(objProductionNormsInfo.FK_ICProductCarcassID);

            #region old code
            //ICMaterialConfigsController objMaterialConfigsController = new ICMaterialConfigsController();
            //List<ICMaterialConfigsInfo> listConfig = (List<ICMaterialConfigsInfo>)objMaterialConfigsController.GetActiveConfigBySomeCriteria(null, null);
            //List<MMProductionNormItemsInfo> normItemList = new List<MMProductionNormItemsInfo>();
            //if (listConfig != null)
            //{
            //    if (entity.ProductionNormItemList != null)
            //    {
            //        List<ICMaterialConfigsInfo> lstMaterialConfigFilter = new List<ICMaterialConfigsInfo>();
            //        entity.ProductionNormItemList.ConvertToList(normItemList);
            //        if (normItemList != null && normItemList.Count > 0)
            //        {
            //            var disNormItemList = (from n in normItemList
            //                                   group n by new { n.FK_ICProductAttributeSpecialityID, n.MMProductionNormItemProductWoodType } into gr
            //                                   select new
            //                                   {
            //                                       gr.Key.FK_ICProductAttributeSpecialityID
            //                                    ,
            //                                       gr.Key.MMProductionNormItemProductWoodType
            //                                    ,
            //                                       MMProductionNormItemBlocks = gr.Sum(o => o.MMProductionNormItemBlocks)
            //                                   }
            //                                   ).ToList();
            //            if (disNormItemList != null && listConfig != null)
            //            {
            //                foreach (var item in disNormItemList)
            //                {
            //                    List<ICMaterialConfigsInfo> lstMaterialConfig = listConfig.Where(c => c.FK_ICProductAttributeSpecialityID == item.FK_ICProductAttributeSpecialityID
            //                        && c.MMProductionNormItemProductWoodType.Trim() == item.MMProductionNormItemProductWoodType.Trim()).ToList();
            //                    if (lstMaterialConfig != null && lstMaterialConfig.Count > 0)
            //                    {
            //                        lstMaterialConfig.ForEach(o => { o.ICMaterialConfigQty = item.MMProductionNormItemBlocks * o.ICMaterialConfigQty; });
            //                        foreach (ICMaterialConfigsInfo cof in lstMaterialConfig)
            //                        {
            //                            ICMaterialConfigsInfo exitConfig = lstMaterialConfigFilter.Where(x => x.FK_ICProductID == cof.FK_ICProductID).FirstOrDefault();
            //                            if (exitConfig != null && exitConfig.FK_ICProductID > 0)
            //                            {
            //                                exitConfig.ICMaterialConfigQty += cof.ICMaterialConfigQty;
            //                            }
            //                            else
            //                                lstMaterialConfigFilter.Add(cof);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        if (lstMaterialConfigFilter != null && lstMaterialConfigFilter.Count > 0)
            //        {
            //            bool repeat = false;
            //            lstMaterialConfigFilter.ForEach(o => {
            //                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            //                //Set value from config
            //                objProductionNormItemsInfo.FK_ICProductID = o.FK_ICProductID;
            //                objProductionNormItemsInfo.FK_ICProductGroupID = o.FK_ICProductGroupID;
            //                objProductionNormItemsInfo.FK_ICDepartmentID = o.FK_ICDepartmentID;
            //                objProductionNormItemsInfo.MMProductionNormItemProductName = o.ICMaterialConfigProductName;
            //                objProductionNormItemsInfo.MMProductionNormItemNo = o.ICMaterialConfigProductNo;
            //                objProductionNormItemsInfo.MMProductionNormItemNeededTime = DateTime.Now;
            //                objProductionNormItemsInfo.FK_ICMeasureUnitID = o.FK_ICMeasureUnitID;
            //                objProductionNormItemsInfo.MMProductionNormItemProductDesc = o.ICMaterialConfigProductDesc;
            //                objProductionNormItemsInfo.MMProductionNormItemProductSupplierNumber = o.ICProductSupplierNumber;
            //                objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.GeneralMaterial.ToString();
            //                objProductionNormItemsInfo.MMProductionNormItemUnit = o.ICMeasureUnitName;
            //                objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking = o.ICProductSizeAndSpecifiCations;
            //                objProductionNormItemsInfo.MMProductionNormItemProductDesc = o.ICMaterialConfigProductDesc;
            //                objProductionNormItemsInfo.MMProductionNormItemQuantity = o.ICMaterialConfigQty;
            //                if (entity.GeneralMaterialList != null && entity.GeneralMaterialList.Count > 0)
            //                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.GeneralMaterialList.Count + 1;
            //                else
            //                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = 1;

            //                if (entity.GeneralMaterialList != null && entity.GeneralMaterialList.Count > 0)
            //                {
            //                    if (entity.GeneralMaterialList.Any(n => n.FK_ICProductID == o.FK_ICProductID))
            //                    {
            //                        DialogResult dlgResult = DialogResult.No;
            //                        if (!repeat)
            //                        {
            //                            dlgResult = MessageBox.Show(string.Format(ProductionNormLocalizeResources.MaterialExitsInListMessage, o.ICMaterialConfigProductName)
            //                                   + Environment.NewLine + "Cancel: Cập nhật và không hỏi lại"
            //                                   + Environment.NewLine + "Yes: Cộng số lượng từ cấu hình"
            //                                   + Environment.NewLine + "No: Cập nhật số lượng theo cấu hình."
            //                                  , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //                        }
            //                        MMProductionNormItemsInfo objExitsInfo = entity.GeneralMaterialList.Where(n => n.FK_ICProductID == o.FK_ICProductID).FirstOrDefault();
            //                        if (objExitsInfo != null)
            //                        {
            //                            if (dlgResult == DialogResult.Yes)
            //                            {
            //                                objExitsInfo.MMProductionNormItemQuantity += o.ICMaterialConfigQty;
            //                            }
            //                            else if (dlgResult == DialogResult.Cancel || repeat || dlgResult == DialogResult.No)
            //                            {
            //                                if (dlgResult == DialogResult.Cancel)
            //                                    repeat = true;
            //                                objExitsInfo.MMProductionNormItemQuantity = o.ICMaterialConfigQty;
            //                            }
            //                        }
            //                    }
            //                    else
            //                    {
            //                        entity.GeneralMaterialList.Add(objProductionNormItemsInfo);
            //                    }
            //                }
            //                else
            //                {
            //                    entity.GeneralMaterialList.Add(objProductionNormItemsInfo);
            //                }

            //            });
            //            entity.GeneralMaterialList.GridControl.RefreshDataSource();
            //        }

            //    }
            //}
            #endregion

            ICProductPackingDetailsController pdController = new ICProductPackingDetailsController();
            List<ICProductPackingDetailsInfo> ICProductPackingDetailsList = pdController.GetByProductID(objProductionNormsInfo.FK_ICProductCarcassID);

            ICMaterialConfigsController mcController = new ICMaterialConfigsController();
            List<ICMaterialConfigsInfo> lstConfig = mcController.GetAllAliveAndActiveConfig();

            List<ICMaterialConfigsInfo> lstMatchConfig;

            entity.GeneralMaterialList.ForEach(item =>
            {
                item.MMProductionNormItemQuantity = 0;



                if (carcass != null)
                {
                    lstMatchConfig = lstConfig.Where(t => t.FK_ICProductID == item.FK_ICProductID).ToList();
                    if (lstMatchConfig != null && lstMatchConfig.Any())
                    {
                        foreach (ICMaterialConfigsInfo config in lstMatchConfig)
                        {
                            CalculateMaterialQtyByConfig(item, config, carcass, objProductionNormsInfo, ICProductPackingDetailsList);
                        }
                    }
                }
            });

            entity.GeneralMaterialList.GridControl.RefreshDataSource();
        }

        public void CalculateMaterialQtyByConfig(MMProductionNormItemsInfo item, ICMaterialConfigsInfo config, ICProductsInfo carcass, MMProductionNormsInfo pn, List<ICProductPackingDetailsInfo> ICProductPackingDetailsList)
        {
            if (config.ICMaterialConfigCalByQty) // tính trên khối lượng bom
            {
                List<string> lstfinishStr = carcass.ICProductAttributeFinishing.Split(',').ToList();

                bool isExist = false;
                foreach (string id in lstfinishStr)
                {
                    if (config.FK_ICProductAttHTType.ToString() == id.Trim())
                    {
                        isExist = true;
                        break;
                    }
                }

                if (isExist)
                {
                    item.MMProductionNormItemQuantity += (pn.MMProductionNormBlock * config.ICMaterialConfigQty);
                }
            }
            else // tính trên kích thước thùng
            {
                foreach (ICProductPackingDetailsInfo packing in ICProductPackingDetailsList)
                {
                    if (packing.FK_ICProductAttributeSpecialityID == config.FK_ICProductAttPackingMaterialSpeciality)
                    {
                        if (config.ICMaterialConfigCalByType
                            == MaterialConfigCalByType.Circumcircle.ToString()) // chu vi 1 mặt
                        {
                            item.MMProductionNormItemQuantity +=
                                ((packing.ICProductPackingDetailLength + packing.ICProductPackingDetailWidth) * 2 * config.ICMaterialConfigQty);
                        }
                        else if (config.ICMaterialConfigCalByType
                            == MaterialConfigCalByType.Longest.ToString()) // cạnh dài nhất
                        {
                            item.MMProductionNormItemQuantity +=
                                (Math.Max(Math.Max(packing.ICProductPackingDetailLength, packing.ICProductPackingDetailWidth)
                                            , packing.ICProductPackingDetailHeight) * config.ICMaterialConfigQty);
                        }
                    }
                }
            }
        }

        public MMProductionNormItemsInfo AddItemToGeneralMaterialList(ICProductsInfo productObject)
        {
            if (IsEditable())
                ActionEdit();
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            ChangestatusToEdit(ProductType.GeneralMaterial.ToString());
            ICProductsController objProductsController = new ICProductsController();
            MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
            if (productObject != null)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = SetValueGeneralMaterialItemFromProduct(productObject);
                if (entity.GeneralMaterialList != null && entity.GeneralMaterialList.Count > 0)
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = entity.GeneralMaterialList.Count + 1;
                else
                    objProductionNormItemsInfo.MMProductionNormItemSortOrder = 1;

                #region calculate qty by config
                ICProductsController pController = new ICProductsController();
                ICProductsInfo carcass = (ICProductsInfo)pController.GetObjectByID(objProductionNormsInfo.FK_ICProductCarcassID);

                ICProductPackingDetailsController pdController = new ICProductPackingDetailsController();
                List<ICProductPackingDetailsInfo> ICProductPackingDetailsList = pdController.GetByProductID(objProductionNormsInfo.FK_ICProductCarcassID);

                ICMaterialConfigsController mcController = new ICMaterialConfigsController();
                List<ICMaterialConfigsInfo> lstConfig = mcController.GetAllAliveAndActiveConfig();

                List<ICMaterialConfigsInfo> lstMatchConfig;
                if (carcass != null)
                {
                    lstMatchConfig = lstConfig.Where(t => t.FK_ICProductID == objProductionNormItemsInfo.FK_ICProductID).ToList();
                    if (lstMatchConfig != null && lstMatchConfig.Any())
                    {
                        foreach (ICMaterialConfigsInfo config in lstMatchConfig)
                        {
                            CalculateMaterialQtyByConfig(objProductionNormItemsInfo, config, carcass, objProductionNormsInfo, ICProductPackingDetailsList);
                        }
                    }
                }
                #endregion

                entity.GeneralMaterialList.Add(objProductionNormItemsInfo);
                entity.GeneralMaterialList.GridControl.RefreshDataSource();
                return objProductionNormItemsInfo;
            }
            return null;

        }
        public MMProductionNormItemsInfo SetValueGeneralMaterialItemFromProduct(ICProductsInfo objProductsInfo)
        {
            MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
            objProductionNormItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProductionNormItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProductionNormItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProductionNormItemsInfo.MMProductionNormItemProductName = objProductsInfo.ICProductName;
            objProductionNormItemsInfo.MMProductionNormItemNo = objProductsInfo.ICProductNo;
            objProductionNormItemsInfo.MMProductionNormItemNeededTime = DateTime.Now;
            objProductionNormItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductionNormItemsInfo.MMProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            objProductionNormItemsInfo.MMProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objProductionNormItemsInfo.MMProductionNormItemGroup = ProductType.GeneralMaterial.ToString();
            objProductionNormItemsInfo.MMProductionNormItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
                objProductionNormItemsInfo.MMProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;

            if (objProductionNormItemsInfo.SubList == null)
                objProductionNormItemsInfo.SubList = new BOSTreeList();
            return objProductionNormItemsInfo;
        }
        public void RemoveSelectedItemFromGeneralMaterialList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                entity.GeneralMaterialList.RemoveSelectedRowObjectFromList();
                entity.GeneralMaterialList.GridControl.RefreshDataSource();
            }
        }
        public void ResetGeneralMaterialSortOrder()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            int sortOrder = 1;
            foreach (MMProductionNormItemsInfo item in entity.GeneralMaterialList)
            {
                item.MMProductionNormItemSortOrder = sortOrder++;
            }
            entity.GeneralMaterialList.GridControl.RefreshDataSource();
        }
        #endregion

        public void InvalidateWoodTreeList()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
            int carcassID = mainObject.FK_ICProductCarcassID;
            if (carcassID == 0)
                carcassID = mainObject.FK_ICProductID;
            List<MMProductionNormItemsInfo> collection = productItemController.GetCarcassByProductID(carcassID);

            entity.ProductionNormItemList.Clear();

            if (collection != null && collection.Any())
            {
                entity.ProductionNormItemList.Invalidate(collection, 0);
            }
            RefreshProductItemTreeListView(entity.ProductionNormItemList);

            UpdateProductionNormInfo();
        }

        public void RefreshProductItemTreeListView(BOSTreeList treelist)
        {
            if (treelist != null && treelist.TreeListControl != null)
            {
                treelist.TreeListControl.RefreshDataSource();
                treelist.TreeListControl.ExpandAll();
                treelist.TreeListControl.BestFitColumns();
            }
        }
        public void InvalidateBOMGeneralMaterial()
        {
            ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
            MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            List<MMProductionNormItemsInfo> collection = new List<MMProductionNormItemsInfo>();
            if (mainObject.FK_ICProductCarcassID != mainObject.FK_ICProductID)
            {
                MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
                collection = productItemController.GetCarcassByProductIDGeneralMaterial(mainObject.FK_ICProductCarcassID);
            }

            entity.GeneralMaterialCarcassList.Invalidate(collection);
            entity.GeneralMaterialCarcassList.GridControl.RefreshDataSource();


        }

        private void UpdateProductionNormInfo()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                decimal totalM3 = 0;
                decimal totalM2 = 0;

                ProductionNormEntities entity = (ProductionNormEntities)CurrentModuleEntity;
                MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
                foreach (MMProductionNormItemsInfo pnItem in entity.ProductionNormItemList)
                {
                    totalM3 += pnItem.MMProductionNormItemBlockPerOne
                                * pnItem.MMProductionNormItemQuantity;

                    totalM2 += (pnItem.MMProductionNormItemPaintA + pnItem.MMProductionNormItemPaintB);
                }

                mainObject.MMProductionNormBlock = totalM3;
                mainObject.MMProductionNormTotalPaint = totalM2;

                entity.UpdateMainObjectBindingSource();
            }
        }
    }
}

using BOSCommon.Constants;
using System;
using BOSLib;
using BOSCommon;

namespace BOSERP.Modules.PaintProcesses
{
    public class PaintProcessesEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSTreeList PaintProcessesItemList { get; set; }

        #endregion

        #region Constructor
        public PaintProcessesEntities()
            : base()
        {
            PaintProcessesItemList = new BOSTreeList();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMPaintProcessessInfo();
            SearchObject = new MMPaintProcessessInfo();
        }
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMPaintProcessesItemTableName, new MMPaintProcessesItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            PaintProcessesItemList.InitBOSList(this,
                                             TableName.MMPaintProcessesTableName,
                                             TableName.MMPaintProcessesItemTableName,
                                             BOSTreeList.cstRelationForeign);
            PaintProcessesItemList.ItemTableForeignKey = "FK_MMPaintProcessesID";


        }

        public override void InitGridControlInBOSList()
        {
            PaintProcessesItemList.InitBOSTreeListControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMPaintProcessessInfo mainObject = (MMPaintProcessessInfo)MainObject;
            mainObject.MMPaintProcessesStatus = Status.New.ToString();
            mainObject.MMPaintProcessesIsActive = true;
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PaintProcessesItemList.SetDefaultListAndRefreshTreeListControl();

            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            PaintProcessesItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            MMPaintProcessessInfo objProductsInfo = (MMPaintProcessessInfo)MainObject;
            //if (!((PaintProcessesModule)Module).CheckExistPaintProcesses())
            //{
            int iObjectID = base.SaveMainObject();
            return iObjectID;
            //}
            //else
            //{
            //    objProductsInfo.MMPaintProcessesNo = cstNewObjectText;
            //    return 0;
            //}
        }

        public override void SaveModuleObjects()
        {

            MMPaintProcessessInfo objPaintProcessessInfo = (MMPaintProcessessInfo)MainObject;
            objPaintProcessessInfo.MMPaintProcessesTotalAmount = Math.Round(objPaintProcessessInfo.MMPaintProcessesTotalAmount, 0, MidpointRounding.AwayFromZero);
            foreach (MMPaintProcessesItemsInfo item in PaintProcessesItemList)
            {
                item.FK_MMPaintProcessesID = objPaintProcessessInfo.MMPaintProcessesID;
                item.MMPaintProcessesItemProductQty = Math.Round(item.MMPaintProcessesItemProductQty, 4, MidpointRounding.AwayFromZero);
                item.MMPaintProcessesItemMixRatio = item.MMPaintProcessesItemMixRatio;
                item.MMPaintProcessesItemProductUnitCost = Math.Round(item.MMPaintProcessesItemProductUnitCost, 0, MidpointRounding.AwayFromZero);
                item.MMPaintProcessesItemTotalCost = Math.Round(item.MMPaintProcessesItemTotalCost, 0, MidpointRounding.AwayFromZero);
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMPaintProcessesItemsInfo obj in item.SubList)
                    {
                        obj.FK_MMPaintProcessesID = objPaintProcessessInfo.MMPaintProcessesID;
                        obj.MMPaintProcessesItemProductQty = Math.Round(obj.MMPaintProcessesItemProductQty, 4, MidpointRounding.AwayFromZero);
                        obj.MMPaintProcessesItemMixRatio = obj.MMPaintProcessesItemMixRatio;
                        obj.MMPaintProcessesItemProductUnitCost = Math.Round(obj.MMPaintProcessesItemProductUnitCost, 0, MidpointRounding.AwayFromZero);
                        obj.MMPaintProcessesItemTotalCost = Math.Round(obj.MMPaintProcessesItemTotalCost, 0, MidpointRounding.AwayFromZero);
                    }
                }



            }
            PaintProcessesItemList.SaveItemObjects();
        }

        public void UpdateTotalAmount()
        {
            MMPaintProcessessInfo objPaintProcessessInfo = (MMPaintProcessessInfo)MainObject;
            objPaintProcessessInfo.MMPaintProcessesTotalAmount = 0;
            foreach (MMPaintProcessesItemsInfo item in PaintProcessesItemList)
            {
                if (item.FK_ICProductID != 0)
                {
                    objPaintProcessessInfo.MMPaintProcessesTotalAmount += item.MMPaintProcessesItemTotalCost;
                }
                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMPaintProcessesItemsInfo itemChild in item.SubList)
                    {
                        objPaintProcessessInfo.MMPaintProcessesTotalAmount += itemChild.MMPaintProcessesItemTotalCost;
                    }
                }
            }
            UpdateMainObjectBindingSource();
        }

        public override void DuplicateModuleObjectList()
        {
            MMPaintProcessessInfo objPaintProcessessInfo = (MMPaintProcessessInfo)MainObject;
            objPaintProcessessInfo.MMPaintProcessesStatus = PaintProcessesStatus.New.ToString();
            PaintProcessesItemList.Duplicate();
            MMPaintProcessesItemsController objPaintProcessesItemsController = new MMPaintProcessesItemsController();
            foreach (MMPaintProcessesItemsInfo item in PaintProcessesItemList)
            {
                if (item.FK_ICProductID == 0)
                {
                    item.FK_MMPaintProcessesID = 0;
                    objPaintProcessesItemsController.CreateObject(item);
                }
            }
            PaintProcessesItemList.TreeListControl.RefreshDataSource();
            PaintProcessesItemList.TreeListControl.ExpandAll();
            PaintProcessesItemList.TreeListControl.BestFitColumns();
        }
        #endregion

        #region Delete Object functions
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                PaintProcessesItemList.DeleteItemObjects();
            }
        }
        #endregion
    }
}

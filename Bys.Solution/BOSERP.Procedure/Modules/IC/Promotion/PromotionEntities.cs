using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using BOSLib;

namespace BOSERP.Modules.Promotion
{
    public class PromotionEntities : ERPModuleEntities
    {
        #region Declare Constant
        public readonly static String strICPromotionsObjectName = "ICPromotions";
        public readonly static String strICPromotionItemsObjectName = "ICPromotionItems";
        public readonly static String strICPromotionItemDetailsObjectName = "ICPromotionItemDetails";
        public readonly static String cstICDepartmentAttributesObjectName = "ICDepartmentAttributes";
        public readonly static String cstICDepartmentAttributeValuesObjectName = "ICDepartmentAttributeValues";
        #endregion
        
        #region Declare all entities variables
        private ICPromotionsInfo _iCPromotionsObject;
        private ICPromotionItemsInfo _iCPromotionItemsObject;
        private ICPromotionItemDetailsInfo _iCPromotionItemDetailsObject;

        private BOSList<ICPromotionItemsInfo> _lstICPromotionItems;
        private BOSList<ICPromotionItemDetailsInfo> _lstICPromotionItemDetails;
        #endregion

        #region Public Properties
        public ICPromotionsInfo ICPromotionsObject
        {
            get
            {
                return _iCPromotionsObject;
            }
            set
            {
                _iCPromotionsObject = value;
            }
        }
        public ICPromotionItemsInfo ICPromotionItemsObject
        {
            get
            {
                return _iCPromotionItemsObject;
            }
            set
            {
                _iCPromotionItemsObject = value;
            }
        }
        public ICPromotionItemDetailsInfo ICPromotionItemDetailsObject
        {
            get
            {
                return _iCPromotionItemDetailsObject;
            }
            set
            {
                _iCPromotionItemDetailsObject = value;
            }
        }

        public BOSList<ICPromotionItemsInfo> ICPromotionItemsList
        {
            get
            {
                return _lstICPromotionItems;
            }
            set
            {
                _lstICPromotionItems = value;
            }
        }      
        public BOSList<ICPromotionItemDetailsInfo> ICPromotionItemDetailsList
        {
            get
            {
                return _lstICPromotionItemDetails;
            }
            set
            {
                _lstICPromotionItemDetails = value;
            }
        }
        #endregion

        #region Constructor
        public PromotionEntities()
            : base()
        {
            _iCPromotionsObject = new ICPromotionsInfo();

            _iCPromotionItemsObject = new ICPromotionItemsInfo();
            _iCPromotionItemDetailsObject = new ICPromotionItemDetailsInfo();

            _lstICPromotionItems = new BOSList<ICPromotionItemsInfo>();
            _lstICPromotionItemDetails = new BOSList<ICPromotionItemDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

            MainObject = ICPromotionsObject;
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ICPromotionItems", ICPromotionItemsObject);
            ModuleObjects.Add("ICPromotionItemDetails", ICPromotionItemDetailsObject);
        }

        public override void InitModuleObjectList()
        {
            ICPromotionItemsList = new BOSList<ICPromotionItemsInfo>();
            //PromotionItemsEntityList.InitBOSList(this, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICPromotionItemsInfo)));
            ICPromotionItemsList.InitBOSList(this, "ICPromotions", "ICPromotionItems");
            ICPromotionItemDetailsList = new BOSList<ICPromotionItemDetailsInfo>();
            //ICPromotionItemDetailsList.InitBOSList(this, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICPromotionItemDetailsInfo)));
            ICPromotionItemDetailsList.InitBOSList(this, "ICPromotionItems", "ICPromotionItemDetails");
        }

        public override void InitGridControlInBOSList()
        {
            ICPromotionItemsList.InitBOSListGridControl();
            ICPromotionItemDetailsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ICPromotionItemsList.SetDefaultListAndRefreshGridControl();
                ICPromotionItemDetailsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void  InvalidateModuleObject(BusinessObject obj)
        {
            base.InvalidateModuleObject(obj);
            if (obj.GetType() == typeof(ICPromotionItemsInfo))
            {
                ICPromotionItemDetailsList.Invalidate(((ICPromotionItemsInfo)obj).ICPromotionItemID);
            }
        }
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            ((PromotionModule)this.Module).EnableDisableControlsByPromotionType(((ICPromotionsInfo)MainObject).ICPromotionTypeCombo);
        }
        public override void InvalidateModuleObject(ERPModuleItemsEntity entItem, string strModuleObjectName)
        {
            base.InvalidateModuleObject(entItem, strModuleObjectName);
            if (strModuleObjectName == strICPromotionItemsObjectName)
            {
                PromotionItemsEntity pie = (PromotionItemsEntity)entItem;
                ICPromotionItemDetailsController objPromotionItemDetailsController = new ICPromotionItemDetailsController();
                if (pie.ICPromotionItemDetailsList == null)
                {
                    pie.ICPromotionItemDetailsList = new BOSList<ICPromotionItemDetailsInfo>();
                    DataSet ds = objPromotionItemDetailsController.GetAllDataByForeignColumn("FK_ICPromotionItemID", pie.ICPromotionItemID);
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            ICPromotionItemDetailsInfo objPromotionItemDetaisInfo = (ICPromotionItemDetailsInfo)objPromotionItemDetailsController.GetObjectFromDataRow(row);
                            pie.ICPromotionItemDetailsList.Add(objPromotionItemDetaisInfo);
                        }
                    }
                }

                ICPromotionItemDetailsList.Invalidate(pie.ICPromotionItemDetailsList);
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICPromotionItemsList.Invalidate(iObjectID);

            //Calcuate regular price and discount price for all items
            ICProductsController objProductsController = new ICProductsController();
            foreach (ICPromotionItemsInfo objPromotionItem in ICPromotionItemsList)
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objPromotionItem.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objPromotionItem.ICPromotionItemRegularePrice = Convert.ToDouble(objProductsInfo.ICProductPrice01);
                    objPromotionItem.ICPromotionItemDiscountPrice = ((PromotionModule)Module).CalculateDiscountPriceByPromotiontype(Convert.ToDouble(objProductsInfo.ICProductPrice01));
                }
            }
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ICPromotionItemsList.SaveItemObjects();
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            if (strTableName == PromotionEntities.strICPromotionsObjectName)
            {
                ICPromotionItemsController objPromotionItemsController = new ICPromotionItemsController();
                objPromotionItemsController.DeleteByForeignColumn("FK_ICPromotionID", iObjectID);
            }
        }
    }
}

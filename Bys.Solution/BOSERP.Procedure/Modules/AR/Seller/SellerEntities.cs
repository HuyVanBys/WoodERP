using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Seller
{
    class SellerEntities : ERPModuleEntities
    {
        #region Declare Constant
        public readonly static String strARSellersObjectName = "ARSellers";
        public readonly static String strARSellerContactsObjectName = "ARSellerContacts";
        public readonly static String strARSellerProductsObjectName = "ARSellerProducts";
        #endregion

        #region Declare all entities variables
        private ARSellersInfo _sellersObject;
        private ARSellerContactsInfo _sellerContactsObject;
        private ARSellerProductsInfo _sellerProductsObject;

        public BOSList<ARSellerContactsInfo> lstARSellerContacts;
        public BOSList<ARSellerProductsInfo> lstARSellerProducts;
        #endregion

        #region Public Properties
        public ARSellersInfo SellersObject
        {
            get
            {
                return _sellersObject;
            }
            set
            {
                _sellersObject = value;
            }
        }

        public ARSellerContactsInfo SellerContactsObject
        {
            get
            {
                return _sellerContactsObject;
            }
            set
            {
                _sellerContactsObject = value;
            }
        }

        public BOSList<ARSellerContactsInfo> ARSellerContactsList
        {
            get
            {
                return lstARSellerContacts;
            }
            set
            {
                lstARSellerContacts = value;
            }
        }

        public BOSList<ARSellerProductsInfo> ARSellerProductsList
        {
            get
            {
                return lstARSellerProducts;
            }
            set
            {
                lstARSellerProducts = value;
            }
        }

        #endregion

        #region Constructor
        public SellerEntities()
            : base()
        {
            _sellersObject = new ARSellersInfo();

            _sellerContactsObject = new ARSellerContactsInfo();

            lstARSellerContacts = new BOSList<ARSellerContactsInfo>();
            lstARSellerProducts = new BOSList<ARSellerProductsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

            MainObject = SellersObject;
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ARSellerContacts", SellerContactsObject);
        }

        public override void InitModuleObjectList()
        {
            lstARSellerContacts = new BOSList<ARSellerContactsInfo>();
            //lstARSellerContacts.InitBOSList(this,BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARSellerContactsInfo)));
            lstARSellerContacts.InitBOSList(this, "ARSellers", "ARSellerContacts");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                lstARSellerContacts.Clear();
                BindingSource bds = new BindingSource();
                bds.DataSource = lstARSellerContacts;
                //lstARSellerContacts.GridControl.DataSource = bds;

                (Module.Controls["fld_dgcARSellerContacts"] as BOSComponent.BOSGridControl).DataSource = bds;

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
            //Invalidate all objects related with ARSellerContacts
            //InvalidateMAContactsAndMAAddressObjects(iObjectID);            
            ARSellerContactsList.Invalidate(iObjectID);
        }


        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {

        }

        #endregion
    }
}

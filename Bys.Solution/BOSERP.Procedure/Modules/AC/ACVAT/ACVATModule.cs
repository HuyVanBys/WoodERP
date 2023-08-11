using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP.Modules.ACVAT
{
    public class ACVATModule : BaseTransactionModule
    {
        #region Constant
        public BOSLookupEdit VATDocumentTypeLookupEditControl = null;
        #endregion
        public ACVATModule()
        {
            Name = ModuleName.ACVAT;
            CurrentModuleEntity = new ACVATEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            VATDocumentTypeLookupEditControl = (BOSLookupEdit)Controls["fld_lkeACVATDocumentType"];
            VATDocumentTypeLookupEditControl.Properties.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(Properties_CustomDisplayText);
        }

        void Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            ACVATEntities entity = (ACVATEntities)CurrentModuleEntity;
            ACVATsInfo objVATsInfo = (ACVATsInfo)entity.MainObject;
            ADConfigValuesController controller = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = controller.GetObjectByGroupAndValue(ConfigValueGroup.VATDocumentType, objVATsInfo.ACVATDocumentType);
            if (objConfigValuesInfo != null && VATDocumentTypeLookupEditControl != null)
                e.DisplayText = objConfigValuesInfo.ADConfigText;
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACVATsController objVATsController = new ACVATsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACVATsInfo searchObject = (ACVATsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = objVATsController.GetVATList(
                                                                       searchObject.ACVATNo,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       searchObject.ACVATInvoiceType,
                                                                       searchObject.VATDateFrom,
                                                                       searchObject.VATDateTo);
            return ds;

        }

        public void ChangeObject(string objectAccessKey)
        {
            ACVATsInfo objVATsInfo = (ACVATsInfo)CurrentModuleEntity.MainObject;
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                objVATsInfo.ACObjectAccessKey = objectAccessKey;
                ACObjectsController objObjectsController = new ACObjectsController();
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
                objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
                if (objObjectsInfo != null)
                {
                    objVATsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                    objVATsInfo.ACObjectType = objObjectsInfo.ACObjectType;
                    if (objObjectsInfo.ACObjectType == ObjectType.Supplier.ToString())
                    {
                        APSuppliersController objSuppliersController = new APSuppliersController();
                        APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(objObjectsInfo.ACObjectID);
                        if (supplier != null)
                        {
                            objVATsInfo.ACVATObjectName = supplier.APSupplierName;
                            objVATsInfo.ACVATObjectAddress = supplier.APSupplierContactAddressLine3;
                            objVATsInfo.ACVATObjectTaxNumber = supplier.APSupplierTaxNumber;
                        }
                    }
                    else if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                    {
                        ARCustomersController objCustomersController = new ARCustomersController();
                        ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(objObjectsInfo.ACObjectID);
                        if (customer != null)
                        {
                            objVATsInfo.ACVATObjectName = customer.ARCustomerName;
                            objVATsInfo.ACVATObjectAddress = customer.ARCustomerContactAddressLine3;
                            objVATsInfo.ACVATObjectTaxNumber = customer.ARCustomerTaxNumber;
                        }
                    }
                }
            }
            else
            {
                objVATsInfo.FK_ACObjectID = 0;
                objVATsInfo.ACObjectType = string.Empty;
                objVATsInfo.ACVATObjectName = string.Empty;
                objVATsInfo.ACVATObjectAddress = string.Empty;
                objVATsInfo.ACVATObjectTaxNumber = string.Empty;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ChangeVATAmount()
        {
            ((ACVATEntities)CurrentModuleEntity).UpdateTotalAmount();
        }

        public void ChangeVATTaxPercent()
        {
            ((ACVATEntities)CurrentModuleEntity).UpdateTotalAmount();
        }

        public void ChangeVATTaxAmount()
        {
            ACVATsInfo objVATsInfo = (ACVATsInfo)CurrentModuleEntity.MainObject;
            if (objVATsInfo.ACVATAmount > 0)
                objVATsInfo.ACVATTaxPercent = objVATsInfo.ACVATTaxAmount / objVATsInfo.ACVATAmount * 100;
            ((ACVATEntities)CurrentModuleEntity).UpdateTotalAmount();
        }
        public List<ADConfigValuesInfo> GetVATDocumentTypeDatasource(string InvoiceType)
        {
            List<ADConfigValuesInfo> dataSource = new List<ADConfigValuesInfo>();
            ADConfigValuesController controller = new ADConfigValuesController();
            DataSet ds = controller.GetADConfigValuesByGroup(ConfigValueGroup.VATDocumentType);
            if (ds != null && ds.Tables.Count != 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADConfigValuesInfo configValue = controller.GetObjectFromDataRow(row) as ADConfigValuesInfo;
                    if (InvoiceType != string.Empty)
                    {
                        if (InvoiceType == "Input")
                        {
                            if (configValue.ADConfigKeyDesc == InvoiceType)
                                dataSource.Add(configValue);
                            else
                                continue;
                        }
                        else
                        {
                            if (configValue.ADConfigKeyDesc != "Input")
                                dataSource.Add(configValue);
                            else
                                continue;
                        }
                    }
                    else
                        dataSource.Add(configValue);
                }
            }
            return dataSource;
        }

        public void ChangeVATDocumentType(string VATDocumentType)
        {
            ACVATEntities entity = (ACVATEntities)CurrentModuleEntity;
            ACVATsInfo objVATsInfo = (ACVATsInfo)entity.MainObject;
            ADConfigValuesController controller = new ADConfigValuesController();

            if (VATDocumentType != string.Empty)
            {
                objVATsInfo.ACVATDocumentType = VATDocumentType;
                ADConfigValuesInfo objConfigValuesInfo = controller.GetObjectByGroupAndValue(ConfigValueGroup.VATDocumentType, objVATsInfo.ACVATDocumentType);
                if (objConfigValuesInfo != null && VATDocumentTypeLookupEditControl != null)
                {
                    VATDocumentTypeLookupEditControl.EditValue = objVATsInfo.ACVATDocumentType;
                    VATDocumentTypeLookupEditControl.Text = objConfigValuesInfo.ADConfigText;
                }
                entity.UpdateMainObjectBindingSource();
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            ACVATEntities entity = (ACVATEntities)CurrentModuleEntity;
            ACVATsInfo objVATsInfo = (ACVATsInfo)entity.MainObject;
            ADConfigValuesController controller = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = controller.GetObjectByGroupAndValue(ConfigValueGroup.VATDocumentType, objVATsInfo.ACVATDocumentType);
            if (objVATsInfo.ACVATDocumentType != string.Empty && VATDocumentTypeLookupEditControl != null)
            {
                VATDocumentTypeLookupEditControl.Properties.DataSource = GetVATDocumentTypeDatasource(objVATsInfo.ACVATDocumentType);
                VATDocumentTypeLookupEditControl.EditValue = objVATsInfo.ACVATDocumentType;
                if (objConfigValuesInfo != null)
                    VATDocumentTypeLookupEditControl.Text = objConfigValuesInfo.ADConfigText;
            }
        }
    }
}

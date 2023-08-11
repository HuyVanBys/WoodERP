using BOSComponent;
using DevExpress.XtraEditors.Controls;
using Localization;
using System.Collections.Generic;

namespace BOSERP.Modules.SupplierPayment
{
    public partial class ExchangeWayLookupEdit : BOSLookupEdit
    {
        public override void InitializeControl()
        {
            base.InitializeControl();

            Properties.ValueMember = "Value";
            Properties.DisplayMember = "DisplayedText";
            Properties.Columns.Add(new LookUpColumnInfo("DisplayedText", SupplierPaymentLocalizedResources.ExchangeWay));
        }

        /// <summary>
        /// Initialize data source for the lookup edit
        /// </summary>
        /// <param name="documentCurrencyID">Currency id of the supplier payment</param>
        public void InitDataSource(int documentCurrencyID)
        {
            GECurrenciesController objCurrencysController = new GECurrenciesController();
            GECurrenciesInfo documentCurrency = null;
            if (documentCurrencyID > 0)
            {
                documentCurrency = (GECurrenciesInfo)objCurrencysController.GetObjectByID(documentCurrencyID);
            }
            else
            {
                documentCurrency = (GECurrenciesInfo)objCurrencysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID);
            }
            if (documentCurrency != null)
            {
                List<GECurrenciesInfo> currencys = objCurrencysController.GetAllCurrencys();
                List<ExchangeWay> exchangeWays = new List<ExchangeWay>();
                foreach (GECurrenciesInfo objCurrencysInfo in currencys)
                {
                    string displayedText = string.Format("{0} --> {1}", objCurrencysInfo.GECurrencyName, documentCurrency.GECurrencyName);
                    exchangeWays.Add(new ExchangeWay(string.Format("{0}{1}", objCurrencysInfo.GECurrencyID, documentCurrency.GECurrencyID), displayedText));
                    if (objCurrencysInfo.GECurrencyID != documentCurrencyID)
                    {
                        displayedText = string.Format("{0} --> {1}", documentCurrency.GECurrencyName, objCurrencysInfo.GECurrencyName);
                        exchangeWays.Add(new ExchangeWay(string.Format("{0}{1}", documentCurrency.GECurrencyID, objCurrencysInfo.GECurrencyID), displayedText));
                    }
                }
                Properties.DataSource = exchangeWays;
            }
        }
    }
}

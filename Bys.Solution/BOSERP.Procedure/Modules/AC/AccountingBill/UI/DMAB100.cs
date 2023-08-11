using BOSComponent;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountingBill.UI
{
    /// <summary>
    /// Summary description for DMAB100
    /// </summary>
    public partial class DMAB100 : BOSERPScreen
    {

        public DMAB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        public override Control InitializeControl(Control ctrl)
        {
            ctrl = base.InitializeControl(ctrl);

            if (ctrl.Name == "fld_lkeFK_ACAssObjectID")
            {
                (ctrl as BOSLookupEdit).Properties.ValueMember = "ACAssObjectAccessKey";
            }
            return ctrl;
        }


        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
                ((AccountingBillModule)Module).ChangeFK_ACObjectID(e.Value.ToString());
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AccountingBillModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_txtACDocumentExchangeRate_Validated(object sender, EventArgs e)
        {
            ((AccountingBillModule)Module).UpdateAccountingBillList();
        }

        private void fld_dgcACAccountingBills_Load(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_PMProjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int projectID = 0;
                if (int.TryParse(e.Value.ToString(), out projectID))
                {
                    ((AccountingBillModule)Module).ChangeProject(projectID);
                }
            }
        }

        private void fld_lkeFK_ACSegmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int segmentID = 0;
                if (int.TryParse(e.Value.ToString(), out segmentID))
                {
                    ((AccountingBillModule)Module).ChangeSegment(segmentID);
                }
            }
        }

        private void fld_lkeFK_ACObjectID_Validated(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;

            AccountingBillModule module = (AccountingBillModule)Module;
            AccountingBillEntities entity = (AccountingBillEntities)module.CurrentModuleEntity;
            ACDocumentsInfo mainObj = (ACDocumentsInfo)entity.MainObject;
            if (mainObj.ACObjectAccessKey != null)
            {
                string[] objArr = mainObj.ACObjectAccessKey.ToString().Split(';');
                if (objArr.Length == 2)
                {
                    foreach (var item in entity.AccountingBillsList)
                    {
                        if (item.ACObjectAccessKey == mainObj.ACObjectAccessKey)
                        {
                            int objectID = int.Parse(objArr[0]);
                            ACObjectsController objectController = new ACObjectsController();
                            ACObjectsInfo objObjectsInfo = objectController.GetObjectByIDAndType(objectID, objArr[1]);
                            if (objObjectsInfo != null)
                            {
                                item.ACAccountingBillTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                            }
                        }
                    }
                    entity.AccountingBillsList.GridControl.RefreshDataSource();
                }
            }
        }

        private void fld_medACDocumentDesc_Validated(object sender, EventArgs e)
        {
            ((AccountingBillModule)Module).UpdateItemDesc();
        }
    }
}

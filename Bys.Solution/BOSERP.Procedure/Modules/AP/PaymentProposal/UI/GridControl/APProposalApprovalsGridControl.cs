using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentProposal
{
    public partial class APPaymentProposalApprovalsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public void InvalidateDataSource(List<APPaymentProposalApprovalsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "HREmployeeName", "Người duyệt");
            AddGridColumn(strTableName, "APPaymentProposalApprovalDate", "Ngày xét duyệt");
            AddGridColumn(strTableName, "APPaymentProposalApprovalAction", "Hành động duyệt");
            AddGridColumn(strTableName, "APPaymentProposalApprovalMessages", "Lời nhắn");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "")
        {

            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAAllowDummy = true,
                Visible = true
            });
        }
    }
}

Update ADReports
Set AAStatus = 'Delete'
Where ADReportNo = 'RP108'

--
Update AAColumnAlias
Set AAColumnAliasName = N'FK_GEPaymentTermID', AAReferenceTable = 'GEPaymentTerms', AADisplayedMember = 'GEPaymentTermName'
Where AAColumnAliasName = 'ARCustomerPaymentTerm' and AATableName = 'ARCustomers'

Update AAColumnAlias
Set AAStatus = 'Delete'
Where AAColumnAliasName = 'APInvoiceInStatusDisplayText' and AATableName = 'APInvoiceIns'

Update AAColumnAlias
Set  AAReferenceTable = 'GECurrencies', AADisplayedMember = 'GECurrencyName'
Where AAColumnAliasName = 'FK_GECurrencyID' and AATableName = 'ARReceiptVouchers'

Update AAColumnAlias
Set AAColumnAliasCaption = N'Khoản mục chi phí'
Where AAColumnAliasName = 'FK_ACSegmentID' and AATableName = 'ICShipments'
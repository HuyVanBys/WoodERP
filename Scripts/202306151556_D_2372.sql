﻿insert into AAColumnAlias Values (0, '', 'Alive', 'APInvoiceInItemExchangeExtCost', N'Tiền hàng VND', 'APInvoiceInItems', '', '', '', '', 1, 0)
insert into AAColumnAlias Values (0, '', 'Alive', 'APInvoiceInItemExchangeTaxAmount', N'Tiền thuế VND', 'APInvoiceInItems', '', '', '', '', 1, 0)
insert into AAColumnAlias Values (0, '', 'Alive', 'APInvoiceInItemExchangeTotalCost', N'Tổng tiền VND', 'APInvoiceInItems', '', '', '', '', 1, 0)
insert into STFieldFormats values ('InvoiceIn', 'APInvoiceInItems', (Select STFieldFormatGroupID from STFieldFormatGroups Where STFieldFormatGroupName = 'FormatGroupPrice'),'APInvoiceInItemExchangeExtCost', 0, 0)
insert into STFieldFormats values ('InvoiceIn', 'APInvoiceInItems', (Select STFieldFormatGroupID from STFieldFormatGroups Where STFieldFormatGroupName = 'FormatGroupPrice'),'APInvoiceInItemExchangeTaxAmount', 0, 0)
insert into STFieldFormats values ('InvoiceIn', 'APInvoiceInItems', (Select STFieldFormatGroupID from STFieldFormatGroups Where STFieldFormatGroupName = 'FormatGroupPrice'),'APInvoiceInItemExchangeTotalCost', 0, 0)
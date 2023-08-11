--Đã chạy DB dev, test, ĐỨc THành
DELETE dbo.ADConfigValues WHERE ADConfigKeyGroup = 'OutputVATDocumentType'

INSERT INTO dbo.ADConfigValues VALUES ('Alive', N'OutputVATDocumentTypeInvoiceType1', N'InvoiceType1', N'1. Hàng hóa, dịch vụ không chịu thuế GTGT:', N'OutputVATDocumentTypeInvoiceType1', N'OutputVATDocumentType', 1) 
INSERT INTO dbo.ADConfigValues VALUES ('Alive', N'OutputVATDocumentTypeInvoiceType2', N'InvoiceType2', N'2. Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 0%:', N'OutputVATDocumentTypeInvoiceType2', N'OutputVATDocumentType', 1) 
INSERT INTO dbo.ADConfigValues VALUES ('Alive', N'OutputVATDocumentTypeInvoiceType3', N'InvoiceType3', N'3. Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 5%:', N'OutputVATDocumentTypeInvoiceType3', N'OutputVATDocumentType', 1) 
INSERT INTO dbo.ADConfigValues VALUES ('Alive', N'OutputVATDocumentTypeInvoiceType4', N'InvoiceType4', N'4. Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 8%:', N'OutputVATDocumentTypeInvoiceType4', N'OutputVATDocumentType', 1) 
INSERT INTO dbo.ADConfigValues VALUES ('Alive', N'OutputVATDocumentTypeInvoiceType5', N'InvoiceType5', N'5. Hàng hóa, dịch vụ không phải tổng hợp trên tờ khai 01/GTGT:', N'OutputVATDocumentTypeInvoiceType5', N'OutputVATDocumentType', 1) 
INSERT INTO dbo.ADConfigValues VALUES ('Alive', N'OutputVATDocumentTypeInvoiceType6', N'InvoiceType6', N'6. Hàng hóa, dịch vụ chịu thuế suất thuế GTGT 10%:', N'OutputVATDocumentTypeInvoiceType6', N'OutputVATDocumentType', 1) 

CREATE TABLE ICShipmentItemComponents
([ICShipmentItemComponentID] [int] NOT NULL IDENTITY(1, 1),
[AAStatus] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[FK_ICShipmentItemID] [int] NOT NULL,
[FK_ICStockID] [int] NOT NULL,
[FK_ICProductID] [int] NOT NULL,
[FK_ICProductSerieID] [int] NOT NULL,
[ICShipmentItemComponentQty] [decimal] (18, 5) NULL,
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ICShipmentItemComponents] ADD CONSTRAINT [PK_ICShipmentItemComponents] PRIMARY KEY CLUSTERED ([ICShipmentItemComponentID]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Idx_ICShipmentItemComponents] ON [dbo].[ICShipmentItemComponents] ([FK_ICProductID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ICShipmentItemComponents] ADD CONSTRAINT [FK_ICShipmentItemComponents_ICShipmentItems] FOREIGN KEY ([FK_ICShipmentItemID]) REFERENCES [dbo].[ICShipmentItems] ([ICShipmentItemID])
GO
ALTER TABLE [dbo].[ICShipmentItemComponents] ADD CONSTRAINT [FK_ICShipmentItemComponents_ICProducts] FOREIGN KEY ([FK_ICProductID]) REFERENCES [dbo].[ICProducts] ([ICProductID])
GO
ALTER TABLE [dbo].[ICShipmentItemComponents] ADD CONSTRAINT [FK_ICShipmentItemComponents_ICProductSeries] FOREIGN KEY ([FK_ICProductSerieID]) REFERENCES [dbo].[ICProductSeries] ([ICProductSerieID])
GO
ALTER TABLE [dbo].[ICShipmentItemComponents] ADD CONSTRAINT [FK_ICShipmentItemComponents_ICStocks] FOREIGN KEY ([FK_ICStockID]) REFERENCES [dbo].[ICStocks] ([ICStockID])
GO

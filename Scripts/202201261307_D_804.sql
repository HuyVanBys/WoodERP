Update AAColumnAlias
Set AAStatus = 'Delete'
Where AATableName = 'ARDiscountProgramItems' and AAColumnAliasName in ('ARDiscountProgramItemPriorityQty','ARDiscountProgramItemBasicPrice', 'ARDiscountProgramItemProductUnitPrice', 'ARDiscountProgramItemPriorityPrice', 'ARDiscountProgramItemIsExhibit', 'ARDiscountProgramItemBonusAmount')
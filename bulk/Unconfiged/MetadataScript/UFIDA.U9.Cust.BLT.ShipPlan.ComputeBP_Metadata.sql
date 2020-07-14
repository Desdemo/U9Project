	declare	@SNIndex bigint
	if object_id('InnerAllocSerials') is null
	    exec	[dbo].[AllocSerials]
			    @AllocCount = 20000,
			    @StartSN = @SNIndex output

	else
	    exec	[dbo].[InnerAllocSerials]
			    @AllocCount = 20000,
			    @StartSN = @SNIndex output
--Valid @SNIndex


execute sp_UninstallMDProject '7958f19a-cd89-424d-acf9-71990ba72195'
INSERT INTO UBF_MD_Project(Name, ID, AssemblyName, CreateOp, ComponentType, ModifyTime, ModifyOp, CreateTime) VALUES('ComputeBP', '7958f19a-cd89-424d-acf9-71990ba72195', 'UFIDA.U9.Cust.BLT.ShipPlan.ComputeBP', 'Administrator', 'BP', '2020-07-14T11:41:41', '', '2020-07-14T11:41:41')
INSERT INTO UBF_MD_Import(Source_ID, Imported_ID) VALUES('7958f19a-cd89-424d-acf9-71990ba72195', '91ad4317-b286-4156-b6f4-6a79ce43994a')
INSERT INTO UBF_MD_Component(Local_ID, Kind, Name, ID, AssemblyName, CreateOp, ModifyTime, Version, ModifyOp, MD_Module_ID, CreateTime) VALUES(@SNIndex+0, 'BP', 'FreightCalculationBP', 'd5a826c6-8101-48ab-97d3-1ff714356d02', 'UFIDA.U9.Cust.BLT.ShipPlan.ComputeBP', 'Administrator', '2020-07-14T11:41:41', '', '', '7958f19a-cd89-424d-acf9-71990ba72195', '2020-07-14T11:41:41')
INSERT INTO UBF_MD_Class (ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_ParentClass_ID, MD_Component_ID, Local_Component_ID, ClassType, FullName, IsDefault, IsService, TransactionType, ReturnTypeID, IsAuthority, Discriminator) VALUES ('85a2d1e7-52e2-459e-a3eb-cbcd26e3baa7', 'ComputeBP', 'Administrator', '2020-07-14T11:41:41', 'Administrator', '2020-07-14T15:49:53', @SNIndex+1, '00000000-0000-0000-0000-000000000000', 'd5a826c6-8101-48ab-97d3-1ff714356d02', @SNIndex+0, 7, 'UFIDA.U9.Cust.BLT.ShipPlan.ComputeBP.ComputeBP', 0, 0, 2, '9b412470-c8e9-407b-99b2-2b4c2508d4d1', 1, 'UFIDA.UBF.MD.Business.Operation')
INSERT INTO UBF_MD_Attribute(ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_Class_ID, Local_Class_ID, DataTypeID, GroupName, IsCollection, DefaultValue, Length, Precision, Sequence, Scale, MaxValue, MinValue, IsKey, IsNullable, IsReadOnly, Visibility, IsCalculation, IsGlobalization, IsSystem, IsBusinessKey, IsQueryAttribute, IsForAsso, GroupID, IsModifyControl, IsDynamic, IsImpressible, IsInCache, IsKeySerializable, IsColumnDefine, IsFilterDefine, IsSortDefine, IsDefaultColumn, IsEntityData, DefaultColumnName, DataTypeFlag,ForOBAImport) VALUES('0e3dcd32-139c-4b04-b626-8341c1f06923', 'Data', 'Administrator', '2020-07-14T11:41:41', '', '2020-07-14T11:41:41', @SNIndex+2, '85a2d1e7-52e2-459e-a3eb-cbcd26e3baa7', @SNIndex+1, '9b412470-c8e9-407b-99b2-2b4c2508d4d1', 'Misc', 0, '', 4, 10, 0, 0, '', '', 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 'f82e3de7-cbec-44b3-8dab-116908f74a2c', 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', 1,0)
INSERT INTO UBF_MD_Attribute(ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_Class_ID, Local_Class_ID, DataTypeID, GroupName, IsCollection, DefaultValue, Length, Precision, Sequence, Scale, MaxValue, MinValue, IsKey, IsNullable, IsReadOnly, Visibility, IsCalculation, IsGlobalization, IsSystem, IsBusinessKey, IsQueryAttribute, IsForAsso, GroupID, IsModifyControl, IsDynamic, IsImpressible, IsInCache, IsKeySerializable, IsColumnDefine, IsFilterDefine, IsSortDefine, IsDefaultColumn, IsEntityData, DefaultColumnName, DataTypeFlag,ForOBAImport) VALUES('02d7f7ee-b13a-495c-9961-16c9f3577bb0', 'DataLine', 'Administrator', '2020-07-14T11:41:41', '', '2020-07-14T11:41:41', @SNIndex+3, '85a2d1e7-52e2-459e-a3eb-cbcd26e3baa7', @SNIndex+1, '7c236994-42fa-4f5f-97de-edfea1c7966b', 'Misc', 1, '', 50, 5, 1, 0, '', '', 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 'f82e3de7-cbec-44b3-8dab-116908f74a2c', 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', 4,0)
INSERT INTO UBF_MD_Class (ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_ParentClass_ID, MD_Component_ID, Local_Component_ID, ClassType, FullName, IsDefault, IsService, TransactionType, ReturnTypeID, IsAuthority, Discriminator) VALUES ('429e0588-aa6b-429f-bfe7-76c88fb061e6', 'Operation', 'Administrator', '2020-07-14T11:41:41', 'Administrator', '2020-07-14T15:49:53', @SNIndex+4, '00000000-0000-0000-0000-000000000000', 'd5a826c6-8101-48ab-97d3-1ff714356d02', @SNIndex+0, 7, 'UFIDA.U9.Cust.BLT.ShipPlan.ComputeBP.Operation', 0, 0, 2, '378d45b4-375d-4b5d-8748-abc9575c26b3', 1, 'UFIDA.UBF.MD.Business.Operation')
INSERT INTO UBF_MD_Attribute(ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_Class_ID, Local_Class_ID, DataTypeID, GroupName, IsCollection, DefaultValue, Length, Precision, Sequence, Scale, MaxValue, MinValue, IsKey, IsNullable, IsReadOnly, Visibility, IsCalculation, IsGlobalization, IsSystem, IsBusinessKey, IsQueryAttribute, IsForAsso, GroupID, IsModifyControl, IsDynamic, IsImpressible, IsInCache, IsKeySerializable, IsColumnDefine, IsFilterDefine, IsSortDefine, IsDefaultColumn, IsEntityData, DefaultColumnName, DataTypeFlag,ForOBAImport) VALUES('69a5bfb7-7f51-4d18-86f0-a5815fdfc759', 'Amounts', 'Administrator', '2020-07-14T11:41:41', '', '2020-07-14T11:41:41', @SNIndex+5, '429e0588-aa6b-429f-bfe7-76c88fb061e6', @SNIndex+4, '18c20d02-9d67-4778-8ee8-52b802e977ca', 'Misc', 1, '', 50, 5, 0, 0, '', '', 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, '403d0148-8860-41d7-b431-ef96e522226f', 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', 4,0)
INSERT INTO UBF_MD_Class (ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_ParentClass_ID, MD_Component_ID, Local_Component_ID, ClassType, FullName, IsDefault, IsService, TransactionType, ReturnTypeID, IsAuthority, Discriminator) VALUES ('8c524551-ce42-4c64-9714-323b35a77a32', 'CreateLogisticsConstsOperation', 'Administrator', '2020-07-14T11:41:41', 'Administrator', '2020-07-14T15:49:53', @SNIndex+6, '00000000-0000-0000-0000-000000000000', 'd5a826c6-8101-48ab-97d3-1ff714356d02', @SNIndex+0, 7, 'UFIDA.U9.Cust.BLT.ShipPlan.ComputeBP.CreateLogisticsConstsOperation', 0, 0, 2, '5efeea06-cae7-4cc0-82e9-20a789e4e582', 1, 'UFIDA.UBF.MD.Business.Operation')
INSERT INTO UBF_MD_Attribute(ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_Class_ID, Local_Class_ID, DataTypeID, GroupName, IsCollection, DefaultValue, Length, Precision, Sequence, Scale, MaxValue, MinValue, IsKey, IsNullable, IsReadOnly, Visibility, IsCalculation, IsGlobalization, IsSystem, IsBusinessKey, IsQueryAttribute, IsForAsso, GroupID, IsModifyControl, IsDynamic, IsImpressible, IsInCache, IsKeySerializable, IsColumnDefine, IsFilterDefine, IsSortDefine, IsDefaultColumn, IsEntityData, DefaultColumnName, DataTypeFlag,ForOBAImport) VALUES('11ea9ab0-e98e-4735-8846-d3edfa6c6083', 'Data', 'Administrator', '2020-07-14T11:41:41', '', '2020-07-14T11:41:41', @SNIndex+7, '8c524551-ce42-4c64-9714-323b35a77a32', @SNIndex+6, '9b412470-c8e9-407b-99b2-2b4c2508d4d1', 'Misc', 0, '', 50, 5, 0, 0, '', '', 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, '8144b318-7d43-425c-a17e-ffc0d763a14e', 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', 1,0)
INSERT INTO UBF_MD_Attribute(ID, Name, CreateOp, CreateTime, ModifyOp, ModifyTime, Local_ID, MD_Class_ID, Local_Class_ID, DataTypeID, GroupName, IsCollection, DefaultValue, Length, Precision, Sequence, Scale, MaxValue, MinValue, IsKey, IsNullable, IsReadOnly, Visibility, IsCalculation, IsGlobalization, IsSystem, IsBusinessKey, IsQueryAttribute, IsForAsso, GroupID, IsModifyControl, IsDynamic, IsImpressible, IsInCache, IsKeySerializable, IsColumnDefine, IsFilterDefine, IsSortDefine, IsDefaultColumn, IsEntityData, DefaultColumnName, DataTypeFlag,ForOBAImport) VALUES('a17b3758-abd3-473e-b30e-329fbbc2bb33', 'DataLine', 'Administrator', '2020-07-14T11:41:41', '', '2020-07-14T11:41:41', @SNIndex+8, '8c524551-ce42-4c64-9714-323b35a77a32', @SNIndex+6, '7c236994-42fa-4f5f-97de-edfea1c7966b', 'Misc', 1, '', 50, 5, 1, 0, '', '', 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, '8144b318-7d43-425c-a17e-ffc0d763a14e', 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', 4,0)

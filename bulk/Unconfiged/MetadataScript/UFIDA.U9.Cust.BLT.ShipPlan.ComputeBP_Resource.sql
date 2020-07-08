DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = 'd5a826c6-8101-48ab-97d3-1ff714356d02' AND LanguageName = 'zh-CN'
DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = '85a2d1e7-52e2-459e-a3eb-cbcd26e3baa7' AND LanguageName = 'zh-CN'
DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = '429e0588-aa6b-429f-bfe7-76c88fb061e6' AND LanguageName = 'zh-CN'
DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = '0e3dcd32-139c-4b04-b626-8341c1f06923' AND LanguageName = 'zh-CN'
DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = '02d7f7ee-b13a-495c-9961-16c9f3577bb0' AND LanguageName = 'zh-CN'
DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = '69a5bfb7-7f51-4d18-86f0-a5815fdfc759' AND LanguageName = 'zh-CN'
DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = 'd7ce0580-9275-4b63-a529-db6f5c7ab24b' AND LanguageName = 'zh-CN'
DELETE FROM UBF_RES_ResourceValue WHERE ResourceName = '7c821e2f-7274-45ce-ada9-95eb6bff0922' AND LanguageName = 'zh-CN'
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', 'd5a826c6-8101-48ab-97d3-1ff714356d02', 'T', '', 'FreightCalculationBP', 'BPComponent', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, '7d1bad8a-e749-4b2e-830c-7090cdb53fc5', null)
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', '85a2d1e7-52e2-459e-a3eb-cbcd26e3baa7', 'T', '', '运费计算操作', 'BPOperation', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, '0f8fa6ca-adf1-49d7-89dc-37dadfba98b6', null)
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', '429e0588-aa6b-429f-bfe7-76c88fb061e6', 'T', '', '费用分摊操作', 'BPOperation', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, '7fe3b12e-7480-4afb-956f-92c4dd9f9ae6', null)
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', '0e3dcd32-139c-4b04-b626-8341c1f06923', 'T', '', '费用头', 'BPOperationAttribute', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, 'a3bae001-66f5-4fff-b751-b03fbc7d38a6', null)
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', '02d7f7ee-b13a-495c-9961-16c9f3577bb0', 'T', '', '费用行', 'BPOperationAttribute', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, '30d0aff9-7c6a-4ae9-8259-d0f781171ac6', null)
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', '69a5bfb7-7f51-4d18-86f0-a5815fdfc759', 'T', '', '费用集合', 'BPOperationAttribute', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, '35e657d7-3331-4929-8000-e9f91fae9aa9', null)
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', 'd7ce0580-9275-4b63-a529-db6f5c7ab24b', 'T', '', '实现', 'BPOperationImplementsOperation', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, '758d96b3-be23-464b-be4d-849b7909a8a4', null)
INSERT INTO UBF_RES_ResourceValue(LanguageName, ResourceName, Status, Description, DisplayName, Type, Help, ComponentID, ParentHelpResourceName, ResourceID, ParentResourceName) VALUES('zh-CN', '7c821e2f-7274-45ce-ada9-95eb6bff0922', 'T', '', '实现', 'BPOperationImplementsOperation', null, 'd5a826c6-8101-48ab-97d3-1ff714356d02', null, 'f39c9d81-bd95-4d77-94ce-034afcc0befa', null)

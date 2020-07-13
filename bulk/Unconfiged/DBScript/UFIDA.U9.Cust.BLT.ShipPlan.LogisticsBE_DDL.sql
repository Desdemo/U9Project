set QUOTED_IDENTIFIER on
set ANSI_PADDING on

/*=================================================*/
/*       Drop database element                     */
/*=================================================*/

/*=============FK================*/

if object_id(N'fk_Cust_ShipPlan_PriceListLine_DynamicPrice_reference_Cust_ShipPlan_PriceType_ID', N'F') is not null
    alter table [Cust_ShipPlan_PriceListLine]
        drop constraint fk_Cust_ShipPlan_PriceListLine_DynamicPrice_reference_Cust_ShipPlan_PriceType_ID
go

if object_id(N'fk_Cust_ShipPlan_ComplexList_Supp_reference_CBO_Supplier_ID', N'F') is not null
    alter table [Cust_ShipPlan_ComplexList]
        drop constraint fk_Cust_ShipPlan_ComplexList_Supp_reference_CBO_Supplier_ID
go

if object_id(N'fk_Cust_ShipPlan_ComplexList_Address_reference_Base_Location_ID', N'F') is not null
    alter table [Cust_ShipPlan_ComplexList]
        drop constraint fk_Cust_ShipPlan_ComplexList_Address_reference_Base_Location_ID
go

if object_id(N'fk_Cust_ShipPlan_ComplexList_StartAddress_reference_Base_Location_ID', N'F') is not null
    alter table [Cust_ShipPlan_ComplexList]
        drop constraint fk_Cust_ShipPlan_ComplexList_StartAddress_reference_Base_Location_ID
go

if object_id(N'fk_Cust_ShipPlan_ComplexListLine_BulkUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_ShipPlan_ComplexListLine]
        drop constraint fk_Cust_ShipPlan_ComplexListLine_BulkUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_ShipPlan_ComplexListLine_WeightUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_ShipPlan_ComplexListLine]
        drop constraint fk_Cust_ShipPlan_ComplexListLine_WeightUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_ShipPlan_ComplexListLine_ComputeUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_ShipPlan_ComplexListLine]
        drop constraint fk_Cust_ShipPlan_ComplexListLine_ComputeUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_ShipPlan_LogisticsCosts_Supplier_reference_CBO_Supplier_ID', N'F') is not null
    alter table [Cust_ShipPlan_LogisticsCosts]
        drop constraint fk_Cust_ShipPlan_LogisticsCosts_Supplier_reference_CBO_Supplier_ID
go

if object_id(N'fk_Cust_ShipPlan_LogisticsCosts_Location_reference_Base_Location_ID', N'F') is not null
    alter table [Cust_ShipPlan_LogisticsCosts]
        drop constraint fk_Cust_ShipPlan_LogisticsCosts_Location_reference_Base_Location_ID
go

if object_id(N'fk_Cust_ShipPlan_LogisticsCosts_BulkUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_ShipPlan_LogisticsCosts]
        drop constraint fk_Cust_ShipPlan_LogisticsCosts_BulkUom_reference_Base_UOM_ID
go

if object_id(N'fk_Cust_ShipPlan_LogisticsCosts_WeightUom_reference_Base_UOM_ID', N'F') is not null
    alter table [Cust_ShipPlan_LogisticsCosts]
        drop constraint fk_Cust_ShipPlan_LogisticsCosts_WeightUom_reference_Base_UOM_ID
go

/*=============Table================*/

if object_id(N'[Cust_ShipPlan_PriceType]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_PriceType]',@IsChildTable=0
    drop table [Cust_ShipPlan_PriceType]
end
go

if object_id(N'[Cust_ShipPlan_PriceTypeLine]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_PriceTypeLine]',@IsChildTable=0
    drop table [Cust_ShipPlan_PriceTypeLine]
end
go

if object_id(N'[Cust_ShipPlan_PriceList]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_PriceList]',@IsChildTable=0
    drop table [Cust_ShipPlan_PriceList]
end
go

if object_id(N'[Cust_ShipPlan_PriceListLine]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_PriceListLine]',@IsChildTable=0
    drop table [Cust_ShipPlan_PriceListLine]
end
go

if object_id(N'[Cust_ShipPlan_ComplexList]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_ComplexList]',@IsChildTable=0
    drop table [Cust_ShipPlan_ComplexList]
end
go

if object_id(N'[Cust_ShipPlan_ComplexListLine]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_ComplexListLine]',@IsChildTable=0
    drop table [Cust_ShipPlan_ComplexListLine]
end
go

if object_id(N'[Cust_ShipPlan_LogisticsCosts]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_LogisticsCosts]',@IsChildTable=0
    drop table [Cust_ShipPlan_LogisticsCosts]
end
go

/*=================================================*/
/*       Create database element                   */
/*=================================================*/

/*=============Table================*/

create table [Cust_ShipPlan_PriceType]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [PriceTypeEnum] int not null,
    [Coding] nvarchar(50) not null,
    [Name] nvarchar(50) not null,
    [Remark] nvarchar(50) null,
    [Currency] bigint not null,
    [Uom] bigint not null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_PriceType'
go

create table [Cust_ShipPlan_PriceTypeLine]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [SerialNumber] int not null,
    [UnitPrice] float(53) not null,
    [Start] int not null,
    [Cutoff] int not null,
    [Remark] nvarchar(50) null,
    [LineTotal] int not null,
    [PriceType] bigint null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_PriceTypeLine'
go

create table [Cust_ShipPlan_PriceList]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [DocNo] nvarchar(50) not null,
    [Name] nvarchar(50) not null,
    [Supplier] bigint not null,
    [Currency] bigint not null,
    [CountBasis] int null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_PriceList'
go

create table [Cust_ShipPlan_PriceListLine]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [No] int not null,
    [Departure] bigint not null,
    [Destination] bigint not null,
    [SalesUnit] bigint not null,
    [Price] float(53) null,
    [DynamicPrice] bigint null,
    [DeliveryPickup] float(53) null,
    [DeliveryCharges] float(53) null,
    [FreePickup] int null,
    [FreeDelivery] int null,
    [TransportationTime] int null,
    [Remark] nvarchar(50) null,
    [PriceList] bigint null,
    [CountBasis] int null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_PriceListLine'
go

create table [Cust_ShipPlan_ComplexList]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [Supp] bigint null,
    [Address] bigint null,
    [ShipDate] datetime null,
    [ComputeBasis] int null,
    [TwoAddress] bit null,
    [Total] float(53) null,
    [TotalAmount] float(53) null,
    [RealTotal] float(53) null,
    [RealTotalAmount] float(53) null,
    [StartAddress] bigint null,
    [TotalBulk] float(53) null,
    [TotalWeight] float(53) null,
    [RealBulk] float(53) null,
    [RealWeight] float(53) null,
    [PickupAmount] float(53) null,
    [ChargesAmount] float(53) null,
    [OtherAmount] float(53) null,
    [Remark] nvarchar(50) null,
    [Discharge] float(53) null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_ComplexList'
go

create table [Cust_ShipPlan_ComplexListLine]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [SrcDocType] int not null,
    [DocNo] nvarchar(50) not null,
    [DocNoID] bigint not null,
    [DocLineID] bigint not null,
    [Address] bigint not null,
    [Item] bigint not null,
    [Qty] int not null,
    [PriceUom] bigint not null,
    [ComputeBasisEnum] int not null,
    [ComplexList] bigint null,
    [BulkUom] bigint null,
    [Bulks] float(53) null,
    [WeightUom] bigint null,
    [Weights] float(53) null,
    [LineTotal] float(53) null,
    [ComputeUom] bigint null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_ComplexListLine'
go

create table [Cust_ShipPlan_LogisticsCosts]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [DocType] int null,
    [Salesman] nvarchar(50) null,
    [CustomerContact] nvarchar(50) null,
    [Phone] nvarchar(50) null,
    [ShipDate] datetime null,
    [SaleNo] nvarchar(50) null,
    [Supplier] bigint null,
    [Qty] int null,
    [ProductCategory] int null,
    [Province] nvarchar(50) null,
    [Location] bigint null,
    [IBulk] float(53) null,
    [Weight] float(53) null,
    [BulkUom] bigint null,
    [WeightUom] bigint null,
    [PickupFee] float(53) null,
    [DeliveryFee] float(53) null,
    [DischargeFee] float(53) null,
    [OtherFee] float(53) null,
    [StandardShipping] float(53) null,
    [TotalFreight] float(53) null,
    [RealFreight] float(53) null,
    [AverageCost] float(53) null,
    [Remark] nvarchar(50) null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_LogisticsCosts'
go

/*=============PK================*/

alter table [Cust_ShipPlan_PriceType]
    add constraint pk_Cust_ShipPlan_PriceType
    primary key clustered
    ([ID] asc)
go

alter table [Cust_ShipPlan_PriceTypeLine]
    add constraint pk_Cust_ShipPlan_PriceTypeLine
    primary key clustered
    ([ID] asc)
go

alter table [Cust_ShipPlan_PriceList]
    add constraint pk_Cust_ShipPlan_PriceList
    primary key clustered
    ([ID] asc)
go

alter table [Cust_ShipPlan_PriceListLine]
    add constraint pk_Cust_ShipPlan_PriceListLine
    primary key clustered
    ([ID] asc)
go

alter table [Cust_ShipPlan_ComplexList]
    add constraint pk_Cust_ShipPlan_ComplexList
    primary key clustered
    ([ID] asc)
go

alter table [Cust_ShipPlan_ComplexListLine]
    add constraint pk_Cust_ShipPlan_ComplexListLine
    primary key clustered
    ([ID] asc)
go

alter table [Cust_ShipPlan_LogisticsCosts]
    add constraint pk_Cust_ShipPlan_LogisticsCosts
    primary key clustered
    ([ID] asc)
go

/*=============Index================*/

create unique nonclustered index UFIDA_U9_Cust_BLT_ShipPlan_LogisticsBE_PriceList_BusinessKey_Index
    on [Cust_ShipPlan_PriceList]([Supplier]  ASC, [Currency]  ASC)
go

create unique nonclustered index UFIDA_U9_Cust_BLT_ShipPlan_LogisticsBE_PriceListLine_BusinessKey_Index
    on [Cust_ShipPlan_PriceListLine]([Departure]  ASC, [Destination]  ASC, [SalesUnit]  ASC)
go

/*=============FK================*/

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint fk_Cust_ShipPlan_PriceListLine_DynamicPrice_reference_Cust_ShipPlan_PriceType_ID
    foreign key ([DynamicPrice])
    references [Cust_ShipPlan_PriceType]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint fk_Cust_ShipPlan_ComplexList_Supp_reference_CBO_Supplier_ID
    foreign key ([Supp])
    references [CBO_Supplier]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint fk_Cust_ShipPlan_ComplexList_Address_reference_Base_Location_ID
    foreign key ([Address])
    references [Base_Location]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint fk_Cust_ShipPlan_ComplexList_StartAddress_reference_Base_Location_ID
    foreign key ([StartAddress])
    references [Base_Location]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint fk_Cust_ShipPlan_ComplexListLine_BulkUom_reference_Base_UOM_ID
    foreign key ([BulkUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint fk_Cust_ShipPlan_ComplexListLine_WeightUom_reference_Base_UOM_ID
    foreign key ([WeightUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint fk_Cust_ShipPlan_ComplexListLine_ComputeUom_reference_Base_UOM_ID
    foreign key ([ComputeUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint fk_Cust_ShipPlan_LogisticsCosts_Supplier_reference_CBO_Supplier_ID
    foreign key ([Supplier])
    references [CBO_Supplier]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint fk_Cust_ShipPlan_LogisticsCosts_Location_reference_Base_Location_ID
    foreign key ([Location])
    references [Base_Location]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint fk_Cust_ShipPlan_LogisticsCosts_BulkUom_reference_Base_UOM_ID
    foreign key ([BulkUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint fk_Cust_ShipPlan_LogisticsCosts_WeightUom_reference_Base_UOM_ID
    foreign key ([WeightUom])
    references [Base_UOM]([ID])
    on delete no action
    on update no action
go

/*=============Default================*/

alter table [Cust_ShipPlan_PriceType]
    with check
    add constraint [11847492-36d0-40a8-ba99-881b0034a9b4_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceType]
    with check
    add constraint [c64bbf12-55c3-47da-955c-cc7bd61a11bf_Default]
    default 0 for [PriceTypeEnum]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [b48e768c-91a7-472d-bbe6-8b846f25bf57_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [baf8d79e-d99c-43b8-8187-c1f805a3bd69_Default]
    default 0 for [SerialNumber]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [47e2b38d-9564-4353-9ca7-24c644c6ed2f_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [ee1e0a6d-7ece-41a4-b618-28d56d9678d1_Default]
    default 0 for [Start]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [e96d9ffd-49e3-45dd-bbed-49ec975538bf_Default]
    default 0 for [Cutoff]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [6008db8c-3e91-449a-b319-1680a91e8d56_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [141f8bd1-6c3c-4fb1-8b9e-e561622a54a1_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [24d5929c-7727-456c-80a5-9655bf2789e4_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [697d5309-4ac7-4cd2-bd33-def2997ce8b1_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [52b727a4-c2f9-4cdd-92ea-8afa31b239ad_Default]
    default 0 for [No]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [d7606d49-f7d9-4725-8c34-a1c8e53dab5b_Default]
    default 0 for [Price]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [9749335d-a904-4613-a084-ca48d7c32af4_Default]
    default 0 for [DeliveryPickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [02eb112c-5cb2-475f-9f25-3eddfea9f7cc_Default]
    default 0 for [DeliveryCharges]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [8670b25b-03dd-4e60-80d0-7056df50f100_Default]
    default 0 for [FreePickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [5183b582-2312-44c1-aa63-f09cc5d418ff_Default]
    default 0 for [FreeDelivery]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [9a1b82c3-fae3-454e-8e28-19fc2a4538b0_Default]
    default 0 for [TransportationTime]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [03188245-052e-48e6-8eed-d140acb5d228_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [57cd6d3b-ca7f-4c1c-90e8-e9f55aad0dce_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ee10f1d0-5c2f-4e54-ade0-e1b3afd491f9_Default]
    default 0 for [ComputeBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [40ca0b93-0b72-4a98-a7cc-bdd6aa704e36_Default]
    default 0 for [TwoAddress]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [1a5334c2-b642-4061-95d4-cc0ee4d30fa7_Default]
    default 0 for [Total]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [2f678d51-5d43-4594-8d17-2838a4d44030_Default]
    default 0 for [TotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [44574386-036e-4f85-ac52-102bb45a1013_Default]
    default 0 for [RealTotal]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [d43a66e3-4c37-481a-936b-59a1e0493b02_Default]
    default 0 for [RealTotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [1a8c875f-64a9-4630-aca4-3085e06a20da_Default]
    default 0 for [TotalBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [5983cc2a-386d-47cd-a315-2dc6675f83d6_Default]
    default 0 for [TotalWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [0b1d1180-d7e9-4e60-a286-4fbdc837cf77_Default]
    default 0 for [RealBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [92d9e063-d9ac-49df-9668-0b6d497bef72_Default]
    default 0 for [RealWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ca7ba74f-7e2f-4cc4-a8b2-eca6ad118e76_Default]
    default 0 for [PickupAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [15e8c013-130b-4d04-b9ca-77bef97c465a_Default]
    default 0 for [ChargesAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [3518db25-2d32-487b-98b8-14a34c1b53bd_Default]
    default 0 for [OtherAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [173cecdd-b16d-48d5-8f33-4dbc20f65492_Default]
    default 0 for [Discharge]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [af6bb438-32e0-4440-926f-04d9ba0f71a1_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [99d2809c-823d-43aa-9bf1-ba8d1926562e_Default]
    default 0 for [SrcDocType]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [60051c4f-0f71-4450-8ee4-85b8671598d4_Default]
    default 0 for [DocNoID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [6d0271c9-c0aa-4c3e-9501-50f5e17c5ef2_Default]
    default 0 for [DocLineID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [ebd4c276-d32b-4c8c-a690-64f7de098b90_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [a1e9f08c-32f8-4c12-8961-fbb7ffe272cb_Default]
    default 0 for [ComputeBasisEnum]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [9430eb3e-1e10-4c2e-a784-226a2eefc7ef_Default]
    default 0 for [Bulks]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [43bc04b1-29d8-4cce-88a2-a1132562c602_Default]
    default 0 for [Weights]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [957bb195-7d57-464c-9ffe-e79b6998b734_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [bd9d8231-cc1b-4fd9-bc18-ed6ae4728520_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [ac3063c9-58ae-43b4-92d1-fccedc02c7fa_Default]
    default 0 for [DocType]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [a1727f80-6b7b-4405-9330-10d860dfcfb1_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [23fa0b63-bc29-4a3b-91e1-c0715d349c87_Default]
    default 0 for [ProductCategory]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [6d254fa3-9063-41d5-a18e-a9c88496c554_Default]
    default 0 for [IBulk]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [93c8a93f-d002-4385-b868-845d842ea4dd_Default]
    default 0 for [Weight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [da263cde-4427-46ae-b481-532fd2e33afc_Default]
    default 0 for [PickupFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [1986e4cd-22c8-4c77-9c90-705c1e93ffd2_Default]
    default 0 for [DeliveryFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [a767ae88-6c4d-4be4-99c4-15269b7af650_Default]
    default 0 for [DischargeFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [50b39a85-3ce1-4e42-aa7e-1c5ead5bfa27_Default]
    default 0 for [OtherFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [0fb63c3b-5a22-4ee3-893c-dbc4b7a79536_Default]
    default 0 for [StandardShipping]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [a6293109-96d6-4888-8702-efffb2571ed7_Default]
    default 0 for [TotalFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [6874ecf7-62fc-4d5a-9521-30c4e5d3826d_Default]
    default 0 for [RealFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [e46685ec-1eaf-4df0-a63c-e2157f64984d_Default]
    default 0 for [AverageCost]
go

/*=============TableAllCheck================*/

ALTER TABLE [Cust_ShipPlan_PriceType] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceTypeLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceListLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexListLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_LogisticsCosts] WITH CHECK NOCHECK CONSTRAINT ALL 


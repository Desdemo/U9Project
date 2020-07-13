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
    add constraint [18c7bd7f-553f-4b9f-bb28-aa9a48a47605_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceType]
    with check
    add constraint [be888092-6095-4d71-bedd-5808e58ad7f1_Default]
    default 0 for [PriceTypeEnum]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [29e3f3e2-f87f-434d-b45b-3c28c2a42f33_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [8b569af7-2973-481c-acaf-c2e5534ee2fb_Default]
    default 0 for [SerialNumber]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [068908c9-08f4-4b74-9976-a776389d1b13_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [31f52b87-4982-4b7f-a5d2-450b5023a7ff_Default]
    default 0 for [Start]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [1f532bc6-c76b-4bd3-b753-1bebe0a1a6a7_Default]
    default 0 for [Cutoff]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [10649e8e-2c01-48a9-9f9d-1330fb41aa90_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [a983b45b-fcd6-4ab4-9622-8f3af658c443_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [21097266-394c-4d26-bd52-ece7d7971a4b_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [4f1ac0cd-b219-44e7-8b91-2a693b771ba3_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [75d35dc7-58e5-4993-a63c-dd62e2c444a6_Default]
    default 0 for [No]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [641bc5d7-8bab-4e3f-9a7c-97e6c57efb28_Default]
    default 0 for [Price]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [6fc0298d-52c8-4463-b8cf-039d956a1bb7_Default]
    default 0 for [DeliveryPickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [145ab9dd-6f8f-43e9-b69f-0491107d8b16_Default]
    default 0 for [DeliveryCharges]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [c39a5b49-30bb-43d6-bada-c009d2aab4a0_Default]
    default 0 for [FreePickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [71f54394-53a9-4911-b9bb-c5bce20e9ffa_Default]
    default 0 for [FreeDelivery]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [72f10dcc-df1d-4121-a319-afedb7f88a0f_Default]
    default 0 for [TransportationTime]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [32ae0b83-7862-429c-9053-6ffd0475adee_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [22c64aa0-22c8-456f-b644-03b8efe99ffe_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [13cca166-407d-4f11-9aab-43f37920796a_Default]
    default 0 for [ComputeBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [f27522a6-a944-48f7-b2a9-f0e709581c0b_Default]
    default 0 for [TwoAddress]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [a77d60fd-c3a9-424d-be20-fa7c3830ac2a_Default]
    default 0 for [Total]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [05a68985-885a-431e-98d8-c0060cfdb616_Default]
    default 0 for [TotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [fb7cfa5c-d7e4-46ec-98e3-7754f0a7c5cb_Default]
    default 0 for [RealTotal]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [d61da1ed-ce81-4ac6-a64c-04460a3c4b0e_Default]
    default 0 for [RealTotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ba6a5204-485f-4b11-81a7-68248ad2b246_Default]
    default 0 for [TotalBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [2f0323ba-9d81-40d5-bbf1-2ef6869cdbcd_Default]
    default 0 for [TotalWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [97e9857e-1ebd-473f-a2d9-ae2ee9e398f3_Default]
    default 0 for [RealBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [f9dfa2ad-0935-4412-93f0-ece87e8369ba_Default]
    default 0 for [RealWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [a0ad7be3-d369-4dc2-a16a-6822e8ce15cf_Default]
    default 0 for [PickupAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [483eabf8-ba5c-4661-b373-4b53e99ccac9_Default]
    default 0 for [ChargesAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [22fab7fe-f61a-487b-b646-ad25c37b95f9_Default]
    default 0 for [OtherAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [1e1f7149-d8fb-4585-ac8d-6e6699456de0_Default]
    default 0 for [Discharge]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [9a5d0384-05e1-4b03-a5dc-d3bf5c29612e_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [bd6bd285-112b-4658-8f58-9804f6ab7cff_Default]
    default 0 for [SrcDocType]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [cbd37111-56b5-4809-9f15-882e12c20876_Default]
    default 0 for [DocNoID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [6c0982bc-931d-45bf-848a-ac23b9181d4c_Default]
    default 0 for [DocLineID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [bb7126d7-0a61-4f57-927a-a14e0c37ed0e_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [776cb6d5-b835-4ca1-b098-bde29b1e9ccf_Default]
    default 0 for [ComputeBasisEnum]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [01be7690-4b3c-4849-86a1-c20d0fb62fa5_Default]
    default 0 for [Bulks]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [50929c18-15cc-4d14-b28c-89f7991c2fa4_Default]
    default 0 for [Weights]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [12391416-c629-4615-9067-520971bd05c8_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [35eab614-2f66-4286-8cb8-2699ae36886b_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [2d5cf197-20db-4645-b046-f3525499716e_Default]
    default 0 for [DocType]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [db00e264-a726-4bd3-8693-bafe61632870_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [41533ec1-cd64-4e17-aa32-e01d93742b47_Default]
    default 0 for [ProductCategory]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [53c371de-7bfd-439b-9385-7e1d19786e75_Default]
    default 0 for [IBulk]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [314862ea-957c-460f-9763-03e76e4dd210_Default]
    default 0 for [Weight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [4895fe03-40bf-49a3-ac25-8d5a6ed55234_Default]
    default 0 for [PickupFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [e438fc66-0c4a-4ad8-870f-e86e760cdd83_Default]
    default 0 for [DeliveryFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [009b1f8a-2055-4d53-94d9-d7e0ac124ded_Default]
    default 0 for [DischargeFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [01af0cce-69ad-462a-ab64-82e44648e617_Default]
    default 0 for [OtherFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [3dd916b5-04fe-44dd-9e51-3c6db7d4df24_Default]
    default 0 for [StandardShipping]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [e77b2746-715b-4c86-8886-01d3794c5273_Default]
    default 0 for [TotalFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [3771dfaf-c96f-4ded-9508-cf0ff5655fdd_Default]
    default 0 for [RealFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [1cbc6081-afcf-4dfd-9d70-c5449de12568_Default]
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


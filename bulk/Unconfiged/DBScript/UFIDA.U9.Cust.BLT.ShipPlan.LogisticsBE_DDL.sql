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

if object_id(N'fk_Cust_ShipPlan_ComplexList_DeliveryAddress_reference_Base_Location_ID', N'F') is not null
    alter table [Cust_ShipPlan_ComplexList]
        drop constraint fk_Cust_ShipPlan_ComplexList_DeliveryAddress_reference_Base_Location_ID
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

if object_id(N'[Cust_ShipPlan_FreightLink]', N'u') is not null
begin
    exec p_DropForeignKey @TableName='[Cust_ShipPlan_FreightLink]',@IsChildTable=0
    drop table [Cust_ShipPlan_FreightLink]
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
    [StartAddress] int null,
    [TotalBulk] float(53) null,
    [TotalWeight] float(53) null,
    [RealBulk] float(53) null,
    [RealWeight] float(53) null,
    [PickupAmount] float(53) null,
    [ChargesAmount] float(53) null,
    [OtherAmount] float(53) null,
    [Remark] nvarchar(50) null,
    [Discharge] float(53) null,
    [UnitPrice] float(53) null,
    [DeliveryAddress] bigint null,
    [NumberOfTrucks] smallint null
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
    [ComputeUom] bigint null,
    [DeliveryFactory] int null
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
    [Remark] nvarchar(50) null,
    [UintPrice] float(53) null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_LogisticsCosts'
go

create table [Cust_ShipPlan_FreightLink]
(
    [ID] bigint not null,
    [CreatedOn] datetime null,
    [CreatedBy] nvarchar(50) null,
    [ModifiedOn] datetime null,
    [ModifiedBy] nvarchar(50) null,
    [SysVersion] bigint null,
    [SrcDoctype] int null,
    [DocID] bigint null,
    [Amount] float(53) null
)
go
exec p_CreateCustomType 'Cust_ShipPlan_FreightLink'
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

alter table [Cust_ShipPlan_FreightLink]
    add constraint pk_Cust_ShipPlan_FreightLink
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

create unique nonclustered index UFIDA_U9_Cust_BLT_ShipPlan_LogisticsBE_BizEntity_BusinessKey_Index
    on [Cust_ShipPlan_FreightLink]([DocID]  ASC, [SrcDoctype]  ASC)
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
    add constraint fk_Cust_ShipPlan_ComplexList_DeliveryAddress_reference_Base_Location_ID
    foreign key ([DeliveryAddress])
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
    add constraint [75c1ef79-188e-451f-9256-cfa282910d03_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceType]
    with check
    add constraint [1d7b1903-2eb4-4879-817f-60618a325566_Default]
    default 0 for [PriceTypeEnum]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [8367fff2-d8de-40b2-85f0-7a210a897b03_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [a669ab33-b5ec-4a27-aa9d-09f201065be9_Default]
    default 0 for [SerialNumber]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [88878afb-5f6f-4271-b95d-0ecb3c11df6b_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [e6beb584-ff94-4e3b-ac08-b66469b0e7d8_Default]
    default 0 for [Start]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [faebb076-769c-4829-a0cd-c141b554ffce_Default]
    default 0 for [Cutoff]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [591160b6-bd8d-4a72-83a1-58e112e7a3d1_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [48db396d-9f4f-4c92-a4e2-4fbb4208a383_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [10f4fa81-a315-44d6-8577-c40d4a5fb74f_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [6545d9d7-1912-4738-b836-896fad636efb_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [9af85d30-898c-40f6-a323-a028c3148f96_Default]
    default 0 for [No]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [66b14a3d-0f15-4fcc-baf5-9f2fe5064e18_Default]
    default 0 for [Price]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [faa6eaa9-c46f-4826-ae88-ac946942c54b_Default]
    default 0 for [DeliveryPickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [ebe87d23-8787-47b0-ab9e-51889cd35240_Default]
    default 0 for [DeliveryCharges]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [195f46bb-efca-4930-ac55-c39e888bcebf_Default]
    default 0 for [FreePickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [aedd0852-bfd3-42ec-ab28-c6da4bf5da1d_Default]
    default 0 for [FreeDelivery]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [cede4aff-e9b9-4dd4-ab05-18f5147a64c6_Default]
    default 0 for [TransportationTime]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [ba976d88-5f38-4251-8cf1-4b0efb84c22c_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ac1a9c3a-c195-42fe-b032-d5210cc9ee89_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [042b3579-0868-4595-9294-88773e74ac7b_Default]
    default 0 for [ComputeBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [80ccd3eb-060b-401b-b9c2-b27f4d2f0967_Default]
    default 0 for [TwoAddress]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [2b115a9e-9465-4f96-a9f0-9856f9b572be_Default]
    default 0 for [Total]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [149893f3-6317-4d6f-9e4a-9eba1181a9bc_Default]
    default 0 for [TotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [a833c730-f9e2-4bed-af3c-ceb72b8c77a8_Default]
    default 0 for [RealTotal]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [630c7d8e-1df1-4480-9a09-0ff65a2565fc_Default]
    default 0 for [RealTotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ba17191e-e3fd-4f76-869b-11c38e41db9e_Default]
    default 0 for [StartAddress]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [422ce2b6-4235-4416-b3b1-ebc8a63c11a8_Default]
    default 0 for [TotalBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [b5350c8c-3178-41ba-90ca-4a0f3376c7f9_Default]
    default 0 for [TotalWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [e60cb16e-82c9-4ad2-82e4-441b04b032aa_Default]
    default 0 for [RealBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [7bff87e9-1bb6-492a-8235-95ccfafd2153_Default]
    default 0 for [RealWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ec99b948-8fd5-489b-ab09-d41ef7ff0669_Default]
    default 0 for [PickupAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [dc500a21-ada3-4999-a1d4-67eddd536f74_Default]
    default 0 for [ChargesAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [34a8e9fb-0817-4141-b6a8-f3d5721a62dd_Default]
    default 0 for [OtherAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [5ef38502-0946-496a-b0ed-55307f73fe65_Default]
    default 0 for [Discharge]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [baa3e9f1-fc17-4d31-b16f-c2b1124b1c29_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [17748eb7-412d-4307-a149-d6d091b5f671_Default]
    default 1 for [NumberOfTrucks]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [3599a334-ca3e-4ab6-b8dc-ddcbdd5b56c8_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [aefe0ea6-cb94-47c2-be6f-6cb47e21b90a_Default]
    default 0 for [SrcDocType]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [7b1830ba-b4f6-4fa0-aa24-28d3a032f95f_Default]
    default 0 for [DocNoID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [4206795e-92d8-40a0-bea3-871809d7ab2d_Default]
    default 0 for [DocLineID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [e918b1ee-fd1d-4ba7-a587-0b95a8d36298_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [a7aee79d-f945-4aa4-8ef2-0fb7bd7ee486_Default]
    default 0 for [ComputeBasisEnum]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [1dff701d-ec56-4647-b6bc-e63f46c9f97c_Default]
    default 0 for [Bulks]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [bea73555-203c-4cfd-a5cf-2f3e612f4023_Default]
    default 0 for [Weights]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [a3309f3f-7f9e-4161-989f-359d46088ccc_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [111b2ecd-65c3-469b-8606-0bcbbe489e77_Default]
    default 0 for [DeliveryFactory]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [ff05477f-1937-43e9-8964-f99761992f93_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [faca5162-0f34-4c6e-96b6-800abef948bc_Default]
    default 0 for [DocType]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [964d157c-84d2-4796-86be-ea482915acdb_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [225ea6af-683a-4ef9-a622-7bef46ef063d_Default]
    default 0 for [ProductCategory]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [8121cf0a-0fef-4f68-b817-157446d19a27_Default]
    default 0 for [IBulk]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [f94e1b7c-69a7-4542-9ca6-4402b16fdbb1_Default]
    default 0 for [Weight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [1ff8bf15-a929-4e6b-802c-f12ea871c6c2_Default]
    default 0 for [PickupFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [6e25ab6c-efcc-47d7-b889-557df08258e2_Default]
    default 0 for [DeliveryFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [78faae37-d39a-4b83-8e75-dbb9f4e0ca87_Default]
    default 0 for [DischargeFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [c6263161-d8a4-445b-996a-49c892b51ae6_Default]
    default 0 for [OtherFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [06cf5163-772c-43b2-bbc4-790b6ad1e2b4_Default]
    default 0 for [StandardShipping]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [5b846c1a-36d0-48f5-9b02-34f391b6069f_Default]
    default 0 for [TotalFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [5314c73c-6689-4cc3-a724-f7ac07f03162_Default]
    default 0 for [RealFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [6a779ef1-3b69-4a83-af6e-3db800a734f8_Default]
    default 0 for [AverageCost]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [ef5865ef-7188-471b-9fe8-2dc28ca2b666_Default]
    default 0 for [UintPrice]
go

alter table [Cust_ShipPlan_FreightLink]
    with check
    add constraint [74896ed0-28dd-4d49-a6e8-aa3423bfd25f_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_FreightLink]
    with check
    add constraint [64b37f66-d0f2-4cfe-b503-6f0803dd0353_Default]
    default 0 for [SrcDoctype]
go

alter table [Cust_ShipPlan_FreightLink]
    with check
    add constraint [79e632a5-b043-4a6a-8e99-efec32b4aee4_Default]
    default 0 for [DocID]
go

alter table [Cust_ShipPlan_FreightLink]
    with check
    add constraint [1752f38a-d365-472f-8ce1-f97f6b4b0c89_Default]
    default 0 for [Amount]
go

/*=============TableAllCheck================*/

ALTER TABLE [Cust_ShipPlan_PriceType] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceTypeLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceListLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexListLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_LogisticsCosts] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_FreightLink] WITH CHECK NOCHECK CONSTRAINT ALL 


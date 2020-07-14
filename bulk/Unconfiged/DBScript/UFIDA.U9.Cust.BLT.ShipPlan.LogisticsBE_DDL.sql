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
    [Discharge] float(53) null,
    [UnitPrice] float(53) null
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
    [Remark] nvarchar(50) null,
    [UintPrice] float(53) null
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
    add constraint [ebbcdfcc-6b71-44c8-88f3-c17065692a18_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceType]
    with check
    add constraint [43dd42ae-f320-4132-96fd-3a2e31c83e22_Default]
    default 0 for [PriceTypeEnum]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [5f1d8000-f204-49df-b9d1-6874ed2b4c20_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [812a71ad-0346-417f-8239-2a718ab936e7_Default]
    default 0 for [SerialNumber]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [bd344b03-1c3e-4a2b-9e8a-d636d6b65a55_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [789a026f-dde9-4b5d-93cd-88984a80f220_Default]
    default 0 for [Start]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [25001e94-da23-4ca2-8cbc-a55a352470e7_Default]
    default 0 for [Cutoff]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [2f6fdb5b-b8fe-4310-b75c-17e9bf2ca3ac_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [53b4aef1-781f-41d7-9b19-d2759869685f_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [26ba229c-76b0-40ce-b0d1-28d48a4f9409_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [5ad37aff-976a-4887-a696-9265d54a5b87_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [32564593-a5ac-48fc-9297-2373b1f9dbf1_Default]
    default 0 for [No]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [f0233fb0-a789-4532-8a1a-52662e2b72f3_Default]
    default 0 for [Price]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [f73bc558-2b8c-4216-bd76-9f3dbc21184d_Default]
    default 0 for [DeliveryPickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [0ed4dfb8-e496-41ab-8cd5-40a6f4a25a76_Default]
    default 0 for [DeliveryCharges]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [ba0520c1-9413-4d47-a800-21c8ee6e3928_Default]
    default 0 for [FreePickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [7a2a63c6-8e32-4afe-b589-fd040cf59079_Default]
    default 0 for [FreeDelivery]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [b940f160-2cea-4ed3-897b-ba2d80756431_Default]
    default 0 for [TransportationTime]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [29226283-1092-46cd-a94d-8e7be07697ab_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [d63c9ef1-a5fc-404d-9a54-a2edec2e400c_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [11c2d5c4-e8c2-4155-9173-d2f1ce2063c8_Default]
    default 0 for [ComputeBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [2cf1216a-47e5-48d2-b876-cadec9ebdc30_Default]
    default 0 for [TwoAddress]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [a759e728-8ed7-4912-9425-212985a19826_Default]
    default 0 for [Total]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [e5f95fbd-053b-4b8a-ab97-f9f7050b2c11_Default]
    default 0 for [TotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [89b358a0-6793-44f2-bfc9-3a2feee3b6af_Default]
    default 0 for [RealTotal]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [49f6a756-af0b-4f07-8bb0-1ff94f28c0b7_Default]
    default 0 for [RealTotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [01621ab6-debf-4263-8eb4-79f883f225d1_Default]
    default 0 for [TotalBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [2b4b2dc7-b428-457d-a370-287115077981_Default]
    default 0 for [TotalWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ac87a457-e0c3-437e-8b1b-037deb347da6_Default]
    default 0 for [RealBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [65882817-c824-4bec-8daa-6703256ed939_Default]
    default 0 for [RealWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [c82bd0d3-c162-4056-a225-b5499c8145af_Default]
    default 0 for [PickupAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [d5448f9b-36a6-4e3e-9087-5793b9fba69b_Default]
    default 0 for [ChargesAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [88b66e15-58e4-47d1-8313-6093efc23d56_Default]
    default 0 for [OtherAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [b400dad4-20f4-4fc6-a1ec-c09c11a2be10_Default]
    default 0 for [Discharge]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [0d0039a0-790b-417e-8e5a-3af7c6952d77_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [4f926d69-f888-4ad8-b45c-dab272fa8068_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [cb5df0bb-cd56-4bf5-aa4d-1565f1cf9dde_Default]
    default 0 for [SrcDocType]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [35497d44-3f8d-4c91-a268-ed8bc5257d31_Default]
    default 0 for [DocNoID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [f9cbb2e1-564f-4a2f-9d6c-905df8bac36e_Default]
    default 0 for [DocLineID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [7c978f95-1736-4ac9-9d66-d91a0fcbaefb_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [f2be3020-081f-4a80-9b07-23b3f81e0dfd_Default]
    default 0 for [ComputeBasisEnum]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [48c12136-dc6e-4b2d-ae9f-21cc8ad8a666_Default]
    default 0 for [Bulks]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [908becb4-94af-468d-b874-0c5b1b57ac68_Default]
    default 0 for [Weights]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [050b1c17-b83d-4bcf-9bae-4b1aa1c5a087_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [8514489e-2356-417d-87ec-70e805a918a6_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [03159f46-2b41-4fd3-aeb1-4f359e82e42b_Default]
    default 0 for [DocType]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [0e61f14c-042a-43f4-ad60-ccdd7deb7ffc_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [87c00a2d-0f02-4a5c-ae49-590a32760a7f_Default]
    default 0 for [ProductCategory]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [8c9d4eb6-3e99-4e8a-ab4f-48ee91e98a25_Default]
    default 0 for [IBulk]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [e5cdb9e4-b980-48d1-9bde-5fa618ac27df_Default]
    default 0 for [Weight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [466d7d75-0e1b-4df6-8d36-d6d6d62e0bde_Default]
    default 0 for [PickupFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [ded020eb-3f85-45c9-b7ce-7be4d0605f30_Default]
    default 0 for [DeliveryFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [4ae74a1a-9031-4bdd-b863-5c8d30f525b1_Default]
    default 0 for [DischargeFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [6585f3e8-a2cc-4767-8fdf-cce8a3a5c040_Default]
    default 0 for [OtherFee]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [86f98cd9-1411-400e-998f-b0ad96870dc3_Default]
    default 0 for [StandardShipping]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [641f8cdb-b59f-4d12-89cd-b79680139386_Default]
    default 0 for [TotalFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [a3974941-864b-45ac-973f-d1fd59a87b96_Default]
    default 0 for [RealFreight]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [d823ab70-48d6-4f3c-b0d0-2b0eaed24935_Default]
    default 0 for [AverageCost]
go

alter table [Cust_ShipPlan_LogisticsCosts]
    with check
    add constraint [68ba6ec9-b19d-415f-a2c5-2f884e376c67_Default]
    default 0 for [UintPrice]
go

/*=============TableAllCheck================*/

ALTER TABLE [Cust_ShipPlan_PriceType] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceTypeLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceListLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexListLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_LogisticsCosts] WITH CHECK NOCHECK CONSTRAINT ALL 


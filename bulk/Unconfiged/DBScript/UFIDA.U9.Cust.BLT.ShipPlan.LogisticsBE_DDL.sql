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

/*=============Default================*/

alter table [Cust_ShipPlan_PriceType]
    with check
    add constraint [ed73365a-3acc-4739-bbe2-ea1925e52367_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceType]
    with check
    add constraint [067d9518-fbb2-4141-bf5c-d0372d076942_Default]
    default 0 for [PriceTypeEnum]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [aaf964b0-20a1-49ed-8998-4391f85770ab_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [ac20ff13-5d8d-45c9-a71e-b20bee4af2d7_Default]
    default 0 for [SerialNumber]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [b1e316a3-359c-4e14-a5c0-b63e54f8c361_Default]
    default 0 for [UnitPrice]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [ef6bde22-73b7-4025-b52d-3d22e80e4768_Default]
    default 0 for [Start]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [56d7e047-f103-4aaf-aac5-f4ac2afff959_Default]
    default 0 for [Cutoff]
go

alter table [Cust_ShipPlan_PriceTypeLine]
    with check
    add constraint [3a53cdf3-0cfd-4833-b6ad-1947233a7751_Default]
    default 0 for [LineTotal]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [2a4c4a15-874c-4ff4-bb26-4ba3dc6c68b0_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceList]
    with check
    add constraint [8e6731f6-7976-4390-b3b8-2afcd75718d8_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [780512f6-0173-4486-818d-b86db6c58a70_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [0cc29656-f3e4-4602-9c47-c74a067eb6f7_Default]
    default 0 for [No]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [ec13a6a9-c601-4a79-9cae-a73a1eb7042d_Default]
    default 0 for [Price]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [c55f5e10-1186-4bde-adb9-2e12bb06742a_Default]
    default 0 for [DeliveryPickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [a73cb021-522a-4402-b63c-71efc3553d91_Default]
    default 0 for [DeliveryCharges]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [214f6cd3-765f-45fb-bfac-a27c12e18739_Default]
    default 0 for [FreePickup]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [384bcfef-dfe9-4f20-8017-09b97c78941c_Default]
    default 0 for [FreeDelivery]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [a1861ee0-4a38-4bed-822f-4ceebb053383_Default]
    default 0 for [TransportationTime]
go

alter table [Cust_ShipPlan_PriceListLine]
    with check
    add constraint [6ee8f7ab-df6b-49fe-96a5-5622541425fb_Default]
    default 0 for [CountBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [8344142b-82bf-4e3c-8a3e-93eb61440521_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [4c57f581-2ef6-4d7f-ba36-0df011d6b71d_Default]
    default 0 for [ComputeBasis]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [b0941d41-6035-4011-8704-5a2b993e375b_Default]
    default 0 for [TwoAddress]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [8cdac38b-3979-45f4-9dd2-7f6196041fdc_Default]
    default 0 for [Total]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [c4b9b099-3922-4aa3-b3e0-f83c380442d7_Default]
    default 0 for [TotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [05db2b44-e101-4e2b-b7b8-8bf79715f998_Default]
    default 0 for [RealTotal]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [7bc07f53-d1d2-4568-bb73-4190cc3f22fe_Default]
    default 0 for [RealTotalAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [35865492-162f-4a58-bb66-42e807c4a14f_Default]
    default 0 for [TotalBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [2c3f0f8c-b6c7-4505-8711-2fff0e3b4b0c_Default]
    default 0 for [TotalWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [89993fb0-00d5-490b-bb29-52af3a98862d_Default]
    default 0 for [RealBulk]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [82e14d8e-ecd2-4ad7-8985-b92feef9db26_Default]
    default 0 for [RealWeight]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [d1537c33-20bd-4627-b2cb-39cdc80b3076_Default]
    default 0 for [PickupAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [df94d187-d0da-42f9-9037-0d855f6549f6_Default]
    default 0 for [ChargesAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [48be8dd1-c1cf-4a80-ba43-ea0bc88cea6b_Default]
    default 0 for [OtherAmount]
go

alter table [Cust_ShipPlan_ComplexList]
    with check
    add constraint [ec6a4458-ca73-4d8f-946d-0312a9a861ce_Default]
    default 0 for [Discharge]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [3f9dd0ec-b98b-45ed-817e-bf8625959d29_Default]
    default 0 for [SysVersion]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [ed357cbb-66e1-4f3f-ab00-29b557d272e3_Default]
    default 0 for [SrcDocType]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [5a8eb686-d0b4-42af-b91a-9727723d7723_Default]
    default 0 for [DocNoID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [5859b67b-3986-430c-8f6b-71f74a4a78df_Default]
    default 0 for [DocLineID]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [e41de8e0-9aba-40a2-93b7-bc65c6710829_Default]
    default 0 for [Qty]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [71047323-3571-46f2-9bfe-2af4cdb75e39_Default]
    default 0 for [ComputeBasisEnum]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [4f9bf6d6-f397-4bc1-9bf7-cafbc625fc84_Default]
    default 0 for [Bulks]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [57b1d25e-86b9-41a0-a41d-9ef7f2690f64_Default]
    default 0 for [Weights]
go

alter table [Cust_ShipPlan_ComplexListLine]
    with check
    add constraint [fd319665-40a0-4687-9841-efa40e277af2_Default]
    default 0 for [LineTotal]
go

/*=============TableAllCheck================*/

ALTER TABLE [Cust_ShipPlan_PriceType] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceTypeLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_PriceListLine] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexList] WITH CHECK NOCHECK CONSTRAINT ALL 
ALTER TABLE [Cust_ShipPlan_ComplexListLine] WITH CHECK NOCHECK CONSTRAINT ALL 


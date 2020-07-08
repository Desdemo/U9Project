#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI
{
	[Serializable]
	public partial class PriceListUIModelModel : UIModel
	{
		#region Constructor
		public PriceListUIModelModel() : base("PriceListUIModel")
		{
			InitClass();
			this.SetResourceInfo("1a463b06-e390-4032-8d2b-cb0f8e35e11f");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private PriceListUIModelModel(bool isInit) : base("PriceListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new PriceListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private PriceListView viewPriceList;			
		private PriceList_PriceListLineView viewPriceList_PriceListLine;			
		#endregion
		
		#region links
		//private IUILink linkPriceList__PriceList_PriceListLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public PriceListView PriceList
		{
			get { return (PriceListView)this["PriceList"]; }
		}
		public PriceList_PriceListLineView PriceList_PriceListLine
		{
			get { return (PriceList_PriceListLineView)this["PriceList_PriceListLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewPriceList = new PriceListView(this);
			this.viewPriceList.SetResourceInfo("c3432f51-6865-4297-b399-a86330ca3367");
			this.Views.Add(this.viewPriceList);			
			this.viewPriceList_PriceListLine = new PriceList_PriceListLineView(this);
			this.viewPriceList_PriceListLine.SetResourceInfo("a9ffb518-3dbb-4613-b0ba-6493cbcffca5");
			this.Views.Add(this.viewPriceList_PriceListLine);			

			//this.linkPriceList__PriceList_PriceListLine
			{
			IUILink link = new UILink("PriceList__PriceList_PriceListLine",this,this.viewPriceList.FieldID,this.viewPriceList_PriceListLine.FieldPriceList,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"PriceListLine");
			this.Links.Add(link);
			}
			//this.linkPriceList__PriceList_PriceListLine.ChildKeyConstraint.UpdateRule = Rule.Cascade;
			//this.linkPriceList__PriceList_PriceListLine.ChildKeyConstraint.DeleteRule = Rule.Cascade;
			//this.linkPriceList__PriceList_PriceListLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class PriceListView : UIView
	{
		#region Constructor
		public PriceListView(IUIModel model) : base(model,"PriceList","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceList", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private PriceListView():base(null,"PriceList","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceList", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new PriceListView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldDocNo
		{
			get { return this.Fields["DocNo"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldSupplier
		{
			get { return this.Fields["Supplier"]; }
		}
		public IUIField FieldSupplier_Code
		{
			get { return this.Fields["Supplier_Code"]; }
		}
		public IUIField FieldSupplier_Name
		{
			get { return this.Fields["Supplier_Name"]; }
		}
		public IUIField FieldCurrency
		{
			get { return this.Fields["Currency"]; }
		}
		public IUIField FieldCurrency_Code
		{
			get { return this.Fields["Currency_Code"]; }
		}
		public IUIField FieldCurrency_Name
		{
			get { return this.Fields["Currency_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public PriceListDefaultFilterFilter DefaultFilter
		{
			get { return (PriceListDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","496ee9e7-d45e-44ec-b098-8dbec223a59a");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5cb43273-0ecb-47b2-8623-36b8bba3f962");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","285e61d9-68c7-44a3-bce0-8adb659bf4cf");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","0d3ddf82-8fea-4431-9f8d-ab59128d287d");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","427fb585-f459-4d8b-bb17-5dee3aebae94");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","8ef30dab-285d-4e4a-99fa-b50a622f3766");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","73a95037-a38b-4cf0-a331-201f7141576b");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), false,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b348be7d-467f-4110-a7be-006244124749");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "Supplier", true,true, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","256c2380-fa7d-4e6e-9adb-c559ae4cff95");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Code", typeof(String), false,"","System.String", "Supplier.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d1464d4-8c28-4605-b2c6-c35a92dd4b2f");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Name", typeof(String), true,"","System.String", "Supplier.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5b9e3fc4-647a-49b9-93b0-c993bd133b66");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency", typeof(Int64), false,"","UFIDA.U9.Base.Currency.Currency", "Currency", true,true, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","cedada45-a8b8-492d-bb21-d20d17de9f97");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Code", typeof(String), false,"","System.String", "Currency.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4d87562-7768-4058-8a71-c460e4a47aea");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Name", typeof(String), true,"","System.String", "Currency.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","47fbf264-dd09-4568-a981-f3e47dcf6d8e");


			this.CurrentFilter = new PriceListDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new PriceListRecord(builder);
		}
		#endregion

		#region new method
		public new PriceListRecord FocusedRecord
		{
			get { return (PriceListRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new PriceListRecord AddNewUIRecord()
		{	
			return (PriceListRecord)base.AddNewUIRecord();
		}
		public new PriceListRecord NewUIRecord()
		{	
			return (PriceListRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class PriceListRecord : UIRecord
	{
		#region Constructor
		public PriceListRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private PriceListView uiviewPriceList
		{
			get { return (PriceListView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new PriceListRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewPriceList.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceList.FieldID);
			}
			set{
				this[this.uiviewPriceList.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewPriceList.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceList.FieldCreatedOn);
			}
			set{
				this[this.uiviewPriceList.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewPriceList.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldCreatedBy);
			}
			set{
				this[this.uiviewPriceList.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewPriceList.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceList.FieldModifiedOn);
			}
			set{
				this[this.uiviewPriceList.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewPriceList.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldModifiedBy);
			}
			set{
				this[this.uiviewPriceList.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewPriceList.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewPriceList.FieldSysVersion);
			}
			set{
				this[this.uiviewPriceList.FieldSysVersion] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewPriceList.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldDocNo);
			}
			set{
				this[this.uiviewPriceList.FieldDocNo] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewPriceList.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldName);
			}
			set{
				this[this.uiviewPriceList.FieldName] = value;
			}
		}
		
		
		public  Int64 Supplier
		{
			get{
				//object value = this[this.uiviewPriceList.FieldSupplier] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceList.FieldSupplier);
			}
			set{
				this[this.uiviewPriceList.FieldSupplier] = value;
			}
		}
		
		
		public  String Supplier_Code
		{
			get{
				//object value = this[this.uiviewPriceList.FieldSupplier_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldSupplier_Code);
			}
			set{
				this[this.uiviewPriceList.FieldSupplier_Code] = value;
			}
		}
		
		
		public  String Supplier_Name
		{
			get{
				//object value = this[this.uiviewPriceList.FieldSupplier_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldSupplier_Name);
			}
			set{
				this[this.uiviewPriceList.FieldSupplier_Name] = value;
			}
		}
		
		
		public  Int64 Currency
		{
			get{
				//object value = this[this.uiviewPriceList.FieldCurrency] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceList.FieldCurrency);
			}
			set{
				this[this.uiviewPriceList.FieldCurrency] = value;
			}
		}
		
		
		public  String Currency_Code
		{
			get{
				//object value = this[this.uiviewPriceList.FieldCurrency_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldCurrency_Code);
			}
			set{
				this[this.uiviewPriceList.FieldCurrency_Code] = value;
			}
		}
		
		
		public  String Currency_Name
		{
			get{
				//object value = this[this.uiviewPriceList.FieldCurrency_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList.FieldCurrency_Name);
			}
			set{
				this[this.uiviewPriceList.FieldCurrency_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class PriceListDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public PriceListDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private PriceListDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new PriceListDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



	[Serializable]
	public partial class PriceList_PriceListLineView : UIView
	{
		#region Constructor
		public PriceList_PriceListLineView(IUIModel model) : base(model,"PriceList_PriceListLine","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceListLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private PriceList_PriceListLineView():base(null,"PriceList_PriceListLine","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceListLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new PriceList_PriceListLineView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldPriceList
		{
			get { return this.Fields["PriceList"]; }
		}
		public IUIField FieldPriceList_Name
		{
			get { return this.Fields["PriceList_Name"]; }
		}
		public IUIField FieldNo
		{
			get { return this.Fields["No"]; }
		}
		public IUIField FieldDeparture
		{
			get { return this.Fields["Departure"]; }
		}
		public IUIField FieldDeparture_Code
		{
			get { return this.Fields["Departure_Code"]; }
		}
		public IUIField FieldDeparture_Name
		{
			get { return this.Fields["Departure_Name"]; }
		}
		public IUIField FieldDestination
		{
			get { return this.Fields["Destination"]; }
		}
		public IUIField FieldDestination_Code
		{
			get { return this.Fields["Destination_Code"]; }
		}
		public IUIField FieldDestination_Name
		{
			get { return this.Fields["Destination_Name"]; }
		}
		public IUIField FieldSalesUnit
		{
			get { return this.Fields["SalesUnit"]; }
		}
		public IUIField FieldSalesUnit_Code
		{
			get { return this.Fields["SalesUnit_Code"]; }
		}
		public IUIField FieldSalesUnit_Name
		{
			get { return this.Fields["SalesUnit_Name"]; }
		}
		public IUIField FieldPrice
		{
			get { return this.Fields["Price"]; }
		}
		public IUIField FieldDynamicPrice
		{
			get { return this.Fields["DynamicPrice"]; }
		}
		public IUIField FieldDynamicPrice_Name
		{
			get { return this.Fields["DynamicPrice_Name"]; }
		}
		public IUIField FieldDeliveryPickup
		{
			get { return this.Fields["DeliveryPickup"]; }
		}
		public IUIField FieldDeliveryCharges
		{
			get { return this.Fields["DeliveryCharges"]; }
		}
		public IUIField FieldFreePickup
		{
			get { return this.Fields["FreePickup"]; }
		}
		public IUIField FieldFreeDelivery
		{
			get { return this.Fields["FreeDelivery"]; }
		}
		public IUIField FieldTransportationTime
		{
			get { return this.Fields["TransportationTime"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}
		public IUIField FieldDynamicPrice_Coding
		{
			get { return this.Fields["DynamicPrice_Coding"]; }
		}
		public IUIField FieldCountBasis
		{
			get { return this.Fields["CountBasis"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public PriceList_PriceListLineDefaultFilterFilter DefaultFilter
		{
			get { return (PriceList_PriceListLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b569b9ed-c841-43f3-9bac-ef4c00d4b382");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","bee245fa-a3a8-4597-a2f8-cb3c7c3e551c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ba04b6c-e1eb-49c0-af82-485de0fe2cdc");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","da1b68c5-3079-48f4-833d-2552f01cc346");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ca5912a-c0a4-470e-911c-fd39117feafd");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","23e988b8-5e1f-453b-a562-6d1f71d27d08");
			UIModelRuntimeFactory.AddNewUIField(this,"PriceList", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceList", "PriceList", true,true, false, "",false,(UIFieldType)4,"df6720e0-e134-4ec5-a030-9f2e18d19d6f","1461c1c9-d414-44b4-8cdb-d990ca87ca7e");
			UIModelRuntimeFactory.AddNewUIField(this,"PriceList_Name", typeof(String), false,"","System.String", "PriceList.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25971cca-bc35-4e7a-9999-d9d9f45f8847");
			UIModelRuntimeFactory.AddNewUIField(this,"No", typeof(Int32), false,"0","System.Int32", "No", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","b2f32ef9-7a2f-4f0e-a395-358f48a87b76");
			UIModelRuntimeFactory.AddNewUIField(this,"Departure", typeof(Int64), false,"","UFIDA.U9.Base.Location.Location", "Departure", true,true, false, "",false,(UIFieldType)4,"9f2e8034-0609-402e-9dc1-edfdecb1d8d6","06d2dfb0-bffa-4585-978b-78a7cffdd4a0");
			UIModelRuntimeFactory.AddNewUIField(this,"Departure_Code", typeof(String), false,"","System.String", "Departure.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","819f585e-1529-4c3e-88eb-b82ce8602ffe");
			UIModelRuntimeFactory.AddNewUIField(this,"Departure_Name", typeof(String), true,"","System.String", "Departure.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8ad9d704-4016-4eba-88e2-cf57a569e4cf");
			UIModelRuntimeFactory.AddNewUIField(this,"Destination", typeof(Int64), false,"","UFIDA.U9.Base.Location.Location", "Destination", true,true, false, "",false,(UIFieldType)4,"9f2e8034-0609-402e-9dc1-edfdecb1d8d6","bbfa07a5-0625-4435-8529-4c6c64eaf7bb");
			UIModelRuntimeFactory.AddNewUIField(this,"Destination_Code", typeof(String), false,"","System.String", "Destination.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","badf8462-72c1-4793-8908-cae0781a450b");
			UIModelRuntimeFactory.AddNewUIField(this,"Destination_Name", typeof(String), true,"","System.String", "Destination.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ed0189fd-247a-43c3-8432-9967d3c8a180");
			UIModelRuntimeFactory.AddNewUIField(this,"SalesUnit", typeof(Int64), false,"","UFIDA.U9.Base.UOM.UOM", "SalesUnit", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","cd5c6b3e-245b-4475-a18a-082d85f6f5b3");
			UIModelRuntimeFactory.AddNewUIField(this,"SalesUnit_Code", typeof(String), false,"","System.String", "SalesUnit.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","76ea1385-5260-40a2-a55b-2f9718b35d42");
			UIModelRuntimeFactory.AddNewUIField(this,"SalesUnit_Name", typeof(String), true,"","System.String", "SalesUnit.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7610f2db-14f6-445d-8f1b-2da5be9d65fd");
			UIModelRuntimeFactory.AddNewUIField(this,"Price", typeof(Double), true,"0","System.Double", "Price", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","a9c3e31b-62f8-44b0-89fe-0fcf9d6dba90");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceType", "DynamicPrice", true,true, false, "",false,(UIFieldType)4,"bd95fd8c-8ea8-44e4-9b29-6b1d3075fe9b","2babad27-3d0f-45b4-809d-5c738c0e3c6f");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice_Name", typeof(String), false,"","System.String", "DynamicPrice.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","885b77c3-7d10-4d51-b4bf-6a3d52cef868");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryPickup", typeof(Double), true,"0","System.Double", "DeliveryPickup", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","3e3a9e0a-c9dc-457c-be5c-36ba6ce1213f");
			UIModelRuntimeFactory.AddNewUIField(this,"DeliveryCharges", typeof(Double), true,"0","System.Double", "DeliveryCharges", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","ca8ba677-fbf1-418e-b311-f939f540cad5");
			UIModelRuntimeFactory.AddNewUIField(this,"FreePickup", typeof(Int32), true,"0","System.Int32", "FreePickup", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","2595f814-fbc0-4e8d-a67e-5d4e9e003df9");
			UIModelRuntimeFactory.AddNewUIField(this,"FreeDelivery", typeof(Int32), true,"0","System.Int32", "FreeDelivery", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","a7282dc2-c24e-4598-a591-cc604b72fe9d");
			UIModelRuntimeFactory.AddNewUIField(this,"TransportationTime", typeof(Int32), true,"0","System.Int32", "TransportationTime", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","c475ae55-49d9-4a50-9432-d9f8a3884c54");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","089d10d1-df6b-405f-a19d-307cff7b76bd");
			UIModelRuntimeFactory.AddNewUIField(this,"DynamicPrice_Coding", typeof(String), false,"","System.String", "DynamicPrice.Coding", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7abca8b5-17b0-46dc-b545-e98eee0a343a");
			UIModelRuntimeFactory.AddNewUIField(this,"CountBasis", typeof(Int32), false,"0","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.ComputeBasisEnum", "CountBasis", true,true, false, "",false,(UIFieldType)2,"e3295719-9440-48ec-9a0f-173daca91077","418a389b-3d57-4846-9365-5ca05fe15faf");


			this.CurrentFilter = new PriceList_PriceListLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new PriceList_PriceListLineRecord(builder);
		}
		#endregion

		#region new method
		public new PriceList_PriceListLineRecord FocusedRecord
		{
			get { return (PriceList_PriceListLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new PriceList_PriceListLineRecord AddNewUIRecord()
		{	
			return (PriceList_PriceListLineRecord)base.AddNewUIRecord();
		}
		public new PriceList_PriceListLineRecord NewUIRecord()
		{	
			return (PriceList_PriceListLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class PriceList_PriceListLineRecord : UIRecord
	{
		#region Constructor
		public PriceList_PriceListLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private PriceList_PriceListLineView uiviewPriceList_PriceListLine
		{
			get { return (PriceList_PriceListLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new PriceList_PriceListLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceList_PriceListLine.FieldID);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceList_PriceListLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceList_PriceListLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewPriceList_PriceListLine.FieldSysVersion);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? PriceList
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldPriceList] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewPriceList_PriceListLine.FieldPriceList);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldPriceList] = value;
			}
		}
		
		
		public  String PriceList_Name
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldPriceList_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldPriceList_Name);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldPriceList_Name] = value;
			}
		}
		
		
		public  Int32 No
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldNo] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewPriceList_PriceListLine.FieldNo);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldNo] = value;
			}
		}
		
		
		public  Int64 Departure
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDeparture] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceList_PriceListLine.FieldDeparture);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDeparture] = value;
			}
		}
		
		
		public  String Departure_Code
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDeparture_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldDeparture_Code);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDeparture_Code] = value;
			}
		}
		
		
		public  String Departure_Name
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDeparture_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldDeparture_Name);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDeparture_Name] = value;
			}
		}
		
		
		public  Int64 Destination
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDestination] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceList_PriceListLine.FieldDestination);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDestination] = value;
			}
		}
		
		
		public  String Destination_Code
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDestination_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldDestination_Code);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDestination_Code] = value;
			}
		}
		
		
		public  String Destination_Name
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDestination_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldDestination_Name);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDestination_Name] = value;
			}
		}
		
		
		public  Int64 SalesUnit
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldSalesUnit] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceList_PriceListLine.FieldSalesUnit);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldSalesUnit] = value;
			}
		}
		
		
		public  String SalesUnit_Code
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldSalesUnit_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldSalesUnit_Code);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldSalesUnit_Code] = value;
			}
		}
		
		
		public  String SalesUnit_Name
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldSalesUnit_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldSalesUnit_Name);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldSalesUnit_Name] = value;
			}
		}
		
		
		public  Double? Price
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldPrice] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewPriceList_PriceListLine.FieldPrice);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldPrice] = value;
			}
		}
		
		
		public  Int64? DynamicPrice
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDynamicPrice] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewPriceList_PriceListLine.FieldDynamicPrice);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDynamicPrice] = value;
			}
		}
		
		
		public  String DynamicPrice_Name
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDynamicPrice_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldDynamicPrice_Name);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDynamicPrice_Name] = value;
			}
		}
		
		
		public  Double? DeliveryPickup
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDeliveryPickup] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewPriceList_PriceListLine.FieldDeliveryPickup);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDeliveryPickup] = value;
			}
		}
		
		
		public  Double? DeliveryCharges
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDeliveryCharges] ;
				//return (Double?)value;
				return GetValue<Double?>(this.uiviewPriceList_PriceListLine.FieldDeliveryCharges);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDeliveryCharges] = value;
			}
		}
		
		
		public  Int32? FreePickup
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldFreePickup] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewPriceList_PriceListLine.FieldFreePickup);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldFreePickup] = value;
			}
		}
		
		
		public  Int32? FreeDelivery
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldFreeDelivery] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewPriceList_PriceListLine.FieldFreeDelivery);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldFreeDelivery] = value;
			}
		}
		
		
		public  Int32? TransportationTime
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldTransportationTime] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewPriceList_PriceListLine.FieldTransportationTime);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldTransportationTime] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldRemark);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldRemark] = value;
			}
		}
		
		
		public  String DynamicPrice_Coding
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldDynamicPrice_Coding] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceList_PriceListLine.FieldDynamicPrice_Coding);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldDynamicPrice_Coding] = value;
			}
		}
		
		
		public  Int32 CountBasis
		{
			get{
				//object value = this[this.uiviewPriceList_PriceListLine.FieldCountBasis] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewPriceList_PriceListLine.FieldCountBasis);
			}
			set{
				this[this.uiviewPriceList_PriceListLine.FieldCountBasis] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class PriceList_PriceListLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public PriceList_PriceListLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private PriceList_PriceListLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new PriceList_PriceListLineDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}
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
	public partial class PriceTypeUIModelModel : UIModel
	{
		#region Constructor
		public PriceTypeUIModelModel() : base("PriceTypeUIModel")
		{
			InitClass();
			this.SetResourceInfo("4396f785-7a0c-4db9-ab24-e0a623b9c76d");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private PriceTypeUIModelModel(bool isInit) : base("PriceTypeUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new PriceTypeUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private PriceTypeView viewPriceType;			
		private PriceType_PriceTypeLineView viewPriceType_PriceTypeLine;			
		#endregion
		
		#region links
		//private IUILink linkPriceType__PriceType_PriceTypeLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public PriceTypeView PriceType
		{
			get { return (PriceTypeView)this["PriceType"]; }
		}
		public PriceType_PriceTypeLineView PriceType_PriceTypeLine
		{
			get { return (PriceType_PriceTypeLineView)this["PriceType_PriceTypeLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewPriceType = new PriceTypeView(this);
			this.viewPriceType.SetResourceInfo("a9925b5a-f720-4a9f-8428-34f0f8382343");
			this.Views.Add(this.viewPriceType);			
			this.viewPriceType_PriceTypeLine = new PriceType_PriceTypeLineView(this);
			this.viewPriceType_PriceTypeLine.SetResourceInfo("fa12a733-9d2b-431e-9dee-51dff9a9cedf");
			this.Views.Add(this.viewPriceType_PriceTypeLine);			

			//this.linkPriceType__PriceType_PriceTypeLine
			{
			IUILink link = new UILink("PriceType__PriceType_PriceTypeLine",this,this.viewPriceType.FieldID,this.viewPriceType_PriceTypeLine.FieldPriceType,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"PriceTypeLine");
			this.Links.Add(link);
			}
			//this.linkPriceType__PriceType_PriceTypeLine.ChildKeyConstraint.UpdateRule = Rule.Cascade;
			//this.linkPriceType__PriceType_PriceTypeLine.ChildKeyConstraint.DeleteRule = Rule.Cascade;
			//this.linkPriceType__PriceType_PriceTypeLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class PriceTypeView : UIView
	{
		#region Constructor
		public PriceTypeView(IUIModel model) : base(model,"PriceType","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private PriceTypeView():base(null,"PriceType","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new PriceTypeView();
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
		public IUIField FieldPriceTypeEnum
		{
			get { return this.Fields["PriceTypeEnum"]; }
		}
		public IUIField FieldCoding
		{
			get { return this.Fields["Coding"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
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
		public IUIField FieldUom
		{
			get { return this.Fields["Uom"]; }
		}
		public IUIField FieldUom_Code
		{
			get { return this.Fields["Uom_Code"]; }
		}
		public IUIField FieldUom_Name
		{
			get { return this.Fields["Uom_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public PriceTypeDefaultFilterFilter DefaultFilter
		{
			get { return (PriceTypeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","7eec2b7d-b871-4cf2-88d8-ef5f0c631f8a");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","240d3eb5-9f5c-4e27-a2e4-bb792c0e4590");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99798590-eb58-431b-9460-cfd5b459e74b");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","2cc6d2e8-bdf4-4db1-871b-a91ef231e9d0");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a9f58c7e-5e95-4ff5-adde-827b285579e5");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","fdb23c5d-a89b-4be7-8e42-0fac81bb36c5");
			UIModelRuntimeFactory.AddNewUIField(this,"PriceTypeEnum", typeof(Int32), false,"0","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceTypeEnum", "PriceTypeEnum", true,true, false, "",false,(UIFieldType)2,"02bf117d-2b6a-4558-ad7a-00399f3eb0d5","73c4ab19-25d1-4896-960a-f23d872788c6");
			UIModelRuntimeFactory.AddNewUIField(this,"Coding", typeof(String), false,"","System.String", "Coding", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","70928766-da98-4e18-8c94-d029714593a6");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), false,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0f06fcbe-7c38-484f-afdc-fe41235f502a");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b5d9295-fec6-478e-9f0e-85c9d2c6ef31");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency", typeof(Int64), false,"","UFIDA.U9.Base.Currency.Currency", "Currency", true,true, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","b0416bc9-3fc1-4e4c-bdf1-d284050a7ce6");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Code", typeof(String), false,"","System.String", "Currency.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1b7a472c-5f4f-4cdf-8227-9ac110216b82");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Name", typeof(String), true,"","System.String", "Currency.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a698d77e-a90f-40eb-b821-0e345279c290");
			UIModelRuntimeFactory.AddNewUIField(this,"Uom", typeof(Int64), false,"","UFIDA.U9.Base.UOM.UOM", "Uom", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","9802c413-3a08-4f5b-8821-3f99755820ec");
			UIModelRuntimeFactory.AddNewUIField(this,"Uom_Code", typeof(String), false,"","System.String", "Uom.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f58e2446-3c38-4d74-8073-f334d2c45230");
			UIModelRuntimeFactory.AddNewUIField(this,"Uom_Name", typeof(String), true,"","System.String", "Uom.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1e103ef-7644-4a50-a249-ec46de6a896b");


			this.CurrentFilter = new PriceTypeDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new PriceTypeRecord(builder);
		}
		#endregion

		#region new method
		public new PriceTypeRecord FocusedRecord
		{
			get { return (PriceTypeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new PriceTypeRecord AddNewUIRecord()
		{	
			return (PriceTypeRecord)base.AddNewUIRecord();
		}
		public new PriceTypeRecord NewUIRecord()
		{	
			return (PriceTypeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class PriceTypeRecord : UIRecord
	{
		#region Constructor
		public PriceTypeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private PriceTypeView uiviewPriceType
		{
			get { return (PriceTypeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new PriceTypeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewPriceType.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceType.FieldID);
			}
			set{
				this[this.uiviewPriceType.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewPriceType.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceType.FieldCreatedOn);
			}
			set{
				this[this.uiviewPriceType.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewPriceType.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldCreatedBy);
			}
			set{
				this[this.uiviewPriceType.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewPriceType.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceType.FieldModifiedOn);
			}
			set{
				this[this.uiviewPriceType.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewPriceType.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldModifiedBy);
			}
			set{
				this[this.uiviewPriceType.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewPriceType.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewPriceType.FieldSysVersion);
			}
			set{
				this[this.uiviewPriceType.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32 PriceTypeEnum
		{
			get{
				//object value = this[this.uiviewPriceType.FieldPriceTypeEnum] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewPriceType.FieldPriceTypeEnum);
			}
			set{
				this[this.uiviewPriceType.FieldPriceTypeEnum] = value;
			}
		}
		
		
		public  String Coding
		{
			get{
				//object value = this[this.uiviewPriceType.FieldCoding] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldCoding);
			}
			set{
				this[this.uiviewPriceType.FieldCoding] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewPriceType.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldName);
			}
			set{
				this[this.uiviewPriceType.FieldName] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewPriceType.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldRemark);
			}
			set{
				this[this.uiviewPriceType.FieldRemark] = value;
			}
		}
		
		
		public  Int64 Currency
		{
			get{
				//object value = this[this.uiviewPriceType.FieldCurrency] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceType.FieldCurrency);
			}
			set{
				this[this.uiviewPriceType.FieldCurrency] = value;
			}
		}
		
		
		public  String Currency_Code
		{
			get{
				//object value = this[this.uiviewPriceType.FieldCurrency_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldCurrency_Code);
			}
			set{
				this[this.uiviewPriceType.FieldCurrency_Code] = value;
			}
		}
		
		
		public  String Currency_Name
		{
			get{
				//object value = this[this.uiviewPriceType.FieldCurrency_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldCurrency_Name);
			}
			set{
				this[this.uiviewPriceType.FieldCurrency_Name] = value;
			}
		}
		
		
		public  Int64 Uom
		{
			get{
				//object value = this[this.uiviewPriceType.FieldUom] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceType.FieldUom);
			}
			set{
				this[this.uiviewPriceType.FieldUom] = value;
			}
		}
		
		
		public  String Uom_Code
		{
			get{
				//object value = this[this.uiviewPriceType.FieldUom_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldUom_Code);
			}
			set{
				this[this.uiviewPriceType.FieldUom_Code] = value;
			}
		}
		
		
		public  String Uom_Name
		{
			get{
				//object value = this[this.uiviewPriceType.FieldUom_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType.FieldUom_Name);
			}
			set{
				this[this.uiviewPriceType.FieldUom_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class PriceTypeDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public PriceTypeDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private PriceTypeDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new PriceTypeDefaultFilterFilter();
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
	public partial class PriceType_PriceTypeLineView : UIView
	{
		#region Constructor
		public PriceType_PriceTypeLineView(IUIModel model) : base(model,"PriceType_PriceTypeLine","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceTypeLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private PriceType_PriceTypeLineView():base(null,"PriceType_PriceTypeLine","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceTypeLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new PriceType_PriceTypeLineView();
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
		public IUIField FieldPriceType
		{
			get { return this.Fields["PriceType"]; }
		}
		public IUIField FieldSerialNumber
		{
			get { return this.Fields["SerialNumber"]; }
		}
		public IUIField FieldUnitPrice
		{
			get { return this.Fields["UnitPrice"]; }
		}
		public IUIField FieldStart
		{
			get { return this.Fields["Start"]; }
		}
		public IUIField FieldCutoff
		{
			get { return this.Fields["Cutoff"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}
		public IUIField FieldLineTotal
		{
			get { return this.Fields["LineTotal"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public PriceType_PriceTypeLineDefaultFilterFilter DefaultFilter
		{
			get { return (PriceType_PriceTypeLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","06c76786-b39b-4686-a4c9-5b96c17ed072");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","aa3167df-e852-4a32-8633-d76c69a3c547");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fc63758b-5d82-4bbe-8587-2901a5f55cb2");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","edbcd0a8-952d-4e62-8e72-41e540b6d81a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","945ebc56-962f-4cbe-b9a4-76b1c2382197");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ae2465c2-66a3-4551-8df0-00cc79cf38ff");
			UIModelRuntimeFactory.AddNewUIField(this,"PriceType", typeof(Int64), true,"","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceType", "PriceType", true,true, false, "",false,(UIFieldType)4,"bd95fd8c-8ea8-44e4-9b29-6b1d3075fe9b","d322e08b-ed1d-460a-b60c-3784067abd53");
			UIModelRuntimeFactory.AddNewUIField(this,"SerialNumber", typeof(Int32), false,"0","System.Int32", "SerialNumber", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","65a14ea2-2ff2-4232-a7d4-80a6070de175");
			UIModelRuntimeFactory.AddNewUIField(this,"UnitPrice", typeof(Double), false,"0","System.Double", "UnitPrice", true,true, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","9eaee70e-0126-4ec7-8c9d-ebca83efec02");
			UIModelRuntimeFactory.AddNewUIField(this,"Start", typeof(Int32), false,"0","System.Int32", "Start", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","4fd9c896-22ce-4d9b-a239-101e2e2d046f");
			UIModelRuntimeFactory.AddNewUIField(this,"Cutoff", typeof(Int32), false,"0","System.Int32", "Cutoff", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","4aa50aa9-9df1-40c0-a9ae-011be5a21be7");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3da9bff5-8328-4aa4-bd27-c910a8f723ed");
			UIModelRuntimeFactory.AddNewUIField(this,"LineTotal", typeof(Int32), false,"0","System.Int32", "LineTotal", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","1642a902-9494-41bd-b6e7-42001aad2907");


			this.CurrentFilter = new PriceType_PriceTypeLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new PriceType_PriceTypeLineRecord(builder);
		}
		#endregion

		#region new method
		public new PriceType_PriceTypeLineRecord FocusedRecord
		{
			get { return (PriceType_PriceTypeLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new PriceType_PriceTypeLineRecord AddNewUIRecord()
		{	
			return (PriceType_PriceTypeLineRecord)base.AddNewUIRecord();
		}
		public new PriceType_PriceTypeLineRecord NewUIRecord()
		{	
			return (PriceType_PriceTypeLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class PriceType_PriceTypeLineRecord : UIRecord
	{
		#region Constructor
		public PriceType_PriceTypeLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private PriceType_PriceTypeLineView uiviewPriceType_PriceTypeLine
		{
			get { return (PriceType_PriceTypeLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new PriceType_PriceTypeLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewPriceType_PriceTypeLine.FieldID);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceType_PriceTypeLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType_PriceTypeLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewPriceType_PriceTypeLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType_PriceTypeLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewPriceType_PriceTypeLine.FieldSysVersion);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? PriceType
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldPriceType] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewPriceType_PriceTypeLine.FieldPriceType);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldPriceType] = value;
			}
		}
		
		
		public  Int32 SerialNumber
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldSerialNumber] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewPriceType_PriceTypeLine.FieldSerialNumber);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldSerialNumber] = value;
			}
		}
		
		
		public  Double UnitPrice
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldUnitPrice] ;
				//return (Double)value;
				return GetValue<Double>(this.uiviewPriceType_PriceTypeLine.FieldUnitPrice);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldUnitPrice] = value;
			}
		}
		
		
		public  Int32 Start
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldStart] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewPriceType_PriceTypeLine.FieldStart);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldStart] = value;
			}
		}
		
		
		public  Int32 Cutoff
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldCutoff] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewPriceType_PriceTypeLine.FieldCutoff);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldCutoff] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewPriceType_PriceTypeLine.FieldRemark);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldRemark] = value;
			}
		}
		
		
		public  Int32 LineTotal
		{
			get{
				//object value = this[this.uiviewPriceType_PriceTypeLine.FieldLineTotal] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewPriceType_PriceTypeLine.FieldLineTotal);
			}
			set{
				this[this.uiviewPriceType_PriceTypeLine.FieldLineTotal] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class PriceType_PriceTypeLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public PriceType_PriceTypeLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private PriceType_PriceTypeLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new PriceType_PriceTypeLineDefaultFilterFilter();
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
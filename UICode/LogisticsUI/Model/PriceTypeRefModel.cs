#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace PriceTypeRef
{
	[Serializable]
	public partial class PriceTypeRefModel : UIModel
	{
		#region Constructor
		public PriceTypeRefModel() : base("PriceTypeRef")
		{
			InitClass();
			this.SetResourceInfo("5089809c-f207-4346-aebe-1b12fb68b033");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private PriceTypeRefModel(bool isInit) : base("PriceTypeRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new PriceTypeRefModel(false);
		}
		#endregion
		#region member
		#region views
		private cRefView viewcRef;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public cRefView cRef
		{
			get { return (cRefView)this["cRef"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewcRef = new cRefView(this);
			this.viewcRef.SetResourceInfo("3eef1ab4-bd0c-41ce-9279-7b5c75402ec8");
			this.Views.Add(this.viewcRef);			

			
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
	public partial class cRefView : UIView
	{
		#region Constructor
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCoding
		{
			get { return this.Fields["Coding"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldPriceTypeEnum
		{
			get { return this.Fields["PriceTypeEnum"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","907ad3e6-0ff1-4677-9e11-9ac862b72b48");
			UIModelRuntimeFactory.AddNewUIField(this,"Coding", typeof(String), false,"","System.String", "Coding", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b8054205-238e-4e52-a8c3-b957b6916859");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), false,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b07386a1-6b81-4259-aba6-7b8cd53869b4");
			UIModelRuntimeFactory.AddNewUIField(this,"PriceTypeEnum", typeof(Int32), false,"","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceTypeEnum", "PriceTypeEnum", true,true, false, "",false,(UIFieldType)2,"02bf117d-2b6a-4558-ad7a-00399f3eb0d5","e52c5767-0e80-4d55-bd34-3725da0781b4");


			this.CurrentFilter = new cRefDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region new method
		public new cRefRecord FocusedRecord
		{
			get { return (cRefRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new cRefRecord AddNewUIRecord()
		{	
			return (cRefRecord)base.AddNewUIRecord();
		}
		public new cRefRecord NewUIRecord()
		{	
			return (cRefRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class cRefRecord : UIRecord
	{
		#region Constructor
		public cRefRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private cRefView uiviewcRef
		{
			get { return (cRefView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldID);
			}
			set{
				this[this.uiviewcRef.FieldID] = value;
			}
		}
		
		
		public  String Coding
		{
			get{
				//object value = this[this.uiviewcRef.FieldCoding] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCoding);
			}
			set{
				this[this.uiviewcRef.FieldCoding] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldName);
			}
			set{
				this[this.uiviewcRef.FieldName] = value;
			}
		}
		
		
		public  Int32 PriceTypeEnum
		{
			get{
				//object value = this[this.uiviewcRef.FieldPriceTypeEnum] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewcRef.FieldPriceTypeEnum);
			}
			set{
				this[this.uiviewcRef.FieldPriceTypeEnum] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@" order by Coding desc")
		{
			InitClass();
		}
		//for Clone Constructor
		private cRefDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new cRefDefaultFilterFilter();
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
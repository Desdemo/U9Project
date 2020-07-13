#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.BLT.ShipPlan.LogisticsConstsUI
{
	[Serializable]
	public partial class LogisticsConstsBListUIModelModel : UIModel
	{
		#region Constructor
		public LogisticsConstsBListUIModelModel() : base("LogisticsConstsBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("205bb11a-ce29-4dbb-b935-c1c8cf0905d6");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LogisticsConstsBListUIModelModel(bool isInit) : base("LogisticsConstsBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LogisticsConstsBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private LogisticsCostsView viewLogisticsCosts;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public LogisticsCostsView LogisticsCosts
		{
			get { return (LogisticsCostsView)this["LogisticsCosts"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewLogisticsCosts = new LogisticsCostsView(this);
			this.viewLogisticsCosts.SetResourceInfo("8e33e2df-37fc-4198-bc7d-ce3907873fff");
			this.Views.Add(this.viewLogisticsCosts);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsConstsUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class LogisticsCostsView : UIView
	{
		#region Constructor
		public LogisticsCostsView(IUIModel model) : base(model,"LogisticsCosts","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.LogisticsCosts", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private LogisticsCostsView():base(null,"LogisticsCosts","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.LogisticsCosts", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new LogisticsCostsView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public LogisticsCostsDefaultFilterFilter DefaultFilter
		{
			get { return (LogisticsCostsDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","624f1b40-6d5f-40cf-a9e1-d7b254c4ceda");


			this.CurrentFilter = new LogisticsCostsDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new LogisticsCostsRecord(builder);
		}
		#endregion

		#region new method
		public new LogisticsCostsRecord FocusedRecord
		{
			get { return (LogisticsCostsRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new LogisticsCostsRecord AddNewUIRecord()
		{	
			return (LogisticsCostsRecord)base.AddNewUIRecord();
		}
		public new LogisticsCostsRecord NewUIRecord()
		{	
			return (LogisticsCostsRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class LogisticsCostsRecord : UIRecord
	{
		#region Constructor
		public LogisticsCostsRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private LogisticsCostsView uiviewLogisticsCosts
		{
			get { return (LogisticsCostsView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new LogisticsCostsRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewLogisticsCosts.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLogisticsCosts.FieldID);
			}
			set{
				this[this.uiviewLogisticsCosts.FieldID] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class LogisticsCostsDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public LogisticsCostsDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private LogisticsCostsDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new LogisticsCostsDefaultFilterFilter();
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
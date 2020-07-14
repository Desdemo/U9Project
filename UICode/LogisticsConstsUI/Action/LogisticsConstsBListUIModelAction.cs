/**************************************************************
 * Description:
 * LogisticsConstsBListUIModelAction.cs
 * Product: U9
 * Co.    : UFIDA Group
 * Author : Auto Generated
 * version: 2.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.IView; 
using System.Data;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFIDA.UBF.Query.CaseModel;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.ExportService;

namespace UFIDA.U9.Cust.BLT.ShipPlan.LogisticsConstsUI
{
	public partial class LogisticsConstsBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LogisticsConstsBListUIModelAction));
		//强类型化基类Model属性.
		public new LogisticsConstsBListUIModelModel CurrentModel 
		{
			get {
				return (LogisticsConstsBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public LogisticsConstsBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public LogisticsConstsBListUIModelAction(LogisticsConstsBListUIModelModel model) : base(model)
		{
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnLookCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnLookCase_Extend);
		}
		private void OnLookCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:QryClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("QryClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnCaseChanged(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnCaseChanged_Extend);
		}
		private void OnCaseChanged_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	        QryService.OnCaseChangedDefault("DDLCase", this.CurrentPart);
		QueryAdjust();
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnOutPut(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnOutPut_Extend);
		}
		private void OnOutPut_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnOutPut
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnOutPut",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnGridRowDbClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnGridRowDbClick_Extend);
		}
		private void OnGridRowDbClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnNew(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnNew_Extend);
		}
		private void OnNew_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnPrint(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnPrint_Extend);
		}
		private void OnPrint_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnPrint
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnPrint",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnDelete(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnDelete_Extend);
		}
		private void OnDelete_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:ListDeleteClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ListDeleteClick",this,sender,e);

	  
		}
		#region Action的内置两个Action.
		/// <summary>
		/// Help: 数据加载(发生在Form的初始化加载时)
		/// </summary>
		public void OnLoadData(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnLoadData_Extend(sender,e) ;
		}
		private void OnLoadData_DefaultImpl(object sender, UIActionEventArgs e)
		{
		   
		     InitCaseModel();
				}
		/// <summary>
		/// Help: 数据收集(发生在Form的CallBack或者是PostBack时)
		/// </summary>
		public void OnDataCollect(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnDataCollect_Extend(sender,e) ;
		}
		private void OnDataCollect_DefaultImpl(object sender, UIActionEventArgs e)
		{
		    UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DataCollect",this,sender,e);
		}
		#endregion
         

            
        #region BE列表自动产生的代码
        
		public void QueryAdjust()
		{
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.LogisticsCosts", "a52d789a-109a-418f-94c3-050bb23d5c2c", UIGrid.UIView, UIGrid, 1);

			beQryStrategyImpl.Adjust();
		    
			AfterQryAdjust_Extend(UIGrid);

			UIGrid.UIView.CurrentFilter.OPath = CustomFilterOpath_Extend(QryService.GetDefaultOpath((BaseWebForm)(this.CurrentPart)));
			UIGrid.UIView.CurrentFilter.OrderBy = QryService.GetOrderByOpath((BaseWebForm)(this.CurrentPart));

			UIGrid.UIView.Clear();
			this.NavigateAction.FirstPage(null);

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
		}

		public void InitCaseModel()
		{
			QryService.ClearSession((UFSoft.UBF.UI.FormProcess.BaseWebForm)(this.CurrentPart));
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.LogisticsCosts", "a52d789a-109a-418f-94c3-050bb23d5c2c", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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
OPl765f/6tqfX39+fZvX/wM=";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}

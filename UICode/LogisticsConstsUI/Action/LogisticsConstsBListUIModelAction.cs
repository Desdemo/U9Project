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
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}

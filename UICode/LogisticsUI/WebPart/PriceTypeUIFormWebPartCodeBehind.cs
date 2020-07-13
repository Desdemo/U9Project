using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;
using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Globalization;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.Business;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI;
using System.Collections.Generic;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI
{
    public partial class PriceTypeUIFormWebPart
    {
        #region eventBind
		 
				//MethodName:BtnNew_Click ActionName:NewClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnNew_Click(object sender, EventArgs e)
        {
			//新增事件不进行数据收集，如果数据改变，Client端提示直接触发Save操作.


			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnNew_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnNew_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:NewClick

	
		Action.NewClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnDelete_Click ActionName:DeleteClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnDelete_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnDelete_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnDelete_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:DeleteClick

	
		Action.DeleteClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnOutPut_Click ActionName:OutputClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnOutPut_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnOutPut_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnOutPut_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:OutputClick

	
		Action.OutputClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnPrint_Click ActionName:PrintClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnPrint_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnPrint_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnPrint_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:PrintClick

	
		Action.PrintClick(sender,new UIActionEventArgs());

		
			
        }
		 

			

		//MethodName:DDLCase_TextChanged ActionName:OnCaseChanged
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void DDLCase_TextChanged(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,DDLCase_TextChanged_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void DDLCase_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

		
			Action.OnCaseChanged(sender,new UIActionEventArgs());
	 

		
			
        }
		 
				//MethodName:OnLookCase_Click ActionName:OnLookCase
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void OnLookCase_Click(object sender, EventArgs e)
        {
					

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,OnLookCase_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void OnLookCase_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.OnLookCase(sender,new UIActionEventArgs());

		
			
        }
		 
			
				

		//MethodName:DataGrid1_GridRowDbClicked ActionName:OnGridRowDbClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void DataGrid1_GridRowDbClicked(object sender, GridDBClickEventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					try
			{				
				DataGrid1_GridRowDbClicked_Extend(sender,e) ;			
			}
			catch(Exception ex)
			{
				if (UFSoft.UBF.Exceptions.ExceptionHelper.IsUnknownException(ex, true)) {
                    throw;
                }
                IUIModel model = this.Model;
				this.Model.ErrorMessage.SetErrorMessage(ref model,ex);
			}
	
			
        }

        //default implement by tpl ...
        private void DataGrid1_GridRowDbClicked_DefaultImpl(object sender, GridDBClickEventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

		
			Action.OnGridRowDbClick(sender,new UIActionEventArgs());
	 

		
			
        }
		#region  数据初始化加载和数据收集方法
		public void OnLoadData(object sender)
		{	
		    try
			{
			    OnLoadData_Extend(sender) ;
			}
			catch(Exception ex)
			{
				if (UFSoft.UBF.Exceptions.ExceptionHelper.IsUnknownException(ex, true)) {
                    throw;
                }
                IUIModel model = this.Model;
				this.Model.ErrorMessage.SetErrorMessage(ref model,ex);
			}			
		}		
		public void OnLoadData_DefaultImpl(object sender)
		{
			Action.OnLoadData(sender,new UIActionEventArgs());
		}
		
		public override void OnDataCollect(object sender)
		{
			try
			{
			    adjust.ProcessAdjustBeforeDataCollect(this);
			    OnDataCollect_Extend(sender);
			    adjust.ProcessAdjustAfterDataCollect(this);
			}
			catch(Exception ex)
			{
				if (UFSoft.UBF.Exceptions.ExceptionHelper.IsUnknownException(ex, true)) {
                    throw;
                }
                IUIModel model = this.Model;
				this.Model.ErrorMessage.SetErrorMessage(ref model,ex);
			}
		}
		private void OnDataCollect_DefaultImpl(object sender)
		{
			Action.OnDataCollect(sender,new UIActionEventArgs());			
		}

		#endregion 
		
        #region Grid控件DataGrid5的分页事件	
        void UFGridDataGrid5_GridMakePageEventHandler(Object sender, GridMakePageEventArgs  e)
        {
            //Grid的首页、下页、上页、末页处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridMakePage",this.Action,this.DataGrid5,e);
        }
        #endregion

        #region Grid控件DataGrid5的客户化筛选事件	
        void UFGridDataGrid5_GridCustomFilterHandler(Object sender, GridCustomFilterArgs  e)
        {
            //Grid的客户化筛选，首条、上一条、下一条、末条处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridCustomFilter",this.Action,this.DataGrid5,e);
        }
        #endregion

        #endregion
        
    }
}
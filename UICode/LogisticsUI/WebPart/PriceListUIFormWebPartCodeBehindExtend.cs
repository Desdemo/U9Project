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
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using UFSoft.UBF.UI.FormProcess;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.WebControls.Association;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI
{
    public partial class PriceListUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnSave_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCancel_Click...
		private void BtnCancel_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCancel_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAdd_Click...
		private void BtnAdd_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAdd_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnDelete_Click...
		private void BtnDelete_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnDelete_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCopy_Click...
		private void BtnCopy_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCopy_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnSubmit_Click...
		private void BtnSubmit_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnSubmit_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnApprove_Click...
		private void BtnApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnApprove_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFind_Click...
		private void BtnFind_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFind_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnList_Click...
		private void BtnList_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnList_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFirstPage_Click...
		private void BtnFirstPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFirstPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrevPage_Click...
		private void BtnPrevPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrevPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnNextPage_Click...
		private void BtnNextPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnNextPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnLastPage_Click...
		private void BtnLastPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnLastPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAttachment_Click...
		private void BtnAttachment_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAttachment_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFlow_Click...
		private void BtnFlow_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFlow_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOutput_Click...
		private void BtnOutput_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOutput_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrint_Click...
		private void BtnPrint_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrint_Click_DefaultImpl(sender,e);
		}

		
            
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
			OnLoadData_DefaultImpl(sender);
		}
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{

		}

        public void AfterCreateChildControls()
        {

			//开启个性化        
			UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((BaseWebForm)this, true);
			//查询按钮设置
			PDFormMessage.ShowConfirmDialog(this.Page, "82a5e4be-43af-449e-b8a8-b247f4df486a", "580", "408",
				Title, wpFindID.ClientID, this.BtnFind, null);
			//取得提示信息资源：是否删除当前记录
			string message = PDResource.GetDeleteConfirmInfo();
			//绑定注册弹出对话框到删除按钮
			PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
			PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);

			AllotPriceChangedCallBack();
			AllotDynamicPriceChangedCallBack();

			// 复制行
			AutoCopyRow();
		}

		private void AutoCopyRow()
		{
			this.DataGrid5.AllowCopyRow = true;
		}

		private void AllotPriceChangedCallBack()
		{
			AssociationControl gridCellDataChangedASC = new AssociationControl();       //基本固定代码
			gridCellDataChangedASC.SourceServerControl = this.DataGrid5;
			gridCellDataChangedASC.SourceControl.EventName = "OnCellDataChanged";


			//CallBack处理方案
			((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("Price");
			//((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("DynamicPrice");

			ClientCallBackFrm gridCellDataChangedCBF = new ClientCallBackFrm();
			gridCellDataChangedCBF.ParameterControls.Add(this.DataGrid5);

			gridCellDataChangedCBF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(AllotPriceChange);
			gridCellDataChangedCBF.Add(gridCellDataChangedASC);
			this.Controls.Add(gridCellDataChangedCBF);

		}
		///<summary>
		/// 表格的CallBack处理方式，返回结果
		///</summary>
		///<param name="args"></param>
		///<returns></returns>
		private object AllotPriceChange(CustomerActionEventArgs args)
		{
			this.Model.PriceList.ClearErrorMessage();
			UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid5);

			//取表格数据（当前行）
			ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows]; //基本固定代码
			int curIndex = int.Parse(list[0].ToString());
			Hashtable table = (Hashtable)((ArrayList)args.ArgsHash[this.DataGrid5.ClientID])[curIndex];


			
			
			decimal Price = decimal.Parse(table["Price"].ToString()); //开始
			decimal DynamicPrice = decimal.Parse(table["DynamicPrice"].ToString()); //开始

			if (Price > 0)
			{
				// 合计
				DynamicPrice = 0;
				grid.CellValue.Add(new object[] { curIndex, "DynamicPrice", new string[] { DynamicPrice.ToString(), DynamicPrice.ToString(), DynamicPrice.ToString() } });
				args.ArgsResult.Add(grid.ClientInstanceWithValue);

			}
			
			//合计
			//grid.CellValue.Add(new object[] { curIndex, "LineTotal", new string[] { LineTotal.ToString(), LineTotal.ToString(), LineTotal.ToString() } });
			//args.ArgsResult.Add(grid.ClientInstanceWithValue);
			return args;

		}

		private void AllotDynamicPriceChangedCallBack()
		{
			AssociationControl gridCellDataChangedASC = new AssociationControl();       //基本固定代码
			gridCellDataChangedASC.SourceServerControl = this.DataGrid5;
			gridCellDataChangedASC.SourceControl.EventName = "OnCellDataChanged";


			//CallBack处理方案
			//((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("Price");
			((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("DynamicPrice");

			ClientCallBackFrm gridCellDataChangedCBF = new ClientCallBackFrm();
			gridCellDataChangedCBF.ParameterControls.Add(this.DataGrid5);

			gridCellDataChangedCBF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(AllotDynamicPriceChange);
			gridCellDataChangedCBF.Add(gridCellDataChangedASC);
			this.Controls.Add(gridCellDataChangedCBF);

		}
		///<summary>
		/// 表格的CallBack处理方式，返回结果
		///</summary>
		///<param name="args"></param>
		///<returns></returns>
		private object AllotDynamicPriceChange(CustomerActionEventArgs args)
		{
			this.Model.PriceList.ClearErrorMessage();
			UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid5);

			//取表格数据（当前行）
			ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows]; //基本固定代码
			int curIndex = int.Parse(list[0].ToString());
			Hashtable table = (Hashtable)((ArrayList)args.ArgsHash[this.DataGrid5.ClientID])[curIndex];




			decimal Price = decimal.Parse(table["Price"].ToString()); //开始
			decimal DynamicPrice = decimal.Parse(table["DynamicPrice"].ToString()); //开始

			//if (Price > 0)
			//{
			//	// 合计
			//	DynamicPrice = 0;
			//	grid.CellValue.Add(new object[] { curIndex, "DynamicPrice", new string[] { DynamicPrice.ToString(), DynamicPrice.ToString(), DynamicPrice.ToString() } });
			//	args.ArgsResult.Add(grid.ClientInstanceWithValue);

			//}
			if (DynamicPrice > -1)
			{
				Price = 0;
				grid.CellValue.Add(new object[] { curIndex, "Price", new string[] { Price.ToString(), Price.ToString(), Price.ToString() } });
				args.ArgsResult.Add(grid.ClientInstanceWithValue);
			}

			//合计
			//grid.CellValue.Add(new object[] { curIndex, "LineTotal", new string[] { LineTotal.ToString(), LineTotal.ToString(), LineTotal.ToString() } });
			//args.ArgsResult.Add(grid.ClientInstanceWithValue);
			return args;

		}


		public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{

		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}
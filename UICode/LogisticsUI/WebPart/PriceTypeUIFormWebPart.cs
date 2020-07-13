


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:a86392be-694b-4604-8b69-560707974255 
 * Form Name:PriceTypeUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI
{
	[FormRegister("UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.PriceTypeUIFormWebPart", "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart", "a86392be-694b-4604-8b69-560707974255","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI', 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.PriceTypeUIFormWebPart', 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart', 'a86392be-694b-4604-8b69-560707974255')
	///<siteMapNode url="~/erp/simple.aspx?lnk=a86392be-694b-4604-8b69-560707974255" title="PriceTypeUIForm"/>
    public partial class PriceTypeUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(PriceTypeUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new PriceTypeUIModelAction Action
		{
			get { return (PriceTypeUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		PriceTypeUIModelModel _uimodel=null;
		public new PriceTypeUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new PriceTypeUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as PriceTypeUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFButton BtnCancel;
        IUFButton BtnAdd;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFButton BtnCopy;
        IUFSeparator Separator1;
        IUFButton BtnSubmit;
        IUFButton BtnApprove;
        IUFButton BtnUndoApprove;
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFButton BtnFlow;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFDropDownButton DDBtnOperation;
        IUFDropDownButton DDBtnActivity;
        IUFDropDownButton DDBtnQuery;
        IUFDropDownButton DDBtnTaskLink;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFDropDownButton DropDownButton11;
        IUFDropDownButton DropDownButton13;
        IUFDropDownButton DropDownButton15;
        IUFDropDownButton DropDownButton12;
        IUFCard Card4;
        IUFCard Card2;
        IUFLabel lblID47;
        IUFFldNumberControl ID47;
        IUFLabel lblSysVersion71;
        IUFFldNumberControl SysVersion71;
        IUFLabel lblCoding143;
        IUFFldTextBox Coding143;
        IUFLabel lblName173;
        IUFFldTextBox Name173;
        IUFLabel lblCurrency167;
        IUFFldReference Currency167;
        IUFLabel lblUom248;
        IUFFldReference Uom248;
        IUFLabel lblPriceTypeEnum647;
        IUFFldDropDownList PriceTypeEnum647;
        IUFLabel lblRemark287;
        IUFFldTextBox Remark287;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public PriceTypeUIFormWebPart()
        {
            FormID = "a86392be-694b-4604-8b69-560707974255";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnSave.Click += new EventHandler(BtnSave_Click);		
						
				//Button控件事件
			this.BtnCancel.Click += new EventHandler(BtnCancel_Click);		
						
				//Button控件事件
			this.BtnAdd.Click += new EventHandler(BtnAdd_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnCopy.Click += new EventHandler(BtnCopy_Click);		
						
				//Button控件事件
			this.BtnSubmit.Click += new EventHandler(BtnSubmit_Click);		
						
				//Button控件事件
			this.BtnApprove.Click += new EventHandler(BtnApprove_Click);		
						
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
				//Button控件事件
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						
				//Button控件事件
			this.FindButton.Click += new EventHandler(FindButton_Click);		
						
				//Button控件事件
			this.QryButton.Click += new EventHandler(QryButton_Click);		
						
							
				//Button控件事件
			this.CancelButton.Click += new EventHandler(CancelButton_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid5).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid5_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid5).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid5_GridCustomFilterHandler);

            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new PriceTypeUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (PriceTypeUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
				//BtnFind对应隐藏域的数据传递。:True
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.BindingBtnFindParam(this);
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new PriceTypeUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"PriceTypeUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","667858a8-f60a-4dd4-b969-fb1358074469");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","411f8641-d983-4aeb-baed-91e090361157");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","54e5afa8-8af1-46fd-8be7-2030d3a42397");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","e2fab9d5-ed20-4f2d-9a18-a9fe2fec459f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","a077fef0-1973-434f-a1ef-7f64843499e5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","9615e5ec-0fb6-4b1e-b8b6-999b642ec6e1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","9db6b9c1-07ba-494c-8656-dc3f3b947a2e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","06d7977b-eeff-48e1-a2ba-0be06983c170");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","76fa51a0-268d-4259-822d-b0d7a299cd41");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","a21e2736-9965-488b-986c-c0864929386a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","19f0462c-5814-46cf-b972-fc91b7851324");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","d283f9d8-eafd-4c16-b78a-fa3aaf7f779f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","c29ef334-c1e1-43cd-9dbe-756f5cc8add5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","e8ed4aa0-d7b7-4398-b97b-8c17aecf3495");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","1f46dc97-5260-49ea-89c2-6ef3bb14fbfa");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","4a89301e-37db-4f57-812e-c704a9dc497d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","d426098f-7fd8-44a9-8536-6e49f296b4c9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","9f41a0bf-57c5-4db9-a98f-1e4fdabd80d5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","bb3dd804-869a-4b97-bbef-173285a72ac4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DDBtnOperation(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnOperation, "1");		


	
			_BuilderControl_DDBtnActivity(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnActivity, "2");		


	
			_BuilderControl_DDBtnQuery(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnQuery, "3");		


	
			_BuilderControl_DDBtnTaskLink(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnTaskLink, "8");		


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 18, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","dc894455-0a1a-4380-a077-807b4d74843a");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 20, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","0747a6c0-2f95-4058-8724-536eec13f300");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "10");		


	
			_BuilderControl_DropDownButton11(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton11, "5");		


	
			_BuilderControl_DropDownButton13(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton13, "6");		


	
			_BuilderControl_DropDownButton15(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton15, "7");		


	
			_BuilderControl_DropDownButton12(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton12, "4");		



										

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				       
        private void _BuilderControl_DDBtnOperation(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnOperation",true, true,"1"
            , 80, 20, 0, 0, 1, 1, "100","c4e31736-3819-479a-9f0a-2a306ba44bec","968a8019-0a97-4cb2-9d52-30778d322bb3");
            this.DDBtnOperation = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnActivity(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnActivity",true, true,"2"
            , 80, 20, 2, 0, 1, 1, "100","d24eab78-82b5-4f55-aa4a-f1c85a2c0489","fb8bdb04-d7cf-4a5e-b10b-65099b335f20");
            this.DDBtnActivity = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnQuery(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnQuery",true, true,"3"
            , 80, 20, 4, 0, 1, 1, "100","61a151e6-462e-4392-b264-c988ddd844b8","f7578b02-6660-4e02-a8d4-1cb4ba66c702");
            this.DDBtnQuery = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnTaskLink(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnTaskLink",true, true,"8"
            , 80, 20, 14, 0, 1, 1, "100","e9b85406-d7e2-41f5-94da-49a69f06327c","ae6ff23a-6ffa-4108-852c-f1439b770aae");
            this.DDBtnTaskLink = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton11(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton11",true, true,"5"
            , 80, 20, 8, 0, 1, 1, "100","","43f858ec-0e3f-4757-b776-0adf768b764d");
            this.DropDownButton11 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton13(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton13",true, true,"6"
            , 80, 20, 10, 0, 1, 1, "100","","1892e27d-6b66-4c61-b98d-27f1e2a01d5d");
            this.DropDownButton13 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton15(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton15",true, true,"7"
            , 80, 20, 12, 0, 1, 1, "100","","61a8d4be-bb67-4887-b914-296b22bd6c41");
            this.DropDownButton15 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton12(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton12",true, true,"4"
            , 80, 20, 6, 0, 1, 1, "100","","c3b6de1c-7e7d-4bf6-b0f5-83c6ccb9a82b");
            this.DropDownButton12 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","f94817fc-1f68-459d-9cbb-ce597f1b1742");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(72,bool.Parse("True")),new GridRowDef(328,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_Card2(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "1");		


	
			_BuilderControl_DataGrid5(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid5, "2");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","7eec2b7d-b871-4cf2-88d8-ef5f0c631f8a","a468ea5b-5b69-4f86-8943-cb194edfc7fa");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.PriceType, "PriceType", "", null, 1, "计价类型");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID47 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID47", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","7eec2b7d-b871-4cf2-88d8-ef5f0c631f8a","8941024d-3049-4839-96ec-6c6d557b7533");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID47, "0");		


				this.ID47 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID47", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID47","19.0","7eec2b7d-b871-4cf2-88d8-ef5f0c631f8a","2fa07425-b434-4292-a234-ec9a8377b1d1",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID47, "False", "ID", this.Model.PriceType, this.Model.PriceType.FieldID, "PriceType");
	
		
			UIControlBuilder.BuilderUFControl(this.ID47, "1");		
		 

				this.lblSysVersion71 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion71", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","fdb23c5d-a89b-4be7-8e42-0fac81bb36c5","3ce58b35-94ce-4768-a8c1-a462e2fdd22d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion71, "2");		


				this.SysVersion71 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion71", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion71","19.0","fdb23c5d-a89b-4be7-8e42-0fac81bb36c5","b843e3e8-ed0b-4d95-b657-d9f0ee96adb6",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion71, "False", "SysVersion", this.Model.PriceType, this.Model.PriceType.FieldSysVersion, "PriceType");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion71, "3");		
		 

				this.lblCoding143 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCoding143", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","70928766-da98-4e18-8c94-d029714593a6","bb24851f-e5fa-43e4-89a3-dbffdf209449");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCoding143, "4");		


				this.Coding143 = UIControlBuilder.BuilderTextBox(_UFCard, "Coding143", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCoding143","","50","70928766-da98-4e18-8c94-d029714593a6","00434c2b-524a-4b3f-aa40-d3a7105ac92e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Coding143, "False", "Coding", this.Model.PriceType, this.Model.PriceType.FieldCoding, "PriceType");


		
			UIControlBuilder.BuilderUFControl(this.Coding143, "5");		
		 

				this.lblName173 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblName173", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","0f06fcbe-7c38-484f-afdc-fe41235f502a","a99c0b7e-e1df-4716-bcd6-770a9b1ac7c2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName173, "6");		


				this.Name173 = UIControlBuilder.BuilderTextBox(_UFCard, "Name173", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName173","","50","0f06fcbe-7c38-484f-afdc-fe41235f502a","61087604-ce87-4cae-a33a-80affe3e1ba9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name173, "False", "Name", this.Model.PriceType, this.Model.PriceType.FieldName, "PriceType");


		
			UIControlBuilder.BuilderUFControl(this.Name173, "7");		
		 

				this.lblCurrency167 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCurrency167", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","b0416bc9-3fc1-4e4c-bdf1-d284050a7ce6","400d5495-13a1-4fa9-8f8e-0e98277cac5c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCurrency167, "8");		


				this.Currency167 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Currency167",false,true, true,153, 20, 2, 2, 1, 1, "100","9",false,false,true,"lblCurrency167","b0416bc9-3fc1-4e4c-bdf1-d284050a7ce6","08041973-6d20-4bcd-9b9e-4dd1940b8106");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Currency167, "False", "Currency", this.Model.PriceType, this.Model.PriceType.FieldCurrency, "PriceType");
			UIControlBuilder.SetReferenceControlRefInfo(this.Currency167,"27f276ae-3cd1-49bc-9e3b-2f3b938bc4d0", 580,408, "Name","Code","ID", this.Model.PriceType.FieldCurrency_Code,this.Model.PriceType.FieldCurrency_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Currency167,"Currency167",new ReferenceInputParam[]{new ReferenceInputParam("DateTime1","","","",1),new ReferenceInputParam("DateTime2","","","",1),});
 			//for personal
		 				 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Currency167,"Currency167",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","ISOCode",""),new ReferenceOutputParam("","Symbol",""),new ReferenceOutputParam("","PriceRound_Precision",""),new ReferenceOutputParam("","PriceRound_RoundType",""),new ReferenceOutputParam("","PriceRound_RoundValue",""),new ReferenceOutputParam("","MoneyRound_Precision",""),new ReferenceOutputParam("","MoneyRound_RoundType",""),new ReferenceOutputParam("","MoneyRound_RoundValue",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Currency167, "9");		
		 

				this.lblUom248 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblUom248", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","9802c413-3a08-4f5b-8821-3f99755820ec","1fdfda6c-2f0e-41f0-ac36-2be7f5a0ba2f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblUom248, "10");		


				this.Uom248 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Uom248",false,true, true,152, 20, 6, 0, 1, 1, "100","11",false,false,true,"lblUom248","9802c413-3a08-4f5b-8821-3f99755820ec","63e6bfec-6742-4e4d-a2d3-6011ff11d3fb");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Uom248, "False", "Uom", this.Model.PriceType, this.Model.PriceType.FieldUom, "PriceType");
			UIControlBuilder.SetReferenceControlRefInfo(this.Uom248,"2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd", 580,408, "Name","Code","ID", this.Model.PriceType.FieldUom_Code,this.Model.PriceType.FieldUom_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Uom248,"Uom248",new ReferenceInputParam[]{new ReferenceInputParam("DateTime1","","","",1),new ReferenceInputParam("DateTime2","","","",1),});
 			//for personal
		 				 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Uom248,"Uom248",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","UOMClass",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Round_Precision",""),new ReferenceOutputParam("","Round_RoundType",""),new ReferenceOutputParam("","Round_RoundValue",""),new ReferenceOutputParam("","BaseUOM_ID",""),new ReferenceOutputParam("","BaseUOM_Code",""),new ReferenceOutputParam("","BaseUOM_Name",""),new ReferenceOutputParam("","RatioToBase",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Uom248, "11");		
		 

				this.lblPriceTypeEnum647 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblPriceTypeEnum647", "", "True", "True", "Right", 152, 20, 4, 1, 1, 1, "100","73c4ab19-25d1-4896-960a-f23d872788c6","6e92ac8f-a473-4216-af0d-7fceec75149c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPriceTypeEnum647, "12");		


		        this.PriceTypeEnum647 = UIControlBuilder.BuilderDropDownList(_UFCard, "PriceTypeEnum647", "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceTypeEnum", false,  true, true, "Left", 2, 60, 0, 152, 20, 6, 1, 1, 1, "100",true,false,"lblPriceTypeEnum647","73c4ab19-25d1-4896-960a-f23d872788c6","196242e6-8ad0-44b4-9b55-710b9135686b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.PriceTypeEnum647, "False", "PriceTypeEnum", this.Model.PriceType, this.Model.PriceType.FieldPriceTypeEnum, "PriceType");
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.PriceTypeEnum");
			EnumControlsMap.Add(this.PriceTypeEnum647, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.PriceTypeEnum647, "13");		
		 

				this.lblRemark287 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblRemark287", "", "True", "True", "Right", 152, 20, 8, 0, 1, 1, "100","3b5d9295-fec6-478e-9f0e-85c9d2c6ef31","d1868a1e-80a7-4977-baf7-97c4051d70ae");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRemark287, "14");		


				this.Remark287 = UIControlBuilder.BuilderTextBox(_UFCard, "Remark287", "True", "True", "True", "True", "Left", 0, 60, 0, 152, 70, 10, 0, 1, 3, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblRemark287","","50","3b5d9295-fec6-478e-9f0e-85c9d2c6ef31","bc957ca0-efbc-43c6-a81d-073c3ad10bdc");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Remark287, "False", "Remark", this.Model.PriceType, this.Model.PriceType.FieldRemark, "PriceType");


		
			UIControlBuilder.BuilderUFControl(this.Remark287, "15");		
		 


										
			this.Currency167.IsMultiOrg  = false ;
			this.lblCurrency167.SetMultiOrgInfo(this.Currency167,false);
			
		
			this.Uom248.IsMultiOrg  = false ;
			this.lblUom248.SetMultiOrgInfo(this.Uom248,false);
			
				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 339, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.PriceType_PriceTypeLine, "PriceType_PriceTypeLine", "", null, 20, "计价类型.Misc.计价类型行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID48","NumberColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","06c76786-b39b-4686-a4c9-5b96c17ed072","06c76786-b39b-4686-a4c9-5b96c17ed072","1e82b60b-264b-4587-a465-cd12d8bc33f5");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion72","NumberColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","ae2465c2-66a3-4551-8df0-00cc79cf38ff","ae2465c2-66a3-4551-8df0-00cc79cf38ff","42b12a12-bfec-4619-b5a9-ec300559194d");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SerialNumber0","NumberColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["SerialNumber"]/*SerialNumber*/,"SerialNumber", false, true, false, false, false, false, 2, 100, "10.0",true, false,"0","65a14ea2-2ff2-4232-a7d4-80a6070de175","65a14ea2-2ff2-4232-a7d4-80a6070de175","707a4c1c-867b-49ad-bd00-f47aa85ebdf2");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",true,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PriceType_Name0","TextBoxColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["PriceType_Name"]/*PriceType_Name*/,"PriceType_Name", false, true, true, false, false, false, 0, 100, "50",true, false,"","f639eb7a-bcc9-4c2c-a15f-e98cabdd9497","f639eb7a-bcc9-4c2c-a15f-e98cabdd9497","f6e8e35c-2b25-440c-8b43-2df7d91b6a3a");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UnitPrice0","NumberColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["UnitPrice"]/*UnitPrice*/,"UnitPrice", false, true, true, false, false, false, 11, 100, "53.0",true, false,"0","9eaee70e-0126-4ec7-8c9d-ebca83efec02","9eaee70e-0126-4ec7-8c9d-ebca83efec02","1833f4cf-d5b9-45d4-96c1-7c55b1930e35");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Start0","NumberColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["Start"]/*Start*/,"Start", false, true, true, false, false, false, 2, 100, "10.0",true, false,"0","4fd9c896-22ce-4d9b-a239-101e2e2d046f","4fd9c896-22ce-4d9b-a239-101e2e2d046f","14674a21-a5bb-4aef-8e39-7d6d7b96b07b");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Cutoff0","NumberColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["Cutoff"]/*Cutoff*/,"Cutoff", false, true, true, false, false, false, 2, 100, "10.0",true, false,"0","4aa50aa9-9df1-40c0-a9ae-011be5a21be7","4aa50aa9-9df1-40c0-a9ae-011be5a21be7","331a0534-55f0-4dd6-9011-e85cf0f8c76d");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"LineTotal0","NumberColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["LineTotal"]/*LineTotal*/,"LineTotal", false, true, false, false, false, false, 2, 100, "10.0",true, false,"0","1642a902-9494-41bd-b6e7-42001aad2907","1642a902-9494-41bd-b6e7-42001aad2907","6a61af83-b05e-470e-8e92-b5b0bb75cf03");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Remark288","TextBoxColumnModel", "", 0,this.Model.PriceType_PriceTypeLine.Fields["Remark"]/*Remark*/,"Remark", false, true, true, false, false, true, 0, 100, "50",true, false,"","3da9bff5-8328-4aa4-bd27-c910a8f723ed","3da9bff5-8328-4aa4-bd27-c910a8f723ed","41c7230d-5516-4e27-aa65-82544f5def8f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}

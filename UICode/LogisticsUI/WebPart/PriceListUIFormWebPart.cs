


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
 * Form ID:6b6d8fa6-b739-47d2-9422-2ebc6b42166f 
 * Form Name:PriceListUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI
{
	[FormRegister("UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI","UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.PriceListUIFormWebPart", "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart", "6b6d8fa6-b739-47d2-9422-2ebc6b42166f","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI', 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.PriceListUIFormWebPart', 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart', '6b6d8fa6-b739-47d2-9422-2ebc6b42166f')
	///<siteMapNode url="~/erp/simple.aspx?lnk=6b6d8fa6-b739-47d2-9422-2ebc6b42166f" title="PriceListUIForm"/>
    public partial class PriceListUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(PriceListUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new PriceListUIModelAction Action
		{
			get { return (PriceListUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		PriceListUIModelModel _uimodel=null;
		public new PriceListUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new PriceListUIModelModel();
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
                this.Model = value as PriceListUIModelModel;
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
        IUFLabel lblID38;
        IUFFldNumberControl ID38;
        IUFLabel lblSysVersion65;
        IUFFldNumberControl SysVersion65;
        IUFLabel lblDocNo68;
        IUFFldTextBox DocNo68;
        IUFLabel lblName62;
        IUFFldTextBox Name62;
        IUFLabel lblSupplier74;
        IUFFldReference Supplier74;
        IUFLabel lblCurrency134;
        IUFFldReference Currency134;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public PriceListUIFormWebPart()
        {
            FormID = "6b6d8fa6-b739-47d2-9422-2ebc6b42166f";
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
					this.Model = new PriceListUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (PriceListUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new PriceListUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"PriceListUIForm",true,992,504);
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
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","dbbe23cb-199f-453f-a6de-6117cdef5ea7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","52b8f5e7-d756-4b2b-aa16-dd721c9abced");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","a81860a4-4e45-4838-bc49-735223ced391");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","e900bb5b-3db5-4923-a45f-cfb967488f44");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","a06ef38b-d2dc-4a7e-a748-538b1b5c618e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","ac2c7f88-2ffc-4268-90ff-0a74925bd50a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","3aa2e263-2549-4900-979a-463c0332e0b5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","569123b2-a18c-4f33-bb90-ec4bdf25daf7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","73dea567-7406-43b7-b2d4-d94fc5e78277");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","18d63d1d-ddf1-4dfe-a821-7e6e0ad6e4fe");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","aaee7902-8191-4415-a2e6-dc6d55995215");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","22bee12b-edd1-47d5-b5e4-2252595a0ba9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","62c73f53-c297-49d0-aeaf-b66aeaec3635");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","c66692d0-b841-463a-8567-a9b3e7dbf83f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","ad490d84-0b60-4c2d-bd8d-9547ef31303d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","647f0e37-9c90-4b91-806d-ef0a2b77afa8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","c34d838d-c055-4458-ab1e-c97955a1c530");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","e12f0558-ccd0-4eb2-baed-9c2be99cc5e4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","d6200eb1-6b83-4cfc-af1d-70e6bc571bc0");
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


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 18, 0, 1, 1, "100","", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","3967774d-32cd-4990-a667-ac07495826f0");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 20, 0, 1, 1, "100","", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","787f2d7a-856f-49bd-b7be-d421bd52c297");
	

		
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
            , 80, 20, 0, 0, 1, 1, "100","c4e31736-3819-479a-9f0a-2a306ba44bec","0f7ab24e-b974-44da-97a2-94fe2b2e7f10");
            this.DDBtnOperation = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnActivity(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnActivity",true, true,"2"
            , 80, 20, 2, 0, 1, 1, "100","d24eab78-82b5-4f55-aa4a-f1c85a2c0489","e7bb5bfc-6b45-43e0-b6e5-9a7d0e44da92");
            this.DDBtnActivity = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnQuery(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnQuery",true, true,"3"
            , 80, 20, 4, 0, 1, 1, "100","61a151e6-462e-4392-b264-c988ddd844b8","ab8e38e1-cc12-4a53-b1d7-ef0313979001");
            this.DDBtnQuery = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DDBtnTaskLink(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnTaskLink",true, true,"8"
            , 80, 20, 14, 0, 1, 1, "100","e9b85406-d7e2-41f5-94da-49a69f06327c","93ef7dbe-a7fa-4ee6-8e5b-ba62049b4735");
            this.DDBtnTaskLink = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton11(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton11",true, true,"5"
            , 80, 20, 8, 0, 1, 1, "100","","2ee0a33f-3086-4096-9297-59bfdf39d282");
            this.DropDownButton11 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton13(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton13",true, true,"6"
            , 80, 20, 10, 0, 1, 1, "100","","5bd5332b-028c-49cd-a20d-47e968136b5b");
            this.DropDownButton13 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton15(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton15",true, true,"7"
            , 80, 20, 12, 0, 1, 1, "100","","9ff0dd26-798b-4c7e-9b76-810a331e7435");
            this.DropDownButton15 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

				       
        private void _BuilderControl_DropDownButton12(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton12",true, true,"4"
            , 80, 20, 6, 0, 1, 1, "100","","a63a9fec-a023-4b66-ba94-f941552f452b");
            this.DropDownButton12 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","991babeb-2103-412b-9792-3b35139f97ee");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","496ee9e7-d45e-44ec-b098-8dbec223a59a","4e6dc205-d065-422f-ac74-004dc0cc2309");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.PriceList, "PriceList", "", null, 1, "物流价目表");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID38 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID38", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","496ee9e7-d45e-44ec-b098-8dbec223a59a","f929d6e7-04ed-41a4-998a-25721c801ade");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID38, "0");		


				this.ID38 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID38", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID38","19.0","496ee9e7-d45e-44ec-b098-8dbec223a59a","34d7ebc7-ca78-401b-a49c-f146f51e4b61",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID38, "False", "ID", this.Model.PriceList, this.Model.PriceList.FieldID, "PriceList");
	
		
			UIControlBuilder.BuilderUFControl(this.ID38, "1");		
		 

				this.lblSysVersion65 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion65", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","8ef30dab-285d-4e4a-99fa-b50a622f3766","aaee8fb0-a3d5-4739-b68a-7303bc129d4d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion65, "2");		


				this.SysVersion65 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion65", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion65","19.0","8ef30dab-285d-4e4a-99fa-b50a622f3766","76ae65d4-e1e0-4941-b3d9-fa9f3209a41f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion65, "False", "SysVersion", this.Model.PriceList, this.Model.PriceList.FieldSysVersion, "PriceList");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion65, "3");		
		 

				this.lblDocNo68 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocNo68", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","73a95037-a38b-4cf0-a331-201f7141576b","5efc8de0-dc6e-456a-bad8-4c84baae50cb");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocNo68, "4");		


				this.DocNo68 = UIControlBuilder.BuilderTextBox(_UFCard, "DocNo68", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblDocNo68","","50","73a95037-a38b-4cf0-a331-201f7141576b","f1091a67-c285-48b6-97bb-147f1cdb6449");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocNo68, "False", "DocNo", this.Model.PriceList, this.Model.PriceList.FieldDocNo, "PriceList");


		
			UIControlBuilder.BuilderUFControl(this.DocNo68, "5");		
		 

				this.lblName62 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblName62", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","b348be7d-467f-4110-a7be-006244124749","5acd622e-edc3-49e4-8316-22d6357c24e3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName62, "6");		


				this.Name62 = UIControlBuilder.BuilderTextBox(_UFCard, "Name62", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName62","","50","b348be7d-467f-4110-a7be-006244124749","52dccfd7-c3f8-4482-bc46-b3fdad1650ce");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name62, "False", "Name", this.Model.PriceList, this.Model.PriceList.FieldName, "PriceList");


		
			UIControlBuilder.BuilderUFControl(this.Name62, "7");		
		 

				this.lblSupplier74 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSupplier74", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","256c2380-fa7d-4e6e-9adb-c559ae4cff95","4d67f403-7e54-402e-b811-a272364a8bfa");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSupplier74, "8");		


				this.Supplier74 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Supplier74",false,true, true,153, 20, 2, 2, 1, 1, "100","9",false,false,true,"lblSupplier74","256c2380-fa7d-4e6e-9adb-c559ae4cff95","213d2289-07e2-4966-9b18-6721c655f2d0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Supplier74, "False", "Supplier", this.Model.PriceList, this.Model.PriceList.FieldSupplier, "PriceList");
			UIControlBuilder.SetReferenceControlRefInfo(this.Supplier74,"ea01ca72-c3a4-4563-b9b9-d47c720f051c", 580,408, "Name","Code","ID", this.Model.PriceList.FieldSupplier_Code,this.Model.PriceList.FieldSupplier_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Supplier74,"Supplier74",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","Category_Name",""),new ReferenceOutputParam("","Territory_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Supplier74, "9");		
		 

				this.lblCurrency134 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCurrency134", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","cedada45-a8b8-492d-bb21-d20d17de9f97","f1a2490c-45ee-4bf9-a7e5-680758081af4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCurrency134, "10");		


				this.Currency134 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Currency134",false,true, true,152, 20, 6, 0, 1, 1, "100","11",false,false,true,"lblCurrency134","cedada45-a8b8-492d-bb21-d20d17de9f97","3e966c01-748e-4cb6-ab55-c6173faf9c81");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Currency134, "False", "Currency", this.Model.PriceList, this.Model.PriceList.FieldCurrency, "PriceList");
			UIControlBuilder.SetReferenceControlRefInfo(this.Currency134,"27f276ae-3cd1-49bc-9e3b-2f3b938bc4d0", 580,408, "Name","Code","ID", this.Model.PriceList.FieldCurrency_Code,this.Model.PriceList.FieldCurrency_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Currency134,"Currency134",new ReferenceInputParam[]{new ReferenceInputParam("DateTime1","","","",1),new ReferenceInputParam("DateTime2","","","",1),});
 			//for personal
		 				 		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Currency134,"Currency134",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","ISOCode",""),new ReferenceOutputParam("","Symbol",""),new ReferenceOutputParam("","PriceRound_Precision",""),new ReferenceOutputParam("","PriceRound_RoundType",""),new ReferenceOutputParam("","PriceRound_RoundValue",""),new ReferenceOutputParam("","MoneyRound_Precision",""),new ReferenceOutputParam("","MoneyRound_RoundType",""),new ReferenceOutputParam("","MoneyRound_RoundValue",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Currency134, "11");		
		 


										
			this.Supplier74.IsMultiOrg  = false ;
			this.lblSupplier74.SetMultiOrgInfo(this.Supplier74,false);
			
		
			this.Currency134.IsMultiOrg  = false ;
			this.lblCurrency134.SetMultiOrgInfo(this.Currency134,false);
			


            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 339, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.PriceList_PriceListLine, "PriceList_PriceListLine", "", null, 20, "物流价目表.Misc.物流价目表行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID39","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 50, "19.0",true, false,"","b569b9ed-c841-43f3-9bac-ef4c00d4b382","b569b9ed-c841-43f3-9bac-ef4c00d4b382","ae504d80-edd8-44bf-bad6-19e6dbdae40e");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion66","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","23e988b8-5e1f-453b-a562-6d1f71d27d08","23e988b8-5e1f-453b-a562-6d1f71d27d08","f6366df0-8e20-4d92-a5cc-766757f671b9");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"No0","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["No"]/*No*/,"No", false, true, false, false, false, false, 2, 100, "10.0",true, false,"0","b2f32ef9-7a2f-4f0e-a395-358f48a87b76","b2f32ef9-7a2f-4f0e-a395-358f48a87b76","7b4cbf76-ca71-4772-85ee-fd9e5061eea7");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",true,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Departure0","ReferenceColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["Departure"]/*Departure*/,"Departure", false, true, true, false, false, false, 7, 100, "19.0",true, false,"","06d2dfb0-bffa-4585-978b-78a7cffdd4a0","06d2dfb0-bffa-4585-978b-78a7cffdd4a0","5d1ea276-783d-49e7-9867-979edce810f6");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.PriceList_PriceListLine.FieldDeparture_Code/*Departure_Code*/, this.Model.PriceList_PriceListLine.FieldDeparture_Name/*Departure_Name*/, "1eff2146-d07b-4ab6-b6c4-323e5e6b5185"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "5d1ea276-783d-49e7-9867-979edce810f6";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Destination0","ReferenceColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["Destination"]/*Destination*/,"Destination", false, true, true, false, false, false, 7, 100, "19.0",true, false,"","bbfa07a5-0625-4435-8529-4c6c64eaf7bb","bbfa07a5-0625-4435-8529-4c6c64eaf7bb","0a031667-dfb0-4f89-a466-855f19782e8d");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.PriceList_PriceListLine.FieldDestination_Code/*Destination_Code*/, this.Model.PriceList_PriceListLine.FieldDestination_Name/*Destination_Name*/, "1eff2146-d07b-4ab6-b6c4-323e5e6b5185"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "0a031667-dfb0-4f89-a466-855f19782e8d";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CountBasis1","DropDownListColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["CountBasis"]/*CountBasis*/,"CountBasis", false, true, true, false, false, false, 2, 100, "10.0",true, false,"0","418a389b-3d57-4846-9365-5ca05fe15faf","418a389b-3d57-4846-9365-5ca05fe15faf","465197b6-a31e-460e-af8d-9f4cdb0f5d5b");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.ComputeBasisEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.BLT.ShipPlan.LogisticsBE.ComputeBasisEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SalesUnit0","ReferenceColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["SalesUnit"]/*SalesUnit*/,"SalesUnit", false, true, true, false, false, false, 7, 100, "19.0",true, false,"","cd5c6b3e-245b-4475-a18a-082d85f6f5b3","cd5c6b3e-245b-4475-a18a-082d85f6f5b3","51dbd720-514c-4092-9449-042945677d78");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.PriceList_PriceListLine.FieldSalesUnit_Code/*SalesUnit_Code*/, this.Model.PriceList_PriceListLine.FieldSalesUnit_Name/*SalesUnit_Name*/, "2cb04e9c-44df-44e8-b518-f1ce0ba1e2cd"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "51dbd720-514c-4092-9449-042945677d78";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							



						
            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Price0","NumberColumnModel", "", 2,this.Model.PriceList_PriceListLine.Fields["Price"]/*Price*/,"Price", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","a9c3e31b-62f8-44b0-89fe-0fcf9d6dba90","a9c3e31b-62f8-44b0-89fe-0fcf9d6dba90","7918e82b-e2de-455e-9da9-ca88d9da8648");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DynamicPrice0","ReferenceColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["DynamicPrice"]/*DynamicPrice*/,"DynamicPrice", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","2babad27-3d0f-45b4-809d-5c738c0e3c6f","2babad27-3d0f-45b4-809d-5c738c0e3c6f","1080c7f0-a9e4-463c-ac79-4f6dcac6c173");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Coding", "Name", this.Model.PriceList_PriceListLine.FieldDynamicPrice_Coding/*DynamicPrice_Coding*/, this.Model.PriceList_PriceListLine.FieldDynamicPrice_Name/*DynamicPrice_Name*/, "5089809c-f207-4346-aebe-1b12fb68b033"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "1080c7f0-a9e4-463c-ac79-4f6dcac6c173";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DeliveryPickup0","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["DeliveryPickup"]/*DeliveryPickup*/,"DeliveryPickup", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","3e3a9e0a-c9dc-457c-be5c-36ba6ce1213f","3e3a9e0a-c9dc-457c-be5c-36ba6ce1213f","f4917076-1cd7-4bb4-a72f-b191904bf1a5");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FreePickup0","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["FreePickup"]/*FreePickup*/,"FreePickup", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","2595f814-fbc0-4e8d-a67e-5d4e9e003df9","2595f814-fbc0-4e8d-a67e-5d4e9e003df9","2dbd1ba9-e1ee-445c-aac5-44789aefb2af");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DeliveryCharges0","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["DeliveryCharges"]/*DeliveryCharges*/,"DeliveryCharges", false, true, true, false, false, true, 11, 100, "53.0",true, false,"0","ca8ba677-fbf1-418e-b311-f939f540cad5","ca8ba677-fbf1-418e-b311-f939f540cad5","ba2853a5-c8f0-4900-8306-aff351a96550");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FreeDelivery0","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["FreeDelivery"]/*FreeDelivery*/,"FreeDelivery", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","a7282dc2-c24e-4598-a591-cc604b72fe9d","a7282dc2-c24e-4598-a591-cc604b72fe9d","f8a4906a-5032-41af-9575-7b064874b12b");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"TransportationTime0","NumberColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["TransportationTime"]/*TransportationTime*/,"TransportationTime", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","c475ae55-49d9-4a50-9432-d9f8a3884c54","c475ae55-49d9-4a50-9432-d9f8a3884c54","adbbf3c7-2eca-4ae9-a909-6eb4d5a921b5");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Remark0","TextBoxColumnModel", "", 0,this.Model.PriceList_PriceListLine.Fields["Remark"]/*Remark*/,"Remark", false, true, true, false, false, true, 0, 100, "50",true, false,"","089d10d1-df6b-405f-a19d-307cff7b76bd","089d10d1-df6b-405f-a19d-307cff7b76bd","60915cb4-5635-47cd-bc3b-4147fefb5fe8");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}

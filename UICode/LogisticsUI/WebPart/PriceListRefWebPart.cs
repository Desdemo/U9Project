﻿


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
 * Form ID:82a5e4be-43af-449e-b8a8-b247f4df486a 
 * Form Name:PriceListRef
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace PriceListRef
{
	[FormRegister("UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI","PriceListRef.PriceListRefWebPart", "UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart", "82a5e4be-43af-449e-b8a8-b247f4df486a","WebPart", "False", 580, 408)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI', 'PriceListRef.PriceListRefWebPart', 'UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart', '82a5e4be-43af-449e-b8a8-b247f4df486a')
	///<siteMapNode url="~/erp/simple.aspx?lnk=82a5e4be-43af-449e-b8a8-b247f4df486a" title="PriceListRef"/>
    public partial class PriceListRefWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(PriceListRefWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new PriceListRefAction Action
		{
			get { return (PriceListRefAction)base.Action; }
			set { base.Action = value; }
		}
		PriceListRefModel _uimodel=null;
		public new PriceListRefModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new PriceListRefModel();
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
                this.Model = value as PriceListRefModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card4;
        IUFLabel Label0;
        IUFFldDropDownList SelectList;
        IUFWizardControl WizardControl0;
        IUFLabel lblContinueCheckBox;
        IUFFldCheckBox ContinueCheckBox;
        IUFButton FindButton;
        IUFFldCheckBox CheckBox;
        IUFCard Card6;
        IUFCard CardForRefQueryCase;
        IUFButton QryButton;
        IUFLabel lbCase;
        IUFFldDropDownList DDLCase;
        IUFCard Card1;
        IUFButton ConfirmButton;
        IUFButton CancelButton;
        IUFDataGrid DataGrid;
        IUFRadioBoxList MatchTypeRadioBoxList;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public PriceListRefWebPart()
        {
            FormID = "82a5e4be-43af-449e-b8a8-b247f4df486a";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.FindButton.Click += new EventHandler(FindButton_Click);		
						
				//Button控件事件
			this.QryButton.Click += new EventHandler(QryButton_Click);		
						
							
				//Button控件事件
			this.ConfirmButton.Click += new EventHandler(ConfirmButton_Click);		
						
				//Button控件事件
			this.CancelButton.Click += new EventHandler(CancelButton_Click);		
						
				//Grid控件事件
			
			((UFWebDataGridAdapter)this.DataGrid).RowDoubleClick += new GridRowDBClickedDelegate(DataGrid_GridRowDbClicked);
			//((UFWebDataGridAdapter)this.DataGrid).DBClickAutoPostBack = true;
						

	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid_GridCustomFilterHandler);

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
					this.Model = new PriceListRefModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				if(this.UseQueryCase){
					UFIDA.UBF.Query.CommonService.RefQueryHelper.AfterOnLoad_Qry_DefaultImpl(this.Action);
				}
				//去除.已经移入到OnInit()中.
				//this.Model = (PriceListRefModel)this.CurrentState[this.TaskId.ToString()];
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
										
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.LocateRecordFromFocusID(this, this.DataGrid);
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
			    if(this.UseQueryCase){
					UFIDA.UBF.Query.CommonService.RefQueryHelper.AfterUIModelBinding_Qry_DefaultImpl(this.Action);
				}
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
            this.Action = new PriceListRefAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
                DialogNoPersonalization = true;
		        if(!UseQueryCase){
		            CardForRefQueryCase.Visible=false;
		            UFGrid sortGrid = this.GetUFControlByName(this.TopLevelContainer, "DataGrid") as UFGrid;
                    if (sortGrid != null)
                        sortGrid.ShowCustomFilterToolBar = false;
		        }
		        else
                {
                    UFIDA.UBF.Query.CommonService.RefQueryHelper.AfterCreateChildControls_Qry_DefaultImpl(this.Action);
                    UFIDA.U9.UI.PDHelper.PDFormMessage.ShowQryDialogForReference(this,this.QryButton);
                }
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"PriceListRef",true,580,408);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 4, 0, 5, 10, 5, 10, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 5,new GridColumnDef[]{new GridColumnDef(560,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(318,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "1");		


	
			_BuilderControl_Card6(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card6, "0");		


	
			_BuilderControl_DataGrid(_panel);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid, "2");		


	
			_BuilderControl_MatchTypeRadioBoxList(_panel);

		
			UIControlBuilder.BuilderUFControl(this.MatchTypeRadioBoxList, "6");		



				
     
			
			
            EventBind();
            AfterCreateChildControls();
            
			((UFWebButtonAdapter)ConfirmButton).IsDefaultButton = true;
        }        







	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "1","","e0eb6174-3601-474e-be0a-f8ec236d1254");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 560, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(45,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(180,bool.Parse("False")),new GridColumnDef(15,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(5,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(60,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 45, 20, 0, 0, 1, 1, "100","9bf97f14-74b9-4a4f-b2fc-d5bfb9c95e3a","3f1089e1-dfec-4533-8d2e-03148c5f5428");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "0");		


		        this.SelectList = UIControlBuilder.BuilderDropDownList(_UFCard, "SelectList", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 2, 0, 1, 1, "100",true,false,"","","b12f9c99-f807-427e-84de-16f2a68ba6e1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SelectList, "False", "", null, null, "");
			EnumControlsMap.Add(this.SelectList, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.SelectList, "1");		
		 

	
			_BuilderControl_WizardControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.WizardControl0, "2");		


				this.lblContinueCheckBox = UIControlBuilder.BuilderUFLabel(_UFCard, "lblContinueCheckBox", "", "False", "True", "Right", 80, 20, 6, 0, 1, 1, "100","0aead14b-b05a-4582-9aca-34da4f4bf7a0","af51ed4a-3029-46f2-a984-cf18e929ca62");


								

		
			UIControlBuilder.BuilderUFControl(this.lblContinueCheckBox, "3");		


				this.ContinueCheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "ContinueCheckBox", false, true, "Left", 60, 0, 30, 20, 8, 0, 1, 1, "100",true,"lblContinueCheckBox","","497ed5fd-6323-4163-90b3-245bc046751d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ContinueCheckBox, "False", "", null, null, "");
		

		
			UIControlBuilder.BuilderUFControl(this.ContinueCheckBox, "4");		
		 

				this.FindButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "FindButton", true, true, 60, 20, 10, 0, 1, 1, "100","R", this.Model.ElementID,"",false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","d8ac8613-fd8e-42b7-b6f3-eab2d399180d");
	

		
			UIControlBuilder.BuilderUFControl(this.FindButton, "4");		


				this.CheckBox = UIControlBuilder.BuilderUFCheckbox(_UFCard, "CheckBox", false, true, "Left", 60, 0, 30, 20, 0, 0, 1, 1, "100",false,"","","1a61dfd5-76e1-49d6-ba55-a61b504c64e2");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CheckBox, "False", "", null, null, "");
		

		
			UIControlBuilder.BuilderUFControl(this.CheckBox, "5");		
		 


							

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

		    private void _BuilderControl_WizardControl0(IUFContainer container)
        {
            IUFWizardControl _UFWizard = new UFWebWizardControlAdapter();
            _UFWizard.ID = "WizardControl0";
			UIControlBuilder.BuilderUFControl(_UFWizard, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFWizard, 180, 20, 4, 0, 1, 1, "100");

            ///foreach _UFWizard下的所有控件，增加到此容器
            
            this.WizardControl0 = _UFWizard;
    		_UFWizard.SetWizardPageVisible(0);
            container.Controls.Add(_UFWizard);
        }

	                   
        private IUFCard _BuilderControl_Card6(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card6",false,"FunctionBar", true, true, "0","","12a3d90e-0759-4e95-b9e6-f17b5473a85f");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 560, 20, 0, 3, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(360,bool.Parse("False")),new GridColumnDef(30,bool.Parse("False")),new GridColumnDef(170,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card6 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_CardForRefQueryCase(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.CardForRefQueryCase, "0");		


	
			_BuilderControl_Card1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card1, "0");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_CardForRefQueryCase(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"CardForRefQueryCase",false,"none", true, true, "0","","74b56b70-5d70-4d3c-a3fc-8fd9fad4ce98");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 360, 20, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 6, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(150,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.CardForRefQueryCase = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.QryButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "QryButton", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"3664768b-36ca-44ab-9583-8d85fb432e43","3664768b-36ca-44ab-9583-8d85fb432e43","6d04099f-eedb-4230-abec-76f3f38b8691");
	

		
			UIControlBuilder.BuilderUFControl(this.QryButton, "1");		


				this.lbCase = UIControlBuilder.BuilderUFLabel(_UFCard, "lbCase", "", "True", "True", "Right", 80, 20, 3, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","6fa14526-0fc7-405d-8884-f9d3d4033cc8");


								

		
			UIControlBuilder.BuilderUFControl(this.lbCase, "1");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 150, 20, 5, 0, 1, 1, "100",true,false,"","","e0145f7e-d486-4652-8eb5-e81c175891b9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "2");		
		 


			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card1(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"none", true, true, "0","","911b5779-2747-4e2b-9cf4-063829d658c7");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 170, 20, 2, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 1, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.ConfirmButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "ConfirmButton", true, true, 80, 20, 0, 0, 1, 1, "100","O", this.Model.ElementID,"",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","1234981b-7283-4f6b-b908-97fef9281455");
	

		
			UIControlBuilder.BuilderUFControl(this.ConfirmButton, "3");		


				this.CancelButton = UIControlBuilder.BuilderUFButton(_UFCard, true, "CancelButton", true, true, 80, 20, 2, 0, 1, 1, "100","C", this.Model.ElementID,"",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","13ba9869-2ca4-41a1-af69-a28faa55c7f2");
	

		
			UIControlBuilder.BuilderUFControl(this.CancelButton, "4");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,13,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 560, 318, 0, 2, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.cRef, "cRef", "", null, 13, "物流价目表");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.cRef.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, true, 7, 80, "19",true, false,"","6af73d99-6704-4733-866b-9748485cdd2f","6af73d99-6704-4733-866b-9748485cdd2f","4efe588a-4d64-4438-bed5-c1cdee0886a6");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.FixedPoint, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
	
    if (this.UseQueryCase && UFIDA.UBF.Query.CommonService.RefQueryHelper.QueryCaseExist(this.Action, null))
    {
            return;
    }
	 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DocNo0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["DocNo"]/*DocNo*/,"DocNo", false, true, true, false, false, true, 0, 80, "5",true, false,"","83f7be28-3770-4f1f-957f-0d54b5f7ea7c","83f7be28-3770-4f1f-957f-0d54b5f7ea7c","e33d9369-3ae8-414f-8165-4283e23ddce3");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Name"]/*Name*/,"Name", false, true, true, false, false, true, 0, 80, "5",true, false,"","a99c0689-15ac-4e21-b822-44d798924f4b","a99c0689-15ac-4e21-b822-44d798924f4b","2218f0ea-db43-462e-a0d0-e6e657ec90a5");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Supplier_Name0","TextBoxColumnModel", "", 0,this.Model.cRef.Fields["Supplier_Name"]/*Supplier_Name*/,"Supplier_Name", false, true, true, false, false, true, 0, 255, "5",true, true,"","5efdf52b-dcf3-4daa-8669-8d8f61190c09","5efdf52b-dcf3-4daa-8669-8d8f61190c09","a27eee23-3e1f-4717-888c-c3623e9cd4bf");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","5") ;          
	  
		 
        }

	        private void _BuilderControl_MatchTypeRadioBoxList(IUFContainer container)
        {
            IUFRadioBoxList _UFListControl = UIControlBuilder.BuildRadioBoxList(container,"MatchTypeRadioBoxList",true,true,"6",0,4,UFSoft.UBF.UI.ControlModel.LineOrientation.Horizontal);
			CommonBuilder.GridLayoutPropBuilder(container, _UFListControl, 560, 20, 0, 1, 1, 1, "100");
            this.MatchTypeRadioBoxList = _UFListControl;
            ///foreach CheckBoxList和RadioBoxList下的所有子项
            ListItem listItem = null ;
            listItem = UIControlBuilder.BuildListItem(container,"0", true,false,"130bc338-9958-4133-9b7f-9c185bc2455a","af99f822-f2fa-4bfe-8af4-dfdc6bb56735");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"1", true,false,"49790074-95af-497d-ae37-16bb697f3ce6","fdb911a9-0a10-4562-8758-254995379a03");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"2", true,true,"517d6f15-ca0d-4e3b-aa58-3c85a5b2ae66","0e8f907a-5312-4af9-ab29-94849b11ea05");
            _UFListControl.Items.Add(listItem);
            listItem = UIControlBuilder.BuildListItem(container,"3", true,false,"ea7795fe-8961-4c3f-8ed1-b5128be2cd75","bfa42281-333a-4aae-9b6f-87cdba5aa187");
            _UFListControl.Items.Add(listItem);
        }




		#endregion
		

	}
}

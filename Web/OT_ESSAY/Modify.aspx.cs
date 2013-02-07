using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace cfs.Web.OT_ESSAY
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string ES_ID= Request.Params["id"];
					ShowInfo(ES_ID);
				}
			}
		}
			
	private void ShowInfo(string ES_ID)
	{
		cfs.BLL.OT_ESSAY bll=new cfs.BLL.OT_ESSAY();
		cfs.Model.OT_ESSAY model=bll.GetModel(ES_ID);
		this.lblES_ID.Text=model.ES_ID;
		this.txtES_TYPE.Text=model.ES_TYPE;
		this.txtES_TITLE.Text=model.ES_TITLE;
		this.txtES_CONTENT.Text=model.ES_CONTENT;
		this.txtES_HARD.Text=model.ES_HARD.ToString();
		this.txtES_DELFLAG.Text=model.ES_DELFLAG.ToString();
		this.txtES_CTIME.Text=model.ES_CTIME.ToString();
		this.txtES_TID.Text=model.ES_TID;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtES_TYPE.Text.Trim().Length==0)
			{
				strErr+="ES_TYPE不能为空！\\n";	
			}
			if(this.txtES_TITLE.Text.Trim().Length==0)
			{
				strErr+="ES_TITLE不能为空！\\n";	
			}
			if(this.txtES_CONTENT.Text.Trim().Length==0)
			{
				strErr+="ES_CONTENT不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtES_HARD.Text))
			{
				strErr+="ES_HARD格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtES_DELFLAG.Text))
			{
				strErr+="ES_DELFLAG格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtES_CTIME.Text))
			{
				strErr+="ES_CTIME格式错误！\\n";	
			}
			if(this.txtES_TID.Text.Trim().Length==0)
			{
				strErr+="ES_TID不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ES_ID=this.lblES_ID.Text;
			string ES_TYPE=this.txtES_TYPE.Text;
			string ES_TITLE=this.txtES_TITLE.Text;
			string ES_CONTENT=this.txtES_CONTENT.Text;
			int ES_HARD=int.Parse(this.txtES_HARD.Text);
			int ES_DELFLAG=int.Parse(this.txtES_DELFLAG.Text);
			DateTime ES_CTIME=DateTime.Parse(this.txtES_CTIME.Text);
			string ES_TID=this.txtES_TID.Text;


			cfs.Model.OT_ESSAY model=new cfs.Model.OT_ESSAY();
			model.ES_ID=ES_ID;
			model.ES_TYPE=ES_TYPE;
			model.ES_TITLE=ES_TITLE;
			model.ES_CONTENT=ES_CONTENT;
			model.ES_HARD=ES_HARD;
			model.ES_DELFLAG=ES_DELFLAG;
			model.ES_CTIME=ES_CTIME;
			model.ES_TID=ES_TID;

			cfs.BLL.OT_ESSAY bll=new cfs.BLL.OT_ESSAY();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

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
namespace cfs.Web.OT_PAPERDETAIL
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string PD_ID= Request.Params["id"];
					ShowInfo(PD_ID);
				}
			}
		}
			
	private void ShowInfo(string PD_ID)
	{
		cfs.BLL.OT_PAPERDETAIL bll=new cfs.BLL.OT_PAPERDETAIL();
		cfs.Model.OT_PAPERDETAIL model=bll.GetModel(PD_ID);
		this.lblPD_ID.Text=model.PD_ID;
		this.txtPD_SID.Text=model.PD_SID;
		this.txtPD_QID.Text=model.PD_QID;
		this.txtPD_NUM.Text=model.PD_NUM.ToString();
		this.txtPD_POINT.Text=model.PD_POINT.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPD_SID.Text.Trim().Length==0)
			{
				strErr+="PD_SID不能为空！\\n";	
			}
			if(this.txtPD_QID.Text.Trim().Length==0)
			{
				strErr+="PD_QID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPD_NUM.Text))
			{
				strErr+="PD_NUM格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPD_POINT.Text))
			{
				strErr+="PD_POINT格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string PD_ID=this.lblPD_ID.Text;
			string PD_SID=this.txtPD_SID.Text;
			string PD_QID=this.txtPD_QID.Text;
			int PD_NUM=int.Parse(this.txtPD_NUM.Text);
			decimal PD_POINT=decimal.Parse(this.txtPD_POINT.Text);


			cfs.Model.OT_PAPERDETAIL model=new cfs.Model.OT_PAPERDETAIL();
			model.PD_ID=PD_ID;
			model.PD_SID=PD_SID;
			model.PD_QID=PD_QID;
			model.PD_NUM=PD_NUM;
			model.PD_POINT=PD_POINT;

			cfs.BLL.OT_PAPERDETAIL bll=new cfs.BLL.OT_PAPERDETAIL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

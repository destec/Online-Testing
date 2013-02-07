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
namespace cfs.Web.OT_SESSION
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSE_ID.Text.Trim().Length==0)
			{
				strErr+="SE_ID不能为空！\\n";	
			}
			if(this.txtSE_TID.Text.Trim().Length==0)
			{
				strErr+="SE_TID不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSE_CTIME.Text))
			{
				strErr+="SE_CTIME格式错误！\\n";	
			}
			if(this.txtSE_NAME.Text.Trim().Length==0)
			{
				strErr+="SE_NAME不能为空！\\n";	
			}
			if(this.txtSE_CONTENT.Text.Trim().Length==0)
			{
				strErr+="SE_CONTENT不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSE_TTIME.Text))
			{
				strErr+="SE_TTIME格式错误！\\n";	
			}
			if(this.txtSE_DTIME.Text.Trim().Length==0)
			{
				strErr+="SE_DTIME不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSE_DELFLAG.Text))
			{
				strErr+="SE_DELFLAG格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string SE_ID=this.txtSE_ID.Text;
			string SE_TID=this.txtSE_TID.Text;
			DateTime SE_CTIME=DateTime.Parse(this.txtSE_CTIME.Text);
			string SE_NAME=this.txtSE_NAME.Text;
			string SE_CONTENT=this.txtSE_CONTENT.Text;
			DateTime SE_TTIME=DateTime.Parse(this.txtSE_TTIME.Text);
			string SE_DTIME=this.txtSE_DTIME.Text;
			int SE_DELFLAG=int.Parse(this.txtSE_DELFLAG.Text);

			cfs.Model.OT_SESSION model=new cfs.Model.OT_SESSION();
			model.SE_ID=SE_ID;
			model.SE_TID=SE_TID;
			model.SE_CTIME=SE_CTIME;
			model.SE_NAME=SE_NAME;
			model.SE_CONTENT=SE_CONTENT;
			model.SE_TTIME=SE_TTIME;
			model.SE_DTIME=SE_DTIME;
			model.SE_DELFLAG=SE_DELFLAG;

			cfs.BLL.OT_SESSION bll=new cfs.BLL.OT_SESSION();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

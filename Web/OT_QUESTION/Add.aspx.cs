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
namespace cfs.Web.OT_QUESTION
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtQS_ID.Text.Trim().Length==0)
			{
				strErr+="QS_ID不能为空！\\n";	
			}
			if(this.txtQS_TYPE.Text.Trim().Length==0)
			{
				strErr+="QS_TYPE不能为空！\\n";	
			}
			if(this.txtQS_EID.Text.Trim().Length==0)
			{
				strErr+="QS_EID不能为空！\\n";	
			}
			if(this.txtQS_CONTENT.Text.Trim().Length==0)
			{
				strErr+="QS_CONTENT不能为空！\\n";	
			}
			if(this.txtQS_CHOICE_A.Text.Trim().Length==0)
			{
				strErr+="QS_CHOICE_A不能为空！\\n";	
			}
			if(this.txtQS_CHOICE_B.Text.Trim().Length==0)
			{
				strErr+="QS_CHOICE_B不能为空！\\n";	
			}
			if(this.txtQS_CHOICE_C.Text.Trim().Length==0)
			{
				strErr+="QS_CHOICE_C不能为空！\\n";	
			}
			if(this.txtQS_CHOICE_D.Text.Trim().Length==0)
			{
				strErr+="QS_CHOICE_D不能为空！\\n";	
			}
			if(this.txtQS_CHOICE_COR.Text.Trim().Length==0)
			{
				strErr+="QS_CHOICE_COR不能为空！\\n";	
			}
			if(this.txtQS_COR_EXPLAINATION.Text.Trim().Length==0)
			{
				strErr+="QS_COR_EXPLAINATION不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtQS_DELFLAG.Text))
			{
				strErr+="QS_DELFLAG格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtQS_HARD.Text))
			{
				strErr+="QS_HARD格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtQS_CTIME.Text))
			{
				strErr+="QS_CTIME格式错误！\\n";	
			}
			if(this.txtQS_TID.Text.Trim().Length==0)
			{
				strErr+="QS_TID不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string QS_ID=this.txtQS_ID.Text;
			string QS_TYPE=this.txtQS_TYPE.Text;
			string QS_EID=this.txtQS_EID.Text;
			string QS_CONTENT=this.txtQS_CONTENT.Text;
			string QS_CHOICE_A=this.txtQS_CHOICE_A.Text;
			string QS_CHOICE_B=this.txtQS_CHOICE_B.Text;
			string QS_CHOICE_C=this.txtQS_CHOICE_C.Text;
			string QS_CHOICE_D=this.txtQS_CHOICE_D.Text;
			string QS_CHOICE_COR=this.txtQS_CHOICE_COR.Text;
			string QS_COR_EXPLAINATION=this.txtQS_COR_EXPLAINATION.Text;
			int QS_DELFLAG=int.Parse(this.txtQS_DELFLAG.Text);
			int QS_HARD=int.Parse(this.txtQS_HARD.Text);
			DateTime QS_CTIME=DateTime.Parse(this.txtQS_CTIME.Text);
			string QS_TID=this.txtQS_TID.Text;

			cfs.Model.OT_QUESTION model=new cfs.Model.OT_QUESTION();
			model.QS_ID=QS_ID;
			model.QS_TYPE=QS_TYPE;
			model.QS_EID=QS_EID;
			model.QS_CONTENT=QS_CONTENT;
			model.QS_CHOICE_A=QS_CHOICE_A;
			model.QS_CHOICE_B=QS_CHOICE_B;
			model.QS_CHOICE_C=QS_CHOICE_C;
			model.QS_CHOICE_D=QS_CHOICE_D;
			model.QS_CHOICE_COR=QS_CHOICE_COR;
			model.QS_COR_EXPLAINATION=QS_COR_EXPLAINATION;
			model.QS_DELFLAG=QS_DELFLAG;
			model.QS_HARD=QS_HARD;
			model.QS_CTIME=QS_CTIME;
			model.QS_TID=QS_TID;

			cfs.BLL.OT_QUESTION bll=new cfs.BLL.OT_QUESTION();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

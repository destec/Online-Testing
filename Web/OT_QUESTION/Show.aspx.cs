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
namespace cfs.Web.OT_QUESTION
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string QS_ID= strid;
					ShowInfo(QS_ID);
				}
			}
		}
		
	private void ShowInfo(string QS_ID)
	{
		cfs.BLL.OT_QUESTION bll=new cfs.BLL.OT_QUESTION();
		cfs.Model.OT_QUESTION model=bll.GetModel(QS_ID);
		this.lblQS_ID.Text=model.QS_ID;
		this.lblQS_TYPE.Text=model.QS_TYPE;
		this.lblQS_EID.Text=model.QS_EID;
		this.lblQS_CONTENT.Text=model.QS_CONTENT;
		this.lblQS_CHOICE_A.Text=model.QS_CHOICE_A;
		this.lblQS_CHOICE_B.Text=model.QS_CHOICE_B;
		this.lblQS_CHOICE_C.Text=model.QS_CHOICE_C;
		this.lblQS_CHOICE_D.Text=model.QS_CHOICE_D;
		this.lblQS_CHOICE_COR.Text=model.QS_CHOICE_COR;
		this.lblQS_COR_EXPLAINATION.Text=model.QS_COR_EXPLAINATION;
		this.lblQS_DELFLAG.Text=model.QS_DELFLAG.ToString();
		this.lblQS_HARD.Text=model.QS_HARD.ToString();
		this.lblQS_CTIME.Text=model.QS_CTIME.ToString();
		this.lblQS_TID.Text=model.QS_TID;

	}


    }
}

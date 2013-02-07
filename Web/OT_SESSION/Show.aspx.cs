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
namespace cfs.Web.OT_SESSION
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
					string SE_ID= strid;
					ShowInfo(SE_ID);
				}
			}
		}
		
	private void ShowInfo(string SE_ID)
	{
		cfs.BLL.OT_SESSION bll=new cfs.BLL.OT_SESSION();
		cfs.Model.OT_SESSION model=bll.GetModel(SE_ID);
		this.lblSE_ID.Text=model.SE_ID;
		this.lblSE_TID.Text=model.SE_TID;
		this.lblSE_CTIME.Text=model.SE_CTIME.ToString();
		this.lblSE_NAME.Text=model.SE_NAME;
		this.lblSE_CONTENT.Text=model.SE_CONTENT;
		this.lblSE_TTIME.Text=model.SE_TTIME.ToString();
		this.lblSE_DTIME.Text=model.SE_DTIME;
		this.lblSE_DELFLAG.Text=model.SE_DELFLAG.ToString();

	}


    }
}

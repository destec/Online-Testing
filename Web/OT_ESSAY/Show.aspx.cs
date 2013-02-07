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
namespace cfs.Web.OT_ESSAY
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
					string ES_ID= strid;
					ShowInfo(ES_ID);
				}
			}
		}
		
	private void ShowInfo(string ES_ID)
	{
		cfs.BLL.OT_ESSAY bll=new cfs.BLL.OT_ESSAY();
		cfs.Model.OT_ESSAY model=bll.GetModel(ES_ID);
		this.lblES_ID.Text=model.ES_ID;
		this.lblES_TYPE.Text=model.ES_TYPE;
		this.lblES_TITLE.Text=model.ES_TITLE;
		this.lblES_CONTENT.Text=model.ES_CONTENT;
		this.lblES_HARD.Text=model.ES_HARD.ToString();
		this.lblES_DELFLAG.Text=model.ES_DELFLAG.ToString();
		this.lblES_CTIME.Text=model.ES_CTIME.ToString();
		this.lblES_TID.Text=model.ES_TID;

	}


    }
}

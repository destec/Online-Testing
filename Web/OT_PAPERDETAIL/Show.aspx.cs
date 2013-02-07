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
namespace cfs.Web.OT_PAPERDETAIL
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
					string PD_ID= strid;
					ShowInfo(PD_ID);
				}
			}
		}
		
	private void ShowInfo(string PD_ID)
	{
		cfs.BLL.OT_PAPERDETAIL bll=new cfs.BLL.OT_PAPERDETAIL();
		cfs.Model.OT_PAPERDETAIL model=bll.GetModel(PD_ID);
		this.lblPD_ID.Text=model.PD_ID;
		this.lblPD_SID.Text=model.PD_SID;
		this.lblPD_QID.Text=model.PD_QID;
		this.lblPD_NUM.Text=model.PD_NUM.ToString();
		this.lblPD_POINT.Text=model.PD_POINT.ToString();

	}


    }
}

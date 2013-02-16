using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cfs.Web.cfsadmin.QuestionManagement.Details
{
    public partial class CompositionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = Request.QueryString["type"];
            this.type.Value = type;
            string qsid = Request.QueryString["qsid"];
            this.qsid.Value = qsid;
            cfs.BLL.OT_ESSAY bll = new BLL.OT_ESSAY();
            cfs.Model.OT_ESSAY model = new Model.OT_ESSAY();
            switch (type)
            {
                case "CompositionDetail":
                    model = bll.GetModel(qsid);
                    if (model.ES_TITLE == null || model.ES_TITLE.ToString().Trim() == "")
                    {
                        this.question_title.Value = "";
                        this.question_title.Disabled = true;
                    }
                    else
                    {
                        this.question_title.Value = model.ES_TITLE.ToString();
                        this.question_title.Disabled = true;
                    }
                    if (model.ES_CONTENT == null || model.ES_CONTENT.ToString().Trim() == "")
                    {
                        this.question_content.Value = "";
                        this.question_content.Disabled = true;
                    }
                    else
                    {
                        this.question_content.Value = model.ES_CONTENT.ToString();
                        this.question_content.Disabled = true;
                    }
                    if (model.ES_ANSWER == null || model.ES_ANSWER.ToString().Trim() == "")
                    {
                        this.answer.Value = "";
                        this.answer.Disabled = true;
                    }
                    else
                    {
                        this.answer.Value = model.ES_ANSWER.ToString();
                        this.answer.Disabled = true;
                    }
                    break;
                case "CompositionEdit":
                    model = bll.GetModel(qsid);
                    if (model.ES_TITLE == null || model.ES_TITLE.ToString().Trim() == "")
                    {
                        this.question_title.Value = "";
                    }
                    else
                    {
                        this.question_title.Value = model.ES_TITLE.ToString();
                    }
                    if (model.ES_CONTENT == null || model.ES_CONTENT.ToString().Trim() == "")
                    {
                        this.question_content.Value = "";
                    }
                    else
                    {
                        this.question_content.Value = model.ES_CONTENT.ToString();
                    }
                    if (model.ES_ANSWER == null || model.ES_ANSWER.ToString().Trim() == "")
                    {
                        this.answer.Value = "";
                    }
                    else
                    {
                        this.answer.Value = model.ES_ANSWER.ToString();
                    }
                    break;
                case "CompositionAdd":
                    break;
                default:
                    break;
            }
        }
    }
}
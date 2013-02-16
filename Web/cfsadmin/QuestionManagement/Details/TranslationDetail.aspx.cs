using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cfs.Web.cfsadmin.QuestionManagement.Details
{
    public partial class TranslationDetail : System.Web.UI.Page
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
                case "TranslationDetail":
                    model = bll.GetModel(qsid);
                    if (model.ES_CONTENT == null || model.ES_CONTENT.ToString().Trim() == "")
                    {
                        this.question.Value = "";
                        this.question.Disabled = true;
                    }
                    else
                    {
                        this.question.Value = model.ES_CONTENT.ToString();
                        this.question.Disabled = true;
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
                case "TranslationEdit":
                    model = bll.GetModel(qsid);
                    if (model.ES_CONTENT == null || model.ES_CONTENT.ToString().Trim() == "")
                    {
                        this.question.Value = "";
                    }
                    else
                    {
                        this.question.Value = model.ES_CONTENT.ToString();
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
                case "TranslationAdd":
                    break;
            }
        }
    }
}
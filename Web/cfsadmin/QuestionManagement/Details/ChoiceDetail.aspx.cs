using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cfs.Web.cfsadmin.QuestionManagement.Details
{
    public partial class ChoiceDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = Request.QueryString["type"];
            this.type.Value = type;
            string qsid = Request.QueryString["qsid"].Trim();
            this.qsid.Value = qsid;
            cfs.BLL.OT_QUESTION bll = new BLL.OT_QUESTION();
            cfs.Model.OT_QUESTION model = new Model.OT_QUESTION();
            switch (type)
            {
                case "ChoiceEdit":
                    model = bll.GetModel(qsid);
                    this.number.Value = model.QS_ID.ToString();
                    if (model.QS_CONTENT == null || model.QS_CONTENT.ToString().Trim() == "")
                    {
                        this.question.Value = "";
                    }
                    else
                    {
                        this.question.Value = model.QS_CONTENT.ToString();
                    }
                    if (model.QS_CHOICE_A == null || model.QS_CHOICE_A.ToString().Trim() == "")
                    {
                        this.ca.Value = "";
                    }
                    else
                    {
                        this.ca.Value = model.QS_CHOICE_A.ToString();

                    }
                    if (model.QS_CHOICE_B == null || model.QS_CHOICE_B.ToString().Trim() == "")
                    {
                        this.cb.Value = "";
                    }
                    else
                    {
                        this.cb.Value = model.QS_CHOICE_B.ToString();
                    }
                    if (model.QS_CHOICE_C == null || model.QS_CHOICE_C.ToString().Trim() == "")
                    {
                        this.cc.Value = "";
                    }
                    else
                    {
                        this.cc.Value = model.QS_CHOICE_C.ToString();
                    }
                    if (model.QS_CHOICE_D == null || model.QS_CHOICE_D.ToString().Trim() == "")
                    {
                        this.cd.Value = "";
                    }
                    else
                    {
                        this.cd.Value = model.QS_CHOICE_D.ToString();
                    }
                    if (model.QS_CHOICE_COR != null && model.QS_CHOICE_COR.ToString().Trim() != "")
                    {
                        switch (model.QS_CHOICE_COR)
                        {
                            case 1:
                                this.answer1.Checked = true;
                                break;
                            case 2:
                                this.answer2.Checked = true;
                                break;
                            case 3:
                                this.answer3.Checked = true;
                                break;
                            case 4:
                                this.answer4.Checked = true;
                                break;
                            default:
                                break;
                        }
                    }
                    if (model.QS_COR_EXPLAINATION == null || model.QS_COR_EXPLAINATION.ToString().Trim() == "")
                    {
                        this.explaination.Value = "";
                    }
                    else
                    {
                        this.explaination.Value = model.QS_COR_EXPLAINATION.ToString();
                    }
                    break;
                case "ChoiceDetail":
                    model = bll.GetModel(qsid);
                    this.number.Value = model.QS_ID.ToString();
                    if (model.QS_CONTENT == null || model.QS_CONTENT.ToString().Trim() == "")
                    {
                        this.question.Value = "";
                        this.question.Disabled = true;
                    }
                    else
                    {
                        this.question.Value = model.QS_CONTENT.ToString();
                        this.question.Disabled = true;
                    }
                    if (model.QS_CHOICE_A == null || model.QS_CHOICE_A.ToString().Trim() == "")
                    {
                        this.ca.Value = "";
                        this.ca.Disabled = true;
                    }
                    else
                    {
                        this.ca.Value = model.QS_CHOICE_A.ToString();
                        this.ca.Disabled = true;
                    }
                    if (model.QS_CHOICE_B == null || model.QS_CHOICE_B.ToString().Trim() == "")
                    {
                        this.cb.Value = "";
                        this.cb.Disabled = true;
                    }
                    else
                    {
                        this.cb.Value = model.QS_CHOICE_B.ToString();
                        this.cb.Disabled = true;
                    }
                    if (model.QS_CHOICE_C == null || model.QS_CHOICE_C.ToString().Trim() == "")
                    {
                        this.cc.Value = "";
                        this.cc.Disabled = true;
                    }
                    else
                    {
                        this.cc.Value = model.QS_CHOICE_C.ToString();
                        this.cc.Disabled = true;
                    }
                    if (model.QS_CHOICE_D == null || model.QS_CHOICE_D.ToString().Trim() == "")
                    {
                        this.cd.Value = "";
                        this.cd.Disabled = true;
                    }
                    else
                    {
                        this.cd.Value = model.QS_CHOICE_D.ToString();
                        this.cd.Disabled = true;
                    }
                    if (model.QS_CHOICE_COR != null && model.QS_CHOICE_COR.ToString().Trim() != "")
                    {
                        switch (model.QS_CHOICE_COR)
                        {
                            case 1:
                                this.answer1.Checked = true;
                                break;
                            case 2:
                                this.answer2.Checked = true;
                                break;
                            case 3:
                                this.answer3.Checked = true;
                                break;
                            case 4:
                                this.answer4.Checked = true;
                                break;
                            default:
                                break;
                        }
                        this.answer1.Disabled = true;
                        this.answer2.Disabled = true;
                        this.answer3.Disabled = true;
                        this.answer4.Disabled = true;
                    }
                    if (model.QS_COR_EXPLAINATION == null || model.QS_COR_EXPLAINATION.ToString().Trim() == "")
                    {
                        this.explaination.Value = "";
                        this.explaination.Disabled = true;
                    }
                    else
                    {
                        this.explaination.Value = model.QS_COR_EXPLAINATION.ToString();
                        this.explaination.Disabled = true;
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
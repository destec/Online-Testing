using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace cfs.Web.cfsadmin.QuestionManagement
{
    /// <summary>
    /// bean 的摘要说明
    /// </summary>
    public class bean : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            /*----------------------题目操作接口—————————————————————————*/
            string action = context.Request.Params["type"];
            string qsid = context.Request.Params["qsid"];
            cfs.Model.JSON jj;
            cfs.BLL.OT_QUESTION bll = new BLL.OT_QUESTION();
            cfs.Model.OT_QUESTION model = new Model.OT_QUESTION();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            switch (action)
            {

                case "ChoiceDetail":
                    break;
                case "ChoiceAdd":
                    //调用存储过程生成QS_ID
                    model.QS_CONTENT = context.Request.Form["question"];
                    model.QS_CHOICE_A = context.Request.Form["ca"];
                    model.QS_CHOICE_B = context.Request.Form["cb"];
                    model.QS_CHOICE_C = context.Request.Form["cc"];
                    model.QS_CHOICE_D = context.Request.Form["cd"];
                    model.QS_CHOICE_COR = Convert.ToInt32(context.Request.Form["answer"]);
                    model.QS_COR_EXPLAINATION = context.Request.Form["explaination"];
                    model.QS_CTIME = System.DateTime.Now;
                    if (bll.Add(model))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "新增成功", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "新增失败", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "ChoiceEdit":
                    model = bll.GetModel(qsid);
                    model.QS_CONTENT = context.Request.Form["question"];
                    model.QS_CHOICE_A = context.Request.Form["ca"];
                    model.QS_CHOICE_B = context.Request.Form["cb"];
                    model.QS_CHOICE_C = context.Request.Form["cc"];
                    model.QS_CHOICE_D = context.Request.Form["cd"];
                    model.QS_CHOICE_COR = Convert.ToInt32(context.Request.Form["answer"]);
                    model.QS_COR_EXPLAINATION = context.Request.Form["explaination"];
                    model.QS_CTIME = System.DateTime.Now;
                    if (bll.Update(model))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "编辑成功", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "编辑失败", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "ChoiceDelete":
                    if (bll.Delete(qsid))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "删除成功", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "删除失败", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                default:
                    break;
            }


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
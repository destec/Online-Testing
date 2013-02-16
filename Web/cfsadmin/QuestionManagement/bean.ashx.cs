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
            cfs.BLL.OT_QUESTION bll_q = new BLL.OT_QUESTION();
            cfs.Model.OT_QUESTION model_q = new Model.OT_QUESTION();
            cfs.BLL.OT_ESSAY bll_e = new BLL.OT_ESSAY();
            cfs.Model.OT_ESSAY model_e = new cfs.Model.OT_ESSAY();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            switch (action)
            {
                case "TranslationDetail":
                    break;
                case "TranslationAdd":
                    //调用存储过程生成ES_ID
                    model_e.ES_CONTENT = context.Request.Form["question"];
                    model_e.ES_ANSWER = context.Request.Form["answer"];
                    model_e.ES_CTIME = System.DateTime.Now;
                    if (bll_e.Add(model_e))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "新增成功", navTabId = "Translation", rel = "", callbackType = "closeCurrent" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "新增失败", navTabId = "Translation", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "TranslationEdit":
                    model_e = bll_e.GetModel(qsid);
                    model_e.ES_CONTENT = context.Request.Form["question"];
                    model_e.ES_ANSWER = context.Request.Form["answer"];
                    model_e.ES_CTIME = System.DateTime.Now;
                    if (bll_e.Update(model_e))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "编辑成功", navTabId = "Translation", rel = "", callbackType = "closeCurrent" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "编辑失败", navTabId = "Translation", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "TranlationDelete":
                    if (bll_e.Delete(qsid))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "删除成功", navTabId = "Translation", rel = "", callbackType = "" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "删除失败", navTabId = "Translation", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "CompositionDetail":
                    break;
                case "CompositionAdd":
                    //调用存储过程生成ES_ID
                    model_e.ES_TITLE = context.Request.Form["question_title"];
                    model_e.ES_CONTENT = context.Request.Form["question_content"];
                    model_e.ES_ANSWER = context.Request.Form["answer"];
                    model_e.ES_CTIME = System.DateTime.Now;
                    if (bll_e.Add(model_e))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "新增成功", navTabId = "Composition", rel = "", callbackType = "closeCurrent" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "新增失败", navTabId = "Composition", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "CompositionEdit":
                    model_e = bll_e.GetModel(qsid);
                    model_e.ES_TITLE = context.Request.Form["question_title"];
                    model_e.ES_CONTENT = context.Request.Form["question_content"];
                    model_e.ES_ANSWER = context.Request.Form["answer"];
                    model_e.ES_CTIME = System.DateTime.Now;
                    if (bll_e.Update(model_e))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "编辑成功", navTabId = "Composition", rel = "", callbackType = "closeCurrent" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "编辑失败", navTabId = "Composition", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "CompositionDelete":
                    if (bll_e.Delete(qsid))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "删除成功", navTabId = "Composition", rel = "", callbackType = "" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "删除失败", navTabId = "Composition", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "ChoiceDetail":
                    break;
                case "ChoiceAdd":
                    //调用存储过程生成QS_ID
                    model_q.QS_CONTENT = context.Request.Form["question"];
                    model_q.QS_CHOICE_A = context.Request.Form["ca"];
                    model_q.QS_CHOICE_B = context.Request.Form["cb"];
                    model_q.QS_CHOICE_C = context.Request.Form["cc"];
                    model_q.QS_CHOICE_D = context.Request.Form["cd"];
                    model_q.QS_CHOICE_COR = Convert.ToInt32(context.Request.Form["answer"]);
                    model_q.QS_COR_EXPLAINATION = context.Request.Form["explaination"];
                    model_q.QS_CTIME = System.DateTime.Now;
                    if (bll_q.Add(model_q))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "新增成功", navTabId = "Choice", rel = "", callbackType = "closeCurrent" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "新增失败", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "ChoiceEdit":
                    model_q = bll_q.GetModel(qsid);
                    model_q.QS_CONTENT = context.Request.Form["question"];
                    model_q.QS_CHOICE_A = context.Request.Form["ca"];
                    model_q.QS_CHOICE_B = context.Request.Form["cb"];
                    model_q.QS_CHOICE_C = context.Request.Form["cc"];
                    model_q.QS_CHOICE_D = context.Request.Form["cd"];
                    model_q.QS_CHOICE_COR = Convert.ToInt32(context.Request.Form["answer"]);
                    model_q.QS_COR_EXPLAINATION = context.Request.Form["explaination"];
                    model_q.QS_CTIME = System.DateTime.Now;
                    if (bll_q.Update(model_q))
                    {
                        jj = new Model.JSON() { statusCode = "200", message = "编辑成功", navTabId = "Choice", rel = "", callbackType = "closeCurrent" };
                    }
                    else
                    {
                        jj = new Model.JSON() { statusCode = "300", message = "编辑失败", navTabId = "Choice", rel = "", callbackType = "" };
                    }
                    context.Response.Write(jss.Serialize(jj));
                    break;
                case "ChoiceDelete":
                    if (bll_q.Delete(qsid))
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
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChoiceDetail.aspx.cs" Inherits="cfs.Web.cfsadmin.QuestionManagement.Details.ChoiceDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="pageContent">
        <form id="Form1" method="post" action="QuestionManagement/bean.ashx" class="pageForm required-validate"
        onsubmit="return validateCallback(this, dialogAjaxDone)" runat="server">
        <div class="pageFormContent" layouth="56">
            <p>
                <label>
                    题目编号：
                </label>
                <input type="text" id="number" runat="server" />
                <input type="hidden" name="page" id="page" runat="server" />
                <input type="hidden" name="pagenum" id="pagenum" runat="server" />
                <input type="hidden" id="type" runat="server" />
                <input type="hidden" id="UserGroup" runat="server" />
                <input type="hidden" id="qsid" runat="server" />
            </p>
            <p>
                <label>
                    题干：
                </label>
                <input type="text" runat="server" id="question" />
            </p>
            <p>
                <label>
                    选项A：
                </label>
                <input type="text" runat="server" id="ca" />
            </p>
            <p>
                <label>
                    选项B：
                </label>
                <input type="text" runat="server" id="cb" />
            </p>
            <p>
                <label>
                    选项C：
                </label>
                <input type="text" runat="server" id="cc" />
            </p>
            <p>
                <label>
                    选项D：
                </label>
                <input type="text" runat="server" id="cd" />
            </p>
            <p>
                <label>
                    正确选项：
                </label>
                <input type="radio" runat="server" id="answer1" name="answer" value="1"/>A
                <input type="radio" runat="server" id="answer2" name="answer" value="2"/>B
                <input type="radio" runat="server" id="answer3" name="answer" value="3"/>C
                <input type="radio" runat="server" id="answer4" name="answer" value="4"/>D
            </p>
            <p>
                <label>
                    答案解析：
                </label>
                <input type="text" runat="server" id="explaination" />
            </p>
        </div>
        <div class="formBar">
            <ul>
                <li>
                    <div class="buttonActive">
                        <div class="buttonContent">
                            <button type="submit">
                                提交</button></div>
                    </div>
                </li>
                <li>
                    <div class="button">
                        <div class="buttonContent">
                            <button type="button" class="close">
                                关闭</button></div>
                    </div>
                </li>
            </ul>
        </div>
        </form>
    </div>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Choice.aspx.cs" Inherits="cfs.Web.cfsadmin.QuestionManagement.Choice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="pagerForm" method="post" onsubmit="return navTabSearch(this);" action="">
    <input type="hidden" name="pageNum" id="pageNum" value="1" />
    <input type="hidden" name="numPerPage" value="<%=NumPerPage %>" />
    </form>
    <div class="pageContent">
        <div class="panelBar">
            <ul class="toolBar" id="admin" runat="server">
                <li><a class="icon" href="QuestionManagement/Details/ChoiceDetail.aspx?qsid={qsid}&type=ChoiceDetail&page=<%=NumPerPage %>&pagenum=<%=PageNum %>"
                    target="dialog" rel="detail" warn="请选择一条记录" width="500" height="370"><span>查看详细</span></a></li>
                <li class="line">line</li>
                <li><a class="add" href="QuestionManagement/Details/ChoiceDetail.aspx?qsid={qsid}&type=ChoiceAdd&page=<%=NumPerPage %>&pagenum=<%=PageNum %>"
                    target="dialog" rel="catemodadd" width="500" height="370"><span>新增</span></a></li>
                <li class="line">line</li>
                <li><a title="确实要删除这些记录吗?" target="ajaxTodo" href="QuestionManagement/bean.ashx?qsid={qsid}&type=ChoiceDelete&page=<%=NumPerPage %>&pagenum=<%=PageNum %>" warn="请选择一条记录" class="delete" title="确定要删除这条信息吗?"><span>删除</span></a></li>
                <li class="line">line</li>
                <li><a class="edit" href="QuestionManagement/Details/ChoiceDetail.aspx?qsid={qsid}&type=ChoiceEdit&page=<%=NumPerPage %>&pagenum=<%=PageNum %>"
                    target="dialog" rel="depdel" warn="请选择一条记录" width="500" height="370"><span>修改</span></a></li>
            </ul>
        </div>
    </div>
    <div id="MainTable" runat="server">
    </div>
    <div class="panelBar">
        <div class="pages">
            <span>每页显示</span>
            <select name="numPerPage" onchange="navTabPageBreak({numPerPage:this.value})">
                <option value="<%=NumPerPage%>">选择<%=NumPerPage%></option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="50">50</option>
                <option value="100">100</option>
            </select>
            <span>条，共<font color="red"><strong><%=TotalCount%></strong></font>条</span>
        </div>
        <div class="pagination" targettype="navTab" totalcount="<%=TotalCount%>" numperpage="<%=NumPerPage%>"
            pagenumshown="<%=PageNumShown%>" currentpage="<%=PageNum%>">
        </div>
    </div>
</body>
</html>

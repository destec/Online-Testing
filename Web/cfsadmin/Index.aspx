<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="cfs.Web.cfsadmin.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=7" />
    <title>大学英语在线考试系统</title>
    <link href="themes/default/style.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="themes/css/core.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="themes/css/print.css" rel="stylesheet" type="text/css" media="print" />
    <link href="uploadify/css/uploadify.css" rel="stylesheet" type="text/css" media="screen" />
    <!--[if IE]>
<link href="themes/css/ieHack.css" rel="stylesheet" type="text/css" media="screen"/>
<![endif]-->
    <script src="js/speedup.js" type="text/javascript"></script>
    <script src="js/jquery-1.7.2.js" type="text/javascript"></script>
    <script src="js/jquery.cookie.js" type="text/javascript"></script>
    <script src="js/jquery.validate.js" type="text/javascript"></script>
    <script src="js/jquery.bgiframe.js" type="text/javascript"></script>
    <script src="xheditor/xheditor-1.1.14-zh-cn.min.js" type="text/javascript"></script>
    <script src="uploadify/scripts/swfobject.js" type="text/javascript"></script>
    <script src="uploadify/scripts/jquery.uploadify.v2.1.0.js" type="text/javascript"></script>
    <!-- svg图表  supports Firefox 3.0+, Safari 3.0+, Chrome 5.0+, Opera 9.5+ and Internet Explorer 6.0+ -->
    <script type="text/javascript" src="chart/raphael.js"></script>
    <script type="text/javascript" src="chart/g.raphael.js"></script>
    <script type="text/javascript" src="chart/g.bar.js"></script>
    <script type="text/javascript" src="chart/g.line.js"></script>
    <script type="text/javascript" src="chart/g.pie.js"></script>
    <script type="text/javascript" src="chart/g.dot.js"></script>
    <script src="js/dwz.core.js" type="text/javascript"></script>
    <script src="js/dwz.util.date.js" type="text/javascript"></script>
    <script src="js/dwz.validate.method.js" type="text/javascript"></script>
    <script src="js/dwz.regional.zh.js" type="text/javascript"></script>
    <script src="js/dwz.barDrag.js" type="text/javascript"></script>
    <script src="js/dwz.drag.js" type="text/javascript"></script>
    <script src="js/dwz.tree.js" type="text/javascript"></script>
    <script src="js/dwz.accordion.js" type="text/javascript"></script>
    <script src="js/dwz.ui.js" type="text/javascript"></script>
    <script src="js/dwz.theme.js" type="text/javascript"></script>
    <script src="js/dwz.switchEnv.js" type="text/javascript"></script>
    <script src="js/dwz.alertMsg.js" type="text/javascript"></script>
    <script src="js/dwz.contextmenu.js" type="text/javascript"></script>
    <script src="js/dwz.navTab.js" type="text/javascript"></script>
    <script src="js/dwz.tab.js" type="text/javascript"></script>
    <script src="js/dwz.resize.js" type="text/javascript"></script>
    <script src="js/dwz.dialog.js" type="text/javascript"></script>
    <script src="js/dwz.dialogDrag.js" type="text/javascript"></script>
    <script src="js/dwz.sortDrag.js" type="text/javascript"></script>
    <script src="js/dwz.cssTable.js" type="text/javascript"></script>
    <script src="js/dwz.stable.js" type="text/javascript"></script>
    <script src="js/dwz.taskBar.js" type="text/javascript"></script>
    <script src="js/dwz.ajax.js" type="text/javascript"></script>
    <script src="js/dwz.pagination.js" type="text/javascript"></script>
    <script src="js/dwz.database.js" type="text/javascript"></script>
    <script src="js/dwz.datepicker.js" type="text/javascript"></script>
    <script src="js/dwz.effects.js" type="text/javascript"></script>
    <script src="js/dwz.panel.js" type="text/javascript"></script>
    <script src="js/dwz.checkbox.js" type="text/javascript"></script>
    <script src="js/dwz.history.js" type="text/javascript"></script>
    <script src="js/dwz.combox.js" type="text/javascript"></script>
    <script src="js/dwz.print.js" type="text/javascript"></script>
    <!--
<script src="bin/dwz.min.js" type="text/javascript"></script>
-->
    <script src="js/dwz.regional.zh.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            DWZ.init("dwz.frag.xml", {
                loginUrl: "login_dialog.html", loginTitle: "登录", // 弹出登录对话框
                //		loginUrl:"login.html",	// 跳到登录页面
                statusCode: { ok: 200, error: 300, timeout: 301 }, //【可选】
                pageInfo: { pageNum: "pageNum", numPerPage: "numPerPage", orderField: "orderField", orderDirection: "orderDirection" }, //【可选】
                debug: false, // 调试模式 【true|false】
                callback: function () {
                    initEnv();
                    $("#themeList").theme({ themeBase: "themes" }); // themeBase 相对于index页面的主题base路径
                }
            });
        });

    </script>
</head>
<body scroll="no">
    <div id="layout">
        <div id="header">
            <div class="headerNav">
                <%--<a class="logo" href="http://j-ui.com">标志</a>--%>
                <ul class="nav">
                    <li><a href="changepwd.html" target="dialog" width="600">设置</a></li>
                    <li><a href="login.html">退出</a></li>
                </ul>
                <ul class="themeList" id="themeList">
                    <li theme="default">
                        <div class="selected">
                            蓝色</div>
                    </li>
                    <li theme="green">
                        <div>
                            绿色</div>
                    </li>
                    <!--<li theme="red"><div>红色</div></li>-->
                    <li theme="purple">
                        <div>
                            紫色</div>
                    </li>
                    <li theme="silver">
                        <div>
                            银色</div>
                    </li>
                    <li theme="azure">
                        <div>
                            天蓝</div>
                    </li>
                </ul>
            </div>
            <!-- navMenu -->
        </div>
        <div id="leftside">
            <div id="sidebar_s">
                <div class="collapse">
                    <div class="toggleCollapse">
                        <div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="sidebar">
                <div class="toggleCollapse">
                    <h2>
                        主菜单</h2>
                    <div>
                        收缩</div>
                </div>
                <div class="accordion" fillspace="sidebar">
                    <div class="accordionHeader">
                        <h2>
                            <span>Folder</span>题目管理</h2>
                    </div>
                    <div class="accordionContent">
                        <ul class="tree treeFolder">
                            <li>
                            <a href="./QuestionManagement/FillingBlanks.aspx" target="navTab" rel="FillingBlanks">完型填空</a>
                             <a href="./QuestionManagement/DepthReading.aspx" target="navTab" rel="DepthReading">精读（阅读理解）</a> 
                             <a href="./QuestionManagement/FastReading.aspx" target="navTab" rel="FastReading">快速阅读</a> 
                             <a href="./QuestionManagement/Choice.aspx" target="navTab" rel="Choice">单项选择</a> 
                             <a href="./QuestionManagement/Translation.aspx" target="navTab" rel="Translation">翻译</a>
                             <a href="./QuestionManagement/Composition.aspx" target="navTab" rel="Composition">作文</a> 
                             </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div id="container">
            <div id="navTab" class="tabsPage">
                <div class="tabsPageHeader">
                    <div class="tabsPageHeaderContent">
                        <!-- 显示左右控制时添加 class="tabsPageHeaderMargin" -->
                        <ul class="navTab-tab">
                            <li tabid="main" class="main"><a href="javascript:;"><span><span class="home_icon">主页</span></span></a></li>
                        </ul>
                    </div>
                    <div class="tabsLeft">
                        left</div>
                    <!-- 禁用只需要添加一个样式 class="tabsLeft tabsLeftDisabled" -->
                    <div class="tabsRight">
                        right</div>
                    <!-- 禁用只需要添加一个样式 class="tabsRight tabsRightDisabled" -->
                    <div class="tabsMore">
                        more</div>
                </div>
                <ul class="tabsMoreList">
                    <li><a href="javascript:;">我的主页</a></li>
                </ul>
                <div class="navTab-panel tabsPageContent layoutBox">
                    <div class="page unitBox">
                        <%--<div class="accountInfo">
                            <div class="alertInfo">
                                <h2>
                                    <a href="doc/dwz-user-guide.pdf" target="_blank">DWZ框架使用手册(PDF)</a></h2>
                                <a href="doc/dwz-user-guide.swf" target="_blank">DWZ框架演示视频</a>
                            </div>
                            <div class="right">
                                <p>
                                    <a href="doc/dwz-user-guide.zip" target="_blank" style="line-height: 19px">DWZ框架使用手册(CHM)</a></p>
                                <p>
                                    <a href="doc/dwz-ajax-develop.swf" target="_blank" style="line-height: 19px">DWZ框架Ajax开发视频教材</a></p>
                            </div>
                            <p>
                                <span>DWZ富客户端框架</span></p>
                            <p>
                                DWZ官方微博:<a href="http://weibo.com/dwzui" target="_blank">http://weibo.com/dwzui</a></p>
                        </div>--%>
                        <div class="pageFormContent" layouth="80" style="margin-right: 230px">
                            <h2>
                                大学英语在线考试系统</h2>
                            <div class="divider">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="footer">
        Copyright &copy; 2013 <a href="http://cfs.zjxu.edu.cn" target="_blank">cfs.zjxu.edu.cn</a>
        Tel：0573-xxx</div>
    <!-- 注意此处js代码用于google站点统计，非DWZ代码，请删除 -->
    <%--<script type="text/javascript">
    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-16716654-1']);
    _gaq.push(['_trackPageview']);

    (function () {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? ' https://ssl' : ' http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();
</script>--%>
</body>
</html>


<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="cfs.Web.OT_ESSAY.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ES_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ES_TYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_TYPE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ES_TITLE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_TITLE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ES_CONTENT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_CONTENT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ES_HARD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_HARD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ES_DELFLAG
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_DELFLAG" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ES_CTIME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_CTIME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ES_TID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblES_TID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





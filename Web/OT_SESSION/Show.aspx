<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="cfs.Web.OT_SESSION.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		SE_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SE_TID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_TID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SE_CTIME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_CTIME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SE_CONTENT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_CONTENT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SE_TTIME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_TTIME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SE_DTIME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_DTIME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SE_DELFLAG
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSE_DELFLAG" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





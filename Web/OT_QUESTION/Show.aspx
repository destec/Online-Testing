<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="cfs.Web.OT_QUESTION.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		QS_ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_TYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_TYPE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_EID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_EID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CONTENT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_CONTENT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_A
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_CHOICE_A" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_B
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_CHOICE_B" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_C
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_CHOICE_C" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_D
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_CHOICE_D" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_COR
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_CHOICE_COR" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_COR_EXPLAINATION
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_COR_EXPLAINATION" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_DELFLAG
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_DELFLAG" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_HARD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_HARD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CTIME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_CTIME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_TID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQS_TID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





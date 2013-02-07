<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="cfs.Web.OT_QUESTION.Modify" Title="修改页" %>
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
		<asp:label id="lblQS_ID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_TYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_TYPE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_EID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_EID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CONTENT
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_CONTENT" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_A
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_CHOICE_A" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_B
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_CHOICE_B" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_C
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_CHOICE_C" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_D
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_CHOICE_D" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CHOICE_COR
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_CHOICE_COR" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_COR_EXPLAINATION
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_COR_EXPLAINATION" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_DELFLAG
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_DELFLAG" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_HARD
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_HARD" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_CTIME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtQS_CTIME" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QS_TID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQS_TID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>


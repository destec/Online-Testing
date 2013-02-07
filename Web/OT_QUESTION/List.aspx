<%@ Page Title="OT_QUESTION" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="cfs.Web.OT_QUESTION.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="QS_ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="QS_ID" HeaderText="QS_ID" SortExpression="QS_ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_TYPE" HeaderText="QS_TYPE" SortExpression="QS_TYPE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_EID" HeaderText="QS_EID" SortExpression="QS_EID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_CONTENT" HeaderText="QS_CONTENT" SortExpression="QS_CONTENT" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_CHOICE_A" HeaderText="QS_CHOICE_A" SortExpression="QS_CHOICE_A" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_CHOICE_B" HeaderText="QS_CHOICE_B" SortExpression="QS_CHOICE_B" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_CHOICE_C" HeaderText="QS_CHOICE_C" SortExpression="QS_CHOICE_C" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_CHOICE_D" HeaderText="QS_CHOICE_D" SortExpression="QS_CHOICE_D" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_CHOICE_COR" HeaderText="QS_CHOICE_COR" SortExpression="QS_CHOICE_COR" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_COR_EXPLAINATION" HeaderText="QS_COR_EXPLAINATION" SortExpression="QS_COR_EXPLAINATION" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_DELFLAG" HeaderText="QS_DELFLAG" SortExpression="QS_DELFLAG" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_HARD" HeaderText="QS_HARD" SortExpression="QS_HARD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_CTIME" HeaderText="QS_CTIME" SortExpression="QS_CTIME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QS_TID" HeaderText="QS_TID" SortExpression="QS_TID" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="QS_ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="QS_ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

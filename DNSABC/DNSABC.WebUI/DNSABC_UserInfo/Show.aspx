﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="DNSABC.Web.DNSABC_UserInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		账户余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAccountBalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		可用余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAvilableBalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		已经消费金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblConsumedAmount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		积分
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户等级ID 默认值1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGradeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		有效状态 0为停用
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		联系人姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRealName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QQ号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQq" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		联系人手机
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMobil" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		邮编
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPostcode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		网站
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWebsite" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		身份证号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIDcardNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		账户类型 企业则对应企业信息表
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAccountType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		站点ID 0为主站 大于0为站
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSiteID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





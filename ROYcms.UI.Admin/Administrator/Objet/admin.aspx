<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_Objet_admin" CodeBehind="admin.aspx.cs" ValidateRequest="false" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
</head>
<body>
<form runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <table width="100%" border="0" class="tiao_top">
    <tr>
      <td width="77%" nowrap><div class="tiao_con"> 
      <%if (Request["class"] != null)
        { %>
      <a href="/administrator/objet/insert.aspx?Classkind=<% =ViewState["ClassKind"] %>&Class=<% =Request["class"] %>">
      <img align="absmiddle" src="/administrator/images/nv6.png" />�����Ϣ</a> 
      <%} %>
      <a href="/administrator/objet/admin.aspx?Classkind=<% =ViewState["ClassKind"] %>">
      <img align="absmiddle" src="/administrator/images/nv8.png" />������Ϣ</a> 
      <a href='/administrator/class/index.aspx?ClassKind=<% =ViewState["ClassKind"] %>'>
      <img align="absmiddle" src="/administrator/images/nv9.png" />�������</a> 
      </div></td>
      <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
    </tr>
  </table>
  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:0px; margin-top:5px;">
    <tr>
      <td nowrap><img src="/administrator/images/funnel.png" width="16" height="16" align="absmiddle">
        <asp:DropDownList ID="DdlMenu" runat="server" CssClass="select" Width="100px" AutoPostBack="True" onselectedindexchanged="DdlMenu_SelectedIndexChanged">
         <asp:ListItem Value="0">����Ƶ��</asp:ListItem>
        </asp:DropDownList>
          <asp:DropDownList ID="DdState" runat="server" CssClass="select" Width="78px"  AutoPostBack="True" onselectedindexchanged="DdState_SelectedIndexChanged">
              <asp:ListItem Value="0">����״̬</asp:ListItem>
              <asp:ListItem Value="1">�Ѿ�����</asp:ListItem>
              <asp:ListItem Value="2">�ݸ���</asp:ListItem>
              <asp:ListItem Value="3">����վ</asp:ListItem>
          </asp:DropDownList>
          <asp:DropDownList ID="DdAttribute" runat="server" CssClass="select" Width="78px"  AutoPostBack="True" onselectedindexchanged="DdAttribute_SelectedIndexChanged">
              <asp:ListItem Value="0">��������</asp:ListItem>
              <asp:ListItem Value="1">�ö�</asp:ListItem>
              <asp:ListItem Value="2">�Ƽ�</asp:ListItem>
              <asp:ListItem Value="3">ͷ��</asp:ListItem>
          </asp:DropDownList>
         <asp:DropDownList ID="DdTime" runat="server" CssClass="select" Width="78px"  AutoPostBack="True" onselectedindexchanged="DdTime_SelectedIndexChanged">
              <asp:ListItem Value="0">����ʱ��</asp:ListItem>
              <asp:ListItem Value="1">1���ڷ���</asp:ListItem>
              <asp:ListItem Value="2">2���ڷ���</asp:ListItem>
              <asp:ListItem Value="3">3���ڷ���</asp:ListItem>
              <asp:ListItem Value="3">���緢��</asp:ListItem>
          </asp:DropDownList>
      </td>
      <td width="25%" align="right" nowrap>
        <input name="keywords" id="keywords" type="text" class="txtInput" style="width:120px;height:21px" title="�������ű���ؼ��ʽ���������" runat="server">
        <asp:Button ID="Submit" CssClass="btnSearch" runat="server" Text="����" onclick="Submit_Click" />
      </td>
    </tr>
  </table>
 
    <asp:Repeater ID="Repeater_admin" runat="server">
    <HeaderTemplate>
    <table cellpadding="5" cellspacing="1" border="0" width="100%"  class="Tb" style="margin-right:5px; margin-bottom:5px;margin-top:5px;" >
    <tr id="tiao_center">
      <td width="23" nowrap><input  id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
      <td width="28" nowrap><span class="line">���</span></td>
      <td nowrap><span class="line">��Ŀ</span></td>
      <td nowrap><span class="line">����</span></td>
      <td nowrap><span class="line">����</span></td>
      <td nowrap><span class="line">¼������</span></td>
      <td nowrap><span class="line">�ö� | �Ƽ�</span></td>
      <td nowrap><span class="line">״̬</span></td>
      <td width="100" align="center" nowrap><span class="line">����</span></td>
    </tr>
    </HeaderTemplate>
    
      <ItemTemplate>
        <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
          <td nowrap><asp:CheckBox ID="ID_list" runat="server" onclick="javascript:chkRow(this);" /></td>
          <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("bh") %>'></asp:Label></td>
          <td nowrap>
          <a rel="facebox" title="Ƶ��" href="#classContent<%#Eval("bh") %>"><%#get_classname(Convert.ToInt32(Eval("classname"))) %></a>
            <div id="classContent<%#Eval("bh") %>" style="display:none;">
              <h3>��������</h3>
              <p>��������:[<%#Eval("classname") %>]<%#get_classname(Convert.ToInt32(Eval("classname"))) %></p>
            </div>
            </td>
          <td>
          <a href='Insert.aspx?id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>'> <%#Eval("title") %> </a> 
          <a rel="facebox" title="ժҪ" href='#zhaiyao<%#Eval("bh") %>'><img src="/administrator/images/tag.png" alt="�鿴ժҪ" border="0" title='<%#Eval("zhaiyao") %>'></a>
            <div id="zhaiyao<%#Eval("bh") %>"  style="display:none;">
              <h3>��ϢժҪ</h3>
              <p><%#Eval("zhaiyao") %></p>
            </div></td>
          <td nowrap><a rel="facebox" href="#author<%#Eval("bh") %>"><%#Eval("author")%></a>
            <div id="author<%#Eval("bh") %>" style="display:none;">
              <h3>��������</h3>
              <p><%#Eval("author") %></p>
            </div></td>
          <td nowrap><%#Eval("time")%></td>
          <td nowrap><a href='?t=ding&id=<%#Eval("bh") %>&ding=<%#Eval("ding") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>&page=<% =ViewState["Page"] %>'><b><font color="#FF3300" title="����ö�"><%#Eval("ding").ToString().Trim()=="0"?"��":"X"%></font></b></a> &nbsp;&nbsp; <a href='?t=tuijian&id=<%#Eval("bh") %>&tuijian=<%#Eval("tuijian") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>&page=<% =Request["page"] %>'><b><font color="#FF3300" title="����Ƽ���"><%#Eval("tuijian").ToString().Trim()=="0"?"��":"X"%></font></b></a></td>
          <td nowrap><a href='?t=K&id=<%#Eval("bh") %>&K=<%#Eval("switchs") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>&page=<% =ViewState["Page"] %>'><b><font color="#FF3300" title="����رա�"><%#Eval("switchs").ToString().Trim()=="0"?"��":"X"%></font></b></a></td>
          <td align="center" nowrap>
          <a href='<%# new ROYcms.Templet.GetMyUrl().GetArticle(Convert.ToInt32(Eval("bh"))) %>' target=_blank>����</a>
           | <a href='Insert.aspx?id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>'>�༭</a>
           | <a  href='#del<%#Eval("bh") %>' rel='facebox' title='ȷ��ɾ�� [<%#Eval("title")%>] ��?'>ɾ��</a>
            <div id="del<%#Eval("bh") %>" style="display:none; width:260px;">
               <p style="color:Red; margin-bottom:5px;">ע�⣺������ɾ���û�����Ϣ�������Լ����ɵľ�̬�ļ��Լ��������ĸ����������Ϣ��</p>
                  <a href='?t=del&id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>' class="btnSearch" style="padding:3px;">ɾ��</a> 
                  <a href='?class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>' class="btnSearch" style="padding:3px;">ȡ��</a> 
            </div>
           
           </td>
        </tr>
      </ItemTemplate>
      
      <FooterTemplate>
      <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\">���޼�¼</td></tr>" : ""%>
     
      <tr>
      <td colspan="9" bgcolor="#E2F1FC">
      <input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute; clip: rect(6 15 15 6)">
      <img src="/administrator/images/cms-ico12.gif" border="0">
      <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif" onclick="ImageButton_all_del_Click" style="width: 63px" OnClientClick="return window.confirm('ȷ��ɾ��������¼��?');"  />
      <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="/administrator/images/cms-ding.gif" onclick="ImageButton_ding_Click" style="width: 63px" />
      <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/administrator/images/cms-tuijian.gif" onclick="ImageButton_tuijian_Click" style="width: 63px" />
      <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/administrator/images/cms-K.gif" onclick="ImageButton_K_Click" style="width: 63px" />
      
      
      <span style="float:right">��ʾ <asp:TextBox ID="PageSize" OnTextChanged="PageSizeTextChanged" AutoPostBack="True" Text=<%#Application["PageSize"] %> runat="server" Width="30px" CssClass="txtInput"></asp:TextBox>��/ҳ</span>

      <center>
      <Script Language="JavaScript" type="text/JavaScript" src="/Administrator/js/page.js"></Script> 
          <script language="JavaScript">
						<!--
						var pg = new showPages('pg');
						pg.pageCount =<% =ViewState["PageCon"] %>;  // ������ҳ��(��Ҫ)
						pg.argName = 'page';  // ���������(��ѡ,Ĭ��Ϊpage)
						//document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
						pg.printHtml(1);
						//
						-->
          </script> 
          
       </center> 
       <div> ����ܹ�<% =ViewState["PageContent"]%>������</div> 
       </td>
    </tr>
  </table>
    </FooterTemplate>
    </asp:Repeater>

</form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_Product_admin" ValidateRequest="false" %>
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
        <td width="77%" nowrap><div class="tiao_con"> <a href="/administrator/objet/xclass.aspx?Classkind=<% =this.ClassKind %>"><img align="absmiddle" src="/administrator/images/nv6.png" />�����Ϣ</a> 
        <a href="/administrator/objet/admin.aspx?Classkind=<% =this.ClassKind %>"><img align="absmiddle" src="/administrator/images/nv8.png" />������Ϣ</a> 
        <a href='/administrator/class/index.aspx?ClassKind=<% =ClassKind %>'><img align="absmiddle" src="/administrator/images/nv9.png" />�������</a> 

        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    
      <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:0px; margin-top:5px;">
        <tr>
          <td width="15%" nowrap>
          <img src="/administrator/images/funnel.png" width="16" height="16" align="absmiddle">
           ɸѡ<asp:DropDownList ID="DdlMenu" runat="server" CssClass="input" 
                  Width="200px" AutoPostBack="True" 
                  onselectedindexchanged="DdlMenu_SelectedIndexChanged"></asp:DropDownList>
          </td>
          <td width="60%" align="left" nowrap><img src="/administrator/images/date_magnify.gif" width="16" height="16" align="absmiddle">
            <a href="?day=0&ClassKind=<% =this.ClassKind %>">����</a> 
            <a href="?day=1&ClassKind=<% =this.ClassKind %>">����</a> 
            <a href="?day=2&ClassKind=<% =this.ClassKind %>">ǰ��</a> 
            <a href="?day=3&ClassKind=<% =this.ClassKind %>">����</a> 
            </td>
          <td width="25%" align="right" nowrap><table border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td nowrap><img src="/administrator/images/cms-ico7.gif" width="12" height="11" align="absmiddle"> �ؼ��������� </td>
              <td nowrap><input name="keywords" id="keywords" type="text" class="input" style="width:120px;height:21px" title="�������ű���ؼ��ʽ���������" runat="server"></td>
              <td align="right" width="40"> 
                  <asp:Button ID="Submit" CssClass="bt" runat="server" Text="����" onclick="Submit_Click" /></td>
            </tr>
          </table></td>
        </tr>
      </table>
      

      <table cellpadding="5" cellspacing="1" border="0" width="100%"  class="Tb" style="margin-right:5px; margin-bottom:5px;margin-top:5px;" >
        <tr  id="tiao_center">
          <td width="23" nowrap><input  id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
          <td width="28" nowrap><span class="line">���</span></td>
          <td width="25" align="center" nowrap><span class="line">��Ŀ</span></td>
          <td><span class="line">����</span></td>
          <td width="43" nowrap><span class="line">����</span></td>
          <td width="90" nowrap><span class="line">¼������</span></td>
          <td width="65" nowrap><span class="line">�ö� | �Ƽ�</span></td>
          <td width="34" nowrap><span class="line">״̬</span></td>
          <td width="143" align="center" nowrap><span class="line">����</span></td>
        </tr>
        
        
            <asp:Repeater ID="Repeater_admin" runat="server">
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td height="25"  nowrap><asp:CheckBox ID="ID_list" runat="server" onclick="javascript:chkRow(this);" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("bh") %>'></asp:Label>
              </td>
              <td align="center" nowrap title='<%#get_classname(Convert.ToInt32(Eval("classname"))) %>'>
              <a  rel="facebox"  href="#classContent<%#Eval("bh") %>"><img src="/administrator/images/chart_organisation.png" border="0" title='<%#get_classname(Convert.ToInt32(Eval("classname"))) %>'></a>
              <div id="classContent<%#Eval("bh") %>" style="display:none;">
              <h3>��������</h3>
              <p>��������:[<%#Eval("classname") %>]<%#get_classname(Convert.ToInt32(Eval("classname"))) %></p>
              </div>
              </td>
              <td title='<%#Eval("title") %>'><%#Eval("pic").ToString() == "no" ? "" : "<img  rel=facebox href=/administrator/images/bullet_picture.png src=/administrator/images/bullet_picture.png title=����ͼ >"%><a  rel="facebox"  href='all.aspx?id=<%#Eval("bh") %>' title='<%#Eval("zhaiyao") %>'> <%#Eval("title") %> </a> <a rel="facebox" href="#zhaiyao<%#Eval("bh") %>"><img src="/administrator/images/tag.png" alt="�鿴ժҪ" border="0" title='<%#Eval("zhaiyao") %>'></a>
              <div id="zhaiyao<%#Eval("bh") %>" style="display:none;">
              <h3>��ϢժҪ</h3>
              <p><%#Eval("zhaiyao") %></p>
              </div>
                <a href='/app_xml/<%#Eval("type") %>/<%#Eval("bh") %>.xml' target="_blank"><img src="/administrator/images/bullet_feed.png" alt="�鿴XML���ݸ�ʽ" border="0" title='<%#Eval("zhaiyao") %>'></a></td>
              <td nowrap title='<%#Eval("author") %>'>
              <a rel="facebox" href="#author<%#Eval("bh") %>"><%#Eval("author")%></a>
               <div id="author<%#Eval("bh") %>" style="display:none;">
              <h3>��������</h3>
              <p><%#Eval("author") %></p>
              </div>
              </td>
              <td nowrap title='<%#Eval("time") %>'><%#Eval("time") != null?Convert.ToDateTime(Eval("time")).ToString("yyyy/MM/dd hh:mm"):"00"%></td>
              <td align="center" nowrap>
              <a href='?t=ding&id=<%#Eval("bh") %>&ding=<%#Eval("ding") %>&ClassKind=<% =this.ClassKind %>&page=<% =Request["page"] %>'><b><font color="#FF3300" title="����ö�"><%#Eval("ding").ToString().Trim()=="0"?"��":"X"%></font></b></a> 
              &nbsp;&nbsp;
               <a href='?t=tuijian&id=<%#Eval("bh") %>&tuijian=<%#Eval("tuijian") %>&ClassKind=<% =this.ClassKind %>&page=<% =Request["page"] %>'><b><font color="#FF3300" title="����Ƽ���"><%#Eval("tuijian").ToString().Trim()=="0"?"��":"X"%></font></b></a> 
              </td>
              <td align="center" nowrap><a href='?t=K&id=<%#Eval("bh") %>&K=<%#Eval("switchs") %>&ClassKind=<% =this.ClassKind %>&page=<% =Request["page"] %>'><b><font color="#FF3300" title="����رա�"><%#Eval("switchs").ToString().Trim()=="0"?"��":"X"%></font></b></a> </td>
              <td align="center" nowrap><a rel="facebox" href='all.aspx?id=<%#Eval("bh") %>'>����</a> | <a href='Remark.aspx?NewsId=<%#Eval("bh") %>'>����</a> | <a href='edit.aspx?id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =this.ClassKind %>'>�༭</a> | <a href='?t=del&id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =this.ClassKind %>' onClick="return window.confirm('ȷ��ɾ�� [<%#Eval("title") %>] ��?');">ɾ��</a></td>
            </tr>
          </ItemTemplate>
        </asp:Repeater>
        
        
        <tr>
          <td height="25" colspan="9" bgcolor="#E2F1FC">
            

            
            <input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute; clip: rect(6 15 15 6)">
            <img src="/administrator/images/cms-ico12.gif" border="0">
            <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif" onclick="ImageButton_all_del_Click" style="width: 63px" OnClientClick="return window.confirm('ȷ��ɾ��������¼��?');"  />      
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="/administrator/images/cms-ding.gif" onclick="ImageButton_ding_Click" style="width: 63px" />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/administrator/images/cms-tuijian.gif" onclick="ImageButton_tuijian_Click" style="width: 63px" />      
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/administrator/images/cms-K.gif" onclick="ImageButton_K_Click" style="width: 63px" />                
            
            
<center>
<Script Language="JavaScript" type="text/JavaScript" src="/Administrator/js/page.js"></Script>
<script language="JavaScript">
<!--
var pg = new showPages('pg');
pg.pageCount =<% =pages %>;  // ������ҳ��(��Ҫ)
pg.argName = 'page';  // ���������(��ѡ,Ĭ��Ϊpage)
//document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
pg.printHtml(1);
//
-->
</script>
�� [<span class="TabbedPanelsTabHover"><% = pages*30 %></span>] ������
</center>
            
            
          </td>
          </tr>
 </table>


</form>
</body>
</html>
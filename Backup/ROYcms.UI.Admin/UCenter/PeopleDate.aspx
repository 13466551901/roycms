
<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.PeopleDate" Title="��������" Codebehind="PeopleDate.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link rel="stylesheet" href="/administrator/editor/themes/default/default.css" />
<script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script>
<script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
<STYLE>
 .Tb td{
   font-size:12px;
   padding:3px;
 }
</STYLE>
    <div>
    <div id="Topnav_tags">
      <ul>
        <li>
          <a href="/ucenter/PeopleDate.aspx?S=0">��������</a>
        </li>
        <li>
          <a href="/ucenter/PeopleDate.aspx?S=1">��ϸ����</a>
        </li>
         <li>
          <a href="/ucenter/PeopleDate.aspx?S=2">�������˻�</a>
        </li>
       <li>
          <a href="/ucenter/PeopleDate.aspx?S=3">��ҵ��֤</a>
        </li>
         <li>
          <a href="/ucenter/PeopleDate.aspx?S=4">��־</a>
        </li>
      </ul>
    </div>
     <!--******************************��������********************************-->
      <%if (ROYcms.Common.Request.GetQueryInt("S") == 0)
        { %>
    
     <table width="477" border="0" align="center" cellpadding="10" cellspacing="0">
       <tr>
    <td width="128" align="center" valign="top"><table width="90%" border="0" align="center" cellpadding="0" cellspacing="3">
      <tr>
        <td align="center"><asp:Image ID="Photo_pic" CssClass="Photo_pic" runat="server" />
          </td>
      </tr>
      <tr>
        <td align="center">
        <a href="javascript:;" id="SitePhoto_pic">�����ҵ�ͷ��+</a>
        
          <script>
              KindEditor.ready(function (K) {
                  var editor = K.editor({
                      cssPath: '/Administrator/Editor/plugins/code/prettify.css',
                      uploadJson: '/Administrator/Editor/C/upload_json.ashx?root=Ucenter,Pic',
                      fileManagerJson: '/Administrator/Editor/C/file_manager_json.ashx?root=Ucenter,Pic',
                      allowFileManager: true
                  });
                  K('#SitePhoto_pic').click(function () {
                      editor.loadPlugin('image', function () {
                          editor.plugin.imageDialog({
                              imageUrl: K('.Photo_pic').attr("src"),
                              clickFn: function (url, title, width, height, border, align) {
                                  K('.Photo_pic').attr("src", url);
                                  editor.hideDialog();
                              }
                          });
                      });
                  });
              });
		                        </script>


        </td>
      </tr>
    </table></td>
    <td width="309"><table cellspacing="10" cellpadding="0" width="310" border="0">
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> ��¼���ƣ�</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
            <%= ROYcms.Common.Session.Get("user")%>
            <a href="#">�޸�</a>
            </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> ���룺</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
          ***<%=___ROYcms_user_bll.GetModel(Convert.ToInt32(ROYcms.Common.Session.Get("user_id"))).password.Remove(0, 3)%>
        <a href="#" onclick="window.open('update_password.aspx','Sample','toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=no,resizable=yes,copyhistory=yes,width=450,height=300,left=200,top=100')" >�޸�����</a>
        </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> QQ��</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
        <asp:TextBox CssClass="input_css" id="txtqq" runat="server" Width="200px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap">���䣺</td>
        <td width="170" height="25" align="left" nowrap="nowrap"><asp:TextBox CssClass="input_css" id="txtemail" runat="server" Width="200px"></asp:TextBox></td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> ���䣺</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
        <asp:TextBox CssClass="input_css" id="txtage" runat="server" Width="50px"></asp:TextBox></td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap">�Ա�</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
            <asp:DropDownList ID="DropDownList_sex" runat="server" CssClass="select" Width="50px">
                <asp:ListItem>��</asp:ListItem>
                <asp:ListItem Value="Ů"></asp:ListItem>
                <asp:ListItem>����</asp:ListItem>
            </asp:DropDownList>
          </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> ͷ�� ��</td>
        <td width="170" height="25" align="left" nowrap="nowrap"><asp:TextBox CssClass="input_css" id="txtpic" runat="server" Width="200px"></asp:TextBox></td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> �ǳƣ�</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
        <asp:TextBox CssClass="input_css" id="txtusername" runat="server" Width="200px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td height="25" nowrap="nowrap"></td>
        <td height="25" nowrap="nowrap">
        <asp:Button ID="btnUpdate" runat="server" Text="ȷ�ϱ༭" OnClick="btnUpdate_Click" CssClass="btnSubmit" ></asp:Button>
        </td>
      </tr>
    </table></td>
  </tr>
</table>
<%}  else if (ROYcms.Common.Request.GetQueryInt("S") ==1){%>


    <!--******************************��ϸ����********************************-->
  

                          <table width="477" border="0" align="center" cellpadding="0" cellspacing="6">
                <tr>
                  <td width="129" align="right">��ϵ��������</td>
                  <td width="330"><input type="text" class="txtInput" name="RealName" id="RealName" /></td>
                </tr>
                <tr>
                  <td align="right">��ϵ���ֻ���</td>
                  <td><input type="text" class="txtInput" name="Mobil" id="Mobil" /></td>
                </tr>
                <tr>
                <td align="right">�绰��</td>
                <td><input type="text" class="txtInput" name="Tel" id="Tel" /></td>
                </tr>
                <tr>
                <td align="right">��ַ��</td>
                <td><input name="Address" type="text" class="txtInput" id="Address" size="45" /></td>
                </tr>
                <tr>
                <td align="right">�ʱࣺ</td>
                <td><input type="text" class="txtInput" name="Postcode" id="Postcode" /></td>
                </tr>
                <tr>
                <td align="right">��վ��</td>
                <td><input type="text" class="txtInput" name="Website" id="Website" /></td>
                </tr>
                <tr>
                <td align="right">���֤���룺</td>
                <td><input name="IDcardNum" type="text" class="txtInput" id="IDcardNum" size="45" /></td>
                </tr>
                <tr>
                  <td align="right">&nbsp;</td>
                  <td><input type="button" name="button" id="button" value="ȷ�ϱ༭"  class="btnSubmit"/></td>
                </tr>

     </table>

        <%} else if (ROYcms.Common.Request.GetQueryInt("S") == 2)
        { %>

            <!--******************************�������˻�********************************-->
   
        �������˻�������

        <%}  else if (ROYcms.Common.Request.GetQueryInt("S") == 3)
        { %>
            <!--******************************��ҵ��֤********************************-->
     
        ��ҵ���������ޣ�����ϵ��վ����Ա��

        <%} else if (ROYcms.Common.Request.GetQueryInt("S") == 4)
        {  %>
                    <!--******************************��־********************************-->
      

                <asp:Repeater ID="Repeater_admin" runat="server">
        <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
              <TBODY>
                <TR id="tiao_center">
               
                  <TD width="28" nowrap><span class="line">���</span></TD>
            
                  <TD><span class="line">�¼�</span></TD>
              
                  <TD><span class="line">IP��ַ</span></TD>
                  <TD><span class="line">����ʱ��</span></TD>
                </TR>
        </HeaderTemplate>
          <ItemTemplate>
            <tr  onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
             
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
              <td><%#Eval("Event")%></td>
           
              <td><a rel="facebox" href='/app_api/AJAXIP.aspx?ip=<%#Eval("Ip")%>'><%#Eval("Ip")%></a></td>
              <td><%#Eval("Time")%></td>
            </tr>
          </ItemTemplate>
          <FooterTemplate>
          <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\">���޼�¼</td></tr>" : ""%>
                  </TBODY>
                </TABLE>
          </FooterTemplate>
        </asp:Repeater>

        <%} %>
    </div>
</asp:Content>

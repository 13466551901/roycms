<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.Default" Title="��������" Codebehind="Default.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script>    $("#current").parent().addClass("hover");</script>
    <div id="Topnav_tags">
      <ul>
        <li>
          <a href="?S=0">վ�ڹ���</a>
        </li>
        <li>
          <a href="?S=1">�ҵ�Ͷ����</a>
        </li>
      </ul>
    </div>
    <dl class="feed_block">

     <%if (ROYcms.Common.Request.GetQueryInt("S") == 0)
       {%>
      <asp:Repeater ID="Repeater_list" runat="server">
        <ItemTemplate>
          <dt class="current">
            <a>����:</a>
            [<%#___ROYcms_class_Bll.GetClassField(Convert.ToInt32(___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "classname")), "ClassName")%>]
            <a rel="facebox" href='/administrator/objet/all.aspx?id=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "bh")%>' ><%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "title")%></a>
            <span class="font_666"> <%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "time")%></span></dt>
          <dd> <%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "zhaiyao")%> <img src="images/quote-end.gif" width="14" height="10" /></dd>
        </ItemTemplate>
          <FooterTemplate>
              <%#Repeater_list.Items.Count == 0 ? "���޼�¼" : ""%>
                  </TBODY>
                </TABLE>
            </FooterTemplate>
      </asp:Repeater>
      <%}
       else if (ROYcms.Common.Request.GetQueryInt("S") == 1)
       {%>
       Ͷ������ϢΪ��δ����ͨͶ�ݡ�
        <%} %>
    </dl>

</asp:Content>

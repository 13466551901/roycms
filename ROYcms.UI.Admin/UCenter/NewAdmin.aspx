
<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.NewAdmin" Title="�ѷ�����Ϣ����" Codebehind="NewAdmin.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
<dl class="feed_block" style="margin-left:15px;">

 <asp:Repeater ID="Repeater_list" runat="server">
        <ItemTemplate>
          <dt class="current">
            <a>����:</a>
            [<%#___ROYcms_class_Bll.GetClassField(Convert.ToInt32(___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "classname")), "ClassName")%>]
            <a rel="facebox" href='/administrator/objet/all.aspx?id=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "bh")%>' ><%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "title")%></a>
            
            | <a target=_blank  href='/administrator/objet/edit.aspx?id=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "bh")%>&class=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "classname")%>&ClassKind=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "type")%>'>�༭</a>
            | <a href='?t=del&id=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "bh")%>&class=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "classname")%>&ClassKind=<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "type")%>' onClick="return window.confirm('ȷ��ɾ�� [<%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "title")%>] ��?');">ɾ��</a>
            <span class="font_666"> <%#___ROYcms_news_Bll.GetField(Convert.ToInt32(Eval("New_id")), "time")%></span></dt>
        </ItemTemplate>
      </asp:Repeater>

</dl>

 
</asp:Content>
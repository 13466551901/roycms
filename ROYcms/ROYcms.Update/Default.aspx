<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ROYcms.Update._Default" %>
<%@ Register src="_header.ascx" tagname="_header" tagprefix="uc1" %>
<%@ Register src="_foot.ascx" tagname="_foot" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>ROYcms!NT ����ƽ̨</title>
<link href="css/css.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
  <div id="wrap">
   <uc1:_header ID="_header1" runat="server" />  
    <div id="list-selected"><img src="Images/page_white_csharp.png" /> ÿ��һ�䣺</div>
    <h1 class="biaoti">
      <div class="code_name">������������</div>
    </h1>
    <div class="main">
      <div class="left">
        <asp:AdRotator ID="AdRotator1" runat="server"  DataSourceID="XmlDataSource_ads" />
        <asp:XmlDataSource ID="XmlDataSource_ads" runat="server" DataFile="~/App_Data/ads/ads.xml"></asp:XmlDataSource>
        <br />
        ���¼�¼
        �汾���
        �����Ŷ�
        ��������
        ��Դ����
        ��Ȩ��ѯ
        �ҵĹ���
        �����߿�ʼ����
        ��û�м������Թ������
        ���м���Ҫ����Դ��
        
        ������ͳ��
        
        
        �Ƽ�ƽ������Ŷ�
        �Ƽ���������Ŷ�  
          
        </div>
      <div class="right"></div>
    </div>
<uc2:_foot ID="_foot1" runat="server" />
  </div>
</form>
</body>
</html>

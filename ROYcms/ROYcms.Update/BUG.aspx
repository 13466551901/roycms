<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="BUG.aspx.cs" Inherits="ROYcms.Update.BUG" %>
<%@ Register src="_header.ascx" tagname="_header" tagprefix="uc1" %>
<%@ Register src="_foot.ascx" tagname="_foot" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>ROYcms!NT ����ƽ̨</title>
<link href="css/css.css" rel="stylesheet" type="text/css" />
<script src="/Administrator/WebUI/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/Administrator/WebUI/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<link href="/Administrator/WebUI/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/Administrator/WebUI/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" action="administrator/xml/FromXml.aspx">
  <div id="wrap">
   <uc1:_header ID="_header" runat="server" />  
    <div id="list-selected"><img src="Images/page_white_csharp.png" /> ÿ��һ�䣺</div>
    <h1 class="biaoti">
      <div class="code_name">BUG����</div>
    </h1>
    <div class="main">
      <div class="left"><br />
        <br />
        <span id="sprytextfield1">
        <label>BUG����[�������������]��
          <input type="text" name="BUG����" id="BUG����" />
        </label>
      <span class="textfieldRequiredMsg">��Ҫ�ṩһ��ֵ��</span></span><span id="sprytextarea1">
      <label><br />
        BUG���������[��ϸ����]��
          <textarea name="BUG��������[��ϸ����]" id="BUG��������[��ϸ����]" cols="45" rows="8"></textarea>
      </label>
      <span class="textareaRequiredMsg">��Ҫ�ṩһ��ֵ��</span></span>
      <label>
        ȷ��
        <input type="submit" name="ȷ��" id="ȷ��" value="�ύ" />
      </label>
<br />
      <br />
      <br />
      </div>
      <div class="right"></div>
    </div>
<uc2:_foot ID="_foot1" runat="server" />

  </div>
    </form>
<script type="text/javascript">
<!--
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1");
//-->
</script>
</body>
</html>

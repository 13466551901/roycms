<script Language="C#" runat="server">
void Page_Load(Object sender, EventArgs E){  
//��Ҫ���ܲ���
//������   orderId 
//�۸�     orderAmount 
//��Ʒ���� productName
//����     productNum
//
    
    
	//ȫ�ֲ��� ��������
    String IndexUrl = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host");
    String signMsg ="";
    String orderId=Request["orderId"];
	String orderAmount=Request["orderAmount"];
	 //String productName=Server.UrlEncode(Request["productName"]==null?"":Request["productName"]).ToLower();
   String productName = "__";
	String productNum=Request["productNum"]==null?"":Request["productNum"];
	
    if(orderId!=null&&orderAmount!=null){
	//String URL="";
	String signMsgVal="";

	signMsgVal=appendParam(signMsgVal,"inputCharset","1");
    signMsgVal = appendParam(signMsgVal, "pageUrl", "http://www.99bill.com/gateway/recvMerchantInfoAction.htm");
    signMsgVal = appendParam(signMsgVal, "bgUrl", IndexUrl + "Administrator/Payment/99bill/99bill_rt.aspx");
	signMsgVal=appendParam(signMsgVal,"version","v2.0");
	signMsgVal=appendParam(signMsgVal,"language","1");
	signMsgVal=appendParam(signMsgVal,"signType","4");

    signMsgVal = appendParam(signMsgVal, "merchantAcctId", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("merchantacct_id"));
	signMsgVal=appendParam(signMsgVal,"payerName","");
	signMsgVal=appendParam(signMsgVal,"payerContactType","1");
	signMsgVal=appendParam(signMsgVal,"payerContact","");

    signMsgVal = appendParam(signMsgVal, "orderId", orderId);
    signMsgVal = appendParam(signMsgVal, "orderAmount", (decimal.Parse(orderAmount)*100).ToString());
   
	signMsgVal=appendParam(signMsgVal,"orderTime",DateTime.Now.ToString("yyyyMMddHHmmss"));
    signMsgVal = appendParam(signMsgVal, "productName", productName);
    signMsgVal = appendParam(signMsgVal, "productNum", productNum);
	signMsgVal=appendParam(signMsgVal,"productId","");
	signMsgVal=appendParam(signMsgVal,"productDesc","");
    signMsgVal = appendParam(signMsgVal, "ext1", Request["k"]);
	signMsgVal=appendParam(signMsgVal,"ext2","");
    signMsgVal=appendParam(signMsgVal,"payType","00");	    
	signMsgVal=appendParam(signMsgVal,"redoFlag","0");
	signMsgVal=appendParam(signMsgVal,"pid","");



    //signMsgVal = appendParam(signMsgVal, "key", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("merchantacct_key"));

    //signMsg = GetMD5(signMsgVal, "utf-8").ToUpper();


    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(signMsgVal);
    System.Security.Cryptography.X509Certificates.X509Certificate2 cert = new System.Security.Cryptography.X509Certificates.X509Certificate2(HttpContext.Current.Server.MapPath("tester-rsa.pfx"), "wangteng", System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.MachineKeySet);
    System.Security.Cryptography.RSACryptoServiceProvider rsapri = (System.Security.Cryptography.RSACryptoServiceProvider)cert.PrivateKey;
    System.Security.Cryptography.RSAPKCS1SignatureFormatter f = new System.Security.Cryptography.RSAPKCS1SignatureFormatter(rsapri);
    byte[] result;
    f.SetHashAlgorithm("SHA1");
    System.Security.Cryptography.SHA1CryptoServiceProvider sha = new System.Security.Cryptography.SHA1CryptoServiceProvider();
    result = sha.ComputeHash(bytes);
    signMsg = System.Convert.ToBase64String(f.CreateSignature(result)).ToString();

    //Response.Write("https://www.99bill.com/gateway/recvMerchantInfoAction.htm?" + signMsgVal + "&signMsg=" + Server.UrlEncode(signMsg)));
    Response.Redirect("https://www.99bill.com/gateway/recvMerchantInfoAction.htm?" + signMsgVal + "&signMsg=" + Server.UrlEncode(signMsg));
        
    }
	else{Response.Write("������orderId�������š��Ͳ�����orderAmount���۸񡿲���Ϊ��");}
}
	//���ܺ�����������ֵ��Ϊ�յĲ�������ַ���
#region �ַ�����������
public string appendParam(string returnStr, string paramId, string paramValue)
{
    if (returnStr != "")
    {
        if (paramValue != "")
        {
            returnStr += "&" + paramId + "=" + paramValue;
        }
    }
    else
    {
        if (paramValue != "")
        {
            returnStr = paramId + "=" + paramValue;
        }
    }
    return returnStr;
}
#endregion
    //���ܺ��������ַ������б����ʽת����������MD5���ܣ�Ȼ�󷵻ء���ʼ
   
    private static string GetMD5(string dataStr, string codeType)
    {
        System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] t = md5.ComputeHash(System.Text.Encoding.GetEncoding(codeType).GetBytes(dataStr));
        System.Text.StringBuilder sb = new System.Text.StringBuilder(32);
        for (int i = 0; i < t.Length; i++)
        {
            sb.Append(t[i].ToString("x").PadLeft(2, '0'));
        }
        return sb.ToString();
    }
     
    //���ܺ��������ַ������б����ʽת����������MD5���ܣ�Ȼ�󷵻ء�����
    
</script>


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

    String orderId=Request["orderId"];
	String orderAmount=Request["orderAmount"];
	String productName=Request["productName"]==null?"":Request["productName"];
	String productNum=Request["productNum"]==null?"":Request["productNum"];
	
    if(orderId!=null&&orderAmount!=null){
	String URL="";
	String signMsgVal="";

	signMsgVal=appendParam(signMsgVal,"inputCharset","1");
    signMsgVal = appendParam(signMsgVal, "bgUrl", IndexUrl + "Administrator/Payment/99bill/99bill_rt.aspx");
	signMsgVal=appendParam(signMsgVal,"version","v2.0");
	signMsgVal=appendParam(signMsgVal,"language","1");
	signMsgVal=appendParam(signMsgVal,"signType","1");

    signMsgVal = appendParam(signMsgVal, "merchantAcctId", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("merchantacct_id"));
	signMsgVal=appendParam(signMsgVal,"payerName","");
	signMsgVal=appendParam(signMsgVal,"payerContactType","");
	signMsgVal=appendParam(signMsgVal,"payerContact","");

    signMsgVal = appendParam(signMsgVal, "orderId", orderId);
    signMsgVal = appendParam(signMsgVal, "orderAmount", (decimal.Parse(orderAmount)*100).ToString());
	signMsgVal=appendParam(signMsgVal,"orderTime",DateTime.Now.ToString("yyyyMMddHHmmss"));
    signMsgVal = appendParam(signMsgVal, "productName", productName);
    signMsgVal = appendParam(signMsgVal, "productNum", productNum);
	signMsgVal=appendParam(signMsgVal,"productId","");
	signMsgVal=appendParam(signMsgVal,"productDesc","");
	signMsgVal=appendParam(signMsgVal,"ext1","");
	signMsgVal=appendParam(signMsgVal,"ext2","");
	signMsgVal=appendParam(signMsgVal,"payType","10");	
	signMsgVal=appendParam(signMsgVal,"redoFlag","");
	signMsgVal=appendParam(signMsgVal,"pid","");
	
	URL =signMsgVal;
    signMsgVal = appendParam(signMsgVal, "key", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("merchantacct_key"));
    signMsgVal = GetMD5(signMsgVal, "utf-8").ToUpper();


    //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(signMsgVal);
    //X509Certificate2 cert = new X509Certificate2(HttpContext.Current.Server.MapPath("tester-rsa.pfx"), "1qaz2wsx", X509KeyStorageFlags.MachineKeySet);
    //RSACryptoServiceProvider rsapri = (RSACryptoServiceProvider)cert.PrivateKey;
    //RSAPKCS1SignatureFormatter f = new RSAPKCS1SignatureFormatter(rsapri);
    //byte[] result;
    //f.SetHashAlgorithm("SHA1");
    //SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
    //result = sha.ComputeHash(bytes);
    //signMsg = System.Convert.ToBase64String(f.CreateSignature(result)).ToString();
        
        
    Response.Redirect("https://www.99bill.com/gateway/recvMerchantInfoAction.htm?"+URL+"&signMsg="+signMsgVal);
    }
	else{Response.Write("������orderId�������š��Ͳ�����orderAmount���۸񡿲���Ϊ��");}
}
	//���ܺ�����������ֵ��Ϊ�յĲ�������ַ���
	String appendParam(String returnStr,String paramId,String paramValue){

		if(returnStr!=""){
			
				if(paramValue!=""){
					
					returnStr+="&"+paramId+"="+paramValue;
				}
			
		}else{
			
			if(paramValue!=""){
				returnStr=paramId+"="+paramValue;
			}
		}
		
		return returnStr;
	}
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


using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Rss ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Rss
	{
		public ROYcms_Rss()
		{}
		#region Model
		private int _id;
		private int? _user_id;
		private string _name;
		private string _zhaiyao;
		private string _encode;
		private string _url;
		private DateTime? _time;
		/// <summary>
		/// ���
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// �û�ID
		/// </summary>
		public int? User_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// ���� ������
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ժҪ
		/// </summary>
		public string zhaiyao
		{
			set{ _zhaiyao=value;}
			get{return _zhaiyao;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Encode
		{
			set{ _encode=value;}
			get{return _encode;}
		}
		/// <summary>
		/// URL ��ַ
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// ʱ�� ����
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}


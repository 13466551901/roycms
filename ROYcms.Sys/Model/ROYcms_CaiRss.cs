using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_CaiRss ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_CaiRss
	{
		public ROYcms_CaiRss()
		{}
		#region Model
		private int _id;
		private string _rssurl;
		private string _encode;
		private string _htmlstar;
		private string _htmlend;
		private string _path;
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
		/// RSS��ַ
		/// </summary>
		public string RssUrl
		{
			set{ _rssurl=value;}
			get{return _rssurl;}
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
		/// ��ʼURl��ǩ
		/// </summary>
		public string HtmlStar
		{
			set{ _htmlstar=value;}
			get{return _htmlstar;}
		}
		/// <summary>
        /// ����URl��ǩ
		/// </summary>
		public string HtmlEnd
		{
			set{ _htmlend=value;}
			get{return _htmlend;}
		}
		/// <summary>
		/// ��ַ
		/// </summary>
		public string Path
		{
			set{ _path=value;}
			get{return _path;}
		}
		/// <summary>
		/// ʱ��
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}


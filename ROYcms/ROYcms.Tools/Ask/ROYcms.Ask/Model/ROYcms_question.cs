using System;
namespace ROYcms.Ask.Model
{
	/// <summary>
	/// ʵ����ROYcms_question ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_question
	{
		public ROYcms_question()
		{}
		#region Model
		private int _bh;
		private string _title;
		private string _content;
		private string _tag;
		private int? _status;
		private int? _reward;
		private string _user_id;
		private string _type_id;
		private int? _hits;
		private DateTime? _star_time;
		private DateTime? _end_time;
		private string _ip;
		private int? _switchs;
		/// <summary>
		/// 
		/// </summary>
		public int bh
		{
			set{ _bh=value;}
			get{return _bh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? reward
		{
			set{ _reward=value;}
			get{return _reward;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? hits
		{
			set{ _hits=value;}
			get{return _hits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? star_time
		{
			set{ _star_time=value;}
			get{return _star_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? end_time
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? switchs
		{
			set{ _switchs=value;}
			get{return _switchs;}
		}
		#endregion Model

	}
}


using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Organization ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Organization
	{
		public ROYcms_Organization()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private string _name;
		private int? _classname;
		private string _keyword;
		private string _zhaiyao;
		private string _contents;
		private string _tag;
		private int? _hits;
		private int? _orders;
		private int? _tuijian;
		private int? _switchs;
		private string _type;
		private string _time;
		private string _guid;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int? classname
		{
			set{ _classname=value;}
			get{return _classname;}
		}
		/// <summary>
		/// �ؼ���
		/// </summary>
		public string keyword
		{
			set{ _keyword=value;}
			get{return _keyword;}
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
		public string contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// ��ǩ
		/// </summary>
		public string tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public int? hits
		{
			set{ _hits=value;}
			get{return _hits;}
		}
		/// <summary>
		/// Ȩ��
		/// </summary>
		public int? orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// �Ƿ��Ƽ�
		/// </summary>
		public int? tuijian
		{
			set{ _tuijian=value;}
			get{return _tuijian;}
		}
		/// <summary>
		/// ���ſ���
		/// </summary>
		public int? switchs
		{
			set{ _switchs=value;}
			get{return _switchs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		#endregion Model

	}
}


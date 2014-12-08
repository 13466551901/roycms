using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// �����ģ�ͱ��ϵ�� ROYcms_Class_Model �����ģ�ͱ��ϵ�� ROYcms_Class_Model
	/// </summary>
	[Serializable]
	public partial class ROYcms_Class_Model
	{
		public ROYcms_Class_Model()
		{}
		#region Model
		private int _id;
		private int? _mid;
		private int? _cid;
		private int? _uid;
		private int? _classid;
		private DateTime? _time= DateTime.Now;
		/// <summary>
		/// ��� ���
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ģ�ͱ�ID ģ�ͱ�ID
		/// </summary>
		public int? Mid
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// class�����ID class�����ID
		/// </summary>
		public int? Cid
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// �û���ID
		/// </summary>
		public int? Uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// ����������ֶ���չʱID
		/// </summary>
		public int? ClassID
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TIME
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}


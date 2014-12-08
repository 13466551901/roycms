using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Tag ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Tag
	{
		public ROYcms_Tag()
		{}
		#region Model
		private int _id;
		private string _tag;
		private DateTime? _time;
		private string _type;
		/// <summary>
		/// ���        
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��ǩ
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// ʱ��
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}


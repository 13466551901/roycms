using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Shares_News ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Shares_News
	{
		public ROYcms_Shares_News()
		{}
		#region Model
		private int _id;
		private int? _news_id;
		private string _typename;
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
		/// ���ű��
		/// </summary>
		public int? news_id
		{
			set{ _news_id=value;}
			get{return _news_id;}
		}
		/// <summary>
		/// �Ƽ�����
		/// </summary>
		public string typename
		{
			set{ _typename=value;}
			get{return _typename;}
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


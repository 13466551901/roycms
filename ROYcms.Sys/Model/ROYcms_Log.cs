using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ROYcms_Log:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class ROYcms_Log
	{
		public ROYcms_Log()
		{}
		#region Model
		private int _id;
		private int? _user_id;
		private int? _admin_id;
		private string _err_id;
		private string _event;
		private string _content;
		private DateTime? _time= DateTime.Now;
		private string _ip;
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
		/// ����ԱID
		/// </summary>
		public int? Admin_id
		{
			set{ _admin_id=value;}
			get{return _admin_id;}
		}
		/// <summary>
		/// ����id   ��ʶ 1����Ա��¼ 2��ͨ��Ա��¼ 3����Ա������־ 4��ͨ��Ա������־ 5������־
		/// </summary>
		public string Err_id
		{
			set{ _err_id=value;}
			get{return _err_id;}
		}
		/// <summary>
		/// �¼�
		/// </summary>
		public string Event
		{
			set{ _event=value;}
			get{return _event;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// ��Դip
		/// </summary>
		public string Ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		#endregion Model

	}
}


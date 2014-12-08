using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_WebGroupSubGroup ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_WebGroupSubGroup
	{
		public ROYcms_WebGroupSubGroup()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _domain;
		private string _keystring;
		private string _guid;
		private int? _state;
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
		/// վȺ����
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// վȺ��Χ ���� ��ʶ�ַ�
		/// </summary>
		public string Domain
		{
			set{ _domain=value;}
			get{return _domain;}
		}
		/// <summary>
		/// �ؼ��� �ַ�
		/// </summary>
		public string KeyString
		{
			set{ _keystring=value;}
			get{return _keystring;}
		}
		/// <summary>
		/// ȫ�ֱ�ʶ 
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		/// <summary>
		/// ״̬
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
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


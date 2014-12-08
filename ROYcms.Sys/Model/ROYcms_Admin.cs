using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Admin ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Admin
	{
		public ROYcms_Admin()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _password;
		private string _classkind;
		private int? _rol;
		/// <summary>
		/// ���
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// �û��� 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string classkind
		{
			set{ _classkind=value;}
			get{return _classkind;}
		}
		/// <summary>
		/// Ȩ�ޱ��
		/// </summary>
		public int? Rol
		{
			set{ _rol=value;}
			get{return _rol;}
		}
		#endregion Model

	}
}


using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_RolePath ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_RolePath
	{
		public ROYcms_RolePath()
		{}
		#region Model
		private int _id;
		private int? _roleid;
		private string _path;
		/// <summary>
		/// ���    
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// Ȩ��ID
		/// </summary>
		public int? RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// ��ַ
		/// </summary>
		public string path
		{
			set{ _path=value;}
			get{return _path;}
		}
		#endregion Model

	}
}


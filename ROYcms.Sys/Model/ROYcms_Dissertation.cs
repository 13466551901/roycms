using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Dissertation ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class ROYcms_Dissertation
	{
		public ROYcms_Dissertation()
		{}
		#region Model
		private int _id;
		private string _dissertation_name;
		private string _dissertation_content;
		private string _templet_url;
		/// <summary>
		/// ���
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ר������
		/// </summary>
		public string dissertation_name
		{
			set{ _dissertation_name=value;}
			get{return _dissertation_name;}
		}
		/// <summary>
		/// ר������
		/// </summary>
		public string dissertation_content
		{
			set{ _dissertation_content=value;}
			get{return _dissertation_content;}
		}
		/// <summary>
		/// ģ���ַ
		/// </summary>
		public string templet_url
		{
			set{ _templet_url=value;}
			get{return _templet_url;}
		}
		#endregion Model

	}
}


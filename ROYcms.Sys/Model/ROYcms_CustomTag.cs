using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_CustomTag ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class ROYcms_CustomTag
	{
		public ROYcms_CustomTag()
		{}
		#region Model
		private int _id;
		private string _tag;
		private string _tag_name;
		private string _tag_content;
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
		public string TAG
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// ��ǩ����
		/// </summary>
		public string TAG_name
		{
			set{ _tag_name=value;}
			get{return _tag_name;}
		}
		/// <summary>
		/// ��ǩ����
		/// </summary>
		public string TAG_content
		{
			set{ _tag_content=value;}
			get{return _tag_content;}
		}
		#endregion Model

	}
}


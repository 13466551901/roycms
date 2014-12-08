using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Class_News ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Class_News
	{
		public ROYcms_Class_News()
		{}
		#region Model
		private int _id;
        
		private int? _news_id;
        private int _Class;
		private string _class_id;
		private string _class_list;
		private DateTime? _time;
		private string _guid;
		/// <summary>
		/// ���
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ����ID
		/// </summary>
		public int? news_id
		{
			set{ _news_id=value;}
			get{return _news_id;}
		}
        /// <summary>
        /// �� ���
        /// </summary>
        public int Class
        {
            set { _Class = value; }
            get { return _Class; }
        }
		/// <summary>
		/// ��ID
		/// </summary>
		public string class_id
		{
			set{ _class_id=value;}
			get{return _class_id;}
		}
		/// <summary>
		/// ���б�
		/// </summary>
		public string class_list
		{
			set{ _class_list=value;}
			get{return _class_list;}
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
		/// ȫ��guid
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		#endregion Model

	}
}


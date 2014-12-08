using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_template ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class ROYcms_template
	{
		public ROYcms_template()
		{}
		#region Model
        private int _bh;
        private int _z_id;
		private string _name;
		private string _tag;
		private string _htmlcontent;
        private int? _y;
		private DateTime? _htmltimes;
        private string _class_name;
		/// <summary>
		/// ���        
		/// </summary>
		public int bh
		{
			set{ _bh=value;}
			get{return _bh;}
        }	
        /// <summary>
        /// ģ����ID
        /// </summary>
        public int z_id
        {
            set { _z_id = value; }
            get { return _z_id; }
        }
		/// <summary>
		/// ģ������
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ��ǩ
		/// </summary>
		public string tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// HTML ����
		/// </summary>
		public string htmlcontent
		{
			set{ _htmlcontent=value;}
			get{return _htmlcontent;}
		}
        /// <summary>
        /// �� name
        /// </summary>
        public string class_name
        {
            set { _class_name = value; }
            get { return _class_name; }
        }
        /// <summary>
        /// ״̬��ʶ
        /// </summary>
        public int? y
        {
            set { _y = value; }
            get { return _y; }
        }
		/// <summary>
		/// ʱ��
		/// </summary>
		public DateTime? htmltimes
		{
			set{ _htmltimes=value;}
			get{return _htmltimes;}
		}
		#endregion Model

	}
}


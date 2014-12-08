using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Enterprise ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Enterprise
	{
		public ROYcms_Enterprise()
		{}
        #region Model
        private int _bh;
        private int? _user_id;
        private string _keyword;
        private string _description;
        private string _gs_name;
        private string _gs_tel;
        private string _gs_address;
        private string _gs_web;
        private string _gs_email;
        private int? _classname;
        private int? _huangye_classname;
        private string _introduces;
        private string _business_scope;
        private string _intelligence_honor;
        private string _contacts_us;
        private string _enterprise_culture;
        private string _marketing_network;
        private string _other_1;
        private string _other_2;
        private string _other_3;
        private string _other_4;
        private DateTime? _time;
        private int? _switchs;
        private int? _template_id;
        /// <summary>
        /// 
        /// </summary>
        public int bh
        {
            set { _bh = value; }
            get { return _bh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// ��˾ҳ��ؼ���
        /// </summary>
        public string keyword
        {
            set { _keyword = value; }
            get { return _keyword; }
        }
        /// <summary>
        /// ��˾ҳ������
        /// </summary>
        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// ��˾����
        /// </summary>
        public string gs_name
        {
            set { _gs_name = value; }
            get { return _gs_name; }
        }
        /// <summary>
        /// ��˾�绰
        /// </summary>
        public string gs_tel
        {
            set { _gs_tel = value; }
            get { return _gs_tel; }
        }
        /// <summary>
        /// ��˾��ַ
        /// </summary>
        public string gs_address
        {
            set { _gs_address = value; }
            get { return _gs_address; }
        }
        /// <summary>
        /// ��˾��ַ
        /// </summary>
        public string gs_web
        {
            set { _gs_web = value; }
            get { return _gs_web; }
        }
        /// <summary>
        /// ��˾����
        /// </summary>
        public string gs_email
        {
            set { _gs_email = value; }
            get { return _gs_email; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int? classname
        {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// ��ҳ����
        /// </summary>
        public int? huangye_classname
        {
            set { _huangye_classname = value; }
            get { return _huangye_classname; }
        }
        /// <summary>
        /// ��˾���
        /// </summary>
        public string introduces
        {
            set { _introduces = value; }
            get { return _introduces; }
        }
        /// <summary>
        /// ҵ��Χ
        /// </summary>
        public string business_scope
        {
            set { _business_scope = value; }
            get { return _business_scope; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string intelligence_honor
        {
            set { _intelligence_honor = value; }
            get { return _intelligence_honor; }
        }
        /// <summary>
        /// ��ϵ����
        /// </summary>
        public string contacts_us
        {
            set { _contacts_us = value; }
            get { return _contacts_us; }
        }
        /// <summary>
        /// ��ҵ�Ļ�
        /// </summary>
        public string enterprise_culture
        {
            set { _enterprise_culture = value; }
            get { return _enterprise_culture; }
        }
        /// <summary>
        /// Ӫ������
        /// </summary>
        public string marketing_network
        {
            set { _marketing_network = value; }
            get { return _marketing_network; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string other_1
        {
            set { _other_1 = value; }
            get { return _other_1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string other_2
        {
            set { _other_2 = value; }
            get { return _other_2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string other_3
        {
            set { _other_3 = value; }
            get { return _other_3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string other_4
        {
            set { _other_4 = value; }
            get { return _other_4; }
        }
        /// <summary>
        /// ���̽���ʱ��
        /// </summary>
        public DateTime? time
        {
            set { _time = value; }
            get { return _time; }
        }
        /// <summary>
        /// ���ƿ���
        /// </summary>
        public int? switchs
        {
            set { _switchs = value; }
            get { return _switchs; }
        }
        /// <summary>
        /// ģ��id
        /// </summary>
        public int? template_id
        {
            set { _template_id = value; }
            get { return _template_id; }
        }
        #endregion Model

	}
}


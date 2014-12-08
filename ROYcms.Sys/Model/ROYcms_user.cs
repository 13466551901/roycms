using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_user ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class ROYcms_user
	{
		public ROYcms_user()
		{}
        #region Model
        private int _bh;
        private string _roleid;
        private string _ugroupid;
        private string _name;
        private string _password;
        private int? _money;
        private string _qq;
        private string _email;
        private int? _age;
        private DateTime? _login_time;
        private string _sex;
        private string _pic;
        private string _quanxian;
        private string _username;
        private string _guid;
        private string _ip;
        /// <summary>
        /// Ψһ��ʶ
        /// </summary>
        public int bh
        {
            set { _bh = value; }
            get { return _bh; }
        }
        /// <summary>
        /// Ȩ��ID
        /// </summary>
        public string RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public string UgroupID
        {
            set { _ugroupid = value; }
            get { return _ugroupid; }
        }
        /// <summary>
        /// �û���
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public int? money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// qq
        /// </summary>
        public string qq
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int? age
        {
            set { _age = value; }
            get { return _age; }
        }
        /// <summary>
        /// ע��ʱ��
        /// </summary>
        public DateTime? login_time
        {
            set { _login_time = value; }
            get { return _login_time; }
        }
        /// <summary>
        /// �Ա�
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// ����ͼ/ͷ��
        /// </summary>
        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
        /// <summary>
        /// Ȩ�ޱ�ʶ
        /// </summary>
        public string quanxian
        {
            set { _quanxian = value; }
            get { return _quanxian; }
        }
        /// <summary>
        /// �ǳ�
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// GUIDվȺȫ�ֱ�ʾ
        /// </summary>
        public string GUID
        {
            set { _guid = value; }
            get { return _guid; }
        }
        /// <summary>
        /// ip��ַ
        /// </summary>
        public string ip
        {
            set { _ip = value; }
            get { return _ip; }
        }
        #endregion Model

	}
}


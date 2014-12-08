using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����UserLogin
	/// </summary>
    [Serializable]
    public class UserLogin
    {
        public UserLogin()
        { }
        #region Model
        private string _username = null;//�û���
        private string _email = null;   //����
        private string _password = null;//����
        private string _k = null;       //��ݵ�½
        private string _valdates = null;//��֤��
        private string _Url = null;     //��½�󷵻�URL
        /// <summary>
        /// �û���
        /// </summary>
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// ��ݵ�¼����
        /// </summary>
        public string k
        {
            get { return _k; }
            set { _k = value; }
        }
        /// <summary>
        /// ��֤��
        /// </summary>
        public string valdates
        {
            get { return _valdates; }
            set { _valdates = value; }
        }
        /// <summary>
        /// ��¼�ɹ����صĵ�ַ
        /// </summary>
        /// <value>The URL.</value>
        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }
        #endregion Model

    }
}


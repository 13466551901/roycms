using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Role ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Role
	{
		public ROYcms_Role()
		{}
        #region Model
        private int _id;
        private string _name;
        private string _zhaiyao;
        private DateTime? _time;
        private string _guid;
        /// <summary>
        /// ���
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// Ȩ������
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// Ȩ������
        /// </summary>
        public string zhaiyao
        {
            set { _zhaiyao = value; }
            get { return _zhaiyao; }
        }
        /// <summary>
        /// ʱ��
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        /// <summary>
        /// ȫ�ֱ�ʶ
        /// </summary>
        public string GUID
        {
            set { _guid = value; }
            get { return _guid; }
        }
        #endregion Model

	}
}


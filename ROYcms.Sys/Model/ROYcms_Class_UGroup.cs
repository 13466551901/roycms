using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
    /// ʵ����ROYcms_Class_UGroup ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Class_UGroup
	{
        public ROYcms_Class_UGroup()
		{}
        #region Model
        private int _id;
        private int? _class_id;
        private int? _ugroup_id;
        private int? _user_id;
        private DateTime? _time;
        /// <summary>
        /// ���
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int? Class_id
        {
            set { _class_id = value; }
            get { return _class_id; }
        }
        /// <summary>
        /// �û�����
        /// </summary>
        public int? UGroup_id
        {
            set { _ugroup_id = value; }
            get { return _ugroup_id; }
        }
        /// <summary>
        /// �û����
        /// </summary>
        public int? User_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// ʱ��
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        #endregion Model

	}
}


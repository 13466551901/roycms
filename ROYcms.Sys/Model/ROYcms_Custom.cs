using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
    /// ���ݷ�����ROYcms_Custom
	/// </summary>
	public class ROYcms_Custom
	{
        /// <summary>
        ///  ���ݱ�����
        /// </summary>
        private string _TableName;
        /// <summary>
        ///  �����������  ������ ���ӣ�Id INTEGER,a1 VARCHAR(4000),a2 VARCHAR(4000)
        /// </summary>
        private string _Tablelist;
        /// <summary>
        /// ���¸�ʽ���� a1=11,a2=22,a3=33
        /// </summary>
        private string _UpdateList;
        /// <summary>
        /// ֵ˳�� ���磺var1,var2
        /// </summary>
        private string _InsertList;
        /// <summary>
        /// �ֶ�˳�� ���磺a1,a2
        /// </summary>
        private string _Tlist;
        /// <summary>
        /// ������ϢID��ʾ��ӦROYcms_news��id�ֶ�
        /// </summary>
        private int _newid;
        /// <summary>
        /// ����ID
        /// </summary>
        private int _Cid;
        /// <summary>
        ///   ���ݱ�����
        /// </summary>
        public string TableName
        {
            set { _TableName = value; }
            get { return _TableName; }
        }
        /// <summary>
        ///  �����������  ������ ���ӣ�Id INTEGER,a1 VARCHAR(4000),a2 VARCHAR(4000)
        /// </summary>
        public string Tablelist
        {
            set { _Tablelist = value; }
            get { return _Tablelist; }
        }
        /// <summary>
        /// ���¸�ʽ���� a1=11,a2=22,a3=33
        /// </summary>
        public string UpdateList
        {
            set { _UpdateList = value; }
            get { return _UpdateList; }
        }
        /// <summary>
        /// ֵ˳�� ���磺var1,var2
        /// </summary>
        public string InsertList
        {
            set { _InsertList = value; }
            get { return _InsertList; }
        }
        /// <summary>
        /// �ֶ�˳�� ���磺a1,a2
        /// </summary>
        public string Tlist
        {
            set { _Tlist = value; }
            get { return _Tlist; }
        }
        /// <summary>
        /// ������ϢID��ʾ��ӦROYcms_news��id�ֶ�
        /// </summary>
        public int newid
        {
            set { _newid = value; }
            get { return _newid; }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public int Cid
        {
            set { _Cid = value; }
            get { return _Cid; }
        }
	}
}


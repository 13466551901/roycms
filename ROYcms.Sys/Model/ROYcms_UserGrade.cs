using System;
namespace ROYcms.Sys.Model
{
    /// <summary>
    /// �û��ȼ���չ�� ���Ϊ1���û��ȼ�Ϊ��ʼ�����ݣ�����ɾ�����õȼ��ж�Ӧ�û�������ɾ����ɾ���ȼ�ʱ��ɾ����Ӧ�Ĳ�Ʒ�۸����ݡ�
    ///
    /// </summary>
    [Serializable]
    public partial class ROYcms_UserGrade
    {
        public ROYcms_UserGrade()
        { }
        #region Model
        private int _id;
        private string _gradename;
        private int _isorder = 0;
        private string _remark;
        /// <summary>
        /// ���
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// �ȼ�����
        /// </summary>
        public string GradeName
        {
            set { _gradename = value; }
            get { return _gradename; }
        }
        /// <summary>
        /// Ȩ��
        /// </summary>
        public int isOrder
        {
            set { _isorder = value; }
            get { return _isorder; }
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}




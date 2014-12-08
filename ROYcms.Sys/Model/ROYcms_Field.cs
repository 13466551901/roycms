using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// �Զ����ֶε��ֶα� ROYcms_Field �Զ����ֶε��ֶα� ROYcms_Field
	/// </summary>
	[Serializable]
	public partial class ROYcms_Field
	{
		public ROYcms_Field()
		{}
		#region Model
		private int _id;
		private int? _rid;
		private string _name;
		private string _lable;
		private int? _len;
		private int? _fieldtype;
		private int? _isnull;
		private int? _iskey;
		private string _defaultval;
		private int? _display;
		private string _expression;
		private string _inputtype;
		private int? _inputlen;
		private int? _orderby;
		private DateTime? _time= DateTime.Now;
		/// <summary>
		/// ��� ���
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ģ��ID����ROYcms_Model��id ģ��ID����ROYcms_Model��id
		/// </summary>
		public int? Rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// �ֶ����� �ֶ�����
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// �ֶε�Lable �ֶε�Lable
		/// </summary>
		public string Lable
		{
			set{ _lable=value;}
			get{return _lable;}
		}
		/// <summary>
		/// �ֶεĳ��� �ֶεĳ���
		/// </summary>
		public int? Len
		{
			set{ _len=value;}
			get{return _len;}
		}
		/// <summary>
		/// �ֶε����� �ֶε�����
		/// </summary>
		public int? FieldType
		{
			set{ _fieldtype=value;}
			get{return _fieldtype;}
		}
		/// <summary>
		/// �Ƿ�Ϊ�� �Ƿ�Ϊ��
		/// </summary>
		public int? IsNull
		{
			set{ _isnull=value;}
			get{return _isnull;}
		}
		/// <summary>
		/// �Ƿ�Ϊ���� �Ƿ�Ϊ����
		/// </summary>
		public int? IsKey
		{
			set{ _iskey=value;}
			get{return _iskey;}
		}
		/// <summary>
		/// Ĭ��ֵ Ĭ��ֵ
		/// </summary>
		public string DefaultVal
		{
			set{ _defaultval=value;}
			get{return _defaultval;}
		}
		/// <summary>
		/// ��ʾ�ɼ�״̬ ��ʾ�ɼ�״̬
		/// </summary>
		public int? Display
		{
			set{ _display=value;}
			get{return _display;}
		}
		/// <summary>
		/// ��ʾ���ʽ ��ʾ���ʽ
		/// </summary>
		public string Expression
		{
			set{ _expression=value;}
			get{return _expression;}
		}
		/// <summary>
		/// input����������
		/// </summary>
		public string InputType
		{
			set{ _inputtype=value;}
			get{return _inputtype;}
		}
		/// <summary>
		/// Input����ʾ����
		/// </summary>
		public int? InputLen
		{
			set{ _inputlen=value;}
			get{return _inputlen;}
		}
		/// <summary>
		/// OrderBy��ʾ˳�� OrderBy��ʾ˳��
		/// </summary>
		public int? OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// ʱ�� ʱ��
		/// </summary>
		public DateTime? TIME
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}


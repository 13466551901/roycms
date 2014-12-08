using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ����ģ�ͱ� ROYcms_Model ����ģ�ͱ� ROYcms_Model
	/// </summary>
	[Serializable]
	public partial class ROYcms_Model
	{
		public ROYcms_Model()
		{}
		#region Model
		private int _id;
		private int? _modeltype;
		private string _name;
		private string _tablename;
		private string _modeldescription;
		private DateTime? _time= DateTime.Now;
		/// <summary>
		/// ��� ʱ��
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ģ��Ӧ����ҵ���� ģ��Ӧ����ҵ����
		/// </summary>
		public int? ModelType
		{
			set{ _modeltype=value;}
			get{return _modeltype;}
		}
		/// <summary>
		/// ģ������ ģ������
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ģ�ʹ��������ݿ������� ģ�ʹ��������ݿ�������
		/// </summary>
		public string TableName
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// ģ������˵�� ģ������˵��
		/// </summary>
		public string ModelDescription
		{
			set{ _modeldescription=value;}
			get{return _modeldescription;}
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


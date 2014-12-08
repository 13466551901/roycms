using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_Workflow ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_Workflow
	{
		public ROYcms_Workflow()
		{}
		#region Model
		private int _id;
		private int? _keyid;
		private string _name;
		private string _zhaiyao;
		private DateTime? _time;
		/// <summary>
		/// ���
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// �ؼ���ID
		/// </summary>
		public int? keyId
		{
			set{ _keyid=value;}
			get{return _keyid;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ժҪ
		/// </summary>
		public string zhaiyao
		{
			set{ _zhaiyao=value;}
			get{return _zhaiyao;}
		}
		/// <summary>
		/// ʱ��
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}


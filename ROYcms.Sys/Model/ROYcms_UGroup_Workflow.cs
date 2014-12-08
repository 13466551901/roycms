using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ʵ����ROYcms_UGroup_Workflow ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ROYcms_UGroup_Workflow
	{
		public ROYcms_UGroup_Workflow()
		{}
		#region Model
		private int _id;
		private int? _ugroup_id;
		private int? _workflow_id;
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
		/// ������ID
		/// </summary>
		public int? UGroup_id
		{
			set{ _ugroup_id=value;}
			get{return _ugroup_id;}
		}
		/// <summary>
		/// Ȩ��ID
		/// </summary>
		public int? Workflow_id
		{
			set{ _workflow_id=value;}
			get{return _workflow_id;}
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


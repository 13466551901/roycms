using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// CMS
	/// </summary>
	public partial class CMS
	{
		private readonly ROYcms.Sys.DAL.CMS dal=new ROYcms.Sys.DAL.CMS();
		public CMS()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸñ�
		/// </summary>
		public bool Exists(string TableName)
		{
            return dal.Exists(TableName);
		}
         /// <summary>
        /// ɾ����
        /// </summary>
        public bool DelTable(string TableName)
        {
            return dal.DelTable(TableName);
        }
		#endregion  Method
	}
}


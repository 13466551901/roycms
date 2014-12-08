using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// ���ݷ�����:CMS
	/// </summary>
	public partial class CMS
	{
		public CMS()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���
		/// </summary>
		public bool Exists(string TableName)
		{
            return DbHelperSQL.TabExists(TableName);
            //StringBuilder strSql=new StringBuilder();
            //strSql.Append("select count(1) from sysobjects ");
            //strSql.Append(" where name='" + TableName + "' ");
            //return DbHelperSQL.Exists(strSql.ToString());
		}
        /// <summary>
        /// ɾ����
        /// </summary>
        public bool DelTable(string TableName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DROP TABLE "+ TableName);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0 ? true : false;
        }
        /// <summary>
        /// ɾ��һ��
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Column"></param>
        /// <returns></returns>
        public bool DelColumn(string TableName, string Column)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("alter TABLE " + TableName + " DROP " + Column);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0 ? true : false;
        }
        /// <summary>
        /// ����һ��
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Column"></param>
        /// <param name="Len"></param>
        /// <param name="Type"></param>
        /// <param name="IsNull"></param>
        /// <returns></returns>
        public bool DelColumn(string TableName, string Column,int Len,int Type,int IsNull)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("alter " + TableName + " add " + Column + " varchar(8) NULL; " + TableName + " DROP " + Column);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0 ? true : false;
        }
            

		#endregion  Method
	}
}


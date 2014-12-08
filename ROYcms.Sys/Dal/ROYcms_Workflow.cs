using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// ���ݷ�����ROYcms_Workflow��
	/// </summary>
	public class ROYcms_Workflow
	{
		public ROYcms_Workflow()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", PubConstant.date_prefix + "Workflow"); 
		}
        /// <summary>
        /// ��ȡ ����ֵ  �����ֶ�
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(int Id, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "Workflow");
            strSql.Append(" where id='" + Id + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Workflow");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Workflow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Workflow(");
			strSql.Append("keyId,name,zhaiyao,Time)");
			strSql.Append(" values (");
			strSql.Append("@keyId,@name,@zhaiyao,@Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@keyId", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.NChar,30),
					new SqlParameter("@zhaiyao", SqlDbType.NChar,80),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.keyId;
			parameters[1].Value = model.name;
			parameters[2].Value = model.zhaiyao;
			parameters[3].Value = model.Time;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_Workflow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Workflow set ");
			strSql.Append("keyId=@keyId,");
			strSql.Append("name=@name,");
			strSql.Append("zhaiyao=@zhaiyao,");
			strSql.Append("Time=@Time");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@keyId", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.NChar,30),
					new SqlParameter("@zhaiyao", SqlDbType.NChar,80),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.keyId;
			parameters[2].Value = model.name;
			parameters[3].Value = model.zhaiyao;
			parameters[4].Value = model.Time;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Workflow ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);

            /// <summary>
            /// ɾ����Ӧ�ĸ��¹��� 
            /// </summary>
            //ɾ���빤�����Ĺ��� 
            StringBuilder strSql2 = new StringBuilder();
            strSql2.Append("delete from ["+ PubConstant.date_prefix + "UGroup_Workflow] where Workflow_id =" + id);
            DbHelperSQL.ExecuteSql(strSql2.ToString());
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Workflow GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,keyId,name,zhaiyao,Time from " + PubConstant.date_prefix + "Workflow ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Workflow model=new ROYcms.Sys.Model.ROYcms_Workflow();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["keyId"].ToString()!="")
				{
					model.keyId=int.Parse(ds.Tables[0].Rows[0]["keyId"].ToString());
				}
				model.name=ds.Tables[0].Rows[0]["name"].ToString();
				model.zhaiyao=ds.Tables[0].Rows[0]["zhaiyao"].ToString();
				if(ds.Tables[0].Rows[0]["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,keyId,name,zhaiyao,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "Workflow ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,keyId,name,zhaiyao,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "Workflow ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

	
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = PubConstant.date_prefix + "Workflow";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  ��Ա����

        /// <summary>
        /// ���س���ѯ�������� ����ҳ�õ���
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "Workflow] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }
    }
}


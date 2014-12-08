using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// ���ݷ�����ROYcms_Tag��
	/// </summary>
	public class ROYcms_Tag
	{
		public ROYcms_Tag()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", PubConstant.date_prefix + "Tag"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Tag");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Tag model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Tag(");
			strSql.Append("Tag,Time,type)");
			strSql.Append(" values (");
			strSql.Append("@Tag,@Time,@type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Tag", SqlDbType.NVarChar,100),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@type", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Tag;
			parameters[1].Value = model.Time;
			parameters[2].Value = model.type;

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
		public void Update(ROYcms.Sys.Model.ROYcms_Tag model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Tag set ");
			strSql.Append("Tag=@Tag,");
			strSql.Append("Time=@Time,");
			strSql.Append("type=@type");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@Tag", SqlDbType.NVarChar,100),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@type", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.Tag;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.type;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Tag ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Tag GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,Tag,Time,type from " + PubConstant.date_prefix + "Tag ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Tag model=new ROYcms.Sys.Model.ROYcms_Tag();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.Tag=ds.Tables[0].Rows[0]["Tag"].ToString();
				if(ds.Tables[0].Rows[0]["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
				}
				model.type=ds.Tables[0].Rows[0]["type"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�  ���ظ�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select distinct Tag ");
			strSql.Append(" from " + PubConstant.date_prefix + "Tag ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
       /// <summary>
		/// ��������б� ���ظ�
		/// </summary>
		public DataSet GetListY(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,Tag,Time,type ");
			strSql.Append(" from " + PubConstant.date_prefix + "Tag ");
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
			strSql.Append(" id,Tag,Time,type ");
			strSql.Append(" from " + PubConstant.date_prefix + "Tag ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
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
			parameters[0].Value = PubConstant.date_prefix + "Tag";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}


using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//�����������
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// ���ݷ�����ROYcms_Class_UGroup
	/// </summary>
	public class ROYcms_Class_UGroup
	{
        public ROYcms_Class_UGroup()
		{}
        #region  ��Ա����
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "Class_UGroup");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Class_UGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "Class_UGroup(");
            strSql.Append("Class_id,UGroup_id,User_id,Time)");
            strSql.Append(" values (");
            strSql.Append("@Class_id,@UGroup_id,@User_id,@Time)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Class_id", SqlDbType.Int,4),
					new SqlParameter("@UGroup_id", SqlDbType.Int,4),
					new SqlParameter("@User_id", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.Class_id;
            parameters[1].Value = model.UGroup_id;
            parameters[2].Value = model.User_id;
            parameters[3].Value = model.Time;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public void Update(ROYcms.Sys.Model.ROYcms_Class_UGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Class_UGroup set ");
            strSql.Append("Class_id=@Class_id,");
            strSql.Append("UGroup_id=@UGroup_id,");
            strSql.Append("User_id=@User_id,");
            strSql.Append("Time=@Time");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@Class_id", SqlDbType.Int,4),
					new SqlParameter("@UGroup_id", SqlDbType.Int,4),
					new SqlParameter("@User_id", SqlDbType.Int,4),
					new SqlParameter("@Time", SqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.Class_id;
            parameters[2].Value = model.UGroup_id;
            parameters[3].Value = model.User_id;
            parameters[4].Value = model.Time;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Class_UGroup ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Class_UGroup GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,Class_id,UGroup_id,User_id,Time from " + PubConstant.date_prefix + "Class_UGroup ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            ROYcms.Sys.Model.ROYcms_Class_UGroup model = new ROYcms.Sys.Model.ROYcms_Class_UGroup();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Class_id"].ToString() != "")
                {
                    model.Class_id = int.Parse(ds.Tables[0].Rows[0]["Class_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UGroup_id"].ToString() != "")
                {
                    model.UGroup_id = int.Parse(ds.Tables[0].Rows[0]["UGroup_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_id"].ToString() != "")
                {
                    model.User_id = int.Parse(ds.Tables[0].Rows[0]["User_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Time"].ToString() != "")
                {
                    model.Time = DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Class_id,UGroup_id,User_id,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "Class_UGroup ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,Class_id,UGroup_id,User_id,Time ");
            strSql.Append(" from " + PubConstant.date_prefix + "Class_UGroup ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            parameters[0].Value = PubConstant.date_prefix + "Class_UGroup";
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


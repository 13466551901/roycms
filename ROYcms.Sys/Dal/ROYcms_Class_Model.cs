using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// ���ݷ�����:ROYcms_Class_Model
	/// </summary>
	public partial class ROYcms_Class_Model
	{
		public ROYcms_Class_Model()
		{}
		#region  Method

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Class_Model");
			strSql.Append(" where Id="+Id+" ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

        /// <summary>
        /// �Ƿ���ڸü�¼ ����ClassID
        /// </summary>
        public bool CidExists(int Cid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "Class_Model");
            strSql.Append(" where Cid=" + Cid + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Class_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.Mid != null)
			{
				strSql1.Append("Mid,");
				strSql2.Append(""+model.Mid+",");
			}
			if (model.Cid != null)
			{
				strSql1.Append("Cid,");
				strSql2.Append(""+model.Cid+",");
			}
			if (model.Uid != null)
			{
				strSql1.Append("Uid,");
				strSql2.Append(""+model.Uid+",");
			}
			if (model.ClassID != null)
			{
				strSql1.Append("ClassID,");
				strSql2.Append(""+model.ClassID+",");
			}
			if (model.TIME != null)
			{
				strSql1.Append("TIME,");
				strSql2.Append("'"+model.TIME+"',");
			}
			strSql.Append("insert into "+ PubConstant.date_prefix + "Class_Model(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			strSql.Append(";select @@IDENTITY");
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
        /// <summary>
        /// ����һ������
        /// </summary>
        public bool CidUpdate(ROYcms.Sys.Model.ROYcms_Class_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Class_Model set ");
            if (model.Mid != null)
            {
                strSql.Append("Mid=" + model.Mid + ",");
            }
            else
            {
                strSql.Append("Mid= null ,");
            }
            if (model.Cid != null)
            {
                strSql.Append("Cid=" + model.Cid + ",");
            }
            else
            {
                strSql.Append("Cid= null ,");
            }
            if (model.Uid != null)
            {
                strSql.Append("Uid=" + model.Uid + ",");
            }
            else
            {
                strSql.Append("Uid= null ,");
            }
            if (model.ClassID != null)
            {
                strSql.Append("ClassID=" + model.ClassID + ",");
            }
            else
            {
                strSql.Append("ClassID= null ,");
            }
            if (model.TIME != null)
            {
                strSql.Append("TIME='" + model.TIME + "',");
            }
            else
            {
                strSql.Append("TIME= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Cid=" + model.Cid + "");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Class_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Class_Model set ");
			if (model.Mid != null)
			{
				strSql.Append("Mid="+model.Mid+",");
			}
			else
			{
				strSql.Append("Mid= null ,");
			}
			if (model.Cid != null)
			{
				strSql.Append("Cid="+model.Cid+",");
			}
			else
			{
				strSql.Append("Cid= null ,");
			}
			if (model.Uid != null)
			{
				strSql.Append("Uid="+model.Uid+",");
			}
			else
			{
				strSql.Append("Uid= null ,");
			}
			if (model.ClassID != null)
			{
				strSql.Append("ClassID="+model.ClassID+",");
			}
			else
			{
				strSql.Append("ClassID= null ,");
			}
			if (model.TIME != null)
			{
				strSql.Append("TIME='"+model.TIME+"',");
			}
			else
			{
				strSql.Append("TIME= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where Id="+ model.Id+"");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public bool CidDelete(int Cid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Class_Model ");
            strSql.Append(" where Cid=" + Cid + "");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public bool MidDelete(int Mid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Class_Model ");
            strSql.Append(" where Mid=" + Mid + "");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Class_Model ");
			strSql.Append(" where Id="+Id+"" );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		
        /// <summary>
		/// ����ɾ������
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Class_Model ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Class_Model GetModel(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" Id,Mid,Cid,Uid,ClassID,TIME ");
			strSql.Append(" from " + PubConstant.date_prefix + "Class_Model ");
			strSql.Append(" where Id="+Id+"" );
			ROYcms.Sys.Model.ROYcms_Class_Model model=new ROYcms.Sys.Model.ROYcms_Class_Model();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Mid"]!=null && ds.Tables[0].Rows[0]["Mid"].ToString()!="")
				{
					model.Mid=int.Parse(ds.Tables[0].Rows[0]["Mid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Cid"]!=null && ds.Tables[0].Rows[0]["Cid"].ToString()!="")
				{
					model.Cid=int.Parse(ds.Tables[0].Rows[0]["Cid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Uid"]!=null && ds.Tables[0].Rows[0]["Uid"].ToString()!="")
				{
					model.Uid=int.Parse(ds.Tables[0].Rows[0]["Uid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ClassID"]!=null && ds.Tables[0].Rows[0]["ClassID"].ToString()!="")
				{
					model.ClassID=int.Parse(ds.Tables[0].Rows[0]["ClassID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TIME"]!=null && ds.Tables[0].Rows[0]["TIME"].ToString()!="")
				{
					model.TIME=DateTime.Parse(ds.Tables[0].Rows[0]["TIME"].ToString());
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
			strSql.Append("select Id,Mid,Cid,Uid,ClassID,TIME ");
			strSql.Append(" from " + PubConstant.date_prefix + "Class_Model ");
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
			strSql.Append(" Id,Mid,Cid,Uid,ClassID,TIME ");
			strSql.Append(" from " + PubConstant.date_prefix + "Class_Model ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
       /// <summary>
        /// ��ȡ����ֵ
       /// </summary>
       /// <param name="name"></param>
       /// <param name="strWhere"></param>
       /// <returns></returns>
        public string CidGetP(string name, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + name + " from " + PubConstant.date_prefix + "Class_Model ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj != null)
            {
                return Convert.ToString(obj);
            }
            else
            {
                return null;
            }
        }
		/// <summary>
		/// ��ȡ��¼����
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Class_Model ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from " + PubConstant.date_prefix + "Class_Model T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
	}
}


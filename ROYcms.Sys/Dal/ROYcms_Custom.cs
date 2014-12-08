using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//�����������
namespace ROYcms.Sys.DAL
{
	/// <summary>
    /// ���ݷ�����ROYcms_Custom
	/// </summary>
	public class ROYcms_Custom
	{
        ROYcms.Sys.Model.ROYcms_Custom model = new ROYcms.Sys.Model.ROYcms_Custom();
        /// <summary>
        /// ��Ա����
        /// </summary>
        public ROYcms_Custom()
		{}
		#region  ��Ա����

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="Id"></param>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public ROYcms.Sys.Model.ROYcms_Custom SetVal(System.Web.UI.Page page,int Id,int Cid) 
        {
            //ѭ���õ����������� 
            model.Tlist = null;
            model.InsertList = null;
            model.UpdateList = null;
            model.newid = Id;
            model.Cid = Cid;

            for (int i = 0; i < page.Request.Form.Count; i++)
            {
                if (page.Request.Form.GetKey(i).Contains("ROYcms_") && !page.Request.Form.GetKey(i).Contains("ROYcms__R"))
                {
                    model.Tlist += page.Request.Form.GetKey(i).Replace("ROYcms_", "") + ","; //�еļ���
                    model.InsertList += "'" + page.Request.Form.Get(i) + "',";//Insertֵ�ļ���
                    model.UpdateList += page.Request.Form.GetKey(i).Replace("ROYcms_", "") + "='" + page.Request.Form.Get(i) + "',";//Upadate��ֵ�Լ���
                }
            }
            //����Ĭ���ֶθ�ֵ
            if (model.UpdateList != null)
            {
                model.UpdateList = model.UpdateList + "Id='" + model.newid + "',Cid='" + model.Cid + "'";
            }
            if (model.InsertList != null)
            {
                model.InsertList = model.InsertList + "'" + model.newid + "','" + model.Cid + "'";
            }
            if (model.Tlist != null)
            {
                model.Tlist = model.Tlist + "Id,Cid";
             
            }
            return model;
        }
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int Id,string TableName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + TableName);
            strSql.Append(" where Id="+Id);

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString());
        }
        /// <summary>
        /// �������ݱ��
        /// </summary>
        /// <param name="TableName">�������</param>
        /// <param name="Tablelist">������ ���ӣ�Id INTEGER,a1 VARCHAR(4000),a2 VARCHAR(4000)</param>
        /// <returns></returns>
        public int CreateTable(string TableName, string Tablelist)
        {
            //�ж����ݿ���Ƿ������� select * from master.dbo.sysdatabases where name='����'

            model.TableName = TableName;
            string CreateTableSql = "create table " + TableName + " (" + Tablelist + ");";
            return DbHelperSQL.ExecuteSql(CreateTableSql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int CreateTable(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            //�ж����ݿ���Ƿ������� select * from master.dbo.sysdatabases where name='����'
            string CreateTableSql = "create table " + models.TableName + " (" + models.Tablelist + ");";
            return DbHelperSQL.ExecuteSql(CreateTableSql);
        }
        /// <summary>
        /// ��������Լ��
        /// </summary>
        /// <param name="TableName">�������</param>
        /// <param name="Key">�ֶ�</param>
        /// <returns>������Ӱ�����</returns>
        public int Key(string TableName,string Key)
        {
            string CreateTableSql = " alter  table " + TableName + " add constraint PK_" + TableName + "_Id primary key ("+Key+")";
            return DbHelperSQL.ExecuteSql(CreateTableSql);
        }
	    /// <summary>
        ///  ����һ������
	    /// </summary>
        /// <param name="TableName"> ������ </param>
        /// <param name="Tlist">�ֶ�˳�� ���磺a1,a2</param>
        /// <param name="InsertList">ֵ˳�� ���磺var1,var2</param>
	    /// <returns></returns>
        public int Add(string TableName, string Tlist, string InsertList)
		{
            string InsertSql = "insert into " + TableName + " (" + Tlist + ") values (" + InsertList + ")";
            return DbHelperSQL.ExecuteSql(InsertSql);
		}
        /// <summary>
        ///  ����һ�����ݸ��ݱ��ṹ
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Add(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            string InsertSql = "insert into " + models.TableName + " (" + models.Tlist + ") values (" + models.InsertList + ")";
            return DbHelperSQL.ExecuteSql(InsertSql);
        }
        /// <summary>
        /// ����һ���ֶ�
        /// </summary>
        /// <param name="Id">����ID</param>
        /// <param name="Cid">����ID</param>
        /// <param name="Name">�ֶ�����</param>
        /// <returns></returns>
        public string GetVal(int Id,int Cid,string Name)
        {
            string Val = null;
              
                string TableName = GetTableName(Cid);  //�õ�����
                if (TableName != null) 
                {
                    string Sql = "select " + Name + " from " + TableName + " where Id=" + Id;
                    object obj = ROYcms.DB.DbHelpers.GetSingle(Sql);
                    if (obj != null) { Val = Convert.ToString(obj); }
                }
                return Val;
            
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�����ֶ�����
        /// </summary>
        /// <param name="Cid"></param>
        /// <param name="Field"></param>
        /// <returns></returns>
        public string[] GetTableList(int Cid,string Field) {
            string[] TableLists = null;
            string TableList = null;
            string Mid = new ROYcms.Sys.BLL.ROYcms_Class_Model().CidGetP("Mid", "Cid=" + Cid);
            if (Mid != null)
            {
                DataSet FieldDs = new ROYcms.Sys.BLL.ROYcms_Field().GetList("Rid=" + Mid);
                if (FieldDs.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow Dr in FieldDs.Tables[0].Rows)
                    {
                        string Name = Dr["Name"].ToString();//�ֶ�����
                        string NameC = Dr[Field].ToString();//�ֶ�����
                        if (!Name.Contains("_R"))//ȥ��Ĭ�ϵ��ֶν��б�Ĵ���
                        {
                            TableList += NameC + ",";
                        }
                    }
                }
            }
            if (TableList != null)
            {
                TableList = TableList.Substring(0, TableList.Length - 1);
                TableLists = TableList.Split(',');//�б�����
            }
            return TableLists;
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�������ܹ�����ı���
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string GetTableName(int Cid)
        {
            //�õ�����
            string TableName = null;
            string Mid = new ROYcms.Sys.BLL.ROYcms_Class_Model().CidGetP("Mid", "Cid=" + Cid);//�õ�ģ��ID
            if (new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Mid)) != null)
            {
                TableName = new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Mid)).TableName;
            }
            return TableName;
        }
		/// <summary>
		/// ����һ������
		/// </summary>
        /// <param name="id">��������������������ID </param>
        /// <param name="UpdateList">���¸�ʽ���� a1=11,a2=22,a3=33 </param>
        /// <param name="TableName"> ������ </param>
        public int Update(int id, string UpdateList, string TableName)
		{
            string UpdateSql = "update " + TableName + " set " + UpdateList + " where Id =" + id;
            return DbHelperSQL.ExecuteSql(UpdateSql);
		}
        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Update(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            string UpdateSql = "update " + models.TableName + " set " + models.UpdateList + " where Id =" + models.newid;
            return DbHelperSQL.ExecuteSql(UpdateSql);
        }

		#endregion  ��Ա����
	}
}


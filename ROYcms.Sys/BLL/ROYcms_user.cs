using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using ROYcms.DB;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_user ��ժҪ˵����
	/// </summary>
	public class ROYcms_user
	{
		private readonly ROYcms.Sys.DAL.ROYcms_user dal=new ROYcms.Sys.DAL.ROYcms_user();
		public ROYcms_user()
		{}
		#region  ��Ա����

        ///// <summary>
        ///// �õ����ID
        ///// </summary>
        //public int GetMaxId()
        //{
        //    return dal.GetMaxId();
        //}
        /// <summary>
        /// ��ȡ ����ֵ  �����ֶ�
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(int Id, string Field)
        {
            return dal.GetField(Id, Field);
        }
        /// ��ȡ ����ֵ  �����ֶ� �����û���
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(string name, string Field)
        {
            return dal.GetField(name, Field);
        }
        /// <summary>
        /// ���س���ѯ�������� ����ҳ�õ���
        /// </summary>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
        /// <summary>
        /// ��֤�û�
        /// </summary>
        public bool Exists(string username, string password)
        {
            return dal.Exists(username, password);
        }

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string name)
		{
			return dal.Exists(name);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_user model)
		{
			dal.Update(model);
		}
         /// <summary>
        /// �����û�Ϊ��ͨ�û� ��Ȩ���û�
        /// </summary>
        public void Update(string ugroup_id)
        {
            dal.Update(ugroup_id);
        }
        /// <summary>
        /// �����û�����
        /// </summary>
        public void Update_password(int id, string password)
        {
            dal.Update_password(id, password);
        }
        /// <summary>
        /// �����û����� �����û���
        /// </summary>
        public void Update_password(string user, string password)
        {
            dal.Update_password(user, password);
        }
        /// <summary>
        /// �����û�����xinxi
        /// </summary>
        public void Update_moneys(int id, int money)
        {
            Update_moneys(id, money);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int bh)
		{
			
			dal.Delete(bh);
		}
         /// <summary>
        /// ɾ������
        /// </summary>
        public void Delete(string strWhere)
        {
            dal.Delete(strWhere);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_user GetModel(int bh)
		{
			
			return dal.GetModel(bh);
		}

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_user GetModel(string username)
        {

            return dal.GetModel(username);
        }
        /// <summary>
        /// �����ʼ�����û���
        /// </summary>
        public string GetUserName(string email)
        {

            return dal.GetUserName(email);
        }
		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_user GetModelByCache(int bh)
		{
			
			string CacheKey = ROYcms.Sys.DAL.PubConstant.date_prefix + "userModel-" + bh;
			object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(bh);
					if (objModel != null)
					{
						int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
						ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Sys.Model.ROYcms_user)objModel;
		}


		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<ROYcms.Sys.Model.ROYcms_user> modelList = new List<ROYcms.Sys.Model.ROYcms_user>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_user();
					if(ds.Tables[0].Rows[n]["bh"].ToString()!="")
					{
						model.bh=int.Parse(ds.Tables[0].Rows[n]["bh"].ToString());
					}
					model.name=ds.Tables[0].Rows[n]["name"].ToString();
					model.password=ds.Tables[0].Rows[n]["password"].ToString();
					if(ds.Tables[0].Rows[n]["money"].ToString()!="")
					{
						model.money=int.Parse(ds.Tables[0].Rows[n]["money"].ToString());
					}
					model.qq=ds.Tables[0].Rows[n]["qq"].ToString();
					model.email=ds.Tables[0].Rows[n]["email"].ToString();
					if(ds.Tables[0].Rows[n]["age"].ToString()!="")
					{
						model.age=int.Parse(ds.Tables[0].Rows[n]["age"].ToString());
					}
					if(ds.Tables[0].Rows[n]["login_time"].ToString()!="")
					{
						model.login_time=DateTime.Parse(ds.Tables[0].Rows[n]["login_time"].ToString());
					}
					model.sex=ds.Tables[0].Rows[n]["sex"].ToString();
					model.pic=ds.Tables[0].Rows[n]["pic"].ToString();
					model.quanxian=ds.Tables[0].Rows[n]["quanxian"].ToString();
					model.username=ds.Tables[0].Rows[n]["username"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  ��Ա����
	}
}


using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Blog.Model;
namespace ROYcms.Blog.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_Blog_user ��ժҪ˵����
	/// </summary>
	public class ROYcms_Blog_user
	{
		private readonly ROYcms.Blog.DAL.ROYcms_Blog_user dal=new ROYcms.Blog.DAL.ROYcms_Blog_user();
		public ROYcms_Blog_user()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
        /// <summary>
        /// �Ƿ���ڸü�¼ �Ƿ���ڸü�¼ �����û�ID user_id
        /// </summary>
        public bool Exists(string user_id)
        {
            return dal.Exists(user_id);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ROYcms.Blog.Model.ROYcms_Blog_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(ROYcms.Blog.Model.ROYcms_Blog_user model)
		{
			dal.Update(model);
		}
        /// <summary>
        /// ����һ������ ���� user_id ����
        /// </summary>
        public void Update_user_id(ROYcms.Blog.Model.ROYcms_Blog_user model)
        {
            dal.Update_user_id(model);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int id)
		{
			
			dal.Delete(id);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Blog.Model.ROYcms_Blog_user GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public ROYcms.Blog.Model.ROYcms_Blog_user GetModelByCache(int id)
		{
			
			string CacheKey = "ROYcms_Blog_userModel-" + id;
			object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
						ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Blog.Model.ROYcms_Blog_user)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Blog.Model.ROYcms_Blog_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Blog.Model.ROYcms_Blog_user> DataTableToList(DataTable dt)
		{
			List<ROYcms.Blog.Model.ROYcms_Blog_user> modelList = new List<ROYcms.Blog.Model.ROYcms_Blog_user>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Blog.Model.ROYcms_Blog_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Blog.Model.ROYcms_Blog_user();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["user_id"].ToString()!="")
					{
						model.user_id=int.Parse(dt.Rows[n]["user_id"].ToString());
					}
					model.BlogTitle=dt.Rows[n]["BlogTitle"].ToString();
					model.Keyword=dt.Rows[n]["Keyword"].ToString();
					model.Description=dt.Rows[n]["Description"].ToString();
					if(dt.Rows[n]["Time"].ToString()!="")
					{
						model.Time=DateTime.Parse(dt.Rows[n]["Time"].ToString());
					}
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
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}


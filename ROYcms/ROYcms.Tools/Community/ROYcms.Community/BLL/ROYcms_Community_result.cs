using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Community.Model;
namespace ROYcms.Community.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_Community_result ��ժҪ˵����
	/// </summary>
	public class ROYcms_Community_result
	{
		private readonly ROYcms.Community.DAL.ROYcms_Community_result dal=new ROYcms.Community.DAL.ROYcms_Community_result();
		public ROYcms_Community_result()
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
		public bool Exists(int bh)
		{
			return dal.Exists(bh);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ROYcms.Community.Model.ROYcms_Community_result model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(ROYcms.Community.Model.ROYcms_Community_result model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int bh)
		{
			
			dal.Delete(bh);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Community.Model.ROYcms_Community_result GetModel(int bh)
		{
			
			return dal.GetModel(bh);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public ROYcms.Community.Model.ROYcms_Community_result GetModelByCache(int bh)
		{
			
			string CacheKey = "ROYcms_Community_resultModel-" + bh;
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
			return (ROYcms.Community.Model.ROYcms_Community_result)objModel;
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
		public List<ROYcms.Community.Model.ROYcms_Community_result> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Community.Model.ROYcms_Community_result> DataTableToList(DataTable dt)
		{
			List<ROYcms.Community.Model.ROYcms_Community_result> modelList = new List<ROYcms.Community.Model.ROYcms_Community_result>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Community.Model.ROYcms_Community_result model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Community.Model.ROYcms_Community_result();
					if(dt.Rows[n]["bh"].ToString()!="")
					{
						model.bh=int.Parse(dt.Rows[n]["bh"].ToString());
					}
					if(dt.Rows[n]["Community_id"].ToString()!="")
					{
						model.Community_id=int.Parse(dt.Rows[n]["Community_id"].ToString());
					}
					model.title=dt.Rows[n]["title"].ToString();
					model.content=dt.Rows[n]["content"].ToString();
					model.user_id=dt.Rows[n]["user_id"].ToString();
					model.ip=dt.Rows[n]["ip"].ToString();
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


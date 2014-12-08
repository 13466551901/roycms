using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using ROYcms.Sys.DAL;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_CaiRss ��ժҪ˵����
	/// </summary>
	public class ROYcms_CaiRss
	{
		private readonly ROYcms.Sys.DAL.ROYcms_CaiRss dal=new ROYcms.Sys.DAL.ROYcms_CaiRss();
		public ROYcms_CaiRss()
		{}
		#region  ��Ա����


        /// <summary>
        /// ���س���ѯ�������� ����ҳ�õ���
        /// </summary>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
          /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(string RssUrl)
        {
            return dal.Exists(RssUrl);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_CaiRss model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_CaiRss model)
		{
			dal.Update(model);
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
		public ROYcms.Sys.Model.ROYcms_CaiRss GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_CaiRss GetModelByCache(int id)
		{
			
			string CacheKey = PubConstant.date_prefix + "CaiRssModel-" + id;
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
			return (ROYcms.Sys.Model.ROYcms_CaiRss)objModel;
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
        //public DataSet GetList(int Top,string strWhere,string filedOrder)
        //{
        //    return dal.GetList(Top,strWhere,filedOrder);
        //}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_CaiRss> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_CaiRss> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_CaiRss> modelList = new List<ROYcms.Sys.Model.ROYcms_CaiRss>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_CaiRss model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_CaiRss();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					model.RssUrl=dt.Rows[n]["RssUrl"].ToString();
					model.Encode=dt.Rows[n]["Encode"].ToString();
					model.HtmlStar=dt.Rows[n]["HtmlStar"].ToString();
					model.HtmlEnd=dt.Rows[n]["HtmlEnd"].ToString();
					model.Path=dt.Rows[n]["Path"].ToString();
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
        /// ��ȡ��¼����
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
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


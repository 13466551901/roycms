using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
    /// ҵ���߼���ROYcms_Class_UGroup��ժҪ˵����
	/// </summary>
	public class ROYcms_Class_UGroup
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Class_UGroup dal=new ROYcms.Sys.DAL.ROYcms_Class_UGroup();
        public ROYcms_Class_UGroup()
		{}
        #region  ��Ա����
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Class_UGroup model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_Class_UGroup model)
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
        public ROYcms.Sys.Model.ROYcms_Class_UGroup GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// �õ�һ������ʵ�壬�ӻ����С�
        /// </summary>
        //public ROYcms.Sys.Model.ROYcms_Class_UGroup GetModelByCache(int id)
        //{

        //    string CacheKey = PubConstant.date_prefix + "Class_UGroupModel-" + id;
        //    object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (ROYcms.Sys.Model.ROYcms_Class_UGroup)objModel;
        //}

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
        public DataSet GetList(int id)
        {
            return dal.GetList(" id="+id);
        }
        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Class_UGroup> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Class_UGroup> DataTableToList(DataTable dt)
        {
            List<ROYcms.Sys.Model.ROYcms_Class_UGroup> modelList = new List<ROYcms.Sys.Model.ROYcms_Class_UGroup>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_Class_UGroup model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_Class_UGroup();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["Class_id"].ToString() != "")
                    {
                        model.Class_id = int.Parse(dt.Rows[n]["Class_id"].ToString());
                    }
                    if (dt.Rows[n]["UGroup_id"].ToString() != "")
                    {
                        model.UGroup_id = int.Parse(dt.Rows[n]["UGroup_id"].ToString());
                    }
                    if (dt.Rows[n]["User_id"].ToString() != "")
                    {
                        model.User_id = int.Parse(dt.Rows[n]["User_id"].ToString());
                    }
                    if (dt.Rows[n]["Time"].ToString() != "")
                    {
                        model.Time = DateTime.Parse(dt.Rows[n]["Time"].ToString());
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


using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_template ��ժҪ˵����
	/// </summary>
	public class ROYcms_template
	{
        private readonly ROYcms.Sys.DAL.ROYcms_template dal = new ROYcms.Sys.DAL.ROYcms_template();
        public ROYcms_template()
        { }
        #region  ��Ա����
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int bh)
        {
            return dal.Exists(bh);
        }
        /// <summary>
        /// �Ƿ����del��¼
        /// </summary>
        public int Exists()
        {
            return dal.del_Exists();
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_template model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_template model)
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
        public ROYcms.Sys.Model.ROYcms_template GetModel(int bh)
        {

            return dal.GetModel(bh);
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
        public List<ROYcms.Sys.Model.ROYcms_template> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<ROYcms.Sys.Model.ROYcms_template> modelList = new List<ROYcms.Sys.Model.ROYcms_template>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                ROYcms.Sys.Model.ROYcms_template model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ROYcms.Sys.Model.ROYcms_template();
                    if (ds.Tables[0].Rows[n]["bh"].ToString() != "")
                    {
                        model.bh = int.Parse(ds.Tables[0].Rows[n]["bh"].ToString());
                    }
                    model.name = ds.Tables[0].Rows[n]["name"].ToString();
                    model.tag = ds.Tables[0].Rows[n]["tag"].ToString();
                    model.htmlcontent = ds.Tables[0].Rows[n]["htmlcontent"].ToString();
                    if (ds.Tables[0].Rows[n]["htmltimes"].ToString() != "")
                    {
                        model.htmltimes = DateTime.Parse(ds.Tables[0].Rows[n]["htmltimes"].ToString());
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


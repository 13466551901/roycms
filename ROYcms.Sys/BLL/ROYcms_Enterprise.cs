using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_Enterprise ��ժҪ˵����
	/// </summary>
	public class ROYcms_Enterprise
	{
        private readonly ROYcms.Sys.DAL.ROYcms_Enterprise dal = new ROYcms.Sys.DAL.ROYcms_Enterprise();
		public ROYcms_Enterprise()
		{}
		#region  ��Ա����

        /// <summary>
        /// �޸�һ�������Ƿ��Ƽ�
        /// </summary>
        public void Tuijian_Enterprise(int bh)
        {
            dal.Tuijian_Enterprise(bh);

        }
        /// <summary>
        /// �޸�һ������ �� ���ƿ��� �޸�switchs Ϊ1
        /// </summary>
        public void on_Enterprise(int bh)
        {
            dal.on_Enterprise(bh);

        }
        /// <summary>
        /// ���س���ѯ�������� ����ҳ�õ���
        /// </summary>
        public int GetCount(string strWhere)
        {
           return dal.GetCount(strWhere);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Enterprise model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_Enterprise model)
		{
			dal.Update(model);
		}
        /// <summary>
        /// ����һ������
        /// </summary>
        public void _Update(ROYcms.Sys.Model.ROYcms_Enterprise model)
        {
            dal._Update(model);
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
        public ROYcms.Sys.Model.ROYcms_Enterprise GetModel(int bh)
		{
			
			return dal.GetModel(bh);
		}
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Enterprise _GetModel(int user_id)
        {

            return dal._GetModel(user_id);
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
        public List<ROYcms.Sys.Model.ROYcms_Enterprise> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
        public List<ROYcms.Sys.Model.ROYcms_Enterprise> DataTableToList(DataTable dt)
		{
            List<ROYcms.Sys.Model.ROYcms_Enterprise> modelList = new List<ROYcms.Sys.Model.ROYcms_Enterprise>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                ROYcms.Sys.Model.ROYcms_Enterprise model;
				for (int n = 0; n < rowsCount; n++)
				{
                    model = new ROYcms.Sys.Model.ROYcms_Enterprise();
					if(dt.Rows[n]["bh"].ToString()!="")
					{
						model.bh=int.Parse(dt.Rows[n]["bh"].ToString());
					}
					if(dt.Rows[n]["user_id"].ToString()!="")
					{
						model.user_id=int.Parse(dt.Rows[n]["user_id"].ToString());
					}
					model.introduces=dt.Rows[n]["introduces"].ToString();
					model.business_scope=dt.Rows[n]["business_scope"].ToString();
					model.intelligence_honor=dt.Rows[n]["intelligence_honor"].ToString();
					model.contacts_us=dt.Rows[n]["contacts_us"].ToString();
					model.enterprise_culture=dt.Rows[n]["enterprise_culture"].ToString();
					model.marketing_network=dt.Rows[n]["marketing_network"].ToString();
					model.other_1=dt.Rows[n]["other_1"].ToString();
					model.other_2=dt.Rows[n]["other_2"].ToString();
					model.other_3=dt.Rows[n]["other_3"].ToString();
					model.other_4=dt.Rows[n]["other_4"].ToString();
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


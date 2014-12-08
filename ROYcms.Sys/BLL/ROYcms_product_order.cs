using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ROYcms_product_order
	/// </summary>
	public partial class ROYcms_product_order
	{
        private readonly ROYcms.Sys.DAL.ROYcms_product_order dal = new ROYcms.Sys.DAL.ROYcms_product_order();
		public ROYcms_product_order()
		{}
		#region  Method
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
		public int  Add(ROYcms.Sys.Model.ROYcms_product_order model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_product_order model)
		{
			return dal.Update(model);
		}
        /// <summary>
        /// ��ȡ ����ֵ  �����ֶ� ͨ��������
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(string Id, string Field)
        {
           return GetField(Id, Field);
        }
     
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int id)
		{
			dal.Delete(id);
		}
        /// <summary>
        ///  �޸Ķ���״̬
        /// </summary>
        public void order_status(string order_id, string order_status)
        {
            dal.order_status(order_id, order_status);
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
        /// ���س���ѯ�������� ����ҳ�õ���
        /// </summary>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        /// <summary>
        /// �޸Ķ���״̬
        /// </summary>
        public void GetRecordCount(string order_id, string order_status)
        {
             dal.order_status(order_id, order_status);
        }
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(int PageSize, int PageIndex, string strWhere, int OrderType)
		{
            return dal.GetList(PageSize, PageIndex, strWhere, OrderType);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  Method
	}
}


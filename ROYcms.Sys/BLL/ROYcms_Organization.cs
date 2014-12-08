using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_Organization ��ժҪ˵����
	/// </summary>
	public class ROYcms_Organization
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Organization dal=new ROYcms.Sys.DAL.ROYcms_Organization();
		public ROYcms_Organization()
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
        /// �Ƿ���ڸü�¼ ��ѯ���� USERID
        /// </summary>
        public bool U_Exists(int userid)
        {
            return dal.U_Exists(userid);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Organization model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_Organization model)
		{
			dal.Update(model);
		}
        /// <summary>
        /// ����һ������ ���� userid
        /// </summary>
        public void U_Update(ROYcms.Sys.Model.ROYcms_Organization model)
        {
            dal.U_Update(model);
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
		public ROYcms.Sys.Model.ROYcms_Organization GetModel(int id)
		{
			
			return dal.GetModel(id);
		}
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Organization U_GetModel(int userid)
        {

            return dal.U_GetModel(userid);
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
		public List<ROYcms.Sys.Model.ROYcms_Organization> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Organization> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Organization> modelList = new List<ROYcms.Sys.Model.ROYcms_Organization>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Organization model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Organization();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["userID"].ToString()!="")
					{
						model.userID=int.Parse(dt.Rows[n]["userID"].ToString());
					}
					model.name=dt.Rows[n]["name"].ToString();
					if(dt.Rows[n]["classname"].ToString()!="")
					{
						model.classname=int.Parse(dt.Rows[n]["classname"].ToString());
					}
					model.keyword=dt.Rows[n]["keyword"].ToString();
					model.zhaiyao=dt.Rows[n]["zhaiyao"].ToString();
					model.contents=dt.Rows[n]["contents"].ToString();
					model.tag=dt.Rows[n]["tag"].ToString();
					if(dt.Rows[n]["hits"].ToString()!="")
					{
						model.hits=int.Parse(dt.Rows[n]["hits"].ToString());
					}
					if(dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
					}
					if(dt.Rows[n]["tuijian"].ToString()!="")
					{
						model.tuijian=int.Parse(dt.Rows[n]["tuijian"].ToString());
					}
					if(dt.Rows[n]["switchs"].ToString()!="")
					{
						model.switchs=int.Parse(dt.Rows[n]["switchs"].ToString());
					}
					model.type=dt.Rows[n]["type"].ToString();
					model.Time=dt.Rows[n]["Time"].ToString();
					model.GUID=dt.Rows[n]["GUID"].ToString();
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


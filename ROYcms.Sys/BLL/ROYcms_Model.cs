using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ����ģ�ͱ� ROYc
	/// </summary>
	public partial class ROYcms_Model
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Model dal=new ROYcms.Sys.DAL.ROYcms_Model();
		public ROYcms_Model()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Model model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Id)
		{
            new BLL.ROYcms_Field().MidDelete(Id); //����ɾ�����е�ģ���µ������ֶ�

            if (GetTableName(Id) != null) { if (new BLL.CMS().Exists(GetTableName(Id))) { new BLL.CMS().DelTable(GetTableName(Id)); } } //����ɾ�����

            new BLL.ROYcms_Class_Model().MidDelete(Id);   //����ɾ�������ķ���Ĺ�ϵ�� Model_Class

			return dal.Delete(Id);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}
        /// <summary>
        /// �õ��������
        /// </summary>
        public string GetTableName(int Id)
        {
            if (dal.GetModel(Id) != null) { return dal.GetModel(Id).TableName; }
            else { return null; }
            
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Model GetModel(int Id)
		{
			
			return dal.GetModel(Id);
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
		public List<ROYcms.Sys.Model.ROYcms_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Model> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Model> modelList = new List<ROYcms.Sys.Model.ROYcms_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Model();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["ModelType"]!=null && dt.Rows[n]["ModelType"].ToString()!="")
					{
						model.ModelType=int.Parse(dt.Rows[n]["ModelType"].ToString());
					}
					if(dt.Rows[n]["Name"]!=null && dt.Rows[n]["Name"].ToString()!="")
					{
					model.Name=dt.Rows[n]["Name"].ToString();
					}
					if(dt.Rows[n]["TableName"]!=null && dt.Rows[n]["TableName"].ToString()!="")
					{
					model.TableName=dt.Rows[n]["TableName"].ToString();
					}
					if(dt.Rows[n]["ModelDescription"]!=null && dt.Rows[n]["ModelDescription"].ToString()!="")
					{
					model.ModelDescription=dt.Rows[n]["ModelDescription"].ToString();
					}
					if(dt.Rows[n]["TIME"]!=null && dt.Rows[n]["TIME"].ToString()!="")
					{
						model.TIME=DateTime.Parse(dt.Rows[n]["TIME"].ToString());
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
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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


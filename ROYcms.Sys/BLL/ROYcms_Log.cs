using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
using System.Web;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ROYcms_Log
	/// </summary>
	public partial class ROYcms_Log
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Log dal=new ROYcms.Sys.DAL.ROYcms_Log();
		public ROYcms_Log()
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
		public bool Add(ROYcms.Sys.Model.ROYcms_Log model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Log model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Log GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        /// <summary>
        /// ��־д��
        /// </summary>
        /// <param name="Err_id">��ʶ 1����Ա��¼ 2��ͨ��Ա��¼ 3����Ա������־ 4��ͨ��Ա������־ 5������־ </param>
        /// <param name="Event">��־�¼�����</param>
        /// <param name="Content">��־����</param>
        public void InsertSystemLog(string Err_id, string Event, string Content)
        {
            ROYcms.Sys.Model.ROYcms_Log model = new Model.ROYcms_Log();
            try
            {
                model.Err_id = Err_id;
                model.Event = Event;
                model.Content = Content + "[" + HttpContext.Current.Request.Url.ToString() + "]";
                if (ROYcms.Common.Session.Get("administrator_id") != null)
                {
                    model.Admin_id = Convert.ToInt32(ROYcms.Common.Session.Get("administrator_id"));
                }
                if (ROYcms.Common.Session.Get("user_id") != null)
                {
                    model.User_id = Convert.ToInt32(ROYcms.Common.Session.Get("user_id"));
                }
                model.Ip = ROYcms.Common.SystemCms.GetClientIPv4(); //IP��ַ
                model.Time = DateTime.Now;
                dal.Add(model);
            }
            catch
            {
                ROYcms.Common.SystemCms.InsertErrLog("д�������־ʧ��", HttpContext.Current.Request.Url.ToString());
            }
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
		public List<ROYcms.Sys.Model.ROYcms_Log> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Log> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Log> modelList = new List<ROYcms.Sys.Model.ROYcms_Log>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Log model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Log();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["User_id"]!=null && dt.Rows[n]["User_id"].ToString()!="")
					{
						model.User_id=int.Parse(dt.Rows[n]["User_id"].ToString());
					}
					if(dt.Rows[n]["Admin_id"]!=null && dt.Rows[n]["Admin_id"].ToString()!="")
					{
						model.Admin_id=int.Parse(dt.Rows[n]["Admin_id"].ToString());
					}
					if(dt.Rows[n]["Err_id"]!=null && dt.Rows[n]["Err_id"].ToString()!="")
					{
					model.Err_id=dt.Rows[n]["Err_id"].ToString();
					}
					if(dt.Rows[n]["Event"]!=null && dt.Rows[n]["Event"].ToString()!="")
					{
					model.Event=dt.Rows[n]["Event"].ToString();
					}
					if(dt.Rows[n]["Content"]!=null && dt.Rows[n]["Content"].ToString()!="")
					{
					model.Content=dt.Rows[n]["Content"].ToString();
					}
					if(dt.Rows[n]["Time"]!=null && dt.Rows[n]["Time"].ToString()!="")
					{
						model.Time=DateTime.Parse(dt.Rows[n]["Time"].ToString());
					}
					if(dt.Rows[n]["Ip"]!=null && dt.Rows[n]["Ip"].ToString()!="")
					{
					model.Ip=dt.Rows[n]["Ip"].ToString();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetCount(string where)
        {
            return dal.GetCount(where);
        }
    }
}


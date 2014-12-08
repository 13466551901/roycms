using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
    /// ���ݷ�����ROYcms_Custom
	/// </summary>
	public class ROYcms_Custom
	{
         private readonly ROYcms.Sys.DAL.ROYcms_Custom dal = new ROYcms.Sys.DAL.ROYcms_Custom();
        /// <summary>
        /// ��Ա����
        /// </summary>
        public ROYcms_Custom()
		{}
        #region  ��Ա����


        public ROYcms.Sys.Model.ROYcms_Custom SetVal(System.Web.UI.Page page,int Id,int Cid)
        {
            //ѭ���õ����������� 
           return dal.SetVal(page,Id,Cid);
        }
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int Id, string TableName)
        {
            return dal.Exists(Id, TableName);
        }
        /// <summary>
        /// �������ݱ��
        /// </summary>
        /// <param name="TableName">�������</param>
        /// <param name="Tablelist">������ ���ӣ�Id INTEGER,a1 VARCHAR(4000),a2 VARCHAR(4000)</param>
        /// <returns></returns>
        public int CreateTable(string TableName, string Tablelist)
        {
            //�ж����ݿ���Ƿ������� select * from master.dbo.sysdatabases where name='����'
            return dal.CreateTable(TableName, Tablelist);
        }
        /// <summary>
        /// �������ݱ��
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int CreateTable(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            //�ж����ݿ���Ƿ������� select * from master.dbo.sysdatabases where name='����'
            return dal.CreateTable(models);
        }
        /// <summary>
        /// ��������Լ��
        /// </summary>
        /// <param name="TableName">�������</param>
        /// <param name="Key">�ֶ�</param>
        /// <returns>������Ӱ�����</returns>
        public int Key(string TableName, string Key)
        {
            return dal.Key(TableName, Key);
        }
        /// <summary>
        ///  ����һ������
        /// </summary>
        /// <param name="TableName"> ������ </param>
        /// <param name="Tlist">�ֶ�˳�� ���磺a1,a2</param>
        /// <param name="InsertList">ֵ˳�� ���磺var1,var2</param>
        /// <returns></returns>
        public int Add(string TableName,string Tlist, string InsertList)
        {
           return dal.Add( TableName,Tlist, InsertList);
        }
        /// <summary>
        /// ����һ���ֶ�
        /// </summary>
        /// <param name="Id">����ID</param>
        /// <param name="Cid">����ID</param>
        /// <param name="Name">�ֶ�����</param>
        /// <returns></returns>
        public string GetVal(int Id, int Cid, string Name)
        {
            return dal.GetVal(Id, Cid, Name);
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�����ֶ�����
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetTableList(int Cid) 
        {
            return dal.GetTableList(Cid,"Name");
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�����ֶ�����
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetInputTypeList(int Cid)
        {
            return dal.GetTableList(Cid, "InputType");
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�����ֶ�IsNull
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetIsNullList(int Cid)
        {
            return dal.GetTableList(Cid, "IsNull");
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�����ֶ�Len
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetLenList(int Cid)
        {
            return dal.GetTableList(Cid, "Len");
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�����ֶ�FieldType
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetFieldTypeList(int Cid)
        {
            return dal.GetTableList(Cid, "FieldType");
        }
        /// <summary>
        /// ���ݷ���Cid ����ID�������ܹ�����ı���
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string GetTableName(int Cid)
        {
            return dal.GetTableName(Cid);
        }
        /// <summary>
        ///  ����һ�����ݸ��ݱ��ṹ
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Add(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            return dal.Add(models);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="id">��������������������ID </param>
        /// <param name="UpdateList">���¸�ʽ���� a1=11,a2=22,a3=33 </param>
        /// <param name="TableName"> ������ </param>
        public int Update(int id, string UpdateList, string TableName)
        {
            return dal.Update(id, UpdateList, TableName);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Update(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            return dal.Update(models);
        }

        #endregion  ��Ա����
	}
}


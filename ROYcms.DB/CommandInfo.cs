

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ROYcms.DB
{
    /// <summary>
    /// 
    /// </summary>
    public enum EffentNextType
    {
        /// <summary>
        /// ������������κ�Ӱ�� 
        /// </summary>
        None,
        /// <summary>
        /// ��ǰ������Ϊ"select count(1) from .."��ʽ��������������ִ�У������ڻع�����
        /// </summary>
        WhenHaveContine,
        /// <summary>
        /// ��ǰ������Ϊ"select count(1) from .."��ʽ����������������ִ�У����ڻع�����
        /// </summary>
        WhenNoHaveContine,
        /// <summary>
        /// ��ǰ���Ӱ�쵽�������������0������ع�����
        /// </summary>
        ExcuteEffectRows,
        /// <summary>
        /// �����¼�-��ǰ������Ϊ"select count(1) from .."��ʽ����������������ִ�У����ڻع�����
        /// </summary>
        SolicitationEvent
    }   
    /// <summary>
    /// 
    /// </summary>
    public class CommandInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public object ShareObject = null;
        /// <summary>
        /// 
        /// </summary>
        public object OriginalData = null;
        /// <summary>
        /// 
        /// </summary>
        event EventHandler _solicitationEvent;
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler SolicitationEvent
        {
            add
            {
                _solicitationEvent += value;
            }
            remove
            {
                _solicitationEvent -= value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void OnSolicitationEvent()
        {
            if (_solicitationEvent != null)
            {
                _solicitationEvent(this,new EventArgs());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CommandText;
        /// <summary>
        /// 
        /// </summary>
        public System.Data.Common.DbParameter[] Parameters;
        /// <summary>
        /// 
        /// </summary>
        public EffentNextType EffentNextType = EffentNextType.None;
        /// <summary>
        /// 
        /// </summary>
        public CommandInfo()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="para"></param>
        public CommandInfo(string sqlText, SqlParameter[] para)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="para"></param>
        /// <param name="type"></param>
        public CommandInfo(string sqlText, SqlParameter[] para, EffentNextType type)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
            this.EffentNextType = type;
        }
    }
}

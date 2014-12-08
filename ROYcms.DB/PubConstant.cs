using System;
using System.Configuration;

namespace ROYcms.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class PubConstant
    {        
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {  
                string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                _connectionString = DESEncrypt.Decrypt(_connectionString);
        
                return _connectionString; 
            }
        } 
        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];

            connectionString = DESEncrypt.Decrypt(connectionString);
          
            return connectionString;
        }


    }
}

using Microsoft.Extensions.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace NiuNiu.DAL
{

    /// <summary>
    /// SqlSugarClient帮助类
    /// ** 创始时间：2018-11-02
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public static class SqlSugarClientHelper
    {
        //加载appsetting.json
        static IConfiguration configuration = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json").Build();



        /// <summary>
        ///连接字符串
        /// </summary>
        private static readonly string conn = configuration["SqlConn:MySqlConn"];
        public static SqlSugarClient SqlDBConnection
        {
            get => new SqlSugarClient(new ConnectionConfig()

            {
                ConnectionString = conn,//必填, 数据库连接字符串
                DbType = SqlSugar.DbType.SqlServer,         //必填, 数据库类型
                IsAutoCloseConnection = true,       //默认false, 不自动关闭数据库连接。设置为true无需使用using或者Close操作，自动释放。
                InitKeyType = InitKeyType.SystemTable    //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息

            });
        }
    }
}

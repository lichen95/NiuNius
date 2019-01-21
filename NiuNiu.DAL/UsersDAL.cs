using System;
using System.Collections.Generic;
using System.Text;

namespace NiuNiu.DAL
{
    using IDAL;
    using Entity;
    using SqlSugar;
    using Common;

    /// <summary>
    /// ** 描述：用户DAL层
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public class UsersDAL : IUsersDAL
    {

        SqlSugarClient sugar;
        public UsersDAL()
        {
            if (sugar == null)
                sugar= SqlSugarClientHelper.SqlDBConnection;
        }
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Add(Users t)
        {
            try
            {
                 return sugar.Insertable<Users>(t).ExecuteCommand() > 0;
            }
            catch (Exception ex)
            {
                ErrorLog.WriteLog(ex);
                return false;
            }  
        }

        public bool Delete(string Ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        public Users Login(string Name, string Pwd)
        {
            try
            {
                using (SqlSugarClient sugar = SqlSugarClientHelper.SqlDBConnection)
                {
                    return sugar.Queryable<Users>().First(m=>m.UserName.Equals(Name)&&m.Pwd.Equals(Pwd))??null;
                }
            }
            catch (Exception ex)
            {
                ErrorLog.WriteLog(ex);
                return null;
            }
        }

        public List<Users> Query()
        {
            throw new NotImplementedException();
        }

        public Users QueryById(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Update(Users t)
        {
            try
            {
                using (SqlSugarClient sugar = SqlSugarClientHelper.SqlDBConnection)
                {
                    return sugar.Updateable<Users>(t).ExecuteCommand() > 0;
                }
            }
            catch (Exception ex)
            {
                ErrorLog.WriteLog(ex);
                return false;
            }
        }
    }
}

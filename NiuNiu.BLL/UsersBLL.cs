using System;

namespace NiuNiu.BLL
{
    using IDAL;
    using IBLL;
    using Entity;
    using System.Collections.Generic;

    /// <summary>
    /// ** 描述：用户DAL层
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public class UsersBLL : IUsersBLL
    {
        private IUsersDAL iUsersDAL;
        public UsersBLL(IUsersDAL _iUsersDAL)
        {
            iUsersDAL = _iUsersDAL;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Add(Users t)
        {
            var result = iUsersDAL.Add(t);
            return result;
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
            var result = iUsersDAL.Login(Name, Pwd);
            return result;
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
            var result = iUsersDAL.Update(t);
            return result;
        }
    }
}

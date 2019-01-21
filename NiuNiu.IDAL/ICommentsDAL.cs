using System;
using System.Collections.Generic;
using System.Text;

namespace NiuNiu.IDAL
{
    using Entity;
    /// <summary>
    /// ** 描述：评论DAL接口
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public interface ICommentsDAL : IBase<Comments>
    {
        /// <summary>
        /// 获取评论信息
        /// </summary>
        /// <returns></returns>
        List<Comments> Query();
    }
}

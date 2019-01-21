using System;
using System.Collections.Generic;

namespace NiuNiu.IBLL
{
    using Entity;
    /// <summary>
    /// ** 描述：博客BLL接口
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public interface IBlogsBLL : IBase<Blogs>
    {
        /// <summary>
        /// 获取博客信息
        /// </summary>
        /// <returns></returns>
        List<Blogs> Query();
    }
}

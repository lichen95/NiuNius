using System;
using System.Collections.Generic;
using System.Text;

namespace NiuNiu.IDAL
{
    using Entity;
    /// <summary>
    /// ** 描述：博客类型DAL接口
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public interface IBlogTypesDAL:IBase<BlogTypes>
    {
        /// <summary>
        /// 获取博客类型信息
        /// </summary>
        /// <returns></returns>
        List<BlogTypes> Query();
    }
}

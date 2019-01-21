using System;

namespace NiuNiu.Entity
{
    using System.ComponentModel.DataAnnotations;
    /// <summary>
    /// ** 描述：博客类型表
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public partial class BlogTypes
    {
           public BlogTypes(){


           }
           /// <summary>
           /// Desc:类型ID
           /// Default:
           /// Nullable:False
           /// </summary>    
           [Key]
           public int Id {get;set;}

           /// <summary>
           /// Desc:类型名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

    }
}

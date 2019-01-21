using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiuNiu.BlogEntry
{
    using IBLL;
    using BLL;
    using IDAL;
    using DAL;
    public static class DI
    {
        public static void AddScored(this IServiceCollection service)
        {
            //BLL层注入
            service.AddScoped<IUsersBLL, UsersBLL>();
            //DAL层注入
            service.AddScoped<IUsersDAL, UsersDAL>();

        }
    }
}

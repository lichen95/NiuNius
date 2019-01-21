using Microsoft.Extensions.DependencyInjection;

namespace NiuNiu.BlogEntry
{
    using BLL;
    using DAL;
    using IBLL;
    using IDAL;

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

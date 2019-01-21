
namespace NiuNiu.BlogEntry.Content
{
    using Microsoft.AspNetCore.Http;
    public static class HttpContext
    {
        private static IHttpContextAccessor _accessor;

        public static Microsoft.AspNetCore.Http.HttpContext Current => _accessor.HttpContext;

        internal static void Configure(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NiuNiu.BlogEntry.Controllers
{
    using IBLL;
    using Newtonsoft.Json;
    using Common;
    using Content;
    using System.Web;

    public class UsersController : Controller
    {
        private IUsersBLL iUsersBLL;
        public UsersController(IUsersBLL _iUsersBLL)
        {
            iUsersBLL = _iUsersBLL;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        [HttpPost]
        public bool Login(string Name,string Pwd)
        {
            Pwd = Md5Helper.MD5Encoding(Pwd,"123");
            var result = iUsersBLL.Login(Name,Pwd);
            if (result != null)
            {
                CookieHelper.SetCookies("User", HttpUtility.UrlEncode(JsonConvert.SerializeObject(result)));
                var aa = HttpUtility.UrlDecode(CookieHelper.GetCookies("User"));
                return true;
            }
            return false;
        }
    }
}
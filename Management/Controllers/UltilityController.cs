using DisplayMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace DisplayMonkey.Controllers
{
    public class UltilityController : BaseController
    {
        public ActionResult ChangeLanguage(string language)
        {
            var result = new JsonResult();
            result.Data = new
            {
                status = "Success"
            };

            CultureHelpers.SetCurrentCulture(language);       // locale
            CultureHelpers.SetCurrentUICulture(language);   // resource manager

            HttpCookie cookie = new HttpCookie("accept-language", language);
            Response.Cookies.Add(cookie);

            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}

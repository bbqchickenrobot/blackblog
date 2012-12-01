using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public string Post(int id)
        {
            return HttpUtility.HtmlEncode("Post number: " + id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BlackBlog.Models;

namespace BlackBlog.Controllers
{
    public class ArchivesController : Controller
    {
        BlackBlogEntities db = new BlackBlogEntities();
        //
        // GET: /Archives/

        public ActionResult Index()
        {

            var posts = db.Posts.ToList().OrderByDescending(p => p.DatePublish);

            return View(posts);
        }

    }
}

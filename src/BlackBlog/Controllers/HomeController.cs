using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BlackBlog.Models;

namespace BlackBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var post = new Post
            {
                Title = "Testing Title",
                Author = "Kestrel Blackmore",
                Body = "This is the body of the message",
                DateCreated = DateTime.Now
            }; 

            return View(post);
        }

        public string Post(int id)
        {
            return HttpUtility.HtmlEncode("Post number: " + id);
        }

    }
}

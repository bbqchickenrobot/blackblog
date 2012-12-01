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
        //
        // GET: /Archives/

        public ActionResult Index()
        {
            var posts = new  List<Post> 
            { 
                new Post {
                            Title = "How to be an elite haxor whilst raising 3 kids",
                            DateCreated = DateTime.Now
                          },
                new Post {
                            Title = "Be Legendary or Die Trying!",
                            DateCreated = DateTime.Now.AddDays(-3)
                          },
            };

            return View(posts);
        }

    }
}

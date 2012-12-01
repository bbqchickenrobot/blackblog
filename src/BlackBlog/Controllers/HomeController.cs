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
        BlackBlogEntities db = new BlackBlogEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {

            var postpaging = new PostPaging();

            postpaging.CurrentPost = (from rec in db.Posts
                                      orderby rec.DatePublish descending
                                      select rec).Skip(1).First();

            try
            {
                postpaging.PreviousPost = (from rec in db.Posts
                                           where rec.PostId < postpaging.CurrentPost.PostId
                                           orderby rec.DatePublish descending
                                           select rec).Take(1).First();

                postpaging.NextPost = (from rec in db.Posts
                                           where rec.PostId > postpaging.CurrentPost.PostId
                                           orderby rec.DatePublish descending
                                           select rec).Take(1).First();
            
            }
            catch (InvalidOperationException)
            {
                   // ignore for now 
            }
            
            
            return View(postpaging);
        }

        public string Post(int id)
        {
            return HttpUtility.HtmlEncode("Post number: " + id);
        }

    }
}

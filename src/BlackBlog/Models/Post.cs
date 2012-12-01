using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackBlog.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
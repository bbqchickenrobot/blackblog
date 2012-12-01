using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackBlog.Models
{
    public class PostPaging
    {
        public Post PreviousPost { get; set; }
        public Post CurrentPost { get; set; }
        public Post NextPost { get; set; }
    }
}